//---------------------------------------------------------------------------
#include <vcl.h>
#pragma hdrstop
USERES("MainDemo.res");
USEFORM("MainForm.cpp", frmMainForm);
USEFORM("miscVideoQuality.cpp", frmVideoQuality);
USEFORM("miscCameraControl.cpp", frmCameraControl);
USEFORM("miscVideoControl.cpp", frmVideoControl);
USEFORM("miscSpecialControl.cpp", frmSpecialControls);
//---------------------------------------------------------------------------
WINAPI WinMain(HINSTANCE, HINSTANCE, LPSTR, int)
{
        try
        {
                 Application->Initialize();
                 Application->CreateForm(__classid(TfrmMainForm), &frmMainForm);
                 Application->CreateForm(__classid(TfrmVideoQuality), &frmVideoQuality);
                 Application->CreateForm(__classid(TfrmCameraControl), &frmCameraControl);
                 Application->CreateForm(__classid(TfrmVideoControl), &frmVideoControl);
                 Application->CreateForm(__classid(TfrmSpecialControls), &frmSpecialControls);
                 Application->Run();
        }
        catch (Exception &exception)
        {
                 Application->ShowException(&exception);
        }
        return 0;
}
//---------------------------------------------------------------------------
