// dlg_MainForm.cpp : implementation file
//

#include "stdafx.h"
#include "MainDemo.h"
#include "MainForm.h"

#include "Audio.h"
#include "Display.h"
#include "FrameGrabber.h"
#include "MotionDetection.h"
#include "NetworkStreaming.h"
#include "Overlays.h"	
#include "Player.h"
#include "Recording.h"
#include "Reencoding.h"
#include "TVTuner.h"
#include "VideoProcessing.h"
#include "VideoSource.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

	bool CanUnload;

    const int FreeHandMouseMax = 1000;
    bool FreeHandMouseDrawingEnabled;

	TFileSearch VideoFromBitmapSearch;

	RECT FreeHandMouseDrawing[FreeHandMouseMax+1];

	long StartupWidth, StartupHeight;

/////////////////////////////////////////////////////////////////////////////
// CMainForm dialog

CAudio				*dlg_Audio;
CDisplay			*dlg_Display;
CFrameGrabber		*dlg_FrameGrabber;
CMotionDetection	*dlg_MotionDetection;
CNetworkStreaming	*dlg_NetworkStreaming;
COverlays			*dlg_Overlays;
CPlayer				*dlg_Player;
CRecording			*dlg_Recording;
CReencoding			*dlg_Reencoding;
CTVTuner			*Dlg_TVTuner;
CVideoProcessing	*dlg_VideoProcessing;
CVideoSource		*dlg_VideoSource;

CMainForm::CMainForm(CWnd* pParent /*=NULL*/)
	: CDialog(CMainForm::IDD, pParent)
{
	//{{AFX_DATA_INIT(CMainForm)
		// NOTE: the ClassWizard will add member initialization here
	//}}AFX_DATA_INIT
}

void CMainForm::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CMainForm)
	DDX_Control(pDX, tbrPlayer, m_tbrPlayer);
	DDX_Control(pDX, mmoLog, m_mmoLog);
	DDX_Control(pDX, edtDVDateTime, m_edtDVDateTime);
	DDX_Control(pDX, edtFrameCount, m_edtFrameCount);
	DDX_Control(pDX, edtStoragePath, m_edtStoragePath);
	DDX_Control(pDX, btnFormAudio, m_btnFormAudio);
	DDX_Control(pDX, btnFormRecording, m_btnFormRecording);
	DDX_Control(pDX, btnFormNetworkStreaming, m_btnFormNetworkStreaming);
	DDX_Control(pDX, btnFormPlayer, m_btnFormPlayer);
	DDX_Control(pDX, btnFormFrameGrabber, m_btnFormFrameGrabber);
	DDX_Control(pDX, btnFormMotionDetection, m_btnFormMotionDetection);
	DDX_Control(pDX, btnFormOverlays, m_btnFormOverlays);
	DDX_Control(pDX, btnFormVideoProcessing, m_btnFormVideoProcessing);
	DDX_Control(pDX, btnFormDisplay, m_btnFormDisplay);
	DDX_Control(pDX, btnFormReencoding, m_btnFormReencoding);
	DDX_Control(pDX, btnFormTVTuner, m_btnFormTVTuner);
	DDX_Control(pDX, btnFormVideoSource, m_btnFormVideoSource);
	DDX_Control(pDX, IDC_VIDEOGRABBERVC61, m_VideoGrabber);
	//}}AFX_DATA_MAP
}

BEGIN_MESSAGE_MAP(CMainForm, CDialog)
	//{{AFX_MSG_MAP(CMainForm)
	ON_BN_CLICKED(btnFormVideoSource, OnbtnFormVideoSource)
	ON_BN_CLICKED(btnFormAudio, OnbtnFormAudio)
	ON_BN_CLICKED(btnFormRecording, OnbtnFormRecording)
	ON_BN_CLICKED(btnFormNetworkStreaming, OnbtnFormNetworkStreaming)
	ON_BN_CLICKED(btnFormPlayer, OnbtnFormPlayer)
	ON_BN_CLICKED(btnFormFrameGrabber, OnbtnFormFrameGrabber)
	ON_BN_CLICKED(btnFormMotionDetection, OnbtnFormMotionDetection)
	ON_BN_CLICKED(btnFormOverlays, OnbtnFormOverlays)
	ON_BN_CLICKED(btnFormVideoProcessing, OnbtnFormVideoProcessing)
	ON_BN_CLICKED(btnFormDisplay, OnbtnFormDisplay)
	ON_BN_CLICKED(btnFormReencoding, OnbtnFormReencoding)
	ON_BN_CLICKED(btnFormTVTuner, OnbtnFormTVTuner)
	ON_EN_CHANGE(edtStoragePath, OnChangeedtStoragePath)
	ON_WM_CLOSE()
	ON_COMMAND(mnuAbout, OnmnuAbout)
	ON_COMMAND(mnuDVff, OnmnuDVff)
	ON_COMMAND(mnuDVfreeze, OnmnuDVfreeze)
	ON_COMMAND(mnuDVmodeShuttle, OnmnuDVmodeShuttle)
	ON_COMMAND(mnuDVplay, OnmnuDVplay)
	ON_COMMAND(mnuDVplayFastestFwd, OnmnuDVplayFastestFwd)
	ON_COMMAND(mnuDVplayFastestRev, OnmnuDVplayFastestRev)
	ON_COMMAND(mnuDVplaySlowestFwd, OnmnuDVplaySlowestFwd)
	ON_COMMAND(mnuDVplaySlowestRev, OnmnuDVplaySlowestRev)
	ON_COMMAND(mnuDVrecord, OnmnuDVrecord)
	ON_COMMAND(mnuDVrecordFreeze, OnmnuDVrecordFreeze)
	ON_COMMAND(mnuDVrew, OnmnuDVrew)
	ON_COMMAND(mnuDVstepFwd, OnmnuDVstepFwd)
	ON_COMMAND(mnuDVstepRev, OnmnuDVstepRev)
	ON_COMMAND(mnuDVstop, OnmnuDVstop)
	ON_COMMAND(mnuDVthaw, OnmnuDVthaw)
	ON_COMMAND(mnuRecordStrobe, OnmnuRecordStrobe)
	ON_WM_HSCROLL()
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CMainForm message handlers

