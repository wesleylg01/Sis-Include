˙
 TFRMMASTER 0  TPF0
TfrmMaster	frmMasterLeftwTop¤ WidthHeight CaptionMaster componentColor	clBtnFaceFont.CharsetDEFAULT_CHARSET
Font.ColorclWindowTextFont.Heightõ	Font.NameMS Sans Serif
Font.Style OldCreateOrderOnCreate
FormCreateOnShowFormShowPixelsPerInch`
TextHeight TLabelLabel1LeftTopWidthgHeightCaptionvideo capture device:  TLabelLabel2LeftTop,Width/HeightCaption
video size  TLabelLabel3Left  Top,Width4HeightCaptionvideo input  TLabelLabel4Left(Top,WidthiHeightCaptionanalog video standard  	TComboBoxcboVideoDevicesLeftTopWidth	Height
ItemHeightTabOrder Text#SELECT FIRST A VIDEO CAPTURE DEVICEOnChangecboVideoDevicesChange  TButtonbtnStartMasterLeftTop^Width8HeightCaptionStartTabOrderOnClickbtnStartMasterClick  TButtonbtnStopMasterLeftHTop^Width8HeightCaptionStopTabOrderOnClickbtnStopMasterClick  TButtonbtnNoPreviewLeft Top^Widthņ HeightCaption,disable master component preview (saves CPU)TabOrderOnClickbtnNoPreviewClick  TVideoGrabberVideoGrabberMasterLeftČTopWidthqHeightUASFMediaServerPublishingPoint1http://YourWindowsMediaServer/YourPublishingPointASFVideoWidth@AssociateAudioAndVideoDevices	AudioCompressor AutoFilePrefixvgAVIFormatOpenDMLDualDisplay_LeftDualDisplay_Top
DVEncoder_VideoStandarddvs_PALCropping_Zoom       ˙?MotionDetector_Gridn5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 %MotionDetector_MaxDetectionsPerSecond        @MultiplexedRolemr_MultiplexedMasterMultiplexedStabilizationDelayPlayerSpeedRatio       ˙?!RecordingOnMotion_MotionThreshold āOnõ?SpeakerControl	TextOverlay_Font.CharsetDEFAULT_CHARSETTextOverlay_Font.ColorclAquaTextOverlay_Font.HeightõTextOverlay_Font.NameMS Sans SerifTextOverlay_Font.Style TextOverlay_String  Note: the date/time formats are
standard and can be modified.

system date/time: %sys_time[dd/mm/yy hh:nn:ss]%
DV time code: %time_code%
DV date/time: %dv_time[dd/mm/yy hh:nn:ss]%
frame count: %frame_count%
time (full): %time_full%
time (sec): %time_sec%
time (ns): %time_100ns%TVUseFrequencyOverrides	VideoCompression_Quality       ˙?VideoCompressor VideoFromImages_TemporaryFileSetOfBitmaps01.dat#VideoProcessing_RotationCustomAngle       ļ@VideoRenderervr_StandardRendererVideoSource_FileOrURL&http://www.datastead.com/demo/demo.wmvOnLogVideoGrabberMasterLogOnVideoDeviceSelected%VideoGrabberMasterVideoDeviceSelected  TMemommoLogLeft@TopWidthIHeightjLines.StringsmmoLog TabOrder  	TComboBoxcboVideoSizeLeftTop:Width Height
ItemHeightTabOrderOnChangecboVideoSizeChange  	TComboBoxcboVideoInputLeft  Top:Width Height
ItemHeightTabOrderOnChangecboVideoInputChange  	TComboBoxcboAnalogVideoStandardLeft(Top:Width Height
ItemHeightTabOrderOnChangecboAnalogVideoStandardChange  	TCheckBoxchkMultiplexedInputEmulationLeft TopWidth HeightCaptionemulate input switchingFont.CharsetDEFAULT_CHARSET
Font.ColorclWindowTextFont.Heightõ	Font.NameMS Sans Serif
Font.StylefsBold 
ParentFontTabOrder	OnClick!chkMultiplexedInputEmulationClick   