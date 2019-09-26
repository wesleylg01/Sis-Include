unit MainForm;

interface

uses
  Windows, Messages, SysUtils, Classes, Graphics, Controls, Forms, Dialogs,
  ExtCtrls, ComCtrls, StdCtrls, Buttons, Menus, VidGrab, Jpeg, ShellAPI;

const
  FreeHandMouseCoordinatesMax = 5000;

type
  TfrmMainForm = class(TForm)
    btnPlayerBackwards: TSpeedButton;
    btnPlayerFastForward: TSpeedButton;
    btnPlayerPause: TSpeedButton;
    btnPlayerRewind: TSpeedButton;
    btnPlayerStartPlaying: TSpeedButton;
    btnPlayerStop: TSpeedButton;
    edtFrameCount: TEdit;
    edtStoragePath: TEdit;
    edtDVDateTime: TEdit;
    grbPlayerControl: TGroupBox;
    Label52: TLabel;
    Label9: TLabel;
    mmoLog: TMemo;
    tbrPlayerProgress: TTrackBar;
    VideoGrabber: TVideoGrabber;
    pctMain: TPageControl;
    tbsVideoDevice: TTabSheet;
    rdgPreferredVideoSize: TRadioGroup;
    chkStretchPreferredVideoSize: TCheckBox;
    grbVideoDeviceDialogs: TGroupBox;
    btnDeviceDialog: TButton;
    btnStreamDialog: TButton;
    btnVideoQualityDialog: TButton;
    btnCameraControlDialog: TButton;
    btnVideoControlDialog: TButton;
    tbsAudio: TTabSheet;
    tbsRecording: TTabSheet;
    tbsASFStreaming: TTabSheet;
    grbDirectASFStreaming: TGroupBox;
    Label10: TLabel;
    Label24: TLabel;
    edtNetworkPort: TEdit;
    edtNetworkMaxUsers: TEdit;
    grbASFStreamingToWMServer: TGroupBox;
    Label32: TLabel;
    edtPublishingPoint: TEdit;
    tbsPlayer: TTabSheet;
    btnOpenLastClipRecorded: TSpeedButton;
    btnPlayerOpenFile: TSpeedButton;
    Label23: TLabel;
    Label8: TLabel;
    Label40: TLabel;
    Label41: TLabel;
    btnPlayerOpenStreamingURL: TSpeedButton;
    edtPlayerFastSeekSpeed: TEdit;
    edtPlayerSpeedRatio: TEdit;
    updPlayerFastSeekSpeed: TUpDown;
    btnAutoPlay: TCheckBox;
    edtPlayerClip: TEdit;
    tbsFrameGrabber: TTabSheet;
    Label42: TLabel;
    Label43: TLabel;
    rgdFrameGrabberFormat: TRadioGroup;
    rgdFrameGrabber: TRadioGroup;
    tbsClipReencoding: TTabSheet;
    TabSheet1: TTabSheet;
    mmoSensitivityGrid: TMemo;
    mmoMotionGrid: TMemo;
    tbsFrameOverlay: TTabSheet;
    grbTextOverlay: TGroupBox;
    Label13: TLabel;
    Label20: TLabel;
    Label22: TLabel;
    rdgTextOverlayAlign: TRadioGroup;
    chkTextOverlayEnabled: TCheckBox;
    chkTextOverlayTransparent: TCheckBox;
    mmoTextOverlayString: TMemo;
    edtTextOverlayTop: TEdit;
    edtTextOverlayLeft: TEdit;
    edtTextOverlayRight: TEdit;
    grbFreeHand: TGroupBox;
    chkFreeHandEnabled: TCheckBox;
    btnFreeHandErase: TButton;
    tbsVideoProcessing: TTabSheet;
    tbsDisplay: TTabSheet;
    chk1stVideoWindowActive: TCheckBox;
    grbMainVideoWindow: TGroupBox;
    chk1stEmbedded: TCheckBox;
    chk1stFullScreen: TCheckBox;
    chk1stStayOnTop: TCheckBox;
    chk1stUseVideoPort: TCheckBox;
    rdg1stDisplayedOn: TRadioGroup;
    chk1stMouseMovesWindow: TCheckBox;
    chk1stAutoSize: TCheckBox;
    btnEG1stNewLocation2: TButton;
    chk2ndVideoWindowActive: TCheckBox;
    grb2ndVideoWindow: TGroupBox;
    chk2ndEmbedded: TCheckBox;
    chk2ndFullScreen: TCheckBox;
    chk2ndStayOnTop: TCheckBox;
    chk2ndUseVideoPort: TCheckBox;
    rdg2ndDisplayedOn: TRadioGroup;
    chk2ndMouseMovesWindow: TCheckBox;
    chk2ndAutoSize: TCheckBox;
    btnEG2ndNewLocation2: TButton;
    tbsTuner: TTabSheet;
    lblTVTunerAvailable: TLabel;
    grbTunerCountryCode: TGroupBox;
    grbCountryCode: TGroupBox;
    edtCountryCode: TEdit;
    btnSetCountryCode: TButton;
    rdgTunerInputType: TRadioGroup;
    grbChannel: TGroupBox;
    edtTVChannel: TEdit;
    btnSelect: TButton;
    grbFrequencyOverride: TGroupBox;
    edtChannelFrequency: TEdit;
    btnDeleteFrequencyOverride: TButton;
    chkSetFrequencyOverride: TButton;
    chkEnableFrequencyOverrides: TCheckBox;
    grbTVScan: TGroupBox;
    btnStopScan: TButton;
    btnStartScan: TButton;
    mmoChannelLog: TMemo;
    chkPlayerAudioRendering: TCheckBox;
    grbFileNames: TGroupBox;
    rdgAutoFileName: TRadioGroup;
    Label46: TLabel;
    edtAVIAutoFilePrefix: TEdit;
    grbOneShot: TGroupBox;
    edtUseThisFileName: TEdit;
    btnOneShotTBitmap: TButton;
    btnOneShotBMPFile: TButton;
    btnOneShotJPEGFile: TButton;
    chkUseThisFileName: TCheckBox;
    grbBurstMode: TGroupBox;
    Label14: TLabel;
    Label15: TLabel;
    btnBurstModeBMPFile: TButton;
    btnBurstModeJPEGFile: TButton;
    edtBurstCount: TEdit;
    edtBurstInterval: TEdit;
    btnBurstModeStop: TButton;
    btnBurstModeTBitmap: TButton;
    grbZoomSize: TGroupBox;
    Label12: TLabel;
    tbrCaptureZoomSize: TTrackBar;
    edtCaptureZoomSize: TEdit;
    btnResetCaptureZoomSize: TButton;
    mmoFrameCaptureLog: TMemo;
    chkRefreshPausedDisplay: TCheckBox;
    grbReencodingSettings: TGroupBox;
    chkIncludeVideoStream: TCheckBox;
    chkIncludeAudioStream: TCheckBox;
    chkUseCurrentVideoCompressor: TCheckBox;
    chkUseCurrentAudioCompressor: TCheckBox;
    chkUseFrameGrabber: TCheckBox;
    chkWMVOutput: TCheckBox;
    btnSourceVideoClip: TSpeedButton;
    edtSourceVideoClip: TEdit;
    edtDestinationVideoClip: TEdit;
    Label75: TLabel;
    Label45: TLabel;
    grbStartStopTime: TGroupBox;
    Label78: TLabel;
    Label79: TLabel;
    edtReencStartTime: TEdit;
    edtReencDuration: TEdit;
    edtReencStopTime: TEdit;
    btnDuration: TButton;
    btnStartReencoding: TButton;
    btnStopReencoding: TButton;
    rdgReencodingMethod: TRadioGroup;
    btnOpenLastClipPlayed: TSpeedButton;
    grbVsVideoCaptureDevice: TGroupBox;
    Label2: TLabel;
    Label19: TLabel;
    cboVideoInputs: TComboBox;
    cboAnalogVideoStandard: TComboBox;
    cboVideoDevices: TComboBox;
    btnAutoRefreshPreview: TCheckBox;
    grbVsFileOrUrl: TGroupBox;
    edtVideoSourceFileOrUrl: TEdit;
    grbCropping: TGroupBox;
    Label85: TLabel;
    Label86: TLabel;
    Label87: TLabel;
    Label84: TLabel;
    Label88: TLabel;
    chkCroppingEnabled: TCheckBox;
    trkCroppingX: TTrackBar;
    trkCroppingY: TTrackBar;
    edtCroppingWidth: TEdit;
    edtCroppingHeight: TEdit;
    trkCroppingZoom: TTrackBar;
    chkCroppingOutbounds: TCheckBox;
    btnCroppingZoomReset: TButton;
    grbVMR9Adjust: TGroupBox;
    Label7: TLabel;
    tbrVMR9Brightness: TTrackBar;
    tbrVMR9Contrast: TTrackBar;
    tbrVMR9Saturation: TTrackBar;
    tbrVMR9Hue: TTrackBar;
    vmr9FixRange: TCheckBox;
    Label21: TLabel;
    btnSelectFileOrUrl: TSpeedButton;
    grbVideoSource: TGroupBox;
    cboVideoSource: TComboBox;
    grbPreview: TGroupBox;
    btnStartPreview: TBitBtn;
    btnStopPreview: TButton;
    grbFrameRate: TGroupBox;
    edtFrameRate: TEdit;
    btnFrameRate: TButton;
    Label53: TLabel;
    lblMotionDetectorRequiresFrameGrabber: TLabel;
    chkMotionDetectionEnabled: TCheckBox;
    chkReduceVideoNoise: TCheckBox;
    btnShowGridDialog: TButton;
    Label54: TLabel;
    chkCompareRed: TCheckBox;
    chkCompareGreen: TCheckBox;
    chkCompareBlue: TCheckBox;
    chk_GreyScale: TCheckBox;
    imgMotionDetected: TImage;
    grbMotionRatio: TGroupBox;
    shpMotionDetected: TShape;
    edtMotionRatio: TEdit;
    grbXYMaxMotion: TGroupBox;
    edtMaxMotionXY: TEdit;
    edtMaxMotionCoord: TEdit;
    grbCellsSensitivity: TGroupBox;
    Label57: TLabel;
    Label58: TLabel;
    Label59: TLabel;
    edtXCell: TEdit;
    updXCell: TUpDown;
    edtYCell: TEdit;
    updYCell: TUpDown;
    edtCellSensitivity: TEdit;
    updCellSensitivity: TUpDown;
    btnSetCellsSensitivity: TButton;
    grbGridSize: TGroupBox;
    Label55: TLabel;
    Label56: TLabel;
    edtGridColCount: TEdit;
    updGridColCount: TUpDown;
    edtGridRowCount: TEdit;
    updGridRowCount: TUpDown;
    btnApplyGridSize: TButton;
    grbGridString: TGroupBox;
    Label51: TLabel;
    lblGridValid: TLabel;
    shpGridValid: TShape;
    edtGrid: TEdit;
    updGlobalGridSensitivity: TUpDown;
    Label28: TLabel;
    grbSoftwareVideoProcessing: TGroupBox;
    rdgVideoRotation: TRadioGroup;
    rdgDeinterlacing: TRadioGroup;
    chkFlipVertical: TCheckBox;
    chkFlipHorizontal: TCheckBox;
    chkGreyScale: TCheckBox;
    chkInvertColors: TCheckBox;
    btnResetAll: TButton;
    tbrBrightness: TTrackBar;
    tbrConstrast: TTrackBar;
    tbrSaturation: TTrackBar;
    tbrHue: TTrackBar;
    Label31: TLabel;
    chkTriggered: TCheckBox;
    btnTriggerNow: TButton;
    btnOpenClip: TButton;
    btnPlayerCloseClip: TButton;
    btnGetClipDuration: TButton;
    btnGeneralInfo: TButton;
    btnHeaderInfo: TButton;
    grbAudioCaptureDevice: TGroupBox;
    Label26: TLabel;
    Label49: TLabel;
    Label36: TLabel;
    cboAudioDevices: TComboBox;
    cboAudioInputs: TComboBox;
    tbrAudioInputLevel: TTrackBar;
    tbrAudioInputBalance: TTrackBar;
    chkAudioInputMono: TCheckBox;
    grbAudioRendering: TGroupBox;
    Label1: TLabel;
    Label17: TLabel;
    tbrAudioVolume: TTrackBar;
    tbrAudioBalance: TTrackBar;
    chkMuteAudioRendering: TCheckBox;
    chkTextOverlayShadow: TCheckBox;
    rgdTextOverlayShadowDirection: TRadioGroup;
    updTextOverlaySize: TUpDown;
    Label33: TLabel;
    btnRenewRecordingFile: TButton;
    btnStopRecording: TButton;
    btnStartRecordingControlled: TBitBtn;
    btnStartRecordingImmediately: TBitBtn;
    chkAudioRecording: TCheckBox;
    Label5: TLabel;
    cboAudioFormats: TComboBox;
    chkPreserveNativeFormat: TCheckBox;
    btnNativeFormat: TButton;
    chkAVISaveToThisFile: TCheckBox;
    edtRecordingFileName: TEdit;
    chkPreallocFile: TCheckBox;
    edtPreallocSize: TEdit;
    Label11: TLabel;
    btnCreatePreallocFileNow: TButton;
    btnDlgAudioDevice: TButton;
    btnShowTunerDialog: TButton;
    btnAboutFrameRate: TButton;
    rdgVUMeters: TRadioGroup;
    pnLeftVUMeter: TPanel;
    pnRightVUMeter: TPanel;
    rdgNetworkStreaming: TRadioGroup;
    rdgNetworkStreamingType: TRadioGroup;
    grbASFSettings: TGroupBox;
    Label39: TLabel;
    Label44: TLabel;
    Label67: TLabel;
    Label68: TLabel;
    Label69: TLabel;
    Label70: TLabel;
    Label71: TLabel;
    Label83: TLabel;
    edtASFVideoWidth: TEdit;
    edtASFVideoHeight: TEdit;
    edtASFVideoBitRate: TEdit;
    edtASFVideoMaxKeyFrameSpacing: TEdit;
    edtASFVideoQuality: TEdit;
    edtASFAudioChannels: TEdit;
    cmbASFDeinterlaceMode: TComboBox;
    chkASFFixedFrameRate: TCheckBox;
    GroupBox2: TGroupBox;
    Label30: TLabel;
    btnStartAudioRendering: TButton;
    btnStartWAVRecording: TButton;
    btnStartMP3Recording: TButton;
    btnStopAudio: TButton;
    chkUseAudioOfVideoCaptureDevice: TCheckBox;
    btnViewDirectNetworkStreaming: TButton;
    btnStartASFRecording: TButton;
    chkUseClock: TCheckBox;
    chkEnableSnapshotButton: TCheckBox;
    rdgVideoRenderer: TRadioGroup;
    chkVideoVisibleWhenStopped: TCheckBox;
    chkChangeCursor: TCheckBox;
    chkBorder: TCheckBox;
    chkTransparency: TCheckBox;
    chkSetLogo: TCheckBox;
    imgLogo: TImage;
    grbPlaylist: TGroupBox;
    btnAddToPlaylist: TSpeedButton;
    chkPlaylistLoop: TCheckBox;
    btnPlaylistPlay: TButton;
    btnPlaylistNext: TButton;
    btnPlaylistPrevious: TButton;
    chkPlaylistRandom: TCheckBox;
    btnPlaylistStop: TButton;
    lstPlaylist: TListBox;
    btnClosePlaylist: TButton;
    rdg1AspectRatio: TRadioGroup;
    btnOneShotClipboard: TButton;
    btnBurstModeClipboard: TButton;
    cboAudioRenderers: TComboBox;
    btnResetAllOverrides: TButton;
    rdgTunerMode: TRadioGroup;
    btnSpecialControls: TButton;
    Label50: TLabel;
    edtPixellization: TEdit;
    updPixellization: TUpDown;
    rdgTextOverlaySelector: TRadioGroup;
    btnTextOverlayColor: TButton;
    btnBkgndColor: TButton;
    chk1stVisible: TCheckBox;
    chk2ndVisible: TCheckBox;
    rdgDetectVideoSignal: TRadioGroup;
    Label60: TLabel;
    edtCustomRotationAngle: TEdit;
    Label61: TLabel;
    Label62: TLabel;
    edtReencFrameCount: TEdit;
    edtReencStartFrame: TEdit;
    edtReencStopFrame: TEdit;
    Label63: TLabel;
    Label64: TLabel;
    rdgRecordingMethod: TRadioGroup;
    edtPublishingPointUsername: TEdit;
    edtPublishingPointPassword: TEdit;
    Label65: TLabel;
    Label66: TLabel;
    Label72: TLabel;
    Label73: TLabel;
    edtFrameCaptureWidth: TEdit;
    edtFrameCaptureHeight: TEdit;
    tbr1PanScan: TTrackBar;
    Label74: TLabel;
    rdg2AspectRatio: TRadioGroup;
    Label76: TLabel;
    tbr2PanScan: TTrackBar;
    btnTestPanScan: TButton;
    btnOpenAtFrames: TButton;
    btnOpenAtTimes: TButton;
    Label77: TLabel;
    Label80: TLabel;
    edtStartFrame: TEdit;
    edtStopFrame: TEdit;
    edtStartTime: TEdit;
    edtStopTime: TEdit;
    chkKeepBounds: TCheckBox;
    chkReopen: TCheckBox;
    Label89: TLabel;
    MainMenu1: TMainMenu;
    mnuFile: TMenuItem;
    mnuExit: TMenuItem;
    mnuSendDVCommands: TMenuItem;
    mnuDVPlay: TMenuItem;
    mnuDVStop: TMenuItem;
    mnuDVFreeze: TMenuItem;
    mnuDVThaw: TMenuItem;
    mnuDVFF: TMenuItem;
    mnuDVRew: TMenuItem;
    mnuDVRecord: TMenuItem;
    mnuDVRecordfreeze: TMenuItem;
    mnuDVRecordStrobe: TMenuItem;
    mnuDVStepFwd: TMenuItem;
    mnuDVStepRev: TMenuItem;
    mnuDVModeShuttle: TMenuItem;
    mnuDVPlayfastestfwd: TMenuItem;
    mnuDVPlayslowestfwd: TMenuItem;
    mnuDVPlayfastestrev: TMenuItem;
    mnuDVPlayslowestrev: TMenuItem;
    mnuAbout: TMenuItem;
    rdgProfileVersion: TRadioGroup;
    GroupBox3: TGroupBox;
    edtWM9Profile: TEdit;
    grbASFProfiles: TGroupBox;
    Label34: TLabel;
    lsbProfiles: TListBox;
    btnShowProfilesList: TButton;
    edtProfileIndex: TEdit;
    btnSelectWMV9Profile: TSpeedButton;
    tbsIPCameras: TTabSheet;
    lblChooseIPCamera: TLabel;
    edtIPCameraURL: TEdit;
    btnIPCamStartPreview: TButton;
    edtIPCamConnectionTimeout: TEdit;
    edtIPCamReceiveTimeout: TEdit;
    Label91: TLabel;
    Label92: TLabel;
    Label93: TLabel;
    btnCurrentIPCameraURL: TButton;
    Memo1: TMemo;
    GroupBox4: TGroupBox;
    Label94: TLabel;
    edtIPCamUserName: TEdit;
    Label95: TLabel;
    edtIPCamPassword: TEdit;
    grbBitmapOverlay: TGroupBox;
    Label48: TLabel;
    btnLoadImageOverlayFromFile: TSpeedButton;
    Label25: TLabel;
    chkImageOverlayEnabled: TCheckBox;
    edtImageOverlayLeft: TEdit;
    edtImageOverlayTop: TEdit;
    rdgImageOverlaySelector: TRadioGroup;
    chkImageOverlayTransparent: TCheckBox;
    chkImageOverlayUseTransparentColor: TCheckBox;
    edtImageOverlayTransparentColorValue: TEdit;
    btnImageOverlayPickupColor: TButton;
    btnImageOverlayPickupHelp: TButton;
    Label82: TLabel;
    Label96: TLabel;
    edtImageOverlayWidth: TEdit;
    edtImageOverlayHeight: TEdit;
    Label47: TLabel;
    chkImageOverlayAlphaBlend: TCheckBox;
    Label98: TLabel;
    edtIPCamCommand: TEdit;
    Label99: TLabel;
    btnIPCamSendCommand: TButton;
    VideoSourceFileOrUrl_UserName: TEdit;
    VideoSourceFileOrUrl_Password: TEdit;
    Label100: TLabel;
    Label101: TLabel;
    chkRenderAudioDevice: TCheckBox;
    chkAdjustPixelAspectRatio: TCheckBox;
    chkImageOverlayAlphablendCoeff: TTrackBar;
    chkImageOverlayChromaKey: TCheckBox;
    edtChromaKeyColorValue: TEdit;
    btnChooseChromaKeyColor: TButton;
    Label102: TLabel;
    edtChromaKeyLeewayPercent: TTrackBar;
    Label103: TLabel;
    btnImageOverlayPickupChromaHelp: TButton;
    chkPlayerLoop: TCheckBox;
    grbAudioSynchronization: TGroupBox;
    chkAudioSyncAdjust: TCheckBox;
    tbrAudioSyncAdjust: TTrackBar;
    edtAudioSyncAdjust: TEdit;
    GroupBox5: TGroupBox;
    grbRecordingTimer: TRadioGroup;
    Label29: TLabel;
    edtRecordingTimerInterval: TEdit;
    cboVideoFormats: TComboBox;
    Label81: TLabel;
    cboVideoSubtypes: TComboBox;
    Label104: TLabel;
    cboVideoSizes: TComboBox;
    Label4: TLabel;
    btnOpenDVD: TSpeedButton;
    btnCurrentDVDInfo: TSpeedButton;
    Label3: TLabel;
    edtTextOverlayScrollingSpeed: TEdit;
    chkPlayerTrackbarSynchrone: TCheckBox;
    tbrZoomY: TTrackBar;
    tbrZoomX: TTrackBar;
    tbrZoom: TTrackBar;
    Label18: TLabel;
    Label105: TLabel;
    Label107: TLabel;
    btnPausePreview: TButton;
    btnResumePreview: TButton;
    chk1stAlphablend: TCheckBox;
    chk1stTranspColor: TCheckBox;
    tbr1stAlphablend: TTrackBar;
    edt1sttranspColor: TEdit;
    chk2ndAlphaBlend: TCheckBox;
    chk2ndTranspColor: TCheckBox;
    edt2ndTranspColor: TEdit;
    tbr2ndAlphaBlend: TTrackBar;
    chkChangePixels: TCheckBox;
    chkDrawGridOverFrames: TCheckBox;
    chkDrawTarget: TCheckBox;
    Label27: TLabel;
    btnPlayerFrameStep: TSpeedButton;
    Options1: TMenuItem;
    Resetvideocapturedevicesettings1: TMenuItem;
    chkTextOverlayScrolling: TCheckBox;
    chkAdjustOverlayAspectRatio: TCheckBox;
    btnPIPFromAnotherTVideoGrabber: TSpeedButton;
    lblFrameOverlayRequiresFrameGrabber: TLabel;
    chkBlackMagicDecklink: TCheckBox;
    grbVsScreenRecording: TGroupBox;
    Label35: TLabel;
    Label90: TLabel;
    edtScreenRecordingWindow: TEdit;
    btnScreenRecordingWindow: TButton;
    edtMonitorNumber: TEdit;
    btnMonitorNumberInfo: TButton;
    chkScreenRecordingWithCursor: TCheckBox;
    chkRecordingCanPause: TCheckBox;
    chkRecordingPauseCreatesNewFile: TCheckBox;
    chkRecordingOnMotion: TCheckBox;
    btnPauseRecording: TButton;
    btnResumeRecording: TButton;
    Label6: TLabel;
    Label16: TLabel;
    Label38: TLabel;
    cboVideoCompressors: TComboBox;
    btnVideoCompressorSettings: TButton;
    cboAudioCompressors: TComboBox;
    btnAudioCompressorSettings: TButton;
    rdgCompressMode: TRadioGroup;
    rdgCompressType: TRadioGroup;
    btnSaveVideoCompressorSettings: TButton;
    btnReloadVideoCompressorSettings: TButton;
    btnSaveAudioCompressorSettings: TButton;
    btnReloadAudioCompressorSettings: TButton;
    cboMultiplexers: TComboBox;
    BtnCodecExamples: TButton;
    Button1: TButton;
    procedure btnAudioCompressorSettingsClick(Sender: TObject);
    procedure btnAutoPlayClick(Sender: TObject);
    procedure btnAutoRefreshPreviewClick(Sender: TObject);
    procedure btnBurstModeBMPFileClick(Sender: TObject);
    procedure btnBurstModeJPEGFileClick(Sender: TObject);
    procedure btnBurstModeStopClick(Sender: TObject);
    procedure btnBurstModeTBitmapClick(Sender: TObject);
    procedure btnCameraControlDialogClick(Sender: TObject);
    procedure btnDeleteFrequencyOverrideClick(Sender: TObject);
    procedure btnDeviceDialogClick(Sender: TObject);
    procedure btnEG1stNewLocation2Click(Sender: TObject);
    procedure btnEG2ndNewLocation2Click(Sender: TObject);
    procedure btnFrameRateClick(Sender: TObject);
    procedure btnFreeHandEraseClick(Sender: TObject);
    procedure btnOneShotBMPFileClick(Sender: TObject);
    procedure btnOneShotJPEGFileClick(Sender: TObject);
    procedure btnOneShotTBitmapClick(Sender: TObject);
    procedure btnPauseRecordingClick(Sender: TObject);
    procedure btnPlayerBackwardsClick(Sender: TObject);
    procedure btnPlayerCloseClipClick(Sender: TObject);
    procedure btnPlayerFastForwardClick(Sender: TObject);
    procedure btnOpenLastClipRecordedClick(Sender: TObject);
    procedure btnPlayerOpenFileClick(Sender: TObject);
    procedure btnPlayerPauseClick(Sender: TObject);
    procedure btnPlayerRewindClick(Sender: TObject);
    procedure btnPlayerStartPlayingClick(Sender: TObject);
    procedure btnPlayerStopClick(Sender: TObject);
    procedure btnResetAllClick(Sender: TObject);
    procedure btnResetAllOverridesClick(Sender: TObject);
    procedure btnResetCaptureZoomSizeClick(Sender: TObject);
    procedure btnResumeRecordingClick(Sender: TObject);
    procedure btnSelectClick(Sender: TObject);
    procedure btnSetCountryCodeClick(Sender: TObject);
    procedure btnStartRecordingImmediatelyClick(Sender: TObject);
    procedure btnStartPreviewClick(Sender: TObject);
    procedure btnStartScanClick(Sender: TObject);
    procedure btnStopRecordingClick(Sender: TObject);
    procedure btnStopPreviewClick(Sender: TObject);
    procedure btnStopScanClick(Sender: TObject);
    procedure btnStreamDialogClick(Sender: TObject);
    procedure btnVideoCompressorSettingsClick(Sender: TObject);
    procedure btnVideoControlDialogClick(Sender: TObject);
    procedure btnVideoQualityDialogClick(Sender: TObject);
    procedure cboAnalogVideoStandardChange(Sender: TObject);
    procedure cboAudioCompressorsChange(Sender: TObject);
    procedure cboAudioDevicesChange(Sender: TObject);
    procedure cboAudioFormatsChange(Sender: TObject);
    procedure cboAudioInputsChange(Sender: TObject);
    procedure cboVideoCompressorsChange(Sender: TObject);
    procedure cboVideoDevicesChange(Sender: TObject);
    procedure cboVideoInputsChange(Sender: TObject);
    procedure cboVideoSizesChange(Sender: TObject);
    procedure cboVideoSubtypesChange(Sender: TObject);
    procedure chk1stAutoSizeClick(Sender: TObject);
    procedure chk1stEmbeddedClick(Sender: TObject);
    procedure chk1stFullScreenClick(Sender: TObject);
    procedure chk1stMouseMovesWindowClick(Sender: TObject);
    procedure chk1stStayOnTopClick(Sender: TObject);
    procedure chk1stUseVideoPortClick(Sender: TObject);
    procedure chk1stVideoWindowActiveClick(Sender: TObject);
    procedure chk2ndAutoSizeClick(Sender: TObject);
    procedure chk2ndEmbeddedClick(Sender: TObject);
    procedure chk2ndFullScreenClick(Sender: TObject);
    procedure chk2ndMouseMovesWindowClick(Sender: TObject);
    procedure chk2ndStayOnTopClick(Sender: TObject);
    procedure chk2ndUseVideoPortClick(Sender: TObject);
    procedure chk2ndVideoWindowActiveClick(Sender: TObject);
    procedure chkRecordingCanPauseClick(Sender: TObject);
    procedure chkBorderClick(Sender: TObject);
    procedure chkFlipHorizontalClick(Sender: TObject);
    procedure chkFlipVerticalClick(Sender: TObject);
    procedure chkGreyScaleClick(Sender: TObject);
    procedure chkInvertColorsClick(Sender: TObject);
    procedure chkPlayerAudioRenderingClick(Sender: TObject);
    procedure chkPreallocFileClick(Sender: TObject);
    procedure chkRenderAudioDeviceClick(Sender: TObject);
    procedure chkStretchPreferredVideoSizeClick(Sender: TObject);
    procedure chkTextOverlayEnabledClick(Sender: TObject);
    procedure chkTextOverlayTransparentClick(Sender: TObject);
    procedure chkTransparencyClick(Sender: TObject);
    procedure chkUseThisFileNameClick(Sender: TObject);
    procedure edtAVIAutoFilePrefixChange(Sender: TObject);
    procedure edtBurstCountChange(Sender: TObject);
    procedure edtBurstIntervalChange(Sender: TObject);
    procedure edtPreallocSizeChange(Sender: TObject);
    procedure edtStoragePathChange(Sender: TObject);
    procedure edtTextOverlayLeftChange(Sender: TObject);
    procedure edtTextOverlayTopChange(Sender: TObject);
    procedure edtTextOverlayRightChange(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure mmoTextOverlayStringChange(Sender: TObject);
    procedure mnuAboutClick(Sender: TObject);
    procedure mnuExitClick(Sender: TObject);
    procedure rdg1stDisplayedOnClick(Sender: TObject);
    procedure rdg2ndDisplayedOnClick(Sender: TObject);
    procedure rdgAutoFileNameClick(Sender: TObject);
    procedure rdgCompressModeClick(Sender: TObject);
    procedure rdgCompressTypeClick(Sender: TObject);
    procedure rdgPreferredVideoSizeClick(Sender: TObject);
    procedure rdgTextOverlayAlignClick(Sender: TObject);
    procedure rdgTunerInputTypeClick(Sender: TObject);
    procedure rdgVideoRendererClick(Sender: TObject);
    procedure rgdFrameGrabberClick(Sender: TObject);
    procedure rgdFrameGrabberFormatClick(Sender: TObject);
    procedure SendVCRCommand (Sender: TObject);
    procedure tbrAudioBalanceChange(Sender: TObject);
    procedure tbrBrightnessChange(Sender: TObject);
    procedure tbrCaptureZoomSizeChange(Sender: TObject);
    procedure tbrConstrastChange(Sender: TObject);
    procedure tbrHueChange(Sender: TObject);
    procedure tbrSaturationChange(Sender: TObject);
    procedure updPlayerFastSeekSpeedClick(Sender: TObject; Button: TUDBtnType);
    procedure VideoGrabberDeviceArrivalOrRemoval(Sender: TObject; IsDeviceArrival, IsVideoDevice: Boolean; DeviceName: String; DeviceIndex: Integer);
    procedure VideoGrabberDeviceLost(Sender: TObject);
    procedure VideoGrabberDiskFull(Sender: TObject);
    procedure VideoGrabberMouseDown(Sender: TObject; VideoWindow: Integer; Button: TMouseButton; Shift: TShiftState; X, Y: Integer);
    procedure VideoGrabberMouseMove(Sender: TObject; VideoWindow: Integer; Shift: TShiftState; X, Y: Integer);
    procedure VideoGrabberMouseUp(Sender: TObject; VideoWindow: Integer; Button: TMouseButton; Shift: TShiftState; X, Y: Integer);
    procedure VideoGrabberPlayerEndOfStream(Sender: TObject);
    procedure VideoGrabberPreviewStarted(Sender: TObject);
    procedure VideoGrabberResize(Sender: TObject);
    procedure VideoGrabberResizeVideo(Sender: TObject; SourceWidth, SourceHeight: Integer);
    procedure VideoGrabberTVChannelScanCompleted(Sender: TObject);
    procedure VideoGrabberTVChannelScanStarted(Sender: TObject; MinChannel, MaxChannel: Integer);
    procedure tbrAudioInputLevelChange(Sender: TObject);
    procedure btnCreatePreallocFileNowClick(Sender: TObject);
    procedure chkSetFrequencyOverrideClick(Sender: TObject);
    procedure VideoGrabberDVCommandCompleted(Sender: TObject;
      NewStateValue: Integer; NewStateLabel: String);
    procedure chkEnableFrequencyOverridesClick(Sender: TObject);
    procedure rdgVideoRotationClick(Sender: TObject);
    procedure rdgDeinterlacingClick(Sender: TObject);
    procedure rdgNetworkStreamingClick(Sender: TObject);
    procedure rdgRecordingMethodClick(Sender: TObject);
    procedure edtPublishingPointChange(Sender: TObject);
    procedure edtNetworkPortChange(Sender: TObject);
    procedure edtNetworkMaxUsersChange(Sender: TObject);
    procedure btnShowProfilesListClick(Sender: TObject);
    procedure lsbProfilesClick(Sender: TObject);
    procedure edtProfileIndexChange(Sender: TObject);
    procedure chkCompareRedClick(Sender: TObject);
    procedure chkCompareGreenClick(Sender: TObject);
    procedure chkCompareBlueClick(Sender: TObject);
    procedure chk_GreyScaleClick(Sender: TObject);
    procedure chkReduceVideoNoiseClick(Sender: TObject);
    procedure edtGridChange(Sender: TObject);
    procedure updGlobalGridSensitivityClick(Sender: TObject;
      Button: TUDBtnType);
    procedure btnApplyGridSizeClick(Sender: TObject);
    procedure btnSetCellsSensitivityClick(Sender: TObject);
    procedure btnShowGridDialogClick(Sender: TObject);
    procedure chkMotionDetectionEnabledClick(Sender: TObject);
    procedure VideoGrabberPlayerBufferingData(Sender: TObject;
      StartingToBuffer: Boolean);
    procedure VideoGrabberAudioDeviceSelected(Sender: TObject);
    procedure VideoGrabberLog(Sender: TObject; LogType: TLogType; Severity,
      InfoMsg: String);
    procedure VideoGrabberVideoDeviceSelected(Sender: TObject);
    procedure tbrAudioInputBalanceChange(Sender: TObject);
    procedure chkAudioInputMonoClick(Sender: TObject);
    procedure VideoGrabberReinitializing(Sender: TObject);
    procedure VideoGrabberCopyPreallocDataStarted(Sender: TObject;
      SourceFile, DestFile: String);
    procedure VideoGrabberCopyPreallocDataCompleted(Sender: TObject;
      SourceFile, DestFile: String; Success: Boolean);
    procedure VideoGrabberCreatePreallocFileStarted(Sender: TObject;
      FileName: String);
    procedure VideoGrabberCreatePreallocFileCompleted(Sender: TObject;
      FileName: String; Success: Boolean);
    procedure VideoGrabberRecordingCompleted(Sender: TObject;
      FileName: String; Success: Boolean);
    procedure VideoGrabberRecordingStarted(Sender: TObject;
      FileName: String);
    procedure edtASFVideoWidthChange(Sender: TObject);
    procedure edtASFVideoHeightChange(Sender: TObject);
    procedure edtASFVideoBitRateChange(Sender: TObject);
    procedure edtASFVideoMaxKeyFrameSpacingChange(Sender: TObject);
    procedure edtASFVideoQualityChange(Sender: TObject);
    procedure edtASFAudioChannelsChange(Sender: TObject);
    procedure VideoGrabberReencodingStarted(Sender: TObject; SourceFile,
      DestFile: String);
    procedure VideoGrabberReencodingCompleted(Sender: TObject; SourceFile,
      DestFile: String; Success: Boolean);
    procedure btnViewDirectNetworkStreamingClick(Sender: TObject);
    procedure VideoGrabberInactive(Sender: TObject);
    procedure btnSourceVideoClipClick(Sender: TObject);
    procedure btnStartReencodingClick(Sender: TObject);
    procedure btnStopReencodingClick(Sender: TObject);
    procedure btnDurationClick(Sender: TObject);
    procedure VideoGrabberRecordingReadyToStart(Sender: TObject);
    procedure btnStartRecordingControlledClick(Sender: TObject);
    procedure chkRefreshPausedDisplayClick(Sender: TObject);
    procedure VideoGrabberPlayerOpened(Sender: TObject);
    procedure chkPreserveNativeFormatClick(Sender: TObject);
    procedure chkSetLogoClick(Sender: TObject);
    procedure VideoGrabberDirectNetworkStreamingHostUrl(Sender: TObject;
      HostUrl, HostName: String; HostPort: Integer);
    procedure btnOpenLastClipPlayedClick(Sender: TObject);
    procedure chkASFFixedFrameRateClick(Sender: TObject);
    procedure cmbASFDeinterlaceModeChange(Sender: TObject);
    procedure cboVideoSourceChange(Sender: TObject);
    procedure chkScreenRecordingWithCursorClick(Sender: TObject);
    procedure chkCroppingEnabledClick(Sender: TObject);
    procedure chkCroppingOutboundsClick(Sender: TObject);
    procedure edtCroppingWidthChange(Sender: TObject);
    procedure edtCroppingHeightChange(Sender: TObject);
    procedure trkCroppingZoomChange(Sender: TObject);
    procedure btnCroppingZoomResetClick(Sender: TObject);
    procedure trkCroppingYChange(Sender: TObject);
    procedure trkCroppingXChange(Sender: TObject);
    procedure tbrVMR9BrightnessChange(Sender: TObject);
    procedure tbrVMR9ContrastChange(Sender: TObject);
    procedure tbrVMR9SaturationChange(Sender: TObject);
    procedure tbrVMR9HueChange(Sender: TObject);
    procedure VideoGrabberGraphBuilt(Sender: TObject);
    procedure vmr9FixRangeClick(Sender: TObject);
    procedure chkChangeCursorClick(Sender: TObject);
    procedure btnSelectFileOrUrlClick(Sender: TObject);
    procedure edtVideoSourceFileOrUrlChange(Sender: TObject);
    procedure FormDestroy(Sender: TObject);
    procedure chkAudioRecordingClick(Sender: TObject);
    procedure tbrAudioVolumeChange(Sender: TObject);
    procedure chkMuteAudioRenderingClick(Sender: TObject);
    procedure btnRenewRecordingFileClick(Sender: TObject);
    procedure VideoGrabberCopyPreallocDataProgress(Sender: TObject;
      Percent: Integer; Position, Duration: Int64);
    procedure VideoGrabberCreatePreallocFileProgress(Sender: TObject;
      Percent: Integer; Position, Duration: Int64);
    procedure VideoGrabberReencodingProgress(Sender: TObject;
      Percent: Integer; Position, Duration: Int64);
    procedure VideoGrabberTVChannelSelected(Sender: TObject;
      Channel: Integer; Locked: Boolean; DefaultVideoFrequency,
      OverriddenVideoFrequency, TunerVideoFrequency,
      TunerAudioFrequency: Integer);
    procedure VideoGrabberFrameCaptureCompleted(Sender: TObject;
      FrameBitmap: TBitmap; BitmapWidth, BitmapHeight: Integer;
      FrameNumber: Cardinal; FrameTime: Int64; DestType: TFrameCaptureDest;
      FileName: String; Success: Boolean; FrameId: Integer);
    procedure VideoGrabberMotionDetected(Sender: TObject;
      GlobalMotionRatio: Double; MaxMotionCellX, MaxMotionCellY: Integer;
      FrameBitmap: TBitmap; FrameNumber: Cardinal; FrameTime: Int64;
      FrameId: Integer; var CaptureFrame: Boolean);
    procedure VideoGrabberMotionNotDetected(Sender: TObject;
      FrameBitmap: TBitmap; FrameNumber: Cardinal; FrameTime: Int64;
      FrameId: Integer; var CaptureFrame: Boolean);
    procedure btnNativeFormatClick(Sender: TObject);
    procedure btnLoadImageOverlayFromFileClick(Sender: TObject);
    procedure btnOpenClipClick(Sender: TObject);
    procedure btnGetClipDurationClick(Sender: TObject);
    procedure chkTriggeredClick(Sender: TObject);
    procedure btnTriggerNowClick(Sender: TObject);
    procedure chkRecordingPauseCreatesNewFileClick(Sender: TObject);
    procedure btnGeneralInfoClick(Sender: TObject);
    procedure btnHeaderInfoClick(Sender: TObject);
    procedure rdgVUMetersClick(Sender: TObject);
    procedure chkTextOverlayShadowClick(Sender: TObject);
    procedure rgdTextOverlayShadowDirectionClick(Sender: TObject);
    procedure updTextOverlaySizeClick(Sender: TObject; Button: TUDBtnType);
    procedure btnDlgAudioDeviceClick(Sender: TObject);
    procedure btnShowTunerDialogClick(Sender: TObject);
    procedure btnAboutFrameRateClick(Sender: TObject);
    procedure btnStartAudioRenderingClick(Sender: TObject);
    procedure btnStartMP3RecordingClick(Sender: TObject);
    procedure btnStartWAVRecordingClick(Sender: TObject);
    procedure btnStopAudioClick(Sender: TObject);
    procedure chkUseAudioOfVideoCaptureDeviceClick(Sender: TObject);
    procedure rdgNetworkStreamingTypeClick(Sender: TObject);
    procedure btnStartASFRecordingClick(Sender: TObject);
    procedure chkRecordingOnMotionClick(Sender: TObject);
    procedure chkUseClockClick(Sender: TObject);
    procedure btnScreenRecordingWindowClick(Sender: TObject);
    procedure chkVideoVisibleWhenStoppedClick(Sender: TObject);
    procedure btnAddToPlaylistClick(Sender: TObject);
    procedure btnPlaylistPlayClick(Sender: TObject);
    procedure btnPlaylistNextClick(Sender: TObject);
    procedure btnPlaylistPreviousClick(Sender: TObject);
    procedure btnPlaylistStopClick(Sender: TObject);
    procedure chkPlaylistLoopClick(Sender: TObject);
    procedure chkPlaylistRandomClick(Sender: TObject);
    procedure VideoGrabberPlayerEndOfPlaylist(Sender: TObject);
    procedure lstPlaylistClick(Sender: TObject);
    procedure btnClosePlaylistClick(Sender: TObject);
    procedure VideoGrabberDVDiscontinuity(Sender: TObject;
      var DeliverNewFrame: Boolean);
    procedure rdg1AspectRatioClick(Sender: TObject);
    procedure rdg2AspectRatioClick(Sender: TObject);
    procedure btnOneShotClipboardClick(Sender: TObject);
    procedure btnBurstModeClipboardClick(Sender: TObject);
    procedure cboAudioRenderersChange(Sender: TObject);
    procedure rdgTunerModeClick(Sender: TObject);
    procedure VideoGrabberClientConnection(Sender: TObject;
      Connected: Boolean; ClientInfo: String);
    procedure btnSpecialControlsClick(Sender: TObject);
    procedure updPixellizationClick(Sender: TObject; Button: TUDBtnType);
    procedure rdgTextOverlaySelectorClick(Sender: TObject);
    procedure btnTextOverlayColorClick(Sender: TObject);
    procedure btnBkgndColorClick(Sender: TObject);
    procedure chk1stVisibleClick(Sender: TObject);
    procedure chk2ndVisibleClick(Sender: TObject);
    procedure edtCustomRotationAngleChange(Sender: TObject);
    procedure edtFrameCaptureWidthChange(Sender: TObject);
    procedure edtFrameCaptureHeightChange(Sender: TObject);
    procedure tbr1PanScanChange(Sender: TObject);
    procedure tbr2PanScanChange(Sender: TObject);
    procedure btnTestPanScanClick(Sender: TObject);
    procedure btnOpenAtFramesClick(Sender: TObject);
    procedure btnOpenAtTimesClick(Sender: TObject);
    procedure edtMonitorNumberChange(Sender: TObject);
    procedure btnMonitorNumberInfoClick(Sender: TObject);
    procedure btnSelectWMV9ProfileClick(Sender: TObject);
    procedure rdgProfileVersionClick(Sender: TObject);
    procedure edtWM9ProfileChange(Sender: TObject);
    procedure tbsIPCamerasShow(Sender: TObject);
    procedure btnIPCamStartPreviewClick(Sender: TObject);
    procedure edtIPCameraURLChange(Sender: TObject);
    procedure edtIPCamConnectionTimeoutChange(Sender: TObject);
    procedure edtIPCamReceiveTimeoutChange(Sender: TObject);
    procedure btnCurrentIPCameraURLClick(Sender: TObject);
    procedure btnUrlConfClick(Sender: TObject);
    procedure chkImageOverlayEnabledClick(Sender: TObject);
    procedure rdgImageOverlaySelectorClick(Sender: TObject);
    procedure chkImageOverlayTransparentClick(Sender: TObject);
    procedure chkImageOverlayUseTransparentColorClick(Sender: TObject);
    procedure chkImageOverlayAlphaBlendClick(Sender: TObject);
    procedure updImageAlphaBendClick(Sender: TObject; Button: TUDBtnType);
    procedure edtImageOverlayTransparentColorValueChange(Sender: TObject);
    procedure edtImageOverlayLeftChange(Sender: TObject);
    procedure edtImageOverlayTopChange(Sender: TObject);
    procedure edtImageOverlayWidthChange(Sender: TObject);
    procedure edtImageOverlayHeightChange(Sender: TObject);
    procedure btnImageOverlayPickupColorClick(Sender: TObject);
    procedure btnImageOverlayPickupHelpClick(Sender: TObject);
    procedure btnIPCamSendCommandClick(Sender: TObject);
    procedure VideoSourceFileOrUrl_UserNameChange(Sender: TObject);
    procedure VideoSourceFileOrUrl_PasswordChange(Sender: TObject);
    procedure edtIPCamUserNameChange(Sender: TObject);
    procedure edtIPCamPasswordChange(Sender: TObject);
    procedure edtPublishingPointUsernameChange(Sender: TObject);
    procedure edtPublishingPointPasswordChange(Sender: TObject);
    procedure chkAdjustPixelAspectRatioClick(Sender: TObject);
    procedure edtChromaKeyColorValueChange(Sender: TObject);
    procedure edtChromaKeyLeewayPercentChange(Sender: TObject);
    procedure chkImageOverlayChromaKeyClick(Sender: TObject);
    procedure btnChooseChromaKeyColorClick(Sender: TObject);
    procedure btnImageOverlayPickupChromaHelpClick(Sender: TObject);
    procedure chkImageOverlayAlphablendCoeffChange(Sender: TObject);
    procedure chkPlayerLoopClick(Sender: TObject);
    procedure chkFreeHandEnabledClick(Sender: TObject);
    procedure chkDrawGridOverFramesClick(Sender: TObject);
    procedure VideoGrabberVideoFromBitmapsNextFrameNeeded(Sender: TObject;
      FirstSample: Boolean);
    procedure chkAudioSyncAdjustClick(Sender: TObject);
    procedure tbrAudioSyncAdjustChange(Sender: TObject);
    procedure chkAVISaveToThisFileClick(Sender: TObject);
    procedure edtRecordingFileNameChange(Sender: TObject);
    procedure edtRecordingTimerIntervalChange(Sender: TObject);
    procedure grbRecordingTimerClick(Sender: TObject);
    procedure cboVideoFormatsChange(Sender: TObject);
    procedure mmoLogKeyUp(Sender: TObject; var Key: Word;
      Shift: TShiftState);
    procedure btnOpenDVDClick(Sender: TObject);
    procedure btnCurrentDVDInfoClick(Sender: TObject);
    procedure edtTextOverlayScrollingSpeedChange(Sender: TObject);
    procedure chkChangePixelsClick(Sender: TObject);
    procedure chkPlayerTrackbarSynchroneClick(Sender: TObject);
    procedure tbrPlayerProgressChange(Sender: TObject);
    procedure tbrZoomChange(Sender: TObject);
    procedure tbrZoomYChange(Sender: TObject);
    procedure tbrZoomXChange(Sender: TObject);
    procedure VideoGrabberFrameProgress2(Sender: TObject;
      FrameInfo: pFrameInfo);
    procedure VideoGrabberFrameBitmap(Sender: TObject;
      FrameInfo: pFrameInfo; BitmapInfo: pFrameBitmapInfo);
    procedure btnPausePreviewClick(Sender: TObject);
    procedure btnResumePreviewClick(Sender: TObject);
    procedure chk1stAlphablendClick(Sender: TObject);
    procedure chk1stTranspColorClick(Sender: TObject);
    procedure edt1sttranspColorChange(Sender: TObject);
    procedure tbr1stAlphablendChange(Sender: TObject);
    procedure chk2ndAlphaBlendClick(Sender: TObject);
    procedure tbr2ndAlphaBlendChange(Sender: TObject);
    procedure chk2ndTranspColorClick(Sender: TObject);
    procedure edt2ndTranspColorChange(Sender: TObject);
    procedure btnPlayerFrameStepClick(Sender: TObject);
    procedure btnPIPFromAnotherTVideoGrabberClick(Sender: TObject);
    procedure VideoGrabberRecordingPaused(Sender: TObject);
    procedure Resetvideocapturedevicesettings1Click(Sender: TObject);
    procedure edtPlayerSpeedRatioChange(Sender: TObject);
    procedure btnSaveVideoCompressorSettingsClick(Sender: TObject);
    procedure btnReloadVideoCompressorSettingsClick(Sender: TObject);
    procedure btnSaveAudioCompressorSettingsClick(Sender: TObject);
    procedure btnReloadAudioCompressorSettingsClick(Sender: TObject);
    procedure chkAdjustOverlayAspectRatioClick(Sender: TObject);
    procedure chkTextOverlayScrollingClick(Sender: TObject);
    procedure chkBlackMagicDecklinkClick(Sender: TObject);
    procedure chkEnableSnapshotButtonClick(Sender: TObject);
    procedure cboMultiplexersChange(Sender: TObject);
    procedure BtnCodecExamplesClick(Sender: TObject);
    procedure Button1Click(Sender: TObject);
  private
    FStartupWidth: Integer;
    FStartupHeight: Integer;

    FTransparentForm: TForm;
    FTransparentPanel: TPanel;
    FSnapForm: TForm;
    FSnapImage: TImage;

    FKBWritten_LastReportTime: int64;

    FFreeHandMouseDrawing: array[0..FreeHandMouseCoordinatesMax+1] of TRect;
    FFreeHandMouseDrawingEnabled: boolean;
    FiFreeHandMouseDrawing: LongInt;

    FSearchBmpFiles: TSearchRec;
    FSearchBmpFilesOpened: Boolean;
    FSearchBmpPath: String;

    FOldVideoSignalState: Boolean;

    procedure ShowFormAboveVideo(Form: TForm);
    procedure RefreshDeviceControls;
    procedure RefreshDisplayOptions;
  end;

var
  frmMainForm: TfrmMainForm;

implementation

uses
   miscVideoQuality,
   miscCameraControl,
   miscVideoControl,
   miscSpecialControls;

const
   AUDIO_CLIPS = '*.mp3;*.wav;*.wma;*.mid';
   VIDEO_CLIPS = '*.mp*;*.vro;*.avi;*.asf;*.wmv;*.vob;*.avs;*.mov;*.divx;*.mp4;*.mts;*.3gp;*.swf;*.m2v;*.mkv;*.flv;*.wemb;*.ts;*.m4v;*.mp4v;*.ogg;*.amv;*.rm;*.m2t*';
   IMAGE_FILES = '*.jpg;*.jpeg;*.jpe;*.bmp;*.gif;*.png';
   OPEN_MEDIA_FILES = 'All media files|' + VIDEO_CLIPS + ';' + AUDIO_CLIPS + ';' + IMAGE_FILES
                    + '|Video clips|' + VIDEO_CLIPS
                    + '|Audio clips|' + AUDIO_CLIPS;
   OPEN_MEDIA_FILES_EXTENDED = OPEN_MEDIA_FILES
                    + '|Image files|' + IMAGE_FILES;
   OPEN_IMAGE_FILES = 'Image files|*.bmp;*.jpg;*.gif;*.png;*.tif;*.tiff;*.wmf;*.emf;*.exf;*.jpe;*.jpeg';
{$R *.DFM}

procedure AssignListToComboBox (ComboBox: TComboBox; List: String; Index: integer);
begin
   ComboBox.Items.Text := List;
   if (ComboBox.Items.Count > 0) and (Index >= 0) then begin
      ComboBox.ItemIndex := Index;
   end;
end;

procedure TfrmMainForm.FormCreate(Sender: TObject);
begin
   VideoGrabber.Display_AutoSize := true;    // the control will resize automatically
   VideoGrabber.AutoRefreshPreview := true;  // the preview will restart automatically when changing device properties (e.g. video size, analog video standard, etc...)

   FFreeHandMouseDrawingEnabled:= False; // used for free-hand mouse drawing
   FiFreeHandMouseDrawing:= 0;           // used for free-hand mouse drawing
   FSearchBmpFilesOpened := False;       // used for the "video from bitmaps" in the VideoGrabberVideoFromBitmaps_NextFrameNeeded event

   FKBWritten_LastReportTime := 0;        // used to store the last time, to report periodically the KB written from the OnFrameProgress event (in this demo every 5 seconds)

   FStartupWidth := Width;
   FStartupHeight := Height;

   FOldVideoSignalState := False;

   // - controls using global TVideoGrabber properties, e.g. like the VideoDevices list, are updated from the FormCreate event
   // - controls that depend of the current video device are set in the VideoDeviceSelected event
   // - controls that depend of the current audio device are set in the AudioDeviceSelected event

   ///////////////////////// Controls on main form
   edtStoragePath.Text := VideoGrabber.StoragePath;

   ///////////////////////// Video source tab
   AssignListToComboBox (cboVideoSource, VideoGrabber.VideoSources, Integer (VideoGrabber.VideoSource));
   AssignListToComboBox (cboVideoDevices, VideoGrabber.VideoDevices, VideoGrabber.VideoDevice);
   btnAutoRefreshPreview.Checked := VideoGrabber.AutoRefreshPreview;
   cboVideoSource.ItemIndex := Integer (VideoGrabber.VideoSource);
   chkScreenRecordingWithCursor.Checked := VideoGrabber.ScreenRecordingWithCursor;
   edtMonitorNumber.Text := IntToStr (VideoGrabber.ScreenRecordingMonitor);
   VideoGrabber.VideoSource_FileOrUrl := edtVideoSourceFileOrUrl.Text;

   ///////////////////////// Audio tab
   AssignListToComboBox (cboAudioDevices, VideoGrabber.AudioDevices, VideoGrabber.AudioDevice);
   AssignListToComboBox (cboAudioRenderers, VideoGrabber.AudioRenderers, VideoGrabber.AudioRenderer);
   chkRenderAudioDevice.Checked := VideoGrabber.AudioDeviceRendering;
   chkMuteAudioRendering.Checked := VideoGrabber.MuteAudioRendering;
   rdgVUMeters.ItemIndex := Integer (VideoGrabber.VUMeter);
   chkAudioSyncAdjust.Checked := VideoGrabber.AudioSyncAdjustmentEnabled;
   tbrAudioSyncAdjust.Position := VideoGrabber.AudioSyncAdjustment;
   edtAudioSyncAdjust.Text := IntToStr (tbrAudioSyncAdjust.Position);

   ///////////////////////// RECORDING tab
   rdgRecordingMethod.ItemIndex := Integer (VideoGrabber.RecordingMethod);
   edtPreallocSize.Text := IntToStr (VideoGrabber.PreallocCapFileSizeInMB);
   grbRecordingTimer.ItemIndex := Integer (VideoGrabber.RecordingTimer);
   AssignListToComboBox (cboAudioFormats, VideoGrabber.AudioFormats, integer (VideoGrabber.AudioFormat));
   if VideoGrabber.RecordingFileName <> '' then begin
      EdtRecordingFileName.Text := VideoGrabber.RecordingFileName;
      chkAVISaveToThisFile.Checked := true;
   end;
   chkRecordingCanPause.Checked := VideoGrabber.RecordingCanPause;
   chkRecordingPauseCreatesNewFile.Checked := VideoGrabber.RecordingPauseCreatesNewFile;
   chkPreallocFile.Checked := VideoGrabber.PreallocCapFileEnabled;
   chkPreserveNativeFormat.Checked := VideoGrabber.RecordingInNativeFormat;

   rdgCompressType.ItemIndex := integer (VideoGrabber.CompressionType);
   rdgCompressMode.ItemIndex := integer (VideoGrabber.CompressionMode);
   chkAudioRecording.Checked := VideoGrabber.AudioRecording;
   AssignListToComboBox (cboVideoCompressors, VideoGrabber.VideoCompressors, VideoGrabber.VideoCompressor);
   AssignListToComboBox (cboAudioCompressors, VideoGrabber.AudioCompressors, VideoGrabber.AudioCompressor);
   AssignListToComboBox (cboMultiplexers, VideoGrabber.Multiplexers, VideoGrabber.Multiplexer);

   ///////////////////////// network Streaming tab

   rdgNetworkStreaming.ItemIndex := Integer (VideoGrabber.NetworkStreaming);
   rdgNetworkStreamingType.ItemIndex := Integer (VideoGrabber.NetworkStreamingType);
   rdgNetworkStreamingType.Enabled := VideoGrabber.NetworkStreaming <> ns_Disabled;
   edtPublishingPoint.Text := VideoGrabber.ASFMediaServerPublishingPoint;
   edtNetworkPort.Text := IntToStr (VideoGrabber.ASFNetworkPort);
   edtNetworkMaxUsers.Text := IntToStr (VideoGrabber.ASFNetworkMaxUsers);

   rdgProfileVersion.ItemIndex := Integer (VideoGrabber.ASFProfileVersion);
   if VideoGrabber.ASFProfileFromCustomFile <> '' then begin
      edtWM9Profile.Text := VideoGrabber.ASFProfileFromCustomFile;
   end;
   edtASFVideoWidth.Text := IntToStr (VideoGrabber.ASFVideoWidth);
   edtASFVideoHeight.Text := IntToStr (VideoGrabber.ASFVideoHeight);
   edtASFVideoBitRate.Text := IntToStr (VideoGrabber.ASFVideoBitRate);
   edtASFVideoMaxKeyFrameSpacing.Text := IntToStr (VideoGrabber.ASFVideoMaxKeyFrameSpacing);
   edtASFVideoQuality.Text := IntToStr (VideoGrabber.ASFVideoQuality);
   edtASFAudioChannels.Text := IntToStr (VideoGrabber.ASFAudioChannels);
   chkASFFixedFrameRate.Checked := VideoGrabber.ASFFixedFrameRate;
   cmbASFDeinterlaceMode.ItemIndex := Integer (VideoGrabber.ASFDeinterlaceMode);

   edtProfileIndex.Text := IntToStr (VideoGrabber.ASFProfile);

   ///////////////////////// Player tab
   edtPlayerSpeedRatio.Text := FormatFloat ('0.0', VideoGrabber.PlayerSpeedRatio);

   updPlayerFastSeekSpeed.Position := VideoGrabber.PlayerFastSeekSpeedRatio;
   edtPlayerFastSeekSpeed.Text := IntToStr (VideoGrabber.PlayerFastSeekSpeedRatio);

   btnAutoPlay.Checked := VideoGrabber.AutoStartPlayer;
   chkPlayerAudioRendering.Checked := VideoGrabber.PlayerAudioRendering;
   chkUseClock.Checked := VideoGrabber.UseClock;
   chkRefreshPausedDisplay.Checked := VideoGrabber.PlayerRefreshPausedDisplay;

   ///////////////////////// Frame grabber tab
   edtAVIAutoFilePrefix.Text := VideoGrabber.AutoFilePrefix;
   rgdFrameGrabberFormat.ItemIndex := Integer (VideoGrabber.FrameGrabberRGBFormat);
   rgdFrameGrabber.ItemIndex := integer (VideoGrabber.FrameGrabber);
   rdgAutoFileName.ItemIndex := integer (VideoGrabber.AutoFileName);
   edtFrameCaptureWidth.Text := IntToStr (VideoGrabber.FrameCaptureWidth);
   edtFrameCaptureHeight.Text := IntToStr (VideoGrabber.FrameCaptureHeight);

   ///////////////////////// Frame capture tab
   edtBurstCount.Text := IntToStr (VideoGrabber.BurstCount);
   edtBurstInterval.Text := IntToStr (VideoGrabber.BurstInterval);
   tbrCaptureZoomSize.Position := VideoGrabber.FrameCaptureZoomSize;

   ///////////////////////// Motion detection tab

   chkMotionDetectionEnabled.Checked := Videograbber.MotionDetector_Enabled;
   chkCompareRed.Checked := VideoGrabber.MotionDetector_CompareRed;
   chkCompareGreen.Checked := VideoGrabber.MotionDetector_CompareGreen;
   chkCompareBlue.Checked := VideoGrabber.MotionDetector_CompareBlue;
   chk_GreyScale.Checked := VideoGrabber.MotionDetector_GreyScale;
   chkReduceVideoNoise.Checked := VideoGrabber.MotionDetector_ReduceVideoNoise;
   edtGrid.Text := VideoGrabber.MotionDetector_Grid;
   mmoSensitivityGrid.Text := VideoGrabber.MotionDetector_Get2DTextGrid;
   edtGridColCount.Text := IntToStr (VideoGrabber.MotionDetector_GridXCount);
   edtGridRowCount.Text := IntToStr (VideoGrabber.MotionDetector_GridYCount);
   chkTriggered.Checked := VideoGrabber.MotionDetector_Triggered;

   ///////////////////////// TV Tuner tab
   rdgTunerMode.ItemIndex := Integer (VideoGrabber.TunerMode);
   rdgTunerInputType.ItemIndex := Integer (VideoGrabber.TVTunerInputType);
   edtCountryCode.Text := IntToStr (VideoGrabber.TVCountryCode);
   edtTVChannel.Text := IntToStr (VideoGrabber.TVChannel);
   chkEnableFrequencyOverrides.Checked := VideoGrabber.TVUseFrequencyOverrides;

   ///////////////////////// Overlay tab
   rdgImageOverlaySelector.ItemIndex := VideoGrabber.ImageOverlaySelector;
   rdgImageOverlaySelectorClick (Self);
   chkAdjustOverlayAspectRatio.Checked := VideoGrabber.AdjustOverlayAspectRatio;

   rdgTextOverlaySelector.ItemIndex := VideoGrabber.TextOverlay_Selector;
   rdgTextOverlaySelectorClick (Self);

   ///////////////////////// Video processing tab
   rdgVideoRotation.ItemIndex := Integer (VideoGrabber.VideoProcessing_Rotation);
   tbrBrightness.Position := - VideoGrabber.VideoProcessing_Brightness;
   tbrConstrast.Position := - VideoGrabber.VideoProcessing_Contrast;
   tbrSaturation.Position := - VideoGrabber.VideoProcessing_Saturation;
   tbrHue.Position := VideoGrabber.VideoProcessing_Hue;
   edtCustomRotationAngle.Text := FormatFloat ('0.00', VideoGrabber.VideoProcessing_RotationCustomAngle);

   rdgDeinterlacing.ItemIndex := Integer (VideoGrabber.VideoProcessing_Deinterlacing);
   chkGreyScale.Checked := VideoGrabber.VideoProcessing_GrayScale;
   chkInvertColors.Checked := VideoGrabber.VideoProcessing_InvertColors;
   chkFlipVertical.Checked := VideoGrabber.VideoProcessing_FlipVertical;
   chkFlipHorizontal.Checked := VideoGrabber.VideoProcessing_FlipHorizontal;

   chkCroppingEnabled.Checked := VideoGrabber.Cropping_Enabled;
   chkCroppingOutbounds.Checked := VideoGrabber.Cropping_Outbounds;
   edtCroppingWidth.Text := IntToStr (VideoGrabber.Cropping_Width);
   edtCroppingHeight.Text := IntToStr (VideoGrabber.Cropping_Height);
   trkCroppingZoom.Position := Round (VideoGrabber.Cropping_Zoom * 100);

   // trkCroppingX.Max and trkCroppingY.Max are will be set from the OnResizeVideo event
   trkCroppingY.Position := VideoGrabber.Cropping_Y;
   trkCroppingX.Position := VideoGrabber.Cropping_X;

   ///////////////////////// Display tab
   VideoGrabber.Display_TransparentColorValue := $0000FF;
   VideoGrabber.DualDisplay_TransparentColorValue := $FF0000;

   chkVideoVisibleWhenStopped.Checked := VideoGrabber.VideoVisibleWhenStopped;
   chkAdjustPixelAspectRatio.Checked := VideoGrabber.AdjustPixelAspectRatio;
   chkBorder.Checked := VideoGrabber.BorderStyle = bsSingle;
   chkTransparency.Checked := VideoGrabber.ColorKeyEnabled;
   rdgVideoRenderer.ItemIndex := Integer (VideoGrabber.VideoRenderer);
   RefreshDisplayOptions;

   ///////////////////////// reencoding tab
   chkWMVOutput.Checked := VideoGrabber.Reencoding_WMVOutput;
   chkIncludeVideoStream.Checked := VideoGrabber.Reencoding_IncludeVideoStream;
   chkIncludeAudioStream.Checked := VideoGrabber.Reencoding_IncludeAudioStream ;
   chkUseFrameGrabber.Checked := VideoGrabber.Reencoding_UseFrameGrabber;
   chkUseCurrentVideoCompressor.Checked := VideoGrabber.Reencoding_UseVideoCompressor;
   chkUseCurrentAudioCompressor.Checked := VideoGrabber.Reencoding_UseAudioCompressor;
   edtReencStartTime.Text := IntToStr (VideoGrabber.Reencoding_StartTime);
   edtReencStopTime.Text := IntToStr (VideoGrabber.Reencoding_StopTime);
   edtReencStartFrame.Text := IntToStr (VideoGrabber.Reencoding_StartFrame);
   edtReencStopFrame.Text := IntToStr (VideoGrabber.Reencoding_StopFrame);
   rdgReencodingMethod.ItemIndex := Integer (VideoGrabber.Reencoding_Method);

end;

////////////////////////////////////////////////////////////////////////////////
//                            VIDEO DEVICE TAB
////////////////////////////////////////////////////////////////////////////////

procedure TfrmMainForm.VideoGrabberVideoDeviceSelected(Sender: TObject);
begin
   cboVideoDevices.ItemIndex := VideoGrabber.VideoDevice; // be sure the listbox index matches the current index value

   // from this event update the properties that depend of the current video capture device.
   // This event occurs when a new value is assigned to the VideoDevice property.
   RefreshDeviceControls;
   RefreshDisplayOptions;
end;

procedure TfrmMainForm.cboVideoSourceChange(Sender: TObject);
begin
  case cboVideoSource.ItemIndex of
     0: VideoGrabber.VideoSource := vs_VideoCaptureDevice;
     1: VideoGrabber.VideoSource := vs_ScreenRecording;
     2: VideoGrabber.VideoSource := vs_VideoFileOrURL;
     3: VideoGrabber.VideoSource := vs_JPEGsOrBitmaps;
     4: VideoGrabber.VideoSource := vs_IPCamera;
  else
     mmoLog.Lines.Add ('this option is not demonstrated in this demo');
  end;
end;

procedure TfrmMainForm.cboVideoDevicesChange(Sender: TObject);
begin
   VideoGrabber.VideoDevice := cboVideoDevices.ItemIndex;
   // when selecting another video capture device, the OnVideoDeviceSelected event occurs.
   // be sure to refresh all your device-dependent controls from the OnVideoDeviceSelected event.
end;

procedure TfrmMainForm.btnStartPreviewClick(Sender: TObject);
begin
   VideoGrabber.StartPreview;
end;

procedure TfrmMainForm.btnPausePreviewClick(Sender: TObject);
begin
   VideoGrabber.PausePreview;
end;

procedure TfrmMainForm.btnResumePreviewClick(Sender: TObject);
begin
   VideoGrabber.ResumePreview;
end;

procedure TfrmMainForm.btnStopPreviewClick(Sender: TObject);
begin
   VideoGrabber.StopPreview;
end;

procedure TfrmMainForm.btnAutoRefreshPreviewClick(Sender: TObject);
begin
   VideoGrabber.AutoRefreshPreview := btnAutoRefreshpreview.Checked;
end;

procedure TfrmMainForm.chkEnableSnapshotButtonClick(Sender: TObject);
begin
   if chkEnableSnapshotButton.Enabled then begin
      VideoGrabber.WebcamStillCaptureButton := wb_Enabled;
   end
   else begin
      VideoGrabber.WebcamStillCaptureButton := wb_Disabled;
   end;
end;

procedure TfrmMainForm.cboVideoInputsChange(Sender: TObject);
begin
   VideoGrabber.VideoInput := cboVideoInputs.ItemIndex;
end;

procedure TfrmMainForm.cboVideoFormatsChange(Sender: TObject);
begin
   VideoGrabber.VideoFormat := cboVideoFormats.ItemIndex;
   AssignListToComboBox (cboVideoSizes, VideoGrabber.VideoSizes, VideoGrabber.VideoSize);  // updates VideoSizes accordingly
   AssignListToComboBox (cboVideoSubtypes, VideoGrabber.VideoSubtypes, VideoGrabber.VideoSubtype); // updates VideoSubtypes accordingly
end;

procedure TfrmMainForm.cboVideoSizesChange(Sender: TObject);
begin
   VideoGrabber.VideoSize := cboVideoSizes.ItemIndex;
   AssignListToComboBox (cboVideoFormats, VideoGrabber.VideoFormats, VideoGrabber.VideoFormat); // updates VideoFormats accordingly
end;

procedure TfrmMainForm.cboVideoSubtypesChange(Sender: TObject);
begin
   VideoGrabber.VideoSubtype := cboVideoSubtypes.ItemIndex;
   AssignListToComboBox (cboVideoFormats, VideoGrabber.VideoFormats, VideoGrabber.VideoFormat); // updates VideoFormats accordingly
end;

procedure TfrmMainForm.cboAnalogVideoStandardChange(Sender: TObject);
begin
   VideoGrabber.AnalogVideoStandard := cboAnalogVideoStandard.ItemIndex;
end;

procedure TfrmMainForm.chkSetLogoClick(Sender: TObject);
begin
   if ChkSetLogo.Checked then begin
      ImgLogo.Visible := False;
      VideoGrabber.SetLogoFromTImage (ImgLogo);
      VideoGrabber.LogoLayout := lg_Stretched;
      VideoGrabber.LogoDisplayed := True;
   end
   else begin
      VideoGrabber.LogoDisplayed := False;
   end;
end;

procedure TfrmMainForm.btnDeviceDialogClick(Sender: TObject);
begin
   VideoGrabber.ShowDialog (dlg_VideoDevice);
   RefreshDeviceControls;
end;

procedure TfrmMainForm.btnCameraControlDialogClick(Sender: TObject);
begin
   ShowFormAboveVideo (frmCameraControl);
end;

procedure TfrmMainForm.btnVideoQualityDialogClick(Sender: TObject);
begin
   ShowFormAboveVideo (frmVideoQuality);
end;

procedure TfrmMainForm.btnVideoControlDialogClick(Sender: TObject);
begin
   ShowFormAboveVideo (frmVideoControl);
end;

procedure TfrmMainForm.btnSpecialControlsClick(Sender: TObject);
begin
   ShowFormAboveVideo (frmSpecialControls);
end;

procedure TfrmMainForm.btnStreamDialogClick(Sender: TObject);
begin
   // WARNING: USUALLY, THIS DIALOG ALLOWS TO CHANGE ONLY 1 PARAMETER AT THE SAME TIME
   VideoGrabber.ShowDialog (dlg_StreamConfig);
   VideoGrabberVideoDeviceSelected (Self); // to refresh the controls, if required
end;

procedure TfrmMainForm.rdgPreferredVideoSizeClick(Sender: TObject);
begin
   case rdgPreferredVideoSize.ItemIndex of
      0: VideoGrabber.UseNearestVideoSize (0, 0, chkStretchPreferredVideoSize.Checked); // disables the nearest size feature, uses the device's VideoSize index in the VideoSizes list
      1: VideoGrabber.UseNearestVideoSize ( 88,  60, chkStretchPreferredVideoSize.Checked);
      2: VideoGrabber.UseNearestVideoSize ( 88,  72, chkStretchPreferredVideoSize.Checked);
      3: VideoGrabber.UseNearestVideoSize (180, 120, chkStretchPreferredVideoSize.Checked);
      4: VideoGrabber.UseNearestVideoSize (180, 144, chkStretchPreferredVideoSize.Checked);
      5: VideoGrabber.UseNearestVideoSize (320, 240, chkStretchPreferredVideoSize.Checked);
      6: VideoGrabber.UseNearestVideoSize (352, 288, chkStretchPreferredVideoSize.Checked);
      7: VideoGrabber.UseNearestVideoSize (640, 480, chkStretchPreferredVideoSize.Checked);
      8: VideoGrabber.UseNearestVideoSize (720, 480, chkStretchPreferredVideoSize.Checked);
      9: VideoGrabber.UseNearestVideoSize (720, 576, chkStretchPreferredVideoSize.Checked);
     10: VideoGrabber.UseNearestVideoSize (768, 576, chkStretchPreferredVideoSize.Checked);
      // you can add your own preferred formats
   end;
   cboVideoSizes.Enabled := rdgPreferredVideoSize.ItemIndex = 0;
end;

procedure TfrmMainForm.chkStretchPreferredVideoSizeClick(Sender: TObject);
begin
   rdgPreferredVideoSizeClick (Self);
end;

procedure TfrmMainForm.btnFrameRateClick(Sender: TObject);
var
   Value: Double;
begin
   Value := StrToFloatDef (edtFrameRate.Text, -1);
   VideoGrabber.FrameRate := Value;

   if VideoGrabber.CurrentState = cs_Preview then begin
      mmoLog.lines.Add ('current frame rate: ' + FormatFloat ('0.00', VideoGrabber.CurrentFrameRate) + ' fps.');
   end;
end;

procedure TfrmMainForm.btnAboutFrameRateClick(Sender: TObject);
begin
   ShowMessage ('0 means that the default frame rate of the device will be used.' + #13#10 + 'After the OnPreviewStarted or OnRecordingStarted event occurs,' + #13#10 + 'its value is available in the CurrentFrameRate property.');
end;

procedure TfrmMainForm.btnSelectFileOrUrlClick(Sender: TObject);
var
   OpenDlg: TOpenDialog;
begin
   OpenDlg := TOpenDialog.Create (nil);
   OpenDlg.Filter := OPEN_MEDIA_FILES;
   if OpenDlg.Execute then begin
      edtVideoSourceFileOrUrl.Text := OpenDlg.FileName;
   end;
   OpenDlg.Free;
end;

procedure TfrmMainForm.edtVideoSourceFileOrUrlChange(Sender: TObject);
begin
   VideoGrabber.VideoSource_FileOrUrl := edtVideoSourceFileOrUrl.Text;
end;

procedure TfrmMainForm.VideoSourceFileOrUrl_UserNameChange(Sender: TObject);
begin
   VideoGrabber.SetAuthentication (at_StreamingUrl, VideoSourceFileOrUrl_UserName.Text, VideoSourceFileOrUrl_Password.Text);
end;

procedure TfrmMainForm.VideoSourceFileOrUrl_PasswordChange(Sender: TObject);
begin
   VideoGrabber.SetAuthentication (at_StreamingUrl, VideoSourceFileOrUrl_UserName.Text, VideoSourceFileOrUrl_Password.Text);
end;

procedure TfrmMainForm.btnUrlConfClick(Sender: TObject);
begin
   VideoGrabber.ShowDialog (dlg_NetShowConfig);
end;

procedure TfrmMainForm.btnScreenRecordingWindowClick(Sender: TObject);
begin
   VideoGrabber.SetWindowRecordingByName (edtScreenRecordingWindow.Text, false); // set to "true" for an exact and case-sensitive match
end;

procedure TfrmMainForm.chkScreenRecordingWithCursorClick(Sender: TObject);
begin
   VideoGrabber.ScreenRecordingWithCursor := chkScreenRecordingWithCursor.Checked;
end;

procedure TfrmMainForm.edtMonitorNumberChange(Sender: TObject);
begin
   VideoGrabber.ScreenRecordingMonitor := StrToIntDef (edtMonitorNumber.Text, 0);
end;

procedure TfrmMainForm.btnMonitorNumberInfoClick(Sender: TObject);
begin
   ShowMessage ('-1 = full desktop, 0 = 1st monitor, 1 = 2nd monitor, etc...');
end;

procedure TfrmMainForm.VideoGrabberPreviewStarted(Sender: TObject);
begin
   mmoLog.lines.Add ('');
   mmoLog.lines.Add ('video source size: ' + IntToStr (VideoGrabber.VideoWidth) + 'x' + IntToStr (VideoGrabber.VideoHeight));
   mmoLog.lines.Add ('display aspect ratio: ' + IntToStr (VideoGrabber.VideoWidth_PreferredAspectRatio) + 'x' + IntToStr (VideoGrabber.VideoHeight_PreferredAspectRatio));
   mmoLog.lines.Add ('current frame rate: ' + FormatFloat ('0.00', VideoGrabber.CurrentFrameRate) + ' fps.');
   mmoLog.lines.Add ('');
end;

////////////////////////////////////////////////////////////////////////////////
//                           AUDIO TAB
////////////////////////////////////////////////////////////////////////////////

procedure TfrmMainForm.VideoGrabberAudioDeviceSelected(Sender: TObject);
begin
   // from this event set the parameters that change when the current audio capture device change
   cboAudioDevices.ItemIndex := VideoGrabber.AudioDevice; // be sure the listbox index matches the current index value

   AssignListToComboBox (cboAudioInputs, VideoGrabber.AudioInputs, integer (VideoGrabber.AudioInput));
   tbrAudioInputLevel.Position := VideoGrabber.AudioInputLevel;
   tbrAudioInputBalance.Position := VideoGrabber.AudioInputBalance;
   chkAudioInputMono.Checked := VideoGrabber.AudioInputMono;
end;

procedure TfrmMainForm.btnStartAudioRenderingClick(Sender: TObject);
begin
   VideoGrabber.StartAudioRendering;
   if not VideoGrabber.AudioDeviceRendering then begin
      if btnStartAudioRendering.Tag = 0 then begin
         btnStartAudioRendering.Tag := 1; // to show the popup only one time
         ShowMessage ('StartAudioRendering acts as "preview", e.g. for the VU-Meters, if AudioDeviceRendering (on the left) is not enabled, the audio will not be heard in the speakers');
      end;
   end;
end;

procedure TfrmMainForm.btnStartWAVRecordingClick(Sender: TObject);
begin
   VideoGrabber.CompressionMode := cm_NoCompression;
   VideoGrabber.RecordingMethod := rm_AVI;
   VideoGrabber.StartAudioRecording;
end;

procedure TfrmMainForm.btnStartMP3RecordingClick(Sender: TObject);
begin
   VideoGrabber.CompressionMode := cm_CompressOnTheFly;
   VideoGrabber.CompressionType := ct_Audio;
   VideoGrabber.RecordingMethod := rm_AVI;
   VideoGrabber.AudioCompressor := VideoGrabber.FindIndexInListByName (VideoGrabber.AudioCompressors, 'LAME Audio Encoder', false, true);
   if VideoGrabber.AudioCompressor = -1 then begin
      showmessage ('The LAME Audio Encoder is required, download it from http://www.elecard.com/download/');
   end
   else begin
      VideoGrabber.StartAudioRecording;
   end;
end;

procedure TfrmMainForm.btnStartASFRecordingClick(Sender: TObject);
begin
   VideoGrabber.CompressionMode := cm_NoCompression;
   VideoGrabber.RecordingMethod := rm_ASF;
   VideoGrabber.StartAudioRecording;
end;

procedure TfrmMainForm.btnStopAudioClick(Sender: TObject);
begin
   VideoGrabber.Stop;
end;

procedure TfrmMainForm.chkUseAudioOfVideoCaptureDeviceClick(
  Sender: TObject);
begin
   if chkUseAudioOfVideoCaptureDevice.Checked then begin
      VideoGrabber.VideoDevice := 0; // in this demo, by default we choose the 1st
   end
   else begin
      VideoGrabber.VideoDevice := -1; // this deactivates the video capture device
   end;
end;

procedure TfrmMainForm.chkRenderAudioDeviceClick(Sender: TObject);
begin
   VideoGrabber.AudioDeviceRendering := chkRenderAudioDevice.Checked;
end;

procedure TfrmMainForm.cboAudioDevicesChange(Sender: TObject);
begin
   VideoGrabber.AudioDevice := cboAudioDevices.ItemIndex;
end;

procedure TfrmMainForm.btnDlgAudioDeviceClick(Sender: TObject);
begin
   VideoGrabber.ShowDialog (dlg_AudioDevice);
end;

procedure TfrmMainForm.cboAudioInputsChange(Sender: TObject);
begin
   VideoGrabber.AudioInput := cboAudioInputs.ItemIndex;
end;

procedure TfrmMainForm.tbrAudioInputLevelChange(Sender: TObject);
begin
   VideoGrabber.AudioInputLevel := tbrAudioInputLevel.Position;
end;

procedure TfrmMainForm.tbrAudioInputBalanceChange(Sender: TObject);
begin
   VideoGrabber.AudioInputBalance := tbrAudioInputBalance.Position;
end;

procedure TfrmMainForm.chkAudioInputMonoClick(Sender: TObject);
begin
   VideoGrabber.AudioInputMono := chkAudioInputMono.Checked;
end;

procedure TfrmMainForm.cboAudioRenderersChange(Sender: TObject);
begin
   VideoGrabber.AudioRenderer := cboAudioRenderers.ItemIndex;
end;

procedure TfrmMainForm.tbrAudioVolumeChange(Sender: TObject);
begin
   VideoGrabber.AudioVolume := tbrAudioVolume.Position;
end;

procedure TfrmMainForm.tbrAudioBalanceChange(Sender: TObject);
begin
   VideoGrabber.AudioBalance := tbrAudioBalance.Position;
end;

procedure TfrmMainForm.chkMuteAudioRenderingClick(Sender: TObject);
begin
   VideoGrabber.MuteAudioRendering := chkMuteAudioRendering.Checked;
end;

procedure TfrmMainForm.chkAudioSyncAdjustClick(Sender: TObject);
begin
   VideoGrabber.AudioSyncAdjustmentEnabled := chkAudioSyncAdjust.Checked;
end;

procedure TfrmMainForm.tbrAudioSyncAdjustChange(Sender: TObject);
begin
   VideoGrabber.AudioSyncAdjustment := tbrAudioSyncAdjust.Position;
   edtAudioSyncAdjust.Text := IntToStr (tbrAudioSyncAdjust.Position);
end;

procedure TfrmMainForm.rdgVUMetersClick(Sender: TObject);
const
   VU_LEFT = 0;
   VU_RIGHT = 1;
begin
   case rdgVUMeters.ItemIndex of
      0: begin
         VideoGrabber.VuMeter := vu_Disabled;
      end;
      1: begin
         VideoGrabber.VuMeter := vu_Analog;

         pnLeftVUMeter.Width := (pnLeftVUMeter.Height * 4) div 3;
         pnRightVUMeter.Width := (pnRightVUMeter.Height * 4) div 3;

         VideoGrabber.SetVUMeterSetting(VU_LEFT, vu_bkGndColor, clBlack);
         VideoGrabber.SetVUMeterSetting(VU_RIGHT, vu_bkGndColor, clBlack);
      end;
      2: begin
         VideoGrabber.VuMeter := vu_Bargraph;

         pnLeftVUMeter.Width := (pnLeftVUMeter.Height * 2) div 10;
         pnRightVUMeter.Width := (pnRightVUMeter.Height * 2) div 10;

         VideoGrabber.SetVUMeterSetting(VU_LEFT, vu_BkgndColor, TColor ($404040));
         VideoGrabber.SetVUMeterSetting(VU_RIGHT, vu_BkgndColor, TColor ($404040));

      end;
   end;
   if VideoGrabber.VUMeter <> vu_Disabled then begin
      VideoGrabber.SetVUMeterSetting(VU_LEFT, vu_Handle, pnLeftVUMeter.Handle);   // we use a TPanel to display the VU meters,
      VideoGrabber.SetVUMeterSetting(VU_RIGHT, vu_Handle, pnRightVUMeter.Handle); // this is activated by assigning the TPanel's handle...
   end
   else begin
      VideoGrabber.SetVUMeterSetting(VU_LEFT, vu_Handle, 0); // ...and the TPanel is freed by passing 0 as handle
      VideoGrabber.SetVUMeterSetting(VU_RIGHT, vu_Handle, 0);
   end;
end;

////////////////////////////////////////////////////////////////////////////////
//                             RECORDING TAB
////////////////////////////////////////////////////////////////////////////////

procedure TfrmMainForm.btnStartRecordingImmediatelyClick(Sender: TObject);
begin
   VideoGrabber.HoldRecording := False; // let's start recording as soon as the graph is built.
   VideoGrabber.StartRecording;
end;

procedure TfrmMainForm.btnStartRecordingControlledClick(Sender: TObject);
begin
   VideoGrabber.HoldRecording := True;
   VideoGrabber.StartRecording;

   // Enabling HoldRecording prevents the recording to start when the recording graph is built.
   // after the OnRecordingReadyToStart event occurs, you can accurately start the
   // recording by invoking ResumeRecording.
end;

procedure TfrmMainForm.btnStopRecordingClick(Sender: TObject);
begin
   VideoGrabber.StopRecording;
end;

procedure TfrmMainForm.btnRenewRecordingFileClick(Sender: TObject);
begin
   VideoGrabber.RecordToNewFileNow ('', true);
end;

procedure TfrmMainForm.rdgRecordingMethodClick(Sender: TObject);
begin
   VideoGrabber.RecordingMethod := TRecordingMethod (rdgRecordingMethod.ItemIndex);
   RefreshDeviceControls;
end;

procedure TfrmMainForm.chkRecordingCanPauseClick(Sender: TObject);
begin
   VideoGrabber.RecordingCanPause := chkRecordingCanPause.Checked;
   RefreshDeviceControls;
end;

procedure TfrmMainForm.chkRecordingPauseCreatesNewFileClick(
  Sender: TObject);
begin
   VideoGrabber.RecordingPauseCreatesNewFile := chkRecordingPauseCreatesNewFile.Checked;
end;

procedure TfrmMainForm.chkRecordingOnMotionClick(Sender: TObject);
begin
   VideoGrabber.RecordingOnMotion_Enabled := chkRecordingOnMotion.Checked;
   chkRecordingCanPause.Checked := chkRecordingOnMotion.Checked;
end;

procedure TfrmMainForm.btnPauseRecordingClick(Sender: TObject);
begin
   VideoGrabber.PauseRecording;
end;

procedure TfrmMainForm.btnResumeRecordingClick(Sender: TObject);
begin
   VideoGrabber.ResumeRecording;
end;

procedure TfrmMainForm.chkAVISaveToThisFileClick(Sender: TObject);
begin
   if chkAVISaveToThisFile.Checked then begin
      VideoGrabber.RecordingFileName := edtRecordingFileName.Text;
   end
   else begin
      VideoGrabber.RecordingFileName := '';
   end;
end;

procedure TfrmMainForm.edtRecordingFileNameChange(Sender: TObject);
begin
   if chkAVISaveToThisFile.Checked then begin
      VideoGrabber.RecordingFileName := edtRecordingFileName.Text;
   end;
end;

procedure TfrmMainForm.cboAudioFormatsChange(Sender: TObject);
begin
   VideoGrabber.AudioFormat := TAudioFormat (cboAudioFormats.ItemIndex);
end;

procedure TfrmMainForm.chkAudioRecordingClick(Sender: TObject);
begin
   VideoGrabber.AudioRecording := chkAudioRecording.Checked;
   RefreshDeviceControls;
end;

procedure TfrmMainForm.grbRecordingTimerClick(Sender: TObject);
begin
   VideoGrabber.RecordingTimer := TRecordingTimer (grbRecordingTimer.ItemIndex);
   VideoGrabber.RecordingTimerInterval := StrToIntDef (edtRecordingTimerInterval.Text, 0);
end;

procedure TfrmMainForm.edtRecordingTimerIntervalChange(Sender: TObject);
begin
   VideoGrabber.RecordingTimerInterval := StrToIntDef (edtRecordingTimerInterval.Text, 0);
end;

procedure TfrmMainForm.chkPreserveNativeFormatClick(Sender: TObject);
begin
   VideoGrabber.RecordingInNativeFormat := chkPreserveNativeFormat.Checked;
end;

procedure TfrmMainForm.btnNativeFormatClick(Sender: TObject);
begin
   ShowMessage (
      'Means that the recording stream will not be uncompressed.' + #13#10 +
      '' + #13#10 +
      'MUST BE ENABLED:' + #13#10 +
      '- to record hardware-encoded MPEG' + #13#10 +
      '- to record or DV devices in native DV format' + #13#10 +
      '- to record the DV date/time into the video clip and retrieve it during playback' + #13#10 +
      '' + #13#10 +
      'MUST BE DISABLED:' + #13#10 +
      '- to record the text and graphics overlays into the video clip, and retrieve them during playback' + #13#10
   );
end;

procedure TfrmMainForm.chkPreallocFileClick(Sender: TObject);
begin
   VideoGrabber.PreallocCapFileEnabled := chkPreallocFile.Checked;
end;

procedure TfrmMainForm.btnCreatePreallocFileNowClick(Sender: TObject);
begin
   VideoGrabber.CreatePreallocCapFile;
end;

procedure TfrmMainForm.edtPreallocSizeChange(Sender: TObject);
begin
   VideoGrabber.PreallocCapFileSizeInMB := StrToIntDef (edtPreallocSize.Text, 100);
end;

procedure TfrmMainForm.cboVideoCompressorsChange(Sender: TObject);
begin
   VideoGrabber.VideoCompressor := cboVideoCompressors.ItemIndex;
end;

procedure TfrmMainForm.cboAudioCompressorsChange(Sender: TObject);
begin
   VideoGrabber.AudioCompressor := cboAudioCompressors.ItemIndex;
end;

procedure TfrmMainForm.cboMultiplexersChange(Sender: TObject);
begin
   VideoGrabber.Multiplexer := cboMultiplexers.ItemIndex;
end;

procedure TfrmMainForm.BtnCodecExamplesClick(Sender: TObject);
begin
   ShellExecute(0, 'open', PChar('http://www.datastead.com/tvideograbber-recording-codecs-examples.html?demo=delphi'), '', '', SW_SHOW);
end;

function GetRecordingMethodName (Value: TRecordingMethod): string;
begin
   case Value of
      rm_ASF: Result := 'rm_ASF';
      rm_SendToDV: Result := 'rm_sDV';
      rm_MKV: Result := 'rm_MKV';
      rm_FLV: Result := 'rm_FLV';
      rm_MP4: Result := 'rm_MP4';
      rm_MPG: Result := 'rm_MPG';
      rm_Multiplexer: Result := 'rm_Mux';
   else
      Result := 'rm_AVI';
   end;
end;

procedure TfrmMainForm.btnVideoCompressorSettingsClick(Sender: TObject);
begin
   VideoGrabber.ShowDialog (dlg_VideoCompressor);
end;

procedure TfrmMainForm.btnAudioCompressorSettingsClick(Sender: TObject);
begin
   VideoGrabber.ShowDialog (dlg_AudioCompressor);
end;

procedure TfrmMainForm.Button1Click(Sender: TObject);
begin
   VideoGrabber.ShowDialog (dlg_Multiplexer);
end;

procedure TfrmMainForm.btnSaveVideoCompressorSettingsClick(Sender: TObject);
var
   SaveDlg: TSaveDialog;
begin
   SaveDlg := TSaveDialog.Create(nil);
   SaveDlg.FileName := VideoGrabber.VideoCompressorName + ' (' + GetRecordingMethodName (VideoGrabber.RecordingMethod) + ').txt';
   if SaveDlg.Execute then begin

      // be sure to have selected the RecordingMethod and VideoCompressor before invoking SaveCompressorSettings...

      VideoGrabber.SaveCompressorSettingsToTextFile (TRUE, VideoGrabber.VideoCompressor, SaveDlg.FileName);

      // remark: you can use instead SaveCompressorSettingsToDataString (TRUE, VideoGrabber.VideoCompressor, YourDataString)
   end;
   SaveDlg.Free;
end;

procedure TfrmMainForm.btnSaveAudioCompressorSettingsClick(Sender: TObject);
var
   SaveDlg: TSaveDialog;
begin
   SaveDlg := TSaveDialog.Create(nil);

   SaveDlg.FileName := VideoGrabber.AudioCompressorName + ' (' + GetRecordingMethodName (VideoGrabber.RecordingMethod) + ').txt';
   if SaveDlg.Execute then begin

      // be sure to have selected the RecordingMethod and AudioCompressor before invoking SaveCompressorSettings...

      VideoGrabber.SaveCompressorSettingsToTextFile (FALSE, VideoGrabber.AudioCompressor, SaveDlg.FileName);

      // remark: you can use instead SaveCompressorSettingsToDataString (FALSE, VideoGrabber.AudioCompressor, YourDataString)
   end;
   SaveDlg.Free;
end;

procedure TfrmMainForm.btnReloadVideoCompressorSettingsClick(
  Sender: TObject);
var
   OpenDlg: TOpenDialog;
begin
   OpenDlg := TOpenDialog.Create (nil);
   OpenDlg.Filter := 'Compressor saved settings (*.txt)|*.txt';
   if OpenDlg.Execute then begin

      VideoGrabber.LoadCompressorSettingsFromTextFile (TRUE, VideoGrabber.VideoCompressor, OpenDlg.FileName);

      // remark: you can use instead YourDataString := LoadCompressorSettingsFromDataString (TRUE, VideoGrabber.VideoCompressor)
   end;
   OpenDlg.Free;
end;

procedure TfrmMainForm.btnReloadAudioCompressorSettingsClick(
  Sender: TObject);
var
   OpenDlg: TOpenDialog;
begin
   OpenDlg := TOpenDialog.Create (nil);
   OpenDlg.Filter := 'Compressor saved settings (*.txt)|*.txt';
   if OpenDlg.Execute then begin

      VideoGrabber.LoadCompressorSettingsFromTextFile (FALSE, VideoGrabber.AudioCompressor, OpenDlg.FileName);

      // remark: you can use instead YourDataString := LoadCompressorSettingsFromDataString (FALSE, VideoGrabber.AudioCompressor)

   end;
   OpenDlg.Free;
end;

procedure TfrmMainForm.rdgCompressModeClick(Sender: TObject);
begin
   VideoGrabber.CompressionMode := TCompressionMode (rdgCompressMode.ItemIndex);
   RefreshDeviceControls;
end;

procedure TfrmMainForm.rdgCompressTypeClick(Sender: TObject);
begin
   VideoGrabber.CompressionType := TCompressionType (rdgCompressType.ItemIndex);
end;

procedure TfrmMainForm.VideoGrabberRecordingReadyToStart(Sender: TObject);
begin
   if MessageDlg ('Ready to start recording!', mtInformation, [MbOk, MbCancel], 0) = MrOk then begin
      VideoGrabber.ResumeRecording;
   end
   else begin
      VideoGrabber.StopRecording;
   end;
end;

procedure TfrmMainForm.VideoGrabberRecordingStarted(Sender: TObject;
  FileName: String);
begin
   mmoLog.lines.Add ('recording to ' + FileName + ':');
   mmoLog.lines.Add (IntToStr (VideoGrabber.RecordingWidth) + 'x' + IntToStr (VideoGrabber.RecordingHeight));
   mmoLog.lines.Add ('current frame rate: ' + FormatFloat ('0.00', VideoGrabber.CurrentFrameRate) + ' fps.');
   btnRenewRecordingFile.Enabled := True;
   FKBWritten_LastReportTime := 0;
end;

procedure TfrmMainForm.VideoGrabberReencodingProgress(Sender: TObject;
  Percent: Integer; Position, Duration: Int64);
begin
   mmoLog.Lines.Add (IntToStr (PerCent) + '% completed...');
end;

procedure TfrmMainForm.VideoGrabberRecordingPaused(Sender: TObject);
begin
      mmoLog.Lines.Add ('recording paused...');
end;

procedure TfrmMainForm.VideoGrabberRecordingCompleted(Sender: TObject;
  FileName: String; Success: Boolean);
begin
   if Success then begin
      mmoLog.Lines.Add (FileName + ' successfully created.');
      mmoLog.Lines.Add ('size: ' + IntToStr (VideoGrabber.RecordingKBytesWrittenToDisk) + ' KB');
   end
   else begin
      mmoLog.Lines.Add ('recording failed.');
   end;
   btnRenewRecordingFile.Enabled := False;
end;

procedure TfrmMainForm.VideoGrabberReencodingStarted(Sender: TObject;
  SourceFile, DestFile: String);
begin
   mmoLog.lines.Add ('reencoding ' + SourceFile + ' to ' + DestFile + '...');
end;


procedure TfrmMainForm.VideoGrabberReencodingCompleted(Sender: TObject;
  SourceFile, DestFile: String; Success: Boolean);
begin
   if Success then begin
      mmoLog.Lines.Add (SourceFile + ' successfully reencoded to ' + DestFile);
   end
   else begin
      mmoLog.Lines.Add ('Failed to reencode ' + SourceFile + ' to ' + DestFile);
   end;
end;

procedure TfrmMainForm.VideoGrabberCopyPreallocDataStarted(Sender: TObject;
  SourceFile, DestFile: String);
begin
   mmoLog.Lines.Add ('copying data from ' + SourceFile + ' to ' + DestFile + '...');
end;

procedure TfrmMainForm.VideoGrabberCopyPreallocDataProgress(
  Sender: TObject; Percent: Integer; Position, Duration: Int64);
begin
   mmoLog.Lines.Add ('copying data: ' + IntToStr (Percent) + '% completed.');
end;

procedure TfrmMainForm.VideoGrabberCopyPreallocDataCompleted(
  Sender: TObject; SourceFile, DestFile: String; Success: Boolean);
begin
   if Success then begin
      mmoLog.Lines.Add (SourceFile + ' successfully copied to ' + DestFile + '.');
   end
   else begin
      mmoLog.Lines.Add ('ERROR: Failed to copy ' + SourceFile + ' to ' + DestFile + '!');
   end;
end;

procedure TfrmMainForm.VideoGrabberCreatePreallocFileStarted(
  Sender: TObject; FileName: String);
begin
   mmoLog.Lines.Add ('preallocating file ' + FileName + '...');
end;

procedure TfrmMainForm.VideoGrabberCreatePreallocFileProgress(
  Sender: TObject; Percent: Integer; Position, Duration: Int64);
begin
   mmoLog.Lines.Add (IntToStr (PerCent) + '% of preallocated file completed');
end;

procedure TfrmMainForm.VideoGrabberCreatePreallocFileCompleted(
  Sender: TObject; FileName: String; Success: Boolean);
begin
   if Success then begin
      mmoLog.Lines.Add ('preallocated file ' + FileName + ' successfully created.');
   end
   else begin
      mmoLog.Lines.Add ('ERROR: Failed to preallocate ' + FileName);
   end;
end;

////////////////////////////////////////////////////////////////////////////////
//                             FRAME GRABBER TAB
////////////////////////////////////////////////////////////////////////////////

procedure TfrmMainForm.rgdFrameGrabberClick(Sender: TObject);
begin
   VideoGrabber.FrameGrabber := TFrameGrabber (rgdFrameGrabber.ItemIndex);
   RefreshDeviceControls;
end;

procedure TfrmMainForm.rgdFrameGrabberFormatClick(Sender: TObject);
begin
   VideoGrabber.FrameGrabberRGBFormat := TFrameGrabberRGBFormat (rgdFrameGrabberFormat.ItemIndex);
end;

procedure TfrmMainForm.rdgAutoFileNameClick(Sender: TObject);
begin
   VideoGrabber.AutoFileName := TAutoFileName (rdgAutoFileName.ItemIndex);
end;

procedure TfrmMainForm.edtAVIAutoFilePrefixChange(Sender: TObject);
begin
   VideoGrabber.AutoFilePrefix := edtAVIAutoFilePrefix.Text;
end;

procedure TfrmMainForm.btnOneShotTBitmapClick(Sender: TObject);
begin
   VideoGrabber.CaptureFrameTo (fc_TBitmap, '');
   // note 1: passing an empty file name let TVideoGrabber generate it automatically in the StoragePath directory
   // note 2: using CaptureFrameSyncTo instead of CaptureFrameTo waits for frame capture completion and returns true upon success
end;

procedure TfrmMainForm.btnOneShotBMPFileClick(Sender: TObject);
begin
   if chkUseThisFileName.Checked then begin
      VideoGrabber.CaptureFrameTo (fc_BmpFile, edtUseThisFileName.Text);
   end
   else begin
      VideoGrabber.CaptureFrameTo (fc_BmpFile, '');
   end;
   // note 1: passing an empty file name let TVideoGrabber generate it automatically in the StoragePath directory
   // note 2: using CaptureFrameSyncTo instead of CaptureFrameTo waits for frame capture completion and returns true upon success
end;

procedure TfrmMainForm.btnOneShotJPEGFileClick(Sender: TObject);
begin
   if chkUseThisFileName.Checked then begin
      VideoGrabber.CaptureFrameTo (fc_JpegFile, edtUseThisFileName.Text);
   end
   else begin
      VideoGrabber.CaptureFrameTo (fc_JpegFile, '');
   end;
   // note 1: passing an empty file name let TVideoGrabber generate it automatically in the StoragePath directory
   // note 2: using CaptureFrameSyncTo instead of CaptureFrameTo waits for frame capture completion and returns true upon success
end;

procedure TfrmMainForm.btnOneShotClipboardClick(Sender: TObject);
begin
   VideoGrabber.CaptureFrameTo (fc_Clipboard, '');
end;

procedure TfrmMainForm.chkUseThisFileNameClick(Sender: TObject);
begin
   edtUseThisFileName.Enabled := chkUseThisFileName.Checked;
end;

procedure TfrmMainForm.btnBurstModeTBitmapClick(Sender: TObject);
begin
   VideoGrabber.BurstType := fc_TBitmap;
   VideoGrabber.BurstMode := True;
   // The frame capture starts when BurstMode is set to True.
   // If BurstCount = 0 the frame capture won't stop.
   // Captured frames will be returned by the OnFrameCaptureCompleted event.
end;

procedure TfrmMainForm.btnBurstModeBMPFileClick(Sender: TObject);
begin
   VideoGrabber.BurstType := fc_BmpFile;
   VideoGrabber.BurstMode := True;
   // The frame capture starts when BurstMode is set to True.
   // If BurstCount = 0 the frame capture won't stop.
   // BMP file names will be generated automatically according to AutoFileName
   // and AutoFilePrefix. They will be returned by the OnFrameCaptureCompleted event.
end;

procedure TfrmMainForm.btnBurstModeJPEGFileClick(Sender: TObject);
begin
   VideoGrabber.BurstType := fc_JpegFile;
   VideoGrabber.BurstMode := True;
   // The frame capture starts when BurstMode is set to True.
   // If BurstCount = 0 the frame capture won't stop.
   // JPEG file names will be generated automatically according to AutoFileName
   // and AutoFilePrefix. They will be returned by the OnFrameCaptureCompleted event.
end;

procedure TfrmMainForm.btnBurstModeClipboardClick(Sender: TObject);
begin
   VideoGrabber.BurstType := fc_Clipboard;
   VideoGrabber.BurstMode := True;
   // The frame capture starts when BurstMode is set to True.
   // If BurstCount = 0 the frame capture won't stop.
end;

procedure TfrmMainForm.btnBurstModeStopClick(Sender: TObject);
begin
   VideoGrabber.BurstMode := False;
end;

procedure TfrmMainForm.edtBurstCountChange(Sender: TObject);
begin
   VideoGrabber.BurstCount := StrToIntDef (edtBurstCount.Text, 1);
end;

procedure TfrmMainForm.edtBurstIntervalChange(Sender: TObject);
begin
   VideoGrabber.BurstInterval := StrToIntDef (edtBurstInterval.Text, 1);
end;

procedure TfrmMainForm.tbrCaptureZoomSizeChange(Sender: TObject);
begin
   VideoGrabber.FrameCaptureZoomSize := tbrCaptureZoomSize.Position;
   edtCaptureZoomSize.Text := IntToStr (tbrCaptureZoomSize.Position) + '%';
end;

procedure TfrmMainForm.btnResetCaptureZoomSizeClick(Sender: TObject);
begin
   tbrCaptureZoomSize.Position := 100;
end;

procedure TfrmMainForm.edtFrameCaptureWidthChange(Sender: TObject);
begin
   VideoGrabber.FrameCaptureWidth := StrToIntDef (edtFrameCaptureWidth.Text, -1);
end;

procedure TfrmMainForm.edtFrameCaptureHeightChange(Sender: TObject);
begin
   VideoGrabber.FrameCaptureHeight := StrToIntDef (edtFrameCaptureHeight.Text, -1);
end;

procedure TfrmMainForm.VideoGrabberFrameProgress2(Sender: TObject; FrameInfo: pFrameInfo);
var
   DVTimeCode: String;
   DVDateTime: String;
begin
   with FrameInfo^ do begin
      if CurrentState = cs_Playback then begin // no dropped frames in playback mode
         edtFrameCount.Text := Format ('frame: %d time:%.2d:%.2d:%.2d %.2d', [FrameNumber, FrameTime_Hour, FrameTime_Min, FrameTime_Sec, FrameTime_Hs]);
      end
      else begin
         edtFrameCount.Text := Format ('frame: %d dropped: %d time:%.2d:%.2d:%.2d %.2d', [FrameNumber, DroppedFrameCount, FrameTime_Hour, FrameTime_Min, FrameTime_Sec, FrameTime_Hs]);
      end;

      if DVTimeCode_IsAvailable > 0 then begin // not available if 0
         DVTimeCode := Format ('tc: %.2d:%.2d:%.2d:%.2d', [DVTimeCode_Hour, DVTimeCode_Min, DVTimeCode_Sec, DVTimeCode_Ff]);
      end
      else begin
         DVTimeCode := '';
      end;
      if DVDateTime_IsAvailable > 0 then begin // not available if 0
         DVDateTime := Format ('date: %.2d/%.2d/%.2d %.2d:%.2d:%.2d', [DVDateTime_Day, DVDateTime_Month,  DVDateTime_Year, DVDateTime_Hour, DVDateTime_Min, DVDateTime_Sec]);
      end
      else begin
         DVDateTime := '';
      end;
      edtDVDateTime.Text := DVTimeCode + ' ' + DVDateTime;

      if VideoGrabber.CurrentState = cs_Recording then begin
         if (FrameTime - FKBWritten_LastReportTime) > 50000000 then begin // 5 seconds
            FKBWritten_LastReportTime := FrameTime;
            mmoLog.Lines.Add ('written to disk: ' + IntToStr (VideoGrabber.RecordingKBytesWrittenToDisk) + ' KB');
         end;
      end;
   end;
end;

procedure CopyFrameToBitmapDemo (BitmapInfo: pFrameBitmapInfo);
var
   NewBitmap: TBitmap;
begin
   // this code shows how to make a copy of the current video frame to an Image, invoke it from the OnFrameBitmap event below

   NewBitmap := TBitmap.Create;
   NewBitmap.Canvas.Lock;
   NewBitmap.Width := BitmapInfo^.BitmapWidth;
   NewBitmap.Height := BitmapInfo^.BitmapHeight;
   case BitmapInfo^.BitmapBitsPerPixel of
      32: NewBitmap.PixelFormat := pf32Bit;
      24: NewBitmap.PixelFormat := pf24Bit;
      16: NewBitmap.PixelFormat := pf16Bit;
      15: NewBitmap.PixelFormat := pf15Bit;
       8: NewBitmap.PixelFormat := pf8Bit;
    else  NewBitmap.PixelFormat := pf24Bit;
   end;
   BitBlt (NewBitmap.Canvas.Handle, 0, 0, BitmapInfo^.BitmapWidth, BitmapInfo^.BitmapHeight, BitmapInfo^.BitmapDC, 0, 0, SRCCOPY);
   NewBitmap.Canvas.Unlock;
   NewBitmap.SaveToFile ('c:\myfolder\myframecapture.bmp');
   NewBitmap.Free;
end;

procedure DrawCircle (Canvas: TCanvas; xCenter, yCenter, Radius: LongInt);
var
   xCenterAndRadius: LongInt;
begin
   xCenterAndRadius := xCenter + Radius;
   Canvas.Arc (xCenter - Radius, yCenter - Radius, xCenterAndRadius, yCenter + Radius, xCenterAndRadius, xCenter, xCenterAndRadius, xCenter);
end;

procedure TfrmMainForm.VideoGrabberFrameBitmap(Sender: TObject; FrameInfo: pFrameInfo; BitmapInfo: pFrameBitmapInfo);
type
   pTRGB24Array = ^TRGB24Array;
   TRGB24Array = array[0..65535] of TRGBTriple;

   pTRGB32Array = ^TRGB32Array;
   TRGB32Array = array[0..65535] of TRGBQuad;
var
   i, iCol: integer;
   Canvas: TCanvas;
   NewVideoSignalState: Boolean;
   xStep, yStep, xLocation, yLocation: LongInt;
   BitmapLinePtr: LongWord;
   RGB32Line: pTRGB32Array;
   RGB24Line: pTRGB24Array;
   TargetRadius: LongInt;
begin
//    From this event you should not perform any actions with the potential to block:
//    1. do not hold a critical section or wait on another thread,
//    2. do not call any GDI or USER32.DLL APIs that might cause a window to move,
//    3. do not invoke component properties that send messages, e.g. do not read the ItemIndex property
//       of a ListBox component. If you need to read a such property, set an intermediary variable when
//       the property changes, and then read the intermediary variable from this event.

  // -----------------------------------------------------------
  // CopyFrameToBitmapDemo (BitmapInfo); // CopyFrameToBitmapDemo shows how to make a copy of the current video frame, just uncomment this line to use it
  // -----------------------------------------------------------

  with BitmapInfo^ do begin

   // DRAWS A TARGET AT THE MOUSE LOCATION
   // ====================================

   if chkDrawTarget.Checked then begin
      if LastMouseButtonClicked = mbLeft then begin
         Canvas := TCanvas.Create;
         Canvas.Handle := BitmapDC;
         Canvas.Pen.Color := clRed;
         TargetRadius := 50;
         DrawCircle (Canvas, LastXMouseDownLocation, LastYMouseDownLocation, TargetRadius);
         Canvas.MoveTo (LastXMouseDownLocation - TargetRadius, LastYMouseDownLocation);
         Canvas.LineTo (LastXMouseDownLocation + TargetRadius, LastYMouseDownLocation);
         Canvas.MoveTo (LastXMouseDownLocation, LastYMouseDownLocation - TargetRadius);
         Canvas.LineTo (LastXMouseDownLocation, LastYMouseDownLocation + TargetRadius);
         Canvas.Free;
      end;
   end;

   // DIRECT ACCESS TO THE RGB PIXELS
   // ===============================

   if ChkChangePixels.Checked then begin
      BitmapLinePtr := LongWord (BitmapDataPtr);

      if BitmapBitsPerPixel = 24 then begin   // case where FrameGrabberRGBFormat is set to fgf_RGB24 (you can select it in the "frame grabber" tab)
         for i := 0 to BitmapHeight - 1 do begin
            RGB24Line := pTRGB24Array (BitmapLinePtr);
            for iCol := 0 to BitmapWidth - 1 do begin
               RGB24Line[iCol].rgbtGreen := 0; // e.g. we remove the green color -> purple image
            end;
            inc (BitmapLinePtr, BitmapLineSize);
         end;
      end
      else if BitmapBitsPerPixel = 32 then begin   // case where FrameGrabberRGBFormat is set to fgf_RGB32 (default setting) (you can select it in the "frame grabber" tab)
         for i := 0 to BitmapHeight - 1 do begin
            RGB32Line := pTRGB32Array (BitmapLinePtr);
            for iCol := 0 to BitmapWidth - 1 do begin
               RGB32Line[iCol].rgbBlue := 0; // e.g. we remove the blue color -> yellow image
            end;
            inc (BitmapLinePtr, BitmapLineSize);
         end;
      end;
   end;

   // GRID DRAWING BY USING THE CANVAS DC AND FILLRECT
   // ================================================

   if chkDrawGridOverFrames.Checked then begin

      xStep := BitmapWidth div 10;
      yStep := BitmapHeight div 10;

      xLocation := xStep;
      yLocation := yStep;

      Canvas := TCanvas.Create;
      Canvas.Brush.Color := clBlue;
      Canvas.Brush.Style := bsSolid;
      Canvas.Handle := BitmapDC;

      while xLocation < BitmapWidth do begin
         Canvas.FillRect(Rect(xLocation, 0, xLocation + 1, BitmapHeight));
         inc (xLocation, xStep);
      end;

      while yLocation < BitmapHeight do begin
         Canvas.FillRect(Rect(0, yLocation, BitmapWidth, yLocation + 1));
         inc (yLocation, yStep);
      end;

      Canvas.Free;
   end;

   // FREE HAND DRANWING BY USING THE CANVAS DC AND LINETO / MOVETO
   // =============================================================

   if FiFreeHandMouseDrawing > 0 then begin // see VideoGrabberMouseMove event below
      Canvas := TCanvas.Create;
      Canvas.Handle := BitmapDC;
      Canvas.Pen.Color := clRed;
      for i := 0 to FiFreeHandMouseDrawing - 1 do begin
         if FFreeHandMouseDrawing[i].Right = 0 then begin // Right is used as boolean to know if it is a MoveTo or a LineTo
            Canvas.MoveTo (FFreeHandMouseDrawing[i].Left, FFreeHandMouseDrawing[i].Top);
            Canvas.Pixels[FFreeHandMouseDrawing[i].Left, FFreeHandMouseDrawing[i].Top] := clRed;
         end
         else begin
            Canvas.LineTo (FFreeHandMouseDrawing[i].Left, FFreeHandMouseDrawing[i].Top);
         end;
      end;
      Canvas.Free;
   end;

   // VIDEO SIGNAL DETECTION
   // ======================

   if rdgDetectVideoSignal.ItemIndex > 0 then begin
      NewVideoSignalState := False;
      if rdgDetectVideoSignal.ItemIndex = 1 then begin // no video signal (dark screen)
         NewVideoSignalState := VideoGrabber.IsVideoSignalDetected (false, true, 30, 30, 30, true);
      end
      else if rdgDetectVideoSignal.ItemIndex = 2 then begin // Connexant blue screen (no signal)
         NewVideoSignalState := VideoGrabber.IsVideoSignalDetected (true, false, 0, 0, 0, false);
      end;
      if NewVideoSignalState <> FOldVideoSignalState then begin
         FOldVideoSignalState := NewVideoSignalState; // memorize the new state
         if NewVideoSignalState then begin
            mmoLog.Lines.Add ('Video signal is back');
         end
         else begin
            mmoLog.Lines.Add ('VIDEO SIGNAL LOST');
         end;
      end;
   end;
  end;
end;

procedure TfrmMainForm.VideoGrabberFrameCaptureCompleted(Sender: TObject;
  FrameBitmap: TBitmap; BitmapWidth, BitmapHeight: Integer;
  FrameNumber: Cardinal; FrameTime: Int64; DestType: TFrameCaptureDest;
  FileName: String; Success: Boolean; FrameId: Integer);
var
   DestForm: TForm;
   DestImage: TImage;
begin
   if Success then begin
      mmoFrameCaptureLog.Lines.Add ('frame #' + IntToStr (FrameNumber) + ' captured');
   end;
   Case DestType of
      // ______ bmp or jpeg file
      fc_BmpFile, fc_JpegFile: begin
         if Success then begin
             mmoFrameCaptureLog.Lines.Add (FileName);
          end
          else begin
             mmoFrameCaptureLog.Lines.Add ('error: failed to create ' + FileName);
          end;
       end;

      // ______ memory bitmap
      fc_TBitmap: begin
         if VideoGrabber.CanProcessMessages then begin // to prevent crash in synchrone mode (mainly when Player is playing and UseClock is disabled)
            if (not VideoGrabber.BurstMode) or (VideoGrabber.BurstMode and (VideoGrabber.BurstCount = 0)) then begin // reuse the same form
               if not assigned (FSnapForm) then begin
                  Application.CreateForm (TForm, FSnapForm);
                  FSnapForm.Position := poDefault;
                  FSnapForm.Formstyle := fsStayOnTop;
               end;
               if assigned (FSnapImage) then begin
                  FSnapImage.Free;
               end;
               FSnapImage := TImage.Create (FSnapForm);
               DestForm := FSnapForm;
               DestImage := FSnapImage;
            end
            else begin // create a form for each image
               Application.CreateForm (TForm, DestForm);
               DestForm.Position := poDefault;
               DestForm.Formstyle := fsStayOnTop;
               DestImage := TImage.Create (DestForm);
               DestImage.Parent := DestForm;
            end;

            DestForm.ClientWidth := BitmapWidth;
            DestForm.ClientHeight := BitmapHeight;
            DestImage.AutoSize := true;

            DestImage.Picture.Bitmap.Assign (FrameBitmap);
            // REPLACING THE STATEMENT ABOVE BY THE 2 STATEMENTS BELOW IS FASTER (AVOIDS BITMAP COPY),
            // DestImage.Picture.Bitmap.Handle := FrameBitmap.Handle;
            // FrameBitmap.ReleaseHandle;

            DestImage.Parent := DestForm;

            if not DestForm.Visible then begin
               DestForm.Show;
            end;
         end;
      end;
    end;
end;

////////////////////////////////////////////////////////////////////////////////
//                             PLAYER TAB
////////////////////////////////////////////////////////////////////////////////

procedure TfrmMainForm.btnPlayerOpenFileClick(Sender: TObject);
var
   OpenDlg: TOpenDialog;
begin
   OpenDlg := TOpenDialog.Create (nil);
   OpenDlg.Filter := OPEN_MEDIA_FILES_EXTENDED;
   if OpenDlg.Execute then begin
      edtPlayerClip.Text :=OpenDlg.FileName;
   end;
   OpenDlg.Free;
end;

procedure TfrmMainForm.btnOpenLastClipRecordedClick(Sender: TObject);
begin
   if VideoGrabber.Last_Recording_FileName <> '' then begin
      edtPlayerClip.Text := VideoGrabber.Last_Recording_FileName;
      VideoGrabber.PlayerFileName := edtPlayerClip.Text;
      VideoGrabber.OpenPlayer;
   end;
end;

procedure TfrmMainForm.btnOpenLastClipPlayedClick(Sender: TObject);
begin
   if VideoGrabber.Last_Clip_Played <> '' then begin
      edtPlayerClip.Text := VideoGrabber.Last_Clip_Played;
      VideoGrabber.PlayerFileName := edtPlayerClip.Text;
      VideoGrabber.OpenPlayer;
   end;
end;

procedure TfrmMainForm.btnGetClipDurationClick(Sender: TObject);
var
   Duration: int64;
   FrameCount: int64;
begin
    if VideoGrabber.AVIDuration (edtPlayerClip.Text, Duration, FrameCount) then begin
       mmoLog.Lines.Add ('Duration: ' + IntToStr (Duration));
       mmoLog.Lines.Add ('Frame count: ' + IntToStr (FrameCount));
    end
    else begin
       mmoLog.Lines.Add ('failed to get info for this clip');
    end;
end;

procedure TfrmMainForm.btnGeneralInfoClick(Sender: TObject);
var
   Duration: int64;
   FrameCount: int64;
   VideoWidth: LongInt;
   VideoHeight: LongInt;
   VideoCodec: string;
   AudioCodec: string;
   VideoFrameRateFps: Double;
   AvgBitRate: LongInt;
   AudioChannels: LongInt;
   AudioSamplesPerSec: LongInt;
   AudioBitsPerSample: LongInt;
begin
   if VideoGrabber.AVIInfo (edtPlayerClip.Text, Duration, FrameCount, VideoWidth, VideoHeight, VideoFrameRateFps, AvgBitRate, AudioChannels, AudioSamplesPerSec, AudioBitsPerSample, VideoCodec, AudioCodec) then begin
      mmoLog.lines.Add ('');
      mmoLog.lines.Add (edtPlayerClip.Text + ':');
      mmoLog.lines.Add ('duration (in sec): ' + FormatFloat ('0.00', Duration / 10000000));
      mmoLog.lines.Add ('frame count: ' + IntToStr (FrameCount));
      mmoLog.lines.Add ('video source width: ' + IntToStr (VideoWidth));
      mmoLog.lines.Add ('video source height: ' + IntToStr (VideoHeight));
      mmoLog.lines.Add ('video frame rate (fps): ' + FormatFloat ('0.00', VideoFrameRateFps));
      mmoLog.lines.Add ('average bit rate (kb/s): ' + IntToStr (AvgBitRate div 1024));
      mmoLog.lines.Add ('audio channels: ' + IntToStr (AudioChannels));
      mmoLog.lines.Add ('audio samples/sec: ' + IntToStr (AudioSamplesPerSec));
      mmoLog.lines.Add ('audio bits per sample: ' + IntToStr (AudioBitsPerSample));
      mmoLog.lines.Add ('video codec: ' + VideoCodec);
      mmoLog.lines.Add ('audio codec: ' + AudioCodec);
   end
   else begin
      mmoLog.lines.Add (edtPlayerClip.Text + ' clip not found.');
   end;
end;

procedure TfrmMainForm.btnHeaderInfoClick(Sender: TObject);
begin
    mmoLog.lines.Add ('');
    mmoLog.lines.Add (edtPlayerClip.Text + ' headers:');
    mmoLog.Lines.Add ('Title: ' + VideoGrabber.AVIHeaderInfo(edtPlayerClip.Text, ha_Title));
    mmoLog.Lines.Add ('Description: ' + VideoGrabber.AVIHeaderInfo(edtPlayerClip.Text, ha_Description));
    mmoLog.Lines.Add ('Author: ' + VideoGrabber.AVIHeaderInfo(edtPlayerClip.Text, ha_Author));
    mmoLog.Lines.Add ('Copyright: ' + VideoGrabber.AVIHeaderInfo(edtPlayerClip.Text, ha_Copyright));
    mmoLog.Lines.Add ('Album Artist: ' + VideoGrabber.AVIHeaderInfo(edtPlayerClip.Text, ha_AlbumArtist));
    mmoLog.Lines.Add ('Album Title: ' + VideoGrabber.AVIHeaderInfo(edtPlayerClip.Text, ha_AlbumTitle));
    mmoLog.Lines.Add ('Composer: ' + VideoGrabber.AVIHeaderInfo(edtPlayerClip.Text, ha_Composer));
    mmoLog.Lines.Add ('Content Distributor: ' + VideoGrabber.AVIHeaderInfo(edtPlayerClip.Text, ha_ContentDistributor));
    mmoLog.Lines.Add ('Director: ' + VideoGrabber.AVIHeaderInfo(edtPlayerClip.Text, ha_Director));
    mmoLog.Lines.Add ('Encoding Time: ' + VideoGrabber.AVIHeaderInfo(edtPlayerClip.Text, ha_EncodingTime));
    mmoLog.Lines.Add ('Genre: ' + VideoGrabber.AVIHeaderInfo(edtPlayerClip.Text, ha_Genre));
    mmoLog.Lines.Add ('Language: ' + VideoGrabber.AVIHeaderInfo(edtPlayerClip.Text, ha_Language));
    mmoLog.Lines.Add ('Parental Rating: ' + VideoGrabber.AVIHeaderInfo(edtPlayerClip.Text, ha_ParentalRating));
    mmoLog.Lines.Add ('Producer: ' + VideoGrabber.AVIHeaderInfo(edtPlayerClip.Text, ha_Producer));
    mmoLog.Lines.Add ('Provider: ' + VideoGrabber.AVIHeaderInfo(edtPlayerClip.Text, ha_Provider));
    mmoLog.Lines.Add ('ToolName: ' + VideoGrabber.AVIHeaderInfo(edtPlayerClip.Text, ha_ToolName));
    mmoLog.Lines.Add ('Tool Version: ' + VideoGrabber.AVIHeaderInfo(edtPlayerClip.Text, ha_ToolVersion));
    mmoLog.Lines.Add ('Writer: ' + VideoGrabber.AVIHeaderInfo(edtPlayerClip.Text, ha_Writer));
end;

procedure TfrmMainForm.btnOpenClipClick(Sender: TObject);
begin
   VideoGrabber.PlayerFileName := edtPlayerClip.Text;
   VideoGrabber.OpenPlayer;
end;

procedure TfrmMainForm.btnPlayerCloseClipClick(Sender: TObject);
begin
   VideoGrabber.ClosePlayer;
end;

procedure TfrmMainForm.btnPlayerPauseClick(Sender: TObject);
begin
   VideoGrabber.PausePlayer;
end;

procedure TfrmMainForm.btnPlayerStopClick(Sender: TObject);
begin
   VideoGrabber.StopPlayer;
end;

procedure TfrmMainForm.btnPlayerStartPlayingClick(Sender: TObject);
begin
   VideoGrabber.RunPlayer;
end;

procedure TfrmMainForm.btnPlayerFrameStepClick(Sender: TObject);
begin
   VideoGrabber.PlayerFrameStep (1);
end;

procedure TfrmMainForm.btnPlayerBackwardsClick(Sender: TObject);
begin
   VideoGrabber.RunPlayerBackwards;
end;

procedure TfrmMainForm.btnPlayerRewindClick(Sender: TObject);
begin
   VideoGrabber.RewindPlayer;
end;

procedure TfrmMainForm.btnPlayerFastForwardClick(Sender: TObject);
begin
   VideoGrabber.FastForwardPlayer;
end;

procedure TfrmMainForm.btnAutoPlayClick(Sender: TObject);
begin
   VideoGrabber.AutoStartPlayer := btnAutoPlay.Checked;
end;

procedure TfrmMainForm.tbrPlayerProgressChange(Sender: TObject);
begin
    // the tbrPlayer trackbar is assigned directly to the VideoGrabber.PlayerTrackBar property, that handle the position automatically
end;

procedure TfrmMainForm.chkPlayerTrackbarSynchroneClick(Sender: TObject);
begin
   VideoGrabber.PlayerTrackBarSynchrone := chkPlayerTrackbarSynchrone.Checked;
end;

procedure TfrmMainForm.chkPlayerAudioRenderingClick(Sender: TObject);
begin
   VideoGrabber.PlayerAudioRendering := chkPlayerAudioRendering.Checked;
end;

procedure TfrmMainForm.chkPlayerLoopClick(Sender: TObject);
begin
   // the code is in the PlayerEndOfStream event
end;

procedure TfrmMainForm.chkUseClockClick(Sender: TObject);
begin
   VideoGrabber.UseClock := chkUseClock.Checked;
end;

procedure TfrmMainForm.chkRefreshPausedDisplayClick(Sender: TObject);
begin
   VideoGrabber.PlayerRefreshPausedDisplay := chkRefreshPausedDisplay.Checked;
end;

procedure TfrmMainForm.edtPlayerSpeedRatioChange(Sender: TObject);
var
   OldSpeedRatio: double;
begin
   OldSpeedRatio := VideoGrabber.PlayerSpeedRatio;
   VideoGrabber.PlayerSpeedRatio := StrToFloatDef (edtPlayerSpeedRatio.Text, 1.0);
   if VideoGrabber.PlayerSpeedRatio <> OldSpeedRatio then begin
      mmoLog.Lines.Add ('player speed ratio selected: ' + FormatFloat ('0.0', VideoGrabber.PlayerSpeedRatio));
   end;
end;

procedure TfrmMainForm.updPlayerFastSeekSpeedClick(Sender: TObject; Button: TUDBtnType);
begin
   VideoGrabber.PlayerFastSeekSpeedRatio := updPlayerFastSeekSpeed.Position;
   edtPlayerFastSeekSpeed.Text := IntToStr (VideoGrabber.PlayerFastSeekSpeedRatio);
end;

procedure TfrmMainForm.VideoGrabberPlayerOpened(Sender: TObject);
begin
   mmoLog.Lines.Add ('');
   mmoLog.Lines.Add ('playing ' + VideoGrabber.PlayerFileName);
   if VideoGrabber.IsPlayervideoStreamAvailable = ts_True then begin
      mmoLog.Lines.Add ('this clip has a video stream');
   end
   else if VideoGrabber.IsPlayervideoStreamAvailable = ts_False then begin
      mmoLog.Lines.Add ('this clip does not have video');
   end;
   if VideoGrabber.IsPlayerAudioStreamAvailable = ts_True then begin
      mmoLog.Lines.Add ('this clip has an audio stream');
   end
   else if VideoGrabber.IsPlayerAudioStreamAvailable = ts_False then begin
      mmoLog.Lines.Add ('this clip does not have audio');
   end;
   mmoLog.Lines.Add ('');
   mmoLog.Lines.Add ('video codec: ' + VideoGrabber.PlayerVideoCodec);
   mmoLog.Lines.Add ('audio codec: ' + VideoGrabber.PlayerAudioCodec);
   mmoLog.Lines.Add ('');
   mmoLog.Lines.Add ('Duration: ' + FormatFloat ('0.00', VideoGrabber.PlayerDuration / 10000000));
   mmoLog.Lines.Add ('Frame count: ' + inttostr (VideoGrabber.PlayerFrameCount));
   mmoLog.Lines.Add ('Frame rate: ' + FormatFloat ('0.00', VideoGrabber.PlayerFrameRate));
   mmoLog.lines.Add ('video source size: ' + IntToStr (VideoGrabber.VideoWidth) + 'x' + IntToStr (VideoGrabber.VideoHeight));
   mmoLog.lines.Add ('display aspect ratio: ' + IntToStr (VideoGrabber.VideoWidth_PreferredAspectRatio) + 'x' + IntToStr (VideoGrabber.VideoHeight_PreferredAspectRatio));

   if VideoGrabber.IsPlaylistActive then begin
      lstPlaylist.ItemIndex := videograbber.PlaylistIndex;
   end;
end;

procedure TfrmMainForm.VideoGrabberPlayerBufferingData(Sender: TObject;
  StartingToBuffer: Boolean);
begin
   if StartingToBuffer then begin
      mmoLog.Lines.Add ('buffering data...');
   end
   else begin
      mmoLog.Lines.Add ('buffering completed.');
   end;
end;

procedure TfrmMainForm.btnAddToPlaylistClick(Sender: TObject);
var
   i: LongInt;
var
   OpenDlg: TOpenDialog;
begin
   OpenDlg := TOpenDialog.Create (nil);
   OpenDlg.Filter := OPEN_MEDIA_FILES_EXTENDED;
   OpenDlg.Options := [ofAllowMultiSelect];
   if OpenDlg.Execute then begin
      for i := 0 to OpenDlg.Files.Count - 1 do begin
         VideoGrabber.Playlist (pl_Add, OpenDlg.Files[i]);
         lstPlaylist.Items.Add (OpenDlg.Files[i]);
      end;
   end;
   OpenDlg.Free;
end;

procedure TfrmMainForm.btnPlaylistPlayClick(Sender: TObject);
begin
   VideoGrabber.Playlist (pl_Play, '');
end;

procedure TfrmMainForm.btnPlaylistNextClick(Sender: TObject);
begin
   VideoGrabber.Playlist (pl_Next, '');
end;

procedure TfrmMainForm.btnPlaylistPreviousClick(Sender: TObject);
begin
   VideoGrabber.Playlist (pl_Previous, '');
end;

procedure TfrmMainForm.btnPlaylistStopClick(Sender: TObject);
begin
   VideoGrabber.Playlist (pl_Stop, '');
end;

procedure TfrmMainForm.btnClosePlaylistClick(Sender: TObject);
begin
   VideoGrabber.ClosePlayer;
end;

procedure TfrmMainForm.chkPlaylistLoopClick(Sender: TObject);
begin
   if chkPlaylistLoop.Checked then begin
      VideoGrabber.Playlist (pl_Loop, '');
   end
   else begin
      VideoGrabber.Playlist (pl_NoLoop, '');
   end;
end;

procedure TfrmMainForm.chkPlaylistRandomClick(Sender: TObject);
begin
   if chkPlaylistRandom.Checked then begin
      VideoGrabber.Playlist (pl_Random, '');
   end
   else begin
      VideoGrabber.Playlist (pl_Sequential, '');
   end;
end;

procedure TfrmMainForm.lstPlaylistClick(Sender: TObject);
begin
   VideoGrabber.PlaylistIndex := lstPlaylist.ItemIndex;
   VideoGrabber.Playlist (pl_Play, '');
end;

procedure TfrmMainForm.VideoGrabberPlayerEndOfStream(Sender: TObject);
begin
   mmoLog.Lines.Add ('end of stream.');
   if chkPlayerLoop.Checked then begin
      VideoGrabber.RunPlayer;
   end;
end;

procedure TfrmMainForm.VideoGrabberPlayerEndOfPlaylist(Sender: TObject);
begin
   mmoLog.Lines.Add ('END OF PLAYLIST.');
end;

////////////////////////////////////////////////////////////////////////////////
//                           NETWORK STREAMING TAB
////////////////////////////////////////////////////////////////////////////////

procedure TfrmMainForm.btnViewDirectNetworkStreamingClick(Sender: TObject);
begin
   if VideoGrabber.StreamingURL <> '' then begin
      ShellExecute(0, 'open', PChar(VideoGrabber.StreamingURL), '', '', SW_SHOW);
   end;
end;

procedure TfrmMainForm.rdgNetworkStreamingClick(Sender: TObject);
begin
   VideoGrabber.NetworkStreaming := TNetworkStreaming (rdgNetworkStreaming.ItemIndex);
   btnViewDirectNetworkStreaming.Enabled := VideoGrabber.NetworkStreaming = ns_ASFDirectNetworkStreaming;
   rdgNetworkStreamingType.Enabled := VideoGrabber.NetworkStreaming <> ns_Disabled;
end;

procedure TfrmMainForm.rdgNetworkStreamingTypeClick(Sender: TObject);
begin
   VideoGrabber.NetworkStreamingType := TNetworkStreamingType (rdgNetworkStreamingType.ItemIndex);
end;

procedure TfrmMainForm.edtNetworkPortChange(Sender: TObject);
begin
   VideoGrabber.ASFNetworkPort := StrToIntDef (edtNetworkPort.Text, 0);
end;

procedure TfrmMainForm.edtNetworkMaxUsersChange(Sender: TObject);
begin
   VideoGrabber.ASFNetworkMaxUsers := StrToIntDef (edtNetworkMaxUsers.Text, 0);
end;

procedure TfrmMainForm.edtPublishingPointChange(Sender: TObject);
begin
   VideoGrabber.ASFMediaServerPublishingPoint := edtPublishingPoint.Text;
end;

procedure TfrmMainForm.edtPublishingPointUsernameChange(Sender: TObject);
begin
   VideoGrabber.SetAuthentication (at_PublishingPoint, edtPublishingPointUsername.Text, edtPublishingPointPassword.Text);
end;

procedure TfrmMainForm.edtPublishingPointPasswordChange(Sender: TObject);
begin
   VideoGrabber.SetAuthentication (at_PublishingPoint, edtPublishingPointUsername.Text, edtPublishingPointPassword.Text);
end;

procedure TfrmMainForm.rdgProfileVersionClick(Sender: TObject);
begin
   VideoGrabber.ASFProfileVersion := TASFProfileVersion (rdgProfileVersion.ItemIndex);
end;

procedure TfrmMainForm.btnSelectWMV9ProfileClick(Sender: TObject);
var
   OpenDlg: TOpenDialog;
begin
   if VideoGrabber.ASFProfileVersion = apv_ProfileVersion_9 then begin
      OpenDlg := TOpenDialog.Create (nil);
      OpenDlg.Filter := 'WMV9 profiles (*.prx)|*.prx';
      if OpenDlg.Execute then begin
         edtWM9Profile.Text :=OpenDlg.FileName;
      end;
      OpenDlg.Free;
   end
   else begin
      ShowMessage ('select WMV version 9 first');
   end;
end;

procedure TfrmMainForm.edtWM9ProfileChange(Sender: TObject);
begin
   VideoGrabber.ASFProfileFromCustomFile := edtWM9Profile.Text;
end;

procedure TfrmMainForm.btnShowProfilesListClick(Sender: TObject);
begin
   if VideoGrabber.ASFProfileVersion = apv_ProfileVersion_8 then begin
      LsbProfiles.Items.Text := VideoGrabber.ASFProfiles;
   end
   else begin
      ShowMessage ('select WMV version 8 first');
   end;
end;

procedure TfrmMainForm.edtASFVideoWidthChange(Sender: TObject);
begin
   VideoGrabber.ASFVideoWidth := StrToIntDef (edtASFVideoWidth.Text, -1);
end;

procedure TfrmMainForm.edtASFVideoHeightChange(Sender: TObject);
begin
   VideoGrabber.ASFVideoHeight := StrToIntDef (edtASFVideoHeight.Text, -1);
end;

procedure TfrmMainForm.edtASFVideoBitRateChange(Sender: TObject);
begin
   VideoGrabber.ASFVideoBitRate := StrToIntDef (edtASFVideoBitRate.Text, -1);
end;

procedure TfrmMainForm.edtASFVideoMaxKeyFrameSpacingChange(Sender: TObject);
begin
   VideoGrabber.ASFVideoMaxKeyFrameSpacing := StrToIntDef (edtASFVideoMaxKeyFrameSpacing.Text, -1);
end;

procedure TfrmMainForm.edtASFVideoQualityChange(Sender: TObject);
begin
   VideoGrabber.ASFVideoQuality := StrToIntDef (edtASFVideoQuality.Text, -1);
end;

procedure TfrmMainForm.edtASFAudioChannelsChange(Sender: TObject);
begin
   VideoGrabber.ASFAudioChannels := StrToIntDef (edtASFAudioChannels.Text, -1);
end;

procedure TfrmMainForm.chkASFFixedFrameRateClick(Sender: TObject);
begin
   VideoGrabber.ASFFixedFrameRate := chkASFFixedFrameRate.Checked;
end;

procedure TfrmMainForm.cmbASFDeinterlaceModeChange(Sender: TObject);
begin
   VideoGrabber.ASFDeinterlaceMode := TASFDeinterlaceMode (cmbASFDeinterlaceMode.ItemIndex);
end;

procedure TfrmMainForm.edtProfileIndexChange(Sender: TObject);
begin
   VideoGrabber.ASFProfile := StrToIntDef (edtProfileIndex.Text, -1);
end;

procedure TfrmMainForm.lsbProfilesClick(Sender: TObject);
begin
   if LsbProfiles.Items.Count > 0 then begin
      VideoGrabber.ASFProfile := LsbProfiles.ItemIndex;
      edtProfileIndex.Text := IntToStr (VideoGrabber.ASFProfile);
   end;
end;

procedure TfrmMainForm.VideoGrabberDirectNetworkStreamingHostUrl(
  Sender: TObject; HostUrl, HostName: String; HostPort: Integer);
begin
   mmoLog.Lines.Add ('streaming URL: ' + HostUrl);
   mmoLog.Lines.Add ('streaming host: ' + HostName);
   mmoLog.Lines.Add ('streaming port: ' + IntToStr (HostPort));
   btnViewDirectNetworkStreaming.Enabled := True;
end;

procedure TfrmMainForm.VideoGrabberClientConnection(Sender: TObject;
  Connected: Boolean; ClientInfo: String);
begin
   if Connected then begin
      mmoLog.Lines.Add ('client connected: ' + ClientInfo);
   end
   else begin
      mmoLog.Lines.Add ('client disconnected: ' + ClientInfo);
   end;
end;

////////////////////////////////////////////////////////////////////////////////
//                            TV TUNER TAB
////////////////////////////////////////////////////////////////////////////////

procedure TfrmMainForm.btnShowTunerDialogClick(Sender: TObject);
begin
   VideoGrabber.ShowDialog (dlg_TVTuner);
   RefreshDeviceControls;
end;

procedure TfrmMainForm.rdgTunerModeClick(Sender: TObject);
begin
   VideoGrabber.TunerMode := TTunerMode (rdgTunerMode.ItemIndex);
end;

procedure TfrmMainForm.rdgTunerInputTypeClick(Sender: TObject);
begin
   VideoGrabber.TVTunerInputType := TTunerInputType (rdgTunerInputType.ItemIndex);
end;

procedure TfrmMainForm.btnSetCountryCodeClick(Sender: TObject);
var
   CountryCode: Integer;
begin
   CountryCode := StrToIntDef (edtCountryCode.Text, - 1);
   if CountryCode >= 0 then begin
      VideoGrabber.TVCountryCode := CountryCode;
   end;
end;

procedure TfrmMainForm.btnSelectClick(Sender: TObject);
var
   Channel: Integer;
begin
   Channel  := StrToIntDef (edtTVChannel.Text, - 1);
   if Channel <> -1 then begin
      VideoGrabber.TVChannel := Channel;
   end;
end;

procedure TfrmMainForm.chkSetFrequencyOverrideClick(Sender: TObject);
var
   Channel: Integer;
   Frequency: Integer;
begin
   Channel  := StrToIntDef (edtTVChannel.Text, - 1);
   Frequency := StrToIntDef (edtChannelFrequency.Text, - 1);
   if (Channel <> -1) and (Frequency <> -1) then begin
      VideoGrabber.TVSetChannelFrequencyOverride (Channel, Frequency);
   end;
end;

procedure TfrmMainForm.btnDeleteFrequencyOverrideClick(Sender: TObject);
var
   Channel: Integer;
begin
   Channel  := StrToIntDef (edtTVChannel.Text, - 1);
   if Channel <> -1 then begin
      VideoGrabber.TVSetChannelFrequencyOverride (Channel, -1);
   end;
end;

procedure TfrmMainForm.chkEnableFrequencyOverridesClick(Sender: TObject);
begin
   VideoGrabber.TVUseFrequencyOverrides := chkEnableFrequencyOverrides.Checked;
end;

procedure TfrmMainForm.btnStartScanClick(Sender: TObject);
begin
   VideoGrabber.TVStartAutoScan;
end;

procedure TfrmMainForm.btnStopScanClick(Sender: TObject);
begin
   VideoGrabber.TVStopAutoScan;
end;

procedure TfrmMainForm.btnResetAllOverridesClick(Sender: TObject);
begin
   VideoGrabber.TVClearFrequencyOverrides;
end;

procedure TfrmMainForm.VideoGrabberTVChannelSelected(Sender: TObject;
  Channel: Integer; Locked: Boolean; DefaultVideoFrequency,
  OverriddenVideoFrequency, TunerVideoFrequency,
  TunerAudioFrequency: Integer);
var
   sFrequencyInfo: String;
begin
   if Locked then begin
      sFrequencyInfo := IntToStr (Channel) + ': ' + FormatFloat ('0.00', TunerVideoFrequency / 1000000) + ' Mhz (' + IntToStr (TunerVideoFrequency) + ' Hz';
      if OverriddenVideoFrequency <> -1 then begin
         sFrequencyInfo := sFrequencyInfo + ', overridden';
      end;
      sFrequencyInfo := sFrequencyInfo + ')';
      mmoChannelLog.Lines.Add (sFrequencyInfo);
   end
   else begin
      if OverriddenVideoFrequency <> -1 then begin
         mmoChannelLog.Lines.Add (IntToStr (Channel) + '... overridden and not locked');
      end
      else begin
         mmoChannelLog.Lines.Add (IntToStr (Channel) + '...');
      end;
   end;
   edtTVChannel.Text := IntToStr (Channel);
   if OverriddenVideoFrequency <> -1 then begin
      edtChannelFrequency.Text := IntToStr (OverriddenVideoFrequency);
   end
   else begin
      edtChannelFrequency.Text := IntToStr (TunerVideoFrequency);
   end;
end;

procedure TfrmMainForm.VideoGrabberTVChannelScanStarted(Sender: TObject;
  MinChannel, MaxChannel: Integer);
var
   InputType: String;
begin
   Case VideoGrabber.TVTunerInputType of
      TunerInputCable   : InputType := 'cable input';
      TunerInputAntenna : InputType := 'antenna input';
   end;
   mmoChannelLog.Lines.Add ('scanning country code ' + IntToStr (VideoGrabber.TVCountryCode) + ' (' + InputType + ') from channel ' + IntToStr (MinChannel) + ' to ' + IntToStr (MaxChannel) + '...');
end;

procedure TfrmMainForm.VideoGrabberTVChannelScanCompleted(
  Sender: TObject);
begin
   mmoChannelLog.Lines.Add ('autoscan completed.');
end;

////////////////////////////////////////////////////////////////////////////////
//                            FRAME OVERLAY TAB
////////////////////////////////////////////////////////////////////////////////

procedure TfrmMainForm.chkTextOverlayEnabledClick(Sender: TObject);
begin
   VideoGrabber.TextOverlay_Enabled := chkTextOverlayEnabled.Checked;
   if chkTextOverlayEnabled.Checked then begin
      chkTextOverlayEnabled.Font.Color := clBlack;
   end
   else begin
      chkTextOverlayEnabled.Font.Color := clRed;
   end;
end;

procedure TfrmMainForm.chkTextOverlayScrollingClick(Sender: TObject);
begin
   VideoGrabber.TextOverlay_Scrolling := chkTextOverlayScrolling.Checked;
end;

procedure TfrmMainForm.edtTextOverlayScrollingSpeedChange(Sender: TObject);
begin
   VideoGrabber.TextOverlay_ScrollingSpeed := StrToIntDef (edtTextOverlayScrollingSpeed.Text, 0);
end;

procedure TfrmMainForm.btnTextOverlayColorClick(Sender: TObject);
var
   dlgTextOverlayColor: TColorDialog;
begin
   dlgTextOverlayColor := TColorDialog.Create (nil);
   dlgTextOverlayColor.Color := VideoGrabber.TextOverlay_Font.Color;
   if dlgTextOverlayColor.Execute then begin
      VideoGrabber.TextOverlay_Font.Color := dlgTextOverlayColor.Color;
   end;
   dlgTextOverlayColor.Free;
end;

procedure TfrmMainForm.btnBkgndColorClick(Sender: TObject);
var
   dlgTextOverlayColor: TColorDialog;
begin
   dlgTextOverlayColor := TColorDialog.Create (nil);
   dlgTextOverlayColor.Color := VideoGrabber.TextOverlay_BkColor;
   if dlgTextOverlayColor.Execute then begin
      VideoGrabber.TextOverlay_BkColor := dlgTextOverlayColor.Color;
   end;
   dlgTextOverlayColor.Free;
end;

procedure TfrmMainForm.chkTextOverlayTransparentClick(Sender: TObject);
begin
   VideoGrabber.TextOverlay_Transparent := chkTextOverlayTransparent.Checked;
end;

procedure TfrmMainForm.updTextOverlaySizeClick(Sender: TObject;
  Button: TUDBtnType);
begin
   case Button of
      btPrev: VideoGrabber.TextOverlay_Font.Size := VideoGrabber.TextOverlay_Font.Size - 1;
      btNext: VideoGrabber.TextOverlay_Font.Size := VideoGrabber.TextOverlay_Font.Size + 1;
   end;
end;

procedure TfrmMainForm.chkTextOverlayShadowClick(Sender: TObject);
begin
   VideoGrabber.TextOverlay_Shadow := chkTextOverlayShadow.Checked;
end;

procedure TfrmMainForm.chkAdjustOverlayAspectRatioClick(Sender: TObject);
begin
   VideoGrabber.AdjustOverlayAspectRatio := chkAdjustOverlayAspectRatio.Checked;
end;

procedure TfrmMainForm.rgdTextOverlayShadowDirectionClick(Sender: TObject);
begin
   VideoGrabber.TextOverlay_ShadowDirection := TCardinalDirection (rgdTextOverlayShadowDirection.ItemIndex);
end;

procedure TfrmMainForm.rdgTextOverlayAlignClick(Sender: TObject);
begin
   VideoGrabber.TextOverlay_Align := TTextOverlayAlign (rdgTextOverlayAlign.ItemIndex);
end;

procedure TfrmMainForm.mmoTextOverlayStringChange(Sender: TObject);
begin
   VideoGrabber.TextOverlay_String := mmoTextOverlayString.Text;
end;

procedure TfrmMainForm.edtTextOverlayLeftChange(Sender: TObject);
begin
   VideoGrabber.TextOverlay_Left := StrToIntDef (edtTextOverlayLeft.Text, 0);
end;

procedure TfrmMainForm.edtTextOverlayTopChange(Sender: TObject);
begin
   VideoGrabber.TextOverlay_Top := StrToIntDef (edtTextOverlayTop.Text, 0);
end;

procedure TfrmMainForm.edtTextOverlayRightChange(Sender: TObject);
begin
   VideoGrabber.TextOverlay_Right := StrToIntDef (edtTextOverlayRight.Text, 0);
end;

procedure TfrmMainForm.rdgTextOverlaySelectorClick(Sender: TObject);
begin
   VideoGrabber.TextOverlay_Selector := rdgTextOverlaySelector.ItemIndex;

   // as we have selected another set, let's reload the corresponding values
   chkTextOverlayEnabled.Checked := VideoGrabber.TextOverlay_Enabled;
   if not chkTextOverlayEnabled.Checked then begin
      chkTextOverlayEnabled.Font.Color := clRed;
   end
   else begin
      chkTextOverlayEnabled.Font.Color := clBlack;
   end;
   mmoTextOverlayString.Text := VideoGrabber.TextOverlay_String;
   edtTextOverlayLeft.Text := IntToStr (VideoGrabber.TextOverlay_Left);
   edtTextOverlayTop.Text := IntToStr (VideoGrabber.TextOverlay_Top);
   edtTextOverlayRight.Text := IntToStr (VideoGrabber.TextOverlay_Right);
   rdgTextOverlayAlign.ItemIndex := Integer (VideoGrabber.TextOverlay_Align);
   chkTextOverlayScrolling.Checked := VideoGrabber.TextOverlay_Scrolling;
   edtTextOverlayScrollingSpeed.Text := IntToStr (VideoGrabber.TextOverlay_ScrollingSpeed);
   chkTextOverlayTransparent.Checked := VideoGrabber.TextOverlay_Transparent;
   chkTextOverlayShadow.Checked := VideoGrabber.TextOverlay_Shadow;
   chkTextOverlayShadow.Checked := VideoGrabber.TextOverlay_Shadow;
   rgdTextOverlayShadowDirection.ItemIndex := Integer (VideoGrabber.TextOverlay_ShadowDirection);
end;

procedure TfrmMainForm.chkChangePixelsClick(Sender: TObject);
begin
   // chkChangePixels.Checked is tested in the TfrmMainForm.VideoGrabberFrameBitmap event's code
end;

procedure TfrmMainForm.chkDrawGridOverFramesClick(Sender: TObject);
begin
   // chkDrawTarget.Checked is tested in the TfrmMainForm.VideoGrabberFrameBitmap event's code
end;

procedure TfrmMainForm.chkFreeHandEnabledClick(Sender: TObject);
begin
   // chkFreeHandEnabled.Checked is tested in the TfrmMainForm.VideoGrabberFrameBitmap event's code
end;

procedure TfrmMainForm.btnFreeHandEraseClick(Sender: TObject);
begin
   FiFreeHandMouseDrawing := 0;
   VideoGrabber.RefreshPlayerOverlays;
end;

procedure TfrmMainForm.btnLoadImageOverlayFromFileClick(Sender: TObject);
var
   OpenDlg: TOpenDialog;
begin
   OpenDlg := TOpenDialog.Create (nil);
   OpenDlg.Filter := OPEN_IMAGE_FILES;
   if OpenDlg.Execute then begin
      VideoGrabber.SetImageOverlayFromImageFile (OpenDlg.FileName);
   end;
   OpenDlg.Free;
end;

var
   PIPVideoGrabber: TVideoGrabber = nil;

procedure TfrmMainForm.btnPIPFromAnotherTVideoGrabberClick(
  Sender: TObject);
var
   OpenDlg: TOpenDialog;
begin
   OpenDlg := TOpenDialog.Create (nil);
   OpenDlg.Filter := OPEN_MEDIA_FILES;
   if OpenDlg.Execute then begin
      if not assigned (PIPVideoGrabber) then begin
         PIPVideoGrabber := TVideoGrabber.Create (Self);
         PIPVideoGrabber.VideoRenderer := vr_None;
         PIPVideoGrabber.Visible := false;
         VideoGrabber.Mixer_SetupPIPFromSource (PIPVideoGrabber.UniqueId, 0, 0, 0, 0, true, 10, 10, 200, 150, false);
      end;
      PIPVideoGrabber.PlayerFileName := OpenDlg.FileName;
      PIPVideoGrabber.OpenPlayer();
   end;
   OpenDlg.Free;
end;

procedure TfrmMainForm.rdgImageOverlaySelectorClick(Sender: TObject);
begin
   VideoGrabber.ImageOverlaySelector := rdgImageOverlaySelector.ItemIndex;
   chkImageOverlayEnabled.Checked := VideoGrabber.ImageOverlayEnabled;
   edtImageOverlayLeft.Text := IntToStr (VideoGrabber.ImageOverlay_LeftLocation);
   edtImageOverlayTop.Text := IntToStr (VideoGrabber.ImageOverlay_TopLocation);
   edtImageOverlayWidth.Text := IntToStr (VideoGrabber.ImageOverlay_Width);
   edtImageOverlayHeight.Text := IntToStr (VideoGrabber.ImageOverlay_Height);
   
   chkImageOverlayTransparent.Checked := VideoGrabber.ImageOverlay_Transparent;
   chkImageOverlayUseTransparentColor.Checked := VideoGrabber.ImageOverlay_UseTransparentColor;
   edtImageOverlayTransparentColorValue.Text := Format ('%.6X', [VideoGrabber.ImageOverlay_TransparentColorValue]);

   chkImageOverlayAlphaBlend.Checked := VideoGrabber.ImageOverlay_AlphaBlend;
   chkImageOverlayAlphablendCoeff.Position := VideoGrabber.ImageOverlay_AlphaBlendValue;

   chkImageOverlayChromaKey.Checked := VideoGrabber.ImageOverlay_ChromaKey;
   edtChromaKeyColorValue.Text := Format ('%.6X', [VideoGrabber.ImageOverlay_ChromaKeyRGBColor]);
   edtChromaKeyLeewayPercent.Position := VideoGrabber.ImageOverlay_ChromaKeyLeewayPercent;

end;

procedure TfrmMainForm.chkImageOverlayEnabledClick(Sender: TObject);
begin
   VideoGrabber.ImageOverlayEnabled := chkImageOverlayEnabled.Checked;
end;

procedure TfrmMainForm.edtImageOverlayLeftChange(Sender: TObject);
begin
   VideoGrabber.ImageOverlay_LeftLocation := StrToIntDef (edtImageOverlayLeft.Text, 0);
end;

procedure TfrmMainForm.edtImageOverlayTopChange(Sender: TObject);
begin
   VideoGrabber.ImageOverlay_TopLocation := StrToIntDef (edtImageOverlayTop.Text, 0);
end;

procedure TfrmMainForm.edtImageOverlayWidthChange(Sender: TObject);
begin
   VideoGrabber.ImageOverlay_Width := StrToIntDef (edtImageOverlayWidth.Text, -1);
end;

procedure TfrmMainForm.edtImageOverlayHeightChange(Sender: TObject);
begin
   VideoGrabber.ImageOverlay_Height := StrToIntDef (edtImageOverlayHeight.Text, -1);
end;

procedure TfrmMainForm.chkImageOverlayTransparentClick(Sender: TObject);
begin
   VideoGrabber.ImageOverlay_Transparent := chkImageOverlayTransparent.Checked;
end;

procedure TfrmMainForm.btnImageOverlayPickupColorClick(Sender: TObject);
var
   LastClickRGBValue: DWORD;
begin
   LastClickRGBValue := VideoGrabber.GetRGBPixelAt (-1, -1);
   VideoGrabber.ImageOverlay_TransparentColorValue  := LastClickRGBValue;
   edtImageOverlayTransparentColorValue.Text := Format ('%.6X', [LastClickRGBValue]);
end;

procedure TfrmMainForm.btnImageOverlayPickupHelpClick(Sender: TObject);
begin
   ShowMessage ('while the preview is running:'+#13#10+'- load the image overlay'+#13#10+'- enable "transparent" and "use transp. color value"'+#13#10+'- in the video window, click on the video frame on the color of the overlayed image you want to be transparent'+#13#10+'- click on "pickup the transparent color" to select it as transparent color');
end;

procedure TfrmMainForm.chkImageOverlayUseTransparentColorClick(
  Sender: TObject);
begin
   VideoGrabber.ImageOverlay_UseTransparentColor := chkImageOverlayUseTransparentColor.Checked;
end;

procedure TfrmMainForm.edtImageOverlayTransparentColorValueChange(
  Sender: TObject);
begin
   VideoGrabber.ImageOverlay_TransparentColorValue := StrToIntDef ('$' + edtImageOverlayTransparentColorValue.Text, 0);
end;

procedure TfrmMainForm.chkImageOverlayAlphaBlendClick(Sender: TObject);
begin
   VideoGrabber.ImageOverlay_AlphaBlend := chkImageOverlayAlphaBlend.Checked;
end;

procedure TfrmMainForm.chkImageOverlayAlphablendCoeffChange(Sender: TObject);
begin
   VideoGrabber.ImageOverlay_AlphaBlendValue := chkImageOverlayAlphablendCoeff.Position;
end;

procedure TfrmMainForm.updImageAlphaBendClick(Sender: TObject;
  Button: TUDBtnType);
begin
   VideoGrabber.ImageOverlay_AlphaBlendValue := chkImageOverlayAlphablendCoeff.Position;
end;

procedure TfrmMainForm.chkImageOverlayChromaKeyClick(Sender: TObject);
begin
   VideoGrabber.ImageOverlay_ChromaKey := chkImageOverlayChromaKey.Checked;
end;

procedure TfrmMainForm.edtChromaKeyColorValueChange(Sender: TObject);
begin
   VideoGrabber.ImageOverlay_ChromaKeyRGBColor := StrToIntDef ('$' + edtChromaKeyColorValue.Text, 0);
end;

procedure TfrmMainForm.btnChooseChromaKeyColorClick(Sender: TObject);
var
   LastClickRGBValue: DWORD;
begin
   LastClickRGBValue := VideoGrabber.GetRGBPixelAt (-1, -1);
   VideoGrabber.ImageOverlay_ChromaKeyRGBColor := LastClickRGBValue;
   edtChromaKeyColorValue.Text := Format ('%.6X', [LastClickRGBValue]);
end;

procedure TfrmMainForm.btnImageOverlayPickupChromaHelpClick(Sender: TObject);
begin
   ShowMessage ('while the clip is playing:'+#13#10+'- in the video window, click on the video frame on the background color you want to be used as chroma key'+#13#10+'- click on the "pickup the chroma key" button to select it as chroma key'+#13#10+' - load the image overlay'+#13#10+'- enable "chroma key" then adjust the leeway percent (default = 25%)');
end;

procedure TfrmMainForm.edtChromaKeyLeewayPercentChange(Sender: TObject);
begin
   VideoGrabber.ImageOverlay_ChromaKeyLeewayPercent := edtChromaKeyLeewayPercent.Position;
end;

procedure TfrmMainForm.VideoGrabberMouseDown(Sender: TObject;
  VideoWindow: Integer; Button: TMouseButton; Shift: TShiftState; X,
  Y: Integer);
begin
   if VideoWindow <> -1 then begin // if the video is displayed
      if chkFreeHandEnabled.Checked then begin
         if FiFreeHandMouseDrawing < FreeHandMouseCoordinatesMax then begin
            FFreeHandMouseDrawing[FiFreeHandMouseDrawing].Left := x;
            FFreeHandMouseDrawing[FiFreeHandMouseDrawing].Top := y;
            FFreeHandMouseDrawing[FiFreeHandMouseDrawing].Right := 0; // Right is used as boolean to know if it is a MoveTo or a LineTo
            inc (FiFreeHandMouseDrawing);
            FFreeHandMouseDrawingEnabled := True;
            VideoGrabber.RefreshPlayerOverlays;
         end;
      end;
   end;
end;

procedure TfrmMainForm.VideoGrabberMouseMove(Sender: TObject;
  VideoWindow: Integer; Shift: TShiftState; X, Y: Integer);
begin
   if VideoWindow <> -1 then begin // if the video is displayed
      if FFreeHandMouseDrawingEnabled then begin
         if FiFreeHandMouseDrawing < FreeHandMouseCoordinatesMax then begin
            FFreeHandMouseDrawing[FiFreeHandMouseDrawing].Left := x;
            FFreeHandMouseDrawing[FiFreeHandMouseDrawing].Top := y;
            FFreeHandMouseDrawing[FiFreeHandMouseDrawing].Right := 1; // Right is used as boolean to know if it is a MoveTo or a LineTo
            inc (FiFreeHandMouseDrawing);
            VideoGrabber.RefreshPlayerOverlays;
         end;
      end;
   end;
end;

procedure TfrmMainForm.VideoGrabberMouseUp(Sender: TObject;
  VideoWindow: Integer; Button: TMouseButton; Shift: TShiftState; X,
  Y: Integer);
begin
   FFreeHandMouseDrawingEnabled := False;
   VideoGrabber.RefreshPlayerOverlays;
end;

procedure TfrmMainForm.VideoGrabberResizeVideo(Sender: TObject; SourceWidth, SourceHeight: Integer);
begin
   trkCroppingX.Min := -VideoGrabber.Cropping_Width;
   trkCroppingY.Min := -VideoGrabber.Cropping_Height;
   trkCroppingX.Max := VideoGrabber.Cropping_XMax;
   trkCroppingY.Max := VideoGrabber.Cropping_YMax;
end;

////////////////////////////////////////////////////////////////////////////////
//                           VIDEO PROCESSING TAB
////////////////////////////////////////////////////////////////////////////////

procedure TfrmMainForm.rdgVideoRotationClick(Sender: TObject);
begin
   VideoGrabber.VideoProcessing_Rotation := TVideoRotation (rdgVideoRotation.ItemIndex);
end;

procedure TfrmMainForm.edtCustomRotationAngleChange(Sender: TObject);
begin
   VideoGrabber.VideoProcessing_RotationCustomAngle := StrToFloatDef (edtCustomRotationAngle.Text, 0);
end;

procedure TfrmMainForm.updPixellizationClick(Sender: TObject;
  Button: TUDBtnType);
begin
   VideoGrabber.VideoProcessing_Pixellization := updPixellization.Position;
end;

procedure TfrmMainForm.rdgDeinterlacingClick(Sender: TObject);
begin
   VideoGrabber.VideoProcessing_Deinterlacing := TVideoDeinterlacing (rdgDeinterlacing.ItemIndex);
end;

procedure TfrmMainForm.tbrBrightnessChange(Sender: TObject);
begin
   VideoGrabber.VideoProcessing_Brightness := - tbrBrightness.Position;
end;

procedure TfrmMainForm.tbrConstrastChange(Sender: TObject);
begin
   VideoGrabber.VideoProcessing_Contrast := - tbrConstrast.Position;
end;

procedure TfrmMainForm.tbrSaturationChange(Sender: TObject);
begin
   VideoGrabber.VideoProcessing_Saturation := - tbrSaturation.Position;
end;

procedure TfrmMainForm.tbrHueChange(Sender: TObject);
begin
   VideoGrabber.VideoProcessing_Hue := tbrHue.Position;
end;

procedure TfrmMainForm.btnResetAllClick(Sender: TObject);
begin
   rdgVideoRotation.ItemIndex := 0;
   rdgDeinterlacing.ItemIndex := 0;
   rdgVideoRotation.ItemIndex := 0;
   tbrBrightness.Position := 0;
   tbrConstrast.Position := 0;
   tbrSaturation.Position := 0;
   tbrHue.Position := 0;
   chkGreyScale.Checked := False;
   chkInvertColors.Checked := False;
   chkFlipVertical.Checked := False;
   chkFlipHorizontal.Checked := False;
   updPixellization.Position := 1;
   VideoGrabber.VideoProcessing_Pixellization := 1;
end;

procedure TfrmMainForm.chkFlipVerticalClick(Sender: TObject);
begin
   VideoGrabber.VideoProcessing_FlipVertical := chkFlipVertical.Checked;
end;

procedure TfrmMainForm.chkFlipHorizontalClick(Sender: TObject);
begin
   VideoGrabber.VideoProcessing_FlipHorizontal := chkFlipHorizontal.Checked;
end;

procedure TfrmMainForm.chkGreyScaleClick(Sender: TObject);
begin
   VideoGrabber.VideoProcessing_GrayScale := chkGreyScale.Checked;
end;

procedure TfrmMainForm.chkInvertColorsClick(Sender: TObject);
begin
   VideoGrabber.VideoProcessing_InvertColors := chkInvertColors.Checked;
end;

procedure TfrmMainForm.VideoGrabberGraphBuilt(Sender: TObject);

   procedure InitVMR9Trackbar (VMR9ImageAdjustment: TVMR9ImageAdjustment; Trackbar: TTrackBar);
   var
      MinValue, MaxValue, StepSize, DefaultValue, CurrentValue: LongInt;
   begin
       Trackbar.Enabled := VideoGrabber.GetVMR9ImageAdjustmentBounds (True, vmr9_Brightness, MinValue, MaxValue, StepSize, DefaultValue, CurrentValue);
       if Trackbar.Enabled then begin
          TrackBar.Min := MinValue;
          TrackBar.Max := MaxValue;
          TrackBar.Frequency := StepSize;
          TrackBar.Position := CurrentValue;
       end;
   end;
begin
   InitVMR9Trackbar (vmr9_Brightness, tbrVMR9Brightness);
   InitVMR9Trackbar (vmr9_Contrast, tbrVMR9Contrast);
   InitVMR9Trackbar (vmr9_Saturation, tbrVMR9Saturation);
   InitVMR9Trackbar (vmr9_Hue, tbrVMR9Hue);

   tbrAudioBalance.Position := VideoGrabber.AudioBalance;
   tbrAudioVolume.Position := VideoGrabber.AudioVolume;

   tbrZoomX.Min := - (VideoGrabber.VideoWidth div 2);
   tbrZoomX.Max := VideoGrabber.VideoWidth div 2;
   tbrZoomY.Min := - (VideoGrabber.VideoHeight div 2);
   tbrZoomY.Max := VideoGrabber.VideoHeight div 2;
end;

procedure TfrmMainForm.tbrZoomChange(Sender: TObject);
begin
   VideoGrabber.ZoomCoeff := tbrZoom.Position;
end;

procedure TfrmMainForm.tbrZoomXChange(Sender: TObject);
begin
   VideoGrabber.ZoomXCenter := tbrZoomX.Position;
end;

procedure TfrmMainForm.tbrZoomYChange(Sender: TObject);
begin
   VideoGrabber.ZoomYCenter := tbrZoomY.Position;
end;

procedure TfrmMainForm.tbrVMR9BrightnessChange(Sender: TObject);
begin
   VideoGrabber.SetVMR9ImageAdjustmentValue (True, vmr9_Brightness, tbrVMR9Brightness.Position, false);
end;

procedure TfrmMainForm.tbrVMR9ContrastChange(Sender: TObject);
begin
   VideoGrabber.SetVMR9ImageAdjustmentValue (True, vmr9_Contrast, tbrVMR9Contrast.Position, vmr9FixRange.Checked);
end;

procedure TfrmMainForm.tbrVMR9SaturationChange(Sender: TObject);
begin
   VideoGrabber.SetVMR9ImageAdjustmentValue (True, vmr9_Saturation, tbrVMR9Saturation.Position, vmr9FixRange.Checked);
end;

procedure TfrmMainForm.tbrVMR9HueChange(Sender: TObject);
begin
   VideoGrabber.SetVMR9ImageAdjustmentValue (True, vmr9_Hue, tbrVMR9Hue.Position, false);
end;

procedure TfrmMainForm.vmr9FixRangeClick(Sender: TObject);
begin
   // fixes a possible problem of constrast and saturation range with some video decoders, passed to the SetVMR9ImageAdjustmentValue function below
end;

procedure TfrmMainForm.chkCroppingEnabledClick(Sender: TObject);
begin
   VideoGrabber.Cropping_Enabled := chkCroppingEnabled.Checked;
end;

procedure TfrmMainForm.chkCroppingOutboundsClick(Sender: TObject);
begin
   VideoGrabber.Cropping_Outbounds := chkCroppingOutbounds.Checked;
end;

procedure TfrmMainForm.edtCroppingWidthChange(Sender: TObject);
begin
   VideoGrabber.Cropping_Width := StrToIntDef (edtCroppingWidth.Text, 0);
end;

procedure TfrmMainForm.edtCroppingHeightChange(Sender: TObject);
begin
   VideoGrabber.Cropping_Height := StrToIntDef (edtCroppingHeight.Text, 0);
end;

procedure TfrmMainForm.trkCroppingZoomChange(Sender: TObject);
begin
   VideoGrabber.Cropping_Zoom := trkCroppingZoom.Position / 100;
end;

procedure TfrmMainForm.btnCroppingZoomResetClick(Sender: TObject);
begin
   trkCroppingZoom.Position := 100;
end;

procedure TfrmMainForm.trkCroppingYChange(Sender: TObject);
begin
   // trkCroppingX.Max and trkCroppingY.Max are set from the OnResizeVideo event
   VideoGrabber.Cropping_Y := trkCroppingY.Position;
end;

procedure TfrmMainForm.trkCroppingXChange(Sender: TObject);
begin
   // trkCroppingX.Max and trkCroppingY.Max are set from the OnResizeVideo event
   VideoGrabber.Cropping_X := trkCroppingX.Position;
end;

////////////////////////////////////////////////////////////////////////////////
//                                DISPLAY TAB
////////////////////////////////////////////////////////////////////////////////

procedure EnableOrDisableGroupBoxControls (GroupBox: TGroupBox; Value: Boolean);
var
   i: integer;
begin
   for i := 0 to GroupBox.ControlCount - 1 do begin
      GroupBox.Controls[i].Enabled := Value;
   end;
end;

procedure TfrmMainForm.RefreshDisplayOptions;
begin
   // this procedure is called each time a setting of this form is changed,
   // to show what features can be used, according to their respective states

   // NOTE: duplicating 2 times all the components of this form for the 2 windows
   // is not very efficient, this has been done only for a better readability.

   chk1stVideoWindowActive.Checked := VideoGrabber.Display_Active;
   chk1stVisible.Checked := VideoGrabber.Display_Visible;
   chk1stEmbedded.Checked          := VideoGrabber.Display_Embedded;
   chk1stFullScreen.Checked        := VideoGrabber.Display_FullScreen;
   chk1stStayOnTop.Checked         := VideoGrabber.Display_StayOnTop;
   chk1stUseVideoPort.Checked      := VideoGrabber.Display_VideoPortEnabled;
   chk1stMouseMovesWindow.Checked  := VideoGrabber.Display_MouseMovesWindow;
   chk1stAutoSize.Checked          := VideoGrabber.Display_AutoSize;
   rdg1AspectRatio.ItemIndex       := Integer (VideoGrabber.Display_AspectRatio);
   tbr1PanScan.Position            := VideoGrabber.Display_PanScanRatio;
   chk1stAlphablend.Checked        := VideoGrabber.Display_AlphaBlendEnabled;
   tbr1stAlphablend.Position       := VideoGrabber.Display_AlphaBlendValue;
   chk1stTranspColor.Checked       := VideoGrabber.Display_TransparentColorEnabled;
   edt1stTranspColor.Text          := Format ('%.6X', [VideoGrabber.Display_TransparentColorValue]);


   rdg1stDisplayedOn.ItemIndex     := VideoGrabber.Display_Monitor;

   EnableOrDisableGroupBoxControls (grbMainVideoWindow, VideoGrabber.Display_Active);

   if VideoGrabber.Display_Active then begin
      chk1stStayOnTop.Enabled         := (not VideoGrabber.Display_Embedded) or VideoGrabber.Display_FullScreen;
      rdg1stDisplayedOn.Enabled       := VideoGrabber.MonitorsCount > 1;
      chk1stMouseMovesWindow.Enabled  := not VideoGrabber.Display_Embedded;
      btnEG1stNewLocation2.Enabled    := not VideoGrabber.Display_Embedded;
      chk1stUseVideoPort.Enabled      := VideoGrabber.IsVideoPortAvailable;
      chk1stAlphablend.Enabled        := not VideoGrabber.Display_Embedded;
      chk1stTranspColor.Enabled       := not VideoGrabber.Display_Embedded;
   end;

   chk2ndVideoWindowActive.Checked := VideoGrabber.DualDisplay_Active;
   chk2ndVisible.Checked := VideoGrabber.DualDisplay_Visible;
   chk2ndEmbedded.Checked          := VideoGrabber.DualDisplay_Embedded;
   chk2ndFullScreen.Checked        := VideoGrabber.DualDisplay_FullScreen;
   chk2ndStayOnTop.Checked         := VideoGrabber.DualDisplay_StayOnTop;
   chk2ndUseVideoPort.Checked      := VideoGrabber.DualDisplay_VideoPortEnabled;
   chk2ndMouseMovesWindow.Checked  := VideoGrabber.DualDisplay_MouseMovesWindow;
   chk2ndAutoSize.Checked          := VideoGrabber.DualDisplay_AutoSize;
   rdg2AspectRatio.ItemIndex       := Integer (VideoGrabber.DualDisplay_AspectRatio);
   tbr2PanScan.Position            := VideoGrabber.DualDisplay_PanScanRatio;
   rdg2ndDisplayedOn.ItemIndex     := VideoGrabber.DualDisplay_Monitor;
   chk2ndAlphablend.Checked        := VideoGrabber.DualDisplay_AlphaBlendEnabled;
   tbr2ndAlphablend.Position       := VideoGrabber.DualDisplay_AlphaBlendValue;
   chk2ndTranspColor.Checked       := VideoGrabber.DualDisplay_TransparentColorEnabled;
   edt2ndTranspColor.Text          := Format ('%.6X', [VideoGrabber.DualDisplay_TransparentColorValue]);

   EnableOrDisableGroupBoxControls (grb2ndVideoWindow, VideoGrabber.DualDisplay_Active);

   if VideoGrabber.DualDisplay_Active then begin
      chk2ndStayOnTop.Enabled         := (not VideoGrabber.DualDisplay_Embedded) or VideoGrabber.DualDisplay_FullScreen;
      rdg2ndDisplayedOn.Enabled       := VideoGrabber.MonitorsCount > 1;
      chk2ndMouseMovesWindow.Enabled  := not VideoGrabber.DualDisplay_Embedded;
      chk2ndUseVideoPort.Enabled      := VideoGrabber.IsVideoPortAvailable;
      chk2ndAlphablend.Enabled        := not VideoGrabber.Display_Embedded;
      chk2ndTranspColor.Enabled       := not VideoGrabber.Display_Embedded;
   end;
end;

procedure TfrmMainForm.chkBlackMagicDecklinkClick(Sender: TObject);
begin
   if chkBlackMagicDecklink.Checked then begin
      VideoGrabber.VideoRendererExternal := vre_BlackMagic_Decklink;
   end
   else begin
      VideoGrabber.VideoRendererExternal := vre_None;
   end;
end;

procedure TfrmMainForm.chkVideoVisibleWhenStoppedClick(Sender: TObject);
begin
   VideoGrabber.VideoVisibleWhenStopped := chkVideoVisibleWhenStopped.Checked;
end;

procedure TfrmMainForm.chkAdjustPixelAspectRatioClick(Sender: TObject);
begin
   VideoGrabber.AdjustPixelAspectRatio := chkAdjustPixelAspectRatio.Checked;
end;

procedure TfrmMainForm.chkChangeCursorClick(Sender: TObject);
begin
   case chkChangeCursor.Checked of
      true  : VideoGrabber.VideoCursor := crCross;
      false : VideoGrabber.VideoCursor := crDefault;
   end;
end;

procedure TfrmMainForm.chkBorderClick(Sender: TObject);
begin
   if chkBorder.Checked then begin
      VideoGrabber.BorderStyle := bsSingle;
   end
   else begin
      VideoGrabber.BorderStyle := bsNone;
   end;
end;

procedure TfrmMainForm.chkTransparencyClick(Sender: TObject);
begin
   VideoGrabber.ColorKeyEnabled := chkTransparency.Checked;
   if VideoGrabber.ColorKeyEnabled then begin
      if not assigned (FTransparentForm) then begin
         Application.CreateForm (TForm, FTransparentForm);
         FTransparentForm.Width := 300;
         FTransparentForm.Height := 100;
         FTransparentForm.Position := poScreenCenter;
         FTransparentForm.FormStyle := fsStayOnTop;
         FTransparentPanel := TPanel.Create (FTransparentForm);
         FTransparentPanel.Parent := FTransparentForm;
         FTransparentPanel.BevelInner := bvNone;
         FTransparentPanel.BevelOuter := bvNone;
         FTransparentPanel.Align := alClient;
         FTransparentPanel.Caption := 'transparent window';
         FTransparentPanel.Font.Color := clRed;
         FTransparentPanel.Font.Size := 16;
      end;

      FTransparentForm.Color := clBlue;
      FTransparentPanel.Color := VideoGrabber.ColorKey;
      VideoGrabber.SetWindowTransparency (FTransparentForm.Handle, true, false, 0);
      FTransparentForm.Show;
   end;
end;

procedure TfrmMainForm.rdgVideoRendererClick(Sender: TObject);
begin
   VideoGrabber.VideoRenderer := TVideoRenderer (rdgVideoRenderer.ItemIndex);
end;

procedure TfrmMainForm.chk1stVideoWindowActiveClick(Sender: TObject);
begin
   VideoGrabber.Display_Active := chk1stVideoWindowActive.Checked;
   RefreshDisplayOptions;
end;

procedure TfrmMainForm.chk1stVisibleClick(Sender: TObject);
begin
   VideoGrabber.Display_Visible := chk1stVisible.Checked;
   RefreshDisplayOptions;
end;

procedure TfrmMainForm.chk1stEmbeddedClick(Sender: TObject);
begin
   VideoGrabber.Display_Embedded := chk1stEmbedded.Checked;
   RefreshDisplayOptions;
end;

procedure TfrmMainForm.chk1stAutoSizeClick(Sender: TObject);
begin
   VideoGrabber.Display_AutoSize := chk1stAutoSize.Checked;
   RefreshDisplayOptions;
end;

procedure TfrmMainForm.chk1stFullScreenClick(Sender: TObject);
begin
   VideoGrabber.Display_FullScreen := chk1stFullScreen.Checked;
   RefreshDisplayOptions;
end;

procedure TfrmMainForm.chk1stStayOnTopClick(Sender: TObject);
begin
   VideoGrabber.Display_StayOnTop := chk1stStayOnTop.Checked;
   RefreshDisplayOptions;
end;

procedure TfrmMainForm.chk1stUseVideoPortClick(Sender: TObject);
begin
   VideoGrabber.Display_VideoPortEnabled := chk1stUseVideoPort.Checked;
   RefreshDisplayOptions;
end;

procedure TfrmMainForm.rdg1stDisplayedOnClick(Sender: TObject);
begin
   VideoGrabber.Display_Monitor := rdg1stDisplayedOn.ItemIndex; // 0 or 1
   RefreshDisplayOptions;
end;

procedure TfrmMainForm.btnEG1stNewLocation2Click(Sender: TObject);
begin
   VideoGrabber.Display_AutoSize := False; // we will specify the size below
   VideoGrabber.Display_Embedded := False; // detach from component
   VideoGrabber.Display_SetLocation (20, 20, 640, 480); // Display_AutoSize=false, we can specify a size
   RefreshDisplayOptions;
end;

procedure TfrmMainForm.chk1stMouseMovesWindowClick(Sender: TObject);
begin
   VideoGrabber.Display_MouseMovesWindow := chk1stMouseMovesWindow.Checked;
   RefreshDisplayOptions;
end;

procedure TfrmMainForm.rdg1AspectRatioClick(Sender: TObject);
begin
   VideoGrabber.Display_AspectRatio := TAspectRatio (rdg1AspectRatio.ItemIndex);
end;

procedure TfrmMainForm.tbr2PanScanChange(Sender: TObject);
begin
   VideoGrabber.DualDisplay_PanScanRatio := tbr2PanScan.Position;
end;

procedure TfrmMainForm.tbr1PanScanChange(Sender: TObject);
begin
   VideoGrabber.Display_PanScanRatio := tbr1PanScan.Position;
end;

procedure TfrmMainForm.btnTestPanScanClick(Sender: TObject);
begin
   rdg1AspectRatio.ItemIndex := integer (ar_PanScan);
   VideoGrabber.Display_AspectRatio := ar_PanScan;
   VideoGrabber.Display_Embedded := True;
   VideoGrabber.Display_AutoSize := False;
   VideoGrabber.Width := 600;
   VideoGrabber.Height := VideoGrabber.Width * 9 div 16;
end;

procedure TfrmMainForm.chk1stAlphablendClick(Sender: TObject);
begin
   VideoGrabber.Display_AlphaBlendEnabled := chk1stAlphablend.Checked;
end;

procedure TfrmMainForm.tbr1stAlphablendChange(Sender: TObject);
begin
   VideoGrabber.Display_AlphaBlendValue := tbr1stAlphablend.Position;
end;

procedure TfrmMainForm.chk1stTranspColorClick(Sender: TObject);
begin
   VideoGrabber.Display_TransparentColorEnabled := chk1stTranspColor.Checked;
end;

procedure TfrmMainForm.edt1sttranspColorChange(Sender: TObject);
begin
   VideoGrabber.Display_TransparentColorValue := StrToIntDef ('$' + edt1stTranspColor.Text, 0);
end;

procedure TfrmMainForm.chk2ndAlphaBlendClick(Sender: TObject);
begin
   VideoGrabber.DualDisplay_AlphaBlendEnabled := chk2ndAlphablend.Checked;
end;

procedure TfrmMainForm.tbr2ndAlphaBlendChange(Sender: TObject);
begin
   VideoGrabber.DualDisplay_AlphaBlendValue := tbr2ndAlphablend.Position;
end;

procedure TfrmMainForm.chk2ndTranspColorClick(Sender: TObject);
begin
   VideoGrabber.DualDisplay_TransparentColorEnabled := chk2ndTranspColor.Checked;
end;

procedure TfrmMainForm.edt2ndTranspColorChange(Sender: TObject);
begin
   VideoGrabber.DualDisplay_TransparentColorValue := StrToIntDef ('$' + edt2ndTranspColor.Text, 0);
end;

procedure TfrmMainForm.chk2ndVideoWindowActiveClick(Sender: TObject);
begin
   VideoGrabber.DualDisplay_Active := chk2ndVideoWindowActive.Checked;
   RefreshDisplayOptions;
end;

procedure TfrmMainForm.chk2ndEmbeddedClick(Sender: TObject);
begin
   VideoGrabber.DualDisplay_Embedded := chk2ndEmbedded.Checked;
   RefreshDisplayOptions;
end;

procedure TfrmMainForm.chk2ndVisibleClick(Sender: TObject);
begin
   VideoGrabber.DualDisplay_Visible := chk2ndVisible.Checked;
   RefreshDisplayOptions;
end;

procedure TfrmMainForm.chk2ndFullScreenClick(Sender: TObject);
begin
   VideoGrabber.DualDisplay_FullScreen := chk2ndFullScreen.Checked;
   RefreshDisplayOptions;
end;

procedure TfrmMainForm.chk2ndAutoSizeClick(Sender: TObject);
begin
   VideoGrabber.DualDisplay_AutoSize := chk2ndAutoSize.Checked;
   RefreshDisplayOptions;
end;

procedure TfrmMainForm.chk2ndStayOnTopClick(Sender: TObject);
begin
   VideoGrabber.DualDisplay_StayOnTop := chk2ndStayOnTop.Checked;
   RefreshDisplayOptions;
end;

procedure TfrmMainForm.chk2ndUseVideoPortClick(Sender: TObject);
begin
   VideoGrabber.DualDisplay_VideoPortEnabled := chk2ndUseVideoPort.Checked;
   RefreshDisplayOptions;
end;

procedure TfrmMainForm.chk2ndMouseMovesWindowClick(Sender: TObject);
begin
   VideoGrabber.DualDisplay_MouseMovesWindow := chk2ndMouseMovesWindow.Checked;
   RefreshDisplayOptions;
end;

procedure TfrmMainForm.rdg2AspectRatioClick(Sender: TObject);
begin
   VideoGrabber.DualDisplay_AspectRatio := TAspectRatio (rdg2AspectRatio.ItemIndex);
end;

procedure TfrmMainForm.rdg2ndDisplayedOnClick(Sender: TObject);
begin
   VideoGrabber.DualDisplay_Monitor := rdg2ndDisplayedOn.ItemIndex; // 0 or 1
   RefreshDisplayOptions;
end;

procedure TfrmMainForm.btnEG2ndNewLocation2Click(Sender: TObject);
begin
   VideoGrabber.DualDisplay_AutoSize := False; // we will specify the size below
   VideoGrabber.DualDisplay_Embedded := False; // detach from component
   VideoGrabber.DualDisplay_SetLocation (30, 30, 640, 480); // DualDisplay_AutoSize=false, we can specify a size
   RefreshDisplayOptions;
end;

////////////////////////////////////////////////////////////////////////////////
//                            MOTION DETECTOR TAB
////////////////////////////////////////////////////////////////////////////////

procedure TfrmMainForm.chkMotionDetectionEnabledClick(Sender: TObject);
begin
   videograbber.MotionDetector_Enabled := chkMotionDetectionEnabled.Checked;
end;

procedure TfrmMainForm.chkCompareRedClick(Sender: TObject);
begin
   VideoGrabber.MotionDetector_CompareRed := chkCompareRed.Checked;
end;

procedure TfrmMainForm.chkCompareGreenClick(Sender: TObject);
begin
   VideoGrabber.MotionDetector_CompareGreen := chkCompareGreen.Checked;
end;

procedure TfrmMainForm.chkCompareBlueClick(Sender: TObject);
begin
   VideoGrabber.MotionDetector_CompareBlue := chkCompareBlue.Checked;
end;

procedure TfrmMainForm.chk_GreyScaleClick(Sender: TObject);
begin
   VideoGrabber.MotionDetector_GreyScale := chk_GreyScale.Checked;
end;

procedure TfrmMainForm.chkReduceVideoNoiseClick(Sender: TObject);
begin
   VideoGrabber.MotionDetector_ReduceVideoNoise := chkReduceVideoNoise.Checked;
end;

procedure TfrmMainForm.edtGridChange(Sender: TObject);
begin
   VideoGrabber.MotionDetector_Grid := edtGrid.Text;
   if VideoGrabber.MotionDetector_IsGridValid then begin
      shpGridValid.Brush.Color := clLime;
      lblGridValid.Caption := 'valid';
   end
   else begin
      shpGridValid.Brush.Color := clRed;
      lblGridValid.Caption := 'invalid';
   end;
   mmoSensitivityGrid.Text := VideoGrabber.MotionDetector_Get2DTextGrid;
end;

procedure TfrmMainForm.updGlobalGridSensitivityClick(Sender: TObject;
  Button: TUDBtnType);
begin
   if Button = btNext then begin
      VideoGrabber.MotionDetector_GloballyIncOrDecSensitivity (1);
   end
   else begin
      VideoGrabber.MotionDetector_GloballyIncOrDecSensitivity (-1);
   end;
   edtGrid.Text := VideoGrabber.MotionDetector_Grid;
end;

procedure TfrmMainForm.btnApplyGridSizeClick(Sender: TObject);
begin
   VideoGrabber.MotionDetector_SetGridSize (StrToInt (edtGridColCount.Text), StrToInt (edtGridRowCount.Text));
   edtGrid.Text := VideoGrabber.MotionDetector_Grid;
   mmoSensitivityGrid.Text := VideoGrabber.MotionDetector_Get2DTextGrid;
end;

procedure TfrmMainForm.btnSetCellsSensitivityClick(Sender: TObject);
begin
   VideoGrabber.MotionDetector_SetCellSensitivity (StrToInt (edtXCell.Text), StrToInt (edtYCell.Text), StrToInt (edtCellSensitivity.Text));
   edtGrid.Text := VideoGrabber.MotionDetector_Grid;
   mmoSensitivityGrid.Text := VideoGrabber.MotionDetector_Get2DTextGrid;
end;

procedure TfrmMainForm.btnShowGridDialogClick(Sender: TObject);
begin
   if (VideoGrabber.CurrentState <> cs_Preview) and (VideoGrabber.CurrentState <> cs_Recording) then begin
      ShowMessage ('you should start preview or recording to see the video frame under the grid');
   end
   else if not VideoGrabber.MotionDetector_Enabled then begin
      ShowMessage ('you should enable the motion detector first (MotionDetector_Enabled = true) to see the video frame under the grid');
   end;
   VideoGrabber.MotionDetector_ShowGridDialog;
   edtGrid.Text := VideoGrabber.MotionDetector_Grid;
   mmoSensitivityGrid.Text := VideoGrabber.MotionDetector_Get2DTextGrid;
end;

procedure TfrmMainForm.chkTriggeredClick(Sender: TObject);
begin
   VideoGrabber.MotionDetector_Triggered := chkTriggered.Checked;
end;

procedure TfrmMainForm.btnTriggerNowClick(Sender: TObject);
begin
   VideoGrabber.MotionDetector_TriggerNow;
end;

procedure TfrmMainForm.VideoGrabberMotionDetected(Sender: TObject;
  GlobalMotionRatio: Double; MaxMotionCellX, MaxMotionCellY: Integer;
  FrameBitmap: TBitmap; FrameNumber: Cardinal; FrameTime: Int64;
  FrameId: Integer; var CaptureFrame: Boolean);
var
   MaxMotionXLocation, MaxMotionYLocation: LongInt;
   MotionBitmap: TBitmap;
begin
   shpMotionDetected.Brush.Color := clLime;
   edtMotionRatio.Text :=   FormatFloat ('0.000', VideoGrabber.MotionDetector_GlobalMotionRatio);

   edtMaxMotionXY.Text := 'X:' + IntToStr (MaxMotionCellX) + ' ; Y:' + IntToStr (MaxMotionCellY);
   if VideoGrabber.MotionDetector_GetCellLocation (MaxMotionCellX, MaxMotionCellY, MaxMotionXLocation, MaxMotionYLocation) then begin
      edtMaxMotionCoord.Text := 'x: ' + IntToStr (MaxMotionXLocation) + ' ; y: ' + IntToStr (MaxMotionYLocation);
   end;

   mmoMotionGrid.Text := VideoGrabber.MotionDetector_Get2DTextMotion;

   MotionBitmap := VideoGrabber.GetLastFrameAsTBitmap (0, false, 0, 0, 0, 0, imgMotionDetected.Width, imgMotionDetected.Height, 0);
   if assigned (MotionBitmap) then begin
      imgMotionDetected.Picture.Assign (MotionBitmap);
      MotionBitmap.Free;
   end;
end;

procedure TfrmMainForm.VideoGrabberMotionNotDetected(Sender: TObject;
  FrameBitmap: TBitmap; FrameNumber: Cardinal; FrameTime: Int64;
  FrameId: Integer; var CaptureFrame: Boolean);
begin
   shpMotionDetected.Brush.Color := clGreen;
   edtMotionRatio.Text := '';
   mmoMotionGrid.Text := VideoGrabber.MotionDetector_Get2DTextMotion;
end;

////////////////////////////////////////////////////////////////////////////////
//                         "CLIP REENCODING" TAB
////////////////////////////////////////////////////////////////////////////////

procedure TfrmMainForm.btnSourceVideoClipClick(Sender: TObject);
var
   OpenDlg: TOpenDialog;
begin
   edtDestinationVideoClip.Text := '';
   OpenDlg := TOpenDialog.Create (nil);
   OpenDlg.Filter := OPEN_MEDIA_FILES;
   if OpenDlg.Execute then begin
      edtSourceVideoClip.Text := OpenDlg.FileName;
   end;
   OpenDlg.Free;
end;

procedure TfrmMainForm.btnDurationClick(Sender: TObject);
var
   Duration: int64;
   FrameCount: int64;
begin
   if VideoGrabber.AVIDuration (edtSourceVideoClip.Text, Duration, FrameCount) then begin
      edtReencDuration.Text := IntToStr (Duration);
      edtReencFrameCount.Text := IntToStr (FrameCount);
   end;
end;

procedure TfrmMainForm.btnStartReencodingClick(Sender: TObject);
begin
   VideoGrabber.Reencoding_SourceVideoClip := edtSourceVideoClip.Text;
   VideoGrabber.Reencoding_NewVideoClip := edtDestinationVideoClip.Text;

   VideoGrabber.Reencoding_WMVOutput := chkWMVOutput.Checked;
   VideoGrabber.Reencoding_IncludeVideoStream := chkIncludeVideoStream.Checked;
   VideoGrabber.Reencoding_IncludeAudioStream := chkIncludeAudioStream.Checked;
   VideoGrabber.Reencoding_UseFrameGrabber := chkUseFrameGrabber.Checked;
   VideoGrabber.Reencoding_UseVideoCompressor := chkUseCurrentVideoCompressor.Checked;
   VideoGrabber.Reencoding_UseAudioCompressor := chkUseCurrentAudioCompressor.Checked;
   VideoGrabber.Reencoding_Method := TRecordingMethod (rdgReencodingMethod.ItemIndex);

   // if a frame number is specified (<> -1), it is mandatory, so the time is ignored
   VideoGrabber.Reencoding_StartTime  := StrToInt64Def (edtReencStartTime.Text, -1);
   VideoGrabber.Reencoding_StartFrame  := StrToInt64Def (edtReencStartFrame.Text, -1);
   VideoGrabber.Reencoding_StopTime   := StrToInt64Def (edtReencStopTime.Text, -1);
   VideoGrabber.Reencoding_StopFrame   := StrToInt64Def (edtReencStopFrame.Text, -1);

   VideoGrabber.StartReencoding;
end;

procedure TfrmMainForm.btnStopReencodingClick(Sender: TObject);
begin
   VideoGrabber.StopReencoding;
end;

////////////////////////////////////////////////////////////////////////////////
//                                    MISC.
////////////////////////////////////////////////////////////////////////////////

procedure TfrmMainForm.edtStoragePathChange(Sender: TObject);
begin
   VideoGrabber.StoragePath := edtStoragePath.Text;
end;

procedure TfrmMainForm.ShowFormAboveVideo(Form: TForm);
begin
   if not assigned (Form) then Exit;
   Form.Top := Top + VideoGrabber.Top - Form.Height;
   Form.Left := Left + VideoGrabber.Left - Form.Width;
   if Form.Top < 0 then begin
      Form.Top := 0;
   end;
   if Form.Left < 0 then begin
      Form.Left := 0;
   end;
   Form.Show;
end;

procedure TfrmMainForm.RefreshDeviceControls;
var
   CanUseCompressors: Boolean;
   CanUseMultiplexer: Boolean;
begin
   if csDestroying in ComponentState then Exit; // do nothing if the app terminates

   // let's refresh the controls according to the TVideoGrabber current video device selected

   AssignListToComboBox (cboVideoFormats, VideoGrabber.VideoFormats, VideoGrabber.VideoFormat);
   AssignListToComboBox (cboVideoSizes, VideoGrabber.VideoSizes, VideoGrabber.VideoSize);
   AssignListToComboBox (cboVideoSubtypes, VideoGrabber.VideoSubtypes, VideoGrabber.VideoSubtype);
   AssignListToComboBox (cboVideoInputs, VideoGrabber.VideoInputs, integer (VideoGrabber.VideoInput));
   AssignListToComboBox (cboAnalogVideoStandard, VideoGrabber.AnalogVideoStandards, integer (VideoGrabber.AnalogVideoStandard));

   btnPauseRecording.Enabled := VideoGrabber.RecordingCanPause;
   btnResumeRecording.Enabled := VideoGrabber.RecordingCanPause;

   btnStreamDialog.Enabled := not VideoGrabber.IsDigitalVideoIn;
   btnCameraControlDialog.Enabled := VideoGrabber.IsCameraControlAvailable;
   btnVideoQualityDialog.Enabled := VideoGrabber.IsVideoQualityAvailable;
   btnVideoControlDialog.Enabled := VideoGrabber.IsVideoControlAvailable;

   cboAnalogVideoStandard.Enabled := VideoGrabber.IsAnalogVideoDecoderAvailable;
   cboVideoInputs.Enabled := VideoGrabber.IsVideoCrossbarAvailable;

   edtFrameRate.Text := FormatFloat ('0.00', VideoGrabber.FrameRate);

   rdgTunerMode.ItemIndex := Integer (VideoGrabber.TunerMode);
   rdgTunerInputType.ItemIndex := Integer (VideoGrabber.TVTunerInputType);
   edtCountryCode.Text := IntToStr (VideoGrabber.TVCountryCode);
   edtTVChannel.Text := IntToStr (VideoGrabber.TVChannel);
   LblTVTunerAvailable.Visible := not VideoGrabber.IsTVTunerAvailable;

   lblFrameOverlayRequiresFrameGrabber.Visible := VideoGrabber.FrameGrabber = fg_Disabled;
   lblMotionDetectorRequiresFrameGrabber.Visible := VideoGrabber.FrameGrabber = fg_Disabled;

   if assigned (frmVideoControl) then begin
      frmVideoControl.RefreshControls;
   end;

   CanUseCompressors := not (VideoGrabber.RecordingMethod in [rm_ASF, rm_SendToDV]);

   CanUseMultiplexer := CanUseCompressors and (VideoGrabber.RecordingMethod <> rm_AVI);

   rdgCompressMode.Enabled := CanUseCompressors;
   rdgCompressType.Enabled := CanUseCompressors;
   cboVideoCompressors.Enabled := CanUseCompressors;
   btnVideoCompressorSettings.Enabled := CanUseCompressors;
   cboAudioCompressors.Enabled := CanUseCompressors;
   btnAudioCompressorSettings.Enabled := CanUseCompressors;
   chkPreallocFile.Enabled := CanUseCompressors;
   cboMultiplexers.Enabled := CanUseMultiplexer;
end;

procedure TfrmMainForm.SendVCRCommand (Sender: TObject);
begin
   // THE "TAG" PROPERTY OF EACH MENU ITEM IS USED TO SELECT THE CORRESPONDING TVCRCommand value
   if VideoGrabber.SendDVCommand (TDVCommand (TMenuItem (Sender).Tag)) then begin
      mmoLog.Lines.Add ('DV command sent...');
   end
   else begin
      mmoLog.Lines.Add ('DV command failed.');
   end;
end;

procedure TfrmMainForm.Resetvideocapturedevicesettings1Click(
  Sender: TObject);
begin
   VideoGrabber.ResetVideoDeviceSettings;
end;

procedure TfrmMainForm.VideoGrabberDVCommandCompleted(Sender: TObject;
  NewStateValue: Integer; NewStateLabel: String);
begin
   mmoLog.Lines.Add ('camcorder state: ' + NewStateLabel);
end;

procedure TfrmMainForm.VideoGrabberDVDiscontinuity(Sender: TObject;
  var DeliverNewFrame: Boolean);
begin
   // SAMPLE CODE 1: creates a new file during recording when a discontinuity in the DV date/time is detected (uncommend the 2 lines below)
   // DeliverNewFrame := false;
   // VideoGrabber.RecordToNewFileNow;

   // SAMPLE CODE 2: stops the recording when a discontinuity in the DV date/time is detected (uncommend the 2 lines below)
   // DeliverNewFrame := false;
   // VideoGrabber.StopRecording;

   // Important: from this event you should not perform any actions with the potential to block, such as holding
   //   a critical section or waiting on another thread. Also, do not call any GDI or USER32.DLL APIs.
end;

procedure TfrmMainForm.VideoGrabberLog(Sender: TObject; LogType: TLogType;
  Severity, InfoMsg: String);
begin
   mmoLog.Lines.Add ('[' + Severity + '] ' + InfoMsg);
end;

procedure TfrmMainForm.VideoGrabberInactive(Sender: TObject);
begin
   mmoLog.Lines.Add ('(done.)');
end;

procedure TfrmMainForm.mnuAboutClick(Sender: TObject);
begin
   VideoGrabber.About;
end;

procedure TfrmMainForm.VideoGrabberResize(Sender: TObject);
var
   NewWidth: Integer;
   NewHeight: Integer;
begin
   NewWidth := VideoGrabber.Left + VideoGrabber.Width + 30;
   NewHeight := VideoGrabber.Top + VideoGrabber.Height + 60;
   if NewWidth < FStartupWidth then begin
      NewWidth := FStartupWidth;
   end;
   if NewHeight < FStartupHeight then begin
      NewHeight := FStartupHeight;
   end;
   if (NewWidth >= Width) and (NewHeight >= Height) then begin
      Width := NewWidth;
      Height := NewHeight;
   end;
end;

procedure TfrmMainForm.VideoGrabberDeviceLost(Sender: TObject);
begin
   mmoLog.Lines.Add ('DEVICE LOST!');
   AssignListToComboBox (cboVideoDevices, VideoGrabber.VideoDevices, VideoGrabber.VideoDevice);
   AssignListToComboBox (cboAudioDevices, VideoGrabber.AudioDevices, VideoGrabber.AudioDevice);
end;

procedure TfrmMainForm.VideoGrabberDiskFull(Sender: TObject);
begin
   mmoLog.Lines.Add ('DISK FULL!');
end;

procedure TfrmMainForm.VideoGrabberReinitializing(Sender: TObject);
begin
   mmoLog.Clear;
   FOldVideoSignalState := False;
end;

procedure TfrmMainForm.VideoGrabberDeviceArrivalOrRemoval(Sender: TObject;
  IsDeviceArrival, IsVideoDevice: Boolean; DeviceName: String;
  DeviceIndex: Integer);
var
   AudioOrVideoDevice: string;
begin
   if IsVideoDevice then begin
      AudioOrVideoDevice:= 'video device ';
   end
   else begin
      AudioOrVideoDevice:= 'audio device ';
   end;
   if IsDeviceArrival then begin
      mmoLog.Lines.Add (AudioOrVideoDevice + 'arrival:');
   end
   else begin
      mmoLog.Lines.Add (AudioOrVideoDevice + 'removal:');
   end;
   mmoLog.Lines.Add (DeviceName);
   if IsVideoDevice then begin
      AssignListToComboBox (cboVideoDevices, VideoGrabber.VideoDevices, VideoGrabber.VideoDevice);
   end
   else begin
      AssignListToComboBox (cboAudioDevices, VideoGrabber.AudioDevices, VideoGrabber.AudioDevice);
   end;
end;

procedure TfrmMainForm.VideoGrabberVideoFromBitmapsNextFrameNeeded(
  Sender: TObject; FirstSample: Boolean);
var
   FileAvailable: Boolean;
   EndOfData: Boolean;
   BMPorJPEGFilePath: string;
begin
   FileAvailable := False;
   EndOfData := false;

   if FirstSample or (not FSearchBmpFilesOpened) then begin // let's start from the first file

      if FSearchBmpFilesOpened then begin
         FindClose (FSearchBmpFiles);
         FSearchBmpFilesOpened := False;
      end;

      if Length(VideoGrabber.StoragePath) > 0 then begin // let's add a trailing slash if required
         if (VideoGrabber.StoragePath[Length(VideoGrabber.StoragePath)]) = '\' then begin
            FSearchBmpPath := VideoGrabber.StoragePath;
         end
         else begin
            FSearchBmpPath := VideoGrabber.StoragePath + '\';
         end;
      end
      else begin
         FSearchBmpPath := '.\';
      end;

      if FindFirst (FSearchBmpPath + '*.bmp', faAnyFile, FSearchBmpFiles) = 0 then begin
         FileAvailable := True;
         FSearchBmpFilesOpened := True;
      end
      else if FindFirst (FSearchBmpPath + '*.jpg', faAnyFile, FSearchBmpFiles) = 0 then begin
         FileAvailable := True;
         FSearchBmpFilesOpened := True;
      end
      else begin
         mmoLog.Lines.Add ('');
         mmoLog.Lines.Add ('no bitmap files found in the StoragePath directory! Capture frames to BMP files first by using the frame grabber.');
         EndOfData := True;
      end;
   end
   else begin
      if FindNext (FSearchBmpFiles) = 0 then begin
         FileAvailable := True;
      end
      else begin
         FindClose (FSearchBmpFiles);
         FSearchBmpFilesOpened := False;
         EndOfData := True;
      end;
   end;

   if FileAvailable then begin
      // we can pass a bitmap handle to "BitmapHandle" or a BMP or JPEG file to BMPorJPEGFile
      // in this case we pass a BMP or JPEG file, so we set BitmapHandle = 0
      BMPorJPEGFilePath := FSearchBmpPath + FSearchBmpFiles.Name;

      VideoGrabber.SendImageToVideoFromBitmaps (BMPorJPEGFilePath, 0, false, EndOfData);
   end;
end;

procedure TfrmMainForm.btnOpenAtFramesClick(Sender: TObject);
begin
   // -2 is just used to check if the numeric value is valid
   if (StrToIntDef (edtStartFrame.Text, -2) <> -2) and (StrToIntDef (edtStopFrame.Text, -2) <> -2) then begin
      VideoGrabber.PlayerFileName := edtPlayerClip.Text;
      VideoGrabber.OpenPlayerAtFramePositions (StrToInt (edtStartFrame.Text), StrToInt (edtStopFrame.Text), chkKeepBounds.Checked, chkReopen.Checked);
   end
   else begin
      ShowMessage ('invalid start frame or stop frame');
   end;
end;

procedure TfrmMainForm.btnOpenAtTimesClick(Sender: TObject);
begin
   // -2 is just used to check if the numeric value is valid
   if (StrToIntDef (edtStartTime.Text, -2) <> -2) and (StrToIntDef (edtStopTime.Text, -2) <> -2) then begin
      VideoGrabber.PlayerFileName := edtPlayerClip.Text;
      VideoGrabber.OpenPlayerAtTimePositions (StrToInt (edtStartTime.Text), StrToInt (edtStopTime.Text), chkKeepBounds.Checked, chkReopen.Checked);
   end
   else begin
      ShowMessage ('invalid start Time or stop Time');
   end;
end;

procedure TfrmMainForm.btnOpenDVDClick(Sender: TObject);
begin
   if edtPlayerClip.Text = 'Choose a clip...' then begin
      VideoGrabber.PlayerFileName := ''; // this will use the default DVD if available
   end
   else begin
      VideoGrabber.PlayerFileName := edtPlayerClip.Text;
   end;
   if VideoGrabber.OpenDVD then begin
      edtPlayerClip.Text := VideoGrabber.PlayerFileName;
   end;
end;

procedure TfrmMainForm.btnCurrentDVDInfoClick(Sender: TObject);
var
   i, NumberOfTitles: LongInt;
begin
   mmolog.lines.Add ('');
   mmolog.lines.Add ('Total DVD duration: ' + FormatFloat ('0.00', VideoGrabber.DvdInfo (edtPlayerClip.Text, dvd_TotalDuration, 0)));
   NumberOfTitles := Round (videograbber.Dvdinfo (edtPlayerClip.Text, dvd_NumberOfTitles, 0));
   mmolog.lines.Add ('number of titles: ' + IntToStr (NumberOfTitles));
   for i := 1 to NumberOfTitles do begin
      mmolog.lines.Add ('TITLE: ' + inttostr (i));
      mmolog.lines.Add ('duration in seconds : ' + FormatFloat ('0.00', VideoGrabber.DvdInfo (edtPlayerClip.Text, dvd_TitleDuration, i)));
      mmolog.lines.Add ('frame count: ' + IntToStr (Round (VideoGrabber.DvdInfo (edtPlayerClip.Text, dvd_TitleFrameCount, i))));
      mmolog.lines.Add ('frame rate: ' + IntToStr (Round (VideoGrabber.DvdInfo (edtPlayerClip.Text, dvd_TitleFrameRate, i))));
      mmolog.lines.Add ('video resolution X: ' + IntToStr (Round (VideoGrabber.DvdInfo (edtPlayerClip.Text, dvd_SourceResolutionX, i))));
      mmolog.lines.Add ('video resolution Y: ' + IntToStr (Round (VideoGrabber.DvdInfo (edtPlayerClip.Text, dvd_SourceResolutionY, i))));
      mmolog.lines.Add ('');
   end;
end;

// IP Cameras

procedure TfrmMainForm.tbsIPCamerasShow(Sender: TObject);
begin
   lblChooseIPCamera.Visible := VideoGrabber.VideoSource <> vs_IPCamera;
end;

procedure TfrmMainForm.btnCurrentIPCameraURLClick(Sender: TObject);
begin
   ShellExecute(0, 'open', PChar('http://www.datastead.com/demo/IPCam.htm'), '', '', SW_SHOW);
end;

procedure TfrmMainForm.edtIPCameraURLChange(Sender: TObject);
begin
   VideoGrabber.IPCameraURL := edtIPCameraURL.Text;
end;

procedure TfrmMainForm.edtIPCamUserNameChange(Sender: TObject);
begin
   VideoGrabber.SetAuthentication (at_IPCamera, edtIPCamUserName.Text, edtIPCamPassword.Text);
end;

procedure TfrmMainForm.edtIPCamPasswordChange(Sender: TObject);
begin
   VideoGrabber.SetAuthentication (at_IPCamera, edtIPCamUserName.Text, edtIPCamPassword.Text);
end;

procedure TfrmMainForm.edtIPCamConnectionTimeoutChange(Sender: TObject);
begin
   VideoGrabber.SetIPCameraSetting (ips_ConnectionTimeout, StrToIntDef (edtIPCamConnectionTimeout.Text, 10000));
end;

procedure TfrmMainForm.edtIPCamReceiveTimeoutChange(Sender: TObject);
begin
   VideoGrabber.SetIPCameraSetting (ips_ReceiveTimeout, StrToIntDef (edtIPCamReceiveTimeout.Text, 5000));
end;

procedure TfrmMainForm.btnIPCamStartPreviewClick(Sender: TObject);
begin
   if VideoGrabber.VideoSource <> vs_IPCamera then begin
      if VideoGrabber.CurrentState = cs_Down then begin
         VideoGrabber.VideoSource := vs_IPCamera;
         mmoLog.Lines.Add ('VideoSource set to vs_IPCamera');
      end
      else begin
         ShowMessage ('stop the current action, then select "IP camera" in the "Video sources" list of the "Video Source" tab');
      end;
   end;
   VideoGrabber.StartPreview;
end;

procedure TfrmMainForm.btnIPCamSendCommandClick(Sender: TObject);
begin
   if VideoGrabber.SendIPCameraCommand (edtIPCamCommand.Text) then begin
      mmoLog.Lines.Add ('IP camera command successfully sent.');
   end
   else begin
      mmoLog.Lines.Add ('failed to send the IP camera command (wrong IP address, command not supported or authentication failed)');
   end;
end;

procedure TfrmMainForm.FormDestroy(Sender: TObject);
begin
   if FSearchBmpFilesOpened then begin
      FindClose (FSearchBmpFiles);
      FSearchBmpFilesOpened := False;
   end;
end;

procedure TfrmMainForm.mmoLogKeyUp(Sender: TObject; var Key: Word;
  Shift: TShiftState);
begin
   VideoGrabber.Version := mmoLog.Text;
end;

procedure TfrmMainForm.mnuExitClick(Sender: TObject);
begin
   Close;
end;




end.


