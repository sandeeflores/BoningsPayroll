Imports System.Data.SqlClient
Public Class frmPosition
    Public pos_id As Integer
    Dim ifEdit As Boolean
    'Dim DicDepartment As New Dictionary(Of String, String)
    Dim DicPosition As New Dictionary(Of String, String)
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub


    Private Sub FillDepartment()

        OpenConnection()
        Dim cmd As New SqlCommand
        cmd.Connection = connBIS
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "DepartmentShowAll"

        Dim dr As SqlDataReader = cmd.ExecuteReader

        Dim i As Integer = 0

        While dr.Read
            cboDept.Items.Add(dr("dept_name"))
            i += 1
        End While
        dr.Close()
        cmd.Dispose()
        CloseConnection()
    End Sub

    Private Sub ClearFields()
        txtPosName.Text = String.Empty
        txtPosNo.Text = String.Empty
        cboDept.Text = ""
    End Sub

    Private Sub LoadPosition()

        DicPosition.Clear()
        Dim position_no As Integer = 0

        OpenConnection()

        lvwPos.Items.Clear()

        Dim cmd As New SqlCommand
        cmd.Connection = connBIS
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "ListPosition"

        Dim dr As SqlDataReader = cmd.ExecuteReader

        'populate your listview 
        If dr.HasRows Then
            lvwPos.CheckBoxes = True
            Do While dr.Read()
                Dim item As New ListViewItem
                item.Text = dr("ID")
                item.SubItems.Add(dr("Name"))
                item.SubItems.Add(dr("Department"))
                lvwPos.Items.Add(item)
            Loop
            Me.lvwPos.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize)
            Me.lvwPos.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        Else
            MsgBox("No records found!")
        End If


        dr.Close()


        dr.Close()
        cmd.Dispose()
        CloseConnection()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Try
            'CHECK THE REQUIRED FIELD
            If txtPosName.Text.Trim = String.Empty Then
                MsgBox("Please fill up the required fields.")
                txtPosName.Focus()
                Exit Sub
            End If

            Dim newPosID As Integer = Convert.ToInt32(txtPosNo.Text)
            Dim cmd As New SqlCommand
            Dim position_name As String = txtPosName.Text
            Dim deptCode As Integer

            OpenConnection()
            cmd.Connection = connBIS
            cmd.CommandType = CommandType.StoredProcedure

            cmd.CommandText = "UpdatePosition"

            If lblPosStatus.Text = "New Position" Then
                'new section
                cmd.CommandText = "SavePosition"
                newPosID = 0
            End If

            deptCode = Convert.ToInt32(cboDept.SelectedIndex.ToString) + 1

            cmd.Parameters.AddWithValue("@position_no", newPosID)
            cmd.Parameters.AddWithValue("@position_name", position_name)
            cmd.Parameters.AddWithValue("@dept_code", deptCode)

            newPosID = cmd.ExecuteScalar
            'MsgBox(position_name)
            cmd.Dispose()
            CloseConnection()
        Catch ex As Exception

        End Try

        btnSave.Enabled = False
        txtPosName.Focus()
        LoadPosition()
        lblPosStatus.Text = ""

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub


    Private Sub txtPosSearchBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lvwPos.Items.Clear()
        ' If txtPosSearch.Text.Trim.Length > 0 Then LoadSearchPosition() Else LoadPosition()
    End Sub


    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Check if there is a selected item in listview

        ifEdit = True

        Dim item As ListViewItem = lvwPos.SelectedItems(0)

        Try


            If lvwPos.SelectedItems.Count = 0 Then Exit Sub
            'IsUpdate = True
            'frmOrder_details.txtCustomer.text = lvwCustList.SelectedItems(0).Text

            txtPosNo.Text = lvwPos.SelectedItems(0).SubItems(1).Text
            txtPosName.Text = lvwPos.SelectedItems(0).SubItems(2).Text
            ' cboDept.Text = lvwPos.SelectedItems(0).SubItems(3).Text

            'frmOrder.txtCustomer.Text = lvwCustList.SelectedItems.Item(1).Text

        Catch ex As Exception

        End Try

        btnSave.Enabled = True
        txtPosNo.Enabled = False
        txtPosName.Focus()

    End Sub


    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    'Private Sub SavePosition()

    '    For i As Integer = 0 To lvwPos.Items.Count - 1

    '        OpenConnection()
    '        Dim cmd As New SqlCommand
    '        Dim positition_no As Integer = Val(txtPosNo.Text)
    '        Dim positition_name As String = DicPosition(lvwPos.Items(i).SubItems(2).Text.Trim)
    '        Dim dept_name As String = Val(lvwPos.Items(i).SubItems(3).Text)

    '        cmd.Connection = connBIS
    '        cmd.CommandType = CommandType.StoredProcedure
    '        cmd.CommandText = "SavePosition"

    '        cmd.Parameters.AddWithValue("@or_no", positition_no)
    '        cmd.Parameters.AddWithValue("@product_no", positition_name)
    '        cmd.Parameters.AddWithValue("@dept_name", dept_name)

    '        positition_no = cmd.ExecuteScalar

    '        cmd.Dispose()
    '        CloseConnection()

    '    Next

    'End Sub


    Private Sub lvwPos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwPos.SelectedIndexChanged
        btnNew.Text = "&Cancel"
        btnSave.Enabled = True
        Try

            Dim lvpositions As ListView.SelectedListViewItemCollection = Me.lvwPos.SelectedItems
            Dim item As ListViewItem

            Dim code As String = Nothing
            Dim name As String = Nothing
            Dim dept As String = Nothing

            For Each item In lvpositions
                code += item.SubItems(0).Text
                name += item.SubItems(1).Text
                dept += item.SubItems(2).Text
            Next

            ' Output the price to TextBox1.
            txtPosNo.Text = (code)
            txtPosName.Text = (name)
            cboDept.Text = (dept)


        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        If btnNew.Text = "&New" Then
            btnNew.Text = "&Cancel"
            ClearFields()
            txtPosName.Enabled = True
            btnSave.Enabled = True
            txtPosName.Focus()
            lblPosStatus.Text = "New Position"
        ElseIf btnNew.Text = "&Cancel" Then
            ClearFields()
            btnNew.Text = "&New"
            btnNew.Focus()
            lblPosStatus.Text = "Update Position"
        End If
    End Sub

    Private Sub frmPosition_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadPosition()
        'LoadEmployee()
    End Sub

    Private Sub btnDelete_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim delStr As String = Nothing
        Dim PosItem As String
        Dim j As Integer = 0
        With lvwPos
            For i = 0 To .Items.Count - 1
                If .Items(i).Checked = True Then
                    j += 1
                    PosItem = .Items(i).SubItems(0).Text
                    If j > 1 Then
                        delStr = delStr & " OR position_no=" & PosItem & ""
                    Else
                        delStr = "position_no=" & PosItem
                    End If
                End If
            Next
        End With
        delSelectedPosition(delStr)
        ' MsgBox(delStr)
    End Sub

    Private Sub delSelectedPosition(ByVal delStr As String)
        OpenConnection()
        Dim cmd As New SqlCommand
        Dim position_no As Integer

        cmd.Connection = connBIS
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "DeletePosition"
        cmd.Parameters.AddWithValue("@delPosition", delStr)
        position_no = cmd.ExecuteScalar

        cmd.Dispose()
        CloseConnection()
        LoadPosition()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

        OpenConnection()
        Dim cmd As New SqlCommand

        cmd.Connection = connBIS
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "SearchEmpDept"
        cmd.Parameters.AddWithValue("@str", TextBox1.Text)

        Dim dr As SqlDataReader = cmd.ExecuteReader
        lvwEmployee.Items.Clear()
        'populate your listview 
        If dr.HasRows Then
            'lvwPos.CheckBoxes = True
            Do While dr.Read()
                Dim item As New ListViewItem
                item.Text = dr("EmpNo")
                item.SubItems.Add(dr("FirstName") & " " & dr("LastName"))
                item.SubItems.Add(dr("DateHired"))
                lvwEmployee.Items.Add(item)
            Loop
            'Me.lvwEmployee.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize)
            'Me.lvwEmployee.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        End If


        dr.Close()
        cmd.Dispose()
        CloseConnection()

    End Sub

    Private Sub lvwEmployee_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwEmployee.SelectedIndexChanged

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class