<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucFaturacao
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
        Dim Cod_EntidadeLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("ClsQI", -1)
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Num_Doc")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo IVA")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Sujeito IVA")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Valor IVA")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Taxa IVA")
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
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("ClsLinhas", -1)
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Num_Doc")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Entidade")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Num_Linha")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("strNum_Linha")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Consulta")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consulta")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Quantidade")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("strQuantidade")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Artigo")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Unidade")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Artigo")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("strP_Unitario")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("P_Unitario")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Taxa_Desconto")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("strTaxa_Desconto")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Taxa_IVA")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("strTaxa_IVA")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Valor_Iliquido")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("strValor_Iliquido")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Valor_Desconto")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Valor_IVA")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Feita")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_PS")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Ativo")
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
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("ClsTipos_Pagamento", -1)
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Tipo_Pagamento")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo_Pagamento")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Imagem")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Ativo")
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("ClsEntidades", -1)
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Entidade")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Entidade")
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nome")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Pais")
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Num_Telefone")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Num_Telemovel")
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Email")
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NIF")
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Utilizador")
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Data_Registo")
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Password")
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fotografia")
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Contador_Enderecos")
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Ativo")
        Dim UltraGridColumn104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Lista_Enderecos")
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Lista_Enderecos", 0)
        Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Entidade")
        Dim UltraGridColumn106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Endereco")
        Dim UltraGridColumn107 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descritivo")
        Dim UltraGridColumn108 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Endereco")
        Dim UltraGridColumn109 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Postal")
        Dim UltraGridColumn110 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Localidade")
        Dim UltraGridColumn111 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Data_Registo")
        Dim UltraGridColumn112 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Ativo")
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.testBTN = New System.Windows.Forms.Button()
        Me.btnProxPag = New System.Windows.Forms.Button()
        Me.gpTotais = New System.Windows.Forms.GroupBox()
        Me.lblTotalAPagar = New System.Windows.Forms.Label()
        Me.lblTotalIVA = New System.Windows.Forms.Label()
        Me.lblTotalDesconto = New System.Windows.Forms.Label()
        Me.lblTotalIliquido = New System.Windows.Forms.Label()
        Me.lblTotal4 = New System.Windows.Forms.Label()
        Me.lblTotal3 = New System.Windows.Forms.Label()
        Me.lblTotal2 = New System.Windows.Forms.Label()
        Me.lblTotal1 = New System.Windows.Forms.Label()
        Me.ugQI = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.ugLinhas = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.LocalidadeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.CodPostalTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.EnderecoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.NIFTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.NomeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.btnVoltar = New System.Windows.Forms.Button()
        Me.ucTP = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.ucClientes = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.pnMain = New System.Windows.Forms.Panel()
        Me.pnPesquisa = New System.Windows.Forms.Panel()
        Me.btnPesquisa = New System.Windows.Forms.Button()
        Me.txtPesquisa = New System.Windows.Forms.TextBox()
        Me.picPesquisa = New System.Windows.Forms.PictureBox()
        Me.pnArtigos = New System.Windows.Forms.Panel()
        Me.UltraLiveTileView = New Infragistics.Win.UltraWinLiveTileView.UltraLiveTileView()
        Me.pnFaturacao = New System.Windows.Forms.Panel()
        Me.UltraTabControl = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Cod_EntidadeLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Me.UltraTabPageControl.SuspendLayout()
        Me.gpTotais.SuspendLayout()
        CType(Me.ugQI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ugLinhas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.LocalidadeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodPostalTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnderecoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NIFTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NomeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucTP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnMain.SuspendLayout()
        Me.pnPesquisa.SuspendLayout()
        CType(Me.picPesquisa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnArtigos.SuspendLayout()
        CType(Me.UltraLiveTileView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnFaturacao.SuspendLayout()
        CType(Me.UltraTabControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cod_EntidadeLabel
        '
        Cod_EntidadeLabel.AutoSize = True
        Cod_EntidadeLabel.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Cod_EntidadeLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Cod_EntidadeLabel.Location = New System.Drawing.Point(132, 101)
        Cod_EntidadeLabel.Name = "Cod_EntidadeLabel"
        Cod_EntidadeLabel.Size = New System.Drawing.Size(115, 17)
        Cod_EntidadeLabel.TabIndex = 2
        Cod_EntidadeLabel.Text = "Código do Cliente"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Label4.Location = New System.Drawing.Point(5, 428)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(71, 17)
        Label4.TabIndex = 113
        Label4.Text = "Localidade"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Label3.Location = New System.Drawing.Point(202, 248)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(91, 17)
        Label3.TabIndex = 110
        Label3.Text = "Código Postal"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Label2.Location = New System.Drawing.Point(5, 334)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(66, 17)
        Label2.TabIndex = 107
        Label2.Text = "Endereço"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Label7.Location = New System.Drawing.Point(5, 248)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(28, 17)
        Label7.TabIndex = 104
        Label7.Text = "NIF"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Label1.Location = New System.Drawing.Point(131, 526)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(127, 17)
        Label1.TabIndex = 97
        Label1.Text = "Tipo de Pagamento"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Label6.Location = New System.Drawing.Point(5, 168)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(44, 17)
        Label6.TabIndex = 95
        Label6.Text = "Nome"
        '
        'UltraTabPageControl
        '
        Me.UltraTabPageControl.Controls.Add(Me.testBTN)
        Me.UltraTabPageControl.Controls.Add(Me.btnProxPag)
        Me.UltraTabPageControl.Controls.Add(Me.gpTotais)
        Me.UltraTabPageControl.Controls.Add(Me.ugQI)
        Me.UltraTabPageControl.Controls.Add(Me.ugLinhas)
        Me.UltraTabPageControl.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabPageControl.Name = "UltraTabPageControl"
        Me.UltraTabPageControl.Size = New System.Drawing.Size(383, 1020)
        '
        'testBTN
        '
        Me.testBTN.Location = New System.Drawing.Point(251, 663)
        Me.testBTN.Name = "testBTN"
        Me.testBTN.Size = New System.Drawing.Size(75, 23)
        Me.testBTN.TabIndex = 4
        Me.testBTN.Text = "Test"
        Me.testBTN.UseVisualStyleBackColor = True
        Me.testBTN.Visible = False
        '
        'btnProxPag
        '
        Me.btnProxPag.BackgroundImage = Global.G02_Gustavo_02.My.Resources.Resources.ProximoArtigos
        Me.btnProxPag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnProxPag.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProxPag.FlatAppearance.BorderSize = 0
        Me.btnProxPag.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnProxPag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnProxPag.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProxPag.Location = New System.Drawing.Point(127, 720)
        Me.btnProxPag.Name = "btnProxPag"
        Me.btnProxPag.Size = New System.Drawing.Size(159, 51)
        Me.btnProxPag.TabIndex = 3
        Me.btnProxPag.UseVisualStyleBackColor = True
        '
        'gpTotais
        '
        Me.gpTotais.BackColor = System.Drawing.Color.SeaShell
        Me.gpTotais.Controls.Add(Me.lblTotalAPagar)
        Me.gpTotais.Controls.Add(Me.lblTotalIVA)
        Me.gpTotais.Controls.Add(Me.lblTotalDesconto)
        Me.gpTotais.Controls.Add(Me.lblTotalIliquido)
        Me.gpTotais.Controls.Add(Me.lblTotal4)
        Me.gpTotais.Controls.Add(Me.lblTotal3)
        Me.gpTotais.Controls.Add(Me.lblTotal2)
        Me.gpTotais.Controls.Add(Me.lblTotal1)
        Me.gpTotais.Location = New System.Drawing.Point(77, 484)
        Me.gpTotais.Name = "gpTotais"
        Me.gpTotais.Size = New System.Drawing.Size(241, 173)
        Me.gpTotais.TabIndex = 2
        Me.gpTotais.TabStop = False
        Me.gpTotais.Text = "Totais"
        '
        'lblTotalAPagar
        '
        Me.lblTotalAPagar.BackColor = System.Drawing.Color.Bisque
        Me.lblTotalAPagar.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lblTotalAPagar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.lblTotalAPagar.Location = New System.Drawing.Point(135, 132)
        Me.lblTotalAPagar.Name = "lblTotalAPagar"
        Me.lblTotalAPagar.Size = New System.Drawing.Size(100, 25)
        Me.lblTotalAPagar.TabIndex = 7
        Me.lblTotalAPagar.Text = "0,00€"
        Me.lblTotalAPagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalIVA
        '
        Me.lblTotalIVA.BackColor = System.Drawing.Color.Bisque
        Me.lblTotalIVA.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lblTotalIVA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.lblTotalIVA.Location = New System.Drawing.Point(135, 97)
        Me.lblTotalIVA.Name = "lblTotalIVA"
        Me.lblTotalIVA.Size = New System.Drawing.Size(100, 25)
        Me.lblTotalIVA.TabIndex = 6
        Me.lblTotalIVA.Text = "0,00€"
        Me.lblTotalIVA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalDesconto
        '
        Me.lblTotalDesconto.BackColor = System.Drawing.Color.Bisque
        Me.lblTotalDesconto.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lblTotalDesconto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.lblTotalDesconto.Location = New System.Drawing.Point(135, 63)
        Me.lblTotalDesconto.Name = "lblTotalDesconto"
        Me.lblTotalDesconto.Size = New System.Drawing.Size(100, 25)
        Me.lblTotalDesconto.TabIndex = 5
        Me.lblTotalDesconto.Text = "0,00€"
        Me.lblTotalDesconto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalIliquido
        '
        Me.lblTotalIliquido.BackColor = System.Drawing.Color.Bisque
        Me.lblTotalIliquido.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lblTotalIliquido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.lblTotalIliquido.Location = New System.Drawing.Point(135, 28)
        Me.lblTotalIliquido.Name = "lblTotalIliquido"
        Me.lblTotalIliquido.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalIliquido.TabIndex = 4
        Me.lblTotalIliquido.Text = "0,00€"
        Me.lblTotalIliquido.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotal4
        '
        Me.lblTotal4.BackColor = System.Drawing.Color.Chocolate
        Me.lblTotal4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal4.ForeColor = System.Drawing.Color.White
        Me.lblTotal4.Location = New System.Drawing.Point(6, 132)
        Me.lblTotal4.Name = "lblTotal4"
        Me.lblTotal4.Padding = New System.Windows.Forms.Padding(3)
        Me.lblTotal4.Size = New System.Drawing.Size(121, 25)
        Me.lblTotal4.TabIndex = 3
        Me.lblTotal4.Text = "Total a Pagar"
        Me.lblTotal4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotal3
        '
        Me.lblTotal3.BackColor = System.Drawing.Color.Chocolate
        Me.lblTotal3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal3.ForeColor = System.Drawing.Color.White
        Me.lblTotal3.Location = New System.Drawing.Point(6, 97)
        Me.lblTotal3.Name = "lblTotal3"
        Me.lblTotal3.Padding = New System.Windows.Forms.Padding(3)
        Me.lblTotal3.Size = New System.Drawing.Size(121, 25)
        Me.lblTotal3.TabIndex = 2
        Me.lblTotal3.Text = "Total IVA"
        Me.lblTotal3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotal2
        '
        Me.lblTotal2.BackColor = System.Drawing.Color.Chocolate
        Me.lblTotal2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal2.ForeColor = System.Drawing.Color.White
        Me.lblTotal2.Location = New System.Drawing.Point(6, 63)
        Me.lblTotal2.Name = "lblTotal2"
        Me.lblTotal2.Padding = New System.Windows.Forms.Padding(3)
        Me.lblTotal2.Size = New System.Drawing.Size(121, 25)
        Me.lblTotal2.TabIndex = 1
        Me.lblTotal2.Text = "Total Desconto"
        Me.lblTotal2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotal1
        '
        Me.lblTotal1.BackColor = System.Drawing.Color.Chocolate
        Me.lblTotal1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal1.ForeColor = System.Drawing.Color.White
        Me.lblTotal1.Location = New System.Drawing.Point(6, 28)
        Me.lblTotal1.Name = "lblTotal1"
        Me.lblTotal1.Padding = New System.Windows.Forms.Padding(3)
        Me.lblTotal1.Size = New System.Drawing.Size(121, 23)
        Me.lblTotal1.TabIndex = 0
        Me.lblTotal1.Text = "Total Ilíquido"
        Me.lblTotal1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ugQI
        '
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ugQI.DisplayLayout.Appearance = Appearance1
        UltraGridColumn28.Header.VisiblePosition = 0
        UltraGridColumn28.Hidden = True
        UltraGridColumn29.Header.VisiblePosition = 1
        UltraGridColumn29.Width = 60
        UltraGridColumn30.Header.VisiblePosition = 2
        UltraGridColumn30.Width = 79
        UltraGridColumn31.Header.VisiblePosition = 3
        UltraGridColumn31.Width = 79
        UltraGridColumn32.Header.VisiblePosition = 4
        UltraGridColumn32.Width = 76
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32})
        Me.ugQI.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ugQI.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ugQI.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.ugQI.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugQI.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.ugQI.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugQI.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
        Me.ugQI.DisplayLayout.MaxColScrollRegions = 1
        Me.ugQI.DisplayLayout.MaxRowScrollRegions = 1
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ugQI.DisplayLayout.Override.ActiveCellAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.SystemColors.Highlight
        Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ugQI.DisplayLayout.Override.ActiveRowAppearance = Appearance6
        Me.ugQI.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ugQI.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Me.ugQI.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ugQI.DisplayLayout.Override.CellAppearance = Appearance8
        Me.ugQI.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ugQI.DisplayLayout.Override.CellPadding = 0
        Appearance9.BackColor = System.Drawing.SystemColors.Control
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.ugQI.DisplayLayout.Override.GroupByRowAppearance = Appearance9
        Appearance10.TextHAlignAsString = "Left"
        Me.ugQI.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.ugQI.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ugQI.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance11.BackColor = System.Drawing.SystemColors.Window
        Appearance11.BorderColor = System.Drawing.Color.Silver
        Me.ugQI.DisplayLayout.Override.RowAppearance = Appearance11
        Me.ugQI.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ugQI.DisplayLayout.Override.TemplateAddRowAppearance = Appearance12
        Me.ugQI.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ugQI.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ugQI.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.ugQI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ugQI.Location = New System.Drawing.Point(39, 310)
        Me.ugQI.Name = "ugQI"
        Me.ugQI.Size = New System.Drawing.Size(311, 124)
        Me.ugQI.TabIndex = 1
        Me.ugQI.Text = "UltraGrid1"
        '
        'ugLinhas
        '
        Appearance13.BackColor = System.Drawing.SystemColors.Window
        Appearance13.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ugLinhas.DisplayLayout.Appearance = Appearance13
        UltraGridColumn33.Header.VisiblePosition = 0
        UltraGridColumn33.Hidden = True
        UltraGridColumn34.Header.VisiblePosition = 1
        UltraGridColumn34.Hidden = True
        UltraGridColumn35.Header.VisiblePosition = 2
        UltraGridColumn35.Hidden = True
        UltraGridColumn36.Header.Caption = "Nº"
        UltraGridColumn36.Header.VisiblePosition = 3
        UltraGridColumn36.Width = 34
        UltraGridColumn37.Header.VisiblePosition = 4
        UltraGridColumn37.Hidden = True
        UltraGridColumn38.Header.VisiblePosition = 5
        UltraGridColumn38.Hidden = True
        UltraGridColumn39.Header.VisiblePosition = 6
        UltraGridColumn39.Hidden = True
        UltraGridColumn40.Header.Caption = "QTD"
        UltraGridColumn40.Header.VisiblePosition = 7
        UltraGridColumn40.Width = 53
        UltraGridColumn41.Header.VisiblePosition = 8
        UltraGridColumn41.Hidden = True
        UltraGridColumn42.Header.VisiblePosition = 9
        UltraGridColumn42.Hidden = True
        UltraGridColumn43.Header.VisiblePosition = 10
        UltraGridColumn43.Width = 184
        UltraGridColumn44.Header.Caption = "P Unitario"
        UltraGridColumn44.Header.VisiblePosition = 11
        UltraGridColumn44.Width = 66
        UltraGridColumn45.Header.Caption = "P Unitario"
        UltraGridColumn45.Header.VisiblePosition = 12
        UltraGridColumn45.Hidden = True
        UltraGridColumn46.Header.VisiblePosition = 13
        UltraGridColumn46.Hidden = True
        UltraGridColumn47.Header.Caption = "%DSC"
        UltraGridColumn47.Header.VisiblePosition = 14
        UltraGridColumn47.Width = 55
        UltraGridColumn48.Header.VisiblePosition = 15
        UltraGridColumn48.Hidden = True
        UltraGridColumn49.Header.Caption = "%IVA"
        UltraGridColumn49.Header.VisiblePosition = 16
        UltraGridColumn49.Width = 51
        UltraGridColumn50.Header.VisiblePosition = 17
        UltraGridColumn50.Hidden = True
        UltraGridColumn51.Header.Caption = "Valor Iliquido"
        UltraGridColumn51.Header.VisiblePosition = 18
        UltraGridColumn52.Header.VisiblePosition = 19
        UltraGridColumn52.Hidden = True
        UltraGridColumn53.Header.VisiblePosition = 20
        UltraGridColumn53.Hidden = True
        UltraGridColumn54.Header.VisiblePosition = 21
        UltraGridColumn54.Hidden = True
        UltraGridColumn55.Header.VisiblePosition = 22
        UltraGridColumn55.Hidden = True
        UltraGridColumn56.Header.VisiblePosition = 23
        UltraGridColumn56.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56})
        Me.ugLinhas.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.ugLinhas.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ugLinhas.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance14.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance14.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance14.BorderColor = System.Drawing.SystemColors.Window
        Me.ugLinhas.DisplayLayout.GroupByBox.Appearance = Appearance14
        Appearance15.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugLinhas.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance15
        Me.ugLinhas.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance16.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance16.BackColor2 = System.Drawing.SystemColors.Control
        Appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance16.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugLinhas.DisplayLayout.GroupByBox.PromptAppearance = Appearance16
        Me.ugLinhas.DisplayLayout.MaxColScrollRegions = 1
        Me.ugLinhas.DisplayLayout.MaxRowScrollRegions = 1
        Appearance17.BackColor = System.Drawing.SystemColors.Window
        Appearance17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ugLinhas.DisplayLayout.Override.ActiveCellAppearance = Appearance17
        Appearance18.BackColor = System.Drawing.SystemColors.Highlight
        Appearance18.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ugLinhas.DisplayLayout.Override.ActiveRowAppearance = Appearance18
        Me.ugLinhas.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ugLinhas.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance19.BackColor = System.Drawing.SystemColors.Window
        Me.ugLinhas.DisplayLayout.Override.CardAreaAppearance = Appearance19
        Appearance20.BorderColor = System.Drawing.Color.Silver
        Appearance20.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ugLinhas.DisplayLayout.Override.CellAppearance = Appearance20
        Me.ugLinhas.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ugLinhas.DisplayLayout.Override.CellPadding = 0
        Appearance21.BackColor = System.Drawing.SystemColors.Control
        Appearance21.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance21.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance21.BorderColor = System.Drawing.SystemColors.Window
        Me.ugLinhas.DisplayLayout.Override.GroupByRowAppearance = Appearance21
        Appearance22.TextHAlignAsString = "Left"
        Me.ugLinhas.DisplayLayout.Override.HeaderAppearance = Appearance22
        Me.ugLinhas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ugLinhas.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance23.BackColor = System.Drawing.SystemColors.Window
        Appearance23.BorderColor = System.Drawing.Color.Silver
        Me.ugLinhas.DisplayLayout.Override.RowAppearance = Appearance23
        Me.ugLinhas.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance24.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ugLinhas.DisplayLayout.Override.TemplateAddRowAppearance = Appearance24
        Me.ugLinhas.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ugLinhas.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ugLinhas.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.ugLinhas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ugLinhas.Location = New System.Drawing.Point(29, 45)
        Me.ugLinhas.Name = "ugLinhas"
        Me.ugLinhas.Size = New System.Drawing.Size(340, 226)
        Me.ugLinhas.TabIndex = 0
        Me.ugLinhas.Text = "UltraGrid1"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.LocalidadeTextEdit)
        Me.UltraTabPageControl2.Controls.Add(Label4)
        Me.UltraTabPageControl2.Controls.Add(Me.PictureBox4)
        Me.UltraTabPageControl2.Controls.Add(Me.CodPostalTextEdit)
        Me.UltraTabPageControl2.Controls.Add(Label3)
        Me.UltraTabPageControl2.Controls.Add(Me.PictureBox2)
        Me.UltraTabPageControl2.Controls.Add(Me.EnderecoTextEdit)
        Me.UltraTabPageControl2.Controls.Add(Label2)
        Me.UltraTabPageControl2.Controls.Add(Me.PictureBox1)
        Me.UltraTabPageControl2.Controls.Add(Me.NIFTextEdit)
        Me.UltraTabPageControl2.Controls.Add(Label7)
        Me.UltraTabPageControl2.Controls.Add(Me.PictureBox3)
        Me.UltraTabPageControl2.Controls.Add(Label1)
        Me.UltraTabPageControl2.Controls.Add(Me.NomeTextEdit)
        Me.UltraTabPageControl2.Controls.Add(Label6)
        Me.UltraTabPageControl2.Controls.Add(Me.PictureBox5)
        Me.UltraTabPageControl2.Controls.Add(Me.btnVoltar)
        Me.UltraTabPageControl2.Controls.Add(Me.ucTP)
        Me.UltraTabPageControl2.Controls.Add(Me.ucClientes)
        Me.UltraTabPageControl2.Controls.Add(Cod_EntidadeLabel)
        Me.UltraTabPageControl2.Controls.Add(Me.btnImprimir)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(383, 1020)
        '
        'LocalidadeTextEdit
        '
        Me.LocalidadeTextEdit.Enabled = False
        Me.LocalidadeTextEdit.Location = New System.Drawing.Point(17, 455)
        Me.LocalidadeTextEdit.Name = "LocalidadeTextEdit"
        Me.LocalidadeTextEdit.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.LocalidadeTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.LocalidadeTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.LocalidadeTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.LocalidadeTextEdit.Properties.Appearance.Options.UseFont = True
        Me.LocalidadeTextEdit.Properties.Appearance.Options.UseForeColor = True
        Me.LocalidadeTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.LocalidadeTextEdit.Size = New System.Drawing.Size(351, 28)
        Me.LocalidadeTextEdit.TabIndex = 112
        '
        'PictureBox4
        '
        Me.PictureBox4.Enabled = False
        Me.PictureBox4.Image = Global.G02_Gustavo_02.My.Resources.Resources.Shade2
        Me.PictureBox4.Location = New System.Drawing.Point(6, 448)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(374, 42)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 114
        Me.PictureBox4.TabStop = False
        '
        'CodPostalTextEdit
        '
        Me.CodPostalTextEdit.Enabled = False
        Me.CodPostalTextEdit.Location = New System.Drawing.Point(214, 275)
        Me.CodPostalTextEdit.Name = "CodPostalTextEdit"
        Me.CodPostalTextEdit.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.CodPostalTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.CodPostalTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.CodPostalTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.CodPostalTextEdit.Properties.Appearance.Options.UseFont = True
        Me.CodPostalTextEdit.Properties.Appearance.Options.UseForeColor = True
        Me.CodPostalTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.CodPostalTextEdit.Size = New System.Drawing.Size(154, 28)
        Me.CodPostalTextEdit.TabIndex = 109
        '
        'PictureBox2
        '
        Me.PictureBox2.Enabled = False
        Me.PictureBox2.Image = Global.G02_Gustavo_02.My.Resources.Resources.Shade1
        Me.PictureBox2.Location = New System.Drawing.Point(203, 268)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(177, 42)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 111
        Me.PictureBox2.TabStop = False
        '
        'EnderecoTextEdit
        '
        Me.EnderecoTextEdit.Enabled = False
        Me.EnderecoTextEdit.Location = New System.Drawing.Point(17, 361)
        Me.EnderecoTextEdit.Name = "EnderecoTextEdit"
        Me.EnderecoTextEdit.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.EnderecoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.EnderecoTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.EnderecoTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.EnderecoTextEdit.Properties.Appearance.Options.UseFont = True
        Me.EnderecoTextEdit.Properties.Appearance.Options.UseForeColor = True
        Me.EnderecoTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.EnderecoTextEdit.Size = New System.Drawing.Size(351, 28)
        Me.EnderecoTextEdit.TabIndex = 106
        '
        'PictureBox1
        '
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Image = Global.G02_Gustavo_02.My.Resources.Resources.Shade2
        Me.PictureBox1.Location = New System.Drawing.Point(6, 354)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(374, 42)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 108
        Me.PictureBox1.TabStop = False
        '
        'NIFTextEdit
        '
        Me.NIFTextEdit.Enabled = False
        Me.NIFTextEdit.Location = New System.Drawing.Point(17, 275)
        Me.NIFTextEdit.Name = "NIFTextEdit"
        Me.NIFTextEdit.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.NIFTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.NIFTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.NIFTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.NIFTextEdit.Properties.Appearance.Options.UseFont = True
        Me.NIFTextEdit.Properties.Appearance.Options.UseForeColor = True
        Me.NIFTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.NIFTextEdit.Size = New System.Drawing.Size(154, 28)
        Me.NIFTextEdit.TabIndex = 103
        '
        'PictureBox3
        '
        Me.PictureBox3.Enabled = False
        Me.PictureBox3.Image = Global.G02_Gustavo_02.My.Resources.Resources.Shade1
        Me.PictureBox3.Location = New System.Drawing.Point(6, 268)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(177, 42)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 105
        Me.PictureBox3.TabStop = False
        '
        'NomeTextEdit
        '
        Me.NomeTextEdit.Enabled = False
        Me.NomeTextEdit.Location = New System.Drawing.Point(17, 195)
        Me.NomeTextEdit.Name = "NomeTextEdit"
        Me.NomeTextEdit.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.NomeTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.NomeTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.NomeTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.NomeTextEdit.Properties.Appearance.Options.UseFont = True
        Me.NomeTextEdit.Properties.Appearance.Options.UseForeColor = True
        Me.NomeTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.NomeTextEdit.Size = New System.Drawing.Size(351, 28)
        Me.NomeTextEdit.TabIndex = 94
        '
        'PictureBox5
        '
        Me.PictureBox5.Enabled = False
        Me.PictureBox5.Image = Global.G02_Gustavo_02.My.Resources.Resources.Shade2
        Me.PictureBox5.Location = New System.Drawing.Point(6, 188)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(374, 42)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 96
        Me.PictureBox5.TabStop = False
        '
        'btnVoltar
        '
        Me.btnVoltar.BackColor = System.Drawing.Color.Transparent
        Me.btnVoltar.BackgroundImage = Global.G02_Gustavo_02.My.Resources.Resources.VoltarArtigos
        Me.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVoltar.CausesValidation = False
        Me.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVoltar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnVoltar.FlatAppearance.BorderSize = 0
        Me.btnVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVoltar.Location = New System.Drawing.Point(221, 908)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(159, 51)
        Me.btnVoltar.TabIndex = 19
        Me.btnVoltar.UseVisualStyleBackColor = False
        '
        'ucTP
        '
        Appearance25.BackColor = System.Drawing.SystemColors.Window
        Appearance25.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ucTP.DisplayLayout.Appearance = Appearance25
        UltraGridColumn57.Header.Caption = "Codigo"
        UltraGridColumn57.Header.VisiblePosition = 0
        UltraGridColumn57.Width = 64
        UltraGridColumn58.Header.Caption = "Tipo de Pagamento"
        UltraGridColumn58.Header.VisiblePosition = 1
        UltraGridColumn59.Header.VisiblePosition = 2
        UltraGridColumn59.Hidden = True
        UltraGridColumn60.Header.VisiblePosition = 3
        UltraGridColumn60.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60})
        Me.ucTP.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.ucTP.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ucTP.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance26.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance26.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance26.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance26.BorderColor = System.Drawing.SystemColors.Window
        Me.ucTP.DisplayLayout.GroupByBox.Appearance = Appearance26
        Appearance27.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucTP.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance27
        Me.ucTP.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance28.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance28.BackColor2 = System.Drawing.SystemColors.Control
        Appearance28.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance28.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucTP.DisplayLayout.GroupByBox.PromptAppearance = Appearance28
        Me.ucTP.DisplayLayout.MaxColScrollRegions = 1
        Me.ucTP.DisplayLayout.MaxRowScrollRegions = 1
        Appearance29.BackColor = System.Drawing.SystemColors.Window
        Appearance29.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ucTP.DisplayLayout.Override.ActiveCellAppearance = Appearance29
        Appearance30.BackColor = System.Drawing.SystemColors.Highlight
        Appearance30.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ucTP.DisplayLayout.Override.ActiveRowAppearance = Appearance30
        Me.ucTP.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ucTP.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance31.BackColor = System.Drawing.SystemColors.Window
        Me.ucTP.DisplayLayout.Override.CardAreaAppearance = Appearance31
        Appearance32.BorderColor = System.Drawing.Color.Silver
        Appearance32.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ucTP.DisplayLayout.Override.CellAppearance = Appearance32
        Me.ucTP.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ucTP.DisplayLayout.Override.CellPadding = 0
        Appearance33.BackColor = System.Drawing.SystemColors.Control
        Appearance33.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance33.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance33.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance33.BorderColor = System.Drawing.SystemColors.Window
        Me.ucTP.DisplayLayout.Override.GroupByRowAppearance = Appearance33
        Appearance34.TextHAlignAsString = "Left"
        Me.ucTP.DisplayLayout.Override.HeaderAppearance = Appearance34
        Me.ucTP.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ucTP.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance35.BackColor = System.Drawing.SystemColors.Window
        Appearance35.BorderColor = System.Drawing.Color.Silver
        Me.ucTP.DisplayLayout.Override.RowAppearance = Appearance35
        Me.ucTP.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance36.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ucTP.DisplayLayout.Override.TemplateAddRowAppearance = Appearance36
        Me.ucTP.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ucTP.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ucTP.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.ucTP.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.ucTP.Location = New System.Drawing.Point(135, 546)
        Me.ucTP.Name = "ucTP"
        Me.ucTP.Size = New System.Drawing.Size(139, 35)
        Me.ucTP.TabIndex = 14
        '
        'ucClientes
        '
        Appearance37.BackColor = System.Drawing.SystemColors.Window
        Appearance37.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ucClientes.DisplayLayout.Appearance = Appearance37
        UltraGridColumn61.Header.Caption = "Codigo"
        UltraGridColumn61.Header.VisiblePosition = 0
        UltraGridColumn61.Width = 72
        UltraGridColumn62.Header.VisiblePosition = 1
        UltraGridColumn62.Hidden = True
        UltraGridColumn63.Header.VisiblePosition = 2
        UltraGridColumn63.Width = 228
        UltraGridColumn64.Header.VisiblePosition = 3
        UltraGridColumn64.Hidden = True
        UltraGridColumn65.Header.VisiblePosition = 4
        UltraGridColumn65.Hidden = True
        UltraGridColumn66.Header.VisiblePosition = 5
        UltraGridColumn66.Hidden = True
        UltraGridColumn67.Header.VisiblePosition = 6
        UltraGridColumn67.Hidden = True
        UltraGridColumn68.Header.VisiblePosition = 7
        UltraGridColumn68.Hidden = True
        UltraGridColumn69.Header.VisiblePosition = 8
        UltraGridColumn69.Hidden = True
        UltraGridColumn70.Header.VisiblePosition = 9
        UltraGridColumn70.Hidden = True
        UltraGridColumn71.Header.VisiblePosition = 10
        UltraGridColumn71.Hidden = True
        UltraGridColumn72.Header.VisiblePosition = 11
        UltraGridColumn72.Hidden = True
        UltraGridColumn73.Header.VisiblePosition = 12
        UltraGridColumn73.Hidden = True
        UltraGridColumn103.Header.VisiblePosition = 13
        UltraGridColumn103.Hidden = True
        UltraGridColumn104.Header.VisiblePosition = 14
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68, UltraGridColumn69, UltraGridColumn70, UltraGridColumn71, UltraGridColumn72, UltraGridColumn73, UltraGridColumn103, UltraGridColumn104})
        UltraGridColumn105.Header.VisiblePosition = 0
        UltraGridColumn105.Width = 53
        UltraGridColumn106.Header.VisiblePosition = 1
        UltraGridColumn106.Width = 228
        UltraGridColumn107.Header.VisiblePosition = 2
        UltraGridColumn108.Header.VisiblePosition = 3
        UltraGridColumn109.Header.VisiblePosition = 4
        UltraGridColumn110.Header.VisiblePosition = 5
        UltraGridColumn111.Header.VisiblePosition = 6
        UltraGridColumn112.Header.VisiblePosition = 7
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn105, UltraGridColumn106, UltraGridColumn107, UltraGridColumn108, UltraGridColumn109, UltraGridColumn110, UltraGridColumn111, UltraGridColumn112})
        Me.ucClientes.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.ucClientes.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.ucClientes.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ucClientes.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance38.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance38.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance38.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance38.BorderColor = System.Drawing.SystemColors.Window
        Me.ucClientes.DisplayLayout.GroupByBox.Appearance = Appearance38
        Appearance39.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucClientes.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance39
        Me.ucClientes.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance40.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance40.BackColor2 = System.Drawing.SystemColors.Control
        Appearance40.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance40.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucClientes.DisplayLayout.GroupByBox.PromptAppearance = Appearance40
        Me.ucClientes.DisplayLayout.MaxColScrollRegions = 1
        Me.ucClientes.DisplayLayout.MaxRowScrollRegions = 1
        Appearance41.BackColor = System.Drawing.SystemColors.Window
        Appearance41.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ucClientes.DisplayLayout.Override.ActiveCellAppearance = Appearance41
        Appearance42.BackColor = System.Drawing.SystemColors.Highlight
        Appearance42.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ucClientes.DisplayLayout.Override.ActiveRowAppearance = Appearance42
        Me.ucClientes.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ucClientes.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance43.BackColor = System.Drawing.SystemColors.Window
        Me.ucClientes.DisplayLayout.Override.CardAreaAppearance = Appearance43
        Appearance44.BorderColor = System.Drawing.Color.Silver
        Appearance44.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ucClientes.DisplayLayout.Override.CellAppearance = Appearance44
        Me.ucClientes.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ucClientes.DisplayLayout.Override.CellPadding = 0
        Appearance45.BackColor = System.Drawing.SystemColors.Control
        Appearance45.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance45.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance45.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance45.BorderColor = System.Drawing.SystemColors.Window
        Me.ucClientes.DisplayLayout.Override.GroupByRowAppearance = Appearance45
        Appearance46.TextHAlignAsString = "Left"
        Me.ucClientes.DisplayLayout.Override.HeaderAppearance = Appearance46
        Me.ucClientes.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ucClientes.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance47.BackColor = System.Drawing.SystemColors.Window
        Appearance47.BorderColor = System.Drawing.Color.Silver
        Me.ucClientes.DisplayLayout.Override.RowAppearance = Appearance47
        Me.ucClientes.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance48.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ucClientes.DisplayLayout.Override.TemplateAddRowAppearance = Appearance48
        Me.ucClientes.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ucClientes.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ucClientes.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.ucClientes.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.ucClientes.Location = New System.Drawing.Point(135, 121)
        Me.ucClientes.Name = "ucClientes"
        Me.ucClientes.Size = New System.Drawing.Size(115, 35)
        Me.ucClientes.TabIndex = 3
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.Color.Transparent
        Me.btnImprimir.BackgroundImage = Global.G02_Gustavo_02.My.Resources.Resources.Imprimir
        Me.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnImprimir.CausesValidation = False
        Me.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImprimir.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnImprimir.FlatAppearance.BorderSize = 0
        Me.btnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Location = New System.Drawing.Point(123, 649)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(159, 51)
        Me.btnImprimir.TabIndex = 2
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'pnMain
        '
        Me.pnMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnMain.Controls.Add(Me.pnPesquisa)
        Me.pnMain.Controls.Add(Me.pnArtigos)
        Me.pnMain.Controls.Add(Me.pnFaturacao)
        Me.pnMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnMain.Location = New System.Drawing.Point(0, 0)
        Me.pnMain.Name = "pnMain"
        Me.pnMain.Size = New System.Drawing.Size(5415, 1020)
        Me.pnMain.TabIndex = 0
        '
        'pnPesquisa
        '
        Me.pnPesquisa.Controls.Add(Me.btnPesquisa)
        Me.pnPesquisa.Controls.Add(Me.txtPesquisa)
        Me.pnPesquisa.Controls.Add(Me.picPesquisa)
        Me.pnPesquisa.Location = New System.Drawing.Point(0, 0)
        Me.pnPesquisa.Name = "pnPesquisa"
        Me.pnPesquisa.Size = New System.Drawing.Size(1038, 100)
        Me.pnPesquisa.TabIndex = 1
        '
        'btnPesquisa
        '
        Me.btnPesquisa.BackColor = System.Drawing.Color.White
        Me.btnPesquisa.BackgroundImage = Global.G02_Gustavo_02.My.Resources.Resources.Lupa
        Me.btnPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPesquisa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPesquisa.FlatAppearance.BorderSize = 0
        Me.btnPesquisa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnPesquisa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPesquisa.Location = New System.Drawing.Point(448, 41)
        Me.btnPesquisa.Name = "btnPesquisa"
        Me.btnPesquisa.Size = New System.Drawing.Size(60, 48)
        Me.btnPesquisa.TabIndex = 2
        Me.btnPesquisa.UseVisualStyleBackColor = False
        '
        'txtPesquisa
        '
        Me.txtPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPesquisa.Font = New System.Drawing.Font("Tahoma", 22.0!)
        Me.txtPesquisa.ForeColor = System.Drawing.Color.LightGray
        Me.txtPesquisa.Location = New System.Drawing.Point(119, 47)
        Me.txtPesquisa.Name = "txtPesquisa"
        Me.txtPesquisa.Size = New System.Drawing.Size(339, 36)
        Me.txtPesquisa.TabIndex = 1
        Me.txtPesquisa.Text = "Procurar..."
        '
        'picPesquisa
        '
        Me.picPesquisa.Image = Global.G02_Gustavo_02.My.Resources.Resources.BarraPesquisa
        Me.picPesquisa.Location = New System.Drawing.Point(98, 35)
        Me.picPesquisa.Name = "picPesquisa"
        Me.picPesquisa.Size = New System.Drawing.Size(426, 60)
        Me.picPesquisa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picPesquisa.TabIndex = 0
        Me.picPesquisa.TabStop = False
        '
        'pnArtigos
        '
        Me.pnArtigos.Controls.Add(Me.UltraLiveTileView)
        Me.pnArtigos.Location = New System.Drawing.Point(0, 101)
        Me.pnArtigos.Name = "pnArtigos"
        Me.pnArtigos.Size = New System.Drawing.Size(1038, 899)
        Me.pnArtigos.TabIndex = 1
        '
        'UltraLiveTileView
        '
        Appearance49.BackColor = System.Drawing.Color.Transparent
        Appearance49.BackColor2 = System.Drawing.Color.Transparent
        Appearance49.BackColorAlpha = Infragistics.Win.Alpha.Transparent
        Appearance49.BorderAlpha = Infragistics.Win.Alpha.Transparent
        Appearance49.ForeColor = System.Drawing.Color.Transparent
        Me.UltraLiveTileView.Appearance = Appearance49
        Me.UltraLiveTileView.CollapseButtonVisibility = Infragistics.Win.UltraWinLiveTileView.ExpandCollapseButtonVisibility.Never
        Me.UltraLiveTileView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraLiveTileView.ForeColor = System.Drawing.Color.Transparent
        Appearance50.BackColor = System.Drawing.Color.Transparent
        Appearance50.BackColor2 = System.Drawing.Color.Transparent
        Appearance50.BorderColor = System.Drawing.Color.Transparent
        Appearance50.BorderColor2 = System.Drawing.Color.Transparent
        Me.UltraLiveTileView.GroupAppearance.Active = Appearance50
        Appearance51.BackColor = System.Drawing.Color.Transparent
        Me.UltraLiveTileView.GroupAppearance.HotTracking = Appearance51
        Appearance52.BackColor = System.Drawing.Color.Transparent
        Appearance52.BackColor2 = System.Drawing.Color.Transparent
        Me.UltraLiveTileView.GroupAppearance.Normal = Appearance52
        Me.UltraLiveTileView.LeftClickInCustomizeModeBehavior = Infragistics.Win.UltraWinLiveTileView.LeftClickInCustomizeModeBehavior.Click
        Me.UltraLiveTileView.Location = New System.Drawing.Point(0, 0)
        Me.UltraLiveTileView.Name = "UltraLiveTileView"
        Me.UltraLiveTileView.ResolutionScale = Infragistics.Win.UltraWinLiveTileView.ResolutionScale.Scale140Percent
        Me.UltraLiveTileView.SelectionCheckmarkColor = System.Drawing.Color.Transparent
        Me.UltraLiveTileView.Size = New System.Drawing.Size(1038, 899)
        Me.UltraLiveTileView.TabIndex = 0
        Me.UltraLiveTileView.Text = "UltraLiveTileView"
        Appearance53.BackColor = System.Drawing.Color.Transparent
        Me.UltraLiveTileView.TileAppearance.Active = Appearance53
        Appearance54.BackColor = System.Drawing.Color.Transparent
        Me.UltraLiveTileView.TileAppearance.HotTracking = Appearance54
        Appearance55.BackColor = System.Drawing.Color.Transparent
        Appearance55.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UltraLiveTileView.TileAppearance.Normal = Appearance55
        Appearance56.BackColor = System.Drawing.Color.Transparent
        Appearance56.BackColor2 = System.Drawing.Color.Transparent
        Appearance56.BorderColor = System.Drawing.Color.Transparent
        Appearance56.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UltraLiveTileView.TileAppearance.Selected = Appearance56
        Me.UltraLiveTileView.TileSelection = Infragistics.Win.UltraWinLiveTileView.TileSelection.None
        Me.UltraLiveTileView.TileSizing = Infragistics.Win.UltraWinLiveTileView.TileSizing.Medium
        '
        'pnFaturacao
        '
        Me.pnFaturacao.Controls.Add(Me.UltraTabControl)
        Me.pnFaturacao.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnFaturacao.Location = New System.Drawing.Point(5032, 0)
        Me.pnFaturacao.Name = "pnFaturacao"
        Me.pnFaturacao.Size = New System.Drawing.Size(383, 1020)
        Me.pnFaturacao.TabIndex = 0
        '
        'UltraTabControl
        '
        Me.UltraTabControl.CloseButtonLocation = Infragistics.Win.UltraWinTabs.TabCloseButtonLocation.None
        Me.UltraTabControl.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl.Controls.Add(Me.UltraTabPageControl)
        Me.UltraTabControl.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControl.Name = "UltraTabControl"
        Me.UltraTabControl.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl.Size = New System.Drawing.Size(383, 1020)
        Me.UltraTabControl.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Wizard
        Me.UltraTabControl.TabIndex = 1
        Me.UltraTabControl.TabOrientation = Infragistics.Win.UltraWinTabs.TabOrientation.TopRight
        UltraTab1.TabPage = Me.UltraTabPageControl
        UltraTab1.Text = "Carrinho"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Cliente"
        Me.UltraTabControl.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(383, 1020)
        '
        'ucFaturação
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.pnMain)
        Me.Name = "ucFaturação"
        Me.Size = New System.Drawing.Size(5415, 1020)
        Me.UltraTabPageControl.ResumeLayout(False)
        Me.gpTotais.ResumeLayout(False)
        CType(Me.ugQI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ugLinhas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        Me.UltraTabPageControl2.PerformLayout()
        CType(Me.LocalidadeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodPostalTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnderecoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NIFTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NomeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucTP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnMain.ResumeLayout(False)
        Me.pnPesquisa.ResumeLayout(False)
        Me.pnPesquisa.PerformLayout()
        CType(Me.picPesquisa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnArtigos.ResumeLayout(False)
        CType(Me.UltraLiveTileView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnFaturacao.ResumeLayout(False)
        CType(Me.UltraTabControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnMain As Panel
    Friend WithEvents pnArtigos As Panel
    Friend WithEvents pnFaturacao As Panel
    Friend WithEvents ugLinhas As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraLiveTileView As Infragistics.Win.UltraWinLiveTileView.UltraLiveTileView
    Friend WithEvents UltraTabControl As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ugQI As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents gpTotais As GroupBox
    Friend WithEvents lblTotalAPagar As Label
    Friend WithEvents lblTotalIVA As Label
    Friend WithEvents lblTotalDesconto As Label
    Friend WithEvents lblTotalIliquido As Label
    Friend WithEvents lblTotal4 As Label
    Friend WithEvents lblTotal3 As Label
    Friend WithEvents lblTotal2 As Label
    Friend WithEvents lblTotal1 As Label
    Friend WithEvents btnImprimir As Button
    Friend WithEvents pnPesquisa As Panel
    Friend WithEvents txtPesquisa As TextBox
    Friend WithEvents picPesquisa As PictureBox
    Friend WithEvents btnPesquisa As Button
    Friend WithEvents btnProxPag As Button
    Friend WithEvents ucClientes As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents ucTP As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents testBTN As Button
    Friend WithEvents btnVoltar As Button
    Friend WithEvents CodPostalTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents EnderecoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents NIFTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents NomeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents LocalidadeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PictureBox4 As PictureBox
    ' Friend WithEvents pnPesquisa As Panel
    'Friend WithEvents picPesquisa As PictureBox
    ' Friend WithEvents txtPesquisa As TextBox
    ' Friend WithEvents Button1 As Button
End Class
