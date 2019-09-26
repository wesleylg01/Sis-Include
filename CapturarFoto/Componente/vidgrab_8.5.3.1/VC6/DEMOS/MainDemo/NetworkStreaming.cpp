// NetworkStreaming.cpp : implementation file
//

#include "stdafx.h"
#include "MainDemo.h"
#include "NetworkStreaming.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CNetworkStreaming dialog

CNetworkStreaming::CNetworkStreaming(CWnd* pParent /*=NULL*/)
	: CDialog(CNetworkStreaming::IDD, pParent)
{
	//{{AFX_DATA_INIT(CNetworkStreaming)
		// NOTE: the ClassWizard will add member initialization here
	//}}AFX_DATA_INIT
}

void CNetworkStreaming::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CNetworkStreaming)
		// NOTE: the ClassWizard will add DDX and DDV calls here
	DDX_Control(pDX, rdgNetworkStreaming, m_rdgNetworkStreaming);
	DDX_Control(pDX, rdgNetworkStreaming1, m_rdgNetworkStreaming1);
	DDX_Control(pDX, rdgNetworkStreaming2, m_rdgNetworkStreaming2);
	DDX_Control(pDX, rdgNetworkStreaming3, m_rdgNetworkStreaming3);
	DDX_Control(pDX, btnViewDirectNetworkStreaming, m_btnViewDirectNetworkStreaming);
	DDX_Control(pDX, grbDirectASFStreaming, m_grbDirectASFStreaming);
	DDX_Control(pDX, edtNetworkPort, m_edtNetworkPort);
	DDX_Control(pDX, edtNetworkMaxUsers, m_edtNetworkMaxUsers);
	DDX_Control(pDX, grbASFStreamingToWMServer, m_grbASFStreamingToWMServer);
	DDX_Control(pDX, edtPublishingPoint, m_edtPublishingPoint);
	DDX_Control(pDX, grbASFSettings, m_grbASFSettings);
	DDX_Control(pDX, chkASFFixedFrameRate, m_chkASFFixedFrameRate);
	DDX_Control(pDX, cmbASFDeinterlaceMode, m_cmbASFDeinterlaceMode);
	DDX_Control(pDX, edtASFVideoWidth, m_edtASFVideoWidth);
	DDX_Control(pDX, edtASFVideoBitRate, m_edtASFVideoBitRate);
	DDX_Control(pDX, edtASFVideoQuality, m_edtASFVideoQuality);
	DDX_Control(pDX, edtASFVideoMaxKeyFrameSpacing, m_edtASFVideoMaxKeyFrameSpacing);
	DDX_Control(pDX, edtASFAudioChannels, m_edtASFAudioChannels);
	DDX_Control(pDX, edtASFVideoHeight, m_edtASFVideoHeight);
	DDX_Control(pDX, grbASFProfiles, m_grbASFProfiles);
	DDX_Control(pDX, lsbProfiles, m_lsbProfiles);
	DDX_Control(pDX, btnShowProfilesList, m_btnShowProfilesList);
	DDX_Control(pDX, edtProfileIndex, m_edtProfileIndex);
	//}}AFX_DATA_MAP
}

