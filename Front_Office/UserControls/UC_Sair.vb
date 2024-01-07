Public Class UC_Sair
    Private Sub UC_Sair_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub picEntrar_Enter(sender As Object, e As EventArgs) Handles Me.Enter
        picSair.Image = My.Resources.SairLoginShade
    End Sub

    Private Sub picEntrar_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        picSair.Image = My.Resources.SairLogin
    End Sub

    Private Sub picSair_Click(sender As Object, e As EventArgs) Handles picSair.Click
        End
    End Sub

    Private Sub picSair_KeyPress(sender As Object, e As KeyPressEventArgs) Handles picSair.KeyPress, Me.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            End
        End If
    End Sub
End Class
