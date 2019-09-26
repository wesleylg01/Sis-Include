//---------------------------------------------------------------------------
#ifndef VideoFromBitmapHandles_H
#define VideoFromBitmapHandles_H
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include "VidGrab.hpp"
#include <ExtCtrls.hpp>
#include <Graphics.hpp>
//---------------------------------------------------------------------------

class TForm1 : public TForm
{
__published:	// IDE-managed Components
        TImage *Image1;
        TImage *Image2;
        TImage *Image3;
        TImage *Image4;
        TVideoGrabber *VideoGrabber;
        TButton *btnStartPreview;
        TButton *btnStartRecording;
        TButton *btnStop;
        TMemo *mmoLog;
        TButton *btnPlay;
        TEdit *edtFrameProgress;
        TLabel *Label2;
        TEdit *edtRecordingFrameRate;
        TEdit *edtFinalFrameRate;
        TLabel *Label4;
        TLabel *Label1;
        TCheckBox *chkMakeBitmapCopy;
        void __fastcall VideoGrabberLog(TObject *Sender, TLogType LogType,
          String Severity, String InfoMsg);
        void __fastcall VideoGrabberFrameProgress(TObject *Sender,
          DWORD FrameNumber, Int64 FrameTime, int FrameId);
        void __fastcall btnStartPreviewClick(TObject *Sender);
        void __fastcall btnStartRecordingClick(TObject *Sender);
        void __fastcall btnStopClick(TObject *Sender);
        void __fastcall btnPlayClick(TObject *Sender);
        void __fastcall VideoGrabberInactive(TObject *Sender);
        void __fastcall VideoGrabberPlayerOpened(TObject *Sender);
        void __fastcall VideoGrabberPreviewStarted(TObject *Sender);
        void __fastcall VideoGrabberRecordingStarted(TObject *Sender,
          String FileName);
        void __fastcall VideoGrabberRecordingCompleted(TObject *Sender,
          String FileName, bool Success);
        void __fastcall VideoGrabberAVIDurationUpdated(TObject *Sender,
          String FileName, DWORD FrameCount, double &FrameRate,
          Int64 &Duration);
        void __fastcall VideoGrabberVideoFromBitmapsNextFrameNeeded(
          TObject *Sender, bool FirstSample);
private:	// User declarations
        int FImageIndex;
public:		// User declarations
        __fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
