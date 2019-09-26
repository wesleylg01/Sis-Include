Friend Class miscVideoControl
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
    Friend WithEvents chkFlipVert As System.Windows.Forms.CheckBox
    Friend WithEvents chkFlipHorz As System.Windows.Forms.CheckBox
    Friend WithEvents chkEmulateTrigger As System.Windows.Forms.CheckBox
    Friend WithEvents chkExternalTrigger As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnClose = New System.Windows.Forms.Button
        Me.chkFlipVert = New System.Windows.Forms.CheckBox
        Me.chkFlipHorz = New System.Windows.Forms.CheckBox
        Me.chkExternalTrigger = New System.Windows.Forms.CheckBox
        Me.chkEmulateTrigger = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(88, 120)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(72, 24)
        Me.btnClose.TabIndex = 30
        Me.btnClose.Text = "Close"
        '
        'chkFlipVert
        '
        Me.chkFlipVert.Location = New System.Drawing.Point(8, 16)
        Me.chkFlipVert.Name = "chkFlipVert"
        Me.chkFlipVert.Size = New System.Drawing.Size(208, 16)
        Me.chkFlipVert.TabIndex = 31
        Me.chkFlipVert.Text = "flip vertically"
        '
        'chkFlipHorz
        '
        Me.chkFlipHorz.Location = New System.Drawing.Point(8, 40)
        Me.chkFlipHorz.Name = "chkFlipHorz"
        Me.chkFlipHorz.Size = New System.Drawing.Size(208, 16)
        Me.chkFlipHorz.TabIndex = 32
        Me.chkFlipHorz.Text = "flip horizontally"
        '
        'chkExternalTrigger
        '
        Me.chkExternalTrigger.Location = New System.Drawing.Point(8, 64)
        Me.chkExternalTrigger.Name = "chkExternalTrigger"
        Me.chkExternalTrigger.Size = New System.Drawing.Size(208, 16)
        Me.chkExternalTrigger.TabIndex = 33
        Me.chkExternalTrigger.Text = "external trigger"
        '
        'chkEmulateTrigger
        '
        Me.chkEmulateTrigger.Location = New System.Drawing.Point(8, 88)
        Me.chkEmulateTrigger.Name = "chkEmulateTrigger"
        Me.chkEmulateTrigger.Size = New System.Drawing.Size(248, 16)
        Me.chkEmulateTrigger.TabIndex = 34
        Me.chkEmulateTrigger.Text = "emulate trigger (enable external trigger first)"
        '
        'miscVideoControl
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(256, 157)
        Me.Controls.Add(Me.chkEmulateTrigger)
        Me.Controls.Add(Me.chkExternalTrigger)
        Me.Controls.Add(Me.chkFlipHorz)
        Me.Controls.Add(Me.chkFlipVert)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "miscVideoControl"
        Me.Text = "miscVideoControl"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub RefreshControls()
        chkFlipVert.Enabled = MainForm.DefInstance.AxVideoGrabberNET1.IsVideoControlModeAvailable(vidgrab_NET.TxVideoControl.vc_FlipHorizontal)
        chkFlipHorz.Enabled = MainForm.DefInstance.AxVideoGrabberNET1.IsVideoControlModeAvailable(vidgrab_NET.TxVideoControl.vc_FlipVertical)
        chkExternalTrigger.Enabled = MainForm.DefInstance.AxVideoGrabberNET1.IsVideoControlModeAvailable(vidgrab_NET.TxVideoControl.vc_ExternalTriggerEnable)
        chkEmulateTrigger.Enabled = MainForm.DefInstance.AxVideoGrabberNET1.IsVideoControlModeAvailable(vidgrab_NET.TxVideoControl.vc_Trigger)
    End Sub

    Private Sub chk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFlipVert.CheckedChanged, chkFlipHorz.CheckedChanged, chkExternalTrigger.CheckedChanged, chkEmulateTrigger.CheckedChanged
        MainForm.DefInstance.AxVideoGrabberNET1.SetVideoControlMode(chkFlipHorz.Checked, chkFlipVert.Checked, chkExternalTrigger.Checked, chkEmulateTrigger.Checked)
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub miscVideoControl_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        If Visible Then
            RefreshControls()
        End If
    End Sub
End Class
