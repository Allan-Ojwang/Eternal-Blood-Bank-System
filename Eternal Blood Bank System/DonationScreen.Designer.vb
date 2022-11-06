<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DonationScreen
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
        Me.backBtn = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BackElipse = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.LastNameTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.NumberTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.FirstNameTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.GenderCb = New System.Windows.Forms.ComboBox()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BloodDonatedTB = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BloodTypeCB = New System.Windows.Forms.ComboBox()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.SaveButton = New Bunifu.Framework.UI.BunifuFlatButton()
        CType(Me.backBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
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
        Me.backBtn.TabIndex = 1
        Me.backBtn.TabStop = False
        Me.backBtn.Zoom = 10
        '
        'BackElipse
        '
        Me.BackElipse.ElipseRadius = 5
        Me.BackElipse.TargetControl = Me.backBtn
        '
        'LastNameTb
        '
        Me.LastNameTb.BackColor = System.Drawing.SystemColors.Control
        Me.LastNameTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.LastNameTb.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastNameTb.ForeColor = System.Drawing.Color.Black
        Me.LastNameTb.HintForeColor = System.Drawing.Color.Black
        Me.LastNameTb.HintText = "Enter Last Name"
        Me.LastNameTb.isPassword = False
        Me.LastNameTb.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.LastNameTb.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.LastNameTb.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.LastNameTb.LineThickness = 4
        Me.LastNameTb.Location = New System.Drawing.Point(569, 138)
        Me.LastNameTb.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.LastNameTb.Name = "LastNameTb"
        Me.LastNameTb.Size = New System.Drawing.Size(264, 29)
        Me.LastNameTb.TabIndex = 49
        Me.LastNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'NumberTb
        '
        Me.NumberTb.BackColor = System.Drawing.SystemColors.Control
        Me.NumberTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NumberTb.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberTb.ForeColor = System.Drawing.Color.Black
        Me.NumberTb.HintForeColor = System.Drawing.Color.Black
        Me.NumberTb.HintText = "Enter Phone Number"
        Me.NumberTb.isPassword = False
        Me.NumberTb.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.NumberTb.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.NumberTb.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.NumberTb.LineThickness = 4
        Me.NumberTb.Location = New System.Drawing.Point(242, 233)
        Me.NumberTb.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.NumberTb.Name = "NumberTb"
        Me.NumberTb.Size = New System.Drawing.Size(264, 29)
        Me.NumberTb.TabIndex = 48
        Me.NumberTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'FirstNameTb
        '
        Me.FirstNameTb.BackColor = System.Drawing.SystemColors.Control
        Me.FirstNameTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FirstNameTb.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNameTb.ForeColor = System.Drawing.Color.Black
        Me.FirstNameTb.HintForeColor = System.Drawing.Color.Black
        Me.FirstNameTb.HintText = "Enter First Name"
        Me.FirstNameTb.isPassword = False
        Me.FirstNameTb.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.FirstNameTb.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.FirstNameTb.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.FirstNameTb.LineThickness = 4
        Me.FirstNameTb.Location = New System.Drawing.Point(241, 138)
        Me.FirstNameTb.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.FirstNameTb.Name = "FirstNameTb"
        Me.FirstNameTb.Size = New System.Drawing.Size(264, 29)
        Me.FirstNameTb.TabIndex = 47
        Me.FirstNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(240, 189)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(167, 25)
        Me.BunifuCustomLabel3.TabIndex = 46
        Me.BunifuCustomLabel3.Text = "Phone Number"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(568, 98)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(124, 25)
        Me.BunifuCustomLabel2.TabIndex = 45
        Me.BunifuCustomLabel2.Text = "Last Name"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(240, 98)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(126, 25)
        Me.BunifuCustomLabel1.TabIndex = 44
        Me.BunifuCustomLabel1.Text = "First Name"
        '
        'GenderCb
        '
        Me.GenderCb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.GenderCb.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.GenderCb.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderCb.FormattingEnabled = True
        Me.GenderCb.Items.AddRange(New Object() {"Male", "Female"})
        Me.GenderCb.Location = New System.Drawing.Point(569, 226)
        Me.GenderCb.Name = "GenderCb"
        Me.GenderCb.Size = New System.Drawing.Size(264, 32)
        Me.GenderCb.TabIndex = 51
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(564, 189)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(89, 25)
        Me.BunifuCustomLabel7.TabIndex = 50
        Me.BunifuCustomLabel7.Text = "Gender"
        '
        'BloodDonatedTB
        '
        Me.BloodDonatedTB.BackColor = System.Drawing.SystemColors.Control
        Me.BloodDonatedTB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BloodDonatedTB.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BloodDonatedTB.ForeColor = System.Drawing.Color.Black
        Me.BloodDonatedTB.HintForeColor = System.Drawing.Color.Black
        Me.BloodDonatedTB.HintText = "Enter Blood Amount Donated"
        Me.BloodDonatedTB.isPassword = False
        Me.BloodDonatedTB.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BloodDonatedTB.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BloodDonatedTB.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BloodDonatedTB.LineThickness = 4
        Me.BloodDonatedTB.Location = New System.Drawing.Point(569, 321)
        Me.BloodDonatedTB.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.BloodDonatedTB.Name = "BloodDonatedTB"
        Me.BloodDonatedTB.Size = New System.Drawing.Size(283, 29)
        Me.BloodDonatedTB.TabIndex = 61
        Me.BloodDonatedTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(568, 281)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(167, 25)
        Me.BunifuCustomLabel5.TabIndex = 60
        Me.BunifuCustomLabel5.Text = "Blood Donated"
        '
        'BloodTypeCB
        '
        Me.BloodTypeCB.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BloodTypeCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BloodTypeCB.FormattingEnabled = True
        Me.BloodTypeCB.Items.AddRange(New Object() {"Blood Group A+", "Blood Group A-", "Blood Group B+", "Blood Group B-", "Blood Group AB+", "Blood Group AB-", "Blood Group O+", "Blood Group O-"})
        Me.BloodTypeCB.Location = New System.Drawing.Point(245, 318)
        Me.BloodTypeCB.Name = "BloodTypeCB"
        Me.BloodTypeCB.Size = New System.Drawing.Size(260, 32)
        Me.BloodTypeCB.TabIndex = 59
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(240, 281)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(131, 25)
        Me.BunifuCustomLabel4.TabIndex = 58
        Me.BunifuCustomLabel4.Text = "Blood Type"
        '
        'SaveButton
        '
        Me.SaveButton.Activecolor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.SaveButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.SaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SaveButton.BorderRadius = 0
        Me.SaveButton.ButtonText = "Save"
        Me.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SaveButton.DisabledColor = System.Drawing.Color.Gray
        Me.SaveButton.Iconcolor = System.Drawing.Color.Transparent
        Me.SaveButton.Iconimage = Nothing
        Me.SaveButton.Iconimage_right = Nothing
        Me.SaveButton.Iconimage_right_Selected = Nothing
        Me.SaveButton.Iconimage_Selected = Nothing
        Me.SaveButton.IconMarginLeft = 0
        Me.SaveButton.IconMarginRight = 0
        Me.SaveButton.IconRightVisible = True
        Me.SaveButton.IconRightZoom = 0R
        Me.SaveButton.IconVisible = True
        Me.SaveButton.IconZoom = 90.0R
        Me.SaveButton.IsTab = False
        Me.SaveButton.Location = New System.Drawing.Point(373, 438)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.SaveButton.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.SaveButton.OnHoverTextColor = System.Drawing.Color.Black
        Me.SaveButton.selected = False
        Me.SaveButton.Size = New System.Drawing.Size(331, 32)
        Me.SaveButton.TabIndex = 63
        Me.SaveButton.Text = "Save"
        Me.SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SaveButton.Textcolor = System.Drawing.Color.Black
        Me.SaveButton.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'DonationScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 559)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.BloodDonatedTB)
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Controls.Add(Me.BloodTypeCB)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.GenderCb)
        Me.Controls.Add(Me.BunifuCustomLabel7)
        Me.Controls.Add(Me.LastNameTb)
        Me.Controls.Add(Me.NumberTb)
        Me.Controls.Add(Me.FirstNameTb)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.backBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DonationScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DonationScreen"
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
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents GenderCb As ComboBox
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BloodDonatedTB As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BloodTypeCB As ComboBox
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents SaveButton As Bunifu.Framework.UI.BunifuFlatButton
End Class
