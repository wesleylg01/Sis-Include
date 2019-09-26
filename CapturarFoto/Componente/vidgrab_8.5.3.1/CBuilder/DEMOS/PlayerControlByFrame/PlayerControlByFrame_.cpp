//---------------------------------------------------------------------------
#include <vcl.h>
#pragma hdrstop

#include "PlayerControlByFrame_.h"
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

void __fastcall TForm1::FormCreate(TObject *Sender)
{
   chkUseClock->Checked = VideoGrabber->UseClock;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnPlayerOpenFileClick(TObject *Sender)
{
   dlgOpen->FileName = "*.mpg;*.mpeg;*.vro;*.avi;*.wav;*.asf;*.wmv;*.vob";
   if (dlgOpen->Execute()) {
      edtPlayerClip->Text = dlgOpen->FileName;
   }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnOpenClipClick(TObject *Sender)
{
   Image1->AutoSize = True;
   VideoGrabber->Display_AutoSize = False;
   VideoGrabber->PlayerFileName = edtPlayerClip->Text;
   VideoGrabber->PlayerRefreshPausedDisplay = False;
   VideoGrabber->AutoStartPlayer = False;
   VideoGrabber->BurstCount = 0;
   VideoGrabber->BurstInterval = 0;
   VideoGrabber->BurstMode = True;
   VideoGrabber->OpenPlayer();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnPlayClick(TObject *Sender)
{
   VideoGrabber->RunPlayer();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnPauseClick(TObject *Sender)
{
    VideoGrabber->PausePlayer();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnStopClick(TObject *Sender)
{
    VideoGrabber->StopPlayer();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::VideoGrabberFrameProgress(TObject *Sender,
      DWORD FrameNumber, Int64 FrameTime, int FrameId)
{
   MemoLog->Lines->Add ("frame #" + IntToStr (FrameNumber) + " reached.");
}
//---------------------------------------------------------------------------

void __fastcall TForm1::VideoGrabberFrameCaptureCompleted(TObject *Sender,
      Pointer FrameBitmap, int BitmapWidth, int BitmapHeight,
      DWORD FrameNumber, Int64 FrameTime, TFrameCaptureDest DestType,
      String FileName, bool Success, int FrameId)
{
   Image1->Picture->Assign((Graphics::TBitmap*) FrameBitmap);
   Image1->Update();
   MemoLog->Lines->Add ("frame #" + IntToStr (FrameNumber) + " CAPTURED.");
}
//---------------------------------------------------------------------------

void __fastcall TForm1::chkUseClockClick(TObject *Sender)
{
   VideoGrabber->UseClock = chkUseClock->Checked;
}
//---------------------------------------------------------------------------

