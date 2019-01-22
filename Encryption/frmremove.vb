Public Class frmremove

    Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn.Click
        frmencrypt.remove = "yes"
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frmencrypt.remove = "no"
        Me.Close()
    End Sub

    Private Sub frmremove_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmencrypt.remove = "no"
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