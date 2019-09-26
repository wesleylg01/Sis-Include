//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "FrameCapture_.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "VidGrab"
#pragma link "VidGrab"
#pragma resource "*.dfm"
TForm1 *Form1;
//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
        : TForm(Owner)
{
}
void __fastcall TForm1::FormCreate(TObject *Sender)
{
   ComboBox1->Items->Text = VideoGrabber1->VideoDevices;
   ComboBox1->ItemIndex = VideoGrabber1->VideoDevice;

   Edit1->Text = IntToStr (VideoGrabber1->BurstCount);
   Edit3->Text = IntToStr (VideoGrabber1->BurstInterval);

   Memo1->Lines->Add ("storage: " + VideoGrabber1->StoragePath);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button3Click(TObject *Sender)
{
   VideoGrabber1->StartPreview();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button8Click(TObject *Sender)
{
   VideoGrabber1->StopPreview();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button11Click(TObject *Sender)
{
   VideoGrabber1->BurstType = fc_TBitmap;
   VideoGrabber1->BurstMode = True;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button1Click(TObject *Sender)
{
   VideoGrabber1->BurstType = fc_JpegFile;
   VideoGrabber1->BurstMode = True;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button5Click(TObject *Sender)
{
   VideoGrabber1->BurstType = fc_BmpFile;
   VideoGrabber1->BurstMode = True;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button2Click(TObject *Sender)
{
   VideoGrabber1->BurstMode = False;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button4Click(TObject *Sender)
{
   VideoGrabber1->CaptureFrameTo (fc_TBitmap, "");
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button6Click(TObject *Sender)
{
   if (CheckBox3->Checked) {
      VideoGrabber1->CaptureFrameTo (fc_JpegFile, "");
   }
   else {
      VideoGrabber1->CaptureFrameTo (fc_JpegFile, Edit2->Text);
   }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button7Click(TObject *Sender)
{
   if (CheckBox3->Checked) {
      VideoGrabber1->CaptureFrameTo (fc_BmpFile, "");
   }
   else {
      VideoGrabber1->CaptureFrameTo (fc_BmpFile, Edit2->Text);
   }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::VideoGrabber1VideoDeviceSelected(TObject *Sender)
{
   ComboBox1->ItemIndex = VideoGrabber1->VideoDevice;

   ComboBox2->Items->Text = VideoGrabber1->AnalogVideoStandards;
   ComboBox2->ItemIndex = VideoGrabber1->AnalogVideoStandard;
   ComboBox2->Enabled = VideoGrabber1->IsAnalogVideoDecoderAvailable;

   ComboBox4->Items->Text = VideoGrabber1->VideoInputs;
   ComboBox4->ItemIndex = VideoGrabber1->VideoInput;

   ComboBox5->Items->Text = VideoGrabber1->VideoSizes;
   ComboBox5->ItemIndex = VideoGrabber1->VideoSize;

   Button10->Enabled = VideoGrabber1->IsTVTunerAvailable;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::VideoGrabber1ResizeVideo(TObject *Sender,
      int SourceWidth, int SourceHeight)
{
   int NewWidth;

   Image1->Picture->Assign (NULL);
   Image1->Left = VideoGrabber1->Left + VideoGrabber1->Width + 20;
   Image1->Width = VideoGrabber1->VideoWidth;
   Image1->Height = VideoGrabber1->VideoHeight;
   NewWidth = Image1->Left + VideoGrabber1->Width + 20;
   if (NewWidth < GroupBox3->Width + 20) {
      NewWidth = GroupBox3->Width + 20;
   }
   Height = VideoGrabber1->Top + VideoGrabber1->Height + 75;
   Width = NewWidth;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button9Click(TObject *Sender)
{
   VideoGrabber1->ShowDialog (dlg_VideoDevice);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button10Click(TObject *Sender)
{
   VideoGrabber1->ShowDialog (dlg_TVTuner);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::ComboBox1Change(TObject *Sender)
{
   VideoGrabber1->VideoDevice = ComboBox1->ItemIndex;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::ComboBox2Change(TObject *Sender)
{
   VideoGrabber1->AnalogVideoStandard = ComboBox2->ItemIndex;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::ComboBox4Change(TObject *Sender)
{
   VideoGrabber1->VideoInput = ComboBox4->ItemIndex;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::ComboBox5Change(TObject *Sender)
{
   VideoGrabber1->VideoSize = ComboBox5->ItemIndex;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Edit1Change(TObject *Sender)
{
   VideoGrabber1->BurstCount = StrToIntDef (Edit1->Text, 0);
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Edit3Change(TObject *Sender)
{
   VideoGrabber1->BurstInterval = StrToIntDef (Edit3->Text, 0);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::CheckBox3Click(TObject *Sender)
{
   Edit2->Enabled = ! CheckBox3->Checked; // if the file name is not generated automatically, it can be entered
}
//---------------------------------------------------------------------------



void __fastcall TForm1::VideoGrabber1FrameCaptureCompleted(TObject *Sender,
      Pointer FrameBitmap, int BitmapWidth, int BitmapHeight,
      DWORD FrameNumber, Int64 FrameTime, TFrameCaptureDest DestType,
      String FileName, bool Success, int FrameId)
{
   Graphics::TBitmap *Frame_Bitmap;

   Frame_Bitmap = (Graphics::TBitmap*) FrameBitmap;

   switch (DestType) {
      case fc_BmpFile:
         Memo1->Lines->Add (FileName + " created");
      break;

      case fc_JpegFile:
         Memo1->Lines->Add (FileName + " created");
      break;

      case fc_TBitmap:

      bool AlternateMethod = False; // you can choose one of the 2 methods below (set True to test the 2nd)

      if (! AlternateMethod) { // this code reassign the bitmap handle to the picture (saves CPU)
         Image1->Picture->Bitmap->Handle = Frame_Bitmap->Handle;
         Frame_Bitmap->ReleaseHandle();
      }
      else { // this code makes a copy of the bitmap
         Image1->Picture->Assign (Frame_Bitmap);
      }
      break;
   }
}
//---------------------------------------------------------------------------

