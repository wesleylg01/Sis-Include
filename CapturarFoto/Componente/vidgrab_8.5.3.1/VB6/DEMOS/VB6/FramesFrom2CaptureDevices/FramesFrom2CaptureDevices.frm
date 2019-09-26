VERSION 5.00
Object = "{FF3B1F41-D145-4555-B361-92A5E6DAE70D}#1.0#0"; "vidgrab_VB6.ocx"
Begin VB.Form FramesFrom2CaptureDevices 
   Caption         =   "TVideoGrabber- Capture frames from 2 video capture devices"
   ClientHeight    =   10590
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   18765
   LinkTopic       =   "Form1"
   ScaleHeight     =   10590
   ScaleWidth      =   18765
   StartUpPosition =   3  'Windows Default
   Begin vidgrab_VB6.VideoGrabberVB6 VideoGrabberVB62 
      Height          =   3375
      Left            =   11040
      TabIndex        =   1
      Top             =   2040
      Width           =   4095
      AnalogVideoStandard=   0
      AudioBalance    =   0
      AudioCompressor =   0
      AudioInput      =   0
      AudioInputBalance=   0
      AudioInputLevel =   50000
      AudioInputMono  =   0   'False
      AudioVolume     =   65535
      BufferCount     =   -1
      MpegStreamType  =   0
      PlaylistIndex   =   0
      PlayerDuration  =   1
      PlayerFramePosition=   0
      PlayerTimePosition=   0
      PropertyPageSaverGroup=   "Group01"
      RecordingBacktimedFramesCount=   0
      RecordingCanPause=   0   'False
      SendToDV_DeviceIndex=   -1
      SpeakerBalance  =   1
      SpeakerVolume   =   38798
      TextOverlay_Font=   487197403
      TVChannel       =   0
      TVCountryCode   =   0
      TVTunerInputType=   0
      UseClock        =   -1  'True
      VCRHorizontalLocking=   0   'False
      VideoCompressor =   0
      VideoInput      =   0
      VideoSize       =   0
      VideoSubtype    =   0
      Alignment       =   2
      Caption         =   ""
      Color           =   -16777201
      Enabled         =   -1  'True
      FullRepaint     =   0   'False
      ParentColor     =   0   'False
      Object.Visible         =   -1  'True
      ApplicationPriority=   0
      ASFAudioBitRate =   -1
      ASFAudioChannels=   -1
      ASFDeinterlaceMode=   0
      ASFFixedFrameRate=   0   'False
      ASFMediaServerPublishingPoint=   "http://YourWindowsMediaServer/YourPublishingPoint"
      ASFNetworkPort  =   0
      ASFNetworkMaxUsers=   5
      ASFProfile      =   -1
      ASFProfileFromCustomFile=   ""
      ASFVideoBitRate =   -1
      ASFVideoHeight  =   240
      ASFVideoMaxKeyFrameSpacing=   -1
      ASFVideoQuality =   -1
      ASFVideoWidth   =   320
      NetworkStreaming=   0
      NetworkStreamingType=   1
      AssociateAudioAndVideoDevices=   0   'False
      AVIDurationUpdated=   -1  'True
      AudioDevice     =   -1
      AudioFormat     =   0
      AudioDeviceRendering=   0   'False
      AudioPeakEvent  =   0   'False
      AudioRecording  =   0   'False
      AudioSource     =   0
      VuMeter         =   0
      AutoConnectRelatedPins=   -1  'True
      AutoFileName    =   0
      AutoFileNameMinDigits=   6
      AutoFilePrefix  =   "vg"
      AutoRefreshPreview=   -1  'True
      AutoStartPlayer =   -1  'True
      AVIFormatOpenDML=   -1  'True
      BackgroundColor =   0
      BorderStyle     =   1
      BurstCount      =   3
      BurstInterval   =   0
      BurstMode       =   0   'False
      BurstType       =   0
      CameraControlSettings=   -1  'True
      CaptureFileExt  =   ""
      ColorKeyEnabled =   0   'False
      CompressionMode =   0
      CompressionType =   0
      Display_Active  =   -1  'True
      Display_AutoSize=   -1  'True
      Display_AspectRatio=   0
      Display_Embedded=   -1  'True
      Display_FullScreen=   0   'False
      Display_Height  =   240
      Display_Left    =   10
      Display_StayOnTop=   0   'False
      Display_Monitor =   0
      Display_MouseMovesWindow=   -1  'True
      Display_Top     =   10
      Display_VideoPortEnabled=   -1  'True
      Display_Width   =   320
      DroppedFramesPollingInterval=   -1
      DualDisplay_Active=   0   'False
      DualDisplay_AutoSize=   -1  'True
      DualDisplay_AspectRatio=   0
      DualDisplay_Embedded=   0   'False
      DualDisplay_FullScreen=   0   'False
      DualDisplay_Height=   240
      DualDisplay_Left=   10
      DualDisplay_StayOnTop=   0   'False
      DualDisplay_Monitor=   0
      DualDisplay_MouseMovesWindow=   -1  'True
      DualDisplay_Top =   400
      DualDisplay_VideoPortEnabled=   -1  'True
      DualDisplay_Width=   320
      DVDiscontinuityMinimumInterval=   3
      DVEncoder_VideoFormat=   1
      DVEncoder_VideoResolution=   0
      DVEncoder_VideoStandard=   1
      DVRgb219        =   0   'False
      DVReduceFrameRate=   0   'False
      DVRecordingInNativeFormatSeparatesStreams=   0   'False
      EventNotificationSynchrone=   -1  'True
      Cropping_Enabled=   0   'False
      Cropping_Height =   120
      Cropping_Outbounds=   0   'False
      Cropping_Width  =   160
      Cropping_X      =   0
      Cropping_Y      =   0
      Cropping_Zoom   =   1
      FixFlickerOrBlackCapture=   0   'False
      FrameCaptureWithoutOverlay=   0   'False
      FrameCaptureZoomSize=   100
      FrameGrabber    =   0
      FrameGrabberRGBFormat=   0
      FrameRate       =   0
      HoldRecording   =   0   'False
      LicenseString   =   "N/A"
      JPEGPerformance =   0
      JPEGProgressiveDisplay=   0   'False
      JPEGQuality     =   100
      ImageOverlayEnabled=   0   'False
      LogoDisplayed   =   0   'False
      LogoLayout      =   1
      MotionDetector_CompareBlue=   -1  'True
      MotionDetector_CompareGreen=   -1  'True
      MotionDetector_GreyScale=   0   'False
      MotionDetector_CompareRed=   -1  'True
      MotionDetector_Enabled=   0   'False
      MotionDetector_Grid=   "5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 "
      MotionDetector_MaxDetectionsPerSecond=   0
      MotionDetector_ReduceCPULoad=   1
      MotionDetector_ReduceVideoNoise=   0   'False
      MotionDetector_Triggered=   0   'False
      MultiplexedInputEmulation=   -1  'True
      MultiplexedRole =   0
      MultiplexedSwitchDelay=   0
      MultiplexedStabilizationDelay=   1
      MuteAudioRendering=   0   'False
      NotificationMethod=   0
      NotificationSleepTime=   -1
      NotificationPriority=   3
      OverlayAfterTransform=   0   'False
      PlayerAudioRendering=   -1  'True
      PlayerDVSize    =   0
      PlayerFastSeekSpeedRatio=   4
      PlayerFileName  =   ""
      PlayerForcedCodec=   ""
      PlayerRefreshPausedDisplay=   -1  'True
      PlayerRefreshPausedDisplayFrameRate=   0
      PlayerSpeedRatio=   1
      PreallocCapFileCopiedAfterRecording=   -1  'True
      PreallocCapFileEnabled=   0   'False
      PreallocCapFileName=   ""
      PreallocCapFileSizeInMB=   100
      PreviewZoomSize =   100
      RecordingFileName=   ""
      RecordingInNativeFormat=   -1  'True
      RecordingMethod =   0
      RecordingPauseCreatesNewFile=   0   'False
      RecordingOnMotion_Enabled=   0   'False
      RecordingOnMotion_MotionThreshold=   0
      RecordingOnMotion_NoMotionPauseDelayMs=   5000
      Reencoding_NewVideoClip=   ""
      Reencoding_SourceVideoClip=   ""
      BusyCursor      =   11
      VideoCursor     =   0
      NormalCursor    =   0
      Reencoding_StartTime=   -1
      Reencoding_StopTime=   -1
      Reencoding_IncludeAudioStream=   -1  'True
      Reencoding_IncludeVideoStream=   -1  'True
      Reencoding_Method=   0
      Reencoding_UseAudioCompressor=   0   'False
      Reencoding_UseFrameGrabber=   -1  'True
      Reencoding_UseVideoCompressor=   0   'False
      Reencoding_WMVOutput=   -1  'True
      RawSampleCaptureLocation=   0
      RawVideoSampleCapture=   0   'False
      RawAudioSampleCapture=   0   'False
      RawCaptureAsyncEvent=   -1  'True
      RecordingSize   =   0
      ScreenRecordingThroughClipboard=   0   'False
      ScreenRecordingWithCursor=   -1  'True
      ShapeOverlayEnabled=   0   'False
      SpeakerControl  =   0   'False
      StoragePath     =   "H:\TVideoGrabber\Shareware\Demos\VB6\2Webcams"
      StoreDeviceSettingsInRegistry=   -1  'True
      Synchronized    =   0   'False
      SyncCommands    =   -1  'True
      SyncPreview     =   0
      TextOverlay_Enabled=   0   'False
      TextOverlay_Left=   0
      TextOverlay_Top =   0
      TextOverlay_Right=   320
      TextOverlay_Shadow=   -1  'True
      TextOverlay_ShadowColor=   0
      TextOverlay_ShadowDirection=   7
      TextOverlay_BkColor=   16777215
      TextOverlay_Align=   0
      TextOverlay_FontColor=   16776960
      TextOverlay_String=   $"FramesFrom2CaptureDevices.frx":0000
      TextOverlay_Transparent=   -1  'True
      TranslateMouseCoordinates=   -1  'True
      TVUseFrequencyOverrides=   0   'False
      Version         =   "v7.5 build 196 (75.196), August 28, 2006 - Copyright ©2002-2006 Datastead"
      VideoDevice     =   -1
      VideoCompression_KeyFrameRate=   15
      VideoCompression_PFramesPerKeyFrame=   0
      VideoCompression_Quality=   1
      VideoCompression_WindowSize=   -1
      VideoControlSettings=   -1  'True
      VideoFromImages_BitmapsSortedBy=   0
      VideoFromImages_RepeatIndefinitely=   0   'False
      VideoFromImages_SourceDirectory=   "H:\TVideoGrabber\Shareware\Demos\VB6\2Webcams"
      VideoFromImages_TemporaryFile=   "SetOfBitmaps01.dat"
      VideoProcessing_Brightness=   0
      VideoProcessing_Contrast=   0
      VideoProcessing_Deinterlacing=   0
      VideoProcessing_FlipHorizontal=   0   'False
      VideoProcessing_FlipVertical=   0   'False
      VideoProcessing_GrayScale=   0   'False
      VideoProcessing_Hue=   0
      VideoProcessing_InvertColors=   0   'False
      VideoProcessing_Saturation=   0
      VideoProcessing_Rotation=   0
      VideoQualitySettings=   -1  'True
      VideoRenderer   =   0
      VideoRendererExternal=   0
      VideoSource     =   0
      VideoSource_FileOrURL=   "http://www.datastead.com/demo/demo.wmv"
      VideoSource_FileOrURL_StartTime=   -1
      VideoSource_FileOrURL_StopTime=   -1
      VideoVisibleWhenStopped=   0   'False
      ZoomCoeff       =   1000
      ZoomXCenter     =   0
      ZoomYCenter     =   0
      ParentBackground=   -1  'True
      DoubleBuffered  =   0   'False
   End
   Begin vidgrab_VB6.VideoGrabberVB6 VideoGrabberVB61 
      Height          =   3375
      Left            =   3360
      TabIndex        =   0
      Top             =   2040
      Width           =   3975
      AnalogVideoStandard=   0
      AudioBalance    =   0
      AudioCompressor =   0
      AudioInput      =   0
      AudioInputBalance=   0
      AudioInputLevel =   50000
      AudioInputMono  =   0   'False
      AudioVolume     =   65535
      BufferCount     =   -1
      MpegStreamType  =   0
      PlaylistIndex   =   0
      PlayerDuration  =   1
      PlayerFramePosition=   0
      PlayerTimePosition=   0
      PropertyPageSaverGroup=   "Group01"
      RecordingBacktimedFramesCount=   0
      RecordingCanPause=   0   'False
      SendToDV_DeviceIndex=   -1
      SpeakerBalance  =   1
      SpeakerVolume   =   38798
      TextOverlay_Font=   487197403
      TVChannel       =   0
      TVCountryCode   =   0
      TVTunerInputType=   0
      UseClock        =   -1  'True
      VCRHorizontalLocking=   0   'False
      VideoCompressor =   0
      VideoInput      =   0
      VideoSize       =   0
      VideoSubtype    =   0
      Alignment       =   2
      Caption         =   ""
      Color           =   -16777201
      Enabled         =   -1  'True
      FullRepaint     =   0   'False
      ParentColor     =   0   'False
      Object.Visible         =   -1  'True
      ApplicationPriority=   0
      ASFAudioBitRate =   -1
      ASFAudioChannels=   -1
      ASFDeinterlaceMode=   0
      ASFFixedFrameRate=   0   'False
      ASFMediaServerPublishingPoint=   "http://YourWindowsMediaServer/YourPublishingPoint"
      ASFNetworkPort  =   0
      ASFNetworkMaxUsers=   5
      ASFProfile      =   -1
      ASFProfileFromCustomFile=   ""
      ASFVideoBitRate =   -1
      ASFVideoHeight  =   240
      ASFVideoMaxKeyFrameSpacing=   -1
      ASFVideoQuality =   -1
      ASFVideoWidth   =   320
      NetworkStreaming=   0
      NetworkStreamingType=   1
      AssociateAudioAndVideoDevices=   0   'False
      AVIDurationUpdated=   -1  'True
      AudioDevice     =   -1
      AudioFormat     =   0
      AudioDeviceRendering=   0   'False
      AudioPeakEvent  =   0   'False
      AudioRecording  =   0   'False
      AudioSource     =   0
      VuMeter         =   0
      AutoConnectRelatedPins=   -1  'True
      AutoFileName    =   0
      AutoFileNameMinDigits=   6
      AutoFilePrefix  =   "vg"
      AutoRefreshPreview=   -1  'True
      AutoStartPlayer =   -1  'True
      AVIFormatOpenDML=   -1  'True
      BackgroundColor =   0
      BorderStyle     =   1
      BurstCount      =   3
      BurstInterval   =   0
      BurstMode       =   0   'False
      BurstType       =   0
      CameraControlSettings=   -1  'True
      CaptureFileExt  =   ""
      ColorKeyEnabled =   0   'False
      CompressionMode =   0
      CompressionType =   0
      Display_Active  =   -1  'True
      Display_AutoSize=   -1  'True
      Display_AspectRatio=   0
      Display_Embedded=   -1  'True
      Display_FullScreen=   0   'False
      Display_Height  =   240
      Display_Left    =   10
      Display_StayOnTop=   0   'False
      Display_Monitor =   0
      Display_MouseMovesWindow=   -1  'True
      Display_Top     =   10
      Display_VideoPortEnabled=   -1  'True
      Display_Width   =   320
      DroppedFramesPollingInterval=   -1
      DualDisplay_Active=   0   'False
      DualDisplay_AutoSize=   -1  'True
      DualDisplay_AspectRatio=   0
      DualDisplay_Embedded=   0   'False
      DualDisplay_FullScreen=   0   'False
      DualDisplay_Height=   240
      DualDisplay_Left=   10
      DualDisplay_StayOnTop=   0   'False
      DualDisplay_Monitor=   0
      DualDisplay_MouseMovesWindow=   -1  'True
      DualDisplay_Top =   400
      DualDisplay_VideoPortEnabled=   -1  'True
      DualDisplay_Width=   320
      DVDiscontinuityMinimumInterval=   3
      DVEncoder_VideoFormat=   1
      DVEncoder_VideoResolution=   0
      DVEncoder_VideoStandard=   1
      DVRgb219        =   0   'False
      DVReduceFrameRate=   0   'False
      DVRecordingInNativeFormatSeparatesStreams=   0   'False
      EventNotificationSynchrone=   -1  'True
      Cropping_Enabled=   0   'False
      Cropping_Height =   120
      Cropping_Outbounds=   0   'False
      Cropping_Width  =   160
      Cropping_X      =   0
      Cropping_Y      =   0
      Cropping_Zoom   =   1
      FixFlickerOrBlackCapture=   0   'False
      FrameCaptureWithoutOverlay=   0   'False
      FrameCaptureZoomSize=   100
      FrameGrabber    =   0
      FrameGrabberRGBFormat=   0
      FrameRate       =   0
      HoldRecording   =   0   'False
      LicenseString   =   "N/A"
      JPEGPerformance =   0
      JPEGProgressiveDisplay=   0   'False
      JPEGQuality     =   100
      ImageOverlayEnabled=   0   'False
      LogoDisplayed   =   0   'False
      LogoLayout      =   1
      MotionDetector_CompareBlue=   -1  'True
      MotionDetector_CompareGreen=   -1  'True
      MotionDetector_GreyScale=   0   'False
      MotionDetector_CompareRed=   -1  'True
      MotionDetector_Enabled=   0   'False
      MotionDetector_Grid=   "5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 "
      MotionDetector_MaxDetectionsPerSecond=   0
      MotionDetector_ReduceCPULoad=   1
      MotionDetector_ReduceVideoNoise=   0   'False
      MotionDetector_Triggered=   0   'False
      MultiplexedInputEmulation=   -1  'True
      MultiplexedRole =   0
      MultiplexedSwitchDelay=   0
      MultiplexedStabilizationDelay=   1
      MuteAudioRendering=   0   'False
      NotificationMethod=   0
      NotificationSleepTime=   -1
      NotificationPriority=   3
      OverlayAfterTransform=   0   'False
      PlayerAudioRendering=   -1  'True
      PlayerDVSize    =   0
      PlayerFastSeekSpeedRatio=   4
      PlayerFileName  =   ""
      PlayerForcedCodec=   ""
      PlayerRefreshPausedDisplay=   -1  'True
      PlayerRefreshPausedDisplayFrameRate=   0
      PlayerSpeedRatio=   1
      PreallocCapFileCopiedAfterRecording=   -1  'True
      PreallocCapFileEnabled=   0   'False
      PreallocCapFileName=   ""
      PreallocCapFileSizeInMB=   100
      PreviewZoomSize =   100
      RecordingFileName=   ""
      RecordingInNativeFormat=   -1  'True
      RecordingMethod =   0
      RecordingPauseCreatesNewFile=   0   'False
      RecordingOnMotion_Enabled=   0   'False
      RecordingOnMotion_MotionThreshold=   0
      RecordingOnMotion_NoMotionPauseDelayMs=   5000
      Reencoding_NewVideoClip=   ""
      Reencoding_SourceVideoClip=   ""
      BusyCursor      =   11
      VideoCursor     =   0
      NormalCursor    =   0
      Reencoding_StartTime=   -1
      Reencoding_StopTime=   -1
      Reencoding_IncludeAudioStream=   -1  'True
      Reencoding_IncludeVideoStream=   -1  'True
      Reencoding_Method=   0
      Reencoding_UseAudioCompressor=   0   'False
      Reencoding_UseFrameGrabber=   -1  'True
      Reencoding_UseVideoCompressor=   0   'False
      Reencoding_WMVOutput=   -1  'True
      RawSampleCaptureLocation=   0
      RawVideoSampleCapture=   0   'False
      RawAudioSampleCapture=   0   'False
      RawCaptureAsyncEvent=   -1  'True
      RecordingSize   =   0
      ScreenRecordingThroughClipboard=   0   'False
      ScreenRecordingWithCursor=   -1  'True
      ShapeOverlayEnabled=   0   'False
      SpeakerControl  =   0   'False
      StoragePath     =   "H:\TVideoGrabber\Shareware\Demos\VB6\2Webcams"
      StoreDeviceSettingsInRegistry=   -1  'True
      Synchronized    =   0   'False
      SyncCommands    =   -1  'True
      SyncPreview     =   0
      TextOverlay_Enabled=   0   'False
      TextOverlay_Left=   0
      TextOverlay_Top =   0
      TextOverlay_Right=   320
      TextOverlay_Shadow=   -1  'True
      TextOverlay_ShadowColor=   0
      TextOverlay_ShadowDirection=   7
      TextOverlay_BkColor=   16777215
      TextOverlay_Align=   0
      TextOverlay_FontColor=   16776960
      TextOverlay_String=   $"FramesFrom2CaptureDevices.frx":011A
      TextOverlay_Transparent=   -1  'True
      TranslateMouseCoordinates=   -1  'True
      TVUseFrequencyOverrides=   0   'False
      Version         =   "v7.5 build 196 (75.196), August 28, 2006 - Copyright ©2002-2006 Datastead"
      VideoDevice     =   -1
      VideoCompression_KeyFrameRate=   15
      VideoCompression_PFramesPerKeyFrame=   0
      VideoCompression_Quality=   1
      VideoCompression_WindowSize=   -1
      VideoControlSettings=   -1  'True
      VideoFromImages_BitmapsSortedBy=   0
      VideoFromImages_RepeatIndefinitely=   0   'False
      VideoFromImages_SourceDirectory=   "H:\TVideoGrabber\Shareware\Demos\VB6\2Webcams"
      VideoFromImages_TemporaryFile=   "SetOfBitmaps01.dat"
      VideoProcessing_Brightness=   0
      VideoProcessing_Contrast=   0
      VideoProcessing_Deinterlacing=   0
      VideoProcessing_FlipHorizontal=   0   'False
      VideoProcessing_FlipVertical=   0   'False
      VideoProcessing_GrayScale=   0   'False
      VideoProcessing_Hue=   0
      VideoProcessing_InvertColors=   0   'False
      VideoProcessing_Saturation=   0
      VideoProcessing_Rotation=   0
      VideoQualitySettings=   -1  'True
      VideoRenderer   =   0
      VideoRendererExternal=   0
      VideoSource     =   0
      VideoSource_FileOrURL=   "http://www.datastead.com/demo/demo.wmv"
      VideoSource_FileOrURL_StartTime=   -1
      VideoSource_FileOrURL_StopTime=   -1
      VideoVisibleWhenStopped=   0   'False
      ZoomCoeff       =   1000
      ZoomXCenter     =   0
      ZoomYCenter     =   0
      ParentBackground=   -1  'True
      DoubleBuffered  =   0   'False
   End
   Begin VB.CommandButton btnCaptureNframes 
      Caption         =   "capture 20 frames from both devices"
      Height          =   375
      Left            =   7560
      TabIndex        =   34
      Top             =   2640
      Width           =   3135
   End
   Begin VB.TextBox mmoLog 
      BackColor       =   &H80000016&
      Height          =   10095
      Left            =   120
      MultiLine       =   -1  'True
      TabIndex        =   33
      Top             =   240
      Width           =   3015
   End
   Begin VB.Frame destination 
      Caption         =   "destination:"
      Height          =   1335
      Left            =   7800
      TabIndex        =   29
      Top             =   3480
      Width           =   2775
      Begin VB.OptionButton rdgJpegFiles 
         Caption         =   "JPEG files"
         Height          =   255
         Left            =   240
         TabIndex        =   32
         Top             =   960
         Width           =   1215
      End
      Begin VB.OptionButton rdgBMPfiles 
         Caption         =   "BMP files"
         Height          =   255
         Left            =   240
         TabIndex        =   31
         Top             =   600
         Width           =   1215
      End
      Begin VB.OptionButton rdgMemoryBitmaps 
         Caption         =   "memory bitmaps"
         Height          =   255
         Left            =   240
         TabIndex        =   30
         Top             =   240
         Value           =   -1  'True
         Width           =   1455
      End
   End
   Begin VB.CommandButton btnStopPreview2 
      Caption         =   "stop preview"
      Height          =   255
      Left            =   14040
      TabIndex        =   28
      Top             =   1680
      Width           =   1095
   End
   Begin VB.PictureBox Picture2 
      Appearance      =   0  'Flat
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   3375
      Left            =   11040
      ScaleHeight     =   3345
      ScaleWidth      =   4065
      TabIndex        =   27
      Top             =   5520
      Width           =   4095
   End
   Begin VB.PictureBox Picture1 
      Appearance      =   0  'Flat
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   3375
      Left            =   3360
      ScaleHeight     =   3345
      ScaleWidth      =   3945
      TabIndex        =   26
      Top             =   5520
      Width           =   3975
   End
   Begin VB.CommandButton btnCaptureOneFrame 
      Caption         =   "capture one frame from both devices"
      Height          =   375
      Left            =   7560
      TabIndex        =   25
      Top             =   2040
      Width           =   3135
   End
   Begin VB.CommandButton btnStartPreview2 
      Caption         =   "start preview"
      Height          =   255
      Left            =   12840
      TabIndex        =   24
      Top             =   1680
      Width           =   1095
   End
   Begin VB.CommandButton btnStopPreview1 
      Caption         =   "stop preview"
      Height          =   255
      Left            =   4560
      TabIndex        =   23
      Top             =   1680
      Width           =   1095
   End
   Begin VB.CommandButton btnStartPreview1 
      Caption         =   "start preview"
      Height          =   255
      Left            =   3360
      TabIndex        =   22
      Top             =   1680
      Width           =   1095
   End
   Begin VB.Frame Frame2 
      Caption         =   "2nd video capture device"
      Height          =   1455
      Left            =   9360
      TabIndex        =   3
      Top             =   120
      Width           =   5775
      Begin VB.ComboBox cboAnalogVideoStandard2 
         Height          =   315
         Left            =   4080
         TabIndex        =   17
         Top             =   960
         Width           =   1575
      End
      Begin VB.ComboBox cboVideoSubtypes2 
         Height          =   315
         Left            =   2760
         TabIndex        =   16
         Top             =   960
         Width           =   1215
      End
      Begin VB.ComboBox cboVideoSizes2 
         Height          =   315
         Left            =   1440
         TabIndex        =   15
         Top             =   960
         Width           =   1215
      End
      Begin VB.ComboBox cboVideoInputs2 
         Height          =   315
         Left            =   120
         TabIndex        =   14
         Top             =   960
         Width           =   1215
      End
      Begin VB.ComboBox cboVideoDevices2 
         Height          =   315
         Left            =   120
         TabIndex        =   13
         Text            =   "SELECT FIRST A VIDEO CAPTURE DEVICE IN THIS LIST"
         Top             =   360
         Width           =   5295
      End
      Begin VB.Label Label8 
         Caption         =   "analog video standard"
         Height          =   255
         Left            =   4080
         TabIndex        =   21
         Top             =   720
         Width           =   1575
      End
      Begin VB.Label Label7 
         AutoSize        =   -1  'True
         Caption         =   "video size"
         Height          =   195
         Left            =   1440
         TabIndex        =   20
         Top             =   720
         Width           =   705
      End
      Begin VB.Label Label6 
         AutoSize        =   -1  'True
         Caption         =   "video subtype"
         Height          =   195
         Left            =   2760
         TabIndex        =   19
         Top             =   720
         Width           =   990
      End
      Begin VB.Label Label5 
         Caption         =   "video input"
         Height          =   255
         Left            =   120
         TabIndex        =   18
         Top             =   720
         Width           =   975
      End
   End
   Begin VB.Frame Frame1 
      Caption         =   "1st video capture device"
      Height          =   1455
      Left            =   3360
      TabIndex        =   2
      Top             =   120
      Width           =   5775
      Begin VB.ComboBox cboAnalogVideoStandard1 
         Height          =   315
         Left            =   4080
         TabIndex        =   8
         Top             =   960
         Width           =   1575
      End
      Begin VB.ComboBox cboVideoSubtypes1 
         Height          =   315
         Left            =   2760
         TabIndex        =   7
         Top             =   960
         Width           =   1215
      End
      Begin VB.ComboBox cboVideoSizes1 
         Height          =   315
         Left            =   1440
         TabIndex        =   6
         Top             =   960
         Width           =   1215
      End
      Begin VB.ComboBox cboVideoInputs1 
         Height          =   315
         Left            =   120
         TabIndex        =   5
         Top             =   960
         Width           =   1215
      End
      Begin VB.ComboBox cboVideoDevices1 
         Height          =   315
         Left            =   120
         TabIndex        =   4
         Text            =   "SELECT FIRST A VIDEO CAPTURE DEVICE IN THIS LIST"
         Top             =   360
         Width           =   5295
      End
      Begin VB.Label Label4 
         Caption         =   "analog video standard"
         Height          =   255
         Left            =   4080
         TabIndex        =   12
         Top             =   720
         Width           =   1575
      End
      Begin VB.Label Label3 
         AutoSize        =   -1  'True
         Caption         =   "video size"
         Height          =   195
         Left            =   1440
         TabIndex        =   11
         Top             =   720
         Width           =   705
      End
      Begin VB.Label Label2 
         AutoSize        =   -1  'True
         Caption         =   "video subtype"
         Height          =   195
         Left            =   2760
         TabIndex        =   10
         Top             =   720
         Width           =   990
      End
      Begin VB.Label Label1 
         Caption         =   "video input"
         Height          =   255
         Left            =   120
         TabIndex        =   9
         Top             =   720
         Width           =   975
      End
   End
