Imports System.IO
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.IO.IsolatedStorage
Public Class frmencrypt
    'Dim con As New SqlConnection
    'Dim cmd As New SqlCommand
    'Dim rdr As SqlDataReader
    Public statuss, messageanswer, deleteanswer, remove As String
    Private arr As String() = New String(5) {}
    Dim ifsw, ifsr As IsolatedStorageFileStream
    Dim isostr As IsolatedStorageFile
    Private Sub frmencrypt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = New Point(200, 96)
        'con.ConnectionString = "Data Source=ABRI-PC\SQLEXPRESS;Initial Catalog=users;Integrated Security=True"
        statuss = ""
        arr(0) = ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}"
        arr(1) = ".{21EC2020-3AEA-1069-A2DD-08002B30309D}"
        arr(2) = ".{2559a1f4-21d7-11d4-bdaf-00c04f60b9f0}"
        arr(3) = ".{645FF040-5081-101B-9F08-00AA002F954E}"
        arr(4) = ".{2559a1f1-21d7-11d4-bdaf-00c04f60b9f0}"
        arr(5) = ".{7007ACC7-3202-11D1-AAD2-00805FC1270E}"
        messageanswer = ""
        deleteanswer = ""
        remove = ""
        isostr = IsolatedStorageFile.GetStore(IsolatedStorageScope.User Or IsolatedStorageScope.Domain Or IsolatedStorageScope.Assembly, Nothing, Nothing)
        If Not isostr.FileExists("files.txt") Then
            'isostr.CreateDirectory("abrishikor")
            isostr.CreateFile("files.txt")
        End If
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        addfiles()
    End Sub

    Private Sub dgv1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellContentClick
        'If con.State = ConnectionState.Closed Then
        '    con.Open()
        'End If

        'cmd.CommandType = CommandType.Text
        'cmd.Connection = con
        If e.ColumnIndex = 2 Then
            If e.RowIndex >= 0 Then
                If dgv1.Rows(e.RowIndex).Cells(1).Value = "Accessible" Then
                    If dgv1.Rows(e.RowIndex).Cells(0).Value <> "" Then
                        System.Diagnostics.Process.Start(dgv1.Rows(e.RowIndex).Cells(0).Value)
                    Else
                        frmmessage.Text = "Path Error..."
                        frmmessage.Label1.Text = "NO FOLDER PATH SELECTED..."
                        frmmessage.ShowDialog()
                    End If
                Else
                    frmmessage.Text = "Locked Folder..."
                    frmmessage.Label1.Text = "THE FOLDER PATH SELECTED IS LOCKED, UNLOCK IT FIRST..."
                    frmmessage.ShowDialog()
                End If
            End If
        ElseIf e.ColumnIndex = 3 Then
            If e.RowIndex >= 0 Then
                If dgv1.Rows(e.RowIndex).Cells(1).Value = "Accessible" Then
                    If dgv1.Rows(e.RowIndex).Cells(0).Value <> "" Then
                        'lock it here

                        statuss = arr(0)

                        Dim d As DirectoryInfo = New DirectoryInfo(dgv1.Rows(e.RowIndex).Cells(0).Value)
                        Dim selectedpath As String = d.Parent.FullName + d.Name



                        If dgv1.Rows(e.RowIndex).Cells(0).Value.LastIndexOf(".{") = -1 Then
                            If (Not d.Root.Equals(d.Parent.FullName)) Then
                                d.MoveTo(d.Parent.FullName & "\" & d.Name & statuss)
                            Else
                                d.MoveTo(d.Parent.FullName + d.Name & statuss)
                            End If
                            'TextBox1.Text = dgv1.Rows(e.RowIndex).Cells(0).Value
                            'ProgressBar1.Value = 75
                            'ProgressBar1.Value = 100
                            dgv1.Rows(e.RowIndex).Cells(4).Value = d.ToString
                            'cmd.CommandText = "update files set hiden='" & dgv1.Rows(e.RowIndex).Cells(4).Value & "' where uname='" & Label1.Text & "' and dir='" & dgv1.Rows(e.RowIndex).Cells(0).Value & "'"
                            'cmd.ExecuteNonQuery()
                            ' CType(dgv1.Rows(e.RowIndex).Cells(2).Value, System.Windows.Forms.Button).Enabled = False
                            'Dim sw1 As New IO.StreamWriter("C:\Users\Abri\Desktop\ff\abriii\a.txt", True)
                            '  For Each line In System.IO.File.ReadLines("C:\Users\Abri\Desktop\ff\abriii\aa.txt")
                            ifsw = New IsolatedStorageFileStream("tempfiles.txt", FileMode.Append, isostr)
                            ifsr = New IsolatedStorageFileStream("files.txt", FileMode.Open, isostr)
                            Dim sw As New StreamWriter(ifsw)
                            Dim sr As New StreamReader(ifsr)
                            While sr.Peek() <> -1
                                Dim line = sr.ReadLine
                                If Not line.Contains((Label1.Text.Trim & "|" & dgv1.Rows(e.RowIndex).Cells(0).Value.ToString.Trim).ToString.Trim) Then
                                    sw.Write(line & vbNewLine)
                                End If
                            End While
                            '  Next
                            sw.Close()
                            sr.Close()
                            ifsr.Close()
                            ifsw.Close()
                            ifsw.Dispose()
                            ifsr.Dispose()
                            ifsw = New IsolatedStorageFileStream("files.txt", FileMode.Truncate, isostr)
                            ifsr = New IsolatedStorageFileStream("tempfiles.txt", FileMode.Open, isostr)
                            Dim sw2 As New IO.StreamWriter(ifsw)
                            Dim sr2 As New StreamReader(ifsr)
                            While sr2.Peek > -1
                                ' For Each line In System.IO.File.ReadLines("C:\Users\Abri\Desktop\ff\abriii\a.txt")
                                ' If Not line.Contains((Label1.Text.Trim & "|" & dgv1.Rows(e.RowIndex).Cells(0).Value.ToString.Trim).ToString.Trim) Then
                                Dim line = sr2.ReadLine
                                sw2.Write(line & vbNewLine)
                                ' end if
                                'Next
                            End While
                            sw2.Write(Label1.Text.Trim & "|" & dgv1.Rows(e.RowIndex).Cells(0).Value.ToString.Trim & "|" & dgv1.Rows(e.RowIndex).Cells(4).Value.ToString.Trim & vbNewLine)
                            sw2.Close()
                            sr2.Close()
                            ifsr.Close()
                            ifsw.Close()
                            ifsw.Dispose()
                            ifsr.Dispose()

                            ' IO.File.Delete("C:\Users\Abri\Desktop\ff\abriii\a.txt")
                            isostr.DeleteFile("tempfiles.txt")
                            dgv1.Rows(e.RowIndex).Cells(3).Value = "UnLock"
                            dgv1.Rows(e.RowIndex).Cells(1).Value = "Locked"
                        Else
                            MsgBox("VALID FOLDER NAME SHOULD NOT HAVE THOSE CHARACTERS . and { ")
                            'status = getstatus(status)
                            'd.MoveTo(FolderBrowserDialog1.SelectedPath.Substring(0, FolderBrowserDialog1.SelectedPath.LastIndexOf(".")))
                            'TextBox1.Text = FolderBrowserDialog1.SelectedPath.Substring(0, FolderBrowserDialog1.SelectedPath.LastIndexOf("."))
                        End If

                    Else
                        frmmessage.Text = "Path Error..."
                        frmmessage.Label1.Text = "NO FOLDER PATH SELECTED..."
                        frmmessage.ShowDialog()
                    End If
                Else
                    If dgv1.Rows(e.RowIndex).Cells(4).Value <> "" Then
                        'unlock it here 
                        statuss = arr(1)

                        Dim d As DirectoryInfo = New DirectoryInfo(dgv1.Rows(e.RowIndex).Cells(4).Value)
                        Dim selectedpath As String = d.Parent.FullName + d.Name

                        'ProgressBar1.Value = 40
                        'ProgressBar1.Value = 100

                        If dgv1.Rows(e.RowIndex).Cells(4).Value.LastIndexOf(".{") = -1 Then
                            MsgBox("THE FOLDER IS ALREADY OPEN/UNLOCKED...")
                            'If (Not d.Root.Equals(d.Parent.FullName)) Then
                            '    d.MoveTo(d.Parent.FullName & "\" & d.Name & status)
                            'Else
                            '    d.MoveTo(d.Parent.FullName + d.Name & status)
                            'End If

                            'TextBox2.Text = FolderBrowserDialog1.SelectedPath
                            'ProgressBar1.Value = 100
                            'ProgressBar1.Value = 100
                        Else

                            statuss = getstatus(statuss)
                            d.MoveTo(dgv1.Rows(e.RowIndex).Cells(4).Value.Substring(0, dgv1.Rows(e.RowIndex).Cells(4).Value.LastIndexOf(".")))
                            'TextBox2.Text = dgv1.Rows(e.RowIndex).Cells(0).Value.Substring(0, dgv1.Rows(e.RowIndex).Cells(0).Value.LastIndexOf("."))
                            'cmd.CommandText = "update files set hiden='not' where uname='" & Label1.Text & "' and dir='" & dgv1.Rows(e.RowIndex).Cells(0).Value & "'"
                            'cmd.ExecuteNonQuery()
                            ' Dim swr1 As New IO.StreamWriter("C:\Users\Abri\Desktop\ff\abriii\a.txt", True)
                            ifsr = New IsolatedStorageFileStream("files.txt", FileMode.Open, isostr)
                            ifsw = New IsolatedStorageFileStream("tempfiles.txt", FileMode.Append, isostr)
                            Dim sw1 As New StreamWriter(ifsw)
                            Dim sr1 As New StreamReader(ifsr)
                            'For Each line In System.IO.File.ReadLines("C:\Users\Abri\Desktop\ff\abriii\aa.txt")
                            While sr1.Peek <> -1
                                Dim line = sr1.ReadLine
                                If Not line.Contains((Label1.Text.Trim & "|" & dgv1.Rows(e.RowIndex).Cells(0).Value.ToString.Trim).ToString.Trim) Then
                                    sw1.Write(line & vbNewLine)
                                End If
                            End While
                            ' Next
                            sw1.Close()
                            sr1.Close()
                            sr1.Dispose()
                            sw1.Dispose()
                            ifsr.Close()
                            ifsw.Close()
                            ifsw.Dispose()
                            ifsr.Dispose()
                            ifsr = New IsolatedStorageFileStream("tempfiles.txt", FileMode.Open, isostr)
                            ifsw = New IsolatedStorageFileStream("files.txt", FileMode.Truncate, isostr)
                            Dim sw2 As New StreamWriter(ifsw)
                            Dim sr2 As New StreamReader(ifsr)
                            ' Dim sw2 As New IO.StreamWriter("C:\Users\Abri\Desktop\ff\abriii\aa.txt")
                            'For Each line In System.IO.File.ReadLines("C:\Users\Abri\Desktop\ff\abriii\a.txt")
                            ' If Not line.Contains((Label1.Text.Trim & "|" & dgv1.Rows(e.RowIndex).Cells(0).Value.ToString.Trim).ToString.Trim) Then
                            While sr2.Peek > -1
                                Dim line = sr2.ReadLine
                                sw2.Write(line & vbNewLine)
                                ' end if
                                'Next
                            End While
                            sw2.Write(Label1.Text.Trim & "|" & dgv1.Rows(e.RowIndex).Cells(0).Value.ToString.Trim & "|not" & vbNewLine)
                            sw2.Close()
                            sr2.Close()
                            sr2.Dispose()
                            sw2.Dispose()
                            ifsr.Close()
                            ifsw.Close()
                            ifsw.Dispose()
                            ifsr.Dispose()
                            ' IO.File.Delete("C:\Users\Abri\Desktop\ff\abriii\a.txt")
                            isostr.DeleteFile("tempfiles.txt")
                            'CType(dgv1.Rows(e.RowIndex).Cells(2).Value, System.Windows.Forms.Button).Enabled = True
                            dgv1.Rows(e.RowIndex).Cells(3).Value = "Lock"
                            dgv1.Rows(e.RowIndex).Cells(1).Value = "Accessible"
                            dgv1.Rows(e.RowIndex).Cells(4).Value = "not"
                        End If
                    Else
                        frmmessage.Text = "Path Error..."
                        frmmessage.Label1.Text = "NO FOLDER PATH SELECTED..."
                        frmmessage.ShowDialog()
                    End If
                End If
            End If
        End If
        'cmd.Parameters.Clear()
        'If con.State = ConnectionState.Open Then
        '    con.Close()
        'End If
    End Sub

    Private Sub btnse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        dgv1.SelectAll()
        'Dim p As Integer

        'p = dgv1.SelectedRows.Count - 1
        'While 0 <= p
        '    MsgBox(p)
        '    MsgBox(dgv1.SelectedRows(p).Cells(0).Value)
        '    MsgBox(dgv1.SelectedRows(p).Cells(1).Value)
        '    p = p - 1
        'End While
    End Sub

    Private Sub btnunse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        dgv1.ClearSelection()
        ' Me.dgv1.Columns(0).SortMode = DataGridViewColumnSortMode.Automatic
        ' dgv1.Sort(dgv1.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub btnlock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlock.Click
        Dim j As Integer
        j = dgv1.SelectedRows.Count - 1
        While j >= 0
            If dgv1.SelectedRows(j).Cells(1).Value = "Accessible" Then
                locker(j)
            End If
            j = j - 1
        End While
    End Sub
    Public Sub locker(ByVal row As Integer)
       
        'If con.State = ConnectionState.Closed Then
        '    con.Open()
        '    cmd.Connection = con
        '    cmd.CommandType = CommandType.Text
        'End If


        If dgv1.SelectedRows(row).Cells(0).Value <> "" Then
            'lock it here

            statuss = arr(0)

            Dim d As DirectoryInfo = New DirectoryInfo(dgv1.SelectedRows(row).Cells(0).Value)
            Dim selectedpath As String = d.Parent.FullName + d.Name



            If dgv1.SelectedRows(row).Cells(0).Value.LastIndexOf(".{") = -1 Then
                If (Not d.Root.Equals(d.Parent.FullName)) Then
                    d.MoveTo(d.Parent.FullName & "\" & d.Name & statuss)
                Else
                    d.MoveTo(d.Parent.FullName + d.Name & statuss)
                End If
                'TextBox1.Text = dgv1.Rows(e.RowIndex).Cells(0).Value
                'ProgressBar1.Value = 75
                'ProgressBar1.Value = 100
                dgv1.SelectedRows(row).Cells(4).Value = d.ToString
                'cmd.CommandText = "update files set hiden='" & dgv1.SelectedRows(row).Cells(4).Value & "' where uname='" & Label1.Text & "' and dir='" & dgv1.SelectedRows(row).Cells(0).Value & "'"
                'cmd.ExecuteNonQuery()

                '  Dim sw1 As New IO.StreamWriter("C:\Users\Abri\Desktop\ff\abriii\a.txt", True)
                ifsw = New IsolatedStorageFileStream("tempfiles.txt", FileMode.Append, isostr)
                ifsr = New IsolatedStorageFileStream("files.txt", FileMode.Open, isostr)
                Dim sw1 As New StreamWriter(ifsw)
                Dim sr1 As New StreamReader(ifsr)
                'For Each line In System.IO.File.ReadLines("C:\Users\Abri\Desktop\ff\abriii\aa.txt")
                While sr1.Peek > -1
                    Dim line = sr1.ReadLine
                    If Not line.Contains((Label1.Text.Trim & "|" & dgv1.SelectedRows(row).Cells(0).Value.ToString.Trim).ToString.Trim) Then
                        sw1.Write(line & vbNewLine)
                    End If
                End While
                'Next
                sw1.Close()
                '  sw2.Close()
                sr1.Close()
                sr1.Dispose()
                sw1.Dispose()
                ifsr.Close()
                ifsw.Close()
                ifsw.Dispose()
                ifsr.Dispose()
                'Dim sw2 As New IO.StreamWriter("C:\Users\Abri\Desktop\ff\abriii\aa.txt")
                ifsr = New IsolatedStorageFileStream("tempfiles.txt", FileMode.Open, isostr)
                ifsw = New IsolatedStorageFileStream("files.txt", FileMode.Truncate, isostr)
                Dim sw2 As New StreamWriter(ifsw)
                Dim sr2 As New StreamReader(ifsr)
                'For Each line In System.IO.File.ReadLines("C:\Users\Abri\Desktop\ff\abriii\a.txt")
                ' If Not line.Contains((Label1.Text.Trim & "|" & dgv1.Rows(e.RowIndex).Cells(0).Value.ToString.Trim).ToString.Trim) Then
                While sr2.Peek <> -1
                    Dim line = sr2.ReadLine
                    sw2.Write(line & vbNewLine)
                End While
                ' end if
                'Next

                sw2.Write(Label1.Text.Trim & "|" & dgv1.SelectedRows(row).Cells(0).Value.ToString.Trim & "|" & dgv1.SelectedRows(row).Cells(4).Value.ToString.Trim & vbNewLine)
                sw2.Close()
                ' sw2.Close()
                sr2.Close()
                sr2.Dispose()
                sw2.Dispose()
                ifsr.Close()
                ifsw.Close()
                ifsw.Dispose()
                ifsr.Dispose()
                'IO.File.Delete("C:\Users\Abri\Desktop\ff\abriii\a.txt")
                isostr.DeleteFile("tempfiles.txt")
                dgv1.SelectedRows(row).Cells(3).Value = "UnLock"
                dgv1.SelectedRows(row).Cells(1).Value = "Locked"
                ' CType(dgv1.SelectedRows(row).Cells(2).Value, System.Windows.Forms.Button).Enabled = False
            Else
                MsgBox("VALID FOLDER NAME SHOULD NOT HAVE THOSE CHARACTERS . and { ")
                'status = getstatus(status)
                'd.MoveTo(FolderBrowserDialog1.SelectedPath.Substring(0, FolderBrowserDialog1.SelectedPath.LastIndexOf(".")))
                'TextBox1.Text = FolderBrowserDialog1.SelectedPath.Substring(0, FolderBrowserDialog1.SelectedPath.LastIndexOf("."))
            End If

        Else
            frmmessage.Text = "Path Error..."
            frmmessage.Label1.Text = "NO FOLDER PATH SELECTED..."
            frmmessage.ShowDialog()
        End If
        ' Else
        'it is alreaady locked

        '  dgv1.SelectedRows(i).Cells(3).Value = "UnLock"
        ' dgv1.SelectedRows(i).Cells(1).Value = "Locked"


    End Sub
    Private Function getstatus(ByVal stat As String) As String
        For i As Integer = 0 To 5
            If stat.LastIndexOf(arr(i)) <> -1 Then
                stat = stat.Substring(stat.LastIndexOf("."))
            End If
        Next i
        Return stat
    End Function

    Private Sub btndeletes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndeletes.Click
        If Not dgv1.SelectedRows.Count > 0 Then
            Exit Sub
        End If
        frmyesnomessage.Label1.Text = "Do you want to delete those folders just from the locker or from the disk also?"
        frmyesnomessage.ShowDialog()
        If messageanswer = "cancel" Then
            Exit Sub
        End If
        'If con.State = ConnectionState.Closed Then
        '    con.Open()
        '    cmd.Connection = con
        '    cmd.CommandType = CommandType.Text
        'End If
        Dim i As Integer
        i = dgv1.SelectedRows.Count - 1
        'Dim sw1 As New IO.StreamWriter("C:\Users\Abri\Desktop\ff\abriii\a.txt")
        ' Dim sw2 As New IO.StreamWriter("C:\Users\Abri\Desktop\ff\abriii\aa.txt")
        ifsw = New IsolatedStorageFileStream("tempfiles.txt", FileMode.Append, isostr)
        ifsr = New IsolatedStorageFileStream("files.txt", FileMode.Open, isostr)
        Dim sr1 As New StreamReader(ifsr)
        Dim sw1 As New StreamWriter(ifsw)
        While i >= 0
            If messageanswer = "fromdisk" Then
                'delete a file from file system
                If FileIO.FileSystem.DirectoryExists(dgv1.SelectedRows(i).Cells(0).Value) Then
                    FileIO.FileSystem.DeleteDirectory(dgv1.SelectedRows(i).Cells(0).Value, FileIO.DeleteDirectoryOption.DeleteAllContents)
                ElseIf FileIO.FileSystem.DirectoryExists(dgv1.SelectedRows(i).Cells(4).Value) Then
                    FileIO.FileSystem.DeleteDirectory(dgv1.SelectedRows(i).Cells(4).Value, FileIO.DeleteDirectoryOption.DeleteAllContents)
                End If
            End If

            'cmd.CommandText = "delete from files where dir='" & dgv1.SelectedRows(i).Cells(0).Value & "' and uname='" & Label1.Text & "'"
            'cmd.ExecuteNonQuery()
            While sr1.Peek <> -1
                Dim line = sr1.ReadLine
                '    For Each line In System.IO.File.ReadLines("C:\Users\Abri\Desktop\ff\abriii\aa.txt")
                If Not line.Contains((Label1.Text.Trim & "|" & dgv1.SelectedRows(i).Cells(0).Value.ToString.Trim).ToString.Trim) Then
                    sw1.Write(line & vbNewLine)
                End If
                'Next
            End While
            sw1.Close()
            sw1.Close()
            sr1.Close()
            sr1.Dispose()
            sw1.Dispose()
            ifsr.Close()
            ifsw.Close()
            ifsw.Dispose()
            ifsr.Dispose()
            dgv1.Rows.Remove(dgv1.SelectedRows(i))
            i = i - 1
        End While
        ifsw = New IsolatedStorageFileStream("files.txt", FileMode.Truncate, isostr)
        ifsr = New IsolatedStorageFileStream("tempfiles.txt", FileMode.Open, isostr)
        Dim sr2 As New StreamReader(ifsr)
        Dim sw2 As New StreamWriter(ifsw)
        While sr2.Peek <> -1
            Dim line = sr2.ReadLine
            'For Each line In System.IO.File.ReadLines("C:\Users\Abri\Desktop\ff\abriii\a.txt")
            'If Not line.Contains((Label1.Text.Trim & "|" & dgv1.Rows(e.RowIndex).Cells(0).Value.ToString.Trim).ToString.Trim) Then
            sw2.Write(line & vbNewLine)
            'end if
            'Next
        End While
        'sw2.Write(Label1.Text.Trim & "|" & dgv1.Rows(i).Cells(0).Value.ToString.Trim & "|" & dgv1.Rows(e.RowIndex).Cells(4).Value.ToString.Trim & vbNewLine)
        sw2.Close()
        sw2.Close()
        sr2.Close()
        sr2.Dispose()
        sw2.Dispose()
        ifsr.Close()
        ifsw.Close()
        ifsw.Dispose()
        ifsr.Dispose()
        'sw2.Close()
        'IO.File.Delete("C:\Users\Abri\Desktop\ff\abriii\a.txt")
        isostr.DeleteFile("tempfiles.txt")
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        ' frmdelete.Label1.Text = "Are sure you want to delete this lockername and all folders managed by this lockername?"
        frmdelete.ShowDialog()
        'If con.State = ConnectionState.Closed Then
        '    con.Open()
        '    cmd.Connection = con
        '    cmd.CommandType = CommandType.Text
        'End If
        If deleteanswer = "yes" Then
            Dim i As Integer
            i = dgv1.RowCount - 1
            While i >= 0
                If FileIO.FileSystem.DirectoryExists(dgv1.Rows(i).Cells(0).Value) Then
                    FileIO.FileSystem.DeleteDirectory(dgv1.Rows(i).Cells(0).Value, FileIO.DeleteDirectoryOption.DeleteAllContents)
                ElseIf FileIO.FileSystem.DirectoryExists(dgv1.Rows(i).Cells(4).Value) Then
                    FileIO.FileSystem.DeleteDirectory(dgv1.Rows(i).Cells(4).Value, FileIO.DeleteDirectoryOption.DeleteAllContents)
                End If
                i = i - 1
            End While

            'cmd.CommandText = "delete from files where uname='" & Label1.Text & "'"
            'cmd.ExecuteNonQuery()
            'cmd.CommandText = "delete from users where uname='" & Label1.Text & "'"
            'cmd.ExecuteNonQuery()
            'Dim sw1 As New IO.StreamWriter("C:\Users\Abri\Desktop\ff\abriii\a.txt")
            ifsr = New IsolatedStorageFileStream("files.txt", FileMode.Open, isostr)
            ifsw = New IsolatedStorageFileStream("tempfiles.txt", FileMode.Append, isostr)
            Dim sw1 As New StreamWriter(ifsw)
            Dim sr1 As New StreamReader(ifsr)
            While sr1.Peek <> -1
                'For Each line In System.IO.File.ReadLines("C:\Users\Abri\Desktop\ff\abriii\aa.txt")
                Dim line = sr1.ReadLine
                If Not line.Contains(Label1.Text.Trim & "|") Then
                    sw1.Write(line & vbNewLine)
                End If
                'Next
            End While
            'sw1.Close()
            ' sw1.Close()
            sw1.Close()
            sr1.Close()
            sr1.Dispose()
            sw1.Dispose()
            ifsr.Close()
            ifsw.Close()
            ifsw.Dispose()
            ifsr.Dispose()
            ifsr = New IsolatedStorageFileStream("tempfiles.txt", FileMode.Open, isostr)
            ifsw = New IsolatedStorageFileStream("files.txt", FileMode.Truncate, isostr)
            Dim sr2 As New StreamReader(ifsr)
            Dim sw2 As New StreamWriter(ifsw)
            ' Dim sw2 As New IO.StreamWriter("C:\Users\Abri\Desktop\ff\abriii\aa.txt")
            While sr2.Peek <> -1
                ' For Each line In System.IO.File.ReadLines("C:\Users\Abri\Desktop\ff\abriii\a.txt")
                ' If Not line.Contains((Label1.Text.Trim & "|" & dgv1.Rows(e.RowIndex).Cells(0).Value.ToString.Trim).ToString.Trim) Then
                Dim line = sr2.ReadLine
                sw2.Write(line & vbNewLine)
                ' end if
                'Next
            End While
            'sw2.Write(Label1.Text.Trim & "|" & dgv1.SelectedRows(row).Cells(0).Value.ToString.Trim & "|" & dgv1.SelectedRows(row).Cells(4).Value.ToString.Trim & vbNewLine)
            sw2.Close()
            'sw1.Close()
            ' sw1.Close()
            sr2.Close()
            sr2.Dispose()
            sw2.Dispose()
            ifsr.Close()
            ifsw.Close()
            ifsw.Dispose()
            ifsr.Dispose()
            ' IO.File.Delete("C:\Users\Abri\Desktop\ff\abriii\a.txt")
            isostr.DeleteFile("tempfiles.txt")
            ifsr = New IsolatedStorageFileStream("users.txt", FileMode.Open, isostr)
            ifsw = New IsolatedStorageFileStream("temp.txt", FileMode.Append, isostr)
            Dim swuser1 As New StreamWriter(ifsw)
            Dim sruser1 As New StreamReader(ifsr)
            'Dim swuser1 As New IO.StreamWriter("C:\Users\Abri\Desktop\ff\abriii\a.txt")
            While sruser1.Peek <> -1
                Dim line = sruser1.ReadLine
                'For Each line In System.IO.File.ReadLines("C:\Users\Abri\Desktop\ff\abriii\xx.txt")
                If Not line.Contains(Label1.Text.Trim & "|") Then
                    swuser1.Write(line & vbNewLine)
                End If
                'Next
            End While
            swuser1.Close()
            swuser1.Dispose()
            sruser1.Close()
            sruser1.Dispose()
            ifsr.Close()
            ifsr.Dispose()
            ifsw.Close()
            ifsw.Dispose()
            ifsr = New IsolatedStorageFileStream("temp.txt", FileMode.Open, isostr)
            ifsw = New IsolatedStorageFileStream("users.txt", FileMode.Truncate, isostr)
            Dim swuser2 As New StreamWriter(ifsw)
            Dim sruser2 As New StreamReader(ifsr)
            'Dim swuser2 As New IO.StreamWriter("C:\Users\Abri\Desktop\ff\abriii\xx.txt")
            While sruser2.Peek <> -1
                Dim line = sruser2.ReadLine
                'For Each line In System.IO.File.ReadLines("C:\Users\Abri\Desktop\ff\abriii\a.txt")
                ' If Not line.Contains((Label1.Text.Trim & "|" & dgv1.Rows(e.RowIndex).Cells(0).Value.ToString.Trim).ToString.Trim) Then
                swuser2.Write(line & vbNewLine)
                ' end if
                'Next
            End While
            'sw2.Write(Label1.Text.Trim & "|" & dgv1.SelectedRows(row).Cells(0).Value.ToString.Trim & "|" & dgv1.SelectedRows(row).Cells(4).Value.ToString.Trim & vbNewLine)
            'swuser2.Close()
            swuser2.Close()
            swuser2.Dispose()
            sruser2.Close()
            sruser2.Dispose()
            ifsr.Close()
            ifsr.Dispose()
            ifsw.Close()
            ifsw.Dispose()
            ' IO.File.Delete("C:\Users\Abri\Desktop\ff\abriii\a.txt")
            isostr.DeleteFile("temp.txt")

        ElseIf deleteanswer = "no" Then
            Exit Sub
        Else
            Exit Sub
        End If
        'If con.State = ConnectionState.Open Then
        '    con.Close()
        'End If
    End Sub


    Private Sub addfiles()
        'MsgBox(l4.Text.IndexOf("'"))
        'MsgBox(l4.Text.LastIndexOf("'"))
        'If con.State = ConnectionState.Closed Then
        '    con.Open()
        'End If
        'MsgBox(l4.Text.Substring(l4.Text.IndexOf("'") + 1, l4.Text.LastIndexOf("'") - 1 - l4.Text.IndexOf("'")).Length)
        'cmd.Connection = con
        fbd.ShowDialog()
        Dim str As String
        str = fbd.SelectedPath
        If str = "" Then
            Exit Sub
        Else
            If str.Contains(".{") Then
                MessageBox.Show("This is not valid folder name...", "Invalid folder", MessageBoxButtons.OK)
                Exit Sub
            End If
            Dim inr As Integer
            inr = 0
            'check whether it is added to the grid
            While inr < dgv1.Rows.Count
                If dgv1.Rows(inr).Cells(0).Value = str Then
                    frmmessage.Text = "Folder Conflict..."
                    frmmessage.Label1.Text = "FOLDER PATH ALREADY ADDED TO THIS LOCKER..."
                    frmmessage.ShowDialog()
                    Exit Sub
                End If
                inr = inr + 1
            End While

        End If
        '  path = str.Substring(0, str.LastIndexOf("\") + 1)
        ' foldername = str.Substring(str.LastIndexOf("\") + 1)
        ifsw = New IsolatedStorageFileStream("files.txt", FileMode.Append, isostr)
        Dim sw As New StreamWriter(ifsw)
        sw.Write(Label1.Text & "|" & str & "|not" & vbNewLine)
        sw.Close()
        sw.Dispose()
        ifsw.Close()
        ifsw.Dispose()
        dgv1.Rows.Add(New String() {str, "Accessible", "OpenFolder", "Lock", "not"})
        'Dim sw As New IO.StreamWriter("C:\Users\Abri\Desktop\ff\abriii\aa.txt", True)
        'Dim i As Integer
        'i = Label1.Text.Length
        'cmd.Parameters.Add(New SqlParameter("@uname", SqlDbType.VarChar, i, ParameterDirection.Input, False, 0, 0, "uname", DataRowVersion.Proposed, Label1.Text))
        'cmd.Parameters.Add(New SqlParameter("@dir", SqlDbType.VarChar, str.ToString.Length, ParameterDirection.Input, False, 0, 0, "dir", DataRowVersion.Proposed, str))
        'cmd.Parameters.Add(New SqlParameter("@hiden", SqlDbType.VarChar, 30, ParameterDirection.Input, False, 0, 0, "hiden", DataRowVersion.Proposed, "not"))
        ''cmd.CommandText = "insert into files(uname,dir,hiden) values('" & Label1.Text & "','" & dgv1.Rows(e.RowIndex).Cells(0).Value & "','" & dgv1.Rows(e.RowIndex).Cells(4).Value & "')"
        ''MsgBox(dgv1.Rows(e.RowIndex).Cells(0).Value)
        '' MsgBox(dgv1.Rows(e.RowIndex).Cells(4).Value)
        '' MsgBox(Label1.Text)
        'cmd.CommandText = "INSERT INTO files (uname, dir, hiden) VALUES(@uname,@dir,@hiden)"
        'cmd.ExecuteNonQuery()
        'cmd.Parameters.Clear()
    End Sub

    Private Sub dgv1_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dgv1.RowsAdded
        l4.Text = "THE FILES LOCKED AND MANAGED BY THE USER '" & Label1.Text & "' ARE(" & dgv1.Rows.Count & "):"
    End Sub

    Private Sub dgv1_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles dgv1.RowsRemoved
        If Not dgv1.Rows.Count > 0 Then
            l4.Text = "YOU('" & Label1.Text.ToString.ToUpper & "') HAVE NO FILES LOCKED... BUT YOU CAN ADD NOW:"
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add.Click
        addfiles()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selectall.Click
        dgv1.SelectAll()
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles unselect.Click
        dgv1.ClearSelection()
    End Sub

    Private Sub ContextMenuStrip2_Opening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip2.Opening
        'MsgBox("hi")
        If dgv1.RowCount > 0 Then
            ContextMenuStrip2.Items(2).Enabled = True
        Else
            ContextMenuStrip2.Items(2).Enabled = False
        End If
        If Not dgv1.SelectedRows.Count > 0 Then
            ContextMenuStrip2.Items(3).Enabled = False
            ContextMenuStrip2.Items(4).Enabled = False
            ContextMenuStrip2.Items(5).Enabled = False
            ContextMenuStrip2.Items(6).Enabled = False
        Else
            ContextMenuStrip2.Items(4).Enabled = True
            ContextMenuStrip2.Items(5).Enabled = True
            ContextMenuStrip2.Items(6).Enabled = True
            ContextMenuStrip2.Items(3).Enabled = True
        End If

       
    End Sub
    Public Sub unlocker(ByVal rowno As Integer)
        'If con.State = ConnectionState.Closed Then
        '    con.Open()
        '    cmd.Connection = con
        '    cmd.CommandType = CommandType.Text
        'End If
        If dgv1.SelectedRows(rowno).Cells(4).Value <> "" Then
            'unlock it here 
            statuss = arr(1)

            Dim d As DirectoryInfo = New DirectoryInfo(dgv1.SelectedRows(rowno).Cells(4).Value)
            Dim selectedpath As String = d.Parent.FullName + d.Name

            'ProgressBar1.Value = 40
            'ProgressBar1.Value = 100

            If dgv1.SelectedRows(rowno).Cells(4).Value.LastIndexOf(".{") = -1 Then
                MsgBox("THE FOLDER IS ALREADY OPEN/UNLOCKED...")
                'If (Not d.Root.Equals(d.Parent.FullName)) Then
                '    d.MoveTo(d.Parent.FullName & "\" & d.Name & status)
                'Else
                '    d.MoveTo(d.Parent.FullName + d.Name & status)
                'End If

                'TextBox2.Text = FolderBrowserDialog1.SelectedPath
                'ProgressBar1.Value = 100
                'ProgressBar1.Value = 100
            Else

                statuss = getstatus(statuss)
                d.MoveTo(dgv1.SelectedRows(rowno).Cells(4).Value.Substring(0, dgv1.SelectedRows(rowno).Cells(4).Value.LastIndexOf(".")))
                'TextBox2.Text = dgv1.selectedrows(rowno).Cells(0).Value.Substring(0, dgv1.selectedrows(rowno).Cells(0).Value.LastIndexOf("."))
                'cmd.CommandText = "update files set hiden='not' where uname='" & Label1.Text & "' and dir='" & dgv1.SelectedRows(rowno).Cells(0).Value & "'"
                'cmd.ExecuteNonQuery()
                ifsr = New IsolatedStorageFileStream("files.txt", FileMode.Open, isostr)
                ifsw = New IsolatedStorageFileStream("tempfiles.txt", FileMode.Append, isostr)
                Dim sw1 As New StreamWriter(ifsw)
                Dim sr1 As New StreamReader(ifsr)
                'Dim sw1 As New IO.StreamWriter("C:\Users\Abri\Desktop\ff\abriii\a.txt")
                While sr1.Peek > -1
                    'For Each line In System.IO.File.ReadLines("C:\Users\Abri\Desktop\ff\abriii\aa.txt")
                    Dim line = sr1.ReadLine
                    If Not line.Contains(Label1.Text.Trim & "|" & dgv1.SelectedRows(rowno).Cells(0).Value.ToString.Trim) Then
                        sw1.Write(line & vbNewLine)
                    End If
                    'Next
                End While
                sw1.Close()
                sw1.Dispose()
                sr1.Close()
                sr1.Dispose()
                ifsr.Close()
                ifsr.Dispose()
                ifsw.Close()
                ifsw.Dispose()
                ifsw = New IsolatedStorageFileStream("files.txt", FileMode.Truncate, isostr)
                ifsr = New IsolatedStorageFileStream("tempfiles.txt", FileMode.Open, isostr)
                Dim sw2 As New StreamWriter(ifsw)
                Dim sr2 As New StreamReader(ifsr)
                'Dim sw2 As New IO.StreamWriter("C:\Users\Abri\Desktop\ff\abriii\aa.txt")
                While sr2.Peek > -1
                    Dim line = sr2.ReadLine
                    ' For Each line In System.IO.File.ReadLines("C:\Users\Abri\Desktop\ff\abriii\a.txt")
                    'If Not line.Contains((Label1.Text.Trim & "|" & dgv1.Rows(e.RowIndex).Cells(0).Value.ToString.Trim).ToString.Trim) Then
                    sw2.Write(line & vbNewLine)
                    'end if
                    'Next
                End While
                sw2.Write(Label1.Text.Trim & "|" & dgv1.SelectedRows(rowno).Cells(0).Value.ToString.Trim & "|not" & vbNewLine)
                sw2.Close()
                sw2.Dispose()
                sr2.Close()
                sr2.Dispose()
                ifsr.Close()
                ifsr.Dispose()
                ifsw.Close()
                ifsw.Dispose()
                '  IO.File.Delete("C:\Users\Abri\Desktop\ff\abriii\a.txt")
                isostr.DeleteFile("tempfiles.txt")
                ' CType(dgv1.SelectedRows(rowno).Cells(2).Value, System.Windows.Forms.Button).Enabled = True
                dgv1.SelectedRows(rowno).Cells(3).Value = "Lock"
                dgv1.SelectedRows(rowno).Cells(1).Value = "Accessible"
                dgv1.SelectedRows(rowno).Cells(4).Value = "not"
            End If

        End If
    End Sub

    Private Sub unlock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles unlock.Click
        Dim i As Integer
        i = dgv1.SelectedRows.Count - 1
        While i >= 0
            If dgv1.SelectedRows(i).Cells(1).Value = "Locked" Then
                unlocker(i)
            End If
            i = i - 1
        End While
    End Sub

    Private Sub lock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lock.Click
        Dim j As Integer
        j = dgv1.SelectedRows.Count - 1
        While j >= 0
            If dgv1.SelectedRows(j).Cells(1).Value = "Accessible" Then
                locker(j)
            End If
            j = j - 1
        End While
    End Sub

    Private Sub delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delete.Click
        ' frmremove.Label1.Text = "Are you sure you want to remove those folders from the locker?"
        frmremove.ShowDialog()
        If remove = "yes" Then
            Dim j As Integer
            j = dgv1.SelectedRows.Count - 1
            While j >= 0
                If dgv1.SelectedRows(j).Cells(1).Value = "Accessible" Then
                    remover(j)
                Else
                    unlocker(j)
                    remover(j)
                End If
                j = j - 1
            End While
        End If
    End Sub
    Public Sub remover(ByVal row As Integer)
        If remove = "no" Then
            Exit Sub
        End If
        'If con.State = ConnectionState.Closed Then
        '    con.Open()
        '    cmd.Connection = con
        '    cmd.CommandType = CommandType.Text
        'End If

        If remove = "yes" Then
            'cmd.CommandText = "delete from files where dir='" & dgv1.SelectedRows(row).Cells(0).Value & "' and uname='" & Label1.Text & "'"
            'cmd.ExecuteNonQuery()
            ifsr = New IsolatedStorageFileStream("files.txt", FileMode.Open, isostr)
            ifsw = New IsolatedStorageFileStream("tempfiles.txt", FileMode.Append, isostr)
            Dim sw1 As New StreamWriter(ifsw)
            Dim sr1 As New StreamReader(ifsr)
            'Dim sw1 As New IO.StreamWriter("C:\Users\Abri\Desktop\ff\abriii\a.txt")
            While sr1.Peek <> -1
                Dim line = sr1.ReadLine
                'For Each line In System.IO.File.ReadLines("C:\Users\Abri\Desktop\ff\abriii\aa.txt")
                If Not line.Contains(Label1.Text.Trim & "|" & dgv1.SelectedRows(row).Cells(0).Value.ToString.Trim) Then
                    sw1.Write(line & vbNewLine)
                End If
                'Next
            End While
            sw1.Close()
            sw1.Dispose()
            sr1.Close()
            sr1.Dispose()
            ifsr.Close()
            ifsr.Dispose()
            ifsw.Close()
            ifsw.Dispose()
            ifsw = New IsolatedStorageFileStream("files.txt", FileMode.Truncate, isostr)
            ifsr = New IsolatedStorageFileStream("tempfiles.txt", FileMode.Open, isostr)
            Dim sw2 As New StreamWriter(ifsw)
            Dim sr2 As New StreamReader(ifsr)
            ' Dim sw2 As New IO.StreamWriter("C:\Users\Abri\Desktop\ff\abriii\aa.txt")
            While sr2.Peek <> -1
                Dim line = sr2.ReadLine
                'For Each line In System.IO.File.ReadLines("C:\Users\Abri\Desktop\ff\abriii\a.txt")
                'If Not line.Contains((Label1.Text.Trim & "|" & dgv1.Rows(e.RowIndex).Cells(0).Value.ToString.Trim).ToString.Trim) Then
                sw2.Write(line & vbNewLine)
                'end if
                'Next
            End While
            ' sw2.Write(Label1.Text.Trim & "|" & dgv1.SelectedRows(row).Cells(0).Value.ToString.Trim & "|not" & vbNewLine)
            sw2.Close()
            sw2.Dispose()
            sr2.Close()
            sr2.Dispose()
            ifsr.Close()
            ifsr.Dispose()
            ifsw.Close()
            ifsw.Dispose()
            ' IO.File.Delete("C:\Users\Abri\Desktop\ff\abriii\a.txt")
            isostr.DeleteFile("tempfiles.txt")
            dgv1.Rows.Remove(dgv1.SelectedRows(row))
        End If

    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        dgv1.Refresh()
        dgv1.SelectAll()
        dgv1.ClearSelection()
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Dim i As Integer
        dgv1.SelectAll()
        i = dgv1.SelectedRows.Count - 1
        While i >= 0
            If Not dgv1.SelectedRows(i).Cells(1).Value = "Locked" Then
                locker(i)
            End If
            i = i - 1
        End While
        Me.Close()
        frmmain.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer
        i = dgv1.SelectedRows.Count - 1
        While i >= 0
            If dgv1.SelectedRows(i).Cells(1).Value = "Locked" Then
                unlocker(i)
            End If
            i = i - 1
        End While
    End Sub

    Private Sub btnadd_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnadd.MouseEnter
        btnadd.BackColor = Color.FromArgb(123, 60, 250)
    End Sub

    Private Sub btnadd_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnadd.MouseLeave
        btnadd.BackColor = Color.FromArgb(128, 128, 255)
    End Sub

    Private Sub btnlock_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnlock.MouseEnter
        btnlock.BackColor = Color.FromArgb(123, 60, 250)
    End Sub

    Private Sub btnlock_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnlock.MouseLeave
        btnlock.BackColor = Color.FromArgb(128, 128, 255)
    End Sub

    Private Sub Button1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter
        Button1.BackColor = Color.FromArgb(123, 60, 250)
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.FromArgb(128, 128, 255)
    End Sub

    Private Sub btndeletes_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btndeletes.MouseEnter
        btndeletes.BackColor = Color.FromArgb(123, 60, 250)
    End Sub

    Private Sub btndeletes_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btndeletes.MouseLeave
        btndeletes.BackColor = Color.FromArgb(128, 128, 255)
    End Sub

    Private Sub btndelete_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btndelete.MouseEnter
        btndelete.BackColor = Color.FromArgb(123, 60, 250)
    End Sub

    Private Sub btndelete_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btndelete.MouseLeave
        btndelete.BackColor = Color.FromArgb(128, 128, 255)
    End Sub

    Private Sub btnclose_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnclose.MouseEnter
        btnclose.BackColor = Color.FromArgb(123, 60, 250)
    End Sub

    Private Sub btnclose_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnclose.MouseLeave
        btnclose.BackColor = Color.FromArgb(128, 128, 255)
    End Sub
End Class