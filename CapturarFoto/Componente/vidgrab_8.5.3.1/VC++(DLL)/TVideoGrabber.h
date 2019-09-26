#include <string.h>
#include <unknwn.h>

#ifndef VidgrabDecl
#define VidgrabDecl

//#region DeclareEnumeratedTypes
      typedef enum TAero
      {
      ae_Default = 0,
      ae_AutoBestRenderingQuality = 1,
      ae_ForceOnWhenStartingVideo = 2,
      ae_ForceOffWhenStartingVideo = 3,
      ae_ForceOnImmediately = 4,
      ae_ForceOffImmediately = 5
      } TAero;
      
      typedef enum TApplicationPriority
      {
      ap_default = 0,
      ap_idle = 1,
      ap_normal = 2,
      ap_high = 3,
      ap_realtime = 4
      } TApplicationPriority;
      
      typedef enum TASFDeinterlaceMode
      {
      adm_NotInterlaced = 0,
      adm_DeinterlaceNormal = 1,
      adm_DeinterlaceHalfSize = 2,
      adm_DeinterlaceHalfSizeDoubleRate = 3,
      adm_DeinterlaceInverseTelecine = 4,
      adm_DeinterlaceVerticalHalfSizeDoubleRate = 5
      } TASFDeinterlaceMode;
      
      typedef enum TASFProfileVersion
      {
      apv_ProfileVersion_8 = 0,
      apv_ProfileVersion_9 = 1
      } TASFProfileVersion;
      
      typedef enum TAspectRatio
      {
      ar_Box = 0,
      ar_NoResize = 1,
      ar_Stretch = 2,
      ar_PanScan = 3
      } TAspectRatio;
      
      typedef enum TAudioChannelRenderMode
      {
      acrm_Normal = 0,
      acrm_RenderLeft = 1,
      acrm_RenderRight = 2,
      acrm_MuteLeft = 3,
      acrm_MuteRight = 4,
      acrm_Mute_All = 5,
      acrm_MixLeftAndRight = 6,
      acrm_PassThru = 7
      } TAudioChannelRenderMode;
      
      typedef enum TAudioFormat
      {
      af_default = 0,
      af_8000_8b_1ch = 1,
      af_8000_8b_2ch = 2,
      af_8000_16b_1ch = 3,
      af_8000_16b_2ch = 4,
      af_11025_8b_1ch = 5,
      af_11025_8b_2ch = 6,
      af_11025_16b_1ch = 7,
      af_11025_16b_2ch = 8,
      af_16000_8b_1ch = 9,
      af_16000_8b_2ch = 10,
      af_16000_16b_1ch = 11,
      af_16000_16b_2ch = 12,
      af_22050_8b_1ch = 13,
      af_22050_8b_2ch = 14,
      af_22050_16b_1ch = 15,
      af_22050_16b_2ch = 16,
      af_32000_8b_1ch = 17,
      af_32000_8b_2ch = 18,
      af_32000_16b_1ch = 19,
      af_32000_16b_2ch = 20,
      af_44100_8b_1ch = 21,
      af_44100_8b_2ch = 22,
      af_44100_16b_1ch = 23,
      af_44100_16b_2ch = 24,
      af_48000_8b_1ch = 25,
      af_48000_8b_2ch = 26,
      af_48000_16b_1ch = 27,
      af_48000_16b_2ch = 28
      } TAudioFormat;
      
      typedef enum TAudioSource
      {
      as_Default = 0,
      as_UseExternalAudio = 1
      } TAudioSource;
      
      typedef enum TAuthenticationType
      {
      at_PublishingPoint = 0,
      at_IPCamera = 1,
      at_StreamingUrl = 2
      } TAuthenticationType;
      
      typedef enum TAutoFileName
      {
      fn_Sequential = 0,
      fn_DateTime = 1,
      fn_Counter = 2
      } TAutoFileName;
      
      typedef enum TAVIInfoType
      {
      av_Duration = 0,
      av_FrameCount = 1,
      av_VideoWidth = 2,
      av_VideoHeight = 3,
      av_VideoFrameRateFps = 4,
      av_VideoCodec = 5,
      av_AudioCodec = 6,
      av_AvgBitRate = 7,
      av_AudioChannels = 8,
      av_AudioSamplesPerSec = 9,
      av_AudioBitsPerSample = 10,
      av_FileSizeInKB = 11,
      av_AudioStreams = 12
      } TAVIInfoType;
      
      typedef enum TAVIMuxConfig
      {
      avmx_SetInterleavingMode = 0,
      avmx_SetInterleave = 1,
      avmx_SetPreroll = 2
      } TAVIMuxConfig;
      
      typedef enum TBorderStyle
      {
      bsNone = 0,
      bsSingle = 1
      } TBorderStyle;
      
      typedef enum TCameraControl
      {
      cc_Pan = 0,
      cc_Tilt = 1,
      cc_Roll = 2,
      cc_Zoom = 3,
      cc_Exposure = 4,
      cc_Iris = 5,
      cc_Focus = 6
      } TCameraControl;
      
      typedef enum TCardinalDirection
      {
      cd_North = 0,
      cd_NorthEast = 1,
      cd_East = 2,
      cd_SouthEast = 3,
      cd_South = 4,
      cd_SouthWest = 5,
      cd_West = 6,
      cd_NorthWest = 7,
      cd_Center = 8
      } TCardinalDirection;
      
      typedef enum TCompressionMode
      {
      cm_NoCompression = 0,
      cm_CompressOnTheFly = 1,
      cm_CompressAfterRecording = 2
      } TCompressionMode;
      
      typedef enum TCompressionType
      {
      ct_Video = 0,
      ct_Audio = 1,
      ct_AudioVideo = 2
      } TCompressionType;
      
      typedef enum TCurrentState
      {
      cs_Down = 0,
      cs_Preview = 1,
      cs_Recording = 2,
      cs_Playback = 3,
      cs_Reencoding = 4
      } TCurrentState;
      
      typedef enum TCursors
      {
      cr_Default = 0,
      cr_None = 1,
      cr_Arrow = 2,
      cr_cross = 3,
      cr_IBeam = 4,
      cr_Size = 5,
      cr_SizeNESW = 6,
      cr_SizeNS = 7,
      cr_SizeNWSE = 8,
      cr_SizeWE = 9,
      cr_UpArrow = 10,
      cr_HourGlass = 11,
      cr_Drag = 12,
      cr_NoDrop = 13,
      cr_HSplit = 14,
      cr_VSplit = 15,
      cr_MultiDrag = 16,
      cr_SQLWait = 17,
      cr_No = 18,
      cr_AppStart = 19,
      cr_Help = 20,
      cr_HandPoint = 21,
      cr_SizeAll = 22
      } TCursors;
      
      typedef enum TDialog
      {
      dlg_VideoDevice = 0,
      dlg_VideoCompressor = 1,
      dlg_AudioCompressor = 2,
      dlg_StreamConfig = 3,
      dlg_VfwFormat = 4,
      dlg_VfwSource = 5,
      dlg_vfwDisplay = 6,
      dlg_VideoCrossbar = 7,
      dlg_AudioCrossbar = 8,
      dlg_TVTuner = 9,
      dlg_TVAudio = 10,
      dlg_AudioDevice = 11,
      dlg_NetShowConfig = 12,
      dlg_DScaler = 13,
      dlg_FFDShowVideo = 14,
      dlg_FFDShowAudio = 15,
      dlg_Multiplexer = 16,
      dlg_None = 17
      } TDialog;
      
      typedef enum TDragAction
      {
      dsDragEnter = 0,
      dsDragLeave = 1,
      dsDragMove = 2
      } TDragAction;
      
      typedef enum TDVCommand
      {
      dv_Play = 0,
      dv_Stop = 1,
      dv_Freeze = 2,
      dv_Thaw = 3,
      dv_Ff = 4,
      dv_Rew = 5,
      dv_Record = 6,
      dv_RecordFreeze = 7,
      dv_RecordStrobe = 8,
      dv_StepFwd = 9,
      dv_StepRev = 10,
      dv_ModeShuttle = 11,
      dv_PlayFastestFwd = 12,
      dv_PlaySlowestFwd = 13,
      dv_PlayFastestRev = 14,
      dv_PlaySlowestRev = 15
      } TDVCommand;
      
      typedef enum TDVDInfoType
      {
      dvd_NumberOfVolumes = 0,
      dvd_TotalDuration = 1,
      dvd_NumberOfTitles = 2,
      dvd_TitleDuration = 3,
      dvd_TitleFrameRate = 4,
      dvd_SourceResolutionX = 5,
      dvd_SourceResolutionY = 6,
      dvd_TitleFrameCount = 7
      } TDVDInfoType;
      
      typedef enum TDVSize
      {
      dv_Full = 0,
      dv_Half = 1,
      dv_Quarter = 2,
      dv_DC = 3
      } TDVSize;
      
      typedef enum TDVVideoFormat
      {
      dvf_Default = 0,
      dvf_DVSD = 1,
      dvf_DVHD = 2,
      dvf_DVSL = 3
      } TDVVideoFormat;
      
      typedef enum TDVVideoStandard
      {
      dvs_Default = 0,
      dvs_PAL = 1,
      dvs_NTSC = 2
      } TDVVideoStandard;
      
      typedef enum TFileSort
      {
      fs_TimeAsc = 0,
      fs_TimeDesc = 1,
      fs_NameAsc = 2,
      fs_NameDesc = 3
      } TFileSort;
      
      typedef enum TFormatType
      {
      ft_VideoInfo = 0,
      ft_VideoInfo2 = 1,
      ft_DvInfo = 2,
      ft_Mpeg1Video = 3,
      ft_Mpeg2Video = 4,
      ft_Mpeg1Stream = 5,
      ft_Mpeg2Stream = 6,
      ft_MpegStreamType = 7,
      ft_MpegCustom = 8,
      ft_WaveFormatEx = 9,
      ft_Mpeg1Audio = 10,
      ft_Mpeg2Audio = 11,
      ft_Mpeg3Audio = 12,
      ft_OGG = 13,
      ft_Unknown = 14
      } TFormatType;
      
      typedef enum TFrameCaptureDest
      {
      fc_TBitmap = 0,
      fc_BmpFile = 1,
      fc_JpegFile = 2,
      fc_Clipboard = 3
      } TFrameCaptureDest;
      
      typedef enum TFrameGrabber
      {
      fg_BothStreams = 0,
      fg_PreviewStream = 1,
      fg_CaptureStream = 2,
      fg_Disabled = 3
      } TFrameGrabber;
      
      typedef enum TFrameGrabberRGBFormat
      {
      fgf_Default = 0,
      fgf_RGB32 = 1,
      fgf_RGB24 = 2,
      fgf_RGB565 = 3,
      fgf_RGB555 = 4,
      fgf_RGB8 = 5
      } TFrameGrabberRGBFormat;
      
      typedef enum TFrameInfoId
      {
      fi_FrameNumber = 0,
      fi_DroppedFrameCount = 1,
      fi_SampleTime_Hour = 2,
      fi_SampleTime_Min = 3,
      fi_SampleTime_Sec = 4,
      fi_SampleTime_Hs = 5,
      fi_SampleTime_TotalMin = 6,
      fi_DVTimeCode_IsAvailable = 7,
      fi_DVTimeCode_Hour = 8,
      fi_DVTimeCode_Min = 9,
      fi_DVTimeCode_Sec = 10,
      fi_DVTimeCode_Ff = 11,
      fi_DVTimeCode_TrackNumber = 12,
      fi_DVDateTime_IsAvailable = 13,
      fi_DVDateTime_Year = 14,
      fi_DVDateTime_Month = 15,
      fi_DVDateTime_Day = 16,
      fi_DVDateTime_Hour = 17,
      fi_DVDateTime_Min = 18,
      fi_DVDateTime_Sec = 19
      } TFrameInfoId;
      
      typedef enum TFrameInfoStringId
      {
      fis_DVTimeCode = 0,
      fis_DVDateTime = 1,
      fis_TimeCode = 2,
      fis_FrameTime = 3,
      fis_FrameNumber = 4,
      fis_FullInfo = 5
      } TFrameInfoStringId;
      
      typedef enum TGraphState
      {
      gs_Stopped = 0,
      gs_Paused = 1,
      gs_Running = 2
      } TGraphState;
      
      typedef enum THeaderAttribute
      {
      ha_Title = 0,
      ha_Description = 1,
      ha_Author = 2,
      ha_Copyright = 3,
      ha_AlbumArtist = 4,
      ha_AlbumTitle = 5,
      ha_Composer = 6,
      ha_ContentDistributor = 7,
      ha_Director = 8,
      ha_EncodingTime = 9,
      ha_Genre = 10,
      ha_Language = 11,
      ha_ParentalRating = 12,
      ha_Producer = 13,
      ha_Provider = 14,
      ha_ToolName = 15,
      ha_ToolVersion = 16,
      ha_Writer = 17,
      ha_IARL = 18,
      ha_ICMS = 19,
      ha_ICMT = 20,
      ha_ICRD = 21,
      ha_ICRP = 22,
      ha_IDIM = 23,
      ha_IDPI = 24,
      ha_IENG = 25,
      ha_IGNR = 26,
      ha_IKEY = 27,
      ha_ILGT = 28,
      ha_IMED = 29,
      ha_IPLT = 30,
      ha_IPRD = 31,
      ha_ISFT = 32,
      ha_ISHP = 33,
      ha_ISRC = 34,
      ha_ISRF = 35,
      ha_ITCH = 36
      } THeaderAttribute;
      
      typedef enum TIPCameraSetting
      {
      ips_ConnectionTimeout = 0,
      ips_ReceiveTimeout = 1
      } TIPCameraSetting;
      
      typedef enum TJPEGPerformance
      {
      jpBestQuality = 0,
      jpBestSpeed = 1
      } TJPEGPerformance;
      
      typedef enum TLogoLayout
      {
      lg_Centered = 0,
      lg_Stretched = 1,
      lg_Repeated = 2,
      lg_TopLeft = 3,
      lg_TopRight = 4,
      lg_BottomLeft = 5,
      lg_BottomRight = 6,
      lg_Boxed = 7
      } TLogoLayout;
      
      typedef enum TLogType
      {
      e_add_filter = 0,
      e_add_source_filter = 1,
      e_audio_compressor_not_suitable = 2,
      e_bind_moniker_to_filter = 3,
      e_compressor_possibly_not_suitable = 4,
      e_create_instance = 5,
      e_ddraw_caps_not_suitable = 6,
      e_device_in_use_in_another_graph = 7,
      e_disk_full = 8,
      e_failed = 9,
      e_failed_to_allocate_recording_file = 10,
      e_failed_to_bind_codec = 11,
      e_failed_to_connect_crossbar_pin = 12,
      e_failed_to_connect_to_server = 13,
      e_failed_to_create_directory = 14,
      e_failed_to_create_file = 15,
      e_failed_to_create_temp = 16,
      e_failed_to_bind_frame_grabber = 17,
      e_failed_to_load_ASF_profile = 18,
      e_failed_to_load_ASF_profile_custom_file = 19,
      e_failed_to_load_set_of_bitmaps = 20,
      e_failed_to_set_image_overlay = 21,
      e_failed_to_set_logo = 22,
      e_failed_to_play_backwards = 23,
      e_failed_to_render_file = 24,
      e_failed_to_renew_recording_file = 25,
      e_failed_to_set_player_speed_ratio_with_audio = 26,
      e_failed_to_setup_network_streaming = 27,
      e_failed_to_start_preview = 28,
      e_failed_to_start_recording = 29,
      e_file_in_use = 30,
      e_file_name_not_specified = 31,
      e_file_not_found = 32,
      e_get_audio_format = 33,
      e_get_interface = 34,
      e_get_video_format = 35,
      e_graph_error = 36,
      e_graph_cant_run = 37,
      e_graph_must_be_restarted = 38,
      e_hw_deinterlace_not_supported = 39,
      e_incompatible_options = 40,
      e_index_out_of_range = 41,
      e_invalid_directory = 42,
      e_library_not_found = 43,
      e_load_filter = 44,
      e_no_audio_In_device = 45,
      e_no_device_available = 46,
      e_no_dialog = 47,
      e_no_stream_control = 48,
      e_no_tv_tuner = 49,
      e_no_device_selected = 50,
      e_no_video_input_device = 51,
      e_not_allowed_during_network_streaming = 52,
      e_not_allowed_with_streaming_URL = 53,
      e_not_assigned = 54,
      e_not_multiplexed_master = 55,
      e_not_previewing = 56,
      e_not_recording = 57,
      e_not_reencoding = 58,
      e_not_streaming = 59,
      e_out_of_memory = 60,
      e_pause_resume_disabled = 61,
      e_pin_not_found = 62,
      e_interface_not_assigned = 63,
      e_query_config_avi_mux = 64,
      e_reencoding = 65,
      e_recording_cannot_pause = 66,
      e_render_audio_stream = 67,
      e_render_video_stream = 68,
      e_must_restart_master = 69,
      e_recording_on_motion_failed = 70,
      e_sendtodv_device_index_out_of_bound = 71,
      e_sendtodv_deviceindex_and_videodevice_have_same_value = 72,
      e_sendtodv_failed_to_bind_dv_device = 73,
      e_set_filter_graph = 74,
      e_set_interleaving_mode = 75,
      e_set_master_stream = 76,
      e_set_output_compatibility_index = 77,
      e_set_output_file_name = 78,
      e_set_format = 79,
      e_start_preview_first = 80,
      e_stop_player_first = 81,
      e_stop_preview_first = 82,
      e_stop_recording_first = 83,
      e_stop_reencoding_first = 84,
      e_storage_path_read_only = 85,
      e_streaming_type_not_specified = 86,
      e_third_party_filter_already_inserted = 87,
      e_third_party_filter_error = 88,
      e_trace_log = 89,
      e_tv_command_not_allowed_during_tv_tuning = 90,
      e_tuner_input_not_selected = 91,
      e_TVideoGrabber_Filter_obsolete = 92,
      e_value_out_of_range = 93,
      e_video_compressor_not_suitable = 94,
      e_window_transparency_failed = 95,
      e_invalid_size = 96,
      e_invalid_window_handle = 97,
      e_tuner_mode_not_supported = 98,
      e_publishing_point_connection_failed = 99,
      e_speaker_control_disabled = 100,
      i_audio_device_associated_to_video_device = 101,
      i_begin_discovering_device = 102,
      i_binding_device_or_compressor = 103,
      i_discovering_device = 104,
      i_end_discovering_device = 105,
      i_preallocated_file_size_large_enough = 106,
      i_preallocated_file_size_changed = 107,
      i_preallocated_file_not_suitable = 108,
      i_streaming_to_publishing_point = 109,
      i_third_party_filter_inserted = 110,
      i_using_ASF_Profile = 111,
      i_recording_videosubtype = 112,
      i_ismpegstream = 113,
      i_new_recording_filename = 114,
      i_using_property_group = 115,
      i_streaming_client_connected = 116,
      i_streaming_client_disconnected = 117,
      i_refreshing_preview = 118,
      i_recording_on_motion = 119,
      i_window_found = 120,
      i_limiting_preview = 121,
      i_codec_recommended = 122,
      i_tuner_mode = 123,
      i_DV_date_time_discontinuity = 124,
      w_cannot_connect_thirdparty_filter = 125,
      w_cannot_connect_thirdparty_renderer = 126,
      w_cannot_instantiate_thirdparty_filter = 127,
      w_cannot_route_crossbar = 128,
      w_cannot_use_color_key = 129,
      w_command_delayed = 130,
      w_does_not_apply_to_dv = 131,
      w_find_audio_device = 132,
      w_filter_does_not_save_properties = 133,
      w_frame_grabber_requires_CPU = 134,
      w_hold_recording = 135,
      w_information = 136,
      w_not_playing = 137,
      w_player_audio_should_be_disabled = 138,
      w_recording_cancelled_by_user = 139,
      w_can_pause_and_ASF_incompatible = 140,
      w_set_audio_format = 141,
      w_storage_path_on_network = 142,
      w_tv_tuner = 143,
      w_using_nearest_video_size = 144,
      w_divx_codec_not_installed = 145,
      w_codec_does_not_support_debugger = 146,
      w_divx_codec_profile = 147,
      w_device_partially_supported = 148,
      w_excessive_grid_size = 149,
      w_grid_too_large_for_dialog = 150,
      w_operation_may_lock = 151,
      w_audio_streaming_needs_audiorecording_property_enabled = 152,
      w_network_streaming_disabled = 153,
      w_server_lost_next_retry = 154,
      w_overlay_mixer_not_available = 155,
      w_network_streaming_change_requires_application_to_be_restarted = 156,
      w_standard_renderer_recommended = 157,
      w_window_transparency_and_recording_not_recommended = 158,
      w_clip_not_seekable = 159,
      w_only_WMV_recording_during_network_streaming = 160,
      w_check_analog_video_standard = 161,
      w_recording_timer_set = 162,
      w_stream_time_beyong_script_time = 163,
      w_generate_new_file = 164,
      w_hires_timer_not_available = 165,
      w_applies_to_the_current_recording_method = 166,
      i_leaving_full_screen_mode = 167
      } TLogType;
      
      typedef enum TMainConceptFiltersVersion
      {
      mc_Version4 = 0,
      mc_Version8 = 1
      } TMainConceptFiltersVersion;
      
      typedef enum TMiscDeviceControl
      {
      mdc_GPIO = 0,
      mdc_VPD = 1,
      mdc_VPD_Data = 2
      } TMiscDeviceControl;
      
      typedef enum TMouseButton
      {
      mbLeft = 0,
      mbRight = 1,
      mbMiddle = 2
      } TMouseButton;
      
      typedef enum TMPEGProgramSetting
      {
      mps_Program_Number = 0,
      mps_Program_PCR_PID = 1,
      mps_VideoStream_PID = 2,
      mps_AudioStream_PID = 3,
      mps_VideoStream_Type = 4,
      mps_AudioStream_Type = 5,
      mps_VideoFormat_Width = 6,
      mps_VideoFormat_Height = 7,
      mps_VideoAspectRatio_X = 8,
      mps_VideoAspectRatio_Y = 9,
      mps_ReceiveTimeoutInSeconds = 10
      } TMPEGProgramSetting;
      
      typedef enum TMpegStreamType
      {
      mpst_Default = 0,
      mpst_Program = 1,
      mpst_Program_DVD = 2,
      mpst_Program_DVD_MC = 3,
      mpst_Program_SVCD = 4,
      mpst_MPEG1 = 5,
      mpst_MPEG1_VCD = 6
      } TMpegStreamType;
      
      typedef enum TMultiplexedRole
      {
      mr_NotMultiplexed = 0,
      mr_MultiplexedMosaic4 = 1,
      mr_MultiplexedMosaic16 = 2,
      mr_MultiplexedMaster = 3,
      mr_MultiplexedSlave = 4
      } TMultiplexedRole;
      
      typedef enum TNetworkStreaming
      {
      ns_Disabled = 0,
      ns_ASFDirectNetworkStreaming = 1,
      ns_ASFStreamingToPublishingPoint = 2
      } TNetworkStreaming;
      
      typedef enum TNetworkStreamingType
      {
      nst_AudioVideoStreaming = 0,
      nst_VideoStreaming = 1,
      nst_AudioStreaming = 2
      } TNetworkStreamingType;
      
      typedef enum TNotificationMethod
      {
      nm_Timer = 0,
      nm_Thread = 1
      } TNotificationMethod;
      
      typedef enum TPlayerState
      {
      ps_Closed = 0,
      ps_Stopped = 1,
      ps_Paused = 2,
      ps_Playing = 3,
      ps_PlayingBackward = 4,
      ps_FastForwarding = 5,
      ps_FastRewinding = 6,
      ps_Downloading = 7,
      ps_DownloadCompleted = 8,
      ps_DownloadCancelled = 9
      } TPlayerState;
      
      typedef enum TPlaylist
      {
      pl_Add = 0,
      pl_Remove = 1,
      pl_Clear = 2,
      pl_Loop = 3,
      pl_NoLoop = 4,
      pl_Play = 5,
      pl_Stop = 6,
      pl_Next = 7,
      pl_Previous = 8,
      pl_SortAlpha = 9,
      pl_SortRevAlpha = 10,
      pl_Random = 11,
      pl_Sequential = 12,
      pl_SpecifyPositions = 13,
      pl_Transition = 14
      } TPlaylist;
      
      typedef enum TPointGreyConfig
      {
      pgr_SetRegister = 0,
      pgr_GetRegister = 1,
      pgr_SetBufferSize = 2,
      pgr_GetBufferSize = 3,
      pgr_SetFormat = 4,
      pgr_GetFormat = 5
      } TPointGreyConfig;
      
      typedef enum TRawSampleCaptureLocation
      {
      rl_SourceFormat = 0,
      rl_AfterCompression = 1
      } TRawSampleCaptureLocation;
      
      typedef enum TRecordingMethod
      {
      rm_AVI = 0,
      rm_ASF = 1,
      rm_SendToDV = 2,
      rm_MKV = 3,
      rm_FLV = 4,
      rm_MP4 = 5,
      rm_WebM = 6,
      rm_MPG = 7,
      rm_Multiplexer = 8
      } TRecordingMethod;
      
      typedef enum TRecordingSize
      {
      rs_Default = 0,
      rs_HalfSize = 1,
      rs_QuarterSize = 2
      } TRecordingSize;
      
      typedef enum TRecordingTimer
      {
      rt_Disabled = 0,
      rt_RecordToNewFile = 1,
      rt_StopRecording = 2,
      rt_StartRecording = 3
      } TRecordingTimer;
      
      typedef enum TRegistryRoot
      {
      RR_HKEY_CURRENT_USER = 0,
      RR_HKEY_LOCAL_MACHINE = 1
      } TRegistryRoot;
      
      typedef enum TRGBSelector
      {
      rs_Red = 0,
      rs_Green = 1,
      rs_Blue = 2
      } TRGBSelector;
      
      typedef enum TSynchronizationRole
      {
      sr_Master = 0,
      sr_Slave = 1
      } TSynchronizationRole;
      
      typedef enum TSyncPreview
      {
      sp_Auto = 0,
      sp_Disabled = 1,
      sp_Enabled = 2
      } TSyncPreview;
      
      typedef enum TTextOverlayAlign
      {
      tf_Left = 0,
      tf_Center = 1,
      tf_Right = 2
      } TTextOverlayAlign;
      
      typedef enum TThirdPartyFilterList
      {
      tpf_VideoSource = 0,
      tpf_VideoPreview = 1,
      tpf_VideoRecording = 2,
      tpf_AudioSource = 3,
      tpf_AudioRendering = 4,
      tpf_AudioRecording = 5,
      tpf_VideoRendering = 6,
      tpf_VideoRenderer = 7,
      tpf_AudioRenderer = 8,
      tpf_ThirdPartyVideoSource = 9,
      tpf_ThirdPartyAudioSource = 10,
      tpf_AddToGraph = 11
      } TThirdPartyFilterList;
      
      typedef enum TThreadPriority
      {
      tpIdle = 0,
      tpLowest = 1,
      tpLower = 2,
      tpNormal = 3,
      tpHigher = 4,
      tpHighest = 5,
      tpTimeCritical = 6
      } TThreadPriority;
      
      typedef enum TTrackbarAction
      {
      tba_MouseDown = 0,
      tba_MouseUp = 1,
      tba_KeyDown = 2,
      tba_KeyUp = 3
      } TTrackbarAction;
      
      typedef enum TTriState
      {
      ts_Undefined = 0,
      ts_False = 1,
      ts_True = 2
      } TTriState;
      
      typedef enum TTunerInputType
      {
      TunerInputCable = 0,
      TunerInputAntenna = 1
      } TTunerInputType;
      
      typedef enum TTunerMode
      {
      tm_TVTuner = 0,
      tm_FMRadioTuner = 1,
      tm_AMRadioTuner = 2,
      tm_DigitalSatelliteTuner = 3
      } TTunerMode;
      
      typedef enum TTVChannelInfo
      {
      tci_Channel = 0,
      tci_DefaultVideoFrequency = 1,
      tci_OverriddenVideoFrequency = 2,
      tci_TunerVideoFrequency = 3,
      tci_TunerAudioFrequency = 4,
      tci_Locked = 5
      } TTVChannelInfo;
      
      typedef enum TVideoControl
      {
      vc_FlipHorizontal = 0,
      vc_FlipVertical = 1,
      vc_ExternalTriggerEnable = 2,
      vc_Trigger = 3
      } TVideoControl;
      
      typedef enum TVideoDeinterlacing
      {
      di_Disabled = 0,
      di_HalfSize = 1,
      di_FullSize = 2,
      di_DScaler = 3,
      di_AVISynth = 4,
      di_FFDShow = 5,
      di_ThirdPartyDeinterlacer = 6
      } TVideoDeinterlacing;
      
      typedef enum TVideoQuality
      {
      vq_Brightness = 0,
      vq_Contrast = 1,
      vq_Hue = 2,
      vq_Saturation = 3,
      vq_Sharpness = 4,
      vq_Gamma = 5,
      vq_ColorEnable = 6,
      vq_WhiteBalance = 7,
      vq_BacklightCompensation = 8,
      vq_Gain = 9
      } TVideoQuality;
      
      typedef enum TVideoRenderer
      {
      vr_AutoSelect = 0,
      vr_EVR = 1,
      vr_VMR9 = 2,
      vr_VMR7 = 3,
      vr_StandardRenderer = 4,
      vr_OverlayRenderer = 5,
      vr_RecordingPriority = 6,
      vr_None = 7
      } TVideoRenderer;
      
      typedef enum TVideoRendererExternal
      {
      vre_None = 0,
      vre_Matrox_PRO = 1,
      vre_Decklink_SD = 2,
      vre_Decklink_Extreme = 3,
      vre_Pinnacle_MovieBoard = 4,
      vre_BlackMagic_Decklink = 5
      } TVideoRendererExternal;
      
      typedef enum TVideoRotation
      {
      rt_0_deg = 0,
      rt_90_deg = 1,
      rt_180_deg = 2,
      rt_270_deg = 3,
      rt_0_deg_mirror = 4,
      rt_90_deg_mirror = 5,
      rt_180_deg_mirror = 6,
      rt_270_deg_mirror = 7,
      rt_custom_angle = 8,
      rt_custom_angle_mirror = 9
      } TVideoRotation;
      
      typedef enum TVideoSource
      {
      vs_VideoCaptureDevice = 0,
      vs_ScreenRecording = 1,
      vs_VideoFileOrURL = 2,
      vs_JPEGsOrBitmaps = 3,
      vs_IPCamera = 4,
      vs_Mixer = 5,
      vs_VideoFromImages = 6,
      vs_ThirdPartyFilter = 7
      } TVideoSource;
      
      typedef enum TVideoWindowNotify
      {
      vwActive = 0,
      vwVisible = 1,
      vwAutoSize = 2,
      vwEmbedded = 3,
      vwColorKeyEnabled = 4,
      vwAlphaBlendEnabled = 5,
      vwFullScreen = 6,
      vwStayOnTop = 7,
      vwMouseMovesWindow = 8,
      vwVideoPortEnabled = 9,
      vwMonitor = 10,
      vwAspectRatio = 11,
      vwVideoWidth = 12,
      vwVideoHeight = 13,
      vwPanScanRatio = 14,
      vwColorKeyValue = 15,
      vwAlphaBlendValue = 16,
      vwLeft = 17,
      vwTop = 18,
      vwLocation = 19
      } TVideoWindowNotify;
      
      typedef enum TVMR9ImageAdjustment
      {
      vmr9_Brightness = 0,
      vmr9_Contrast = 1,
      vmr9_Hue = 2,
      vmr9_Saturation = 3,
      vmr9_Alpha = 4
      } TVMR9ImageAdjustment;
      
      typedef enum TVuMeter
      {
      vu_Disabled = 0,
      vu_Analog = 1,
      vu_Bargraph = 2
      } TVuMeter;
      
      typedef enum TVUMeterSetting
      {
      vu_Handle = 0,
      vu_WarningPercent = 1,
      vu_PeakPercent = 2,
      vu_BkgndColor = 3,
      vu_NormalColor = 4,
      vu_WarningColor = 5,
      vu_PeakColor = 6,
      vu_TickSize = 7,
      vu_TickInterval = 8,
      vu_NeedleThickness = 9
      } TVUMeterSetting;
      
      typedef enum TWebcamStillCaptureButton
      {
      wb_Disabled = 0,
      wb_Enabled = 1
      } TWebcamStillCaptureButton;
      
//#endregion DeclareEnumeratedTypes

   typedef struct TFrameInfo
   {
            __int64 frameTime;
            __int64 frameTime_TotalMin;
            __int64 frameTime_TotalSec;
            __int64 frameTime_TotalHs;
            __int64 framenumber;
            int droppedframecount;
            int frametime_hour;
            int frametime_min;
            int frametime_sec;
            int frametime_hs;
            int dvtimecode_isavailable;
            int dvtimecode_hour;
            int dvtimecode_min;
            int dvtimecode_sec;
            int dvtimecode_ff;
            int dvtimecode_tracknumber;
            int dvdatetime_isavailable;
            int dvdatetime_year;
            int dvdatetime_month;
            int dvdatetime_day;
            int dvdatetime_hour;
            int dvdatetime_min;
            int dvdatetime_sec;
            TCurrentState CurrentState;
            TGraphState TGraphState;
            TPlayerState PlayerState;
            int reserved0;
            int reserved1;
   } TFrameInfo;

   typedef struct TFrameBitmapInfo
   {
            int bitmapWidth;
            int bitmapHeight;
            int bitmapBitsPerPixel;
            int bitmapLineSize;
            int bitmapSize;
            int bitmapPlanes;
            int bitmapHandle;
            int bitmapDataPtr;
            int bitmapDC;
            int CurrentXMouseLocation;
            int CurrentYMouseLocation;
            int LastXMouseDownLocation;
            int LastYMouseDownLocation;
            bool IsMouseDown;
            TMouseButton LastMouseButtonClicked;
            int reserved0;
   } TFrameBitmapInfo;

