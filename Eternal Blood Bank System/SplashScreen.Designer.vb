<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreen))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LoadTxt = New System.Windows.Forms.Label()
        Me.SplashScreenBar = New Bunifu.Framework.UI.BunifuProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SplashScreenCorners = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(197, 86)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(617, 307)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'LoadTxt
        '
        Me.LoadTxt.AutoSize = True
        Me.LoadTxt.BackColor = System.Drawing.Color.Transparent
        Me.LoadTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadTxt.ForeColor = System.Drawing.Color.White
        Me.LoadTxt.Location = New System.Drawing.Point(449, 466)
        Me.LoadTxt.Name = "LoadTxt"
        Me.LoadTxt.Size = New System.Drawing.Size(123, 24)
        Me.LoadTxt.TabIndex = 1
        Me.LoadTxt.Text = "Just A Minute"
        '
        'SplashScreenBar
        '
        Me.SplashScreenBar.BackColor = System.Drawing.Color.White
        Me.SplashScreenBar.BorderRadius = 5
        Me.SplashScreenBar.Location = New System.Drawing.Point(226, 431)
        Me.SplashScreenBar.MaximumValue = 100
        Me.SplashScreenBar.Name = "SplashScreenBar"
        Me.SplashScreenBar.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.SplashScreenBar.Size = New System.Drawing.Size(545, 19)
        Me.SplashScreenBar.TabIndex = 2
        Me.SplashScreenBar.Value = 0
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'SplashScreenCorners
        '
        Me.SplashScreenCorners.ElipseRadius = 20
        Me.SplashScreenCorners.TargetControl = Me
        '
        'SplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(980, 625)
        Me.Controls.Add(Me.SplashScreenBar)
        Me.Controls.Add(Me.LoadTxt)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SplashScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LoadTxt As Label
    Friend WithEvents SplashScreenBar As Bunifu.Framework.UI.BunifuProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents SplashScreenCorners As Bunifu.Framework.UI.BunifuElipse
End Class
