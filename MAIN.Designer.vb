<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DailyReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MonthlyReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AnualReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.menuAddPossition = New System.Windows.Forms.ToolStripMenuItem
        Me.EmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DepartmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip
        Me.MenuStrip3 = New System.Windows.Forms.MenuStrip
        Me.Button1 = New System.Windows.Forms.Button
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel12 = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblLogin = New System.Windows.Forms.ToolStripStatusLabel
        Me.tsslLogin = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel10 = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblName = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel8 = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblDate = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblTime = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel9 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel7 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 24)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStrip1.Size = New System.Drawing.Size(1053, 73)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.boningpayroll.My.Resources.Resources._exit
        Me.ExitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(62, 69)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        Me.ExitToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DailyReportsToolStripMenuItem, Me.MonthlyReportsToolStripMenuItem, Me.AnualReportsToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Image = Global.boningpayroll.My.Resources.Resources.reports
        Me.ReportsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(62, 69)
        Me.ReportsToolStripMenuItem.Text = " &Reports"
        Me.ReportsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'DailyReportsToolStripMenuItem
        '
        Me.DailyReportsToolStripMenuItem.Name = "DailyReportsToolStripMenuItem"
        Me.DailyReportsToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.DailyReportsToolStripMenuItem.Text = "&Daily Reports"
        '
        'MonthlyReportsToolStripMenuItem
        '
        Me.MonthlyReportsToolStripMenuItem.Name = "MonthlyReportsToolStripMenuItem"
        Me.MonthlyReportsToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.MonthlyReportsToolStripMenuItem.Text = "&Monthly Reports"
        '
        'AnualReportsToolStripMenuItem
        '
        Me.AnualReportsToolStripMenuItem.Name = "AnualReportsToolStripMenuItem"
        Me.AnualReportsToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.AnualReportsToolStripMenuItem.Text = "&Anual Reports "
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuAddPossition, Me.EmployeeToolStripMenuItem, Me.DepartmentToolStripMenuItem})
        Me.ToolStripMenuItem1.Image = Global.boningpayroll.My.Resources.Resources.dataEntry
        Me.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(73, 69)
        Me.ToolStripMenuItem1.Text = "&Data Entry"
        Me.ToolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'menuAddPossition
        '
        Me.menuAddPossition.Name = "menuAddPossition"
        Me.menuAddPossition.Size = New System.Drawing.Size(137, 22)
        Me.menuAddPossition.Text = "&Position"
        '
        'EmployeeToolStripMenuItem
        '
        Me.EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem"
        Me.EmployeeToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.EmployeeToolStripMenuItem.Text = "&Employee"
        '
        'DepartmentToolStripMenuItem
        '
        Me.DepartmentToolStripMenuItem.Name = "DepartmentToolStripMenuItem"
        Me.DepartmentToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.DepartmentToolStripMenuItem.Text = "&Department"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Teal
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.Black
        Me.TextBox2.Location = New System.Drawing.Point(0, 52)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(378, 20)
        Me.TextBox2.TabIndex = 14
        Me.TextBox2.Text = "                    WATER TECHNOLOGY SYSTEM INC."
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TextBox1.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(0, 24)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(248, 58)
        Me.TextBox1.TabIndex = 17
        Me.TextBox1.Text = "BONING'S"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.Color.Black
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 97)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip2.Size = New System.Drawing.Size(1053, 24)
        Me.MenuStrip2.TabIndex = 15
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'MenuStrip3
        '
        Me.MenuStrip3.BackColor = System.Drawing.Color.Black
        Me.MenuStrip3.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip3.Name = "MenuStrip3"
        Me.MenuStrip3.Size = New System.Drawing.Size(1053, 24)
        Me.MenuStrip3.TabIndex = 18
        Me.MenuStrip3.Text = "MenuStrip3"
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Image = Global.boningpayroll.My.Resources.Resources.logo_copy_blacks
        Me.Button1.Location = New System.Drawing.Point(245, 39)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 50)
        Me.Button1.TabIndex = 20
        Me.Button1.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel12, Me.lblLogin, Me.tsslLogin, Me.ToolStripStatusLabel10, Me.lblName, Me.ToolStripStatusLabel5, Me.ToolStripStatusLabel8, Me.lblDate, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel6, Me.lblTime, Me.ToolStripStatusLabel9, Me.ToolStripStatusLabel7, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 578)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.Size = New System.Drawing.Size(1053, 24)
        Me.StatusStrip1.TabIndex = 21
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel12
        '
        Me.ToolStripStatusLabel12.BorderSides = CType((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ToolStripStatusLabel12.Name = "ToolStripStatusLabel12"
        Me.ToolStripStatusLabel12.Size = New System.Drawing.Size(47, 19)
        Me.ToolStripStatusLabel12.Text = "Login: "
        '
        'lblLogin
        '
        Me.lblLogin.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Top
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(80, 19)
        Me.lblLogin.Text = "                       "
        '
        'tsslLogin
        '
        Me.tsslLogin.Name = "tsslLogin"
        Me.tsslLogin.Size = New System.Drawing.Size(10, 19)
        Me.tsslLogin.Text = " "
        '
        'ToolStripStatusLabel10
        '
        Me.ToolStripStatusLabel10.BorderSides = CType((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ToolStripStatusLabel10.Name = "ToolStripStatusLabel10"
        Me.ToolStripStatusLabel10.Size = New System.Drawing.Size(49, 19)
        Me.ToolStripStatusLabel10.Text = "Name: "
        '
        'lblName
        '
        Me.lblName.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Top
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(83, 19)
        Me.lblName.Text = "                        "
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(10, 19)
        Me.ToolStripStatusLabel5.Text = " "
        '
        'ToolStripStatusLabel8
        '
        Me.ToolStripStatusLabel8.BorderSides = CType((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ToolStripStatusLabel8.Name = "ToolStripStatusLabel8"
        Me.ToolStripStatusLabel8.Size = New System.Drawing.Size(41, 19)
        Me.ToolStripStatusLabel8.Text = "Date: "
        '
        'lblDate
        '
        Me.lblDate.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Top
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(80, 19)
        Me.lblDate.Text = "                       "
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(10, 19)
        Me.ToolStripStatusLabel3.Text = " "
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.BorderSides = CType((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(44, 19)
        Me.ToolStripStatusLabel6.Text = "Time: "
        '
        'lblTime
        '
        Me.lblTime.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Top
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(83, 19)
        Me.lblTime.Text = "                        "
        '
        'ToolStripStatusLabel9
        '
        Me.ToolStripStatusLabel9.Name = "ToolStripStatusLabel9"
        Me.ToolStripStatusLabel9.Size = New System.Drawing.Size(10, 19)
        Me.ToolStripStatusLabel9.Text = " "
        '
        'ToolStripStatusLabel7
        '
        Me.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
        Me.ToolStripStatusLabel7.Size = New System.Drawing.Size(10, 19)
        Me.ToolStripStatusLabel7.Text = " "
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.BorderSides = CType((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ToolStripStatusLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(122, 19)
        Me.ToolStripStatusLabel2.Text = "Host:  EIS Ver.1.0.0"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TextBox3.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.White
        Me.TextBox3.Location = New System.Drawing.Point(301, 39)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(238, 58)
        Me.TextBox3.TabIndex = 22
        Me.TextBox3.Text = "TRADING"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.boningpayroll.My.Resources.Resources.logo6
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1053, 602)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.MenuStrip3)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DailyReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MonthlyReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuAddPossition As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuStrip3 As System.Windows.Forms.MenuStrip
    Friend WithEvents AnualReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DepartmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel12 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblLogin As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsslLogin As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel10 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblName As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel8 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblDate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel9 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel7 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
End Class
