object Form2: TForm2
  Left = 0
  Top = 0
  Caption = 'Leitor'
  ClientHeight = 494
  ClientWidth = 882
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
    Left = 6
    Top = 0
    Width = 640
    Height = 480
  end
  object Memo1: TMemo
    Left = 652
    Top = 0
    Width = 225
    Height = 453
    TabOrder = 0
  end
  object ComboBox1: TComboBox
    Left = 649
    Top = 459
    Width = 228
    Height = 21
    ItemHeight = 13
    TabOrder = 1
    Text = 'ComboBox1'
    OnChange = ComboBox1Change
  end
  object VideoGrabber1: TVideoGrabber
    Left = 40
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
  object Button1: TButton
    Left = 776
    Top = 421
    Width = 75
    Height = 25
    Caption = 'Button1'
    TabOrder = 3
    Visible = False
    OnClick = Button1Click
  end
  object Timer1: TTimer
    Enabled = False
    Interval = 10
    OnTimer = Timer1Timer
    Left = 376
    Top = 40
  end
end
