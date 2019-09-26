//---------------------------------------------------------------------------
#ifndef NonVisible_H
#define NonVisible_H
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include <ExtCtrls.hpp>
#include "VidGrab.hpp"
#include <Menus.hpp>
//---------------------------------------------------------------------------
class TForm1 : public TForm
{
__published:	// Composants gérés par l'EDI
        TImage *imgCapturedFrame;
        TGroupBox *GroupBox1;
        TButton *btnCreate;
        TButton *btnCapture;
        TButton *btnDestroy;
        TCheckBox *chkVisible;
        TComboBox *cmbVideoDevices;
        TComboBox *cmbVideoSizes;
        TComboBox *cmbVideoInputs;
        TButton *btnTVTuner;
        void __fastcall btnCreateClick(TObject *Sender);
        void __fastcall btnCaptureClick(TObject *Sender);
        void __fastcall cmbVideoDevicesChange(TObject *Sender);
        void __fastcall cmbVideoSizesChange(TObject *Sender);
        void __fastcall cmbVideoInputsChange(TObject *Sender);
        void __fastcall btnDestroyClick(TObject *Sender);
        void __fastcall btnTVTunerClick(TObject *Sender);
        void __fastcall chkVisibleClick(TObject *Sender);
        void __fastcall FormCreate(TObject *Sender);
private:
        void __fastcall OnVideoDeviceSelected(TObject *Sender);
        void __fastcall OnFrameCaptureCompleted(
             TObject *Sender, Pointer FrameBitmap, int BitmapWidth,
             int BitmapHeight, unsigned FrameNumber, Int64 FrameTime,
             TFrameCaptureDest DestType, String FileName, bool Success,
             int FrameId);
        void __fastcall OnResizeVideo(TObject *Sender, int SourceWidth, int SourceHeight);
public:
        __fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
