
Imports System.Runtime.InteropServices

Friend Class MainForm
    Inherits System.Windows.Forms.Form
#Region "Windows Form Designer generated code "
    Public Sub New()
        MyBase.New()

        If m_vb6FormDefInstance Is Nothing Then
            If m_InitializingDefInstance Then
                m_vb6FormDefInstance = Me
            Else
                Try
                    'For the start-up form, the first instance created is the default instance.
                    If System.Reflection.Assembly.GetExecutingAssembly.EntryPoint.DeclaringType Is Me.GetType Then
                        m_vb6FormDefInstance = Me
                    End If
                Catch
                End Try
            End If
        End If

        'This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub
    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents mmoLog As System.Windows.Forms.TextBox
    Public WithEvents edtDVDateTime As System.Windows.Forms.TextBox
    Public WithEvents edtFrameCount As System.Windows.Forms.TextBox
    Public WithEvents edtStoragePath As System.Windows.Forms.TextBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents mnuExit As System.Windows.Forms.MenuItem
    Public WithEvents mnuFile As System.Windows.Forms.MenuItem
    Public WithEvents mnuAbout As System.Windows.Forms.MenuItem
    Public MainMenu1 As System.Windows.Forms.MainMenu
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Friend WithEvents AxVideoGrabberNET1 As Axvidgrab_NET.AxVideoGrabberNET
    Friend WithEvents mnuPriority As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPriorityDefault As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPriorityIdle As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPriorityNormal As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPriorityHigh As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPriorityRealTime As System.Windows.Forms.MenuItem
    Friend WithEvents tbcTabs As System.Windows.Forms.TabControl
    Friend WithEvents tbpVideoSource As System.Windows.Forms.TabPage
    Friend WithEvents tbpIPCameras As System.Windows.Forms.TabPage
    Friend WithEvents tbpAudio As System.Windows.Forms.TabPage
    Friend WithEvents tbpRecording As System.Windows.Forms.TabPage
    Friend WithEvents tbpNetworkStreaming As System.Windows.Forms.TabPage
    Friend WithEvents tbpPlayer As System.Windows.Forms.TabPage
    Friend WithEvents tbpFrameGrabber As System.Windows.Forms.TabPage
    Friend WithEvents tbpMotionDetection As System.Windows.Forms.TabPage
    Friend WithEvents tbpOverlays As System.Windows.Forms.TabPage
    Friend WithEvents tbpVideoProcessing As System.Windows.Forms.TabPage
    Friend WithEvents tbpDisplay As System.Windows.Forms.TabPage
    Friend WithEvents tbpReencoding As System.Windows.Forms.TabPage
    Friend WithEvents tbpTVTuner As System.Windows.Forms.TabPage
    Friend WithEvents mnuDVCommands As System.Windows.Forms.MenuItem
    Friend WithEvents gbPlayerControl As System.Windows.Forms.GroupBox
    Friend WithEvents tbrPlayer As System.Windows.Forms.TrackBar
    Public WithEvents btnFastFwd As System.Windows.Forms.Button
    Public WithEvents btnFastRew As System.Windows.Forms.Button
    Public WithEvents btnPlay As System.Windows.Forms.Button
    Public WithEvents btnStop As System.Windows.Forms.Button
    Public WithEvents btnPause As System.Windows.Forms.Button
    Public WithEvents btnPlayBackwards As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents tbpVideoFromJPEGsorBitmaps As System.Windows.Forms.TabPage
    Friend WithEvents mnuDVPlay As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDVStop As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDVFreeze As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDVThaw As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDVFF As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDVRew As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDVRecord As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDVRecordFreeze As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDVRecordStrobe As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDVStepFwd As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDVStepRev As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDVModeShuttle As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDVPlayFastestFwd As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDVPlaySlowestFwd As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDVPlayFastestRev As System.Windows.Forms.MenuItem
    Friend WithEvents chkPlayerTrackBarSynchrone As System.Windows.Forms.CheckBox
    Public WithEvents btnFrameStep As System.Windows.Forms.Button
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents tbrZoomY As System.Windows.Forms.TrackBar
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents tbrZoomX As System.Windows.Forms.TrackBar
    Friend WithEvents tbrZoom As System.Windows.Forms.TrackBar
    Friend WithEvents AutoSizeInfo As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents mnuDVPlaySlowestRev As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnFastFwd = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnFastRew = New System.Windows.Forms.Button
        Me.btnPlay = New System.Windows.Forms.Button
        Me.btnStop = New System.Windows.Forms.Button
        Me.btnPause = New System.Windows.Forms.Button
        Me.btnPlayBackwards = New System.Windows.Forms.Button
        Me.btnFrameStep = New System.Windows.Forms.Button
        Me.mmoLog = New System.Windows.Forms.TextBox
        Me.edtDVDateTime = New System.Windows.Forms.TextBox
        Me.edtFrameCount = New System.Windows.Forms.TextBox
        Me.edtStoragePath = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.mnuFile = New System.Windows.Forms.MenuItem
        Me.mnuExit = New System.Windows.Forms.MenuItem
        Me.mnuDVCommands = New System.Windows.Forms.MenuItem
        Me.mnuDVPlay = New System.Windows.Forms.MenuItem
        Me.mnuDVStop = New System.Windows.Forms.MenuItem
        Me.mnuDVFreeze = New System.Windows.Forms.MenuItem
        Me.mnuDVThaw = New System.Windows.Forms.MenuItem
        Me.mnuDVFF = New System.Windows.Forms.MenuItem
        Me.mnuDVRew = New System.Windows.Forms.MenuItem
        Me.mnuDVRecord = New System.Windows.Forms.MenuItem
        Me.mnuDVRecordFreeze = New System.Windows.Forms.MenuItem
        Me.mnuDVRecordStrobe = New System.Windows.Forms.MenuItem
        Me.mnuDVStepFwd = New System.Windows.Forms.MenuItem
        Me.mnuDVStepRev = New System.Windows.Forms.MenuItem
        Me.mnuDVModeShuttle = New System.Windows.Forms.MenuItem
        Me.mnuDVPlayFastestFwd = New System.Windows.Forms.MenuItem
        Me.mnuDVPlaySlowestFwd = New System.Windows.Forms.MenuItem
        Me.mnuDVPlayFastestRev = New System.Windows.Forms.MenuItem
        Me.mnuDVPlaySlowestRev = New System.Windows.Forms.MenuItem
        Me.mnuPriority = New System.Windows.Forms.MenuItem
        Me.mnuPriorityDefault = New System.Windows.Forms.MenuItem
        Me.mnuPriorityIdle = New System.Windows.Forms.MenuItem
        Me.mnuPriorityNormal = New System.Windows.Forms.MenuItem
        Me.mnuPriorityHigh = New System.Windows.Forms.MenuItem
        Me.mnuPriorityRealTime = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.mnuAbout = New System.Windows.Forms.MenuItem
        Me.tbcTabs = New System.Windows.Forms.TabControl
        Me.tbpVideoSource = New System.Windows.Forms.TabPage
        Me.tbpIPCameras = New System.Windows.Forms.TabPage
        Me.tbpAudio = New System.Windows.Forms.TabPage
        Me.tbpRecording = New System.Windows.Forms.TabPage
        Me.tbpVideoFromJPEGsorBitmaps = New System.Windows.Forms.TabPage
        Me.tbpNetworkStreaming = New System.Windows.Forms.TabPage
        Me.tbpPlayer = New System.Windows.Forms.TabPage
        Me.tbpFrameGrabber = New System.Windows.Forms.TabPage
        Me.tbpMotionDetection = New System.Windows.Forms.TabPage
        Me.tbpOverlays = New System.Windows.Forms.TabPage
        Me.tbpVideoProcessing = New System.Windows.Forms.TabPage
        Me.tbpDisplay = New System.Windows.Forms.TabPage
        Me.tbpReencoding = New System.Windows.Forms.TabPage
        Me.tbpTVTuner = New System.Windows.Forms.TabPage
        Me.gbPlayerControl = New System.Windows.Forms.GroupBox
        Me.tbrPlayer = New System.Windows.Forms.TrackBar
        Me.AxVideoGrabberNET1 = New AxVidgrab_NET.AxVideoGrabberNET
        Me.chkPlayerTrackBarSynchrone = New System.Windows.Forms.CheckBox
        Me.tbrZoomY = New System.Windows.Forms.TrackBar
        Me.label4 = New System.Windows.Forms.Label
        Me.label3 = New System.Windows.Forms.Label
        Me.tbrZoomX = New System.Windows.Forms.TrackBar
        Me.tbrZoom = New System.Windows.Forms.TrackBar
        Me.AutoSizeInfo = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.tbcTabs.SuspendLayout()
        Me.gbPlayerControl.SuspendLayout()
        CType(Me.tbrPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxVideoGrabberNET1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbrZoomY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbrZoomX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbrZoom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnFastFwd
        '
        Me.btnFastFwd.BackColor = System.Drawing.SystemColors.Control
        Me.btnFastFwd.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnFastFwd.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFastFwd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnFastFwd.ImageIndex = 0
        Me.btnFastFwd.ImageList = Me.ImageList1
        Me.btnFastFwd.Location = New System.Drawing.Point(232, 16)
        Me.btnFastFwd.Name = "btnFastFwd"
        Me.btnFastFwd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnFastFwd.Size = New System.Drawing.Size(32, 22)
        Me.btnFastFwd.TabIndex = 32
        Me.ToolTip1.SetToolTip(Me.btnFastFwd, "Fast Forward")
        Me.btnFastFwd.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Silver
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        Me.ImageList1.Images.SetKeyName(4, "")
        Me.ImageList1.Images.SetKeyName(5, "")
        Me.ImageList1.Images.SetKeyName(6, "")
        '
        'btnFastRew
        '
        Me.btnFastRew.BackColor = System.Drawing.SystemColors.Control
        Me.btnFastRew.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnFastRew.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFastRew.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnFastRew.ImageIndex = 1
        Me.btnFastRew.ImageList = Me.ImageList1
        Me.btnFastRew.Location = New System.Drawing.Point(194, 16)
        Me.btnFastRew.Name = "btnFastRew"
        Me.btnFastRew.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnFastRew.Size = New System.Drawing.Size(32, 22)
        Me.btnFastRew.TabIndex = 31
        Me.ToolTip1.SetToolTip(Me.btnFastRew, "Rewind")
        Me.btnFastRew.UseVisualStyleBackColor = False
        '
        'btnPlay
        '
        Me.btnPlay.BackColor = System.Drawing.SystemColors.Control
        Me.btnPlay.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnPlay.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPlay.ImageIndex = 2
        Me.btnPlay.ImageList = Me.ImageList1
        Me.btnPlay.Location = New System.Drawing.Point(118, 16)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnPlay.Size = New System.Drawing.Size(32, 22)
        Me.btnPlay.TabIndex = 30
        Me.ToolTip1.SetToolTip(Me.btnPlay, "Play")
        Me.btnPlay.UseVisualStyleBackColor = False
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.SystemColors.Control
        Me.btnStop.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnStop.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnStop.ImageIndex = 3
        Me.btnStop.ImageList = Me.ImageList1
        Me.btnStop.Location = New System.Drawing.Point(43, 16)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnStop.Size = New System.Drawing.Size(32, 22)
        Me.btnStop.TabIndex = 29
        Me.ToolTip1.SetToolTip(Me.btnStop, "Stop")
        Me.btnStop.UseVisualStyleBackColor = False
        '
        'btnPause
        '
        Me.btnPause.BackColor = System.Drawing.SystemColors.Control
        Me.btnPause.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnPause.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPause.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPause.ImageIndex = 4
        Me.btnPause.ImageList = Me.ImageList1
        Me.btnPause.Location = New System.Drawing.Point(80, 16)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnPause.Size = New System.Drawing.Size(32, 22)
        Me.btnPause.TabIndex = 28
        Me.ToolTip1.SetToolTip(Me.btnPause, "Pause")
        Me.btnPause.UseVisualStyleBackColor = False
        '
        'btnPlayBackwards
        '
        Me.btnPlayBackwards.BackColor = System.Drawing.SystemColors.Control
        Me.btnPlayBackwards.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnPlayBackwards.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayBackwards.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPlayBackwards.ImageIndex = 5
        Me.btnPlayBackwards.ImageList = Me.ImageList1
        Me.btnPlayBackwards.Location = New System.Drawing.Point(6, 16)
        Me.btnPlayBackwards.Name = "btnPlayBackwards"
        Me.btnPlayBackwards.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnPlayBackwards.Size = New System.Drawing.Size(32, 22)
        Me.btnPlayBackwards.TabIndex = 27
        Me.ToolTip1.SetToolTip(Me.btnPlayBackwards, "Play Reverse")
        Me.btnPlayBackwards.UseVisualStyleBackColor = False
        '
        'btnFrameStep
        '
        Me.btnFrameStep.BackColor = System.Drawing.SystemColors.Control
        Me.btnFrameStep.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnFrameStep.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFrameStep.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnFrameStep.ImageIndex = 6
        Me.btnFrameStep.ImageList = Me.ImageList1
        Me.btnFrameStep.Location = New System.Drawing.Point(156, 16)
        Me.btnFrameStep.Name = "btnFrameStep"
        Me.btnFrameStep.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnFrameStep.Size = New System.Drawing.Size(32, 22)
        Me.btnFrameStep.TabIndex = 33
        Me.ToolTip1.SetToolTip(Me.btnFrameStep, "Play")
        Me.btnFrameStep.UseVisualStyleBackColor = False
        '
        'mmoLog
        '
        Me.mmoLog.AcceptsReturn = True
        Me.mmoLog.BackColor = System.Drawing.SystemColors.Window
        Me.mmoLog.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.mmoLog.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mmoLog.ForeColor = System.Drawing.SystemColors.WindowText
        Me.mmoLog.Location = New System.Drawing.Point(6, 349)
        Me.mmoLog.MaxLength = 0
        Me.mmoLog.Multiline = True
        Me.mmoLog.Name = "mmoLog"
        Me.mmoLog.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.mmoLog.Size = New System.Drawing.Size(208, 305)
        Me.mmoLog.TabIndex = 17
        '
        'edtDVDateTime
        '
        Me.edtDVDateTime.AcceptsReturn = True
        Me.edtDVDateTime.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.edtDVDateTime.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtDVDateTime.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtDVDateTime.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtDVDateTime.Location = New System.Drawing.Point(6, 325)
        Me.edtDVDateTime.MaxLength = 0
        Me.edtDVDateTime.Name = "edtDVDateTime"
        Me.edtDVDateTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtDVDateTime.Size = New System.Drawing.Size(208, 20)
        Me.edtDVDateTime.TabIndex = 16
        '
        'edtFrameCount
        '
        Me.edtFrameCount.AcceptsReturn = True
        Me.edtFrameCount.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.edtFrameCount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtFrameCount.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtFrameCount.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtFrameCount.Location = New System.Drawing.Point(6, 301)
        Me.edtFrameCount.MaxLength = 0
        Me.edtFrameCount.Name = "edtFrameCount"
        Me.edtFrameCount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtFrameCount.Size = New System.Drawing.Size(208, 20)
        Me.edtFrameCount.TabIndex = 15
        '
        'edtStoragePath
        '
        Me.edtStoragePath.AcceptsReturn = True
        Me.edtStoragePath.BackColor = System.Drawing.SystemColors.Window
        Me.edtStoragePath.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtStoragePath.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtStoragePath.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtStoragePath.Location = New System.Drawing.Point(6, 277)
        Me.edtStoragePath.MaxLength = 0
        Me.edtStoragePath.Name = "edtStoragePath"
        Me.edtStoragePath.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtStoragePath.Size = New System.Drawing.Size(208, 20)
        Me.edtStoragePath.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(6, 261)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(71, 14)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "storage path:"
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuDVCommands, Me.mnuPriority, Me.MenuItem1, Me.mnuAbout})
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuExit})
        Me.mnuFile.Text = "File"
        '
        'mnuExit
        '
        Me.mnuExit.Index = 0
        Me.mnuExit.Text = "Exit"
        '
        'mnuDVCommands
        '
        Me.mnuDVCommands.Index = 1
        Me.mnuDVCommands.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuDVPlay, Me.mnuDVStop, Me.mnuDVFreeze, Me.mnuDVThaw, Me.mnuDVFF, Me.mnuDVRew, Me.mnuDVRecord, Me.mnuDVRecordFreeze, Me.mnuDVRecordStrobe, Me.mnuDVStepFwd, Me.mnuDVStepRev, Me.mnuDVModeShuttle, Me.mnuDVPlayFastestFwd, Me.mnuDVPlaySlowestFwd, Me.mnuDVPlayFastestRev, Me.mnuDVPlaySlowestRev})
        Me.mnuDVCommands.Text = "Send DV Commands"
        '
        'mnuDVPlay
        '
        Me.mnuDVPlay.Index = 0
        Me.mnuDVPlay.Text = "Play"
        '
        'mnuDVStop
        '
        Me.mnuDVStop.Index = 1
        Me.mnuDVStop.Text = "Stop"
        '
        'mnuDVFreeze
        '
        Me.mnuDVFreeze.Index = 2
        Me.mnuDVFreeze.Text = "Freeze"
        '
        'mnuDVThaw
        '
        Me.mnuDVThaw.Index = 3
        Me.mnuDVThaw.Text = "Thaw"
        '
        'mnuDVFF
        '
        Me.mnuDVFF.Index = 4
        Me.mnuDVFF.Text = "FF"
        '
        'mnuDVRew
        '
        Me.mnuDVRew.Index = 5
        Me.mnuDVRew.Text = "Rew"
        '
        'mnuDVRecord
        '
        Me.mnuDVRecord.Index = 6
        Me.mnuDVRecord.Text = "Record"
        '
        'mnuDVRecordFreeze
        '
        Me.mnuDVRecordFreeze.Index = 7
        Me.mnuDVRecordFreeze.Text = "Record Freeze"
        '
        'mnuDVRecordStrobe
        '
        Me.mnuDVRecordStrobe.Index = 8
        Me.mnuDVRecordStrobe.Text = "Record Strobe"
        '
        'mnuDVStepFwd
        '
        Me.mnuDVStepFwd.Index = 9
        Me.mnuDVStepFwd.Text = "Step Fwd"
        '
        'mnuDVStepRev
        '
        Me.mnuDVStepRev.Index = 10
        Me.mnuDVStepRev.Text = "Step Rev"
        '
        'mnuDVModeShuttle
        '
        Me.mnuDVModeShuttle.Index = 11
        Me.mnuDVModeShuttle.Text = "Mode Shuttle"
        '
        'mnuDVPlayFastestFwd
        '
        Me.mnuDVPlayFastestFwd.Index = 12
        Me.mnuDVPlayFastestFwd.Text = "Play Fastest Fwd"
        '
        'mnuDVPlaySlowestFwd
        '
        Me.mnuDVPlaySlowestFwd.Index = 13
        Me.mnuDVPlaySlowestFwd.Text = "Play Slowest Fwd"
        '
        'mnuDVPlayFastestRev
        '
        Me.mnuDVPlayFastestRev.Index = 14
        Me.mnuDVPlayFastestRev.Text = "Play Fastest Rev"
        '
        'mnuDVPlaySlowestRev
        '
        Me.mnuDVPlaySlowestRev.Index = 15
        Me.mnuDVPlaySlowestRev.Text = "Plat Slowest Rev"
        '
        'mnuPriority
        '
        Me.mnuPriority.Index = 2
        Me.mnuPriority.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuPriorityDefault, Me.mnuPriorityIdle, Me.mnuPriorityNormal, Me.mnuPriorityHigh, Me.mnuPriorityRealTime})
        Me.mnuPriority.Text = "Priority"
        '
        'mnuPriorityDefault
        '
        Me.mnuPriorityDefault.Index = 0
        Me.mnuPriorityDefault.Text = "Default"
        '
        'mnuPriorityIdle
        '
        Me.mnuPriorityIdle.Index = 1
        Me.mnuPriorityIdle.Text = "Idle"
        '
        'mnuPriorityNormal
        '
        Me.mnuPriorityNormal.Index = 2
        Me.mnuPriorityNormal.Text = "Normal"
        '
        'mnuPriorityHigh
        '
        Me.mnuPriorityHigh.Index = 3
        Me.mnuPriorityHigh.Text = "High"
        '
        'mnuPriorityRealTime
        '
        Me.mnuPriorityRealTime.Index = 4
        Me.mnuPriorityRealTime.Text = "Real Time"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 3
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2})
        Me.MenuItem1.Text = "Options"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "Reset video capture device settings"
        '
        'mnuAbout
        '
        Me.mnuAbout.Index = 4
        Me.mnuAbout.Text = "About"
        '
        'tbcTabs
        '
        Me.tbcTabs.Controls.Add(Me.tbpVideoSource)
        Me.tbcTabs.Controls.Add(Me.tbpIPCameras)
        Me.tbcTabs.Controls.Add(Me.tbpAudio)
        Me.tbcTabs.Controls.Add(Me.tbpRecording)
        Me.tbcTabs.Controls.Add(Me.tbpVideoFromJPEGsorBitmaps)
        Me.tbcTabs.Controls.Add(Me.tbpNetworkStreaming)
        Me.tbcTabs.Controls.Add(Me.tbpPlayer)
        Me.tbcTabs.Controls.Add(Me.tbpFrameGrabber)
        Me.tbcTabs.Controls.Add(Me.tbpMotionDetection)
        Me.tbcTabs.Controls.Add(Me.tbpOverlays)
        Me.tbcTabs.Controls.Add(Me.tbpVideoProcessing)
        Me.tbcTabs.Controls.Add(Me.tbpDisplay)
        Me.tbcTabs.Controls.Add(Me.tbpReencoding)
        Me.tbcTabs.Controls.Add(Me.tbpTVTuner)
        Me.tbcTabs.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcTabs.Location = New System.Drawing.Point(6, 2)
        Me.tbcTabs.Name = "tbcTabs"
        Me.tbcTabs.Padding = New System.Drawing.Point(5, 3)
        Me.tbcTabs.SelectedIndex = 0
        Me.tbcTabs.Size = New System.Drawing.Size(940, 210)
        Me.tbcTabs.TabIndex = 58
        '
        'tbpVideoSource
        '
        Me.tbpVideoSource.Location = New System.Drawing.Point(4, 23)
        Me.tbpVideoSource.Name = "tbpVideoSource"
        Me.tbpVideoSource.Size = New System.Drawing.Size(932, 183)
        Me.tbpVideoSource.TabIndex = 0
        Me.tbpVideoSource.Text = "video source"
        '
        'tbpIPCameras
        '
        Me.tbpIPCameras.Location = New System.Drawing.Point(4, 23)
        Me.tbpIPCameras.Name = "tbpIPCameras"
        Me.tbpIPCameras.Size = New System.Drawing.Size(932, 183)
        Me.tbpIPCameras.TabIndex = 1
        Me.tbpIPCameras.Text = "IP cameras"
        '
        'tbpAudio
        '
        Me.tbpAudio.Location = New System.Drawing.Point(4, 23)
        Me.tbpAudio.Name = "tbpAudio"
        Me.tbpAudio.Size = New System.Drawing.Size(932, 183)
        Me.tbpAudio.TabIndex = 2
        Me.tbpAudio.Text = "audio"
        '
        'tbpRecording
        '
        Me.tbpRecording.Location = New System.Drawing.Point(4, 23)
        Me.tbpRecording.Name = "tbpRecording"
        Me.tbpRecording.Size = New System.Drawing.Size(932, 183)
        Me.tbpRecording.TabIndex = 3
        Me.tbpRecording.Text = "recording"
        '
        'tbpVideoFromJPEGsorBitmaps
        '
        Me.tbpVideoFromJPEGsorBitmaps.Location = New System.Drawing.Point(4, 23)
        Me.tbpVideoFromJPEGsorBitmaps.Name = "tbpVideoFromJPEGsorBitmaps"
        Me.tbpVideoFromJPEGsorBitmaps.Size = New System.Drawing.Size(932, 183)
        Me.tbpVideoFromJPEGsorBitmaps.TabIndex = 13
        Me.tbpVideoFromJPEGsorBitmaps.Text = "img>vid"
        '
        'tbpNetworkStreaming
        '
        Me.tbpNetworkStreaming.Location = New System.Drawing.Point(4, 23)
        Me.tbpNetworkStreaming.Name = "tbpNetworkStreaming"
        Me.tbpNetworkStreaming.Size = New System.Drawing.Size(932, 183)
        Me.tbpNetworkStreaming.TabIndex = 4
        Me.tbpNetworkStreaming.Text = "network streaming & WMV"
        '
        'tbpPlayer
        '
        Me.tbpPlayer.Location = New System.Drawing.Point(4, 23)
        Me.tbpPlayer.Name = "tbpPlayer"
        Me.tbpPlayer.Size = New System.Drawing.Size(932, 183)
        Me.tbpPlayer.TabIndex = 5
        Me.tbpPlayer.Text = "player"
        '
        'tbpFrameGrabber
        '
        Me.tbpFrameGrabber.Location = New System.Drawing.Point(4, 23)
        Me.tbpFrameGrabber.Name = "tbpFrameGrabber"
        Me.tbpFrameGrabber.Size = New System.Drawing.Size(932, 183)
        Me.tbpFrameGrabber.TabIndex = 6
        Me.tbpFrameGrabber.Text = "frame grabber"
        '
        'tbpMotionDetection
        '
        Me.tbpMotionDetection.Location = New System.Drawing.Point(4, 23)
        Me.tbpMotionDetection.Name = "tbpMotionDetection"
        Me.tbpMotionDetection.Size = New System.Drawing.Size(932, 183)
        Me.tbpMotionDetection.TabIndex = 7
        Me.tbpMotionDetection.Text = "motion detection"
        '
        'tbpOverlays
        '
        Me.tbpOverlays.Location = New System.Drawing.Point(4, 23)
        Me.tbpOverlays.Name = "tbpOverlays"
        Me.tbpOverlays.Size = New System.Drawing.Size(932, 183)
        Me.tbpOverlays.TabIndex = 8
        Me.tbpOverlays.Text = "overlays"
        '
        'tbpVideoProcessing
        '
        Me.tbpVideoProcessing.Location = New System.Drawing.Point(4, 23)
        Me.tbpVideoProcessing.Name = "tbpVideoProcessing"
        Me.tbpVideoProcessing.Size = New System.Drawing.Size(932, 183)
        Me.tbpVideoProcessing.TabIndex = 9
        Me.tbpVideoProcessing.Text = "video processing"
        '
        'tbpDisplay
        '
        Me.tbpDisplay.Location = New System.Drawing.Point(4, 23)
        Me.tbpDisplay.Name = "tbpDisplay"
        Me.tbpDisplay.Size = New System.Drawing.Size(932, 183)
        Me.tbpDisplay.TabIndex = 10
        Me.tbpDisplay.Text = "display"
        '
        'tbpReencoding
        '
        Me.tbpReencoding.Location = New System.Drawing.Point(4, 23)
        Me.tbpReencoding.Name = "tbpReencoding"
        Me.tbpReencoding.Size = New System.Drawing.Size(932, 183)
        Me.tbpReencoding.TabIndex = 11
        Me.tbpReencoding.Text = "reencoding"
        '
        'tbpTVTuner
        '
        Me.tbpTVTuner.Location = New System.Drawing.Point(4, 23)
        Me.tbpTVTuner.Name = "tbpTVTuner"
        Me.tbpTVTuner.Size = New System.Drawing.Size(932, 183)
        Me.tbpTVTuner.TabIndex = 12
        Me.tbpTVTuner.Text = "tuner"
        '
        'gbPlayerControl
        '
        Me.gbPlayerControl.Controls.Add(Me.btnFrameStep)
        Me.gbPlayerControl.Controls.Add(Me.btnFastFwd)
        Me.gbPlayerControl.Controls.Add(Me.btnFastRew)
        Me.gbPlayerControl.Controls.Add(Me.btnPlay)
        Me.gbPlayerControl.Controls.Add(Me.btnPause)
        Me.gbPlayerControl.Controls.Add(Me.btnPlayBackwards)
        Me.gbPlayerControl.Controls.Add(Me.tbrPlayer)
        Me.gbPlayerControl.Controls.Add(Me.btnStop)
        Me.gbPlayerControl.Location = New System.Drawing.Point(6, 214)
        Me.gbPlayerControl.Name = "gbPlayerControl"
        Me.gbPlayerControl.Size = New System.Drawing.Size(928, 44)
        Me.gbPlayerControl.TabIndex = 59
        Me.gbPlayerControl.TabStop = False
        Me.gbPlayerControl.Text = "player control"
        '
        'tbrPlayer
        '
        Me.tbrPlayer.AutoSize = False
        Me.tbrPlayer.Location = New System.Drawing.Point(270, 14)
        Me.tbrPlayer.Name = "tbrPlayer"
        Me.tbrPlayer.Size = New System.Drawing.Size(651, 30)
        Me.tbrPlayer.TabIndex = 20
        '
        'AxVideoGrabberNET1
        '
        Me.AxVideoGrabberNET1.Location = New System.Drawing.Point(240, 318)
        Me.AxVideoGrabberNET1.Name = "AxVideoGrabberNET1"
        Me.AxVideoGrabberNET1.OcxState = CType(resources.GetObject("AxVideoGrabberNET1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxVideoGrabberNET1.Size = New System.Drawing.Size(408, 312)
        Me.AxVideoGrabberNET1.TabIndex = 20
        '
        'chkPlayerTrackBarSynchrone
        '
        Me.chkPlayerTrackBarSynchrone.Location = New System.Drawing.Point(773, 248)
        Me.chkPlayerTrackBarSynchrone.Name = "chkPlayerTrackBarSynchrone"
        Me.chkPlayerTrackBarSynchrone.Size = New System.Drawing.Size(154, 18)
        Me.chkPlayerTrackBarSynchrone.TabIndex = 60
        Me.chkPlayerTrackBarSynchrone.Text = "player trackbar synchrone"
        '
        'tbrZoomY
        '
        Me.tbrZoomY.AutoSize = False
        Me.tbrZoomY.Location = New System.Drawing.Point(216, 312)
        Me.tbrZoomY.Maximum = 20000
        Me.tbrZoomY.Minimum = 1000
        Me.tbrZoomY.Name = "tbrZoomY"
        Me.tbrZoomY.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbrZoomY.Size = New System.Drawing.Size(18, 318)
        Me.tbrZoomY.TabIndex = 74
        Me.tbrZoomY.Value = 1000
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(217, 296)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(17, 14)
        Me.label4.TabIndex = 73
        Me.label4.Text = "Y:"
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(217, 273)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(87, 27)
        Me.label3.TabIndex = 72
        Me.label3.Text = "zoom center X:"
        Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbrZoomX
        '
        Me.tbrZoomX.AutoSize = False
        Me.tbrZoomX.Location = New System.Drawing.Point(292, 282)
        Me.tbrZoomX.Maximum = 20000
        Me.tbrZoomX.Minimum = 1000
        Me.tbrZoomX.Name = "tbrZoomX"
        Me.tbrZoomX.Size = New System.Drawing.Size(483, 15)
        Me.tbrZoomX.TabIndex = 71
        Me.tbrZoomX.Value = 1000
        '
        'tbrZoom
        '
        Me.tbrZoom.AutoSize = False
        Me.tbrZoom.Location = New System.Drawing.Point(249, 250)
        Me.tbrZoom.Maximum = 20000
        Me.tbrZoom.Minimum = 1000
        Me.tbrZoom.Name = "tbrZoom"
        Me.tbrZoom.Size = New System.Drawing.Size(537, 26)
        Me.tbrZoom.TabIndex = 70
        Me.tbrZoom.Value = 1000
        '
        'AutoSizeInfo
        '
        Me.AutoSizeInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.AutoSizeInfo.Location = New System.Drawing.Point(246, 300)
        Me.AutoSizeInfo.Name = "AutoSizeInfo"
        Me.AutoSizeInfo.Size = New System.Drawing.Size(693, 20)
        Me.AutoSizeInfo.TabIndex = 75
        Me.AutoSizeInfo.Text = "the component will resize automatically because Display_AutoSize is enabled in th" & _
            "e Form_Load event (default = disabled)"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(213, 248)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(42, 27)
        Me.label2.TabIndex = 76
        Me.label2.Text = "ZOOM:"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MainForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(950, 647)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.tbrZoomY)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.tbrZoomX)
        Me.Controls.Add(Me.tbrZoom)
        Me.Controls.Add(Me.AutoSizeInfo)
        Me.Controls.Add(Me.chkPlayerTrackBarSynchrone)
        Me.Controls.Add(Me.gbPlayerControl)
        Me.Controls.Add(Me.tbcTabs)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AxVideoGrabberNET1)
        Me.Controls.Add(Me.mmoLog)
        Me.Controls.Add(Me.edtDVDateTime)
        Me.Controls.Add(Me.edtFrameCount)
        Me.Controls.Add(Me.edtStoragePath)
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(11, 30)
        Me.Menu = Me.MainMenu1
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DataStead Software - TVideoGrabber demo"
        Me.tbcTabs.ResumeLayout(False)
        Me.gbPlayerControl.ResumeLayout(False)
        CType(Me.tbrPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxVideoGrabberNET1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbrZoomY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbrZoomX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbrZoom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region
#Region "Create MainForm default instance"
    Private Shared m_vb6FormDefInstance As MainForm
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As MainForm
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New MainForm
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As MainForm)
            m_vb6FormDefInstance = Value
        End Set
    End Property
