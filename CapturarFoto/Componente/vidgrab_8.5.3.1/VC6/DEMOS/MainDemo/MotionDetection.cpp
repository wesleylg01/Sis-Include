// MotionDetection.cpp : implementation file
//

#include "stdafx.h"
#include "MainDemo.h"
#include "MotionDetection.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CMotionDetection dialog

CMotionDetection::CMotionDetection(CWnd* pParent /*=NULL*/)
	: CDialog(CMotionDetection::IDD, pParent)
{
	//{{AFX_DATA_INIT(CMotionDetection)
		// NOTE: the ClassWizard will add member initialization here
	//}}AFX_DATA_INIT
}

void CMotionDetection::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CMotionDetection)
		// NOTE: the ClassWizard will add DDX and DDV calls here
	DDX_Control(pDX, imgMotionDetected, m_imgMotionDetected);
	DDX_Control(pDX, chkMotionDetectionEnabled, m_chkMotionDetectionEnabled);
	DDX_Control(pDX, chkReduceVideoNoise, m_chkReduceVideoNoise);
	DDX_Control(pDX, btnShowGridDialog, m_btnShowGridDialog);
	DDX_Control(pDX, chkCompareRed, m_chkCompareRed);
	DDX_Control(pDX, chk_GreyScale, m_chk_GreyScale);
	DDX_Control(pDX, chkCompareBlue, m_chkCompareBlue);
	DDX_Control(pDX, chkCompareGreen, m_chkCompareGreen);
	DDX_Control(pDX, grbGridString, m_grbGridString);
	DDX_Control(pDX, edtGrid, m_edtGrid);
	DDX_Control(pDX, lblGridValid, m_lblGridValid);
	DDX_Control(pDX, edtGridColCount, m_edtGridColCount);
	DDX_Control(pDX, edtGridRowCount, m_edtGridRowCount);
	DDX_Control(pDX, btnApplyGridSize, m_btnApplyGridSize);
	DDX_Control(pDX, edtXCell, m_edtXCell);
	DDX_Control(pDX, edtYCell, m_edtYCell);
	DDX_Control(pDX, btnSetCellsSensitivity, m_btnSetCellsSensitivity);
	DDX_Control(pDX, edtCellSensitivity, m_edtCellSensitivity);
	DDX_Control(pDX, grbXYMaxMotion, m_grbXYMaxMotion);
	DDX_Control(pDX, edtMaxMotionXY, m_edtMaxMotionXY);
	DDX_Control(pDX, edtMaxMotionCoord, m_edtMaxMotionCoord);
	DDX_Control(pDX, grbMotionRatio, m_grbMotionRatio);
	DDX_Control(pDX, edtMotionRatio, m_edtMotionRatio);
	DDX_Control(pDX, mmoSensitivityGrid, m_mmoSensitivityGrid);
	DDX_Control(pDX, mmoMotionGrid, m_mmoMotionGrid);
	DDX_Control(pDX, lblMotionDetectorRequiresFrameGrabber, m_lblMotionDetectorRequiresFrameGrabber);
	DDX_Control(pDX, updGlobalGridSensitivity, m_updGlobalGridSensitivity);
	DDX_Control(pDX, updGridColCount, m_updGridColCount);
	DDX_Control(pDX, updGridRowCount, m_updGridRowCount);
	DDX_Control(pDX, updXCell, m_updXCell);
	DDX_Control(pDX, updYCell, m_updYCell);
	DDX_Control(pDX, updCellSensitivity, m_updCellSensitivity);
	//}}AFX_DATA_MAP
}

BEGIN_MESSAGE_MAP(CMotionDetection, CDialog)
	//{{AFX_MSG_MAP(CMotionDetection)
	ON_BN_CLICKED(btnApplyGridSize, OnbtnApplyGridSize)
	ON_BN_CLICKED(btnSetCellsSensitivity, OnbtnSetCellsSensitivity)
	ON_BN_CLICKED(btnShowGridDialog, OnbtnShowGridDialog)
	ON_BN_CLICKED(chk_GreyScale, OnGreyScale)
	ON_BN_CLICKED(chkCompareBlue, OnchkCompareBlue)
	ON_BN_CLICKED(chkCompareGreen, OnchkCompareGreen)
	ON_BN_CLICKED(chkCompareRed, OnchkCompareRed)
	ON_BN_CLICKED(chkMotionDetectionEnabled, OnchkMotionDetectionEnabled)
	ON_BN_CLICKED(chkReduceVideoNoise, OnchkReduceVideoNoise)
	ON_EN_CHANGE(edtGrid, OnChangeedtGrid)
	ON_WM_CLOSE()
	ON_NOTIFY(UDN_DELTAPOS, updGlobalGridSensitivity, OnDeltaposupdGlobalGridSensitivity)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CMotionDetection message handlers

BOOL CMotionDetection::OnInitDialog()
{
	CDialog::OnInitDialog();

	m_updGlobalGridSensitivity	.SetRange(0, 10);

	m_edtGridColCount	.SetWindowText("10");
	m_edtGridRowCount	.SetWindowText("10");
	m_updGridColCount	.SetRange(0, 10);
	m_updGridRowCount	.SetRange(0, 10);
	m_edtXCell	.SetWindowText("10");
	m_edtYCell	.SetWindowText("10");
	m_updXCell	.SetRange(0, 10);
	m_updYCell	.SetRange(0, 10);
	m_edtCellSensitivity.SetWindowText("10");
	m_updCellSensitivity.SetRange(0, 10);

	return TRUE;
}

