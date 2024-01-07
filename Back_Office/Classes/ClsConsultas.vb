
Imports System.Data.SqlClient

Public Enum enStatus As Integer
    N_Aplicavel
    Pago
    N_Pago
End Enum
''' <summary>
'''      Classe ClsConsultas Classe da Tabela Consultas
'''      Gerado em 03/03/2023 15:49:34
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2023
''' </remarks>
Public Class ClsConsultas


    ' -----------------------------------------
    ' Property's da tabela Consultas
    ' -----------------------------------------

    'Public Property Cod_Consulta As String                                  ' Len:  5 - SQL_Type: nvarchar
    'Public Property Cod_Entidade As String                                  ' Len:  5 - SQL_Type: nvarchar
    'Public ReadOnly Property Nome_Entidade
    '    Get
    '        Return If(Cod_Entidade = "", "", ClsEntidades.GetEntidadesByCod(Cod_Entidade).Nome)
    '    End Get
    'End Property
    'Public Property Cod_Sala As String                                      ' Len:  3 - SQL_Type: nvarchar
    'Public ReadOnly Property Sala
    '    Get
    '        Return If(Cod_Sala = "", "", ClsSalas.GetSalasByCod(Cod_Sala).Sala)
    '    End Get
    'End Property

    'Public Property Cod_Animal As String ' Lenght 5
    'Public ReadOnly Property Nome_Animal As String
    '    Get
    '        Return If(Cod_Animal = "", "", ClsAnimais.GetAnimaisByCod(Cod_Animal).Nome_Animal)
    '    End Get
    'End Property


    'Public Property Cod_Tipo_Consulta As String                             ' Len:  5 - SQL_Type: nvarchar
    'Public ReadOnly Property Tipo_Consulta
    '    Get
    '        Return If(Cod_Tipo_Consulta = "", "", ClsTipos_Consulta.GetTipos_ConsultaByCod(Cod_Tipo_Consulta).Designacao)
    '    End Get
    'End Property
    'Public Property Cod_Tipo_Animal As String                               ' Len:  4 - SQL_Type: nvarchar
    'Public ReadOnly Property Tipo_Animal
    '    Get
    '        Return If(Cod_Tipo_Animal = "", "", ClsTiposAnimais.GetTipos_AnimaisByCod(Cod_Tipo_Animal).Animal)
    '    End Get
    'End Property

    'Public Property Hora_Inicio As Date                                     ' SQL_Type: smalldatetime
    'Public Property Hora_Fim As Date                                        ' SQL_Type: smalldatetime
    'Public Property Status As enStatus                                       ' SQL_Type: smallint
    'Public Property Observacoes As String                                   ' Len:240 - SQL_Type: nvarchar
    'Public Property FLG_Ativo As Boolean                                    ' SQL_Type: bit



    Public Property Cod_Consulta As String            ' Lenght: 5
    Public Property Cod_Entidade As String            ' Lenght: 5
    Public Property Cod_Veterinario As String         ' Lenght: 5
    Public Property Cod_Sala As String                ' Lenght: 3
    Public Property Cod_Animal As String              ' Lenght: 5
    Public Property Cod_Tipo_Consulta As String       ' Lenght: 5
    Public Property Cod_Tipo_Animal As String         ' Lenght: 4
    Public Property Dia As Date                       ' datetime
    Public Property Hora_Inicio As Date               ' datetime
    Public Property Hora_Fim As Date                  ' datetime
    Public Property Status As enStatus                ' int
    Public Property Observacoes As String             ' Lenght: 240
    Public Property FLG_Ativo As Boolean              ' Boolean





    Sub New()
    End Sub


    Friend Shared Function GetNovoCodigo() As String

        Return "CS" & ClsEmpresas.GetContador(enCont.Consultas).ToString("000") ' <-------------- VERIFICAR O Nº de ZEROS

    End Function


    ''' <summary>
    '''      Function GetConsultas() Método para devolver a Lista de Consultas
    '''      Gerado em 03/03/2023 15:49:34
    ''' </summary>
    ''' <returns>
    '''      mListaConsultas
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function GetConsultas() As List(Of ClsConsultas)
        Dim mListaConsultas As New List(Of ClsConsultas)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Consulta,'') As Cod_Consulta,"
        mStrSQL += "ISNULL(Cod_Entidade,'') As Cod_Entidade,"
        mStrSQL += "ISNULL(Cod_Veterinario,'') As Cod_Veterinario,"
        mStrSQL += "ISNULL(Cod_Sala,'') As Cod_Sala,"
        mStrSQL += "ISNULL(Cod_Animal,'') As Cod_Animal,"
        mStrSQL += "ISNULL(Cod_Tipo_Consulta,'') As Cod_Tipo_Consulta,"
        mStrSQL += "ISNULL(Cod_Tipo_Animal,'') As Cod_Tipo_Animal,"
        mStrSQL += "ISNULL(Dia,0) As Dia,"
        mStrSQL += "ISNULL(Hora_Inicio,0) As Hora_Inicio,"
        mStrSQL += "ISNULL(Hora_Fim,0) As Hora_Fim,"
        mStrSQL += "ISNULL(Status,0) As Status,"
        mStrSQL += "ISNULL(Observacoes,'') As Observacoes,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Consultas "
        mStrSQL += "WHERE FLG_Ativo=1"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsConsultas As New ClsConsultas

            With mClsConsultas
                .Cod_Consulta = mRDR.GetString(mRDR.GetOrdinal("Cod_Consulta"))
                .Cod_Entidade = mRDR.GetString(mRDR.GetOrdinal("Cod_Entidade"))
                .Cod_Veterinario = mRDR.GetString(mRDR.GetOrdinal("Cod_Veterinario"))
                .Cod_Sala = mRDR.GetString(mRDR.GetOrdinal("Cod_Sala"))
                .Cod_Animal = mRDR.GetString(mRDR.GetOrdinal("Cod_Animal"))
                .Cod_Tipo_Consulta = mRDR.GetString(mRDR.GetOrdinal("Cod_Tipo_Consulta"))
                .Cod_Tipo_Animal = mRDR.GetString(mRDR.GetOrdinal("Cod_Tipo_Animal"))
                .Dia = mRDR.GetDateTime(mRDR.GetOrdinal("Dia"))
                .Hora_Inicio = mRDR.GetDateTime(mRDR.GetOrdinal("Hora_Inicio"))
                .Hora_Fim = mRDR.GetDateTime(mRDR.GetOrdinal("Hora_Fim"))
                .Status = mRDR.GetValue(mRDR.GetOrdinal("Status"))
                .Observacoes = mRDR.GetString(mRDR.GetOrdinal("Observacoes"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaConsultas.Add(mClsConsultas)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaConsultas
    End Function

    ''' <summary>
    '''      Function FiltrarConsultas Método para Filtrar os campos da lista de Consultas
    '''      Gerado em 03/03/2023 15:49:34
    ''' </summary>
    ''' <returns>
    '''      mListaConsultas
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function FiltrarConsultas(ByVal pFiltro As ClsConsultas) As List(Of ClsConsultas)
        Dim mListaConsultas As New List(Of ClsConsultas)
        Dim mLista As New List(Of ClsConsultas)

        mListaConsultas = GetConsultas()

        mLista = mListaConsultas.FindAll(Function(x) _
x.Cod_Consulta.Contains(pFiltro.Cod_Consulta)
)
        '-----------------------------------------------------
        'Pode Colocar em cima mais colunas como esta abaixo...
        '-----------------------------------------------------
        ' AND x.Cod_Entidade.Contains(pFiltro.Cod_Entidade) 

        Return mLista
    End Function


    ''' <summary>
    '''      Function GetConsultasByCod(ByVal pCod_Consulta As String) Método para decolver uma Classe de Consultas
    '''      Gerado em 03/03/2023 15:49:34
    ''' </summary>
    ''' <returns>
    '''      mClsConsultas
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function GetConsultasByCod(ByVal pCod_Consulta As String) As ClsConsultas
        Dim mClsConsultas As New ClsConsultas

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Consulta", pCod_Consulta)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Consulta,'') As Cod_Consulta,"
        mStrSQL += "ISNULL(Cod_Entidade,'') As Cod_Entidade,"
        mStrSQL += "ISNULL(Cod_Veterinario,'') As Cod_Veterinario,"
        mStrSQL += "ISNULL(Cod_Sala,'') As Cod_Sala,"
        mStrSQL += "ISNULL(Cod_Animal,'') As Cod_Animal,"
        mStrSQL += "ISNULL(Cod_Tipo_Consulta,'') As Cod_Tipo_Consulta,"
        mStrSQL += "ISNULL(Cod_Tipo_Animal,'') As Cod_Tipo_Animal,"
        mStrSQL += "ISNULL(Dia,0) As Dia,"
        mStrSQL += "ISNULL(Hora_Inicio,0) As Hora_Inicio,"
        mStrSQL += "ISNULL(Hora_Fim,0) As Hora_Fim,"
        mStrSQL += "ISNULL(Status,0) As Status,"
        mStrSQL += "ISNULL(Observacoes,'') As Observacoes,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Consultas "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Cod_Consulta=@pCod_Consulta"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsConsultas
                .Cod_Consulta = mRDR.GetString(mRDR.GetOrdinal("Cod_Consulta"))
                .Cod_Entidade = mRDR.GetString(mRDR.GetOrdinal("Cod_Entidade"))
                .Cod_Veterinario = mRDR.GetString(mRDR.GetOrdinal("Cod_Veterinario"))
                .Cod_Sala = mRDR.GetString(mRDR.GetOrdinal("Cod_Sala"))
                .Cod_Animal = mRDR.GetString(mRDR.GetOrdinal("Cod_Animal"))
                .Cod_Tipo_Consulta = mRDR.GetString(mRDR.GetOrdinal("Cod_Tipo_Consulta"))
                .Cod_Tipo_Animal = mRDR.GetString(mRDR.GetOrdinal("Cod_Tipo_Animal"))
                .Dia = mRDR.GetDateTime(mRDR.GetOrdinal("Dia"))
                .Hora_Inicio = mRDR.GetDateTime(mRDR.GetOrdinal("Hora_Inicio"))
                .Hora_Fim = mRDR.GetDateTime(mRDR.GetOrdinal("Hora_Fim"))
                .Status = mRDR.GetValue(mRDR.GetOrdinal("Status"))
                .Observacoes = mRDR.GetString(mRDR.GetOrdinal("Observacoes"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mClsConsultas
    End Function


    ''' <summary>
    '''      Function ModificaConsultas(ByVal pClsConsultas As ClsConsultas) Método para Modificar a TABELA Consultas
    '''      Gerado em 03/03/2023 15:49:34
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function ModificaConsultas(ByVal pClsConsultas As ClsConsultas) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Consulta", pClsConsultas.Cod_Consulta.Substring(0, IIf(Len(pClsConsultas.Cod_Consulta) > 5, 5, Len(pClsConsultas.Cod_Consulta))))
        mCMD.Parameters.AddWithValue("@pCod_Entidade", pClsConsultas.Cod_Entidade.Substring(0, IIf(Len(pClsConsultas.Cod_Entidade) > 5, 5, Len(pClsConsultas.Cod_Entidade))))
        mCMD.Parameters.AddWithValue("@pCod_Veterinario", pClsConsultas.Cod_Veterinario.Substring(0, IIf(Len(pClsConsultas.Cod_Veterinario) > 5, 5, Len(pClsConsultas.Cod_Veterinario))))
        mCMD.Parameters.AddWithValue("@pCod_Sala", pClsConsultas.Cod_Sala.Substring(0, IIf(Len(pClsConsultas.Cod_Sala) > 3, 3, Len(pClsConsultas.Cod_Sala))))
        mCMD.Parameters.AddWithValue("@pCod_Animal", pClsConsultas.Cod_Animal.Substring(0, IIf(Len(pClsConsultas.Cod_Animal) > 5, 5, Len(pClsConsultas.Cod_Animal))))
        mCMD.Parameters.AddWithValue("@pCod_Tipo_Consulta", pClsConsultas.Cod_Tipo_Consulta.Substring(0, IIf(Len(pClsConsultas.Cod_Tipo_Consulta) > 5, 5, Len(pClsConsultas.Cod_Tipo_Consulta))))
        mCMD.Parameters.AddWithValue("@pCod_Tipo_Animal", pClsConsultas.Cod_Tipo_Animal.Substring(0, IIf(Len(pClsConsultas.Cod_Tipo_Animal) > 4, 4, Len(pClsConsultas.Cod_Tipo_Animal))))
        mCMD.Parameters.AddWithValue("@pDia", pClsConsultas.Dia)
        mCMD.Parameters.AddWithValue("@pHora_Inicio", pClsConsultas.Hora_Inicio)
        mCMD.Parameters.AddWithValue("@pHora_Fim", pClsConsultas.Hora_Fim)
        mCMD.Parameters.AddWithValue("@pStatus", pClsConsultas.Status)
        mCMD.Parameters.AddWithValue("@pObservacoes", pClsConsultas.Observacoes.Substring(0, IIf(Len(pClsConsultas.Observacoes) > 240, 240, Len(pClsConsultas.Observacoes))))


        mStrSQL = "UPDATE Consultas SET "
        mStrSQL += "Cod_Entidade=@pCod_Entidade,"
        mStrSQL += "Cod_Veterinario=@pCod_Veterinario,"
        mStrSQL += "Cod_Sala=@pCod_Sala,"
        mStrSQL += "Cod_Animal=@pCod_Animal,"
        mStrSQL += "Cod_Tipo_Consulta=@pCod_Tipo_Consulta,"
        mStrSQL += "Cod_Tipo_Animal=@pCod_Tipo_Animal,"
        mStrSQL += "Dia=@pDia,"
        mStrSQL += "Hora_Inicio=@pHora_Inicio,"
        mStrSQL += "Hora_Fim=@pHora_Fim,"
        mStrSQL += "Status=@pStatus,"
        mStrSQL += "Observacoes=@pObservacoes "
        mStrSQL += "WHERE Cod_Consulta=@pCod_Consulta"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ModificaConsultas:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function GravaConsultas(ByVal pNovoConsultas As ClsConsultas) Método para Gravar a TABELA Consultas
    '''      Gerado em 03/03/2023 15:49:34
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function GravaConsultas(ByVal pNovoConsultas As ClsConsultas) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()


        mCMD.Parameters.AddWithValue("@pCod_Consulta", pNovoConsultas.Cod_Consulta.Substring(0, IIf(Len(pNovoConsultas.Cod_Consulta) > 5, 5, Len(pNovoConsultas.Cod_Consulta))))
        mCMD.Parameters.AddWithValue("@pCod_Entidade", pNovoConsultas.Cod_Entidade.Substring(0, IIf(Len(pNovoConsultas.Cod_Entidade) > 5, 5, Len(pNovoConsultas.Cod_Entidade))))
        mCMD.Parameters.AddWithValue("@pCod_Veterinario", pNovoConsultas.Cod_Veterinario.Substring(0, IIf(Len(pNovoConsultas.Cod_Veterinario) > 5, 5, Len(pNovoConsultas.Cod_Veterinario))))
        mCMD.Parameters.AddWithValue("@pCod_Sala", pNovoConsultas.Cod_Sala.Substring(0, IIf(Len(pNovoConsultas.Cod_Sala) > 3, 3, Len(pNovoConsultas.Cod_Sala))))
        mCMD.Parameters.AddWithValue("@pCod_Animal", pNovoConsultas.Cod_Animal.Substring(0, IIf(Len(pNovoConsultas.Cod_Animal) > 5, 5, Len(pNovoConsultas.Cod_Animal))))
        mCMD.Parameters.AddWithValue("@pCod_Tipo_Consulta", pNovoConsultas.Cod_Tipo_Consulta.Substring(0, IIf(Len(pNovoConsultas.Cod_Tipo_Consulta) > 5, 5, Len(pNovoConsultas.Cod_Tipo_Consulta))))
        mCMD.Parameters.AddWithValue("@pCod_Tipo_Animal", pNovoConsultas.Cod_Tipo_Animal.Substring(0, IIf(Len(pNovoConsultas.Cod_Tipo_Animal) > 4, 4, Len(pNovoConsultas.Cod_Tipo_Animal))))
        mCMD.Parameters.AddWithValue("@pDia", pNovoConsultas.Dia)
        mCMD.Parameters.AddWithValue("@pHora_Inicio", pNovoConsultas.Hora_Inicio)
        mCMD.Parameters.AddWithValue("@pHora_Fim", pNovoConsultas.Hora_Fim)
        mCMD.Parameters.AddWithValue("@pStatus", pNovoConsultas.Status)
        mCMD.Parameters.AddWithValue("@pObservacoes", pNovoConsultas.Observacoes.Substring(0, IIf(Len(pNovoConsultas.Observacoes) > 240, 240, Len(pNovoConsultas.Observacoes))))
        mCMD.Parameters.AddWithValue("@pFLG_Ativo", pNovoConsultas.FLG_Ativo)


        mStrSQL = "INSERT INTO Consultas "
        mStrSQL += "("
        mStrSQL += "Cod_Consulta,"
        mStrSQL += "Cod_Entidade,"
        mStrSQL += "Cod_Veterinario,"
        mStrSQL += "Cod_Sala,"
        mStrSQL += "Cod_Animal,"
        mStrSQL += "Cod_Tipo_Consulta,"
        mStrSQL += "Cod_Tipo_Animal,"
        mStrSQL += "Dia,"
        mStrSQL += "Hora_Inicio,"
        mStrSQL += "Hora_Fim,"
        mStrSQL += "Status,"
        mStrSQL += "Observacoes,"
        mStrSQL += "FLG_Ativo "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        mStrSQL += "@pCod_Consulta,"
        mStrSQL += "@pCod_Entidade,"
        mStrSQL += "@pCod_Veterinario,"
        mStrSQL += "@pCod_Sala,"
        mStrSQL += "@pCod_Animal,"
        mStrSQL += "@pCod_Tipo_Consulta,"
        mStrSQL += "@pCod_Tipo_Animal,"
        mStrSQL += "@pDia,"
        mStrSQL += "@pHora_Inicio,"
        mStrSQL += "@pHora_Fim,"
        mStrSQL += "@pStatus,"
        mStrSQL += "@pObservacoes,"
        mStrSQL += "1"
        mStrSQL += ")"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
            ClsEmpresas.GravaContador(enCont.Consultas)
        Catch ex As Exception
            MsgBox("GravaConsultas:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function ApagaConsultas(ByVal pCod_Consulta As String) Método para Apagar um Registo da Tabela Consultas
    '''      Gerado em 03/03/2023 15:49:34
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function ApagaConsultas(ByVal pCod_Consulta As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pCod_Consulta", pCod_Consulta)


        mStrSQL = "UPDATE Consultas SET "
        mStrSQL += "FLG_Ativo=0 "
        mStrSQL += "WHERE Cod_Consulta=@pCod_Consulta"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ApagaConsultas:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function
End Class



''' <summary>
'''      Classe ConsultasComparer 
'''      Gerado em 03/03/2023 15:49:34
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2023
''' </remarks>
Public Class ConsultasComparer
    Implements IEqualityComparer(Of ClsConsultas)

    Public Function Equals1(ByVal x As ClsConsultas, ByVal y As ClsConsultas) As Boolean Implements IEqualityComparer(Of ClsConsultas).Equals

        If x Is y Then Return True

        If x Is Nothing OrElse y Is Nothing Then Return False

        Return (x.Cod_Consulta = y.Cod_Consulta) ' AndAlso (x.Cod_Entidade = y.Cod_Entidade)
    End Function

    Public Function GetHashCode1(ByVal pCls As ClsConsultas) As Integer Implements IEqualityComparer(Of ClsConsultas).GetHashCode

        If pCls Is Nothing Then Return 0

        'Dim Hash_ClsConsultas_Cod_Entidade = pCls.Cod_Entidade.GetHashCode()
        Dim Hash_ClsConsultas_Cod_Consulta = pCls.Cod_Consulta.GetHashCode()

        Return Hash_ClsConsultas_Cod_Consulta 'Xor Hash_ClsConsultas_Cod_Entidade
    End Function
End Class