End
Attribute VB_Name = "FramesFrom2CaptureDevices"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub btnCaptureNframes_Click()
   If rdgMemoryBitmaps.Value = True Then
        VideoGrabberVB61.BurstType = fc_TBitmap
        VideoGrabberVB62.BurstType = fc_TBitmap
   ElseIf rdgBMPfiles.Value = True Then
        VideoGrabberVB61.BurstType = fc_BmpFile
        VideoGrabberVB62.BurstType = fc_BmpFile
   Else
        VideoGrabberVB61.BurstType = fc_JpegFile
        VideoGrabberVB62.BurstType = fc_JpegFile
   End If

   VideoGrabberVB61.BurstCount = 20 ' set 0 to capture indefinitely
   VideoGrabberVB62.BurstCount = 20 ' set 0 to capture indefinitely
   
   VideoGrabberVB61.BurstMode = True
   VideoGrabberVB62.BurstMode = True
End Sub

Private Sub Form_Load()
  
   AssignListToComboBox cboVideoDevices1, VideoGrabberVB61.VideoDevices, VideoGrabberVB61.VideoDevice ' this will raise the OnVideoDeviceSelected event that will update the VB controls that depends of the video capture device (like VideoInputs list, the VideoSizes list, etc...)
   
   VideoGrabberVB61.Display_AutoSize = False
   VideoGrabberVB61.AutoFilePrefix = "1st"
   Picture1.AutoRedraw = True
   
   AssignListToComboBox cboVideoDevices2, VideoGrabberVB62.VideoDevices, VideoGrabberVB62.VideoDevice ' this will raise the OnVideoDeviceSelected event that will update the VB controls that depends of the video capture device (like VideoInputs list, the VideoSizes list, etc...)
   VideoGrabberVB62.Display_AutoSize = False
   VideoGrabberVB62.AutoFilePrefix = "2nd"
   Picture2.AutoRedraw = True
