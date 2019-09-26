Option Strict Off
Option Explicit On
Friend Class Recording
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
    Public WithEvents btnMoreInfo As System.Windows.Forms.Button
    Public WithEvents btnStartRecordingImmediately As System.Windows.Forms.Button
    Public WithEvents btnStartRecordingControlled As System.Windows.Forms.Button
    Public WithEvents btnStopRecording As System.Windows.Forms.Button
    Public WithEvents btnRenewRecordingFile As System.Windows.Forms.Button
    Public WithEvents chkRecordingCanPause As System.Windows.Forms.CheckBox
    Public WithEvents btnPauseRecording As System.Windows.Forms.Button
    Public WithEvents btnResumeRecording As System.Windows.Forms.Button
    Public WithEvents cboVideoCompressors As System.Windows.Forms.ComboBox
    Public WithEvents btnVideoCompressorSettings As System.Windows.Forms.Button
    Public WithEvents cboAudioCompressors As System.Windows.Forms.ComboBox
    Public WithEvents btnAudioCompressorSettings As System.Windows.Forms.Button
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents rdgRecordingMethod As System.Windows.Forms.GroupBox
    Public WithEvents chkAudioRecording As System.Windows.Forms.CheckBox
    Public WithEvents cboAudioFormats As System.Windows.Forms.ComboBox
    Public WithEvents chkPreserveNativeFormat As System.Windows.Forms.CheckBox
    Public WithEvents chkAVISaveToThisFile As System.Windows.Forms.CheckBox
    Public WithEvents edtRecordingFileName As System.Windows.Forms.TextBox
    Public WithEvents chkOpenDML As System.Windows.Forms.CheckBox
    Public WithEvents chkPreallocFile As System.Windows.Forms.CheckBox
    Public WithEvents edtPreallocSize As System.Windows.Forms.TextBox
    Public WithEvents btnCreatePreallocFileNow As System.Windows.Forms.Button
    Public WithEvents Label13 As System.Windows.Forms.Label
    Public WithEvents Label15 As System.Windows.Forms.Label
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Friend WithEvents chkPauseCreatesNewFile As System.Windows.Forms.CheckBox
    Friend WithEvents chkRecordingOnMotion As System.Windows.Forms.CheckBox
    Friend WithEvents btnSendToDVinfo As System.Windows.Forms.Button
    Friend WithEvents btnASFinfo As System.Windows.Forms.Button
    Public WithEvents rdgRecordingMethodSendToDV As System.Windows.Forms.RadioButton
    Public WithEvents rdgRecordingMethodAVI As System.Windows.Forms.RadioButton
    Public WithEvents rdgRecordingMethodWMV As System.Windows.Forms.RadioButton
    Friend WithEvents rdgRecordingTimer As System.Windows.Forms.GroupBox
    Friend WithEvents lblStartRecordingControlled As System.Windows.Forms.Label
    Friend WithEvents edtRecordingTimer As System.Windows.Forms.TextBox
    Friend WithEvents chkScreenRecordWindow As System.Windows.Forms.CheckBox
    Friend WithEvents rdgRecordingTimer2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdgRecordingTimer1 As System.Windows.Forms.RadioButton
    Friend WithEvents rdgRecordingTimer4 As System.Windows.Forms.RadioButton
    Friend WithEvents rdgRecordingTimer3 As System.Windows.Forms.RadioButton
    Public WithEvents rdgRecordingMethodMKV As System.Windows.Forms.RadioButton
    Public WithEvents rdgRecordingMethodMP4 As System.Windows.Forms.RadioButton
    Public WithEvents rdgRecordingMethodFLV As System.Windows.Forms.RadioButton
    Public WithEvents btnReloadAudioCompressorSettings As System.Windows.Forms.Button
    Public WithEvents btnSaveAudioCompressorSettings As System.Windows.Forms.Button
    Public WithEvents btnReloadVideoCompressorSettings As System.Windows.Forms.Button
    Public WithEvents btnSaveVideoCompressorSettings As System.Windows.Forms.Button
    Public WithEvents rdgCompressMode As System.Windows.Forms.GroupBox
    Public WithEvents rdgCompressModeNo As System.Windows.Forms.RadioButton
    Public WithEvents rdgCompressModeAfterCapture As System.Windows.Forms.RadioButton
    Public WithEvents rdgCompressModeOnTheFly As System.Windows.Forms.RadioButton
    Public WithEvents rdgCompressType As System.Windows.Forms.GroupBox
    Public WithEvents rdgCompressTypeAudio As System.Windows.Forms.RadioButton
    Public WithEvents rdgCompressTypeAudioVideo As System.Windows.Forms.RadioButton
    Public WithEvents rdgCompressTypeVideo As System.Windows.Forms.RadioButton
    Private WithEvents rdgRecordingMethodMultiplexer As System.Windows.Forms.RadioButton
    Private WithEvents rdgRecordingMethodMPG As System.Windows.Forms.RadioButton
    Friend WithEvents btnCodecExamples As System.Windows.Forms.Button
    Public WithEvents cboMultiplexers As System.Windows.Forms.ComboBox
    Public WithEvents Label55 As System.Windows.Forms.Label
    Public WithEvents Button1 As System.Windows.Forms.Button
    Private WithEvents rdgRecordingMethod_WebM As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnMoreInfo = New System.Windows.Forms.Button
        Me.btnStartRecordingImmediately = New System.Windows.Forms.Button
        Me.btnStartRecordingControlled = New System.Windows.Forms.Button
        Me.btnStopRecording = New System.Windows.Forms.Button
        Me.btnRenewRecordingFile = New System.Windows.Forms.Button
        Me.btnResumeRecording = New System.Windows.Forms.Button
        Me.btnPauseRecording = New System.Windows.Forms.Button
        Me.chkRecordingOnMotion = New System.Windows.Forms.CheckBox
        Me.chkPauseCreatesNewFile = New System.Windows.Forms.CheckBox
        Me.chkRecordingCanPause = New System.Windows.Forms.CheckBox
        Me.btnReloadAudioCompressorSettings = New System.Windows.Forms.Button
        Me.btnSaveAudioCompressorSettings = New System.Windows.Forms.Button
        Me.btnReloadVideoCompressorSettings = New System.Windows.Forms.Button
        Me.btnSaveVideoCompressorSettings = New System.Windows.Forms.Button
        Me.cboVideoCompressors = New System.Windows.Forms.ComboBox
        Me.btnVideoCompressorSettings = New System.Windows.Forms.Button
        Me.cboAudioCompressors = New System.Windows.Forms.ComboBox
        Me.btnAudioCompressorSettings = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.rdgRecordingMethod = New System.Windows.Forms.GroupBox
        Me.rdgRecordingMethodMultiplexer = New System.Windows.Forms.RadioButton
        Me.rdgRecordingMethodMPG = New System.Windows.Forms.RadioButton
        Me.rdgRecordingMethod_WebM = New System.Windows.Forms.RadioButton
        Me.rdgRecordingMethodMP4 = New System.Windows.Forms.RadioButton
        Me.rdgRecordingMethodFLV = New System.Windows.Forms.RadioButton
        Me.rdgRecordingMethodMKV = New System.Windows.Forms.RadioButton
        Me.btnSendToDVinfo = New System.Windows.Forms.Button
        Me.btnASFinfo = New System.Windows.Forms.Button
        Me.rdgRecordingMethodSendToDV = New System.Windows.Forms.RadioButton
        Me.rdgRecordingMethodAVI = New System.Windows.Forms.RadioButton
        Me.rdgRecordingMethodWMV = New System.Windows.Forms.RadioButton
        Me.chkAudioRecording = New System.Windows.Forms.CheckBox
        Me.cboAudioFormats = New System.Windows.Forms.ComboBox
        Me.chkPreserveNativeFormat = New System.Windows.Forms.CheckBox
        Me.chkAVISaveToThisFile = New System.Windows.Forms.CheckBox
        Me.edtRecordingFileName = New System.Windows.Forms.TextBox
        Me.chkOpenDML = New System.Windows.Forms.CheckBox
        Me.chkPreallocFile = New System.Windows.Forms.CheckBox
        Me.edtPreallocSize = New System.Windows.Forms.TextBox
        Me.btnCreatePreallocFileNow = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.rdgRecordingTimer = New System.Windows.Forms.GroupBox
        Me.rdgRecordingTimer4 = New System.Windows.Forms.RadioButton
        Me.rdgRecordingTimer3 = New System.Windows.Forms.RadioButton
        Me.rdgRecordingTimer2 = New System.Windows.Forms.RadioButton
        Me.rdgRecordingTimer1 = New System.Windows.Forms.RadioButton
        Me.chkScreenRecordWindow = New System.Windows.Forms.CheckBox
        Me.lblStartRecordingControlled = New System.Windows.Forms.Label
        Me.edtRecordingTimer = New System.Windows.Forms.TextBox
        Me.rdgCompressTypeVideo = New System.Windows.Forms.RadioButton
        Me.rdgCompressTypeAudioVideo = New System.Windows.Forms.RadioButton
        Me.rdgCompressTypeAudio = New System.Windows.Forms.RadioButton
        Me.rdgCompressType = New System.Windows.Forms.GroupBox
        Me.rdgCompressModeOnTheFly = New System.Windows.Forms.RadioButton
        Me.rdgCompressModeAfterCapture = New System.Windows.Forms.RadioButton
        Me.rdgCompressModeNo = New System.Windows.Forms.RadioButton
        Me.rdgCompressMode = New System.Windows.Forms.GroupBox
        Me.btnCodecExamples = New System.Windows.Forms.Button
        Me.cboMultiplexers = New System.Windows.Forms.ComboBox
        Me.Label55 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.rdgRecordingMethod.SuspendLayout()
        Me.rdgRecordingTimer.SuspendLayout()
        Me.rdgCompressType.SuspendLayout()
        Me.rdgCompressMode.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnMoreInfo
        '
        Me.btnMoreInfo.BackColor = System.Drawing.SystemColors.Control
        Me.btnMoreInfo.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnMoreInfo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoreInfo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnMoreInfo.Location = New System.Drawing.Point(172, 50)
        Me.btnMoreInfo.Name = "btnMoreInfo"
        Me.btnMoreInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnMoreInfo.Size = New System.Drawing.Size(18, 20)
        Me.btnMoreInfo.TabIndex = 38
        Me.btnMoreInfo.Text = "?"
        Me.btnMoreInfo.UseVisualStyleBackColor = False
        '
        'btnStartRecordingImmediately
        '
        Me.btnStartRecordingImmediately.BackColor = System.Drawing.SystemColors.Control
        Me.btnStartRecordingImmediately.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnStartRecordingImmediately.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartRecordingImmediately.ForeColor = System.Drawing.Color.Red
        Me.btnStartRecordingImmediately.Location = New System.Drawing.Point(6, 5)
        Me.btnStartRecordingImmediately.Name = "btnStartRecordingImmediately"
        Me.btnStartRecordingImmediately.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnStartRecordingImmediately.Size = New System.Drawing.Size(105, 24)
        Me.btnStartRecordingImmediately.TabIndex = 34
        Me.btnStartRecordingImmediately.Text = "start (immediately)"
        Me.btnStartRecordingImmediately.UseVisualStyleBackColor = False
        '
        'btnStartRecordingControlled
        '
        Me.btnStartRecordingControlled.BackColor = System.Drawing.SystemColors.Control
        Me.btnStartRecordingControlled.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnStartRecordingControlled.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartRecordingControlled.ForeColor = System.Drawing.Color.Red
        Me.btnStartRecordingControlled.Location = New System.Drawing.Point(115, 5)
        Me.btnStartRecordingControlled.Name = "btnStartRecordingControlled"
        Me.btnStartRecordingControlled.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnStartRecordingControlled.Size = New System.Drawing.Size(97, 24)
        Me.btnStartRecordingControlled.TabIndex = 33
        Me.btnStartRecordingControlled.Text = "start (controlled)"
        Me.btnStartRecordingControlled.UseVisualStyleBackColor = False
        '
        'btnStopRecording
        '
        Me.btnStopRecording.BackColor = System.Drawing.SystemColors.Control
        Me.btnStopRecording.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnStopRecording.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStopRecording.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnStopRecording.Location = New System.Drawing.Point(215, 5)
        Me.btnStopRecording.Name = "btnStopRecording"
        Me.btnStopRecording.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnStopRecording.Size = New System.Drawing.Size(45, 24)
        Me.btnStopRecording.TabIndex = 32
        Me.btnStopRecording.Text = "stop"
        Me.btnStopRecording.UseVisualStyleBackColor = False
        '
        'btnRenewRecordingFile
        '
        Me.btnRenewRecordingFile.BackColor = System.Drawing.SystemColors.Control
        Me.btnRenewRecordingFile.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnRenewRecordingFile.Enabled = False
        Me.btnRenewRecordingFile.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRenewRecordingFile.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnRenewRecordingFile.Location = New System.Drawing.Point(263, 5)
        Me.btnRenewRecordingFile.Name = "btnRenewRecordingFile"
        Me.btnRenewRecordingFile.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnRenewRecordingFile.Size = New System.Drawing.Size(138, 24)
        Me.btnRenewRecordingFile.TabIndex = 31
        Me.btnRenewRecordingFile.Text = "new file during recording"
        Me.btnRenewRecordingFile.UseVisualStyleBackColor = False
        '
        'btnResumeRecording
        '
        Me.btnResumeRecording.BackColor = System.Drawing.SystemColors.Control
        Me.btnResumeRecording.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnResumeRecording.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResumeRecording.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnResumeRecording.Location = New System.Drawing.Point(586, 57)
        Me.btnResumeRecording.Name = "btnResumeRecording"
        Me.btnResumeRecording.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnResumeRecording.Size = New System.Drawing.Size(58, 20)
        Me.btnResumeRecording.TabIndex = 28
        Me.btnResumeRecording.Text = "resume"
        Me.btnResumeRecording.UseVisualStyleBackColor = False
        '
        'btnPauseRecording
        '
        Me.btnPauseRecording.BackColor = System.Drawing.SystemColors.Control
        Me.btnPauseRecording.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnPauseRecording.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPauseRecording.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPauseRecording.Location = New System.Drawing.Point(522, 57)
        Me.btnPauseRecording.Name = "btnPauseRecording"
        Me.btnPauseRecording.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnPauseRecording.Size = New System.Drawing.Size(58, 20)
        Me.btnPauseRecording.TabIndex = 29
        Me.btnPauseRecording.Text = "pause"
        Me.btnPauseRecording.UseVisualStyleBackColor = False
        '
        'chkRecordingOnMotion
        '
        Me.chkRecordingOnMotion.Location = New System.Drawing.Point(522, 39)
        Me.chkRecordingOnMotion.Name = "chkRecordingOnMotion"
        Me.chkRecordingOnMotion.Size = New System.Drawing.Size(216, 16)
        Me.chkRecordingOnMotion.TabIndex = 32
        Me.chkRecordingOnMotion.Text = "pause/resume on motion"
        '
        'chkPauseCreatesNewFile
        '
        Me.chkPauseCreatesNewFile.Location = New System.Drawing.Point(522, 24)
        Me.chkPauseCreatesNewFile.Name = "chkPauseCreatesNewFile"
        Me.chkPauseCreatesNewFile.Size = New System.Drawing.Size(152, 16)
        Me.chkPauseCreatesNewFile.TabIndex = 31
        Me.chkPauseCreatesNewFile.Text = "pause creates new file"
        '
        'chkRecordingCanPause
        '
        Me.chkRecordingCanPause.BackColor = System.Drawing.SystemColors.Control
        Me.chkRecordingCanPause.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkRecordingCanPause.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRecordingCanPause.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkRecordingCanPause.Location = New System.Drawing.Point(522, 5)
        Me.chkRecordingCanPause.Name = "chkRecordingCanPause"
        Me.chkRecordingCanPause.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkRecordingCanPause.Size = New System.Drawing.Size(152, 16)
        Me.chkRecordingCanPause.TabIndex = 30
        Me.chkRecordingCanPause.Text = "recording can pause"
        Me.chkRecordingCanPause.UseVisualStyleBackColor = False
        '
        'btnReloadAudioCompressorSettings
        '
        Me.btnReloadAudioCompressorSettings.BackColor = System.Drawing.SystemColors.Control
        Me.btnReloadAudioCompressorSettings.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnReloadAudioCompressorSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReloadAudioCompressorSettings.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnReloadAudioCompressorSettings.Location = New System.Drawing.Point(880, 90)
        Me.btnReloadAudioCompressorSettings.Name = "btnReloadAudioCompressorSettings"
        Me.btnReloadAudioCompressorSettings.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnReloadAudioCompressorSettings.Size = New System.Drawing.Size(50, 18)
        Me.btnReloadAudioCompressorSettings.TabIndex = 34
        Me.btnReloadAudioCompressorSettings.Text = "reload"
        Me.btnReloadAudioCompressorSettings.UseVisualStyleBackColor = False
        '
        'btnSaveAudioCompressorSettings
        '
        Me.btnSaveAudioCompressorSettings.BackColor = System.Drawing.SystemColors.Control
        Me.btnSaveAudioCompressorSettings.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSaveAudioCompressorSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveAudioCompressorSettings.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSaveAudioCompressorSettings.Location = New System.Drawing.Point(829, 90)
        Me.btnSaveAudioCompressorSettings.Name = "btnSaveAudioCompressorSettings"
        Me.btnSaveAudioCompressorSettings.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSaveAudioCompressorSettings.Size = New System.Drawing.Size(50, 18)
        Me.btnSaveAudioCompressorSettings.TabIndex = 33
        Me.btnSaveAudioCompressorSettings.Text = "save"
        Me.btnSaveAudioCompressorSettings.UseVisualStyleBackColor = False
        '
        'btnReloadVideoCompressorSettings
        '
        Me.btnReloadVideoCompressorSettings.BackColor = System.Drawing.SystemColors.Control
        Me.btnReloadVideoCompressorSettings.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnReloadVideoCompressorSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReloadVideoCompressorSettings.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnReloadVideoCompressorSettings.Location = New System.Drawing.Point(880, 36)
        Me.btnReloadVideoCompressorSettings.Name = "btnReloadVideoCompressorSettings"
        Me.btnReloadVideoCompressorSettings.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnReloadVideoCompressorSettings.Size = New System.Drawing.Size(50, 18)
        Me.btnReloadVideoCompressorSettings.TabIndex = 32
        Me.btnReloadVideoCompressorSettings.Text = "reload"
        Me.btnReloadVideoCompressorSettings.UseVisualStyleBackColor = False
        '
        'btnSaveVideoCompressorSettings
        '
        Me.btnSaveVideoCompressorSettings.BackColor = System.Drawing.SystemColors.Control
        Me.btnSaveVideoCompressorSettings.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSaveVideoCompressorSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveVideoCompressorSettings.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSaveVideoCompressorSettings.Location = New System.Drawing.Point(829, 36)
        Me.btnSaveVideoCompressorSettings.Name = "btnSaveVideoCompressorSettings"
        Me.btnSaveVideoCompressorSettings.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSaveVideoCompressorSettings.Size = New System.Drawing.Size(50, 18)
        Me.btnSaveVideoCompressorSettings.TabIndex = 31
        Me.btnSaveVideoCompressorSettings.Text = "save"
        Me.btnSaveVideoCompressorSettings.UseVisualStyleBackColor = False
        '
        'cboVideoCompressors
        '
        Me.cboVideoCompressors.BackColor = System.Drawing.SystemColors.Window
        Me.cboVideoCompressors.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboVideoCompressors.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVideoCompressors.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboVideoCompressors.Location = New System.Drawing.Point(770, 14)
        Me.cboVideoCompressors.Name = "cboVideoCompressors"
        Me.cboVideoCompressors.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboVideoCompressors.Size = New System.Drawing.Size(161, 22)
        Me.cboVideoCompressors.TabIndex = 16
        '
        'btnVideoCompressorSettings
        '
        Me.btnVideoCompressorSettings.BackColor = System.Drawing.SystemColors.Control
        Me.btnVideoCompressorSettings.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnVideoCompressorSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVideoCompressorSettings.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnVideoCompressorSettings.Location = New System.Drawing.Point(770, 36)
        Me.btnVideoCompressorSettings.Name = "btnVideoCompressorSettings"
        Me.btnVideoCompressorSettings.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnVideoCompressorSettings.Size = New System.Drawing.Size(53, 18)
        Me.btnVideoCompressorSettings.TabIndex = 15
        Me.btnVideoCompressorSettings.Text = "settings"
        Me.btnVideoCompressorSettings.UseVisualStyleBackColor = False
        '
        'cboAudioCompressors
        '
        Me.cboAudioCompressors.BackColor = System.Drawing.SystemColors.Window
        Me.cboAudioCompressors.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboAudioCompressors.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAudioCompressors.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboAudioCompressors.Location = New System.Drawing.Point(770, 68)
        Me.cboAudioCompressors.Name = "cboAudioCompressors"
        Me.cboAudioCompressors.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboAudioCompressors.Size = New System.Drawing.Size(161, 22)
        Me.cboAudioCompressors.TabIndex = 14
        '
        'btnAudioCompressorSettings
        '
        Me.btnAudioCompressorSettings.BackColor = System.Drawing.SystemColors.Control
        Me.btnAudioCompressorSettings.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnAudioCompressorSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAudioCompressorSettings.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAudioCompressorSettings.Location = New System.Drawing.Point(770, 90)
        Me.btnAudioCompressorSettings.Name = "btnAudioCompressorSettings"
        Me.btnAudioCompressorSettings.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnAudioCompressorSettings.Size = New System.Drawing.Size(53, 18)
        Me.btnAudioCompressorSettings.TabIndex = 13
        Me.btnAudioCompressorSettings.Text = "settings"
        Me.btnAudioCompressorSettings.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(770, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(113, 17)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "video compressor"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(770, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(113, 17)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "audio compressor"
        '
        'rdgRecordingMethod
        '
        Me.rdgRecordingMethod.BackColor = System.Drawing.SystemColors.Control
        Me.rdgRecordingMethod.Controls.Add(Me.rdgRecordingMethodMultiplexer)
        Me.rdgRecordingMethod.Controls.Add(Me.rdgRecordingMethodMPG)
        Me.rdgRecordingMethod.Controls.Add(Me.rdgRecordingMethod_WebM)
        Me.rdgRecordingMethod.Controls.Add(Me.rdgRecordingMethodMP4)
        Me.rdgRecordingMethod.Controls.Add(Me.rdgRecordingMethodFLV)
        Me.rdgRecordingMethod.Controls.Add(Me.rdgRecordingMethodMKV)
        Me.rdgRecordingMethod.Controls.Add(Me.btnSendToDVinfo)
        Me.rdgRecordingMethod.Controls.Add(Me.btnASFinfo)
        Me.rdgRecordingMethod.Controls.Add(Me.rdgRecordingMethodSendToDV)
        Me.rdgRecordingMethod.Controls.Add(Me.rdgRecordingMethodAVI)
        Me.rdgRecordingMethod.Controls.Add(Me.rdgRecordingMethodWMV)
        Me.rdgRecordingMethod.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgRecordingMethod.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgRecordingMethod.Location = New System.Drawing.Point(402, 0)
        Me.rdgRecordingMethod.Name = "rdgRecordingMethod"
        Me.rdgRecordingMethod.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgRecordingMethod.Size = New System.Drawing.Size(116, 182)
        Me.rdgRecordingMethod.TabIndex = 9
        Me.rdgRecordingMethod.TabStop = False
        Me.rdgRecordingMethod.Text = "recording  method"
        '
        'rdgRecordingMethodMultiplexer
        '
        Me.rdgRecordingMethodMultiplexer.AutoSize = True
        Me.rdgRecordingMethodMultiplexer.Location = New System.Drawing.Point(7, 157)
        Me.rdgRecordingMethodMultiplexer.Name = "rdgRecordingMethodMultiplexer"
        Me.rdgRecordingMethodMultiplexer.Size = New System.Drawing.Size(109, 18)
        Me.rdgRecordingMethodMultiplexer.TabIndex = 48
        Me.rdgRecordingMethodMultiplexer.TabStop = True
        Me.rdgRecordingMethodMultiplexer.Tag = "8"
        Me.rdgRecordingMethodMultiplexer.Text = "Multiplexer(other)"
        '
        'rdgRecordingMethodMPG
        '
        Me.rdgRecordingMethodMPG.AutoSize = True
        Me.rdgRecordingMethodMPG.Location = New System.Drawing.Point(7, 139)
        Me.rdgRecordingMethodMPG.Name = "rdgRecordingMethodMPG"
        Me.rdgRecordingMethodMPG.Size = New System.Drawing.Size(47, 18)
        Me.rdgRecordingMethodMPG.TabIndex = 47
        Me.rdgRecordingMethodMPG.TabStop = True
        Me.rdgRecordingMethodMPG.Tag = "7"
        Me.rdgRecordingMethodMPG.Text = "MPG"
        '
        'rdgRecordingMethod_WebM
        '
        Me.rdgRecordingMethod_WebM.AutoSize = True
        Me.rdgRecordingMethod_WebM.Location = New System.Drawing.Point(7, 121)
        Me.rdgRecordingMethod_WebM.Name = "rdgRecordingMethod_WebM"
        Me.rdgRecordingMethod_WebM.Size = New System.Drawing.Size(86, 18)
        Me.rdgRecordingMethod_WebM.TabIndex = 46
        Me.rdgRecordingMethod_WebM.TabStop = True
        Me.rdgRecordingMethod_WebM.Tag = "6"
        Me.rdgRecordingMethod_WebM.Text = "WebM (VP8)"
        '
        'rdgRecordingMethodMP4
        '
        Me.rdgRecordingMethodMP4.BackColor = System.Drawing.SystemColors.Control
        Me.rdgRecordingMethodMP4.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgRecordingMethodMP4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgRecordingMethodMP4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgRecordingMethodMP4.Location = New System.Drawing.Point(7, 104)
        Me.rdgRecordingMethodMP4.Name = "rdgRecordingMethodMP4"
        Me.rdgRecordingMethodMP4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgRecordingMethodMP4.Size = New System.Drawing.Size(89, 17)
        Me.rdgRecordingMethodMP4.TabIndex = 45
        Me.rdgRecordingMethodMP4.TabStop = True
        Me.rdgRecordingMethodMP4.Tag = "5"
        Me.rdgRecordingMethodMP4.Text = "MP4"
        Me.rdgRecordingMethodMP4.UseVisualStyleBackColor = False
        '
        'rdgRecordingMethodFLV
        '
        Me.rdgRecordingMethodFLV.BackColor = System.Drawing.SystemColors.Control
        Me.rdgRecordingMethodFLV.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgRecordingMethodFLV.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgRecordingMethodFLV.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgRecordingMethodFLV.Location = New System.Drawing.Point(7, 87)
        Me.rdgRecordingMethodFLV.Name = "rdgRecordingMethodFLV"
        Me.rdgRecordingMethodFLV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgRecordingMethodFLV.Size = New System.Drawing.Size(89, 17)
        Me.rdgRecordingMethodFLV.TabIndex = 44
        Me.rdgRecordingMethodFLV.TabStop = True
        Me.rdgRecordingMethodFLV.Tag = "4"
        Me.rdgRecordingMethodFLV.Text = "FLV"
        Me.rdgRecordingMethodFLV.UseVisualStyleBackColor = False
        '
        'rdgRecordingMethodMKV
        '
        Me.rdgRecordingMethodMKV.BackColor = System.Drawing.SystemColors.Control
        Me.rdgRecordingMethodMKV.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgRecordingMethodMKV.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgRecordingMethodMKV.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgRecordingMethodMKV.Location = New System.Drawing.Point(7, 70)
        Me.rdgRecordingMethodMKV.Name = "rdgRecordingMethodMKV"
        Me.rdgRecordingMethodMKV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgRecordingMethodMKV.Size = New System.Drawing.Size(79, 17)
        Me.rdgRecordingMethodMKV.TabIndex = 43
        Me.rdgRecordingMethodMKV.TabStop = True
        Me.rdgRecordingMethodMKV.Tag = "3"
        Me.rdgRecordingMethodMKV.Text = "MKV"
        Me.rdgRecordingMethodMKV.UseVisualStyleBackColor = False
        '
        'btnSendToDVinfo
        '
        Me.btnSendToDVinfo.Location = New System.Drawing.Point(88, 53)
        Me.btnSendToDVinfo.Name = "btnSendToDVinfo"
        Me.btnSendToDVinfo.Size = New System.Drawing.Size(22, 20)
        Me.btnSendToDVinfo.TabIndex = 41
        Me.btnSendToDVinfo.Text = "?"
        '
        'btnASFinfo
        '
        Me.btnASFinfo.Location = New System.Drawing.Point(88, 34)
        Me.btnASFinfo.Name = "btnASFinfo"
        Me.btnASFinfo.Size = New System.Drawing.Size(22, 20)
        Me.btnASFinfo.TabIndex = 40
        Me.btnASFinfo.Text = "?"
        '
        'rdgRecordingMethodSendToDV
        '
        Me.rdgRecordingMethodSendToDV.BackColor = System.Drawing.SystemColors.Control
        Me.rdgRecordingMethodSendToDV.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgRecordingMethodSendToDV.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgRecordingMethodSendToDV.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgRecordingMethodSendToDV.Location = New System.Drawing.Point(7, 53)
        Me.rdgRecordingMethodSendToDV.Name = "rdgRecordingMethodSendToDV"
        Me.rdgRecordingMethodSendToDV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgRecordingMethodSendToDV.Size = New System.Drawing.Size(96, 17)
        Me.rdgRecordingMethodSendToDV.TabIndex = 39
        Me.rdgRecordingMethodSendToDV.TabStop = True
        Me.rdgRecordingMethodSendToDV.Tag = "2"
        Me.rdgRecordingMethodSendToDV.Text = "Send to DV"
        Me.rdgRecordingMethodSendToDV.UseVisualStyleBackColor = False
        '
        'rdgRecordingMethodAVI
        '
        Me.rdgRecordingMethodAVI.BackColor = System.Drawing.SystemColors.Control
        Me.rdgRecordingMethodAVI.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgRecordingMethodAVI.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgRecordingMethodAVI.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgRecordingMethodAVI.Location = New System.Drawing.Point(7, 19)
        Me.rdgRecordingMethodAVI.Name = "rdgRecordingMethodAVI"
        Me.rdgRecordingMethodAVI.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgRecordingMethodAVI.Size = New System.Drawing.Size(89, 17)
        Me.rdgRecordingMethodAVI.TabIndex = 11
        Me.rdgRecordingMethodAVI.TabStop = True
        Me.rdgRecordingMethodAVI.Tag = "0"
        Me.rdgRecordingMethodAVI.Text = "AVI or MPEG"
        Me.rdgRecordingMethodAVI.UseVisualStyleBackColor = False
        '
        'rdgRecordingMethodWMV
        '
        Me.rdgRecordingMethodWMV.BackColor = System.Drawing.SystemColors.Control
        Me.rdgRecordingMethodWMV.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgRecordingMethodWMV.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgRecordingMethodWMV.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgRecordingMethodWMV.Location = New System.Drawing.Point(7, 36)
        Me.rdgRecordingMethodWMV.Name = "rdgRecordingMethodWMV"
        Me.rdgRecordingMethodWMV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgRecordingMethodWMV.Size = New System.Drawing.Size(89, 17)
        Me.rdgRecordingMethodWMV.TabIndex = 10
        Me.rdgRecordingMethodWMV.TabStop = True
        Me.rdgRecordingMethodWMV.Tag = "1"
        Me.rdgRecordingMethodWMV.Text = "ASF (WMV)"
        Me.rdgRecordingMethodWMV.UseVisualStyleBackColor = False
        '
        'chkAudioRecording
        '
        Me.chkAudioRecording.BackColor = System.Drawing.SystemColors.Control
        Me.chkAudioRecording.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkAudioRecording.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAudioRecording.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkAudioRecording.Location = New System.Drawing.Point(6, 51)
        Me.chkAudioRecording.Name = "chkAudioRecording"
        Me.chkAudioRecording.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkAudioRecording.Size = New System.Drawing.Size(153, 17)
        Me.chkAudioRecording.TabIndex = 8
        Me.chkAudioRecording.Text = "enable audio recording"
        Me.chkAudioRecording.UseVisualStyleBackColor = False
        '
        'cboAudioFormats
        '
        Me.cboAudioFormats.BackColor = System.Drawing.SystemColors.Window
        Me.cboAudioFormats.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboAudioFormats.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAudioFormats.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboAudioFormats.Location = New System.Drawing.Point(6, 81)
        Me.cboAudioFormats.Name = "cboAudioFormats"
        Me.cboAudioFormats.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboAudioFormats.Size = New System.Drawing.Size(184, 22)
        Me.cboAudioFormats.TabIndex = 7
        '
        'chkPreserveNativeFormat
        '
        Me.chkPreserveNativeFormat.AutoSize = True
        Me.chkPreserveNativeFormat.BackColor = System.Drawing.SystemColors.Control
        Me.chkPreserveNativeFormat.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkPreserveNativeFormat.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPreserveNativeFormat.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkPreserveNativeFormat.Location = New System.Drawing.Point(6, 33)
        Me.chkPreserveNativeFormat.Name = "chkPreserveNativeFormat"
        Me.chkPreserveNativeFormat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkPreserveNativeFormat.Size = New System.Drawing.Size(171, 18)
        Me.chkPreserveNativeFormat.TabIndex = 6
        Me.chkPreserveNativeFormat.Text = "RECORD IN NATIVE FORMAT"
        Me.chkPreserveNativeFormat.UseVisualStyleBackColor = False
        '
        'chkAVISaveToThisFile
        '
        Me.chkAVISaveToThisFile.BackColor = System.Drawing.SystemColors.Control
        Me.chkAVISaveToThisFile.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkAVISaveToThisFile.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAVISaveToThisFile.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkAVISaveToThisFile.Location = New System.Drawing.Point(6, 108)
        Me.chkAVISaveToThisFile.Name = "chkAVISaveToThisFile"
        Me.chkAVISaveToThisFile.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkAVISaveToThisFile.Size = New System.Drawing.Size(267, 17)
        Me.chkAVISaveToThisFile.TabIndex = 5
        Me.chkAVISaveToThisFile.Text = "do not generate file names automatically, save to:"
        Me.chkAVISaveToThisFile.UseVisualStyleBackColor = False
        '
        'edtRecordingFileName
        '
        Me.edtRecordingFileName.AcceptsReturn = True
        Me.edtRecordingFileName.BackColor = System.Drawing.SystemColors.Window
        Me.edtRecordingFileName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtRecordingFileName.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtRecordingFileName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtRecordingFileName.Location = New System.Drawing.Point(273, 108)
        Me.edtRecordingFileName.MaxLength = 0
        Me.edtRecordingFileName.Name = "edtRecordingFileName"
        Me.edtRecordingFileName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtRecordingFileName.Size = New System.Drawing.Size(127, 20)
        Me.edtRecordingFileName.TabIndex = 4
        Me.edtRecordingFileName.Text = "CaptureFile01.wmv"
        '
        'chkOpenDML
        '
        Me.chkOpenDML.BackColor = System.Drawing.SystemColors.Control
        Me.chkOpenDML.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkOpenDML.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOpenDML.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkOpenDML.Location = New System.Drawing.Point(6, 125)
        Me.chkOpenDML.Name = "chkOpenDML"
        Me.chkOpenDML.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkOpenDML.Size = New System.Drawing.Size(256, 17)
        Me.chkOpenDML.TabIndex = 3
        Me.chkOpenDML.Text = "OpenDML format (avi 2.0, captured file > 1 Gb)"
        Me.chkOpenDML.UseVisualStyleBackColor = False
        '
        'chkPreallocFile
        '
        Me.chkPreallocFile.BackColor = System.Drawing.SystemColors.Control
        Me.chkPreallocFile.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkPreallocFile.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPreallocFile.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkPreallocFile.Location = New System.Drawing.Point(6, 141)
        Me.chkPreallocFile.Name = "chkPreallocFile"
        Me.chkPreallocFile.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkPreallocFile.Size = New System.Drawing.Size(168, 17)
        Me.chkPreallocFile.TabIndex = 2
        Me.chkPreallocFile.Text = "use preallocated capture file:"
        Me.chkPreallocFile.UseVisualStyleBackColor = False
        '
        'edtPreallocSize
        '
        Me.edtPreallocSize.AcceptsReturn = True
        Me.edtPreallocSize.BackColor = System.Drawing.SystemColors.Window
        Me.edtPreallocSize.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtPreallocSize.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtPreallocSize.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtPreallocSize.Location = New System.Drawing.Point(168, 142)
        Me.edtPreallocSize.MaxLength = 0
        Me.edtPreallocSize.Name = "edtPreallocSize"
        Me.edtPreallocSize.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtPreallocSize.Size = New System.Drawing.Size(39, 20)
        Me.edtPreallocSize.TabIndex = 1
        Me.edtPreallocSize.Text = "100"
        '
        'btnCreatePreallocFileNow
        '
        Me.btnCreatePreallocFileNow.BackColor = System.Drawing.SystemColors.Control
        Me.btnCreatePreallocFileNow.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCreatePreallocFileNow.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreatePreallocFileNow.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCreatePreallocFileNow.Location = New System.Drawing.Point(260, 139)
        Me.btnCreatePreallocFileNow.Name = "btnCreatePreallocFileNow"
        Me.btnCreatePreallocFileNow.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCreatePreallocFileNow.Size = New System.Drawing.Size(140, 23)
        Me.btnCreatePreallocFileNow.TabIndex = 0
        Me.btnCreatePreallocFileNow.Text = "create preallocated file"
        Me.btnCreatePreallocFileNow.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(6, 67)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(72, 17)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "audio format:"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(207, 144)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(52, 18)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "Mb (size)"
        '
        'rdgRecordingTimer
        '
        Me.rdgRecordingTimer.Controls.Add(Me.rdgRecordingTimer4)
        Me.rdgRecordingTimer.Controls.Add(Me.rdgRecordingTimer3)
        Me.rdgRecordingTimer.Controls.Add(Me.rdgRecordingTimer2)
        Me.rdgRecordingTimer.Controls.Add(Me.rdgRecordingTimer1)
        Me.rdgRecordingTimer.Controls.Add(Me.chkScreenRecordWindow)
        Me.rdgRecordingTimer.Controls.Add(Me.lblStartRecordingControlled)
        Me.rdgRecordingTimer.Controls.Add(Me.edtRecordingTimer)
        Me.rdgRecordingTimer.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgRecordingTimer.Location = New System.Drawing.Point(196, 30)
        Me.rdgRecordingTimer.Name = "rdgRecordingTimer"
        Me.rdgRecordingTimer.Size = New System.Drawing.Size(205, 75)
        Me.rdgRecordingTimer.TabIndex = 46
        Me.rdgRecordingTimer.TabStop = False
        Me.rdgRecordingTimer.Text = "recording timer"
        '
        'rdgRecordingTimer4
        '
        Me.rdgRecordingTimer4.Location = New System.Drawing.Point(116, 28)
        Me.rdgRecordingTimer4.Name = "rdgRecordingTimer4"
        Me.rdgRecordingTimer4.Size = New System.Drawing.Size(84, 17)
        Me.rdgRecordingTimer4.TabIndex = 52
        Me.rdgRecordingTimer4.TabStop = True
        Me.rdgRecordingTimer4.Tag = "3"
        Me.rdgRecordingTimer4.Text = "start after..."
        '
        'rdgRecordingTimer3
        '
        Me.rdgRecordingTimer3.Location = New System.Drawing.Point(116, 13)
        Me.rdgRecordingTimer3.Name = "rdgRecordingTimer3"
        Me.rdgRecordingTimer3.Size = New System.Drawing.Size(84, 17)
        Me.rdgRecordingTimer3.TabIndex = 51
        Me.rdgRecordingTimer3.TabStop = True
        Me.rdgRecordingTimer3.Tag = "2"
        Me.rdgRecordingTimer3.Text = "stop after..."
        '
        'rdgRecordingTimer2
        '
        Me.rdgRecordingTimer2.Location = New System.Drawing.Point(9, 28)
        Me.rdgRecordingTimer2.Name = "rdgRecordingTimer2"
        Me.rdgRecordingTimer2.Size = New System.Drawing.Size(106, 18)
        Me.rdgRecordingTimer2.TabIndex = 50
        Me.rdgRecordingTimer2.TabStop = True
        Me.rdgRecordingTimer2.Tag = "1"
        Me.rdgRecordingTimer2.Text = "new file every..."
        '
        'rdgRecordingTimer1
        '
        Me.rdgRecordingTimer1.Location = New System.Drawing.Point(9, 13)
        Me.rdgRecordingTimer1.Name = "rdgRecordingTimer1"
        Me.rdgRecordingTimer1.Size = New System.Drawing.Size(97, 17)
        Me.rdgRecordingTimer1.TabIndex = 49
        Me.rdgRecordingTimer1.TabStop = True
        Me.rdgRecordingTimer1.Tag = "0"
        Me.rdgRecordingTimer1.Text = "disabled"
        '
        'chkScreenRecordWindow
        '
        Me.chkScreenRecordWindow.Checked = True
        Me.chkScreenRecordWindow.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkScreenRecordWindow.Enabled = False
        Me.chkScreenRecordWindow.Location = New System.Drawing.Point(93, 41)
        Me.chkScreenRecordWindow.Name = "chkScreenRecordWindow"
        Me.chkScreenRecordWindow.Size = New System.Drawing.Size(105, 32)
        Me.chkScreenRecordWindow.TabIndex = 48
        Me.chkScreenRecordWindow.Text = "e.g. source = screen window"
        '
        'lblStartRecordingControlled
        '
        Me.lblStartRecordingControlled.AutoSize = True
        Me.lblStartRecordingControlled.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblStartRecordingControlled.Location = New System.Drawing.Point(38, 50)
        Me.lblStartRecordingControlled.Name = "lblStartRecordingControlled"
        Me.lblStartRecordingControlled.Size = New System.Drawing.Size(49, 14)
        Me.lblStartRecordingControlled.TabIndex = 46
        Me.lblStartRecordingControlled.Text = "seconds"
        '
        'edtRecordingTimer
        '
        Me.edtRecordingTimer.Location = New System.Drawing.Point(8, 48)
        Me.edtRecordingTimer.Name = "edtRecordingTimer"
        Me.edtRecordingTimer.Size = New System.Drawing.Size(28, 20)
        Me.edtRecordingTimer.TabIndex = 45
        Me.edtRecordingTimer.Text = "0"
        '
        'rdgCompressTypeVideo
        '
        Me.rdgCompressTypeVideo.BackColor = System.Drawing.SystemColors.Control
        Me.rdgCompressTypeVideo.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgCompressTypeVideo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgCompressTypeVideo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgCompressTypeVideo.Location = New System.Drawing.Point(8, 16)
        Me.rdgCompressTypeVideo.Name = "rdgCompressTypeVideo"
        Me.rdgCompressTypeVideo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgCompressTypeVideo.Size = New System.Drawing.Size(88, 17)
        Me.rdgCompressTypeVideo.TabIndex = 18
        Me.rdgCompressTypeVideo.TabStop = True
        Me.rdgCompressTypeVideo.Tag = "0"
        Me.rdgCompressTypeVideo.Text = "video"
        Me.rdgCompressTypeVideo.UseVisualStyleBackColor = False
        '
        'rdgCompressTypeAudioVideo
        '
        Me.rdgCompressTypeAudioVideo.BackColor = System.Drawing.SystemColors.Control
        Me.rdgCompressTypeAudioVideo.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgCompressTypeAudioVideo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgCompressTypeAudioVideo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgCompressTypeAudioVideo.Location = New System.Drawing.Point(8, 48)
        Me.rdgCompressTypeAudioVideo.Name = "rdgCompressTypeAudioVideo"
        Me.rdgCompressTypeAudioVideo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgCompressTypeAudioVideo.Size = New System.Drawing.Size(89, 17)
        Me.rdgCompressTypeAudioVideo.TabIndex = 19
        Me.rdgCompressTypeAudioVideo.TabStop = True
        Me.rdgCompressTypeAudioVideo.Tag = "2"
        Me.rdgCompressTypeAudioVideo.Text = "audio + video"
        Me.rdgCompressTypeAudioVideo.UseVisualStyleBackColor = False
        '
        'rdgCompressTypeAudio
        '
        Me.rdgCompressTypeAudio.BackColor = System.Drawing.SystemColors.Control
        Me.rdgCompressTypeAudio.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgCompressTypeAudio.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgCompressTypeAudio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgCompressTypeAudio.Location = New System.Drawing.Point(8, 32)
        Me.rdgCompressTypeAudio.Name = "rdgCompressTypeAudio"
        Me.rdgCompressTypeAudio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgCompressTypeAudio.Size = New System.Drawing.Size(81, 17)
        Me.rdgCompressTypeAudio.TabIndex = 20
        Me.rdgCompressTypeAudio.TabStop = True
        Me.rdgCompressTypeAudio.Tag = "1"
        Me.rdgCompressTypeAudio.Text = "audio"
        Me.rdgCompressTypeAudio.UseVisualStyleBackColor = False
        '
        'rdgCompressType
        '
        Me.rdgCompressType.BackColor = System.Drawing.SystemColors.Control
        Me.rdgCompressType.Controls.Add(Me.rdgCompressTypeAudio)
        Me.rdgCompressType.Controls.Add(Me.rdgCompressTypeAudioVideo)
        Me.rdgCompressType.Controls.Add(Me.rdgCompressTypeVideo)
        Me.rdgCompressType.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgCompressType.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgCompressType.Location = New System.Drawing.Point(662, 71)
        Me.rdgCompressType.Name = "rdgCompressType"
        Me.rdgCompressType.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgCompressType.Size = New System.Drawing.Size(102, 70)
        Me.rdgCompressType.TabIndex = 17
        Me.rdgCompressType.TabStop = False
        Me.rdgCompressType.Text = "compress. type"
        '
        'rdgCompressModeOnTheFly
        '
        Me.rdgCompressModeOnTheFly.BackColor = System.Drawing.SystemColors.Control
        Me.rdgCompressModeOnTheFly.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgCompressModeOnTheFly.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgCompressModeOnTheFly.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgCompressModeOnTheFly.Location = New System.Drawing.Point(8, 32)
        Me.rdgCompressModeOnTheFly.Name = "rdgCompressModeOnTheFly"
        Me.rdgCompressModeOnTheFly.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgCompressModeOnTheFly.Size = New System.Drawing.Size(81, 17)
        Me.rdgCompressModeOnTheFly.TabIndex = 22
        Me.rdgCompressModeOnTheFly.TabStop = True
        Me.rdgCompressModeOnTheFly.Tag = "1"
        Me.rdgCompressModeOnTheFly.Text = "on the fly"
        Me.rdgCompressModeOnTheFly.UseVisualStyleBackColor = False
        '
        'rdgCompressModeAfterCapture
        '
        Me.rdgCompressModeAfterCapture.BackColor = System.Drawing.SystemColors.Control
        Me.rdgCompressModeAfterCapture.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgCompressModeAfterCapture.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgCompressModeAfterCapture.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgCompressModeAfterCapture.Location = New System.Drawing.Point(8, 48)
        Me.rdgCompressModeAfterCapture.Name = "rdgCompressModeAfterCapture"
        Me.rdgCompressModeAfterCapture.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgCompressModeAfterCapture.Size = New System.Drawing.Size(88, 17)
        Me.rdgCompressModeAfterCapture.TabIndex = 23
        Me.rdgCompressModeAfterCapture.TabStop = True
        Me.rdgCompressModeAfterCapture.Tag = "2"
        Me.rdgCompressModeAfterCapture.Text = "after capture"
        Me.rdgCompressModeAfterCapture.UseVisualStyleBackColor = False
        '
        'rdgCompressModeNo
        '
        Me.rdgCompressModeNo.BackColor = System.Drawing.SystemColors.Control
        Me.rdgCompressModeNo.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgCompressModeNo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgCompressModeNo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgCompressModeNo.Location = New System.Drawing.Point(8, 16)
        Me.rdgCompressModeNo.Name = "rdgCompressModeNo"
        Me.rdgCompressModeNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgCompressModeNo.Size = New System.Drawing.Size(57, 17)
        Me.rdgCompressModeNo.TabIndex = 24
        Me.rdgCompressModeNo.TabStop = True
        Me.rdgCompressModeNo.Tag = "0"
        Me.rdgCompressModeNo.Text = "no"
        Me.rdgCompressModeNo.UseVisualStyleBackColor = False
        '
        'rdgCompressMode
        '
        Me.rdgCompressMode.BackColor = System.Drawing.SystemColors.Control
        Me.rdgCompressMode.Controls.Add(Me.rdgCompressModeNo)
        Me.rdgCompressMode.Controls.Add(Me.rdgCompressModeAfterCapture)
        Me.rdgCompressMode.Controls.Add(Me.rdgCompressModeOnTheFly)
        Me.rdgCompressMode.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgCompressMode.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgCompressMode.Location = New System.Drawing.Point(662, 0)
        Me.rdgCompressMode.Name = "rdgCompressMode"
        Me.rdgCompressMode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgCompressMode.Size = New System.Drawing.Size(102, 70)
        Me.rdgCompressMode.TabIndex = 21
        Me.rdgCompressMode.TabStop = False
        Me.rdgCompressMode.Text = "compress. mode"
        '
        'btnCodecExamples
        '
        Me.btnCodecExamples.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCodecExamples.Location = New System.Drawing.Point(576, 164)
        Me.btnCodecExamples.Name = "btnCodecExamples"
        Me.btnCodecExamples.Size = New System.Drawing.Size(354, 20)
        Me.btnCodecExamples.TabIndex = 85
        Me.btnCodecExamples.Text = "Examples of compatible codecs depending on the recording method"
        '
        'cboMultiplexers
        '
        Me.cboMultiplexers.BackColor = System.Drawing.SystemColors.Window
        Me.cboMultiplexers.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboMultiplexers.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMultiplexers.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboMultiplexers.Location = New System.Drawing.Point(769, 124)
        Me.cboMultiplexers.Name = "cboMultiplexers"
        Me.cboMultiplexers.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboMultiplexers.Size = New System.Drawing.Size(161, 22)
        Me.cboMultiplexers.TabIndex = 86
        '
        'Label55
        '
        Me.Label55.BackColor = System.Drawing.SystemColors.Control
        Me.Label55.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label55.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label55.Location = New System.Drawing.Point(770, 110)
        Me.Label55.Name = "Label55"
        Me.Label55.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label55.Size = New System.Drawing.Size(162, 18)
        Me.Label55.TabIndex = 87
        Me.Label55.Text = "multiplexer (default = -1)"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(770, 146)
        Me.Button1.Name = "Button1"
        Me.Button1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button1.Size = New System.Drawing.Size(53, 18)
        Me.Button1.TabIndex = 88
        Me.Button1.Text = "settings"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Recording
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(952, 194)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cboMultiplexers)
        Me.Controls.Add(Me.Label55)
        Me.Controls.Add(Me.btnCodecExamples)
        Me.Controls.Add(Me.rdgCompressMode)
        Me.Controls.Add(Me.rdgCompressType)
        Me.Controls.Add(Me.btnMoreInfo)
        Me.Controls.Add(Me.rdgRecordingTimer)
        Me.Controls.Add(Me.btnCreatePreallocFileNow)
        Me.Controls.Add(Me.edtPreallocSize)
        Me.Controls.Add(Me.edtRecordingFileName)
        Me.Controls.Add(Me.btnStartRecordingImmediately)
        Me.Controls.Add(Me.btnStartRecordingControlled)
        Me.Controls.Add(Me.btnStopRecording)
        Me.Controls.Add(Me.btnRenewRecordingFile)
        Me.Controls.Add(Me.rdgRecordingMethod)
        Me.Controls.Add(Me.chkAudioRecording)
        Me.Controls.Add(Me.cboAudioFormats)
        Me.Controls.Add(Me.chkPreserveNativeFormat)
        Me.Controls.Add(Me.chkAVISaveToThisFile)
        Me.Controls.Add(Me.chkOpenDML)
        Me.Controls.Add(Me.chkPreallocFile)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.btnReloadAudioCompressorSettings)
        Me.Controls.Add(Me.btnSaveAudioCompressorSettings)
        Me.Controls.Add(Me.btnReloadVideoCompressorSettings)
        Me.Controls.Add(Me.btnSaveVideoCompressorSettings)
        Me.Controls.Add(Me.cboVideoCompressors)
        Me.Controls.Add(Me.btnVideoCompressorSettings)
        Me.Controls.Add(Me.cboAudioCompressors)
        Me.Controls.Add(Me.btnAudioCompressorSettings)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnResumeRecording)
        Me.Controls.Add(Me.btnPauseRecording)
        Me.Controls.Add(Me.chkRecordingOnMotion)
        Me.Controls.Add(Me.chkPauseCreatesNewFile)
        Me.Controls.Add(Me.chkRecordingCanPause)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(4, 23)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Recording"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "0"
        Me.rdgRecordingMethod.ResumeLayout(False)
        Me.rdgRecordingMethod.PerformLayout()
        Me.rdgRecordingTimer.ResumeLayout(False)
        Me.rdgRecordingTimer.PerformLayout()
        Me.rdgCompressType.ResumeLayout(False)
        Me.rdgCompressMode.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region

    Public Sub RefreshControls()
        SetRadioButtonInGroupUsingTag((rdgRecordingMethod), MainForm.DefInstance.VideoGrabber1.RecordingMethod)
        SetRadioButtonInGroupUsingTag((rdgCompressMode), MainForm.DefInstance.VideoGrabber1.CompressionMode)
        SetRadioButtonInGroupUsingTag((rdgCompressType), MainForm.DefInstance.VideoGrabber1.CompressionType)
        SetRadioButtonInGroupUsingTag((rdgRecordingTimer), MainForm.DefInstance.VideoGrabber1.RecordingTimer)

        edtPreallocSize.Text = MainForm.DefInstance.VideoGrabber1.PreallocCapFileSizeInMB
        chkRecordingCanPause.Checked = MainForm.DefInstance.VideoGrabber1.RecordingCanPause
        chkPauseCreatesNewFile.Checked = MainForm.DefInstance.VideoGrabber1.RecordingPauseCreatesNewFile
        chkRecordingOnMotion.Checked = MainForm.DefInstance.VideoGrabber1.RecordingOnMotion_Enabled

        chkPreallocFile.Checked = MainForm.DefInstance.VideoGrabber1.PreallocCapFileEnabled
        chkOpenDML.Checked = MainForm.DefInstance.VideoGrabber1.AVIFormatOpenDML
        chkPreserveNativeFormat.Checked = MainForm.DefInstance.VideoGrabber1.RecordingInNativeFormat

        chkAudioRecording.Checked = MainForm.DefInstance.VideoGrabber1.AudioRecording

        AssignListToComboBox((cboVideoCompressors), MainForm.DefInstance.VideoGrabber1.VideoCompressors, MainForm.DefInstance.VideoGrabber1.VideoCompressor)
        AssignListToComboBox((cboAudioCompressors), MainForm.DefInstance.VideoGrabber1.AudioCompressors, MainForm.DefInstance.VideoGrabber1.AudioCompressor)
        AssignListToComboBox((cboMultiplexers), MainForm.DefInstance.VideoGrabber1.Multiplexers, MainForm.DefInstance.VideoGrabber1.Multiplexer)

        AssignListToComboBox(cboAudioFormats, MainForm.DefInstance.VideoGrabber1.AudioFormats, MainForm.DefInstance.VideoGrabber1.AudioFormat)

        btnPauseRecording.Enabled = MainForm.DefInstance.VideoGrabber1.RecordingCanPause
        btnResumeRecording.Enabled = MainForm.DefInstance.VideoGrabber1.RecordingCanPause

        rdgCompressMode.Enabled = True
        rdgCompressType.Enabled = True

        chkScreenRecordWindow.Enabled = IIf(MainForm.DefInstance.VideoGrabber1.VideoSource = VidGrab.TVideoSource.vs_ScreenRecording, True, False)

        If Not MainForm.DefInstance.VideoGrabber1.AudioRecording Then
            'Recording.rdgCompressType.ItemIndex = 0
            rdgCompressType.Enabled = False
        End If

        chkOpenDML.Enabled = IIf(MainForm.DefInstance.VideoGrabber1.RecordingMethod = VidGrab.TRecordingMethod.rm_AVI, True, False)

        Dim CanUseCompressors As Boolean = (MainForm.DefInstance.VideoGrabber1.RecordingMethod <> VidGrab.TRecordingMethod.rm_ASF) _
            And (MainForm.DefInstance.VideoGrabber1.RecordingMethod <> VidGrab.TRecordingMethod.rm_SendToDV)

        Dim CanUseMultiplexer As Boolean = CanUseCompressors And (MainForm.DefInstance.VideoGrabber1.RecordingMethod <> VidGrab.TRecordingMethod.rm_AVI)
 
        rdgCompressMode.Enabled = CanUseCompressors
        rdgCompressType.Enabled = CanUseCompressors
        cboVideoCompressors.Enabled = CanUseCompressors
        btnVideoCompressorSettings.Enabled = CanUseCompressors
        cboAudioCompressors.Enabled = CanUseCompressors
        btnAudioCompressorSettings.Enabled = CanUseCompressors
        chkPreallocFile.Enabled = CanUseCompressors
        cboMultiplexers.Enabled = CanUseMultiplexer

    End Sub

    Private Sub btnVideoCompressorSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVideoCompressorSettings.Click
        MainForm.DefInstance.VideoGrabber1.ShowDialog(VidGrab.TDialog.dlg_VideoCompressor)
    End Sub

    Private Sub btnAudioCompressorSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAudioCompressorSettings.Click
        MainForm.DefInstance.VideoGrabber1.ShowDialog(VidGrab.TDialog.dlg_AudioCompressor)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MainForm.DefInstance.VideoGrabber1.ShowDialog(VidGrab.TDialog.dlg_Multiplexer)
    End Sub

    Private Sub btnCodecExamples_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCodecExamples.Click
        Dim SW_SHOW As Int32
        SW_SHOW = 5

        ShellExecute(0, "open", "http://www.datastead.com/tvideograbber-recording-codecs-examples.html?demo=vbnet", "", "", SW_SHOW)
    End Sub


    Private Sub btnSaveVideoCompressorSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveVideoCompressorSettings.Click
        Dim SaveDlg As SaveFileDialog = New SaveFileDialog
        SaveDlg.FileName = MainForm.VideoGrabber1.VideoCompressorName + " (" + MainForm.VideoGrabber1.RecordingMethod.ToString() + ").txt"
        If SaveDlg.ShowDialog() = DialogResult.OK Then
            ' be sure to have selected the RecordingMethod and VideoCompressor before invoking SaveCompressorSettings...

            MainForm.VideoGrabber1.SaveCompressorSettingsToTextFile(True, MainForm.VideoGrabber1.VideoCompressor, SaveDlg.FileName)

            ' remark: you can use instead SaveCompressorSettingsToDataString (TRUE, VideoGrabber.VideoCompressor, YourDataString)
        End If
    End Sub

    Private Sub btnSaveAudioCompressorSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveAudioCompressorSettings.Click
        Dim SaveDlg As SaveFileDialog = New SaveFileDialog
        SaveDlg.FileName = MainForm.VideoGrabber1.AudioCompressorName + " (" + MainForm.VideoGrabber1.RecordingMethod.ToString() + ").txt"
        If SaveDlg.ShowDialog() = DialogResult.OK Then
            ' be sure to have selected the RecordingMethod and AudioCompressor before invoking SaveCompressorSettings...

            MainForm.VideoGrabber1.SaveCompressorSettingsToTextFile(False, MainForm.VideoGrabber1.AudioCompressor, SaveDlg.FileName)

            ' remark: you can use instead SaveCompressorSettingsToDataString (FALSE, VideoGrabber.AudioCompressor, YourDataString)
        End If
    End Sub

    Private Sub btnReloadVideoCompressorSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReloadVideoCompressorSettings.Click
        Dim OpenDlg As OpenFileDialog = New OpenFileDialog
        OpenDlg.Filter = OPEN_COMPRESSOR_SETTINGS
        If OpenDlg.ShowDialog = DialogResult.OK Then

            MainForm.VideoGrabber1.LoadCompressorSettingsFromTextFile(True, MainForm.VideoGrabber1.VideoCompressor, OpenDlg.FileName)

            ' remark: you can use instead YourDataString := LoadCompressorSettingsFromDataString (TRUE, VideoGrabber.VideoCompressor)
        End If
    End Sub

    Private Sub btnReloadAudioCompressorSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReloadAudioCompressorSettings.Click
        Dim OpenDlg As OpenFileDialog = New OpenFileDialog
        OpenDlg.Filter = OPEN_COMPRESSOR_SETTINGS
        If OpenDlg.ShowDialog = DialogResult.OK Then

            MainForm.VideoGrabber1.LoadCompressorSettingsFromTextFile(False, MainForm.VideoGrabber1.AudioCompressor, OpenDlg.FileName)

            ' remark: you can use instead YourDataString := LoadCompressorSettingsFromDataString (TRUE, VideoGrabber.AudioCompressor)
        End If
    End Sub

    Private Sub btnCreatePreallocFileNow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreatePreallocFileNow.Click
        MainForm.DefInstance.VideoGrabber1.CreatePreallocCapFile()
    End Sub

    Private Sub btnMoreInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoreInfo.Click
        MessageBox.Show("Means that the recording stream will not be uncompressed." & vbCrLf & "" & vbCrLf & "MUST BE ENABLED:" & vbCrLf & "- to record hardware-encoded MPEG" & vbCrLf & "- to record DV devices in native DV format" & vbCrLf & "- to record the DV date/time into the video clip and retrieve it during playback" & vbCrLf & "" & vbCrLf & "MUST BE DISABLED:" & vbCrLf & "- to record text and graphics overlays into the video clip, and retrieve them during playback", _
                "DataStead TVideoGrabber VB.NET OCX Demo", MessageBoxButtons.OK)
    End Sub

    Private Sub btnPauseRecording_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPauseRecording.Click
        MainForm.DefInstance.VideoGrabber1.PauseRecording()
    End Sub

    Private Sub btnRenewRecordingFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRenewRecordingFile.Click
        If chkAVISaveToThisFile.Checked Then
            MainForm.DefInstance.VideoGrabber1.RecordingFileName = edtRecordingFileName.Text
        Else
            MainForm.DefInstance.VideoGrabber1.RecordingFileName = ""
        End If
        MainForm.DefInstance.VideoGrabber1.RecordToNewFileNow("", True)
    End Sub

    Private Sub btnResumeRecording_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResumeRecording.Click
        MainForm.DefInstance.VideoGrabber1.ResumeRecording()
    End Sub


    Private Sub btnStartRecordingControlled_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartRecordingControlled.Click
        If chkAVISaveToThisFile.Checked Then
            MainForm.DefInstance.VideoGrabber1.RecordingFileName = edtRecordingFileName.Text
        Else
            MainForm.DefInstance.VideoGrabber1.RecordingFileName = ""
        End If

        MainForm.DefInstance.VideoGrabber1.HoldRecording = True
        MainForm.DefInstance.VideoGrabber1.StartRecording()

        ' Enabling HoldRecording before calling StartRecording prevents the recording
        '  to start (when the recording graph is built) until the
        '  OnRecordingReadyToStart event is fired, where ResumeRecording must be invoked
        '  to commence recording, or StopRecording to cancel recording
        ' EXCEPTION: RecordingTimer = rt_StartRecording: recording is started
        '  after RecordingTimerInterval regardless of HoldRecording setting,
        '  and OnRecordingReadyToStart event is not fired

        If (MainForm.DefInstance.VideoGrabber1.RecordingTimer = VidGrab.TRecordingTimer.rt_StartRecording) And (MainForm.DefInstance.VideoGrabber1.VideoSource = VidGrab.TVideoSource.vs_ScreenRecording) And (chkScreenRecordWindow.Checked = True) And (lngScreenRecordingWindow > 0) Then
            ' for screen recording of a window, this code will make it the top window before recording start;
            '  window handle was gathered by EnumerateWindows in OnEnumerateWindows
            ' (see demo procedures in VideoSource form btnScreenRecordingWindow and SetEnumerateWindows)
            InsetForms.SetWindowPos(wenScreenRecordingWindow(lngScreenRecordingWindow - 1).WindowHandle, InsetForms.HWND_TOP, 0, 0, 0, 0, SWP_NOMOVE Or SWP_NOSIZE)
        End If
    End Sub

    Private Sub rdgRecordingTimer1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgRecordingTimer1.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.RecordingTimer = VidGrab.TRecordingTimer.rt_Disabled
    End Sub

    Private Sub rdgRecordingTimer2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgRecordingTimer2.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.RecordingTimer = VidGrab.TRecordingTimer.rt_RecordToNewFile
    End Sub

    Private Sub rdgRecordingTimer3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgRecordingTimer3.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.RecordingTimer = VidGrab.TRecordingTimer.rt_StopRecording
    End Sub

    Private Sub rdgRecordingTimer4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgRecordingTimer4.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.RecordingTimer = VidGrab.TRecordingTimer.rt_StartRecording
    End Sub

    Private Sub edtRecordingTimer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtRecordingTimer.TextChanged
        If Val(edtRecordingTimer.Text) > 0 Then
            MainForm.DefInstance.VideoGrabber1.RecordingTimerInterval = Val(edtRecordingTimer.Text)
        Else
            MainForm.DefInstance.VideoGrabber1.RecordingTimerInterval = 0
        End If
    End Sub

    Private Sub chkScreenRecordWindow_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkScreenRecordWindow.CheckedChanged
        ' for source = screen demonstration purposes, if:
        ' - VideoSource = vs_ScreenRecording
        ' - source window handle is identified with VideoSource form btnScreenRecordingWindow
        '   via EnumerateWindows and OnEnumerateWindows event (SetEnumerateWindows demo procedure)
        ' - chkScreenRecordWindow is enabled
        ' source window will be made top window at recording start (using API SetWindowPos),
        '  see Recording form btnStartRecordingImmediately and btnStartRecordingControlled,
        '  and events OnEnumerateWindows, OnRecordingReadyToStart
    End Sub

    Private Sub btnStartRecordingImmediately_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartRecordingImmediately.Click
        If chkAVISaveToThisFile.Checked Then
            MainForm.DefInstance.VideoGrabber1.RecordingFileName = edtRecordingFileName.Text
        Else
            MainForm.DefInstance.VideoGrabber1.RecordingFileName = ""
        End If
        ' Enabling HoldRecording before calling StartRecording prevents the recording
        '  to start (when the recording graph is built) until the
        '  OnRecordingReadyToStart event is fired, where ResumeRecording must be invoked
        '  to commence recording, or StopRecording to cancel recording
        ' EXCEPTION: RecordingTimer = rt_StartRecording: recording is started
        '  after RecordingTimerInterval regardless of HoldRecording setting,
        '  and OnRecordingReadyToStart event is not fired
        MainForm.DefInstance.VideoGrabber1.HoldRecording = False ' let's start recording as soon as the graph is built.
        If (MainForm.DefInstance.VideoGrabber1.RecordingTimer = VidGrab.TRecordingTimer.rt_StartRecording) And (MainForm.DefInstance.VideoGrabber1.VideoSource = VidGrab.TVideoSource.vs_ScreenRecording) And (chkScreenRecordWindow.Checked = True) And (lngScreenRecordingWindow > 0) Then
            ' for screen recording of a window, this code will make it the top window before recording start;
            '  window handle was gathered by EnumerateWindows in OnEnumerateWindows
            ' (see demo procedures in VideoSource form btnScreenRecordingWindow and SetEnumerateWindows)
            InsetForms.SetWindowPos(wenScreenRecordingWindow(lngScreenRecordingWindow - 1).WindowHandle, InsetForms.HWND_TOP, 0, 0, 0, 0, SWP_NOMOVE Or SWP_NOSIZE)
        End If
        MainForm.DefInstance.VideoGrabber1.StartRecording()
    End Sub


    Private Sub btnStopRecording_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStopRecording.Click
        MainForm.DefInstance.VideoGrabber1.StopRecording()
    End Sub

    Private Sub cboAudioCompressors_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAudioCompressors.SelectedIndexChanged
        MainForm.DefInstance.VideoGrabber1.AudioCompressor = cboAudioCompressors.SelectedIndex
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMultiplexers.SelectedIndexChanged
        MainForm.DefInstance.VideoGrabber1.Multiplexer = cboMultiplexers.SelectedIndex
    End Sub

    Private Sub cboAudioFormats_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAudioFormats.SelectedIndexChanged
        MainForm.DefInstance.VideoGrabber1.AudioFormat = cboAudioFormats.SelectedIndex
    End Sub

    Private Sub cboVideoCompressors_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboVideoCompressors.SelectedIndexChanged
        MainForm.DefInstance.VideoGrabber1.VideoCompressor = cboVideoCompressors.SelectedIndex
    End Sub

    Private Sub chkAudioRecording_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAudioRecording.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.AudioRecording = chkAudioRecording.Checked
        ''MainForm.DefInstance.RefreshDeviceControls()
    End Sub

    Private Sub chkOpenDML_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOpenDML.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.AVIFormatOpenDML = chkOpenDML.Checked
    End Sub

    Private Sub chkPreallocFile_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPreallocFile.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.PreallocCapFileEnabled = chkPreallocFile.Checked
    End Sub

    Private Sub chkPreserveNativeFormat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPreserveNativeFormat.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.RecordingInNativeFormat = chkPreserveNativeFormat.Checked
    End Sub

    Private Sub chkRecordingCanPause_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRecordingCanPause.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.RecordingCanPause = chkRecordingCanPause.Checked
        btnPauseRecording.Enabled = MainForm.DefInstance.VideoGrabber1.RecordingCanPause
        btnResumeRecording.Enabled = MainForm.DefInstance.VideoGrabber1.RecordingCanPause
    End Sub

    Private Sub chkPauseCreatesNewFile_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPauseCreatesNewFile.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.RecordingPauseCreatesNewFile = chkPauseCreatesNewFile.Checked
    End Sub

    Private Sub chkRecordingOnMotion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRecordingOnMotion.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.RecordingOnMotion_Enabled = chkRecordingOnMotion.Checked
        chkRecordingCanPause.Checked = chkRecordingOnMotion.Checked
    End Sub

    Private Sub edtPreallocSize_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtPreallocSize.TextChanged
        If IsNumeric(edtPreallocSize.Text) Then
            MainForm.DefInstance.VideoGrabber1.PreallocCapFileSizeInMB = edtPreallocSize.Text
        End If
    End Sub

    Private Sub rdgCompressMode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgCompressModeAfterCapture.CheckedChanged
        If CType(sender, RadioButton).Checked Then
            MainForm.DefInstance.VideoGrabber1.CompressionMode = sender.Tag
        End If
    End Sub

    Private Sub rdgCompressType_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgCompressTypeAudio.CheckedChanged
        If CType(sender, RadioButton).Checked Then
            MainForm.DefInstance.VideoGrabber1.CompressionType = sender.Tag
        End If
    End Sub

    Private Sub rdgRecordingMethod_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgRecordingMethodAVI.CheckedChanged, rdgRecordingMethodWMV.CheckedChanged, rdgRecordingMethodSendToDV.CheckedChanged, rdgRecordingMethodMKV.CheckedChanged, rdgRecordingMethodFLV.CheckedChanged, rdgRecordingMethodMP4.CheckedChanged, rdgRecordingMethod_WebM.CheckedChanged
        If CType(sender, RadioButton).Checked Then
            MainForm.DefInstance.VideoGrabber1.RecordingMethod = sender.Tag
            RefreshControls()
        End If
    End Sub


    Private Sub BtnASFinfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnASFinfo.Click
        MessageBox.Show("the ASF (WMV) settings are located in the 'network streaming' tab", _
                "DataStead TVideoGrabber VB.NET OCX Demo", MessageBoxButtons.OK)
    End Sub

    Private Sub btnSendToDVinfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendToDVinfo.Click
        MessageBox.Show("the recording is sent to the DV camcorder (this feature is also called 'print to DV')", _
                "DataStead TVideoGrabber VB.NET OCX Demo", MessageBoxButtons.OK)
    End Sub

    Private Sub Recording_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        If Visible Then
            RefreshControls()
        End If
    End Sub

    Private Sub Recording_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

End Class
