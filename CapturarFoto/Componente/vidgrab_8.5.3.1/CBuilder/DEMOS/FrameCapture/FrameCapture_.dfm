�
 TFORM1 0�  TPF0TForm1Form1Left�Top� WidthHeightCaption TVideoGrabber frame capture demoColor	clBtnFaceFont.CharsetDEFAULT_CHARSET
Font.ColorclWindowTextFont.Height�	Font.NameMS Sans Serif
Font.Style OldCreateOrderPositionpoScreenCenterOnCreate
FormCreatePixelsPerInch`
TextHeight TImageImage1Left�Top� WidthyHeight)AutoSize	  	TGroupBox	GroupBox2LeftTop.Width�Height.Captionsingle frame captureTabOrder  TButtonButton6LeftHTopWidth<HeightCaptionto JPEG fileTabOrder OnClickButton6Click  TButtonButton7Left� TopWidth<HeightCaptionto BMP fileTabOrderOnClickButton7Click  TButtonButton4LeftTopWidth<HeightCaption	to TImageTabOrderOnClickButton4Click  TEditEdit2Left8TopWidth� HeightEnabledTabOrderTextfile_name_if_not_auto  	TCheckBox	CheckBox3Left� TopWidthYHeightCaptionauto file nameChecked	State	cbCheckedTabOrderOnClickCheckBox3Click   	TGroupBox	GroupBox3LeftTop WidthHeight.Captionvideo deviceTabOrder 	TComboBox	ComboBox1LefthTopWidth� Height
ItemHeightTabOrder TextSELECT FIRST A CAPTURE DEVICEOnChangeComboBox1Change  	TComboBox	ComboBox2LeftXTopWidthiHeight
ItemHeightTabOrderTextvideo standardOnChangeComboBox2Change  	TComboBox	ComboBox4Left�TopWidthYHeight
ItemHeightTabOrderTextcrossbarOnChangeComboBox4Change  	TComboBox	ComboBox5Left�TopWidthYHeight
ItemHeightTabOrderTextsizeOnChangeComboBox5Change  TButtonButton10Left�TopWidth1HeightCaptiontv tunerTabOrderOnClickButton10Click  TButtonButton9LeftXTopWidth9HeightCaptiondeviceTabOrderOnClickButton9Click  TButtonButton3LeftTopWidth(HeightCaptionStartTabOrderOnClickButton3Click  TButtonButton8Left8TopWidth(HeightCaptionStopTabOrderOnClickButton8Click   TVideoGrabberVideoGrabber1LeftTop� Width�Height)ASFMediaServerPublishingPoint1http://YourWindowsMediaServer/YourPublishingPointASFVideoWidth@AudioCompressor AutoFilePrefixvgCaptureFileExtaviDroppedFramesPollingInterval
DualDisplay_Left�DualDisplay_Top
DVEncoder_VideoStandarddvs_PALCropping_Zoom       ��?MotionDetector_Gridn5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 MultiplexedStabilizationDelayPlayerSpeedRatio       ��?!RecordingOnMotion_MotionThreshold �O��n��?TextOverlay_Font.CharsetDEFAULT_CHARSETTextOverlay_Font.ColorclAquaTextOverlay_Font.Height�TextOverlay_Font.NameMS Sans SerifTextOverlay_Font.Style TextOverlay_String  Note: the date/time formats 
can be easily modified.

system date/time: %sys_time[dd/mm/yy hh:nn:ss]%
DV time code: %time_code%
DV date/time: %dv_time[dd/mm/yy hh:nn:ss]%
frame count: %frame_count%
time (full): %time_full%
time (sec): %time_sec%
time (ns): %time_100ns%TVUseFrequencyOverrides	VideoCompression_Quality       ��?VideoCompressor VideoFromImages_TemporaryFileSetOfBitmaps01.dat#VideoProcessing_RotationCustomAngle       �@VideoSource_FileOrURL&http://www.datastead.com/demo/demo.wmvOnFrameCaptureCompleted"VideoGrabber1FrameCaptureCompletedOnResizeVideoVideoGrabber1ResizeVideoOnVideoDeviceSelected VideoGrabber1VideoDeviceSelected  	TGroupBox	GroupBox1LeftTop\Width�Height.Captionautomated frame captureTabOrder TLabelLabel2Left�TopWidth%HeightCaption	interval:  TLabelLabel1LeftTopWidthTHeightCaptionnumber of frames:  TLabelLabel4LeftTopWidthFHeightCaption(0 = don't stop)  TButtonButton2Left� TopWidth<HeightCaptionstopFont.CharsetDEFAULT_CHARSET
Font.ColorclWindowTextFont.Height�	Font.NameMS Sans Serif
Font.StylefsBold 
ParentFontTabOrder OnClickButton2Click  TButtonButton1LeftHTopWidth<HeightCaptionto JPEG fileTabOrderOnClickButton1Click  TButtonButton5Left� TopWidth<HeightCaptionto BMP fileTabOrderOnClickButton5Click  TButtonButton11LeftTopWidth<HeightCaption	to TImageTabOrderOnClickButton11Click  TEditEdit3Left�TopWidthHeightTabOrderText0OnChangeEdit3Change  TEditEdit1LefthTopWidthHeightTabOrderText4OnChangeEdit1Change   TMemoMemo1Left�Top3WidthHeightVColorclSilverLines.StringsMemo1 TabOrder   