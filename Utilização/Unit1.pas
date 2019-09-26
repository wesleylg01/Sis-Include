unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, ShellAPI, StdCtrls, ComCtrls;

type
  TForm1 = class(TForm)
    Button1: TButton;
    OpenDialog1: TOpenDialog;
    Button2: TButton;
    Label1: TLabel;
    Button3: TButton;
    RichEdit1: TRichEdit;
    procedure Button1Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);
    procedure Button3Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

procedure TForm1.Button1Click(Sender: TObject);
begin
// se for txt ele cria qr... se for diferente ele lê arquivo
ShellExecute(handle,'open',Pchar(ExtractFilePath(Application.ExeName)+'\appConversor\conversor.jar'), Pchar(ExtractFilePath(Application.ExeName)+'\txtFonte\fonte.txt'),'',SW_SHOWNORMAL);
end;

procedure TForm1.Button2Click(Sender: TObject);
var caminho: string;
begin
if OpenDialog1.Execute then
   caminho:= OpenDialog1.FileName;

CopyFile(pChar(caminho), Pchar(ExtractFilePath(Application.ExeName)+'\txtFonte\fonte.txt'), true);
// se for txt ele cria qr... se for diferente ele lê arquivo
ShellExecute(handle,'open',Pchar(ExtractFilePath(Application.ExeName)+'\appConversor\conversor.jar'), Pchar(ExtractFilePath(Application.ExeName)+'\txtFonte\fonte.txt'),'',SW_SHOWNORMAL);
Showmessage('Arquivos qrCode convertido no caminho '+Pchar(ExtractFilePath(Application.ExeName)+'qrCode\'));
end;

procedure TForm1.Button3Click(Sender: TObject);
var txt: TStringList;
begin
DeleteFile(Pchar(ExtractFilePath(Application.ExeName)+'\txtFonte\fonte.txt'));
ShellExecute(handle,'open',Pchar(ExtractFilePath(Application.ExeName)+'\appConversor\conversor.jar'), Pchar(ExtractFilePath(Application.ExeName)+'\txtFonte\fonte.png'),'',SW_SHOWNORMAL);
txt:= TStringList.Create;
while true do
begin
      if FileExists(ExtractFilePath(Application.ExeName)+'\txtFonte\fonte.txt') then
         break;
end;

      Sleep(2000);
      txt.LoadFromFile(ExtractFilePath(Application.ExeName)+'\txtFonte\fonte.txt');

RichEdit1.Lines.AddStrings(txt);
end;

end.
