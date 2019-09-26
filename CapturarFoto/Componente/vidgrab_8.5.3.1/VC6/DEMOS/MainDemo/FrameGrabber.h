#if !defined(AFX_FRAMEGRABBER_H__67FE3716_B503_40C8_8A17_60D98867D9B0__INCLUDED_)
#define AFX_FRAMEGRABBER_H__67FE3716_B503_40C8_8A17_60D98867D9B0__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// FrameGrabber.h : header file
//

#include "MainForm.h"

/////////////////////////////////////////////////////////////////////////////
// CFrameGrabber dialog

class CFrameGrabber : public CDialog
{
// Construction
public:
	CFrameGrabber(CWnd* pParent = NULL);   // standard constructor

	void CaptureZoomSize_Change();

	CMainForm *dlg_MainForm;
// Dialog Data

	//{{AFX_DATA(CFrameGrabber)
	enum { IDD = FrameGrabber };
	CEdit	m_mmoFrameCaptureLog;
	CButton	m_btnResetCaptureZoomSize;
	CEdit	m_edtCaptureZoomSize;
	CSliderCtrl	m_tbrCaptureZoomSize;
	CButton	m_rdgAutoFileName;
	CEdit	m_edtAVIAutoFilePrefix;
	CButton	m_rdgAutoFileName1;
	CButton	m_rdgAutoFileName2;
	CButton	m_grbBurstMode;
	CButton	m_btnBurstModeStop;
	CButton	m_btnBurstModeJPEGFile;
	CButton	m_btnBurstModeBMPFile;
	CButton	m_btnBurstModeTBitmap;
	CEdit	m_edtBurstCount;
	CEdit	m_edtBurstInterval;
	CButton	m_grbOneShot;
	CButton	m_chkUseThisFileName;
	CEdit	m_edtUseThisFileName;
	CButton	m_btnOneShotTBitmap;
	CButton	m_btnOneShotBMPFile;
	CButton	m_btnOneShotJPEGFile;
	CButton	m_rgdFrameGrabberFormat;
	CButton	m_rgdFrameGrabberFormat1;
	CButton	m_rgdFrameGrabberFormat2;
	CButton	m_rgdFrameGrabberFormat3;
	CButton	m_rgdFrameGrabberFormat4;
	CButton	m_rgdFrameGrabberFormat5;
	CButton	m_rgdFrameGrabberFormat6;
	CButton	m_rgdFrameGrabber;
	CButton	m_rgdFrameGrabber1;
	CButton	m_rgdFrameGrabber2;
	CButton	m_rgdFrameGrabber3;
	CButton	m_rgdFrameGrabber4;
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CFrameGrabber)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:

	// Generated message map functions
	//{{AFX_MSG(CFrameGrabber)
	virtual BOOL OnInitDialog();
	afx_msg void OnbtnBurstModeBMPFile();
	afx_msg void OnbtnBurstModeJPEGFile();
	afx_msg void OnbtnBurstModeStop();
	afx_msg void OnbtnBurstModeTBitmap();
	afx_msg void OnbtnOneShotBMPFile();
	afx_msg void OnbtnOneShotJPEGFile();
	afx_msg void OnbtnOneShotTBitmap();
	afx_msg void OnbtnResetCaptureZoomSize();
	afx_msg void OnchkUseThisFileName();
	afx_msg void OnChangeedtAVIAutoFilePrefix();
	afx_msg void OnChangeedtBurstCount();
	afx_msg void OnChangeedtBurstInterval();
	afx_msg void OnClose();
	afx_msg void OnrdgAutoFileName1();
	afx_msg void OnrdgAutoFileName2();
	afx_msg void OnrgdFrameGrabberFormat1();
	afx_msg void OnrgdFrameGrabberFormat2();
	afx_msg void OnrgdFrameGrabberFormat3();
	afx_msg void OnrgdFrameGrabberFormat4();
	afx_msg void OnrgdFrameGrabberFormat5();
	afx_msg void OnrgdFrameGrabberFormat6();
	afx_msg void OnrgdFrameGrabber1();
	afx_msg void OnrgdFrameGrabber2();
	afx_msg void OnrgdFrameGrabber3();
	afx_msg void OnrgdFrameGrabber4();
	afx_msg void OnVScroll(UINT nSBCode, UINT nPos, CScrollBar* pScrollBar);
	afx_msg void OnbtnOneShotClipboard();
	afx_msg void OnbtnBurstModeClipboard();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_FRAMEGRABBER_H__67FE3716_B503_40C8_8A17_60D98867D9B0__INCLUDED_)
