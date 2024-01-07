<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Consultas
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
        Dim Cod_ConsultaLabel As System.Windows.Forms.Label
        Dim Cod_Tipo_ConsultaLabel As System.Windows.Forms.Label
        Dim Tipo_ConsultaLabel As System.Windows.Forms.Label
        Dim Tipo_UtenteLabel As System.Windows.Forms.Label
        Dim MedicoLabel As System.Windows.Forms.Label
        Dim Cod_EntidadeLabel As System.Windows.Forms.Label
        Dim ObservacoesLabel As System.Windows.Forms.Label
        Dim AuxiliarLabel As System.Windows.Forms.Label
        Dim HorarioLabel As System.Windows.Forms.Label
        Me.UC_NAV11 = New G02_Gustavo_02.UC_NAV1()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.HorarioDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.AuxiliarTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ObservacoesTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Cod_EntidadeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.MedicoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Tipo_UtenteTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Tipo_ConsultaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Cod_Tipo_ConsultaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Cod_ConsultaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Cod_ConsultaLabel = New System.Windows.Forms.Label()
        Cod_Tipo_ConsultaLabel = New System.Windows.Forms.Label()
        Tipo_ConsultaLabel = New System.Windows.Forms.Label()
        Tipo_UtenteLabel = New System.Windows.Forms.Label()
        MedicoLabel = New System.Windows.Forms.Label()
        Cod_EntidadeLabel = New System.Windows.Forms.Label()
        ObservacoesLabel = New System.Windows.Forms.Label()
        AuxiliarLabel = New System.Windows.Forms.Label()
        HorarioLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.HorarioDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HorarioDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuxiliarTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObservacoesTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cod_EntidadeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tipo_UtenteTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tipo_ConsultaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cod_Tipo_ConsultaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cod_ConsultaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cod_ConsultaLabel
        '
        Cod_ConsultaLabel.AutoSize = True
        Cod_ConsultaLabel.Location = New System.Drawing.Point(56, 61)
        Cod_ConsultaLabel.Name = "Cod_ConsultaLabel"
        Cod_ConsultaLabel.Size = New System.Drawing.Size(73, 13)
        Cod_ConsultaLabel.TabIndex = 0
        Cod_ConsultaLabel.Text = "Cod Consulta:"
        '
        'Cod_Tipo_ConsultaLabel
        '
        Cod_Tipo_ConsultaLabel.AutoSize = True
        Cod_Tipo_ConsultaLabel.Location = New System.Drawing.Point(32, 87)
        Cod_Tipo_ConsultaLabel.Name = "Cod_Tipo_ConsultaLabel"
        Cod_Tipo_ConsultaLabel.Size = New System.Drawing.Size(97, 13)
        Cod_Tipo_ConsultaLabel.TabIndex = 2
        Cod_Tipo_ConsultaLabel.Text = "Cod Tipo Consulta:"
        '
        'Tipo_ConsultaLabel
        '
        Tipo_ConsultaLabel.AutoSize = True
        Tipo_ConsultaLabel.Location = New System.Drawing.Point(54, 113)
        Tipo_ConsultaLabel.Name = "Tipo_ConsultaLabel"
        Tipo_ConsultaLabel.Size = New System.Drawing.Size(75, 13)
        Tipo_ConsultaLabel.TabIndex = 4
        Tipo_ConsultaLabel.Text = "Tipo Consulta:"
        '
        'Tipo_UtenteLabel
        '
        Tipo_UtenteLabel.AutoSize = True
        Tipo_UtenteLabel.Location = New System.Drawing.Point(63, 195)
        Tipo_UtenteLabel.Name = "Tipo_UtenteLabel"
        Tipo_UtenteLabel.Size = New System.Drawing.Size(66, 13)
        Tipo_UtenteLabel.TabIndex = 6
        Tipo_UtenteLabel.Text = "Tipo Utente:"
        '
        'MedicoLabel
        '
        MedicoLabel.AutoSize = True
        MedicoLabel.Location = New System.Drawing.Point(84, 165)
        MedicoLabel.Name = "MedicoLabel"
        MedicoLabel.Size = New System.Drawing.Size(45, 13)
        MedicoLabel.TabIndex = 10
        MedicoLabel.Text = "Medico:"
        '
        'Cod_EntidadeLabel
        '
        Cod_EntidadeLabel.AutoSize = True
        Cod_EntidadeLabel.Location = New System.Drawing.Point(55, 221)
        Cod_EntidadeLabel.Name = "Cod_EntidadeLabel"
        Cod_EntidadeLabel.Size = New System.Drawing.Size(74, 13)
        Cod_EntidadeLabel.TabIndex = 12
        Cod_EntidadeLabel.Text = "Cod Entidade:"
        '
        'ObservacoesLabel
        '
        ObservacoesLabel.AutoSize = True
        ObservacoesLabel.Location = New System.Drawing.Point(56, 247)
        ObservacoesLabel.Name = "ObservacoesLabel"
        ObservacoesLabel.Size = New System.Drawing.Size(73, 13)
        ObservacoesLabel.TabIndex = 14
        ObservacoesLabel.Text = "Observacoes:"
        '
        'AuxiliarLabel
        '
        AuxiliarLabel.AutoSize = True
        AuxiliarLabel.Location = New System.Drawing.Point(86, 273)
        AuxiliarLabel.Name = "AuxiliarLabel"
        AuxiliarLabel.Size = New System.Drawing.Size(43, 13)
        AuxiliarLabel.TabIndex = 16
        AuxiliarLabel.Text = "Auxiliar:"
        '
        'HorarioLabel
        '
        HorarioLabel.AutoSize = True
        HorarioLabel.Location = New System.Drawing.Point(85, 139)
        HorarioLabel.Name = "HorarioLabel"
        HorarioLabel.Size = New System.Drawing.Size(44, 13)
        HorarioLabel.TabIndex = 17
        HorarioLabel.Text = "Horario:"
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
        Me.Panel1.Controls.Add(HorarioLabel)
        Me.Panel1.Controls.Add(Me.HorarioDateEdit)
        Me.Panel1.Controls.Add(AuxiliarLabel)
        Me.Panel1.Controls.Add(Me.AuxiliarTextEdit)
        Me.Panel1.Controls.Add(ObservacoesLabel)
        Me.Panel1.Controls.Add(Me.ObservacoesTextEdit)
        Me.Panel1.Controls.Add(Cod_EntidadeLabel)
        Me.Panel1.Controls.Add(Me.Cod_EntidadeTextEdit)
        Me.Panel1.Controls.Add(MedicoLabel)
        Me.Panel1.Controls.Add(Me.MedicoTextEdit)
        Me.Panel1.Controls.Add(Tipo_UtenteLabel)
        Me.Panel1.Controls.Add(Me.Tipo_UtenteTextEdit)
        Me.Panel1.Controls.Add(Tipo_ConsultaLabel)
        Me.Panel1.Controls.Add(Me.Tipo_ConsultaTextEdit)
        Me.Panel1.Controls.Add(Cod_Tipo_ConsultaLabel)
        Me.Panel1.Controls.Add(Me.Cod_Tipo_ConsultaTextEdit)
        Me.Panel1.Controls.Add(Cod_ConsultaLabel)
        Me.Panel1.Controls.Add(Me.Cod_ConsultaTextEdit)
        Me.Panel1.Location = New System.Drawing.Point(20, 88)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(845, 522)
        Me.Panel1.TabIndex = 1
        '
        'HorarioDateEdit
        '
        Me.HorarioDateEdit.EditValue = Nothing
        Me.HorarioDateEdit.Location = New System.Drawing.Point(135, 136)
        Me.HorarioDateEdit.Name = "HorarioDateEdit"
        Me.HorarioDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.HorarioDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.HorarioDateEdit.Size = New System.Drawing.Size(106, 20)
        Me.HorarioDateEdit.TabIndex = 18
        '
        'AuxiliarTextEdit
        '
        Me.AuxiliarTextEdit.Location = New System.Drawing.Point(135, 270)
        Me.AuxiliarTextEdit.Name = "AuxiliarTextEdit"
        Me.AuxiliarTextEdit.Size = New System.Drawing.Size(213, 20)
        Me.AuxiliarTextEdit.TabIndex = 17
        '
        'ObservacoesTextEdit
        '
        Me.ObservacoesTextEdit.Location = New System.Drawing.Point(135, 244)
        Me.ObservacoesTextEdit.Name = "ObservacoesTextEdit"
        Me.ObservacoesTextEdit.Size = New System.Drawing.Size(674, 20)
        Me.ObservacoesTextEdit.TabIndex = 15
        '
        'Cod_EntidadeTextEdit
        '
        Me.Cod_EntidadeTextEdit.Location = New System.Drawing.Point(135, 218)
        Me.Cod_EntidadeTextEdit.Name = "Cod_EntidadeTextEdit"
        Me.Cod_EntidadeTextEdit.Size = New System.Drawing.Size(106, 20)
        Me.Cod_EntidadeTextEdit.TabIndex = 13
        '
        'MedicoTextEdit
        '
        Me.MedicoTextEdit.Location = New System.Drawing.Point(135, 166)
        Me.MedicoTextEdit.Name = "MedicoTextEdit"
        Me.MedicoTextEdit.Size = New System.Drawing.Size(213, 20)
        Me.MedicoTextEdit.TabIndex = 11
        '
        'Tipo_UtenteTextEdit
        '
        Me.Tipo_UtenteTextEdit.Location = New System.Drawing.Point(135, 192)
        Me.Tipo_UtenteTextEdit.Name = "Tipo_UtenteTextEdit"
        Me.Tipo_UtenteTextEdit.Size = New System.Drawing.Size(106, 20)
        Me.Tipo_UtenteTextEdit.TabIndex = 7
        '
        'Tipo_ConsultaTextEdit
        '
        Me.Tipo_ConsultaTextEdit.Location = New System.Drawing.Point(135, 110)
        Me.Tipo_ConsultaTextEdit.Name = "Tipo_ConsultaTextEdit"
        Me.Tipo_ConsultaTextEdit.Size = New System.Drawing.Size(213, 20)
        Me.Tipo_ConsultaTextEdit.TabIndex = 5
        '
        'Cod_Tipo_ConsultaTextEdit
        '
        Me.Cod_Tipo_ConsultaTextEdit.Location = New System.Drawing.Point(135, 84)
        Me.Cod_Tipo_ConsultaTextEdit.Name = "Cod_Tipo_ConsultaTextEdit"
        Me.Cod_Tipo_ConsultaTextEdit.Size = New System.Drawing.Size(106, 20)
        Me.Cod_Tipo_ConsultaTextEdit.TabIndex = 3
        '
        'Cod_ConsultaTextEdit
        '
        Me.Cod_ConsultaTextEdit.Location = New System.Drawing.Point(135, 58)
        Me.Cod_ConsultaTextEdit.Name = "Cod_ConsultaTextEdit"
        Me.Cod_ConsultaTextEdit.Size = New System.Drawing.Size(106, 20)
        Me.Cod_ConsultaTextEdit.TabIndex = 1
        '
        'UC_Consultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.UC_NAV11)
        Me.Name = "UC_Consultas"
        Me.Size = New System.Drawing.Size(984, 611)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.HorarioDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HorarioDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuxiliarTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObservacoesTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cod_EntidadeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tipo_UtenteTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tipo_ConsultaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cod_Tipo_ConsultaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cod_ConsultaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UC_NAV11 As UC_NAV1
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ObservacoesTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Cod_EntidadeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents MedicoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Tipo_UtenteTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Tipo_ConsultaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Cod_Tipo_ConsultaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Cod_ConsultaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AuxiliarTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents HorarioDateEdit As DevExpress.XtraEditors.DateEdit
End Class
