Option Strict Off
Option Explicit On
Friend Class VideoSource
    Inherits SubForm ' SubForm is declared in VBUtil and inherits from System.Windows.Forms.Form
    'Unlike normal Form, it is not destroyed when closed, unless MainForm is being destroyed too.
#Region "Windows Form Designer generated code "
    Public Sub New()
        MyBase.New()
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
    Public WithEvents cboVideoSource As System.Windows.Forms.ComboBox
    Public WithEvents grbVideoSource As System.Windows.Forms.GroupBox
    Public WithEvents btnStartPreview As System.Windows.Forms.Button
    Public WithEvents btnStopPreview As System.Windows.Forms.Button
    Public WithEvents grbPreview As System.Windows.Forms.GroupBox
    Public WithEvents btnFrameRate As System.Windows.Forms.Button
    Public WithEvents edtFrameRate As System.Windows.Forms.TextBox
    Public WithEvents grbFrameRate As System.Windows.Forms.GroupBox
    Public WithEvents cboVideoDevices As System.Windows.Forms.ComboBox
    Public WithEvents cboVideoInputs As System.Windows.Forms.ComboBox
    Public WithEvents cboVideoSizes As System.Windows.Forms.ComboBox
    Public WithEvents cboVideoSubtypes As System.Windows.Forms.ComboBox
    Public WithEvents cboAnalogVideoStandard As System.Windows.Forms.ComboBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents grbVsVideoCaptureDevice As System.Windows.Forms.GroupBox
    Public WithEvents btnSelectFileOrUrl As System.Windows.Forms.Button
    Public WithEvents edtVideoSourceFileOrUrl As System.Windows.Forms.TextBox
    Public WithEvents grbVsFileOrUrl As System.Windows.Forms.GroupBox
    Public WithEvents chkScreenRecordingWithCursor As System.Windows.Forms.CheckBox
    Public WithEvents grbVsScreenRecording As System.Windows.Forms.GroupBox
    Public WithEvents rdgPreferredVideoSize1 As System.Windows.Forms.RadioButton
    Public WithEvents rdgPreferredVideoSize2 As System.Windows.Forms.RadioButton
    Public WithEvents rdgPreferredVideoSize3 As System.Windows.Forms.RadioButton
    Public WithEvents rdgPreferredVideoSize4 As System.Windows.Forms.RadioButton
    Public WithEvents rdgPreferredVideoSize5 As System.Windows.Forms.RadioButton
    Public WithEvents rdgPreferredVideoSize6 As System.Windows.Forms.RadioButton
    Public WithEvents rdgPreferredVideoSize7 As System.Windows.Forms.RadioButton
    Public WithEvents rdgPreferredVideoSize10 As System.Windows.Forms.RadioButton
    Public WithEvents rdgPreferredVideoSize11 As System.Windows.Forms.RadioButton
    Public WithEvents chkStretchPreferredVideoSize As System.Windows.Forms.CheckBox
    Public WithEvents rdgPreferredVideoSize12 As System.Windows.Forms.RadioButton
    Public WithEvents rdgPreferredVideoSize13 As System.Windows.Forms.RadioButton
    Public WithEvents grbPreferredVideoSizes As System.Windows.Forms.GroupBox
    Public WithEvents btnDeviceDialog As System.Windows.Forms.Button
    Public WithEvents btnStreamDialog As System.Windows.Forms.Button
    Public WithEvents btnCameraControlDialog As System.Windows.Forms.Button
    Public WithEvents btnVideoQualityDialog As System.Windows.Forms.Button
    Public WithEvents btnVideoControlDialog As System.Windows.Forms.Button
    Public WithEvents grbVideoDevicesDialogs As System.Windows.Forms.GroupBox
    Public WithEvents btnAutoRefreshPreview As System.Windows.Forms.CheckBox
    Public WithEvents Label11 As System.Windows.Forms.Label
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Friend WithEvents grbMultiplexedInputs As System.Windows.Forms.GroupBox
    Friend WithEvents chk4InputsLayout As System.Windows.Forms.CheckBox
    Friend WithEvents chkMultiplexedInputEmulation As System.Windows.Forms.CheckBox
    Public WithEvents edtScreenRecordingWindow As System.Windows.Forms.TextBox
    Public WithEvents btnScreenRecordingWindow As System.Windows.Forms.Button
    Public WithEvents btnSpecialControls As System.Windows.Forms.Button
    Friend WithEvents btnDVCamcorderControl As System.Windows.Forms.Button
    Friend WithEvents btnMonitorNumberInfo As System.Windows.Forms.Button
    Friend WithEvents edtMonitorNumber As System.Windows.Forms.TextBox
    Friend WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents label8 As System.Windows.Forms.Label
    Friend WithEvents label7 As System.Windows.Forms.Label
    Friend WithEvents edtSourceFileOrUrlPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnFrameRateHelp As System.Windows.Forms.Button
    Public WithEvents chkReduceDVFrameRate As System.Windows.Forms.CheckBox
    Friend WithEvents chkScreenRecordingWindow As System.Windows.Forms.CheckBox
    Friend WithEvents btnDemoUrl As System.Windows.Forms.Button
    Friend WithEvents lblEnumerateWindows As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents edtSourceFileOrUrlUserName As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.grbVideoSource = New System.Windows.Forms.GroupBox
        Me.cboVideoSource = New System.Windows.Forms.ComboBox
        Me.grbPreview = New System.Windows.Forms.GroupBox
        Me.btnStartPreview = New System.Windows.Forms.Button
        Me.btnStopPreview = New System.Windows.Forms.Button
        Me.grbFrameRate = New System.Windows.Forms.GroupBox
        Me.btnFrameRateHelp = New System.Windows.Forms.Button
        Me.btnFrameRate = New System.Windows.Forms.Button
        Me.edtFrameRate = New System.Windows.Forms.TextBox
        Me.grbVsVideoCaptureDevice = New System.Windows.Forms.GroupBox
        Me.grbMultiplexedInputs = New System.Windows.Forms.GroupBox
        Me.chkMultiplexedInputEmulation = New System.Windows.Forms.CheckBox
        Me.chk4InputsLayout = New System.Windows.Forms.CheckBox
        Me.cboVideoDevices = New System.Windows.Forms.ComboBox
        Me.cboVideoInputs = New System.Windows.Forms.ComboBox
        Me.cboVideoSizes = New System.Windows.Forms.ComboBox
        Me.cboVideoSubtypes = New System.Windows.Forms.ComboBox
        Me.cboAnalogVideoStandard = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.grbVsFileOrUrl = New System.Windows.Forms.GroupBox
        Me.btnDemoUrl = New System.Windows.Forms.Button
        Me.label8 = New System.Windows.Forms.Label
        Me.label7 = New System.Windows.Forms.Label
        Me.edtSourceFileOrUrlPassword = New System.Windows.Forms.TextBox
        Me.edtSourceFileOrUrlUserName = New System.Windows.Forms.TextBox
        Me.btnSelectFileOrUrl = New System.Windows.Forms.Button
        Me.edtVideoSourceFileOrUrl = New System.Windows.Forms.TextBox
        Me.grbVsScreenRecording = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.chkScreenRecordingWindow = New System.Windows.Forms.CheckBox
        Me.btnScreenRecordingWindow = New System.Windows.Forms.Button
        Me.btnMonitorNumberInfo = New System.Windows.Forms.Button
        Me.edtMonitorNumber = New System.Windows.Forms.TextBox
        Me.label6 = New System.Windows.Forms.Label
        Me.edtScreenRecordingWindow = New System.Windows.Forms.TextBox
        Me.chkScreenRecordingWithCursor = New System.Windows.Forms.CheckBox
        Me.lblEnumerateWindows = New System.Windows.Forms.Label
        Me.grbPreferredVideoSizes = New System.Windows.Forms.GroupBox
        Me.rdgPreferredVideoSize1 = New System.Windows.Forms.RadioButton
        Me.rdgPreferredVideoSize2 = New System.Windows.Forms.RadioButton
        Me.rdgPreferredVideoSize3 = New System.Windows.Forms.RadioButton
        Me.rdgPreferredVideoSize4 = New System.Windows.Forms.RadioButton
        Me.rdgPreferredVideoSize5 = New System.Windows.Forms.RadioButton
        Me.rdgPreferredVideoSize6 = New System.Windows.Forms.RadioButton
        Me.rdgPreferredVideoSize7 = New System.Windows.Forms.RadioButton
        Me.rdgPreferredVideoSize10 = New System.Windows.Forms.RadioButton
        Me.rdgPreferredVideoSize11 = New System.Windows.Forms.RadioButton
        Me.chkStretchPreferredVideoSize = New System.Windows.Forms.CheckBox
        Me.rdgPreferredVideoSize12 = New System.Windows.Forms.RadioButton
        Me.rdgPreferredVideoSize13 = New System.Windows.Forms.RadioButton
        Me.grbVideoDevicesDialogs = New System.Windows.Forms.GroupBox
        Me.btnDVCamcorderControl = New System.Windows.Forms.Button
        Me.btnSpecialControls = New System.Windows.Forms.Button
        Me.btnDeviceDialog = New System.Windows.Forms.Button
        Me.btnStreamDialog = New System.Windows.Forms.Button
        Me.btnCameraControlDialog = New System.Windows.Forms.Button
        Me.btnVideoQualityDialog = New System.Windows.Forms.Button
        Me.btnVideoControlDialog = New System.Windows.Forms.Button
        Me.btnAutoRefreshPreview = New System.Windows.Forms.CheckBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.chkReduceDVFrameRate = New System.Windows.Forms.CheckBox
        Me.grbVideoSource.SuspendLayout()
        Me.grbPreview.SuspendLayout()
        Me.grbFrameRate.SuspendLayout()
        Me.grbVsVideoCaptureDevice.SuspendLayout()
        Me.grbMultiplexedInputs.SuspendLayout()
        Me.grbVsFileOrUrl.SuspendLayout()
        Me.grbVsScreenRecording.SuspendLayout()
        Me.grbPreferredVideoSizes.SuspendLayout()
        Me.grbVideoDevicesDialogs.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbVideoSource
        '
        Me.grbVideoSource.BackColor = System.Drawing.SystemColors.Control
        Me.grbVideoSource.Controls.Add(Me.cboVideoSource)
        Me.grbVideoSource.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbVideoSource.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grbVideoSource.Location = New System.Drawing.Point(4, 0)
        Me.grbVideoSource.Name = "grbVideoSource"
        Me.grbVideoSource.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grbVideoSource.Size = New System.Drawing.Size(161, 46)
        Me.grbVideoSource.TabIndex = 44
        Me.grbVideoSource.TabStop = False
        Me.grbVideoSource.Text = "VIDEO SOURCE"
        '
        'cboVideoSource
        '
        Me.cboVideoSource.BackColor = System.Drawing.SystemColors.Window
        Me.cboVideoSource.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboVideoSource.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVideoSource.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboVideoSource.Location = New System.Drawing.Point(8, 18)
        Me.cboVideoSource.Name = "cboVideoSource"
        Me.cboVideoSource.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboVideoSource.Size = New System.Drawing.Size(147, 22)
        Me.cboVideoSource.TabIndex = 45
        '
        'grbPreview
        '
        Me.grbPreview.BackColor = System.Drawing.SystemColors.Control
        Me.grbPreview.Controls.Add(Me.btnStartPreview)
        Me.grbPreview.Controls.Add(Me.btnStopPreview)
        Me.grbPreview.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbPreview.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grbPreview.Location = New System.Drawing.Point(171, 0)
        Me.grbPreview.Name = "grbPreview"
        Me.grbPreview.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grbPreview.Size = New System.Drawing.Size(137, 46)
        Me.grbPreview.TabIndex = 41
        Me.grbPreview.TabStop = False
        Me.grbPreview.Text = "Preview"
        '
        'btnStartPreview
        '
        Me.btnStartPreview.BackColor = System.Drawing.SystemColors.Control
        Me.btnStartPreview.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnStartPreview.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartPreview.ForeColor = System.Drawing.Color.Red
        Me.btnStartPreview.Location = New System.Drawing.Point(8, 15)
        Me.btnStartPreview.Name = "btnStartPreview"
        Me.btnStartPreview.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnStartPreview.Size = New System.Drawing.Size(57, 24)
        Me.btnStartPreview.TabIndex = 43
        Me.btnStartPreview.Text = "Start"
        Me.btnStartPreview.UseVisualStyleBackColor = False
        '
        'btnStopPreview
        '
        Me.btnStopPreview.BackColor = System.Drawing.SystemColors.Control
        Me.btnStopPreview.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnStopPreview.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStopPreview.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnStopPreview.Location = New System.Drawing.Point(72, 15)
        Me.btnStopPreview.Name = "btnStopPreview"
        Me.btnStopPreview.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnStopPreview.Size = New System.Drawing.Size(57, 24)
        Me.btnStopPreview.TabIndex = 42
        Me.btnStopPreview.Text = "Stop"
        Me.btnStopPreview.UseVisualStyleBackColor = False
        '
        'grbFrameRate
        '
        Me.grbFrameRate.BackColor = System.Drawing.SystemColors.Control
        Me.grbFrameRate.Controls.Add(Me.btnFrameRateHelp)
        Me.grbFrameRate.Controls.Add(Me.btnFrameRate)
        Me.grbFrameRate.Controls.Add(Me.edtFrameRate)
        Me.grbFrameRate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbFrameRate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grbFrameRate.Location = New System.Drawing.Point(313, 0)
        Me.grbFrameRate.Name = "grbFrameRate"
        Me.grbFrameRate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grbFrameRate.Size = New System.Drawing.Size(105, 46)
        Me.grbFrameRate.TabIndex = 38
        Me.grbFrameRate.TabStop = False
        Me.grbFrameRate.Text = "Frame rate"
        '
        'btnFrameRateHelp
        '
        Me.btnFrameRateHelp.Location = New System.Drawing.Point(75, 18)
        Me.btnFrameRateHelp.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.btnFrameRateHelp.Name = "btnFrameRateHelp"
        Me.btnFrameRateHelp.Size = New System.Drawing.Size(20, 22)
        Me.btnFrameRateHelp.TabIndex = 41
        Me.btnFrameRateHelp.Text = "?"
        '
        'btnFrameRate
        '
        Me.btnFrameRate.BackColor = System.Drawing.SystemColors.Control
        Me.btnFrameRate.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnFrameRate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFrameRate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnFrameRate.Location = New System.Drawing.Point(45, 18)
        Me.btnFrameRate.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.btnFrameRate.Name = "btnFrameRate"
        Me.btnFrameRate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnFrameRate.Size = New System.Drawing.Size(30, 22)
        Me.btnFrameRate.TabIndex = 40
        Me.btnFrameRate.Text = "OK"
        Me.btnFrameRate.UseVisualStyleBackColor = False
        '
        'edtFrameRate
        '
        Me.edtFrameRate.AcceptsReturn = True
        Me.edtFrameRate.BackColor = System.Drawing.SystemColors.Window
        Me.edtFrameRate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtFrameRate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtFrameRate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtFrameRate.Location = New System.Drawing.Point(6, 18)
        Me.edtFrameRate.MaxLength = 0
        Me.edtFrameRate.Name = "edtFrameRate"
        Me.edtFrameRate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtFrameRate.Size = New System.Drawing.Size(33, 20)
        Me.edtFrameRate.TabIndex = 39
        Me.edtFrameRate.Text = "0"
        '
        'grbVsVideoCaptureDevice
        '
        Me.grbVsVideoCaptureDevice.BackColor = System.Drawing.SystemColors.Control
        Me.grbVsVideoCaptureDevice.Controls.Add(Me.grbMultiplexedInputs)
        Me.grbVsVideoCaptureDevice.Controls.Add(Me.cboVideoDevices)
        Me.grbVsVideoCaptureDevice.Controls.Add(Me.cboVideoInputs)
        Me.grbVsVideoCaptureDevice.Controls.Add(Me.cboVideoSizes)
        Me.grbVsVideoCaptureDevice.Controls.Add(Me.cboVideoSubtypes)
        Me.grbVsVideoCaptureDevice.Controls.Add(Me.cboAnalogVideoStandard)
        Me.grbVsVideoCaptureDevice.Controls.Add(Me.Label1)
        Me.grbVsVideoCaptureDevice.Controls.Add(Me.Label2)
        Me.grbVsVideoCaptureDevice.Controls.Add(Me.Label3)
        Me.grbVsVideoCaptureDevice.Controls.Add(Me.Label4)
        Me.grbVsVideoCaptureDevice.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbVsVideoCaptureDevice.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grbVsVideoCaptureDevice.Location = New System.Drawing.Point(4, 46)
        Me.grbVsVideoCaptureDevice.Name = "grbVsVideoCaptureDevice"
        Me.grbVsVideoCaptureDevice.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grbVsVideoCaptureDevice.Size = New System.Drawing.Size(569, 74)
        Me.grbVsVideoCaptureDevice.TabIndex = 27
        Me.grbVsVideoCaptureDevice.TabStop = False
        Me.grbVsVideoCaptureDevice.Text = "video source = video capture device"
        '
        'grbMultiplexedInputs
        '
        Me.grbMultiplexedInputs.Controls.Add(Me.chkMultiplexedInputEmulation)
        Me.grbMultiplexedInputs.Controls.Add(Me.chk4InputsLayout)
        Me.grbMultiplexedInputs.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbMultiplexedInputs.Location = New System.Drawing.Point(414, 8)
        Me.grbMultiplexedInputs.Name = "grbMultiplexedInputs"
        Me.grbMultiplexedInputs.Size = New System.Drawing.Size(148, 58)
        Me.grbMultiplexedInputs.TabIndex = 38
        Me.grbMultiplexedInputs.TabStop = False
        Me.grbMultiplexedInputs.Text = "Multiplexed inputs"
        '
        'chkMultiplexedInputEmulation
        '
        Me.chkMultiplexedInputEmulation.Location = New System.Drawing.Point(8, 33)
        Me.chkMultiplexedInputEmulation.Name = "chkMultiplexedInputEmulation"
        Me.chkMultiplexedInputEmulation.Size = New System.Drawing.Size(134, 16)
        Me.chkMultiplexedInputEmulation.TabIndex = 1
        Me.chkMultiplexedInputEmulation.Text = "emulation"
        '
        'chk4InputsLayout
        '
        Me.chk4InputsLayout.Location = New System.Drawing.Point(8, 16)
        Me.chk4InputsLayout.Name = "chk4InputsLayout"
        Me.chk4InputsLayout.Size = New System.Drawing.Size(134, 16)
        Me.chk4InputsLayout.TabIndex = 0
        Me.chk4InputsLayout.Text = "enable 4 inputs layout"
        '
        'cboVideoDevices
        '
        Me.cboVideoDevices.BackColor = System.Drawing.SystemColors.Window
        Me.cboVideoDevices.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboVideoDevices.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVideoDevices.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboVideoDevices.Location = New System.Drawing.Point(8, 13)
        Me.cboVideoDevices.Name = "cboVideoDevices"
        Me.cboVideoDevices.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboVideoDevices.Size = New System.Drawing.Size(390, 22)
        Me.cboVideoDevices.TabIndex = 33
        Me.cboVideoDevices.Text = "SELECT FIRST A VIDEO CAPTURE DEVICE IN THIS LIST"
        '
        'cboVideoInputs
        '
        Me.cboVideoInputs.BackColor = System.Drawing.SystemColors.Window
        Me.cboVideoInputs.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboVideoInputs.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVideoInputs.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboVideoInputs.Location = New System.Drawing.Point(8, 48)
        Me.cboVideoInputs.Name = "cboVideoInputs"
        Me.cboVideoInputs.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboVideoInputs.Size = New System.Drawing.Size(82, 22)
        Me.cboVideoInputs.TabIndex = 32
        '
        'cboVideoSizes
        '
        Me.cboVideoSizes.BackColor = System.Drawing.SystemColors.Window
        Me.cboVideoSizes.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboVideoSizes.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVideoSizes.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboVideoSizes.Location = New System.Drawing.Point(98, 48)
        Me.cboVideoSizes.Name = "cboVideoSizes"
        Me.cboVideoSizes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboVideoSizes.Size = New System.Drawing.Size(82, 22)
        Me.cboVideoSizes.TabIndex = 31
        '
        'cboVideoSubtypes
        '
        Me.cboVideoSubtypes.BackColor = System.Drawing.SystemColors.Window
        Me.cboVideoSubtypes.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboVideoSubtypes.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVideoSubtypes.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboVideoSubtypes.Location = New System.Drawing.Point(187, 48)
        Me.cboVideoSubtypes.Name = "cboVideoSubtypes"
        Me.cboVideoSubtypes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboVideoSubtypes.Size = New System.Drawing.Size(88, 22)
        Me.cboVideoSubtypes.TabIndex = 30
        '
        'cboAnalogVideoStandard
        '
        Me.cboAnalogVideoStandard.BackColor = System.Drawing.SystemColors.Window
        Me.cboAnalogVideoStandard.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboAnalogVideoStandard.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAnalogVideoStandard.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboAnalogVideoStandard.Location = New System.Drawing.Point(282, 48)
        Me.cboAnalogVideoStandard.Name = "cboAnalogVideoStandard"
        Me.cboAnalogVideoStandard.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboAnalogVideoStandard.Size = New System.Drawing.Size(116, 22)
        Me.cboAnalogVideoStandard.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(5, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(65, 17)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "video input"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(184, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(75, 14)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "video subtype"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(98, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(56, 14)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "video size"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(279, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(121, 17)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "analog video standard"
        '
        'grbVsFileOrUrl
        '
        Me.grbVsFileOrUrl.BackColor = System.Drawing.SystemColors.Control
        Me.grbVsFileOrUrl.Controls.Add(Me.btnDemoUrl)
        Me.grbVsFileOrUrl.Controls.Add(Me.label8)
        Me.grbVsFileOrUrl.Controls.Add(Me.label7)
        Me.grbVsFileOrUrl.Controls.Add(Me.edtSourceFileOrUrlPassword)
        Me.grbVsFileOrUrl.Controls.Add(Me.edtSourceFileOrUrlUserName)
        Me.grbVsFileOrUrl.Controls.Add(Me.btnSelectFileOrUrl)
        Me.grbVsFileOrUrl.Controls.Add(Me.edtVideoSourceFileOrUrl)
        Me.grbVsFileOrUrl.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbVsFileOrUrl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grbVsFileOrUrl.Location = New System.Drawing.Point(4, 120)
        Me.grbVsFileOrUrl.Name = "grbVsFileOrUrl"
        Me.grbVsFileOrUrl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grbVsFileOrUrl.Size = New System.Drawing.Size(464, 60)
        Me.grbVsFileOrUrl.TabIndex = 24
        Me.grbVsFileOrUrl.TabStop = False
        Me.grbVsFileOrUrl.Text = "video source = file or URL"
        '
        'btnDemoUrl
        '
        Me.btnDemoUrl.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDemoUrl.Location = New System.Drawing.Point(309, 15)
        Me.btnDemoUrl.Name = "btnDemoUrl"
        Me.btnDemoUrl.Size = New System.Drawing.Size(75, 20)
        Me.btnDemoUrl.TabIndex = 38
        Me.btnDemoUrl.Text = "demo URL?"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.Location = New System.Drawing.Point(387, 38)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(34, 14)
        Me.label8.TabIndex = 37
        Me.label8.Text = "pass:"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.Location = New System.Drawing.Point(387, 17)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(32, 14)
        Me.label7.TabIndex = 36
        Me.label7.Text = "user:"
        '
        'edtSourceFileOrUrlPassword
        '
        Me.edtSourceFileOrUrlPassword.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtSourceFileOrUrlPassword.Location = New System.Drawing.Point(425, 36)
        Me.edtSourceFileOrUrlPassword.Name = "edtSourceFileOrUrlPassword"
        Me.edtSourceFileOrUrlPassword.Size = New System.Drawing.Size(33, 20)
        Me.edtSourceFileOrUrlPassword.TabIndex = 35
        '
        'edtSourceFileOrUrlUserName
        '
        Me.edtSourceFileOrUrlUserName.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtSourceFileOrUrlUserName.Location = New System.Drawing.Point(425, 13)
        Me.edtSourceFileOrUrlUserName.Name = "edtSourceFileOrUrlUserName"
        Me.edtSourceFileOrUrlUserName.Size = New System.Drawing.Size(33, 20)
        Me.edtSourceFileOrUrlUserName.TabIndex = 34
        '
        'btnSelectFileOrUrl
        '
        Me.btnSelectFileOrUrl.BackColor = System.Drawing.SystemColors.Control
        Me.btnSelectFileOrUrl.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSelectFileOrUrl.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectFileOrUrl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSelectFileOrUrl.Location = New System.Drawing.Point(0, 14)
        Me.btnSelectFileOrUrl.Name = "btnSelectFileOrUrl"
        Me.btnSelectFileOrUrl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSelectFileOrUrl.Size = New System.Drawing.Size(47, 21)
        Me.btnSelectFileOrUrl.TabIndex = 26
        Me.btnSelectFileOrUrl.Text = "open"
        Me.btnSelectFileOrUrl.UseVisualStyleBackColor = False
        '
        'edtVideoSourceFileOrUrl
        '
        Me.edtVideoSourceFileOrUrl.AcceptsReturn = True
        Me.edtVideoSourceFileOrUrl.BackColor = System.Drawing.SystemColors.Window
        Me.edtVideoSourceFileOrUrl.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtVideoSourceFileOrUrl.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtVideoSourceFileOrUrl.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtVideoSourceFileOrUrl.Location = New System.Drawing.Point(53, 14)
        Me.edtVideoSourceFileOrUrl.MaxLength = 0
        Me.edtVideoSourceFileOrUrl.Name = "edtVideoSourceFileOrUrl"
        Me.edtVideoSourceFileOrUrl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtVideoSourceFileOrUrl.Size = New System.Drawing.Size(251, 20)
        Me.edtVideoSourceFileOrUrl.TabIndex = 25
        Me.edtVideoSourceFileOrUrl.Text = "mms://www.datastead.com/demo/demo.wmv"
        '
        'grbVsScreenRecording
        '
        Me.grbVsScreenRecording.BackColor = System.Drawing.SystemColors.Control
        Me.grbVsScreenRecording.Controls.Add(Me.Label5)
        Me.grbVsScreenRecording.Controls.Add(Me.chkScreenRecordingWindow)
        Me.grbVsScreenRecording.Controls.Add(Me.btnScreenRecordingWindow)
        Me.grbVsScreenRecording.Controls.Add(Me.btnMonitorNumberInfo)
        Me.grbVsScreenRecording.Controls.Add(Me.edtMonitorNumber)
        Me.grbVsScreenRecording.Controls.Add(Me.label6)
        Me.grbVsScreenRecording.Controls.Add(Me.edtScreenRecordingWindow)
        Me.grbVsScreenRecording.Controls.Add(Me.chkScreenRecordingWithCursor)
        Me.grbVsScreenRecording.Controls.Add(Me.lblEnumerateWindows)
        Me.grbVsScreenRecording.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbVsScreenRecording.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grbVsScreenRecording.Location = New System.Drawing.Point(472, 121)
        Me.grbVsScreenRecording.Name = "grbVsScreenRecording"
        Me.grbVsScreenRecording.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grbVsScreenRecording.Size = New System.Drawing.Size(310, 60)
        Me.grbVsScreenRecording.TabIndex = 22
        Me.grbVsScreenRecording.TabStop = False
        Me.grbVsScreenRecording.Text = "video source = screen recording"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(80, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 14)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "use this window (""""=full screen)"
        '
        'chkScreenRecordingWindow
        '
        Me.chkScreenRecordingWindow.AutoSize = True
        Me.chkScreenRecordingWindow.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkScreenRecordingWindow.Location = New System.Drawing.Point(222, 34)
        Me.chkScreenRecordingWindow.Name = "chkScreenRecordingWindow"
        Me.chkScreenRecordingWindow.Size = New System.Drawing.Size(53, 18)
        Me.chkScreenRecordingWindow.TabIndex = 34
        Me.chkScreenRecordingWindow.Text = "exact"
        '
        'btnScreenRecordingWindow
        '
        Me.btnScreenRecordingWindow.BackColor = System.Drawing.SystemColors.Control
        Me.btnScreenRecordingWindow.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnScreenRecordingWindow.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnScreenRecordingWindow.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnScreenRecordingWindow.Location = New System.Drawing.Point(276, 33)
        Me.btnScreenRecordingWindow.Name = "btnScreenRecordingWindow"
        Me.btnScreenRecordingWindow.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnScreenRecordingWindow.Size = New System.Drawing.Size(28, 21)
        Me.btnScreenRecordingWindow.TabIndex = 27
        Me.btnScreenRecordingWindow.Text = "ok"
        Me.btnScreenRecordingWindow.UseVisualStyleBackColor = False
        '
        'btnMonitorNumberInfo
        '
        Me.btnMonitorNumberInfo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMonitorNumberInfo.Location = New System.Drawing.Point(39, 33)
        Me.btnMonitorNumberInfo.Name = "btnMonitorNumberInfo"
        Me.btnMonitorNumberInfo.Size = New System.Drawing.Size(38, 20)
        Me.btnMonitorNumberInfo.TabIndex = 33
        Me.btnMonitorNumberInfo.Text = "info?"
        '
        'edtMonitorNumber
        '
        Me.edtMonitorNumber.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtMonitorNumber.Location = New System.Drawing.Point(2, 34)
        Me.edtMonitorNumber.Name = "edtMonitorNumber"
        Me.edtMonitorNumber.Size = New System.Drawing.Size(40, 20)
        Me.edtMonitorNumber.TabIndex = 32
        Me.edtMonitorNumber.Text = "0"
        '
        'label6
        '
        Me.label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(2, 18)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(85, 18)
        Me.label6.TabIndex = 31
        Me.label6.Text = "monitor num:"
        '
        'edtScreenRecordingWindow
        '
        Me.edtScreenRecordingWindow.AcceptsReturn = True
        Me.edtScreenRecordingWindow.BackColor = System.Drawing.SystemColors.Window
        Me.edtScreenRecordingWindow.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtScreenRecordingWindow.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtScreenRecordingWindow.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtScreenRecordingWindow.Location = New System.Drawing.Point(83, 33)
        Me.edtScreenRecordingWindow.MaxLength = 0
        Me.edtScreenRecordingWindow.Name = "edtScreenRecordingWindow"
        Me.edtScreenRecordingWindow.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtScreenRecordingWindow.Size = New System.Drawing.Size(134, 20)
        Me.edtScreenRecordingWindow.TabIndex = 26
        Me.edtScreenRecordingWindow.Text = "TVideoGrabber demo"
        '
        'chkScreenRecordingWithCursor
        '
        Me.chkScreenRecordingWithCursor.AutoSize = True
        Me.chkScreenRecordingWithCursor.BackColor = System.Drawing.SystemColors.Control
        Me.chkScreenRecordingWithCursor.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkScreenRecordingWithCursor.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkScreenRecordingWithCursor.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkScreenRecordingWithCursor.Location = New System.Drawing.Point(250, 11)
        Me.chkScreenRecordingWithCursor.Name = "chkScreenRecordingWithCursor"
        Me.chkScreenRecordingWithCursor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkScreenRecordingWithCursor.Size = New System.Drawing.Size(58, 18)
        Me.chkScreenRecordingWithCursor.TabIndex = 23
        Me.chkScreenRecordingWithCursor.Text = "cursor"
        Me.chkScreenRecordingWithCursor.UseVisualStyleBackColor = False
        '
        'lblEnumerateWindows
        '
        Me.lblEnumerateWindows.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnumerateWindows.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblEnumerateWindows.Location = New System.Drawing.Point(399, 31)
        Me.lblEnumerateWindows.Name = "lblEnumerateWindows"
        Me.lblEnumerateWindows.Size = New System.Drawing.Size(22, 18)
        Me.lblEnumerateWindows.TabIndex = 35
        Me.lblEnumerateWindows.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grbPreferredVideoSizes
        '
        Me.grbPreferredVideoSizes.BackColor = System.Drawing.SystemColors.Control
        Me.grbPreferredVideoSizes.Controls.Add(Me.rdgPreferredVideoSize1)
        Me.grbPreferredVideoSizes.Controls.Add(Me.rdgPreferredVideoSize2)
        Me.grbPreferredVideoSizes.Controls.Add(Me.rdgPreferredVideoSize3)
        Me.grbPreferredVideoSizes.Controls.Add(Me.rdgPreferredVideoSize4)
        Me.grbPreferredVideoSizes.Controls.Add(Me.rdgPreferredVideoSize5)
        Me.grbPreferredVideoSizes.Controls.Add(Me.rdgPreferredVideoSize6)
        Me.grbPreferredVideoSizes.Controls.Add(Me.rdgPreferredVideoSize7)
        Me.grbPreferredVideoSizes.Controls.Add(Me.rdgPreferredVideoSize10)
        Me.grbPreferredVideoSizes.Controls.Add(Me.rdgPreferredVideoSize11)
        Me.grbPreferredVideoSizes.Controls.Add(Me.chkStretchPreferredVideoSize)
        Me.grbPreferredVideoSizes.Controls.Add(Me.rdgPreferredVideoSize12)
        Me.grbPreferredVideoSizes.Controls.Add(Me.rdgPreferredVideoSize13)
        Me.grbPreferredVideoSizes.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbPreferredVideoSizes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grbPreferredVideoSizes.Location = New System.Drawing.Point(580, 16)
        Me.grbPreferredVideoSizes.Name = "grbPreferredVideoSizes"
        Me.grbPreferredVideoSizes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grbPreferredVideoSizes.Size = New System.Drawing.Size(201, 104)
        Me.grbPreferredVideoSizes.TabIndex = 7
        Me.grbPreferredVideoSizes.TabStop = False
        Me.grbPreferredVideoSizes.Text = "preferred video sizes (examples)"
        '
        'rdgPreferredVideoSize1
        '
        Me.rdgPreferredVideoSize1.BackColor = System.Drawing.SystemColors.Control
        Me.rdgPreferredVideoSize1.Checked = True
        Me.rdgPreferredVideoSize1.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgPreferredVideoSize1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgPreferredVideoSize1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgPreferredVideoSize1.Location = New System.Drawing.Point(8, 14)
        Me.rdgPreferredVideoSize1.Name = "rdgPreferredVideoSize1"
        Me.rdgPreferredVideoSize1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgPreferredVideoSize1.Size = New System.Drawing.Size(97, 15)
        Me.rdgPreferredVideoSize1.TabIndex = 21
        Me.rdgPreferredVideoSize1.TabStop = True
        Me.rdgPreferredVideoSize1.Tag = "0"
        Me.rdgPreferredVideoSize1.Text = "device sizes"
        Me.rdgPreferredVideoSize1.UseVisualStyleBackColor = False
        '
        'rdgPreferredVideoSize2
        '
        Me.rdgPreferredVideoSize2.BackColor = System.Drawing.SystemColors.Control
        Me.rdgPreferredVideoSize2.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgPreferredVideoSize2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgPreferredVideoSize2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgPreferredVideoSize2.Location = New System.Drawing.Point(8, 28)
        Me.rdgPreferredVideoSize2.Name = "rdgPreferredVideoSize2"
        Me.rdgPreferredVideoSize2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgPreferredVideoSize2.Size = New System.Drawing.Size(97, 15)
        Me.rdgPreferredVideoSize2.TabIndex = 20
        Me.rdgPreferredVideoSize2.TabStop = True
        Me.rdgPreferredVideoSize2.Tag = "1"
        Me.rdgPreferredVideoSize2.Text = "88x60"
        Me.rdgPreferredVideoSize2.UseVisualStyleBackColor = False
        '
        'rdgPreferredVideoSize3
        '
        Me.rdgPreferredVideoSize3.BackColor = System.Drawing.SystemColors.Control
        Me.rdgPreferredVideoSize3.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgPreferredVideoSize3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgPreferredVideoSize3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgPreferredVideoSize3.Location = New System.Drawing.Point(8, 42)
        Me.rdgPreferredVideoSize3.Name = "rdgPreferredVideoSize3"
        Me.rdgPreferredVideoSize3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgPreferredVideoSize3.Size = New System.Drawing.Size(97, 15)
        Me.rdgPreferredVideoSize3.TabIndex = 19
        Me.rdgPreferredVideoSize3.TabStop = True
        Me.rdgPreferredVideoSize3.Tag = "2"
        Me.rdgPreferredVideoSize3.Text = "88x72"
        Me.rdgPreferredVideoSize3.UseVisualStyleBackColor = False
        '
        'rdgPreferredVideoSize4
        '
        Me.rdgPreferredVideoSize4.BackColor = System.Drawing.SystemColors.Control
        Me.rdgPreferredVideoSize4.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgPreferredVideoSize4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgPreferredVideoSize4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgPreferredVideoSize4.Location = New System.Drawing.Point(8, 56)
        Me.rdgPreferredVideoSize4.Name = "rdgPreferredVideoSize4"
        Me.rdgPreferredVideoSize4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgPreferredVideoSize4.Size = New System.Drawing.Size(97, 15)
        Me.rdgPreferredVideoSize4.TabIndex = 18
        Me.rdgPreferredVideoSize4.TabStop = True
        Me.rdgPreferredVideoSize4.Tag = "3"
        Me.rdgPreferredVideoSize4.Text = "180x120"
        Me.rdgPreferredVideoSize4.UseVisualStyleBackColor = False
        '
        'rdgPreferredVideoSize5
        '
        Me.rdgPreferredVideoSize5.BackColor = System.Drawing.SystemColors.Control
        Me.rdgPreferredVideoSize5.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgPreferredVideoSize5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgPreferredVideoSize5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgPreferredVideoSize5.Location = New System.Drawing.Point(8, 70)
        Me.rdgPreferredVideoSize5.Name = "rdgPreferredVideoSize5"
        Me.rdgPreferredVideoSize5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgPreferredVideoSize5.Size = New System.Drawing.Size(97, 15)
        Me.rdgPreferredVideoSize5.TabIndex = 17
        Me.rdgPreferredVideoSize5.TabStop = True
        Me.rdgPreferredVideoSize5.Tag = "4"
        Me.rdgPreferredVideoSize5.Text = "180x144"
        Me.rdgPreferredVideoSize5.UseVisualStyleBackColor = False
        '
        'rdgPreferredVideoSize6
        '
        Me.rdgPreferredVideoSize6.BackColor = System.Drawing.SystemColors.Control
        Me.rdgPreferredVideoSize6.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgPreferredVideoSize6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgPreferredVideoSize6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgPreferredVideoSize6.Location = New System.Drawing.Point(8, 84)
        Me.rdgPreferredVideoSize6.Name = "rdgPreferredVideoSize6"
        Me.rdgPreferredVideoSize6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgPreferredVideoSize6.Size = New System.Drawing.Size(97, 15)
        Me.rdgPreferredVideoSize6.TabIndex = 16
        Me.rdgPreferredVideoSize6.TabStop = True
        Me.rdgPreferredVideoSize6.Tag = "5"
        Me.rdgPreferredVideoSize6.Text = "320x240"
        Me.rdgPreferredVideoSize6.UseVisualStyleBackColor = False
        '
        'rdgPreferredVideoSize7
        '
        Me.rdgPreferredVideoSize7.BackColor = System.Drawing.SystemColors.Control
        Me.rdgPreferredVideoSize7.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgPreferredVideoSize7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgPreferredVideoSize7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgPreferredVideoSize7.Location = New System.Drawing.Point(104, 14)
        Me.rdgPreferredVideoSize7.Name = "rdgPreferredVideoSize7"
        Me.rdgPreferredVideoSize7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgPreferredVideoSize7.Size = New System.Drawing.Size(64, 15)
        Me.rdgPreferredVideoSize7.TabIndex = 15
        Me.rdgPreferredVideoSize7.TabStop = True
        Me.rdgPreferredVideoSize7.Tag = "6"
        Me.rdgPreferredVideoSize7.Text = "352x288"
        Me.rdgPreferredVideoSize7.UseVisualStyleBackColor = False
        '
        'rdgPreferredVideoSize10
        '
        Me.rdgPreferredVideoSize10.BackColor = System.Drawing.SystemColors.Control
        Me.rdgPreferredVideoSize10.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgPreferredVideoSize10.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgPreferredVideoSize10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgPreferredVideoSize10.Location = New System.Drawing.Point(104, 28)
        Me.rdgPreferredVideoSize10.Name = "rdgPreferredVideoSize10"
        Me.rdgPreferredVideoSize10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgPreferredVideoSize10.Size = New System.Drawing.Size(74, 15)
        Me.rdgPreferredVideoSize10.TabIndex = 12
        Me.rdgPreferredVideoSize10.TabStop = True
        Me.rdgPreferredVideoSize10.Tag = "7"
        Me.rdgPreferredVideoSize10.Text = "640x480"
        Me.rdgPreferredVideoSize10.UseVisualStyleBackColor = False
        '
        'rdgPreferredVideoSize11
        '
        Me.rdgPreferredVideoSize11.BackColor = System.Drawing.SystemColors.Control
        Me.rdgPreferredVideoSize11.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgPreferredVideoSize11.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgPreferredVideoSize11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgPreferredVideoSize11.Location = New System.Drawing.Point(104, 42)
        Me.rdgPreferredVideoSize11.Name = "rdgPreferredVideoSize11"
        Me.rdgPreferredVideoSize11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgPreferredVideoSize11.Size = New System.Drawing.Size(74, 15)
        Me.rdgPreferredVideoSize11.TabIndex = 11
        Me.rdgPreferredVideoSize11.TabStop = True
        Me.rdgPreferredVideoSize11.Tag = "8"
        Me.rdgPreferredVideoSize11.Text = "720x480"
        Me.rdgPreferredVideoSize11.UseVisualStyleBackColor = False
        '
        'chkStretchPreferredVideoSize
        '
        Me.chkStretchPreferredVideoSize.BackColor = System.Drawing.SystemColors.Control
        Me.chkStretchPreferredVideoSize.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkStretchPreferredVideoSize.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkStretchPreferredVideoSize.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkStretchPreferredVideoSize.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkStretchPreferredVideoSize.Location = New System.Drawing.Point(116, 84)
        Me.chkStretchPreferredVideoSize.Name = "chkStretchPreferredVideoSize"
        Me.chkStretchPreferredVideoSize.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkStretchPreferredVideoSize.Size = New System.Drawing.Size(74, 18)
        Me.chkStretchPreferredVideoSize.TabIndex = 10
        Me.chkStretchPreferredVideoSize.Text = "stretch"
        Me.chkStretchPreferredVideoSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkStretchPreferredVideoSize.UseVisualStyleBackColor = False
        '
        'rdgPreferredVideoSize12
        '
        Me.rdgPreferredVideoSize12.BackColor = System.Drawing.SystemColors.Control
        Me.rdgPreferredVideoSize12.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgPreferredVideoSize12.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgPreferredVideoSize12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgPreferredVideoSize12.Location = New System.Drawing.Point(104, 56)
        Me.rdgPreferredVideoSize12.Name = "rdgPreferredVideoSize12"
        Me.rdgPreferredVideoSize12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgPreferredVideoSize12.Size = New System.Drawing.Size(74, 15)
        Me.rdgPreferredVideoSize12.TabIndex = 9
        Me.rdgPreferredVideoSize12.TabStop = True
        Me.rdgPreferredVideoSize12.Tag = "9"
        Me.rdgPreferredVideoSize12.Text = "720x576"
        Me.rdgPreferredVideoSize12.UseVisualStyleBackColor = False
        '
        'rdgPreferredVideoSize13
        '
        Me.rdgPreferredVideoSize13.BackColor = System.Drawing.SystemColors.Control
        Me.rdgPreferredVideoSize13.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgPreferredVideoSize13.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgPreferredVideoSize13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgPreferredVideoSize13.Location = New System.Drawing.Point(104, 70)
        Me.rdgPreferredVideoSize13.Name = "rdgPreferredVideoSize13"
        Me.rdgPreferredVideoSize13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgPreferredVideoSize13.Size = New System.Drawing.Size(74, 15)
        Me.rdgPreferredVideoSize13.TabIndex = 8
        Me.rdgPreferredVideoSize13.TabStop = True
        Me.rdgPreferredVideoSize13.Tag = "10"
        Me.rdgPreferredVideoSize13.Text = "768x576"
        Me.rdgPreferredVideoSize13.UseVisualStyleBackColor = False
        '
        'grbVideoDevicesDialogs
        '
        Me.grbVideoDevicesDialogs.BackColor = System.Drawing.SystemColors.Control
        Me.grbVideoDevicesDialogs.Controls.Add(Me.btnDVCamcorderControl)
        Me.grbVideoDevicesDialogs.Controls.Add(Me.btnSpecialControls)
        Me.grbVideoDevicesDialogs.Controls.Add(Me.btnDeviceDialog)
        Me.grbVideoDevicesDialogs.Controls.Add(Me.btnStreamDialog)
        Me.grbVideoDevicesDialogs.Controls.Add(Me.btnCameraControlDialog)
        Me.grbVideoDevicesDialogs.Controls.Add(Me.btnVideoQualityDialog)
        Me.grbVideoDevicesDialogs.Controls.Add(Me.btnVideoControlDialog)
        Me.grbVideoDevicesDialogs.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbVideoDevicesDialogs.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grbVideoDevicesDialogs.Location = New System.Drawing.Point(788, 0)
        Me.grbVideoDevicesDialogs.Name = "grbVideoDevicesDialogs"
        Me.grbVideoDevicesDialogs.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grbVideoDevicesDialogs.Size = New System.Drawing.Size(121, 180)
        Me.grbVideoDevicesDialogs.TabIndex = 1
        Me.grbVideoDevicesDialogs.TabStop = False
        Me.grbVideoDevicesDialogs.Text = "video device dialogs"
        '
        'btnDVCamcorderControl
        '
        Me.btnDVCamcorderControl.Location = New System.Drawing.Point(16, 153)
        Me.btnDVCamcorderControl.Name = "btnDVCamcorderControl"
        Me.btnDVCamcorderControl.Size = New System.Drawing.Size(88, 20)
        Me.btnDVCamcorderControl.TabIndex = 48
        Me.btnDVCamcorderControl.Text = "DV camcorder"
        '
        'btnSpecialControls
        '
        Me.btnSpecialControls.BackColor = System.Drawing.SystemColors.Control
        Me.btnSpecialControls.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSpecialControls.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpecialControls.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSpecialControls.Location = New System.Drawing.Point(16, 130)
        Me.btnSpecialControls.Name = "btnSpecialControls"
        Me.btnSpecialControls.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSpecialControls.Size = New System.Drawing.Size(88, 20)
        Me.btnSpecialControls.TabIndex = 7
        Me.btnSpecialControls.Text = "special controls"
        Me.btnSpecialControls.UseVisualStyleBackColor = False
        '
        'btnDeviceDialog
        '
        Me.btnDeviceDialog.BackColor = System.Drawing.SystemColors.Control
        Me.btnDeviceDialog.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDeviceDialog.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeviceDialog.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDeviceDialog.Location = New System.Drawing.Point(16, 15)
        Me.btnDeviceDialog.Name = "btnDeviceDialog"
        Me.btnDeviceDialog.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnDeviceDialog.Size = New System.Drawing.Size(88, 20)
        Me.btnDeviceDialog.TabIndex = 6
        Me.btnDeviceDialog.Text = "device"
        Me.btnDeviceDialog.UseVisualStyleBackColor = False
        '
        'btnStreamDialog
        '
        Me.btnStreamDialog.BackColor = System.Drawing.SystemColors.Control
        Me.btnStreamDialog.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnStreamDialog.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStreamDialog.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnStreamDialog.Location = New System.Drawing.Point(16, 38)
        Me.btnStreamDialog.Name = "btnStreamDialog"
        Me.btnStreamDialog.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnStreamDialog.Size = New System.Drawing.Size(88, 20)
        Me.btnStreamDialog.TabIndex = 5
        Me.btnStreamDialog.Text = "stream"
        Me.btnStreamDialog.UseVisualStyleBackColor = False
        '
        'btnCameraControlDialog
        '
        Me.btnCameraControlDialog.BackColor = System.Drawing.SystemColors.Control
        Me.btnCameraControlDialog.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCameraControlDialog.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCameraControlDialog.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCameraControlDialog.Location = New System.Drawing.Point(16, 61)
        Me.btnCameraControlDialog.Name = "btnCameraControlDialog"
        Me.btnCameraControlDialog.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCameraControlDialog.Size = New System.Drawing.Size(88, 20)
        Me.btnCameraControlDialog.TabIndex = 4
        Me.btnCameraControlDialog.Text = "camera control"
        Me.btnCameraControlDialog.UseVisualStyleBackColor = False
        '
        'btnVideoQualityDialog
        '
        Me.btnVideoQualityDialog.BackColor = System.Drawing.SystemColors.Control
        Me.btnVideoQualityDialog.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnVideoQualityDialog.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVideoQualityDialog.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnVideoQualityDialog.Location = New System.Drawing.Point(16, 84)
        Me.btnVideoQualityDialog.Name = "btnVideoQualityDialog"
        Me.btnVideoQualityDialog.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnVideoQualityDialog.Size = New System.Drawing.Size(88, 20)
        Me.btnVideoQualityDialog.TabIndex = 3
        Me.btnVideoQualityDialog.Text = "video quality"
        Me.btnVideoQualityDialog.UseVisualStyleBackColor = False
        '
        'btnVideoControlDialog
        '
        Me.btnVideoControlDialog.BackColor = System.Drawing.SystemColors.Control
        Me.btnVideoControlDialog.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnVideoControlDialog.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVideoControlDialog.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnVideoControlDialog.Location = New System.Drawing.Point(16, 107)
        Me.btnVideoControlDialog.Name = "btnVideoControlDialog"
        Me.btnVideoControlDialog.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnVideoControlDialog.Size = New System.Drawing.Size(88, 20)
        Me.btnVideoControlDialog.TabIndex = 2
        Me.btnVideoControlDialog.Text = "video control"
        Me.btnVideoControlDialog.UseVisualStyleBackColor = False
        '
        'btnAutoRefreshPreview
        '
        Me.btnAutoRefreshPreview.BackColor = System.Drawing.SystemColors.Control
        Me.btnAutoRefreshPreview.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnAutoRefreshPreview.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAutoRefreshPreview.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAutoRefreshPreview.Location = New System.Drawing.Point(434, 16)
        Me.btnAutoRefreshPreview.Name = "btnAutoRefreshPreview"
        Me.btnAutoRefreshPreview.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnAutoRefreshPreview.Size = New System.Drawing.Size(128, 17)
        Me.btnAutoRefreshPreview.TabIndex = 0
        Me.btnAutoRefreshPreview.Text = "Auto refresh preview"
        Me.btnAutoRefreshPreview.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label11.Location = New System.Drawing.Point(432, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(340, 14)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "use FindIndexInListByName to programmatically select an item in a list"
        '
        'chkReduceDVFrameRate
        '
        Me.chkReduceDVFrameRate.BackColor = System.Drawing.SystemColors.Control
        Me.chkReduceDVFrameRate.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkReduceDVFrameRate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkReduceDVFrameRate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkReduceDVFrameRate.Location = New System.Drawing.Point(434, 31)
        Me.chkReduceDVFrameRate.Name = "chkReduceDVFrameRate"
        Me.chkReduceDVFrameRate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkReduceDVFrameRate.Size = New System.Drawing.Size(113, 17)
        Me.chkReduceDVFrameRate.TabIndex = 47
        Me.chkReduceDVFrameRate.Text = "half DV frame rate"
        Me.chkReduceDVFrameRate.UseVisualStyleBackColor = False
        '
        'VideoSource
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(919, 204)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.chkReduceDVFrameRate)
        Me.Controls.Add(Me.grbVideoSource)
        Me.Controls.Add(Me.grbPreview)
        Me.Controls.Add(Me.grbFrameRate)
        Me.Controls.Add(Me.grbVsVideoCaptureDevice)
        Me.Controls.Add(Me.grbVsFileOrUrl)
        Me.Controls.Add(Me.grbVsScreenRecording)
        Me.Controls.Add(Me.grbPreferredVideoSizes)
        Me.Controls.Add(Me.grbVideoDevicesDialogs)
        Me.Controls.Add(Me.btnAutoRefreshPreview)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(4, 23)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VideoSource"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.grbVideoSource.ResumeLayout(False)
        Me.grbPreview.ResumeLayout(False)
        Me.grbFrameRate.ResumeLayout(False)
        Me.grbFrameRate.PerformLayout()
        Me.grbVsVideoCaptureDevice.ResumeLayout(False)
        Me.grbVsVideoCaptureDevice.PerformLayout()
        Me.grbMultiplexedInputs.ResumeLayout(False)
        Me.grbVsFileOrUrl.ResumeLayout(False)
        Me.grbVsFileOrUrl.PerformLayout()
        Me.grbVsScreenRecording.ResumeLayout(False)
        Me.grbVsScreenRecording.PerformLayout()
        Me.grbPreferredVideoSizes.ResumeLayout(False)
        Me.grbVideoDevicesDialogs.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region
    Public frmMiscCameraControl As miscCameraControl
    Public frmMiscVideoQuality As miscVideoQuality
    Public frmMiscVideoControl As miscVideoControl
    Public frmMiscSpecialControl As miscSpecialControl
    Public frmMiscDVCommands As miscDVCommands

    Public Sub RefreshControls()
        AssignListToComboBox(cboVideoSource, MainForm.DefInstance.AxVideoGrabberNET1.VideoSources, MainForm.DefInstance.AxVideoGrabberNET1.VideoSource, 5)
        AssignListToComboBox(cboVideoDevices, MainForm.DefInstance.AxVideoGrabberNET1.VideoDevices, MainForm.DefInstance.AxVideoGrabberNET1.VideoDevice)

        If MainForm.DefInstance.AxVideoGrabberNET1.VideoDevice >= 0 Then ' if a video capture device has been selected
            AssignListToComboBox(cboAnalogVideoStandard, MainForm.DefInstance.AxVideoGrabberNET1.AnalogVideoStandards, MainForm.DefInstance.AxVideoGrabberNET1.AnalogVideoStandard)
            AssignListToComboBox(cboVideoSizes, MainForm.DefInstance.AxVideoGrabberNET1.VideoSizes, MainForm.DefInstance.AxVideoGrabberNET1.VideoSize)
            AssignListToComboBox(cboVideoSubtypes, MainForm.DefInstance.AxVideoGrabberNET1.VideoSubtypes, MainForm.DefInstance.AxVideoGrabberNET1.VideoSubtype)
            AssignListToComboBox(cboVideoInputs, MainForm.DefInstance.AxVideoGrabberNET1.VideoInputs, MainForm.DefInstance.AxVideoGrabberNET1.VideoInput)
        End If

        cboAnalogVideoStandard.Enabled = MainForm.DefInstance.AxVideoGrabberNET1.IsAnalogVideoDecoderAvailable
        cboVideoInputs.Enabled = MainForm.DefInstance.AxVideoGrabberNET1.IsVideoCrossbarAvailable

        btnAutoRefreshPreview.Checked = MainForm.DefInstance.AxVideoGrabberNET1.AutoRefreshPreview

        cboVideoSource.SelectedIndex = MainForm.DefInstance.AxVideoGrabberNET1.VideoSource

        chkScreenRecordingWithCursor.Checked = MainForm.DefInstance.AxVideoGrabberNET1.ScreenRecordingWithCursor
        edtMonitorNumber.Text = MainForm.DefInstance.AxVideoGrabberNET1.ScreenRecordingMonitor.ToString()

        chkReduceDVFrameRate.Checked = MainForm.DefInstance.AxVideoGrabberNET1.DVReduceFrameRate
        chkReduceDVFrameRate.Enabled = MainForm.DefInstance.AxVideoGrabberNET1.IsDigitalVideoIn

        btnStreamDialog.Enabled = Not MainForm.DefInstance.AxVideoGrabberNET1.IsDigitalVideoIn
        btnCameraControlDialog.Enabled = MainForm.DefInstance.AxVideoGrabberNET1.IsCameraControlAvailable
        btnVideoQualityDialog.Enabled = MainForm.DefInstance.AxVideoGrabberNET1.IsVideoQualityAvailable
        btnVideoControlDialog.Enabled = MainForm.DefInstance.AxVideoGrabberNET1.IsVideoControlAvailable

        edtFrameRate.Text = MainForm.DefInstance.AxVideoGrabberNET1.FrameRate.ToString("0.00")

        If Not (frmMiscCameraControl Is Nothing) Then frmMiscCameraControl.RefreshControls()
        If Not (frmMiscVideoQuality Is Nothing) Then frmMiscVideoQuality.RefreshControls()
        If Not (frmMiscVideoControl Is Nothing) Then frmMiscVideoControl.RefreshControls()
        If Not (frmMiscSpecialControl Is Nothing) Then frmMiscSpecialControl.RefreshControls()
        If Not (frmMiscDVCommands Is Nothing) Then frmMiscDVCommands.RefreshControls()
    End Sub

    Private Sub VideoSource_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmMiscCameraControl = New miscCameraControl
        frmMiscVideoQuality = New miscVideoQuality
        frmMiscVideoControl = New miscVideoControl
        frmMiscSpecialControl = New miscSpecialControl
        frmMiscDVCommands = New miscDVCommands
    End Sub

    Private Sub btnAutoRefreshPreview_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAutoRefreshPreview.CheckedChanged
        MainForm.DefInstance.AxVideoGrabberNET1.AutoRefreshPreview = btnAutoRefreshPreview.Checked
    End Sub

    Private Sub btnDeviceDialog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeviceDialog.Click
        MainForm.DefInstance.AxVideoGrabberNET1.ShowDialog(Vidgrab_NET.TxDialog.dlg_VideoDevice)
        MainForm.DefInstance.RefreshControls()
    End Sub

    Private Sub btnFrameRate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFrameRate.Click
        If IsNumeric(edtFrameRate.Text) Then
            MainForm.DefInstance.AxVideoGrabberNET1.FrameRate = Convert.ToDouble(edtFrameRate.Text)

            If MainForm.DefInstance.AxVideoGrabberNET1.CurrentState = Vidgrab_NET.TxCurrentState.cs_Preview Then
                AddLog((MainForm.DefInstance.mmoLog), "current frame rate: " & MainForm.DefInstance.AxVideoGrabberNET1.CurrentFrameRate.ToString("0.00") & " fps.")
            End If
        End If
    End Sub

    Private Sub btnFrameRateHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFrameRateHelp.Click

        MessageBox.Show("""0"" means that the default frame rate of the device will be used." & vbCrLf & vbCrLf & _
                "After the OnPreviewStarted or OnRecordingStarted event occurs," & vbCrLf & _
                "its value is available in the CurrentFrameRate property.", _
                "DataStead TVideoGrabber VB.NET OCX Demo", MessageBoxButtons.OK)

    End Sub

    Private Sub btnSelectFileOrUrl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectFileOrUrl.Click
        Dim dlgOpen As OpenFileDialog = New OpenFileDialog

        dlgOpen.Filter = OPEN_MEDIA_FILES
        If dlgOpen.ShowDialog = Windows.Forms.DialogResult.OK Then
            edtVideoSourceFileOrUrl.Text = dlgOpen.FileName
        End If
    End Sub

    Private Sub btnDemoUrl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDemoUrl.Click
        edtVideoSourceFileOrUrl.Text = "mms://www.datastead.com/demo/demo.wmv"
    End Sub

    Private Sub btnStartPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartPreview.Click
        MainForm.DefInstance.AxVideoGrabberNET1.StartPreview()
    End Sub

    Private Sub btnStopPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStopPreview.Click
        MainForm.DefInstance.AxVideoGrabberNET1.StopPreview()
    End Sub

    Private Sub btnStreamDialog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStreamDialog.Click
        ' WARNING: USUALLY, THIS DIALOG ALLOWS TO CHANGE ONLY 1 PARAMETER AT THE SAME TIME
        MainForm.DefInstance.AxVideoGrabberNET1.ShowDialog(Vidgrab_NET.TxDialog.dlg_StreamConfig)
        MainForm.DefInstance.AxVideoGrabberNET1.VideoDevice = MainForm.DefInstance.AxVideoGrabberNET1.VideoDevice
    End Sub

    Private Sub cboVideoSource_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboVideoSource.SelectedIndexChanged
        If cboVideoSource.SelectedIndex < 5 Then
            MainForm.DefInstance.AxVideoGrabberNET1.VideoSource = cboVideoSource.SelectedIndex
        Else
            AddLog((MainForm.DefInstance.mmoLog), "this option is not demonstrated in this demo")
        End If
    End Sub

    Private Sub cboAnalogVideoStandard_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAnalogVideoStandard.SelectedIndexChanged
        MainForm.DefInstance.AxVideoGrabberNET1.AnalogVideoStandard = cboAnalogVideoStandard.SelectedIndex
    End Sub

    Private Sub cboVideoDevices_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboVideoDevices.SelectedIndexChanged
        MainForm.DefInstance.AxVideoGrabberNET1.VideoDevice = cboVideoDevices.SelectedIndex
        ' when selecting another video device, the OnVideoDeviceSelected event occurs.
        ' From this event we invoke RefreshControls to to refresh all the device-dependent controls.
    End Sub

    Private Sub cboVideoInputs_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboVideoInputs.SelectedIndexChanged
        MainForm.DefInstance.AxVideoGrabberNET1.VideoInput = cboVideoInputs.SelectedIndex
    End Sub

    Private Sub cboVideoSizes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboVideoSizes.SelectedIndexChanged
        MainForm.DefInstance.AxVideoGrabberNET1.VideoSize = cboVideoSizes.SelectedIndex
    End Sub

    Private Sub cboVideoSubtypes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboVideoSubtypes.SelectedIndexChanged
        MainForm.DefInstance.AxVideoGrabberNET1.VideoSubtype = cboVideoSubtypes.SelectedIndex
    End Sub

    Private Sub chkReduceDVFrameRate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkReduceDVFrameRate.CheckedChanged
        MainForm.DefInstance.AxVideoGrabberNET1.DVReduceFrameRate = chkReduceDVFrameRate.Checked
    End Sub

    Private Sub btnScreenRecordingWindow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnScreenRecordingWindow.Click

        MainForm.DefInstance.AxVideoGrabberNET1.SetWindowRecordingByName(edtScreenRecordingWindow.Text, chkScreenRecordingWindow.Checked)  ' exactMatch "true" for an exact and case-sensitive match
        '
        ' recording window may be designated by name, class or handle by calling EnumerateWindows, which
        '  causes visible window info to be returned in the OnEnumerateWindows event
        ' recording window may then be set by handle rather than name with SetWindowRecordingByHandle
        '
        MainForm.DefInstance.SetEnumerateWindows(edtScreenRecordingWindow.Text, (chkScreenRecordingWindow.Checked))
        If strScreenRecordingWindow <> "" Then
            MainForm.DefInstance.AxVideoGrabberNET1.EnumerateWindows()
        End If

    End Sub

    Private Sub chkScreenRecordingWithCursor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkScreenRecordingWithCursor.CheckedChanged
        MainForm.DefInstance.AxVideoGrabberNET1.ScreenRecordingWithCursor = chkScreenRecordingWithCursor.Checked
    End Sub

    Private Sub edtMonitorNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtMonitorNumber.TextChanged
        If IsNumeric(edtMonitorNumber.Text) Then
            MainForm.DefInstance.AxVideoGrabberNET1.ScreenRecordingMonitor = Convert.ToInt32(edtMonitorNumber.Text)
        End If
    End Sub

    Private Sub btnMonitorNumberInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMonitorNumberInfo.Click
        MessageBox.Show("  -1 = whole desktop (across monitors)     0 = 1st monitor (default)    1 = 2nd monitor    etc...", _
                "DataStead TVideoGrabber VB.NET OCX Demo", MessageBoxButtons.OK)
    End Sub

    Private Sub edtVideoSourceFileOrUrl_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtVideoSourceFileOrUrl.TextChanged
        MainForm.DefInstance.AxVideoGrabberNET1.VideoSource_FileOrURL = edtVideoSourceFileOrUrl.Text
    End Sub

    Private Sub edtSourceFileOrUrlUserName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtSourceFileOrUrlUserName.TextChanged
        MainForm.DefInstance.AxVideoGrabberNET1.SetAuthentication(Vidgrab_NET.TxAuthenticationType.at_StreamingUrl, edtSourceFileOrUrlUserName.Text, edtSourceFileOrUrlPassword.Text)
    End Sub

    Private Sub edtSourceFileOrUrlPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtSourceFileOrUrlPassword.TextChanged
        MainForm.DefInstance.AxVideoGrabberNET1.SetAuthentication(Vidgrab_NET.TxAuthenticationType.at_StreamingUrl, edtSourceFileOrUrlUserName.Text, edtSourceFileOrUrlPassword.Text)
    End Sub

    Private Sub rdgPreferredVideoSize_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgPreferredVideoSize1.CheckedChanged, rdgPreferredVideoSize2.CheckedChanged, rdgPreferredVideoSize3.CheckedChanged, rdgPreferredVideoSize4.CheckedChanged, rdgPreferredVideoSize5.CheckedChanged, rdgPreferredVideoSize6.CheckedChanged, rdgPreferredVideoSize7.CheckedChanged, rdgPreferredVideoSize10.CheckedChanged, rdgPreferredVideoSize11.CheckedChanged, rdgPreferredVideoSize12.CheckedChanged
        Dim w, h As Integer

        If CType(sender, RadioButton).Checked Then
            Select Case sender.tag
                Case 0
                    w = 0
                    h = 0
                Case 1
                    w = 88
                    h = 60
                Case 2
                    w = 88
                    h = 72
                Case 3
                    w = 180
                    h = 120
                Case 4
                    w = 180
                    h = 144
                Case 5
                    w = 320
                    h = 240
                Case 6
                    w = 352
                    h = 288
                Case 7
                    w = 640
                    h = 480
                Case 8
                    w = 720
                    h = 480
                Case 9
                    w = 720
                    h = 576
                Case 10
                    w = 768
                    h = 576
            End Select
            MainForm.DefInstance.AxVideoGrabberNET1.UseNearestVideoSize(w, h, chkStretchPreferredVideoSize.Checked) ' disables the nearest size feature, uses the device's VideoSize index in the VideoSizes list
            cboVideoSizes.Enabled = True
        End If
    End Sub

    Private Sub chk4InputsLayout_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk4InputsLayout.CheckedChanged
        If chk4InputsLayout.Checked Then
            MainForm.DefInstance.AxVideoGrabberNET1.MultiplexedRole = Vidgrab_NET.TxMultiplexedRole.mr_MultiplexedMosaic4
        Else
            MainForm.DefInstance.AxVideoGrabberNET1.MultiplexedRole = Vidgrab_NET.TxMultiplexedRole.mr_NotMultiplexed
        End If
    End Sub

    Private Sub chkMultiplexedInputEmulation_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMultiplexedInputEmulation.CheckedChanged
        MainForm.DefInstance.AxVideoGrabberNET1.MultiplexedInputEmulation = chk4InputsLayout.Checked
    End Sub

    Private Sub btnSpecialControls_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSpecialControls.Click
        frmMiscSpecialControl.Show()
    End Sub

    Private Sub btnVideoControlDialog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVideoControlDialog.Click
        frmMiscVideoControl.Show()
    End Sub

    Private Sub btnVideoQualityDialog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVideoQualityDialog.Click
        frmMiscVideoQuality.Show()
    End Sub

    Private Sub btnCameraControlDialog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCameraControlDialog.Click
        frmMiscCameraControl.Show()
    End Sub

    Private Sub btnDVCamcorderControl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDVCamcorderControl.Click
        frmMiscDVCommands.Show()
    End Sub

    Private Sub VideoSource_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        If Visible Then
            RefreshControls()
        End If
    End Sub

    Private Sub chkReduceDVFrameRate_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkReduceDVFrameRate.CheckedChanged

    End Sub

End Class
