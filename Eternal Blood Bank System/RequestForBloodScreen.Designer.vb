﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RequestForBloodScreen
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
        Me.RequestButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.LastNameTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.NumberTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.FirstNameTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BloodTypeCB = New System.Windows.Forms.ComboBox()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BloodNeededTB = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.GenderCB = New System.Windows.Forms.ComboBox()
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
        Me.backBtn.TabIndex = 1
        Me.backBtn.TabStop = False
        Me.backBtn.Zoom = 10
        '
        'RequestButton
        '
        Me.RequestButton.Activecolor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.RequestButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RequestButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.RequestButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RequestButton.BorderRadius = 0
        Me.RequestButton.ButtonText = "Request Now"
        Me.RequestButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RequestButton.DisabledColor = System.Drawing.Color.Gray
        Me.RequestButton.Iconcolor = System.Drawing.Color.Transparent
        Me.RequestButton.Iconimage = Nothing
        Me.RequestButton.Iconimage_right = Nothing
        Me.RequestButton.Iconimage_right_Selected = Nothing
        Me.RequestButton.Iconimage_Selected = Nothing
        Me.RequestButton.IconMarginLeft = 0
        Me.RequestButton.IconMarginRight = 0
        Me.RequestButton.IconRightVisible = True
        Me.RequestButton.IconRightZoom = 0R
        Me.RequestButton.IconVisible = True
        Me.RequestButton.IconZoom = 90.0R
        Me.RequestButton.IsTab = False
        Me.RequestButton.Location = New System.Drawing.Point(338, 494)
        Me.RequestButton.Name = "RequestButton"
        Me.RequestButton.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.RequestButton.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.RequestButton.OnHoverTextColor = System.Drawing.Color.Black
        Me.RequestButton.selected = False
        Me.RequestButton.Size = New System.Drawing.Size(331, 32)
        Me.RequestButton.TabIndex = 53
        Me.RequestButton.Text = "Request Now"
        Me.RequestButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RequestButton.Textcolor = System.Drawing.Color.Black
        Me.RequestButton.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.LastNameTb.Location = New System.Drawing.Point(583, 156)
        Me.LastNameTb.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.LastNameTb.Name = "LastNameTb"
        Me.LastNameTb.Size = New System.Drawing.Size(283, 29)
        Me.LastNameTb.TabIndex = 52
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
        Me.NumberTb.Location = New System.Drawing.Point(172, 263)
        Me.NumberTb.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.NumberTb.Name = "NumberTb"
        Me.NumberTb.Size = New System.Drawing.Size(264, 29)
        Me.NumberTb.TabIndex = 51
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
        Me.FirstNameTb.Location = New System.Drawing.Point(172, 156)
        Me.FirstNameTb.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.FirstNameTb.Name = "FirstNameTb"
        Me.FirstNameTb.Size = New System.Drawing.Size(264, 29)
        Me.FirstNameTb.TabIndex = 50
        Me.FirstNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(170, 219)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(167, 25)
        Me.BunifuCustomLabel3.TabIndex = 47
        Me.BunifuCustomLabel3.Text = "Phone Number"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(582, 116)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(124, 25)
        Me.BunifuCustomLabel2.TabIndex = 46
        Me.BunifuCustomLabel2.Text = "Last Name"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(171, 116)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(126, 25)
        Me.BunifuCustomLabel1.TabIndex = 45
        Me.BunifuCustomLabel1.Text = "First Name"
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(582, 219)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(89, 25)
        Me.BunifuCustomLabel8.TabIndex = 48
        Me.BunifuCustomLabel8.Text = "Gender"
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(171, 325)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(131, 25)
        Me.BunifuCustomLabel4.TabIndex = 54
        Me.BunifuCustomLabel4.Text = "Blood Type"
        '
        'BloodTypeCB
        '
        Me.BloodTypeCB.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BloodTypeCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BloodTypeCB.FormattingEnabled = True
        Me.BloodTypeCB.Items.AddRange(New Object() {"Blood Group A+", "Blood Group A-", "Blood Group B+", "Blood Group B-", "Blood Group AB+", "Blood Group AB-", "Blood Group O+", "Blood Group O-"})
        Me.BloodTypeCB.Location = New System.Drawing.Point(176, 362)
        Me.BloodTypeCB.Name = "BloodTypeCB"
        Me.BloodTypeCB.Size = New System.Drawing.Size(260, 32)
        Me.BloodTypeCB.TabIndex = 55
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(582, 325)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(167, 25)
        Me.BunifuCustomLabel5.TabIndex = 56
        Me.BunifuCustomLabel5.Text = "Blood Quantity"
        '
        'BloodNeededTB
        '
        Me.BloodNeededTB.BackColor = System.Drawing.SystemColors.Control
        Me.BloodNeededTB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BloodNeededTB.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BloodNeededTB.ForeColor = System.Drawing.Color.Black
        Me.BloodNeededTB.HintForeColor = System.Drawing.Color.Black
        Me.BloodNeededTB.HintText = "Enter Blood Amount Needed"
        Me.BloodNeededTB.isPassword = False
        Me.BloodNeededTB.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BloodNeededTB.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BloodNeededTB.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BloodNeededTB.LineThickness = 4
        Me.BloodNeededTB.Location = New System.Drawing.Point(583, 365)
        Me.BloodNeededTB.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.BloodNeededTB.Name = "BloodNeededTB"
        Me.BloodNeededTB.Size = New System.Drawing.Size(283, 29)
        Me.BloodNeededTB.TabIndex = 57
        Me.BloodNeededTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'GenderCB
        '
        Me.GenderCB.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.GenderCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderCB.FormattingEnabled = True
        Me.GenderCB.Items.AddRange(New Object() {"Male", "Female"})
        Me.GenderCB.Location = New System.Drawing.Point(583, 260)
        Me.GenderCB.Name = "GenderCB"
        Me.GenderCB.Size = New System.Drawing.Size(279, 32)
        Me.GenderCB.TabIndex = 58
        '
        'RequestForBloodScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 635)
        Me.Controls.Add(Me.GenderCB)
        Me.Controls.Add(Me.BloodNeededTB)
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Controls.Add(Me.BloodTypeCB)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.RequestButton)
        Me.Controls.Add(Me.LastNameTb)
        Me.Controls.Add(Me.NumberTb)
        Me.Controls.Add(Me.FirstNameTb)
        Me.Controls.Add(Me.BunifuCustomLabel8)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.backBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RequestForBloodScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RequestForBloodScreen"
        CType(Me.backBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents backBtn As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BackElipse As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents GenderCB As ComboBox
    Friend WithEvents BloodNeededTB As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BloodTypeCB As ComboBox
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents RequestButton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents LastNameTb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents NumberTb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents FirstNameTb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
End Class
