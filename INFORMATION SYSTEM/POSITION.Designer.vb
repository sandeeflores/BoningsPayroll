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
        Me.groupBox3 = New System.Windows.Forms.GroupBox
        Me.txtPosSearch = New System.Windows.Forms.TextBox
        Me.lvwPos = New System.Windows.Forms.ListView
        Me.columnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.columnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.columnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.columnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.grpPos = New System.Windows.Forms.GroupBox
        Me.cboDept = New System.Windows.Forms.ComboBox
        Me.txtPosName = New System.Windows.Forms.TextBox
        Me.txtPosNo = New System.Windows.Forms.TextBox
        Me.label5 = New System.Windows.Forms.Label
        Me.label4 = New System.Windows.Forms.Label
        Me.label3 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnNew = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnView = New System.Windows.Forms.Button
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
        Me.grpPos.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel3
        '
        Me.panel3.BackColor = System.Drawing.Color.LightGray
        Me.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel3.Controls.Add(Me.groupBox3)
        Me.panel3.Controls.Add(Me.lvwPos)
        Me.panel3.Location = New System.Drawing.Point(13, 198)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(539, 371)
        Me.panel3.TabIndex = 21
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.txtPosSearch)
        Me.groupBox3.Location = New System.Drawing.Point(20, 18)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(321, 60)
        Me.groupBox3.TabIndex = 8
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Position Information"
        '
        'txtPosSearch
        '
        Me.txtPosSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPosSearch.Location = New System.Drawing.Point(25, 19)
        Me.txtPosSearch.Multiline = True
        Me.txtPosSearch.Name = "txtPosSearch"
        Me.txtPosSearch.Size = New System.Drawing.Size(270, 27)
        Me.txtPosSearch.TabIndex = 16
        '
        'lvwPos
        '
        Me.lvwPos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader9, Me.columnHeader10, Me.columnHeader11, Me.columnHeader12})
        Me.lvwPos.FullRowSelect = True
        Me.lvwPos.GridLines = True
        Me.lvwPos.Location = New System.Drawing.Point(20, 84)
        Me.lvwPos.Name = "lvwPos"
        Me.lvwPos.Size = New System.Drawing.Size(489, 257)
        Me.lvwPos.TabIndex = 8
        Me.lvwPos.UseCompatibleStateImageBehavior = False
        Me.lvwPos.View = System.Windows.Forms.View.Details
        '
        'columnHeader9
        '
        Me.columnHeader9.Text = "No."
        Me.columnHeader9.Width = 41
        '
        'columnHeader10
        '
        Me.columnHeader10.Text = "Position No."
        Me.columnHeader10.Width = 82
        '
        'columnHeader11
        '
        Me.columnHeader11.Text = "Position Name"
        Me.columnHeader11.Width = 119
        '
        'columnHeader12
        '
        Me.columnHeader12.Text = "Department"
        Me.columnHeader12.Width = 217
        '
        'grpPos
        '
        Me.grpPos.BackColor = System.Drawing.Color.LightGray
        Me.grpPos.Controls.Add(Me.cboDept)
        Me.grpPos.Controls.Add(Me.txtPosName)
        Me.grpPos.Controls.Add(Me.txtPosNo)
        Me.grpPos.Controls.Add(Me.label5)
        Me.grpPos.Controls.Add(Me.label4)
        Me.grpPos.Controls.Add(Me.label3)
        Me.grpPos.Controls.Add(Me.btnSave)
        Me.grpPos.Location = New System.Drawing.Point(13, 38)
        Me.grpPos.Name = "grpPos"
        Me.grpPos.Size = New System.Drawing.Size(539, 154)
        Me.grpPos.TabIndex = 20
        Me.grpPos.TabStop = False
        Me.grpPos.Text = "Position Information"
        '
        'cboDept
        '
        Me.cboDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDept.FormattingEnabled = True
        Me.cboDept.Location = New System.Drawing.Point(117, 98)
        Me.cboDept.Name = "cboDept"
        Me.cboDept.Size = New System.Drawing.Size(225, 21)
        Me.cboDept.TabIndex = 16
        '
        'txtPosName
        '
        Me.txtPosName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPosName.Location = New System.Drawing.Point(117, 62)
        Me.txtPosName.Name = "txtPosName"
        Me.txtPosName.Size = New System.Drawing.Size(132, 20)
        Me.txtPosName.TabIndex = 15
        '
        'txtPosNo
        '
        Me.txtPosNo.Enabled = False
        Me.txtPosNo.Location = New System.Drawing.Point(117, 26)
        Me.txtPosNo.Name = "txtPosNo"
        Me.txtPosNo.ReadOnly = True
        Me.txtPosNo.Size = New System.Drawing.Size(70, 20)
        Me.txtPosNo.TabIndex = 14
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(18, 106)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(65, 13)
        Me.label5.TabIndex = 13
        Me.label5.Text = "Department:"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(18, 70)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(78, 13)
        Me.label4.TabIndex = 12
        Me.label4.Text = "Position Name:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(18, 29)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(64, 13)
        Me.label3.TabIndex = 11
        Me.label3.Text = "Position No."
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(423, 96)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(87, 23)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Location = New System.Drawing.Point(13, 589)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(87, 23)
        Me.btnNew.TabIndex = 28
        Me.btnNew.Text = "&New"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Location = New System.Drawing.Point(106, 589)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(87, 23)
        Me.btnEdit.TabIndex = 27
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Location = New System.Drawing.Point(292, 589)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(87, 23)
        Me.btnDelete.TabIndex = 26
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(465, 589)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(87, 23)
        Me.btnClose.TabIndex = 25
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnView.Location = New System.Drawing.Point(199, 589)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(87, 23)
        Me.btnView.TabIndex = 24
        Me.btnView.Text = "&View"
        Me.btnView.UseVisualStyleBackColor = False
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.LightGray
        Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel2.Controls.Add(Me.label12)
        Me.panel2.Controls.Add(Me.groupBox2)
        Me.panel2.Controls.Add(Me.lvwEmpList)
        Me.panel2.Location = New System.Drawing.Point(558, 38)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(432, 531)
        Me.panel2.TabIndex = 30
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
        Me.lvwEmpList.Size = New System.Drawing.Size(393, 384)
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
        Me.columnHeader2.Text = "Emp-no"
        Me.columnHeader2.Width = 57
        '
        'columnHeader3
        '
        Me.columnHeader3.Text = "Name"
        Me.columnHeader3.Width = 226
        '
        'MenuStrip3
        '
        Me.MenuStrip3.BackColor = System.Drawing.Color.Teal
        Me.MenuStrip3.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip3.Name = "MenuStrip3"
        Me.MenuStrip3.Size = New System.Drawing.Size(999, 24)
        Me.MenuStrip3.TabIndex = 32
        Me.MenuStrip3.Text = "MenuStrip3"
        '
        'frmPosition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(999, 624)
        Me.ControlBox = False
        Me.Controls.Add(Me.MenuStrip3)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.panel3)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.grpPos)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPosition"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POSITION"
        Me.panel3.ResumeLayout(False)
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        Me.grpPos.ResumeLayout(False)
        Me.grpPos.PerformLayout()
        Me.panel2.ResumeLayout(False)
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents panel3 As System.Windows.Forms.Panel
    Private WithEvents groupBox3 As System.Windows.Forms.GroupBox
    Private WithEvents lvwPos As System.Windows.Forms.ListView
    Private WithEvents columnHeader9 As System.Windows.Forms.ColumnHeader
    Private WithEvents columnHeader10 As System.Windows.Forms.ColumnHeader
    Private WithEvents columnHeader11 As System.Windows.Forms.ColumnHeader
    Private WithEvents columnHeader12 As System.Windows.Forms.ColumnHeader
    Private WithEvents grpPos As System.Windows.Forms.GroupBox
    Private WithEvents cboDept As System.Windows.Forms.ComboBox
    Private WithEvents txtPosName As System.Windows.Forms.TextBox
    Private WithEvents txtPosNo As System.Windows.Forms.TextBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents btnSave As System.Windows.Forms.Button
    Private WithEvents btnNew As System.Windows.Forms.Button
    Private WithEvents btnEdit As System.Windows.Forms.Button
    Private WithEvents btnDelete As System.Windows.Forms.Button
    Private WithEvents btnClose As System.Windows.Forms.Button
    Private WithEvents btnView As System.Windows.Forms.Button
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
    Friend WithEvents MenuStrip3 As System.Windows.Forms.MenuStrip
    Private WithEvents txtPosSearch As System.Windows.Forms.TextBox
End Class
