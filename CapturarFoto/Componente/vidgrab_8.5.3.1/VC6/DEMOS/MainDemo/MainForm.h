//{{AFX_INCLUDES()
#include "videograbbervc6.h"
//}}AFX_INCLUDES
#if !defined(AFX_MAINFORM_H__DCE0471F_0FCF_4DE9_A4DB_CC9BBFA877D0__INCLUDED_)
#define AFX_MAINFORM_H__DCE0471F_0FCF_4DE9_A4DB_CC9BBFA877D0__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// MainForm.h : header file
//

/////////////////////////////////////////////////////////////////////////////
// CMainForm dialog

class CMainForm : public CDialog
{
	friend class CVideoSource;

// Construction
public:
	CMainForm(CWnd* pParent = NULL);   // standard constructor

	long BitmapOverlay_Width, BitmapOverlay_Height, BitmapOverlay_Left, BitmapOverlay_Top;
	long iFreeHandMouseDrawing;

	void Form_Load();
	void RefreshVideoDeviceControls();
	void SendDVCommand(TxDVCommand DvCommand);
	void ShowForm (CDialog *Dialog);

// Dialog Data
	CFileDialog	*m_dlgOpen;

	//{{AFX_DATA(CMainForm)
	enum { IDD = MainForm };
	CSliderCtrl	m_tbrPlayer;
	CEdit	m_mmoLog;
	CEdit	m_edtDVDateTime;
	CEdit	m_edtFrameCount;
	CEdit	m_edtStoragePath;
	CButton	m_btnFormAudio;
	CButton	m_btnFormRecording;
	CButton	m_btnFormNetworkStreaming;
	CButton	m_btnFormPlayer;
	CButton	m_btnFormFrameGrabber;
	CButton	m_btnFormMotionDetection;
	CButton	m_btnFormOverlays;
	CButton	m_btnFormVideoProcessing;
	CButton	m_btnFormDisplay;
	CButton	m_btnFormReencoding;
	CButton	m_btnFormTVTuner;
	CButton	m_btnFormVideoSource;
	CVideoGrabberVC6	m_VideoGrabber;
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CMainForm)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:

	// Generated message map functions
	//{{AFX_MSG(CMainForm)
	virtual BOOL OnInitDialog();
	afx_msg void OnbtnFormVideoSource();
	afx_msg void OnbtnFormAudio();
	afx_msg void OnbtnFormRecording();
	afx_msg void OnbtnFormNetworkStreaming();
	afx_msg void OnbtnFormPlayer();
	afx_msg void OnbtnFormFrameGrabber();
	afx_msg void OnbtnFormMotionDetection();
	afx_msg void OnbtnFormOverlays();
	afx_msg void OnbtnFormVideoProcessing();
	afx_msg void OnbtnFormDisplay();
	afx_msg void OnbtnFormReencoding();
	afx_msg void OnbtnFormTVTuner();
	afx_msg void OnChangeedtStoragePath();
	afx_msg void OnClose();
	afx_msg void OnmnuAbout();
	afx_msg void OnmnuDVff();
	afx_msg void OnmnuDVfreeze();
	afx_msg void OnmnuDVmodeShuttle();
	afx_msg void OnmnuDVplay();
	afx_msg void OnmnuDVplayFastestFwd();
	afx_msg void OnmnuDVplayFastestRev();
	afx_msg void OnmnuDVplaySlowestFwd();
	afx_msg void OnmnuDVplaySlowestRev();
	afx_msg void OnmnuDVrecord();
	afx_msg void OnmnuDVrecordFreeze();
	afx_msg void OnmnuDVrew();
	afx_msg void OnmnuDVstepFwd();
	afx_msg void OnmnuDVstepRev();
	afx_msg void OnmnuDVstop();
	afx_msg void OnmnuDVthaw();
	afx_msg void OnmnuRecordStrobe();
	afx_msg void OnHScroll(UINT nSBCode, UINT nPos, CScrollBar* pScrollBar);
	afx_msg void OnOnAudioDeviceSelectedVideograbbervc61();
	afx_msg void OnOnCopyPreallocDataCompletedVideograbbervc61(LPCTSTR SourceFile, LPCTSTR DestFile, BOOL Success);
	afx_msg void OnOnCopyPreallocDataProgressVideograbbervc61(long Percent, double Position, double Duration);
	afx_msg void OnOnCopyPreallocDataStartedVideograbbervc61(LPCTSTR SourceFile, LPCTSTR DestFile);
	afx_msg void OnOnCreatePreallocFileCompletedVideograbbervc61(LPCTSTR FileName, BOOL Success);
	afx_msg void OnOnCreatePreallocFileProgressVideograbbervc61(long Percent, double Position, double Duration);
	afx_msg void OnOnCreatePreallocFileStartedVideograbbervc61(LPCTSTR FileName);
	afx_msg void OnOnDeviceArrivalOrRemovalVideograbbervc61(BOOL IsDeviceArrival, BOOL IsVideoDevice, LPCTSTR DeviceName, long DeviceIndex);
	afx_msg void OnOnDeviceLostVideograbbervc61();
	afx_msg void OnOnDirectNetworkStreamingHostUrlVideograbbervc61(LPCTSTR HostUrl, LPCTSTR HostName, long HostPort);
	afx_msg void OnOnDiskFullVideograbbervc61();
	afx_msg void OnOnDVCommandCompletedVideograbbervc61(long NewStateValue, LPCTSTR NewStateLabel);
	afx_msg void OnOnDVDiscontinuityVideograbbervc61(BOOL FAR* DeliverNewFrame);
	afx_msg void OnOnFrameCaptureCompletedVideograbbervc61(long FrameBitmapHandle, long BitmapWidth, long BitmapHeight, long FrameNumber, double FrameTime, long DestType, LPCTSTR FileName, BOOL Success, long FrameId);
	afx_msg void OnOnFrameOverlayUsingDCVideograbbervc61(long Dc, long FrameNumber, double FrameTime, long FrameId);
	afx_msg void OnOnFrameOverlayUsingDIBVideograbbervc61(long FrameBitmapHandle, long FrameNumber, double FrameTime, long FrameId);
	afx_msg void OnOnFrameProgressVideograbbervc61(long FrameNumber, double FrameTime, long FrameId);
	afx_msg void OnOnInactiveVideograbbervc61();
	afx_msg void OnOnLogVideograbbervc61(long LogType, LPCTSTR Severity, LPCTSTR InfoMsg);
	afx_msg void OnOnMotionDetectedVideograbbervc61(double GlobalMotionRatio, long MaxMotionCellX, long MaxMotionCellY, long FrameBitmapHandle, long FrameNumber, double FrameTime, long FrameId, BOOL FAR* CaptureFrame);
	afx_msg void OnOnMotionNotDetectedVideograbbervc61(long FrameBitmapHandle, long FrameNumber, double FrameTime, long FrameId, BOOL FAR* CaptureFrame);
	afx_msg void OnOnMouseDownVideograbbervc61(long VideoWindow, long Button, long x, long y);
	afx_msg void OnOnMouseMoveVideograbbervc61(long VideoWindow, long x, long y);
	afx_msg void OnOnMouseUpVideograbbervc61(long VideoWindow, long Button, long x, long y);
	afx_msg void OnOnPlayerOpenedVideograbbervc61();
	afx_msg void OnOnPreviewStartedVideograbbervc61();
	afx_msg void OnOnPlayerEndOfStreamVideograbbervc61();
	afx_msg void OnOnRecordingCompletedVideograbbervc61(LPCTSTR FileName, BOOL Success);
	afx_msg void OnOnRecordingReadyToStartVideograbbervc61();
	afx_msg void OnOnRecordingStartedVideograbbervc61(LPCTSTR FileName);
	afx_msg void OnOnReencodingCompletedVideograbbervc61(LPCTSTR SourceFile, LPCTSTR DestFile, BOOL Success);
	afx_msg void OnOnReencodingProgressVideograbbervc61(long Percent, double Position, double Duration);
	afx_msg void OnOnReencodingStartedVideograbbervc61(LPCTSTR SourceFile, LPCTSTR DestFile);
	afx_msg void OnOnReinitializingVideograbbervc61();
	afx_msg void OnOnResizeVideograbbervc61();
	afx_msg void OnOnResizeVideoVideograbbervc61(long SourceWidth, long SourceHeight);
	afx_msg void OnOnTVChannelScanCompletedVideograbbervc61();
	afx_msg void OnOnTVChannelScanStartedVideograbbervc61(long MinChannel, long MaxChannel);
	afx_msg void OnOnTVChannelSelectedVideograbbervc61(long Channel, BOOL Locked, long DefaultVideoFrequency, long OverriddenVideoFrequency, long TunerVideoFrequency, long TunerAudioFrequency);
	afx_msg void OnOnVideoDeviceSelectedVideograbbervc61();
	afx_msg void OnOnVideoFromBitmapsNextFrameNeededVideograbbervc61(BOOL FirstSample, long FAR* BitmapHandle, BOOL FAR* CanFreeBitmapHandle, BSTR FAR* BMPorJPEGFile, BOOL FAR* EndOfData);
	DECLARE_EVENTSINK_MAP()
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}

// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_MAINFORM_H__DCE0471F_0FCF_4DE9_A4DB_CC9BBFA877D0__INCLUDED_)

