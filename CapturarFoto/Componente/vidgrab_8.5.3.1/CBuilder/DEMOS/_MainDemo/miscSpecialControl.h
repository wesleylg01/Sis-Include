//---------------------------------------------------------------------------
#ifndef miscSpecialControlH
#define miscSpecialControlH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include <ExtCtrls.hpp>
//---------------------------------------------------------------------------
class TfrmSpecialControls : public TForm
{
__published:	// IDE-managed Components
        TGroupBox *GroupBox1;
        TButton *btnPanTiltUp;
        TButton *btnPanTiltLeft;
        TButton *btnPanTiltHome;
        TButton *btnPanTiltRight;
        TButton *btnPanTiltDown;
        TRadioGroup *rdgGpio0;
        TRadioGroup *rdgGpio1;
        TRadioGroup *rdgGpio2;
        TRadioGroup *rdgGpio3;
        void __fastcall btnPanTiltHomeClick(TObject *Sender);
        void __fastcall btnPanTiltRightClick(TObject *Sender);
        void __fastcall btnPanTiltLeftClick(TObject *Sender);
        void __fastcall btnPanTiltUpClick(TObject *Sender);
        void __fastcall btnPanTiltDownClick(TObject *Sender);
        void __fastcall rdgGpio0Click(TObject *Sender);
        void __fastcall rdgGpio2Click(TObject *Sender);
        void __fastcall rdgGpio1Click(TObject *Sender);
        void __fastcall rdgGpio3Click(TObject *Sender);
private:	// User declarations
public:		// User declarations
        __fastcall TfrmSpecialControls(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TfrmSpecialControls *frmSpecialControls;
//---------------------------------------------------------------------------
#endif
