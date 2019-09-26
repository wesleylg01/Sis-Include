Option Strict Off
Option Explicit On
Friend Class Overlays
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
    Public WithEvents mmoTextOverlayString As System.Windows.Forms.TextBox
    Public WithEvents chkTextOverlayEnabled As System.Windows.Forms.CheckBox
    Public WithEvents edtTextOverlayLeft As System.Windows.Forms.TextBox
    Public WithEvents edtTextOverlayTop As System.Windows.Forms.TextBox
    Public WithEvents chkTextOverlayTransparent As System.Windows.Forms.CheckBox
    Public WithEvents Label43 As System.Windows.Forms.Label
    Public WithEvents Label44 As System.Windows.Forms.Label
    Public WithEvents Label45 As System.Windows.Forms.Label
    Public WithEvents grbTextOverlay As System.Windows.Forms.GroupBox
    Public WithEvents chkFreeHandEnabled As System.Windows.Forms.CheckBox
    Public WithEvents btnFreeHandErase As System.Windows.Forms.Button
    Public WithEvents grbFreeHand As System.Windows.Forms.GroupBox
    Public WithEvents Label48 As System.Windows.Forms.Label
    Public WithEvents Label49 As System.Windows.Forms.Label
    Public WithEvents grbBitmapOverlay As System.Windows.Forms.GroupBox
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Friend WithEvents chkTextOverlayShadow As System.Windows.Forms.CheckBox
    Friend WithEvents btnSelectFontColor As System.Windows.Forms.Button
    Friend WithEvents btnSelectFont As System.Windows.Forms.Button
    Friend WithEvents grbOverlaySelector As System.Windows.Forms.GroupBox
    Friend WithEvents rgdShadow7 As System.Windows.Forms.RadioButton
    Friend WithEvents rgdShadow6 As System.Windows.Forms.RadioButton
    Friend WithEvents rgdShadow5 As System.Windows.Forms.RadioButton
    Friend WithEvents rgdShadow4 As System.Windows.Forms.RadioButton
    Friend WithEvents rgdShadow3 As System.Windows.Forms.RadioButton
    Friend WithEvents rgdShadow2 As System.Windows.Forms.RadioButton
    Friend WithEvents rgdShadow1 As System.Windows.Forms.RadioButton
    Friend WithEvents rgdShadow0 As System.Windows.Forms.RadioButton
    Friend WithEvents rgdTextOverlayShadowDirection As System.Windows.Forms.GroupBox
    Friend WithEvents btnBackColor As System.Windows.Forms.Button
    Friend WithEvents btnImageOverlayFromFile As System.Windows.Forms.Button
    Friend WithEvents chkImageOverlayAlphaBlend As System.Windows.Forms.CheckBox
    Friend WithEvents chkImageOverlayUseTransparentColor As System.Windows.Forms.CheckBox
    Public WithEvents chkImageOverlayEnabled As System.Windows.Forms.CheckBox
    Public WithEvents chkImageOverlayTransparent As System.Windows.Forms.CheckBox
    Friend WithEvents edtImageOverlayTransparentColorValue As System.Windows.Forms.TextBox
    Friend WithEvents TextSelector4 As System.Windows.Forms.RadioButton
    Friend WithEvents TextSelector2 As System.Windows.Forms.RadioButton
    Friend WithEvents TextSelector1 As System.Windows.Forms.RadioButton
    Friend WithEvents TextSelector0 As System.Windows.Forms.RadioButton
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grpImageOverlaySelector As System.Windows.Forms.GroupBox
    Friend WithEvents ImageSelector9 As System.Windows.Forms.RadioButton
    Friend WithEvents ImageSelector8 As System.Windows.Forms.RadioButton
    Friend WithEvents ImageSelector7 As System.Windows.Forms.RadioButton
    Friend WithEvents ImageSelector6 As System.Windows.Forms.RadioButton
    Friend WithEvents ImageSelector5 As System.Windows.Forms.RadioButton
    Friend WithEvents ImageSelector4 As System.Windows.Forms.RadioButton
    Friend WithEvents ImageSelector3 As System.Windows.Forms.RadioButton
    Friend WithEvents ImageSelector2 As System.Windows.Forms.RadioButton
    Friend WithEvents ImageSelector1 As System.Windows.Forms.RadioButton
    Friend WithEvents ImageSelector0 As System.Windows.Forms.RadioButton
    Friend WithEvents TextSelector3 As System.Windows.Forms.RadioButton
    Public WithEvents edtImageOverlayWidth As System.Windows.Forms.TextBox
    Public WithEvents edtImageOverlayHeight As System.Windows.Forms.TextBox
    Public WithEvents edtImageOverlayLeft As System.Windows.Forms.TextBox
    Public WithEvents edtImageOverlayTop As System.Windows.Forms.TextBox
    Public WithEvents edtTextOverlayRight As System.Windows.Forms.TextBox
    Friend WithEvents tbrImageOverlayAlphaBlending As System.Windows.Forms.TrackBar
    Friend WithEvents btnImageOverlayPickupTransparentColorHelp As System.Windows.Forms.Button
    Friend WithEvents btnImageOverlayPickupTransparentColor As System.Windows.Forms.Button
    Friend WithEvents btnImageOverlayPickupChromaKeyColorHelp As System.Windows.Forms.Button
    Friend WithEvents btnImageOverlayPickupChromaKeyColor As System.Windows.Forms.Button
    Public WithEvents chkImageOverlayChromaKey As System.Windows.Forms.CheckBox
    Friend WithEvents edtImageOverlayChromaKeyColorValue As System.Windows.Forms.TextBox
    Friend WithEvents tbrChromaKeyLeeway As System.Windows.Forms.TrackBar
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSelectShadowColor As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnFreeHandColor As System.Windows.Forms.Button
    Friend WithEvents btnDrawGridColor As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents edtDrawGrid As System.Windows.Forms.TextBox
    Friend WithEvents btnPIP As System.Windows.Forms.Button
    Private WithEvents chkTextOverlayScrolling As System.Windows.Forms.CheckBox
    Public WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents edtTextOverlayScrollingSpeed As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents rdgTextOverlayAlign As System.Windows.Forms.GroupBox
    Public WithEvents rdgTextOverlayAlignRight As System.Windows.Forms.RadioButton
    Public WithEvents rdgTextOverlayAlignCenter As System.Windows.Forms.RadioButton
    Public WithEvents rdgTextOverlayAlignLeft As System.Windows.Forms.RadioButton
    Public WithEvents chkAdjustOverlayAspectRatio As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Overlays))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnFreeHandColor = New System.Windows.Forms.Button
        Me.btnDrawGridColor = New System.Windows.Forms.Button
        Me.edtDrawGrid = New System.Windows.Forms.TextBox
        Me.grbTextOverlay = New System.Windows.Forms.GroupBox
        Me.chkTextOverlayScrolling = New System.Windows.Forms.CheckBox
        Me.label7 = New System.Windows.Forms.Label
        Me.edtTextOverlayScrollingSpeed = New System.Windows.Forms.TextBox
        Me.edtTextOverlayLeft = New System.Windows.Forms.TextBox
        Me.btnSelectShadowColor = New System.Windows.Forms.Button
        Me.rgdTextOverlayShadowDirection = New System.Windows.Forms.GroupBox
        Me.rgdShadow7 = New System.Windows.Forms.RadioButton
        Me.rgdShadow6 = New System.Windows.Forms.RadioButton
        Me.rgdShadow5 = New System.Windows.Forms.RadioButton
        Me.rgdShadow4 = New System.Windows.Forms.RadioButton
        Me.rgdShadow3 = New System.Windows.Forms.RadioButton
        Me.rgdShadow2 = New System.Windows.Forms.RadioButton
        Me.rgdShadow1 = New System.Windows.Forms.RadioButton
        Me.rgdShadow0 = New System.Windows.Forms.RadioButton
        Me.grbOverlaySelector = New System.Windows.Forms.GroupBox
        Me.TextSelector4 = New System.Windows.Forms.RadioButton
        Me.TextSelector3 = New System.Windows.Forms.RadioButton
        Me.TextSelector2 = New System.Windows.Forms.RadioButton
        Me.TextSelector1 = New System.Windows.Forms.RadioButton
        Me.TextSelector0 = New System.Windows.Forms.RadioButton
        Me.btnBackColor = New System.Windows.Forms.Button
        Me.btnSelectFontColor = New System.Windows.Forms.Button
        Me.chkTextOverlayShadow = New System.Windows.Forms.CheckBox
        Me.btnSelectFont = New System.Windows.Forms.Button
        Me.mmoTextOverlayString = New System.Windows.Forms.TextBox
        Me.chkTextOverlayEnabled = New System.Windows.Forms.CheckBox
        Me.edtTextOverlayTop = New System.Windows.Forms.TextBox
        Me.edtTextOverlayRight = New System.Windows.Forms.TextBox
        Me.chkTextOverlayTransparent = New System.Windows.Forms.CheckBox
        Me.Label44 = New System.Windows.Forms.Label
        Me.Label45 = New System.Windows.Forms.Label
        Me.Label43 = New System.Windows.Forms.Label
        Me.chkAdjustOverlayAspectRatio = New System.Windows.Forms.CheckBox
        Me.grbFreeHand = New System.Windows.Forms.GroupBox
        Me.chkFreeHandEnabled = New System.Windows.Forms.CheckBox
        Me.btnFreeHandErase = New System.Windows.Forms.Button
        Me.grbBitmapOverlay = New System.Windows.Forms.GroupBox
        Me.tbrChromaKeyLeeway = New System.Windows.Forms.TrackBar
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnImageOverlayPickupChromaKeyColorHelp = New System.Windows.Forms.Button
        Me.btnImageOverlayPickupChromaKeyColor = New System.Windows.Forms.Button
        Me.edtImageOverlayChromaKeyColorValue = New System.Windows.Forms.TextBox
        Me.chkImageOverlayChromaKey = New System.Windows.Forms.CheckBox
        Me.tbrImageOverlayAlphaBlending = New System.Windows.Forms.TrackBar
        Me.btnImageOverlayPickupTransparentColorHelp = New System.Windows.Forms.Button
        Me.btnImageOverlayPickupTransparentColor = New System.Windows.Forms.Button
        Me.grpImageOverlaySelector = New System.Windows.Forms.GroupBox
        Me.ImageSelector9 = New System.Windows.Forms.RadioButton
        Me.ImageSelector8 = New System.Windows.Forms.RadioButton
        Me.ImageSelector7 = New System.Windows.Forms.RadioButton
        Me.ImageSelector6 = New System.Windows.Forms.RadioButton
        Me.ImageSelector5 = New System.Windows.Forms.RadioButton
        Me.ImageSelector4 = New System.Windows.Forms.RadioButton
        Me.ImageSelector3 = New System.Windows.Forms.RadioButton
        Me.ImageSelector2 = New System.Windows.Forms.RadioButton
        Me.ImageSelector1 = New System.Windows.Forms.RadioButton
        Me.ImageSelector0 = New System.Windows.Forms.RadioButton
        Me.edtImageOverlayWidth = New System.Windows.Forms.TextBox
        Me.edtImageOverlayHeight = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.edtImageOverlayTransparentColorValue = New System.Windows.Forms.TextBox
        Me.btnImageOverlayFromFile = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.chkImageOverlayAlphaBlend = New System.Windows.Forms.CheckBox
        Me.chkImageOverlayUseTransparentColor = New System.Windows.Forms.CheckBox
        Me.chkImageOverlayEnabled = New System.Windows.Forms.CheckBox
        Me.chkImageOverlayTransparent = New System.Windows.Forms.CheckBox
        Me.edtImageOverlayLeft = New System.Windows.Forms.TextBox
        Me.edtImageOverlayTop = New System.Windows.Forms.TextBox
        Me.Label48 = New System.Windows.Forms.Label
        Me.Label49 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnPIP = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.rdgTextOverlayAlign = New System.Windows.Forms.GroupBox
        Me.rdgTextOverlayAlignLeft = New System.Windows.Forms.RadioButton
        Me.rdgTextOverlayAlignCenter = New System.Windows.Forms.RadioButton
        Me.rdgTextOverlayAlignRight = New System.Windows.Forms.RadioButton
        Me.grbTextOverlay.SuspendLayout()
        Me.rgdTextOverlayShadowDirection.SuspendLayout()
        Me.grbOverlaySelector.SuspendLayout()
        Me.grbFreeHand.SuspendLayout()
        Me.grbBitmapOverlay.SuspendLayout()
        CType(Me.tbrChromaKeyLeeway, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbrImageOverlayAlphaBlending, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpImageOverlaySelector.SuspendLayout()
        Me.rdgTextOverlayAlign.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnFreeHandColor
        '
        Me.btnFreeHandColor.Location = New System.Drawing.Point(80, 17)
        Me.btnFreeHandColor.Name = "btnFreeHandColor"
        Me.btnFreeHandColor.Size = New System.Drawing.Size(16, 22)
        Me.btnFreeHandColor.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.btnFreeHandColor, "select ""free hand"" drawng color from a color dialog")
        '
        'btnDrawGridColor
        '
        Me.btnDrawGridColor.Location = New System.Drawing.Point(630, 26)
        Me.btnDrawGridColor.Name = "btnDrawGridColor"
        Me.btnDrawGridColor.Size = New System.Drawing.Size(16, 20)
        Me.btnDrawGridColor.TabIndex = 46
        Me.ToolTip1.SetToolTip(Me.btnDrawGridColor, "select grid color from a color dialog")
        '
        'edtDrawGrid
        '
        Me.edtDrawGrid.Location = New System.Drawing.Point(645, 26)
        Me.edtDrawGrid.Name = "edtDrawGrid"
        Me.edtDrawGrid.Size = New System.Drawing.Size(25, 20)
        Me.edtDrawGrid.TabIndex = 44
        Me.edtDrawGrid.Text = "0"
        Me.ToolTip1.SetToolTip(Me.edtDrawGrid, "enter a number between 2 and 100 to activate grid drawing")
        '
        'grbTextOverlay
        '
        Me.grbTextOverlay.BackColor = System.Drawing.SystemColors.Control
        Me.grbTextOverlay.Controls.Add(Me.mmoTextOverlayString)
        Me.grbTextOverlay.Controls.Add(Me.rdgTextOverlayAlign)
        Me.grbTextOverlay.Controls.Add(Me.chkTextOverlayScrolling)
        Me.grbTextOverlay.Controls.Add(Me.label7)
        Me.grbTextOverlay.Controls.Add(Me.edtTextOverlayScrollingSpeed)
        Me.grbTextOverlay.Controls.Add(Me.edtTextOverlayLeft)
        Me.grbTextOverlay.Controls.Add(Me.btnSelectShadowColor)
        Me.grbTextOverlay.Controls.Add(Me.rgdTextOverlayShadowDirection)
        Me.grbTextOverlay.Controls.Add(Me.grbOverlaySelector)
        Me.grbTextOverlay.Controls.Add(Me.btnBackColor)
        Me.grbTextOverlay.Controls.Add(Me.btnSelectFontColor)
        Me.grbTextOverlay.Controls.Add(Me.chkTextOverlayShadow)
        Me.grbTextOverlay.Controls.Add(Me.btnSelectFont)
        Me.grbTextOverlay.Controls.Add(Me.chkTextOverlayEnabled)
        Me.grbTextOverlay.Controls.Add(Me.edtTextOverlayTop)
        Me.grbTextOverlay.Controls.Add(Me.edtTextOverlayRight)
        Me.grbTextOverlay.Controls.Add(Me.chkTextOverlayTransparent)
        Me.grbTextOverlay.Controls.Add(Me.Label44)
        Me.grbTextOverlay.Controls.Add(Me.Label45)
        Me.grbTextOverlay.Controls.Add(Me.Label43)
        Me.grbTextOverlay.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbTextOverlay.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grbTextOverlay.Location = New System.Drawing.Point(4, 0)
        Me.grbTextOverlay.Name = "grbTextOverlay"
        Me.grbTextOverlay.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grbTextOverlay.Size = New System.Drawing.Size(361, 178)
        Me.grbTextOverlay.TabIndex = 16
        Me.grbTextOverlay.TabStop = False
        Me.grbTextOverlay.Text = "text overlay (up to 1000 different simultaneous text overlays)"
        '
        'chkTextOverlayScrolling
        '
        Me.chkTextOverlayScrolling.AutoSize = True
        Me.chkTextOverlayScrolling.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTextOverlayScrolling.Location = New System.Drawing.Point(190, 16)
        Me.chkTextOverlayScrolling.Name = "chkTextOverlayScrolling"
        Me.chkTextOverlayScrolling.Size = New System.Drawing.Size(74, 18)
        Me.chkTextOverlayScrolling.TabIndex = 42
        Me.chkTextOverlayScrolling.Text = "scrolling"
        Me.chkTextOverlayScrolling.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkTextOverlayScrolling.UseVisualStyleBackColor = True
        '
        'label7
        '
        Me.label7.BackColor = System.Drawing.SystemColors.Control
        Me.label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.label7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.label7.Location = New System.Drawing.Point(228, 16)
        Me.label7.Name = "label7"
        Me.label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.label7.Size = New System.Drawing.Size(98, 18)
        Me.label7.TabIndex = 41
        Me.label7.Text = "-> speed(+-)"
        Me.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'edtTextOverlayScrollingSpeed
        '
        Me.edtTextOverlayScrollingSpeed.Location = New System.Drawing.Point(326, 15)
        Me.edtTextOverlayScrollingSpeed.Name = "edtTextOverlayScrollingSpeed"
        Me.edtTextOverlayScrollingSpeed.Size = New System.Drawing.Size(31, 20)
        Me.edtTextOverlayScrollingSpeed.TabIndex = 40
        '
        'edtTextOverlayLeft
        '
        Me.edtTextOverlayLeft.AcceptsReturn = True
        Me.edtTextOverlayLeft.BackColor = System.Drawing.SystemColors.Window
        Me.edtTextOverlayLeft.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtTextOverlayLeft.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtTextOverlayLeft.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtTextOverlayLeft.Location = New System.Drawing.Point(193, 53)
        Me.edtTextOverlayLeft.MaxLength = 0
        Me.edtTextOverlayLeft.Name = "edtTextOverlayLeft"
        Me.edtTextOverlayLeft.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtTextOverlayLeft.Size = New System.Drawing.Size(33, 20)
        Me.edtTextOverlayLeft.TabIndex = 20
        Me.edtTextOverlayLeft.Text = "5"
        '
        'btnSelectShadowColor
        '
        Me.btnSelectShadowColor.Location = New System.Drawing.Point(269, 82)
        Me.btnSelectShadowColor.Name = "btnSelectShadowColor"
        Me.btnSelectShadowColor.Size = New System.Drawing.Size(86, 20)
        Me.btnSelectShadowColor.TabIndex = 36
        Me.btnSelectShadowColor.Text = "shadow color"
        '
        'rgdTextOverlayShadowDirection
        '
        Me.rgdTextOverlayShadowDirection.Controls.Add(Me.rgdShadow7)
        Me.rgdTextOverlayShadowDirection.Controls.Add(Me.rgdShadow6)
        Me.rgdTextOverlayShadowDirection.Controls.Add(Me.rgdShadow5)
        Me.rgdTextOverlayShadowDirection.Controls.Add(Me.rgdShadow4)
        Me.rgdTextOverlayShadowDirection.Controls.Add(Me.rgdShadow3)
        Me.rgdTextOverlayShadowDirection.Controls.Add(Me.rgdShadow2)
        Me.rgdTextOverlayShadowDirection.Controls.Add(Me.rgdShadow1)
        Me.rgdTextOverlayShadowDirection.Controls.Add(Me.rgdShadow0)
        Me.rgdTextOverlayShadowDirection.Location = New System.Drawing.Point(249, 101)
        Me.rgdTextOverlayShadowDirection.Name = "rgdTextOverlayShadowDirection"
        Me.rgdTextOverlayShadowDirection.Size = New System.Drawing.Size(106, 73)
        Me.rgdTextOverlayShadowDirection.TabIndex = 35
        Me.rgdTextOverlayShadowDirection.TabStop = False
        Me.rgdTextOverlayShadowDirection.Text = "shadow direction"
        '
        'rgdShadow7
        '
        Me.rgdShadow7.Location = New System.Drawing.Point(57, 55)
        Me.rgdShadow7.Name = "rgdShadow7"
        Me.rgdShadow7.Size = New System.Drawing.Size(45, 16)
        Me.rgdShadow7.TabIndex = 17
        Me.rgdShadow7.Tag = "7"
        Me.rgdShadow7.Text = "n-w"
        '
        'rgdShadow6
        '
        Me.rgdShadow6.Location = New System.Drawing.Point(57, 41)
        Me.rgdShadow6.Name = "rgdShadow6"
        Me.rgdShadow6.Size = New System.Drawing.Size(45, 16)
        Me.rgdShadow6.TabIndex = 16
        Me.rgdShadow6.Tag = "6"
        Me.rgdShadow6.Text = "w"
        '
        'rgdShadow5
        '
        Me.rgdShadow5.Location = New System.Drawing.Point(57, 27)
        Me.rgdShadow5.Name = "rgdShadow5"
        Me.rgdShadow5.Size = New System.Drawing.Size(45, 16)
        Me.rgdShadow5.TabIndex = 15
        Me.rgdShadow5.Tag = "5"
        Me.rgdShadow5.Text = "s-w"
        '
        'rgdShadow4
        '
        Me.rgdShadow4.Location = New System.Drawing.Point(57, 13)
        Me.rgdShadow4.Name = "rgdShadow4"
        Me.rgdShadow4.Size = New System.Drawing.Size(45, 16)
        Me.rgdShadow4.TabIndex = 14
        Me.rgdShadow4.Tag = "4"
        Me.rgdShadow4.Text = "s"
        '
        'rgdShadow3
        '
        Me.rgdShadow3.Location = New System.Drawing.Point(8, 55)
        Me.rgdShadow3.Name = "rgdShadow3"
        Me.rgdShadow3.Size = New System.Drawing.Size(48, 16)
        Me.rgdShadow3.TabIndex = 13
        Me.rgdShadow3.Tag = "3"
        Me.rgdShadow3.Text = "s-e"
        '
        'rgdShadow2
        '
        Me.rgdShadow2.Location = New System.Drawing.Point(8, 41)
        Me.rgdShadow2.Name = "rgdShadow2"
        Me.rgdShadow2.Size = New System.Drawing.Size(48, 16)
        Me.rgdShadow2.TabIndex = 12
        Me.rgdShadow2.Tag = "2"
        Me.rgdShadow2.Text = "e"
        '
        'rgdShadow1
        '
        Me.rgdShadow1.Location = New System.Drawing.Point(8, 27)
        Me.rgdShadow1.Name = "rgdShadow1"
        Me.rgdShadow1.Size = New System.Drawing.Size(48, 16)
        Me.rgdShadow1.TabIndex = 11
        Me.rgdShadow1.Tag = "1"
        Me.rgdShadow1.Text = "n-e"
        '
        'rgdShadow0
        '
        Me.rgdShadow0.Checked = True
        Me.rgdShadow0.Location = New System.Drawing.Point(8, 13)
        Me.rgdShadow0.Name = "rgdShadow0"
        Me.rgdShadow0.Size = New System.Drawing.Size(48, 16)
        Me.rgdShadow0.TabIndex = 10
        Me.rgdShadow0.TabStop = True
        Me.rgdShadow0.Tag = "0"
        Me.rgdShadow0.Text = "n"
        '
        'grbOverlaySelector
        '
        Me.grbOverlaySelector.Controls.Add(Me.TextSelector4)
        Me.grbOverlaySelector.Controls.Add(Me.TextSelector3)
        Me.grbOverlaySelector.Controls.Add(Me.TextSelector2)
        Me.grbOverlaySelector.Controls.Add(Me.TextSelector1)
        Me.grbOverlaySelector.Controls.Add(Me.TextSelector0)
        Me.grbOverlaySelector.Location = New System.Drawing.Point(6, 39)
        Me.grbOverlaySelector.Name = "grbOverlaySelector"
        Me.grbOverlaySelector.Size = New System.Drawing.Size(181, 33)
        Me.grbOverlaySelector.TabIndex = 34
        Me.grbOverlaySelector.TabStop = False
        Me.grbOverlaySelector.Text = "text selector [0 - n]  0 = default"
        '
        'TextSelector4
        '
        Me.TextSelector4.Location = New System.Drawing.Point(142, 14)
        Me.TextSelector4.Name = "TextSelector4"
        Me.TextSelector4.Size = New System.Drawing.Size(24, 16)
        Me.TextSelector4.TabIndex = 4
        Me.TextSelector4.Tag = "4"
        Me.TextSelector4.Text = "4"
        '
        'TextSelector3
        '
        Me.TextSelector3.Location = New System.Drawing.Point(110, 14)
        Me.TextSelector3.Name = "TextSelector3"
        Me.TextSelector3.Size = New System.Drawing.Size(24, 16)
        Me.TextSelector3.TabIndex = 3
        Me.TextSelector3.Tag = "3"
        Me.TextSelector3.Text = "3"
        '
        'TextSelector2
        '
        Me.TextSelector2.Location = New System.Drawing.Point(78, 14)
        Me.TextSelector2.Name = "TextSelector2"
        Me.TextSelector2.Size = New System.Drawing.Size(24, 16)
        Me.TextSelector2.TabIndex = 2
        Me.TextSelector2.Tag = "2"
        Me.TextSelector2.Text = "2"
        '
        'TextSelector1
        '
        Me.TextSelector1.Location = New System.Drawing.Point(46, 14)
        Me.TextSelector1.Name = "TextSelector1"
        Me.TextSelector1.Size = New System.Drawing.Size(24, 16)
        Me.TextSelector1.TabIndex = 1
        Me.TextSelector1.Tag = "1"
        Me.TextSelector1.Text = "1"
        '
        'TextSelector0
        '
        Me.TextSelector0.Location = New System.Drawing.Point(14, 14)
        Me.TextSelector0.Name = "TextSelector0"
        Me.TextSelector0.Size = New System.Drawing.Size(24, 16)
        Me.TextSelector0.TabIndex = 0
        Me.TextSelector0.Tag = "0"
        Me.TextSelector0.Text = "0"
        '
        'btnBackColor
        '
        Me.btnBackColor.Location = New System.Drawing.Point(193, 152)
        Me.btnBackColor.Name = "btnBackColor"
        Me.btnBackColor.Size = New System.Drawing.Size(51, 21)
        Me.btnBackColor.TabIndex = 33
        Me.btnBackColor.Text = "bkgnd"
        '
        'btnSelectFontColor
        '
        Me.btnSelectFontColor.Location = New System.Drawing.Point(193, 129)
        Me.btnSelectFontColor.Name = "btnSelectFontColor"
        Me.btnSelectFontColor.Size = New System.Drawing.Size(51, 21)
        Me.btnSelectFontColor.TabIndex = 32
        Me.btnSelectFontColor.Text = "color"
        '
        'chkTextOverlayShadow
        '
        Me.chkTextOverlayShadow.Location = New System.Drawing.Point(200, 85)
        Me.chkTextOverlayShadow.Name = "chkTextOverlayShadow"
        Me.chkTextOverlayShadow.Size = New System.Drawing.Size(67, 15)
        Me.chkTextOverlayShadow.TabIndex = 31
        Me.chkTextOverlayShadow.Text = "shadow"
        '
        'btnSelectFont
        '
        Me.btnSelectFont.Location = New System.Drawing.Point(193, 106)
        Me.btnSelectFont.Name = "btnSelectFont"
        Me.btnSelectFont.Size = New System.Drawing.Size(51, 21)
        Me.btnSelectFont.TabIndex = 30
        Me.btnSelectFont.Text = "font dlg"
        '
        'mmoTextOverlayString
        '
        Me.mmoTextOverlayString.AcceptsReturn = True
        Me.mmoTextOverlayString.BackColor = System.Drawing.SystemColors.Window
        Me.mmoTextOverlayString.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.mmoTextOverlayString.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mmoTextOverlayString.ForeColor = System.Drawing.SystemColors.WindowText
        Me.mmoTextOverlayString.Location = New System.Drawing.Point(6, 78)
        Me.mmoTextOverlayString.MaxLength = 0
        Me.mmoTextOverlayString.Multiline = True
        Me.mmoTextOverlayString.Name = "mmoTextOverlayString"
        Me.mmoTextOverlayString.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.mmoTextOverlayString.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.mmoTextOverlayString.Size = New System.Drawing.Size(181, 66)
        Me.mmoTextOverlayString.TabIndex = 26
        '
        'chkTextOverlayEnabled
        '
        Me.chkTextOverlayEnabled.BackColor = System.Drawing.SystemColors.Control
        Me.chkTextOverlayEnabled.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkTextOverlayEnabled.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTextOverlayEnabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkTextOverlayEnabled.Location = New System.Drawing.Point(8, 17)
        Me.chkTextOverlayEnabled.Name = "chkTextOverlayEnabled"
        Me.chkTextOverlayEnabled.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkTextOverlayEnabled.Size = New System.Drawing.Size(72, 17)
        Me.chkTextOverlayEnabled.TabIndex = 25
        Me.chkTextOverlayEnabled.Text = "enabled"
        Me.chkTextOverlayEnabled.UseVisualStyleBackColor = False
        '
        'edtTextOverlayTop
        '
        Me.edtTextOverlayTop.AcceptsReturn = True
        Me.edtTextOverlayTop.BackColor = System.Drawing.SystemColors.Window
        Me.edtTextOverlayTop.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtTextOverlayTop.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtTextOverlayTop.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtTextOverlayTop.Location = New System.Drawing.Point(272, 53)
        Me.edtTextOverlayTop.MaxLength = 0
        Me.edtTextOverlayTop.Name = "edtTextOverlayTop"
        Me.edtTextOverlayTop.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtTextOverlayTop.Size = New System.Drawing.Size(33, 20)
        Me.edtTextOverlayTop.TabIndex = 19
        Me.edtTextOverlayTop.Text = "5"
        '
        'edtTextOverlayRight
        '
        Me.edtTextOverlayRight.AcceptsReturn = True
        Me.edtTextOverlayRight.BackColor = System.Drawing.SystemColors.Window
        Me.edtTextOverlayRight.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtTextOverlayRight.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtTextOverlayRight.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtTextOverlayRight.Location = New System.Drawing.Point(231, 53)
        Me.edtTextOverlayRight.MaxLength = 0
        Me.edtTextOverlayRight.Name = "edtTextOverlayRight"
        Me.edtTextOverlayRight.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtTextOverlayRight.Size = New System.Drawing.Size(33, 20)
        Me.edtTextOverlayRight.TabIndex = 18
        Me.edtTextOverlayRight.Text = "-1"
        '
        'chkTextOverlayTransparent
        '
        Me.chkTextOverlayTransparent.BackColor = System.Drawing.SystemColors.Control
        Me.chkTextOverlayTransparent.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkTextOverlayTransparent.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTextOverlayTransparent.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkTextOverlayTransparent.Location = New System.Drawing.Point(90, 17)
        Me.chkTextOverlayTransparent.Name = "chkTextOverlayTransparent"
        Me.chkTextOverlayTransparent.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkTextOverlayTransparent.Size = New System.Drawing.Size(82, 16)
        Me.chkTextOverlayTransparent.TabIndex = 17
        Me.chkTextOverlayTransparent.Text = "transparent"
        Me.chkTextOverlayTransparent.UseVisualStyleBackColor = False
        '
        'Label44
        '
        Me.Label44.BackColor = System.Drawing.SystemColors.Control
        Me.Label44.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label44.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label44.Location = New System.Drawing.Point(272, 40)
        Me.Label44.Name = "Label44"
        Me.Label44.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label44.Size = New System.Drawing.Size(33, 14)
        Me.Label44.TabIndex = 28
        Me.Label44.Text = "top"
        '
        'Label45
        '
        Me.Label45.BackColor = System.Drawing.SystemColors.Control
        Me.Label45.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label45.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label45.Location = New System.Drawing.Point(231, 40)
        Me.Label45.Name = "Label45"
        Me.Label45.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label45.Size = New System.Drawing.Size(36, 17)
        Me.Label45.TabIndex = 27
        Me.Label45.Text = "right"
        '
        'Label43
        '
        Me.Label43.BackColor = System.Drawing.SystemColors.Control
        Me.Label43.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label43.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label43.Location = New System.Drawing.Point(193, 40)
        Me.Label43.Name = "Label43"
        Me.Label43.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label43.Size = New System.Drawing.Size(33, 17)
        Me.Label43.TabIndex = 29
        Me.Label43.Text = "left"
        '
        'chkAdjustOverlayAspectRatio
        '
        Me.chkAdjustOverlayAspectRatio.AutoSize = True
        Me.chkAdjustOverlayAspectRatio.BackColor = System.Drawing.SystemColors.Control
        Me.chkAdjustOverlayAspectRatio.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkAdjustOverlayAspectRatio.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAdjustOverlayAspectRatio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkAdjustOverlayAspectRatio.Location = New System.Drawing.Point(603, 6)
        Me.chkAdjustOverlayAspectRatio.Name = "chkAdjustOverlayAspectRatio"
        Me.chkAdjustOverlayAspectRatio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkAdjustOverlayAspectRatio.Size = New System.Drawing.Size(171, 18)
        Me.chkAdjustOverlayAspectRatio.TabIndex = 43
        Me.chkAdjustOverlayAspectRatio.Text = "adjust overlay aspect ratio"
        Me.chkAdjustOverlayAspectRatio.UseVisualStyleBackColor = False
        '
        'grbFreeHand
        '
        Me.grbFreeHand.BackColor = System.Drawing.SystemColors.Control
        Me.grbFreeHand.Controls.Add(Me.chkFreeHandEnabled)
        Me.grbFreeHand.Controls.Add(Me.btnFreeHandErase)
        Me.grbFreeHand.Controls.Add(Me.btnFreeHandColor)
        Me.grbFreeHand.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbFreeHand.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grbFreeHand.Location = New System.Drawing.Point(371, 0)
        Me.grbFreeHand.Name = "grbFreeHand"
        Me.grbFreeHand.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grbFreeHand.Size = New System.Drawing.Size(209, 49)
        Me.grbFreeHand.TabIndex = 13
        Me.grbFreeHand.TabStop = False
        Me.grbFreeHand.Text = """free hand"" mouse overlay USING DC"
        '
        'chkFreeHandEnabled
        '
        Me.chkFreeHandEnabled.BackColor = System.Drawing.SystemColors.Control
        Me.chkFreeHandEnabled.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkFreeHandEnabled.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFreeHandEnabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkFreeHandEnabled.Location = New System.Drawing.Point(10, 20)
        Me.chkFreeHandEnabled.Name = "chkFreeHandEnabled"
        Me.chkFreeHandEnabled.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkFreeHandEnabled.Size = New System.Drawing.Size(65, 17)
        Me.chkFreeHandEnabled.TabIndex = 15
        Me.chkFreeHandEnabled.Text = "enabled"
        Me.chkFreeHandEnabled.UseVisualStyleBackColor = False
        '
        'btnFreeHandErase
        '
        Me.btnFreeHandErase.BackColor = System.Drawing.SystemColors.Control
        Me.btnFreeHandErase.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnFreeHandErase.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFreeHandErase.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnFreeHandErase.Location = New System.Drawing.Point(96, 17)
        Me.btnFreeHandErase.Name = "btnFreeHandErase"
        Me.btnFreeHandErase.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnFreeHandErase.Size = New System.Drawing.Size(104, 22)
        Me.btnFreeHandErase.TabIndex = 14
        Me.btnFreeHandErase.Text = "erase drawing"
        Me.btnFreeHandErase.UseVisualStyleBackColor = False
        '
        'grbBitmapOverlay
        '
        Me.grbBitmapOverlay.BackColor = System.Drawing.SystemColors.Control
        Me.grbBitmapOverlay.Controls.Add(Me.tbrChromaKeyLeeway)
        Me.grbBitmapOverlay.Controls.Add(Me.Label4)
        Me.grbBitmapOverlay.Controls.Add(Me.Label3)
        Me.grbBitmapOverlay.Controls.Add(Me.btnImageOverlayPickupChromaKeyColorHelp)
        Me.grbBitmapOverlay.Controls.Add(Me.btnImageOverlayPickupChromaKeyColor)
        Me.grbBitmapOverlay.Controls.Add(Me.edtImageOverlayChromaKeyColorValue)
        Me.grbBitmapOverlay.Controls.Add(Me.chkImageOverlayChromaKey)
        Me.grbBitmapOverlay.Controls.Add(Me.tbrImageOverlayAlphaBlending)
        Me.grbBitmapOverlay.Controls.Add(Me.btnImageOverlayPickupTransparentColorHelp)
        Me.grbBitmapOverlay.Controls.Add(Me.btnImageOverlayPickupTransparentColor)
        Me.grbBitmapOverlay.Controls.Add(Me.grpImageOverlaySelector)
        Me.grbBitmapOverlay.Controls.Add(Me.edtImageOverlayWidth)
        Me.grbBitmapOverlay.Controls.Add(Me.edtImageOverlayHeight)
        Me.grbBitmapOverlay.Controls.Add(Me.Label1)
        Me.grbBitmapOverlay.Controls.Add(Me.Label2)
        Me.grbBitmapOverlay.Controls.Add(Me.edtImageOverlayTransparentColorValue)
        Me.grbBitmapOverlay.Controls.Add(Me.btnImageOverlayFromFile)
        Me.grbBitmapOverlay.Controls.Add(Me.chkImageOverlayAlphaBlend)
        Me.grbBitmapOverlay.Controls.Add(Me.chkImageOverlayUseTransparentColor)
        Me.grbBitmapOverlay.Controls.Add(Me.chkImageOverlayEnabled)
        Me.grbBitmapOverlay.Controls.Add(Me.chkImageOverlayTransparent)
        Me.grbBitmapOverlay.Controls.Add(Me.edtImageOverlayLeft)
        Me.grbBitmapOverlay.Controls.Add(Me.edtImageOverlayTop)
        Me.grbBitmapOverlay.Controls.Add(Me.Label48)
        Me.grbBitmapOverlay.Controls.Add(Me.Label49)
        Me.grbBitmapOverlay.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbBitmapOverlay.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grbBitmapOverlay.Location = New System.Drawing.Point(371, 47)
        Me.grbBitmapOverlay.Name = "grbBitmapOverlay"
        Me.grbBitmapOverlay.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grbBitmapOverlay.Size = New System.Drawing.Size(539, 131)
        Me.grbBitmapOverlay.TabIndex = 0
        Me.grbBitmapOverlay.TabStop = False
        Me.grbBitmapOverlay.Text = "image overlay"
        '
        'tbrChromaKeyLeeway
        '
        Me.tbrChromaKeyLeeway.AutoSize = False
        Me.tbrChromaKeyLeeway.Location = New System.Drawing.Point(433, 82)
        Me.tbrChromaKeyLeeway.Maximum = 100
        Me.tbrChromaKeyLeeway.Name = "tbrChromaKeyLeeway"
        Me.tbrChromaKeyLeeway.Size = New System.Drawing.Size(88, 16)
        Me.tbrChromaKeyLeeway.TabIndex = 44
        Me.tbrChromaKeyLeeway.TickFrequency = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(333, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 14)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "chroma key RGB color:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(333, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 16)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "chroma key leeway (0..100%)"
        '
        'btnImageOverlayPickupChromaKeyColorHelp
        '
        Me.btnImageOverlayPickupChromaKeyColorHelp.Location = New System.Drawing.Point(492, 102)
        Me.btnImageOverlayPickupChromaKeyColorHelp.Name = "btnImageOverlayPickupChromaKeyColorHelp"
        Me.btnImageOverlayPickupChromaKeyColorHelp.Size = New System.Drawing.Size(24, 21)
        Me.btnImageOverlayPickupChromaKeyColorHelp.TabIndex = 43
        Me.btnImageOverlayPickupChromaKeyColorHelp.Text = "?"
        '
        'btnImageOverlayPickupChromaKeyColor
        '
        Me.btnImageOverlayPickupChromaKeyColor.Location = New System.Drawing.Point(336, 102)
        Me.btnImageOverlayPickupChromaKeyColor.Name = "btnImageOverlayPickupChromaKeyColor"
        Me.btnImageOverlayPickupChromaKeyColor.Size = New System.Drawing.Size(150, 21)
        Me.btnImageOverlayPickupChromaKeyColor.TabIndex = 42
        Me.btnImageOverlayPickupChromaKeyColor.Text = "pick up chroma key color"
        '
        'edtImageOverlayChromaKeyColorValue
        '
        Me.edtImageOverlayChromaKeyColorValue.Location = New System.Drawing.Point(460, 61)
        Me.edtImageOverlayChromaKeyColorValue.Name = "edtImageOverlayChromaKeyColorValue"
        Me.edtImageOverlayChromaKeyColorValue.Size = New System.Drawing.Size(56, 20)
        Me.edtImageOverlayChromaKeyColorValue.TabIndex = 41
        Me.edtImageOverlayChromaKeyColorValue.Text = "0"
        '
        'chkImageOverlayChromaKey
        '
        Me.chkImageOverlayChromaKey.BackColor = System.Drawing.SystemColors.Control
        Me.chkImageOverlayChromaKey.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkImageOverlayChromaKey.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkImageOverlayChromaKey.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkImageOverlayChromaKey.Location = New System.Drawing.Point(336, 45)
        Me.chkImageOverlayChromaKey.Name = "chkImageOverlayChromaKey"
        Me.chkImageOverlayChromaKey.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkImageOverlayChromaKey.Size = New System.Drawing.Size(117, 20)
        Me.chkImageOverlayChromaKey.TabIndex = 39
        Me.chkImageOverlayChromaKey.Text = "chroma key"
        Me.chkImageOverlayChromaKey.UseVisualStyleBackColor = False
        '
        'tbrImageOverlayAlphaBlending
        '
        Me.tbrImageOverlayAlphaBlending.AutoSize = False
        Me.tbrImageOverlayAlphaBlending.Location = New System.Drawing.Point(211, 82)
        Me.tbrImageOverlayAlphaBlending.Maximum = 255
        Me.tbrImageOverlayAlphaBlending.Name = "tbrImageOverlayAlphaBlending"
        Me.tbrImageOverlayAlphaBlending.Size = New System.Drawing.Size(96, 16)
        Me.tbrImageOverlayAlphaBlending.TabIndex = 38
        Me.tbrImageOverlayAlphaBlending.TickFrequency = 26
        '
        'btnImageOverlayPickupTransparentColorHelp
        '
        Me.btnImageOverlayPickupTransparentColorHelp.Location = New System.Drawing.Point(276, 102)
        Me.btnImageOverlayPickupTransparentColorHelp.Name = "btnImageOverlayPickupTransparentColorHelp"
        Me.btnImageOverlayPickupTransparentColorHelp.Size = New System.Drawing.Size(27, 21)
        Me.btnImageOverlayPickupTransparentColorHelp.TabIndex = 37
        Me.btnImageOverlayPickupTransparentColorHelp.Text = "?"
        '
        'btnImageOverlayPickupTransparentColor
        '
        Me.btnImageOverlayPickupTransparentColor.Location = New System.Drawing.Point(116, 102)
        Me.btnImageOverlayPickupTransparentColor.Name = "btnImageOverlayPickupTransparentColor"
        Me.btnImageOverlayPickupTransparentColor.Size = New System.Drawing.Size(154, 21)
        Me.btnImageOverlayPickupTransparentColor.TabIndex = 36
        Me.btnImageOverlayPickupTransparentColor.Text = "pick up transparent color"
        '
        'grpImageOverlaySelector
        '
        Me.grpImageOverlaySelector.Controls.Add(Me.ImageSelector9)
        Me.grpImageOverlaySelector.Controls.Add(Me.ImageSelector8)
        Me.grpImageOverlaySelector.Controls.Add(Me.ImageSelector7)
        Me.grpImageOverlaySelector.Controls.Add(Me.ImageSelector6)
        Me.grpImageOverlaySelector.Controls.Add(Me.ImageSelector5)
        Me.grpImageOverlaySelector.Controls.Add(Me.ImageSelector4)
        Me.grpImageOverlaySelector.Controls.Add(Me.ImageSelector3)
        Me.grpImageOverlaySelector.Controls.Add(Me.ImageSelector2)
        Me.grpImageOverlaySelector.Controls.Add(Me.ImageSelector1)
        Me.grpImageOverlaySelector.Controls.Add(Me.ImageSelector0)
        Me.grpImageOverlaySelector.Location = New System.Drawing.Point(195, 11)
        Me.grpImageOverlaySelector.Name = "grpImageOverlaySelector"
        Me.grpImageOverlaySelector.Size = New System.Drawing.Size(337, 34)
        Me.grpImageOverlaySelector.TabIndex = 35
        Me.grpImageOverlaySelector.TabStop = False
        Me.grpImageOverlaySelector.Text = "image selector [0..9] 0 = default"
        '
        'ImageSelector9
        '
        Me.ImageSelector9.Location = New System.Drawing.Point(302, 15)
        Me.ImageSelector9.Name = "ImageSelector9"
        Me.ImageSelector9.Size = New System.Drawing.Size(24, 16)
        Me.ImageSelector9.TabIndex = 9
        Me.ImageSelector9.Tag = "9"
        Me.ImageSelector9.Text = "9"
        '
        'ImageSelector8
        '
        Me.ImageSelector8.Location = New System.Drawing.Point(270, 15)
        Me.ImageSelector8.Name = "ImageSelector8"
        Me.ImageSelector8.Size = New System.Drawing.Size(24, 16)
        Me.ImageSelector8.TabIndex = 8
        Me.ImageSelector8.Tag = "8"
        Me.ImageSelector8.Text = "8"
        '
        'ImageSelector7
        '
        Me.ImageSelector7.Location = New System.Drawing.Point(238, 15)
        Me.ImageSelector7.Name = "ImageSelector7"
        Me.ImageSelector7.Size = New System.Drawing.Size(24, 16)
        Me.ImageSelector7.TabIndex = 7
        Me.ImageSelector7.Tag = "7"
        Me.ImageSelector7.Text = "7"
        '
        'ImageSelector6
        '
        Me.ImageSelector6.Location = New System.Drawing.Point(206, 15)
        Me.ImageSelector6.Name = "ImageSelector6"
        Me.ImageSelector6.Size = New System.Drawing.Size(24, 16)
        Me.ImageSelector6.TabIndex = 6
        Me.ImageSelector6.Tag = "6"
        Me.ImageSelector6.Text = "6"
        '
        'ImageSelector5
        '
        Me.ImageSelector5.Location = New System.Drawing.Point(174, 15)
        Me.ImageSelector5.Name = "ImageSelector5"
        Me.ImageSelector5.Size = New System.Drawing.Size(24, 16)
        Me.ImageSelector5.TabIndex = 5
        Me.ImageSelector5.Tag = "5"
        Me.ImageSelector5.Text = "5"
        '
        'ImageSelector4
        '
        Me.ImageSelector4.Location = New System.Drawing.Point(144, 15)
        Me.ImageSelector4.Name = "ImageSelector4"
        Me.ImageSelector4.Size = New System.Drawing.Size(24, 16)
        Me.ImageSelector4.TabIndex = 4
        Me.ImageSelector4.Tag = "4"
        Me.ImageSelector4.Text = "4"
        '
        'ImageSelector3
        '
        Me.ImageSelector3.Location = New System.Drawing.Point(112, 15)
        Me.ImageSelector3.Name = "ImageSelector3"
        Me.ImageSelector3.Size = New System.Drawing.Size(24, 16)
        Me.ImageSelector3.TabIndex = 3
        Me.ImageSelector3.Tag = "3"
        Me.ImageSelector3.Text = "3"
        '
        'ImageSelector2
        '
        Me.ImageSelector2.Location = New System.Drawing.Point(80, 15)
        Me.ImageSelector2.Name = "ImageSelector2"
        Me.ImageSelector2.Size = New System.Drawing.Size(24, 16)
        Me.ImageSelector2.TabIndex = 2
        Me.ImageSelector2.Tag = "2"
        Me.ImageSelector2.Text = "2"
        '
        'ImageSelector1
        '
        Me.ImageSelector1.Location = New System.Drawing.Point(48, 15)
        Me.ImageSelector1.Name = "ImageSelector1"
        Me.ImageSelector1.Size = New System.Drawing.Size(24, 16)
        Me.ImageSelector1.TabIndex = 1
        Me.ImageSelector1.Tag = "1"
        Me.ImageSelector1.Text = "1"
        '
        'ImageSelector0
        '
        Me.ImageSelector0.Location = New System.Drawing.Point(16, 15)
        Me.ImageSelector0.Name = "ImageSelector0"
        Me.ImageSelector0.Size = New System.Drawing.Size(24, 16)
        Me.ImageSelector0.TabIndex = 0
        Me.ImageSelector0.Tag = "0"
        Me.ImageSelector0.Text = "0"
        '
        'edtImageOverlayWidth
        '
        Me.edtImageOverlayWidth.AcceptsReturn = True
        Me.edtImageOverlayWidth.BackColor = System.Drawing.SystemColors.Window
        Me.edtImageOverlayWidth.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtImageOverlayWidth.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtImageOverlayWidth.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtImageOverlayWidth.Location = New System.Drawing.Point(19, 95)
        Me.edtImageOverlayWidth.MaxLength = 0
        Me.edtImageOverlayWidth.Name = "edtImageOverlayWidth"
        Me.edtImageOverlayWidth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtImageOverlayWidth.Size = New System.Drawing.Size(33, 20)
        Me.edtImageOverlayWidth.TabIndex = 19
        Me.edtImageOverlayWidth.Text = "-1"
        '
        'edtImageOverlayHeight
        '
        Me.edtImageOverlayHeight.AcceptsReturn = True
        Me.edtImageOverlayHeight.BackColor = System.Drawing.SystemColors.Window
        Me.edtImageOverlayHeight.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtImageOverlayHeight.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtImageOverlayHeight.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtImageOverlayHeight.Location = New System.Drawing.Point(61, 95)
        Me.edtImageOverlayHeight.MaxLength = 0
        Me.edtImageOverlayHeight.Name = "edtImageOverlayHeight"
        Me.edtImageOverlayHeight.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtImageOverlayHeight.Size = New System.Drawing.Size(33, 20)
        Me.edtImageOverlayHeight.TabIndex = 18
        Me.edtImageOverlayHeight.Text = "-1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(18, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(34, 14)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "width"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(58, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(36, 14)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "height"
        '
        'edtImageOverlayTransparentColorValue
        '
        Me.edtImageOverlayTransparentColorValue.Location = New System.Drawing.Point(247, 61)
        Me.edtImageOverlayTransparentColorValue.Name = "edtImageOverlayTransparentColorValue"
        Me.edtImageOverlayTransparentColorValue.Size = New System.Drawing.Size(56, 20)
        Me.edtImageOverlayTransparentColorValue.TabIndex = 17
        Me.edtImageOverlayTransparentColorValue.Text = "0"
        '
        'btnImageOverlayFromFile
        '
        Me.btnImageOverlayFromFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImageOverlayFromFile.ImageIndex = 0
        Me.btnImageOverlayFromFile.ImageList = Me.ImageList1
        Me.btnImageOverlayFromFile.Location = New System.Drawing.Point(77, 15)
        Me.btnImageOverlayFromFile.Name = "btnImageOverlayFromFile"
        Me.btnImageOverlayFromFile.Size = New System.Drawing.Size(110, 24)
        Me.btnImageOverlayFromFile.TabIndex = 16
        Me.btnImageOverlayFromFile.Text = " load image..."
        Me.btnImageOverlayFromFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Fuchsia
        Me.ImageList1.Images.SetKeyName(0, "")
        '
        'chkImageOverlayAlphaBlend
        '
        Me.chkImageOverlayAlphaBlend.Location = New System.Drawing.Point(116, 80)
        Me.chkImageOverlayAlphaBlend.Name = "chkImageOverlayAlphaBlend"
        Me.chkImageOverlayAlphaBlend.Size = New System.Drawing.Size(106, 16)
        Me.chkImageOverlayAlphaBlend.TabIndex = 14
        Me.chkImageOverlayAlphaBlend.Text = "alpha blending (0..255):"
        '
        'chkImageOverlayUseTransparentColor
        '
        Me.chkImageOverlayUseTransparentColor.Location = New System.Drawing.Point(116, 62)
        Me.chkImageOverlayUseTransparentColor.Name = "chkImageOverlayUseTransparentColor"
        Me.chkImageOverlayUseTransparentColor.Size = New System.Drawing.Size(139, 18)
        Me.chkImageOverlayUseTransparentColor.TabIndex = 12
        Me.chkImageOverlayUseTransparentColor.Text = "use transparent color:"
        '
        'chkImageOverlayEnabled
        '
        Me.chkImageOverlayEnabled.BackColor = System.Drawing.SystemColors.Control
        Me.chkImageOverlayEnabled.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkImageOverlayEnabled.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkImageOverlayEnabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkImageOverlayEnabled.Location = New System.Drawing.Point(8, 16)
        Me.chkImageOverlayEnabled.Name = "chkImageOverlayEnabled"
        Me.chkImageOverlayEnabled.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkImageOverlayEnabled.Size = New System.Drawing.Size(72, 17)
        Me.chkImageOverlayEnabled.TabIndex = 6
        Me.chkImageOverlayEnabled.Text = "enabled"
        Me.chkImageOverlayEnabled.UseVisualStyleBackColor = False
        '
        'chkImageOverlayTransparent
        '
        Me.chkImageOverlayTransparent.BackColor = System.Drawing.SystemColors.Control
        Me.chkImageOverlayTransparent.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkImageOverlayTransparent.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkImageOverlayTransparent.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkImageOverlayTransparent.Location = New System.Drawing.Point(116, 45)
        Me.chkImageOverlayTransparent.Name = "chkImageOverlayTransparent"
        Me.chkImageOverlayTransparent.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkImageOverlayTransparent.Size = New System.Drawing.Size(131, 20)
        Me.chkImageOverlayTransparent.TabIndex = 5
        Me.chkImageOverlayTransparent.Text = "transparent"
        Me.chkImageOverlayTransparent.UseVisualStyleBackColor = False
        '
        'edtImageOverlayLeft
        '
        Me.edtImageOverlayLeft.AcceptsReturn = True
        Me.edtImageOverlayLeft.BackColor = System.Drawing.SystemColors.Window
        Me.edtImageOverlayLeft.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtImageOverlayLeft.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtImageOverlayLeft.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtImageOverlayLeft.Location = New System.Drawing.Point(19, 59)
        Me.edtImageOverlayLeft.MaxLength = 0
        Me.edtImageOverlayLeft.Name = "edtImageOverlayLeft"
        Me.edtImageOverlayLeft.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtImageOverlayLeft.Size = New System.Drawing.Size(33, 20)
        Me.edtImageOverlayLeft.TabIndex = 4
        Me.edtImageOverlayLeft.Text = "10"
        '
        'edtImageOverlayTop
        '
        Me.edtImageOverlayTop.AcceptsReturn = True
        Me.edtImageOverlayTop.BackColor = System.Drawing.SystemColors.Window
        Me.edtImageOverlayTop.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtImageOverlayTop.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtImageOverlayTop.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtImageOverlayTop.Location = New System.Drawing.Point(61, 59)
        Me.edtImageOverlayTop.MaxLength = 0
        Me.edtImageOverlayTop.Name = "edtImageOverlayTop"
        Me.edtImageOverlayTop.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtImageOverlayTop.Size = New System.Drawing.Size(33, 20)
        Me.edtImageOverlayTop.TabIndex = 3
        Me.edtImageOverlayTop.Text = "10"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.BackColor = System.Drawing.SystemColors.Control
        Me.Label48.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label48.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label48.Location = New System.Drawing.Point(18, 46)
        Me.Label48.Name = "Label48"
        Me.Label48.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label48.Size = New System.Drawing.Size(22, 14)
        Me.Label48.TabIndex = 10
        Me.Label48.Text = "left"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.BackColor = System.Drawing.SystemColors.Control
        Me.Label49.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label49.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label49.Location = New System.Drawing.Point(58, 46)
        Me.Label49.Name = "Label49"
        Me.Label49.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label49.Size = New System.Drawing.Size(22, 14)
        Me.Label49.TabIndex = 9
        Me.Label49.Text = "top"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(670, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 14)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "facets"
        '
        'btnPIP
        '
        Me.btnPIP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPIP.ImageIndex = 0
        Me.btnPIP.ImageList = Me.ImageList1
        Me.btnPIP.Location = New System.Drawing.Point(708, 23)
        Me.btnPIP.Name = "btnPIP"
        Me.btnPIP.Size = New System.Drawing.Size(227, 26)
        Me.btnPIP.TabIndex = 45
        Me.btnPIP.Text = "PIP from another TVideoGrabber control"
        Me.btnPIP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(600, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 14)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "grid:"
        '
        'rdgTextOverlayAlign
        '
        Me.rdgTextOverlayAlign.Controls.Add(Me.rdgTextOverlayAlignRight)
        Me.rdgTextOverlayAlign.Controls.Add(Me.rdgTextOverlayAlignCenter)
        Me.rdgTextOverlayAlign.Controls.Add(Me.rdgTextOverlayAlignLeft)
        Me.rdgTextOverlayAlign.Location = New System.Drawing.Point(8, 134)
        Me.rdgTextOverlayAlign.Name = "rdgTextOverlayAlign"
        Me.rdgTextOverlayAlign.Size = New System.Drawing.Size(179, 36)
        Me.rdgTextOverlayAlign.TabIndex = 48
        Me.rdgTextOverlayAlign.TabStop = False
        '
        'rdgTextOverlayAlignLeft
        '
        Me.rdgTextOverlayAlignLeft.AutoSize = True
        Me.rdgTextOverlayAlignLeft.BackColor = System.Drawing.SystemColors.Control
        Me.rdgTextOverlayAlignLeft.Checked = True
        Me.rdgTextOverlayAlignLeft.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgTextOverlayAlignLeft.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgTextOverlayAlignLeft.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgTextOverlayAlignLeft.Location = New System.Drawing.Point(8, 14)
        Me.rdgTextOverlayAlignLeft.Name = "rdgTextOverlayAlignLeft"
        Me.rdgTextOverlayAlignLeft.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgTextOverlayAlignLeft.Size = New System.Drawing.Size(40, 18)
        Me.rdgTextOverlayAlignLeft.TabIndex = 24
        Me.rdgTextOverlayAlignLeft.TabStop = True
        Me.rdgTextOverlayAlignLeft.Tag = "0"
        Me.rdgTextOverlayAlignLeft.Text = "left"
        Me.rdgTextOverlayAlignLeft.UseVisualStyleBackColor = False
        '
        'rdgTextOverlayAlignCenter
        '
        Me.rdgTextOverlayAlignCenter.AutoSize = True
        Me.rdgTextOverlayAlignCenter.BackColor = System.Drawing.SystemColors.Control
        Me.rdgTextOverlayAlignCenter.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgTextOverlayAlignCenter.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgTextOverlayAlignCenter.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgTextOverlayAlignCenter.Location = New System.Drawing.Point(59, 14)
        Me.rdgTextOverlayAlignCenter.Name = "rdgTextOverlayAlignCenter"
        Me.rdgTextOverlayAlignCenter.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgTextOverlayAlignCenter.Size = New System.Drawing.Size(56, 18)
        Me.rdgTextOverlayAlignCenter.TabIndex = 23
        Me.rdgTextOverlayAlignCenter.TabStop = True
        Me.rdgTextOverlayAlignCenter.Tag = "1"
        Me.rdgTextOverlayAlignCenter.Text = "center"
        Me.rdgTextOverlayAlignCenter.UseVisualStyleBackColor = False
        '
        'rdgTextOverlayAlignRight
        '
        Me.rdgTextOverlayAlignRight.AutoSize = True
        Me.rdgTextOverlayAlignRight.BackColor = System.Drawing.SystemColors.Control
        Me.rdgTextOverlayAlignRight.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgTextOverlayAlignRight.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgTextOverlayAlignRight.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgTextOverlayAlignRight.Location = New System.Drawing.Point(122, 14)
        Me.rdgTextOverlayAlignRight.Name = "rdgTextOverlayAlignRight"
        Me.rdgTextOverlayAlignRight.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgTextOverlayAlignRight.Size = New System.Drawing.Size(46, 18)
        Me.rdgTextOverlayAlignRight.TabIndex = 22
        Me.rdgTextOverlayAlignRight.TabStop = True
        Me.rdgTextOverlayAlignRight.Tag = "2"
        Me.rdgTextOverlayAlignRight.Text = "right"
        Me.rdgTextOverlayAlignRight.UseVisualStyleBackColor = False
        '
        'Overlays
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(951, 231)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkAdjustOverlayAspectRatio)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnDrawGridColor)
        Me.Controls.Add(Me.btnPIP)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.edtDrawGrid)
        Me.Controls.Add(Me.grbTextOverlay)
        Me.Controls.Add(Me.grbFreeHand)
        Me.Controls.Add(Me.grbBitmapOverlay)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(4, 23)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Overlays"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.grbTextOverlay.ResumeLayout(False)
        Me.grbTextOverlay.PerformLayout()
        Me.rgdTextOverlayShadowDirection.ResumeLayout(False)
        Me.grbOverlaySelector.ResumeLayout(False)
        Me.grbFreeHand.ResumeLayout(False)
        Me.grbBitmapOverlay.ResumeLayout(False)
        Me.grbBitmapOverlay.PerformLayout()
        CType(Me.tbrChromaKeyLeeway, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbrImageOverlayAlphaBlending, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpImageOverlaySelector.ResumeLayout(False)
        Me.rdgTextOverlayAlign.ResumeLayout(False)
        Me.rdgTextOverlayAlign.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region
    Dim FFontSize As Integer = 12

    Dim PIPVideoGrabber As AxVidgrab_NET.AxVideoGrabberNET

    Public Sub RefreshControls()
        btnDrawGridColor.BackColor = MainForm.DefInstance.frmOverlays_btnDrawGridColor
        btnFreeHandColor.BackColor = MainForm.DefInstance.frmOverlays_btnFreeHandColor
        chkAdjustOverlayAspectRatio.Checked = MainForm.DefInstance.AxVideoGrabberNET1.AdjustOverlayAspectRatio
    End Sub

    Private Sub Overlays_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextSelector0.Checked = True
        ImageSelector0.Checked = True
    End Sub

    Private Sub chkTextOverlayEnabled_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTextOverlayEnabled.CheckedChanged
        MainForm.DefInstance.AxVideoGrabberNET1.TextOverlay_String = mmoTextOverlayString.Text
        MainForm.DefInstance.AxVideoGrabberNET1.TextOverlay_Enabled = chkTextOverlayEnabled.Checked
    End Sub

    Private Sub chkAdjustOverlayAspectRatio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAdjustOverlayAspectRatio.CheckedChanged
        MainForm.DefInstance.AxVideoGrabberNET1.AdjustOverlayAspectRatio = chkAdjustOverlayAspectRatio.Checked
    End Sub

    Private Sub chkTextOverlayTransparent_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTextOverlayTransparent.CheckedChanged
        MainForm.DefInstance.AxVideoGrabberNET1.TextOverlay_Transparent = chkTextOverlayTransparent.Checked
    End Sub

    Private Sub chkTextOverlayShadow_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTextOverlayShadow.CheckedChanged
        MainForm.DefInstance.AxVideoGrabberNET1.TextOverlay_Shadow = chkTextOverlayShadow.Checked
    End Sub

    Private Sub btnSelectShadowColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectShadowColor.Click
        Dim cd As New ColorDialog
        If cd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            MainForm.DefInstance.AxVideoGrabberNET1.TextOverlay_ShadowColor = cd.Color
        End If
    End Sub

    Private Sub edtTextOverlayTop_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtTextOverlayTop.TextChanged
        If IsNumeric(edtTextOverlayTop.Text) Then
            MainForm.DefInstance.AxVideoGrabberNET1.TextOverlay_Top = edtTextOverlayTop.Text
        End If
    End Sub

    Private Sub edtTextOverlayRight_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtTextOverlayRight.TextChanged
        If IsNumeric(edtTextOverlayRight.Text) Then
            MainForm.DefInstance.AxVideoGrabberNET1.TextOverlay_Right = edtTextOverlayRight.Text
        End If
    End Sub

    Private Sub edtTextOverlayLeft_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtTextOverlayLeft.TextChanged
        If IsNumeric(edtTextOverlayLeft.Text) Then
            MainForm.DefInstance.AxVideoGrabberNET1.TextOverlay_Left = edtTextOverlayLeft.Text
        End If
    End Sub

    Private Sub mmoTextOverlayString_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mmoTextOverlayString.TextChanged
        MainForm.DefInstance.AxVideoGrabberNET1.TextOverlay_String = mmoTextOverlayString.Text
    End Sub

    Private Sub rdgTextOverlayAlign_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgTextOverlayAlignCenter.CheckedChanged
        If CType(sender, RadioButton).Checked Then
            MainForm.DefInstance.AxVideoGrabberNET1.TextOverlay_Align = sender.Tag
        End If
    End Sub

    Private Overloads Sub btnSelectFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectFont.Click
        Dim fd As New FontDialog
        If fd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            MainForm.DefInstance.AxVideoGrabberNET1.TextOverlay_Font = fd.Font.ToHfont().ToInt32()
        End If
    End Sub

    Private Sub btnSelectFontColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectFontColor.Click
        Dim cd As New ColorDialog
        If cd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            MainForm.DefInstance.AxVideoGrabberNET1.TextOverlay_FontColor = cd.Color
        End If
    End Sub

    Private Sub btnBackColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackColor.Click
        Dim cd As New ColorDialog
        If cd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            MainForm.DefInstance.AxVideoGrabberNET1.TextOverlay_BkColor = cd.Color
        End If
    End Sub

    Private Sub chkTextOverlayScrolling_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTextOverlayScrolling.CheckedChanged
        MainForm.DefInstance.AxVideoGrabberNET1.TextOverlay_Scrolling = chkTextOverlayScrolling.Checked
    End Sub

    Private Sub edtTextOverlayScrollingSpeed_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtTextOverlayScrollingSpeed.TextChanged
        If IsNumeric(edtTextOverlayScrollingSpeed.Text) Then
            MainForm.DefInstance.AxVideoGrabberNET1.TextOverlay_ScrollingSpeed = edtTextOverlayScrollingSpeed.Text
        End If
    End Sub

    Private Sub TextSelector_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextSelector4.CheckedChanged, TextSelector2.CheckedChanged, TextSelector1.CheckedChanged, TextSelector0.CheckedChanged, TextSelector3.CheckedChanged
        If CType(sender, RadioButton).Checked Then
            MainForm.DefInstance.AxVideoGrabberNET1.TextOverlay_Selector = sender.Tag

            ' as we have selected another set, let's reload the corresponding values
            chkTextOverlayEnabled.Checked = MainForm.DefInstance.AxVideoGrabberNET1.TextOverlay_Enabled

            mmoTextOverlayString.Text = MainForm.DefInstance.AxVideoGrabberNET1.TextOverlay_String
            edtTextOverlayLeft.Text = MainForm.DefInstance.AxVideoGrabberNET1.TextOverlay_Left.ToString
            edtTextOverlayTop.Text = MainForm.DefInstance.AxVideoGrabberNET1.TextOverlay_Top.ToString
            edtTextOverlayRight.Text = MainForm.DefInstance.AxVideoGrabberNET1.TextOverlay_Right.ToString
            edtTextOverlayScrollingSpeed.Text = MainForm.DefInstance.AxVideoGrabberNET1.TextOverlay_ScrollingSpeed

            SetRadioButtonInGroupUsingTag(rdgTextOverlayAlign, MainForm.DefInstance.AxVideoGrabberNET1.TextOverlay_Align)
            chkTextOverlayTransparent.Checked = MainForm.DefInstance.AxVideoGrabberNET1.TextOverlay_Transparent
            chkTextOverlayShadow.Checked = MainForm.DefInstance.AxVideoGrabberNET1.TextOverlay_Shadow
            chkTextOverlayScrolling.Checked = MainForm.DefInstance.AxVideoGrabberNET1.TextOverlay_Scrolling
            SetRadioButtonInGroupUsingTag(rgdTextOverlayShadowDirection, MainForm.DefInstance.AxVideoGrabberNET1.TextOverlay_ShadowDirection)
        End If
    End Sub

    Private Sub ShadowDirection_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rgdShadow0.CheckedChanged, rgdShadow1.CheckedChanged, rgdShadow2.CheckedChanged, rgdShadow3.CheckedChanged, rgdShadow4.CheckedChanged, rgdShadow5.CheckedChanged, rgdShadow6.CheckedChanged, rgdShadow7.CheckedChanged
        If CType(sender, RadioButton).Checked Then
            MainForm.DefInstance.AxVideoGrabberNET1.TextOverlay_ShadowDirection = sender.Tag
        End If
    End Sub

    Private Sub btnPIP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPIP.Click
        Dim dlgOpen As OpenFileDialog = New OpenFileDialog
        dlgOpen.Filter = OPEN_MEDIA_FILES
        If dlgOpen.ShowDialog = Windows.Forms.DialogResult.OK Then
            If PIPVideoGrabber Is Nothing Then
                PIPVideoGrabber = New AxVidgrab_NET.AxVideoGrabberNET()
                Me.Controls.Add(Me.PIPVideoGrabber)
                PIPVideoGrabber.VideoRenderer = Vidgrab_NET.TxVideoRenderer.vr_None
                PIPVideoGrabber.Visible = False
                MainForm.DefInstance.AxVideoGrabberNET1.Mixer_SetupPIPFromSource(PIPVideoGrabber.UniqueID, 0, 0, 0, 0, True, 10, 10, 200, 150, False)
            End If
            PIPVideoGrabber.PlayerFileName = dlgOpen.FileName
            PIPVideoGrabber.OpenPlayer()
        End If
    End Sub

    Private Sub btnBitmapOverlayFromFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImageOverlayFromFile.Click
        Dim fd As New OpenFileDialog

        fd.Filter = OPEN_PICTURE_FILES
        If fd.ShowDialog = Windows.Forms.DialogResult.OK Then
            MainForm.DefInstance.AxVideoGrabberNET1.SetImageOverlayFromImageFile(fd.FileName)
        End If
    End Sub

    Private Sub Overlays_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        If Visible Then
            RefreshControls()
        End If
    End Sub

    Private Sub ImageSelector_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImageSelector0.CheckedChanged, ImageSelector1.CheckedChanged, ImageSelector2.CheckedChanged, ImageSelector3.CheckedChanged, ImageSelector4.CheckedChanged, ImageSelector5.CheckedChanged, ImageSelector6.CheckedChanged, ImageSelector7.CheckedChanged, ImageSelector8.CheckedChanged, ImageSelector9.CheckedChanged
        MainForm.DefInstance.AxVideoGrabberNET1.ImageOverlaySelector = sender.Tag

        chkImageOverlayEnabled.Checked = MainForm.DefInstance.AxVideoGrabberNET1.ImageOverlayEnabled
        edtImageOverlayLeft.Text = MainForm.DefInstance.AxVideoGrabberNET1.ImageOverlay_LeftLocation.ToString()
        edtImageOverlayTop.Text = MainForm.DefInstance.AxVideoGrabberNET1.ImageOverlay_TopLocation.ToString()
        edtImageOverlayWidth.Text = MainForm.DefInstance.AxVideoGrabberNET1.ImageOverlay_Width.ToString()
        edtImageOverlayHeight.Text = MainForm.DefInstance.AxVideoGrabberNET1.ImageOverlay_Height.ToString()

        chkImageOverlayTransparent.Checked = MainForm.DefInstance.AxVideoGrabberNET1.ImageOverlay_Transparent
        chkImageOverlayUseTransparentColor.Checked = MainForm.DefInstance.AxVideoGrabberNET1.ImageOverlay_UseTransparentColor
        edtImageOverlayTransparentColorValue.Text = "&H" + MainForm.DefInstance.AxVideoGrabberNET1.ImageOverlay_TransparentColorValue.ToString("X000000")
        chkImageOverlayAlphaBlend.Checked = MainForm.DefInstance.AxVideoGrabberNET1.ImageOverlay_AlphaBlend
        tbrImageOverlayAlphaBlending.Value = MainForm.DefInstance.AxVideoGrabberNET1.ImageOverlay_AlphaBlendValue

        chkImageOverlayChromaKey.Checked = MainForm.DefInstance.AxVideoGrabberNET1.ImageOverlay_ChromaKey
        edtImageOverlayChromaKeyColorValue.Text = "&H" + MainForm.DefInstance.AxVideoGrabberNET1.ImageOverlay_ChromaKeyRGBColor.ToString("X000000")
        tbrChromaKeyLeeway.Value = MainForm.DefInstance.AxVideoGrabberNET1.ImageOverlay_ChromaKeyLeewayPercent
    End Sub

    Private Sub chkImageOverlayEnabled_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkImageOverlayEnabled.CheckedChanged
        MainForm.DefInstance.AxVideoGrabberNET1.ImageOverlayEnabled = chkImageOverlayEnabled.Checked
    End Sub

    Private Sub edtImageOverlayLeft_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtImageOverlayLeft.TextChanged
        If IsNumeric(edtImageOverlayLeft.Text) Then
            MainForm.DefInstance.AxVideoGrabberNET1.ImageOverlay_LeftLocation = edtImageOverlayLeft.Text
        End If
    End Sub

    Private Sub edtImageOverlayTop_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtImageOverlayTop.TextChanged
        If IsNumeric(edtImageOverlayTop.Text) Then
            MainForm.DefInstance.AxVideoGrabberNET1.ImageOverlay_TopLocation = edtImageOverlayTop.Text
        End If
    End Sub

    Private Sub edtImageOverlayWidth_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtImageOverlayWidth.TextChanged
        If IsNumeric(edtImageOverlayWidth.Text) Then
            MainForm.DefInstance.AxVideoGrabberNET1.ImageOverlay_Width = edtImageOverlayWidth.Text
        End If
    End Sub

    Private Sub edtImageOverlayHeight_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtImageOverlayHeight.TextChanged
        If IsNumeric(edtImageOverlayHeight.Text) Then
            MainForm.DefInstance.AxVideoGrabberNET1.ImageOverlay_Height = edtImageOverlayHeight.Text
        End If
    End Sub

    Private Sub chkImageOverlayTransparent_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkImageOverlayTransparent.CheckedChanged
        MainForm.DefInstance.AxVideoGrabberNET1.ImageOverlay_Transparent = chkImageOverlayTransparent.Checked
    End Sub

    Private Sub btnImageOverlayPickupColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImageOverlayPickupTransparentColor.Click
        If MainForm.DefInstance.cPickupColor.LastRGBPixelValueAtMousePosition <> -1 Then
            MainForm.DefInstance.AxVideoGrabberNET1.ImageOverlay_TransparentColorValue = MainForm.DefInstance.cPickupColor.LastRGBPixelValueAtMousePosition
            edtImageOverlayTransparentColorValue.Text = "&H" + MainForm.DefInstance.cPickupColor.LastRGBPixelValueAtMousePosition.ToString("X000000")
        End If
    End Sub

    Private Sub btnImageOverlayPickupHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImageOverlayPickupTransparentColorHelp.Click
        MessageBox.Show("while the preview is running:" & vbCrLf & "- load the image overlay" & vbCrLf & "- enable 'transparent' and 'use transp. color value'" & vbCrLf & "- in the video window, click on the video frame on the color of the overlayed image you want to be transparent" & vbCrLf & "- click on 'pickup the transparent color' to select it as transparent color", _
                "DataStead TVideoGrabber VB.NET OCX Demo", MessageBoxButtons.OK)
    End Sub

    Private Sub chkImageOverlayUseTransparentColor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkImageOverlayUseTransparentColor.CheckedChanged
        MainForm.DefInstance.AxVideoGrabberNET1.ImageOverlay_UseTransparentColor = chkImageOverlayUseTransparentColor.Checked
    End Sub

    Private Sub edtImageOverlayTransparentColorValue_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtImageOverlayTransparentColorValue.TextChanged
        If IsNumeric(edtImageOverlayTransparentColorValue.Text) Then
            MainForm.DefInstance.AxVideoGrabberNET1.ImageOverlay_TransparentColorValue = edtImageOverlayTransparentColorValue.Text
        End If
    End Sub

    Private Sub chkImageOverlayAlphaBlend_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkImageOverlayAlphaBlend.CheckedChanged
        MainForm.DefInstance.AxVideoGrabberNET1.ImageOverlay_AlphaBlend = chkImageOverlayAlphaBlend.Checked
    End Sub

    Private Sub tbrImageOverlayAlphaBlending_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbrImageOverlayAlphaBlending.Scroll
        MainForm.DefInstance.AxVideoGrabberNET1.ImageOverlay_AlphaBlendValue = tbrImageOverlayAlphaBlending.Value
    End Sub

    Private Sub chkImageOverlayChromaKey_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkImageOverlayChromaKey.CheckedChanged
        MainForm.DefInstance.AxVideoGrabberNET1.ImageOverlay_ChromaKey = chkImageOverlayChromaKey.Checked
    End Sub

    Private Sub edtImageOverlayChromaKeyColorValue_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtImageOverlayChromaKeyColorValue.TextChanged
        If IsNumeric(edtImageOverlayChromaKeyColorValue.Text) Then
            MainForm.DefInstance.AxVideoGrabberNET1.ImageOverlay_ChromaKeyRGBColor = edtImageOverlayChromaKeyColorValue.Text
        End If
    End Sub

    Private Sub btnImageOverlayPickupChromaKeyColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImageOverlayPickupChromaKeyColor.Click
        If MainForm.DefInstance.cPickupColor.LastRGBPixelValueAtMousePosition <> -1 Then
            MainForm.DefInstance.AxVideoGrabberNET1.ImageOverlay_ChromaKeyRGBColor = MainForm.DefInstance.cPickupColor.LastRGBPixelValueAtMousePosition
            edtImageOverlayChromaKeyColorValue.Text = "&H" + MainForm.DefInstance.cPickupColor.LastRGBPixelValueAtMousePosition.ToString("X000000")
        End If
    End Sub

    Private Sub btnImageOverlayPickupChromaKeyColorHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImageOverlayPickupChromaKeyColorHelp.Click
        MessageBox.Show("while the clip is playing:" & vbCrLf & "- in the video window, click on the video frame on the background color you want to be used as chroma key" & vbCrLf & "- click on the 'pickup the chroma key' button to select it as chroma key" & vbCrLf & " - load the image overlay" & vbCrLf & "- enable 'chroma key' then adjust the leeway percent (default = 25%)", _
                "DataStead TVideoGrabber VB.NET OCX Demo", MessageBoxButtons.OK)
    End Sub

    Private Sub tbrChromaKeyLeeway_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbrChromaKeyLeeway.Scroll
        MainForm.DefInstance.AxVideoGrabberNET1.ImageOverlay_ChromaKeyLeewayPercent = tbrChromaKeyLeeway.Value
    End Sub

    Private Sub chkFreeHandEnabled_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFreeHandEnabled.CheckedChanged
        ' the sample code is located in the OnMouse... events and the overlay is performed in the OnFrameBitmap event of MainForm
    End Sub

    Private Sub btnFreeHandErase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFreeHandErase.Click
        MainForm.DefInstance.cFreeHandDrawing.iArrayCoordinates = 0
        MainForm.DefInstance.AxVideoGrabberNET1.RefreshPlayerOverlays()
    End Sub

    Private Sub btnFreeHandColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFreeHandColor.Click
        Dim cd As New ColorDialog
        If cd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            MainForm.DefInstance.frmOverlays_btnFreeHandColor = cd.Color
            btnFreeHandColor.BackColor = cd.Color
        End If
    End Sub


    Private Sub edtDrawGrid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtDrawGrid.TextChanged
        Select Case Val(edtDrawGrid.Text)
            Case Is > 100
                MainForm.DefInstance.frmOverlays_edtDrawGrid = 100
            Case Is > 1
                MainForm.DefInstance.frmOverlays_edtDrawGrid = Val(edtDrawGrid.Text)
            Case Else
                MainForm.DefInstance.frmOverlays_edtDrawGrid = 0
        End Select
        ' frmOverlays_edtDrawGrid is tested in the OnFrameOverlayUsingDC event of MainForm
    End Sub

    Private Sub btnDrawGridColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDrawGridColor.Click
        Dim cd As New ColorDialog
        If cd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            MainForm.DefInstance.frmOverlays_btnDrawGridColor = cd.Color
            btnDrawGridColor.BackColor = cd.Color
        End If
    End Sub
End Class
