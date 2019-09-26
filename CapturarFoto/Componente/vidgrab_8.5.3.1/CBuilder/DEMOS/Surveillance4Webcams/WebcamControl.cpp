//---------------------------------------------------------------------------
#include <vcl.h>
#pragma hdrstop

#include "WebcamControl.h"
#include "Surveillance4Webcams_.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "VidGrab"
#pragma resource "*.dfm"
TFrmWebcam *FrmWebcam;
//---------------------------------------------------------------------------
__fastcall TFrmWebcam::TFrmWebcam(TComponent* Owner)
        : TForm(Owner)
{
}
//---------------------------------------------------------------------------

void __fastcall AssignListToComboBox (TComboBox* ComboBox, String List, int Index)
{
   ComboBox->Items->Text = List;
   if (ComboBox->Items->Count > 0) {
      ComboBox->ItemIndex = Index;
   }
}
//---------------------------------------------------------------------------

void __fastcall TFrmWebcam::FormCreate(TObject *Sender)
{
   AssignListToComboBox (cboVideoDevices, VideoGrabber->VideoDevices, VideoGrabber->VideoDevice);
   updMaxDetectionsPerSecond->Position = VideoGrabber->MotionDetector_MaxDetectionsPerSecond;
}
//---------------------------------------------------------------------------
void __fastcall TFrmWebcam::updGlobalSensitivityClick(TObject *Sender,
      TUDBtnType Button)
{
   VideoGrabber->MotionDetector_GloballyIncOrDecSensitivity (updGlobalSensitivity->Position);
}
//---------------------------------------------------------------------------
void __fastcall TFrmWebcam::updMaxDetectionsPerSecondClick(TObject *Sender,
      TUDBtnType Button)
{
   VideoGrabber->MotionDetector_MaxDetectionsPerSecond = updMaxDetectionsPerSecond->Position;
}
//---------------------------------------------------------------------------
void __fastcall TFrmWebcam::StartPreview1Click(TObject *Sender)
{
   VideoGrabber->StartPreview();
}
//---------------------------------------------------------------------------
void __fastcall TFrmWebcam::StopPreview1Click(TObject *Sender)
{
   VideoGrabber->StopPreview();
}
//---------------------------------------------------------------------------
void __fastcall TFrmWebcam::StartRecording1Click(TObject *Sender)
{
   VideoGrabber->StartRecording();
}
//---------------------------------------------------------------------------
void __fastcall TFrmWebcam::StopRecording1Click(TObject *Sender)
{
   VideoGrabber->StopRecording();
}
//---------------------------------------------------------------------------
void __fastcall TFrmWebcam::StartPlayback1Click(TObject *Sender)
{
   VideoGrabber->PlayerFileName = VideoGrabber->Last_Recording_FileName;
   VideoGrabber->OpenPlayer();
}
//---------------------------------------------------------------------------
void __fastcall TFrmWebcam::StopPlayback2Click(TObject *Sender)
{
   VideoGrabber->ClosePlayer();
}
//---------------------------------------------------------------------------
void __fastcall TFrmWebcam::VideoGrabberMotionDetected(TObject *Sender,
      double GlobalMotionRatio, int MaxMotionCellX, int MaxMotionCellY,
      Pointer FrameBitmap, DWORD FrameNumber, Int64 FrameTime, int FrameId,
      bool &CaptureFrame)
{
   shpMotionDetected->Brush->Color = clLime;
   mmoMotionGrid->Text = VideoGrabber->MotionDetector_Get2DTextMotion();
   CaptureFrame = chkCaptureFrame->Checked;
}
//---------------------------------------------------------------------------
void __fastcall TFrmWebcam::VideoGrabberMotionNotDetected(TObject *Sender,
      Pointer FrameBitmap, DWORD FrameNumber, Int64 FrameTime, int FrameId,
      bool &CaptureFrame)
{
   shpMotionDetected->Brush->Color = clGreen;
   mmoMotionGrid->Text = VideoGrabber->MotionDetector_Get2DTextMotion();
}
//---------------------------------------------------------------------------
void __fastcall TFrmWebcam::cboVideoDevicesChange(TObject *Sender)
{
   VideoGrabber->VideoDevice = cboVideoDevices->ItemIndex;
}
//---------------------------------------------------------------------------
void __fastcall TFrmWebcam::VideoGrabberVideoDeviceSelected(
      TObject *Sender)
{
   if (cboVideoDevices->ItemIndex != VideoGrabber->VideoDevice) {
      cboVideoDevices->ItemIndex = VideoGrabber->VideoDevice;
   }
   AssignListToComboBox (cboVideoSize, VideoGrabber->VideoSizes, VideoGrabber->VideoSize);
   AssignListToComboBox (cboVideoInput, VideoGrabber->VideoInputs, VideoGrabber->VideoInput);
   AssignListToComboBox (cboAnalogVideoStandard, VideoGrabber->AnalogVideoStandards, VideoGrabber->AnalogVideoStandard);
}
//---------------------------------------------------------------------------
void __fastcall TFrmWebcam::cboVideoSizeChange(TObject *Sender)
{
   VideoGrabber->VideoSize = cboVideoSize->ItemIndex;
}
//---------------------------------------------------------------------------
void __fastcall TFrmWebcam::cboVideoInputChange(TObject *Sender)
{
   VideoGrabber->VideoInput = cboVideoInput->ItemIndex;
}
//---------------------------------------------------------------------------
void __fastcall TFrmWebcam::cboAnalogVideoStandardChange(TObject *Sender)
{
   VideoGrabber->AnalogVideoStandard = cboAnalogVideoStandard->ItemIndex;
}
//---------------------------------------------------------------------------
void __fastcall TFrmWebcam::VideoGrabberLog(TObject *Sender,
      TLogType LogType, String Severity, String InfoMsg)
{
   FrmMaster->mmoLog->Lines->Add (Name + ": " + InfoMsg);
}
//---------------------------------------------------------------------------
