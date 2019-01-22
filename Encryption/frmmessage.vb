Public Class frmmessage

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        Me.Close()
    End Sub

    Private Sub frmmessage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Width = Label1.Width + 50
        btnok.Location = New Point(Me.Width / 2 - 60, 76)
    End Sub

    Private Sub btnok_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnok.MouseEnter
        btnok.BackColor = Color.LimeGreen
    End Sub

    Private Sub btnok_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnok.MouseLeave
        btnok.BackColor = Color.Lime
    End Sub
End Class