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
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.SuspendLayout()
        '
        'SignUpCorners
        '
        Me.SignUpCorners.ElipseRadius = 20
        Me.SignUpCorners.TargetControl = Me
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
        Me.BunifuGradientPanel1.TabIndex = 9
        '
        'SignUpScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(980, 625)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SignUpScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SignUpScreen"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SignUpCorners As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
End Class
