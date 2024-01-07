Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Drawing.Text
Imports System.IO
Imports DevExpress.Xpo.DB.Helpers

Public Class ucVeterinarios
    Dim mLista As New List(Of ClsVeterinarios)
    Dim mPath As String = Application.StartupPath + "\..\..\Resources\Images\Veterinarios\"

    Private Sub UC_Veterinarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mLista = ClsVeterinarios.GetVeterinarios
        mNav = New clsNav(mLista.Count)
        UC_NAV1.mFRM = Me

        SetupComps(True)
        UC_NAV1.Load_Status()
        UC_NAV1.SetupNav()
        LoadRegistos()

        Me.Text = "Manutenção da Tabela de Entidades"
        RoundImage()
    End Sub

    Sub SetupComps(ByVal pBool As Boolean)
        Me.CodVeterinarioTextEdit.ReadOnly = True
        FotografiaTextEdit.ReadOnly = True
        If Not pBool Then
            If Me.UC_NAV1.mNovo Then
                CodVeterinarioTextEdit.Focus()
            Else
            End If
        End If
        NomeTextEdit.ReadOnly = pBool
        NomeTextEdit.Enabled = Not pBool
        NumTelefoneTextEdit.ReadOnly = pBool
        NumTelefoneTextEdit.Enabled = Not pBool
        NumTelemovelTextEdit.ReadOnly = pBool
        NumTelemovelTextEdit.Enabled = Not pBool
        EmailTextEdit.ReadOnly = pBool
        EmailTextEdit.Enabled = Not pBool

        picCarregarImagem.Visible = Not pBool
        picApagarImagem.Visible = Not pBool
    End Sub

    Sub LoadRegistos()
        LimpaTXT()
        If mNav.Registo_Atual > 0 Then
            With mLista(mNav.Registo_Atual - 1)

                NomeTextEdit.Text = .Nome
                NumTelefoneTextEdit.Text = .Num_Telefone
                NumTelemovelTextEdit.Text = .Num_Telemovel
                EmailTextEdit.Text = .Email
                CodVeterinarioTextEdit.Text = .Cod_Veterinario
                '-------------------------------------------------------------------

Cont:
                If .Fotografia = "" Then
                    picVeterinario.Image = Image.FromFile(mPath + "Default.png")
                Else
                    Try
                        picVeterinario.Image = Image.FromFile(mPath + .Fotografia)
                    Catch ex As Exception
                        .Fotografia = ""
                        GoTo Cont
                    End Try
                End If
                FotografiaTextEdit.Text = .Fotografia
            End With
        End If
    End Sub

    Sub LimpaTXT()
        NomeTextEdit.Text = ""
        NumTelefoneTextEdit.Text = ""
        NumTelemovelTextEdit.Text = ""
        EmailTextEdit.Text = ""
        CodVeterinarioTextEdit.Text = ""
        If UC_NAV1.mNovo Then
            CodVeterinarioTextEdit.Text = ClsVeterinarios.GetNovoCodigo
        End If
    End Sub

    Sub Grava(ByVal pbNovo As Boolean)

        '----------------------------------
        'Exemplo de UltraValidate
        '----------------------------------
        'UltraValidator1.Validate()
        '----------------------------------

        Dim mFLG_Gravou As Boolean = False
        Dim mCls As New ClsVeterinarios
        Dim mRegisto_Atual As Integer = mNav.Registo_Atual
        Dim mNovaEntidade As String = ClsVeterinarios.GetNovoCodigo()

        With mCls
            If pbNovo Then
                .Cod_Veterinario = mNovaEntidade
                If FotografiaTextEdit.Text = "" Then
                    FotografiaTextEdit.Text = "Default.png"
                End If
            Else
                .Cod_Veterinario = CodVeterinarioTextEdit.Text
            End If
            .Nome = NomeTextEdit.Text
            .Num_Telefone = NumTelefoneTextEdit.Text
            .Num_Telemovel = NumTelemovelTextEdit.Text
            .Email = EmailTextEdit.Text
            .Fotografia = FotografiaTextEdit.Text
        End With

        If pbNovo Then
            mFLG_Gravou = ClsVeterinarios.GravaVeterinarios(mCls)
            ClsEmpresas.GravaContador(enCont.Veterinarios)
        Else
            mFLG_Gravou = ClsVeterinarios.ModificaVeterinarios(mCls)
        End If


        If mFLG_Gravou Then
            If pbNovo Then
                Me.UC_NAV1.mNovo = False
                mLista = ClsVeterinarios.GetVeterinarios
                mNav = New clsNav(mLista.Count)
                mNav.Registo_Atual = mLista.FindIndex(Function(x) x.Cod_Veterinario = mCls.Cod_Veterinario) + 1
                LoadRegistos()
            Else
                mLista = ClsVeterinarios.GetVeterinarios
                mNav = New clsNav(mLista.Count)
                mNav.Registo_Atual = mRegisto_Atual
                LoadRegistos()
            End If
        Else
            MsgBox("Erro na gravação:")
        End If
        mNovaEntidade = Nothing
    End Sub

    Sub Apaga_Registo()
        Try
            ClsVeterinarios.ApagaVeterinarios(mLista(mNav.Registo_Atual - 1).Cod_Veterinario)
        Catch ex As Exception
            MsgBox("Erro a Apagar o Registo Atual" & vbCrLf & ex.Message)
            Exit Sub
        End Try

        mLista = ClsVeterinarios.GetVeterinarios
        mNav = New clsNav(mLista.Count)
        LoadRegistos()
    End Sub

    Private Sub picCarregarImagem_Click(sender As Object, e As EventArgs) Handles picCarregarImagem.Click
        ofdVeterinario.Filter = " JPG |*.jpg| PNG | *.png| Todos os Ficheiros| *.*"
        If ofdVeterinario.ShowDialog = DialogResult.OK Then

            Dim mCont As Integer = 0
            Dim mFileName As String = ofdVeterinario.SafeFileName.ToString
            Dim mLen As Integer = Len(mFileName)
            Dim mExt As String = mFileName.Substring(mLen - 4, 4)

            Dim mFileDestino As String = mPath + CodVeterinarioTextEdit.Text + mExt
            Me.picVeterinario.Text = CodVeterinarioTextEdit.Text + mExt
            Me.FotografiaTextEdit.Text = CodVeterinarioTextEdit.Text + mExt

