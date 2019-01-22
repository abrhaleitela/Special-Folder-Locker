'Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO.IsolatedStorage
Imports System.IO
Public Class frmpassrec
    'Dim con As New SqlConnection
    'Dim cmd As New SqlCommand
    'Dim rdr As SqlDataReader
    Dim ifsw, ifsr As IsolatedStorageFileStream
    Dim isostr As IsolatedStorageFile
    Dim uname, fpalce, model, nname, namee As String
    Private Sub frmpassrec_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = New Point(200, 96)
        uname = ""
        nname = ""
        fpalce = ""
        model = ""
        namee = ""
        '  con.ConnectionString = "Data Source=ABRI-PC\SQLEXPRESS;Initial Catalog=users;Integrated Security=True"
        isostr = IsolatedStorageFile.GetStore(IsolatedStorageScope.User Or IsolatedStorageScope.Domain Or IsolatedStorageScope.Assembly, Nothing, Nothing)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frmmain.pnldeafult.Visible = True
        frmregister.Close()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'If con.State = ConnectionState.Closed Then
        '    con.Open()
        '    cmd.Connection = con
        '    cmd.CommandType = CommandType.Text
        'End If
        'cmd.CommandText = "select pwd from users where uname='" & txtuname.Text & "' and fplace='" & txtfplace.Text & "' and model='" & txtmodel.Text & "' and  nname='" & txtnname.Text & "'"
        'rdr = cmd.ExecuteReader
        ifsr = New IsolatedStorageFileStream("users.txt", FileMode.Open, isostr)
        Dim sr1 As New StreamReader(ifsr)
        While sr1.Peek <> -1
            Dim line = sr1.ReadLine.Split("|")
            If line(1) = txtuname.Text And line(3) = txtfplace.Text And line(4) = txtmodel.Text And txtnname.Text = line(5) Then
                'rdr.Read()
                'txtpwd.Text = rdr.GetValue(0).ToString
                txtpwd.Enabled = True
                txtpwd.ReadOnly = False
                txtcpwd.Visible = True
                txtpwd.Visible = True
                lp.Visible = True
                l1.Visible = True
                btnchange.Visible = True
                uname = txtuname.Text
                nname = txtnname.Text
                fpalce = txtfplace.Text
                model = txtmodel.Text
                sr1.Close()
                sr1.Dispose()
                ifsr.Close()
                ifsr.Dispose()
                Exit Sub
            End If
            'If rdr.IsClosed = False Then
            '    rdr.Close()
            'End If
        End While
        sr1.Close()
        sr1.Dispose()
        ifsr.Close()
        ifsr.Dispose()
        MessageBox.Show("Your input is invalid...", "Password Recovery Error...", MessageBoxButtons.OK)
    End Sub

    Private Sub Button2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseEnter
        Button2.BackColor = Color.FromArgb(123, 60, 250)
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Button2.BackColor = Color.FromArgb(128, 128, 255)
    End Sub

    Private Sub Button1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter
        Button1.BackColor = Color.FromArgb(123, 60, 250)
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.FromArgb(128, 128, 255)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnchange.Click
        If txtcpwd.Text = "" Or txtpwd.Text = "" Then
            MessageBox.Show("You need to enter new password first...", "Input Error...", MessageBoxButtons.OK)
            Exit Sub
        End If
        If Not txtcpwd.Text = txtpwd.Text Then
            MessageBox.Show("Password mismatch...", "Input Error...", MessageBoxButtons.OK)
            Exit Sub
        End If
        ifsr = New IsolatedStorageFileStream("users.txt", FileMode.Open, isostr)
        ifsw = New IsolatedStorageFileStream("temp.txt", FileMode.Append, isostr)
        Dim sr As New StreamReader(ifsr)
        Dim sw As New StreamWriter(ifsw)
        While sr.Peek <> -1
            Dim lin = sr.ReadLine
            Dim line = lin.Split("|")
            If Not (line(1) = uname And line(3) = fpalce And line(4) = model And line(5) = nname) Then
                sw.Write(lin & vbNewLine)
            Else
                namee = line(0)
            End If
        End While
        sr.Close()
        sr.Dispose()
        sw.Close()
        sw.Dispose()
        ifsr.Close()
        ifsr.Dispose()
        ifsw.Close()
        ifsw.Dispose()
        ifsw = New IsolatedStorageFileStream("users.txt", FileMode.Truncate, isostr)
        ifsr = New IsolatedStorageFileStream("temp.txt", FileMode.Open, isostr)
        Dim sw1 As New StreamWriter(ifsw)
        Dim sr1 As New StreamReader(ifsr)
        While sr1.Peek <> -1
            Dim ll = sr1.ReadLine
            sw1.Write(ll & vbNewLine)
        End While
        sw1.Write(namee & "|" & uname & "|" & txtpwd.Text & "|" & fpalce & "|" & model & "|" & nname & vbNewLine)
        sr1.Close()
        sr1.Dispose()
        sw1.Close()
        sw1.Dispose()
        ifsr.Close()
        ifsr.Dispose()
        ifsw.Close()
        ifsw.Dispose()
        isostr.DeleteFile("temp.txt")
        txtcpwd.Text = ""
        txtcpwd.Visible = False
        txtpwd.Text = ""
        txtpwd.Visible = False
        l1.Visible = False
        lp.Visible = False
        btnchange.Visible = False
    End Sub

    Private Sub Button3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnchange.MouseEnter
        btnchange.BackColor = Color.FromArgb(123, 60, 250)
    End Sub

    Private Sub Button3_Mouseleave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnchange.MouseLeave
        btnchange.BackColor = Color.FromArgb(128, 128, 255)
    End Sub
End Class