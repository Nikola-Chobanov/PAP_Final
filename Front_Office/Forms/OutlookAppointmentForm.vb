Imports System.ComponentModel
Imports System.Drawing
Imports System.IO
Imports System.Reflection
Imports System.Windows.Forms
Imports DevExpress.CodeParser
Imports DevExpress.Utils
Imports DevExpress.Utils.Internal
Imports DevExpress.Utils.Menu
Imports DevExpress.Utils.Svg
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Native
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Commands
Imports DevExpress.XtraScheduler.iCalendar
Imports DevExpress.XtraScheduler.Localization
Imports DevExpress.XtraScheduler.Native
Imports DevExpress.XtraScheduler.Printing
Imports DevExpress.XtraScheduler.Printing.Native
Imports DevExpress.XtraScheduler.Services
Imports DevExpress.XtraScheduler.UI

Partial Public Class OutlookAppointmentForm
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm
    Implements IDXManagerPopupMenu


#Region "Fields"
    Private m_openRecurrenceForm As Boolean
    Private ReadOnly m_storage As ISchedulerStorage
    Private ReadOnly m_control As SchedulerControl
    Private m_recurringSvgImage As SvgImage
    Private m_normalSvgImage As SvgImage
    Private ReadOnly m_controller As AppointmentFormController
    Private m_menuManager As IDXMenuManager
    Private m_supressCancelCore As Boolean

    '-----------------------------------------------------------------------
    ' INdices
    Private mIndex_Sala As Integer = 0
    Private mIndex_TC As Integer = 0
    Private mIndex_Animal As Integer = 0
    Private mIndex_Medico As Integer = 0


    Private mClsConsulta As New ClsConsultas

    Private mCod_Consulta As String = String.Empty


    Private mCod_Entidade As String = String.Empty
    Private mCod_Veterinario As String = String.Empty

    Private mCod_Sala As String = String.Empty
    Private mCod_Tipo_Consulta As String = String.Empty
    Private mCod_Tipo_Animal As String = String.Empty
    Private mCod_Animal As String = String.Empty


    Private mHI As DateTime
    Private mHF As DateTime

    Private mNome_Entidade As String = String.Empty
    Private mNome_Medico As String = String.Empty
    Private mSala As String = String.Empty
    Private mNome_Animal As String = String.Empty

    Private mTipo_Consulta As String = String.Empty
    Private mTipo_Animal As String = String.Empty

    Private mLista_Salas As New List(Of ClsSalas)
    Private mLista_Animais As New List(Of ClsAnimais)
    Private mLista_Tipos_Consulta As New List(Of ClsTipos_Consulta)
    Private mLista_Medicos As New List(Of ClsEntidades)

    Private mClsEntidade As New ClsEntidades

    Private mClsAnimal As New ClsAnimais



    '-----------------------------------------------------------------------
    'Private _Contacts As String = String.Empty

#End Region

    <EditorBrowsable(EditorBrowsableState.Never)>
    Public Sub New()
        InitializeComponent()
    End Sub
    Public Sub New(ByVal control As DevExpress.XtraScheduler.SchedulerControl, ByVal apt As Appointment)
        Me.New(control, apt, False)
    End Sub
    Public Sub New(ByVal control As DevExpress.XtraScheduler.SchedulerControl, ByVal apt As Appointment, ByVal openRecurrenceForm As Boolean)
        Guard.ArgumentNotNull(control, "control")
        Guard.ArgumentNotNull(control.DataStorage, "control.DataStorage")
        Guard.ArgumentNotNull(apt, "apt")

        Me.m_openRecurrenceForm = openRecurrenceForm
        Me.m_controller = CreateController(control, apt)
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()
        SetupPredefinedConstraints()

        LoadIcons()

        Me.m_control = control
        Me.m_storage = control.DataStorage

        Me.edtResource.SchedulerControl = control
        Me.edtResource.Storage = m_storage
        Me.edtResources.SchedulerControl = control

        Me.riAppointmentResource.SchedulerControl = control
        Me.riAppointmentResource.Storage = m_storage
        Me.riAppointmentStatus.Storage = m_storage

        Me.riAppointmentLabel.Storage = m_storage

        BindControllerToControls()

        LookAndFeel.ParentLookAndFeel = control.LookAndFeel

        Me.m_supressCancelCore = False
    End Sub


