#if !defined(AFX_RECORDING_H__023C1B92_B087_4E56_9D68_073C3AAADA72__INCLUDED_)
#define AFX_RECORDING_H__023C1B92_B087_4E56_9D68_073C3AAADA72__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// Recording.h : header file
//

#include "MainForm.h"

/////////////////////////////////////////////////////////////////////////////
// CRecording dialog

class CRecording : public CDialog
{
// Construction
public:
	CRecording(CWnd* pParent = NULL);   // standard constructor

	CMainForm *dlg_MainForm;

// Dialog Data

	//{{AFX_DATA(CRecording)
	enum { IDD = Recording };
	CButton	m_chkRecordingPauseCreatesNewFile;
	CButton	m_btnMoreInfo;
	CButton	m_btnStartRecordingImmediately;
	CButton	m_btnStartRecordingControlled;
	CButton	m_btnStopRecording;
	CButton	m_btnRenewRecordingFile;
	CButton	m_grbAVIPauseResume;
	CButton	m_chkRecordingCanPause;
	CButton	m_btnPauseRecording;
	CButton	m_btnResumeRecording;
	CButton	m_rdgCompressMode;
	CButton	m_rdgCompressMode1;
	CButton	m_rdgCompressMode3;
	CButton	m_rdgCompressMode2;
	CButton	m_rdgCompressType;
	CButton	m_rdgCompressType2;
	CButton	m_rdgCompressType3;
	CButton	m_rdgCompressType1;
	CComboBox	m_cboVideoCompressors;
	CButton	m_btnVideoCompressorSettings;
	CComboBox	m_cboAudioCompressors;
	CButton	m_btnAudioCompressorSettings;
	CButton	m_rdgRecordingMethod;
	CButton	m_rdgRecordingMethod1;
	CButton	m_rdgRecordingMethod2;
	CButton	m_chkAudioRecording;
	CComboBox	m_cboAudioFormats;
	CButton	m_chkPreserveNativeFormat;
	CButton	m_chkAVISaveToThisFile;
	CEdit	m_edtRecordingFileName;
	CButton	m_chkOpenDML;
	CButton	m_chkPreallocFile;
	CEdit	m_edtPreallocSize;
	CButton	m_btnCreatePreallocFileNow;
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CRecording)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:

	// Generated message map functions
	//{{AFX_MSG(CRecording)
	virtual BOOL OnInitDialog();
	afx_msg void OnbtnAudioCompressorSettings();
	afx_msg void OnbtnCreatePreallocFileNow();
	afx_msg void OnbtnPauseRecording();
	afx_msg void OnbtnRenewRecordingFile();
	afx_msg void OnbtnResumeRecording();
	afx_msg void OnbtnStartRecordingControlled();
	afx_msg void OnbtnStartRecordingImmediately();
	afx_msg void OnbtnStopRecording();
	afx_msg void OnbtnVideoCompressorSettings();
	afx_msg void OnSelchangecboAudioCompressors();
	afx_msg void OnSelchangecboAudioFormats();
	afx_msg void OnSelchangecboVideoCompressors();
	afx_msg void OnchkAudioRecording();
	afx_msg void OnchkOpenDML();
	afx_msg void OnchkPreallocFile();
	afx_msg void OnchkPreserveNativeFormat();
	afx_msg void OnchkRecordingCanPause();
	afx_msg void OnChangeedtPreallocSize();
	afx_msg void OnClose();
	afx_msg void OnrdgCompressMode1();
	afx_msg void OnrdgCompressMode2();
	afx_msg void OnrdgCompressMode3();
	afx_msg void OnrdgCompressType1();
	afx_msg void OnrdgCompressType2();
	afx_msg void OnrdgCompressType3();
	afx_msg void OnrdgRecordingMethod1();
	afx_msg void OnrdgRecordingMethod2();
	afx_msg void OnbtnMoreInfo();
	afx_msg void OnrdgRecordingMethod3();
	afx_msg void OnchkRecordingPauseCreatesNewFile();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_RECORDING_H__023C1B92_B087_4E56_9D68_073C3AAADA72__INCLUDED_)
