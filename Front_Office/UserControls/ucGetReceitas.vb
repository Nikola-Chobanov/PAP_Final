Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class ucGetReceitas
    Private Sub ucGetReceitas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click

        TextBox2.Text = ClsLinhasTotais.GetReceita(TextBox1.Text)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click, PictureBox2.Click, PictureBox3.Click, PictureBox4.Click, PictureBox6.Click, PictureBox7.Click
        TextBox2.Text = ClsLinhasTotais.GetReceita(CInt(sender.tag))
        TextBox1.Text = sender.tag

    End Sub
End Class
