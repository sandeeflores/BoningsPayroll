<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPosition
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
        Me.panel3 = New System.Windows.Forms.Panel
        Me.lvwPos = New System.Windows.Forms.ListView
        Me.colID = New System.Windows.Forms.ColumnHeader
        Me.colName = New System.Windows.Forms.ColumnHeader
        Me.colDepartment = New System.Windows.Forms.ColumnHeader
        Me.grpPos = New System.Windows.Forms.GroupBox
        Me.lblPosStatus = New System.Windows.Forms.Label
        Me.cboDept = New System.Windows.Forms.ComboBox
        Me.btnNew = New System.Windows.Forms.Button
        Me.txtPosName = New System.Windows.Forms.TextBox
        Me.txtPosNo = New System.Windows.Forms.TextBox
        Me.label5 = New System.Windows.Forms.Label
        Me.label4 = New System.Windows.Forms.Label
        Me.label3 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.MenuStrip3 = New System.Windows.Forms.MenuStrip
        Me.lvwEmployee = New System.Windows.Forms.ListView
        Me.colEmpno = New System.Windows.Forms.ColumnHeader
        Me.colNameEmp = New System.Windows.Forms.ColumnHeader
        Me.colDateHired = New System.Windows.Forms.ColumnHeader
        Me.lblListEmp = New System.Windows.Forms.Label
        Me.btnDelete = New System.Windows.Forms.Button
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.panel3.SuspendLayout()
        Me.grpPos.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel3
        '
        Me.panel3.BackColor = System.Drawing.Color.LightGray
        Me.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel3.Controls.Add(Me.lvwPos)
        Me.panel3.Location = New System.Drawing.Point(13, 219)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(435, 319)
        Me.panel3.TabIndex = 21
        '
        'lvwPos
        '
        Me.lvwPos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colID, Me.colName, Me.colDepartment})
        Me.lvwPos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwPos.FullRowSelect = True
        Me.lvwPos.GridLines = True
        Me.lvwPos.Location = New System.Drawing.Point(5, 6)
        Me.lvwPos.Name = "lvwPos"
        Me.lvwPos.Size = New System.Drawing.Size(423, 303)
        Me.lvwPos.TabIndex = 8
        Me.lvwPos.UseCompatibleStateImageBehavior = False
        Me.lvwPos.View = System.Windows.Forms.View.Details
        '
        'colID
        '
        Me.colID.Text = "ID"
        '
        'colName
        '
        Me.colName.Text = "Name"
        Me.colName.Width = 150
        '
        'colDepartment
        '
        Me.colDepartment.Text = "Department"
        Me.colDepartment.Width = 200
        '
        'grpPos
        '
        Me.grpPos.BackColor = System.Drawing.Color.LightGray
        Me.grpPos.Controls.Add(Me.lblPosStatus)
        Me.grpPos.Controls.Add(Me.cboDept)
        Me.grpPos.Controls.Add(Me.btnNew)
        Me.grpPos.Controls.Add(Me.txtPosName)
        Me.grpPos.Controls.Add(Me.txtPosNo)
        Me.grpPos.Controls.Add(Me.label5)
        Me.grpPos.Controls.Add(Me.label4)
        Me.grpPos.Controls.Add(Me.label3)
        Me.grpPos.Controls.Add(Me.btnSave)
        Me.grpPos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPos.Location = New System.Drawing.Point(13, 38)
        Me.grpPos.Name = "grpPos"
        Me.grpPos.Size = New System.Drawing.Size(435, 175)
        Me.grpPos.TabIndex = 20
        Me.grpPos.TabStop = False
        Me.grpPos.Text = "Position Information"
        '
        'lblPosStatus
        '
        Me.lblPosStatus.AutoSize = True
        Me.lblPosStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosStatus.ForeColor = System.Drawing.Color.Maroon
        Me.lblPosStatus.Location = New System.Drawing.Point(255, 32)
        Me.lblPosStatus.Name = "lblPosStatus"
        Me.lblPosStatus.Size = New System.Drawing.Size(45, 16)
        Me.lblPosStatus.TabIndex = 17
        Me.lblPosStatus.Text = "Status"
        Me.lblPosStatus.Visible = False
        '
        'cboDept
        '
        Me.cboDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDept.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDept.FormattingEnabled = True
        Me.cboDept.Items.AddRange(New Object() {"Accounting", "Purchasing", "Sales", "Marketing", "Finance", "Warehouse", "RS-Admin", "RS-Accounting", "ICT Services"})
        Me.cboDept.Location = New System.Drawing.Point(123, 98)
        Me.cboDept.Name = "cboDept"
        Me.cboDept.Size = New System.Drawing.Size(225, 28)
        Me.cboDept.TabIndex = 16
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnNew.Location = New System.Drawing.Point(292, 132)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(55, 30)
        Me.btnNew.TabIndex = 28
        Me.btnNew.Text = "&New"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'txtPosName
        '
        Me.txtPosName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPosName.Location = New System.Drawing.Point(123, 64)
        Me.txtPosName.Name = "txtPosName"
        Me.txtPosName.Size = New System.Drawing.Size(225, 26)
        Me.txtPosName.TabIndex = 15
        '
        'txtPosNo
        '
        Me.txtPosNo.Enabled = False
        Me.txtPosNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPosNo.Location = New System.Drawing.Point(123, 26)
        Me.txtPosNo.Name = "txtPosNo"
        Me.txtPosNo.ReadOnly = True
        Me.txtPosNo.Size = New System.Drawing.Size(70, 26)
        Me.txtPosNo.TabIndex = 14
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(31, 104)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(81, 16)
        Me.label5.TabIndex = 13
        Me.label5.Text = "Department:"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(18, 70)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(99, 16)
        Me.label4.TabIndex = 12
        Me.label4.Text = "Position Name:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(31, 34)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(75, 16)
        Me.label3.TabIndex = 11
        Me.label3.Text = "Position ID:"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(230, 132)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(56, 30)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(732, 547)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(87, 23)
        Me.btnClose.TabIndex = 25
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'MenuStrip3
        '
        Me.MenuStrip3.BackColor = System.Drawing.Color.Teal
        Me.MenuStrip3.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip3.Name = "MenuStrip3"
        Me.MenuStrip3.Size = New System.Drawing.Size(831, 24)
        Me.MenuStrip3.TabIndex = 32
        Me.MenuStrip3.Text = "MenuStrip3"
        '
        'lvwEmployee
        '
        Me.lvwEmployee.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colEmpno, Me.colNameEmp, Me.colDateHired})
        Me.lvwEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwEmployee.FullRowSelect = True
        Me.lvwEmployee.GridLines = True
        Me.lvwEmployee.Location = New System.Drawing.Point(456, 64)
        Me.lvwEmployee.Name = "lvwEmployee"
        Me.lvwEmployee.Size = New System.Drawing.Size(365, 474)
        Me.lvwEmployee.TabIndex = 33
        Me.lvwEmployee.UseCompatibleStateImageBehavior = False
        Me.lvwEmployee.View = System.Windows.Forms.View.Details
        '
        'colEmpno
        '
        Me.colEmpno.Text = "Emp No."
        '
        'colNameEmp
        '
        Me.colNameEmp.Text = "Name"
        Me.colNameEmp.Width = 200
        '
        'colDateHired
        '
        Me.colDateHired.Text = "Date Hired"
        Me.colDateHired.Width = 200
        '
        'lblListEmp
        '
        Me.lblListEmp.AutoSize = True
        Me.lblListEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListEmp.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblListEmp.Location = New System.Drawing.Point(459, 37)
        Me.lblListEmp.Name = "lblListEmp"
        Me.lblListEmp.Size = New System.Drawing.Size(242, 20)
        Me.lblListEmp.TabIndex = 34
        Me.lblListEmp.Text = "List of Employee per Position"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Location = New System.Drawing.Point(177, 545)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(37, 23)
        Me.btnDelete.TabIndex = 35
        Me.btnDelete.Text = "OK"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(19, 547)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(157, 20)
        Me.CheckBox1.TabIndex = 36
        Me.CheckBox1.Text = "Check Items to Delete"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'frmPosition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(831, 578)
        Me.ControlBox = False
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.lblListEmp)
        Me.Controls.Add(Me.lvwEmployee)
        Me.Controls.Add(Me.MenuStrip3)
        Me.Controls.Add(Me.panel3)
        Me.Controls.Add(Me.grpPos)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPosition"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POSITION"
        Me.panel3.ResumeLayout(False)
        Me.grpPos.ResumeLayout(False)
        Me.grpPos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents panel3 As System.Windows.Forms.Panel
    Private WithEvents lvwPos As System.Windows.Forms.ListView
    Private WithEvents grpPos As System.Windows.Forms.GroupBox
    Private WithEvents cboDept As System.Windows.Forms.ComboBox
    Private WithEvents txtPosName As System.Windows.Forms.TextBox
    Private WithEvents txtPosNo As System.Windows.Forms.TextBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents btnSave As System.Windows.Forms.Button
    Private WithEvents btnNew As System.Windows.Forms.Button
    Private WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents MenuStrip3 As System.Windows.Forms.MenuStrip
    Friend WithEvents lblPosStatus As System.Windows.Forms.Label
    Friend WithEvents colID As System.Windows.Forms.ColumnHeader
    Friend WithEvents colName As System.Windows.Forms.ColumnHeader
    Friend WithEvents colDepartment As System.Windows.Forms.ColumnHeader
    Private WithEvents lvwEmployee As System.Windows.Forms.ListView
    Friend WithEvents colEmpno As System.Windows.Forms.ColumnHeader
    Friend WithEvents colNameEmp As System.Windows.Forms.ColumnHeader
    Friend WithEvents colDateHired As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblListEmp As System.Windows.Forms.Label
    Private WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
