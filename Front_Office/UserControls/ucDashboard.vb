Imports System.Data.SqlTypes
Imports System.Drawing.Drawing2D
Imports DevExpress.Diagram.Core.Shapes
Imports DevExpress.XtraCharts
Imports DevExpress.XtraRichEdit.Model
Imports Infragistics.Win.UltraWinGrid

Public Class ucDashboard

    Friend Shared Nome As String

    Friend Shared Fotografia As String

    Dim mListaAnimais As New List(Of ClsAnimais)
    Dim mEntidade As New ClsEntidades
    Dim mPathEntidade As String = Application.StartupPath + "\..\..\Resources\Images\"
    Private Sub ucDashboard_Load(sender As Object, e As EventArgs) Handles Me.Load


        Dim roundRect As New Rectangle(0, 0, picEntidade.Width, picEntidade.Height)
        Dim path As New GraphicsPath()
        Dim diameter As Integer = 40
        Dim arc As New Rectangle(roundRect.Location, New Size(diameter, diameter))

        path.AddArc(arc, 180, 90)

        arc.X = roundRect.Right - diameter
        path.AddArc(arc, 270, 90)

        arc.Y = roundRect.Bottom - diameter
        path.AddArc(arc, 0, 90)

        arc.X = roundRect.Left
        path.AddArc(arc, 90, 90)

        path.CloseAllFigures()

        picEntidade.SizeMode = PictureBoxSizeMode.StretchImage
        picEntidade.Region = New Region(path)

        LoadEntidade()
        LoadInfo()
    End Sub

    Sub LoadEntidade()
        If Nome = "" Then
            lblNome.Text = "Nome"
        Else
            lblNome.Text = GetFirstAndLastName(Nome)
        End If


        If Fotografia <> "" Then
            picEntidade.Image = Image.FromFile(mPathEntidade + Fotografia)
        Else
            picEntidade.Image = Image.FromFile(mPathEntidade + "Default.png")
        End If
    End Sub


    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Dim mAgora As DateTime = DateTime.Now

        lblDiaHoraData.Text = String.Format("{0:t} {1}, {2}", mAgora, mAgora.ToString("dddd"), mAgora.ToString("dd/MM/yyyy"))

    End Sub

    Sub LoadInfo()
        Dim mListaConsultas As List(Of ClsConsultas) = ClsConsultas.GetUltimasTresConsultas()

        lblTotalPacientes.Text = ClsAnimais.GetCountAnimais()
        lblConsultasSemana.Text = ClsConsultas.GetCountConsultasSemanaAtual()
        lblVeterinarios.Text = ClsVeterinarios.GetCountVeterinarios()
        'lblReceita.Text = ClsLinhas.GetReceitaSemana() & "€"

        If Nome = "" Then
            lblBemVindo.Text = "Bem-Vindo!"
        Else
            lblBemVindo.Text = "Bem-Vindo " + Nome + "!"
        End If


        If mListaConsultas.Count = 0 Then
            picSemConsultas.Visible = True
        ElseIf mListaConsultas.Count = 1 Then

            picUltimaConsulta.Visible = True
            lblTipoConsulta.Visible = True
            lblVeterinario.Visible = True
            lblInicio.Visible = True
            lblFim.Visible = True
            lblTipoConsulta.Text = mListaConsultas(0).Tipo_Consulta
            lblVeterinario.Text = mListaConsultas(0).Veterinario
            lblInicio.Text = mListaConsultas(0).Hora_Inicio.ToString("t")
            lblFim.Text = mListaConsultas(0).Hora_Fim.ToString("t")

            picPenultimaConsulta.Visible = False
            lblTipoConsulta1.Visible = False
            lblVeterinario1.Visible = False
            lblInicio1.Visible = False
            lblFim1.Visible = False

            picAntepenultimaConsulta.Visible = False
            lblTipoConsulta2.Visible = False
            lblVeterinario2.Visible = False
            lblInicio2.Visible = False
            lblFim2.Visible = False

        ElseIf mListaConsultas.Count = 2 Then

            picUltimaConsulta.Visible = True
            lblTipoConsulta.Visible = True
            lblVeterinario.Visible = True
            lblInicio.Visible = True
            lblFim.Visible = True
            lblTipoConsulta.Text = mListaConsultas(0).Tipo_Consulta
            lblVeterinario.Text = mListaConsultas(0).Veterinario
            lblInicio.Text = mListaConsultas(0).Hora_Inicio.ToString("t")
            lblFim.Text = mListaConsultas(0).Hora_Fim.ToString("t")

            picPenultimaConsulta.Visible = True
            lblTipoConsulta1.Visible = True
            lblVeterinario1.Visible = True
            lblInicio1.Visible = True
            lblFim1.Visible = True
            lblTipoConsulta1.Text = mListaConsultas(1).Tipo_Consulta
            lblVeterinario1.Text = mListaConsultas(1).Veterinario
            lblInicio1.Text = mListaConsultas(1).Hora_Inicio.ToString("t")
            lblFim1.Text = mListaConsultas(1).Hora_Fim.ToString("t")

            picAntepenultimaConsulta.Visible = False
            lblTipoConsulta2.Visible = False
            lblVeterinario2.Visible = False
            lblInicio2.Visible = False
            lblFim2.Visible = False
        Else

            picUltimaConsulta.Visible = True
            lblTipoConsulta.Visible = True
            lblVeterinario.Visible = True
            lblInicio.Visible = True
            lblFim.Visible = True
            lblTipoConsulta.Text = mListaConsultas(0).Tipo_Consulta
            lblVeterinario.Text = mListaConsultas(0).Veterinario
            lblInicio.Text = mListaConsultas(0).Hora_Inicio.ToString("t")
            lblFim.Text = mListaConsultas(0).Hora_Fim.ToString("t")

            picPenultimaConsulta.Visible = True
            lblTipoConsulta1.Visible = True
            lblVeterinario1.Visible = True
            lblInicio1.Visible = True
            lblFim1.Visible = True
            lblTipoConsulta1.Text = mListaConsultas(1).Tipo_Consulta
            lblVeterinario1.Text = mListaConsultas(1).Veterinario
            lblInicio1.Text = mListaConsultas(1).Hora_Inicio.ToString("t")
            lblFim1.Text = mListaConsultas(1).Hora_Fim.ToString("t")

            picAntepenultimaConsulta.Visible = True
            lblTipoConsulta2.Visible = True
            lblVeterinario2.Visible = True
            lblInicio2.Visible = True
            lblFim2.Visible = True
            lblTipoConsulta2.Text = mListaConsultas(2).Tipo_Consulta
            lblVeterinario2.Text = mListaConsultas(2).Veterinario
            lblInicio2.Text = mListaConsultas(2).Hora_Inicio.ToString("t")
            lblFim2.Text = mListaConsultas(2).Hora_Fim.ToString("t")
        End If


        Config_ugAnimais()
    End Sub

    Sub Config_ugAnimais()
        ugAnimais.DataSource = ClsAnimais.GetUltimosCincoAnimais()
        ugAnimais.Refresh()

        ugAnimais.DisplayLayout.Bands(0).Header.Caption = "Últimos Cinco Pacientes"

        Me.ugAnimais.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        Me.ugAnimais.DisplayLayout.Appearance.FontData.Name = "Tahoma"
        Me.ugAnimais.DisplayLayout.Appearance.FontData.SizeInPoints = 12
        Me.ugAnimais.DisplayLayout.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.ugAnimais.DisplayLayout.Override.HeaderAppearance.FontData.Name = "Tahoma"
        Me.ugAnimais.DisplayLayout.Override.HeaderAppearance.FontData.SizeInPoints = 12
        Me.ugAnimais.DisplayLayout.Override.HeaderAppearance.ForeColor = System.Drawing.Color.DimGray

        'Me.ugAnimais.DisplayLayout.Override.SelectedRowAppearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer))
        'Me.ugAnimais.DisplayLayout.Override.SelectedRowAppearance.ForeColor = System.Drawing.Color.White
        'Me.ugAnimais.DisplayLayout.Override.ActiveRowAppearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        'Me.ugAnimais.DisplayLayout.Override.ActiveRowAppearance.ForeColor = System.Drawing.Color.White
        '
        'Me.ugAnimais.DisplayLayout.Override.SelectedRowAppearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer))
        'Me.ugAnimais.DisplayLayout.Override.SelectedRowAppearance.ForeColor = System.Drawing.Color.White
        'Me.ugAnimais.DisplayLayout.Override.ActiveRowAppearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        'Me.ugAnimais.DisplayLayout.Override.ActiveRowAppearance.ForeColor = System.Drawing.Color.White

        'Me.ugAnimais.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        Me.ugAnimais.DisplayLayout.Override.CellAppearance.TextHAlign = Infragistics.Win.HAlign.Left
        Me.ugAnimais.DisplayLayout.Override.CellAppearance.TextVAlign = Infragistics.Win.VAlign.Middle
        Me.ugAnimais.DisplayLayout.Override.DefaultRowHeight = 42
        Me.ugAnimais.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        Me.ugAnimais.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.AutoFree
        Me.ugAnimais.DisplayLayout.Override.RowSizingArea = Infragistics.Win.UltraWinGrid.RowSizingArea.RowSelectorsOnly
        Me.ugAnimais.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Single

    End Sub

    Function GetFirstAndLastName(Nome)
        Dim mNomeCompleto() As String
        Dim mNomeFinal As String = ""

        If Nome <> "" Then
            mNomeCompleto = Nome.Split(" ")
            mNomeFinal = mNomeCompleto(0) & " " & mNomeCompleto(mNomeCompleto.Length - 1)
        Else
            Nome = "Nome"
        End If

        Return mNomeFinal
    End Function

    Private Sub picAdicionarConsulta_Click(sender As Object, e As EventArgs) Handles picAdicionarConsulta.Click
        frmMain.mUC.Dispose()

        Dim mFrmApp As New frmApp
        mFrmApp.FormBorderStyle = FormBorderStyle.None
        mFrmApp.TopLevel = False
        mFrmApp.Parent = Me.pnMain
        mFrmApp.Dock = DockStyle.Fill

        mFrmApp.Show()

        frmMain.aceDashboard.Appearance.Normal.BackColor = Nothing
        frmMain.aceDashboard.Appearance.Default.BackColor = Nothing
        frmMain.aceConsultas.Appearance.Default.BackColor = Color.Coral
        frmMain.aceFaturacao.Appearance.Default.BackColor = Nothing
        frmMain.aceVeterinarios.Appearance.Default.BackColor = Nothing
        frmMain.aceProcurar.Appearance.Default.BackColor = Nothing
    End Sub

    Private Sub PicMudar_Click(sender As Object, e As EventArgs) Handles PicMudar.Click
        If PicMudar.Tag = 1 Then
            UcGetReceitas1.Visible = True
            UcComparaReceitas1.Visible = False
            PicMudar.Image = My.Resources.Receitas
            PicMudar.Tag = 0
        Else
            UcGetReceitas1.Visible = False
            UcComparaReceitas1.Visible = True
            PicMudar.Image = My.Resources.Comparar
            PicMudar.Tag = 1

        End If
    End Sub
    Private Sub btnVoltar_MouseMove(sender As Object, e As MouseEventArgs) Handles PicMudar.MouseMove
        If PicMudar.Tag = 1 Then
            PicMudar.Image = My.Resources.ReceitasShade
        Else
            PicMudar.Image = My.Resources.CompararShade
        End If

    End Sub

    Private Sub btnVoltar_MouseLeave(sender As Object, e As EventArgs) Handles PicMudar.MouseLeave
        If PicMudar.Tag = 1 Then
            PicMudar.Image = My.Resources.Receitas
        Else
            PicMudar.Image = My.Resources.Comparar
        End If
    End Sub
End Class
