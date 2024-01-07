Imports System.Drawing.Drawing2D
Imports System.IO
''' <summary>
'''      Classe frmAnimais- Form da Tabela de Animais
'''      Gerado em 29/11/2022 14:12:53
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2022
''' </remarks>
Public Class UC_Animais
    Dim mListaEntidade As New List(Of ClsEntidades)
    Dim mLista As New List(Of ClsAnimais)
    Dim mPath As String = Application.StartupPath + "\..\..\Resources\Images\Animais\"

    Private Sub frmAnimais_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mLista = ClsAnimais.GetAnimais
        mNav = New clsNav(mLista.Count)
        mListaEntidade = ClsEntidades.GetEntidadesByFLG("C")
        UC_NAV11.mFRM = Me

        SetupComps(True)
        UC_NAV11.Load_Status()
        UC_NAV11.SetupNav()
        LoadRegistos()

        Me.Text = "Manutenção da Tabela de Animais"

        ucCodEntidade.DataSource = mListaEntidade
        ucCodEntidade.DisplayMember = "Nome"
        ucCodEntidade.ValueMember = "Cod_Entidade"

        Setup_ucTA()
        Round_Image()
    End Sub

    Sub Round_Image()
        Dim path As New System.Drawing.Drawing2D.GraphicsPath()
        Dim mCornerRadius As Integer = 50
        Dim mRectangle As Rectangle = New Rectangle(0, 0, picAnimal.Width, picAnimal.Height)
        Dim mArcRectangle As Rectangle = New Rectangle(mRectangle.Left, mRectangle.Top, mCornerRadius, mCornerRadius)
        path.AddArc(mArcRectangle, 180, 90)

        mArcRectangle.X = mRectangle.Right - mCornerRadius
        path.AddArc(mArcRectangle, 270, 90)
        mArcRectangle.Y = mRectangle.Bottom - mCornerRadius
        path.AddArc(mArcRectangle, 0, 90)
        mArcRectangle.X = mRectangle.Left
        path.AddArc(mArcRectangle, 90, 90)
        path.CloseFigure()

        picAnimal.Region = New Region(path)
    End Sub

    Sub Setup_ucTA()
        ucCodTA.DataSource = ClsTiposAnimais.GetTipos_Animais
        ucCodTA.DisplayMember = "Animal"
        ucCodTA.ValueMember = "Cod_Tipo_Animal"
        'UC_CodTA.MDatasource = ClsTipo_Animais.GetTipo_Animais
        'UC_CodTA.ColocaDados()

        ucCodTA.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        ucCodTA.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.Horizontal
        With ucCodTA.DisplayLayout.Bands(0)
            .Columns("Cod_Tipo_Animal").Hidden = True
            .Columns("FLG_Ativo").Hidden = True
            With .Columns("Animal")
                .Hidden = False
                .CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            End With

        End With

    End Sub


    Sub SetupComps(ByVal pBool As Boolean)
        Me.Cod_AnimalTextEdit.ReadOnly = True
        If Not pBool Then
            If Me.UC_NAV11.mNovo Then
                Me.Cod_AnimalTextEdit.Focus()
                Me.Imagem_AnimalTextEdit.Text = "Default.png"
            Else
                Me.Nome_AnimalTextEdit.Focus()
            End If
        End If
        Nome_AnimalTextEdit.ReadOnly = pBool
        Cod_EntidadeTextEdit.ReadOnly = True
        Cod_Tipo_AnimalTextEdit.ReadOnly = True
        Imagem_AnimalTextEdit.ReadOnly = True
        Nome_AnimalTextEdit.Enabled = Not pBool
        Cod_EntidadeTextEdit.Enabled = Not pBool
        Cod_Tipo_AnimalTextEdit.Enabled = Not pBool
        picCarregarImagem.Visible = Not pBool
        picApagarImagem.Visible = Not pBool
        ucCodEntidade.Visible = Not pBool
        ucCodTA.Visible = Not pBool




    End Sub

    Sub LoadRegistos()
        LimpaTXT()
        If mNav.Registo_Atual > 0 Then
            With mLista(mNav.Registo_Atual - 1)
                Nome_AnimalTextEdit.Text = .Nome_Animal
                Cod_EntidadeTextEdit.Text = .Cod_Entidade
                Cod_Tipo_AnimalTextEdit.Text = .Cod_Tipo_Animal
                Cod_AnimalTextEdit.Text = .Cod_Animal
