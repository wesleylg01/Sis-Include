#if !defined(AFX_DISPLAY_H__14328D20_523D_49FB_8D40_C7C51C44CACD__INCLUDED_)
#define AFX_DISPLAY_H__14328D20_523D_49FB_8D40_C7C51C44CACD__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// Display.h : header file
//

#include "MainForm.h"

/////////////////////////////////////////////////////////////////////////////
// CDisplay dialog

class CDisplay : public CDialog
{
// Construction
public:
	CDisplay(CWnd* pParent = NULL);   // standard constructor

	CMainForm *dlg_MainForm;

	void RefreshDisplayOptions();

// Dialog Data
	//{{AFX_DATA(CDisplay)
	enum { IDD = Display };
	CButton	m_chk2ndVideoWindowActive;
	CButton	m_grb2ndVideoWindow;
	CButton	m_btnEG2ndNewLocation2;
	CButton	m_btnEG2ndNewLocation;
	CButton	m_rdg2ndDisplayedOn;
	CButton	m_rdg2ndDisplayedOn2;
	CButton	m_rdg2ndDisplayedOn1;
	CButton	m_chk2ndAutoSize;
	CButton	m_chk2ndStayOnTop;
	CButton	m_chk2ndMouseMovesWindow;
	CButton	m_chk2ndFullScreen;
	CButton	m_chk2ndKeepAspectRatio;
	CButton	m_chk2ndUseVideoPort;
	CButton	m_chk2ndEmbedded;
	CButton	m_grbMainVideoWindow;
	CButton	m_chk1stEmbedded;
	CButton	m_chk1stUseVideoPort;
	CButton	m_chk1stKeepAspectRatio;
	CButton	m_chk1stFullScreen;
	CButton	m_chk1stMouseMovesWindow;
	CButton	m_chk1stStayOnTop;
	CButton	m_chk1stAutoSize;
	CButton	m_rdg1stDisplayedOn;
	CButton	m_rdg1stDisplayedOn1;
	CButton	m_rdg1stDisplayedOn2;
	CButton	m_btnEG1stNewLocation;
	CButton	m_btnEG1stNewLocation2;
	CButton	m_chk1stVideoWindowActive;
	CButton	m_chkSetLogo;
	CButton	m_chkBorder;
	CButton	m_chkChangeCursor;
	CButton	m_rdgVideoRenderer;
	CButton	m_rdgVideoRenderer5;
	CButton	m_rdgVideoRenderer4;
	CButton	m_rdgVideoRenderer1;
	CButton	m_rdgVideoRenderer3;
	CButton	m_rdgVideoRenderer2;
	CButton	m_rdgVideoRenderer6;
	CButton	m_rdgVideoRenderer7;
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CDisplay)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation

protected:

	// Generated message map functions
	//{{AFX_MSG(CDisplay)
	virtual BOOL OnInitDialog();
	afx_msg void OnbtnEG1stNewLocation();
	afx_msg void OnbtnEG1stNewLocation2();
	afx_msg void OnbtnEG2ndNewLocation();
	afx_msg void OnbtnEG2ndNewLocation2();
	afx_msg void Onchk1stAutoSize();
	afx_msg void Onchk1stEmbedded();
	afx_msg void Onchk1stFullScreen();
	afx_msg void Onchk1stKeepAspectRatio();
	afx_msg void Onchk1stMouseMovesWindow();
	afx_msg void Onchk1stStayOnTop();
	afx_msg void Onchk1stUseVideoPort();
	afx_msg void Onchk1stVideoWindowActive();
	afx_msg void Onchk2ndAutoSize();
	afx_msg void Onchk2ndEmbedded();
	afx_msg void Onchk2ndFullScreen();
	afx_msg void Onchk2ndKeepAspectRatio();
	afx_msg void Onchk2ndMouseMovesWindow();
	afx_msg void Onchk2ndStayOnTop();
	afx_msg void Onchk2ndUseVideoPort();
	afx_msg void Onchk2ndVideoWindowActive();
	afx_msg void OnchkBorder();
	afx_msg void OnchkChangeCursor();
	afx_msg void OnchkSetLogo();
	afx_msg void OnClose();
	afx_msg void Onrdg1stDisplayedOn1();
	afx_msg void Onrdg1stDisplayedOn2();
	afx_msg void Onrdg2ndDisplayedOn1();
	afx_msg void Onrdg2ndDisplayedOn2();
	afx_msg void OnrdgVideoRenderer1();
	afx_msg void OnrdgVideoRenderer2();
	afx_msg void OnrdgVideoRenderer3();
	afx_msg void OnrdgVideoRenderer4();
	afx_msg void OnrdgVideoRenderer5();
	afx_msg void OnrdgVideoRenderer6();
	afx_msg void OnrdgVideoRenderer7();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_DISPLAY_H__14328D20_523D_49FB_8D40_C7C51C44CACD__INCLUDED_)
