<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.acMenu = New DevExpress.XtraBars.Navigation.AccordionControl()
        Me.accInicio = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.aceDashboard = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.aceConsultas = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.aceFaturacao = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement2 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement1 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.aceVeterinarios = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement4 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.aceProcurar = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.accSair = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement6 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.pnMain = New System.Windows.Forms.Panel()
        CType(Me.acMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'acMenu
        '
        Me.acMenu.Appearance.AccordionControl.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.acMenu.Appearance.AccordionControl.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.acMenu.Appearance.AccordionControl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.acMenu.Appearance.AccordionControl.Options.UseBackColor = True
        Me.acMenu.Appearance.AccordionControl.Options.UseForeColor = True
        Me.acMenu.Appearance.Group.Default.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.acMenu.Appearance.Group.Default.Options.UseBackColor = True
        Me.acMenu.Appearance.Group.Default.Options.UseTextOptions = True
        Me.acMenu.Appearance.Group.Default.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.acMenu.Appearance.Group.Hovered.BackColor = System.Drawing.Color.Transparent
        Me.acMenu.Appearance.Group.Hovered.Options.UseBackColor = True
        Me.acMenu.Appearance.Item.Pressed.BackColor = System.Drawing.Color.Coral
        Me.acMenu.Appearance.Item.Pressed.Options.UseBackColor = True
        Me.acMenu.ContextButtonsOptions.AnimationType = DevExpress.Utils.ContextAnimationType.OpacityAnimation
        Me.acMenu.ContextButtonsOptions.ItemCursor = System.Windows.Forms.Cursors.Hand
        Me.acMenu.ContextButtonsOptions.PanelCursor = System.Windows.Forms.Cursors.Hand
        Me.acMenu.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.acMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.acMenu.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.accInicio, Me.accSair})
        Me.acMenu.Location = New System.Drawing.Point(0, 0)
        Me.acMenu.Name = "acMenu"
        Me.acMenu.OptionsMinimizing.AllowMinimizeMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.acMenu.OptionsMinimizing.MinimizedWidth = 48
        Me.acMenu.OptionsMinimizing.PopupFormAutoHeightMode = DevExpress.XtraBars.Navigation.AccordionPopupFormAutoHeightMode.None
        Me.acMenu.RootDisplayMode = DevExpress.XtraBars.Navigation.AccordionControlRootDisplayMode.Footer
        Me.acMenu.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden
        Me.acMenu.Size = New System.Drawing.Size(250, 985)
        Me.acMenu.TabIndex = 0
        Me.acMenu.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu
        '
        'accInicio
        '
        Me.accInicio.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.aceDashboard, Me.aceConsultas, Me.aceFaturacao, Me.AccordionControlElement2, Me.AccordionControlElement1, Me.aceVeterinarios, Me.AccordionControlElement4, Me.aceProcurar})
        Me.accInicio.Expanded = True
        Me.accInicio.ImageOptions.Image = Global.G02_Gustavo_02.My.Resources.Resources.Inicio
        Me.accInicio.Name = "accInicio"
        Me.accInicio.Text = "Element7"
        '
        'aceDashboard
        '
        Me.aceDashboard.Appearance.Default.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!)
        Me.aceDashboard.Appearance.Default.ForeColor = System.Drawing.Color.White
        Me.aceDashboard.Appearance.Default.Options.UseFont = True
        Me.aceDashboard.Appearance.Default.Options.UseForeColor = True
        Me.aceDashboard.Appearance.Normal.BackColor = System.Drawing.Color.Coral
        Me.aceDashboard.Appearance.Normal.Options.UseBackColor = True
        Me.aceDashboard.HeaderTemplate.AddRange(New DevExpress.XtraBars.Navigation.HeaderElementInfo() {New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)})
        Me.aceDashboard.Height = 75
        Me.aceDashboard.ImageOptions.Image = Global.G02_Gustavo_02.My.Resources.Resources.Dashboard
        Me.aceDashboard.Name = "aceDashboard"
        Me.aceDashboard.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.aceDashboard.Text = "Dashboard"
        '
        'aceConsultas
        '
        Me.aceConsultas.Appearance.Default.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!)
        Me.aceConsultas.Appearance.Default.ForeColor = System.Drawing.Color.White
        Me.aceConsultas.Appearance.Default.Options.UseFont = True
        Me.aceConsultas.Appearance.Default.Options.UseForeColor = True
        Me.aceConsultas.HeaderTemplate.AddRange(New DevExpress.XtraBars.Navigation.HeaderElementInfo() {New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)})
        Me.aceConsultas.Height = 75
        Me.aceConsultas.ImageOptions.Image = Global.G02_Gustavo_02.My.Resources.Resources.Calendario
        Me.aceConsultas.Name = "aceConsultas"
        Me.aceConsultas.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.aceConsultas.Text = "Consultas"
        '
        'aceFaturacao
        '
        Me.aceFaturacao.Appearance.Default.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!)
        Me.aceFaturacao.Appearance.Default.ForeColor = System.Drawing.Color.White
        Me.aceFaturacao.Appearance.Default.Options.UseFont = True
        Me.aceFaturacao.Appearance.Default.Options.UseForeColor = True
        Me.aceFaturacao.HeaderTemplate.AddRange(New DevExpress.XtraBars.Navigation.HeaderElementInfo() {New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)})
        Me.aceFaturacao.Height = 75
        Me.aceFaturacao.ImageOptions.Image = Global.G02_Gustavo_02.My.Resources.Resources.Artigos
        Me.aceFaturacao.Name = "aceFaturacao"
        Me.aceFaturacao.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.aceFaturacao.Text = "Faturação"
        '
        'AccordionControlElement2
        '
        Me.AccordionControlElement2.Appearance.Default.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccordionControlElement2.Appearance.Default.ForeColor = System.Drawing.Color.White
        Me.AccordionControlElement2.Appearance.Default.Options.UseFont = True
        Me.AccordionControlElement2.Appearance.Default.Options.UseForeColor = True
        Me.AccordionControlElement2.HeaderTemplate.AddRange(New DevExpress.XtraBars.Navigation.HeaderElementInfo() {New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)})
        Me.AccordionControlElement2.Height = 90
        Me.AccordionControlElement2.ImageOptions.Image = CType(resources.GetObject("AccordionControlElement2.ImageOptions.Image"), System.Drawing.Image)
        Me.AccordionControlElement2.Name = "AccordionControlElement2"
        Me.AccordionControlElement2.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement2.Text = "Adicionar Consulta"
        Me.AccordionControlElement2.Visible = False
        '
        'AccordionControlElement1
        '
        Me.AccordionControlElement1.Appearance.Default.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!)
        Me.AccordionControlElement1.Appearance.Default.ForeColor = System.Drawing.Color.White
        Me.AccordionControlElement1.Appearance.Default.Options.UseFont = True
        Me.AccordionControlElement1.Appearance.Default.Options.UseForeColor = True
        Me.AccordionControlElement1.HeaderTemplate.AddRange(New DevExpress.XtraBars.Navigation.HeaderElementInfo() {New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)})
        Me.AccordionControlElement1.Height = 90
        Me.AccordionControlElement1.ImageOptions.Image = CType(resources.GetObject("AccordionControlElement1.ImageOptions.Image"), System.Drawing.Image)
        Me.AccordionControlElement1.Name = "AccordionControlElement1"
        Me.AccordionControlElement1.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement1.Text = "Alterar Consulta"
        Me.AccordionControlElement1.Visible = False
        '
        'aceVeterinarios
        '
        Me.aceVeterinarios.Appearance.Default.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!)
        Me.aceVeterinarios.Appearance.Default.ForeColor = System.Drawing.Color.White
        Me.aceVeterinarios.Appearance.Default.Options.UseFont = True
        Me.aceVeterinarios.Appearance.Default.Options.UseForeColor = True
        Me.aceVeterinarios.HeaderTemplate.AddRange(New DevExpress.XtraBars.Navigation.HeaderElementInfo() {New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)})
        Me.aceVeterinarios.Height = 75
        Me.aceVeterinarios.ImageOptions.Image = Global.G02_Gustavo_02.My.Resources.Resources.VeterinariosIcon
        Me.aceVeterinarios.Name = "aceVeterinarios"
        Me.aceVeterinarios.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.aceVeterinarios.Text = "Veterinários"
        '
        'AccordionControlElement4
        '
        Me.AccordionControlElement4.Appearance.Default.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccordionControlElement4.Appearance.Default.ForeColor = System.Drawing.Color.White
        Me.AccordionControlElement4.Appearance.Default.Options.UseFont = True
        Me.AccordionControlElement4.Appearance.Default.Options.UseForeColor = True
        Me.AccordionControlElement4.HeaderTemplate.AddRange(New DevExpress.XtraBars.Navigation.HeaderElementInfo() {New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)})
        Me.AccordionControlElement4.Height = 90
        Me.AccordionControlElement4.ImageOptions.Image = CType(resources.GetObject("AccordionControlElement4.ImageOptions.Image"), System.Drawing.Image)
        Me.AccordionControlElement4.Name = "AccordionControlElement4"
        Me.AccordionControlElement4.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement4.Text = "Bloquear Consulta"
        Me.AccordionControlElement4.Visible = False
        '
        'aceProcurar
        '
        Me.aceProcurar.Appearance.Default.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.aceProcurar.Appearance.Default.ForeColor = System.Drawing.Color.White
        Me.aceProcurar.Appearance.Default.Options.UseFont = True
        Me.aceProcurar.Appearance.Default.Options.UseForeColor = True
        Me.aceProcurar.HeaderTemplate.AddRange(New DevExpress.XtraBars.Navigation.HeaderElementInfo() {New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)})
        Me.aceProcurar.Height = 75
        Me.aceProcurar.ImageOptions.Image = Global.G02_Gustavo_02.My.Resources.Resources.IconProcurar
        Me.aceProcurar.Name = "aceProcurar"
        Me.aceProcurar.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.aceProcurar.Text = "Procurar Consultas"
        Me.aceProcurar.Visible = False
        '
        'accSair
        '
        Me.accSair.Expanded = True
        Me.accSair.ImageOptions.Image = Global.G02_Gustavo_02.My.Resources.Resources.Sair
        Me.accSair.Name = "accSair"
        Me.accSair.Text = "Element8"
        '
        'AccordionControlElement6
        '
        Me.AccordionControlElement6.Height = 800
        Me.AccordionControlElement6.ImageOptions.Image = CType(resources.GetObject("AccordionControlElement6.ImageOptions.Image"), System.Drawing.Image)
        Me.AccordionControlElement6.Name = "AccordionControlElement6"
        Me.AccordionControlElement6.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        '
        'pnMain
        '
        Me.pnMain.BackColor = System.Drawing.Color.Transparent
        Me.pnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnMain.Location = New System.Drawing.Point(250, 0)
        Me.pnMain.Name = "pnMain"
        Me.pnMain.Size = New System.Drawing.Size(1174, 985)
        Me.pnMain.TabIndex = 1
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1424, 985)
        Me.Controls.Add(Me.pnMain)
        Me.Controls.Add(Me.acMenu)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "Clive's"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.acMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents acMenu As DevExpress.XtraBars.Navigation.AccordionControl
    Friend WithEvents AccordionControlElement2 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlElement1 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents aceVeterinarios As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlElement4 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents aceProcurar As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlElement6 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents accInicio As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents accSair As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents aceConsultas As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents aceFaturacao As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents pnMain As Panel
    Friend WithEvents aceDashboard As DevExpress.XtraBars.Navigation.AccordionControlElement
End Class
