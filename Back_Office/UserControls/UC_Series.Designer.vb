<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Series
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim lblCodSerie As System.Windows.Forms.Label
        Dim lblContador As System.Windows.Forms.Label
        Dim lblFLGTipoDoc As System.Windows.Forms.Label
        Dim lblAnoTrabalho As System.Windows.Forms.Label
        Dim lblFiltro As System.Windows.Forms.Label
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("ClsSeries", -1)
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Serie")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Tipo_Doc")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ano_Trabalho")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Contador")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Ativo")
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FiltroCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.pnGrid = New System.Windows.Forms.Panel()
        Me.ugSeries = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.AnoTrabalhoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.picAnoTrabalho = New System.Windows.Forms.PictureBox()
        Me.FLGTipoDocTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ContadorTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.picCriarSerie = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CodSerieTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.picCodSerie = New System.Windows.Forms.PictureBox()
        Me.picContador = New System.Windows.Forms.PictureBox()
        Me.picFLGTipoDoc = New System.Windows.Forms.PictureBox()
        Me.UltraGridBagLayoutManager1 = New Infragistics.Win.Misc.UltraGridBagLayoutManager(Me.components)
        Me.UC_NAV11 = New G02_Nikola_04.UC_NAV()
        lblCodSerie = New System.Windows.Forms.Label()
        lblContador = New System.Windows.Forms.Label()
        lblFLGTipoDoc = New System.Windows.Forms.Label()
        lblAnoTrabalho = New System.Windows.Forms.Label()
        lblFiltro = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.FiltroCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnGrid.SuspendLayout()
        CType(Me.ugSeries, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnoTrabalhoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAnoTrabalho, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FLGTipoDocTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContadorTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCriarSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodSerieTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCodSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picContador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFLGTipoDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGridBagLayoutManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCodSerie
        '
        lblCodSerie.AutoSize = True
        lblCodSerie.Font = New System.Drawing.Font("Tahoma", 10.0!)
        lblCodSerie.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        lblCodSerie.Location = New System.Drawing.Point(411, 187)
        lblCodSerie.Name = "lblCodSerie"
        lblCodSerie.Size = New System.Drawing.Size(103, 17)
        lblCodSerie.TabIndex = 0
        lblCodSerie.Text = "Código da Série"
        '
        'lblContador
        '
        lblContador.AutoSize = True
        lblContador.Font = New System.Drawing.Font("Tahoma", 10.0!)
        lblContador.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        lblContador.Location = New System.Drawing.Point(637, 187)
        lblContador.Name = "lblContador"
        lblContador.Size = New System.Drawing.Size(66, 17)
        lblContador.TabIndex = 14
        lblContador.Tag = "9"
        lblContador.Text = "Contador"
        '
        'lblFLGTipoDoc
        '
        lblFLGTipoDoc.AutoSize = True
        lblFLGTipoDoc.Font = New System.Drawing.Font("Tahoma", 10.0!)
        lblFLGTipoDoc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        lblFLGTipoDoc.Location = New System.Drawing.Point(850, 187)
        lblFLGTipoDoc.Name = "lblFLGTipoDoc"
        lblFLGTipoDoc.Size = New System.Drawing.Size(177, 17)
        lblFLGTipoDoc.TabIndex = 19
        lblFLGTipoDoc.Tag = "9"
        lblFLGTipoDoc.Text = "FLG do de Tipo Documento"
        '
        'lblAnoTrabalho
        '
        lblAnoTrabalho.AutoSize = True
        lblAnoTrabalho.Font = New System.Drawing.Font("Tahoma", 10.0!)
        lblAnoTrabalho.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        lblAnoTrabalho.Location = New System.Drawing.Point(1088, 187)
        lblAnoTrabalho.Name = "lblAnoTrabalho"
        lblAnoTrabalho.Size = New System.Drawing.Size(89, 17)
        lblAnoTrabalho.TabIndex = 20
        lblAnoTrabalho.Tag = "9"
        lblAnoTrabalho.Text = "Ano Trabalho"
        '
        'lblFiltro
        '
        lblFiltro.AutoSize = True
        lblFiltro.Font = New System.Drawing.Font("Tahoma", 15.0!)
        lblFiltro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        lblFiltro.Location = New System.Drawing.Point(731, 408)
        lblFiltro.Name = "lblFiltro"
        lblFiltro.Size = New System.Drawing.Size(113, 24)
        lblFiltro.TabIndex = 47
        lblFiltro.Tag = "9"
        lblFiltro.Text = "Filtrar Série"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(lblFiltro)
        Me.Panel1.Controls.Add(Me.FiltroCheckEdit)
        Me.Panel1.Controls.Add(Me.pnGrid)
        Me.Panel1.Controls.Add(Me.AnoTrabalhoTextEdit)
        Me.Panel1.Controls.Add(Me.picAnoTrabalho)
        Me.Panel1.Controls.Add(lblAnoTrabalho)
        Me.Panel1.Controls.Add(lblFLGTipoDoc)
        Me.Panel1.Controls.Add(Me.FLGTipoDocTextEdit)
        Me.Panel1.Controls.Add(Me.ContadorTextEdit)
        Me.Panel1.Controls.Add(lblContador)
        Me.Panel1.Controls.Add(Me.picCriarSerie)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(lblCodSerie)
        Me.Panel1.Controls.Add(Me.CodSerieTextEdit)
        Me.Panel1.Controls.Add(Me.picCodSerie)
        Me.Panel1.Controls.Add(Me.picContador)
        Me.Panel1.Controls.Add(Me.picFLGTipoDoc)
        Me.Panel1.Location = New System.Drawing.Point(4, 86)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1625, 857)
        Me.Panel1.TabIndex = 1
        '
        'FiltroCheckEdit
        '
        Me.FiltroCheckEdit.Location = New System.Drawing.Point(850, 403)
        Me.FiltroCheckEdit.Name = "FiltroCheckEdit"
        Me.FiltroCheckEdit.Properties.Caption = "False"
        Me.FiltroCheckEdit.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Custom
        Me.FiltroCheckEdit.Properties.CheckBoxOptions.SvgImageSize = New System.Drawing.Size(30, 30)
        Me.FiltroCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.FiltroCheckEdit.Properties.ImageOptions.SvgImageChecked = Global.G02_Nikola_04.My.Resources.Resources.CheckEditCheckedSVG1
        Me.FiltroCheckEdit.Properties.ImageOptions.SvgImageSize = New System.Drawing.Size(30, 30)
        Me.FiltroCheckEdit.Properties.ImageOptions.SvgImageUnchecked = Global.G02_Nikola_04.My.Resources.Resources.CheckEditSVG1
        Me.FiltroCheckEdit.Properties.ValueGrayed = True
        Me.FiltroCheckEdit.Size = New System.Drawing.Size(40, 34)
        Me.FiltroCheckEdit.TabIndex = 46
        '
        'pnGrid
        '
        Me.pnGrid.Controls.Add(Me.ugSeries)
        Me.pnGrid.Location = New System.Drawing.Point(572, 702)
        Me.pnGrid.Name = "pnGrid"
        Me.pnGrid.Size = New System.Drawing.Size(471, 155)
        Me.pnGrid.TabIndex = 2
        '
        'ugSeries
        '
        Me.ugSeries.AllowDrop = True
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ugSeries.DisplayLayout.Appearance = Appearance1
        UltraGridColumn36.Header.VisiblePosition = 0
        UltraGridColumn37.Header.VisiblePosition = 1
        UltraGridColumn38.Header.VisiblePosition = 2
        UltraGridColumn39.Header.VisiblePosition = 3
        UltraGridColumn40.Header.VisiblePosition = 4
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40})
        Me.ugSeries.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ugSeries.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ugSeries.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.ugSeries.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugSeries.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.ugSeries.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugSeries.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
        Me.ugSeries.DisplayLayout.MaxColScrollRegions = 1
        Me.ugSeries.DisplayLayout.MaxRowScrollRegions = 1
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ugSeries.DisplayLayout.Override.ActiveCellAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.SystemColors.Highlight
        Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ugSeries.DisplayLayout.Override.ActiveRowAppearance = Appearance6
        Me.ugSeries.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ugSeries.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Me.ugSeries.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ugSeries.DisplayLayout.Override.CellAppearance = Appearance8
        Me.ugSeries.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ugSeries.DisplayLayout.Override.CellPadding = 0
        Appearance9.BackColor = System.Drawing.SystemColors.Control
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.ugSeries.DisplayLayout.Override.GroupByRowAppearance = Appearance9
        Appearance10.TextHAlignAsString = "Left"
        Me.ugSeries.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.ugSeries.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ugSeries.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance11.BackColor = System.Drawing.SystemColors.Window
        Appearance11.BorderColor = System.Drawing.Color.Silver
        Me.ugSeries.DisplayLayout.Override.RowAppearance = Appearance11
        Me.ugSeries.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ugSeries.DisplayLayout.Override.TemplateAddRowAppearance = Appearance12
        Me.ugSeries.DisplayLayout.Scrollbars = Infragistics.Win.UltraWinGrid.Scrollbars.None
        Me.ugSeries.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ugSeries.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ugSeries.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ugSeries.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ugSeries.Location = New System.Drawing.Point(0, 0)
        Me.ugSeries.Name = "ugSeries"
        Me.ugSeries.Size = New System.Drawing.Size(471, 155)
        Me.ugSeries.TabIndex = 8
        Me.ugSeries.Text = "ugSeries"
        '
        'AnoTrabalhoTextEdit
        '
        Me.AnoTrabalhoTextEdit.Enabled = False
        Me.AnoTrabalhoTextEdit.Location = New System.Drawing.Point(1098, 215)
        Me.AnoTrabalhoTextEdit.Name = "AnoTrabalhoTextEdit"
        Me.AnoTrabalhoTextEdit.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.AnoTrabalhoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.AnoTrabalhoTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.AnoTrabalhoTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.AnoTrabalhoTextEdit.Properties.Appearance.Options.UseFont = True
        Me.AnoTrabalhoTextEdit.Properties.Appearance.Options.UseForeColor = True
        Me.AnoTrabalhoTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.AnoTrabalhoTextEdit.Size = New System.Drawing.Size(69, 32)
        Me.AnoTrabalhoTextEdit.TabIndex = 22
        '
        'picAnoTrabalho
        '
        Me.picAnoTrabalho.Image = Global.G02_Nikola_04.My.Resources.Resources.ShadeSmall
        Me.picAnoTrabalho.Location = New System.Drawing.Point(1089, 209)
        Me.picAnoTrabalho.Name = "picAnoTrabalho"
        Me.picAnoTrabalho.Size = New System.Drawing.Size(88, 42)
        Me.picAnoTrabalho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAnoTrabalho.TabIndex = 21
        Me.picAnoTrabalho.TabStop = False
        '
        'FLGTipoDocTextEdit
        '
        Me.FLGTipoDocTextEdit.Enabled = False
        Me.FLGTipoDocTextEdit.Location = New System.Drawing.Point(861, 215)
        Me.FLGTipoDocTextEdit.Name = "FLGTipoDocTextEdit"
        Me.FLGTipoDocTextEdit.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.FLGTipoDocTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.FLGTipoDocTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.FLGTipoDocTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.FLGTipoDocTextEdit.Properties.Appearance.Options.UseFont = True
        Me.FLGTipoDocTextEdit.Properties.Appearance.Options.UseForeColor = True
        Me.FLGTipoDocTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.FLGTipoDocTextEdit.Size = New System.Drawing.Size(81, 32)
        Me.FLGTipoDocTextEdit.TabIndex = 18
        '
        'ContadorTextEdit
        '
        Me.ContadorTextEdit.Enabled = False
        Me.ContadorTextEdit.Location = New System.Drawing.Point(649, 215)
        Me.ContadorTextEdit.Name = "ContadorTextEdit"
        Me.ContadorTextEdit.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.ContadorTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.ContadorTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ContadorTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.ContadorTextEdit.Properties.Appearance.Options.UseFont = True
        Me.ContadorTextEdit.Properties.Appearance.Options.UseForeColor = True
        Me.ContadorTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.ContadorTextEdit.Size = New System.Drawing.Size(73, 32)
        Me.ContadorTextEdit.TabIndex = 15
        '
        'picCriarSerie
        '
        Me.picCriarSerie.BackColor = System.Drawing.Color.Transparent
        Me.picCriarSerie.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picCriarSerie.Image = Global.G02_Nikola_04.My.Resources.Resources.CriarSerie
        Me.picCriarSerie.Location = New System.Drawing.Point(703, 309)
        Me.picCriarSerie.Name = "picCriarSerie"
        Me.picCriarSerie.Size = New System.Drawing.Size(216, 38)
        Me.picCriarSerie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCriarSerie.TabIndex = 12
        Me.picCriarSerie.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(0, 171)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(0, 0)
        Me.Panel2.TabIndex = 9
        '
        'CodSerieTextEdit
        '
        Me.CodSerieTextEdit.Enabled = False
        Me.CodSerieTextEdit.Location = New System.Drawing.Point(421, 215)
        Me.CodSerieTextEdit.Name = "CodSerieTextEdit"
        Me.CodSerieTextEdit.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.CodSerieTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.CodSerieTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CodSerieTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.CodSerieTextEdit.Properties.Appearance.Options.UseFont = True
        Me.CodSerieTextEdit.Properties.Appearance.Options.UseForeColor = True
        Me.CodSerieTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.CodSerieTextEdit.Size = New System.Drawing.Size(95, 32)
        Me.CodSerieTextEdit.TabIndex = 1
        '
        'picCodSerie
        '
        Me.picCodSerie.Image = Global.G02_Nikola_04.My.Resources.Resources.ShadeSmall
        Me.picCodSerie.Location = New System.Drawing.Point(412, 209)
        Me.picCodSerie.Name = "picCodSerie"
        Me.picCodSerie.Size = New System.Drawing.Size(114, 42)
        Me.picCodSerie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCodSerie.TabIndex = 13
        Me.picCodSerie.TabStop = False
        '
        'picContador
        '
        Me.picContador.Image = Global.G02_Nikola_04.My.Resources.Resources.ShadeSmall
        Me.picContador.Location = New System.Drawing.Point(638, 209)
        Me.picContador.Name = "picContador"
        Me.picContador.Size = New System.Drawing.Size(92, 42)
        Me.picContador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picContador.TabIndex = 16
        Me.picContador.TabStop = False
        '
        'picFLGTipoDoc
        '
        Me.picFLGTipoDoc.Image = Global.G02_Nikola_04.My.Resources.Resources.ShadeSmall
        Me.picFLGTipoDoc.Location = New System.Drawing.Point(851, 209)
        Me.picFLGTipoDoc.Name = "picFLGTipoDoc"
        Me.picFLGTipoDoc.Size = New System.Drawing.Size(100, 42)
        Me.picFLGTipoDoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFLGTipoDoc.TabIndex = 17
        Me.picFLGTipoDoc.TabStop = False
        '
        'UC_NAV11
        '
        Me.UC_NAV11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UC_NAV11.Location = New System.Drawing.Point(0, 0)
        Me.UC_NAV11.mFRM = Nothing
        Me.UC_NAV11.Name = "UC_NAV11"
        Me.UC_NAV11.Size = New System.Drawing.Size(1632, 974)
        Me.UC_NAV11.TabIndex = 0
        '
        'UC_Series
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.UC_NAV11)
        Me.Name = "UC_Series"
        Me.Size = New System.Drawing.Size(1632, 974)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.FiltroCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnGrid.ResumeLayout(False)
        CType(Me.ugSeries, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnoTrabalhoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAnoTrabalho, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FLGTipoDocTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContadorTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCriarSerie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodSerieTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCodSerie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picContador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFLGTipoDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGridBagLayoutManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UC_NAV11 As UC_NAV
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ugSeries As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents CodSerieTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UltraGridBagLayoutManager1 As Infragistics.Win.Misc.UltraGridBagLayoutManager
    Friend WithEvents picCriarSerie As PictureBox
    Friend WithEvents picCodSerie As PictureBox
    Friend WithEvents pnGrid As Panel
    Friend WithEvents FLGTipoDocTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ContadorTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents picContador As PictureBox
    Friend WithEvents picFLGTipoDoc As PictureBox
    Friend WithEvents AnoTrabalhoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents picAnoTrabalho As PictureBox
    Friend WithEvents FiltroCheckEdit As DevExpress.XtraEditors.CheckEdit
End Class