BEGIN_MESSAGE_MAP(CNetworkStreaming, CDialog)
	//{{AFX_MSG_MAP(CNetworkStreaming)
	ON_BN_CLICKED(btnShowProfilesList, OnbtnShowProfilesList)
	ON_BN_CLICKED(btnViewDirectNetworkStreaming, OnbtnViewDirectNetworkStreaming)
	ON_BN_CLICKED(chkASFFixedFrameRate, OnchkASFFixedFrameRate)
	ON_CBN_SELCHANGE(cmbASFDeinterlaceMode, OnSelchangecmbASFDeinterlaceMode)
	ON_EN_CHANGE(edtASFAudioChannels, OnChangeedtASFAudioChannels)
	ON_EN_CHANGE(edtASFVideoBitRate, OnChangeedtASFVideoBitRate)
	ON_EN_CHANGE(edtASFVideoHeight, OnChangeedtASFVideoHeight)
	ON_EN_CHANGE(edtASFVideoMaxKeyFrameSpacing, OnChangeedtASFVideoMaxKeyFrameSpacing)
	ON_EN_CHANGE(edtASFVideoQuality, OnChangeedtASFVideoQuality)
	ON_EN_CHANGE(edtASFVideoWidth, OnChangeedtASFVideoWidth)
	ON_EN_CHANGE(edtNetworkMaxUsers, OnChangeedtNetworkMaxUsers)
	ON_EN_CHANGE(edtNetworkPort, OnChangeedtNetworkPort)
	ON_EN_CHANGE(edtProfileIndex, OnChangeedtProfileIndex)
	ON_EN_CHANGE(edtPublishingPoint, OnChangeedtPublishingPoint)
	ON_WM_CLOSE()
	ON_LBN_SELCHANGE(lsbProfiles, OnSelchangelsbProfiles)
	ON_BN_CLICKED(rdgNetworkStreaming1, OnrdgNetworkStreaming1)
	ON_BN_CLICKED(rdgNetworkStreaming2, OnrdgNetworkStreaming2)
	ON_BN_CLICKED(rdgNetworkStreaming3, OnrdgNetworkStreaming3)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CNetworkStreaming message handlers

BOOL CNetworkStreaming::OnInitDialog()
{
	CDialog::OnInitDialog();

	m_edtNetworkPort	.SetWindowText("0");
	m_cmbASFDeinterlaceMode	.AddString("adm_NotInterlaced");
	m_cmbASFDeinterlaceMode	.AddString("adm_DeinterlaceNormal");
	m_cmbASFDeinterlaceMode	.AddString("adm_DeinterlaceHalfSize");
	m_cmbASFDeinterlaceMode	.AddString("adm_DeinterlaceHalfSizeDoubleRate");
	m_cmbASFDeinterlaceMode	.AddString("adm_DeinterlaceInverseTelecine");
	m_cmbASFDeinterlaceMode	.AddString("adm_DeinterlaceVerticalHalfSizeDoubleRate");

	return TRUE;
}

void CNetworkStreaming::OnbtnShowProfilesList() 
{
	LoadTextBox(&m_lsbProfiles, dlg_MainForm->m_VideoGrabber.GetASFProfiles());
}

void CNetworkStreaming::OnbtnViewDirectNetworkStreaming() 
{
	if (dlg_MainForm->m_VideoGrabber.GetStreamingURL() != "")
		ShellExecute(0, "open", dlg_MainForm->m_VideoGrabber.GetStreamingURL(), "", "", SW_SHOW);
}

void CNetworkStreaming::OnchkASFFixedFrameRate() 
{
	dlg_MainForm->m_VideoGrabber.SetASFFixedFrameRate(m_chkASFFixedFrameRate.GetCheck()==BST_CHECKED);
}

void CNetworkStreaming::OnSelchangecmbASFDeinterlaceMode() 
{
	dlg_MainForm->m_VideoGrabber.SetASFDeinterlaceMode(m_cmbASFDeinterlaceMode.GetCurSel());
}

void CNetworkStreaming::OnChangeedtASFAudioChannels() 
{
	long ASFAudioChannels;
	if (IsNumeric(&m_edtASFAudioChannels, ASFAudioChannels))
		dlg_MainForm->m_VideoGrabber.SetASFAudioChannels(ASFAudioChannels);
}

void CNetworkStreaming::OnChangeedtASFVideoBitRate()
{
	long ASFVideoBitRate;
	if (IsNumeric(&m_edtASFVideoBitRate, ASFVideoBitRate) && ASFVideoBitRate>0)
		dlg_MainForm->m_VideoGrabber.SetASFVideoBitRate(ASFVideoBitRate);
}

