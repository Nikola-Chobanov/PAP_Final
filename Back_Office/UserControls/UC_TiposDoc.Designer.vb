<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_TiposDoc
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
        Dim lblFLGTipoDoc As System.Windows.Forms.Label
        Dim lblDesignação As System.Windows.Forms.Label
        Dim lblDescritivoImpressao As System.Windows.Forms.Label
        Dim lblESC As System.Windows.Forms.Label
        Dim lblFLGDC As System.Windows.Forms.Label
        Dim lblFLGEntidade As System.Windows.Forms.Label
        Dim lblCodSerie As System.Windows.Forms.Label
        Dim lblFLGVenda As System.Windows.Forms.Label
        Dim lblFLGCompra As System.Windows.Forms.Label
        Dim lblFLGStock As System.Windows.Forms.Label
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("ClsTipos_Doc", -1)
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Tipo_Doc")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Designacao")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descritivo_Impressao")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_ESC")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_DC")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Entidade")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Venda")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Compra")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Stock")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Serie")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Contador")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Ativo")
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UC_TiposDoc))
        Me.pnTD = New System.Windows.Forms.Panel()
        Me.pnGrid = New System.Windows.Forms.Panel()
        Me.ugTD = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.DesignacaoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CodSerieTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.FLGEntidadeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.FLGDCTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.FLGESCTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DescritivoImpressaoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.FLGStockCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.FLGCompraCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.picCodSerie = New System.Windows.Forms.PictureBox()
        Me.picFLGEntidade = New System.Windows.Forms.PictureBox()
        Me.picFLGDC = New System.Windows.Forms.PictureBox()
        Me.picFLGESC = New System.Windows.Forms.PictureBox()
        Me.picDescritivoImpressao = New System.Windows.Forms.PictureBox()
        Me.FLGTipoDocTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.picFLGTipoDoc = New System.Windows.Forms.PictureBox()
        Me.FLGVendaCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.picDesignacao = New System.Windows.Forms.PictureBox()
        Me.UC_NAV11 = New G02_Nikola_04.UC_NAV()
        lblFLGTipoDoc = New System.Windows.Forms.Label()
        lblDesignação = New System.Windows.Forms.Label()
        lblDescritivoImpressao = New System.Windows.Forms.Label()
        lblESC = New System.Windows.Forms.Label()
        lblFLGDC = New System.Windows.Forms.Label()
        lblFLGEntidade = New System.Windows.Forms.Label()
        lblCodSerie = New System.Windows.Forms.Label()
        lblFLGVenda = New System.Windows.Forms.Label()
        lblFLGCompra = New System.Windows.Forms.Label()
        lblFLGStock = New System.Windows.Forms.Label()
        Me.pnTD.SuspendLayout()
        Me.pnGrid.SuspendLayout()
        CType(Me.ugTD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DesignacaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodSerieTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FLGEntidadeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FLGDCTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FLGESCTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescritivoImpressaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FLGStockCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FLGCompraCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCodSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFLGEntidade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFLGDC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFLGESC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDescritivoImpressao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FLGTipoDocTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFLGTipoDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FLGVendaCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDesignacao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFLGTipoDoc
        '
        lblFLGTipoDoc.AutoSize = True
        lblFLGTipoDoc.Font = New System.Drawing.Font("Tahoma", 10.0!)
        lblFLGTipoDoc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        lblFLGTipoDoc.Location = New System.Drawing.Point(367, 117)
        lblFLGTipoDoc.Name = "lblFLGTipoDoc"
        lblFLGTipoDoc.Size = New System.Drawing.Size(130, 17)
        lblFLGTipoDoc.TabIndex = 20
        lblFLGTipoDoc.Text = "Tipo de Documento"
        '
        'lblDesignação
        '
        lblDesignação.AutoSize = True
        lblDesignação.Font = New System.Drawing.Font("Tahoma", 10.0!)
        lblDesignação.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        lblDesignação.Location = New System.Drawing.Point(656, 117)
        lblDesignação.Name = "lblDesignação"
        lblDesignação.Size = New System.Drawing.Size(78, 17)
        lblDesignação.TabIndex = 23
        lblDesignação.Text = "Designação"
        '
        'lblDescritivoImpressao
        '
        lblDescritivoImpressao.AutoSize = True
        lblDescritivoImpressao.Font = New System.Drawing.Font("Tahoma", 10.0!)
        lblDescritivoImpressao.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        lblDescritivoImpressao.Location = New System.Drawing.Point(1060, 115)
        lblDescritivoImpressao.Name = "lblDescritivoImpressao"
        lblDescritivoImpressao.Size = New System.Drawing.Size(154, 17)
        lblDescritivoImpressao.TabIndex = 26
        lblDescritivoImpressao.Text = "Descritivo de Impressão"
        '
        'lblESC
        '
        lblESC.AutoSize = True
        lblESC.Font = New System.Drawing.Font("Tahoma", 10.0!)
        lblESC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        lblESC.Location = New System.Drawing.Point(367, 209)
        lblESC.Name = "lblESC"
        lblESC.Size = New System.Drawing.Size(138, 17)
        lblESC.TabIndex = 29
        lblESC.Text = "Entrada, Saída ou CC"
        '
        'lblFLGDC
        '
        lblFLGDC.AutoSize = True
        lblFLGDC.Font = New System.Drawing.Font("Tahoma", 10.0!)
        lblFLGDC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        lblFLGDC.Location = New System.Drawing.Point(647, 209)
        lblFLGDC.Name = "lblFLGDC"
        lblFLGDC.Size = New System.Drawing.Size(116, 17)
        lblFLGDC.TabIndex = 32
        lblFLGDC.Text = "Débito ou Crédito"
        '
        'lblFLGEntidade
        '
        lblFLGEntidade.AutoSize = True
        lblFLGEntidade.Font = New System.Drawing.Font("Tahoma", 10.0!)
        lblFLGEntidade.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        lblFLGEntidade.Location = New System.Drawing.Point(895, 209)
        lblFLGEntidade.Name = "lblFLGEntidade"
        lblFLGEntidade.Size = New System.Drawing.Size(110, 17)
        lblFLGEntidade.TabIndex = 35
        lblFLGEntidade.Text = "Tipo de Entidade"
        '
        'lblCodSerie
        '
        lblCodSerie.AutoSize = True
        lblCodSerie.Font = New System.Drawing.Font("Tahoma", 10.0!)
        lblCodSerie.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        lblCodSerie.Location = New System.Drawing.Point(1110, 209)
        lblCodSerie.Name = "lblCodSerie"
        lblCodSerie.Size = New System.Drawing.Size(103, 17)
        lblCodSerie.TabIndex = 38
        lblCodSerie.Text = "Código da Série"
        '
        'lblFLGVenda
        '
        lblFLGVenda.AutoSize = True
        lblFLGVenda.Font = New System.Drawing.Font("Tahoma", 16.0!)
        lblFLGVenda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        lblFLGVenda.Location = New System.Drawing.Point(542, 412)
        lblFLGVenda.Name = "lblFLGVenda"
        lblFLGVenda.Size = New System.Drawing.Size(73, 27)
        lblFLGVenda.TabIndex = 41
        lblFLGVenda.Text = "Venda"
        '
        'lblFLGCompra
        '
        lblFLGCompra.AutoSize = True
        lblFLGCompra.Font = New System.Drawing.Font("Tahoma", 16.0!)
        lblFLGCompra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        lblFLGCompra.Location = New System.Drawing.Point(761, 412)
        lblFLGCompra.Name = "lblFLGCompra"
        lblFLGCompra.Size = New System.Drawing.Size(87, 27)
        lblFLGCompra.TabIndex = 42
        lblFLGCompra.Text = "Compra"
        '
        'lblFLGStock
        '
        lblFLGStock.AutoSize = True
        lblFLGStock.Font = New System.Drawing.Font("Tahoma", 16.0!)
        lblFLGStock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        lblFLGStock.Location = New System.Drawing.Point(1002, 412)
        lblFLGStock.Name = "lblFLGStock"
        lblFLGStock.Size = New System.Drawing.Size(64, 27)
        lblFLGStock.TabIndex = 43
        lblFLGStock.Text = "Stock"
        '
        'pnTD
        '
        Me.pnTD.Controls.Add(Me.pnGrid)
        Me.pnTD.Controls.Add(Me.DesignacaoTextEdit)
        Me.pnTD.Controls.Add(Me.CodSerieTextEdit)
        Me.pnTD.Controls.Add(Me.FLGEntidadeTextEdit)
        Me.pnTD.Controls.Add(Me.FLGDCTextEdit)
        Me.pnTD.Controls.Add(Me.FLGESCTextEdit)
        Me.pnTD.Controls.Add(Me.DescritivoImpressaoTextEdit)
        Me.pnTD.Controls.Add(Me.FLGStockCheckEdit)
        Me.pnTD.Controls.Add(Me.FLGCompraCheckEdit)
        Me.pnTD.Controls.Add(lblFLGStock)
        Me.pnTD.Controls.Add(lblFLGCompra)
        Me.pnTD.Controls.Add(lblFLGVenda)
        Me.pnTD.Controls.Add(Me.picCodSerie)
        Me.pnTD.Controls.Add(lblCodSerie)
        Me.pnTD.Controls.Add(Me.picFLGEntidade)
        Me.pnTD.Controls.Add(lblFLGEntidade)
        Me.pnTD.Controls.Add(Me.picFLGDC)
        Me.pnTD.Controls.Add(lblFLGDC)
        Me.pnTD.Controls.Add(Me.picFLGESC)
        Me.pnTD.Controls.Add(lblESC)
        Me.pnTD.Controls.Add(Me.picDescritivoImpressao)
        Me.pnTD.Controls.Add(lblDescritivoImpressao)
        Me.pnTD.Controls.Add(lblDesignação)
        Me.pnTD.Controls.Add(Me.FLGTipoDocTextEdit)
        Me.pnTD.Controls.Add(Me.picFLGTipoDoc)
        Me.pnTD.Controls.Add(lblFLGTipoDoc)
        Me.pnTD.Controls.Add(Me.FLGVendaCheckEdit)
        Me.pnTD.Controls.Add(Me.picDesignacao)
        Me.pnTD.Location = New System.Drawing.Point(3, 88)
        Me.pnTD.Name = "pnTD"
        Me.pnTD.Size = New System.Drawing.Size(1616, 742)
        Me.pnTD.TabIndex = 1
        '
        'pnGrid
        '
        Me.pnGrid.Controls.Add(Me.ugTD)
        Me.pnGrid.Location = New System.Drawing.Point(355, 550)
        Me.pnGrid.Name = "pnGrid"
        Me.pnGrid.Size = New System.Drawing.Size(910, 192)
        Me.pnGrid.TabIndex = 3
        '
        'ugTD
        '
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ugTD.DisplayLayout.Appearance = Appearance1
        UltraGridColumn19.Header.Caption = "TD"
        UltraGridColumn19.Header.VisiblePosition = 0
        UltraGridColumn19.Width = 40
        UltraGridColumn20.Header.Caption = "Designação"
        UltraGridColumn20.Header.VisiblePosition = 1
        UltraGridColumn20.Width = 127
        UltraGridColumn21.Header.Caption = "Descritivo Impressão"
        UltraGridColumn21.Header.VisiblePosition = 2
        UltraGridColumn21.Width = 144
        UltraGridColumn22.Header.Caption = "ESC"
        UltraGridColumn22.Header.VisiblePosition = 3
        UltraGridColumn22.Width = 45
        UltraGridColumn23.Header.Caption = "DC"
        UltraGridColumn23.Header.VisiblePosition = 4
        UltraGridColumn23.Width = 37
        UltraGridColumn24.Header.VisiblePosition = 5
        UltraGridColumn24.Hidden = True
        UltraGridColumn25.Header.Caption = "FLG Venda"
        UltraGridColumn25.Header.VisiblePosition = 6
        UltraGridColumn26.Header.Caption = "FLG Compra"
        UltraGridColumn26.Header.VisiblePosition = 7
        UltraGridColumn27.Header.Caption = "FLG Stock"
        UltraGridColumn27.Header.VisiblePosition = 8
        UltraGridColumn28.Header.Caption = "Codigo de Serie"
        UltraGridColumn28.Header.VisiblePosition = 9
        UltraGridColumn28.HiddenWhenGroupBy = Infragistics.Win.DefaultableBoolean.[False]
        UltraGridColumn29.Header.VisiblePosition = 10
        UltraGridColumn30.Header.VisiblePosition = 11
        UltraGridColumn30.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30})
        UltraGridBand1.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        UltraGridBand1.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        UltraGridBand1.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        UltraGridBand1.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        UltraGridBand1.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        UltraGridBand1.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.ugTD.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ugTD.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ugTD.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.ugTD.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugTD.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.ugTD.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugTD.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
        Me.ugTD.DisplayLayout.MaxColScrollRegions = 1
        Me.ugTD.DisplayLayout.MaxRowScrollRegions = 1
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ugTD.DisplayLayout.Override.ActiveCellAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.SystemColors.Highlight
        Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ugTD.DisplayLayout.Override.ActiveRowAppearance = Appearance6
        Me.ugTD.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ugTD.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Me.ugTD.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ugTD.DisplayLayout.Override.CellAppearance = Appearance8
        Me.ugTD.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ugTD.DisplayLayout.Override.CellPadding = 0
        Appearance9.BackColor = System.Drawing.SystemColors.Control
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.ugTD.DisplayLayout.Override.GroupByRowAppearance = Appearance9
        Appearance10.TextHAlignAsString = "Left"
        Me.ugTD.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.ugTD.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ugTD.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance11.BackColor = System.Drawing.SystemColors.Window
        Appearance11.BorderColor = System.Drawing.Color.Silver
        Me.ugTD.DisplayLayout.Override.RowAppearance = Appearance11
        Me.ugTD.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ugTD.DisplayLayout.Override.TemplateAddRowAppearance = Appearance12
        Me.ugTD.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ugTD.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ugTD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ugTD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ugTD.Location = New System.Drawing.Point(0, 0)
        Me.ugTD.Name = "ugTD"
        Me.ugTD.Size = New System.Drawing.Size(910, 192)
        Me.ugTD.TabIndex = 0
        Me.ugTD.Text = "UltraGrid1"
        '
        'DesignacaoTextEdit
        '
        Me.DesignacaoTextEdit.Enabled = False
        Me.DesignacaoTextEdit.Location = New System.Drawing.Point(664, 145)
        Me.DesignacaoTextEdit.Name = "DesignacaoTextEdit"
        Me.DesignacaoTextEdit.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.DesignacaoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.DesignacaoTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.DesignacaoTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.DesignacaoTextEdit.Properties.Appearance.Options.UseFont = True
        Me.DesignacaoTextEdit.Properties.Appearance.Options.UseForeColor = True
        Me.DesignacaoTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.DesignacaoTextEdit.Size = New System.Drawing.Size(260, 28)
        Me.DesignacaoTextEdit.TabIndex = 24
        '
        'CodSerieTextEdit
        '
        Me.CodSerieTextEdit.Enabled = False
        Me.CodSerieTextEdit.Location = New System.Drawing.Point(1119, 237)
        Me.CodSerieTextEdit.Name = "CodSerieTextEdit"
        Me.CodSerieTextEdit.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.CodSerieTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.CodSerieTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CodSerieTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.CodSerieTextEdit.Properties.Appearance.Options.UseFont = True
        Me.CodSerieTextEdit.Properties.Appearance.Options.UseForeColor = True
        Me.CodSerieTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.CodSerieTextEdit.Size = New System.Drawing.Size(92, 28)
        Me.CodSerieTextEdit.TabIndex = 39
        '
        'FLGEntidadeTextEdit
        '
        Me.FLGEntidadeTextEdit.Enabled = False
        Me.FLGEntidadeTextEdit.Location = New System.Drawing.Point(911, 237)
        Me.FLGEntidadeTextEdit.Name = "FLGEntidadeTextEdit"
        Me.FLGEntidadeTextEdit.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.FLGEntidadeTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.FLGEntidadeTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.FLGEntidadeTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.FLGEntidadeTextEdit.Properties.Appearance.Options.UseFont = True
        Me.FLGEntidadeTextEdit.Properties.Appearance.Options.UseForeColor = True
        Me.FLGEntidadeTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.FLGEntidadeTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.FLGEntidadeTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.FLGEntidadeTextEdit.Size = New System.Drawing.Size(48, 28)
        Me.FLGEntidadeTextEdit.TabIndex = 36
        '
        'FLGDCTextEdit
        '
        Me.FLGDCTextEdit.Enabled = False
        Me.FLGDCTextEdit.Location = New System.Drawing.Point(663, 238)
        Me.FLGDCTextEdit.Name = "FLGDCTextEdit"
        Me.FLGDCTextEdit.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.FLGDCTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.FLGDCTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.FLGDCTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.FLGDCTextEdit.Properties.Appearance.Options.UseFont = True
        Me.FLGDCTextEdit.Properties.Appearance.Options.UseForeColor = True
        Me.FLGDCTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.FLGDCTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.FLGDCTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.FLGDCTextEdit.Size = New System.Drawing.Size(48, 28)
        Me.FLGDCTextEdit.TabIndex = 33
        '
        'FLGESCTextEdit
        '
        Me.FLGESCTextEdit.Enabled = False
        Me.FLGESCTextEdit.Location = New System.Drawing.Point(383, 237)
        Me.FLGESCTextEdit.Name = "FLGESCTextEdit"
        Me.FLGESCTextEdit.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.FLGESCTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.FLGESCTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.FLGESCTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.FLGESCTextEdit.Properties.Appearance.Options.UseFont = True
        Me.FLGESCTextEdit.Properties.Appearance.Options.UseForeColor = True
        Me.FLGESCTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.FLGESCTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.FLGESCTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.FLGESCTextEdit.Size = New System.Drawing.Size(48, 28)
        Me.FLGESCTextEdit.TabIndex = 30
        '
        'DescritivoImpressaoTextEdit
        '
        Me.DescritivoImpressaoTextEdit.Enabled = False
        Me.DescritivoImpressaoTextEdit.Location = New System.Drawing.Point(1068, 143)
        Me.DescritivoImpressaoTextEdit.Name = "DescritivoImpressaoTextEdit"
        Me.DescritivoImpressaoTextEdit.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.DescritivoImpressaoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.DescritivoImpressaoTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.DescritivoImpressaoTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.DescritivoImpressaoTextEdit.Properties.Appearance.Options.UseFont = True
        Me.DescritivoImpressaoTextEdit.Properties.Appearance.Options.UseForeColor = True
        Me.DescritivoImpressaoTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.DescritivoImpressaoTextEdit.Size = New System.Drawing.Size(143, 28)
        Me.DescritivoImpressaoTextEdit.TabIndex = 27
        '
        'FLGStockCheckEdit
        '
        Me.FLGStockCheckEdit.Location = New System.Drawing.Point(1070, 408)
        Me.FLGStockCheckEdit.Name = "FLGStockCheckEdit"
        Me.FLGStockCheckEdit.Properties.Caption = "False"
        Me.FLGStockCheckEdit.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Custom
        Me.FLGStockCheckEdit.Properties.CheckBoxOptions.SvgImageSize = New System.Drawing.Size(30, 30)
        Me.FLGStockCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.FLGStockCheckEdit.Properties.ImageOptions.SvgImageChecked = Global.G02_Nikola_04.My.Resources.Resources.CheckEditCheckedSVG1
        Me.FLGStockCheckEdit.Properties.ImageOptions.SvgImageSize = New System.Drawing.Size(30, 30)
        Me.FLGStockCheckEdit.Properties.ImageOptions.SvgImageUnchecked = Global.G02_Nikola_04.My.Resources.Resources.CheckEditSVG1
        Me.FLGStockCheckEdit.Properties.ValueGrayed = True
        Me.FLGStockCheckEdit.Size = New System.Drawing.Size(40, 34)
        Me.FLGStockCheckEdit.TabIndex = 45
        '
        'FLGCompraCheckEdit
        '
        Me.FLGCompraCheckEdit.Location = New System.Drawing.Point(853, 408)
        Me.FLGCompraCheckEdit.Name = "FLGCompraCheckEdit"
        Me.FLGCompraCheckEdit.Properties.Caption = "False"
        Me.FLGCompraCheckEdit.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Custom
        Me.FLGCompraCheckEdit.Properties.CheckBoxOptions.SvgImageSize = New System.Drawing.Size(30, 30)
        Me.FLGCompraCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.FLGCompraCheckEdit.Properties.ImageOptions.SvgImageChecked = Global.G02_Nikola_04.My.Resources.Resources.CheckEditCheckedSVG1
        Me.FLGCompraCheckEdit.Properties.ImageOptions.SvgImageSize = New System.Drawing.Size(30, 30)
        Me.FLGCompraCheckEdit.Properties.ImageOptions.SvgImageUnchecked = Global.G02_Nikola_04.My.Resources.Resources.CheckEditSVG1
        Me.FLGCompraCheckEdit.Properties.ValueGrayed = True
        Me.FLGCompraCheckEdit.Size = New System.Drawing.Size(40, 34)
        Me.FLGCompraCheckEdit.TabIndex = 44
        '
        'picCodSerie
        '
        Me.picCodSerie.Image = CType(resources.GetObject("picCodSerie.Image"), System.Drawing.Image)
        Me.picCodSerie.Location = New System.Drawing.Point(1110, 231)
        Me.picCodSerie.Name = "picCodSerie"
        Me.picCodSerie.Size = New System.Drawing.Size(109, 42)
        Me.picCodSerie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCodSerie.TabIndex = 40
        Me.picCodSerie.TabStop = False
        '
        'picFLGEntidade
        '
        Me.picFLGEntidade.Image = Global.G02_Nikola_04.My.Resources.Resources.ShadeSmall
        Me.picFLGEntidade.Location = New System.Drawing.Point(894, 231)
        Me.picFLGEntidade.Name = "picFLGEntidade"
        Me.picFLGEntidade.Size = New System.Drawing.Size(81, 42)
        Me.picFLGEntidade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFLGEntidade.TabIndex = 37
        Me.picFLGEntidade.TabStop = False
        '
        'picFLGDC
        '
        Me.picFLGDC.Image = Global.G02_Nikola_04.My.Resources.Resources.ShadeSmall
        Me.picFLGDC.Location = New System.Drawing.Point(646, 231)
        Me.picFLGDC.Name = "picFLGDC"
        Me.picFLGDC.Size = New System.Drawing.Size(81, 42)
        Me.picFLGDC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFLGDC.TabIndex = 34
        Me.picFLGDC.TabStop = False
        '
        'picFLGESC
        '
        Me.picFLGESC.Image = Global.G02_Nikola_04.My.Resources.Resources.ShadeSmall
        Me.picFLGESC.Location = New System.Drawing.Point(366, 231)
        Me.picFLGESC.Name = "picFLGESC"
        Me.picFLGESC.Size = New System.Drawing.Size(81, 42)
        Me.picFLGESC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFLGESC.TabIndex = 31
        Me.picFLGESC.TabStop = False
        '
        'picDescritivoImpressao
        '
        Me.picDescritivoImpressao.Image = Global.G02_Nikola_04.My.Resources.Resources.Shade2
        Me.picDescritivoImpressao.Location = New System.Drawing.Point(1059, 137)
        Me.picDescritivoImpressao.Name = "picDescritivoImpressao"
        Me.picDescritivoImpressao.Size = New System.Drawing.Size(160, 42)
        Me.picDescritivoImpressao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDescritivoImpressao.TabIndex = 28
        Me.picDescritivoImpressao.TabStop = False
        '
        'FLGTipoDocTextEdit
        '
        Me.FLGTipoDocTextEdit.Enabled = False
        Me.FLGTipoDocTextEdit.Location = New System.Drawing.Point(383, 145)
        Me.FLGTipoDocTextEdit.Name = "FLGTipoDocTextEdit"
        Me.FLGTipoDocTextEdit.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.FLGTipoDocTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.FLGTipoDocTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.FLGTipoDocTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.FLGTipoDocTextEdit.Properties.Appearance.Options.UseFont = True
        Me.FLGTipoDocTextEdit.Properties.Appearance.Options.UseForeColor = True
        Me.FLGTipoDocTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.FLGTipoDocTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.FLGTipoDocTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.FLGTipoDocTextEdit.Size = New System.Drawing.Size(48, 28)
        Me.FLGTipoDocTextEdit.TabIndex = 21
        '
        'picFLGTipoDoc
        '
        Me.picFLGTipoDoc.Image = Global.G02_Nikola_04.My.Resources.Resources.ShadeSmall
        Me.picFLGTipoDoc.Location = New System.Drawing.Point(366, 139)
        Me.picFLGTipoDoc.Name = "picFLGTipoDoc"
        Me.picFLGTipoDoc.Size = New System.Drawing.Size(81, 42)
        Me.picFLGTipoDoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFLGTipoDoc.TabIndex = 22
        Me.picFLGTipoDoc.TabStop = False
        '
        'FLGVendaCheckEdit
        '
        Me.FLGVendaCheckEdit.Location = New System.Drawing.Point(622, 408)
        Me.FLGVendaCheckEdit.Name = "FLGVendaCheckEdit"
        Me.FLGVendaCheckEdit.Properties.Caption = "True"
        Me.FLGVendaCheckEdit.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Custom
        Me.FLGVendaCheckEdit.Properties.CheckBoxOptions.SvgImageSize = New System.Drawing.Size(30, 30)
        Me.FLGVendaCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.FLGVendaCheckEdit.Properties.ImageOptions.SvgImageChecked = Global.G02_Nikola_04.My.Resources.Resources.CheckEditCheckedSVG1
        Me.FLGVendaCheckEdit.Properties.ImageOptions.SvgImageSize = New System.Drawing.Size(30, 30)
        Me.FLGVendaCheckEdit.Properties.ImageOptions.SvgImageUnchecked = Global.G02_Nikola_04.My.Resources.Resources.CheckEditSVG1
        Me.FLGVendaCheckEdit.Properties.ValueGrayed = True
        Me.FLGVendaCheckEdit.Size = New System.Drawing.Size(40, 34)
        Me.FLGVendaCheckEdit.TabIndex = 15
        '
        'picDesignacao
        '
        Me.picDesignacao.Image = Global.G02_Nikola_04.My.Resources.Resources.Shade2
        Me.picDesignacao.Location = New System.Drawing.Point(655, 139)
        Me.picDesignacao.Name = "picDesignacao"
        Me.picDesignacao.Size = New System.Drawing.Size(277, 42)
        Me.picDesignacao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDesignacao.TabIndex = 25
        Me.picDesignacao.TabStop = False
        '
        'UC_NAV11
        '
        Me.UC_NAV11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UC_NAV11.Location = New System.Drawing.Point(0, 0)
        Me.UC_NAV11.mFRM = Nothing
        Me.UC_NAV11.Name = "UC_NAV11"
        Me.UC_NAV11.Size = New System.Drawing.Size(1622, 856)
        Me.UC_NAV11.TabIndex = 0
        '
        'UC_TiposDoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnTD)
        Me.Controls.Add(Me.UC_NAV11)
        Me.Name = "UC_TiposDoc"
        Me.Size = New System.Drawing.Size(1622, 856)
        Me.pnTD.ResumeLayout(False)
        Me.pnTD.PerformLayout()
        Me.pnGrid.ResumeLayout(False)
        CType(Me.ugTD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DesignacaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodSerieTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FLGEntidadeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FLGDCTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FLGESCTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescritivoImpressaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FLGStockCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FLGCompraCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCodSerie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFLGEntidade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFLGDC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFLGESC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDescritivoImpressao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FLGTipoDocTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFLGTipoDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FLGVendaCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDesignacao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UC_NAV11 As UC_NAV
    Friend WithEvents pnTD As Panel
    Friend WithEvents FLGVendaCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents pnGrid As Panel
    Friend WithEvents FLGTipoDocTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents picFLGTipoDoc As PictureBox
    Friend WithEvents DesignacaoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents picDesignacao As PictureBox
    Friend WithEvents DescritivoImpressaoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents picDescritivoImpressao As PictureBox
    Friend WithEvents FLGESCTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents picFLGESC As PictureBox
    Friend WithEvents FLGDCTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents picFLGDC As PictureBox
    Friend WithEvents FLGEntidadeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents picFLGEntidade As PictureBox
    Friend WithEvents CodSerieTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents picCodSerie As PictureBox
    Friend WithEvents FLGCompraCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents FLGStockCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ugTD As Infragistics.Win.UltraWinGrid.UltraGrid
End Class
