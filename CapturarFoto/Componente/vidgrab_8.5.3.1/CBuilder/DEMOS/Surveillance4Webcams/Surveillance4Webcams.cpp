//---------------------------------------------------------------------------
#include <vcl.h>
#pragma hdrstop
USERES("Surveillance4Webcams.res");
USEFORM("Surveillance4Webcams_.cpp", FrmMaster);
USEFORM("WebcamControl.cpp", FrmWebcam);
//---------------------------------------------------------------------------
WINAPI WinMain(HINSTANCE, HINSTANCE, LPSTR, int)
{
        try
        {
                 Application->Initialize();
                 Application->CreateForm(__classid(TFrmMaster), &FrmMaster);
                 Application->CreateForm(__classid(TFrmWebcam), &FrmWebcam);
                 Application->Run();
        }
        catch (Exception &exception)
        {
                 Application->ShowException(&exception);
        }
        return 0;
}
//---------------------------------------------------------------------------
