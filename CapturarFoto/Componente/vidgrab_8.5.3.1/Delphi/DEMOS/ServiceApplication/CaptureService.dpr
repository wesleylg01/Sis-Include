program CaptureService;

uses
  SvcMgr,
  CaptureService_ in 'CaptureService_.pas' {Service1: TService};

{$R *.RES}

begin
  Application.Initialize;
  Application.CreateForm(TService1, Service1);
  Application.Run;
end.
