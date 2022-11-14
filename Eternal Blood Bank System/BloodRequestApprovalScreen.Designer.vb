<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BloodRequestApprovalScreen
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
        Me.RequestDataGridView = New System.Windows.Forms.DataGridView()
        Me.ApproveButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.DisapproveButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.backBtn = New Bunifu.Framework.UI.BunifuImageButton()
        CType(Me.RequestDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'RequestDataGridView
        '
        Me.RequestDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RequestDataGridView.Location = New System.Drawing.Point(86, 113)
        Me.RequestDataGridView.Name = "RequestDataGridView"
        Me.RequestDataGridView.Size = New System.Drawing.Size(871, 476)
        Me.RequestDataGridView.TabIndex = 5
        '
        'ApproveButton
        '
        Me.ApproveButton.Activecolor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ApproveButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ApproveButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ApproveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ApproveButton.BorderRadius = 0
        Me.ApproveButton.ButtonText = "Approve"
        Me.ApproveButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ApproveButton.DisabledColor = System.Drawing.Color.Gray
        Me.ApproveButton.Enabled = False
        Me.ApproveButton.Iconcolor = System.Drawing.Color.Transparent
        Me.ApproveButton.Iconimage = Nothing
        Me.ApproveButton.Iconimage_right = Nothing
        Me.ApproveButton.Iconimage_right_Selected = Nothing
        Me.ApproveButton.Iconimage_Selected = Nothing
        Me.ApproveButton.IconMarginLeft = 0
        Me.ApproveButton.IconMarginRight = 0
        Me.ApproveButton.IconRightVisible = True
        Me.ApproveButton.IconRightZoom = 0R
        Me.ApproveButton.IconVisible = True
        Me.ApproveButton.IconZoom = 90.0R
        Me.ApproveButton.IsTab = False
        Me.ApproveButton.Location = New System.Drawing.Point(638, 42)
        Me.ApproveButton.Name = "ApproveButton"
        Me.ApproveButton.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ApproveButton.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.ApproveButton.OnHoverTextColor = System.Drawing.Color.Black
        Me.ApproveButton.selected = False
        Me.ApproveButton.Size = New System.Drawing.Size(152, 32)
        Me.ApproveButton.TabIndex = 66
        Me.ApproveButton.Text = "Approve"
        Me.ApproveButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ApproveButton.Textcolor = System.Drawing.Color.Black
        Me.ApproveButton.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'DisapproveButton
        '
        Me.DisapproveButton.Activecolor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.DisapproveButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DisapproveButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.DisapproveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DisapproveButton.BorderRadius = 0
        Me.DisapproveButton.ButtonText = "Disapprove"
        Me.DisapproveButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DisapproveButton.DisabledColor = System.Drawing.Color.Gray
        Me.DisapproveButton.Enabled = False
        Me.DisapproveButton.Iconcolor = System.Drawing.Color.Transparent
        Me.DisapproveButton.Iconimage = Nothing
        Me.DisapproveButton.Iconimage_right = Nothing
        Me.DisapproveButton.Iconimage_right_Selected = Nothing
        Me.DisapproveButton.Iconimage_Selected = Nothing
        Me.DisapproveButton.IconMarginLeft = 0
        Me.DisapproveButton.IconMarginRight = 0
        Me.DisapproveButton.IconRightVisible = True
        Me.DisapproveButton.IconRightZoom = 0R
        Me.DisapproveButton.IconVisible = True
        Me.DisapproveButton.IconZoom = 90.0R
        Me.DisapproveButton.IsTab = False
        Me.DisapproveButton.Location = New System.Drawing.Point(805, 42)
        Me.DisapproveButton.Name = "DisapproveButton"
        Me.DisapproveButton.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.DisapproveButton.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.DisapproveButton.OnHoverTextColor = System.Drawing.Color.Black
        Me.DisapproveButton.selected = False
        Me.DisapproveButton.Size = New System.Drawing.Size(152, 32)
        Me.DisapproveButton.TabIndex = 67
        Me.DisapproveButton.Text = "Disapprove"
        Me.DisapproveButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DisapproveButton.Textcolor = System.Drawing.Color.Black
        Me.DisapproveButton.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.backBtn.TabIndex = 4
        Me.backBtn.TabStop = False
        Me.backBtn.Zoom = 10
        '
        'BloodRequestApprovalScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 635)
        Me.Controls.Add(Me.DisapproveButton)
        Me.Controls.Add(Me.ApproveButton)
        Me.Controls.Add(Me.RequestDataGridView)
        Me.Controls.Add(Me.backBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BloodRequestApprovalScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BloodRequestApprovalScreen"
        CType(Me.RequestDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.backBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents backBtn As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BackElipse As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents RequestDataGridView As DataGridView
    Friend WithEvents ApproveButton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents DisapproveButton As Bunifu.Framework.UI.BunifuFlatButton
End Class