//#region DeclareCallbackType
      typedef void CALLBACK TOnAudioDeviceSelectedCb  ( int Object,  int Sender);
      typedef void CALLBACK TOnAudioPeakCb  ( int Object,  int Sender,  double Left_Percent,  double Left_DB,  double Right_Percent,  double Right_DB);
      typedef void CALLBACK TOnAuthenticationNeededCb  ( int Object,  int Sender,  TAuthenticationType AuthenticationType,  wchar_t *Realm,  wchar_t *Server,  wchar_t **Username,  wchar_t **Password);
      typedef void CALLBACK TOnAVIDurationUpdatedCb  ( int Object,  int Sender,  wchar_t *FileName,  unsigned int Frames,  double *FrameRate,  __int64 *Duration);
      typedef void CALLBACK TOnBacktimedFramesCountReachedCb  ( int Object,  int Sender);
      typedef void CALLBACK TOnBitmapsLoadingProgressCb  ( int Object,  int Sender,  int Percent,  __int64 Position,  __int64 Duration,  wchar_t *Comment);
      typedef void CALLBACK TOnClickCb  ( int Object,  int Sender);
      typedef void CALLBACK TOnClientConnectionCb  ( int Object,  int Sender,  BOOL Connected,  wchar_t *ClientInfo);
      typedef void CALLBACK TOnColorKeyChangeCb  ( int Object,  int Sender,  int ColorKey);
      typedef void CALLBACK TOnCopyPreallocDataCompletedCb  ( int Object,  int Sender,  wchar_t *SourceFile,  wchar_t *DestFile,  BOOL Success);
      typedef void CALLBACK TOnCopyPreallocDataProgressCb  ( int Object,  int Sender,  int Percent,  __int64 Position,  __int64 Duration);
      typedef void CALLBACK TOnCopyPreallocDataStartedCb  ( int Object,  int Sender,  wchar_t *SourceFile,  wchar_t *DestFile);
      typedef void CALLBACK TOnCreatePreallocFileCompletedCb  ( int Object,  int Sender,  wchar_t *FileName,  BOOL Success);
      typedef void CALLBACK TOnCreatePreallocFileProgressCb  ( int Object,  int Sender,  int Percent,  __int64 Position,  __int64 Duration);
      typedef void CALLBACK TOnCreatePreallocFileStartedCb  ( int Object,  int Sender,  wchar_t *FileName);
      typedef void CALLBACK TOnDblClickCb  ( int Object,  int Sender);
      typedef void CALLBACK TOnDeviceArrivalOrRemovalCb  ( int Object,  int Sender,  BOOL IsDeviceArrival,  BOOL IsVideoDevice,  wchar_t *DeviceName,  int DeviceIndex);
      typedef void CALLBACK TOnDeviceLostCb  ( int Object,  int Sender);
      typedef void CALLBACK TOnDirectNetworkStreamingHostUrlCb  ( int Object,  int Sender,  wchar_t *HostUrl,  wchar_t *HostName,  int HostPort);
      typedef void CALLBACK TOnDiskFullCb  ( int Object,  int Sender);
      typedef void CALLBACK TOnDragDropCb  ( int Object,  int Sender,  int Source,  int X,  int Y);
      typedef void CALLBACK TOnDragOverCb  ( int Object,  int Sender,  int Source,  int X,  int Y,  TDragAction State,  BOOL *Accept);
      typedef void CALLBACK TOnDVCommandCompletedCb  ( int Object,  int Sender,  int NewStateValue,  wchar_t *NewStateLabel);
      typedef void CALLBACK TOnDVDiscontinuityCb  ( int Object,  int Sender,  BOOL *DeliverNewFrame);
      typedef void CALLBACK TOnEnumerateWindowsCb  ( int Object,  int Sender,  int WindowHandle,  wchar_t *WindowName,  wchar_t *WindowClass);
      typedef void CALLBACK TOnFilterSelectedCb  ( int Object,  int Sender,  wchar_t *FilterName,  BOOL *RejectFilter);
      typedef void CALLBACK TOnFirstFrameReceivedCb  ( int Object,  int Sender);
      typedef void CALLBACK TOnFrameBitmapCb  ( int Object,  int Sender,  TFrameInfo *FrameInfo,  TFrameBitmapInfo *BitmapInfo);
      typedef void CALLBACK TOnFrameCaptureCompletedCb  ( int Object,  int Sender,  int FrameBitmapHandle,  int BitmapWidth,  int BitmapHeight,  unsigned int FrameNumber,  __int64 FrameTime,  TFrameCaptureDest DestType,  wchar_t *FileName,  BOOL Success,  int FrameId);
      typedef void CALLBACK TOnFrameOverlayUsingDCCb  ( int Object,  int Sender,  int Dc,  unsigned int FrameNumber,  __int64 FrameTime,  int FrameId);
      typedef void CALLBACK TOnFrameOverlayUsingDIBCb  ( int Object,  int Sender,  int FrameBitmapHandle,  unsigned int FrameNumber,  __int64 FrameTime,  int FrameId);
      typedef void CALLBACK TOnFrameProgressCb  ( int Object,  int Sender,  unsigned int FrameNumber,  __int64 FrameTime,  int FrameId);
      typedef void CALLBACK TOnFrameProgress2Cb  ( int Object,  int Sender,  TFrameInfo *FrameInfo);
      typedef void CALLBACK TOnGraphBuiltCb  ( int Object,  int Sender);
      typedef void CALLBACK TOnInactiveCb  ( int Object,  int Sender);
      typedef void CALLBACK TOnKeyPressCb  ( int Object,  int Sender,  int VideoWindow,  wchar_t **Key,  int PhysicalKey);
      typedef void CALLBACK TOnLastCommandCompletedCb  ( int Object,  int Sender);
      typedef void CALLBACK TOnLogCb  ( int Object,  int Sender,  TLogType LogType,  wchar_t *Severity,  wchar_t *InfoMsg);
      typedef void CALLBACK TOnMotionDetectedCb  ( int Object,  int Sender,  double GlobalMotionRatio,  int MaxMotionCellX,  int MaxMotionCellY,  int FrameBitmapHandle,  unsigned int FrameNumber,  __int64 FrameTime,  int FrameId,  BOOL *CaptureFrame);
      typedef void CALLBACK TOnMotionNotDetectedCb  ( int Object,  int Sender,  int FrameBitmapHandle,  unsigned int FrameNumber,  __int64 FrameTime,  int FrameId,  BOOL *CaptureFrame);
      typedef void CALLBACK TOnMouseDownCb  ( int Object,  int Sender,  int VideoWindow,  TMouseButton Button,  int X,  int Y);
      typedef void CALLBACK TOnMouseMoveCb  ( int Object,  int Sender,  int VideoWindow,  int X,  int Y);
      typedef void CALLBACK TOnMouseUpCb  ( int Object,  int Sender,  int VideoWindow,  TMouseButton Button,  int X,  int Y);
      typedef void CALLBACK TOnMouseWheelCb  ( int Object,  int Sender,  int VideoWindow,  BOOL DirectionUp,  int X,  int Y);
      typedef void CALLBACK TOnNoVideoDevicesCb  ( int Object,  int Sender);
      typedef void CALLBACK TOnPlayerBufferingDataCb  ( int Object,  int Sender,  BOOL StartingToBuffer);
      typedef void CALLBACK TOnPlayerEndOfPlaylistCb  ( int Object,  int Sender);
      typedef void CALLBACK TOnPlayerEndOfStreamCb  ( int Object,  int Sender);
      typedef void CALLBACK TOnPlayerOpenedCb  ( int Object,  int Sender);
      typedef void CALLBACK TOnPlayerStateChangedCb  ( int Object,  int Sender,  TPlayerState OldPlayerState,  TPlayerState NewPlayerState);
      typedef void CALLBACK TOnPlayerUpdateTrackbarPositionCb  ( int Object,  int Sender,  unsigned int FrameNumber,  __int64 FrameTime,  int FrameId);
      typedef void CALLBACK TOnPreviewStartedCb  ( int Object,  int Sender);
      typedef void CALLBACK TOnRawAudioSampleCb  ( int Object,  int Sender,  int pSampleBuffer,  int SampleBufferSize,  int SampleDataLength,  TFormatType FormatType,  int pFormat,  int pWaveFormatEx,  __int64 SampleStartTime,  __int64 SampleStopTime);
      typedef void CALLBACK TOnRawVideoSampleCb  ( int Object,  int Sender,  int pSampleBuffer,  int SampleBufferSize,  int SampleDataLength,  TFormatType FormatType,  int pFormat,  int pBitmapInfoHeader,  __int64 SampleStartTime,  __int64 SampleStopTime);
      typedef void CALLBACK TOnRecordingCompletedCb  ( int Object,  int Sender,  wchar_t *FileName,  BOOL Success);
      typedef void CALLBACK TOnRecordingPausedCb  ( int Object,  int Sender);
      typedef void CALLBACK TOnRecordingReadyToStartCb  ( int Object,  int Sender);
      typedef void CALLBACK TOnRecordingStartedCb  ( int Object,  int Sender,  wchar_t *FileName);
      typedef void CALLBACK TOnReencodingCompletedCb  ( int Object,  int Sender,  wchar_t *SourceFile,  wchar_t *DestFile,  BOOL Success);
      typedef void CALLBACK TOnReencodingProgressCb  ( int Object,  int Sender,  int Percent,  __int64 Position,  __int64 Duration);
      typedef void CALLBACK TOnReencodingStartedCb  ( int Object,  int Sender,  wchar_t *SourceFile,  wchar_t *DestFile);
      typedef void CALLBACK TOnReinitializingCb  ( int Object,  int Sender);
      typedef void CALLBACK TOnResizeVideoCb  ( int Object,  int Sender,  int SourceWidth,  int SourceHeight);
      typedef void CALLBACK TOnTextOverlayScrollingCompletedCb  ( int Object,  int Sender,  int TextOverlayIndex);
      typedef void CALLBACK TOnThirdPartyFilterConnectedCb  ( int Object,  int Sender,  TThirdPartyFilterList Location,  IUnknown*Intf);
      typedef void CALLBACK TOnTVChannelScanCompletedCb  ( int Object,  int Sender);
      typedef void CALLBACK TOnTVChannelScanStartedCb  ( int Object,  int Sender,  int MinChannel,  int MaxChannel);
      typedef void CALLBACK TOnTVChannelSelectedCb  ( int Object,  int Sender,  int Channel,  BOOL Locked,  int DefaultVideoFrequency,  int OverriddenVideoFrequency,  int TunerVideoFrequency,  int TunerAudioFrequency);
      typedef void CALLBACK TOnVideoCompressionSettingsCb  ( int Object,  int Sender,  BOOL CanKeyFrameRate,  BOOL CanPFramesPerKeyFrame,  BOOL CanQuality,  BOOL CanWindowSize,  BOOL CanSpecifyDataRate,  int DefaultFrameRate,  int DefaultPFramesPerKey,  double DefaultQuality,  int DefaultWindowSize,  int DefaultDataRate);
      typedef void CALLBACK TOnVideoDeviceSelectedCb  ( int Object,  int Sender);
      typedef void CALLBACK TOnVideoFromBitmapsNextFrameNeededCb  ( int Object,  int Sender,  BOOL FirstSample);
//#endregion DeclareCallbackType

