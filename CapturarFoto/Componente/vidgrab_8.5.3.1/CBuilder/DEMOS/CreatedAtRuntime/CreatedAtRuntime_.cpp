//---------------------------------------------------------------------------
#include <vcl.h>
#pragma hdrstop

#include "CreatedAtRuntime_.h"
#include "VidGrab.hpp"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "VidGrab"
#pragma resource "*.dfm"

TForm1 *Form1;
TVideoGrabber *VideoGrabber;
bool VideoGrabberCreated;

//---------------------------------------------------------------------------

__fastcall TForm1::TForm1(TComponent* Owner)
        : TForm(Owner)
{
}
//---------------------------------------------------------------------------

void __fastcall TForm1::FormCreate(TObject *Sender)
{
   VideoGrabberCreated = false;

   TVideoGrabber *vg;
   vg = new TVideoGrabber((TComponent*) NULL); // to get the list of the video capture devices before creating the main component
   cmbVideoDevices->Items->Text = vg->VideoDevices;
   delete (vg);
   cmbVideoDevices->ItemIndex = 0;
}
//---------------------------------------------------------------------------
void __fastcall TForm1::btnCreateClick(TObject *Sender)
{
   if (VideoGrabber == NULL) {

      VideoGrabber = new TVideoGrabber (this);

      VideoGrabber->Visible = chkVisible->Checked;

      VideoGrabber->OnVideoDeviceSelected = OnVideoDeviceSelected;
      VideoGrabber->OnFrameCaptureCompleted = OnFrameCaptureCompleted;
      VideoGrabber->OnResizeVideo = OnResizeVideo;

      VideoGrabber->VideoDevice = cmbVideoDevices->ItemIndex;

      VideoGrabber->Left = 8;
      VideoGrabber->Top = 55;

      VideoGrabber->Parent = this;

      VideoGrabber->StartPreview();
      VideoGrabberCreated = true;
   }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnCaptureClick(TObject *Sender)
{
   if (VideoGrabberCreated) {
      VideoGrabber->CaptureFrameTo (fc_TBitmap, "");
   }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnDestroyClick(TObject *Sender)
{
   if (VideoGrabberCreated) {
      VideoGrabber->Free();
      VideoGrabberCreated = false;
      VideoGrabber = NULL;
   }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::OnVideoDeviceSelected(TObject *Sender)
{
   imgCapturedFrame->Picture->Assign (NULL);

   cmbVideoSizes->Clear();
   cmbVideoSizes->Items->Text = ((TVideoGrabber*) Sender)->VideoSizes;
   cmbVideoSizes->ItemIndex = ((TVideoGrabber*) Sender)->VideoSize;

   cmbVideoInputs->Clear();
   cmbVideoInputs->Items->Text = ((TVideoGrabber*) Sender)->VideoInputs;
   cmbVideoInputs->ItemIndex = ((TVideoGrabber*) Sender)->VideoInput;

   btnTVTuner->Enabled = VideoGrabber->IsTVTunerAvailable;
}
//---------------------------------------------------------------------------


void __fastcall TForm1::OnFrameCaptureCompleted(
      TObject *Sender, Pointer FrameBitmap, int BitmapWidth,
      int BitmapHeight, unsigned FrameNumber, Int64 FrameTime,
      TFrameCaptureDest DestType, String FileName, bool Success,
      int FrameId)
{
   Graphics::TBitmap *Frame_Bitmap;

   Frame_Bitmap = (Graphics::TBitmap*) FrameBitmap;

   imgCapturedFrame->Left = ((TVideoGrabber*) (Sender))->Left + ((TVideoGrabber*) (Sender))->Width + 10;
   imgCapturedFrame->AutoSize = true;

   bool AlternateMethod = False; // you can choose one of the 2 methods below (set True to test the 2nd)

   if (! AlternateMethod) { // this code reassign the bitmap handle to the picture (saves CPU)
      imgCapturedFrame->Picture->Bitmap->Handle = Frame_Bitmap->Handle;
      Frame_Bitmap->ReleaseHandle();
   }
   else { // this code makes a copy of the bitmap
      imgCapturedFrame->Picture->Assign (Frame_Bitmap);
   }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::OnResizeVideo(TObject *Sender, int SourceWidth, int SourceHeight)
{
   int NewWidth;

   imgCapturedFrame->Picture->Assign (NULL);
   Height = VideoGrabber->Top + VideoGrabber->Height + 80;
   imgCapturedFrame->Left = VideoGrabber->Left + VideoGrabber->Width + 20;
   imgCapturedFrame->Top = 55;
   imgCapturedFrame->Width = VideoGrabber->Width;
   imgCapturedFrame->Height = VideoGrabber->Height;
   NewWidth = imgCapturedFrame->Left + VideoGrabber->Width + 15;
   if (NewWidth < GroupBox1->Width + 20) {
      NewWidth = GroupBox1->Width + 20;
   }
   Width = NewWidth;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnTVTunerClick(TObject *Sender)
{
   if (VideoGrabberCreated) {
      VideoGrabber->ShowDialog (dlg_TVTuner);
   }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::cmbVideoDevicesChange(TObject *Sender)
{
   if (VideoGrabberCreated) {
      VideoGrabber->VideoDevice =cmbVideoDevices->ItemIndex;
   }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::cmbVideoSizesChange(TObject *Sender)
{
   if (VideoGrabberCreated) {
      VideoGrabber->VideoSize =cmbVideoSizes->ItemIndex;
   }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::cmbVideoInputsChange(TObject *Sender)
{
   if (VideoGrabberCreated) {
      VideoGrabber->VideoInput =cmbVideoInputs->ItemIndex;
   }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::chkVisibleClick(TObject *Sender)
{
   if (VideoGrabberCreated) {
      VideoGrabber->Visible = chkVisible->Checked;
   }
}
//---------------------------------------------------------------------------

