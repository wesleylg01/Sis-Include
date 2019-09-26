# Microsoft Developer Studio Project File - Name="MainDemo" - Package Owner=<4>
# Microsoft Developer Studio Generated Build File, Format Version 6.00
# ** DO NOT EDIT **

# TARGTYPE "Win32 (x86) Application" 0x0101

CFG=MainDemo - Win32 Debug
!MESSAGE This is not a valid makefile. To build this project using NMAKE,
!MESSAGE use the Export Makefile command and run
!MESSAGE 
!MESSAGE NMAKE /f "MainDemo.mak".
!MESSAGE 
!MESSAGE You can specify a configuration when running NMAKE
!MESSAGE by defining the macro CFG on the command line. For example:
!MESSAGE 
!MESSAGE NMAKE /f "MainDemo.mak" CFG="MainDemo - Win32 Debug"
!MESSAGE 
!MESSAGE Possible choices for configuration are:
!MESSAGE 
!MESSAGE "MainDemo - Win32 Release" (based on "Win32 (x86) Application")
!MESSAGE "MainDemo - Win32 Debug" (based on "Win32 (x86) Application")
!MESSAGE 

# Begin Project
# PROP AllowPerConfigDependencies 0
# PROP Scc_ProjName ""
# PROP Scc_LocalPath ""
CPP=cl.exe
MTL=midl.exe
RSC=rc.exe

!IF  "$(CFG)" == "MainDemo - Win32 Release"

# PROP BASE Use_MFC 6
# PROP BASE Use_Debug_Libraries 0
# PROP BASE Output_Dir "Release"
# PROP BASE Intermediate_Dir "Release"
# PROP BASE Target_Dir ""
# PROP Use_MFC 6
# PROP Use_Debug_Libraries 0
# PROP Output_Dir "Release"
# PROP Intermediate_Dir "Release"
# PROP Target_Dir ""
# ADD BASE CPP /nologo /MD /W3 /GX /O2 /D "WIN32" /D "NDEBUG" /D "_WINDOWS" /D "_AFXDLL" /Yu"stdafx.h" /FD /c
# ADD CPP /nologo /MD /W3 /GX /O2 /D "WIN32" /D "NDEBUG" /D "_WINDOWS" /D "_AFXDLL" /D "_MBCS" /FR /Yu"stdafx.h" /FD /c
# ADD BASE MTL /nologo /D "NDEBUG" /mktyplib203 /win32
# ADD MTL /nologo /D "NDEBUG" /mktyplib203 /win32
# ADD BASE RSC /l 0x419 /d "NDEBUG" /d "_AFXDLL"
# ADD RSC /l 0x419 /d "NDEBUG" /d "_AFXDLL"
BSC32=bscmake.exe
# ADD BASE BSC32 /nologo
# ADD BSC32 /nologo
LINK32=link.exe
# ADD BASE LINK32 /nologo /subsystem:windows /machine:I386
# ADD LINK32 /nologo /subsystem:windows /machine:I386

!ELSEIF  "$(CFG)" == "MainDemo - Win32 Debug"

# PROP BASE Use_MFC 6
# PROP BASE Use_Debug_Libraries 1
# PROP BASE Output_Dir "Debug"
# PROP BASE Intermediate_Dir "Debug"
# PROP BASE Target_Dir ""
# PROP Use_MFC 6
# PROP Use_Debug_Libraries 1
# PROP Output_Dir "Debug"
# PROP Intermediate_Dir "Debug"
# PROP Target_Dir ""
# ADD BASE CPP /nologo /MDd /W3 /Gm /GX /ZI /Od /D "WIN32" /D "_DEBUG" /D "_WINDOWS" /D "_AFXDLL" /Yu"stdafx.h" /FD /GZ /c
# ADD CPP /nologo /MDd /W3 /Gm /GX /ZI /Od /D "WIN32" /D "_DEBUG" /D "_WINDOWS" /D "_AFXDLL" /D "_MBCS" /FR /Yu"stdafx.h" /FD /GZ /c
# ADD BASE MTL /nologo /D "_DEBUG" /mktyplib203 /win32
# ADD MTL /nologo /D "_DEBUG" /mktyplib203 /win32
# ADD BASE RSC /l 0x419 /d "_DEBUG" /d "_AFXDLL"
# ADD RSC /l 0x419 /d "_DEBUG" /d "_AFXDLL"
BSC32=bscmake.exe
# ADD BASE BSC32 /nologo
# ADD BSC32 /nologo
LINK32=link.exe
# ADD BASE LINK32 /nologo /subsystem:windows /debug /machine:I386 /pdbtype:sept
# ADD LINK32 /nologo /subsystem:windows /debug /machine:I386 /pdbtype:sept

