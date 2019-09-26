// Overlays.cpp : implementation file
//

#include "stdafx.h"
#include "MainDemo.h"
#include "Overlays.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// COverlays dialog

COverlays::COverlays(CWnd* pParent /*=NULL*/)
	: CDialog(COverlays::IDD, pParent)
{
	//{{AFX_DATA_INIT(COverlays)
	//}}AFX_DATA_INIT
}


void COverlays::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(COverlays)
	DDX_Control(pDX, cmbBitmapOverlayTransparentColor, m_cmbBitmapOverlayTransparentColor);
	DDX_Control(pDX, edtAlphaBlendingValue, m_edtAlphaBlendingValue);
	DDX_Control(pDX, chkBitmapOverlayUseTransparentColor, m_chkBitmapOverlayUseTransparentColor);
	DDX_Control(pDX, chkBitmapOverlayAlphaBlending, m_chkBitmapOverlayAlphaBlending);
	DDX_Control(pDX, imgBitmapOverlay, m_ImgBitmapOverlay);
	DDX_Control(pDX, grbTextOverlay, m_grbTextOverlay);
	DDX_Control(pDX, mmoTextOverlayString, m_mmoTextOverlayString);
	DDX_Control(pDX, chkTextOverlayEnabled, m_chkTextOverlayEnabled);
	DDX_Control(pDX, rdgTextOverlayAlign, m_rdgTextOverlayAlign);
	DDX_Control(pDX, rdgTextOverlayAlign1, m_rdgTextOverlayAlign1);
	DDX_Control(pDX, rdgTextOverlayAlign2, m_rdgTextOverlayAlign2);
	DDX_Control(pDX, rdgTextOverlayAlign3, m_rdgTextOverlayAlign3);
	DDX_Control(pDX, edtTextOverlayLeft, m_edtTextOverlayLeft);
	DDX_Control(pDX, edtTextOverlayTop, m_edtTextOverlayTop);
	DDX_Control(pDX, edtTextOverlayWidth, m_edtTextOverlayWidth);
	DDX_Control(pDX, chkTextOverlayTransparent, m_chkTextOverlayTransparent);
	DDX_Control(pDX, grbFreeHand, m_grbFreeHand);
	DDX_Control(pDX, chkFreeHandEnabled, m_chkFreeHandEnabled);
	DDX_Control(pDX, btnFreeHandErase, m_btnFreeHandErase);
	DDX_Control(pDX, grbLinesOverlay, m_grbLinesOverlay);
	DDX_Control(pDX, chkLinesOverlayEnabled, m_chkLinesOverlayEnabled);
	DDX_Control(pDX, grbBitmapOverlay, m_grbBitmapOverlay);
	DDX_Control(pDX, chkBitmapOverlayEnabled, m_chkBitmapOverlayEnabled);
	DDX_Control(pDX, chkBitmapOverlayTransparent, m_chkBitmapOverlayTransparent);
	DDX_Control(pDX, edtBitmapOvlerlayLeft, m_edtBitmapOvlerlayLeft);
	DDX_Control(pDX, edtBitmapOvlerlayTop, m_edtBitmapOvlerlayTop);
	DDX_Control(pDX, btnBitmapOverlayResetSize, m_btnBitmapOverlayResetSize);
	DDX_Control(pDX, edtBitmapOverlaySize, m_edtBitmapOverlaySize);
	DDX_Control(pDX, tbrBitmapOverlaySize, m_tbrBitmapOverlaySize);
	DDX_Control(pDX, lblFrameOverlayRequiresFrameGrabber, m_lblFrameOverlayRequiresFrameGrabber);
	DDX_Control(pDX, btnCreateCustomFont, m_btnCreateCustomFont);
	//}}AFX_DATA_MAP
}

