//---------------------------------------------------------------------------
#ifndef SendVideoCaptureDeviceToDVDevice_H
#define SendVideoCaptureDeviceToDVDevice_H
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
        TLabel *Label1;
        TLabel *Label2;
        TLabel *Label5;
        TLabel *Label6;
        TComboBox *cboDestinationDVDevices;
        TVideoGrabber *VideoGrabber;
        TEdit *edtDestinationDVdevice;
        TButton *btnStart;
        TMemo *mmoLog;
        TButton *Button1;
        TLabel *Label3;
        TComboBox *cboVideoCaptureDevices;
        TLabel *Label4;
        TEdit *edtSourceVideoCaptureDevice;
        TLabel *Label7;
        void __fastcall FormShow(TObject *Sender);
        void __fastcall cboDestinationDVDevicesChange(TObject *Sender);
        void __fastcall cboVideoCaptureDevicesChange(TObject *Sender);
        void __fastcall VideoGrabberLog(TObject *Sender, TLogType LogType,
          String Severity, String InfoMsg);
        void __fastcall btnStartClick(TObject *Sender);
        void __fastcall Button1Click(TObject *Sender);
private:	// User declarations
public:		// User declarations
        __fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
