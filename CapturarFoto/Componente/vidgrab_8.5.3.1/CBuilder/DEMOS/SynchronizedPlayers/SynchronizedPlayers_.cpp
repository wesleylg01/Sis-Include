//---------------------------------------------------------------------------
#include <vcl.h>
#pragma hdrstop

#include "SynchronizedPlayers_.h"
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

void __fastcall TForm1::btnPlayerOpenFileClick(TObject *Sender)
{
   dlgOpen->FileName = "*.mpg;*.mpeg;*.vro;*.avi;*.wav;*.mp3;*.asf;*.wmv;*.vob";
   if (dlgOpen->Execute()) {
      edtFileName->Text = dlgOpen->FileName;
   }
}
//---------------------------------------------------------------------------

void __fastcall SetupPlayer (TVideoGrabber *VideoGrabber, TSynchronizationRole SynchronizationRole, String VideoClip)
{
   VideoGrabber->Synchronized = true;
   VideoGrabber->TextOverlay_Enabled = true;
   VideoGrabber->AutoStartPlayer = false;
   VideoGrabber->SynchronizationRole = SynchronizationRole;
   VideoGrabber->PlayerFileName = VideoClip;
}
//---------------------------------------------------------------------------

// NOTE 1:
// when its Synchronized property is enabled, invoking the command applied on one component
// is applied to all the other components that have also their Synchronized property enabled
// (within the same application).

// NOTE 2:
// the trackbars are associated to the TVideoGrabber components through their "PlayerTrackbar" property

void __fastcall TForm1::btnOpenClick(TObject *Sender)
{
   SetupPlayer (VideoGrabber1, sr_Master, edtFileName->Text);
   SetupPlayer (VideoGrabber2, sr_Slave, edtFileName->Text);
   SetupPlayer (VideoGrabber3, sr_Slave, edtFileName->Text);
   SetupPlayer (VideoGrabber4, sr_Slave, edtFileName->Text);

   VideoGrabber1->ClosePlayer();
   VideoGrabber1->OpenPlayer();
   VideoGrabber1->StartSynchronized();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnCloseClick(TObject *Sender)
{
   VideoGrabber1->ClosePlayer();
}
//---------------------------------------------------------------------------
void __fastcall TForm1::btnPauseClick(TObject *Sender)
{
   VideoGrabber1->PausePlayer();
}
//---------------------------------------------------------------------------
void __fastcall TForm1::btnStopClick(TObject *Sender)
{
   VideoGrabber1->StopPlayer();
}
//---------------------------------------------------------------------------
void __fastcall TForm1::btnPlayClick(TObject *Sender)
{
   VideoGrabber1->RunPlayer();
}
//---------------------------------------------------------------------------
void __fastcall TForm1::chkSync1Click(TObject *Sender)
{
   VideoGrabber1->Synchronized = chkSync1->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::chkSync2Click(TObject *Sender)
{
   VideoGrabber2->Synchronized = chkSync2->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::chkSync3Click(TObject *Sender)
{
   VideoGrabber3->Synchronized = chkSync3->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::chkSync4Click(TObject *Sender)
{
   VideoGrabber4->Synchronized = chkSync4->Checked;
}
//---------------------------------------------------------------------------

