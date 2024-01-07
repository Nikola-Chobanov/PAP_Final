Public Class ucTiposConsulta


    ''' <summary>
    '''      Classe frmTipo_Consulta- Form da Tabela de Tipo_Consulta
    '''      Gerado em 29/11/2022 14:12:55
    ''' </summary>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>

    Dim mLista As New List(Of ClsTipos_Consulta)

    Private Sub frmTipo_Consulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mLista = ClsTipos_Consulta.GetTipos_Consulta
        mNav = New clsNav(mLista.Count)

        UC_NAV1.mFRM = Me

        SetupComps(True)
        UC_NAV1.Load_Status()
        UC_NAV1.SetupNav()
        LoadRegistos()

        Me.Text = "Manutenção da Tabela de Tipo_Consulta"

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
        ' A mLista que contém a lista de Tipo_Consulta
        ' pode ser filtrada através do método
        ' FiltrarTipo_Consulta com o parâmetro da ClsTipo_Consulta
        ' 
        ' É preciso criar uma variável do tipo ClsTipo_Consulta
        ' e chamar o método FiltrarTipo_Consulta com esse parâmetro:
        '
        '   Dim mclsFiltro as New clsTipo_Consulta with {.Cod_Tipo_Consulta=txtCod_Tipo_Consulta.Text, .Designacao=txtDesignacao.Text}
        '   Dim mListaFiltro = clsTipo_Consulta.FiltrarTipo_Consulta(mclsFiltro)
        '----------------------------------------------------------------------------------------------

        '-----------------
        'ucPaises
        '-----------------
        'ucPaises.DataSource = clsPaises.GetPaises
        'ucPaises.DisplayMember = "Pais"
        'ucPaises.ValueMember = "Cod_Pais"


    End Sub


    Sub SetupComps(ByVal pBool As Boolean)
        Me.CodTipoConsultaTextEdit.ReadOnly = True
        If Not pBool Then
            If Me.UC_NAV1.mNovo Then
                Me.CodTipoConsultaTextEdit.Focus()
            Else
                Me.DesignacaoTextEdit.Focus()
            End If
        End If
        DesignacaoTextEdit.ReadOnly = pBool
        DesignacaoTextEdit.Enabled = Not pBool

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
                '-------------------------
                ' Cod_Tipo_Consulta
                '-------------------------
                CodTipoConsultaTextEdit.Text = .Cod_Tipo_Consulta

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

        DesignacaoTextEdit.Text = ""
        '-------------------------------
        CodTipoConsultaTextEdit.Text = ""
        If UC_NAV1.mNovo Then
            CodTipoConsultaTextEdit.Text = ClsTipos_Consulta.GetNovoCodigo
        End If
    End Sub


    Sub Grava(ByVal pbNovo As Boolean)

        '----------------------------------
        'Exemplo de UltraValidate
        '----------------------------------
        'UltraValidator1.Validate()
        '----------------------------------

        Dim mFLG_Gravou As Boolean = False
        Dim mCls As New ClsTipos_Consulta
        Dim mRegisto_Atual As Integer = mNav.Registo_Atual

        With mCls
            If pbNovo Then
                '--------------------------------------
                'Método Não criado na CLASSE 
                ' Se for preciso é preciso criá-lo... 
                '--------------------------------------
                .Cod_Tipo_Consulta = CodTipoConsultaTextEdit.Text
                '--------------------------------------
            Else

                .Cod_Tipo_Consulta = CodTipoConsultaTextEdit.Text
            End If

            .Designacao = DesignacaoTextEdit.Text
        End With

        If pbNovo Then
            mFLG_Gravou = ClsTipos_Consulta.GravaTipos_Consulta(mCls)
        Else
            mFLG_Gravou = ClsTipos_Consulta.ModificaTipos_Consulta(mCls)
        End If


        If mFLG_Gravou Then
            If pbNovo Then
                Me.UC_NAV1.mNovo = False
                mLista = ClsTipos_Consulta.GetTipos_Consulta
                mNav = New clsNav(mLista.Count)
                mNav.Registo_Atual = mLista.FindIndex(Function(x) x.Cod_Tipo_Consulta = mCls.Cod_Tipo_Consulta) + 1
                LoadRegistos()

                '---------------------------
                'upBar.Maximum = mNav.Max_Registos
                'upBar.Value = mNav.Registo_Atual
            Else
                mLista = ClsTipos_Consulta.GetTipos_Consulta
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
            ClsTipos_Consulta.ApagaTipos_Consulta(mLista(mNav.Registo_Atual - 1).Cod_Tipo_Consulta)
        Catch ex As Exception
            MsgBox("Erro a Apagar o Registo Atual" & vbCrLf & ex.Message)
            Exit Sub
        End Try

        mLista = ClsTipos_Consulta.GetTipos_Consulta
        mNav = New clsNav(mLista.Count)
        LoadRegistos()
    End Sub

End Class
