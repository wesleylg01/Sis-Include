unit SendVideoClipToDVDevice_;

interface

uses
  Windows, Messages, SysUtils, Classes, Graphics, Controls, Forms, Dialogs,
  StdCtrls, Vidgrab, ExtCtrls, Buttons;

type
  TForm1 = class(TForm)
    cboVideoDevices: TComboBox;
    VideoGrabber: TVideoGrabber;
    edtDestinationDVdevice: TEdit;
    Label1: TLabel;
    Label2: TLabel;
    btnPlayerOpenFile: TSpeedButton;
    edtVideoClip: TEdit;
    Label3: TLabel;
    Label4: TLabel;
    Label5: TLabel;
    btnStart: TButton;
    dlgOpen: TOpenDialog;
    mmoLog: TMemo;
    Button1: TButton;
    Label6: TLabel;
    procedure FormCreate(Sender: TObject);
    procedure cboVideoDevicesChange(Sender: TObject);
    procedure btnStartClick(Sender: TObject);
    procedure btnPlayerOpenFileClick(Sender: TObject);
    procedure VideoGrabberLog(Sender: TObject; LogType: TLogType; Severity,
      InfoMsg: String);
    procedure Button1Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.DFM}

procedure AssignListToComboBox (ComboBox: TComboBox; List: String; Index: integer; MaxCount: Integer = 0);
begin
   ComboBox.Text := '';
   ComboBox.Items.Text := List;
   if ComboBox.Items.Count > 0 then begin
      ComboBox.ItemIndex := Index;
   end;
   if MaxCount > 0 then begin
      while ComboBox.Items.count > MaxCount do begin
         ComboBox.Items.Delete (ComboBox.Items.Count - 1);
      end;
   end;
end;

procedure TForm1.FormCreate(Sender: TObject);
begin
   AssignListToComboBox (cboVideoDevices, VideoGrabber.VideoDevices, VideoGrabber.VideoDevice);

   // prevents resizing automatically the video window
   VideoGrabber.Display_AutoSize := False;
   VideoGrabber.Display_AspectRatio := ar_Box;
end;

procedure TForm1.cboVideoDevicesChange(Sender: TObject);
begin
   if VideoGrabber.IsDVDevice (cboVideoDevices.ItemIndex) then begin
      edtDestinationDVdevice.Text := cboVideoDevices.Items[cboVideoDevices.ItemIndex];
      VideoGrabber.SendToDV_DeviceIndex := cboVideoDevices.ItemIndex;
   end
   else begin
      edtDestinationDVdevice.Text := 'THIS IS NOT A DV DEVICE!';
   end;
end;

procedure TForm1.btnPlayerOpenFileClick(Sender: TObject);
begin
   dlgOpen.FileName := '*.mpg;*.mpeg;*.vro;*.avi;*.wav;*.asf;*.wmv;*.vob';
   if dlgOpen.Execute then begin
      edtVideoClip.Text := dlgOpen.FileName;
   end;
end;

procedure TForm1.VideoGrabberLog(Sender: TObject; LogType: TLogType;
  Severity, InfoMsg: String);
var
   LogTypeValue: LongInt;
begin
   LogTypeValue := Integer (LogType);
   mmoLog.Lines.Add (IntToStr (LogTypeValue) + ': ' + InfoMsg);
   if LogTypeValue = 27 then begin
      mmoLog.Lines.Add ('CHECK:');
      mmoLog.Lines.Add ('- that you have selected a destination DV device (step1)');
      mmoLog.Lines.Add ('- that you have selected a video clip (step 2)');
      mmoLog.Lines.Add ('- that your DV device is in TAPE MODE');
   end;
end;

procedure TForm1.btnStartClick(Sender: TObject);
begin
   VideoGrabber.VideoSource := vs_VideoFileOrURL;
   VideoGrabber.VideoSource_FileOrURL := edtVideoClip.Text;
   VideoGrabber.RecordingMethod := rm_SendToDV;
   VideoGrabber.StartRecording;
end;

procedure TForm1.Button1Click(Sender: TObject);
begin
   VideoGrabber.Stop;
end;

end.
