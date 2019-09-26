#if !defined(AFX_VIDEOSOURCE_H__F5CE28F6_076A_4C24_927D_70A3AE053064__INCLUDED_)
#define AFX_VIDEOSOURCE_H__F5CE28F6_076A_4C24_927D_70A3AE053064__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// VideoSource.h : header file
//
#include "MainForm.h"

/////////////////////////////////////////////////////////////////////////////
// CVideoSource dialog

class CVideoSource : public CDialog
{
// Construction
public:
	CVideoSource(CWnd* pParent = NULL);   // standard constructor

	CMainForm *dlg_MainForm;

// Dialog Data

	//{{AFX_DATA(CVideoSource)
	enum { IDD = VideoSource };
	CComboBox	m_cboVideoSource;
	CButton	m_grbPreview;
	CButton	m_btnStartPreview;
	CButton	m_btnStopPreview;
	CButton	m_grbFrameRate;
	CButton	m_btnFrameRate;
	CEdit	m_edtFrameRate;
	CButton	m_grbVsVideoCaptureDevice;
	CComboBox	m_cboVideoDevices;
	CComboBox	m_cboVideoInputs;
	CComboBox	m_cboVideoSizes;
	CComboBox	m_cboVideoSubtypes;
	CComboBox	m_cboAnalogVideoStandard;
	CButton	m_chkReduceDVFrameRate;
	CButton	m_grbVsFileOrUrl;
	CButton	m_btnSelectFileOrUrl;
	CEdit	m_edtVideoSourceFileOrUrl;
	CButton	m_grbVsScreenRecording;
	CButton	m_chkScreenRecordingWithCursor;
	CButton	m_grbPreferredVideoSizes;
	CButton	m_rdgPreferredVideoSize1;
	CButton	m_rdgPreferredVideoSize2;
	CButton	m_rdgPreferredVideoSize3;
	CButton	m_rdgPreferredVideoSize4;
	CButton	m_rdgPreferredVideoSize5;
	CButton	m_rdgPreferredVideoSize6;
	CButton	m_rdgPreferredVideoSize7;
	CButton	m_rdgPreferredVideoSize8;
	CButton	m_rdgPreferredVideoSize9;
	CButton	m_rdgPreferredVideoSize10;
	CButton	m_rdgPreferredVideoSize11;
	CButton	m_chkStretchPreferredVideoSize;
	CButton	m_rdgPreferredVideoSize12;
	CButton	m_rdgPreferredVideoSize13;
	CButton	m_grbVideoDevicesDialogs;
	CButton	m_btnDeviceDialog;
	CButton	m_btnStreamDialog;
	CButton	m_btnCameraControlDialog;
	CButton	m_btnVideoQualityDialog;
	CButton	m_btnVideoControlDialog;
	CButton	m_btnAutoRefreshPreview;
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CVideoSource)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:

	// Generated message map functions
	//{{AFX_MSG(CVideoSource)
	virtual BOOL OnInitDialog();
	afx_msg void OnbtnAutoRefreshPreview();
	afx_msg void OnbtnDeviceDialog();
	afx_msg void OnbtnFrameRate();
	afx_msg void OnbtnSelectFileOrUrl();
	afx_msg void OnbtnStartPreview();
	afx_msg void OnbtnStopPreview();
	afx_msg void OnbtnStreamDialog();
	afx_msg void OnSelchangecboVideoSource();
	afx_msg void OnSelchangecboAnalogVideoStandard();
	afx_msg void OnSelchangecboVideoDevices();
	afx_msg void OnSelchangecboVideoInputs();
	afx_msg void OnSelchangecboVideoSizes();
	afx_msg void OnSelchangecboVideoSubtypes();
	afx_msg void OnchkReduceDVFrameRate();
	afx_msg void OnchkScreenRecordingWithCursor();
	afx_msg void OnChangeedtVideoSourceFileOrUrl();
	afx_msg void OnClose();
	afx_msg void OnrdgPreferredVideoSize1();
	afx_msg void OnrdgPreferredVideoSize2();
	afx_msg void OnrdgPreferredVideoSize3();
	afx_msg void OnrdgPreferredVideoSize4();
	afx_msg void OnrdgPreferredVideoSize5();
	afx_msg void OnrdgPreferredVideoSize6();
	afx_msg void OnrdgPreferredVideoSize7();
	afx_msg void OnrdgPreferredVideoSize8();
	afx_msg void OnrdgPreferredVideoSize9();
	afx_msg void OnrdgPreferredVideoSize10();
	afx_msg void OnrdgPreferredVideoSize11();
	afx_msg void OnrdgPreferredVideoSize12();
	afx_msg void OnrdgPreferredVideoSize13();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_VIDEOSOURCE_H__F5CE28F6_076A_4C24_927D_70A3AE053064__INCLUDED_)