Cont:
                If .Imagem_Animal = "" Then
                    picAnimal.Image = Image.FromFile(mPath + "Default.png")
                Else
                    Try
                        picAnimal.Image = Image.FromFile(mPath + .Imagem_Animal)
                    Catch ex As Exception
                        .Imagem_Animal = ""
                        GoTo Cont
                    End Try
                End If

                Imagem_AnimalTextEdit.Text = .Imagem_Animal
            End With


        End If

    End Sub

    Sub LimpaTXT()

        Nome_AnimalTextEdit.Text = ""
        Cod_EntidadeTextEdit.Text = ""
        Cod_Tipo_AnimalTextEdit.Text = ""
        If UC_NAV11.mNovo Then
            Imagem_AnimalTextEdit.Text = ""
        Else
            Imagem_AnimalTextEdit.Text = "Default.png"
        End If
        Cod_AnimalTextEdit.Text = ""
    End Sub


    Sub Grava(ByVal pbNovo As Boolean)

        '----------------------------------
        'Exemplo de UltraValidate
        '----------------------------------
        'UltraValidator1.Validate()
        '----------------------------------

        Dim mFLG_Gravou As Boolean = False
        Dim mCls As New ClsAnimais
        Dim mRegisto_Atual As Integer = mNav.Registo_Atual

        With mCls
            If pbNovo Then

                .Cod_Animal = ClsAnimais.GetNovoCodigo()

            Else
                .Cod_Animal = Cod_AnimalTextEdit.Text
            End If
            .Nome_Animal = Nome_AnimalTextEdit.Text
            .Cod_Entidade = Cod_EntidadeTextEdit.Text
            .Cod_Tipo_Animal = Cod_Tipo_AnimalTextEdit.Text
            .Imagem_Animal = Imagem_AnimalTextEdit.Text
        End With

        If pbNovo Then
            mFLG_Gravou = ClsAnimais.GravaAnimais(mCls)
            ClsEmpresas.GravaContador(enCont.Animais)
        Else
            mFLG_Gravou = ClsAnimais.ModificaAnimais(mCls)
        End If


        If mFLG_Gravou Then
            If pbNovo Then
                Me.UC_NAV11.mNovo = False
                mLista = ClsAnimais.GetAnimais
                mNav = New clsNav(mLista.Count)
                mNav.Registo_Atual = mLista.FindIndex(Function(x) x.Cod_Animal = mCls.Cod_Animal) + 1
                LoadRegistos()

                '---------------------------
                'upBar.Maximum = mNav.Max_Registos
                'upBar.Value = mNav.Registo_Atual
            Else
                mLista = ClsAnimais.GetAnimais
                mNav = New clsNav(mLista.Count)
                mNav.Registo_Atual = mRegisto_Atual
                LoadRegistos()
            End If
        Else
            MsgBox("Erro na gravação:")
        End If
    End Sub


    Sub Apaga_Registo()
        Try
            ClsAnimais.ApagaAnimais(mLista(mNav.Registo_Atual - 1).Cod_Animal)
        Catch ex As Exception
            MsgBox("Erro a Apagar o Registo Atual" & vbCrLf & ex.Message)
            Exit Sub
        End Try

        mLista = ClsAnimais.GetAnimais
        mNav = New clsNav(mLista.Count)
        LoadRegistos()
    End Sub

    Private Sub picCarregarImagem_Click(sender As Object, e As EventArgs) Handles picCarregarImagem.Click
        ofdImagem.Filter = " JPG |*.jpg| PNG | *.png| Todos os Ficheiros| *.*"
        If ofdImagem.ShowDialog = DialogResult.OK Then

            Dim mCont As Integer = 0
            Dim mFileName As String = ofdImagem.SafeFileName.ToString
            Dim mLen As Integer = Len(mFileName)
            Dim mExt As String = mFileName.Substring(mLen - 4, 4)

            If Me.UC_NAV11.mNovo Then
                Me.Cod_AnimalTextEdit.Text = ClsAnimais.GetNovoCodigo
            End If

            Dim mFileDestino As String = mPath + Cod_AnimalTextEdit.Text + mExt
            Me.Imagem_AnimalTextEdit.Text = Cod_AnimalTextEdit.Text + mExt

