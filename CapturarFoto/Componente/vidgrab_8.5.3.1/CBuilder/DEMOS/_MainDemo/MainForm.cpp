//---------------------------------------------------------------------------
#include <vcl.h>
#include <jpeg.hpp>
#include <shellapi.h>
#pragma hdrstop

#include "miscCameraControl.h"
#include "miscVideoControl.h"
#include "miscVideoQuality.h"
#include "miscSpecialControl.h"
#include "MainForm.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma link "VidGrab"
#pragma resource "*.dfm"

#pragma warn -8057

TfrmMainForm *frmMainForm;

   const String AUDIO_CLIPS = "*.mp3;*.wav;*.wma;*.mid";
   const String VIDEO_CLIPS = "*.mp*;*.vro;*.avi;*.asf;*.wmv;*.vob;*.avs;*.mov;*.divx;*.mp4;*.mts;*.3gp;*.swf;*.m2v;*.mkv;*.flv;*.wemb;*.ts;*.m4v;*.mp4v";
   const String IMAGE_FILES = "*.jpg;*.jpeg;*.jpe;*.bmp;*.gif;*.png";
   const String OPEN_MEDIA_FILES = "All media files|" + VIDEO_CLIPS + ";" + AUDIO_CLIPS + ";" + IMAGE_FILES
                    + "|Video clips|" + VIDEO_CLIPS
                    + "|Audio clips|" + AUDIO_CLIPS;
   const String OPEN_MEDIA_FILES_EXTENDED = OPEN_MEDIA_FILES
                    + "|Image files|" + IMAGE_FILES;
   const String OPEN_IMAGE_FILES = "Image files|*.bmp;*.jpg;*.gif;*.png;*.tif;*.tiff;*.wmf;*.emf;*.exf;*.jpe;*.jpeg";


//---------------------------------------------------------------------------
__fastcall TfrmMainForm::TfrmMainForm(TComponent* Owner)
        : TForm(Owner)
{
}
//---------------------------------------------------------------------------

