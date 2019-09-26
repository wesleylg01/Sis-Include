program _4_MultiplexedInputs;

uses
  Forms,
  _4_MultiplexedInputs_Master in '_4_MultiplexedInputs_Master.pas' {frmMaster};

{$R *.RES}

begin
  Application.Initialize;
  Application.CreateForm(TfrmMaster, frmMaster);
  Application.Run;
end.
