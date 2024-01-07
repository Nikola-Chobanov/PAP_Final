<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Doc
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
        Dim Num_DocLabel As System.Windows.Forms.Label
        Dim FLG_Tipo_DocLabel As System.Windows.Forms.Label
        Dim Cod_EntidadeLabel As System.Windows.Forms.Label
        Dim DesignacaoLabel As System.Windows.Forms.Label
        Dim Data_DocLabel As System.Windows.Forms.Label
        Dim Taxa_DescontoLabel As System.Windows.Forms.Label
        Dim Data_VencimentoLabel As System.Windows.Forms.Label
        Me.UC_NAV11 = New G02_Gustavo_02.UC_NAV1()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Data_VencimentoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Taxa_DescontoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Data_DocDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DesignacaoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Cod_EntidadeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.FLG_Tipo_DocTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Num_DocTextEdit = New DevExpress.XtraEditors.TextEdit()
        Num_DocLabel = New System.Windows.Forms.Label()
        FLG_Tipo_DocLabel = New System.Windows.Forms.Label()
        Cod_EntidadeLabel = New System.Windows.Forms.Label()
        DesignacaoLabel = New System.Windows.Forms.Label()
        Data_DocLabel = New System.Windows.Forms.Label()
        Taxa_DescontoLabel = New System.Windows.Forms.Label()
        Data_VencimentoLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Taxa_DescontoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DesignacaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cod_EntidadeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FLG_Tipo_DocTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Num_DocTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Num_DocLabel
        '
        Num_DocLabel.AutoSize = True
        Num_DocLabel.Location = New System.Drawing.Point(35, 28)
        Num_DocLabel.Name = "Num_DocLabel"
        Num_DocLabel.Size = New System.Drawing.Size(55, 13)
        Num_DocLabel.TabIndex = 0
        Num_DocLabel.Text = "Num Doc:"
        '
        'FLG_Tipo_DocLabel
        '
        FLG_Tipo_DocLabel.AutoSize = True
        FLG_Tipo_DocLabel.Location = New System.Drawing.Point(13, 54)
        FLG_Tipo_DocLabel.Name = "FLG_Tipo_DocLabel"
        FLG_Tipo_DocLabel.Size = New System.Drawing.Size(77, 13)
        FLG_Tipo_DocLabel.TabIndex = 2
        FLG_Tipo_DocLabel.Text = "FLG Tipo Doc:"
        '
        'Cod_EntidadeLabel
        '
        Cod_EntidadeLabel.AutoSize = True
        Cod_EntidadeLabel.Location = New System.Drawing.Point(16, 80)
        Cod_EntidadeLabel.Name = "Cod_EntidadeLabel"
        Cod_EntidadeLabel.Size = New System.Drawing.Size(74, 13)
        Cod_EntidadeLabel.TabIndex = 4
        Cod_EntidadeLabel.Text = "Cod Entidade:"
        '
        'DesignacaoLabel
        '
        DesignacaoLabel.AutoSize = True
        DesignacaoLabel.Location = New System.Drawing.Point(23, 106)
        DesignacaoLabel.Name = "DesignacaoLabel"
        DesignacaoLabel.Size = New System.Drawing.Size(67, 13)
        DesignacaoLabel.TabIndex = 6
        DesignacaoLabel.Text = "Designacao:"
        '
        'Data_DocLabel
        '
        Data_DocLabel.AutoSize = True
        Data_DocLabel.Location = New System.Drawing.Point(34, 133)
        Data_DocLabel.Name = "Data_DocLabel"
        Data_DocLabel.Size = New System.Drawing.Size(56, 13)
        Data_DocLabel.TabIndex = 8
        Data_DocLabel.Text = "Data Doc:"
        '
        'Taxa_DescontoLabel
        '
        Taxa_DescontoLabel.AutoSize = True
        Taxa_DescontoLabel.Location = New System.Drawing.Point(7, 158)
        Taxa_DescontoLabel.Name = "Taxa_DescontoLabel"
        Taxa_DescontoLabel.Size = New System.Drawing.Size(83, 13)
        Taxa_DescontoLabel.TabIndex = 10
        Taxa_DescontoLabel.Text = "Taxa Desconto:"
        '
        'Data_VencimentoLabel
        '
        Data_VencimentoLabel.AutoSize = True
        Data_VencimentoLabel.Location = New System.Drawing.Point(-2, 185)
        Data_VencimentoLabel.Name = "Data_VencimentoLabel"
        Data_VencimentoLabel.Size = New System.Drawing.Size(92, 13)
        Data_VencimentoLabel.TabIndex = 12
        Data_VencimentoLabel.Text = "Data Vencimento:"
        '
        'UC_NAV11
        '
        Me.UC_NAV11.Location = New System.Drawing.Point(3, 3)
        Me.UC_NAV11.mFRM = Nothing
        Me.UC_NAV11.Name = "UC_NAV11"
        Me.UC_NAV11.Size = New System.Drawing.Size(885, 643)
        Me.UC_NAV11.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Data_VencimentoLabel)
        Me.Panel1.Controls.Add(Me.Data_VencimentoDateTimePicker)
        Me.Panel1.Controls.Add(Taxa_DescontoLabel)
        Me.Panel1.Controls.Add(Me.Taxa_DescontoTextEdit)
        Me.Panel1.Controls.Add(Data_DocLabel)
        Me.Panel1.Controls.Add(Me.Data_DocDateTimePicker)
        Me.Panel1.Controls.Add(DesignacaoLabel)
        Me.Panel1.Controls.Add(Me.DesignacaoTextEdit)
        Me.Panel1.Controls.Add(Cod_EntidadeLabel)
        Me.Panel1.Controls.Add(Me.Cod_EntidadeTextEdit)
        Me.Panel1.Controls.Add(FLG_Tipo_DocLabel)
        Me.Panel1.Controls.Add(Me.FLG_Tipo_DocTextEdit)
        Me.Panel1.Controls.Add(Num_DocLabel)
        Me.Panel1.Controls.Add(Me.Num_DocTextEdit)
        Me.Panel1.Location = New System.Drawing.Point(18, 83)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(984, 611)
        Me.Panel1.TabIndex = 1
        '
        'Data_VencimentoDateTimePicker
        '
        Me.Data_VencimentoDateTimePicker.Location = New System.Drawing.Point(96, 181)
        Me.Data_VencimentoDateTimePicker.Name = "Data_VencimentoDateTimePicker"
        Me.Data_VencimentoDateTimePicker.Size = New System.Drawing.Size(181, 20)
        Me.Data_VencimentoDateTimePicker.TabIndex = 13
        '
        'Taxa_DescontoTextEdit
        '
        Me.Taxa_DescontoTextEdit.Location = New System.Drawing.Point(96, 155)
        Me.Taxa_DescontoTextEdit.Name = "Taxa_DescontoTextEdit"
        Me.Taxa_DescontoTextEdit.Size = New System.Drawing.Size(86, 20)
        Me.Taxa_DescontoTextEdit.TabIndex = 11
        '
        'Data_DocDateTimePicker
        '
        Me.Data_DocDateTimePicker.Location = New System.Drawing.Point(96, 129)
        Me.Data_DocDateTimePicker.Name = "Data_DocDateTimePicker"
        Me.Data_DocDateTimePicker.Size = New System.Drawing.Size(181, 20)
        Me.Data_DocDateTimePicker.TabIndex = 9
        '
        'DesignacaoTextEdit
        '
        Me.DesignacaoTextEdit.Location = New System.Drawing.Point(96, 103)
        Me.DesignacaoTextEdit.Name = "DesignacaoTextEdit"
        Me.DesignacaoTextEdit.Size = New System.Drawing.Size(86, 20)
        Me.DesignacaoTextEdit.TabIndex = 7
        '
        'Cod_EntidadeTextEdit
        '
        Me.Cod_EntidadeTextEdit.Location = New System.Drawing.Point(96, 77)
        Me.Cod_EntidadeTextEdit.Name = "Cod_EntidadeTextEdit"
        Me.Cod_EntidadeTextEdit.Size = New System.Drawing.Size(86, 20)
        Me.Cod_EntidadeTextEdit.TabIndex = 5
        '
        'FLG_Tipo_DocTextEdit
        '
        Me.FLG_Tipo_DocTextEdit.Location = New System.Drawing.Point(96, 51)
        Me.FLG_Tipo_DocTextEdit.Name = "FLG_Tipo_DocTextEdit"
        Me.FLG_Tipo_DocTextEdit.Size = New System.Drawing.Size(86, 20)
        Me.FLG_Tipo_DocTextEdit.TabIndex = 3
        '
        'Num_DocTextEdit
        '
        Me.Num_DocTextEdit.Location = New System.Drawing.Point(96, 25)
        Me.Num_DocTextEdit.Name = "Num_DocTextEdit"
        Me.Num_DocTextEdit.Size = New System.Drawing.Size(86, 20)
        Me.Num_DocTextEdit.TabIndex = 1
        '
        'UC_Doc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.UC_NAV11)
        Me.Name = "UC_Doc"
        Me.Size = New System.Drawing.Size(991, 672)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Taxa_DescontoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DesignacaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cod_EntidadeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FLG_Tipo_DocTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Num_DocTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UC_NAV11 As UC_NAV1
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Data_VencimentoDateTimePicker As DateTimePicker
    Friend WithEvents Taxa_DescontoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Data_DocDateTimePicker As DateTimePicker
    Friend WithEvents DesignacaoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Cod_EntidadeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FLG_Tipo_DocTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Num_DocTextEdit As DevExpress.XtraEditors.TextEdit
End Class
