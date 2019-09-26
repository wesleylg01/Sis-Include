// Display.cpp : implementation file
//

#include "stdafx.h"
#include "MainDemo.h"
#include "Display.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CDisplay dialog

CDisplay::CDisplay(CWnd* pParent /*=NULL*/)
	: CDialog(CDisplay::IDD, pParent)
{
	//{{AFX_DATA_INIT(CDisplay)
		// NOTE: the ClassWizard will add member initialization here
	//}}AFX_DATA_INIT
}

void CDisplay::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CDisplay)
		// NOTE: the ClassWizard will add DDX and DDV calls here
	DDX_Control(pDX, chk2ndVideoWindowActive, m_chk2ndVideoWindowActive);
	DDX_Control(pDX, grb2ndVideoWindow, m_grb2ndVideoWindow);
	DDX_Control(pDX, btnEG2ndNewLocation2, m_btnEG2ndNewLocation2);
	DDX_Control(pDX, btnEG2ndNewLocation, m_btnEG2ndNewLocation);
	DDX_Control(pDX, rdg2ndDisplayedOn, m_rdg2ndDisplayedOn);
	DDX_Control(pDX, rdg2ndDisplayedOn2, m_rdg2ndDisplayedOn2);
	DDX_Control(pDX, rdg2ndDisplayedOn1, m_rdg2ndDisplayedOn1);
	DDX_Control(pDX, chk2ndAutoSize, m_chk2ndAutoSize);
	DDX_Control(pDX, chk2ndStayOnTop, m_chk2ndStayOnTop);
	DDX_Control(pDX, chk2ndMouseMovesWindow, m_chk2ndMouseMovesWindow);
	DDX_Control(pDX, chk2ndFullScreen, m_chk2ndFullScreen);
	DDX_Control(pDX, chk2ndUseVideoPort, m_chk2ndUseVideoPort);
	DDX_Control(pDX, chk2ndEmbedded, m_chk2ndEmbedded);
	DDX_Control(pDX, grbMainVideoWindow, m_grbMainVideoWindow);
	DDX_Control(pDX, chk1stEmbedded, m_chk1stEmbedded);
	DDX_Control(pDX, chk1stUseVideoPort, m_chk1stUseVideoPort);
	DDX_Control(pDX, chk1stFullScreen, m_chk1stFullScreen);
	DDX_Control(pDX, chk1stMouseMovesWindow, m_chk1stMouseMovesWindow);
	DDX_Control(pDX, chk1stStayOnTop, m_chk1stStayOnTop);
	DDX_Control(pDX, chk1stAutoSize, m_chk1stAutoSize);
	DDX_Control(pDX, rdg1stDisplayedOn, m_rdg1stDisplayedOn);
	DDX_Control(pDX, rdg1stDisplayedOn1, m_rdg1stDisplayedOn1);
	DDX_Control(pDX, rdg1stDisplayedOn2, m_rdg1stDisplayedOn2);
	DDX_Control(pDX, btnEG1stNewLocation, m_btnEG1stNewLocation);
	DDX_Control(pDX, btnEG1stNewLocation2, m_btnEG1stNewLocation2);
	DDX_Control(pDX, chk1stVideoWindowActive, m_chk1stVideoWindowActive);
	DDX_Control(pDX, chkSetLogo, m_chkSetLogo);
	DDX_Control(pDX, chkBorder, m_chkBorder);
	DDX_Control(pDX, chkChangeCursor, m_chkChangeCursor);
	DDX_Control(pDX, rdgVideoRenderer, m_rdgVideoRenderer);
	DDX_Control(pDX, rdgVideoRenderer1, m_rdgVideoRenderer1);
	DDX_Control(pDX, rdgVideoRenderer3, m_rdgVideoRenderer3);
	DDX_Control(pDX, rdgVideoRenderer2, m_rdgVideoRenderer2);
	DDX_Control(pDX, rdgVideoRenderer4, m_rdgVideoRenderer4);
	DDX_Control(pDX, rdgVideoRenderer5, m_rdgVideoRenderer5);
	DDX_Control(pDX, rdgVideoRenderer6, m_rdgVideoRenderer6);
	DDX_Control(pDX, rdgVideoRenderer7, m_rdgVideoRenderer7);
	//}}AFX_DATA_MAP
}

