//---------------------------------------------------------------------------
#include <vcl.h>
#pragma hdrstop

#include "SendVideoCaptureDeviceToDVDevice_.h"
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
void __fastcall AssignListToComboBox (TComboBox* ComboBox, String List, int Index)
{
   ComboBox->Items->Text = List;
   if (ComboBox->Items->Count > 0) {
      ComboBox->ItemIndex = Index;
   }
}
//---------------------------------------------------------------------------
void __fastcall TForm1::FormShow(TObject *Sender)
{
   AssignListToComboBox (cboDestinationDVDevices, VideoGrabber->VideoDevices, 0);
   AssignListToComboBox (cboVideoCaptureDevices, VideoGrabber->VideoDevices, 0);

   // prevents resizing automatically the video window
   VideoGrabber->Display_AutoSize = false;
   VideoGrabber->Display_AspectRatio = ar_Box;

   edtDestinationDVdevice->Text = "";
   edtSourceVideoCaptureDevice->Text = "";
}
//---------------------------------------------------------------------------
void __fastcall TForm1::cboDestinationDVDevicesChange(TObject *Sender)
{
   if (VideoGrabber->IsDVDevice (cboDestinationDVDevices->ItemIndex) ) {
      edtDestinationDVdevice->Text = cboDestinationDVDevices->Items->Strings[cboDestinationDVDevices->ItemIndex];
      VideoGrabber->SendToDV_DeviceIndex = cboDestinationDVDevices->ItemIndex;
   }
   else {
      edtDestinationDVdevice->Text = "THIS IS NOT A DV DEVICE!";
   }
}
//---------------------------------------------------------------------------
void __fastcall TForm1::cboVideoCaptureDevicesChange(TObject *Sender)
{
   edtSourceVideoCaptureDevice->Text = cboVideoCaptureDevices->Items->Strings[cboVideoCaptureDevices->ItemIndex];
   VideoGrabber->SendToDV_DeviceIndex = cboVideoCaptureDevices->ItemIndex;
}
//---------------------------------------------------------------------------
void __fastcall TForm1::VideoGrabberLog(TObject *Sender, TLogType LogType,
      String Severity, String InfoMsg)
{
   int LogTypeValue;

   LogTypeValue = (int) LogType;
   mmoLog->Lines->Add (IntToStr (LogTypeValue) + ": " + InfoMsg);
   if (LogTypeValue == 27 ) {
      mmoLog->Lines->Add ("CHECK:");
      mmoLog->Lines->Add ("- that you have selected a destination DV device (step1)");
      mmoLog->Lines->Add ("- that you have selected a video clip (step 2)");
      mmoLog->Lines->Add ("- that your DV device is in TAPE MODE");
   }
}
//---------------------------------------------------------------------------
void __fastcall TForm1::btnStartClick(TObject *Sender)
{
   VideoGrabber->VideoSource = vs_VideoCaptureDevice;
   VideoGrabber->VideoDevice = cboVideoCaptureDevices->ItemIndex;

   VideoGrabber->SendToDV_DeviceIndex = cboDestinationDVDevices->ItemIndex;
   VideoGrabber->RecordingMethod = rm_SendToDV;

   if (VideoGrabber->VideoDevice == VideoGrabber->SendToDV_DeviceIndex) {
      ShowMessage ("the destination device cannot be used as source!");
   }
   else {
      VideoGrabber->StartRecording();
   }
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Button1Click(TObject *Sender)
{
   VideoGrabber->Stop();
}
//---------------------------------------------------------------------------
