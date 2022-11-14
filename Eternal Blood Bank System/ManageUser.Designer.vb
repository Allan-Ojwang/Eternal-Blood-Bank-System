<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageUser))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.LastNameTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.DeleteButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.UpdateButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.UserDataGridView = New System.Windows.Forms.DataGridView()
        Me.EmailTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.NumberTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.IDTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.FirstNameTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.backBtn = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BackElipse = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.GenderCb = New System.Windows.Forms.ComboBox()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.UsernameTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PaswordTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel9 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.DOB = New Bunifu.Framework.UI.BunifuDatepicker()
        CType(Me.UserDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.backBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(862, 119)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(148, 25)
        Me.BunifuCustomLabel7.TabIndex = 89
        Me.BunifuCustomLabel7.Text = "Date Of Birth"
        '
        'LastNameTb
        '
        Me.LastNameTb.BackColor = System.Drawing.SystemColors.Control
        Me.LastNameTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.LastNameTb.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastNameTb.ForeColor = System.Drawing.Color.Black
        Me.LastNameTb.HintForeColor = System.Drawing.Color.Black
        Me.LastNameTb.HintText = "Enter Last Name"
        Me.LastNameTb.isPassword = False
        Me.LastNameTb.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.LastNameTb.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.LastNameTb.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.LastNameTb.LineThickness = 4
        Me.LastNameTb.Location = New System.Drawing.Point(863, 55)
        Me.LastNameTb.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.LastNameTb.Name = "LastNameTb"
        Me.LastNameTb.Size = New System.Drawing.Size(264, 29)
        Me.LastNameTb.TabIndex = 88
        Me.LastNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(862, 15)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(124, 25)
        Me.BunifuCustomLabel5.TabIndex = 87
        Me.BunifuCustomLabel5.Text = "Last Name"
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
        Me.DeleteButton.Location = New System.Drawing.Point(726, 331)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.DeleteButton.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.DeleteButton.OnHoverTextColor = System.Drawing.Color.Black
        Me.DeleteButton.selected = False
        Me.DeleteButton.Size = New System.Drawing.Size(152, 32)
        Me.DeleteButton.TabIndex = 86
        Me.DeleteButton.Text = "DELETE"
        Me.DeleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DeleteButton.Textcolor = System.Drawing.Color.Black
        Me.DeleteButton.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.UpdateButton.Location = New System.Drawing.Point(425, 331)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.UpdateButton.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.UpdateButton.OnHoverTextColor = System.Drawing.Color.Black
        Me.UpdateButton.selected = False
        Me.UpdateButton.Size = New System.Drawing.Size(152, 32)
        Me.UpdateButton.TabIndex = 85
        Me.UpdateButton.Text = "UPDATE"
        Me.UpdateButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UpdateButton.Textcolor = System.Drawing.Color.Black
        Me.UpdateButton.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'UserDataGridView
        '
        Me.UserDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.UserDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.UserDataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UserDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.UserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.UserDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.UserDataGridView.Location = New System.Drawing.Point(170, 369)
        Me.UserDataGridView.Name = "UserDataGridView"
        Me.UserDataGridView.Size = New System.Drawing.Size(910, 314)
        Me.UserDataGridView.TabIndex = 83
        '
        'EmailTb
        '
        Me.EmailTb.BackColor = System.Drawing.SystemColors.Control
        Me.EmailTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.EmailTb.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTb.ForeColor = System.Drawing.Color.Black
        Me.EmailTb.HintForeColor = System.Drawing.Color.Black
        Me.EmailTb.HintText = "Enter Email"
        Me.EmailTb.isPassword = False
        Me.EmailTb.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.EmailTb.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.EmailTb.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.EmailTb.LineThickness = 4
        Me.EmailTb.Location = New System.Drawing.Point(159, 159)
        Me.EmailTb.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.EmailTb.Name = "EmailTb"
        Me.EmailTb.Size = New System.Drawing.Size(264, 29)
        Me.EmailTb.TabIndex = 82
        Me.EmailTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(158, 119)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(70, 25)
        Me.BunifuCustomLabel3.TabIndex = 81
        Me.BunifuCustomLabel3.Text = "Email"
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
        Me.NumberTb.Location = New System.Drawing.Point(511, 159)
        Me.NumberTb.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.NumberTb.Name = "NumberTb"
        Me.NumberTb.Size = New System.Drawing.Size(264, 29)
        Me.NumberTb.TabIndex = 80
        Me.NumberTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(510, 119)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(167, 25)
        Me.BunifuCustomLabel4.TabIndex = 79
        Me.BunifuCustomLabel4.Text = "Phone Number"
        '
        'IDTb
        '
        Me.IDTb.BackColor = System.Drawing.SystemColors.Control
        Me.IDTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.IDTb.Enabled = False
        Me.IDTb.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTb.ForeColor = System.Drawing.Color.Black
        Me.IDTb.HintForeColor = System.Drawing.Color.Black
        Me.IDTb.HintText = "ID"
        Me.IDTb.isPassword = False
        Me.IDTb.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.IDTb.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.IDTb.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.IDTb.LineThickness = 4
        Me.IDTb.Location = New System.Drawing.Point(159, 55)
        Me.IDTb.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.IDTb.Name = "IDTb"
        Me.IDTb.Size = New System.Drawing.Size(264, 29)
        Me.IDTb.TabIndex = 78
        Me.IDTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(158, 15)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(34, 25)
        Me.BunifuCustomLabel2.TabIndex = 77
        Me.BunifuCustomLabel2.Text = "ID"
        '
        'FirstNameTb
        '
        Me.FirstNameTb.BackColor = System.Drawing.SystemColors.Control
        Me.FirstNameTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FirstNameTb.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNameTb.ForeColor = System.Drawing.Color.Black
        Me.FirstNameTb.HintForeColor = System.Drawing.Color.Black
        Me.FirstNameTb.HintText = "Enter First Name"
        Me.FirstNameTb.isPassword = False
        Me.FirstNameTb.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.FirstNameTb.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.FirstNameTb.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.FirstNameTb.LineThickness = 4
        Me.FirstNameTb.Location = New System.Drawing.Point(507, 55)
        Me.FirstNameTb.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.FirstNameTb.Name = "FirstNameTb"
        Me.FirstNameTb.Size = New System.Drawing.Size(264, 29)
        Me.FirstNameTb.TabIndex = 76
        Me.FirstNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(506, 15)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(126, 25)
        Me.BunifuCustomLabel1.TabIndex = 75
        Me.BunifuCustomLabel1.Text = "First Name"
        '
        'backBtn
        '
        Me.backBtn.BackColor = System.Drawing.Color.Black
        Me.backBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.backBtn.Image = CType(resources.GetObject("backBtn.Image"), System.Drawing.Image)
        Me.backBtn.ImageActive = Nothing
        Me.backBtn.Location = New System.Drawing.Point(15, 14)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(52, 52)
        Me.backBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.backBtn.TabIndex = 74
        Me.backBtn.TabStop = False
        Me.backBtn.Zoom = 10
        '
        'BackElipse
        '
        Me.BackElipse.ElipseRadius = 5
        Me.BackElipse.TargetControl = Me.backBtn
        '
        'GenderCb
        '
        Me.GenderCb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.GenderCb.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.GenderCb.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderCb.FormattingEnabled = True
        Me.GenderCb.Items.AddRange(New Object() {"Male", "Female"})
        Me.GenderCb.Location = New System.Drawing.Point(867, 242)
        Me.GenderCb.Name = "GenderCb"
        Me.GenderCb.Size = New System.Drawing.Size(264, 32)
        Me.GenderCb.TabIndex = 96
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(862, 205)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(89, 25)
        Me.BunifuCustomLabel6.TabIndex = 95
        Me.BunifuCustomLabel6.Text = "Gender"
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
        Me.UsernameTb.Location = New System.Drawing.Point(159, 245)
        Me.UsernameTb.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.UsernameTb.Name = "UsernameTb"
        Me.UsernameTb.Size = New System.Drawing.Size(264, 29)
        Me.UsernameTb.TabIndex = 94
        Me.UsernameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(158, 205)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(118, 25)
        Me.BunifuCustomLabel8.TabIndex = 93
        Me.BunifuCustomLabel8.Text = "Username"
        '
        'PaswordTb
        '
        Me.PaswordTb.BackColor = System.Drawing.SystemColors.Control
        Me.PaswordTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PaswordTb.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaswordTb.ForeColor = System.Drawing.Color.Black
        Me.PaswordTb.HintForeColor = System.Drawing.Color.Black
        Me.PaswordTb.HintText = "Enter Password"
        Me.PaswordTb.isPassword = False
        Me.PaswordTb.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.PaswordTb.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.PaswordTb.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.PaswordTb.LineThickness = 4
        Me.PaswordTb.Location = New System.Drawing.Point(511, 245)
        Me.PaswordTb.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.PaswordTb.Name = "PaswordTb"
        Me.PaswordTb.Size = New System.Drawing.Size(264, 29)
        Me.PaswordTb.TabIndex = 92
        Me.PaswordTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel9
        '
        Me.BunifuCustomLabel9.AutoSize = True
        Me.BunifuCustomLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BunifuCustomLabel9.Location = New System.Drawing.Point(510, 205)
        Me.BunifuCustomLabel9.Name = "BunifuCustomLabel9"
        Me.BunifuCustomLabel9.Size = New System.Drawing.Size(114, 25)
        Me.BunifuCustomLabel9.TabIndex = 91
        Me.BunifuCustomLabel9.Text = "Password"
        '
        'DOB
        '
        Me.DOB.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.DOB.BorderRadius = 0
        Me.DOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOB.ForeColor = System.Drawing.Color.Black
        Me.DOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DOB.FormatCustom = "dd-MM-yyyy"
        Me.DOB.Location = New System.Drawing.Point(867, 159)
        Me.DOB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DOB.Name = "DOB"
        Me.DOB.Size = New System.Drawing.Size(264, 29)
        Me.DOB.TabIndex = 97
        Me.DOB.Value = New Date(2022, 10, 22, 0, 0, 0, 0)
        '
        'ManageUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1268, 691)
        Me.Controls.Add(Me.DOB)
        Me.Controls.Add(Me.GenderCb)
        Me.Controls.Add(Me.BunifuCustomLabel6)
        Me.Controls.Add(Me.UsernameTb)
        Me.Controls.Add(Me.BunifuCustomLabel8)
        Me.Controls.Add(Me.PaswordTb)
        Me.Controls.Add(Me.BunifuCustomLabel9)
        Me.Controls.Add(Me.BunifuCustomLabel7)
        Me.Controls.Add(Me.LastNameTb)
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.UserDataGridView)
        Me.Controls.Add(Me.EmailTb)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.NumberTb)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.IDTb)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.FirstNameTb)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.backBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ManageUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ManageUser"
        CType(Me.UserDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.backBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents GenderCb As ComboBox
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents UsernameTb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PaswordTb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel9 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents LastNameTb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents DeleteButton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents UpdateButton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents UserDataGridView As DataGridView
    Friend WithEvents EmailTb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents NumberTb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents IDTb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents FirstNameTb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents backBtn As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BackElipse As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents DOB As Bunifu.Framework.UI.BunifuDatepicker
End Class
