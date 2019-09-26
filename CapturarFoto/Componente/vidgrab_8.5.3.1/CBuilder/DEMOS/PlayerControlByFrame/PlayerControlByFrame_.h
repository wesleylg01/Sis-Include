//---------------------------------------------------------------------------
#ifndef PlayerControlByFrame_H
#define PlayerControlByFrame_H
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include "VidGrab.hpp"
#include <Buttons.hpp>
#include <Dialogs.hpp>
#include <ExtCtrls.hpp>
//---------------------------------------------------------------------------
class TForm1 : public TForm
{
__published:	// IDE-managed Components
        TSpeedButton *btnPlayerOpenFile;
        TImage *Image1;
        TVideoGrabber *VideoGrabber;
        TEdit *edtPlayerClip;
        TButton *btnOpenClip;
        TMemo *MemoLog;
        TGroupBox *GroupBox1;
        TSpeedButton *btnStop;
        TSpeedButton *btnPlay;
        TSpeedButton *btnPause;
        TGroupBox *GroupBox2;
        TEdit *edtReachFrameNumber;
        TButton *btnReachFrame;
        TOpenDialog *dlgOpen;
        TCheckBox *chkUseClock;
        void __fastcall btnPlayerOpenFileClick(TObject *Sender);
        void __fastcall btnOpenClipClick(TObject *Sender);
        void __fastcall btnPlayClick(TObject *Sender);
        void __fastcall btnPauseClick(TObject *Sender);
        void __fastcall btnStopClick(TObject *Sender);
        void __fastcall VideoGrabberFrameProgress(TObject *Sender,
          DWORD FrameNumber, Int64 FrameTime, int FrameId);
        void __fastcall VideoGrabberFrameCaptureCompleted(TObject *Sender,
          Pointer FrameBitmap, int BitmapWidth, int BitmapHeight,
          DWORD FrameNumber, Int64 FrameTime, TFrameCaptureDest DestType,
          String FileName, bool Success, int FrameId);
        void __fastcall FormCreate(TObject *Sender);
        void __fastcall chkUseClockClick(TObject *Sender);
private:	// User declarations
public:		// User declarations
        __fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
