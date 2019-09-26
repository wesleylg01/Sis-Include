// VideoSource.cpp : implementation file
//

#include "stdafx.h"
#include "MainDemo.h"
#include "VideoSource.h"
#include "MainForm.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CVideoSource dialog

CVideoSource::CVideoSource(CWnd* pParent /*=NULL*/)
	: CDialog(CVideoSource::IDD, pParent)
{
	//{{AFX_DATA_INIT(CVideoSource)
		// NOTE: the ClassWizard will add member initialization here
	//}}AFX_DATA_INIT
}

void CVideoSource::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CVideoSource)
		// NOTE: the ClassWizard will add DDX and DDV calls here
	DDX_Control(pDX, cboVideoSource, m_cboVideoSource);
	DDX_Control(pDX, grbPreview, m_grbPreview);
	DDX_Control(pDX, btnStartPreview, m_btnStartPreview);
	DDX_Control(pDX, btnStopPreview, m_btnStopPreview);
	DDX_Control(pDX, grbFrameRate, m_grbFrameRate);
	DDX_Control(pDX, btnFrameRate, m_btnFrameRate);
	DDX_Control(pDX, edtFrameRate, m_edtFrameRate);
	DDX_Control(pDX, grbVsVideoCaptureDevice, m_grbVsVideoCaptureDevice);
	DDX_Control(pDX, cboVideoDevices, m_cboVideoDevices);
	DDX_Control(pDX, cboVideoInputs, m_cboVideoInputs);
	DDX_Control(pDX, cboVideoSizes, m_cboVideoSizes);
	DDX_Control(pDX, cboVideoSubtypes, m_cboVideoSubtypes);
	DDX_Control(pDX, cboAnalogVideoStandard, m_cboAnalogVideoStandard);
	DDX_Control(pDX, chkReduceDVFrameRate, m_chkReduceDVFrameRate);
	DDX_Control(pDX, grbVsFileOrUrl, m_grbVsFileOrUrl);
	DDX_Control(pDX, btnSelectFileOrUrl, m_btnSelectFileOrUrl);
	DDX_Control(pDX, edtVideoSourceFileOrUrl, m_edtVideoSourceFileOrUrl);
	DDX_Control(pDX, grbVsScreenRecording, m_grbVsScreenRecording);
	DDX_Control(pDX, chkScreenRecordingWithCursor, m_chkScreenRecordingWithCursor);
	DDX_Control(pDX, grbPreferredVideoSizes, m_grbPreferredVideoSizes);
	DDX_Control(pDX, rdgPreferredVideoSize1, m_rdgPreferredVideoSize1);
	DDX_Control(pDX, rdgPreferredVideoSize2, m_rdgPreferredVideoSize2);
	DDX_Control(pDX, rdgPreferredVideoSize3, m_rdgPreferredVideoSize3);
	DDX_Control(pDX, rdgPreferredVideoSize4, m_rdgPreferredVideoSize4);
	DDX_Control(pDX, rdgPreferredVideoSize5, m_rdgPreferredVideoSize5);
	DDX_Control(pDX, rdgPreferredVideoSize6, m_rdgPreferredVideoSize6);
	DDX_Control(pDX, rdgPreferredVideoSize7, m_rdgPreferredVideoSize7);
	DDX_Control(pDX, rdgPreferredVideoSize8, m_rdgPreferredVideoSize8);
	DDX_Control(pDX, rdgPreferredVideoSize9, m_rdgPreferredVideoSize9);
	DDX_Control(pDX, rdgPreferredVideoSize10, m_rdgPreferredVideoSize10);
	DDX_Control(pDX, rdgPreferredVideoSize11, m_rdgPreferredVideoSize11);
	DDX_Control(pDX, chkStretchPreferredVideoSize, m_chkStretchPreferredVideoSize);
	DDX_Control(pDX, rdgPreferredVideoSize12, m_rdgPreferredVideoSize12);
	DDX_Control(pDX, rdgPreferredVideoSize13, m_rdgPreferredVideoSize13);
	DDX_Control(pDX, grbVideoDevicesDialogs, m_grbVideoDevicesDialogs);
	DDX_Control(pDX, btnDeviceDialog, m_btnDeviceDialog);
	DDX_Control(pDX, btnStreamDialog, m_btnStreamDialog);
	DDX_Control(pDX, btnCameraControlDialog, m_btnCameraControlDialog);
	DDX_Control(pDX, btnVideoQualityDialog, m_btnVideoQualityDialog);
	DDX_Control(pDX, btnVideoControlDialog, m_btnVideoControlDialog);
	DDX_Control(pDX, btnAutoRefreshPreview, m_btnAutoRefreshPreview);
	//}}AFX_DATA_MAP
}

