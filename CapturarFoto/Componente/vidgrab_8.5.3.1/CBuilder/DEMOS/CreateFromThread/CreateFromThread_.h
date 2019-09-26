//---------------------------------------------------------------------------
#ifndef CreateFromThread_H
#define CreateFromThread_H
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include "Vidgrab.hpp"
//---------------------------------------------------------------------------

class TVideoGrabberThread : public TThread
{
__published:
private:
   TVideoGrabber *VideoGrabber;
public:
        __fastcall TVideoGrabberThread(bool CreateSuspended);
        virtual void __fastcall Execute(void);
};


class TForm1 : public TForm
{
__published:	// IDE-managed Components
        TButton *Button1;
        void __fastcall Button1Click(TObject *Sender);
        void __fastcall FormCloseQuery(TObject *Sender, bool &CanClose);
private:
        TVideoGrabberThread *VideoGrabberThread;
public:
        __fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
