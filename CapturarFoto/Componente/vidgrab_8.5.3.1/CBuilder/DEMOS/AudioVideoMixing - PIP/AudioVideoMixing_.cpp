//---------------------------------------------------------------------------
#include <vcl.h>
#pragma hdrstop

#include "AudioVideoMixing_.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "VidGrab"
#pragma resource "*.dfm"
TForm1 *Form1;
//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
        : TForm(Owner)
{
}
//---------------------------------------------------------------------------

const String OPEN_MEDIA_FILES = "*.mpg;*.mpeg;*.vro;*.avi;*.wav;*.asf;*.wmv;*.vob;*.mp3";
const String OPEN_MEDIA_FILES_EXTENDED = OPEN_MEDIA_FILES + ";*.jpg;*.bmp;*.gif";

void __fastcall AssignListToComboBox (TComboBox* ComboBox, String List, int Index)
{
   ComboBox->Items->Text = List;
   if (ComboBox->Items->Count > 0) {
      ComboBox->ItemIndex = Index;
   }
}

void __fastcall TForm1::FormCreate(TObject *Sender)
{
   FFormClosing = false;

   InitializeCriticalSection (&csOverlay);

   VideoGrabberSrc1->AudioFormat = af_22050_16b_2ch; // you can choose any audio format, but it have to be the same on both components
   VideoGrabberSrc1->RawAudioSampleCapture = true;

   VideoGrabberSrc2->AudioFormat = af_22050_16b_2ch; // you can choose any audio format, but it have to be the same on both components
   VideoGrabberSrc2->RawAudioSampleCapture = true;

   VideoGrabberSrc1->Display_AutoSize = false;
   VideoGrabberSrc1->RecordingInNativeFormat = false;
   VideoGrabberSrc1->AudioDeviceRendering = false;
   VideoGrabberSrc1->AudioRecording = true;

   VideoGrabberSrc2->Display_AutoSize = false;
   VideoGrabberSrc2->AudioDeviceRendering = true;
   VideoGrabberSrc2->PlayerAudioRendering = true;
   VideoGrabberSrc2->PlayerRefreshPausedDisplay = false;

   AssignListToComboBox (cboVideoDevices1, VideoGrabberSrc1->VideoDevices, VideoGrabberSrc1->VideoDevice);
   AssignListToComboBox (cboVideoDevices2, VideoGrabberSrc1->VideoDevices, VideoGrabberSrc1->VideoDevice);
   FPIPBitmap = NULL;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnSrc1StartClick(TObject *Sender)
{
   VideoGrabberSrc1->VideoSource = vs_VideoCaptureDevice;
   VideoGrabberSrc1->StartPreview();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnSrc1StartRecordingClick(TObject *Sender)
{
   VideoGrabberSrc1->VideoSource = vs_VideoCaptureDevice;
   VideoGrabberSrc1->StartRecording();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnSrc1StopClick(TObject *Sender)
{
   VideoGrabberSrc1->Stop();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnSrcPlayRecordingClick(TObject *Sender)
{
   VideoGrabberSrc1->PlayerFileName = VideoGrabberSrc1->Last_Recording_FileName;
   VideoGrabberSrc1->OpenPlayer();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnSrc1PlayLastRecordedClick(TObject *Sender)
{
   VideoGrabberSrc1->PlayerFileName = VideoGrabberSrc1->Last_Recording_FileName;
   VideoGrabberSrc1->OpenPlayer();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnSrc1ReplayClick(TObject *Sender)
{
   VideoGrabberSrc1->PlayerFileName = VideoGrabberSrc1->Last_Clip_Played;
   VideoGrabberSrc1->OpenPlayer();
}

//---------------------------------------------------------------------------
void __fastcall TForm1::btnSrc2StartClick(TObject *Sender)
{
   VideoGrabberSrc2->VideoSource = vs_VideoCaptureDevice;
   VideoGrabberSrc2->StartPreview();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnSrc2StopClick(TObject *Sender)
{
   VideoGrabberSrc2->Stop();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnSrc2ReplayClick(TObject *Sender)
{
   VideoGrabberSrc2->PlayerFileName = VideoGrabberSrc2->Last_Clip_Played;
   VideoGrabberSrc2->OpenPlayer();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnPlayerOpenFileClick(TObject *Sender)
{
   dlgOpen->FileName = OPEN_MEDIA_FILES_EXTENDED;
   if (dlgOpen->Execute()) {
      VideoGrabberSrc2->PlayerFileName  = dlgOpen->FileName;
      VideoGrabberSrc2->OpenPlayer();
   }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::cboVideoDevices1Change(TObject *Sender)
{
   VideoGrabberSrc1->VideoDevice = cboVideoDevices1->ItemIndex;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnMixPlayerOpenFileClick(TObject *Sender)
{
   dlgOpen->FileName = OPEN_MEDIA_FILES_EXTENDED;
   if (dlgOpen->Execute()) {
      VideoGrabberSrc1->PlayerFileName  = dlgOpen->FileName;
      VideoGrabberSrc1->OpenPlayer();
   }
}

//---------------------------------------------------------------------------
void __fastcall TForm1::cboVideoDevices2Change(TObject *Sender)
{
   VideoGrabberSrc2->VideoDevice = cboVideoDevices2->ItemIndex;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::VideoGrabberSrc1VideoDeviceSelected(
      TObject *Sender)
{
   cboVideoDevices1->ItemIndex = VideoGrabberSrc1->VideoDevice;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::VideoGrabberSrc2VideoDeviceSelected(
      TObject *Sender)
{
   cboVideoDevices2->ItemIndex = VideoGrabberSrc2->VideoDevice;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::VideoGrabberSrc2RawAudioSample(TObject *Sender,
      Pointer pSampleBuffer, int SampleBufferSize, int SampleDataLength,
      TFormatType FormatType, Pointer pFormat, Pointer pWaveFormatEx,
      Int64 SampleStartTime, Int64 SampleStopTime)
{
   if (! FFormClosing) { // required because Src1 may be destroyed before Src2
      if (VideoGrabberSrc2->GraphState() == gs_Running) {
         VideoGrabberSrc1->MixAudioSamples ((unsigned char*) pSampleBuffer, SampleBufferSize, SampleDataLength, FormatType, pFormat, SampleStartTime, SampleStopTime);
      }
   }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::VideoGrabberSrc1FrameOverlayUsingDC(
      TObject *Sender, HDC Dc, DWORD FrameNumber, Int64 FrameTime,
      int FrameId)
{
   EnterCriticalSection (&csOverlay);
   if (FPIPBitmap) {
      VideoGrabberSrc1->DrawBitmapOverFrame (FPIPBitmap, false, 10, 10, VideoGrabberSrc1->VideoWidth >> 1, VideoGrabberSrc1->VideoHeight >> 1, false, false, (TColor) 0, false, 0, false, 0, 0);
   }
   LeaveCriticalSection (&csOverlay);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::VideoGrabberSrc2FrameOverlayUsingDC(
      TObject *Sender, HDC Dc, DWORD FrameNumber, Int64 FrameTime,
      int FrameId)
{
   Graphics::TBitmap *BitmapReceived;
   TCanvas *TempCanvas;
   TRect VideoRect;

   EnterCriticalSection (&csOverlay);
   if (FPIPBitmap) {
      BitmapReceived = FPIPBitmap;
   }
   else {
      BitmapReceived = new Graphics::TBitmap();
      BitmapReceived->Width = VideoGrabberSrc2->VideoWidth;
      BitmapReceived->Height = VideoGrabberSrc2->VideoHeight;
      FPIPBitmap = BitmapReceived;
   }
   TempCanvas = new TCanvas();
   TempCanvas->Handle = Dc;
   SetRect (&VideoRect, 0, 0, VideoGrabberSrc2->VideoWidth, VideoGrabberSrc2->VideoHeight);
   TempCanvas->Lock();
   BitmapReceived->Canvas->Lock();
   BitmapReceived->Canvas->CopyRect (VideoRect, TempCanvas, VideoRect);
   TempCanvas->Unlock();
   BitmapReceived->Canvas->Unlock();
   delete (TempCanvas);
   LeaveCriticalSection (&csOverlay);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::VideoGrabberSrc2Inactive(TObject *Sender)
{
   Graphics::TBitmap *Temp;

   if (FPIPBitmap) {
      Temp = FPIPBitmap;
      FPIPBitmap = NULL;
      delete (Temp);
   }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::FormDestroy(TObject *Sender)
{
   DeleteCriticalSection (&csOverlay);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::tbrSrc1CurrentSourceLevelChange(TObject *Sender)
{
   VideoGrabberSrc1->MixAudioSamples_CurrentSourceLevel = 100 - tbrSrc1CurrentSourceLevel->Position;
   if (chkCombined->Checked) {
      tbrSrc1ExternalSourceLevel->Position = VideoGrabberSrc1->MixAudioSamples_CurrentSourceLevel;
   }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::tbrSrc1ExternalSourceLevelChange(TObject *Sender)
{
   VideoGrabberSrc1->MixAudioSamples_ExternalSourceLevel = 100 - tbrSrc1ExternalSourceLevel->Position;
   if (chkCombined->Checked) {
      tbrSrc1CurrentSourceLevel->Position = VideoGrabberSrc1->MixAudioSamples_ExternalSourceLevel;
   }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::chkCombinedClick(TObject *Sender)
{
   tbrSrc1CurrentSourceLevelChange (this);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::FormCloseQuery(TObject *Sender, bool &CanClose)
{
    FFormClosing = true;
}
//---------------------------------------------------------------------------

