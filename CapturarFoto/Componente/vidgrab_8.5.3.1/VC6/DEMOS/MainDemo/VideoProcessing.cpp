// VideoProcessing.cpp : implementation file
//

#include "stdafx.h"
#include "MainDemo.h"
#include "VideoProcessing.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CVideoProcessing dialog

CVideoProcessing::CVideoProcessing(CWnd* pParent /*=NULL*/)
	: CDialog(CVideoProcessing::IDD, pParent)
{
	//{{AFX_DATA_INIT(CVideoProcessing)
		// NOTE: the ClassWizard will add member initialization here
	//}}AFX_DATA_INIT
}

void CVideoProcessing::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CVideoProcessing)
		// NOTE: the ClassWizard will add DDX and DDV calls here
	DDX_Control(pDX, grbSoftwareVideoProcessing, m_grbSoftwareVideoProcessing);
	DDX_Control(pDX, btnResetAll, m_btnResetAll);
	DDX_Control(pDX, rdgVideoRotation, m_rdgVideoRotation);
	DDX_Control(pDX, rdgVideoRotation8, m_rdgVideoRotation8);
	DDX_Control(pDX, rdgVideoRotation7, m_rdgVideoRotation7);
	DDX_Control(pDX, rdgVideoRotation6, m_rdgVideoRotation6);
	DDX_Control(pDX, rdgVideoRotation5, m_rdgVideoRotation5);
	DDX_Control(pDX, rdgVideoRotation1, m_rdgVideoRotation1);
	DDX_Control(pDX, rdgVideoRotation3, m_rdgVideoRotation3);
	DDX_Control(pDX, rdgVideoRotation2, m_rdgVideoRotation2);
	DDX_Control(pDX, rdgVideoRotation4, m_rdgVideoRotation4);
	DDX_Control(pDX, rdgDeinterlacing, m_rdgDeinterlacing);
	DDX_Control(pDX, rdgDeinterlacing3, m_rdgDeinterlacing3);
	DDX_Control(pDX, rdgDeinterlacing2, m_rdgDeinterlacing2);
	DDX_Control(pDX, rdgDeinterlacing1, m_rdgDeinterlacing1);
	DDX_Control(pDX, chkFlipVertical, m_chkFlipVertical);
	DDX_Control(pDX, chkFlipHorizontal, m_chkFlipHorizontal);
	DDX_Control(pDX, chkGreyScale, m_chkGreyScale);
	DDX_Control(pDX, chkInvertColors, m_chkInvertColors);
	DDX_Control(pDX, tbrBrightness, m_tbrBrightness);
	DDX_Control(pDX, tbrContrast, m_tbrContrast);
	DDX_Control(pDX, tbrSaturation, m_tbrSaturation);
	DDX_Control(pDX, tbrHue, m_tbrHue);
	DDX_Control(pDX, grbCropping, m_grbCropping);
	DDX_Control(pDX, chkCroppingEnabled, m_chkCroppingEnabled);
	DDX_Control(pDX, chkCroppingOutbounds, m_chkCroppingOutbounds);
	DDX_Control(pDX, edtCroppingWidth, m_edtCroppingWidth);
	DDX_Control(pDX, edtCroppingHeight, m_edtCroppingHeight);
	DDX_Control(pDX, btnCroppingZoomReset, m_btnCroppingZoomReset);
	DDX_Control(pDX, trkCroppingX, m_trkCroppingX);
	DDX_Control(pDX, trkCroppingY, m_trkCroppingY);
	DDX_Control(pDX, trkCroppingZoom, m_trkCroppingZoom);
	DDX_Control(pDX, grbVMR9Adjust, m_grbVMR9Adjust);
	DDX_Control(pDX, vmr9FixRange, m_vmr9FixRange);
	DDX_Control(pDX, tbrVMR9Brightness, m_tbrVMR9Brightness);
	DDX_Control(pDX, tbrVMR9Contrast, m_tbrVMR9Contrast);
	DDX_Control(pDX, tbrVMR9Saturation, m_tbrVMR9Saturation);
	DDX_Control(pDX, tbrVMR9Hue, m_tbrVMR9Hue);
	//}}AFX_DATA_MAP
}

