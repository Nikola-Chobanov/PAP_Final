Imports DevExpress.XtraBars.BarItemVisibility
Public Class frmEndereco
    Public Property rCod_Entidade As String
    Public Property rCod_Endereco As String
    Public Property rNovo As Boolean = False

    Dim mClasse As New ClsEnderecos
    Dim mListaPTEnderecos As New List(Of ClsPT_Enderecos)
    Dim mListaLocalidades As New List(Of ClsCP_Localidades)
    Dim mLocalidade As New ClsCP_Localidades
    Dim mListaCodPostais As New List(Of ClsCP_Localidades)
    Private Sub frmEnderecos_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        mListaCodPostais = ClsCP_Localidades.GetCP_Localidades
        If Not rNovo Then
            mClasse = ClsEnderecos.GetEnderecosByCod(rCod_Entidade, rCod_Endereco)
            SetupComps(False)
            SetupBotoes(False)
            LoadRegistos()
            Me.DescritivoTextEdit.Focus()
            Me.bbStatus.Caption = "Estou a modificar um Registo"
        Else
            mListaLocalidades = ClsCP_Localidades.GetLocalidades
            SetupComps(False)
            SetupBotoes(False)
            Me.CodEntidadeTextEdit.Text = rCod_Entidade
            Me.CodEnderecoTextEdit.Text = rCod_Endereco
            Me.DescritivoTextEdit.Focus()
            Me.bbStatus.Caption = "Estou a Criar um Novo Registo"
            DataRegistoDateEdit.DateTime = Date.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")
            DataRegistoDateEdit.Refresh()
        End If

        Load_CodPostal()
        Load_CodPostal()

        If rNovo Then
            ucLocalidades.DataSource = mListaLocalidades
        End If

        cmbDescritivo.Items.Add("Endereço de Faturação")
        cmbDescritivo.Items.Add("Endereço de Envio")
    End Sub

    Sub Load_CodPostal()
        ucCodPostal.DataSource = mListaCodPostais
    End Sub

    Sub SetupBotoes(pBool As Boolean)

        Me.bbNovo.Visibility = If(Not pBool, Never, Always)
        Me.bbModifica.Visibility = If(Not pBool, Never, Always)
        Me.bbApaga.Visibility = If(Not pBool, Never, Always)
        Me.bbSair.Visibility = If(Not pBool, Never, Always)
        Me.bbGrava.Visibility = If(pBool, Never, Always)
        Me.bbCancela.Visibility = If(pBool, Never, Always)

        'If mNovo Then bbStatus.Caption = ""


    End Sub
    Sub LimpaTXT()

        CodEnderecoTextEdit.Text = ""
        DescritivoTextEdit.Text = ""
        EnderecoTextEdit.Text = ""
        CodPostalTextEdit.Text = ""
        LocalidadeTextEdit.Text = ""
        DataRegistoDateEdit.Text = ""
        '-------------------------------
        CodEntidadeTextEdit.Text = ""
    End Sub
    Sub LoadRegistos()
        LimpaTXT()

        With mClasse
            If rNovo Then
                DataRegistoDateEdit.Text = Date.Now.ToString("yyyy-MM-dd")
            Else
                DataRegistoDateEdit.Text = .Data_Registo
            End If

            CodEntidadeTextEdit.Text = .Cod_Entidade
            CodEnderecoTextEdit.Text = .Cod_Endereco

            DescritivoTextEdit.Text = .Descritivo
            EnderecoTextEdit.Text = .Endereco
            CodPostalTextEdit.Text = .Cod_Postal
            LocalidadeTextEdit.Text = .Localidade


        End With
        '-------------------------------
        'upBar.Value = mNav.Registo_Atual
        '-------------------------------



    End Sub


    Sub SetupComps(ByVal pBool As Boolean)

        Me.CodEntidadeTextEdit.ReadOnly = True
        Me.CodEnderecoTextEdit.ReadOnly = True

        DescritivoTextEdit.ReadOnly = pBool
        EnderecoTextEdit.ReadOnly = pBool
        CodPostalTextEdit.ReadOnly = pBool
        LocalidadeTextEdit.ReadOnly = pBool

        DataRegistoDateEdit.ReadOnly = True
        DataRegistoDateEdit.Enabled = False


    End Sub

    Sub Grava(ByVal pbNovo As Boolean)

        '----------------------------------
        'Exemplo de UltraValidate
        '----------------------------------
        'UltraValidator1.Validate()
        '----------------------------------

        Dim mFLG_Gravou As Boolean = False
        Dim mCls As New ClsEnderecos


        With mCls

            .Cod_Entidade = CodEntidadeTextEdit.Text
            .Cod_Endereco = CodEnderecoTextEdit.Text
            '----------------------------------
            'Aqui VERIFICAR Todos os CAMPOS
            '  Não tem por ex. o FLG_Ativo...
            '----------------------------------

            .Descritivo = DescritivoTextEdit.Text
            .Endereco = EnderecoTextEdit.Text
            .Cod_Postal = CodPostalTextEdit.Text
            .Localidade = LocalidadeTextEdit.Text

            .Data_Registo = If(pbNovo, Date.Now, DataRegistoDateEdit.Text)

        End With

        If pbNovo Then
            mFLG_Gravou = ClsEnderecos.GravaEnderecos(mCls)
        Else
            mFLG_Gravou = ClsEnderecos.ModificaEnderecos(mCls)
        End If


        If mFLG_Gravou Then
            rNovo = False
        Else
            MsgBox("Erro na gravação:")
        End If
    End Sub


    Private Sub bbNovo_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbNovo.ItemClick
        SetupComps(False)
        SetupBotoes(False)
    End Sub

    Private Sub bbModifica_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbModifica.ItemClick
        SetupComps(False)
        SetupBotoes(False)
    End Sub

    Private Sub bbGrava_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbGrava.ItemClick
        Grava(rNovo)
        Close()
    End Sub

    Private Sub bbCancela_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbCancela.ItemClick
        Close()
    End Sub

    Private Sub ucLocalidades_AfterCloseUp(sender As Object, e As EventArgs) Handles ucLocalidades.AfterCloseUp
        If ucLocalidades.ActiveRow Is Nothing Then
            If LocalidadeTextEdit.Text <> "" Then
                Exit Sub
            End If
            LocalidadeTextEdit.Text = "Lisboa"
            Exit Sub
        End If
        If CodPostalTextEdit.Text <> "" Then
            Exit Sub
        Else
            LocalidadeTextEdit.Text = ucLocalidades.ActiveRow.Cells("Localidade").Text
            ucCodPostal.DataSource = ClsCP_Localidades.GetCodPostalByLocalidade(LocalidadeTextEdit.Text)
        End If
        '--------------------------------------------------------------------------

    End Sub

    Private Sub cmbDescritivo_TextChanged(sender As Object, e As EventArgs) Handles cmbDescritivo.TextChanged
        If cmbDescritivo.Text Is Nothing Then
            If DescritivoTextEdit.Text <> "" Then
                Exit Sub
            End If
            DescritivoTextEdit.Text = "Endereço de Envio"
            Exit Sub
        End If
        DescritivoTextEdit.Text = cmbDescritivo.Text
    End Sub

    Private Sub ucCodPostal_AfterCloseUp(sender As Object, e As EventArgs) Handles ucCodPostal.AfterCloseUp
        If ucCodPostal.ActiveRow Is Nothing Then
            If CodPostalTextEdit.Text <> "" Then
                Exit Sub
            End If
            CodPostalTextEdit.Text = "7500-000"
            GoTo Localidade
            Exit Sub
        End If
        CodPostalTextEdit.Text = ucCodPostal.ActiveRow.Cells("Cod_Postal").Text
        '---------------------------------------------------------------------------
Localidade:
        mLocalidade = ClsCP_Localidades.GetCP_LocalidadesByCod(CodPostalTextEdit.Text)
        LocalidadeTextEdit.Text = mLocalidade.Localidade
        ucLocalidades.Enabled = False
    End Sub
End Class