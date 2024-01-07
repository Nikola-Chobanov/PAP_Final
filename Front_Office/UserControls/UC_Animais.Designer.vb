<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Animais
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
        Dim Cod_AnimalLabel As System.Windows.Forms.Label
        Dim Nome_AnimalLabel As System.Windows.Forms.Label
        Dim Cod_EntidadeLabel As System.Windows.Forms.Label
        Dim Cod_Tipo_AnimalLabel As System.Windows.Forms.Label
        Dim Imagem_AnimalLabel As System.Windows.Forms.Label
        Me.UC_NAV11 = New G02_Gustavo_02.UC_NAV1()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Imagem_AnimalTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Cod_Tipo_AnimalTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Cod_EntidadeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Nome_AnimalTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Cod_AnimalTextEdit = New DevExpress.XtraEditors.TextEdit()
        Cod_AnimalLabel = New System.Windows.Forms.Label()
        Nome_AnimalLabel = New System.Windows.Forms.Label()
        Cod_EntidadeLabel = New System.Windows.Forms.Label()
        Cod_Tipo_AnimalLabel = New System.Windows.Forms.Label()
        Imagem_AnimalLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Imagem_AnimalTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cod_Tipo_AnimalTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cod_EntidadeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Nome_AnimalTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cod_AnimalTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cod_AnimalLabel
        '
        Cod_AnimalLabel.AutoSize = True
        Cod_AnimalLabel.Location = New System.Drawing.Point(46, 24)
        Cod_AnimalLabel.Name = "Cod_AnimalLabel"
        Cod_AnimalLabel.Size = New System.Drawing.Size(63, 13)
        Cod_AnimalLabel.TabIndex = 0
        Cod_AnimalLabel.Text = "Cod Animal:"
        '
        'Nome_AnimalLabel
        '
        Nome_AnimalLabel.AutoSize = True
        Nome_AnimalLabel.Location = New System.Drawing.Point(37, 55)
        Nome_AnimalLabel.Name = "Nome_AnimalLabel"
        Nome_AnimalLabel.Size = New System.Drawing.Size(72, 13)
        Nome_AnimalLabel.TabIndex = 2
        Nome_AnimalLabel.Text = "Nome Animal:"
        '
        'Cod_EntidadeLabel
        '
        Cod_EntidadeLabel.AutoSize = True
        Cod_EntidadeLabel.Location = New System.Drawing.Point(35, 81)
        Cod_EntidadeLabel.Name = "Cod_EntidadeLabel"
        Cod_EntidadeLabel.Size = New System.Drawing.Size(74, 13)
        Cod_EntidadeLabel.TabIndex = 4
        Cod_EntidadeLabel.Text = "Cod Entidade:"
        '
        'Cod_Tipo_AnimalLabel
        '
        Cod_Tipo_AnimalLabel.AutoSize = True
        Cod_Tipo_AnimalLabel.Location = New System.Drawing.Point(22, 107)
        Cod_Tipo_AnimalLabel.Name = "Cod_Tipo_AnimalLabel"
        Cod_Tipo_AnimalLabel.Size = New System.Drawing.Size(87, 13)
        Cod_Tipo_AnimalLabel.TabIndex = 6
        Cod_Tipo_AnimalLabel.Text = "Cod Tipo Animal:"
        '
        'Imagem_AnimalLabel
        '
        Imagem_AnimalLabel.AutoSize = True
        Imagem_AnimalLabel.Location = New System.Drawing.Point(28, 133)
        Imagem_AnimalLabel.Name = "Imagem_AnimalLabel"
        Imagem_AnimalLabel.Size = New System.Drawing.Size(81, 13)
        Imagem_AnimalLabel.TabIndex = 8
        Imagem_AnimalLabel.Text = "Imagem Animal:"
        '
        'UC_NAV11
        '
        Me.UC_NAV11.Location = New System.Drawing.Point(3, 0)
        Me.UC_NAV11.mFRM = Nothing
        Me.UC_NAV11.Name = "UC_NAV11"
        Me.UC_NAV11.Size = New System.Drawing.Size(765, 607)
        Me.UC_NAV11.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Imagem_AnimalLabel)
        Me.Panel1.Controls.Add(Me.Imagem_AnimalTextEdit)
        Me.Panel1.Controls.Add(Cod_Tipo_AnimalLabel)
        Me.Panel1.Controls.Add(Me.Cod_Tipo_AnimalTextEdit)
        Me.Panel1.Controls.Add(Cod_EntidadeLabel)
        Me.Panel1.Controls.Add(Me.Cod_EntidadeTextEdit)
        Me.Panel1.Controls.Add(Nome_AnimalLabel)
        Me.Panel1.Controls.Add(Me.Nome_AnimalTextEdit)
        Me.Panel1.Controls.Add(Cod_AnimalLabel)
        Me.Panel1.Controls.Add(Me.Cod_AnimalTextEdit)
        Me.Panel1.Location = New System.Drawing.Point(23, 88)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(726, 503)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(436, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(206, 170)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Imagem_AnimalTextEdit
        '
        Me.Imagem_AnimalTextEdit.Location = New System.Drawing.Point(115, 130)
        Me.Imagem_AnimalTextEdit.Name = "Imagem_AnimalTextEdit"
        Me.Imagem_AnimalTextEdit.Size = New System.Drawing.Size(164, 20)
        Me.Imagem_AnimalTextEdit.TabIndex = 9
        '
        'Cod_Tipo_AnimalTextEdit
        '
        Me.Cod_Tipo_AnimalTextEdit.Location = New System.Drawing.Point(115, 104)
        Me.Cod_Tipo_AnimalTextEdit.Name = "Cod_Tipo_AnimalTextEdit"
        Me.Cod_Tipo_AnimalTextEdit.Size = New System.Drawing.Size(164, 20)
        Me.Cod_Tipo_AnimalTextEdit.TabIndex = 7
        '
        'Cod_EntidadeTextEdit
        '
        Me.Cod_EntidadeTextEdit.Location = New System.Drawing.Point(115, 78)
        Me.Cod_EntidadeTextEdit.Name = "Cod_EntidadeTextEdit"
        Me.Cod_EntidadeTextEdit.Size = New System.Drawing.Size(164, 20)
        Me.Cod_EntidadeTextEdit.TabIndex = 5
        '
        'Nome_AnimalTextEdit
        '
        Me.Nome_AnimalTextEdit.Location = New System.Drawing.Point(115, 52)
        Me.Nome_AnimalTextEdit.Name = "Nome_AnimalTextEdit"
        Me.Nome_AnimalTextEdit.Size = New System.Drawing.Size(164, 20)
        Me.Nome_AnimalTextEdit.TabIndex = 3
        '
        'Cod_AnimalTextEdit
        '
        Me.Cod_AnimalTextEdit.Location = New System.Drawing.Point(115, 21)
        Me.Cod_AnimalTextEdit.Name = "Cod_AnimalTextEdit"
        Me.Cod_AnimalTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.Cod_AnimalTextEdit.TabIndex = 1
        '
        'UC_Animais
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.UC_NAV11)
        Me.Name = "UC_Animais"
        Me.Size = New System.Drawing.Size(984, 611)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Imagem_AnimalTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cod_Tipo_AnimalTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cod_EntidadeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Nome_AnimalTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cod_AnimalTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UC_NAV11 As UC_NAV1
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Imagem_AnimalTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Cod_Tipo_AnimalTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Cod_EntidadeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Nome_AnimalTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Cod_AnimalTextEdit As DevExpress.XtraEditors.TextEdit
End Class
