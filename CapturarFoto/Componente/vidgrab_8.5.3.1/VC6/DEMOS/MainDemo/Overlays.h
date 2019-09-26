#if !defined(AFX_OVERLAYS_H__494CB516_5715_44B9_9850_18AF1E593FF4__INCLUDED_)
#define AFX_OVERLAYS_H__494CB516_5715_44B9_9850_18AF1E593FF4__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// Overlays.h : header file
//

#include "MainForm.h"

/////////////////////////////////////////////////////////////////////////////
// COverlays dialog

class COverlays : public CDialog
{
// Construction
public:
	COverlays(CWnd* pParent = NULL);   // standard constructor

	void UpdateBitmapOverlaySize();

	CMainForm *dlg_MainForm;

// Dialog Data

	//{{AFX_DATA(COverlays)
	enum { IDD = Overlays };
	CComboBox	m_cmbBitmapOverlayTransparentColor;
	CEdit	m_edtAlphaBlendingValue;
	CButton	m_chkBitmapOverlayUseTransparentColor;
	CButton	m_chkBitmapOverlayAlphaBlending;
	CStatic	m_ImgBitmapOverlay;
	CButton	m_grbTextOverlay;
	CEdit	m_mmoTextOverlayString;
	CButton	m_chkTextOverlayEnabled;
	CButton	m_rdgTextOverlayAlign;
	CButton	m_rdgTextOverlayAlign1;
	CButton	m_rdgTextOverlayAlign2;
	CButton	m_rdgTextOverlayAlign3;
	CEdit	m_edtTextOverlayLeft;
	CEdit	m_edtTextOverlayTop;
	CEdit	m_edtTextOverlayWidth;
	CButton	m_chkTextOverlayTransparent;
	CButton	m_grbFreeHand;
	CButton	m_chkFreeHandEnabled;
	CButton	m_btnFreeHandErase;
	CButton	m_grbLinesOverlay;
	CButton	m_chkLinesOverlayEnabled;
	CButton	m_grbBitmapOverlay;
	CButton	m_chkBitmapOverlayEnabled;
	CButton	m_chkBitmapOverlayTransparent;
	CEdit	m_edtBitmapOvlerlayLeft;
	CEdit	m_edtBitmapOvlerlayTop;
	CButton	m_btnBitmapOverlayResetSize;
	CEdit	m_edtBitmapOverlaySize;
	CSliderCtrl	m_tbrBitmapOverlaySize;
	CStatic	m_lblFrameOverlayRequiresFrameGrabber;
	CButton	m_btnCreateCustomFont;
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(COverlays)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:

	// Generated message map functions
	//{{AFX_MSG(COverlays)
	virtual BOOL OnInitDialog();
	afx_msg void OnbtnBitmapOverlayResetSize();
	afx_msg void OnbtnCreateCustomFont();
	afx_msg void OnbtnFreeHandErase();
	afx_msg void OnchkBitmapOverlayEnabled();
	afx_msg void OnchkTextOverlayEnabled();
	afx_msg void OnchkTextOverlayTransparent();
	afx_msg void OnChangeedtBitmapOvlerlayLeft();
	afx_msg void OnChangeedtBitmapOvlerlayTop();
	afx_msg void OnChangeedtTextOverlayLeft();
	afx_msg void OnChangeedtTextOverlayTop();
	afx_msg void OnChangeedtTextOverlayWidth();
	afx_msg void OnClose();
	afx_msg void OnChangemmoTextOverlayString();
	afx_msg void OnrdgTextOverlayAlign1();
	afx_msg void OnrdgTextOverlayAlign2();
	afx_msg void OnrdgTextOverlayAlign3();
	afx_msg void OnVScroll(UINT nSBCode, UINT nPos, CScrollBar* pScrollBar);
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_OVERLAYS_H__494CB516_5715_44B9_9850_18AF1E593FF4__INCLUDED_)