BEGIN_MESSAGE_MAP(CVideoProcessing, CDialog)
	//{{AFX_MSG_MAP(CVideoProcessing)
	ON_BN_CLICKED(btnCroppingZoomReset, OnbtnCroppingZoomReset)
	ON_BN_CLICKED(btnResetAll, OnbtnResetAll)
	ON_BN_CLICKED(chkCroppingEnabled, OnchkCroppingEnabled)
	ON_BN_CLICKED(chkCroppingOutbounds, OnchkCroppingOutbounds)
	ON_BN_CLICKED(chkFlipHorizontal, OnchkFlipHorizontal)
	ON_BN_CLICKED(chkFlipVertical, OnchkFlipVertical)
	ON_BN_CLICKED(chkGreyScale, OnchkGreyScale)
	ON_BN_CLICKED(chkInvertColors, OnchkInvertColors)
	ON_EN_CHANGE(edtCroppingHeight, OnChangeedtCroppingHeight)
	ON_EN_CHANGE(edtCroppingWidth, OnChangeedtCroppingWidth)
	ON_WM_CLOSE()
	ON_BN_CLICKED(rdgDeinterlacing1, OnrdgDeinterlacing1)
	ON_BN_CLICKED(rdgDeinterlacing2, OnrdgDeinterlacing2)
	ON_BN_CLICKED(rdgDeinterlacing3, OnrdgDeinterlacing3)
	ON_BN_CLICKED(rdgVideoRotation1, OnrdgVideoRotation1)
	ON_BN_CLICKED(rdgVideoRotation2, OnrdgVideoRotation2)
	ON_BN_CLICKED(rdgVideoRotation3, OnrdgVideoRotation3)
	ON_BN_CLICKED(rdgVideoRotation4, OnrdgVideoRotation4)
	ON_BN_CLICKED(rdgVideoRotation5, OnrdgVideoRotation5)
	ON_BN_CLICKED(rdgVideoRotation6, OnrdgVideoRotation6)
	ON_BN_CLICKED(rdgVideoRotation7, OnrdgVideoRotation7)
	ON_BN_CLICKED(rdgVideoRotation8, OnrdgVideoRotation8)
	ON_WM_VSCROLL()
	ON_WM_HSCROLL()
	ON_BN_CLICKED(vmr9FixRange, Onvmr9FixRange)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CVideoProcessing message handlers

BOOL CVideoProcessing::OnInitDialog()
{
	CDialog::OnInitDialog();

	m_tbrBrightness	.SetRange(-128, 128, true);
	m_tbrBrightness	.SetTicFreq(0);

	m_tbrContrast	.SetRange(-128, 128, true);
	m_tbrContrast	.SetTicFreq(0);

	m_tbrSaturation	.SetRange(-64, 64, true);
	m_tbrSaturation	.SetTicFreq(0);

	m_tbrHue	.SetRange(-180, 180, true);
	m_tbrHue	.SetTicFreq(0);

	m_trkCroppingX	.SetRange(0, 30000, true);
	m_trkCroppingX	.SetTicFreq(0);

	m_trkCroppingY	.SetRange(0, 30000, true);
	m_trkCroppingY	.SetTicFreq(0);

	m_trkCroppingZoom.SetRange(0, 1000, true);
	m_trkCroppingZoom.SetTicFreq(50);

	m_vmr9FixRange	.SetCheck(BST_CHECKED);

	m_tbrVMR9Brightness	.SetRange(-128, 128, true);
	m_tbrVMR9Brightness	.SetTicFreq(0);

	m_tbrVMR9Contrast	.SetRange(-128, 128, true);
	m_tbrVMR9Contrast	.SetTicFreq(0);

	m_tbrVMR9Saturation	.SetRange(-64, 64, true);
	m_tbrVMR9Saturation	.SetTicFreq(0);

	m_tbrVMR9Hue	.SetRange(-180, 180, true);
	m_tbrVMR9Hue	.SetTicFreq(0);

	return TRUE;
}

void CVideoProcessing::OnbtnCroppingZoomReset() 
{
	m_trkCroppingZoom.SetPos(100);
	dlg_MainForm->m_VideoGrabber.SetCropping_Zoom(m_trkCroppingZoom.GetPos() / 100.0);
}

