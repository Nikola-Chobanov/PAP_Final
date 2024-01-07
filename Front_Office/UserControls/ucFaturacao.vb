Imports DevExpress.XtraPrinting.Native
Imports DevExpress.XtraRichEdit.Import.Html
Imports Infragistics.Win
Imports Infragistics.Win.Misc
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinLiveTileView
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports System.Drawing
Imports DevExpress.DashboardCommon

Public Class ucFaturacao

    Friend Shared Property FLG_Consulta As Boolean = False
    Friend Shared Property cCod_Cliente As String = ""
    Friend Shared Property cCod_Artigo As String = ""

    Dim mTileGroup As Infragistics.Win.UltraWinLiveTileView.TileGroup

    Dim mListaCategorias As New List(Of ClsCategorias)
    Dim mListaArtigos As New List(Of ClsArtigos)
    Dim mListaEntidades As New List(Of ClsEntidades)

    Dim mPathCategorias As String = Application.StartupPath + "\..\..\Resources\Images\Categorias\"
    Dim mPathArtigos As String = Application.StartupPath + "\..\..\Resources\Images\Artigos\"

    Dim mLinhas As List(Of ClsLinhas)
    Dim mDoc As New ClsDoc
    Dim mTD As New ClsTipos_Doc
    Dim mIndexCat As Integer
    Dim mEntidade As New ClsEntidades
    Dim mNumDocAtual As String
    Dim mFLG_Novo As Boolean = True
    Dim mIndex_Clientes As Integer = 0



    Private Sub ucFaturacao_Load(sender As Object, e As EventArgs) Handles Me.Load
        mListaEntidades = ClsEntidades.GetEntidadesByFLG("C")


        'UC_Clientes.DataSource = mLista_Entidades

        'UC_TipoPagamento.DataSource = ClsTipos_Pagamento.GetTipos_Pagamento

        mTD = ClsTipos_Doc.GetTipos_DocByCod("FC")
        ucTP.DataSource = ClsTipos_Pagamento.GetTipos_Pagamento
        ucClientes.DataSource = mListaEntidades

        ucClientes.Rows(mIndex_Clientes).Selected = True

        If FLG_Consulta Then
            mDoc = New ClsDoc(mTD, cCod_Cliente, cCod_Artigo)
            mIndex_Clientes = mListaEntidades.FindIndex(Function(x) x.Cod_Entidade = cCod_Cliente)

            ucClientes.Rows(mIndex_Clientes).Selected = True
        Else
            mDoc = New ClsDoc(mTD)
        End If
        mEntidade = mListaEntidades(mIndex_Clientes)
        Display_Entidade()
        ugLinhas.DataSource = mDoc.Linhas

        LoadCategorias()
        Config_ugLinhas()
        DisplayQI()
        DisplayTotais()
    End Sub

    Sub LoadCategorias()
        Dim mCaminho As String
        UltraLiveTileView.TileSizing = Infragistics.Win.UltraWinLiveTileView.TileSizing.Medium
        UltraLiveTileView.Appearance.BorderColor = Color.Transparent
        mListaCategorias = ClsCategorias.GetCategorias

        Try
            UltraLiveTileView.Groups.Clear()
            mTileGroup = UltraLiveTileView.Groups.Add("Categorias")
        Catch ex As Exception

        End Try

        For Each mCategoria As ClsCategorias In mListaCategorias
            mCaminho = ""

            With mCategoria
                mTileGroup.Text = ""
                Dim mTile As LiveTile
                mTile = mTileGroup.Tiles.AddLiveTile(.Cod_Categoria)
                mCaminho = mPathCategorias + mCategoria.Imagem
                mTile.Appearance.Normal.ImageBackground = Image.FromFile(mCaminho)

                mTileGroup.Control.Dock = DockStyle.Bottom
                mTile.Control.ResolutionScale = ResolutionScale.Scale140Percent

                mTile.Appearance.Active.BorderColor = Color.Transparent
                mTile.Appearance.Active.BackColor = Color.Transparent
                mTile.Appearance.Selected.BorderColor = Color.Transparent
                mTile.Appearance.Selected.BackColor = Color.Transparent
                mTile.Appearance.Normal.BorderColor = Color.Transparent
                mTile.Appearance.Normal.BackColor = Color.Transparent

            End With

        Next

    End Sub

    Sub LoadArtigos(ByVal pCodCategoria As String)


        mListaArtigos = ClsArtigos.GetArtigosByCategoria(pCodCategoria)

        UltraLiveTileView.TileSizing = Infragistics.Win.UltraWinLiveTileView.TileSizing.Medium
        UltraLiveTileView.Appearance.BorderColor = Color.Transparent

        Try
            UltraLiveTileView.Groups.Clear()
            mTileGroup = UltraLiveTileView.Groups.Add("Artigos")
        Catch ex As Exception

        End Try

        For Each mArtigo As ClsArtigos In mListaArtigos
            Dim mCaminho As String = ""

            With mArtigo
                mTileGroup.Text = ""
                Dim mTile As StaticTile
                mTile = mTileGroup.Tiles.AddStaticTile(.Cod_Artigo)
                mTile.DefaultView.Text = mArtigo.Designacao


                mCaminho = mPathArtigos + mArtigo.Imagem

                Try
                    mTile.DefaultView.Image.AllResolutions.Image = Image.FromFile(mCaminho)
                Catch ex As Exception
                    mTile.DefaultView.Image.AllResolutions.Image = Image.FromFile(mPathArtigos + "Default.png")
                End Try

                mTile.Control.Dock = DockStyle.Fill
                mTile.Control.ResolutionScale = ResolutionScale.Scale140Percent

                mTile.Appearance.Active.BorderColor = Color.Transparent
                mTile.Appearance.Active.BackColor = Color.Transparent
                mTile.Appearance.Selected.BorderColor = Color.Transparent
                mTile.Appearance.Selected.BackColor = Color.Transparent
                mTile.Appearance.Normal.BorderColor = Color.Transparent
                mTile.Appearance.Normal.BackColor = Color.Transparent

                mTile.Tag = mArtigo.Cod_Artigo
            End With

            TileBack()
        Next

    End Sub

    Sub LoadProcura(ByVal mListaArtigos As List(Of ClsArtigos))


        UltraLiveTileView.TileSizing = Infragistics.Win.UltraWinLiveTileView.TileSizing.Medium
        UltraLiveTileView.Appearance.BorderColor = Color.Transparent


        Try
            UltraLiveTileView.Groups.Clear()
            mTileGroup = UltraLiveTileView.Groups.Add("Artigos")
            TileBack()
        Catch ex As Exception

        End Try

        For Each mArtigo As ClsArtigos In mListaArtigos
            Dim mCaminho As String = ""

            With mArtigo
                mTileGroup.Text = ""
                Dim mTile As StaticTile
                mTile = mTileGroup.Tiles.AddStaticTile(.Cod_Artigo)
                mTile.DefaultView.Text = mArtigo.Designacao


                mCaminho = mPathArtigos + mArtigo.Imagem

                Try
                    mTile.DefaultView.Image.AllResolutions.Image = Image.FromFile(mCaminho)
                Catch ex As Exception
                    mTile.DefaultView.Image.AllResolutions.Image = Image.FromFile(mPathArtigos + "Default.png")
                End Try

                mTile.Control.Dock = DockStyle.Fill
                mTile.Control.ResolutionScale = ResolutionScale.Scale140Percent

                mTile.Appearance.Active.BorderColor = Color.Transparent
                mTile.Appearance.Active.BackColor = Color.Transparent
                mTile.Appearance.Selected.BorderColor = Color.Transparent
                mTile.Appearance.Selected.BackColor = Color.Transparent
                mTile.Appearance.Normal.BorderColor = Color.Transparent
                mTile.Appearance.Normal.BackColor = Color.Transparent

                mTile.Tag = mArtigo.Cod_Artigo
            End With


        Next
    End Sub

    Sub TileBack()
        If mTileGroup.Tiles.ContainsKey("Voltar") Then
            mTileGroup.Tiles.Remove("Voltar")
        End If

        Dim mTile As LiveTile = mTileGroup.Tiles.AddLiveTile("Voltar")
        mTile.Appearance.Normal.ImageBackground = Image.FromFile(mPathCategorias + "Voltar.png")
        mTile.Appearance.Normal.BackColor = Color.White
    End Sub

    Private Sub UltraLiveTileView_Click(sender As Object, e As TileClickEventArgs) Handles UltraLiveTileView.TileClick
        Select Case mTileGroup.Key

            Case "Categorias"
                mTileGroup.Tiles.Clear()

                If (e.Tile.Key = "Voltar") Then
                    mTileGroup.Tiles.Clear()
                    UltraTabControl.SelectedTab = UltraTabControl.Tabs.Item(0)
                Else
                    UltraTabControl.SelectedTab = UltraTabControl.Tabs.Item(0)
                    mIndexCat = mListaCategorias.FindIndex(Function(x) x.Cod_Categoria = e.Tile.Key)
                    LoadArtigos(mListaCategorias(mIndexCat).Cod_Categoria)
                End If

            Case "Artigos"

                If (e.Tile.Key = "Voltar") Then
                    mTileGroup.Tiles.Clear()
                    LoadCategorias()
                Else
                    Dim mDdd As String
                    mDdd = mDoc.Num_Doc & " - " & e.Tile.Tag
                    AddLinha(e.Tile.Tag)
                    DisplayTotais()
                    DisplayQI()
                End If


        End Select
    End Sub

    Sub AddLinha(pCod_Artigo As String)
        Dim mArtigo As New ClsArtigos
        mArtigo = ClsArtigos.GetArtigosByCod(pCod_Artigo)

        Dim mIndexArtigo = 0

        Dim NumArtigos As Integer = mDoc.Linhas.FindAll(Function(x) x.Cod_Artigo = mArtigo.Cod_Artigo).Count

        If NumArtigos = 0 Then
            Dim index As Integer = mDoc.Linhas.FindIndex(Function(x) x.Cod_Artigo = "")
            mDoc.Linhas(index) = New ClsLinhas(mDoc.Num_Doc, index, mArtigo, 1, 0, mTD.FLG_Entidade)
        Else
            Dim linhaParaAtualizar = mDoc.Linhas.Find(Function(x) x.Cod_Artigo = mArtigo.Cod_Artigo)
            linhaParaAtualizar.Quantidade += 1
            linhaParaAtualizar.strQuantidade = linhaParaAtualizar.Quantidade.ToString()
        End If

        ugLinhas.ActiveRow.Update()
        ugLinhas.DataSource = mDoc.Linhas
        ugLinhas.Refresh()
    End Sub

    Sub Config_ugLinhas()

        With ugLinhas.DisplayLayout.Bands(0)
            .Columns("Num_Doc").Hidden = True

            .Columns("Num_Linha").Hidden = True

            .Columns("StrNum_Linha").Hidden = False
            .Columns("StrNum_Linha").Width = 4 * 6.5
            .Columns("StrNum_Linha").CellAppearance.TextHAlign = HAlign.Center
            .Columns("StrNum_Linha").Header.Caption = "Nº"
            .Columns("StrNum_Linha").Header.Appearance.TextHAlign = HAlign.Center
            .Columns("StrNum_Linha").CellActivation = Activation.NoEdit

            .Columns("Cod_Artigo").Hidden = False
            .Columns("Cod_Artigo").Width = 9 * 6.5
            .Columns("Cod_Artigo").CellAppearance.TextHAlign = HAlign.Center
            .Columns("Cod_Artigo").Header.Caption = "Código"
            .Columns("Cod_Artigo").Header.Appearance.TextHAlign = HAlign.Center
            .Columns("Cod_Artigo").CellActivation = Activation.NoEdit

            .Columns("FLG_Entidade").Hidden = True

            .Columns("Artigo").Hidden = False
            .Columns("Artigo").Width = 30 * 6.5
            .Columns("Artigo").CellAppearance.TextHAlign = HAlign.Left
            .Columns("Artigo").Header.Caption = "Artigo"
            .Columns("Artigo").Header.Appearance.TextHAlign = HAlign.Left
            .Columns("Artigo").CellActivation = Activation.AllowEdit


            .Columns("Artigo").Style = ColumnStyle.DropDownValidate
            .Columns("Artigo").AutoCompleteMode = AutoCompleteMode.Suggest
            .Columns("Artigo").AutoSuggestFilterMode = AutoSuggestFilterMode.Contains

            .Columns("Quantidade").Hidden = True

            .Columns("strQuantidade").Hidden = False
            .Columns("strQuantidade").Width = 6 * 6.5
            .Columns("strQuantidade").CellAppearance.TextHAlign = HAlign.Center
            .Columns("strQuantidade").Header.Caption = "QTD"
            .Columns("strQuantidade").Header.Appearance.TextHAlign = HAlign.Center
            .Columns("strQuantidade").CellActivation = Activation.AllowEdit

            .Columns("Unidade").Hidden = True
            .Columns("Unidade").Width = 6 * 6.5
            .Columns("Unidade").CellAppearance.TextHAlign = HAlign.Center
            .Columns("Unidade").Header.Caption = "Un."
            .Columns("Unidade").Header.Appearance.TextHAlign = HAlign.Center
            .Columns("Unidade").CellActivation = Activation.NoEdit

            .Columns("P_Unitario").Hidden = True

            .Columns("strP_Unitario").Hidden = False
            .Columns("strP_Unitario").Width = 8 * 6.5
            .Columns("strP_Unitario").CellAppearance.TextHAlign = HAlign.Right
            .Columns("strP_Unitario").Header.Caption = "P.Unit"
            .Columns("strP_Unitario").Header.Appearance.TextHAlign = HAlign.Center
            .Columns("strP_Unitario").CellActivation = Activation.NoEdit
            .Columns("strP_Unitario").Format = "###,###.00"


            .Columns("Taxa_IVA").Hidden = True

            .Columns("Valor_IVA").Hidden = True

            .Columns("Taxa_Desconto").Hidden = True

            .Columns("strTaxa_Desconto").Hidden = False
            .Columns("strTaxa_Desconto").Width = 8 * 6.5
            .Columns("strTaxa_Desconto").CellAppearance.TextHAlign = HAlign.Center
            .Columns("strTaxa_Desconto").Header.Caption = "%Dsc"
            .Columns("strTaxa_Desconto").Header.Appearance.TextHAlign = HAlign.Center
            .Columns("strTaxa_Desconto").CellActivation = Activation.AllowEdit

            .Columns("strTaxa_IVA").Hidden = True
            .Columns("strTaxa_IVA").Width = 8 * 6.5
            .Columns("strTaxa_IVA").CellAppearance.TextHAlign = HAlign.Center
            .Columns("strTaxa_IVA").Header.Caption = "%IVA"
            .Columns("strTaxa_IVA").Header.Appearance.TextHAlign = HAlign.Center
            .Columns("strTaxa_IVA").CellActivation = Activation.NoEdit


            .Columns("Valor_Desconto").Hidden = True

            .Columns("Valor_Iliquido").Hidden = True

            .Columns("strValor_Iliquido").Hidden = True
            .Columns("strValor_Iliquido").Width = 12 * 6.5
            .Columns("strValor_Iliquido").CellAppearance.TextHAlign = HAlign.Right
            .Columns("strValor_Iliquido").Header.Caption = "V.Ilíquido"
            .Columns("strValor_Iliquido").Header.Appearance.TextHAlign = HAlign.Center
            .Columns("strValor_Iliquido").CellActivation = Activation.NoEdit
            .Columns("strValor_Iliquido").Format = "###,###.00"

            .Columns("FLG_Ativo").Hidden = True

        End With
    End Sub

    Sub Init_ugLinhas()
        ugLinhas.DataBindings.Clear()
        ugLinhas.DataSource = New List(Of ClsLinhas)

        ugLinhas.DisplayLayout.Bands(0).Columns("P_Unitario").Format = "###.##"
        ugLinhas.DisplayLayout.Bands(0).Columns("Valor_Iliquido").Format = "###,###.##"

        ugLinhas.Enabled = False
        For Each mRow As UltraGridRow In ugLinhas.Rows
            mRow.Activate()
            If mRow.Cells("Designacao").Value <> "" Then Remover()
        Next
        ugLinhas.PerformAction(FirstRowInGrid)
        ugLinhas.PerformAction(FirstCellInGrid)
        ugLinhas.PerformAction(NextCell)
        ugLinhas.Enabled = True
    End Sub

    Sub Remover()

        ugLinhas.EventManager.AllEventsEnabled = False

        With ugLinhas.ActiveRow.Cells
            If ugLinhas.ActiveRow.Cells.Item("Quantidade").Value > 1 Then
                ugLinhas.ActiveRow.Cells.Item("Quantidade").Value = ugLinhas.ActiveRow.Cells.Item("Quantidade").Value - 1
                ugLinhas.ActiveRow.Cells.Item("Valor_Iliquido").Value = ugLinhas.ActiveRow.Cells.Item("Valor_Iliquido").Value - ugLinhas.ActiveRow.Cells.Item("P_Unitario").Value
            Else
                .Item("Designacao").Value = ""
                .Item("Cod_Artigo").Value = ""
                .Item("FLG_Preferencia").Value = False
                .Item("Quantidade").Value = ""
                .Item("Unidade").Value = ""
                .Item("P_Unitario").Value = ""
                .Item("Taxa_Desconto").Value = ""
                .Item("Taxa_IVA").Value = ""
                .Item("Valor_IVA").Value = ""
                .Item("Valor_Iliquido").Value = ""
                .Item("Tipo_IVA").Value = "N"
                .Item("Valor_Desconto").Value = "0,00"
                .Item("FLG_Feita").Value = False

            End If
        End With


        ugLinhas.ActiveCell = ugLinhas.ActiveRow.Cells("Designacao")
        ugLinhas.PerformAction(EnterEditMode)

        ugLinhas.EventManager.AllEventsEnabled = True

    End Sub

    Sub DisplayQI()
        mDoc.LinhasQI = ClsQI.GetQI(mDoc.Linhas)
        ugQI.DataSource = mDoc.LinhasQI
        ugQI.Refresh()
    End Sub

    Sub DisplayTotais()
        mDoc.Totais = New ClsDoc_Totais(mDoc.Linhas)

        With mDoc.Totais
            Me.lblTotalIliquido.Text = FormatCurrency(.Total_Iliquido)
            Me.lblTotalDesconto.Text = FormatCurrency(.Total_Desconto)
            Me.lblTotalIVA.Text = FormatCurrency(.Total_IVA)
            Me.lblTotalAPagar.Text = FormatCurrency(.Total_A_Pagar)
        End With


    End Sub

    Sub GravaDoc()
        If Not ClsGrava.Grava_Documento(mDoc, mTD) Then
            'MsgBox("Documento: " & mDoc.Designacao & " não foi gravado!")
        Else
            'MsgBox("Documento: " & mDoc.Designacao & " gravado com sucesso!")
        End If
    End Sub

    Sub NovoDoc()
        mFLG_Novo = True
        DisplayTotais()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        UltraTabControl.SelectedTab = UltraTabControl.Tabs.Item(0)
        mNumDocAtual = ""

        GravaDoc()
        Imprimir_Doc()
    End Sub

    Sub Imprimir_Doc()
        Dim mxFAT As New xrFAT
        Dim mxQI As New xrQI
        mxFAT.ObjectDataSource1.Parameters(0).Value = mDoc.Num_Doc

        mxQI.ObjectDataSource1.Parameters(0).Value = mDoc.Num_Doc
        mxFAT.xrSubQI.ReportSource = mxQI

        frmReport.dvReport.DocumentSource = mxFAT
        frmReport.ShowDialog()

        frmMain.mUC.Parent = Nothing
        frmMain.loadUC(enUserControlsFront.Dashboard)

    End Sub


    Private Sub btnImprimir_GotFocus(sender As Object, e As EventArgs) Handles btnImprimir.GotFocus
        btnImprimir.BackgroundImage = My.Resources.ImprimirShade
    End Sub

    Private Sub btnImprimir_Leave(sender As Object, e As EventArgs) Handles btnImprimir.Leave
        btnImprimir.BackgroundImage = My.Resources.Imprimir
    End Sub

    Private Sub btnProxPag_Click(sender As Object, e As EventArgs) Handles btnProxPag.Click
        UltraTabControl.SelectedTab = UltraTabControl.Tabs.Item(1)
        btnImprimir.Enabled = False
    End Sub

    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
        UltraTabControl.SelectedTab = UltraTabControl.Tabs.Item(0)
    End Sub

    Private Sub ucTiposPagamento_AfterCloseUp(sender As Object, e As EventArgs) Handles ucTP.AfterCloseUp
        btnImprimir.Enabled = True
    End Sub

    Private Sub ucClientes_AfterCloseUp(sender As Object, e As EventArgs) Handles ucClientes.AfterCloseUp
        Dim mRow As UltraGridRow = ucClientes.ActiveRow
        Dim mIndex As Integer = 0

        Try
            mIndex = mRow.Index
        Catch ex As Exception
            mIndex = 0
        End Try

        mEntidade = mListaEntidades(mIndex)

        Display_Entidade()
    End Sub

    Sub Display_Entidade()
        With mEntidade
            Me.ucClientes.Text = .Cod_Entidade
            Me.NomeTextEdit.Text = .Nome
            Me.EnderecoTextEdit.Text = .Lista_Enderecos(0).Endereco
            Me.LocalidadeTextEdit.Text = .Lista_Enderecos(0).Localidade
            Me.NIFTextEdit.Text = .NIF
            Me.CodPostalTextEdit.Text = .Lista_Enderecos(0).Cod_Postal
        End With

        mDoc.Cod_Entidade = mEntidade.Cod_Entidade
    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles testBTN.Click
        Dim mxFAT As New xrFAT
        Dim mxQI As New xrQI

        mDoc = ClsDoc.GetDocByCod("FC0022/2023")


        Dim mlistaLinhas As List(Of ClsLinhas)
        mlistaLinhas = ClsLinhas.GetLinhas("FC0022/2023")
        With mxFAT
            .ObjectDataSource1.Parameters(0).Value = mDoc.Num_Doc
        End With
        mxQI.ObjectDataSource1.Parameters(0).Value = mDoc.Num_Doc

        frmReport.dvReport.DocumentSource = mxFAT
        frmReport.ShowDialog()
    End Sub

    Private Sub btnProxPag_MouseMove(sender As Object, e As MouseEventArgs) Handles btnProxPag.MouseMove
        btnProxPag.BackgroundImage = My.Resources.ProximoArtigosShade
    End Sub

    Private Sub btnProxPag_MouseLeave(sender As Object, e As EventArgs) Handles btnProxPag.MouseLeave
        btnProxPag.BackgroundImage = My.Resources.ProximoArtigos
    End Sub

    Private Sub btnImprimir_MouseMove(sender As Object, e As MouseEventArgs) Handles btnImprimir.MouseMove
        btnImprimir.BackgroundImage = My.Resources.ImprimirShade
    End Sub

    Private Sub btnImprimir_MouseLeave(sender As Object, e As EventArgs) Handles btnImprimir.MouseLeave
        btnImprimir.BackgroundImage = My.Resources.Imprimir
    End Sub

    Private Sub btnVoltar_MouseMove(sender As Object, e As MouseEventArgs) Handles btnVoltar.MouseMove
        btnVoltar.BackgroundImage = My.Resources.VoltarArtigosShade
    End Sub

    Private Sub btnVoltar_MouseLeave(sender As Object, e As EventArgs) Handles btnVoltar.MouseLeave
        btnVoltar.BackgroundImage = My.Resources.VoltarArtigos
    End Sub

    Private Sub txtPesquisa_Click(sender As Object, e As EventArgs) Handles txtPesquisa.Click
        txtPesquisa.Text = ""
        txtPesquisa.ForeColor = Color.DimGray
    End Sub

    Private Sub btnPesquisa_Click(sender As Object, e As EventArgs) Handles btnPesquisa.Click
        If txtPesquisa.Text <> "" Then
            mListaArtigos = ClsArtigos.ProcuraArtigo(txtPesquisa.Text)
        End If

        LoadProcura(mListaArtigos)

    End Sub

End Class