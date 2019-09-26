//---------------------------------------------------------------------------
#ifndef SendVideoClipToDVDevice_H
#define SendVideoClipToDVDevice_H
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
        TComboBox *cboVideoDevices;
        TVideoGrabber *VideoGrabber;
        TEdit *edtDestinationDVdevice;
        TLabel *Label1;
        TLabel *Label2;
        TSpeedButton *btnPlayerOpenFile;
        TEdit *edtVideoClip;
        TLabel *Label3;
        TLabel *Label4;
        TLabel *Label5;
        TButton *btnStart;
        TOpenDialog *dlgOpen;
        TMemo *mmoLog;
        TButton *Button1;
        TLabel *Label6;
        void __fastcall FormShow(TObject *Sender);
        void __fastcall cboVideoDevicesChange(TObject *Sender);
        void __fastcall btnPlayerOpenFileClick(TObject *Sender);
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
