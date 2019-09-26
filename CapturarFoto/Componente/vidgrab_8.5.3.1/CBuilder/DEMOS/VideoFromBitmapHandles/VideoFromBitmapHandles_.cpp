//---------------------------------------------------------------------------
#include <vcl.h>
#pragma hdrstop

#include "VideoFromBitmapHandles_.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "VidGrab"
#pragma resource "*.dfm"
TForm1 *Form1;

__fastcall TForm1::TForm1(TComponent* Owner)
        : TForm(Owner)
{
}
//---------------------------------------------------------------------------


void __fastcall TForm1::btnStartPreviewClick(TObject *Sender)
{
   VideoGrabber->VideoSource = vs_JPEGsOrBitmaps;
   VideoGrabber->FrameRate = StrToIntDef (edtRecordingFrameRate->Text, 200);
   VideoGrabber->StartPreview();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnStartRecordingClick(TObject *Sender)
{
   VideoGrabber->VideoSource = vs_JPEGsOrBitmaps;
   VideoGrabber->FrameRate = StrToIntDef (edtRecordingFrameRate->Text, 200);
   VideoGrabber->StartRecording();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnStopClick(TObject *Sender)
{
   VideoGrabber->Stop();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnPlayClick(TObject *Sender)
{
   VideoGrabber->PlayerFileName = VideoGrabber->Last_Recording_FileName;
   VideoGrabber->OpenPlayer();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::VideoGrabberFrameProgress(TObject *Sender,
      DWORD FrameNumber, Int64 FrameTime, int FrameId)
{
   edtFrameProgress->Text = "frame # " + IntToStr (FrameNumber);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::VideoGrabberLog(TObject *Sender, TLogType LogType,
      String Severity, String InfoMsg)
{
   mmoLog->Lines->Add (InfoMsg);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::VideoGrabberInactive(TObject *Sender)
{
   mmoLog->Lines->Add ("done.");
}
//---------------------------------------------------------------------------

void __fastcall TForm1::VideoGrabberPreviewStarted(TObject *Sender)
{
   mmoLog->Lines->Add ("previewing");
}
//---------------------------------------------------------------------------

void __fastcall TForm1::VideoGrabberRecordingStarted(TObject *Sender,
      String FileName)
{
   mmoLog->Lines->Add ("recording to: " + FileName);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::VideoGrabberRecordingCompleted(TObject *Sender,
      String FileName, bool Success)
{
   if (Success) {
      mmoLog->Lines->Add ("recording completed: " + FileName);
   }
   else {
      mmoLog->Lines->Add ("recording failed: " + FileName);
   }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::VideoGrabberPlayerOpened(TObject *Sender)
{
   mmoLog->Lines->Add ("playing: " + VideoGrabber->PlayerFileName);
}
//---------------------------------------------------------------------------








void __fastcall TForm1::VideoGrabberAVIDurationUpdated(TObject *Sender,
      String FileName, DWORD FrameCount, double &FrameRate,
      Int64 &Duration)
{
   FrameRate = StrToIntDef (edtFinalFrameRate->Text, 30);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::VideoGrabberVideoFromBitmapsNextFrameNeeded(
      TObject *Sender, bool FirstSample)
{
   int BitmapHandle;
   bool CanFreeBitmapHandle;

   if (chkMakeBitmapCopy->Checked) {

      // in this case we make a copy of the bitmap, and we pass the copy
      // and the handle will be freed by TVideoGrabber

      Graphics::TBitmap* Bitmap = new Graphics::TBitmap;

      switch (FImageIndex) {
         case 0: Bitmap->Assign (Image1->Picture); break;
         case 1: Bitmap->Assign (Image2->Picture); break;
         case 2: Bitmap->Assign (Image3->Picture); break;
         case 3: Bitmap->Assign (Image4->Picture); break;
      }
      BitmapHandle = (int) Bitmap->Handle;
      Bitmap->ReleaseHandle();
      delete (Bitmap);
      CanFreeBitmapHandle = true; // it's a copy, TVideoGrabber can free it

   }
   else {

      // in this case we pass directly the bitmap handle,
      // and we tell TVideoGrabber not to free it
      switch (FImageIndex) {
         case 0: BitmapHandle = (int) Image1->Picture->Bitmap->Handle; break;
         case 1: BitmapHandle = (int) Image2->Picture->Bitmap->Handle; break;
         case 2: BitmapHandle = (int) Image3->Picture->Bitmap->Handle; break;
         case 3: BitmapHandle = (int) Image4->Picture->Bitmap->Handle; break;
      }
      CanFreeBitmapHandle = false; // it's not a copy, TVideoGrabber must not free it

   }
   FImageIndex ++;
   if (FImageIndex == 4) {
      FImageIndex = 0;
   }
   VideoGrabber->SendImageToVideoFromBitmaps ("", BitmapHandle, CanFreeBitmapHandle, false);
}
//---------------------------------------------------------------------------


