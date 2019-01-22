Imports System.IO.IsolatedStorage
Imports System.IO
Public Class frmlogin
    Dim ifsw As IsolatedStorageFileStream
    Dim ifsr As IsolatedStorageFileStream
    Dim isostr As IsolatedStorageFile
    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        'frmdecrypt.Close()
        'pnldeafult.Visible = False
        'frmpassrec.Close()
        'frmencrypt.MdiParent = Me
        'frmencrypt.Show()

        'con.Open()
        'cmd.Connection = con
        'cmd.CommandText = "select count(*) from users where uname='" & txtuname.Text & "'"
        'Dim k As Integer
        'k = cmd.ExecuteScalar()
        'If k = 0 Then
        If isostr.FileExists("users.txt") Then
            ifsr = New IsolatedStorageFileStream("users.txt", IO.FileMode.Open, isostr)
            Dim sr1 As New StreamReader(ifsr)
            '        For Each line In IO.File.ReadLines("C:\Users\Abri\Desktop\ff\abriii\xx.txt")
            While sr1.Peek <> -1
                Dim line = sr1.ReadLine
                If line.Contains("|") Then
                    Dim n = line.ToString.Split("|")
                    If n(1) = txtuname.Text And n(2) = txtpassword.Text Then
                        'cmd.CommandText = "select * from users where uname='" & txtuname.Text & "'"
                        'rdr = cmd.ExecuteReader
                        'rdr.Read()
                        'If rdr.GetValue(2) = txtpassword.Text Then
                        'login granetd
                        'frmencrypt.IsMdiChild = True
                        ' PictureBox1.SendToBack()
                        'rdr.Close()
                        'cmd.CommandText = "select * from files where uname='" & txtuname.Text & "'"
                        'rdr = cmd.ExecuteReader
                        frmdecrypt.Close()
                        frmmain.pnldeafult.Visible = False
                        frmpassrec.Close()
                        frmencrypt.MdiParent = frmmain
                        frmencrypt.Label1.Text = txtuname.Text.ToString
                        sr1.Close()
                        sr1.Dispose()
                        ifsr.Close()
                        ifsr.Dispose()
                        ifsr = New IsolatedStorageFileStream("files.txt", FileMode.Open, isostr)
                        Dim sr2 As New StreamReader(ifsr)
                        While sr2.Peek <> -1
                            'For Each row In IO.File.ReadLines("C:\Users\Abri\Desktop\ff\abriii\aa.txt")
                            Dim row = sr2.ReadLine
                            If row.Contains("|") Then
                                Dim arr = row.ToString.Split("|")
                                If arr(0).Trim = txtuname.Text Then
                                    If arr(2).Trim = "not" Then
                                        frmencrypt.dgv1.Rows.Add(New String() {arr(1).ToString.Trim, "Accessible", "OpenFolder", "Lock", "not"})
                                    Else
                                        frmencrypt.dgv1.Rows.Add(New String() {arr(1).ToString.Trim, "Locked", "OpenFolder", "UnLock", arr(2).ToString.Trim})
                                        ' CType(frmencrypt.dgv1.Rows(frmencrypt.dgv1.RowCount - 1).Cells(2)., System.Windows.Forms.Button).Enabled = False
                                    End If
                                End If
                            End If
                            'next
                        End While
                        sr2.Close()
                        ' sr2.Close()
                        sr2.Dispose()
                        ifsr.Close()
                        ifsr.Dispose()
                        If frmencrypt.dgv1.RowCount > 0 Then
                            frmencrypt.l4.Text = "THE FOLDERS LOCKED AND MANAGED BY THE LOCKERNAME '" & txtuname.Text.ToString.ToUpper & "' ARE(" & frmencrypt.dgv1.RowCount & "):"
                        Else
                            frmencrypt.l4.Text = "YOU('" & txtuname.Text.ToString.ToUpper & "') HAVE NO FILES LOCKED... BUT YOU CAN ADD NOW:"
                        End If
                        'If rdr.IsClosed = False Then
                        '    rdr.Close()
                        'End If
                        'If Not con.State = ConnectionState.Closed Then
                        '    con.Close()
                        'End If
                        txtpassword.Text = ""
                        txtuname.Text = ""
                        frmmain.loginmess = True
                        frmencrypt.Show()
                        Exit Sub
                    End If
                End If
            End While
            frmmain.loginmess = False
            frmmessage.Text = "Login Failed..."
            frmmessage.Label1.Text = "INVALID LOGIN ATTEMPT..."
            frmmessage.ShowDialog()
            txtpassword.Text = ""
            txtpassword.Focus()
            'rdr.Close()
            'con.Close()
            'UNAME not FOUND
            sr1.Close()
            sr1.Dispose()
            ifsr.Close()
            ifsr.Dispose()
        Else
            frmmain.loginmess = False
            frmmessage.Text = "Login Failed..."
            frmmessage.Label1.Text = "INVALID LOGIN ATTEMPT..."
            frmmessage.ShowDialog()
        End If
    End Sub

    Private Sub frmlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Location = New Point(200, 96)
        isostr = IsolatedStorageFile.GetStore(IsolatedStorageScope.User Or IsolatedStorageScope.Domain Or IsolatedStorageScope.Assembly, Nothing, Nothing)
        'con.ConnectionString = "Data Source=ABRI-PC\SQLEXPRESS;Initial Catalog=users;Integrated Security=True"
    End Sub

    Private Sub l4_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles l4.LinkClicked
        frmmain.pnldeafult.Visible = False
        ' pnlregister.Visible = True
        frmregister.Close()
        frmcontact.Close()
        frmpassrec.MdiParent = frmmain
        frmpassrec.Show()
        Me.Close()
    End Sub

    Private Sub btnregister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnregister.Click
        frmmain.pnldeafult.Visible = False
        'pnlregister.Visible = True
        frmpassrec.Close()
        frmcontact.Close()
        frmencrypt.Close()
        frmregister.MdiParent = frmmain
        frmregister.Show()
    End Sub

    Private Sub btnregister_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnregister.MouseEnter
        btnregister.BackColor = Color.FromArgb(123, 60, 250)
    End Sub


    Private Sub btnregister_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnregister.MouseLeave
        btnregister.BackColor = Color.FromArgb(128, 128, 255)
    End Sub

    Private Sub btnlogin_Mouseenter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnlogin.MouseEnter
        btnlogin.BackColor = Color.FromArgb(123, 60, 250)
    End Sub

    Private Sub btnlogin_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnlogin.MouseLeave
        btnlogin.BackColor = Color.FromArgb(128, 128, 255)
    End Sub
End Class