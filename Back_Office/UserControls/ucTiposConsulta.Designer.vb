<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucTiposConsulta
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
        Dim lblDesignacao As System.Windows.Forms.Label
        Dim lblCodTC As System.Windows.Forms.Label
        Me.pnMain = New System.Windows.Forms.Panel()
        Me.UC_NAV1 = New G02_Nikola_04.UC_NAV()
        Me.DesignacaoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.picDesignacao = New System.Windows.Forms.PictureBox()
        Me.CodTipoConsultaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.picCodTC = New System.Windows.Forms.PictureBox()
        lblDesignacao = New System.Windows.Forms.Label()
        lblCodTC = New System.Windows.Forms.Label()
        Me.pnMain.SuspendLayout()
        CType(Me.DesignacaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDesignacao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodTipoConsultaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCodTC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnMain
        '
        Me.pnMain.Controls.Add(lblCodTC)
        Me.pnMain.Controls.Add(Me.CodTipoConsultaTextEdit)
        Me.pnMain.Controls.Add(Me.picCodTC)
        Me.pnMain.Controls.Add(Me.DesignacaoTextEdit)
        Me.pnMain.Controls.Add(lblDesignacao)
        Me.pnMain.Controls.Add(Me.picDesignacao)
        Me.pnMain.Location = New System.Drawing.Point(8, 89)
        Me.pnMain.Name = "pnMain"
        Me.pnMain.Size = New System.Drawing.Size(1611, 745)
        Me.pnMain.TabIndex = 1
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
        'DesignacaoTextEdit
        '
        Me.DesignacaoTextEdit.Enabled = False
        Me.DesignacaoTextEdit.Location = New System.Drawing.Point(543, 299)
        Me.DesignacaoTextEdit.Name = "DesignacaoTextEdit"
        Me.DesignacaoTextEdit.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.DesignacaoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.DesignacaoTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.DesignacaoTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.DesignacaoTextEdit.Properties.Appearance.Options.UseFont = True
        Me.DesignacaoTextEdit.Properties.Appearance.Options.UseForeColor = True
        Me.DesignacaoTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.DesignacaoTextEdit.Size = New System.Drawing.Size(351, 28)
        Me.DesignacaoTextEdit.TabIndex = 69
        '
        'lblDesignacao
        '
        lblDesignacao.AutoSize = True
        lblDesignacao.Font = New System.Drawing.Font("Tahoma", 10.0!)
        lblDesignacao.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        lblDesignacao.Location = New System.Drawing.Point(531, 272)
        lblDesignacao.Name = "lblDesignacao"
        lblDesignacao.Size = New System.Drawing.Size(78, 17)
        lblDesignacao.TabIndex = 70
        lblDesignacao.Text = "Designação"
        '
        'picDesignacao
        '
        Me.picDesignacao.Enabled = False
        Me.picDesignacao.Image = Global.G02_Nikola_04.My.Resources.Resources.Shade2
        Me.picDesignacao.Location = New System.Drawing.Point(532, 292)
        Me.picDesignacao.Name = "picDesignacao"
        Me.picDesignacao.Size = New System.Drawing.Size(374, 42)
        Me.picDesignacao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDesignacao.TabIndex = 71
        Me.picDesignacao.TabStop = False
        '
        'lblCodTC
        '
        lblCodTC.AutoSize = True
        lblCodTC.Font = New System.Drawing.Font("Tahoma", 10.0!)
        lblCodTC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        lblCodTC.Location = New System.Drawing.Point(530, 187)
        lblCodTC.Name = "lblCodTC"
        lblCodTC.Size = New System.Drawing.Size(177, 17)
        lblCodTC.TabIndex = 74
        lblCodTC.Text = "Código do Tipo da Consulta"
        '
        'CodTipoConsultaTextEdit
        '
        Me.CodTipoConsultaTextEdit.Enabled = False
        Me.CodTipoConsultaTextEdit.Location = New System.Drawing.Point(543, 214)
        Me.CodTipoConsultaTextEdit.Name = "CodTipoConsultaTextEdit"
        Me.CodTipoConsultaTextEdit.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.CodTipoConsultaTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.CodTipoConsultaTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.CodTipoConsultaTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.CodTipoConsultaTextEdit.Properties.Appearance.Options.UseFont = True
        Me.CodTipoConsultaTextEdit.Properties.Appearance.Options.UseForeColor = True
        Me.CodTipoConsultaTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.CodTipoConsultaTextEdit.Size = New System.Drawing.Size(77, 28)
        Me.CodTipoConsultaTextEdit.TabIndex = 72
        '
        'picCodTC
        '
        Me.picCodTC.Image = Global.G02_Nikola_04.My.Resources.Resources.ShadeSmall
        Me.picCodTC.Location = New System.Drawing.Point(533, 207)
        Me.picCodTC.Name = "picCodTC"
        Me.picCodTC.Size = New System.Drawing.Size(96, 42)
        Me.picCodTC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCodTC.TabIndex = 73
        Me.picCodTC.TabStop = False
        '
        'UC_TC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnMain)
        Me.Controls.Add(Me.UC_NAV1)
        Me.Name = "UC_TC"
        Me.Size = New System.Drawing.Size(1622, 856)
        Me.pnMain.ResumeLayout(False)
        Me.pnMain.PerformLayout()
        CType(Me.DesignacaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDesignacao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodTipoConsultaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCodTC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UC_NAV1 As UC_NAV
    Friend WithEvents pnMain As Panel
    Friend WithEvents DesignacaoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents picDesignacao As PictureBox
    Friend WithEvents CodTipoConsultaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents picCodTC As PictureBox
End Class
