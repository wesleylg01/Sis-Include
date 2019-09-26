//---------------------------------------------------------------------------
#ifndef WebcamControlH
#define WebcamControlH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include "VidGrab.hpp"
#include <ComCtrls.hpp>
#include <ExtCtrls.hpp>
//---------------------------------------------------------------------------
class TFrmWebcam : public TForm
{
__published:	// IDE-managed Components
        TLabel *Label2;
        TLabel *Label1;
        TLabel *Label3;
        TShape *shpMotionDetected;
        TLabel *Label4;
        TLabel *Label5;
        TLabel *Label6;
        TLabel *Label7;
        TEdit *edtGlobalSensitivity;
        TUpDown *updGlobalSensitivity;
        TEdit *edtMaxDetectionsPerSecond;
        TUpDown *updMaxDetectionsPerSecond;
        TMemo *mmoMotionGrid;
        TComboBox *cboVideoDevices;
        TComboBox *cboVideoSize;
        TComboBox *cboVideoInput;
        TComboBox *cboAnalogVideoStandard;
        TVideoGrabber *VideoGrabber;
        TButton *StartPreview1;
        TButton *StopPreview1;
        TButton *StartRecording1;
        TButton *StopRecording1;
        TButton *StartPlayback1;
        TButton *StopPlayback2;
        TCheckBox *chkCaptureFrame;
        void __fastcall FormCreate(TObject *Sender);
        void __fastcall updGlobalSensitivityClick(TObject *Sender,
          TUDBtnType Button);
        void __fastcall updMaxDetectionsPerSecondClick(TObject *Sender,
          TUDBtnType Button);
        void __fastcall StartPreview1Click(TObject *Sender);
        void __fastcall StopPreview1Click(TObject *Sender);
        void __fastcall StartRecording1Click(TObject *Sender);
        void __fastcall StopRecording1Click(TObject *Sender);
        void __fastcall StartPlayback1Click(TObject *Sender);
        void __fastcall StopPlayback2Click(TObject *Sender);
        void __fastcall VideoGrabberMotionDetected(TObject *Sender,
          double GlobalMotionRatio, int MaxMotionCellX, int MaxMotionCellY,
          Pointer FrameBitmap, DWORD FrameNumber, Int64 FrameTime,
          int FrameId, bool &CaptureFrame);
        void __fastcall VideoGrabberMotionNotDetected(TObject *Sender,
          Pointer FrameBitmap, DWORD FrameNumber, Int64 FrameTime,
          int FrameId, bool &CaptureFrame);
        void __fastcall cboVideoDevicesChange(TObject *Sender);
        void __fastcall VideoGrabberVideoDeviceSelected(TObject *Sender);
        void __fastcall cboVideoSizeChange(TObject *Sender);
        void __fastcall cboVideoInputChange(TObject *Sender);
        void __fastcall cboAnalogVideoStandardChange(TObject *Sender);
        void __fastcall VideoGrabberLog(TObject *Sender, TLogType LogType,
          String Severity, String InfoMsg);
private:	// User declarations
public:		// User declarations
        __fastcall TFrmWebcam(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TFrmWebcam *FrmWebcam;
//---------------------------------------------------------------------------
#endif