End Sub

Private Sub cboVideoDevices1_Click()
   VideoGrabberVB61.VideoDevice = cboVideoDevices1.ListIndex
   ' when selecting another video device, the OnVideoDeviceSelected event occurs.
   ' be sure to refresh all your device-dependent controls from this event.
End Sub

Private Sub cboVideoDevices2_Click()
   VideoGrabberVB62.VideoDevice = cboVideoDevices2.ListIndex
   ' when selecting another video device, the OnVideoDeviceSelected event occurs.
   ' be sure to refresh all your device-dependent controls from this event.
End Sub

Private Sub VideoGrabberVB61_OnLog(ByVal LogType As vidgrab_VB6.TxLogType, ByVal Severity As String, ByVal InfoMsg As String)
    AddLog mmoLog, "[" + Severity + "] " + InfoMsg
End Sub

Private Sub VideoGrabberVB62_OnLog(ByVal LogType As vidgrab_VB6.TxLogType, ByVal Severity As String, ByVal InfoMsg As String)
    AddLog mmoLog, "[" + Severity + "] " + InfoMsg
End Sub

Private Sub VideoGrabberVB61_OnVideoDeviceSelected()
   cboVideoDevices1.Text = VideoGrabberVB61.VideoDeviceName
   AssignListToComboBox cboAnalogVideoStandard1, VideoGrabberVB61.AnalogVideoStandards, VideoGrabberVB61.AnalogVideoStandard
   AssignListToComboBox cboVideoSizes1, VideoGrabberVB61.VideoSizes, VideoGrabberVB61.VideoSize
   AssignListToComboBox cboVideoSubtypes1, VideoGrabberVB61.VideoSubtypes, VideoGrabberVB61.VideoSubtype
   AssignListToComboBox cboVideoInputs1, VideoGrabberVB61.VideoInputs, VideoGrabberVB61.VideoInput
