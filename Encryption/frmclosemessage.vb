Public Class frmclosemessage

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmmain.closemessanswer = "close"
        Dim i As Integer
        frmencrypt.dgv1.SelectAll()
        i = frmencrypt.dgv1.SelectedRows.Count - 1
        While i >= 0
            If Not frmencrypt.dgv1.SelectedRows(i).Cells(1).Value = "Locked" Then
                frmencrypt.locker(i)
            End If
            i = i - 1
        End While
        frmmain.loginmess = False
        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frmmain.closemessanswer = "cancel"
        Me.Close()
    End Sub

    Private Sub frmclosemessage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmmain.closemessanswer = "cancel"
    End Sub

    Private Sub Button2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseEnter
        Button2.BackColor = Color.LimeGreen
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Button2.BackColor = Color.Lime
    End Sub

    Private Sub Button1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter
        Button1.BackColor = Color.LimeGreen
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.Lime
    End Sub
End Class