//---------------------------------------------------------------------------
#include "CaptureService_.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"

TService1 *Service1;
//---------------------------------------------------------------------------
__fastcall TService1::TService1(TComponent* Owner)
	: TService(Owner)
{
}

//---------------------------------------------------------------------------
TServiceController __fastcall TService1::GetServiceController(void)
{
	return (TServiceController) ServiceController;
}

//---------------------------------------------------------------------------
void __stdcall ServiceController(unsigned CtrlCode)
{
	Service1->Controller(CtrlCode);
}

//---------------------------------------------------------------------------
void __fastcall TService1::ExecuteService (void)
{
   VideoGrabber->CaptureFrameTo (fc_JpegFile, "");
}

//---------------------------------------------------------------------------
void __fastcall TService1::ServiceCreate(TObject *Sender)
{
   VideoGrabber = new TVideoGrabber((TComponent*) NULL);
   VideoGrabber->StoragePath = "c:\mycapture";
}

//---------------------------------------------------------------------------
void __fastcall TService1::ServiceDestroy(TObject *Sender)
{
	delete (VideoGrabber);
}
//---------------------------------------------------------------------------
void __fastcall TService1::ServiceExecute(TService *Sender)
{
	while (! Terminated) {
                ExecuteService();
		ServiceThread->ProcessRequests (true);
		Sleep (5000);
	}
}
//---------------------------------------------------------------------------
void __fastcall TService1::ServiceStart(TService *Sender, bool &Started)
{
	VideoGrabber->StartPreview();
}
//---------------------------------------------------------------------------
void __fastcall TService1::ServiceStop(TService *Sender, bool &Stopped)
{
	VideoGrabber->StopPreview();
}
//---------------------------------------------------------------------------