void CMainForm::Form_Load()
{
	CanUnload = false;

	FreeHandMouseDrawingEnabled = false;	// used for free-hand mouse drawing
	iFreeHandMouseDrawing = 0;		// used for free-hand mouse drawing
//?   SearchBmpFilesOpened = false;		// used for the "video from bitmaps" in the VideoGrabberVideoFromBitmaps_NextFrameNeeded event

	RECT rect;
	GetWindowRect(&rect);
	StartupWidth = rect.right - rect.left;	// Width
	StartupHeight= rect.bottom - rect.top;	// Height

	m_edtStoragePath.SetWindowText(m_VideoGrabber.GetStoragePath());

	AssignListToComboBox(&dlg_VideoSource->m_cboVideoSource, m_VideoGrabber.GetVideoSources(), m_VideoGrabber.GetVideoSource(), 4);

	// Video Source tab
	dlg_VideoSource->m_btnAutoRefreshPreview.SetCheck (m_VideoGrabber.GetAutoRefreshPreview());
	dlg_VideoSource->m_cboVideoSource.SetCurSel(m_VideoGrabber.GetVideoSource());
	dlg_VideoSource->m_chkScreenRecordingWithCursor.SetCheck(m_VideoGrabber.GetScreenRecordingWithCursor());

	// Audio tab
	dlg_Audio->m_chkRenderAudioDevice .SetCheck(m_VideoGrabber.GetAudioDeviceRendering());
	dlg_Audio->m_chkMuteAudioRendering.SetCheck(m_VideoGrabber.GetMuteAudioRendering());

	// RECORDING tab
	SetOptionButtonByIndex (dlg_Recording, rdgRecordingMethod, m_VideoGrabber.GetRecordingMethod());

	SetOptionButtonByIndex (dlg_Recording, rdgCompressMode, m_VideoGrabber.GetCompressionMode());

	SetOptionButtonByIndex (dlg_Recording, rdgCompressType, m_VideoGrabber.GetCompressionType());

	dlg_Recording->m_edtPreallocSize.SetWindowText(ToCString(m_VideoGrabber.GetPreallocCapFileSizeInMB()));

	dlg_Recording->m_chkRecordingCanPause	         .SetCheck(m_VideoGrabber.GetRecordingCanPause());
	dlg_Recording->m_chkRecordingPauseCreatesNewFile .SetCheck(m_VideoGrabber.GetRecordingPauseCreatesNewFile());
	dlg_Recording->m_chkPreallocFile		         .SetCheck(m_VideoGrabber.GetPreallocCapFileEnabled());
	dlg_Recording->m_chkOpenDML						 .SetCheck(m_VideoGrabber.GetAVIFormatOpenDML());
	dlg_Recording->m_chkPreserveNativeFormat		 .SetCheck(m_VideoGrabber.GetRecordingInNativeFormat());
	dlg_Recording->m_chkAudioRecording				 .SetCheck(m_VideoGrabber.GetAudioRecording());

	AssignListToComboBox(&dlg_Recording->m_cboVideoCompressors, m_VideoGrabber.GetVideoCompressors(), m_VideoGrabber.GetVideoCompressor());
	AssignListToComboBox(&dlg_Recording->m_cboAudioCompressors, m_VideoGrabber.GetAudioCompressors(), m_VideoGrabber.GetAudioCompressor());

	// network Streaming tab
	SetOptionButtonByIndex (dlg_NetworkStreaming, rdgNetworkStreaming, m_VideoGrabber.GetNetworkStreaming());

	dlg_NetworkStreaming->m_edtPublishingPoint	.SetWindowText(m_VideoGrabber.GetASFMediaServerPublishingPoint());
	dlg_NetworkStreaming->m_edtNetworkPort		.SetWindowText(ToCString(m_VideoGrabber.GetASFNetworkPort()));
	dlg_NetworkStreaming->m_edtNetworkMaxUsers	.SetWindowText(ToCString(m_VideoGrabber.GetASFNetworkMaxUsers()));
	dlg_NetworkStreaming->m_edtASFVideoWidth	.SetWindowText(ToCString(m_VideoGrabber.GetASFVideoWidth()));
	dlg_NetworkStreaming->m_edtASFVideoHeight	.SetWindowText(ToCString(m_VideoGrabber.GetASFVideoHeight()));
	dlg_NetworkStreaming->m_edtASFVideoBitRate	.SetWindowText(ToCString(m_VideoGrabber.GetASFVideoBitRate()));
	dlg_NetworkStreaming->m_edtASFVideoMaxKeyFrameSpacing.SetWindowText(ToCString(m_VideoGrabber.GetASFVideoMaxKeyFrameSpacing()));
	dlg_NetworkStreaming->m_edtASFVideoQuality	.SetWindowText(ToCString(m_VideoGrabber.GetASFVideoQuality()));
	dlg_NetworkStreaming->m_edtASFAudioChannels	.SetWindowText(ToCString(m_VideoGrabber.GetASFAudioChannels()));

	dlg_NetworkStreaming->m_chkASFFixedFrameRate.SetCheck(m_VideoGrabber.GetASFFixedFrameRate());
	dlg_NetworkStreaming->m_cmbASFDeinterlaceMode.SetCurSel(m_VideoGrabber.GetASFDeinterlaceMode());
	dlg_NetworkStreaming->m_edtProfileIndex.SetWindowText(ToCString(m_VideoGrabber.GetASFProfile()));

	// Player tab
	dlg_Player->m_updPlayerSpeedRatio.SetPos((int)(m_VideoGrabber.GetPlayerSpeedRatio() * 10));
	dlg_Player->m_updPlayerFastSeekSpeed.SetPos(m_VideoGrabber.GetPlayerFastSeekSpeedRatio() * 10);

	dlg_Player->m_btnAutoPlay.SetCheck(m_VideoGrabber.GetAutoStartPlayer());
	dlg_Player->m_chkPlayerAudioRendering.SetCheck(m_VideoGrabber.GetPlayerAudioRendering());

	SetOptionButtonByIndex (dlg_Player, rdgDVPlaybackSize, m_VideoGrabber.GetPlayerDVSize());

	dlg_Player->m_chkRefreshPausedDisplay.SetCheck(m_VideoGrabber.GetPlayerRefreshPausedDisplay());

	// Frame grabber tab
	SetOptionButtonByIndex (dlg_FrameGrabber, rgdFrameGrabber, m_VideoGrabber.GetFrameGrabber());
	SetOptionButtonByIndex (dlg_FrameGrabber, rgdFrameGrabberFormat, m_VideoGrabber.GetFrameGrabberRGBFormat());
	SetOptionButtonByIndex (dlg_FrameGrabber, rdgAutoFileName, m_VideoGrabber.GetAutoFileName());

	dlg_FrameGrabber->m_edtAVIAutoFilePrefix.SetWindowText(m_VideoGrabber.GetAutoFilePrefix());
	dlg_FrameGrabber->m_edtBurstCount		.SetWindowText(ToCString(m_VideoGrabber.GetBurstCount()));
	dlg_FrameGrabber->m_edtBurstInterval	.SetWindowText(ToCString(m_VideoGrabber.GetBurstInterval()));
	dlg_FrameGrabber->m_tbrCaptureZoomSize	.SetPos(m_VideoGrabber.GetFrameCaptureZoomSize());

	// Motion detection tab
	dlg_MotionDetection->m_chkMotionDetectionEnabled.SetCheck(m_VideoGrabber.GetMotionDetector_Enabled());
	dlg_MotionDetection->m_chkCompareRed			.SetCheck(m_VideoGrabber.GetMotionDetector_CompareRed());
	dlg_MotionDetection->m_chkCompareGreen			.SetCheck(m_VideoGrabber.GetMotionDetector_CompareGreen());
	dlg_MotionDetection->m_chkCompareBlue			.SetCheck(m_VideoGrabber.GetMotionDetector_CompareBlue());
	dlg_MotionDetection->m_chk_GreyScale			.SetCheck(m_VideoGrabber.GetMotionDetector_GreyScale());
	dlg_MotionDetection->m_chkReduceVideoNoise		.SetCheck(m_VideoGrabber.GetMotionDetector_ReduceVideoNoise());

	dlg_MotionDetection->m_edtGrid				.SetWindowText(m_VideoGrabber.GetMotionDetector_Grid());
	dlg_MotionDetection->m_mmoSensitivityGrid	.SetWindowText(m_VideoGrabber.MotionDetector_Get2DTextGrid());

	dlg_MotionDetection->m_edtGridColCount		.SetWindowText(ToCString(m_VideoGrabber.GetMotionDetector_GridXCount()));
	dlg_MotionDetection->m_edtGridRowCount		.SetWindowText(ToCString(m_VideoGrabber.GetMotionDetector_GridYCount()));

	// TV Tuner tab
	SetOptionButtonByIndex (Dlg_TVTuner, rdgTunerInputType, m_VideoGrabber.GetTVTunerInputType());

	Dlg_TVTuner->m_edtCountryCode.SetWindowText(ToCString(m_VideoGrabber.GetTVCountryCode()));
	Dlg_TVTuner->m_edtTVChannel.SetWindowText(ToCString(m_VideoGrabber.GetTVChannel()));
	Dlg_TVTuner->m_chkEnableFrequencyOverrides.SetCheck(m_VideoGrabber.GetTVUseFrequencyOverrides());

	// Frame overlay tab
	dlg_Overlays->m_mmoTextOverlayString.SetWindowText(m_VideoGrabber.GetTextOverlay_String());
	dlg_Overlays->m_chkTextOverlayEnabled.SetCheck(m_VideoGrabber.GetTextOverlay_Enabled());
	dlg_Overlays->m_chkTextOverlayTransparent.SetCheck(m_VideoGrabber.GetTextOverlay_Transparent());
	dlg_Overlays->m_cmbBitmapOverlayTransparentColor.AddString ("yellow");
	dlg_Overlays->m_cmbBitmapOverlayTransparentColor.AddString ("red");
	dlg_Overlays->m_cmbBitmapOverlayTransparentColor.AddString ("blue");
	dlg_Overlays->m_cmbBitmapOverlayTransparentColor.AddString ("white");
	dlg_Overlays->m_cmbBitmapOverlayTransparentColor.SetCurSel (0);

	// Video processing tab
	SetOptionButtonByIndex (dlg_VideoProcessing, rdgVideoRotation, m_VideoGrabber.GetVideoProcessing_Rotation());
	SetOptionButtonByIndex (dlg_VideoProcessing, rdgDeinterlacing, m_VideoGrabber.GetVideoProcessing_Deinterlacing());

	dlg_VideoProcessing->m_tbrBrightness.SetPos(m_VideoGrabber.GetVideoProcessing_Brightness());
	dlg_VideoProcessing->m_tbrContrast	.SetPos(m_VideoGrabber.GetVideoProcessing_Contrast());
	dlg_VideoProcessing->m_tbrSaturation.SetPos(m_VideoGrabber.GetVideoProcessing_Saturation());
	dlg_VideoProcessing->m_tbrHue		.SetPos(m_VideoGrabber.GetVideoProcessing_Hue());

	dlg_VideoProcessing->m_chkGreyScale		.SetCheck(m_VideoGrabber.GetVideoProcessing_GrayScale());
	dlg_VideoProcessing->m_chkInvertColors	.SetCheck(m_VideoGrabber.GetVideoProcessing_InvertColors());
	dlg_VideoProcessing->m_chkFlipVertical	.SetCheck(m_VideoGrabber.GetVideoProcessing_FlipVertical());
	dlg_VideoProcessing->m_chkFlipHorizontal.SetCheck(m_VideoGrabber.GetVideoProcessing_FlipHorizontal());

	dlg_VideoProcessing->m_chkCroppingEnabled	.SetCheck(m_VideoGrabber.GetCropping_Enabled());
	dlg_VideoProcessing->m_chkCroppingOutbounds	.SetCheck(m_VideoGrabber.GetCropping_Outbounds());

	dlg_VideoProcessing->m_edtCroppingWidth		.SetWindowText(ToCString(m_VideoGrabber.GetCropping_Width()));
	dlg_VideoProcessing->m_edtCroppingHeight	.SetWindowText(ToCString(m_VideoGrabber.GetCropping_Height()));

	dlg_VideoProcessing->m_trkCroppingZoom		.SetPos((int)(m_VideoGrabber.GetCropping_Zoom() * 100));

	// trkCroppingX.Max and trkCroppingY.Max are will be set from the OnResizeVideo event
	dlg_VideoProcessing->m_trkCroppingY		.SetPos(m_VideoGrabber.GetCropping_Y());
	dlg_VideoProcessing->m_trkCroppingX		.SetPos(m_VideoGrabber.GetCropping_X());

	// Display tab
	SetOptionButtonByIndex (dlg_Display, rdgVideoRenderer, m_VideoGrabber.GetVideoRenderer());

	dlg_Display->m_chkBorder.SetCheck(m_VideoGrabber.GetBorderStyle()==bsSingle ? BST_CHECKED : BST_UNCHECKED);
	dlg_Display->RefreshDisplayOptions();

	// reencoding tab
	SetOptionButtonByIndex (dlg_Reencoding, rdgReencodingMethod, m_VideoGrabber.GetReencoding_Method());

	dlg_Reencoding->m_chkWMVOutput			.SetCheck(m_VideoGrabber.GetReencoding_WMVOutput());
	dlg_Reencoding->m_chkIncludeVideoStream	.SetCheck(m_VideoGrabber.GetReencoding_IncludeVideoStream());
	dlg_Reencoding->m_chkIncludeAudioStream	.SetCheck(m_VideoGrabber.GetReencoding_IncludeAudioStream());
	dlg_Reencoding->m_chkUseFrameGrabber	.SetCheck(m_VideoGrabber.GetReencoding_UseFrameGrabber());
	dlg_Reencoding->m_chkUseCurrentVideoCompressor.SetCheck(m_VideoGrabber.GetReencoding_UseVideoCompressor());
	dlg_Reencoding->m_chkUseCurrentAudioCompressor.SetCheck(-m_VideoGrabber.GetReencoding_UseAudioCompressor());

	cs.Format("%lf", m_VideoGrabber.GetReencodingStartTime());
	dlg_Reencoding->m_edtStartTime	.SetWindowText(cs);

	cs.Format("%lf", m_VideoGrabber.GetReencodingStopTime());
	dlg_Reencoding->m_edtStopTime	.SetWindowText(cs);

	RefreshVideoDeviceControls();
}

