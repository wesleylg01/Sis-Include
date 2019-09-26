Friend Class miscVideoQuality
    Inherits SubForm ' SubForm is declared in VBUtil and inherits from System.Windows.Forms.Form
    'Unlike normal Form, it is not destroyed when closed, unless MainForm is being destroyed too.

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbrBrightness As System.Windows.Forms.TrackBar
    Friend WithEvents tbrGamma As System.Windows.Forms.TrackBar
    Friend WithEvents tbrSharpness As System.Windows.Forms.TrackBar
    Friend WithEvents tbrWhiteBalance As System.Windows.Forms.TrackBar
    Friend WithEvents tbrHue As System.Windows.Forms.TrackBar
    Friend WithEvents tbrSaturation As System.Windows.Forms.TrackBar
    Friend WithEvents tbrContrast As System.Windows.Forms.TrackBar
    Friend WithEvents btnBrightness As System.Windows.Forms.Button
    Friend WithEvents btnContrast As System.Windows.Forms.Button
    Friend WithEvents btnHue As System.Windows.Forms.Button
    Friend WithEvents btnSaturation As System.Windows.Forms.Button
    Friend WithEvents btnSharpness As System.Windows.Forms.Button
    Friend WithEvents btnGamma As System.Windows.Forms.Button
    Friend WithEvents btnWhiteBalance As System.Windows.Forms.Button
    Friend WithEvents chkBrightness As System.Windows.Forms.CheckBox
    Friend WithEvents chkContrast As System.Windows.Forms.CheckBox
    Friend WithEvents chkHue As System.Windows.Forms.CheckBox
    Friend WithEvents chkSaturation As System.Windows.Forms.CheckBox
    Friend WithEvents chkSharpness As System.Windows.Forms.CheckBox
    Friend WithEvents chkGamma As System.Windows.Forms.CheckBox
    Friend WithEvents chkWhiteBalance As System.Windows.Forms.CheckBox
    Friend WithEvents chkGain As System.Windows.Forms.CheckBox
    Friend WithEvents btnGain As System.Windows.Forms.Button
    Friend WithEvents tbrGain As System.Windows.Forms.TrackBar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.tbrBrightness = New System.Windows.Forms.TrackBar
        Me.tbrGamma = New System.Windows.Forms.TrackBar
        Me.tbrSharpness = New System.Windows.Forms.TrackBar
        Me.tbrWhiteBalance = New System.Windows.Forms.TrackBar
        Me.tbrHue = New System.Windows.Forms.TrackBar
        Me.tbrSaturation = New System.Windows.Forms.TrackBar
        Me.tbrContrast = New System.Windows.Forms.TrackBar
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnBrightness = New System.Windows.Forms.Button
        Me.btnContrast = New System.Windows.Forms.Button
        Me.btnHue = New System.Windows.Forms.Button
        Me.btnSaturation = New System.Windows.Forms.Button
        Me.btnSharpness = New System.Windows.Forms.Button
        Me.btnGamma = New System.Windows.Forms.Button
        Me.btnWhiteBalance = New System.Windows.Forms.Button
        Me.chkBrightness = New System.Windows.Forms.CheckBox
        Me.chkContrast = New System.Windows.Forms.CheckBox
        Me.chkHue = New System.Windows.Forms.CheckBox
        Me.chkSaturation = New System.Windows.Forms.CheckBox
        Me.chkSharpness = New System.Windows.Forms.CheckBox
        Me.chkGamma = New System.Windows.Forms.CheckBox
        Me.chkWhiteBalance = New System.Windows.Forms.CheckBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.chkGain = New System.Windows.Forms.CheckBox
        Me.btnGain = New System.Windows.Forms.Button
        Me.tbrGain = New System.Windows.Forms.TrackBar
        Me.Label8 = New System.Windows.Forms.Label
        CType(Me.tbrBrightness, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbrGamma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbrSharpness, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbrWhiteBalance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbrHue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbrSaturation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbrContrast, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbrGain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbrBrightness
        '
        Me.tbrBrightness.Location = New System.Drawing.Point(24, 24)
        Me.tbrBrightness.Name = "tbrBrightness"
        Me.tbrBrightness.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbrBrightness.Size = New System.Drawing.Size(45, 184)
        Me.tbrBrightness.TabIndex = 0
        Me.tbrBrightness.Tag = "0"
        Me.tbrBrightness.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'tbrGamma
        '
        Me.tbrGamma.Location = New System.Drawing.Point(304, 24)
        Me.tbrGamma.Name = "tbrGamma"
        Me.tbrGamma.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbrGamma.Size = New System.Drawing.Size(45, 184)
        Me.tbrGamma.TabIndex = 1
        Me.tbrGamma.Tag = "5"
        Me.tbrGamma.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'tbrSharpness
        '
        Me.tbrSharpness.Location = New System.Drawing.Point(248, 24)
        Me.tbrSharpness.Name = "tbrSharpness"
        Me.tbrSharpness.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbrSharpness.Size = New System.Drawing.Size(45, 184)
        Me.tbrSharpness.TabIndex = 2
        Me.tbrSharpness.Tag = "4"
        Me.tbrSharpness.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'tbrWhiteBalance
        '
        Me.tbrWhiteBalance.Location = New System.Drawing.Point(360, 24)
        Me.tbrWhiteBalance.Name = "tbrWhiteBalance"
        Me.tbrWhiteBalance.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbrWhiteBalance.Size = New System.Drawing.Size(45, 184)
        Me.tbrWhiteBalance.TabIndex = 3
        Me.tbrWhiteBalance.Tag = "7"
        Me.tbrWhiteBalance.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'tbrHue
        '
        Me.tbrHue.Location = New System.Drawing.Point(136, 24)
        Me.tbrHue.Name = "tbrHue"
        Me.tbrHue.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbrHue.Size = New System.Drawing.Size(45, 184)
        Me.tbrHue.TabIndex = 4
        Me.tbrHue.Tag = "2"
        Me.tbrHue.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'tbrSaturation
        '
        Me.tbrSaturation.Location = New System.Drawing.Point(192, 24)
        Me.tbrSaturation.Name = "tbrSaturation"
        Me.tbrSaturation.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbrSaturation.Size = New System.Drawing.Size(45, 184)
        Me.tbrSaturation.TabIndex = 5
        Me.tbrSaturation.Tag = "3"
        Me.tbrSaturation.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'tbrContrast
        '
        Me.tbrContrast.Location = New System.Drawing.Point(80, 24)
        Me.tbrContrast.Name = "tbrContrast"
        Me.tbrContrast.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbrContrast.Size = New System.Drawing.Size(45, 184)
        Me.tbrContrast.TabIndex = 6
        Me.tbrContrast.Tag = "1"
        Me.tbrContrast.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(80, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "contrast"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(144, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "hue"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(184, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "saturation"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(240, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "sharpness"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(304, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "gamma"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(360, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "white bal."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "brightness"
        '
        'btnBrightness
        '
        Me.btnBrightness.Location = New System.Drawing.Point(24, 216)
        Me.btnBrightness.Name = "btnBrightness"
        Me.btnBrightness.Size = New System.Drawing.Size(48, 16)
        Me.btnBrightness.TabIndex = 15
        Me.btnBrightness.Tag = "0"
        Me.btnBrightness.Text = "default"
        '
        'btnContrast
        '
        Me.btnContrast.Location = New System.Drawing.Point(80, 216)
        Me.btnContrast.Name = "btnContrast"
        Me.btnContrast.Size = New System.Drawing.Size(48, 16)
        Me.btnContrast.TabIndex = 16
        Me.btnContrast.Tag = "1"
        Me.btnContrast.Text = "default"
        '
        'btnHue
        '
        Me.btnHue.Location = New System.Drawing.Point(136, 216)
        Me.btnHue.Name = "btnHue"
        Me.btnHue.Size = New System.Drawing.Size(48, 16)
        Me.btnHue.TabIndex = 17
        Me.btnHue.Tag = "2"
        Me.btnHue.Text = "default"
        '
        'btnSaturation
        '
        Me.btnSaturation.Location = New System.Drawing.Point(192, 216)
        Me.btnSaturation.Name = "btnSaturation"
        Me.btnSaturation.Size = New System.Drawing.Size(48, 16)
        Me.btnSaturation.TabIndex = 18
        Me.btnSaturation.Tag = "3"
        Me.btnSaturation.Text = "default"
        '
        'btnSharpness
        '
        Me.btnSharpness.Location = New System.Drawing.Point(248, 216)
        Me.btnSharpness.Name = "btnSharpness"
        Me.btnSharpness.Size = New System.Drawing.Size(48, 16)
        Me.btnSharpness.TabIndex = 19
        Me.btnSharpness.Tag = "4"
        Me.btnSharpness.Text = "default"
        '
        'btnGamma
        '
        Me.btnGamma.Location = New System.Drawing.Point(304, 216)
        Me.btnGamma.Name = "btnGamma"
        Me.btnGamma.Size = New System.Drawing.Size(48, 16)
        Me.btnGamma.TabIndex = 20
        Me.btnGamma.Tag = "5"
        Me.btnGamma.Text = "default"
        '
        'btnWhiteBalance
        '
        Me.btnWhiteBalance.Location = New System.Drawing.Point(360, 216)
        Me.btnWhiteBalance.Name = "btnWhiteBalance"
        Me.btnWhiteBalance.Size = New System.Drawing.Size(48, 16)
        Me.btnWhiteBalance.TabIndex = 21
        Me.btnWhiteBalance.Tag = "6"
        Me.btnWhiteBalance.Text = "default"
        '
        'chkBrightness
        '
        Me.chkBrightness.Location = New System.Drawing.Point(24, 240)
        Me.chkBrightness.Name = "chkBrightness"
        Me.chkBrightness.Size = New System.Drawing.Size(48, 16)
        Me.chkBrightness.TabIndex = 22
        Me.chkBrightness.Tag = "0"
        Me.chkBrightness.Text = "auto"
        '
        'chkContrast
        '
        Me.chkContrast.Location = New System.Drawing.Point(80, 240)
        Me.chkContrast.Name = "chkContrast"
        Me.chkContrast.Size = New System.Drawing.Size(48, 16)
        Me.chkContrast.TabIndex = 23
        Me.chkContrast.Tag = "1"
        Me.chkContrast.Text = "auto"
        '
        'chkHue
        '
        Me.chkHue.Location = New System.Drawing.Point(136, 240)
        Me.chkHue.Name = "chkHue"
        Me.chkHue.Size = New System.Drawing.Size(48, 16)
        Me.chkHue.TabIndex = 24
        Me.chkHue.Tag = "2"
        Me.chkHue.Text = "auto"
        '
        'chkSaturation
        '
        Me.chkSaturation.Location = New System.Drawing.Point(192, 240)
        Me.chkSaturation.Name = "chkSaturation"
        Me.chkSaturation.Size = New System.Drawing.Size(48, 16)
        Me.chkSaturation.TabIndex = 25
        Me.chkSaturation.Tag = "3"
        Me.chkSaturation.Text = "auto"
        '
        'chkSharpness
        '
        Me.chkSharpness.Location = New System.Drawing.Point(248, 240)
        Me.chkSharpness.Name = "chkSharpness"
        Me.chkSharpness.Size = New System.Drawing.Size(48, 16)
        Me.chkSharpness.TabIndex = 26
        Me.chkSharpness.Tag = "4"
        Me.chkSharpness.Text = "auto"
        '
        'chkGamma
        '
        Me.chkGamma.Location = New System.Drawing.Point(304, 240)
        Me.chkGamma.Name = "chkGamma"
        Me.chkGamma.Size = New System.Drawing.Size(48, 16)
        Me.chkGamma.TabIndex = 27
        Me.chkGamma.Tag = "5"
        Me.chkGamma.Text = "auto"
        '
        'chkWhiteBalance
        '
        Me.chkWhiteBalance.Location = New System.Drawing.Point(360, 240)
        Me.chkWhiteBalance.Name = "chkWhiteBalance"
        Me.chkWhiteBalance.Size = New System.Drawing.Size(48, 16)
        Me.chkWhiteBalance.TabIndex = 28
        Me.chkWhiteBalance.Tag = "6"
        Me.chkWhiteBalance.Text = "auto"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(216, 280)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(72, 24)
        Me.btnClose.TabIndex = 29
        Me.btnClose.Text = "Close"
        '
        'chkGain
        '
        Me.chkGain.Location = New System.Drawing.Point(416, 240)
        Me.chkGain.Name = "chkGain"
        Me.chkGain.Size = New System.Drawing.Size(48, 16)
        Me.chkGain.TabIndex = 32
        Me.chkGain.Tag = "7"
        Me.chkGain.Text = "auto"
        '
        'btnGain
        '
        Me.btnGain.Location = New System.Drawing.Point(416, 216)
        Me.btnGain.Name = "btnGain"
        Me.btnGain.Size = New System.Drawing.Size(48, 16)
        Me.btnGain.TabIndex = 31
        Me.btnGain.Tag = "7"
        Me.btnGain.Text = "default"
        '
        'tbrGain
        '
        Me.tbrGain.Location = New System.Drawing.Point(416, 24)
        Me.tbrGain.Name = "tbrGain"
        Me.tbrGain.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbrGain.Size = New System.Drawing.Size(45, 184)
        Me.tbrGain.TabIndex = 30
        Me.tbrGain.Tag = "9"
        Me.tbrGain.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(424, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 16)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "gain"
        '
        'miscVideoQuality
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(504, 309)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.chkGain)
        Me.Controls.Add(Me.btnGain)
        Me.Controls.Add(Me.tbrGain)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.chkWhiteBalance)
        Me.Controls.Add(Me.chkGamma)
        Me.Controls.Add(Me.chkSharpness)
        Me.Controls.Add(Me.chkSaturation)
        Me.Controls.Add(Me.chkHue)
        Me.Controls.Add(Me.chkContrast)
        Me.Controls.Add(Me.chkBrightness)
        Me.Controls.Add(Me.btnWhiteBalance)
        Me.Controls.Add(Me.btnGamma)
        Me.Controls.Add(Me.btnSharpness)
        Me.Controls.Add(Me.btnSaturation)
        Me.Controls.Add(Me.btnHue)
        Me.Controls.Add(Me.btnContrast)
        Me.Controls.Add(Me.btnBrightness)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbrContrast)
        Me.Controls.Add(Me.tbrSaturation)
        Me.Controls.Add(Me.tbrHue)
        Me.Controls.Add(Me.tbrWhiteBalance)
        Me.Controls.Add(Me.tbrSharpness)
        Me.Controls.Add(Me.tbrGamma)
        Me.Controls.Add(Me.tbrBrightness)
        Me.Name = "miscVideoQuality"
        Me.Text = "miscVideoQuality"
        CType(Me.tbrBrightness, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbrGamma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbrSharpness, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbrWhiteBalance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbrHue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbrSaturation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbrContrast, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbrGain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Structure SettingGroup
        Dim tbrValue As TrackBar
        Dim chkAuto As CheckBox
        Dim btnDefault As Button
    End Structure

    Dim FSettingGroup(10) As SettingGroup

    Public Sub RefreshControls()
        InitTrackBar(chkBrightness, btnBrightness, tbrBrightness, vidgrab_NET.TxVideoQuality.vq_Brightness)
        InitTrackBar(chkContrast, btnContrast, tbrContrast, vidgrab_NET.TxVideoQuality.vq_Contrast)
        InitTrackBar(chkHue, btnHue, tbrHue, vidgrab_NET.TxVideoQuality.vq_Hue)
        InitTrackBar(chkSaturation, btnSaturation, tbrSaturation, vidgrab_NET.TxVideoQuality.vq_Saturation)
        InitTrackBar(chkSharpness, btnSharpness, tbrSharpness, vidgrab_NET.TxVideoQuality.vq_Sharpness)
        InitTrackBar(chkGamma, btnGamma, tbrGamma, vidgrab_NET.TxVideoQuality.vq_Gamma)
        InitTrackBar(chkWhiteBalance, btnWhiteBalance, tbrWhiteBalance, vidgrab_NET.TxVideoQuality.vq_WhiteBalance)
        InitTrackBar(chkGain, btnGain, tbrGain, vidgrab_NET.TxVideoQuality.vq_Gain)
    End Sub
    Private Sub InitTrackBar(ByRef chkAuto As CheckBox, ByRef btnDefault As Button, ByRef tbrValue As TrackBar, ByVal Setting As vidgrab_NET.TxVideoQuality)

        tbrValue.Tag = Setting

        AddHandler tbrValue.Scroll, AddressOf tbrSetValue
        AddHandler btnDefault.Click, AddressOf btnSetDefault
        AddHandler chkAuto.CheckedChanged, AddressOf tbrSetValue

        tbrValue.Tag = Setting
        chkAuto.Tag = Setting
        btnDefault.Tag = Setting

        FSettingGroup(Setting).tbrValue = tbrValue
        FSettingGroup(Setting).chkAuto = chkAuto
        FSettingGroup(Setting).btnDefault = btnDefault

        If Not MainForm.DefInstance.AxVideoGrabberNET1.IsVideoQualitySettingAvailable(Setting) Then
            tbrValue.Enabled = False
            tbrValue.TickFrequency = 0
            tbrValue.Minimum = 0
            tbrValue.Maximum = 1
            tbrValue.Value = 1
            chkAuto.Enabled = False
            btnDefault.Enabled = False
        Else
            chkAuto.Enabled = True
            chkAuto.Checked = MainForm.DefInstance.AxVideoGrabberNET1.VideoQualityAuto(Setting)
            tbrValue.Enabled = Not chkAuto.Checked
            btnDefault.Enabled = Not chkAuto.Checked

            Dim MinValue As Integer = MainForm.DefInstance.AxVideoGrabberNET1.VideoQualityMin(Setting)
            Dim MaxValue As Integer = MainForm.DefInstance.AxVideoGrabberNET1.VideoQualityMax(Setting)
            Dim CurrentValue As Integer = MainForm.DefInstance.AxVideoGrabberNET1.VideoQualityValue(Setting)

            If (MinValue < CurrentValue) Then
                MinValue = CurrentValue
            End If

            If (CurrentValue > MaxValue) Then
                MaxValue = CurrentValue
            End If

            tbrValue.Minimum = MinValue
            tbrValue.Maximum = MaxValue
            tbrValue.Value = CurrentValue
            tbrValue.TickFrequency = MainForm.DefInstance.AxVideoGrabberNET1.VideoQualityStep(Setting)
        End If
    End Sub

    Private Sub tbrSetValue(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbrBrightness.Scroll, chkBrightness.CheckedChanged

        Dim ct As Control = DirectCast(sender, Control)
        Dim Setting As vidgrab_NET.TxVideoQuality = DirectCast(ct.Tag, vidgrab_NET.TxVideoQuality)

        MainForm.DefInstance.AxVideoGrabberNET1.SetVideoQuality(Setting, FSettingGroup(Setting).chkAuto.Checked, False, FSettingGroup(Setting).tbrValue.Value)
        FSettingGroup(Setting).tbrValue.Enabled = Not FSettingGroup(Setting).chkAuto.Checked
        FSettingGroup(Setting).btnDefault.Enabled = Not FSettingGroup(Setting).chkAuto.Checked
    End Sub

    Private Sub btnSetDefault(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrightness.Click

        Dim ct As Control = DirectCast(sender, Control)
        Dim Setting As vidgrab_NET.TxVideoQuality = DirectCast(ct.Tag, vidgrab_NET.TxVideoQuality)

        MainForm.DefInstance.AxVideoGrabberNET1.SetVideoQuality(Setting, FSettingGroup(Setting).chkAuto.Checked, True, FSettingGroup(Setting).tbrValue.Value)
        FSettingGroup(Setting).tbrValue.Value = MainForm.DefInstance.AxVideoGrabberNET1.VideoQualityValue(Setting)
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub miscVideoQuality_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        If Visible Then
            RefreshControls()
        End If
    End Sub
End Class
