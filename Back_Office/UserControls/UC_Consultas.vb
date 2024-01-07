Imports DevExpress.CodeParser
Imports DevExpress.Data.Helpers
Imports DevExpress.DataProcessing.ExtractStorage
Imports Infragistics.Win
''' <summary>
'''      Classe frmConsultas- Form da Tabela de Consultas
'''      Gerado em 03/03/2023 15:49:34
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2023
''' </remarks>
Public Class UC_Consultas
    Dim mLista As New List(Of ClsConsultas)
    Dim mListaAnimais As New List(Of ClsAnimais)
    Dim mListaClientes As New List(Of ClsEntidades)
    Dim mListaVeterinarios As New List(Of ClsEntidades)
    Dim mListaTiposConsultas As New List(Of ClsTipos_Consulta)
    Dim mListaSalas As New List(Of ClsSalas)

    Private Sub frmConsultas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mLista = ClsConsultas.GetConsultas
        mNav = New clsNav(mLista.Count)

        UC_NAV1.mFRM = Me

        SetupComps(True)
        UC_NAV1.Load_Status()
        UC_NAV1.SetupNav()
        LoadRegistos()

        mListaAnimais = ClsAnimais.GetAnimaisByEntidade(CodEntidadeTextEdit.Text)
        mListaClientes = ClsEntidades.GetEntidadesByFLG("C")
        mListaVeterinarios = ClsEntidades.GetEntidadesByFLG("V")
        mListaTiposConsultas = ClsTipos_Consulta.GetTipos_Consulta()
        mListaSalas = ClsSalas.GetSalas()

        cbStatus.Items.Add(enStatus.Pago)
        cbStatus.Items.Add(enStatus.N_Pago)
        cbStatus.Items.Add(enStatus.N_Aplicavel)
#Region "Exemplo de codigo"
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
        ' A mLista que contÃ©m a lista de Consultas
        ' pode ser filtrada atravÃ©s do mÃ©todo
        ' FiltrarConsultas com o parÃ¢metro da ClsConsultas
        ' 
        ' Ã‰ preciso criar uma variÃ¡vel do tipo ClsConsultas
        ' e chamar o mÃ©todo FiltrarConsultas com esse parÃ¢metro:
        '
        '   Dim mclsFiltro as New clsConsultas with {.Cod_Consulta=txtCod_Consulta.Text, .Cod_Entidade=txtCod_Entidade.Text}
        '   Dim mListaFiltro = clsConsultas.FiltrarConsultas(mclsFiltro)
        '----------------------------------------------------------------------------------------------

        '-----------------
        'ucPaises
        '-----------------
        'ucPaises.DataSource = clsPaises.GetPaises
        'ucPaises.DisplayMember = "Pais"
        'ucPaises.ValueMember = "Cod_Pais"