BEGIN_MESSAGE_MAP(COverlays, CDialog)
	//{{AFX_MSG_MAP(COverlays)
	ON_BN_CLICKED(btnBitmapOverlayResetSize, OnbtnBitmapOverlayResetSize)
	ON_BN_CLICKED(btnCreateCustomFont, OnbtnCreateCustomFont)
	ON_BN_CLICKED(btnFreeHandErase, OnbtnFreeHandErase)
	ON_BN_CLICKED(chkBitmapOverlayEnabled, OnchkBitmapOverlayEnabled)
	ON_BN_CLICKED(chkTextOverlayEnabled, OnchkTextOverlayEnabled)
	ON_BN_CLICKED(chkTextOverlayTransparent, OnchkTextOverlayTransparent)
	ON_EN_CHANGE(edtBitmapOvlerlayLeft, OnChangeedtBitmapOvlerlayLeft)
	ON_EN_CHANGE(edtBitmapOvlerlayTop, OnChangeedtBitmapOvlerlayTop)
	ON_EN_CHANGE(edtTextOverlayLeft, OnChangeedtTextOverlayLeft)
	ON_EN_CHANGE(edtTextOverlayTop, OnChangeedtTextOverlayTop)
	ON_EN_CHANGE(edtTextOverlayWidth, OnChangeedtTextOverlayWidth)
	ON_WM_CLOSE()
	ON_EN_CHANGE(mmoTextOverlayString, OnChangemmoTextOverlayString)
	ON_BN_CLICKED(rdgTextOverlayAlign1, OnrdgTextOverlayAlign1)
	ON_BN_CLICKED(rdgTextOverlayAlign2, OnrdgTextOverlayAlign2)
	ON_BN_CLICKED(rdgTextOverlayAlign3, OnrdgTextOverlayAlign3)
	ON_WM_VSCROLL()
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// COverlays message handlers

BOOL COverlays::OnInitDialog()
{
	CDialog::OnInitDialog();

	m_edtTextOverlayLeft	.SetWindowText("5");
	m_edtTextOverlayTop		.SetWindowText("5");
	m_edtTextOverlayWidth	.SetWindowText("140");
	m_edtBitmapOvlerlayLeft	.SetWindowText("50");
	m_edtBitmapOvlerlayTop	.SetWindowText("50");
	m_edtBitmapOverlaySize	.SetWindowText("100%");
	m_tbrBitmapOverlaySize	.SetRange(0, 300, true);
	m_tbrBitmapOverlaySize	.SetPos(100);
	m_tbrBitmapOverlaySize	.SetTicFreq(10);

	return TRUE;
}

void COverlays::UpdateBitmapOverlaySize()
{
	RECT rect;
	m_ImgBitmapOverlay.GetWindowRect(&rect);
	int imgW = rect.right  - rect.left;
	int imgH = rect.bottom - rect.top;

	if (m_tbrBitmapOverlaySize.GetPos()==100)
	{
		dlg_MainForm->BitmapOverlay_Width = imgW;	//	/Screen.TwipsPerPixelX
		dlg_MainForm->BitmapOverlay_Height= imgH;	//	/Screen.TwipsPerPixelY
	} else {
		double kk = m_tbrBitmapOverlaySize.GetPos() / 100.0;
		dlg_MainForm->BitmapOverlay_Width = long(imgW*kk +0.5);	// /Screen.TwipsPerPixelX
		dlg_MainForm->BitmapOverlay_Height= long(imgH*kk +0.5);	// /Screen.TwipsPerPixelY
	}
	cs.Format("%d%%", m_tbrBitmapOverlaySize.GetPos());
	m_edtBitmapOverlaySize.SetWindowText(cs);
}

void COverlays::OnbtnBitmapOverlayResetSize() 
{
	m_tbrBitmapOverlaySize.SetPos(100);
	UpdateBitmapOverlaySize();
}

void COverlays::OnbtnCreateCustomFont() 
{
	HFONT hf = CreateFont(20, 20, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0);
	dlg_MainForm->m_VideoGrabber.SetTextOverlay_Font((long)hf);
	dlg_MainForm->m_VideoGrabber.SetTextOverlay_FontColor(0xC0C0C0); // &HC0C0C0
}

