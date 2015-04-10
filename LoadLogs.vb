Imports System.Diagnostics
Imports System.Windows.Forms
Imports System.IO
Imports System.Data.SqlClient

Public Class LoadLogs

    Private Sub LoadLogs_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        setHeader()
    End Sub

    Private Sub setHeader()
        ListView1.Width = 725
        ' Declare and construct the ColumnHeader objects. 
        Dim header1, header2, header3, header4, header5, header6, header7, header8, header9, header10 As ColumnHeader
        header1 = New ColumnHeader
        header2 = New ColumnHeader
        header3 = New ColumnHeader
        header4 = New ColumnHeader
        header5 = New ColumnHeader
        header6 = New ColumnHeader
        header7 = New ColumnHeader
        header8 = New ColumnHeader
        header9 = New ColumnHeader
        header10 = New ColumnHeader

        ' Set the text, alignment and width for each column header.
        header1.Text = "No"
        header1.TextAlign = HorizontalAlignment.Left
        header1.Width = 40

        header2.TextAlign = HorizontalAlignment.Left
        header2.Text = "TMNo"
        header2.Width = 60

        header3.TextAlign = HorizontalAlignment.Left
        header3.Text = "EnNo"
        header3.Width = 60

        header4.TextAlign = HorizontalAlignment.Left
        header4.Text = "Name"
        header4.Width = 100

        header5.TextAlign = HorizontalAlignment.Left
        header5.Text = "GMNo"
        header5.Width = 60

        header6.TextAlign = HorizontalAlignment.Left
        header6.Text = "Mode"
        header6.Width = 60

        header7.TextAlign = HorizontalAlignment.Left
        header7.Text = "In/Out"
        header7.Width = 60

        header8.TextAlign = HorizontalAlignment.Left
        header8.Text = "Antipass"
        header8.Width = 60


        header9.TextAlign = HorizontalAlignment.Left
        header9.Text = "DaiGong"
        header9.Width = 60

        header10.TextAlign = HorizontalAlignment.Left
        header10.Text = "DateTime"
        header10.Width = 150

        ' Add the headers to the ListView control.
        ListView1.Columns.Add(header1)
        ListView1.Columns.Add(header2)
        ListView1.Columns.Add(header3)
        ListView1.Columns.Add(header4)
        ListView1.Columns.Add(header5)
        ListView1.Columns.Add(header6)
        ListView1.Columns.Add(header7)
        ListView1.Columns.Add(header8)
        ListView1.Columns.Add(header9)
        ListView1.Columns.Add(header10)
        ListView1.View = View.Details
        ' Specify that each item appears on a separate line.
        ListView1.View = View.Details
    End Sub
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (ListView1.Items.Count) = 0 Then
            ListView1.Items.Clear()
            GetDataFromFile()
        End If
    End Sub

    Private Sub GetDataFromFile()
        Try


            Dim appPath As String = "c:\bonings\AGL_0001.txt"
            Dim fileEntries As New List(Of String)

            If Not File.Exists(appPath) Then
                Exit Sub
            End If

            'Try
            ' Read the file into a list...
            Dim reader As StreamReader = New StreamReader(appPath)
            fileEntries.Clear()

            Do Until reader.Peek = -1 'Until eof
                fileEntries.Add(reader.ReadLine)
            Loop

            reader.Close()

            'Catch ex As Exception
            ' The file's empty.
            ' End Try

            ' Now we have the whole file in a list(Of String)

            Dim ctr As Integer = 0

        
            For Each line As String In fileEntries
                ctr = ctr + 1
                If ctr > 1 Then
                    Dim parts() As String = Split(line, vbTab)

                    'MsgBox(parts(0) & " " & parts(1) & " " & parts(3) & " " & parts(4))
                    'ListView1.Items.AddRange(parts.Select(Function(x) New ListViewItem(x)).ToArray)

                    Dim item As New ListViewItem
                    item.Text = parts(0)
                    item.SubItems.Add(parts(1))
                    item.SubItems.Add(parts(2))
                    item.SubItems.Add(parts(3))
                    item.SubItems.Add(parts(4))
                    item.SubItems.Add(parts(5))
                    item.SubItems.Add(parts(6))
                    item.SubItems.Add(parts(7))
                    item.SubItems.Add(parts(8))
                    item.SubItems.Add(parts(9))

                    ListView1.Items.Add(item)

                End If
            Next


        Catch ex As Exception
            MessageBox.Show("Error Found!")
        End Try

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ' Try

        If (ListView1.Items.Count) = 0 Then
            MessageBox.Show("Error! " & ListView1.Items.Count & " Items Found!")
        Else

            Dim cmd As New SqlCommand
            Dim newaglId As Integer = 0
            OpenConnection()
            cmd.Connection = connBIS
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "InsertToAGL"
            newaglId = cmd.ExecuteScalar
            MsgBox("Save!")
            cmd.Dispose()
            CloseConnection()

        End If
        'Catch ex As Exception
        'MessageBox("Error Found!")
        ' End Try

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ListView1.Items.Clear()
    End Sub
End Class
