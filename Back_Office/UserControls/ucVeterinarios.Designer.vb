<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucVeterinarios
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
        Dim lblCodEntidade As System.Windows.Forms.Label
        Dim lblNome As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ClsVeterinariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UC_NAV1 = New G02_Nikola_04.UC_NAV()
        Me.ofdVeterinario = New System.Windows.Forms.OpenFileDialog()
        Me.picVeterinario = New System.Windows.Forms.PictureBox()
        Me.picFotografia = New System.Windows.Forms.PictureBox()
        Me.FotografiaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.picCarregarImagem = New System.Windows.Forms.PictureBox()
        Me.picApagarImagem = New System.Windows.Forms.PictureBox()
        Me.picCodEntidade = New System.Windows.Forms.PictureBox()
        Me.CodVeterinarioTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.picDescritivo = New System.Windows.Forms.PictureBox()
        Me.NomeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.EmailTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.NumTelefoneTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.NumTelemovelTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Panel2 = New System.Windows.Forms.Panel()
        lblCodEntidade = New System.Windows.Forms.Label()
        lblNome = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.ClsVeterinariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picVeterinario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFotografia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FotografiaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCarregarImagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picApagarImagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCodEntidade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodVeterinarioTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDescritivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NomeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmailTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumTelefoneTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumTelemovelTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.UC_NAV1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1632, 974)
        Me.Panel1.TabIndex = 0
        '
        'ClsVeterinariosBindingSource
        '
        Me.ClsVeterinariosBindingSource.DataSource = GetType(G02_Nikola_04.ClsVeterinarios)
        '
        'UC_NAV1
        '
        Me.UC_NAV1.AutoSize = True
        Me.UC_NAV1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UC_NAV1.Location = New System.Drawing.Point(0, 0)
        Me.UC_NAV1.mFRM = Nothing
        Me.UC_NAV1.Name = "UC_NAV1"
        Me.UC_NAV1.Size = New System.Drawing.Size(1632, 974)
        Me.UC_NAV1.TabIndex = 0
        '
        'ofdVeterinario
        '
        Me.ofdVeterinario.FileName = "OpenFileDialog1"
        '
        'picVeterinario
        '
        Me.picVeterinario.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picVeterinario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picVeterinario.Location = New System.Drawing.Point(911, 174)
        Me.picVeterinario.Name = "picVeterinario"
        Me.picVeterinario.Size = New System.Drawing.Size(348, 293)
        Me.picVeterinario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picVeterinario.TabIndex = 80
        Me.picVeterinario.TabStop = False
        '
        'picFotografia
        '
        Me.picFotografia.Image = Global.G02_Nikola_04.My.Resources.Resources.Shade1
        Me.picFotografia.Location = New System.Drawing.Point(1014, 485)
        Me.picFotografia.Name = "picFotografia"
        Me.picFotografia.Size = New System.Drawing.Size(156, 42)
        Me.picFotografia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFotografia.TabIndex = 82
        Me.picFotografia.TabStop = False
        '
        'FotografiaTextEdit
        '
        Me.FotografiaTextEdit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FotografiaTextEdit.Enabled = False
        Me.FotografiaTextEdit.Location = New System.Drawing.Point(1022, 492)
        Me.FotografiaTextEdit.Name = "FotografiaTextEdit"
        Me.FotografiaTextEdit.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.FotografiaTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.FotografiaTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.FotografiaTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.FotografiaTextEdit.Properties.Appearance.Options.UseFont = True
        Me.FotografiaTextEdit.Properties.Appearance.Options.UseForeColor = True
        Me.FotografiaTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.FotografiaTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.FotografiaTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.FotografiaTextEdit.Size = New System.Drawing.Size(140, 28)
        Me.FotografiaTextEdit.TabIndex = 81
        '
        'picCarregarImagem
        '
        Me.picCarregarImagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picCarregarImagem.BackColor = System.Drawing.Color.Transparent
        Me.picCarregarImagem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picCarregarImagem.Image = Global.G02_Nikola_04.My.Resources.Resources.CarregarImagem
        Me.picCarregarImagem.Location = New System.Drawing.Point(989, 558)
        Me.picCarregarImagem.Name = "picCarregarImagem"
        Me.picCarregarImagem.Size = New System.Drawing.Size(206, 37)
        Me.picCarregarImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCarregarImagem.TabIndex = 83
        Me.picCarregarImagem.TabStop = False
        '
        'picApagarImagem
        '
        Me.picApagarImagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picApagarImagem.BackColor = System.Drawing.Color.Transparent
        Me.picApagarImagem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picApagarImagem.Image = Global.G02_Nikola_04.My.Resources.Resources.ApagarImagem
        Me.picApagarImagem.Location = New System.Drawing.Point(989, 615)
        Me.picApagarImagem.Name = "picApagarImagem"
        Me.picApagarImagem.Size = New System.Drawing.Size(206, 37)
        Me.picApagarImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picApagarImagem.TabIndex = 84
        Me.picApagarImagem.TabStop = False
        '
        'picCodEntidade
        '
        Me.picCodEntidade.Image = Global.G02_Nikola_04.My.Resources.Resources.ShadeSmall
        Me.picCodEntidade.Location = New System.Drawing.Point(400, 201)
        Me.picCodEntidade.Name = "picCodEntidade"
        Me.picCodEntidade.Size = New System.Drawing.Size(96, 42)
        Me.picCodEntidade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCodEntidade.TabIndex = 86
        Me.picCodEntidade.TabStop = False
        '
        'CodVeterinarioTextEdit
        '
        Me.CodVeterinarioTextEdit.Enabled = False
        Me.CodVeterinarioTextEdit.Location = New System.Drawing.Point(410, 208)
        Me.CodVeterinarioTextEdit.Name = "CodVeterinarioTextEdit"
        Me.CodVeterinarioTextEdit.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.CodVeterinarioTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.CodVeterinarioTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.CodVeterinarioTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.CodVeterinarioTextEdit.Properties.Appearance.Options.UseFont = True
        Me.CodVeterinarioTextEdit.Properties.Appearance.Options.UseForeColor = True
        Me.CodVeterinarioTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.CodVeterinarioTextEdit.Size = New System.Drawing.Size(77, 28)
        Me.CodVeterinarioTextEdit.TabIndex = 85
        '
        'lblCodEntidade
        '
        lblCodEntidade.AutoSize = True
        lblCodEntidade.Font = New System.Drawing.Font("Tahoma", 10.0!)
        lblCodEntidade.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        lblCodEntidade.Location = New System.Drawing.Point(397, 181)
        lblCodEntidade.Name = "lblCodEntidade"
        lblCodEntidade.Size = New System.Drawing.Size(139, 17)
        lblCodEntidade.TabIndex = 87
        lblCodEntidade.Text = "Código do Veterinário"
        '
        'picDescritivo
        '
        Me.picDescritivo.Enabled = False
        Me.picDescritivo.Image = Global.G02_Nikola_04.My.Resources.Resources.Shade
        Me.picDescritivo.Location = New System.Drawing.Point(582, 201)
        Me.picDescritivo.Name = "picDescritivo"
        Me.picDescritivo.Size = New System.Drawing.Size(288, 42)
        Me.picDescritivo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDescritivo.TabIndex = 90
        Me.picDescritivo.TabStop = False
        '
        'lblNome
        '
        lblNome.AutoSize = True
        lblNome.Font = New System.Drawing.Font("Tahoma", 10.0!)
        lblNome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        lblNome.Location = New System.Drawing.Point(581, 181)
        lblNome.Name = "lblNome"
        lblNome.Size = New System.Drawing.Size(44, 17)
        lblNome.TabIndex = 89
        lblNome.Text = "Nome"
        '
        'NomeTextEdit
        '
        Me.NomeTextEdit.Enabled = False
        Me.NomeTextEdit.Location = New System.Drawing.Point(593, 208)
        Me.NomeTextEdit.Name = "NomeTextEdit"
        Me.NomeTextEdit.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.NomeTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.NomeTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.NomeTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.NomeTextEdit.Properties.Appearance.Options.UseFont = True
        Me.NomeTextEdit.Properties.Appearance.Options.UseForeColor = True
        Me.NomeTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.NomeTextEdit.Size = New System.Drawing.Size(265, 28)
        Me.NomeTextEdit.TabIndex = 88
        '
        'PictureBox5
        '
        Me.PictureBox5.Enabled = False
        Me.PictureBox5.Image = Global.G02_Nikola_04.My.Resources.Resources.Shade2
        Me.PictureBox5.Location = New System.Drawing.Point(399, 382)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(374, 42)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 93
        Me.PictureBox5.TabStop = False
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Label6.Location = New System.Drawing.Point(398, 362)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(39, 17)
        Label6.TabIndex = 92
        Label6.Text = "Email"
        '
        'EmailTextEdit
        '
        Me.EmailTextEdit.Enabled = False
        Me.EmailTextEdit.Location = New System.Drawing.Point(410, 389)
        Me.EmailTextEdit.Name = "EmailTextEdit"
        Me.EmailTextEdit.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.EmailTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.EmailTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.EmailTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.EmailTextEdit.Properties.Appearance.Options.UseFont = True
        Me.EmailTextEdit.Properties.Appearance.Options.UseForeColor = True
        Me.EmailTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.EmailTextEdit.Size = New System.Drawing.Size(351, 28)
        Me.EmailTextEdit.TabIndex = 91
        '
        'PictureBox3
        '
        Me.PictureBox3.Enabled = False
        Me.PictureBox3.Image = Global.G02_Nikola_04.My.Resources.Resources.Shade1
        Me.PictureBox3.Location = New System.Drawing.Point(399, 293)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(160, 42)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 96
        Me.PictureBox3.TabStop = False
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Label4.Location = New System.Drawing.Point(398, 273)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(131, 17)
        Label4.TabIndex = 95
        Label4.Text = "Número de Telefone"
        '
        'NumTelefoneTextEdit
        '
        Me.NumTelefoneTextEdit.Enabled = False
        Me.NumTelefoneTextEdit.Location = New System.Drawing.Point(410, 300)
        Me.NumTelefoneTextEdit.Name = "NumTelefoneTextEdit"
        Me.NumTelefoneTextEdit.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.NumTelefoneTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.NumTelefoneTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.NumTelefoneTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.NumTelefoneTextEdit.Properties.Appearance.Options.UseFont = True
        Me.NumTelefoneTextEdit.Properties.Appearance.Options.UseForeColor = True
        Me.NumTelefoneTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.NumTelefoneTextEdit.Size = New System.Drawing.Size(137, 28)
        Me.NumTelefoneTextEdit.TabIndex = 94
        '
        'PictureBox4
        '
        Me.PictureBox4.Enabled = False
        Me.PictureBox4.Image = Global.G02_Nikola_04.My.Resources.Resources.Shade1
        Me.PictureBox4.Location = New System.Drawing.Point(611, 293)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(162, 42)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 99
        Me.PictureBox4.TabStop = False
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Label5.Location = New System.Drawing.Point(610, 273)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(141, 17)
        Label5.TabIndex = 98
        Label5.Text = "Número de Telemóvel"
        '
        'NumTelemovelTextEdit
        '
        Me.NumTelemovelTextEdit.Enabled = False
        Me.NumTelemovelTextEdit.Location = New System.Drawing.Point(622, 300)
        Me.NumTelemovelTextEdit.Name = "NumTelemovelTextEdit"
        Me.NumTelemovelTextEdit.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.NumTelemovelTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.NumTelemovelTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.NumTelemovelTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.NumTelemovelTextEdit.Properties.Appearance.Options.UseFont = True
        Me.NumTelemovelTextEdit.Properties.Appearance.Options.UseForeColor = True
        Me.NumTelemovelTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.NumTelemovelTextEdit.Size = New System.Drawing.Size(139, 28)
        Me.NumTelemovelTextEdit.TabIndex = 97
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.NumTelemovelTextEdit)
        Me.Panel2.Controls.Add(Label5)
        Me.Panel2.Controls.Add(Me.PictureBox4)
        Me.Panel2.Controls.Add(Me.NumTelefoneTextEdit)
        Me.Panel2.Controls.Add(Label4)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.EmailTextEdit)
        Me.Panel2.Controls.Add(Label6)
        Me.Panel2.Controls.Add(Me.PictureBox5)
        Me.Panel2.Controls.Add(Me.NomeTextEdit)
        Me.Panel2.Controls.Add(lblNome)
        Me.Panel2.Controls.Add(Me.picDescritivo)
        Me.Panel2.Controls.Add(lblCodEntidade)
        Me.Panel2.Controls.Add(Me.CodVeterinarioTextEdit)
        Me.Panel2.Controls.Add(Me.picCodEntidade)
        Me.Panel2.Controls.Add(Me.picApagarImagem)
        Me.Panel2.Controls.Add(Me.picCarregarImagem)
        Me.Panel2.Controls.Add(Me.FotografiaTextEdit)
        Me.Panel2.Controls.Add(Me.picFotografia)
        Me.Panel2.Controls.Add(Me.picVeterinario)
        Me.Panel2.Location = New System.Drawing.Point(3, 75)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1629, 871)
        Me.Panel2.TabIndex = 1
        '
        'ucVeterinarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ucVeterinarios"
        Me.Size = New System.Drawing.Size(1632, 974)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ClsVeterinariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picVeterinario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFotografia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FotografiaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCarregarImagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picApagarImagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCodEntidade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodVeterinarioTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDescritivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NomeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmailTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumTelefoneTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumTelemovelTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ClsVeterinariosBindingSource As BindingSource
    Friend WithEvents UC_NAV1 As UC_NAV
    Friend WithEvents ofdVeterinario As OpenFileDialog
    Friend WithEvents Panel2 As Panel
    Friend WithEvents NumTelemovelTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents NumTelefoneTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents EmailTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents NomeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents picDescritivo As PictureBox
    Friend WithEvents CodVeterinarioTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents picCodEntidade As PictureBox
    Friend WithEvents picApagarImagem As PictureBox
    Friend WithEvents picCarregarImagem As PictureBox
    Friend WithEvents FotografiaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents picFotografia As PictureBox
    Friend WithEvents picVeterinario As PictureBox
End Class
