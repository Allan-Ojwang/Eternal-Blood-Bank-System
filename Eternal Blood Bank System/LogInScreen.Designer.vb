<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogInScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogInScreen))
        Me.LogInCorners = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.UsernameTextbox = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PasswordTextbox = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.LogInButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.SignUpBtn = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogInCorners
        '
        Me.LogInCorners.ElipseRadius = 20
        Me.LogInCorners.TargetControl = Me
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, 147)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(489, 313)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'UsernameTextbox
        '
        Me.UsernameTextbox.BackColor = System.Drawing.Color.White
        Me.UsernameTextbox.BorderColorFocused = System.Drawing.Color.Blue
        Me.UsernameTextbox.BorderColorIdle = System.Drawing.Color.Transparent
        Me.UsernameTextbox.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.UsernameTextbox.BorderThickness = 3
        Me.UsernameTextbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UsernameTextbox.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.UsernameTextbox.ForeColor = System.Drawing.Color.White
        Me.UsernameTextbox.isPassword = False
        Me.UsernameTextbox.Location = New System.Drawing.Point(566, 189)
        Me.UsernameTextbox.Margin = New System.Windows.Forms.Padding(4)
        Me.UsernameTextbox.Name = "UsernameTextbox"
        Me.UsernameTextbox.Size = New System.Drawing.Size(322, 40)
        Me.UsernameTextbox.TabIndex = 2
        Me.UsernameTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(561, 137)
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
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(561, 279)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(128, 29)
        Me.BunifuCustomLabel2.TabIndex = 5
        Me.BunifuCustomLabel2.Text = "Password"
        '
        'PasswordTextbox
        '
        Me.PasswordTextbox.BackColor = System.Drawing.Color.White
        Me.PasswordTextbox.BorderColorFocused = System.Drawing.Color.Blue
        Me.PasswordTextbox.BorderColorIdle = System.Drawing.Color.Transparent
        Me.PasswordTextbox.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.PasswordTextbox.BorderThickness = 3
        Me.PasswordTextbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PasswordTextbox.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.PasswordTextbox.ForeColor = System.Drawing.Color.White
        Me.PasswordTextbox.isPassword = False
        Me.PasswordTextbox.Location = New System.Drawing.Point(566, 331)
        Me.PasswordTextbox.Margin = New System.Windows.Forms.Padding(4)
        Me.PasswordTextbox.Name = "PasswordTextbox"
        Me.PasswordTextbox.Size = New System.Drawing.Size(322, 40)
        Me.PasswordTextbox.TabIndex = 4
        Me.PasswordTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.LogInButton.Location = New System.Drawing.Point(566, 429)
        Me.LogInButton.Name = "LogInButton"
        Me.LogInButton.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.LogInButton.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.LogInButton.OnHoverTextColor = System.Drawing.Color.Black
        Me.LogInButton.selected = False
        Me.LogInButton.Size = New System.Drawing.Size(322, 31)
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
        Me.SignUpBtn.Location = New System.Drawing.Point(583, 498)
        Me.SignUpBtn.Name = "SignUpBtn"
        Me.SignUpBtn.Size = New System.Drawing.Size(292, 22)
        Me.SignUpBtn.TabIndex = 7
        Me.SignUpBtn.Text = "Dont't have an account? Click Here." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
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
        'LogInScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(980, 625)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.Controls.Add(Me.SignUpBtn)
        Me.Controls.Add(Me.LogInButton)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.PasswordTextbox)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.UsernameTextbox)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LogInScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LogInCorners As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents UsernameTextbox As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents LogInButton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PasswordTextbox As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents SignUpBtn As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
End Class