void CMainForm::ShowForm (CDialog *Dialog)
{
	CRect wMain, wChild; 

	GetWindowRect(&wMain); 
	Dialog->GetWindowRect (wChild);
    CPoint loc (wMain.left, wMain.top - wChild.Height() - 10);
    Dialog->SetWindowPos(NULL, loc.x, loc.y, 0, 0, SWP_NOSIZE | SWP_NOZORDER); 

	Dialog->ShowWindow(SW_SHOW);
}

BOOL CMainForm::OnInitDialog()
{
	CDialog::OnInitDialog();

	dlg_Audio = new CAudio;
	dlg_Audio->dlg_MainForm = this;
	dlg_Audio->Create (Audio);

	dlg_Display = new CDisplay;
	dlg_Display->dlg_MainForm = this;
	dlg_Display->Create (Display);

	dlg_FrameGrabber = new CFrameGrabber;
	dlg_FrameGrabber->dlg_MainForm = this;
	dlg_FrameGrabber->Create (FrameGrabber);

	dlg_MotionDetection = new CMotionDetection;
	dlg_MotionDetection->dlg_MainForm = this;
	dlg_MotionDetection->Create (MotionDetection);

	dlg_NetworkStreaming = new CNetworkStreaming;
	dlg_NetworkStreaming->dlg_MainForm = this;
	dlg_NetworkStreaming->Create (NetworkStreaming);

	dlg_Overlays = new COverlays;
	dlg_Overlays->dlg_MainForm = this;
	dlg_Overlays->Create (Overlays);

	dlg_Player = new CPlayer;
	dlg_Player->dlg_MainForm = this;
	dlg_Player->Create (Player);

	dlg_Recording = new CRecording;
	dlg_Recording->dlg_MainForm = this;
	dlg_Recording->Create (Recording);

	dlg_Reencoding = new CReencoding;
	dlg_Reencoding->dlg_MainForm = this;
	dlg_Reencoding->Create (Reencoding);

	dlg_VideoSource = new CVideoSource;
	dlg_VideoSource->dlg_MainForm = this;
	dlg_VideoSource->Create (VideoSource);

	Dlg_TVTuner = new CTVTuner;
	Dlg_TVTuner->dlg_MainForm = this;
	Dlg_TVTuner->Create (TVTuner);

	dlg_VideoProcessing = new CVideoProcessing;
	dlg_VideoProcessing->dlg_MainForm = this;
	dlg_VideoProcessing->Create (VideoProcessing);

	Form_Load();

	return TRUE;
}

void CMainForm::RefreshVideoDeviceControls() {

	m_VideoGrabber.SetAutoRefreshPreview (false); // prevents restarting preview each time a property is set below, will be re-enabled at end of RefreshVideoDeviceControls()

	AssignListToComboBox(&dlg_VideoSource->m_cboVideoDevices, m_VideoGrabber.GetVideoDevices(), m_VideoGrabber.GetVideoDevice());
	AssignListToComboBox(&dlg_Audio->m_cboAudioDevices		, m_VideoGrabber.GetAudioDevices(), m_VideoGrabber.GetAudioDevice());

	dlg_VideoSource->m_chkReduceDVFrameRate.SetCheck(m_VideoGrabber.GetDVReduceFrameRate());
	dlg_VideoSource->m_chkReduceDVFrameRate.SetCheck(m_VideoGrabber.GetIsDigitalVideoIn());

	dlg_Recording->m_btnPauseRecording.EnableWindow(m_VideoGrabber.GetRecordingCanPause());
	dlg_Recording->m_btnResumeRecording.EnableWindow(m_VideoGrabber.GetRecordingCanPause());

	// ' mnuSendDVCommands.EnableWindow(m_VideoGrabber.GetIsDVCommandAvailable());	// TOSEE

	dlg_VideoSource->m_btnStreamDialog			.EnableWindow(!m_VideoGrabber.GetIsDigitalVideoIn());
	dlg_VideoSource->m_btnCameraControlDialog	.EnableWindow(m_VideoGrabber.GetIsCameraControlAvailable());
	dlg_VideoSource->m_btnVideoQualityDialog	.EnableWindow(m_VideoGrabber.GetIsVideoQualityAvailable());
	dlg_VideoSource->m_btnVideoControlDialog	.EnableWindow(m_VideoGrabber.GetIsVideoControlAvailable());
	dlg_VideoSource->m_cboAnalogVideoStandard	.EnableWindow(m_VideoGrabber.GetIsAnalogVideoDecoderAvailable());
	dlg_VideoSource->m_cboVideoInputs			.EnableWindow(m_VideoGrabber.GetIsVideoCrossbarAvailable());

	cs.Format("%.2lf", m_VideoGrabber.GetFrameRate());
	dlg_VideoSource->m_edtFrameRate.SetWindowText(cs);

	SetOptionButtonByIndex (Dlg_TVTuner, rdgTunerInputType, m_VideoGrabber.GetTVTunerInputType());
	Dlg_TVTuner->m_edtCountryCode.SetWindowText(ToCString(m_VideoGrabber.GetTVCountryCode()));
	Dlg_TVTuner->m_edtTVChannel.SetWindowText(ToCString(m_VideoGrabber.GetTVChannel()));

	m_btnFormTVTuner.EnableWindow(!m_VideoGrabber.GetIsTVTunerAvailable());

	dlg_Recording->m_rdgCompressMode.EnableWindow(true);
	dlg_Recording->m_rdgCompressType.EnableWindow(true);

	if (!m_VideoGrabber.GetAudioRecording()) {
		// ' dlg_Recording->m_rdgCompressType.ItemIndex = 0
		dlg_Recording->m_rdgCompressType.EnableWindow(false);
	}

	dlg_Overlays->m_lblFrameOverlayRequiresFrameGrabber.ShowWindow(
		(m_VideoGrabber.GetFrameGrabber()==fg_Disabled) ? SW_SHOW : SW_HIDE);

	dlg_MotionDetection->m_lblMotionDetectorRequiresFrameGrabber.ShowWindow(
		(m_VideoGrabber.GetFrameGrabber()==fg_Disabled) ? SW_SHOW : SW_HIDE);

	// ' m_VideoControl.RefreshControls TOSEE

	dlg_Recording->m_chkOpenDML					.EnableWindow(m_VideoGrabber.GetRecordingMethod()==rm_AVI);
	dlg_Recording->m_rdgCompressMode			.EnableWindow(m_VideoGrabber.GetRecordingMethod()==rm_AVI);
	dlg_Recording->m_rdgCompressType			.EnableWindow(m_VideoGrabber.GetRecordingMethod()==rm_AVI);
	dlg_Recording->m_cboVideoCompressors		.EnableWindow(m_VideoGrabber.GetRecordingMethod()==rm_AVI);
	dlg_Recording->m_btnVideoCompressorSettings	.EnableWindow(m_VideoGrabber.GetRecordingMethod()==rm_AVI);
	dlg_Recording->m_cboAudioCompressors		.EnableWindow(m_VideoGrabber.GetRecordingMethod()==rm_AVI);
	dlg_Recording->m_btnAudioCompressorSettings	.EnableWindow(m_VideoGrabber.GetRecordingMethod()==rm_AVI);
	dlg_Recording->m_chkPreallocFile			.EnableWindow(m_VideoGrabber.GetRecordingMethod()==rm_AVI);

	m_VideoGrabber.SetAutoRefreshPreview(dlg_VideoSource->m_btnAutoRefreshPreview.GetCheck()==BST_CHECKED); // let's restore the setting disabled at the beginning of RefreshVideoDeviceControls()

}