#End Region

    Public Class FreeHandDrawing
        Public Const CMAXCOORDINATESARRAY As Short = 5000
        Public MAXCOORDINATESARRAY As Short = CMAXCOORDINATESARRAY
        Public DrawingEnabled As Boolean = False
        Public iArrayCoordinates As Integer = 0
        Public ArrayCoordinates(CMAXCOORDINATESARRAY + 1) As System.Drawing.Rectangle

        Protected Overrides Sub Finalize()
            MyBase.Finalize()
        End Sub
    End Class

    ' used in the image overlay sample, to pickup a transparent color on the video frame at the last mouse click location
    Public Class PickupColor
        Public MustGetRGBPixel As Boolean = False
        Public LastRGBPixelValueAtMousePosition As Long = -1
        Public MouseXVideoPosition As Integer = 0
        Public MouseYVideoPosition As Integer = 0
    End Class


    Public frmOverlays_edtDrawGrid As Long
    Public frmOverlays_btnDrawGridColor As Color
    Public frmOverlays_btnFreeHandColor As Color

    Public VideoProcessing_DetectNoVideoSignal As Boolean
    Public VideoProcessing_DetectConnexantBlueScreen As Boolean

    Public OldVideoSignalState As Boolean


    Public VideoFromImages As VideoFromImagesFileList
    Public VideoFromImagesUsePictureBox As Boolean

    Public cFreeHandDrawing As FreeHandDrawing
    Public cPickupColor As PickupColor

    Private LastKBWrittenReportTime As Double

    Public frmInsetForm As System.Windows.Forms.Form

    Private StartupWidth As Integer
    Private StartupHeight As Integer
    Private iCountPictureBox As Integer


    Public StartupVGWidth As Integer
    Public StartupVGHeight As Integer


    Public frmVideoSource As VideoSource
    Private frmIPCamera As IPCamera
    Private frmAudio As Audio
    Private frmDisplay As Display
    Private frmFrameGrabber As FrameGrabber
    Private frmMotionDetection As MotionDetection
    Private frmNetworkStreaming As NetworkStreaming
    Private frmOverlays As Overlays
    Private frmPlayer As Player
    Public frmRecording As Recording
    Private frmReencoding As Reencoding
    Private frmSnapform As SnapForm
    Private frmTVTuner As TVTuner
    Private frmVideoProcessing As VideoProcessing
    Private frmVideoFromJPEGsOrBitmaps As VideoFromJPEGsorBitmaps


    Public brushMotionRatio As Brush
    Public boolMotionRatio As Boolean



    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        VideoFromImages = New VideoFromImagesFileList
        VideoFromImagesUsePictureBox = False

        iCountPictureBox = 0

        StartupWidth = Width
        StartupHeight = Height


        frmOverlays_edtDrawGrid = 0
        frmOverlays_btnDrawGridColor = Color.Blue
        frmOverlays_btnFreeHandColor = Color.Red

        StartupVGWidth = AxVideoGrabberNET1.Width
        StartupVGHeight = AxVideoGrabberNET1.Height

        AxVideoGrabberNET1.StoragePath = System.IO.Directory.GetCurrentDirectory()
        AxVideoGrabberNET1.Display_AutoSize = True   ' the control will resize automatically
        AxVideoGrabberNET1.AutoRefreshPreview = True ' the preview will restart automatically when changing device properties (e.g. video size, analog video standard, etc...)

        edtStoragePath.Text = AxVideoGrabberNET1.StoragePath

        cFreeHandDrawing = New FreeHandDrawing
        cPickupColor = New PickupColor

        LastKBWrittenReportTime = 0

        frmVideoSource = New VideoSource
        frmIPCamera = New IPCamera
        frmAudio = New Audio
        frmDisplay = New Display
        frmFrameGrabber = New FrameGrabber
        frmMotionDetection = New MotionDetection
        frmVideoFromJPEGsOrBitmaps = New VideoFromJPEGsorBitmaps
        frmNetworkStreaming = New NetworkStreaming
        frmOverlays = New Overlays
        frmPlayer = New Player
        frmRecording = New Recording
        frmReencoding = New Reencoding
        frmSnapform = New SnapForm
        frmTVTuner = New TVTuner
        frmVideoProcessing = New VideoProcessing

        RefreshControls()


        tbcTabs.SelectedTab = tbpVideoSource
        SelectInsetForm(tbcTabs)


    End Sub

    Public Sub RefreshControls()
        frmVideoSource.RefreshControls()
        frmIPCamera.RefreshControls()
        frmAudio.RefreshControls()
        frmDisplay.RefreshControls()
        frmFrameGrabber.RefreshControls()
        frmMotionDetection.RefreshControls()
        frmNetworkStreaming.RefreshControls()
        frmOverlays.RefreshControls()
        frmPlayer.RefreshControls()
        frmRecording.RefreshControls()
        frmReencoding.RefreshControls()
        frmTVTuner.RefreshControls()
        frmVideoProcessing.RefreshControls()
        frmVideoFromJPEGsOrBitmaps.RefreshControls()
    End Sub

    Private Sub tbcTabs_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbcTabs.SelectedIndexChanged
        SelectInsetForm(tbcTabs)
    End Sub

    Private Sub SelectInsetForm(ByVal Tabs As TabControl)

        If Not frmInsetForm Is Nothing Then
            frmInsetForm.Close()
        End If

        Select Case Tabs.SelectedTab.Name
            Case "tbpVideoSource"
                frmInsetForm = frmVideoSource
            Case "tbpIPCameras"
                frmInsetForm = frmIPCamera
            Case "tbpAudio"
                frmInsetForm = frmAudio
            Case "tbpRecording"
                frmInsetForm = frmRecording
            Case "tbpVideoFromJPEGsorBitmaps"
                frmInsetForm = frmVideoFromJPEGsOrBitmaps
            Case "tbpNetworkStreaming"
                frmInsetForm = frmNetworkStreaming
            Case "tbpPlayer"
                frmInsetForm = frmPlayer
            Case "tbpFrameGrabber"
                frmInsetForm = frmFrameGrabber
            Case "tbpMotionDetection"
                frmInsetForm = frmMotionDetection
            Case "tbpOverlays"
                frmInsetForm = frmOverlays
            Case "tbpVideoProcessing"
                frmInsetForm = frmVideoProcessing
            Case "tbpDisplay"
                frmInsetForm = frmDisplay
            Case "tbpReencoding"
                frmInsetForm = frmReencoding
            Case "tbpTVTuner"
                frmInsetForm = frmTVTuner
        End Select

        If Not frmInsetForm Is Nothing Then
            InsetForms.InsetForm(frmInsetForm, Tabs.SelectedTab.Handle.ToInt32)
            frmInsetForm.Show()
        End If

    End Sub



    Public Sub SetEnumerateWindows(ByVal WindowName As String, ByVal ExactMatch As Boolean)
        ReDim wenScreenRecordingWindow(0)
        lngScreenRecordingWindow = 0
        strScreenRecordingWindow = WindowName
        boolScreenRecordingWindow = ExactMatch
        If strScreenRecordingWindow = "" Then
            frmVideoSource.lblEnumerateWindows.Text = ""
        Else
            frmVideoSource.lblEnumerateWindows.Text = CStr(lngScreenRecordingWindow)
        End If
    End Sub

    Private Sub AxVideoGrabberNET1_OnEnumerateWindows(ByVal sender As Object, ByVal e As AxVidgrab_NET.IVideoGrabberNETEvents_OnEnumerateWindowsEvent) Handles AxVideoGrabberNET1.OnEnumerateWindows
        ' EnumerateWindows begins gathering of visible windows
        ' Demo proc SetEnumerateWindows initializes array wenScreenRecordingWindow(),
        '  called in OnRecordingReadyToStart event, which is instigated by
        '  enabling HoldRecording before calling StartRecording
        '  (see btnStartRecordingControlled in Recording form)
        Dim b As Boolean
        If (LCase(strScreenRecordingWindow) = LCase(e.windowName)) Then
            b = True
        ElseIf (Not boolScreenRecordingWindow) And InStr(1, LCase(e.windowName), LCase(strScreenRecordingWindow)) > 0 Then
            b = True
        Else
            b = False
        End If
        If b Then
            ReDim Preserve wenScreenRecordingWindow(lngScreenRecordingWindow)
            With wenScreenRecordingWindow(lngScreenRecordingWindow)
                .WindowHandle = e.windowHandle
                .WindowClass = e.windowClass
                .WindowName = e.windowName
            End With
            lngScreenRecordingWindow = lngScreenRecordingWindow + 1

            frmVideoSource.lblEnumerateWindows.Text = CStr(lngScreenRecordingWindow)

        End If
    End Sub


    Private Sub AxVideoGrabberNET1_OnVideoDeviceSelected(ByVal sender As Object, ByVal e As System.EventArgs) Handles AxVideoGrabberNET1.OnVideoDeviceSelected
        RefreshControls() ' updates all the ComboBox lists and controls, especially those that depend of the video capture device (like VideoInputs, VideoSubtypes, etc...)
    End Sub

    Private Sub AxVideoGrabberNET1_OnAudioDeviceSelected(ByVal sender As Object, ByVal e As System.EventArgs) Handles AxVideoGrabberNET1.OnAudioDeviceSelected
        RefreshControls() ' updates all the ComboBox lists and controls, especially those that depend of the audio capture device (like AudioInputs, etc...)
    End Sub


    Private Sub AxVideoGrabberNET1_OnFrameBitmap(ByVal sender As System.Object, ByVal e As AxVidgrab_NET.IVideoGrabberNETEvents_OnFrameBitmapEvent) Handles AxVideoGrabberNET1.OnFrameBitmap

        ' please read the (*) comment at the bottom of this page

