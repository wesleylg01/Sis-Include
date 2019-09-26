unit _16_MultiplexedInputs_Masters;

interface

uses
  Windows, Messages, SysUtils, Classes, Graphics, Controls, Forms, Dialogs,
  StdCtrls, ComCtrls, ExtCtrls, VidGrab;

type
  TfrmMaster = class(TForm)
    Label1: TLabel;
    cboVideoDevices: TComboBox;
    btnStartMaster: TButton;
    btnStopMaster: TButton;
    btnNoPreview: TButton;
    VideoGrabberMaster: TVideoGrabber;
    mmoLog: TMemo;
    Label2: TLabel;
    cboVideoSize: TComboBox;
    cboVideoInput: TComboBox;
    Label3: TLabel;
    Label4: TLabel;
    cboAnalogVideoStandard: TComboBox;
    chkMultiplexedInputEmulation: TCheckBox;
    procedure btnStartMasterClick(Sender: TObject);
    procedure btnStopMasterClick(Sender: TObject);
    procedure cboVideoDevicesChange(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure btnNoPreviewClick(Sender: TObject);
    procedure FormShow(Sender: TObject);
    procedure VideoGrabberMasterLog(Sender: TObject; LogType: TLogType;
      Severity, InfoMsg: String);
    procedure VideoGrabberMasterVideoDeviceSelected(Sender: TObject);
    procedure cboVideoSizeChange(Sender: TObject);
    procedure cboVideoInputChange(Sender: TObject);
    procedure cboAnalogVideoStandardChange(Sender: TObject);
    procedure chkMultiplexedInputEmulationClick(Sender: TObject);
  private
  public
  end;

var
  frmMaster: TfrmMaster;

implementation

{$R *.DFM}

uses MultiplexedInputs_Slaves;

const
   FormSpacings = 5;

procedure AssignListToComboBox (ComboBox: TComboBox; List: String; Index: integer);
begin
   ComboBox.Text := '';
   ComboBox.Items.Text := List;
   if ComboBox.Items.Count > 0 then begin
      ComboBox.ItemIndex := Index;
   end;
end;

procedure CreateSlaveForm (IdInput: LongInt; var SlaveForm: TFrmSlave; FormTop, FormLeft: LongInt);
begin
   Application.CreateForm (TFrmSlave, SlaveForm);
   SlaveForm.Caption := 'Input ' + IntToStr (IdInput);
   SlaveForm.Top := FormTop;
   SlaveForm.Left := FormLeft;
   SlaveForm.VideoGrabberSlave.MultiplexedRole := mr_MultiplexedSlave;
   SlaveForm.Show;
end;

procedure TfrmMaster.FormCreate(Sender: TObject);
begin
   AssignListToComboBox (cboVideoDevices, VideoGrabberMaster.VideoDevices, VideoGrabberMaster.VideoDevice);
   chkMultiplexedInputEmulation.Checked := VideoGrabberMaster.MultiplexedInputEmulation;
end;

procedure TfrmMaster.VideoGrabberMasterVideoDeviceSelected(
  Sender: TObject);
begin
   AssignListToComboBox (cboVideoSize, VideoGrabberMaster.VideoSizes, VideoGrabberMaster.VideoSize);
   AssignListToComboBox (cboVideoInput, VideoGrabberMaster.VideoInputs, VideoGrabberMaster.VideoInput);
   AssignListToComboBox (cboAnalogVideoStandard, VideoGrabberMaster.AnalogVideoStandards, VideoGrabberMaster.AnalogVideoStandard);
end;

procedure TfrmMaster.cboVideoSizeChange(Sender: TObject);
begin
   VideoGrabberMaster.VideoSize := cboVideoSize.ItemIndex;
end;

procedure TfrmMaster.cboVideoInputChange(Sender: TObject);
begin
   VideoGrabberMaster.VideoInput := cboVideoInput.ItemIndex;
end;

procedure TfrmMaster.cboAnalogVideoStandardChange(Sender: TObject);
begin
   VideoGrabberMaster.AnalogVideoStandard := cboAnalogVideoStandard.ItemIndex;
end;

const
   MINSLAVE = 0;
   MAXSLAVE = 15;

var
   FrmSlave: array[MINSLAVE..MAXSLAVE] of TFrmSlave;

procedure TfrmMaster.FormShow(Sender: TObject);
var
   i: LongInt;
   xPos, yPos: LongInt;
   FormCount: LongInt;
begin
   FormCount := 0;
   Left := 10;
   Top := 10;
   Application.ProcessMessages;
   xPos := frmMaster.Left;
   yPos := frmMaster.Top + frmMaster.Height + FormSpacings;
   for i := MINSLAVE to MAXSLAVE do begin
      if not assigned (FrmSlave[i]) then begin
         CreateSlaveForm (i, FrmSlave[i], yPos, xPos);
      end;
      inc (FormCount);
      if FormCount < 4 then begin
         xPos := xPos + FrmSlave[0].Width + FormSpacings;
      end
      else begin
         FormCount := 0;
         xPos := frmMaster.Left;
         yPos := yPos + FrmSlave[0].Height + FormSpacings;
      end;
   end;

   for i := MINSLAVE to MAXSLAVE do begin
      VideoGrabberMaster.AssociateMultiplexedSlave (i, FrmSlave[i].VideoGrabberSlave.UniqueId);
   end;
end;

procedure TfrmMaster.cboVideoDevicesChange(Sender: TObject);
begin
   VideoGrabberMaster.VideoDevice := cboVideoDevices.ItemIndex;
end;

procedure TfrmMaster.btnStartMasterClick(Sender: TObject);
begin
   VideoGrabberMaster.StartPreview;
end;

procedure TfrmMaster.btnStopMasterClick(Sender: TObject);
begin
   VideoGrabberMaster.StopPreview;
end;

procedure TfrmMaster.btnNoPreviewClick(Sender: TObject);
begin
   VideoGrabberMaster.VideoRenderer := vr_None;
   VideoGrabberMaster.Visible := False;
end;

procedure TfrmMaster.VideoGrabberMasterLog(Sender: TObject;
  LogType: TLogType; Severity, InfoMsg: String);
begin
   mmoLog.Lines.Add ('[' + Severity + '] ' + InfoMsg);
end;

procedure TfrmMaster.chkMultiplexedInputEmulationClick(Sender: TObject);
begin
   VideoGrabberMaster.MultiplexedInputEmulation := chkMultiplexedInputEmulation.Checked;
end;

end.
