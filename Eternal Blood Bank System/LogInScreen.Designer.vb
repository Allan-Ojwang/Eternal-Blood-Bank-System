<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LogInScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogInScreen))
        Me.LogInCorners = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.LogInButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.SignUpBtn = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PasswordTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.UsernameTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.closeBtn = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.closeBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogInCorners
        '
        Me.LogInCorners.ElipseRadius = 20
        Me.LogInCorners.TargetControl = Me
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(634, 128)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(132, 29)
        Me.BunifuCustomLabel1.TabIndex = 3
        Me.BunifuCustomLabel1.Text = "Username"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(634, 270)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(128, 29)
        Me.BunifuCustomLabel2.TabIndex = 5
        Me.BunifuCustomLabel2.Text = "Password"
        '
        'LogInButton
        '
        Me.LogInButton.Activecolor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.LogInButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LogInButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.LogInButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LogInButton.BorderRadius = 0
        Me.LogInButton.ButtonText = "Log In"
        Me.LogInButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogInButton.DisabledColor = System.Drawing.Color.Gray
        Me.LogInButton.Iconcolor = System.Drawing.Color.Transparent
        Me.LogInButton.Iconimage = Nothing
        Me.LogInButton.Iconimage_right = Nothing
        Me.LogInButton.Iconimage_right_Selected = Nothing
        Me.LogInButton.Iconimage_Selected = Nothing
        Me.LogInButton.IconMarginLeft = 0
        Me.LogInButton.IconMarginRight = 0
        Me.LogInButton.IconRightVisible = True
        Me.LogInButton.IconRightZoom = 0R
        Me.LogInButton.IconVisible = True
        Me.LogInButton.IconZoom = 90.0R
        Me.LogInButton.IsTab = False
        Me.LogInButton.Location = New System.Drawing.Point(639, 420)
        Me.LogInButton.Name = "LogInButton"
        Me.LogInButton.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.LogInButton.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.LogInButton.OnHoverTextColor = System.Drawing.Color.Black
        Me.LogInButton.selected = False
        Me.LogInButton.Size = New System.Drawing.Size(167, 31)
        Me.LogInButton.TabIndex = 6
        Me.LogInButton.Text = "Log In"
        Me.LogInButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LogInButton.Textcolor = System.Drawing.Color.Black
        Me.LogInButton.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'SignUpBtn
        '
        Me.SignUpBtn.AutoSize = True
        Me.SignUpBtn.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignUpBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.SignUpBtn.Location = New System.Drawing.Point(656, 489)
        Me.SignUpBtn.Name = "SignUpBtn"
        Me.SignUpBtn.Size = New System.Drawing.Size(292, 22)
        Me.SignUpBtn.TabIndex = 7
        Me.SignUpBtn.Text = "Dont't have an account? Click Here." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PasswordTb
        '
        Me.PasswordTb.BackColor = System.Drawing.Color.Black
        Me.PasswordTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PasswordTb.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTb.ForeColor = System.Drawing.Color.White
        Me.PasswordTb.HintForeColor = System.Drawing.Color.White
        Me.PasswordTb.HintText = "Enter Your Password"
        Me.PasswordTb.isPassword = False
        Me.PasswordTb.LineFocusedColor = System.Drawing.Color.IndianRed
        Me.PasswordTb.LineIdleColor = System.Drawing.Color.IndianRed
        Me.PasswordTb.LineMouseHoverColor = System.Drawing.Color.IndianRed
        Me.PasswordTb.LineThickness = 4
        Me.PasswordTb.Location = New System.Drawing.Point(639, 329)
        Me.PasswordTb.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.PasswordTb.Name = "PasswordTb"
        Me.PasswordTb.Size = New System.Drawing.Size(322, 40)
        Me.PasswordTb.TabIndex = 35
        Me.PasswordTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'UsernameTb
        '
        Me.UsernameTb.BackColor = System.Drawing.Color.Black
        Me.UsernameTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UsernameTb.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTb.ForeColor = System.Drawing.Color.White
        Me.UsernameTb.HintForeColor = System.Drawing.Color.White
        Me.UsernameTb.HintText = "Enter Your Username"
        Me.UsernameTb.isPassword = False
        Me.UsernameTb.LineFocusedColor = System.Drawing.Color.IndianRed
        Me.UsernameTb.LineIdleColor = System.Drawing.Color.IndianRed
        Me.UsernameTb.LineMouseHoverColor = System.Drawing.Color.IndianRed
        Me.UsernameTb.LineThickness = 4
        Me.UsernameTb.Location = New System.Drawing.Point(639, 186)
        Me.UsernameTb.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.UsernameTb.Name = "UsernameTb"
        Me.UsernameTb.Size = New System.Drawing.Size(322, 40)
        Me.UsernameTb.TabIndex = 34
        Me.UsernameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'closeBtn
        '
        Me.closeBtn.BackColor = System.Drawing.Color.Transparent
        Me.closeBtn.Image = CType(resources.GetObject("closeBtn.Image"), System.Drawing.Image)
        Me.closeBtn.ImageActive = Nothing
        Me.closeBtn.Location = New System.Drawing.Point(1093, 7)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(30, 30)
        Me.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.closeBtn.TabIndex = 36
        Me.closeBtn.TabStop = False
        Me.closeBtn.Zoom = 10
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.closeBtn)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(980, 40)
        Me.BunifuGradientPanel1.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Eternal_Blood_Bank_System.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(1, 147)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(489, 313)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'LogInScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(980, 625)
        Me.Controls.Add(Me.PasswordTb)
        Me.Controls.Add(Me.UsernameTb)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.Controls.Add(Me.SignUpBtn)
        Me.Controls.Add(Me.LogInButton)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LogInScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.closeBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LogInCorners As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents LogInButton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents SignUpBtn As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents PasswordTb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents UsernameTb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents closeBtn As Bunifu.Framework.UI.BunifuImageButton
End Class