BEGIN_MESSAGE_MAP(CDisplay, CDialog)
	//{{AFX_MSG_MAP(CDisplay)
	ON_BN_CLICKED(btnEG1stNewLocation, OnbtnEG1stNewLocation)
	ON_BN_CLICKED(btnEG1stNewLocation2, OnbtnEG1stNewLocation2)
	ON_BN_CLICKED(btnEG2ndNewLocation, OnbtnEG2ndNewLocation)
	ON_BN_CLICKED(btnEG2ndNewLocation2, OnbtnEG2ndNewLocation2)
	ON_BN_CLICKED(chk1stAutoSize, Onchk1stAutoSize)
	ON_BN_CLICKED(chk1stEmbedded, Onchk1stEmbedded)
	ON_BN_CLICKED(chk1stFullScreen, Onchk1stFullScreen)
	ON_BN_CLICKED(chk1stMouseMovesWindow, Onchk1stMouseMovesWindow)
	ON_BN_CLICKED(chk1stStayOnTop, Onchk1stStayOnTop)
	ON_BN_CLICKED(chk1stUseVideoPort, Onchk1stUseVideoPort)
	ON_BN_CLICKED(chk1stVideoWindowActive, Onchk1stVideoWindowActive)
	ON_BN_CLICKED(chk2ndAutoSize, Onchk2ndAutoSize)
	ON_BN_CLICKED(chk2ndEmbedded, Onchk2ndEmbedded)
	ON_BN_CLICKED(chk2ndFullScreen, Onchk2ndFullScreen)
	ON_BN_CLICKED(chk2ndMouseMovesWindow, Onchk2ndMouseMovesWindow)
	ON_BN_CLICKED(chk2ndStayOnTop, Onchk2ndStayOnTop)
	ON_BN_CLICKED(chk2ndUseVideoPort, Onchk2ndUseVideoPort)
	ON_BN_CLICKED(chk2ndVideoWindowActive, Onchk2ndVideoWindowActive)
	ON_BN_CLICKED(chkBorder, OnchkBorder)
	ON_BN_CLICKED(chkChangeCursor, OnchkChangeCursor)
	ON_BN_CLICKED(chkSetLogo, OnchkSetLogo)
	ON_WM_CLOSE()
	ON_BN_CLICKED(rdg1stDisplayedOn1, Onrdg1stDisplayedOn1)
	ON_BN_CLICKED(rdg1stDisplayedOn2, Onrdg1stDisplayedOn2)
	ON_BN_CLICKED(rdg2ndDisplayedOn1, Onrdg2ndDisplayedOn1)
	ON_BN_CLICKED(rdg2ndDisplayedOn2, Onrdg2ndDisplayedOn2)
	ON_BN_CLICKED(rdgVideoRenderer1, OnrdgVideoRenderer1)
	ON_BN_CLICKED(rdgVideoRenderer2, OnrdgVideoRenderer2)
	ON_BN_CLICKED(rdgVideoRenderer3, OnrdgVideoRenderer3)
	ON_BN_CLICKED(rdgVideoRenderer4, OnrdgVideoRenderer4)
	ON_BN_CLICKED(rdgVideoRenderer5, OnrdgVideoRenderer5)
	ON_BN_CLICKED(rdgVideoRenderer6, OnrdgVideoRenderer6)
	ON_BN_CLICKED(rdgVideoRenderer7, OnrdgVideoRenderer7)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CDisplay message handlers

BOOL CDisplay::OnInitDialog()
{
	CDialog::OnInitDialog();

	return TRUE;
}