void CNetworkStreaming::OnChangeedtASFVideoHeight() 
{
	long ASFVideoHeight;
	if (IsNumeric(&m_edtASFVideoHeight,ASFVideoHeight) && ASFVideoHeight>0)
		dlg_MainForm->m_VideoGrabber.SetASFVideoHeight(ASFVideoHeight);
}

void CNetworkStreaming::OnChangeedtASFVideoMaxKeyFrameSpacing() 
{
	long ASFVideoMaxKeyFrameSpacing;
	if (IsNumeric(&m_edtASFVideoMaxKeyFrameSpacing,ASFVideoMaxKeyFrameSpacing))
		dlg_MainForm->m_VideoGrabber.SetASFVideoMaxKeyFrameSpacing(ASFVideoMaxKeyFrameSpacing);
}

void CNetworkStreaming::OnChangeedtASFVideoQuality() 
{
	long ASFVideoQuality;
	if (IsNumeric(&m_edtASFVideoQuality,ASFVideoQuality) && ASFVideoQuality>=0)
		dlg_MainForm->m_VideoGrabber.SetASFVideoQuality(ASFVideoQuality);
}

void CNetworkStreaming::OnChangeedtASFVideoWidth() 
{
	long ASFVideoWidth;
	if (IsNumeric(&m_edtASFVideoWidth,ASFVideoWidth) && ASFVideoWidth>0)
		dlg_MainForm->m_VideoGrabber.SetASFVideoWidth(ASFVideoWidth);
}

void CNetworkStreaming::OnChangeedtNetworkMaxUsers() 
{
	long NetworkPort;
	if (IsNumeric(&m_edtNetworkPort,NetworkPort) && NetworkPort>=0)
		dlg_MainForm->m_VideoGrabber.SetASFNetworkPort(NetworkPort);
}

void CNetworkStreaming::OnChangeedtNetworkPort() 
{
	long NetworkMaxUsers;
	if (IsNumeric(&m_edtNetworkMaxUsers,NetworkMaxUsers) && NetworkMaxUsers>0)
            dlg_MainForm->m_VideoGrabber.SetASFNetworkMaxUsers(NetworkMaxUsers);
}

void CNetworkStreaming::OnChangeedtProfileIndex() 
{
	long ProfileIndex;
	if (IsNumeric(&m_edtProfileIndex,ProfileIndex))
		dlg_MainForm->m_VideoGrabber.SetASFProfile(ProfileIndex);
}

void CNetworkStreaming::OnChangeedtPublishingPoint() 
{
	m_edtPublishingPoint.GetWindowText(cs);
	dlg_MainForm->m_VideoGrabber.SetASFMediaServerPublishingPoint(cs);
}

void CNetworkStreaming::OnClose() 
{
//?   If Not dlg_MainForm.CanUnload Then
//?      Hide
//?      Cancel = True
//?   End If
	
	CDialog::OnClose();
}

void CNetworkStreaming::OnSelchangelsbProfiles() 
{
	if (m_lsbProfiles.GetCount() > 0)
	{
		dlg_MainForm->m_VideoGrabber.SetASFProfile(m_lsbProfiles.GetCurSel());
		m_edtProfileIndex.SetWindowText(ToCString(dlg_MainForm->m_VideoGrabber.GetASFProfile()));
	}
}

void CNetworkStreaming::OnrdgNetworkStreaming1() 
{
	dlg_MainForm->m_VideoGrabber.SetNetworkStreaming(ns_Disabled);
	m_btnViewDirectNetworkStreaming.EnableWindow(false);
}

void CNetworkStreaming::OnrdgNetworkStreaming2() 
{
	dlg_MainForm->m_VideoGrabber.SetNetworkStreaming(ns_ASFDirectNetworkStreaming);
	m_btnViewDirectNetworkStreaming.EnableWindow(true);
}

void CNetworkStreaming::OnrdgNetworkStreaming3() 
{
	dlg_MainForm->m_VideoGrabber.SetNetworkStreaming(ns_ASFStreamingToPublishingPoint);
	m_btnViewDirectNetworkStreaming.EnableWindow(false);
}