BEGIN_MESSAGE_MAP(CVideoSource, CDialog)
	//{{AFX_MSG_MAP(CVideoSource)
	ON_BN_CLICKED(btnAutoRefreshPreview, OnbtnAutoRefreshPreview)
	ON_BN_CLICKED(btnDeviceDialog, OnbtnDeviceDialog)
	ON_BN_CLICKED(btnFrameRate, OnbtnFrameRate)
	ON_BN_CLICKED(btnSelectFileOrUrl, OnbtnSelectFileOrUrl)
	ON_BN_CLICKED(btnStartPreview, OnbtnStartPreview)
	ON_BN_CLICKED(btnStopPreview, OnbtnStopPreview)
	ON_BN_CLICKED(btnStreamDialog, OnbtnStreamDialog)
	ON_CBN_SELCHANGE(cboVideoSource, OnSelchangecboVideoSource)
	ON_CBN_SELCHANGE(cboAnalogVideoStandard, OnSelchangecboAnalogVideoStandard)
	ON_CBN_SELCHANGE(cboVideoDevices, OnSelchangecboVideoDevices)
	ON_CBN_SELCHANGE(cboVideoInputs, OnSelchangecboVideoInputs)
	ON_CBN_SELCHANGE(cboVideoSizes, OnSelchangecboVideoSizes)
	ON_CBN_SELCHANGE(cboVideoSubtypes, OnSelchangecboVideoSubtypes)
	ON_BN_CLICKED(chkReduceDVFrameRate, OnchkReduceDVFrameRate)
	ON_BN_CLICKED(chkScreenRecordingWithCursor, OnchkScreenRecordingWithCursor)
	ON_EN_CHANGE(edtVideoSourceFileOrUrl, OnChangeedtVideoSourceFileOrUrl)
	ON_WM_CLOSE()
	ON_BN_CLICKED(rdgPreferredVideoSize1, OnrdgPreferredVideoSize1)
	ON_BN_CLICKED(rdgPreferredVideoSize2, OnrdgPreferredVideoSize2)
	ON_BN_CLICKED(rdgPreferredVideoSize3, OnrdgPreferredVideoSize3)
	ON_BN_CLICKED(rdgPreferredVideoSize4, OnrdgPreferredVideoSize4)
	ON_BN_CLICKED(rdgPreferredVideoSize5, OnrdgPreferredVideoSize5)
	ON_BN_CLICKED(rdgPreferredVideoSize6, OnrdgPreferredVideoSize6)
	ON_BN_CLICKED(rdgPreferredVideoSize7, OnrdgPreferredVideoSize7)
	ON_BN_CLICKED(rdgPreferredVideoSize8, OnrdgPreferredVideoSize8)
	ON_BN_CLICKED(rdgPreferredVideoSize9, OnrdgPreferredVideoSize9)
	ON_BN_CLICKED(rdgPreferredVideoSize10, OnrdgPreferredVideoSize10)
	ON_BN_CLICKED(rdgPreferredVideoSize11, OnrdgPreferredVideoSize11)
	ON_BN_CLICKED(rdgPreferredVideoSize12, OnrdgPreferredVideoSize12)
	ON_BN_CLICKED(rdgPreferredVideoSize13, OnrdgPreferredVideoSize13)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CVideoSource message handlers

BOOL CVideoSource::OnInitDialog()
{
	CDialog::OnInitDialog();

	m_edtFrameRate	.SetWindowText("0");
	m_edtVideoSourceFileOrUrl	.SetWindowText("mms://www.datastead.com/demo/demo.wmv");
	m_rdgPreferredVideoSize1	.SetCheck(BST_CHECKED);

	return TRUE;
}

void CVideoSource::OnbtnAutoRefreshPreview() 
{
	dlg_MainForm->m_VideoGrabber.SetAutoRefreshPreview(m_btnAutoRefreshPreview.GetCheck()==BST_CHECKED);
}

