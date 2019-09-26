//---------------------------------------------------------------------------
#include <vcl.h>
#pragma hdrstop

#include "VideoFromBMPorJPEGfiles_.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "VidGrab"
#pragma resource "*.dfm"
TForm1 *Form1;

__fastcall TFileSearch::TFileSearch (TComponent* Owner): TComponent (Owner)
{
   Opened = False;
}
//---------------------------------------------------------------------------

String __fastcall TFileSearch::FirstFile (String SearchPath, String FileKind)
{
   String Result = "";

   if (Opened) {
      Close(); // let's close any previous opened search
   }

   if (SearchPath.Length() > 0) { // let's add a trailing slash if required
      if (SearchPath[SearchPath.Length()] == '\\') {
         Path = SearchPath;
      }
      else {
         Path = SearchPath + "\\";
      }
   }
   else {
      Path = ".\\";
   }

   if (FindFirst (Path + FileKind, faAnyFile, SearchRec) == 0) {
      Result = Path + SearchRec.Name;
      Opened = True;
   }
   return Result;
}
//---------------------------------------------------------------------------

String __fastcall TFileSearch::NextFile ()
{
   String Result = "";
   if (Opened) {
      if (FindNext (SearchRec) == 0) {
         Result = Path + SearchRec.Name;
      }
      else {
         Close();
      }
   }
   return Result;
}
//---------------------------------------------------------------------------

void __fastcall TFileSearch::Close ()
{
   if (Opened) {
      FindClose (SearchRec);
      Opened = False;
   }
}
//---------------------------------------------------------------------------

__fastcall TFileSearch::~TFileSearch ()
{
   Close();
   //TComponent::~TComponent ();
}
//---------------------------------------------------------------------------

__fastcall TForm1::TForm1(TComponent* Owner)
        : TForm(Owner)
{
}
//---------------------------------------------------------------------------

void __fastcall TForm1::FormCreate(TObject *Sender)
{
   SearchForFiles = new TFileSearch (this);
}
//---------------------------------------------------------------------------


void __fastcall TForm1::btnStartPreviewClick(TObject *Sender)
{
   VideoGrabber->VideoSource = vs_JPEGsOrBitmaps;
   VideoGrabber->FrameRate = StrToIntDef (edtRecordingFrameRate->Text, 50);
   VideoGrabber->StartPreview();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnStartRecordingClick(TObject *Sender)
{
   VideoGrabber->VideoSource = vs_JPEGsOrBitmaps;
   VideoGrabber->FrameRate = StrToIntDef (edtRecordingFrameRate->Text, 50);
   VideoGrabber->StartRecording();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnStopClick(TObject *Sender)
{
   VideoGrabber->Stop();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnPlayClick(TObject *Sender)
{
   VideoGrabber->PlayerFileName = VideoGrabber->Last_Recording_FileName;
   VideoGrabber->OpenPlayer();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::VideoGrabberFrameProgress(TObject *Sender,
      DWORD FrameNumber, Int64 FrameTime, int FrameId)
{
   edtFrameProgress->Text = "frame # " + IntToStr (FrameNumber);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::VideoGrabberLog(TObject *Sender, TLogType LogType,
      String Severity, String InfoMsg)
{
   mmoLog->Lines->Add (InfoMsg);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::VideoGrabberInactive(TObject *Sender)
{
   mmoLog->Lines->Add ("done.");
}
//---------------------------------------------------------------------------

void __fastcall TForm1::VideoGrabberPreviewStarted(TObject *Sender)
{
   mmoLog->Lines->Add ("previewing");
}
//---------------------------------------------------------------------------

void __fastcall TForm1::VideoGrabberRecordingStarted(TObject *Sender,
      String FileName)
{
   mmoLog->Lines->Add ("recording to: " + FileName);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::VideoGrabberRecordingCompleted(TObject *Sender,
      String FileName, bool Success)
{
   if (Success) {
      mmoLog->Lines->Add ("recording completed: " + FileName);
   }
   else {
      mmoLog->Lines->Add ("recording failed: " + FileName);
   }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::VideoGrabberPlayerOpened(TObject *Sender)
{
   mmoLog->Lines->Add ("playing: " + VideoGrabber->PlayerFileName);
}
//---------------------------------------------------------------------------






void __fastcall TForm1::VideoGrabberAVIDurationUpdated(TObject *Sender,
      String FileName, DWORD FrameCount, double &FrameRate,
      Int64 &Duration)
{
   FrameRate = StrToIntDef (edtFinalFrameRate->Text, 10);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::VideoGrabberVideoFromBitmapsNextFrameNeeded(
      TObject *Sender, bool FirstSample)
{
   String ImageFile;
   bool EndOfData;
   // you can pass to this event:
   // - either the path to a BMP file or a JPEG file (this is the case in this example)
   // - either a the HBITMAP handle of a bitmap (see the VideoFromBitmapHandles demo project)

   // in this version we pass a JPEG or BMP file so BitmapHandle and CanFreeBitmapHandle are not used

   // FirstSample is true the first time the event occurs (useful to know e.g. when a file search must be restarted from the beginning)

   ImageFile = "";
   EndOfData = false;

   if (FirstSample) {
      if (rdgSearchForBMPorJPEG->ItemIndex == 0) {
         ImageFile = SearchForFiles->FirstFile (edtFilesLocation->Text, "*.bmp");
      }
      else {
         ImageFile = SearchForFiles->FirstFile (edtFilesLocation->Text, "*.jpg");
      }
   }
   else {
      ImageFile = SearchForFiles->NextFile();
   }

   if (ImageFile == "") {
      EndOfData = True;
   }
   VideoGrabber->SendImageToVideoFromBitmaps (ImageFile, 0, false, EndOfData);
}
//---------------------------------------------------------------------------

