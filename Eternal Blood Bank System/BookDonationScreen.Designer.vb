<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookDonationScreen
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
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BackElipse = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.backBtn = New Bunifu.Framework.UI.BunifuImageButton()
        Me.LastNameTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.NumberTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.FirstNameTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.DOA = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BookButton = New Bunifu.Framework.UI.BunifuFlatButton()
        CType(Me.backBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.backBtn.TabIndex = 0
        Me.backBtn.TabStop = False
        Me.backBtn.Zoom = 10
        '
        'LastNameTb
        '
        Me.LastNameTb.BackColor = System.Drawing.SystemColors.Control
        Me.LastNameTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.LastNameTb.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastNameTb.ForeColor = System.Drawing.Color.Black
        Me.LastNameTb.HintForeColor = System.Drawing.Color.Black
        Me.LastNameTb.HintText = "Enter Your Last Name"
        Me.LastNameTb.isPassword = False
        Me.LastNameTb.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.LastNameTb.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.LastNameTb.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.LastNameTb.LineThickness = 4
        Me.LastNameTb.Location = New System.Drawing.Point(580, 206)
        Me.LastNameTb.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.LastNameTb.Name = "LastNameTb"
        Me.LastNameTb.Size = New System.Drawing.Size(264, 29)
        Me.LastNameTb.TabIndex = 43
        Me.LastNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'NumberTb
        '
        Me.NumberTb.BackColor = System.Drawing.SystemColors.Control
        Me.NumberTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NumberTb.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberTb.ForeColor = System.Drawing.Color.Black
        Me.NumberTb.HintForeColor = System.Drawing.Color.Black
        Me.NumberTb.HintText = "Enter Your Phone Number"
        Me.NumberTb.isPassword = False
        Me.NumberTb.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.NumberTb.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.NumberTb.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.NumberTb.LineThickness = 4
        Me.NumberTb.Location = New System.Drawing.Point(162, 313)
        Me.NumberTb.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.NumberTb.Name = "NumberTb"
        Me.NumberTb.Size = New System.Drawing.Size(264, 29)
        Me.NumberTb.TabIndex = 42
        Me.NumberTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'FirstNameTb
        '
        Me.FirstNameTb.BackColor = System.Drawing.SystemColors.Control
        Me.FirstNameTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FirstNameTb.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNameTb.ForeColor = System.Drawing.Color.Black
        Me.FirstNameTb.HintForeColor = System.Drawing.Color.Black
        Me.FirstNameTb.HintText = "Enter Your First Name"
        Me.FirstNameTb.isPassword = False
        Me.FirstNameTb.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.FirstNameTb.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.FirstNameTb.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.FirstNameTb.LineThickness = 4
        Me.FirstNameTb.Location = New System.Drawing.Point(162, 206)
        Me.FirstNameTb.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.FirstNameTb.Name = "FirstNameTb"
        Me.FirstNameTb.Size = New System.Drawing.Size(264, 29)
        Me.FirstNameTb.TabIndex = 41
        Me.FirstNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'DOA
        '
        Me.DOA.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.DOA.BorderRadius = 0
        Me.DOA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOA.ForeColor = System.Drawing.Color.Black
        Me.DOA.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DOA.FormatCustom = "dd-MM-yyyy"
        Me.DOA.Location = New System.Drawing.Point(580, 313)
        Me.DOA.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DOA.Name = "DOA"
        Me.DOA.Size = New System.Drawing.Size(264, 29)
        Me.DOA.TabIndex = 40
        Me.DOA.Value = New Date(2022, 10, 22, 0, 0, 0, 0)
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(579, 269)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(230, 25)
        Me.BunifuCustomLabel8.TabIndex = 39
        Me.BunifuCustomLabel8.Text = "Date Of Appointment"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(160, 269)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(167, 25)
        Me.BunifuCustomLabel3.TabIndex = 38
        Me.BunifuCustomLabel3.Text = "Phone Number"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(579, 166)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(124, 25)
        Me.BunifuCustomLabel2.TabIndex = 37
        Me.BunifuCustomLabel2.Text = "Last Name"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(161, 166)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(126, 25)
        Me.BunifuCustomLabel1.TabIndex = 36
        Me.BunifuCustomLabel1.Text = "First Name"
        '
        'BookButton
        '
        Me.BookButton.Activecolor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BookButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BookButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BookButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BookButton.BorderRadius = 0
        Me.BookButton.ButtonText = "Book Now"
        Me.BookButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BookButton.DisabledColor = System.Drawing.Color.Gray
        Me.BookButton.Iconcolor = System.Drawing.Color.Transparent
        Me.BookButton.Iconimage = Nothing
        Me.BookButton.Iconimage_right = Nothing
        Me.BookButton.Iconimage_right_Selected = Nothing
        Me.BookButton.Iconimage_Selected = Nothing
        Me.BookButton.IconMarginLeft = 0
        Me.BookButton.IconMarginRight = 0
        Me.BookButton.IconRightVisible = True
        Me.BookButton.IconRightZoom = 0R
        Me.BookButton.IconVisible = True
        Me.BookButton.IconZoom = 90.0R
        Me.BookButton.IsTab = False
        Me.BookButton.Location = New System.Drawing.Point(332, 405)
        Me.BookButton.Name = "BookButton"
        Me.BookButton.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BookButton.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.BookButton.OnHoverTextColor = System.Drawing.Color.Black
        Me.BookButton.selected = False
        Me.BookButton.Size = New System.Drawing.Size(331, 32)
        Me.BookButton.TabIndex = 44
        Me.BookButton.Text = "Book Now"
        Me.BookButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BookButton.Textcolor = System.Drawing.Color.Black
        Me.BookButton.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BookDonationScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 635)
        Me.Controls.Add(Me.BookButton)
        Me.Controls.Add(Me.LastNameTb)
        Me.Controls.Add(Me.NumberTb)
        Me.Controls.Add(Me.FirstNameTb)
        Me.Controls.Add(Me.DOA)
        Me.Controls.Add(Me.BunifuCustomLabel8)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.backBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BookDonationScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BookDonationScreen"
        CType(Me.backBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents backBtn As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BackElipse As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents LastNameTb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents NumberTb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents FirstNameTb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents DOA As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BookButton As Bunifu.Framework.UI.BunifuFlatButton
End Class
