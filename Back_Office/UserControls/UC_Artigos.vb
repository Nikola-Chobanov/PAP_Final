Imports System.ComponentModel
Imports System.Drawing.Text
Imports System.IO
Imports DevExpress.DataAccess.UI.Localization
Imports DevExpress.XtraRichEdit.Model
Imports Infragistics.Win.UltraWinGrid

Public Class UC_Artigos
    Dim mListaCategorias As New List(Of ClsCategorias)
    Dim mLista As New List(Of ClsArtigos)
    Dim mPath As String = Application.StartupPath + "\..\..\Resources\Images\Artigos\"


    Private Sub UC_Artigos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mLista = ClsArtigos.Get_Artigos

        mNav = New clsNav(mLista.Count)
        UC_NAV1.mFRM = Me

        SetupComps(True)
        UC_NAV1.Load_Status()
        UC_NAV1.SetupNav()
        LoadRegistos()
        '--------------------------------------
        cmbProdutoServico.Items.Add("Produto")
        cmbProdutoServico.Items.Add("Serviço")

        cmbTipoIVA.Items.Add("0/Isento")
        cmbTipoIVA.Items.Add("Reduzido")
        cmbTipoIVA.Items.Add("Intermédio")
        cmbTipoIVA.Items.Add("Normal")
        '--------------------------------------

        Preco_VendaSpinEdit.Properties.MinValue = 0
        LoadCategorias()
    End Sub

    Sub LoadCategorias()
        mListaCategorias = ClsCategorias.GetCategorias
        ucCategorias.DataSource = mListaCategorias
    End Sub


    Sub SetupComps(ByVal pBool As Boolean)
        Me.CodArtigoTextEdit.ReadOnly = True

        If Not pBool Then
            If Me.UC_NAV1.mNovo Then
            Else
                Me.FLGProdutoServicoTextEdit.Focus()
            End If
        End If
        Data_Ultima_VendaDateEdit.Enabled = Not pBool
        cmbTipoIVA.Visible = Not pBool
        cmbProdutoServico.Visible = Not pBool
        Data_RegistoDateEdit.Enabled = Not pBool


        FLGProdutoServicoTextEdit.ReadOnly = pBool
        DesignacaoTextEdit.ReadOnly = pBool
        DesignacaoTextEdit.Enabled = Not pBool
        TipoIVATextEdit.ReadOnly = pBool
        TipoIVATextEdit.Enabled = Not pBool
        Preco_VendaSpinEdit.ReadOnly = pBool
        Preco_VendaSpinEdit.Enabled = Not pBool
        ucCategorias.Enabled = Not pBool
        ucCategorias.Visible = Not pBool
        CodCategoria.ReadOnly = pBool
        picCarregarImagem.Visible = Not pBool
        picApagarImagem.Visible = Not pBool
    End Sub
    Sub LimpaTxt()
        CodArtigoTextEdit.Text = ""
        FLGProdutoServicoTextEdit.Text = ""
        DesignacaoTextEdit.Text = ""
        TipoIVATextEdit.Text = ""
        Preco_VendaSpinEdit.Text = ""
        Data_Ultima_VendaDateEdit.Text = ""
        Data_RegistoDateEdit.Text = ""
        ImagemTextEdit.Text = ""
        cmbProdutoServico.Text = ""
        cmbTipoIVA.Text = ""
        CodCategoria.Text = ""
        'If UC_NAV1.mNovo Then
        '    CodArtigoTextEdit.Text = ClsArtigos.GetNovoCodigo
        '    CodArtigoTextEdit.Refresh()
        'End If
    End Sub
    Sub LoadRegistos()
        LimpaTxt()
        If mNav.Registo_Atual > 0 Then
            With mLista(mNav.Registo_Atual - 1)
                CodArtigoTextEdit.Text = .Cod_Artigo
                FLGProdutoServicoTextEdit.Text = .FLG_Produto_Servico
                DesignacaoTextEdit.Text = .Designacao
                TipoIVATextEdit.Text = .Tipo_IVA
                Preco_VendaSpinEdit.Text = .Preco_Venda
                Data_Ultima_VendaDateEdit.Text = .Data_Ultima_Venda
                Data_RegistoDateEdit.Text = .Data_Registo
                CodCategoria.Text = .Cod_Categoria
