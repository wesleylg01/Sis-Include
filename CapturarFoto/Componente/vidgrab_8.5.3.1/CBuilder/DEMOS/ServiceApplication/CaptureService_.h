//---------------------------------------------------------------------------
#ifndef CaptureService_H
#define CaptureService_H
//---------------------------------------------------------------------------
#include <SysUtils.hpp>
#include <Classes.hpp>
#include <SvcMgr.hpp>
#include <vcl.h>
#include <VidGrab.hpp>
//---------------------------------------------------------------------------
class TService1 : public TService
{
__published:    // IDE-managed Components
        void __fastcall ServiceCreate(TObject *Sender);
        void __fastcall ServiceDestroy(TObject *Sender);
        void __fastcall ServiceExecute(TService *Sender);
        void __fastcall ServiceStart(TService *Sender, bool &Started);
        void __fastcall ServiceStop(TService *Sender, bool &Stopped);
private:        // User declarations
        TVideoGrabber *VideoGrabber;
        void __fastcall ExecuteService (void);
public:         // User declarations
	__fastcall TService1(TComponent* Owner);
	TServiceController __fastcall GetServiceController(void);

	friend void __stdcall ServiceController(unsigned CtrlCode);
};
//---------------------------------------------------------------------------
extern PACKAGE TService1 *Service1;
//---------------------------------------------------------------------------
#endif
