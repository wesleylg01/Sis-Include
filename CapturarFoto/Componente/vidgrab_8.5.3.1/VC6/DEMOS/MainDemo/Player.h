#if !defined(AFX_PLAYER_H__7F6F31F4_A0B2_43F3_89AD_99F7BE8EF6B2__INCLUDED_)
#define AFX_PLAYER_H__7F6F31F4_A0B2_43F3_89AD_99F7BE8EF6B2__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// Player.h : header file
//

#include "MainForm.h"

/////////////////////////////////////////////////////////////////////////////
// CPlayer dialog

class CPlayer : public CDialog
{
// Construction
public:
	CPlayer(CWnd* pParent = NULL);   // standard constructor

	CMainForm *dlg_MainForm;

// Dialog Data

	//{{AFX_DATA(CPlayer)
	enum { IDD = Player };
	CButton	m_btnFastFwd;
	CButton	m_btnFastRew;
	CButton	m_btnPlay;
	CButton	m_btnStop;
	CButton	m_btnPause;
	CButton	m_btnPlayBackwards;
	CButton	m_btnPlayerOpenFile;
	CButton	m_btnOpenLastClipRecorded;
	CButton	m_btnOpenLastClipPlayed;
	CButton	m_btnPlayerCloseFile;
	CButton	m_btnPlayerOpenStreamingURL;
	CEdit	m_edtPlayerStreamingURL;
	CEdit	m_edtPlayerSpeedRatio;
	CEdit	m_edtPlayerFastSeekSpeed;
	CButton	m_btnAutoPlay;
	CButton	m_chkPlayerAudioRendering;
	CButton	m_chkRefreshPausedDisplay;
	CButton	m_rdgDVPlaybackSize;
	CButton	m_rdgDVPlaybackSize1;
	CButton	m_rdgDVPlaybackSize2;
	CButton	m_rdgDVPlaybackSize3;
	CButton	m_rdgDVPlaybackSize4;
	CSpinButtonCtrl	m_updPlayerSpeedRatio;
	CSpinButtonCtrl	m_updPlayerFastSeekSpeed;
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CPlayer)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:

	// Generated message map functions
	//{{AFX_MSG(CPlayer)
	virtual BOOL OnInitDialog();
	afx_msg void OnbtnAutoPlay();
	afx_msg void OnbtnFastFwd();
	afx_msg void OnbtnFastRew();
	afx_msg void OnbtnOpenLastClipPlayed();
	afx_msg void OnbtnOpenLastClipRecorded();
	afx_msg void OnbtnPause();
	afx_msg void OnbtnPlay();
	afx_msg void OnbtnPlayBackwards();
	afx_msg void OnbtnPlayerCloseFile();
	afx_msg void OnbtnPlayerOpenFile();
	afx_msg void OnbtnPlayerOpenStreamingURL();
	afx_msg void OnbtnStop();
	afx_msg void OnchkPlayerAudioRendering();
	afx_msg void OnchkRefreshPausedDisplay();
	afx_msg void OnClose();
	afx_msg void OnrdgDVPlaybackSize1();
	afx_msg void OnrdgDVPlaybackSize2();
	afx_msg void OnrdgDVPlaybackSize3();
	afx_msg void OnrdgDVPlaybackSize4();
	afx_msg void OnDeltaposupdPlayerSpeedRatio(NMHDR* pNMHDR, LRESULT* pResult);
	afx_msg void OnDeltaposupdPlayerFastSeekSpeed(NMHDR* pNMHDR, LRESULT* pResult);
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_PLAYER_H__7F6F31F4_A0B2_43F3_89AD_99F7BE8EF6B2__INCLUDED_)
