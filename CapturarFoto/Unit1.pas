unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, ExtCtrls, VidGrab, StdCtrls;

type
  TForm1 = class(TForm)
    Image1: TImage;
    ComboBox1: TComboBox;
    VideoGrabber1: TVideoGrabber;
    Timer1: TTimer;
    procedure FormActivate(Sender: TObject);
    procedure ComboBox1Change(Sender: TObject);
    procedure Timer1Timer(Sender: TObject);
    procedure VideoGrabber1FrameCaptureCompleted(Sender: TObject;
      FrameBitmap: TBitmap; BitmapWidth, BitmapHeight: Integer;
      FrameNumber: Cardinal; FrameTime: Int64; DestType: TFrameCaptureDest;
      FileName: string; Success: Boolean; FrameId: Integer);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

procedure TForm1.ComboBox1Change(Sender: TObject);
begin
VideoGrabber1.VideoDevice:= ComboBox1.ItemIndex;
VideoGrabber1.VideoSize:=3;
VideoGrabber1.ShowDialog(dlg_StreamConfig);
VideoGrabber1.StartPreview;
Timer1.Enabled:= true;
end;

procedure TForm1.FormActivate(Sender: TObject);
begin
ComboBox1.Items.Text := VideoGrabber1.VideoDevices;
ComboBox1.ItemIndex := VideoGrabber1.VideoDevice;
end;

procedure TForm1.Timer1Timer(Sender: TObject);
begin
VideoGrabber1.BurstType := fc_TBitmap;
VideoGrabber1.BurstMode := True;
end;

procedure TForm1.VideoGrabber1FrameCaptureCompleted(Sender: TObject;
  FrameBitmap: TBitmap; BitmapWidth, BitmapHeight: Integer;
  FrameNumber: Cardinal; FrameTime: Int64; DestType: TFrameCaptureDest;
  FileName: string; Success: Boolean; FrameId: Integer);
begin
Image1.Picture.Bitmap:= FrameBitmap;
end;

end.
