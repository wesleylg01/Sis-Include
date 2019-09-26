// Recording.cpp : implementation file
//

#include "stdafx.h"
#include "MainDemo.h"
#include "Recording.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CRecording dialog

CRecording::CRecording(CWnd* pParent /*=NULL*/)
	: CDialog(CRecording::IDD, pParent)
{
	//{{AFX_DATA_INIT(CRecording)
	//}}AFX_DATA_INIT
}

void CRecording::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CRecording)
	DDX_Control(pDX, chkRecordingPauseCreatesNewFile, m_chkRecordingPauseCreatesNewFile);
	DDX_Control(pDX, btnMoreInfo, m_btnMoreInfo);
	DDX_Control(pDX, btnStartRecordingImmediately, m_btnStartRecordingImmediately);
	DDX_Control(pDX, btnStartRecordingControlled, m_btnStartRecordingControlled);
	DDX_Control(pDX, btnStopRecording, m_btnStopRecording);
	DDX_Control(pDX, btnRenewRecordingFile, m_btnRenewRecordingFile);
	DDX_Control(pDX, grbAVIPauseResume, m_grbAVIPauseResume);
	DDX_Control(pDX, chkRecordingCanPause, m_chkRecordingCanPause);
	DDX_Control(pDX, btnPauseRecording, m_btnPauseRecording);
	DDX_Control(pDX, btnResumeRecording, m_btnResumeRecording);
	DDX_Control(pDX, rdgCompressMode, m_rdgCompressMode);
	DDX_Control(pDX, rdgCompressMode1, m_rdgCompressMode1);
	DDX_Control(pDX, rdgCompressMode3, m_rdgCompressMode3);
	DDX_Control(pDX, rdgCompressMode2, m_rdgCompressMode2);
	DDX_Control(pDX, rdgCompressType, m_rdgCompressType);
	DDX_Control(pDX, rdgCompressType2, m_rdgCompressType2);
	DDX_Control(pDX, rdgCompressType3, m_rdgCompressType3);
	DDX_Control(pDX, rdgCompressType1, m_rdgCompressType1);
	DDX_Control(pDX, cboVideoCompressors, m_cboVideoCompressors);
	DDX_Control(pDX, btnVideoCompressorSettings, m_btnVideoCompressorSettings);
	DDX_Control(pDX, cboAudioCompressors, m_cboAudioCompressors);
	DDX_Control(pDX, btnAudioCompressorSettings, m_btnAudioCompressorSettings);
	DDX_Control(pDX, rdgRecordingMethod, m_rdgRecordingMethod);
	DDX_Control(pDX, rdgRecordingMethod1, m_rdgRecordingMethod1);
	DDX_Control(pDX, rdgRecordingMethod2, m_rdgRecordingMethod2);
	DDX_Control(pDX, chkAudioRecording, m_chkAudioRecording);
	DDX_Control(pDX, cboAudioFormats, m_cboAudioFormats);
	DDX_Control(pDX, chkPreserveNativeFormat, m_chkPreserveNativeFormat);
	DDX_Control(pDX, chkAVISaveToThisFile, m_chkAVISaveToThisFile);
	DDX_Control(pDX, edtRecordingFileName, m_edtRecordingFileName);
	DDX_Control(pDX, chkOpenDML, m_chkOpenDML);
	DDX_Control(pDX, chkPreallocFile, m_chkPreallocFile);
	DDX_Control(pDX, edtPreallocSize, m_edtPreallocSize);
	DDX_Control(pDX, btnCreatePreallocFileNow, m_btnCreatePreallocFileNow);
	//}}AFX_DATA_MAP
}