void CMainForm::OnChangeedtStoragePath() 
{
	m_edtStoragePath.GetWindowText(cs);
	m_VideoGrabber.SetStoragePath(cs);
}

//Private Sub Command15_Click()
//   FrameGrabber.Show
//End Sub

void CMainForm::OnbtnFormAudio() 
{
	ShowForm (dlg_Audio);
}

void CMainForm::OnbtnFormDisplay() 
{
	ShowForm (dlg_Display);
}

void CMainForm::OnbtnFormFrameGrabber() 
{
	ShowForm (dlg_FrameGrabber);
}

void CMainForm::OnbtnFormMotionDetection() 
{
	ShowForm (dlg_MotionDetection);
}

void CMainForm::OnbtnFormNetworkStreaming() 
{
	ShowForm (dlg_NetworkStreaming);
}

void CMainForm::OnbtnFormOverlays() 
{
	ShowForm (dlg_Overlays);	
}

void CMainForm::OnbtnFormPlayer() 
{
	ShowForm (dlg_Player);
}

void CMainForm::OnbtnFormRecording() 
{
	ShowForm (dlg_Recording);
}

void CMainForm::OnbtnFormReencoding() 
{
	ShowForm (dlg_Reencoding);
}

void CMainForm::OnbtnFormTVTuner() 
{
	ShowForm (Dlg_TVTuner);
}

void CMainForm::OnbtnFormVideoProcessing() 
{
	ShowForm (dlg_VideoProcessing);
}

void CMainForm::OnbtnFormVideoSource() 
{
	ShowForm (dlg_VideoSource);
}

void CMainForm::OnClose() 
{
	FileSearch_Close(VideoFromBitmapSearch);
//?	CanUnload = True

	CDialog::OnClose();
}

void CMainForm::OnmnuAbout() 
{
	m_VideoGrabber.About();
}

void CMainForm::SendDVCommand(TxDVCommand DvCommand)
{
	// IT IS THE "TAG" PROPERTY OF EACH MENU ITEM THAT SELECTS THE CORRESPONDING TVCRCommand
	if (m_VideoGrabber.SendDVCommand(DvCommand))
		AddLog(&m_mmoLog, "DV command sent...");
	else {
		if ((m_VideoGrabber.GetCurrentState() != cs_Preview) && (m_VideoGrabber.GetCurrentState() != cs_Recording))
			AddLog(&m_mmoLog, "DV command failed. Preview must be running!");
		else
			AddLog(&m_mmoLog, "DV command failed.");
	}
}

void CMainForm::OnmnuDVff() 
{
	SendDVCommand (dv_Ff);
}

void CMainForm::OnmnuDVfreeze() 
{
	SendDVCommand (dv_Freeze);
}

void CMainForm::OnmnuDVmodeShuttle() 
{
	SendDVCommand (dv_ModeShuttle);
}

void CMainForm::OnmnuDVplay() 
{
	SendDVCommand (dv_Play);
}

void CMainForm::OnmnuDVplayFastestFwd() 
{
	SendDVCommand (dv_PlayFastestFwd);
}

void CMainForm::OnmnuDVplayFastestRev() 
{
	SendDVCommand (dv_PlayFastestRev);
}

void CMainForm::OnmnuDVplaySlowestFwd() 
{
	SendDVCommand (dv_PlaySlowestFwd);
}

void CMainForm::OnmnuDVplaySlowestRev() 
{
	SendDVCommand (dv_PlaySlowestRev);
}

void CMainForm::OnmnuDVrecord() 
{
	SendDVCommand (dv_Record);
}

void CMainForm::OnmnuDVrecordFreeze() 
{
	SendDVCommand (dv_RecordFreeze);
}

void CMainForm::OnmnuDVrew() 
{
	SendDVCommand (dv_Rew);
}

void CMainForm::OnmnuDVstepFwd() 
{
	SendDVCommand (dv_StepFwd);
}

void CMainForm::OnmnuDVstepRev() 
{
	SendDVCommand (dv_StepRev);
}

void CMainForm::OnmnuDVstop() 
{
	SendDVCommand (dv_Stop);
}

void CMainForm::OnmnuDVthaw() 
{
	SendDVCommand (dv_Thaw);
}

void CMainForm::OnmnuRecordStrobe() 
{
	SendDVCommand (dv_RecordStrobe);
}

void CMainForm::OnHScroll(UINT nSBCode, UINT nPos, CScrollBar* pScrollBar) 
{
	if (pScrollBar->m_hWnd==m_tbrPlayer.m_hWnd) {
		if (!m_VideoGrabber.GetInFrameProgressEvent())
			m_VideoGrabber.SetPlayerFramePosition(m_tbrPlayer.GetPos());
	}
	
	CDialog::OnHScroll(nSBCode, nPos, pScrollBar);
}

void CMainForm::OnOnAudioDeviceSelectedVideograbbervc61() 
{
	// from this event set the parameters that change when the current audio capture device change
	dlg_Audio->m_cboAudioDevices.SetCurSel(m_VideoGrabber.GetAudioDevice());	// be sure the listbox index matches the current index value
	AssignListToComboBox(&dlg_Recording->m_cboAudioFormats, m_VideoGrabber.GetAudioFormats(), m_VideoGrabber.GetAudioFormat());
	AssignListToComboBox(&dlg_Audio->m_cboAudioInputs, m_VideoGrabber.GetAudioInputs(), m_VideoGrabber.GetAudioInput());
	dlg_Audio->m_tbrAudioInputLevel.SetPos(m_VideoGrabber.GetAudioInputLevel());
	dlg_Audio->m_tbrAudioInputBalance.SetPos(m_VideoGrabber.GetAudioInputBalance());
	dlg_Audio->m_chkAudioInputMono.SetCheck(m_VideoGrabber.GetAudioInputMono() ? BST_CHECKED : BST_UNCHECKED);
}

void CMainForm::OnOnCopyPreallocDataCompletedVideograbbervc61(LPCTSTR SourceFile, LPCTSTR DestFile, BOOL Success)
{
	if (Success)	
		AddLog(&m_mmoLog, CString(" successfully copied to ") + CString(DestFile) + CString(".") );
	else
		AddLog(&m_mmoLog, CString("ERROR: Failed to copy ") + CString(SourceFile) + CString(" to ") + CString(DestFile) + CString("!") );
}

void CMainForm::OnOnCopyPreallocDataProgressVideograbbervc61(long Percent, double Position, double Duration) 
{
	cs.Format("copying data: %ld%% completed.", Percent);
	AddLog(&m_mmoLog, cs);
}

void CMainForm::OnOnCopyPreallocDataStartedVideograbbervc61(LPCTSTR SourceFile, LPCTSTR DestFile) 
{
	cs.Format("copying data from %s to %s ...", SourceFile, DestFile);
	AddLog(&m_mmoLog, cs);
}

void CMainForm::OnOnCreatePreallocFileCompletedVideograbbervc61(LPCTSTR FileName, BOOL Success) 
{
	if (Success) {
		AddLog(&m_mmoLog, CString("preallocated file ") + CString(FileName) + CString(" successfully created.") );
	} else {
		AddLog(&m_mmoLog, CString("ERROR: Failed to preallocate ")+CString(FileName));
	}
}

