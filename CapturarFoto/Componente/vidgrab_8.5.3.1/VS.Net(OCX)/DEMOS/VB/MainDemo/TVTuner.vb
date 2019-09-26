Option Strict Off
Option Explicit On
Friend Class TVTuner
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
    Public WithEvents mmoChannelLog As System.Windows.Forms.TextBox
    Public WithEvents edtTVChannel As System.Windows.Forms.TextBox
    Public WithEvents btnSelect As System.Windows.Forms.Button
    Public WithEvents edtChannelFrequency As System.Windows.Forms.TextBox
    Public WithEvents chkEnableFrequencyOverrides As System.Windows.Forms.CheckBox
    Public WithEvents grbFrequencyOverride As System.Windows.Forms.GroupBox
    Public WithEvents grbTVChannel As System.Windows.Forms.GroupBox
    Public WithEvents rdgTunerInputType As System.Windows.Forms.GroupBox
    Public WithEvents edtCountryCode As System.Windows.Forms.TextBox
    Public WithEvents btnSetCountryCode As System.Windows.Forms.Button
    Public WithEvents grbCountryCode As System.Windows.Forms.GroupBox
    Public WithEvents grbTunerCountryCode As System.Windows.Forms.GroupBox
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Public WithEvents btnResetAllOverrides As System.Windows.Forms.Button
    Friend WithEvents rdgTunerMode As System.Windows.Forms.GroupBox
    Friend WithEvents rdgTunerModeDigitalSatellite As System.Windows.Forms.RadioButton
    Friend WithEvents rdgTunerModeAMRadio As System.Windows.Forms.RadioButton
    Friend WithEvents rdgTunerModeFMRadio As System.Windows.Forms.RadioButton
    Friend WithEvents rdgTunerModeTV As System.Windows.Forms.RadioButton
    Public WithEvents rdgTunerInputTypeCable As System.Windows.Forms.RadioButton
    Public WithEvents rdgTunerInputTypeAntenna As System.Windows.Forms.RadioButton
    Public WithEvents btnSetOverride As System.Windows.Forms.Button
    Friend WithEvents lblTVTunerAvailable As System.Windows.Forms.Label
    Public WithEvents grbTVScan As System.Windows.Forms.GroupBox
    Public WithEvents btnStartScan As System.Windows.Forms.Button
    Public WithEvents btnStopScan As System.Windows.Forms.Button
    Friend WithEvents btnTunerDialog As System.Windows.Forms.Button
    Friend WithEvents lblTVTuner As System.Windows.Forms.Label
    Public WithEvents btnDeleteOverride As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.mmoChannelLog = New System.Windows.Forms.TextBox
        Me.grbTVChannel = New System.Windows.Forms.GroupBox
        Me.edtTVChannel = New System.Windows.Forms.TextBox
        Me.btnSelect = New System.Windows.Forms.Button
        Me.grbFrequencyOverride = New System.Windows.Forms.GroupBox
        Me.btnResetAllOverrides = New System.Windows.Forms.Button
        Me.edtChannelFrequency = New System.Windows.Forms.TextBox
        Me.btnSetOverride = New System.Windows.Forms.Button
        Me.btnDeleteOverride = New System.Windows.Forms.Button
        Me.chkEnableFrequencyOverrides = New System.Windows.Forms.CheckBox
        Me.grbTunerCountryCode = New System.Windows.Forms.GroupBox
        Me.lblTVTuner = New System.Windows.Forms.Label
        Me.rdgTunerMode = New System.Windows.Forms.GroupBox
        Me.rdgTunerModeDigitalSatellite = New System.Windows.Forms.RadioButton
        Me.rdgTunerModeAMRadio = New System.Windows.Forms.RadioButton
        Me.rdgTunerModeFMRadio = New System.Windows.Forms.RadioButton
        Me.rdgTunerModeTV = New System.Windows.Forms.RadioButton
        Me.rdgTunerInputType = New System.Windows.Forms.GroupBox
        Me.rdgTunerInputTypeCable = New System.Windows.Forms.RadioButton
        Me.rdgTunerInputTypeAntenna = New System.Windows.Forms.RadioButton
        Me.grbCountryCode = New System.Windows.Forms.GroupBox
        Me.edtCountryCode = New System.Windows.Forms.TextBox
        Me.btnSetCountryCode = New System.Windows.Forms.Button
        Me.lblTVTunerAvailable = New System.Windows.Forms.Label
        Me.grbTVScan = New System.Windows.Forms.GroupBox
        Me.btnStartScan = New System.Windows.Forms.Button
        Me.btnStopScan = New System.Windows.Forms.Button
        Me.btnTunerDialog = New System.Windows.Forms.Button
        Me.grbTVChannel.SuspendLayout()
        Me.grbFrequencyOverride.SuspendLayout()
        Me.grbTunerCountryCode.SuspendLayout()
        Me.rdgTunerMode.SuspendLayout()
        Me.rdgTunerInputType.SuspendLayout()
        Me.grbCountryCode.SuspendLayout()
        Me.grbTVScan.SuspendLayout()
        Me.SuspendLayout()
        '
        'mmoChannelLog
        '
        Me.mmoChannelLog.AcceptsReturn = True
        Me.mmoChannelLog.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.mmoChannelLog.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.mmoChannelLog.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mmoChannelLog.ForeColor = System.Drawing.SystemColors.WindowText
        Me.mmoChannelLog.Location = New System.Drawing.Point(453, 16)
        Me.mmoChannelLog.MaxLength = 0
        Me.mmoChannelLog.Multiline = True
        Me.mmoChannelLog.Name = "mmoChannelLog"
        Me.mmoChannelLog.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.mmoChannelLog.Size = New System.Drawing.Size(456, 161)
        Me.mmoChannelLog.TabIndex = 19
        '
        'grbTVChannel
        '
        Me.grbTVChannel.BackColor = System.Drawing.SystemColors.Control
        Me.grbTVChannel.Controls.Add(Me.edtTVChannel)
        Me.grbTVChannel.Controls.Add(Me.btnSelect)
        Me.grbTVChannel.Controls.Add(Me.grbFrequencyOverride)
        Me.grbTVChannel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbTVChannel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grbTVChannel.Location = New System.Drawing.Point(4, 97)
        Me.grbTVChannel.Name = "grbTVChannel"
        Me.grbTVChannel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grbTVChannel.Size = New System.Drawing.Size(344, 81)
        Me.grbTVChannel.TabIndex = 8
        Me.grbTVChannel.TabStop = False
        Me.grbTVChannel.Text = "TV channel"
        '
        'edtTVChannel
        '
        Me.edtTVChannel.AcceptsReturn = True
        Me.edtTVChannel.BackColor = System.Drawing.SystemColors.Window
        Me.edtTVChannel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtTVChannel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtTVChannel.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtTVChannel.Location = New System.Drawing.Point(10, 27)
        Me.edtTVChannel.MaxLength = 0
        Me.edtTVChannel.Name = "edtTVChannel"
        Me.edtTVChannel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtTVChannel.Size = New System.Drawing.Size(43, 20)
        Me.edtTVChannel.TabIndex = 18
        '
        'btnSelect
        '
        Me.btnSelect.BackColor = System.Drawing.SystemColors.Control
        Me.btnSelect.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSelect.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSelect.Location = New System.Drawing.Point(61, 26)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSelect.Size = New System.Drawing.Size(43, 22)
        Me.btnSelect.TabIndex = 17
        Me.btnSelect.Text = "set"
        '
        'grbFrequencyOverride
        '
        Me.grbFrequencyOverride.BackColor = System.Drawing.SystemColors.Control
        Me.grbFrequencyOverride.Controls.Add(Me.btnResetAllOverrides)
        Me.grbFrequencyOverride.Controls.Add(Me.edtChannelFrequency)
        Me.grbFrequencyOverride.Controls.Add(Me.btnSetOverride)
        Me.grbFrequencyOverride.Controls.Add(Me.btnDeleteOverride)
        Me.grbFrequencyOverride.Controls.Add(Me.chkEnableFrequencyOverrides)
        Me.grbFrequencyOverride.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbFrequencyOverride.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grbFrequencyOverride.Location = New System.Drawing.Point(119, 9)
        Me.grbFrequencyOverride.Name = "grbFrequencyOverride"
        Me.grbFrequencyOverride.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grbFrequencyOverride.Size = New System.Drawing.Size(217, 67)
        Me.grbFrequencyOverride.TabIndex = 12
        Me.grbFrequencyOverride.TabStop = False
        Me.grbFrequencyOverride.Text = "frequency override"
        '
        'btnResetAllOverrides
        '
        Me.btnResetAllOverrides.BackColor = System.Drawing.SystemColors.Control
        Me.btnResetAllOverrides.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnResetAllOverrides.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetAllOverrides.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnResetAllOverrides.Location = New System.Drawing.Point(146, 12)
        Me.btnResetAllOverrides.Name = "btnResetAllOverrides"
        Me.btnResetAllOverrides.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnResetAllOverrides.Size = New System.Drawing.Size(65, 22)
        Me.btnResetAllOverrides.TabIndex = 17
        Me.btnResetAllOverrides.Text = "clear all"
        '
        'edtChannelFrequency
        '
        Me.edtChannelFrequency.AcceptsReturn = True
        Me.edtChannelFrequency.BackColor = System.Drawing.SystemColors.Window
        Me.edtChannelFrequency.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtChannelFrequency.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtChannelFrequency.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtChannelFrequency.Location = New System.Drawing.Point(8, 39)
        Me.edtChannelFrequency.MaxLength = 0
        Me.edtChannelFrequency.Name = "edtChannelFrequency"
        Me.edtChannelFrequency.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtChannelFrequency.Size = New System.Drawing.Size(61, 20)
        Me.edtChannelFrequency.TabIndex = 16
        '
        'btnSetOverride
        '
        Me.btnSetOverride.BackColor = System.Drawing.SystemColors.Control
        Me.btnSetOverride.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSetOverride.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetOverride.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSetOverride.Location = New System.Drawing.Point(75, 39)
        Me.btnSetOverride.Name = "btnSetOverride"
        Me.btnSetOverride.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSetOverride.Size = New System.Drawing.Size(65, 22)
        Me.btnSetOverride.TabIndex = 15
        Me.btnSetOverride.Text = "set"
        '
        'btnDeleteOverride
        '
        Me.btnDeleteOverride.BackColor = System.Drawing.SystemColors.Control
        Me.btnDeleteOverride.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDeleteOverride.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteOverride.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDeleteOverride.Location = New System.Drawing.Point(146, 39)
        Me.btnDeleteOverride.Name = "btnDeleteOverride"
        Me.btnDeleteOverride.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnDeleteOverride.Size = New System.Drawing.Size(65, 22)
        Me.btnDeleteOverride.TabIndex = 14
        Me.btnDeleteOverride.Text = "delete"
        '
        'chkEnableFrequencyOverrides
        '
        Me.chkEnableFrequencyOverrides.BackColor = System.Drawing.SystemColors.Control
        Me.chkEnableFrequencyOverrides.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkEnableFrequencyOverrides.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEnableFrequencyOverrides.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkEnableFrequencyOverrides.Location = New System.Drawing.Point(16, 17)
        Me.chkEnableFrequencyOverrides.Name = "chkEnableFrequencyOverrides"
        Me.chkEnableFrequencyOverrides.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkEnableFrequencyOverrides.Size = New System.Drawing.Size(97, 17)
        Me.chkEnableFrequencyOverrides.TabIndex = 13
        Me.chkEnableFrequencyOverrides.Text = "enabled"
        '
        'grbTunerCountryCode
        '
        Me.grbTunerCountryCode.BackColor = System.Drawing.SystemColors.Control
        Me.grbTunerCountryCode.Controls.Add(Me.lblTVTuner)
        Me.grbTunerCountryCode.Controls.Add(Me.rdgTunerMode)
        Me.grbTunerCountryCode.Controls.Add(Me.rdgTunerInputType)
        Me.grbTunerCountryCode.Controls.Add(Me.grbCountryCode)
        Me.grbTunerCountryCode.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbTunerCountryCode.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grbTunerCountryCode.Location = New System.Drawing.Point(4, 0)
        Me.grbTunerCountryCode.Name = "grbTunerCountryCode"
        Me.grbTunerCountryCode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grbTunerCountryCode.Size = New System.Drawing.Size(344, 93)
        Me.grbTunerCountryCode.TabIndex = 0
        Me.grbTunerCountryCode.TabStop = False
        Me.grbTunerCountryCode.Text = "TV Tuner"
        '
        'lblTVTuner
        '
        Me.lblTVTuner.AutoSize = True
        Me.lblTVTuner.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTVTuner.Location = New System.Drawing.Point(82, 0)
        Me.lblTVTuner.Name = "lblTVTuner"
        Me.lblTVTuner.Size = New System.Drawing.Size(205, 14)
        Me.lblTVTuner.TabIndex = 7
        Me.lblTVTuner.Text = "Tuner mode, input type and country code"
        '
        'rdgTunerMode
        '
        Me.rdgTunerMode.Controls.Add(Me.rdgTunerModeDigitalSatellite)
        Me.rdgTunerMode.Controls.Add(Me.rdgTunerModeAMRadio)
        Me.rdgTunerMode.Controls.Add(Me.rdgTunerModeFMRadio)
        Me.rdgTunerMode.Controls.Add(Me.rdgTunerModeTV)
        Me.rdgTunerMode.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgTunerMode.Location = New System.Drawing.Point(8, 13)
        Me.rdgTunerMode.Name = "rdgTunerMode"
        Me.rdgTunerMode.Size = New System.Drawing.Size(121, 75)
        Me.rdgTunerMode.TabIndex = 6
        Me.rdgTunerMode.TabStop = False
        Me.rdgTunerMode.Text = "tuner mode"
        '
        'rdgTunerModeDigitalSatellite
        '
        Me.rdgTunerModeDigitalSatellite.Location = New System.Drawing.Point(8, 56)
        Me.rdgTunerModeDigitalSatellite.Name = "rdgTunerModeDigitalSatellite"
        Me.rdgTunerModeDigitalSatellite.Size = New System.Drawing.Size(107, 17)
        Me.rdgTunerModeDigitalSatellite.TabIndex = 3
        Me.rdgTunerModeDigitalSatellite.Tag = "3"
        Me.rdgTunerModeDigitalSatellite.Text = "Digital Satellite"
        '
        'rdgTunerModeAMRadio
        '
        Me.rdgTunerModeAMRadio.Location = New System.Drawing.Point(8, 42)
        Me.rdgTunerModeAMRadio.Name = "rdgTunerModeAMRadio"
        Me.rdgTunerModeAMRadio.Size = New System.Drawing.Size(107, 17)
        Me.rdgTunerModeAMRadio.TabIndex = 2
        Me.rdgTunerModeAMRadio.Tag = "2"
        Me.rdgTunerModeAMRadio.Text = "AM Radio"
        '
        'rdgTunerModeFMRadio
        '
        Me.rdgTunerModeFMRadio.Location = New System.Drawing.Point(8, 28)
        Me.rdgTunerModeFMRadio.Name = "rdgTunerModeFMRadio"
        Me.rdgTunerModeFMRadio.Size = New System.Drawing.Size(107, 18)
        Me.rdgTunerModeFMRadio.TabIndex = 1
        Me.rdgTunerModeFMRadio.Tag = "1"
        Me.rdgTunerModeFMRadio.Text = "FM Radio"
        '
        'rdgTunerModeTV
        '
        Me.rdgTunerModeTV.Location = New System.Drawing.Point(8, 14)
        Me.rdgTunerModeTV.Name = "rdgTunerModeTV"
        Me.rdgTunerModeTV.Size = New System.Drawing.Size(107, 16)
        Me.rdgTunerModeTV.TabIndex = 0
        Me.rdgTunerModeTV.Tag = "0"
        Me.rdgTunerModeTV.Text = "TV"
        '
        'rdgTunerInputType
        '
        Me.rdgTunerInputType.BackColor = System.Drawing.SystemColors.Control
        Me.rdgTunerInputType.Controls.Add(Me.rdgTunerInputTypeCable)
        Me.rdgTunerInputType.Controls.Add(Me.rdgTunerInputTypeAntenna)
        Me.rdgTunerInputType.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgTunerInputType.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgTunerInputType.Location = New System.Drawing.Point(135, 27)
        Me.rdgTunerInputType.Name = "rdgTunerInputType"
        Me.rdgTunerInputType.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgTunerInputType.Size = New System.Drawing.Size(105, 57)
        Me.rdgTunerInputType.TabIndex = 5
        Me.rdgTunerInputType.TabStop = False
        Me.rdgTunerInputType.Text = "tuner input type"
        '
        'rdgTunerInputTypeCable
        '
        Me.rdgTunerInputTypeCable.BackColor = System.Drawing.SystemColors.Control
        Me.rdgTunerInputTypeCable.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgTunerInputTypeCable.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgTunerInputTypeCable.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgTunerInputTypeCable.Location = New System.Drawing.Point(8, 16)
        Me.rdgTunerInputTypeCable.Name = "rdgTunerInputTypeCable"
        Me.rdgTunerInputTypeCable.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgTunerInputTypeCable.Size = New System.Drawing.Size(65, 17)
        Me.rdgTunerInputTypeCable.TabIndex = 7
        Me.rdgTunerInputTypeCable.TabStop = True
        Me.rdgTunerInputTypeCable.Tag = "0"
        Me.rdgTunerInputTypeCable.Text = "cable"
        '
        'rdgTunerInputTypeAntenna
        '
        Me.rdgTunerInputTypeAntenna.BackColor = System.Drawing.SystemColors.Control
        Me.rdgTunerInputTypeAntenna.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgTunerInputTypeAntenna.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgTunerInputTypeAntenna.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgTunerInputTypeAntenna.Location = New System.Drawing.Point(8, 32)
        Me.rdgTunerInputTypeAntenna.Name = "rdgTunerInputTypeAntenna"
        Me.rdgTunerInputTypeAntenna.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgTunerInputTypeAntenna.Size = New System.Drawing.Size(65, 17)
        Me.rdgTunerInputTypeAntenna.TabIndex = 6
        Me.rdgTunerInputTypeAntenna.TabStop = True
        Me.rdgTunerInputTypeAntenna.Tag = "1"
        Me.rdgTunerInputTypeAntenna.Text = "antenna"
        '
        'grbCountryCode
        '
        Me.grbCountryCode.BackColor = System.Drawing.SystemColors.Control
        Me.grbCountryCode.Controls.Add(Me.edtCountryCode)
        Me.grbCountryCode.Controls.Add(Me.btnSetCountryCode)
        Me.grbCountryCode.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbCountryCode.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grbCountryCode.Location = New System.Drawing.Point(246, 27)
        Me.grbCountryCode.Name = "grbCountryCode"
        Me.grbCountryCode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grbCountryCode.Size = New System.Drawing.Size(90, 57)
        Me.grbCountryCode.TabIndex = 2
        Me.grbCountryCode.TabStop = False
        Me.grbCountryCode.Text = "country code"
        '
        'edtCountryCode
        '
        Me.edtCountryCode.AcceptsReturn = True
        Me.edtCountryCode.BackColor = System.Drawing.SystemColors.Window
        Me.edtCountryCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtCountryCode.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtCountryCode.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtCountryCode.Location = New System.Drawing.Point(8, 24)
        Me.edtCountryCode.MaxLength = 0
        Me.edtCountryCode.Name = "edtCountryCode"
        Me.edtCountryCode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtCountryCode.Size = New System.Drawing.Size(33, 20)
        Me.edtCountryCode.TabIndex = 4
        '
        'btnSetCountryCode
        '
        Me.btnSetCountryCode.BackColor = System.Drawing.SystemColors.Control
        Me.btnSetCountryCode.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSetCountryCode.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetCountryCode.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSetCountryCode.Location = New System.Drawing.Point(48, 24)
        Me.btnSetCountryCode.Name = "btnSetCountryCode"
        Me.btnSetCountryCode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSetCountryCode.Size = New System.Drawing.Size(32, 20)
        Me.btnSetCountryCode.TabIndex = 3
        Me.btnSetCountryCode.Text = "set"
        '
        'lblTVTunerAvailable
        '
        Me.lblTVTunerAvailable.AutoSize = True
        Me.lblTVTunerAvailable.ForeColor = System.Drawing.Color.Red
        Me.lblTVTunerAvailable.Location = New System.Drawing.Point(354, -1)
        Me.lblTVTunerAvailable.Name = "lblTVTunerAvailable"
        Me.lblTVTunerAvailable.Size = New System.Drawing.Size(268, 14)
        Me.lblTVTunerAvailable.TabIndex = 20
        Me.lblTVTunerAvailable.Text = "The tuner is not available for this video capture device"
        '
        'grbTVScan
        '
        Me.grbTVScan.BackColor = System.Drawing.SystemColors.Control
        Me.grbTVScan.Controls.Add(Me.btnStartScan)
        Me.grbTVScan.Controls.Add(Me.btnStopScan)
        Me.grbTVScan.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbTVScan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grbTVScan.Location = New System.Drawing.Point(354, 67)
        Me.grbTVScan.Name = "grbTVScan"
        Me.grbTVScan.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grbTVScan.Size = New System.Drawing.Size(93, 75)
        Me.grbTVScan.TabIndex = 21
        Me.grbTVScan.TabStop = False
        Me.grbTVScan.Text = "Autoscan"
        '
        'btnStartScan
        '
        Me.btnStartScan.BackColor = System.Drawing.SystemColors.Control
        Me.btnStartScan.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnStartScan.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartScan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnStartScan.Location = New System.Drawing.Point(8, 16)
        Me.btnStartScan.Name = "btnStartScan"
        Me.btnStartScan.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnStartScan.Size = New System.Drawing.Size(76, 22)
        Me.btnStartScan.TabIndex = 11
        Me.btnStartScan.Text = "start"
        '
        'btnStopScan
        '
        Me.btnStopScan.BackColor = System.Drawing.SystemColors.Control
        Me.btnStopScan.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnStopScan.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStopScan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnStopScan.Location = New System.Drawing.Point(8, 45)
        Me.btnStopScan.Name = "btnStopScan"
        Me.btnStopScan.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnStopScan.Size = New System.Drawing.Size(76, 22)
        Me.btnStopScan.TabIndex = 10
        Me.btnStopScan.Text = "stop"
        '
        'btnTunerDialog
        '
        Me.btnTunerDialog.Location = New System.Drawing.Point(354, 27)
        Me.btnTunerDialog.Name = "btnTunerDialog"
        Me.btnTunerDialog.Size = New System.Drawing.Size(92, 27)
        Me.btnTunerDialog.TabIndex = 22
        Me.btnTunerDialog.Text = "tuner dialog"
        '
        'TVTuner
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(945, 221)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnTunerDialog)
        Me.Controls.Add(Me.grbTVScan)
        Me.Controls.Add(Me.lblTVTunerAvailable)
        Me.Controls.Add(Me.mmoChannelLog)
        Me.Controls.Add(Me.grbTVChannel)
        Me.Controls.Add(Me.grbTunerCountryCode)
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(4, 23)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TVTuner"
        Me.ShowInTaskbar = False
        Me.grbTVChannel.ResumeLayout(False)
        Me.grbTVChannel.PerformLayout()
        Me.grbFrequencyOverride.ResumeLayout(False)
        Me.grbFrequencyOverride.PerformLayout()
        Me.grbTunerCountryCode.ResumeLayout(False)
        Me.grbTunerCountryCode.PerformLayout()
        Me.rdgTunerMode.ResumeLayout(False)
        Me.rdgTunerInputType.ResumeLayout(False)
        Me.grbCountryCode.ResumeLayout(False)
        Me.grbCountryCode.PerformLayout()
        Me.grbTVScan.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region
    Public Sub RefreshControls()
        SetRadioButtonInGroupUsingTag(rdgTunerMode, MainForm.DefInstance.AxVideoGrabberNET1.TunerMode)
        SetRadioButtonInGroupUsingTag(rdgTunerInputType, MainForm.DefInstance.AxVideoGrabberNET1.TVTunerInputType)
        edtCountryCode.Text = MainForm.DefInstance.AxVideoGrabberNET1.TVCountryCode
        edtTVChannel.Text = MainForm.DefInstance.AxVideoGrabberNET1.TVChannel
        chkEnableFrequencyOverrides.Checked = MainForm.DefInstance.AxVideoGrabberNET1.TVUseFrequencyOverrides
        lblTVTunerAvailable.Visible = Not MainForm.DefInstance.AxVideoGrabberNET1.IsTVTunerAvailable
    End Sub

    Private Sub btnResetAllOverrides_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResetAllOverrides.Click
        MainForm.DefInstance.AxVideoGrabberNET1.TVClearFrequencyOverrides()
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        If IsNumeric(edtTVChannel.Text) Then
            MainForm.DefInstance.AxVideoGrabberNET1.TVChannel = edtTVChannel.Text
        End If
    End Sub

    Private Sub btnSetCountryCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetCountryCode.Click
        If IsNumeric(edtCountryCode.Text) Then
            MainForm.DefInstance.AxVideoGrabberNET1.TVCountryCode = edtCountryCode.Text
        End If
    End Sub

    Private Sub btnTunerDialog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTunerDialog.Click
        MainForm.DefInstance.AxVideoGrabberNET1.ShowDialog(vidgrab_NET.TxDialog.dlg_TVTuner)
        RefreshControls()
    End Sub

    Private Sub btnStartScan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartScan.Click
        MainForm.DefInstance.AxVideoGrabberNET1.TVStartAutoScan()
    End Sub

    Private Sub btnStopScan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStopScan.Click
        MainForm.DefInstance.AxVideoGrabberNET1.TVStopAutoScan()
    End Sub

    Private Sub chkEnableFrequencyOverrides_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEnableFrequencyOverrides.CheckedChanged
        MainForm.DefInstance.AxVideoGrabberNET1.TVUseFrequencyOverrides = chkEnableFrequencyOverrides.Checked
    End Sub

    Private Sub btnSetOverride_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetOverride.Click
        If IsNumeric(edtTVChannel.Text) And IsNumeric(edtChannelFrequency.Text) Then
            MainForm.DefInstance.AxVideoGrabberNET1.TVSetChannelFrequencyOverride(edtTVChannel.Text, edtChannelFrequency.Text)
        End If
    End Sub

    Private Sub btnDeleteOverride_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteOverride.Click
        If IsNumeric(edtTVChannel.Text) Then
            MainForm.DefInstance.AxVideoGrabberNET1.TVSetChannelFrequencyOverride(edtTVChannel.Text, -1)
        End If
    End Sub

    Private Sub rdgTunerInputType_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgTunerInputTypeCable.CheckedChanged, rdgTunerInputTypeAntenna.CheckedChanged
        If CType(sender, RadioButton).Checked Then
            MainForm.DefInstance.AxVideoGrabberNET1.TVTunerInputType = sender.Tag
        End If
    End Sub

    Private Sub rdgTunerMode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgTunerModeTV.CheckedChanged, rdgTunerModeFMRadio.CheckedChanged, rdgTunerModeAMRadio.CheckedChanged, rdgTunerModeDigitalSatellite.CheckedChanged
        If CType(sender, RadioButton).Checked Then
            MainForm.DefInstance.AxVideoGrabberNET1.TunerMode = sender.Tag
        End If
    End Sub

    Private Sub TVTuner_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        If Visible Then
            RefreshControls()
        End If
    End Sub

End Class
