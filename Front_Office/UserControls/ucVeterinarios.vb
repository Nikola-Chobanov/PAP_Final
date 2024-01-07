Public Class ucVeterinarios

    Public Shared mListaVeterinarios As New List(Of ClsVeterinarios)

    Private Sub ucVeterinarios_Load(sender As Object, e As EventArgs) Handles Me.Load
        mListaVeterinarios = ClsVeterinarios.GetVeterinarios
        LoadPanel()
    End Sub

    Private Sub LoadPanel()

        If mListaVeterinarios.Count = 0 Then
            FlowLayoutPanel.BackgroundImage = My.Resources._Default
        Else
            For i As Integer = 0 To mListaVeterinarios.Count - 1

                Dim ucVeterinario As New ucVeterinario

                ucVeterinario.Cod_Veterinario = mListaVeterinarios(i).Cod_Veterinario

                Me.FlowLayoutPanel.Controls.Add(ucVeterinario)

            Next
        End If

    End Sub


End Class
