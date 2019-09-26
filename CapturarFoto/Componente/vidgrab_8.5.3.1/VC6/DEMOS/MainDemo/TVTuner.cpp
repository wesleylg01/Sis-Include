// TVTuner.cpp : implementation file
//

#include "stdafx.h"
#include "MainDemo.h"
#include "TVTuner.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CTVTuner dialog

CTVTuner::CTVTuner(CWnd* pParent /*=NULL*/)
	: CDialog(CTVTuner::IDD, pParent)
{
	//{{AFX_DATA_INIT(CTVTuner)
		// NOTE: the ClassWizard will add member initialization here
	//}}AFX_DATA_INIT
}

void CTVTuner::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CTVTuner)
		// NOTE: the ClassWizard will add DDX and DDV calls here
	DDX_Control(pDX, mmoChannelLog, m_mmoChannelLog);
	DDX_Control(pDX, grbTVChannel, m_grbTVChannel);
	DDX_Control(pDX, edtTVChannel, m_edtTVChannel);
	DDX_Control(pDX, btnSelect, m_btnSelect);
	DDX_Control(pDX, grbFrequencyOverride, m_grbFrequencyOverride);
	DDX_Control(pDX, edtChannelFrequency, m_edtChannelFrequency);
	DDX_Control(pDX, Command22, m_Command22);
	DDX_Control(pDX, Command23, m_Command23);
	DDX_Control(pDX, chkEnableFrequencyOverrides, m_chkEnableFrequencyOverrides);
	DDX_Control(pDX, grbTVScan, m_grbTVScan);
	DDX_Control(pDX, btnStartScan, m_btnStartScan);
	DDX_Control(pDX, btnStopScan, m_btnStopScan);
	DDX_Control(pDX, grbTunerCountryCode, m_grbTunerCountryCode);
	DDX_Control(pDX, rdgTunerInputType, m_rdgTunerInputType);
	DDX_Control(pDX, rdgTunerInputType1, m_rdgTunerInputType1);
	DDX_Control(pDX, rdgTunerInputType2, m_rdgTunerInputType2);
	DDX_Control(pDX, grbCountryCode, m_grbCountryCode);
	DDX_Control(pDX, edtCountryCode, m_edtCountryCode);
	DDX_Control(pDX, btnSetCountryCode, m_btnSetCountryCode);
	DDX_Control(pDX, btnResetAllOverrides, m_btnResetAllOverrides);
	//}}AFX_DATA_MAP
}

BEGIN_MESSAGE_MAP(CTVTuner, CDialog)
	//{{AFX_MSG_MAP(CTVTuner)
	ON_BN_CLICKED(btnResetAllOverrides, OnbtnResetAllOverrides)
	ON_BN_CLICKED(btnSelect, OnbtnSelect)
	ON_BN_CLICKED(btnSetCountryCode, OnbtnSetCountryCode)
	ON_BN_CLICKED(btnStartScan, OnbtnStartScan)
	ON_BN_CLICKED(btnStopScan, OnbtnStopScan)
	ON_BN_CLICKED(chkEnableFrequencyOverrides, OnchkEnableFrequencyOverrides)
	ON_BN_CLICKED(Command22, OnCommand22)
	ON_BN_CLICKED(Command23, OnCommand23)
	ON_WM_CLOSE()
	ON_BN_CLICKED(rdgTunerInputType1, OnrdgTunerInputType1)
	ON_BN_CLICKED(rdgTunerInputType2, OnrdgTunerInputType2)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CTVTuner message handlers

BOOL CTVTuner::OnInitDialog()
{
	CDialog::OnInitDialog();

	return TRUE;
}

void CTVTuner::OnbtnResetAllOverrides() 
{
	dlg_MainForm->m_VideoGrabber.TVClearFrequencyOverrides();
}

void CTVTuner::OnbtnSelect() 
{
	long TVChannel;
	if (IsNumeric(&m_edtTVChannel,TVChannel))
		dlg_MainForm->m_VideoGrabber.SetTVChannel(TVChannel);
}

void CTVTuner::OnbtnSetCountryCode() 
{
	long CountryCode;
	if (IsNumeric(&m_edtCountryCode,CountryCode))
		dlg_MainForm->m_VideoGrabber.SetTVCountryCode(CountryCode);
}

void CTVTuner::OnbtnStartScan() 
{
	dlg_MainForm->m_VideoGrabber.TVStartAutoScan();
}

void CTVTuner::OnbtnStopScan() 
{
	if (dlg_MainForm->m_VideoGrabber.TVStopAutoScan())
		AddLog(&m_mmoChannelLog, "stopping autoscan...");
}

void CTVTuner::OnchkEnableFrequencyOverrides() 
{
	dlg_MainForm->m_VideoGrabber.SetTVUseFrequencyOverrides(m_chkEnableFrequencyOverrides.GetCheck()==BST_CHECKED);
}

void CTVTuner::OnCommand22() 
{
	long TVChannel, ChannelFrequency;
	if (IsNumeric(&m_edtTVChannel,TVChannel) && IsNumeric(&m_edtChannelFrequency,ChannelFrequency))
		dlg_MainForm->m_VideoGrabber.TVSetChannelFrequencyOverride(TVChannel,ChannelFrequency);
}

void CTVTuner::OnCommand23() 
{
	long TVChannel;
	if (IsNumeric(&m_edtTVChannel,TVChannel))
		dlg_MainForm->m_VideoGrabber.TVSetChannelFrequencyOverride(TVChannel, -1);
}

void CTVTuner::OnClose() 
{
//?   If Not dlg_MainForm.CanUnload Then
//?      Hide
//?      Cancel = True
//?   End If

	CDialog::OnClose();
}

void CTVTuner::OnrdgTunerInputType1() 
{
	dlg_MainForm->m_VideoGrabber.SetTVTunerInputType(TunerInputCable);
}

void CTVTuner::OnrdgTunerInputType2() 
{
	dlg_MainForm->m_VideoGrabber.SetTVTunerInputType(TunerInputAntenna);
}
