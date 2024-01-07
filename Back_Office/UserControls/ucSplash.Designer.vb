<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucSplash
    Inherits DevExpress.XtraSplashScreen.SplashScreen

    'Form overrides dispose to clean up the component list.
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
        Me.labelStatus = New DevExpress.XtraEditors.LabelControl()
        Me.labelCopyright = New DevExpress.XtraEditors.LabelControl()
        Me.peImage = New DevExpress.XtraEditors.PictureEdit()
        Me.progressBarControl = New DevExpress.XtraEditors.MarqueeProgressBarControl()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.peImage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.progressBarControl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelStatus
        '
        Me.labelStatus.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.labelStatus.Appearance.Options.UseFont = True
        Me.labelStatus.Location = New System.Drawing.Point(4, 286)
        Me.labelStatus.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
        Me.labelStatus.Name = "labelStatus"
        Me.labelStatus.Size = New System.Drawing.Size(59, 16)
        Me.labelStatus.TabIndex = 12
        Me.labelStatus.Text = "A entrar..."
        '
        'labelCopyright
        '
        Me.labelCopyright.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.labelCopyright.Appearance.Options.UseFont = True
        Me.labelCopyright.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.labelCopyright.Location = New System.Drawing.Point(325, 286)
        Me.labelCopyright.Name = "labelCopyright"
        Me.labelCopyright.Size = New System.Drawing.Size(54, 16)
        Me.labelCopyright.TabIndex = 11
        Me.labelCopyright.Text = "Copyright"
        '
        'peImage
        '
        Me.peImage.Cursor = System.Windows.Forms.Cursors.Default
        Me.peImage.EditValue = Global.G02_Nikola_04.My.Resources.Resources.Logo
        Me.peImage.Location = New System.Drawing.Point(171, 43)
        Me.peImage.Name = "peImage"
        Me.peImage.Properties.AllowFocused = False
        Me.peImage.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.peImage.Properties.Appearance.Options.UseBackColor = True
        Me.peImage.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.peImage.Properties.ShowMenu = False
        Me.peImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.peImage.Properties.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None
        Me.peImage.Size = New System.Drawing.Size(110, 110)
        Me.peImage.TabIndex = 14
        '
        'progressBarControl
        '
        Me.progressBarControl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.progressBarControl.EditValue = 0
        Me.progressBarControl.Location = New System.Drawing.Point(1, 305)
        Me.progressBarControl.Name = "progressBarControl"
        Me.progressBarControl.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.progressBarControl.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.progressBarControl.Size = New System.Drawing.Size(446, 12)
        Me.progressBarControl.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(193, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 14)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Versão 0.1"
        '
        'ucSplash11
        '
        Me.AllowControlsInImageMode = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 318)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.peImage)
        Me.Controls.Add(Me.labelStatus)
        Me.Controls.Add(Me.labelCopyright)
        Me.Controls.Add(Me.progressBarControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "ucSplash11"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.ShowMode = DevExpress.XtraSplashScreen.ShowMode.Image
        Me.SplashImageOptions.Image = Global.G02_Nikola_04.My.Resources.Resources.ucSplashBack
        Me.Text = "Clive's"
        CType(Me.peImage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.progressBarControl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents peImage As DevExpress.XtraEditors.PictureEdit
    Private WithEvents labelStatus As DevExpress.XtraEditors.LabelControl
    Private WithEvents labelCopyright As DevExpress.XtraEditors.LabelControl
    Private WithEvents progressBarControl As DevExpress.XtraEditors.MarqueeProgressBarControl
    Friend WithEvents Label1 As Label
End Class