BEGIN_MESSAGE_MAP(CRecording, CDialog)
	//{{AFX_MSG_MAP(CRecording)
	ON_BN_CLICKED(btnAudioCompressorSettings, OnbtnAudioCompressorSettings)
	ON_BN_CLICKED(btnCreatePreallocFileNow, OnbtnCreatePreallocFileNow)
	ON_BN_CLICKED(btnPauseRecording, OnbtnPauseRecording)
	ON_BN_CLICKED(btnRenewRecordingFile, OnbtnRenewRecordingFile)
	ON_BN_CLICKED(btnResumeRecording, OnbtnResumeRecording)
	ON_BN_CLICKED(btnStartRecordingControlled, OnbtnStartRecordingControlled)
	ON_BN_CLICKED(btnStartRecordingImmediately, OnbtnStartRecordingImmediately)
	ON_BN_CLICKED(btnStopRecording, OnbtnStopRecording)
	ON_BN_CLICKED(btnVideoCompressorSettings, OnbtnVideoCompressorSettings)
	ON_CBN_SELCHANGE(cboAudioCompressors, OnSelchangecboAudioCompressors)
	ON_CBN_SELCHANGE(cboAudioFormats, OnSelchangecboAudioFormats)
	ON_CBN_SELCHANGE(cboVideoCompressors, OnSelchangecboVideoCompressors)
	ON_BN_CLICKED(chkAudioRecording, OnchkAudioRecording)
	ON_BN_CLICKED(chkOpenDML, OnchkOpenDML)
	ON_BN_CLICKED(chkPreallocFile, OnchkPreallocFile)
	ON_BN_CLICKED(chkPreserveNativeFormat, OnchkPreserveNativeFormat)
	ON_BN_CLICKED(chkRecordingCanPause, OnchkRecordingCanPause)
	ON_EN_CHANGE(edtPreallocSize, OnChangeedtPreallocSize)
	ON_WM_CLOSE()
	ON_BN_CLICKED(rdgCompressMode1, OnrdgCompressMode1)
	ON_BN_CLICKED(rdgCompressMode2, OnrdgCompressMode2)
	ON_BN_CLICKED(rdgCompressMode3, OnrdgCompressMode3)
	ON_BN_CLICKED(rdgCompressType1, OnrdgCompressType1)
	ON_BN_CLICKED(rdgCompressType2, OnrdgCompressType2)
	ON_BN_CLICKED(rdgCompressType3, OnrdgCompressType3)
	ON_BN_CLICKED(rdgRecordingMethod1, OnrdgRecordingMethod1)
	ON_BN_CLICKED(rdgRecordingMethod2, OnrdgRecordingMethod2)
	ON_BN_CLICKED(btnMoreInfo, OnbtnMoreInfo)
	ON_BN_CLICKED(rdgRecordingMethod3, OnrdgRecordingMethod3)
	ON_BN_CLICKED(chkRecordingPauseCreatesNewFile, OnchkRecordingPauseCreatesNewFile)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CRecording message handlers

BOOL CRecording::OnInitDialog()
{
	CDialog::OnInitDialog();

	m_edtRecordingFileName	.SetWindowText("CaptureFile01.wmv");
	m_edtPreallocSize	.SetWindowText("100");

	return TRUE;
}

void CRecording::OnbtnAudioCompressorSettings() 
{
	dlg_MainForm->m_VideoGrabber.ShowDialog (dlg_AudioCompressor);
}

void CRecording::OnbtnCreatePreallocFileNow() 
{
	dlg_MainForm->m_VideoGrabber.CreatePreallocCapFile();
}

void CRecording::OnbtnPauseRecording() 
{
	dlg_MainForm->m_VideoGrabber.PauseRecording();
}

void CRecording::OnbtnRenewRecordingFile() 
{
	if (m_chkAVISaveToThisFile.GetCheck()==BST_CHECKED) {
		m_edtRecordingFileName.GetWindowText(cs);
		dlg_MainForm->m_VideoGrabber.SetRecordingFileName(cs);
	} else {
		// keyword that indicates TVideoGrabber to generate a new recording file name automatically
		dlg_MainForm->m_VideoGrabber.SetRecordingFileName("");
	}
	dlg_MainForm->m_VideoGrabber.RecordToNewFileNow("", true);
}

void CRecording::OnbtnResumeRecording() 
{
	dlg_MainForm->m_VideoGrabber.ResumeRecording();
}

void CRecording::OnbtnStartRecordingControlled() 
{
	if (m_chkAVISaveToThisFile.GetCheck()==BST_CHECKED) {
		m_edtRecordingFileName.GetWindowText(cs);
		dlg_MainForm->m_VideoGrabber.SetRecordingFileName(cs);
	} else {
		dlg_MainForm->m_VideoGrabber.SetRecordingFileName("");
	  }

	dlg_MainForm->m_VideoGrabber.SetHoldRecording(true);
	dlg_MainForm->m_VideoGrabber.StartRecording();

	// Enabling HoldRecording prevents the recording to start when the recording graph is built.
	// after the OnRecordingReadyToStart event occurs, you can accurately start the
	// recording by invoking ResumeRecording.
}

void CRecording::OnbtnStartRecordingImmediately() 
{
	if (m_chkAVISaveToThisFile.GetCheck()==BST_CHECKED) {
		m_edtRecordingFileName.GetWindowText(cs);
		dlg_MainForm->m_VideoGrabber.SetRecordingFileName(cs);
	} else {
		dlg_MainForm->m_VideoGrabber.SetRecordingFileName("");
	}
	dlg_MainForm->m_VideoGrabber.SetHoldRecording(false);	// let's start recording as soon as the graph is built.
	dlg_MainForm->m_VideoGrabber.StartRecording();
}

void CRecording::OnbtnStopRecording() 
{
	dlg_MainForm->m_VideoGrabber.StopRecording();
}

void CRecording::OnbtnVideoCompressorSettings() 
{
	dlg_MainForm->m_VideoGrabber.ShowDialog (dlg_VideoCompressor);
}

void CRecording::OnSelchangecboAudioCompressors() 
{
	dlg_MainForm->m_VideoGrabber.SetAudioCompressor(m_cboAudioCompressors.GetCurSel());
}

