unit CreateVidgrabFromThread_;

interface
uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms, Dialogs, VidGrab, StdCtrls, ExtCtrls;

type
  TCameraThread = Class( TThread )
  Private
      Run: Boolean;
      IPCamera: TVideoGrabber;
  Public
      constructor Create(CreateSuspended: Boolean);
      Procedure Execute; Override;
  End;

  TForm3 = class(TForm)
    Button1: TButton;
    procedure Button1Click(Sender: TObject);
    procedure FormCloseQuery(Sender: TObject; var CanClose: Boolean);
  private
     CameraThread: TCameraThread;
  public
  end;

var
  Form3: TForm3;

  MediaUrl: String ='http://webkamera.kristinehamn.se/axis-cgi/mjpg/video.cgi';

implementation

{$R *.dfm}

procedure TForm3.Button1Click(Sender: TObject);
begin
   CameraThread := TCameraThread.Create (false);
   //CameraThread.Resume;
 end;

constructor TCameraThread.Create(CreateSuspended: Boolean);
begin
   inherited Create (CreateSuspended);
   Priority := tpLower;
end;

procedure TCameraThread.Execute;
begin
   try
      IPCamera:=TVideoGrabber.Create(nil);  // the component must be created and assigned the Parent from the thread
      IPCamera.Parent:=Form3;
      IPCamera.Align:=alClient;
      IPCamera.BorderStyle:=bsNone;
      IPCamera.IPCameraURL:=MediaUrl;
      IPCamera.VideoSource:=vs_IPCamera;
      IPCamera.SetAuthentication (at_IPCamera, 'root', 'password');

      While not Terminated do begin
         if IPCamera.CurrentState=cs_Down then begin
            IPCamera.StartPreview;
         end;
         Sleep(100);
         Application.HandleMessage; /// the main trick is there, see https://forums.embarcadero.com/thread.jspa?threadID=37272
      end;
      IPCamera.Free; // let's free it when the thread is terminated
   except
   end;
end;

procedure TForm3.FormCloseQuery(Sender: TObject; var CanClose: Boolean);
begin
   if assigned (CameraThread) then begin
     CameraThread.Terminate;
     CameraThread.WaitFor; // we have to wait for the thread stop to be completed to avoid a crash because Form3 does not exist anymore
   end;
   CanClose := true;
end;

end.
