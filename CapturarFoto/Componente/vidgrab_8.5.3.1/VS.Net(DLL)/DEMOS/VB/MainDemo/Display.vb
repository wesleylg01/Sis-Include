Option Strict Off
Option Explicit On
Friend Class Display
    Inherits SubForm ' SubForm is declared in VBUtil and inherits from System.Windows.Forms.Form
    'Unlike normal Form, it is not destroyed when closed, unless MainForm is being destroyed too.
#Region "Windows Form Designer generated code "
    Public Sub New()
        MyBase.New()
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
    Public WithEvents chk2ndVideoWindowActive As System.Windows.Forms.CheckBox
    Public WithEvents btnEG2ndNewLocation2 As System.Windows.Forms.Button
    Public WithEvents btnEG2ndNewLocation As System.Windows.Forms.Button
    Public WithEvents rdg2ndDisplayedOn2 As System.Windows.Forms.RadioButton
    Public WithEvents rdg2ndDisplayedOn1 As System.Windows.Forms.RadioButton
    Public WithEvents rdg2ndDisplayedOn As System.Windows.Forms.GroupBox
    Public WithEvents chk2ndAutoSize As System.Windows.Forms.CheckBox
    Public WithEvents chk2ndStayOnTop As System.Windows.Forms.CheckBox
    Public WithEvents chk2ndMouseMovesWindow As System.Windows.Forms.CheckBox
    Public WithEvents chk2ndFullScreen As System.Windows.Forms.CheckBox
    Public WithEvents chk2ndUseVideoPort As System.Windows.Forms.CheckBox
    Public WithEvents chk2ndEmbedded As System.Windows.Forms.CheckBox
    Public WithEvents grb2ndVideoWindow As System.Windows.Forms.GroupBox
    Public WithEvents chk1stEmbedded As System.Windows.Forms.CheckBox
    Public WithEvents chk1stUseVideoPort As System.Windows.Forms.CheckBox
    Public WithEvents chk1stFullScreen As System.Windows.Forms.CheckBox
    Public WithEvents chk1stMouseMovesWindow As System.Windows.Forms.CheckBox
    Public WithEvents chk1stStayOnTop As System.Windows.Forms.CheckBox
    Public WithEvents chk1stAutoSize As System.Windows.Forms.CheckBox
    Public WithEvents rdg1stDisplayedOn1 As System.Windows.Forms.RadioButton
    Public WithEvents rdg1stDisplayedOn2 As System.Windows.Forms.RadioButton
    Public WithEvents rdg1stDisplayedOn As System.Windows.Forms.GroupBox
    Public WithEvents btnEG1stNewLocation As System.Windows.Forms.Button
    Public WithEvents btnEG1stNewLocation2 As System.Windows.Forms.Button
    Public WithEvents grbMainVideoWindow As System.Windows.Forms.GroupBox
    Public WithEvents chk1stVideoWindowActive As System.Windows.Forms.CheckBox
    Public WithEvents chkSetLogo As System.Windows.Forms.CheckBox
    Public WithEvents chkBorder As System.Windows.Forms.CheckBox
    Public WithEvents chkChangeCursor As System.Windows.Forms.CheckBox
    Public WithEvents imgLogo As System.Windows.Forms.PictureBox
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Friend WithEvents chkTransparency As System.Windows.Forms.CheckBox
    Friend WithEvents rdg1AspectRatio As System.Windows.Forms.GroupBox
    Friend WithEvents rdg2AspectRatio As System.Windows.Forms.GroupBox
    Public WithEvents rdgVideoRenderer As System.Windows.Forms.GroupBox
    Friend WithEvents chkVideoVisibleWhenStopped As System.Windows.Forms.CheckBox
    Friend WithEvents chk1stVisible As System.Windows.Forms.CheckBox
    Friend WithEvents chk2ndVisible As System.Windows.Forms.CheckBox
    Friend WithEvents rdg2DisplayAspectRatioStretch As System.Windows.Forms.RadioButton
    Friend WithEvents rdg2DisplayAspectRatioPan As System.Windows.Forms.RadioButton
    Friend WithEvents rdg2DisplayAspectRatioBox As System.Windows.Forms.RadioButton
    Friend WithEvents rdg1DisplayAspectRatioStretch As System.Windows.Forms.RadioButton
    Friend WithEvents rdg1DisplayAspectRatioPan As System.Windows.Forms.RadioButton
    Friend WithEvents rdg1DisplayAspectRatioBox As System.Windows.Forms.RadioButton
    Friend WithEvents rdgVideoRendererNone As System.Windows.Forms.RadioButton
    Public WithEvents rdgVideoRendererOverlay As System.Windows.Forms.RadioButton
    Public WithEvents rdgVideoRendererStandard As System.Windows.Forms.RadioButton
    Public WithEvents rdgVideoRendererAutoSelect As System.Windows.Forms.RadioButton
    Public WithEvents rdgVideoRendererVMR7 As System.Windows.Forms.RadioButton
    Public WithEvents rdgVideoRendererVMR9 As System.Windows.Forms.RadioButton
    Friend WithEvents rdg1DisplayAspectRatioPanScan As System.Windows.Forms.RadioButton
    Friend WithEvents rdg2DisplayAspectRatioPanScan As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbr1PanScan As System.Windows.Forms.TrackBar
    Friend WithEvents tbr2PanScan As System.Windows.Forms.TrackBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnTestPanScan As System.Windows.Forms.Button
    Friend WithEvents rdgVideoRendererRecPriority As System.Windows.Forms.RadioButton
    Friend WithEvents btnTestPanScanHelp As System.Windows.Forms.Button
    Public WithEvents rdgVideoRendererEVR As System.Windows.Forms.RadioButton
    Friend WithEvents chkBlackMagicOutput As System.Windows.Forms.CheckBox
    Public WithEvents chkAdjustPixelAspectRatio As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Display))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.chk2ndVideoWindowActive = New System.Windows.Forms.CheckBox
        Me.grb2ndVideoWindow = New System.Windows.Forms.GroupBox
        Me.rdg2ndDisplayedOn = New System.Windows.Forms.GroupBox
        Me.rdg2ndDisplayedOn2 = New System.Windows.Forms.RadioButton
        Me.rdg2ndDisplayedOn1 = New System.Windows.Forms.RadioButton
        Me.tbr2PanScan = New System.Windows.Forms.TrackBar
        Me.Label2 = New System.Windows.Forms.Label
        Me.chk2ndVisible = New System.Windows.Forms.CheckBox
        Me.rdg2AspectRatio = New System.Windows.Forms.GroupBox
        Me.rdg2DisplayAspectRatioPanScan = New System.Windows.Forms.RadioButton
        Me.rdg2DisplayAspectRatioStretch = New System.Windows.Forms.RadioButton
        Me.rdg2DisplayAspectRatioPan = New System.Windows.Forms.RadioButton
        Me.rdg2DisplayAspectRatioBox = New System.Windows.Forms.RadioButton
        Me.btnEG2ndNewLocation2 = New System.Windows.Forms.Button
        Me.btnEG2ndNewLocation = New System.Windows.Forms.Button
        Me.chk2ndAutoSize = New System.Windows.Forms.CheckBox
        Me.chk2ndStayOnTop = New System.Windows.Forms.CheckBox
        Me.chk2ndMouseMovesWindow = New System.Windows.Forms.CheckBox
        Me.chk2ndFullScreen = New System.Windows.Forms.CheckBox
        Me.chk2ndUseVideoPort = New System.Windows.Forms.CheckBox
        Me.chk2ndEmbedded = New System.Windows.Forms.CheckBox
        Me.grbMainVideoWindow = New System.Windows.Forms.GroupBox
        Me.btnTestPanScanHelp = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.rdg1stDisplayedOn = New System.Windows.Forms.GroupBox
        Me.rdg1stDisplayedOn2 = New System.Windows.Forms.RadioButton
        Me.rdg1stDisplayedOn1 = New System.Windows.Forms.RadioButton
        Me.chk1stFullScreen = New System.Windows.Forms.CheckBox
        Me.chk1stUseVideoPort = New System.Windows.Forms.CheckBox
        Me.btnTestPanScan = New System.Windows.Forms.Button
        Me.tbr1PanScan = New System.Windows.Forms.TrackBar
        Me.chk1stVisible = New System.Windows.Forms.CheckBox
        Me.rdg1AspectRatio = New System.Windows.Forms.GroupBox
        Me.rdg1DisplayAspectRatioPanScan = New System.Windows.Forms.RadioButton
        Me.rdg1DisplayAspectRatioStretch = New System.Windows.Forms.RadioButton
        Me.rdg1DisplayAspectRatioPan = New System.Windows.Forms.RadioButton
        Me.rdg1DisplayAspectRatioBox = New System.Windows.Forms.RadioButton
        Me.chk1stEmbedded = New System.Windows.Forms.CheckBox
        Me.chk1stMouseMovesWindow = New System.Windows.Forms.CheckBox
        Me.chk1stStayOnTop = New System.Windows.Forms.CheckBox
        Me.chk1stAutoSize = New System.Windows.Forms.CheckBox
        Me.btnEG1stNewLocation = New System.Windows.Forms.Button
        Me.btnEG1stNewLocation2 = New System.Windows.Forms.Button
        Me.chk1stVideoWindowActive = New System.Windows.Forms.CheckBox
        Me.chkSetLogo = New System.Windows.Forms.CheckBox
        Me.chkBorder = New System.Windows.Forms.CheckBox
        Me.chkChangeCursor = New System.Windows.Forms.CheckBox
        Me.imgLogo = New System.Windows.Forms.PictureBox
        Me.chkTransparency = New System.Windows.Forms.CheckBox
        Me.rdgVideoRenderer = New System.Windows.Forms.GroupBox
        Me.rdgVideoRendererEVR = New System.Windows.Forms.RadioButton
        Me.rdgVideoRendererNone = New System.Windows.Forms.RadioButton
        Me.rdgVideoRendererOverlay = New System.Windows.Forms.RadioButton
        Me.rdgVideoRendererStandard = New System.Windows.Forms.RadioButton
        Me.rdgVideoRendererAutoSelect = New System.Windows.Forms.RadioButton
        Me.rdgVideoRendererVMR7 = New System.Windows.Forms.RadioButton
        Me.rdgVideoRendererVMR9 = New System.Windows.Forms.RadioButton
        Me.rdgVideoRendererRecPriority = New System.Windows.Forms.RadioButton
        Me.chkVideoVisibleWhenStopped = New System.Windows.Forms.CheckBox
        Me.chkAdjustPixelAspectRatio = New System.Windows.Forms.CheckBox
        Me.chkBlackMagicOutput = New System.Windows.Forms.CheckBox
        Me.grb2ndVideoWindow.SuspendLayout()
        Me.rdg2ndDisplayedOn.SuspendLayout()
        CType(Me.tbr2PanScan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.rdg2AspectRatio.SuspendLayout()
        Me.grbMainVideoWindow.SuspendLayout()
        Me.rdg1stDisplayedOn.SuspendLayout()
        CType(Me.tbr1PanScan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.rdg1AspectRatio.SuspendLayout()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.rdgVideoRenderer.SuspendLayout()
        Me.SuspendLayout()
        '
        'chk2ndVideoWindowActive
        '
        Me.chk2ndVideoWindowActive.BackColor = System.Drawing.SystemColors.Control
        Me.chk2ndVideoWindowActive.Cursor = System.Windows.Forms.Cursors.Default
        Me.chk2ndVideoWindowActive.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk2ndVideoWindowActive.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chk2ndVideoWindowActive.Location = New System.Drawing.Point(660, 0)
        Me.chk2ndVideoWindowActive.Name = "chk2ndVideoWindowActive"
        Me.chk2ndVideoWindowActive.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chk2ndVideoWindowActive.Size = New System.Drawing.Size(185, 17)
        Me.chk2ndVideoWindowActive.TabIndex = 36
        Me.chk2ndVideoWindowActive.Text = "2ND VIDEO WINDOW ACTIVE"
        Me.chk2ndVideoWindowActive.UseVisualStyleBackColor = False
        '
        'grb2ndVideoWindow
        '
        Me.grb2ndVideoWindow.BackColor = System.Drawing.SystemColors.Control
        Me.grb2ndVideoWindow.Controls.Add(Me.rdg2ndDisplayedOn)
        Me.grb2ndVideoWindow.Controls.Add(Me.tbr2PanScan)
        Me.grb2ndVideoWindow.Controls.Add(Me.Label2)
        Me.grb2ndVideoWindow.Controls.Add(Me.chk2ndVisible)
        Me.grb2ndVideoWindow.Controls.Add(Me.rdg2AspectRatio)
        Me.grb2ndVideoWindow.Controls.Add(Me.btnEG2ndNewLocation2)
        Me.grb2ndVideoWindow.Controls.Add(Me.btnEG2ndNewLocation)
        Me.grb2ndVideoWindow.Controls.Add(Me.chk2ndAutoSize)
        Me.grb2ndVideoWindow.Controls.Add(Me.chk2ndStayOnTop)
        Me.grb2ndVideoWindow.Controls.Add(Me.chk2ndMouseMovesWindow)
        Me.grb2ndVideoWindow.Controls.Add(Me.chk2ndFullScreen)
        Me.grb2ndVideoWindow.Controls.Add(Me.chk2ndUseVideoPort)
        Me.grb2ndVideoWindow.Controls.Add(Me.chk2ndEmbedded)
        Me.grb2ndVideoWindow.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb2ndVideoWindow.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grb2ndVideoWindow.Location = New System.Drawing.Point(604, 16)
        Me.grb2ndVideoWindow.Name = "grb2ndVideoWindow"
        Me.grb2ndVideoWindow.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grb2ndVideoWindow.Size = New System.Drawing.Size(313, 163)
        Me.grb2ndVideoWindow.TabIndex = 23
        Me.grb2ndVideoWindow.TabStop = False
        Me.grb2ndVideoWindow.Text = "main video window"
        '
        'rdg2ndDisplayedOn
        '
        Me.rdg2ndDisplayedOn.BackColor = System.Drawing.SystemColors.Control
        Me.rdg2ndDisplayedOn.Controls.Add(Me.rdg2ndDisplayedOn2)
        Me.rdg2ndDisplayedOn.Controls.Add(Me.rdg2ndDisplayedOn1)
        Me.rdg2ndDisplayedOn.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdg2ndDisplayedOn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdg2ndDisplayedOn.Location = New System.Drawing.Point(220, 9)
        Me.rdg2ndDisplayedOn.Name = "rdg2ndDisplayedOn"
        Me.rdg2ndDisplayedOn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdg2ndDisplayedOn.Size = New System.Drawing.Size(87, 52)
        Me.rdg2ndDisplayedOn.TabIndex = 31
        Me.rdg2ndDisplayedOn.TabStop = False
        Me.rdg2ndDisplayedOn.Text = "display on..."
        '
        'rdg2ndDisplayedOn2
        '
        Me.rdg2ndDisplayedOn2.BackColor = System.Drawing.SystemColors.Control
        Me.rdg2ndDisplayedOn2.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdg2ndDisplayedOn2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdg2ndDisplayedOn2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdg2ndDisplayedOn2.Location = New System.Drawing.Point(6, 31)
        Me.rdg2ndDisplayedOn2.Name = "rdg2ndDisplayedOn2"
        Me.rdg2ndDisplayedOn2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdg2ndDisplayedOn2.Size = New System.Drawing.Size(79, 17)
        Me.rdg2ndDisplayedOn2.TabIndex = 33
        Me.rdg2ndDisplayedOn2.TabStop = True
        Me.rdg2ndDisplayedOn2.Tag = "1"
        Me.rdg2ndDisplayedOn2.Text = "2nd monitor"
        Me.rdg2ndDisplayedOn2.UseVisualStyleBackColor = False
        '
        'rdg2ndDisplayedOn1
        '
        Me.rdg2ndDisplayedOn1.BackColor = System.Drawing.SystemColors.Control
        Me.rdg2ndDisplayedOn1.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdg2ndDisplayedOn1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdg2ndDisplayedOn1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdg2ndDisplayedOn1.Location = New System.Drawing.Point(6, 16)
        Me.rdg2ndDisplayedOn1.Name = "rdg2ndDisplayedOn1"
        Me.rdg2ndDisplayedOn1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdg2ndDisplayedOn1.Size = New System.Drawing.Size(79, 17)
        Me.rdg2ndDisplayedOn1.TabIndex = 32
        Me.rdg2ndDisplayedOn1.TabStop = True
        Me.rdg2ndDisplayedOn1.Tag = "0"
        Me.rdg2ndDisplayedOn1.Text = "1st monitor"
        Me.rdg2ndDisplayedOn1.UseVisualStyleBackColor = False
        '
        'tbr2PanScan
        '
        Me.tbr2PanScan.AutoSize = False
        Me.tbr2PanScan.Location = New System.Drawing.Point(165, 137)
        Me.tbr2PanScan.Maximum = 100
        Me.tbr2PanScan.Name = "tbr2PanScan"
        Me.tbr2PanScan.Size = New System.Drawing.Size(142, 20)
        Me.tbr2PanScan.TabIndex = 39
        Me.tbr2PanScan.TickFrequency = 10
        Me.tbr2PanScan.Value = 50
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(167, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 14)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "pan-scan ratio: (0..100)"
        '
        'chk2ndVisible
        '
        Me.chk2ndVisible.Location = New System.Drawing.Point(8, 14)
        Me.chk2ndVisible.Name = "chk2ndVisible"
        Me.chk2ndVisible.Size = New System.Drawing.Size(56, 17)
        Me.chk2ndVisible.TabIndex = 37
        Me.chk2ndVisible.Text = "visible"
        '
        'rdg2AspectRatio
        '
        Me.rdg2AspectRatio.Controls.Add(Me.rdg2DisplayAspectRatioPanScan)
        Me.rdg2AspectRatio.Controls.Add(Me.rdg2DisplayAspectRatioStretch)
        Me.rdg2AspectRatio.Controls.Add(Me.rdg2DisplayAspectRatioPan)
        Me.rdg2AspectRatio.Controls.Add(Me.rdg2DisplayAspectRatioBox)
        Me.rdg2AspectRatio.Location = New System.Drawing.Point(8, 80)
        Me.rdg2AspectRatio.Name = "rdg2AspectRatio"
        Me.rdg2AspectRatio.Size = New System.Drawing.Size(153, 83)
        Me.rdg2AspectRatio.TabIndex = 36
        Me.rdg2AspectRatio.TabStop = False
        Me.rdg2AspectRatio.Text = "aspect ratio"
        '
        'rdg2DisplayAspectRatioPanScan
        '
        Me.rdg2DisplayAspectRatioPanScan.Location = New System.Drawing.Point(8, 62)
        Me.rdg2DisplayAspectRatioPanScan.Name = "rdg2DisplayAspectRatioPanScan"
        Me.rdg2DisplayAspectRatioPanScan.Size = New System.Drawing.Size(116, 16)
        Me.rdg2DisplayAspectRatioPanScan.TabIndex = 4
        Me.rdg2DisplayAspectRatioPanScan.Tag = "3"
        Me.rdg2DisplayAspectRatioPanScan.Text = "pan-scan"
        '
        'rdg2DisplayAspectRatioStretch
        '
        Me.rdg2DisplayAspectRatioStretch.Location = New System.Drawing.Point(8, 46)
        Me.rdg2DisplayAspectRatioStretch.Name = "rdg2DisplayAspectRatioStretch"
        Me.rdg2DisplayAspectRatioStretch.Size = New System.Drawing.Size(116, 18)
        Me.rdg2DisplayAspectRatioStretch.TabIndex = 2
        Me.rdg2DisplayAspectRatioStretch.Tag = "2"
        Me.rdg2DisplayAspectRatioStretch.Text = "stretch"
        '
        'rdg2DisplayAspectRatioPan
        '
        Me.rdg2DisplayAspectRatioPan.Location = New System.Drawing.Point(8, 30)
        Me.rdg2DisplayAspectRatioPan.Name = "rdg2DisplayAspectRatioPan"
        Me.rdg2DisplayAspectRatioPan.Size = New System.Drawing.Size(116, 16)
        Me.rdg2DisplayAspectRatioPan.TabIndex = 1
        Me.rdg2DisplayAspectRatioPan.Tag = "1"
        Me.rdg2DisplayAspectRatioPan.Text = "no resize"
        '
        'rdg2DisplayAspectRatioBox
        '
        Me.rdg2DisplayAspectRatioBox.Location = New System.Drawing.Point(8, 14)
        Me.rdg2DisplayAspectRatioBox.Name = "rdg2DisplayAspectRatioBox"
        Me.rdg2DisplayAspectRatioBox.Size = New System.Drawing.Size(143, 16)
        Me.rdg2DisplayAspectRatioBox.TabIndex = 0
        Me.rdg2DisplayAspectRatioBox.Tag = "0"
        Me.rdg2DisplayAspectRatioBox.Text = "box (letterbox, pillarbox)"
        '
        'btnEG2ndNewLocation2
        '
        Me.btnEG2ndNewLocation2.BackColor = System.Drawing.SystemColors.Control
        Me.btnEG2ndNewLocation2.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnEG2ndNewLocation2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEG2ndNewLocation2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEG2ndNewLocation2.Location = New System.Drawing.Point(165, 91)
        Me.btnEG2ndNewLocation2.Name = "btnEG2ndNewLocation2"
        Me.btnEG2ndNewLocation2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnEG2ndNewLocation2.Size = New System.Drawing.Size(140, 21)
        Me.btnEG2ndNewLocation2.TabIndex = 35
        Me.btnEG2ndNewLocation2.Text = "e.g. 520,20 (480,200)"
        Me.btnEG2ndNewLocation2.UseVisualStyleBackColor = False
        '
        'btnEG2ndNewLocation
        '
        Me.btnEG2ndNewLocation.BackColor = System.Drawing.SystemColors.Control
        Me.btnEG2ndNewLocation.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnEG2ndNewLocation.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEG2ndNewLocation.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEG2ndNewLocation.Location = New System.Drawing.Point(165, 67)
        Me.btnEG2ndNewLocation.Name = "btnEG2ndNewLocation"
        Me.btnEG2ndNewLocation.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnEG2ndNewLocation.Size = New System.Drawing.Size(140, 21)
        Me.btnEG2ndNewLocation.TabIndex = 34
        Me.btnEG2ndNewLocation.Text = "e.g. 510,10 (autosize)"
        Me.btnEG2ndNewLocation.UseVisualStyleBackColor = False
        '
        'chk2ndAutoSize
        '
        Me.chk2ndAutoSize.BackColor = System.Drawing.SystemColors.Control
        Me.chk2ndAutoSize.Cursor = System.Windows.Forms.Cursors.Default
        Me.chk2ndAutoSize.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk2ndAutoSize.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chk2ndAutoSize.Location = New System.Drawing.Point(8, 46)
        Me.chk2ndAutoSize.Name = "chk2ndAutoSize"
        Me.chk2ndAutoSize.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chk2ndAutoSize.Size = New System.Drawing.Size(74, 17)
        Me.chk2ndAutoSize.TabIndex = 30
        Me.chk2ndAutoSize.Text = "autosize"
        Me.chk2ndAutoSize.UseVisualStyleBackColor = False
        '
        'chk2ndStayOnTop
        '
        Me.chk2ndStayOnTop.BackColor = System.Drawing.SystemColors.Control
        Me.chk2ndStayOnTop.Cursor = System.Windows.Forms.Cursors.Default
        Me.chk2ndStayOnTop.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk2ndStayOnTop.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chk2ndStayOnTop.Location = New System.Drawing.Point(8, 62)
        Me.chk2ndStayOnTop.Name = "chk2ndStayOnTop"
        Me.chk2ndStayOnTop.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chk2ndStayOnTop.Size = New System.Drawing.Size(88, 17)
        Me.chk2ndStayOnTop.TabIndex = 29
        Me.chk2ndStayOnTop.Text = "stay on top"
        Me.chk2ndStayOnTop.UseVisualStyleBackColor = False
        '
        'chk2ndMouseMovesWindow
        '
        Me.chk2ndMouseMovesWindow.BackColor = System.Drawing.SystemColors.Control
        Me.chk2ndMouseMovesWindow.Cursor = System.Windows.Forms.Cursors.Default
        Me.chk2ndMouseMovesWindow.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk2ndMouseMovesWindow.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chk2ndMouseMovesWindow.Location = New System.Drawing.Point(85, 46)
        Me.chk2ndMouseMovesWindow.Name = "chk2ndMouseMovesWindow"
        Me.chk2ndMouseMovesWindow.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chk2ndMouseMovesWindow.Size = New System.Drawing.Size(137, 17)
        Me.chk2ndMouseMovesWindow.TabIndex = 28
        Me.chk2ndMouseMovesWindow.Text = "mouse moves window"
        Me.chk2ndMouseMovesWindow.UseVisualStyleBackColor = False
        '
        'chk2ndFullScreen
        '
        Me.chk2ndFullScreen.BackColor = System.Drawing.SystemColors.Control
        Me.chk2ndFullScreen.Cursor = System.Windows.Forms.Cursors.Default
        Me.chk2ndFullScreen.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk2ndFullScreen.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chk2ndFullScreen.Location = New System.Drawing.Point(85, 14)
        Me.chk2ndFullScreen.Name = "chk2ndFullScreen"
        Me.chk2ndFullScreen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chk2ndFullScreen.Size = New System.Drawing.Size(89, 17)
        Me.chk2ndFullScreen.TabIndex = 27
        Me.chk2ndFullScreen.Text = "full screen"
        Me.chk2ndFullScreen.UseVisualStyleBackColor = False
        '
        'chk2ndUseVideoPort
        '
        Me.chk2ndUseVideoPort.BackColor = System.Drawing.SystemColors.Control
        Me.chk2ndUseVideoPort.Cursor = System.Windows.Forms.Cursors.Default
        Me.chk2ndUseVideoPort.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk2ndUseVideoPort.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chk2ndUseVideoPort.Location = New System.Drawing.Point(85, 30)
        Me.chk2ndUseVideoPort.Name = "chk2ndUseVideoPort"
        Me.chk2ndUseVideoPort.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chk2ndUseVideoPort.Size = New System.Drawing.Size(120, 17)
        Me.chk2ndUseVideoPort.TabIndex = 25
        Me.chk2ndUseVideoPort.Text = "use video port"
        Me.chk2ndUseVideoPort.UseVisualStyleBackColor = False
        '
        'chk2ndEmbedded
        '
        Me.chk2ndEmbedded.BackColor = System.Drawing.SystemColors.Control
        Me.chk2ndEmbedded.Cursor = System.Windows.Forms.Cursors.Default
        Me.chk2ndEmbedded.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk2ndEmbedded.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chk2ndEmbedded.Location = New System.Drawing.Point(8, 30)
        Me.chk2ndEmbedded.Name = "chk2ndEmbedded"
        Me.chk2ndEmbedded.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chk2ndEmbedded.Size = New System.Drawing.Size(89, 17)
        Me.chk2ndEmbedded.TabIndex = 24
        Me.chk2ndEmbedded.Text = "embedded"
        Me.chk2ndEmbedded.UseVisualStyleBackColor = False
        '
        'grbMainVideoWindow
        '
        Me.grbMainVideoWindow.BackColor = System.Drawing.SystemColors.Control
        Me.grbMainVideoWindow.Controls.Add(Me.btnTestPanScanHelp)
        Me.grbMainVideoWindow.Controls.Add(Me.Label1)
        Me.grbMainVideoWindow.Controls.Add(Me.rdg1stDisplayedOn)
        Me.grbMainVideoWindow.Controls.Add(Me.chk1stFullScreen)
        Me.grbMainVideoWindow.Controls.Add(Me.chk1stUseVideoPort)
        Me.grbMainVideoWindow.Controls.Add(Me.btnTestPanScan)
        Me.grbMainVideoWindow.Controls.Add(Me.tbr1PanScan)
        Me.grbMainVideoWindow.Controls.Add(Me.chk1stVisible)
        Me.grbMainVideoWindow.Controls.Add(Me.rdg1AspectRatio)
        Me.grbMainVideoWindow.Controls.Add(Me.chk1stEmbedded)
        Me.grbMainVideoWindow.Controls.Add(Me.chk1stMouseMovesWindow)
        Me.grbMainVideoWindow.Controls.Add(Me.chk1stStayOnTop)
        Me.grbMainVideoWindow.Controls.Add(Me.chk1stAutoSize)
        Me.grbMainVideoWindow.Controls.Add(Me.btnEG1stNewLocation)
        Me.grbMainVideoWindow.Controls.Add(Me.btnEG1stNewLocation2)
        Me.grbMainVideoWindow.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbMainVideoWindow.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grbMainVideoWindow.Location = New System.Drawing.Point(288, 16)
        Me.grbMainVideoWindow.Name = "grbMainVideoWindow"
        Me.grbMainVideoWindow.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grbMainVideoWindow.Size = New System.Drawing.Size(313, 163)
        Me.grbMainVideoWindow.TabIndex = 10
        Me.grbMainVideoWindow.TabStop = False
        Me.grbMainVideoWindow.Text = "main video window"
        '
        'btnTestPanScanHelp
        '
        Me.btnTestPanScanHelp.Location = New System.Drawing.Point(286, 118)
        Me.btnTestPanScanHelp.Name = "btnTestPanScanHelp"
        Me.btnTestPanScanHelp.Size = New System.Drawing.Size(18, 21)
        Me.btnTestPanScanHelp.TabIndex = 28
        Me.btnTestPanScanHelp.Text = "?"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(167, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 28)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "pan-scan ratio:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " (0 - 100)"
        '
        'rdg1stDisplayedOn
        '
        Me.rdg1stDisplayedOn.BackColor = System.Drawing.SystemColors.Control
        Me.rdg1stDisplayedOn.Controls.Add(Me.rdg1stDisplayedOn2)
        Me.rdg1stDisplayedOn.Controls.Add(Me.rdg1stDisplayedOn1)
        Me.rdg1stDisplayedOn.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdg1stDisplayedOn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdg1stDisplayedOn.Location = New System.Drawing.Point(220, 9)
        Me.rdg1stDisplayedOn.Name = "rdg1stDisplayedOn"
        Me.rdg1stDisplayedOn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdg1stDisplayedOn.Size = New System.Drawing.Size(87, 52)
        Me.rdg1stDisplayedOn.TabIndex = 13
        Me.rdg1stDisplayedOn.TabStop = False
        Me.rdg1stDisplayedOn.Text = "display on..."
        '
        'rdg1stDisplayedOn2
        '
        Me.rdg1stDisplayedOn2.BackColor = System.Drawing.SystemColors.Control
        Me.rdg1stDisplayedOn2.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdg1stDisplayedOn2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdg1stDisplayedOn2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdg1stDisplayedOn2.Location = New System.Drawing.Point(6, 31)
        Me.rdg1stDisplayedOn2.Name = "rdg1stDisplayedOn2"
        Me.rdg1stDisplayedOn2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdg1stDisplayedOn2.Size = New System.Drawing.Size(79, 17)
        Me.rdg1stDisplayedOn2.TabIndex = 14
        Me.rdg1stDisplayedOn2.TabStop = True
        Me.rdg1stDisplayedOn2.Tag = "1"
        Me.rdg1stDisplayedOn2.Text = "2nd monitor"
        Me.rdg1stDisplayedOn2.UseVisualStyleBackColor = False
        '
        'rdg1stDisplayedOn1
        '
        Me.rdg1stDisplayedOn1.BackColor = System.Drawing.SystemColors.Control
        Me.rdg1stDisplayedOn1.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdg1stDisplayedOn1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdg1stDisplayedOn1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdg1stDisplayedOn1.Location = New System.Drawing.Point(6, 16)
        Me.rdg1stDisplayedOn1.Name = "rdg1stDisplayedOn1"
        Me.rdg1stDisplayedOn1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdg1stDisplayedOn1.Size = New System.Drawing.Size(79, 17)
        Me.rdg1stDisplayedOn1.TabIndex = 15
        Me.rdg1stDisplayedOn1.TabStop = True
        Me.rdg1stDisplayedOn1.Tag = "0"
        Me.rdg1stDisplayedOn1.Text = "1st monitor"
        Me.rdg1stDisplayedOn1.UseVisualStyleBackColor = False
        '
        'chk1stFullScreen
        '
        Me.chk1stFullScreen.BackColor = System.Drawing.SystemColors.Control
        Me.chk1stFullScreen.Cursor = System.Windows.Forms.Cursors.Default
        Me.chk1stFullScreen.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk1stFullScreen.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chk1stFullScreen.Location = New System.Drawing.Point(85, 14)
        Me.chk1stFullScreen.Name = "chk1stFullScreen"
        Me.chk1stFullScreen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chk1stFullScreen.Size = New System.Drawing.Size(89, 17)
        Me.chk1stFullScreen.TabIndex = 19
        Me.chk1stFullScreen.Text = "full screen"
        Me.chk1stFullScreen.UseVisualStyleBackColor = False
        '
        'chk1stUseVideoPort
        '
        Me.chk1stUseVideoPort.BackColor = System.Drawing.SystemColors.Control
        Me.chk1stUseVideoPort.Cursor = System.Windows.Forms.Cursors.Default
        Me.chk1stUseVideoPort.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk1stUseVideoPort.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chk1stUseVideoPort.Location = New System.Drawing.Point(85, 30)
        Me.chk1stUseVideoPort.Name = "chk1stUseVideoPort"
        Me.chk1stUseVideoPort.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chk1stUseVideoPort.Size = New System.Drawing.Size(120, 17)
        Me.chk1stUseVideoPort.TabIndex = 21
        Me.chk1stUseVideoPort.Text = "use video port"
        Me.chk1stUseVideoPort.UseVisualStyleBackColor = False
        '
        'btnTestPanScan
        '
        Me.btnTestPanScan.Location = New System.Drawing.Point(249, 118)
        Me.btnTestPanScan.Name = "btnTestPanScan"
        Me.btnTestPanScan.Size = New System.Drawing.Size(37, 21)
        Me.btnTestPanScan.TabIndex = 27
        Me.btnTestPanScan.Text = "test"
        '
        'tbr1PanScan
        '
        Me.tbr1PanScan.AutoSize = False
        Me.tbr1PanScan.Location = New System.Drawing.Point(165, 137)
        Me.tbr1PanScan.Maximum = 100
        Me.tbr1PanScan.Name = "tbr1PanScan"
        Me.tbr1PanScan.Size = New System.Drawing.Size(142, 20)
        Me.tbr1PanScan.TabIndex = 26
        Me.tbr1PanScan.TickFrequency = 10
        Me.tbr1PanScan.Value = 50
        '
        'chk1stVisible
        '
        Me.chk1stVisible.Location = New System.Drawing.Point(8, 14)
        Me.chk1stVisible.Name = "chk1stVisible"
        Me.chk1stVisible.Size = New System.Drawing.Size(80, 17)
        Me.chk1stVisible.TabIndex = 24
        Me.chk1stVisible.Text = "visible"
        '
        'rdg1AspectRatio
        '
        Me.rdg1AspectRatio.Controls.Add(Me.rdg1DisplayAspectRatioPanScan)
        Me.rdg1AspectRatio.Controls.Add(Me.rdg1DisplayAspectRatioStretch)
        Me.rdg1AspectRatio.Controls.Add(Me.rdg1DisplayAspectRatioPan)
        Me.rdg1AspectRatio.Controls.Add(Me.rdg1DisplayAspectRatioBox)
        Me.rdg1AspectRatio.Location = New System.Drawing.Point(8, 80)
        Me.rdg1AspectRatio.Name = "rdg1AspectRatio"
        Me.rdg1AspectRatio.Size = New System.Drawing.Size(153, 83)
        Me.rdg1AspectRatio.TabIndex = 23
        Me.rdg1AspectRatio.TabStop = False
        Me.rdg1AspectRatio.Text = "aspect ratio"
        '
        'rdg1DisplayAspectRatioPanScan
        '
        Me.rdg1DisplayAspectRatioPanScan.Location = New System.Drawing.Point(8, 62)
        Me.rdg1DisplayAspectRatioPanScan.Name = "rdg1DisplayAspectRatioPanScan"
        Me.rdg1DisplayAspectRatioPanScan.Size = New System.Drawing.Size(115, 16)
        Me.rdg1DisplayAspectRatioPanScan.TabIndex = 3
        Me.rdg1DisplayAspectRatioPanScan.Tag = "3"
        Me.rdg1DisplayAspectRatioPanScan.Text = "pan-scan"
        '
        'rdg1DisplayAspectRatioStretch
        '
        Me.rdg1DisplayAspectRatioStretch.Location = New System.Drawing.Point(8, 46)
        Me.rdg1DisplayAspectRatioStretch.Name = "rdg1DisplayAspectRatioStretch"
        Me.rdg1DisplayAspectRatioStretch.Size = New System.Drawing.Size(115, 16)
        Me.rdg1DisplayAspectRatioStretch.TabIndex = 2
        Me.rdg1DisplayAspectRatioStretch.Tag = "2"
        Me.rdg1DisplayAspectRatioStretch.Text = "stretch"
        '
        'rdg1DisplayAspectRatioPan
        '
        Me.rdg1DisplayAspectRatioPan.Location = New System.Drawing.Point(8, 30)
        Me.rdg1DisplayAspectRatioPan.Name = "rdg1DisplayAspectRatioPan"
        Me.rdg1DisplayAspectRatioPan.Size = New System.Drawing.Size(115, 17)
        Me.rdg1DisplayAspectRatioPan.TabIndex = 1
        Me.rdg1DisplayAspectRatioPan.Tag = "1"
        Me.rdg1DisplayAspectRatioPan.Text = "no resize"
        '
        'rdg1DisplayAspectRatioBox
        '
        Me.rdg1DisplayAspectRatioBox.Location = New System.Drawing.Point(8, 14)
        Me.rdg1DisplayAspectRatioBox.Name = "rdg1DisplayAspectRatioBox"
        Me.rdg1DisplayAspectRatioBox.Size = New System.Drawing.Size(143, 16)
        Me.rdg1DisplayAspectRatioBox.TabIndex = 0
        Me.rdg1DisplayAspectRatioBox.Tag = "0"
        Me.rdg1DisplayAspectRatioBox.Text = "box (letterbox, pillarbox)"
        '
        'chk1stEmbedded
        '
        Me.chk1stEmbedded.BackColor = System.Drawing.SystemColors.Control
        Me.chk1stEmbedded.Cursor = System.Windows.Forms.Cursors.Default
        Me.chk1stEmbedded.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk1stEmbedded.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chk1stEmbedded.Location = New System.Drawing.Point(8, 30)
        Me.chk1stEmbedded.Name = "chk1stEmbedded"
        Me.chk1stEmbedded.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chk1stEmbedded.Size = New System.Drawing.Size(80, 17)
        Me.chk1stEmbedded.TabIndex = 22
        Me.chk1stEmbedded.Text = "embedded"
        Me.chk1stEmbedded.UseVisualStyleBackColor = False
        '
        'chk1stMouseMovesWindow
        '
        Me.chk1stMouseMovesWindow.BackColor = System.Drawing.SystemColors.Control
        Me.chk1stMouseMovesWindow.Cursor = System.Windows.Forms.Cursors.Default
        Me.chk1stMouseMovesWindow.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk1stMouseMovesWindow.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chk1stMouseMovesWindow.Location = New System.Drawing.Point(85, 46)
        Me.chk1stMouseMovesWindow.Name = "chk1stMouseMovesWindow"
        Me.chk1stMouseMovesWindow.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chk1stMouseMovesWindow.Size = New System.Drawing.Size(136, 17)
        Me.chk1stMouseMovesWindow.TabIndex = 18
        Me.chk1stMouseMovesWindow.Text = "mouse moves window"
        Me.chk1stMouseMovesWindow.UseVisualStyleBackColor = False
        '
        'chk1stStayOnTop
        '
        Me.chk1stStayOnTop.BackColor = System.Drawing.SystemColors.Control
        Me.chk1stStayOnTop.Cursor = System.Windows.Forms.Cursors.Default
        Me.chk1stStayOnTop.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk1stStayOnTop.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chk1stStayOnTop.Location = New System.Drawing.Point(8, 62)
        Me.chk1stStayOnTop.Name = "chk1stStayOnTop"
        Me.chk1stStayOnTop.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chk1stStayOnTop.Size = New System.Drawing.Size(88, 17)
        Me.chk1stStayOnTop.TabIndex = 17
        Me.chk1stStayOnTop.Text = "stay on top"
        Me.chk1stStayOnTop.UseVisualStyleBackColor = False
        '
        'chk1stAutoSize
        '
        Me.chk1stAutoSize.BackColor = System.Drawing.SystemColors.Control
        Me.chk1stAutoSize.Cursor = System.Windows.Forms.Cursors.Default
        Me.chk1stAutoSize.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk1stAutoSize.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chk1stAutoSize.Location = New System.Drawing.Point(8, 46)
        Me.chk1stAutoSize.Name = "chk1stAutoSize"
        Me.chk1stAutoSize.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chk1stAutoSize.Size = New System.Drawing.Size(80, 17)
        Me.chk1stAutoSize.TabIndex = 16
        Me.chk1stAutoSize.Text = "autosize"
        Me.chk1stAutoSize.UseVisualStyleBackColor = False
        '
        'btnEG1stNewLocation
        '
        Me.btnEG1stNewLocation.BackColor = System.Drawing.SystemColors.Control
        Me.btnEG1stNewLocation.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnEG1stNewLocation.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEG1stNewLocation.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEG1stNewLocation.Location = New System.Drawing.Point(165, 67)
        Me.btnEG1stNewLocation.Name = "btnEG1stNewLocation"
        Me.btnEG1stNewLocation.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnEG1stNewLocation.Size = New System.Drawing.Size(140, 21)
        Me.btnEG1stNewLocation.TabIndex = 12
        Me.btnEG1stNewLocation.Text = "e.g. 10,10 (autosize)"
        Me.btnEG1stNewLocation.UseVisualStyleBackColor = False
        '
        'btnEG1stNewLocation2
        '
        Me.btnEG1stNewLocation2.BackColor = System.Drawing.SystemColors.Control
        Me.btnEG1stNewLocation2.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnEG1stNewLocation2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEG1stNewLocation2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEG1stNewLocation2.Location = New System.Drawing.Point(165, 91)
        Me.btnEG1stNewLocation2.Name = "btnEG1stNewLocation2"
        Me.btnEG1stNewLocation2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnEG1stNewLocation2.Size = New System.Drawing.Size(140, 21)
        Me.btnEG1stNewLocation2.TabIndex = 11
        Me.btnEG1stNewLocation2.Text = "e.g. 20,20 (480,200)"
        Me.btnEG1stNewLocation2.UseVisualStyleBackColor = False
        '
        'chk1stVideoWindowActive
        '
        Me.chk1stVideoWindowActive.BackColor = System.Drawing.SystemColors.Control
        Me.chk1stVideoWindowActive.Cursor = System.Windows.Forms.Cursors.Default
        Me.chk1stVideoWindowActive.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk1stVideoWindowActive.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chk1stVideoWindowActive.Location = New System.Drawing.Point(348, 0)
        Me.chk1stVideoWindowActive.Name = "chk1stVideoWindowActive"
        Me.chk1stVideoWindowActive.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chk1stVideoWindowActive.Size = New System.Drawing.Size(185, 17)
        Me.chk1stVideoWindowActive.TabIndex = 9
        Me.chk1stVideoWindowActive.Text = "MAIN VIDEO WINDOW ACTIVE"
        Me.chk1stVideoWindowActive.UseVisualStyleBackColor = False
        '
        'chkSetLogo
        '
        Me.chkSetLogo.BackColor = System.Drawing.SystemColors.Control
        Me.chkSetLogo.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkSetLogo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSetLogo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkSetLogo.Location = New System.Drawing.Point(120, 109)
        Me.chkSetLogo.Name = "chkSetLogo"
        Me.chkSetLogo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkSetLogo.Size = New System.Drawing.Size(135, 17)
        Me.chkSetLogo.TabIndex = 8
        Me.chkSetLogo.Text = "show logo, e.g.:"
        Me.chkSetLogo.UseVisualStyleBackColor = False
        '
        'chkBorder
        '
        Me.chkBorder.BackColor = System.Drawing.SystemColors.Control
        Me.chkBorder.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkBorder.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBorder.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkBorder.Location = New System.Drawing.Point(120, 70)
        Me.chkBorder.Name = "chkBorder"
        Me.chkBorder.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkBorder.Size = New System.Drawing.Size(96, 17)
        Me.chkBorder.TabIndex = 7
        Me.chkBorder.Text = "border"
        Me.chkBorder.UseVisualStyleBackColor = False
        '
        'chkChangeCursor
        '
        Me.chkChangeCursor.BackColor = System.Drawing.SystemColors.Control
        Me.chkChangeCursor.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkChangeCursor.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkChangeCursor.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkChangeCursor.Location = New System.Drawing.Point(120, 54)
        Me.chkChangeCursor.Name = "chkChangeCursor"
        Me.chkChangeCursor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkChangeCursor.Size = New System.Drawing.Size(160, 17)
        Me.chkChangeCursor.TabIndex = 6
        Me.chkChangeCursor.Text = "change cursor (e.g.: cross)"
        Me.chkChangeCursor.UseVisualStyleBackColor = False
        '
        'imgLogo
        '
        Me.imgLogo.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgLogo.Image = CType(resources.GetObject("imgLogo.Image"), System.Drawing.Image)
        Me.imgLogo.Location = New System.Drawing.Point(120, 126)
        Me.imgLogo.Name = "imgLogo"
        Me.imgLogo.Size = New System.Drawing.Size(71, 50)
        Me.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgLogo.TabIndex = 37
        Me.imgLogo.TabStop = False
        '
        'chkTransparency
        '
        Me.chkTransparency.Location = New System.Drawing.Point(120, 86)
        Me.chkTransparency.Name = "chkTransparency"
        Me.chkTransparency.Size = New System.Drawing.Size(96, 17)
        Me.chkTransparency.TabIndex = 38
        Me.chkTransparency.Text = "transparency"
        '
        'rdgVideoRenderer
        '
        Me.rdgVideoRenderer.BackColor = System.Drawing.SystemColors.Control
        Me.rdgVideoRenderer.Controls.Add(Me.rdgVideoRendererEVR)
        Me.rdgVideoRenderer.Controls.Add(Me.rdgVideoRendererNone)
        Me.rdgVideoRenderer.Controls.Add(Me.rdgVideoRendererOverlay)
        Me.rdgVideoRenderer.Controls.Add(Me.rdgVideoRendererStandard)
        Me.rdgVideoRenderer.Controls.Add(Me.rdgVideoRendererAutoSelect)
        Me.rdgVideoRenderer.Controls.Add(Me.rdgVideoRendererVMR7)
        Me.rdgVideoRenderer.Controls.Add(Me.rdgVideoRendererVMR9)
        Me.rdgVideoRenderer.Controls.Add(Me.rdgVideoRendererRecPriority)
        Me.rdgVideoRenderer.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgVideoRenderer.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgVideoRenderer.Location = New System.Drawing.Point(4, 0)
        Me.rdgVideoRenderer.Name = "rdgVideoRenderer"
        Me.rdgVideoRenderer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgVideoRenderer.Size = New System.Drawing.Size(112, 179)
        Me.rdgVideoRenderer.TabIndex = 39
        Me.rdgVideoRenderer.TabStop = False
        Me.rdgVideoRenderer.Text = "video renderer"
        '
        'rdgVideoRendererEVR
        '
        Me.rdgVideoRendererEVR.BackColor = System.Drawing.SystemColors.Control
        Me.rdgVideoRendererEVR.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgVideoRendererEVR.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgVideoRendererEVR.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgVideoRendererEVR.Location = New System.Drawing.Point(8, 38)
        Me.rdgVideoRendererEVR.Name = "rdgVideoRendererEVR"
        Me.rdgVideoRendererEVR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgVideoRendererEVR.Size = New System.Drawing.Size(65, 17)
        Me.rdgVideoRendererEVR.TabIndex = 46
        Me.rdgVideoRendererEVR.TabStop = True
        Me.rdgVideoRendererEVR.Tag = "1"
        Me.rdgVideoRendererEVR.Text = "EVR"
        Me.rdgVideoRendererEVR.UseVisualStyleBackColor = False
        '
        'rdgVideoRendererNone
        '
        Me.rdgVideoRendererNone.Location = New System.Drawing.Point(8, 152)
        Me.rdgVideoRendererNone.Name = "rdgVideoRendererNone"
        Me.rdgVideoRendererNone.Size = New System.Drawing.Size(80, 17)
        Me.rdgVideoRendererNone.TabIndex = 43
        Me.rdgVideoRendererNone.Tag = "7"
        Me.rdgVideoRendererNone.Text = "none"
        '
        'rdgVideoRendererOverlay
        '
        Me.rdgVideoRendererOverlay.BackColor = System.Drawing.SystemColors.Control
        Me.rdgVideoRendererOverlay.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgVideoRendererOverlay.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgVideoRendererOverlay.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgVideoRendererOverlay.Location = New System.Drawing.Point(8, 114)
        Me.rdgVideoRendererOverlay.Name = "rdgVideoRendererOverlay"
        Me.rdgVideoRendererOverlay.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgVideoRendererOverlay.Size = New System.Drawing.Size(64, 17)
        Me.rdgVideoRendererOverlay.TabIndex = 42
        Me.rdgVideoRendererOverlay.TabStop = True
        Me.rdgVideoRendererOverlay.Tag = "5"
        Me.rdgVideoRendererOverlay.Text = "overlay"
        Me.rdgVideoRendererOverlay.UseVisualStyleBackColor = False
        '
        'rdgVideoRendererStandard
        '
        Me.rdgVideoRendererStandard.BackColor = System.Drawing.SystemColors.Control
        Me.rdgVideoRendererStandard.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgVideoRendererStandard.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgVideoRendererStandard.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgVideoRendererStandard.Location = New System.Drawing.Point(8, 95)
        Me.rdgVideoRendererStandard.Name = "rdgVideoRendererStandard"
        Me.rdgVideoRendererStandard.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgVideoRendererStandard.Size = New System.Drawing.Size(73, 17)
        Me.rdgVideoRendererStandard.TabIndex = 41
        Me.rdgVideoRendererStandard.TabStop = True
        Me.rdgVideoRendererStandard.Tag = "4"
        Me.rdgVideoRendererStandard.Text = "standard"
        Me.rdgVideoRendererStandard.UseVisualStyleBackColor = False
        '
        'rdgVideoRendererAutoSelect
        '
        Me.rdgVideoRendererAutoSelect.BackColor = System.Drawing.SystemColors.Control
        Me.rdgVideoRendererAutoSelect.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgVideoRendererAutoSelect.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgVideoRendererAutoSelect.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgVideoRendererAutoSelect.Location = New System.Drawing.Point(8, 19)
        Me.rdgVideoRendererAutoSelect.Name = "rdgVideoRendererAutoSelect"
        Me.rdgVideoRendererAutoSelect.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgVideoRendererAutoSelect.Size = New System.Drawing.Size(80, 17)
        Me.rdgVideoRendererAutoSelect.TabIndex = 40
        Me.rdgVideoRendererAutoSelect.TabStop = True
        Me.rdgVideoRendererAutoSelect.Tag = "0"
        Me.rdgVideoRendererAutoSelect.Text = "auto select"
        Me.rdgVideoRendererAutoSelect.UseVisualStyleBackColor = False
        '
        'rdgVideoRendererVMR7
        '
        Me.rdgVideoRendererVMR7.BackColor = System.Drawing.SystemColors.Control
        Me.rdgVideoRendererVMR7.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgVideoRendererVMR7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgVideoRendererVMR7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgVideoRendererVMR7.Location = New System.Drawing.Point(8, 76)
        Me.rdgVideoRendererVMR7.Name = "rdgVideoRendererVMR7"
        Me.rdgVideoRendererVMR7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgVideoRendererVMR7.Size = New System.Drawing.Size(65, 17)
        Me.rdgVideoRendererVMR7.TabIndex = 39
        Me.rdgVideoRendererVMR7.TabStop = True
        Me.rdgVideoRendererVMR7.Tag = "3"
        Me.rdgVideoRendererVMR7.Text = "VMR7"
        Me.rdgVideoRendererVMR7.UseVisualStyleBackColor = False
        '
        'rdgVideoRendererVMR9
        '
        Me.rdgVideoRendererVMR9.BackColor = System.Drawing.SystemColors.Control
        Me.rdgVideoRendererVMR9.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgVideoRendererVMR9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgVideoRendererVMR9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgVideoRendererVMR9.Location = New System.Drawing.Point(8, 57)
        Me.rdgVideoRendererVMR9.Name = "rdgVideoRendererVMR9"
        Me.rdgVideoRendererVMR9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgVideoRendererVMR9.Size = New System.Drawing.Size(65, 17)
        Me.rdgVideoRendererVMR9.TabIndex = 38
        Me.rdgVideoRendererVMR9.TabStop = True
        Me.rdgVideoRendererVMR9.Tag = "2"
        Me.rdgVideoRendererVMR9.Text = "VMR9"
        Me.rdgVideoRendererVMR9.UseVisualStyleBackColor = False
        '
        'rdgVideoRendererRecPriority
        '
        Me.rdgVideoRendererRecPriority.AutoSize = True
        Me.rdgVideoRendererRecPriority.Location = New System.Drawing.Point(8, 133)
        Me.rdgVideoRendererRecPriority.Name = "rdgVideoRendererRecPriority"
        Me.rdgVideoRendererRecPriority.Size = New System.Drawing.Size(107, 18)
        Me.rdgVideoRendererRecPriority.TabIndex = 44
        Me.rdgVideoRendererRecPriority.Tag = "6"
        Me.rdgVideoRendererRecPriority.Text = "recording priority"
        '
        'chkVideoVisibleWhenStopped
        '
        Me.chkVideoVisibleWhenStopped.Location = New System.Drawing.Point(120, 22)
        Me.chkVideoVisibleWhenStopped.Name = "chkVideoVisibleWhenStopped"
        Me.chkVideoVisibleWhenStopped.Size = New System.Drawing.Size(160, 17)
        Me.chkVideoVisibleWhenStopped.TabIndex = 40
        Me.chkVideoVisibleWhenStopped.Text = "video visible when stopped"
        '
        'chkAdjustPixelAspectRatio
        '
        Me.chkAdjustPixelAspectRatio.BackColor = System.Drawing.SystemColors.Control
        Me.chkAdjustPixelAspectRatio.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkAdjustPixelAspectRatio.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAdjustPixelAspectRatio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkAdjustPixelAspectRatio.Location = New System.Drawing.Point(120, 38)
        Me.chkAdjustPixelAspectRatio.Name = "chkAdjustPixelAspectRatio"
        Me.chkAdjustPixelAspectRatio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkAdjustPixelAspectRatio.Size = New System.Drawing.Size(151, 17)
        Me.chkAdjustPixelAspectRatio.TabIndex = 41
        Me.chkAdjustPixelAspectRatio.Text = "adjust pixel aspect ratio"
        Me.chkAdjustPixelAspectRatio.UseVisualStyleBackColor = False
        '
        'chkBlackMagicOutput
        '
        Me.chkBlackMagicOutput.Location = New System.Drawing.Point(120, 6)
        Me.chkBlackMagicOutput.Name = "chkBlackMagicOutput"
        Me.chkBlackMagicOutput.Size = New System.Drawing.Size(160, 17)
        Me.chkBlackMagicOutput.TabIndex = 42
        Me.chkBlackMagicOutput.Text = "BlackMagic Decklink output"
        '
        'Display
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(959, 237)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkBlackMagicOutput)
        Me.Controls.Add(Me.chkAdjustPixelAspectRatio)
        Me.Controls.Add(Me.chkVideoVisibleWhenStopped)
        Me.Controls.Add(Me.rdgVideoRenderer)
        Me.Controls.Add(Me.chkTransparency)
        Me.Controls.Add(Me.chk2ndVideoWindowActive)
        Me.Controls.Add(Me.grb2ndVideoWindow)
        Me.Controls.Add(Me.grbMainVideoWindow)
        Me.Controls.Add(Me.chk1stVideoWindowActive)
        Me.Controls.Add(Me.chkSetLogo)
        Me.Controls.Add(Me.chkBorder)
        Me.Controls.Add(Me.chkChangeCursor)
        Me.Controls.Add(Me.imgLogo)
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(4, 23)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Display"
        Me.ShowInTaskbar = False
        Me.grb2ndVideoWindow.ResumeLayout(False)
        Me.grb2ndVideoWindow.PerformLayout()
        Me.rdg2ndDisplayedOn.ResumeLayout(False)
        CType(Me.tbr2PanScan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.rdg2AspectRatio.ResumeLayout(False)
        Me.grbMainVideoWindow.ResumeLayout(False)
        Me.grbMainVideoWindow.PerformLayout()
        Me.rdg1stDisplayedOn.ResumeLayout(False)
        CType(Me.tbr1PanScan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.rdg1AspectRatio.ResumeLayout(False)
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.rdgVideoRenderer.ResumeLayout(False)
        Me.rdgVideoRenderer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
#End Region
    Dim RefreshingDisplayOptions As Boolean = False

    Private frmTransparentWindow As TransparentWindow

    
    Private boolPanScan As Boolean
    Private PanScanVGWidth As Long
    Private PanScanVGHeight As Long
    

    Private Sub Display_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmTransparentWindow = New TransparentWindow
    End Sub

    Public Sub RefreshControls()
        ' NOTE: duplicating 2 times all the components of this form for the 2 windows
        ' is not very efficient, this has been done only for a better readability.
        SetRadioButtonInGroupUsingTag((rdgVideoRenderer), MainForm.DefInstance.VideoGrabber1.VideoRenderer)
        chkBorder.Checked = IIf(MainForm.DefInstance.VideoGrabber1.BorderStyle = VidGrab.TBorderStyle.bsSingle, System.Windows.Forms.CheckState.Checked, System.Windows.Forms.CheckState.Unchecked)
        chkAdjustPixelAspectRatio.Checked = MainForm.DefInstance.VideoGrabber1.AdjustPixelAspectRatio

        chk1stVisible.Checked = MainForm.DefInstance.VideoGrabber1.Display_Visible
        chk1stVideoWindowActive.Checked = MainForm.DefInstance.VideoGrabber1.Display_Active
        chk1stEmbedded.Checked = MainForm.DefInstance.VideoGrabber1.Display_Embedded
        chk1stFullScreen.Checked = MainForm.DefInstance.VideoGrabber1.Display_FullScreen
        chk1stStayOnTop.Checked = MainForm.DefInstance.VideoGrabber1.Display_StayOnTop
        chk1stUseVideoPort.Checked = MainForm.DefInstance.VideoGrabber1.Display_VideoPortEnabled
        chk1stMouseMovesWindow.Checked = MainForm.DefInstance.VideoGrabber1.Display_MouseMovesWindow
        chk1stAutoSize.Checked = MainForm.DefInstance.VideoGrabber1.Display_AutoSize
        SetRadioButtonInGroupUsingTag(rdg1stDisplayedOn, MainForm.DefInstance.VideoGrabber1.Display_Monitor)
        SetRadioButtonInGroupUsingTag(rdg1AspectRatio, MainForm.DefInstance.VideoGrabber1.Display_AspectRatio)
        tbr1PanScan.Value = MainForm.DefInstance.VideoGrabber1.Display_PanScanRatio

        grbMainVideoWindow.Enabled = MainForm.DefInstance.VideoGrabber1.Display_Active

        If MainForm.DefInstance.VideoGrabber1.Display_Active Then
            chk1stStayOnTop.Enabled = (Not MainForm.DefInstance.VideoGrabber1.Display_Embedded) Or MainForm.DefInstance.VideoGrabber1.Display_FullScreen
            chk1stMouseMovesWindow.Enabled = Not MainForm.DefInstance.VideoGrabber1.Display_Embedded
            rdg1stDisplayedOn.Enabled = Not MainForm.DefInstance.VideoGrabber1.Display_Embedded
            btnEG1stNewLocation.Enabled = Not MainForm.DefInstance.VideoGrabber1.Display_Embedded
            btnEG1stNewLocation2.Enabled = Not MainForm.DefInstance.VideoGrabber1.Display_Embedded
            chk1stUseVideoPort.Enabled = MainForm.DefInstance.VideoGrabber1.IsVideoPortAvailable
        End If

        chk2ndVisible.Checked = MainForm.DefInstance.VideoGrabber1.DualDisplay_Visible
        chk2ndVideoWindowActive.Checked = MainForm.DefInstance.VideoGrabber1.DualDisplay_Active
        chk2ndEmbedded.Checked = MainForm.DefInstance.VideoGrabber1.DualDisplay_Embedded
        chk2ndFullScreen.Checked = MainForm.DefInstance.VideoGrabber1.DualDisplay_FullScreen
        chk2ndStayOnTop.Checked = MainForm.DefInstance.VideoGrabber1.DualDisplay_StayOnTop
        chk2ndUseVideoPort.Checked = MainForm.DefInstance.VideoGrabber1.DualDisplay_VideoPortEnabled
        chk2ndMouseMovesWindow.Checked = MainForm.DefInstance.VideoGrabber1.DualDisplay_MouseMovesWindow
        chk2ndAutoSize.Checked = MainForm.DefInstance.VideoGrabber1.DualDisplay_AutoSize
        SetRadioButtonInGroupUsingTag(rdg2ndDisplayedOn, MainForm.DefInstance.VideoGrabber1.DualDisplay_Monitor)
        SetRadioButtonInGroupUsingTag(rdg2AspectRatio, MainForm.DefInstance.VideoGrabber1.DualDisplay_AspectRatio)
        tbr2PanScan.Value = MainForm.DefInstance.VideoGrabber1.DualDisplay_PanScanRatio

        grb2ndVideoWindow.Enabled = MainForm.DefInstance.VideoGrabber1.DualDisplay_Active

        If MainForm.DefInstance.VideoGrabber1.DualDisplay_Active Then
            chk2ndStayOnTop.Enabled = (Not MainForm.DefInstance.VideoGrabber1.DualDisplay_Embedded) Or MainForm.DefInstance.VideoGrabber1.DualDisplay_FullScreen
            chk2ndMouseMovesWindow.Enabled = Not MainForm.DefInstance.VideoGrabber1.DualDisplay_Embedded
            rdg2ndDisplayedOn.Enabled = Not MainForm.DefInstance.VideoGrabber1.DualDisplay_Embedded
            btnEG2ndNewLocation.Enabled = Not MainForm.DefInstance.VideoGrabber1.DualDisplay_Embedded
            btnEG2ndNewLocation.Enabled = Not MainForm.DefInstance.VideoGrabber1.DualDisplay_Embedded
            chk2ndUseVideoPort.Enabled = MainForm.DefInstance.VideoGrabber1.IsVideoPortAvailable
        End If
    End Sub

    Private Sub rdgVideoRenderer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgVideoRendererAutoSelect.CheckedChanged, rdgVideoRendererVMR9.CheckedChanged, rdgVideoRendererVMR7.CheckedChanged, rdgVideoRendererStandard.CheckedChanged, rdgVideoRendererOverlay.CheckedChanged, rdgVideoRendererRecPriority.CheckedChanged, rdgVideoRendererNone.CheckedChanged, rdgVideoRendererEVR.CheckedChanged
        If CType(sender, RadioButton).Checked Then
            MainForm.DefInstance.VideoGrabber1.VideoRenderer = sender.tag
        End If
    End Sub

    Private Sub btnEG1stNewLocation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEG1stNewLocation.Click
        MainForm.DefInstance.VideoGrabber1.Display_AutoSize = True ' the component"s video size will be used
        MainForm.DefInstance.VideoGrabber1.Display_Embedded = False ' detach from component
        MainForm.DefInstance.VideoGrabber1.Display_SetLocation(10, 10, 320, 240) ' 320 and 240 are not used because of AutoSize above
        RefreshControls()
    End Sub

    Private Sub btnEG1stNewLocation2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEG1stNewLocation2.Click
        MainForm.DefInstance.VideoGrabber1.Display_AutoSize = False ' we will specify the size below
        MainForm.DefInstance.VideoGrabber1.Display_Embedded = False ' detach from component
        MainForm.DefInstance.VideoGrabber1.Display_SetLocation(20, 20, 480, 200) ' new size: 480 x 360
        RefreshControls()
    End Sub

    Private Sub btnEG2ndNewLocation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEG2ndNewLocation.Click
        MainForm.DefInstance.VideoGrabber1.DualDisplay_AutoSize = True ' the component"s video size will be used
        MainForm.DefInstance.VideoGrabber1.DualDisplay_Embedded = False ' detach from component
        MainForm.DefInstance.VideoGrabber1.DualDisplay_SetLocation(510, 10, 320, 240) ' 320 and 240 are not used because of AutoSize above
        RefreshControls()

    End Sub

    Private Sub btnEG2ndNewLocation2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEG2ndNewLocation2.Click
        MainForm.DefInstance.VideoGrabber1.DualDisplay_AutoSize = False ' we will specify the size below
        MainForm.DefInstance.VideoGrabber1.DualDisplay_Embedded = False ' detach from component
        MainForm.DefInstance.VideoGrabber1.DualDisplay_SetLocation(520, 30, 480, 200) ' new size: 480 x 360
        RefreshControls()
    End Sub

    Private Sub chk1stAutoSize_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk1stAutoSize.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.Display_AutoSize = chk1stAutoSize.Checked
        RefreshControls()

        
        ' disabling Display_AutoSize alone will not restore previously set video Width 
        '  and Height...for demonstration purposes, Width and Height are here restored
        '  to initial IDE MainForm_Load values if Display_AutoSize has been disabled:
        If Not MainForm.DefInstance.VideoGrabber1.Display_AutoSize Then
            If MainForm.DefInstance.VideoGrabber1.Display_Embedded Then
                MainForm.DefInstance.VideoGrabber1.Width = MainForm.DefInstance.StartupVGWidth
                MainForm.DefInstance.VideoGrabber1.Height = MainForm.DefInstance.StartupVGHeight
            Else
                MainForm.DefInstance.VideoGrabber1.Display_Width = MainForm.DefInstance.StartupVGWidth
                MainForm.DefInstance.VideoGrabber1.Display_Height = MainForm.DefInstance.StartupVGHeight
            End If
        End If
        
    End Sub

    Private Sub chk1stVisible_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk1stVisible.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.Display_Visible = chk1stVisible.Checked
    End Sub

    Private Sub chk1stEmbedded_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk1stEmbedded.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.Display_Embedded = chk1stEmbedded.Checked
        RefreshControls()
    End Sub

    Private Sub chk1stFullScreen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk1stFullScreen.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.Display_FullScreen = chk1stFullScreen.Checked
        RefreshControls()
    End Sub

    Private Sub chk1stMouseMovesWindow_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk1stMouseMovesWindow.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.Display_MouseMovesWindow = chk1stMouseMovesWindow.Checked
        RefreshControls()
    End Sub

    Private Sub chk1stStayOnTop_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk1stStayOnTop.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.Display_StayOnTop = chk1stStayOnTop.Checked
        RefreshControls()
    End Sub

    Private Sub chk1stUseVideoPort_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk1stUseVideoPort.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.Display_VideoPortEnabled = chk1stUseVideoPort.Checked
        RefreshControls()
    End Sub

    Private Sub chk2ndAutoSize_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk2ndAutoSize.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.DualDisplay_AutoSize = chk2ndAutoSize.Checked
        RefreshControls()

        
        ' disabling DualDisplay_AutoSize alone will not restore previously set video Width 
        '  and Height...for demonstration purposes, Width and Height are here restored
        '  to initial IDE MainForm_Load values if DualDisplay_AutoSize has been disabled:
        If Not MainForm.DefInstance.VideoGrabber1.DualDisplay_AutoSize Then
            If MainForm.DefInstance.VideoGrabber1.DualDisplay_Embedded Then
                MainForm.DefInstance.VideoGrabber1.Width = MainForm.DefInstance.StartupVGWidth
                MainForm.DefInstance.VideoGrabber1.Height = MainForm.DefInstance.StartupVGHeight
            Else
                MainForm.DefInstance.VideoGrabber1.DualDisplay_Width = MainForm.DefInstance.StartupVGWidth
                MainForm.DefInstance.VideoGrabber1.DualDisplay_Height = MainForm.DefInstance.StartupVGHeight
            End If
        End If
        
    End Sub

    Private Sub chk2ndVisible_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk2ndVisible.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.DualDisplay_Visible = chk2ndVisible.Checked
    End Sub

    Private Sub chk2ndEmbedded_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk2ndEmbedded.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.DualDisplay_Embedded = chk2ndEmbedded.Checked
        RefreshControls()
    End Sub

    Private Sub chk2ndFullScreen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk2ndFullScreen.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.DualDisplay_FullScreen = chk2ndFullScreen.Checked
        RefreshControls()
    End Sub

    Private Sub chk2ndMouseMovesWindow_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk2ndMouseMovesWindow.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.DualDisplay_MouseMovesWindow = chk2ndMouseMovesWindow.Checked
        RefreshControls()
    End Sub

    Private Sub chk2ndStayOnTop_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk2ndStayOnTop.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.DualDisplay_StayOnTop = chk2ndStayOnTop.Checked
        RefreshControls()
    End Sub

    Private Sub chk2ndUseVideoPort_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk2ndUseVideoPort.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.DualDisplay_VideoPortEnabled = chk2ndUseVideoPort.Checked
        RefreshControls()
    End Sub

    Private Sub chkBlackMagicOutput_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBlackMagicOutput.CheckedChanged
        If chkBlackMagicOutput.Checked Then
            MainForm.DefInstance.VideoGrabber1.VideoRendererExternal = VidGrab.TVideoRendererExternal.vre_BlackMagic_Decklink
        Else
            MainForm.DefInstance.VideoGrabber1.VideoRendererExternal = VidGrab.TVideoRendererExternal.vre_None
        End If
    End Sub

    Private Sub chkVideoVisibleWhenStopped_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVideoVisibleWhenStopped.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.VideoVisibleWhenStopped = chkVideoVisibleWhenStopped.Checked
    End Sub

    Private Sub chkAdjustPixelAspectRatio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAdjustPixelAspectRatio.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.AdjustPixelAspectRatio = chkAdjustPixelAspectRatio.Checked
    End Sub

    Private Sub chkBorder_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBorder.CheckedChanged
#If Not VS2003 Then
        If chkBorder.Checked Then
            MainForm.DefInstance.VideoGrabber1.BorderStyle = VidGrab.TBorderStyle.bsSingle
        Else
            MainForm.DefInstance.VideoGrabber1.BorderStyle = VidGrab.TBorderStyle.bsNone
        End If
#End If
    End Sub

    Private Sub chkChangeCursor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkChangeCursor.CheckedChanged
        Select Case chkChangeCursor.Checked
            Case True
                MainForm.DefInstance.VideoGrabber1.VideoCursor = VidGrab.TCursors.cr_cross
            Case False
                MainForm.DefInstance.VideoGrabber1.VideoCursor = VidGrab.TCursors.cr_Default
        End Select
    End Sub

    Private Sub rdg1stDisplayedOnMonitor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdg1stDisplayedOn1.CheckedChanged, rdg1stDisplayedOn2.CheckedChanged
        If CType(sender, RadioButton).Checked Then
            MainForm.DefInstance.VideoGrabber1.Display_Monitor = sender.tag
            RefreshControls()
        End If
    End Sub

    Private Sub rdg2ndDisplayedOn1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdg2ndDisplayedOn1.CheckedChanged, rdg2ndDisplayedOn2.CheckedChanged
        If CType(sender, RadioButton).Checked Then
            MainForm.DefInstance.VideoGrabber1.DualDisplay_Monitor = sender.tag
            RefreshControls()
        End If
    End Sub

    Private Sub chk2ndVideoWindowActive_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk2ndVideoWindowActive.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.DualDisplay_Active = chk2ndVideoWindowActive.Checked
        RefreshControls()
    End Sub

    Private Sub chk1stVideoWindowActive_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk1stVideoWindowActive.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.Display_Active = chk1stVideoWindowActive.Checked
        RefreshControls()
    End Sub

    Private Sub chkSetLogo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSetLogo.CheckedChanged
        Select Case chkSetLogo.Checked
            Case True
                MainForm.DefInstance.VideoGrabber1.SetLogoFromHBitmap(CreateBitmapHandleFromPictureBox(imgLogo))
                MainForm.DefInstance.VideoGrabber1.LogoLayout = VidGrab.TLogoLayout.lg_Stretched
                MainForm.DefInstance.VideoGrabber1.LogoDisplayed = True
            Case False
                MainForm.DefInstance.VideoGrabber1.LogoDisplayed = False
        End Select
    End Sub

    Private Sub chkTransparency_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTransparency.CheckedChanged
        frmTransparentWindow.TransparencyKey = Color.FromArgb(MainForm.DefInstance.VideoGrabber1.ColorKey)
        frmTransparentWindow.BackColor = ColorTranslator.FromWin32 (frmTransparentWindow.TransparencyKey.ToArgb())
        frmTransparentWindow.TransparentLabel.ForeColor = Color.Red
        frmTransparentWindow.Show()
    End Sub

    Private Sub rdgDisplayAspectRatio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdg1DisplayAspectRatioBox.CheckedChanged, rdg1DisplayAspectRatioPan.CheckedChanged, rdg1DisplayAspectRatioStretch.CheckedChanged, rdg1DisplayAspectRatioPanScan.CheckedChanged
        If CType(sender, RadioButton).Checked Then
            MainForm.DefInstance.VideoGrabber1.Display_AspectRatio = sender.tag
        End If
    End Sub

    Private Sub tbr1PanScan_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbr1PanScan.Scroll
        MainForm.DefInstance.VideoGrabber1.Display_PanScanRatio = tbr1PanScan.Value
    End Sub

    Private Sub btnTestPanScan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTestPanScan.Click


        chk1stEmbedded.Checked = True
        MainForm.DefInstance.VideoGrabber1.Display_Embedded = True
        chkAdjustPixelAspectRatio.Checked = False
        MainForm.DefInstance.VideoGrabber1.AdjustPixelAspectRatio = False
        chk1stAutoSize.Checked = False
        MainForm.DefInstance.VideoGrabber1.Display_AutoSize = False

        ' disabling Display_AutoSize alone will not restore previously set video Width 
        '  and Height...for demonstration purposes, Width and Height are here restored
        '  to initial IDE MainForm_Load values if Display_AutoSize is enabled
        If Not MainForm.DefInstance.VideoGrabber1.Display_AutoSize Then
            If MainForm.DefInstance.VideoGrabber1.Display_Embedded Then
                MainForm.DefInstance.VideoGrabber1.Width = MainForm.DefInstance.StartupVGWidth
                MainForm.DefInstance.VideoGrabber1.Height = MainForm.DefInstance.StartupVGHeight
            Else
                MainForm.DefInstance.VideoGrabber1.Display_Width = MainForm.DefInstance.StartupVGWidth
                MainForm.DefInstance.VideoGrabber1.Display_Height = MainForm.DefInstance.StartupVGHeight
            End If
        End If

        ' for pan / scan demonstration, change video Width and Height to a
        '  16 x 9 aspect ratio, or restore to pre-demonstration Width and Height
        If boolPanScan Then
            MainForm.DefInstance.VideoGrabber1.Width = PanScanVGWidth
            MainForm.DefInstance.VideoGrabber1.Height = PanScanVGHeight
        Else
            PanScanVGWidth = MainForm.DefInstance.VideoGrabber1.Width
            PanScanVGHeight = MainForm.DefInstance.VideoGrabber1.Height
            MainForm.DefInstance.VideoGrabber1.Width = MainForm.DefInstance.VideoGrabber1.Height * (16 / 9)
        End If
        boolPanScan = Not boolPanScan

        ' setting Display_AspectRatio to ar_PanScan (pan and scan)
        rdg1DisplayAspectRatioPanScan.Checked = True
        MainForm.DefInstance.VideoGrabber1.Display_AspectRatio = VidGrab.TAspectRatio.ar_PanScan


    End Sub

    Private Sub btnTestPanScanHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTestPanScanHelp.Click

        MessageBox.Show("Test Display_AspectRatio settings with Display_AutoSize disabled:" & vbCrLf & vbCrLf & _
                "With Display_AutoSize = False and AdjustPixelAspectRatio= False, the Display_AspectRatio setting" & vbCrLf & _
                "  determines how the video is displayed within the control Width and Height properties:" & vbCrLf & _
                "  ar_Box: video appears in full with correct aspect ratio (e.g. letterbox)" & vbCrLf & _
                "  ar_NoResize: video appears in ""native"" size with correct aspect ratio" & vbCrLf & _
                "  ar_Stretch: video is stretched to fill the control, regardless of correct aspect ratio" & vbCrLf & _
                "  ar_PanScan: Display_PanScanRatio (0-100) determines setting between ""letterbox"" and ""pan-scan""" & vbCrLf & vbCrLf & _
                "(see Help: ""User guide.Display - Dual display.Video window"")", _
                "DataStead TVideoGrabber VB.NET OCX Demo", MessageBoxButtons.OK)

    End Sub

    Private Sub rdgDualDisplayAspectRatio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdg2DisplayAspectRatioBox.CheckedChanged, rdg2DisplayAspectRatioPan.CheckedChanged, rdg2DisplayAspectRatioStretch.CheckedChanged, rdg2DisplayAspectRatioPanScan.CheckedChanged
        If CType(sender, RadioButton).Checked Then
            MainForm.DefInstance.VideoGrabber1.DualDisplay_AspectRatio = sender.tag
        End If
    End Sub

    Private Sub tbr2PanScan_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbr2PanScan.Scroll
        MainForm.DefInstance.VideoGrabber1.DualDisplay_PanScanRatio = tbr2PanScan.Value
    End Sub

    Private Sub Display_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        If Visible Then
            RefreshControls()
        End If

    End Sub

End Class
