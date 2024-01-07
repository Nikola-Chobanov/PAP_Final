Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Drawing.Text
Imports System.IO
Public Class UC_Entidades
    Public Shared Property Filtrado As Boolean

    Dim mListaFiltro As New List(Of ClsEntidades)
    Dim mLista As New List(Of ClsEntidades)
    Dim mListaCodPais As New List(Of ClsPaises)
    Dim mListaEntidades As New List(Of ClsEntidades)
    Dim mListaEnderecos As New List(Of ClsEnderecos)
    Dim maEntidades As New ArrayList
    Dim maFiltro As New ArrayList
    Dim mListaAnimais As New List(Of ClsAnimais)
    Dim mfrm As frmEndereco

    Dim mPathEntidade As String = Application.StartupPath + "\..\..\Resources\Images\Entidades\"
    Friend mUC As UserControl

    Private Sub UC_Entidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mLista = ClsEntidades.GetEntidades
        mNav = New clsNav(mLista.Count)
        UC_NAV11.mFRM = Me

        SetupComps(True)
        UC_NAV11.Load_Status()
        UC_NAV11.SetupNav()
        LoadRegistos()

        Me.Text = "Manutenção da Tabela de Entidades"


        maEntidades.Add("Cliente")
        maEntidades.Add("Funcionario")
        maEntidades.Add("Veterinario")

        maFiltro.Add("Cliente")
        maFiltro.Add("Funcionario")
        maFiltro.Add("Veterinario")


        cbFLG_Entidade.DataSource = maEntidades
        cbFLG_Entidade.SelectedIndex = 0

        cmbFiltro.DataSource = maFiltro
        cmbFiltro.SelectedIndex = 0
        ucPais.DataSource = ClsPaises.GetPaises
        ucPais.DisplayMember = "Pais"
        ucPais.ValueMember = "Cod_Pais"

        RoundImage()
    End Sub


    Sub SetupComps(ByVal pBool As Boolean)
        Me.CodEntidadeTextEdit.ReadOnly = True
        Me.Data_RegistoDateEdit.ReadOnly = True
        cbFLG_Entidade.Enabled = Me.UC_NAV11.mNovo
        If Not pBool Then
            If Me.UC_NAV11.mNovo Then
                Me.ucPaises.Focus()

                cbFLG_Entidade.SelectedIndex = 0
            Else

                Me.FLGEntidadeTextEdit.Focus()
            End If
        End If
        FLGEntidadeTextEdit.ReadOnly = pBool
        FLGEntidadeTextEdit.Enabled = Not pBool
        NomeTextEdit.ReadOnly = pBool
        NomeTextEdit.Enabled = Not pBool
        CodPaisTextEdit.ReadOnly = pBool
        CodPaisTextEdit.Enabled = Not pBool
        NumTelefoneTextEdit.ReadOnly = pBool
        NumTelefoneTextEdit.Enabled = Not pBool
        NumTelemovelTextEdit.ReadOnly = pBool
        NumTelemovelTextEdit.Enabled = Not pBool
        EmailTextEdit.ReadOnly = pBool
        EmailTextEdit.Enabled = Not pBool
        NIFTextEdit.ReadOnly = pBool
        NIFTextEdit.Enabled = Not pBool
        Data_RegistoDateEdit.ReadOnly = pBool
        Data_RegistoDateEdit.Enabled = Not pBool
        PasswordTextEdit.ReadOnly = pBool
        PasswordTextEdit.Enabled = Not pBool
        cmbFiltro.Enabled = pBool
        cdFiltro.Enabled = pBool
        cbFLG_Entidade.Visible = Not pBool
        ucPais.Visible = Not pBool
        picCarregarImagem.Visible = Not pBool
        picApagarImagem.Visible = Not pBool
        ucPais.ReadOnly = pBool
        ugEnderecos.Enabled = Not pBool
        ugAnimais.Enabled = Not pBool
        If UC_NAV11.mNovo Then
            cbFLG_Entidade.Enabled = True
        End If
    End Sub


    Function GetIndexCMB(pCod As String) As Integer
        Dim mReturn As Integer = 0

        Dim n As Integer = 0

        For n = 0 To (cbFLG_Entidade.Items.Count - 1)
            If pCod.ToUpper = (cbFLG_Entidade.Items(n).ToString).ToUpper.Substring(0, 1) Then
                Exit For
            End If
        Next
        mReturn = n

        Return mReturn
    End Function

    Sub LoadRegistos()
        LimpaTXT()
        If mNav.Registo_Atual > 0 Then
            With mLista(mNav.Registo_Atual - 1)
                FLGEntidadeTextEdit.Text = .FLG_Entidade
                NomeTextEdit.Text = .Nome
                CodPaisTextEdit.Text = .Cod_Pais
                NumTelefoneTextEdit.Text = .Num_Telefone
                NumTelemovelTextEdit.Text = .Num_Telemovel
                EmailTextEdit.Text = .Email
                NIFTextEdit.Text = .NIF
                Data_RegistoDateEdit.Text = .Data_Registo
                PasswordTextEdit.Text = .Password
                CodEntidadeTextEdit.Text = .Cod_Entidade
                '-------------------------------------------------------------------

