//---------------------------------------------------------------------------
#ifndef PictureInPictureMixer_H
#define PictureInPictureMixer_H
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
__published:	// Composants gérés par l'EDI
        TLabel *Label1;
        TLabel *Label3;
        TLabel *Label4;
        TLabel *Label2;
        TLabel *Label8;
        TSpeedButton *btnOpenClipA;
        TLabel *Label9;
        TSpeedButton *btnOpenClipB;
        TVideoGrabber *VideoGrabberSrc1;
        TButton *btnSrc1Start;
        TButton *btnSrc2Start;
        TVideoGrabber *VideoGrabberSrc2;
        TComboBox *cboVideoDevices1;
        TButton *btnSrc2Stop;
        TButton *btnSrc1Stop;
        TComboBox *cboVideoDevices2;
        TGroupBox *GroupBox1;
        TLabel *Label5;
        TLabel *Label6;
        TLabel *Label7;
        TButton *btnDestStart;
        TEdit *edtDestWidth;
        TEdit *edtDestHeight;
        TButton *btnSizeOk;
        TButton *btnStartRecording;
        TButton *Button2;
        TEdit *edtOutputFrameRate;
        TButton *btnFrameRateOk;
        TButton *btnPlayRecorded;
        TVideoGrabber *VideoGrabberMixer;
        TCheckBox *ChkSendToMixer1;
        TMemo *mmoLog;
        TCheckBox *ChkSendToMixer2;
        TCheckBox *chkPipA;
        TEdit *edtLeftA;
        TEdit *edtTopA;
        TEdit *edtWidthA;
        TEdit *edtHeightA;
        TCheckBox *chkPipB;
        TEdit *edtLeftB;
        TEdit *edtTopB;
        TEdit *edtWidthB;
        TEdit *edtHeightB;
        TButton *btnMoveToTop;
        TButton *Button1;
        TButton *btnPlayClipA;
        TButton *btnStopClipA;
        TButton *btnPlayClipB;
        TButton *btnStopClipB;
        TOpenDialog *OpenDialog;
        void __fastcall FormCreate(TObject *Sender);
        void __fastcall btnSizeOkClick(TObject *Sender);
        void __fastcall btnSrc1StartClick(TObject *Sender);
        void __fastcall btnSrc1StopClick(TObject *Sender);
        void __fastcall btnSrc2StartClick(TObject *Sender);
        void __fastcall btnSrc2StopClick(TObject *Sender);
        void __fastcall btnDestStartClick(TObject *Sender);
        void __fastcall Button2Click(TObject *Sender);
        void __fastcall cboVideoDevices1Change(TObject *Sender);
        void __fastcall cboVideoDevices2Change(TObject *Sender);
        void __fastcall SetPIPA(TObject *Sender);
        void __fastcall SetPIPB(TObject *Sender);
        void __fastcall VideoGrabberLog(TObject *Sender, TLogType LogType, String Severity, String InfoMsg);
        void __fastcall ChkSendToMixer1Click(TObject *Sender);
        void __fastcall ChkSendToMixer2Click(TObject *Sender);
        void __fastcall btnStartRecordingClick(TObject *Sender);
        void __fastcall btnPlayRecordedClick(TObject *Sender);
        void __fastcall btnFrameRateOkClick(TObject *Sender);
        void __fastcall VideoGrabberSrc1VideoDeviceSelected(
          TObject *Sender);
        void __fastcall VideoGrabberSrc2VideoDeviceSelected(
          TObject *Sender);
        void __fastcall VideoGrabberMixerPreviewStarted(TObject *Sender);
        void __fastcall VideoGrabberMixerRecordingStarted(TObject *Sender,
          String FileName);
        void __fastcall VideoGrabberMixerPlayerOpened(TObject *Sender);
        void __fastcall btnOpenClipAClick(TObject *Sender);
        void __fastcall btnOpenClipBClick(TObject *Sender);
        void __fastcall btnPlayClipAClick(TObject *Sender);
        void __fastcall btnPlayClipBClick(TObject *Sender);
        void __fastcall btnStopClipAClick(TObject *Sender);
        void __fastcall btnStopClipBClick(TObject *Sender);
private:
        int FCurrentMixer1ID;
        int FCurrentMixer2ID;
public:
        __fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
