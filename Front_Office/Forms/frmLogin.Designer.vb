<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")>
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.picEyeLogin = New System.Windows.Forms.PictureBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUtilizador = New System.Windows.Forms.TextBox()
        Me.ulblPassword = New Infragistics.Win.Misc.UltraLabel()
        Me.ulblUtilizador = New Infragistics.Win.Misc.UltraLabel()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnEntrar = New System.Windows.Forms.Button()
        Me.picPassword = New System.Windows.Forms.PictureBox()
        Me.picUtilizador = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEyeLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUtilizador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.Image = Global.G02_Gustavo_02.My.Resources.Resources.Logo
        Me.picLogo.Location = New System.Drawing.Point(56, 22)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(100, 100)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 22
        Me.picLogo.TabStop = False
        '
        'picEyeLogin
        '
        Me.picEyeLogin.Image = Global.G02_Gustavo_02.My.Resources.Resources.OlhoA
        Me.picEyeLogin.Location = New System.Drawing.Point(204, 269)
        Me.picEyeLogin.Name = "picEyeLogin"
        Me.picEyeLogin.Size = New System.Drawing.Size(22, 19)
        Me.picEyeLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEyeLogin.TabIndex = 19
        Me.picEyeLogin.TabStop = False
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txtPassword.Location = New System.Drawing.Point(60, 268)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(171, 20)
        Me.txtPassword.TabIndex = 0
        Me.txtPassword.Tag = "1"
        '
        'txtUtilizador
        '
        Me.txtUtilizador.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtUtilizador.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUtilizador.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txtUtilizador.Location = New System.Drawing.Point(60, 182)
        Me.txtUtilizador.Multiline = True
        Me.txtUtilizador.Name = "txtUtilizador"
        Me.txtUtilizador.Size = New System.Drawing.Size(171, 21)
        Me.txtUtilizador.TabIndex = 3
        Me.txtUtilizador.Tag = "0"
        '
        'ulblPassword
        '
        Me.ulblPassword.Anchor = System.Windows.Forms.AnchorStyles.Left
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(79, Byte), Integer))
        Appearance1.TextHAlignAsString = "Center"
        Appearance1.TextVAlignAsString = "Middle"
        Me.ulblPassword.Appearance = Appearance1
        Me.ulblPassword.Font = New System.Drawing.Font("NewsGoth Cn BT", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ulblPassword.Location = New System.Drawing.Point(51, 228)
        Me.ulblPassword.Name = "ulblPassword"
        Me.ulblPassword.Size = New System.Drawing.Size(114, 34)
        Me.ulblPassword.TabIndex = 16
        Me.ulblPassword.Text = "Password"
        '
        'ulblUtilizador
        '
        Me.ulblUtilizador.Anchor = System.Windows.Forms.AnchorStyles.Left
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(79, Byte), Integer))
        Appearance2.TextHAlignAsString = "Center"
        Appearance2.TextVAlignAsString = "Middle"
        Me.ulblUtilizador.Appearance = Appearance2
        Me.ulblUtilizador.Font = New System.Drawing.Font("NewsGoth Cn BT", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ulblUtilizador.Location = New System.Drawing.Point(51, 142)
        Me.ulblUtilizador.Name = "ulblUtilizador"
        Me.ulblUtilizador.Size = New System.Drawing.Size(114, 34)
        Me.ulblUtilizador.TabIndex = 15
        Me.ulblUtilizador.Text = "Utilizador"
        '
        'btnSair
        '
        Me.btnSair.BackColor = System.Drawing.Color.Transparent
        Me.btnSair.BackgroundImage = Global.G02_Gustavo_02.My.Resources.Resources.SairLogin
        Me.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSair.CausesValidation = False
        Me.btnSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSair.FlatAppearance.BorderSize = 0
        Me.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSair.ForeColor = System.Drawing.Color.Transparent
        Me.btnSair.Location = New System.Drawing.Point(12, 405)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(129, 36)
        Me.btnSair.TabIndex = 2
        Me.btnSair.UseVisualStyleBackColor = False
        '
        'btnEntrar
        '
        Me.btnEntrar.BackColor = System.Drawing.Color.Transparent
        Me.btnEntrar.BackgroundImage = Global.G02_Gustavo_02.My.Resources.Resources.Entrar
        Me.btnEntrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEntrar.CausesValidation = False
        Me.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEntrar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnEntrar.FlatAppearance.BorderSize = 0
        Me.btnEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEntrar.Location = New System.Drawing.Point(81, 324)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(125, 38)
        Me.btnEntrar.TabIndex = 1
        Me.btnEntrar.UseVisualStyleBackColor = False
        '
        'picPassword
        '
        Me.picPassword.BackColor = System.Drawing.Color.Transparent
        Me.picPassword.Image = Global.G02_Gustavo_02.My.Resources.Resources.backLogin
        Me.picPassword.Location = New System.Drawing.Point(56, 263)
        Me.picPassword.Name = "picPassword"
        Me.picPassword.Size = New System.Drawing.Size(181, 31)
        Me.picPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPassword.TabIndex = 20
        Me.picPassword.TabStop = False
        '
        'picUtilizador
        '
        Me.picUtilizador.BackColor = System.Drawing.Color.Transparent
        Me.picUtilizador.Image = Global.G02_Gustavo_02.My.Resources.Resources.backLogin
        Me.picUtilizador.Location = New System.Drawing.Point(56, 177)
        Me.picUtilizador.Name = "picUtilizador"
        Me.picUtilizador.Size = New System.Drawing.Size(181, 31)
        Me.picUtilizador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picUtilizador.TabIndex = 21
        Me.picUtilizador.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.G02_Gustavo_02.My.Resources.Resources.CaoLogin
        Me.PictureBox1.Location = New System.Drawing.Point(369, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(450, 450)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.G02_Gustavo_02.My.Resources.Resources.BackGroundLogin
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(613, 453)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.picEyeLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUtilizador)
        Me.Controls.Add(Me.ulblPassword)
        Me.Controls.Add(Me.ulblUtilizador)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnEntrar)
        Me.Controls.Add(Me.picPassword)
        Me.Controls.Add(Me.picUtilizador)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEyeLogin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUtilizador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picLogo As PictureBox
    Friend WithEvents picEyeLogin As PictureBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUtilizador As TextBox
    Friend WithEvents ulblPassword As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ulblUtilizador As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnSair As Button
    Friend WithEvents btnEntrar As Button
    Friend WithEvents picPassword As PictureBox
    Friend WithEvents picUtilizador As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
