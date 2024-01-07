Public Class UC_Animais


    ''' <summary>
    '''      Classe frmAnimais- Form da Tabela de Animais
    '''      Gerado em 29/11/2022 14:12:53
    ''' </summary>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>

    Dim mLista As New List(Of ClsAnimais)

    Private Sub frmAnimais_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mLista = ClsAnimais.GetAnimais
        mNav = New clsNav(mLista.Count)

        UC_NAV11.mFRM = Me

        SetupComps(True)
        UC_NAV11.Load_Status()
        UC_NAV11.SetupNav()
        LoadRegistos()

        Me.Text = "Manutenção da Tabela de Animais"

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
        ' A mLista que contém a lista de Animais
        ' pode ser filtrada através do método
        ' FiltrarAnimais com o parâmetro da ClsAnimais
        ' 
        ' É preciso criar uma variável do tipo ClsAnimais
        ' e chamar o método FiltrarAnimais com esse parâmetro:
        '
        '   Dim mclsFiltro as New clsAnimais with {.Cod_Animal=txtCod_Animal.Text, .Nome_Animal=txtNome_Animal.Text}
        '   Dim mListaFiltro = clsAnimais.FiltrarAnimais(mclsFiltro)
        '----------------------------------------------------------------------------------------------

        '-----------------
        'ucPaises
        '-----------------
        'ucPaises.DataSource = clsPaises.GetPaises
        'ucPaises.DisplayMember = "Pais"
        'ucPaises.ValueMember = "Cod_Pais"


    End Sub


    Sub SetupComps(ByVal pBool As Boolean)
        Me.Cod_AnimalTextEdit.ReadOnly = True
        If Not pBool Then
            If Me.UC_NAV11.mNovo Then
                Me.Cod_AnimalTextEdit.Focus()
            Else
                Me.Nome_AnimalTextEdit.Focus()
            End If
        End If
        Nome_AnimalTextEdit.ReadOnly = pBool
        Cod_EntidadeTextEdit.ReadOnly = pBool
        Cod_Tipo_AnimalTextEdit.ReadOnly = pBool
        Imagem_AnimalTextEdit.ReadOnly = pBool

        '------------------------------
        'Exemplo da eventual UltraCmbo 
        '------------------------------
        'Me.PaisUltraCombo.ReadOnly = pBool

    End Sub

    Sub LoadRegistos()
        LimpaTXT()
        If mNav.Registo_Atual > 0 Then
            With mLista(mNav.Registo_Atual - 1)
                Nome_AnimalTextEdit.Text = .Nome_Animal
                Cod_EntidadeTextEdit.Text = .Cod_Entidade
                Cod_Tipo_AnimalTextEdit.Text = .Cod_Tipo_Animal
                Imagem_AnimalTextEdit.Text = .Imagem_Animal
                '-------------------------
                ' Cod_Animal
                '-------------------------
                Cod_AnimalTextEdit.Text = .Cod_Animal

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

        Nome_AnimalTextEdit.Text = ""
        Cod_EntidadeTextEdit.Text = ""
        Cod_Tipo_AnimalTextEdit.Text = ""
        Imagem_AnimalTextEdit.Text = ""
        '-------------------------------
        Cod_AnimalTextEdit.Text = ""
    End Sub


    Sub Grava(ByVal pbNovo As Boolean)

        '----------------------------------
        'Exemplo de UltraValidate
        '----------------------------------
        'UltraValidator1.Validate()
        '----------------------------------

        Dim mFLG_Gravou As Boolean = False
        Dim mCls As New ClsAnimais
        Dim mRegisto_Atual As Integer = mNav.Registo_Atual

        With mCls
            If pbNovo Then
                '--------------------------------------
                'Método Não criado na CLASSE 
                ' Se for preciso é preciso criá-lo... 
                '--------------------------------------
                '.Cod_Animal = ClsAnimais.GetNovoCodigo
                '--------------------------------------
            Else
                '--------------------------------------
                ' Se for preciso é preciso criá-lo... 
                '--------------------------------------
                .Cod_Animal = Cod_AnimalTextEdit.Text
            End If
            '----------------------------------
            'Aqui VERIFICAR Todos os CAMPOS
            '  Não tem por ex. o FLG_Ativo...
            '----------------------------------
            .Nome_Animal = Nome_AnimalTextEdit.Text
            .Cod_Entidade = Cod_EntidadeTextEdit.Text
            .Cod_Tipo_Animal = Cod_Tipo_AnimalTextEdit.Text
            .Imagem_Animal = Imagem_AnimalTextEdit.Text
        End With

        If pbNovo Then
            mFLG_Gravou = ClsAnimais.GravaAnimais(mCls)
        Else
            mFLG_Gravou = ClsAnimais.ModificaAnimais(mCls)
        End If


        If mFLG_Gravou Then
            If pbNovo Then
                Me.UC_NAV11.mNovo = False
                mLista = ClsAnimais.GetAnimais
                mNav = New clsNav(mLista.Count)
                mNav.Registo_Atual = mLista.FindIndex(Function(x) x.Cod_Animal = mCls.Cod_Animal) + 1
                LoadRegistos()

                '---------------------------
                'upBar.Maximum = mNav.Max_Registos
                'upBar.Value = mNav.Registo_Atual
            Else
                mLista = ClsAnimais.GetAnimais
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
            ClsAnimais.ApagaAnimais(mLista(mNav.Registo_Atual - 1).Cod_Animal)
        Catch ex As Exception
            MsgBox("Erro a Apagar o Registo Atual" & vbCrLf & ex.Message)
            Exit Sub
        End Try

        mLista = ClsAnimais.GetAnimais
        mNav = New clsNav(mLista.Count)
        LoadRegistos()
    End Sub


End Class

