#if !defined(AFX_NETWORKSTREAMING_H__47EAB96D_97C0_4259_BA9A_17B0F5E2E8D2__INCLUDED_)
#define AFX_NETWORKSTREAMING_H__47EAB96D_97C0_4259_BA9A_17B0F5E2E8D2__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// NetworkStreaming.h : header file
//

#include "MainForm.h"

/////////////////////////////////////////////////////////////////////////////
// CNetworkStreaming dialog

class CNetworkStreaming : public CDialog
{
// Construction
public:
	CNetworkStreaming(CWnd* pParent = NULL);   // standard constructor

	CMainForm *dlg_MainForm;

// Dialog Data

	//{{AFX_DATA(CNetworkStreaming)
	enum { IDD = NetworkStreaming };
	CButton	m_rdgNetworkStreaming;
	CButton	m_rdgNetworkStreaming1;
	CButton	m_rdgNetworkStreaming2;
	CButton	m_rdgNetworkStreaming3;
	CButton	m_btnViewDirectNetworkStreaming;
	CButton	m_grbDirectASFStreaming;
	CEdit	m_edtNetworkPort;
	CEdit	m_edtNetworkMaxUsers;
	CButton	m_grbASFStreamingToWMServer;
	CEdit	m_edtPublishingPoint;
	CButton	m_grbASFSettings;
	CButton	m_chkASFFixedFrameRate;
	CComboBox	m_cmbASFDeinterlaceMode;
	CEdit	m_edtASFVideoWidth;
	CEdit	m_edtASFVideoBitRate;
	CEdit	m_edtASFVideoQuality;
	CEdit	m_edtASFVideoMaxKeyFrameSpacing;
	CEdit	m_edtASFAudioChannels;
	CEdit	m_edtASFVideoHeight;
	CButton	m_grbASFProfiles;
	CListBox	m_lsbProfiles;
	CButton	m_btnShowProfilesList;
	CEdit	m_edtProfileIndex;
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CNetworkStreaming)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:

	// Generated message map functions
	//{{AFX_MSG(CNetworkStreaming)
	virtual BOOL OnInitDialog();
	afx_msg void OnbtnShowProfilesList();
	afx_msg void OnbtnViewDirectNetworkStreaming();
	afx_msg void OnchkASFFixedFrameRate();
	afx_msg void OnSelchangecmbASFDeinterlaceMode();
	afx_msg void OnChangeedtASFAudioChannels();
	afx_msg void OnChangeedtASFVideoBitRate();
	afx_msg void OnChangeedtASFVideoHeight();
	afx_msg void OnChangeedtASFVideoMaxKeyFrameSpacing();
	afx_msg void OnChangeedtASFVideoQuality();
	afx_msg void OnChangeedtASFVideoWidth();
	afx_msg void OnChangeedtNetworkMaxUsers();
	afx_msg void OnChangeedtNetworkPort();
	afx_msg void OnChangeedtProfileIndex();
	afx_msg void OnChangeedtPublishingPoint();
	afx_msg void OnClose();
	afx_msg void OnSelchangelsbProfiles();
	afx_msg void OnrdgNetworkStreaming1();
	afx_msg void OnrdgNetworkStreaming2();
	afx_msg void OnrdgNetworkStreaming3();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_NETWORKSTREAMING_H__47EAB96D_97C0_4259_BA9A_17B0F5E2E8D2__INCLUDED_)