void CVideoProcessing::OnbtnResetAll() 
{
	m_rdgVideoRotation1.SetCheck(BST_CHECKED);
	m_rdgVideoRotation2.SetCheck(BST_UNCHECKED);
	m_rdgVideoRotation3.SetCheck(BST_UNCHECKED);
	m_rdgVideoRotation4.SetCheck(BST_UNCHECKED);
	m_rdgVideoRotation5.SetCheck(BST_UNCHECKED);
	m_rdgVideoRotation6.SetCheck(BST_UNCHECKED);
	m_rdgVideoRotation7.SetCheck(BST_UNCHECKED);
	m_rdgVideoRotation8.SetCheck(BST_UNCHECKED);

	m_rdgDeinterlacing1.SetCheck(BST_CHECKED);
	m_rdgDeinterlacing2.SetCheck(BST_UNCHECKED);
	m_rdgDeinterlacing3.SetCheck(BST_UNCHECKED);

	m_tbrBrightness	.SetPos(0);
	m_tbrContrast	.SetPos(0);
	m_tbrSaturation	.SetPos(0);
	m_tbrHue		.SetPos(0);
	dlg_MainForm->m_VideoGrabber.SetVideoProcessing_Brightness	(-m_tbrBrightness.GetPos());
	dlg_MainForm->m_VideoGrabber.SetVideoProcessing_Contrast	(-m_tbrContrast.GetPos());
	dlg_MainForm->m_VideoGrabber.SetVideoProcessing_Saturation	(-m_tbrSaturation.GetPos());
	dlg_MainForm->m_VideoGrabber.SetVideoProcessing_Hue			(-m_tbrHue.GetPos());

	m_chkGreyScale		.SetCheck(BST_UNCHECKED);
	m_chkInvertColors	.SetCheck(BST_UNCHECKED);
	m_chkFlipVertical	.SetCheck(BST_UNCHECKED);
	m_chkFlipHorizontal	.SetCheck(BST_UNCHECKED);
}

void CVideoProcessing::OnchkCroppingEnabled() 
{
	dlg_MainForm->m_VideoGrabber.SetCropping_Enabled(m_chkCroppingEnabled.GetCheck()==BST_CHECKED);
}

void CVideoProcessing::OnchkCroppingOutbounds() 
{
	dlg_MainForm->m_VideoGrabber.SetCropping_Outbounds(m_chkCroppingOutbounds.GetCheck()==BST_CHECKED);
}

void CVideoProcessing::OnchkFlipHorizontal() 
{
	dlg_MainForm->m_VideoGrabber.SetVideoProcessing_FlipHorizontal(m_chkFlipHorizontal.GetCheck()==BST_CHECKED);
}

void CVideoProcessing::OnchkFlipVertical() 
{
	dlg_MainForm->m_VideoGrabber.SetVideoProcessing_FlipVertical(m_chkFlipVertical.GetCheck()==BST_CHECKED);
}

void CVideoProcessing::OnchkGreyScale() 
{
	dlg_MainForm->m_VideoGrabber.SetVideoProcessing_GrayScale(m_chkGreyScale.GetCheck()==BST_CHECKED);
}

void CVideoProcessing::OnchkInvertColors() 
{
	dlg_MainForm->m_VideoGrabber.SetVideoProcessing_InvertColors(m_chkInvertColors.GetCheck()==BST_CHECKED);
}

void CVideoProcessing::OnChangeedtCroppingHeight() 
{
	long CroppingHeight;
	if (IsNumeric(&m_edtCroppingHeight,CroppingHeight))
		dlg_MainForm->m_VideoGrabber.SetCropping_Height(CroppingHeight);
}

void CVideoProcessing::OnChangeedtCroppingWidth() 
{
	long CroppingWidth;
	if (IsNumeric(&m_edtCroppingWidth,CroppingWidth))
		dlg_MainForm->m_VideoGrabber.SetCropping_Width(CroppingWidth);
}

void CVideoProcessing::OnClose() 
{
//?   If Not dlg_MainForm->CanUnload Then
//?      Hide
//?      Cancel = True
//?   End If

	CDialog::OnClose();
}

void CVideoProcessing::OnrdgDeinterlacing1() 
{
	dlg_MainForm->m_VideoGrabber.SetVideoProcessing_Deinterlacing(di_Disabled);
}

void CVideoProcessing::OnrdgDeinterlacing2() 
{
	dlg_MainForm->m_VideoGrabber.SetVideoProcessing_Deinterlacing(di_HalfSize);
}

void CVideoProcessing::OnrdgDeinterlacing3() 
{
	dlg_MainForm->m_VideoGrabber.SetVideoProcessing_Deinterlacing(di_FullSize);
}

void CVideoProcessing::OnrdgVideoRotation1() 
{
	dlg_MainForm->m_VideoGrabber.SetVideoProcessing_Rotation(rt_0_deg);
}

void CVideoProcessing::OnrdgVideoRotation2() 
{
	dlg_MainForm->m_VideoGrabber.SetVideoProcessing_Rotation(rt_90_deg);
}

void CVideoProcessing::OnrdgVideoRotation3() 
{
	dlg_MainForm->m_VideoGrabber.SetVideoProcessing_Rotation(rt_180_deg);
}