Cont:
                If .Fotografia = "" Then
                    picEntidade.Image = Image.FromFile(mPathEntidade + "Default.png")
                Else
                    Try
                        picEntidade.Image = Image.FromFile(mPathEntidade + .Fotografia)
                    Catch ex As Exception
                        .Fotografia = ""
                        GoTo Cont
                    End Try
                End If

                FotografiaTextEdit.Text = .Fotografia
                '-------------------------------------------------------------------
                Dim mListaEnderecos As New List(Of ClsEnderecos)
                mListaEnderecos = .Lista_Enderecos.FindAll(Function(x) x.FLG_Ativo = True)

                ugEnderecos.DataSource = mListaEnderecos
                ugEnderecos.Refresh()
                Dim mListaAnimais As New List(Of ClsAnimais)
                mListaAnimais = .Lista_Animais.FindAll(Function(x) x.FLG_Ativo = True)

                ugAnimais.DataSource = mListaAnimais
                ugAnimais.Refresh()

                NumTelemovelTextEdit.Text = .Num_Telemovel
                '-------------------------------------------------------------------

                Dim mIndex As Integer = GetIndexCMB(.FLG_Entidade)

                mIndex = If(mIndex <= maEntidades.Count - 1, mIndex, mIndex - 1)
                cbFLG_Entidade.SelectedIndex = mIndex


                Dim mIndex_Entidades As Integer

                mIndex_Entidades = mListaEntidades.FindIndex(Function(x) x.FLG_Entidade = .FLG_Entidade)
                mIndex_Entidades = If(mIndex_Entidades <= mListaEntidades.Count - 1, mIndex_Entidades, -1)
            End With
        End If

    End Sub

    Sub LimpaTXT()

        FLGEntidadeTextEdit.Text = ""
        NomeTextEdit.Text = ""
        CodPaisTextEdit.Text = ""
        NumTelefoneTextEdit.Text = ""
        NumTelemovelTextEdit.Text = ""
        EmailTextEdit.Text = ""
        NIFTextEdit.Text = ""
        Data_RegistoDateEdit.Text = ""
        PasswordTextEdit.Text = ""
        CodEntidadeTextEdit.Text = ""


        ucPais.Text = Nothing
        If UC_NAV11.mNovo Then
            ugEnderecos.Enabled = False
        End If
    End Sub


    Sub Grava(ByVal pbNovo As Boolean)

        '----------------------------------
        'Exemplo de UltraValidate
        '----------------------------------
        'UltraValidator1.Validate()
        '----------------------------------

        Dim mFLG_Gravou As Boolean = False
        Dim mCls As New ClsEntidades
        Dim mClsEndereco As New ClsEnderecos
        Dim mRegisto_Atual As Integer = mNav.Registo_Atual
        Dim mNovaEntidade As String = ClsEntidades.GetNovoCodigo(FLGEntidadeTextEdit.Text)
        Dim enFLG_Entidade As enCont
        Dim mDataAtual = Date.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")

        With mCls
            If pbNovo Then
                .Cod_Entidade = mNovaEntidade
                .Data_Registo = Date.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")
                Me.Data_RegistoDateEdit.ReadOnly = True
                Me.Data_RegistoDateEdit.Text = Date.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")
                If FotografiaTextEdit.Text = "" Then
                    FotografiaTextEdit.Text = "Default.png"
                End If
            Else
                .Cod_Entidade = CodEntidadeTextEdit.Text
                .Data_Registo = Data_RegistoDateEdit.Text
            End If
            .FLG_Entidade = FLGEntidadeTextEdit.Text
            .Nome = NomeTextEdit.Text
            .Cod_Pais = CodPaisTextEdit.Text
            .Num_Telefone = NumTelefoneTextEdit.Text
            .Num_Telemovel = NumTelemovelTextEdit.Text
            .Email = EmailTextEdit.Text
            .NIF = NIFTextEdit.Text
            .Password = PasswordTextEdit.Text
            .Fotografia = FotografiaTextEdit.Text
        End With

        If pbNovo Then
            mFLG_Gravou = ClsEntidades.GravaEntidades(mCls)
            enFLG_Entidade = GetFLG_Entidade(FLGEntidadeTextEdit.Text)
            ClsEmpresas.GravaContador(enFLG_Entidade)
        Else
            mFLG_Gravou = ClsEntidades.ModificaEntidades(mCls)
        End If


        If mFLG_Gravou Then
            If pbNovo Then
                Me.UC_NAV11.mNovo = False
                mLista = ClsEntidades.GetEntidades
                mNav = New clsNav(mLista.Count)
                mNav.Registo_Atual = mLista.FindIndex(Function(x) x.Cod_Entidade = mCls.Cod_Entidade) + 1
                LoadRegistos()
            Else
                mLista = ClsEntidades.GetEntidades
                mNav = New clsNav(mLista.Count)
                mNav.Registo_Atual = mRegisto_Atual
                LoadRegistos()
            End If
        Else
            MsgBox("Erro na gravação:")
        End If
        mNovaEntidade = Nothing
    End Sub


    Sub Apaga_Registo()
        Try
            ClsEntidades.ApagaEntidades(mLista(mNav.Registo_Atual - 1).Cod_Entidade)
        Catch ex As Exception
            MsgBox("Erro a Apagar o Registo Atual" & vbCrLf & ex.Message)
            Exit Sub
        End Try

        mLista = ClsEntidades.GetEntidades
        mNav = New clsNav(mLista.Count)
        LoadRegistos()
    End Sub

    Private Sub cbFLG_Entidade_Click(sender As Object, e As EventArgs) Handles cbFLG_Entidade.TextChanged, cbFLG_Entidade.Leave
        If cbFLG_Entidade.Text Is Nothing Then
            If FLGEntidadeTextEdit.Text <> "" Then
                Exit Sub
            End If
            FLGEntidadeTextEdit.Text = "C"
            Exit Sub
        End If
        FLGEntidadeTextEdit.Text = cbFLG_Entidade.Text.Substring(0, 1)
        If Me.UC_NAV11.mNovo = True Then
            CodEntidadeTextEdit.Text = ClsEntidades.GetNovoCodigo(FLGEntidadeTextEdit.Text)

        End If
    End Sub

    Private Sub ucPais_AfterCloseUp(sender As Object, e As EventArgs) Handles ucPais.AfterCloseUp, ucPais.Leave
        If ucPais.ActiveRow Is Nothing Then
            If CodPaisTextEdit.Text <> "" Then
                Exit Sub
            End If
            CodPaisTextEdit.Text = "PT"
            Exit Sub
        End If
        Try
            Me.CodPaisTextEdit.Text = ucPais.ActiveRow.Cells("Cod_Pais").Text
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function GetFLG_Entidade(pFLG_Entidade As String) As enCont
        Dim mReturn As enCont

        Select Case pFLG_Entidade
            Case "C"
                mReturn = enCont.Clientes
            Case "F"
                mReturn = enCont.Funcionarios
            Case "V"
                mReturn = enCont.Veterinarios
        End Select

        Return mReturn
    End Function

    Private Sub picCarregarImagem_Click(sender As Object, e As EventArgs) Handles picCarregarImagem.Click
        ofdEntidade.Filter = " JPG |*.jpg| PNG | *.png| Todos os Ficheiros| *.*"
        If ofdEntidade.ShowDialog = DialogResult.OK Then

            Dim mCont As Integer = 0
            Dim mFileName As String = ofdEntidade.SafeFileName.ToString
            Dim mLen As Integer = Len(mFileName)
            Dim mExt As String = mFileName.Substring(mLen - 4, 4)

            Dim mFileDestino As String = mPathEntidade + CodEntidadeTextEdit.Text + mExt
            Me.picEntidade.Text = CodEntidadeTextEdit.Text + mExt
            Me.FotografiaTextEdit.Text = CodEntidadeTextEdit.Text + mExt

