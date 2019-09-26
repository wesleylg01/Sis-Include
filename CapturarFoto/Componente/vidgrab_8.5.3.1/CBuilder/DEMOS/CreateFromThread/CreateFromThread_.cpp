//---------------------------------------------------------------------------
#include <vcl.h>
#pragma hdrstop

#include "CreateFromThread_.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TForm1 *Form1;
//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
        : TForm(Owner)
{
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button1Click(TObject *Sender)
{
   if (VideoGrabberThread == NULL) {
      VideoGrabberThread = new TVideoGrabberThread(true);
      VideoGrabberThread->Resume();
   }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::FormCloseQuery(TObject *Sender, bool &CanClose)
{
   if (VideoGrabberThread) {
     VideoGrabberThread->Terminate();
     VideoGrabberThread->WaitFor(); // we have to wait for the thread stop to be completed to avoid a crash because Form3 does not exist anymore
     VideoGrabberThread = NULL;
   }
   CanClose = true;
}
//---------------------------------------------------------------------------

__fastcall TVideoGrabberThread::TVideoGrabberThread( bool CreateSuspended):TThread(CreateSuspended)
{
   Priority = tpLower;
}
//---------------------------------------------------------------------------

void __fastcall TVideoGrabberThread::Execute()
{
   VideoGrabber = new TVideoGrabber((TComponent*) NULL);  // the component must be created and assigned the Parent from the thread
   VideoGrabber->Parent = Form1;
   VideoGrabber->Display_AspectRatio = ar_Box;
   VideoGrabber->Align = alClient;
   VideoGrabber->BorderStyle = bsNone;
   VideoGrabber->IPCameraURL = "http://webkamera.kristinehamn.se/axis-cgi/mjpg/video.cgi";
   VideoGrabber->VideoSource = vs_IPCamera;
   //VideoGrabber->SetAuthentication (at_IPCamera, 'yourusername', 'yourpassword');
   VideoGrabber->StartPreview();

   // thread loop
   while (! Terminated) {
      Sleep(50);
      Application->HandleMessage(); /// the main trick is there, see https://forums.embarcadero.com/thread.jspa?threadID=37272
   }

   delete(VideoGrabber); // let's free it when the thread is terminated
}
//---------------------------------------------------------------------------