End Sub

Private Sub VideoGrabberVB62_OnVideoDeviceSelected()
   cboVideoDevices2.Text = VideoGrabberVB62.VideoDeviceName
   AssignListToComboBox cboAnalogVideoStandard2, VideoGrabberVB62.AnalogVideoStandards, VideoGrabberVB62.AnalogVideoStandard
   AssignListToComboBox cboVideoSizes2, VideoGrabberVB62.VideoSizes, VideoGrabberVB62.VideoSize
   AssignListToComboBox cboVideoSubtypes2, VideoGrabberVB62.VideoSubtypes, VideoGrabberVB62.VideoSubtype
   AssignListToComboBox cboVideoInputs2, VideoGrabberVB62.VideoInputs, VideoGrabberVB62.VideoInput
End Sub

Private Sub btnStartPreview1_Click()
   VideoGrabberVB61.StartPreview
End Sub

Private Sub btnStartPreview2_Click()
   VideoGrabberVB62.StartPreview
End Sub

Private Sub btnStopPreview2_Click()
   VideoGrabberVB62.StopPreview
End Sub

Private Sub cboAnalogVideoStandard1_Click()
   VideoGrabberVB61.AnalogVideoStandard = cboAnalogVideoStandard1.ListIndex
End Sub

Private Sub cboAnalogVideoStandard2_Click()
   VideoGrabberVB62.AnalogVideoStandard = cboAnalogVideoStandard2.ListIndex
