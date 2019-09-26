program _16_MultiplexedInputs;

uses
  Forms,
  _16_MultiplexedInputs_Masters in '_16_MultiplexedInputs_Masters.pas' {frmMaster};

{$R *.RES}

begin
  Application.Initialize;
  Application.CreateForm(TfrmMaster, frmMaster);
  Application.Run;
end.
