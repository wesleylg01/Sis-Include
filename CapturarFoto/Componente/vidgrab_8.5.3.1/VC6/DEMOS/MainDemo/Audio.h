#if !defined(AFX_AUDIO_H__81DA2CDD_888B_4796_BD40_2DA98A23D992__INCLUDED_)
#define AFX_AUDIO_H__81DA2CDD_888B_4796_BD40_2DA98A23D992__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// Audio.h : header file
//

#include "MainForm.h"

/////////////////////////////////////////////////////////////////////////////
// CAudio dialog

class CAudio : public CDialog
{
// Construction
public:
	CAudio(CWnd* pParent = NULL);   // standard constructor

	CMainForm *dlg_MainForm;

// Dialog Data
	//{{AFX_DATA(CAudio)
	enum { IDD = Audio };
	CButton	m_chkRenderAudioDevice;
	CButton	m_grbAudioRendering;
	CButton	m_chkMuteAudioRendering;
	CSliderCtrl	m_tbrAudioVolume;
	CSliderCtrl	m_tbrAudioBalance;
	CButton	m_grbAudioCaptureDevice;
	CComboBox	m_cboAudioDevices;
	CComboBox	m_cboAudioInputs;
	CButton	m_chkAudioInputMono;
	CSliderCtrl	m_tbrAudioInputLevel;
	CSliderCtrl	m_tbrAudioInputBalance;
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CAudio)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:

	// Generated message map functions
	//{{AFX_MSG(CAudio)
	virtual BOOL OnInitDialog();
	afx_msg void OnSelchangecboAudioDevices();
	afx_msg void OnSelchangecboAudioInputs();
	afx_msg void OnchkAudioInputMono();
	afx_msg void OnchkMuteAudioRendering();
	afx_msg void OnchkRenderAudioDevice();
	afx_msg void OnClose();
	afx_msg void OnHScroll(UINT nSBCode, UINT nPos, CScrollBar* pScrollBar);
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_AUDIO_H__81DA2CDD_888B_4796_BD40_2DA98A23D992__INCLUDED_)
