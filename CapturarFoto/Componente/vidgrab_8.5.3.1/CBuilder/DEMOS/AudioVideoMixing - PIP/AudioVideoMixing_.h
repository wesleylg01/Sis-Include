//---------------------------------------------------------------------------
#ifndef AudioVideoMixing_H
#define AudioVideoMixing_H
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include "VidGrab.hpp"
#include <ExtCtrls.hpp>
#include <Dialogs.hpp>
#include <Buttons.hpp>
#include <ComCtrls.hpp>
//---------------------------------------------------------------------------
class TForm1 : public TForm
{
__published:	// IDE-managed Components
        TLabel *Label2;
        TVideoGrabber *VideoGrabberSrc1;
        TButton *btnSrc1Start;
        TButton *btnSrc2Start;
        TVideoGrabber *VideoGrabberSrc2;
        TComboBox *cboVideoDevices1;
        TButton *btnSrc2Stop;
        TButton *btnSrc1Stop;
        TComboBox *cboVideoDevices2;
        TButton *btnSrc1StartRecording;
        TLabel *Label1;
        TOpenDialog *dlgOpen;
        TSpeedButton *btnPlayerOpenFile;
        TSpeedButton *btnMixPlayerOpenFile;
        TButton *btnSrc1PlayLastRecorded;
        TButton *btnSrc2Replay;
        TButton *btnSrc1Replay;
        TTrackBar *tbrSrc1CurrentSourceLevel;
        TLabel *Label3;
        TLabel *Label4;
        TTrackBar *tbrSrc1ExternalSourceLevel;
        TCheckBox *chkCombined;
        void __fastcall FormCreate(TObject *Sender);
        void __fastcall btnSrc1StartClick(TObject *Sender);
        void __fastcall btnSrc1StopClick(TObject *Sender);
        void __fastcall btnSrc2StartClick(TObject *Sender);
        void __fastcall btnSrc2StopClick(TObject *Sender);
        void __fastcall cboVideoDevices1Change(TObject *Sender);
        void __fastcall cboVideoDevices2Change(TObject *Sender);
        void __fastcall VideoGrabberSrc1VideoDeviceSelected(
          TObject *Sender);
        void __fastcall VideoGrabberSrc2VideoDeviceSelected(
          TObject *Sender);
        void __fastcall VideoGrabberSrc1FrameOverlayUsingDC(
          TObject *Sender, HDC Dc, DWORD FrameNumber, Int64 FrameTime,
          int FrameId);
        void __fastcall VideoGrabberSrc2Inactive(TObject *Sender);
        void __fastcall btnSrc1StartRecordingClick(TObject *Sender);
        void __fastcall btnSrcPlayRecordingClick(TObject *Sender);
        void __fastcall VideoGrabberSrc2FrameOverlayUsingDC(
          TObject *Sender, HDC Dc, DWORD FrameNumber, Int64 FrameTime,
          int FrameId);
        void __fastcall btnPlayerOpenFileClick(TObject *Sender);
        void __fastcall FormDestroy(TObject *Sender);
        void __fastcall VideoGrabberSrc2RawAudioSample(TObject *Sender,
          Pointer pSampleBuffer, int SampleBufferSize,
          int SampleDataLength, TFormatType FormatType, Pointer pFormat,
          Pointer pWaveFormatEx, Int64 SampleStartTime,
          Int64 SampleStopTime);
        void __fastcall btnMixPlayerOpenFileClick(TObject *Sender);
        void __fastcall btnSrc1PlayLastRecordedClick(TObject *Sender);
        void __fastcall btnSrc1ReplayClick(TObject *Sender);
        void __fastcall btnSrc2ReplayClick(TObject *Sender);
        void __fastcall tbrSrc1CurrentSourceLevelChange(TObject *Sender);
        void __fastcall tbrSrc1ExternalSourceLevelChange(TObject *Sender);
        void __fastcall chkCombinedClick(TObject *Sender);
        void __fastcall FormCloseQuery(TObject *Sender, bool &CanClose);
private:	// User declarations
        bool FFormClosing;
        Graphics::TBitmap *FPIPBitmap;
        TRTLCriticalSection csOverlay;
public:		// User declarations
        __fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
