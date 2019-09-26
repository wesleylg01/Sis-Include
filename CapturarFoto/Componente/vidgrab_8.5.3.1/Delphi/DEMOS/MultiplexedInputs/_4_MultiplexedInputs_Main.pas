unit _4_MultiplexedInputs_Main;

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

var
   FrmSlave1: TFrmSlave;
   FrmSlave2: TFrmSlave;
   FrmSlave3: TFrmSlave;
   FrmSlave4: TFrmSlave;

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
   SlaveForm.VideoGrabberSlave.MultiplexedRole := ms_MultiplexedSlave;
   SlaveForm.Show;
end;

procedure TfrmMaster.FormCreate(Sender: TObject);
begin
   AssignListToComboBox (cboVideoDevices, VideoDevices, VideoGrabberMaster.VideoDevice);
end;

procedure TfrmMaster.VideoGrabberMasterVideoDeviceSelected(
  Sender: TObject);
begin
   AssignListToComboBox (cboVideoSize, VideoGrabberMaster.VideoSizes, VideoGrabberMaster.VideoSize);
   AssignListToComboBox (cboVideoInput, VideoGrabberMaster.VideoInputs, VideoGrabberMaster.VideoInput);
end;

procedure TfrmMaster.cboVideoSizeChange(Sender: TObject);
begin
   VideoGrabberMaster.VideoSize := cboVideoSize.ItemIndex;
end;

procedure TfrmMaster.cboVideoInputChange(Sender: TObject);
begin
   VideoGrabberMaster.VideoInput := cboVideoInput.ItemIndex;
end;

procedure TfrmMaster.FormShow(Sender: TObject);
begin
   if not assigned (FrmSlave1) then CreateSlaveForm (1, FrmSlave1, frmMaster.Top + frmMaster.Height + FormSpacings, frmMaster.Left);
   if not assigned (FrmSlave2) then CreateSlaveForm (2, FrmSlave2, frmMaster.Top + frmMaster.Height + FormSpacings, frmMaster.Left + FrmSlave1.Width + FormSpacings);
   if not assigned (FrmSlave3) then CreateSlaveForm (3, FrmSlave3, FrmSlave1.Top + FrmSlave1.Height + FormSpacings, frmMaster.Left);
   if not assigned (FrmSlave4) then CreateSlaveForm (4, FrmSlave4, FrmSlave1.Top + FrmSlave1.Height + FormSpacings, frmMaster.Left + FrmSlave1.Width + FormSpacings);

   VideoGrabberMaster.MultiplexedSlave1 := FrmSlave1.VideoGrabberSlave;
   VideoGrabberMaster.MultiplexedSlave2 := FrmSlave2.VideoGrabberSlave;
   VideoGrabberMaster.MultiplexedSlave3 := FrmSlave3.VideoGrabberSlave;
   VideoGrabberMaster.MultiplexedSlave4 := FrmSlave4.VideoGrabberSlave;

   FrmSlave1.VideoGrabberSlave.VideoRenderer := vr_StandardRenderer;
   FrmSlave2.VideoGrabberSlave.VideoRenderer := vr_StandardRenderer;
   FrmSlave3.VideoGrabberSlave.VideoRenderer := vr_StandardRenderer;
   FrmSlave4.VideoGrabberSlave.VideoRenderer := vr_StandardRenderer;
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

end.
