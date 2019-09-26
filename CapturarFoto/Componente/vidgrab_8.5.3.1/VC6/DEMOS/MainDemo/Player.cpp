// Player.cpp : implementation file
//

#include "stdafx.h"
#include "MainDemo.h"
#include "Player.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CPlayer dialog

CPlayer::CPlayer(CWnd* pParent /*=NULL*/)
	: CDialog(CPlayer::IDD, pParent)
{
	//{{AFX_DATA_INIT(CPlayer)
		// NOTE: the ClassWizard will add member initialization here
	//}}AFX_DATA_INIT
}

void CPlayer::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CPlayer)
		// NOTE: the ClassWizard will add DDX and DDV calls here
	DDX_Control(pDX, btnFastFwd, m_btnFastFwd);
	DDX_Control(pDX, btnFastRew, m_btnFastRew);
	DDX_Control(pDX, btnPlay, m_btnPlay);
	DDX_Control(pDX, btnStop, m_btnStop);
	DDX_Control(pDX, btnPause, m_btnPause);
	DDX_Control(pDX, btnPlayBackwards, m_btnPlayBackwards);
	DDX_Control(pDX, btnPlayerOpenFile, m_btnPlayerOpenFile);
	DDX_Control(pDX, btnOpenLastClipRecorded, m_btnOpenLastClipRecorded);
	DDX_Control(pDX, btnOpenLastClipPlayed, m_btnOpenLastClipPlayed);
	DDX_Control(pDX, btnPlayerCloseFile, m_btnPlayerCloseFile);
	DDX_Control(pDX, btnPlayerOpenStreamingURL, m_btnPlayerOpenStreamingURL);
	DDX_Control(pDX, edtPlayerStreamingURL, m_edtPlayerStreamingURL);
	DDX_Control(pDX, edtPlayerSpeedRatio, m_edtPlayerSpeedRatio);
	DDX_Control(pDX, edtPlayerFastSeekSpeed, m_edtPlayerFastSeekSpeed);
	DDX_Control(pDX, btnAutoPlay, m_btnAutoPlay);
	DDX_Control(pDX, chkPlayerAudioRendering, m_chkPlayerAudioRendering);
	DDX_Control(pDX, chkRefreshPausedDisplay, m_chkRefreshPausedDisplay);
	DDX_Control(pDX, rdgDVPlaybackSize, m_rdgDVPlaybackSize);
	DDX_Control(pDX, rdgDVPlaybackSize1, m_rdgDVPlaybackSize1);
	DDX_Control(pDX, rdgDVPlaybackSize2, m_rdgDVPlaybackSize2);
	DDX_Control(pDX, rdgDVPlaybackSize3, m_rdgDVPlaybackSize3);
	DDX_Control(pDX, rdgDVPlaybackSize4, m_rdgDVPlaybackSize4);
	DDX_Control(pDX, updPlayerSpeedRatio, m_updPlayerSpeedRatio);
	DDX_Control(pDX, updPlayerFastSeekSpeed, m_updPlayerFastSeekSpeed);
	//}}AFX_DATA_MAP
}

