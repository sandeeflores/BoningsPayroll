<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payroll
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
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.btnSavePaySlip = New System.Windows.Forms.Button
        Me.btnDeducSave = New System.Windows.Forms.Button
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtEmpNo = New System.Windows.Forms.TextBox
        Me.txtEmpName = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.DatePickEnd = New System.Windows.Forms.DateTimePicker
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.DatePickStart = New System.Windows.Forms.DateTimePicker
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TxtPhil = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.cboCAHistory = New System.Windows.Forms.ComboBox
        Me.TxtTotalDeductions = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtCA = New System.Windows.Forms.TextBox
        Me.TxtTax = New System.Windows.Forms.TextBox
        Me.TxtPagibig = New System.Windows.Forms.TextBox
        Me.TxtSSS = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.TxtNet = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtGross = New System.Windows.Forms.TextBox
        Me.TxtDaysWrk = New System.Windows.Forms.TextBox
        Me.TxtRateDay = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label24 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(6, 97)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(308, 285)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'btnSavePaySlip
        '
        Me.btnSavePaySlip.Location = New System.Drawing.Point(136, 130)
        Me.btnSavePaySlip.Name = "btnSavePaySlip"
        Me.btnSavePaySlip.Size = New System.Drawing.Size(64, 23)
        Me.btnSavePaySlip.TabIndex = 13
        Me.btnSavePaySlip.Text = "&Print"
        Me.btnSavePaySlip.UseVisualStyleBackColor = True
        '
        'btnDeducSave
        '
        Me.btnDeducSave.Location = New System.Drawing.Point(138, 218)
        Me.btnDeducSave.Name = "btnDeducSave"
        Me.btnDeducSave.Size = New System.Drawing.Size(64, 23)
        Me.btnDeducSave.TabIndex = 9
        Me.btnDeducSave.Text = "&Save"
        Me.btnDeducSave.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(12, 22)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(100, 16)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "Employee No.: "
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(234, 23)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(48, 16)
        Me.Label18.TabIndex = 29
        Me.Label18.Text = "Name:"
        '
        'txtEmpNo
        '
        Me.txtEmpNo.Location = New System.Drawing.Point(108, 22)
        Me.txtEmpNo.Name = "txtEmpNo"
        Me.txtEmpNo.Size = New System.Drawing.Size(76, 20)
        Me.txtEmpNo.TabIndex = 1
        '
        'txtEmpName
        '
        Me.txtEmpName.Location = New System.Drawing.Point(288, 22)
        Me.txtEmpName.Name = "txtEmpName"
        Me.txtEmpName.Size = New System.Drawing.Size(258, 20)
        Me.txtEmpName.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.DatePickEnd)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.DatePickStart)
        Me.GroupBox1.Controls.Add(Me.ListView1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(320, 417)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Coverage"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(139, 80)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(50, 13)
        Me.Label23.TabIndex = 35
        Me.Label23.Text = "Total Hrs"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(67, 80)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(50, 13)
        Me.Label22.TabIndex = 34
        Me.Label22.Text = "Time Out"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 80)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(42, 13)
        Me.Label21.TabIndex = 33
        Me.Label21.Text = "Time In"
        '
        'DatePickEnd
        '
        Me.DatePickEnd.Location = New System.Drawing.Point(161, 48)
        Me.DatePickEnd.Name = "DatePickEnd"
        Me.DatePickEnd.Size = New System.Drawing.Size(132, 20)
        Me.DatePickEnd.TabIndex = 4
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(200, 26)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(52, 13)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "End Date"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(38, 25)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(55, 13)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Start Date"
        '
        'DatePickStart
        '
        Me.DatePickStart.Location = New System.Drawing.Point(18, 49)
        Me.DatePickStart.Name = "DatePickStart"
        Me.DatePickStart.Size = New System.Drawing.Size(132, 20)
        Me.DatePickStart.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtPhil)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cboCAHistory)
        Me.GroupBox2.Controls.Add(Me.TxtTotalDeductions)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TxtCA)
        Me.GroupBox2.Controls.Add(Me.TxtTax)
        Me.GroupBox2.Controls.Add(Me.TxtPagibig)
        Me.GroupBox2.Controls.Add(Me.TxtSSS)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.btnDeducSave)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(336, 47)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(210, 251)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Deductions"
        '
        'TxtPhil
        '
        Me.TxtPhil.Location = New System.Drawing.Point(101, 78)
        Me.TxtPhil.Name = "TxtPhil"
        Me.TxtPhil.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtPhil.Size = New System.Drawing.Size(100, 20)
        Me.TxtPhil.TabIndex = 38
        Me.TxtPhil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(34, 84)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 13)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "PhilHealth: P"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 162)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "CA History: P"
        '
        'cboCAHistory
        '
        Me.cboCAHistory.FormattingEnabled = True
        Me.cboCAHistory.Location = New System.Drawing.Point(100, 159)
        Me.cboCAHistory.Name = "cboCAHistory"
        Me.cboCAHistory.Size = New System.Drawing.Size(102, 21)
        Me.cboCAHistory.TabIndex = 36
        '
        'TxtTotalDeductions
        '
        Me.TxtTotalDeductions.BackColor = System.Drawing.SystemColors.Info
        Me.TxtTotalDeductions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalDeductions.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtTotalDeductions.Location = New System.Drawing.Point(102, 190)
        Me.TxtTotalDeductions.Name = "TxtTotalDeductions"
        Me.TxtTotalDeductions.Size = New System.Drawing.Size(100, 21)
        Me.TxtTotalDeductions.TabIndex = 0
        Me.TxtTotalDeductions.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Total Deductns: P"
        '
        'TxtCA
        '
        Me.TxtCA.Location = New System.Drawing.Point(102, 132)
        Me.TxtCA.Name = "TxtCA"
        Me.TxtCA.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtCA.Size = New System.Drawing.Size(100, 20)
        Me.TxtCA.TabIndex = 8
        Me.TxtCA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTax
        '
        Me.TxtTax.Location = New System.Drawing.Point(102, 104)
        Me.TxtTax.Name = "TxtTax"
        Me.TxtTax.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtTax.Size = New System.Drawing.Size(100, 20)
        Me.TxtTax.TabIndex = 7
        Me.TxtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtPagibig
        '
        Me.TxtPagibig.Location = New System.Drawing.Point(102, 49)
        Me.TxtPagibig.Name = "TxtPagibig"
        Me.TxtPagibig.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtPagibig.Size = New System.Drawing.Size(100, 20)
        Me.TxtPagibig.TabIndex = 6
        Me.TxtPagibig.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtSSS
        '
        Me.TxtSSS.Location = New System.Drawing.Point(102, 22)
        Me.TxtSSS.Name = "TxtSSS"
        Me.TxtSSS.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtSSS.Size = New System.Drawing.Size(100, 20)
        Me.TxtSSS.TabIndex = 5
        Me.TxtSSS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Cash Advance: P"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "TAX: P"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "PagIbig: P"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "SSS: P"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxtNet)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.TxtGross)
        Me.GroupBox3.Controls.Add(Me.TxtDaysWrk)
        Me.GroupBox3.Controls.Add(Me.TxtRateDay)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.btnSavePaySlip)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Location = New System.Drawing.Point(336, 304)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(210, 160)
        Me.GroupBox3.TabIndex = 34
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "PAYSLIP/SALARY"
        '
        'TxtNet
        '
        Me.TxtNet.BackColor = System.Drawing.SystemColors.Info
        Me.TxtNet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNet.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtNet.Location = New System.Drawing.Point(100, 104)
        Me.TxtNet.Name = "TxtNet"
        Me.TxtNet.Size = New System.Drawing.Size(100, 21)
        Me.TxtNet.TabIndex = 0
        Me.TxtNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Total Net: P"
        '
        'TxtGross
        '
        Me.TxtGross.Location = New System.Drawing.Point(100, 76)
        Me.TxtGross.Name = "TxtGross"
        Me.TxtGross.Size = New System.Drawing.Size(100, 20)
        Me.TxtGross.TabIndex = 12
        Me.TxtGross.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDaysWrk
        '
        Me.TxtDaysWrk.Location = New System.Drawing.Point(100, 45)
        Me.TxtDaysWrk.Name = "TxtDaysWrk"
        Me.TxtDaysWrk.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtDaysWrk.Size = New System.Drawing.Size(100, 20)
        Me.TxtDaysWrk.TabIndex = 11
        Me.TxtDaysWrk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtRateDay
        '
        Me.TxtRateDay.Location = New System.Drawing.Point(100, 16)
        Me.TxtRateDay.Name = "TxtRateDay"
        Me.TxtRateDay.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtRateDay.Size = New System.Drawing.Size(100, 20)
        Me.TxtRateDay.TabIndex = 10
        Me.TxtRateDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(29, 79)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Total Gross: P"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "No. of Days Wrk: "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(36, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Rate/Day: P"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(188, 21)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(46, 23)
        Me.Button3.TabIndex = 35
        Me.Button3.Text = "Load"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(234, 80)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(49, 13)
        Me.Label24.TabIndex = 35
        Me.Label24.Text = "Remarks"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(63, 389)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox1.Size = New System.Drawing.Size(189, 20)
        Me.TextBox1.TabIndex = 37
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 393)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 13)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "Remark(s)"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(256, 388)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(58, 23)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Payroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 476)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtEmpName)
        Me.Controls.Add(Me.txtEmpNo)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Name = "Payroll"
        Me.Text = "Payroll"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents btnSavePaySlip As System.Windows.Forms.Button
    Friend WithEvents btnDeducSave As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtEmpNo As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpName As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DatePickEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents DatePickStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtTax As System.Windows.Forms.TextBox
    Friend WithEvents TxtPagibig As System.Windows.Forms.TextBox
    Friend WithEvents TxtSSS As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotalDeductions As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtCA As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtNet As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtGross As System.Windows.Forms.TextBox
    Friend WithEvents TxtDaysWrk As System.Windows.Forms.TextBox
    Friend WithEvents TxtRateDay As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboCAHistory As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TxtPhil As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
