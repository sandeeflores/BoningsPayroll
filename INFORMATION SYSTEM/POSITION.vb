Imports System.Data.SqlClient
Public Class frmPosition
    Public pos_id As Integer
    Dim ifEdit As Boolean
    'Dim DicDepartment As New Dictionary(Of String, String)
    Dim DicPosition As New Dictionary(Of String, String)
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub POSITION_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtPosSearch.Focus()

        ClearFields()
        txtPosName.Enabled = False
        btnSave.Enabled = False
        btnEdit.Enabled = False
        cboDept.Text = String.Empty

        If ifEdit = True Then
            OpenConnection()

            Dim cmd As New SqlCommand
            Dim position_id As Integer = txtPosNo.Text


            cmd.Connection = connBIS
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "PositionShowAll"

            cmd.Parameters.AddWithValue("@position_no", position_id)


            Dim dr As SqlDataReader = cmd.ExecuteReader

            If dr.Read Then

                txtPosNo.Text = position_id

            End If

            dr.Close()
            cmd.Dispose()
            CloseConnection()
        Else
            Generate_Position()
        End If

        'If pos_id > 0 Then 'check if it is editing
        '    LoadPositionInfo()
        'End If

    End Sub
    Private Sub FillDepartment()

        cboDept.Items.Clear()
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
        'ifEdit = False

        txtPosName.Text = String.Empty
        cboDept.Text = String.Empty
    End Sub
    Private Sub LoadPosition()
        cboDept.Items.Clear()
        'DicDepartment.Clear()
        DicPosition.Clear()
        Dim position_no As Integer = 0

        Dim search_text As String = txtPosSearch.Text.Trim

        OpenConnection()

        lvwPos.Items.Clear()

        Dim cmd As New SqlCommand
        cmd.Connection = connBIS
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "SelectedPosition"

        cmd.Parameters.AddWithValue("@position_no", position_no)

        Dim dr As SqlDataReader = cmd.ExecuteReader

        Dim i As Integer = 0




        With lvwPos
            While dr.Read
                cboDept.Items.Add(dr("dept_name"))
                'DicDepartment.Add(dr("dept_code"), dr("dept_name"))
                DicPosition.Add(dr("position_no"), dr("position_name"))


                .Items.Add(Format(i + 1, "0000"))
                .Items(i).SubItems.Add(dr(Format("position_no", "0000")))
                .Items(i).SubItems.Add(dr("position_name"))
                .Items(i).SubItems.Add(dr("dept_name"))
                i += 1

            End While
        End With


        dr.Close()
        cmd.Dispose()
        CloseConnection()
    End Sub

    Private Sub Generate_Position()

        OpenConnection()

        Dim cmd As New SqlCommand
        Dim i As Integer = 1

        cmd.Connection = connBIS
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Generate_Position_no"

        Dim dr As SqlDataReader = cmd.ExecuteReader
        dr.Read()
        'Dim i As Integer = dr("position_id") + 1

        txtPosNo.Text = Format(dr("position_no"), "0000")


        cmd.Dispose()
        CloseConnection()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        btnNew.Enabled = True
        btnEdit.Enabled = True
        
        'CHECK THE REQUIRED FIELD
        If txtPosName.Text.Trim = String.Empty _
            And cboDept.Text.Trim = String.Empty Then
            MsgBox("Please fill up the required fields.")
            txtPosName.Focus()
            Exit Sub
        End If

        Try
            Dim msg As String

            OpenConnection()
            Dim sqlText As String
            Dim cmd As New SqlCommand
            Dim position_id As String = Val(txtPosNo.Text)
            Dim position_name As String = txtPosName.Text
            Dim department As String = cboDept.SelectedItem

            If ifEdit = True Then
                sqlText = "UpdatePosition"
                cmd.Parameters.AddWithValue("@position_no", position_id)
                msg = "You successfully update your position"
            Else
                sqlText = "SetPosition"
                msg = "you successfully added your position"
            End If

            cmd.Connection = connBIS
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = sqlText


            MsgBox(txtPosNo.Text.Trim)
            MsgBox(txtPosName.Text.Trim)
            MsgBox(cboDept.Text)

            cmd.Parameters.AddWithValue("@position_no", position_id)
            cmd.Parameters.AddWithValue("@position_name", position_name)
            cmd.Parameters.AddWithValue("@dept_code", department) 'DicDepartment(department))

            position_id = cmd.ExecuteScalar

            cmd.Dispose()
            CloseConnection()

            ClearFields()
            btnSave.Enabled = False
            LoadAllPosition()
            checkExistingPositionDetails()
            SavePosition()
            'FillDepartment()

        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("The Position inputted is already Exist")

        End Try
        'SavePosition()
        txtPosName.Focus()
        txtPosName.SelectAll()
        txtPosNo.Text = String.Empty
        txtPosName.Text = String.Empty
        cboDept.Text = String.Empty

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        btnNew.Enabled = False
        ClearFields()
        txtPosName.Enabled = True
        btnSave.Enabled = True
        btnEdit.Enabled = False
        FillDepartment()
        txtPosName.Focus()
        Generate_Position()
    End Sub

    Private Sub checkExistingPositionDetails()
        OpenConnection()
        Dim cmd As New SqlCommand
        Dim position_no As Integer = Val(txtPosNo.Text)

        cmd.Connection = connBIS
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "CheckPositionNo"

        cmd.Parameters.AddWithValue("@position_no", position_no)
        position_no = cmd.ExecuteScalar

        cmd.Dispose()
        CloseConnection()
    End Sub


    Public Sub LoadSearchPosition()
        Dim dept_no As Integer = 0

        Dim search_text As String = txtPosSearch.Text.Trim

        OpenConnection()

        lvwPos.Items.Clear()

        Dim cmd As New SqlCommand
        cmd.Connection = connBIS
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "SearchPosition"

        cmd.Parameters.AddWithValue("@position_name", search_text)

        Dim dr As SqlDataReader = cmd.ExecuteReader

        Dim i As Integer = 0

        With lvwPos
            While dr.Read
                .Items.Add(Format(i + 1, "0000"))
                .Items(i).SubItems.Add(dr("position_no"))
                .Items(i).SubItems.Add(dr("position_name"))
                .Items(i).SubItems.Add(dr("dept_name"))

                i += 1
            End While
        End With

        dr.Close()
        cmd.Dispose()
        CloseConnection()

    End Sub

    Private Sub lvwPos_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvwPos.MouseDoubleClick
        Try

            If lvwPos.SelectedItems.Count = 0 Then Exit Sub


            txtPosNo.Text = lvwPos.SelectedItems(0).SubItems(1).Text
            txtPosName.Text = lvwPos.SelectedItems(0).SubItems(2).Text
            cboDept.Text = lvwPos.SelectedItems(0).SubItems(3).Text

        Catch ex As Exception

        End Try
        btnSave.Enabled = True
        txtPosName.Focus()
    End Sub

    Private Sub txtPosSearchBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lvwPos.Items.Clear()
        If txtPosSearch.Text.Trim.Length > 0 Then LoadSearchPosition() Else LoadPosition()
    End Sub

    Private Sub LoadAllPosition()
        lvwPos.Items.Clear()

        Dim dept_code As Integer = 0
        Dim search_text As String = txtPosSearch.Text.Trim

        OpenConnection()


        Dim cmd As New SqlCommand
        cmd.Connection = connBIS
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "SelectAllPosition"


        Dim dr As SqlDataReader = cmd.ExecuteReader
        DicPosition.Clear()
        Dim i As Integer = 0
        With lvwPos
            While dr.Read
                DicPosition.Add(dr("position_no"), dr("position_name"))
                .Items.Add(Format(i + 1, "00"))
                .Items(i).SubItems.Add(Format(dr("position_no"), "0000"))
                .Items(i).SubItems.Add(dr("position_name"))
                .Items(i).SubItems.Add(dr("dept_name"))
                i += 1

            End While
        End With
        dr.Close()
        cmd.Dispose()
        CloseConnection()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        'Check if there is a selected item in listview

        ifEdit = True

        Dim item As ListViewItem = lvwPos.SelectedItems(0)

        Try


            If lvwPos.SelectedItems.Count = 0 Then Exit Sub
            'IsUpdate = True
            'frmOrder_details.txtCustomer.text = lvwCustList.SelectedItems(0).Text

            txtPosNo.Text = lvwPos.SelectedItems(0).SubItems(1).Text
            txtPosName.Text = lvwPos.SelectedItems(0).SubItems(2).Text
            cboDept.Text = lvwPos.SelectedItems(0).SubItems(3).Text

            'frmOrder.txtCustomer.Text = lvwCustList.SelectedItems.Item(1).Text

        Catch ex As Exception

        End Try

        btnSave.Enabled = True
        txtPosNo.Enabled = False
        txtPosName.Focus()
    End Sub


    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If lvwPos.SelectedItems.Count = 0 Then Exit Sub

        If MsgBox("This Position will be deleted permanently in the record." + vbCrLf + "Do you want to continue?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim position_id As String = lvwPos.SelectedItems(0).Text

        OpenConnection()
        Dim cmd As New SqlCommand
        cmd.Connection = connBIS
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "DeletePosition"
        cmd.Parameters.AddWithValue("@position_no", position_id)

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        CloseConnection()
        MsgBox("Position is successfully deleted.")
        LoadAllPosition()
    End Sub

    Private Sub SavePosition()

        For i As Integer = 0 To lvwPos.Items.Count - 1

            OpenConnection()
            Dim cmd As New SqlCommand
            Dim positition_no As Integer = Val(txtPosNo.Text)
            Dim positition_name As String = DicPosition(lvwPos.Items(i).SubItems(2).Text.Trim)
            Dim dept_name As String = Val(lvwPos.Items(i).SubItems(3).Text)



            cmd.Connection = connBIS
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "SavePosition"

            cmd.Parameters.AddWithValue("@or_no", positition_no)
            cmd.Parameters.AddWithValue("@product_no", positition_name)
            cmd.Parameters.AddWithValue("@dept_name", dept_name)


            positition_no = cmd.ExecuteScalar

            cmd.Dispose()
            CloseConnection()

        Next

    End Sub

End Class