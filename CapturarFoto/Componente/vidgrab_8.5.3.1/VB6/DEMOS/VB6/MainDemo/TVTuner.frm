VERSION 5.00
Begin VB.Form TVTuner 
   BorderStyle     =   0  'None
   Caption         =   "TV tuner"
   ClientHeight    =   3120
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   13995
   ControlBox      =   0   'False
   LinkTopic       =   "Form1"
   LockControls    =   -1  'True
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   208
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   933
   ShowInTaskbar   =   0   'False
   StartUpPosition =   3  'Windows Default
   Begin VB.Frame framTabs 
      BorderStyle     =   0  'None
      Height          =   2700
      Index           =   9
      Left            =   0
      TabIndex        =   0
      Top             =   0
      Width           =   13575
      Begin VB.TextBox mmoChannelLog 
         BackColor       =   &H00C0C0C0&
         Height          =   2415
         Left            =   6480
         MultiLine       =   -1  'True
         TabIndex        =   26
         Top             =   240
         Width           =   7095
      End
      Begin VB.Frame grbTVChannel 
         Caption         =   "TV Channel"
         Height          =   1215
         Left            =   0
         TabIndex        =   17
         Top             =   1440
         Width           =   4935
         Begin VB.Frame grbFrequencyOverride 
            Caption         =   "TV Frequency override"
            Height          =   975
            Left            =   1800
            TabIndex        =   20
            Top             =   160
            Width           =   3015
            Begin VB.CheckBox chkEnableFrequencyOverrides 
               Caption         =   "enabled"
               Height          =   255
               Left            =   120
               TabIndex        =   25
               Top             =   220
               Width           =   975
            End
            Begin VB.CommandButton Command23 
               Caption         =   "delete"
               Height          =   320
               Left            =   1920
               TabIndex        =   24
               Top             =   560
               Width           =   855
            End
            Begin VB.CommandButton Command22 
               Caption         =   "set"
               Height          =   320
               Left            =   1080
               TabIndex        =   23
               Top             =   560
               Width           =   735
            End
            Begin VB.TextBox edtChannelFrequency 
               Height          =   320
               Left            =   120
               TabIndex        =   22
               Top             =   560
               Width           =   855
            End
            Begin VB.CommandButton btnResetAllOverrides 
               Caption         =   "clear all"
               Height          =   320
               Left            =   1920
               TabIndex        =   21
               Top             =   200
               Width           =   855
            End
         End
         Begin VB.CommandButton btnSelect 
            Caption         =   "set"
            Height          =   320
            Left            =   1200
            TabIndex        =   19
            Top             =   480
            Width           =   375
         End
         Begin VB.TextBox edtTVChannel 
            Height          =   320
            Left            =   120
            TabIndex        =   18
            Top             =   480
            Width           =   975
         End
      End
      Begin VB.Frame grbTunerCountryCode 
         Caption         =   "Tuner"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   1395
         Left            =   0
         TabIndex        =   5
         Top             =   0
         Width           =   4935
         Begin VB.Frame grbCountryCode 
            Caption         =   "country code"
            Height          =   735
            Left            =   3480
            TabIndex        =   14
            Top             =   420
            Width           =   1335
            Begin VB.CommandButton btnSetCountryCode 
               Caption         =   "set"
               Height          =   255
               Left            =   720
               TabIndex        =   16
               Top             =   240
               Width           =   375
            End
            Begin VB.TextBox edtCountryCode 
               Height          =   285
               Left            =   120
               TabIndex        =   15
               Top             =   240
               Width           =   495
            End
         End
         Begin VB.Frame rdgTunerInputType 
            Caption         =   "tuner input type"
            Height          =   735
            Left            =   1920
            TabIndex        =   11
            Top             =   420
            Width           =   1455
            Begin VB.OptionButton rdgTunerInputType2 
               Caption         =   "antenna"
               Height          =   255
               Left            =   120
               TabIndex        =   13
               Tag             =   "1"
               Top             =   440
               Width           =   975
            End
            Begin VB.OptionButton rdgTunerInputType1 
               Caption         =   "cable"
               Height          =   255
               Left            =   120
               TabIndex        =   12
               Tag             =   "0"
               Top             =   220
               Width           =   975
            End
         End
         Begin VB.Frame rdgTunerMode 
            Caption         =   "tuner mode"
            Height          =   1095
            Left            =   120
            TabIndex        =   6
            Top             =   220
            Width           =   1695
            Begin VB.OptionButton rdgTunerMode1 
               Caption         =   "TV"
               Height          =   195
               Left            =   120
               TabIndex        =   10
               Tag             =   "0"
               Top             =   200
               Width           =   1455
            End
            Begin VB.OptionButton rdgTunerMode2 
               Caption         =   "FM Radio"
               Height          =   195
               Left            =   120
               TabIndex        =   9
               Tag             =   "1"
               Top             =   400
               Width           =   1455
            End
            Begin VB.OptionButton rdgTunerMode3 
               Caption         =   "AM Radio"
               Height          =   195
               Index           =   0
               Left            =   120
               TabIndex        =   8
               Tag             =   "2"
               Top             =   600
               Width           =   1455
            End
            Begin VB.OptionButton rdgTunerMode4 
               Caption         =   "Digital Satellite"
               Height          =   195
               Index           =   1
               Left            =   120
               TabIndex        =   7
               Tag             =   "3"
               Top             =   800
               Width           =   1455
            End
         End
         Begin VB.Label lblTVTuner 
            AutoSize        =   -1  'True
            Caption         =   "Tuner mode, input type and country code"
            Height          =   195
            Left            =   1200
            TabIndex        =   28
            Top             =   0
            Width           =   2925
         End
      End
      Begin VB.CommandButton btnTunerDialog 
         Caption         =   "tuner dialog"
         Height          =   320
         Left            =   5040
         TabIndex        =   4
         Top             =   480
         Width           =   1335
      End
      Begin VB.Frame grbTVScan 
         Caption         =   "Autoscan"
         Height          =   975
         Left            =   5040
         TabIndex        =   1
         Top             =   1080
         Width           =   1335
         Begin VB.CommandButton btnStartScan 
            Caption         =   "start"
            Height          =   255
            Left            =   120
            TabIndex        =   3
            Top             =   240
            Width           =   1095
         End
         Begin VB.CommandButton btnStopScan 
            Caption         =   "stop"
            Height          =   255
            Left            =   120
            TabIndex        =   2
            Top             =   600
            Width           =   1095
         End
      End
      Begin VB.Label lblTVTunerAvailable 
         Caption         =   "The tuner is not available for this video capture device"
         ForeColor       =   &H000000FF&
         Height          =   255
         Left            =   5040
         TabIndex        =   27
         Top             =   0
         Visible         =   0   'False
         Width           =   4815
      End
   End
