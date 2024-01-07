<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucDashboard
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("ClsAnimais", -1)
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Animal")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nome_Animal")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Entidade")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Entidade")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Tipo_Animal")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo_Animal")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Imagem_Animal")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Ativo")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.pnMain = New System.Windows.Forms.Panel()
        Me.dnDashboard = New DevExpress.XtraScheduler.DateNavigator()
        Me.PicMudar = New System.Windows.Forms.PictureBox()
        Me.UcGetReceitas1 = New G02_Gustavo_02.ucGetReceitas()
        Me.UcComparaReceitas1 = New G02_Gustavo_02.ucComparaReceitas()
        Me.pnUltimasTresConsultas = New System.Windows.Forms.Panel()
        Me.lblVeterinario2 = New System.Windows.Forms.Label()
        Me.lblVeterinario1 = New System.Windows.Forms.Label()
        Me.lblVeterinario = New System.Windows.Forms.Label()
        Me.lblTipoConsulta2 = New System.Windows.Forms.Label()
        Me.picAdicionarConsulta = New System.Windows.Forms.PictureBox()
        Me.lblTipoConsulta1 = New System.Windows.Forms.Label()
        Me.lblFim2 = New System.Windows.Forms.Label()
        Me.lblFim1 = New System.Windows.Forms.Label()
        Me.lblTipoConsulta = New System.Windows.Forms.Label()
        Me.lblInicio = New System.Windows.Forms.Label()
        Me.lblInicio2 = New System.Windows.Forms.Label()
        Me.lblInicio1 = New System.Windows.Forms.Label()
        Me.lblFim = New System.Windows.Forms.Label()
        Me.picPenultimaConsulta = New System.Windows.Forms.PictureBox()
        Me.picAntepenultimaConsulta = New System.Windows.Forms.PictureBox()
        Me.picUltimaConsulta = New System.Windows.Forms.PictureBox()
        Me.picSemConsultas = New System.Windows.Forms.PictureBox()
        Me.ugAnimais = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.lblConsultasSemana = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTotalPacientes = New System.Windows.Forms.Label()
        Me.picPacientes = New System.Windows.Forms.PictureBox()
        Me.lblFuncionario = New System.Windows.Forms.Label()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.picEntidade = New System.Windows.Forms.PictureBox()
        Me.picPerfil = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblDiaHoraData = New System.Windows.Forms.Label()
        Me.lblBemVindo = New System.Windows.Forms.Label()
        Me.picPanel = New System.Windows.Forms.PictureBox()
        Me.lblVeterinarios = New System.Windows.Forms.Label()
        Me.picVeterinarios = New System.Windows.Forms.PictureBox()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.ClsAnimaisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.pnMain.SuspendLayout()
        CType(Me.dnDashboard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dnDashboard.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicMudar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnUltimasTresConsultas.SuspendLayout()
        CType(Me.picAdicionarConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPenultimaConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAntepenultimaConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUltimaConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSemConsultas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ugAnimais, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEntidade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPerfil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.picPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picVeterinarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClsAnimaisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnMain
        '
        Me.pnMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnMain.BackColor = System.Drawing.Color.Transparent
        Me.pnMain.Controls.Add(Me.dnDashboard)
        Me.pnMain.Controls.Add(Me.PicMudar)
        Me.pnMain.Controls.Add(Me.UcGetReceitas1)
        Me.pnMain.Controls.Add(Me.UcComparaReceitas1)
        Me.pnMain.Controls.Add(Me.pnUltimasTresConsultas)
        Me.pnMain.Controls.Add(Me.ugAnimais)
        Me.pnMain.Controls.Add(Me.lblConsultasSemana)
        Me.pnMain.Controls.Add(Me.PictureBox1)
        Me.pnMain.Controls.Add(Me.lblTotalPacientes)
        Me.pnMain.Controls.Add(Me.picPacientes)
        Me.pnMain.Controls.Add(Me.lblFuncionario)
        Me.pnMain.Controls.Add(Me.lblNome)
        Me.pnMain.Controls.Add(Me.picEntidade)
        Me.pnMain.Controls.Add(Me.picPerfil)
        Me.pnMain.Controls.Add(Me.Panel1)
        Me.pnMain.Controls.Add(Me.lblVeterinarios)
        Me.pnMain.Controls.Add(Me.picVeterinarios)
        Me.pnMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnMain.Location = New System.Drawing.Point(0, 0)
        Me.pnMain.Name = "pnMain"
        Me.pnMain.Size = New System.Drawing.Size(1551, 994)
        Me.pnMain.TabIndex = 0
        '
        'dnDashboard
        '
        Me.dnDashboard.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dnDashboard.Appearance.Font = New System.Drawing.Font("Tahoma", 40.0!)
        Me.dnDashboard.Appearance.Options.UseFont = True
        Me.dnDashboard.CalendarAppearance.CalendarHeader.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.dnDashboard.CalendarAppearance.CalendarHeader.Options.UseFont = True
        Me.dnDashboard.CalendarAppearance.DayCellSpecial.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.dnDashboard.CalendarAppearance.DayCellSpecial.Options.UseFont = True
        Me.dnDashboard.CalendarAppearance.Header.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.dnDashboard.CalendarAppearance.Header.Options.UseFont = True
        Me.dnDashboard.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.[False]
        Me.dnDashboard.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dnDashboard.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.ClassicNew
        Me.dnDashboard.CellSize = New System.Drawing.Size(50, 50)
        Me.dnDashboard.FirstDayOfWeek = System.DayOfWeek.Sunday
        Me.dnDashboard.Location = New System.Drawing.Point(753, 51)
        Me.dnDashboard.MinimumSize = New System.Drawing.Size(400, 400)
        Me.dnDashboard.Name = "dnDashboard"
        Me.dnDashboard.Size = New System.Drawing.Size(400, 400)
        Me.dnDashboard.TabIndex = 24
        '
        'PicMudar
        '
        Me.PicMudar.Image = Global.G02_Gustavo_02.My.Resources.Resources.Receitas
        Me.PicMudar.Location = New System.Drawing.Point(548, 440)
        Me.PicMudar.Name = "PicMudar"
        Me.PicMudar.Size = New System.Drawing.Size(138, 40)
        Me.PicMudar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicMudar.TabIndex = 21
        Me.PicMudar.TabStop = False
        Me.PicMudar.Tag = "1"
        '
        'UcGetReceitas1
        '
        Me.UcGetReceitas1.BackColor = System.Drawing.Color.Transparent
        Me.UcGetReceitas1.Location = New System.Drawing.Point(0, 402)
        Me.UcGetReceitas1.Name = "UcGetReceitas1"
        Me.UcGetReceitas1.Size = New System.Drawing.Size(498, 299)
        Me.UcGetReceitas1.TabIndex = 20
        '
        'UcComparaReceitas1
        '
        Me.UcComparaReceitas1.BackColor = System.Drawing.Color.Transparent
        Me.UcComparaReceitas1.Location = New System.Drawing.Point(0, 402)
        Me.UcComparaReceitas1.Name = "UcComparaReceitas1"
        Me.UcComparaReceitas1.Size = New System.Drawing.Size(498, 299)
        Me.UcComparaReceitas1.TabIndex = 19
        '
        'pnUltimasTresConsultas
        '
        Me.pnUltimasTresConsultas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnUltimasTresConsultas.Controls.Add(Me.lblVeterinario2)
        Me.pnUltimasTresConsultas.Controls.Add(Me.lblVeterinario1)
        Me.pnUltimasTresConsultas.Controls.Add(Me.lblVeterinario)
        Me.pnUltimasTresConsultas.Controls.Add(Me.lblTipoConsulta2)
        Me.pnUltimasTresConsultas.Controls.Add(Me.picAdicionarConsulta)
        Me.pnUltimasTresConsultas.Controls.Add(Me.lblTipoConsulta1)
        Me.pnUltimasTresConsultas.Controls.Add(Me.lblFim2)
        Me.pnUltimasTresConsultas.Controls.Add(Me.lblFim1)
        Me.pnUltimasTresConsultas.Controls.Add(Me.lblTipoConsulta)
        Me.pnUltimasTresConsultas.Controls.Add(Me.lblInicio)
        Me.pnUltimasTresConsultas.Controls.Add(Me.lblInicio2)
        Me.pnUltimasTresConsultas.Controls.Add(Me.lblInicio1)
        Me.pnUltimasTresConsultas.Controls.Add(Me.lblFim)
        Me.pnUltimasTresConsultas.Controls.Add(Me.picPenultimaConsulta)
        Me.pnUltimasTresConsultas.Controls.Add(Me.picAntepenultimaConsulta)
        Me.pnUltimasTresConsultas.Controls.Add(Me.picUltimaConsulta)
        Me.pnUltimasTresConsultas.Controls.Add(Me.picSemConsultas)
        Me.pnUltimasTresConsultas.Location = New System.Drawing.Point(1123, 463)
        Me.pnUltimasTresConsultas.Name = "pnUltimasTresConsultas"
        Me.pnUltimasTresConsultas.Size = New System.Drawing.Size(356, 528)
        Me.pnUltimasTresConsultas.TabIndex = 14
        '
        'lblVeterinario2
        '
        Me.lblVeterinario2.AutoSize = True
        Me.lblVeterinario2.BackColor = System.Drawing.SystemColors.Window
        Me.lblVeterinario2.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.lblVeterinario2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.lblVeterinario2.Location = New System.Drawing.Point(145, 97)
        Me.lblVeterinario2.Name = "lblVeterinario2"
        Me.lblVeterinario2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblVeterinario2.Size = New System.Drawing.Size(94, 22)
        Me.lblVeterinario2.TabIndex = 23
        Me.lblVeterinario2.Text = "Veterinário"
        Me.lblVeterinario2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblVeterinario2.Visible = False
        '
        'lblVeterinario1
        '
        Me.lblVeterinario1.AutoSize = True
        Me.lblVeterinario1.BackColor = System.Drawing.SystemColors.Window
        Me.lblVeterinario1.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.lblVeterinario1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.lblVeterinario1.Location = New System.Drawing.Point(148, 240)
        Me.lblVeterinario1.Name = "lblVeterinario1"
        Me.lblVeterinario1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblVeterinario1.Size = New System.Drawing.Size(94, 22)
        Me.lblVeterinario1.TabIndex = 18
        Me.lblVeterinario1.Text = "Veterinário"
        Me.lblVeterinario1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblVeterinario1.Visible = False
        '
        'lblVeterinario
        '
        Me.lblVeterinario.AutoSize = True
        Me.lblVeterinario.BackColor = System.Drawing.SystemColors.Window
        Me.lblVeterinario.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.lblVeterinario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.lblVeterinario.Location = New System.Drawing.Point(145, 380)
        Me.lblVeterinario.Name = "lblVeterinario"
        Me.lblVeterinario.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblVeterinario.Size = New System.Drawing.Size(94, 22)
        Me.lblVeterinario.TabIndex = 13
        Me.lblVeterinario.Text = "Veterinário"
        Me.lblVeterinario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblVeterinario.Visible = False
        '
        'lblTipoConsulta2
        '
        Me.lblTipoConsulta2.AutoSize = True
        Me.lblTipoConsulta2.BackColor = System.Drawing.SystemColors.Window
        Me.lblTipoConsulta2.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.lblTipoConsulta2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.lblTipoConsulta2.Location = New System.Drawing.Point(145, 38)
        Me.lblTipoConsulta2.Name = "lblTipoConsulta2"
        Me.lblTipoConsulta2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblTipoConsulta2.Size = New System.Drawing.Size(113, 22)
        Me.lblTipoConsulta2.TabIndex = 20
        Me.lblTipoConsulta2.Text = "TipoConsulta"
        Me.lblTipoConsulta2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTipoConsulta2.Visible = False
        '
        'picAdicionarConsulta
        '
        Me.picAdicionarConsulta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picAdicionarConsulta.Image = Global.G02_Gustavo_02.My.Resources.Resources.AdicionarConsulta
        Me.picAdicionarConsulta.Location = New System.Drawing.Point(90, 456)
        Me.picAdicionarConsulta.Name = "picAdicionarConsulta"
        Me.picAdicionarConsulta.Size = New System.Drawing.Size(191, 69)
        Me.picAdicionarConsulta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAdicionarConsulta.TabIndex = 15
        Me.picAdicionarConsulta.TabStop = False
        Me.picAdicionarConsulta.Visible = False
        '
        'lblTipoConsulta1
        '
        Me.lblTipoConsulta1.AutoSize = True
        Me.lblTipoConsulta1.BackColor = System.Drawing.SystemColors.Window
        Me.lblTipoConsulta1.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.lblTipoConsulta1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.lblTipoConsulta1.Location = New System.Drawing.Point(148, 181)
        Me.lblTipoConsulta1.Name = "lblTipoConsulta1"
        Me.lblTipoConsulta1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblTipoConsulta1.Size = New System.Drawing.Size(113, 22)
        Me.lblTipoConsulta1.TabIndex = 15
        Me.lblTipoConsulta1.Text = "TipoConsulta"
        Me.lblTipoConsulta1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTipoConsulta1.Visible = False
        '
        'lblFim2
        '
        Me.lblFim2.AutoSize = True
        Me.lblFim2.BackColor = System.Drawing.SystemColors.Window
        Me.lblFim2.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblFim2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.lblFim2.Location = New System.Drawing.Point(209, 67)
        Me.lblFim2.Name = "lblFim2"
        Me.lblFim2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblFim2.Size = New System.Drawing.Size(35, 19)
        Me.lblFim2.TabIndex = 22
        Me.lblFim2.Text = "Fim"
        Me.lblFim2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblFim2.Visible = False
        '
        'lblFim1
        '
        Me.lblFim1.AutoSize = True
        Me.lblFim1.BackColor = System.Drawing.SystemColors.Window
        Me.lblFim1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblFim1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.lblFim1.Location = New System.Drawing.Point(212, 212)
        Me.lblFim1.Name = "lblFim1"
        Me.lblFim1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblFim1.Size = New System.Drawing.Size(35, 19)
        Me.lblFim1.TabIndex = 17
        Me.lblFim1.Text = "Fim"
        Me.lblFim1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblFim1.Visible = False
        '
        'lblTipoConsulta
        '
        Me.lblTipoConsulta.AutoSize = True
        Me.lblTipoConsulta.BackColor = System.Drawing.SystemColors.Window
        Me.lblTipoConsulta.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.lblTipoConsulta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.lblTipoConsulta.Location = New System.Drawing.Point(145, 322)
        Me.lblTipoConsulta.Name = "lblTipoConsulta"
        Me.lblTipoConsulta.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblTipoConsulta.Size = New System.Drawing.Size(113, 22)
        Me.lblTipoConsulta.TabIndex = 10
        Me.lblTipoConsulta.Text = "TipoConsulta"
        Me.lblTipoConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTipoConsulta.Visible = False
        '
        'lblInicio
        '
        Me.lblInicio.AutoSize = True
        Me.lblInicio.BackColor = System.Drawing.SystemColors.Window
        Me.lblInicio.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblInicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.lblInicio.Location = New System.Drawing.Point(145, 352)
        Me.lblInicio.Name = "lblInicio"
        Me.lblInicio.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblInicio.Size = New System.Drawing.Size(48, 19)
        Me.lblInicio.TabIndex = 11
        Me.lblInicio.Text = "Inicio"
        Me.lblInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblInicio.Visible = False
        '
        'lblInicio2
        '
        Me.lblInicio2.AutoSize = True
        Me.lblInicio2.BackColor = System.Drawing.SystemColors.Window
        Me.lblInicio2.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblInicio2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.lblInicio2.Location = New System.Drawing.Point(145, 67)
        Me.lblInicio2.Name = "lblInicio2"
        Me.lblInicio2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblInicio2.Size = New System.Drawing.Size(48, 19)
        Me.lblInicio2.TabIndex = 21
        Me.lblInicio2.Text = "Inicio"
        Me.lblInicio2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblInicio2.Visible = False
        '
        'lblInicio1
        '
        Me.lblInicio1.AutoSize = True
        Me.lblInicio1.BackColor = System.Drawing.SystemColors.Window
        Me.lblInicio1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblInicio1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.lblInicio1.Location = New System.Drawing.Point(148, 212)
        Me.lblInicio1.Name = "lblInicio1"
        Me.lblInicio1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblInicio1.Size = New System.Drawing.Size(48, 19)
        Me.lblInicio1.TabIndex = 16
        Me.lblInicio1.Text = "Inicio"
        Me.lblInicio1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblInicio1.Visible = False
        '
        'lblFim
        '
        Me.lblFim.AutoSize = True
        Me.lblFim.BackColor = System.Drawing.SystemColors.Window
        Me.lblFim.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblFim.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.lblFim.Location = New System.Drawing.Point(209, 352)
        Me.lblFim.Name = "lblFim"
        Me.lblFim.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblFim.Size = New System.Drawing.Size(35, 19)
        Me.lblFim.TabIndex = 12
        Me.lblFim.Text = "Fim"
        Me.lblFim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblFim.Visible = False
        '
        'picPenultimaConsulta
        '
        Me.picPenultimaConsulta.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picPenultimaConsulta.Image = Global.G02_Gustavo_02.My.Resources.Resources.UltimasTresConsultas
        Me.picPenultimaConsulta.Location = New System.Drawing.Point(0, 159)
        Me.picPenultimaConsulta.Name = "picPenultimaConsulta"
        Me.picPenultimaConsulta.Size = New System.Drawing.Size(356, 121)
        Me.picPenultimaConsulta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPenultimaConsulta.TabIndex = 14
        Me.picPenultimaConsulta.TabStop = False
        Me.picPenultimaConsulta.Visible = False
        '
        'picAntepenultimaConsulta
        '
        Me.picAntepenultimaConsulta.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picAntepenultimaConsulta.Image = Global.G02_Gustavo_02.My.Resources.Resources.UltimasTresConsultas
        Me.picAntepenultimaConsulta.Location = New System.Drawing.Point(0, 16)
        Me.picAntepenultimaConsulta.Name = "picAntepenultimaConsulta"
        Me.picAntepenultimaConsulta.Size = New System.Drawing.Size(354, 121)
        Me.picAntepenultimaConsulta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAntepenultimaConsulta.TabIndex = 19
        Me.picAntepenultimaConsulta.TabStop = False
        Me.picAntepenultimaConsulta.Visible = False
        '
        'picUltimaConsulta
        '
        Me.picUltimaConsulta.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picUltimaConsulta.Image = Global.G02_Gustavo_02.My.Resources.Resources.UltimasTresConsultas
        Me.picUltimaConsulta.Location = New System.Drawing.Point(0, 303)
        Me.picUltimaConsulta.Name = "picUltimaConsulta"
        Me.picUltimaConsulta.Size = New System.Drawing.Size(354, 121)
        Me.picUltimaConsulta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picUltimaConsulta.TabIndex = 9
        Me.picUltimaConsulta.TabStop = False
        Me.picUltimaConsulta.Visible = False
        '
        'picSemConsultas
        '
        Me.picSemConsultas.Image = Global.G02_Gustavo_02.My.Resources.Resources.SemConsultas
        Me.picSemConsultas.Location = New System.Drawing.Point(0, 16)
        Me.picSemConsultas.Name = "picSemConsultas"
        Me.picSemConsultas.Size = New System.Drawing.Size(356, 408)
        Me.picSemConsultas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSemConsultas.TabIndex = 19
        Me.picSemConsultas.TabStop = False
        Me.picSemConsultas.Visible = False
        '
        'ugAnimais
        '
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ugAnimais.DisplayLayout.Appearance = Appearance1
        Me.ugAnimais.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn17.Header.Caption = "Código"
        UltraGridColumn17.Header.VisiblePosition = 0
        UltraGridColumn17.Width = 100
        UltraGridColumn18.Header.Caption = "Nome do Animal"
        UltraGridColumn18.Header.VisiblePosition = 1
        UltraGridColumn18.Width = 179
        UltraGridColumn19.Header.VisiblePosition = 5
        UltraGridColumn19.Hidden = True
        UltraGridColumn20.Header.VisiblePosition = 3
        UltraGridColumn20.Width = 171
        UltraGridColumn21.Header.VisiblePosition = 4
        UltraGridColumn21.Hidden = True
        UltraGridColumn22.Header.Caption = "Tipo do Animal"
        UltraGridColumn22.Header.VisiblePosition = 2
        UltraGridColumn22.Width = 173
        UltraGridColumn23.Header.VisiblePosition = 6
        UltraGridColumn23.Hidden = True
        UltraGridColumn24.Header.VisiblePosition = 7
        UltraGridColumn24.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24})
        UltraGridBand1.Header.Caption = "Últimos Cinco Pacientes"
        UltraGridBand1.HeaderVisible = True
        Me.ugAnimais.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ugAnimais.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Rounded4Thick
        Me.ugAnimais.DisplayLayout.BorderStyleCaption = Infragistics.Win.UIElementBorderStyle.Rounded4Thick
        Me.ugAnimais.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ugAnimais.DisplayLayout.DefaultSelectedBackColor = System.Drawing.Color.Transparent
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.ugAnimais.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugAnimais.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.ugAnimais.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ugAnimais.DisplayLayout.GroupByBox.Hidden = True
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugAnimais.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
        Me.ugAnimais.DisplayLayout.MaxColScrollRegions = 1
        Me.ugAnimais.DisplayLayout.MaxRowScrollRegions = 1
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ugAnimais.DisplayLayout.Override.ActiveCellAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.SystemColors.Highlight
        Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ugAnimais.DisplayLayout.Override.ActiveRowAppearance = Appearance6
        Me.ugAnimais.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ugAnimais.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Me.ugAnimais.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Appearance8.FontData.Name = "Tahoma"
        Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ugAnimais.DisplayLayout.Override.CellAppearance = Appearance8
        Me.ugAnimais.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ugAnimais.DisplayLayout.Override.CellPadding = 0
        Appearance9.BackColor = System.Drawing.SystemColors.Control
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.ugAnimais.DisplayLayout.Override.GroupByRowAppearance = Appearance9
        Appearance10.TextHAlignAsString = "Left"
        Me.ugAnimais.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.ugAnimais.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance11.BackColor = System.Drawing.SystemColors.Window
        Appearance11.BorderColor = System.Drawing.Color.Silver
        Appearance11.FontData.Name = "Tahoma"
        Me.ugAnimais.DisplayLayout.Override.RowAppearance = Appearance11
        Me.ugAnimais.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ugAnimais.DisplayLayout.Override.TemplateAddRowAppearance = Appearance12
        Me.ugAnimais.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ugAnimais.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ugAnimais.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ugAnimais.Location = New System.Drawing.Point(40, 703)
        Me.ugAnimais.Name = "ugAnimais"
        Me.ugAnimais.Size = New System.Drawing.Size(646, 276)
        Me.ugAnimais.TabIndex = 8
        Me.ugAnimais.Text = "UltraGrid1"
        '
        'lblConsultasSemana
        '
        Me.lblConsultasSemana.AutoSize = True
        Me.lblConsultasSemana.BackColor = System.Drawing.SystemColors.Window
        Me.lblConsultasSemana.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.lblConsultasSemana.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.lblConsultasSemana.Location = New System.Drawing.Point(888, 791)
        Me.lblConsultasSemana.Name = "lblConsultasSemana"
        Me.lblConsultasSemana.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblConsultasSemana.Size = New System.Drawing.Size(96, 24)
        Me.lblConsultasSemana.TabIndex = 6
        Me.lblConsultasSemana.Text = "Consultas"
        Me.lblConsultasSemana.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.G02_Gustavo_02.My.Resources.Resources.ConsultasSemana
        Me.PictureBox1.Location = New System.Drawing.Point(769, 730)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(284, 104)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'lblTotalPacientes
        '
        Me.lblTotalPacientes.AutoSize = True
        Me.lblTotalPacientes.BackColor = System.Drawing.SystemColors.Window
        Me.lblTotalPacientes.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.lblTotalPacientes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.lblTotalPacientes.Location = New System.Drawing.Point(878, 932)
        Me.lblTotalPacientes.Name = "lblTotalPacientes"
        Me.lblTotalPacientes.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblTotalPacientes.Size = New System.Drawing.Size(95, 24)
        Me.lblTotalPacientes.TabIndex = 5
        Me.lblTotalPacientes.Text = "Pacientes"
        Me.lblTotalPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picPacientes
        '
        Me.picPacientes.Image = Global.G02_Gustavo_02.My.Resources.Resources.TotalPacientes
        Me.picPacientes.Location = New System.Drawing.Point(769, 871)
        Me.picPacientes.Name = "picPacientes"
        Me.picPacientes.Size = New System.Drawing.Size(284, 104)
        Me.picPacientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPacientes.TabIndex = 4
        Me.picPacientes.TabStop = False
        '
        'lblFuncionario
        '
        Me.lblFuncionario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFuncionario.AutoSize = True
        Me.lblFuncionario.BackColor = System.Drawing.SystemColors.Window
        Me.lblFuncionario.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.lblFuncionario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.lblFuncionario.Location = New System.Drawing.Point(1406, 51)
        Me.lblFuncionario.Name = "lblFuncionario"
        Me.lblFuncionario.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFuncionario.Size = New System.Drawing.Size(59, 12)
        Me.lblFuncionario.TabIndex = 3
        Me.lblFuncionario.Text = "Funcionário"
        Me.lblFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNome
        '
        Me.lblNome.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.lblNome.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNome.AutoSize = True
        Me.lblNome.BackColor = System.Drawing.SystemColors.Window
        Me.lblNome.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.lblNome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.lblNome.Location = New System.Drawing.Point(1400, 27)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblNome.Size = New System.Drawing.Size(47, 18)
        Me.lblNome.TabIndex = 0
        Me.lblNome.Text = "Nome"
        Me.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picEntidade
        '
        Me.picEntidade.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picEntidade.BackColor = System.Drawing.Color.LightGray
        Me.picEntidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picEntidade.Location = New System.Drawing.Point(1345, 29)
        Me.picEntidade.Name = "picEntidade"
        Me.picEntidade.Size = New System.Drawing.Size(47, 41)
        Me.picEntidade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEntidade.TabIndex = 1
        Me.picEntidade.TabStop = False
        '
        'picPerfil
        '
        Me.picPerfil.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picPerfil.Image = Global.G02_Gustavo_02.My.Resources.Resources.picPerfil
        Me.picPerfil.Location = New System.Drawing.Point(1327, 14)
        Me.picPerfil.Name = "picPerfil"
        Me.picPerfil.Size = New System.Drawing.Size(214, 68)
        Me.picPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPerfil.TabIndex = 0
        Me.picPerfil.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblDiaHoraData)
        Me.Panel1.Controls.Add(Me.lblBemVindo)
        Me.Panel1.Controls.Add(Me.picPanel)
        Me.Panel1.Location = New System.Drawing.Point(40, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(646, 345)
        Me.Panel1.TabIndex = 16
        '
        'lblDiaHoraData
        '
        Me.lblDiaHoraData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDiaHoraData.AutoSize = True
        Me.lblDiaHoraData.BackColor = System.Drawing.SystemColors.Window
        Me.lblDiaHoraData.Font = New System.Drawing.Font("Berlin Sans FB", 20.0!)
        Me.lblDiaHoraData.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.lblDiaHoraData.Location = New System.Drawing.Point(22, 54)
        Me.lblDiaHoraData.Name = "lblDiaHoraData"
        Me.lblDiaHoraData.Size = New System.Drawing.Size(165, 30)
        Me.lblDiaHoraData.TabIndex = 17
        Me.lblDiaHoraData.Text = "DiaHoraData"
        Me.lblDiaHoraData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBemVindo
        '
        Me.lblBemVindo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBemVindo.AutoSize = True
        Me.lblBemVindo.BackColor = System.Drawing.SystemColors.Window
        Me.lblBemVindo.Font = New System.Drawing.Font("Berlin Sans FB", 20.0!)
        Me.lblBemVindo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.lblBemVindo.Location = New System.Drawing.Point(22, 13)
        Me.lblBemVindo.Name = "lblBemVindo"
        Me.lblBemVindo.Size = New System.Drawing.Size(80, 30)
        Me.lblBemVindo.TabIndex = 16
        Me.lblBemVindo.Text = "Nome"
        Me.lblBemVindo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picPanel
        '
        Me.picPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picPanel.Image = Global.G02_Gustavo_02.My.Resources.Resources.PanelDashboard
        Me.picPanel.Location = New System.Drawing.Point(0, 0)
        Me.picPanel.Name = "picPanel"
        Me.picPanel.Size = New System.Drawing.Size(646, 345)
        Me.picPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPanel.TabIndex = 15
        Me.picPanel.TabStop = False
        '
        'lblVeterinarios
        '
        Me.lblVeterinarios.AutoSize = True
        Me.lblVeterinarios.BackColor = System.Drawing.SystemColors.Window
        Me.lblVeterinarios.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.lblVeterinarios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.lblVeterinarios.Location = New System.Drawing.Point(884, 643)
        Me.lblVeterinarios.Name = "lblVeterinarios"
        Me.lblVeterinarios.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblVeterinarios.Size = New System.Drawing.Size(117, 24)
        Me.lblVeterinarios.TabIndex = 18
        Me.lblVeterinarios.Text = "Veterinários"
        Me.lblVeterinarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picVeterinarios
        '
        Me.picVeterinarios.Image = Global.G02_Gustavo_02.My.Resources.Resources.TotalVeterinarios
        Me.picVeterinarios.Location = New System.Drawing.Point(769, 582)
        Me.picVeterinarios.Name = "picVeterinarios"
        Me.picVeterinarios.Size = New System.Drawing.Size(284, 104)
        Me.picVeterinarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picVeterinarios.TabIndex = 17
        Me.picVeterinarios.TabStop = False
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 1000
        '
        'ClsAnimaisBindingSource
        '
        Me.ClsAnimaisBindingSource.DataSource = GetType(G02_Gustavo_02.ClsAnimais)
        '
        'ucDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.pnMain)
        Me.Name = "ucDashboard"
        Me.Size = New System.Drawing.Size(1551, 994)
        Me.pnMain.ResumeLayout(False)
        Me.pnMain.PerformLayout()
        CType(Me.dnDashboard.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dnDashboard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicMudar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnUltimasTresConsultas.ResumeLayout(False)
        Me.pnUltimasTresConsultas.PerformLayout()
        CType(Me.picAdicionarConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPenultimaConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAntepenultimaConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUltimaConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSemConsultas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ugAnimais, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPacientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEntidade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPerfil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picPanel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picVeterinarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClsAnimaisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnMain As Panel
    Friend WithEvents picPerfil As PictureBox
    Friend WithEvents picEntidade As PictureBox
    Friend WithEvents lblNome As Label
    Friend WithEvents lblFuncionario As Label
    Friend WithEvents picPacientes As PictureBox
    Friend WithEvents lblTotalPacientes As Label
    Friend WithEvents lblConsultasSemana As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ugAnimais As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ClsAnimaisBindingSource As BindingSource
    Friend WithEvents picUltimaConsulta As PictureBox
    Friend WithEvents pnUltimasTresConsultas As Panel
    Friend WithEvents lblVeterinario As Label
    Friend WithEvents lblTipoConsulta As Label
    Friend WithEvents lblFim As Label
    Friend WithEvents lblInicio As Label
    Friend WithEvents lblVeterinario2 As Label
    Friend WithEvents lblVeterinario1 As Label
    Friend WithEvents lblTipoConsulta2 As Label
    Friend WithEvents lblTipoConsulta1 As Label
    Friend WithEvents lblFim2 As Label
    Friend WithEvents lblFim1 As Label
    Friend WithEvents lblInicio2 As Label
    Friend WithEvents lblInicio1 As Label
    Friend WithEvents picAntepenultimaConsulta As PictureBox
    Friend WithEvents picPenultimaConsulta As PictureBox
    Friend WithEvents picAdicionarConsulta As PictureBox
    Friend WithEvents picPanel As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblBemVindo As Label
    Friend WithEvents lblDiaHoraData As Label
    Friend WithEvents Timer As Timer
    Friend WithEvents lblVeterinarios As Label
    Friend WithEvents picVeterinarios As PictureBox
    Friend WithEvents picSemConsultas As PictureBox
    Friend WithEvents UcGetReceitas1 As ucGetReceitas
    Friend WithEvents UcComparaReceitas1 As ucComparaReceitas
    Friend WithEvents PicMudar As PictureBox
    Friend WithEvents dnDashboard As DevExpress.XtraScheduler.DateNavigator
End Class
