//---------------------------------------------------------------------------
#ifndef MixedVideoSources_H
#define MixedVideoSources_H
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include "VidGrab.hpp"
#include <ExtCtrls.hpp>
//---------------------------------------------------------------------------
class TForm1 : public TForm
{
__published:	// IDE-managed Components
        TVideoGrabber *VideoGrabberSrc1;
        TButton *btnSrc1Start;
        TButton *btnSrc2Start;
        TVideoGrabber *VideoGrabberSrc2;
        TButton *btnSrc2Stop;
        TButton *btnSrc1Stop;
        TLabel *Label2;
        TLabel *Label1;
        TLabel *Label3;
        TComboBox *cboVideoDevices1;
        TComboBox *cboVideoDevices2;
        TGroupBox *GroupBox1;
        TLabel *Label4;
        TLabel *Label5;
        TLabel *Label6;
        TLabel *Label7;
        TButton *btnDestStart;
        TEdit *edtMaxSwapFrameCount;
        TEdit *edtDestWidth;
        TEdit *edtDestHeight;
        TButton *btnSizeOk;
        TCheckBox *chkStopWhenAllDown;
        TButton *btnStartRecording;
        TButton *Button2;
        TEdit *edtOutputFrameRate;
        TButton *btnFrameRateOk;
        TButton *btnPlayRecorded;
        TVideoGrabber *VideoGrabberDest;
        TMemo *mmoLog;
        void __fastcall FormCreate(TObject *Sender);
        void __fastcall btnSrc1StartClick(TObject *Sender);
        void __fastcall btnSrc1StopClick(TObject *Sender);
        void __fastcall btnSrc2StartClick(TObject *Sender);
        void __fastcall btnSrc2StopClick(TObject *Sender);
        void __fastcall btnDestStartClick(TObject *Sender);
        void __fastcall btnDestStopClick(TObject *Sender);
        void __fastcall VideoGrabberSrcFrameCaptureCompleted(
          TObject *Sender, Pointer FrameBitmap, int BitmapWidth,
          int BitmapHeight, DWORD FrameNumber, Int64 FrameTime,
          TFrameCaptureDest DestType, String FileName, bool Success,
          int FrameId);
        void __fastcall cboVideoDevices1Change(TObject *Sender);
        void __fastcall cboVideoDevices2Change(TObject *Sender);
        void __fastcall btnSizeOkClick(TObject *Sender);
        void __fastcall edtMaxSwapFrameCountChange(TObject *Sender);
        void __fastcall VideoGrabberSrcInactive(TObject *Sender);
        void __fastcall VideoGrabberSrc1VideoDeviceSelected(
          TObject *Sender);
        void __fastcall VideoGrabberSrc2VideoDeviceSelected(
          TObject *Sender);
        void __fastcall btnFrameRateOkClick(TObject *Sender);
        void __fastcall btnStartRecordingClick(TObject *Sender);
        void __fastcall btnPlayRecordedClick(TObject *Sender);
        void __fastcall VideoGrabberDestLog(TObject *Sender,
          TLogType LogType, String Severity, String InfoMsg);
        void __fastcall VideoGrabberDestRecordingStarted(TObject *Sender,
          String FileName);
        void __fastcall VideoGrabberDestPlayerOpened(TObject *Sender);
        void __fastcall VideoGrabberDestVideoFromBitmapsNextFrameNeeded(
          TObject *Sender, bool FirstSample);
private:	// User declarations
        int FSwapFrameCount;
        int FMaxSwapFrameCount;
        TVideoGrabber *FVideoGrabbers[2];
        int FSourceIndex;
        Graphics::TBitmap *FCurrentBitmap;
        int FDestWidth;
        int FDestHeight;
        bool FAllSourcesStopped;
        bool FCurrentBitmapInUse;
        void __fastcall SwapToNextSource (void);
public:		// User declarations
        __fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
