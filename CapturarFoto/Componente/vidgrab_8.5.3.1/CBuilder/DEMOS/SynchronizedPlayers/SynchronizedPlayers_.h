//---------------------------------------------------------------------------
#ifndef SynchronizedPlayers_H
#define SynchronizedPlayers_H
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include "VidGrab.hpp"
#include <Buttons.hpp>
#include <Dialogs.hpp>
#include <ExtCtrls.hpp>
#include <ComCtrls.hpp>
//---------------------------------------------------------------------------
class TForm1 : public TForm
{
__published:	// IDE-managed Components
        TSpeedButton *btnPlayerOpenFile;
        TSpeedButton *btnPause;
        TSpeedButton *btnStop;
        TSpeedButton *btnPlay;
        TEdit *edtFileName;
        TVideoGrabber *VideoGrabber2;
        TVideoGrabber *VideoGrabber3;
        TVideoGrabber *VideoGrabber4;
        TVideoGrabber *VideoGrabber1;
        TButton *btnOpen;
        TButton *btnClose;
        TOpenDialog *dlgOpen;
        TTrackBar *TrackBar1;
        TCheckBox *chkSync1;
        TTrackBar *TrackBar2;
        TCheckBox *chkSync2;
        TTrackBar *TrackBar4;
        TCheckBox *chkSync4;
        TTrackBar *TrackBar3;
        TCheckBox *chkSync3;
        void __fastcall btnPlayerOpenFileClick(TObject *Sender);
        void __fastcall btnCloseClick(TObject *Sender);
        void __fastcall btnPauseClick(TObject *Sender);
        void __fastcall btnStopClick(TObject *Sender);
        void __fastcall btnPlayClick(TObject *Sender);
        void __fastcall btnOpenClick(TObject *Sender);
        void __fastcall chkSync1Click(TObject *Sender);
        void __fastcall chkSync2Click(TObject *Sender);
        void __fastcall chkSync3Click(TObject *Sender);
        void __fastcall chkSync4Click(TObject *Sender);
private:	// User declarations
public:		// User declarations
        __fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
