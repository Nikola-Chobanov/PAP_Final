<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_NAV1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UC_NAV1))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.BarNAV = New DevExpress.XtraBars.Bar()
        Me.bbPrimeiro = New DevExpress.XtraBars.BarButtonItem()
        Me.bbAnterior = New DevExpress.XtraBars.BarButtonItem()
        Me.bbSeguinte = New DevExpress.XtraBars.BarButtonItem()
        Me.bbUltimo = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.bbStatus = New DevExpress.XtraBars.BarStaticItem()
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.bbNovo = New DevExpress.XtraBars.BarButtonItem()
        Me.bbModifica = New DevExpress.XtraBars.BarButtonItem()
        Me.bbApaga = New DevExpress.XtraBars.BarButtonItem()
        Me.bbSair = New DevExpress.XtraBars.BarButtonItem()
        Me.bbGrava = New DevExpress.XtraBars.BarButtonItem()
        Me.bbCancela = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.BarNAV, Me.Bar3, Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbPrimeiro, Me.bbAnterior, Me.bbSeguinte, Me.bbUltimo, Me.bbNovo, Me.bbModifica, Me.bbApaga, Me.bbSair, Me.bbGrava, Me.bbCancela, Me.bbStatus, Me.BarStaticItem1})
        Me.BarManager1.MaxItemId = 15
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'BarNAV
        '
        Me.BarNAV.BarName = "Tools"
        Me.BarNAV.DockCol = 0
        Me.BarNAV.DockRow = 0
        Me.BarNAV.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.BarNAV.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbPrimeiro), New DevExpress.XtraBars.LinkPersistInfo(Me.bbAnterior), New DevExpress.XtraBars.LinkPersistInfo(Me.bbSeguinte), New DevExpress.XtraBars.LinkPersistInfo(Me.bbUltimo)})
        Me.BarNAV.Text = "Tools"
        '
        'bbPrimeiro
        '
        Me.bbPrimeiro.Caption = "Primeiro"
        Me.bbPrimeiro.Id = 0
        Me.bbPrimeiro.ImageOptions.Image = CType(resources.GetObject("bbPrimeiro.ImageOptions.Image"), System.Drawing.Image)
        Me.bbPrimeiro.Name = "bbPrimeiro"
        '
        'bbAnterior
        '
        Me.bbAnterior.Caption = "Anterior"
        Me.bbAnterior.Id = 1
        Me.bbAnterior.ImageOptions.Image = CType(resources.GetObject("bbAnterior.ImageOptions.Image"), System.Drawing.Image)
        Me.bbAnterior.Name = "bbAnterior"
        '
        'bbSeguinte
        '
        Me.bbSeguinte.Caption = "Seguinte"
        Me.bbSeguinte.Id = 2
        Me.bbSeguinte.ImageOptions.Image = CType(resources.GetObject("bbSeguinte.ImageOptions.Image"), System.Drawing.Image)
        Me.bbSeguinte.Name = "bbSeguinte"
        '
        'bbUltimo
        '
        Me.bbUltimo.Caption = "Ultimo"
        Me.bbUltimo.Id = 3
        Me.bbUltimo.ImageOptions.Image = CType(resources.GetObject("bbUltimo.ImageOptions.Image"), System.Drawing.Image)
        Me.bbUltimo.Name = "bbUltimo"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbStatus)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'bbStatus
        '
        Me.bbStatus.Caption = "bsStatus"
        Me.bbStatus.Id = 13
        Me.bbStatus.Name = "bbStatus"
        '
        'Bar1
        '
        Me.Bar1.BarName = "Custom 5"
        Me.Bar1.DockCol = 1
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbNovo), New DevExpress.XtraBars.LinkPersistInfo(Me.bbModifica), New DevExpress.XtraBars.LinkPersistInfo(Me.bbApaga), New DevExpress.XtraBars.LinkPersistInfo(Me.bbSair), New DevExpress.XtraBars.LinkPersistInfo(Me.bbGrava), New DevExpress.XtraBars.LinkPersistInfo(Me.bbCancela)})
        Me.Bar1.Offset = 227
        Me.Bar1.Text = "Custom 5"
        '
        'bbNovo
        '
        Me.bbNovo.Caption = "Novo"
        Me.bbNovo.Id = 4
        Me.bbNovo.ImageOptions.Image = CType(resources.GetObject("bbNovo.ImageOptions.Image"), System.Drawing.Image)
        Me.bbNovo.Name = "bbNovo"
        '
        'bbModifica
        '
        Me.bbModifica.Caption = "Modifica"
        Me.bbModifica.Id = 5
        Me.bbModifica.ImageOptions.Image = CType(resources.GetObject("bbModifica.ImageOptions.Image"), System.Drawing.Image)
        Me.bbModifica.Name = "bbModifica"
        '
        'bbApaga
        '
        Me.bbApaga.Caption = "Apaga"
        Me.bbApaga.Id = 8
        Me.bbApaga.ImageOptions.Image = CType(resources.GetObject("bbApaga.ImageOptions.Image"), System.Drawing.Image)
        Me.bbApaga.Name = "bbApaga"
        '
        'bbSair
        '
        Me.bbSair.Caption = "Sair"
        Me.bbSair.Id = 9
        Me.bbSair.ImageOptions.Image = CType(resources.GetObject("bbSair.ImageOptions.Image"), System.Drawing.Image)
        Me.bbSair.Name = "bbSair"
        '
        'bbGrava
        '
        Me.bbGrava.Caption = "Grava"
        Me.bbGrava.Id = 11
        Me.bbGrava.ImageOptions.Image = CType(resources.GetObject("bbGrava.ImageOptions.Image"), System.Drawing.Image)
        Me.bbGrava.Name = "bbGrava"
        '
        'bbCancela
        '
        Me.bbCancela.Caption = "Cancela"
        Me.bbCancela.Id = 12
        Me.bbCancela.ImageOptions.Image = CType(resources.GetObject("bbCancela.ImageOptions.Image"), System.Drawing.Image)
        Me.bbCancela.Name = "bbCancela"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(984, 72)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 589)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(984, 22)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 72)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 517)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(984, 72)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 517)
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Caption = "BarStaticItem1"
        Me.BarStaticItem1.Id = 14
        Me.BarStaticItem1.Name = "BarStaticItem1"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Sair"
        Me.BarButtonItem8.Id = 10
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 72)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(984, 517)
        Me.Panel1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(984, 517)
        Me.Panel2.TabIndex = 0
        '
        'UC_NAV1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "UC_NAV1"
        Me.Size = New System.Drawing.Size(984, 611)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents BarNAV As DevExpress.XtraBars.Bar
    Friend WithEvents bbPrimeiro As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbAnterior As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbSeguinte As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbUltimo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents bbStatus As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents bbNovo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbModifica As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbApaga As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbSair As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbGrava As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbCancela As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
