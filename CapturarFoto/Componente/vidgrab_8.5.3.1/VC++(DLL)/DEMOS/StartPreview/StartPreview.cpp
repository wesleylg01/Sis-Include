
#include "stdafx.h"
#include "..\..\TVideoGrabber.h"

const int MAXSTRINGLEN = 500;

HBITMAP CopyFrameBitmap (HBITMAP FrameBitmapHandle)
{
	DIBSECTION DibSection;
	BOOL Ok = false;
	void *ppVBits;

	if ( !GetObject(FrameBitmapHandle,  sizeof(DIBSECTION), &DibSection)) return NULL;
	HDC hScr = GetDC(NULL);
	if (! hScr) return NULL;

	HBITMAP hDestBitmap = CreateDIBSection (hScr, (BITMAPINFO*) &DibSection.dsBmih, DIB_RGB_COLORS, &ppVBits, 0, 0);
	ReleaseDC(NULL, hScr);

	if (hDestBitmap) {
		HDC SrcDc = CreateCompatibleDC (NULL);
		if (SrcDc) {
			HDC DestDc = CreateCompatibleDC (NULL);
			if (DestDc) {
				HBITMAP hSrcDestBitmap = (HBITMAP) SelectObject (SrcDc, FrameBitmapHandle); 
				HBITMAP hOldDestBitmap = (HBITMAP) SelectObject (DestDc, hDestBitmap); 
				Ok = BitBlt (DestDc, 0, 0, DibSection.dsBm.bmWidth, DibSection.dsBm.bmHeight, SrcDc, 0, 0, SRCCOPY); 
				SelectObject (DestDc, hOldDestBitmap); 
				SelectObject (SrcDc, hSrcDestBitmap); 
				DeleteDC (DestDc);
			}
			DeleteDC (SrcDc);
		}
	}
	if (Ok) {
		return hDestBitmap;
	}
	else {
		if (hDestBitmap) {
			DeleteObject (hDestBitmap);
		}
		return NULL;
	}
}

void CALLBACK OnFrameBitmap  ( int Object,  int Sender,  TFrameInfo *FrameInfo,  TFrameBitmapInfo *BitmapInfo)
{
	HBITMAP CurrentBitmap = (HBITMAP) BitmapInfo->bitmapHandle;
	// ...
	// do what you need with the Current frame bitmap handle
	// ...
}

void CALLBACK OnPreviewStarted (int Object, int Sender) 
{
	CVideoGrabber *VideoGrabberSender = (CVideoGrabber*) (Sender);

	wchar_t *DeviceName = VideoGrabberSender->GetVideoDeviceName ();
	MessageBoxW (0, DeviceName, L"previewing: ", 0);
	SysFreeString (DeviceName);
}

int APIENTRY WinMain(HINSTANCE hInstance,
                     HINSTANCE hPrevInstance,
                     LPSTR     lpCmdLine,
                     int       nCmdShow)
{

	CVideoGrabber *VideoGrabber = new CVideoGrabber ();

	VideoGrabber->SetVideoDevice (0); // 1st video capture in the VideoDevices list

	/*
	 // THIS CODE SELECTS THE VIDEODEVICE BY ITS NAME IN THE VIDEODEVICES LIST
	int VideoDeviceIndex = VideoGrabber->VideoDeviceIndex ("Logitech QuickCam Ultra Vision (WDM)"); // replace by the name of your capture device as it appears in the VideoDevices list
	if (VideoDeviceIndex > -1) {
		VideoGrabber->SetVideoDevice (VideoDeviceIndex); 
	}
	*/

	int AnalogVideoStandardIndex = VideoGrabber->AnalogVideoStandardIndex (L"PAL B");
	if (AnalogVideoStandardIndex > -1) {
		VideoGrabber->SetAnalogVideoStandard (AnalogVideoStandardIndex);
	}

	int VideoSizeIndex = VideoGrabber->VideoSizeIndex (L"640x480");
	if (VideoSizeIndex > -1) {
		VideoGrabber->SetVideoSize (VideoSizeIndex);
	}

	VideoGrabber->SetDisplay_Embedded (false);
	VideoGrabber->SetDisplay_AutoSize (true);
	VideoGrabber->Display_SetLocation (100, 100, 320, 240); // 320, 240 ignored when Display_Autosize = true

	VideoGrabber->SetOnPreviewStarted (OnPreviewStarted);
	VideoGrabber->SetOnFrameBitmap (OnFrameBitmap);

	if (VideoGrabber->StartPreview()) 
	{
	}	
	MessageBoxW (0, L"click OK to destroy the component", L"", 0);

	delete (VideoGrabber);

	return 0;
}




