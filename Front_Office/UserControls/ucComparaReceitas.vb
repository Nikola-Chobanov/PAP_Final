Imports DevExpress.Pdf.Native.BouncyCastle.Utilities

Public Class ucComparaReceitas
    Private Sub ucComparaReceitas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Dim strdata1 As String = TextBox1.Text & "-" & TextBox6.Text & "-" & TextBox7.Text
        Dim data1 As DateTime = Convert.ToDateTime(strdata1)

        Dim strdata2 As String = TextBox5.Text & "-" & TextBox4.Text & "-" & TextBox3.Text
        Dim data2 As DateTime = Convert.ToDateTime(strdata2)

        Dim strdata3 As String = TextBox13.Text & "-" & TextBox12.Text & "-" & TextBox11.Text
        Dim data3 As DateTime = Convert.ToDateTime(strdata3)

        Dim strdata4 As String = TextBox10.Text & "-" & TextBox9.Text & "-" & TextBox8.Text
        Dim data4 As DateTime = Convert.ToDateTime(strdata4)

        Dim Bln As Boolean
        If Label13.Text = "|Valor|" Then
            Bln = 1
        Else
            Bln = 0
        End If
        Dim s As Char
        If Label13.Text = "|Valor|" Then
            s = "€"
        Else
            s = "%"
        End If
        TextBox2.Text = ClsLinhasTotais.ComparaReceita(data1, data2, data3, data4, Bln) & s
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        If Label13.Text = "|Valor|" Then
            Label13.Text = "|Taxa de Crescimento|"
        Else
            Label13.Text = "|Valor|"
        End If
    End Sub
End Class