void CVideoSource::OnbtnDeviceDialog() 
{
	dlg_MainForm->m_VideoGrabber.ShowDialog (dlg_VideoDevice);
	dlg_MainForm->RefreshVideoDeviceControls();
}

void CVideoSource::OnbtnFrameRate()
{
	char buf[100];
	m_edtFrameRate.GetWindowText(buf,sizeof(buf));
	double value;
	if (1==sscanf(buf,"%lf",&value))
		dlg_MainForm->m_VideoGrabber.SetFrameRate(value);

	if (dlg_MainForm->m_VideoGrabber.GetCurrentState()==cs_Preview) {
		cs.Format("current frame rate: %.2lf fps.", dlg_MainForm->m_VideoGrabber.GetCurrentFrameRate());
		AddLog(&dlg_MainForm->m_mmoLog, cs);
	}
}

void CVideoSource::OnbtnSelectFileOrUrl() 
{
	CString sFilter = "All Video Files|*.mpg;*.mpeg;*.vro;*.avi;*.wav;*.asf;*.wmv;*.vob|";
	CFileDialog dlg(TRUE, 0, 0, OFN_FILEMUSTEXIST|OFN_ENABLESIZING|OFN_HIDEREADONLY, sFilter);
	if (dlg.DoModal()!=IDOK) return;
	m_edtVideoSourceFileOrUrl.SetWindowText(dlg.GetPathName());
}

void CVideoSource::OnbtnStartPreview() 
{
	dlg_MainForm->m_VideoGrabber.StartPreview();
}

void CVideoSource::OnbtnStopPreview() 
{
	dlg_MainForm->m_VideoGrabber.StopPreview();
}

void CVideoSource::OnbtnStreamDialog() 
{
	// WARNING: USUALLY, THIS DIALOG ALLOWS TO CHANGE ONLY 1 PARAMETER AT THE SAME TIME
	dlg_MainForm->m_VideoGrabber.ShowDialog (dlg_StreamConfig);
	dlg_MainForm->OnOnVideoDeviceSelectedVideograbbervc61();	// to refresh the controls, if required
}

void CVideoSource::OnSelchangecboVideoSource() 
{
	dlg_MainForm->m_VideoGrabber.SetVideoSource(m_cboVideoSource.GetCurSel());
}

void CVideoSource::OnSelchangecboAnalogVideoStandard() 
{
	dlg_MainForm->m_VideoGrabber.SetAnalogVideoStandard(m_cboAnalogVideoStandard.GetCurSel());
}

void CVideoSource::OnSelchangecboVideoDevices() 
{
	dlg_MainForm->m_VideoGrabber.SetVideoDevice(m_cboVideoDevices.GetCurSel());
	// when selecting another video device, the OnVideoDeviceSelected event occurs.
	// be sure to refresh all your device-dependent controls from this event.
}

void CVideoSource::OnSelchangecboVideoInputs() 
{
	dlg_MainForm->m_VideoGrabber.SetVideoInput(m_cboVideoInputs.GetCurSel());
}

void CVideoSource::OnSelchangecboVideoSizes() 
{
	dlg_MainForm->m_VideoGrabber.SetVideoSize(m_cboVideoSizes.GetCurSel());
}

void CVideoSource::OnSelchangecboVideoSubtypes() 
{
	dlg_MainForm->m_VideoGrabber.SetVideoSubtype(m_cboVideoSubtypes.GetCurSel());
}

void CVideoSource::OnchkReduceDVFrameRate() 
{
	dlg_MainForm->m_VideoGrabber.SetDVReduceFrameRate(m_chkReduceDVFrameRate.GetCheck()==BST_CHECKED);
}

void CVideoSource::OnchkScreenRecordingWithCursor() 
{
	dlg_MainForm->m_VideoGrabber.SetScreenRecordingWithCursor(m_chkScreenRecordingWithCursor.GetCheck()==BST_CHECKED);
}

void CVideoSource::OnChangeedtVideoSourceFileOrUrl() 
{
	m_edtVideoSourceFileOrUrl.GetWindowText(cs);
	dlg_MainForm->m_VideoGrabber.SetVideoSource_FileOrURL(cs);
}