!ENDIF 

# Begin Target

# Name "MainDemo - Win32 Release"
# Name "MainDemo - Win32 Debug"
# Begin Group "Source Files"

# PROP Default_Filter "cpp;c;cxx;rc;def;r;odl;idl;hpj;bat"
# Begin Source File

SOURCE=.\Audio.cpp
# End Source File
# Begin Source File

SOURCE=.\Display.cpp
# End Source File
# Begin Source File

SOURCE=.\FrameGrabber.cpp
# End Source File
# Begin Source File

SOURCE=.\MainDemo.cpp
# End Source File
# Begin Source File

SOURCE=.\MainDemo.rc
# End Source File
# Begin Source File

SOURCE=.\MainForm.cpp
# End Source File
# Begin Source File

SOURCE=.\MotionDetection.cpp
# End Source File
# Begin Source File

SOURCE=.\NetworkStreaming.cpp
# End Source File
# Begin Source File

SOURCE=.\Overlays.cpp
# End Source File
# Begin Source File

SOURCE=.\Player.cpp
# End Source File
# Begin Source File

SOURCE=.\Recording.cpp
# End Source File
# Begin Source File

SOURCE=.\Reencoding.cpp
# End Source File
# Begin Source File

SOURCE=.\StdAfx.cpp
# ADD CPP /Yc"stdafx.h"
# End Source File
# Begin Source File

SOURCE=.\TVTuner.cpp
# End Source File
# Begin Source File

SOURCE=.\VCTools.cpp
# End Source File
# Begin Source File

SOURCE=.\videograbbervc6.cpp
# End Source File
# Begin Source File

SOURCE=.\VideoProcessing.cpp
# End Source File
# Begin Source File

SOURCE=.\VideoSource.cpp
# End Source File
# End Group
# Begin Group "Header Files"

# PROP Default_Filter "h;hpp;hxx;hm;inl"
# Begin Source File

SOURCE=.\Audio.h
# End Source File
# Begin Source File

SOURCE=.\Display.h
# End Source File
# Begin Source File

SOURCE=.\FrameGrabber.h
# End Source File
# Begin Source File

SOURCE=.\MainDemo.h
# End Source File
# Begin Source File

SOURCE=.\MainForm.h
# End Source File
# Begin Source File

SOURCE=.\MotionDetection.h
# End Source File
# Begin Source File

SOURCE=.\NetworkStreaming.h
# End Source File
# Begin Source File

SOURCE=.\Overlays.h
# End Source File
# Begin Source File

SOURCE=.\Player.h
# End Source File
# Begin Source File

SOURCE=.\Recording.h
# End Source File
# Begin Source File

SOURCE=.\Reencoding.h
# End Source File
# Begin Source File

SOURCE=.\Resource.h
# End Source File
# Begin Source File

SOURCE=.\StdAfx.h
# End Source File
# Begin Source File

SOURCE=.\TVTuner.h
# End Source File
# Begin Source File

SOURCE=.\videograbbervc6.h
# End Source File
# Begin Source File

SOURCE=.\VideoProcessing.h
# End Source File
# Begin Source File

SOURCE=.\VideoSource.h
# End Source File
# End Group
# Begin Group "Resource Files"

# PROP Default_Filter "ico;cur;bmp;dlg;rc2;rct;bin;rgs;gif;jpg;jpeg;jpe"
# Begin Source File

SOURCE=.\res\Display_imgLogo.bmp
# End Source File
# Begin Source File

SOURCE=.\res\MainDemo.ico
# End Source File
# Begin Source File

SOURCE=.\res\MainDemo.rc2
# End Source File
# Begin Source File

SOURCE=.\res\Overlays_imgBitmapOverlay.bmp
# End Source File
# End Group
# End Target
# End Project
# Section MainDemo : {18EAE3F2-7134-4FFA-9212-F50BD0A76D94}
# 	2:5:Class:CVideoGrabberVC6
# 	2:10:HeaderFile:videograbbervc6.h
# 	2:8:ImplFile:videograbbervc6.cpp
# End Section
# Section MainDemo : {7B1B9250-C44C-4339-9E76-5BC8438DDF45}
# 	2:21:DefaultSinkHeaderFile:videograbbervc6.h
# 	2:16:DefaultSinkClass:CVideoGrabberVC6
# End Section