void CMotionDetection::OnbtnApplyGridSize() 
{
	long ColCount, RowCount;
	if (IsNumeric(&m_edtGridColCount, ColCount) && IsNumeric(&m_edtGridRowCount, RowCount))
	{
		dlg_MainForm->m_VideoGrabber.MotionDetector_SetGridSize(ColCount, RowCount);
		m_edtGrid.SetWindowText(dlg_MainForm->m_VideoGrabber.GetMotionDetector_Grid());
		m_mmoSensitivityGrid.SetWindowText(dlg_MainForm->m_VideoGrabber.MotionDetector_Get2DTextGrid());
	}
}

void CMotionDetection::OnbtnSetCellsSensitivity() 
{
	long XCell, YCell, CellSens;
	if (IsNumeric(&m_edtXCell,XCell) && IsNumeric(&m_edtYCell,YCell) && IsNumeric(&m_edtCellSensitivity,CellSens))
	{
		dlg_MainForm->m_VideoGrabber.MotionDetector_SetCellSensitivity(XCell, YCell, CellSens);
		m_edtGrid.SetWindowText(dlg_MainForm->m_VideoGrabber.GetMotionDetector_Grid());
		m_mmoSensitivityGrid.SetWindowText(dlg_MainForm->m_VideoGrabber.MotionDetector_Get2DTextGrid());
	}
}

void CMotionDetection::OnbtnShowGridDialog() 
{
	if ((dlg_MainForm->m_VideoGrabber.GetCurrentState()!=cs_Preview) && (dlg_MainForm->m_VideoGrabber.GetCurrentState()!=cs_Recording)) 
		AfxMessageBox("you should start preview or recording to see the video frame under the grid");

	if (!dlg_MainForm->m_VideoGrabber.GetMotionDetector_Enabled())
		AfxMessageBox("you should enable the motion detector first (MotionDetector_Enabled = true) to see the video frame under the grid");

	if ((dlg_MainForm->m_VideoGrabber.GetMotionDetector_GridXCount()>30) || (dlg_MainForm->m_VideoGrabber.GetMotionDetector_GridYCount() > 30))
		AfxMessageBox("the grid will be too dense to be edited through the dialog, you should use SetGridCell");

	dlg_MainForm->m_VideoGrabber.MotionDetector_ShowGridDialog();
	m_edtGrid.SetWindowText(dlg_MainForm->m_VideoGrabber.GetMotionDetector_Grid());
	m_mmoSensitivityGrid.SetWindowText(dlg_MainForm->m_VideoGrabber.MotionDetector_Get2DTextGrid());
}

void CMotionDetection::OnGreyScale() 
{
	dlg_MainForm->m_VideoGrabber.SetMotionDetector_GreyScale(m_chk_GreyScale.GetCheck()==BST_CHECKED);
}

void CMotionDetection::OnchkCompareBlue() 
{
	dlg_MainForm->m_VideoGrabber.SetMotionDetector_CompareBlue(m_chkCompareBlue.GetCheck()==BST_CHECKED);
}

void CMotionDetection::OnchkCompareGreen() 
{
	dlg_MainForm->m_VideoGrabber.SetMotionDetector_CompareGreen(m_chkCompareGreen.GetCheck()==BST_CHECKED);
}

void CMotionDetection::OnchkCompareRed() 
{
	dlg_MainForm->m_VideoGrabber.SetMotionDetector_CompareRed(m_chkCompareRed.GetCheck()==BST_CHECKED);
}

void CMotionDetection::OnchkMotionDetectionEnabled() 
{
	dlg_MainForm->m_VideoGrabber.SetMotionDetector_Enabled(m_chkMotionDetectionEnabled.GetCheck()==BST_CHECKED);
}

void CMotionDetection::OnchkReduceVideoNoise() 
{
	dlg_MainForm->m_VideoGrabber.SetMotionDetector_ReduceVideoNoise(m_chkReduceVideoNoise.GetCheck()==BST_CHECKED);
}

void CMotionDetection::OnChangeedtGrid() 
{
	m_edtGrid.GetWindowText(cs);
	dlg_MainForm->m_VideoGrabber.SetMotionDetector_Grid(cs);

	if (dlg_MainForm->m_VideoGrabber.GetMotionDetector_IsGridValid())
		m_lblGridValid.SetWindowText("valid");
	else
		m_lblGridValid.SetWindowText("INVALID!");

	m_mmoSensitivityGrid.SetWindowText(dlg_MainForm->m_VideoGrabber.MotionDetector_Get2DTextGrid());
}

void CMotionDetection::OnClose() 
{
//?   If Not dlg_MainForm.CanUnload Then
//?      Hide
//?      Cancel = True
//?   End If

	CDialog::OnClose();
}

void CMotionDetection::OnDeltaposupdGlobalGridSensitivity(NMHDR* pNMHDR, LRESULT* pResult)
{
	NM_UPDOWN* pNMUpDown = (NM_UPDOWN*)pNMHDR;

	if (pNMUpDown->iDelta == -1) {
		dlg_MainForm->m_VideoGrabber.MotionDetector_GloballyIncOrDecSensitivity(-1);
		m_edtGrid.SetWindowText(dlg_MainForm->m_VideoGrabber.GetMotionDetector_Grid());
	}

	if (pNMUpDown->iDelta == 1) {
		dlg_MainForm->m_VideoGrabber.MotionDetector_GloballyIncOrDecSensitivity (1);
		m_edtGrid.SetWindowText(dlg_MainForm->m_VideoGrabber.GetMotionDetector_Grid());
	}
	
	*pResult = 0;
}