Cont:
            Try
                File.Copy(ofdImagem.FileName, mFileDestino, True)
            Catch ex As Exception
                If File.Exists(mFileDestino) Then
                    mCont += 1
                    mFileDestino = mPath + Cod_AnimalTextEdit.Text + mCont.ToString("000") + mExt
                    Me.Imagem_AnimalTextEdit.Text = Cod_AnimalTextEdit.Text + mCont.ToString("000") + mExt
                    GoTo Cont
                End If

            End Try

            Me.picAnimal.Image = Image.FromFile(mFileDestino)

            If mCont > 0 Then
                Me.picAnimal.Image.Tag = Cod_AnimalTextEdit.Text + mCont.ToString("000") + mExt
            Else
                Me.picAnimal.Image.Tag = Cod_AnimalTextEdit.Text + mExt
            End If

        End If
    End Sub

    Private Sub ucCod_Entidade_AfterCloseUp(sender As Object, e As EventArgs) Handles ucCodEntidade.AfterCloseUp
        If ucCodEntidade.ActiveRow Is Nothing Then
            If Cod_EntidadeTextEdit.Text <> "" Then
                Exit Sub
            End If
            Cod_EntidadeTextEdit.Text = "C0001"
            Exit Sub
        End If
        Try
            Me.Cod_EntidadeTextEdit.Text = ucCodEntidade.ActiveRow.Cells("Cod_Entidade").Text
        Catch ex As Exception
            MsgBox("Selecione uma Entidade" + vbCrLf + ex.Message)
        End Try
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

    Private Sub ucCodTA_AfterCloseUp(sender As Object, e As EventArgs) Handles ucCodTA.AfterCloseUp
        If ucCodTA.ActiveRow Is Nothing Then
            If Cod_Tipo_AnimalTextEdit.Text <> "" Then
                Exit Sub
            End If
            ucCodTA.Text = "R"
            Exit Sub
        End If
        Cod_Tipo_AnimalTextEdit.Text = ucCodTA.ActiveRow.Cells("Cod_Tipo_Animal").Text
        Try

        Catch ex As Exception
            MsgBox("Por favor selecione um animal" + vbCrLf + ex.Message)
        End Try
        If Me.UC_NAV11.mNovo Then
            Cod_AnimalTextEdit.Text = ClsAnimais.GetNovoCodigo
        Else
            Cod_AnimalTextEdit.Text = Cod_AnimalTextEdit.Text
        End If
    End Sub


    Private Sub picApagarImagem_Click(sender As Object, e As EventArgs) Handles picApagarImagem.Click
        If Imagem_AnimalTextEdit.Text <> "" Then


            If MsgBox("Quer apagar a imagem?", MsgBoxStyle.YesNo, "Imagem Animal") = vbNo Then
                Exit Sub
            ElseIf vbYes Then
                picAnimal.Image = Nothing
                Imagem_AnimalTextEdit.Text = "Default.png"
            End If
        End If
    End Sub

End Class