#Region "Properties"
    <Browsable(False)>
    Public Property MenuManager() As IDXMenuManager
        Get
            Return m_menuManager
        End Get
        Private Set(ByVal value As IDXMenuManager)
            m_menuManager = value
        End Set
    End Property
    Protected Friend ReadOnly Property Controller() As AppointmentFormController
        Get
            Return m_controller
        End Get
    End Property
    Protected Friend ReadOnly Property Control() As SchedulerControl
        Get
            Return m_control
        End Get
    End Property
    Protected Friend ReadOnly Property Storage() As ISchedulerStorage
        Get
            Return m_storage
        End Get
    End Property
    Protected Friend ReadOnly Property IsNewAppointment() As Boolean
        Get
            Return If(m_controller IsNot Nothing, m_controller.IsNewAppointment, True)
        End Get
    End Property
    Protected Friend ReadOnly Property RecurringSvgImage() As SvgImage
        Get
            Return m_recurringSvgImage
        End Get
    End Property
    Protected Friend ReadOnly Property NormalSvgImage() As SvgImage
        Get
            Return m_normalSvgImage
        End Get
    End Property
    <Browsable(False), EditorBrowsable(EditorBrowsableState.Never)>
    Public Property SvgImage() As SvgImage
        Get
            Return IconOptions.SvgImage
        End Get
        Set(ByVal value As SvgImage)
            IconOptions.SvgImage = value
        End Set
    End Property
    Protected Friend ReadOnly Property OpenRecurrenceForm() As Boolean
        Get
            Return m_openRecurrenceForm
        End Get
    End Property
    <DXDescription("DevExpress.XtraScheduler.UI.AppointmentRibbonForm,ReadOnly"), DXCategory(CategoryName.Behavior), DefaultValue(False)>
    Public Property [ReadOnly]() As Boolean
        Get
            Return Controller.ReadOnly
        End Get
        Set(ByVal value As Boolean)
            If Controller.ReadOnly = value Then
                Return
            End If
            Controller.ReadOnly = value
        End Set
    End Property
    Protected Overrides ReadOnly Property ShowMode() As FormShowMode
        Get
            Return DevExpress.XtraEditors.FormShowMode.AfterInitialization
        End Get
    End Property
