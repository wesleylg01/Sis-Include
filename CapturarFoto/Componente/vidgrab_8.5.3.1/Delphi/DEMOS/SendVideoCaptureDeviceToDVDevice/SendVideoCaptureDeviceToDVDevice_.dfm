�
 TFORM1 0�  TPF0TForm1Form1Left� TopkWidth�Height Caption8TVideoGrabber:  Send video capture device to a DV deviceColor	clBtnFaceFont.CharsetDEFAULT_CHARSET
Font.ColorclWindowTextFont.Height�	Font.NameMS Sans Serif
Font.Style OldCreateOrderOnCreate
FormCreatePixelsPerInch`
TextHeight TLabelLabel1LeftTopWidth� HeightCaption)1. select a DV device (as destination) ->Font.CharsetDEFAULT_CHARSET
Font.ColorclWindowTextFont.Height�	Font.NameMS Sans Serif
Font.StylefsBold 
ParentFont  TLabelLabel2Left� Top4Width� HeightCaption!destination DV device selected ->  TLabelLabel5LeftTop� Width^HeightCaption=3. start sending the video capture device to the DV device ->Font.CharsetDEFAULT_CHARSET
Font.ColorclWindowTextFont.Height�	Font.NameMS Sans Serif
Font.StylefsBold 
ParentFont  TLabelLabel6LeftTop� WidthHeightCaptionlog:  TLabelLabel3LeftTopTWidthHeightCaption/2. select a video capture device (as source) ->Font.CharsetDEFAULT_CHARSET
Font.ColorclWindowTextFont.Height�	Font.NameMS Sans Serif
Font.StylefsBold 
ParentFont  TLabelLabel4LefthToptWidth� HeightCaption'source video capture device selected ->  TLabelLabel7LeftTopbWidth� HeightCaption*(must not be the DV device selected in 1.)Font.CharsetDEFAULT_CHARSET
Font.ColorclRedFont.Height�	Font.NameMS Sans Serif
Font.Style 
ParentFont  	TComboBoxcboDestinationDVDevicesLeft0TopWidth�HeightFont.CharsetDEFAULT_CHARSET
Font.ColorclWindowTextFont.Height�	Font.NameMS Sans Serif
Font.Style 
ItemHeight
ParentFontTabOrder TextcboDestinationDVDevicesOnChangecboDestinationDVDevicesChange  TVideoGrabberVideoGrabberLeft0Top� Width�HeightAASFMediaServerPublishingPoint1http://YourWindowsMediaServer/YourPublishingPointASFVideoWidth@AudioCompressor AutoFilePrefixvgDroppedFramesPollingInterval
DualDisplay_Left�DualDisplay_Top
DVEncoder_VideoStandarddvs_PALCropping_Zoom       ��?MotionDetector_Gridn5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 MultiplexedStabilizationDelayPlayerSpeedRatio       ��?!RecordingOnMotion_MotionThreshold �O��n��?TextOverlay_Font.CharsetDEFAULT_CHARSETTextOverlay_Font.ColorclAquaTextOverlay_Font.Height�TextOverlay_Font.NameMS Sans SerifTextOverlay_Font.Style TextOverlay_String  Note: the date/time formats 
can be easily modified.

system date/time: %sys_time[dd/mm/yy hh:nn:ss]%
DV time code: %time_code%
DV date/time: %dv_time[dd/mm/yy hh:nn:ss]%
frame count: %frame_count%
time (full): %time_full%
time (sec): %time_sec%
time (ns): %time_100ns%VideoCompression_Quality       ��?VideoCompressor VideoFromImages_TemporaryFileSetOfBitmaps01.dat#VideoProcessing_RotationCustomAngle       �@VideoSource_FileOrURL&http://www.datastead.com/demo/demo.wmvOnLogVideoGrabberLog  TEditedtDestinationDVdeviceLeft0Top0Width�HeightColorclSilverTabOrderTextedtDestinationDVdevice  TButtonbtnStartLeftxTop� WidthIHeightCaptionStartTabOrderOnClickbtnStartClick  TMemommoLogLeftTop� WidthHeightALines.StringsmmoLog TabOrder  TButtonButton1Left�Top� WidthAHeightCaptionStopTabOrderOnClickButton1Click  	TComboBoxcboVideoCaptureDevicesLeft0TopPWidth�HeightFont.CharsetDEFAULT_CHARSET
Font.ColorclWindowTextFont.Height�	Font.NameMS Sans Serif
Font.Style 
ItemHeight
ParentFontTabOrderTextcboVideoCaptureDevicesOnChangecboVideoCaptureDevicesChange  TEditedtSourceVideoCaptureDeviceLeft0ToppWidth�HeightColorclSilverTabOrderTextedtSourceVideoCaptureDevice   