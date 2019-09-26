//---------------------------------------------------------------------------
#include <vcl.h>
#pragma hdrstop

#include "PictureInPictureMixer_.h"
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

void __fastcall AssignListToComboBox (TComboBox* ComboBox, String List, int Index)
{
   ComboBox->Items->Text = List;
   if (ComboBox->Items->Count > 0) {
      ComboBox->ItemIndex = Index;
   }
}

const String OPEN_MEDIA_FILES = "*.mp*;*.vro;*.avi;*.wav;*.asf;*.wm*;*.vob;*.mov;*.avs;*.divx";

//---------------------------------------------------------------------------
void __fastcall TForm1::FormCreate(TObject *Sender)
{
   FCurrentMixer1ID = 0;
   FCurrentMixer2ID = 0;

   VideoGrabberMixer->VideoSource = vs_Mixer;
   
   VideoGrabberSrc1->Display_AutoSize = false;
   VideoGrabberSrc2->Display_AutoSize = false;

   AssignListToComboBox (cboVideoDevices1, VideoGrabberSrc1->VideoDevices, VideoGrabberSrc1->VideoDevice);
   AssignListToComboBox (cboVideoDevices2, VideoGrabberSrc2->VideoDevices, VideoGrabberSrc2->VideoDevice);

   FCurrentMixer1ID = VideoGrabberMixer->Mixer_AddToMixer (VideoGrabberSrc1->UniqueID, 0, 0, 0, 0, 0, true, true);
   FCurrentMixer2ID = VideoGrabberMixer->Mixer_AddToMixer (VideoGrabberSrc2->UniqueID, 0, 0, 0, 0, 0, true, true);

   SetPIPA (this);
   SetPIPB (this);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnSizeOkClick(TObject *Sender)
{
   VideoGrabberMixer->UseNearestVideoSize (StrToIntDef (edtDestWidth->Text, 320), StrToIntDef (edtDestHeight->Text, 240), true);
        
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnSrc1StartClick(TObject *Sender)
{
   VideoGrabberSrc1->StartPreview();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnSrc1StopClick(TObject *Sender)
{
   VideoGrabberSrc1->StopPreview();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnSrc2StartClick(TObject *Sender)
{
   VideoGrabberSrc2->StartPreview();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnSrc2StopClick(TObject *Sender)
{
   VideoGrabberSrc2->StopPreview();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnDestStartClick(TObject *Sender)
{
   VideoGrabberMixer->VideoSource = vs_Mixer;
   VideoGrabberMixer->StartPreview();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button2Click(TObject *Sender)
{
   VideoGrabberMixer->Stop();
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

void __fastcall TForm1::SetPIPA(TObject *Sender)
{
   int PIPLeft, PIPTop, PIPWidth, PIPHeight;
   bool ActivatePIP, MoveToTop;

   ActivatePIP = chkPipA->Checked;
   MoveToTop = ((TComponent*)Sender)->Tag == 1; // the tag of the "move to top" button = 1, if the sender"s tag = 1 it"s the "move to top" button that has been pressed
   PIPLeft   = StrToIntDef (edtLeftA->Text, 0);
   PIPTop    = StrToIntDef (edtTopA->Text, 0);
   PIPWidth  = StrToIntDef (edtWidthA->Text, 0);
   PIPHeight = StrToIntDef (edtHeightA->Text, 0);
   VideoGrabberMixer->Mixer_SetPIPLocation (FCurrentMixer1ID, ActivatePIP, PIPLeft, PIPTop, PIPWidth, PIPHeight, MoveToTop);
}

void __fastcall TForm1::SetPIPB(TObject *Sender)
{
   int PIPLeft, PIPTop, PIPWidth, PIPHeight;
   bool ActivatePIP, MoveToTop;

   ActivatePIP = chkPipB->Checked;
   MoveToTop = ((TComponent*)Sender)->Tag == 1; // the tag of the "move to top" button = 1, if the sender"s tag = 1 it"s the "move to top" button that has been pressed
   PIPLeft   = StrToIntDef (edtLeftB->Text, 0);
   PIPTop    = StrToIntDef (edtTopB->Text, 0);
   PIPWidth  = StrToIntDef (edtWidthB->Text, 0);
   PIPHeight = StrToIntDef (edtHeightB->Text, 0);
   VideoGrabberMixer->Mixer_SetPIPLocation (FCurrentMixer2ID, ActivatePIP, PIPLeft, PIPTop, PIPWidth, PIPHeight, MoveToTop);
}


void __fastcall TForm1::ChkSendToMixer1Click(TObject *Sender)
{
   VideoGrabberMixer->Mixer_Activation (FCurrentMixer1ID, ChkSendToMixer1->Checked);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::ChkSendToMixer2Click(TObject *Sender)
{
   VideoGrabberMixer->Mixer_Activation (FCurrentMixer2ID, ChkSendToMixer1->Checked);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnStartRecordingClick(TObject *Sender)
{
   VideoGrabberMixer->VideoSource = vs_Mixer;
   VideoGrabberMixer->StartRecording();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnPlayRecordedClick(TObject *Sender)
{
   VideoGrabberMixer->PlayerFileName = VideoGrabberMixer->Last_Recording_FileName;
   VideoGrabberMixer->OpenPlayer();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnFrameRateOkClick(TObject *Sender)
{
   VideoGrabberMixer->FrameRate = StrToFloatDef (edtOutputFrameRate->Text, 30);
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

void __fastcall TForm1::VideoGrabberLog(TObject *Sender, TLogType LogType, String Severity, String InfoMsg)
{
   mmoLog->Lines->Add ("[" + Severity + "] " + InfoMsg);
}
//---------------------------------------------------------------------------


void __fastcall TForm1::VideoGrabberMixerPreviewStarted(TObject *Sender)
{
   mmoLog->Lines->Add ("previewing");
}
//---------------------------------------------------------------------------

void __fastcall TForm1::VideoGrabberMixerRecordingStarted(TObject *Sender,
      String FileName)
{
   mmoLog->Lines->Add ("recording to " + FileName);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::VideoGrabberMixerPlayerOpened(TObject *Sender)
{
   mmoLog->Lines->Add ("playing " + ((TVideoGrabber*)Sender)->PlayerFileName);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnOpenClipAClick(TObject *Sender)
{
   OpenDialog->FileName = OPEN_MEDIA_FILES;
   if (OpenDialog->Execute()) {
      VideoGrabberSrc1->PlayerFileName = OpenDialog->FileName;
      VideoGrabberSrc1->OpenPlayer();
   }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnOpenClipBClick(TObject *Sender)
{
   OpenDialog->FileName = OPEN_MEDIA_FILES;
   if (OpenDialog->Execute()) {
      VideoGrabberSrc2->PlayerFileName = OpenDialog->FileName;
      VideoGrabberSrc2->OpenPlayer();
   }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnPlayClipAClick(TObject *Sender)
{
   VideoGrabberSrc1->RunPlayer();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnPlayClipBClick(TObject *Sender)
{
   VideoGrabberSrc2->RunPlayer();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnStopClipAClick(TObject *Sender)
{
   VideoGrabberSrc1->StopPlayer();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnStopClipBClick(TObject *Sender)
{
   VideoGrabberSrc1->StopPlayer();
}
//---------------------------------------------------------------------------

