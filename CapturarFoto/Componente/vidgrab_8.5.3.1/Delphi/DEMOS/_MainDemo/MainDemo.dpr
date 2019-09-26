program MainDemo;

uses
  Forms,
  MainForm in 'MainForm.pas' {frmMainForm},
  miscVideoQuality in 'miscVideoQuality.pas' {frmVideoQuality},
  miscVideoControl in 'miscVideoControl.pas' {frmVideoControl},
  miscCameraControl in 'miscCameraControl.pas' {frmCameraControl},
  miscSpecialControls in 'miscSpecialControls.pas' {frmSpecialControls};
{$R *.RES}

begin
  Application.Initialize;
  Application.Title := 'Datastead TVideoGrabber VCL component demo';
  Application.CreateForm(TfrmMainForm, frmMainForm);
  Application.CreateForm(TfrmVideoQuality, frmVideoQuality);
  Application.CreateForm(TfrmVideoControl, frmVideoControl);
  Application.CreateForm(TfrmCameraControl, frmCameraControl);
  Application.CreateForm(TfrmSpecialControls, frmSpecialControls);
  Application.Run;
end.
