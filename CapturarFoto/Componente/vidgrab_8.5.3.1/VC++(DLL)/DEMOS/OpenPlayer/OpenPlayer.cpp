
#include "stdafx.h"
#include "..\..\TVideoGrabber.h"

const int MAXSTRINGLEN = 500;

wchar_t *VideoClipFileName = L"you don't have specified the clip to open!"; // SPECIFY THE FILE NAME OF THE CLIP TO OPEN HERE

void CALLBACK OnPlayerOpened (int Object, int Sender) 
{
	CVideoGrabber *VideoGrabberSender = (CVideoGrabber*) (Sender);

	wchar_t *PlayerFileName = VideoGrabberSender->GetPlayerFileName ();
	MessageBoxW (0, PlayerFileName, L"playing: ", 0);
	SysFreeString (PlayerFileName);
}

int APIENTRY WinMain(HINSTANCE hInstance,
                     HINSTANCE hPrevInstance,
                     LPSTR     lpCmdLine,
                     int       nCmdShow)
{

	CVideoGrabber *VideoGrabber = new CVideoGrabber ();
	VideoGrabber->SetDisplay_Embedded (false);
	VideoGrabber->SetOnPlayerOpened (OnPlayerOpened);
	VideoGrabber->Display_SetLocation (100, 100, 320, 240);
	VideoGrabber->SetPlayerFileName (VideoClipFileName); 
	if (! VideoGrabber->OpenPlayer()) 
		MessageBoxW (0, VideoClipFileName, L"failed to open:", 0);
	{
	}
	MessageBoxW (0, L"click OK to destroy the component", L"", 0);

	delete (VideoGrabber);

	return 0;
}