BEGIN_MESSAGE_MAP(CPlayer, CDialog)
	//{{AFX_MSG_MAP(CPlayer)
	ON_BN_CLICKED(btnAutoPlay, OnbtnAutoPlay)
	ON_BN_CLICKED(btnFastFwd, OnbtnFastFwd)
	ON_BN_CLICKED(btnFastRew, OnbtnFastRew)
	ON_BN_CLICKED(btnOpenLastClipPlayed, OnbtnOpenLastClipPlayed)
	ON_BN_CLICKED(btnOpenLastClipRecorded, OnbtnOpenLastClipRecorded)
	ON_BN_CLICKED(btnPause, OnbtnPause)
	ON_BN_CLICKED(btnPlay, OnbtnPlay)
	ON_BN_CLICKED(btnPlayBackwards, OnbtnPlayBackwards)
	ON_BN_CLICKED(btnPlayerCloseFile, OnbtnPlayerCloseFile)
	ON_BN_CLICKED(btnPlayerOpenFile, OnbtnPlayerOpenFile)
	ON_BN_CLICKED(btnPlayerOpenStreamingURL, OnbtnPlayerOpenStreamingURL)
	ON_BN_CLICKED(btnStop, OnbtnStop)
	ON_BN_CLICKED(chkPlayerAudioRendering, OnchkPlayerAudioRendering)
	ON_BN_CLICKED(chkRefreshPausedDisplay, OnchkRefreshPausedDisplay)
	ON_WM_CLOSE()
	ON_BN_CLICKED(rdgDVPlaybackSize1, OnrdgDVPlaybackSize1)
	ON_BN_CLICKED(rdgDVPlaybackSize2, OnrdgDVPlaybackSize2)
	ON_BN_CLICKED(rdgDVPlaybackSize3, OnrdgDVPlaybackSize3)
	ON_BN_CLICKED(rdgDVPlaybackSize4, OnrdgDVPlaybackSize4)
	ON_NOTIFY(UDN_DELTAPOS, updPlayerSpeedRatio, OnDeltaposupdPlayerSpeedRatio)
	ON_NOTIFY(UDN_DELTAPOS, updPlayerFastSeekSpeed, OnDeltaposupdPlayerFastSeekSpeed)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CPlayer message handlers

BOOL CPlayer::OnInitDialog()
{
	CDialog::OnInitDialog();

	m_edtPlayerStreamingURL	.SetWindowText("mms://www.datastead.com/demo/demo.wmv");
	m_edtPlayerSpeedRatio	.SetWindowText("10");
	m_edtPlayerFastSeekSpeed.SetWindowText("1");
	m_updPlayerSpeedRatio	.SetRange(0, 32767);
	m_updPlayerFastSeekSpeed.SetRange(0, 32767);

	return TRUE;
}

void CPlayer::OnbtnAutoPlay() 
{
	dlg_MainForm->m_VideoGrabber.SetAutoStartPlayer(m_btnAutoPlay.GetCheck()==BST_CHECKED);
}

void CPlayer::OnbtnFastFwd() 
{
	dlg_MainForm->m_VideoGrabber.FastForwardPlayer();
}

void CPlayer::OnbtnFastRew() 
{
	dlg_MainForm->m_VideoGrabber.RewindPlayer();
}

void CPlayer::OnbtnOpenLastClipPlayed() 
{
	dlg_MainForm->m_VideoGrabber.SetPlayerFileName(dlg_MainForm->m_VideoGrabber.GetLast_Clip_Played());
	dlg_MainForm->m_VideoGrabber.OpenPlayer();
}

void CPlayer::OnbtnOpenLastClipRecorded() 
{
	dlg_MainForm->m_VideoGrabber.SetPlayerFileName(dlg_MainForm->m_VideoGrabber.GetLast_Recording_FileName());
	dlg_MainForm->m_VideoGrabber.OpenPlayer();
}

void CPlayer::OnbtnPause() 
{
	dlg_MainForm->m_VideoGrabber.PausePlayer();
}

void CPlayer::OnbtnPlay() 
{
	dlg_MainForm->m_VideoGrabber.RunPlayer();
}

void CPlayer::OnbtnPlayBackwards() 
{
	dlg_MainForm->m_VideoGrabber.RunPlayerBackwards();
}

void CPlayer::OnbtnPlayerCloseFile() 
{
	dlg_MainForm->m_VideoGrabber.ClosePlayer();
}

void CPlayer::OnbtnPlayerOpenFile() 
{
	CString sFilter = "All Video Files|*.mpg;*.mpeg;*.vro;*.avi;*.wav;*.asf;*.wmv;*.vob|";
	CFileDialog dlg(TRUE, 0, 0, OFN_FILEMUSTEXIST|OFN_ENABLESIZING|OFN_HIDEREADONLY, sFilter);
	if (dlg.DoModal()!=IDOK) return;
	dlg_MainForm->m_VideoGrabber.SetPlayerFileName(dlg.GetPathName());
	dlg_MainForm->m_VideoGrabber.OpenPlayer();
}

