// FrameGrabber.cpp : implementation file
//

#include "stdafx.h"
#include "MainDemo.h"
#include "FrameGrabber.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CFrameGrabber dialog

CFrameGrabber::CFrameGrabber(CWnd* pParent /*=NULL*/)
	: CDialog(CFrameGrabber::IDD, pParent)
{
	//{{AFX_DATA_INIT(CFrameGrabber)
		// NOTE: the ClassWizard will add member initialization here
	//}}AFX_DATA_INIT
}

void CFrameGrabber::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CFrameGrabber)
		// NOTE: the ClassWizard will add DDX and DDV calls here
	DDX_Control(pDX, mmoFrameCaptureLog, m_mmoFrameCaptureLog);
	DDX_Control(pDX, btnResetCaptureZoomSize, m_btnResetCaptureZoomSize);
	DDX_Control(pDX, edtCaptureZoomSize, m_edtCaptureZoomSize);
	DDX_Control(pDX, tbrCaptureZoomSize, m_tbrCaptureZoomSize);
	DDX_Control(pDX, rdgAutoFileName, m_rdgAutoFileName);
	DDX_Control(pDX, edtAVIAutoFilePrefix, m_edtAVIAutoFilePrefix);
	DDX_Control(pDX, rdgAutoFileName1, m_rdgAutoFileName1);
	DDX_Control(pDX, rdgAutoFileName2, m_rdgAutoFileName2);
	DDX_Control(pDX, grbBurstMode, m_grbBurstMode);
	DDX_Control(pDX, btnBurstModeStop, m_btnBurstModeStop);
	DDX_Control(pDX, btnBurstModeJPEGFile, m_btnBurstModeJPEGFile);
	DDX_Control(pDX, btnBurstModeBMPFile, m_btnBurstModeBMPFile);
	DDX_Control(pDX, btnBurstModeTBitmap, m_btnBurstModeTBitmap);
	DDX_Control(pDX, edtBurstCount, m_edtBurstCount);
	DDX_Control(pDX, edtBurstInterval, m_edtBurstInterval);
	DDX_Control(pDX, grbOneShot, m_grbOneShot);
	DDX_Control(pDX, chkUseThisFileName, m_chkUseThisFileName);
	DDX_Control(pDX, edtUseThisFileName, m_edtUseThisFileName);
	DDX_Control(pDX, btnOneShotTBitmap, m_btnOneShotTBitmap);
	DDX_Control(pDX, btnOneShotBMPFile, m_btnOneShotBMPFile);
	DDX_Control(pDX, btnOneShotJPEGFile, m_btnOneShotJPEGFile);
	DDX_Control(pDX, rgdFrameGrabberFormat, m_rgdFrameGrabberFormat);
	DDX_Control(pDX, rgdFrameGrabberFormat1, m_rgdFrameGrabberFormat1);
	DDX_Control(pDX, rgdFrameGrabberFormat2, m_rgdFrameGrabberFormat2);
	DDX_Control(pDX, rgdFrameGrabberFormat3, m_rgdFrameGrabberFormat3);
	DDX_Control(pDX, rgdFrameGrabberFormat4, m_rgdFrameGrabberFormat4);
	DDX_Control(pDX, rgdFrameGrabberFormat5, m_rgdFrameGrabberFormat5);
	DDX_Control(pDX, rgdFrameGrabberFormat6, m_rgdFrameGrabberFormat6);
	DDX_Control(pDX, rgdFrameGrabber, m_rgdFrameGrabber);
	DDX_Control(pDX, rgdFrameGrabber1, m_rgdFrameGrabber1);
	DDX_Control(pDX, rgdFrameGrabber2, m_rgdFrameGrabber2);
	DDX_Control(pDX, rgdFrameGrabber3, m_rgdFrameGrabber3);
	DDX_Control(pDX, rgdFrameGrabber4, m_rgdFrameGrabber4);
	//}}AFX_DATA_MAP
}