#End Region
        LoadCombos()
    End Sub


    Sub LoadCombos()
        ucCodAnimal.DataSource = mListaAnimais
        ucCodEntidade.DataSource = mListaClientes
        ucCodVeterinario.DataSource = mListaVeterinarios
        ucCodTipoConsulta.DataSource = mListaTiposConsultas
        ucSalas.DataSource = mListaSalas
    End Sub


    Sub SetupComps(ByVal pBool As Boolean)
        Me.CodConsultaTextEdit.ReadOnly = True
        If Not pBool Then
            If Me.UC_NAV1.mNovo Then
                Me.CodConsultaTextEdit.Focus()
            Else
                Me.CodEntidadeTextEdit.Focus()
            End If
        End If
        CodAnimalTextEdit.ReadOnly = pBool
        CodAnimalTextEdit.Enabled = Not pBool
        CodEntidadeTextEdit.ReadOnly = pBool
        CodEntidadeTextEdit.Enabled = Not pBool
        CodSalaTextEdit.ReadOnly = pBool
        CodSalaTextEdit.Enabled = Not pBool
        CodTipoConsultaTextEdit.ReadOnly = pBool
        CodTipoConsultaTextEdit.Enabled = Not pBool
        CodTipoAnimalTextEdit.ReadOnly = pBool
        CodTipoAnimalTextEdit.Enabled = Not pBool
        Hora_InicioTimeEdit.ReadOnly = pBool
        Hora_InicioTimeEdit.Enabled = Not pBool
        Hora_FimTimeEdit.ReadOnly = pBool
        Hora_FimTimeEdit.Enabled = Not pBool
        StatusTextEdit.ReadOnly = pBool
        StatusTextEdit.Enabled = Not pBool
        ObservacoesTextEdit.ReadOnly = pBool
        ObservacoesTextEdit.Enabled = Not pBool
        CodVeterinarioTextEdit.ReadOnly = pBool
        CodTipoAnimalTextEdit.Enabled = Not pBool
        DiaDateEdit.ReadOnly = pBool
        DiaDateEdit.Enabled = Not pBool

        cbStatus.Visible = Not pBool
        ucCodEntidade.Visible = Not pBool
        ucCodAnimal.Visible = Not pBool
        ucCodTipoConsulta.Visible = Not pBool
        ucCodVeterinario.Visible = Not pBool
        ucSalas.Visible = Not pBool


        '------------------------------
        'Exemplo da eventual UltraCmbo 
        '------------------------------
        'Me.PaisUltraCombo.ReadOnly = pBool

    End Sub

    Sub LoadRegistos()
        LimpaTXT()
        If mNav.Registo_Atual > 0 Then
            With mLista(mNav.Registo_Atual - 1)
                CodEntidadeTextEdit.Text = .Cod_Entidade
                CodVeterinarioTextEdit.Text = .Cod_Veterinario
                CodSalaTextEdit.Text = .Cod_Sala
                CodAnimalTextEdit.Text = .Cod_Animal
                CodTipoConsultaTextEdit.Text = .Cod_Tipo_Consulta
                CodTipoAnimalTextEdit.Text = .Cod_Tipo_Animal
                DiaDateEdit.Text = .Dia
                Hora_InicioTimeEdit.Time = .Hora_Inicio.ToString("t")
                Hora_FimTimeEdit.Time = .Hora_Fim.ToString("t")
                StatusTextEdit.Text = .Status
                ObservacoesTextEdit.Text = .Observacoes
                '-------------------------
                ' Cod_Consulta
                '-------------------------
                CodConsultaTextEdit.Text = .Cod_Consulta

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

        CodEntidadeTextEdit.Text = ""
        CodVeterinarioTextEdit.Text = ""
        CodSalaTextEdit.Text = ""
        CodAnimalTextEdit.Text = ""
        CodTipoConsultaTextEdit.Text = ""
        CodTipoAnimalTextEdit.Text = ""
        DiaDateEdit.Text = ""
        Hora_InicioTimeEdit.EditValue = ""
        Hora_FimTimeEdit.EditValue = ""
        StatusTextEdit.Text = ""
        ObservacoesTextEdit.Text = ""
        '-------------------------------
        CodConsultaTextEdit.Text = ""
        If UC_NAV1.mNovo Then
            CodConsultaTextEdit.Text = ClsConsultas.GetNovoCodigo
        End If
        '-------------------------------
        ucCodAnimal.Text = ""
        ucCodEntidade.Text = ""
        ucCodTipoConsulta.Text = ""
        ucCodVeterinario.Text = ""
        ucSalas.Text = ""
    End Sub


    Sub Grava(ByVal pbNovo As Boolean)

        '----------------------------------
        'Exemplo de UltraValidate
        '----------------------------------
        'UltraValidator1.Validate()
        '----------------------------------

        Dim mFLG_Gravou As Boolean = False
        Dim mCls As New ClsConsultas
        Dim mRegisto_Atual As Integer = mNav.Registo_Atual

        With mCls
            If pbNovo Then
                .Cod_Consulta = CodConsultaTextEdit.Text
            Else

                .Cod_Consulta = CodConsultaTextEdit.Text
            End If

            .Cod_Entidade = CodEntidadeTextEdit.Text
            .Cod_Veterinario = CodVeterinarioTextEdit.Text
            .Cod_Sala = CodSalaTextEdit.Text
            .Cod_Animal = CodAnimalTextEdit.Text
            .Cod_Tipo_Consulta = CodTipoConsultaTextEdit.Text
            .Cod_Tipo_Animal = CodTipoAnimalTextEdit.Text
            .Dia = DiaDateEdit.Text
            .Hora_Inicio = DiaDateEdit.Text + " " + Hora_InicioTimeEdit.Text
            .Hora_Fim = DiaDateEdit.Text + " " + Hora_FimTimeEdit.Text
            .Status = StatusTextEdit.Text
            .Observacoes = ObservacoesTextEdit.Text
        End With

        If pbNovo Then
            mFLG_Gravou = ClsConsultas.GravaConsultas(mCls)
        Else
            mFLG_Gravou = ClsConsultas.ModificaConsultas(mCls)
        End If


        If mFLG_Gravou Then
            If pbNovo Then
                Me.UC_NAV1.mNovo = False
                mLista = ClsConsultas.GetConsultas
                mNav = New clsNav(mLista.Count)
                mNav.Registo_Atual = mLista.FindIndex(Function(x) x.Cod_Consulta = mCls.Cod_Consulta) + 1
                LoadRegistos()

                '---------------------------
                'upBar.Maximum = mNav.Max_Registos
                'upBar.Value = mNav.Registo_Atual
            Else
                mLista = ClsConsultas.GetConsultas
                mNav = New clsNav(mLista.Count)
                mNav.Registo_Atual = mRegisto_Atual
                LoadRegistos()
            End If
        Else
            MsgBox("Erro na gravaÃ§Ã£o:")
        End If
    End Sub


    Sub Apaga_Registo()
        Try
            ClsConsultas.ApagaConsultas(mLista(mNav.Registo_Atual - 1).Cod_Consulta)
        Catch ex As Exception
            MsgBox("Erro a Apagar o Registo Atual" & vbCrLf & ex.Message)
            Exit Sub
        End Try

        mLista = ClsConsultas.GetConsultas
        mNav = New clsNav(mLista.Count)
        LoadRegistos()
    End Sub

    '---------------------------------------------------------
    '                       Ultra Combos
    '---------------------------------------------------------

    Private Sub cbStatus_Leave(sender As Object, e As EventArgs) Handles cbStatus.Leave
        If cbStatus.Text Is Nothing Then
            If StatusTextEdit.Text <> "" Then
                Exit Sub
            End If
            StatusTextEdit.Text = enStatus.N_Aplicavel
            Exit Sub
        End If
        StatusTextEdit.Text = cbStatus.SelectedItem
    End Sub

    Private Sub ucCodAnimal_AfterCloseUp(sender As Object, e As EventArgs) Handles ucCodAnimal.AfterCloseUp
        If ucCodAnimal.ActiveRow Is Nothing Then
            If CodAnimalTextEdit.Text <> "" Then
                Exit Sub
            End If
            CodAnimalTextEdit.Text = "A0001"
            Exit Sub
        End If
        CodAnimalTextEdit.Text = ucCodAnimal.ActiveRow.Cells("Cod_Animal").Text
        CodTipoAnimalTextEdit.Text = ucCodAnimal.ActiveRow.Cells("Cod_Tipo_Animal").Text
    End Sub

    Private Sub ucCodEntidade_AfterCloseUp(sender As Object, e As EventArgs) Handles ucCodEntidade.AfterCloseUp
        If ucCodEntidade.ActiveRow Is Nothing Then
            If CodEntidadeTextEdit.Text <> "" Then
                Exit Sub
            End If
            CodEntidadeTextEdit.Text = "C0001"
            Exit Sub
        End If
        CodEntidadeTextEdit.Text = ucCodEntidade.ActiveRow.Cells("Cod_Entidade").Text
        mListaAnimais = ClsAnimais.GetAnimaisByEntidade(CodEntidadeTextEdit.Text)
        LoadCombos()
    End Sub

    Private Sub ucCodTipoConsulta_AfterCloseUp(sender As Object, e As EventArgs) Handles ucCodTipoConsulta.AfterCloseUp
        If ucCodTipoConsulta.ActiveRow Is Nothing Then
            If CodTipoConsultaTextEdit.Text <> "" Then
                Exit Sub
            End If
            CodTipoConsultaTextEdit.Text = "TC001"
            Exit Sub
        End If
        CodTipoConsultaTextEdit.Text = ucCodTipoConsulta.ActiveRow.Cells("Cod_Tipo_Consulta").Text
    End Sub

    Private Sub ucCodVeterinario_AfterCloseUp(sender As Object, e As EventArgs) Handles ucCodVeterinario.AfterCloseUp
        If ucCodVeterinario.ActiveRow Is Nothing Then
            If CodVeterinarioTextEdit.Text <> "" Then
                Exit Sub
            End If
            CodVeterinarioTextEdit.Text = "V0001"
            Exit Sub
        End If
        CodVeterinarioTextEdit.Text = ucCodVeterinario.ActiveRow.Cells("Cod_Entidade").Text
    End Sub

    Private Sub ucSalas_AfterCloseUp(sender As Object, e As EventArgs) Handles ucSalas.AfterCloseUp
        If ucSalas.ActiveRow Is Nothing Then
            If CodSalaTextEdit.Text <> "" Then
                Exit Sub
            End If
            CodSalaTextEdit.Text = "S01"
            Exit Sub
        End If
        CodSalaTextEdit.Text = ucSalas.ActiveRow.Cells("Cod_Sala").Text
    End Sub
End Class