void CDisplay::RefreshDisplayOptions()
{
	// this procedure is called each time a setting of this form is changed,
	// to show what features can be used, according to their respective states

	// NOTE: duplicating 2 times all the components of this form for the 2 windows
	// is not very efficient, this has been done only for a better readability.

	m_chk1stVideoWindowActive	.SetCheck(dlg_MainForm->m_VideoGrabber.GetDisplay_Active());
	m_chk1stEmbedded			.SetCheck(dlg_MainForm->m_VideoGrabber.GetDisplay_Embedded());
	m_chk1stFullScreen			.SetCheck(dlg_MainForm->m_VideoGrabber.GetDisplay_FullScreen());
	m_chk1stStayOnTop			.SetCheck(dlg_MainForm->m_VideoGrabber.GetDisplay_StayOnTop());
	m_chk1stUseVideoPort		.SetCheck(dlg_MainForm->m_VideoGrabber.GetDisplay_VideoPortEnabled());
	m_chk1stMouseMovesWindow	.SetCheck(dlg_MainForm->m_VideoGrabber.GetDisplay_MouseMovesWindow());
	m_chk1stAutoSize			.SetCheck(dlg_MainForm->m_VideoGrabber.GetDisplay_AutoSize());

	SetOptionButtonByIndex (this, rdg1stDisplayedOn, dlg_MainForm->m_VideoGrabber.GetDisplay_Monitor());

//	EnableOrDisableFrameControls(&m_grbMainVideoWindow, dlg_MainForm->m_VideoGrabber.GetDisplay_Active());
	static const int hControls_grbMainVideoWindow[] = {
		chk1stEmbedded, chk1stAutoSize, chk1stStayOnTop, chk1stMouseMovesWindow,
		chk1stFullScreen, chk1stUseVideoPort, 0};
	EnableOrDisableControls(this, hControls_grbMainVideoWindow, dlg_MainForm->m_VideoGrabber.GetDisplay_Active());

	m_grbMainVideoWindow.EnableWindow(dlg_MainForm->m_VideoGrabber.GetDisplay_Active());

	if (dlg_MainForm->m_VideoGrabber.GetDisplay_Active())
	{
		m_chk1stStayOnTop		.EnableWindow( (!dlg_MainForm->m_VideoGrabber.GetDisplay_Embedded()) || dlg_MainForm->m_VideoGrabber.GetDisplay_FullScreen());
		m_chk1stMouseMovesWindow.EnableWindow(!dlg_MainForm->m_VideoGrabber.GetDisplay_Embedded());
		m_rdg1stDisplayedOn		.EnableWindow(!dlg_MainForm->m_VideoGrabber.GetDisplay_Embedded());
		m_btnEG1stNewLocation	.EnableWindow(!dlg_MainForm->m_VideoGrabber.GetDisplay_Embedded());
		m_btnEG1stNewLocation2	.EnableWindow(!dlg_MainForm->m_VideoGrabber.GetDisplay_Embedded());
		m_chk1stUseVideoPort	.EnableWindow( dlg_MainForm->m_VideoGrabber.GetIsVideoPortAvailable());
	}

	m_chk2ndVideoWindowActive	.SetCheck(-dlg_MainForm->m_VideoGrabber.GetDualDisplay_Active());
	m_chk2ndEmbedded			.SetCheck(-dlg_MainForm->m_VideoGrabber.GetDualDisplay_Embedded());
	m_chk2ndFullScreen			.SetCheck(-dlg_MainForm->m_VideoGrabber.GetDualDisplay_FullScreen());
	m_chk2ndStayOnTop			.SetCheck(-dlg_MainForm->m_VideoGrabber.GetDualDisplay_StayOnTop());
	m_chk2ndUseVideoPort		.SetCheck(-dlg_MainForm->m_VideoGrabber.GetDualDisplay_VideoPortEnabled());
	m_chk2ndMouseMovesWindow	.SetCheck(-dlg_MainForm->m_VideoGrabber.GetDualDisplay_MouseMovesWindow());
	m_chk2ndAutoSize			.SetCheck(-dlg_MainForm->m_VideoGrabber.GetDualDisplay_AutoSize());

	SetOptionButtonByIndex (this, rdg2ndDisplayedOn, dlg_MainForm->m_VideoGrabber.GetDualDisplay_Monitor());

//	EnableOrDisableFrameControls(&m_grb2ndVideoWindow, dlg_MainForm->m_VideoGrabber.GetDualDisplay_Active());
	static const int hControls_grb2ndVideoWindow[] = {
		chk2ndEmbedded, chk2ndAutoSize, chk2ndStayOnTop, chk2ndMouseMovesWindow,
		chk2ndFullScreen, chk2ndUseVideoPort, 0};
	EnableOrDisableControls(this, hControls_grb2ndVideoWindow, dlg_MainForm->m_VideoGrabber.GetDualDisplay_Active());

	m_grb2ndVideoWindow.EnableWindow(dlg_MainForm->m_VideoGrabber.GetDualDisplay_Active());

	if (dlg_MainForm->m_VideoGrabber.GetDualDisplay_Active())
	{
		m_chk2ndStayOnTop		.EnableWindow(!dlg_MainForm->m_VideoGrabber.GetDualDisplay_Embedded() || dlg_MainForm->m_VideoGrabber.GetDualDisplay_FullScreen());
		m_chk2ndMouseMovesWindow.EnableWindow(!dlg_MainForm->m_VideoGrabber.GetDualDisplay_Embedded());
		m_rdg2ndDisplayedOn		.EnableWindow(!dlg_MainForm->m_VideoGrabber.GetDualDisplay_Embedded());
		m_btnEG2ndNewLocation	.EnableWindow(!dlg_MainForm->m_VideoGrabber.GetDualDisplay_Embedded());
		m_btnEG2ndNewLocation	.EnableWindow(!dlg_MainForm->m_VideoGrabber.GetDualDisplay_Embedded());
		m_chk2ndUseVideoPort	.EnableWindow( dlg_MainForm->m_VideoGrabber.GetIsVideoPortAvailable());
	}
}

