�
 TFORM1 0�  TPF0TForm1Form1Left�TopWidth�HeightCaptionVideo from BMP or JPEG filesColor	clBtnFaceFont.CharsetDEFAULT_CHARSET
Font.ColorclWindowTextFont.Height�	Font.NameMS Sans Serif
Font.Style OldCreateOrderPositionpoScreenCenterOnCreate
FormCreatePixelsPerInch`
TextHeight TLabelLabel1LeftTopWidthiHeightCaptionQfirst of all, enter the folder in which where the BMP or JPEG files are located:   TLabelLabel2Left� Top&Width� HeightCaption!frame rate during recording(fps:)  TLabelLabel3Left� Top>Width� HeightCaption"real frame rate of the clip (fps:)  TLabelLabel4Left� TopPWidthHeightCaption?(it is possible to record faster than the normal playback rate)  TVideoGrabberVideoGrabberLeftTophWidth�HeightICaptionVideoGrabberASFMediaServerPublishingPoint1http://YourWindowsMediaServer/YourPublishingPointASFVideoWidth@AutoFilePrefixvgDroppedFramesPollingInterval
DualDisplay_Left�DualDisplay_Top
DVEncoder_VideoStandarddvs_PALCropping_Zoom       ��?FrameGrabberfg_PreviewStreamMotionDetector_Gridn5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 MultiplexedStabilizationDelayPlayerSpeedRatio       ��?!RecordingOnMotion_MotionThreshold �O��n��?TextOverlay_Font.CharsetDEFAULT_CHARSETTextOverlay_Font.ColorclAquaTextOverlay_Font.Height�TextOverlay_Font.NameMS Sans SerifTextOverlay_Font.Style TextOverlay_String  Note: the date/time formats 
can be easily modified.

system date/time: %sys_time[dd/mm/yy hh:nn:ss]%
DV time code: %time_code%
DV date/time: %dv_time[dd/mm/yy hh:nn:ss]%
frame count: %frame_count%
time (full): %time_full%
time (sec): %time_sec%
time (ns): %time_100ns%TVUseFrequencyOverrides	VideoCompression_Quality       ��?VideoFromImages_TemporaryFileSetOfBitmaps01.dat#VideoProcessing_RotationCustomAngle       �@VideoSource_FileOrURL&http://www.datastead.com/demo/demo.wmvOnAVIDurationUpdatedVideoGrabberAVIDurationUpdatedOnFrameProgressVideoGrabberFrameProgress
OnInactiveVideoGrabberInactiveOnLogVideoGrabberLogOnPlayerOpenedVideoGrabberPlayerOpenedOnPreviewStartedVideoGrabberPreviewStartedOnRecordingCompletedVideoGrabberRecordingCompletedOnRecordingStartedVideoGrabberRecordingStarted!OnVideoFromBitmapsNextFrameNeeded+VideoGrabberVideoFromBitmapsNextFrameNeeded  TButtonbtnStartPreviewLeft�Top"WidthPHeightCaptionstart previewTabOrderOnClickbtnStartPreviewClick  TEditedtFilesLocationLeft�TopWidthHeightTabOrderTextc:\MyBitmapsSourceDirectory  TButtonbtnStartRecordingLeftTop"WidthPHeightCaptionstart recordingTabOrderOnClickbtnStartRecordingClick  TButtonbtnStopLeftpTop"WidthPHeightCaptionstopTabOrderOnClickbtnStopClick  TMemommoLogLeftToppWidth� HeightIColorclSilverLines.StringsmmoLog TabOrder  TButtonbtnPlayLeftpTop:WidthPHeightCaptionplayTabOrderOnClickbtnPlayClick  TEditedtFrameProgressLeftTopXWidth� HeightColorclSilverTabOrderTextedtFrameProgress  TRadioGrouprdgSearchForBMPorJPEGLeftTop(Width� Height)Captionsearch for:Columns	ItemIndex Items.Strings	BMP files
JPEG files TabOrder  TEditedtRecordingFrameRateLeft�Top"Width!HeightTabOrder	Text50  TEditedtFinalFrameRateLeft�Top:Width!HeightTabOrder
Text10   