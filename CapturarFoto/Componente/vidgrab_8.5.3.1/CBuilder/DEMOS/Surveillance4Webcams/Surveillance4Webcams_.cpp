//---------------------------------------------------------------------------
#include <vcl.h>
#pragma hdrstop

#include "WebcamControl.h"
#include "Surveillance4Webcams_.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TFrmMaster *FrmMaster;

const
   FormSpacings = 5;

//---------------------------------------------------------------------------
__fastcall TFrmMaster::TFrmMaster(TComponent* Owner)
        : TForm(Owner)
{
}
//---------------------------------------------------------------------------

void __fastcall CreateWebcamForm (int VideoDeviceIndex, TFrmWebcam **WebcamForm, int FormTop, int FormLeft)
{
   Application->CreateForm (__classid(TFrmWebcam), WebcamForm);
   (*WebcamForm)->Caption = "Camera " + IntToStr (VideoDeviceIndex);
   (*WebcamForm)->Top = FormTop;
   (*WebcamForm)->Left = FormLeft;
   (*WebcamForm)->VideoGrabber->Display_AutoSize = False;
   (*WebcamForm)->VideoGrabber->Display_AspectRatio = ar_Stretch;
   (*WebcamForm)->VideoGrabber->AutoFilePrefix = "CAM" + IntToStr (VideoDeviceIndex) + '_';
   (*WebcamForm)->VideoGrabber->AutoFileName = fn_DateTime;
   (*WebcamForm)->VideoGrabber->VideoDevice = VideoDeviceIndex;
   (*WebcamForm)->VideoGrabber->CaptureFrameTo (fc_JpegFile, ""); // the motion detection will return frame captured as JPEG files
   (*WebcamForm)->VideoGrabber->MotionDetector_Enabled = True;
   (*WebcamForm)->Show();
}


void __fastcall TFrmMaster::btnStartMasterClick(TObject *Sender)
{
   FrmWebcam1->VideoGrabber->Synchronized = True;
   FrmWebcam2->VideoGrabber->Synchronized = True;
   FrmWebcam3->VideoGrabber->Synchronized = True;
   FrmWebcam4->VideoGrabber->Synchronized = True;
   FrmWebcam1->VideoGrabber->StartPreview();
   FrmWebcam2->VideoGrabber->StartPreview();
   FrmWebcam3->VideoGrabber->StartPreview();
   FrmWebcam4->VideoGrabber->StartPreview();
}
//---------------------------------------------------------------------------
void __fastcall TFrmMaster::btnStopMasterClick(TObject *Sender)
{
   FrmWebcam1->VideoGrabber->StopPreview();
   FrmWebcam2->VideoGrabber->StopPreview();
   FrmWebcam3->VideoGrabber->StopPreview();
   FrmWebcam4->VideoGrabber->StopPreview();
}
//---------------------------------------------------------------------------
void __fastcall TFrmMaster::FormShow(TObject *Sender)
{
   if (! FrmWebcam1) CreateWebcamForm (0, &FrmWebcam1, FrmMaster->Top + FrmMaster->Height + FormSpacings, FrmMaster->Left);
   if (! FrmWebcam2) CreateWebcamForm (1, &FrmWebcam2, FrmMaster->Top + FrmMaster->Height + FormSpacings, FrmMaster->Left + FrmWebcam1->Width + FormSpacings);
   if (! FrmWebcam3) CreateWebcamForm (2, &FrmWebcam3, FrmWebcam1->Top + FrmWebcam1->Height + FormSpacings, FrmMaster->Left);
   if (! FrmWebcam4) CreateWebcamForm (3, &FrmWebcam4, FrmWebcam1->Top + FrmWebcam1->Height + FormSpacings, FrmMaster->Left + FrmWebcam1->Width + FormSpacings);
}
//---------------------------------------------------------------------------
