<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Categorias
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
        Dim lblDesignacao As System.Windows.Forms.Label
        Dim lblCodCategoria As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnCategorias = New Infragistics.Win.Misc.UltraPanel()
        Me.picApagarImagem = New System.Windows.Forms.PictureBox()
        Me.picCarregarImagem = New System.Windows.Forms.PictureBox()
        Me.ImagemTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.picFotografia = New System.Windows.Forms.PictureBox()
        Me.picCategoria = New System.Windows.Forms.PictureBox()
        Me.UC_NAV1 = New G02_Nikola_04.UC_NAV()
        Me.ofdCategorias = New System.Windows.Forms.OpenFileDialog()
        Me.DesignacaoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.picDescritivo = New System.Windows.Forms.PictureBox()
        Me.CodCategoriaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.picCodEntidade = New System.Windows.Forms.PictureBox()
        lblDesignacao = New System.Windows.Forms.Label()
        lblCodCategoria = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.pnCategorias.ClientArea.SuspendLayout()
        Me.pnCategorias.SuspendLayout()
        CType(Me.picApagarImagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCarregarImagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagemTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFotografia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DesignacaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDescritivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodCategoriaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCodEntidade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pnCategorias)
        Me.Panel1.Controls.Add(Me.UC_NAV1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1632, 974)
        Me.Panel1.TabIndex = 0
        '
        'pnCategorias
        '
        Me.pnCategorias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        'pnCategorias.ClientArea
        '
        Me.pnCategorias.ClientArea.Controls.Add(Me.DesignacaoTextEdit)
        Me.pnCategorias.ClientArea.Controls.Add(lblDesignacao)
        Me.pnCategorias.ClientArea.Controls.Add(Me.picDescritivo)
        Me.pnCategorias.ClientArea.Controls.Add(lblCodCategoria)
        Me.pnCategorias.ClientArea.Controls.Add(Me.CodCategoriaTextEdit)
        Me.pnCategorias.ClientArea.Controls.Add(Me.picCodEntidade)
        Me.pnCategorias.ClientArea.Controls.Add(Me.picApagarImagem)
        Me.pnCategorias.ClientArea.Controls.Add(Me.picCarregarImagem)
        Me.pnCategorias.ClientArea.Controls.Add(Me.ImagemTextEdit)
        Me.pnCategorias.ClientArea.Controls.Add(Me.picFotografia)
        Me.pnCategorias.ClientArea.Controls.Add(Me.picCategoria)
        Me.pnCategorias.Location = New System.Drawing.Point(3, 84)
        Me.pnCategorias.Name = "pnCategorias"
        Me.pnCategorias.Size = New System.Drawing.Size(1626, 857)
        Me.pnCategorias.TabIndex = 1
        '
        'picApagarImagem
        '
        Me.picApagarImagem.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picApagarImagem.BackColor = System.Drawing.Color.Transparent
        Me.picApagarImagem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picApagarImagem.Image = Global.G02_Nikola_04.My.Resources.Resources.ApagarImagem
        Me.picApagarImagem.Location = New System.Drawing.Point(917, 604)
        Me.picApagarImagem.Name = "picApagarImagem"
        Me.picApagarImagem.Size = New System.Drawing.Size(206, 37)
        Me.picApagarImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picApagarImagem.TabIndex = 84
        Me.picApagarImagem.TabStop = False
        '
        'picCarregarImagem
        '
        Me.picCarregarImagem.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picCarregarImagem.BackColor = System.Drawing.Color.Transparent
        Me.picCarregarImagem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picCarregarImagem.Image = Global.G02_Nikola_04.My.Resources.Resources.CarregarImagem
        Me.picCarregarImagem.Location = New System.Drawing.Point(917, 547)
        Me.picCarregarImagem.Name = "picCarregarImagem"
        Me.picCarregarImagem.Size = New System.Drawing.Size(206, 37)
        Me.picCarregarImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCarregarImagem.TabIndex = 83
        Me.picCarregarImagem.TabStop = False
        '
        'ImagemTextEdit
        '
        Me.ImagemTextEdit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ImagemTextEdit.Enabled = False
        Me.ImagemTextEdit.Location = New System.Drawing.Point(950, 481)
        Me.ImagemTextEdit.Name = "ImagemTextEdit"
        Me.ImagemTextEdit.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.ImagemTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.ImagemTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ImagemTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.ImagemTextEdit.Properties.Appearance.Options.UseFont = True
        Me.ImagemTextEdit.Properties.Appearance.Options.UseForeColor = True
        Me.ImagemTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.ImagemTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ImagemTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.ImagemTextEdit.Size = New System.Drawing.Size(140, 28)
        Me.ImagemTextEdit.TabIndex = 81
        '
        'picFotografia
        '
        Me.picFotografia.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picFotografia.Image = Global.G02_Nikola_04.My.Resources.Resources.Shade1
        Me.picFotografia.Location = New System.Drawing.Point(942, 474)
        Me.picFotografia.Name = "picFotografia"
        Me.picFotografia.Size = New System.Drawing.Size(156, 42)
        Me.picFotografia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFotografia.TabIndex = 82
        Me.picFotografia.TabStop = False
        '
        'picCategoria
        '
        Me.picCategoria.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picCategoria.Location = New System.Drawing.Point(839, 163)
        Me.picCategoria.Name = "picCategoria"
        Me.picCategoria.Size = New System.Drawing.Size(348, 293)
        Me.picCategoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCategoria.TabIndex = 80
        Me.picCategoria.TabStop = False
        '
        'UC_NAV1
        '
        Me.UC_NAV1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UC_NAV1.Location = New System.Drawing.Point(0, 0)
        Me.UC_NAV1.mFRM = Nothing
        Me.UC_NAV1.Name = "UC_NAV1"
        Me.UC_NAV1.Size = New System.Drawing.Size(1632, 974)
        Me.UC_NAV1.TabIndex = 0
        '
        'DesignacaoTextEdit
        '
        Me.DesignacaoTextEdit.Enabled = False
        Me.DesignacaoTextEdit.Location = New System.Drawing.Point(405, 360)
        Me.DesignacaoTextEdit.Name = "DesignacaoTextEdit"
        Me.DesignacaoTextEdit.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.DesignacaoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.DesignacaoTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.DesignacaoTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.DesignacaoTextEdit.Properties.Appearance.Options.UseFont = True
        Me.DesignacaoTextEdit.Properties.Appearance.Options.UseForeColor = True
        Me.DesignacaoTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.DesignacaoTextEdit.Size = New System.Drawing.Size(265, 28)
        Me.DesignacaoTextEdit.TabIndex = 88
        '
        'lblDesignacao
        '
        lblDesignacao.AutoSize = True
        lblDesignacao.Font = New System.Drawing.Font("Tahoma", 10.0!)
        lblDesignacao.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        lblDesignacao.Location = New System.Drawing.Point(393, 333)
        lblDesignacao.Name = "lblDesignacao"
        lblDesignacao.Size = New System.Drawing.Size(78, 17)
        lblDesignacao.TabIndex = 89
        lblDesignacao.Text = "Designação"
        '
        'picDescritivo
        '
        Me.picDescritivo.Enabled = False
        Me.picDescritivo.Image = Global.G02_Nikola_04.My.Resources.Resources.Shade
        Me.picDescritivo.Location = New System.Drawing.Point(394, 353)
        Me.picDescritivo.Name = "picDescritivo"
        Me.picDescritivo.Size = New System.Drawing.Size(288, 42)
        Me.picDescritivo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDescritivo.TabIndex = 90
        Me.picDescritivo.TabStop = False
        '
        'lblCodCategoria
        '
        lblCodCategoria.AutoSize = True
        lblCodCategoria.Font = New System.Drawing.Font("Tahoma", 10.0!)
        lblCodCategoria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        lblCodCategoria.Location = New System.Drawing.Point(393, 229)
        lblCodCategoria.Name = "lblCodCategoria"
        lblCodCategoria.Size = New System.Drawing.Size(132, 17)
        lblCodCategoria.TabIndex = 87
        lblCodCategoria.Text = "Código da Categoria"
        '
        'CodCategoriaTextEdit
        '
        Me.CodCategoriaTextEdit.Enabled = False
        Me.CodCategoriaTextEdit.Location = New System.Drawing.Point(406, 256)
        Me.CodCategoriaTextEdit.Name = "CodCategoriaTextEdit"
        Me.CodCategoriaTextEdit.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.CodCategoriaTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.CodCategoriaTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.CodCategoriaTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.CodCategoriaTextEdit.Properties.Appearance.Options.UseFont = True
        Me.CodCategoriaTextEdit.Properties.Appearance.Options.UseForeColor = True
        Me.CodCategoriaTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.CodCategoriaTextEdit.Size = New System.Drawing.Size(77, 28)
        Me.CodCategoriaTextEdit.TabIndex = 85
        '
        'picCodEntidade
        '
        Me.picCodEntidade.Image = Global.G02_Nikola_04.My.Resources.Resources.ShadeSmall
        Me.picCodEntidade.Location = New System.Drawing.Point(396, 249)
        Me.picCodEntidade.Name = "picCodEntidade"
        Me.picCodEntidade.Size = New System.Drawing.Size(96, 42)
        Me.picCodEntidade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCodEntidade.TabIndex = 86
        Me.picCodEntidade.TabStop = False
        '
        'UC_Categorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UC_Categorias"
        Me.Size = New System.Drawing.Size(1632, 974)
        Me.Panel1.ResumeLayout(False)
        Me.pnCategorias.ClientArea.ResumeLayout(False)
        Me.pnCategorias.ClientArea.PerformLayout()
        Me.pnCategorias.ResumeLayout(False)
        CType(Me.picApagarImagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCarregarImagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagemTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFotografia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DesignacaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDescritivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodCategoriaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCodEntidade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents UC_NAV1 As UC_NAV
    Friend WithEvents pnCategorias As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents ofdCategorias As OpenFileDialog
    Friend WithEvents picApagarImagem As PictureBox
    Friend WithEvents picCarregarImagem As PictureBox
    Friend WithEvents ImagemTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents picFotografia As PictureBox
    Friend WithEvents picCategoria As PictureBox
    Friend WithEvents DesignacaoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents picDescritivo As PictureBox
    Friend WithEvents CodCategoriaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents picCodEntidade As PictureBox
End Class