Cont:
            Try
                File.Copy(ofdVeterinario.FileName, mFileDestino, True)
            Catch ex As Exception
                If File.Exists(mFileDestino) Then
                    mCont += 1
                    mFileDestino = mPath + CodVeterinarioTextEdit.Text + mCont.ToString("000") + mExt
                    Me.CodVeterinarioTextEdit.Text = CodVeterinarioTextEdit.Text + mCont.ToString("000") + mExt
                    GoTo Cont
                End If

            End Try

            Me.picVeterinario.Image = Image.FromFile(mFileDestino)

            If mCont > 0 Then
                Me.picVeterinario.Image.Tag = CodVeterinarioTextEdit.Text + mCont.ToString("000") + mExt
            Else
                Me.picVeterinario.Image.Tag = CodVeterinarioTextEdit.Text + mExt
            End If

        End If
    End Sub

    Private Sub picApagarImagem_Click(sender As Object, e As EventArgs) Handles picApagarImagem.Click
        If FotografiaTextEdit.Text <> "" Then
            If MsgBox("Quer apagar a imagem?", vbYesNo, "Imagem Entidade") = vbNo Then
                Exit Sub
            ElseIf vbYes Then
                picVeterinario.Image = Image.FromFile(mPath + "Default.png")
                FotografiaTextEdit.Text = "Default.png"
            End If
        End If
    End Sub

    Sub RoundImage()
        Dim path As New System.Drawing.Drawing2D.GraphicsPath()
        Dim mCornerRadius As Integer = 50
        Dim mRectangle As Rectangle = New Rectangle(0, 0, picVeterinario.Width, picVeterinario.Height)
        Dim mArcRectangle As Rectangle = New Rectangle(mRectangle.Left, mRectangle.Top, mCornerRadius, mCornerRadius)
        path.AddArc(mArcRectangle, 180, 90)

        mArcRectangle.X = mRectangle.Right - mCornerRadius
        path.AddArc(mArcRectangle, 270, 90)
        mArcRectangle.Y = mRectangle.Bottom - mCornerRadius
        path.AddArc(mArcRectangle, 0, 90)
        mArcRectangle.X = mRectangle.Left
        path.AddArc(mArcRectangle, 90, 90)
        path.CloseFigure()

        picVeterinario.Region = New Region(path)
    End Sub

    Private Sub picCarregarImagem_MouseMove(sender As Object, e As MouseEventArgs) Handles picCarregarImagem.MouseMove
        picCarregarImagem.Image = My.Resources.CarregarImagemShade2
    End Sub

    Private Sub picCarregarImagem_MouseLeave(sender As Object, e As EventArgs) Handles picCarregarImagem.MouseLeave
        picCarregarImagem.Image = My.Resources.CarregarImagem
    End Sub

    Private Sub picApagarImagem_MouseHover(sender As Object, e As MouseEventArgs) Handles picApagarImagem.MouseMove
        picApagarImagem.Image = My.Resources.ApagarImagemShade2
    End Sub

    Private Sub picApagarImagem_MouseLeave(sender As Object, e As EventArgs) Handles picApagarImagem.MouseLeave
        picApagarImagem.Image = My.Resources.ApagarImagem
    End Sub

End Class
