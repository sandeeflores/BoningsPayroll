<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployee
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
        Me.grpEmp = New System.Windows.Forms.GroupBox
        Me.txtEmpNo = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.btnDELETE = New System.Windows.Forms.Button
        Me.btnSve = New System.Windows.Forms.Button
        Me.btnEDIT = New System.Windows.Forms.Button
        Me.cboDepartment = New System.Windows.Forms.ComboBox
        Me.btnUpload = New System.Windows.Forms.Button
        Me.btnNEW = New System.Windows.Forms.Button
        Me.label36 = New System.Windows.Forms.Label
        Me.dtpHired = New System.Windows.Forms.DateTimePicker
        Me.cboPos = New System.Windows.Forms.ComboBox
        Me.label13 = New System.Windows.Forms.Label
        Me.txtRate = New System.Windows.Forms.TextBox
        Me.label11 = New System.Windows.Forms.Label
        Me.label10 = New System.Windows.Forms.Label
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.label9 = New System.Windows.Forms.Label
        Me.dtpBdate = New System.Windows.Forms.DateTimePicker
        Me.label8 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.cboGender = New System.Windows.Forms.ComboBox
        Me.label7 = New System.Windows.Forms.Label
        Me.picPhoto = New System.Windows.Forms.PictureBox
        Me.label6 = New System.Windows.Forms.Label
        Me.txtMname = New System.Windows.Forms.TextBox
        Me.label5 = New System.Windows.Forms.Label
        Me.label4 = New System.Windows.Forms.Label
        Me.txtFname = New System.Windows.Forms.TextBox
        Me.txtLname = New System.Windows.Forms.TextBox
        Me.lblName = New System.Windows.Forms.Label
        Me.label3 = New System.Windows.Forms.Label
        Me.tabControl1 = New System.Windows.Forms.TabControl
        Me.tabPage1 = New System.Windows.Forms.TabPage
        Me.label17 = New System.Windows.Forms.Label
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.txtCellPhone = New System.Windows.Forms.TextBox
        Me.label16 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtRefName = New System.Windows.Forms.TextBox
        Me.panel2 = New System.Windows.Forms.Panel
        Me.Label67 = New System.Windows.Forms.Label
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.Label68 = New System.Windows.Forms.Label
        Me.lvwEmpList = New System.Windows.Forms.ListView
        Me.columnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.columnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.columnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.MenuStrip3 = New System.Windows.Forms.MenuStrip
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.RadioButton6 = New System.Windows.Forms.RadioButton
        Me.RadioButton5 = New System.Windows.Forms.RadioButton
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.grpEmp.SuspendLayout()
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabControl1.SuspendLayout()
        Me.tabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpEmp
        '
        Me.grpEmp.BackColor = System.Drawing.Color.LightGray
        Me.grpEmp.Controls.Add(Me.Panel1)
        Me.grpEmp.Controls.Add(Me.txtEmpNo)
        Me.grpEmp.Controls.Add(Me.Button2)
        Me.grpEmp.Controls.Add(Me.btnDELETE)
        Me.grpEmp.Controls.Add(Me.btnSve)
        Me.grpEmp.Controls.Add(Me.btnEDIT)
        Me.grpEmp.Controls.Add(Me.cboDepartment)
        Me.grpEmp.Controls.Add(Me.btnUpload)
        Me.grpEmp.Controls.Add(Me.btnNEW)
        Me.grpEmp.Controls.Add(Me.label36)
        Me.grpEmp.Controls.Add(Me.dtpHired)
        Me.grpEmp.Controls.Add(Me.cboPos)
        Me.grpEmp.Controls.Add(Me.label13)
        Me.grpEmp.Controls.Add(Me.txtRate)
        Me.grpEmp.Controls.Add(Me.label11)
        Me.grpEmp.Controls.Add(Me.label10)
        Me.grpEmp.Controls.Add(Me.txtAddress)
        Me.grpEmp.Controls.Add(Me.label9)
        Me.grpEmp.Controls.Add(Me.dtpBdate)
        Me.grpEmp.Controls.Add(Me.label8)
        Me.grpEmp.Controls.Add(Me.btnSave)
        Me.grpEmp.Controls.Add(Me.cboGender)
        Me.grpEmp.Controls.Add(Me.label7)
        Me.grpEmp.Controls.Add(Me.picPhoto)
        Me.grpEmp.Controls.Add(Me.label6)
        Me.grpEmp.Controls.Add(Me.txtMname)
        Me.grpEmp.Controls.Add(Me.label5)
        Me.grpEmp.Controls.Add(Me.label4)
        Me.grpEmp.Controls.Add(Me.txtFname)
        Me.grpEmp.Controls.Add(Me.txtLname)
        Me.grpEmp.Controls.Add(Me.lblName)
        Me.grpEmp.Controls.Add(Me.label3)
        Me.grpEmp.Controls.Add(Me.tabControl1)
        Me.grpEmp.Location = New System.Drawing.Point(5, 35)
        Me.grpEmp.Name = "grpEmp"
        Me.grpEmp.Size = New System.Drawing.Size(619, 583)
        Me.grpEmp.TabIndex = 1
        Me.grpEmp.TabStop = False
        Me.grpEmp.Text = "Employee Information"
        '
        'txtEmpNo
        '
        Me.txtEmpNo.Location = New System.Drawing.Point(99, 21)
        Me.txtEmpNo.Name = "txtEmpNo"
        Me.txtEmpNo.Size = New System.Drawing.Size(90, 20)
        Me.txtEmpNo.TabIndex = 37
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(526, 547)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 27)
        Me.Button2.TabIndex = 36
        Me.Button2.Text = "&CLOSE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnDELETE
        '
        Me.btnDELETE.Location = New System.Drawing.Point(287, 547)
        Me.btnDELETE.Name = "btnDELETE"
        Me.btnDELETE.Size = New System.Drawing.Size(83, 27)
        Me.btnDELETE.TabIndex = 15
        Me.btnDELETE.Text = "&DELETE"
        Me.btnDELETE.UseVisualStyleBackColor = True
        '
        'btnSve
        '
        Me.btnSve.Location = New System.Drawing.Point(110, 547)
        Me.btnSve.Name = "btnSve"
        Me.btnSve.Size = New System.Drawing.Size(83, 27)
        Me.btnSve.TabIndex = 17
        Me.btnSve.Text = "&SAVE"
        Me.btnSve.UseVisualStyleBackColor = True
        '
        'btnEDIT
        '
        Me.btnEDIT.Location = New System.Drawing.Point(198, 547)
        Me.btnEDIT.Name = "btnEDIT"
        Me.btnEDIT.Size = New System.Drawing.Size(83, 27)
        Me.btnEDIT.TabIndex = 13
        Me.btnEDIT.Text = "&EDIT"
        Me.btnEDIT.UseVisualStyleBackColor = True
        '
        'cboDepartment
        '
        Me.cboDepartment.FormattingEnabled = True
        Me.cboDepartment.Location = New System.Drawing.Point(100, 197)
        Me.cboDepartment.Name = "cboDepartment"
        Me.cboDepartment.Size = New System.Drawing.Size(200, 21)
        Me.cboDepartment.TabIndex = 35
        '
        'btnUpload
        '
        Me.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpload.Location = New System.Drawing.Point(476, 132)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(114, 23)
        Me.btnUpload.TabIndex = 33
        Me.btnUpload.Text = "Upload photo"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'btnNEW
        '
        Me.btnNEW.Location = New System.Drawing.Point(15, 547)
        Me.btnNEW.Name = "btnNEW"
        Me.btnNEW.Size = New System.Drawing.Size(83, 27)
        Me.btnNEW.TabIndex = 14
        Me.btnNEW.Text = "&NEW"
        Me.btnNEW.UseVisualStyleBackColor = True
        '
        'label36
        '
        Me.label36.AutoSize = True
        Me.label36.Location = New System.Drawing.Point(12, 508)
        Me.label36.Name = "label36"
        Me.label36.Size = New System.Drawing.Size(61, 13)
        Me.label36.TabIndex = 32
        Me.label36.Text = "Date Hired:"
        '
        'dtpHired
        '
        Me.dtpHired.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHired.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.dtpHired.Location = New System.Drawing.Point(94, 502)
        Me.dtpHired.Name = "dtpHired"
        Me.dtpHired.Size = New System.Drawing.Size(228, 20)
        Me.dtpHired.TabIndex = 31
        '
        'cboPos
        '
        Me.cboPos.FormattingEnabled = True
        Me.cboPos.Location = New System.Drawing.Point(100, 235)
        Me.cboPos.Name = "cboPos"
        Me.cboPos.Size = New System.Drawing.Size(200, 21)
        Me.cboPos.TabIndex = 28
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Location = New System.Drawing.Point(7, 243)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(67, 13)
        Me.label13.TabIndex = 27
        Me.label13.Text = "Job Position:"
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(398, 195)
        Me.txtRate.Multiline = True
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(113, 20)
        Me.txtRate.TabIndex = 26
        Me.txtRate.Text = "0.00"
        Me.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Location = New System.Drawing.Point(6, 197)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(65, 13)
        Me.label11.TabIndex = 24
        Me.label11.Text = "Department:"
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(318, 198)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(75, 13)
        Me.label10.TabIndex = 23
        Me.label10.Text = "Daily Rate :  P"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(99, 150)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(319, 34)
        Me.txtAddress.TabIndex = 22
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(7, 150)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(48, 13)
        Me.label9.TabIndex = 21
        Me.label9.Text = "Address:"
        '
        'dtpBdate
        '
        Me.dtpBdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBdate.Location = New System.Drawing.Point(99, 118)
        Me.dtpBdate.Name = "dtpBdate"
        Me.dtpBdate.Size = New System.Drawing.Size(200, 20)
        Me.dtpBdate.TabIndex = 20
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(7, 118)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(55, 13)
        Me.label8.TabIndex = 19
        Me.label8.Text = "Birthdate: "
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Location = New System.Drawing.Point(540, 617)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(87, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'cboGender
        '
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboGender.Location = New System.Drawing.Point(99, 87)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(91, 21)
        Me.cboGender.TabIndex = 18
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(7, 87)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(45, 13)
        Me.label7.TabIndex = 17
        Me.label7.Text = "Gender:"
        '
        'picPhoto
        '
        Me.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPhoto.Location = New System.Drawing.Point(460, 19)
        Me.picPhoto.Name = "picPhoto"
        Me.picPhoto.Size = New System.Drawing.Size(141, 107)
        Me.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPhoto.TabIndex = 10
        Me.picPhoto.TabStop = False
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(296, 70)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(67, 13)
        Me.label6.TabIndex = 16
        Me.label6.Text = "Middle name"
        '
        'txtMname
        '
        Me.txtMname.Location = New System.Drawing.Point(299, 47)
        Me.txtMname.Multiline = True
        Me.txtMname.Name = "txtMname"
        Me.txtMname.Size = New System.Drawing.Size(94, 20)
        Me.txtMname.TabIndex = 15
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(196, 70)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(57, 13)
        Me.label5.TabIndex = 14
        Me.label5.Text = "First Name"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(96, 70)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(56, 13)
        Me.label4.TabIndex = 13
        Me.label4.Text = "Last name"
        '
        'txtFname
        '
        Me.txtFname.Location = New System.Drawing.Point(199, 47)
        Me.txtFname.Multiline = True
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(94, 20)
        Me.txtFname.TabIndex = 12
        '
        'txtLname
        '
        Me.txtLname.Location = New System.Drawing.Point(99, 47)
        Me.txtLname.Multiline = True
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(91, 20)
        Me.txtLname.TabIndex = 11
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(7, 47)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 10
        Me.lblName.Text = "Name:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(7, 27)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(73, 13)
        Me.label3.TabIndex = 9
        Me.label3.Text = "Employee No."
        '
        'tabControl1
        '
        Me.tabControl1.Controls.Add(Me.tabPage1)
        Me.tabControl1.Controls.Add(Me.TabPage2)
        Me.tabControl1.Location = New System.Drawing.Point(8, 277)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(605, 217)
        Me.tabControl1.TabIndex = 2
        '
        'tabPage1
        '
        Me.tabPage1.BackColor = System.Drawing.Color.LightGray
        Me.tabPage1.Controls.Add(Me.label17)
        Me.tabPage1.Controls.Add(Me.txtEmail)
        Me.tabPage1.Controls.Add(Me.txtCellPhone)
        Me.tabPage1.Controls.Add(Me.label16)
        Me.tabPage1.Location = New System.Drawing.Point(4, 22)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage1.Size = New System.Drawing.Size(597, 191)
        Me.tabPage1.TabIndex = 6
        Me.tabPage1.Text = "Contact:"
        '
        'label17
        '
        Me.label17.AutoSize = True
        Me.label17.Location = New System.Drawing.Point(8, 59)
        Me.label17.Name = "label17"
        Me.label17.Size = New System.Drawing.Size(57, 13)
        Me.label17.TabIndex = 35
        Me.label17.Text = "Email Add:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(117, 52)
        Me.txtEmail.Multiline = True
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(152, 20)
        Me.txtEmail.TabIndex = 34
        '
        'txtCellPhone
        '
        Me.txtCellPhone.Location = New System.Drawing.Point(117, 16)
        Me.txtCellPhone.MaxLength = 11
        Me.txtCellPhone.Multiline = True
        Me.txtCellPhone.Name = "txtCellPhone"
        Me.txtCellPhone.Size = New System.Drawing.Size(152, 20)
        Me.txtCellPhone.TabIndex = 33
        '
        'label16
        '
        Me.label16.AutoSize = True
        Me.label16.Location = New System.Drawing.Point(8, 23)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(64, 13)
        Me.label16.TabIndex = 32
        Me.label16.Text = "Mobile No. :"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.txtRefName)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(597, 191)
        Me.TabPage2.TabIndex = 7
        Me.TabPage2.Text = "Referred by : "
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(36, 35)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(44, 13)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "Name : "
        '
        'txtRefName
        '
        Me.txtRefName.Location = New System.Drawing.Point(88, 35)
        Me.txtRefName.MaxLength = 11
        Me.txtRefName.Multiline = True
        Me.txtRefName.Name = "txtRefName"
        Me.txtRefName.Size = New System.Drawing.Size(274, 20)
        Me.txtRefName.TabIndex = 34
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.LightGray
        Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel2.Controls.Add(Me.Label67)
        Me.panel2.Controls.Add(Me.RadioButton2)
        Me.panel2.Controls.Add(Me.RadioButton1)
        Me.panel2.Controls.Add(Me.txtSearch)
        Me.panel2.Controls.Add(Me.Label68)
        Me.panel2.Controls.Add(Me.lvwEmpList)
        Me.panel2.Location = New System.Drawing.Point(636, 35)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(406, 581)
        Me.panel2.TabIndex = 12
        '
        'Label67
        '
        Me.Label67.BackColor = System.Drawing.Color.LightGray
        Me.Label67.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.Location = New System.Drawing.Point(9, 71)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(383, 22)
        Me.Label67.TabIndex = 10
        Me.Label67.Text = "Employee List"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(137, 21)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(53, 17)
        Me.RadioButton2.TabIndex = 7
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Name"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(79, 21)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(42, 17)
        Me.RadioButton1.TabIndex = 6
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "I.D."
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(79, 43)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(313, 20)
        Me.txtSearch.TabIndex = 5
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Location = New System.Drawing.Point(15, 21)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(58, 13)
        Me.Label68.TabIndex = 4
        Me.Label68.Text = "Search by:"
        '
        'lvwEmpList
        '
        Me.lvwEmpList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader1, Me.columnHeader2, Me.columnHeader3})
        Me.lvwEmpList.FullRowSelect = True
        Me.lvwEmpList.GridLines = True
        Me.lvwEmpList.Location = New System.Drawing.Point(12, 96)
        Me.lvwEmpList.Name = "lvwEmpList"
        Me.lvwEmpList.Size = New System.Drawing.Size(380, 477)
        Me.lvwEmpList.TabIndex = 3
        Me.lvwEmpList.UseCompatibleStateImageBehavior = False
        Me.lvwEmpList.View = System.Windows.Forms.View.Details
        '
        'columnHeader1
        '
        Me.columnHeader1.Text = "No"
        Me.columnHeader1.Width = 33
        '
        'columnHeader2
        '
        Me.columnHeader2.Text = "Emp. No."
        Me.columnHeader2.Width = 70
        '
        'columnHeader3
        '
        Me.columnHeader3.Text = "Name"
        Me.columnHeader3.Width = 264
        '
        'MenuStrip3
        '
        Me.MenuStrip3.BackColor = System.Drawing.Color.Teal
        Me.MenuStrip3.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip3.Name = "MenuStrip3"
        Me.MenuStrip3.Size = New System.Drawing.Size(1054, 24)
        Me.MenuStrip3.TabIndex = 16
        Me.MenuStrip3.Text = "MenuStrip3"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.RadioButton6)
        Me.Panel1.Controls.Add(Me.RadioButton5)
        Me.Panel1.Controls.Add(Me.RadioButton4)
        Me.Panel1.Controls.Add(Me.RadioButton3)
        Me.Panel1.Location = New System.Drawing.Point(329, 226)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(276, 56)
        Me.Panel1.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Performance"
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(215, 25)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(47, 17)
        Me.RadioButton6.TabIndex = 46
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "Poor"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(167, 25)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(42, 17)
        Me.RadioButton5.TabIndex = 45
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "Fair"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(84, 24)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(80, 17)
        Me.RadioButton4.TabIndex = 44
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Satisfactory"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(14, 24)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(68, 17)
        Me.RadioButton3.TabIndex = 43
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Excellent"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'frmEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1054, 628)
        Me.Controls.Add(Me.MenuStrip3)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.grpEmp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee"
        Me.grpEmp.ResumeLayout(False)
        Me.grpEmp.PerformLayout()
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabControl1.ResumeLayout(False)
        Me.tabPage1.ResumeLayout(False)
        Me.tabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents grpEmp As System.Windows.Forms.GroupBox
    Private WithEvents btnUpload As System.Windows.Forms.Button
    Private WithEvents label36 As System.Windows.Forms.Label
    Private WithEvents dtpHired As System.Windows.Forms.DateTimePicker
    Private WithEvents cboPos As System.Windows.Forms.ComboBox
    Private WithEvents label13 As System.Windows.Forms.Label
    Private WithEvents txtRate As System.Windows.Forms.TextBox
    Private WithEvents label10 As System.Windows.Forms.Label
    Private WithEvents txtAddress As System.Windows.Forms.TextBox
    Private WithEvents label9 As System.Windows.Forms.Label
    Private WithEvents dtpBdate As System.Windows.Forms.DateTimePicker
    Private WithEvents label8 As System.Windows.Forms.Label
    Private WithEvents btnSave As System.Windows.Forms.Button
    Private WithEvents cboGender As System.Windows.Forms.ComboBox
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents picPhoto As System.Windows.Forms.PictureBox
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents txtMname As System.Windows.Forms.TextBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents txtFname As System.Windows.Forms.TextBox
    Private WithEvents txtLname As System.Windows.Forms.TextBox
    Private WithEvents lblName As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents tabControl1 As System.Windows.Forms.TabControl
    Private WithEvents tabPage1 As System.Windows.Forms.TabPage
    Private WithEvents label17 As System.Windows.Forms.Label
    Private WithEvents txtEmail As System.Windows.Forms.TextBox
    Private WithEvents txtCellPhone As System.Windows.Forms.TextBox
    Private WithEvents label16 As System.Windows.Forms.Label
    Private WithEvents cboDepartment As System.Windows.Forms.ComboBox
    Private WithEvents label11 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Private WithEvents Label67 As System.Windows.Forms.Label
    Private WithEvents lvwEmpList As System.Windows.Forms.ListView
    Private WithEvents columnHeader1 As System.Windows.Forms.ColumnHeader
    Private WithEvents columnHeader2 As System.Windows.Forms.ColumnHeader
    Private WithEvents columnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnEDIT As System.Windows.Forms.Button
    Friend WithEvents btnNEW As System.Windows.Forms.Button
    Friend WithEvents btnDELETE As System.Windows.Forms.Button
    Friend WithEvents btnSve As System.Windows.Forms.Button
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Private WithEvents txtRefName As System.Windows.Forms.TextBox
    Private WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip3 As System.Windows.Forms.MenuStrip
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtEmpNo As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton

End Class