void CVideoSource::OnClose() 
{
//?   If Not dlg_MainForm.CanUnload Then
//?      Hide
//?      Cancel = True
//?   End If

	CDialog::OnClose();
}

void CVideoSource::OnrdgPreferredVideoSize1() 
{
	dlg_MainForm->m_VideoGrabber.UseNearestVideoSize(0, 0, m_chkStretchPreferredVideoSize.GetCheck()==BST_CHECKED);	// disables the nearest size feature, uses the device's VideoSize index in the VideoSizes list
	m_cboVideoSizes.EnableWindow(true);
}

void CVideoSource::OnrdgPreferredVideoSize2() 
{
	dlg_MainForm->m_VideoGrabber.UseNearestVideoSize(88, 60, m_chkStretchPreferredVideoSize.GetCheck()==BST_CHECKED);
	m_cboVideoSizes.EnableWindow(false);
}

void CVideoSource::OnrdgPreferredVideoSize3() 
{
	dlg_MainForm->m_VideoGrabber.UseNearestVideoSize(88, 72, m_chkStretchPreferredVideoSize.GetCheck()==BST_CHECKED);
	m_cboVideoSizes.EnableWindow(false);
}

void CVideoSource::OnrdgPreferredVideoSize4() 
{
	dlg_MainForm->m_VideoGrabber.UseNearestVideoSize(180, 120, m_chkStretchPreferredVideoSize.GetCheck()==BST_CHECKED);
	m_cboVideoSizes.EnableWindow(false);
}

void CVideoSource::OnrdgPreferredVideoSize5() 
{
	dlg_MainForm->m_VideoGrabber.UseNearestVideoSize(180, 144, m_chkStretchPreferredVideoSize.GetCheck()==BST_CHECKED);
	m_cboVideoSizes.EnableWindow(false);
}

void CVideoSource::OnrdgPreferredVideoSize6() 
{
	dlg_MainForm->m_VideoGrabber.UseNearestVideoSize(320, 240, m_chkStretchPreferredVideoSize.GetCheck()==BST_CHECKED);
	m_cboVideoSizes.EnableWindow(false);
}

void CVideoSource::OnrdgPreferredVideoSize7() 
{
	dlg_MainForm->m_VideoGrabber.UseNearestVideoSize(352, 288, m_chkStretchPreferredVideoSize.GetCheck()==BST_CHECKED);
	m_cboVideoSizes.EnableWindow(false);
}

void CVideoSource::OnrdgPreferredVideoSize8() 
{
	dlg_MainForm->m_VideoGrabber.UseNearestVideoSize(360, 240, m_chkStretchPreferredVideoSize.GetCheck()==BST_CHECKED);
	m_cboVideoSizes.EnableWindow(false);
}

void CVideoSource::OnrdgPreferredVideoSize9() 
{
	dlg_MainForm->m_VideoGrabber.UseNearestVideoSize(360, 288, m_chkStretchPreferredVideoSize.GetCheck()==BST_CHECKED);
	m_cboVideoSizes.EnableWindow(false);
}

void CVideoSource::OnrdgPreferredVideoSize10() 
{
	dlg_MainForm->m_VideoGrabber.UseNearestVideoSize(640, 480, m_chkStretchPreferredVideoSize.GetCheck()==BST_CHECKED);
	m_cboVideoSizes.EnableWindow(false);
}

void CVideoSource::OnrdgPreferredVideoSize11() 
{
	dlg_MainForm->m_VideoGrabber.UseNearestVideoSize(720, 480, m_chkStretchPreferredVideoSize.GetCheck()==BST_CHECKED);
	m_cboVideoSizes.EnableWindow(false);
}

void CVideoSource::OnrdgPreferredVideoSize12() 
{
	dlg_MainForm->m_VideoGrabber.UseNearestVideoSize(720, 576, m_chkStretchPreferredVideoSize.GetCheck()==BST_CHECKED);
	m_cboVideoSizes.EnableWindow(false);
}

void CVideoSource::OnrdgPreferredVideoSize13() 
{
	dlg_MainForm->m_VideoGrabber.UseNearestVideoSize(768, 576, m_chkStretchPreferredVideoSize.GetCheck()==BST_CHECKED);
	m_cboVideoSizes.EnableWindow(false);
}
