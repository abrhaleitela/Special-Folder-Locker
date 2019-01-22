'Imports System.Data.SqlClient

Public Class frmmain
    'Dim con As New SqlConnection
    'Dim rdr As SqlDataReader
    'Dim cmd As New SqlCommand
    '  Dim pressedbtn As String
    Public loginmess As Boolean
    Public closemessanswer As String
    Private Sub frmmain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pnldeafult.Visible = True

        closemessanswer = "close"
        loginmess = False
        ' con.ConnectionString = "Data Source=ABRI-PC\SQLEXPRESS;Initial Catalog=users;Integrated Security=True"
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If loginmess = True Then
            frmclosemessage.ShowDialog()
            If closemessanswer = "cancel" Then
                Exit Sub
            End If
        End If
        frmcontact.Close()
        pnldeafult.Visible = False
        ' pnlregister.Visible = True
        frmpassrec.Close()
        frmencrypt.Close()
        frmregister.MdiParent = Me
        frmregister.Show()


    End Sub

    Private Sub frmmain_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.Size = New Size(957, 656)
    End Sub



    'Private Sub btnregister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    pnldeafult.Visible = False
    '    ' pnlregister.Visible = True
    '    frmpassrec.Close()
    '    frmencrypt.Close()
    '    frmregister.MdiParent = Me
    '    frmregister.Show()


    'End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If loginmess = True Then
            frmclosemessage.ShowDialog()
            If closemessanswer = "cancel" Then
                Exit Sub
            End If
        End If
        pnldeafult.Visible = False
        ' pnlregister.Visible = True
        frmregister.Close()
        frmencrypt.Close()
        frmcontact.Close()
        frmpassrec.MdiParent = Me
        frmpassrec.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If loginmess = True Then
            frmclosemessage.ShowDialog()
            If closemessanswer = "cancel" Then
                Exit Sub
            End If
        End If
        pnldeafult.Visible = False
        ' pnlregister.Visible = True
        frmpassrec.Close()
        frmregister.Close()
        frmencrypt.Close()
        frmcontact.Close()
        frmlogin.MdiParent = Me
        frmlogin.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If loginmess = True Then
            frmclosemessage.ShowDialog()
            If closemessanswer = "cancel" Then
                Exit Sub
            End If
        End If
        pnldeafult.Visible = True
        ' pnlregister.Visible = True
        frmpassrec.Close()
        frmregister.Close()
        frmencrypt.Close()
        frmlogin.Close()
        frmcontact.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        pnldeafult.Visible = False
        ' pnlregister.Visible = True
        frmpassrec.Close()
        frmregister.Close()
        frmencrypt.Close()
        frmlogin.Close()
        frmcontact.MdiParent = Me
        frmcontact.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

    End Sub
End Class
