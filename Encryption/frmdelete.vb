Public Class frmdelete

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn.Click
        frmencrypt.deleteanswer = "yes"
        Me.Close()
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frmencrypt.deleteanswer = "no"
        Me.Close()
    End Sub

    Private Sub frmdelete_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmencrypt.deleteanswer = "no"
        Me.Width = Label1.Width + 60
    End Sub

    Private Sub btn_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn.MouseEnter
        btn.BackColor = Color.LimeGreen
    End Sub

    Private Sub btn_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn.MouseLeave
        btn.BackColor = Color.Lime
    End Sub

    Private Sub Button2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseEnter
        Button2.BackColor = Color.LimeGreen
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Button2.BackColor = Color.Lime
    End Sub

   
End Class