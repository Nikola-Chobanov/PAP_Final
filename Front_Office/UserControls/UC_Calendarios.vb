Imports System.Data.SqlClient
''' <summary>
'''      Classe frmCalendarios- Form da Tabela de Calendarios
'''      Gerado em 29/11/2022 14:12:53
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2022
''' </remarks>
Public Class UC_Calendarios

    Dim mLista As New List(Of ClsCalendarios)



    Sub SetupAgendas() Handles MyBase.Load
        With SCAgendas
            .Start = Date.Now
            .ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.FullWeek
            .DayView.ShowWorkTimeOnly = True
            .WorkWeekView.ShowWorkTimeOnly = True
            .FullWeekView.ShowWorkTimeOnly = True
        End With
        SchedulerDataStorage1.RefreshData()
    End Sub


    'Private Sub UC_Calendarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    '    mLista = ClsCalendarios.GetCalendarios
    '    mNav = New clsNav(mLista.Count)

    '    UC_NAV11.mFRM = Me

    '    SetupComps(True)
    '    UC_NAV11.Load_Status()
    '    UC_NAV11.SetupNav()
    '    LoadRegistos()

    '    Me.Text = "Manutenção da Tabela de Calendarios"

    '    '-------------------------------
    '    'Exemplo de ProgressBar
    '    '-------------------------------
    '    'upBar.Maximum = mNav.Max_Registos
    '    'upBar.Minimum = 1
    '    'upBar.Value = mNav.RegistoAtual
    '    '-------------------------------


    '    '-------------------------------
    '    'Exemplo de Combo...
    '    '-------------------------------

    '    '-----------------
    '    'ucPaises
    '    '-----------------
    '    'ucPaises.DataSource = clsPaises.GetPaises
    '    'ucPaises.DisplayMember = "Pais"
    '    'ucPaises.ValueMember = "Cod_Pais"

    '    '----------------------------------------------------------------------------------------------
    '    ' Como se faz um Filtro da Lista de Clientes?
    '    ' 
    '    ' A mLista que contém a lista de Calendarios
    '    ' pode ser filtrada através do método
    '    ' FiltrarCalendarios com o parâmetro da ClsCalendarios
    '    ' 
    '    ' É preciso criar uma variável do tipo ClsCalendarios
    '    ' e chamar o método FiltrarCalendarios com esse parâmetro:
    '    '
    '    '   Dim mclsFiltro as New clsCalendarios with {.Cod_Calendario=txtCod_Calendario.Text, .Designacao=txtDesignacao.Text}
    '    '   Dim mListaFiltro = clsCalendarios.FiltrarCalendarios(mclsFiltro)
    '    '----------------------------------------------------------------------------------------------

    '    '-----------------
    '    'ucPaises
    '    '-----------------
    '    'ucPaises.DataSource = clsPaises.GetPaises
    '    'ucPaises.DisplayMember = "Pais"
    '    'ucPaises.ValueMember = "Cod_Pais"


    'End Sub


    'Sub SetupComps(ByVal pBool As Boolean)
    '    Me.Cod_CalendarioTextEdit.ReadOnly = True
    '    If Not pBool Then
    '        If Me.UC_NAV11.mNovo Then
    '            Me.Cod_CalendarioTextEdit.Focus()
    '        Else
    '            Me.DesignacaoTextEdit.Focus()
    '        End If
    '    End If
    '    DesignacaoTextEdit.ReadOnly = pBool
    '    AnoTextEdit.ReadOnly = pBool

    '    '------------------------------
    '    'Exemplo da eventual UltraCmbo 
    '    '------------------------------
    '    'Me.PaisUltraCombo.ReadOnly = pBool

    'End Sub

    'Sub LoadRegistos()
    '    LimpaTXT()
    '    If mNav.Registo_Atual > 0 Then
    '        With mLista(mNav.Registo_Atual - 1)
    '            DesignacaoTextEdit.Text = .Designacao
    '            AnoTextEdit.Text = .Ano
    '            '-------------------------
    '            ' Cod_Calendario
    '            '-------------------------
    '            Cod_CalendarioTextEdit.Text = .Cod_Calendario

    '            '-------------------------------
    '            'Exemplo para as Combos...
    '            '-------------------------------
    '            'ucPaises.Text = clsPaises.GetPaisbyCod(.Cod_Pais).Pais
    '        End With
    '        '-------------------------------
    '        'upBar.Value = mNav.Registo_Atual
    '        '-------------------------------

    '    End If

    'End Sub

    'Sub LimpaTXT()

    '    DesignacaoTextEdit.Text = ""
    '    AnoTextEdit.Text = ""
    '    '-------------------------------
    '    Cod_CalendarioTextEdit.Text = ""
    'End Sub


    'Sub Grava(ByVal pbNovo As Boolean)

    '    '----------------------------------
    '    'Exemplo de UltraValidate
    '    '----------------------------------
    '    'UltraValidator1.Validate()
    '    '----------------------------------

    '    Dim mFLG_Gravou As Boolean = False
    '    Dim mCls As New ClsCalendarios
    '    Dim mRegisto_Atual As Integer = mNav.Registo_Atual

    '    With mCls
    '        If pbNovo Then
    '            '--------------------------------------
    '            'Método Não criado na CLASSE 
    '            ' Se for preciso é preciso criá-lo... 
    '            '--------------------------------------
    '            '.Cod_Calendario = ClsCalendarios.GetNovoCodigo
    '            '--------------------------------------
    '        Else
    '            '--------------------------------------
    '            ' Se for preciso é preciso criá-lo... 
    '            '--------------------------------------
    '            .Cod_Calendario = Cod_CalendarioTextEdit.Text
    '        End If
    '        '----------------------------------
    '        'Aqui VERIFICAR Todos os CAMPOS
    '        '  Não tem por ex. o FLG_Ativo...
    '        '----------------------------------
    '        .Designacao = DesignacaoTextEdit.Text
    '        .Ano = AnoTextEdit.Text
    '    End With

    '    If pbNovo Then
    '        mFLG_Gravou = ClsCalendarios.GravaCalendarios(mCls)
    '    Else
    '        mFLG_Gravou = ClsCalendarios.ModificaCalendarios(mCls)
    '    End If


    '    If mFLG_Gravou Then
    '        If pbNovo Then
    '            Me.UC_NAV11.mNovo = False
    '            mLista = ClsCalendarios.GetCalendarios
    '            mNav = New clsNav(mLista.Count)
    '            mNav.Registo_Atual = mLista.FindIndex(Function(x) x.Cod_Calendario = mCls.Cod_Calendario) + 1
    '            LoadRegistos()

    '            '---------------------------
    '            'upBar.Maximum = mNav.Max_Registos
    '            'upBar.Value = mNav.Registo_Atual
    '        Else
    '            mLista = ClsCalendarios.GetCalendarios
    '            mNav = New clsNav(mLista.Count)
    '            mNav.Registo_Atual = mRegisto_Atual
    '            LoadRegistos()
    '        End If
    '    Else
    '        MsgBox("Erro na gravação:")
    '    End If
    'End Sub


    'Sub Apaga_Registo()
    '    Try
    '        ClsCalendarios.ApagaCalendarios(mLista(mNav.Registo_Atual - 1).Cod_Calendario)
    '    Catch ex As Exception
    '        MsgBox("Erro a Apagar o Registo Atual" & vbCrLf & ex.Message)
    '        Exit Sub
    '    End Try

    '    mLista = ClsCalendarios.GetCalendarios
    '    mNav = New clsNav(mLista.Count)
    '    LoadRegistos()
    'End Sub


End Class