void CRecording::OnSelchangecboAudioFormats() 
{
	dlg_MainForm->m_VideoGrabber.SetAudioFormat(m_cboAudioFormats.GetCurSel());
}

void CRecording::OnSelchangecboVideoCompressors() 
{
	dlg_MainForm->m_VideoGrabber.SetVideoCompressor(m_cboVideoCompressors.GetCurSel());
}

void CRecording::OnchkAudioRecording() 
{
	dlg_MainForm->m_VideoGrabber.SetAudioRecording(m_chkAudioRecording.GetCheck()==BST_CHECKED);
	dlg_MainForm->RefreshVideoDeviceControls();
}

void CRecording::OnchkOpenDML() 
{
	dlg_MainForm->m_VideoGrabber.SetAVIFormatOpenDML(m_chkOpenDML.GetCheck()==BST_CHECKED);
}

void CRecording::OnchkPreallocFile()
{
	dlg_MainForm->m_VideoGrabber.SetPreallocCapFileEnabled(m_chkPreallocFile.GetCheck()==BST_CHECKED);
}

void CRecording::OnchkPreserveNativeFormat() 
{
	dlg_MainForm->m_VideoGrabber.SetRecordingInNativeFormat(m_chkPreserveNativeFormat.GetCheck()==BST_CHECKED);
}

void CRecording::OnchkRecordingCanPause() 
{
	dlg_MainForm->m_VideoGrabber.SetRecordingCanPause(m_chkRecordingCanPause.GetCheck()==BST_CHECKED);
	dlg_MainForm->RefreshVideoDeviceControls();
}

void CRecording::OnchkRecordingPauseCreatesNewFile() 
{
	dlg_MainForm->m_VideoGrabber.SetRecordingPauseCreatesNewFile (m_chkRecordingPauseCreatesNewFile.GetCheck()==BST_CHECKED);
}

void CRecording::OnChangeedtPreallocSize() 
{
	long PreallocSize;
	if (IsNumeric(&m_edtPreallocSize,PreallocSize))
		dlg_MainForm->m_VideoGrabber.SetPreallocCapFileSizeInMB(PreallocSize);
}

void CRecording::OnClose() 
{
//?  If Not dlg_MainForm.CanUnload Then
//?      Hide
//?      Cancel = True
//?  End If
	
	CDialog::OnClose();
}

void CRecording::OnrdgCompressMode1() 
{
	dlg_MainForm->m_VideoGrabber.SetCompressionMode(cm_NoCompression);
	dlg_MainForm->RefreshVideoDeviceControls();
}

void CRecording::OnrdgCompressMode2() 
{
	dlg_MainForm->m_VideoGrabber.SetCompressionMode(cm_CompressOnTheFly);
	dlg_MainForm->RefreshVideoDeviceControls();
}

void CRecording::OnrdgCompressMode3() 
{
	dlg_MainForm->m_VideoGrabber.SetCompressionMode(cm_CompressAfterRecording);
	dlg_MainForm->RefreshVideoDeviceControls();
}

void CRecording::OnrdgCompressType1() 
{
	dlg_MainForm->m_VideoGrabber.SetCompressionType(ct_Video);
}

void CRecording::OnrdgCompressType2() 
{
	dlg_MainForm->m_VideoGrabber.SetCompressionType(ct_Audio);
}

void CRecording::OnrdgCompressType3() 
{
	dlg_MainForm->m_VideoGrabber.SetCompressionType(ct_AudioVideo);
}

void CRecording::OnrdgRecordingMethod1() 
{
	dlg_MainForm->m_VideoGrabber.SetRecordingMethod(rm_AVI);
	dlg_MainForm->RefreshVideoDeviceControls();
}

void CRecording::OnrdgRecordingMethod2() 
{
	dlg_MainForm->m_VideoGrabber.SetRecordingMethod(rm_ASF);
	dlg_MainForm->RefreshVideoDeviceControls();
}

void CRecording::OnrdgRecordingMethod3() 
{
	dlg_MainForm->m_VideoGrabber.SetRecordingMethod(rm_SendToDV);
	dlg_MainForm->RefreshVideoDeviceControls();
	
}

void CRecording::OnbtnMoreInfo() 
{
	CString Msg;

	Msg += "Means that the recording stream will not be uncompressed.\n";
	Msg += "\n";
	Msg += "MUST BE ENABLED:\n";
	Msg += "- to record hardware-encoded MPEG\n";
	Msg += "- to record or DV devices in native DV format\n";
	Msg += "- to record the DV date/time into the video clip and retrieve it during playback\n";
	Msg += "\n";
	Msg += "MUST BE DISABLED:\n";
	Msg += "- to record the text and graphics overlays into the video clip, and retrieve them during playback\n";

	MessageBox (Msg, "RecordingInNativeFormat", 0);
	
}


