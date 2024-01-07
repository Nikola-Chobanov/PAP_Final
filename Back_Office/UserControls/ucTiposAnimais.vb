Imports System.IO
''' <summary>
'''      Classe frmTipos_Animais- Form da Tabela de Tipos_Animais
'''      Gerado em 03/03/2023 15:49:35
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2023
''' </remarks>
Public Class ucTiposAnimais



    Dim mLista As New List(Of ClsTiposAnimais)
    Dim mPathTiposAnimais As String = Application.StartupPath + "\..\..\Resources\Images\TiposAnimais\"
    Private Sub frmTipos_Animais_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mLista = ClsTiposAnimais.GetTipos_Animais
        mNav = New clsNav(mLista.Count)

        UC_NAV1.mFRM = Me

        SetupComps(True)
        UC_NAV1.Load_Status()
        UC_NAV1.SetupNav()
        LoadRegistos()

        Me.Text = "Manutenção da Tabela de Tipos_Animais"

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
        ' A mLista que contém a lista de Tipos_Animais
        ' pode ser filtrada através do método
        ' FiltrarTipos_Animais com o parâmetro da ClsTipos_Animais
        ' 
        ' É preciso criar uma variável do tipo ClsTipos_Animais
        ' e chamar o método FiltrarTipos_Animais com esse parâmetro:
        '
        '   Dim mclsFiltro as New clsTipos_Animais with {.Cod_Tipo_Animal=txtCod_Tipo_Animal.Text, .Animal=txtAnimal.Text}
        '   Dim mListaFiltro = clsTipos_Animais.FiltrarTipos_Animais(mclsFiltro)
        '----------------------------------------------------------------------------------------------

        '-----------------
        'ucPaises
        '-----------------
        'ucPaises.DataSource = clsPaises.GetPaises
        'ucPaises.DisplayMember = "Pais"
        'ucPaises.ValueMember = "Cod_Pais"

        RoundImage()
    End Sub


    Sub SetupComps(ByVal pBool As Boolean)
        Me.CodTipoAnimalTextEdit.ReadOnly = True
        If Not pBool Then
            If Me.UC_NAV1.mNovo Then
                Me.CodTipoAnimalTextEdit.Focus()
            Else
                Me.AnimalTextedit.Focus()
            End If
        End If
        CodTipoAnimalTextEdit.Enabled = Not pBool
        AnimalTextedit.ReadOnly = pBool
        AnimalTextedit.Enabled = Not pBool
        picCarregarImagem.Visible = Not pBool
        picApagarImagem.Visible = Not pBool

        '------------------------------
        'Exemplo da eventual UltraCmbo 
        '------------------------------
        'Me.PaisUltraCombo.ReadOnly = pBool

    End Sub

    Sub LoadRegistos()
        LimpaTXT()
        If mNav.Registo_Atual > 0 Then
            With mLista(mNav.Registo_Atual - 1)
                AnimalTextedit.Text = .Animal
                CodTipoAnimalTextEdit.Text = .Cod_Tipo_Animal
