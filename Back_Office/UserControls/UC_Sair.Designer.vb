<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Sair
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
        Me.picSair = New System.Windows.Forms.PictureBox()
        CType(Me.picSair, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picSair
        '
        Me.picSair.BackColor = System.Drawing.Color.Transparent
        Me.picSair.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picSair.Image = Global.G02_Nikola_04.My.Resources.Resources.SairLogin
        Me.picSair.Location = New System.Drawing.Point(0, 0)
        Me.picSair.Name = "picSair"
        Me.picSair.Size = New System.Drawing.Size(120, 33)
        Me.picSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSair.TabIndex = 0
        Me.picSair.TabStop = False
        '
        'UC_Sair
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BackgroundImage = Global.G02_Nikola_04.My.Resources.Resources.SairLogin
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.picSair)
        Me.DoubleBuffered = True
        Me.Name = "UC_Sair"
        Me.Size = New System.Drawing.Size(120, 33)
        CType(Me.picSair, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picSair As PictureBox
End Class