BEGIN_MESSAGE_MAP(CFrameGrabber, CDialog)
	//{{AFX_MSG_MAP(CFrameGrabber)
	ON_BN_CLICKED(btnBurstModeBMPFile, OnbtnBurstModeBMPFile)
	ON_BN_CLICKED(btnBurstModeJPEGFile, OnbtnBurstModeJPEGFile)
	ON_BN_CLICKED(btnBurstModeStop, OnbtnBurstModeStop)
	ON_BN_CLICKED(btnBurstModeTBitmap, OnbtnBurstModeTBitmap)
	ON_BN_CLICKED(btnOneShotBMPFile, OnbtnOneShotBMPFile)
	ON_BN_CLICKED(btnOneShotJPEGFile, OnbtnOneShotJPEGFile)
	ON_BN_CLICKED(btnOneShotTBitmap, OnbtnOneShotTBitmap)
	ON_BN_CLICKED(btnResetCaptureZoomSize, OnbtnResetCaptureZoomSize)
	ON_BN_CLICKED(chkUseThisFileName, OnchkUseThisFileName)
	ON_EN_CHANGE(edtAVIAutoFilePrefix, OnChangeedtAVIAutoFilePrefix)
	ON_EN_CHANGE(edtBurstCount, OnChangeedtBurstCount)
	ON_EN_CHANGE(edtBurstInterval, OnChangeedtBurstInterval)
	ON_WM_CLOSE()
	ON_BN_CLICKED(rdgAutoFileName1, OnrdgAutoFileName1)
	ON_BN_CLICKED(rdgAutoFileName2, OnrdgAutoFileName2)
	ON_BN_CLICKED(rgdFrameGrabberFormat1, OnrgdFrameGrabberFormat1)
	ON_BN_CLICKED(rgdFrameGrabberFormat2, OnrgdFrameGrabberFormat2)
	ON_BN_CLICKED(rgdFrameGrabberFormat3, OnrgdFrameGrabberFormat3)
	ON_BN_CLICKED(rgdFrameGrabberFormat4, OnrgdFrameGrabberFormat4)
	ON_BN_CLICKED(rgdFrameGrabberFormat5, OnrgdFrameGrabberFormat5)
	ON_BN_CLICKED(rgdFrameGrabberFormat6, OnrgdFrameGrabberFormat6)
	ON_BN_CLICKED(rgdFrameGrabber1, OnrgdFrameGrabber1)
	ON_BN_CLICKED(rgdFrameGrabber2, OnrgdFrameGrabber2)
	ON_BN_CLICKED(rgdFrameGrabber3, OnrgdFrameGrabber3)
	ON_BN_CLICKED(rgdFrameGrabber4, OnrgdFrameGrabber4)
	ON_WM_VSCROLL()
	ON_BN_CLICKED(btnOneShotClipboard, OnbtnOneShotClipboard)
	ON_BN_CLICKED(btnBurstModeClipboard, OnbtnBurstModeClipboard)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CFrameGrabber message handlers

BOOL CFrameGrabber::OnInitDialog()
{
	CDialog::OnInitDialog();

	m_edtCaptureZoomSize	.SetWindowText("100%");
	m_tbrCaptureZoomSize	.SetRange(0, 300, true);
	m_tbrCaptureZoomSize	.SetTicFreq(10);
	m_edtBurstCount			.SetWindowText("3");
	m_edtBurstInterval		.SetWindowText("0");
	m_edtUseThisFileName	.SetWindowText("CapFile01");

	m_edtUseThisFileName.EnableWindow(m_chkUseThisFileName.GetCheck()==BST_CHECKED);

	return TRUE;
}

void CFrameGrabber::OnbtnBurstModeBMPFile() 
{
	dlg_MainForm->m_VideoGrabber.SetBurstType(fc_BmpFile);
	dlg_MainForm->m_VideoGrabber.SetBurstMode(true);
	// The frame capture starts when BurstMode is set to True.
	// If BurstCount = 0 the frame capture won"t stop.
	// BMP file names will be generated automatically according to AutoFileName
	// and AutoFilePrefix. They will be returned by the OnFrameCaptureCompleted event.
}