#If VS2003 Then
        Dim FrameInfo As TFrameInfo = CType(Marshal.PtrToStructure(New IntPtr(CType(e.frameInfo.ToString(), Integer)), GetType(TFrameInfo)), TFrameInfo)
        Dim FrameBitmap As TFrameBitmapInfo = CType(Marshal.PtrToStructure(New IntPtr(CType(e.bitmapInfo.ToString(), Integer)), GetType(TFrameBitmapInfo)), TFrameBitmapInfo)
#Else
        Dim FrameInfo As TFrameInfo = CType(Marshal.PtrToStructure(CType(e.frameInfo, IntPtr), GetType(TFrameInfo)), TFrameInfo)
        Dim FrameBitmap As TFrameBitmapInfo = CType(Marshal.PtrToStructure(CType(e.bitmapInfo, IntPtr), GetType(TFrameBitmapInfo)), TFrameBitmapInfo)
#End If


        ' -----------------------------------------------------------
        ' CopyFrameToBitmapDemo(FrameBitmap);  // CopyFrameToBitmapDemo shows how to make a copy of the current video frame, just uncomment this line to use it
        ' -----------------------------------------------------------

        ' GRID DRAWING
        ' ============

        If frmOverlays_edtDrawGrid > 1 Then

            Dim MyGraphics As Graphics = Graphics.FromHdcInternal(New IntPtr(FrameBitmap.bitmapDC))
            Dim b As SolidBrush = New SolidBrush(frmOverlays_btnDrawGridColor)

            Dim VideoGrabberWidth As Integer = AxVideoGrabberNET1.VideoWidth
            Dim VideoGrabberHeight As Integer = AxVideoGrabberNET1.VideoHeight

            Dim xStep As Integer = CType(VideoGrabberWidth / frmOverlays_edtDrawGrid, Integer)
            Dim yStep As Integer = xStep

            Dim xLocation As Integer = xStep
            Dim yLocation As Integer = yStep

            While xLocation < VideoGrabberWidth
                MyGraphics.FillRectangle(b, xLocation, 0, 1, VideoGrabberHeight)
                xLocation += xStep
            End While

            While yLocation < VideoGrabberHeight
                MyGraphics.FillRectangle(b, 0, yLocation, VideoGrabberWidth, 1)
                yLocation += yStep
            End While

            MyGraphics.Dispose()
        End If

        ' FREE HAND DRAWING
        ' ============

        If cFreeHandDrawing.iArrayCoordinates > 0 Then ' see the VideoGrabberMouse... events

            Dim MyGraphics As Graphics = Graphics.FromHdcInternal(New IntPtr(FrameBitmap.bitmapDC))
            Dim p As Pen = New Pen(frmOverlays_btnFreeHandColor)
            Dim b As SolidBrush = New SolidBrush(frmOverlays_btnFreeHandColor)

            Dim LastX As Integer = 0
            Dim LastY As Integer = 0
            Dim i As Integer

            For i = 0 To cFreeHandDrawing.iArrayCoordinates - 1
                If cFreeHandDrawing.ArrayCoordinates(i).Width = 0 Then '// Width is used as boolean to know if it is a MoveTo or a LineTo
                    LastX = cFreeHandDrawing.ArrayCoordinates(i).X
                    LastY = cFreeHandDrawing.ArrayCoordinates(i).Y
                    MyGraphics.FillRectangle(b, LastX, LastY, 1, 1)
                Else
                    MyGraphics.DrawLine(p, LastX, LastY, cFreeHandDrawing.ArrayCoordinates(i).X, cFreeHandDrawing.ArrayCoordinates(i).Y)
                    LastX = cFreeHandDrawing.ArrayCoordinates(i).X
                    LastY = cFreeHandDrawing.ArrayCoordinates(i).Y
                End If
            Next

            MyGraphics.Dispose()

        End If

        ' VIDEO SIGNAL DETECTION
        ' ============

        Dim NewVideoSignalState As Boolean

        NewVideoSignalState = OldVideoSignalState

        If VideoProcessing_DetectNoVideoSignal Then
            NewVideoSignalState = AxVideoGrabberNET1.IsVideoSignalDetected(False, True, 30, 30, 30, True)
        ElseIf VideoProcessing_DetectConnexantBlueScreen Then
            NewVideoSignalState = AxVideoGrabberNET1.IsVideoSignalDetected(True, False, 0, 0, 0, False)
        End If

        If NewVideoSignalState <> OldVideoSignalState Then
            OldVideoSignalState = NewVideoSignalState
            If NewVideoSignalState Then
                AddLog(mmoLog, "Video signal is back")
            Else
                AddLog(mmoLog, "VIDEO SIGNAL LOST")
            End If
        End If


        ' used in the image overlay sample, to pickup a transparent color on the video frame at the last mouse click location
        If cPickupColor.MustGetRGBPixel Then
            cPickupColor.MustGetRGBPixel = False
            cPickupColor.LastRGBPixelValueAtMousePosition = AxVideoGrabberNET1.GetRGBPixelAt(cPickupColor.MouseXVideoPosition, cPickupColor.MouseYVideoPosition)
        End If
    End Sub

    Private Sub AxVideoGrabberNET1_OnFrameProgress2(ByVal sender As System.Object, ByVal e As AxVidgrab_NET.IVideoGrabberNETEvents_OnFrameProgress2Event) Handles AxVideoGrabberNET1.OnFrameProgress2

