Public Class ucUtilizador

    Public Property UText As String
        Get
            Return txtUtilizador.Text
        End Get
        Set(value As String)
            txtUtilizador.Text = value
        End Set
    End Property

    Private Sub txtUtilizador_Click(sender As Object, e As EventArgs) Handles txtUtilizador.Click, picUtilizador.Click
        txtUtilizador.Focus()
    End Sub

    ' Private Sub CheckKey(sender As Object, e As KeyEventArgs) Handles txtContent.KeyDown
    '     If e.KeyCode = Keys.Enter Then
    '         ClsLogin.LogIn_Action()
    '     End If
    ' End Sub

    Private Sub txtUtilizador_Enter(sender As Object, e As EventArgs) Handles txtUtilizador.Enter
        picUtilizador.Image = My.Resources.backLoginShade
    End Sub
    Private Sub txtUtilizador_Leave(sender As Object, e As EventArgs) Handles txtUtilizador.Leave
        picUtilizador.Image = My.Resources.backLogin
    End Sub
End Class