void CDisplay::OnbtnEG1stNewLocation() 
{
	dlg_MainForm->m_VideoGrabber.SetDisplay_AutoSize(true);		// the component"s video size will be used
	dlg_MainForm->m_VideoGrabber.SetDisplay_Embedded(false);	// detach from component
	dlg_MainForm->m_VideoGrabber.Display_SetLocation(10, 10, 320, 240);	// 320 and 240 are not used because of AutoSize above
	RefreshDisplayOptions();
}

void CDisplay::OnbtnEG1stNewLocation2() 
{
	dlg_MainForm->m_VideoGrabber.SetDisplay_AutoSize(false);	// we will specify the size below
	dlg_MainForm->m_VideoGrabber.SetDisplay_Embedded(false);	// detach from component
	dlg_MainForm->m_VideoGrabber.Display_SetLocation(20, 20, 480, 360);	// new size: 480 x 360
	RefreshDisplayOptions();
}

void CDisplay::OnbtnEG2ndNewLocation() 
{
	dlg_MainForm->m_VideoGrabber.SetDualDisplay_AutoSize(true);		// the component"s video size will be used
	dlg_MainForm->m_VideoGrabber.SetDualDisplay_Embedded(false);	// detach from component
	dlg_MainForm->m_VideoGrabber.DualDisplay_SetLocation(510, 10, 320, 240);	// 320 and 240 are not used because of AutoSize above
	RefreshDisplayOptions();
}

void CDisplay::OnbtnEG2ndNewLocation2() 
{
	dlg_MainForm->m_VideoGrabber.SetDualDisplay_AutoSize(false);	// we will specify the size below
	dlg_MainForm->m_VideoGrabber.SetDualDisplay_Embedded(false);	// detach from component
	dlg_MainForm->m_VideoGrabber.DualDisplay_SetLocation(520, 30, 480, 360);	// new size: 480 x 360
	RefreshDisplayOptions();
}

void CDisplay::Onchk1stAutoSize() 
{
	dlg_MainForm->m_VideoGrabber.SetDisplay_AutoSize(m_chk1stAutoSize.GetCheck()==BST_CHECKED);
	RefreshDisplayOptions();
}

void CDisplay::Onchk1stEmbedded() 
{
	dlg_MainForm->m_VideoGrabber.SetDisplay_Embedded(m_chk1stEmbedded.GetCheck()==BST_CHECKED);
	RefreshDisplayOptions();
}

void CDisplay::Onchk1stFullScreen() 
{
	dlg_MainForm->m_VideoGrabber.SetDisplay_FullScreen(m_chk1stFullScreen.GetCheck()==BST_CHECKED);
	RefreshDisplayOptions();
}

void CDisplay::Onchk1stMouseMovesWindow() 
{
	dlg_MainForm->m_VideoGrabber.SetDisplay_MouseMovesWindow(m_chk1stMouseMovesWindow.GetCheck()==BST_CHECKED);
	RefreshDisplayOptions();
}

void CDisplay::Onchk1stStayOnTop() 
{
	dlg_MainForm->m_VideoGrabber.SetDisplay_StayOnTop(m_chk1stStayOnTop.GetCheck()==BST_CHECKED);
	RefreshDisplayOptions();
}

void CDisplay::Onchk1stUseVideoPort() 
{
	dlg_MainForm->m_VideoGrabber.SetDisplay_VideoPortEnabled(m_chk1stUseVideoPort.GetCheck()==BST_CHECKED);
	RefreshDisplayOptions();
}

void CDisplay::Onchk1stVideoWindowActive() 
{
	dlg_MainForm->m_VideoGrabber.SetDisplay_Active(m_chk1stVideoWindowActive.GetCheck()==BST_CHECKED);
	RefreshDisplayOptions();
}

void CDisplay::Onchk2ndAutoSize() 
{
	dlg_MainForm->m_VideoGrabber.SetDualDisplay_AutoSize(m_chk2ndAutoSize.GetCheck()==BST_CHECKED);
	RefreshDisplayOptions();
}

void CDisplay::Onchk2ndEmbedded() 
{
	dlg_MainForm->m_VideoGrabber.SetDualDisplay_Embedded(m_chk2ndEmbedded.GetCheck()==BST_CHECKED);
	RefreshDisplayOptions();
}

void CDisplay::Onchk2ndFullScreen() 
{
	dlg_MainForm->m_VideoGrabber.SetDualDisplay_FullScreen(m_chk2ndFullScreen.GetCheck()==BST_CHECKED);
	RefreshDisplayOptions();
}