void CMainForm::OnOnCreatePreallocFileProgressVideograbbervc61(long Percent, double Position, double Duration) 
{
	cs.Format("%ld%% of preallocated file completed", Percent);
	AddLog(&m_mmoLog, cs);
}

void CMainForm::OnOnCreatePreallocFileStartedVideograbbervc61(LPCTSTR FileName) 
{
	AddLog(&m_mmoLog, CString("preallocating file ") + CString(FileName) + CString("..."));
}

void CMainForm::OnOnDeviceArrivalOrRemovalVideograbbervc61(BOOL IsDeviceArrival, BOOL IsVideoDevice, LPCTSTR DeviceName, long DeviceIndex) 
{
	CString AudioOrVideoDevice = IsVideoDevice ? "video device " : "audio device ";

	if (IsDeviceArrival)
		AddLog(&m_mmoLog, AudioOrVideoDevice + " arrival:");
	else
		AddLog(&m_mmoLog, AudioOrVideoDevice + " removal:");

	AddLog(&m_mmoLog, DeviceName);

	if (IsVideoDevice)
		AssignListToComboBox(&dlg_VideoSource->m_cboVideoDevices, m_VideoGrabber.GetVideoDevices(), m_VideoGrabber.GetVideoDevice());
	else
		AssignListToComboBox(&dlg_Audio->m_cboAudioDevices, m_VideoGrabber.GetAudioDevices(), m_VideoGrabber.GetAudioDevice());
}

void CMainForm::OnOnDeviceLostVideograbbervc61() 
{
	AddLog(&m_mmoLog, "DEVICE LOST!");
	AssignListToComboBox(&dlg_VideoSource->m_cboVideoDevices, m_VideoGrabber.GetVideoDevices(), m_VideoGrabber.GetVideoDevice());
	AssignListToComboBox(&dlg_Audio->m_cboAudioDevices, m_VideoGrabber.GetAudioDevices(), m_VideoGrabber.GetAudioDevice());
}

void CMainForm::OnOnDirectNetworkStreamingHostUrlVideograbbervc61(LPCTSTR HostUrl, LPCTSTR HostName, long HostPort) 
{
	AddLog(&m_mmoLog, CString("streaming URL: ") + HostUrl);
	AddLog(&m_mmoLog, CString("streaming host: ") + HostName);
	cs.Format("streaming port: %ld", HostPort);
	AddLog(&m_mmoLog, cs);
}

void CMainForm::OnOnDiskFullVideograbbervc61() 
{
	AddLog(&m_mmoLog, "DISK FULL!");
}

void CMainForm::OnOnDVCommandCompletedVideograbbervc61(long NewStateValue, LPCTSTR NewStateLabel) 
{
	cs.Format("camcorder state: %ld", NewStateLabel);
	AddLog(&m_mmoLog, cs);
}

void CMainForm::OnOnFrameCaptureCompletedVideograbbervc61(long FrameBitmapHandle, long BitmapWidth, long BitmapHeight, long FrameNumber, double FrameTime, long DestType, LPCTSTR FileName, BOOL Success, long FrameId) 
{
	if (Success) {
		cs.Format("frame #%ld captured", FrameNumber);
		AddLog(&dlg_FrameGrabber->m_mmoFrameCaptureLog, cs);
	}
   
	switch(DestType) {

		//______ bmp or jpeg file
		case fc_BmpFile:
		case fc_JpegFile:
			if (Success)
				AddLog(&dlg_FrameGrabber->m_mmoFrameCaptureLog, FileName);
			else
				AddLog(&dlg_FrameGrabber->m_mmoFrameCaptureLog, CString("error: failed to create ") + CString(FileName));
			break;

	}
}

void CMainForm::OnOnDVDiscontinuityVideograbbervc61(BOOL FAR* DeliverNewFrame) 
{
   // SAMPLE CODE 1: creates a new file during recording when a discontinuity in the DV date/time is detected (uncommend the 2 lines below)
   // DeliverNewFrame = false;
   // m_VideoGrabber.RecordToNewFileNow();

   // SAMPLE CODE 2: stops the recording when a discontinuity in the DV date/time is detected (uncommend the 2 lines below)
   // DeliverNewFrame = false;
   // m_VideoGrabber.StopRecording();

   // Important: from this event you should not perform any actions with the potential to block, such as holding
   // a critical section or waiting on another thread. Also, do not call any GDI or USER32.DLL APIs.
}

void CMainForm::OnOnFrameOverlayUsingDCVideograbbervc61(long Dc, long FrameNumber, double FrameTime, long FrameId) 
{
	bool AlphaBlend;
	bool UseTransparentColor;
	bool Transparent;
	long AlphaBlendValue;

	Transparent = dlg_Overlays->m_chkBitmapOverlayTransparent.GetCheck() == BST_CHECKED;
	UseTransparentColor = dlg_Overlays->m_chkBitmapOverlayUseTransparentColor.GetCheck()== BST_CHECKED;

	AlphaBlend = dlg_Overlays->m_chkBitmapOverlayAlphaBlending.GetCheck()== BST_CHECKED;
	if (! IsNumeric (&dlg_Overlays->m_edtAlphaBlendingValue,AlphaBlendValue)) {
		AlphaBlendValue = 100;
	}

	int TransparentColor = 0XFFFFFF;
	switch (dlg_Overlays->m_cmbBitmapOverlayTransparentColor.GetCurSel ()) {
		case 0: TransparentColor = 0X00FFFF; break;
		case 1: TransparentColor = 0X0000FF; break;
		case 2: TransparentColor = 0XFF0000; break;
		case 3: TransparentColor = 0XFFFFFF; break;
	}

	if (dlg_Overlays->m_chkBitmapOverlayEnabled.GetCheck()== BST_CHECKED) {  // DO NOT TEST DIRECTLY dlg_Overlays->m_chkBitmapOverlayEnabled.GetCheck() from this event, this can lock
		m_VideoGrabber.DrawBitmapOverFrame(
			(long)dlg_Overlays->m_ImgBitmapOverlay.GetBitmap(),
			false,
			BitmapOverlay_Left, BitmapOverlay_Top, 
			BitmapOverlay_Width, BitmapOverlay_Height,
			dlg_Overlays->m_chkBitmapOverlayTransparent.GetCheck()== BST_CHECKED, UseTransparentColor, TransparentColor,
			AlphaBlend, AlphaBlendValue,
			false, 0, 0
			);
	}

	if (iFreeHandMouseDrawing > 0) { 
		// see the VideoGrabberMouse... events
		const COLORREF vbRed = RGB(255,0,0);
		HDC hDc = (HDC)Dc;
		for(long i=0; i<iFreeHandMouseDrawing; i++) {
			if (FreeHandMouseDrawing[i].right==0) 
			{	// Right is used as boolean to know if it is a MoveTo or a LineTo
				POINT Point;
	            MoveToEx(hDc, FreeHandMouseDrawing[i].left, FreeHandMouseDrawing[i].top, &Point);
	            SetPixel(hDc, FreeHandMouseDrawing[i].left, FreeHandMouseDrawing[i].top, vbRed);
			} else {
				HPEN NewPen = CreatePen(PS_SOLID, 1, vbRed);
				HGDIOBJ OldPen = SelectObject(hDc, NewPen);
				LineTo(hDc, FreeHandMouseDrawing[i].left, FreeHandMouseDrawing[i].top);
				SelectObject(hDc, OldPen);
				DeleteObject(NewPen);
			}
 		}
	}
}

void CMainForm::OnOnFrameOverlayUsingDIBVideograbbervc61(long FrameBitmapHandle, long FrameNumber, double FrameTime, long FrameId) 
{
	// read the (1) comment at the bottom of this unit

	DIBSECTION DibSect;
	bool SkipLine;
	long CurrentLine;
   
	if (dlg_Overlays->m_chkLinesOverlayEnabled.GetCheck()== BST_CHECKED) // DO NOT TEST DIRECTLY dlg_Overlays->m_chkLinesOverlayEnabled.GetCheck() from this event, this ccan lock
	{
		if (GetObject((void*)FrameBitmapHandle, sizeof(DibSect), &DibSect) != 0)
		{
            SkipLine = false;
			CurrentLine = 0;
			for (long i=0; i < DibSect.dsBm.bmHeight; i++)
			{
				if (SkipLine) {
					//????
					char *pDestination = (char *)(DibSect.dsBm.bmBits) + CurrentLine;
					ZeroMemory(pDestination, DibSect.dsBm.bmWidthBytes);
				}
				CurrentLine += DibSect.dsBm.bmWidthBytes;
				SkipLine = !SkipLine;
			}
		}
	}
}

