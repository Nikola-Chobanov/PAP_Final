Imports DevExpress
Imports DevExpress.Schedule
Imports DevExpress.XtraBars
Imports DevExpress.XtraDiagram.Options
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Drawing
Imports DevExpress.XtraScheduler.Reporting
Imports System.Drawing.Drawing2D
Imports System.Math


Public Class frmApp
    Dim mCod_Consulta_Mudado As String = String.Empty

    Private Sub frmApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'I2021_G2DataSet.Statuses' table. You can move, or remove it, as needed.
        Me.StatusesTableAdapter.Fill(Me.I2021_G2DataSet.Statuses)
        'TODO: This line of code loads data into the 'I2021_G2DataSet.Labels' table. You can move, or remove it, as needed.
        Me.LabelsTableAdapter.Fill(Me.I2021_G2DataSet.Labels)

        'Get_Labels_Status(Me.SchedulerControl1)

        'TODO: This line of code loads data into the 'I2021_G2DataSet.Resources' table. You can move, or remove it, as needed.
        Me.ResourcesTableAdapter.Fill(Me.I2021_G2DataSet.Resources)
        'TODO: This line of code loads data into the 'I2021_G2DataSet.Appointments' table. You can move, or remove it, as needed.
        Me.AppointmentsTableAdapter.Fill(Me.I2021_G2DataSet.Appointments)





        Dim mDia As Date = Date.Now
        Dim mDiaS As Integer = mDia.DayOfWeek
        mDia = mDia.AddDays(mDiaS - 1)

        With Me.SchedulerControl1
            .WorkWeekView.ShowWorkTimeOnly = True
            .Start = Date.Now

        End With

        Dim mAno As String = Year(Date.Now).ToString
        Gera_Holidays(mAno)

        mCod_Consulta_Mudado = String.Empty


    End Sub

    'Sub Get_Labels_Status(ByVal scheduler As SchedulerControl)

    '    scheduler.Storage.Appointments.Clear()

    '    Dim Labels_STR() As String = {"Agendada", "Anulada", "Efetuada"}
    '    Dim Labels_Color() As Color = {Color.Ivory, Color.Pink, Color.Plum}

    '    Dim Status_STR() As String = {"Não Pago", "Pago"}
    '    Dim Status_Color() As Color = {Color.Green, Color.Red}



    '    Dim labelStorage As IAppointmentLabelStorage = scheduler.Storage.Appointments.Labels
    '    labelStorage.Clear()

    '    Dim count As Integer = Labels_STR.Length
    '    For i As Integer = 0 To count - 1
    '        Dim label As IAppointmentLabel = labelStorage.CreateNewLabel(i, Labels_STR(i))
    '        label.SetColor(Labels_Color(i))
    '        labelStorage.Add(label)
    '    Next i


    '    Dim statusColl As AppointmentStatusCollection = scheduler.Storage.Appointments.Statuses
    '    statusColl.Clear()
    '    count = Status_STR.Length
    '    For i As Integer = 0 To count - 1
    '        Dim status As AppointmentStatus = statusColl.CreateNewStatus(i, Status_STR(i), Status_STR(i))
    '        status.SetBrush(New SolidBrush(Status_Color(i)))
    '        statusColl.Add(status)
    '    Next i
    'End Sub


    Sub Gera_Holidays(ByVal pAno As String)
        Dim mLista_Feriados As New List(Of ClsCalendario_Detalhes)
        mLista_Feriados = ClsCalendario_Detalhes.GetLista_Feriados_By_Ano(pAno)

        ' Dim mListaHolidays As New List(Of Holiday)

        For Each pFeriado As ClsCalendario_Detalhes In mLista_Feriados
            Dim mHol As New Holiday(pFeriado.Dia, pFeriado.Descritivo_Feriado)
            Me.SchedulerControl1.WorkDays.Add(mHol)
            '---------------------------------------------------
            ' Ciar um appointment das 9 às 19 com cor vermelha
            '---------------------------------------------------
        Next

    End Sub


    Private Sub SchedulerControl1_EditAppointmentFormShowing(sender As Object, e As DevExpress.XtraScheduler.AppointmentFormEventArgs) Handles SchedulerControl1.EditAppointmentFormShowing
        Dim scheduler As DevExpress.XtraScheduler.SchedulerControl = CType(sender, DevExpress.XtraScheduler.SchedulerControl)
        Dim form As G02_Gustavo_02.OutlookAppointmentForm = New G02_Gustavo_02.OutlookAppointmentForm(scheduler, e.Appointment, e.OpenRecurrenceForm)
        Try
            e.DialogResult = form.ShowDialog
            e.Handled = True
            If ucFaturacao.FLG_Consulta Then
                Me.Close()
            End If
        Finally
            form.Dispose()
        End Try

    End Sub

    Private Sub SchedulerControl1_CustomDrawResourceHeader(sender As Object, e As CustomDrawObjectEventArgs) Handles SchedulerControl1.CustomDrawResourceHeader
        Dim header As SchedulerHeader = TryCast(e.ObjectInfo, SchedulerHeader)
        If Not header Is Nothing Then

            ' Check whether the current date is a known holiday.
            Dim hol As Holiday = FindHoliday(header.Interval.Start.Date)
            If Not hol Is Nothing Then

                ' Add the holiday name to the day header's caption.
                header.Caption = String.Format("{0} ({1})", hol.DisplayName,
                hol.Date.ToShortDateString())
            End If
        End If
    End Sub
    Private Function FindHoliday(ByVal [date] As DateTime) As Holiday
        For Each item As WorkDay In SchedulerControl1.WorkDays
            If TypeOf item Is Holiday Then
                Dim hol As Holiday = CType(item, Holiday)
                If hol.Date = [date] Then
                    Return hol
                End If
            End If
        Next item
        Return Nothing
    End Function

    Private Sub SchedulerControl1_CustomDrawDayHeader(sender As Object, e As CustomDrawObjectEventArgs) Handles SchedulerControl1.CustomDrawDayHeader
        Dim header As SchedulerHeader = TryCast(e.ObjectInfo, SchedulerHeader)
        If Not header Is Nothing Then

            ' Check whether the current date is a known holiday.
            Dim hol As Holiday = FindHoliday(header.Interval.Start.Date)
            If Not hol Is Nothing Then

                header.Caption = String.Format("{0} ({1})", hol.DisplayName, hol.Date.ToShortDateString())

                Using backBrush = New LinearGradientBrush(e.Bounds, Color.LightBlue, Color.Blue, LinearGradientMode.Vertical)
                    e.Cache.FillRectangle(backBrush, e.Bounds)
                End Using
                Dim innerRect As Rectangle = Rectangle.Inflate(e.Bounds, -2, -2)
                ' Draws the inner rectangle.
                Using backBrush = New LinearGradientBrush(e.Bounds, Color.Blue, Color.LightSkyBlue, LinearGradientMode.Vertical)
                    e.Cache.FillRectangle(backBrush, innerRect)
                End Using
                ' Draws the header's caption.
                e.Cache.DrawString(header.Caption, header.Appearance.HeaderCaption.Font, Brushes.White, innerRect, header.Appearance.HeaderCaption.GetStringFormat())
                e.Handled = True
            End If
        End If
    End Sub

    'Private Sub scheduler_CustomDrawAppointment(ByVal sender As Object, ByVal e As CustomDrawObjectEventArgs) Handles SchedulerControl1.CustomDrawAppointment
    '    Dim appointment As Appointment = TryCast(e.ObjectInfo, Appointment)
    '    If appointment IsNot Nothing Then
    '        ' Acessa a coleção de labels do compromisso
    '        Dim labels As AppointmentLabelCollection = appointment.LabelKey
    '        ' Altera a primeira label
    '        labels(0).DisplayName = "Nova Label 1"
    '        ' Altera a segunda label
    '        labels(1).DisplayName = "Nova Label 2"
    '    End If
    'End Sub



    Private Sub SchedulerDataStorage1_AppointmentsChanged(sender As Object, e As PersistentObjectsEventArgs) Handles SchedulerDataStorage1.AppointmentsChanged

        AppointmentsTableAdapter.Update(I2021_G2DataSet)

        I2021_G2DataSet.AcceptChanges()
        If mCod_Consulta_Mudado IsNot String.Empty Then


            Dim mApp As New ClsAppointments
            mApp = ClsAppointments.GetAppointmentsByCod_Consulta(mCod_Consulta_Mudado)
            Dim mClsConsulta As New ClsConsultas
            mClsConsulta = ClsConsultas.GetConsultasByCod(mCod_Consulta_Mudado)
            With mClsConsulta
                .Dia = ClsUtils.GetDataSH(mApp.StartDate)
                .Hora_Inicio = mApp.StartDate
                .Hora_Fim = mApp.EndDate

            End With
            Dim mSim As Boolean
            mSim = ClsConsultas.ModificaConsultas(mClsConsulta)
            If mSim = False Then
                MsgBox("Não Gravei....")
            End If

        End If
        mCod_Consulta_Mudado = String.Empty

    End Sub
    Private Sub SchedulerDataStorage1_AP_INSERT_DELETEED(sender As Object, e As DevExpress.XtraScheduler.PersistentObjectsEventArgs) Handles SchedulerDataStorage1.AppointmentsInserted, SchedulerDataStorage1.AppointmentsDeleted
        AppointmentsTableAdapter.Update(I2021_G2DataSet)
        I2021_G2DataSet.AcceptChanges()

    End Sub

    Private Sub SchedulerDataStorage1_AppointmentChanging(sender As Object, e As PersistentObjectCancelEventArgs) Handles SchedulerDataStorage1.AppointmentChanging
        Dim advArgs As AdvPersistentObjectCancelEventArgs = CType(e, AdvPersistentObjectCancelEventArgs)

        If advArgs.PropertyName = "Start" Then
            mCod_Consulta_Mudado = advArgs.Object.CustomFields(0).ToString

        End If

    End Sub
End Class