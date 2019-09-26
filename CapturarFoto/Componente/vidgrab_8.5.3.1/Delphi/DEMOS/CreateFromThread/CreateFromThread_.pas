unit CreateFromThread_;

interface

uses
  Windows, Messages, SysUtils, Classes, Graphics, Controls, Forms, Dialogs,
  StdCtrls, VidGrab;

type

(*………………………………………………………………………………………………………………………………………………………………………………………………………………*)
  TVideoGrabberThread = Class( TThread )
  Private
      VideoGrabber: TVideoGrabber;
  Public
      constructor Create(CreateSuspended: Boolean);
      Procedure Execute; Override;
  End;

(*………………………………………………………………………………………………………………………………………………………………………………………………………………*)
  TForm1 = class(TForm)
    Button1: TButton;
    procedure Button1Click(Sender: TObject);
    procedure FormCloseQuery(Sender: TObject; var CanClose: Boolean);
  private
     VideoGrabberThread: TVideoGrabberThread;
  public
  end;

var
  Form1: TForm1;

implementation

{$R *.DFM}

(*………………………………………………………………………………………………………………………………………………………………………………………………………………*)
procedure TForm1.Button1Click(Sender: TObject);
(*………………………………………………………………………………………………………………………………………………………………………………………………………………*)
begin
   if not assigned (VideoGrabberThread) then begin
      VideoGrabberThread := TVideoGrabberThread.Create (true);
      VideoGrabberThread.Resume();
   end;
end;

(*………………………………………………………………………………………………………………………………………………………………………………………………………………*)
procedure TForm1.FormCloseQuery(Sender: TObject; var CanClose: Boolean);
(*………………………………………………………………………………………………………………………………………………………………………………………………………………*)
begin
   if assigned (VideoGrabberThread) then begin
     VideoGrabberThread.Terminate();
     VideoGrabberThread.WaitFor(); // we have to wait for the thread stop to be completed to avoid a crash because Form3 does not exist anymore
     VideoGrabberThread := nil;
   end;
   CanClose := true;
end;

(*………………………………………………………………………………………………………………………………………………………………………………………………………………*)
constructor TVideoGrabberThread.Create(CreateSuspended: Boolean);
(*………………………………………………………………………………………………………………………………………………………………………………………………………………*)
begin
   inherited Create (CreateSuspended);
   Priority := tpLower;
end;

(*………………………………………………………………………………………………………………………………………………………………………………………………………………*)
procedure TVideoGrabberThread.Execute;
(*………………………………………………………………………………………………………………………………………………………………………………………………………………*)
begin
   VideoGrabber := TVideoGrabber.Create(nil);  // the component must be created and assigned the Parent from the thread
   VideoGrabber.Parent := Form1;
   VideoGrabber.Display_AspectRatio := ar_Box;
   VideoGrabber.Align := alClient;
   VideoGrabber.BorderStyle := bsNone;
   VideoGrabber.IPCameraURL := 'http://webkamera.kristinehamn.se/axis-cgi/mjpg/video.cgi';
   VideoGrabber.VideoSource := vs_IPCamera;
   //VideoGrabber.SetAuthentication (at_IPCamera, 'yourusername', 'yourpassword');
   VideoGrabber.StartPreview();

   // thread loop
   While not Terminated do begin
      Sleep(50);
      Application.HandleMessage; /// the main trick is there, see https://forums.embarcadero.com/thread.jspa?threadID=37272
   end;

   VideoGrabber.Free; // let's free it when the thread is terminated
end;

end.
