'Public Class UC_Consultas


'    ''' <summary>
'    '''      Classe frmConsultas- Form da Tabela de Consultas
'    '''      Gerado em 29/11/2022 14:12:53
'    ''' </summary>
'    ''' <remarks>
'    '''      (c) ETLA - PM-2022
'    ''' </remarks>
'    Dim mLista As New List(Of ClsConsultas)

'    Private Sub UC_Consultas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

'        mLista = ClsConsultas.GetConsultas
'        mNav = New clsNav(mLista.Count)

'        UC_NAV11.mFRM = Me

'        SetupComps(True)
'        UC_NAV11.Load_Status()
'        UC_NAV11.SetupNav()
'        LoadRegistos()

'        Me.Text = "Manutenção da Tabela de Consultas"

'        '-------------------------------
'        'Exemplo de ProgressBar
'        '-------------------------------
'        'upBar.Maximum = mNav.Max_Registos
'        'upBar.Minimum = 1
'        'upBar.Value = mNav.RegistoAtual
'        '-------------------------------


'        '-------------------------------
'        'Exemplo de Combo...
'        '-------------------------------

'        '-----------------
'        'ucPaises
'        '-----------------
'        'ucPaises.DataSource = clsPaises.GetPaises
'        'ucPaises.DisplayMember = "Pais"
'        'ucPaises.ValueMember = "Cod_Pais"


'        '-----------------
'        'ucPaises
'        '-----------------
'        'ucPaises.DataSource = clsPaises.GetPaises
'        'ucPaises.DisplayMember = "Pais"
'        'ucPaises.ValueMember = "Cod_Pais"


'    End Sub


'    Sub SetupComps(ByVal pBool As Boolean)
'        Me.Cod_ConsultaTextEdit.ReadOnly = True
'        If Not pBool Then
'            If Me.UC_NAV11.mNovo Then
'                Me.Cod_ConsultaTextEdit.Focus()
'            Else
'                Me.Cod_Tipo_ConsultaTextEdit.Focus()
'            End If
'        End If
'        Cod_Tipo_ConsultaTextEdit.ReadOnly = pBool
'        Tipo_ConsultaTextEdit.ReadOnly = pBool
'        HorarioDateEdit.ReadOnly = pBool
'        MedicoTextEdit.ReadOnly = pBool
'        Tipo_UtenteTextEdit.ReadOnly = pBool
'        Cod_EntidadeTextEdit.ReadOnly = pBool
'        ObservacoesTextEdit.ReadOnly = pBool
'        AuxiliarTextEdit.ReadOnly = pBool

'        '------------------------------
'        'Exemplo da eventual UltraCmbo 
'        '------------------------------
'        'Me.PaisUltraCombo.ReadOnly = pBool

'    End Sub

'    Sub LoadRegistos()
'        LimpaTXT()
'        If mNav.Registo_Atual > 0 Then
'            With mLista(mNav.Registo_Atual - 1)
'                Cod_Tipo_ConsultaTextEdit.Text = .Cod_Tipo_Consulta
'                Tipo_ConsultaTextEdit.Text = .Tipo_Consulta
'                HorarioDateEdit.Text = .Horario
'                MedicoTextEdit.Text = .Medico
'                Tipo_UtenteTextEdit.Text = .Tipo_Utente
'                Cod_EntidadeTextEdit.Text = .Cod_Entidade
'                ObservacoesTextEdit.Text = .Observacoes
'                AuxiliarTextEdit.Text = .Auxiliar
'                '-------------------------
'                ' Cod_Consulta
'                '-------------------------
'                Cod_ConsultaTextEdit.Text = .Cod_Consulta

'                '-------------------------------
'                'Exemplo para as Combos...
'                '-------------------------------
'                'ucPaises.Text = clsPaises.GetPaisbyCod(.Cod_Pais).Pais
'            End With
'            '-------------------------------
'            'upBar.Value = mNav.Registo_Atual
'            '-------------------------------

