Option Strict Off
Option Explicit On 
Friend Class Audio
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
    Public WithEvents chkMuteAudioRendering As System.Windows.Forms.CheckBox
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents grbAudioRendering As System.Windows.Forms.GroupBox
    Public WithEvents cboAudioDevices As System.Windows.Forms.ComboBox
    Public WithEvents cboAudioInputs As System.Windows.Forms.ComboBox
    Public WithEvents chkAudioInputMono As System.Windows.Forms.CheckBox
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents grbAudioCaptureDevice As System.Windows.Forms.GroupBox
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Public WithEvents tbrAudioVolume As System.Windows.Forms.TrackBar
    Public WithEvents tbrAudioBalance As System.Windows.Forms.TrackBar
    Public WithEvents tbrAudioInputLevel As System.Windows.Forms.TrackBar
    Public WithEvents tbrAudioInputBalance As System.Windows.Forms.TrackBar
    Friend WithEvents cboAudioRenderers As System.Windows.Forms.ComboBox
    Friend WithEvents grbVuMeters As System.Windows.Forms.GroupBox
    Friend WithEvents rdgVUDisabled As System.Windows.Forms.RadioButton
    Friend WithEvents rdgVUAnalog As System.Windows.Forms.RadioButton
    Friend WithEvents rdgVUBargraph As System.Windows.Forms.RadioButton
    Friend WithEvents pnlVUMeterLeft As System.Windows.Forms.Panel
    Friend WithEvents pnlVUMeterRight As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnStartAudioRendering As System.Windows.Forms.Button
    Friend WithEvents btnStartWavRecording As System.Windows.Forms.Button
    Friend WithEvents btnSartMP3Recording As System.Windows.Forms.Button
    Friend WithEvents btnStartWMVRecording As System.Windows.Forms.Button
    Friend WithEvents btnStopAudio As System.Windows.Forms.Button
    Friend WithEvents chkUseAudioOfVideoCaptureDevice As System.Windows.Forms.CheckBox
    Public WithEvents chkRenderAudioDevice As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAudioDeviceDialog As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.grbAudioRendering = New System.Windows.Forms.GroupBox
        Me.cboAudioRenderers = New System.Windows.Forms.ComboBox
        Me.tbrAudioVolume = New System.Windows.Forms.TrackBar
        Me.tbrAudioBalance = New System.Windows.Forms.TrackBar
        Me.chkMuteAudioRendering = New System.Windows.Forms.CheckBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.grbAudioCaptureDevice = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnAudioDeviceDialog = New System.Windows.Forms.Button
        Me.tbrAudioInputLevel = New System.Windows.Forms.TrackBar
        Me.tbrAudioInputBalance = New System.Windows.Forms.TrackBar
        Me.cboAudioDevices = New System.Windows.Forms.ComboBox
        Me.cboAudioInputs = New System.Windows.Forms.ComboBox
        Me.chkAudioInputMono = New System.Windows.Forms.CheckBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.grbVuMeters = New System.Windows.Forms.GroupBox
        Me.rdgVUBargraph = New System.Windows.Forms.RadioButton
        Me.rdgVUAnalog = New System.Windows.Forms.RadioButton
        Me.rdgVUDisabled = New System.Windows.Forms.RadioButton
        Me.pnlVUMeterLeft = New System.Windows.Forms.Panel
        Me.pnlVUMeterRight = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnStopAudio = New System.Windows.Forms.Button
        Me.btnStartWMVRecording = New System.Windows.Forms.Button
        Me.btnSartMP3Recording = New System.Windows.Forms.Button
        Me.btnStartWavRecording = New System.Windows.Forms.Button
        Me.btnStartAudioRendering = New System.Windows.Forms.Button
        Me.chkUseAudioOfVideoCaptureDevice = New System.Windows.Forms.CheckBox
        Me.chkRenderAudioDevice = New System.Windows.Forms.CheckBox
        Me.grbAudioRendering.SuspendLayout()
        CType(Me.tbrAudioVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbrAudioBalance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbAudioCaptureDevice.SuspendLayout()
        CType(Me.tbrAudioInputLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbrAudioInputBalance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbVuMeters.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbAudioRendering
        '
        Me.grbAudioRendering.BackColor = System.Drawing.SystemColors.Control
        Me.grbAudioRendering.Controls.Add(Me.cboAudioRenderers)
        Me.grbAudioRendering.Controls.Add(Me.tbrAudioVolume)
        Me.grbAudioRendering.Controls.Add(Me.tbrAudioBalance)
        Me.grbAudioRendering.Controls.Add(Me.chkMuteAudioRendering)
        Me.grbAudioRendering.Controls.Add(Me.Label5)
        Me.grbAudioRendering.Controls.Add(Me.Label6)
        Me.grbAudioRendering.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbAudioRendering.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grbAudioRendering.Location = New System.Drawing.Point(636, 48)
        Me.grbAudioRendering.Name = "grbAudioRendering"
        Me.grbAudioRendering.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grbAudioRendering.Size = New System.Drawing.Size(273, 127)
        Me.grbAudioRendering.TabIndex = 10
        Me.grbAudioRendering.TabStop = False
        Me.grbAudioRendering.Text = "audio rendering"
        '
        'cboAudioRenderers
        '
        Me.cboAudioRenderers.Location = New System.Drawing.Point(65, 15)
        Me.cboAudioRenderers.Name = "cboAudioRenderers"
        Me.cboAudioRenderers.Size = New System.Drawing.Size(202, 22)
        Me.cboAudioRenderers.TabIndex = 18
        Me.cboAudioRenderers.Text = "default (AudioRenderer = -1)"
        '
        'tbrAudioVolume
        '
        Me.tbrAudioVolume.AutoSize = False
        Me.tbrAudioVolume.Location = New System.Drawing.Point(12, 56)
        Me.tbrAudioVolume.Maximum = 65535
        Me.tbrAudioVolume.Name = "tbrAudioVolume"
        Me.tbrAudioVolume.Size = New System.Drawing.Size(255, 18)
        Me.tbrAudioVolume.TabIndex = 17
        Me.tbrAudioVolume.TickFrequency = 7300
        '
        'tbrAudioBalance
        '
        Me.tbrAudioBalance.AutoSize = False
        Me.tbrAudioBalance.Location = New System.Drawing.Point(12, 95)
        Me.tbrAudioBalance.Maximum = 32767
        Me.tbrAudioBalance.Minimum = -32768
        Me.tbrAudioBalance.Name = "tbrAudioBalance"
        Me.tbrAudioBalance.Size = New System.Drawing.Size(255, 18)
        Me.tbrAudioBalance.TabIndex = 17
        Me.tbrAudioBalance.TickFrequency = 7300
        '
        'chkMuteAudioRendering
        '
        Me.chkMuteAudioRendering.BackColor = System.Drawing.SystemColors.Control
        Me.chkMuteAudioRendering.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkMuteAudioRendering.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMuteAudioRendering.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkMuteAudioRendering.Location = New System.Drawing.Point(12, 17)
        Me.chkMuteAudioRendering.Name = "chkMuteAudioRendering"
        Me.chkMuteAudioRendering.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkMuteAudioRendering.Size = New System.Drawing.Size(66, 18)
        Me.chkMuteAudioRendering.TabIndex = 12
        Me.chkMuteAudioRendering.Text = "mute"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(16, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(97, 17)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "volume"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(16, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(97, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "balance"
        '
        'grbAudioCaptureDevice
        '
        Me.grbAudioCaptureDevice.BackColor = System.Drawing.SystemColors.Control
        Me.grbAudioCaptureDevice.Controls.Add(Me.Label2)
        Me.grbAudioCaptureDevice.Controls.Add(Me.btnAudioDeviceDialog)
        Me.grbAudioCaptureDevice.Controls.Add(Me.tbrAudioInputLevel)
        Me.grbAudioCaptureDevice.Controls.Add(Me.tbrAudioInputBalance)
        Me.grbAudioCaptureDevice.Controls.Add(Me.cboAudioDevices)
        Me.grbAudioCaptureDevice.Controls.Add(Me.cboAudioInputs)
        Me.grbAudioCaptureDevice.Controls.Add(Me.chkAudioInputMono)
        Me.grbAudioCaptureDevice.Controls.Add(Me.Label7)
        Me.grbAudioCaptureDevice.Controls.Add(Me.Label8)
        Me.grbAudioCaptureDevice.Controls.Add(Me.Label9)
        Me.grbAudioCaptureDevice.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbAudioCaptureDevice.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grbAudioCaptureDevice.Location = New System.Drawing.Point(4, 32)
        Me.grbAudioCaptureDevice.Name = "grbAudioCaptureDevice"
        Me.grbAudioCaptureDevice.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grbAudioCaptureDevice.Size = New System.Drawing.Size(321, 143)
        Me.grbAudioCaptureDevice.TabIndex = 0
        Me.grbAudioCaptureDevice.TabStop = False
        Me.grbAudioCaptureDevice.Text = "Audio capture device"
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label2.Location = New System.Drawing.Point(7, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(307, 28)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "to programmatically select an item by name in a list, use the FindIndexInListByNa" & _
            "me function"
        '
        'btnAudioDeviceDialog
        '
        Me.btnAudioDeviceDialog.Location = New System.Drawing.Point(230, 38)
        Me.btnAudioDeviceDialog.Name = "btnAudioDeviceDialog"
        Me.btnAudioDeviceDialog.Size = New System.Drawing.Size(80, 23)
        Me.btnAudioDeviceDialog.TabIndex = 19
        Me.btnAudioDeviceDialog.Text = "device dialog"
        '
        'tbrAudioInputLevel
        '
        Me.tbrAudioInputLevel.AutoSize = False
        Me.tbrAudioInputLevel.Location = New System.Drawing.Point(126, 93)
        Me.tbrAudioInputLevel.Maximum = 65535
        Me.tbrAudioInputLevel.Name = "tbrAudioInputLevel"
        Me.tbrAudioInputLevel.Size = New System.Drawing.Size(171, 18)
        Me.tbrAudioInputLevel.TabIndex = 17
        Me.tbrAudioInputLevel.TickFrequency = 7300
        '
        'tbrAudioInputBalance
        '
        Me.tbrAudioInputBalance.AutoSize = False
        Me.tbrAudioInputBalance.Location = New System.Drawing.Point(126, 117)
        Me.tbrAudioInputBalance.Maximum = 32767
        Me.tbrAudioInputBalance.Minimum = -32768
        Me.tbrAudioInputBalance.Name = "tbrAudioInputBalance"
        Me.tbrAudioInputBalance.Size = New System.Drawing.Size(171, 18)
        Me.tbrAudioInputBalance.TabIndex = 17
        Me.tbrAudioInputBalance.TickFrequency = 7300
        '
        'cboAudioDevices
        '
        Me.cboAudioDevices.BackColor = System.Drawing.SystemColors.Window
        Me.cboAudioDevices.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboAudioDevices.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAudioDevices.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboAudioDevices.Location = New System.Drawing.Point(79, 13)
        Me.cboAudioDevices.Name = "cboAudioDevices"
        Me.cboAudioDevices.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboAudioDevices.Size = New System.Drawing.Size(236, 22)
        Me.cboAudioDevices.TabIndex = 4
        Me.cboAudioDevices.Text = "SELECT AN AUDIO CAPTURE DEVICE IN THIS LIST"
        '
        'cboAudioInputs
        '
        Me.cboAudioInputs.BackColor = System.Drawing.SystemColors.Window
        Me.cboAudioInputs.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboAudioInputs.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAudioInputs.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboAudioInputs.Location = New System.Drawing.Point(8, 38)
        Me.cboAudioInputs.Name = "cboAudioInputs"
        Me.cboAudioInputs.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboAudioInputs.Size = New System.Drawing.Size(128, 22)
        Me.cboAudioInputs.TabIndex = 3
        '
        'chkAudioInputMono
        '
        Me.chkAudioInputMono.BackColor = System.Drawing.SystemColors.Control
        Me.chkAudioInputMono.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkAudioInputMono.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAudioInputMono.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkAudioInputMono.Location = New System.Drawing.Point(155, 41)
        Me.chkAudioInputMono.Name = "chkAudioInputMono"
        Me.chkAudioInputMono.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkAudioInputMono.Size = New System.Drawing.Size(56, 17)
        Me.chkAudioInputMono.TabIndex = 2
        Me.chkAudioInputMono.Text = "mono"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(8, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(65, 17)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "audio input"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(8, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(114, 18)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "audio input level"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(5, 111)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(117, 18)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "audio input balance"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'grbVuMeters
        '
        Me.grbVuMeters.Controls.Add(Me.rdgVUBargraph)
        Me.grbVuMeters.Controls.Add(Me.rdgVUAnalog)
        Me.grbVuMeters.Controls.Add(Me.rdgVUDisabled)
        Me.grbVuMeters.Location = New System.Drawing.Point(354, 48)
        Me.grbVuMeters.Name = "grbVuMeters"
        Me.grbVuMeters.Size = New System.Drawing.Size(249, 35)
        Me.grbVuMeters.TabIndex = 11
        Me.grbVuMeters.TabStop = False
        Me.grbVuMeters.Text = "VU-Meters"
        '
        'rdgVUBargraph
        '
        Me.rdgVUBargraph.Location = New System.Drawing.Point(166, 13)
        Me.rdgVUBargraph.Name = "rdgVUBargraph"
        Me.rdgVUBargraph.Size = New System.Drawing.Size(77, 18)
        Me.rdgVUBargraph.TabIndex = 2
        Me.rdgVUBargraph.Tag = "2"
        Me.rdgVUBargraph.Text = "bargraph"
        '
        'rdgVUAnalog
        '
        Me.rdgVUAnalog.Location = New System.Drawing.Point(95, 13)
        Me.rdgVUAnalog.Name = "rdgVUAnalog"
        Me.rdgVUAnalog.Size = New System.Drawing.Size(65, 18)
        Me.rdgVUAnalog.TabIndex = 1
        Me.rdgVUAnalog.Tag = "1"
        Me.rdgVUAnalog.Text = "analog"
        '
        'rdgVUDisabled
        '
        Me.rdgVUDisabled.Checked = True
        Me.rdgVUDisabled.Location = New System.Drawing.Point(12, 13)
        Me.rdgVUDisabled.Name = "rdgVUDisabled"
        Me.rdgVUDisabled.Size = New System.Drawing.Size(72, 18)
        Me.rdgVUDisabled.TabIndex = 0
        Me.rdgVUDisabled.TabStop = True
        Me.rdgVUDisabled.Tag = "0"
        Me.rdgVUDisabled.Text = "disabled"
        '
        'pnlVUMeterLeft
        '
        Me.pnlVUMeterLeft.AccessibleName = ""
        Me.pnlVUMeterLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlVUMeterLeft.Location = New System.Drawing.Point(354, 88)
        Me.pnlVUMeterLeft.Name = "pnlVUMeterLeft"
        Me.pnlVUMeterLeft.Size = New System.Drawing.Size(121, 81)
        Me.pnlVUMeterLeft.TabIndex = 12
        '
        'pnlVUMeterRight
        '
        Me.pnlVUMeterRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlVUMeterRight.Location = New System.Drawing.Point(482, 88)
        Me.pnlVUMeterRight.Name = "pnlVUMeterRight"
        Me.pnlVUMeterRight.Size = New System.Drawing.Size(121, 81)
        Me.pnlVUMeterRight.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnStopAudio)
        Me.GroupBox1.Controls.Add(Me.btnStartWMVRecording)
        Me.GroupBox1.Controls.Add(Me.btnSartMP3Recording)
        Me.GroupBox1.Controls.Add(Me.btnStartWavRecording)
        Me.GroupBox1.Controls.Add(Me.btnStartAudioRendering)
        Me.GroupBox1.Controls.Add(Me.chkUseAudioOfVideoCaptureDevice)
        Me.GroupBox1.Location = New System.Drawing.Point(332, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(577, 49)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "AUDIO rendering / recording / streaming ONLY  (you can activate the streaming in " & _
            "the ""network streaming"" tab)"
        '
        'btnStopAudio
        '
        Me.btnStopAudio.Location = New System.Drawing.Point(350, 18)
        Me.btnStopAudio.Name = "btnStopAudio"
        Me.btnStopAudio.Size = New System.Drawing.Size(50, 24)
        Me.btnStopAudio.TabIndex = 4
        Me.btnStopAudio.Text = "stop"
        '
        'btnStartWMVRecording
        '
        Me.btnStartWMVRecording.Location = New System.Drawing.Point(264, 18)
        Me.btnStartWMVRecording.Name = "btnStartWMVRecording"
        Me.btnStartWMVRecording.Size = New System.Drawing.Size(80, 24)
        Me.btnStartWMVRecording.TabIndex = 3
        Me.btnStartWMVRecording.Text = "record WMV"
        '
        'btnSartMP3Recording
        '
        Me.btnSartMP3Recording.Location = New System.Drawing.Point(186, 18)
        Me.btnSartMP3Recording.Name = "btnSartMP3Recording"
        Me.btnSartMP3Recording.Size = New System.Drawing.Size(72, 24)
        Me.btnSartMP3Recording.TabIndex = 2
        Me.btnSartMP3Recording.Text = "record MP3"
        '
        'btnStartWavRecording
        '
        Me.btnStartWavRecording.Location = New System.Drawing.Point(100, 18)
        Me.btnStartWavRecording.Name = "btnStartWavRecording"
        Me.btnStartWavRecording.Size = New System.Drawing.Size(80, 24)
        Me.btnStartWavRecording.TabIndex = 1
        Me.btnStartWavRecording.Text = "record WAV"
        '
        'btnStartAudioRendering
        '
        Me.btnStartAudioRendering.Location = New System.Drawing.Point(6, 18)
        Me.btnStartAudioRendering.Name = "btnStartAudioRendering"
        Me.btnStartAudioRendering.Size = New System.Drawing.Size(88, 24)
        Me.btnStartAudioRendering.TabIndex = 0
        Me.btnStartAudioRendering.Text = "start rendering"
        '
        'chkUseAudioOfVideoCaptureDevice
        '
        Me.chkUseAudioOfVideoCaptureDevice.Location = New System.Drawing.Point(406, 12)
        Me.chkUseAudioOfVideoCaptureDevice.Name = "chkUseAudioOfVideoCaptureDevice"
        Me.chkUseAudioOfVideoCaptureDevice.Size = New System.Drawing.Size(165, 35)
        Me.chkUseAudioOfVideoCaptureDevice.TabIndex = 5
        Me.chkUseAudioOfVideoCaptureDevice.Text = "use the audio out of the video capture device, if any"
        '
        'chkRenderAudioDevice
        '
        Me.chkRenderAudioDevice.BackColor = System.Drawing.SystemColors.Control
        Me.chkRenderAudioDevice.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkRenderAudioDevice.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRenderAudioDevice.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkRenderAudioDevice.Location = New System.Drawing.Point(12, 8)
        Me.chkRenderAudioDevice.Name = "chkRenderAudioDevice"
        Me.chkRenderAudioDevice.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkRenderAudioDevice.Size = New System.Drawing.Size(272, 18)
        Me.chkRenderAudioDevice.TabIndex = 19
        Me.chkRenderAudioDevice.Text = "AUDIO DEVICE RENDERING"
        '
        'Audio
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(938, 202)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkRenderAudioDevice)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pnlVUMeterRight)
        Me.Controls.Add(Me.pnlVUMeterLeft)
        Me.Controls.Add(Me.grbVuMeters)
        Me.Controls.Add(Me.grbAudioRendering)
        Me.Controls.Add(Me.grbAudioCaptureDevice)
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(4, 23)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Audio"
        Me.ShowInTaskbar = False
        Me.grbAudioRendering.ResumeLayout(False)
        CType(Me.tbrAudioVolume, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbrAudioBalance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbAudioCaptureDevice.ResumeLayout(False)
        CType(Me.tbrAudioInputLevel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbrAudioInputBalance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbVuMeters.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region
    Public Sub RefreshControls()
        AssignListToComboBox(cboAudioDevices, MainForm.DefInstance.VideoGrabber1.AudioDevices, MainForm.DefInstance.VideoGrabber1.AudioDevice)

        If MainForm.DefInstance.VideoGrabber1.AudioDevice >= 0 Then ' if an audio capture device has been selected
            AssignListToComboBox(cboAudioInputs, MainForm.DefInstance.VideoGrabber1.AudioInputs, MainForm.DefInstance.VideoGrabber1.AudioInput)
        End If

        tbrAudioInputLevel.Value = MainForm.DefInstance.VideoGrabber1.AudioInputLevel
        tbrAudioInputBalance.Value = MainForm.DefInstance.VideoGrabber1.AudioInputBalance
        chkAudioInputMono.Checked = IIf(MainForm.DefInstance.VideoGrabber1.AudioInputMono, System.Windows.Forms.CheckState.Checked, System.Windows.Forms.CheckState.Unchecked)

        AssignListToComboBox(cboAudioRenderers, MainForm.DefInstance.VideoGrabber1.AudioRenderers, MainForm.DefInstance.VideoGrabber1.AudioRenderer)

        chkRenderAudioDevice.Checked = MainForm.DefInstance.VideoGrabber1.AudioDeviceRendering
        chkMuteAudioRendering.Checked = MainForm.DefInstance.VideoGrabber1.MuteAudioRendering

        If MainForm.DefInstance.VideoGrabber1.AudioDevice = -1 Then
            cboAudioDevices.Text = "SELECT AND AUDIO CAPTURE DEVICE IN THIS LIST"
        End If
        If MainForm.DefInstance.VideoGrabber1.AudioRenderer = -1 Then
            cboAudioRenderers.Text = "default (AudioRenderer = -1)"
        End If
    End Sub

    Private Sub cboAudioDevices_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAudioDevices.SelectedIndexChanged
        MainForm.DefInstance.VideoGrabber1.AudioDevice = cboAudioDevices.SelectedIndex
    End Sub

    Private Sub btnAudioDeviceDialog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAudioDeviceDialog.Click
        MainForm.DefInstance.VideoGrabber1.ShowDialog(VidGrab.TDialog.dlg_AudioDevice)
    End Sub

    Private Sub cboAudioInputs_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAudioInputs.SelectedIndexChanged
        MainForm.DefInstance.VideoGrabber1.AudioInput = cboAudioInputs.SelectedIndex
    End Sub

    Private Sub chkAudioInputMono_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAudioInputMono.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.AudioInputMono = chkAudioInputMono.Checked
    End Sub

    Private Sub chkRenderAudioDevice_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRenderAudioDevice.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.AudioDeviceRendering = chkRenderAudioDevice.Checked
    End Sub

    Private Sub chkMuteAudioRendering_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMuteAudioRendering.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.MuteAudioRendering = chkMuteAudioRendering.Checked
    End Sub

    Private Sub cboAudioRenderers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAudioRenderers.SelectedIndexChanged
        MainForm.DefInstance.VideoGrabber1.AudioRenderer = cboAudioRenderers.SelectedIndex
    End Sub

    Private Sub tbrAudioVolume_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbrAudioVolume.Scroll
        MainForm.DefInstance.VideoGrabber1.AudioVolume = tbrAudioVolume.Value
    End Sub

    Private Sub tbrAudioInputLevel_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbrAudioInputLevel.Scroll
        MainForm.DefInstance.VideoGrabber1.AudioInputLevel = tbrAudioInputLevel.Value
    End Sub

    Private Sub tbrAudioInputBalance_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbrAudioInputBalance.Scroll
        MainForm.DefInstance.VideoGrabber1.AudioInputBalance = tbrAudioInputBalance.Value
    End Sub

    Private Sub tbrAudioBalance_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbrAudioBalance.Scroll
        MainForm.DefInstance.VideoGrabber1.AudioBalance = tbrAudioBalance.Value
    End Sub

    Private Sub rdgVUMeters_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgVUDisabled.CheckedChanged, rdgVUAnalog.CheckedChanged, rdgVUBargraph.CheckedChanged
        Const VU_LEFT As Integer = 0
        Const VU_RIGHT As Integer = 1

        If CType(sender, RadioButton).Checked Then
            Select Case sender.Tag
                Case 0
                    MainForm.DefInstance.VideoGrabber1.VuMeter = VidGrab.TVuMeter.vu_Disabled
                    MainForm.DefInstance.VideoGrabber1.SetVUMeterSetting(Convert.ToUInt32(VU_LEFT), VidGrab.TVUMeterSetting.vu_Handle, Convert.ToUInt32(0))
                    MainForm.DefInstance.VideoGrabber1.SetVUMeterSetting(Convert.ToUInt32(VU_RIGHT), VidGrab.TVUMeterSetting.vu_Handle, Convert.ToUInt32(0))
                Case 1
                    pnlVUMeterLeft.Width = (pnlVUMeterLeft.Height * 4) / 3
                    pnlVUMeterRight.Width = (pnlVUMeterRight.Height * 4) / 3

                    MainForm.DefInstance.VideoGrabber1.SetVUMeterSetting(Convert.ToUInt32(VU_LEFT), VidGrab.TVUMeterSetting.vu_BkgndColor, Convert.ToUInt32(&H0))
                    MainForm.DefInstance.VideoGrabber1.SetVUMeterSetting(Convert.ToUInt32(VU_RIGHT), VidGrab.TVUMeterSetting.vu_BkgndColor, Convert.ToUInt32(&H0))
                    MainForm.DefInstance.VideoGrabber1.SetVUMeterSetting(Convert.ToUInt32(VU_LEFT), VidGrab.TVUMeterSetting.vu_Handle, Convert.ToUInt32(pnlVUMeterLeft.Handle.ToInt32()))
                    MainForm.DefInstance.VideoGrabber1.SetVUMeterSetting(Convert.ToUInt32(VU_RIGHT), VidGrab.TVUMeterSetting.vu_Handle, Convert.ToUInt32(pnlVUMeterRight.Handle.ToInt32()))
                Case 2
                    MainForm.DefInstance.VideoGrabber1.VuMeter = VidGrab.TVuMeter.vu_Bargraph

                    pnlVUMeterLeft.Width = (pnlVUMeterLeft.Height * 2) / 10
                    pnlVUMeterRight.Width = (pnlVUMeterRight.Height * 2) / 10

                    MainForm.DefInstance.VideoGrabber1.SetVUMeterSetting(Convert.ToUInt32(VU_LEFT), VidGrab.TVUMeterSetting.vu_BkgndColor, Convert.ToUInt32(&H404040))
                    MainForm.DefInstance.VideoGrabber1.SetVUMeterSetting(Convert.ToUInt32(VU_RIGHT), VidGrab.TVUMeterSetting.vu_BkgndColor, Convert.ToUInt32(&H404040))
                    MainForm.DefInstance.VideoGrabber1.SetVUMeterSetting(Convert.ToUInt32(VU_LEFT), VidGrab.TVUMeterSetting.vu_Handle, Convert.ToUInt32(pnlVUMeterLeft.Handle.ToInt32()))
                    MainForm.DefInstance.VideoGrabber1.SetVUMeterSetting(Convert.ToUInt32(VU_RIGHT), VidGrab.TVUMeterSetting.vu_Handle, Convert.ToUInt32(pnlVUMeterRight.Handle.ToInt32()))
            End Select
        End If
    End Sub

    Private Sub btnStartAudioRendering_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartAudioRendering.Click
        MainForm.DefInstance.VideoGrabber1.StartAudioRendering()
        If Not MainForm.DefInstance.VideoGrabber1.AudioDeviceRendering Then
            If btnStartAudioRendering.Tag = 0 Then
                btnStartAudioRendering.Tag = 1 ' to show the popup only one time
                MsgBox("StartAudioRendering acts as 'preview', e.g. for the VU-Meters, if AudioDeviceRendering (on the left) is not enabled, the audio will not be heard in the speakers")
            End If
        End If
    End Sub

    Private Sub btnStartWavRecording_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartWavRecording.Click
        MainForm.DefInstance.VideoGrabber1.CompressionMode = VidGrab.TCompressionMode.cm_NoCompression
        MainForm.DefInstance.VideoGrabber1.RecordingMethod = VidGrab.TRecordingMethod.rm_AVI
        MainForm.DefInstance.VideoGrabber1.StartAudioRecording()
    End Sub

    Private Sub btnSartMP3Recording_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSartMP3Recording.Click
        MainForm.DefInstance.VideoGrabber1.CompressionMode = VidGrab.TCompressionMode.cm_CompressOnTheFly
        MainForm.DefInstance.VideoGrabber1.CompressionType = VidGrab.TCompressionType.ct_Audio
        MainForm.DefInstance.VideoGrabber1.RecordingMethod = VidGrab.TRecordingMethod.rm_AVI
        MainForm.DefInstance.VideoGrabber1.AudioCompressor = MainForm.DefInstance.VideoGrabber1.FindIndexInListByName(MainForm.DefInstance.VideoGrabber1.AudioCompressors, "LAME Audio Encoder", False, True)
        If MainForm.DefInstance.VideoGrabber1.AudioCompressor = -1 Then
            MsgBox("The LAME Audio Encoder is required, download it from http://www.elecard.com/download/")
        Else
            MainForm.DefInstance.VideoGrabber1.StartAudioRecording()
        End If
    End Sub

    Private Sub btnStartWMVRecording_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartWMVRecording.Click
        MainForm.DefInstance.VideoGrabber1.CompressionMode = VidGrab.TCompressionMode.cm_NoCompression
        MainForm.DefInstance.VideoGrabber1.RecordingMethod = VidGrab.TRecordingMethod.rm_ASF
        MainForm.DefInstance.VideoGrabber1.StartAudioRecording()
    End Sub

    Private Sub btnStopAudio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStopAudio.Click
        MainForm.DefInstance.VideoGrabber1.Stop()
    End Sub

    Private Sub chkUseAudioOfVideoCaptureDevice_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkUseAudioOfVideoCaptureDevice.CheckedChanged
        If chkUseAudioOfVideoCaptureDevice.Checked Then
            MainForm.DefInstance.VideoGrabber1.VideoDevice = 0 ' in this demo, by default we choose the 1st
        Else
            MainForm.DefInstance.VideoGrabber1.VideoDevice = -1 ' this deactivates the video capture device
        End If
    End Sub

    Private Sub Audio_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        If Visible Then
            RefreshControls()
        End If
    End Sub

End Class
