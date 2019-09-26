// maindemo.h : main header file for the MAINDEMO application
//

#if !defined(AFX_MAINDEMO_H__170DBF58_6783_44E9_97A8_BCCB4F4CCE0A__INCLUDED_)
#define AFX_MAINDEMO_H__170DBF58_6783_44E9_97A8_BCCB4F4CCE0A__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#ifndef __AFXWIN_H__
	#error include 'stdafx.h' before including this file for PCH
#endif

#include "resource.h"		// main symbols

/////////////////////////////////////////////////////////////////////////////
// CMainDemoApp:
// See maindemo.cpp for the implementation of this class
//

class CMainDemoApp : public CWinApp
{
public:
	CMainDemoApp();

// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CMainDemoApp)
	public:
	virtual BOOL InitInstance();
	//}}AFX_VIRTUAL

// Implementation

	//{{AFX_MSG(CMainDemoApp)
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};


/////////////////////////////////////////////////////////////////////////////

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_MAINDEMO_H__170DBF58_6783_44E9_97A8_BCCB4F4CCE0A__INCLUDED_)
