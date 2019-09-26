unit MultiplexedInputs_Slaves;

interface

uses
  Windows, Messages, SysUtils, Classes, Graphics, Controls, Forms, Dialogs,
  StdCtrls, ComCtrls, ExtCtrls, VidGrab;

type
  TFrmSlave = class(TForm)
    VideoGrabberSlave: TVideoGrabber;
    StartPreview1: TButton;
    StopPreview1: TButton;
    StartRecording1: TButton;
    StopRecording1: TButton;
    StartPlayback1: TButton;
    StopPlayback2: TButton;
    edtGlobalSensitivity: TEdit;
    updGlobalSensitivity: TUpDown;
    Label2: TLabel;
    edtMaxDetectionsPerSecond: TEdit;
    updMaxDetectionsPerSecond: TUpDown;
    Label1: TLabel;
    Label3: TLabel;
    mmoMotionGrid: TMemo;
    shpMotionDetected: TShape;
    procedure updGlobalSensitivityClick(Sender: TObject; Button: TUDBtnType);
    procedure StartPreview1Click(Sender: TObject);
    procedure StopPreview1Click(Sender: TObject);
    procedure StartRecording1Click(Sender: TObject);
    procedure StopRecording1Click(Sender: TObject);
    procedure StartPlayback1Click(Sender: TObject);
    procedure StopPlayback2Click(Sender: TObject);
    procedure FormShow(Sender: TObject);
    procedure updMaxDetectionsPerSecondClick(Sender: TObject;
      Button: TUDBtnType);
    procedure VideoGrabberSlaveMotionDetected(Sender: TObject;
      GlobalMotionRatio: Double; MaxMotionCellX, MaxMotionCellY: Integer;
      FrameBitmap: TBitmap; FrameNumber: Cardinal; FrameTime: Int64;
      FrameId: Integer; var CaptureFrame: Boolean);
    procedure VideoGrabberSlaveMotionNotDetected(Sender: TObject;
      FrameBitmap: TBitmap; FrameNumber: Cardinal; FrameTime: Int64;
      FrameId: Integer; var CaptureFrame: Boolean);
  private
  public
  end;

var
  FrmSlave: TFrmSlave;

implementation

{$R *.DFM}

procedure AssignListToComboBox (ComboBox: TComboBox; List: String; Index: integer);
begin
   ComboBox.Text := '';
   ComboBox.Items.Text := List;
   if ComboBox.Items.Count > 0 then begin
      ComboBox.ItemIndex := Index;
   end;
end;

procedure TFrmSlave.FormShow(Sender: TObject);
begin
   UpdMaxDetectionsPerSecond.Position := Round (VideoGrabberSlave.MotionDetector_MaxDetectionsPerSecond);
end;

procedure TFrmSlave.updGlobalSensitivityClick(Sender: TObject; Button: TUDBtnType);
begin
   VideoGrabberSlave.MotionDetector_ResetGlobalSensitivity (UpdGlobalSensitivity.Position);
end;

procedure TFrmSlave.updMaxDetectionsPerSecondClick(Sender: TObject;
  Button: TUDBtnType);
begin
   VideoGrabberSlave.MotionDetector_MaxDetectionsPerSecond := UpdMaxDetectionsPerSecond.Position;
end;

procedure TFrmSlave.StartPreview1Click(Sender: TObject);
begin
   VideoGrabberSlave.StartPreview;
end;

procedure TFrmSlave.StopPreview1Click(Sender: TObject);
begin
   VideoGrabberSlave.StopPreview;
end;

procedure TFrmSlave.StartRecording1Click(Sender: TObject);
begin
   VideoGrabberSlave.StartRecording;
end;

procedure TFrmSlave.StopRecording1Click(Sender: TObject);
begin
   VideoGrabberSlave.StopRecording;
end;

procedure TFrmSlave.StartPlayback1Click(Sender: TObject);
begin
   VideoGrabberSlave.PlayerFileName := VideoGrabberSlave.Last_Recording_FileName;
   VideoGrabberSlave.OpenPlayer;
end;

procedure TFrmSlave.StopPlayback2Click(Sender: TObject);
begin
   VideoGrabberSlave.ClosePlayer;
end;

procedure TFrmSlave.VideoGrabberSlaveMotionDetected(Sender: TObject;
  GlobalMotionRatio: Double; MaxMotionCellX, MaxMotionCellY: Integer;
  FrameBitmap: TBitmap; FrameNumber: Cardinal; FrameTime: Int64;
  FrameId: Integer; var CaptureFrame: Boolean);
begin
   shpMotionDetected.Brush.Color := clLime;
   mmoMotionGrid.Text := VideoGrabberSlave.MotionDetector_Get2DTextMotion;
end;

procedure TFrmSlave.VideoGrabberSlaveMotionNotDetected(Sender: TObject;
  FrameBitmap: TBitmap; FrameNumber: Cardinal; FrameTime: Int64;
  FrameId: Integer; var CaptureFrame: Boolean);
begin
   shpMotionDetected.Brush.Color := clGreen;
   mmoMotionGrid.Text := VideoGrabberSlave.MotionDetector_Get2DTextMotion;
end;

end.