void CMainForm::OnOnFrameProgressVideograbbervc61(long FrameNumber, double FrameTime, long FrameId) 
{
	CString DVTimeCode, DVDateTime;

	cs.Format("frame:  %ld  dropped: %ld  time: %02ld:%02ld:%02ld.%02ld"
		, FrameNumber
		, m_VideoGrabber.GetFrameInfo(FrameId, fi_DroppedFrameCount)
		, m_VideoGrabber.GetFrameInfo(FrameId, fi_SampleTime_Hour)
		, m_VideoGrabber.GetFrameInfo(FrameId, fi_SampleTime_Min)
		, m_VideoGrabber.GetFrameInfo(FrameId, fi_SampleTime_Sec)
		, m_VideoGrabber.GetFrameInfo(FrameId, fi_SampleTime_Hs) );

	m_edtFrameCount.SetWindowText(cs);
                          
	if (m_VideoGrabber.GetFrameInfo(FrameId, fi_DVTimeCode_IsAvailable) > 0) 
	{	// not available if 0
		DVTimeCode.Format("tc: %02ld:%02ld:%02ld:%02ld"
			, m_VideoGrabber.GetFrameInfo(FrameId, fi_DVTimeCode_Hour)
			, m_VideoGrabber.GetFrameInfo(FrameId, fi_DVTimeCode_Min)
			, m_VideoGrabber.GetFrameInfo(FrameId, fi_DVTimeCode_Sec)
			, m_VideoGrabber.GetFrameInfo(FrameId, fi_DVTimeCode_Ff) );
	} else {
		DVTimeCode = " ";
	} 

	if (m_VideoGrabber.GetFrameInfo(FrameId, fi_DVDateTime_IsAvailable) > 0) 
	{	// not available if 0
		DVDateTime.Format("dv date: %02ld/%02ld/%02ld %02ld:%02ld:%02ld"
		, m_VideoGrabber.GetFrameInfo(FrameId, fi_DVDateTime_Day)
		, m_VideoGrabber.GetFrameInfo(FrameId, fi_DVDateTime_Month)
		, m_VideoGrabber.GetFrameInfo(FrameId, fi_DVDateTime_Year)
		, m_VideoGrabber.GetFrameInfo(FrameId, fi_DVDateTime_Hour)
		, m_VideoGrabber.GetFrameInfo(FrameId, fi_DVDateTime_Min)
		, m_VideoGrabber.GetFrameInfo(FrameId, fi_DVDateTime_Sec) );
	}

	m_edtDVDateTime.SetWindowText(DVTimeCode + " " + DVDateTime);
   
	if (m_VideoGrabber.GetCurrentState()==cs_Playback)
		m_tbrPlayer.SetPos(FrameNumber);
}

void CMainForm::OnOnInactiveVideograbbervc61() 
{
	AddLog(&m_mmoLog, "(done.)");
}

void CMainForm::OnOnLogVideograbbervc61(long LogType, LPCTSTR Severity, LPCTSTR InfoMsg) 
{
	AddLog(&m_mmoLog, CString("[") + CString(Severity) + CString("] ") + CString(InfoMsg));
}

void CMainForm::OnOnMotionDetectedVideograbbervc61(double GlobalMotionRatio, long MaxMotionCellX, long MaxMotionCellY, long FrameBitmapHandle, long FrameNumber, double FrameTime, long FrameId, BOOL FAR* CaptureFrame) 
{
	long MaxMotionXLocation, MaxMotionYLocation;

	cs.Format("%.3lf", m_VideoGrabber.GetMotionDetector_GlobalMotionRatio());
	dlg_MotionDetection->m_edtMotionRatio.SetWindowText(cs);

	cs.Format("x: %d   y: %d", MaxMotionCellX, MaxMotionCellY);
	dlg_MotionDetection->m_edtMaxMotionXY.SetWindowText(cs);

	if (m_VideoGrabber.MotionDetector_GetCellLocation(MaxMotionCellX, MaxMotionCellY, &MaxMotionXLocation, &MaxMotionYLocation))
	{	// the 2 last parameters are passed by ref
		cs.Format("x: %d   y: %d", MaxMotionXLocation, MaxMotionYLocation);
		dlg_MotionDetection->m_edtMaxMotionCoord.SetWindowText(cs);
	}

	dlg_MotionDetection->m_mmoMotionGrid.SetWindowText(m_VideoGrabber.MotionDetector_Get2DTextMotion());

	HDC nDC = CreateCompatibleDC(0);
	HGDIOBJ OldBitmap = SelectObject(nDC, (HGDIOBJ)(FrameBitmapHandle));

	RECT rect;
	dlg_MotionDetection->m_imgMotionDetected.GetWindowRect(&rect);
	int ScaleWidth  = rect.right  - rect.left + 1;
	int ScaleHeight = rect.bottom - rect.top  + 1;

	StretchBlt(
		dlg_MotionDetection->m_imgMotionDetected.GetDC()->m_hDC, 0, 0,
		ScaleWidth,	 //? dlg_MotionDetection->m_imgMotionDetected.ScaleWidth, 
		ScaleHeight, //? dlg_MotionDetection->m_imgMotionDetected.ScaleHeight, 
		nDC, 0, 0, 
		m_VideoGrabber.GetVideoWidth(), m_VideoGrabber.GetVideoHeight(), 
		SRCCOPY);

	SelectObject(nDC, OldBitmap);
	DeleteDC(nDC);
}

void CMainForm::OnOnMotionNotDetectedVideograbbervc61(long FrameBitmapHandle, long FrameNumber, double FrameTime, long FrameId, BOOL FAR* CaptureFrame) 
{
	dlg_MotionDetection->m_edtMotionRatio.SetWindowText("");
	dlg_MotionDetection->m_mmoMotionGrid.SetWindowText(m_VideoGrabber.MotionDetector_Get2DTextMotion());
}

void CMainForm::OnOnMouseDownVideograbbervc61(long VideoWindow, long Button, long x, long y) 
{
	if (VideoWindow != -1)
	{	// if the video is displayed
		if (dlg_Overlays->m_chkFreeHandEnabled.GetCheck()==BST_CHECKED)
		{
			FreeHandMouseDrawing[iFreeHandMouseDrawing].left = x;
			FreeHandMouseDrawing[iFreeHandMouseDrawing].top  = y;
			FreeHandMouseDrawing[iFreeHandMouseDrawing].right = 0;	// Right is used as boolean to know if it is a MoveTo or a LineTo
			iFreeHandMouseDrawing++;
			FreeHandMouseDrawingEnabled = true;
		}
	}
}

void CMainForm::OnOnMouseMoveVideograbbervc61(long VideoWindow, long x, long y) 
{
	if (VideoWindow != -1)
	{	// if the video is displayed
		if (FreeHandMouseDrawingEnabled)
		{
			if (iFreeHandMouseDrawing < FreeHandMouseMax)
			{
				FreeHandMouseDrawing[iFreeHandMouseDrawing].left = x;
				FreeHandMouseDrawing[iFreeHandMouseDrawing].top  = y;
				FreeHandMouseDrawing[iFreeHandMouseDrawing].right = 1;	// Right is used as boolean to know if it is a MoveTo or a LineTo
				iFreeHandMouseDrawing++;
			}
		}
	}
}

void CMainForm::OnOnMouseUpVideograbbervc61(long VideoWindow, long Button, long x, long y) 
{
	FreeHandMouseDrawingEnabled = false;
}

void CMainForm::OnOnPlayerOpenedVideograbbervc61() 
{
	m_tbrPlayer.SetRangeMin(0, false);
	m_tbrPlayer.SetTicFreq(1);
	m_tbrPlayer.SetRangeMax((int)m_VideoGrabber.GetPlayerFrameCount(), true);
}

void CMainForm::OnOnPreviewStartedVideograbbervc61() 
{
	AddLog(&m_mmoLog, "");

	cs.Format("video size: %d x %d", m_VideoGrabber.GetVideoWidth(), m_VideoGrabber.GetVideoHeight());
	AddLog(&m_mmoLog, cs);

	cs.Format("display size: %d x %d", m_VideoGrabber.GetDisplay_VideoWidth(), m_VideoGrabber.GetDisplay_VideoHeight());
	AddLog(&m_mmoLog, cs);

	cs.Format("current frame rate: %.2lf fps.", m_VideoGrabber.GetCurrentFrameRate());
	AddLog(&m_mmoLog, cs);

	AddLog(&m_mmoLog, "");
}

void CMainForm::OnOnRecordingCompletedVideograbbervc61(LPCTSTR FileName, BOOL Success) 
{
	if (Success)
		AddLog(&m_mmoLog, " successfully created.");
	else
		AddLog(&m_mmoLog, "recording failed.");
	dlg_Recording->m_btnRenewRecordingFile.EnableWindow(false);
}

void CMainForm::OnOnRecordingReadyToStartVideograbbervc61() 
{
	if (AfxMessageBox("Ready to start recording!",MB_OKCANCEL)==IDOK)
		m_VideoGrabber.ResumeRecording();	// TOSEE
	else
		m_VideoGrabber.StopRecording();
}