void CFrameGrabber::OnbtnBurstModeJPEGFile() 
{
	dlg_MainForm->m_VideoGrabber.SetBurstType(fc_JpegFile);
	dlg_MainForm->m_VideoGrabber.SetBurstMode(true);
	// The frame capture starts when BurstMode is set to True.
	// If BurstCount = 0 the frame capture won"t stop.
	// JPEG file names will be generated automatically according to AutoFileName
	// and AutoFilePrefix. They will be returned by the OnFrameCaptureCompleted event.
}

void CFrameGrabber::OnbtnBurstModeClipboard() 
{
	dlg_MainForm->m_VideoGrabber.SetBurstType(fc_Clipboard);
	dlg_MainForm->m_VideoGrabber.SetBurstMode(true);
	// The frame capture starts when BurstMode is set to True.
	// If BurstCount = 0 the frame capture won"t stop.
	// Captured frames will be returned by the OnFrameCaptureCompleted event.
}

void CFrameGrabber::OnbtnBurstModeStop() 
{
	dlg_MainForm->m_VideoGrabber.SetBurstMode(false);
}

void CFrameGrabber::OnbtnBurstModeTBitmap() 
{
	dlg_MainForm->m_VideoGrabber.SetBurstType(fc_TBitmap);
	dlg_MainForm->m_VideoGrabber.SetBurstMode(true);
	// The frame capture starts when BurstMode is set to True.
	// If BurstCount = 0 the frame capture won"t stop.
	// Captured frames will be returned by the OnFrameCaptureCompleted event.
}

void CFrameGrabber::OnbtnOneShotBMPFile() 
{
	char UseThisFileName[600] = "";
	if (m_chkUseThisFileName.GetCheck()==BST_CHECKED)
		m_edtUseThisFileName.GetWindowText(UseThisFileName, sizeof(UseThisFileName));
	dlg_MainForm->m_VideoGrabber.CaptureFrameTo(fc_BmpFile, UseThisFileName);
	// note 1: passing an empty file name let TVideoGrabber generate it automatically in the StoragePath directory
	// note 2: using CaptureFrameSyncTo instead of CaptureFrameTo waits for frame capture completion and returns true upon success
}

void CFrameGrabber::OnbtnOneShotJPEGFile() 
{
	char UseThisFileName[600] = "";
	if (m_chkUseThisFileName.GetCheck()==BST_CHECKED)
		m_edtUseThisFileName.GetWindowText(UseThisFileName, sizeof(UseThisFileName));
	dlg_MainForm->m_VideoGrabber.CaptureFrameTo(fc_JpegFile, UseThisFileName);
	// note 1: passing an empty file name let TVideoGrabber generate it automatically in the StoragePath directory
	// note 2: using CaptureFrameSyncTo instead of CaptureFrameTo waits for frame capture completion and returns true upon success
}

void CFrameGrabber::OnbtnOneShotClipboard() 
{
	dlg_MainForm->m_VideoGrabber.CaptureFrameTo(fc_Clipboard, "");
}

void CFrameGrabber::OnbtnOneShotTBitmap() 
{
	dlg_MainForm->m_VideoGrabber.CaptureFrameTo(fc_TBitmap, "");
}

void CFrameGrabber::OnbtnResetCaptureZoomSize() 
{
	m_tbrCaptureZoomSize.SetPos(100);
	CaptureZoomSize_Change();
}

void CFrameGrabber::OnchkUseThisFileName() 
{
	m_edtUseThisFileName.EnableWindow(m_chkUseThisFileName.GetCheck()==BST_CHECKED);
}

void CFrameGrabber::OnChangeedtAVIAutoFilePrefix() 
{
	CString cs;
	m_edtAVIAutoFilePrefix.GetWindowText(cs);
	dlg_MainForm->m_VideoGrabber.SetAutoFilePrefix(cs);
}

