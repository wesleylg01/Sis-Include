#include "stdafx.h"

 CString cs;

void AddLog(CEdit *TextBox, const CString &Line)
{
	CString curText;
	TextBox->GetWindowText(curText);
	curText = curText + "\r\n" + Line;
	TextBox->SetWindowText(curText);
	int nb = curText.GetLength();
	TextBox->SetSel(nb,nb);
}

void SetOptionButtonByIndex(CDialog *Dialog, const int nIDStart, int Indx)
{
	// to implement
}

void EnableOrDisableControls(CWnd *dlg, const int *hControls, BOOL En)
{
	for( ;*hControls; hControls++)
	{
		CWnd *wnd = dlg->GetDlgItem(*hControls);
		if (wnd)
			wnd->EnableWindow(En);
	}
}

void LoadTextBox(CListBox *Dest, const CString &Source)
{
	Dest->ResetContent();

	for(long Startpos=0 ; ; )
	{
		long Endpos = Source.Find("\r",Startpos);	// InStr(Startpos, Source, vbCr)
		if (Endpos<0) break;

		Dest->AddString(Source.Mid(Startpos, Endpos-Startpos));	// Mid(Source, Startpos, Endpos - Startpos));

        Startpos = Endpos + 2;	// skip CR/LF
	}
}

void AssignListToComboBox(CComboBox *Dest, CString Source, long Indx, long MaxIndxLimit) 
{
    Dest->ResetContent();

	long MaxIndxCount = (MaxIndxLimit>0) ? MaxIndxLimit : 99999;
	long Startpos = 0;
	long Endpos = Source.Find("\r", Startpos);

	while ((Endpos >= 0) && (MaxIndxCount > 0))
	{
		Dest->AddString(Source.Mid(Startpos, Endpos - Startpos));
		Startpos = Endpos + 2;	// skip CR/LF
		Endpos = Source.Find("\r", Startpos);	// InStr(Startpos, Source, vbCr)
		MaxIndxCount--;
	}

	if (Indx < Dest->GetCount())
		Dest->SetCurSel(Indx);
}

void FileSearch_Close(TFileSearch &FileSearch)
{
	if (FileSearch.Opened)
	{
		FindClose(FileSearch.Handle);
		FileSearch.Opened = false;
	}
}

CString FileSearch_NextFile(
	CString SearchPath, CString FileKind, 
	BOOL RestartFromFirstFile, TFileSearch &FileSearch)
{
	CString FileSearch_NextFile = "";

	if (RestartFromFirstFile || (!FileSearch.Opened))
	{
		FileSearch_Close(FileSearch);	// let's close any previous opened search

		if (SearchPath.GetLength() > 0)
		{	// let's add a trailing slash if required
			FileSearch.Path = (SearchPath.Right(1)=="\\") 
				? SearchPath : (SearchPath + "\\");
		} else {
			FileSearch.Path = ".\\";
		}

		FileSearch.Handle = FindFirstFile(FileSearch.Path + FileKind, &FileSearch.Data);
		if (FileSearch.Handle != INVALID_HANDLE_VALUE)
		{
			FileSearch_NextFile = FileSearch.Path + FileSearch.Data.cFileName;
			FileSearch.Opened = true;
		}

	} else {
		if (FindNextFile(FileSearch.Handle, &FileSearch.Data) != 0) 
		{
			FileSearch_NextFile = FileSearch.Path + FileSearch.Data.cFileName;
		} else {
			FileSearch_Close(FileSearch);
		}
	}

return FileSearch_NextFile;
}

bool IsNumeric(CEdit *edit, long &Number)
{
	char buf[100];
	edit->GetWindowText(buf,sizeof(buf));
	if (1==sscanf(buf,"%ld", &Number)) return true;
	else {
//		Number = 0;
		return false;
	}
}

CString ToCString(long z) {
	CString cs;
	cs.Format("%ld",z);
	return cs;
}
