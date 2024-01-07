<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucTiposAnimais
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
        Dim lblCodTA As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.upTiposAnimais = New Infragistics.Win.Misc.UltraPanel()
        Me.picApagarImagem = New System.Windows.Forms.PictureBox()
        Me.picCarregarImagem = New System.Windows.Forms.PictureBox()
        Me.ImagemTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.picFotografia = New System.Windows.Forms.PictureBox()
        Me.picTipoAnimal = New System.Windows.Forms.PictureBox()
        Me.AnimalTextedit = New DevExpress.XtraEditors.TextEdit()
        Me.picAnimal = New System.Windows.Forms.PictureBox()
        Me.CodTipoAnimalTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.picCodTA = New System.Windows.Forms.PictureBox()
        Me.UC_NAV1 = New G02_Nikola_04.UC_NAV()
        Me.ofdTiposAnimais = New System.Windows.Forms.OpenFileDialog()
        lblCodTA = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.upTiposAnimais.ClientArea.SuspendLayout()
        Me.upTiposAnimais.SuspendLayout()
        CType(Me.picApagarImagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCarregarImagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagemTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFotografia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTipoAnimal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnimalTextedit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAnimal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodTipoAnimalTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCodTA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCodTA
        '
        lblCodTA.AutoSize = True
        lblCodTA.Font = New System.Drawing.Font("Tahoma", 10.0!)
        lblCodTA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        lblCodTA.Location = New System.Drawing.Point(464, 251)
        lblCodTA.Name = "lblCodTA"
        lblCodTA.Size = New System.Drawing.Size(163, 17)
        lblCodTA.TabIndex = 52
        lblCodTA.Text = "Código do Tipo de Animal"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Label1.Location = New System.Drawing.Point(464, 367)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(47, 17)
        Label1.TabIndex = 55
        Label1.Text = "Animal"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.upTiposAnimais)
        Me.Panel1.Controls.Add(Me.UC_NAV1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1622, 856)
        Me.Panel1.TabIndex = 0
        '
        'upTiposAnimais
        '
        Me.upTiposAnimais.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        'upTiposAnimais.ClientArea
        '
        Me.upTiposAnimais.ClientArea.Controls.Add(Me.picApagarImagem)
        Me.upTiposAnimais.ClientArea.Controls.Add(Me.picCarregarImagem)
        Me.upTiposAnimais.ClientArea.Controls.Add(Me.ImagemTextEdit)
        Me.upTiposAnimais.ClientArea.Controls.Add(Me.picFotografia)
        Me.upTiposAnimais.ClientArea.Controls.Add(Me.picTipoAnimal)
        Me.upTiposAnimais.ClientArea.Controls.Add(Label1)
        Me.upTiposAnimais.ClientArea.Controls.Add(Me.AnimalTextedit)
        Me.upTiposAnimais.ClientArea.Controls.Add(Me.picAnimal)
        Me.upTiposAnimais.ClientArea.Controls.Add(lblCodTA)
        Me.upTiposAnimais.ClientArea.Controls.Add(Me.CodTipoAnimalTextEdit)
        Me.upTiposAnimais.ClientArea.Controls.Add(Me.picCodTA)
        Me.upTiposAnimais.Location = New System.Drawing.Point(3, 87)
        Me.upTiposAnimais.Name = "upTiposAnimais"
        Me.upTiposAnimais.Size = New System.Drawing.Size(1616, 737)
        Me.upTiposAnimais.TabIndex = 1
        '
        'picApagarImagem
        '
        Me.picApagarImagem.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picApagarImagem.BackColor = System.Drawing.Color.Transparent
        Me.picApagarImagem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picApagarImagem.Image = Global.G02_Nikola_04.My.Resources.Resources.ApagarImagem
        Me.picApagarImagem.Location = New System.Drawing.Point(910, 557)
        Me.picApagarImagem.Name = "picApagarImagem"
        Me.picApagarImagem.Size = New System.Drawing.Size(206, 37)
        Me.picApagarImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picApagarImagem.TabIndex = 83
        Me.picApagarImagem.TabStop = False
        '
        'picCarregarImagem
        '
        Me.picCarregarImagem.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picCarregarImagem.BackColor = System.Drawing.Color.Transparent
        Me.picCarregarImagem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picCarregarImagem.Image = Global.G02_Nikola_04.My.Resources.Resources.CarregarImagem
        Me.picCarregarImagem.Location = New System.Drawing.Point(910, 500)
        Me.picCarregarImagem.Name = "picCarregarImagem"
        Me.picCarregarImagem.Size = New System.Drawing.Size(206, 37)
        Me.picCarregarImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCarregarImagem.TabIndex = 82
        Me.picCarregarImagem.TabStop = False
        '
        'ImagemTextEdit
        '
        Me.ImagemTextEdit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ImagemTextEdit.Enabled = False
        Me.ImagemTextEdit.Location = New System.Drawing.Point(945, 424)
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
        Me.ImagemTextEdit.TabIndex = 80
        '
        'picFotografia
        '
        Me.picFotografia.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picFotografia.Image = Global.G02_Nikola_04.My.Resources.Resources.Shade1
        Me.picFotografia.Location = New System.Drawing.Point(937, 417)
        Me.picFotografia.Name = "picFotografia"
        Me.picFotografia.Size = New System.Drawing.Size(156, 42)
        Me.picFotografia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFotografia.TabIndex = 81
        Me.picFotografia.TabStop = False
        '
        'picTipoAnimal
        '
        Me.picTipoAnimal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picTipoAnimal.Location = New System.Drawing.Point(847, 125)
        Me.picTipoAnimal.Name = "picTipoAnimal"
        Me.picTipoAnimal.Size = New System.Drawing.Size(348, 293)
        Me.picTipoAnimal.TabIndex = 56
        Me.picTipoAnimal.TabStop = False
        '
        'AnimalTextedit
        '
        Me.AnimalTextedit.Enabled = False
        Me.AnimalTextedit.Location = New System.Drawing.Point(477, 394)
        Me.AnimalTextedit.Name = "AnimalTextedit"
        Me.AnimalTextedit.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.AnimalTextedit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.AnimalTextedit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.AnimalTextedit.Properties.Appearance.Options.UseBackColor = True
        Me.AnimalTextedit.Properties.Appearance.Options.UseFont = True
        Me.AnimalTextedit.Properties.Appearance.Options.UseForeColor = True
        Me.AnimalTextedit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.AnimalTextedit.Size = New System.Drawing.Size(77, 28)
        Me.AnimalTextedit.TabIndex = 53
        '
        'picAnimal
        '
        Me.picAnimal.Image = Global.G02_Nikola_04.My.Resources.Resources.ShadeSmall
        Me.picAnimal.Location = New System.Drawing.Point(467, 387)
        Me.picAnimal.Name = "picAnimal"
        Me.picAnimal.Size = New System.Drawing.Size(96, 42)
        Me.picAnimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAnimal.TabIndex = 54
        Me.picAnimal.TabStop = False
        '
        'CodTipoAnimalTextEdit
        '
        Me.CodTipoAnimalTextEdit.Enabled = False
        Me.CodTipoAnimalTextEdit.Location = New System.Drawing.Point(477, 278)
        Me.CodTipoAnimalTextEdit.Name = "CodTipoAnimalTextEdit"
        Me.CodTipoAnimalTextEdit.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.CodTipoAnimalTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.CodTipoAnimalTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.CodTipoAnimalTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.CodTipoAnimalTextEdit.Properties.Appearance.Options.UseFont = True
        Me.CodTipoAnimalTextEdit.Properties.Appearance.Options.UseForeColor = True
        Me.CodTipoAnimalTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.CodTipoAnimalTextEdit.Size = New System.Drawing.Size(77, 28)
        Me.CodTipoAnimalTextEdit.TabIndex = 50
        '
        'picCodTA
        '
        Me.picCodTA.Image = Global.G02_Nikola_04.My.Resources.Resources.ShadeSmall
        Me.picCodTA.Location = New System.Drawing.Point(467, 271)
        Me.picCodTA.Name = "picCodTA"
        Me.picCodTA.Size = New System.Drawing.Size(96, 42)
        Me.picCodTA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCodTA.TabIndex = 51
        Me.picCodTA.TabStop = False
        '
        'UC_NAV1
        '
        Me.UC_NAV1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UC_NAV1.Location = New System.Drawing.Point(0, 0)
        Me.UC_NAV1.mFRM = Nothing
        Me.UC_NAV1.Name = "UC_NAV1"
        Me.UC_NAV1.Size = New System.Drawing.Size(1622, 856)
        Me.UC_NAV1.TabIndex = 0
        '
        'ucTiposAnimais
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ucTiposAnimais"
        Me.Size = New System.Drawing.Size(1622, 856)
        Me.Panel1.ResumeLayout(False)
        Me.upTiposAnimais.ClientArea.ResumeLayout(False)
        Me.upTiposAnimais.ClientArea.PerformLayout()
        Me.upTiposAnimais.ResumeLayout(False)
        CType(Me.picApagarImagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCarregarImagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagemTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFotografia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTipoAnimal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnimalTextedit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAnimal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodTipoAnimalTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCodTA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents UC_NAV1 As UC_NAV
    Friend WithEvents upTiposAnimais As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents ofdTiposAnimais As OpenFileDialog
    Friend WithEvents CodTipoAnimalTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents picCodTA As PictureBox
    Friend WithEvents AnimalTextedit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents picAnimal As PictureBox
    Friend WithEvents picTipoAnimal As PictureBox
    Friend WithEvents picApagarImagem As PictureBox
    Friend WithEvents picCarregarImagem As PictureBox
    Friend WithEvents ImagemTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents picFotografia As PictureBox
End Class
