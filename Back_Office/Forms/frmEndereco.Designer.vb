<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEndereco
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim lblCodEntidade As System.Windows.Forms.Label
        Dim lblCodEndereco As System.Windows.Forms.Label
        Dim lblDescritivo As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim lblCodPostal As System.Windows.Forms.Label
        Dim lblEndereço As System.Windows.Forms.Label
        Dim lblDataRegisto As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEndereco))
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("ClsCP_Localidades", -1)
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Postal")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Distrito")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Concelho")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Localidade")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Ativo")
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
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("ClsCP_Localidades", -1)
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Postal")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Distrito")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Concelho")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Localidade")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Ativo")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.BarNAV = New DevExpress.XtraBars.Bar()
        Me.Bar4 = New DevExpress.XtraBars.Bar()
        Me.Bar5 = New DevExpress.XtraBars.Bar()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.bbStatus = New DevExpress.XtraBars.BarStaticItem()
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.bbGrava = New DevExpress.XtraBars.BarButtonItem()
        Me.bbCancela = New DevExpress.XtraBars.BarButtonItem()
        Me.bbApaga = New DevExpress.XtraBars.BarButtonItem()
        Me.bbNovo = New DevExpress.XtraBars.BarButtonItem()
        Me.bbModifica = New DevExpress.XtraBars.BarButtonItem()
        Me.bbSair = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.bbPrimeiro = New DevExpress.XtraBars.BarButtonItem()
        Me.bbAnterior = New DevExpress.XtraBars.BarButtonItem()
        Me.bbSeguinte = New DevExpress.XtraBars.BarButtonItem()
        Me.bbUltimo = New DevExpress.XtraBars.BarButtonItem()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.pnMain = New System.Windows.Forms.Panel()
        Me.DescritivoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.cmbDescritivo = New System.Windows.Forms.ComboBox()
        Me.ucLocalidades = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.ucCodPostal = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.EnderecoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.picEndereco = New System.Windows.Forms.PictureBox()
        Me.CodPostalTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.picCodPostal = New System.Windows.Forms.PictureBox()
        Me.LocalidadeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.picLocalidade = New System.Windows.Forms.PictureBox()
        Me.picDescritivo = New System.Windows.Forms.PictureBox()
        Me.CodEnderecoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DataRegistoDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.CodEntidadeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.picCodEntidade = New System.Windows.Forms.PictureBox()
        lblCodEntidade = New System.Windows.Forms.Label()
        lblCodEndereco = New System.Windows.Forms.Label()
        lblDescritivo = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        lblCodPostal = New System.Windows.Forms.Label()
        lblEndereço = New System.Windows.Forms.Label()
        lblDataRegisto = New System.Windows.Forms.Label()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnMain.SuspendLayout()
        CType(Me.DescritivoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucLocalidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucCodPostal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnderecoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEndereco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodPostalTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCodPostal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalidadeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLocalidade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDescritivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodEnderecoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataRegistoDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataRegistoDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodEntidadeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCodEntidade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCodEntidade
        '
        lblCodEntidade.AutoSize = True
        lblCodEntidade.Font = New System.Drawing.Font("Tahoma", 10.0!)
        lblCodEntidade.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        lblCodEntidade.Location = New System.Drawing.Point(46, 16)
        lblCodEntidade.Name = "lblCodEntidade"
        lblCodEntidade.Size = New System.Drawing.Size(127, 17)
        lblCodEntidade.TabIndex = 23
        lblCodEntidade.Text = "Código da Entidade"
        '
        'lblCodEndereco
        '
        lblCodEndereco.AutoSize = True
        lblCodEndereco.Font = New System.Drawing.Font("Tahoma", 10.0!)
        lblCodEndereco.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        lblCodEndereco.Location = New System.Drawing.Point(193, 16)
        lblCodEndereco.Name = "lblCodEndereco"
        lblCodEndereco.Size = New System.Drawing.Size(133, 17)
        lblCodEndereco.TabIndex = 24
        lblCodEndereco.Text = "Código do Endereço"
        '
        'lblDescritivo
        '
        lblDescritivo.AutoSize = True
        lblDescritivo.Font = New System.Drawing.Font("Tahoma", 10.0!)
        lblDescritivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        lblDescritivo.Location = New System.Drawing.Point(47, 87)
        lblDescritivo.Name = "lblDescritivo"
        lblDescritivo.Size = New System.Drawing.Size(68, 17)
        lblDescritivo.TabIndex = 26
        lblDescritivo.Text = "Descritivo"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Label1.Location = New System.Drawing.Point(47, 164)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(71, 17)
        Label1.TabIndex = 29
        Label1.Text = "Localidade"
        '
        'lblCodPostal
        '
        lblCodPostal.AutoSize = True
        lblCodPostal.Font = New System.Drawing.Font("Tahoma", 10.0!)
        lblCodPostal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        lblCodPostal.Location = New System.Drawing.Point(46, 240)
        lblCodPostal.Name = "lblCodPostal"
        lblCodPostal.Size = New System.Drawing.Size(91, 17)
        lblCodPostal.TabIndex = 33
        lblCodPostal.Text = "Código Postal"
        '
        'lblEndereço
        '
        lblEndereço.AutoSize = True
        lblEndereço.Font = New System.Drawing.Font("Tahoma", 10.0!)
        lblEndereço.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        lblEndereço.Location = New System.Drawing.Point(47, 320)
        lblEndereço.Name = "lblEndereço"
        lblEndereço.Size = New System.Drawing.Size(66, 17)
        lblEndereço.TabIndex = 35
        lblEndereço.Text = "Endereço"
        '
        'lblDataRegisto
        '
        lblDataRegisto.AutoSize = True
        lblDataRegisto.Font = New System.Drawing.Font("Tahoma", 10.0!)
        lblDataRegisto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        lblDataRegisto.Location = New System.Drawing.Point(400, 334)
        lblDataRegisto.Name = "lblDataRegisto"
        lblDataRegisto.Size = New System.Drawing.Size(106, 17)
        lblDataRegisto.TabIndex = 37
        lblDataRegisto.Text = "Data do Registo"
        '
        'BarNAV
        '
        Me.BarNAV.BarName = "Tools"
        Me.BarNAV.DockCol = 0
        Me.BarNAV.DockRow = 0
        Me.BarNAV.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.BarNAV.OptionsBar.AllowQuickCustomization = False
        Me.BarNAV.OptionsBar.DrawDragBorder = False
        Me.BarNAV.Text = "Tools"
        '
        'Bar4
        '
        Me.Bar4.BarName = "Custom 5"
        Me.Bar4.DockCol = 1
        Me.Bar4.DockRow = 0
        Me.Bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar4.Offset = 227
        Me.Bar4.Text = "Custom 5"
        '
        'Bar5
        '
        Me.Bar5.BarName = "Custom 5"
        Me.Bar5.DockCol = 1
        Me.Bar5.DockRow = 0
        Me.Bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar5.Offset = 227
        Me.Bar5.Text = "Custom 5"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3, Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbPrimeiro, Me.bbAnterior, Me.bbSeguinte, Me.bbUltimo, Me.bbNovo, Me.bbModifica, Me.bbApaga, Me.bbSair, Me.bbGrava, Me.bbCancela, Me.bbStatus, Me.BarStaticItem1})
        Me.BarManager1.MaxItemId = 15
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbStatus)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'bbStatus
        '
        Me.bbStatus.Caption = "bsStatus"
        Me.bbStatus.Id = 13
        Me.bbStatus.Name = "bbStatus"
        '
        'Bar2
        '
        Me.Bar2.BarName = "Custom 5"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbGrava), New DevExpress.XtraBars.LinkPersistInfo(Me.bbCancela), New DevExpress.XtraBars.LinkPersistInfo(Me.bbApaga), New DevExpress.XtraBars.LinkPersistInfo(Me.bbNovo), New DevExpress.XtraBars.LinkPersistInfo(Me.bbModifica), New DevExpress.XtraBars.LinkPersistInfo(Me.bbSair)})
        Me.Bar2.Offset = 205
        Me.Bar2.OptionsBar.AllowQuickCustomization = False
        Me.Bar2.OptionsBar.DrawDragBorder = False
        Me.Bar2.Text = "Custom 5"
        '
        'bbGrava
        '
        Me.bbGrava.Caption = "Grava"
        Me.bbGrava.Id = 11
        Me.bbGrava.ImageOptions.Image = Global.G02_Nikola_04.My.Resources.Resources.Grava
        Me.bbGrava.Name = "bbGrava"
        '
        'bbCancela
        '
        Me.bbCancela.Caption = "Cancela"
        Me.bbCancela.Id = 12
        Me.bbCancela.ImageOptions.Image = Global.G02_Nikola_04.My.Resources.Resources.Cancela
        Me.bbCancela.Name = "bbCancela"
        '
        'bbApaga
        '
        Me.bbApaga.Caption = "Apaga"
        Me.bbApaga.Id = 8
        Me.bbApaga.ImageOptions.Image = CType(resources.GetObject("bbApaga.ImageOptions.Image"), System.Drawing.Image)
        Me.bbApaga.Name = "bbApaga"
        '
        'bbNovo
        '
        Me.bbNovo.Caption = "Novo"
        Me.bbNovo.Id = 4
        Me.bbNovo.ImageOptions.Image = CType(resources.GetObject("bbNovo.ImageOptions.Image"), System.Drawing.Image)
        Me.bbNovo.Name = "bbNovo"
        '
        'bbModifica
        '
        Me.bbModifica.Caption = "Modifica"
        Me.bbModifica.Id = 5
        Me.bbModifica.ImageOptions.Image = CType(resources.GetObject("bbModifica.ImageOptions.Image"), System.Drawing.Image)
        Me.bbModifica.Name = "bbModifica"
        '
        'bbSair
        '
        Me.bbSair.Caption = "Sair"
        Me.bbSair.Id = 9
        Me.bbSair.ImageOptions.Image = CType(resources.GetObject("bbSair.ImageOptions.Image"), System.Drawing.Image)
        Me.bbSair.Name = "bbSair"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(593, 51)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 472)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(593, 22)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 51)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 421)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(593, 51)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 421)
        '
        'bbPrimeiro
        '
        Me.bbPrimeiro.Caption = "Primeiro"
        Me.bbPrimeiro.Id = 0
        Me.bbPrimeiro.ImageOptions.Image = CType(resources.GetObject("bbPrimeiro.ImageOptions.Image"), System.Drawing.Image)
        Me.bbPrimeiro.Name = "bbPrimeiro"
        '
        'bbAnterior
        '
        Me.bbAnterior.Caption = "Anterior"
        Me.bbAnterior.Id = 1
        Me.bbAnterior.ImageOptions.Image = CType(resources.GetObject("bbAnterior.ImageOptions.Image"), System.Drawing.Image)
        Me.bbAnterior.Name = "bbAnterior"
        '
        'bbSeguinte
        '
        Me.bbSeguinte.Caption = "Seguinte"
        Me.bbSeguinte.Id = 2
        Me.bbSeguinte.ImageOptions.Image = CType(resources.GetObject("bbSeguinte.ImageOptions.Image"), System.Drawing.Image)
        Me.bbSeguinte.Name = "bbSeguinte"
        '
        'bbUltimo
        '
        Me.bbUltimo.Caption = "Ultimo"
        Me.bbUltimo.Id = 3
        Me.bbUltimo.ImageOptions.Image = CType(resources.GetObject("bbUltimo.ImageOptions.Image"), System.Drawing.Image)
        Me.bbUltimo.Name = "bbUltimo"
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Caption = "BarStaticItem1"
        Me.BarStaticItem1.Id = 14
        Me.BarStaticItem1.Name = "BarStaticItem1"
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.FloatLocation = New System.Drawing.Point(2255, 388)
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbPrimeiro), New DevExpress.XtraBars.LinkPersistInfo(Me.bbAnterior), New DevExpress.XtraBars.LinkPersistInfo(Me.bbSeguinte), New DevExpress.XtraBars.LinkPersistInfo(Me.bbUltimo)})
        Me.Bar1.Text = "Tools"
        '
        'pnMain
        '
        Me.pnMain.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnMain.Controls.Add(Me.DescritivoTextEdit)
        Me.pnMain.Controls.Add(Me.cmbDescritivo)
        Me.pnMain.Controls.Add(Me.ucLocalidades)
        Me.pnMain.Controls.Add(Me.ucCodPostal)
        Me.pnMain.Controls.Add(lblDataRegisto)
        Me.pnMain.Controls.Add(Me.EnderecoTextEdit)
        Me.pnMain.Controls.Add(lblEndereço)
        Me.pnMain.Controls.Add(Me.picEndereco)
        Me.pnMain.Controls.Add(lblCodPostal)
        Me.pnMain.Controls.Add(Me.CodPostalTextEdit)
        Me.pnMain.Controls.Add(Me.picCodPostal)
        Me.pnMain.Controls.Add(Me.LocalidadeTextEdit)
        Me.pnMain.Controls.Add(Label1)
        Me.pnMain.Controls.Add(Me.picLocalidade)
        Me.pnMain.Controls.Add(lblDescritivo)
        Me.pnMain.Controls.Add(Me.picDescritivo)
        Me.pnMain.Controls.Add(lblCodEndereco)
        Me.pnMain.Controls.Add(lblCodEntidade)
        Me.pnMain.Controls.Add(Me.CodEnderecoTextEdit)
        Me.pnMain.Controls.Add(Me.PictureBox1)
        Me.pnMain.Controls.Add(Me.DataRegistoDateEdit)
        Me.pnMain.Controls.Add(Me.CodEntidadeTextEdit)
        Me.pnMain.Controls.Add(Me.picCodEntidade)
        Me.pnMain.Location = New System.Drawing.Point(21, 66)
        Me.pnMain.Name = "pnMain"
        Me.pnMain.Size = New System.Drawing.Size(552, 393)
        Me.pnMain.TabIndex = 20
        '
        'DescritivoTextEdit
        '
        Me.DescritivoTextEdit.Enabled = False
        Me.DescritivoTextEdit.Location = New System.Drawing.Point(59, 112)
        Me.DescritivoTextEdit.Name = "DescritivoTextEdit"
        Me.DescritivoTextEdit.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.DescritivoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.DescritivoTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.DescritivoTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.DescritivoTextEdit.Properties.Appearance.Options.UseFont = True
        Me.DescritivoTextEdit.Properties.Appearance.Options.UseForeColor = True
        Me.DescritivoTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.DescritivoTextEdit.Size = New System.Drawing.Size(265, 28)
        Me.DescritivoTextEdit.TabIndex = 25
        '
        'cmbDescritivo
        '
        Me.cmbDescritivo.Font = New System.Drawing.Font("Tahoma", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDescritivo.FormattingEnabled = True
        Me.cmbDescritivo.Location = New System.Drawing.Point(374, 113)
        Me.cmbDescritivo.Name = "cmbDescritivo"
        Me.cmbDescritivo.Size = New System.Drawing.Size(121, 29)
        Me.cmbDescritivo.TabIndex = 41
        '
        'ucLocalidades
        '
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ucLocalidades.DisplayLayout.Appearance = Appearance1
        UltraGridColumn15.Header.VisiblePosition = 0
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.Header.VisiblePosition = 1
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.Header.VisiblePosition = 2
        UltraGridColumn17.Hidden = True
        UltraGridColumn18.Header.VisiblePosition = 3
        UltraGridColumn18.Width = 166
        UltraGridColumn19.Header.VisiblePosition = 4
        UltraGridColumn19.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19})
        Me.ucLocalidades.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ucLocalidades.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ucLocalidades.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ucLocalidades.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.ucLocalidades.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucLocalidades.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.ucLocalidades.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucLocalidades.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
        Me.ucLocalidades.DisplayLayout.MaxColScrollRegions = 1
        Me.ucLocalidades.DisplayLayout.MaxRowScrollRegions = 1
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ucLocalidades.DisplayLayout.Override.ActiveCellAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.SystemColors.Highlight
        Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ucLocalidades.DisplayLayout.Override.ActiveRowAppearance = Appearance6
        Me.ucLocalidades.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ucLocalidades.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Me.ucLocalidades.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ucLocalidades.DisplayLayout.Override.CellAppearance = Appearance8
        Me.ucLocalidades.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ucLocalidades.DisplayLayout.Override.CellPadding = 0
        Appearance9.BackColor = System.Drawing.SystemColors.Control
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.ucLocalidades.DisplayLayout.Override.GroupByRowAppearance = Appearance9
        Appearance10.TextHAlignAsString = "Left"
        Me.ucLocalidades.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.ucLocalidades.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ucLocalidades.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance11.BackColor = System.Drawing.SystemColors.Window
        Appearance11.BorderColor = System.Drawing.Color.Silver
        Me.ucLocalidades.DisplayLayout.Override.RowAppearance = Appearance11
        Me.ucLocalidades.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ucLocalidades.DisplayLayout.Override.TemplateAddRowAppearance = Appearance12
        Me.ucLocalidades.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ucLocalidades.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ucLocalidades.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.ucLocalidades.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.ucLocalidades.Location = New System.Drawing.Point(360, 189)
        Me.ucLocalidades.Name = "ucLocalidades"
        Me.ucLocalidades.Size = New System.Drawing.Size(162, 32)
        Me.ucLocalidades.TabIndex = 14
        '
        'ucCodPostal
        '
        Appearance13.BackColor = System.Drawing.SystemColors.Window
        Appearance13.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ucCodPostal.DisplayLayout.Appearance = Appearance13
        UltraGridColumn10.Header.VisiblePosition = 0
        UltraGridColumn11.Header.VisiblePosition = 1
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.VisiblePosition = 2
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.Header.VisiblePosition = 3
        UltraGridColumn13.Hidden = True
        UltraGridColumn13.Width = 166
        UltraGridColumn14.Header.VisiblePosition = 4
        UltraGridColumn14.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14})
        Me.ucCodPostal.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.ucCodPostal.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ucCodPostal.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ucCodPostal.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Appearance14.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance14.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance14.BorderColor = System.Drawing.SystemColors.Window
        Me.ucCodPostal.DisplayLayout.GroupByBox.Appearance = Appearance14
        Appearance15.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucCodPostal.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance15
        Me.ucCodPostal.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance16.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance16.BackColor2 = System.Drawing.SystemColors.Control
        Appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance16.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucCodPostal.DisplayLayout.GroupByBox.PromptAppearance = Appearance16
        Me.ucCodPostal.DisplayLayout.MaxColScrollRegions = 1
        Me.ucCodPostal.DisplayLayout.MaxRowScrollRegions = 1
        Appearance17.BackColor = System.Drawing.SystemColors.Window
        Appearance17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ucCodPostal.DisplayLayout.Override.ActiveCellAppearance = Appearance17
        Appearance18.BackColor = System.Drawing.SystemColors.Highlight
        Appearance18.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ucCodPostal.DisplayLayout.Override.ActiveRowAppearance = Appearance18
        Me.ucCodPostal.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ucCodPostal.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance19.BackColor = System.Drawing.SystemColors.Window
        Me.ucCodPostal.DisplayLayout.Override.CardAreaAppearance = Appearance19
        Appearance20.BorderColor = System.Drawing.Color.Silver
        Appearance20.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ucCodPostal.DisplayLayout.Override.CellAppearance = Appearance20
        Me.ucCodPostal.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ucCodPostal.DisplayLayout.Override.CellPadding = 0
        Appearance21.BackColor = System.Drawing.SystemColors.Control
        Appearance21.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance21.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance21.BorderColor = System.Drawing.SystemColors.Window
        Me.ucCodPostal.DisplayLayout.Override.GroupByRowAppearance = Appearance21
        Appearance22.TextHAlignAsString = "Left"
        Me.ucCodPostal.DisplayLayout.Override.HeaderAppearance = Appearance22
        Me.ucCodPostal.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ucCodPostal.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance23.BackColor = System.Drawing.SystemColors.Window
        Appearance23.BorderColor = System.Drawing.Color.Silver
        Me.ucCodPostal.DisplayLayout.Override.RowAppearance = Appearance23
        Me.ucCodPostal.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance24.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ucCodPostal.DisplayLayout.Override.TemplateAddRowAppearance = Appearance24
        Me.ucCodPostal.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ucCodPostal.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ucCodPostal.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.ucCodPostal.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.ucCodPostal.Location = New System.Drawing.Point(206, 265)
        Me.ucCodPostal.Name = "ucCodPostal"
        Me.ucCodPostal.Size = New System.Drawing.Size(137, 32)
        Me.ucCodPostal.TabIndex = 18
        '
        'EnderecoTextEdit
        '
        Me.EnderecoTextEdit.Location = New System.Drawing.Point(59, 345)
        Me.EnderecoTextEdit.Name = "EnderecoTextEdit"
        Me.EnderecoTextEdit.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.EnderecoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.EnderecoTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.EnderecoTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.EnderecoTextEdit.Properties.Appearance.Options.UseFont = True
        Me.EnderecoTextEdit.Properties.Appearance.Options.UseForeColor = True
        Me.EnderecoTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.EnderecoTextEdit.Size = New System.Drawing.Size(243, 28)
        Me.EnderecoTextEdit.TabIndex = 34
        '
        'picEndereco
        '
        Me.picEndereco.Enabled = False
        Me.picEndereco.Image = Global.G02_Nikola_04.My.Resources.Resources.Shade2
        Me.picEndereco.Location = New System.Drawing.Point(48, 340)
        Me.picEndereco.Name = "picEndereco"
        Me.picEndereco.Size = New System.Drawing.Size(266, 42)
        Me.picEndereco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEndereco.TabIndex = 36
        Me.picEndereco.TabStop = False
        '
        'CodPostalTextEdit
        '
        Me.CodPostalTextEdit.Location = New System.Drawing.Point(59, 265)
        Me.CodPostalTextEdit.Name = "CodPostalTextEdit"
        Me.CodPostalTextEdit.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.CodPostalTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.CodPostalTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.CodPostalTextEdit.Properties.Appearance.Options.UseFont = True
        Me.CodPostalTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.CodPostalTextEdit.Size = New System.Drawing.Size(103, 28)
        Me.CodPostalTextEdit.TabIndex = 31
        '
        'picCodPostal
        '
        Me.picCodPostal.Image = Global.G02_Nikola_04.My.Resources.Resources.ShadeSmall
        Me.picCodPostal.Location = New System.Drawing.Point(49, 260)
        Me.picCodPostal.Name = "picCodPostal"
        Me.picCodPostal.Size = New System.Drawing.Size(122, 42)
        Me.picCodPostal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCodPostal.TabIndex = 32
        Me.picCodPostal.TabStop = False
        '
        'LocalidadeTextEdit
        '
        Me.LocalidadeTextEdit.Location = New System.Drawing.Point(59, 189)
        Me.LocalidadeTextEdit.Name = "LocalidadeTextEdit"
        Me.LocalidadeTextEdit.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.LocalidadeTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.LocalidadeTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.LocalidadeTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.LocalidadeTextEdit.Properties.Appearance.Options.UseFont = True
        Me.LocalidadeTextEdit.Properties.Appearance.Options.UseForeColor = True
        Me.LocalidadeTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.LocalidadeTextEdit.Size = New System.Drawing.Size(265, 28)
        Me.LocalidadeTextEdit.TabIndex = 28
        '
        'picLocalidade
        '
        Me.picLocalidade.Enabled = False
        Me.picLocalidade.Image = Global.G02_Nikola_04.My.Resources.Resources.Shade
        Me.picLocalidade.Location = New System.Drawing.Point(48, 184)
        Me.picLocalidade.Name = "picLocalidade"
        Me.picLocalidade.Size = New System.Drawing.Size(288, 42)
        Me.picLocalidade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLocalidade.TabIndex = 30
        Me.picLocalidade.TabStop = False
        '
        'picDescritivo
        '
        Me.picDescritivo.Enabled = False
        Me.picDescritivo.Image = Global.G02_Nikola_04.My.Resources.Resources.Shade
        Me.picDescritivo.Location = New System.Drawing.Point(48, 107)
        Me.picDescritivo.Name = "picDescritivo"
        Me.picDescritivo.Size = New System.Drawing.Size(288, 42)
        Me.picDescritivo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDescritivo.TabIndex = 27
        Me.picDescritivo.TabStop = False
        '
        'CodEnderecoTextEdit
        '
        Me.CodEnderecoTextEdit.Enabled = False
        Me.CodEnderecoTextEdit.Location = New System.Drawing.Point(206, 41)
        Me.CodEnderecoTextEdit.Name = "CodEnderecoTextEdit"
        Me.CodEnderecoTextEdit.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.CodEnderecoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.CodEnderecoTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.CodEnderecoTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.CodEnderecoTextEdit.Properties.Appearance.Options.UseFont = True
        Me.CodEnderecoTextEdit.Properties.Appearance.Options.UseForeColor = True
        Me.CodEnderecoTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.CodEnderecoTextEdit.Size = New System.Drawing.Size(77, 28)
        Me.CodEnderecoTextEdit.TabIndex = 21
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.G02_Nikola_04.My.Resources.Resources.ShadeSmall
        Me.PictureBox1.Location = New System.Drawing.Point(196, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(96, 42)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'DataRegistoDateEdit
        '
        Me.DataRegistoDateEdit.EditValue = Nothing
        Me.DataRegistoDateEdit.Location = New System.Drawing.Point(388, 354)
        Me.DataRegistoDateEdit.Name = "DataRegistoDateEdit"
        Me.DataRegistoDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DataRegistoDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DataRegistoDateEdit.Size = New System.Drawing.Size(134, 20)
        Me.DataRegistoDateEdit.TabIndex = 13
        '
        'CodEntidadeTextEdit
        '
        Me.CodEntidadeTextEdit.Enabled = False
        Me.CodEntidadeTextEdit.Location = New System.Drawing.Point(59, 41)
        Me.CodEntidadeTextEdit.Name = "CodEntidadeTextEdit"
        Me.CodEntidadeTextEdit.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.CodEntidadeTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.CodEntidadeTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.CodEntidadeTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.CodEntidadeTextEdit.Properties.Appearance.Options.UseFont = True
        Me.CodEntidadeTextEdit.Properties.Appearance.Options.UseForeColor = True
        Me.CodEntidadeTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.CodEntidadeTextEdit.Size = New System.Drawing.Size(77, 28)
        Me.CodEntidadeTextEdit.TabIndex = 1
        '
        'picCodEntidade
        '
        Me.picCodEntidade.Image = Global.G02_Nikola_04.My.Resources.Resources.ShadeSmall
        Me.picCodEntidade.Location = New System.Drawing.Point(49, 36)
        Me.picCodEntidade.Name = "picCodEntidade"
        Me.picCodEntidade.Size = New System.Drawing.Size(96, 42)
        Me.picCodEntidade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCodEntidade.TabIndex = 20
        Me.picCodEntidade.TabStop = False
        '
        'frmEndereco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 494)
        Me.Controls.Add(Me.pnMain)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEndereco"
        Me.Text = "frmEndereco1"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnMain.ResumeLayout(False)
        Me.pnMain.PerformLayout()
        CType(Me.DescritivoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucLocalidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucCodPostal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnderecoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEndereco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodPostalTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCodPostal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalidadeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLocalidade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDescritivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodEnderecoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataRegistoDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataRegistoDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodEntidadeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCodEntidade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarNAV As DevExpress.XtraBars.Bar
    Friend WithEvents Bar4 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar5 As DevExpress.XtraBars.Bar
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents bbStatus As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents bbNovo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbModifica As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbApaga As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbSair As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbGrava As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbCancela As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents bbPrimeiro As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbAnterior As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbSeguinte As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbUltimo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents pnMain As Panel
    Friend WithEvents cmbDescritivo As ComboBox
    Friend WithEvents ucLocalidades As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents ucCodPostal As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents EnderecoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents picEndereco As PictureBox
    Friend WithEvents CodPostalTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents picCodPostal As PictureBox
    Friend WithEvents LocalidadeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents picLocalidade As PictureBox
    Friend WithEvents DescritivoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents picDescritivo As PictureBox
    Friend WithEvents CodEnderecoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataRegistoDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents CodEntidadeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents picCodEntidade As PictureBox
End Class
