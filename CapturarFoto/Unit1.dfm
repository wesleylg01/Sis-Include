object Form1: TForm1
  Left = 0
  Top = 0
  Caption = 'Prot'#243'tipo de aquisi'#231#227'o foto'
  ClientHeight = 218
  ClientWidth = 288
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  OldCreateOrder = False
  OnActivate = FormActivate
  PixelsPerInch = 96
  TextHeight = 13
  object Image1: TImage
    Left = 56
    Top = 8
    Width = 177
    Height = 161
  end
  object ComboBox1: TComboBox
    Left = 56
    Top = 184
    Width = 177
    Height = 21
    ItemHeight = 13
    TabOrder = 0
    Text = 'ComboBox1'
    OnChange = ComboBox1Change
  end
  object VideoGrabber1: TVideoGrabber
    Left = 8
    Top = 8
    Width = 24
    Height = 18
    Caption = 'VideoGrabber1'
    Color = clBlack
    Visible = False
    ASFVideoWidth = -1
    AspectRatioToUse = -1.000000000000000000
    AudioCompressor = 0
    AutoFilePrefix = 'vg'
    Cropping_Zoom = 1.000000000000000000
    LicenseString = 'N/A'
    MotionDetector_Grid = 
      '5555555555 5555555555 5555555555 5555555555 5555555555 555555555' +
      '5 5555555555 5555555555 5555555555 5555555555'
    PlayerSpeedRatio = 1.000000000000000000
    Reencoding_StartTime = -1
    Reencoding_StartFrame = -1
    Reencoding_StopTime = -1
    Reencoding_StopFrame = -1
    TextOverlay_Font.Charset = DEFAULT_CHARSET
    TextOverlay_Font.Color = clAqua
    TextOverlay_Font.Height = -16
    TextOverlay_Font.Name = 'Tahoma'
    TextOverlay_Font.Style = []
    TextOverlay_String = 
      'Note: the date/time formats '#13#10'can be easily modified.'#13#10#13#10'system ' +
      'date/time: %sys_time[dd/mm/yy hh:nn:ss]%'#13#10'DV time code: %time_co' +
      'de%'#13#10'DV date/time: %dv_time[dd/mm/yy hh:nn:ss]%'#13#10'frame number: %' +
      'frame_count%'#13#10'time (full): %time_full%'#13#10'time (sec): %time_sec%'#13#10 +
      'time (ns): %time_100ns%'
    VideoCompression_Quality = 1.000000000000000000
    VideoCompressor = 0
    VideoFromImages_TemporaryFile = 'SetOfBitmaps01.dat'
    VideoProcessing_RotationCustomAngle = 45.500000000000000000
    VideoSource_FileOrURL_StartTime = -1
    VideoSource_FileOrURL_StopTime = -1
    OnFrameCaptureCompleted = VideoGrabber1FrameCaptureCompleted
  end
  object Timer1: TTimer
    Enabled = False
    Interval = 10
    OnTimer = Timer1Timer
    Left = 8
    Top = 64
  end
end
