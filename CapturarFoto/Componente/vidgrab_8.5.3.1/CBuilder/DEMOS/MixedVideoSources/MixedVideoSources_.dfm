�
 TFORM1 0  TPF0TForm1Form1Left�Top� Width<Height�CaptionForm1Color	clBtnFaceFont.CharsetDEFAULT_CHARSET
Font.ColorclWindowTextFont.Height�	Font.NameMS Sans Serif
Font.Style OldCreateOrderPositionpoScreenCenterOnCreate
FormCreatePixelsPerInch`
TextHeight TLabelLabel2LeftTop Width� HeightCaptionvideo capture device Source 1:  TLabelLabel1Left`Top Width�HeightCaptionSvideo capture device Source 2 (be sure not to select the same device than Source 1)  TLabelLabel3LeftTopWidthHeightCaption�this demo consists to capture all the frames of 2 video sources (Src1 and Src2), and to use the captured frames as source for a third TVideoGrabber component (Dest)Font.CharsetDEFAULT_CHARSET
Font.ColorclNavyFont.Height�	Font.NameMS Sans Serif
Font.Style 
ParentFont  TVideoGrabberVideoGrabberSrc1LeftToppWidthIHeightASFMediaServerPublishingPoint1http://YourWindowsMediaServer/YourPublishingPointASFVideoWidth@AudioCompressor AutoFilePrefixvgDroppedFramesPollingInterval
DualDisplay_Left�DualDisplay_Top
DVEncoder_VideoStandarddvs_PALCropping_Zoom       ��?MotionDetector_Gridn5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 MultiplexedStabilizationDelayPlayerSpeedRatio       ��?!RecordingOnMotion_MotionThreshold �O��n��?TextOverlay_Font.CharsetDEFAULT_CHARSETTextOverlay_Font.ColorclAquaTextOverlay_Font.Height�TextOverlay_Font.NameMS Sans SerifTextOverlay_Font.Style TextOverlay_String  Note: the date/time formats 
can be easily modified.

system date/time: %sys_time[dd/mm/yy hh:nn:ss]%
DV time code: %time_code%
DV date/time: %dv_time[dd/mm/yy hh:nn:ss]%
frame count: %frame_count%
time (full): %time_full%
time (sec): %time_sec%
time (ns): %time_100ns%VideoCompression_Quality       ��?VideoCompressor VideoFromImages_TemporaryFileSetOfBitmaps01.dat#VideoProcessing_RotationCustomAngle       �@VideoSource_FileOrURL&http://www.datastead.com/demo/demo.wmvOnFrameCaptureCompleted$VideoGrabberSrcFrameCaptureCompleted
OnInactiveVideoGrabberSrcInactiveOnVideoDeviceSelected#VideoGrabberSrc1VideoDeviceSelected  TButtonbtnSrc1StartLeftTopPWidthQHeightCaptionstart previewTabOrderOnClickbtnSrc1StartClick  TButtonbtnSrc2StartLeft`TopPWidthQHeightCaptionstart previewTabOrderOnClickbtnSrc2StartClick  TVideoGrabberVideoGrabberSrc2TagLeft`ToppWidthIHeightASFMediaServerPublishingPoint1http://YourWindowsMediaServer/YourPublishingPointASFVideoWidth@AudioCompressor AutoFilePrefixvgDroppedFramesPollingInterval
DualDisplay_Left�DualDisplay_Top
DVEncoder_VideoStandarddvs_PALCropping_Zoom       ��?MotionDetector_Gridn5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 MultiplexedStabilizationDelayPlayerSpeedRatio       ��?!RecordingOnMotion_MotionThreshold �O��n��?TextOverlay_Font.CharsetDEFAULT_CHARSETTextOverlay_Font.ColorclAquaTextOverlay_Font.Height�TextOverlay_Font.NameMS Sans SerifTextOverlay_Font.Style TextOverlay_String  Note: the date/time formats 
can be easily modified.