//#region DeclareDLLImport
      #define DLLIMPORT __declspec(dllimport)
      #ifdef __cplusplus
         extern "C" {
      #endif
      DLLIMPORT void _stdcall _About ( int Sender);
      DLLIMPORT int _stdcall _AnalogVideoStandardIndex ( int Sender,  wchar_t * Value);
      DLLIMPORT wchar_t * _stdcall _ASFStreaming_GetAuthorizationList ( int Sender);
      DLLIMPORT wchar_t * _stdcall _ASFStreaming_GetConnectedClients ( int Sender);
      DLLIMPORT int _stdcall _ASFStreaming_GetConnectedClientsCount ( int Sender);
      DLLIMPORT BOOL _stdcall _ASFStreaming_ResetAuthorizations ( int Sender);
      DLLIMPORT BOOL _stdcall _ASFStreaming_SetAuthorization ( int Sender,  BOOL Allowed,  wchar_t * IP,  wchar_t * Mask);
      DLLIMPORT BOOL _stdcall _AssociateMultiplexedSlave ( int Sender,  int InputNumber,  int SlaveUniqueID);
      DLLIMPORT int _stdcall _AudioCompressorIndex ( int Sender,  wchar_t * Value);
      DLLIMPORT int _stdcall _AudioDeviceIndex ( int Sender,  wchar_t * Value);
      DLLIMPORT int _stdcall _AudioInputIndex ( int Sender,  wchar_t * Value);
      DLLIMPORT int _stdcall _AudioRendererIndex ( int Sender,  wchar_t * Value);
      DLLIMPORT BOOL _stdcall _AVIDuration ( int Sender,  wchar_t * AVIFile,  __int64* Duration,  __int64* FrameCount);
      DLLIMPORT wchar_t * _stdcall _AVIHeaderInfo ( int Sender,  wchar_t * AVIFile,  THeaderAttribute HeaderAttribute);
      DLLIMPORT BOOL _stdcall _AVIInfo ( int Sender,  wchar_t * AVIFile,  __int64* Duration,  __int64* FrameCount,  int* _VideoWidth,  int* _VideoHeight,  double* VideoFrameRateFps,  int* AvgBitRate,  int* AudioChannels,  int* AudioSamplesPerSec,  int* AudioBitsPerSample,  wchar_t ** VideoCodec,  wchar_t ** AudioCodec);
      DLLIMPORT wchar_t * _stdcall _AVIInfo2 ( int Sender,  wchar_t * AVIFile,  TAVIInfoType AVIInfoType);
      DLLIMPORT BOOL _stdcall _CameraControlAuto ( int Sender,  TCameraControl Setting);
      DLLIMPORT int _stdcall _CameraControlDefault ( int Sender,  TCameraControl Setting);
      DLLIMPORT int _stdcall _CameraControlMax ( int Sender,  TCameraControl Setting);
      DLLIMPORT int _stdcall _CameraControlMin ( int Sender,  TCameraControl Setting);
      DLLIMPORT int _stdcall _CameraControlStep ( int Sender,  TCameraControl Setting);
      DLLIMPORT int _stdcall _CameraControlValue ( int Sender,  TCameraControl Setting);
      DLLIMPORT BOOL _stdcall _Cancel ( int Sender);
      DLLIMPORT BOOL _stdcall _CanProcessMessages ( int Sender);
      DLLIMPORT BOOL _stdcall _CaptureFrameSyncTo ( int Sender,  TFrameCaptureDest Dest,  wchar_t * FileName);
      DLLIMPORT BOOL _stdcall _CaptureFrameTo ( int Sender,  TFrameCaptureDest Dest,  wchar_t * FileName);
      DLLIMPORT void _stdcall _ClearHeaderAttributes ( int Sender);
      DLLIMPORT void _stdcall _ClosePlayer ( int Sender);
      DLLIMPORT void _stdcall _ContinueProcessing ( int Sender);
      DLLIMPORT BOOL _stdcall _CreatePreallocCapFile ( int Sender);
      DLLIMPORT int _stdcall _CreateVideoGrabber ( int Sender);
      DLLIMPORT void _stdcall _DestroyVideoGrabber ( int Sender);
      DLLIMPORT void _stdcall _Display_SetLocation ( int Sender,  int WindowLeft,  int WindowTop,  int WindowWidth,  int WindowHeight);
      DLLIMPORT BOOL _stdcall _DrawBitmapOverFrame ( int Sender,  int BitmapHandle,  BOOL Stretched,  int LeftLocation,  int TopLocation,  int bmWidth,  int bmHeight,  BOOL Transparent,  BOOL UseTransparentColor,  int TransparentColorValue,  BOOL AlphaBlend,  int AlphaBlendValue,  BOOL ChromaKey,  int ChromaKeyRGBColor,  int ChromaKeyLeewayPercent);
      DLLIMPORT void _stdcall _DualDisplay_SetLocation ( int Sender,  int WindowLeft,  int WindowTop,  int WindowWidth,  int WindowHeight);
      DLLIMPORT double _stdcall _DVDInfo ( int Sender,  wchar_t * DVDRootDirectory,  TDVDInfoType DVDInfoType,  int TitleNumber);
      DLLIMPORT BOOL _stdcall _EnableMultiplexedInput ( int Sender,  int InputNumber,  BOOL Enable);
      DLLIMPORT BOOL _stdcall _EnumerateWindows ( int Sender);
      DLLIMPORT void _stdcall _FastForwardPlayer ( int Sender);
      DLLIMPORT int _stdcall _FindIndexInListByName ( int Sender,  wchar_t * List,  wchar_t * SearchedString,  BOOL IsSubString,  BOOL IgnoreCase);
      DLLIMPORT BOOL _stdcall _GetAdjustOverlayAspectRatio ( int Sender);
      DLLIMPORT BOOL _stdcall _GetAdjustPixelAspectRatio ( int Sender);
      DLLIMPORT TAero _stdcall _GetAero ( int Sender);
      DLLIMPORT int _stdcall _GetAnalogVideoStandard ( int Sender);
      DLLIMPORT wchar_t * _stdcall _GetAnalogVideoStandards ( int Sender);
      DLLIMPORT int _stdcall _GetAnalogVideoStandardsCount ( int Sender);
      DLLIMPORT TApplicationPriority _stdcall _GetApplicationPriority ( int Sender);
      DLLIMPORT int _stdcall _GetASFAudioBitRate ( int Sender);
      DLLIMPORT int _stdcall _GetASFAudioChannels ( int Sender);
      DLLIMPORT int _stdcall _GetASFBufferWindow ( int Sender);
      DLLIMPORT TASFDeinterlaceMode _stdcall _GetASFDeinterlaceMode ( int Sender);
      DLLIMPORT BOOL _stdcall _GetASFFixedFrameRate ( int Sender);
      DLLIMPORT wchar_t * _stdcall _GetASFMediaServerPublishingPoint ( int Sender);
      DLLIMPORT BOOL _stdcall _GetASFMediaServerRemovePublishingPointAfterDisconnect ( int Sender);
      DLLIMPORT wchar_t * _stdcall _GetASFMediaServerTemplatePublishingPoint ( int Sender);
      DLLIMPORT int _stdcall _GetASFNetworkMaxUsers ( int Sender);
      DLLIMPORT int _stdcall _GetASFNetworkPort ( int Sender);
      DLLIMPORT int _stdcall _GetASFProfile ( int Sender);
      DLLIMPORT wchar_t * _stdcall _GetASFProfileFromCustomFile ( int Sender);
      DLLIMPORT wchar_t * _stdcall _GetASFProfiles ( int Sender);
      DLLIMPORT int _stdcall _GetASFProfilesCount ( int Sender);
      DLLIMPORT TASFProfileVersion _stdcall _GetASFProfileVersion ( int Sender);
      DLLIMPORT int _stdcall _GetASFVideoBitRate ( int Sender);
      DLLIMPORT double _stdcall _GetASFVideoFrameRate ( int Sender);
      DLLIMPORT int _stdcall _GetASFVideoHeight ( int Sender);
      DLLIMPORT int _stdcall _GetASFVideoMaxKeyFrameSpacing ( int Sender);
      DLLIMPORT int _stdcall _GetASFVideoQuality ( int Sender);
      DLLIMPORT int _stdcall _GetASFVideoWidth ( int Sender);
      DLLIMPORT double _stdcall _GetAspectRatioToUse ( int Sender);
      DLLIMPORT BOOL _stdcall _GetAssociateAudioAndVideoDevices ( int Sender);
      DLLIMPORT int _stdcall _GetAudioBalance ( int Sender);
      DLLIMPORT TAudioChannelRenderMode _stdcall _GetAudioChannelRenderMode ( int Sender);
      DLLIMPORT wchar_t * _stdcall _GetAudioCodec ( int Sender);
      DLLIMPORT int _stdcall _GetAudioCompressor ( int Sender);
      DLLIMPORT wchar_t * _stdcall _GetAudioCompressorName ( int Sender);
      DLLIMPORT wchar_t * _stdcall _GetAudioCompressors ( int Sender);
      DLLIMPORT int _stdcall _GetAudioCompressorsCount ( int Sender);
      DLLIMPORT int _stdcall _GetAudioDevice ( int Sender);
      DLLIMPORT wchar_t * _stdcall _GetAudioDeviceName ( int Sender);
      DLLIMPORT BOOL _stdcall _GetAudioDeviceRendering ( int Sender);
      DLLIMPORT wchar_t * _stdcall _GetAudioDevices ( int Sender);
      DLLIMPORT int _stdcall _GetAudioDevicesCount ( int Sender);
      DLLIMPORT TAudioFormat _stdcall _GetAudioFormat ( int Sender);
      DLLIMPORT wchar_t * _stdcall _GetAudioFormats ( int Sender);
      DLLIMPORT int _stdcall _GetAudioInput ( int Sender);
      DLLIMPORT int _stdcall _GetAudioInputBalance ( int Sender);
      DLLIMPORT int _stdcall _GetAudioInputLevel ( int Sender);
      DLLIMPORT BOOL _stdcall _GetAudioInputMono ( int Sender);
      DLLIMPORT wchar_t * _stdcall _GetAudioInputs ( int Sender);
      DLLIMPORT int _stdcall _GetAudioInputsCount ( int Sender);
      DLLIMPORT BOOL _stdcall _GetAudioPeakEvent ( int Sender);
      DLLIMPORT BOOL _stdcall _GetAudioRecording ( int Sender);
      DLLIMPORT int _stdcall _GetAudioRenderer ( int Sender);
      DLLIMPORT wchar_t * _stdcall _GetAudioRendererName ( int Sender);
      DLLIMPORT wchar_t * _stdcall _GetAudioRenderers ( int Sender);
      DLLIMPORT int _stdcall _GetAudioRenderersCount ( int Sender);
      DLLIMPORT TAudioSource _stdcall _GetAudioSource ( int Sender);
      DLLIMPORT int _stdcall _GetAudioStreamNumber ( int Sender);
      DLLIMPORT int _stdcall _GetAudioSyncAdjustment ( int Sender);
      DLLIMPORT BOOL _stdcall _GetAudioSyncAdjustmentEnabled ( int Sender);
      DLLIMPORT int _stdcall _GetAudioVolume ( int Sender);
      DLLIMPORT BOOL _stdcall _GetAutoConnectRelatedPins ( int Sender);
      DLLIMPORT TAutoFileName _stdcall _GetAutoFileName ( int Sender);
      DLLIMPORT int _stdcall _GetAutoFileNameMinDigits ( int Sender);
      DLLIMPORT wchar_t * _stdcall _GetAutoFilePrefix ( int Sender);
      DLLIMPORT BOOL _stdcall _GetAutoRefreshPreview ( int Sender);
      DLLIMPORT BOOL _stdcall _GetAutoStartPlayer ( int Sender);
      DLLIMPORT BOOL _stdcall _GetAVIDurationUpdated ( int Sender);
      DLLIMPORT BOOL _stdcall _GetAVIFormatOpenDML ( int Sender);
      DLLIMPORT BOOL _stdcall _GetAVIFormatOpenDMLCompatibilityIndex ( int Sender);
      DLLIMPORT int _stdcall _GetBackgroundColor ( int Sender);
      DLLIMPORT int _stdcall _GetBufferCount ( int Sender);
      DLLIMPORT int _stdcall _GetBurstCount ( int Sender);
      DLLIMPORT int _stdcall _GetBurstInterval ( int Sender);
      DLLIMPORT BOOL _stdcall _GetBurstMode ( int Sender);
      DLLIMPORT TFrameCaptureDest _stdcall _GetBurstType ( int Sender);
      DLLIMPORT BOOL _stdcall _GetBusy ( int Sender);
      DLLIMPORT TCursors _stdcall _GetBusyCursor ( int Sender);
      DLLIMPORT BOOL _stdcall _GetCameraControlSettings ( int Sender);
      DLLIMPORT wchar_t * _stdcall _GetCaptureFileExt ( int Sender);
      DLLIMPORT int _stdcall _GetColorKey ( int Sender);
      DLLIMPORT BOOL _stdcall _GetColorKeyEnabled ( int Sender);
      DLLIMPORT TCompressionMode _stdcall _GetCompressionMode ( int Sender);
      DLLIMPORT TCompressionType _stdcall _GetCompressionType ( int Sender);
      DLLIMPORT BOOL _stdcall _GetCropping_Enabled ( int Sender);
      DLLIMPORT int _stdcall _GetCropping_Height ( int Sender);
      DLLIMPORT BOOL _stdcall _GetCropping_Outbounds ( int Sender);
      DLLIMPORT int _stdcall _GetCropping_Width ( int Sender);
      DLLIMPORT int _stdcall _GetCropping_X ( int Sender);
      DLLIMPORT int _stdcall _GetCropping_XMax ( int Sender);
      DLLIMPORT int _stdcall _GetCropping_Y ( int Sender);
      DLLIMPORT int _stdcall _GetCropping_YMax ( int Sender);
      DLLIMPORT double _stdcall _GetCropping_Zoom ( int Sender);
      DLLIMPORT double _stdcall _GetCurrentFrameRate ( int Sender);
      DLLIMPORT TCurrentState _stdcall _GetCurrentState ( int Sender);
      DLLIMPORT __int64 _stdcall _GetDeliveredFrames ( int Sender);
      DLLIMPORT wchar_t * _stdcall _GetDirectShowFilters ( int Sender);
      DLLIMPORT int _stdcall _GetDirectShowFiltersCount ( int Sender);
      DLLIMPORT int _stdcall _GetDisplay_VideoHeight ( int Sender);
      DLLIMPORT int _stdcall _GetDisplay_VideoWidth ( int Sender);
      DLLIMPORT int _stdcall _GetDisplay_VideoWindowHandle ( int Sender);
      DLLIMPORT BOOL _stdcall _GetDisplay2BoolProperties ( int Sender,  int Index);
      DLLIMPORT int _stdcall _GetDisplay2LongProperties ( int Sender,  int Index);
      DLLIMPORT TAspectRatio _stdcall _GetDisplayAspectRatio ( int Sender,  int Index);
      DLLIMPORT BOOL _stdcall _GetDisplayBoolProperties ( int Sender,  int Index);
      DLLIMPORT int _stdcall _GetDisplayLongProperties ( int Sender,  int Index);
      DLLIMPORT int _stdcall _GetDroppedFrameCount ( int Sender);
      DLLIMPORT int _stdcall _GetDroppedFramesPollingInterval ( int Sender);
      DLLIMPORT int _stdcall _GetDualDisplay_VideoHeight ( int Sender);
      DLLIMPORT int _stdcall _GetDualDisplay_VideoWidth ( int Sender);
      DLLIMPORT int _stdcall _GetDualDisplay_VideoWindowHandle ( int Sender);
      DLLIMPORT BOOL _stdcall _GetDVDateTimeEnabled ( int Sender);
      DLLIMPORT int _stdcall _GetDVDiscontinuityMinimumInterval ( int Sender);
      DLLIMPORT int _stdcall _GetDVDTitle ( int Sender);
      DLLIMPORT TDVVideoFormat _stdcall _GetDVEncoder_VideoFormat ( int Sender);
      DLLIMPORT TDVSize _stdcall _GetDVEncoder_VideoResolution ( int Sender);
      DLLIMPORT TDVVideoStandard _stdcall _GetDVEncoder_VideoStandard ( int Sender);
      DLLIMPORT BOOL _stdcall _GetDVRecordingInNativeFormatSeparatesStreams ( int Sender);
      DLLIMPORT BOOL _stdcall _GetDVReduceFrameRate ( int Sender);
      DLLIMPORT BOOL _stdcall _GetDVRgb219 ( int Sender);
      DLLIMPORT BOOL _stdcall _GetDVTimeCodeEnabled ( int Sender);
      DLLIMPORT BOOL _stdcall _GetEventNotificationSynchrone ( int Sender);
      DLLIMPORT BOOL _stdcall _GetFixFlickerOrBlackCapture ( int Sender);
      DLLIMPORT int _stdcall _GetFrameCaptureHeight ( int Sender);
      DLLIMPORT int _stdcall _GetFrameCaptureWidth ( int Sender);
      DLLIMPORT BOOL _stdcall _GetFrameCaptureWithoutOverlay ( int Sender);
      DLLIMPORT int _stdcall _GetFrameCaptureZoomSize ( int Sender);
      DLLIMPORT TFrameGrabber _stdcall _GetFrameGrabber ( int Sender);
      DLLIMPORT TFrameGrabberRGBFormat _stdcall _GetFrameGrabberCurrentRGBFormat ( int Sender);
      DLLIMPORT TFrameGrabberRGBFormat _stdcall _GetFrameGrabberRGBFormat ( int Sender);
      DLLIMPORT int _stdcall _GetFrameInfo ( int Sender,  int FrameId,  TFrameInfoId FrameInfoId);
      DLLIMPORT wchar_t * _stdcall _GetFrameInfoString ( int Sender,  TFrameInfoStringId FrameInfoStringId);
      DLLIMPORT BOOL _stdcall _GetFrameNumberStartsFromZero ( int Sender);
      DLLIMPORT double _stdcall _GetFrameRate ( int Sender);
      DLLIMPORT BOOL _stdcall _GetHoldRecording ( int Sender);
      DLLIMPORT BOOL _stdcall _GetImageOverlay_AlphaBlend ( int Sender);
      DLLIMPORT int _stdcall _GetImageOverlay_AlphaBlendValue ( int Sender);
      DLLIMPORT BOOL _stdcall _GetImageOverlay_ChromaKey ( int Sender);
      DLLIMPORT int _stdcall _GetImageOverlay_ChromaKeyLeewayPercent ( int Sender);
      DLLIMPORT int _stdcall _GetImageOverlay_ChromaKeyRGBColor ( int Sender);
      DLLIMPORT int _stdcall _GetImageOverlay_Height ( int Sender);
      DLLIMPORT int _stdcall _GetImageOverlay_LeftLocation ( int Sender);
      DLLIMPORT double _stdcall _GetImageOverlay_RotationAngle ( int Sender);
      DLLIMPORT BOOL _stdcall _GetImageOverlay_StretchToVideoSize ( int Sender);
      DLLIMPORT int _stdcall _GetImageOverlay_TopLocation ( int Sender);
      DLLIMPORT BOOL _stdcall _GetImageOverlay_Transparent ( int Sender);
      DLLIMPORT int _stdcall _GetImageOverlay_TransparentColorValue ( int Sender);
      DLLIMPORT BOOL _stdcall _GetImageOverlay_UseTransparentColor ( int Sender);
      DLLIMPORT int _stdcall _GetImageOverlay_Width ( int Sender);
      DLLIMPORT BOOL _stdcall _GetImageOverlayEnabled ( int Sender);
      DLLIMPORT int _stdcall _GetImageOverlaySelector ( int Sender);
      DLLIMPORT double _stdcall _GetImageRatio ( int Sender);
      DLLIMPORT BOOL _stdcall _GetInFrameProgressEvent ( int Sender);
      DLLIMPORT wchar_t * _stdcall _GetIPCameraURL ( int Sender);
      DLLIMPORT BOOL _stdcall _GetIsAnalogVideoDecoderAvailable ( int Sender);
      DLLIMPORT BOOL _stdcall _GetIsAudioCrossbarAvailable ( int Sender);
      DLLIMPORT TTriState _stdcall _GetIsAudioInputBalanceAvailable ( int Sender);
      DLLIMPORT BOOL _stdcall _GetIsCameraControlAvailable ( int Sender);
      DLLIMPORT BOOL _stdcall _GetIsDigitalVideoIn ( int Sender);
      DLLIMPORT BOOL _stdcall _GetIsDVCommandAvailable ( int Sender);
      DLLIMPORT BOOL _stdcall _GetIsHorizontalSyncLocked ( int Sender);
      DLLIMPORT BOOL _stdcall _GetIsMpegStream ( int Sender);
      DLLIMPORT TTriState _stdcall _GetIsPlayerAudioStreamAvailable ( int Sender);
      DLLIMPORT TTriState _stdcall _GetIsPlayerVideoStreamAvailable ( int Sender);
      DLLIMPORT BOOL _stdcall _GetIsRecordingPaused ( int Sender);
      DLLIMPORT BOOL _stdcall _GetIsTVAudioAvailable ( int Sender);
      DLLIMPORT BOOL _stdcall _GetIsTVAutoTuneRunning ( int Sender);
      DLLIMPORT BOOL _stdcall _GetIsTVTunerAvailable ( int Sender);
      DLLIMPORT BOOL _stdcall _GetIsVideoControlAvailable ( int Sender);
      DLLIMPORT BOOL _stdcall _GetIsVideoCrossbarAvailable ( int Sender);
      DLLIMPORT BOOL _stdcall _GetIsVideoInterlaced ( int Sender);
      DLLIMPORT BOOL _stdcall _GetIsVideoPortAvailable ( int Sender);
      DLLIMPORT BOOL _stdcall _GetIsVideoQualityAvailable ( int Sender);
      DLLIMPORT BOOL _stdcall _GetIsWDMVideoDriver ( int Sender);
      DLLIMPORT wchar_t * _stdcall _GetItemNameFromList ( int Sender,  wchar_t * List,  int ItemIndex);
      DLLIMPORT TJPEGPerformance _stdcall _GetJPEGPerformance ( int Sender);
      DLLIMPORT BOOL _stdcall _GetJPEGProgressiveDisplay ( int Sender);
      DLLIMPORT int _stdcall _GetJPEGQuality ( int Sender);
      DLLIMPORT wchar_t * _stdcall _GetLast_BurstFrameCapture_FileName ( int Sender);
      DLLIMPORT wchar_t * _stdcall _GetLast_CaptureFrameTo_FileName ( int Sender);
      DLLIMPORT wchar_t * _stdcall _GetLast_Clip_Played ( int Sender);
      DLLIMPORT wchar_t * _stdcall _GetLast_Recording_FileName ( int Sender);
      DLLIMPORT int _stdcall _GetLastFrameAsHBITMAP ( int Sender,  int BufferIndex,  BOOL WithOverlays,  int SrcLeftLocation,  int SrcTopLocation,  int SrcWidth,  int SrcHeight,  int DestWidth,  int DestHeight,  int BitmapColorBitCount);
      DLLIMPORT wchar_t * _stdcall _GetLicenseString ( int Sender);
      DLLIMPORT BOOL _stdcall _GetLogoDisplayed ( int Sender);
      DLLIMPORT TLogoLayout _stdcall _GetLogoLayout ( int Sender);
      DLLIMPORT wchar_t * _stdcall _GetLogString ( int Sender,  TLogType Value);
      DLLIMPORT int _stdcall _GetMiscDeviceControl ( int Sender,  TMiscDeviceControl MiscDeviceControl,  int Index);
      DLLIMPORT int _stdcall _GetMixAudioSamplesLevel ( int Sender,  int Index);
      DLLIMPORT int _stdcall _GetMixer_MosaicColumns ( int Sender);
      DLLIMPORT int _stdcall _GetMixer_MosaicLines ( int Sender);
      DLLIMPORT BOOL _stdcall _GetMotionDetector_CompareBlue ( int Sender);
      DLLIMPORT BOOL _stdcall _GetMotionDetector_CompareGreen ( int Sender);
      DLLIMPORT BOOL _stdcall _GetMotionDetector_CompareRed ( int Sender);
      DLLIMPORT BOOL _stdcall _GetMotionDetector_Enabled ( int Sender);
      DLLIMPORT double _stdcall _GetMotionDetector_GlobalMotionRatio ( int Sender);
      DLLIMPORT BOOL _stdcall _GetMotionDetector_GreyScale ( int Sender);
      DLLIMPORT wchar_t * _stdcall _GetMotionDetector_Grid ( int Sender);
      DLLIMPORT int _stdcall _GetMotionDetector_GridXCount ( int Sender);
      DLLIMPORT int _stdcall _GetMotionDetector_GridYCount ( int Sender);
      DLLIMPORT BOOL _stdcall _GetMotionDetector_IsGridValid ( int Sender);
      DLLIMPORT double _stdcall _GetMotionDetector_MaxDetectionsPerSecond ( int Sender);
      DLLIMPORT int _stdcall _GetMotionDetector_ReduceCPULoad ( int Sender);
      DLLIMPORT BOOL _stdcall _GetMotionDetector_ReduceVideoNoise ( int Sender);
      DLLIMPORT BOOL _stdcall _GetMotionDetector_Triggered ( int Sender);
      DLLIMPORT BOOL _stdcall _GetMouseWheelEventEnabled ( int Sender);
      DLLIMPORT TMpegStreamType _stdcall _GetMpegStreamType ( int Sender);
      DLLIMPORT BOOL _stdcall _GetMultiplexedInputEmulation ( int Sender);
      DLLIMPORT TMultiplexedRole _stdcall _GetMultiplexedRole ( int Sender);
      DLLIMPORT int _stdcall _GetMultiplexedStabilizationDelay ( int Sender);
      DLLIMPORT int _stdcall _GetMultiplexedSwitchDelay ( int Sender);
      DLLIMPORT int _stdcall _GetMultiplexer ( int Sender);
      DLLIMPORT wchar_t * _stdcall _GetMultiplexerName ( int Sender);
      DLLIMPORT wchar_t * _stdcall _GetMultiplexers ( int Sender);
      DLLIMPORT int _stdcall _GetMultiplexersCount ( int Sender);
      DLLIMPORT BOOL _stdcall _GetMuteAudioRendering ( int Sender);
      DLLIMPORT int _stdcall _GetNearestVideoHeight ( int Sender,  int PreferredVideoWidth,  int PreferredVideoHeight);
      DLLIMPORT void _stdcall _GetNearestVideoSize ( int Sender,  int PreferredVideoWidth,  int PreferredVideoHeight,  int* NearestVideoWidth,  int* NearestVideoHeight);
      DLLIMPORT int _stdcall _GetNearestVideoWidth ( int Sender,  int PreferredVideoWidth,  int PreferredVideoHeight);
      DLLIMPORT TNetworkStreaming _stdcall _GetNetworkStreaming ( int Sender);
      DLLIMPORT TNetworkStreamingType _stdcall _GetNetworkStreamingType ( int Sender);
      DLLIMPORT TCursors _stdcall _GetNormalCursor ( int Sender);
      DLLIMPORT TNotificationMethod _stdcall _GetNotificationMethod ( int Sender);
      DLLIMPORT TThreadPriority _stdcall _GetNotificationPriority ( int Sender);
      DLLIMPORT int _stdcall _GetNotificationSleepTime ( int Sender);
      DLLIMPORT BOOL _stdcall _GetOverlayAfterTransform ( int Sender);
      DLLIMPORT double _stdcall _GetPixelsDistance ( int Sender,  int x1,  int y1,  int x2,  int y2);
      DLLIMPORT BOOL _stdcall _GetPlayerAudioRendering ( int Sender);
      DLLIMPORT __int64 _stdcall _GetPlayerDuration ( int Sender);
      DLLIMPORT TDVSize _stdcall _GetPlayerDVSize ( int Sender);
      DLLIMPORT int _stdcall _GetPlayerFastSeekSpeedRatio ( int Sender);
      DLLIMPORT wchar_t * _stdcall _GetPlayerFileName ( int Sender);
      DLLIMPORT wchar_t * _stdcall _GetPlayerForcedCodec ( int Sender);
      DLLIMPORT __int64 _stdcall _GetPlayerFrameCount ( int Sender);
      DLLIMPORT __int64 _stdcall _GetPlayerFramePosition ( int Sender);
      DLLIMPORT double _stdcall _GetPlayerFrameRate ( int Sender);
      DLLIMPORT int _stdcall _GetPlayerOpenProgressPercent ( int Sender);
      DLLIMPORT BOOL _stdcall _GetPlayerRefreshPausedDisplay ( int Sender);
      DLLIMPORT double _stdcall _GetPlayerRefreshPausedDisplayFrameRate ( int Sender);
      DLLIMPORT double _stdcall _GetPlayerSpeedRatio ( int Sender);
      DLLIMPORT TPlayerState _stdcall _GetPlayerState ( int Sender);
      DLLIMPORT __int64 _stdcall _GetPlayerTimePosition ( int Sender);
      DLLIMPORT BOOL _stdcall _GetPlayerTrackBarSynchrone ( int Sender);
      DLLIMPORT wchar_t * _stdcall _GetPlaylist ( int Sender);
      DLLIMPORT int _stdcall _GetPlaylistIndex ( int Sender);
      DLLIMPORT BOOL _stdcall _GetPreallocCapFileCopiedAfterRecording ( int Sender);
      DLLIMPORT BOOL _stdcall _GetPreallocCapFileEnabled ( int Sender);
      DLLIMPORT wchar_t * _stdcall _GetPreallocCapFileName ( int Sender);
      DLLIMPORT int _stdcall _GetPreallocCapFileSizeInMB ( int Sender);
      DLLIMPORT int _stdcall _GetPreviewZoomSize ( int Sender);
      DLLIMPORT BOOL _stdcall _GetQuickDeviceInitialization ( int Sender);
      DLLIMPORT BOOL _stdcall _GetRawAudioSampleCapture ( int Sender);
      DLLIMPORT BOOL _stdcall _GetRawCaptureAsyncEvent ( int Sender);
      DLLIMPORT TRawSampleCaptureLocation _stdcall _GetRawSampleCaptureLocation ( int Sender);
      DLLIMPORT BOOL _stdcall _GetRawVideoSampleCapture ( int Sender);
      DLLIMPORT int _stdcall _GetRecordingAudioBitRate ( int Sender);
      DLLIMPORT int _stdcall _GetRecordingBacktimedFramesCount ( int Sender);
      DLLIMPORT BOOL _stdcall _GetRecordingCanPause ( int Sender);
      DLLIMPORT double _stdcall _GetRecordingDuration ( int Sender);
      DLLIMPORT wchar_t * _stdcall _GetRecordingFileName ( int Sender);
      DLLIMPORT wchar_t * _stdcall _GetRecordingFourCC ( int Sender);
      DLLIMPORT int _stdcall _GetRecordingHeight ( int Sender);
      DLLIMPORT BOOL _stdcall _GetRecordingInNativeFormat ( int Sender);
      DLLIMPORT TRecordingMethod _stdcall _GetRecordingMethod ( int Sender);
      DLLIMPORT BOOL _stdcall _GetRecordingOnMotion_Enabled ( int Sender);
      DLLIMPORT double _stdcall _GetRecordingOnMotion_MotionThreshold ( int Sender);
      DLLIMPORT int _stdcall _GetRecordingOnMotion_NoMotionPauseDelayMs ( int Sender);
      DLLIMPORT BOOL _stdcall _GetRecordingPauseCreatesNewFile ( int Sender);
      DLLIMPORT TRecordingSize _stdcall _GetRecordingSize ( int Sender);
      DLLIMPORT TRecordingTimer _stdcall _GetRecordingTimer ( int Sender);
      DLLIMPORT int _stdcall _GetRecordingTimerInterval ( int Sender);
      DLLIMPORT int _stdcall _GetRecordingVideoBitRate ( int Sender);
      DLLIMPORT int _stdcall _GetRecordingWidth ( int Sender);
      DLLIMPORT BOOL _stdcall _GetReencodingIncludeAudioStream ( int Sender);
      DLLIMPORT BOOL _stdcall _GetReencodingIncludeVideoStream ( int Sender);
      DLLIMPORT TRecordingMethod _stdcall _GetReencodingMethod ( int Sender);
      DLLIMPORT wchar_t * _stdcall _GetReencodingNewVideoClip ( int Sender);
      DLLIMPORT wchar_t * _stdcall _GetReencodingSourceVideoClip ( int Sender);
      DLLIMPORT __int64 _stdcall _GetReencodingStartFrame ( int Sender);
      DLLIMPORT __int64 _stdcall _GetReencodingStartTime ( int Sender);
      DLLIMPORT __int64 _stdcall _GetReencodingStopFrame ( int Sender);
      DLLIMPORT __int64 _stdcall _GetReencodingStopTime ( int Sender);
      DLLIMPORT BOOL _stdcall _GetReencodingUseAudioCompressor ( int Sender);
      DLLIMPORT BOOL _stdcall _GetReencodingUseFrameGrabber ( int Sender);
      DLLIMPORT BOOL _stdcall _GetReencodingUseVideoCompressor ( int Sender);
      DLLIMPORT BOOL _stdcall _GetReencodingWMVOutput ( int Sender);
      DLLIMPORT int _stdcall _GetRGBPixelAt ( int Sender,  int x,  int y);
      DLLIMPORT BOOL _stdcall _GetScreenRecordingLayeredWindows ( int Sender);
      DLLIMPORT int _stdcall _GetScreenRecordingMonitor ( int Sender);
      DLLIMPORT BOOL _stdcall _GetScreenRecordingNonVisibleWindows ( int Sender);
      DLLIMPORT BOOL _stdcall _GetScreenRecordingThroughClipboard ( int Sender);
      DLLIMPORT BOOL _stdcall _GetScreenRecordingWithCursor ( int Sender);
      DLLIMPORT int _stdcall _GetSendToDV_DeviceIndex ( int Sender);
      DLLIMPORT int _stdcall _GetSpeakerBalance ( int Sender);
      DLLIMPORT BOOL _stdcall _GetSpeakerControl ( int Sender);
      DLLIMPORT int _stdcall _GetSpeakerVolume ( int Sender);
      DLLIMPORT wchar_t * _stdcall _GetStoragePath ( int Sender);
      DLLIMPORT BOOL _stdcall _GetStoreDeviceSettingsInRegistry ( int Sender);
      DLLIMPORT wchar_t * _stdcall _GetStreamingURL ( int Sender);
      DLLIMPORT BOOL _stdcall _GetSyncCommands ( int Sender);
      DLLIMPORT TSynchronizationRole _stdcall _GetSynchronizationRole ( int Sender);
      DLLIMPORT BOOL _stdcall _GetSynchronized ( int Sender);
      DLLIMPORT TSyncPreview _stdcall _GetSyncPreview ( int Sender);
      DLLIMPORT wchar_t * _stdcall _GetSystemTempPath ( int Sender);
      DLLIMPORT int _stdcall _GetTextOverlay_Font ( int Sender);
      DLLIMPORT TTextOverlayAlign _stdcall _GetTextOverlayAlign ( int Sender);
      DLLIMPORT int _stdcall _GetTextOverlayBkColor ( int Sender);
      DLLIMPORT BOOL _stdcall _GetTextOverlayEnabled ( int Sender);
      DLLIMPORT int _stdcall _GetTextOverlayFontColor ( int Sender);
      DLLIMPORT int _stdcall _GetTextOverlayLeft ( int Sender);
      DLLIMPORT int _stdcall _GetTextOverlayRight ( int Sender);
      DLLIMPORT BOOL _stdcall _GetTextOverlayScrolling ( int Sender);
      DLLIMPORT int _stdcall _GetTextOverlayScrollingSpeed ( int Sender);
      DLLIMPORT int _stdcall _GetTextOverlaySelector ( int Sender);
      DLLIMPORT BOOL _stdcall _GetTextOverlayShadow ( int Sender);
      DLLIMPORT int _stdcall _GetTextOverlayShadowColor ( int Sender);
      DLLIMPORT TCardinalDirection _stdcall _GetTextOverlayShadowDirection ( int Sender);
      DLLIMPORT wchar_t * _stdcall _GetTextOverlayString ( int Sender);
      DLLIMPORT int _stdcall _GetTextOverlayTop ( int Sender);
      DLLIMPORT BOOL _stdcall _GetTextOverlayTransparent ( int Sender);
      DLLIMPORT wchar_t * _stdcall _GetThirdPartyDeinterlacer ( int Sender);
      DLLIMPORT BOOL _stdcall _GetTimeCodeReaderAvailable ( int Sender);
      DLLIMPORT BOOL _stdcall _GetTranslatedCoordinates ( int Sender,  int DisplayIndex,  int NativeX,  int NativeY,  int* TranslatedX,  int* TranslatedY);
      DLLIMPORT BOOL _stdcall _GetTranslateMouseCoordinates ( int Sender);
      DLLIMPORT int _stdcall _GetTunerFrequency ( int Sender);
      DLLIMPORT TTunerMode _stdcall _GetTunerMode ( int Sender);
      DLLIMPORT int _stdcall _GetTVChannel ( int Sender);
      DLLIMPORT int _stdcall _GeTTVChannelInfo ( int Sender,  TTVChannelInfo Value);
      DLLIMPORT int _stdcall _GetTVCountryCode ( int Sender);
      DLLIMPORT TTunerInputType _stdcall _GetTVTunerInputType ( int Sender);
      DLLIMPORT BOOL _stdcall _GetTVUseFrequencyOverrides ( int Sender);
      DLLIMPORT int _stdcall _GetUniqueID ( int Sender);
      DLLIMPORT BOOL _stdcall _GetUseClock ( int Sender);
      DLLIMPORT BOOL _stdcall _GetVCRHorizontalLocking ( int Sender);
      DLLIMPORT wchar_t * _stdcall _GetVersion ( int Sender);
      DLLIMPORT wchar_t * _stdcall _GetVideoCodec ( int Sender);
      DLLIMPORT int _stdcall _GetVideoCompression_DataRate ( int Sender);
      DLLIMPORT int _stdcall _GetVideoCompression_KeyFrameRate ( int Sender);
      DLLIMPORT int _stdcall _GetVideoCompression_PFramesPerKeyFrame ( int Sender);
      DLLIMPORT double _stdcall _GetVideoCompression_Quality ( int Sender);
      DLLIMPORT int _stdcall _GetVideoCompression_WindowSize ( int Sender);
      DLLIMPORT BOOL _stdcall _GetVideoCompressionSettings ( int Sender,  int* DataRate,  int* KeyFrameRate,  int* PFramesPerKeyFrame,  int* WindowSize,  double* Quality,  BOOL* CanQuality,  BOOL* CanCrunch,  BOOL* CanKeyFrame,  BOOL* CanBFrame,  BOOL* CanWindow);
      DLLIMPORT int _stdcall _GetVideoCompressor ( int Sender);
      DLLIMPORT wchar_t * _stdcall _GetVideoCompressorName ( int Sender);
      DLLIMPORT wchar_t * _stdcall _GetVideoCompressors ( int Sender);
      DLLIMPORT int _stdcall _GetVideoCompressorsCount ( int Sender);
      DLLIMPORT BOOL _stdcall _GetVideoControlSettings ( int Sender);
      DLLIMPORT TCursors _stdcall _GetVideoCursor ( int Sender);
      DLLIMPORT int _stdcall _GetVideoDevice ( int Sender);
      DLLIMPORT wchar_t * _stdcall _GetVideoDeviceName ( int Sender);
      DLLIMPORT wchar_t * _stdcall _GetVideoDevices ( int Sender);
      DLLIMPORT int _stdcall _GetVideoDevicesCount ( int Sender);
      DLLIMPORT wchar_t * _stdcall _GetVideoDevicesId ( int Sender);
      DLLIMPORT BOOL _stdcall _GetVideoDoubleBuffered ( int Sender);
      DLLIMPORT int _stdcall _GetVideoFormat ( int Sender);
      DLLIMPORT wchar_t * _stdcall _GetVideoFormats ( int Sender);
      DLLIMPORT int _stdcall _GetVideoFormatsCount ( int Sender);
      DLLIMPORT TFileSort _stdcall _GetVideoFromImages_BitmapsSortedBy ( int Sender);
      DLLIMPORT BOOL _stdcall _GetVideoFromImages_RepeatIndefinitely ( int Sender);
      DLLIMPORT wchar_t * _stdcall _GetVideoFromImages_SourceDirectory ( int Sender);
      DLLIMPORT wchar_t * _stdcall _GetVideoFromImages_TemporaryFile ( int Sender);
      DLLIMPORT int _stdcall _GetVideoHeight ( int Sender);
      DLLIMPORT int _stdcall _GetVideoHeight_PreferredAspectRatio ( int Sender);
      DLLIMPORT int _stdcall _GetVideoHeightFromIndex ( int Sender,  int Index);
      DLLIMPORT int _stdcall _GetVideoInput ( int Sender);
      DLLIMPORT wchar_t * _stdcall _GetVideoInputs ( int Sender);
      DLLIMPORT int _stdcall _GetVideoInputsCount ( int Sender);
      DLLIMPORT int _stdcall _GetVideoProcessingBrightness ( int Sender);
      DLLIMPORT int _stdcall _GetVideoProcessingContrast ( int Sender);
      DLLIMPORT TVideoDeinterlacing _stdcall _GetVideoProcessingDeinterlacing ( int Sender);
      DLLIMPORT BOOL _stdcall _GetVideoProcessingGrayScale ( int Sender);
      DLLIMPORT int _stdcall _GetVideoProcessingHue ( int Sender);
      DLLIMPORT BOOL _stdcall _GetVideoProcessingInvertColors ( int Sender);
      DLLIMPORT BOOL _stdcall _GetVideoProcessingLeftRight ( int Sender);
      DLLIMPORT int _stdcall _GetVideoProcessingPixellization ( int Sender);
      DLLIMPORT TVideoRotation _stdcall _GetVideoProcessingRotation ( int Sender);
      DLLIMPORT double _stdcall _GetVideoProcessingRotationCustomAngle ( int Sender);
      DLLIMPORT int _stdcall _GetVideoProcessingSaturation ( int Sender);
      DLLIMPORT BOOL _stdcall _GetVideoProcessingTopDown ( int Sender);
      DLLIMPORT BOOL _stdcall _GetVideoQualitySettings ( int Sender);
      DLLIMPORT TVideoRenderer _stdcall _GetVideoRenderer ( int Sender);
      DLLIMPORT TVideoRendererExternal _stdcall _GetVideoRendererExternal ( int Sender);
      DLLIMPORT int _stdcall _GetVideoRendererExternalIndex ( int Sender);
      DLLIMPORT int _stdcall _GetVideoSize ( int Sender);
      DLLIMPORT BOOL _stdcall _GetVideoSizeFromIndex ( int Sender,  int Index,  int* _VideoWidth,  int* _VideoHeight);
      DLLIMPORT wchar_t * _stdcall _GetVideoSizes ( int Sender);
      DLLIMPORT int _stdcall _GetVideoSizesCount ( int Sender);
      DLLIMPORT TVideoSource _stdcall _GetVideoSource ( int Sender);
      DLLIMPORT wchar_t * _stdcall _GetVideoSource_FileOrURL ( int Sender);
      DLLIMPORT __int64 _stdcall _GetVideoSource_FileOrURL_StartTime ( int Sender);
      DLLIMPORT __int64 _stdcall _GetVideoSource_FileOrURL_StopTime ( int Sender);
      DLLIMPORT wchar_t * _stdcall _GetVideoSources ( int Sender);
      DLLIMPORT int _stdcall _GetVideoSourcesCount ( int Sender);
      DLLIMPORT int _stdcall _GetVideoSubtype ( int Sender);
      DLLIMPORT wchar_t * _stdcall _GetVideoSubtypes ( int Sender);
      DLLIMPORT int _stdcall _GetVideoSubtypesCount ( int Sender);
      DLLIMPORT BOOL _stdcall _GetVideoVisibleWhenStopped ( int Sender);
      DLLIMPORT int _stdcall _GetVideoWidth ( int Sender);
      DLLIMPORT int _stdcall _GetVideoWidth_PreferredAspectRatio ( int Sender);
      DLLIMPORT int _stdcall _GetVideoWidthFromIndex ( int Sender,  int Index);
      DLLIMPORT int _stdcall _GetVirtualAudioStreamControl ( int Sender);
      DLLIMPORT int _stdcall _GetVirtualVideoStreamControl ( int Sender);
      DLLIMPORT BOOL _stdcall _GetVMR9ImageAdjustmentBounds ( int Sender,  BOOL MainDisplay,  TVMR9ImageAdjustment VMR9ControlSetting,  int* MinValue,  int* MaxValue,  int* StepSize,  int* DefaultValue,  int* CurrentValue);
      DLLIMPORT TVuMeter _stdcall _GetVuMeter ( int Sender);
      DLLIMPORT unsigned int _stdcall _GetVUMeterSetting ( int Sender,  unsigned int ChannelIndex,  TVUMeterSetting VUMeterSetting);
      DLLIMPORT TWebcamStillCaptureButton _stdcall _GetWebcamStillCaptureButton ( int Sender);
      DLLIMPORT int _stdcall _GetZoomCoeff ( int Sender);
      DLLIMPORT int _stdcall _GetZoomXCenter ( int Sender);
      DLLIMPORT int _stdcall _GetZoomYCenter ( int Sender);
      DLLIMPORT TGraphState _stdcall _GraphState ( int Sender);
      DLLIMPORT void _stdcall _InitSyncMgr ( int Sender,  BOOL FromDeb,  BOOL Is_DM);
      DLLIMPORT BOOL _stdcall _IsAudioDeviceASoundCard ( int Sender,  int DeviceIndex);
      DLLIMPORT BOOL _stdcall _IsAudioDeviceConnected ( int Sender,  int DeviceIndex);
      DLLIMPORT BOOL _stdcall _IsAudioRendererConnected ( int Sender,  int RendererIndex);
      DLLIMPORT BOOL _stdcall _IsCameraControlSettingAvailable ( int Sender,  TCameraControl Setting);
      DLLIMPORT BOOL _stdcall _IsDialogAvailable ( int Sender,  TDialog Dialog);
      DLLIMPORT BOOL _stdcall _IsDirectX8OrHigherInstalled ( int Sender);
      DLLIMPORT BOOL _stdcall _IsDVDevice ( int Sender,  int Index);
      DLLIMPORT BOOL _stdcall _IsPlaylistActive ( int Sender);
      DLLIMPORT BOOL _stdcall _IsVideoControlModeAvailable ( int Sender,  TVideoControl Mode);
      DLLIMPORT BOOL _stdcall _IsVideoDeviceConnected ( int Sender,  int DeviceIndex);
      DLLIMPORT BOOL _stdcall _IsVideoQualitySettingAvailable ( int Sender,  TVideoQuality Setting);
      DLLIMPORT BOOL _stdcall _IsVideoSignalDetected ( int Sender,  BOOL DetectConnexantBlueScreen,  BOOL DetectCustomRGB,  int CustomR,  int CustomG,  int CustomB,  BOOL UseAsMaxValues);
      DLLIMPORT BOOL _stdcall _IsVMR9ImageAdjustmentAvailable ( int Sender,  BOOL MainDisplay);
      DLLIMPORT BOOL _stdcall _LoadCompressorSettingsFromDataString ( int Sender,  BOOL IsVideoCompressor,  int CompressorIndex,  wchar_t * DataString);
      DLLIMPORT BOOL _stdcall _LoadCompressorSettingsFromTextFile ( int Sender,  BOOL IsVideoCompressor,  int CompressorIndex,  wchar_t * FileName);
      DLLIMPORT BOOL _stdcall _MixAudioSamples ( int Sender,  int pSampleBuffer,  int SampleBufferSize,  int SampleDataLength,  TFormatType SampleFormatType,  int pFormat,  __int64 SampleStartTime,  __int64 SampleStopTime);
      DLLIMPORT BOOL _stdcall _Mixer_Activation ( int Sender,  int Id,  BOOL Activate);
      DLLIMPORT int _stdcall _Mixer_AddAudioToMixer ( int Sender,  int SourceUniqueID);
      DLLIMPORT int _stdcall _Mixer_AddToMixer ( int Sender,  int SourceUniqueID,  int SourceVideoInput,  int MosaicLine,  int MosaicColumn,  int AlternatedGroup,  int AlternatedTimeIntervalInMs,  BOOL ReplacePreviouslyAdded,  BOOL CanEraseBackground);
      DLLIMPORT BOOL _stdcall _Mixer_AudioActivation ( int Sender,  int Id,  BOOL Activate);
      DLLIMPORT BOOL _stdcall _Mixer_RemoveAudioFromMixer ( int Sender,  int Id);
      DLLIMPORT BOOL _stdcall _Mixer_RemoveFromMixer ( int Sender,  int Id);
      DLLIMPORT int _stdcall _Mixer_SetupPIPFromSource ( int Sender,  int SourceUniqueID,  int Source_Left,  int Source_Top,  int Source_Width,  int Source_Height,  BOOL ActivatePIP,  int PIP_Left,  int PIP_Top,  int PIP_Width,  int PIP_Height,  BOOL MoveToTop);
      DLLIMPORT BOOL _stdcall _MonitorBounds ( int Sender,  int MonitorNumber,  int* LeftBound,  int* TopBound,  int* RightBound,  int* BottomBound);
      DLLIMPORT int _stdcall _MonitorsCount ( int Sender);
      DLLIMPORT int _stdcall _MotionDetector_CellColorIntensity ( int Sender,  TRGBSelector RGBSelector,  int x,  int y);
      DLLIMPORT double _stdcall _MotionDetector_CellMotionRatio ( int Sender,  int x,  int y);
      DLLIMPORT wchar_t * _stdcall _MotionDetector_Get2DTextGrid ( int Sender);
      DLLIMPORT wchar_t * _stdcall _MotionDetector_Get2DTextMotion ( int Sender);
      DLLIMPORT BOOL _stdcall _MotionDetector_GetCellLocation ( int Sender,  int x,  int y,  int* XLocation,  int* YLocation);
      DLLIMPORT BOOL _stdcall _MotionDetector_GetCellSensitivity ( int Sender,  int x,  int y,  int* Value);
      DLLIMPORT BOOL _stdcall _MotionDetector_GetCellSize ( int Sender,  int* XSize,  int* YSize);
      DLLIMPORT int _stdcall _MotionDetector_GlobalColorIntensity ( int Sender,  TRGBSelector RGBSelector);
      DLLIMPORT void _stdcall _MotionDetector_GloballyIncOrDecSensitivity ( int Sender,  int Value);
      DLLIMPORT void _stdcall _MotionDetector_Reset ( int Sender);
      DLLIMPORT void _stdcall _MotionDetector_ResetGlobalSensitivity ( int Sender,  int Value);
      DLLIMPORT BOOL _stdcall _MotionDetector_SetCellSensitivity ( int Sender,  int x,  int y,  int Value);
      DLLIMPORT void _stdcall _MotionDetector_SetGridSize ( int Sender,  int x,  int y);
      DLLIMPORT void _stdcall _MotionDetector_ShowGridDialog ( int Sender);
      DLLIMPORT void _stdcall _MotionDetector_TriggerNow ( int Sender);
      DLLIMPORT BOOL _stdcall _MotionDetector_UseThisReferenceSample ( int Sender,  int Bitmap_,  wchar_t * BMPFile,  wchar_t * JPEGFile);
      DLLIMPORT int _stdcall _MPEGProgramSetting ( int Sender,  TMPEGProgramSetting MPEGProgramSetting,  int Value);
      DLLIMPORT int _stdcall _MultiplexerIndex ( int Sender,  wchar_t * Value);
      DLLIMPORT void _stdcall _NotifyPlayerTrackbarAction ( int Sender,  TTrackbarAction TrackbarAction);
      DLLIMPORT BOOL _stdcall _OpenDVD ( int Sender);
      DLLIMPORT BOOL _stdcall _OpenPlayer ( int Sender);
      DLLIMPORT BOOL _stdcall _OpenPlayerAtFramePositions ( int Sender,  __int64 StartFrame,  __int64 StopFrame,  BOOL KeepBounds,  BOOL CloseAndReopenIfAlreadyOpened);
      DLLIMPORT BOOL _stdcall _OpenPlayerAtTimePositions ( int Sender,  __int64 StartTime,  __int64 StopTime,  BOOL KeepBounds,  BOOL CloseAndReopenIfAlreadyOpened);
      DLLIMPORT void _stdcall _PausePlayer ( int Sender);
      DLLIMPORT BOOL _stdcall _PausePreview ( int Sender);
      DLLIMPORT BOOL _stdcall _PauseRecording ( int Sender);
      DLLIMPORT BOOL _stdcall _PlayerFrameStep ( int Sender,  int FrameCount);
      DLLIMPORT BOOL _stdcall _Playlist ( int Sender,  TPlaylist PlaylistAction,  wchar_t * VideoClip);
      DLLIMPORT int _stdcall _PointGreyConfig ( int Sender,  TPointGreyConfig ConfigType,  unsigned int* PGRActionValue,  unsigned int ulRegister,  unsigned int ulMode,  unsigned int ulLeft,  unsigned int ulTop,  unsigned int ulWidth,  unsigned int ulHeight,  unsigned int ulPercentage,  unsigned int ulFormat);
      DLLIMPORT BOOL _stdcall _PutMiscDeviceControl ( int Sender,  TMiscDeviceControl MiscDeviceControl,  int Index,  int Value);
      DLLIMPORT unsigned int _stdcall _RecordingKBytesWrittenToDisk ( int Sender);
      DLLIMPORT BOOL _stdcall _RecordToNewFileNow ( int Sender,  wchar_t * NewRecordingFileName,  BOOL ResetStreamTime);
      DLLIMPORT BOOL _stdcall _ReencodeVideoClip ( int Sender,  wchar_t * SourceVideoClip,  wchar_t * NewVideoClip,  BOOL IncludeVideoStream,  BOOL IncludeAudioStream,  BOOL UseFrameGrabber,  BOOL UseCurrentVideoCompressor,  BOOL UseCurrentAudioCompressor);
      DLLIMPORT void _stdcall _RefreshDevicesAndCompressorsLists ( int Sender);
      DLLIMPORT void _stdcall _RefreshPlayerOverlays ( int Sender);
      DLLIMPORT BOOL _stdcall _ResetPreview ( int Sender);
      DLLIMPORT BOOL _stdcall _ResetVideoDeviceSettings ( int Sender);
      DLLIMPORT BOOL _stdcall _ResumePreview ( int Sender);
      DLLIMPORT BOOL _stdcall _ResumeRecording ( int Sender);
      DLLIMPORT void _stdcall _RetrieveInitialXYAfterRotation ( int Sender,  int X,  int Y,  int* OriginalX,  int* OriginalY);
      DLLIMPORT void _stdcall _RewindPlayer ( int Sender);
      DLLIMPORT void _stdcall _RunPlayer ( int Sender);
      DLLIMPORT void _stdcall _RunPlayerBackwards ( int Sender);
      DLLIMPORT wchar_t * _stdcall _SaveCompressorSettingsToDataString ( int Sender,  BOOL IsVideoCompressor,  int CompressorIndex);
      DLLIMPORT BOOL _stdcall _SaveCompressorSettingsToTextFile ( int Sender,  BOOL IsVideoCompressor,  int CompressorIndex,  wchar_t * FileName);
      DLLIMPORT BOOL _stdcall _ScreenRecordingUsingCoordinates ( int Sender,  BOOL FunctionEnabled,  int scLeft,  int scTop,  int scWidth,  int scHeight);
      DLLIMPORT BOOL _stdcall _SendCameraCommand ( int Sender,  int Pan,  int Tilt,  BOOL Relative);
      DLLIMPORT BOOL _stdcall _SendDVCommand ( int Sender,  TDVCommand DVCommand);
      DLLIMPORT BOOL _stdcall _SendImageToVideoFromBitmaps ( int Sender,  wchar_t * ImageFilePath,  int BitmapHandle,  BOOL CanFreeBitmapHandle,  BOOL EndOfData);
      DLLIMPORT BOOL _stdcall _SendIPCameraCommand ( int Sender,  wchar_t * IPCameraCommand);
      DLLIMPORT void _stdcall _Set_OnDeviceArrivalOrRemoval ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetAdjustOverlayAspectRatio ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetAdjustPixelAspectRatio ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetAero ( int Sender,  TAero Value);
      DLLIMPORT void _stdcall _SetAnalogVideoStandard ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetApplicationPriority ( int Sender,  TApplicationPriority Value);
      DLLIMPORT void _stdcall _SetASFAudioBitRate ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetASFAudioChannels ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetASFBufferWindow ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetASFDeinterlaceMode ( int Sender,  TASFDeinterlaceMode Value);
      DLLIMPORT void _stdcall _SetASFFixedFrameRate ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetASFMediaServerPublishingPoint ( int Sender,  wchar_t * Value);
      DLLIMPORT void _stdcall _SetASFMediaServerRemovePublishingPointAfterDisconnect ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetASFMediaServerTemplatePublishingPoint ( int Sender,  wchar_t * Value);
      DLLIMPORT void _stdcall _SetASFNetworkMaxUsers ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetASFNetworkPort ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetASFProfile ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetASFProfileFromCustomFile ( int Sender,  wchar_t * Value);
      DLLIMPORT void _stdcall _SetASFProfileVersion ( int Sender,  TASFProfileVersion Value);
      DLLIMPORT void _stdcall _SetASFVideoBitRate ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetASFVideoFrameRate ( int Sender,  double Value);
      DLLIMPORT void _stdcall _SetASFVideoHeight ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetASFVideoMaxKeyFrameSpacing ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetASFVideoQuality ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetASFVideoWidth ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetAspectRatioToUse ( int Sender,  double Value);
      DLLIMPORT void _stdcall _SetAssociateAudioAndVideoDevices ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetAudioBalance ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetAudioChannelRenderMode ( int Sender,  TAudioChannelRenderMode Value);
      DLLIMPORT void _stdcall _SetAudioCompressor ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetAudioDevice ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetAudioDeviceRendering ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetAudioFormat ( int Sender,  TAudioFormat Value);
      DLLIMPORT void _stdcall _SetAudioInput ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetAudioInputBalance ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetAudioInputLevel ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetAudioInputMono ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetAudioPeakEvent ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetAudioRecording ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetAudioRenderer ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetAudioSource ( int Sender,  TAudioSource Value);
      DLLIMPORT void _stdcall _SetAudioStreamNumber ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetAudioSyncAdjustment ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetAudioSyncAdjustmentEnabled ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetAudioVolume ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetAuthentication ( int Sender,  TAuthenticationType AuthenticationType,  wchar_t * UserName,  wchar_t * Password);
      DLLIMPORT void _stdcall _SetAutoConnectRelatedPins ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetAutoFileName ( int Sender,  TAutoFileName Value);
      DLLIMPORT void _stdcall _SetAutoFileNameMinDigits ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetAutoFilePrefix ( int Sender,  wchar_t * Value);
      DLLIMPORT void _stdcall _SetAutoRefreshPreview ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetAutoStartPlayer ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetAVIDurationUpdated ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetAVIFormatOpenDML ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetAVIFormatOpenDMLCompatibilityIndex ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetAVIMuxConfig ( int Sender,  TAVIMuxConfig AVIMuxSetting,  int Value);
      DLLIMPORT void _stdcall _SetBackgroundColor ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetBufferCount ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetBurstCount ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetBurstInterval ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetBurstMode ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetBurstType ( int Sender,  TFrameCaptureDest Value);
      DLLIMPORT void _stdcall _SetBusyCursor ( int Sender,  TCursors Value);
      DLLIMPORT BOOL _stdcall _SetCameraControl ( int Sender,  TCameraControl Setting,  BOOL SetAuto,  BOOL SetDefault,  int SetValue);
      DLLIMPORT void _stdcall _SetCameraControlSettings ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetCaptureFileExt ( int Sender,  wchar_t * Value);
      DLLIMPORT void _stdcall _SetColorKey ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetColorKeyEnabled ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetCompressionMode ( int Sender,  TCompressionMode Value);
      DLLIMPORT void _stdcall _SetCompressionType ( int Sender,  TCompressionType Value);
      DLLIMPORT void _stdcall _SetCropping_Enabled ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetCropping_Height ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetCropping_Outbounds ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetCropping_Width ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetCropping_X ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetCropping_Y ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetCropping_Zoom ( int Sender,  double Value);
      DLLIMPORT void _stdcall _SetDisplay2BoolProperties ( int Sender,  int Index,  BOOL Value);
      DLLIMPORT void _stdcall _SetDisplay2LongProperties ( int Sender,  int Index,  int Value);
      DLLIMPORT void _stdcall _SetDisplayAspectRatio ( int Sender,  int Index,  TAspectRatio Value);
      DLLIMPORT void _stdcall _SetDisplayBoolProperties ( int Sender,  int Index,  BOOL Value);
      DLLIMPORT void _stdcall _SetDisplayLongProperties ( int Sender,  int Index,  int Value);
      DLLIMPORT void _stdcall _SetDroppedFramesPollingInterval ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetDVDateTimeEnabled ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetDVDiscontinuityMinimumInterval ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetDVDTitle ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetDVEncoder_VideoFormat ( int Sender,  TDVVideoFormat Value);
      DLLIMPORT void _stdcall _SetDVEncoder_VideoResolution ( int Sender,  TDVSize Value);
      DLLIMPORT void _stdcall _SetDVEncoder_VideoStandard ( int Sender,  TDVVideoStandard Value);
      DLLIMPORT void _stdcall _SetDVRecordingInNativeFormatSeparatesStreams ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetDVReduceFrameRate ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetDVRgb219 ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetDVTimeCodeEnabled ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetEventNotificationSynchrone ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetFixFlickerOrBlackCapture ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetFrameCaptureBounds ( int Sender,  int LeftPosition,  int TopPosition,  int RightPosition,  int BottomPosition);
      DLLIMPORT void _stdcall _SetFrameCaptureHeight ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetFrameCaptureWidth ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetFrameCaptureWithoutOverlay ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetFrameCaptureZoomSize ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetFrameGrabber ( int Sender,  TFrameGrabber Value);
      DLLIMPORT void _stdcall _SetFrameGrabberRGBFormat ( int Sender,  TFrameGrabberRGBFormat Value);
      DLLIMPORT void _stdcall _SetFrameNumberStartsFromZero ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetFrameRate ( int Sender,  double Value);
      DLLIMPORT void _stdcall _SetHeaderAttribute ( int Sender,  THeaderAttribute HeaderAttribute,  wchar_t * Value);
      DLLIMPORT void _stdcall _SetHoldRecording ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetImageOverlay_AlphaBlend ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetImageOverlay_AlphaBlendValue ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetImageOverlay_ChromaKey ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetImageOverlay_ChromaKeyLeewayPercent ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetImageOverlay_ChromaKeyRGBColor ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetImageOverlay_Height ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetImageOverlay_LeftLocation ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetImageOverlay_RotationAngle ( int Sender,  double Value);
      DLLIMPORT void _stdcall _SetImageOverlay_StretchToVideoSize ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetImageOverlay_TopLocation ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetImageOverlay_Transparent ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetImageOverlay_TransparentColorValue ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetImageOverlay_UseTransparentColor ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetImageOverlay_Width ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetImageOverlayAttributes ( int Sender,  int LeftLocation,  int TopLocation,  int StretchedWidth,  int StretchedHeight,  BOOL Transparent,  BOOL UseTransparentColor,  int TransparentColorValue,  BOOL AlphaBlend,  int AlphaBlendValue);
      DLLIMPORT void _stdcall _SetImageOverlayEnabled ( int Sender,  BOOL Value);
      DLLIMPORT BOOL _stdcall _SetImageOverlayFromBMPFile ( int Sender,  wchar_t * FileName);
      DLLIMPORT BOOL _stdcall _SetImageOverlayFromHBitmap ( int Sender,  int Bitmap);
      DLLIMPORT BOOL _stdcall _SetImageOverlayFromImageFile ( int Sender,  wchar_t * FileName);
      DLLIMPORT BOOL _stdcall _SetImageOverlayFromJPEGFile ( int Sender,  wchar_t * FileName);
      DLLIMPORT void _stdcall _SetImageOverlaySelector ( int Sender,  int Value);
      DLLIMPORT BOOL _stdcall _SetIPCameraSetting ( int Sender,  TIPCameraSetting Setting,  int Value);
      DLLIMPORT void _stdcall _SetIPCameraURL ( int Sender,  wchar_t * Value);
      DLLIMPORT void _stdcall _SetJPEGPerformance ( int Sender,  TJPEGPerformance Value);
      DLLIMPORT void _stdcall _SetJPEGProgressiveDisplay ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetJPEGQuality ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetLicenseString ( int Sender,  wchar_t * Value);
      DLLIMPORT void _stdcall _SetLocation ( int Sender,  int lLeft,  int lTop,  int lWidth,  int lHeight);
      DLLIMPORT void _stdcall _SetLogoDisplayed ( int Sender,  BOOL Value);
      DLLIMPORT BOOL _stdcall _SetLogoFromBMPFile ( int Sender,  wchar_t * FileName);
      DLLIMPORT BOOL _stdcall _SetLogoFromHBitmap ( int Sender,  int Bitmap);
      DLLIMPORT BOOL _stdcall _SetLogoFromJPEGFile ( int Sender,  wchar_t * FileName);
      DLLIMPORT void _stdcall _SetLogoLayout ( int Sender,  TLogoLayout Value);
      DLLIMPORT void _stdcall _SetMixAudioSamplesLevel ( int Sender,  int Index,  int Value);
      DLLIMPORT void _stdcall _SetMixer_MosaicColumns ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetMixer_MosaicLines ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetMotionDetector_CompareBlue ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetMotionDetector_CompareGreen ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetMotionDetector_CompareRed ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetMotionDetector_Enabled ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetMotionDetector_GreyScale ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetMotionDetector_Grid ( int Sender,  wchar_t * Value);
      DLLIMPORT void _stdcall _SetMotionDetector_MaxDetectionsPerSecond ( int Sender,  double Value);
      DLLIMPORT void _stdcall _SetMotionDetector_ReduceCPULoad ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetMotionDetector_ReduceVideoNoise ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetMotionDetector_Triggered ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetMouseWheelEventEnabled ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetMpegStreamType ( int Sender,  TMpegStreamType Value);
      DLLIMPORT void _stdcall _SetMultiplexedInputEmulation ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetMultiplexedRole ( int Sender,  TMultiplexedRole Value);
      DLLIMPORT void _stdcall _SetMultiplexedStabilizationDelay ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetMultiplexedSwitchDelay ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetMultiplexer ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetMultiplexerFilterByName ( int Sender,  wchar_t * Value);
      DLLIMPORT void _stdcall _SetMuteAudioRendering ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetNetworkStreaming ( int Sender,  TNetworkStreaming Value);
      DLLIMPORT void _stdcall _SetNetworkStreamingType ( int Sender,  TNetworkStreamingType Value);
      DLLIMPORT void _stdcall _SetNormalCursor ( int Sender,  TCursors Value);
      DLLIMPORT void _stdcall _SetNotificationMethod ( int Sender,  TNotificationMethod Value);
      DLLIMPORT void _stdcall _SetNotificationPriority ( int Sender,  TThreadPriority Value);
      DLLIMPORT void _stdcall _SetNotificationSleepTime ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetOnAudioDeviceSelected ( int Instance,  TOnAudioDeviceSelectedCb Event);
      DLLIMPORT void _stdcall _SetOnAudioPeak ( int Instance,  TOnAudioPeakCb Event);
      DLLIMPORT void _stdcall _SetOnAuthenticationNeeded ( int Instance,  TOnAuthenticationNeededCb Event);
      DLLIMPORT void _stdcall _SetOnAVIDurationUpdated ( int Instance,  TOnAVIDurationUpdatedCb Event);
      DLLIMPORT void _stdcall _SetOnBacktimedFramesCountReached ( int Instance,  TOnBacktimedFramesCountReachedCb Event);
      DLLIMPORT void _stdcall _SetOnBitmapsLoadingProgress ( int Instance,  TOnBitmapsLoadingProgressCb Event);
      DLLIMPORT void _stdcall _SetOnClick ( int Instance,  TOnClickCb Event);
      DLLIMPORT void _stdcall _SetOnClientConnection ( int Instance,  TOnClientConnectionCb Event);
      DLLIMPORT void _stdcall _SetOnColorKeyChange ( int Instance,  TOnColorKeyChangeCb Event);
      DLLIMPORT void _stdcall _SetOnCopyPreallocDataCompleted ( int Instance,  TOnCopyPreallocDataCompletedCb Event);
      DLLIMPORT void _stdcall _SetOnCopyPreallocDataProgress ( int Instance,  TOnCopyPreallocDataProgressCb Event);
      DLLIMPORT void _stdcall _SetOnCopyPreallocDataStarted ( int Instance,  TOnCopyPreallocDataStartedCb Event);
      DLLIMPORT void _stdcall _SetOnCreatePreallocFileCompleted ( int Instance,  TOnCreatePreallocFileCompletedCb Event);
      DLLIMPORT void _stdcall _SetOnCreatePreallocFileProgress ( int Instance,  TOnCreatePreallocFileProgressCb Event);
      DLLIMPORT void _stdcall _SetOnCreatePreallocFileStarted ( int Instance,  TOnCreatePreallocFileStartedCb Event);
      DLLIMPORT void _stdcall _SetOnDblClick ( int Instance,  TOnDblClickCb Event);
      DLLIMPORT void _stdcall _SetOnDeviceArrivalOrRemoval ( int Instance,  TOnDeviceArrivalOrRemovalCb Event);
      DLLIMPORT void _stdcall _SetOnDeviceLost ( int Instance,  TOnDeviceLostCb Event);
      DLLIMPORT void _stdcall _SetOnDirectNetworkStreamingHostUrl ( int Instance,  TOnDirectNetworkStreamingHostUrlCb Event);
      DLLIMPORT void _stdcall _SetOnDiskFull ( int Instance,  TOnDiskFullCb Event);
      DLLIMPORT void _stdcall _SetOnDragDrop ( int Instance,  TOnDragDropCb Event);
      DLLIMPORT void _stdcall _SetOnDragOver ( int Instance,  TOnDragOverCb Event);
      DLLIMPORT void _stdcall _SetOnDVCommandCompleted ( int Instance,  TOnDVCommandCompletedCb Event);
      DLLIMPORT void _stdcall _SetOnDVDiscontinuity ( int Instance,  TOnDVDiscontinuityCb Event);
      DLLIMPORT void _stdcall _SetOnEnumerateWindows ( int Instance,  TOnEnumerateWindowsCb Event);
      DLLIMPORT void _stdcall _SetOnFilterSelected ( int Instance,  TOnFilterSelectedCb Event);
      DLLIMPORT void _stdcall _SetOnFirstFrameReceived ( int Instance,  TOnFirstFrameReceivedCb Event);
      DLLIMPORT void _stdcall _SetOnFrameBitmap ( int Instance,  TOnFrameBitmapCb Event);
      DLLIMPORT void _stdcall _SetOnFrameCaptureCompleted ( int Instance,  TOnFrameCaptureCompletedCb Event);
      DLLIMPORT void _stdcall _SetOnFrameOverlayUsingDC ( int Instance,  TOnFrameOverlayUsingDCCb Event);
      DLLIMPORT void _stdcall _SetOnFrameOverlayUsingDIB ( int Instance,  TOnFrameOverlayUsingDIBCb Event);
      DLLIMPORT void _stdcall _SetOnFrameProgress ( int Instance,  TOnFrameProgressCb Event);
      DLLIMPORT void _stdcall _SetOnFrameProgress2 ( int Instance,  TOnFrameProgress2Cb Event);
      DLLIMPORT void _stdcall _SetOnGraphBuilt ( int Instance,  TOnGraphBuiltCb Event);
      DLLIMPORT void _stdcall _SetOnInactive ( int Instance,  TOnInactiveCb Event);
      DLLIMPORT void _stdcall _SetOnKeyPress ( int Instance,  TOnKeyPressCb Event);
      DLLIMPORT void _stdcall _SetOnLastCommandCompleted ( int Instance,  TOnLastCommandCompletedCb Event);
      DLLIMPORT void _stdcall _SetOnLog ( int Instance,  TOnLogCb Event);
      DLLIMPORT void _stdcall _SetOnMotionDetected ( int Instance,  TOnMotionDetectedCb Event);
      DLLIMPORT void _stdcall _SetOnMotionNotDetected ( int Instance,  TOnMotionNotDetectedCb Event);
      DLLIMPORT void _stdcall _SetOnMouseDown ( int Instance,  TOnMouseDownCb Event);
      DLLIMPORT void _stdcall _SetOnMouseMove ( int Instance,  TOnMouseMoveCb Event);
      DLLIMPORT void _stdcall _SetOnMouseUp ( int Instance,  TOnMouseUpCb Event);
      DLLIMPORT void _stdcall _SetOnMouseWheel ( int Instance,  TOnMouseWheelCb Event);
      DLLIMPORT void _stdcall _SetOnNoVideoDevices ( int Instance,  TOnNoVideoDevicesCb Event);
      DLLIMPORT void _stdcall _SetOnPlayerBufferingData ( int Instance,  TOnPlayerBufferingDataCb Event);
      DLLIMPORT void _stdcall _SetOnPlayerEndOfPlaylist ( int Instance,  TOnPlayerEndOfPlaylistCb Event);
      DLLIMPORT void _stdcall _SetOnPlayerEndOfStream ( int Instance,  TOnPlayerEndOfStreamCb Event);
      DLLIMPORT void _stdcall _SetOnPlayerOpened ( int Instance,  TOnPlayerOpenedCb Event);
      DLLIMPORT void _stdcall _SetOnPlayerStateChanged ( int Instance,  TOnPlayerStateChangedCb Event);
      DLLIMPORT void _stdcall _SetOnPlayerUpdateTrackbarPosition ( int Instance,  TOnPlayerUpdateTrackbarPositionCb Event);
      DLLIMPORT void _stdcall _SetOnPreviewStarted ( int Instance,  TOnPreviewStartedCb Event);
      DLLIMPORT void _stdcall _SetOnRawAudioSample ( int Instance,  TOnRawAudioSampleCb Event);
      DLLIMPORT void _stdcall _SetOnRawVideoSample ( int Instance,  TOnRawVideoSampleCb Event);
      DLLIMPORT void _stdcall _SetOnRecordingCompleted ( int Instance,  TOnRecordingCompletedCb Event);
      DLLIMPORT void _stdcall _SetOnRecordingPaused ( int Instance,  TOnRecordingPausedCb Event);
      DLLIMPORT void _stdcall _SetOnRecordingReadyToStart ( int Instance,  TOnRecordingReadyToStartCb Event);
      DLLIMPORT void _stdcall _SetOnRecordingStarted ( int Instance,  TOnRecordingStartedCb Event);
      DLLIMPORT void _stdcall _SetOnReencodingCompleted ( int Instance,  TOnReencodingCompletedCb Event);
      DLLIMPORT void _stdcall _SetOnReencodingProgress ( int Instance,  TOnReencodingProgressCb Event);
      DLLIMPORT void _stdcall _SetOnReencodingStarted ( int Instance,  TOnReencodingStartedCb Event);
      DLLIMPORT void _stdcall _SetOnReinitializing ( int Instance,  TOnReinitializingCb Event);
      DLLIMPORT void _stdcall _SetOnResizeVideo ( int Instance,  TOnResizeVideoCb Event);
      DLLIMPORT void _stdcall _SetOnTextOverlayScrollingCompleted ( int Instance,  TOnTextOverlayScrollingCompletedCb Event);
      DLLIMPORT void _stdcall _SetOnThirdPartyFilterConnected ( int Instance,  TOnThirdPartyFilterConnectedCb Event);
      DLLIMPORT void _stdcall _SetOnTVChannelScanCompleted ( int Instance,  TOnTVChannelScanCompletedCb Event);
      DLLIMPORT void _stdcall _SetOnTVChannelScanStarted ( int Instance,  TOnTVChannelScanStartedCb Event);
      DLLIMPORT void _stdcall _SetOnTVChannelSelected ( int Instance,  TOnTVChannelSelectedCb Event);
      DLLIMPORT void _stdcall _SetOnVideoCompressionSettings ( int Instance,  TOnVideoCompressionSettingsCb Event);
      DLLIMPORT void _stdcall _SetOnVideoDeviceSelected ( int Instance,  TOnVideoDeviceSelectedCb Event);
      DLLIMPORT void _stdcall _SetOnVideoFromBitmapsNextFrameNeeded ( int Instance,  TOnVideoFromBitmapsNextFrameNeededCb Event);
      DLLIMPORT void _stdcall _SetOverlayAfterTransform ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetParentWindow ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetPlayerAudioRendering ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetPlayerDuration ( int Sender,  __int64 Value);
      DLLIMPORT void _stdcall _SetPlayerDVSize ( int Sender,  TDVSize Value);
      DLLIMPORT void _stdcall _SetPlayerFastSeekSpeedRatio ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetPlayerFileName ( int Sender,  wchar_t * Value);
      DLLIMPORT void _stdcall _SetPlayerForcedCodec ( int Sender,  wchar_t * Value);
      DLLIMPORT void _stdcall _SetPlayerFramePosition ( int Sender,  __int64 Value);
      DLLIMPORT void _stdcall _SetPlayerRefreshPausedDisplay ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetPlayerRefreshPausedDisplayFrameRate ( int Sender,  double Value);
      DLLIMPORT void _stdcall _SetPlayerSpeedRatio ( int Sender,  double Value);
      DLLIMPORT void _stdcall _SetPlayerTimePosition ( int Sender,  __int64 Value);
      DLLIMPORT void _stdcall _SetPlayerTrackBarSynchrone ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetPlaylistIndex ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetPreallocCapFileCopiedAfterRecording ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetPreallocCapFileEnabled ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetPreallocCapFileName ( int Sender,  wchar_t * Value);
      DLLIMPORT void _stdcall _SetPreallocCapFileSizeInMB ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetPreviewZoomSize ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetQuickDeviceInitialization ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetRawAudioSampleCapture ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetRawCaptureAsyncEvent ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetRawSampleCaptureLocation ( int Sender,  TRawSampleCaptureLocation Value);
      DLLIMPORT void _stdcall _SetRawVideoSampleCapture ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetRecordingAudioBitRate ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetRecordingBacktimedFramesCount ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetRecordingCanPause ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetRecordingFileName ( int Sender,  wchar_t * Value);
      DLLIMPORT void _stdcall _SetRecordingInNativeFormat ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetRecordingMethod ( int Sender,  TRecordingMethod Value);
      DLLIMPORT void _stdcall _SetRecordingOnMotion_Enabled ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetRecordingOnMotion_MotionThreshold ( int Sender,  double Value);
      DLLIMPORT void _stdcall _SetRecordingOnMotion_NoMotionPauseDelayMs ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetRecordingPauseCreatesNewFile ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetRecordingSize ( int Sender,  TRecordingSize Value);
      DLLIMPORT void _stdcall _SetRecordingTimer ( int Sender,  TRecordingTimer Value);
      DLLIMPORT void _stdcall _SetRecordingTimerInterval ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetRecordingVideoBitRate ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetReencodingIncludeAudioStream ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetReencodingIncludeVideoStream ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetReencodingMethod ( int Sender,  TRecordingMethod Value);
      DLLIMPORT void _stdcall _SetReencodingNewVideoClip ( int Sender,  wchar_t * Value);
      DLLIMPORT void _stdcall _SetReencodingSourceVideoClip ( int Sender,  wchar_t * Value);
      DLLIMPORT void _stdcall _SetReencodingStartFrame ( int Sender,  __int64 Value);
      DLLIMPORT void _stdcall _SetReencodingStartTime ( int Sender,  __int64 Value);
      DLLIMPORT void _stdcall _SetReencodingStopFrame ( int Sender,  __int64 Value);
      DLLIMPORT void _stdcall _SetReencodingStopTime ( int Sender,  __int64 Value);
      DLLIMPORT void _stdcall _SetReencodingUseAudioCompressor ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetReencodingUseFrameGrabber ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetReencodingUseVideoCompressor ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetReencodingWMVOutput ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetScreenRecordingLayeredWindows ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetScreenRecordingMonitor ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetScreenRecordingNonVisibleWindows ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetScreenRecordingThroughClipboard ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetScreenRecordingWithCursor ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetSendToDV_DeviceIndex ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetSpeakerBalance ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetSpeakerControl ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetSpeakerVolume ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetStoragePath ( int Sender,  wchar_t * Value);
      DLLIMPORT void _stdcall _SetStoreDeviceSettingsInRegistry ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetSyncCommands ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetSynchronizationRole ( int Sender,  TSynchronizationRole Value);
      DLLIMPORT void _stdcall _SetSynchronized ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetSyncPreview ( int Sender,  TSyncPreview Value);
      DLLIMPORT void _stdcall _SetTextOverlay_Font ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetTextOverlayAlign ( int Sender,  TTextOverlayAlign Value);
      DLLIMPORT void _stdcall _SetTextOverlayBkColor ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetTextOverlayCustomVar ( int Sender,  int TextOverlaySelector,  int VarIndex,  wchar_t * VarText);
      DLLIMPORT void _stdcall _SetTextOverlayEnabled ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetTextOverlayFontColor ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetTextOverlayLeft ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetTextOverlayRight ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetTextOverlayScrolling ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetTextOverlayScrollingSpeed ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetTextOverlaySelector ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetTextOverlayShadow ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetTextOverlayShadowColor ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetTextOverlayShadowDirection ( int Sender,  TCardinalDirection Value);
      DLLIMPORT void _stdcall _SetTextOverlayString ( int Sender,  wchar_t * Value);
      DLLIMPORT void _stdcall _SetTextOverlayTop ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetTextOverlayTransparent ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetThirdPartyDeinterlacer ( int Sender,  wchar_t * Value);
      DLLIMPORT void _stdcall _SetTranslateMouseCoordinates ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetTunerFrequency ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetTunerMode ( int Sender,  TTunerMode Value);
      DLLIMPORT void _stdcall _SetTVChannel ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetTVCountryCode ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetTVTunerInputType ( int Sender,  TTunerInputType Value);
      DLLIMPORT void _stdcall _SetTVUseFrequencyOverrides ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetUseClock ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetVCRHorizontalLocking ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetVersion ( int Sender,  wchar_t * Value);
      DLLIMPORT void _stdcall _SetVideoCompression_DataRate ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetVideoCompression_KeyFrameRate ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetVideoCompression_PFramesPerKeyFrame ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetVideoCompression_Quality ( int Sender,  double Value);
      DLLIMPORT void _stdcall _SetVideoCompression_WindowSize ( int Sender,  int Value);
      DLLIMPORT BOOL _stdcall _SetVideoCompressionDefaults ( int Sender);
      DLLIMPORT BOOL _stdcall _SetVideoCompressionSettings ( int Sender,  int DataRate,  int KeyFrameRate,  int PFramesPerKeyFrame,  int WindowSize,  double Quality);
      DLLIMPORT void _stdcall _SetVideoCompressor ( int Sender,  int Value);
      DLLIMPORT BOOL _stdcall _SetVideoControlMode ( int Sender,  BOOL FlipHorizontal,  BOOL FlipVertical,  BOOL ExternalTriggerEnable,  BOOL Trigger);
      DLLIMPORT void _stdcall _SetVideoControlSettings ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetVideoCursor ( int Sender,  TCursors Value);
      DLLIMPORT void _stdcall _SetVideoDevice ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetVideoDoubleBuffered ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetVideoFormat ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetVideoFromImages_BitmapsSortedBy ( int Sender,  TFileSort Value);
      DLLIMPORT void _stdcall _SetVideoFromImages_RepeatIndefinitely ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetVideoFromImages_SourceDirectory ( int Sender,  wchar_t * Value);
      DLLIMPORT void _stdcall _SetVideoFromImages_TemporaryFile ( int Sender,  wchar_t * Value);
      DLLIMPORT void _stdcall _SetVideoInput ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetVideoProcessingBrightness ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetVideoProcessingContrast ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetVideoProcessingDeinterlacing ( int Sender,  TVideoDeinterlacing Value);
      DLLIMPORT void _stdcall _SetVideoProcessingGrayScale ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetVideoProcessingHue ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetVideoProcessingInvertColors ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetVideoProcessingLeftRight ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetVideoProcessingPixellization ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetVideoProcessingRotation ( int Sender,  TVideoRotation Value);
      DLLIMPORT void _stdcall _SetVideoProcessingRotationCustomAngle ( int Sender,  double Value);
      DLLIMPORT void _stdcall _SetVideoProcessingSaturation ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetVideoProcessingTopDown ( int Sender,  BOOL Value);
      DLLIMPORT BOOL _stdcall _SetVideoQuality ( int Sender,  TVideoQuality Setting,  BOOL SetAuto,  BOOL SetDefault,  int SetValue);
      DLLIMPORT void _stdcall _SetVideoQualitySettings ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetVideoRenderer ( int Sender,  TVideoRenderer Value);
      DLLIMPORT void _stdcall _SetVideoRendererExternal ( int Sender,  TVideoRendererExternal Value);
      DLLIMPORT void _stdcall _SetVideoRendererExternalIndex ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetVideoSize ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetVideoSource ( int Sender,  TVideoSource Value);
      DLLIMPORT void _stdcall _SetVideoSource_FileOrURL ( int Sender,  wchar_t * Value);
      DLLIMPORT void _stdcall _SetVideoSource_FileOrURL_StartTime ( int Sender,  __int64 Value);
      DLLIMPORT void _stdcall _SetVideoSource_FileOrURL_StopTime ( int Sender,  __int64 Value);
      DLLIMPORT void _stdcall _SetVideoSubtype ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetVideoVisibleWhenStopped ( int Sender,  BOOL Value);
      DLLIMPORT void _stdcall _SetVirtualAudioStreamControl ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetVirtualVideoStreamControl ( int Sender,  int Value);
      DLLIMPORT BOOL _stdcall _SetVMR9ImageAdjustmentValue ( int Sender,  BOOL MainDisplay,  TVMR9ImageAdjustment VMR9ControlSetting,  int Value,  BOOL FixRange);
      DLLIMPORT void _stdcall _SetVuMeter ( int Sender,  TVuMeter Value);
      DLLIMPORT void _stdcall _SetVUMeterSetting ( int Sender,  unsigned int ChannelIndex,  TVUMeterSetting VUMeterSetting,  unsigned int Value);
      DLLIMPORT void _stdcall _SetWebcamStillCaptureButton ( int Sender,  TWebcamStillCaptureButton Value);
      DLLIMPORT BOOL _stdcall _SetWindowRecordingByHandle ( int Sender,  int Window_Handle);
      DLLIMPORT BOOL _stdcall _SetWindowRecordingByName ( int Sender,  wchar_t * WindowName,  BOOL ExactMatch);
      DLLIMPORT BOOL _stdcall _SetWindowTransparency ( int Sender,  int WndHandle,  BOOL UseColorKey,  BOOL UseAlpha,  int AlphaValue);
      DLLIMPORT void _stdcall _SetZoomCoeff ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetZoomXCenter ( int Sender,  int Value);
      DLLIMPORT void _stdcall _SetZoomYCenter ( int Sender,  int Value);
      DLLIMPORT BOOL _stdcall _ShowDialog ( int Sender,  TDialog Dialog);
      DLLIMPORT BOOL _stdcall _StartAudioRecording ( int Sender);
      DLLIMPORT BOOL _stdcall _StartAudioRendering ( int Sender);
      DLLIMPORT BOOL _stdcall _StartPreview ( int Sender);
      DLLIMPORT BOOL _stdcall _StartRecording ( int Sender);
      DLLIMPORT BOOL _stdcall _StartReencoding ( int Sender);
      DLLIMPORT BOOL _stdcall _StartSynchronized ( int Sender);
      DLLIMPORT BOOL _stdcall _Stop ( int Sender);
      DLLIMPORT void _stdcall _StopPlayer ( int Sender);
      DLLIMPORT void _stdcall _StopPreview ( int Sender);
      DLLIMPORT void _stdcall _StopRecording ( int Sender);
      DLLIMPORT BOOL _stdcall _StopReencoding ( int Sender);
      DLLIMPORT BOOL _stdcall _TextOverlay_CreateCustomFont ( int Sender,  int fHeight,  int fWidth,  int fEscapement,  int fOrientation,  int fWeight,  BOOL fItalic,  BOOL fUnderline,  BOOL fStrikeOut,  unsigned int fCharSet,  unsigned int fOutputPrecision,  unsigned int fClipPrecision,  unsigned int fQuality,  unsigned int fPitchAndFamily,  wchar_t * FontFacename);
      DLLIMPORT BOOL _stdcall _ThirdPartyFilter_AddToList ( int Sender,  TThirdPartyFilterList Location,  wchar_t * GUIDString,  wchar_t * OptionalDLLFilePath,  wchar_t * FilterName,  BOOL Enable,  BOOL CanSaveFilterState);
      DLLIMPORT BOOL _stdcall _ThirdPartyFilter_ClearList ( int Sender);
      DLLIMPORT BOOL _stdcall _ThirdPartyFilter_Enable ( int Sender,  TThirdPartyFilterList Location,  wchar_t * GUIDString,  BOOL Enable);
      DLLIMPORT BOOL _stdcall _ThirdPartyFilter_RemoveFromList ( int Sender,  TThirdPartyFilterList Location,  wchar_t * GUIDString);
      DLLIMPORT BOOL _stdcall _ThirdPartyFilter_ShowDialog ( int Sender,  TThirdPartyFilterList Location,  wchar_t * GUIDString);
      DLLIMPORT BOOL _stdcall _TVClearFrequencyOverrides ( int Sender);
      DLLIMPORT BOOL _stdcall _TVGetMinMaxChannels ( int Sender,  int* MinChannel,  int* MaxChannel);
      DLLIMPORT int _stdcall _TVSetChannelFrequencyOverride ( int Sender,  int TVChannel,  int FrequencyInHz);
      DLLIMPORT BOOL _stdcall _TVStartAutoScan ( int Sender);
      DLLIMPORT BOOL _stdcall _TVStartAutoScanChannels ( int Sender,  int MinChannel,  int MaxChannel,  int Interval_ms);
      DLLIMPORT BOOL _stdcall _TVStopAutoScan ( int Sender);
      DLLIMPORT void _stdcall _UseNearestVideoSize ( int Sender,  int PreferredWidth,  int PreferredHeight,  BOOL Stretch);
      DLLIMPORT BOOL _stdcall _VDECGetHorizontalLocked ( int Sender,  int* plLocked);
      DLLIMPORT BOOL _stdcall _VDECGetNumberOfLines ( int Sender,  int* plNumberOfLines);
      DLLIMPORT BOOL _stdcall _VDECGetOutputEnable ( int Sender,  int* plOutputEnable);
      DLLIMPORT BOOL _stdcall _VDECGetVCRHorizontalLocking ( int Sender,  int* plVCRHorizontalLocking);
      DLLIMPORT BOOL _stdcall _VDECPutOutputEnable ( int Sender,  int lOutputEnable);
      DLLIMPORT BOOL _stdcall _VDECPutTVFormat ( int Sender,  int lAnalogVideoStandard);
      DLLIMPORT BOOL _stdcall _VDECPutVCRHorizontalLocking ( int Sender,  int lVCRHorizontalLocking);
      DLLIMPORT int _stdcall _VideoCompressorIndex ( int Sender,  wchar_t * Value);
      DLLIMPORT int _stdcall _VideoDeviceIndex ( int Sender,  wchar_t * Value);
      DLLIMPORT int _stdcall _VideoFormatIndex ( int Sender,  wchar_t * Value);
      DLLIMPORT BOOL _stdcall _VideoFromImages_CreateSetOfBitmaps ( int Sender);
      DLLIMPORT int _stdcall _VideoInputIndex ( int Sender,  wchar_t * Value);
      DLLIMPORT BOOL _stdcall _VideoQualityAuto ( int Sender,  TVideoQuality Setting);
      DLLIMPORT int _stdcall _VideoQualityDefault ( int Sender,  TVideoQuality Setting);
      DLLIMPORT int _stdcall _VideoQualityMax ( int Sender,  TVideoQuality Setting);
      DLLIMPORT int _stdcall _VideoQualityMin ( int Sender,  TVideoQuality Setting);
      DLLIMPORT int _stdcall _VideoQualityStep ( int Sender,  TVideoQuality Setting);
      DLLIMPORT int _stdcall _VideoQualityValue ( int Sender,  TVideoQuality Setting);
      DLLIMPORT int _stdcall _VideoSizeIndex ( int Sender,  wchar_t * Value);
      DLLIMPORT int _stdcall _VideoSubtypeIndex ( int Sender,  wchar_t * Value);
      DLLIMPORT BOOL _stdcall _WriteScriptCommand ( int Sender,  wchar_t * ScriptType,  wchar_t * ScriptArgument);
      #ifdef __cplusplus
         }
      #endif
