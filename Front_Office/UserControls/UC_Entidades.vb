'Public Class UC_Entidades

'    Dim mLista As New List(Of ClsEntidades)

'    Private Sub UC_Entidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load

'        mLista = ClsEntidades.GetEntidades
'        mNav = New clsNav(mLista.Count)

'        UC_NAV11.mFRM = Me

'        SetupComps(True)
'        UC_NAV11.Load_Status()
'        UC_NAV11.SetupNav()
'        LoadRegistos()

'        Me.Text = "Manutenção da Tabela de Entidades"

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

'        '----------------------------------------------------------------------------------------------
'        ' Como se faz um Filtro da Lista de Clientes?
'        ' 
'        ' A mLista que contém a lista de Entidades
'        ' pode ser filtrada através do método
'        ' FiltrarEntidades com o parâmetro da ClsEntidades
'        ' 
'        ' É preciso criar uma variável do tipo ClsEntidades
'        ' e chamar o método FiltrarEntidades com esse parâmetro:
'        '
'        '   Dim mclsFiltro as New clsEntidades with {.Cod_Entidade=txtCod_Entidade.Text, .FLG_Entidade=txtFLG_Entidade.Text}
'        '   Dim mListaFiltro = clsEntidades.FiltrarEntidades(mclsFiltro)
'        '----------------------------------------------------------------------------------------------

'        '-----------------
'        'ucPaises
'        '-----------------
'        'ucPaises.DataSource = clsPaises.GetPaises
'        'ucPaises.DisplayMember = "Pais"
'        'ucPaises.ValueMember = "Cod_Pais"


'    End Sub


'    Sub SetupComps(ByVal pBool As Boolean)
'        Me.Cod_EntidadeTextEdit.ReadOnly = True
'        Me.Data_RegistoDateEdit.ReadOnly = True
'        If Not pBool Then
'            If Me.UC_NAV11.mNovo Then
'                Me.Cod_EntidadeTextEdit.Focus()
'                Me.Cod_EntidadeTextEdit.ReadOnly = True
'            Else
'                Me.FLG_EntidadeTextEdit.Focus()
'            End If
'        End If
'        FLG_EntidadeTextEdit.ReadOnly = pBool
'        NomeTextEdit.ReadOnly = pBool
'        Cod_PaisTextEdit.ReadOnly = pBool
'        Num_TelefoneTextEdit.ReadOnly = pBool
'        Num_TelemovelTextEdit.ReadOnly = pBool
'        EmailTextEdit.ReadOnly = pBool
'        NIFTextEdit.ReadOnly = pBool
'        Data_RegistoDateEdit.ReadOnly = pBool
'        PasswordTextEdit.ReadOnly = pBool
'        UtilizadorTextEdit.ReadOnly = pBool

'        '------------------------------
'        'Exemplo da eventual UltraCmbo 
'        '------------------------------
'        'Me.PaisUltraCombo.ReadOnly = pBool

'    End Sub

'    Sub LoadRegistos()
'        LimpaTXT()
'        If mNav.Registo_Atual > 0 Then
'            With mLista(mNav.Registo_Atual - 1)
'                FLG_EntidadeTextEdit.Text = .FLG_Entidade
'                NomeTextEdit.Text = .Nome
'                Cod_PaisTextEdit.Text = .Cod_Pais
'                Num_TelefoneTextEdit.Text = .Num_Telefone
'                Num_TelemovelTextEdit.Text = .Num_Telemovel
'                EmailTextEdit.Text = .Email
'                NIFTextEdit.Text = .NIF
'                Data_RegistoDateEdit.Text = .Data_Registo
'                PasswordTextEdit.Text = .Password
'                UtilizadorTextEdit.Text = .Utilizador
'                '-------------------------
'                ' Cod_Entidade
'                '-------------------------
'                Cod_EntidadeTextEdit.Text = .Cod_Entidade

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

'        FLG_EntidadeTextEdit.Text = ""
'        NomeTextEdit.Text = ""
'        Cod_PaisTextEdit.Text = ""
'        Num_TelefoneTextEdit.Text = ""
'        Num_TelemovelTextEdit.Text = ""
'        EmailTextEdit.Text = ""
'        NIFTextEdit.Text = ""
'        Data_RegistoDateEdit.Text = ""
'        PasswordTextEdit.Text = ""
'        UtilizadorTextEdit.Text = ""
'        '-------------------------------
'        Cod_EntidadeTextEdit.Text = ""
'    End Sub


'    Sub Grava(ByVal pbNovo As Boolean)

'        '----------------------------------
'        'Exemplo de UltraValidate
'        '----------------------------------
'        'UltraValidator1.Validate()
'        '----------------------------------

'        Dim mFLG_Gravou As Boolean = False
'        Dim mCls As New ClsEntidades
'        Dim mRegisto_Atual As Integer = mNav.Registo_Atual



'        With mCls
'            If pbNovo Then
'                '--------------------------------------
'                'Método Não criado na CLASSE 
'                ' Se for preciso é preciso criá-lo... 
'                '--------------------------------------
'                '.Cod_Entidade = ClsEntidades.GetNovoCodigo
'                '--------------------------------------
'            Else
'                '--------------------------------------
'                ' Se for preciso é preciso criá-lo... 
'                '--------------------------------------
'                .Cod_Entidade = ClsEntidades.GetNovoCodigo()
'            End If

'            '----------------------------------
'            'Aqui VERIFICAR Todos os CAMPOS
'            '  Não tem por ex. o FLG_Ativo...
'            '----------------------------------
'            .FLG_Entidade = "E" 'FLG_EntidadeTextEdit.Text
'            .Nome = NomeTextEdit.Text
'            .Cod_Pais = Cod_PaisTextEdit.Text
'            .Num_Telefone = Num_TelefoneTextEdit.Text
'            .Num_Telemovel = Num_TelemovelTextEdit.Text
'            .Email = EmailTextEdit.Text
'            .NIF = NIFTextEdit.Text
'            .Data_Registo = Date.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")
'            .Password = PasswordTextEdit.Text
'            '.Utilizador = UtilizadorTextEdit.Text
'        End With

'        If pbNovo Then
'            mFLG_Gravou = ClsEntidades.GravaEntidades(mCls)
'        Else
'            mFLG_Gravou = ClsEntidades.ModificaEntidades(mCls)
'        End If


'        If mFLG_Gravou Then
'            If pbNovo Then
'                Me.UC_NAV11.mNovo = False
'                mLista = ClsEntidades.GetEntidades
'                mNav = New clsNav(mLista.Count)
'                mNav.Registo_Atual = mLista.FindIndex(Function(x) x.Cod_Entidade = mCls.Cod_Entidade) + 1
'                LoadRegistos()

'                '---------------------------
'                'upBar.Maximum = mNav.Max_Registos
'                'upBar.Value = mNav.Registo_Atual
'            Else
'                mLista = ClsEntidades.GetEntidades
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
'            ClsEntidades.ApagaEntidades(mLista(mNav.Registo_Atual - 1).Cod_Entidade)
'        Catch ex As Exception
'            MsgBox("Erro a Apagar o Registo Atual" & vbCrLf & ex.Message)
'            Exit Sub
'        End Try

'        mLista = ClsEntidades.GetEntidades
'        mNav = New clsNav(mLista.Count)
'        LoadRegistos()
'    End Sub


'End Class
