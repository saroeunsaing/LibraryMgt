<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Borrower
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
        Me.IconButton11 = New FontAwesome.Sharp.IconButton()
        Me.Btn_Close = New FontAwesome.Sharp.IconButton()
        Me.Panel_Title.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_Title
        '
        Me.Panel_Title.BackColor = System.Drawing.Color.MistyRose
        Me.Panel_Title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_Title.Controls.Add(Me.IconButton11)
        Me.Panel_Title.Controls.Add(Me.Btn_Close)
        Me.Panel_Title.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Title.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Title.Name = "Panel_Title"
        Me.Panel_Title.Size = New System.Drawing.Size(897, 35)
        Me.Panel_Title.TabIndex = 23
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
        Me.IconButton11.Text = "អ្នកខ្ចីសៀវភៅ"
        Me.IconButton11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton11.UseVisualStyleBackColor = True
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
        Me.Btn_Close.Location = New System.Drawing.Point(852, 0)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Rotation = 0R
        Me.Btn_Close.Size = New System.Drawing.Size(35, 35)
        Me.Btn_Close.TabIndex = 7
        Me.Btn_Close.UseVisualStyleBackColor = True
        '
        'Frm_Borrower
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(897, 539)
        Me.Controls.Add(Me.Panel_Title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_Borrower"
        Me.Text = "Frm_Borrower"
        Me.Panel_Title.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Title As Panel
    Friend WithEvents IconButton11 As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Close As FontAwesome.Sharp.IconButton
End Class
