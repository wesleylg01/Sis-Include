Option Strict Off
Option Explicit On
Friend Class NetworkStreaming
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
    Public WithEvents btnViewDirectNetworkStreaming As System.Windows.Forms.Button
    Public WithEvents rdgNetworkStreaming As System.Windows.Forms.GroupBox
    Public WithEvents edtNetworkPort As System.Windows.Forms.TextBox
    Public WithEvents edtNetworkMaxUsers As System.Windows.Forms.TextBox
    Public WithEvents Label16 As System.Windows.Forms.Label
    Public WithEvents Label17 As System.Windows.Forms.Label
    Public WithEvents grbDirectASFStreaming As System.Windows.Forms.GroupBox
    Public WithEvents edtPublishingPoint As System.Windows.Forms.TextBox
    Public WithEvents Label18 As System.Windows.Forms.Label
    Public WithEvents grbASFStreamingToWMServer As System.Windows.Forms.GroupBox
    Public WithEvents chkASFFixedFrameRate As System.Windows.Forms.CheckBox
    Public WithEvents cmbASFDeinterlaceMode As System.Windows.Forms.ComboBox
    Public WithEvents edtASFVideoWidth As System.Windows.Forms.TextBox
    Public WithEvents edtASFVideoBitRate As System.Windows.Forms.TextBox
    Public WithEvents edtASFVideoQuality As System.Windows.Forms.TextBox
    Public WithEvents edtASFVideoMaxKeyFrameSpacing As System.Windows.Forms.TextBox
    Public WithEvents edtASFAudioChannels As System.Windows.Forms.TextBox
    Public WithEvents edtASFVideoHeight As System.Windows.Forms.TextBox
    Public WithEvents Label20 As System.Windows.Forms.Label
    Public WithEvents Label21 As System.Windows.Forms.Label
    Public WithEvents Label22 As System.Windows.Forms.Label
    Public WithEvents Label23 As System.Windows.Forms.Label
    Public WithEvents Label24 As System.Windows.Forms.Label
    Public WithEvents Label25 As System.Windows.Forms.Label
    Public WithEvents Label26 As System.Windows.Forms.Label
    Public WithEvents grbASFSettings As System.Windows.Forms.GroupBox
    Public WithEvents lsbProfiles As System.Windows.Forms.ListBox
    Public WithEvents btnShowProfilesList As System.Windows.Forms.Button
    Public WithEvents edtProfileIndex As System.Windows.Forms.TextBox
    Public WithEvents Label27 As System.Windows.Forms.Label
    Public WithEvents grbASFProfiles As System.Windows.Forms.GroupBox
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Friend WithEvents rdgNetworkStreamingTypeAudioVideo As System.Windows.Forms.RadioButton
    Friend WithEvents rdgNetworkStreamingTypeVideo As System.Windows.Forms.RadioButton
    Friend WithEvents rdgNetworkStreamingTypeAudio As System.Windows.Forms.RadioButton
    Friend WithEvents rdgNetworkStreamingType As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents edtPublishingPointUsername As System.Windows.Forms.TextBox
    Friend WithEvents edtPublishingPointPassword As System.Windows.Forms.TextBox
    Public WithEvents rdgNetworkStreamingDisabled As System.Windows.Forms.RadioButton
    Public WithEvents rdgNetworkStreamingDirect As System.Windows.Forms.RadioButton
    Public WithEvents rdgNetworkStreamingPublishingPoint As System.Windows.Forms.RadioButton
    Public WithEvents grbWMV9profiles As System.Windows.Forms.GroupBox
    Friend WithEvents btnSelectWMV9Profile As System.Windows.Forms.Button
    Friend WithEvents edtWMV9profile As System.Windows.Forms.TextBox
    Public WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents grbWMVversion As System.Windows.Forms.GroupBox
    Friend WithEvents rdgWMV9 As System.Windows.Forms.RadioButton
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents rgdWMV8 As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NetworkStreaming))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.rdgNetworkStreaming = New System.Windows.Forms.GroupBox
        Me.btnViewDirectNetworkStreaming = New System.Windows.Forms.Button
        Me.rdgNetworkStreamingDisabled = New System.Windows.Forms.RadioButton
        Me.rdgNetworkStreamingDirect = New System.Windows.Forms.RadioButton
        Me.rdgNetworkStreamingPublishingPoint = New System.Windows.Forms.RadioButton
        Me.grbDirectASFStreaming = New System.Windows.Forms.GroupBox
        Me.edtNetworkPort = New System.Windows.Forms.TextBox
        Me.edtNetworkMaxUsers = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.grbASFStreamingToWMServer = New System.Windows.Forms.GroupBox
        Me.edtPublishingPointPassword = New System.Windows.Forms.TextBox
        Me.edtPublishingPointUsername = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.edtPublishingPoint = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.grbASFSettings = New System.Windows.Forms.GroupBox
        Me.grbWMVversion = New System.Windows.Forms.GroupBox
        Me.rdgWMV9 = New System.Windows.Forms.RadioButton
        Me.rgdWMV8 = New System.Windows.Forms.RadioButton
        Me.Label19 = New System.Windows.Forms.Label
        Me.chkASFFixedFrameRate = New System.Windows.Forms.CheckBox
        Me.cmbASFDeinterlaceMode = New System.Windows.Forms.ComboBox
        Me.edtASFVideoWidth = New System.Windows.Forms.TextBox
        Me.edtASFVideoBitRate = New System.Windows.Forms.TextBox
        Me.edtASFVideoQuality = New System.Windows.Forms.TextBox
        Me.edtASFVideoMaxKeyFrameSpacing = New System.Windows.Forms.TextBox
        Me.edtASFAudioChannels = New System.Windows.Forms.TextBox
        Me.edtASFVideoHeight = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.grbASFProfiles = New System.Windows.Forms.GroupBox
        Me.lsbProfiles = New System.Windows.Forms.ListBox
        Me.btnShowProfilesList = New System.Windows.Forms.Button
        Me.edtProfileIndex = New System.Windows.Forms.TextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.rdgNetworkStreamingType = New System.Windows.Forms.GroupBox
        Me.rdgNetworkStreamingTypeAudio = New System.Windows.Forms.RadioButton
        Me.rdgNetworkStreamingTypeVideo = New System.Windows.Forms.RadioButton
        Me.rdgNetworkStreamingTypeAudioVideo = New System.Windows.Forms.RadioButton
        Me.grbWMV9profiles = New System.Windows.Forms.GroupBox
        Me.btnSelectWMV9Profile = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.edtWMV9profile = New System.Windows.Forms.TextBox
        Me.rdgNetworkStreaming.SuspendLayout()
        Me.grbDirectASFStreaming.SuspendLayout()
        Me.grbASFStreamingToWMServer.SuspendLayout()
        Me.grbASFSettings.SuspendLayout()
        Me.grbWMVversion.SuspendLayout()
        Me.grbASFProfiles.SuspendLayout()
        Me.rdgNetworkStreamingType.SuspendLayout()
        Me.grbWMV9profiles.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdgNetworkStreaming
        '
        Me.rdgNetworkStreaming.BackColor = System.Drawing.SystemColors.Control
        Me.rdgNetworkStreaming.Controls.Add(Me.btnViewDirectNetworkStreaming)
        Me.rdgNetworkStreaming.Controls.Add(Me.rdgNetworkStreamingDisabled)
        Me.rdgNetworkStreaming.Controls.Add(Me.rdgNetworkStreamingDirect)
        Me.rdgNetworkStreaming.Controls.Add(Me.rdgNetworkStreamingPublishingPoint)
        Me.rdgNetworkStreaming.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgNetworkStreaming.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgNetworkStreaming.Location = New System.Drawing.Point(4, 0)
        Me.rdgNetworkStreaming.Name = "rdgNetworkStreaming"
        Me.rdgNetworkStreaming.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgNetworkStreaming.Size = New System.Drawing.Size(193, 76)
        Me.rdgNetworkStreaming.TabIndex = 29
        Me.rdgNetworkStreaming.TabStop = False
        Me.rdgNetworkStreaming.Text = "Network streaming"
        '
        'btnViewDirectNetworkStreaming
        '
        Me.btnViewDirectNetworkStreaming.BackColor = System.Drawing.SystemColors.Control
        Me.btnViewDirectNetworkStreaming.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnViewDirectNetworkStreaming.Enabled = False
        Me.btnViewDirectNetworkStreaming.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewDirectNetworkStreaming.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnViewDirectNetworkStreaming.Location = New System.Drawing.Point(148, 28)
        Me.btnViewDirectNetworkStreaming.Name = "btnViewDirectNetworkStreaming"
        Me.btnViewDirectNetworkStreaming.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnViewDirectNetworkStreaming.Size = New System.Drawing.Size(39, 22)
        Me.btnViewDirectNetworkStreaming.TabIndex = 30
        Me.btnViewDirectNetworkStreaming.Text = "view"
        '
        'rdgNetworkStreamingDisabled
        '
        Me.rdgNetworkStreamingDisabled.BackColor = System.Drawing.SystemColors.Control
        Me.rdgNetworkStreamingDisabled.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgNetworkStreamingDisabled.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgNetworkStreamingDisabled.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgNetworkStreamingDisabled.Location = New System.Drawing.Point(6, 16)
        Me.rdgNetworkStreamingDisabled.Name = "rdgNetworkStreamingDisabled"
        Me.rdgNetworkStreamingDisabled.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgNetworkStreamingDisabled.Size = New System.Drawing.Size(104, 17)
        Me.rdgNetworkStreamingDisabled.TabIndex = 33
        Me.rdgNetworkStreamingDisabled.TabStop = True
        Me.rdgNetworkStreamingDisabled.Tag = "0"
        Me.rdgNetworkStreamingDisabled.Text = "disabled"
        '
        'rdgNetworkStreamingDirect
        '
        Me.rdgNetworkStreamingDirect.BackColor = System.Drawing.SystemColors.Control
        Me.rdgNetworkStreamingDirect.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgNetworkStreamingDirect.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgNetworkStreamingDirect.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgNetworkStreamingDirect.Location = New System.Drawing.Point(6, 34)
        Me.rdgNetworkStreamingDirect.Name = "rdgNetworkStreamingDirect"
        Me.rdgNetworkStreamingDirect.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgNetworkStreamingDirect.Size = New System.Drawing.Size(147, 18)
        Me.rdgNetworkStreamingDirect.TabIndex = 32
        Me.rdgNetworkStreamingDirect.TabStop = True
        Me.rdgNetworkStreamingDirect.Tag = "1"
        Me.rdgNetworkStreamingDirect.Text = "direct network streaming"
        '
        'rdgNetworkStreamingPublishingPoint
        '
        Me.rdgNetworkStreamingPublishingPoint.BackColor = System.Drawing.SystemColors.Control
        Me.rdgNetworkStreamingPublishingPoint.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgNetworkStreamingPublishingPoint.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgNetworkStreamingPublishingPoint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgNetworkStreamingPublishingPoint.Location = New System.Drawing.Point(6, 52)
        Me.rdgNetworkStreamingPublishingPoint.Name = "rdgNetworkStreamingPublishingPoint"
        Me.rdgNetworkStreamingPublishingPoint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgNetworkStreamingPublishingPoint.Size = New System.Drawing.Size(179, 17)
        Me.rdgNetworkStreamingPublishingPoint.TabIndex = 31
        Me.rdgNetworkStreamingPublishingPoint.TabStop = True
        Me.rdgNetworkStreamingPublishingPoint.Tag = "2"
        Me.rdgNetworkStreamingPublishingPoint.Text = "stream to a WM publishing point"
        '
        'grbDirectASFStreaming
        '
        Me.grbDirectASFStreaming.BackColor = System.Drawing.SystemColors.Control
        Me.grbDirectASFStreaming.Controls.Add(Me.edtNetworkPort)
        Me.grbDirectASFStreaming.Controls.Add(Me.edtNetworkMaxUsers)
        Me.grbDirectASFStreaming.Controls.Add(Me.Label16)
        Me.grbDirectASFStreaming.Controls.Add(Me.Label17)
        Me.grbDirectASFStreaming.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbDirectASFStreaming.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grbDirectASFStreaming.Location = New System.Drawing.Point(4, 80)
        Me.grbDirectASFStreaming.Name = "grbDirectASFStreaming"
        Me.grbDirectASFStreaming.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grbDirectASFStreaming.Size = New System.Drawing.Size(297, 52)
        Me.grbDirectASFStreaming.TabIndex = 24
        Me.grbDirectASFStreaming.TabStop = False
        Me.grbDirectASFStreaming.Text = "direct ASF network streaming"
        '
        'edtNetworkPort
        '
        Me.edtNetworkPort.AcceptsReturn = True
        Me.edtNetworkPort.BackColor = System.Drawing.SystemColors.Window
        Me.edtNetworkPort.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtNetworkPort.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtNetworkPort.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtNetworkPort.Location = New System.Drawing.Point(120, 24)
        Me.edtNetworkPort.MaxLength = 0
        Me.edtNetworkPort.Name = "edtNetworkPort"
        Me.edtNetworkPort.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtNetworkPort.Size = New System.Drawing.Size(41, 20)
        Me.edtNetworkPort.TabIndex = 26
        Me.edtNetworkPort.Text = "0"
        '
        'edtNetworkMaxUsers
        '
        Me.edtNetworkMaxUsers.AcceptsReturn = True
        Me.edtNetworkMaxUsers.BackColor = System.Drawing.SystemColors.Window
        Me.edtNetworkMaxUsers.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtNetworkMaxUsers.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtNetworkMaxUsers.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtNetworkMaxUsers.Location = New System.Drawing.Point(232, 24)
        Me.edtNetworkMaxUsers.MaxLength = 0
        Me.edtNetworkMaxUsers.Name = "edtNetworkMaxUsers"
        Me.edtNetworkMaxUsers.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtNetworkMaxUsers.Size = New System.Drawing.Size(56, 20)
        Me.edtNetworkMaxUsers.TabIndex = 25
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.SystemColors.Control
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(8, 24)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(111, 14)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "Port (0 = auto select):"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.SystemColors.Control
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label17.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(176, 24)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(61, 14)
        Me.Label17.TabIndex = 27
        Me.Label17.Text = "Max users:"
        '
        'grbASFStreamingToWMServer
        '
        Me.grbASFStreamingToWMServer.BackColor = System.Drawing.SystemColors.Control
        Me.grbASFStreamingToWMServer.Controls.Add(Me.edtPublishingPointPassword)
        Me.grbASFStreamingToWMServer.Controls.Add(Me.edtPublishingPointUsername)
        Me.grbASFStreamingToWMServer.Controls.Add(Me.Label2)
        Me.grbASFStreamingToWMServer.Controls.Add(Me.Label1)
        Me.grbASFStreamingToWMServer.Controls.Add(Me.edtPublishingPoint)
        Me.grbASFStreamingToWMServer.Controls.Add(Me.Label18)
        Me.grbASFStreamingToWMServer.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbASFStreamingToWMServer.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grbASFStreamingToWMServer.Location = New System.Drawing.Point(4, 134)
        Me.grbASFStreamingToWMServer.Name = "grbASFStreamingToWMServer"
        Me.grbASFStreamingToWMServer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grbASFStreamingToWMServer.Size = New System.Drawing.Size(673, 43)
        Me.grbASFStreamingToWMServer.TabIndex = 21
        Me.grbASFStreamingToWMServer.TabStop = False
        Me.grbASFStreamingToWMServer.Text = "stream to a WM publishing point with authentication: (e.g. http://myserver.com:80" & _
            "80/mypublishingpoint)"
        '
        'edtPublishingPointPassword
        '
        Me.edtPublishingPointPassword.Location = New System.Drawing.Point(590, 16)
        Me.edtPublishingPointPassword.Name = "edtPublishingPointPassword"
        Me.edtPublishingPointPassword.Size = New System.Drawing.Size(74, 20)
        Me.edtPublishingPointPassword.TabIndex = 27
        '
        'edtPublishingPointUsername
        '
        Me.edtPublishingPointUsername.Location = New System.Drawing.Point(442, 16)
        Me.edtPublishingPointUsername.Name = "edtPublishingPointUsername"
        Me.edtPublishingPointUsername.Size = New System.Drawing.Size(74, 20)
        Me.edtPublishingPointUsername.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(530, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 14)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "password:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(384, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 14)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "username:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'edtPublishingPoint
        '
        Me.edtPublishingPoint.AcceptsReturn = True
        Me.edtPublishingPoint.BackColor = System.Drawing.SystemColors.Window
        Me.edtPublishingPoint.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtPublishingPoint.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtPublishingPoint.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtPublishingPoint.Location = New System.Drawing.Point(99, 16)
        Me.edtPublishingPoint.MaxLength = 0
        Me.edtPublishingPoint.Name = "edtPublishingPoint"
        Me.edtPublishingPoint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtPublishingPoint.Size = New System.Drawing.Size(273, 20)
        Me.edtPublishingPoint.TabIndex = 22
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.SystemColors.Control
        Me.Label18.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label18.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(18, 19)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label18.Size = New System.Drawing.Size(81, 14)
        Me.Label18.TabIndex = 23
        Me.Label18.Text = "publishing URL:"
        '
        'grbASFSettings
        '
        Me.grbASFSettings.BackColor = System.Drawing.SystemColors.Control
        Me.grbASFSettings.Controls.Add(Me.grbWMVversion)
        Me.grbASFSettings.Controls.Add(Me.Label19)
        Me.grbASFSettings.Controls.Add(Me.chkASFFixedFrameRate)
        Me.grbASFSettings.Controls.Add(Me.cmbASFDeinterlaceMode)
        Me.grbASFSettings.Controls.Add(Me.edtASFVideoWidth)
        Me.grbASFSettings.Controls.Add(Me.edtASFVideoBitRate)
        Me.grbASFSettings.Controls.Add(Me.edtASFVideoQuality)
        Me.grbASFSettings.Controls.Add(Me.edtASFVideoMaxKeyFrameSpacing)
        Me.grbASFSettings.Controls.Add(Me.edtASFAudioChannels)
        Me.grbASFSettings.Controls.Add(Me.edtASFVideoHeight)
        Me.grbASFSettings.Controls.Add(Me.Label20)
        Me.grbASFSettings.Controls.Add(Me.Label21)
        Me.grbASFSettings.Controls.Add(Me.Label22)
        Me.grbASFSettings.Controls.Add(Me.Label23)
        Me.grbASFSettings.Controls.Add(Me.Label24)
        Me.grbASFSettings.Controls.Add(Me.Label25)
        Me.grbASFSettings.Controls.Add(Me.Label26)
        Me.grbASFSettings.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbASFSettings.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grbASFSettings.Location = New System.Drawing.Point(307, 0)
        Me.grbASFSettings.Name = "grbASFSettings"
        Me.grbASFSettings.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grbASFSettings.Size = New System.Drawing.Size(369, 132)
        Me.grbASFSettings.TabIndex = 4
        Me.grbASFSettings.TabStop = False
        Me.grbASFSettings.Text = "WMV settings"
        '
        'grbWMVversion
        '
        Me.grbWMVversion.Controls.Add(Me.rdgWMV9)
        Me.grbWMVversion.Controls.Add(Me.rgdWMV8)
        Me.grbWMVversion.Location = New System.Drawing.Point(131, 26)
        Me.grbWMVversion.Name = "grbWMVversion"
        Me.grbWMVversion.Size = New System.Drawing.Size(80, 60)
        Me.grbWMVversion.TabIndex = 22
        Me.grbWMVversion.TabStop = False
        Me.grbWMVversion.Text = "WMV version"
        '
        'rdgWMV9
        '
        Me.rdgWMV9.Location = New System.Drawing.Point(8, 34)
        Me.rdgWMV9.Name = "rdgWMV9"
        Me.rdgWMV9.Size = New System.Drawing.Size(64, 16)
        Me.rdgWMV9.TabIndex = 1
        Me.rdgWMV9.Text = "WMV 9"
        '
        'rgdWMV8
        '
        Me.rgdWMV8.Location = New System.Drawing.Point(8, 16)
        Me.rgdWMV8.Name = "rgdWMV8"
        Me.rgdWMV8.Size = New System.Drawing.Size(64, 16)
        Me.rgdWMV8.TabIndex = 0
        Me.rgdWMV8.Text = "WMV 8"
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.SystemColors.Control
        Me.Label19.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label19.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label19.Location = New System.Drawing.Point(128, 8)
        Me.Label19.Name = "Label19"
        Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label19.Size = New System.Drawing.Size(168, 17)
        Me.Label19.TabIndex = 21
        Me.Label19.Text = "(-1 = use default or profile value)"
        '
        'chkASFFixedFrameRate
        '
        Me.chkASFFixedFrameRate.BackColor = System.Drawing.SystemColors.Control
        Me.chkASFFixedFrameRate.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkASFFixedFrameRate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkASFFixedFrameRate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkASFFixedFrameRate.Location = New System.Drawing.Point(17, 72)
        Me.chkASFFixedFrameRate.Name = "chkASFFixedFrameRate"
        Me.chkASFFixedFrameRate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkASFFixedFrameRate.Size = New System.Drawing.Size(104, 17)
        Me.chkASFFixedFrameRate.TabIndex = 12
        Me.chkASFFixedFrameRate.Text = "fixed frame rate"
        '
        'cmbASFDeinterlaceMode
        '
        Me.cmbASFDeinterlaceMode.BackColor = System.Drawing.SystemColors.Window
        Me.cmbASFDeinterlaceMode.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbASFDeinterlaceMode.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbASFDeinterlaceMode.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbASFDeinterlaceMode.Items.AddRange(New Object() {"adm_NotInterlaced", "adm_DeinterlaceNormal", "adm_DeinterlaceHalfSize", "adm_DeinterlaceHalfSizeDoubleRate", "adm_DeinterlaceInverseTelecine", "adm_DeinterlaceVerticalHalfSizeDoubleRate"})
        Me.cmbASFDeinterlaceMode.Location = New System.Drawing.Point(17, 103)
        Me.cmbASFDeinterlaceMode.Name = "cmbASFDeinterlaceMode"
        Me.cmbASFDeinterlaceMode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbASFDeinterlaceMode.Size = New System.Drawing.Size(209, 22)
        Me.cmbASFDeinterlaceMode.TabIndex = 11
        '
        'edtASFVideoWidth
        '
        Me.edtASFVideoWidth.AcceptsReturn = True
        Me.edtASFVideoWidth.BackColor = System.Drawing.SystemColors.Window
        Me.edtASFVideoWidth.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtASFVideoWidth.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtASFVideoWidth.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtASFVideoWidth.Location = New System.Drawing.Point(88, 24)
        Me.edtASFVideoWidth.MaxLength = 0
        Me.edtASFVideoWidth.Name = "edtASFVideoWidth"
        Me.edtASFVideoWidth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtASFVideoWidth.Size = New System.Drawing.Size(33, 20)
        Me.edtASFVideoWidth.TabIndex = 10
        '
        'edtASFVideoBitRate
        '
        Me.edtASFVideoBitRate.AcceptsReturn = True
        Me.edtASFVideoBitRate.BackColor = System.Drawing.SystemColors.Window
        Me.edtASFVideoBitRate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtASFVideoBitRate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtASFVideoBitRate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtASFVideoBitRate.Location = New System.Drawing.Point(322, 19)
        Me.edtASFVideoBitRate.MaxLength = 0
        Me.edtASFVideoBitRate.Name = "edtASFVideoBitRate"
        Me.edtASFVideoBitRate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtASFVideoBitRate.Size = New System.Drawing.Size(39, 20)
        Me.edtASFVideoBitRate.TabIndex = 9
        '
        'edtASFVideoQuality
        '
        Me.edtASFVideoQuality.AcceptsReturn = True
        Me.edtASFVideoQuality.BackColor = System.Drawing.SystemColors.Window
        Me.edtASFVideoQuality.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtASFVideoQuality.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtASFVideoQuality.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtASFVideoQuality.Location = New System.Drawing.Point(322, 43)
        Me.edtASFVideoQuality.MaxLength = 0
        Me.edtASFVideoQuality.Name = "edtASFVideoQuality"
        Me.edtASFVideoQuality.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtASFVideoQuality.Size = New System.Drawing.Size(39, 20)
        Me.edtASFVideoQuality.TabIndex = 8
        '
        'edtASFVideoMaxKeyFrameSpacing
        '
        Me.edtASFVideoMaxKeyFrameSpacing.AcceptsReturn = True
        Me.edtASFVideoMaxKeyFrameSpacing.BackColor = System.Drawing.SystemColors.Window
        Me.edtASFVideoMaxKeyFrameSpacing.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtASFVideoMaxKeyFrameSpacing.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtASFVideoMaxKeyFrameSpacing.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtASFVideoMaxKeyFrameSpacing.Location = New System.Drawing.Point(322, 67)
        Me.edtASFVideoMaxKeyFrameSpacing.MaxLength = 0
        Me.edtASFVideoMaxKeyFrameSpacing.Name = "edtASFVideoMaxKeyFrameSpacing"
        Me.edtASFVideoMaxKeyFrameSpacing.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtASFVideoMaxKeyFrameSpacing.Size = New System.Drawing.Size(39, 20)
        Me.edtASFVideoMaxKeyFrameSpacing.TabIndex = 7
        '
        'edtASFAudioChannels
        '
        Me.edtASFAudioChannels.AcceptsReturn = True
        Me.edtASFAudioChannels.BackColor = System.Drawing.SystemColors.Window
        Me.edtASFAudioChannels.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtASFAudioChannels.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtASFAudioChannels.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtASFAudioChannels.Location = New System.Drawing.Point(322, 91)
        Me.edtASFAudioChannels.MaxLength = 0
        Me.edtASFAudioChannels.Name = "edtASFAudioChannels"
        Me.edtASFAudioChannels.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtASFAudioChannels.Size = New System.Drawing.Size(39, 20)
        Me.edtASFAudioChannels.TabIndex = 6
        '
        'edtASFVideoHeight
        '
        Me.edtASFVideoHeight.AcceptsReturn = True
        Me.edtASFVideoHeight.BackColor = System.Drawing.SystemColors.Window
        Me.edtASFVideoHeight.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtASFVideoHeight.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtASFVideoHeight.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtASFVideoHeight.Location = New System.Drawing.Point(88, 50)
        Me.edtASFVideoHeight.MaxLength = 0
        Me.edtASFVideoHeight.Name = "edtASFVideoHeight"
        Me.edtASFVideoHeight.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtASFVideoHeight.Size = New System.Drawing.Size(33, 20)
        Me.edtASFVideoHeight.TabIndex = 5
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.SystemColors.Control
        Me.Label20.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label20.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(19, 26)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label20.Size = New System.Drawing.Size(66, 14)
        Me.Label20.TabIndex = 19
        Me.Label20.Text = "video width:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.SystemColors.Control
        Me.Label21.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label21.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(252, 24)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label21.Size = New System.Drawing.Size(72, 14)
        Me.Label21.TabIndex = 18
        Me.Label21.Text = "video bit rate:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.SystemColors.Control
        Me.Label22.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label22.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Location = New System.Drawing.Point(17, 52)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label22.Size = New System.Drawing.Size(68, 14)
        Me.Label22.TabIndex = 17
        Me.Label22.Text = "video height:"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.SystemColors.Control
        Me.Label23.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label23.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(254, 49)
        Me.Label23.Name = "Label23"
        Me.Label23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label23.Size = New System.Drawing.Size(70, 14)
        Me.Label23.TabIndex = 16
        Me.Label23.Text = "video quality:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.SystemColors.Control
        Me.Label24.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label24.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label24.Location = New System.Drawing.Point(225, 72)
        Me.Label24.Name = "Label24"
        Me.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label24.Size = New System.Drawing.Size(99, 14)
        Me.Label24.TabIndex = 15
        Me.Label24.Text = "key frame spacing:"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.SystemColors.Control
        Me.Label25.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label25.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label25.Location = New System.Drawing.Point(241, 95)
        Me.Label25.Name = "Label25"
        Me.Label25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label25.Size = New System.Drawing.Size(83, 14)
        Me.Label25.TabIndex = 14
        Me.Label25.Text = "audio channels:"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.SystemColors.Control
        Me.Label26.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label26.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label26.Location = New System.Drawing.Point(14, 90)
        Me.Label26.Name = "Label26"
        Me.Label26.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label26.Size = New System.Drawing.Size(92, 14)
        Me.Label26.TabIndex = 13
        Me.Label26.Text = "deinterlace mode:"
        '
        'grbASFProfiles
        '
        Me.grbASFProfiles.BackColor = System.Drawing.SystemColors.Control
        Me.grbASFProfiles.Controls.Add(Me.lsbProfiles)
        Me.grbASFProfiles.Controls.Add(Me.btnShowProfilesList)
        Me.grbASFProfiles.Controls.Add(Me.edtProfileIndex)
        Me.grbASFProfiles.Controls.Add(Me.Label27)
        Me.grbASFProfiles.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbASFProfiles.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grbASFProfiles.Location = New System.Drawing.Point(682, 52)
        Me.grbASFProfiles.Name = "grbASFProfiles"
        Me.grbASFProfiles.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grbASFProfiles.Size = New System.Drawing.Size(232, 125)
        Me.grbASFProfiles.TabIndex = 0
        Me.grbASFProfiles.TabStop = False
        Me.grbASFProfiles.Text = "WMV 8 Profiles"
        '
        'lsbProfiles
        '
        Me.lsbProfiles.BackColor = System.Drawing.SystemColors.Window
        Me.lsbProfiles.Cursor = System.Windows.Forms.Cursors.Default
        Me.lsbProfiles.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsbProfiles.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lsbProfiles.ItemHeight = 14
        Me.lsbProfiles.Location = New System.Drawing.Point(8, 58)
        Me.lsbProfiles.Name = "lsbProfiles"
        Me.lsbProfiles.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lsbProfiles.Size = New System.Drawing.Size(218, 60)
        Me.lsbProfiles.TabIndex = 34
        '
        'btnShowProfilesList
        '
        Me.btnShowProfilesList.BackColor = System.Drawing.SystemColors.Control
        Me.btnShowProfilesList.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnShowProfilesList.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowProfilesList.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnShowProfilesList.Location = New System.Drawing.Point(8, 33)
        Me.btnShowProfilesList.Name = "btnShowProfilesList"
        Me.btnShowProfilesList.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnShowProfilesList.Size = New System.Drawing.Size(187, 21)
        Me.btnShowProfilesList.TabIndex = 2
        Me.btnShowProfilesList.Text = "show WMV 8 profiles list"
        '
        'edtProfileIndex
        '
        Me.edtProfileIndex.AcceptsReturn = True
        Me.edtProfileIndex.BackColor = System.Drawing.SystemColors.Window
        Me.edtProfileIndex.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtProfileIndex.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtProfileIndex.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtProfileIndex.Location = New System.Drawing.Point(201, 14)
        Me.edtProfileIndex.MaxLength = 0
        Me.edtProfileIndex.Name = "edtProfileIndex"
        Me.edtProfileIndex.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtProfileIndex.Size = New System.Drawing.Size(25, 20)
        Me.edtProfileIndex.TabIndex = 1
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.SystemColors.Control
        Me.Label27.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label27.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label27.Location = New System.Drawing.Point(8, 16)
        Me.Label27.Name = "Label27"
        Me.Label27.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label27.Size = New System.Drawing.Size(193, 14)
        Me.Label27.TabIndex = 3
        Me.Label27.Text = "index of current profile: (-1 = disabled)"
        '
        'rdgNetworkStreamingType
        '
        Me.rdgNetworkStreamingType.Controls.Add(Me.rdgNetworkStreamingTypeAudio)
        Me.rdgNetworkStreamingType.Controls.Add(Me.rdgNetworkStreamingTypeVideo)
        Me.rdgNetworkStreamingType.Controls.Add(Me.rdgNetworkStreamingTypeAudioVideo)
        Me.rdgNetworkStreamingType.Location = New System.Drawing.Point(204, 0)
        Me.rdgNetworkStreamingType.Name = "rdgNetworkStreamingType"
        Me.rdgNetworkStreamingType.Size = New System.Drawing.Size(97, 76)
        Me.rdgNetworkStreamingType.TabIndex = 30
        Me.rdgNetworkStreamingType.TabStop = False
        Me.rdgNetworkStreamingType.Text = "streaming type"
        '
        'rdgNetworkStreamingTypeAudio
        '
        Me.rdgNetworkStreamingTypeAudio.Location = New System.Drawing.Point(6, 52)
        Me.rdgNetworkStreamingTypeAudio.Name = "rdgNetworkStreamingTypeAudio"
        Me.rdgNetworkStreamingTypeAudio.Size = New System.Drawing.Size(87, 17)
        Me.rdgNetworkStreamingTypeAudio.TabIndex = 2
        Me.rdgNetworkStreamingTypeAudio.Tag = "2"
        Me.rdgNetworkStreamingTypeAudio.Text = "Audio ONLY"
        '
        'rdgNetworkStreamingTypeVideo
        '
        Me.rdgNetworkStreamingTypeVideo.Location = New System.Drawing.Point(6, 34)
        Me.rdgNetworkStreamingTypeVideo.Name = "rdgNetworkStreamingTypeVideo"
        Me.rdgNetworkStreamingTypeVideo.Size = New System.Drawing.Size(87, 17)
        Me.rdgNetworkStreamingTypeVideo.TabIndex = 1
        Me.rdgNetworkStreamingTypeVideo.Tag = "1"
        Me.rdgNetworkStreamingTypeVideo.Text = "Video ONLY"
        '
        'rdgNetworkStreamingTypeAudioVideo
        '
        Me.rdgNetworkStreamingTypeAudioVideo.Location = New System.Drawing.Point(6, 16)
        Me.rdgNetworkStreamingTypeAudioVideo.Name = "rdgNetworkStreamingTypeAudioVideo"
        Me.rdgNetworkStreamingTypeAudioVideo.Size = New System.Drawing.Size(87, 17)
        Me.rdgNetworkStreamingTypeAudioVideo.TabIndex = 0
        Me.rdgNetworkStreamingTypeAudioVideo.Tag = "0"
        Me.rdgNetworkStreamingTypeAudioVideo.Text = "Audio Video"
        '
        'grbWMV9profiles
        '
        Me.grbWMV9profiles.BackColor = System.Drawing.SystemColors.Control
        Me.grbWMV9profiles.Controls.Add(Me.btnSelectWMV9Profile)
        Me.grbWMV9profiles.Controls.Add(Me.edtWMV9profile)
        Me.grbWMV9profiles.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbWMV9profiles.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grbWMV9profiles.Location = New System.Drawing.Point(682, 0)
        Me.grbWMV9profiles.Name = "grbWMV9profiles"
        Me.grbWMV9profiles.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grbWMV9profiles.Size = New System.Drawing.Size(232, 49)
        Me.grbWMV9profiles.TabIndex = 38
        Me.grbWMV9profiles.TabStop = False
        Me.grbWMV9profiles.Text = "WMV 9 profiles"
        '
        'btnSelectWMV9Profile
        '
        Me.btnSelectWMV9Profile.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectWMV9Profile.ImageIndex = 0 '"OpenFolder.bmp"
        Me.btnSelectWMV9Profile.ImageList = Me.ImageList1
        Me.btnSelectWMV9Profile.Location = New System.Drawing.Point(8, 16)
        Me.btnSelectWMV9Profile.Name = "btnSelectWMV9Profile"
        Me.btnSelectWMV9Profile.Size = New System.Drawing.Size(45, 22)
        Me.btnSelectWMV9Profile.TabIndex = 1
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Fuchsia
        '
        'edtWMV9profile
        '
        Me.edtWMV9profile.Location = New System.Drawing.Point(59, 16)
        Me.edtWMV9profile.Name = "edtWMV9profile"
        Me.edtWMV9profile.Size = New System.Drawing.Size(167, 20)
        Me.edtWMV9profile.TabIndex = 0
        Me.edtWMV9profile.Text = "<- select a WMV9 profile..."
        '
        'NetworkStreaming
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(947, 210)
        Me.ControlBox = False
        Me.Controls.Add(Me.grbWMV9profiles)
        Me.Controls.Add(Me.rdgNetworkStreamingType)
        Me.Controls.Add(Me.rdgNetworkStreaming)
        Me.Controls.Add(Me.grbASFSettings)
        Me.Controls.Add(Me.grbASFProfiles)
        Me.Controls.Add(Me.grbDirectASFStreaming)
        Me.Controls.Add(Me.grbASFStreamingToWMServer)
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(4, 23)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NetworkStreaming"
        Me.ShowInTaskbar = False
        Me.rdgNetworkStreaming.ResumeLayout(False)
        Me.grbDirectASFStreaming.ResumeLayout(False)
        Me.grbDirectASFStreaming.PerformLayout()
        Me.grbASFStreamingToWMServer.ResumeLayout(False)
        Me.grbASFStreamingToWMServer.PerformLayout()
        Me.grbASFSettings.ResumeLayout(False)
        Me.grbASFSettings.PerformLayout()
        Me.grbWMVversion.ResumeLayout(False)
        Me.grbASFProfiles.ResumeLayout(False)
        Me.grbASFProfiles.PerformLayout()
        Me.rdgNetworkStreamingType.ResumeLayout(False)
        Me.grbWMV9profiles.ResumeLayout(False)
        Me.grbWMV9profiles.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