//#endregion DeclareDLLImport

#ifdef __cplusplus

   class CVideoGrabber 
   {
      private:
	   int  m_VideoGrabber;
   public:
      CVideoGrabber () { 
        m_VideoGrabber = _CreateVideoGrabber ((int) this);
      };

      CVideoGrabber (void* classPtr) { 
         m_VideoGrabber = _CreateVideoGrabber ((int) classPtr);
      };

      ~CVideoGrabber () {
        _DestroyVideoGrabber (m_VideoGrabber);
        m_VideoGrabber = NULL; 
      };
                                     
      //#region BuildFunctions
                  void About () {  _About (m_VideoGrabber); };
                  int AnalogVideoStandardIndex (wchar_t * Value) {  return _AnalogVideoStandardIndex (m_VideoGrabber, Value); };
                  void ASFStreaming_GetAuthorizationList () {  _ASFStreaming_GetAuthorizationList (m_VideoGrabber); };
                  void ASFStreaming_GetConnectedClients () {  _ASFStreaming_GetConnectedClients (m_VideoGrabber); };
                  int ASFStreaming_GetConnectedClientsCount () {  return _ASFStreaming_GetConnectedClientsCount (m_VideoGrabber); };
                  BOOL ASFStreaming_ResetAuthorizations () {  return _ASFStreaming_ResetAuthorizations (m_VideoGrabber); };
                  BOOL ASFStreaming_SetAuthorization (BOOL Allowed, wchar_t * IP, wchar_t * Mask) {  return _ASFStreaming_SetAuthorization (m_VideoGrabber, Allowed, IP, Mask); };
                  BOOL AssociateMultiplexedSlave (int InputNumber, int SlaveUniqueID) {  return _AssociateMultiplexedSlave (m_VideoGrabber, InputNumber, SlaveUniqueID); };
                  int AudioCompressorIndex (wchar_t * Value) {  return _AudioCompressorIndex (m_VideoGrabber, Value); };
                  int AudioDeviceIndex (wchar_t * Value) {  return _AudioDeviceIndex (m_VideoGrabber, Value); };
                  int AudioInputIndex (wchar_t * Value) {  return _AudioInputIndex (m_VideoGrabber, Value); };
                  int AudioRendererIndex (wchar_t * Value) {  return _AudioRendererIndex (m_VideoGrabber, Value); };
                  BOOL AVIDuration (wchar_t * AVIFile, __int64* Duration, __int64* FrameCount) {  return _AVIDuration (m_VideoGrabber, AVIFile, Duration, FrameCount); };
                  void AVIHeaderInfo (wchar_t * AVIFile, THeaderAttribute HeaderAttribute) {  _AVIHeaderInfo (m_VideoGrabber, AVIFile, HeaderAttribute); };
                  BOOL AVIInfo (wchar_t * AVIFile, __int64* Duration, __int64* FrameCount, int* _VideoWidth, int* _VideoHeight, double* VideoFrameRateFps, int* AvgBitRate, int* AudioChannels, int* AudioSamplesPerSec, int* AudioBitsPerSample, wchar_t ** VideoCodec, wchar_t ** AudioCodec) {  return _AVIInfo (m_VideoGrabber, AVIFile, Duration, FrameCount, _VideoWidth, _VideoHeight, VideoFrameRateFps, AvgBitRate, AudioChannels, AudioSamplesPerSec, AudioBitsPerSample, VideoCodec, AudioCodec); };
                  void AVIInfo2 (wchar_t * AVIFile, TAVIInfoType AVIInfoType) {  _AVIInfo2 (m_VideoGrabber, AVIFile, AVIInfoType); };
                  BOOL CameraControlAuto (TCameraControl Setting) {  return _CameraControlAuto (m_VideoGrabber, Setting); };
                  int CameraControlDefault (TCameraControl Setting) {  return _CameraControlDefault (m_VideoGrabber, Setting); };
                  int CameraControlMax (TCameraControl Setting) {  return _CameraControlMax (m_VideoGrabber, Setting); };
                  int CameraControlMin (TCameraControl Setting) {  return _CameraControlMin (m_VideoGrabber, Setting); };
                  int CameraControlStep (TCameraControl Setting) {  return _CameraControlStep (m_VideoGrabber, Setting); };
                  int CameraControlValue (TCameraControl Setting) {  return _CameraControlValue (m_VideoGrabber, Setting); };
                  BOOL Cancel () {  return _Cancel (m_VideoGrabber); };
                  BOOL CanProcessMessages () {  return _CanProcessMessages (m_VideoGrabber); };
                  BOOL CaptureFrameSyncTo (TFrameCaptureDest Dest, wchar_t * FileName) {  return _CaptureFrameSyncTo (m_VideoGrabber, Dest, FileName); };
                  BOOL CaptureFrameTo (TFrameCaptureDest Dest, wchar_t * FileName) {  return _CaptureFrameTo (m_VideoGrabber, Dest, FileName); };
                  void ClearHeaderAttributes () {  _ClearHeaderAttributes (m_VideoGrabber); };
                  void ClosePlayer () {  _ClosePlayer (m_VideoGrabber); };
                  void ContinueProcessing () {  _ContinueProcessing (m_VideoGrabber); };
                  BOOL CreatePreallocCapFile () {  return _CreatePreallocCapFile (m_VideoGrabber); };
                  void Display_SetLocation (int WindowLeft, int WindowTop, int WindowWidth, int WindowHeight) {  _Display_SetLocation (m_VideoGrabber, WindowLeft, WindowTop, WindowWidth, WindowHeight); };
                  BOOL DrawBitmapOverFrame (int BitmapHandle, BOOL Stretched, int LeftLocation, int TopLocation, int bmWidth, int bmHeight, BOOL Transparent, BOOL UseTransparentColor, int TransparentColorValue, BOOL AlphaBlend, int AlphaBlendValue, BOOL ChromaKey, int ChromaKeyRGBColor, int ChromaKeyLeewayPercent) {  return _DrawBitmapOverFrame (m_VideoGrabber, BitmapHandle, Stretched, LeftLocation, TopLocation, bmWidth, bmHeight, Transparent, UseTransparentColor, TransparentColorValue, AlphaBlend, AlphaBlendValue, ChromaKey, ChromaKeyRGBColor, ChromaKeyLeewayPercent); };
                  void DualDisplay_SetLocation (int WindowLeft, int WindowTop, int WindowWidth, int WindowHeight) {  _DualDisplay_SetLocation (m_VideoGrabber, WindowLeft, WindowTop, WindowWidth, WindowHeight); };
                  double DVDInfo (wchar_t * DVDRootDirectory, TDVDInfoType DVDInfoType, int TitleNumber) {  return _DVDInfo (m_VideoGrabber, DVDRootDirectory, DVDInfoType, TitleNumber); };
                  BOOL EnableMultiplexedInput (int InputNumber, BOOL Enable) {  return _EnableMultiplexedInput (m_VideoGrabber, InputNumber, Enable); };
                  BOOL EnumerateWindows () {  return _EnumerateWindows (m_VideoGrabber); };
                  void FastForwardPlayer () {  _FastForwardPlayer (m_VideoGrabber); };
                  int FindIndexInListByName (wchar_t * List, wchar_t * SearchedString, BOOL IsSubString, BOOL IgnoreCase) {  return _FindIndexInListByName (m_VideoGrabber, List, SearchedString, IsSubString, IgnoreCase); };
                  int GetFrameInfo (int FrameId, TFrameInfoId FrameInfoId) {  return _GetFrameInfo (m_VideoGrabber, FrameId, FrameInfoId); };
                  void GetFrameInfoString (TFrameInfoStringId FrameInfoStringId) {  _GetFrameInfoString (m_VideoGrabber, FrameInfoStringId); };
                  void GetItemNameFromList (wchar_t * List, int ItemIndex) {  _GetItemNameFromList (m_VideoGrabber, List, ItemIndex); };
                  int GetLastFrameAsHBITMAP (int BufferIndex, BOOL WithOverlays, int SrcLeftLocation, int SrcTopLocation, int SrcWidth, int SrcHeight, int DestWidth, int DestHeight, int BitmapColorBitCount) {  return _GetLastFrameAsHBITMAP (m_VideoGrabber, BufferIndex, WithOverlays, SrcLeftLocation, SrcTopLocation, SrcWidth, SrcHeight, DestWidth, DestHeight, BitmapColorBitCount); };
                  void GetLogString (TLogType Value) {  _GetLogString (m_VideoGrabber, Value); };
                  int GetMiscDeviceControl (TMiscDeviceControl MiscDeviceControl, int Index) {  return _GetMiscDeviceControl (m_VideoGrabber, MiscDeviceControl, Index); };
                  int GetNearestVideoHeight (int PreferredVideoWidth, int PreferredVideoHeight) {  return _GetNearestVideoHeight (m_VideoGrabber, PreferredVideoWidth, PreferredVideoHeight); };
                  void GetNearestVideoSize (int PreferredVideoWidth, int PreferredVideoHeight, int* NearestVideoWidth, int* NearestVideoHeight) {  _GetNearestVideoSize (m_VideoGrabber, PreferredVideoWidth, PreferredVideoHeight, NearestVideoWidth, NearestVideoHeight); };
                  int GetNearestVideoWidth (int PreferredVideoWidth, int PreferredVideoHeight) {  return _GetNearestVideoWidth (m_VideoGrabber, PreferredVideoWidth, PreferredVideoHeight); };
                  double GetPixelsDistance (int x1, int y1, int x2, int y2) {  return _GetPixelsDistance (m_VideoGrabber, x1, y1, x2, y2); };
                  void GetPlaylist () {  _GetPlaylist (m_VideoGrabber); };
                  int GetRGBPixelAt (int x, int y) {  return _GetRGBPixelAt (m_VideoGrabber, x, y); };
                  BOOL GetTranslatedCoordinates (int DisplayIndex, int NativeX, int NativeY, int* TranslatedX, int* TranslatedY) {  return _GetTranslatedCoordinates (m_VideoGrabber, DisplayIndex, NativeX, NativeY, TranslatedX, TranslatedY); };
                  int GeTTVChannelInfo (TTVChannelInfo Value) {  return _GeTTVChannelInfo (m_VideoGrabber, Value); };
                  BOOL GetVideoCompressionSettings (int* DataRate, int* KeyFrameRate, int* PFramesPerKeyFrame, int* WindowSize, double* Quality, BOOL* CanQuality, BOOL* CanCrunch, BOOL* CanKeyFrame, BOOL* CanBFrame, BOOL* CanWindow) {  return _GetVideoCompressionSettings (m_VideoGrabber, DataRate, KeyFrameRate, PFramesPerKeyFrame, WindowSize, Quality, CanQuality, CanCrunch, CanKeyFrame, CanBFrame, CanWindow); };
                  int GetVideoHeightFromIndex (int Index) {  return _GetVideoHeightFromIndex (m_VideoGrabber, Index); };
                  BOOL GetVideoSizeFromIndex (int Index, int* _VideoWidth, int* _VideoHeight) {  return _GetVideoSizeFromIndex (m_VideoGrabber, Index, _VideoWidth, _VideoHeight); };
                  int GetVideoWidthFromIndex (int Index) {  return _GetVideoWidthFromIndex (m_VideoGrabber, Index); };
                  BOOL GetVMR9ImageAdjustmentBounds (BOOL MainDisplay, TVMR9ImageAdjustment VMR9ControlSetting, int* MinValue, int* MaxValue, int* StepSize, int* DefaultValue, int* CurrentValue) {  return _GetVMR9ImageAdjustmentBounds (m_VideoGrabber, MainDisplay, VMR9ControlSetting, MinValue, MaxValue, StepSize, DefaultValue, CurrentValue); };
                  unsigned int GetVUMeterSetting (unsigned int ChannelIndex, TVUMeterSetting VUMeterSetting) {  return _GetVUMeterSetting (m_VideoGrabber, ChannelIndex, VUMeterSetting); };
                  TGraphState GraphState () {  return _GraphState (m_VideoGrabber); };
                  BOOL IsAudioDeviceASoundCard (int DeviceIndex) {  return _IsAudioDeviceASoundCard (m_VideoGrabber, DeviceIndex); };
                  BOOL IsAudioDeviceConnected (int DeviceIndex) {  return _IsAudioDeviceConnected (m_VideoGrabber, DeviceIndex); };
                  BOOL IsAudioRendererConnected (int RendererIndex) {  return _IsAudioRendererConnected (m_VideoGrabber, RendererIndex); };
                  BOOL IsCameraControlSettingAvailable (TCameraControl Setting) {  return _IsCameraControlSettingAvailable (m_VideoGrabber, Setting); };
                  BOOL IsDialogAvailable (TDialog Dialog) {  return _IsDialogAvailable (m_VideoGrabber, Dialog); };
                  BOOL IsDirectX8OrHigherInstalled () {  return _IsDirectX8OrHigherInstalled (m_VideoGrabber); };
                  BOOL IsDVDevice (int Index) {  return _IsDVDevice (m_VideoGrabber, Index); };
                  BOOL IsPlaylistActive () {  return _IsPlaylistActive (m_VideoGrabber); };
                  BOOL IsVideoControlModeAvailable (TVideoControl Mode) {  return _IsVideoControlModeAvailable (m_VideoGrabber, Mode); };
                  BOOL IsVideoDeviceConnected (int DeviceIndex) {  return _IsVideoDeviceConnected (m_VideoGrabber, DeviceIndex); };
                  BOOL IsVideoQualitySettingAvailable (TVideoQuality Setting) {  return _IsVideoQualitySettingAvailable (m_VideoGrabber, Setting); };
                  BOOL IsVideoSignalDetected (BOOL DetectConnexantBlueScreen, BOOL DetectCustomRGB, int CustomR, int CustomG, int CustomB, BOOL UseAsMaxValues) {  return _IsVideoSignalDetected (m_VideoGrabber, DetectConnexantBlueScreen, DetectCustomRGB, CustomR, CustomG, CustomB, UseAsMaxValues); };
                  BOOL IsVMR9ImageAdjustmentAvailable (BOOL MainDisplay) {  return _IsVMR9ImageAdjustmentAvailable (m_VideoGrabber, MainDisplay); };
                  BOOL LoadCompressorSettingsFromDataString (BOOL IsVideoCompressor, int CompressorIndex, wchar_t * DataString) {  return _LoadCompressorSettingsFromDataString (m_VideoGrabber, IsVideoCompressor, CompressorIndex, DataString); };
                  BOOL LoadCompressorSettingsFromTextFile (BOOL IsVideoCompressor, int CompressorIndex, wchar_t * FileName) {  return _LoadCompressorSettingsFromTextFile (m_VideoGrabber, IsVideoCompressor, CompressorIndex, FileName); };
                  BOOL MixAudioSamples (int pSampleBuffer, int SampleBufferSize, int SampleDataLength, TFormatType SampleFormatType, int pFormat, __int64 SampleStartTime, __int64 SampleStopTime) {  return _MixAudioSamples (m_VideoGrabber, pSampleBuffer, SampleBufferSize, SampleDataLength, SampleFormatType, pFormat, SampleStartTime, SampleStopTime); };
                  BOOL Mixer_Activation (int Id, BOOL Activate) {  return _Mixer_Activation (m_VideoGrabber, Id, Activate); };
                  int Mixer_AddAudioToMixer (int SourceUniqueID) {  return _Mixer_AddAudioToMixer (m_VideoGrabber, SourceUniqueID); };
                  int Mixer_AddToMixer (int SourceUniqueID, int SourceVideoInput, int MosaicLine, int MosaicColumn, int AlternatedGroup, int AlternatedTimeIntervalInMs, BOOL ReplacePreviouslyAdded, BOOL CanEraseBackground) {  return _Mixer_AddToMixer (m_VideoGrabber, SourceUniqueID, SourceVideoInput, MosaicLine, MosaicColumn, AlternatedGroup, AlternatedTimeIntervalInMs, ReplacePreviouslyAdded, CanEraseBackground); };
                  BOOL Mixer_AudioActivation (int Id, BOOL Activate) {  return _Mixer_AudioActivation (m_VideoGrabber, Id, Activate); };
                  BOOL Mixer_RemoveAudioFromMixer (int Id) {  return _Mixer_RemoveAudioFromMixer (m_VideoGrabber, Id); };
                  BOOL Mixer_RemoveFromMixer (int Id) {  return _Mixer_RemoveFromMixer (m_VideoGrabber, Id); };
                  int Mixer_SetupPIPFromSource (int SourceUniqueID, int Source_Left, int Source_Top, int Source_Width, int Source_Height, BOOL ActivatePIP, int PIP_Left, int PIP_Top, int PIP_Width, int PIP_Height, BOOL MoveToTop) {  return _Mixer_SetupPIPFromSource (m_VideoGrabber, SourceUniqueID, Source_Left, Source_Top, Source_Width, Source_Height, ActivatePIP, PIP_Left, PIP_Top, PIP_Width, PIP_Height, MoveToTop); };
                  BOOL MonitorBounds (int MonitorNumber, int* LeftBound, int* TopBound, int* RightBound, int* BottomBound) {  return _MonitorBounds (m_VideoGrabber, MonitorNumber, LeftBound, TopBound, RightBound, BottomBound); };
                  int MonitorsCount () {  return _MonitorsCount (m_VideoGrabber); };
                  int MotionDetector_CellColorIntensity (TRGBSelector RGBSelector, int x, int y) {  return _MotionDetector_CellColorIntensity (m_VideoGrabber, RGBSelector, x, y); };
                  double MotionDetector_CellMotionRatio (int x, int y) {  return _MotionDetector_CellMotionRatio (m_VideoGrabber, x, y); };
                  void MotionDetector_Get2DTextGrid () {  _MotionDetector_Get2DTextGrid (m_VideoGrabber); };
                  void MotionDetector_Get2DTextMotion () {  _MotionDetector_Get2DTextMotion (m_VideoGrabber); };
                  BOOL MotionDetector_GetCellLocation (int x, int y, int* XLocation, int* YLocation) {  return _MotionDetector_GetCellLocation (m_VideoGrabber, x, y, XLocation, YLocation); };
                  BOOL MotionDetector_GetCellSensitivity (int x, int y, int* Value) {  return _MotionDetector_GetCellSensitivity (m_VideoGrabber, x, y, Value); };
                  BOOL MotionDetector_GetCellSize (int* XSize, int* YSize) {  return _MotionDetector_GetCellSize (m_VideoGrabber, XSize, YSize); };
                  int MotionDetector_GlobalColorIntensity (TRGBSelector RGBSelector) {  return _MotionDetector_GlobalColorIntensity (m_VideoGrabber, RGBSelector); };
                  void MotionDetector_GloballyIncOrDecSensitivity (int Value) {  _MotionDetector_GloballyIncOrDecSensitivity (m_VideoGrabber, Value); };
                  void MotionDetector_Reset () {  _MotionDetector_Reset (m_VideoGrabber); };
                  void MotionDetector_ResetGlobalSensitivity (int Value) {  _MotionDetector_ResetGlobalSensitivity (m_VideoGrabber, Value); };
                  BOOL MotionDetector_SetCellSensitivity (int x, int y, int Value) {  return _MotionDetector_SetCellSensitivity (m_VideoGrabber, x, y, Value); };
                  void MotionDetector_SetGridSize (int x, int y) {  _MotionDetector_SetGridSize (m_VideoGrabber, x, y); };
                  void MotionDetector_ShowGridDialog () {  _MotionDetector_ShowGridDialog (m_VideoGrabber); };
                  void MotionDetector_TriggerNow () {  _MotionDetector_TriggerNow (m_VideoGrabber); };
                  BOOL MotionDetector_UseThisReferenceSample (int Bitmap_, wchar_t * BMPFile, wchar_t * JPEGFile) {  return _MotionDetector_UseThisReferenceSample (m_VideoGrabber, Bitmap_, BMPFile, JPEGFile); };
                  int MPEGProgramSetting (TMPEGProgramSetting MPEGProgramSetting, int Value) {  return _MPEGProgramSetting (m_VideoGrabber, MPEGProgramSetting, Value); };
                  int MultiplexerIndex (wchar_t * Value) {  return _MultiplexerIndex (m_VideoGrabber, Value); };
                  void NotifyPlayerTrackbarAction (TTrackbarAction TrackbarAction) {  _NotifyPlayerTrackbarAction (m_VideoGrabber, TrackbarAction); };
                  BOOL OpenDVD () {  return _OpenDVD (m_VideoGrabber); };
                  BOOL OpenPlayer () {  return _OpenPlayer (m_VideoGrabber); };
                  BOOL OpenPlayerAtFramePositions (__int64 StartFrame, __int64 StopFrame, BOOL KeepBounds, BOOL CloseAndReopenIfAlreadyOpened) {  return _OpenPlayerAtFramePositions (m_VideoGrabber, StartFrame, StopFrame, KeepBounds, CloseAndReopenIfAlreadyOpened); };
                  BOOL OpenPlayerAtTimePositions (__int64 StartTime, __int64 StopTime, BOOL KeepBounds, BOOL CloseAndReopenIfAlreadyOpened) {  return _OpenPlayerAtTimePositions (m_VideoGrabber, StartTime, StopTime, KeepBounds, CloseAndReopenIfAlreadyOpened); };
                  void PausePlayer () {  _PausePlayer (m_VideoGrabber); };
                  BOOL PausePreview () {  return _PausePreview (m_VideoGrabber); };
                  BOOL PauseRecording () {  return _PauseRecording (m_VideoGrabber); };
                  BOOL PlayerFrameStep (int FrameCount) {  return _PlayerFrameStep (m_VideoGrabber, FrameCount); };
                  BOOL Playlist (TPlaylist PlaylistAction, wchar_t * VideoClip) {  return _Playlist (m_VideoGrabber, PlaylistAction, VideoClip); };
                  int PointGreyConfig (TPointGreyConfig ConfigType, unsigned int* PGRActionValue, unsigned int ulRegister, unsigned int ulMode, unsigned int ulLeft, unsigned int ulTop, unsigned int ulWidth, unsigned int ulHeight, unsigned int ulPercentage, unsigned int ulFormat) {  return _PointGreyConfig (m_VideoGrabber, ConfigType, PGRActionValue, ulRegister, ulMode, ulLeft, ulTop, ulWidth, ulHeight, ulPercentage, ulFormat); };
                  BOOL PutMiscDeviceControl (TMiscDeviceControl MiscDeviceControl, int Index, int Value) {  return _PutMiscDeviceControl (m_VideoGrabber, MiscDeviceControl, Index, Value); };
                  unsigned int RecordingKBytesWrittenToDisk () {  return _RecordingKBytesWrittenToDisk (m_VideoGrabber); };
                  BOOL RecordToNewFileNow (wchar_t * NewRecordingFileName, BOOL ResetStreamTime) {  return _RecordToNewFileNow (m_VideoGrabber, NewRecordingFileName, ResetStreamTime); };
                  BOOL ReencodeVideoClip (wchar_t * SourceVideoClip, wchar_t * NewVideoClip, BOOL IncludeVideoStream, BOOL IncludeAudioStream, BOOL UseFrameGrabber, BOOL UseCurrentVideoCompressor, BOOL UseCurrentAudioCompressor) {  return _ReencodeVideoClip (m_VideoGrabber, SourceVideoClip, NewVideoClip, IncludeVideoStream, IncludeAudioStream, UseFrameGrabber, UseCurrentVideoCompressor, UseCurrentAudioCompressor); };
                  void RefreshDevicesAndCompressorsLists () {  _RefreshDevicesAndCompressorsLists (m_VideoGrabber); };
                  void RefreshPlayerOverlays () {  _RefreshPlayerOverlays (m_VideoGrabber); };
                  BOOL ResetPreview () {  return _ResetPreview (m_VideoGrabber); };
                  BOOL ResetVideoDeviceSettings () {  return _ResetVideoDeviceSettings (m_VideoGrabber); };
                  BOOL ResumePreview () {  return _ResumePreview (m_VideoGrabber); };
                  BOOL ResumeRecording () {  return _ResumeRecording (m_VideoGrabber); };
                  void RetrieveInitialXYAfterRotation (int X, int Y, int* OriginalX, int* OriginalY) {  _RetrieveInitialXYAfterRotation (m_VideoGrabber, X, Y, OriginalX, OriginalY); };
                  void RewindPlayer () {  _RewindPlayer (m_VideoGrabber); };
                  void RunPlayer () {  _RunPlayer (m_VideoGrabber); };
                  void RunPlayerBackwards () {  _RunPlayerBackwards (m_VideoGrabber); };
                  void SaveCompressorSettingsToDataString (BOOL IsVideoCompressor, int CompressorIndex) {  _SaveCompressorSettingsToDataString (m_VideoGrabber, IsVideoCompressor, CompressorIndex); };
                  BOOL SaveCompressorSettingsToTextFile (BOOL IsVideoCompressor, int CompressorIndex, wchar_t * FileName) {  return _SaveCompressorSettingsToTextFile (m_VideoGrabber, IsVideoCompressor, CompressorIndex, FileName); };
                  BOOL ScreenRecordingUsingCoordinates (BOOL FunctionEnabled, int scLeft, int scTop, int scWidth, int scHeight) {  return _ScreenRecordingUsingCoordinates (m_VideoGrabber, FunctionEnabled, scLeft, scTop, scWidth, scHeight); };
                  BOOL SendCameraCommand (int Pan, int Tilt, BOOL Relative) {  return _SendCameraCommand (m_VideoGrabber, Pan, Tilt, Relative); };
                  BOOL SendDVCommand (TDVCommand DVCommand) {  return _SendDVCommand (m_VideoGrabber, DVCommand); };
                  BOOL SendImageToVideoFromBitmaps (wchar_t * ImageFilePath, int BitmapHandle, BOOL CanFreeBitmapHandle, BOOL EndOfData) {  return _SendImageToVideoFromBitmaps (m_VideoGrabber, ImageFilePath, BitmapHandle, CanFreeBitmapHandle, EndOfData); };
                  BOOL SendIPCameraCommand (wchar_t * IPCameraCommand) {  return _SendIPCameraCommand (m_VideoGrabber, IPCameraCommand); };
                  void Set_OnDeviceArrivalOrRemoval (int Value) {  _Set_OnDeviceArrivalOrRemoval (m_VideoGrabber, Value); };
                  void SetAuthentication (TAuthenticationType AuthenticationType, wchar_t * UserName, wchar_t * Password) {  _SetAuthentication (m_VideoGrabber, AuthenticationType, UserName, Password); };
                  void SetAVIMuxConfig (TAVIMuxConfig AVIMuxSetting, int Value) {  _SetAVIMuxConfig (m_VideoGrabber, AVIMuxSetting, Value); };
                  BOOL SetCameraControl (TCameraControl Setting, BOOL SetAuto, BOOL SetDefault, int SetValue) {  return _SetCameraControl (m_VideoGrabber, Setting, SetAuto, SetDefault, SetValue); };
                  void SetFrameCaptureBounds (int LeftPosition, int TopPosition, int RightPosition, int BottomPosition) {  _SetFrameCaptureBounds (m_VideoGrabber, LeftPosition, TopPosition, RightPosition, BottomPosition); };
                  void SetHeaderAttribute (THeaderAttribute HeaderAttribute, wchar_t * Value) {  _SetHeaderAttribute (m_VideoGrabber, HeaderAttribute, Value); };
                  void SetImageOverlayAttributes (int LeftLocation, int TopLocation, int StretchedWidth, int StretchedHeight, BOOL Transparent, BOOL UseTransparentColor, int TransparentColorValue, BOOL AlphaBlend, int AlphaBlendValue) {  _SetImageOverlayAttributes (m_VideoGrabber, LeftLocation, TopLocation, StretchedWidth, StretchedHeight, Transparent, UseTransparentColor, TransparentColorValue, AlphaBlend, AlphaBlendValue); };
                  BOOL SetImageOverlayFromBMPFile (wchar_t * FileName) {  return _SetImageOverlayFromBMPFile (m_VideoGrabber, FileName); };
                  BOOL SetImageOverlayFromHBitmap (int Bitmap) {  return _SetImageOverlayFromHBitmap (m_VideoGrabber, Bitmap); };
                  BOOL SetImageOverlayFromImageFile (wchar_t * FileName) {  return _SetImageOverlayFromImageFile (m_VideoGrabber, FileName); };
                  BOOL SetImageOverlayFromJPEGFile (wchar_t * FileName) {  return _SetImageOverlayFromJPEGFile (m_VideoGrabber, FileName); };
                  BOOL SetIPCameraSetting (TIPCameraSetting Setting, int Value) {  return _SetIPCameraSetting (m_VideoGrabber, Setting, Value); };
                  void SetLocation (int lLeft, int lTop, int lWidth, int lHeight) {  _SetLocation (m_VideoGrabber, lLeft, lTop, lWidth, lHeight); };
                  BOOL SetLogoFromBMPFile (wchar_t * FileName) {  return _SetLogoFromBMPFile (m_VideoGrabber, FileName); };
                  BOOL SetLogoFromHBitmap (int Bitmap) {  return _SetLogoFromHBitmap (m_VideoGrabber, Bitmap); };
                  BOOL SetLogoFromJPEGFile (wchar_t * FileName) {  return _SetLogoFromJPEGFile (m_VideoGrabber, FileName); };
                  void SetMultiplexerFilterByName (wchar_t * Value) {  _SetMultiplexerFilterByName (m_VideoGrabber, Value); };
                  void SetParentWindow (int Value) {  _SetParentWindow (m_VideoGrabber, Value); };
                  void SetTextOverlayCustomVar (int TextOverlaySelector, int VarIndex, wchar_t * VarText) {  _SetTextOverlayCustomVar (m_VideoGrabber, TextOverlaySelector, VarIndex, VarText); };
                  BOOL SetVideoCompressionDefaults () {  return _SetVideoCompressionDefaults (m_VideoGrabber); };
                  BOOL SetVideoCompressionSettings (int DataRate, int KeyFrameRate, int PFramesPerKeyFrame, int WindowSize, double Quality) {  return _SetVideoCompressionSettings (m_VideoGrabber, DataRate, KeyFrameRate, PFramesPerKeyFrame, WindowSize, Quality); };
                  BOOL SetVideoControlMode (BOOL FlipHorizontal, BOOL FlipVertical, BOOL ExternalTriggerEnable, BOOL Trigger) {  return _SetVideoControlMode (m_VideoGrabber, FlipHorizontal, FlipVertical, ExternalTriggerEnable, Trigger); };
                  BOOL SetVideoQuality (TVideoQuality Setting, BOOL SetAuto, BOOL SetDefault, int SetValue) {  return _SetVideoQuality (m_VideoGrabber, Setting, SetAuto, SetDefault, SetValue); };
                  BOOL SetVMR9ImageAdjustmentValue (BOOL MainDisplay, TVMR9ImageAdjustment VMR9ControlSetting, int Value, BOOL FixRange) {  return _SetVMR9ImageAdjustmentValue (m_VideoGrabber, MainDisplay, VMR9ControlSetting, Value, FixRange); };
                  void SetVUMeterSetting (unsigned int ChannelIndex, TVUMeterSetting VUMeterSetting, unsigned int Value) {  _SetVUMeterSetting (m_VideoGrabber, ChannelIndex, VUMeterSetting, Value); };
                  BOOL SetWindowRecordingByHandle (int Window_Handle) {  return _SetWindowRecordingByHandle (m_VideoGrabber, Window_Handle); };
                  BOOL SetWindowRecordingByName (wchar_t * WindowName, BOOL ExactMatch) {  return _SetWindowRecordingByName (m_VideoGrabber, WindowName, ExactMatch); };
                  BOOL SetWindowTransparency (int WndHandle, BOOL UseColorKey, BOOL UseAlpha, int AlphaValue) {  return _SetWindowTransparency (m_VideoGrabber, WndHandle, UseColorKey, UseAlpha, AlphaValue); };
                  BOOL ShowDialog (TDialog Dialog) {  return _ShowDialog (m_VideoGrabber, Dialog); };
                  BOOL StartAudioRecording () {  return _StartAudioRecording (m_VideoGrabber); };
                  BOOL StartAudioRendering () {  return _StartAudioRendering (m_VideoGrabber); };
                  BOOL StartPreview () {  return _StartPreview (m_VideoGrabber); };
                  BOOL StartRecording () {  return _StartRecording (m_VideoGrabber); };
                  BOOL StartReencoding () {  return _StartReencoding (m_VideoGrabber); };
                  BOOL StartSynchronized () {  return _StartSynchronized (m_VideoGrabber); };
                  BOOL Stop () {  return _Stop (m_VideoGrabber); };
                  void StopPlayer () {  _StopPlayer (m_VideoGrabber); };
                  void StopPreview () {  _StopPreview (m_VideoGrabber); };
                  void StopRecording () {  _StopRecording (m_VideoGrabber); };
                  BOOL StopReencoding () {  return _StopReencoding (m_VideoGrabber); };
                  BOOL TextOverlay_CreateCustomFont (int fHeight, int fWidth, int fEscapement, int fOrientation, int fWeight, BOOL fItalic, BOOL fUnderline, BOOL fStrikeOut, unsigned int fCharSet, unsigned int fOutputPrecision, unsigned int fClipPrecision, unsigned int fQuality, unsigned int fPitchAndFamily, wchar_t * FontFacename) {  return _TextOverlay_CreateCustomFont (m_VideoGrabber, fHeight, fWidth, fEscapement, fOrientation, fWeight, fItalic, fUnderline, fStrikeOut, fCharSet, fOutputPrecision, fClipPrecision, fQuality, fPitchAndFamily, FontFacename); };
                  BOOL ThirdPartyFilter_AddToList (TThirdPartyFilterList Location, wchar_t * GUIDString, wchar_t * OptionalDLLFilePath, wchar_t * FilterName, BOOL Enable, BOOL CanSaveFilterState) {  return _ThirdPartyFilter_AddToList (m_VideoGrabber, Location, GUIDString, OptionalDLLFilePath, FilterName, Enable, CanSaveFilterState); };
                  BOOL ThirdPartyFilter_ClearList () {  return _ThirdPartyFilter_ClearList (m_VideoGrabber); };
                  BOOL ThirdPartyFilter_Enable (TThirdPartyFilterList Location, wchar_t * GUIDString, BOOL Enable) {  return _ThirdPartyFilter_Enable (m_VideoGrabber, Location, GUIDString, Enable); };
                  BOOL ThirdPartyFilter_RemoveFromList (TThirdPartyFilterList Location, wchar_t * GUIDString) {  return _ThirdPartyFilter_RemoveFromList (m_VideoGrabber, Location, GUIDString); };
                  BOOL ThirdPartyFilter_ShowDialog (TThirdPartyFilterList Location, wchar_t * GUIDString) {  return _ThirdPartyFilter_ShowDialog (m_VideoGrabber, Location, GUIDString); };
                  BOOL TVClearFrequencyOverrides () {  return _TVClearFrequencyOverrides (m_VideoGrabber); };
                  BOOL TVGetMinMaxChannels (int* MinChannel, int* MaxChannel) {  return _TVGetMinMaxChannels (m_VideoGrabber, MinChannel, MaxChannel); };
                  int TVSetChannelFrequencyOverride (int TVChannel, int FrequencyInHz) {  return _TVSetChannelFrequencyOverride (m_VideoGrabber, TVChannel, FrequencyInHz); };
                  BOOL TVStartAutoScan () {  return _TVStartAutoScan (m_VideoGrabber); };
                  BOOL TVStartAutoScanChannels (int MinChannel, int MaxChannel, int Interval_ms) {  return _TVStartAutoScanChannels (m_VideoGrabber, MinChannel, MaxChannel, Interval_ms); };
                  BOOL TVStopAutoScan () {  return _TVStopAutoScan (m_VideoGrabber); };
                  void UseNearestVideoSize (int PreferredWidth, int PreferredHeight, BOOL Stretch) {  _UseNearestVideoSize (m_VideoGrabber, PreferredWidth, PreferredHeight, Stretch); };
                  BOOL VDECGetHorizontalLocked (int* plLocked) {  return _VDECGetHorizontalLocked (m_VideoGrabber, plLocked); };
                  BOOL VDECGetNumberOfLines (int* plNumberOfLines) {  return _VDECGetNumberOfLines (m_VideoGrabber, plNumberOfLines); };
                  BOOL VDECGetOutputEnable (int* plOutputEnable) {  return _VDECGetOutputEnable (m_VideoGrabber, plOutputEnable); };
                  BOOL VDECGetVCRHorizontalLocking (int* plVCRHorizontalLocking) {  return _VDECGetVCRHorizontalLocking (m_VideoGrabber, plVCRHorizontalLocking); };
                  BOOL VDECPutOutputEnable (int lOutputEnable) {  return _VDECPutOutputEnable (m_VideoGrabber, lOutputEnable); };
                  BOOL VDECPutTVFormat (int lAnalogVideoStandard) {  return _VDECPutTVFormat (m_VideoGrabber, lAnalogVideoStandard); };
                  BOOL VDECPutVCRHorizontalLocking (int lVCRHorizontalLocking) {  return _VDECPutVCRHorizontalLocking (m_VideoGrabber, lVCRHorizontalLocking); };
                  int VideoCompressorIndex (wchar_t * Value) {  return _VideoCompressorIndex (m_VideoGrabber, Value); };
                  int VideoDeviceIndex (wchar_t * Value) {  return _VideoDeviceIndex (m_VideoGrabber, Value); };
                  int VideoFormatIndex (wchar_t * Value) {  return _VideoFormatIndex (m_VideoGrabber, Value); };
                  BOOL VideoFromImages_CreateSetOfBitmaps () {  return _VideoFromImages_CreateSetOfBitmaps (m_VideoGrabber); };
                  int VideoInputIndex (wchar_t * Value) {  return _VideoInputIndex (m_VideoGrabber, Value); };
                  BOOL VideoQualityAuto (TVideoQuality Setting) {  return _VideoQualityAuto (m_VideoGrabber, Setting); };
                  int VideoQualityDefault (TVideoQuality Setting) {  return _VideoQualityDefault (m_VideoGrabber, Setting); };
                  int VideoQualityMax (TVideoQuality Setting) {  return _VideoQualityMax (m_VideoGrabber, Setting); };
                  int VideoQualityMin (TVideoQuality Setting) {  return _VideoQualityMin (m_VideoGrabber, Setting); };
                  int VideoQualityStep (TVideoQuality Setting) {  return _VideoQualityStep (m_VideoGrabber, Setting); };
                  int VideoQualityValue (TVideoQuality Setting) {  return _VideoQualityValue (m_VideoGrabber, Setting); };
                  int VideoSizeIndex (wchar_t * Value) {  return _VideoSizeIndex (m_VideoGrabber, Value); };
                  int VideoSubtypeIndex (wchar_t * Value) {  return _VideoSubtypeIndex (m_VideoGrabber, Value); };
                  BOOL WriteScriptCommand (wchar_t * ScriptType, wchar_t * ScriptArgument) {  return _WriteScriptCommand (m_VideoGrabber, ScriptType, ScriptArgument); };
      //#endregion BuildFunctions
                                                
      //#region DeclareProperties
                  wchar_t * GetAnalogVideoStandards () { return _GetAnalogVideoStandards (m_VideoGrabber); };
                  
                  int GetAnalogVideoStandardsCount () { return _GetAnalogVideoStandardsCount (m_VideoGrabber); };
                  
                  wchar_t * GetASFProfiles () { return _GetASFProfiles (m_VideoGrabber); };
                  
                  int GetASFProfilesCount () { return _GetASFProfilesCount (m_VideoGrabber); };
                  
                  int GetAudioBalance () { return _GetAudioBalance (m_VideoGrabber); };
                  void SetAudioBalance (int Value) { _SetAudioBalance (m_VideoGrabber, Value); };
                  
                  wchar_t * GetAudioCompressorName () { return _GetAudioCompressorName (m_VideoGrabber); };
                  
                  wchar_t * GetAudioCompressors () { return _GetAudioCompressors (m_VideoGrabber); };
                  
                  int GetAudioCompressorsCount () { return _GetAudioCompressorsCount (m_VideoGrabber); };
                  
                  int GetAudioInputBalance () { return _GetAudioInputBalance (m_VideoGrabber); };
                  void SetAudioInputBalance (int Value) { _SetAudioInputBalance (m_VideoGrabber, Value); };
                  
                  int GetAudioInputLevel () { return _GetAudioInputLevel (m_VideoGrabber); };
                  void SetAudioInputLevel (int Value) { _SetAudioInputLevel (m_VideoGrabber, Value); };
                  
                  BOOL GetAudioInputMono () { return _GetAudioInputMono (m_VideoGrabber); };
                  void SetAudioInputMono (BOOL Value) { _SetAudioInputMono (m_VideoGrabber, Value); };
                  
                  wchar_t * GetAudioInputs () { return _GetAudioInputs (m_VideoGrabber); };
                  
                  int GetAudioInputsCount () { return _GetAudioInputsCount (m_VideoGrabber); };
                  
                  wchar_t * GetAudioDeviceName () { return _GetAudioDeviceName (m_VideoGrabber); };
                  
                  wchar_t * GetAudioDevices () { return _GetAudioDevices (m_VideoGrabber); };
                  
                  int GetAudioDevicesCount () { return _GetAudioDevicesCount (m_VideoGrabber); };
                  
                  wchar_t * GetAudioFormats () { return _GetAudioFormats (m_VideoGrabber); };
                  
                  wchar_t * GetAudioRendererName () { return _GetAudioRendererName (m_VideoGrabber); };
                  
                  wchar_t * GetAudioRenderers () { return _GetAudioRenderers (m_VideoGrabber); };
                  
                  int GetAudioRenderersCount () { return _GetAudioRenderersCount (m_VideoGrabber); };
                  
                  int GetAudioVolume () { return _GetAudioVolume (m_VideoGrabber); };
                  void SetAudioVolume (int Value) { _SetAudioVolume (m_VideoGrabber, Value); };
                  
                  int GetBufferCount () { return _GetBufferCount (m_VideoGrabber); };
                  void SetBufferCount (int Value) { _SetBufferCount (m_VideoGrabber, Value); };
                  
                  BOOL GetBusy () { return _GetBusy (m_VideoGrabber); };
                  
                  double GetRecordingDuration () { return _GetRecordingDuration (m_VideoGrabber); };
                  
                  wchar_t * GetRecordingFourCC () { return _GetRecordingFourCC (m_VideoGrabber); };
                  
                  int GetCropping_YMax () { return _GetCropping_YMax (m_VideoGrabber); };
                  
                  int GetCropping_XMax () { return _GetCropping_XMax (m_VideoGrabber); };
                  
                  double GetCurrentFrameRate () { return _GetCurrentFrameRate (m_VideoGrabber); };
                  
                  TCurrentState GetCurrentState () { return _GetCurrentState (m_VideoGrabber); };
                  
                  __int64 GetDeliveredFrames () { return _GetDeliveredFrames (m_VideoGrabber); };
                  
                  wchar_t * GetDirectShowFilters () { return _GetDirectShowFilters (m_VideoGrabber); };
                  
                  int GetDirectShowFiltersCount () { return _GetDirectShowFiltersCount (m_VideoGrabber); };
                  
                  int GetDisplay_VideoHeight () { return _GetDisplay_VideoHeight (m_VideoGrabber); };
                  
                  int GetDisplay_VideoWidth () { return _GetDisplay_VideoWidth (m_VideoGrabber); };
                  
                  int GetDisplay_VideoWindowHandle () { return _GetDisplay_VideoWindowHandle (m_VideoGrabber); };
                  
                  int GetDualDisplay_VideoWindowHandle () { return _GetDualDisplay_VideoWindowHandle (m_VideoGrabber); };
                  
                  int GetDroppedFrames () { return _GetDroppedFrameCount (m_VideoGrabber); };
                  
                  int GetDualDisplay_VideoHeight () { return _GetDualDisplay_VideoHeight (m_VideoGrabber); };
                  
                  int GetDualDisplay_VideoWidth () { return _GetDualDisplay_VideoWidth (m_VideoGrabber); };
                  
                  TFrameGrabberRGBFormat GetFrameGrabberCurrentRGBFormat () { return _GetFrameGrabberCurrentRGBFormat (m_VideoGrabber); };
                  
                  BOOL GetHoldRecording () { return _GetHoldRecording (m_VideoGrabber); };
                  void SetHoldRecording (BOOL Value) { _SetHoldRecording (m_VideoGrabber, Value); };
                  
                  int GetImageOverlaySelector () { return _GetImageOverlaySelector (m_VideoGrabber); };
                  void SetImageOverlaySelector (int Value) { _SetImageOverlaySelector (m_VideoGrabber, Value); };
                  
                  double GetImageRatio () { return _GetImageRatio (m_VideoGrabber); };
                  
                  BOOL GetInFrameProgressEvent () { return _GetInFrameProgressEvent (m_VideoGrabber); };
                  
                  BOOL GetIsAnalogVideoDecoderAvailable () { return _GetIsAnalogVideoDecoderAvailable (m_VideoGrabber); };
                  
                  BOOL GetIsAudioCrossbarAvailable () { return _GetIsAudioCrossbarAvailable (m_VideoGrabber); };
                  
                  TTriState GetIsAudioInputBalanceAvailable () { return _GetIsAudioInputBalanceAvailable (m_VideoGrabber); };
                  
                  BOOL GetIsCameraControlAvailable () { return _GetIsCameraControlAvailable (m_VideoGrabber); };
                  
                  BOOL GetIsDigitalVideoIn () { return _GetIsDigitalVideoIn (m_VideoGrabber); };
                  
                  BOOL GetIsDVCommandAvailable () { return _GetIsDVCommandAvailable (m_VideoGrabber); };
                  
                  BOOL GetIsHorizontalSyncLocked () { return _GetIsHorizontalSyncLocked (m_VideoGrabber); };
                  
                  BOOL GetIsMpegStream () { return _GetIsMpegStream (m_VideoGrabber); };
                  
                  TTriState GetIsPlayerAudioStreamAvailable () { return _GetIsPlayerAudioStreamAvailable (m_VideoGrabber); };
                  
                  TTriState GetIsPlayerVideoStreamAvailable () { return _GetIsPlayerVideoStreamAvailable (m_VideoGrabber); };
                  
                  BOOL GetIsRecordingPaused () { return _GetIsRecordingPaused (m_VideoGrabber); };
                  
                  BOOL GetIsTimeCodeReaderAvailable () { return _GetTimeCodeReaderAvailable (m_VideoGrabber); };
                  
                  BOOL GetIsTVTunerAvailable () { return _GetIsTVTunerAvailable (m_VideoGrabber); };
                  
                  BOOL GetIsTVAutoTuneRunning () { return _GetIsTVAutoTuneRunning (m_VideoGrabber); };
                  
                  BOOL GetIsTVAudioAvailable () { return _GetIsTVAudioAvailable (m_VideoGrabber); };
                  
                  BOOL GetIsVideoControlAvailable () { return _GetIsVideoControlAvailable (m_VideoGrabber); };
                  
                  BOOL GetIsVideoCrossbarAvailable () { return _GetIsVideoCrossbarAvailable (m_VideoGrabber); };
                  
                  BOOL GetIsVideoInterlaced () { return _GetIsVideoInterlaced (m_VideoGrabber); };
                  
                  BOOL GetIsVideoQualityAvailable () { return _GetIsVideoQualityAvailable (m_VideoGrabber); };
                  
                  BOOL GetIsVideoPortAvailable () { return _GetIsVideoPortAvailable (m_VideoGrabber); };
                  
                  BOOL GetIsWDMVideoDriver () { return _GetIsWDMVideoDriver (m_VideoGrabber); };
                  
                  wchar_t * GetLast_BurstFrameCapture_FileName () { return _GetLast_BurstFrameCapture_FileName (m_VideoGrabber); };
                  
                  wchar_t * GetLast_CaptureFrameTo_FileName () { return _GetLast_CaptureFrameTo_FileName (m_VideoGrabber); };
                  
                  wchar_t * GetLast_Recording_FileName () { return _GetLast_Recording_FileName (m_VideoGrabber); };
                  
                  wchar_t * GetLast_Clip_Played () { return _GetLast_Clip_Played (m_VideoGrabber); };
                  
                  double GetMotionDetector_GlobalMotionRatio () { return _GetMotionDetector_GlobalMotionRatio (m_VideoGrabber); };
                  
                  int GetMotionDetector_GridXCount () { return _GetMotionDetector_GridXCount (m_VideoGrabber); };
                  
                  int GetMotionDetector_GridYCount () { return _GetMotionDetector_GridYCount (m_VideoGrabber); };
                  
                  BOOL GetMotionDetector_IsGridValid () { return _GetMotionDetector_IsGridValid (m_VideoGrabber); };
                  
                  TMpegStreamType GetMpegStreamType () { return _GetMpegStreamType (m_VideoGrabber); };
                  void SetMpegStreamType (TMpegStreamType Value) { _SetMpegStreamType (m_VideoGrabber, Value); };
                  
                  wchar_t * GetMultiplexerName () { return _GetMultiplexerName (m_VideoGrabber); };
                  
                  wchar_t * GetMultiplexers () { return _GetMultiplexers (m_VideoGrabber); };
                  
                  int GetMultiplexersCount () { return _GetMultiplexersCount (m_VideoGrabber); };
                  
                  int GetPlaylistIndex () { return _GetPlaylistIndex (m_VideoGrabber); };
                  void SetPlaylistIndex (int Value) { _SetPlaylistIndex (m_VideoGrabber, Value); };
                  
                  wchar_t * GetPlayerAudioCodec () { return _GetAudioCodec (m_VideoGrabber); };
                  
                  __int64 GetPlayerDuration () { return _GetPlayerDuration (m_VideoGrabber); };
                  void SetPlayerDuration (__int64 Value) { _SetPlayerDuration (m_VideoGrabber, Value); };
                  
                  __int64 GetPlayerFrameCount () { return _GetPlayerFrameCount (m_VideoGrabber); };
                  
                  __int64 GetPlayerFramePosition () { return _GetPlayerFramePosition (m_VideoGrabber); };
                  void SetPlayerFramePosition (__int64 Value) { _SetPlayerFramePosition (m_VideoGrabber, Value); };
                  
                  int GetPlayerOpenProgressPercent () { return _GetPlayerOpenProgressPercent (m_VideoGrabber); };
                  
                  TPlayerState GetPlayerState () { return _GetPlayerState (m_VideoGrabber); };
                  
                  __int64 GetPlayerTimePosition () { return _GetPlayerTimePosition (m_VideoGrabber); };
                  void SetPlayerTimePosition (__int64 Value) { _SetPlayerTimePosition (m_VideoGrabber, Value); };
                  
                  double GetPlayerFrameRate () { return _GetPlayerFrameRate (m_VideoGrabber); };
                  
                  wchar_t * GetPlayerVideoCodec () { return _GetVideoCodec (m_VideoGrabber); };
                  
                  int GetRecordingBacktimedFramesCount () { return _GetRecordingBacktimedFramesCount (m_VideoGrabber); };
                  void SetRecordingBacktimedFramesCount (int Value) { _SetRecordingBacktimedFramesCount (m_VideoGrabber, Value); };
                  
                  BOOL GetRecordingCanPause () { return _GetRecordingCanPause (m_VideoGrabber); };
                  void SetRecordingCanPause (BOOL Value) { _SetRecordingCanPause (m_VideoGrabber, Value); };
                  
                  int GetRecordingHeight () { return _GetRecordingHeight (m_VideoGrabber); };
                  
                  int GetRecordingWidth () { return _GetRecordingWidth (m_VideoGrabber); };
                  
                  int GetSendToDV_DeviceIndex () { return _GetSendToDV_DeviceIndex (m_VideoGrabber); };
                  void SetSendToDV_DeviceIndex (int Value) { _SetSendToDV_DeviceIndex (m_VideoGrabber, Value); };
                  
                  int GetSpeakerBalance () { return _GetSpeakerBalance (m_VideoGrabber); };
                  void SetSpeakerBalance (int Value) { _SetSpeakerBalance (m_VideoGrabber, Value); };
                  
                  int GetSpeakerVolume () { return _GetSpeakerVolume (m_VideoGrabber); };
                  void SetSpeakerVolume (int Value) { _SetSpeakerVolume (m_VideoGrabber, Value); };
                  
                  wchar_t * GetStreamingURL () { return _GetStreamingURL (m_VideoGrabber); };
                  
                  wchar_t * GetSystemTempPath () { return _GetSystemTempPath (m_VideoGrabber); };
                  
                  int GetTextOverlay_Font () { return _GetTextOverlay_Font (m_VideoGrabber); };
                  void SetTextOverlay_Font (int Value) { _SetTextOverlay_Font (m_VideoGrabber, Value); };
                  
                  int GetTextOverlay_Selector () { return _GetTextOverlaySelector (m_VideoGrabber); };
                  void SetTextOverlay_Selector (int Value) { _SetTextOverlaySelector (m_VideoGrabber, Value); };
                  
                  int GetTVChannel () { return _GetTVChannel (m_VideoGrabber); };
                  void SetTVChannel (int Value) { _SetTVChannel (m_VideoGrabber, Value); };
                  
                  int GetTVCountryCode () { return _GetTVCountryCode (m_VideoGrabber); };
                  void SetTVCountryCode (int Value) { _SetTVCountryCode (m_VideoGrabber, Value); };
                  
                  TTunerInputType GetTVTunerInputType () { return _GetTVTunerInputType (m_VideoGrabber); };
                  void SetTVTunerInputType (TTunerInputType Value) { _SetTVTunerInputType (m_VideoGrabber, Value); };
                  
                  TTunerMode GetTunerMode () { return _GetTunerMode (m_VideoGrabber); };
                  void SetTunerMode (TTunerMode Value) { _SetTunerMode (m_VideoGrabber, Value); };
                  
                  int GetUniqueID () { return _GetUniqueID (m_VideoGrabber); };
                  
                  BOOL GetVCRHorizontalLocking () { return _GetVCRHorizontalLocking (m_VideoGrabber); };
                  void SetVCRHorizontalLocking (BOOL Value) { _SetVCRHorizontalLocking (m_VideoGrabber, Value); };
                  
                  wchar_t * GetVideoCompressorName () { return _GetVideoCompressorName (m_VideoGrabber); };
                  
                  wchar_t * GetVideoCompressors () { return _GetVideoCompressors (m_VideoGrabber); };
                  
                  int GetVideoCompressorsCount () { return _GetVideoCompressorsCount (m_VideoGrabber); };
                  
                  wchar_t * GetVideoFormats () { return _GetVideoFormats (m_VideoGrabber); };
                  
                  int GetVideoFormatsCount () { return _GetVideoFormatsCount (m_VideoGrabber); };
                  
                  wchar_t * GetVideoInputs () { return _GetVideoInputs (m_VideoGrabber); };
                  
                  int GetVideoInputsCount () { return _GetVideoInputsCount (m_VideoGrabber); };
                  
                  wchar_t * GetVideoDeviceName () { return _GetVideoDeviceName (m_VideoGrabber); };
                  
                  wchar_t * GetVideoDevices () { return _GetVideoDevices (m_VideoGrabber); };
                  
                  wchar_t * GetVideoDevicesId () { return _GetVideoDevicesId (m_VideoGrabber); };
                  
                  int GetVideoDevicesCount () { return _GetVideoDevicesCount (m_VideoGrabber); };
                  
                  int GetVideoHeight () { return _GetVideoHeight (m_VideoGrabber); };
                  
                  int GetVideoHeight_PreferredAspectRatio () { return _GetVideoHeight_PreferredAspectRatio (m_VideoGrabber); };
                  
                  int GetVideoWidth () { return _GetVideoWidth (m_VideoGrabber); };
                  
                  int GetVideoWidth_PreferredAspectRatio () { return _GetVideoWidth_PreferredAspectRatio (m_VideoGrabber); };
                  
                  wchar_t * GetVideoSizes () { return _GetVideoSizes (m_VideoGrabber); };
                  
                  int GetVideoSizesCount () { return _GetVideoSizesCount (m_VideoGrabber); };
                  
                  wchar_t * GetVideoSources () { return _GetVideoSources (m_VideoGrabber); };
                  
                  int GetVideoSourcesCount () { return _GetVideoSourcesCount (m_VideoGrabber); };
                  
                  wchar_t * GetVideoSubtypes () { return _GetVideoSubtypes (m_VideoGrabber); };
                  
                  int GetVideoSubtypesCount () { return _GetVideoSubtypesCount (m_VideoGrabber); };
                  
                  BOOL GetAdjustOverlayAspectRatio () { return _GetAdjustOverlayAspectRatio (m_VideoGrabber); };
                  void SetAdjustOverlayAspectRatio (BOOL Value) { _SetAdjustOverlayAspectRatio (m_VideoGrabber, Value); };
                  
                  BOOL GetAdjustPixelAspectRatio () { return _GetAdjustPixelAspectRatio (m_VideoGrabber); };
                  void SetAdjustPixelAspectRatio (BOOL Value) { _SetAdjustPixelAspectRatio (m_VideoGrabber, Value); };
                  
                  TAero GetAero () { return _GetAero (m_VideoGrabber); };
                  void SetAero (TAero Value) { _SetAero (m_VideoGrabber, Value); };
                  
                  int GetAnalogVideoStandard () { return _GetAnalogVideoStandard (m_VideoGrabber); };
                  void SetAnalogVideoStandard (int Value) { _SetAnalogVideoStandard (m_VideoGrabber, Value); };
                  
                  TApplicationPriority GetApplicationPriority () { return _GetApplicationPriority (m_VideoGrabber); };
                  void SetApplicationPriority (TApplicationPriority Value) { _SetApplicationPriority (m_VideoGrabber, Value); };
                  
                  int GetASFAudioBitRate () { return _GetASFAudioBitRate (m_VideoGrabber); };
                  void SetASFAudioBitRate (int Value) { _SetASFAudioBitRate (m_VideoGrabber, Value); };
                  
                  int GetASFAudioChannels () { return _GetASFAudioChannels (m_VideoGrabber); };
                  void SetASFAudioChannels (int Value) { _SetASFAudioChannels (m_VideoGrabber, Value); };
                  
                  int GetASFBufferWindow () { return _GetASFBufferWindow (m_VideoGrabber); };
                  void SetASFBufferWindow (int Value) { _SetASFBufferWindow (m_VideoGrabber, Value); };
                  
                  TASFDeinterlaceMode GetASFDeinterlaceMode () { return _GetASFDeinterlaceMode (m_VideoGrabber); };
                  void SetASFDeinterlaceMode (TASFDeinterlaceMode Value) { _SetASFDeinterlaceMode (m_VideoGrabber, Value); };
                  
                  BOOL GetASFFixedFrameRate () { return _GetASFFixedFrameRate (m_VideoGrabber); };
                  void SetASFFixedFrameRate (BOOL Value) { _SetASFFixedFrameRate (m_VideoGrabber, Value); };
                  
                  wchar_t * GetASFMediaServerPublishingPoint () { return _GetASFMediaServerPublishingPoint (m_VideoGrabber); };
                  void SetASFMediaServerPublishingPoint (wchar_t * Value) { _SetASFMediaServerPublishingPoint (m_VideoGrabber, Value); };
                  
                  wchar_t * GetASFMediaServerTemplatePublishingPoint () { return _GetASFMediaServerTemplatePublishingPoint (m_VideoGrabber); };
                  void SetASFMediaServerTemplatePublishingPoint (wchar_t * Value) { _SetASFMediaServerTemplatePublishingPoint (m_VideoGrabber, Value); };
                  
                  BOOL GetASFMediaServerRemovePublishingPointAfterDisconnect () { return _GetASFMediaServerRemovePublishingPointAfterDisconnect (m_VideoGrabber); };
                  void SetASFMediaServerRemovePublishingPointAfterDisconnect (BOOL Value) { _SetASFMediaServerRemovePublishingPointAfterDisconnect (m_VideoGrabber, Value); };
                  
                  int GetASFNetworkPort () { return _GetASFNetworkPort (m_VideoGrabber); };
                  void SetASFNetworkPort (int Value) { _SetASFNetworkPort (m_VideoGrabber, Value); };
                  
                  int GetASFNetworkMaxUsers () { return _GetASFNetworkMaxUsers (m_VideoGrabber); };
                  void SetASFNetworkMaxUsers (int Value) { _SetASFNetworkMaxUsers (m_VideoGrabber, Value); };
                  
                  int GetASFProfile () { return _GetASFProfile (m_VideoGrabber); };
                  void SetASFProfile (int Value) { _SetASFProfile (m_VideoGrabber, Value); };
                  
                  wchar_t * GetASFProfileFromCustomFile () { return _GetASFProfileFromCustomFile (m_VideoGrabber); };
                  void SetASFProfileFromCustomFile (wchar_t * Value) { _SetASFProfileFromCustomFile (m_VideoGrabber, Value); };
                  
                  TASFProfileVersion GetASFProfileVersion () { return _GetASFProfileVersion (m_VideoGrabber); };
                  void SetASFProfileVersion (TASFProfileVersion Value) { _SetASFProfileVersion (m_VideoGrabber, Value); };
                  
                  int GetASFVideoBitRate () { return _GetASFVideoBitRate (m_VideoGrabber); };
                  void SetASFVideoBitRate (int Value) { _SetASFVideoBitRate (m_VideoGrabber, Value); };
                  
                  double GetASFVideoFrameRate () { return _GetASFVideoFrameRate (m_VideoGrabber); };
                  void SetASFVideoFrameRate (double Value) { _SetASFVideoFrameRate (m_VideoGrabber, Value); };
                  
                  int GetASFVideoHeight () { return _GetASFVideoHeight (m_VideoGrabber); };
                  void SetASFVideoHeight (int Value) { _SetASFVideoHeight (m_VideoGrabber, Value); };
                  
                  int GetASFVideoMaxKeyFrameSpacing () { return _GetASFVideoMaxKeyFrameSpacing (m_VideoGrabber); };
                  void SetASFVideoMaxKeyFrameSpacing (int Value) { _SetASFVideoMaxKeyFrameSpacing (m_VideoGrabber, Value); };
                  
                  int GetASFVideoQuality () { return _GetASFVideoQuality (m_VideoGrabber); };
                  void SetASFVideoQuality (int Value) { _SetASFVideoQuality (m_VideoGrabber, Value); };
                  
                  int GetASFVideoWidth () { return _GetASFVideoWidth (m_VideoGrabber); };
                  void SetASFVideoWidth (int Value) { _SetASFVideoWidth (m_VideoGrabber, Value); };
                  
                  double GetAspectRatioToUse () { return _GetAspectRatioToUse (m_VideoGrabber); };
                  void SetAspectRatioToUse (double Value) { _SetAspectRatioToUse (m_VideoGrabber, Value); };
                  
                  BOOL GetAssociateAudioAndVideoDevices () { return _GetAssociateAudioAndVideoDevices (m_VideoGrabber); };
                  void SetAssociateAudioAndVideoDevices (BOOL Value) { _SetAssociateAudioAndVideoDevices (m_VideoGrabber, Value); };
                  
                  BOOL GetAVIDurationUpdated () { return _GetAVIDurationUpdated (m_VideoGrabber); };
                  void SetAVIDurationUpdated (BOOL Value) { _SetAVIDurationUpdated (m_VideoGrabber, Value); };
                  
                  TAudioChannelRenderMode GetAudioChannelRenderMode () { return _GetAudioChannelRenderMode (m_VideoGrabber); };
                  void SetAudioChannelRenderMode (TAudioChannelRenderMode Value) { _SetAudioChannelRenderMode (m_VideoGrabber, Value); };
                  
                  int GetAudioCompressor () { return _GetAudioCompressor (m_VideoGrabber); };
                  void SetAudioCompressor (int Value) { _SetAudioCompressor (m_VideoGrabber, Value); };
                  
                  int GetAudioDevice () { return _GetAudioDevice (m_VideoGrabber); };
                  void SetAudioDevice (int Value) { _SetAudioDevice (m_VideoGrabber, Value); };
                  
                  BOOL GetAudioDeviceRendering () { return _GetAudioDeviceRendering (m_VideoGrabber); };
                  void SetAudioDeviceRendering (BOOL Value) { _SetAudioDeviceRendering (m_VideoGrabber, Value); };
                  
                  TAudioFormat GetAudioFormat () { return _GetAudioFormat (m_VideoGrabber); };
                  void SetAudioFormat (TAudioFormat Value) { _SetAudioFormat (m_VideoGrabber, Value); };
                  
                  int GetAudioInput () { return _GetAudioInput (m_VideoGrabber); };
                  void SetAudioInput (int Value) { _SetAudioInput (m_VideoGrabber, Value); };
                  
                  BOOL GetAudioPeakEvent () { return _GetAudioPeakEvent (m_VideoGrabber); };
                  void SetAudioPeakEvent (BOOL Value) { _SetAudioPeakEvent (m_VideoGrabber, Value); };
                  
                  BOOL GetAudioRecording () { return _GetAudioRecording (m_VideoGrabber); };
                  void SetAudioRecording (BOOL Value) { _SetAudioRecording (m_VideoGrabber, Value); };
                  
                  int GetAudioRenderer () { return _GetAudioRenderer (m_VideoGrabber); };
                  void SetAudioRenderer (int Value) { _SetAudioRenderer (m_VideoGrabber, Value); };
                  
                  int GetAudioStreamNumber () { return _GetAudioStreamNumber (m_VideoGrabber); };
                  void SetAudioStreamNumber (int Value) { _SetAudioStreamNumber (m_VideoGrabber, Value); };
                  
                  BOOL GetAudioSyncAdjustmentEnabled () { return _GetAudioSyncAdjustmentEnabled (m_VideoGrabber); };
                  void SetAudioSyncAdjustmentEnabled (BOOL Value) { _SetAudioSyncAdjustmentEnabled (m_VideoGrabber, Value); };
                  
                  int GetAudioSyncAdjustment () { return _GetAudioSyncAdjustment (m_VideoGrabber); };
                  void SetAudioSyncAdjustment (int Value) { _SetAudioSyncAdjustment (m_VideoGrabber, Value); };
                  
                  TAudioSource GetAudioSource () { return _GetAudioSource (m_VideoGrabber); };
                  void SetAudioSource (TAudioSource Value) { _SetAudioSource (m_VideoGrabber, Value); };
                  
                  BOOL GetAutoConnectRelatedPins () { return _GetAutoConnectRelatedPins (m_VideoGrabber); };
                  void SetAutoConnectRelatedPins (BOOL Value) { _SetAutoConnectRelatedPins (m_VideoGrabber, Value); };
                  
                  TAutoFileName GetAutoFileName () { return _GetAutoFileName (m_VideoGrabber); };
                  void SetAutoFileName (TAutoFileName Value) { _SetAutoFileName (m_VideoGrabber, Value); };
                  
                  int GetAutoFileNameMinDigits () { return _GetAutoFileNameMinDigits (m_VideoGrabber); };
                  void SetAutoFileNameMinDigits (int Value) { _SetAutoFileNameMinDigits (m_VideoGrabber, Value); };
                  
                  wchar_t * GetAutoFilePrefix () { return _GetAutoFilePrefix (m_VideoGrabber); };
                  void SetAutoFilePrefix (wchar_t * Value) { _SetAutoFilePrefix (m_VideoGrabber, Value); };
                  
                  BOOL GetAutoRefreshPreview () { return _GetAutoRefreshPreview (m_VideoGrabber); };
                  void SetAutoRefreshPreview (BOOL Value) { _SetAutoRefreshPreview (m_VideoGrabber, Value); };
                  
                  BOOL GetAutoStartPlayer () { return _GetAutoStartPlayer (m_VideoGrabber); };
                  void SetAutoStartPlayer (BOOL Value) { _SetAutoStartPlayer (m_VideoGrabber, Value); };
                  
                  BOOL GetAVIFormatOpenDML () { return _GetAVIFormatOpenDML (m_VideoGrabber); };
                  void SetAVIFormatOpenDML (BOOL Value) { _SetAVIFormatOpenDML (m_VideoGrabber, Value); };
                  
                  BOOL GetAVIFormatOpenDMLCompatibilityIndex () { return _GetAVIFormatOpenDMLCompatibilityIndex (m_VideoGrabber); };
                  void SetAVIFormatOpenDMLCompatibilityIndex (BOOL Value) { _SetAVIFormatOpenDMLCompatibilityIndex (m_VideoGrabber, Value); };
                  
                  int GetBackgroundColor () { return _GetBackgroundColor (m_VideoGrabber); };
                  void SetBackgroundColor (int Value) { _SetBackgroundColor (m_VideoGrabber, Value); };
                  
                  int GetBurstCount () { return _GetBurstCount (m_VideoGrabber); };
                  void SetBurstCount (int Value) { _SetBurstCount (m_VideoGrabber, Value); };
                  
                  int GetBurstInterval () { return _GetBurstInterval (m_VideoGrabber); };
                  void SetBurstInterval (int Value) { _SetBurstInterval (m_VideoGrabber, Value); };
                  
                  BOOL GetBurstMode () { return _GetBurstMode (m_VideoGrabber); };
                  void SetBurstMode (BOOL Value) { _SetBurstMode (m_VideoGrabber, Value); };
                  
                  TFrameCaptureDest GetBurstType () { return _GetBurstType (m_VideoGrabber); };
                  void SetBurstType (TFrameCaptureDest Value) { _SetBurstType (m_VideoGrabber, Value); };
                  
                  BOOL GetCameraControlSettings () { return _GetCameraControlSettings (m_VideoGrabber); };
                  void SetCameraControlSettings (BOOL Value) { _SetCameraControlSettings (m_VideoGrabber, Value); };
                  
                  wchar_t * GetCaptureFileExt () { return _GetCaptureFileExt (m_VideoGrabber); };
                  void SetCaptureFileExt (wchar_t * Value) { _SetCaptureFileExt (m_VideoGrabber, Value); };
                  
                  int GetColorKey () { return _GetColorKey (m_VideoGrabber); };
                  void SetColorKey (int Value) { _SetColorKey (m_VideoGrabber, Value); };
                  
                  BOOL GetColorKeyEnabled () { return _GetColorKeyEnabled (m_VideoGrabber); };
                  void SetColorKeyEnabled (BOOL Value) { _SetColorKeyEnabled (m_VideoGrabber, Value); };
                  
                  TCompressionMode GetCompressionMode () { return _GetCompressionMode (m_VideoGrabber); };
                  void SetCompressionMode (TCompressionMode Value) { _SetCompressionMode (m_VideoGrabber, Value); };
                  
                  TCompressionType GetCompressionType () { return _GetCompressionType (m_VideoGrabber); };
                  void SetCompressionType (TCompressionType Value) { _SetCompressionType (m_VideoGrabber, Value); };
                  
                  BOOL GetDisplay_Active () { return _GetDisplayBoolProperties (m_VideoGrabber, (int)vwActive); };
                  void SetDisplay_Active (BOOL Value) { _SetDisplayBoolProperties (m_VideoGrabber, (int)vwActive, Value); };
                  
                  BOOL GetDisplay_AlphaBlendEnabled () { return _GetDisplayBoolProperties (m_VideoGrabber, (int)vwAlphaBlendEnabled); };
                  void SetDisplay_AlphaBlendEnabled (BOOL Value) { _SetDisplayBoolProperties (m_VideoGrabber, (int)vwAlphaBlendEnabled, Value); };
                  
                  int GetDisplay_AlphaBlendValue () { return _GetDisplayLongProperties (m_VideoGrabber, (int)vwAlphaBlendValue); };
                  void SetDisplay_AlphaBlendValue (int Value) { _SetDisplayLongProperties (m_VideoGrabber, (int)vwAlphaBlendValue, Value); };
                  
                  BOOL GetDisplay_AutoSize () { return _GetDisplayBoolProperties (m_VideoGrabber, (int)vwAutoSize); };
                  void SetDisplay_AutoSize (BOOL Value) { _SetDisplayBoolProperties (m_VideoGrabber, (int)vwAutoSize, Value); };
                  
                  TAspectRatio GetDisplay_AspectRatio () { return _GetDisplayAspectRatio (m_VideoGrabber, 0); };
                  void SetDisplay_AspectRatio (TAspectRatio Value) { _SetDisplayAspectRatio (m_VideoGrabber, 0, Value); };
                  
                  BOOL GetDisplay_Embedded () { return _GetDisplayBoolProperties (m_VideoGrabber, (int)vwEmbedded); };
                  void SetDisplay_Embedded (BOOL Value) { _SetDisplayBoolProperties (m_VideoGrabber, (int)vwEmbedded, Value); };
                  
                  BOOL GetDisplay_FullScreen () { return _GetDisplayBoolProperties (m_VideoGrabber, (int)vwFullScreen); };
                  void SetDisplay_FullScreen (BOOL Value) { _SetDisplayBoolProperties (m_VideoGrabber, (int)vwFullScreen, Value); };
                  
                  int GetDisplay_Height () { return _GetDisplayLongProperties (m_VideoGrabber, (int)vwVideoHeight); };
                  void SetDisplay_Height (int Value) { _SetDisplayLongProperties (m_VideoGrabber, (int)vwVideoHeight, Value); };
                  
                  int GetDisplay_Left () { return _GetDisplayLongProperties (m_VideoGrabber, (int)vwLeft); };
                  void SetDisplay_Left (int Value) { _SetDisplayLongProperties (m_VideoGrabber, (int)vwLeft, Value); };
                  
                  int GetDisplay_Monitor () { return _GetDisplayLongProperties (m_VideoGrabber, (int)vwMonitor); };
                  void SetDisplay_Monitor (int Value) { _SetDisplayLongProperties (m_VideoGrabber, (int)vwMonitor, Value); };
                  
                  BOOL GetDisplay_MouseMovesWindow () { return _GetDisplayBoolProperties (m_VideoGrabber, (int)vwMouseMovesWindow); };
                  void SetDisplay_MouseMovesWindow (BOOL Value) { _SetDisplayBoolProperties (m_VideoGrabber, (int)vwMouseMovesWindow, Value); };
                  
                  int GetDisplay_PanScanRatio () { return _GetDisplayLongProperties (m_VideoGrabber, (int)vwPanScanRatio); };
                  void SetDisplay_PanScanRatio (int Value) { _SetDisplayLongProperties (m_VideoGrabber, (int)vwPanScanRatio, Value); };
                  
                  BOOL GetDisplay_StayOnTop () { return _GetDisplayBoolProperties (m_VideoGrabber, (int)vwStayOnTop); };
                  void SetDisplay_StayOnTop (BOOL Value) { _SetDisplayBoolProperties (m_VideoGrabber, (int)vwStayOnTop, Value); };
                  
                  int GetDisplay_Top () { return _GetDisplayLongProperties (m_VideoGrabber, (int)vwTop); };
                  void SetDisplay_Top (int Value) { _SetDisplayLongProperties (m_VideoGrabber, (int)vwTop, Value); };
                  
                  BOOL GetDisplay_TransparentColorEnabled () { return _GetDisplayBoolProperties (m_VideoGrabber, (int)vwColorKeyEnabled); };
                  void SetDisplay_TransparentColorEnabled (BOOL Value) { _SetDisplayBoolProperties (m_VideoGrabber, (int)vwColorKeyEnabled, Value); };
                  
                  int GetDisplay_TransparentColorValue () { return _GetDisplayLongProperties (m_VideoGrabber, (int)vwColorKeyValue); };
                  void SetDisplay_TransparentColorValue (int Value) { _SetDisplayLongProperties (m_VideoGrabber, (int)vwColorKeyValue, Value); };
                  
                  BOOL GetDisplay_VideoPortEnabled () { return _GetDisplayBoolProperties (m_VideoGrabber, (int)vwVideoPortEnabled); };
                  void SetDisplay_VideoPortEnabled (BOOL Value) { _SetDisplayBoolProperties (m_VideoGrabber, (int)vwVideoPortEnabled, Value); };
                  
                  BOOL GetDisplay_Visible () { return _GetDisplayBoolProperties (m_VideoGrabber, (int)vwVisible); };
                  void SetDisplay_Visible (BOOL Value) { _SetDisplayBoolProperties (m_VideoGrabber, (int)vwVisible, Value); };
                  
                  int GetDisplay_Width () { return _GetDisplayLongProperties (m_VideoGrabber, (int)vwVideoWidth); };
                  void SetDisplay_Width (int Value) { _SetDisplayLongProperties (m_VideoGrabber, (int)vwVideoWidth, Value); };
                  
                  BOOL GetDoubleBuffered () { return _GetVideoDoubleBuffered (m_VideoGrabber); };
                  void SetDoubleBuffered (BOOL Value) { _SetVideoDoubleBuffered (m_VideoGrabber, Value); };
                  
                  int GetDroppedFramesPollingInterval () { return _GetDroppedFramesPollingInterval (m_VideoGrabber); };
                  void SetDroppedFramesPollingInterval (int Value) { _SetDroppedFramesPollingInterval (m_VideoGrabber, Value); };
                  
                  BOOL GetDualDisplay_Active () { return _GetDisplay2BoolProperties (m_VideoGrabber, (int)vwActive); };
                  void SetDualDisplay_Active (BOOL Value) { _SetDisplay2BoolProperties (m_VideoGrabber, (int)vwActive, Value); };
                  
                  BOOL GetDualDisplay_AlphaBlendEnabled () { return _GetDisplay2BoolProperties (m_VideoGrabber, (int)vwAlphaBlendEnabled); };
                  void SetDualDisplay_AlphaBlendEnabled (BOOL Value) { _SetDisplay2BoolProperties (m_VideoGrabber, (int)vwAlphaBlendEnabled, Value); };
                  
                  int GetDualDisplay_AlphaBlendValue () { return _GetDisplay2LongProperties (m_VideoGrabber, (int)vwAlphaBlendValue); };
                  void SetDualDisplay_AlphaBlendValue (int Value) { _SetDisplay2LongProperties (m_VideoGrabber, (int)vwAlphaBlendValue, Value); };
                  
                  BOOL GetDualDisplay_TransparentColorEnabled () { return _GetDisplay2BoolProperties (m_VideoGrabber, (int)vwColorKeyEnabled); };
                  void SetDualDisplay_TransparentColorEnabled (BOOL Value) { _SetDisplay2BoolProperties (m_VideoGrabber, (int)vwColorKeyEnabled, Value); };
                  
                  int GetDualDisplay_TransparentColorValue () { return _GetDisplay2LongProperties (m_VideoGrabber, (int)vwColorKeyValue); };
                  void SetDualDisplay_TransparentColorValue (int Value) { _SetDisplay2LongProperties (m_VideoGrabber, (int)vwColorKeyValue, Value); };
                  
                  BOOL GetDualDisplay_AutoSize () { return _GetDisplay2BoolProperties (m_VideoGrabber, (int)vwAutoSize); };
                  void SetDualDisplay_AutoSize (BOOL Value) { _SetDisplay2BoolProperties (m_VideoGrabber, (int)vwAutoSize, Value); };
                  
                  TAspectRatio GetDualDisplay_AspectRatio () { return _GetDisplayAspectRatio (m_VideoGrabber, 1); };
                  void SetDualDisplay_AspectRatio (TAspectRatio Value) { _SetDisplayAspectRatio (m_VideoGrabber, 1, Value); };
                  
                  BOOL GetDualDisplay_Embedded () { return _GetDisplay2BoolProperties (m_VideoGrabber, (int)vwEmbedded); };
                  void SetDualDisplay_Embedded (BOOL Value) { _SetDisplay2BoolProperties (m_VideoGrabber, (int)vwEmbedded, Value); };
                  
                  BOOL GetDualDisplay_FullScreen () { return _GetDisplay2BoolProperties (m_VideoGrabber, (int)vwFullScreen); };
                  void SetDualDisplay_FullScreen (BOOL Value) { _SetDisplay2BoolProperties (m_VideoGrabber, (int)vwFullScreen, Value); };
                  
                  int GetDualDisplay_Height () { return _GetDisplay2LongProperties (m_VideoGrabber, (int)vwVideoHeight); };
                  void SetDualDisplay_Height (int Value) { _SetDisplay2LongProperties (m_VideoGrabber, (int)vwVideoHeight, Value); };
                  
                  int GetDualDisplay_Left () { return _GetDisplay2LongProperties (m_VideoGrabber, (int)vwLeft); };
                  void SetDualDisplay_Left (int Value) { _SetDisplay2LongProperties (m_VideoGrabber, (int)vwLeft, Value); };
                  
                  int GetDualDisplay_Monitor () { return _GetDisplay2LongProperties (m_VideoGrabber, (int)vwMonitor); };
                  void SetDualDisplay_Monitor (int Value) { _SetDisplay2LongProperties (m_VideoGrabber, (int)vwMonitor, Value); };
                  
                  BOOL GetDualDisplay_MouseMovesWindow () { return _GetDisplay2BoolProperties (m_VideoGrabber, (int)vwMouseMovesWindow); };
                  void SetDualDisplay_MouseMovesWindow (BOOL Value) { _SetDisplay2BoolProperties (m_VideoGrabber, (int)vwMouseMovesWindow, Value); };
                  
                  int GetDualDisplay_PanScanRatio () { return _GetDisplay2LongProperties (m_VideoGrabber, (int)vwPanScanRatio); };
                  void SetDualDisplay_PanScanRatio (int Value) { _SetDisplay2LongProperties (m_VideoGrabber, (int)vwPanScanRatio, Value); };
                  
                  BOOL GetDualDisplay_StayOnTop () { return _GetDisplay2BoolProperties (m_VideoGrabber, (int)vwStayOnTop); };
                  void SetDualDisplay_StayOnTop (BOOL Value) { _SetDisplay2BoolProperties (m_VideoGrabber, (int)vwStayOnTop, Value); };
                  
                  int GetDualDisplay_Top () { return _GetDisplay2LongProperties (m_VideoGrabber, (int)vwTop); };
                  void SetDualDisplay_Top (int Value) { _SetDisplay2LongProperties (m_VideoGrabber, (int)vwTop, Value); };
                  
                  BOOL GetDualDisplay_VideoPortEnabled () { return _GetDisplay2BoolProperties (m_VideoGrabber, (int)vwVideoPortEnabled); };
                  void SetDualDisplay_VideoPortEnabled (BOOL Value) { _SetDisplay2BoolProperties (m_VideoGrabber, (int)vwVideoPortEnabled, Value); };
                  
                  BOOL GetDualDisplay_Visible () { return _GetDisplay2BoolProperties (m_VideoGrabber, (int)vwVisible); };
                  void SetDualDisplay_Visible (BOOL Value) { _SetDisplay2BoolProperties (m_VideoGrabber, (int)vwVisible, Value); };
                  
                  int GetDualDisplay_Width () { return _GetDisplay2LongProperties (m_VideoGrabber, (int)vwVideoWidth); };
                  void SetDualDisplay_Width (int Value) { _SetDisplay2LongProperties (m_VideoGrabber, (int)vwVideoWidth, Value); };
                  
                  BOOL GetDVDateTimeEnabled () { return _GetDVDateTimeEnabled (m_VideoGrabber); };
                  void SetDVDateTimeEnabled (BOOL Value) { _SetDVDateTimeEnabled (m_VideoGrabber, Value); };
                  
                  int GetDVDTitle () { return _GetDVDTitle (m_VideoGrabber); };
                  void SetDVDTitle (int Value) { _SetDVDTitle (m_VideoGrabber, Value); };
                  
                  int GetDVDiscontinuityMinimumInterval () { return _GetDVDiscontinuityMinimumInterval (m_VideoGrabber); };
                  void SetDVDiscontinuityMinimumInterval (int Value) { _SetDVDiscontinuityMinimumInterval (m_VideoGrabber, Value); };
                  
                  TDVVideoFormat GetDVEncoder_VideoFormat () { return _GetDVEncoder_VideoFormat (m_VideoGrabber); };
                  void SetDVEncoder_VideoFormat (TDVVideoFormat Value) { _SetDVEncoder_VideoFormat (m_VideoGrabber, Value); };
                  
                  TDVSize GetDVEncoder_VideoResolution () { return _GetDVEncoder_VideoResolution (m_VideoGrabber); };
                  void SetDVEncoder_VideoResolution (TDVSize Value) { _SetDVEncoder_VideoResolution (m_VideoGrabber, Value); };
                  
                  TDVVideoStandard GetDVEncoder_VideoStandard () { return _GetDVEncoder_VideoStandard (m_VideoGrabber); };
                  void SetDVEncoder_VideoStandard (TDVVideoStandard Value) { _SetDVEncoder_VideoStandard (m_VideoGrabber, Value); };
                  
                  BOOL GetDVRgb219 () { return _GetDVRgb219 (m_VideoGrabber); };
                  void SetDVRgb219 (BOOL Value) { _SetDVRgb219 (m_VideoGrabber, Value); };
                  
                  BOOL GetDVReduceFrameRate () { return _GetDVReduceFrameRate (m_VideoGrabber); };
                  void SetDVReduceFrameRate (BOOL Value) { _SetDVReduceFrameRate (m_VideoGrabber, Value); };
                  
                  BOOL GetDVRecordingInNativeFormatSeparatesStreams () { return _GetDVRecordingInNativeFormatSeparatesStreams (m_VideoGrabber); };
                  void SetDVRecordingInNativeFormatSeparatesStreams (BOOL Value) { _SetDVRecordingInNativeFormatSeparatesStreams (m_VideoGrabber, Value); };
                  
                  BOOL GetDVTimeCodeEnabled () { return _GetDVTimeCodeEnabled (m_VideoGrabber); };
                  void SetDVTimeCodeEnabled (BOOL Value) { _SetDVTimeCodeEnabled (m_VideoGrabber, Value); };
                  
                  BOOL GetEventNotificationSynchrone () { return _GetEventNotificationSynchrone (m_VideoGrabber); };
                  void SetEventNotificationSynchrone (BOOL Value) { _SetEventNotificationSynchrone (m_VideoGrabber, Value); };
                  
                  BOOL GetCropping_Enabled () { return _GetCropping_Enabled (m_VideoGrabber); };
                  void SetCropping_Enabled (BOOL Value) { _SetCropping_Enabled (m_VideoGrabber, Value); };
                  
                  int GetCropping_Height () { return _GetCropping_Height (m_VideoGrabber); };
                  void SetCropping_Height (int Value) { _SetCropping_Height (m_VideoGrabber, Value); };
                  
                  BOOL GetCropping_Outbounds () { return _GetCropping_Outbounds (m_VideoGrabber); };
                  void SetCropping_Outbounds (BOOL Value) { _SetCropping_Outbounds (m_VideoGrabber, Value); };
                  
                  int GetCropping_Width () { return _GetCropping_Width (m_VideoGrabber); };
                  void SetCropping_Width (int Value) { _SetCropping_Width (m_VideoGrabber, Value); };
                  
                  int GetCropping_X () { return _GetCropping_X (m_VideoGrabber); };
                  void SetCropping_X (int Value) { _SetCropping_X (m_VideoGrabber, Value); };
                  
                  int GetCropping_Y () { return _GetCropping_Y (m_VideoGrabber); };
                  void SetCropping_Y (int Value) { _SetCropping_Y (m_VideoGrabber, Value); };
                  
                  double GetCropping_Zoom () { return _GetCropping_Zoom (m_VideoGrabber); };
                  void SetCropping_Zoom (double Value) { _SetCropping_Zoom (m_VideoGrabber, Value); };
                  
                  BOOL GetFixFlickerOrBlackCapture () { return _GetFixFlickerOrBlackCapture (m_VideoGrabber); };
                  void SetFixFlickerOrBlackCapture (BOOL Value) { _SetFixFlickerOrBlackCapture (m_VideoGrabber, Value); };
                  
                  BOOL GetFrameCaptureWithoutOverlay () { return _GetFrameCaptureWithoutOverlay (m_VideoGrabber); };
                  void SetFrameCaptureWithoutOverlay (BOOL Value) { _SetFrameCaptureWithoutOverlay (m_VideoGrabber, Value); };
                  
                  int GetFrameCaptureHeight () { return _GetFrameCaptureHeight (m_VideoGrabber); };
                  void SetFrameCaptureHeight (int Value) { _SetFrameCaptureHeight (m_VideoGrabber, Value); };
                  
                  int GetFrameCaptureWidth () { return _GetFrameCaptureWidth (m_VideoGrabber); };
                  void SetFrameCaptureWidth (int Value) { _SetFrameCaptureWidth (m_VideoGrabber, Value); };
                  
                  int GetFrameCaptureZoomSize () { return _GetFrameCaptureZoomSize (m_VideoGrabber); };
                  void SetFrameCaptureZoomSize (int Value) { _SetFrameCaptureZoomSize (m_VideoGrabber, Value); };
                  
                  TFrameGrabber GetFrameGrabber () { return _GetFrameGrabber (m_VideoGrabber); };
                  void SetFrameGrabber (TFrameGrabber Value) { _SetFrameGrabber (m_VideoGrabber, Value); };
                  
                  TFrameGrabberRGBFormat GetFrameGrabberRGBFormat () { return _GetFrameGrabberRGBFormat (m_VideoGrabber); };
                  void SetFrameGrabberRGBFormat (TFrameGrabberRGBFormat Value) { _SetFrameGrabberRGBFormat (m_VideoGrabber, Value); };
                  
                  BOOL GetFrameNumberStartsFromZero () { return _GetFrameNumberStartsFromZero (m_VideoGrabber); };
                  void SetFrameNumberStartsFromZero (BOOL Value) { _SetFrameNumberStartsFromZero (m_VideoGrabber, Value); };
                  
                  double GetFrameRate () { return _GetFrameRate (m_VideoGrabber); };
                  void SetFrameRate (double Value) { _SetFrameRate (m_VideoGrabber, Value); };
                  
                  BOOL GetImageOverlay_AlphaBlend () { return _GetImageOverlay_AlphaBlend (m_VideoGrabber); };
                  void SetImageOverlay_AlphaBlend (BOOL Value) { _SetImageOverlay_AlphaBlend (m_VideoGrabber, Value); };
                  
                  int GetImageOverlay_AlphaBlendValue () { return _GetImageOverlay_AlphaBlendValue (m_VideoGrabber); };
                  void SetImageOverlay_AlphaBlendValue (int Value) { _SetImageOverlay_AlphaBlendValue (m_VideoGrabber, Value); };
                  
                  BOOL GetImageOverlay_ChromaKey () { return _GetImageOverlay_ChromaKey (m_VideoGrabber); };
                  void SetImageOverlay_ChromaKey (BOOL Value) { _SetImageOverlay_ChromaKey (m_VideoGrabber, Value); };
                  
                  int GetImageOverlay_ChromaKeyLeewayPercent () { return _GetImageOverlay_ChromaKeyLeewayPercent (m_VideoGrabber); };
                  void SetImageOverlay_ChromaKeyLeewayPercent (int Value) { _SetImageOverlay_ChromaKeyLeewayPercent (m_VideoGrabber, Value); };
                  
                  int GetImageOverlay_ChromaKeyRGBColor () { return _GetImageOverlay_ChromaKeyRGBColor (m_VideoGrabber); };
                  void SetImageOverlay_ChromaKeyRGBColor (int Value) { _SetImageOverlay_ChromaKeyRGBColor (m_VideoGrabber, Value); };
                  
                  int GetImageOverlay_Height () { return _GetImageOverlay_Height (m_VideoGrabber); };
                  void SetImageOverlay_Height (int Value) { _SetImageOverlay_Height (m_VideoGrabber, Value); };
                  
                  int GetImageOverlay_LeftLocation () { return _GetImageOverlay_LeftLocation (m_VideoGrabber); };
                  void SetImageOverlay_LeftLocation (int Value) { _SetImageOverlay_LeftLocation (m_VideoGrabber, Value); };
                  
                  double GetImageOverlay_RotationAngle () { return _GetImageOverlay_RotationAngle (m_VideoGrabber); };
                  void SetImageOverlay_RotationAngle (double Value) { _SetImageOverlay_RotationAngle (m_VideoGrabber, Value); };
                  
                  BOOL GetImageOverlay_StretchToVideoSize () { return _GetImageOverlay_StretchToVideoSize (m_VideoGrabber); };
                  void SetImageOverlay_StretchToVideoSize (BOOL Value) { _SetImageOverlay_StretchToVideoSize (m_VideoGrabber, Value); };
                  
                  int GetImageOverlay_TopLocation () { return _GetImageOverlay_TopLocation (m_VideoGrabber); };
                  void SetImageOverlay_TopLocation (int Value) { _SetImageOverlay_TopLocation (m_VideoGrabber, Value); };
                  
                  BOOL GetImageOverlay_Transparent () { return _GetImageOverlay_Transparent (m_VideoGrabber); };
                  void SetImageOverlay_Transparent (BOOL Value) { _SetImageOverlay_Transparent (m_VideoGrabber, Value); };
                  
                  int GetImageOverlay_TransparentColorValue () { return _GetImageOverlay_TransparentColorValue (m_VideoGrabber); };
                  void SetImageOverlay_TransparentColorValue (int Value) { _SetImageOverlay_TransparentColorValue (m_VideoGrabber, Value); };
                  
                  BOOL GetImageOverlay_UseTransparentColor () { return _GetImageOverlay_UseTransparentColor (m_VideoGrabber); };
                  void SetImageOverlay_UseTransparentColor (BOOL Value) { _SetImageOverlay_UseTransparentColor (m_VideoGrabber, Value); };
                  
                  int GetImageOverlay_Width () { return _GetImageOverlay_Width (m_VideoGrabber); };
                  void SetImageOverlay_Width (int Value) { _SetImageOverlay_Width (m_VideoGrabber, Value); };
                  
                  BOOL GetImageOverlayEnabled () { return _GetImageOverlayEnabled (m_VideoGrabber); };
                  void SetImageOverlayEnabled (BOOL Value) { _SetImageOverlayEnabled (m_VideoGrabber, Value); };
                  
                  wchar_t * GetIPCameraURL () { return _GetIPCameraURL (m_VideoGrabber); };
                  void SetIPCameraURL (wchar_t * Value) { _SetIPCameraURL (m_VideoGrabber, Value); };
                  
                  TJPEGPerformance GetJPEGPerformance () { return _GetJPEGPerformance (m_VideoGrabber); };
                  void SetJPEGPerformance (TJPEGPerformance Value) { _SetJPEGPerformance (m_VideoGrabber, Value); };
                  
                  BOOL GetJPEGProgressiveDisplay () { return _GetJPEGProgressiveDisplay (m_VideoGrabber); };
                  void SetJPEGProgressiveDisplay (BOOL Value) { _SetJPEGProgressiveDisplay (m_VideoGrabber, Value); };
                  
                  int GetJPEGQuality () { return _GetJPEGQuality (m_VideoGrabber); };
                  void SetJPEGQuality (int Value) { _SetJPEGQuality (m_VideoGrabber, Value); };
                  
                  wchar_t * GetLicenseString () { return _GetLicenseString (m_VideoGrabber); };
                  void SetLicenseString (wchar_t * Value) { _SetLicenseString (m_VideoGrabber, Value); };
                  
                  BOOL GetLogoDisplayed () { return _GetLogoDisplayed (m_VideoGrabber); };
                  void SetLogoDisplayed (BOOL Value) { _SetLogoDisplayed (m_VideoGrabber, Value); };
                  
                  TLogoLayout GetLogoLayout () { return _GetLogoLayout (m_VideoGrabber); };
                  void SetLogoLayout (TLogoLayout Value) { _SetLogoLayout (m_VideoGrabber, Value); };
                  
                  int GetMixAudioSamples_CurrentSourceLevel () { return _GetMixAudioSamplesLevel (m_VideoGrabber, 0); };
                  void SetMixAudioSamples_CurrentSourceLevel (int Value) { _SetMixAudioSamplesLevel (m_VideoGrabber, 0, Value); };
                  
                  int GetMixAudioSamples_ExternalSourceLevel () { return _GetMixAudioSamplesLevel (m_VideoGrabber, 1); };
                  void SetMixAudioSamples_ExternalSourceLevel (int Value) { _SetMixAudioSamplesLevel (m_VideoGrabber, 1, Value); };
                  
                  int GetMixer_MosaicColumns () { return _GetMixer_MosaicColumns (m_VideoGrabber); };
                  void SetMixer_MosaicColumns (int Value) { _SetMixer_MosaicColumns (m_VideoGrabber, Value); };
                  
                  int GetMixer_MosaicLines () { return _GetMixer_MosaicLines (m_VideoGrabber); };
                  void SetMixer_MosaicLines (int Value) { _SetMixer_MosaicLines (m_VideoGrabber, Value); };
                  
                  BOOL GetMotionDetector_CompareBlue () { return _GetMotionDetector_CompareBlue (m_VideoGrabber); };
                  void SetMotionDetector_CompareBlue (BOOL Value) { _SetMotionDetector_CompareBlue (m_VideoGrabber, Value); };
                  
                  BOOL GetMotionDetector_CompareGreen () { return _GetMotionDetector_CompareGreen (m_VideoGrabber); };
                  void SetMotionDetector_CompareGreen (BOOL Value) { _SetMotionDetector_CompareGreen (m_VideoGrabber, Value); };
                  
                  BOOL GetMotionDetector_GreyScale () { return _GetMotionDetector_GreyScale (m_VideoGrabber); };
                  void SetMotionDetector_GreyScale (BOOL Value) { _SetMotionDetector_GreyScale (m_VideoGrabber, Value); };
                  
                  BOOL GetMotionDetector_CompareRed () { return _GetMotionDetector_CompareRed (m_VideoGrabber); };
                  void SetMotionDetector_CompareRed (BOOL Value) { _SetMotionDetector_CompareRed (m_VideoGrabber, Value); };
                  
                  BOOL GetMotionDetector_Enabled () { return _GetMotionDetector_Enabled (m_VideoGrabber); };
                  void SetMotionDetector_Enabled (BOOL Value) { _SetMotionDetector_Enabled (m_VideoGrabber, Value); };
                  
                  wchar_t * GetMotionDetector_Grid () { return _GetMotionDetector_Grid (m_VideoGrabber); };
                  void SetMotionDetector_Grid (wchar_t * Value) { _SetMotionDetector_Grid (m_VideoGrabber, Value); };
                  
                  double GetMotionDetector_MaxDetectionsPerSecond () { return _GetMotionDetector_MaxDetectionsPerSecond (m_VideoGrabber); };
                  void SetMotionDetector_MaxDetectionsPerSecond (double Value) { _SetMotionDetector_MaxDetectionsPerSecond (m_VideoGrabber, Value); };
                  
                  int GetMotionDetector_ReduceCPULoad () { return _GetMotionDetector_ReduceCPULoad (m_VideoGrabber); };
                  void SetMotionDetector_ReduceCPULoad (int Value) { _SetMotionDetector_ReduceCPULoad (m_VideoGrabber, Value); };
                  
                  BOOL GetMotionDetector_ReduceVideoNoise () { return _GetMotionDetector_ReduceVideoNoise (m_VideoGrabber); };
                  void SetMotionDetector_ReduceVideoNoise (BOOL Value) { _SetMotionDetector_ReduceVideoNoise (m_VideoGrabber, Value); };
                  
                  BOOL GetMotionDetector_Triggered () { return _GetMotionDetector_Triggered (m_VideoGrabber); };
                  void SetMotionDetector_Triggered (BOOL Value) { _SetMotionDetector_Triggered (m_VideoGrabber, Value); };
                  
                  BOOL GetMouseWheelEventEnabled () { return _GetMouseWheelEventEnabled (m_VideoGrabber); };
                  void SetMouseWheelEventEnabled (BOOL Value) { _SetMouseWheelEventEnabled (m_VideoGrabber, Value); };
                  
                  BOOL GetMultiplexedInputEmulation () { return _GetMultiplexedInputEmulation (m_VideoGrabber); };
                  void SetMultiplexedInputEmulation (BOOL Value) { _SetMultiplexedInputEmulation (m_VideoGrabber, Value); };
                  
                  TMultiplexedRole GetMultiplexedRole () { return _GetMultiplexedRole (m_VideoGrabber); };
                  void SetMultiplexedRole (TMultiplexedRole Value) { _SetMultiplexedRole (m_VideoGrabber, Value); };
                  
                  int GetMultiplexedSwitchDelay () { return _GetMultiplexedSwitchDelay (m_VideoGrabber); };
                  void SetMultiplexedSwitchDelay (int Value) { _SetMultiplexedSwitchDelay (m_VideoGrabber, Value); };
                  
                  int GetMultiplexedStabilizationDelay () { return _GetMultiplexedStabilizationDelay (m_VideoGrabber); };
                  void SetMultiplexedStabilizationDelay (int Value) { _SetMultiplexedStabilizationDelay (m_VideoGrabber, Value); };
                  
                  int GetMultiplexer () { return _GetMultiplexer (m_VideoGrabber); };
                  void SetMultiplexer (int Value) { _SetMultiplexer (m_VideoGrabber, Value); };
                  
                  BOOL GetMuteAudioRendering () { return _GetMuteAudioRendering (m_VideoGrabber); };
                  void SetMuteAudioRendering (BOOL Value) { _SetMuteAudioRendering (m_VideoGrabber, Value); };
                  
                  TNetworkStreaming GetNetworkStreaming () { return _GetNetworkStreaming (m_VideoGrabber); };
                  void SetNetworkStreaming (TNetworkStreaming Value) { _SetNetworkStreaming (m_VideoGrabber, Value); };
                  
                  TNetworkStreamingType GetNetworkStreamingType () { return _GetNetworkStreamingType (m_VideoGrabber); };
                  void SetNetworkStreamingType (TNetworkStreamingType Value) { _SetNetworkStreamingType (m_VideoGrabber, Value); };
                  
                  TNotificationMethod GetNotificationMethod () { return _GetNotificationMethod (m_VideoGrabber); };
                  void SetNotificationMethod (TNotificationMethod Value) { _SetNotificationMethod (m_VideoGrabber, Value); };
                  
                  int GetNotificationSleepTime () { return _GetNotificationSleepTime (m_VideoGrabber); };
                  void SetNotificationSleepTime (int Value) { _SetNotificationSleepTime (m_VideoGrabber, Value); };
                  
                  TThreadPriority GetNotificationPriority () { return _GetNotificationPriority (m_VideoGrabber); };
                  void SetNotificationPriority (TThreadPriority Value) { _SetNotificationPriority (m_VideoGrabber, Value); };
                  
                  BOOL GetOverlayAfterTransform () { return _GetOverlayAfterTransform (m_VideoGrabber); };
                  void SetOverlayAfterTransform (BOOL Value) { _SetOverlayAfterTransform (m_VideoGrabber, Value); };
                  
                  BOOL GetPlayerAudioRendering () { return _GetPlayerAudioRendering (m_VideoGrabber); };
                  void SetPlayerAudioRendering (BOOL Value) { _SetPlayerAudioRendering (m_VideoGrabber, Value); };
                  
                  TDVSize GetPlayerDVSize () { return _GetPlayerDVSize (m_VideoGrabber); };
                  void SetPlayerDVSize (TDVSize Value) { _SetPlayerDVSize (m_VideoGrabber, Value); };
                  
                  int GetPlayerFastSeekSpeedRatio () { return _GetPlayerFastSeekSpeedRatio (m_VideoGrabber); };
                  void SetPlayerFastSeekSpeedRatio (int Value) { _SetPlayerFastSeekSpeedRatio (m_VideoGrabber, Value); };
                  
                  wchar_t * GetPlayerFileName () { return _GetPlayerFileName (m_VideoGrabber); };
                  void SetPlayerFileName (wchar_t * Value) { _SetPlayerFileName (m_VideoGrabber, Value); };
                  
                  wchar_t * GetPlayerForcedCodec () { return _GetPlayerForcedCodec (m_VideoGrabber); };
                  void SetPlayerForcedCodec (wchar_t * Value) { _SetPlayerForcedCodec (m_VideoGrabber, Value); };
                  
                  BOOL GetPlayerRefreshPausedDisplay () { return _GetPlayerRefreshPausedDisplay (m_VideoGrabber); };
                  void SetPlayerRefreshPausedDisplay (BOOL Value) { _SetPlayerRefreshPausedDisplay (m_VideoGrabber, Value); };
                  
                  double GetPlayerRefreshPausedDisplayFrameRate () { return _GetPlayerRefreshPausedDisplayFrameRate (m_VideoGrabber); };
                  void SetPlayerRefreshPausedDisplayFrameRate (double Value) { _SetPlayerRefreshPausedDisplayFrameRate (m_VideoGrabber, Value); };
                  
                  double GetPlayerSpeedRatio () { return _GetPlayerSpeedRatio (m_VideoGrabber); };
                  void SetPlayerSpeedRatio (double Value) { _SetPlayerSpeedRatio (m_VideoGrabber, Value); };
                  
                  BOOL GetPlayerTrackBarSynchrone () { return _GetPlayerTrackBarSynchrone (m_VideoGrabber); };
                  void SetPlayerTrackBarSynchrone (BOOL Value) { _SetPlayerTrackBarSynchrone (m_VideoGrabber, Value); };
                  
                  BOOL GetPreallocCapFileCopiedAfterRecording () { return _GetPreallocCapFileCopiedAfterRecording (m_VideoGrabber); };
                  void SetPreallocCapFileCopiedAfterRecording (BOOL Value) { _SetPreallocCapFileCopiedAfterRecording (m_VideoGrabber, Value); };
                  
                  BOOL GetPreallocCapFileEnabled () { return _GetPreallocCapFileEnabled (m_VideoGrabber); };
                  void SetPreallocCapFileEnabled (BOOL Value) { _SetPreallocCapFileEnabled (m_VideoGrabber, Value); };
                  
                  wchar_t * GetPreallocCapFileName () { return _GetPreallocCapFileName (m_VideoGrabber); };
                  void SetPreallocCapFileName (wchar_t * Value) { _SetPreallocCapFileName (m_VideoGrabber, Value); };
                  
                  int GetPreallocCapFileSizeInMB () { return _GetPreallocCapFileSizeInMB (m_VideoGrabber); };
                  void SetPreallocCapFileSizeInMB (int Value) { _SetPreallocCapFileSizeInMB (m_VideoGrabber, Value); };
                  
                  int GetPreviewZoomSize () { return _GetPreviewZoomSize (m_VideoGrabber); };
                  void SetPreviewZoomSize (int Value) { _SetPreviewZoomSize (m_VideoGrabber, Value); };
                  
                  int GetRecordingAudioBitRate () { return _GetRecordingAudioBitRate (m_VideoGrabber); };
                  void SetRecordingAudioBitRate (int Value) { _SetRecordingAudioBitRate (m_VideoGrabber, Value); };
                  
                  int GetRecordingVideoBitRate () { return _GetRecordingVideoBitRate (m_VideoGrabber); };
                  void SetRecordingVideoBitRate (int Value) { _SetRecordingVideoBitRate (m_VideoGrabber, Value); };
                  
                  wchar_t * GetRecordingFileName () { return _GetRecordingFileName (m_VideoGrabber); };
                  void SetRecordingFileName (wchar_t * Value) { _SetRecordingFileName (m_VideoGrabber, Value); };
                  
                  BOOL GetRecordingInNativeFormat () { return _GetRecordingInNativeFormat (m_VideoGrabber); };
                  void SetRecordingInNativeFormat (BOOL Value) { _SetRecordingInNativeFormat (m_VideoGrabber, Value); };
                  
                  TRecordingMethod GetRecordingMethod () { return _GetRecordingMethod (m_VideoGrabber); };
                  void SetRecordingMethod (TRecordingMethod Value) { _SetRecordingMethod (m_VideoGrabber, Value); };
                  
                  BOOL GetRecordingPauseCreatesNewFile () { return _GetRecordingPauseCreatesNewFile (m_VideoGrabber); };
                  void SetRecordingPauseCreatesNewFile (BOOL Value) { _SetRecordingPauseCreatesNewFile (m_VideoGrabber, Value); };
                  
                  BOOL GetRecordingOnMotion_Enabled () { return _GetRecordingOnMotion_Enabled (m_VideoGrabber); };
                  void SetRecordingOnMotion_Enabled (BOOL Value) { _SetRecordingOnMotion_Enabled (m_VideoGrabber, Value); };
                  
                  double GetRecordingOnMotion_MotionThreshold () { return _GetRecordingOnMotion_MotionThreshold (m_VideoGrabber); };
                  void SetRecordingOnMotion_MotionThreshold (double Value) { _SetRecordingOnMotion_MotionThreshold (m_VideoGrabber, Value); };
                  
                  TRecordingTimer GetRecordingTimer () { return _GetRecordingTimer (m_VideoGrabber); };
                  void SetRecordingTimer (TRecordingTimer Value) { _SetRecordingTimer (m_VideoGrabber, Value); };
                  
                  int GetRecordingTimerInterval () { return _GetRecordingTimerInterval (m_VideoGrabber); };
                  void SetRecordingTimerInterval (int Value) { _SetRecordingTimerInterval (m_VideoGrabber, Value); };
                  
                  int GetRecordingOnMotion_NoMotionPauseDelayMs () { return _GetRecordingOnMotion_NoMotionPauseDelayMs (m_VideoGrabber); };
                  void SetRecordingOnMotion_NoMotionPauseDelayMs (int Value) { _SetRecordingOnMotion_NoMotionPauseDelayMs (m_VideoGrabber, Value); };
                  
                  wchar_t * GetReencoding_NewVideoClip () { return _GetReencodingNewVideoClip (m_VideoGrabber); };
                  void SetReencoding_NewVideoClip (wchar_t * Value) { _SetReencodingNewVideoClip (m_VideoGrabber, Value); };
                  
                  wchar_t * GetReencoding_SourceVideoClip () { return _GetReencodingSourceVideoClip (m_VideoGrabber); };
                  void SetReencoding_SourceVideoClip (wchar_t * Value) { _SetReencodingSourceVideoClip (m_VideoGrabber, Value); };
                  
                  TCursors GetBusyCursor () { return _GetBusyCursor (m_VideoGrabber); };
                  void SetBusyCursor (TCursors Value) { _SetBusyCursor (m_VideoGrabber, Value); };
                  
                  TCursors GetVideoCursor () { return _GetVideoCursor (m_VideoGrabber); };
                  void SetVideoCursor (TCursors Value) { _SetVideoCursor (m_VideoGrabber, Value); };
                  
                  TCursors GetNormalCursor () { return _GetNormalCursor (m_VideoGrabber); };
                  void SetNormalCursor (TCursors Value) { _SetNormalCursor (m_VideoGrabber, Value); };
                  
                  __int64 GetReencoding_StartTime () { return _GetReencodingStartTime (m_VideoGrabber); };
                  void SetReencoding_StartTime (__int64 Value) { _SetReencodingStartTime (m_VideoGrabber, Value); };
                  
                  __int64 GetReencoding_StartFrame () { return _GetReencodingStartFrame (m_VideoGrabber); };
                  void SetReencoding_StartFrame (__int64 Value) { _SetReencodingStartFrame (m_VideoGrabber, Value); };
                  
                  __int64 GetReencoding_StopTime () { return _GetReencodingStopTime (m_VideoGrabber); };
                  void SetReencoding_StopTime (__int64 Value) { _SetReencodingStopTime (m_VideoGrabber, Value); };
                  
                  __int64 GetReencoding_StopFrame () { return _GetReencodingStopFrame (m_VideoGrabber); };
                  void SetReencoding_StopFrame (__int64 Value) { _SetReencodingStopFrame (m_VideoGrabber, Value); };
                  
                  BOOL GetReencoding_IncludeAudioStream () { return _GetReencodingIncludeAudioStream (m_VideoGrabber); };
                  void SetReencoding_IncludeAudioStream (BOOL Value) { _SetReencodingIncludeAudioStream (m_VideoGrabber, Value); };
                  
                  BOOL GetReencoding_IncludeVideoStream () { return _GetReencodingIncludeVideoStream (m_VideoGrabber); };
                  void SetReencoding_IncludeVideoStream (BOOL Value) { _SetReencodingIncludeVideoStream (m_VideoGrabber, Value); };
                  
                  TRecordingMethod GetReencoding_Method () { return _GetReencodingMethod (m_VideoGrabber); };
                  void SetReencoding_Method (TRecordingMethod Value) { _SetReencodingMethod (m_VideoGrabber, Value); };
                  
                  BOOL GetReencoding_UseAudioCompressor () { return _GetReencodingUseAudioCompressor (m_VideoGrabber); };
                  void SetReencoding_UseAudioCompressor (BOOL Value) { _SetReencodingUseAudioCompressor (m_VideoGrabber, Value); };
                  
                  BOOL GetReencoding_UseFrameGrabber () { return _GetReencodingUseFrameGrabber (m_VideoGrabber); };
                  void SetReencoding_UseFrameGrabber (BOOL Value) { _SetReencodingUseFrameGrabber (m_VideoGrabber, Value); };
                  
                  BOOL GetReencoding_UseVideoCompressor () { return _GetReencodingUseVideoCompressor (m_VideoGrabber); };
                  void SetReencoding_UseVideoCompressor (BOOL Value) { _SetReencodingUseVideoCompressor (m_VideoGrabber, Value); };
                  
                  BOOL GetReencoding_WMVOutput () { return _GetReencodingWMVOutput (m_VideoGrabber); };
                  void SetReencoding_WMVOutput (BOOL Value) { _SetReencodingWMVOutput (m_VideoGrabber, Value); };
                  
                  BOOL GetQuickDeviceInitialization () { return _GetQuickDeviceInitialization (m_VideoGrabber); };
                  void SetQuickDeviceInitialization (BOOL Value) { _SetQuickDeviceInitialization (m_VideoGrabber, Value); };
                  
                  BOOL GetRawAudioSampleCapture () { return _GetRawAudioSampleCapture (m_VideoGrabber); };
                  void SetRawAudioSampleCapture (BOOL Value) { _SetRawAudioSampleCapture (m_VideoGrabber, Value); };
                  
                  BOOL GetRawCaptureAsyncEvent () { return _GetRawCaptureAsyncEvent (m_VideoGrabber); };
                  void SetRawCaptureAsyncEvent (BOOL Value) { _SetRawCaptureAsyncEvent (m_VideoGrabber, Value); };
                  
                  TRawSampleCaptureLocation GetRawSampleCaptureLocation () { return _GetRawSampleCaptureLocation (m_VideoGrabber); };
                  void SetRawSampleCaptureLocation (TRawSampleCaptureLocation Value) { _SetRawSampleCaptureLocation (m_VideoGrabber, Value); };
                  
                  BOOL GetRawVideoSampleCapture () { return _GetRawVideoSampleCapture (m_VideoGrabber); };
                  void SetRawVideoSampleCapture (BOOL Value) { _SetRawVideoSampleCapture (m_VideoGrabber, Value); };
                  
                  TRecordingSize GetRecordingSize () { return _GetRecordingSize (m_VideoGrabber); };
                  void SetRecordingSize (TRecordingSize Value) { _SetRecordingSize (m_VideoGrabber, Value); };
                  
                  BOOL GetScreenRecordingLayeredWindows () { return _GetScreenRecordingLayeredWindows (m_VideoGrabber); };
                  void SetScreenRecordingLayeredWindows (BOOL Value) { _SetScreenRecordingLayeredWindows (m_VideoGrabber, Value); };
                  
                  int GetScreenRecordingMonitor () { return _GetScreenRecordingMonitor (m_VideoGrabber); };
                  void SetScreenRecordingMonitor (int Value) { _SetScreenRecordingMonitor (m_VideoGrabber, Value); };
                  
                  BOOL GetScreenRecordingNonVisibleWindows () { return _GetScreenRecordingNonVisibleWindows (m_VideoGrabber); };
                  void SetScreenRecordingNonVisibleWindows (BOOL Value) { _SetScreenRecordingNonVisibleWindows (m_VideoGrabber, Value); };
                  
                  BOOL GetScreenRecordingThroughClipboard () { return _GetScreenRecordingThroughClipboard (m_VideoGrabber); };
                  void SetScreenRecordingThroughClipboard (BOOL Value) { _SetScreenRecordingThroughClipboard (m_VideoGrabber, Value); };
                  
                  BOOL GetScreenRecordingWithCursor () { return _GetScreenRecordingWithCursor (m_VideoGrabber); };
                  void SetScreenRecordingWithCursor (BOOL Value) { _SetScreenRecordingWithCursor (m_VideoGrabber, Value); };
                  
                  BOOL GetSpeakerControl () { return _GetSpeakerControl (m_VideoGrabber); };
                  void SetSpeakerControl (BOOL Value) { _SetSpeakerControl (m_VideoGrabber, Value); };
                  
                  wchar_t * GetStoragePath () { return _GetStoragePath (m_VideoGrabber); };
                  void SetStoragePath (wchar_t * Value) { _SetStoragePath (m_VideoGrabber, Value); };
                  
                  BOOL GetStoreDeviceSettingsInRegistry () { return _GetStoreDeviceSettingsInRegistry (m_VideoGrabber); };
                  void SetStoreDeviceSettingsInRegistry (BOOL Value) { _SetStoreDeviceSettingsInRegistry (m_VideoGrabber, Value); };
                  
                  TSynchronizationRole GetSynchronizationRole () { return _GetSynchronizationRole (m_VideoGrabber); };
                  void SetSynchronizationRole (TSynchronizationRole Value) { _SetSynchronizationRole (m_VideoGrabber, Value); };
                  
                  BOOL GetSynchronized () { return _GetSynchronized (m_VideoGrabber); };
                  void SetSynchronized (BOOL Value) { _SetSynchronized (m_VideoGrabber, Value); };
                  
                  BOOL GetSyncCommands () { return _GetSyncCommands (m_VideoGrabber); };
                  void SetSyncCommands (BOOL Value) { _SetSyncCommands (m_VideoGrabber, Value); };
                  
                  TSyncPreview GetSyncPreview () { return _GetSyncPreview (m_VideoGrabber); };
                  void SetSyncPreview (TSyncPreview Value) { _SetSyncPreview (m_VideoGrabber, Value); };
                  
                  BOOL GetTextOverlay_Enabled () { return _GetTextOverlayEnabled (m_VideoGrabber); };
                  void SetTextOverlay_Enabled (BOOL Value) { _SetTextOverlayEnabled (m_VideoGrabber, Value); };
                  
                  int GetTextOverlay_Left () { return _GetTextOverlayLeft (m_VideoGrabber); };
                  void SetTextOverlay_Left (int Value) { _SetTextOverlayLeft (m_VideoGrabber, Value); };
                  
                  int GetTextOverlay_Top () { return _GetTextOverlayTop (m_VideoGrabber); };
                  void SetTextOverlay_Top (int Value) { _SetTextOverlayTop (m_VideoGrabber, Value); };
                  
                  int GetTextOverlay_Right () { return _GetTextOverlayRight (m_VideoGrabber); };
                  void SetTextOverlay_Right (int Value) { _SetTextOverlayRight (m_VideoGrabber, Value); };
                  
                  BOOL GetTextOverlay_Scrolling () { return _GetTextOverlayScrolling (m_VideoGrabber); };
                  void SetTextOverlay_Scrolling (BOOL Value) { _SetTextOverlayScrolling (m_VideoGrabber, Value); };
                  
                  int GetTextOverlay_ScrollingSpeed () { return _GetTextOverlayScrollingSpeed (m_VideoGrabber); };
                  void SetTextOverlay_ScrollingSpeed (int Value) { _SetTextOverlayScrollingSpeed (m_VideoGrabber, Value); };
                  
                  BOOL GetTextOverlay_Shadow () { return _GetTextOverlayShadow (m_VideoGrabber); };
                  void SetTextOverlay_Shadow (BOOL Value) { _SetTextOverlayShadow (m_VideoGrabber, Value); };
                  
                  int GetTextOverlay_ShadowColor () { return _GetTextOverlayShadowColor (m_VideoGrabber); };
                  void SetTextOverlay_ShadowColor (int Value) { _SetTextOverlayShadowColor (m_VideoGrabber, Value); };
                  
                  TCardinalDirection GetTextOverlay_ShadowDirection () { return _GetTextOverlayShadowDirection (m_VideoGrabber); };
                  void SetTextOverlay_ShadowDirection (TCardinalDirection Value) { _SetTextOverlayShadowDirection (m_VideoGrabber, Value); };
                  
                  int GetTextOverlay_BkColor () { return _GetTextOverlayBkColor (m_VideoGrabber); };
                  void SetTextOverlay_BkColor (int Value) { _SetTextOverlayBkColor (m_VideoGrabber, Value); };
                  
                  TTextOverlayAlign GetTextOverlay_Align () { return _GetTextOverlayAlign (m_VideoGrabber); };
                  void SetTextOverlay_Align (TTextOverlayAlign Value) { _SetTextOverlayAlign (m_VideoGrabber, Value); };
                  
                  int GetTextOverlay_FontColor () { return _GetTextOverlayFontColor (m_VideoGrabber); };
                  void SetTextOverlay_FontColor (int Value) { _SetTextOverlayFontColor (m_VideoGrabber, Value); };
                  
                  wchar_t * GetTextOverlay_String () { return _GetTextOverlayString (m_VideoGrabber); };
                  void SetTextOverlay_String (wchar_t * Value) { _SetTextOverlayString (m_VideoGrabber, Value); };
                  
                  BOOL GetTextOverlay_Transparent () { return _GetTextOverlayTransparent (m_VideoGrabber); };
                  void SetTextOverlay_Transparent (BOOL Value) { _SetTextOverlayTransparent (m_VideoGrabber, Value); };
                  
                  wchar_t * GetThirdPartyDeinterlacer () { return _GetThirdPartyDeinterlacer (m_VideoGrabber); };
                  void SetThirdPartyDeinterlacer (wchar_t * Value) { _SetThirdPartyDeinterlacer (m_VideoGrabber, Value); };
                  
                  BOOL GetTranslateMouseCoordinates () { return _GetTranslateMouseCoordinates (m_VideoGrabber); };
                  void SetTranslateMouseCoordinates (BOOL Value) { _SetTranslateMouseCoordinates (m_VideoGrabber, Value); };
                  
                  BOOL GetTVUseFrequencyOverrides () { return _GetTVUseFrequencyOverrides (m_VideoGrabber); };
                  void SetTVUseFrequencyOverrides (BOOL Value) { _SetTVUseFrequencyOverrides (m_VideoGrabber, Value); };
                  
                  int GetTunerFrequency () { return _GetTunerFrequency (m_VideoGrabber); };
                  void SetTunerFrequency (int Value) { _SetTunerFrequency (m_VideoGrabber, Value); };
                  
                  BOOL GetUseClock () { return _GetUseClock (m_VideoGrabber); };
                  void SetUseClock (BOOL Value) { _SetUseClock (m_VideoGrabber, Value); };
                  
                  wchar_t * GetVersion () { return _GetVersion (m_VideoGrabber); };
                  void SetVersion (wchar_t * Value) { _SetVersion (m_VideoGrabber, Value); };
                  
                  int GetVideoDevice () { return _GetVideoDevice (m_VideoGrabber); };
                  void SetVideoDevice (int Value) { _SetVideoDevice (m_VideoGrabber, Value); };
                  
                  int GetVideoCompression_DataRate () { return _GetVideoCompression_DataRate (m_VideoGrabber); };
                  void SetVideoCompression_DataRate (int Value) { _SetVideoCompression_DataRate (m_VideoGrabber, Value); };
                  
                  int GetVideoCompression_KeyFrameRate () { return _GetVideoCompression_KeyFrameRate (m_VideoGrabber); };
                  void SetVideoCompression_KeyFrameRate (int Value) { _SetVideoCompression_KeyFrameRate (m_VideoGrabber, Value); };
                  
                  int GetVideoCompression_PFramesPerKeyFrame () { return _GetVideoCompression_PFramesPerKeyFrame (m_VideoGrabber); };
                  void SetVideoCompression_PFramesPerKeyFrame (int Value) { _SetVideoCompression_PFramesPerKeyFrame (m_VideoGrabber, Value); };
                  
                  double GetVideoCompression_Quality () { return _GetVideoCompression_Quality (m_VideoGrabber); };
                  void SetVideoCompression_Quality (double Value) { _SetVideoCompression_Quality (m_VideoGrabber, Value); };
                  
                  int GetVideoCompression_WindowSize () { return _GetVideoCompression_WindowSize (m_VideoGrabber); };
                  void SetVideoCompression_WindowSize (int Value) { _SetVideoCompression_WindowSize (m_VideoGrabber, Value); };
                  
                  int GetVideoCompressor () { return _GetVideoCompressor (m_VideoGrabber); };
                  void SetVideoCompressor (int Value) { _SetVideoCompressor (m_VideoGrabber, Value); };
                  
                  BOOL GetVideoControlSettings () { return _GetVideoControlSettings (m_VideoGrabber); };
                  void SetVideoControlSettings (BOOL Value) { _SetVideoControlSettings (m_VideoGrabber, Value); };
                  
                  int GetVideoFormat () { return _GetVideoFormat (m_VideoGrabber); };
                  void SetVideoFormat (int Value) { _SetVideoFormat (m_VideoGrabber, Value); };
                  
                  TFileSort GetVideoFromImages_BitmapsSortedBy () { return _GetVideoFromImages_BitmapsSortedBy (m_VideoGrabber); };
                  void SetVideoFromImages_BitmapsSortedBy (TFileSort Value) { _SetVideoFromImages_BitmapsSortedBy (m_VideoGrabber, Value); };
                  
                  BOOL GetVideoFromImages_RepeatIndefinitely () { return _GetVideoFromImages_RepeatIndefinitely (m_VideoGrabber); };
                  void SetVideoFromImages_RepeatIndefinitely (BOOL Value) { _SetVideoFromImages_RepeatIndefinitely (m_VideoGrabber, Value); };
                  
                  wchar_t * GetVideoFromImages_SourceDirectory () { return _GetVideoFromImages_SourceDirectory (m_VideoGrabber); };
                  void SetVideoFromImages_SourceDirectory (wchar_t * Value) { _SetVideoFromImages_SourceDirectory (m_VideoGrabber, Value); };
                  
                  wchar_t * GetVideoFromImages_TemporaryFile () { return _GetVideoFromImages_TemporaryFile (m_VideoGrabber); };
                  void SetVideoFromImages_TemporaryFile (wchar_t * Value) { _SetVideoFromImages_TemporaryFile (m_VideoGrabber, Value); };
                  
                  int GetVideoInput () { return _GetVideoInput (m_VideoGrabber); };
                  void SetVideoInput (int Value) { _SetVideoInput (m_VideoGrabber, Value); };
                  
                  int GetVideoProcessing_Brightness () { return _GetVideoProcessingBrightness (m_VideoGrabber); };
                  void SetVideoProcessing_Brightness (int Value) { _SetVideoProcessingBrightness (m_VideoGrabber, Value); };
                  
                  int GetVideoProcessing_Contrast () { return _GetVideoProcessingContrast (m_VideoGrabber); };
                  void SetVideoProcessing_Contrast (int Value) { _SetVideoProcessingContrast (m_VideoGrabber, Value); };
                  
                  TVideoDeinterlacing GetVideoProcessing_Deinterlacing () { return _GetVideoProcessingDeinterlacing (m_VideoGrabber); };
                  void SetVideoProcessing_Deinterlacing (TVideoDeinterlacing Value) { _SetVideoProcessingDeinterlacing (m_VideoGrabber, Value); };
                  
                  BOOL GetVideoProcessing_FlipHorizontal () { return _GetVideoProcessingLeftRight (m_VideoGrabber); };
                  void SetVideoProcessing_FlipHorizontal (BOOL Value) { _SetVideoProcessingLeftRight (m_VideoGrabber, Value); };
                  
                  BOOL GetVideoProcessing_FlipVertical () { return _GetVideoProcessingTopDown (m_VideoGrabber); };
                  void SetVideoProcessing_FlipVertical (BOOL Value) { _SetVideoProcessingTopDown (m_VideoGrabber, Value); };
                  
                  BOOL GetVideoProcessing_GrayScale () { return _GetVideoProcessingGrayScale (m_VideoGrabber); };
                  void SetVideoProcessing_GrayScale (BOOL Value) { _SetVideoProcessingGrayScale (m_VideoGrabber, Value); };
                  
                  int GetVideoProcessing_Hue () { return _GetVideoProcessingHue (m_VideoGrabber); };
                  void SetVideoProcessing_Hue (int Value) { _SetVideoProcessingHue (m_VideoGrabber, Value); };
                  
                  BOOL GetVideoProcessing_InvertColors () { return _GetVideoProcessingInvertColors (m_VideoGrabber); };
                  void SetVideoProcessing_InvertColors (BOOL Value) { _SetVideoProcessingInvertColors (m_VideoGrabber, Value); };
                  
                  int GetVideoProcessing_Pixellization () { return _GetVideoProcessingPixellization (m_VideoGrabber); };
                  void SetVideoProcessing_Pixellization (int Value) { _SetVideoProcessingPixellization (m_VideoGrabber, Value); };
                  
                  int GetVideoProcessing_Saturation () { return _GetVideoProcessingSaturation (m_VideoGrabber); };
                  void SetVideoProcessing_Saturation (int Value) { _SetVideoProcessingSaturation (m_VideoGrabber, Value); };
                  
                  TVideoRotation GetVideoProcessing_Rotation () { return _GetVideoProcessingRotation (m_VideoGrabber); };
                  void SetVideoProcessing_Rotation (TVideoRotation Value) { _SetVideoProcessingRotation (m_VideoGrabber, Value); };
                  
                  double GetVideoProcessing_RotationCustomAngle () { return _GetVideoProcessingRotationCustomAngle (m_VideoGrabber); };
                  void SetVideoProcessing_RotationCustomAngle (double Value) { _SetVideoProcessingRotationCustomAngle (m_VideoGrabber, Value); };
                  
                  BOOL GetVideoQualitySettings () { return _GetVideoQualitySettings (m_VideoGrabber); };
                  void SetVideoQualitySettings (BOOL Value) { _SetVideoQualitySettings (m_VideoGrabber, Value); };
                  
                  TVideoRenderer GetVideoRenderer () { return _GetVideoRenderer (m_VideoGrabber); };
                  void SetVideoRenderer (TVideoRenderer Value) { _SetVideoRenderer (m_VideoGrabber, Value); };
                  
                  TVideoRendererExternal GetVideoRendererExternal () { return _GetVideoRendererExternal (m_VideoGrabber); };
                  void SetVideoRendererExternal (TVideoRendererExternal Value) { _SetVideoRendererExternal (m_VideoGrabber, Value); };
                  
                  int GetVideoRendererExternalIndex () { return _GetVideoRendererExternalIndex (m_VideoGrabber); };
                  void SetVideoRendererExternalIndex (int Value) { _SetVideoRendererExternalIndex (m_VideoGrabber, Value); };
                  
                  int GetVideoSize () { return _GetVideoSize (m_VideoGrabber); };
                  void SetVideoSize (int Value) { _SetVideoSize (m_VideoGrabber, Value); };
                  
                  TVideoSource GetVideoSource () { return _GetVideoSource (m_VideoGrabber); };
                  void SetVideoSource (TVideoSource Value) { _SetVideoSource (m_VideoGrabber, Value); };
                  
                  wchar_t * GetVideoSource_FileOrURL () { return _GetVideoSource_FileOrURL (m_VideoGrabber); };
                  void SetVideoSource_FileOrURL (wchar_t * Value) { _SetVideoSource_FileOrURL (m_VideoGrabber, Value); };
                  
                  __int64 GetVideoSource_FileOrURL_StartTime () { return _GetVideoSource_FileOrURL_StartTime (m_VideoGrabber); };
                  void SetVideoSource_FileOrURL_StartTime (__int64 Value) { _SetVideoSource_FileOrURL_StartTime (m_VideoGrabber, Value); };
                  
                  __int64 GetVideoSource_FileOrURL_StopTime () { return _GetVideoSource_FileOrURL_StopTime (m_VideoGrabber); };
                  void SetVideoSource_FileOrURL_StopTime (__int64 Value) { _SetVideoSource_FileOrURL_StopTime (m_VideoGrabber, Value); };
                  
                  int GetVideoSubtype () { return _GetVideoSubtype (m_VideoGrabber); };
                  void SetVideoSubtype (int Value) { _SetVideoSubtype (m_VideoGrabber, Value); };
                  
                  BOOL GetVideoVisibleWhenStopped () { return _GetVideoVisibleWhenStopped (m_VideoGrabber); };
                  void SetVideoVisibleWhenStopped (BOOL Value) { _SetVideoVisibleWhenStopped (m_VideoGrabber, Value); };
                  
                  int GetVirtualVideoStreamControl () { return _GetVirtualVideoStreamControl (m_VideoGrabber); };
                  void SetVirtualVideoStreamControl (int Value) { _SetVirtualVideoStreamControl (m_VideoGrabber, Value); };
                  
                  int GetVirtualAudioStreamControl () { return _GetVirtualAudioStreamControl (m_VideoGrabber); };
                  void SetVirtualAudioStreamControl (int Value) { _SetVirtualAudioStreamControl (m_VideoGrabber, Value); };
                  
                  TVuMeter GetVuMeter () { return _GetVuMeter (m_VideoGrabber); };
                  void SetVuMeter (TVuMeter Value) { _SetVuMeter (m_VideoGrabber, Value); };
                  
                  TWebcamStillCaptureButton GetWebcamStillCaptureButton () { return _GetWebcamStillCaptureButton (m_VideoGrabber); };
                  void SetWebcamStillCaptureButton (TWebcamStillCaptureButton Value) { _SetWebcamStillCaptureButton (m_VideoGrabber, Value); };
                  
                  int GetZoomCoeff () { return _GetZoomCoeff (m_VideoGrabber); };
                  void SetZoomCoeff (int Value) { _SetZoomCoeff (m_VideoGrabber, Value); };
                  
                  int GetZoomXCenter () { return _GetZoomXCenter (m_VideoGrabber); };
                  void SetZoomXCenter (int Value) { _SetZoomXCenter (m_VideoGrabber, Value); };
                  
                  int GetZoomYCenter () { return _GetZoomYCenter (m_VideoGrabber); };
                  void SetZoomYCenter (int Value) { _SetZoomYCenter (m_VideoGrabber, Value); };
                  
      //#endregion DeclareProperties
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   
      //#region DeclareEvents
                  void SetOnAudioDeviceSelected (TOnAudioDeviceSelectedCb OnAudioDeviceSelectedCb) { _SetOnAudioDeviceSelected (m_VideoGrabber, OnAudioDeviceSelectedCb); };
                  void SetOnAudioPeak (TOnAudioPeakCb OnAudioPeakCb) { _SetOnAudioPeak (m_VideoGrabber, OnAudioPeakCb); };
                  void SetOnAuthenticationNeeded (TOnAuthenticationNeededCb OnAuthenticationNeededCb) { _SetOnAuthenticationNeeded (m_VideoGrabber, OnAuthenticationNeededCb); };
                  void SetOnAVIDurationUpdated (TOnAVIDurationUpdatedCb OnAVIDurationUpdatedCb) { _SetOnAVIDurationUpdated (m_VideoGrabber, OnAVIDurationUpdatedCb); };
                  void SetOnBacktimedFramesCountReached (TOnBacktimedFramesCountReachedCb OnBacktimedFramesCountReachedCb) { _SetOnBacktimedFramesCountReached (m_VideoGrabber, OnBacktimedFramesCountReachedCb); };
                  void SetOnBitmapsLoadingProgress (TOnBitmapsLoadingProgressCb OnBitmapsLoadingProgressCb) { _SetOnBitmapsLoadingProgress (m_VideoGrabber, OnBitmapsLoadingProgressCb); };
                  void SetOnClick (TOnClickCb OnClickCb) { _SetOnClick (m_VideoGrabber, OnClickCb); };
                  void SetOnClientConnection (TOnClientConnectionCb OnClientConnectionCb) { _SetOnClientConnection (m_VideoGrabber, OnClientConnectionCb); };
                  void SetOnColorKeyChange (TOnColorKeyChangeCb OnColorKeyChangeCb) { _SetOnColorKeyChange (m_VideoGrabber, OnColorKeyChangeCb); };
                  void SetOnCopyPreallocDataCompleted (TOnCopyPreallocDataCompletedCb OnCopyPreallocDataCompletedCb) { _SetOnCopyPreallocDataCompleted (m_VideoGrabber, OnCopyPreallocDataCompletedCb); };
                  void SetOnCopyPreallocDataProgress (TOnCopyPreallocDataProgressCb OnCopyPreallocDataProgressCb) { _SetOnCopyPreallocDataProgress (m_VideoGrabber, OnCopyPreallocDataProgressCb); };
                  void SetOnCopyPreallocDataStarted (TOnCopyPreallocDataStartedCb OnCopyPreallocDataStartedCb) { _SetOnCopyPreallocDataStarted (m_VideoGrabber, OnCopyPreallocDataStartedCb); };
                  void SetOnCreatePreallocFileCompleted (TOnCreatePreallocFileCompletedCb OnCreatePreallocFileCompletedCb) { _SetOnCreatePreallocFileCompleted (m_VideoGrabber, OnCreatePreallocFileCompletedCb); };
                  void SetOnCreatePreallocFileProgress (TOnCreatePreallocFileProgressCb OnCreatePreallocFileProgressCb) { _SetOnCreatePreallocFileProgress (m_VideoGrabber, OnCreatePreallocFileProgressCb); };
                  void SetOnCreatePreallocFileStarted (TOnCreatePreallocFileStartedCb OnCreatePreallocFileStartedCb) { _SetOnCreatePreallocFileStarted (m_VideoGrabber, OnCreatePreallocFileStartedCb); };
                  void SetOnDblClick (TOnDblClickCb OnDblClickCb) { _SetOnDblClick (m_VideoGrabber, OnDblClickCb); };
                  void SetOnDeviceArrivalOrRemoval (TOnDeviceArrivalOrRemovalCb OnDeviceArrivalOrRemovalCb) { _SetOnDeviceArrivalOrRemoval (m_VideoGrabber, OnDeviceArrivalOrRemovalCb); };
                  void SetOnDeviceLost (TOnDeviceLostCb OnDeviceLostCb) { _SetOnDeviceLost (m_VideoGrabber, OnDeviceLostCb); };
                  void SetOnDirectNetworkStreamingHostUrl (TOnDirectNetworkStreamingHostUrlCb OnDirectNetworkStreamingHostUrlCb) { _SetOnDirectNetworkStreamingHostUrl (m_VideoGrabber, OnDirectNetworkStreamingHostUrlCb); };
                  void SetOnDiskFull (TOnDiskFullCb OnDiskFullCb) { _SetOnDiskFull (m_VideoGrabber, OnDiskFullCb); };
                  void SetOnDragDrop (TOnDragDropCb OnDragDropCb) { _SetOnDragDrop (m_VideoGrabber, OnDragDropCb); };
                  void SetOnDragOver (TOnDragOverCb OnDragOverCb) { _SetOnDragOver (m_VideoGrabber, OnDragOverCb); };
                  void SetOnDVCommandCompleted (TOnDVCommandCompletedCb OnDVCommandCompletedCb) { _SetOnDVCommandCompleted (m_VideoGrabber, OnDVCommandCompletedCb); };
                  void SetOnDVDiscontinuity (TOnDVDiscontinuityCb OnDVDiscontinuityCb) { _SetOnDVDiscontinuity (m_VideoGrabber, OnDVDiscontinuityCb); };
                  void SetOnEnumerateWindows (TOnEnumerateWindowsCb OnEnumerateWindowsCb) { _SetOnEnumerateWindows (m_VideoGrabber, OnEnumerateWindowsCb); };
                  void SetOnFilterSelected (TOnFilterSelectedCb OnFilterSelectedCb) { _SetOnFilterSelected (m_VideoGrabber, OnFilterSelectedCb); };
                  void SetOnFirstFrameReceived (TOnFirstFrameReceivedCb OnFirstFrameReceivedCb) { _SetOnFirstFrameReceived (m_VideoGrabber, OnFirstFrameReceivedCb); };
                  void SetOnFrameBitmap (TOnFrameBitmapCb OnFrameBitmapCb) { _SetOnFrameBitmap (m_VideoGrabber, OnFrameBitmapCb); };
                  void SetOnFrameCaptureCompleted (TOnFrameCaptureCompletedCb OnFrameCaptureCompletedCb) { _SetOnFrameCaptureCompleted (m_VideoGrabber, OnFrameCaptureCompletedCb); };
                  void SetOnFrameOverlayUsingDC (TOnFrameOverlayUsingDCCb OnFrameOverlayUsingDCCb) { _SetOnFrameOverlayUsingDC (m_VideoGrabber, OnFrameOverlayUsingDCCb); };
                  void SetOnFrameOverlayUsingDIB (TOnFrameOverlayUsingDIBCb OnFrameOverlayUsingDIBCb) { _SetOnFrameOverlayUsingDIB (m_VideoGrabber, OnFrameOverlayUsingDIBCb); };
                  void SetOnFrameProgress (TOnFrameProgressCb OnFrameProgressCb) { _SetOnFrameProgress (m_VideoGrabber, OnFrameProgressCb); };
                  void SetOnFrameProgress2 (TOnFrameProgress2Cb OnFrameProgress2Cb) { _SetOnFrameProgress2 (m_VideoGrabber, OnFrameProgress2Cb); };
                  void SetOnGraphBuilt (TOnGraphBuiltCb OnGraphBuiltCb) { _SetOnGraphBuilt (m_VideoGrabber, OnGraphBuiltCb); };
                  void SetOnInactive (TOnInactiveCb OnInactiveCb) { _SetOnInactive (m_VideoGrabber, OnInactiveCb); };
                  void SetOnKeyPress (TOnKeyPressCb OnKeyPressCb) { _SetOnKeyPress (m_VideoGrabber, OnKeyPressCb); };
                  void SetOnLastCommandCompleted (TOnLastCommandCompletedCb OnLastCommandCompletedCb) { _SetOnLastCommandCompleted (m_VideoGrabber, OnLastCommandCompletedCb); };
                  void SetOnLog (TOnLogCb OnLogCb) { _SetOnLog (m_VideoGrabber, OnLogCb); };
                  void SetOnMotionDetected (TOnMotionDetectedCb OnMotionDetectedCb) { _SetOnMotionDetected (m_VideoGrabber, OnMotionDetectedCb); };
                  void SetOnMotionNotDetected (TOnMotionNotDetectedCb OnMotionNotDetectedCb) { _SetOnMotionNotDetected (m_VideoGrabber, OnMotionNotDetectedCb); };
                  void SetOnMouseDown (TOnMouseDownCb OnMouseDownCb) { _SetOnMouseDown (m_VideoGrabber, OnMouseDownCb); };
                  void SetOnMouseMove (TOnMouseMoveCb OnMouseMoveCb) { _SetOnMouseMove (m_VideoGrabber, OnMouseMoveCb); };
                  void SetOnMouseUp (TOnMouseUpCb OnMouseUpCb) { _SetOnMouseUp (m_VideoGrabber, OnMouseUpCb); };
                  void SetOnMouseWheel (TOnMouseWheelCb OnMouseWheelCb) { _SetOnMouseWheel (m_VideoGrabber, OnMouseWheelCb); };
                  void SetOnNoVideoDevices (TOnNoVideoDevicesCb OnNoVideoDevicesCb) { _SetOnNoVideoDevices (m_VideoGrabber, OnNoVideoDevicesCb); };
                  void SetOnPlayerBufferingData (TOnPlayerBufferingDataCb OnPlayerBufferingDataCb) { _SetOnPlayerBufferingData (m_VideoGrabber, OnPlayerBufferingDataCb); };
                  void SetOnPlayerEndOfPlaylist (TOnPlayerEndOfPlaylistCb OnPlayerEndOfPlaylistCb) { _SetOnPlayerEndOfPlaylist (m_VideoGrabber, OnPlayerEndOfPlaylistCb); };
                  void SetOnPlayerEndOfStream (TOnPlayerEndOfStreamCb OnPlayerEndOfStreamCb) { _SetOnPlayerEndOfStream (m_VideoGrabber, OnPlayerEndOfStreamCb); };
                  void SetOnPlayerOpened (TOnPlayerOpenedCb OnPlayerOpenedCb) { _SetOnPlayerOpened (m_VideoGrabber, OnPlayerOpenedCb); };
                  void SetOnPlayerStateChanged (TOnPlayerStateChangedCb OnPlayerStateChangedCb) { _SetOnPlayerStateChanged (m_VideoGrabber, OnPlayerStateChangedCb); };
                  void SetOnPlayerUpdateTrackbarPosition (TOnPlayerUpdateTrackbarPositionCb OnPlayerUpdateTrackbarPositionCb) { _SetOnPlayerUpdateTrackbarPosition (m_VideoGrabber, OnPlayerUpdateTrackbarPositionCb); };
                  void SetOnPreviewStarted (TOnPreviewStartedCb OnPreviewStartedCb) { _SetOnPreviewStarted (m_VideoGrabber, OnPreviewStartedCb); };
                  void SetOnRawAudioSample (TOnRawAudioSampleCb OnRawAudioSampleCb) { _SetOnRawAudioSample (m_VideoGrabber, OnRawAudioSampleCb); };
                  void SetOnRawVideoSample (TOnRawVideoSampleCb OnRawVideoSampleCb) { _SetOnRawVideoSample (m_VideoGrabber, OnRawVideoSampleCb); };
                  void SetOnRecordingCompleted (TOnRecordingCompletedCb OnRecordingCompletedCb) { _SetOnRecordingCompleted (m_VideoGrabber, OnRecordingCompletedCb); };
                  void SetOnRecordingPaused (TOnRecordingPausedCb OnRecordingPausedCb) { _SetOnRecordingPaused (m_VideoGrabber, OnRecordingPausedCb); };
                  void SetOnRecordingReadyToStart (TOnRecordingReadyToStartCb OnRecordingReadyToStartCb) { _SetOnRecordingReadyToStart (m_VideoGrabber, OnRecordingReadyToStartCb); };
                  void SetOnRecordingStarted (TOnRecordingStartedCb OnRecordingStartedCb) { _SetOnRecordingStarted (m_VideoGrabber, OnRecordingStartedCb); };
                  void SetOnReencodingCompleted (TOnReencodingCompletedCb OnReencodingCompletedCb) { _SetOnReencodingCompleted (m_VideoGrabber, OnReencodingCompletedCb); };
                  void SetOnReencodingProgress (TOnReencodingProgressCb OnReencodingProgressCb) { _SetOnReencodingProgress (m_VideoGrabber, OnReencodingProgressCb); };
                  void SetOnReencodingStarted (TOnReencodingStartedCb OnReencodingStartedCb) { _SetOnReencodingStarted (m_VideoGrabber, OnReencodingStartedCb); };
                  void SetOnReinitializing (TOnReinitializingCb OnReinitializingCb) { _SetOnReinitializing (m_VideoGrabber, OnReinitializingCb); };
                  void SetOnResizeVideo (TOnResizeVideoCb OnResizeVideoCb) { _SetOnResizeVideo (m_VideoGrabber, OnResizeVideoCb); };
                  void SetOnTextOverlayScrollingCompleted (TOnTextOverlayScrollingCompletedCb OnTextOverlayScrollingCompletedCb) { _SetOnTextOverlayScrollingCompleted (m_VideoGrabber, OnTextOverlayScrollingCompletedCb); };
                  void SetOnThirdPartyFilterConnected (TOnThirdPartyFilterConnectedCb OnThirdPartyFilterConnectedCb) { _SetOnThirdPartyFilterConnected (m_VideoGrabber, OnThirdPartyFilterConnectedCb); };
                  void SetOnTVChannelScanCompleted (TOnTVChannelScanCompletedCb OnTVChannelScanCompletedCb) { _SetOnTVChannelScanCompleted (m_VideoGrabber, OnTVChannelScanCompletedCb); };
                  void SetOnTVChannelScanStarted (TOnTVChannelScanStartedCb OnTVChannelScanStartedCb) { _SetOnTVChannelScanStarted (m_VideoGrabber, OnTVChannelScanStartedCb); };
                  void SetOnTVChannelSelected (TOnTVChannelSelectedCb OnTVChannelSelectedCb) { _SetOnTVChannelSelected (m_VideoGrabber, OnTVChannelSelectedCb); };
                  void SetOnVideoCompressionSettings (TOnVideoCompressionSettingsCb OnVideoCompressionSettingsCb) { _SetOnVideoCompressionSettings (m_VideoGrabber, OnVideoCompressionSettingsCb); };
                  void SetOnVideoDeviceSelected (TOnVideoDeviceSelectedCb OnVideoDeviceSelectedCb) { _SetOnVideoDeviceSelected (m_VideoGrabber, OnVideoDeviceSelectedCb); };
                  void SetOnVideoFromBitmapsNextFrameNeeded (TOnVideoFromBitmapsNextFrameNeededCb OnVideoFromBitmapsNextFrameNeededCb) { _SetOnVideoFromBitmapsNextFrameNeeded (m_VideoGrabber, OnVideoFromBitmapsNextFrameNeededCb); };
      //#endregion DeclareEvents
   };

#endif __cplusplus

#endif VidgrabDecl
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        
