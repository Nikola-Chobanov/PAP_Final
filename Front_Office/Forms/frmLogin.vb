Imports DevExpress.XtraGrid.Views.Grid

Public Class frmLogin

    Dim mUserName = My.User.Name.Substring(5, 8)

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtUtilizador.Text = mUserName
        txtPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub btnEntrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntrar.Click
        Testa()
    End Sub

    'Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
    '    If e.KeyChar = ChrW(Keys.Enter) Then
    '        Testa()
    '    End If
    'End Sub

    Sub Testa()
        Dim mU As String = Me.txtUtilizador.Text
        Dim mP As String = Me.txtPassword.Text

        If ClsEntidades.TestaEntidadesByUserName(mU, mP) Then
            ucDashboard.Nome = ClsEntidades.GetPicAndUser(mU).Nome
            ucDashboard.Fotografia = ClsEntidades.GetPicAndUser(mU).Fotografia
            Dim mFrm As New ucSplash
            mFrm.Show()
            Me.Hide()
        Else
            MsgBox("Utilizador ou Palavra-passe incorreto(s). Por favor tente novamente.")

            txtUtilizador.Text = mUserName
            txtPassword.Text = ""
            txtPassword.Focus()

        End If
    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        End
    End Sub

    Private Sub txtUtilizador_GotFocus(sender As Object, e As EventArgs) Handles txtUtilizador.GotFocus
        picUtilizador.Image = My.Resources.backLoginShade
    End Sub

    Private Sub txtUtilizador_Leave(sender As Object, e As EventArgs) Handles txtUtilizador.Leave
        picUtilizador.Image = My.Resources.backLogin
    End Sub

    Private Sub txtPassword_GotFocus(sender As Object, e As EventArgs) Handles txtPassword.GotFocus
        picPassword.Image = My.Resources.backLoginShade
    End Sub

    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
        picPassword.Image = My.Resources.backLogin
    End Sub

    Private Sub btnEntrar_GotFocus(sender As Object, e As EventArgs) Handles btnEntrar.GotFocus
        btnEntrar.BackgroundImage = My.Resources.EntrarShade
    End Sub

    Private Sub btnEntrar_Leave(sender As Object, e As EventArgs) Handles btnEntrar.Leave
        btnEntrar.BackgroundImage = My.Resources.Entrar
    End Sub

    Private Sub btnSair_GotFocus(sender As Object, e As EventArgs) Handles btnSair.GotFocus
        btnSair.BackgroundImage = My.Resources.SairLoginShade
    End Sub

    Private Sub btnSair_Leave(sender As Object, e As EventArgs) Handles btnSair.Leave
        btnSair.BackgroundImage = My.Resources.SairLogin
    End Sub

    Private Sub btnEntrar_MouseMove(sender As Object, e As MouseEventArgs) Handles btnEntrar.MouseMove
        btnEntrar.BackgroundImage = My.Resources.EntrarShade
    End Sub

    Private Sub btnEntrar_MouseLeave(sender As Object, e As EventArgs) Handles btnEntrar.MouseLeave
        btnEntrar.BackgroundImage = My.Resources.Entrar
    End Sub

    Private Sub btnSair_MouseMove(sender As Object, e As MouseEventArgs) Handles btnSair.MouseMove
        btnSair.BackgroundImage = My.Resources.SairLoginShade
    End Sub

    Private Sub btnSair_MouseLeave(sender As Object, e As EventArgs) Handles btnSair.MouseLeave
        btnSair.BackgroundImage = My.Resources.SairLogin
    End Sub

    Private Sub picEyeLogin_Click(sender As Object, e As EventArgs) Handles picEyeLogin.Click
        If picEyeLogin.Tag = 1 Then
            txtPassword.UseSystemPasswordChar = True
            picEyeLogin.Tag = 0
            picEyeLogin.Image = My.Resources.OlhoA
        Else
            txtPassword.UseSystemPasswordChar = False
            picEyeLogin.Tag = 1
            picEyeLogin.Image = My.Resources.OlhoF
        End If
    End Sub


End Class