Cont:
                If .Imagem = "" Then
                    picArtigo.Image = Image.FromFile(mPath + "Default.png")
                    ' ImagemTextEdit.Text = "Default.png"
                Else
                    Try
                        picArtigo.Image = Image.FromFile(mPath + .Imagem)
                    Catch ex As Exception
                        .Imagem = "Default.png"
                        GoTo Cont
                    End Try
                End If

                ImagemTextEdit.Text = .Imagem


            End With
        End If
    End Sub

    Sub Grava(ByVal pbNovo As Boolean)
        Dim mFLG_Gravou As Boolean = False
        Dim mCls As New ClsArtigos
        Dim mRegisto_Atual As Integer = mNav.Registo_Atual

        With mCls
            If pbNovo Then

                .Cod_Artigo = CodArtigoTextEdit.Text
                .Data_Registo = Date.Now.ToString("yyyy-MM-dd") 'HH:mm:ss.fff")
                .Data_Ultima_Venda = Data_Ultima_VendaDateEdit.Text
                Data_RegistoDateEdit.Refresh()
            Else
                .Cod_Artigo = CodArtigoTextEdit.Text
                .Data_Registo = Data_RegistoDateEdit.Text
                .Data_Ultima_Venda = Data_Ultima_VendaDateEdit.Text
            End If
            .Cod_Categoria = CodCategoria.Text
            .FLG_Produto_Servico = FLGProdutoServicoTextEdit.Text
            .Designacao = DesignacaoTextEdit.Text
            .Tipo_IVA = TipoIVATextEdit.Text
            .Imagem = ImagemTextEdit.Text
            If Preco_VendaSpinEdit.Value < 0 Then
                .Preco_Venda = 0
                Preco_VendaSpinEdit.Text = 0
            Else
                .Preco_Venda = Preco_VendaSpinEdit.Text
            End If



        End With

        If pbNovo Then
            mFLG_Gravou = ClsArtigos.GravaArtigos(mCls)
            'ClsEmpresas.GravaContador(enCont.Artigos)
        Else
            mFLG_Gravou = ClsArtigos.ModificaArtigos(mCls)
        End If


        If mFLG_Gravou Then
            If pbNovo Then
                Me.UC_NAV1.mNovo = False
                mLista = ClsArtigos.Get_Artigos
                mNav = New clsNav(mLista.Count)
                mNav.Registo_Atual = mLista.FindIndex(Function(x) x.Cod_Artigo = mCls.Cod_Artigo) + 1
                LoadRegistos()

                '---------------------------
                'upBar.Maximum = mNav.Max_Registos
                'upBar.Value = mNav.Registo_Atual
            Else
                mLista = ClsArtigos.Get_Artigos
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
            ClsArtigos.ApagaArtigos(mLista(mNav.Registo_Atual - 1).Cod_Artigo)
        Catch ex As Exception
            MsgBox("Erro a Apagar o Registo Atual" & vbCrLf & ex.Message)
            Exit Sub
        End Try

        mLista = ClsArtigos.Get_Artigos
        mNav = New clsNav(mLista.Count)
        LoadRegistos()
    End Sub

    Private Sub cmbProdutoServico_Leave(sender As Object, e As EventArgs) Handles cmbProdutoServico.Leave
        If cmbProdutoServico.Text = "" Then
            If FLGProdutoServicoTextEdit.Text <> "" Then
                Exit Sub
            End If
            FLGProdutoServicoTextEdit.Text = "S"
            Exit Sub
        End If
        Try
            FLGProdutoServicoTextEdit.Text = cmbProdutoServico.Text.Substring(0, 1)
            If FLGProdutoServicoTextEdit.Text = "P" Then
                CodArtigoTextEdit.Text = ClsArtigos.GetNovoCodigo(enCont.Produtos)
            Else
                CodArtigoTextEdit.Text = ClsArtigos.GetNovoCodigo(enCont.Servicos)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmbTipoIVA_TextChanged(sender As Object, e As EventArgs) Handles cmbTipoIVA.Leave
        If cmbTipoIVA.Text = "" Then
            If TipoIVATextEdit.Text <> "" Then
                Exit Sub
            End If
            TipoIVATextEdit.Text = "N"
            Exit Sub
        End If
        Try
            TipoIVATextEdit.Text = cmbTipoIVA.Text.Substring(0, 1)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub picCarregarImagem_Click(sender As Object, e As EventArgs) Handles picCarregarImagem.Click
        ofdArtigo.Filter = " PNG |*.png| JPG | *.jpg| Todos os Ficheiros| *.*"
        If ofdArtigo.ShowDialog = DialogResult.OK Then

            Dim mCont As Integer = 0
            Dim mFileName As String = ofdArtigo.SafeFileName.ToString
            Dim mLen As Integer = Len(mFileName)
            Dim mExt As String = mFileName.Substring(mLen - 4, 4)

            Dim mFileDestino As String = mPath + CodArtigoTextEdit.Text + mExt
            Me.picArtigo.Text = CodArtigoTextEdit.Text + mExt
            Me.ImagemTextEdit.Text = CodArtigoTextEdit.Text + mExt

