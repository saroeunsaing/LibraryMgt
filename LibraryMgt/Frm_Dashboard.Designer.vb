<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Dashboard
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
        Me.Panel_Title = New System.Windows.Forms.Panel()
        Me.Btn_Maximize = New FontAwesome.Sharp.IconButton()
        Me.Btn_Restore = New FontAwesome.Sharp.IconButton()
        Me.Btn_Minimize = New FontAwesome.Sharp.IconButton()
        Me.Btn_Close = New FontAwesome.Sharp.IconButton()
        Me.Panel_Menu = New System.Windows.Forms.Panel()
        Me.Btn_Dashboard = New FontAwesome.Sharp.IconButton()
        Me.Panel_Content = New System.Windows.Forms.Panel()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.IconButton4 = New FontAwesome.Sharp.IconButton()
        Me.IconButton5 = New FontAwesome.Sharp.IconButton()
        Me.IconButton6 = New FontAwesome.Sharp.IconButton()
        Me.IconButton7 = New FontAwesome.Sharp.IconButton()
        Me.IconButton8 = New FontAwesome.Sharp.IconButton()
        Me.IconButton9 = New FontAwesome.Sharp.IconButton()
        Me.IconButton10 = New FontAwesome.Sharp.IconButton()
        Me.IconButton11 = New FontAwesome.Sharp.IconButton()
        Me.IconButton12 = New FontAwesome.Sharp.IconButton()
        Me.Panel_Title.SuspendLayout()
        Me.Panel_Menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_Title
        '
        Me.Panel_Title.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel_Title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_Title.Controls.Add(Me.IconButton11)
        Me.Panel_Title.Controls.Add(Me.Btn_Maximize)
        Me.Panel_Title.Controls.Add(Me.Btn_Restore)
        Me.Panel_Title.Controls.Add(Me.Btn_Minimize)
        Me.Panel_Title.Controls.Add(Me.Btn_Close)
        Me.Panel_Title.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Title.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Title.Name = "Panel_Title"
        Me.Panel_Title.Size = New System.Drawing.Size(1100, 35)
        Me.Panel_Title.TabIndex = 22
        '
        'Btn_Maximize
        '
        Me.Btn_Maximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Maximize.FlatAppearance.BorderSize = 0
        Me.Btn_Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Maximize.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Maximize.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_Maximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize
        Me.Btn_Maximize.IconColor = System.Drawing.Color.DimGray
        Me.Btn_Maximize.IconSize = 22
        Me.Btn_Maximize.Location = New System.Drawing.Point(1009, 0)
        Me.Btn_Maximize.Name = "Btn_Maximize"
        Me.Btn_Maximize.Rotation = 0R
        Me.Btn_Maximize.Size = New System.Drawing.Size(35, 35)
        Me.Btn_Maximize.TabIndex = 10
        Me.Btn_Maximize.UseVisualStyleBackColor = True
        '
        'Btn_Restore
        '
        Me.Btn_Restore.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Restore.FlatAppearance.BorderSize = 0
        Me.Btn_Restore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Restore.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Restore.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_Restore.IconChar = FontAwesome.Sharp.IconChar.WindowRestore
        Me.Btn_Restore.IconColor = System.Drawing.Color.DimGray
        Me.Btn_Restore.IconSize = 22
        Me.Btn_Restore.Location = New System.Drawing.Point(1009, -5)
        Me.Btn_Restore.Name = "Btn_Restore"
        Me.Btn_Restore.Rotation = 0R
        Me.Btn_Restore.Size = New System.Drawing.Size(35, 35)
        Me.Btn_Restore.TabIndex = 9
        Me.Btn_Restore.UseVisualStyleBackColor = True
        Me.Btn_Restore.Visible = False
        '
        'Btn_Minimize
        '
        Me.Btn_Minimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Minimize.FlatAppearance.BorderSize = 0
        Me.Btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Minimize.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Minimize.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_Minimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.Btn_Minimize.IconColor = System.Drawing.Color.DimGray
        Me.Btn_Minimize.IconSize = 22
        Me.Btn_Minimize.Location = New System.Drawing.Point(963, 0)
        Me.Btn_Minimize.Name = "Btn_Minimize"
        Me.Btn_Minimize.Rotation = 0R
        Me.Btn_Minimize.Size = New System.Drawing.Size(35, 35)
        Me.Btn_Minimize.TabIndex = 8
        Me.Btn_Minimize.UseVisualStyleBackColor = True
        '
        'Btn_Close
        '
        Me.Btn_Close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Close.FlatAppearance.BorderSize = 0
        Me.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Close.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Close.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_Close.IconChar = FontAwesome.Sharp.IconChar.WindowClose
        Me.Btn_Close.IconColor = System.Drawing.Color.DimGray
        Me.Btn_Close.IconSize = 22
        Me.Btn_Close.Location = New System.Drawing.Point(1055, 0)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Rotation = 0R
        Me.Btn_Close.Size = New System.Drawing.Size(35, 35)
        Me.Btn_Close.TabIndex = 7
        Me.Btn_Close.UseVisualStyleBackColor = True
        '
        'Panel_Menu
        '
        Me.Panel_Menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_Menu.Controls.Add(Me.IconButton12)
        Me.Panel_Menu.Controls.Add(Me.IconButton10)
        Me.Panel_Menu.Controls.Add(Me.IconButton9)
        Me.Panel_Menu.Controls.Add(Me.IconButton8)
        Me.Panel_Menu.Controls.Add(Me.IconButton7)
        Me.Panel_Menu.Controls.Add(Me.IconButton6)
        Me.Panel_Menu.Controls.Add(Me.IconButton5)
        Me.Panel_Menu.Controls.Add(Me.IconButton4)
        Me.Panel_Menu.Controls.Add(Me.IconButton3)
        Me.Panel_Menu.Controls.Add(Me.IconButton2)
        Me.Panel_Menu.Controls.Add(Me.IconButton1)
        Me.Panel_Menu.Controls.Add(Me.Btn_Dashboard)
        Me.Panel_Menu.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_Menu.Location = New System.Drawing.Point(0, 35)
        Me.Panel_Menu.Name = "Panel_Menu"
        Me.Panel_Menu.Size = New System.Drawing.Size(210, 665)
        Me.Panel_Menu.TabIndex = 23
        '
        'Btn_Dashboard
        '
        Me.Btn_Dashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Dashboard.FlatAppearance.BorderSize = 0
        Me.Btn_Dashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_Dashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Btn_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Dashboard.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Dashboard.Font = New System.Drawing.Font("NiDA Bayon", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Dashboard.ForeColor = System.Drawing.Color.DimGray
        Me.Btn_Dashboard.IconChar = FontAwesome.Sharp.IconChar.UserPlus
        Me.Btn_Dashboard.IconColor = System.Drawing.Color.LightSeaGreen
        Me.Btn_Dashboard.IconSize = 30
        Me.Btn_Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Dashboard.Location = New System.Drawing.Point(35, 32)
        Me.Btn_Dashboard.Name = "Btn_Dashboard"
        Me.Btn_Dashboard.Rotation = 0R
        Me.Btn_Dashboard.Size = New System.Drawing.Size(184, 40)
        Me.Btn_Dashboard.TabIndex = 26
        Me.Btn_Dashboard.Text = "ចុះឈ្មោះអ្នកខ្ចីសៀវភៅ"
        Me.Btn_Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Dashboard.UseVisualStyleBackColor = True
        '
        'Panel_Content
        '
        Me.Panel_Content.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_Content.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Content.Location = New System.Drawing.Point(210, 35)
        Me.Panel_Content.Name = "Panel_Content"
        Me.Panel_Content.Size = New System.Drawing.Size(890, 665)
        Me.Panel_Content.TabIndex = 24
        '
        'IconButton1
        '
        Me.IconButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.IconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton1.Font = New System.Drawing.Font("NiDA Bayon", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.Color.DimGray
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Book
        Me.IconButton1.IconColor = System.Drawing.Color.Plum
        Me.IconButton1.IconSize = 30
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.Location = New System.Drawing.Point(36, 78)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Rotation = 0R
        Me.IconButton1.Size = New System.Drawing.Size(163, 40)
        Me.IconButton1.TabIndex = 27
        Me.IconButton1.Text = "ឱ្យខ្ចីសៀវភៅ"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'IconButton2
        '
        Me.IconButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.IconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton2.Font = New System.Drawing.Font("NiDA Bayon", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton2.ForeColor = System.Drawing.Color.DimGray
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.PenFancy
        Me.IconButton2.IconColor = System.Drawing.Color.Gold
        Me.IconButton2.IconSize = 30
        Me.IconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton2.Location = New System.Drawing.Point(38, 216)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Rotation = 0R
        Me.IconButton2.Size = New System.Drawing.Size(162, 40)
        Me.IconButton2.TabIndex = 28
        Me.IconButton2.Text = "បន្ថែមសម្ភារ"
        Me.IconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton2.UseVisualStyleBackColor = True
        '
        'IconButton3
        '
        Me.IconButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconButton3.FlatAppearance.BorderSize = 0
        Me.IconButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.IconButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.IconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton3.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton3.Font = New System.Drawing.Font("NiDA Bayon", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton3.ForeColor = System.Drawing.Color.DimGray
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.BookMedical
        Me.IconButton3.IconColor = System.Drawing.Color.LimeGreen
        Me.IconButton3.IconSize = 30
        Me.IconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton3.Location = New System.Drawing.Point(38, 170)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Rotation = 0R
        Me.IconButton3.Size = New System.Drawing.Size(164, 40)
        Me.IconButton3.TabIndex = 29
        Me.IconButton3.Text = "បន្ថែមសៀវភៅ"
        Me.IconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton3.UseVisualStyleBackColor = True
        '
        'IconButton4
        '
        Me.IconButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconButton4.FlatAppearance.BorderSize = 0
        Me.IconButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.IconButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.IconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton4.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton4.Font = New System.Drawing.Font("NiDA Bayon", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton4.ForeColor = System.Drawing.Color.DimGray
        Me.IconButton4.IconChar = FontAwesome.Sharp.IconChar.Bookmark
        Me.IconButton4.IconColor = System.Drawing.Color.Salmon
        Me.IconButton4.IconSize = 30
        Me.IconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton4.Location = New System.Drawing.Point(38, 124)
        Me.IconButton4.Name = "IconButton4"
        Me.IconButton4.Rotation = 0R
        Me.IconButton4.Size = New System.Drawing.Size(162, 40)
        Me.IconButton4.TabIndex = 30
        Me.IconButton4.Text = "សងសៀវភៅ"
        Me.IconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton4.UseVisualStyleBackColor = True
        '
        'IconButton5
        '
        Me.IconButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconButton5.FlatAppearance.BorderSize = 0
        Me.IconButton5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.IconButton5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.IconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton5.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton5.Font = New System.Drawing.Font("NiDA Bayon", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton5.ForeColor = System.Drawing.Color.DimGray
        Me.IconButton5.IconChar = FontAwesome.Sharp.IconChar.Lock
        Me.IconButton5.IconColor = System.Drawing.Color.Turquoise
        Me.IconButton5.IconSize = 30
        Me.IconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton5.Location = New System.Drawing.Point(37, 354)
        Me.IconButton5.Name = "IconButton5"
        Me.IconButton5.Rotation = 0R
        Me.IconButton5.Size = New System.Drawing.Size(164, 43)
        Me.IconButton5.TabIndex = 31
        Me.IconButton5.Text = "ប្ដូរពាក្យសម្ងាត់"
        Me.IconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton5.UseVisualStyleBackColor = True
        '
        'IconButton6
        '
        Me.IconButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconButton6.FlatAppearance.BorderSize = 0
        Me.IconButton6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.IconButton6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.IconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton6.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton6.Font = New System.Drawing.Font("NiDA Bayon", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton6.ForeColor = System.Drawing.Color.DimGray
        Me.IconButton6.IconChar = FontAwesome.Sharp.IconChar.LockOpen
        Me.IconButton6.IconColor = System.Drawing.Color.IndianRed
        Me.IconButton6.IconSize = 30
        Me.IconButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton6.Location = New System.Drawing.Point(37, 403)
        Me.IconButton6.Name = "IconButton6"
        Me.IconButton6.Rotation = 0R
        Me.IconButton6.Size = New System.Drawing.Size(164, 40)
        Me.IconButton6.TabIndex = 32
        Me.IconButton6.Text = "ចាក់សោកម្មវិធី"
        Me.IconButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton6.UseVisualStyleBackColor = True
        '
        'IconButton7
        '
        Me.IconButton7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconButton7.FlatAppearance.BorderSize = 0
        Me.IconButton7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.IconButton7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.IconButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton7.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton7.Font = New System.Drawing.Font("NiDA Bayon", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton7.ForeColor = System.Drawing.Color.DimGray
        Me.IconButton7.IconChar = FontAwesome.Sharp.IconChar.ExclamationCircle
        Me.IconButton7.IconColor = System.Drawing.Color.DarkGreen
        Me.IconButton7.IconSize = 30
        Me.IconButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton7.Location = New System.Drawing.Point(35, 449)
        Me.IconButton7.Name = "IconButton7"
        Me.IconButton7.Rotation = 0R
        Me.IconButton7.Size = New System.Drawing.Size(164, 40)
        Me.IconButton7.TabIndex = 33
        Me.IconButton7.Text = "អំពីកម្មិវិធី"
        Me.IconButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton7.UseVisualStyleBackColor = True
        '
        'IconButton8
        '
        Me.IconButton8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconButton8.FlatAppearance.BorderSize = 0
        Me.IconButton8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.IconButton8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.IconButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton8.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton8.Font = New System.Drawing.Font("NiDA Bayon", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton8.ForeColor = System.Drawing.Color.DimGray
        Me.IconButton8.IconChar = FontAwesome.Sharp.IconChar.Empire
        Me.IconButton8.IconColor = System.Drawing.Color.Red
        Me.IconButton8.IconSize = 30
        Me.IconButton8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton8.Location = New System.Drawing.Point(39, 495)
        Me.IconButton8.Name = "IconButton8"
        Me.IconButton8.Rotation = 0R
        Me.IconButton8.Size = New System.Drawing.Size(156, 40)
        Me.IconButton8.TabIndex = 34
        Me.IconButton8.Text = "ចាកចេញ"
        Me.IconButton8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton8.UseVisualStyleBackColor = True
        '
        'IconButton9
        '
        Me.IconButton9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconButton9.FlatAppearance.BorderSize = 0
        Me.IconButton9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.IconButton9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.IconButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton9.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton9.Font = New System.Drawing.Font("NiDA Bayon", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton9.ForeColor = System.Drawing.Color.DimGray
        Me.IconButton9.IconChar = FontAwesome.Sharp.IconChar.ChartPie
        Me.IconButton9.IconColor = System.Drawing.Color.Crimson
        Me.IconButton9.IconSize = 35
        Me.IconButton9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton9.Location = New System.Drawing.Point(35, 262)
        Me.IconButton9.Name = "IconButton9"
        Me.IconButton9.Rotation = 0R
        Me.IconButton9.Size = New System.Drawing.Size(164, 40)
        Me.IconButton9.TabIndex = 35
        Me.IconButton9.Text = "បង្ហាញស្ថិតិ"
        Me.IconButton9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton9.UseVisualStyleBackColor = True
        '
        'IconButton10
        '
        Me.IconButton10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconButton10.FlatAppearance.BorderSize = 0
        Me.IconButton10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.IconButton10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.IconButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton10.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton10.Font = New System.Drawing.Font("NiDA Bayon", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton10.ForeColor = System.Drawing.Color.DimGray
        Me.IconButton10.IconChar = FontAwesome.Sharp.IconChar.Lightbulb
        Me.IconButton10.IconColor = System.Drawing.Color.OliveDrab
        Me.IconButton10.IconSize = 30
        Me.IconButton10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton10.Location = New System.Drawing.Point(39, 308)
        Me.IconButton10.Name = "IconButton10"
        Me.IconButton10.Rotation = 0R
        Me.IconButton10.Size = New System.Drawing.Size(161, 40)
        Me.IconButton10.TabIndex = 36
        Me.IconButton10.Text = "មើលជំនួយ"
        Me.IconButton10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton10.UseVisualStyleBackColor = True
        '
        'IconButton11
        '
        Me.IconButton11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconButton11.FlatAppearance.BorderSize = 0
        Me.IconButton11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.IconButton11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.IconButton11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton11.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton11.Font = New System.Drawing.Font("NiDA Bayon", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton11.ForeColor = System.Drawing.Color.DimGray
        Me.IconButton11.IconChar = FontAwesome.Sharp.IconChar.LifeRing
        Me.IconButton11.IconColor = System.Drawing.Color.LightSeaGreen
        Me.IconButton11.IconSize = 30
        Me.IconButton11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton11.Location = New System.Drawing.Point(2, -1)
        Me.IconButton11.Name = "IconButton11"
        Me.IconButton11.Rotation = 0R
        Me.IconButton11.Size = New System.Drawing.Size(197, 36)
        Me.IconButton11.TabIndex = 37
        Me.IconButton11.Text = "បណ្ណាល័យ"
        Me.IconButton11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton11.UseVisualStyleBackColor = True
        '
        'IconButton12
        '
        Me.IconButton12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconButton12.FlatAppearance.BorderSize = 0
        Me.IconButton12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.IconButton12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.IconButton12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton12.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton12.Font = New System.Drawing.Font("NiDA Bayon", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton12.ForeColor = System.Drawing.Color.DimGray
        Me.IconButton12.IconChar = FontAwesome.Sharp.IconChar.ListAlt
        Me.IconButton12.IconColor = System.Drawing.Color.LightSeaGreen
        Me.IconButton12.IconSize = 30
        Me.IconButton12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton12.Location = New System.Drawing.Point(-4, -1)
        Me.IconButton12.Name = "IconButton12"
        Me.IconButton12.Rotation = 0R
        Me.IconButton12.Size = New System.Drawing.Size(197, 40)
        Me.IconButton12.TabIndex = 37
        Me.IconButton12.Text = "មីនុយ"
        Me.IconButton12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton12.UseVisualStyleBackColor = True
        '
        'Frm_Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1100, 700)
        Me.Controls.Add(Me.Panel_Content)
        Me.Controls.Add(Me.Panel_Menu)
        Me.Controls.Add(Me.Panel_Title)
        Me.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.Name = "Frm_Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel_Title.ResumeLayout(False)
        Me.Panel_Menu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Title As Panel
    Friend WithEvents Btn_Maximize As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Restore As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Minimize As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Close As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel_Menu As Panel
    Friend WithEvents Btn_Dashboard As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel_Content As Panel
    Friend WithEvents IconButton11 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton12 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton10 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton9 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton8 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton7 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton6 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton5 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton4 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
End Class
