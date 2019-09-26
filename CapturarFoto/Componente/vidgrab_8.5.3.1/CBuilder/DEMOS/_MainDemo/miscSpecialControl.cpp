//---------------------------------------------------------------------------
#include <vcl.h>
#pragma hdrstop

#include "miscSpecialControl.h"
#include "MainForm.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"

#pragma warn -8057

TfrmSpecialControls *frmSpecialControls;
//---------------------------------------------------------------------------
__fastcall TfrmSpecialControls::TfrmSpecialControls(TComponent* Owner)
        : TForm(Owner)
{
}
//---------------------------------------------------------------------------
void __fastcall TfrmSpecialControls::btnPanTiltHomeClick(TObject *Sender)
{
   frmMainForm->VideoGrabber->SendCameraCommand (0, 0, false);
}
//---------------------------------------------------------------------------
void __fastcall TfrmSpecialControls::btnPanTiltRightClick(TObject *Sender)
{
   frmMainForm->VideoGrabber->SendCameraCommand (1, 0, true);
}
//---------------------------------------------------------------------------
void __fastcall TfrmSpecialControls::btnPanTiltLeftClick(TObject *Sender)
{
   frmMainForm->VideoGrabber->SendCameraCommand (-1, 0, true);
}
//---------------------------------------------------------------------------
void __fastcall TfrmSpecialControls::btnPanTiltUpClick(TObject *Sender)
{
   frmMainForm->VideoGrabber->SendCameraCommand (0, 1, true);
}
//---------------------------------------------------------------------------
void __fastcall TfrmSpecialControls::btnPanTiltDownClick(TObject *Sender)
{
   frmMainForm->VideoGrabber->SendCameraCommand (0, -1, true);
}
//---------------------------------------------------------------------------
void __fastcall TfrmSpecialControls::rdgGpio0Click(TObject *Sender)
{
   frmMainForm->VideoGrabber->PutMiscDeviceControl (mdc_GPIO, 0, rdgGpio0->ItemIndex);
}
//---------------------------------------------------------------------------
void __fastcall TfrmSpecialControls::rdgGpio1Click(TObject *Sender)
{
   frmMainForm->VideoGrabber->PutMiscDeviceControl (mdc_GPIO, 1, rdgGpio1->ItemIndex);
}
//---------------------------------------------------------------------------
void __fastcall TfrmSpecialControls::rdgGpio2Click(TObject *Sender)
{
   frmMainForm->VideoGrabber->PutMiscDeviceControl (mdc_GPIO, 2, rdgGpio2->ItemIndex);
}
//---------------------------------------------------------------------------
void __fastcall TfrmSpecialControls::rdgGpio3Click(TObject *Sender)
{
   frmMainForm->VideoGrabber->PutMiscDeviceControl (mdc_GPIO, 3, rdgGpio3->ItemIndex);
}
//---------------------------------------------------------------------------
