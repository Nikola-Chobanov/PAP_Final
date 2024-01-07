<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucVeterinario
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
        Me.picVeterinario = New System.Windows.Forms.PictureBox()
        Me.picFotografia = New System.Windows.Forms.PictureBox()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblTelefone = New System.Windows.Forms.Label()
        Me.lblTelemovel = New System.Windows.Forms.Label()
        CType(Me.picVeterinario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFotografia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picVeterinario
        '
        Me.picVeterinario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picVeterinario.Image = Global.G02_Gustavo_02.My.Resources.Resources.picVeterinario
        Me.picVeterinario.Location = New System.Drawing.Point(0, 0)
        Me.picVeterinario.Name = "picVeterinario"
        Me.picVeterinario.Size = New System.Drawing.Size(344, 480)
        Me.picVeterinario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picVeterinario.TabIndex = 0
        Me.picVeterinario.TabStop = False
        '
        'picFotografia
        '
        Me.picFotografia.Location = New System.Drawing.Point(32, 38)
        Me.picFotografia.Name = "picFotografia"
        Me.picFotografia.Size = New System.Drawing.Size(277, 225)
        Me.picFotografia.TabIndex = 1
        Me.picFotografia.TabStop = False
        '
        'lblNome
        '
        Me.lblNome.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNome.AutoSize = True
        Me.lblNome.BackColor = System.Drawing.SystemColors.Window
        Me.lblNome.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!)
        Me.lblNome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.lblNome.Location = New System.Drawing.Point(28, 275)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(60, 23)
        Me.lblNome.TabIndex = 18
        Me.lblNome.Text = "Nome"
        Me.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmail
        '
        Me.lblEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.SystemColors.Window
        Me.lblEmail.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!)
        Me.lblEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.lblEmail.Location = New System.Drawing.Point(28, 329)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(56, 23)
        Me.lblEmail.TabIndex = 19
        Me.lblEmail.Text = "Email"
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTelefone
        '
        Me.lblTelefone.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTelefone.AutoSize = True
        Me.lblTelefone.BackColor = System.Drawing.SystemColors.Window
        Me.lblTelefone.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!)
        Me.lblTelefone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.lblTelefone.Location = New System.Drawing.Point(28, 387)
        Me.lblTelefone.Name = "lblTelefone"
        Me.lblTelefone.Size = New System.Drawing.Size(148, 23)
        Me.lblTelefone.TabIndex = 20
        Me.lblTelefone.Text = "NúmeroTelefone"
        Me.lblTelefone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTelemovel
        '
        Me.lblTelemovel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTelemovel.AutoSize = True
        Me.lblTelemovel.BackColor = System.Drawing.SystemColors.Window
        Me.lblTelemovel.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!)
        Me.lblTelemovel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.lblTelemovel.Location = New System.Drawing.Point(28, 419)
        Me.lblTelemovel.Name = "lblTelemovel"
        Me.lblTelemovel.Size = New System.Drawing.Size(163, 23)
        Me.lblTelemovel.TabIndex = 21
        Me.lblTelemovel.Text = "NúmeroTelemovel"
        Me.lblTelemovel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ucVeterinario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblTelemovel)
        Me.Controls.Add(Me.lblTelefone)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.picFotografia)
        Me.Controls.Add(Me.picVeterinario)
        Me.Name = "ucVeterinario"
        Me.Size = New System.Drawing.Size(344, 480)
        CType(Me.picVeterinario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFotografia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picVeterinario As PictureBox
    Friend WithEvents picFotografia As PictureBox
    Friend WithEvents lblNome As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblTelefone As Label
    Friend WithEvents lblTelemovel As Label
End Class
