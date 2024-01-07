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
        Dim Cod_SerieLabel As System.Windows.Forms.Label
        Dim FLG_Tipo_DocLabel As System.Windows.Forms.Label
        Dim Ano_TrabalhoLabel As System.Windows.Forms.Label
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("ClsSeries", -1)
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Serie")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Tipo_Doc")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ano_Trabalho")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Contador")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Ativo")
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
        Dim ContadorLabel1 As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ugSeries = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Ano_TrabalhoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.FLG_Tipo_DocTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Cod_SerieTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.UltraGridBagLayoutManager1 = New Infragistics.Win.Misc.UltraGridBagLayoutManager(Me.components)
        Me.ContadorTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.UC_NAV11 = New G02_Gustavo_02.UC_NAV1()
        Me.btnCriaSerie = New System.Windows.Forms.Button()
        Cod_SerieLabel = New System.Windows.Forms.Label()
        FLG_Tipo_DocLabel = New System.Windows.Forms.Label()
        Ano_TrabalhoLabel = New System.Windows.Forms.Label()
        ContadorLabel1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.ugSeries, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ano_TrabalhoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FLG_Tipo_DocTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cod_SerieTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGridBagLayoutManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContadorTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cod_SerieLabel
        '
        Cod_SerieLabel.AutoSize = True
        Cod_SerieLabel.Location = New System.Drawing.Point(29, 16)
        Cod_SerieLabel.Name = "Cod_SerieLabel"
        Cod_SerieLabel.Size = New System.Drawing.Size(56, 13)
        Cod_SerieLabel.TabIndex = 0
        Cod_SerieLabel.Text = "Cod Serie:"
        '
        'FLG_Tipo_DocLabel
        '
        FLG_Tipo_DocLabel.AutoSize = True
        FLG_Tipo_DocLabel.Location = New System.Drawing.Point(8, 42)
        FLG_Tipo_DocLabel.Name = "FLG_Tipo_DocLabel"
        FLG_Tipo_DocLabel.Size = New System.Drawing.Size(77, 13)
        FLG_Tipo_DocLabel.TabIndex = 2
        FLG_Tipo_DocLabel.Text = "FLG Tipo Doc:"
        '
        'Ano_TrabalhoLabel
        '
        Ano_TrabalhoLabel.AutoSize = True
        Ano_TrabalhoLabel.Location = New System.Drawing.Point(11, 68)
        Ano_TrabalhoLabel.Name = "Ano_TrabalhoLabel"
        Ano_TrabalhoLabel.Size = New System.Drawing.Size(74, 13)
        Ano_TrabalhoLabel.TabIndex = 4
        Ano_TrabalhoLabel.Text = "Ano Trabalho:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCriaSerie)
        Me.Panel1.Controls.Add(ContadorLabel1)
        Me.Panel1.Controls.Add(Me.ContadorTextEdit)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Ano_TrabalhoLabel)
        Me.Panel1.Controls.Add(Me.Ano_TrabalhoTextEdit)
        Me.Panel1.Controls.Add(FLG_Tipo_DocLabel)
        Me.Panel1.Controls.Add(Me.FLG_Tipo_DocTextEdit)
        Me.Panel1.Controls.Add(Cod_SerieLabel)
        Me.Panel1.Controls.Add(Me.Cod_SerieTextEdit)
        Me.Panel1.Location = New System.Drawing.Point(3, 75)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(978, 530)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ugSeries)
        Me.Panel2.Location = New System.Drawing.Point(0, 285)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(633, 225)
        Me.Panel2.TabIndex = 9
        '
        'ugSeries
        '
        Me.ugSeries.AllowDrop = True
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ugSeries.DisplayLayout.Appearance = Appearance1
        UltraGridColumn6.Header.VisiblePosition = 0
        UltraGridColumn7.Header.VisiblePosition = 1
        UltraGridColumn8.Header.VisiblePosition = 2
        UltraGridColumn9.Header.VisiblePosition = 3
        UltraGridColumn10.Header.VisiblePosition = 4
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10})
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
        Me.ugSeries.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ugSeries.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ugSeries.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.ugSeries.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ugSeries.Location = New System.Drawing.Point(0, 0)
        Me.ugSeries.Name = "ugSeries"
        Me.ugSeries.Size = New System.Drawing.Size(633, 225)
        Me.ugSeries.TabIndex = 8
        Me.ugSeries.Text = "UltraGrid1"
        '
        'Ano_TrabalhoTextEdit
        '
        Me.Ano_TrabalhoTextEdit.Location = New System.Drawing.Point(91, 65)
        Me.Ano_TrabalhoTextEdit.Name = "Ano_TrabalhoTextEdit"
        Me.Ano_TrabalhoTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.Ano_TrabalhoTextEdit.TabIndex = 5
        '
        'FLG_Tipo_DocTextEdit
        '
        Me.FLG_Tipo_DocTextEdit.Location = New System.Drawing.Point(91, 39)
        Me.FLG_Tipo_DocTextEdit.Name = "FLG_Tipo_DocTextEdit"
        Me.FLG_Tipo_DocTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.FLG_Tipo_DocTextEdit.TabIndex = 3
        '
        'Cod_SerieTextEdit
        '
        Me.Cod_SerieTextEdit.Location = New System.Drawing.Point(91, 13)
        Me.Cod_SerieTextEdit.Name = "Cod_SerieTextEdit"
        Me.Cod_SerieTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.Cod_SerieTextEdit.TabIndex = 1
        '
        'ContadorLabel1
        '
        ContadorLabel1.AutoSize = True
        ContadorLabel1.Location = New System.Drawing.Point(218, 16)
        ContadorLabel1.Name = "ContadorLabel1"
        ContadorLabel1.Size = New System.Drawing.Size(53, 13)
        ContadorLabel1.TabIndex = 9
        ContadorLabel1.Text = "Contador:"
        '
        'ContadorTextEdit
        '
        Me.ContadorTextEdit.Location = New System.Drawing.Point(277, 13)
        Me.ContadorTextEdit.Name = "ContadorTextEdit"
        Me.ContadorTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.ContadorTextEdit.TabIndex = 10
        '
        'UC_NAV11
        '
        Me.UC_NAV11.Location = New System.Drawing.Point(3, 3)
        Me.UC_NAV11.mFRM = Nothing
        Me.UC_NAV11.Name = "UC_NAV11"
        Me.UC_NAV11.Size = New System.Drawing.Size(984, 611)
        Me.UC_NAV11.TabIndex = 0
        '
        'btnCriaSerie
        '
        Me.btnCriaSerie.Location = New System.Drawing.Point(3, 123)
        Me.btnCriaSerie.Name = "btnCriaSerie"
        Me.btnCriaSerie.Size = New System.Drawing.Size(201, 23)
        Me.btnCriaSerie.TabIndex = 11
        Me.btnCriaSerie.Text = "Cria Serie do Ano Atual"
        Me.btnCriaSerie.UseVisualStyleBackColor = True
        '
        'UC_Series
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.UC_NAV11)
        Me.Name = "UC_Series"
        Me.Size = New System.Drawing.Size(987, 614)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.ugSeries, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ano_TrabalhoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FLG_Tipo_DocTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cod_SerieTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGridBagLayoutManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContadorTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UC_NAV11 As UC_NAV1
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ugSeries As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Ano_TrabalhoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FLG_Tipo_DocTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Cod_SerieTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UltraGridBagLayoutManager1 As Infragistics.Win.Misc.UltraGridBagLayoutManager
    Friend WithEvents ContadorTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnCriaSerie As Button
End Class
