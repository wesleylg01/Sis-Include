//---------------------------------------------------------------------------
#include <vcl.h>
#pragma hdrstop

#include "MixedVideoSources_.h"
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

const
   MAXSOURCES = 2;

void __fastcall AssignListToComboBox (TComboBox* ComboBox, String List, int Index)
{
   ComboBox->Items->Text = List;
   if (ComboBox->Items->Count > 0) {
      ComboBox->ItemIndex = Index;
   }
}

void __fastcall TForm1::FormCreate(TObject *Sender)
{
   FDestWidth = 320;
   FDestHeight = 240;
   AssignListToComboBox (cboVideoDevices1, VideoGrabberSrc1->VideoDevices, VideoGrabberSrc1->VideoDevice);
   AssignListToComboBox (cboVideoDevices2, VideoGrabberSrc1->VideoDevices, VideoGrabberSrc1->VideoDevice);
   FVideoGrabbers[0] = VideoGrabberSrc1;
   FVideoGrabbers[1] = VideoGrabberSrc2;
   FSourceIndex = 0;
   FSourceIndex = 0;
   FSwapFrameCount = 0;
   FMaxSwapFrameCount = 30;
   FAllSourcesStopped = false;
   FCurrentBitmap = NULL;
   FCurrentBitmapInUse = false;

}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnSrc1StartClick(TObject *Sender)
{
   VideoGrabberSrc1->VideoSource = vs_VideoCaptureDevice;
   VideoGrabberSrc1->BurstMode = true;
   VideoGrabberSrc1->BurstCount = 0;
      VideoGrabberSrc1->StartPreview();
}
//---------------------------------------------------------------------------
void __fastcall TForm1::btnSrc1StopClick(TObject *Sender)
{
   VideoGrabberSrc1->Stop();
}
//---------------------------------------------------------------------------
void __fastcall TForm1::btnSrc2StartClick(TObject *Sender)
{
   VideoGrabberSrc2->VideoSource = vs_VideoCaptureDevice;
   VideoGrabberSrc2->BurstMode = true;
   VideoGrabberSrc2->BurstCount = 0;
   VideoGrabberSrc2->StartPreview();
}
//---------------------------------------------------------------------------
void __fastcall TForm1::btnSrc2StopClick(TObject *Sender)
{
   VideoGrabberSrc2->Stop();
}
//---------------------------------------------------------------------------
void __fastcall TForm1::btnDestStartClick(TObject *Sender)
{
   if ((VideoGrabberSrc1->CurrentState == cs_Preview) || (VideoGrabberSrc2->CurrentState == cs_Preview)) {
      VideoGrabberDest->VideoSource = vs_JPEGsOrBitmaps;
      VideoGrabberDest->StartPreview();
   }
   else {
      ShowMessage ("at least one video source must be previewing");
   }
}
//---------------------------------------------------------------------------
void __fastcall TForm1::btnDestStopClick(TObject *Sender)
{
   VideoGrabberDest->Stop();
}
//---------------------------------------------------------------------------
void __fastcall TForm1::VideoGrabberSrcFrameCaptureCompleted(
      TObject *Sender, Pointer FrameBitmap, int BitmapWidth,
      int BitmapHeight, DWORD FrameNumber, Int64 FrameTime,
      TFrameCaptureDest DestType, String FileName, bool Success,
      int FrameId)
{
   Graphics::TBitmap *NewBitmap;
   Graphics::TBitmap *OldBitmap;

   FAllSourcesStopped = false; // if (we receive a frame this means at least one source is running
   if (FVideoGrabbers[FSourceIndex] == Sender) {
      if (FVideoGrabbers[FSourceIndex]->CurrentState != cs_Down) {
         NewBitmap = new (Graphics::TBitmap);
         NewBitmap->Assign ((Graphics::TBitmap*) FrameBitmap);
         if (! FCurrentBitmapInUse) {
            OldBitmap = FCurrentBitmap;
            FCurrentBitmap = NewBitmap;
            if (OldBitmap) {
               delete (OldBitmap);
            }
         }
         else {
            delete (NewBitmap); // the current bitmap was in use, so finally we don't pass this new one
         }
      }
   }
}
//---------------------------------------------------------------------------


