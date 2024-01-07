<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.AccordionControl1 = New DevExpress.XtraBars.Navigation.AccordionControl()
        Me.accGestao = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.accG_Entidades = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.accG_Calendarios = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.accG_Artigos = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.accG_Categorias = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.accG_Animais = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.accG_TiposAnimais = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.accG_Veterinarios = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.accG_Consultas = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.accG_TC = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.accG_Series = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.accG_Doc = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.accG_TD = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.accG_IVA = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.accSair = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement19 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement20 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement21 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.AccordionControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AccordionControl1
        '
        Me.AccordionControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.AccordionControl1.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.accGestao, Me.accSair})
        Me.AccordionControl1.Location = New System.Drawing.Point(0, 0)
        Me.AccordionControl1.Name = "AccordionControl1"
        Me.AccordionControl1.RootDisplayMode = DevExpress.XtraBars.Navigation.AccordionControlRootDisplayMode.Footer
        Me.AccordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden
        Me.AccordionControl1.Size = New System.Drawing.Size(260, 611)
        Me.AccordionControl1.TabIndex = 0
        Me.AccordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu
        '
        'accGestao
        '
        Me.accGestao.Appearance.Default.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.accGestao.Appearance.Default.Options.UseFont = True
        Me.accGestao.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.accG_Entidades, Me.accG_Calendarios, Me.accG_Artigos, Me.accG_Categorias, Me.accG_Animais, Me.accG_TiposAnimais, Me.accG_Veterinarios, Me.accG_Consultas, Me.accG_TC, Me.accG_Series, Me.accG_Doc, Me.accG_TD, Me.accG_IVA})
        Me.accGestao.Expanded = True
        Me.accGestao.ImageOptions.Image = Global.G02_Nikola_04.My.Resources.Resources.Inicio
        Me.accGestao.Name = "accGestao"
        Me.accGestao.Text = "Gestão"
        '
        'accG_Entidades
        '
        Me.accG_Entidades.Appearance.Default.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.accG_Entidades.Appearance.Default.Options.UseFont = True
        Me.accG_Entidades.HeaderTemplate.AddRange(New DevExpress.XtraBars.Navigation.HeaderElementInfo() {New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)})
        Me.accG_Entidades.Height = 60
        Me.accG_Entidades.ImageOptions.Image = Global.G02_Nikola_04.My.Resources.Resources.EntidadesIcon
        Me.accG_Entidades.Name = "accG_Entidades"
        Me.accG_Entidades.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.accG_Entidades.Text = "Entidades"
        '
        'accG_Calendarios
        '
        Me.accG_Calendarios.Appearance.Default.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.accG_Calendarios.Appearance.Default.Options.UseFont = True
        Me.accG_Calendarios.Height = 50
        Me.accG_Calendarios.Name = "accG_Calendarios"
        Me.accG_Calendarios.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.accG_Calendarios.Text = "Calendários"
        Me.accG_Calendarios.Visible = False
        '
        'accG_Artigos
        '
        Me.accG_Artigos.Appearance.Default.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.accG_Artigos.Appearance.Default.Options.UseFont = True
        Me.accG_Artigos.HeaderTemplate.AddRange(New DevExpress.XtraBars.Navigation.HeaderElementInfo() {New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)})
        Me.accG_Artigos.Height = 60
        Me.accG_Artigos.ImageOptions.Image = Global.G02_Nikola_04.My.Resources.Resources.ArtigosIcon
        Me.accG_Artigos.Name = "accG_Artigos"
        Me.accG_Artigos.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.accG_Artigos.Text = "Artigos"
        '
        'accG_Categorias
        '
        Me.accG_Categorias.Appearance.Default.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.accG_Categorias.Appearance.Default.Options.UseFont = True
        Me.accG_Categorias.HeaderTemplate.AddRange(New DevExpress.XtraBars.Navigation.HeaderElementInfo() {New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)})
        Me.accG_Categorias.Height = 60
        Me.accG_Categorias.ImageOptions.Image = Global.G02_Nikola_04.My.Resources.Resources.CategoriasIcon
        Me.accG_Categorias.Name = "accG_Categorias"
        Me.accG_Categorias.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.accG_Categorias.Text = "Categorias"
        '
        'accG_Animais
        '
        Me.accG_Animais.Appearance.Default.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.accG_Animais.Appearance.Default.Options.UseFont = True
        Me.accG_Animais.HeaderTemplate.AddRange(New DevExpress.XtraBars.Navigation.HeaderElementInfo() {New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)})
        Me.accG_Animais.Height = 60
        Me.accG_Animais.ImageOptions.Image = Global.G02_Nikola_04.My.Resources.Resources.AnimaisIcon
        Me.accG_Animais.Name = "accG_Animais"
        Me.accG_Animais.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.accG_Animais.Text = "Animais"
        '
        'accG_TiposAnimais
        '
        Me.accG_TiposAnimais.Appearance.Default.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.accG_TiposAnimais.Appearance.Default.Options.UseFont = True
        Me.accG_TiposAnimais.HeaderTemplate.AddRange(New DevExpress.XtraBars.Navigation.HeaderElementInfo() {New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)})
        Me.accG_TiposAnimais.Height = 60
        Me.accG_TiposAnimais.ImageOptions.Image = Global.G02_Nikola_04.My.Resources.Resources.TiposAnimaisIcon
        Me.accG_TiposAnimais.Name = "accG_TiposAnimais"
        Me.accG_TiposAnimais.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.accG_TiposAnimais.Text = "Tipos de  Animais"
        '
        'accG_Veterinarios
        '
        Me.accG_Veterinarios.Appearance.Default.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.accG_Veterinarios.Appearance.Default.Options.UseFont = True
        Me.accG_Veterinarios.HeaderTemplate.AddRange(New DevExpress.XtraBars.Navigation.HeaderElementInfo() {New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)})
        Me.accG_Veterinarios.Height = 60
        Me.accG_Veterinarios.ImageOptions.Image = Global.G02_Nikola_04.My.Resources.Resources.VeterinariosIcon
        Me.accG_Veterinarios.Name = "accG_Veterinarios"
        Me.accG_Veterinarios.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.accG_Veterinarios.Text = "Veterinários"
        '
        'accG_Consultas
        '
        Me.accG_Consultas.Appearance.Default.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.accG_Consultas.Appearance.Default.Options.UseFont = True
        Me.accG_Consultas.HeaderTemplate.AddRange(New DevExpress.XtraBars.Navigation.HeaderElementInfo() {New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)})
        Me.accG_Consultas.Height = 60
        Me.accG_Consultas.ImageOptions.Image = Global.G02_Nikola_04.My.Resources.Resources.ConsultasIcon
        Me.accG_Consultas.Name = "accG_Consultas"
        Me.accG_Consultas.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.accG_Consultas.Text = "Consultas"
        '
        'accG_TC
        '
        Me.accG_TC.Appearance.Default.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.accG_TC.Appearance.Default.Options.UseFont = True
        Me.accG_TC.HeaderTemplate.AddRange(New DevExpress.XtraBars.Navigation.HeaderElementInfo() {New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)})
        Me.accG_TC.Height = 60
        Me.accG_TC.ImageOptions.Image = Global.G02_Nikola_04.My.Resources.Resources.TiposConsultasIcon
        Me.accG_TC.Name = "accG_TC"
        Me.accG_TC.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.accG_TC.Text = "Tipos de Consulta"
        '
        'accG_Series
        '
        Me.accG_Series.Appearance.Default.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.accG_Series.Appearance.Default.Options.UseFont = True
        Me.accG_Series.HeaderTemplate.AddRange(New DevExpress.XtraBars.Navigation.HeaderElementInfo() {New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)})
        Me.accG_Series.Height = 60
        Me.accG_Series.ImageOptions.Image = Global.G02_Nikola_04.My.Resources.Resources.SeriesIcon
        Me.accG_Series.Name = "accG_Series"
        Me.accG_Series.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.accG_Series.Text = "Series"
        '
        'accG_Doc
        '
        Me.accG_Doc.Appearance.Default.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.accG_Doc.Appearance.Default.Options.UseFont = True
        Me.accG_Doc.HeaderTemplate.AddRange(New DevExpress.XtraBars.Navigation.HeaderElementInfo() {New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)})
        Me.accG_Doc.Height = 60
        Me.accG_Doc.ImageOptions.Image = Global.G02_Nikola_04.My.Resources.Resources.DocumentosIcon
        Me.accG_Doc.Name = "accG_Doc"
        Me.accG_Doc.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.accG_Doc.Text = "Documentos"
        '
        'accG_TD
        '
        Me.accG_TD.Appearance.Default.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.accG_TD.Appearance.Default.Options.UseFont = True
        Me.accG_TD.HeaderTemplate.AddRange(New DevExpress.XtraBars.Navigation.HeaderElementInfo() {New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)})
        Me.accG_TD.Height = 60
        Me.accG_TD.ImageOptions.Image = Global.G02_Nikola_04.My.Resources.Resources.TiposDocumentoIcon
        Me.accG_TD.Name = "accG_TD"
        Me.accG_TD.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.accG_TD.Text = "Tipos de Documento"
        '
        'accG_IVA
        '
        Me.accG_IVA.Appearance.Default.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.accG_IVA.Appearance.Default.Options.UseFont = True
        Me.accG_IVA.HeaderTemplate.AddRange(New DevExpress.XtraBars.Navigation.HeaderElementInfo() {New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)})
        Me.accG_IVA.Height = 60
        Me.accG_IVA.ImageOptions.Image = Global.G02_Nikola_04.My.Resources.Resources.IVAIcon
        Me.accG_IVA.Name = "accG_IVA"
        Me.accG_IVA.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.accG_IVA.Text = "IVA"
        '
        'accSair
        '
        Me.accSair.ImageOptions.Image = Global.G02_Nikola_04.My.Resources.Resources.Sair
        Me.accSair.Name = "accSair"
        '
        'AccordionControlElement19
        '
        Me.AccordionControlElement19.Name = "AccordionControlElement19"
        Me.AccordionControlElement19.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement19.Text = "Element19"
        '
        'AccordionControlElement20
        '
        Me.AccordionControlElement20.Name = "AccordionControlElement20"
        Me.AccordionControlElement20.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement20.Text = "Element20"
        '
        'AccordionControlElement21
        '
        Me.AccordionControlElement21.Name = "AccordionControlElement21"
        Me.AccordionControlElement21.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement21.Text = "Element21"
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(260, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(984, 611)
        Me.Panel1.TabIndex = 1
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1244, 611)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.AccordionControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AccordionControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AccordionControl1 As DevExpress.XtraBars.Navigation.AccordionControl
    Friend WithEvents accGestao As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents accG_Entidades As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents accG_Calendarios As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents accG_Series As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents accG_Doc As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents accG_Animais As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlElement19 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlElement20 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlElement21 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents Panel1 As Panel
    Friend WithEvents accG_TD As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents accG_TC As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents accG_Artigos As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents accG_IVA As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents accG_TiposAnimais As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents accG_Categorias As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents accG_Consultas As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents accG_Veterinarios As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents accSair As DevExpress.XtraBars.Navigation.AccordionControlElement
End Class
