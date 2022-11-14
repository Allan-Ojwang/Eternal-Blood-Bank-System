<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reports
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reports))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BackElipse = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.backBtn = New Bunifu.Framework.UI.BunifuImageButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Donation = New System.Windows.Forms.TabPage()
        Me.DonationPrintButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.DonationReportDataGridView = New System.Windows.Forms.DataGridView()
        Me.BloodRequest = New System.Windows.Forms.TabPage()
        Me.RequestPrintButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.RequestReportDataGridView = New System.Windows.Forms.DataGridView()
        Me.AppointmentReport = New System.Windows.Forms.TabPage()
        Me.AppointmentPrintButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.AppointmentReportDataGridView = New System.Windows.Forms.DataGridView()
        Me.DonationDoc = New System.Drawing.Printing.PrintDocument()
        Me.RequestDoc = New System.Drawing.Printing.PrintDocument()
        Me.AppointmentDoc = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.backBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.Donation.SuspendLayout()
        CType(Me.DonationReportDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BloodRequest.SuspendLayout()
        CType(Me.RequestReportDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AppointmentReport.SuspendLayout()
        CType(Me.AppointmentReportDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.backBtn.TabIndex = 2
        Me.backBtn.TabStop = False
        Me.backBtn.Zoom = 10
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Donation)
        Me.TabControl1.Controls.Add(Me.BloodRequest)
        Me.TabControl1.Controls.Add(Me.AppointmentReport)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(85, 55)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(949, 580)
        Me.TabControl1.TabIndex = 3
        '
        'Donation
        '
        Me.Donation.BackColor = System.Drawing.SystemColors.Control
        Me.Donation.Controls.Add(Me.DonationPrintButton)
        Me.Donation.Controls.Add(Me.DonationReportDataGridView)
        Me.Donation.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Donation.Location = New System.Drawing.Point(4, 25)
        Me.Donation.Name = "Donation"
        Me.Donation.Padding = New System.Windows.Forms.Padding(3)
        Me.Donation.Size = New System.Drawing.Size(941, 551)
        Me.Donation.TabIndex = 0
        Me.Donation.Text = "Donation Report"
        '
        'DonationPrintButton
        '
        Me.DonationPrintButton.Activecolor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.DonationPrintButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DonationPrintButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.DonationPrintButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DonationPrintButton.BorderRadius = 0
        Me.DonationPrintButton.ButtonText = "PRINT"
        Me.DonationPrintButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DonationPrintButton.DisabledColor = System.Drawing.Color.Gray
        Me.DonationPrintButton.Iconcolor = System.Drawing.Color.Transparent
        Me.DonationPrintButton.Iconimage = Nothing
        Me.DonationPrintButton.Iconimage_right = Nothing
        Me.DonationPrintButton.Iconimage_right_Selected = Nothing
        Me.DonationPrintButton.Iconimage_Selected = Nothing
        Me.DonationPrintButton.IconMarginLeft = 0
        Me.DonationPrintButton.IconMarginRight = 0
        Me.DonationPrintButton.IconRightVisible = False
        Me.DonationPrintButton.IconRightZoom = 0R
        Me.DonationPrintButton.IconVisible = False
        Me.DonationPrintButton.IconZoom = 90.0R
        Me.DonationPrintButton.IsTab = False
        Me.DonationPrintButton.Location = New System.Drawing.Point(769, 9)
        Me.DonationPrintButton.Margin = New System.Windows.Forms.Padding(6)
        Me.DonationPrintButton.Name = "DonationPrintButton"
        Me.DonationPrintButton.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.DonationPrintButton.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.DonationPrintButton.OnHoverTextColor = System.Drawing.Color.Black
        Me.DonationPrintButton.selected = False
        Me.DonationPrintButton.Size = New System.Drawing.Size(150, 60)
        Me.DonationPrintButton.TabIndex = 86
        Me.DonationPrintButton.Text = "PRINT"
        Me.DonationPrintButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DonationPrintButton.Textcolor = System.Drawing.Color.Black
        Me.DonationPrintButton.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'DonationReportDataGridView
        '
        Me.DonationReportDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DonationReportDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DonationReportDataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DonationReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DonationReportDataGridView.Location = New System.Drawing.Point(15, 81)
        Me.DonationReportDataGridView.Name = "DonationReportDataGridView"
        Me.DonationReportDataGridView.Size = New System.Drawing.Size(910, 467)
        Me.DonationReportDataGridView.TabIndex = 57
        '
        'BloodRequest
        '
        Me.BloodRequest.BackColor = System.Drawing.SystemColors.Control
        Me.BloodRequest.Controls.Add(Me.RequestPrintButton)
        Me.BloodRequest.Controls.Add(Me.RequestReportDataGridView)
        Me.BloodRequest.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BloodRequest.Location = New System.Drawing.Point(4, 25)
        Me.BloodRequest.Name = "BloodRequest"
        Me.BloodRequest.Padding = New System.Windows.Forms.Padding(3)
        Me.BloodRequest.Size = New System.Drawing.Size(941, 551)
        Me.BloodRequest.TabIndex = 1
        Me.BloodRequest.Text = "Blood Request Report"
        '
        'RequestPrintButton
        '
        Me.RequestPrintButton.Activecolor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.RequestPrintButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RequestPrintButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.RequestPrintButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RequestPrintButton.BorderRadius = 0
        Me.RequestPrintButton.ButtonText = "PRINT"
        Me.RequestPrintButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RequestPrintButton.DisabledColor = System.Drawing.Color.Gray
        Me.RequestPrintButton.Iconcolor = System.Drawing.Color.Transparent
        Me.RequestPrintButton.Iconimage = Nothing
        Me.RequestPrintButton.Iconimage_right = Nothing
        Me.RequestPrintButton.Iconimage_right_Selected = Nothing
        Me.RequestPrintButton.Iconimage_Selected = Nothing
        Me.RequestPrintButton.IconMarginLeft = 0
        Me.RequestPrintButton.IconMarginRight = 0
        Me.RequestPrintButton.IconRightVisible = False
        Me.RequestPrintButton.IconRightZoom = 0R
        Me.RequestPrintButton.IconVisible = False
        Me.RequestPrintButton.IconZoom = 90.0R
        Me.RequestPrintButton.IsTab = False
        Me.RequestPrintButton.Location = New System.Drawing.Point(776, 11)
        Me.RequestPrintButton.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.RequestPrintButton.Name = "RequestPrintButton"
        Me.RequestPrintButton.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.RequestPrintButton.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.RequestPrintButton.OnHoverTextColor = System.Drawing.Color.Black
        Me.RequestPrintButton.selected = False
        Me.RequestPrintButton.Size = New System.Drawing.Size(150, 60)
        Me.RequestPrintButton.TabIndex = 87
        Me.RequestPrintButton.Text = "PRINT"
        Me.RequestPrintButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RequestPrintButton.Textcolor = System.Drawing.Color.Black
        Me.RequestPrintButton.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'RequestReportDataGridView
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RequestReportDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.RequestReportDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.RequestReportDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.RequestReportDataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.RequestReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RequestReportDataGridView.Location = New System.Drawing.Point(16, 81)
        Me.RequestReportDataGridView.Name = "RequestReportDataGridView"
        Me.RequestReportDataGridView.Size = New System.Drawing.Size(910, 467)
        Me.RequestReportDataGridView.TabIndex = 58
        '
        'AppointmentReport
        '
        Me.AppointmentReport.BackColor = System.Drawing.SystemColors.Control
        Me.AppointmentReport.Controls.Add(Me.AppointmentPrintButton)
        Me.AppointmentReport.Controls.Add(Me.AppointmentReportDataGridView)
        Me.AppointmentReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AppointmentReport.Location = New System.Drawing.Point(4, 25)
        Me.AppointmentReport.Name = "AppointmentReport"
        Me.AppointmentReport.Padding = New System.Windows.Forms.Padding(3)
        Me.AppointmentReport.Size = New System.Drawing.Size(941, 551)
        Me.AppointmentReport.TabIndex = 2
        Me.AppointmentReport.Text = "Appointment Report"
        '
        'AppointmentPrintButton
        '
        Me.AppointmentPrintButton.Activecolor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.AppointmentPrintButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AppointmentPrintButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.AppointmentPrintButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AppointmentPrintButton.BorderRadius = 0
        Me.AppointmentPrintButton.ButtonText = "PRINT"
        Me.AppointmentPrintButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AppointmentPrintButton.DisabledColor = System.Drawing.Color.Gray
        Me.AppointmentPrintButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AppointmentPrintButton.Iconcolor = System.Drawing.Color.Transparent
        Me.AppointmentPrintButton.Iconimage = Nothing
        Me.AppointmentPrintButton.Iconimage_right = Nothing
        Me.AppointmentPrintButton.Iconimage_right_Selected = Nothing
        Me.AppointmentPrintButton.Iconimage_Selected = Nothing
        Me.AppointmentPrintButton.IconMarginLeft = 0
        Me.AppointmentPrintButton.IconMarginRight = 0
        Me.AppointmentPrintButton.IconRightVisible = False
        Me.AppointmentPrintButton.IconRightZoom = 0R
        Me.AppointmentPrintButton.IconVisible = False
        Me.AppointmentPrintButton.IconZoom = 90.0R
        Me.AppointmentPrintButton.IsTab = False
        Me.AppointmentPrintButton.Location = New System.Drawing.Point(776, 9)
        Me.AppointmentPrintButton.Margin = New System.Windows.Forms.Padding(24, 20, 24, 20)
        Me.AppointmentPrintButton.Name = "AppointmentPrintButton"
        Me.AppointmentPrintButton.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.AppointmentPrintButton.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.AppointmentPrintButton.OnHoverTextColor = System.Drawing.Color.Black
        Me.AppointmentPrintButton.selected = False
        Me.AppointmentPrintButton.Size = New System.Drawing.Size(150, 60)
        Me.AppointmentPrintButton.TabIndex = 88
        Me.AppointmentPrintButton.Text = "PRINT"
        Me.AppointmentPrintButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AppointmentPrintButton.Textcolor = System.Drawing.Color.Black
        Me.AppointmentPrintButton.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'AppointmentReportDataGridView
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AppointmentReportDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.AppointmentReportDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.AppointmentReportDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.AppointmentReportDataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.AppointmentReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AppointmentReportDataGridView.Location = New System.Drawing.Point(16, 81)
        Me.AppointmentReportDataGridView.Name = "AppointmentReportDataGridView"
        Me.AppointmentReportDataGridView.Size = New System.Drawing.Size(910, 467)
        Me.AppointmentReportDataGridView.TabIndex = 59
        '
        'DonationDoc
        '
        '
        'RequestDoc
        '
        '
        'AppointmentDoc
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1099, 647)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.backBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Reports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reports"
        CType(Me.backBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.Donation.ResumeLayout(False)
        CType(Me.DonationReportDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BloodRequest.ResumeLayout(False)
        CType(Me.RequestReportDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AppointmentReport.ResumeLayout(False)
        CType(Me.AppointmentReportDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents backBtn As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BackElipse As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Donation As TabPage
    Friend WithEvents BloodRequest As TabPage
    Friend WithEvents AppointmentReport As TabPage
    Friend WithEvents DonationReportDataGridView As DataGridView
    Friend WithEvents RequestReportDataGridView As DataGridView
    Friend WithEvents AppointmentReportDataGridView As DataGridView
    Friend WithEvents DonationDoc As Printing.PrintDocument
    Friend WithEvents DonationPrintButton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents RequestDoc As Printing.PrintDocument
    Friend WithEvents AppointmentDoc As Printing.PrintDocument
    Friend WithEvents RequestPrintButton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents AppointmentPrintButton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