void __fastcall AssignListToComboBox (TComboBox* ComboBox, String List, int Index)
{
   ComboBox->Items->Text = List;
   if (ComboBox->Items->Count > 0) {
      ComboBox->ItemIndex = Index;
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::FormCreate(TObject *Sender)
{

   VideoGrabber->Display_AutoSize = true;    // the control will resize automatically
   VideoGrabber->AutoRefreshPreview = true;  // the preview will restart automatically when changing device properties (e.g. video size, analog video standard, etc...)

   FiFreeHandMouseDrawing = 0;                // used for free-hand mouse drawing
   FFreeHandMouseDrawingEnabled = false;      // used for free-hand mouse drawing
   FSearchBmpOrJPEGFilesOpened = false;       // used for the "video from bitmaps" in the VideoGrabberVideoFromBitmaps_NextFrameNeeded event

   FKBWritten_LastReportTime = 0;             // used to store the last time, to report periodically the KB written from the OnFrameProgress2 event (in this demo every 5 seconds)

   FStartupWidth = Width;
   FStartupHeight = Height;

   // - controls using global TVideoGrabber properties, e.g. like the VideoDevices list, are updated from the FormCreate event
   // - controls that depend of the current video device are set in the OnVideoDeviceSelected event
   // - controls that depend of the current audio device are set in the OnAudioDeviceSelected event


   ///////////////////////// Controls on main form
   edtStoragePath->Text = VideoGrabber->StoragePath;

   ///////////////////////// Video source tab
   AssignListToComboBox (cboVideoSource, VideoGrabber->VideoSources, VideoGrabber->VideoSource);
   btnAutoRefreshPreview->Checked = VideoGrabber->AutoRefreshPreview;
   cboVideoSource->ItemIndex = VideoGrabber->VideoSource;
   chkScreenRecordingWithCursor->Checked = VideoGrabber->ScreenRecordingWithCursor;
   edtMonitorNumber->Text = IntToStr (VideoGrabber->ScreenRecordingMonitor);
   chkMultiplexedInputEmulation->Checked = VideoGrabber->MultiplexedInputEmulation;
   VideoGrabber->VideoSource_FileOrURL = edtVideoSourceFileOrUrl->Text;

   ///////////////////////// Audio tab
   chkRenderAudioDevice->Checked = VideoGrabber->AudioDeviceRendering;
   chkMuteAudioRendering->Checked = VideoGrabber->MuteAudioRendering;
   chkAudioSyncAdjust->Checked = VideoGrabber->AudioSyncAdjustmentEnabled;
   tbrAudioSyncAdjust->Position = VideoGrabber->AudioSyncAdjustment;
   edtAudioSyncAdjust->Text = IntToStr (tbrAudioSyncAdjust->Position);

   ///////////////////////// RECORDING tab
   rdgRecordingMethod->ItemIndex = VideoGrabber->RecordingMethod;
   grbRecordingTimer->ItemIndex = VideoGrabber->RecordingTimer;
   edtPreallocSize->Text = IntToStr (VideoGrabber->PreallocCapFileSizeInMB);
   AssignListToComboBox (cboAudioFormats, VideoGrabber->AudioFormats, VideoGrabber->AudioFormat);
   chkRecordingCanPause->Checked = VideoGrabber->RecordingCanPause;
   if (VideoGrabber->RecordingFileName > "") {
      edtRecordingFileName->Text = VideoGrabber->RecordingFileName;
      chkAVISaveToThisFile->Checked = true;
   }
   chkRecordingPauseCreatesNewFile->Checked = VideoGrabber->RecordingPauseCreatesNewFile;
   chkPreallocFile->Checked = VideoGrabber->PreallocCapFileEnabled;
   chkPreserveNativeFormat->Checked = VideoGrabber->RecordingInNativeFormat;

   rdgCompressType->ItemIndex = VideoGrabber->CompressionType;
   rdgCompressMode->ItemIndex = VideoGrabber->CompressionMode;
   chkAudioRecording->Checked = VideoGrabber->AudioRecording;

   AssignListToComboBox (cboVideoCompressors, VideoGrabber->VideoCompressors, VideoGrabber->VideoCompressor);
   AssignListToComboBox (cboAudioCompressors, VideoGrabber->AudioCompressors, VideoGrabber->AudioCompressor);
   AssignListToComboBox (cboMultiplexers, VideoGrabber->Multiplexers, VideoGrabber->Multiplexer);

   ///////////////////////// network Streaming tab

   rdgNetworkStreaming->ItemIndex = VideoGrabber->NetworkStreaming;
   rdgNetworkStreamingType->ItemIndex = Integer (VideoGrabber->NetworkStreamingType);
   rdgNetworkStreamingType->Enabled = VideoGrabber->NetworkStreaming != ns_Disabled;
   edtPublishingPoint->Text = VideoGrabber->ASFMediaServerPublishingPoint;
   edtNetworkPort->Text = IntToStr (VideoGrabber->ASFNetworkPort);
   edtNetworkMaxUsers->Text = IntToStr (VideoGrabber->ASFNetworkMaxUsers);

   rdgProfileVersion->ItemIndex = Integer (VideoGrabber->ASFProfileVersion);
   if (VideoGrabber->ASFProfileFromCustomFile != "") {
      edtWM9Profile->Text = VideoGrabber->ASFProfileFromCustomFile;
   }
   edtASFVideoWidth->Text = IntToStr (VideoGrabber->ASFVideoWidth);
   edtASFVideoHeight->Text = IntToStr (VideoGrabber->ASFVideoHeight);
   edtASFVideoBitRate->Text = IntToStr (VideoGrabber->ASFVideoBitRate);
   edtASFVideoMaxKeyFrameSpacing->Text = IntToStr (VideoGrabber->ASFVideoMaxKeyFrameSpacing);
   edtASFVideoQuality->Text = IntToStr (VideoGrabber->ASFVideoQuality);
   edtASFAudioChannels->Text = IntToStr (VideoGrabber->ASFAudioChannels);
   chkASFFixedFrameRate->Checked = VideoGrabber->ASFFixedFrameRate;
   cmbASFDeinterlaceMode->ItemIndex = VideoGrabber->ASFDeinterlaceMode;

   edtProfileIndex->Text = IntToStr (VideoGrabber->ASFProfile);

   ///////////////////////// Player tab
   edtPlayerSpeedRatio->Text = FormatFloat ("0.0", VideoGrabber->PlayerSpeedRatio);

   updPlayerFastSeekSpeed->Position = (short) VideoGrabber->PlayerFastSeekSpeedRatio;
   edtPlayerFastSeekSpeed->Text = IntToStr (VideoGrabber->PlayerFastSeekSpeedRatio);

   btnAutoPlay->Checked = VideoGrabber->AutoStartPlayer;
   chkPlayerAudioRendering->Checked = VideoGrabber->PlayerAudioRendering;
   chkUseClock->Checked = VideoGrabber->UseClock;
   chkRefreshPausedDisplay->Checked = VideoGrabber->PlayerRefreshPausedDisplay;

   ///////////////////////// Frame grabber tab
   edtAVIAutoFilePrefix->Text = VideoGrabber->AutoFilePrefix;
   rgdFrameGrabberFormat->ItemIndex = VideoGrabber->FrameGrabberRGBFormat;
   rgdFrameGrabber->ItemIndex = VideoGrabber->FrameGrabber;
   rdgAutoFileName->ItemIndex = VideoGrabber->AutoFileName;
   edtFrameCaptureWidth->Text = IntToStr (VideoGrabber->FrameCaptureWidth);
   edtFrameCaptureHeight->Text = IntToStr (VideoGrabber->FrameCaptureHeight);

   ///////////////////////// Frame capture tab
   edtBurstCount->Text = IntToStr (VideoGrabber->BurstCount);
   edtBurstInterval->Text = IntToStr (VideoGrabber->BurstInterval);
   tbrCaptureZoomSize->Position = VideoGrabber->FrameCaptureZoomSize;

   ///////////////////////// Motion detection tab

   chkMotionDetectionEnabled->Checked = VideoGrabber->MotionDetector_Enabled;
   chkCompareRed->Checked = VideoGrabber->MotionDetector_CompareRed;
   chkCompareGreen->Checked = VideoGrabber->MotionDetector_CompareGreen;
   chkCompareBlue->Checked = VideoGrabber->MotionDetector_CompareBlue;
   chk_GreyScale->Checked = VideoGrabber->MotionDetector_GreyScale;
   chkReduceVideoNoise->Checked = VideoGrabber->MotionDetector_ReduceVideoNoise;
   edtGrid->Text = VideoGrabber->MotionDetector_Grid;
   mmoSensitivityGrid->Text = VideoGrabber->MotionDetector_Get2DTextGrid();
   edtGridColCount->Text = IntToStr (VideoGrabber->MotionDetector_GridXCount);
   edtGridRowCount->Text = IntToStr (VideoGrabber->MotionDetector_GridYCount);
   chkTriggered->Checked = VideoGrabber->MotionDetector_Triggered;

   ///////////////////////// TV Tuner tab
   rdgTunerMode->ItemIndex = VideoGrabber->TunerMode;
   edtCountryCode->Text = IntToStr (VideoGrabber->TVCountryCode);
   rdgTunerInputType->ItemIndex = VideoGrabber->TVTunerInputType;
   edtTVChannel->Text = IntToStr (VideoGrabber->TVChannel);
   chkEnableFrequencyOverrides->Checked = VideoGrabber->TVUseFrequencyOverrides;

   ///////////////////////// Overlay tab
   rdgTextOverlaySelector->ItemIndex = VideoGrabber->TextOverlay_Selector;
   rdgTextOverlaySelectorClick (this);
   chkAdjustOverlayAspectRatio->Checked = VideoGrabber->AdjustOverlayAspectRatio;

   rdgImageOverlaySelector->ItemIndex = VideoGrabber->ImageOverlaySelector;
   rdgImageOverlaySelectorClick (this);

   ///////////////////////// Video processing tab
   rdgVideoRotation->ItemIndex = VideoGrabber->VideoProcessing_Rotation;
   tbrBrightness->Position = - VideoGrabber->VideoProcessing_Brightness;
   tbrConstrast->Position = - VideoGrabber->VideoProcessing_Contrast;
   tbrSaturation->Position = - VideoGrabber->VideoProcessing_Saturation;
   tbrHue->Position = VideoGrabber->VideoProcessing_Hue;
   edtCustomRotationAngle->Text = FormatFloat ("0.00", VideoGrabber->VideoProcessing_RotationCustomAngle);

   rdgDeinterlacing->ItemIndex = VideoGrabber->VideoProcessing_Deinterlacing;
   chkGreyScale->Checked = VideoGrabber->VideoProcessing_GrayScale;
   chkInvertColors->Checked = VideoGrabber->VideoProcessing_InvertColors;
   chkFlipVertical->Checked = VideoGrabber->VideoProcessing_FlipVertical;
   chkFlipHorizontal->Checked = VideoGrabber->VideoProcessing_FlipHorizontal;

   chkCroppingEnabled->Checked = VideoGrabber->Cropping_Enabled;
   chkCroppingOutbounds->Checked = VideoGrabber->Cropping_Outbounds;
   edtCroppingWidth->Text = IntToStr (VideoGrabber->Cropping_Width);
   edtCroppingHeight->Text = IntToStr (VideoGrabber->Cropping_Height);
   trkCroppingZoom->Position = VideoGrabber->Cropping_Zoom * 100;

   // trkCroppingX.Max and trkCroppingY.Max are will be set from the OnResizeVideo event
   trkCroppingY->Position = VideoGrabber->Cropping_Y;
   trkCroppingX->Position = VideoGrabber->Cropping_X;


   ///////////////////////// Display tab
   chkVideoVisibleWhenStopped->Checked = VideoGrabber->VideoVisibleWhenStopped;
   chkAdjustPixelAspectRatio->Checked = VideoGrabber->AdjustPixelAspectRatio;
   chkBorder->Checked = VideoGrabber->BorderStyle == bsSingle;
   chkTransparency->Checked = VideoGrabber->ColorKeyEnabled;
   rdgVideoRenderer->ItemIndex = VideoGrabber->VideoRenderer;
   RefreshDisplayOptions();

   ///////////////////////// reencoding tab
   chkWMVOutput->Checked = VideoGrabber->Reencoding_WMVOutput;
   chkIncludeVideoStream->Checked = VideoGrabber->Reencoding_IncludeVideoStream;
   chkIncludeAudioStream->Checked = VideoGrabber->Reencoding_IncludeAudioStream ;
   chkUseFrameGrabber->Checked = VideoGrabber->Reencoding_UseFrameGrabber;
   chkUseCurrentVideoCompressor->Checked = VideoGrabber->Reencoding_UseVideoCompressor;
   chkUseCurrentAudioCompressor->Checked = VideoGrabber->Reencoding_UseAudioCompressor;
   edtReencStartTime->Text = IntToStr (VideoGrabber->Reencoding_StartTime);
   edtReencStartFrame->Text = IntToStr (VideoGrabber->Reencoding_StartFrame);
   edtReencStopTime->Text = IntToStr (VideoGrabber->Reencoding_StopTime);
   edtReencStopFrame->Text = IntToStr (VideoGrabber->Reencoding_StopFrame);
   rdgReencodingMethod->ItemIndex = Integer (VideoGrabber->Reencoding_Method);
}
//---------------------------------------------------------------------------

////////////////////////////////////////////////////////////////////////////////
//                            VIDEO DEVICE TAB
////////////////////////////////////////////////////////////////////////////////

void __fastcall TfrmMainForm::VideoGrabberVideoDeviceSelected(
      TObject *Sender)
{
   // from this event update the properties that depend of the current video capture device->
   // This event occurs when you assign a new value to the VideoDevice property->

   AssignListToComboBox (cboVideoSizes, VideoGrabber->VideoSizes, VideoGrabber->VideoSize);
   AssignListToComboBox (cboVideoSubtypes, VideoGrabber->VideoSubtypes, VideoGrabber->VideoSubtype);
   AssignListToComboBox (cboAnalogVideoStandard, VideoGrabber->AnalogVideoStandards, VideoGrabber->AnalogVideoStandard);
   AssignListToComboBox (cboVideoInputs, VideoGrabber->VideoInputs, VideoGrabber->VideoInput);

   RefreshDeviceControls();
   RefreshDisplayOptions();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::cboVideoSourceChange(TObject *Sender)
{
  switch (cboVideoSource->ItemIndex) {
     case 0: VideoGrabber->VideoSource = vs_VideoCaptureDevice; break;
     case 1: VideoGrabber->VideoSource = vs_ScreenRecording;  break;
     case 2: VideoGrabber->VideoSource = vs_VideoFileOrURL; break;
     case 3: VideoGrabber->VideoSource = vs_JPEGsOrBitmaps; break;
     case 4: VideoGrabber->VideoSource = vs_IPCamera; break;
     default:
        mmoLog->Lines->Add ("this option is not demonstrated in this demo");
  }
}

//---------------------------------------------------------------------------
void __fastcall TfrmMainForm::cboVideoDevicesChange(TObject *Sender)
{
   VideoGrabber->VideoDevice = cboVideoDevices->ItemIndex;
   // when selecting another video device, the OnVideoDeviceSelected event occurs.
   // be sure to refresh all your device-dependent controls from this event.
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnStartPreviewClick(TObject *Sender)
{
   VideoGrabber->StartPreview();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnStopPreviewClick(TObject *Sender)
{
   VideoGrabber->StopPreview();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnPausePreviewClick(TObject *Sender)
{
   VideoGrabber->PausePreview();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnResumePreviewClick(TObject *Sender)
{
   VideoGrabber->ResumePreview();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnAutoRefreshPreviewClick(TObject *Sender)
{
   VideoGrabber->AutoRefreshPreview = btnAutoRefreshPreview->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkEnableSnapshotButtonClick(TObject *Sender)
{
   if (chkEnableSnapshotButton->Enabled) {
      VideoGrabber->WebcamStillCaptureButton = wb_Enabled;
   }
   else {
      VideoGrabber->WebcamStillCaptureButton = wb_Disabled;
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::cboVideoInputsChange(TObject *Sender)
{
   VideoGrabber->VideoInput = cboVideoInputs->ItemIndex;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::cboVideoSizesChange(TObject *Sender)
{
   VideoGrabber->VideoSize = cboVideoSizes->ItemIndex;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::cboAnalogVideoStandardChange(TObject *Sender)
{
   VideoGrabber->AnalogVideoStandard = cboAnalogVideoStandard->ItemIndex;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::cboVideoSubtypesChange(TObject *Sender)
{
   VideoGrabber->VideoSubtype = cboVideoSubtypes->ItemIndex;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkSetLogoClick(TObject *Sender)
{
   if (chkSetLogo->Checked) {
      imgLogo->Visible = false;
      VideoGrabber->SetLogoFromTImage (imgLogo);
      VideoGrabber->LogoLayout = lg_Stretched;
      VideoGrabber->LogoDisplayed = true;
   }
   else {
      VideoGrabber->LogoDisplayed = false;
   }
}
//---------------------------------------------------------------------------
void __fastcall TfrmMainForm::btnDeviceDialogClick(TObject *Sender)
{
   VideoGrabber->ShowDialog (dlg_VideoDevice);
   RefreshDeviceControls();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnStreamDialogClick(TObject *Sender)
{
   // WARNING: USUALLY, THIS DIALOG ALLOWS TO CHANGE ONLY 1 PARAMETER AT THE SAME TIME
   VideoGrabber->ShowDialog (dlg_StreamConfig);
   VideoGrabberVideoDeviceSelected (this); // to refresh the controls, if (required
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnCameraControlDialogClick(TObject *Sender)
{
   ShowFormAboveVideo (frmCameraControl);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnVideoQualityDialogClick(TObject *Sender)
{
   ShowFormAboveVideo (frmVideoQuality);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnVideoControlDialogClick(TObject *Sender)
{
   ShowFormAboveVideo (frmVideoControl);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnSpecialControlsClick(TObject *Sender)
{
   ShowFormAboveVideo (frmSpecialControls);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::rdgPreferredVideoSizeClick(TObject *Sender)
{
   switch (rdgPreferredVideoSize->ItemIndex) {
      case  0: VideoGrabber->UseNearestVideoSize (0, 0, chkStretchPreferredVideoSize->Checked); break; // disables the nearest size feature, uses the device"s VideoSize index in the VideoSizes list
      case  1: VideoGrabber->UseNearestVideoSize ( 88,  60, chkStretchPreferredVideoSize->Checked); break;
      case  2: VideoGrabber->UseNearestVideoSize ( 88,  72, chkStretchPreferredVideoSize->Checked); break;
      case  3: VideoGrabber->UseNearestVideoSize (180, 120, chkStretchPreferredVideoSize->Checked); break;
      case  4: VideoGrabber->UseNearestVideoSize (180, 144, chkStretchPreferredVideoSize->Checked); break;
      case  5: VideoGrabber->UseNearestVideoSize (320, 240, chkStretchPreferredVideoSize->Checked); break;
      case  6: VideoGrabber->UseNearestVideoSize (352, 288, chkStretchPreferredVideoSize->Checked); break;
      case  7: VideoGrabber->UseNearestVideoSize (640, 480, chkStretchPreferredVideoSize->Checked); break;
      case  8: VideoGrabber->UseNearestVideoSize (720, 480, chkStretchPreferredVideoSize->Checked); break;
      case  9: VideoGrabber->UseNearestVideoSize (720, 576, chkStretchPreferredVideoSize->Checked); break;
      case 10: VideoGrabber->UseNearestVideoSize (768, 576, chkStretchPreferredVideoSize->Checked); break;
      // you can add your own preferred formats
   }
   cboVideoSizes->Enabled = rdgPreferredVideoSize->ItemIndex == 0;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkStretchPreferredVideoSizeClick(
      TObject *Sender)
{
   rdgPreferredVideoSizeClick (this);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnSelectFileOrUrlClick(TObject *Sender)
{
   TOpenDialog *OpenDlg = new TOpenDialog(NULL);
   OpenDlg->Filter = OPEN_MEDIA_FILES;
   if (OpenDlg->Execute()) {
      edtVideoSourceFileOrUrl->Text = OpenDlg->FileName;
   }
   delete (OpenDlg);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnUrlConfClick(TObject *Sender)
{
   VideoGrabber->ShowDialog (dlg_NetShowConfig);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnFrameRateClick(TObject *Sender)
{
   float Value;

   Value = StrToFloatDef (edtFrameRate->Text, -1);
   VideoGrabber->FrameRate = Value;
   if (VideoGrabber->CurrentState == cs_Preview) {
      mmoLog->Lines->Add ("current frame rate: " + FormatFloat ("0.00", VideoGrabber->CurrentFrameRate) + " fps.");
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnAboutFrameRateClick(TObject *Sender)
{
   ShowMessage ("0 means that the default frame rate of the device will be used.\nAfter the OnPreviewStarted or OnRecordingStarted event occurs,\nits value is available in the CurrentFrameRate property.");
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkMultiplexedAutoSwitchClick(
      TObject *Sender)
{
   if (chkMultiplexedAutoSwitch->Checked) {
      VideoGrabber->MultiplexedRole = mr_MultiplexedMosaic4;
   }
   else {
      VideoGrabber->MultiplexedRole = mr_NotMultiplexed;
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkMultiplexedInputEmulationClick(
      TObject *Sender)
{
   VideoGrabber->MultiplexedInputEmulation = chkMultiplexedInputEmulation->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtVideoSourceFileOrUrlChange(
      TObject *Sender)
{
   VideoGrabber->VideoSource_FileOrURL = edtVideoSourceFileOrUrl->Text;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoSourceFileOrUrl_UserNameChange(TObject *Sender)
{
   VideoGrabber->SetAuthentication (at_StreamingUrl, VideoSourceFileOrUrl_UserName->Text, VideoSourceFileOrUrl_Password->Text);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoSourceFileOrUrl_PasswordChange(TObject *Sender)
{
   VideoGrabber->SetAuthentication (at_StreamingUrl, VideoSourceFileOrUrl_UserName->Text, VideoSourceFileOrUrl_Password->Text);
}
//---------------------------------------------------------------------------


void __fastcall TfrmMainForm::btnDemoURLClick(TObject *Sender)
{
   ShellExecute(0, "open", "http://www.datastead.com/demo/StreamingURL.htm", NULL, NULL, SW_SHOW);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnScreenRecordingWindowClick(
      TObject *Sender)
{
   VideoGrabber->SetWindowRecordingByName (edtScreenRecordingWindow->Text, false); // set to "true" for an exact and case-sensitive match
}

//---------------------------------------------------------------------------
void __fastcall TfrmMainForm::chkScreenRecordingWithCursorClick(
      TObject *Sender)
{
   VideoGrabber->ScreenRecordingWithCursor = chkScreenRecordingWithCursor->Checked;
}
//---------------------------------------------------------------------------


void __fastcall TfrmMainForm::edtMonitorNumberChange(TObject *Sender)
{
   VideoGrabber->ScreenRecordingMonitor = StrToIntDef (edtMonitorNumber->Text, 0);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnMonitorNumberInfoClick(TObject *Sender)
{
   ShowMessage ("-1 = whole desktop (across monitors)    0 = 1st monitor     1 = 2nd monitor     etc...");
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberPreviewStarted(TObject *Sender)
{
   mmoLog->Lines->Add ("");
   mmoLog->Lines->Add ("video source size: " + IntToStr (VideoGrabber->VideoWidth) + "x" + IntToStr (VideoGrabber->VideoHeight));
   mmoLog->Lines->Add ("display aspect ratio: " + IntToStr (VideoGrabber->VideoWidth_PreferredAspectRatio) + "x" + IntToStr (VideoGrabber->VideoHeight_PreferredAspectRatio));
   mmoLog->Lines->Add ("current frame rate: " + FormatFloat ("0.00", VideoGrabber->CurrentFrameRate) + " fps.");
   mmoLog->Lines->Add ("");
}
//---------------------------------------------------------------------------

////////////////////////////////////////////////////////////////////////////////
//                           AUDIO TAB
////////////////////////////////////////////////////////////////////////////////

void __fastcall TfrmMainForm::VideoGrabberAudioDeviceSelected(
      TObject *Sender)
{
   // from this event set the parameters that change when the current audio capture device change

   cboAudioDevices->ItemIndex = VideoGrabber->AudioDevice; // be sure the listbox index matches the current index value

   AssignListToComboBox (cboAudioInputs, VideoGrabber->AudioInputs, VideoGrabber->AudioInput);
   tbrAudioInputLevel->Position = VideoGrabber->AudioInputLevel;
   tbrAudioInputBalance->Position = VideoGrabber->AudioInputBalance;
   chkAudioInputMono->Checked = VideoGrabber->AudioInputMono;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnStartAudioRenderingClick(TObject *Sender)
{
   VideoGrabber->StartAudioRendering();
   if (! VideoGrabber->AudioDeviceRendering) {
      if (btnStartAudioRendering->Tag == 0) {
         btnStartAudioRendering->Tag = 1; // to show the popup only one time
         ShowMessage ("StartAudioRendering acts as 'preview', e.g. for the VU-Meters, if AudioDeviceRendering (on the left) is not enabled, the audio will not be heard in the speakers");
      }
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnStartWAVRecordingClick(TObject *Sender)
{
   VideoGrabber->RecordingMethod = rm_AVI;
   VideoGrabber->CompressionMode = cm_NoCompression;
   VideoGrabber->StartAudioRecording();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnStartMP3RecordingClick(TObject *Sender)
{
   VideoGrabber->RecordingMethod = rm_AVI;
   VideoGrabber->CompressionMode = cm_CompressOnTheFly;
   VideoGrabber->CompressionType = ct_Audio;
   VideoGrabber->AudioCompressor = VideoGrabber->FindIndexInListByName (VideoGrabber->AudioCompressors, "LAME Audio Encoder", false, true);
   if (VideoGrabber->AudioCompressor == -1) {
      ShowMessage ("The LAME Audio Encoder is required, download it from http://www.elecard.com/download/");
   }
   else {
      VideoGrabber->StartAudioRecording();
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnStartASFRecordingClick(TObject *Sender)
{
   VideoGrabber->CompressionMode = cm_NoCompression;
   VideoGrabber->RecordingMethod = rm_ASF;
   VideoGrabber->StartAudioRecording();
}
//---------------------------------------------------------------------------
void __fastcall TfrmMainForm::btnStopAudioClick(TObject *Sender)
{
   VideoGrabber->Stop();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkUseAudioOfVideoCaptureDeviceClick(
      TObject *Sender)
{
   if (chkUseAudioOfVideoCaptureDevice->Checked) {
      VideoGrabber->VideoDevice = 0; // in this demo, by default we choose the 1st
   }
   else {
      VideoGrabber->VideoDevice = -1; // this deactivates the video capture device
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkRenderAudioDeviceClick(TObject *Sender)
{
   VideoGrabber->AudioDeviceRendering = chkRenderAudioDevice->Checked;

}
//---------------------------------------------------------------------------
void __fastcall TfrmMainForm::cboAudioDevicesChange(TObject *Sender)
{
   VideoGrabber->AudioDevice = cboAudioDevices->ItemIndex;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnDlgAudioDeviceClick(TObject *Sender)
{
   VideoGrabber->ShowDialog (dlg_AudioDevice);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::cboAudioInputsChange(TObject *Sender)
{
   VideoGrabber->AudioInput = cboAudioInputs->ItemIndex;
}
//---------------------------------------------------------------------------


void __fastcall TfrmMainForm::tbrAudioInputLevelChange(TObject *Sender)
{
   VideoGrabber->AudioInputLevel = tbrAudioInputLevel->Position;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::tbrAudioInputBalanceChange(TObject *Sender)
{
   VideoGrabber->AudioInputBalance = tbrAudioInputBalance->Position;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkAudioInputMonoClick(TObject *Sender)
{
   VideoGrabber->AudioInputMono = chkAudioInputMono->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::cboAudioRenderersChange(TObject *Sender)
{
   VideoGrabber->AudioRenderer = cboAudioRenderers->ItemIndex;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::tbrAudioVolumeChange(TObject *Sender)
{
   VideoGrabber->AudioVolume = tbrAudioVolume->Position;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::tbrAudioBalanceChange(TObject *Sender)
{
   VideoGrabber->AudioBalance = tbrAudioBalance->Position;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkMuteAudioRenderingClick(TObject *Sender)
{
   VideoGrabber->MuteAudioRendering = chkMuteAudioRendering->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkAudioSyncAdjustClick(TObject *Sender)
{
   VideoGrabber->AudioSyncAdjustmentEnabled = chkAudioSyncAdjust->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::tbrAudioSyncAdjustChange(TObject *Sender)
{
   VideoGrabber->AudioSyncAdjustment = tbrAudioSyncAdjust->Position;
   edtAudioSyncAdjust->Text = IntToStr (tbrAudioSyncAdjust->Position);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::rdgVUMetersClick(TObject *Sender)
{
   int VU_LEFT = 0;
   int VU_RIGHT = 1;

   switch (rdgVUMeters->ItemIndex) {
      case 0: {
         VideoGrabber->VuMeter = vu_Disabled;
      }; break;
      case 1: {
         VideoGrabber->VuMeter = vu_Analog;

         pnLeftVUMeter->Width = (pnLeftVUMeter->Height * 4) / 3;
         pnRightVUMeter->Width = (pnRightVUMeter->Height * 4) / 3;

         VideoGrabber->SetVUMeterSetting (VU_LEFT, vu_BkgndColor, clBlack);
         VideoGrabber->SetVUMeterSetting (VU_RIGHT, vu_BkgndColor, clBlack);
      }; break;
      case 2: {
         VideoGrabber->VuMeter = vu_Bargraph;

         pnLeftVUMeter->Width = (pnLeftVUMeter->Height * 2) / 10;
         pnRightVUMeter->Width = (pnRightVUMeter->Height * 2) / 10;

         VideoGrabber->SetVUMeterSetting (VU_LEFT, vu_BkgndColor, TColor (0x404040));
         VideoGrabber->SetVUMeterSetting (VU_RIGHT, vu_BkgndColor, TColor (0x404040));
      }; break;
   }
   if (VideoGrabber->VuMeter != vu_Disabled) {
      VideoGrabber->SetVUMeterSetting (VU_LEFT, vu_Handle, (unsigned int) pnLeftVUMeter->Handle);   // we use a TPanel to display the VU meters,
      VideoGrabber->SetVUMeterSetting (VU_RIGHT, vu_Handle, (unsigned int) pnRightVUMeter->Handle); // this is activated by assigning the TPanel's handle->->->
   }
   else {
      VideoGrabber->SetVUMeterSetting (VU_LEFT, vu_Handle, 0); // ->->->and the TPanel is freed by passing 0 as handle
      VideoGrabber->SetVUMeterSetting (VU_RIGHT, vu_Handle, 0);
   }

}
//---------------------------------------------------------------------------

////////////////////////////////////////////////////////////////////////////////
//                             RECORDING TAB
////////////////////////////////////////////////////////////////////////////////

void __fastcall TfrmMainForm::btnStartRecordingImmediatelyClick(
      TObject *Sender)
{
   VideoGrabber->HoldRecording = false; // let's start recording as soon as the graph is built.
   VideoGrabber->StartRecording();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnStartRecordingControlledClick(
      TObject *Sender)
{
   VideoGrabber->HoldRecording = true;
   VideoGrabber->StartRecording();

   // Enabling HoldRecording prevents the recording to start when the recording graph is built.
   // after the OnRecordingReadyToStart event occurs, you can accurately start the
   // recording by invoking ResumeRecording.
}

//---------------------------------------------------------------------------
void __fastcall TfrmMainForm::btnStopRecordingClick(TObject *Sender)
{
   VideoGrabber->StopRecording();
}

//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnRenewRecordingFileClick(TObject *Sender)
{
   if (chkAVISaveToThisFile->Checked) {
      VideoGrabber->RecordToNewFileNow (edtRecordingFileName->Text, true);
   }
   else {
      VideoGrabber->RecordToNewFileNow ("", true);
   }
}

//---------------------------------------------------------------------------
void __fastcall TfrmMainForm::rdgRecordingMethodClick(TObject *Sender)
{
   VideoGrabber->RecordingMethod = TRecordingMethod (rdgRecordingMethod->ItemIndex);
   RefreshDeviceControls();
}
//---------------------------------------------------------------------------
void __fastcall TfrmMainForm::chkRecordingCanPauseClick(TObject *Sender)
{
   VideoGrabber->RecordingCanPause = chkRecordingCanPause->Checked;
   RefreshDeviceControls();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkRecordingPauseCreatesNewFileClick(
      TObject *Sender)
{
   VideoGrabber->RecordingPauseCreatesNewFile = chkRecordingPauseCreatesNewFile->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkRecordingOnMotionClick(TObject *Sender)
{
   VideoGrabber->RecordingOnMotion_Enabled = chkRecordingOnMotion->Checked;
   chkRecordingCanPause->Checked = chkRecordingOnMotion->Checked;
}

//---------------------------------------------------------------------------
void __fastcall TfrmMainForm::btnPauseRecordingClick(TObject *Sender)
{
   VideoGrabber->PauseRecording();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnResumeRecordingClick(TObject *Sender)
{
   VideoGrabber->ResumeRecording();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkAVISaveToThisFileClick(TObject *Sender)
{
   if (chkAVISaveToThisFile->Checked) {
      VideoGrabber->RecordingFileName = edtRecordingFileName->Text;
   }
   else {
      VideoGrabber->RecordingFileName = "";
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtRecordingFileNameChange(TObject *Sender)
{
   if (chkAVISaveToThisFile->Checked) {
      VideoGrabber->RecordingFileName = edtRecordingFileName->Text;
   }
}

void __fastcall TfrmMainForm::cboAudioFormatsChange(TObject *Sender)
{
   VideoGrabber->AudioFormat = TAudioFormat (cboAudioFormats->ItemIndex);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkAudioRecordingClick(TObject *Sender)
{
   VideoGrabber->AudioRecording = chkAudioRecording->Checked;
   RefreshDeviceControls();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::grbRecordingTimerClick(TObject *Sender)
{
   VideoGrabber->RecordingTimer = TRecordingTimer (grbRecordingTimer->ItemIndex);
   VideoGrabber->RecordingTimerInterval = StrToIntDef (edtRecordingTimerInterval->Text, 0);
}

//---------------------------------------------------------------------------
void __fastcall TfrmMainForm::edtRecordingTimerIntervalChange(
      TObject *Sender)
{
   VideoGrabber->RecordingTimerInterval = StrToIntDef (edtRecordingTimerInterval->Text, 0);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkPreserveNativeFormatClick(TObject *Sender)
{
   VideoGrabber->RecordingInNativeFormat = chkPreserveNativeFormat->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnNativeFormatClick(TObject *Sender)
{
   String Msg;

   Msg += "Means that the recording stream will not be uncompressed.\n";
   Msg += "\n";
   Msg += "MUST BE ENABLED:\n";
   Msg += "- to record hardware-encoded MPEG\n";
   Msg += "- to record or DV devices in native DV format\n";
   Msg += "- to record the DV date/time into the video clip and retrieve it during playback\n";
   Msg += "\n";
   Msg += "MUST BE DISABLED:\n";
   Msg += "- to record the text and graphics overlays into the video clip, and retrieve them during playback\n";
   ShowMessage (Msg);
}
//---------------------------------------------------------------------------
void __fastcall TfrmMainForm::chkPreallocFileClick(TObject *Sender)
{
   VideoGrabber->PreallocCapFileEnabled = chkPreallocFile->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnCreatePreallocFileNowClick(
      TObject *Sender)
{
   VideoGrabber->CreatePreallocCapFile();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtPreallocSizeChange(TObject *Sender)
{
   VideoGrabber->PreallocCapFileSizeInMB = StrToIntDef (edtPreallocSize->Text, 100);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::cboVideoCompressorsChange(TObject *Sender)
{
   VideoGrabber->VideoCompressor = cboVideoCompressors->ItemIndex;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::cboAudioCompressorsChange(TObject *Sender)
{
   VideoGrabber->AudioCompressor = cboAudioCompressors->ItemIndex;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::cboMultiplexersChange(TObject *Sender)
{
   VideoGrabber->Multiplexer = cboMultiplexers->ItemIndex;

}
//---------------------------------------------------------------------------

String GetRecordingMethodName (TRecordingMethod Value)
{
   switch (Value) {
      case rm_ASF         : return "rm_ASF";
      case rm_SendToDV    : return "rm_sDV";
      case rm_MKV         : return "rm_MKV";
      case rm_FLV         : return "rm_FLV";
      case rm_MP4         : return "rm_MP4";
      case rm_Multiplexer : return "rm_Mux";
   default:
      return "rm_AVI";
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnVideoCompressorSettingsClick(
      TObject *Sender)
{
   VideoGrabber->ShowDialog (dlg_VideoCompressor);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnAudioCompressorSettingsClick(
      TObject *Sender)
{
   VideoGrabber->ShowDialog (dlg_AudioCompressor);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::Button1Click(TObject *Sender)
{
   VideoGrabber->ShowDialog (dlg_Multiplexer);

}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnSaveVideoCompressorSettingsClick(
      TObject *Sender)
{
   TSaveDialog *SaveDlg = new TSaveDialog(NULL);

   SaveDlg->FileName = VideoGrabber->VideoCompressorName + " (" + GetRecordingMethodName (VideoGrabber->RecordingMethod) + ").txt";
   if (SaveDlg->Execute()) {

      // be sure to have selected the RecordingMethod and VideoCompressor before invoking SaveCompressorSettings...

      VideoGrabber->SaveCompressorSettingsToTextFile (TRUE, VideoGrabber->VideoCompressor, SaveDlg->FileName);

      // remark: you can use instead SaveCompressorSettingsToDataString (TRUE, VideoGrabber.VideoCompressor, YourDataString)
   }
   delete (SaveDlg);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnSaveAudioCompressorSettingsClick(
      TObject *Sender)
{
   TSaveDialog *SaveDlg = new TSaveDialog(NULL);

   SaveDlg->FileName = VideoGrabber->AudioCompressorName + " (" + GetRecordingMethodName (VideoGrabber->RecordingMethod) + ").txt";
   if (SaveDlg->Execute()) {

      // be sure to have selected the RecordingMethod and AudioCompressor before invoking SaveCompressorSettings...

      VideoGrabber->SaveCompressorSettingsToTextFile (FALSE, VideoGrabber->AudioCompressor, SaveDlg->FileName);

      // remark: you can use instead SaveCompressorSettingsToDataString (FALSE, VideoGrabber.AudioCompressor, YourDataString)
   }
   delete (SaveDlg);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnReloadVideoCompressorSettingsClick(
      TObject *Sender)
{
   TOpenDialog *OpenDlg = new TOpenDialog(NULL);
   OpenDlg->Filter = "Compressor saved settings (*.txt)|*.txt";
   if (OpenDlg->Execute()) {

      VideoGrabber->LoadCompressorSettingsFromTextFile (TRUE, VideoGrabber->VideoCompressor, OpenDlg->FileName);

      // remark: you can use instead YourDataString := LoadCompressorSettingsFromDataString (TRUE, VideoGrabber->VideoCompressor)
   }
   delete (OpenDlg);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnReloadAudioCompressorSettingsClick(
      TObject *Sender)
{
   TOpenDialog *OpenDlg = new TOpenDialog(NULL);
   OpenDlg->Filter = "Compressor saved settings (*.txt)|*.txt";
   if (OpenDlg->Execute()) {

      VideoGrabber->LoadCompressorSettingsFromTextFile (FALSE, VideoGrabber->AudioCompressor, OpenDlg->FileName);

      // remark: you can use instead YourDataString := LoadCompressorSettingsFromDataString (FALSE, VideoGrabber->AudioCompressor)
   }
   delete (OpenDlg);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::rdgCompressModeClick(TObject *Sender)
{
   VideoGrabber->CompressionMode = TCompressionMode (rdgCompressMode->ItemIndex);
   RefreshDeviceControls();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::rdgCompressTypeClick(TObject *Sender)
{
   VideoGrabber->CompressionType = TCompressionType (rdgCompressType->ItemIndex);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberRecordingReadyToStart(
      TObject *Sender)
{
   if (MessageDlg ("Ready to start recording!", mtInformation, TMsgDlgButtons() << mbOK << mbCancel, 0) == mrOk) {
      VideoGrabber->ResumeRecording();
   }
   else {
      VideoGrabber->StopRecording();
   }
}

void __fastcall TfrmMainForm::VideoGrabberRecordingStarted(TObject *Sender,
      String FileName)
{
   mmoLog->Lines->Add ("recording to " + FileName + ":");
   mmoLog->Lines->Add (IntToStr (VideoGrabber->RecordingWidth) + "x" + IntToStr (VideoGrabber->RecordingHeight));
   mmoLog->Lines->Add ("current frame rate: " + FormatFloat ("0.00", VideoGrabber->CurrentFrameRate) + " fps.");
   btnRenewRecordingFile->Enabled = true;
   FKBWritten_LastReportTime = 0;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberRecordingPaused(TObject *Sender)
{
      mmoLog->Lines->Add ("recording paused...");

}

//---------------------------------------------------------------------------
void __fastcall TfrmMainForm::VideoGrabberRecordingCompleted(
      TObject *Sender, String FileName, bool Success)
{
   if (Success) {
      mmoLog->Lines->Add (FileName + " successfully created.");
      mmoLog->Lines->Add ("size: " + IntToStr ((int) VideoGrabber->RecordingKBytesWrittenToDisk()) + " KB");
   }
   else {
      mmoLog->Lines->Add ("recording failed.");
   }
   btnRenewRecordingFile->Enabled = false;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberReencodingStarted(
      TObject *Sender, String SourceFile, String DestFile)
{
   mmoLog->Lines->Add ("reencoding " + SourceFile + " to " + DestFile + "...");
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberReencodingProgress(
      TObject *Sender, int Percent, Int64 Position, Int64 Duration)
{
   mmoLog->Lines->Add (IntToStr (Percent) + "% completed...");
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberReencodingCompleted(
      TObject *Sender, String SourceFile, String DestFile,
      bool Success)
{
   if (Success) {
      mmoLog->Lines->Add (SourceFile + "successfully reencoded to " + DestFile);
   }
   else {
      mmoLog->Lines->Add ("ERROR: failed to reencode " + SourceFile + " to " + DestFile);
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberCreatePreallocFileStarted(
      TObject *Sender, String FileName)
{
   mmoLog->Lines->Add ("preallocating file " + FileName + "...");
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberCreatePreallocFileProgress(
      TObject *Sender, int Percent, Int64 Position, Int64 Duration)
{
   mmoLog->Lines->Add (IntToStr (Percent) + "% of preallocated file completed");
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberCreatePreallocFileCompleted(
      TObject *Sender, String FileName, bool Success)
{
   if (Success) {
      mmoLog->Lines->Add (FileName + "successfully preallocated.");
   }
   else {
      mmoLog->Lines->Add ("Failed to allocate " + FileName);
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberCopyPreallocDataStarted(
      TObject *Sender, String SourceFile, String DestFile)
{
   mmoLog->Lines->Add ("copying data from " + SourceFile + " to " + DestFile + "...");
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberCopyPreallocDataProgress(
      TObject *Sender, int Percent, Int64 Position, Int64 Duration)
{
   mmoLog->Lines->Add ("copying data: " + IntToStr (Percent) + "% completed.");
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberCopyPreallocDataCompleted(
      TObject *Sender, String SourceFile, String DestFile,
      bool Success)
{
   if (Success) {
      mmoLog->Lines->Add (SourceFile + " successfully copied to " + DestFile);
   }
   else {
      mmoLog->Lines->Add ("ERROR: failed to copy " + SourceFile + " to " + DestFile);
   }

}
//---------------------------------------------------------------------------


////////////////////////////////////////////////////////////////////////////////
//                             FRAME GRABBER TAB
////////////////////////////////////////////////////////////////////////////////


void __fastcall TfrmMainForm::rgdFrameGrabberClick(TObject *Sender)
{
   VideoGrabber->FrameGrabber = TFrameGrabber (rgdFrameGrabber->ItemIndex);
   RefreshDeviceControls();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::rgdFrameGrabberFormatClick(TObject *Sender)
{
   VideoGrabber->FrameGrabberRGBFormat = TFrameGrabberRGBFormat (rgdFrameGrabberFormat->ItemIndex);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::rdgAutoFileNameClick(TObject *Sender)
{
   VideoGrabber->AutoFileName = TAutoFileName (rdgAutoFileName->ItemIndex);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtAVIAutoFilePrefixChange(TObject *Sender)
{
   VideoGrabber->AutoFilePrefix = edtAVIAutoFilePrefix->Text;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnOneShotTBitmapClick(TObject *Sender)
{
   VideoGrabber->CaptureFrameTo (fc_TBitmap, "");
   // note 1: passing an empty file name let TVideoGrabber generate it automatically in the StoragePath directory
   // note 2: using CaptureFrameSyncTo instead of CaptureFrameTo waits for frame capture completion and returns true upon success
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnOneShotBMPFileClick(TObject *Sender)
{
   if (chkUseThisFileName->Checked) {
      VideoGrabber->CaptureFrameTo (fc_BmpFile, edtUseThisFileName->Text);
   }
   else {
      VideoGrabber->CaptureFrameTo (fc_BmpFile, "");
   }
   // note 1: passing an empty file name let TVideoGrabber generate it automatically in the StoragePath directory
   // note 2: using CaptureFrameSyncTo instead of CaptureFrameTo waits for frame capture completion and returns true upon success
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnOneShotJPEGFileClick(TObject *Sender)
{
   if (chkUseThisFileName->Checked) {
      VideoGrabber->CaptureFrameTo (fc_JpegFile, edtUseThisFileName->Text);
   }
   else {
      VideoGrabber->CaptureFrameTo (fc_JpegFile, "");
   }
   // note 1: passing an empty file name let TVideoGrabber generate it automatically in the StoragePath directory
   // note 2: using CaptureFrameSyncTo instead of CaptureFrameTo waits for frame capture completion and returns true upon success
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnOneShotClipboardClick(TObject *Sender)
{
      VideoGrabber->CaptureFrameTo (fc_Clipboard, "");
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkUseThisFileNameClick(TObject *Sender)
{
   edtUseThisFileName->Enabled = chkUseThisFileName->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnBurstModeTBitmapClick(TObject *Sender)
{
   VideoGrabber->BurstType = fc_TBitmap;
   VideoGrabber->BurstMode = true;
   // The frame capture starts when BurstMode is set to true.
   // if BurstCount = 0 the frame capture does not stop.
   // Captured frames will be returned by the OnFrameCaptureCompleted event.
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnBurstModeBMPFileClick(TObject *Sender)
{
   VideoGrabber->BurstType = fc_BmpFile;
   VideoGrabber->BurstMode = true;
   // The frame capture starts when BurstMode is set to true.
   // if BurstCount = 0 the frame capture does not stop.
   // BMP file names will be generated automatically according to AutoFileName
   // and AutoFilePrefix. They will be returned by the OnFrameCaptureCompleted event.
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnBurstModeJPEGFileClick(TObject *Sender)
{
   VideoGrabber->BurstType = fc_JpegFile;
   VideoGrabber->BurstMode = true;
   // The frame capture starts when BurstMode is set to true.
   // if BurstCount = 0 the frame capture does not stop.
   // JPEG file names will be generated automatically according to AutoFileName
   // and AutoFilePrefix. They will be returned by the OnFrameCaptureCompleted event->
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnBurstModeClipboardClick(TObject *Sender)
{
   VideoGrabber->BurstType = fc_Clipboard;
   VideoGrabber->BurstMode = true;
   // The frame capture starts when BurstMode is set to true.
   // if BurstCount = 0 the frame capture does not stop.
   // Captured frames will be returned by the OnFrameCaptureCompleted event.
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnBurstModeStopClick(TObject *Sender)
{
   VideoGrabber->BurstMode = false;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtBurstCountChange(TObject *Sender)
{
   VideoGrabber->BurstCount = StrToIntDef (edtBurstCount->Text, 1);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtBurstIntervalChange(TObject *Sender)
{
   VideoGrabber->BurstInterval = StrToIntDef (edtBurstInterval->Text, 1);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::tbrCaptureZoomSizeChange(TObject *Sender)
{
   VideoGrabber->FrameCaptureZoomSize = tbrCaptureZoomSize->Position;
   edtCaptureZoomSize->Text = IntToStr (tbrCaptureZoomSize->Position) + "%";
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnResetCaptureZoomSizeClick(TObject *Sender)
{
   tbrCaptureZoomSize->Position = 100;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtFrameCaptureWidthChange(TObject *Sender)
{
   VideoGrabber->FrameCaptureWidth = StrToIntDef (edtFrameCaptureWidth->Text, -1);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtFrameCaptureHeightChange(TObject *Sender)
{
   VideoGrabber->FrameCaptureHeight = StrToIntDef (edtFrameCaptureHeight->Text, -1);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberFrameProgress2(TObject *Sender,
      pFrameInfo FrameInfo)
{
   String DVTimeCode;
   String DVDateTime;

   TVarRec FrameTimeVars[] = {FrameInfo->FrameTime_Hour, FrameInfo->FrameTime_Min, FrameInfo->FrameTime_Sec, FrameInfo->FrameTime_Hs};

   if (FrameInfo->CurrentState == cs_Playback) {  // no dropped frames during playback
      edtFrameCount->Text = "frame: " + IntToStr (FrameInfo->FrameNumber) + " time:" + Format ("%.2d:%.2d:%.2d %.2d", FrameTimeVars, (ARRAYSIZE(FrameTimeVars) -1));
   }
   else {
      edtFrameCount->Text = "frame: " + IntToStr (FrameInfo->FrameNumber) + " dropped:" + IntToStr (FrameInfo->DroppedFrameCount) + " time:" + Format ("%.2d:%.2d:%.2d %.2d", FrameTimeVars, (ARRAYSIZE(FrameTimeVars) -1));
   }

   if (FrameInfo->DVTimeCode_IsAvailable) {
      TVarRec TimeCodeVars[] = {FrameInfo->DVTimeCode_Hour, FrameInfo->DVTimeCode_Min, FrameInfo->DVTimeCode_Sec, FrameInfo->DVTimeCode_Ff};
      DVTimeCode = Format ("tc: %.2d:%.2d:%.2d %.2d", TimeCodeVars, (ARRAYSIZE(TimeCodeVars) -1));
   }
   else {
       DVTimeCode = "";
   }

   if (FrameInfo->DVDateTime_IsAvailable) {
      TVarRec DVDateTimeVars[] = {FrameInfo->DVDateTime_Day, FrameInfo->DVDateTime_Month, FrameInfo->DVDateTime_Year, FrameInfo->DVDateTime_Hour, FrameInfo->DVDateTime_Min, FrameInfo->DVDateTime_Sec};
       DVDateTime = Format ("dv date: %.2d/%.2d/%.2d %.2d:%.2d:%.2d", DVDateTimeVars, (ARRAYSIZE(DVDateTimeVars) -1));
   }
   else {
       DVDateTime = "";
   }
   edtDVDateTime->Text = DVTimeCode + " " + DVDateTime;

   if (VideoGrabber->CurrentState == cs_Recording) {
      if ((FrameInfo->FrameTime - FKBWritten_LastReportTime) > 50000000) { // 5 seconds
         FKBWritten_LastReportTime = FrameInfo->FrameTime;
         mmoLog->Lines->Add ("written to disk: " + IntToStr ((int) VideoGrabber->RecordingKBytesWrittenToDisk()) + " KB");
      }
   }
}
//---------------------------------------------------------------------------

void CopyFrameToBitmapDemo (pFrameBitmapInfo BitmapInfo)
{
   // this code shows how to make a copy of the current video frame to an Image, invoke it from the OnFrameBitmap event below

   Graphics::TBitmap *NewBitmap = new Graphics::TBitmap();
   NewBitmap->Canvas->Lock();
   NewBitmap->Width = BitmapInfo->BitmapWidth;
   NewBitmap->Height = BitmapInfo->BitmapHeight;
   switch (BitmapInfo->BitmapBitsPerPixel) {
      case 32: NewBitmap->PixelFormat = pf32bit; break;
      case 24: NewBitmap->PixelFormat = pf24bit; break;
      case 16: NewBitmap->PixelFormat = pf16bit; break;
      case 15: NewBitmap->PixelFormat = pf15bit; break;
      case  8: NewBitmap->PixelFormat =  pf8bit; break;
      default: NewBitmap->PixelFormat = pf24bit; break;
   }
   BitBlt (NewBitmap->Canvas->Handle, 0, 0, BitmapInfo->BitmapWidth, BitmapInfo->BitmapHeight, BitmapInfo->BitmapDC, 0, 0, SRCCOPY);
   NewBitmap->Canvas->Unlock();
   NewBitmap->SaveToFile ("c:\\myfolder\\myframecapture.bmp");
   delete (NewBitmap);
}
//---------------------------------------------------------------------------

void DrawCircle (TCanvas *Canvas, int xCenter, int yCenter, int Radius)
{
   int xCenterAndRadius = xCenter + Radius;
   Canvas->Arc (xCenter - Radius, yCenter - Radius, xCenterAndRadius, yCenter + Radius, xCenterAndRadius, xCenter, xCenterAndRadius, xCenter);
}
//---------------------------------------------------------------------------


void __fastcall TfrmMainForm::VideoGrabberFrameBitmap(TObject *Sender,
      pFrameInfo FrameInfo, pFrameBitmapInfo BitmapInfo)
{

//    From this event you should not perform any actions with the potential to block:
//    1. do not hold a critical section or wait on another thread,
//    2. do not call any GDI or USER32.DLL APIs that might cause a window to move,
//    3. do not invoke component properties that send messages, e.g. do not read the ItemIndex property
//       of a ListBox component. If you need to read a such property, set an intermediary variable when
//       the property changes, and then read the intermediary variable from this event.


   // -----------------------------------------------------------
   // CopyFrameToBitmapDemo (BitmapInfo); // CopyFrameToBitmapDemo shows how to make a copy of the current video frame, just uncomment this line to use it
   // -----------------------------------------------------------

   // DRAWS A TARGET AT THE MOUSE LOCATION
   // =============================================================

   if (chkDrawTarget->Checked) {
      if (BitmapInfo->LastMouseButtonClicked == mbLeft) {

         int TargetRadius = 50;

         TCanvas *Canvas = new TCanvas();
         Canvas->Handle = BitmapInfo->BitmapDC;
         Canvas->Pen->Color = clRed;
         DrawCircle (Canvas, BitmapInfo->LastXMouseDownLocation, BitmapInfo->LastYMouseDownLocation, TargetRadius);
         Canvas->MoveTo (BitmapInfo->LastXMouseDownLocation - TargetRadius, BitmapInfo->LastYMouseDownLocation);
         Canvas->LineTo (BitmapInfo->LastXMouseDownLocation + TargetRadius, BitmapInfo->LastYMouseDownLocation);
         Canvas->MoveTo (BitmapInfo->LastXMouseDownLocation, BitmapInfo->LastYMouseDownLocation - TargetRadius);
         Canvas->LineTo (BitmapInfo->LastXMouseDownLocation, BitmapInfo->LastYMouseDownLocation + TargetRadius);
         delete (Canvas);
      }
   }

   // DIRECT ACCESS TO THE RGB PIXELS
   // ===============================

   if (chkChangePixels->Checked) {
      unsigned int BitmapLinePtr = (unsigned int) BitmapInfo->BitmapDataPtr;

      if (BitmapInfo->BitmapBitsPerPixel == 24) {   // case where FrameGrabberRGBFormat is set to fgf_RGB24 (you can select it in the "frame grabber" tab)
         for (int i = 0 ; i < BitmapInfo->BitmapHeight ; i++) {
            TRGBTriple *RGB24Line = (TRGBTriple*) BitmapLinePtr;
            for (int iCol = 0 ; iCol < BitmapInfo->BitmapWidth ; iCol ++) {
               RGB24Line[iCol].rgbtGreen = 0; // e.g. we remove the green color -> purple image
            }
            BitmapLinePtr += BitmapInfo->BitmapLineSize;
         }
      }
      else if (BitmapInfo->BitmapBitsPerPixel == 32) {   // case where FrameGrabberRGBFormat is set to fgf_RGB32 (default setting) (you can select it in the "frame grabber" tab)
         for (int i = 0 ; i < BitmapInfo->BitmapHeight ; i++) {
            TRGBQuad *RGB32Line = (TRGBQuad*) BitmapLinePtr;
            for (int iCol = 0 ; iCol < BitmapInfo->BitmapWidth ; iCol ++) {
               RGB32Line[iCol].rgbBlue = 0; // e.g. we remove the blue color -> yellow image
            }
            BitmapLinePtr += BitmapInfo->BitmapLineSize;
         }
      }
   }

   // GRID DRAWING BY USING THE CANVAS DC AND FILLRECT
   // ================================================

   if (chkDrawGridOverFrames->Checked) {

      int xStep = BitmapInfo->BitmapWidth / 10;
      int yStep = BitmapInfo->BitmapHeight / 10;

      int xLocation = xStep;
      int yLocation = yStep;

      TCanvas *Canvas = new TCanvas;
      Canvas->Brush->Color = clBlue;
      Canvas->Brush->Style = bsSolid;
      Canvas->Handle = BitmapInfo->BitmapDC;

      while (xLocation < BitmapInfo->BitmapWidth) {
         Canvas->FillRect(Rect(xLocation, 0, xLocation + 1, BitmapInfo->BitmapHeight));
         xLocation += xStep;
      }

      while (yLocation < BitmapInfo->BitmapHeight) {
         Canvas->FillRect(Rect(0, yLocation, BitmapInfo->BitmapWidth, yLocation + 1));
         yLocation += yStep;
      }

      Canvas->Free();
   }

   // FREE HAND DRANWING BY USING THE CANVAS DC AND LINETO / MOVETO
   // =============================================================

   if (FiFreeHandMouseDrawing > 0) { // see VideoGrabberMouseMove event below
      TCanvas *Canvas = new TCanvas;
      Canvas->Handle = BitmapInfo->BitmapDC;
      Canvas->Pen->Color = clRed;
      for (int i = 0;  i < FiFreeHandMouseDrawing ; i++) {
         if (FFreeHandMouseDrawing[i].Right == 0) { // Right is used as boolean to know if (it is a MoveTo or a LineTo
            Canvas->MoveTo (FFreeHandMouseDrawing[i].Left, FFreeHandMouseDrawing[i].Top);
            Canvas->Pixels[FFreeHandMouseDrawing[i].Left][FFreeHandMouseDrawing[i].Top] = clRed;
         }
         else {
            Canvas->LineTo (FFreeHandMouseDrawing[i].Left, FFreeHandMouseDrawing[i].Top);
         }
      }
      Canvas->Free();
   }

   // VIDEO SIGNAL DETECTION
   // ======================

   if (rdgDetectVideoSignal->ItemIndex > 0) {
      int NewVideoSignalState = false;
      if (rdgDetectVideoSignal->ItemIndex == 1) { // no video signal (dark screen)
         NewVideoSignalState = VideoGrabber->IsVideoSignalDetected (false, true, 30, 30, 30, true);
      }
      else if (rdgDetectVideoSignal->ItemIndex == 2) { // Connexant blue screen (no signal)
         NewVideoSignalState = VideoGrabber->IsVideoSignalDetected (true, false, 0, 0, 0, false);
      }
      if (NewVideoSignalState != FOldVideoSignalState) {
         FOldVideoSignalState = NewVideoSignalState; // memorize the new state
         if (NewVideoSignalState) {
            mmoLog->Lines->Add ("Video signal is back");
         }
         else {
            mmoLog->Lines->Add ("VIDEO SIGNAL LOST");
         }
      }
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberFrameCaptureCompleted(
      TObject *Sender, Pointer FrameBitmap, int BitmapWidth,
      int BitmapHeight, DWORD FrameNumber, Int64 FrameTime,
      TFrameCaptureDest DestType, String FileName, bool Success,
      int FrameId)
{
   TForm *DestForm;
   TImage *DestImage;
   Graphics::TBitmap *Frame_Bitmap;

   Frame_Bitmap = (Graphics::TBitmap*) FrameBitmap;

   if (Success) {
      mmoFrameCaptureLog->Lines->Add ("frame #" + IntToStr ((Int64) FrameNumber) + " captured");
   }
   switch (DestType) {
      // ______ bmp or jpeg file
      case fc_BmpFile, fc_JpegFile: {
         if (Success) {
             mmoFrameCaptureLog->Lines->Add (FileName);
          }
          else {
             mmoFrameCaptureLog->Lines->Add ("error: failed to create " + FileName);
          }
       } break;

      // ______ memory bitmap
      case fc_TBitmap: {
         DestForm = NULL;
         if (VideoGrabber->CanProcessMessages()) { // to prevent crash in synchrone mode (mainly when Player is playing and UseClock is disabled)
            if ((! VideoGrabber->BurstMode) || (VideoGrabber->BurstMode && (VideoGrabber->BurstCount == 0))) { // reuse the same form
               if (! FSnapForm) {
                  Application->CreateForm (__classid (TForm), &FSnapForm);
                  FSnapForm->Position = poDefault;
                  FSnapForm->FormStyle = fsStayOnTop;
               }
               if (FSnapImage) {
                  FSnapImage->Free();
               }
               FSnapImage = new TImage (DestForm);
               DestForm = FSnapForm;
               DestImage = FSnapImage;
            }
            else { // create a form for each image
               Application->CreateForm (__classid (TForm), &DestForm);
               DestForm->Position = poDefault;
               DestForm->FormStyle = fsStayOnTop;
               DestImage = new TImage (DestForm);
               DestImage->Parent = DestForm;
            }

            DestForm->ClientWidth = Frame_Bitmap->Width;
            DestForm->ClientHeight = Frame_Bitmap->Height;
            DestImage->AutoSize = true;

            bool AlternateMethod = false; // you can choose one of the 2 methods below (set true to test the 2nd)

            if (! AlternateMethod) { // this code reassign the bitmap handle to the picture (saves CPU)
               DestImage->Picture->Bitmap->Handle = Frame_Bitmap->Handle;
               Frame_Bitmap->ReleaseHandle();
            }
            else { // this code makes a copy of the bitmap
               DestImage->Picture->Assign (Frame_Bitmap);
            }

            DestImage->Parent = DestForm;

            if (! DestForm->Visible) {
               DestForm->Show();
            }
         }
      } break;
    }
}
//---------------------------------------------------------------------------

////////////////////////////////////////////////////////////////////////////////
//                             PLAYER TAB
////////////////////////////////////////////////////////////////////////////////

void __fastcall TfrmMainForm::btnPlayerOpenFileClick(TObject *Sender)
{
   TOpenDialog *OpenDlg = new TOpenDialog(NULL);
   OpenDlg->Filter = OPEN_MEDIA_FILES_EXTENDED;
   if (OpenDlg->Execute()) {
      edtPlayerClip->Text =OpenDlg->FileName;
   }
   delete (OpenDlg);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnGetClipDurationClick(TObject *Sender)
{
   __int64 Duration;
   __int64 FrameCount;

   if (VideoGrabber->AVIDuration (edtPlayerClip->Text, Duration, FrameCount)) {
       mmoLog->Lines->Add ("Duration: " + IntToStr (Duration));
       mmoLog->Lines->Add ("Frame count: " + IntToStr (FrameCount));
   }
   else {
       mmoLog->Lines->Add ("failed to get info for this clip");
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnGeneralInfoClick(TObject *Sender)
{
   __int64 Duration;
   __int64 FrameCount;
   int VideoWidth;
   int VideoHeight;
   String VideoCodec;
   String AudioCodec;
   double VideoFrameRateFps;
   int AvgBitRate;
   int AudioChannels;
   int AudioSamplesPerSec;
   int AudioBitsPerSample;

   if (VideoGrabber->AVIInfo (edtPlayerClip->Text, Duration, FrameCount, VideoWidth, VideoHeight, VideoFrameRateFps, AvgBitRate, AudioChannels, AudioSamplesPerSec, AudioBitsPerSample, VideoCodec, AudioCodec)) {
      mmoLog->Lines->Add ("");
      mmoLog->Lines->Add (edtPlayerClip->Text + ":");
      mmoLog->Lines->Add ("duration (in sec): " + FormatFloat ("0.00", Duration / 100000));
      mmoLog->Lines->Add ("frame count: " + IntToStr (FrameCount));
      mmoLog->Lines->Add ("video width: " + IntToStr (VideoWidth));
      mmoLog->Lines->Add ("video height: " + IntToStr (VideoHeight));
      mmoLog->Lines->Add ("video frame rate (fps): " + FormatFloat ("0.00", VideoFrameRateFps));
      mmoLog->Lines->Add ("average bit rate (kb/s): " + IntToStr (AvgBitRate / 1024));
      mmoLog->Lines->Add ("audio channels: " + IntToStr (AudioChannels));
      mmoLog->Lines->Add ("audio samples/sec: " + IntToStr (AudioSamplesPerSec));
      mmoLog->Lines->Add ("audio bits per sample: " + IntToStr (AudioBitsPerSample));
      mmoLog->Lines->Add ("video codec: " + VideoCodec);
      mmoLog->Lines->Add ("audio codec: " + AudioCodec);
   }
   else {
      mmoLog->Lines->Add (edtPlayerClip->Text + " clip not found->");
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnHeaderInfoClick(TObject *Sender)
{
    mmoLog->Lines->Add ("");
    mmoLog->Lines->Add (edtPlayerClip->Text + " headers:");
    mmoLog->Lines->Add ("Title: " + VideoGrabber->AVIHeaderInfo(edtPlayerClip->Text, ha_Title));
    mmoLog->Lines->Add ("Description: " + VideoGrabber->AVIHeaderInfo(edtPlayerClip->Text, ha_Description));
    mmoLog->Lines->Add ("Author: " + VideoGrabber->AVIHeaderInfo(edtPlayerClip->Text, ha_Author));
    mmoLog->Lines->Add ("Copyright: " + VideoGrabber->AVIHeaderInfo(edtPlayerClip->Text, ha_Copyright));
    mmoLog->Lines->Add ("Album Artist: " + VideoGrabber->AVIHeaderInfo(edtPlayerClip->Text, ha_AlbumArtist));
    mmoLog->Lines->Add ("Album Title: " + VideoGrabber->AVIHeaderInfo(edtPlayerClip->Text, ha_AlbumTitle));
    mmoLog->Lines->Add ("Composer: " + VideoGrabber->AVIHeaderInfo(edtPlayerClip->Text, ha_Composer));
    mmoLog->Lines->Add ("Content Distributor: " + VideoGrabber->AVIHeaderInfo(edtPlayerClip->Text, ha_ContentDistributor));
    mmoLog->Lines->Add ("Director: " + VideoGrabber->AVIHeaderInfo(edtPlayerClip->Text, ha_Director));
    mmoLog->Lines->Add ("Encoding Time: " + VideoGrabber->AVIHeaderInfo(edtPlayerClip->Text, ha_EncodingTime));
    mmoLog->Lines->Add ("Genre: " + VideoGrabber->AVIHeaderInfo(edtPlayerClip->Text, ha_Genre));
    mmoLog->Lines->Add ("Language: " + VideoGrabber->AVIHeaderInfo(edtPlayerClip->Text, ha_Language));
    mmoLog->Lines->Add ("Parental Rating: " + VideoGrabber->AVIHeaderInfo(edtPlayerClip->Text, ha_ParentalRating));
    mmoLog->Lines->Add ("Producer: " + VideoGrabber->AVIHeaderInfo(edtPlayerClip->Text, ha_Producer));
    mmoLog->Lines->Add ("Provider: " + VideoGrabber->AVIHeaderInfo(edtPlayerClip->Text, ha_Provider));
    mmoLog->Lines->Add ("ToolName: " + VideoGrabber->AVIHeaderInfo(edtPlayerClip->Text, ha_ToolName));
    mmoLog->Lines->Add ("Tool Version: " + VideoGrabber->AVIHeaderInfo(edtPlayerClip->Text, ha_ToolVersion));
    mmoLog->Lines->Add ("Writer: " + VideoGrabber->AVIHeaderInfo(edtPlayerClip->Text, ha_Writer));
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnOpenClipClick(TObject *Sender)
{
   VideoGrabber->PlayerFileName = edtPlayerClip->Text;
   VideoGrabber->OpenPlayer();

}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnPlayerCloseClipClick(TObject *Sender)
{
 VideoGrabber->ClosePlayer();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnOpenLastClipRecordedClick(TObject *Sender)
{
   if (VideoGrabber->Last_Recording_FileName != "") {
      edtPlayerClip->Text = VideoGrabber->Last_Recording_FileName;
      VideoGrabber->PlayerFileName = edtPlayerClip->Text;
      VideoGrabber->OpenPlayer();
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnOpenLastClipPlayedClick(TObject *Sender)
{
   if (VideoGrabber->Last_Clip_Played != "") {
      edtPlayerClip->Text = VideoGrabber->Last_Clip_Played;
      VideoGrabber->PlayerFileName = edtPlayerClip->Text;
      VideoGrabber->OpenPlayer();
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnPlayerCloseFileClick(TObject *Sender)
{
   VideoGrabber->ClosePlayer();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnPlayerPauseClick(TObject *Sender)
{
   VideoGrabber->PausePlayer();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnPlayerStopClick(TObject *Sender)
{
   VideoGrabber->StopPlayer();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnPlayerStartPlayingClick(TObject *Sender)
{
   VideoGrabber->RunPlayer();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnPlayerFrameStepClick(TObject *Sender)
{
   VideoGrabber->PlayerFrameStep (1);

}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnPlayerBackwardsClick(TObject *Sender)
{
   VideoGrabber->RunPlayerBackwards();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnPlayerRewindClick(TObject *Sender)
{
   VideoGrabber->RewindPlayer();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnPlayerFastForwardClick(TObject *Sender)
{
   VideoGrabber->FastForwardPlayer();

}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnAutoPlayClick(TObject *Sender)
{
   VideoGrabber->AutoStartPlayer = btnAutoPlay->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::tbrPlayerProgressChange(TObject *Sender)
{
    // the tbrPlayer trackbar is assigned directly to the VideoGrabber.PlayerTrackBar property, that handle the position automatically
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkPlayerTrackbarSynchroneClick(
      TObject *Sender)
{
   VideoGrabber->PlayerTrackBarSynchrone = chkPlayerTrackbarSynchrone->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkPlayerAudioRenderingClick(TObject *Sender)
{
   VideoGrabber->PlayerAudioRendering = chkPlayerAudioRendering->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkUseClockClick(TObject *Sender)
{
   VideoGrabber->UseClock = chkUseClock->Checked;
}

//---------------------------------------------------------------------------
void __fastcall TfrmMainForm::chkRefreshPausedDisplayClick(TObject *Sender)
{
   VideoGrabber->PlayerRefreshPausedDisplay = chkRefreshPausedDisplay->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtPlayerSpeedRatioChange(TObject *Sender)
{
   double OldSpeedRatio = VideoGrabber->PlayerSpeedRatio;
   VideoGrabber->PlayerSpeedRatio = StrToFloatDef (edtPlayerSpeedRatio->Text, 1.0);
   if (VideoGrabber->PlayerSpeedRatio != OldSpeedRatio) {
      mmoLog->Lines->Add ("player speed ratio selected: " + FormatFloat ("0.0", VideoGrabber->PlayerSpeedRatio));
   }

}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::updPlayerFastSeekSpeedClick(TObject *Sender,
      TUDBtnType Button)
{
   VideoGrabber->PlayerFastSeekSpeedRatio = updPlayerFastSeekSpeed->Position;
   edtPlayerFastSeekSpeed->Text = IntToStr (VideoGrabber->PlayerFastSeekSpeedRatio);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberPlayerOpened(TObject *Sender)
{
   mmoLog->Lines->Add ("");
   mmoLog->Lines->Add ("playing " + VideoGrabber->PlayerFileName);
   if (VideoGrabber->IsPlayerVideoStreamAvailable == ts_True) {
      mmoLog->Lines->Add ("this clip has a video stream");
   }
   else if (VideoGrabber->IsPlayerVideoStreamAvailable == ts_False) {
      mmoLog->Lines->Add ("this clip does not have video");
   }
   if (VideoGrabber->IsPlayerAudioStreamAvailable == ts_True) {
      mmoLog->Lines->Add ("this clip has an audio stream");
   }
   else if (VideoGrabber->IsPlayerAudioStreamAvailable == ts_False) {
      mmoLog->Lines->Add ("this clip does not have audio");
   }
   mmoLog->Lines->Add ("");
   mmoLog->Lines->Add ("video codec: " + VideoGrabber->PlayerVideoCodec);
   mmoLog->Lines->Add ("audio codec: " + VideoGrabber->PlayerAudioCodec);
   mmoLog->Lines->Add ("");
   mmoLog->Lines->Add ("Duration: " + FormatFloat ("0.00", VideoGrabber->PlayerDuration / 10000000));
   mmoLog->Lines->Add ("Frame count: " + IntToStr (VideoGrabber->PlayerFrameCount));
   mmoLog->Lines->Add ("Frame rate: " + FormatFloat ("0.00", VideoGrabber->PlayerFrameRate));
   mmoLog->Lines->Add ("video source size:" + IntToStr (VideoGrabber->VideoWidth) + "x" + IntToStr (VideoGrabber->VideoHeight));
   mmoLog->Lines->Add ("display aspect ratio: " + IntToStr (VideoGrabber->VideoWidth_PreferredAspectRatio) + "x" + IntToStr (VideoGrabber->VideoHeight_PreferredAspectRatio));

   if (VideoGrabber->IsPlaylistActive() ) {
      lstPlaylist->ItemIndex = VideoGrabber->PlaylistIndex;
   }

}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberPlayerBufferingData(
      TObject *Sender, bool StartingToBuffer)
{
   if (StartingToBuffer) {
      mmoLog->Lines->Add ("buffering data...");
   }
   else {
      mmoLog->Lines->Add ("buffering completed.");
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnAddToPlaylistClick(TObject *Sender)
{
   int i;

   TOpenDialog *OpenDlg = new TOpenDialog(NULL);
   OpenDlg->Filter = OPEN_MEDIA_FILES_EXTENDED;
   OpenDlg->Options = OpenDlg->Options << ofAllowMultiSelect;
   if (OpenDlg->Execute()) {
      for (i = 0 ; i <OpenDlg->Files->Count ; i ++) {
         VideoGrabber->Playlist (pl_Add, OpenDlg->Files->Strings[i]);
         lstPlaylist->Items->Add (OpenDlg->Files->Strings[i]);
      }
   }
   delete (OpenDlg);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnPlaylistPlayClick(TObject *Sender)
{
   VideoGrabber->Playlist (pl_Play, "");
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnPlaylistNextClick(TObject *Sender)
{
   VideoGrabber->Playlist (pl_Next, "");
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnPlaylistPreviousClick(TObject *Sender)
{
   VideoGrabber->Playlist (pl_Previous, "");
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnPlaylistStopClick(TObject *Sender)
{
   VideoGrabber->Playlist (pl_Stop, "");
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnClosePlaylistClick(TObject *Sender)
{
   VideoGrabber->ClosePlayer();

}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkPlaylistLoopClick(TObject *Sender)
{
   if (chkPlaylistLoop->Checked) {
      VideoGrabber->Playlist (pl_Loop, "");
   }
   else {
      VideoGrabber->Playlist (pl_NoLoop, "");
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkPlaylistRandomClick(TObject *Sender)
{
   if (chkPlaylistLoop->Checked) {
      VideoGrabber->Playlist (pl_Random, "");
   }
   else {
      VideoGrabber->Playlist (pl_Sequential, "");
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::lstPlaylistClick(TObject *Sender)
{
   VideoGrabber->PlaylistIndex = lstPlaylist->ItemIndex;
   VideoGrabber->Playlist (pl_Play, "");
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberPlayerEndOfStream(
      TObject *Sender)
{
   mmoLog->Lines->Add ("End of stream.");
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberPlayerEndOfPlaylist(
      TObject *Sender)
{
   mmoLog->Lines->Add ("END OF PLAYLIST.");
}
//---------------------------------------------------------------------------

////////////////////////////////////////////////////////////////////////////////
//                           NETWORK STREAMING TAB
////////////////////////////////////////////////////////////////////////////////

void __fastcall TfrmMainForm::btnViewDirectNetworkStreamingClick(
      TObject *Sender)
{
   if (VideoGrabber->StreamingURL != "") {
	  ShellExecute (NULL, "open", (char*) VideoGrabber->StreamingURL.c_str(), NULL, NULL, SW_SHOWNORMAL);
   }
}
//---------------------------------------------------------------------------
void __fastcall TfrmMainForm::rdgNetworkStreamingClick(TObject *Sender)
{
   VideoGrabber->NetworkStreaming = TNetworkStreaming (rdgNetworkStreaming->ItemIndex);
   btnViewDirectNetworkStreaming->Enabled = VideoGrabber->NetworkStreaming == ns_ASFDirectNetworkStreaming;
   rdgNetworkStreamingType->Enabled = VideoGrabber->NetworkStreaming != ns_Disabled;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::rdgNetworkStreamingTypeClick(TObject *Sender)
{
   VideoGrabber->NetworkStreamingType = (TNetworkStreamingType) rdgNetworkStreamingType->ItemIndex;
}
//---------------------------------------------------------------------------
void __fastcall TfrmMainForm::edtNetworkPortChange(TObject *Sender)
{
   VideoGrabber->ASFNetworkPort = StrToIntDef (edtNetworkPort->Text, 0);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtNetworkMaxUsersChange(TObject *Sender)
{
   VideoGrabber->ASFNetworkMaxUsers = StrToIntDef (edtNetworkMaxUsers->Text, 0);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtPublishingPointChange(TObject *Sender)
{
   VideoGrabber->ASFMediaServerPublishingPoint = edtPublishingPoint->Text;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtPublishingPointUsernameChange(TObject *Sender)
{
   VideoGrabber->SetAuthentication (at_PublishingPoint, edtPublishingPointUsername->Text, edtPublishingPointPassword->Text);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtPublishingPointPasswordChange(TObject *Sender)
{
   VideoGrabber->SetAuthentication (at_PublishingPoint, edtPublishingPointUsername->Text, edtPublishingPointPassword->Text);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::rdgProfileVersionClick(TObject *Sender)
{
   VideoGrabber->ASFProfileVersion = TASFProfileVersion (rdgProfileVersion->ItemIndex);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnSelectWMV9ProfileClick(TObject *Sender)
{
   if (VideoGrabber->ASFProfileVersion == apv_ProfileVersion_9) {
      TOpenDialog *OpenDlg = new TOpenDialog(NULL);
      OpenDlg->Filter = "WMV9 profiles (*.prx)|*.prx";
      if (OpenDlg->Execute()) {
         edtWM9Profile->Text = OpenDlg->FileName;
      }
      delete (OpenDlg);
   }
   else {
      ShowMessage ("select WMV version 9 first");
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtWM9ProfileChange(TObject *Sender)
{
   VideoGrabber->ASFProfileFromCustomFile = edtWM9Profile->Text;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnShowProfilesListClick(TObject *Sender)
{
   lsbProfiles->Items->Text = VideoGrabber->ASFProfiles;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtASFVideoWidthChange(TObject *Sender)
{
   VideoGrabber->ASFVideoWidth = StrToIntDef (edtASFVideoWidth->Text, -1);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtASFVideoHeightChange(TObject *Sender)
{
   VideoGrabber->ASFVideoHeight = StrToIntDef (edtASFVideoHeight->Text, -1);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtASFVideoBitRateChange(TObject *Sender)
{
   VideoGrabber->ASFVideoBitRate = StrToIntDef (edtASFVideoBitRate->Text, -1);
}
//---------------------------------------------------------------------------


void __fastcall TfrmMainForm::edtASFVideoMaxKeyFrameSpacingChange(
      TObject *Sender)
{
   VideoGrabber->ASFVideoMaxKeyFrameSpacing = StrToIntDef (edtASFVideoMaxKeyFrameSpacing->Text, -1);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtASFVideoQualityChange(TObject *Sender)
{
   VideoGrabber->ASFVideoQuality = StrToIntDef (edtASFVideoQuality->Text, -1);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtASFAudioChannelsChange(TObject *Sender)
{
   VideoGrabber->ASFAudioChannels = StrToIntDef (edtASFAudioChannels->Text, -1);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkASFFixedFrameRateClick(TObject *Sender)
{
   VideoGrabber->ASFFixedFrameRate = chkASFFixedFrameRate->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::cmbASFDeinterlaceModeChange(TObject *Sender)
{
   VideoGrabber->ASFDeinterlaceMode = TASFDeinterlaceMode (cmbASFDeinterlaceMode->ItemIndex);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtProfileIndexChange(TObject *Sender)
{
   VideoGrabber->ASFProfile = StrToIntDef (edtProfileIndex->Text, -1);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::lsbProfilesClick(TObject *Sender)
{
   if (lsbProfiles->Items->Count > 0) {
      VideoGrabber->ASFProfile = lsbProfiles->ItemIndex;
      edtProfileIndex->Text = IntToStr (VideoGrabber->ASFProfile);
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberDirectNetworkStreamingHostUrl(
      TObject *Sender, String HostUrl, String HostName,
      int HostPort)
{
   mmoLog->Lines->Add ("streaming URL: " + HostUrl);
   mmoLog->Lines->Add ("streaming host: " + HostName);
   mmoLog->Lines->Add ("streaming port: " + IntToStr (HostPort));
   btnViewDirectNetworkStreaming->Enabled = true;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberClientConnection(TObject *Sender,
      bool Connected, String ClientInfo)
{
   if (Connected) {
      mmoLog->Lines->Add ("client connected: " + ClientInfo);
   }
   else {
      mmoLog->Lines->Add ("client disconnected: " + ClientInfo);
   }
}
//---------------------------------------------------------------------------


////////////////////////////////////////////////////////////////////////////////
//                            TV TUNER TAB
////////////////////////////////////////////////////////////////////////////////


void __fastcall TfrmMainForm::btnShowTunerDialogClick(TObject *Sender)
{
   VideoGrabber->ShowDialog (dlg_TVTuner);
   RefreshDeviceControls();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::rdgTunerModeClick(TObject *Sender)
{
   VideoGrabber->TunerMode = TTunerMode (rdgTunerMode->ItemIndex);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::rdgTunerInputTypeClick(TObject *Sender)
{
   VideoGrabber->TVTunerInputType = TTunerInputType (rdgTunerInputType->ItemIndex);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnSetCountryCodeClick(TObject *Sender)
{
   int CountryCode;

   CountryCode = StrToIntDef (edtCountryCode->Text, -1);
   if (CountryCode >= 0) {
      VideoGrabber->TVCountryCode = CountryCode;
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnSelectClick(TObject *Sender)
{
   int Channel;

   Channel  = StrToIntDef (edtTVChannel->Text, -1);
   if (Channel != -1) {
      VideoGrabber->TVChannel = Channel;
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkSetFrequencyOverrideClick(TObject *Sender)
{
   int Channel;
   int Frequency;

   Channel  = StrToIntDef (edtTVChannel->Text, -1);
   Frequency = StrToIntDef (edtChannelFrequency->Text, -1);
   if ((Channel != -1) && (Frequency != -1)) {
      VideoGrabber->TVSetChannelFrequencyOverride (Channel, Frequency);
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnDeleteFrequencyOverrideClick(
      TObject *Sender)
{
   int Channel;

   Channel  = StrToIntDef (edtTVChannel->Text, -1);
   if (Channel != -1) {
      VideoGrabber->TVSetChannelFrequencyOverride (Channel, -1);
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkEnableFrequencyOverridesClick(
      TObject *Sender)
{
   VideoGrabber->TVUseFrequencyOverrides = chkEnableFrequencyOverrides->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnStartScanClick(TObject *Sender)
{
   VideoGrabber->TVStartAutoScan();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnStopScanClick(TObject *Sender)
{
   VideoGrabber->TVStopAutoScan();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnResetAllOverridesClick(TObject *Sender)
{
   VideoGrabber->TVClearFrequencyOverrides();
}
//---------------------------------------------------------------------------
void __fastcall TfrmMainForm::VideoGrabberTVChannelScanStarted(
      TObject *Sender, int MinChannel, int MaxChannel)
{
   String InputType;

   switch (VideoGrabber->TVTunerInputType) {
      case TunerInputCable   : InputType = "cable input";   break;
      case TunerInputAntenna : InputType = "antenna input"; break;
   }
   mmoChannelLog->Lines->Add ("scanning country code " + IntToStr (VideoGrabber->TVCountryCode) + " (" + InputType + ") from channel " + IntToStr (MinChannel) + " to " + IntToStr (MaxChannel) + "...");
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberTVChannelSelected(
      TObject *Sender, int Channel, bool Locked, int DefaultVideoFrequency,
      int OverriddenVideoFrequency, int TunerVideoFrequency,
      int TunerAudioFrequency)
{
   String sFrequencyInfo;

   if (Locked) {
      sFrequencyInfo = IntToStr (Channel) + ": " + FormatFloat ("0.00", TunerVideoFrequency / 1000000) + " Mhz (" + IntToStr (TunerVideoFrequency) + " Hz";
      if (OverriddenVideoFrequency != -1) {
         sFrequencyInfo = sFrequencyInfo + ", overridden";
      }
      sFrequencyInfo = sFrequencyInfo + ")";
      mmoChannelLog->Lines->Add (sFrequencyInfo);
   }
   else {
      if (OverriddenVideoFrequency != -1) {
         mmoChannelLog->Lines->Add (IntToStr (Channel) + "... overridden and ! locked");
      }
      else {
         mmoChannelLog->Lines->Add (IntToStr (Channel) + "...");
      }
   }
   edtTVChannel->Text = IntToStr (Channel);
   if (OverriddenVideoFrequency != -1) {
      edtChannelFrequency->Text = IntToStr (OverriddenVideoFrequency);
   }
   else {
      edtChannelFrequency->Text = IntToStr (TunerVideoFrequency);
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberTVChannelScanCompleted(
      TObject *Sender)
{
   mmoChannelLog->Lines->Add ("autoscan completed.");
}
//---------------------------------------------------------------------------

////////////////////////////////////////////////////////////////////////////////
//                            FRAME OVERLAY TAB
////////////////////////////////////////////////////////////////////////////////



void __fastcall TfrmMainForm::chkTextOverlayEnabledClick(TObject *Sender)
{
   VideoGrabber->TextOverlay_String = mmoTextOverlayString->Text;

   VideoGrabber->TextOverlay_Enabled = chkTextOverlayEnabled->Checked;

   if (! chkTextOverlayEnabled->Checked) {
      chkTextOverlayEnabled->Font->Color = clRed;
   }
   else {
      chkTextOverlayEnabled->Font->Color = clBlack;
   }
}
//---------------------------------------------------------------------------


void __fastcall TfrmMainForm::chkTextOverlayTransparentClick(
      TObject *Sender)
{
   VideoGrabber->TextOverlay_Transparent = chkTextOverlayTransparent->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::updTextOverlaySizeClick(TObject *Sender,
      TUDBtnType Button)
{
   switch (Button) {
      case btPrev: VideoGrabber->TextOverlay_Font->Size = VideoGrabber->TextOverlay_Font->Size - 1; break;
      case btNext: VideoGrabber->TextOverlay_Font->Size = VideoGrabber->TextOverlay_Font->Size + 1; break;
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::rgdShadowDirectionClick(TObject *Sender)
{
   VideoGrabber->TextOverlay_ShadowDirection = TCardinalDirection (rgdTextOverlayShadowDirection->ItemIndex);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkAdjustOverlayAspectRatioClick(
      TObject *Sender)
{
   VideoGrabber->AdjustOverlayAspectRatio = chkAdjustOverlayAspectRatio->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkTextOverlayShadowClick(TObject *Sender)
{
   VideoGrabber->TextOverlay_Shadow = chkTextOverlayShadow->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::rdgTextOverlayAlignClick(TObject *Sender)
{
   VideoGrabber->TextOverlay_Align = TTextOverlayAlign (rdgTextOverlayAlign->ItemIndex);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::mmoTextOverlayStringChange(TObject *Sender)
{
   VideoGrabber->TextOverlay_String = mmoTextOverlayString->Text;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtTextOverlayLeftChange(TObject *Sender)
{
   VideoGrabber->TextOverlay_Left = StrToIntDef (edtTextOverlayLeft->Text, 0);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtTextOverlayTopChange(TObject *Sender)
{
   VideoGrabber->TextOverlay_Top = StrToIntDef (edtTextOverlayTop->Text, 0);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtTextOverlayRightChange(TObject *Sender)
{
   VideoGrabber->TextOverlay_Right = StrToIntDef (edtTextOverlayRight->Text, 0);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnBkgndColorClick(TObject *Sender)
{
   TColorDialog *dlgTextOverlayColor = new TColorDialog(NULL);
   dlgTextOverlayColor->Color = VideoGrabber->TextOverlay_Font->Color;
   if (dlgTextOverlayColor->Execute()) {
      VideoGrabber->TextOverlay_Font->Color = dlgTextOverlayColor->Color;
   }
   delete (dlgTextOverlayColor);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkTextOverlayScrollingClick(TObject *Sender)
{
   VideoGrabber->TextOverlay_Scrolling = chkTextOverlayScrolling->Checked;

}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtTextOverlayScrollingSpeedChange(
      TObject *Sender)
{
   VideoGrabber->TextOverlay_ScrollingSpeed = StrToIntDef (edtTextOverlayScrollingSpeed->Text, 0);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnTextOverlayColorClick(TObject *Sender)
{
   TColorDialog *dlgTextOverlayColor = new TColorDialog(NULL);
   dlgTextOverlayColor->Color = VideoGrabber->TextOverlay_BkColor;
   if (dlgTextOverlayColor->Execute()) {
      VideoGrabber->TextOverlay_BkColor = dlgTextOverlayColor->Color;
   }
   delete (dlgTextOverlayColor);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::rgdTextOverlayShadowDirectionClick(
      TObject *Sender)
{
   VideoGrabber->TextOverlay_ShadowDirection = TCardinalDirection (rgdTextOverlayShadowDirection->ItemIndex);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::rdgTextOverlaySelectorClick(TObject *Sender)
{
   VideoGrabber->TextOverlay_Selector = rdgTextOverlaySelector->ItemIndex;

   // as we have selected another set, let's reload the corresponding values
   chkTextOverlayEnabled->Checked = VideoGrabber->TextOverlay_Enabled;
   if (! chkTextOverlayEnabled->Checked) {
      chkTextOverlayEnabled->Font->Color = clRed;
   }
   else {
      chkTextOverlayEnabled->Font->Color = clBlack;
   }

   mmoTextOverlayString->Text = VideoGrabber->TextOverlay_String;
   edtTextOverlayLeft->Text = IntToStr (VideoGrabber->TextOverlay_Left);
   edtTextOverlayTop->Text = IntToStr (VideoGrabber->TextOverlay_Top);
   edtTextOverlayRight->Text = IntToStr (VideoGrabber->TextOverlay_Right);
   rdgTextOverlayAlign->ItemIndex = Integer (VideoGrabber->TextOverlay_Align);
   chkTextOverlayScrolling->Checked = VideoGrabber->TextOverlay_Scrolling;
   edtTextOverlayScrollingSpeed->Text = IntToStr (VideoGrabber->TextOverlay_ScrollingSpeed);
   chkTextOverlayTransparent->Checked = VideoGrabber->TextOverlay_Transparent;
   chkTextOverlayShadow->Checked = VideoGrabber->TextOverlay_Shadow;
   chkAdjustOverlayAspectRatio->Checked = VideoGrabber->AdjustOverlayAspectRatio;
   rgdTextOverlayShadowDirection->ItemIndex = Integer (VideoGrabber->TextOverlay_ShadowDirection);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkChangePixelsClick(TObject *Sender)
{
   // chkChangePixels->Checked is tested in the TfrmMainForm::VideoGrabberFrameBitmap event's code
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkDrawGridOverFramesClick(TObject *Sender)
{
   // chkDrawGridOverFrames->Checked is tested in the TfrmMainForm::VideoGrabberFrameBitmap event's code
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkFreeHandEnabledClick(TObject *Sender)
{
   // chkFreeHandEnabled->Checked is tested in the TfrmMainForm::VideoGrabberFrameBitmap event's code
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnFreeHandEraseClick(TObject *Sender)
{
   FiFreeHandMouseDrawing = 0;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnLoadImageOverlayFromFileClick(
      TObject *Sender)
{
   TOpenDialog *OpenDlg = new TOpenDialog(NULL);
   OpenDlg->Filter = OPEN_IMAGE_FILES;
   if (OpenDlg->Execute()) {
      VideoGrabber->SetImageOverlayFromImageFile (OpenDlg->FileName);
   }
   delete (OpenDlg);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkImageOverlayEnabledClick(TObject *Sender)
{
   VideoGrabber->ImageOverlayEnabled = chkImageOverlayEnabled->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberMouseDown(TObject *Sender,
      int VideoWindow, TMouseButton Button, TShiftState Shift, int X,
      int Y)
{
   if (VideoWindow != -1) { // if the video is displayed
      if (chkFreeHandEnabled->Checked) {
         FFreeHandMouseDrawing[FiFreeHandMouseDrawing].Left = X;
         FFreeHandMouseDrawing[FiFreeHandMouseDrawing].Top = Y;
         FFreeHandMouseDrawing[FiFreeHandMouseDrawing].Right = 0; // Right is used as boolean to know if (it is a MoveTo or a LineTo
         FiFreeHandMouseDrawing ++;
         FFreeHandMouseDrawingEnabled = true;
         VideoGrabber->RefreshPlayerOverlays();
      }
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberMouseMove(TObject *Sender,
      int VideoWindow, TShiftState Shift, int X, int Y)
{
   if (VideoWindow != -1) { // if the video is displayed
      if (FFreeHandMouseDrawingEnabled) { // has been enabled in the MouseDown event above
         if (FiFreeHandMouseDrawing < CFreeHandMouseMax) {
            FFreeHandMouseDrawing[FiFreeHandMouseDrawing].Left = X;
            FFreeHandMouseDrawing[FiFreeHandMouseDrawing].Top = Y;
            FFreeHandMouseDrawing[FiFreeHandMouseDrawing].Right = 1; // Right is used as boolean to know if (it is a MoveTo or a LineTo
            FiFreeHandMouseDrawing ++;
            VideoGrabber->RefreshPlayerOverlays();
         }
      }
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberMouseUp(TObject *Sender,
      int VideoWindow, TMouseButton Button, TShiftState Shift, int X,
      int Y)
{
   FFreeHandMouseDrawingEnabled = false;
   VideoGrabber->RefreshPlayerOverlays();
}

//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberResizeVideo(TObject *Sender,
      int SourceWidth, int SourceHeight)
{
   trkCroppingX->Min = -VideoGrabber->Cropping_Width;
   trkCroppingY->Min = -VideoGrabber->Cropping_Height;
   trkCroppingX->Max = VideoGrabber->Cropping_XMax;
   trkCroppingY->Max = VideoGrabber->Cropping_YMax;
}
//---------------------------------------------------------------------------

////////////////////////////////////////////////////////////////////////////////
//                           VIDEO PROCESSING TAB
////////////////////////////////////////////////////////////////////////////////


void __fastcall TfrmMainForm::rdgVideoRotationClick(TObject *Sender)
{
   VideoGrabber->VideoProcessing_Rotation = TVideoRotation (rdgVideoRotation->ItemIndex);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtCustomRotationAngleChange(TObject *Sender)
{
   VideoGrabber->VideoProcessing_RotationCustomAngle = StrToFloatDef (edtCustomRotationAngle->Text, 0);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::updPixellizationClick(TObject *Sender,
      TUDBtnType Button)
{
   VideoGrabber->VideoProcessing_Pixellization = updPixellization->Position;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::rdgDeinterlacingClick(TObject *Sender)
{
   VideoGrabber->VideoProcessing_Deinterlacing = TVideoDeinterlacing (rdgDeinterlacing->ItemIndex);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::tbrBrightnessChange(TObject *Sender)
{
   VideoGrabber->VideoProcessing_Brightness = - tbrBrightness->Position;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::tbrConstrastChange(TObject *Sender)
{
   VideoGrabber->VideoProcessing_Contrast = - tbrConstrast->Position;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::tbrSaturationChange(TObject *Sender)
{
   VideoGrabber->VideoProcessing_Saturation = - tbrSaturation->Position;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::tbrHueChange(TObject *Sender)
{
   VideoGrabber->VideoProcessing_Hue = tbrHue->Position;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnResetAllClick(TObject *Sender)
{
   rdgVideoRotation->ItemIndex = 0;
   rdgDeinterlacing->ItemIndex = 0;
   tbrBrightness->Position = 0;
   tbrConstrast->Position = 0;
   tbrSaturation->Position = 0;
   tbrHue->Position = 0;
   chkGreyScale->Checked = false;
   chkInvertColors->Checked = false;
   chkFlipVertical->Checked = false;
   chkFlipHorizontal->Checked = false;
   updPixellization->Position = 1;
   VideoGrabber->VideoProcessing_Pixellization = 1;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkFlipVerticalClick(TObject *Sender)
{
   VideoGrabber->VideoProcessing_FlipVertical = chkFlipVertical->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkFlipHorizontalClick(TObject *Sender)
{
   VideoGrabber->VideoProcessing_FlipHorizontal = chkFlipHorizontal->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkGreyScaleClick(TObject *Sender)
{
   VideoGrabber->VideoProcessing_GrayScale = chkGreyScale->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkInvertColorsClick(TObject *Sender)
{
   VideoGrabber->VideoProcessing_InvertColors = chkInvertColors->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::vmr9FixRangeClick(TObject *Sender)
{
   // fixes a possible problem of constrast and saturation range with some video decoders, passed to the SetVMR9ImageAdjustmentValue function below
}
//---------------------------------------------------------------------------


void __fastcall TfrmMainForm::tbrVMR9BrightnessChange(TObject *Sender)
{
   VideoGrabber->SetVMR9ImageAdjustmentValue (true, vmr9_Brightness, tbrVMR9Brightness->Position, false);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::tbrVMR9ContrastChange(TObject *Sender)
{
   VideoGrabber->SetVMR9ImageAdjustmentValue (true, vmr9_Contrast, tbrVMR9Contrast->Position, vmr9FixRange->Checked);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::tbrVMR9SaturationChange(TObject *Sender)
{
   VideoGrabber->SetVMR9ImageAdjustmentValue (true, vmr9_Saturation, tbrVMR9Saturation->Position, vmr9FixRange->Checked);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::tbrVMR9HueChange(TObject *Sender)
{
   VideoGrabber->SetVMR9ImageAdjustmentValue (true, vmr9_Hue, tbrVMR9Hue->Position, false);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::InitVMR9Trackbar (TVMR9ImageAdjustment VMR9ImageAdjustment, TTrackBar *TrackBar)
{
   int MinValue, MaxValue, StepSize, DefaultValue, CurrentValue;

   TrackBar->Enabled = VideoGrabber->GetVMR9ImageAdjustmentBounds (true, vmr9_Brightness, MinValue, MaxValue, StepSize, DefaultValue, CurrentValue);
   if (TrackBar->Enabled) {
      TrackBar->Min = MinValue;
      TrackBar->Max = MaxValue;
      TrackBar->Frequency = StepSize;
      TrackBar->Position = CurrentValue;
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberGraphBuilt(TObject *Sender)
{
   InitVMR9Trackbar (vmr9_Brightness, tbrVMR9Brightness);
   InitVMR9Trackbar (vmr9_Contrast, tbrVMR9Contrast);
   InitVMR9Trackbar (vmr9_Saturation, tbrVMR9Saturation);
   InitVMR9Trackbar (vmr9_Hue, tbrVMR9Hue);

   tbrAudioBalance->Position = VideoGrabber->AudioBalance;
   tbrAudioVolume->Position = VideoGrabber->AudioVolume;

   tbrZoomX->Min = - (VideoGrabber->VideoWidth / 2);
   tbrZoomX->Max = VideoGrabber->VideoWidth / 2;
   tbrZoomY->Min = - (VideoGrabber->VideoHeight / 2);
   tbrZoomY->Max = VideoGrabber->VideoHeight / 2;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::tbrZoomChange(TObject *Sender)
{
   VideoGrabber->ZoomCoeff = tbrZoom->Position;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::tbrZoomXChange(TObject *Sender)
{
   VideoGrabber->ZoomXCenter = tbrZoomX->Position;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::tbrZoomYChange(TObject *Sender)
{
   VideoGrabber->ZoomYCenter = tbrZoomY->Position;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkCroppingEnabledClick(TObject *Sender)
{
   VideoGrabber->Cropping_Enabled = chkCroppingEnabled->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkCroppingOutboundsClick(TObject *Sender)
{
   VideoGrabber->Cropping_Outbounds = chkCroppingOutbounds->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtCroppingWidthChange(TObject *Sender)
{
   VideoGrabber->Cropping_Width = StrToIntDef (edtCroppingWidth->Text, 0);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtCroppingHeightChange(TObject *Sender)
{
   VideoGrabber->Cropping_Height = StrToIntDef (edtCroppingHeight->Text, 0);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::trkCroppingZoomChange(TObject *Sender)
{
   VideoGrabber->Cropping_Zoom = trkCroppingZoom->Position / 100;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnCroppingZoomResetClick(TObject *Sender)
{
   trkCroppingZoom->Position = 100;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::trkCroppingYChange(TObject *Sender)
{
   // trkCroppingX->Max and trkCroppingY->Max are set from the OnResizeVideo event
   VideoGrabber->Cropping_Y = trkCroppingY->Position;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::trkCroppingXChange(TObject *Sender)
{
   // trkCroppingX->Max and trkCroppingY->Max are set from the OnResizeVideo event
   VideoGrabber->Cropping_X = trkCroppingX->Position;
}
//---------------------------------------------------------------------------

////////////////////////////////////////////////////////////////////////////////
//                                DISPLAY TAB
////////////////////////////////////////////////////////////////////////////////

void __fastcall EnableOrDisableGroupBoxControls (TGroupBox *GroupBox, bool Value)
{
   int i;

   for (i = 0 ; i < GroupBox->ControlCount ; i ++) {
      GroupBox->Controls[i]->Enabled = Value;
   }
}

void __fastcall TfrmMainForm::RefreshDisplayOptions(void)
{
   if (ComponentState.Contains(csDestroying)) return; // do nothing if the app terminates

   // let's refresh the controls according to the TVideoGrabber's states

   AssignListToComboBox (cboVideoDevices, VideoGrabber->VideoDevices, VideoGrabber->VideoDevice);
   AssignListToComboBox (cboAudioDevices, VideoGrabber->AudioDevices, VideoGrabber->AudioDevice);
   AssignListToComboBox (cboAudioRenderers, VideoGrabber->AudioRenderers, VideoGrabber->AudioRenderer);

   chk1stVideoWindowActive->Checked = VideoGrabber->Display_Active;
   chk1stVisible->Checked           = VideoGrabber->Display_Visible;
   chk1stEmbedded->Checked          = VideoGrabber->Display_Embedded;
   chk1stFullScreen->Checked        = VideoGrabber->Display_FullScreen;
   chk1stStayOnTop->Checked         = VideoGrabber->Display_StayOnTop;
   chk1stUseVideoPort->Checked      = VideoGrabber->Display_VideoPortEnabled;
   chk1stMouseMovesWindow->Checked  = VideoGrabber->Display_MouseMovesWindow;
   chk1stAutoSize->Checked          = VideoGrabber->Display_AutoSize;
   rdg1AspectRatio->ItemIndex       = VideoGrabber->Display_AspectRatio;
   tbr1PanScan->Position            = VideoGrabber->Display_PanScanRatio;

   rdg1stDisplayedOn->ItemIndex     = VideoGrabber->Display_Monitor;

   EnableOrDisableGroupBoxControls (grbMainVideoWindow, VideoGrabber->Display_Active);

   if (VideoGrabber->Display_Active) {
      chk1stStayOnTop->Enabled         = (! VideoGrabber->Display_Embedded) || VideoGrabber->Display_FullScreen;
      rdg1stDisplayedOn->Enabled       = VideoGrabber->MonitorsCount() > 1;
      chk1stMouseMovesWindow->Enabled  = ! VideoGrabber->Display_Embedded;
      btnEG1stNewLocation->Enabled     = ! VideoGrabber->Display_Embedded;
      btnEG1stNewLocation2->Enabled    = ! VideoGrabber->Display_Embedded;
      chk1stUseVideoPort->Enabled      = VideoGrabber->IsVideoPortAvailable;
   }

   chk2ndVideoWindowActive->Checked = VideoGrabber->DualDisplay_Active;
   chk2ndVisible->Checked           = VideoGrabber->DualDisplay_Visible;
   chk2ndEmbedded->Checked          = VideoGrabber->DualDisplay_Embedded;
   chk2ndFullScreen->Checked        = VideoGrabber->DualDisplay_FullScreen;
   chk2ndStayOnTop->Checked         = VideoGrabber->DualDisplay_StayOnTop;
   chk2ndUseVideoPort->Checked      = VideoGrabber->DualDisplay_VideoPortEnabled;
   chk2ndMouseMovesWindow->Checked  = VideoGrabber->DualDisplay_MouseMovesWindow;
   chk2ndAutoSize->Checked          = VideoGrabber->DualDisplay_AutoSize;
   rdg2AspectRatio->ItemIndex       = VideoGrabber->DualDisplay_AspectRatio;
   tbr2PanScan->Position            = VideoGrabber->DualDisplay_PanScanRatio;
   rdg2ndDisplayedOn->ItemIndex     = VideoGrabber->DualDisplay_Monitor;

   EnableOrDisableGroupBoxControls (grb2ndVideoWindow, VideoGrabber->DualDisplay_Active);

   if (VideoGrabber->DualDisplay_Active) {
      chk2ndStayOnTop->Enabled         = (! VideoGrabber->DualDisplay_Embedded) || VideoGrabber->DualDisplay_FullScreen;
      rdg2ndDisplayedOn->Enabled       = VideoGrabber->MonitorsCount() > 1;
      chk2ndMouseMovesWindow->Enabled  = ! VideoGrabber->DualDisplay_Embedded;
      btnEG2ndNewLocation->Enabled     = ! VideoGrabber->DualDisplay_Embedded;
      btnEG2ndNewLocation->Enabled     = ! VideoGrabber->DualDisplay_Embedded;
      chk2ndUseVideoPort->Enabled      = VideoGrabber->IsVideoPortAvailable;
   }
}

//---------------------------------------------------------------------------
void __fastcall TfrmMainForm::chkBlackMagicDecklinkClick(TObject *Sender)
{
   if (chkBlackMagicDecklink->Checked)
   {
      VideoGrabber->VideoRendererExternal = vre_BlackMagic_Decklink;
   }
   else
   {
      VideoGrabber->VideoRendererExternal = vre_None;
   }
}

//---------------------------------------------------------------------------
void __fastcall TfrmMainForm::chkVideoVisibleWhenStoppedClick(
      TObject *Sender)
{
   VideoGrabber->VideoVisibleWhenStopped = chkVideoVisibleWhenStopped->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkAdjustPixelAspectRatioClick(
      TObject *Sender)
{
   VideoGrabber->AdjustPixelAspectRatio = chkAdjustPixelAspectRatio->Checked;
}

//---------------------------------------------------------------------------
void __fastcall TfrmMainForm::chkChangeCursorClick(TObject *Sender)
{
   if (chkChangeCursor->Checked) {
      VideoGrabber->VideoCursor = crCross;
   }
   else {
      VideoGrabber->VideoCursor = crDefault;
   }
}

//---------------------------------------------------------------------------
void __fastcall TfrmMainForm::chkBorderClick(TObject *Sender)
{
   if (chkBorder->Checked) {
      VideoGrabber->BorderStyle = bsSingle;
   }
   else {
      VideoGrabber->BorderStyle = bsNone;
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkTransparencyClick(TObject *Sender)
{
   VideoGrabber->ColorKeyEnabled = chkTransparency->Checked;
   if (VideoGrabber->ColorKeyEnabled) {
      if (FTransparentForm == NULL) {
         Application->CreateForm (__classid (TForm), &FTransparentForm);
         FTransparentForm->Width = 300;
         FTransparentForm->Height = 100;
         FTransparentForm->Position = poScreenCenter;
         FTransparentForm->FormStyle = fsStayOnTop;
         FTransparentPanel = new TPanel (FTransparentForm);
         FTransparentPanel->Parent = FTransparentForm;
         FTransparentPanel->BevelInner = bvNone;
         FTransparentPanel->BevelOuter = bvNone;
         FTransparentPanel->Align = alClient;
         FTransparentPanel->Caption = "transparent window";
         FTransparentPanel->Font->Color = clRed;
         FTransparentPanel->Font->Size = 16;
      }

      FTransparentForm->Color = clBlue;
      FTransparentPanel->Color = VideoGrabber->ColorKey;
      VideoGrabber->SetWindowTransparency ((unsigned int) FTransparentForm->Handle, true, false, 0);
      FTransparentForm->Show();
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::rdgVideoRendererClick(TObject *Sender)
{
   VideoGrabber->VideoRenderer = TVideoRenderer (rdgVideoRenderer->ItemIndex);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chk1stVideoWindowActiveClick(TObject *Sender)
{
   VideoGrabber->Display_Active = chk1stVideoWindowActive->Checked;
   RefreshDisplayOptions();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chk1stVisibleClick(TObject *Sender)
{
   VideoGrabber->Display_Visible = chk1stVisible->Checked;
   RefreshDisplayOptions();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chk1stEmbeddedClick(TObject *Sender)
{
   VideoGrabber->Display_Embedded = chk1stEmbedded->Checked;
   RefreshDisplayOptions();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chk1stAutoSizeClick(TObject *Sender)
{
   VideoGrabber->Display_AutoSize = chk1stAutoSize->Checked;
   RefreshDisplayOptions();
}
//---------------------------------------------------------------------------


void __fastcall TfrmMainForm::chk1stFullScreenClick(TObject *Sender)
{
   VideoGrabber->Display_FullScreen = chk1stFullScreen->Checked;
   RefreshDisplayOptions();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chk1stStayOnTopClick(TObject *Sender)
{
   VideoGrabber->Display_StayOnTop = chk1stStayOnTop->Checked;
   RefreshDisplayOptions();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chk1stUseVideoPortClick(TObject *Sender)
{
   VideoGrabber->Display_VideoPortEnabled = chk1stUseVideoPort->Checked;
   RefreshDisplayOptions();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::rdg1stDisplayedOnClick(TObject *Sender)
{
   VideoGrabber->Display_Monitor = rdg1stDisplayedOn->ItemIndex; // 0 or 1
   RefreshDisplayOptions();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnEG1stNewLocationClick(TObject *Sender)
{
   VideoGrabber->Display_AutoSize = true;  // the component"s video size will be used
   VideoGrabber->Display_Embedded = false; // detach from component
   VideoGrabber->Display_SetLocation (10, 10, 320, 240); // 320 and 240 are ! used because of AutoSize above
   RefreshDisplayOptions();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnEG1stNewLocation2Click(TObject *Sender)
{
   VideoGrabber->Display_AutoSize = false; // we will specify the size below
   VideoGrabber->Display_Embedded = false; // detach from component
   VideoGrabber->Display_SetLocation (20, 20, 480, 360); // new size: 480 x 360
   RefreshDisplayOptions();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chk1stMouseMovesWindowClick(TObject *Sender)
{
   VideoGrabber->Display_MouseMovesWindow = chk1stMouseMovesWindow->Checked;
   RefreshDisplayOptions();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::rdg1AspectRatioClick(TObject *Sender)
{
   VideoGrabber->Display_AspectRatio = (TAspectRatio) rdg1AspectRatio->ItemIndex;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::tbr2PanScanChange(TObject *Sender)
{
   VideoGrabber->DualDisplay_PanScanRatio = tbr2PanScan->Position;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::tbr1PanScanChange(TObject *Sender)
{
   VideoGrabber->Display_PanScanRatio = tbr1PanScan->Position;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnTestPanScanClick(TObject *Sender)
{
   rdg1AspectRatio->ItemIndex = ar_PanScan;
   VideoGrabber->Display_AspectRatio = ar_PanScan;
   VideoGrabber->Display_Embedded = true;
   VideoGrabber->Display_AutoSize = false;
   VideoGrabber->Width = 400;
   VideoGrabber->Height = VideoGrabber->Width * 9 / 16;
}

//---------------------------------------------------------------------------
void __fastcall TfrmMainForm::chk2ndVideoWindowActiveClick(TObject *Sender)
{
   VideoGrabber->DualDisplay_Active = chk2ndVideoWindowActive->Checked;
   RefreshDisplayOptions();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chk2ndVisibleClick(TObject *Sender)
{
   VideoGrabber->DualDisplay_Visible = chk2ndVisible->Checked;
   RefreshDisplayOptions();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chk2ndEmbeddedClick(TObject *Sender)
{
   VideoGrabber->DualDisplay_Embedded = chk2ndEmbedded->Checked;
   RefreshDisplayOptions();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chk2ndFullScreenClick(TObject *Sender)
{
   VideoGrabber->DualDisplay_FullScreen = chk2ndFullScreen->Checked;
   RefreshDisplayOptions();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chk2ndAutoSizeClick(TObject *Sender)
{
   VideoGrabber->DualDisplay_AutoSize = chk2ndAutoSize->Checked;
   RefreshDisplayOptions();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chk2ndStayOnTopClick(TObject *Sender)
{
   VideoGrabber->DualDisplay_StayOnTop = chk2ndStayOnTop->Checked;
   RefreshDisplayOptions();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chk2ndUseVideoPortClick(TObject *Sender)
{
   VideoGrabber->DualDisplay_VideoPortEnabled = chk2ndUseVideoPort->Checked;
   RefreshDisplayOptions();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chk2ndMouseMovesWindowClick(TObject *Sender)
{
   VideoGrabber->DualDisplay_MouseMovesWindow = chk2ndMouseMovesWindow->Checked;
   RefreshDisplayOptions();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::rdg2AspectRatioClick(TObject *Sender)
{
   VideoGrabber->DualDisplay_AspectRatio = (TAspectRatio) rdg2AspectRatio->ItemIndex;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::rdg2ndDisplayedOnClick(TObject *Sender)
{
   VideoGrabber->DualDisplay_Monitor = rdg2ndDisplayedOn->ItemIndex; // 0 or 1
   RefreshDisplayOptions();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnEG2ndNewLocationClick(TObject *Sender)
{
   VideoGrabber->DualDisplay_AutoSize = true;  // the component"s video size will be used
   VideoGrabber->DualDisplay_Embedded = false; // detach from component
   VideoGrabber->DualDisplay_SetLocation (510, 10, 320, 240); // 320 and 240 are ! used because of AutoSize above
   RefreshDisplayOptions();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnEG2ndNewLocation2Click(TObject *Sender)
{
   VideoGrabber->DualDisplay_AutoSize = false; // we will specify the size below
   VideoGrabber->DualDisplay_Embedded = false; // detach from component
   VideoGrabber->DualDisplay_SetLocation (520, 30, 480, 360); // new size: 480 x 360
   RefreshDisplayOptions();
}
//---------------------------------------------------------------------------

////////////////////////////////////////////////////////////////////////////////
//                            MOTION DETECTOR TAB
////////////////////////////////////////////////////////////////////////////////

void __fastcall TfrmMainForm::chkMotionDetectionEnabledClick(
      TObject *Sender)
{
   VideoGrabber->MotionDetector_Enabled = chkMotionDetectionEnabled->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkCompareRedClick(TObject *Sender)
{
   VideoGrabber->MotionDetector_CompareRed = chkCompareRed->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkCompareGreenClick(TObject *Sender)
{
   VideoGrabber->MotionDetector_CompareGreen = chkCompareGreen->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkCompareBlueClick(TObject *Sender)
{
   VideoGrabber->MotionDetector_CompareBlue = chkCompareBlue->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chk_GreyScaleClick(TObject *Sender)
{
   VideoGrabber->MotionDetector_GreyScale = chk_GreyScale->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkReduceVideoNoiseClick(TObject *Sender)
{
   VideoGrabber->MotionDetector_ReduceVideoNoise = chkReduceVideoNoise->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtGridChange(TObject *Sender)
{
   VideoGrabber->MotionDetector_Grid = edtGrid->Text;
   if (VideoGrabber->MotionDetector_IsGridValid) {
      shpGridValid->Brush->Color = clLime;
      lblGridValid->Caption = "valid";
   }
   else {
      shpGridValid->Brush->Color = clRed;
      lblGridValid->Caption = "invalid";
   }
   mmoSensitivityGrid->Text = VideoGrabber->MotionDetector_Get2DTextGrid();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::updGlobalGridSensitivityClick(
      TObject *Sender, TUDBtnType Button)
{
   if (Button == Comctrls::btNext) {
      VideoGrabber->MotionDetector_GloballyIncOrDecSensitivity (1);
   }
   else {
      VideoGrabber->MotionDetector_GloballyIncOrDecSensitivity (-1);
   }
   edtGrid->Text = VideoGrabber->MotionDetector_Grid;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnApplyGridSizeClick(TObject *Sender)
{
   VideoGrabber->MotionDetector_SetGridSize (StrToInt (edtGridColCount->Text), StrToInt (edtGridRowCount->Text));
   edtGrid->Text = VideoGrabber->MotionDetector_Grid;
   mmoSensitivityGrid->Text = VideoGrabber->MotionDetector_Get2DTextGrid();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnSetCellsSensitivityClick(TObject *Sender)
{
   VideoGrabber->MotionDetector_SetCellSensitivity (StrToInt (edtXCell->Text), StrToInt (edtYCell->Text), StrToInt (edtCellSensitivity->Text));
   edtGrid->Text = VideoGrabber->MotionDetector_Grid;
   mmoSensitivityGrid->Text = VideoGrabber->MotionDetector_Get2DTextGrid();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnShowGridDialogClick(TObject *Sender)
{
   if ((VideoGrabber->CurrentState != cs_Preview) && (VideoGrabber->CurrentState != cs_Recording)) {
      ShowMessage ("you should start preview or recording to see the video frame under the grid");
   }
   else if (! VideoGrabber->MotionDetector_Enabled) {
      ShowMessage ("you should enable the motion detector first (MotionDetector_Enabled = true) to see the video frame under the grid");
   }
   VideoGrabber->MotionDetector_ShowGridDialog();
   edtGrid->Text = VideoGrabber->MotionDetector_Grid;
   mmoSensitivityGrid->Text = VideoGrabber->MotionDetector_Get2DTextGrid();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkTriggeredClick(TObject *Sender)
{
   VideoGrabber->MotionDetector_Triggered = chkTriggered->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnTriggerNowClick(TObject *Sender)
{
   VideoGrabber->MotionDetector_TriggerNow();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberMotionDetected(TObject *Sender,
      double GlobalMotionRatio, int MaxMotionCellX, int MaxMotionCellY,
      Pointer FrameBitmap, DWORD FrameNumber, Int64 FrameTime, int FrameId,
      bool &CaptureFrame)
{
   int MaxMotionXLocation, MaxMotionYLocation;
   Graphics::TBitmap *MotionBitmap;

   shpMotionDetected->Brush->Color = clLime;
   edtMotionRatio->Text = FormatFloat ("0.000", VideoGrabber->MotionDetector_GlobalMotionRatio);

   edtMaxMotionXY->Text = "X:" + IntToStr (MaxMotionCellX) + " ; Y:" + IntToStr (MaxMotionCellY);
   if (VideoGrabber->MotionDetector_GetCellLocation (MaxMotionCellX, MaxMotionCellY, MaxMotionXLocation, MaxMotionYLocation)) {
      edtMaxMotionCoord->Text = "x: " + IntToStr (MaxMotionXLocation) + " ; y: " + IntToStr (MaxMotionYLocation);
   }

   mmoMotionGrid->Text = VideoGrabber->MotionDetector_Get2DTextMotion();

   MotionBitmap = VideoGrabber->GetLastFrameAsTBitmap (0, false, 0, 0, 0, 0, imgMotionDetected->Width, imgMotionDetected->Height, 0);
   if (MotionBitmap != NULL) {
      imgMotionDetected->Picture->Assign (MotionBitmap);
      delete (MotionBitmap);
   }

}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberMotionNotDetected(
      TObject *Sender, Pointer FrameBitmap, DWORD FrameNumber,
      Int64 FrameTime, int FrameId, bool &CaptureFrame)
{
   shpMotionDetected->Brush->Color = clGreen;
   edtMotionRatio->Text = "";
   mmoMotionGrid->Text = VideoGrabber->MotionDetector_Get2DTextMotion();
}
//---------------------------------------------------------------------------

////////////////////////////////////////////////////////////////////////////////
//                         "CLIP REENCODING" TAB
////////////////////////////////////////////////////////////////////////////////

void __fastcall TfrmMainForm::btnSourceVideoClipClick(TObject *Sender)
{
   TOpenDialog *OpenDlg = new TOpenDialog(NULL);
   OpenDlg->Filter = OPEN_MEDIA_FILES;
   if (OpenDlg->Execute()) {
      edtSourceVideoClip->Text = OpenDlg->FileName;
   }
   delete (OpenDlg);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnDurationClick(TObject *Sender)
{
   __int64 Duration;
   __int64 FrameCount;

   if (VideoGrabber->AVIDuration (edtSourceVideoClip->Text, Duration, FrameCount)) {
      edtReencDuration->Text = IntToStr (Duration);
      edtReencDuration->Text = IntToStr (Duration);
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnStartReencodingClick(TObject *Sender)
{
   VideoGrabber->Reencoding_SourceVideoClip = edtSourceVideoClip->Text;
   VideoGrabber->Reencoding_NewVideoClip = edtDestinationVideoClip->Text;

   VideoGrabber->Reencoding_WMVOutput = chkWMVOutput->Checked;
   VideoGrabber->Reencoding_IncludeVideoStream = chkIncludeVideoStream->Checked;
   VideoGrabber->Reencoding_IncludeAudioStream = chkIncludeAudioStream->Checked;
   VideoGrabber->Reencoding_UseFrameGrabber = chkUseFrameGrabber->Checked;
   VideoGrabber->Reencoding_UseVideoCompressor = chkUseCurrentVideoCompressor->Checked;
   VideoGrabber->Reencoding_UseAudioCompressor = chkUseCurrentAudioCompressor->Checked;
   VideoGrabber->Reencoding_Method = TRecordingMethod (rdgReencodingMethod->ItemIndex);

   // if a frame number is specified (<> -1), it is mandatory, so the time is ignored
   VideoGrabber->Reencoding_StartTime  = StrToInt64Def (edtReencStartTime->Text, -1);
   VideoGrabber->Reencoding_StartFrame  = StrToInt64Def (edtReencStartFrame->Text, -1);
   VideoGrabber->Reencoding_StopTime   = StrToInt64Def (edtReencStopTime->Text, -1);
   VideoGrabber->Reencoding_StopFrame   = StrToInt64Def (edtReencStopFrame->Text, -1);

   VideoGrabber->StartReencoding();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnStopReencodingClick(TObject *Sender)
{
   VideoGrabber->StopReencoding();
}
//---------------------------------------------------------------------------

////////////////////////////////////////////////////////////////////////////////
//                                    MISC.
////////////////////////////////////////////////////////////////////////////////


void __fastcall TfrmMainForm::edtStoragePathChange(TObject *Sender)
{
   VideoGrabber->StoragePath = edtStoragePath->Text;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::RefreshDeviceControls(void)
{
   if (ComponentState == (TComponentState() << csDestroying)) {
      // we do nothing if the app terminates
      return;
   }

   // refresh the controls according to the TVideoGrabber's states

   btnPauseRecording->Enabled = VideoGrabber->RecordingCanPause;
   btnResumeRecording->Enabled = VideoGrabber->RecordingCanPause;

   btnStreamDialog->Enabled = ! VideoGrabber->IsDigitalVideoIn;
   btnCameraControlDialog->Enabled = VideoGrabber->IsCameraControlAvailable;
   btnVideoQualityDialog->Enabled = VideoGrabber->IsVideoQualityAvailable;
   btnVideoControlDialog->Enabled = VideoGrabber->IsVideoControlAvailable;

   cboAnalogVideoStandard->Enabled = VideoGrabber->IsAnalogVideoDecoderAvailable;
   cboVideoInputs->Enabled = VideoGrabber->IsVideoCrossbarAvailable;

   edtFrameRate->Text = FormatFloat ("0.00", VideoGrabber->FrameRate);

   rdgTunerMode->ItemIndex = VideoGrabber->TunerMode;
   rdgTunerInputType->ItemIndex = VideoGrabber->TVTunerInputType;
   edtCountryCode->Text = IntToStr (VideoGrabber->TVCountryCode);
   edtTVChannel->Text = IntToStr (VideoGrabber->TVChannel);
   lblTVTunerAvailable->Visible = ! VideoGrabber->IsTVTunerAvailable;

   lblFrameOverlayRequiresFrameGrabber->Visible = VideoGrabber->FrameGrabber == fg_Disabled;
   lblMotionDetectorRequiresFrameGrabber->Visible = VideoGrabber->FrameGrabber == fg_Disabled;

   if (frmVideoControl) {
      frmVideoControl->RefreshControls();
   }

   bool CanUseCompressors = (VideoGrabber->RecordingMethod != rm_AVI) && (VideoGrabber->RecordingMethod != rm_SendToDV);

   bool CanUseMultiplexer = CanUseCompressors && (VideoGrabber->RecordingMethod != rm_AVI);

   rdgCompressMode->Enabled = CanUseCompressors;
   rdgCompressType->Enabled = CanUseCompressors;
   cboVideoCompressors->Enabled = CanUseCompressors;
   btnVideoCompressorSettings->Enabled = CanUseCompressors;
   cboAudioCompressors->Enabled = CanUseCompressors;
   btnAudioCompressorSettings->Enabled = CanUseCompressors;
   chkPreallocFile->Enabled = CanUseCompressors;
   cboMultiplexers->Enabled = CanUseMultiplexer;
}

void __fastcall TfrmMainForm::SendVCRCommand (TObject *Sender)
{
   // THE "TAG" PROPERTY OF EACH MENU ITEM IS USED TO SELECT THE CORRESPONDING TVCRCommand value
   if (VideoGrabber->SendDVCommand (TDVCommand (((TMenuItem*) Sender)->Tag))) {
      mmoLog->Lines->Add ("DV command sent...");
   }
   else {
      mmoLog->Lines->Add ("DV command failed.");
   }
}
void __fastcall TfrmMainForm::VideoGrabberDVCommandCompleted(
      TObject *Sender, int NewStateValue, String NewStateLabel)
{
   mmoLog->Lines->Add ("camcorder state: " + NewStateLabel);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::Resetvideocapturedevicesettings1Click(
      TObject *Sender)
{
   VideoGrabber->ResetVideoDeviceSettings();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberDVDiscontinuity(TObject *Sender,
      bool &DeliverNewFrame)
{
   // SAMPLE CODE 1: creates a new file during recording when a discontinuity in the DV date/time is detected (uncommend the 2 lines below)
   // DeliverNewFrame = false;
   // VideoGrabber->RecordToNewFileNow();

   // SAMPLE CODE 2: stops the recording when a discontinuity in the DV date/time is detected (uncommend the 2 lines below)
   // DeliverNewFrame = false;
   // VideoGrabber->StopRecording();

   // Important: from this event you should not perform any actions with the potential to block, such as holding
   //   a critical section or waiting on another thread. Also, do not call any GDI or USER32.DLL APIs.
   
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberLog(TObject *Sender,
      TLogType LogType, String Severity, String InfoMsg)
{
   mmoLog->Lines->Add ("[" + Severity + "] " + InfoMsg);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberInactive(TObject *Sender)
{
   mmoLog->Lines->Add ("(done)");
}
//---------------------------------------------------------------------------
void __fastcall TfrmMainForm::ShowFormAboveVideo (TForm *Form)
{
   if (Form == NULL) return;
   Form->Top = Top + VideoGrabber->Top - Form->Height;
   Form->Left = Left + VideoGrabber->Left - Form->Width;
   if (Form->Top < 0) {
      Form->Top = 0;
   }
   if (Form->Left < 0) {
      Form->Left = 0;
   }
   Form->Show();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::mnuAboutClick(TObject *Sender)
{
   VideoGrabber->About();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberResize(TObject *Sender)
{
   int NewWidth;
   int NewHeight;

   NewWidth = VideoGrabber->Left + VideoGrabber->Width + 30;
   NewHeight = VideoGrabber->Top + VideoGrabber->Height + 60;
   if (NewWidth < FStartupWidth) {
      NewWidth = FStartupWidth;
   }
   if (NewHeight < FStartupHeight) {
      NewHeight = FStartupHeight;
   }
   if ((NewWidth >= Width) && (NewHeight >= Height)) {
      Width = NewWidth;
      Height = NewHeight;
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberDeviceLost(TObject *Sender)
{
   mmoLog->Lines->Add ("DEVICE LOST!");
   AssignListToComboBox (cboVideoDevices, VideoGrabber->VideoDevices, VideoGrabber->VideoDevice);
   AssignListToComboBox (cboAudioDevices, VideoGrabber->AudioDevices, VideoGrabber->AudioDevice);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberDiskFull(TObject *Sender)
{
   mmoLog->Lines->Add ("DISK FULL!");
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberReinitializing(TObject *Sender)
{
   mmoLog->Clear();
   FOldVideoSignalState = false;
}
//---------------------------------------------------------------------------
void __fastcall TfrmMainForm::VideoGrabberDeviceArrivalOrRemoval(
      TObject *Sender, bool IsDeviceArrival, bool IsVideoDevice,
      String DeviceName, int DeviceIndex)
{
   String AudioOrVideoDevice;

   if (IsVideoDevice) {
      AudioOrVideoDevice= "video device ";
   }
   else {
      AudioOrVideoDevice= "audio device ";
   }
   if (IsDeviceArrival) {
      mmoLog->Lines->Add (AudioOrVideoDevice + "arrival:");
   }
   else {
      mmoLog->Lines->Add (AudioOrVideoDevice + "removal:");
   }
   mmoLog->Lines->Add (DeviceName);
   if (IsVideoDevice) {
      AssignListToComboBox (cboVideoDevices, VideoGrabber->VideoDevices, VideoGrabber->VideoDevice);
   }
   else {
      AssignListToComboBox (cboAudioDevices, VideoGrabber->AudioDevices, VideoGrabber->AudioDevice);
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::VideoGrabberVideoFromBitmapsNextFrameNeeded(
      TObject *Sender, bool FirstSample)
{
   // you can pass to this event:
   // - either the path to a BMP file or a JPEG file (this is the case in this example)
   // - either a the HBITMAP handle of a bitmap

   // FirstSample is true the first time the event occurs (useful to know e.g. when a file search must be restarted from the beginning)

   bool FileAvailable;
   bool EndOfData;
   String BMPorJPEGFilePath;

   FileAvailable = false;
   EndOfData = false;

   if (FirstSample || (! FSearchBmpOrJPEGFilesOpened))  { // let's start from the first file
      if (FSearchBmpOrJPEGFilesOpened) {
        FindClose (FSearchBmpOrJPEGFiles);
        FSearchBmpOrJPEGFilesOpened = false;
      }

      if (VideoGrabber->StoragePath.Length() > 0) { // let's add a trailing slash if required
         if (VideoGrabber->StoragePath.SubString (VideoGrabber->StoragePath.Length(), 1) == "\\") {
            FSearchBmpPath = VideoGrabber->StoragePath;
         }
         else {
            FSearchBmpPath = VideoGrabber->StoragePath + "\\";
         }
      }
      else {
         FSearchBmpPath = ".\\";
      }

      if (FindFirst (FSearchBmpPath + "*.bmp", faAnyFile, FSearchBmpOrJPEGFiles) == 0) {
         FileAvailable = true;
         FSearchBmpOrJPEGFilesOpened = true;
      }
      else if (FindFirst (FSearchBmpPath + "*.jpg", faAnyFile, FSearchBmpOrJPEGFiles) == 0) {
         FileAvailable = true;
         FSearchBmpOrJPEGFilesOpened = true;
      }
      else {
         mmoLog->Lines->Add ("");
         mmoLog->Lines->Add ("no bitmap files found in the StoragePath directory! Capture frames to BMP files first by using the frame grabber.");
         EndOfData = true;
      }
   }
   else {
      if (FindNext (FSearchBmpOrJPEGFiles) == 0) {
         FileAvailable = true;
      }
      else {
         FindClose (FSearchBmpOrJPEGFiles);
         FSearchBmpOrJPEGFilesOpened = false;
         EndOfData = true;
      };
   };

   if (FileAvailable) {
      BMPorJPEGFilePath = FSearchBmpPath + FSearchBmpOrJPEGFiles.Name;
      VideoGrabber->SendImageToVideoFromBitmaps (BMPorJPEGFilePath, NULL, false, EndOfData);
   };
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnOpenAtFramesClick(TObject *Sender)
{
   // -2 is just used to check if the numeric value is valid
   if ((StrToIntDef (edtStartFrame->Text, -2) != -2) && (StrToIntDef (edtStopFrame->Text, -2) != -2)) {
      VideoGrabber->OpenPlayerAtFramePositions (StrToInt (edtStartFrame->Text), StrToInt (edtStopFrame->Text), chkKeepBounds->Checked, chkReopen->Checked);
   }
   else {
      ShowMessage ("invalid start frame or stop frame");
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnOpenAtTimesClick(TObject *Sender)
{
   // -2 is just used to check if the numeric value is valid
   if ((StrToIntDef (edtStartTime->Text, -2) != -2) && (StrToIntDef (edtStopTime->Text, -2) != -2)) {
      VideoGrabber->OpenPlayerAtTimePositions (StrToInt (edtStartTime->Text), StrToInt (edtStopTime->Text), chkKeepBounds->Checked, chkReopen->Checked);
   }
   else {
      ShowMessage ("invalid start Time or stop Time");
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::tbsIPCamerasShow(TObject *Sender)
{
   lblChooseIPCamera->Visible = (VideoGrabber->VideoSource != vs_IPCamera);

}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnCurrentIPCameraURLClick(TObject *Sender)
{
      ShellExecute(0, "open", "http://www.datastead.com/demo/IPCam.htm", NULL, NULL, SW_SHOW);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtIPCameraURLChange(TObject *Sender)
{
   VideoGrabber->IPCameraURL = edtIPCameraURL->Text;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtIPCamUserNameChange(TObject *Sender)
{
   VideoGrabber->SetAuthentication (at_IPCamera, edtIPCamUserName->Text, edtIPCamPassword->Text);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtIPCamPasswordChange(TObject *Sender)
{
   VideoGrabber->SetAuthentication (at_IPCamera, edtIPCamUserName->Text, edtIPCamPassword->Text);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtIPCamConnectionTimeoutChange(
      TObject *Sender)
{
   VideoGrabber->SetIPCameraSetting (ips_ConnectionTimeout, StrToIntDef (edtIPCamConnectionTimeout->Text, 10000));
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtIPCamReceiveTimeoutChange(TObject *Sender)
{
   VideoGrabber->SetIPCameraSetting (ips_ReceiveTimeout, StrToIntDef (edtIPCamReceiveTimeout->Text, 5000));
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnIPCamStartPreviewClick(TObject *Sender)
{
   if (VideoGrabber->VideoSource != vs_IPCamera) {
      if (VideoGrabber->CurrentState == cs_Down) {
         VideoGrabber->VideoSource = vs_IPCamera;
         mmoLog->Lines->Add ("VideoSource set to vs_IPCamera");
      }
      else {
         ShowMessage ("stop the current action, then select 'IP camera' in the 'Video sources' list of the 'Video Source' tab");
      }
   }
   VideoGrabber->StartPreview();
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnIPCamSendCommandClick(TObject *Sender)
{
   if (VideoGrabber->SendIPCameraCommand (edtIPCamCommand->Text)) {
      mmoLog->Lines->Add ("IP camera command successfully sent.");
   }
   else {
      mmoLog->Lines->Add ("failed to send the IP camera command (wrong IP address, command not supported or authentication failed)");
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnIPCamAuthenticationInfoClick(
      TObject *Sender)
{
   ShowMessage ("when an authentication is required to connect to the IP camera, the OnAuthenticationNeeded event occurs.\nThe user name and password must be passed to the UserName and Password parameters of this event.");

}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::FormDestroy(TObject *Sender)
{
   if (FSearchBmpOrJPEGFilesOpened) {
      FindClose (FSearchBmpOrJPEGFiles);
      FSearchBmpOrJPEGFilesOpened = false;
   }
}
//---------------------------------------------------------------------------

TVideoGrabber *PIPVideoGrabber = NULL;

void __fastcall TfrmMainForm::btnPIPFromAnotherTVideoGrabberClick(
      TObject *Sender)
{
   TOpenDialog *OpenDlg = new TOpenDialog(NULL);
   OpenDlg->Filter = OPEN_MEDIA_FILES;
   if (OpenDlg->Execute()) {
      if (PIPVideoGrabber == NULL) {
         PIPVideoGrabber = new TVideoGrabber(this);
         PIPVideoGrabber->VideoRenderer = vr_None;
         PIPVideoGrabber->Visible = false;
         VideoGrabber->Mixer_SetupPIPFromSource (PIPVideoGrabber->UniqueID, 0, 0, 0, 0, true, 10, 10, 200, 150, false);
      }
      PIPVideoGrabber->PlayerFileName = OpenDlg->FileName;
      PIPVideoGrabber->OpenPlayer();
   }
   delete (OpenDlg);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::rdgImageOverlaySelectorClick(TObject *Sender)
{
   VideoGrabber->ImageOverlaySelector = rdgImageOverlaySelector->ItemIndex;
   chkImageOverlayEnabled->Checked = VideoGrabber->ImageOverlayEnabled;
   edtImageOverlayLeft->Text = IntToStr (VideoGrabber->ImageOverlay_LeftLocation);
   edtImageOverlayTop->Text = IntToStr (VideoGrabber->ImageOverlay_TopLocation);
   edtImageOverlayWidth->Text = IntToStr (VideoGrabber->ImageOverlay_Width);
   edtImageOverlayHeight->Text = IntToStr (VideoGrabber->ImageOverlay_Height);

   chkImageOverlayTransparent->Checked = VideoGrabber->ImageOverlay_Transparent;
   chkImageOverlayUseTransparentColor->Checked = VideoGrabber->ImageOverlay_UseTransparentColor;
   TVarRec TransparentColorValueVar[] = {VideoGrabber->ImageOverlay_TransparentColorValue};
   edtImageOverlayTransparentColorValue->Text = Format ("$%.6X", TransparentColorValueVar, (ARRAYSIZE(TransparentColorValueVar) -1));

   chkImageOverlayAlphaBlend->Checked = VideoGrabber->ImageOverlay_AlphaBlend;
   chkImageOverlayAlphablendCoeff->Position = (short) VideoGrabber->ImageOverlay_AlphaBlendValue;

   chkImageOverlayChromaKey->Checked = VideoGrabber->ImageOverlay_ChromaKey;
   edtChromaKeyLeewayPercent->Position = VideoGrabber->ImageOverlay_ChromaKeyLeewayPercent;
   TVarRec ChromaKeyColorValueVar[] = {VideoGrabber->ImageOverlay_ChromaKeyRGBColor};
   edtChromaKeyColorValue->Text = Format ("%.6X", ChromaKeyColorValueVar, (ARRAYSIZE(ChromaKeyColorValueVar) -1));

}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkBitmapOverlayEnabledClick(TObject *Sender)
{
   VideoGrabber->ImageOverlayEnabled = chkImageOverlayEnabled->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtImageOverlayLeftChange(TObject *Sender)
{
   VideoGrabber->ImageOverlay_LeftLocation = StrToIntDef (edtImageOverlayLeft->Text, 0);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtImageOverlayTopChange(TObject *Sender)
{
   VideoGrabber->ImageOverlay_TopLocation = StrToIntDef (edtImageOverlayTop->Text, 0);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtImageOverlayWidthChange(TObject *Sender)
{
   VideoGrabber->ImageOverlay_Width = StrToIntDef (edtImageOverlayWidth->Text, -1);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtImageOverlayHeightChange(TObject *Sender)
{
   VideoGrabber->ImageOverlay_Height = StrToIntDef (edtImageOverlayHeight->Text, -1);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkImageOverlayTransparentClick(
      TObject *Sender)
{
   VideoGrabber->ImageOverlay_Transparent = chkImageOverlayTransparent->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnImageOverlayPickupColorClick(
      TObject *Sender)
{
   DWORD MouseLocationRGBValue = VideoGrabber->GetRGBPixelAt (-1, -1);
   VideoGrabber->ImageOverlay_TransparentColorValue = MouseLocationRGBValue;
   TVarRec RGBPixelValueVar[] = {(int) MouseLocationRGBValue};
   edtImageOverlayTransparentColorValue->Text = Format ("%.6X", RGBPixelValueVar, (ARRAYSIZE(RGBPixelValueVar) -1));
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnImageOverlayPickupHelpClick(
      TObject *Sender)
{
   ShowMessage ("while the preview is running:\n- load the image overlay\n- enable ""transparent"" and ""use transp. color value""\n- in the video window, click on the video frame on the color of the overlayed image you want to be transparent\n- click on 'pickup the transparent color'");
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkImageOverlayUseTransparentColorClick(
      TObject *Sender)
{
   VideoGrabber->ImageOverlay_UseTransparentColor = chkImageOverlayUseTransparentColor->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtImageOverlayTransparentColorValueChange(
      TObject *Sender)
{
   VideoGrabber->ImageOverlay_TransparentColorValue = StrToIntDef (edtImageOverlayTransparentColorValue->Text, 0);
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkImageOverlayAlphaBlendClick(
      TObject *Sender)
{
   VideoGrabber->ImageOverlay_AlphaBlend = chkImageOverlayAlphaBlend->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkImageOverlayAlphablendCoeffChange(
      TObject *Sender)
{
   VideoGrabber->ImageOverlay_AlphaBlendValue = chkImageOverlayAlphablendCoeff->Position;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::updImageAlphaBendClick(TObject *Sender,
      TUDBtnType Button)
{
   VideoGrabber->ImageOverlay_AlphaBlendValue = chkImageOverlayAlphablendCoeff->Position;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnChooseChromaKeyColorClick(TObject *Sender)
{
   DWORD MouseLocationRGBValue = VideoGrabber->GetRGBPixelAt (-1, -1);
   VideoGrabber->ImageOverlay_TransparentColorValue = MouseLocationRGBValue;
   TVarRec RGBPixelValueVar[] = {(int) MouseLocationRGBValue};
   edtChromaKeyColorValue->Text = Format ("%.6X", RGBPixelValueVar, (ARRAYSIZE(RGBPixelValueVar) -1));
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnImageOverlayPickupChromaHelpClick(
      TObject *Sender)
{
   ShowMessage ("while the clip is playing:\n- in the video window, click on the video frame on the background color you want to be used as chroma key\n- click on the 'pickup the chroma key' button to select it as chroma key\n - load the image overlay and check the 'enabled' button\n- enable 'chroma key' then adjust the leeway percent (default = 25%)");
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::chkImageOverlayChromaKeyClick(
      TObject *Sender)
{
   VideoGrabber->ImageOverlay_ChromaKey = chkImageOverlayChromaKey->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtChromaKeyLeewayPercentChange(
      TObject *Sender)
{
   VideoGrabber->ImageOverlay_ChromaKeyLeewayPercent = edtChromaKeyLeewayPercent->Position;
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::edtChromaKeyColorValueChange(TObject *Sender)
{
   VideoGrabber->ImageOverlay_ChromaKeyRGBColor = StrToIntDef (edtChromaKeyColorValue->Text, 0);
}
//---------------------------------------------------------------------------
void __fastcall TfrmMainForm::btnOpenDVDClick(TObject *Sender)
{
   if (edtPlayerClip->Text == "Choose a clip...") {
      VideoGrabber->PlayerFileName = ""; // this will use the default DVD if available
   }
   else {
      VideoGrabber->PlayerFileName = edtPlayerClip->Text;
   }
   if (VideoGrabber->OpenDVD()) {
      edtPlayerClip->Text = VideoGrabber->PlayerFileName;
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::btnCurrentDVDInfoClick(TObject *Sender)
{
   int i, NumberOfTitles;

   mmoLog->Lines->Add ("");
   mmoLog->Lines->Add ("Total DVD duration: " + FormatFloat ("0.00", VideoGrabber->DVDInfo (edtPlayerClip->Text, dvd_TotalDuration, 0)));
   NumberOfTitles = VideoGrabber->DVDInfo (edtPlayerClip->Text, dvd_NumberOfTitles, 0);
   mmoLog->Lines->Add ("number of titles: " + IntToStr (NumberOfTitles));
   for (i = 1; i <= NumberOfTitles; i ++) {
      mmoLog->Lines->Add ("TITLE: " + IntToStr (i));
      mmoLog->Lines->Add ("duration in seconds : " + FormatFloat ("0.00", VideoGrabber->DVDInfo (edtPlayerClip->Text, dvd_TitleDuration, i)));
      mmoLog->Lines->Add ("frame count: " + FormatFloat ("0", VideoGrabber->DVDInfo (edtPlayerClip->Text, dvd_TitleFrameCount, i)));
      mmoLog->Lines->Add ("frame rate: " + FormatFloat ("0", VideoGrabber->DVDInfo (edtPlayerClip->Text, dvd_TitleFrameRate, i)));
      mmoLog->Lines->Add ("video resolution X: " + FormatFloat ("0", VideoGrabber->DVDInfo (edtPlayerClip->Text, dvd_SourceResolutionX, i)));
      mmoLog->Lines->Add ("video resolution Y: " + FormatFloat ("0", VideoGrabber->DVDInfo (edtPlayerClip->Text, dvd_SourceResolutionY, i)));
      mmoLog->Lines->Add ("");
   }
}
//---------------------------------------------------------------------------

void __fastcall TfrmMainForm::mnuExitClick(TObject *Sender)
{
   Close();
}
//---------------------------------------------------------------------------







void __fastcall TfrmMainForm::BtnCodecExamplesClick(TObject *Sender)
{
   ShellExecute(0, "open", "http://www.datastead.com/tvideograbber-recording-codecs-examples.html?demo=cbuilder", NULL, NULL, SW_SHOW);

}
//---------------------------------------------------------------------------