void CDisplay::Onchk2ndMouseMovesWindow() 
{
	dlg_MainForm->m_VideoGrabber.SetDualDisplay_MouseMovesWindow(m_chk2ndMouseMovesWindow.GetCheck()==BST_CHECKED);
	RefreshDisplayOptions();
}

void CDisplay::Onchk2ndStayOnTop() 
{
	dlg_MainForm->m_VideoGrabber.SetDualDisplay_StayOnTop(m_chk2ndStayOnTop.GetCheck()==BST_CHECKED);
	RefreshDisplayOptions();
}

void CDisplay::Onchk2ndUseVideoPort() 
{
	dlg_MainForm->m_VideoGrabber.SetDualDisplay_VideoPortEnabled(m_chk2ndUseVideoPort.GetCheck()==BST_CHECKED);
	RefreshDisplayOptions();
}

void CDisplay::Onchk2ndVideoWindowActive() 
{
	dlg_MainForm->m_VideoGrabber.SetDualDisplay_Active(m_chk2ndVideoWindowActive.GetCheck()==BST_CHECKED);
	RefreshDisplayOptions();
}

void CDisplay::OnchkBorder() 
{
	dlg_MainForm->m_VideoGrabber.SetBorderStyle(m_chkBorder.GetCheck()==BST_CHECKED ? bsSingle : bsNone);
}

void CDisplay::OnchkChangeCursor() 
{
	dlg_MainForm->m_VideoGrabber.SetVideoCursor( 
		m_chkChangeCursor.GetCheck()==BST_CHECKED ? cr_cross : cr_Default );
}

void CDisplay::OnchkSetLogo() 
{
	if (m_chkSetLogo.GetCheck()==BST_CHECKED) {
		CStatic *stImg = (CStatic *) GetDlgItem(imgLogo);
		stImg->ShowWindow(SW_HIDE);
		dlg_MainForm->m_VideoGrabber.SetLogoFromHBitmap((long)stImg->GetBitmap());  // imgLogo.Picture.Handle
		dlg_MainForm->m_VideoGrabber.SetLogoLayout(lg_Stretched);
		dlg_MainForm->m_VideoGrabber.SetLogoDisplayed(true);
	} else {
		dlg_MainForm->m_VideoGrabber.SetLogoDisplayed(false);
	}
}

void CDisplay::OnClose() 
{
//?   If Not MainForm.CanUnload Then
//?      Hide
//?      Cancel = True
//?   End If

	CDialog::OnClose();
}

void CDisplay::Onrdg1stDisplayedOn1() 
{
	dlg_MainForm->m_VideoGrabber.SetDisplay_Monitor(0);
	RefreshDisplayOptions();
}

void CDisplay::Onrdg1stDisplayedOn2() 
{
	dlg_MainForm->m_VideoGrabber.SetDisplay_Monitor(1);
	RefreshDisplayOptions();
}

void CDisplay::Onrdg2ndDisplayedOn1() 
{
	dlg_MainForm->m_VideoGrabber.SetDualDisplay_Monitor(0);
	RefreshDisplayOptions();
}

void CDisplay::Onrdg2ndDisplayedOn2() 
{
	dlg_MainForm->m_VideoGrabber.SetDualDisplay_Monitor(1);
	RefreshDisplayOptions();
}

void CDisplay::OnrdgVideoRenderer1() 
{
	dlg_MainForm->m_VideoGrabber.SetVideoRenderer(vr_AutoSelect);
}

void CDisplay::OnrdgVideoRenderer2() 
{
	dlg_MainForm->m_VideoGrabber.SetVideoRenderer(vr_VMR9);
}

void CDisplay::OnrdgVideoRenderer3() 
{
	dlg_MainForm->m_VideoGrabber.SetVideoRenderer(vr_VMR7);
}

void CDisplay::OnrdgVideoRenderer4() 
{
	dlg_MainForm->m_VideoGrabber.SetVideoRenderer(vr_StandardRenderer);
}

void CDisplay::OnrdgVideoRenderer5() 
{
	dlg_MainForm->m_VideoGrabber.SetVideoRenderer(vr_OverlayRenderer);
}

void CDisplay::OnrdgVideoRenderer6() 
{
	dlg_MainForm->m_VideoGrabber.SetVideoRenderer(vr_RecordingPriority);
}

void CDisplay::OnrdgVideoRenderer7() 
{
	dlg_MainForm->m_VideoGrabber.SetVideoRenderer(vr_None);
}