End Sub

Private Sub cboVideoInputs1_Click()
   VideoGrabberVB61.VideoInput = cboVideoInputs1.ListIndex
End Sub

Private Sub cboVideoInputs2_Click()
   VideoGrabberVB62.VideoInput = cboVideoInputs2.ListIndex
End Sub


Private Sub cboVideoSizes1_Click()
   VideoGrabberVB61.VideoSize = cboVideoSizes1.ListIndex
End Sub

Private Sub cboVideoSizes2_Click()
   VideoGrabberVB62.VideoSize = cboVideoSizes2.ListIndex
End Sub

Private Sub cboVideoSubtypes1_Click()
   VideoGrabberVB61.VideoSubtype = cboVideoSubtypes1.ListIndex
End Sub

Private Sub cboVideoSubtypes2_Click()
   VideoGrabberVB62.VideoSubtype = cboVideoSubtypes2.ListIndex
End Sub

Private Sub btnCaptureOneFrame_Click()
   VideoGrabberVB61.BurstMode = False
   VideoGrabberVB62.BurstMode = False
   
   If rdgMemoryBitmaps.Value = True Then
        VideoGrabberVB61.CaptureFrameTo fc_TBitmap, ""
        VideoGrabberVB62.CaptureFrameTo fc_TBitmap, ""
   ElseIf rdgBMPfiles.Value = True Then
        VideoGrabberVB61.CaptureFrameTo fc_BmpFile, ""
        VideoGrabberVB62.CaptureFrameTo fc_BmpFile, ""
   Else
        VideoGrabberVB61.CaptureFrameTo fc_JpegFile, ""
        VideoGrabberVB62.CaptureFrameTo fc_JpegFile, ""
   End If
