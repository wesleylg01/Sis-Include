//---------------------------------------------------------------------------
#ifndef Surveillance4Webcams_H
#define Surveillance4Webcams_H
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
//---------------------------------------------------------------------------
class TFrmMaster : public TForm
{
__published:	// IDE-managed Components
        TMemo *mmoLog;
        TButton *btnStartMaster;
        TButton *btnStopMaster;
        void __fastcall btnStartMasterClick(TObject *Sender);
        void __fastcall btnStopMasterClick(TObject *Sender);
        void __fastcall FormShow(TObject *Sender);
private:	// User declarations
   TFrmWebcam *FrmWebcam1;
   TFrmWebcam *FrmWebcam2;
   TFrmWebcam *FrmWebcam3;
   TFrmWebcam *FrmWebcam4;
public:		// User declarations
        __fastcall TFrmMaster(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TFrmMaster *FrmMaster;
//---------------------------------------------------------------------------
#endif
