Friend Class miscSpecialControl
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
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents btnPanTiltHome As System.Windows.Forms.Button
    Friend WithEvents btnPanTiltUp As System.Windows.Forms.Button
    Friend WithEvents btnPanTiltLeft As System.Windows.Forms.Button
    Friend WithEvents btnPanTiltDown As System.Windows.Forms.Button
    Friend WithEvents btnPanTiltRight As System.Windows.Forms.Button
    Friend WithEvents rdgGpio0off As System.Windows.Forms.RadioButton
    Friend WithEvents rdgGpio0on As System.Windows.Forms.RadioButton
    Friend WithEvents rdgGpio1on As System.Windows.Forms.RadioButton
    Friend WithEvents rdgGpio1off As System.Windows.Forms.RadioButton
    Friend WithEvents rdgGpio2on As System.Windows.Forms.RadioButton
    Friend WithEvents rdgGpio2off As System.Windows.Forms.RadioButton
    Friend WithEvents rdgGpio3on As System.Windows.Forms.RadioButton
    Friend WithEvents rdgGpio3off As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnClose = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnPanTiltRight = New System.Windows.Forms.Button
        Me.btnPanTiltDown = New System.Windows.Forms.Button
        Me.btnPanTiltLeft = New System.Windows.Forms.Button
        Me.btnPanTiltUp = New System.Windows.Forms.Button
        Me.btnPanTiltHome = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rdgGpio0on = New System.Windows.Forms.RadioButton
        Me.rdgGpio0off = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.rdgGpio1on = New System.Windows.Forms.RadioButton
        Me.rdgGpio1off = New System.Windows.Forms.RadioButton
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.rdgGpio2on = New System.Windows.Forms.RadioButton
        Me.rdgGpio2off = New System.Windows.Forms.RadioButton
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.rdgGpio3on = New System.Windows.Forms.RadioButton
        Me.rdgGpio3off = New System.Windows.Forms.RadioButton
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(144, 208)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(72, 24)
        Me.btnClose.TabIndex = 31
        Me.btnClose.Text = "Close"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnPanTiltRight)
        Me.GroupBox1.Controls.Add(Me.btnPanTiltDown)
        Me.GroupBox1.Controls.Add(Me.btnPanTiltLeft)
        Me.GroupBox1.Controls.Add(Me.btnPanTiltUp)
        Me.GroupBox1.Controls.Add(Me.btnPanTiltHome)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(184, 184)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PAN/TILT (motorized)"
        '
        'btnPanTiltRight
        '
        Me.btnPanTiltRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPanTiltRight.Location = New System.Drawing.Point(120, 72)
        Me.btnPanTiltRight.Name = "btnPanTiltRight"
        Me.btnPanTiltRight.Size = New System.Drawing.Size(40, 40)
        Me.btnPanTiltRight.TabIndex = 4
        Me.btnPanTiltRight.Text = ">"
        '
        'btnPanTiltDown
        '
        Me.btnPanTiltDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPanTiltDown.Location = New System.Drawing.Point(72, 120)
        Me.btnPanTiltDown.Name = "btnPanTiltDown"
        Me.btnPanTiltDown.Size = New System.Drawing.Size(40, 40)
        Me.btnPanTiltDown.TabIndex = 3
        Me.btnPanTiltDown.Text = "v"
        '
        'btnPanTiltLeft
        '
        Me.btnPanTiltLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPanTiltLeft.Location = New System.Drawing.Point(24, 72)
        Me.btnPanTiltLeft.Name = "btnPanTiltLeft"
        Me.btnPanTiltLeft.Size = New System.Drawing.Size(40, 40)
        Me.btnPanTiltLeft.TabIndex = 2
        Me.btnPanTiltLeft.Text = "<"
        '
        'btnPanTiltUp
        '
        Me.btnPanTiltUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPanTiltUp.Location = New System.Drawing.Point(72, 24)
        Me.btnPanTiltUp.Name = "btnPanTiltUp"
        Me.btnPanTiltUp.Size = New System.Drawing.Size(40, 40)
        Me.btnPanTiltUp.TabIndex = 1
        Me.btnPanTiltUp.Text = "^"
        '
        'btnPanTiltHome
        '
        Me.btnPanTiltHome.Location = New System.Drawing.Point(72, 72)
        Me.btnPanTiltHome.Name = "btnPanTiltHome"
        Me.btnPanTiltHome.Size = New System.Drawing.Size(40, 40)
        Me.btnPanTiltHome.TabIndex = 0
        Me.btnPanTiltHome.Text = "home"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdgGpio0on)
        Me.GroupBox2.Controls.Add(Me.rdgGpio0off)
        Me.GroupBox2.Location = New System.Drawing.Point(224, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(112, 40)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GPIO 0"
        '
        'rdgGpio0on
        '
        Me.rdgGpio0on.Location = New System.Drawing.Point(64, 12)
        Me.rdgGpio0on.Name = "rdgGpio0on"
        Me.rdgGpio0on.Size = New System.Drawing.Size(40, 24)
        Me.rdgGpio0on.TabIndex = 1
        Me.rdgGpio0on.Tag = "1"
        Me.rdgGpio0on.Text = "on"
        '
        'rdgGpio0off
        '
        Me.rdgGpio0off.Location = New System.Drawing.Point(16, 12)
        Me.rdgGpio0off.Name = "rdgGpio0off"
        Me.rdgGpio0off.Size = New System.Drawing.Size(56, 24)
        Me.rdgGpio0off.TabIndex = 0
        Me.rdgGpio0off.Tag = "0"
        Me.rdgGpio0off.Text = "off"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rdgGpio1on)
        Me.GroupBox3.Controls.Add(Me.rdgGpio1off)
        Me.GroupBox3.Location = New System.Drawing.Point(224, 56)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(112, 40)
        Me.GroupBox3.TabIndex = 34
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GPIO 0"
        '
        'rdgGpio1on
        '
        Me.rdgGpio1on.Location = New System.Drawing.Point(64, 12)
        Me.rdgGpio1on.Name = "rdgGpio1on"
        Me.rdgGpio1on.Size = New System.Drawing.Size(40, 24)
        Me.rdgGpio1on.TabIndex = 1
        Me.rdgGpio1on.Tag = "1"
        Me.rdgGpio1on.Text = "on"
        '
        'rdgGpio1off
        '
        Me.rdgGpio1off.Location = New System.Drawing.Point(16, 12)
        Me.rdgGpio1off.Name = "rdgGpio1off"
        Me.rdgGpio1off.Size = New System.Drawing.Size(56, 24)
        Me.rdgGpio1off.TabIndex = 0
        Me.rdgGpio1off.Tag = "0"
        Me.rdgGpio1off.Text = "off"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rdgGpio2on)
        Me.GroupBox4.Controls.Add(Me.rdgGpio2off)
        Me.GroupBox4.Location = New System.Drawing.Point(224, 104)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(112, 40)
        Me.GroupBox4.TabIndex = 34
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GPIO 0"
        '
        'rdgGpio2on
        '
        Me.rdgGpio2on.Location = New System.Drawing.Point(64, 12)
        Me.rdgGpio2on.Name = "rdgGpio2on"
        Me.rdgGpio2on.Size = New System.Drawing.Size(40, 24)
        Me.rdgGpio2on.TabIndex = 1
        Me.rdgGpio2on.Tag = "1"
        Me.rdgGpio2on.Text = "on"
        '
        'rdgGpio2off
        '
        Me.rdgGpio2off.Location = New System.Drawing.Point(16, 12)
        Me.rdgGpio2off.Name = "rdgGpio2off"
        Me.rdgGpio2off.Size = New System.Drawing.Size(56, 24)
        Me.rdgGpio2off.TabIndex = 0
        Me.rdgGpio2off.Tag = "0"
        Me.rdgGpio2off.Text = "off"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.rdgGpio3on)
        Me.GroupBox5.Controls.Add(Me.rdgGpio3off)
        Me.GroupBox5.Location = New System.Drawing.Point(224, 152)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(112, 40)
        Me.GroupBox5.TabIndex = 35
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "GPIO 0"
        '
        'rdgGpio3on
        '
        Me.rdgGpio3on.Location = New System.Drawing.Point(64, 12)
        Me.rdgGpio3on.Name = "rdgGpio3on"
        Me.rdgGpio3on.Size = New System.Drawing.Size(40, 24)
        Me.rdgGpio3on.TabIndex = 1
        Me.rdgGpio3on.Tag = "1"
        Me.rdgGpio3on.Text = "on"
        '
        'rdgGpio3off
        '
        Me.rdgGpio3off.Location = New System.Drawing.Point(16, 12)
        Me.rdgGpio3off.Name = "rdgGpio3off"
        Me.rdgGpio3off.Size = New System.Drawing.Size(56, 24)
        Me.rdgGpio3off.TabIndex = 0
        Me.rdgGpio3off.Tag = "0"
        Me.rdgGpio3off.Text = "off"
        '
        'miscSpecialControl
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(352, 245)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.GroupBox4)
        Me.Name = "miscSpecialControl"
        Me.Text = "miscSpecialControl"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Sub RefreshControls()

    End Sub

    Private Sub btnPanTiltHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPanTiltHome.Click
        MainForm.DefInstance.AxVideoGrabberNET1.SendCameraCommand(0, 0, False)
    End Sub

    Private Sub btnPanTiltUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPanTiltUp.Click
        MainForm.DefInstance.AxVideoGrabberNET1.SendCameraCommand(0, 1, True)
    End Sub

    Private Sub btnPanTiltDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPanTiltDown.Click
        MainForm.DefInstance.AxVideoGrabberNET1.SendCameraCommand(0, -1, True)
    End Sub

    Private Sub btnPanTiltLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPanTiltLeft.Click
        MainForm.DefInstance.AxVideoGrabberNET1.SendCameraCommand(-1, 0, True)
    End Sub

    Private Sub btnPanTiltRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPanTiltRight.Click
        MainForm.DefInstance.AxVideoGrabberNET1.SendCameraCommand(1, 0, True)
    End Sub

    Private Sub rdgGpio0_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgGpio0off.CheckedChanged, rdgGpio0on.CheckedChanged
        Dim rb As RadioButton = DirectCast(sender, RadioButton)
        If rb.Checked() Then
            If CInt(rb.Tag) = 0 Then
                MainForm.DefInstance.AxVideoGrabberNET1.PutMiscDeviceControl(vidgrab_NET.TxMiscDeviceControl.mdc_GPIO, 0, 0)
            Else
                MainForm.DefInstance.AxVideoGrabberNET1.PutMiscDeviceControl(vidgrab_NET.TxMiscDeviceControl.mdc_GPIO, 0, 1)
            End If
        End If
    End Sub

    Private Sub rdgGpio1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgGpio1off.CheckedChanged, rdgGpio1on.CheckedChanged
        Dim rb As RadioButton = DirectCast(sender, RadioButton)
        If rb.Checked() Then
            If CInt(rb.Tag) = 0 Then
                MainForm.DefInstance.AxVideoGrabberNET1.PutMiscDeviceControl(vidgrab_NET.TxMiscDeviceControl.mdc_GPIO, 1, 0)
            Else
                MainForm.DefInstance.AxVideoGrabberNET1.PutMiscDeviceControl(vidgrab_NET.TxMiscDeviceControl.mdc_GPIO, 1, 1)
            End If
        End If
    End Sub

    Private Sub rdgGpio2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgGpio2off.CheckedChanged, rdgGpio2on.CheckedChanged
        Dim rb As RadioButton = DirectCast(sender, RadioButton)
        If rb.Checked() Then
            If CInt(rb.Tag) = 0 Then
                MainForm.DefInstance.AxVideoGrabberNET1.PutMiscDeviceControl(vidgrab_NET.TxMiscDeviceControl.mdc_GPIO, 2, 0)
            Else
                MainForm.DefInstance.AxVideoGrabberNET1.PutMiscDeviceControl(vidgrab_NET.TxMiscDeviceControl.mdc_GPIO, 2, 1)
            End If
        End If
    End Sub

    Private Sub rdgGpio3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgGpio3off.CheckedChanged, rdgGpio3on.CheckedChanged
        Dim rb As RadioButton = DirectCast(sender, RadioButton)
        If rb.Checked() Then
            If CInt(rb.Tag) = 0 Then
                MainForm.DefInstance.AxVideoGrabberNET1.PutMiscDeviceControl(vidgrab_NET.TxMiscDeviceControl.mdc_GPIO, 3, 0)
            Else
                MainForm.DefInstance.AxVideoGrabberNET1.PutMiscDeviceControl(vidgrab_NET.TxMiscDeviceControl.mdc_GPIO, 3, 1)
            End If
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub miscSpecialControl_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        If Visible Then
            RefreshControls()
        End If
    End Sub
End Class
