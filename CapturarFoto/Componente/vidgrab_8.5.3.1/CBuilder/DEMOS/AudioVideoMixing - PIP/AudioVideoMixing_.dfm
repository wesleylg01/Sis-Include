�
 TFORM1 0�  TPF0TForm1Form1Left�Top� WidthKHeight�Caption6Mix audio and video from one video source to the otherColor	clBtnFaceFont.CharsetDEFAULT_CHARSET
Font.ColorclWindowTextFont.Height�	Font.NameMS Sans Serif
Font.Style OldCreateOrderOnCloseQueryFormCloseQueryOnCreate
FormCreate	OnDestroyFormDestroyPixelsPerInch`
TextHeight TLabelLabel2LeftTopWidth� HeightCaption.source 1 (src1, makes the audio/video mixing")  TLabelLabel1Left�TopWidth� HeightCaption4source 2 (src2, pass video and audio frames to src1)  TSpeedButtonbtnPlayerOpenFileLeft�TopWidth� HeightCaptionor open a video clip...
Glyph.Data
z  v  BMv      v   (                                       �  �   �� �   � � ��   ���   �  �   �� �   � � ��  ��� UUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUU_�����UU     UUUwwwww_UP����UWu�UUUu�P𸸸��UW�_UUUW_P�����W�u����P��    W�WwwwwuP�����UUW�UUUW�UP�����UUW�UU_�UUP��� UUW_UUwuUUU��UUUUUu��UUUUUp UUUUUWwuUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUU	NumGlyphsOnClickbtnPlayerOpenFileClick  TSpeedButtonbtnMixPlayerOpenFileLeftTopWidth� HeightCaptionor mix with a video clip...
Glyph.Data
z  v  BMv      v   (                                       �  �   �� �   � � ��   ���   �  �   �� �   � � ��  ��� UUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUU_�����UU     UUUwwwww_UP����UWu�UUUu�P𸸸��UW�_UUUW_P�����W�u����P��    W�WwwwwuP�����UUW�UUUW�UP�����UUW�UU_�UUP��� UUW_UUwuUUU��UUUUUu��UUUUUp UUUUUWwuUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUU	NumGlyphsOnClickbtnMixPlayerOpenFileClick  TLabelLabel3LefthTop`WidthHeight'Captionsrc1 audio levelWordWrap	  TLabelLabel4Left�Top`WidthHeight'Captionsrc2 audio levelWordWrap	  TButtonbtnSrc1StartLeftTop8WidthIHeightCaptionstart previewTabOrder OnClickbtnSrc1StartClick  TButtonbtnSrc2StartLeft�Top8WidthQHeightCaptionstart previewTabOrderOnClickbtnSrc2StartClick  	TComboBoxcboVideoDevices1LeftTopWidth� HeightFont.CharsetDEFAULT_CHARSET
Font.ColorclWindowTextFont.Height�	Font.NameMS Sans Serif
Font.Style 
ItemHeight
ParentFontTabOrderTextSELECT THE FIRST CAPTURE DEVICEOnChangecboVideoDevices1Change  TButtonbtnSrc2StopLeftTop8WidthAHeightCaptionstopTabOrderOnClickbtnSrc2StopClick  TButtonbtnSrc1StopLeft� Top8Width!HeightCaptionstopTabOrderOnClickbtnSrc1StopClick  	TComboBoxcboVideoDevices2Left�TopWidth� HeightFont.CharsetDEFAULT_CHARSET
Font.ColorclWindowTextFont.Height�	Font.NameMS Sans Serif
Font.Style 
ItemHeight
ParentFontTabOrderText SELECT THE SECOND CAPTURE DEVICEOnChangecboVideoDevices2Change  TButtonbtnSrc1StartRecordingLeftXTop8WidthYHeightCaptionstart recordingTabOrderOnClickbtnSrc1StartRecordingClick  TVideoGrabberVideoGrabberSrc1LeftTopXWidthIHeight	FullRepaintASFMediaServerPublishingPoint1http://YourWindowsMediaServer/YourPublishingPointASFVideoWidth@AutoFilePrefixvgDualDisplay_Left
DVEncoder_VideoStandarddvs_PALCropping_Zoom       ��?MotionDetector_Gridn5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 MultiplexedStabilizationDelayPlayerSpeedRatio       ��?TextOverlay_Font.CharsetDEFAULT_CHARSETTextOverlay_Font.ColorclAquaTextOverlay_Font.Height�TextOverlay_Font.NameMS Sans SerifTextOverlay_Font.Style TextOverlay_String  Note: the date/time formats 
can be easily modified.

