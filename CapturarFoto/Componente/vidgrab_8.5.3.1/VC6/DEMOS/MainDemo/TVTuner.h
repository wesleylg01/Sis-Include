#if !defined(AFX_TVTUNER_H__39B9723D_F302_454B_8097_ED97AAF0994B__INCLUDED_)
#define AFX_TVTUNER_H__39B9723D_F302_454B_8097_ED97AAF0994B__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// TVTuner.h : header file
//

#include "MainForm.h"

/////////////////////////////////////////////////////////////////////////////
// CTVTuner dialog

class CTVTuner : public CDialog
{
// Construction
public:
	CTVTuner(CWnd* pParent = NULL);   // standard constructor

	CMainForm *dlg_MainForm;
// Dialog Data

	//{{AFX_DATA(CTVTuner)
	enum { IDD = TVTuner };
	CEdit	m_mmoChannelLog;
	CButton	m_grbTVChannel;
	CEdit	m_edtTVChannel;
	CButton	m_btnSelect;
	CButton	m_grbFrequencyOverride;
	CEdit	m_edtChannelFrequency;
	CButton	m_Command22;
	CButton	m_Command23;
	CButton	m_chkEnableFrequencyOverrides;
	CButton	m_grbTVScan;
	CButton	m_btnStartScan;
	CButton	m_btnStopScan;
	CButton	m_grbTunerCountryCode;
	CButton	m_rdgTunerInputType;
	CButton	m_rdgTunerInputType1;
	CButton	m_rdgTunerInputType2;
	CButton	m_grbCountryCode;
	CEdit	m_edtCountryCode;
	CButton	m_btnSetCountryCode;
	CButton	m_btnResetAllOverrides;
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CTVTuner)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:

	// Generated message map functions
	//{{AFX_MSG(CTVTuner)
	virtual BOOL OnInitDialog();
	afx_msg void OnbtnResetAllOverrides();
	afx_msg void OnbtnSelect();
	afx_msg void OnbtnSetCountryCode();
	afx_msg void OnbtnStartScan();
	afx_msg void OnbtnStopScan();
	afx_msg void OnchkEnableFrequencyOverrides();
	afx_msg void OnCommand22();
	afx_msg void OnCommand23();
	afx_msg void OnClose();
	afx_msg void OnrdgTunerInputType1();
	afx_msg void OnrdgTunerInputType2();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_TVTUNER_H__39B9723D_F302_454B_8097_ED97AAF0994B__INCLUDED_)
