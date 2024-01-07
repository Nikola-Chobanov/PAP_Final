''' <summary>
'''      Classe frmSeries- Form da Tabela de Series
'''      Gerado em 29/11/2022 14:12:54
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2022
''' </remarks>
Public Class UC_Series

    Dim mLista As New List(Of ClsSeries)

    Private Sub UC_Series_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mLista = ClsSeries.GetSeries
        mNav = New clsNav(mLista.Count)

        UC_NAV11.mFRM = Me

        SetupComps(True)
        UC_NAV11.Load_Status()
        UC_NAV11.SetupNav()
        LoadRegistos()

        Me.Text = "Manutenção da Tabela de Series"

        setup_ugSeries(mLista)
    End Sub

    Sub setup_ugSeries(ByVal pDataSource As List(Of ClsSeries))
        With ugSeries
            .DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.Select
            .DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None
            .DataSource = pDataSource
        End With
    End Sub

    Sub SetupComps(ByVal pBool As Boolean)
        Me.CodSerieTextEdit.ReadOnly = True
        If Not pBool Then
            If Me.UC_NAV11.mNovo Then
                Me.CodSerieTextEdit.Focus()
            Else
                Me.FLGTipoDocTextEdit.Focus()
            End If
        End If
        FLGTipoDocTextEdit.ReadOnly = pBool
        FLGTipoDocTextEdit.Enabled = Not pBool
        ContadorTextEdit.ReadOnly = pBool
        ContadorTextEdit.Enabled = Not pBool
        AnoTrabalhoTextEdit.ReadOnly = pBool
        AnoTrabalhoTextEdit.Enabled = Not pBool
        FiltroCheckEdit.Enabled = pBool

        '------------------------------
        'Exemplo da eventual UltraCmbo 
        '------------------------------
        'Me.PaisUltraCombo.ReadOnly = pBool

    End Sub

    Sub LoadRegistos()
        LimpaTXT()
        If mNav.Registo_Atual > 0 Then
            With mLista(mNav.Registo_Atual - 1)
                FLGTipoDocTextEdit.Text = .FLG_Tipo_Doc
                AnoTrabalhoTextEdit.Text = .Ano_Trabalho
                ContadorTextEdit.Text = .Contador
                '-------------------------
                ' Cod_Serie
                '-------------------------
                CodSerieTextEdit.Text = .Cod_Serie

                '-------------------------------
                'Exemplo para as Combos...
                '-------------------------------
                'ucPaises.Text = clsPaises.GetPaisbyCod(.Cod_Pais).Pais
            End With
            '-------------------------------
            'upBar.Value = mNav.Registo_Atual
            '-------------------------------

        End If

    End Sub

    Sub LimpaTXT()

        FLGTipoDocTextEdit.Text = ""
        AnoTrabalhoTextEdit.Text = ""
        ContadorTextEdit.Text = ""
        '-------------------------------
        CodSerieTextEdit.Text = ""
    End Sub


    Sub Grava(ByVal pbNovo As Boolean)

        '----------------------------------
        'Exemplo de UltraValidate
        '----------------------------------
        'UltraValidator1.Validate()
        '----------------------------------

        Dim mFLG_Gravou As Boolean = False
        Dim mCls As New ClsSeries
        Dim mRegisto_Atual As Integer = mNav.Registo_Atual

        With mCls
            If pbNovo Then
                '--------------------------------------
                'Método Não criado na CLASSE 
                ' Se for preciso é preciso criá-lo... 
                '--------------------------------------
                '.Cod_Serie = ClsSeries.GetNovoCodigo
                '--------------------------------------
            Else
                '--------------------------------------
                ' Se for preciso é preciso criá-lo... 
                '--------------------------------------
                .Cod_Serie = CodSerieTextEdit.Text
            End If
            '----------------------------------
            'Aqui VERIFICAR Todos os CAMPOS
            '  Não tem por ex. o FLG_Ativo...
            '----------------------------------
            .FLG_Tipo_Doc = FLGTipoDocTextEdit.Text
            .Ano_Trabalho = AnoTrabalhoTextEdit.Text
            .Contador = ContadorTextEdit.Text
        End With

        If pbNovo Then
            mFLG_Gravou = ClsSeries.GravaSeries(mCls)
        Else
            mFLG_Gravou = ClsSeries.ModificaSeries(mCls)
        End If


        If mFLG_Gravou Then
            If pbNovo Then
                Me.UC_NAV11.mNovo = False
                mLista = ClsSeries.GetSeries
                mNav = New clsNav(mLista.Count)
                mNav.Registo_Atual = mLista.FindIndex(Function(x) x.Cod_Serie = mCls.Cod_Serie) + 1
                LoadRegistos()

                '---------------------------
                'upBar.Maximum = mNav.Max_Registos
                'upBar.Value = mNav.Registo_Atual
            Else
                mLista = ClsSeries.GetSeries
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
            ClsSeries.ApagaSeries(mLista(mNav.Registo_Atual - 1).Cod_Serie)
        Catch ex As Exception
            MsgBox("Erro a Apagar o Registo Atual" & vbCrLf & ex.Message)
            Exit Sub
        End Try

        mLista = ClsSeries.GetSeries
        mNav = New clsNav(mLista.Count)
        LoadRegistos()
    End Sub

    Private Sub picCriarSerie_Click(sender As Object, e As EventArgs) Handles picCriarSerie.Click
        '------------------------------------
        'Mudar o ano da tabela Empresas
        '------------------------------------
        Dim mAnoAtual As String = Year(Date.Now).ToString

        If Not ClsEmpresas.GravaAnoAtual(mAnoAtual) Then
            MsgBox("Erro na gravação do ano atual")
            Exit Sub
        End If
        '------------------------------------------
        'Criar os Cod_Serie para todos os Tipos_Doc
        '------------------------------------------
        If Not ClsSeries.Cria_Serie(mAnoAtual) Then
            MsgBox("Erro na Criação da Serie")
            Exit Sub
        End If
    End Sub

    Private Sub picCriarSerie_MouseHover(sender As Object, e As EventArgs) Handles picCriarSerie.MouseHover
        picCriarSerie.Image = My.Resources.CriarSerieShade2
    End Sub

    Private Sub picCriarSerie_MouseLeave(sender As Object, e As EventArgs) Handles picCriarSerie.MouseLeave
        picCriarSerie.Image = My.Resources.CriarSerie
    End Sub

    Private Sub FiltroCheckEdit_CheckedChanged(sender As Object, e As EventArgs) Handles FiltroCheckEdit.EditValueChanged
        Dim mclsFiltro As New ClsSeries With {.Cod_Serie = CodSerieTextEdit.Text, .FLG_Tipo_Doc = FLGTipoDocTextEdit.Text}
        Dim mListaFiltro = ClsSeries.FiltrarSeries(mclsFiltro)
        Dim mDataSource As New List(Of ClsSeries)
        If FiltroCheckEdit.Checked Then
            mDataSource = mListaFiltro
        Else
            mDataSource = mLista
        End If
        setup_ugSeries(mDataSource)
    End Sub
End Class