#End Region

    Sub Display_TBS()
        mNome_Medico = mClsConsulta.Nome_Medico

        Me.tbSubject.Text = "Consulta:" & mClsConsulta.Tipo_Consulta ' & "-" & mNome_Medico
        tbLocation.Text = mClsConsulta.Sala

        tbDescription.Text = Display_Descriptions()

        mClsConsulta.Observacoes = tbDescription.Text

    End Sub


    Function Display_Descriptions() As String

        Dim mReturn As String = String.Empty
        mTipo_Animal = mClsConsulta.Tipo_Animal
        mNome_Animal = mClsConsulta.Nome_Animal
        mNome_Entidade = mClsConsulta.Nome_Entidade


        mReturn = mTipo_Animal & ": " & mNome_Animal & " - Dono: " & mNome_Entidade & vbCrLf
        mReturn += "----------------------------------------------" & vbCrLf
        mReturn += "M�dico: " & mClsConsulta.Nome_Medico & " - " & mClsConsulta.Cod_Consulta

        Return mReturn
    End Function

    Sub Get_UCS(pNovo As Boolean)

        If pNovo Then
            mIndex_Sala = 0
            mIndex_TC = 0
            mIndex_Animal = 0
            mIndex_Medico = 0

        End If


        With Me.ucTipos_Consulta
            .DataSource = mLista_Tipos_Consulta
            .DisplayMember = "Designacao"
            .Rows(mIndex_TC).Selected = True

        End With

        With Me.ucAnimais
            .DataSource = mLista_Animais
            .DisplayMember = "Nome_Animal"
            .Rows(mIndex_Animal).Selected = True

        End With

        With Me.ucMedicos
            .DataSource = mLista_Medicos
            .DisplayMember = "Nome"
            .Rows(mIndex_Medico).Selected = True

        End With

        With Me.ucSalas
            .DataSource = mLista_Salas
            .DisplayMember = "Sala"
            .Rows(mIndex_Sala).Selected = True

        End With
    End Sub

    Sub Get_mListas()

        mLista_Animais = ClsAnimais.GetAnimais
        mLista_Salas = ClsSalas.GetSalas
        mLista_Tipos_Consulta = ClsTipos_Consulta.GetTipos_Consulta
        mLista_Medicos = ClsEntidades.GetEntidadesByFLG("V")

    End Sub

    Sub Get_Datas()

        mHI = edtStartDate.Text
        mHI = mHI.AddHours(CInt(edtStartTime.Text.Substring(0, 2)))
        mHI = mHI.AddMinutes(CInt(edtStartTime.Text.Substring(3, 2)))

        mHF = edtEndDate.Text
        mHF = mHF.AddHours(CInt(edtEndTime.Text.Substring(0, 2)))
        mHF = mHF.AddMinutes(CInt(edtEndTime.Text.Substring(3, 2)))

        With mClsConsulta
            .Hora_Inicio = mHI
            .Hora_Fim = mHF
            .Dia = edtStartDate.Text
        End With
    End Sub

    Public Overridable Sub LoadFormData(ByVal appointment As Appointment)

        If appointment.CustomFields("Cod_Consulta") IsNot Nothing And Not appointment.CustomFields("Cod_Consulta") = "" Then

            mCod_Consulta = appointment.CustomFields("Cod_Consulta").ToString
            mClsConsulta = ClsConsultas.GetConsultasByCod(mCod_Consulta)

            Get_mListas()

            mCod_Entidade = mClsConsulta.Cod_Entidade
            mCod_Animal = mClsConsulta.Cod_Animal

            mCod_Sala = mClsConsulta.Cod_Sala
            mCod_Tipo_Consulta = mClsConsulta.Cod_Tipo_Consulta
            mCod_Tipo_Animal = mClsConsulta.Cod_Tipo_Animal
            mCod_Veterinario = mClsConsulta.Cod_Veterinario

            mSala = mClsConsulta.Sala
            mIndex_Sala = mLista_Salas.FindIndex(Function(x) x.Cod_Sala = mCod_Sala)


            mNome_Animal = mClsConsulta.Nome_Animal
            mIndex_Animal = mLista_Animais.FindIndex(Function(x) x.Cod_Animal = mCod_Animal)

            mNome_Entidade = mClsConsulta.Nome_Entidade
            mIndex_Medico = mLista_Medicos.FindIndex(Function(x) x.Cod_Entidade = mCod_Veterinario)

            mTipo_Animal = mClsConsulta.Tipo_Animal

            mTipo_Consulta = mClsConsulta.Tipo_Consulta
            mIndex_TC = mLista_Tipos_Consulta.FindIndex(Function(x) x.Cod_Tipo_Consulta = mCod_Tipo_Consulta)

            mHI = edtStartDate.Text
            mHF = edtEndDate.Text

            mHI = mHI.AddHours(CInt(edtStartTime.Text.Substring(0, 2)))
            mHI = mHI.AddMinutes(CInt(edtStartTime.Text.Substring(3, 2)))

            Dim mHoras As Integer = CInt(edtEndTime.Text.Substring(0, 2))
            Dim mMinutos As Integer = CInt(edtEndTime.Text.Substring(3, 2))

            mHF = mHF.AddHours(mHoras)
            mHF = mHF.AddMinutes(mMinutos)


            tbSubject.Text = "Consulta:" & mTipo_Consulta
            tbLocation.Text = mSala
            tbDescription.Text = Display_Descriptions()
            mClsConsulta.Observacoes = tbDescription.Text

            Get_Datas()

            Get_UCS(False)

            Me.ucTipos_Consulta.Focus()
        Else
            Me.edtResource.SelectedIndex = 1

            mHI = edtStartDate.Text
            mHI = mHI.AddHours(CInt(edtStartTime.Text.Substring(0, 2)))
            mHI = mHI.AddMinutes(CInt(edtStartTime.Text.Substring(3, 2)))

            mHF = edtEndDate.Text
            mHF = mHF.AddHours(CInt(edtEndTime.Text.Substring(0, 2)))
            mHF = mHF.AddMinutes(CInt(edtEndTime.Text.Substring(3, 2)))

            mClsConsulta = New ClsConsultas With {
                .Cod_Consulta = ClsConsultas.GetNovoCodigo,
                .Cod_Entidade = "C0001",
                .Cod_Veterinario = "V0001",
                .Cod_Sala = "S01",
                .Cod_Animal = "A0001",
                .Cod_Tipo_Consulta = "TC001",
                .Cod_Tipo_Animal = "TA01",
                .Hora_Inicio = mHI,
                .Hora_Fim = mHF,
                .Dia = edtStartDate.Text,
                .Observacoes = "",
                .Status = enStatus.Agendada
                }

            Get_mListas()
            Get_UCS(True)

            Me.ucTipos_Consulta.Focus()
        End If
        '------------------------------

        'If appointment.CustomFields("Cod_Animal") IsNot Nothing Then
        '    mCod_Animal = appointment.CustomFields("Cod_Animal").ToString
        'Else
        '    mCod_Animal = "-"
        'End If
        ''------------------------------


        'If appointment.CustomFields("Cod_Sala") IsNot Nothing Then
        '    mCod_Sala = appointment.CustomFields("Cod_sala").ToString
        'Else
        '    mCod_Sala = "-"
        'End If
        ''------------------------------


        'If appointment.CustomFields("Contacts") IsNot Nothing Then
        '    _Contacts = appointment.CustomFields("Contacts").ToString
        '    Me.MemoContact.Text = _Contacts
        'End If

    End Sub
    Public Overridable Function SaveFormData(ByVal appointment As Appointment) As Boolean

        'appointment.CustomFields("Contacts") = MemoContact.Text

        appointment.CustomFields("Cod_Consulta") = mClsConsulta.Cod_Consulta

        If IsNewAppointment Then
            If Not ClsConsultas.GravaConsultas(mClsConsulta) Then
                MsgBox("N�o consegui gravar o novo")
            End If
        Else
            If Not ClsConsultas.ModificaConsultas(mClsConsulta) Then
                MsgBox("N�o consegui Modificar")
            End If
        End If

        Return True

    End Function
    Public Overridable Function IsAppointmentChanged(ByVal appointment As Appointment) As Boolean

        'If _Contacts = appointment.CustomFields("Contacts") Then
        '    Return False
        'Else
        '    Return True
        'End If
        If mCod_Consulta = appointment.CustomFields("Cod_Consulta") Then
            Return False
        Else
            Return True
        End If
        'Return True
    End Function
    Public Overridable Sub SetMenuManager(ByVal menuManager As DevExpress.Utils.Menu.IDXMenuManager)
        MenuManagerUtils.SetMenuManager(Controls, menuManager)
        Me.m_menuManager = menuManager
    End Sub

    Protected Friend Overridable Sub SetupPredefinedConstraints()
        Me.tbProgress.Properties.Minimum = AppointmentProcessValues.Min
        Me.tbProgress.Properties.Maximum = AppointmentProcessValues.Max
        Me.tbProgress.Properties.SmallChange = AppointmentProcessValues.Step
        Me.edtResources.Visible = True
        If (Not WindowsFormsSettings.GetAllowDefaultSvgImages()) Then
            For Each item As BarItem In Me.ribbonControl1.Items
                item.ImageOptions.SvgImage = Nothing
            Next item
        End If
    End Sub
    Protected Overridable Sub BindControllerToControls()
        Me.DataBindings.Add("Text", Controller, "Subject")
        'Me.Text = tbSubject.Text & "-" & "Consulta"
        BindControllerToIcon()
        BindProperties(Me.tbSubject, "Text", "Subject")
        BindProperties(Me.tbLocation, "Text", "Location")
        BindProperties(Me.tbDescription, "Text", "Description")
        BindProperties(Me.edtStartDate, "EditValue", "DisplayStartDate")
        BindProperties(Me.edtStartDate, "Enabled", "IsDateTimeEditable")
        BindProperties(Me.edtStartTime, "EditValue", "DisplayStartTime")
        BindProperties(Me.edtStartTime, "Enabled", "IsTimeEnabled")
        BindProperties(Me.edtEndDate, "EditValue", "DisplayEndDate", DataSourceUpdateMode.Never)
        BindProperties(Me.edtEndDate, "Enabled", "IsDateTimeEditable", DataSourceUpdateMode.Never)
        BindProperties(Me.edtEndTime, "EditValue", "DisplayEndTime", DataSourceUpdateMode.Never)
        BindProperties(Me.edtEndTime, "Enabled", "IsTimeEnabled", DataSourceUpdateMode.Never)
        BindProperties(Me.chkAllDay, "Checked", "AllDay")
        BindProperties(Me.chkAllDay, "Enabled", "IsDateTimeEditable")

        BindProperties(Me.lblResource, "Enabled", "CanEditResource")

        BindProperties(Me.edtResources, "ResourceIds", "ResourceIds")
        BindProperties(Me.edtResources, "Visible", "ResourceSharing")
        BindProperties(Me.edtResources, "Enabled", "CanEditResource")

        BindProperties(Me.edtResource, "ResourceId", "ResourceId")
        BindProperties(Me.edtResource, "Enabled", "CanEditResource")
        BindToBoolPropertyAndInvert(Me.edtResource, "Visible", "ResourceSharing")

        BindProperties(Me.barLabel, "EditValue", "Label")

        BindProperties(Me.barStatus, "EditValue", "Status")

        BindBoolToVisibility(Me.barReminder, "Visibility", "ReminderVisible")
        BindProperties(Me.barReminder, "Editvalue", "ReminderTimeBeforeStart")

        BindProperties(Me.tbProgress, "Value", "PercentComplete")
        BindProperties(Me.lblPercentCompleteValue, "Text", "PercentComplete", AddressOf ObjectToStringConverter)
        BindProperties(Me.progressPanel, "Visible", "ShouldEditTaskProgress")
        BindProperties(Me.btnDelete, "Enabled", "CanDeleteAppointment")

        BindBoolToVisibility(Me.btnRecurrence, "Visibility", "ShouldShowRecurrenceButton")
        BindProperties(Me.btnRecurrence, "Down", "IsRecurrentAppointment")


        BindToBoolPropertyAndInvert(Me.ribbonControl1, "Enabled", "ReadOnly")

        BindProperties(Me.edtTimeZone, "Visible", "TimeZoneVisible")
        BindProperties(Me.edtTimeZone, "EditValue", "TimeZoneId")
        BindProperties(Me.edtTimeZone, "Enabled", "TimeZoneEnabled")

        BindBoolToVisibility(Me.btnTimeZones, "Visibility", "TimeZonesEnabled")
        BindProperties(Me.btnTimeZones, "Down", "TimeZoneVisible")
    End Sub

    Protected Overridable Sub BindControllerToIcon()
        Dim binding As New Binding("SvgImage", Controller, "AppointmentType")
        AddHandler binding.Format, AddressOf AppointmentTypeToIconConverter
        DataBindings.Add(binding)
    End Sub
    Protected Overridable Sub ObjectToStringConverter(ByVal o As Object, ByVal e As ConvertEventArgs)
        e.Value = e.Value.ToString()
    End Sub
    Protected Overridable Sub AppointmentTypeToIconConverter(ByVal o As Object, ByVal e As ConvertEventArgs)
        Dim type As AppointmentType = CType(e.Value, AppointmentType)
        If type = AppointmentType.Pattern Then
            e.Value = RecurringSvgImage
        Else
            e.Value = NormalSvgImage
        End If
    End Sub
    Protected Overridable Sub BindProperties(ByVal target As Control, ByVal targetProperty As String, ByVal sourceProperty As String)
        BindProperties(target, targetProperty, sourceProperty, DataSourceUpdateMode.OnPropertyChanged)
    End Sub
    Protected Overridable Sub BindProperties(ByVal target As Control, ByVal targetProperty As String, ByVal sourceProperty As String, ByVal updateMode As DataSourceUpdateMode)
        target.DataBindings.Add(targetProperty, Controller, sourceProperty, True, updateMode)
        BindToIsReadOnly(target, updateMode)
    End Sub
    Protected Overridable Sub BindProperties(ByVal target As Control, ByVal targetProperty As String, ByVal sourceProperty As String, ByVal objectToStringConverter As ConvertEventHandler)
        Dim binding As New Binding(targetProperty, Controller, sourceProperty, True)
        AddHandler binding.Format, objectToStringConverter
        target.DataBindings.Add(binding)
    End Sub
    Protected Overridable Sub BindToBoolPropertyAndInvert(ByVal target As Control, ByVal targetProperty As String, ByVal sourceProperty As String)
        target.DataBindings.Add(New BoolInvertBinding(targetProperty, Controller, sourceProperty))
        BindToIsReadOnly(target)
    End Sub
    Protected Overridable Sub BindToIsReadOnly(ByVal control As Control)
        BindToIsReadOnly(control, DataSourceUpdateMode.OnPropertyChanged)
    End Sub
    Protected Overridable Sub BindToIsReadOnly(ByVal control As Control, ByVal updateMode As DataSourceUpdateMode)
        If (Not (TypeOf control Is BaseEdit)) OrElse control.DataBindings("ReadOnly") IsNot Nothing Then
            Return
        End If
        control.DataBindings.Add("ReadOnly", Controller, "ReadOnly", True, updateMode)
    End Sub

    Protected Overridable Sub BindProperties(ByVal target As DevExpress.XtraBars.BarItem, ByVal targetProperty As String, ByVal sourceProperty As String)
        BindProperties(target, targetProperty, sourceProperty, DataSourceUpdateMode.OnPropertyChanged)
    End Sub
    Protected Overridable Sub BindProperties(ByVal target As DevExpress.XtraBars.BarItem, ByVal targetProperty As String, ByVal sourceProperty As String, ByVal updateMode As DataSourceUpdateMode)
        target.DataBindings.Add(targetProperty, Controller, sourceProperty, True, updateMode)
    End Sub
    Protected Overridable Sub BindProperties(ByVal target As DevExpress.XtraBars.BarItem, ByVal targetProperty As String, ByVal sourceProperty As String, ByVal objectToStringConverter As ConvertEventHandler)
        Dim binding As New Binding(targetProperty, Controller, sourceProperty, True)
        AddHandler binding.Format, objectToStringConverter
        target.DataBindings.Add(binding)
    End Sub
    Protected Overridable Sub BindToBoolPropertyAndInvert(ByVal target As DevExpress.XtraBars.BarItem, ByVal targetProperty As String, ByVal sourceProperty As String)
        target.DataBindings.Add(New BoolInvertBinding(targetProperty, Controller, sourceProperty))
    End Sub
    Protected Overridable Sub BindBoolToVisibility(ByVal target As DevExpress.XtraBars.BarItem, ByVal targetProperty As String, ByVal sourceProperty As String)
        target.DataBindings.Add(New BoolToVisibilityBinding(targetProperty, Controller, sourceProperty, False))
    End Sub
    Protected Overridable Sub BindBoolToVisibility(ByVal target As DevExpress.XtraBars.BarItem, ByVal targetProperty As String, ByVal sourceProperty As String, ByVal invert As Boolean)
        target.DataBindings.Add(New BoolToVisibilityBinding(targetProperty, Controller, sourceProperty, invert))
    End Sub

    Protected Overrides Sub OnLoad(ByVal e As EventArgs)
        MyBase.OnLoad(e)
        If Controller Is Nothing Then
            Return
        End If
        SubscribeControlsEvents()
        LoadFormData(Controller.EditedAppointmentCopy)
    End Sub
    Protected Overridable Function CreateController(ByVal control As SchedulerControl, ByVal apt As Appointment) As AppointmentFormController
        Return New AppointmentFormController(control, apt)
    End Function
    Protected Friend Overridable Sub LoadIcons()
        Dim asm As System.Reflection.Assembly = GetType(Appointment).Assembly
        Me.m_recurringSvgImage = ResourceImageHelper.CreateSvgImageFromResources(SchedulerSvgImageNames.NewRecurringAppointment, asm)
        Me.m_normalSvgImage = ResourceImageHelper.CreateSvgImageFromResources(SchedulerSvgImageNames.NewAppointment, asm)
    End Sub
    Protected Friend Overridable Sub SubscribeControlsEvents()
        AddHandler Me.edtEndDate.Validating, AddressOf OnEdtEndDateValidating
        AddHandler Me.edtEndDate.InvalidValue, AddressOf OnEdtEndDateInvalidValue
        AddHandler Me.edtEndTime.Validating, AddressOf OnEdtEndTimeValidating
        AddHandler Me.edtEndTime.InvalidValue, AddressOf OnEdtEndTimeInvalidValue
        AddHandler Me.riDuration.Validating, AddressOf OnCbReminderValidating
        AddHandler Me.edtStartDate.Validating, AddressOf OnEdtStartDateValidating
        AddHandler Me.edtStartDate.InvalidValue, AddressOf OnEdtStartDateInvalidValue
        AddHandler Me.edtStartTime.Validating, AddressOf OnEdtStartTimeValidating
        AddHandler Me.edtStartTime.InvalidValue, AddressOf OnEdtStartTimeInvalidValue
    End Sub
    Protected Friend Overridable Sub UnsubscribeControlsEvents()
        RemoveHandler Me.edtEndDate.Validating, AddressOf OnEdtEndDateValidating
        RemoveHandler Me.edtEndDate.InvalidValue, AddressOf OnEdtEndDateInvalidValue
        RemoveHandler Me.edtEndTime.Validating, AddressOf OnEdtEndTimeValidating
        RemoveHandler Me.edtEndTime.InvalidValue, AddressOf OnEdtEndTimeInvalidValue
        RemoveHandler Me.riDuration.Validating, AddressOf OnCbReminderValidating
        RemoveHandler Me.edtStartDate.Validating, AddressOf OnEdtStartDateValidating
        RemoveHandler Me.edtStartDate.InvalidValue, AddressOf OnEdtStartDateInvalidValue
        RemoveHandler Me.edtStartTime.Validating, AddressOf OnEdtStartTimeValidating
        RemoveHandler Me.edtStartTime.InvalidValue, AddressOf OnEdtStartTimeInvalidValue
    End Sub

    Protected Friend Overridable Sub OnEdtStartTimeInvalidValue(ByVal sender As Object, ByVal e As InvalidValueExceptionEventArgs)
        e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_DateOutsideLimitInterval)
    End Sub
    Protected Friend Overridable Sub OnEdtStartTimeValidating(ByVal sender As Object, ByVal e As CancelEventArgs)
        e.Cancel = Not Controller.ValidateLimitInterval(edtStartDate.DateTime.Date, edtStartTime.Time.TimeOfDay, edtEndDate.DateTime.Date, edtEndTime.Time.TimeOfDay)
    End Sub
    Protected Friend Overridable Sub OnEdtStartDateInvalidValue(ByVal sender As Object, ByVal e As InvalidValueExceptionEventArgs)
        e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_DateOutsideLimitInterval)
    End Sub
    Protected Friend Overridable Sub OnEdtStartDateValidating(ByVal sender As Object, ByVal e As CancelEventArgs)
        e.Cancel = Not Controller.ValidateLimitInterval(edtStartDate.DateTime.Date, edtStartTime.Time.TimeOfDay, edtEndDate.DateTime.Date, edtEndTime.Time.TimeOfDay)
    End Sub
    Protected Friend Overridable Sub OnEdtEndDateValidating(ByVal sender As Object, ByVal e As CancelEventArgs)
        e.Cancel = Not IsValidInterval()
        If (Not e.Cancel) Then
            Me.edtEndDate.DataBindings("EditValue").WriteValue()
        End If
    End Sub
    Protected Friend Overridable Sub OnEdtEndDateInvalidValue(ByVal sender As Object, ByVal e As InvalidValueExceptionEventArgs)
        If (Not AppointmentFormControllerBase.ValidateInterval(edtStartDate.DateTime.Date, edtStartTime.Time.TimeOfDay, edtEndDate.DateTime.Date, edtEndTime.Time.TimeOfDay)) Then
            e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_InvalidEndDate)
        Else
            e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_DateOutsideLimitInterval)
        End If
    End Sub
    Protected Friend Overridable Sub OnEdtEndTimeValidating(ByVal sender As Object, ByVal e As CancelEventArgs)
        e.Cancel = Not IsValidInterval()
        If (Not e.Cancel) Then
            Me.edtEndTime.DataBindings("EditValue").WriteValue()
        End If
    End Sub
    Protected Friend Overridable Sub OnEdtEndTimeInvalidValue(ByVal sender As Object, ByVal e As InvalidValueExceptionEventArgs)
        If (Not AppointmentFormControllerBase.ValidateInterval(edtStartDate.DateTime.Date, edtStartTime.Time.TimeOfDay, edtEndDate.DateTime.Date, edtEndTime.Time.TimeOfDay)) Then
            e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_InvalidEndDate)
        Else
            e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_DateOutsideLimitInterval)
        End If
    End Sub
    Protected Friend Overridable Function IsValidInterval() As Boolean
        Return AppointmentFormControllerBase.ValidateInterval(edtStartDate.DateTime.Date, edtStartTime.Time.TimeOfDay, edtEndDate.DateTime.Date, edtEndTime.Time.TimeOfDay) AndAlso Controller.ValidateLimitInterval(edtStartDate.DateTime.Date, edtStartTime.Time.TimeOfDay, edtEndDate.DateTime.Date, edtEndTime.Time.TimeOfDay)
    End Function
    Protected Friend Overridable Sub OnOkButton()
        Save(True)
    End Sub
    Protected Overridable Sub OnSaveButton()
        Save(False)
    End Sub
    Private Sub Save(ByVal closeAfterSave As Boolean)
        If (Not ValidateDateAndTime()) Then
            Return
        End If
        If (Not SaveFormData(Controller.EditedAppointmentCopy)) Then
            Return
        End If
        If (Not Controller.IsConflictResolved()) Then
            ShowMessageBox(SchedulerLocalizer.GetString(SchedulerStringId.Msg_Conflict), Controller.GetMessageBoxCaption(SchedulerStringId.Msg_Conflict), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        If IsAppointmentChanged(Controller.EditedAppointmentCopy) OrElse Controller.IsAppointmentChanged() OrElse Controller.IsNewAppointment Then
            Controller.ApplyChanges()
        End If
        If closeAfterSave Then
            Me.m_supressCancelCore = True
            DialogResult = System.Windows.Forms.DialogResult.OK
        End If
    End Sub
    Private Function ValidateDateAndTime() As Boolean
        Me.edtEndDate.DoValidate()
        Me.edtEndTime.DoValidate()
        Me.edtStartDate.DoValidate()
        Me.edtStartTime.DoValidate()

        Return String.IsNullOrEmpty(Me.edtEndTime.ErrorText) AndAlso String.IsNullOrEmpty(Me.edtEndDate.ErrorText) AndAlso String.IsNullOrEmpty(Me.edtStartDate.ErrorText) AndAlso String.IsNullOrEmpty(Me.edtStartTime.ErrorText)
    End Function
    Protected Overridable Sub OnSaveAsButton()
        Dim fileDialog As New SaveFileDialog()
        fileDialog.Filter = "iCalendar files (*.ics)|*.ics"
        fileDialog.FilterIndex = 1
        If fileDialog.ShowDialog() <> System.Windows.Forms.DialogResult.OK Then
            Return
        End If
        Try
            Using stream As Stream = fileDialog.OpenFile()
                ExportAppointment(stream)
            End Using
        Catch
            ShowMessageBox("Error: could not export appointments", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ExportAppointment(ByVal stream As Stream)
        If stream Is Nothing Then
            Return
        End If

        Dim aptsToExport As New AppointmentBaseCollection()
        aptsToExport.Add(Controller.EditedAppointmentCopy)
        Dim exporter As New iCalendarExporter(Me.m_storage, aptsToExport)

        exporter.ProductIdentifier = "-//Developer Express Inc."
        exporter.Export(stream)
    End Sub
    Protected Friend Overridable Function ShowMessageBox(ByVal text As String, ByVal caption As String, ByVal buttons As MessageBoxButtons, ByVal icon As MessageBoxIcon) As DialogResult
        Return XtraMessageBox.Show(Me, text, caption, buttons, icon)
    End Function
    Protected Friend Overridable Sub OnDeleteButton()
        If IsNewAppointment Then
            Return
        End If

        Controller.DeleteAppointment()

        DialogResult = System.Windows.Forms.DialogResult.Abort
        Close()
    End Sub
    Protected Friend Overridable Sub OnRecurrenceButton()
        If (Not Controller.ShouldShowRecurrenceButton) Then
            Return
        End If

        Dim patternCopy As Appointment = Controller.PrepareToRecurrenceEdit()

        Dim result As DialogResult
        Using form As Form = CreateAppointmentRecurrenceForm(patternCopy, Control.OptionsView.FirstDayOfWeek)
            result = ShowRecurrenceForm(form)
        End Using

        If result = System.Windows.Forms.DialogResult.Abort Then
            Controller.RemoveRecurrence()
        ElseIf result = System.Windows.Forms.DialogResult.OK Then
            Controller.ApplyRecurrence(patternCopy)
        End If

        Me.btnRecurrence.Down = Controller.IsRecurrentAppointment
    End Sub
    Protected Overridable Sub OnCloseButton()
        Me.Close()
    End Sub

    Private Function CancelCore() As Boolean
        Dim result As Boolean = True

        If DialogResult <> System.Windows.Forms.DialogResult.Abort AndAlso Controller IsNot Nothing AndAlso Controller.IsAppointmentChanged() AndAlso (Not Me.m_supressCancelCore) Then
            Dim dialogResult As DialogResult = ShowMessageBox(SchedulerLocalizer.GetString(SchedulerStringId.Msg_SaveBeforeClose), Controller.GetMessageBoxCaption(SchedulerStringId.Msg_SaveBeforeClose), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)

            If dialogResult = System.Windows.Forms.DialogResult.Cancel Then
                result = False
            ElseIf dialogResult = System.Windows.Forms.DialogResult.Yes Then
                Save(True)
            End If
        End If

        Return result
    End Function

    Protected Overridable Function ShowRecurrenceForm(ByVal form As Form) As DialogResult
        Return form.ShowDialog(Me)
    End Function
    Protected Friend Overridable Function CreateAppointmentRecurrenceForm(ByVal patternCopy As Appointment, ByVal firstDayOfWeek As DevExpress.XtraScheduler.FirstDayOfWeek) As Form
        Dim form As New AppointmentRecurrenceForm(patternCopy, firstDayOfWeek, Controller)
        form.SetMenuManager(MenuManager)
        form.LookAndFeel.ParentLookAndFeel = LookAndFeel
        form.RightToLeftLayout = RightToLeftLayout
        form.RightToLeft = RightToLeft
        form.ShowExceptionsRemoveMsgBox = m_controller.AreExceptionsPresent()
        Return form
    End Function
    Friend Sub OnAppointmentFormActivated(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Activated
        If m_openRecurrenceForm Then
            m_openRecurrenceForm = False
            OnRecurrenceButton()
        End If
    End Sub
    Protected Friend Overridable Sub OnCbReminderValidating(ByVal sender As Object, ByVal e As CancelEventArgs)
        Dim span As TimeSpan = CType(barReminder.EditValue, TimeSpan)
        e.Cancel = span.Ticks < 0 AndAlso span <> TimeSpan.MinValue
        If (Not e.Cancel) Then
            Me.barReminder.DataBindings("EditValue").WriteValue()
        End If
    End Sub

    Protected Friend Overridable Sub OnNextButton()
        If CancelCore() Then
            Me.m_supressCancelCore = True
            Dim command As New OpenNextAppointmentCommand(Control)
            command.Execute()
            Me.Close()
        End If
    End Sub

    Protected Friend Overridable Sub OnPreviousButton()
        If CancelCore() Then
            Me.m_supressCancelCore = True
            Dim command As New OpenPrevAppointmentCommand(Control)
            command.Execute()
            Me.Close()
        End If
    End Sub

    Protected Friend Overridable Sub OnTimeZonesButton()
        Controller.TimeZoneVisible = Not Controller.TimeZoneVisible
    End Sub

    Protected Overridable Sub OnApplicationButtonClick()
        Me.appointmentBackstageControl.SetPrintDocument(Control.GetPrintPreviewDocument(New RibbonFormPreviewMemoPrintStyle(Controller.EditedAppointmentCopy)))
    End Sub

    Protected Overridable Sub OnPrintButton()
        Using tool As PrintTool = New PrintTool(Me.appointmentBackstageControl.Document)
            tool.Print(Me.appointmentBackstageControl.SelectedPrinterName)
        End Using
    End Sub

    Protected Overridable Sub OnPrintOptionsButton()
        Using tool As PrintTool = New PrintTool(Me.appointmentBackstageControl.Document)
            tool.PrintDialog(FindForm(), LookAndFeel)
        End Using
    End Sub

    Private Sub btnSaveAndClose_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSaveAndClose.ItemClick
        OnOkButton()
    End Sub

    Private Sub barButtonDelete_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick
        OnDeleteButton()
    End Sub

    Private Sub barRecurrence_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btnRecurrence.ItemClick
        OnRecurrenceButton()
    End Sub

    Private Sub bvbSave_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs)
        OnSaveButton()
    End Sub

    Private Sub bvbSaveAs_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs)
        OnSaveAsButton()
    End Sub

    Private Sub bvbClose_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs)
        OnCloseButton()
    End Sub

    Private Sub btnSave_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btnSave.ItemClick
        OnSaveButton()
    End Sub

    Protected Overrides Sub OnClosing(ByVal e As CancelEventArgs)
        e.Cancel = Not CancelCore()
        MyBase.OnClosing(e)
    End Sub

    Private Sub btnNext_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btnNext.ItemClick
        OnNextButton()
    End Sub

    Private Sub btnPrevious_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btnPrevious.ItemClick
        OnPreviousButton()
    End Sub

    Private Sub btnTimeZones_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btnTimeZones.ItemClick
        OnTimeZonesButton()
    End Sub

    Private Sub ribbonControl1_ApplicationButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonControl1.ApplicationButtonClick
        OnApplicationButtonClick()
    End Sub

    Private Sub schedulerPrint_PrintOptionsClick(ByVal sender As Object, ByVal e As System.EventArgs)
        OnPrintOptionsButton()
    End Sub

    Private Sub schedulerPrint_PrintClick(ByVal sender As Object, ByVal e As System.EventArgs)
        OnPrintButton()
    End Sub

    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Me.components IsNot Nothing Then
                Me.components.Dispose()
            End If
            If LookAndFeel IsNot Nothing Then
                LookAndFeel.ParentLookAndFeel = Nothing
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    Private Sub ucTipos_Consulta_AfterCloseUp(sender As Object, e As EventArgs) Handles ucTipos_Consulta.AfterCloseUp, ucTipos_Consulta.Leave
        Dim mIndex As Integer = 0

        If ucTipos_Consulta.ActiveRow IsNot Nothing Then
            mIndex = ucTipos_Consulta.ActiveRow.Index

        End If

        mClsConsulta.Cod_Tipo_Consulta = mLista_Tipos_Consulta(mIndex).Cod_Tipo_Consulta

        Me.ucAnimais.Focus()

    End Sub

    Private Sub ucAnimais_AfterCloseUp(sender As Object, e As EventArgs) Handles ucAnimais.AfterCloseUp, ucAnimais.Leave
        Dim mIndex As Integer = 0

        If ucAnimais.ActiveRow IsNot Nothing Then
            mIndex = ucAnimais.ActiveRow.Index

        End If

        mClsConsulta.Cod_Animal = mLista_Animais(mIndex).Cod_Animal
        mClsConsulta.Cod_Entidade = mLista_Animais(mIndex).Cod_Entidade
        mClsConsulta.Cod_Tipo_Animal = mLista_Animais(mIndex).Cod_Tipo_Animal


        Me.ucMedicos.Focus()
    End Sub

    Private Sub ucMedicos_AfterCloseUp(sender As Object, e As EventArgs) Handles ucMedicos.AfterCloseUp, ucMedicos.Leave
        Dim mIndex As Integer = 0

        If ucMedicos.ActiveRow IsNot Nothing Then
            mIndex = ucMedicos.ActiveRow.Index

        End If

        mClsConsulta.Cod_Veterinario = mLista_Medicos(mIndex).Cod_Entidade

        Me.edtResource.SelectedIndex = mIndex + 1

        Me.ucSalas.Focus()
    End Sub

    Private Sub ucSalas_AfterCloseUp(sender As Object, e As EventArgs) Handles ucSalas.AfterCloseUp, ucSalas.Leave
        Dim mIndex As Integer = 0

        If ucSalas.ActiveRow IsNot Nothing Then
            mIndex = ucSalas.ActiveRow.Index

        End If

        mClsConsulta.Cod_Sala = mLista_Salas(mIndex).Cod_Sala

        Display_TBS()

    End Sub

    Private Sub cmdFatura_Click(sender As Object, e As EventArgs) Handles cmdFatura.Click

        Dim mUDoc As UserControl

        ucFaturacao.FLG_Consulta = True
        ucFaturacao.cCod_Cliente = mCod_Entidade
        ucFaturacao.cCod_Artigo = "S" & mCod_Tipo_Consulta.Substring(2, 3)


        mUDoc = New ucFaturacao

        mUDoc.Dock = DockStyle.Fill
        mUDoc.Parent = frmMain.pnMain

        Me.Close()


    End Sub
End Class