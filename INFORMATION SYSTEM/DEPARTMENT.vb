Imports System.Data.SqlClient
Public Class frmDepartment
    Public IsUpdate As Boolean

    Public ItemToBeEdited As Integer
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub
    Private Sub DEPARTMENT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtDeptCode.Enabled = False
        txtName.Enabled = False
        CLEAR()
        btnSave.Enabled = False
        LoadAllDepartment()
    End Sub

    Private Sub CLEAR()
        txtDeptCode.Text = ""
        txtName.Text = ""
        lvwEmpList.Items.Clear()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnSave.Enabled = True
        txtDeptCode.Focus()
        txtDeptCode.Enabled = True
        txtName.Enabled = True
        CLEAR()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        btnSave.Enabled = False
        btnAdd.Enabled = True
        btnEdit.Enabled = True
        If txtDeptCode.Text.Trim = String.Empty _
            And txtName.Text.Trim = String.Empty Then
            MsgBox("Please fill all the required fields.")
            txtDeptCode.Focus()
            Exit Sub
        End If
        Try
            Dim msg As String
            'OpenConnection()
            ''SET UP SQL COMMAND
            'Dim cmd As New SqlCommand
            'cmd.Connection = connBIS
            'cmd.CommandType = CommandType.StoredProcedure
            'cmd.CommandText = IIf(ifEdit, "UpdateDepartment", "SetDepartment")
            ''ADD PARAMETERS
            'cmd.Parameters.AddWithValue("@dept_code", txtDeptCode.Text.Trim)
            'cmd.Parameters.AddWithValue("@dept_name", txtName.Text.Trim)

            'cmd.ExecuteNonQuery()
            'Dim msg As String = "Department is successfully " + IIf(ifEdit, "updated", "added")
            'MsgBox(msg)

            OpenConnection()
            Dim sqlText As String
            Dim cmd As New SqlCommand
            Dim dept_code As String = txtDeptCode.Text
            Dim dept_name As String = txtName.Text

            If IsUpdate = True Then
                sqlText = "UpdateDepartment"
                cmd.Parameters.AddWithValue("@dept_code", dept_code)
                msg = "You successfully update your department"
            Else
                sqlText = "SetDepartment"
                msg = "you successfully added your department"
            End If

            cmd.Connection = connBIS
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = sqlText


            cmd.Parameters.AddWithValue("@dept_code", dept_code)
            cmd.Parameters.AddWithValue("@dept_name", dept_name)

            dept_code = cmd.ExecuteScalar

            cmd.Dispose()
            CloseConnection()

            CLEAR()
            btnSave.Enabled = False
            LoadAllDepartment()

        Catch ex As Exception
            MsgBox("The Department inputted is already Exist")
            txtDeptCode.Focus()
            txtDeptCode.SelectAll()
        End Try

    End Sub

    Public Sub LoadDepartment()
        Dim dept_code As Integer = 0

        Dim search_text As String = txtDeptsSearchBox.Text.Trim

        OpenConnection()

        lvwDept.Items.Clear()

        Dim cmd As New SqlCommand
        cmd.Connection = connBIS
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "SelectedDepartment"

        'cmd.Parameters.AddWithValue("@position_id", position_id)
        'cmd.Parameters.AddWithValue("@dept_name", search_text)

        Dim dr As SqlDataReader = cmd.ExecuteReader

        Dim i As Integer = 0

        With lvwDept
            While dr.Read
                .Items.Add(Format(i + 1, "0000"))
                .Items(i).SubItems.Add(dr("dept_code"))
                .Items(i).SubItems.Add(dr("dept_name"))

                i += 1
            End While
        End With

        dr.Close()
        cmd.Dispose()
        CloseConnection()

    End Sub
    Private Sub LoadAllDepartment()
        lvwDept.Items.Clear()

        Dim dept_code As Integer = 0
        Dim search_text As String = txtDeptsSearchBox.Text.Trim

        OpenConnection()

        lvwDept.Items.Clear()


        Dim cmd As New SqlCommand
        cmd.Connection = connBIS
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "SelectAllDepartment"


        Dim dr As SqlDataReader = cmd.ExecuteReader
        Dim i As Integer = 0
        While dr.Read
            lvwDept.Items.Add(Format(i + 1, "0000"))
            lvwDept.Items(i).SubItems.Add(dr("dept_code"))
            lvwDept.Items(i).SubItems.Add(dr("dept_name"))
            i += 1
        End While

        dr.Close()
        cmd.Dispose()
        CloseConnection()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        'Check if there is a selected item in listview

        IsUpdate = True

        Dim item As ListViewItem = lvwDept.SelectedItems(0)

        Try


            If lvwDept.SelectedItems.Count = 0 Then Exit Sub
            'IsUpdate = True
            'frmOrder_details.txtCustomer.text = lvwCustList.SelectedItems(0).Text

            txtDeptCode.Text = lvwDept.SelectedItems(0).SubItems(1).Text
            txtName.Text = lvwDept.SelectedItems(0).SubItems(2).Text


            'frmOrder.txtCustomer.Text = lvwCustList.SelectedItems.Item(1).Text

        Catch ex As Exception

        End Try

        btnSave.Enabled = True
        txtDeptCode.Enabled = False
        txtName.Focus()
    End Sub


    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If lvwDept.SelectedItems.Count = 0 Then Exit Sub

        If MsgBox("This Department will be deleted permanently in the record." + vbCrLf + "Do you want to continue?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim dept_code As String = lvwDept.SelectedItems(0).SubItems(1).Text


        OpenConnection()
        Dim cmd As New SqlCommand
        cmd.Connection = connBIS
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "DeleteDepartment"
        cmd.Parameters.AddWithValue("@dept_code", dept_code)

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        CloseConnection()
        MsgBox("Department is successfully deleted.")
        LoadAllDepartment()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub



    Private Sub txtDeptsSearchBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDeptsSearchBox.TextChanged
        lvwDept.Items.Clear()
        If txtDeptsSearchBox.Text.Trim.Length > 0 Then LoadSearchDepartment() Else LoadAllDepartment()
    End Sub

    Public Sub LoadSearchDepartment()
        Dim dept_no As Integer = 0

        Dim search_text As String = txtDeptsSearchBox.Text.Trim

        OpenConnection()

        lvwDept.Items.Clear()

        Dim cmd As New SqlCommand
        cmd.Connection = connBIS
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "SearchDepartment"

        cmd.Parameters.AddWithValue("@dept_name", search_text)

        Dim dr As SqlDataReader = cmd.ExecuteReader

        Dim i As Integer = 0

        With lvwDept
            While dr.Read
                .Items.Add(Format(i + 1, "0000"))
                .Items(i).SubItems.Add(dr("dept_code"))
                .Items(i).SubItems.Add(dr("dept_name"))

                i += 1
            End While
        End With

        dr.Close()
        cmd.Dispose()
        CloseConnection()

    End Sub

    Private Sub lvwDept_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvwDept.MouseDoubleClick
        Try


            If lvwDept.SelectedItems.Count = 0 Then Exit Sub


            txtDeptCode.Text = lvwDept.SelectedItems(0).SubItems(1).Text
            txtName.Text = lvwDept.SelectedItems(0).SubItems(2).Text


        Catch ex As Exception

        End Try
        btnSave.Enabled = True
        txtDeptCode.Enabled = False
        txtName.Focus()
    End Sub

    Private Sub grpAdd_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpAdd.Enter

    End Sub
End Class