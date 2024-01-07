<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Entidades
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
        Me.components = New System.ComponentModel.Container()
        Dim Cod_EntidadeLabel As System.Windows.Forms.Label
        Dim FLG_EntidadeLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim Cod_PaisLabel As System.Windows.Forms.Label
        Dim Num_TelefoneLabel As System.Windows.Forms.Label
        Dim Num_TelemovelLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim NIFLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim UtilizadorLabel As System.Windows.Forms.Label
        Dim Data_RegistoLabel As System.Windows.Forms.Label
        Me.ClsEntidadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UC_NAV11 = New G02_Gustavo_02.UC_NAV1()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UtilizadorTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PasswordTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.NIFTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.EmailTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Num_TelemovelTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Num_TelefoneTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Cod_PaisTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.NomeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.FLG_EntidadeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Cod_EntidadeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Data_RegistoDateEdit = New DevExpress.XtraEditors.DateEdit()
        Cod_EntidadeLabel = New System.Windows.Forms.Label()
        FLG_EntidadeLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        Cod_PaisLabel = New System.Windows.Forms.Label()
        Num_TelefoneLabel = New System.Windows.Forms.Label()
        Num_TelemovelLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        NIFLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        UtilizadorLabel = New System.Windows.Forms.Label()
        Data_RegistoLabel = New System.Windows.Forms.Label()
        CType(Me.ClsEntidadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.UtilizadorTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PasswordTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NIFTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmailTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Num_TelemovelTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Num_TelefoneTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cod_PaisTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NomeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FLG_EntidadeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cod_EntidadeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Data_RegistoDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Data_RegistoDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cod_EntidadeLabel
        '
        Cod_EntidadeLabel.AutoSize = True
        Cod_EntidadeLabel.Location = New System.Drawing.Point(42, 43)
        Cod_EntidadeLabel.Name = "Cod_EntidadeLabel"
        Cod_EntidadeLabel.Size = New System.Drawing.Size(74, 13)
        Cod_EntidadeLabel.TabIndex = 0
        Cod_EntidadeLabel.Text = "Cod Entidade:"
        '
        'FLG_EntidadeLabel
        '
        FLG_EntidadeLabel.AutoSize = True
        FLG_EntidadeLabel.Location = New System.Drawing.Point(41, 69)
        FLG_EntidadeLabel.Name = "FLG_EntidadeLabel"
        FLG_EntidadeLabel.Size = New System.Drawing.Size(75, 13)
        FLG_EntidadeLabel.TabIndex = 2
        FLG_EntidadeLabel.Text = "FLG Entidade:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(78, 95)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(38, 13)
        NomeLabel.TabIndex = 4
        NomeLabel.Text = "Nome:"
        '
        'Cod_PaisLabel
        '
        Cod_PaisLabel.AutoSize = True
        Cod_PaisLabel.Location = New System.Drawing.Point(64, 121)
        Cod_PaisLabel.Name = "Cod_PaisLabel"
        Cod_PaisLabel.Size = New System.Drawing.Size(52, 13)
        Cod_PaisLabel.TabIndex = 6
        Cod_PaisLabel.Text = "Cod Pais:"
        '
        'Num_TelefoneLabel
        '
        Num_TelefoneLabel.AutoSize = True
        Num_TelefoneLabel.Location = New System.Drawing.Point(39, 147)
        Num_TelefoneLabel.Name = "Num_TelefoneLabel"
        Num_TelefoneLabel.Size = New System.Drawing.Size(77, 13)
        Num_TelefoneLabel.TabIndex = 8
        Num_TelefoneLabel.Text = "Num Telefone:"
        '
        'Num_TelemovelLabel
        '
        Num_TelemovelLabel.AutoSize = True
        Num_TelemovelLabel.Location = New System.Drawing.Point(32, 173)
        Num_TelemovelLabel.Name = "Num_TelemovelLabel"
        Num_TelemovelLabel.Size = New System.Drawing.Size(84, 13)
        Num_TelemovelLabel.TabIndex = 10
        Num_TelemovelLabel.Text = "Num Telemovel:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(81, 199)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 12
        EmailLabel.Text = "Email:"
        '
        'NIFLabel
        '
        NIFLabel.AutoSize = True
        NIFLabel.Location = New System.Drawing.Point(89, 225)
        NIFLabel.Name = "NIFLabel"
        NIFLabel.Size = New System.Drawing.Size(27, 13)
        NIFLabel.TabIndex = 14
        NIFLabel.Text = "NIF:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(60, 277)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(56, 13)
        PasswordLabel.TabIndex = 18
        PasswordLabel.Text = "Password:"
        '
        'UtilizadorLabel
        '
        UtilizadorLabel.AutoSize = True
        UtilizadorLabel.Location = New System.Drawing.Point(63, 303)
        UtilizadorLabel.Name = "UtilizadorLabel"
        UtilizadorLabel.Size = New System.Drawing.Size(53, 13)
        UtilizadorLabel.TabIndex = 20
        UtilizadorLabel.Text = "Utilizador:"
        '
        'ClsEntidadesBindingSource
        '
        Me.ClsEntidadesBindingSource.DataSource = GetType(G02_Gustavo_02.ClsEntidades)
        '
        'UC_NAV11
        '
        Me.UC_NAV11.Location = New System.Drawing.Point(3, 0)
        Me.UC_NAV11.mFRM = Nothing
        Me.UC_NAV11.Name = "UC_NAV11"
        Me.UC_NAV11.Size = New System.Drawing.Size(985, 633)
        Me.UC_NAV11.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Data_RegistoLabel)
        Me.Panel1.Controls.Add(Me.Data_RegistoDateEdit)
        Me.Panel1.Controls.Add(UtilizadorLabel)
        Me.Panel1.Controls.Add(Me.UtilizadorTextEdit)
        Me.Panel1.Controls.Add(PasswordLabel)
        Me.Panel1.Controls.Add(Me.PasswordTextEdit)
        Me.Panel1.Controls.Add(NIFLabel)
        Me.Panel1.Controls.Add(Me.NIFTextEdit)
        Me.Panel1.Controls.Add(EmailLabel)
        Me.Panel1.Controls.Add(Me.EmailTextEdit)
        Me.Panel1.Controls.Add(Num_TelemovelLabel)
        Me.Panel1.Controls.Add(Me.Num_TelemovelTextEdit)
        Me.Panel1.Controls.Add(Num_TelefoneLabel)
        Me.Panel1.Controls.Add(Me.Num_TelefoneTextEdit)
        Me.Panel1.Controls.Add(Cod_PaisLabel)
        Me.Panel1.Controls.Add(Me.Cod_PaisTextEdit)
        Me.Panel1.Controls.Add(NomeLabel)
        Me.Panel1.Controls.Add(Me.NomeTextEdit)
        Me.Panel1.Controls.Add(FLG_EntidadeLabel)
        Me.Panel1.Controls.Add(Me.FLG_EntidadeTextEdit)
        Me.Panel1.Controls.Add(Cod_EntidadeLabel)
        Me.Panel1.Controls.Add(Me.Cod_EntidadeTextEdit)
        Me.Panel1.Location = New System.Drawing.Point(31, 102)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(828, 473)
        Me.Panel1.TabIndex = 1
        '
        'UtilizadorTextEdit
        '
        Me.UtilizadorTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClsEntidadesBindingSource, "Utilizador", True))
        Me.UtilizadorTextEdit.Location = New System.Drawing.Point(122, 300)
        Me.UtilizadorTextEdit.Name = "UtilizadorTextEdit"
        Me.UtilizadorTextEdit.Size = New System.Drawing.Size(220, 20)
        Me.UtilizadorTextEdit.TabIndex = 21
        '
        'PasswordTextEdit
        '
        Me.PasswordTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClsEntidadesBindingSource, "Password", True))
        Me.PasswordTextEdit.Location = New System.Drawing.Point(122, 274)
        Me.PasswordTextEdit.Name = "PasswordTextEdit"
        Me.PasswordTextEdit.Size = New System.Drawing.Size(220, 20)
        Me.PasswordTextEdit.TabIndex = 19
        '
        'NIFTextEdit
        '
        Me.NIFTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClsEntidadesBindingSource, "NIF", True))
        Me.NIFTextEdit.Location = New System.Drawing.Point(122, 222)
        Me.NIFTextEdit.Name = "NIFTextEdit"
        Me.NIFTextEdit.Size = New System.Drawing.Size(220, 20)
        Me.NIFTextEdit.TabIndex = 15
        '
        'EmailTextEdit
        '
        Me.EmailTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClsEntidadesBindingSource, "Email", True))
        Me.EmailTextEdit.Location = New System.Drawing.Point(122, 196)
        Me.EmailTextEdit.Name = "EmailTextEdit"
        Me.EmailTextEdit.Size = New System.Drawing.Size(220, 20)
        Me.EmailTextEdit.TabIndex = 13
        '
        'Num_TelemovelTextEdit
        '
        Me.Num_TelemovelTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClsEntidadesBindingSource, "Num_Telemovel", True))
        Me.Num_TelemovelTextEdit.Location = New System.Drawing.Point(122, 170)
        Me.Num_TelemovelTextEdit.Name = "Num_TelemovelTextEdit"
        Me.Num_TelemovelTextEdit.Size = New System.Drawing.Size(220, 20)
        Me.Num_TelemovelTextEdit.TabIndex = 11
        '
        'Num_TelefoneTextEdit
        '
        Me.Num_TelefoneTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClsEntidadesBindingSource, "Num_Telefone", True))
        Me.Num_TelefoneTextEdit.Location = New System.Drawing.Point(122, 144)
        Me.Num_TelefoneTextEdit.Name = "Num_TelefoneTextEdit"
        Me.Num_TelefoneTextEdit.Size = New System.Drawing.Size(220, 20)
        Me.Num_TelefoneTextEdit.TabIndex = 9
        '
        'Cod_PaisTextEdit
        '
        Me.Cod_PaisTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClsEntidadesBindingSource, "Cod_Pais", True))
        Me.Cod_PaisTextEdit.Location = New System.Drawing.Point(122, 118)
        Me.Cod_PaisTextEdit.Name = "Cod_PaisTextEdit"
        Me.Cod_PaisTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.Cod_PaisTextEdit.TabIndex = 7
        '
        'NomeTextEdit
        '
        Me.NomeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClsEntidadesBindingSource, "Nome", True))
        Me.NomeTextEdit.Location = New System.Drawing.Point(122, 92)
        Me.NomeTextEdit.Name = "NomeTextEdit"
        Me.NomeTextEdit.Size = New System.Drawing.Size(220, 20)
        Me.NomeTextEdit.TabIndex = 5
        '
        'FLG_EntidadeTextEdit
        '
        Me.FLG_EntidadeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClsEntidadesBindingSource, "FLG_Entidade", True))
        Me.FLG_EntidadeTextEdit.Location = New System.Drawing.Point(122, 66)
        Me.FLG_EntidadeTextEdit.Name = "FLG_EntidadeTextEdit"
        Me.FLG_EntidadeTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.FLG_EntidadeTextEdit.TabIndex = 3
        '
        'Cod_EntidadeTextEdit
        '
        Me.Cod_EntidadeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClsEntidadesBindingSource, "Cod_Entidade", True))
        Me.Cod_EntidadeTextEdit.Location = New System.Drawing.Point(122, 40)
        Me.Cod_EntidadeTextEdit.Name = "Cod_EntidadeTextEdit"
        Me.Cod_EntidadeTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.Cod_EntidadeTextEdit.TabIndex = 1
        '
        'Data_RegistoLabel
        '
        Data_RegistoLabel.AutoSize = True
        Data_RegistoLabel.Location = New System.Drawing.Point(44, 251)
        Data_RegistoLabel.Name = "Data_RegistoLabel"
        Data_RegistoLabel.Size = New System.Drawing.Size(72, 13)
        Data_RegistoLabel.TabIndex = 21
        Data_RegistoLabel.Text = "Data Registo:"
        '
        'Data_RegistoDateEdit
        '
        Me.Data_RegistoDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClsEntidadesBindingSource, "Data_Registo", True))
        Me.Data_RegistoDateEdit.EditValue = Nothing
        Me.Data_RegistoDateEdit.Location = New System.Drawing.Point(122, 248)
        Me.Data_RegistoDateEdit.Name = "Data_RegistoDateEdit"
        Me.Data_RegistoDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Data_RegistoDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Data_RegistoDateEdit.Size = New System.Drawing.Size(220, 20)
        Me.Data_RegistoDateEdit.TabIndex = 22
        '
        'UC_Entidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.UC_NAV11)
        Me.Name = "UC_Entidades"
        Me.Size = New System.Drawing.Size(1000, 650)
        CType(Me.ClsEntidadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.UtilizadorTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PasswordTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NIFTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmailTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Num_TelemovelTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Num_TelefoneTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cod_PaisTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NomeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FLG_EntidadeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cod_EntidadeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Data_RegistoDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Data_RegistoDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ClsEntidadesBindingSource As BindingSource
    Friend WithEvents UC_NAV11 As UC_NAV1
    Friend WithEvents Panel1 As Panel
    Friend WithEvents UtilizadorTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PasswordTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NIFTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EmailTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Num_TelemovelTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Num_TelefoneTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Cod_PaisTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NomeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FLG_EntidadeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Cod_EntidadeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Data_RegistoDateEdit As DevExpress.XtraEditors.DateEdit
End Class
