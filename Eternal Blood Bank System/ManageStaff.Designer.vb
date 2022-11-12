<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManageStaff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageStaff))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BackElipse = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.backBtn = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.FullNameTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.StaffIDTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.UsernameTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PasswordTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.StaffDataGridView = New System.Windows.Forms.DataGridView()
        Me.AddButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.UpdateButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.DeleteButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.NumberTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.GenderCb = New System.Windows.Forms.ComboBox()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        CType(Me.backBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.backBtn.Image = CType(resources.GetObject("backBtn.Image"), System.Drawing.Image)
        Me.backBtn.ImageActive = Nothing
        Me.backBtn.Location = New System.Drawing.Point(12, 12)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(52, 52)
        Me.backBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.backBtn.TabIndex = 3
        Me.backBtn.TabStop = False
        Me.backBtn.Zoom = 10
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'FullNameTb
        '
        Me.FullNameTb.BackColor = System.Drawing.SystemColors.Control
        Me.FullNameTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FullNameTb.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FullNameTb.ForeColor = System.Drawing.Color.Black
        Me.FullNameTb.HintForeColor = System.Drawing.Color.Black
        Me.FullNameTb.HintText = "Enter Full Name"
        Me.FullNameTb.isPassword = False
        Me.FullNameTb.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.FullNameTb.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.FullNameTb.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.FullNameTb.LineThickness = 4
        Me.FullNameTb.Location = New System.Drawing.Point(505, 68)
        Me.FullNameTb.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.FullNameTb.Name = "FullNameTb"
        Me.FullNameTb.Size = New System.Drawing.Size(264, 29)
        Me.FullNameTb.TabIndex = 49
        Me.FullNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(504, 28)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(118, 25)
        Me.BunifuCustomLabel1.TabIndex = 48
        Me.BunifuCustomLabel1.Text = "Full Name"
        '
        'StaffIDTb
        '
        Me.StaffIDTb.BackColor = System.Drawing.SystemColors.Control
        Me.StaffIDTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.StaffIDTb.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaffIDTb.ForeColor = System.Drawing.Color.Black
        Me.StaffIDTb.HintForeColor = System.Drawing.Color.Black
        Me.StaffIDTb.HintText = "Staff ID"
        Me.StaffIDTb.isPassword = False
        Me.StaffIDTb.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.StaffIDTb.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.StaffIDTb.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.StaffIDTb.LineThickness = 4
        Me.StaffIDTb.Location = New System.Drawing.Point(157, 68)
        Me.StaffIDTb.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.StaffIDTb.Name = "StaffIDTb"
        Me.StaffIDTb.Size = New System.Drawing.Size(264, 29)
        Me.StaffIDTb.TabIndex = 51
        Me.StaffIDTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(156, 28)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(90, 25)
        Me.BunifuCustomLabel2.TabIndex = 50
        Me.BunifuCustomLabel2.Text = "Staff ID"
        '
        'UsernameTb
        '
        Me.UsernameTb.BackColor = System.Drawing.SystemColors.Control
        Me.UsernameTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UsernameTb.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTb.ForeColor = System.Drawing.Color.Black
        Me.UsernameTb.HintForeColor = System.Drawing.Color.Black
        Me.UsernameTb.HintText = "Enter Username"
        Me.UsernameTb.isPassword = False
        Me.UsernameTb.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.UsernameTb.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.UsernameTb.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.UsernameTb.LineThickness = 4
        Me.UsernameTb.Location = New System.Drawing.Point(157, 172)
        Me.UsernameTb.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.UsernameTb.Name = "UsernameTb"
        Me.UsernameTb.Size = New System.Drawing.Size(264, 29)
        Me.UsernameTb.TabIndex = 55
        Me.UsernameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(156, 132)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(118, 25)
        Me.BunifuCustomLabel3.TabIndex = 54
        Me.BunifuCustomLabel3.Text = "Username"
        '
        'PasswordTb
        '
        Me.PasswordTb.BackColor = System.Drawing.SystemColors.Control
        Me.PasswordTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PasswordTb.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTb.ForeColor = System.Drawing.Color.Black
        Me.PasswordTb.HintForeColor = System.Drawing.Color.Black
        Me.PasswordTb.HintText = "Enter Password"
        Me.PasswordTb.isPassword = False
        Me.PasswordTb.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.PasswordTb.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.PasswordTb.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.PasswordTb.LineThickness = 4
        Me.PasswordTb.Location = New System.Drawing.Point(509, 172)
        Me.PasswordTb.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.PasswordTb.Name = "PasswordTb"
        Me.PasswordTb.Size = New System.Drawing.Size(264, 29)
        Me.PasswordTb.TabIndex = 53
        Me.PasswordTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(508, 132)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(114, 25)
        Me.BunifuCustomLabel4.TabIndex = 52
        Me.BunifuCustomLabel4.Text = "Password"
        '
        'StaffDataGridView
        '
        Me.StaffDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.StaffDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.StaffDataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.StaffDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.StaffDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.StaffDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.StaffDataGridView.Location = New System.Drawing.Point(171, 341)
        Me.StaffDataGridView.Name = "StaffDataGridView"
        Me.StaffDataGridView.Size = New System.Drawing.Size(910, 314)
        Me.StaffDataGridView.TabIndex = 56
        '
        'AddButton
        '
        Me.AddButton.Activecolor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.AddButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AddButton.BorderRadius = 0
        Me.AddButton.ButtonText = "ADD"
        Me.AddButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddButton.DisabledColor = System.Drawing.Color.Gray
        Me.AddButton.Iconcolor = System.Drawing.Color.Transparent
        Me.AddButton.Iconimage = Nothing
        Me.AddButton.Iconimage_right = Nothing
        Me.AddButton.Iconimage_right_Selected = Nothing
        Me.AddButton.Iconimage_Selected = Nothing
        Me.AddButton.IconMarginLeft = 0
        Me.AddButton.IconMarginRight = 0
        Me.AddButton.IconRightVisible = True
        Me.AddButton.IconRightZoom = 0R
        Me.AddButton.IconVisible = True
        Me.AddButton.IconZoom = 90.0R
        Me.AddButton.IsTab = False
        Me.AddButton.Location = New System.Drawing.Point(315, 253)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.AddButton.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.AddButton.OnHoverTextColor = System.Drawing.Color.Black
        Me.AddButton.selected = False
        Me.AddButton.Size = New System.Drawing.Size(152, 32)
        Me.AddButton.TabIndex = 67
        Me.AddButton.Text = "ADD"
        Me.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AddButton.Textcolor = System.Drawing.Color.Black
        Me.AddButton.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'UpdateButton
        '
        Me.UpdateButton.Activecolor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.UpdateButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UpdateButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.UpdateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UpdateButton.BorderRadius = 0
        Me.UpdateButton.ButtonText = "UPDATE"
        Me.UpdateButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UpdateButton.DisabledColor = System.Drawing.Color.Gray
        Me.UpdateButton.Iconcolor = System.Drawing.Color.Transparent
        Me.UpdateButton.Iconimage = Nothing
        Me.UpdateButton.Iconimage_right = Nothing
        Me.UpdateButton.Iconimage_right_Selected = Nothing
        Me.UpdateButton.Iconimage_Selected = Nothing
        Me.UpdateButton.IconMarginLeft = 0
        Me.UpdateButton.IconMarginRight = 0
        Me.UpdateButton.IconRightVisible = True
        Me.UpdateButton.IconRightZoom = 0R
        Me.UpdateButton.IconVisible = True
        Me.UpdateButton.IconZoom = 90.0R
        Me.UpdateButton.IsTab = False
        Me.UpdateButton.Location = New System.Drawing.Point(531, 253)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.UpdateButton.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.UpdateButton.OnHoverTextColor = System.Drawing.Color.Black
        Me.UpdateButton.selected = False
        Me.UpdateButton.Size = New System.Drawing.Size(152, 32)
        Me.UpdateButton.TabIndex = 68
        Me.UpdateButton.Text = "UPDATE"
        Me.UpdateButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UpdateButton.Textcolor = System.Drawing.Color.Black
        Me.UpdateButton.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'DeleteButton
        '
        Me.DeleteButton.Activecolor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.DeleteButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DeleteButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DeleteButton.BorderRadius = 0
        Me.DeleteButton.ButtonText = "DELETE"
        Me.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DeleteButton.DisabledColor = System.Drawing.Color.Gray
        Me.DeleteButton.Iconcolor = System.Drawing.Color.Transparent
        Me.DeleteButton.Iconimage = Nothing
        Me.DeleteButton.Iconimage_right = Nothing
        Me.DeleteButton.Iconimage_right_Selected = Nothing
        Me.DeleteButton.Iconimage_Selected = Nothing
        Me.DeleteButton.IconMarginLeft = 0
        Me.DeleteButton.IconMarginRight = 0
        Me.DeleteButton.IconRightVisible = True
        Me.DeleteButton.IconRightZoom = 0R
        Me.DeleteButton.IconVisible = True
        Me.DeleteButton.IconZoom = 90.0R
        Me.DeleteButton.IsTab = False
        Me.DeleteButton.Location = New System.Drawing.Point(772, 253)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.DeleteButton.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.DeleteButton.OnHoverTextColor = System.Drawing.Color.Black
        Me.DeleteButton.selected = False
        Me.DeleteButton.Size = New System.Drawing.Size(152, 32)
        Me.DeleteButton.TabIndex = 69
        Me.DeleteButton.Text = "DELETE"
        Me.DeleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DeleteButton.Textcolor = System.Drawing.Color.Black
        Me.DeleteButton.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'NumberTb
        '
        Me.NumberTb.BackColor = System.Drawing.SystemColors.Control
        Me.NumberTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NumberTb.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberTb.ForeColor = System.Drawing.Color.Black
        Me.NumberTb.HintForeColor = System.Drawing.Color.Black
        Me.NumberTb.HintText = "Enter Phone Number"
        Me.NumberTb.isPassword = False
        Me.NumberTb.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.NumberTb.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.NumberTb.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.NumberTb.LineThickness = 4
        Me.NumberTb.Location = New System.Drawing.Point(861, 68)
        Me.NumberTb.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.NumberTb.Name = "NumberTb"
        Me.NumberTb.Size = New System.Drawing.Size(264, 29)
        Me.NumberTb.TabIndex = 71
        Me.NumberTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(860, 28)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(167, 25)
        Me.BunifuCustomLabel5.TabIndex = 70
        Me.BunifuCustomLabel5.Text = "Phone Number"
        '
        'GenderCb
        '
        Me.GenderCb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.GenderCb.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.GenderCb.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderCb.FormattingEnabled = True
        Me.GenderCb.Items.AddRange(New Object() {"Male", "Female"})
        Me.GenderCb.Location = New System.Drawing.Point(865, 169)
        Me.GenderCb.Name = "GenderCb"
        Me.GenderCb.Size = New System.Drawing.Size(264, 32)
        Me.GenderCb.TabIndex = 73
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(860, 132)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(89, 25)
        Me.BunifuCustomLabel7.TabIndex = 72
        Me.BunifuCustomLabel7.Text = "Gender"
        '
        'ManageStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1268, 691)
        Me.Controls.Add(Me.GenderCb)
        Me.Controls.Add(Me.BunifuCustomLabel7)
        Me.Controls.Add(Me.NumberTb)
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.StaffDataGridView)
        Me.Controls.Add(Me.UsernameTb)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.PasswordTb)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.StaffIDTb)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.FullNameTb)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.backBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ManageStaff"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ManageStaff"
        CType(Me.backBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents backBtn As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BackElipse As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents StaffDataGridView As DataGridView
    Friend WithEvents UsernameTb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PasswordTb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents StaffIDTb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents FullNameTb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents DeleteButton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents UpdateButton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents AddButton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents NumberTb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents GenderCb As ComboBox
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
End Class