'        End If

'    End Sub

'    Sub LimpaTXT()

'        Cod_Tipo_ConsultaTextEdit.Text = ""
'        Tipo_ConsultaTextEdit.Text = ""
'        HorarioDateEdit.Text = ""
'        MedicoTextEdit.Text = ""
'        Tipo_UtenteTextEdit.Text = ""
'        Cod_EntidadeTextEdit.Text = ""
'        ObservacoesTextEdit.Text = ""
'        AuxiliarTextEdit.Text = ""
'        '-------------------------------
'        Cod_ConsultaTextEdit.Text = ""
'    End Sub


'    Sub Grava(ByVal pbNovo As Boolean)

'        '----------------------------------
'        'Exemplo de UltraValidate
'        '----------------------------------
'        'UltraValidator1.Validate()
'        '----------------------------------

'        Dim mFLG_Gravou As Boolean = False
'        Dim mCls As New ClsConsultas
'        Dim mRegisto_Atual As Integer = mNav.Registo_Atual

'        With mCls
'            If pbNovo Then
'                '--------------------------------------
'                'Método Não criado na CLASSE 
'                ' Se for preciso é preciso criá-lo... 
'                '--------------------------------------
'                '.Cod_Consulta = ClsConsultas.GetNovoCodigo
'                '--------------------------------------
'            Else
'                '--------------------------------------
'                ' Se for preciso é preciso criá-lo... 
'                '--------------------------------------
'                .Cod_Consulta = Cod_ConsultaTextEdit.Text
'            End If
'            '----------------------------------
'            'Aqui VERIFICAR Todos os CAMPOS
'            '  Não tem por ex. o FLG_Ativo...
'            '----------------------------------
'            .Cod_Tipo_Consulta = Cod_Tipo_ConsultaTextEdit.Text
'            .Tipo_Consulta = Tipo_ConsultaTextEdit.Text
'            .Horario = HorarioDateEdit.Text
'            .Medico = MedicoTextEdit.Text
'            .Tipo_Utente = Tipo_UtenteTextEdit.Text
'            .Cod_Entidade = Cod_EntidadeTextEdit.Text
'            .Observacoes = ObservacoesTextEdit.Text
'            .Auxiliar = AuxiliarTextEdit.Text
'        End With

'        If pbNovo Then
'            mFLG_Gravou = ClsConsultas.GravaConsultas(mCls)
'        Else
'            mFLG_Gravou = ClsConsultas.ModificaConsultas(mCls)
'        End If


'        If mFLG_Gravou Then
'            If pbNovo Then
'                Me.UC_NAV11.mNovo = False
'                mLista = ClsConsultas.GetConsultas
'                mNav = New clsNav(mLista.Count)
'                mNav.Registo_Atual = mLista.FindIndex(Function(x) x.Cod_Consulta = mCls.Cod_Consulta) + 1
'                LoadRegistos()

'                '---------------------------
'                'upBar.Maximum = mNav.Max_Registos
'                'upBar.Value = mNav.Registo_Atual
'            Else
'                mLista = ClsConsultas.GetConsultas
'                mNav = New clsNav(mLista.Count)
'                mNav.Registo_Atual = mRegisto_Atual
'                LoadRegistos()
'            End If
'        Else
'            MsgBox("Erro na gravação:")
'        End If
'    End Sub


'    Sub Apaga_Registo()
'        Try
'            ClsConsultas.ApagaConsultas(mLista(mNav.Registo_Atual - 1).Cod_Consulta)
'        Catch ex As Exception
'            MsgBox("Erro a Apagar o Registo Atual" & vbCrLf & ex.Message)
'            Exit Sub
'        End Try

'        mLista = ClsConsultas.GetConsultas
'        mNav = New clsNav(mLista.Count)
'        LoadRegistos()
'    End Sub




'End Class
