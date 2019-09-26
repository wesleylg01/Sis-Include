//---------------------------------------------------------------------------
#include <vcl.h>
#pragma hdrstop

#include "SendVideoClipToDVDevice_.h"
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
   AssignListToComboBox (cboVideoDevices, VideoGrabber->VideoDevices, VideoGrabber->VideoDevice);

   // prevents resizing automatically the video window
   VideoGrabber->Display_AutoSize = false;
   VideoGrabber->Display_AspectRatio = ar_Box;

}
//---------------------------------------------------------------------------
void __fastcall TForm1::cboVideoDevicesChange(TObject *Sender)
{
   if (VideoGrabber->IsDVDevice (cboVideoDevices->ItemIndex) ) {
      edtDestinationDVdevice->Text = cboVideoDevices->Items->Strings[cboVideoDevices->ItemIndex];
      VideoGrabber->SendToDV_DeviceIndex = cboVideoDevices->ItemIndex;
   }
   else {
      edtDestinationDVdevice->Text = "THIS IS NOT A DV DEVICE!";
   }
}
//---------------------------------------------------------------------------
void __fastcall TForm1::btnPlayerOpenFileClick(TObject *Sender)
{
   dlgOpen->FileName = "*.mpg;*.mpeg;*.vro;*.avi;*.wav;*.asf;*.wmv;*.vob";
   if (dlgOpen->Execute()) {
      edtVideoClip->Text = dlgOpen->FileName;
   }
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
   VideoGrabber->VideoSource = vs_VideoFileOrURL;
   VideoGrabber->VideoSource_FileOrURL = edtVideoClip->Text;
   VideoGrabber->RecordingMethod = rm_SendToDV;
   VideoGrabber->StartRecording();
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Button1Click(TObject *Sender)
{
   VideoGrabber->Stop();
}
//---------------------------------------------------------------------------
