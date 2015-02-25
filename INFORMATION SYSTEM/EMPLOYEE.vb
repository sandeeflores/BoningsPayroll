Imports System.Data.SqlClient
Public Class frmEmployee
    Dim is_deleted As Boolean
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ClearField()
        'disable buttons not needed yet
        btnSave.Enabled = False
        btnEDIT.Enabled = False
        btnDELETE.Enabled = False
        btnSave.Enabled = False
        btnSve.Enabled = False
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnNEW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNEW.Click

        txtLname.Focus()
        ClearField()
        btnNEW.Enabled = False
        btnSve.Enabled = True

    End Sub

    Private Sub Label67_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label67.Click

    End Sub

    Private Sub grpEmp_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpEmp.Enter

    End Sub

    Private Sub label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles label16.Click

    End Sub

    Private Sub TextBox25_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRefName.TextChanged

    End Sub

    Private Sub LoadAllEmployee()

    End Sub


    Private Sub ClearField()
        txtAddress.Text = ""
        txtCellPhone.Text = ""
        txtEmail.Text = ""
        txtFname.Text = ""
        txtLname.Text = ""
        txtMname.Text = ""
        txtRefName.Text = ""
        txtRate.Text = ""
        lvwEmpList.Items.Clear()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub btnSve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSve.Click

        'CHECK THE REQUIRED FIELD

        Dim msg As String
        Dim i = lvwEmpList.Items.Count
        OpenConnection()
        Dim sqlText As String
        Dim cmd As New SqlCommand
        Dim employee_id As Int32 = 0
        Dim lastname As String = txtLname.Text
        Dim firstname As String = txtFname.Text
        Dim middlename As String = txtMname.Text
        Dim referred_by As String = txtRefName.Text
        Dim gender As String = cboGender.Text
        Dim address As String = txtAddress.Text
        Dim birthdate As String = dtpBdate.Text
        Dim dateHired As String = dtpHired.Text
        Dim position_id As String = cboPos.Text
        Dim daily_rate As String = txtRate.Text

        'If txtEmpNo.Text = String.Empty Then
        '    MsgBox("Please input Employee No.")
        '    txtEmpNo.Focus()
        '    Exit Sub
        'End If

        If txtLname.Text = String.Empty Then
            MsgBox("Please input Last name.")
            txtLname.Focus()
            Exit Sub
        End If

        If txtFname.Text = String.Empty Then
            MsgBox("Please input First name.")
            txtFname.Focus()
            Exit Sub
        End If

        If txtMname.Text = String.Empty Then
            MsgBox("Please input Middle name.")
            txtMname.Focus()
            Exit Sub
        End If

        If cboGender.Text = String.Empty Then
            MsgBox("Please select Gender.")
            cboGender.Focus()
            Exit Sub
        End If

        If txtAddress.Text = String.Empty Then
            MsgBox("Please input Address.")
            txtAddress.Focus()
            Exit Sub
        End If

        If cboDepartment.Text = String.Empty Then
            MsgBox("Please select Department.")
            cboDepartment.Focus()
            Exit Sub
        End If

        If cboPos.Text = String.Empty Then
            MsgBox("Please select Position.")
            cboPos.Focus()
            Exit Sub
        End If

        If txtRate.Text = String.Empty Then
            txtRate.Text = Format(Val(txtRate.Text), "###,##0.00")
            MsgBox("Please input Daily Rate.")
            txtRate.Focus()
            Exit Sub
        End If

        If txtCellPhone.Text = String.Empty Then
            MsgBox("Please input Mobile No.")
            txtCellPhone.Focus()
            Exit Sub
        End If

        If txtEmail.Text = String.Empty Then
            txtEmail.Text = "N/A"
            txtEmail.Focus()
            Exit Sub
        End If

        If txtRefName.Text = String.Empty Then
            txtRefName.Text = "N/A"
            txtRefName.Focus()
            Exit Sub
        End If

        


        cmd.Connection = connBIS
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sqlText"

        'save all the entries
        'cmd.Parameters.AddWithValue("@employee_id", employee_id) 
        cmd.Parameters.AddWithValue("@lastname", lastname)
        cmd.Parameters.AddWithValue("@firstname", firstname)
        cmd.Parameters.AddWithValue("@middlename", middlename)
        cmd.Parameters.AddWithValue("@referred_by", referred_by)
        cmd.Parameters.AddWithValue("@gender", gender)
        cmd.Parameters.AddWithValue("@address", address)
        cmd.Parameters.AddWithValue("@birthdate", birthdate)
        cmd.Parameters.AddWithValue("@dateHired", dateHired)
        cmd.Parameters.AddWithValue("@position_no", position_id)
        cmd.Parameters.AddWithValue("@is_deleted", is_deleted)
        cmd.Parameters.AddWithValue("@daily_rate", daily_rate)


        employee_id = Convert.ToInt32(cmd.ExecuteScalar())

        cmd.Dispose()
        CloseConnection()




        MsgBox(msg)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        btnNEW.Enabled = True

        Exit Sub

    End Sub

    Private Sub dtpBdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpBdate.ValueChanged

    End Sub

    Private Sub txtEmpNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
