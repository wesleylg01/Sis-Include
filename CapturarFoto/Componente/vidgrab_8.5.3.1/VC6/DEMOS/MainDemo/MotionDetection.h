#if !defined(AFX_MOTIONDETECTION_H__68ED8086_8A2C_4768_8199_4AE88DFE778D__INCLUDED_)
#define AFX_MOTIONDETECTION_H__68ED8086_8A2C_4768_8199_4AE88DFE778D__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// MotionDetection.h : header file
//

#include "MainForm.h"

/////////////////////////////////////////////////////////////////////////////
// CMotionDetection dialog

class CMotionDetection : public CDialog
{
// Construction
public:
	CMotionDetection(CWnd* pParent = NULL);   // standard constructor

	CMainForm *dlg_MainForm;

// Dialog Data

	//{{AFX_DATA(CMotionDetection)
	enum { IDD = MotionDetection };
	CStatic	m_imgMotionDetected;
	CButton	m_chkMotionDetectionEnabled;
	CButton	m_chkReduceVideoNoise;
	CButton	m_btnShowGridDialog;
	CButton	m_chkCompareRed;
	CButton	m_chk_GreyScale;
	CButton	m_chkCompareBlue;
	CButton	m_chkCompareGreen;
	CButton	m_grbGridString;
	CEdit	m_edtGrid;
	CStatic	m_lblGridValid;
	CEdit	m_edtGridColCount;
	CEdit	m_edtGridRowCount;
	CButton	m_btnApplyGridSize;
	CEdit	m_edtXCell;
	CEdit	m_edtYCell;
	CButton	m_btnSetCellsSensitivity;
	CEdit	m_edtCellSensitivity;
	CButton	m_grbXYMaxMotion;
	CEdit	m_edtMaxMotionXY;
	CEdit	m_edtMaxMotionCoord;
	CButton	m_grbMotionRatio;
	CEdit	m_edtMotionRatio;
	CEdit	m_mmoSensitivityGrid;
	CEdit	m_mmoMotionGrid;
	CStatic	m_lblMotionDetectorRequiresFrameGrabber;
	CSpinButtonCtrl	m_updGlobalGridSensitivity;
	CSpinButtonCtrl	m_updGridColCount;
	CSpinButtonCtrl	m_updGridRowCount;
	CSpinButtonCtrl	m_updXCell;
	CSpinButtonCtrl	m_updYCell;
	CSpinButtonCtrl	m_updCellSensitivity;
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CMotionDetection)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:

	// Generated message map functions
	//{{AFX_MSG(CMotionDetection)
	virtual BOOL OnInitDialog();
	afx_msg void OnbtnApplyGridSize();
	afx_msg void OnbtnSetCellsSensitivity();
	afx_msg void OnbtnShowGridDialog();
	afx_msg void OnGreyScale();
	afx_msg void OnchkCompareBlue();
	afx_msg void OnchkCompareGreen();
	afx_msg void OnchkCompareRed();
	afx_msg void OnchkMotionDetectionEnabled();
	afx_msg void OnchkReduceVideoNoise();
	afx_msg void OnChangeedtGrid();
	afx_msg void OnClose();
	afx_msg void OnDeltaposupdGlobalGridSensitivity(NMHDR* pNMHDR, LRESULT* pResult);
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_MOTIONDETECTION_H__68ED8086_8A2C_4768_8199_4AE88DFE778D__INCLUDED_)