void __fastcall TForm1::SwapToNextSource (void)
{
   int CurrentSource;
   bool Done;

   Done = false;
   CurrentSource = FSourceIndex;
   while (! Done) {
      FSourceIndex ++;
      if (FSourceIndex >= MAXSOURCES) {
         FSourceIndex = 0;
      }
      if (FVideoGrabbers[FSourceIndex]->CurrentState != cs_Down) {
         Done = true;
      }
      else {
         if (FSourceIndex == CurrentSource) { // all sources stopped
            FAllSourcesStopped = true;
            Done = true;
         }
      }
   }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::cboVideoDevices1Change(TObject *Sender)
{
   VideoGrabberSrc1->VideoDevice = cboVideoDevices1->ItemIndex;
}
//---------------------------------------------------------------------------
void __fastcall TForm1::cboVideoDevices2Change(TObject *Sender)
{
   VideoGrabberSrc2->VideoDevice = cboVideoDevices2->ItemIndex;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnSizeOkClick(TObject *Sender)
{
   if (VideoGrabberDest->CurrentState == cs_Preview) {
      VideoGrabberDest->StopPreview();
      VideoGrabberDest->StartPreview();
   }
}
//---------------------------------------------------------------------------
void __fastcall TForm1::edtMaxSwapFrameCountChange(TObject *Sender)
{
   FMaxSwapFrameCount = StrToIntDef (edtMaxSwapFrameCount->Text, 30);
}
//---------------------------------------------------------------------------
void __fastcall TForm1::VideoGrabberSrcInactive(TObject *Sender)
{
   SwapToNextSource();

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


void __fastcall TForm1::btnFrameRateOkClick(TObject *Sender)
{
   VideoGrabberDest->FrameRate = StrToFloatDef (edtOutputFrameRate->Text, 30);
}
//---------------------------------------------------------------------------


void __fastcall TForm1::btnStartRecordingClick(TObject *Sender)
{
   if ((VideoGrabberSrc1->CurrentState == cs_Preview) || (VideoGrabberSrc2->CurrentState == cs_Preview)) {
      VideoGrabberDest->VideoSource = vs_JPEGsOrBitmaps;
      VideoGrabberDest->StartRecording();
   }
   else {
      ShowMessage ("at least one video source must be previewing");
   }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnPlayRecordedClick(TObject *Sender)
{
   VideoGrabberDest->PlayerFileName = VideoGrabberDest->Last_Recording_FileName;
   VideoGrabberDest->OpenPlayer();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::VideoGrabberDestLog(TObject *Sender,
      TLogType LogType, String Severity, String InfoMsg)
{
   mmoLog->Lines->Add ("[" + Severity + "] " + InfoMsg);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::VideoGrabberDestRecordingStarted(TObject *Sender,
      String FileName)
{
   mmoLog->Lines->Add ("recording to " + FileName);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::VideoGrabberDestPlayerOpened(TObject *Sender)
{
   mmoLog->Lines->Add ("playing " + ((TVideoGrabber*) (Sender))->PlayerFileName);
}
//---------------------------------------------------------------------------


void __fastcall TForm1::VideoGrabberDestVideoFromBitmapsNextFrameNeeded(
      TObject *Sender, bool FirstSample)
{
   Graphics::TBitmap *NewBitmap;

   int BitmapHandle = 0;

   bool EndOfData = false;

   if (FirstSample) {
      FDestWidth = StrToIntDef (edtDestWidth->Text, 320);
      FDestHeight = StrToIntDef (edtDestHeight->Text, 320);
   }
   if (FCurrentBitmap) {
      FCurrentBitmapInUse = true;
      NewBitmap = new (Graphics::TBitmap);
      NewBitmap->Width = FDestWidth;
      NewBitmap->Height = FDestHeight;
      NewBitmap->PixelFormat = pf24bit;
      NewBitmap->Canvas->Lock();
      FCurrentBitmap->Canvas->Lock();
      NewBitmap->Canvas->StretchDraw (Rect (0, 0, FDestWidth, FDestHeight), FCurrentBitmap);
      NewBitmap->Canvas->Unlock();
      FCurrentBitmap->Canvas->Unlock();
      FCurrentBitmapInUse = false;
      BitmapHandle = (int) NewBitmap->Handle;
      NewBitmap->ReleaseHandle();
      delete (NewBitmap);
      FSwapFrameCount ++;
      if (FSwapFrameCount >= FMaxSwapFrameCount) {
         FSwapFrameCount = 0;
         SwapToNextSource();
      }
      if (FAllSourcesStopped) {
         if (chkStopWhenAllDown->Checked) {
            EndOfData = true;
         }
      }
      ((TVideoGrabber*) Sender)->SendImageToVideoFromBitmaps ("", BitmapHandle, true, EndOfData);
   }
}
//---------------------------------------------------------------------------

