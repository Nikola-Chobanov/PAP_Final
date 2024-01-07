''' <summary>
'''      Classe frmIVA- Form da Tabela de IVA
'''      Gerado em 03/03/2023 15:49:34
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2023
''' </remarks>
Public Class ucIVA
    Dim mLista As New List(Of ClsIVA)

    Private Sub UC_IVA_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mLista = ClsIVA.GetIVA
        mNav = New clsNav(mLista.Count)

        UC_NAV1.mFRM = Me

        SetupComps(True)
        UC_NAV1.Load_Status()
        UC_NAV1.SetupNav()
        LoadRegistos()

        Me.Text = "Manutenção da Tabela de IVA"

#Region "exemplo de cope"
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
        ' A mLista que contém a lista de IVA
        ' pode ser filtrada através do método
        ' FiltrarIVA com o parâmetro da ClsIVA
        ' 
        ' É preciso criar uma variável do tipo ClsIVA
        ' e chamar o método FiltrarIVA com esse parâmetro:
        '
        '   Dim mclsFiltro as New clsIVA with {.Cod_IVA=txtCod_IVA.Text, .Taxa_IVA=txtTaxa_IVA.Text}
        '   Dim mListaFiltro = clsIVA.FiltrarIVA(mclsFiltro)
        '----------------------------------------------------------------------------------------------

        '-----------------
        'ucPaises
        '-----------------
        'ucPaises.DataSource = clsPaises.GetPaises
        'ucPaises.DisplayMember = "Pais"
        'ucPaises.ValueMember = "Cod_Pais"
#End Region

    End Sub


    Sub SetupComps(ByVal pBool As Boolean)
        Me.CodIVATextEdit.ReadOnly = True
        If Not pBool Then
            If Me.UC_NAV1.mNovo Then
                Me.CodIVATextEdit.Focus()
            Else
                Me.TaxaIVATextEdit.Focus()
            End If
        End If
        TaxaIVATextEdit.ReadOnly = pBool
        TaxaIVATextEdit.Enabled = Not pBool
        TipoIVATextEdit.ReadOnly = pBool
        TipoIVATextEdit.Enabled = Not pBool
        DesignacaoTextEdit.ReadOnly = pBool
        DesignacaoTextEdit.Enabled = Not pBool
        Data_Inicio_VigorDateEdit.ReadOnly = pBool
        Data_Inicio_VigorDateEdit.Enabled = Not pBool
        Data_Fim_VigorDateEdit.ReadOnly = pBool
        Data_Fim_VigorDateEdit.Enabled = Not pBool
        FLGDescontinuadoCheckEdit.Enabled = Not pBool

        '------------------------------
        'Exemplo da eventual UltraCmbo 
        '------------------------------
        'Me.PaisUltraCombo.ReadOnly = pBool

    End Sub

    Sub LoadRegistos()
        LimpaTXT()
        If mNav.Registo_Atual > 0 Then
            With mLista(mNav.Registo_Atual - 1)
                TaxaIVATextEdit.Text = .Taxa_IVA
                TipoIVATextEdit.Text = .Tipo_IVA
                DesignacaoTextEdit.Text = .Designacao
                Data_Inicio_VigorDateEdit.Text = .Data_Inicio_Vigor
                Data_Fim_VigorDateEdit.Text = .Data_Fim_Vigor
                FLGDescontinuadoCheckEdit.EditValue = .FLG_Descontinuado
                '-------------------------
                ' Cod_IVA
                '-------------------------
                CodIVATextEdit.Text = .Cod_IVA

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

        TaxaIVATextEdit.Text = ""
        TipoIVATextEdit.Text = ""
        DesignacaoTextEdit.Text = ""
        Data_Inicio_VigorDateEdit.Text = ""
        Data_Fim_VigorDateEdit.Text = ""
        FLGDescontinuadoCheckEdit.Text = ""
        '-------------------------------
        CodIVATextEdit.Text = ""

        If UC_NAV1.mNovo Then
            CodIVATextEdit.Text = ClsIVA.GetNovoCodigo
            CodIVATextEdit.Refresh()
        End If
    End Sub

    Sub Grava(ByVal pbNovo As Boolean)

        '----------------------------------
        'Exemplo de UltraValidate
        '----------------------------------
        'UltraValidator1.Validate()
        '----------------------------------

        Dim mFLG_Gravou As Boolean = False
        Dim mCls As New ClsIVA
        Dim mRegisto_Atual As Integer = mNav.Registo_Atual

        With mCls
            If pbNovo Then
                .Cod_IVA = CodIVATextEdit.Text
                '--------------------------------------
            Else
                '--------------------------------------
                ' Se for preciso é preciso criá-lo... 
                '--------------------------------------
                .Cod_IVA = CodIVATextEdit.Text
            End If
            '----------------------------------
            'Aqui VERIFICAR Todos os CAMPOS
            '  Não tem por ex. o FLG_Ativo...
            '----------------------------------
            .Taxa_IVA = TaxaIVATextEdit.Text
            .Tipo_IVA = TipoIVATextEdit.Text
            .Designacao = DesignacaoTextEdit.Text
            .Data_Inicio_Vigor = Data_Inicio_VigorDateEdit.Text
            .Data_Fim_Vigor = Data_Fim_VigorDateEdit.Text
            .FLG_Descontinuado = FLGDescontinuadoCheckEdit.CheckState
        End With

        If pbNovo Then
            mFLG_Gravou = ClsIVA.GravaIVA(mCls)
        Else
            mFLG_Gravou = ClsIVA.ModificaIVA(mCls)
        End If


        If mFLG_Gravou Then
            If pbNovo Then
                Me.UC_NAV1.mNovo = False
                mLista = ClsIVA.GetIVA
                mNav = New clsNav(mLista.Count)
                mNav.Registo_Atual = mLista.FindIndex(Function(x) x.Cod_IVA = mCls.Cod_IVA) + 1
                LoadRegistos()

                '---------------------------
                'upBar.Maximum = mNav.Max_Registos
                'upBar.Value = mNav.Registo_Atual
            Else
                mLista = ClsIVA.GetIVA
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
            ClsIVA.ApagaIVA(mLista(mNav.Registo_Atual - 1).Cod_IVA)
        Catch ex As Exception
            MsgBox("Erro a Apagar o Registo Atual" & vbCrLf & ex.Message)
            Exit Sub
        End Try

        mLista = ClsIVA.GetIVA
        mNav = New clsNav(mLista.Count)
        LoadRegistos()
    End Sub

    Private Sub FLGDescontinuadoCheckEdit_CheckedChanged(sender As Object, e As EventArgs) Handles FLGDescontinuadoCheckEdit.Click
        If FLGDescontinuadoCheckEdit.Checked Then
            FLGDescontinuadoCheckEdit.CheckState = CheckState.Unchecked
        Else
            FLGDescontinuadoCheckEdit.CheckState = CheckState.Checked
        End If

    End Sub


End Class
