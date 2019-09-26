#include <vcl.h>
#pragma hdrstop

#include "miscVideoControl.h"
#include "MainForm.h"
#pragma package(smart_init)
#pragma resource "*.dfm"

#include <set>

#pragma warn -8057

TfrmVideoControl *frmVideoControl;

__fastcall TfrmVideoControl::TfrmVideoControl(TComponent* Owner) : TForm(Owner)
{
}
//---------------------------------------------------------------------------

void __fastcall TfrmVideoControl::RefreshControls()
{
   chkFlipVertically->Enabled = frmMainForm->VideoGrabber->IsVideoControlModeAvailable (vc_FlipHorizontal);
   chkFlipHorizontally->Enabled = frmMainForm->VideoGrabber->IsVideoControlModeAvailable (vc_FlipVertical);
   chkExternalTrigger->Enabled = frmMainForm->VideoGrabber->IsVideoControlModeAvailable (vc_ExternalTriggerEnable);
   chkEmulateTrigger->Enabled = frmMainForm->VideoGrabber->IsVideoControlModeAvailable (vc_Trigger);
}
//---------------------------------------------------------------------------

void __fastcall TfrmVideoControl::ApplyVideoControlMode(TObject *Sender)
{
   frmMainForm->VideoGrabber->SetVideoControlMode (chkFlipHorizontally->Checked, chkFlipVertically->Checked, chkExternalTrigger->Checked, chkEmulateTrigger->Checked);
}
//---------------------------------------------------------------------------

void __fastcall TfrmVideoControl::Button2Click(TObject *Sender)
{
   Close();
}
//---------------------------------------------------------------------------


