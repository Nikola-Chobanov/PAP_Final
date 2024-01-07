Imports System.IO
Imports DevExpress.PivotGrid.CollapseState
''' <summary>
'''      Classe frmCategorias- Form da Tabela de Categorias
'''      Gerado em 30/03/2023 13:41:33
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2023
''' </remarks>Public Class UC_Categorias
Public Class UC_Categorias
    Dim mPath As String = Application.StartupPath + "\..\..\Resources\Images\Categorias\"


    Dim mLista As New List(Of ClsCategorias)

    Private Sub frmCategorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mLista = ClsCategorias.GetCategorias
        mNav = New clsNav(mLista.Count)

        UC_NAV1.mFRM = Me

        SetupComps(True)
        UC_NAV1.Load_Status()
        UC_NAV1.SetupNav()
        LoadRegistos()

        Me.Text = "Manutenção da Tabela de Categorias"

        '-------------------------------
        'Exemplo de ProgressBar
        '-------------------------------
        'upBar.Maximum = mNav.Max_Registos
        'upBar.Minimum = 1
        'upBar.Value = mNav.RegistoAtual
        '-------------------------------


        '-------------------------------
        'Exemplo de Combo...
        '-------------------------------

        '-----------------
        'ucPaises
        '-----------------
        'ucPaises.DataSource = clsPaises.GetPaises
        'ucPaises.DisplayMember = "Pais"
        'ucPaises.ValueMember = "Cod_Pais"

        '----------------------------------------------------------------------------------------------
        ' Como se faz um Filtro da Lista de Clientes?
        ' 
        ' A mLista que contém a lista de Categorias
        ' pode ser filtrada através do método
        ' FiltrarCategorias com o parâmetro da ClsCategorias
        ' 
        ' É preciso criar uma variável do tipo ClsCategorias
        ' e chamar o método FiltrarCategorias com esse parâmetro:
        '
        '   Dim mclsFiltro as New clsCategorias with {.Cod_Categoria=txtCod_Categoria.Text, .Designacao=txtDesignacao.Text}
        '   Dim mListaFiltro = clsCategorias.FiltrarCategorias(mclsFiltro)
        '----------------------------------------------------------------------------------------------

        '-----------------
        'ucPaises
        '-----------------
        'ucPaises.DataSource = clsPaises.GetPaises
        'ucPaises.DisplayMember = "Pais"
        'ucPaises.ValueMember = "Cod_Pais"

        RoundImage()
    End Sub


    Sub SetupComps(ByVal pBool As Boolean)
        Me.CodCategoriaTextEdit.ReadOnly = True
        If Not pBool Then
            If Me.UC_NAV1.mNovo Then
                Me.CodCategoriaTextEdit.Focus()
            Else
                Me.DesignacaoTextEdit.Focus()
            End If
        End If
        DesignacaoTextEdit.ReadOnly = pBool
        DesignacaoTextEdit.Enabled = Not pBool
        ImagemTextEdit.ReadOnly = pBool
        ImagemTextEdit.Enabled = Not pBool
        picCarregarImagem.Visible = Not pBool
        picApagarImagem.Visible = Not pBool

        '------------------------------
        'Exemplo da eventual UltraCmbo 
        '------------------------------
        'Me.PaisUltraCombo.ReadOnly = pBool

    End Sub

    Sub LoadRegistos()
        LimpaTXT()
        If mNav.Registo_Atual > 0 Then
            With mLista(mNav.Registo_Atual - 1)
                DesignacaoTextEdit.Text = .Designacao