void COverlays::OnbtnFreeHandErase() 
{
	dlg_MainForm->iFreeHandMouseDrawing = 0;
}

void COverlays::OnchkBitmapOverlayEnabled() 
{
	UpdateBitmapOverlaySize();
	IsNumeric(&m_edtBitmapOvlerlayLeft, dlg_MainForm->BitmapOverlay_Left);
	IsNumeric(&m_edtBitmapOvlerlayTop , dlg_MainForm->BitmapOverlay_Top );
}

void COverlays::OnchkTextOverlayEnabled() 
{
	m_mmoTextOverlayString.GetWindowText(cs);
	dlg_MainForm->m_VideoGrabber.SetTextOverlay_String(cs);
	dlg_MainForm->m_VideoGrabber.SetTextOverlay_Enabled(m_chkTextOverlayEnabled.GetCheck()==BST_CHECKED);
}

void COverlays::OnchkTextOverlayTransparent() 
{
	dlg_MainForm->m_VideoGrabber.SetTextOverlay_Transparent(m_chkTextOverlayTransparent.GetCheck()==BST_CHECKED);
}

void COverlays::OnChangeedtBitmapOvlerlayLeft() 
{
	long BitmapOvlerlayLeft;
	if (IsNumeric(&m_edtBitmapOvlerlayLeft,BitmapOvlerlayLeft))
		dlg_MainForm->BitmapOverlay_Left = BitmapOvlerlayLeft;
}

void COverlays::OnChangeedtBitmapOvlerlayTop() 
{
	long BitmapOvlerlayTop;
	if (IsNumeric(&m_edtBitmapOvlerlayTop,BitmapOvlerlayTop))
		dlg_MainForm->BitmapOverlay_Top = BitmapOvlerlayTop;
}

void COverlays::OnChangeedtTextOverlayLeft() 
{
	long TextOverlayLeft;
	if (IsNumeric(&m_edtTextOverlayLeft,TextOverlayLeft))
		dlg_MainForm->m_VideoGrabber.SetTextOverlay_Left(TextOverlayLeft);
}

void COverlays::OnChangeedtTextOverlayTop() 
{
	long TextOverlayTop;
	if (IsNumeric(&m_edtTextOverlayTop,TextOverlayTop))
		dlg_MainForm->m_VideoGrabber.SetTextOverlay_Top(TextOverlayTop);
}

void COverlays::OnChangeedtTextOverlayWidth() 
{
	long TextOverlayWidth;
	if (IsNumeric(&m_edtTextOverlayWidth,TextOverlayWidth))
		dlg_MainForm->m_VideoGrabber.SetTextOverlay_Right(TextOverlayWidth);
}

void COverlays::OnClose() 
{
//?   If Not dlg_MainForm.CanUnload Then
//?      Hide
//?      Cancel = True
//?   End If

	CDialog::OnClose();
}

void COverlays::OnChangemmoTextOverlayString() 
{
	m_mmoTextOverlayString.GetWindowText(cs);
	dlg_MainForm->m_VideoGrabber.SetTextOverlay_String(cs);
}

void COverlays::OnrdgTextOverlayAlign1() 
{
	dlg_MainForm->m_VideoGrabber.SetTextOverlay_Align(tf_Left);
}

void COverlays::OnrdgTextOverlayAlign2() 
{
	dlg_MainForm->m_VideoGrabber.SetTextOverlay_Align(tf_Center);
}

void COverlays::OnrdgTextOverlayAlign3() 
{
	dlg_MainForm->m_VideoGrabber.SetTextOverlay_Align(tf_Right);
}

void COverlays::OnVScroll(UINT nSBCode, UINT nPos, CScrollBar* pScrollBar) 
{
	if (pScrollBar->m_hWnd==m_tbrBitmapOverlaySize.m_hWnd) {
		UpdateBitmapOverlaySize();
	}

	CDialog::OnVScroll(nSBCode, nPos, pScrollBar);
}

