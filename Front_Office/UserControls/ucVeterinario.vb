Imports System.Drawing.Drawing2D
Imports DevExpress.XtraRichEdit.Internal.PrintLayout

Public Class ucVeterinario
    Public Shared Property Cod_Veterinario As String

    Private mVeterinario As New ClsVeterinarios
    Dim mListaVeterinarios As New List(Of ClsVeterinarios)
    Dim mPathVeterinario As String = Application.StartupPath + "\..\..\Resources\Images\Veterinarios\"

    Private Sub ucVeterinario_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Cod_Veterinario = Nothing Then
            Exit Sub
        End If

        RoundImage()
        LoadVeterinario()
    End Sub

    Private Sub LoadVeterinario()

        Dim mCaminho = ""
        picFotografia.SizeMode = PictureBoxSizeMode.StretchImage

        mVeterinario = ClsVeterinarios.GetVeterinariosByCod(Cod_Veterinario)

        mCaminho = mPathVeterinario + mVeterinario.Fotografia

        Try
            picFotografia.Image = Image.FromFile(mCaminho)
        Catch ex As Exception
            picFotografia.Image = Image.FromFile(mPathVeterinario + "Default.png")
        End Try

        With mVeterinario
            lblNome.Text = .Nome
            lblEmail.Text = "Email: " & .Email
            lblTelefone.Text = "Telefone: " & .Num_Telefone
            lblTelemovel.Text = "Telemóvel: " & .Num_Telemovel
        End With

    End Sub

    Sub RoundImage()
        Dim path As New System.Drawing.Drawing2D.GraphicsPath()
        Dim mCornerRadius As Integer = 50
        Dim mRectangle As Rectangle = New Rectangle(0, 0, picFotografia.Width, picFotografia.Height)
        Dim mArcRectangle As Rectangle = New Rectangle(mRectangle.Left, mRectangle.Top, mCornerRadius, mCornerRadius)
        path.AddArc(mArcRectangle, 180, 90)

        mArcRectangle.X = mRectangle.Right - mCornerRadius
        path.AddArc(mArcRectangle, 270, 90)
        mArcRectangle.Y = mRectangle.Bottom - mCornerRadius
        path.AddArc(mArcRectangle, 0, 90)
        mArcRectangle.X = mRectangle.Left
        path.AddArc(mArcRectangle, 90, 90)
        path.CloseFigure()

        picFotografia.Region = New Region(path)
    End Sub

End Class
