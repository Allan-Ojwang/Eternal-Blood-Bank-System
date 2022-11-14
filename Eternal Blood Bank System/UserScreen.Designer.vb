<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserScreen))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.donateToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.requestToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.scheduleToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.logOutToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.closeToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BunifuGradientPanel2 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuCustomLabel23 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.Black
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.donateToolStripButton, Me.requestToolStripButton, Me.scheduleToolStripButton, Me.logOutToolStripButton, Me.closeToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 73)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(94, 522)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'donateToolStripButton
        '
        Me.donateToolStripButton.ForeColor = System.Drawing.Color.White
        Me.donateToolStripButton.Image = Global.Eternal_Blood_Bank_System.My.Resources.Resources.donate
        Me.donateToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.donateToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.donateToolStripButton.Margin = New System.Windows.Forms.Padding(0, 20, 0, 0)
        Me.donateToolStripButton.Name = "donateToolStripButton"
        Me.donateToolStripButton.Size = New System.Drawing.Size(92, 79)
        Me.donateToolStripButton.Text = "Donate"
        Me.donateToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.donateToolStripButton.ToolTipText = "Book"
        '
        'requestToolStripButton
        '
        Me.requestToolStripButton.ForeColor = System.Drawing.Color.White
        Me.requestToolStripButton.Image = Global.Eternal_Blood_Bank_System.My.Resources.Resources.request
        Me.requestToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.requestToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.requestToolStripButton.Margin = New System.Windows.Forms.Padding(0, 20, 0, 0)
        Me.requestToolStripButton.Name = "requestToolStripButton"
        Me.requestToolStripButton.Size = New System.Drawing.Size(92, 79)
        Me.requestToolStripButton.Text = "Request"
        Me.requestToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.requestToolStripButton.ToolTipText = "Book"
        '
        'scheduleToolStripButton
        '
        Me.scheduleToolStripButton.ForeColor = System.Drawing.Color.White
        Me.scheduleToolStripButton.Image = Global.Eternal_Blood_Bank_System.My.Resources.Resources.schedule
        Me.scheduleToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.scheduleToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.scheduleToolStripButton.Margin = New System.Windows.Forms.Padding(0, 20, 0, 0)
        Me.scheduleToolStripButton.Name = "scheduleToolStripButton"
        Me.scheduleToolStripButton.Size = New System.Drawing.Size(92, 79)
        Me.scheduleToolStripButton.Text = "Schedule"
        Me.scheduleToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.scheduleToolStripButton.ToolTipText = "Book"
        '
        'logOutToolStripButton
        '
        Me.logOutToolStripButton.ForeColor = System.Drawing.Color.White
        Me.logOutToolStripButton.Image = Global.Eternal_Blood_Bank_System.My.Resources.Resources.log_out
        Me.logOutToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.logOutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.logOutToolStripButton.Margin = New System.Windows.Forms.Padding(0, 20, 0, 0)
        Me.logOutToolStripButton.Name = "logOutToolStripButton"
        Me.logOutToolStripButton.Size = New System.Drawing.Size(92, 69)
        Me.logOutToolStripButton.Text = "Log Out"
        Me.logOutToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.logOutToolStripButton.ToolTipText = "Book"
        '
        'closeToolStripButton
        '
        Me.closeToolStripButton.ForeColor = System.Drawing.Color.White
        Me.closeToolStripButton.Image = Global.Eternal_Blood_Bank_System.My.Resources.Resources._exit
        Me.closeToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.closeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.closeToolStripButton.Margin = New System.Windows.Forms.Padding(0, 20, 0, 0)
        Me.closeToolStripButton.Name = "closeToolStripButton"
        Me.closeToolStripButton.Size = New System.Drawing.Size(92, 69)
        Me.closeToolStripButton.Text = "Close"
        Me.closeToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.closeToolStripButton.ToolTipText = "Book"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel2)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 595)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1020, 40)
        Me.Panel1.TabIndex = 5
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(541, 14)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(182, 16)
        Me.BunifuCustomLabel2.TabIndex = 1
        Me.BunifuCustomLabel2.Text = "Developed By - Allan Ojwang"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(285, 14)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(218, 16)
        Me.BunifuCustomLabel1.TabIndex = 0
        Me.BunifuCustomLabel1.Text = "Eternal Blood Management System"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(272, 425)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(563, 33)
        Me.BunifuCustomLabel3.TabIndex = 7
        Me.BunifuCustomLabel3.Text = "You don't have to be a doctor to save lives"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.Eternal_Blood_Bank_System.My.Resources.Resources.kisspng_blood_donation_blood_bank_charitable_organization_vector_blood_5a8769b794d4e3_2969423515188238636096
        Me.PictureBox2.Location = New System.Drawing.Point(818, 461)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(202, 134)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'BunifuGradientPanel2
        '
        Me.BunifuGradientPanel2.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel2.Controls.Add(Me.BunifuCustomLabel23)
        Me.BunifuGradientPanel2.Controls.Add(Me.PictureBox1)
        Me.BunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.White
        Me.BunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel2.GradientTopRight = System.Drawing.Color.White
        Me.BunifuGradientPanel2.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel2.Name = "BunifuGradientPanel2"
        Me.BunifuGradientPanel2.Quality = 10
        Me.BunifuGradientPanel2.Size = New System.Drawing.Size(1020, 73)
        Me.BunifuGradientPanel2.TabIndex = 4
        '
        'BunifuCustomLabel23
        '
        Me.BunifuCustomLabel23.AutoSize = True
        Me.BunifuCustomLabel23.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel23.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel23.Location = New System.Drawing.Point(222, 9)
        Me.BunifuCustomLabel23.Name = "BunifuCustomLabel23"
        Me.BunifuCustomLabel23.Size = New System.Drawing.Size(633, 55)
        Me.BunifuCustomLabel23.TabIndex = 4
        Me.BunifuCustomLabel23.Text = "Eternal Blood Bank System"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PictureBox1.Image = Global.Eternal_Blood_Bank_System.My.Resources.Resources.sing_logo
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 73)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Eternal_Blood_Bank_System.My.Resources.Resources.kisspng_blood_donation_blood_bank_vector_hand_painted_drops_of_blood_heartbeat_5a82e063806694_2535243615185265635259
        Me.PictureBox3.Location = New System.Drawing.Point(344, 145)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(422, 253)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'UserScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 635)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BunifuGradientPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UserScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UserScreen"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel2.ResumeLayout(False)
        Me.BunifuGradientPanel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuGradientPanel2 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents donateToolStripButton As ToolStripButton
    Friend WithEvents requestToolStripButton As ToolStripButton
    Friend WithEvents scheduleToolStripButton As ToolStripButton
    Friend WithEvents logOutToolStripButton As ToolStripButton
    Friend WithEvents closeToolStripButton As ToolStripButton
    Friend WithEvents BunifuCustomLabel23 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