End Sub

Private Sub VideoGrabberVB61_OnFrameCaptureCompleted(ByVal FrameBitmapHandle As Long, ByVal BitmapWidth As Long, ByVal BitmapHeight As Long, ByVal FrameNumber As Long, ByVal FrameTime As Double, ByVal DestType As vidgrab_VB6.TxFrameCaptureDest, ByVal FileName As String, ByVal Success As Boolean, ByVal FrameId As Long)
    Dim nDC As Long
    Dim OldBitmap As Long
        
    Picture1.Width = Screen.TwipsPerPixelX * BitmapWidth
    Picture1.Height = Screen.TwipsPerPixelY * BitmapHeight
        
    nDC = CreateCompatibleDC(0&)
    OldBitmap = SelectObject(nDC, FrameBitmapHandle)
    Call BitBlt(Picture1.hDC, 0, 0, BitmapWidth, BitmapHeight, nDC, 0, 0, vbSrcCopy)
    Call SelectObject(nDC, OldBitmap)
    Call DeleteDC(nDC)
        
    Picture1.Refresh
    
    If (DestType = fc_BmpFile) Or (DestType = fc_JpegFile) Then
        AddLog mmoLog, "#1: " + FileName
    End If
    
End Sub

Private Sub VideoGrabberVB62_OnFrameCaptureCompleted(ByVal FrameBitmapHandle As Long, ByVal BitmapWidth As Long, ByVal BitmapHeight As Long, ByVal FrameNumber As Long, ByVal FrameTime As Double, ByVal DestType As vidgrab_VB6.TxFrameCaptureDest, ByVal FileName As String, ByVal Success As Boolean, ByVal FrameId As Long)
    Dim nDC As Long
    Dim OldBitmap As Long
        
    Picture2.Width = Screen.TwipsPerPixelX * BitmapWidth
    Picture2.Height = Screen.TwipsPerPixelY * BitmapHeight
        
    nDC = CreateCompatibleDC(0&)
    OldBitmap = SelectObject(nDC, FrameBitmapHandle)
    Call BitBlt(Picture2.hDC, 0, 0, BitmapWidth, BitmapHeight, nDC, 0, 0, vbSrcCopy)
    Call SelectObject(nDC, OldBitmap)
    Call DeleteDC(nDC)
        
    Picture2.Refresh
    
    If (DestType = fc_BmpFile) Or (DestType = fc_JpegFile) Then
        AddLog mmoLog, "#2: " + FileName
    End If
    
End Sub

