//---------------------------------------------------------------------------

#ifndef miscVideoControlH
#define miscVideoControlH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include <ComCtrls.hpp>
#include "VidGrab.hpp"

//---------------------------------------------------------------------------
class TfrmVideoControl : public TForm
{
__published:	// IDE-managed Components
        TCheckBox *chkFlipVertically;
        TCheckBox *chkFlipHorizontally;
        TCheckBox *chkExternalTrigger;
        TCheckBox *chkEmulateTrigger;
        TButton *Button2;
        void __fastcall Button2Click(TObject *Sender);
        void __fastcall ApplyVideoControlMode(TObject *Sender);
private:	// User declarations
public:		// User declarations
        __fastcall TfrmVideoControl(TComponent* Owner);
        void __fastcall RefreshControls();
};
//---------------------------------------------------------------------------
extern PACKAGE TfrmVideoControl *frmVideoControl;
//---------------------------------------------------------------------------
#endif
