<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucIVA
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
        Dim Label2 As System.Windows.Forms.Label
        Dim lblCodEntidade As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim lblFLGCompra As System.Windows.Forms.Label
        Me.pnMain = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DesignacaoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TipoIVATextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TaxaIVATextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CodIVATextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.picCodEntidade = New System.Windows.Forms.PictureBox()
        Me.FLGDescontinuadoCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.Data_Inicio_VigorDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.Data_Fim_VigorDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.UC_NAV1 = New G02_Nikola_04.UC_NAV()
        Label2 = New System.Windows.Forms.Label()
        lblCodEntidade = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        lblFLGCompra = New System.Windows.Forms.Label()
        Me.pnMain.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DesignacaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoIVATextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxaIVATextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodIVATextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCodEntidade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FLGDescontinuadoCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Data_Inicio_VigorDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Data_Inicio_VigorDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Data_Fim_VigorDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Data_Fim_VigorDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Label2.Location = New System.Drawing.Point(863, 220)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(62, 17)
        Label2.TabIndex = 59
        Label2.Text = "Taxa IVA"
        '
        'lblCodEntidade
        '
        lblCodEntidade.AutoSize = True
        lblCodEntidade.Font = New System.Drawing.Font("Tahoma", 10.0!)
        lblCodEntidade.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        lblCodEntidade.Location = New System.Drawing.Point(594, 220)
        lblCodEntidade.Name = "lblCodEntidade"
        lblCodEntidade.Size = New System.Drawing.Size(75, 17)
        lblCodEntidade.TabIndex = 56
        lblCodEntidade.Text = "Código IVA"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Label4.Location = New System.Drawing.Point(865, 332)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(58, 17)
        Label4.TabIndex = 64
        Label4.Text = "Tipo IVA"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Label1.Location = New System.Drawing.Point(595, 332)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(58, 17)
        Label1.TabIndex = 67
        Label1.Text = "Tipo IVA"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Label3.Location = New System.Drawing.Point(593, 448)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(149, 17)
        Label3.TabIndex = 69
        Label3.Text = "Data de Início em Vigor"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Label5.Location = New System.Drawing.Point(865, 448)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(139, 17)
        Label5.TabIndex = 70
        Label5.Text = "Data de Fim em Vigor"
        '
        'lblFLGCompra
        '
        lblFLGCompra.AutoSize = True
        lblFLGCompra.Font = New System.Drawing.Font("Tahoma", 16.0!)
        lblFLGCompra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        lblFLGCompra.Location = New System.Drawing.Point(699, 572)
        lblFLGCompra.Name = "lblFLGCompra"
        lblFLGCompra.Size = New System.Drawing.Size(155, 27)
        lblFLGCompra.TabIndex = 71
        lblFLGCompra.Text = "Descontinuado"
        '
        'pnMain
        '
        Me.pnMain.Controls.Add(Me.Panel2)
        Me.pnMain.Controls.Add(Me.UC_NAV1)
        Me.pnMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnMain.Location = New System.Drawing.Point(0, 0)
        Me.pnMain.Name = "pnMain"
        Me.pnMain.Size = New System.Drawing.Size(1632, 974)
        Me.pnMain.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(lblFLGCompra)
        Me.Panel2.Controls.Add(Label5)
        Me.Panel2.Controls.Add(Label3)
        Me.Panel2.Controls.Add(Me.DesignacaoTextEdit)
        Me.Panel2.Controls.Add(Label1)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.TipoIVATextEdit)
        Me.Panel2.Controls.Add(Label4)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Label2)
        Me.Panel2.Controls.Add(Me.TaxaIVATextEdit)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(lblCodEntidade)
        Me.Panel2.Controls.Add(Me.CodIVATextEdit)
        Me.Panel2.Controls.Add(Me.picCodEntidade)
        Me.Panel2.Controls.Add(Me.FLGDescontinuadoCheckEdit)
        Me.Panel2.Controls.Add(Me.Data_Inicio_VigorDateEdit)
        Me.Panel2.Controls.Add(Me.Data_Fim_VigorDateEdit)
        Me.Panel2.Location = New System.Drawing.Point(3, 86)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1629, 856)
        Me.Panel2.TabIndex = 1
        '
        'DesignacaoTextEdit
        '
        Me.DesignacaoTextEdit.Enabled = False
        Me.DesignacaoTextEdit.Location = New System.Drawing.Point(607, 359)
        Me.DesignacaoTextEdit.Name = "DesignacaoTextEdit"
        Me.DesignacaoTextEdit.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.DesignacaoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.DesignacaoTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.DesignacaoTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.DesignacaoTextEdit.Properties.Appearance.Options.UseFont = True
        Me.DesignacaoTextEdit.Properties.Appearance.Options.UseForeColor = True
        Me.DesignacaoTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.DesignacaoTextEdit.Size = New System.Drawing.Size(137, 28)
        Me.DesignacaoTextEdit.TabIndex = 66
        '
        'PictureBox2
        '
        Me.PictureBox2.Enabled = False
        Me.PictureBox2.Image = Global.G02_Nikola_04.My.Resources.Resources.Shade1
        Me.PictureBox2.Location = New System.Drawing.Point(596, 352)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(160, 42)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 68
        Me.PictureBox2.TabStop = False
        '
        'TipoIVATextEdit
        '
        Me.TipoIVATextEdit.Enabled = False
        Me.TipoIVATextEdit.Location = New System.Drawing.Point(877, 359)
        Me.TipoIVATextEdit.Name = "TipoIVATextEdit"
        Me.TipoIVATextEdit.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.TipoIVATextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.TipoIVATextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.TipoIVATextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.TipoIVATextEdit.Properties.Appearance.Options.UseFont = True
        Me.TipoIVATextEdit.Properties.Appearance.Options.UseForeColor = True
        Me.TipoIVATextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TipoIVATextEdit.Size = New System.Drawing.Size(77, 28)
        Me.TipoIVATextEdit.TabIndex = 63
        '
        'PictureBox3
        '
        Me.PictureBox3.Enabled = False
        Me.PictureBox3.Image = Global.G02_Nikola_04.My.Resources.Resources.ShadeSmall
        Me.PictureBox3.Location = New System.Drawing.Point(866, 352)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(96, 42)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 65
        Me.PictureBox3.TabStop = False
        '
        'TaxaIVATextEdit
        '
        Me.TaxaIVATextEdit.Enabled = False
        Me.TaxaIVATextEdit.Location = New System.Drawing.Point(876, 247)
        Me.TaxaIVATextEdit.Name = "TaxaIVATextEdit"
        Me.TaxaIVATextEdit.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.TaxaIVATextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.TaxaIVATextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.TaxaIVATextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.TaxaIVATextEdit.Properties.Appearance.Options.UseFont = True
        Me.TaxaIVATextEdit.Properties.Appearance.Options.UseForeColor = True
        Me.TaxaIVATextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TaxaIVATextEdit.Size = New System.Drawing.Size(77, 28)
        Me.TaxaIVATextEdit.TabIndex = 57
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.G02_Nikola_04.My.Resources.Resources.ShadeSmall
        Me.PictureBox1.Location = New System.Drawing.Point(866, 240)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(96, 42)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 58
        Me.PictureBox1.TabStop = False
        '
        'CodIVATextEdit
        '
        Me.CodIVATextEdit.Enabled = False
        Me.CodIVATextEdit.Location = New System.Drawing.Point(607, 247)
        Me.CodIVATextEdit.Name = "CodIVATextEdit"
        Me.CodIVATextEdit.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.CodIVATextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.CodIVATextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.CodIVATextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.CodIVATextEdit.Properties.Appearance.Options.UseFont = True
        Me.CodIVATextEdit.Properties.Appearance.Options.UseForeColor = True
        Me.CodIVATextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.CodIVATextEdit.Size = New System.Drawing.Size(77, 28)
        Me.CodIVATextEdit.TabIndex = 54
        '
        'picCodEntidade
        '
        Me.picCodEntidade.Image = Global.G02_Nikola_04.My.Resources.Resources.ShadeSmall
        Me.picCodEntidade.Location = New System.Drawing.Point(597, 240)
        Me.picCodEntidade.Name = "picCodEntidade"
        Me.picCodEntidade.Size = New System.Drawing.Size(96, 42)
        Me.picCodEntidade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCodEntidade.TabIndex = 55
        Me.picCodEntidade.TabStop = False
        '
        'FLGDescontinuadoCheckEdit
        '
        Me.FLGDescontinuadoCheckEdit.Location = New System.Drawing.Point(872, 568)
        Me.FLGDescontinuadoCheckEdit.Name = "FLGDescontinuadoCheckEdit"
        Me.FLGDescontinuadoCheckEdit.Properties.Caption = "True"
        Me.FLGDescontinuadoCheckEdit.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Custom
        Me.FLGDescontinuadoCheckEdit.Properties.CheckBoxOptions.SvgImageSize = New System.Drawing.Size(30, 30)
        Me.FLGDescontinuadoCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.FLGDescontinuadoCheckEdit.Properties.ImageOptions.SvgImageChecked = Global.G02_Nikola_04.My.Resources.Resources.CheckEditCheckedSVG1
        Me.FLGDescontinuadoCheckEdit.Properties.ImageOptions.SvgImageSize = New System.Drawing.Size(30, 30)
        Me.FLGDescontinuadoCheckEdit.Properties.ImageOptions.SvgImageUnchecked = Global.G02_Nikola_04.My.Resources.Resources.CheckEditSVG1
        Me.FLGDescontinuadoCheckEdit.Properties.ValueGrayed = True
        Me.FLGDescontinuadoCheckEdit.Size = New System.Drawing.Size(40, 34)
        Me.FLGDescontinuadoCheckEdit.TabIndex = 42
        '
        'Data_Inicio_VigorDateEdit
        '
        Me.Data_Inicio_VigorDateEdit.EditValue = Nothing
        Me.Data_Inicio_VigorDateEdit.Location = New System.Drawing.Point(596, 473)
        Me.Data_Inicio_VigorDateEdit.Name = "Data_Inicio_VigorDateEdit"
        Me.Data_Inicio_VigorDateEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.Data_Inicio_VigorDateEdit.Properties.Appearance.Options.UseFont = True
        Me.Data_Inicio_VigorDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Data_Inicio_VigorDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Data_Inicio_VigorDateEdit.Size = New System.Drawing.Size(194, 30)
        Me.Data_Inicio_VigorDateEdit.TabIndex = 11
        '
        'Data_Fim_VigorDateEdit
        '
        Me.Data_Fim_VigorDateEdit.EditValue = Nothing
        Me.Data_Fim_VigorDateEdit.Location = New System.Drawing.Point(868, 473)
        Me.Data_Fim_VigorDateEdit.Name = "Data_Fim_VigorDateEdit"
        Me.Data_Fim_VigorDateEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.Data_Fim_VigorDateEdit.Properties.Appearance.Options.UseFont = True
        Me.Data_Fim_VigorDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Data_Fim_VigorDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Data_Fim_VigorDateEdit.Size = New System.Drawing.Size(194, 30)
        Me.Data_Fim_VigorDateEdit.TabIndex = 3
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
        'ucIVA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnMain)
        Me.Name = "ucIVA"
        Me.Size = New System.Drawing.Size(1632, 974)
        Me.pnMain.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DesignacaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoIVATextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxaIVATextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodIVATextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCodEntidade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FLGDescontinuadoCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Data_Inicio_VigorDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Data_Inicio_VigorDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Data_Fim_VigorDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Data_Fim_VigorDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnMain As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Data_Inicio_VigorDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Data_Fim_VigorDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents UC_NAV1 As UC_NAV
    Friend WithEvents FLGDescontinuadoCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents TaxaIVATextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CodIVATextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents picCodEntidade As PictureBox
    Friend WithEvents TipoIVATextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents DesignacaoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PictureBox2 As PictureBox
End Class
