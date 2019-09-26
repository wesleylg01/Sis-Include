#include <SysUtils.hpp>
#include <SvcMgr.hpp>
#pragma hdrstop
#define Application Svcmgr::Application
USERES("CaptureService.res");
USEFORM("CaptureService_.cpp", Service1); /* TService: File Type */
//---------------------------------------------------------------------------
WINAPI WinMain(HINSTANCE, HINSTANCE, LPSTR, int)
{
	try
	{
		Application->Initialize();
		Application->CreateForm(__classid(TService1), &Service1);
                 Application->Run();
	}
	catch (Exception &exception)
	{
		Sysutils::ShowException(&exception, Sysutils::ExceptAddr());
	}
	return 0;
}
