// Reencoding.cpp : implementation file
//

#include "stdafx.h"
#include "MainDemo.h"
#include "Reencoding.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CReencoding dialog

CReencoding::CReencoding(CWnd* pParent /*=NULL*/)
	: CDialog(CReencoding::IDD, pParent)
{
	//{{AFX_DATA_INIT(CReencoding)
		// NOTE: the ClassWizard will add member initialization here
	//}}AFX_DATA_INIT
}

void CReencoding::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CReencoding)
		// NOTE: the ClassWizard will add DDX and DDV calls here
	DDX_Control(pDX, btnStopReencoding, m_btnStopReencoding);
	DDX_Control(pDX, btnStartReencoding, m_btnStartReencoding);
	DDX_Control(pDX, rdgReencodingMethod, m_rdgReencodingMethod);
	DDX_Control(pDX, rdgReencodingMethod1, m_rdgReencodingMethod1);
	DDX_Control(pDX, rdgReencodingMethod2, m_rdgReencodingMethod2);
	DDX_Control(pDX, grbReencodingSettings, m_grbReencodingSettings);
	DDX_Control(pDX, chkWMVOutput, m_chkWMVOutput);
	DDX_Control(pDX, chkUseFrameGrabber, m_chkUseFrameGrabber);
	DDX_Control(pDX, chkIncludeAudioStream, m_chkIncludeAudioStream);
	DDX_Control(pDX, chkUseCurrentVideoCompressor, m_chkUseCurrentVideoCompressor);
	DDX_Control(pDX, chkIncludeVideoStream, m_chkIncludeVideoStream);
	DDX_Control(pDX, chkUseCurrentAudioCompressor, m_chkUseCurrentAudioCompressor);
	DDX_Control(pDX, grbStartStopTime, m_grbStartStopTime);
	DDX_Control(pDX, edtDuration, m_edtDuration);
	DDX_Control(pDX, edtStartTime, m_edtStartTime);
	DDX_Control(pDX, edtStopTime, m_edtStopTime);
	DDX_Control(pDX, btnDuration, m_btnDuration);
	DDX_Control(pDX, edtDestinationVideoClip, m_edtDestinationVideoClip);
	DDX_Control(pDX, edtSourceVideoClip, m_edtSourceVideoClip);
	DDX_Control(pDX, btnSourceVideoClip, m_btnSourceVideoClip);
	//}}AFX_DATA_MAP
}

BEGIN_MESSAGE_MAP(CReencoding, CDialog)
	//{{AFX_MSG_MAP(CReencoding)
	ON_BN_CLICKED(btnDuration, OnbtnDuration)
	ON_BN_CLICKED(btnSourceVideoClip, OnbtnSourceVideoClip)
	ON_BN_CLICKED(btnStartReencoding, OnbtnStartReencoding)
	ON_BN_CLICKED(btnStopReencoding, OnbtnStopReencoding)
	ON_WM_CLOSE()
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CReencoding message handlers

BOOL CReencoding::OnInitDialog()
{
	CDialog::OnInitDialog();

	m_edtStartTime	.SetWindowText("-1");
	m_edtStopTime	.SetWindowText("-1");
	m_edtDestinationVideoClip	.SetWindowText("c:\\TVideoGrabberEval\\capture.wmv");
	m_edtSourceVideoClip	.SetWindowText("http://www.datastead.com/demo/demo.mpg");

	return TRUE;
}

void CReencoding::OnbtnDuration()
{
	double Duration, FrameCount;
	CString AVIFile;
	m_edtSourceVideoClip.GetWindowText(AVIFile);
	if (dlg_MainForm->m_VideoGrabber.AVIDuration(AVIFile, &Duration, &FrameCount)) {
		cs.Format("%lf", Duration);
		m_edtDuration.SetWindowText(cs);
	}
}

void CReencoding::OnbtnSourceVideoClip()
{
	m_edtSourceVideoClip.SetWindowText("");
	CString sFilter = "All Video Files|*.mpg;*.mpeg;*.vro;*.avi;*.wav;*.asf;*.wmv;*.vob|";
	CFileDialog dlg(TRUE, 0, 0, OFN_FILEMUSTEXIST|OFN_ENABLESIZING|OFN_HIDEREADONLY, sFilter);
	if (dlg.DoModal()!=IDOK) return;
	m_edtSourceVideoClip.SetWindowText(dlg.GetPathName());
}

void CReencoding::OnbtnStartReencoding()
{
	m_edtSourceVideoClip.GetWindowText(cs);
	dlg_MainForm->m_VideoGrabber.SetReencoding_SourceVideoClip(cs);

	m_edtDestinationVideoClip.GetWindowText(cs);
	dlg_MainForm->m_VideoGrabber.SetReencoding_NewVideoClip(cs);

	dlg_MainForm->m_VideoGrabber.SetReencoding_WMVOutput(m_chkWMVOutput.GetCheck()==BST_CHECKED);
	dlg_MainForm->m_VideoGrabber.SetReencoding_IncludeVideoStream(m_chkIncludeVideoStream.GetCheck()==BST_CHECKED);
	dlg_MainForm->m_VideoGrabber.SetReencoding_IncludeAudioStream(m_chkIncludeAudioStream.GetCheck()==BST_CHECKED);
	dlg_MainForm->m_VideoGrabber.SetReencoding_UseFrameGrabber(m_chkUseFrameGrabber.GetCheck()==BST_CHECKED);
	dlg_MainForm->m_VideoGrabber.SetReencoding_UseVideoCompressor(m_chkUseCurrentVideoCompressor.GetCheck()==BST_CHECKED);
	dlg_MainForm->m_VideoGrabber.SetReencoding_UseAudioCompressor(m_chkUseCurrentAudioCompressor.GetCheck()==BST_CHECKED);

	if (m_rdgReencodingMethod1.GetCheck()==BST_CHECKED)
		dlg_MainForm->m_VideoGrabber.SetReencoding_Method(rm_AVI);
    
	if (m_rdgReencodingMethod2.GetCheck()==BST_CHECKED)
		dlg_MainForm->m_VideoGrabber.SetReencoding_Method(rm_ASF);

	long StartTime, StopTime;
	if (IsNumeric(&m_edtStartTime,StartTime)) {
		dlg_MainForm->m_VideoGrabber.SetReencodingStartTime(StartTime);
	}

	if (IsNumeric(&m_edtStopTime,StopTime)) {
		dlg_MainForm->m_VideoGrabber.SetReencodingStopTime(StopTime);
	}

	dlg_MainForm->m_VideoGrabber.StartReencoding();
}

void CReencoding::OnbtnStopReencoding() 
{
	dlg_MainForm->m_VideoGrabber.StopReencoding();
}

void CReencoding::OnClose() 
{
//?   If Not dlg_MainForm.CanUnload Then
//?      Hide
//?      Cancel = True
//?   End If
	
	CDialog::OnClose();
}
