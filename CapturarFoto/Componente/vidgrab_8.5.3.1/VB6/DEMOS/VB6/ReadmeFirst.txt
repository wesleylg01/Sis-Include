
 OCX install:
 -----------

 Be sure to register the vidgrab_VB6.OCX component before using the VB6 demo projects:

 Start -> Execute -> RegSvr32 [path to the ocx]\vidbgrab_VB6.OCX

 E.g. RegSvr32 c:\vidgrab\VB6\vidgrab_VB6.OCX


 Properties:
 ----------
 
 Some of properties included in the user guide are not published (their values are 

 not stored, so they are not visible with the object explorer), however they exist 

 and you can assign and read  their values (e.g. VideoDevice, AudioInput, etc...)


 Types:
 -----

 The types that described in the user guide begin by "Tx" in the OCX

 (e.g. "TPlaylist" in the user guide is TxPlaylist in the OCX)

 They are all listed in the "EnumeratedType.txt" file included in the package.

  
 OnFrameBitmap event and OnFrameProgress2 events
 -----------------------------------------------

 These events pass as parameter:
  
 - a pointer to a TFrameInfo structure
 - a pointer to a TFrameBitmapInfo structure

 These structures are declared in the "VidGrabUtil.bas" module included with the MainDemo project

 Look at the FrameBitmap and FrameProgress2 events of the MainDemo project for sample code