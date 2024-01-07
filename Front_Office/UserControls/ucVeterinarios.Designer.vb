<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucVeterinarios
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
        Me.pnMain = New System.Windows.Forms.Panel()
        Me.lblVeterinarios = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnMain
        '
        Me.pnMain.Controls.Add(Me.lblVeterinarios)
        Me.pnMain.Controls.Add(Me.FlowLayoutPanel)
        Me.pnMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnMain.Location = New System.Drawing.Point(0, 0)
        Me.pnMain.Name = "pnMain"
        Me.pnMain.Size = New System.Drawing.Size(1757, 823)
        Me.pnMain.TabIndex = 0
        '
        'lblVeterinarios
        '
        Me.lblVeterinarios.AutoSize = True
        Me.lblVeterinarios.BackColor = System.Drawing.Color.Transparent
        Me.lblVeterinarios.Font = New System.Drawing.Font("Berlin Sans FB", 30.0!)
        Me.lblVeterinarios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.lblVeterinarios.Location = New System.Drawing.Point(47, 45)
        Me.lblVeterinarios.Name = "lblVeterinarios"
        Me.lblVeterinarios.Size = New System.Drawing.Size(215, 44)
        Me.lblVeterinarios.TabIndex = 17
        Me.lblVeterinarios.Text = "Veterinários"
        Me.lblVeterinarios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlowLayoutPanel
        '
        Me.FlowLayoutPanel.Location = New System.Drawing.Point(37, 130)
        Me.FlowLayoutPanel.Name = "FlowLayoutPanel"
        Me.FlowLayoutPanel.Size = New System.Drawing.Size(1359, 554)
        Me.FlowLayoutPanel.TabIndex = 19
        '
        'ucVeterinarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnMain)
        Me.Name = "ucVeterinarios"
        Me.Size = New System.Drawing.Size(1757, 823)
        Me.pnMain.ResumeLayout(False)
        Me.pnMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnMain As Panel
    Friend WithEvents lblVeterinarios As Label
    Friend WithEvents FlowLayoutPanel As FlowLayoutPanel
End Class
