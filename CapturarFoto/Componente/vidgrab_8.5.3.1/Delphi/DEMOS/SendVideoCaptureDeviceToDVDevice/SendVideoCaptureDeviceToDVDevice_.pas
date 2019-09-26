unit SendVideoCaptureDeviceToDVDevice_;

interface

uses
  Windows, Messages, SysUtils, Classes, Graphics, Controls, Forms, Dialogs,
  StdCtrls, Vidgrab, ExtCtrls, Buttons;

type
  TForm1 = class(TForm)
    Label1: TLabel;
    Label2: TLabel;
    Label5: TLabel;
    Label6: TLabel;
    cboDestinationDVDevices: TComboBox;
    VideoGrabber: TVideoGrabber;
    edtDestinationDVdevice: TEdit;
    btnStart: TButton;
    mmoLog: TMemo;
    Button1: TButton;
    Label3: TLabel;
    cboVideoCaptureDevices: TComboBox;
    Label4: TLabel;
    edtSourceVideoCaptureDevice: TEdit;
    Label7: TLabel;
    procedure FormCreate(Sender: TObject);
    procedure cboDestinationDVDevicesChange(Sender: TObject);
    procedure btnStartClick(Sender: TObject);
    procedure VideoGrabberLog(Sender: TObject; LogType: TLogType; Severity,
      InfoMsg: String);
    procedure Button1Click(Sender: TObject);
    procedure cboVideoCaptureDevicesChange(Sender: TObject);
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
   AssignListToComboBox (cboDestinationDVDevices, VideoGrabber.VideoDevices, 0);
   AssignListToComboBox (cboVideoCaptureDevices, VideoGrabber.VideoDevices, 0);

   // prevents resizing automatically the video window
   VideoGrabber.Display_AutoSize := False;
   VideoGrabber.Display_AspectRatio := ar_Box;

   edtDestinationDVdevice.Text := '';
   edtSourceVideoCaptureDevice.Text := '';
end;

procedure TForm1.cboDestinationDVDevicesChange(Sender: TObject);
begin
   if VideoGrabber.IsDVDevice (cboDestinationDVDevices.ItemIndex) then begin
      edtDestinationDVdevice.Text := cboDestinationDVDevices.Items[cboDestinationDVDevices.ItemIndex];
      VideoGrabber.SendToDV_DeviceIndex := cboDestinationDVDevices.ItemIndex;
   end
   else begin
      edtDestinationDVdevice.Text := 'THIS IS NOT A DV DEVICE!';
   end;
end;

procedure TForm1.cboVideoCaptureDevicesChange(Sender: TObject);
begin
   edtSourceVideoCaptureDevice.Text := cboVideoCaptureDevices.Items[cboVideoCaptureDevices.ItemIndex];
   VideoGrabber.VideoDevice := cboVideoCaptureDevices.ItemIndex;
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
   VideoGrabber.VideoSource := vs_VideoCaptureDevice;
   VideoGrabber.VideoDevice := cboVideoCaptureDevices.ItemIndex;

   VideoGrabber.SendToDV_DeviceIndex := cboDestinationDVDevices.ItemIndex;
   VideoGrabber.RecordingMethod := rm_SendToDV;

   if VideoGrabber.VideoDevice = VideoGrabber.SendToDV_DeviceIndex then begin
      ShowMessage ('the destination device cannot be used as source!');
   end
   else begin
      VideoGrabber.StartRecording;
   end;
end;

procedure TForm1.Button1Click(Sender: TObject);
begin
   VideoGrabber.Stop;
end;

end.
