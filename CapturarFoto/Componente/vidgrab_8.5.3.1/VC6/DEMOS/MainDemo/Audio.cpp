// Audio.cpp : implementation file
//

#include "stdafx.h"
#include "MainDemo.h"
#include "Audio.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CAudio dialog

CAudio::CAudio(CWnd* pParent /*=NULL*/)
	: CDialog(CAudio::IDD, pParent)
{
	//{{AFX_DATA_INIT(CAudio)
		// NOTE: the ClassWizard will add member initialization here
	//}}AFX_DATA_INIT
}


void CAudio::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CAudio)
		// NOTE: the ClassWizard will add DDX and DDV calls here
	DDX_Control(pDX, chkRenderAudioDevice, m_chkRenderAudioDevice);
	DDX_Control(pDX, grbAudioRendering, m_grbAudioRendering);
	DDX_Control(pDX, chkMuteAudioRendering, m_chkMuteAudioRendering);
	DDX_Control(pDX, tbrAudioVolume, m_tbrAudioVolume);
	DDX_Control(pDX, tbrAudioBalance, m_tbrAudioBalance);
	DDX_Control(pDX, grbAudioCaptureDevice, m_grbAudioCaptureDevice);
	DDX_Control(pDX, cboAudioDevices, m_cboAudioDevices);
	DDX_Control(pDX, cboAudioInputs, m_cboAudioInputs);
	DDX_Control(pDX, chkAudioInputMono, m_chkAudioInputMono);
	DDX_Control(pDX, tbrAudioInputLevel, m_tbrAudioInputLevel);
	DDX_Control(pDX, tbrAudioInputBalance, m_tbrAudioInputBalance);
	//}}AFX_DATA_MAP
}

BEGIN_MESSAGE_MAP(CAudio, CDialog)
	//{{AFX_MSG_MAP(CAudio)
	ON_CBN_SELCHANGE(cboAudioDevices, OnSelchangecboAudioDevices)
	ON_CBN_SELCHANGE(cboAudioInputs, OnSelchangecboAudioInputs)
	ON_BN_CLICKED(chkAudioInputMono, OnchkAudioInputMono)
	ON_BN_CLICKED(chkMuteAudioRendering, OnchkMuteAudioRendering)
	ON_BN_CLICKED(chkRenderAudioDevice, OnchkRenderAudioDevice)
	ON_WM_CLOSE()
	ON_WM_HSCROLL()
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CAudio message handlers

BOOL CAudio::OnInitDialog()
{
	CDialog::OnInitDialog();

	m_tbrAudioVolume		.SetRange(0, 65535, true);
	m_tbrAudioBalance		.SetRange(-32767, 32768, true);
	m_tbrAudioInputLevel	.SetRange(0, 65535, true);
	m_tbrAudioInputBalance	.SetRange(-32767, 32768, true);

	const int TicFreq = 6553;
	m_tbrAudioVolume		.SetTicFreq(TicFreq);
	m_tbrAudioBalance		.SetTicFreq(TicFreq);
	m_tbrAudioInputLevel	.SetTicFreq(TicFreq);
	m_tbrAudioInputBalance	.SetTicFreq(TicFreq);

	return TRUE;
}

void CAudio::OnSelchangecboAudioDevices() 
{
	dlg_MainForm->m_VideoGrabber.SetAudioDevice(m_cboAudioDevices.GetCurSel());
}

void CAudio::OnSelchangecboAudioInputs() 
{
	dlg_MainForm->m_VideoGrabber.SetAudioInput(m_cboAudioInputs.GetCurSel());
}

void CAudio::OnchkAudioInputMono() 
{
	dlg_MainForm->m_VideoGrabber.SetAudioInputMono(m_chkAudioInputMono.GetCheck()==BST_CHECKED);
}

void CAudio::OnchkMuteAudioRendering() 
{
	dlg_MainForm->m_VideoGrabber.SetMuteAudioRendering(m_chkMuteAudioRendering.GetCheck()==BST_CHECKED);
}

void CAudio::OnchkRenderAudioDevice() 
{
	dlg_MainForm->m_VideoGrabber.SetAudioDeviceRendering(m_chkRenderAudioDevice.GetCheck()==BST_CHECKED);
}

void CAudio::OnClose() 
{
//?   If Not MainForm.CanUnload Then
//?      Hide
//?      Cancel = True
//?   End If
	
	CDialog::OnClose();
}

void CAudio::OnHScroll(UINT nSBCode, UINT nPos, CScrollBar* pScrollBar) 
{
	if (pScrollBar->m_hWnd==m_tbrAudioBalance.m_hWnd) {
		dlg_MainForm->m_VideoGrabber.SetAudioBalance(m_tbrAudioBalance.GetPos());
	}

	if (pScrollBar->m_hWnd==m_tbrAudioInputBalance.m_hWnd) {
		dlg_MainForm->m_VideoGrabber.SetAudioInputBalance(m_tbrAudioInputBalance.GetPos());
	}

	if (pScrollBar->m_hWnd==m_tbrAudioInputLevel.m_hWnd) {
		dlg_MainForm->m_VideoGrabber.SetAudioInputLevel(m_tbrAudioInputLevel.GetPos());
	}

	if (pScrollBar->m_hWnd==m_tbrAudioVolume.m_hWnd) {
		dlg_MainForm->m_VideoGrabber.SetAudioVolume(m_tbrAudioVolume.GetPos());
	}

	CDialog::OnHScroll(nSBCode, nPos, pScrollBar);
}