Cont:
            Try
                File.Copy(ofdEntidade.FileName, mFileDestino, True)
            Catch ex As Exception
                If File.Exists(mFileDestino) Then
                    mCont += 1
                    mFileDestino = mPathEntidade + CodEntidadeTextEdit.Text + mCont.ToString("000") + mExt
                    Me.CodEntidadeTextEdit.Text = CodEntidadeTextEdit.Text + mCont.ToString("000") + mExt
                    GoTo Cont
                End If

            End Try

            Me.picEntidade.Image = Image.FromFile(mFileDestino)

            If mCont > 0 Then
                Me.picEntidade.Image.Tag = CodEntidadeTextEdit.Text + mCont.ToString("000") + mExt
            Else
                Me.picEntidade.Image.Tag = CodEntidadeTextEdit.Text + mExt
            End If

        End If
    End Sub

    Private Sub cdFiltro_CheckStateChanged(sender As Object, e As EventArgs) Handles cdFiltro.CheckStateChanged
        Dim mFLG As String = cmbFiltro.Text.Substring(0, 1)
        Dim mListaFiltro = ClsEntidades.GetEntidadesByFLG(mFLG)
        Dim mCls As New List(Of ClsEntidades)

        mCls = mListaFiltro

        If cdFiltro.Checked Then
            Me.mLista = FiltraEntidades(mFLG)
            mNav = New clsNav(mLista.Count)
            UC_NAV11.mFRM = Me

            SetupComps(True)
            UC_NAV11.Load_Status()
            UC_NAV11.SetupNav()
            LoadRegistos()
        Else
            Me.mLista = ClsEntidades.GetEntidades
            mNav = New clsNav(mLista.Count)
            UC_NAV11.mFRM = Me

            SetupComps(True)
            UC_NAV11.Load_Status()
            UC_NAV11.SetupNav()
            LoadRegistos()
        End If
    End Sub

    Friend Shared Function FiltraEntidades(ByVal pFLG As String)
        Dim mListaEntidades As New List(Of ClsEntidades)
        Dim mLista As New List(Of ClsEntidades)

        mListaEntidades = ClsEntidades.GetEntidades()

        mLista = mListaEntidades.FindAll(Function(x) x.FLG_Entidade.Contains(pFLG))
        '-----------------------------------------------------
        'Pode Colocar em cima mais colunas como esta abaixo...
        '-----------------------------------------------------
        ' AND x.FLG_Entidade.Contains(pFiltro.FLG_Entidade) 

        Return mLista
    End Function


    Private Sub ugEnderecos_Click(sender As Object, e As EventArgs) Handles ugEnderecos.DoubleClick
        Dim mFrm As New frmEndereco

        mFrm.rCod_Entidade = mLista(mNav.Registo_Atual - 1).Cod_Entidade

        If Not ugEnderecos.ActiveRow.Cells("Descritivo").Text = "" Then
            mFrm.rCod_Endereco = ugEnderecos.ActiveRow.Cells("Cod_Endereco").Text
        Else
            mFrm.rNovo = True
            Dim mContador As Integer = (mLista(mNav.Registo_Atual - 1).Contador_Enderecos + 1)

            mFrm.rCod_Endereco = "E" & mContador.ToString("00")
        End If

        mFrm.ShowDialog()
        LoadRegistos()
    End Sub

    Private Sub cmEndereco_Opened(sender As Object, e As EventArgs) Handles cmEndereco.Opened
        Dim mBool As Boolean = ugEnderecos.ActiveRow.Cells("Descritivo").Text = ""

        tsRemover.Enabled = Not mBool
        tsModificar.Enabled = Not mBool
        tsAdicionar.Enabled = mBool
    End Sub

    Private Sub tsAdicionar_Click(sender As Object, e As EventArgs) Handles tsAdicionar.Click
        mfrm = New frmEndereco
        mfrm.rCod_Entidade = mLista(mNav.Registo_Atual - 1).Cod_Entidade
        mfrm.rNovo = True


        Dim mContador As Integer = (mLista(mNav.Registo_Atual - 1).Contador_Enderecos + 1)

        mfrm.rCod_Endereco = "E" & mContador.ToString("00")

        mfrm.ShowDialog()
        LoadRegistos()
    End Sub

    Sub AskRemover()
        Dim mResult As MsgBoxResult

        mResult = MsgBox("Tem a certeza que quer apagar a Linha?", MsgBoxStyle.YesNo)

        If mResult = MsgBoxResult.Yes Then
            Remover_Endereco()
        End If
    End Sub
    Sub Remover_Endereco()
        Dim mCod_Entidade As String = mLista(mNav.Registo_Atual - 1).Cod_Entidade
        Dim mCod_Endereco As String = ugEnderecos.ActiveRow.Cells("Cod_Endereco").Text

        Try
            ClsEnderecos.ApagaEnderecos(mCod_Entidade, mCod_Endereco)
        Catch ex As Exception
            MsgBox("Alguma coisa correu mal..." & vbCrLf & ex.ToString)
        End Try
        LoadRegistos()
    End Sub

    Private Sub tsRemover_Click(sender As Object, e As EventArgs) Handles tsRemover.Click
        AskRemover()
    End Sub

    Private Sub tsModificar_Click(sender As Object, e As EventArgs) Handles tsModificar.Click
        Dim mFrm As New frmEndereco

        mFrm.rCod_Entidade = mLista(mNav.Registo_Atual - 1).Cod_Entidade
        mFrm.rCod_Endereco = ugEnderecos.ActiveRow.Cells("Cod_Endereco").Text

        mFrm.ShowDialog()
        LoadRegistos()
    End Sub

    Private Sub picApagarImagem_Click(sender As Object, e As EventArgs) Handles picApagarImagem.Click
        If FotografiaTextEdit.Text <> "" Then
            If MsgBox("Quer apagar a imagem?", vbYesNo, "Imagem Entidade") = vbNo Then
                Exit Sub
            ElseIf vbYes Then
                picEntidade.Image = Image.FromFile(mPathEntidade + "Default.png")
                FotografiaTextEdit.Text = "Default.png"
            End If
        End If
    End Sub

    Sub RoundImage()
        Dim path As New System.Drawing.Drawing2D.GraphicsPath()
        Dim mCornerRadius As Integer = 50
        Dim mRectangle As Rectangle = New Rectangle(0, 0, picEntidade.Width, picEntidade.Height)
        Dim mArcRectangle As Rectangle = New Rectangle(mRectangle.Left, mRectangle.Top, mCornerRadius, mCornerRadius)
        path.AddArc(mArcRectangle, 180, 90)

        mArcRectangle.X = mRectangle.Right - mCornerRadius
        path.AddArc(mArcRectangle, 270, 90)
        mArcRectangle.Y = mRectangle.Bottom - mCornerRadius
        path.AddArc(mArcRectangle, 0, 90)
        mArcRectangle.X = mRectangle.Left
        path.AddArc(mArcRectangle, 90, 90)
        path.CloseFigure()

        picEntidade.Region = New Region(path)
    End Sub

    Private Sub picCarregarImagem_MouseMove(sender As Object, e As MouseEventArgs) Handles picCarregarImagem.MouseMove
        picCarregarImagem.Image = My.Resources.CarregarImagemShade2
    End Sub

    Private Sub picCarregarImagem_MouseLeave(sender As Object, e As EventArgs) Handles picCarregarImagem.MouseLeave
        picCarregarImagem.Image = My.Resources.CarregarImagem
    End Sub

    Private Sub picApagarImagem_MouseHover(sender As Object, e As MouseEventArgs) Handles picApagarImagem.MouseMove
        picApagarImagem.Image = My.Resources.ApagarImagemShade2
    End Sub

    Private Sub picApagarImagem_MouseLeave(sender As Object, e As EventArgs) Handles picApagarImagem.MouseLeave
        picApagarImagem.Image = My.Resources.ApagarImagem
    End Sub

End Class