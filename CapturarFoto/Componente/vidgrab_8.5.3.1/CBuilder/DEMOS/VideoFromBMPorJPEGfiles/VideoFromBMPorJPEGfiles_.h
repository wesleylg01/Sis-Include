//---------------------------------------------------------------------------
#ifndef VideoFromBMPorJPEGfiles_H
#define VideoFromBMPorJPEGfiles_H
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include "VidGrab.hpp"
#include <ExtCtrls.hpp>
//---------------------------------------------------------------------------

// TFileSearch: small class around FindFirst and FindNext to make the search easier
class TFileSearch : public TComponent
{
private:
      bool Opened;
      String Path;
      TSearchRec SearchRec;
public:
      __fastcall TFileSearch(TComponent* Owner);
      __fastcall ~TFileSearch();
      String __fastcall FirstFile (String SearchPath, String FileKind);
      String __fastcall NextFile ();
      void __fastcall Close ();
};

class TForm1 : public TForm
{
__published:	// IDE-managed Components
        TLabel *Label1;
        TLabel *Label2;
        TLabel *Label3;
        TVideoGrabber *VideoGrabber;
        TButton *btnStartPreview;
        TEdit *edtFilesLocation;
        TButton *btnStartRecording;
        TButton *btnStop;
        TMemo *mmoLog;
        TButton *btnPlay;
        TEdit *edtFrameProgress;
        TRadioGroup *rdgSearchForBMPorJPEG;
        TEdit *edtRecordingFrameRate;
        TEdit *edtFinalFrameRate;
        TLabel *Label4;
        void __fastcall VideoGrabberLog(TObject *Sender, TLogType LogType,
          String Severity, String InfoMsg);
        void __fastcall FormCreate(TObject *Sender);
        void __fastcall VideoGrabberFrameProgress(TObject *Sender,
          DWORD FrameNumber, Int64 FrameTime, int FrameId);
        void __fastcall btnStartPreviewClick(TObject *Sender);
        void __fastcall btnStartRecordingClick(TObject *Sender);
        void __fastcall btnStopClick(TObject *Sender);
        void __fastcall btnPlayClick(TObject *Sender);
        void __fastcall VideoGrabberInactive(TObject *Sender);
        void __fastcall VideoGrabberPreviewStarted(TObject *Sender);
        void __fastcall VideoGrabberRecordingStarted(TObject *Sender,
          String FileName);
        void __fastcall VideoGrabberPlayerOpened(TObject *Sender);
        void __fastcall VideoGrabberRecordingCompleted(TObject *Sender,
          String FileName, bool Success);
        void __fastcall VideoGrabberAVIDurationUpdated(TObject *Sender,
          String FileName, DWORD FrameCount, double &FrameRate,
          Int64 &Duration);
        void __fastcall VideoGrabberVideoFromBitmapsNextFrameNeeded(
          TObject *Sender, bool FirstSample);
private:	// User declarations
        TFileSearch *SearchForFiles;
        bool __fastcall GetNextBitmap (String &BMPorJPEGfile);
public:		// User declarations
        __fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
