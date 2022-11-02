<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminScreen))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.AcceptToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.logOutToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.closeToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.BunifuGradientPanel2 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.BunifuGradientPanel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuCards1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel2)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 585)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(980, 40)
        Me.Panel1.TabIndex = 2
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(642, 11)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(182, 16)
        Me.BunifuCustomLabel2.TabIndex = 1
        Me.BunifuCustomLabel2.Text = "Developed By - Allan Ojwang"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(386, 11)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(218, 16)
        Me.BunifuCustomLabel1.TabIndex = 0
        Me.BunifuCustomLabel1.Text = "Eternal Blood Management System"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.Black
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.AcceptToolStripButton, Me.logOutToolStripButton, Me.closeToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 73)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(94, 512)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton2.Image = Global.Eternal_Blood_Bank_System.My.Resources.Resources.sing_logo
        Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.ToolStripButton2.Size = New System.Drawing.Size(92, 93)
        Me.ToolStripButton2.Text = "Home"
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'AcceptToolStripButton
        '
        Me.AcceptToolStripButton.ForeColor = System.Drawing.Color.White
        Me.AcceptToolStripButton.Image = Global.Eternal_Blood_Bank_System.My.Resources.Resources.accept
        Me.AcceptToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AcceptToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AcceptToolStripButton.Name = "AcceptToolStripButton"
        Me.AcceptToolStripButton.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.AcceptToolStripButton.Size = New System.Drawing.Size(92, 79)
        Me.AcceptToolStripButton.Text = "Accept"
        Me.AcceptToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'logOutToolStripButton
        '
        Me.logOutToolStripButton.ForeColor = System.Drawing.Color.White
        Me.logOutToolStripButton.Image = Global.Eternal_Blood_Bank_System.My.Resources.Resources.log_out
        Me.logOutToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.logOutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.logOutToolStripButton.Name = "logOutToolStripButton"
        Me.logOutToolStripButton.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.logOutToolStripButton.Size = New System.Drawing.Size(92, 79)
        Me.logOutToolStripButton.Text = "Log Out"
        Me.logOutToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'closeToolStripButton
        '
        Me.closeToolStripButton.ForeColor = System.Drawing.Color.White
        Me.closeToolStripButton.Image = Global.Eternal_Blood_Bank_System.My.Resources.Resources._exit
        Me.closeToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.closeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.closeToolStripButton.Name = "closeToolStripButton"
        Me.closeToolStripButton.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.closeToolStripButton.Size = New System.Drawing.Size(92, 79)
        Me.closeToolStripButton.Text = "Close"
        Me.closeToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BunifuGradientPanel2
        '
        Me.BunifuGradientPanel2.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel2.Controls.Add(Me.PictureBox1)
        Me.BunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.White
        Me.BunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel2.GradientTopRight = System.Drawing.Color.White
        Me.BunifuGradientPanel2.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel2.Name = "BunifuGradientPanel2"
        Me.BunifuGradientPanel2.Quality = 10
        Me.BunifuGradientPanel2.Size = New System.Drawing.Size(980, 73)
        Me.BunifuGradientPanel2.TabIndex = 1
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
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.White
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.Tomato
        Me.BunifuCards1.Controls.Add(Me.BunifuCustomLabel3)
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(303, 274)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(250, 115)
        Me.BunifuCards1.TabIndex = 4
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(72, 49)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(104, 13)
        Me.BunifuCustomLabel3.TabIndex = 1
        Me.BunifuCustomLabel3.Text = "BunifuCustomLabel3"
        '
        'AdminScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(980, 625)
        Me.Controls.Add(Me.BunifuCards1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BunifuGradientPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminScreen"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.BunifuGradientPanel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuCards1.ResumeLayout(False)
        Me.BunifuCards1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuGradientPanel2 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents AcceptToolStripButton As ToolStripButton
    Friend WithEvents logOutToolStripButton As ToolStripButton
    Friend WithEvents closeToolStripButton As ToolStripButton
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
End Class
