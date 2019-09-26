#if !defined(AFX_VIDEOPROCESSING_H__A14A9E4A_6877_4C1B_B6A3_2EDC223DE854__INCLUDED_)
#define AFX_VIDEOPROCESSING_H__A14A9E4A_6877_4C1B_B6A3_2EDC223DE854__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// VideoProcessing.h : header file
//

#include "MainForm.h"

/////////////////////////////////////////////////////////////////////////////
// CVideoProcessing dialog

class CVideoProcessing : public CDialog
{
// Construction
public:
	CVideoProcessing(CWnd* pParent = NULL);   // standard constructor

	CMainForm *dlg_MainForm;

// Dialog Data

	//{{AFX_DATA(CVideoProcessing)
	enum { IDD = VideoProcessing };
	CButton	m_grbSoftwareVideoProcessing;
	CButton	m_btnResetAll;
	CButton	m_rdgVideoRotation;
	CButton	m_rdgVideoRotation8;
	CButton	m_rdgVideoRotation7;
	CButton	m_rdgVideoRotation6;
	CButton	m_rdgVideoRotation5;
	CButton	m_rdgVideoRotation1;
	CButton	m_rdgVideoRotation3;
	CButton	m_rdgVideoRotation2;
	CButton	m_rdgVideoRotation4;
	CButton	m_rdgDeinterlacing;
	CButton	m_rdgDeinterlacing3;
	CButton	m_rdgDeinterlacing2;
	CButton	m_rdgDeinterlacing1;
	CButton	m_chkFlipVertical;
	CButton	m_chkFlipHorizontal;
	CButton	m_chkGreyScale;
	CButton	m_chkInvertColors;
	CSliderCtrl	m_tbrBrightness;
	CSliderCtrl	m_tbrContrast;
	CSliderCtrl	m_tbrSaturation;
	CSliderCtrl	m_tbrHue;
	CButton	m_grbCropping;
	CButton	m_chkCroppingEnabled;
	CButton	m_chkCroppingOutbounds;
	CEdit	m_edtCroppingWidth;
	CEdit	m_edtCroppingHeight;
	CButton	m_btnCroppingZoomReset;
	CSliderCtrl	m_trkCroppingX;
	CSliderCtrl	m_trkCroppingY;
	CSliderCtrl	m_trkCroppingZoom;
	CButton	m_grbVMR9Adjust;
	CButton	m_vmr9FixRange;
	CSliderCtrl	m_tbrVMR9Brightness;
	CSliderCtrl	m_tbrVMR9Contrast;
	CSliderCtrl	m_tbrVMR9Saturation;
	CSliderCtrl	m_tbrVMR9Hue;
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CVideoProcessing)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:

	// Generated message map functions
	//{{AFX_MSG(CVideoProcessing)
	virtual BOOL OnInitDialog();
	afx_msg void OnbtnCroppingZoomReset();
	afx_msg void OnbtnResetAll();
	afx_msg void OnchkCroppingEnabled();
	afx_msg void OnchkCroppingOutbounds();
	afx_msg void OnchkFlipHorizontal();
	afx_msg void OnchkFlipVertical();
	afx_msg void OnchkGreyScale();
	afx_msg void OnchkInvertColors();
	afx_msg void OnChangeedtCroppingHeight();
	afx_msg void OnChangeedtCroppingWidth();
	afx_msg void OnClose();
	afx_msg void OnrdgDeinterlacing1();
	afx_msg void OnrdgDeinterlacing2();
	afx_msg void OnrdgDeinterlacing3();
	afx_msg void OnrdgVideoRotation1();
	afx_msg void OnrdgVideoRotation2();
	afx_msg void OnrdgVideoRotation3();
	afx_msg void OnrdgVideoRotation4();
	afx_msg void OnrdgVideoRotation5();
	afx_msg void OnrdgVideoRotation6();
	afx_msg void OnrdgVideoRotation7();
	afx_msg void OnrdgVideoRotation8();
	afx_msg void OnVScroll(UINT nSBCode, UINT nPos, CScrollBar* pScrollBar);
	afx_msg void OnHScroll(UINT nSBCode, UINT nPos, CScrollBar* pScrollBar);
	afx_msg void Onvmr9FixRange();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_VIDEOPROCESSING_H__A14A9E4A_6877_4C1B_B6A3_2EDC223DE854__INCLUDED_)
