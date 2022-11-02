<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUpScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignUpScreen))
        Me.SignUpCorners = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.SignUpBtn = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.LogInButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.DOB = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.FirstNameTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.NumberTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.UsernameTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.PasswordTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.EmailTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.LastNameTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.LevelCb = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.closeBtn = New Bunifu.Framework.UI.BunifuImageButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.closeBtn, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(494, 115)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(126, 25)
        Me.BunifuCustomLabel1.TabIndex = 12
        Me.BunifuCustomLabel1.Text = "First Name"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(821, 115)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(124, 25)
        Me.BunifuCustomLabel2.TabIndex = 14
        Me.BunifuCustomLabel2.Text = "Last Name"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(821, 204)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(167, 25)
        Me.BunifuCustomLabel3.TabIndex = 18
        Me.BunifuCustomLabel3.Text = "Phone Number"
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(494, 204)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(70, 25)
        Me.BunifuCustomLabel4.TabIndex = 16
        Me.BunifuCustomLabel4.Text = "Email"
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(821, 378)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(114, 25)
        Me.BunifuCustomLabel5.TabIndex = 26
        Me.BunifuCustomLabel5.Text = "Password"
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(494, 378)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(118, 25)
        Me.BunifuCustomLabel6.TabIndex = 24
        Me.BunifuCustomLabel6.Text = "Username"
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(821, 296)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(69, 25)
        Me.BunifuCustomLabel7.TabIndex = 22
        Me.BunifuCustomLabel7.Text = "Level"
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(494, 296)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(148, 25)
        Me.BunifuCustomLabel8.TabIndex = 20
        Me.BunifuCustomLabel8.Text = "Date Of Birth"
        '
        'SignUpBtn
        '
        Me.SignUpBtn.AutoSize = True
        Me.SignUpBtn.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignUpBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.SignUpBtn.Location = New System.Drawing.Point(637, 555)
        Me.SignUpBtn.Name = "SignUpBtn"
        Me.SignUpBtn.Size = New System.Drawing.Size(310, 22)
        Me.SignUpBtn.TabIndex = 28
        Me.SignUpBtn.Text = "Don you have an account? Click Here." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
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
        Me.LogInButton.ButtonText = "Sign Up"
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
        Me.LogInButton.Location = New System.Drawing.Point(633, 490)
        Me.LogInButton.Name = "LogInButton"
        Me.LogInButton.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.LogInButton.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.LogInButton.OnHoverTextColor = System.Drawing.Color.Black
        Me.LogInButton.selected = False
        Me.LogInButton.Size = New System.Drawing.Size(331, 31)
        Me.LogInButton.TabIndex = 27
        Me.LogInButton.Text = "Sign Up"
        Me.LogInButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LogInButton.Textcolor = System.Drawing.Color.Black
        Me.LogInButton.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'DOB
        '
        Me.DOB.BackColor = System.Drawing.Color.White
        Me.DOB.BorderRadius = 0
        Me.DOB.ForeColor = System.Drawing.Color.Black
        Me.DOB.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.DOB.FormatCustom = Nothing
        Me.DOB.Location = New System.Drawing.Point(499, 341)
        Me.DOB.Name = "DOB"
        Me.DOB.Size = New System.Drawing.Size(264, 24)
        Me.DOB.TabIndex = 29
        Me.DOB.Value = New Date(2022, 10, 22, 1, 46, 4, 27)
        '
        'FirstNameTb
        '
        Me.FirstNameTb.BackColor = System.Drawing.Color.Black
        Me.FirstNameTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FirstNameTb.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNameTb.ForeColor = System.Drawing.Color.White
        Me.FirstNameTb.HintForeColor = System.Drawing.Color.White
        Me.FirstNameTb.HintText = "Enter Your First Name"
        Me.FirstNameTb.isPassword = False
        Me.FirstNameTb.LineFocusedColor = System.Drawing.Color.IndianRed
        Me.FirstNameTb.LineIdleColor = System.Drawing.Color.IndianRed
        Me.FirstNameTb.LineMouseHoverColor = System.Drawing.Color.IndianRed
        Me.FirstNameTb.LineThickness = 4
        Me.FirstNameTb.Location = New System.Drawing.Point(499, 155)
        Me.FirstNameTb.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.FirstNameTb.Name = "FirstNameTb"
        Me.FirstNameTb.Size = New System.Drawing.Size(264, 29)
        Me.FirstNameTb.TabIndex = 30
        Me.FirstNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'NumberTb
        '
        Me.NumberTb.BackColor = System.Drawing.Color.Black
        Me.NumberTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NumberTb.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberTb.ForeColor = System.Drawing.Color.White
        Me.NumberTb.HintForeColor = System.Drawing.Color.White
        Me.NumberTb.HintText = "Enter Your Phone Number"
        Me.NumberTb.isPassword = False
        Me.NumberTb.LineFocusedColor = System.Drawing.Color.IndianRed
        Me.NumberTb.LineIdleColor = System.Drawing.Color.IndianRed
        Me.NumberTb.LineMouseHoverColor = System.Drawing.Color.IndianRed
        Me.NumberTb.LineThickness = 4
        Me.NumberTb.Location = New System.Drawing.Point(826, 248)
        Me.NumberTb.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.NumberTb.Name = "NumberTb"
        Me.NumberTb.Size = New System.Drawing.Size(264, 29)
        Me.NumberTb.TabIndex = 31
        Me.NumberTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.UsernameTb.Location = New System.Drawing.Point(499, 416)
        Me.UsernameTb.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.UsernameTb.Name = "UsernameTb"
        Me.UsernameTb.Size = New System.Drawing.Size(264, 29)
        Me.UsernameTb.TabIndex = 32
        Me.UsernameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.PasswordTb.Location = New System.Drawing.Point(826, 416)
        Me.PasswordTb.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.PasswordTb.Name = "PasswordTb"
        Me.PasswordTb.Size = New System.Drawing.Size(264, 29)
        Me.PasswordTb.TabIndex = 33
        Me.PasswordTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'EmailTb
        '
        Me.EmailTb.BackColor = System.Drawing.Color.Black
        Me.EmailTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.EmailTb.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTb.ForeColor = System.Drawing.Color.White
        Me.EmailTb.HintForeColor = System.Drawing.Color.White
        Me.EmailTb.HintText = "Enter Your Email"
        Me.EmailTb.isPassword = False
        Me.EmailTb.LineFocusedColor = System.Drawing.Color.IndianRed
        Me.EmailTb.LineIdleColor = System.Drawing.Color.IndianRed
        Me.EmailTb.LineMouseHoverColor = System.Drawing.Color.IndianRed
        Me.EmailTb.LineThickness = 4
        Me.EmailTb.Location = New System.Drawing.Point(499, 248)
        Me.EmailTb.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.EmailTb.Name = "EmailTb"
        Me.EmailTb.Size = New System.Drawing.Size(264, 29)
        Me.EmailTb.TabIndex = 34
        Me.EmailTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'LastNameTb
        '
        Me.LastNameTb.BackColor = System.Drawing.Color.Black
        Me.LastNameTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.LastNameTb.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastNameTb.ForeColor = System.Drawing.Color.White
        Me.LastNameTb.HintForeColor = System.Drawing.Color.White
        Me.LastNameTb.HintText = "Enter Your Last Name"
        Me.LastNameTb.isPassword = False
        Me.LastNameTb.LineFocusedColor = System.Drawing.Color.IndianRed
        Me.LastNameTb.LineIdleColor = System.Drawing.Color.IndianRed
        Me.LastNameTb.LineMouseHoverColor = System.Drawing.Color.IndianRed
        Me.LastNameTb.LineThickness = 4
        Me.LastNameTb.Location = New System.Drawing.Point(826, 155)
        Me.LastNameTb.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.LastNameTb.Name = "LastNameTb"
        Me.LastNameTb.Size = New System.Drawing.Size(264, 29)
        Me.LastNameTb.TabIndex = 35
        Me.LastNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'LevelCb
        '
        Me.LevelCb.FormattingEnabled = True
        Me.LevelCb.Items.AddRange(New Object() {"Admin", "Donor"})
        Me.LevelCb.Location = New System.Drawing.Point(826, 341)
        Me.LevelCb.Name = "LevelCb"
        Me.LevelCb.Size = New System.Drawing.Size(264, 21)
        Me.LevelCb.TabIndex = 36
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Eternal_Blood_Bank_System.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(0, 124)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(471, 307)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
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
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(1144, 40)
        Me.BunifuGradientPanel1.TabIndex = 9
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
        Me.closeBtn.TabIndex = 37
        Me.closeBtn.TabStop = False
        Me.closeBtn.Zoom = 10
        '
        'SignUpScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1144, 625)
        Me.Controls.Add(Me.LevelCb)
        Me.Controls.Add(Me.LastNameTb)
        Me.Controls.Add(Me.EmailTb)
        Me.Controls.Add(Me.PasswordTb)
        Me.Controls.Add(Me.UsernameTb)
        Me.Controls.Add(Me.NumberTb)
        Me.Controls.Add(Me.FirstNameTb)
        Me.Controls.Add(Me.DOB)
        Me.Controls.Add(Me.SignUpBtn)
        Me.Controls.Add(Me.LogInButton)
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Controls.Add(Me.BunifuCustomLabel6)
        Me.Controls.Add(Me.BunifuCustomLabel7)
        Me.Controls.Add(Me.BunifuCustomLabel8)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SignUpScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        CType(Me.closeBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SignUpCorners As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents SignUpBtn As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents LogInButton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents FirstNameTb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents DOB As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents LastNameTb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents EmailTb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents PasswordTb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents UsernameTb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents NumberTb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents LevelCb As ComboBox
    Friend WithEvents closeBtn As Bunifu.Framework.UI.BunifuImageButton
End Class