void CFrameGrabber::OnChangeedtBurstCount() 
{
	long nNewValue;
	if (IsNumeric(&m_edtBurstCount, nNewValue))
		dlg_MainForm->m_VideoGrabber.SetBurstCount(nNewValue);
}

void CFrameGrabber::OnChangeedtBurstInterval() 
{
	long nNewValue;
	if (IsNumeric(&m_edtBurstInterval, nNewValue))
		dlg_MainForm->m_VideoGrabber.SetBurstInterval(nNewValue);
}

void CFrameGrabber::OnClose() 
{
//?   If Not MainForm.CanUnload Then
//?      Hide
//?      Cancel = True
//?   End If

	CDialog::OnClose();
}

void CFrameGrabber::OnrdgAutoFileName1() 
{
	dlg_MainForm->m_VideoGrabber.SetAutoFileName(fn_Sequential);
}

void CFrameGrabber::OnrdgAutoFileName2() 
{
	dlg_MainForm->m_VideoGrabber.SetAutoFileName(fn_DateTime);
}

void CFrameGrabber::OnrgdFrameGrabber1() 
{
	dlg_MainForm->m_VideoGrabber.SetFrameGrabber(fg_BothStreams);
	dlg_MainForm->RefreshVideoDeviceControls();
}

void CFrameGrabber::OnrgdFrameGrabber2() 
{
	dlg_MainForm->m_VideoGrabber.SetFrameGrabber(fg_PreviewStream);
	dlg_MainForm->RefreshVideoDeviceControls();
}

void CFrameGrabber::OnrgdFrameGrabber3() 
{
	dlg_MainForm->m_VideoGrabber.SetFrameGrabber(fg_CaptureStream);
	dlg_MainForm->RefreshVideoDeviceControls();
}

void CFrameGrabber::OnrgdFrameGrabber4() 
{
	dlg_MainForm->m_VideoGrabber.SetFrameGrabber(fg_Disabled);
	dlg_MainForm->RefreshVideoDeviceControls();
}

void CFrameGrabber::OnrgdFrameGrabberFormat1() 
{
	dlg_MainForm->m_VideoGrabber.SetFrameGrabberRGBFormat(fgf_Default);
}

void CFrameGrabber::OnrgdFrameGrabberFormat2() 
{
	dlg_MainForm->m_VideoGrabber.SetFrameGrabberRGBFormat(fgf_RGB32);
}

void CFrameGrabber::OnrgdFrameGrabberFormat3() 
{
	dlg_MainForm->m_VideoGrabber.SetFrameGrabberRGBFormat(fgf_RGB24);
}

void CFrameGrabber::OnrgdFrameGrabberFormat4() 
{
	dlg_MainForm->m_VideoGrabber.SetFrameGrabberRGBFormat(fgf_RGB565);
}

void CFrameGrabber::OnrgdFrameGrabberFormat5() 
{
	dlg_MainForm->m_VideoGrabber.SetFrameGrabberRGBFormat(fgf_RGB555);
}

void CFrameGrabber::OnrgdFrameGrabberFormat6() 
{
	dlg_MainForm->m_VideoGrabber.SetFrameGrabberRGBFormat(fgf_RGB8);
}

void CFrameGrabber::CaptureZoomSize_Change()
{
	dlg_MainForm->m_VideoGrabber.SetFrameCaptureZoomSize(m_tbrCaptureZoomSize.GetPos());
	char buf[100];
	sprintf(buf, "%d%%", m_tbrCaptureZoomSize.GetPos());
	m_edtCaptureZoomSize.SetWindowText(buf);
}

void CFrameGrabber::OnVScroll(UINT nSBCode, UINT nPos, CScrollBar* pScrollBar) 
{
	if (pScrollBar->m_hWnd==m_tbrCaptureZoomSize.m_hWnd) {
		CaptureZoomSize_Change();
	}
	
	CDialog::OnVScroll(nSBCode, nPos, pScrollBar);
}