void CPlayer::OnbtnPlayerOpenStreamingURL() 
{
	m_edtPlayerStreamingURL.GetWindowText(cs);
	dlg_MainForm->m_VideoGrabber.SetPlayerFileName(cs);
	dlg_MainForm->m_VideoGrabber.OpenPlayer();
}

void CPlayer::OnbtnStop() 
{
	dlg_MainForm->m_VideoGrabber.StopPlayer();
}

void CPlayer::OnchkPlayerAudioRendering() 
{
	dlg_MainForm->m_VideoGrabber.SetPlayerAudioRendering(m_chkPlayerAudioRendering.GetCheck()==BST_CHECKED);
}

void CPlayer::OnchkRefreshPausedDisplay() 
{
	dlg_MainForm->m_VideoGrabber.SetPlayerRefreshPausedDisplay(m_chkRefreshPausedDisplay.GetCheck()==BST_CHECKED);
}

void CPlayer::OnClose() 
{
//?   If Not dlg_MainForm.CanUnload Then
//?      Hide
//?      Cancel = True
//?   End If
	
	CDialog::OnClose();
}

void CPlayer::OnrdgDVPlaybackSize1() 
{
	dlg_MainForm->m_VideoGrabber.SetPlayerDVSize(dv_Full);
}

void CPlayer::OnrdgDVPlaybackSize2() 
{
	dlg_MainForm->m_VideoGrabber.SetPlayerDVSize(dv_Half);
}

void CPlayer::OnrdgDVPlaybackSize3() 
{
	dlg_MainForm->m_VideoGrabber.SetPlayerDVSize(dv_Quarter);
}

void CPlayer::OnrdgDVPlaybackSize4() 
{
	dlg_MainForm->m_VideoGrabber.SetPlayerDVSize(dv_DC);
}

void CPlayer::OnDeltaposupdPlayerFastSeekSpeed(NMHDR* pNMHDR, LRESULT* pResult) 
{
	NM_UPDOWN* pNMUpDown = (NM_UPDOWN*)pNMHDR;

	long PlayerFastSeekSpeed;	
	if (IsNumeric(&m_edtPlayerFastSeekSpeed,PlayerFastSeekSpeed)) {

		if (pNMUpDown->iDelta == -1) {
				if (PlayerFastSeekSpeed > 1) PlayerFastSeekSpeed--;
		}

		if (pNMUpDown->iDelta == 1) {
			PlayerFastSeekSpeed++;
		}

		m_edtPlayerFastSeekSpeed.SetWindowText(ToCString(PlayerFastSeekSpeed));
		dlg_MainForm->m_VideoGrabber.SetPlayerFastSeekSpeedRatio(PlayerFastSeekSpeed);

	}

	*pResult = 0;
}

void CPlayer::OnDeltaposupdPlayerSpeedRatio(NMHDR* pNMHDR, LRESULT* pResult) 
{
	NM_UPDOWN* pNMUpDown = (NM_UPDOWN*)pNMHDR;

	long PlayerSpeedRatio;
	if (IsNumeric(&m_edtPlayerSpeedRatio,PlayerSpeedRatio)) {

		if (pNMUpDown->iDelta == -1) {
			if (PlayerSpeedRatio > 1)	PlayerSpeedRatio--;
		}

		if (pNMUpDown->iDelta == 1) {
			PlayerSpeedRatio++;
		}

		m_edtPlayerSpeedRatio.SetWindowText(ToCString(PlayerSpeedRatio));

		dlg_MainForm->m_VideoGrabber.SetPlayerSpeedRatio(PlayerSpeedRatio / 10);
	}

	*pResult = 0;
}
