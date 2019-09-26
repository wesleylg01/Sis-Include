Option Strict Off
Option Explicit On 
Friend Class IPCamera
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
    Friend WithEvents edtIPCameraInfo As System.Windows.Forms.TextBox
    Friend WithEvents edtIPCamReceiveTimeout As System.Windows.Forms.TextBox
    Friend WithEvents edtIPCamConnectionTimeout As System.Windows.Forms.TextBox
    Friend WithEvents edtIPCameraURL As System.Windows.Forms.TextBox
    Friend WithEvents label5 As System.Windows.Forms.Label
    Friend WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
    Public WithEvents edtIPCamPassword As System.Windows.Forms.TextBox
    Public WithEvents edtIPCamUserName As System.Windows.Forms.TextBox
    Friend WithEvents btnIPCamStartPreview As System.Windows.Forms.Button
    Friend WithEvents btnIPCamera As System.Windows.Forms.Button
    Friend WithEvents lblFirstSelectIPCamera As System.Windows.Forms.Label
    Friend WithEvents edtIPCamCommand As System.Windows.Forms.TextBox
    Friend WithEvents btnIPCamSendCommand As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IPCamera))
        Me.edtIPCameraInfo = New System.Windows.Forms.TextBox
        Me.edtIPCamReceiveTimeout = New System.Windows.Forms.TextBox
        Me.edtIPCamConnectionTimeout = New System.Windows.Forms.TextBox
        Me.edtIPCameraURL = New System.Windows.Forms.TextBox
        Me.label5 = New System.Windows.Forms.Label
        Me.label4 = New System.Windows.Forms.Label
        Me.label3 = New System.Windows.Forms.Label
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me.label2 = New System.Windows.Forms.Label
        Me.label1 = New System.Windows.Forms.Label
        Me.edtIPCamPassword = New System.Windows.Forms.TextBox
        Me.edtIPCamUserName = New System.Windows.Forms.TextBox
        Me.btnIPCamStartPreview = New System.Windows.Forms.Button
        Me.btnIPCamera = New System.Windows.Forms.Button
        Me.lblFirstSelectIPCamera = New System.Windows.Forms.Label
        Me.edtIPCamCommand = New System.Windows.Forms.TextBox
        Me.btnIPCamSendCommand = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'edtIPCameraInfo
        '
        Me.edtIPCameraInfo.BackColor = System.Drawing.Color.Silver
        Me.edtIPCameraInfo.Location = New System.Drawing.Point(664, 4)
        Me.edtIPCameraInfo.Multiline = True
        Me.edtIPCameraInfo.Name = "edtIPCameraInfo"
        Me.edtIPCameraInfo.ReadOnly = True
        Me.edtIPCameraInfo.Size = New System.Drawing.Size(244, 177)
        Me.edtIPCameraInfo.TabIndex = 22
        Me.edtIPCameraInfo.Text = resources.GetString("edtIPCameraInfo.Text")
        '
        'edtIPCamReceiveTimeout
        '
        Me.edtIPCamReceiveTimeout.Location = New System.Drawing.Point(200, 85)
        Me.edtIPCamReceiveTimeout.Name = "edtIPCamReceiveTimeout"
        Me.edtIPCamReceiveTimeout.Size = New System.Drawing.Size(67, 20)
        Me.edtIPCamReceiveTimeout.TabIndex = 16
        Me.edtIPCamReceiveTimeout.Text = "5000"
        '
        'edtIPCamConnectionTimeout
        '
        Me.edtIPCamConnectionTimeout.Location = New System.Drawing.Point(200, 61)
        Me.edtIPCamConnectionTimeout.Name = "edtIPCamConnectionTimeout"
        Me.edtIPCamConnectionTimeout.Size = New System.Drawing.Size(67, 20)
        Me.edtIPCamConnectionTimeout.TabIndex = 15
        Me.edtIPCamConnectionTimeout.Text = "10000"
        '
        'edtIPCameraURL
        '
        Me.edtIPCameraURL.Location = New System.Drawing.Point(200, 38)
        Me.edtIPCameraURL.Name = "edtIPCameraURL"
        Me.edtIPCameraURL.Size = New System.Drawing.Size(458, 20)
        Me.edtIPCameraURL.TabIndex = 14
        Me.edtIPCameraURL.Text = "enter the MJPG or JPG URL of the IP camera (RTSP requires an additional filter)"
        '
        'label5
        '
        Me.label5.Location = New System.Drawing.Point(11, 85)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(189, 16)
        Me.label5.TabIndex = 21
        Me.label5.Text = "Receive timeout (in milliseconds):"
        Me.label5.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(8, 61)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(192, 16)
        Me.label4.TabIndex = 20
        Me.label4.Text = "Connection timeout  (in milliseconds):"
        Me.label4.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(0, 38)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(200, 16)
        Me.label3.TabIndex = 19
        Me.label3.Text = "URL of the IP camera:"
        Me.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.edtIPCamPassword)
        Me.groupBox1.Controls.Add(Me.edtIPCamUserName)
        Me.groupBox1.Location = New System.Drawing.Point(336, 88)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(321, 43)
        Me.groupBox1.TabIndex = 18
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "if authentication needed: "
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(169, 19)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(56, 12)
        Me.label2.TabIndex = 4
        Me.label2.Text = "password:"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(6, 17)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(64, 14)
        Me.label1.TabIndex = 3
        Me.label1.Text = "user name:"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'edtIPCamPassword
        '
        Me.edtIPCamPassword.Location = New System.Drawing.Point(229, 15)
        Me.edtIPCamPassword.Name = "edtIPCamPassword"
        Me.edtIPCamPassword.Size = New System.Drawing.Size(82, 20)
        Me.edtIPCamPassword.TabIndex = 2
        '
        'edtIPCamUserName
        '
        Me.edtIPCamUserName.Location = New System.Drawing.Point(76, 15)
        Me.edtIPCamUserName.Name = "edtIPCamUserName"
        Me.edtIPCamUserName.Size = New System.Drawing.Size(82, 20)
        Me.edtIPCamUserName.TabIndex = 1
        '
        'btnIPCamStartPreview
        '
        Me.btnIPCamStartPreview.Location = New System.Drawing.Point(200, 110)
        Me.btnIPCamStartPreview.Name = "btnIPCamStartPreview"
        Me.btnIPCamStartPreview.Size = New System.Drawing.Size(113, 22)
        Me.btnIPCamStartPreview.TabIndex = 17
        Me.btnIPCamStartPreview.Text = "Start preview"
        '
        'btnIPCamera
        '
        Me.btnIPCamera.Location = New System.Drawing.Point(200, 16)
        Me.btnIPCamera.Name = "btnIPCamera"
        Me.btnIPCamera.Size = New System.Drawing.Size(458, 20)
        Me.btnIPCamera.TabIndex = 13
        Me.btnIPCamera.Text = "e.g. URL of a public IP camera currently available (just copy the URL and paste i" & _
            "t below)"
        '
        'lblFirstSelectIPCamera
        '
        Me.lblFirstSelectIPCamera.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstSelectIPCamera.ForeColor = System.Drawing.Color.Red
        Me.lblFirstSelectIPCamera.Location = New System.Drawing.Point(4, 0)
        Me.lblFirstSelectIPCamera.Name = "lblFirstSelectIPCamera"
        Me.lblFirstSelectIPCamera.Size = New System.Drawing.Size(545, 14)
        Me.lblFirstSelectIPCamera.TabIndex = 12
        Me.lblFirstSelectIPCamera.Text = "first select VideoSource = vs_IPCamera in the Video Sources list of the  ""video s" & _
            "ource"" tab"
        '
        'edtIPCamCommand
        '
        Me.edtIPCamCommand.Location = New System.Drawing.Point(336, 136)
        Me.edtIPCamCommand.Name = "edtIPCamCommand"
        Me.edtIPCamCommand.Size = New System.Drawing.Size(271, 20)
        Me.edtIPCamCommand.TabIndex = 23
        Me.edtIPCamCommand.Text = "http://x.x.x.x/axis-cgi/com/ptz.cgi?move=home"
        '
        'btnIPCamSendCommand
        '
        Me.btnIPCamSendCommand.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIPCamSendCommand.Location = New System.Drawing.Point(605, 134)
        Me.btnIPCamSendCommand.Name = "btnIPCamSendCommand"
        Me.btnIPCamSendCommand.Size = New System.Drawing.Size(52, 22)
        Me.btnIPCamSendCommand.TabIndex = 24
        Me.btnIPCamSendCommand.Text = "SEND"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(0, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(338, 15)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Send an IP camera command (replace x.x.x.x by the real IP address):"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(648, 16)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "(e.g. for Axis PTZ commands, replace the last word of the the sample command abov" & _
            "e with ""home"", ""up"", ""down"", ""left"" or ""right"")"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(333, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(240, 16)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Start the recording in the ""Recording"" form"
        '
        'IPCamera
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1000, 228)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnIPCamSendCommand)
        Me.Controls.Add(Me.edtIPCamCommand)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.edtIPCameraInfo)
        Me.Controls.Add(Me.edtIPCamReceiveTimeout)
        Me.Controls.Add(Me.edtIPCamConnectionTimeout)
        Me.Controls.Add(Me.edtIPCameraURL)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.btnIPCamStartPreview)
        Me.Controls.Add(Me.btnIPCamera)
        Me.Controls.Add(Me.lblFirstSelectIPCamera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "IPCamera"
        Me.ShowInTaskbar = False
        Me.Text = "IPCamera"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public Sub RefreshControls()
        lblFirstSelectIPCamera.Visible = (MainForm.DefInstance.VideoGrabber1.VideoSource <> VidGrab.TVideoSource.vs_IPCamera)
    End Sub

    Private Sub btnIPCamera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIPCamera.Click
        Dim SW_SHOW As Int32
        SW_SHOW = 5

        ShellExecute(0, "open", "http://www.datastead.com/demo/IPCam.htm", "", "", SW_SHOW)
    End Sub

    Private Sub edtIPCameraURL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtIPCameraURL.TextChanged
        MainForm.DefInstance.VideoGrabber1.IPCameraURL = edtIPCameraURL.Text
    End Sub

    Private Sub edtIPCamUserName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtIPCamUserName.TextChanged
        MainForm.DefInstance.VideoGrabber1.SetAuthentication(VidGrab.TAuthenticationType.at_IPCamera, edtIPCamUserName.Text, edtIPCamPassword.Text)
    End Sub

    Private Sub edtIPCamPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtIPCamPassword.TextChanged
        MainForm.DefInstance.VideoGrabber1.SetAuthentication(VidGrab.TAuthenticationType.at_IPCamera, edtIPCamUserName.Text, edtIPCamPassword.Text)
    End Sub

    Private Sub edtIPCamConnectionTimeout_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtIPCamConnectionTimeout.TextChanged
        If IsNumeric(edtIPCamConnectionTimeout.Text) Then
            MainForm.DefInstance.VideoGrabber1.SetIPCameraSetting(VidGrab.TIPCameraSetting.ips_ConnectionTimeout, Convert.ToInt32(edtIPCamConnectionTimeout.Text))
        End If
    End Sub

    Private Sub edtIPCamReceiveTimeout_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtIPCamReceiveTimeout.TextChanged
        If (IsNumeric(edtIPCamReceiveTimeout.Text)) Then
            MainForm.DefInstance.VideoGrabber1.SetIPCameraSetting(VidGrab.TIPCameraSetting.ips_ReceiveTimeout, Convert.ToInt32(edtIPCamReceiveTimeout.Text))
        End If
    End Sub

    Private Sub btnIPCamStartPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIPCamStartPreview.Click
        If MainForm.DefInstance.VideoGrabber1.VideoSource <> VidGrab.TVideoSource.vs_IPCamera Then
            MainForm.DefInstance.VideoGrabber1.VideoSource = VidGrab.TVideoSource.vs_IPCamera
            AddLog(MainForm.DefInstance.mmoLog, "VideoSource set to ""vs_IPCamera""")
        End If
        MainForm.DefInstance.VideoGrabber1.StartPreview()
    End Sub

    Private Sub btnIPCamSendCommand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIPCamSendCommand.Click
        If MainForm.DefInstance.VideoGrabber1.SendIPCameraCommand(edtIPCamCommand.Text) Then
            AddLog(MainForm.DefInstance.mmoLog, "IP camera command successfully sent.")
        Else
            AddLog(MainForm.DefInstance.mmoLog, "failed to send the IP camera command (wrong IP address, command not supported or authentication failed)")
        End If
    End Sub

    Private Sub IPCamera_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        If Visible Then
            RefreshControls()
        End If
    End Sub

End Class
