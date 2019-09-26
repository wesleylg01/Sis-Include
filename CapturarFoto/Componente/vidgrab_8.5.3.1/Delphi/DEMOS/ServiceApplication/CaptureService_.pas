unit CaptureService_;

interface

uses
  Windows, Messages, SysUtils, Classes, Graphics, Controls, SvcMgr, Dialogs, VidGrab;

type
  TService1 = class(TService)
	 procedure ServiceStart(Sender: TService; var Started: Boolean);
	 procedure ServiceStop(Sender: TService; var Stopped: Boolean);
	 procedure ServiceExecute(Sender: TService);
    procedure ServiceCreate(Sender: TObject);
    procedure ServiceDestroy(Sender: TObject);
  private
	 { Private declarations }
	  VideoGrabber: TVideoGrabber;
	  procedure ExecuteService;
  public
	 function GetServiceController: TServiceController; override;
	 { Public declarations }
  end;

var
  Service1: TService1;

implementation

{$R *.DFM}

// THIS DEMO START THE PREVIEW OF THE DEFAULT VIDEO CAPTURE DEVICE AND CAPTURE FRAMES PERIODICALLY EVERY 5 SECONDS TO THE c:\mycapture FOLDER

procedure ServiceController(CtrlCode: DWord); stdcall;
begin
   Service1.Controller(CtrlCode);
end;

function TService1.GetServiceController: TServiceController;
begin
   Result := ServiceController;
end;

procedure TService1.ExecuteService;
begin
   VideoGrabber.CaptureFrameTo (fc_JpegFile, '');
end;

procedure TService1.ServiceCreate(Sender: TObject);
begin
   VideoGrabber := TVideoGrabber.Create (nil);
	VideoGrabber.StoragePath := 'c:\mycapture';
end;

procedure TService1.ServiceDestroy(Sender: TObject);
begin
	VideoGrabber.Free;
end;

procedure TService1.ServiceExecute(Sender: TService);
begin
	while not Terminated do begin
		ExecuteService;
		ServiceThread.ProcessRequests (true);
		Sleep (5000);
	end;
end;

procedure TService1.ServiceStart(Sender: TService; var Started: Boolean);
begin
	VideoGrabber.StartPreview;
end;

procedure TService1.ServiceStop(Sender: TService; var Stopped: Boolean);
begin
	VideoGrabber.StopPreview;
end;

end.