#End Region

    Public Sub RefreshControls()
        SetRadioButtonInGroupUsingTag((rdgNetworkStreaming), MainForm.DefInstance.AxVideoGrabberNET1.NetworkStreaming)
        SetRadioButtonInGroupUsingTag((rdgNetworkStreamingType), MainForm.DefInstance.AxVideoGrabberNET1.NetworkStreamingType)

        If MainForm.DefInstance.AxVideoGrabberNET1.ASFProfileVersion = vidgrab_NET.TxASFProfileVersion.apv_ProfileVersion_8 Then
            rgdWMV8.Checked = True
        End If
        If MainForm.DefInstance.AxVideoGrabberNET1.ASFProfileVersion = vidgrab_NET.TxASFProfileVersion.apv_ProfileVersion_9 Then
            rdgWMV9.Checked = True
        End If

        If MainForm.DefInstance.AxVideoGrabberNET1.ASFProfileFromCustomFile <> "" Then
            edtWMV9profile.Text = MainForm.DefInstance.AxVideoGrabberNET1.ASFProfileFromCustomFile
        End If

        edtPublishingPoint.Text = MainForm.DefInstance.AxVideoGrabberNET1.ASFMediaServerPublishingPoint
        edtNetworkPort.Text = MainForm.DefInstance.AxVideoGrabberNET1.ASFNetworkPort
        edtNetworkMaxUsers.Text = MainForm.DefInstance.AxVideoGrabberNET1.ASFNetworkMaxUsers

        edtASFVideoWidth.Text = MainForm.DefInstance.AxVideoGrabberNET1.ASFVideoWidth
        edtASFVideoHeight.Text = MainForm.DefInstance.AxVideoGrabberNET1.ASFVideoHeight
        edtASFVideoBitRate.Text = MainForm.DefInstance.AxVideoGrabberNET1.ASFVideoBitRate
        edtASFVideoMaxKeyFrameSpacing.Text = MainForm.DefInstance.AxVideoGrabberNET1.ASFVideoMaxKeyFrameSpacing
        edtASFVideoQuality.Text = MainForm.DefInstance.AxVideoGrabberNET1.ASFVideoQuality
        edtASFAudioChannels.Text = MainForm.DefInstance.AxVideoGrabberNET1.ASFAudioChannels
        chkASFFixedFrameRate.Checked = MainForm.DefInstance.AxVideoGrabberNET1.ASFFixedFrameRate
        cmbASFDeinterlaceMode.SelectedIndex = MainForm.DefInstance.AxVideoGrabberNET1.ASFDeinterlaceMode

        edtProfileIndex.Text = MainForm.DefInstance.AxVideoGrabberNET1.ASFProfile
    End Sub
    Private Sub btnShowProfilesList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowProfilesList.Click
        LoadTextBox(lsbProfiles, MainForm.DefInstance.AxVideoGrabberNET1.ASFProfiles)
    End Sub

    Private Sub btnViewDirectNetworkStreaming_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewDirectNetworkStreaming.Click
        Dim SW_SHOW As Int32
        SW_SHOW = 5
        If MainForm.DefInstance.AxVideoGrabberNET1.StreamingURL <> "" Then
            ShellExecute(0, "open", MainForm.DefInstance.AxVideoGrabberNET1.StreamingURL, "", "", SW_SHOW)
        End If
    End Sub

    Private Sub chkASFFixedFrameRate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkASFFixedFrameRate.CheckedChanged
        MainForm.DefInstance.AxVideoGrabberNET1.ASFFixedFrameRate = chkASFFixedFrameRate.Checked
    End Sub

    Private Sub cmbASFDeinterlaceMode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbASFDeinterlaceMode.TextChanged
        MainForm.DefInstance.AxVideoGrabberNET1.ASFDeinterlaceMode = cmbASFDeinterlaceMode.SelectedIndex
    End Sub

    Private Sub edtASFAudioChannels_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtASFAudioChannels.TextChanged
        If IsNumeric(edtASFAudioChannels.Text) Then
            MainForm.DefInstance.AxVideoGrabberNET1.ASFAudioChannels = edtASFAudioChannels.Text
        End If
    End Sub

    Private Sub edtASFVideoBitRate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtASFVideoBitRate.TextChanged
        If IsNumeric(edtASFVideoBitRate.Text) Then
            If CDbl(edtASFVideoBitRate.Text) > 0 Then
                MainForm.DefInstance.AxVideoGrabberNET1.ASFVideoBitRate = edtASFVideoBitRate.Text
            End If
        End If
    End Sub

    Private Sub edtASFVideoHeight_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtASFVideoHeight.TextChanged
        If IsNumeric(edtASFVideoHeight.Text) Then
            If CDbl(edtASFVideoHeight.Text) > 0 Then
                MainForm.DefInstance.AxVideoGrabberNET1.ASFVideoHeight = edtASFVideoHeight.Text
            End If
        End If
    End Sub

    Private Sub edtASFVideoMaxKeyFrameSpacing_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtASFVideoMaxKeyFrameSpacing.TextChanged
        If IsNumeric(edtASFVideoMaxKeyFrameSpacing.Text) Then
            MainForm.DefInstance.AxVideoGrabberNET1.ASFVideoMaxKeyFrameSpacing = edtASFVideoMaxKeyFrameSpacing.Text
        End If
    End Sub

    Private Sub edtASFVideoQuality_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtASFVideoQuality.TextChanged
        If IsNumeric(edtASFVideoQuality.Text) Then
            If CDbl(edtASFVideoQuality.Text) >= 0 Then
                MainForm.DefInstance.AxVideoGrabberNET1.ASFVideoQuality = edtASFVideoQuality.Text
            End If
        End If
    End Sub

    Private Sub edtASFVideoWidth_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtASFVideoWidth.TextChanged
        If IsNumeric(edtASFVideoWidth.Text) Then
            If CDbl(edtASFVideoWidth.Text) > 0 Then
                MainForm.DefInstance.AxVideoGrabberNET1.ASFVideoWidth = edtASFVideoWidth.Text
            End If
        End If
    End Sub

    Private Sub edtNetworkMaxUsers_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtNetworkMaxUsers.TextChanged
        If IsNumeric(edtNetworkMaxUsers.Text) Then
            If CDbl(edtNetworkMaxUsers.Text) > 0 Then
                MainForm.DefInstance.AxVideoGrabberNET1.ASFNetworkMaxUsers = edtNetworkMaxUsers.Text
            End If
        End If
    End Sub

    Private Sub edtNetworkPort_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtNetworkPort.TextChanged
        If IsNumeric(edtNetworkPort.Text) Then
            If CDbl(edtNetworkPort.Text) >= 0 Then
                MainForm.DefInstance.AxVideoGrabberNET1.ASFNetworkPort = edtNetworkPort.Text
            End If
        End If
    End Sub

    Private Sub edtProfileIndex_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtProfileIndex.TextChanged
        If IsNumeric(edtProfileIndex.Text) Then
            MainForm.DefInstance.AxVideoGrabberNET1.ASFProfile = edtProfileIndex.Text
        End If
    End Sub

    Private Sub edtPublishingPoint_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtPublishingPoint.TextChanged
        MainForm.DefInstance.AxVideoGrabberNET1.ASFMediaServerPublishingPoint = edtPublishingPoint.Text
    End Sub

    Private Sub edtPublishingPointUsername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtPublishingPointUsername.TextChanged
        MainForm.DefInstance.AxVideoGrabberNET1.SetAuthentication(vidgrab_NET.TxAuthenticationType.at_PublishingPoint, edtPublishingPointUsername.Text, edtPublishingPointPassword.Text)
    End Sub

    Private Sub edtPublishingPointPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtPublishingPointPassword.TextChanged
        MainForm.DefInstance.AxVideoGrabberNET1.SetAuthentication(vidgrab_NET.TxAuthenticationType.at_PublishingPoint, edtPublishingPointUsername.Text, edtPublishingPointPassword.Text)
    End Sub

    Private Sub lsbProfiles_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsbProfiles.SelectedIndexChanged
        If lsbProfiles.Items.Count > 0 Then
            MainForm.DefInstance.AxVideoGrabberNET1.ASFProfile = lsbProfiles.SelectedIndex
            edtProfileIndex.Text = MainForm.DefInstance.AxVideoGrabberNET1.ASFProfile
        End If
    End Sub

    Private Sub rdgNetworkStreaming_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgNetworkStreamingDisabled.CheckedChanged, rdgNetworkStreamingDirect.CheckedChanged, rdgNetworkStreamingPublishingPoint.CheckedChanged
        If CType(sender, RadioButton).Checked Then
            MainForm.DefInstance.AxVideoGrabberNET1.NetworkStreaming = sender.tag
            btnViewDirectNetworkStreaming.Enabled = MainForm.DefInstance.AxVideoGrabberNET1.NetworkStreaming = vidgrab_NET.TxNetworkStreaming.ns_Disabled
        End If
    End Sub

    Private Sub rdgNetworkStreamingTypeAudioVideo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgNetworkStreamingTypeAudioVideo.CheckedChanged, rdgNetworkStreamingTypeVideo.CheckedChanged, rdgNetworkStreamingTypeAudio.CheckedChanged
        If CType(sender, RadioButton).Checked Then
            MainForm.DefInstance.AxVideoGrabberNET1.NetworkStreamingType = sender.tag
        End If
    End Sub

    Private Sub rgdWMV8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rgdWMV8.CheckedChanged
        MainForm.DefInstance.AxVideoGrabberNET1.ASFProfileVersion = vidgrab_NET.TxASFProfileVersion.apv_ProfileVersion_8
    End Sub

    Private Sub rdgWMV9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgWMV9.CheckedChanged
        MainForm.DefInstance.AxVideoGrabberNET1.ASFProfileVersion = vidgrab_NET.TxASFProfileVersion.apv_ProfileVersion_9
    End Sub

    Private Sub btnSelectWMV9Profile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectWMV9Profile.Click
        If MainForm.DefInstance.AxVideoGrabberNET1.ASFProfileVersion = vidgrab_NET.TxASFProfileVersion.apv_ProfileVersion_9 Then

            Dim dlgOpen As OpenFileDialog = New OpenFileDialog

            dlgOpen.Filter = OPEN_PROFILES
            If dlgOpen.ShowDialog = Windows.Forms.DialogResult.OK Then
                edtWMV9profile.Text = dlgOpen.FileName
            End If
        Else
            MessageBox.Show("select WMV version 9 first", _
                    "DataStead TVideoGrabber VB.NET OCX Demo", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub edtWMV9profile_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtWMV9profile.TextChanged
        If edtWMV9profile.Text <> "<- select a WMV9 profile..." Then
            MainForm.DefInstance.AxVideoGrabberNET1.ASFProfileFromCustomFile = edtWMV9profile.Text
        End If
    End Sub

    Private Sub NetworkStreaming_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        If Visible Then
            RefreshControls()
        End If
    End Sub


End Class
