<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucUtilizador
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
        Me.txtUtilizador = New System.Windows.Forms.TextBox()
        Me.picUtilizador = New System.Windows.Forms.PictureBox()
        CType(Me.picUtilizador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUtilizador
        '
        Me.txtUtilizador.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtUtilizador.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUtilizador.Font = New System.Drawing.Font("NewsGoth Cn BT", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUtilizador.Location = New System.Drawing.Point(6, 3)
        Me.txtUtilizador.Multiline = True
        Me.txtUtilizador.Name = "txtUtilizador"
        Me.txtUtilizador.Size = New System.Drawing.Size(171, 20)
        Me.txtUtilizador.TabIndex = 1
        Me.txtUtilizador.Tag = "0"
        '
        'picUtilizador
        '
        Me.picUtilizador.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.picUtilizador.BackColor = System.Drawing.Color.Transparent
        Me.picUtilizador.Image = Global.G02_Gustavo_02.My.Resources.Resources.backLoginShade
        Me.picUtilizador.Location = New System.Drawing.Point(0, 0)
        Me.picUtilizador.Name = "picUtilizador"
        Me.picUtilizador.Size = New System.Drawing.Size(183, 30)
        Me.picUtilizador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picUtilizador.TabIndex = 2
        Me.picUtilizador.TabStop = False
        '
        'Utilizador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.txtUtilizador)
        Me.Controls.Add(Me.picUtilizador)
        Me.Name = "Utilizador"
        Me.Size = New System.Drawing.Size(183, 30)
        CType(Me.picUtilizador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUtilizador As TextBox
    Friend WithEvents picUtilizador As PictureBox
End Class
