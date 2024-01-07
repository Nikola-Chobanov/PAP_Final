<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class test
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
        Me.UC_NAV1 = New G02_Nikola_04.UC_NAV()
        Me.SuspendLayout()
        '
        'UC_NAV1
        '
        Me.UC_NAV1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UC_NAV1.Location = New System.Drawing.Point(0, 0)
        Me.UC_NAV1.mFRM = Nothing
        Me.UC_NAV1.Name = "UC_NAV1"
        Me.UC_NAV1.Size = New System.Drawing.Size(1134, 586)
        Me.UC_NAV1.TabIndex = 0
        '
        'test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.UC_NAV1)
        Me.Name = "test"
        Me.Size = New System.Drawing.Size(1134, 586)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UC_NAV1 As UC_NAV
End Class
