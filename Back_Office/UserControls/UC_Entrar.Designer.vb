<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Entrar
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
        Me.picEntrar = New System.Windows.Forms.PictureBox()
        CType(Me.picEntrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picEntrar
        '
        Me.picEntrar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picEntrar.Image = Global.G02_Nikola_04.My.Resources.Resources.Entrar
        Me.picEntrar.Location = New System.Drawing.Point(0, 0)
        Me.picEntrar.Name = "picEntrar"
        Me.picEntrar.Size = New System.Drawing.Size(120, 33)
        Me.picEntrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEntrar.TabIndex = 0
        Me.picEntrar.TabStop = False
        '
        'UC_Entrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BackgroundImage = Global.G02_Nikola_04.My.Resources.Resources.Entrar
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.picEntrar)
        Me.DoubleBuffered = True
        Me.Name = "UC_Entrar"
        Me.Size = New System.Drawing.Size(120, 33)
        CType(Me.picEntrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picEntrar As PictureBox
End Class