End
Attribute VB_Name = "TVTuner"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit





Private Sub Form_Unload(Cancel As Integer)
   If Not MainForm.CanUnload Then
      Hide
      Cancel = True
   End If
End Sub

Private Sub btnResetAllOverrides_Click()
   MainForm.VideoGrabberVB61.TVClearFrequencyOverrides
End Sub

Private Sub btnSelect_Click()
   If IsNumeric(edtTVChannel.Text) Then
      MainForm.VideoGrabberVB61.TVChannel = edtTVChannel.Text
    End If
End Sub

Private Sub btnSetCountryCode_Click()
   If IsNumeric(edtCountryCode.Text) Then
      MainForm.VideoGrabberVB61.TVCountryCode = Val(edtCountryCode)
   End If
End Sub

Private Sub btnTunerDialog_Click()
   MainForm.VideoGrabberVB61.ShowDialog dlg_TVTuner
   MainForm.RefreshVideoDeviceControls
End Sub

Private Sub btnStartScan_Click()
   MainForm.VideoGrabberVB61.TVStartAutoScan
End Sub

Private Sub btnStopScan_Click()
   If MainForm.VideoGrabberVB61.TVStopAutoScan Then
      AddLog mmoChannelLog, "stopping autoscan..."
   End If
End Sub

Private Sub chkEnableFrequencyOverrides_Click()
   MainForm.VideoGrabberVB61.TVUseFrequencyOverrides = chkEnableFrequencyOverrides.Value = Checked
End Sub

Private Sub Command22_Click()
   If IsNumeric(edtTVChannel.Text) And IsNumeric(edtChannelFrequency.Text) Then
      MainForm.VideoGrabberVB61.edtTVChannel.Text , edtChannelFrequency.Text
   End If
End Sub

Private Sub Command23_Click()
   If IsNumeric(edtTVChannel.Text) Then
      MainForm.VideoGrabberVB61.TVSetChannelFrequencyOverride edtTVChannel.Text, -1
   End If
End Sub

Private Sub rdgTunerInputType1_Click()
   MainForm.VideoGrabberVB61.TVTunerInputType = TunerInputCable
End Sub

Private Sub rdgTunerInputType2_Click()
   MainForm.VideoGrabberVB61.TVTunerInputType = TunerInputAntenna
End Sub

Private Sub rdgTunerMode1_Click()
   MainForm.VideoGrabberVB61.TunerMode = tm_TVTuner
End Sub

Private Sub rdgTunerMode2_Click()
   MainForm.VideoGrabberVB61.TunerMode = tm_FMRadioTuner
End Sub

Private Sub rdgTunerMode3_Click(Index As Integer)
   MainForm.VideoGrabberVB61.TunerMode = tm_AMRadioTuner
End Sub

Private Sub rdgTunerMode4_Click(Index As Integer)
   MainForm.VideoGrabberVB61.TunerMode = tm_DigitalSatelliteTuner
End Sub