system date/time: %sys_time[dd/mm/yy hh:nn:ss]%
DV time code: %time_code%
DV date/time: %dv_time[dd/mm/yy hh:nn:ss]%
frame count: %frame_count%
time (full): %time_full%
time (sec): %time_sec%
time (ns): %time_100ns%VideoCompression_Quality       ��?VideoCompressor VideoFromImages_TemporaryFileSetOfBitmaps01.dat#VideoProcessing_RotationCustomAngle       �@VideoSource_FileOrURL&http://www.datastead.com/demo/demo.wmvOnFrameCaptureCompleted$VideoGrabberSrcFrameCaptureCompleted
OnInactiveVideoGrabberSrcInactiveOnVideoDeviceSelected#VideoGrabberSrc2VideoDeviceSelected  TButtonbtnSrc2StopLeft�TopPWidthIHeightCaptionstopTabOrderOnClickbtnSrc2StopClick  TButtonbtnSrc1StopLeft`TopPWidthIHeightCaptionstopTabOrderOnClickbtnSrc1StopClick  	TComboBoxcboVideoDevices1LeftTop0WidthIHeightFont.CharsetDEFAULT_CHARSET
Font.ColorclWindowTextFont.Height�	Font.NameMS Sans Serif
Font.Style 
ItemHeight
ParentFontTabOrderTextSELECT THE FIRST CAPTURE DEVICEOnChangecboVideoDevices1Change  	TComboBoxcboVideoDevices2Left`Top0WidthIHeightFont.CharsetDEFAULT_CHARSET
Font.ColorclWindowTextFont.Height�	Font.NameMS Sans Serif
Font.Style 
ItemHeight
ParentFontTabOrderText SELECT THE SECOND CAPTURE DEVICEOnChangecboVideoDevices2Change  	TGroupBox	GroupBox1LeftTopxWidth�HeightQCaption-destination (source 1 and source 2 are mixed)TabOrder TLabelLabel4LeftTopWidthkHeightCaptionswapping frame count:  TLabelLabel5Left�TopWidthHeightCaptionwidth:  TLabelLabel6Left.TopWidth HeightCaptionheight:  TLabelLabel7Left�TopWidthPHeightCaptionoutput frame rate  TButtonbtnDestStartLeftTopWidthIHeightCaptionstart previewTabOrder OnClickbtnDestStartClick  TEditedtMaxSwapFrameCountLeftTopWidth1HeightTabOrderText10OnChangeedtMaxSwapFrameCountChange  TEditedtDestWidthLeft�TopWidth1HeightTabOrderText320  TEditedtDestHeightLeft0TopWidth1HeightTabOrderText240  TButton	btnSizeOkLefthTopWidthHeightCaptionokTabOrderOnClickbtnSizeOkClick  	TCheckBoxchkStopWhenAllDownLeft Top6Width� HeightCaptionstop when all sources downTabOrder  TButtonbtnStartRecordingLeftpTopWidthIHeightCaptionstart recordingTabOrderOnClickbtnStartRecordingClick  TButtonButton2LeftTop4Width� HeightCaptionstopTabOrderOnClickbtnDestStopClick  TEditedtOutputFrameRateLeft�TopWidth)HeightTabOrderText0  TButtonbtnFrameRateOkLeft�TopWidthHeightCaptionokTabOrder	OnClickbtnFrameRateOkClick  TButtonbtnPlayRecordedLeft� TopWidthIHeightCaptionplay recordedTabOrder
OnClickbtnPlayRecordedClick   TVideoGrabberVideoGrabberDestLeftTop�WidthIHeight� ASFMediaServerPublishingPoint1http://YourWindowsMediaServer/YourPublishingPointASFVideoWidth@AudioCompressor AutoFilePrefixvgDroppedFramesPollingInterval
DualDisplay_Left�DualDisplay_Top
DVEncoder_VideoStandarddvs_PALCropping_Zoom       ��?MotionDetector_Gridn5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 MultiplexedStabilizationDelayPlayerSpeedRatio       ��?!RecordingOnMotion_MotionThreshold �O��n��?TextOverlay_Font.CharsetDEFAULT_CHARSETTextOverlay_Font.ColorclAquaTextOverlay_Font.Height�TextOverlay_Font.NameMS Sans SerifTextOverlay_Font.Style TextOverlay_String  Note: the date/time formats 
can be easily modified.

system date/time: %sys_time[dd/mm/yy hh:nn:ss]%
DV time code: %time_code%
DV date/time: %dv_time[dd/mm/yy hh:nn:ss]%
frame count: %frame_count%
time (full): %time_full%
time (sec): %time_sec%
time (ns): %time_100ns%VideoCompression_Quality       ��?VideoCompressor VideoFromImages_TemporaryFileSetOfBitmaps01.dat#VideoProcessing_RotationCustomAngle       �@VideoSource_FileOrURL&http://www.datastead.com/demo/demo.wmvOnLogVideoGrabberDestLogOnPlayerOpenedVideoGrabberDestPlayerOpenedOnRecordingStarted VideoGrabberDestRecordingStarted!OnVideoFromBitmapsNextFrameNeeded/VideoGrabberDestVideoFromBitmapsNextFrameNeeded  TMemommoLogLeft�Top�Width� Height� Lines.StringsmmoLog TabOrder
   