system date/time: %sys_time[dd/mm/yy hh:nn:ss]%
DV time code: %time_code%
DV date/time: %dv_time[dd/mm/yy hh:nn:ss]%
frame count: %frame_count%
time (full): %time_full%
time (sec): %time_sec%
time (ns): %time_100ns%VideoCompression_Quality       ��?VideoFromImages_TemporaryFileSetOfBitmaps01.dat#VideoProcessing_RotationCustomAngle       �@VideoSource_FileOrURL&http://www.datastead.com/demo/demo.wmvOnFrameOverlayUsingDC#VideoGrabberSrc1FrameOverlayUsingDCOnVideoDeviceSelected#VideoGrabberSrc1VideoDeviceSelected  TVideoGrabberVideoGrabberSrc2Left�TopXWidthIHeight	FullRepaintASFMediaServerPublishingPoint1http://YourWindowsMediaServer/YourPublishingPointASFVideoWidth@AutoFilePrefixvgDualDisplay_Left
DVEncoder_VideoStandarddvs_PALCropping_Zoom       ��?MotionDetector_Gridn5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 MultiplexedStabilizationDelayPlayerSpeedRatio       ��?TextOverlay_Font.CharsetDEFAULT_CHARSETTextOverlay_Font.ColorclAquaTextOverlay_Font.Height�TextOverlay_Font.NameMS Sans SerifTextOverlay_Font.Style TextOverlay_String  Note: the date/time formats 
can be easily modified.

system date/time: %sys_time[dd/mm/yy hh:nn:ss]%
DV time code: %time_code%
DV date/time: %dv_time[dd/mm/yy hh:nn:ss]%
frame count: %frame_count%
time (full): %time_full%
time (sec): %time_sec%
time (ns): %time_100ns%VideoCompression_Quality       ��?VideoFromImages_TemporaryFileSetOfBitmaps01.dat#VideoProcessing_RotationCustomAngle       �@VideoSource_FileOrURL&http://www.datastead.com/demo/demo.wmvOnFrameOverlayUsingDC#VideoGrabberSrc2FrameOverlayUsingDC
OnInactiveVideoGrabberSrc2InactiveOnRawAudioSampleVideoGrabberSrc2RawAudioSampleOnVideoDeviceSelected#VideoGrabberSrc2VideoDeviceSelected  TButtonbtnSrc1PlayLastRecordedLeft� Top8WidthaHeightCaptionplay last recordedTabOrder	OnClickbtnSrc1PlayLastRecordedClick  TButtonbtnSrc2ReplayLeft`Top8WidthyHeightCaptionreplay last clip playedTabOrder
OnClickbtnSrc2ReplayClick  TButtonbtnSrc1ReplayLeftHTop8Width)HeightCaptionreplayTabOrderOnClickbtnSrc1ReplayClick  	TTrackBartbrSrc1CurrentSourceLevelLefthTop� WidthHeight� MaxdOrientation
trVertical	FrequencyPosition SelEnd SelStart TabOrderThumbLength	TickMarkstmBottomRight	TickStyletsAutoOnChangetbrSrc1CurrentSourceLevelChange  	TTrackBartbrSrc1ExternalSourceLevelLeft�Top� WidthHeight� MaxdOrientation
trVertical	FrequencyPosition SelEnd SelStart TabOrderThumbLength	TickMarkstmBottomRight	TickStyletsAutoOnChange tbrSrc1ExternalSourceLevelChange  	TCheckBoxchkCombinedLefthTop`WidthAHeightCaptioncombinedTabOrderOnClickchkCombinedClick  TOpenDialogdlgOpenLeft�Top   