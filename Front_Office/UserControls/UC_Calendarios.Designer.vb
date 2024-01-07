<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_Calendarios
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
        Dim TimeRuler1 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
        Dim TimeRuler2 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
        Dim TimeRuler3 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SCAgendas = New DevExpress.XtraScheduler.SchedulerControl()
        Me.SchedulerDataStorage1 = New DevExpress.XtraScheduler.SchedulerDataStorage(Me.components)
        Me.I2021_G2DataSet = New G02_Gustavo_02.I2021_G2DataSet()
        Me.AppointmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AppointmentsTableAdapter = New G02_Gustavo_02.I2021_G2DataSetTableAdapters.AppointmentsTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.SCAgendas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchedulerDataStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.I2021_G2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppointmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SCAgendas)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(984, 611)
        Me.Panel1.TabIndex = 4
        '
        'SCAgendas
        '
        Me.SCAgendas.DataStorage = Me.SchedulerDataStorage1
        Me.SCAgendas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SCAgendas.Location = New System.Drawing.Point(0, 0)
        Me.SCAgendas.Name = "SCAgendas"
        Me.SCAgendas.Size = New System.Drawing.Size(984, 611)
        Me.SCAgendas.Start = New Date(2022, 12, 2, 0, 0, 0, 0)
        Me.SCAgendas.TabIndex = 0
        Me.SCAgendas.Text = "SchedulerControl1"
        Me.SCAgendas.Views.DayView.TimeRulers.Add(TimeRuler1)
        Me.SCAgendas.Views.FullWeekView.Enabled = True
        Me.SCAgendas.Views.FullWeekView.TimeRulers.Add(TimeRuler2)
        Me.SCAgendas.Views.GanttView.Enabled = False
        Me.SCAgendas.Views.TimelineView.Enabled = False
        Me.SCAgendas.Views.WeekView.Enabled = False
        Me.SCAgendas.Views.WorkWeekView.TimeRulers.Add(TimeRuler3)
        Me.SCAgendas.Views.YearView.UseOptimizedScrolling = False
        '
        'SchedulerDataStorage1
        '
        '
        '
        '
        Me.SchedulerDataStorage1.AppointmentDependencies.AutoReload = False
        '
        '
        '
        Me.SchedulerDataStorage1.Appointments.DataSource = Me.AppointmentsBindingSource
        Me.SchedulerDataStorage1.Appointments.Labels.CreateNewLabel(0, "None", "&None", System.Drawing.SystemColors.Window)
        Me.SchedulerDataStorage1.Appointments.Labels.CreateNewLabel(1, "Important", "&Important", System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(190, Byte), Integer)))
        Me.SchedulerDataStorage1.Appointments.Labels.CreateNewLabel(2, "Business", "&Business", System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(255, Byte), Integer)))
        Me.SchedulerDataStorage1.Appointments.Labels.CreateNewLabel(3, "Personal", "&Personal", System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(156, Byte), Integer)))
        Me.SchedulerDataStorage1.Appointments.Labels.CreateNewLabel(4, "Vacation", "&Vacation", System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(199, Byte), Integer)))
        Me.SchedulerDataStorage1.Appointments.Labels.CreateNewLabel(5, "Must Attend", "Must &Attend", System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(147, Byte), Integer)))
        Me.SchedulerDataStorage1.Appointments.Labels.CreateNewLabel(6, "Travel Required", "&Travel Required", System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(255, Byte), Integer)))
        Me.SchedulerDataStorage1.Appointments.Labels.CreateNewLabel(7, "Needs Preparation", "&Needs Preparation", System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(152, Byte), Integer)))
        Me.SchedulerDataStorage1.Appointments.Labels.CreateNewLabel(8, "Birthday", "&Birthday", System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(233, Byte), Integer)))
        Me.SchedulerDataStorage1.Appointments.Labels.CreateNewLabel(9, "Anniversary", "&Anniversary", System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(223, Byte), Integer)))
        Me.SchedulerDataStorage1.Appointments.Labels.CreateNewLabel(10, "Phone Call", "Phone &Call", System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(165, Byte), Integer)))
        Me.SchedulerDataStorage1.Appointments.Mappings.AllDay = "AllDay"
        Me.SchedulerDataStorage1.Appointments.Mappings.Description = "Description"
        Me.SchedulerDataStorage1.Appointments.Mappings.End = "EndDate"
        Me.SchedulerDataStorage1.Appointments.Mappings.Label = "Label"
        Me.SchedulerDataStorage1.Appointments.Mappings.Location = "Location"
        Me.SchedulerDataStorage1.Appointments.Mappings.OriginalOccurrenceEnd = "QueryEndDate"
        Me.SchedulerDataStorage1.Appointments.Mappings.OriginalOccurrenceStart = "QueryStartDate"
        Me.SchedulerDataStorage1.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo"
        Me.SchedulerDataStorage1.Appointments.Mappings.ReminderInfo = "ReminderInfo"
        Me.SchedulerDataStorage1.Appointments.Mappings.ResourceId = "ResourceID"
        Me.SchedulerDataStorage1.Appointments.Mappings.Start = "StartDate"
        Me.SchedulerDataStorage1.Appointments.Mappings.Status = "Status"
        Me.SchedulerDataStorage1.Appointments.Mappings.Subject = "Subject"
        Me.SchedulerDataStorage1.Appointments.Mappings.TimeZoneId = "TimeZoneId"
        Me.SchedulerDataStorage1.Appointments.Mappings.Type = "Type"
        '
        'I2021_G2DataSet
        '
        Me.I2021_G2DataSet.DataSetName = "I2021_G2DataSet"
        Me.I2021_G2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AppointmentsBindingSource
        '
        Me.AppointmentsBindingSource.DataMember = "Appointments"
        Me.AppointmentsBindingSource.DataSource = Me.I2021_G2DataSet
        '
        'AppointmentsTableAdapter
        '
        Me.AppointmentsTableAdapter.ClearBeforeFill = True
        '
        'UC_Calendarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UC_Calendarios"
        Me.Size = New System.Drawing.Size(984, 611)
        Me.Panel1.ResumeLayout(False)
        CType(Me.SCAgendas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchedulerDataStorage1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.I2021_G2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppointmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SCAgendas As DevExpress.XtraScheduler.SchedulerControl
    Friend WithEvents SchedulerDataStorage1 As DevExpress.XtraScheduler.SchedulerDataStorage
    Friend WithEvents AppointmentsBindingSource As BindingSource
    Friend WithEvents I2021_G2DataSet As I2021_G2DataSet
    Friend WithEvents AppointmentsTableAdapter As I2021_G2DataSetTableAdapters.AppointmentsTableAdapter
End Class
