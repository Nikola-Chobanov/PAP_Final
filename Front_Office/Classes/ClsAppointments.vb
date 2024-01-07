
Imports System.Data.SqlClient


''' <summary>
'''      Classe ClsAppointments Classe da Tabela Appointments
'''      Gerado em 21/03/2023 16:57:53
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2023
''' </remarks>
Public Class ClsAppointments


    ' -----------------------------------------
    ' Property's da tabela Appointments
    ' -----------------------------------------

    Public Property UniqueID As Integer                                     ' SQL_Type: int
    Public Property Type As Integer                                         ' SQL_Type: int
    Public Property StartDate As Date                                       ' SQL_Type: datetime
    Public Property EndDate As Date                                         ' SQL_Type: datetime
    Public Property QueryStartDate As Date                                  ' SQL_Type: datetime
    Public Property QueryEndDate As Date                                    ' SQL_Type: datetime
    Public Property AllDay As Boolean                                       ' SQL_Type: bit
    Public Property Subject As String                                       ' Len: 50 - SQL_Type: nvarchar
    Public Property Location As String                                      ' Len: 50 - SQL_Type: nvarchar
    Public Property Description As String                                   ' Len: -1 - SQL_Type: nvarchar
    Public Property Status As Integer                                       ' SQL_Type: int
    Public Property Label As Integer                                         ' SQL_Type: int
    Public Property ResourceID As Integer                                   ' SQL_Type: int
    Public Property ResourceIDs As String                                   ' Len: -1 - SQL_Type: nvarchar
    Public Property ReminderInfo As String                                  ' Len: -1 - SQL_Type: nvarchar
    Public Property RecurrenceInfo As String                                ' Len: -1 - SQL_Type: nvarchar
    Public Property TimeZoneId As String                                    ' Len: -1 - SQL_Type: nvarchar
    Public Property CustomField1 As String                                  ' Len: -1 - SQL_Type: nvarchar - Cod_Consulta
    Public Property CustomField2 As String                                  ' Len: -1 - SQL_Type: nvarchar - Cod_Animal
    Public Property CustomField3 As String                                  ' Len: -1 - SQL_Type: nvarchar - Cod_Sala


    Sub New()
    End Sub


    '--------------------------------------------
    ' Exemplo de criador de Código por contador
    ' Para ser usado no caso de o Cdigo ser gerado
    ' e o contador existir na tabela Empresas
    '---------------------------------------------

    'Friend Shared Function GetNovoCodigo() As String

    'Return "A" & ClsEmpresas.GetContador(enCont.Appointments).ToString("000")' <-------------- VERIFICAR O Nº de ZEROS

    'End Function


    ''' <summary>
    '''      Function GetAppointments() Método para devolver a Lista de Appointments
    '''      Gerado em 21/03/2023 16:57:53
    ''' </summary>
    ''' <returns>
    '''      mListaAppointments
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function GetAppointments() As List(Of ClsAppointments)
        Dim mListaAppointments As New List(Of ClsAppointments)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(UniqueID,0) As UniqueID,"
        mStrSQL += "ISNULL(Type,0) As Type,"
        mStrSQL += "ISNULL(StartDate,0) As StartDate,"
        mStrSQL += "ISNULL(EndDate,0) As EndDate,"
        mStrSQL += "ISNULL(QueryStartDate,0) As QueryStartDate,"
        mStrSQL += "ISNULL(QueryEndDate,0) As QueryEndDate,"
        mStrSQL += "ISNULL(AllDay,1) As AllDay,"
        mStrSQL += "ISNULL(Subject,'') As Subject,"
        mStrSQL += "ISNULL(Location,'') As Location,"
        mStrSQL += "ISNULL(Description,'') As Description,"
        mStrSQL += "ISNULL(Status,0) As Status,"
        mStrSQL += "ISNULL(Label,0) As Label,"
        mStrSQL += "ISNULL(ResourceID,0) As ResourceID,"
        mStrSQL += "ISNULL(ResourceIDs,'') As ResourceIDs,"
        mStrSQL += "ISNULL(ReminderInfo,'') As ReminderInfo,"
        mStrSQL += "ISNULL(RecurrenceInfo,'') As RecurrenceInfo,"
        mStrSQL += "ISNULL(TimeZoneId,'') As TimeZoneId,"
        mStrSQL += "ISNULL(CustomField1,'') As CustomField1,"
        mStrSQL += "ISNULL(CustomField2,'') As CustomField2,"
        mStrSQL += "ISNULL(CustomField3,'') As CustomField3 "
        mStrSQL += "FROM Appointments "
        ' mStrSQL += "WHERE FLG_Ativo=1"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsAppointments As New ClsAppointments

            With mClsAppointments
                .UniqueID = mRDR.GetValue(mRDR.GetOrdinal("UniqueID"))
                .Type = mRDR.GetValue(mRDR.GetOrdinal("Type"))
                .StartDate = mRDR.GetDateTime(mRDR.GetOrdinal("StartDate"))
                .EndDate = mRDR.GetDateTime(mRDR.GetOrdinal("EndDate"))
                .QueryStartDate = mRDR.GetDateTime(mRDR.GetOrdinal("QueryStartDate"))
                .QueryEndDate = mRDR.GetDateTime(mRDR.GetOrdinal("QueryEndDate"))
                .AllDay = mRDR.GetBoolean(mRDR.GetOrdinal("AllDay"))
                .Subject = mRDR.GetString(mRDR.GetOrdinal("Subject"))
                .Location = mRDR.GetString(mRDR.GetOrdinal("Location"))
                .Description = mRDR.GetString(mRDR.GetOrdinal("Description"))
                .Status = mRDR.GetValue(mRDR.GetOrdinal("Status"))
                .Label = mRDR.GetValue(mRDR.GetOrdinal("Label"))
                .ResourceID = mRDR.GetValue(mRDR.GetOrdinal("ResourceID"))
                .ResourceIDs = mRDR.GetString(mRDR.GetOrdinal("ResourceIDs"))
                .ReminderInfo = mRDR.GetString(mRDR.GetOrdinal("ReminderInfo"))
                .RecurrenceInfo = mRDR.GetString(mRDR.GetOrdinal("RecurrenceInfo"))
                .TimeZoneId = mRDR.GetString(mRDR.GetOrdinal("TimeZoneId"))
                .CustomField1 = mRDR.GetString(mRDR.GetOrdinal("CustomField1"))
                .CustomField2 = mRDR.GetString(mRDR.GetOrdinal("CustomField2"))
                .CustomField3 = mRDR.GetString(mRDR.GetOrdinal("CustomField3"))
            End With


            mListaAppointments.Add(mClsAppointments)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaAppointments
    End Function
    Public Shared Function GetAppointmentsByCod_Consulta(ByVal pCod_Consulta As String) As ClsAppointments
        Dim mClsAppointments As New ClsAppointments

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Consulta", pCod_Consulta)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(UniqueID,0) As UniqueID,"
        mStrSQL += "ISNULL(Type,0) As Type,"
        mStrSQL += "ISNULL(StartDate,0) As StartDate,"
        mStrSQL += "ISNULL(EndDate,0) As EndDate,"
        mStrSQL += "ISNULL(QueryStartDate,0) As QueryStartDate,"
        mStrSQL += "ISNULL(QueryEndDate,0) As QueryEndDate,"
        mStrSQL += "ISNULL(AllDay,1) As AllDay,"
        mStrSQL += "ISNULL(Subject,'') As Subject,"
        mStrSQL += "ISNULL(Location,'') As Location,"
        mStrSQL += "ISNULL(Description,'') As Description,"
        mStrSQL += "ISNULL(Status,0) As Status,"
        mStrSQL += "ISNULL(Label,0) As Label,"
        mStrSQL += "ISNULL(ResourceID,0) As ResourceID,"
        mStrSQL += "ISNULL(ResourceIDs,'') As ResourceIDs,"
        mStrSQL += "ISNULL(ReminderInfo,'') As ReminderInfo,"
        mStrSQL += "ISNULL(RecurrenceInfo,'') As RecurrenceInfo,"
        mStrSQL += "ISNULL(TimeZoneId,'') As TimeZoneId,"
        mStrSQL += "ISNULL(CustomField1,'') As CustomField1,"
        mStrSQL += "ISNULL(CustomField2,'') As CustomField2,"
        mStrSQL += "ISNULL(CustomField3,'') As CustomField3 "
        mStrSQL += "FROM Appointments "
        mStrSQL += "WHERE "
        mStrSQL += "CustomField1=@pCod_Consulta"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsAppointments
                .UniqueID = mRDR.GetValue(mRDR.GetOrdinal("UniqueID"))
                .Type = mRDR.GetValue(mRDR.GetOrdinal("Type"))
                .StartDate = mRDR.GetDateTime(mRDR.GetOrdinal("StartDate"))
                .EndDate = mRDR.GetDateTime(mRDR.GetOrdinal("EndDate"))
                .QueryStartDate = mRDR.GetDateTime(mRDR.GetOrdinal("QueryStartDate"))
                .QueryEndDate = mRDR.GetDateTime(mRDR.GetOrdinal("QueryEndDate"))
                .AllDay = mRDR.GetBoolean(mRDR.GetOrdinal("AllDay"))
                .Subject = mRDR.GetString(mRDR.GetOrdinal("Subject"))
                .Location = mRDR.GetString(mRDR.GetOrdinal("Location"))
                .Description = mRDR.GetString(mRDR.GetOrdinal("Description"))
                .Status = mRDR.GetValue(mRDR.GetOrdinal("Status"))
                .Label = mRDR.GetValue(mRDR.GetOrdinal("Label"))
                .ResourceID = mRDR.GetValue(mRDR.GetOrdinal("ResourceID"))
                .ResourceIDs = mRDR.GetString(mRDR.GetOrdinal("ResourceIDs"))
                .ReminderInfo = mRDR.GetString(mRDR.GetOrdinal("ReminderInfo"))
                .RecurrenceInfo = mRDR.GetString(mRDR.GetOrdinal("RecurrenceInfo"))
                .TimeZoneId = mRDR.GetString(mRDR.GetOrdinal("TimeZoneId"))
                .CustomField1 = mRDR.GetString(mRDR.GetOrdinal("CustomField1"))
                .CustomField2 = mRDR.GetString(mRDR.GetOrdinal("CustomField2"))
                .CustomField3 = mRDR.GetString(mRDR.GetOrdinal("CustomField3"))
            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mClsAppointments
    End Function

    ''' <summary>
    '''      Function GetAppointmentsByCod(ByVal pUniqueID As Integer) Método para decolver uma Classe de Appointments
    '''      Gerado em 21/03/2023 16:57:53
    ''' </summary>
    ''' <returns>
    '''      mClsAppointments
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function GetAppointmentsByCod(ByVal pUniqueID As Integer) As ClsAppointments
        Dim mClsAppointments As New ClsAppointments

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pUniqueID", pUniqueID)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(UniqueID,0) As UniqueID,"
        mStrSQL += "ISNULL(Type,0) As Type,"
        mStrSQL += "ISNULL(StartDate,0) As StartDate,"
        mStrSQL += "ISNULL(EndDate,0) As EndDate,"
        mStrSQL += "ISNULL(QueryStartDate,0) As QueryStartDate,"
        mStrSQL += "ISNULL(QueryEndDate,0) As QueryEndDate,"
        mStrSQL += "ISNULL(AllDay,1) As AllDay,"
        mStrSQL += "ISNULL(Subject,'') As Subject,"
        mStrSQL += "ISNULL(Location,'') As Location,"
        mStrSQL += "ISNULL(Description,'') As Description,"
        mStrSQL += "ISNULL(Status,0) As Status,"
        mStrSQL += "ISNULL(Label,0) As Label,"
        mStrSQL += "ISNULL(ResourceID,0) As ResourceID,"
        mStrSQL += "ISNULL(ResourceIDs,'') As ResourceIDs,"
        mStrSQL += "ISNULL(ReminderInfo,'') As ReminderInfo,"
        mStrSQL += "ISNULL(RecurrenceInfo,'') As RecurrenceInfo,"
        mStrSQL += "ISNULL(TimeZoneId,'') As TimeZoneId,"
        mStrSQL += "ISNULL(CustomField1,'') As CustomField1,"
        mStrSQL += "ISNULL(CustomField2,'') As CustomField2,"
        mStrSQL += "ISNULL(CustomField3,'') As CustomField3 "
        mStrSQL += "FROM Appointments "
        mStrSQL += "WHERE "
        mStrSQL += "UniqueID=@pUniqueID"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsAppointments
                .UniqueID = mRDR.GetValue(mRDR.GetOrdinal("UniqueID"))
                .Type = mRDR.GetValue(mRDR.GetOrdinal("Type"))
                .StartDate = mRDR.GetDateTime(mRDR.GetOrdinal("StartDate"))
                .EndDate = mRDR.GetDateTime(mRDR.GetOrdinal("EndDate"))
                .QueryStartDate = mRDR.GetDateTime(mRDR.GetOrdinal("QueryStartDate"))
                .QueryEndDate = mRDR.GetDateTime(mRDR.GetOrdinal("QueryEndDate"))
                .AllDay = mRDR.GetBoolean(mRDR.GetOrdinal("AllDay"))
                .Subject = mRDR.GetString(mRDR.GetOrdinal("Subject"))
                .Location = mRDR.GetString(mRDR.GetOrdinal("Location"))
                .Description = mRDR.GetString(mRDR.GetOrdinal("Description"))
                .Status = mRDR.GetValue(mRDR.GetOrdinal("Status"))
                .Label = mRDR.GetValue(mRDR.GetOrdinal("Label"))
                .ResourceID = mRDR.GetValue(mRDR.GetOrdinal("ResourceID"))
                .ResourceIDs = mRDR.GetString(mRDR.GetOrdinal("ResourceIDs"))
                .ReminderInfo = mRDR.GetString(mRDR.GetOrdinal("ReminderInfo"))
                .RecurrenceInfo = mRDR.GetString(mRDR.GetOrdinal("RecurrenceInfo"))
                .TimeZoneId = mRDR.GetString(mRDR.GetOrdinal("TimeZoneId"))
                .CustomField1 = mRDR.GetString(mRDR.GetOrdinal("CustomField1"))
                .CustomField2 = mRDR.GetString(mRDR.GetOrdinal("CustomField2"))
                .CustomField3 = mRDR.GetString(mRDR.GetOrdinal("CustomField3"))
            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mClsAppointments
    End Function


    ''' <summary>
    '''      Function ModificaAppointments(ByVal pClsAppointments As ClsAppointments) Método para Modificar a TABELA Appointments
    '''      Gerado em 21/03/2023 16:57:53
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function ModificaAppointments(ByVal pClsAppointments As ClsAppointments) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pUniqueID", pClsAppointments.UniqueID)
        mCMD.Parameters.AddWithValue("@pType", pClsAppointments.Type)
        mCMD.Parameters.AddWithValue("@pStartDate", pClsAppointments.StartDate)
        mCMD.Parameters.AddWithValue("@pEndDate", pClsAppointments.EndDate)
        mCMD.Parameters.AddWithValue("@pQueryStartDate", pClsAppointments.QueryStartDate)
        mCMD.Parameters.AddWithValue("@pQueryEndDate", pClsAppointments.QueryEndDate)
        mCMD.Parameters.AddWithValue("@pAllDay", pClsAppointments.AllDay)
        mCMD.Parameters.AddWithValue("@pSubject", pClsAppointments.Subject.Substring(0, IIf(Len(pClsAppointments.Subject) > 50, 50, Len(pClsAppointments.Subject))))
        mCMD.Parameters.AddWithValue("@pLocation", pClsAppointments.Location.Substring(0, IIf(Len(pClsAppointments.Location) > 50, 50, Len(pClsAppointments.Location))))
        mCMD.Parameters.AddWithValue("@pDescription", pClsAppointments.Description.Substring(0, IIf(Len(pClsAppointments.Description) > -1, -1, Len(pClsAppointments.Description))))
        mCMD.Parameters.AddWithValue("@pStatus", pClsAppointments.Status)
        mCMD.Parameters.AddWithValue("@pLabel", pClsAppointments.Label)
        mCMD.Parameters.AddWithValue("@pResourceID", pClsAppointments.ResourceID)
        mCMD.Parameters.AddWithValue("@pResourceIDs", pClsAppointments.ResourceIDs.Substring(0, IIf(Len(pClsAppointments.ResourceIDs) > -1, -1, Len(pClsAppointments.ResourceIDs))))
        mCMD.Parameters.AddWithValue("@pReminderInfo", pClsAppointments.ReminderInfo.Substring(0, IIf(Len(pClsAppointments.ReminderInfo) > -1, -1, Len(pClsAppointments.ReminderInfo))))
        mCMD.Parameters.AddWithValue("@pRecurrenceInfo", pClsAppointments.RecurrenceInfo.Substring(0, IIf(Len(pClsAppointments.RecurrenceInfo) > -1, -1, Len(pClsAppointments.RecurrenceInfo))))
        mCMD.Parameters.AddWithValue("@pTimeZoneId", pClsAppointments.TimeZoneId.Substring(0, IIf(Len(pClsAppointments.TimeZoneId) > -1, -1, Len(pClsAppointments.TimeZoneId))))
        mCMD.Parameters.AddWithValue("@pCustomField1", pClsAppointments.CustomField1.Substring(0, IIf(Len(pClsAppointments.CustomField1) > -1, -1, Len(pClsAppointments.CustomField1))))
        mCMD.Parameters.AddWithValue("@pCustomField2", pClsAppointments.CustomField2.Substring(0, IIf(Len(pClsAppointments.CustomField2) > -1, -1, Len(pClsAppointments.CustomField2))))


        mStrSQL = "UPDATE Appointments SET "
        mStrSQL += "Type=@pType,"
        mStrSQL += "StartDate=@pStartDate,"
        mStrSQL += "EndDate=@pEndDate,"
        mStrSQL += "QueryStartDate=@pQueryStartDate,"
        mStrSQL += "QueryEndDate=@pQueryEndDate,"
        mStrSQL += "AllDay=@pAllDay,"
        mStrSQL += "Subject=@pSubject,"
        mStrSQL += "Location=@pLocation,"
        mStrSQL += "Description=@pDescription,"
        mStrSQL += "Status=@pStatus,"
        mStrSQL += "Label=@pLabel,"
        mStrSQL += "ResourceID=@pResourceID,"
        mStrSQL += "ResourceIDs=@pResourceIDs,"
        mStrSQL += "ReminderInfo=@pReminderInfo,"
        mStrSQL += "RecurrenceInfo=@pRecurrenceInfo,"
        mStrSQL += "TimeZoneId=@pTimeZoneId,"
        mStrSQL += "CustomField1=@pCustomField1,"
        mStrSQL += "CustomField2=@pCustomField2 "
        mStrSQL += "WHERE UniqueID=@pUniqueID"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ModificaAppointments:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function GravaAppointments(ByVal pNovoAppointments As ClsAppointments) Método para Gravar a TABELA Appointments
    '''      Gerado em 21/03/2023 16:57:53
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function GravaAppointments(ByVal pNovoAppointments As ClsAppointments) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()


        mCMD.Parameters.AddWithValue("@pUniqueID", pNovoAppointments.UniqueID)
        mCMD.Parameters.AddWithValue("@pType", pNovoAppointments.Type)
        mCMD.Parameters.AddWithValue("@pStartDate", pNovoAppointments.StartDate)
        mCMD.Parameters.AddWithValue("@pEndDate", pNovoAppointments.EndDate)
        mCMD.Parameters.AddWithValue("@pQueryStartDate", pNovoAppointments.QueryStartDate)
        mCMD.Parameters.AddWithValue("@pQueryEndDate", pNovoAppointments.QueryEndDate)
        mCMD.Parameters.AddWithValue("@pAllDay", pNovoAppointments.AllDay)
        mCMD.Parameters.AddWithValue("@pSubject", pNovoAppointments.Subject.Substring(0, IIf(Len(pNovoAppointments.Subject) > 50, 50, Len(pNovoAppointments.Subject))))
        mCMD.Parameters.AddWithValue("@pLocation", pNovoAppointments.Location.Substring(0, IIf(Len(pNovoAppointments.Location) > 50, 50, Len(pNovoAppointments.Location))))
        mCMD.Parameters.AddWithValue("@pDescription", pNovoAppointments.Description.Substring(0, IIf(Len(pNovoAppointments.Description) > -1, -1, Len(pNovoAppointments.Description))))
        mCMD.Parameters.AddWithValue("@pStatus", pNovoAppointments.Status)
        mCMD.Parameters.AddWithValue("@pLabel", pNovoAppointments.Label)
        mCMD.Parameters.AddWithValue("@pResourceID", pNovoAppointments.ResourceID)
        mCMD.Parameters.AddWithValue("@pResourceIDs", pNovoAppointments.ResourceIDs.Substring(0, IIf(Len(pNovoAppointments.ResourceIDs) > -1, -1, Len(pNovoAppointments.ResourceIDs))))
        mCMD.Parameters.AddWithValue("@pReminderInfo", pNovoAppointments.ReminderInfo.Substring(0, IIf(Len(pNovoAppointments.ReminderInfo) > -1, -1, Len(pNovoAppointments.ReminderInfo))))
        mCMD.Parameters.AddWithValue("@pRecurrenceInfo", pNovoAppointments.RecurrenceInfo.Substring(0, IIf(Len(pNovoAppointments.RecurrenceInfo) > -1, -1, Len(pNovoAppointments.RecurrenceInfo))))
        mCMD.Parameters.AddWithValue("@pTimeZoneId", pNovoAppointments.TimeZoneId.Substring(0, IIf(Len(pNovoAppointments.TimeZoneId) > -1, -1, Len(pNovoAppointments.TimeZoneId))))
        mCMD.Parameters.AddWithValue("@pCustomField1", pNovoAppointments.CustomField1.Substring(0, IIf(Len(pNovoAppointments.CustomField1) > -1, -1, Len(pNovoAppointments.CustomField1))))
        mCMD.Parameters.AddWithValue("@pCustomField2", pNovoAppointments.CustomField2.Substring(0, IIf(Len(pNovoAppointments.CustomField2) > -1, -1, Len(pNovoAppointments.CustomField2))))
        mCMD.Parameters.AddWithValue("@pCustomField3", pNovoAppointments.CustomField3.Substring(0, IIf(Len(pNovoAppointments.CustomField3) > -1, -1, Len(pNovoAppointments.CustomField3))))


        mStrSQL = "INSERT INTO Appointments "
        mStrSQL += "("
        mStrSQL += "UniqueID,"
        mStrSQL += "Type,"
        mStrSQL += "StartDate,"
        mStrSQL += "EndDate,"
        mStrSQL += "QueryStartDate,"
        mStrSQL += "QueryEndDate,"
        mStrSQL += "AllDay,"
        mStrSQL += "Subject,"
        mStrSQL += "Location,"
        mStrSQL += "Description,"
        mStrSQL += "Status,"
        mStrSQL += "Label,"
        mStrSQL += "ResourceID,"
        mStrSQL += "ResourceIDs,"
        mStrSQL += "ReminderInfo,"
        mStrSQL += "RecurrenceInfo,"
        mStrSQL += "TimeZoneId,"
        mStrSQL += "CustomField1,"
        mStrSQL += "CustomField2,"
        mStrSQL += "CustomField3 "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        mStrSQL += "@pUniqueID,"
        mStrSQL += "@pType,"
        mStrSQL += "@pStartDate,"
        mStrSQL += "@pEndDate,"
        mStrSQL += "@pQueryStartDate,"
        mStrSQL += "@pQueryEndDate,"
        mStrSQL += "@pAllDay,"
        mStrSQL += "@pSubject,"
        mStrSQL += "@pLocation,"
        mStrSQL += "@pDescription,"
        mStrSQL += "@pStatus,"
        mStrSQL += "@pLabel,"
        mStrSQL += "@pResourceID,"
        mStrSQL += "@pResourceIDs,"
        mStrSQL += "@pReminderInfo,"
        mStrSQL += "@pRecurrenceInfo,"
        mStrSQL += "@pTimeZoneId,"
        mStrSQL += "@pCustomField1,"
        mStrSQL += "@pCustomField2,"
        mStrSQL += "@pCustomField3 "
        mStrSQL += ")"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
            'ClsEmpresas.GravaContador(enCont.Appointments)'<<<<-------- Verificar se é  preciso...
        Catch ex As Exception
            MsgBox("GravaAppointments:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function ApagaAppointments(ByVal pUniqueID As Integer) Método para Apagar um Registo da Tabela Appointments
    '''      Gerado em 21/03/2023 16:57:53
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function ApagaAppointments(ByVal pUniqueID As Integer) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pUniqueID", pUniqueID)


        mStrSQL = "UPDATE Appointments SET "
        mStrSQL += "FLG_Ativo=0 "
        mStrSQL += "WHERE UniqueID=@pUniqueID"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ApagaAppointments:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function
End Class