Cont:
                If .Imagem = "" Then
                    picTipoAnimal.Image = Image.FromFile(mPathTiposAnimais + "Default.png")
                Else
                    Try
                        picTipoAnimal.Image = Image.FromFile(mPathTiposAnimais + .Imagem)
                    Catch ex As Exception
                        .Imagem = ""
                        GoTo Cont
                    End Try
                End If
                ImagemTextEdit.Text = .Imagem
            End With
        End If
    End Sub

    Sub LimpaTXT()

        AnimalTextedit.Text = ""
        If UC_NAV1.mNovo Then
            ImagemTextEdit.Text = ""
        Else
            ImagemTextEdit.Text = "Default.png"
        End If
        ImagemTextEdit.Text = ""
        CodTipoAnimalTextEdit.Text = ""
        picTipoAnimal.Image = Nothing
        If UC_NAV1.mNovo Then
            CodTipoAnimalTextEdit.Text = ClsTiposAnimais.GetNovoCodigo
        End If
    End Sub


    Sub Grava(ByVal pbNovo As Boolean)

        '----------------------------------
        'Exemplo de UltraValidate
        '----------------------------------
        'UltraValidator1.Validate()
        '----------------------------------

        Dim mFLG_Gravou As Boolean = False
        Dim mCls As New ClsTiposAnimais
        Dim mRegisto_Atual As Integer = mNav.Registo_Atual

        With mCls
            If pbNovo Then
                '--------------------------------------
                'Método Não criado na CLASSE 
                ' Se for preciso é preciso criá-lo... 
                '--------------------------------------
                .Cod_Tipo_Animal = CodTipoAnimalTextEdit.Text
                '--------------------------------------
            Else
                '--------------------------------------
                ' Se for preciso é preciso criá-lo... 
                '--------------------------------------
                .Cod_Tipo_Animal = CodTipoAnimalTextEdit.Text
            End If
            .Imagem = ImagemTextEdit.Text
            .Animal = AnimalTextedit.Text
        End With

        If pbNovo Then
            mFLG_Gravou = ClsTiposAnimais.GravaTipos_Animais(mCls)
        Else
            mFLG_Gravou = ClsTiposAnimais.ModificaTipos_Animais(mCls)
        End If


        If mFLG_Gravou Then
            If pbNovo Then
                Me.UC_NAV1.mNovo = False
                mLista = ClsTiposAnimais.GetTipos_Animais
                mNav = New clsNav(mLista.Count)
                mNav.Registo_Atual = mLista.FindIndex(Function(x) x.Cod_Tipo_Animal = mCls.Cod_Tipo_Animal) + 1
                LoadRegistos()

                '---------------------------
                'upBar.Maximum = mNav.Max_Registos
                'upBar.Value = mNav.Registo_Atual
            Else
                mLista = ClsTiposAnimais.GetTipos_Animais
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
            ClsTiposAnimais.ApagaTipos_Animais(mLista(mNav.Registo_Atual - 1).Cod_Tipo_Animal)
        Catch ex As Exception
            MsgBox("Erro a Apagar o Registo Atual" & vbCrLf & ex.Message)
            Exit Sub
        End Try

        mLista = ClsTiposAnimais.GetTipos_Animais
        mNav = New clsNav(mLista.Count)
        LoadRegistos()
    End Sub

    Private Sub picCarregarImagem_Click(sender As Object, e As EventArgs) Handles picCarregarImagem.Click
        ofdTiposAnimais.Filter = " JPG |*.jpg| PNG | *.png| Todos os Ficheiros| *.*"
        If ofdTiposAnimais.ShowDialog = DialogResult.OK Then

            Dim mCont As Integer = 0
            Dim mFileName As String = ofdTiposAnimais.SafeFileName.ToString
            Dim mLen As Integer = Len(mFileName)
            Dim mExt As String = mFileName.Substring(mLen - 4, 4)

            Dim mFileDestino As String = mPathTiposAnimais + CodTipoAnimalTextEdit.Text + mExt
            Me.picTipoAnimal.Text = CodTipoAnimalTextEdit.Text + mExt
            Me.ImagemTextEdit.Text = CodTipoAnimalTextEdit.Text + mExt

Cont:
            Try
                File.Copy(ofdTiposAnimais.FileName, mFileDestino, True)
            Catch ex As Exception
                If File.Exists(mFileDestino) Then
                    mCont += 1
                    mFileDestino = mPathTiposAnimais + CodTipoAnimalTextEdit.Text + mCont.ToString("00") + mExt
                    Me.ImagemTextEdit.Text = CodTipoAnimalTextEdit.Text + mCont.ToString("00") + mExt
                    GoTo Cont
                End If

            End Try

            Me.picTipoAnimal.Image = Image.FromFile(mFileDestino)

            If mCont > 0 Then
                Me.picTipoAnimal.Image.Tag = CodTipoAnimalTextEdit.Text + mCont.ToString("000") + mExt
            Else
                Me.picTipoAnimal.Image.Tag = CodTipoAnimalTextEdit.Text + mExt
            End If

        End If
    End Sub

    Private Sub picApagarImagem_Click(sender As Object, e As EventArgs) Handles picApagarImagem.Click
        If ImagemTextEdit.Text <> "" Then
            If MsgBox("Quer apagar a imagem?", MsgBoxStyle.YesNo, "Imagem Animal") = vbNo Then
                Exit Sub
            ElseIf vbYes Then
                picTipoAnimal.Image = Image.FromFile(mPathTiposAnimais + "Default.png")
                ImagemTextEdit.Text = "Default.png"
            End If
        End If
    End Sub

    Sub RoundImage()
        Dim path As New System.Drawing.Drawing2D.GraphicsPath()
        Dim mCornerRadius As Integer = 50
        Dim mRectangle As Rectangle = New Rectangle(0, 0, picTipoAnimal.Width, picTipoAnimal.Height)
        Dim mArcRectangle As Rectangle = New Rectangle(mRectangle.Left, mRectangle.Top, mCornerRadius, mCornerRadius)
        path.AddArc(mArcRectangle, 180, 90)

        mArcRectangle.X = mRectangle.Right - mCornerRadius
        path.AddArc(mArcRectangle, 270, 90)
        mArcRectangle.Y = mRectangle.Bottom - mCornerRadius
        path.AddArc(mArcRectangle, 0, 90)
        mArcRectangle.X = mRectangle.Left
        path.AddArc(mArcRectangle, 90, 90)
        path.CloseFigure()

        picTipoAnimal.Region = New Region(path)
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
