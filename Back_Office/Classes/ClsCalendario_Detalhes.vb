
Imports System.Data.SqlClient


''' <summary>
'''      Classe ClsCalendario_Detalhes Classe da Tabela Calendario_Detalhes
'''      Gerado em 29/11/2022 14:12:53
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2022
''' </remarks>
Public Class ClsCalendario_Detalhes


    ' -----------------------------------------
    ' Property's da tabela Calendario_Detalhes
    ' -----------------------------------------

    Public Property Cod_Calendario As String                                ' Len:  5 - SQL_Type: nvarchar
    Public Property Dia As Date                                             ' SQL_Type: smalldatetime
    Public Property Descritivo_Feriado As String                            ' Len: 50 - SQL_Type: nvarchar
    Public Property FLG_Epoca As String                                     ' Len:  1 - SQL_Type: nvarchar
    Public Property FLG_Feriado As Boolean                                  ' SQL_Type: bit
    Public Property FLG_Ativo As Boolean                                    ' SQL_Type: bit


    Sub New()
    End Sub


    '--------------------------------------------
    ' Exemplo de criador de Código por contador
    ' Para ser usado no caso de o Cdigo ser gerado
    ' e o contador existir na tabela Empresas
    '---------------------------------------------

    'Friend Shared Function GetNovoCodigo() As String

    'Return "C" & ClsEmpresas.GetContador(enCont.Calendario_Detalhes).ToString("000")' <-------------- VERIFICAR O Nº de ZEROS

    'End Function


    ''' <summary>
    '''      Function GetCalendario_Detalhes() Método para devolver a Lista de Calendario_Detalhes
    '''      Gerado em 29/11/2022 14:12:53
    ''' </summary>
    ''' <returns>
    '''      mListaCalendario_Detalhes
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function GetCalendario_Detalhes() As List(Of ClsCalendario_Detalhes)
        Dim mListaCalendario_Detalhes As New List(Of ClsCalendario_Detalhes)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Calendario,'') As Cod_Calendario,"
        mStrSQL += "ISNULL(Dia,0) As Dia,"
        mStrSQL += "ISNULL(Descritivo_Feriado,'') As Descritivo_Feriado,"
        mStrSQL += "ISNULL(FLG_Epoca,'') As FLG_Epoca,"
        mStrSQL += "ISNULL(FLG_Feriado,1) As FLG_Feriado,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Calendario_Detalhes "
        mStrSQL += "WHERE FLG_Ativo=1"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsCalendario_Detalhes As New ClsCalendario_Detalhes

            With mClsCalendario_Detalhes
                .Cod_Calendario = mRDR.GetString(mRDR.GetOrdinal("Cod_Calendario"))
                .Dia = mRDR.GetDateTime(mRDR.GetOrdinal("Dia"))
                .Descritivo_Feriado = mRDR.GetString(mRDR.GetOrdinal("Descritivo_Feriado"))
                .FLG_Epoca = mRDR.GetString(mRDR.GetOrdinal("FLG_Epoca"))
                .FLG_Feriado = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Feriado"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaCalendario_Detalhes.Add(mClsCalendario_Detalhes)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaCalendario_Detalhes
    End Function

    ''' <summary>
    '''      Function FiltrarCalendario_Detalhes Método para Filtrar os campos da lista de Calendario_Detalhes
    '''      Gerado em 29/11/2022 14:12:53
    ''' </summary>
    ''' <returns>
    '''      mListaCalendario_Detalhes
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function FiltrarCalendario_Detalhes(ByVal pFiltro As ClsCalendario_Detalhes) As List(Of ClsCalendario_Detalhes)
        Dim mListaCalendario_Detalhes As New List(Of ClsCalendario_Detalhes)
        Dim mLista As New List(Of ClsCalendario_Detalhes)

        mListaCalendario_Detalhes = GetCalendario_Detalhes()

        mLista = mListaCalendario_Detalhes.FindAll(Function(x) _
        x.Cod_Calendario.Contains(pFiltro.Cod_Calendario)
        )
        '-----------------------------------------------------
        'Pode Colocar em cima mais colunas como esta abaixo...
        '-----------------------------------------------------
        ' AND x.Dia.Contains(pFiltro.Dia) 

        Return mLista
    End Function


    ''' <summary>
    '''      Function GetCalendario_DetalhesByCod(ByVal pCod_Calendario As String) Método para decolver uma Classe de Calendario_Detalhes
    '''      Gerado em 29/11/2022 14:12:53
    ''' </summary>
    ''' <returns>
    '''      mClsCalendario_Detalhes
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function GetCalendario_DetalhesByCod(ByVal pCod_Calendario As String) As ClsCalendario_Detalhes
        Dim mClsCalendario_Detalhes As New ClsCalendario_Detalhes

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Calendario", pCod_Calendario)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Calendario,'') As Cod_Calendario,"
        mStrSQL += "ISNULL(Dia,0) As Dia,"
        mStrSQL += "ISNULL(Descritivo_Feriado,'') As Descritivo_Feriado,"
        mStrSQL += "ISNULL(FLG_Epoca,'') As FLG_Epoca,"
        mStrSQL += "ISNULL(FLG_Feriado,1) As FLG_Feriado,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Calendario_Detalhes "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Cod_Calendario=@pCod_Calendario"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsCalendario_Detalhes
                .Cod_Calendario = mRDR.GetString(mRDR.GetOrdinal("Cod_Calendario"))
                .Dia = mRDR.GetDateTime(mRDR.GetOrdinal("Dia"))
                .Descritivo_Feriado = mRDR.GetString(mRDR.GetOrdinal("Descritivo_Feriado"))
                .FLG_Epoca = mRDR.GetString(mRDR.GetOrdinal("FLG_Epoca"))
                .FLG_Feriado = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Feriado"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mClsCalendario_Detalhes
    End Function


    ''' <summary>
    '''      Function ModificaCalendario_Detalhes(ByVal pClsCalendario_Detalhes As ClsCalendario_Detalhes) Método para Modificar a TABELA Calendario_Detalhes
    '''      Gerado em 29/11/2022 14:12:53
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function ModificaCalendario_Detalhes(ByVal pClsCalendario_Detalhes As ClsCalendario_Detalhes) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Calendario", pClsCalendario_Detalhes.Cod_Calendario.Substring(0, IIf(Len(pClsCalendario_Detalhes.Cod_Calendario) > 5, 5, Len(pClsCalendario_Detalhes.Cod_Calendario))))
        mCMD.Parameters.AddWithValue("@pDia", pClsCalendario_Detalhes.Dia)
        mCMD.Parameters.AddWithValue("@pDescritivo_Feriado", pClsCalendario_Detalhes.Descritivo_Feriado.Substring(0, IIf(Len(pClsCalendario_Detalhes.Descritivo_Feriado) > 50, 50, Len(pClsCalendario_Detalhes.Descritivo_Feriado))))
        mCMD.Parameters.AddWithValue("@pFLG_Epoca", pClsCalendario_Detalhes.FLG_Epoca.Substring(0, IIf(Len(pClsCalendario_Detalhes.FLG_Epoca) > 1, 1, Len(pClsCalendario_Detalhes.FLG_Epoca))))
        mCMD.Parameters.AddWithValue("@pFLG_Feriado", pClsCalendario_Detalhes.FLG_Feriado)


        mStrSQL = "UPDATE Calendario_Detalhes SET "
        mStrSQL += "Dia=@pDia,"
        mStrSQL += "Descritivo_Feriado=@pDescritivo_Feriado,"
        mStrSQL += "FLG_Epoca=@pFLG_Epoca,"
        mStrSQL += "FLG_Feriado=@pFLG_Feriado "
        mStrSQL += "WHERE Cod_Calendario=@pCod_Calendario"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ModificaCalendario_Detalhes:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function GravaCalendario_Detalhes(ByVal pNovoCalendario_Detalhes As ClsCalendario_Detalhes) Método para Gravar a TABELA Calendario_Detalhes
    '''      Gerado em 29/11/2022 14:12:53
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function GravaCalendario_Detalhes(ByVal pNovoCalendario_Detalhes As ClsCalendario_Detalhes) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()


        mCMD.Parameters.AddWithValue("@pCod_Calendario", pNovoCalendario_Detalhes.Cod_Calendario.Substring(0, IIf(Len(pNovoCalendario_Detalhes.Cod_Calendario) > 5, 5, Len(pNovoCalendario_Detalhes.Cod_Calendario))))
        mCMD.Parameters.AddWithValue("@pDia", pNovoCalendario_Detalhes.Dia)
        mCMD.Parameters.AddWithValue("@pDescritivo_Feriado", pNovoCalendario_Detalhes.Descritivo_Feriado.Substring(0, IIf(Len(pNovoCalendario_Detalhes.Descritivo_Feriado) > 50, 50, Len(pNovoCalendario_Detalhes.Descritivo_Feriado))))
        mCMD.Parameters.AddWithValue("@pFLG_Epoca", pNovoCalendario_Detalhes.FLG_Epoca.Substring(0, IIf(Len(pNovoCalendario_Detalhes.FLG_Epoca) > 1, 1, Len(pNovoCalendario_Detalhes.FLG_Epoca))))
        mCMD.Parameters.AddWithValue("@pFLG_Feriado", pNovoCalendario_Detalhes.FLG_Feriado)
        mCMD.Parameters.AddWithValue("@pFLG_Ativo", pNovoCalendario_Detalhes.FLG_Ativo)


        mStrSQL = "INSERT INTO Calendario_Detalhes "
        mStrSQL += "("
        mStrSQL += "Cod_Calendario,"
        mStrSQL += "Dia,"
        mStrSQL += "Descritivo_Feriado,"
        mStrSQL += "FLG_Epoca,"
        mStrSQL += "FLG_Feriado,"
        mStrSQL += "FLG_Ativo "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        mStrSQL += "@pCod_Calendario,"
        mStrSQL += "@pDia,"
        mStrSQL += "@pDescritivo_Feriado,"
        mStrSQL += "@pFLG_Epoca,"
        mStrSQL += "@pFLG_Feriado,"
        mStrSQL += "1"
        mStrSQL += ")"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
            'ClsEmpresas.GravaContador(enCont.Calendario_Detalhes)'<<<<-------- Verificar se é  preciso...
        Catch ex As Exception
            MsgBox("GravaCalendario_Detalhes:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function ApagaCalendario_Detalhes(ByVal pCod_Calendario As String) Método para Apagar um Registo da Tabela Calendario_Detalhes
    '''      Gerado em 29/11/2022 14:12:53
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function ApagaCalendario_Detalhes(ByVal pCod_Calendario As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pCod_Calendario", pCod_Calendario)


        mStrSQL = "UPDATE Calendario_Detalhes SET "
        mStrSQL += "FLG_Ativo=0 "
        mStrSQL += "WHERE Cod_Calendario=@pCod_Calendario"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ApagaCalendario_Detalhes:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function
End Class



''' <summary>
'''      Classe Calendario_DetalhesComparer 
'''      Gerado em 29/11/2022 14:12:53
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2022
''' </remarks>
Public Class Calendario_DetalhesComparer
    Implements IEqualityComparer(Of ClsCalendario_Detalhes)

    Public Function Equals1(ByVal x As ClsCalendario_Detalhes, ByVal y As ClsCalendario_Detalhes) As Boolean Implements IEqualityComparer(Of ClsCalendario_Detalhes).Equals

        If x Is y Then Return True

        If x Is Nothing OrElse y Is Nothing Then Return False

        Return (x.Cod_Calendario = y.Cod_Calendario) ' AndAlso (x.Dia = y.Dia)
    End Function

    Public Function GetHashCode1(ByVal pCls As ClsCalendario_Detalhes) As Integer Implements IEqualityComparer(Of ClsCalendario_Detalhes).GetHashCode

        If pCls Is Nothing Then Return 0

        'Dim Hash_ClsCalendario_Detalhes_Dia = pCls.Dia.GetHashCode()
        Dim Hash_ClsCalendario_Detalhes_Cod_Calendario = pCls.Cod_Calendario.GetHashCode()

        Return Hash_ClsCalendario_Detalhes_Cod_Calendario 'Xor Hash_ClsCalendario_Detalhes_Dia
    End Function
End Class
