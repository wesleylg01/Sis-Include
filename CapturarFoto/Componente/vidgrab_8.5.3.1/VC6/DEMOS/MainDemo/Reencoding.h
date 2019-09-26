#if !defined(AFX_REENCODING_H__C7532FBE_67D0_4D20_A00D_55DF0D3D98F5__INCLUDED_)
#define AFX_REENCODING_H__C7532FBE_67D0_4D20_A00D_55DF0D3D98F5__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// Reencoding.h : header file
//

#include "MainForm.h"

/////////////////////////////////////////////////////////////////////////////
// CReencoding dialog

class CReencoding : public CDialog
{
// Construction
public:
	CReencoding(CWnd* pParent = NULL);   // standard constructor

	CMainForm *dlg_MainForm;

// Dialog Data

	//{{AFX_DATA(CReencoding)
	enum { IDD = Reencoding };
	CButton	m_btnStopReencoding;
	CButton	m_btnStartReencoding;
	CButton	m_rdgReencodingMethod;
	CButton	m_rdgReencodingMethod1;
	CButton	m_rdgReencodingMethod2;
	CButton	m_grbReencodingSettings;
	CButton	m_chkWMVOutput;
	CButton	m_chkUseFrameGrabber;
	CButton	m_chkIncludeAudioStream;
	CButton	m_chkUseCurrentVideoCompressor;
	CButton	m_chkIncludeVideoStream;
	CButton	m_chkUseCurrentAudioCompressor;
	CButton	m_grbStartStopTime;
	CEdit	m_edtDuration;
	CEdit	m_edtStartTime;
	CEdit	m_edtStopTime;
	CButton	m_btnDuration;
	CEdit	m_edtDestinationVideoClip;
	CEdit	m_edtSourceVideoClip;
	CButton	m_btnSourceVideoClip;
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CReencoding)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:

	// Generated message map functions
	//{{AFX_MSG(CReencoding)
	virtual BOOL OnInitDialog();
	afx_msg void OnbtnDuration();
	afx_msg void OnbtnSourceVideoClip();
	afx_msg void OnbtnStartReencoding();
	afx_msg void OnbtnStopReencoding();
	afx_msg void OnClose();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_REENCODING_H__C7532FBE_67D0_4D20_A00D_55DF0D3D98F5__INCLUDED_)