void CVideoProcessing::OnrdgVideoRotation4() 
{
	dlg_MainForm->m_VideoGrabber.SetVideoProcessing_Rotation(rt_270_deg);
}

void CVideoProcessing::OnrdgVideoRotation5() 
{
	dlg_MainForm->m_VideoGrabber.SetVideoProcessing_Rotation(rt_0_deg_mirror);
}

void CVideoProcessing::OnrdgVideoRotation6() 
{
	dlg_MainForm->m_VideoGrabber.SetVideoProcessing_Rotation(rt_90_deg_mirror);
}

void CVideoProcessing::OnrdgVideoRotation7() 
{
	dlg_MainForm->m_VideoGrabber.SetVideoProcessing_Rotation(rt_180_deg_mirror);
}

void CVideoProcessing::OnrdgVideoRotation8() 
{
	dlg_MainForm->m_VideoGrabber.SetVideoProcessing_Rotation(rt_270_deg_mirror);
}

void CVideoProcessing::OnVScroll(UINT nSBCode, UINT nPos, CScrollBar* pScrollBar)
{
	if (pScrollBar->m_hWnd==m_tbrBrightness.m_hWnd) {
		dlg_MainForm->m_VideoGrabber.SetVideoProcessing_Brightness(-m_tbrBrightness.GetPos());
	}

	if (pScrollBar->m_hWnd==m_tbrContrast.m_hWnd) {
		dlg_MainForm->m_VideoGrabber.SetVideoProcessing_Contrast(-m_tbrContrast.GetPos());
	}
	
	if (pScrollBar->m_hWnd==m_tbrSaturation.m_hWnd) {
		dlg_MainForm->m_VideoGrabber.SetVideoProcessing_Saturation(-m_tbrSaturation.GetPos());
	}

	if (pScrollBar->m_hWnd==m_tbrHue.m_hWnd) {
		dlg_MainForm->m_VideoGrabber.SetVideoProcessing_Hue(-m_tbrHue.GetPos());
	}
	
	if (pScrollBar->m_hWnd==m_tbrVMR9Brightness.m_hWnd) {
		dlg_MainForm->m_VideoGrabber.SetVMR9ImageAdjustmentValue(true, vmr9_Brightness, m_tbrVMR9Brightness.GetPos(), false);
	}

	if (pScrollBar->m_hWnd==m_tbrVMR9Contrast.m_hWnd) {
		dlg_MainForm->m_VideoGrabber.SetVMR9ImageAdjustmentValue(true, vmr9_Contrast, m_tbrVMR9Contrast.GetPos(), (m_vmr9FixRange.GetCheck()==BST_CHECKED));
	}

	if (pScrollBar->m_hWnd==m_tbrVMR9Saturation.m_hWnd) {
		dlg_MainForm->m_VideoGrabber.SetVMR9ImageAdjustmentValue(true, vmr9_Saturation, m_tbrVMR9Saturation.GetPos(), m_vmr9FixRange.GetCheck()==BST_CHECKED);
	}

	if (pScrollBar->m_hWnd==m_tbrVMR9Hue.m_hWnd) {
		dlg_MainForm->m_VideoGrabber.SetVMR9ImageAdjustmentValue(true, vmr9_Hue, m_tbrVMR9Hue.GetPos(), false);
	}

	if (pScrollBar->m_hWnd==m_trkCroppingY.m_hWnd) {
		// 'trkCroppingX.Max and trkCroppingY.Max are set from the OnResizeVideo event
		dlg_MainForm->m_VideoGrabber.SetCropping_Y(m_trkCroppingY.GetPos());
	}

	CDialog::OnVScroll(nSBCode, nPos, pScrollBar);
}

void CVideoProcessing::OnHScroll(UINT nSBCode, UINT nPos, CScrollBar* pScrollBar) 
{
	if (pScrollBar->m_hWnd==m_trkCroppingX.m_hWnd) {
		// 'trkCroppingX.Max and trkCroppingY.Max are set from the OnResizeVideo event
		dlg_MainForm->m_VideoGrabber.SetCropping_X(m_trkCroppingX.GetPos());
	}
	
	if (pScrollBar->m_hWnd==m_trkCroppingZoom.m_hWnd) {
		dlg_MainForm->m_VideoGrabber.SetCropping_Zoom(m_trkCroppingZoom.GetPos() / 100.0);
	}
	
	CDialog::OnHScroll(nSBCode, nPos, pScrollBar);
}

void CVideoProcessing::Onvmr9FixRange() 
{
	// fixes a possible problem of constrast and saturation range with some video decoders, passed to the SetVMR9ImageAdjustmentValue function below
}
