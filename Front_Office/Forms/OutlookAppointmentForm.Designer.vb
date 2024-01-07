Imports DevExpress.XtraScheduler.UI
Partial Class OutlookAppointmentForm

#Region "Designer generated code"
    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OutlookAppointmentForm))
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("ClsEntidades", -1)
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Entidade")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Entidade")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nome")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Pais")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Num_Telefone")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Num_Telemovel")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Email")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NIF")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Utilizador")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Data_Registo")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Password")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fotografia")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Contador_Enderecos")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Ativo")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Lista_Enderecos")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Lista_Enderecos", 0)
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Entidade")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Endereco")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descritivo")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Endereco")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Postal")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Localidade")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Data_Registo")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Ativo")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("ClsSalas", -1)
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Sala")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Sala")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Ativo")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("ClsTipos_Consulta", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Tipo_Consulta")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Designacao")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Preco_Unitario")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Ativo")
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("ClsAnimais", -1)
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Animal")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nome_Animal")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Entidade")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Tipo_Animal")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo_Animal")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Imagem_Animal")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Ativo")
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.backstageViewControl1 = New DevExpress.XtraBars.Ribbon.BackstageViewControl()
        Me.bvPrint = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
        Me.appointmentBackstageControl = New DevExpress.XtraScheduler.Design.AppointmentBackstageControl()
        Me.btnSaveAndClose = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.barLabel = New DevExpress.XtraBars.BarEditItem()
        Me.riAppointmentLabel = New DevExpress.XtraScheduler.UI.RepositoryItemAppointmentLabel()
        Me.barStatus = New DevExpress.XtraBars.BarEditItem()
        Me.riAppointmentStatus = New DevExpress.XtraScheduler.UI.RepositoryItemAppointmentStatus()
        Me.barReminder = New DevExpress.XtraBars.BarEditItem()
        Me.riDuration = New DevExpress.XtraScheduler.UI.RepositoryItemDuration()
        Me.btnRecurrence = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnNext = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrevious = New DevExpress.XtraBars.BarButtonItem()
        Me.btnTimeZones = New DevExpress.XtraBars.BarButtonItem()
        Me.rpAppointment = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpgActions = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgOptions = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.riAppointmentResource = New DevExpress.XtraScheduler.UI.RepositoryItemAppointmentResource()
        Me.lblStartTime = New DevExpress.XtraEditors.LabelControl()
        Me.edtStartDate = New DevExpress.XtraEditors.DateEdit()
        Me.tbLocation = New DevExpress.XtraEditors.TextEdit()
        Me.edtStartTime = New DevExpress.XtraEditors.TimeEdit()
        Me.lblEndTime = New DevExpress.XtraEditors.LabelControl()
        Me.edtEndDate = New DevExpress.XtraEditors.DateEdit()
        Me.edtEndTime = New DevExpress.XtraEditors.TimeEdit()
        Me.lblLocation = New DevExpress.XtraEditors.LabelControl()
        Me.panel1 = New DevExpress.XtraEditors.PanelControl()
        Me.edtTimeZone = New DevExpress.XtraScheduler.UI.TimeZoneEdit()
        Me.lblResource = New DevExpress.XtraEditors.LabelControl()
        Me.edtResource = New DevExpress.XtraScheduler.UI.AppointmentResourceEdit()
        Me.edtResources = New DevExpress.XtraScheduler.UI.AppointmentResourcesEdit()
        Me.chkAllDay = New DevExpress.XtraEditors.CheckEdit()
        Me.tbSubject = New DevExpress.XtraEditors.TextEdit()
        Me.progressPanel = New System.Windows.Forms.Panel()
        Me.tbProgress = New DevExpress.XtraEditors.TrackBarControl()
        Me.lblPercentCompleteValue = New DevExpress.XtraEditors.LabelControl()
        Me.lblPercentComplete = New DevExpress.XtraEditors.LabelControl()
        Me.lblSubject = New DevExpress.XtraEditors.LabelControl()
        Me.panelMain = New System.Windows.Forms.Panel()
        Me.tbDescription = New DevExpress.XtraEditors.MemoEdit()
        Me.panelDescription = New System.Windows.Forms.Panel()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.cmdFatura = New System.Windows.Forms.Button()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.ucMedicos = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.ucSalas = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.ucTipos_Consulta = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.ucAnimais = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.panel3 = New System.Windows.Forms.Panel()
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.backstageViewControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.backstageViewControl1.SuspendLayout()
        Me.bvPrint.SuspendLayout()
        CType(Me.riAppointmentLabel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riAppointmentStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riDuration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riAppointmentResource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtStartDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtStartDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbLocation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtStartTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtEndDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtEndDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtEndTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        CType(Me.edtTimeZone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtResource.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtResources.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtResources.ResourcesCheckedListBoxControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAllDay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbSubject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.progressPanel.SuspendLayout()
        CType(Me.tbProgress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbProgress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel2.SuspendLayout()
        CType(Me.ucMedicos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucSalas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucTipos_Consulta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucAnimais, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ribbonControl1
        '
        Me.ribbonControl1.ApplicationButtonDropDownControl = Me.backstageViewControl1
        Me.ribbonControl1.AutoSizeItems = True
        Me.ribbonControl1.ExpandCollapseItem.Id = 0
        Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.ribbonControl1.SearchEditItem, Me.btnSaveAndClose, Me.btnDelete, Me.barLabel, Me.barStatus, Me.barReminder, Me.btnRecurrence, Me.btnSave, Me.btnNext, Me.btnPrevious, Me.btnTimeZones})
        resources.ApplyResources(Me.ribbonControl1, "ribbonControl1")
        Me.ribbonControl1.MaxItemId = 17
        Me.ribbonControl1.Name = "ribbonControl1"
        Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.rpAppointment})
        Me.ribbonControl1.QuickToolbarItemLinks.Add(Me.btnSave)
        Me.ribbonControl1.QuickToolbarItemLinks.Add(Me.btnPrevious)
        Me.ribbonControl1.QuickToolbarItemLinks.Add(Me.btnNext)
        Me.ribbonControl1.QuickToolbarItemLinks.Add(Me.btnDelete)
        Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.riAppointmentLabel, Me.riAppointmentResource, Me.riAppointmentStatus, Me.riDuration})
        Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
        '
        'backstageViewControl1
        '
        resources.ApplyResources(Me.backstageViewControl1, "backstageViewControl1")
        Me.backstageViewControl1.Controls.Add(Me.bvPrint)
        Me.backstageViewControl1.Name = "backstageViewControl1"
        Me.backstageViewControl1.Office2013StyleOptions.HeaderBackColor = System.Drawing.SystemColors.Control
        Me.backstageViewControl1.OwnerControl = Me.ribbonControl1
        Me.backstageViewControl1.Style = DevExpress.XtraBars.Ribbon.BackstageViewStyle.Office2013
        Me.backstageViewControl1.VisibleInDesignTime = True
        '
        'bvPrint
        '
        resources.ApplyResources(Me.bvPrint, "bvPrint")
        Me.bvPrint.Controls.Add(Me.appointmentBackstageControl)
        Me.bvPrint.Name = "bvPrint"
        '
        'appointmentBackstageControl
        '
        resources.ApplyResources(Me.appointmentBackstageControl, "appointmentBackstageControl")
        Me.appointmentBackstageControl.Name = "appointmentBackstageControl"
        '
        'btnSaveAndClose
        '
        resources.ApplyResources(Me.btnSaveAndClose, "btnSaveAndClose")
        Me.btnSaveAndClose.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.btnSaveAndClose.Id = 3
        Me.btnSaveAndClose.ImageOptions.Image = CType(resources.GetObject("btnSaveAndClose.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSaveAndClose.ImageOptions.LargeImage = CType(resources.GetObject("btnSaveAndClose.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnSaveAndClose.ImageOptions.SvgImage = CType(resources.GetObject("btnSaveAndClose.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnSaveAndClose.Name = "btnSaveAndClose"
        '
        'btnDelete
        '
        resources.ApplyResources(Me.btnDelete, "btnDelete")
        Me.btnDelete.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.btnDelete.Id = 4
        Me.btnDelete.ImageOptions.Image = CType(resources.GetObject("btnDelete.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDelete.ImageOptions.LargeImage = CType(resources.GetObject("btnDelete.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnDelete.ImageOptions.SvgImage = CType(resources.GetObject("btnDelete.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnDelete.Name = "btnDelete"
        '
        'barLabel
        '
        resources.ApplyResources(Me.barLabel, "barLabel")
        Me.barLabel.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.barLabel.Edit = Me.riAppointmentLabel
        Me.barLabel.Id = 8
        Me.barLabel.Name = "barLabel"
        '
        'riAppointmentLabel
        '
        resources.ApplyResources(Me.riAppointmentLabel, "riAppointmentLabel")
        Me.riAppointmentLabel.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("riAppointmentLabel.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.riAppointmentLabel.DropDownRows = 10
        Me.riAppointmentLabel.Name = "riAppointmentLabel"
        '
        'barStatus
        '
        resources.ApplyResources(Me.barStatus, "barStatus")
        Me.barStatus.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.barStatus.Edit = Me.riAppointmentStatus
        Me.barStatus.Id = 11
        Me.barStatus.Name = "barStatus"
        '
        'riAppointmentStatus
        '
        resources.ApplyResources(Me.riAppointmentStatus, "riAppointmentStatus")
        Me.riAppointmentStatus.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("riAppointmentStatus.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.riAppointmentStatus.Name = "riAppointmentStatus"
        '
        'barReminder
        '
        resources.ApplyResources(Me.barReminder, "barReminder")
        Me.barReminder.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.barReminder.Edit = Me.riDuration
        Me.barReminder.Id = 12
        Me.barReminder.Name = "barReminder"
        Me.barReminder.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'riDuration
        '
        resources.ApplyResources(Me.riDuration, "riDuration")
        Me.riDuration.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("riDuration.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.riDuration.DisabledStateText = Nothing
        Me.riDuration.Name = "riDuration"
        Me.riDuration.ShowEmptyItem = True
        '
        'btnRecurrence
        '
        Me.btnRecurrence.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        resources.ApplyResources(Me.btnRecurrence, "btnRecurrence")
        Me.btnRecurrence.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.btnRecurrence.Enabled = False
        Me.btnRecurrence.Id = 17
        Me.btnRecurrence.ImageOptions.Image = CType(resources.GetObject("btnRecurrence.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRecurrence.ImageOptions.LargeImage = CType(resources.GetObject("btnRecurrence.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnRecurrence.ImageOptions.SvgImage = CType(resources.GetObject("btnRecurrence.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnRecurrence.Name = "btnRecurrence"
        Me.btnRecurrence.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.btnRecurrence.VisibleInSearchMenu = False
        '
        'btnSave
        '
        resources.ApplyResources(Me.btnSave, "btnSave")
        Me.btnSave.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.btnSave.Id = 1
        Me.btnSave.ImageOptions.Image = CType(resources.GetObject("btnSave.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSave.ImageOptions.SvgImage = CType(resources.GetObject("btnSave.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnSave.Name = "btnSave"
        '
        'btnNext
        '
        resources.ApplyResources(Me.btnNext, "btnNext")
        Me.btnNext.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.btnNext.Id = 3
        Me.btnNext.ImageOptions.Image = CType(resources.GetObject("btnNext.ImageOptions.Image"), System.Drawing.Image)
        Me.btnNext.ImageOptions.LargeImage = CType(resources.GetObject("btnNext.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnNext.ImageOptions.SvgImage = CType(resources.GetObject("btnNext.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnNext.Name = "btnNext"
        '
        'btnPrevious
        '
        resources.ApplyResources(Me.btnPrevious, "btnPrevious")
        Me.btnPrevious.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.btnPrevious.Id = 4
        Me.btnPrevious.ImageOptions.Image = CType(resources.GetObject("btnPrevious.ImageOptions.Image"), System.Drawing.Image)
        Me.btnPrevious.ImageOptions.LargeImage = CType(resources.GetObject("btnPrevious.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnPrevious.ImageOptions.SvgImage = CType(resources.GetObject("btnPrevious.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnPrevious.Name = "btnPrevious"
        '
        'btnTimeZones
        '
        Me.btnTimeZones.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        resources.ApplyResources(Me.btnTimeZones, "btnTimeZones")
        Me.btnTimeZones.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.btnTimeZones.Enabled = False
        Me.btnTimeZones.Id = 1
        Me.btnTimeZones.ImageOptions.Image = CType(resources.GetObject("btnTimeZones.ImageOptions.Image"), System.Drawing.Image)
        Me.btnTimeZones.ImageOptions.LargeImage = CType(resources.GetObject("btnTimeZones.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnTimeZones.ImageOptions.SvgImage = CType(resources.GetObject("btnTimeZones.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnTimeZones.Name = "btnTimeZones"
        Me.btnTimeZones.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'rpAppointment
        '
        Me.rpAppointment.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgActions, Me.rpgOptions})
        Me.rpAppointment.Name = "rpAppointment"
        resources.ApplyResources(Me.rpAppointment, "rpAppointment")
        '
        'rpgActions
        '
        Me.rpgActions.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.rpgActions.ItemLinks.Add(Me.btnSaveAndClose)
        Me.rpgActions.ItemLinks.Add(Me.btnDelete)
        Me.rpgActions.Name = "rpgActions"
        resources.ApplyResources(Me.rpgActions, "rpgActions")
        '
        'rpgOptions
        '
        Me.rpgOptions.AllowTextClipping = False
        Me.rpgOptions.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.rpgOptions.ItemLinks.Add(Me.barLabel)
        Me.rpgOptions.ItemLinks.Add(Me.barStatus)
        Me.rpgOptions.ItemLinks.Add(Me.barReminder)
        Me.rpgOptions.ItemLinks.Add(Me.btnRecurrence, "C")
        Me.rpgOptions.ItemLinks.Add(Me.btnTimeZones)
        Me.rpgOptions.Name = "rpgOptions"
        resources.ApplyResources(Me.rpgOptions, "rpgOptions")
        '
        'riAppointmentResource
        '
        resources.ApplyResources(Me.riAppointmentResource, "riAppointmentResource")
        Me.riAppointmentResource.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("riAppointmentResource.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.riAppointmentResource.Name = "riAppointmentResource"
        '
        'lblStartTime
        '
        resources.ApplyResources(Me.lblStartTime, "lblStartTime")
        Me.lblStartTime.Name = "lblStartTime"
        '
        'edtStartDate
        '
        resources.ApplyResources(Me.edtStartDate, "edtStartDate")
        Me.edtStartDate.Name = "edtStartDate"
        Me.edtStartDate.Properties.AccessibleName = resources.GetString("edtStartDate.Properties.AccessibleName")
        Me.edtStartDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("edtStartDate.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.edtStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.edtStartDate.Properties.MaxValue = New Date(4000, 1, 1, 0, 0, 0, 0)
        '
        'tbLocation
        '
        resources.ApplyResources(Me.tbLocation, "tbLocation")
        Me.tbLocation.Name = "tbLocation"
        Me.tbLocation.Properties.AccessibleName = resources.GetString("tbLocation.Properties.AccessibleName")
        '
        'edtStartTime
        '
        resources.ApplyResources(Me.edtStartTime, "edtStartTime")
        Me.edtStartTime.Name = "edtStartTime"
        Me.edtStartTime.Properties.AccessibleName = resources.GetString("edtStartTime.Properties.AccessibleName")
        Me.edtStartTime.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.edtStartTime.Properties.MaskSettings.Set("mask", "t")
        '
        'lblEndTime
        '
        resources.ApplyResources(Me.lblEndTime, "lblEndTime")
        Me.lblEndTime.Name = "lblEndTime"
        '
        'edtEndDate
        '
        resources.ApplyResources(Me.edtEndDate, "edtEndDate")
        Me.edtEndDate.Name = "edtEndDate"
        Me.edtEndDate.Properties.AccessibleName = resources.GetString("edtEndDate.Properties.AccessibleName")
        Me.edtEndDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("edtEndDate.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.edtEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.edtEndDate.Properties.MaxValue = New Date(4000, 1, 1, 0, 0, 0, 0)
        '
        'edtEndTime
        '
        resources.ApplyResources(Me.edtEndTime, "edtEndTime")
        Me.edtEndTime.Name = "edtEndTime"
        Me.edtEndTime.Properties.AccessibleName = resources.GetString("edtEndTime.Properties.AccessibleName")
        Me.edtEndTime.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.edtEndTime.Properties.MaskSettings.Set("mask", "t")
        '
        'lblLocation
        '
        resources.ApplyResources(Me.lblLocation, "lblLocation")
        Me.lblLocation.Name = "lblLocation"
        '
        'panel1
        '
        Me.panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.panel1.Controls.Add(Me.edtTimeZone)
        Me.panel1.Controls.Add(Me.lblResource)
        Me.panel1.Controls.Add(Me.edtResource)
        Me.panel1.Controls.Add(Me.edtResources)
        Me.panel1.Controls.Add(Me.chkAllDay)
        resources.ApplyResources(Me.panel1, "panel1")
        Me.panel1.Name = "panel1"
        '
        'edtTimeZone
        '
        resources.ApplyResources(Me.edtTimeZone, "edtTimeZone")
        Me.edtTimeZone.MenuManager = Me.ribbonControl1
        Me.edtTimeZone.Name = "edtTimeZone"
        Me.edtTimeZone.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("edtTimeZone.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        '
        'lblResource
        '
        resources.ApplyResources(Me.lblResource, "lblResource")
        Me.lblResource.Name = "lblResource"
        '
        'edtResource
        '
        resources.ApplyResources(Me.edtResource, "edtResource")
        Me.edtResource.Name = "edtResource"
        Me.edtResource.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox
        Me.edtResource.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("edtResource.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        '
        'edtResources
        '
        resources.ApplyResources(Me.edtResources, "edtResources")
        Me.edtResources.Name = "edtResources"
        Me.edtResources.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("edtResources.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        '
        '
        '
        Me.edtResources.ResourcesCheckedListBoxControl.Location = CType(resources.GetObject("edtResources.ResourcesCheckedListBoxControl.Location"), System.Drawing.Point)
        Me.edtResources.ResourcesCheckedListBoxControl.Name = ""
        Me.edtResources.ResourcesCheckedListBoxControl.TabIndex = CType(resources.GetObject("edtResources.ResourcesCheckedListBoxControl.TabIndex"), Integer)
        '
        'chkAllDay
        '
        resources.ApplyResources(Me.chkAllDay, "chkAllDay")
        Me.chkAllDay.Name = "chkAllDay"
        Me.chkAllDay.Properties.AccessibleName = resources.GetString("chkAllDay.Properties.AccessibleName")
        Me.chkAllDay.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton
        Me.chkAllDay.Properties.AutoWidth = True
        Me.chkAllDay.Properties.Caption = resources.GetString("chkAllDay.Properties.Caption")
        '
        'tbSubject
        '
        resources.ApplyResources(Me.tbSubject, "tbSubject")
        Me.tbSubject.Name = "tbSubject"
        Me.tbSubject.Properties.AccessibleName = resources.GetString("tbSubject.Properties.AccessibleName")
        '
        'progressPanel
        '
        Me.progressPanel.Controls.Add(Me.tbProgress)
        Me.progressPanel.Controls.Add(Me.lblPercentCompleteValue)
        Me.progressPanel.Controls.Add(Me.lblPercentComplete)
        resources.ApplyResources(Me.progressPanel, "progressPanel")
        Me.progressPanel.Name = "progressPanel"
        Me.progressPanel.TabStop = True
        '
        'tbProgress
        '
        resources.ApplyResources(Me.tbProgress, "tbProgress")
        Me.tbProgress.Name = "tbProgress"
        Me.tbProgress.Properties.AutoSize = False
        Me.tbProgress.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.tbProgress.Properties.Maximum = 100
        Me.tbProgress.Properties.ShowValueToolTip = True
        Me.tbProgress.Properties.TickFrequency = 10
        '
        'lblPercentCompleteValue
        '
        resources.ApplyResources(Me.lblPercentCompleteValue, "lblPercentCompleteValue")
        Me.lblPercentCompleteValue.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblPercentCompleteValue.Appearance.Options.UseBackColor = True
        Me.lblPercentCompleteValue.Name = "lblPercentCompleteValue"
        '
        'lblPercentComplete
        '
        resources.ApplyResources(Me.lblPercentComplete, "lblPercentComplete")
        Me.lblPercentComplete.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblPercentComplete.Appearance.Options.UseBackColor = True
        Me.lblPercentComplete.Name = "lblPercentComplete"
        '
        'lblSubject
        '
        resources.ApplyResources(Me.lblSubject, "lblSubject")
        Me.lblSubject.Name = "lblSubject"
        '
        'panelMain
        '
        resources.ApplyResources(Me.panelMain, "panelMain")
        Me.panelMain.Name = "panelMain"
        '
        'tbDescription
        '
        resources.ApplyResources(Me.tbDescription, "tbDescription")
        Me.tbDescription.Name = "tbDescription"
        Me.tbDescription.Properties.AccessibleName = resources.GetString("tbDescription.Properties.AccessibleName")
        Me.tbDescription.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Client
        '
        'panelDescription
        '
        resources.ApplyResources(Me.panelDescription, "panelDescription")
        Me.panelDescription.Name = "panelDescription"
        '
        'panel2
        '
        Me.panel2.Controls.Add(Me.cmdFatura)
        Me.panel2.Controls.Add(Me.LabelControl5)
        Me.panel2.Controls.Add(Me.ucMedicos)
        Me.panel2.Controls.Add(Me.LabelControl1)
        Me.panel2.Controls.Add(Me.LabelControl4)
        Me.panel2.Controls.Add(Me.LabelControl3)
        Me.panel2.Controls.Add(Me.tbDescription)
        Me.panel2.Controls.Add(Me.LabelControl2)
        Me.panel2.Controls.Add(Me.ucSalas)
        Me.panel2.Controls.Add(Me.ucTipos_Consulta)
        Me.panel2.Controls.Add(Me.ucAnimais)
        Me.panel2.Controls.Add(Me.lblSubject)
        Me.panel2.Controls.Add(Me.panel1)
        Me.panel2.Controls.Add(Me.tbSubject)
        Me.panel2.Controls.Add(Me.edtEndTime)
        Me.panel2.Controls.Add(Me.lblLocation)
        Me.panel2.Controls.Add(Me.edtEndDate)
        Me.panel2.Controls.Add(Me.tbLocation)
        Me.panel2.Controls.Add(Me.lblEndTime)
        Me.panel2.Controls.Add(Me.lblStartTime)
        Me.panel2.Controls.Add(Me.edtStartTime)
        Me.panel2.Controls.Add(Me.edtStartDate)
        resources.ApplyResources(Me.panel2, "panel2")
        Me.panel2.Name = "panel2"
        '
        'cmdFatura
        '
        resources.ApplyResources(Me.cmdFatura, "cmdFatura")
        Me.cmdFatura.Name = "cmdFatura"
        Me.cmdFatura.UseVisualStyleBackColor = True
        '
        'LabelControl5
        '
        resources.ApplyResources(Me.LabelControl5, "LabelControl5")
        Me.LabelControl5.Appearance.BackColor = System.Drawing.Color.Coral
        Me.LabelControl5.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelControl5.Appearance.Font = CType(resources.GetObject("LabelControl5.Appearance.Font"), System.Drawing.Font)
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl5.Appearance.Options.UseBackColor = True
        Me.LabelControl5.Appearance.Options.UseBorderColor = True
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Appearance.Options.UseForeColor = True
        Me.LabelControl5.Appearance.Options.UseTextOptions = True
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl5.Name = "LabelControl5"
        '
        'ucMedicos
        '
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ucMedicos.DisplayLayout.Appearance = Appearance1
        UltraGridColumn18.Header.VisiblePosition = 0
        UltraGridColumn18.Hidden = True
        UltraGridColumn19.Header.VisiblePosition = 1
        UltraGridColumn19.Hidden = True
        UltraGridColumn20.Header.VisiblePosition = 2
        UltraGridColumn20.Width = 206
        UltraGridColumn21.Header.VisiblePosition = 4
        UltraGridColumn21.Hidden = True
        UltraGridColumn22.Header.VisiblePosition = 5
        UltraGridColumn22.Hidden = True
        UltraGridColumn23.Header.VisiblePosition = 6
        UltraGridColumn23.Hidden = True
        UltraGridColumn24.Header.VisiblePosition = 7
        UltraGridColumn24.Hidden = True
        UltraGridColumn25.Header.VisiblePosition = 8
        UltraGridColumn25.Hidden = True
        UltraGridColumn26.Header.VisiblePosition = 9
        UltraGridColumn26.Hidden = True
        UltraGridColumn27.Header.VisiblePosition = 10
        UltraGridColumn27.Hidden = True
        UltraGridColumn28.Header.VisiblePosition = 11
        UltraGridColumn28.Hidden = True
        UltraGridColumn29.Header.VisiblePosition = 12
        UltraGridColumn29.Hidden = True
        UltraGridColumn30.Header.VisiblePosition = 13
        UltraGridColumn30.Hidden = True
        UltraGridColumn14.Header.VisiblePosition = 3
        UltraGridColumn14.Hidden = True
        UltraGridColumn31.Header.VisiblePosition = 14
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn14, UltraGridColumn31})
        UltraGridColumn32.Header.VisiblePosition = 0
        UltraGridColumn33.Header.VisiblePosition = 1
        UltraGridColumn34.Header.VisiblePosition = 2
        UltraGridColumn34.Width = 206
        UltraGridColumn35.Header.VisiblePosition = 3
        UltraGridColumn36.Header.VisiblePosition = 4
        UltraGridColumn37.Header.VisiblePosition = 5
        UltraGridColumn38.Header.VisiblePosition = 6
        UltraGridColumn39.Header.VisiblePosition = 7
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39})
        Me.ucMedicos.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ucMedicos.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.ucMedicos.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ucMedicos.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ucMedicos.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.ucMedicos.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucMedicos.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.ucMedicos.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucMedicos.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
        Me.ucMedicos.DisplayLayout.MaxColScrollRegions = 1
        Me.ucMedicos.DisplayLayout.MaxRowScrollRegions = 1
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ucMedicos.DisplayLayout.Override.ActiveCellAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.SystemColors.Highlight
        Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ucMedicos.DisplayLayout.Override.ActiveRowAppearance = Appearance6
        Me.ucMedicos.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ucMedicos.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Me.ucMedicos.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ucMedicos.DisplayLayout.Override.CellAppearance = Appearance8
        Me.ucMedicos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ucMedicos.DisplayLayout.Override.CellPadding = 0
        Appearance9.BackColor = System.Drawing.SystemColors.Control
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.ucMedicos.DisplayLayout.Override.GroupByRowAppearance = Appearance9
        resources.ApplyResources(Appearance10, "Appearance10")
        Me.ucMedicos.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.ucMedicos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ucMedicos.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance11.BackColor = System.Drawing.SystemColors.Window
        Appearance11.BorderColor = System.Drawing.Color.Silver
        Me.ucMedicos.DisplayLayout.Override.RowAppearance = Appearance11
        Me.ucMedicos.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ucMedicos.DisplayLayout.Override.TemplateAddRowAppearance = Appearance12
        Me.ucMedicos.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ucMedicos.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ucMedicos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        resources.ApplyResources(Me.ucMedicos, "ucMedicos")
        Me.ucMedicos.Name = "ucMedicos"
        '
        'LabelControl1
        '
        resources.ApplyResources(Me.LabelControl1, "LabelControl1")
        Me.LabelControl1.Name = "LabelControl1"
        '
        'LabelControl4
        '
        resources.ApplyResources(Me.LabelControl4, "LabelControl4")
        Me.LabelControl4.Appearance.BackColor = System.Drawing.Color.Coral
        Me.LabelControl4.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelControl4.Appearance.Font = CType(resources.GetObject("LabelControl4.Appearance.Font"), System.Drawing.Font)
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl4.Appearance.Options.UseBackColor = True
        Me.LabelControl4.Appearance.Options.UseBorderColor = True
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Appearance.Options.UseTextOptions = True
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl4.Name = "LabelControl4"
        '
        'LabelControl3
        '
        resources.ApplyResources(Me.LabelControl3, "LabelControl3")
        Me.LabelControl3.Appearance.BackColor = System.Drawing.Color.Coral
        Me.LabelControl3.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelControl3.Appearance.Font = CType(resources.GetObject("LabelControl3.Appearance.Font"), System.Drawing.Font)
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl3.Appearance.Options.UseBackColor = True
        Me.LabelControl3.Appearance.Options.UseBorderColor = True
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Appearance.Options.UseTextOptions = True
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl3.Name = "LabelControl3"
        '
        'LabelControl2
        '
        resources.ApplyResources(Me.LabelControl2, "LabelControl2")
        Me.LabelControl2.Appearance.BackColor = System.Drawing.Color.Coral
        Me.LabelControl2.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelControl2.Appearance.Font = CType(resources.GetObject("LabelControl2.Appearance.Font"), System.Drawing.Font)
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl2.Appearance.Options.UseBackColor = True
        Me.LabelControl2.Appearance.Options.UseBorderColor = True
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Appearance.Options.UseTextOptions = True
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl2.Name = "LabelControl2"
        '
        'ucSalas
        '
        Appearance13.BackColor = System.Drawing.SystemColors.Window
        Appearance13.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ucSalas.DisplayLayout.Appearance = Appearance13
        UltraGridColumn15.Header.VisiblePosition = 0
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.Header.VisiblePosition = 1
        UltraGridColumn16.Width = 100
        UltraGridColumn17.Header.VisiblePosition = 2
        UltraGridColumn17.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn15, UltraGridColumn16, UltraGridColumn17})
        Me.ucSalas.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.ucSalas.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ucSalas.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ucSalas.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Appearance14.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance14.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance14.BorderColor = System.Drawing.SystemColors.Window
        Me.ucSalas.DisplayLayout.GroupByBox.Appearance = Appearance14
        Appearance15.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucSalas.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance15
        Me.ucSalas.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance16.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance16.BackColor2 = System.Drawing.SystemColors.Control
        Appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance16.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucSalas.DisplayLayout.GroupByBox.PromptAppearance = Appearance16
        Me.ucSalas.DisplayLayout.MaxColScrollRegions = 1
        Me.ucSalas.DisplayLayout.MaxRowScrollRegions = 1
        Appearance17.BackColor = System.Drawing.SystemColors.Window
        Appearance17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ucSalas.DisplayLayout.Override.ActiveCellAppearance = Appearance17
        Appearance18.BackColor = System.Drawing.SystemColors.Highlight
        Appearance18.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ucSalas.DisplayLayout.Override.ActiveRowAppearance = Appearance18
        Me.ucSalas.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ucSalas.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance19.BackColor = System.Drawing.SystemColors.Window
        Me.ucSalas.DisplayLayout.Override.CardAreaAppearance = Appearance19
        Appearance20.BorderColor = System.Drawing.Color.Silver
        Appearance20.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ucSalas.DisplayLayout.Override.CellAppearance = Appearance20
        Me.ucSalas.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ucSalas.DisplayLayout.Override.CellPadding = 0
        Appearance21.BackColor = System.Drawing.SystemColors.Control
        Appearance21.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance21.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance21.BorderColor = System.Drawing.SystemColors.Window
        Me.ucSalas.DisplayLayout.Override.GroupByRowAppearance = Appearance21
        resources.ApplyResources(Appearance22, "Appearance22")
        Me.ucSalas.DisplayLayout.Override.HeaderAppearance = Appearance22
        Me.ucSalas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ucSalas.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance23.BackColor = System.Drawing.SystemColors.Window
        Appearance23.BorderColor = System.Drawing.Color.Silver
        Me.ucSalas.DisplayLayout.Override.RowAppearance = Appearance23
        Me.ucSalas.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance24.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ucSalas.DisplayLayout.Override.TemplateAddRowAppearance = Appearance24
        Me.ucSalas.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ucSalas.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ucSalas.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        resources.ApplyResources(Me.ucSalas, "ucSalas")
        Me.ucSalas.Name = "ucSalas"
        '
        'ucTipos_Consulta
        '
        Appearance25.BackColor = System.Drawing.SystemColors.Window
        Appearance25.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ucTipos_Consulta.DisplayLayout.Appearance = Appearance25
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn1.Width = 125
        resources.ApplyResources(UltraGridColumn2.Header, "UltraGridColumn2.Header")
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 260
        UltraGridColumn2.ForceApplyResources = "Header"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Hidden = True
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4})
        Me.ucTipos_Consulta.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.ucTipos_Consulta.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ucTipos_Consulta.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ucTipos_Consulta.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Appearance26.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance26.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance26.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance26.BorderColor = System.Drawing.SystemColors.Window
        Me.ucTipos_Consulta.DisplayLayout.GroupByBox.Appearance = Appearance26
        Appearance27.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucTipos_Consulta.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance27
        Me.ucTipos_Consulta.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance28.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance28.BackColor2 = System.Drawing.SystemColors.Control
        Appearance28.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance28.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucTipos_Consulta.DisplayLayout.GroupByBox.PromptAppearance = Appearance28
        Me.ucTipos_Consulta.DisplayLayout.MaxColScrollRegions = 1
        Me.ucTipos_Consulta.DisplayLayout.MaxRowScrollRegions = 1
        Appearance29.BackColor = System.Drawing.SystemColors.Window
        Appearance29.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ucTipos_Consulta.DisplayLayout.Override.ActiveCellAppearance = Appearance29
        Appearance30.BackColor = System.Drawing.SystemColors.Highlight
        Appearance30.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ucTipos_Consulta.DisplayLayout.Override.ActiveRowAppearance = Appearance30
        Me.ucTipos_Consulta.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ucTipos_Consulta.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance31.BackColor = System.Drawing.SystemColors.Window
        Me.ucTipos_Consulta.DisplayLayout.Override.CardAreaAppearance = Appearance31
        Appearance32.BorderColor = System.Drawing.Color.Silver
        Appearance32.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ucTipos_Consulta.DisplayLayout.Override.CellAppearance = Appearance32
        Me.ucTipos_Consulta.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ucTipos_Consulta.DisplayLayout.Override.CellPadding = 0
        Appearance33.BackColor = System.Drawing.SystemColors.Control
        Appearance33.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance33.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance33.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance33.BorderColor = System.Drawing.SystemColors.Window
        Me.ucTipos_Consulta.DisplayLayout.Override.GroupByRowAppearance = Appearance33
        resources.ApplyResources(Appearance34, "Appearance34")
        Me.ucTipos_Consulta.DisplayLayout.Override.HeaderAppearance = Appearance34
        Me.ucTipos_Consulta.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ucTipos_Consulta.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance35.BackColor = System.Drawing.SystemColors.Window
        Appearance35.BorderColor = System.Drawing.Color.Silver
        Me.ucTipos_Consulta.DisplayLayout.Override.RowAppearance = Appearance35
        Me.ucTipos_Consulta.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance36.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ucTipos_Consulta.DisplayLayout.Override.TemplateAddRowAppearance = Appearance36
        Me.ucTipos_Consulta.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ucTipos_Consulta.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ucTipos_Consulta.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        resources.ApplyResources(Me.ucTipos_Consulta, "ucTipos_Consulta")
        Me.ucTipos_Consulta.Name = "ucTipos_Consulta"
        '
        'ucAnimais
        '
        Appearance37.BackColor = System.Drawing.SystemColors.Window
        Appearance37.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ucAnimais.DisplayLayout.Appearance = Appearance37
        UltraGridColumn5.Header.VisiblePosition = 0
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.Header.VisiblePosition = 1
        UltraGridColumn6.Width = 212
        UltraGridColumn7.Header.VisiblePosition = 2
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 3
        UltraGridColumn8.Hidden = True
        UltraGridColumn11.Header.VisiblePosition = 4
        UltraGridColumn11.Width = 137
        UltraGridColumn9.Header.VisiblePosition = 5
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.Header.VisiblePosition = 6
        UltraGridColumn10.Hidden = True
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn11, UltraGridColumn9, UltraGridColumn10})
        Me.ucAnimais.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.ucAnimais.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ucAnimais.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ucAnimais.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Appearance38.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance38.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance38.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance38.BorderColor = System.Drawing.SystemColors.Window
        Me.ucAnimais.DisplayLayout.GroupByBox.Appearance = Appearance38
        Appearance39.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucAnimais.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance39
        Me.ucAnimais.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance40.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance40.BackColor2 = System.Drawing.SystemColors.Control
        Appearance40.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance40.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucAnimais.DisplayLayout.GroupByBox.PromptAppearance = Appearance40
        Me.ucAnimais.DisplayLayout.MaxColScrollRegions = 1
        Me.ucAnimais.DisplayLayout.MaxRowScrollRegions = 1
        Appearance41.BackColor = System.Drawing.SystemColors.Window
        Appearance41.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ucAnimais.DisplayLayout.Override.ActiveCellAppearance = Appearance41
        Appearance42.BackColor = System.Drawing.SystemColors.Highlight
        Appearance42.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ucAnimais.DisplayLayout.Override.ActiveRowAppearance = Appearance42
        Me.ucAnimais.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ucAnimais.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance43.BackColor = System.Drawing.SystemColors.Window
        Me.ucAnimais.DisplayLayout.Override.CardAreaAppearance = Appearance43
        Appearance44.BorderColor = System.Drawing.Color.Silver
        Appearance44.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ucAnimais.DisplayLayout.Override.CellAppearance = Appearance44
        Me.ucAnimais.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ucAnimais.DisplayLayout.Override.CellPadding = 0
        Appearance45.BackColor = System.Drawing.SystemColors.Control
        Appearance45.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance45.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance45.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance45.BorderColor = System.Drawing.SystemColors.Window
        Me.ucAnimais.DisplayLayout.Override.GroupByRowAppearance = Appearance45
        resources.ApplyResources(Appearance46, "Appearance46")
        Me.ucAnimais.DisplayLayout.Override.HeaderAppearance = Appearance46
        Me.ucAnimais.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ucAnimais.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance47.BackColor = System.Drawing.SystemColors.Window
        Appearance47.BorderColor = System.Drawing.Color.Silver
        Me.ucAnimais.DisplayLayout.Override.RowAppearance = Appearance47
        Me.ucAnimais.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance48.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ucAnimais.DisplayLayout.Override.TemplateAddRowAppearance = Appearance48
        Me.ucAnimais.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ucAnimais.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ucAnimais.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        resources.ApplyResources(Me.ucAnimais, "ucAnimais")
        Me.ucAnimais.Name = "ucAnimais"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Name = "RibbonPage1"
        resources.ApplyResources(Me.RibbonPage1, "RibbonPage1")
        '
        'panel3
        '
        Me.panel3.Controls.Add(Me.backstageViewControl1)
        resources.ApplyResources(Me.panel3, "panel3")
        Me.panel3.Name = "panel3"
        '
        'OutlookAppointmentForm
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.panel3)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.progressPanel)
        Me.Controls.Add(Me.ribbonControl1)
        Me.Name = "OutlookAppointmentForm"
        Me.Ribbon = Me.ribbonControl1
        Me.ShowInTaskbar = False
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.backstageViewControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.backstageViewControl1.ResumeLayout(False)
        Me.bvPrint.ResumeLayout(False)
        CType(Me.riAppointmentLabel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riAppointmentStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riDuration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riAppointmentResource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtStartDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtStartDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbLocation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtStartTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtEndDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtEndDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtEndTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.edtTimeZone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtResource.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtResources.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtResources.ResourcesCheckedListBoxControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAllDay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbSubject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.progressPanel.ResumeLayout(False)
        Me.progressPanel.PerformLayout()
        CType(Me.tbProgress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbProgress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        CType(Me.ucMedicos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucSalas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucTipos_Consulta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucAnimais, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region

    Private components As System.ComponentModel.IContainer = Nothing
    Protected lblStartTime As DevExpress.XtraEditors.LabelControl
    Protected edtStartDate As DevExpress.XtraEditors.DateEdit
    Protected tbLocation As DevExpress.XtraEditors.TextEdit
    Protected edtStartTime As DevExpress.XtraEditors.TimeEdit
    Protected lblEndTime As DevExpress.XtraEditors.LabelControl
    Protected edtEndDate As DevExpress.XtraEditors.DateEdit
    Protected edtEndTime As DevExpress.XtraEditors.TimeEdit
    Protected lblLocation As DevExpress.XtraEditors.LabelControl
    Protected panel1 As DevExpress.XtraEditors.PanelControl
    Protected lblResource As DevExpress.XtraEditors.LabelControl
    Protected edtResource As AppointmentResourceEdit
    Protected edtResources As AppointmentResourcesEdit
    Protected chkAllDay As DevExpress.XtraEditors.CheckEdit
    Protected tbSubject As DevExpress.XtraEditors.TextEdit
    Protected progressPanel As System.Windows.Forms.Panel
    Protected tbProgress As DevExpress.XtraEditors.TrackBarControl
    Protected lblPercentCompleteValue As DevExpress.XtraEditors.LabelControl
    Protected lblPercentComplete As DevExpress.XtraEditors.LabelControl
    Protected lblSubject As DevExpress.XtraEditors.LabelControl
    Private panelMain As System.Windows.Forms.Panel
    Protected tbDescription As DevExpress.XtraEditors.MemoEdit
    Private panelDescription As System.Windows.Forms.Panel
    Private panel2 As System.Windows.Forms.Panel
    Private edtTimeZone As TimeZoneEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Private WithEvents ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents btnSaveAndClose As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnDelete As DevExpress.XtraBars.BarButtonItem
    Private WithEvents barLabel As DevExpress.XtraBars.BarEditItem
    Private WithEvents riAppointmentLabel As RepositoryItemAppointmentLabel
    Private WithEvents barStatus As DevExpress.XtraBars.BarEditItem
    Private WithEvents riAppointmentStatus As RepositoryItemAppointmentStatus
    Private WithEvents barReminder As DevExpress.XtraBars.BarEditItem
    Private WithEvents riDuration As RepositoryItemDuration
    Private WithEvents btnRecurrence As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnNext As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnPrevious As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnTimeZones As DevExpress.XtraBars.BarButtonItem
    Private WithEvents rpAppointment As DevExpress.XtraBars.Ribbon.RibbonPage
    Private WithEvents rpgActions As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private WithEvents rpgOptions As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private WithEvents riAppointmentResource As RepositoryItemAppointmentResource
    Friend WithEvents ucTipos_Consulta As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents ucAnimais As Infragistics.Win.UltraWinGrid.UltraCombo
    Protected WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Protected WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Protected WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ucSalas As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Protected WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ucMedicos As Infragistics.Win.UltraWinGrid.UltraCombo
    Private WithEvents panel3 As Panel
    Private WithEvents backstageViewControl1 As DevExpress.XtraBars.Ribbon.BackstageViewControl
    Private WithEvents bvPrint As DevExpress.XtraBars.Ribbon.BackstageViewClientControl
    Private WithEvents appointmentBackstageControl As DevExpress.XtraScheduler.Design.AppointmentBackstageControl
    Friend WithEvents cmdFatura As Button
End Class