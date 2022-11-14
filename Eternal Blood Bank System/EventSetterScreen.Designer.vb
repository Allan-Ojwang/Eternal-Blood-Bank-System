<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EventSetterScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SignUpCorners = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.DR = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.ActivityTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.LocationTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.SaveButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.backBtn = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BackElipse = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        CType(Me.backBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SignUpCorners
        '
        Me.SignUpCorners.ElipseRadius = 20
        Me.SignUpCorners.TargetControl = Me
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(192, 78)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(61, 25)
        Me.BunifuCustomLabel1.TabIndex = 13
        Me.BunifuCustomLabel1.Text = "Date"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(192, 217)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(89, 25)
        Me.BunifuCustomLabel2.TabIndex = 14
        Me.BunifuCustomLabel2.Text = "Activity"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(192, 146)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(102, 25)
        Me.BunifuCustomLabel3.TabIndex = 15
        Me.BunifuCustomLabel3.Text = "Location"
        '
        'DR
        '
        Me.DR.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.DR.BorderRadius = 0
        Me.DR.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DR.ForeColor = System.Drawing.Color.Black
        Me.DR.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DR.FormatCustom = "dd-MM-yyyy"
        Me.DR.Location = New System.Drawing.Point(357, 78)
        Me.DR.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.DR.Name = "DR"
        Me.DR.Size = New System.Drawing.Size(264, 32)
        Me.DR.TabIndex = 30
        Me.DR.Value = New Date(2022, 10, 22, 0, 0, 0, 0)
        '
        'ActivityTb
        '
        Me.ActivityTb.BackColor = System.Drawing.SystemColors.Control
        Me.ActivityTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ActivityTb.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActivityTb.ForeColor = System.Drawing.Color.Black
        Me.ActivityTb.HintForeColor = System.Drawing.Color.Black
        Me.ActivityTb.HintText = "Enter Activity"
        Me.ActivityTb.isPassword = False
        Me.ActivityTb.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ActivityTb.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ActivityTb.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ActivityTb.LineThickness = 4
        Me.ActivityTb.Location = New System.Drawing.Point(357, 217)
        Me.ActivityTb.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.ActivityTb.Name = "ActivityTb"
        Me.ActivityTb.Size = New System.Drawing.Size(264, 29)
        Me.ActivityTb.TabIndex = 45
        Me.ActivityTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'LocationTb
        '
        Me.LocationTb.BackColor = System.Drawing.SystemColors.Control
        Me.LocationTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.LocationTb.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocationTb.ForeColor = System.Drawing.Color.Black
        Me.LocationTb.HintForeColor = System.Drawing.Color.Black
        Me.LocationTb.HintText = "Enter Location"
        Me.LocationTb.isPassword = False
        Me.LocationTb.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.LocationTb.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.LocationTb.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.LocationTb.LineThickness = 4
        Me.LocationTb.Location = New System.Drawing.Point(357, 142)
        Me.LocationTb.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.LocationTb.Name = "LocationTb"
        Me.LocationTb.Size = New System.Drawing.Size(264, 29)
        Me.LocationTb.TabIndex = 44
        Me.LocationTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.SaveButton.Location = New System.Drawing.Point(289, 313)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.SaveButton.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.SaveButton.OnHoverTextColor = System.Drawing.Color.Black
        Me.SaveButton.selected = False
        Me.SaveButton.Size = New System.Drawing.Size(282, 32)
        Me.SaveButton.TabIndex = 47
        Me.SaveButton.Text = "Save"
        Me.SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SaveButton.Textcolor = System.Drawing.Color.Black
        Me.SaveButton.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.backBtn.TabIndex = 48
        Me.backBtn.TabStop = False
        Me.backBtn.Zoom = 10
        '
        'BackElipse
        '
        Me.BackElipse.ElipseRadius = 5
        Me.BackElipse.TargetControl = Me.backBtn
        '
        'EventSetterScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.backBtn)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.ActivityTb)
        Me.Controls.Add(Me.LocationTb)
        Me.Controls.Add(Me.DR)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EventSetterScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EventSetterScreen"
        CType(Me.backBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SignUpCorners As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents DR As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents ActivityTb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents LocationTb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents SaveButton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents backBtn As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BackElipse As Bunifu.Framework.UI.BunifuElipse
End Class
