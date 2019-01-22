'Imports System.Data.SqlClient
Imports System.IO
Imports System.IO.IsolatedStorage
Public Class frmregister
    'Dim con As New SqlConnection
    'Dim rdr As SqlDataReader
    'Dim cmd As New SqlCommand
    Dim ifsw, ifsr As IsolatedStorageFileStream
    Dim isostr As IsolatedStorageFile
    Private Sub frmregister_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = New Point(200, 96)
        isostr = IsolatedStorageFile.GetStore(IsolatedStorageScope.User Or IsolatedStorageScope.Domain Or IsolatedStorageScope.Assembly, Nothing, Nothing)
        If Not isostr.FileExists("users.txt") Then
            isostr.CreateFile("users.txt")
        End If
        '   con.ConnectionString = "Data Source=ABRI-PC\SQLEXPRESS;Initial Catalog=users;Integrated Security=True"
    End Sub

    Private Sub btnregister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnregister.Click
        If txtcpwd.Text <> txtpwd.Text Then
            frmmessage.Label1.Text = "YOUR PASSWORD DOES NOT MATCH..."
            txtcpwd.Text = ""
            txtpwd.Text = ""
            txtpwd.Focus()
            frmmessage.ShowDialog()
            Exit Sub
        End If
        If Not err.GetError(txtpwd) = "" Or Not err.GetError(txtuname) = "" Or Not err.GetError(txtcpwd) = "" Or Not err.GetError(txtnname) = "" Or Not err.GetError(txtfplace) = "" Or Not err.GetError(txtmodel) = "" Or txtcpwd.Text = "" Or txtfplace.Text = "" Or txtmodel.Text = "" Or txtname.Text = "" Or txtnname.Text = "" Or txtuname.Text = "" Then
            frmmessage.Text = "Validation Error..."
            frmmessage.Label1.Text = "Fill all fields first..."
            frmmessage.ShowDialog()
            Exit Sub
        End If
        If txtcpwd.Text = "" Or txtfplace.Text = "" Or txtmodel.Text = "" Or txtname.Text = "" Or txtnname.Text = "" Or txtuname.Text = "" Then
            frmmessage.Text = "Validation Error..."
            frmmessage.Label1.Text = "Fill all fields first..."
            frmmessage.ShowDialog()
            Exit Sub
        End If
        'con.Open()
        'cmd.Connection = con
        'cmd.CommandText = "select count(*) from users where uname='" & txtuname.Text.Trim & "'"
        ifsr = New IsolatedStorageFileStream("users.txt", FileMode.Open, isostr)
        Dim sr1 As New StreamReader(ifsr)
        While sr1.Peek <> -1
            'For Each line In IO.File.ReadLines("C:\Users\Abri\Desktop\ff\abriii\xx.txt")
            '  Dim k = cmd.ExecuteScalar
            ' If k = 0 Then
            'cmd.CommandText = "insert into users(name,uname,pwd,fplace,model,nname) values(@name,@uname,@pwd,@fplace,@model,@nname) "
            'cmd.Parameters.Add(New SqlParameter("@name", SqlDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "name", DataRowVersion.Proposed, txtname.Text))
            'cmd.Parameters.Add(New SqlParameter("@uname", SqlDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "uname", DataRowVersion.Proposed, txtuname.Text))
            'cmd.Parameters.Add(New SqlParameter("@pwd", SqlDbType.VarChar, txtcpwd.Text.Length, ParameterDirection.Input, False, 0, 0, "pwd", DataRowVersion.Proposed, txtpwd.Text))
            'cmd.Parameters.Add(New SqlParameter("@fplace", SqlDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "fplace", DataRowVersion.Proposed, txtfplace.Text))
            'cmd.Parameters.Add(New SqlParameter("@model", SqlDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "model", DataRowVersion.Proposed, txtmodel.Text))
            'cmd.Parameters.Add(New SqlParameter("@nname", SqlDbType.VarChar, 50, ParameterDirection.Input, False, 0, 0, "nname", DataRowVersion.Proposed, txtnname.Text))
            'cmd.ExecuteNonQuery()
            Dim line = sr1.ReadLine
            If line.Contains("|") Then
                Dim n = line.ToString.Split("|")
                If n(1) = txtuname.Text Then
                    frmmessage.Text = "LockerName Conflict..."
                    frmmessage.Label1.Text = "THERE IS ALREADY SAME LOCKERNAME REGISTERED..."
                    frmmessage.ShowDialog()
                    txtuname.Text = ""
                    txtuname.Focus()
                    sr1.Close()
                    sr1.Dispose()
                    ifsr.Close()
                    ifsr.Dispose()
                    Exit Sub
                End If
            End If
        End While
        'next
        sr1.Close()
        sr1.Dispose()
        ifsr.Close()
        ifsr.Dispose()
        ifsw = New IsolatedStorageFileStream("users.txt", FileMode.Append, isostr)
        Dim sw As New StreamWriter(ifsw)
        'Dim sw As New IO.StreamWriter("C:\Users\Abri\Desktop\ff\abriii\xx.txt", True)
        sw.Write(txtname.Text & "|" & txtuname.Text & "|" & txtpwd.Text & "|" & txtfplace.Text & "|" & txtmodel.Text & "|" & txtnname.Text & vbNewLine)
        sw.Close()
        sw.Dispose()
        sr1.Close()
        sr1.Dispose()
        ifsw.Close()
        ifsw.Dispose()
        ifsr.Close()
        ifsr.Dispose()
        frmmessage.Text = "LockerName Saved..."
        frmmessage.Label1.Text = "THANK YOU FOR USING THIS LOCKER. YOU HAVE REGISTERED SUCCESSFULL."
        frmmessage.ShowDialog()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        frmmain.pnldeafult.Visible = True
        frmpassrec.Close()
        Me.Close()
    End Sub

    Private Sub btncancel_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btncancel.MouseEnter
        btncancel.BackColor = Color.FromArgb(123, 60, 250)
    End Sub

    Private Sub btncancel_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btncancel.MouseLeave
        btncancel.BackColor = Color.FromArgb(128, 128, 255)
    End Sub

    Private Sub btnregister_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnregister.MouseEnter
        btnregister.BackColor = Color.FromArgb(123, 60, 250)
    End Sub

    Private Sub btnregister_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnregister.MouseLeave
        btnregister.BackColor = Color.FromArgb(128, 128, 255)
    End Sub

    Private Sub txtuname_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtuname.LostFocus
        If txtuname.Text = "" Then
            err.SetError(txtuname, "Locker name should not be empty...")
        Else
            err.SetError(txtuname, "")
            err.Clear()
        End If
    End Sub

    Private Sub txtnname_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnname.LostFocus
        If txtnname.Text = "" Then
            err.SetError(txtnname, "This textbox should not be empty...")
        Else
            err.SetError(txtnname, "")
            err.Clear()
        End If
    End Sub

    Private Sub txtmodel_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtmodel.LostFocus
        If txtmodel.Text = "" Then
            err.SetError(txtmodel, "This textbox should not be empty...")
        Else
            err.SetError(txtmodel, "")
            err.Clear()
        End If
    End Sub

    Private Sub txtfplace_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtfplace.LostFocus
        If txtfplace.Text = "" Then
            err.SetError(txtfplace, "This textbox should not be empty...")
        Else
            err.SetError(txtfplace, "")
            err.Clear()
        End If
    End Sub

    Private Sub txtpwd_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpwd.LostFocus
        If txtpwd.Text = "" Then
            err.SetError(txtpwd, "You must enter a password...")
        Else
            err.SetError(txtpwd, "")
            err.Clear()
        End If
    End Sub

    Private Sub txtcpwd_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcpwd.LostFocus
        If txtpwd.Text = "" Or Not (txtpwd.Text.ToString.Equals(txtcpwd.Text.ToString)) Then
            err.SetError(txtcpwd, "You must confirm your password properly...")
        Else
            err.SetError(txtcpwd, "")
            err.Clear()
        End If
    End Sub

   
End Class