Cont:
            Try
                File.Copy(ofdArtigo.FileName, mFileDestino, True)
            Catch ex As Exception
                If File.Exists(mFileDestino) Then
                    mCont += 1
                    mFileDestino = mPath + CodArtigoTextEdit.Text + mCont.ToString("000") + mExt
                    Me.CodArtigoTextEdit.Text = CodArtigoTextEdit.Text + mCont.ToString("000") + mExt
                    GoTo Cont
                End If

            End Try

            Me.picArtigo.Image = Image.FromFile(mFileDestino)

            If mCont > 0 Then
                Me.picArtigo.Image.Tag = CodArtigoTextEdit.Text + mCont.ToString("000") + mExt
            Else
                Me.picArtigo.Image.Tag = CodArtigoTextEdit.Text + mExt
            End If

        End If
    End Sub


    Private Sub picApagarImagem_Click(sender As Object, e As EventArgs) Handles picApagarImagem.Click
        If ImagemTextEdit.Text <> "" Then
            If MsgBox("Quer apagar a imagem?", vbYesNo, "Imagem Entidade") = vbNo Then
                Exit Sub
            ElseIf vbYes Then
                picArtigo.Image = Nothing
                ImagemTextEdit.Text = "Default.png"
            End If
        End If
    End Sub

    Private Sub ucCategorias_AfterCloseUp(sender As Object, e As EventArgs) Handles ucCategorias.AfterCloseUp
        If ucCategorias.ActiveRow Is Nothing Then
            If CodCategoria.Text <> "" Then
                Exit Sub
            End If
            CodCategoria.Text = "CAT02"
            Exit Sub
        End If
        CodCategoria.Text = ucCategorias.ActiveRow.Cells("Cod_Categoria").Text
    End Sub

    Sub RoundImage()
        Dim path As New System.Drawing.Drawing2D.GraphicsPath()
        Dim mCornerRadius As Integer = 50
        Dim mRectangle As Rectangle = New Rectangle(0, 0, picArtigo.Width, picArtigo.Height)
        Dim mArcRectangle As Rectangle = New Rectangle(mRectangle.Left, mRectangle.Top, mCornerRadius, mCornerRadius)
        path.AddArc(mArcRectangle, 180, 90)

        mArcRectangle.X = mRectangle.Right - mCornerRadius
        path.AddArc(mArcRectangle, 270, 90)
        mArcRectangle.Y = mRectangle.Bottom - mCornerRadius
        path.AddArc(mArcRectangle, 0, 90)
        mArcRectangle.X = mRectangle.Left
        path.AddArc(mArcRectangle, 90, 90)
        path.CloseFigure()

        picArtigo.Region = New Region(path)
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