void CMainForm::OnOnRecordingStartedVideograbbervc61(LPCTSTR FileName) 
{
	AddLog(&m_mmoLog, CString("recording to ") + CString(FileName) + ":");

	cs.Format("%d x %d", m_VideoGrabber.GetRecordingWidth(), m_VideoGrabber.GetRecordingHeight());
	AddLog(&m_mmoLog, cs);

	cs.Format("current frame rate: %.1lf fps.", m_VideoGrabber.GetCurrentFrameRate());
	AddLog(&m_mmoLog, cs);

	dlg_Recording->m_btnRenewRecordingFile.EnableWindow(true);
}

void CMainForm::OnOnReencodingCompletedVideograbbervc61(LPCTSTR SourceFile, LPCTSTR DestFile, BOOL Success) 
{
	if (Success)
		AddLog(&m_mmoLog, CString(" successfully reencoded to ") + CString(DestFile));
	else
		AddLog(&m_mmoLog, CString("Failed to reencode ") + CString(SourceFile) + CString(" to ") + CString(DestFile));
}

void CMainForm::OnOnReencodingProgressVideograbbervc61(long Percent, double Position, double Duration) 
{
	cs.Format("%d%% completed...", Percent);
	AddLog(&m_mmoLog, cs);
}

void CMainForm::OnOnReencodingStartedVideograbbervc61(LPCTSTR SourceFile, LPCTSTR DestFile) 
{
	AddLog(&m_mmoLog, CString("reencoding ") + CString(SourceFile) + CString(" to ") + CString(DestFile) + CString("..."));
}

void CMainForm::OnOnReinitializingVideograbbervc61() 
{
	m_mmoLog.SetWindowText("");
}

// TOSEE SendVCRCommand VideoGrabberDVCommandCompleted

// TOSEE VideoGrabberVideoFromBitmaps_NextFrameNeeded

void CMainForm::OnOnResizeVideograbbervc61() 
{
	if (! m_VideoGrabber) return;

	if (! m_VideoGrabber.m_hWnd) return;

//? ==== !!! Debug Needed !!! ===
	RECT rect;

	GetClientRect(&rect);

	long NewWidth, NewHeight;
	NewWidth  = rect.right + 5;	//? m_VideoGrabber.Left + m_VideoGrabber.Width  + 30;
	NewHeight = rect.bottom+ 5;	//? m_VideoGrabber.Top  + m_VideoGrabber.Height + 60;

	if (NewWidth  < StartupWidth)	NewWidth  = StartupWidth;
	if (NewHeight < StartupHeight)	NewHeight = StartupHeight;

//? ==== !!! Debug Needed !!! ===
	GetWindowRect(&rect);
	if ((NewWidth>=(rect.right - rect.left)) && (NewHeight>=(rect.bottom - rect.top))) {
		rect.right = rect.left	+ NewWidth;
		rect.bottom= rect.top	+ NewHeight;
		MoveWindow(&rect);
	}
}

void CMainForm::OnOnResizeVideoVideograbbervc61(long SourceWidth, long SourceHeight) 
{
	if (! m_VideoGrabber) return;
	m_VideoGrabber.SetTextOverlay_Right(SourceWidth);
	dlg_VideoProcessing->m_trkCroppingX.SetRangeMax(m_VideoGrabber.GetCropping_XMax());
	dlg_VideoProcessing->m_trkCroppingY.SetRangeMax(m_VideoGrabber.GetCropping_YMax());
}

void CMainForm::OnOnTVChannelScanCompletedVideograbbervc61() 
{
	AddLog(&Dlg_TVTuner->m_mmoChannelLog, "autoscan completed.");
}

void CMainForm::OnOnTVChannelScanStartedVideograbbervc61(long MinChannel, long MaxChannel) 
{
	CString InputType;
	switch(m_VideoGrabber.GetTVTunerInputType()) {
		case TunerInputCable:
            InputType = "cable input";
			break;
		case TunerInputAntenna:
            InputType = "antenna input";
			break;
	}
	cs.Format("scanning country code %d", m_VideoGrabber.GetTVCountryCode());
	cs += CString(" (") + InputType + ")";
	CString chan;
	chan.Format(" from channel %ld to %ld ...", MinChannel, MaxChannel);
	AddLog(&Dlg_TVTuner->m_mmoChannelLog, cs+chan);
}

void CMainForm::OnOnTVChannelSelectedVideograbbervc61(long Channel, BOOL Locked, long DefaultVideoFrequency, long OverriddenVideoFrequency, long TunerVideoFrequency, long TunerAudioFrequency) 
{
	CString sFrequencyInfo;
	if (Locked) {
		sFrequencyInfo.Format(" %ld: %.2f Mhz ( %ld Hz",
			Channel, (float)(TunerVideoFrequency / 1000000.), TunerVideoFrequency);
		if (OverriddenVideoFrequency!=-1)
			sFrequencyInfo += ", overridden";
		sFrequencyInfo += ")";
		AddLog(&Dlg_TVTuner->m_mmoChannelLog, sFrequencyInfo);
	} else {
		if (OverriddenVideoFrequency!=-1) {
			cs.Format(" %ld... overridden and not locked", Channel);
			AddLog(&Dlg_TVTuner->m_mmoChannelLog, cs);
		} else {
			cs.Format(" %ld...", Channel);
			AddLog(&Dlg_TVTuner->m_mmoChannelLog, cs);
		}
	}

	Dlg_TVTuner->m_edtTVChannel.SetWindowText(ToCString(Channel));
	if (OverriddenVideoFrequency != -1)
		Dlg_TVTuner->m_edtChannelFrequency.SetWindowText(ToCString(OverriddenVideoFrequency));
	else
		Dlg_TVTuner->m_edtChannelFrequency.SetWindowText(ToCString(TunerVideoFrequency));
}

void CMainForm::OnOnVideoDeviceSelectedVideograbbervc61() 
{
	AssignListToComboBox(&dlg_VideoSource->m_cboAnalogVideoStandard, m_VideoGrabber.GetAnalogVideoStandards(), m_VideoGrabber.GetAnalogVideoStandard());
	AssignListToComboBox(&dlg_VideoSource->m_cboVideoSizes, m_VideoGrabber.GetVideoSizes(), m_VideoGrabber.GetVideoSize());
	AssignListToComboBox(&dlg_VideoSource->m_cboVideoSubtypes, m_VideoGrabber.GetVideoSubtypes(), m_VideoGrabber.GetVideoSubtype());
	AssignListToComboBox(&dlg_VideoSource->m_cboVideoInputs, m_VideoGrabber.GetVideoInputs(), m_VideoGrabber.GetVideoInput());
	RefreshVideoDeviceControls();
	dlg_Display->RefreshDisplayOptions();
}

void CMainForm::OnOnVideoFromBitmapsNextFrameNeededVideograbbervc61(BOOL FirstSample, long FAR* BitmapHandle, BOOL FAR* CanFreeBitmapHandle, BSTR FAR* BMPorJPEGFile, BOOL FAR* EndOfData) 
{
	// you can pass to this event:
	// - either the path to a BMP file or a JPEG file (this is the case in this example)
	// - either a the HBITMAP handle of a bitmap
	*BMPorJPEGFile = 
		FileSearch_NextFile(
			m_VideoGrabber.GetStoragePath(),
			CString("*.jpg"), 
			FirstSample, 
			VideoFromBitmapSearch).AllocSysString();
    
	if (*BMPorJPEGFile == '\0') {
		AddLog(&m_mmoLog, "");
		AddLog(&m_mmoLog, "no bitmap files found in the StoragePath directory! Capture frames to BMP files first by using the frame grabber.");
	}
	
}

