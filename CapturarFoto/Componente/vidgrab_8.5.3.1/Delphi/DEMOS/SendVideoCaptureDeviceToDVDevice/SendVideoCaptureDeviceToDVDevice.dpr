program SendVideoCaptureDeviceToDVDevice;

uses
  Forms,
  SendVideoCaptureDeviceToDVDevice_ in 'SendVideoCaptureDeviceToDVDevice_.pas' {Form1};

{$R *.RES}

begin
  Application.Initialize;
  Application.CreateForm(TForm1, Form1);
  Application.Run;
end.
