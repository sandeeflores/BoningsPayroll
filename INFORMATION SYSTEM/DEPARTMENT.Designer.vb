<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDepartment
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
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.panel3 = New System.Windows.Forms.Panel
        Me.lvwDept = New System.Windows.Forms.ListView
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.groupBox3 = New System.Windows.Forms.GroupBox
        Me.txtDeptsSearchBox = New System.Windows.Forms.TextBox
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnView = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.grpAdd = New System.Windows.Forms.GroupBox
        Me.txtDeptCode = New System.Windows.Forms.TextBox
        Me.txtName = New System.Windows.Forms.TextBox
        Me.label4 = New System.Windows.Forms.Label
        Me.label3 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.panel2 = New System.Windows.Forms.Panel
        Me.label12 = New System.Windows.Forms.Label
        Me.groupBox2 = New System.Windows.Forms.GroupBox
        Me.radioButton2 = New System.Windows.Forms.RadioButton
        Me.radioButton1 = New System.Windows.Forms.RadioButton
        Me.txtSearchBox = New System.Windows.Forms.TextBox
        Me.lvwEmpList = New System.Windows.Forms.ListView
        Me.columnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.columnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.columnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.MenuStrip3 = New System.Windows.Forms.MenuStrip
        Me.panel3.SuspendLayout()
        Me.groupBox3.SuspendLayout()
        Me.grpAdd.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Location = New System.Drawing.Point(8, 555)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(87, 23)
        Me.btnAdd.TabIndex = 37
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(380, 555)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(87, 23)
        Me.btnClose.TabIndex = 36
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'panel3
        '
        Me.panel3.BackColor = System.Drawing.Color.LightGray
        Me.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel3.Controls.Add(Me.lvwDept)
        Me.panel3.Controls.Add(Me.groupBox3)
        Me.panel3.Location = New System.Drawing.Point(8, 191)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(459, 347)
        Me.panel3.TabIndex = 35
        '
        'lvwDept
        '
        Me.lvwDept.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lvwDept.FullRowSelect = True
        Me.lvwDept.GridLines = True
        Me.lvwDept.HideSelection = False
        Me.lvwDept.Location = New System.Drawing.Point(14, 78)
        Me.lvwDept.Name = "lvwDept"
        Me.lvwDept.Size = New System.Drawing.Size(428, 250)
        Me.lvwDept.TabIndex = 20
        Me.lvwDept.UseCompatibleStateImageBehavior = False
        Me.lvwDept.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "No."
        Me.ColumnHeader4.Width = 41
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Department Code"
        Me.ColumnHeader5.Width = 97
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Department Name"
        Me.ColumnHeader6.Width = 240
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.txtDeptsSearchBox)
        Me.groupBox3.Location = New System.Drawing.Point(14, 3)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(428, 69)
        Me.groupBox3.TabIndex = 19
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Search Department"
        '
        'txtDeptsSearchBox
        '
        Me.txtDeptsSearchBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDeptsSearchBox.Location = New System.Drawing.Point(21, 20)
        Me.txtDeptsSearchBox.Multiline = True
        Me.txtDeptsSearchBox.Name = "txtDeptsSearchBox"
        Me.txtDeptsSearchBox.Size = New System.Drawing.Size(266, 31)
        Me.txtDeptsSearchBox.TabIndex = 11
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Location = New System.Drawing.Point(287, 555)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(87, 23)
        Me.btnDelete.TabIndex = 34
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnView.Location = New System.Drawing.Point(194, 555)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(87, 23)
        Me.btnView.TabIndex = 33
        Me.btnView.Text = "&View"
        Me.btnView.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Location = New System.Drawing.Point(101, 555)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(87, 23)
        Me.btnEdit.TabIndex = 32
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'grpAdd
        '
        Me.grpAdd.BackColor = System.Drawing.Color.LightGray
        Me.grpAdd.Controls.Add(Me.txtDeptCode)
        Me.grpAdd.Controls.Add(Me.txtName)
        Me.grpAdd.Controls.Add(Me.label4)
        Me.grpAdd.Controls.Add(Me.label3)
        Me.grpAdd.Controls.Add(Me.btnSave)
        Me.grpAdd.Location = New System.Drawing.Point(8, 36)
        Me.grpAdd.Name = "grpAdd"
        Me.grpAdd.Size = New System.Drawing.Size(459, 149)
        Me.grpAdd.TabIndex = 31
        Me.grpAdd.TabStop = False
        Me.grpAdd.Text = "Department Information"
        '
        'txtDeptCode
        '
        Me.txtDeptCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDeptCode.Location = New System.Drawing.Point(139, 29)
        Me.txtDeptCode.Name = "txtDeptCode"
        Me.txtDeptCode.Size = New System.Drawing.Size(87, 20)
        Me.txtDeptCode.TabIndex = 8
        '
        'txtName
        '
        Me.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtName.Location = New System.Drawing.Point(139, 70)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(187, 20)
        Me.txtName.TabIndex = 7
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(16, 78)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(96, 13)
        Me.label4.TabIndex = 6
        Me.label4.Text = "Department Name:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(16, 36)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(96, 13)
        Me.label3.TabIndex = 4
        Me.label3.Text = "DepartmentCode : "
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Location = New System.Drawing.Point(241, 108)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(87, 23)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.LightGray
        Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel2.Controls.Add(Me.label12)
        Me.panel2.Controls.Add(Me.groupBox2)
        Me.panel2.Controls.Add(Me.lvwEmpList)
        Me.panel2.Location = New System.Drawing.Point(495, 36)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(432, 502)
        Me.panel2.TabIndex = 38
        '
        'label12
        '
        Me.label12.BackColor = System.Drawing.Color.LightGray
        Me.label12.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label12.Location = New System.Drawing.Point(23, 94)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(393, 22)
        Me.label12.TabIndex = 18
        Me.label12.Text = "Employee List"
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.radioButton2)
        Me.groupBox2.Controls.Add(Me.radioButton1)
        Me.groupBox2.Controls.Add(Me.txtSearchBox)
        Me.groupBox2.Location = New System.Drawing.Point(17, 3)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(399, 77)
        Me.groupBox2.TabIndex = 17
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Search Employee"
        '
        'radioButton2
        '
        Me.radioButton2.AutoSize = True
        Me.radioButton2.Location = New System.Drawing.Point(9, 58)
        Me.radioButton2.Name = "radioButton2"
        Me.radioButton2.Size = New System.Drawing.Size(39, 17)
        Me.radioButton2.TabIndex = 13
        Me.radioButton2.TabStop = True
        Me.radioButton2.Text = "ID "
        Me.radioButton2.UseVisualStyleBackColor = True
        '
        'radioButton1
        '
        Me.radioButton1.AutoSize = True
        Me.radioButton1.Location = New System.Drawing.Point(54, 58)
        Me.radioButton1.Name = "radioButton1"
        Me.radioButton1.Size = New System.Drawing.Size(53, 17)
        Me.radioButton1.TabIndex = 12
        Me.radioButton1.TabStop = True
        Me.radioButton1.Text = "Name"
        Me.radioButton1.UseVisualStyleBackColor = True
        '
        'txtSearchBox
        '
        Me.txtSearchBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSearchBox.Location = New System.Drawing.Point(6, 18)
        Me.txtSearchBox.Multiline = True
        Me.txtSearchBox.Name = "txtSearchBox"
        Me.txtSearchBox.Size = New System.Drawing.Size(387, 31)
        Me.txtSearchBox.TabIndex = 11
        '
        'lvwEmpList
        '
        Me.lvwEmpList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader1, Me.columnHeader2, Me.columnHeader3})
        Me.lvwEmpList.GridLines = True
        Me.lvwEmpList.Location = New System.Drawing.Point(23, 117)
        Me.lvwEmpList.Name = "lvwEmpList"
        Me.lvwEmpList.Size = New System.Drawing.Size(393, 366)
        Me.lvwEmpList.TabIndex = 15
        Me.lvwEmpList.UseCompatibleStateImageBehavior = False
        Me.lvwEmpList.View = System.Windows.Forms.View.Details
        '
        'columnHeader1
        '
        Me.columnHeader1.Text = "No"
        Me.columnHeader1.Width = 37
        '
        'columnHeader2
        '
        Me.columnHeader2.Text = "Emp_no"
        Me.columnHeader2.Width = 57
        '
        'columnHeader3
        '
        Me.columnHeader3.Text = "Name"
        Me.columnHeader3.Width = 290
        '
        'MenuStrip3
        '
        Me.MenuStrip3.BackColor = System.Drawing.Color.Teal
        Me.MenuStrip3.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip3.Name = "MenuStrip3"
        Me.MenuStrip3.Size = New System.Drawing.Size(935, 24)
        Me.MenuStrip3.TabIndex = 40
        Me.MenuStrip3.Text = "MenuStrip3"
        '
        'frmDepartment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(935, 583)
        Me.Controls.Add(Me.MenuStrip3)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.panel3)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.grpAdd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDepartment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DEPARTMENT"
        Me.panel3.ResumeLayout(False)
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        Me.grpAdd.ResumeLayout(False)
        Me.grpAdd.PerformLayout()
        Me.panel2.ResumeLayout(False)
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btnAdd As System.Windows.Forms.Button
    Private WithEvents btnClose As System.Windows.Forms.Button
    Private WithEvents panel3 As System.Windows.Forms.Panel
    Private WithEvents groupBox3 As System.Windows.Forms.GroupBox
    Private WithEvents txtDeptsSearchBox As System.Windows.Forms.TextBox
    Private WithEvents btnDelete As System.Windows.Forms.Button
    Private WithEvents btnView As System.Windows.Forms.Button
    Private WithEvents btnEdit As System.Windows.Forms.Button
    Private WithEvents grpAdd As System.Windows.Forms.GroupBox
    Private WithEvents txtName As System.Windows.Forms.TextBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents btnSave As System.Windows.Forms.Button
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Private WithEvents label12 As System.Windows.Forms.Label
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents radioButton2 As System.Windows.Forms.RadioButton
    Private WithEvents radioButton1 As System.Windows.Forms.RadioButton
    Private WithEvents txtSearchBox As System.Windows.Forms.TextBox
    Private WithEvents lvwEmpList As System.Windows.Forms.ListView
    Private WithEvents columnHeader1 As System.Windows.Forms.ColumnHeader
    Private WithEvents columnHeader2 As System.Windows.Forms.ColumnHeader
    Private WithEvents columnHeader3 As System.Windows.Forms.ColumnHeader
    Private WithEvents txtDeptCode As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip3 As System.Windows.Forms.MenuStrip
    Friend WithEvents lvwDept As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
End Class
