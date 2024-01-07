Public Class UC_Entrar
    Private Sub ucBtn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtUtilizador_Enter(sender As Object, e As EventArgs) Handles Me.Enter
        picEntrar.Image = My.Resources.EntrarShade
    End Sub

    Private Sub txtUtilizador_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        picEntrar.Image = My.Resources.Entrar
    End Sub

    Private Sub PicEntrar_Click(sender As Object, e As EventArgs) Handles picEntrar.Click
        frmLogin.Testa()
    End Sub

    Private Sub PicEntrar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles picEntrar.KeyPress, Me.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            frmLogin.Testa()
        End If
    End Sub

End Class
