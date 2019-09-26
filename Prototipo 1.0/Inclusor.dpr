program Inclusor;

uses
  Forms,
  UConversao in 'UConversao.pas' {Form1},
  ULeitor in 'ULeitor.pas' {Form2},
  UPrincipal in 'UPrincipal.pas' {Form3};

{$R *.res}

begin
  Application.Initialize;
  Application.MainFormOnTaskbar := True;
  Application.CreateForm(TForm3, Form3);
  Application.CreateForm(TForm2, Form2);
  Application.CreateForm(TForm1, Form1);
  Application.Run;
end.