#If VS2003 Then
        Dim FrameInfo As TFrameInfo = CType(Marshal.PtrToStructure(New IntPtr(CType(e.frameInfo.ToString(), Integer)), GetType(TFrameInfo)), TFrameInfo)
#Else
        Dim FrameInfo As TFrameInfo = CType(Marshal.PtrToStructure(CType(e.frameInfo, IntPtr), GetType(TFrameInfo)), TFrameInfo)
#End If

        Dim DVTimeCode As String
        Dim DVDateTime As String

        If FrameInfo.currentState = Vidgrab_NET.TxCurrentState.cs_Playback Then ' we don't include the dropped frames during playback
            edtFrameCount.Text = String.Format("frame: {0} time:{1:00}:{2:00}:{3:00}:{4:00}", FrameInfo.frameNumber, FrameInfo.frameTime_Hour, FrameInfo.frameTime_Min, FrameInfo.frameTime_Sec, FrameInfo.frameTime_Hs)
        Else
            edtFrameCount.Text = String.Format("frame: {0} dropped:{1} time:{2:00}:{3:00}:{4:00}:{5:00}", FrameInfo.frameNumber, FrameInfo.droppedFrameCount, FrameInfo.frameTime_Hour, FrameInfo.frameTime_Min, FrameInfo.frameTime_Sec, FrameInfo.frameTime_Hs)
        End If

        If FrameInfo.dVTimeCode_IsAvailable > 0 Then ' if available
            DVTimeCode = String.Format("tc: {0:00}:{1:00}:{2:00}:{3:00}", FrameInfo.dVTimeCode_Hour, FrameInfo.dVTimeCode_Min, FrameInfo.dVTimeCode_Sec, FrameInfo.dVTimeCode_Ff)
        Else
            DVTimeCode = " "
        End If
        If FrameInfo.dVDateTime_IsAvailable > 0 Then ' if available
            DVDateTime = String.Format("dv date: {0:00}/{1:00}/{2:00} {3:00}:{4:00}:{5:00}", FrameInfo.dVDateTime_Day, FrameInfo.dVDateTime_Month, FrameInfo.dVDateTime_Year, FrameInfo.dVDateTime_Hour, FrameInfo.dVDateTime_Min, FrameInfo.dVDateTime_Sec)
        Else
            DVDateTime = " "
        End If
        edtDVDateTime.Text = DVTimeCode & " " & DVDateTime

        If AxVideoGrabberNET1.CurrentState = Vidgrab_NET.TxCurrentState.cs_Recording Then
            If (FrameInfo.frameTime - LastKBWrittenReportTime) > 50000000 Then  ' every 5 seconds
                LastKBWrittenReportTime = FrameInfo.frameTime
                AddLog(mmoLog, "written to disk: " & AxVideoGrabberNET1.RecordingKBytesWrittenToDisk.ToString() & " KB")
            End If
        End If

    End Sub

    Private Sub AxVideoGrabberNET1_OnFrameCaptureCompleted(ByVal sender As Object, ByVal e As AxVidgrab_NET.IVideoGrabberNETEvents_OnFrameCaptureCompletedEvent) Handles AxVideoGrabberNET1.OnFrameCaptureCompleted
        If e.success Then
            AddLog((frmFrameGrabber.mmoFrameCaptureLog), "frame #" & e.frameNumber.ToString & " captured")
        End If

        Select Case e.destType
            '______ bmp or jpeg file
            Case Vidgrab_NET.TxFrameCaptureDest.fc_JpegFile, Vidgrab_NET.TxFrameCaptureDest.fc_BmpFile
                If e.success Then
                    AddLog((frmFrameGrabber.mmoFrameCaptureLog), e.fileName)
                Else
                    AddLog((frmFrameGrabber.mmoFrameCaptureLog), "error: failed to create " & e.fileName)
                End If

                '______ memory bitmap
            Case Vidgrab_NET.TxFrameCaptureDest.fc_TBitmap
                If Not frmSnapform.Visible Then
                    frmSnapform.Show()
                End If
                If Not frmSnapform.SnapImage.Image Is Nothing Then
                    frmSnapform.SnapImage.Image.Dispose()
                End If
                frmSnapform.SnapImage.Image = Image.FromHbitmap(New IntPtr(e.frameBitmapHandle))
        End Select
    End Sub

    Private Sub AxVideoGrabberNET1_OnCopyPreallocDataCompleted(ByVal sender As Object, ByVal e As AxVidgrab_NET.IVideoGrabberNETEvents_OnCopyPreallocDataCompletedEvent) Handles AxVideoGrabberNET1.OnCopyPreallocDataCompleted
        If e.success Then
            AddLog(mmoLog, " successfully copied to " & e.destFile & ".")
        Else
            AddLog(mmoLog, "ERROR: Failed to copy " & e.sourceFile & " to " & e.destFile & "!")
        End If
    End Sub

    Private Sub AxVideoGrabberNET1_OnCopyPreallocDataProgress(ByVal sender As Object, ByVal e As AxVidgrab_NET.IVideoGrabberNETEvents_OnCopyPreallocDataProgressEvent) Handles AxVideoGrabberNET1.OnCopyPreallocDataProgress
        AddLog(mmoLog, "copying data: " & e.percent.ToString & "% completed.")
    End Sub

    Private Sub AxVideoGrabberNET1_OnCopyPreallocDataStarted(ByVal sender As Object, ByVal e As AxVidgrab_NET.IVideoGrabberNETEvents_OnCopyPreallocDataStartedEvent) Handles AxVideoGrabberNET1.OnCopyPreallocDataStarted
        AddLog(mmoLog, "copying data from " & e.sourceFile & " to " & e.destFile & "...")
    End Sub

    Private Sub AxVideoGrabberNET1_OnCreatePreallocFileCompleted(ByVal sender As Object, ByVal e As AxVidgrab_NET.IVideoGrabberNETEvents_OnCreatePreallocFileCompletedEvent) Handles AxVideoGrabberNET1.OnCreatePreallocFileCompleted
        If e.success Then
            AddLog(mmoLog, "preallocated file " & e.fileName & " successfully created.")
        Else
            AddLog(mmoLog, "ERROR: Failed to preallocate " & e.fileName)
        End If
    End Sub

    Private Sub AxVideoGrabberNET1_OnCreatePreallocFileProgress(ByVal sender As Object, ByVal e As AxVidgrab_NET.IVideoGrabberNETEvents_OnCreatePreallocFileProgressEvent) Handles AxVideoGrabberNET1.OnCreatePreallocFileProgress
        AddLog(mmoLog, e.percent.ToString & "% of preallocated file completed")
    End Sub

    Private Sub AxVideoGrabberNET1_OnCreatePreallocFileStarted(ByVal sender As Object, ByVal e As AxVidgrab_NET.IVideoGrabberNETEvents_OnCreatePreallocFileStartedEvent) Handles AxVideoGrabberNET1.OnCreatePreallocFileStarted
        AddLog(mmoLog, "preallocating file " & e.fileName & "...")
    End Sub

    Private Sub AxVideoGrabberNET1_OnDeviceArrivalOrRemoval(ByVal sender As Object, ByVal e As AxVidgrab_NET.IVideoGrabberNETEvents_OnDeviceArrivalOrRemovalEvent) Handles AxVideoGrabberNET1.OnDeviceArrivalOrRemoval
        Dim AudioOrVideoDevice As String

        If e.isVideoDevice Then
            AudioOrVideoDevice = "video device "
        Else
            AudioOrVideoDevice = "audio device "
        End If
        If e.isDeviceArrival Then
            AddLog(mmoLog, AudioOrVideoDevice & " arrival:")
        Else
            AddLog(mmoLog, AudioOrVideoDevice & " removal:")
        End If
        AddLog(mmoLog, e.deviceName)
        If e.isVideoDevice Then
            AssignListToComboBox(frmVideoSource.cboVideoDevices, AxVideoGrabberNET1.VideoDevices, AxVideoGrabberNET1.VideoDevice)
        Else
            AssignListToComboBox(frmAudio.cboAudioDevices, AxVideoGrabberNET1.AudioDevices, AxVideoGrabberNET1.AudioDevice)
        End If
    End Sub

    Private Sub AxVideoGrabberNET1_OnDeviceLost(ByVal sender As Object, ByVal e As System.EventArgs) Handles AxVideoGrabberNET1.OnDeviceLost
        AddLog(mmoLog, "DEVICE LOST!")
        AssignListToComboBox(frmVideoSource.cboVideoDevices, AxVideoGrabberNET1.VideoDevices, AxVideoGrabberNET1.VideoDevice)
        AssignListToComboBox(frmAudio.cboAudioDevices, AxVideoGrabberNET1.AudioDevices, AxVideoGrabberNET1.AudioDevice)
    End Sub

    Private Sub AxVideoGrabberNET1_OnDirectNetworkStreamingHostUrl(ByVal sender As Object, ByVal e As AxVidgrab_NET.IVideoGrabberNETEvents_OnDirectNetworkStreamingHostUrlEvent) Handles AxVideoGrabberNET1.OnDirectNetworkStreamingHostUrl
        AddLog(mmoLog, "streaming URL: " & e.hostUrl)
        AddLog(mmoLog, "streaming host: " & e.hostName)
        AddLog(mmoLog, "streaming port: " & e.hostPort.ToString)
    End Sub

    Private Sub AxVideoGrabberNET1_OnDiskFull(ByVal sender As Object, ByVal e As System.EventArgs) Handles AxVideoGrabberNET1.OnDiskFull
        AddLog(mmoLog, "DISK FULL!")
    End Sub

    Private Sub AxVideoGrabberNET1_OnDVCommandCompleted(ByVal sender As Object, ByVal e As AxVidgrab_NET.IVideoGrabberNETEvents_OnDVCommandCompletedEvent) Handles AxVideoGrabberNET1.OnDVCommandCompleted
        AddLog(mmoLog, "camcorder state: " & e.newStateLabel)
    End Sub

    Private Sub AxVideoGrabberNET1_OnDVDiscontinuity(ByVal sender As Object, ByVal e As AxVidgrab_NET.IVideoGrabberNETEvents_OnDVDiscontinuityEvent) Handles AxVideoGrabberNET1.OnDVDiscontinuity
        ' SAMPLE CODE 1: creates a new file during recording when a discontinuity in the DV date/time is detected (uncommend the 2 lines below)
        ' e.deliverNewFrame = False
        ' AxVideoGrabberNET1.RecordToNewFileNow

        ' SAMPLE CODE 2: stops the recording when a discontinuity in the DV date/time is detected (uncommend the 2 lines below)
        ' e.deliverNewFrame = False
        ' AxVideoGrabberNET1.StopRecording

        ' Important: from this event you should not perform any actions with the potential to block, such as
        ' holding a critical section or waiting on another thread. Also, do not call any GDI or USER32.DLL APIs.
    End Sub

    Private Sub AxVideoGrabberNET1_OnLog(ByVal sender As Object, ByVal e As AxVidgrab_NET.IVideoGrabberNETEvents_OnLogEvent) Handles AxVideoGrabberNET1.OnLog
        AddLog(mmoLog, "[" & e.severity & "] " & e.infoMsg)
    End Sub

    Private Sub AxVideoGrabberNET1_OnMotionDetected(ByVal sender As Object, ByVal e As AxVidgrab_NET.IVideoGrabberNETEvents_OnMotionDetectedEvent) Handles AxVideoGrabberNET1.OnMotionDetected
        Dim MaxMotionXLocation As Integer
        Dim MaxMotionYLocation As Integer

        frmMotionDetection.edtMotionRatio.Text = AxVideoGrabberNET1.MotionDetector_GlobalMotionRatio.ToString("0.000")

        MotionDetected = True

        frmMotionDetection.edtMaxMotionXY.Text = "x:" & e.maxMotionCellX.ToString & " y:" & e.maxMotionCellY.ToString

        If AxVideoGrabberNET1.MotionDetector_GetCellLocation(e.maxMotionCellX, e.maxMotionCellY, MaxMotionXLocation, MaxMotionYLocation) Then ' the 2 last parameters are passed by ref
            frmMotionDetection.edtMaxMotionCoord.Text = "x: " & MaxMotionXLocation.ToString & "  y: " & MaxMotionYLocation.ToString
        End If

        frmMotionDetection.mmoMotionGrid.Text = AxVideoGrabberNET1.MotionDetector_Get2DTextMotion

        Dim FrameBitmap As IntPtr = New IntPtr(AxVideoGrabberNET1.GetLastFrameAsHBITMAP(0, False, 0, 0, 0, 0, frmMotionDetection.imgMotionDetected.Width, frmMotionDetection.imgMotionDetected.Height, 32))
        If Not FrameBitmap.Equals(IntPtr.Zero) Then
            frmMotionDetection.imgMotionDetected.Image = Image.FromHbitmap(FrameBitmap)
            DeleteObject(FrameBitmap)
        End If

    End Sub

    Private Sub AxVideoGrabberNET1_OnMotionNotDetected(ByVal sender As Object, ByVal e As AxVidgrab_NET.IVideoGrabberNETEvents_OnMotionNotDetectedEvent) Handles AxVideoGrabberNET1.OnMotionNotDetected
        frmMotionDetection.edtMotionRatio.Text = ""

        MotionDetected = False

        frmMotionDetection.mmoMotionGrid.Text = AxVideoGrabberNET1.MotionDetector_Get2DTextMotion
    End Sub


    Public Property MotionDetected() As Boolean
        Get
            Return boolMotionRatio
        End Get
        Set(ByVal value As Boolean)
            boolMotionRatio = value
            If boolMotionRatio Then
                brushMotionRatio = Brushes.SpringGreen
            Else
                brushMotionRatio = Brushes.DarkGreen
            End If
            frmMotionDetection.grbMotionRatio.Refresh()
        End Set
    End Property


    Private Sub AxVideoGrabberNET1_OnMouseDown(ByVal sender As Object, ByVal e As AxVidgrab_NET.IVideoGrabberNETEvents_OnMouseDownEvent) Handles AxVideoGrabberNET1.OnMouseDown
        If e.videoWindow <> -1 Then ' if the video is displayed
            If frmOverlays.chkFreeHandEnabled.Checked Then
                If cFreeHandDrawing.iArrayCoordinates < cFreeHandDrawing.MAXCOORDINATESARRAY Then
                    cFreeHandDrawing.ArrayCoordinates(cFreeHandDrawing.iArrayCoordinates).X = e.x
                    cFreeHandDrawing.ArrayCoordinates(cFreeHandDrawing.iArrayCoordinates).Y = e.y
                    cFreeHandDrawing.ArrayCoordinates(cFreeHandDrawing.iArrayCoordinates).Width = 0 ' Width is used as boolean to know if it is a MoveTo or a LineTo
                    cFreeHandDrawing.iArrayCoordinates = cFreeHandDrawing.iArrayCoordinates + 1
                    cFreeHandDrawing.DrawingEnabled = True
                    AxVideoGrabberNET1.RefreshPlayerOverlays()
                End If
            End If
        End If
    End Sub

    Private Sub AxVideoGrabberNET1_OnMouseMove(ByVal sender As Object, ByVal e As AxVidgrab_NET.IVideoGrabberNETEvents_OnMouseMoveEvent) Handles AxVideoGrabberNET1.OnMouseMove
        If e.videoWindow <> -1 Then ' if the video is displayed
            If cFreeHandDrawing.DrawingEnabled Then
                If cFreeHandDrawing.iArrayCoordinates < cFreeHandDrawing.MAXCOORDINATESARRAY Then
                    cFreeHandDrawing.ArrayCoordinates(cFreeHandDrawing.iArrayCoordinates).X = e.x
                    cFreeHandDrawing.ArrayCoordinates(cFreeHandDrawing.iArrayCoordinates).Y = e.y
                    cFreeHandDrawing.ArrayCoordinates(cFreeHandDrawing.iArrayCoordinates).Width = 1 ' Width is used as boolean to know if it is a MoveTo or a LineTo
                    cFreeHandDrawing.iArrayCoordinates = cFreeHandDrawing.iArrayCoordinates + 1
                    AxVideoGrabberNET1.RefreshPlayerOverlays()
                End If
            End If
        End If
    End Sub

    Private Sub AxVideoGrabberNET1_OnMouseUp(ByVal sender As Object, ByVal e As AxVidgrab_NET.IVideoGrabberNETEvents_OnMouseUpEvent) Handles AxVideoGrabberNET1.OnMouseUp
        cFreeHandDrawing.DrawingEnabled = False

        ' used in the image overlay sample, to pickup a transparent color on the video frame at the last mouse click location
        cPickupColor.LastRGBPixelValueAtMousePosition = 0
        cPickupColor.MouseXVideoPosition = e.x
        cPickupColor.MouseYVideoPosition = e.y
        cPickupColor.MustGetRGBPixel = True
        AxVideoGrabberNET1.RefreshPlayerOverlays()
    End Sub

    Private Sub AxVideoGrabberNET1_OnPlayerOpened(ByVal sender As Object, ByVal e As System.EventArgs) Handles AxVideoGrabberNET1.OnPlayerOpened
        tbrPlayer.Minimum = 1
        tbrPlayer.TickFrequency = 1
        tbrPlayer.Maximum = CType(AxVideoGrabberNET1.PlayerFrameCount, Integer)

        AddLog(mmoLog, "")
        AddLog(mmoLog, "playing " + AxVideoGrabberNET1.PlayerFileName)

        If (AxVideoGrabberNET1.IsPlayerVideoStreamAvailable = Vidgrab_NET.TxTriState.ts_True) Then
            AddLog(mmoLog, "this clip has a video stream")
        ElseIf (AxVideoGrabberNET1.IsPlayerVideoStreamAvailable = Vidgrab_NET.TxTriState.ts_False) Then
            AddLog(mmoLog, "this clip does not have video")
        End If
        If (AxVideoGrabberNET1.IsPlayerAudioStreamAvailable = Vidgrab_NET.TxTriState.ts_True) Then
            AddLog(mmoLog, "this clip has a Audio stream")
        ElseIf (AxVideoGrabberNET1.IsPlayerAudioStreamAvailable = Vidgrab_NET.TxTriState.ts_False) Then
            AddLog(mmoLog, "this clip does not have Audio")
        End If

        AddLog(mmoLog, "")
        AddLog(mmoLog, "video codec: " + AxVideoGrabberNET1.PlayerVideoCodec)
        AddLog(mmoLog, "audio codec: " + AxVideoGrabberNET1.PlayerAudioCodec)
        AddLog(mmoLog, "")
        Dim PlayerDuration As Double = AxVideoGrabberNET1.PlayerDuration / 10000000
        AddLog(mmoLog, "Duration: " + PlayerDuration.ToString("0.00"))
        AddLog(mmoLog, "Frame count: " + AxVideoGrabberNET1.PlayerFrameCount.ToString())
        AddLog(mmoLog, "Frame rate: " + AxVideoGrabberNET1.PlayerFrameRate.ToString("0.00"))
        AddLog(mmoLog, "size:" + AxVideoGrabberNET1.VideoWidth.ToString() + "x" + AxVideoGrabberNET1.VideoHeight.ToString())

        If (AxVideoGrabberNET1.IsPlaylistActive()) Then
            frmPlayer.lstPlaylist.SelectedIndex = AxVideoGrabberNET1.PlaylistIndex
        End If

    End Sub

    Private Sub AxVideoGrabberNET1_OnPlayerEndOfStream(ByVal sender As Object, ByVal e As System.EventArgs) Handles AxVideoGrabberNET1.OnPlayerEndOfStream
        AddLog(mmoLog, "end of stream.")
        If frmPlayer.chkLoop.Checked Then
            AxVideoGrabberNET1.RunPlayer()
        End If
    End Sub

    Private Sub AxVideoGrabberNET1_OnPlayerUpdateTrackbarPosition(ByVal sender As Object, ByVal e As AxVidgrab_NET.IVideoGrabberNETEvents_OnPlayerUpdateTrackbarPositionEvent) Handles AxVideoGrabberNET1.OnPlayerUpdateTrackbarPosition
        tbrPlayer.Value = CType(AxVideoGrabberNET1.PlayerFramePosition, Integer)
    End Sub

    Private Sub btnFastFwd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFastFwd.Click
        AxVideoGrabberNET1.FastForwardPlayer()
    End Sub

    Private Sub btnFastRew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFastRew.Click
        AxVideoGrabberNET1.RewindPlayer()
    End Sub

    Private Sub btnPause_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPause.Click
        AxVideoGrabberNET1.PausePlayer()
    End Sub

    Private Sub btnPlay_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPlay.Click
        AxVideoGrabberNET1.RunPlayer()
    End Sub

    Private Sub btnFrameStep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFrameStep.Click
        AxVideoGrabberNET1.PlayerFrameStep(1)
    End Sub

    Private Sub btnPlayBackwards_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPlayBackwards.Click
        AxVideoGrabberNET1.RunPlayerBackwards()
    End Sub

    Private Sub btnStop_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnStop.Click
        AxVideoGrabberNET1.StopPlayer()
    End Sub

    Private Sub AxVideoGrabberNET1_OnPreviewStarted(ByVal sender As Object, ByVal e As System.EventArgs) Handles AxVideoGrabberNET1.OnPreviewStarted
        AddLog(mmoLog, "")
        AddLog(mmoLog, "video size: " & AxVideoGrabberNET1.VideoWidth.ToString & " x" & AxVideoGrabberNET1.VideoHeight.ToString)
        AddLog(mmoLog, "display size: " & AxVideoGrabberNET1.Display_VideoWidth.ToString & " x" & AxVideoGrabberNET1.Display_VideoHeight.ToString)
        AddLog(mmoLog, "current frame rate: " & AxVideoGrabberNET1.CurrentFrameRate.ToString("0.00") & " fps.")
        AddLog(mmoLog, "")
    End Sub

    Private Sub AxVideoGrabberNET1_OnRecordingPaused(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxVideoGrabberNET1.OnRecordingPaused
        AddLog(mmoLog, "recording paused...")
    End Sub

    Private Sub AxVideoGrabberNET1_OnRecordingCompleted(ByVal sender As Object, ByVal e As AxVidgrab_NET.IVideoGrabberNETEvents_OnRecordingCompletedEvent) Handles AxVideoGrabberNET1.OnRecordingCompleted
        If e.success Then
            AddLog(mmoLog, " successfully created.")
            AddLog(mmoLog, "size: " & AxVideoGrabberNET1.RecordingKBytesWrittenToDisk.ToString() & " KB")
        Else
            AddLog(mmoLog, "recording failed.")
        End If
        frmRecording.btnRenewRecordingFile.Enabled = False
    End Sub

    Private Sub AxVideoGrabberNET1_OnRecordingReadyToStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles AxVideoGrabberNET1.OnRecordingReadyToStart

        ' Enabling HoldRecording before calling StartRecording prevents the recording
        '  to start (when the recording graph is built) until the
        '  OnRecordingReadyToStart event is fired, where ResumeRecording must be invoked
        '  to commence recording, or StopRecording to cancel recording
        ' EXCEPTION: RecordingTimer = rt_StartRecording: recording is started
        '  after RecordingTimerInterval regardless of HoldRecording setting,
        '  and OnRecordingReadyToStart event is not fired
        If MessageBox.Show("""StartRecording"" was initiated with ""HoldRecording"" enabled," & vbCrLf & _
                 "firing the ""OnRecordingReadyToStart"" event." & vbCrLf & vbCrLf & _
                 "Ready to start recording!", _
                 "DataStead TVideoGrabber VB.NET OCX Demo", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
            If (MainForm.DefInstance.AxVideoGrabberNET1.VideoSource = Vidgrab_NET.TxVideoSource.vs_ScreenRecording) And (frmRecording.chkScreenRecordWindow.Checked = True) And (lngScreenRecordingWindow > 0) Then
                ' for screen recording of a window, this code will make it the top window before recording start;
                '  window handle was gathered by EnumerateWindows in OnEnumerateWindows
                ' (see demo procedures in VideoSource form btnScreenRecordingWindow and SetEnumerateWindows)
                InsetForms.SetWindowPos(CType(wenScreenRecordingWindow(lngScreenRecordingWindow - 1).WindowHandle, Integer), InsetForms.HWND_TOP, 0, 0, 0, 0, SWP_NOMOVE Or SWP_NOSIZE)
            End If
            AxVideoGrabberNET1.ResumeRecording()
        Else
            AxVideoGrabberNET1.StopRecording()
        End If

    End Sub

    Private Sub AxVideoGrabberNET1_OnRecordingStarted(ByVal sender As Object, ByVal e As AxVidgrab_NET.IVideoGrabberNETEvents_OnRecordingStartedEvent) Handles AxVideoGrabberNET1.OnRecordingStarted
        AddLog(mmoLog, "recording to " & e.fileName & ":")
        AddLog(mmoLog, AxVideoGrabberNET1.RecordingWidth.ToString & " x" & AxVideoGrabberNET1.RecordingHeight.ToString)
        AddLog(mmoLog, "current frame rate: " & AxVideoGrabberNET1.CurrentFrameRate.ToString("0.0") & " fps.")
        frmRecording.btnRenewRecordingFile.Enabled = True
        LastKBWrittenReportTime = 0
    End Sub

    Private Sub AxVideoGrabberNET1_OnReencodingCompleted(ByVal sender As Object, ByVal e As AxVidgrab_NET.IVideoGrabberNETEvents_OnReencodingCompletedEvent) Handles AxVideoGrabberNET1.OnReencodingCompleted
        If e.success Then
            AddLog(mmoLog, " successfully reencoded to " & e.destFile)
        Else
            AddLog(mmoLog, "Failed to reencode " & e.sourceFile & " to " & e.destFile)
        End If
    End Sub

    Private Sub AxVideoGrabberNET1_OnReencodingProgress(ByVal sender As Object, ByVal e As AxVidgrab_NET.IVideoGrabberNETEvents_OnReencodingProgressEvent) Handles AxVideoGrabberNET1.OnReencodingProgress
        AddLog(mmoLog, e.percent.ToString & "% completed...")
    End Sub

    Private Sub AxVideoGrabberNET1_OnReencodingStarted(ByVal sender As Object, ByVal e As AxVidgrab_NET.IVideoGrabberNETEvents_OnReencodingStartedEvent) Handles AxVideoGrabberNET1.OnReencodingStarted
        AddLog(mmoLog, "reencoding " & e.sourceFile & " to " & e.destFile & "...")
    End Sub

    Private Sub AxVideoGrabberNET1_OnReinitializing(ByVal sender As Object, ByVal e As System.EventArgs) Handles AxVideoGrabberNET1.OnReinitializing
        mmoLog.Text = ""
    End Sub

    Private Sub AxVideoGrabberNET1_OnResize(ByVal sender As Object, ByVal e As System.EventArgs) Handles AxVideoGrabberNET1.OnResize
        Dim NewWidth As Integer
        Dim NewHeight As Integer

        NewWidth = AxVideoGrabberNET1.Left + AxVideoGrabberNET1.VideoWidth + 30
        NewHeight = AxVideoGrabberNET1.Top + AxVideoGrabberNET1.VideoHeight + 60
        If ((NewWidth >= Width) Or (NewHeight >= Height)) Then
            If NewWidth < StartupWidth Then
                Width = StartupWidth
            Else
                Width = NewWidth
            End If
            If NewHeight < StartupHeight Then
                Height = StartupHeight
            Else
                Height = NewHeight
            End If
        Else
            If NewWidth < StartupWidth Then
                Width = StartupWidth
            End If
            If NewHeight < StartupHeight Then
                Height = StartupHeight
            End If
        End If
    End Sub

    Private Sub AxVideoGrabberNET1_OnResizeVideo(ByVal sender As Object, ByVal e As AxVidgrab_NET.IVideoGrabberNETEvents_OnResizeVideoEvent) Handles AxVideoGrabberNET1.OnResizeVideo
        If Not IsNothing(frmVideoProcessing) Then ' frmVideoProcessing may not have been yet created
            frmVideoProcessing.trkCroppingX.Maximum = AxVideoGrabberNET1.Cropping_XMax
            frmVideoProcessing.trkCroppingX.TickFrequency = (frmVideoProcessing.trkCroppingX.Maximum \ 10)
            frmVideoProcessing.trkCroppingY.Maximum = AxVideoGrabberNET1.Cropping_YMax
            frmVideoProcessing.trkCroppingY.TickFrequency = (frmVideoProcessing.trkCroppingY.Maximum \ 10)
        End If
    End Sub

    Private Sub AxVideoGrabberNET1_OnTVChannelScanCompleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles AxVideoGrabberNET1.OnTVChannelScanCompleted
        AddLog(frmTVTuner.mmoChannelLog, "autoscan completed.")
    End Sub

    Private Sub AxVideoGrabberNET1_OnTVChannelScanStarted(ByVal sender As Object, ByVal e As AxVidgrab_NET.IVideoGrabberNETEvents_OnTVChannelScanStartedEvent) Handles AxVideoGrabberNET1.OnTVChannelScanStarted
        Dim InputType As String

        InputType = " "
        Select Case AxVideoGrabberNET1.TVTunerInputType
            Case Vidgrab_NET.TxTunerInputType.TunerInputCable
                InputType = "cable input"
            Case Vidgrab_NET.TxTunerInputType.TunerInputAntenna
                InputType = "antenna input"
        End Select
        AddLog((frmTVTuner.mmoChannelLog), "scanning country code " & AxVideoGrabberNET1.TVCountryCode.ToString & " (" & InputType & ") from channel " & e.minChannel.ToString & " to " & e.maxChannel.ToString & "...")
    End Sub

    Private Sub AxVideoGrabberNET1_OnTVChannelSelected(ByVal sender As Object, ByVal e As AxVidgrab_NET.IVideoGrabberNETEvents_OnTVChannelSelectedEvent) Handles AxVideoGrabberNET1.OnTVChannelSelected
        Dim sFrequencyInfo As String

        If e.locked Then
            sFrequencyInfo = e.channel.ToString & ": " & Format(e.tunerVideoFrequency / 1000000, "0.00") & " Mhz (" & e.tunerVideoFrequency.ToString & " Hz"
            If e.overriddenVideoFrequency <> -1 Then
                sFrequencyInfo = sFrequencyInfo & ", overridden"
            End If
            sFrequencyInfo = sFrequencyInfo & ")"
            AddLog((frmTVTuner.mmoChannelLog), sFrequencyInfo)
        Else
            If e.overriddenVideoFrequency <> -1 Then
                AddLog((frmTVTuner.mmoChannelLog), e.channel.ToString & "... overridden and not locked")
            Else
                AddLog((frmTVTuner.mmoChannelLog), e.channel.ToString & "...")
            End If
        End If
        frmTVTuner.edtTVChannel.Text = e.channel.ToString
        If e.overriddenVideoFrequency <> -1 Then
            frmTVTuner.edtChannelFrequency.Text = e.overriddenVideoFrequency.ToString
        Else
            frmTVTuner.edtChannelFrequency.Text = e.tunerVideoFrequency.ToString
        End If
    End Sub

    Private Sub bxAxVideoGrabberNET1_OnVideoFromBitmapsNextFrameNeeded(ByVal sender As Object, ByVal e As AxVidgrab_NET.IVideoGrabberNETEvents_OnVideoFromBitmapsNextFrameNeededEvent) Handles AxVideoGrabberNET1.OnVideoFromBitmapsNextFrameNeeded

        ' you can pass to this event:
        ' - either the path to a BMP file or a JPEG file (this is the case in this example)
        ' - either a the HBITMAP handle of a bitmap

        ' also see help "Video clip built from a fixed set of BMP files or JPEG files"

        Dim EndOfData As Boolean

        If VideoFromImagesUsePictureBox Then ' VideoFromImagesUsePictureBox is set in VideoFromJPEGsOrBitmaps.vb

            Dim BitmapHandle As Int32 = 0
            Dim CanFreeBitmapHandle As Boolean = True

            EndOfData = False ' we loop indefinitely

            Select Case iCountPictureBox
                Case 0
                    BitmapHandle = CreateBitmapHandleFromPictureBox(frmVideoFromJPEGsOrBitmaps.PictureBox1)
                Case 1
                    BitmapHandle = CreateBitmapHandleFromPictureBox(frmVideoFromJPEGsOrBitmaps.PictureBox2)
                Case 2
                    BitmapHandle = CreateBitmapHandleFromPictureBox(frmVideoFromJPEGsOrBitmaps.PictureBox3)
                Case 3
                    BitmapHandle = CreateBitmapHandleFromPictureBox(frmVideoFromJPEGsOrBitmaps.PictureBox4)
            End Select

            AxVideoGrabberNET1.SendImageToVideoFromBitmaps("", BitmapHandle, CanFreeBitmapHandle, EndOfData)

            iCountPictureBox = iCountPictureBox + 1
            If iCountPictureBox > 3 Then
                iCountPictureBox = 0
            End If
        Else
            ' FirstSample is true the first time the event occurs (useful to know e.g. when a file search must be restarted from the beginning)
            Dim ImageFile As String
            If e.firstSample Then
                ImageFile = VideoFromImages.FirstImageFile
                If ImageFile = "" Then ' if no BMP file found, let's try JPEG files
                    EndOfData = True
                End If
            Else
                ImageFile = VideoFromImages.NextImageFile
                If ImageFile = "" Then
                    EndOfData = True
                End If
            End If
            AxVideoGrabberNET1.SendImageToVideoFromBitmaps(ImageFile, 0, False, EndOfData)
        End If
    End Sub

    Private Sub AxVideoGrabberNET1_OnClientConnection(ByVal sender As Object, ByVal e As AxVidgrab_NET.IVideoGrabberNETEvents_OnClientConnectionEvent) Handles AxVideoGrabberNET1.OnClientConnection
        If e.connected Then
            AddLog(mmoLog, "client connected: " + e.clientInfo)
        Else
            AddLog(mmoLog, "client disconnected: " + e.clientInfo)
        End If
    End Sub

    Private Sub edtStoragePath_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtStoragePath.TextChanged
        AxVideoGrabberNET1.StoragePath = edtStoragePath.Text
    End Sub

    Private Sub mnuAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAbout.Click
        AxVideoGrabberNET1.About()
    End Sub

    Private Sub mnuPriorityDefault_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPriorityDefault.Click
        AxVideoGrabberNET1.ApplicationPriority = Vidgrab_NET.TxApplicationPriority.ap_default
    End Sub
    Private Sub mnuPriorityIdle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPriorityIdle.Click
        AxVideoGrabberNET1.ApplicationPriority = Vidgrab_NET.TxApplicationPriority.ap_idle
    End Sub

    Private Sub mnuPriorityNormal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPriorityNormal.Click
        AxVideoGrabberNET1.ApplicationPriority = Vidgrab_NET.TxApplicationPriority.ap_normal
    End Sub

    Private Sub mnuPriorityHigh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPriorityHigh.Click
        AxVideoGrabberNET1.ApplicationPriority = Vidgrab_NET.TxApplicationPriority.ap_high
    End Sub

    Private Sub mnuPriorityRealTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPriorityRealTime.Click
        AxVideoGrabberNET1.ApplicationPriority = Vidgrab_NET.TxApplicationPriority.ap_realtime
    End Sub

    Public Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub

    Private Sub AxVideoGrabberNET1_OnGraphBuilt(ByVal sender As Object, ByVal e As System.EventArgs) Handles AxVideoGrabberNET1.OnGraphBuilt
        AutoSizeInfo.Visible = False

        tbrZoomX.Minimum = -(AxVideoGrabberNET1.VideoWidth \ 2)
        tbrZoomX.Maximum = AxVideoGrabberNET1.VideoWidth \ 2
        tbrZoomY.Minimum = -(AxVideoGrabberNET1.VideoHeight \ 2)
        tbrZoomY.Maximum = AxVideoGrabberNET1.VideoHeight \ 2

    End Sub

    Private Sub AxVideoGrabberNET1_OnInactive(ByVal sender As Object, ByVal e As System.EventArgs) Handles AxVideoGrabberNET1.OnInactive
        AddLog(mmoLog, "(done.)")
    End Sub

    Private Sub tbrPlayer_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbrPlayer.Scroll
        AxVideoGrabberNET1.PlayerFramePosition = tbrPlayer.Value
    End Sub

    Private Sub chkPlayerTrackbarSynchrone_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPlayerTrackBarSynchrone.CheckedChanged
        AxVideoGrabberNET1.PlayerTrackBarSynchrone = chkPlayerTrackBarSynchrone.Checked
    End Sub

    Private Sub tbrPlayer_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tbrPlayer.MouseDown
        AxVideoGrabberNET1.NotifyPlayerTrackbarAction(Vidgrab_NET.TxTrackbarAction.tba_MouseDown)
    End Sub

    Private Sub tbrPlayer_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tbrPlayer.MouseUp
        AxVideoGrabberNET1.NotifyPlayerTrackbarAction(Vidgrab_NET.TxTrackbarAction.tba_MouseUp)
    End Sub

    Private Sub tbrPlayer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbrPlayer.KeyDown
        AxVideoGrabberNET1.NotifyPlayerTrackbarAction(Vidgrab_NET.TxTrackbarAction.tba_KeyDown)
    End Sub

    Private Sub tbrPlayer_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbrPlayer.KeyUp
        AxVideoGrabberNET1.NotifyPlayerTrackbarAction(Vidgrab_NET.TxTrackbarAction.tba_KeyUp)
    End Sub

    Private Sub SendDVCommand(ByVal DvCommand As Vidgrab_NET.TxDVCommand)
        If AxVideoGrabberNET1.SendDVCommand(DvCommand) Then
            AddLog(mmoLog, "DV command sent...")
        Else
            If (AxVideoGrabberNET1.CurrentState <> Vidgrab_NET.TxCurrentState.cs_Preview) And (AxVideoGrabberNET1.CurrentState <> Vidgrab_NET.TxCurrentState.cs_Recording) Then
                AddLog(mmoLog, "DV command failed. Preview must be running!")
            Else
                AddLog(mmoLog, "DV command failed.")
            End If
        End If
    End Sub

    Private Sub mnuDVPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDVPlay.Click
        SendDVCommand(Vidgrab_NET.TxDVCommand.dv_Play)
    End Sub

    Private Sub mnuDVStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDVStop.Click
        SendDVCommand(Vidgrab_NET.TxDVCommand.dv_Stop)
    End Sub

    Private Sub mnuDVFreeze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDVFreeze.Click
        SendDVCommand(Vidgrab_NET.TxDVCommand.dv_Freeze)
    End Sub

    Private Sub mnuDVThaw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDVThaw.Click
        SendDVCommand(Vidgrab_NET.TxDVCommand.dv_Thaw)
    End Sub

    Private Sub mnuDVFF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDVFF.Click
        SendDVCommand(Vidgrab_NET.TxDVCommand.dv_Ff)
    End Sub

    Private Sub mnuDVRew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDVRew.Click
        SendDVCommand(Vidgrab_NET.TxDVCommand.dv_Rew)
    End Sub

    Private Sub mnuDVRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDVRecord.Click
        SendDVCommand(Vidgrab_NET.TxDVCommand.dv_Record)
    End Sub

    Private Sub mnuDVRecordFreeze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDVRecordFreeze.Click
        SendDVCommand(Vidgrab_NET.TxDVCommand.dv_RecordFreeze)
    End Sub

    Private Sub mnuDVRecordStrobe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDVRecordStrobe.Click
        SendDVCommand(Vidgrab_NET.TxDVCommand.dv_RecordStrobe)
    End Sub

    Private Sub mnuDVStepFwd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDVStepFwd.Click
        SendDVCommand(Vidgrab_NET.TxDVCommand.dv_StepFwd)
    End Sub

    Private Sub mnuDVStepRev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDVStepRev.Click
        SendDVCommand(Vidgrab_NET.TxDVCommand.dv_StepRev)
    End Sub

    Private Sub mnuDVModeShuttle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDVModeShuttle.Click
        SendDVCommand(Vidgrab_NET.TxDVCommand.dv_ModeShuttle)
    End Sub

    Private Sub mnuDVPlayFastestFwd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDVPlayFastestFwd.Click
        SendDVCommand(Vidgrab_NET.TxDVCommand.dv_PlayFastestFwd)
    End Sub

    Private Sub mnuDVPlaySlowestFwd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDVPlaySlowestFwd.Click
        SendDVCommand(Vidgrab_NET.TxDVCommand.dv_PlaySlowestFwd)
    End Sub

    Private Sub mnuDVPlayFastestRev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDVPlayFastestRev.Click
        SendDVCommand(Vidgrab_NET.TxDVCommand.dv_PlayFastestRev)
    End Sub

    Private Sub mnuDVPlaySlowestRev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDVPlaySlowestRev.Click
        SendDVCommand(Vidgrab_NET.TxDVCommand.dv_PlaySlowestRev)
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        AxVideoGrabberNET1.ResetVideoDeviceSettings()
    End Sub

    Private Sub tbrZoom_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbrZoom.Scroll
        AxVideoGrabberNET1.ZoomCoeff = tbrZoom.Value
    End Sub

    Private Sub tbrZoomX_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbrZoomX.Scroll
        AxVideoGrabberNET1.ZoomXCenter = tbrZoomX.Value
    End Sub

    Private Sub tbrZoomY_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbrZoomY.Scroll
        AxVideoGrabberNET1.ZoomYCenter = tbrZoomY.Value
    End Sub
End Class

'(*) From this event you should not perform any actions with the potential to block:
'    1. do not hold a critical section or wait on another thread,
'    2. do not call any GDI or USER32.DLL APIs that might cause a window to move,
'    3. do not invoke component properties that send messages, e.g. do not read the ItemIndex property
'       of a ListBox component. If you need to read a such property, set an intermediary variable when
'       the property changes, and then read the intermediary variable from this event.
