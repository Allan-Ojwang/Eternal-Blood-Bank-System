<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScheduleSetterScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblMonthAndYear = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TodayButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.NextButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PrevButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.f1Days = New System.Windows.Forms.FlowLayoutPanel()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BackElipse = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.backBtn = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.backBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.backBtn)
        Me.Panel1.Controls.Add(Me.lblMonthAndYear)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1101, 79)
        Me.Panel1.TabIndex = 4
        '
        'lblMonthAndYear
        '
        Me.lblMonthAndYear.AutoSize = True
        Me.lblMonthAndYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthAndYear.Location = New System.Drawing.Point(360, 22)
        Me.lblMonthAndYear.Name = "lblMonthAndYear"
        Me.lblMonthAndYear.Size = New System.Drawing.Size(256, 42)
        Me.lblMonthAndYear.TabIndex = 1
        Me.lblMonthAndYear.Text = "January, 2022"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TodayButton)
        Me.Panel2.Controls.Add(Me.NextButton)
        Me.Panel2.Controls.Add(Me.PrevButton)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(847, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(254, 79)
        Me.Panel2.TabIndex = 0
        '
        'TodayButton
        '
        Me.TodayButton.Activecolor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TodayButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TodayButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TodayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TodayButton.BorderRadius = 0
        Me.TodayButton.ButtonText = "Today"
        Me.TodayButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TodayButton.DisabledColor = System.Drawing.Color.Gray
        Me.TodayButton.Iconcolor = System.Drawing.Color.Transparent
        Me.TodayButton.Iconimage = Nothing
        Me.TodayButton.Iconimage_right = Nothing
        Me.TodayButton.Iconimage_right_Selected = Nothing
        Me.TodayButton.Iconimage_Selected = Nothing
        Me.TodayButton.IconMarginLeft = 0
        Me.TodayButton.IconMarginRight = 0
        Me.TodayButton.IconRightVisible = True
        Me.TodayButton.IconRightZoom = 0R
        Me.TodayButton.IconVisible = True
        Me.TodayButton.IconZoom = 90.0R
        Me.TodayButton.IsTab = False
        Me.TodayButton.Location = New System.Drawing.Point(78, 12)
        Me.TodayButton.Name = "TodayButton"
        Me.TodayButton.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TodayButton.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.TodayButton.OnHoverTextColor = System.Drawing.Color.Black
        Me.TodayButton.selected = False
        Me.TodayButton.Size = New System.Drawing.Size(95, 53)
        Me.TodayButton.TabIndex = 58
        Me.TodayButton.Text = "Today"
        Me.TodayButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.TodayButton.Textcolor = System.Drawing.Color.Black
        Me.TodayButton.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'NextButton
        '
        Me.NextButton.Activecolor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.NextButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NextButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.NextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NextButton.BorderRadius = 0
        Me.NextButton.ButtonText = ">"
        Me.NextButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NextButton.DisabledColor = System.Drawing.Color.Gray
        Me.NextButton.Iconcolor = System.Drawing.Color.Transparent
        Me.NextButton.Iconimage = Nothing
        Me.NextButton.Iconimage_right = Nothing
        Me.NextButton.Iconimage_right_Selected = Nothing
        Me.NextButton.Iconimage_Selected = Nothing
        Me.NextButton.IconMarginLeft = 0
        Me.NextButton.IconMarginRight = 0
        Me.NextButton.IconRightVisible = True
        Me.NextButton.IconRightZoom = 0R
        Me.NextButton.IconVisible = True
        Me.NextButton.IconZoom = 90.0R
        Me.NextButton.IsTab = False
        Me.NextButton.Location = New System.Drawing.Point(183, 12)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.NextButton.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.NextButton.OnHoverTextColor = System.Drawing.Color.Black
        Me.NextButton.selected = False
        Me.NextButton.Size = New System.Drawing.Size(63, 53)
        Me.NextButton.TabIndex = 57
        Me.NextButton.Text = ">"
        Me.NextButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.NextButton.Textcolor = System.Drawing.Color.Black
        Me.NextButton.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PrevButton
        '
        Me.PrevButton.Activecolor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.PrevButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrevButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.PrevButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PrevButton.BorderRadius = 0
        Me.PrevButton.ButtonText = "<"
        Me.PrevButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PrevButton.DisabledColor = System.Drawing.Color.Gray
        Me.PrevButton.Iconcolor = System.Drawing.Color.Transparent
        Me.PrevButton.Iconimage = Nothing
        Me.PrevButton.Iconimage_right = Nothing
        Me.PrevButton.Iconimage_right_Selected = Nothing
        Me.PrevButton.Iconimage_Selected = Nothing
        Me.PrevButton.IconMarginLeft = 0
        Me.PrevButton.IconMarginRight = 0
        Me.PrevButton.IconRightVisible = True
        Me.PrevButton.IconRightZoom = 0R
        Me.PrevButton.IconVisible = True
        Me.PrevButton.IconZoom = 90.0R
        Me.PrevButton.IsTab = False
        Me.PrevButton.Location = New System.Drawing.Point(3, 12)
        Me.PrevButton.Name = "PrevButton"
        Me.PrevButton.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.PrevButton.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.PrevButton.OnHoverTextColor = System.Drawing.Color.Black
        Me.PrevButton.selected = False
        Me.PrevButton.Size = New System.Drawing.Size(63, 53)
        Me.PrevButton.TabIndex = 56
        Me.PrevButton.Text = "<"
        Me.PrevButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.PrevButton.Textcolor = System.Drawing.Color.Black
        Me.PrevButton.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BunifuCustomLabel8)
        Me.Panel3.Controls.Add(Me.BunifuCustomLabel7)
        Me.Panel3.Controls.Add(Me.BunifuCustomLabel6)
        Me.Panel3.Controls.Add(Me.BunifuCustomLabel5)
        Me.Panel3.Controls.Add(Me.BunifuCustomLabel4)
        Me.Panel3.Controls.Add(Me.BunifuCustomLabel3)
        Me.Panel3.Controls.Add(Me.BunifuCustomLabel2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 79)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1101, 43)
        Me.Panel3.TabIndex = 5
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.BackColor = System.Drawing.Color.IndianRed
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(945, 3)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(151, 36)
        Me.BunifuCustomLabel8.TabIndex = 8
        Me.BunifuCustomLabel8.Text = "Saturday"
        Me.BunifuCustomLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.BackColor = System.Drawing.Color.IndianRed
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(788, 3)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(151, 36)
        Me.BunifuCustomLabel7.TabIndex = 7
        Me.BunifuCustomLabel7.Text = "Friday"
        Me.BunifuCustomLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.BackColor = System.Drawing.Color.IndianRed
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(631, 3)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(151, 36)
        Me.BunifuCustomLabel6.TabIndex = 6
        Me.BunifuCustomLabel6.Text = "Thursday"
        Me.BunifuCustomLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.BackColor = System.Drawing.Color.IndianRed
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(317, 3)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(151, 36)
        Me.BunifuCustomLabel5.TabIndex = 5
        Me.BunifuCustomLabel5.Text = "Tuesday"
        Me.BunifuCustomLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.BackColor = System.Drawing.Color.IndianRed
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(474, 3)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(151, 36)
        Me.BunifuCustomLabel4.TabIndex = 4
        Me.BunifuCustomLabel4.Text = "Wednesday"
        Me.BunifuCustomLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.BackColor = System.Drawing.Color.IndianRed
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(160, 3)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(151, 36)
        Me.BunifuCustomLabel3.TabIndex = 3
        Me.BunifuCustomLabel3.Text = "Monday"
        Me.BunifuCustomLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.IndianRed
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(3, 3)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(151, 36)
        Me.BunifuCustomLabel2.TabIndex = 2
        Me.BunifuCustomLabel2.Text = "Sunday"
        Me.BunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'f1Days
        '
        Me.f1Days.Dock = System.Windows.Forms.DockStyle.Fill
        Me.f1Days.Location = New System.Drawing.Point(0, 122)
        Me.f1Days.Name = "f1Days"
        Me.f1Days.Size = New System.Drawing.Size(1101, 758)
        Me.f1Days.TabIndex = 6
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'BackElipse
        '
        Me.BackElipse.ElipseRadius = 5
        Me.BackElipse.TargetControl = Me.backBtn
        '
        'backBtn
        '
        Me.backBtn.BackColor = System.Drawing.Color.Black
        Me.backBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.backBtn.Image = Global.Eternal_Blood_Bank_System.My.Resources.Resources.go_back
        Me.backBtn.ImageActive = Nothing
        Me.backBtn.Location = New System.Drawing.Point(12, 12)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(52, 52)
        Me.backBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.backBtn.TabIndex = 3
        Me.backBtn.TabStop = False
        Me.backBtn.Zoom = 10
        '
        'ScheduleSetterScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1101, 880)
        Me.Controls.Add(Me.f1Days)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ScheduleSetterScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ScheduleSetterScreen"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.backBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblMonthAndYear As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents f1Days As FlowLayoutPanel
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents backBtn As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BackElipse As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents NextButton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents PrevButton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents TodayButton As Bunifu.Framework.UI.BunifuFlatButton
End Class
