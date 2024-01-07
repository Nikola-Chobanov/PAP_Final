<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_Animais
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
        Dim Cod_AnimalLabel As System.Windows.Forms.Label
        Dim Nome_AnimalLabel As System.Windows.Forms.Label
        Dim Cod_EntidadeLabel As System.Windows.Forms.Label
        Dim Cod_Tipo_AnimalLabel As System.Windows.Forms.Label
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("ClsTiposAnimais", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Tipo_Animal")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Animal")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Imagem")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Ativo")
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
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("ClsEntidades", -1)
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Entidade")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Entidade")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nome")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Pais")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Num_Telefone")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Num_Telemovel")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Email")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NIF")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Data_Registo")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Utilizador")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Password")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fotografia")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Ativo")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Contador_Enderecos")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Contador_Animais")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Lista_Enderecos")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Lista_Animais")
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Lista_Enderecos", 0)
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Entidade")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Endereco")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descritivo")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Endereco")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Postal")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Localidade")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Data_Registo")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Ativo")
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Lista_Animais", 0)
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Animal")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nome_Animal")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Entidade")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Tipo_Animal")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Imagem_Animal")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Ativo")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UC_Animais))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Cod_EntidadeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Cod_Tipo_AnimalTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Nome_AnimalTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Cod_AnimalTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ucCodTA = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.picCarregarImagem = New System.Windows.Forms.PictureBox()
        Me.picApagarImagem = New System.Windows.Forms.PictureBox()
        Me.ucCodEntidade = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Imagem_AnimalTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.picCodAnimal = New System.Windows.Forms.PictureBox()
        Me.picNomeAnimal = New System.Windows.Forms.PictureBox()
        Me.picCodEntidade = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picImagemAnimal = New System.Windows.Forms.PictureBox()
        Me.picAnimal = New System.Windows.Forms.PictureBox()
        Me.ofdImagem = New System.Windows.Forms.OpenFileDialog()
        Me.UC_NAV11 = New G02_Nikola_04.UC_NAV()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Cod_AnimalLabel = New System.Windows.Forms.Label()
        Nome_AnimalLabel = New System.Windows.Forms.Label()
        Cod_EntidadeLabel = New System.Windows.Forms.Label()
        Cod_Tipo_AnimalLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Cod_EntidadeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cod_Tipo_AnimalTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Nome_AnimalTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cod_AnimalTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucCodTA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCarregarImagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picApagarImagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucCodEntidade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Imagem_AnimalTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCodAnimal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picNomeAnimal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCodEntidade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picImagemAnimal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAnimal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cod_AnimalLabel
        '
        Cod_AnimalLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Cod_AnimalLabel.AutoSize = True
        Cod_AnimalLabel.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Cod_AnimalLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Cod_AnimalLabel.Location = New System.Drawing.Point(324, 148)
        Cod_AnimalLabel.Name = "Cod_AnimalLabel"
        Cod_AnimalLabel.Size = New System.Drawing.Size(114, 17)
        Cod_AnimalLabel.TabIndex = 0
        Cod_AnimalLabel.Text = "Código do Animal"
        '
        'Nome_AnimalLabel
        '
        Nome_AnimalLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Nome_AnimalLabel.AutoSize = True
        Nome_AnimalLabel.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Nome_AnimalLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Nome_AnimalLabel.Location = New System.Drawing.Point(320, 448)
        Nome_AnimalLabel.Name = "Nome_AnimalLabel"
        Nome_AnimalLabel.Size = New System.Drawing.Size(107, 17)
        Nome_AnimalLabel.TabIndex = 2
        Nome_AnimalLabel.Text = "Nome do Animal"
        '
        'Cod_EntidadeLabel
        '
        Cod_EntidadeLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Cod_EntidadeLabel.AutoSize = True
        Cod_EntidadeLabel.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Cod_EntidadeLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Cod_EntidadeLabel.Location = New System.Drawing.Point(324, 352)
        Cod_EntidadeLabel.Name = "Cod_EntidadeLabel"
        Cod_EntidadeLabel.Size = New System.Drawing.Size(127, 17)
        Cod_EntidadeLabel.TabIndex = 4
        Cod_EntidadeLabel.Text = "Código da Entidade"
        '
        'Cod_Tipo_AnimalLabel
        '
        Cod_Tipo_AnimalLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Cod_Tipo_AnimalLabel.AutoSize = True
        Cod_Tipo_AnimalLabel.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Cod_Tipo_AnimalLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Cod_Tipo_AnimalLabel.Location = New System.Drawing.Point(324, 250)
        Cod_Tipo_AnimalLabel.Name = "Cod_Tipo_AnimalLabel"
        Cod_Tipo_AnimalLabel.Size = New System.Drawing.Size(163, 17)
        Cod_Tipo_AnimalLabel.TabIndex = 3
        Cod_Tipo_AnimalLabel.Text = "Código do Tipo de Animal"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Cod_EntidadeTextEdit)
        Me.Panel1.Controls.Add(Me.Cod_Tipo_AnimalTextEdit)
        Me.Panel1.Controls.Add(Me.Nome_AnimalTextEdit)
        Me.Panel1.Controls.Add(Me.Cod_AnimalTextEdit)
        Me.Panel1.Controls.Add(Me.ucCodTA)
        Me.Panel1.Controls.Add(Me.picCarregarImagem)
        Me.Panel1.Controls.Add(Me.picApagarImagem)
        Me.Panel1.Controls.Add(Me.ucCodEntidade)
        Me.Panel1.Controls.Add(Me.Imagem_AnimalTextEdit)
        Me.Panel1.Controls.Add(Cod_Tipo_AnimalLabel)
        Me.Panel1.Controls.Add(Cod_EntidadeLabel)
        Me.Panel1.Controls.Add(Nome_AnimalLabel)
        Me.Panel1.Controls.Add(Cod_AnimalLabel)
        Me.Panel1.Controls.Add(Me.picCodAnimal)
        Me.Panel1.Controls.Add(Me.picNomeAnimal)
        Me.Panel1.Controls.Add(Me.picCodEntidade)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.picImagemAnimal)
        Me.Panel1.Controls.Add(Me.picAnimal)
        Me.Panel1.Location = New System.Drawing.Point(23, 88)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1609, 856)
        Me.Panel1.TabIndex = 1
        '
        'Cod_EntidadeTextEdit
        '
        Me.Cod_EntidadeTextEdit.Enabled = False
        Me.Cod_EntidadeTextEdit.Location = New System.Drawing.Point(332, 379)
        Me.Cod_EntidadeTextEdit.Name = "Cod_EntidadeTextEdit"
        Me.Cod_EntidadeTextEdit.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.Cod_EntidadeTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.Cod_EntidadeTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Cod_EntidadeTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.Cod_EntidadeTextEdit.Properties.Appearance.Options.UseFont = True
        Me.Cod_EntidadeTextEdit.Properties.Appearance.Options.UseForeColor = True
        Me.Cod_EntidadeTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Cod_EntidadeTextEdit.Size = New System.Drawing.Size(119, 28)
        Me.Cod_EntidadeTextEdit.TabIndex = 5
        '
        'Cod_Tipo_AnimalTextEdit
        '
        Me.Cod_Tipo_AnimalTextEdit.Enabled = False
        Me.Cod_Tipo_AnimalTextEdit.Location = New System.Drawing.Point(333, 277)
        Me.Cod_Tipo_AnimalTextEdit.Name = "Cod_Tipo_AnimalTextEdit"
        Me.Cod_Tipo_AnimalTextEdit.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.Cod_Tipo_AnimalTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.Cod_Tipo_AnimalTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Cod_Tipo_AnimalTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.Cod_Tipo_AnimalTextEdit.Properties.Appearance.Options.UseFont = True
        Me.Cod_Tipo_AnimalTextEdit.Properties.Appearance.Options.UseForeColor = True
        Me.Cod_Tipo_AnimalTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Cod_Tipo_AnimalTextEdit.Size = New System.Drawing.Size(118, 28)
        Me.Cod_Tipo_AnimalTextEdit.TabIndex = 0
        '
        'Nome_AnimalTextEdit
        '
        Me.Nome_AnimalTextEdit.Enabled = False
        Me.Nome_AnimalTextEdit.Location = New System.Drawing.Point(327, 475)
        Me.Nome_AnimalTextEdit.Name = "Nome_AnimalTextEdit"
        Me.Nome_AnimalTextEdit.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.Nome_AnimalTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.Nome_AnimalTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Nome_AnimalTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.Nome_AnimalTextEdit.Properties.Appearance.Options.UseFont = True
        Me.Nome_AnimalTextEdit.Properties.Appearance.Options.UseForeColor = True
        Me.Nome_AnimalTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Nome_AnimalTextEdit.Size = New System.Drawing.Size(195, 28)
        Me.Nome_AnimalTextEdit.TabIndex = 1
        '
        'Cod_AnimalTextEdit
        '
        Me.Cod_AnimalTextEdit.Enabled = False
        Me.Cod_AnimalTextEdit.Location = New System.Drawing.Point(332, 175)
        Me.Cod_AnimalTextEdit.Name = "Cod_AnimalTextEdit"
        Me.Cod_AnimalTextEdit.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.Cod_AnimalTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.Cod_AnimalTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Cod_AnimalTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.Cod_AnimalTextEdit.Properties.Appearance.Options.UseFont = True
        Me.Cod_AnimalTextEdit.Properties.Appearance.Options.UseForeColor = True
        Me.Cod_AnimalTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Cod_AnimalTextEdit.Size = New System.Drawing.Size(119, 28)
        Me.Cod_AnimalTextEdit.TabIndex = 1
        '
        'ucCodTA
        '
        Me.ucCodTA.Cursor = System.Windows.Forms.Cursors.Hand
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ucCodTA.DisplayLayout.Appearance = Appearance1
        UltraGridColumn1.Header.VisiblePosition = 0
        Appearance2.TextHAlignAsString = "Center"
        UltraGridColumn2.Header.Appearance = Appearance2
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn35.Header.VisiblePosition = 2
        UltraGridColumn35.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 3
        UltraGridColumn3.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn35, UltraGridColumn3})
        Me.ucCodTA.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ucCodTA.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ucCodTA.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ucCodTA.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Appearance3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance3.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance3.BorderColor = System.Drawing.SystemColors.Window
        Me.ucCodTA.DisplayLayout.GroupByBox.Appearance = Appearance3
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucCodTA.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance4
        Me.ucCodTA.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance5.BackColor2 = System.Drawing.SystemColors.Control
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance5.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucCodTA.DisplayLayout.GroupByBox.PromptAppearance = Appearance5
        Me.ucCodTA.DisplayLayout.MaxColScrollRegions = 1
        Me.ucCodTA.DisplayLayout.MaxRowScrollRegions = 1
        Appearance6.BackColor = System.Drawing.SystemColors.Window
        Appearance6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ucCodTA.DisplayLayout.Override.ActiveCellAppearance = Appearance6
        Appearance7.BackColor = System.Drawing.SystemColors.Highlight
        Appearance7.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ucCodTA.DisplayLayout.Override.ActiveRowAppearance = Appearance7
        Me.ucCodTA.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ucCodTA.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance8.BackColor = System.Drawing.SystemColors.Window
        Me.ucCodTA.DisplayLayout.Override.CardAreaAppearance = Appearance8
        Appearance9.BorderColor = System.Drawing.Color.Silver
        Appearance9.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ucCodTA.DisplayLayout.Override.CellAppearance = Appearance9
        Me.ucCodTA.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ucCodTA.DisplayLayout.Override.CellPadding = 0
        Appearance10.BackColor = System.Drawing.SystemColors.Control
        Appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance10.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance10.BorderColor = System.Drawing.SystemColors.Window
        Me.ucCodTA.DisplayLayout.Override.GroupByRowAppearance = Appearance10
        Appearance11.TextHAlignAsString = "Left"
        Me.ucCodTA.DisplayLayout.Override.HeaderAppearance = Appearance11
        Me.ucCodTA.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ucCodTA.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance12.BackColor = System.Drawing.SystemColors.Window
        Appearance12.BorderColor = System.Drawing.Color.Silver
        Me.ucCodTA.DisplayLayout.Override.RowAppearance = Appearance12
        Me.ucCodTA.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance13.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ucCodTA.DisplayLayout.Override.TemplateAddRowAppearance = Appearance13
        Me.ucCodTA.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ucCodTA.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ucCodTA.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.ucCodTA.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.ucCodTA.Location = New System.Drawing.Point(484, 274)
        Me.ucCodTA.Name = "ucCodTA"
        Me.ucCodTA.Size = New System.Drawing.Size(146, 33)
        Me.ucCodTA.TabIndex = 2
        '
        'picCarregarImagem
        '
        Me.picCarregarImagem.BackColor = System.Drawing.Color.Transparent
        Me.picCarregarImagem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picCarregarImagem.Image = Global.G02_Nikola_04.My.Resources.Resources.CarregarImagem
        Me.picCarregarImagem.Location = New System.Drawing.Point(948, 562)
        Me.picCarregarImagem.Name = "picCarregarImagem"
        Me.picCarregarImagem.Size = New System.Drawing.Size(206, 37)
        Me.picCarregarImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCarregarImagem.TabIndex = 19
        Me.picCarregarImagem.TabStop = False
        '
        'picApagarImagem
        '
        Me.picApagarImagem.BackColor = System.Drawing.Color.Transparent
        Me.picApagarImagem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picApagarImagem.Image = Global.G02_Nikola_04.My.Resources.Resources.ApagarImagem
        Me.picApagarImagem.Location = New System.Drawing.Point(948, 616)
        Me.picApagarImagem.Name = "picApagarImagem"
        Me.picApagarImagem.Size = New System.Drawing.Size(206, 37)
        Me.picApagarImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picApagarImagem.TabIndex = 18
        Me.picApagarImagem.TabStop = False
        '
        'ucCodEntidade
        '
        Me.ucCodEntidade.Cursor = System.Windows.Forms.Cursors.Hand
        Appearance14.BackColor = System.Drawing.SystemColors.Window
        Appearance14.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ucCodEntidade.DisplayLayout.Appearance = Appearance14
        Appearance15.TextHAlignAsString = "Center"
        UltraGridColumn4.Header.Appearance = Appearance15
        UltraGridColumn4.Header.Caption = "Codigo"
        UltraGridColumn4.Header.VisiblePosition = 0
        UltraGridColumn5.Header.VisiblePosition = 1
        UltraGridColumn5.Hidden = True
        Appearance16.ImageHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn6.Header.Appearance = Appearance16
        UltraGridColumn6.Header.VisiblePosition = 2
        UltraGridColumn6.Width = 265
        UltraGridColumn7.Header.VisiblePosition = 3
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 4
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.Header.VisiblePosition = 5
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.Header.VisiblePosition = 6
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.Header.VisiblePosition = 7
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.VisiblePosition = 8
        UltraGridColumn12.Hidden = True
        UltraGridColumn14.Header.VisiblePosition = 10
        UltraGridColumn14.Hidden = True
        UltraGridColumn13.Header.VisiblePosition = 9
        UltraGridColumn13.Hidden = True
        UltraGridColumn16.Header.VisiblePosition = 11
        UltraGridColumn16.Hidden = True
        UltraGridColumn15.Header.VisiblePosition = 12
        UltraGridColumn15.Hidden = True
        UltraGridColumn17.Header.VisiblePosition = 13
        UltraGridColumn17.Hidden = True
        UltraGridColumn18.Header.VisiblePosition = 14
        UltraGridColumn18.Hidden = True
        UltraGridColumn19.Header.VisiblePosition = 15
        UltraGridColumn20.Header.VisiblePosition = 16
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn14, UltraGridColumn13, UltraGridColumn16, UltraGridColumn15, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20})
        UltraGridColumn21.Header.VisiblePosition = 0
        UltraGridColumn22.Header.VisiblePosition = 1
        UltraGridColumn23.Header.VisiblePosition = 2
        UltraGridColumn24.Header.VisiblePosition = 3
        UltraGridColumn25.Header.VisiblePosition = 4
        UltraGridColumn26.Header.VisiblePosition = 5
        UltraGridColumn27.Header.VisiblePosition = 6
        UltraGridColumn28.Header.VisiblePosition = 7
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28})
        UltraGridColumn29.Header.VisiblePosition = 0
        UltraGridColumn30.Header.VisiblePosition = 1
        UltraGridColumn31.Header.VisiblePosition = 2
        UltraGridColumn32.Header.VisiblePosition = 3
        UltraGridColumn33.Header.VisiblePosition = 4
        UltraGridColumn34.Header.VisiblePosition = 5
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34})
        Me.ucCodEntidade.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.ucCodEntidade.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.ucCodEntidade.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.ucCodEntidade.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ucCodEntidade.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance17.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance17.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance17.BorderColor = System.Drawing.SystemColors.Window
        Me.ucCodEntidade.DisplayLayout.GroupByBox.Appearance = Appearance17
        Appearance18.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucCodEntidade.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance18
        Me.ucCodEntidade.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance19.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance19.BackColor2 = System.Drawing.SystemColors.Control
        Appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance19.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucCodEntidade.DisplayLayout.GroupByBox.PromptAppearance = Appearance19
        Me.ucCodEntidade.DisplayLayout.MaxColScrollRegions = 1
        Me.ucCodEntidade.DisplayLayout.MaxRowScrollRegions = 1
        Appearance20.BackColor = System.Drawing.SystemColors.Window
        Appearance20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ucCodEntidade.DisplayLayout.Override.ActiveCellAppearance = Appearance20
        Appearance21.BackColor = System.Drawing.SystemColors.Highlight
        Appearance21.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ucCodEntidade.DisplayLayout.Override.ActiveRowAppearance = Appearance21
        Me.ucCodEntidade.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ucCodEntidade.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance22.BackColor = System.Drawing.SystemColors.Window
        Me.ucCodEntidade.DisplayLayout.Override.CardAreaAppearance = Appearance22
        Appearance23.BorderColor = System.Drawing.Color.Silver
        Appearance23.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ucCodEntidade.DisplayLayout.Override.CellAppearance = Appearance23
        Me.ucCodEntidade.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ucCodEntidade.DisplayLayout.Override.CellPadding = 0
        Appearance24.BackColor = System.Drawing.SystemColors.Control
        Appearance24.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance24.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance24.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance24.BorderColor = System.Drawing.SystemColors.Window
        Me.ucCodEntidade.DisplayLayout.Override.GroupByRowAppearance = Appearance24
        Appearance25.TextHAlignAsString = "Left"
        Me.ucCodEntidade.DisplayLayout.Override.HeaderAppearance = Appearance25
        Me.ucCodEntidade.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ucCodEntidade.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance26.BackColor = System.Drawing.SystemColors.Window
        Appearance26.BorderColor = System.Drawing.Color.Silver
        Me.ucCodEntidade.DisplayLayout.Override.RowAppearance = Appearance26
        Me.ucCodEntidade.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance27.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ucCodEntidade.DisplayLayout.Override.TemplateAddRowAppearance = Appearance27
        Me.ucCodEntidade.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ucCodEntidade.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ucCodEntidade.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.ucCodEntidade.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.ucCodEntidade.Location = New System.Drawing.Point(484, 376)
        Me.ucCodEntidade.Name = "ucCodEntidade"
        Me.ucCodEntidade.Size = New System.Drawing.Size(170, 33)
        Me.ucCodEntidade.TabIndex = 3
        Me.ucCodEntidade.Visible = False
        '
        'Imagem_AnimalTextEdit
        '
        Me.Imagem_AnimalTextEdit.Enabled = False
        Me.Imagem_AnimalTextEdit.Location = New System.Drawing.Point(987, 469)
        Me.Imagem_AnimalTextEdit.Name = "Imagem_AnimalTextEdit"
        Me.Imagem_AnimalTextEdit.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.Imagem_AnimalTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.Imagem_AnimalTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Imagem_AnimalTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.Imagem_AnimalTextEdit.Properties.Appearance.Options.UseFont = True
        Me.Imagem_AnimalTextEdit.Properties.Appearance.Options.UseForeColor = True
        Me.Imagem_AnimalTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.Imagem_AnimalTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Imagem_AnimalTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Imagem_AnimalTextEdit.Size = New System.Drawing.Size(140, 28)
        Me.Imagem_AnimalTextEdit.TabIndex = 4
        '
        'picCodAnimal
        '
        Me.picCodAnimal.Image = CType(resources.GetObject("picCodAnimal.Image"), System.Drawing.Image)
        Me.picCodAnimal.Location = New System.Drawing.Point(323, 168)
        Me.picCodAnimal.Name = "picCodAnimal"
        Me.picCodAnimal.Size = New System.Drawing.Size(137, 42)
        Me.picCodAnimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCodAnimal.TabIndex = 14
        Me.picCodAnimal.TabStop = False
        '
        'picNomeAnimal
        '
        Me.picNomeAnimal.Enabled = False
        Me.picNomeAnimal.Image = Global.G02_Nikola_04.My.Resources.Resources.Shade2
        Me.picNomeAnimal.Location = New System.Drawing.Point(318, 468)
        Me.picNomeAnimal.Name = "picNomeAnimal"
        Me.picNomeAnimal.Size = New System.Drawing.Size(217, 42)
        Me.picNomeAnimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picNomeAnimal.TabIndex = 15
        Me.picNomeAnimal.TabStop = False
        '
        'picCodEntidade
        '
        Me.picCodEntidade.Image = CType(resources.GetObject("picCodEntidade.Image"), System.Drawing.Image)
        Me.picCodEntidade.Location = New System.Drawing.Point(323, 372)
        Me.picCodEntidade.Name = "picCodEntidade"
        Me.picCodEntidade.Size = New System.Drawing.Size(137, 42)
        Me.picCodEntidade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCodEntidade.TabIndex = 16
        Me.picCodEntidade.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(323, 270)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(137, 42)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'picImagemAnimal
        '
        Me.picImagemAnimal.Image = Global.G02_Nikola_04.My.Resources.Resources.Shade2
        Me.picImagemAnimal.Location = New System.Drawing.Point(979, 464)
        Me.picImagemAnimal.Name = "picImagemAnimal"
        Me.picImagemAnimal.Size = New System.Drawing.Size(156, 42)
        Me.picImagemAnimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picImagemAnimal.TabIndex = 20
        Me.picImagemAnimal.TabStop = False
        '
        'picAnimal
        '
        Me.picAnimal.Location = New System.Drawing.Point(878, 148)
        Me.picAnimal.Name = "picAnimal"
        Me.picAnimal.Size = New System.Drawing.Size(348, 293)
        Me.picAnimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAnimal.TabIndex = 10
        Me.picAnimal.TabStop = False
        '
        'ofdImagem
        '
        Me.ofdImagem.FileName = "OpenFileDialog1"
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
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.UC_NAV11)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1632, 974)
        Me.Panel2.TabIndex = 2
        '
        'UC_Animais
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "UC_Animais"
        Me.Size = New System.Drawing.Size(1632, 974)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Cod_EntidadeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cod_Tipo_AnimalTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Nome_AnimalTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cod_AnimalTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucCodTA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCarregarImagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picApagarImagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucCodEntidade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Imagem_AnimalTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCodAnimal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picNomeAnimal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCodEntidade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picImagemAnimal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAnimal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UC_NAV11 As UC_NAV
    Friend WithEvents Panel1 As Panel
    Friend WithEvents picAnimal As PictureBox
    Friend WithEvents Imagem_AnimalTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Cod_Tipo_AnimalTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Cod_EntidadeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Nome_AnimalTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Cod_AnimalTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ofdImagem As OpenFileDialog
    Friend WithEvents ucCodEntidade As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents picCodAnimal As PictureBox
    Friend WithEvents picNomeAnimal As PictureBox
    Friend WithEvents picCodEntidade As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents picApagarImagem As PictureBox
    Friend WithEvents picImagemAnimal As PictureBox
    Friend WithEvents ucCodTA As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Panel2 As Panel
    Friend WithEvents picCarregarImagem As PictureBox
End Class