Cont:
                If .Imagem = "" Then
                    picCategoria.Image = Image.FromFile(mPath + "Default.png")
                Else
                    Try
                        picCategoria.Image = Image.FromFile(mPath + .Imagem)
                    Catch ex As Exception
                        .Imagem = ""
                        GoTo Cont
                    End Try
                End If
                ImagemTextEdit.Text = .Imagem
                '-------------------------
                ' Cod_Categoria
                '-------------------------
                CodCategoriaTextEdit.Text = .Cod_Categoria
            End With
            '-------------------------------
            'upBar.Value = mNav.Registo_Atual
            '-------------------------------

        End If

    End Sub

    Sub LimpaTXT()
        If UC_NAV1.mNovo Then
            ImagemTextEdit.Text = ""
        Else
            ImagemTextEdit.Text = "Default.png"
        End If
        DesignacaoTextEdit.Text = ""
        '-------------------------------
        CodCategoriaTextEdit.Text = ""

        If UC_NAV1.mNovo Then
            CodCategoriaTextEdit.Text = ClsCategorias.GetNovoCodigo()
        End If
    End Sub


    Sub Grava(ByVal pbNovo As Boolean)

        '----------------------------------
        'Exemplo de UltraValidate
        '----------------------------------
        'UltraValidator1.Validate()
        '----------------------------------

        Dim mFLG_Gravou As Boolean = False
        Dim mCls As New ClsCategorias
        Dim mRegisto_Atual As Integer = mNav.Registo_Atual

        With mCls
            If pbNovo Then
                .Cod_Categoria = CodCategoriaTextEdit.Text

            Else
                .Cod_Categoria = CodCategoriaTextEdit.Text
            End If

            .Designacao = DesignacaoTextEdit.Text
            .Imagem = ImagemTextEdit.Text
        End With

        If pbNovo Then
            mFLG_Gravou = ClsCategorias.GravaCategorias(mCls)
        Else
            mFLG_Gravou = ClsCategorias.ModificaCategorias(mCls)
        End If


        If mFLG_Gravou Then
            If pbNovo Then
                Me.UC_NAV1.mNovo = False
                mLista = ClsCategorias.GetCategorias
                mNav = New clsNav(mLista.Count)
                mNav.Registo_Atual = mLista.FindIndex(Function(x) x.Cod_Categoria = mCls.Cod_Categoria) + 1
                LoadRegistos()

                '---------------------------
                'upBar.Maximum = mNav.Max_Registos
                'upBar.Value = mNav.Registo_Atual
            Else
                mLista = ClsCategorias.GetCategorias
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
            ClsCategorias.ApagaCategorias(mLista(mNav.Registo_Atual - 1).Cod_Categoria)
        Catch ex As Exception
            MsgBox("Erro a Apagar o Registo Atual" & vbCrLf & ex.Message)
            Exit Sub
        End Try

        mLista = ClsCategorias.GetCategorias
        mNav = New clsNav(mLista.Count)
        LoadRegistos()
    End Sub

    Private Sub picCarregarImagem_Click(sender As Object, e As EventArgs) Handles picCarregarImagem.Click
        ofdCategorias.Filter = " JPG |*.jpg| PNG | *.png| Todos os Ficheiros| *.*"
        If ofdCategorias.ShowDialog = DialogResult.OK Then

            Dim mCont As Integer = 0
            Dim mFileName As String = ofdCategorias.SafeFileName.ToString
            Dim mLen As Integer = Len(mFileName)
            Dim mExt As String = mFileName.Substring(mLen - 4, 4)

            Dim mFileDestino As String = mPath + CodCategoriaTextEdit.Text + mExt
            Me.picCategoria.Text = CodCategoriaTextEdit.Text + mExt
            Me.ImagemTextEdit.Text = CodCategoriaTextEdit.Text + mExt

Cont:
            Try
                File.Copy(ofdCategorias.FileName, mFileDestino, True)
            Catch ex As Exception
                If File.Exists(mFileDestino) Then
                    mCont += 1
                    mFileDestino = mPath + CodCategoriaTextEdit.Text + mCont.ToString("00") + mExt
                    Me.ImagemTextEdit.Text = CodCategoriaTextEdit.Text + mCont.ToString("00") + mExt
                    GoTo Cont
                End If

            End Try

            Me.picCategoria.Image = Image.FromFile(mFileDestino)

            If mCont > 0 Then
                Me.picCategoria.Image.Tag = CodCategoriaTextEdit.Text + mCont.ToString("00") + mExt
            Else
                Me.picCategoria.Image.Tag = CodCategoriaTextEdit.Text + mExt
            End If

        End If
    End Sub

    Private Sub picApagarImagem_Click(sender As Object, e As EventArgs) Handles picApagarImagem.Click
        If ImagemTextEdit.Text <> "" Then
            If MsgBox("Quer apagar a imagem?", vbYesNo, "Imagem Entidade") = vbNo Then
                Exit Sub
            ElseIf vbYes Then
                picCategoria.Image = Nothing
                ImagemTextEdit.Text = "Default.png"
            End If
        End If
    End Sub

    Sub RoundImage()
        Dim path As New System.Drawing.Drawing2D.GraphicsPath()
        Dim mCornerRadius As Integer = 50
        Dim mRectangle As Rectangle = New Rectangle(0, 0, picCategoria.Width, picCategoria.Height)
        Dim mArcRectangle As Rectangle = New Rectangle(mRectangle.Left, mRectangle.Top, mCornerRadius, mCornerRadius)
        path.AddArc(mArcRectangle, 180, 90)

        mArcRectangle.X = mRectangle.Right - mCornerRadius
        path.AddArc(mArcRectangle, 270, 90)
        mArcRectangle.Y = mRectangle.Bottom - mCornerRadius
        path.AddArc(mArcRectangle, 0, 90)
        mArcRectangle.X = mRectangle.Left
        path.AddArc(mArcRectangle, 90, 90)
        path.CloseFigure()

        picCategoria.Region = New Region(path)
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
