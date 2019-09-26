unit UPrincipal;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls;

type
  TForm3 = class(TForm)
    Button1: TButton;
    Button2: TButton;
    procedure Button1Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form3: TForm3;

implementation

uses UConversao, ULeitor;

{$R *.dfm}

procedure TForm3.Button1Click(Sender: TObject);
begin
if form1 = nil then
   Application.CreateForm(TForm1, Form1);
   Form1.ShowModal;
end;

procedure TForm3.Button2Click(Sender: TObject);
begin
if form2 = nil then
   Application.CreateForm(TForm2, Form2);
   Form2.ShowModal;
end;

end.