BEGIN_EVENTSINK_MAP(CMainForm, CDialog)
    //{{AFX_EVENTSINK_MAP(CMainForm)
	ON_EVENT(CMainForm, IDC_VIDEOGRABBERVC61, 201 /* OnResize */, OnOnResizeVideograbbervc61, VTS_NONE)
	ON_EVENT(CMainForm, IDC_VIDEOGRABBERVC61, 205 /* OnAudioDeviceSelected */, OnOnAudioDeviceSelectedVideograbbervc61, VTS_NONE)
	ON_EVENT(CMainForm, IDC_VIDEOGRABBERVC61, 213 /* OnCopyPreallocDataCompleted */, OnOnCopyPreallocDataCompletedVideograbbervc61, VTS_BSTR VTS_BSTR VTS_BOOL)
	ON_EVENT(CMainForm, IDC_VIDEOGRABBERVC61, 214 /* OnCopyPreallocDataProgress */, OnOnCopyPreallocDataProgressVideograbbervc61, VTS_I4 VTS_R8 VTS_R8)
	ON_EVENT(CMainForm, IDC_VIDEOGRABBERVC61, 215 /* OnCopyPreallocDataStarted */, OnOnCopyPreallocDataStartedVideograbbervc61, VTS_BSTR VTS_BSTR)
	ON_EVENT(CMainForm, IDC_VIDEOGRABBERVC61, 216 /* OnCreatePreallocFileCompleted */, OnOnCreatePreallocFileCompletedVideograbbervc61, VTS_BSTR VTS_BOOL)
	ON_EVENT(CMainForm, IDC_VIDEOGRABBERVC61, 217 /* OnCreatePreallocFileProgress */, OnOnCreatePreallocFileProgressVideograbbervc61, VTS_I4 VTS_R8 VTS_R8)
	ON_EVENT(CMainForm, IDC_VIDEOGRABBERVC61, 218 /* OnCreatePreallocFileStarted */, OnOnCreatePreallocFileStartedVideograbbervc61, VTS_BSTR)
	ON_EVENT(CMainForm, IDC_VIDEOGRABBERVC61, 219 /* OnDeviceArrivalOrRemoval */, OnOnDeviceArrivalOrRemovalVideograbbervc61, VTS_BOOL VTS_BOOL VTS_BSTR VTS_I4)
	ON_EVENT(CMainForm, IDC_VIDEOGRABBERVC61, 220 /* OnDeviceLost */, OnOnDeviceLostVideograbbervc61, VTS_NONE)
	ON_EVENT(CMainForm, IDC_VIDEOGRABBERVC61, 221 /* OnDirectNetworkStreamingHostUrl */, OnOnDirectNetworkStreamingHostUrlVideograbbervc61, VTS_BSTR VTS_BSTR VTS_I4)
	ON_EVENT(CMainForm, IDC_VIDEOGRABBERVC61, 222 /* OnDiskFull */, OnOnDiskFullVideograbbervc61, VTS_NONE)
	ON_EVENT(CMainForm, IDC_VIDEOGRABBERVC61, 223 /* OnDVDiscontinuity */, OnOnDVDiscontinuityVideograbbervc61, VTS_PBOOL)
	ON_EVENT(CMainForm, IDC_VIDEOGRABBERVC61, 224 /* OnDVCommandCompleted */, OnOnDVCommandCompletedVideograbbervc61, VTS_I4 VTS_BSTR)
	ON_EVENT(CMainForm, IDC_VIDEOGRABBERVC61, 228 /* OnFrameCaptureCompleted */, OnOnFrameCaptureCompletedVideograbbervc61, VTS_I4 VTS_I4 VTS_I4 VTS_I4 VTS_R8 VTS_I4 VTS_BSTR VTS_BOOL VTS_I4)
	ON_EVENT(CMainForm, IDC_VIDEOGRABBERVC61, 229 /* OnFrameOverlayUsingDC */, OnOnFrameOverlayUsingDCVideograbbervc61, VTS_I4 VTS_I4 VTS_R8 VTS_I4)
	ON_EVENT(CMainForm, IDC_VIDEOGRABBERVC61, 230 /* OnFrameOverlayUsingDIB */, OnOnFrameOverlayUsingDIBVideograbbervc61, VTS_I4 VTS_I4 VTS_R8 VTS_I4)
	ON_EVENT(CMainForm, IDC_VIDEOGRABBERVC61, 231 /* OnFrameProgress */, OnOnFrameProgressVideograbbervc61, VTS_I4 VTS_R8 VTS_I4)
	ON_EVENT(CMainForm, IDC_VIDEOGRABBERVC61, 232 /* OnInactive */, OnOnInactiveVideograbbervc61, VTS_NONE)
	ON_EVENT(CMainForm, IDC_VIDEOGRABBERVC61, 237 /* OnLog */, OnOnLogVideograbbervc61, VTS_I4 VTS_BSTR VTS_BSTR)
	ON_EVENT(CMainForm, IDC_VIDEOGRABBERVC61, 238 /* OnMotionDetected */, OnOnMotionDetectedVideograbbervc61, VTS_R8 VTS_I4 VTS_I4 VTS_I4 VTS_I4 VTS_R8 VTS_I4 VTS_PBOOL)
	ON_EVENT(CMainForm, IDC_VIDEOGRABBERVC61, 239 /* OnMotionNotDetected */, OnOnMotionNotDetectedVideograbbervc61, VTS_I4 VTS_I4 VTS_R8 VTS_I4 VTS_PBOOL)
	ON_EVENT(CMainForm, IDC_VIDEOGRABBERVC61, 240 /* OnMouseDown */, OnOnMouseDownVideograbbervc61, VTS_I4 VTS_I4 VTS_I4 VTS_I4)
	ON_EVENT(CMainForm, IDC_VIDEOGRABBERVC61, 241 /* OnMouseMove */, OnOnMouseMoveVideograbbervc61, VTS_I4 VTS_I4 VTS_I4)
	ON_EVENT(CMainForm, IDC_VIDEOGRABBERVC61, 242 /* OnMouseUp */, OnOnMouseUpVideograbbervc61, VTS_I4 VTS_I4 VTS_I4 VTS_I4)
	ON_EVENT(CMainForm, IDC_VIDEOGRABBERVC61, 247 /* OnPlayerEndOfStream */, OnOnPlayerEndOfStreamVideograbbervc61, VTS_NONE)
	ON_EVENT(CMainForm, IDC_VIDEOGRABBERVC61, 248 /* OnPlayerOpened */, OnOnPlayerOpenedVideograbbervc61, VTS_NONE)
	ON_EVENT(CMainForm, IDC_VIDEOGRABBERVC61, 240 /* OnPreviewStarted */, OnOnPreviewStartedVideograbbervc61, VTS_NONE)
	ON_EVENT(CMainForm, IDC_VIDEOGRABBERVC61, 255 /* OnRecordingCompleted */, OnOnRecordingCompletedVideograbbervc61, VTS_BSTR VTS_BOOL)
	ON_EVENT(CMainForm, IDC_VIDEOGRABBERVC61, 257 /* OnRecordingReadyToStart */, OnOnRecordingReadyToStartVideograbbervc61, VTS_NONE)
	ON_EVENT(CMainForm, IDC_VIDEOGRABBERVC61, 258 /* OnRecordingStarted */, OnOnRecordingStartedVideograbbervc61, VTS_BSTR)
	ON_EVENT(CMainForm, IDC_VIDEOGRABBERVC61, 259 /* OnReencodingCompleted */, OnOnReencodingCompletedVideograbbervc61, VTS_BSTR VTS_BSTR VTS_BOOL)
	ON_EVENT(CMainForm, IDC_VIDEOGRABBERVC61, 260 /* OnReencodingProgress */, OnOnReencodingProgressVideograbbervc61, VTS_I4 VTS_R8 VTS_R8)
	ON_EVENT(CMainForm, IDC_VIDEOGRABBERVC61, 261 /* OnReencodingStarted */, OnOnReencodingStartedVideograbbervc61, VTS_BSTR VTS_BSTR)
	ON_EVENT(CMainForm, IDC_VIDEOGRABBERVC61, 262 /* OnReinitializing */, OnOnReinitializingVideograbbervc61, VTS_NONE)
	ON_EVENT(CMainForm, IDC_VIDEOGRABBERVC61, 263 /* OnResizeVideo */, OnOnResizeVideoVideograbbervc61, VTS_I4 VTS_I4)
	ON_EVENT(CMainForm, IDC_VIDEOGRABBERVC61, 264 /* OnTVChannelScanCompleted */, OnOnTVChannelScanCompletedVideograbbervc61, VTS_NONE)
	ON_EVENT(CMainForm, IDC_VIDEOGRABBERVC61, 265 /* OnTVChannelScanStarted */, OnOnTVChannelScanStartedVideograbbervc61, VTS_I4 VTS_I4)
	ON_EVENT(CMainForm, IDC_VIDEOGRABBERVC61, 266 /* OnTVChannelSelected */, OnOnTVChannelSelectedVideograbbervc61, VTS_I4 VTS_BOOL VTS_I4 VTS_I4 VTS_I4 VTS_I4)
	ON_EVENT(CMainForm, IDC_VIDEOGRABBERVC61, 268 /* OnVideoDeviceSelected */, OnOnVideoDeviceSelectedVideograbbervc61, VTS_NONE)
	ON_EVENT(CMainForm, IDC_VIDEOGRABBERVC61, 269 /* OnVideoFromBitmapsNextFrameNeeded */, OnOnVideoFromBitmapsNextFrameNeededVideograbbervc61, VTS_BOOL VTS_PI4 VTS_PBOOL VTS_PBSTR VTS_PBOOL)
	//}}AFX_EVENTSINK_MAP
END_EVENTSINK_MAP()




void CMainForm::OnOnPlayerEndOfStreamVideograbbervc61() 
{
	AddLog(&m_mmoLog, "end of stream.");
}
