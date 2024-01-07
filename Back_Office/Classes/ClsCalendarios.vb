
Imports System.Data.SqlClient


''' <summary>
'''      Classe ClsCalendarios Classe da Tabela Calendarios
'''      Gerado em 29/11/2022 14:12:53
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2022
''' </remarks>
Public Class ClsCalendarios


    ' -----------------------------------------
    ' Property's da tabela Calendarios
    ' -----------------------------------------

    Public Property Cod_Calendario As String                                ' Len:  5 - SQL_Type: nvarchar
    Public Property Designacao As String                                    ' Len: 50 - SQL_Type: nvarchar
    Public Property Ano As String                                           ' Len:  5 - SQL_Type: nvarchar
    Public Property FLG_Ativo As Boolean                                    ' SQL_Type: bit


    Sub New()
    End Sub


    '--------------------------------------------
    ' Exemplo de criador de Código por contador
    ' Para ser usado no caso de o Cdigo ser gerado
    ' e o contador existir na tabela Empresas
    '---------------------------------------------

    'Friend Shared Function GetNovoCodigo() As String

    'Return "C" & ClsEmpresas.GetContador(enCont.Calendarios).ToString("000")' <-------------- VERIFICAR O Nº de ZEROS

    'End Function


    ''' <summary>
    '''      Function GetCalendarios() Método para devolver a Lista de Calendarios
    '''      Gerado em 29/11/2022 14:12:53
    ''' </summary>
    ''' <returns>
    '''      mListaCalendarios
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function GetCalendarios() As List(Of ClsCalendarios)
        Dim mListaCalendarios As New List(Of ClsCalendarios)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Calendario,'') As Cod_Calendario,"
        mStrSQL += "ISNULL(Designacao,'') As Designacao,"
        mStrSQL += "ISNULL(Ano,'') As Ano,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Calendarios "
        mStrSQL += "WHERE FLG_Ativo=1"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsCalendarios As New ClsCalendarios

            With mClsCalendarios
                .Cod_Calendario = mRDR.GetString(mRDR.GetOrdinal("Cod_Calendario"))
                .Designacao = mRDR.GetString(mRDR.GetOrdinal("Designacao"))
                .Ano = mRDR.GetString(mRDR.GetOrdinal("Ano"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaCalendarios.Add(mClsCalendarios)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaCalendarios
    End Function

    ''' <summary>
    '''      Function FiltrarCalendarios Método para Filtrar os campos da lista de Calendarios
    '''      Gerado em 29/11/2022 14:12:53
    ''' </summary>
    ''' <returns>
    '''      mListaCalendarios
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function FiltrarCalendarios(ByVal pFiltro As ClsCalendarios) As List(Of ClsCalendarios)
        Dim mListaCalendarios As New List(Of ClsCalendarios)
        Dim mLista As New List(Of ClsCalendarios)

        mListaCalendarios = GetCalendarios()

        mLista = mListaCalendarios.FindAll(Function(x) _
        x.Cod_Calendario.Contains(pFiltro.Cod_Calendario)
        )
        '-----------------------------------------------------
        'Pode Colocar em cima mais colunas como esta abaixo...
        '-----------------------------------------------------
        ' AND x.Designacao.Contains(pFiltro.Designacao) 

        Return mLista
    End Function


    ''' <summary>
    '''      Function GetCalendariosByCod(ByVal pCod_Calendario As String) Método para decolver uma Classe de Calendarios
    '''      Gerado em 29/11/2022 14:12:53
    ''' </summary>
    ''' <returns>
    '''      mClsCalendarios
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function GetCalendariosByCod(ByVal pCod_Calendario As String) As ClsCalendarios
        Dim mClsCalendarios As New ClsCalendarios

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Calendario", pCod_Calendario)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Calendario,'') As Cod_Calendario,"
        mStrSQL += "ISNULL(Designacao,'') As Designacao,"
        mStrSQL += "ISNULL(Ano,'') As Ano,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Calendarios "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Cod_Calendario=@pCod_Calendario"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsCalendarios
                .Cod_Calendario = mRDR.GetString(mRDR.GetOrdinal("Cod_Calendario"))
                .Designacao = mRDR.GetString(mRDR.GetOrdinal("Designacao"))
                .Ano = mRDR.GetString(mRDR.GetOrdinal("Ano"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mClsCalendarios
    End Function


    ''' <summary>
    '''      Function ModificaCalendarios(ByVal pClsCalendarios As ClsCalendarios) Método para Modificar a TABELA Calendarios
    '''      Gerado em 29/11/2022 14:12:53
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function ModificaCalendarios(ByVal pClsCalendarios As ClsCalendarios) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Calendario", pClsCalendarios.Cod_Calendario.Substring(0, IIf(Len(pClsCalendarios.Cod_Calendario) > 5, 5, Len(pClsCalendarios.Cod_Calendario))))
        mCMD.Parameters.AddWithValue("@pDesignacao", pClsCalendarios.Designacao.Substring(0, IIf(Len(pClsCalendarios.Designacao) > 50, 50, Len(pClsCalendarios.Designacao))))
        mCMD.Parameters.AddWithValue("@pAno", pClsCalendarios.Ano.Substring(0, IIf(Len(pClsCalendarios.Ano) > 5, 5, Len(pClsCalendarios.Ano))))


        mStrSQL = "UPDATE Calendarios SET "
        mStrSQL += "Designacao=@pDesignacao,"
        mStrSQL += "Ano=@pAno "
        mStrSQL += "WHERE Cod_Calendario=@pCod_Calendario"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ModificaCalendarios:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function GravaCalendarios(ByVal pNovoCalendarios As ClsCalendarios) Método para Gravar a TABELA Calendarios
    '''      Gerado em 29/11/2022 14:12:53
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function GravaCalendarios(ByVal pNovoCalendarios As ClsCalendarios) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()


        mCMD.Parameters.AddWithValue("@pCod_Calendario", pNovoCalendarios.Cod_Calendario.Substring(0, IIf(Len(pNovoCalendarios.Cod_Calendario) > 5, 5, Len(pNovoCalendarios.Cod_Calendario))))
        mCMD.Parameters.AddWithValue("@pDesignacao", pNovoCalendarios.Designacao.Substring(0, IIf(Len(pNovoCalendarios.Designacao) > 50, 50, Len(pNovoCalendarios.Designacao))))
        mCMD.Parameters.AddWithValue("@pAno", pNovoCalendarios.Ano.Substring(0, IIf(Len(pNovoCalendarios.Ano) > 5, 5, Len(pNovoCalendarios.Ano))))
        mCMD.Parameters.AddWithValue("@pFLG_Ativo", pNovoCalendarios.FLG_Ativo)


        mStrSQL = "INSERT INTO Calendarios "
        mStrSQL += "("
        mStrSQL += "Cod_Calendario,"
        mStrSQL += "Designacao,"
        mStrSQL += "Ano,"
        mStrSQL += "FLG_Ativo "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        mStrSQL += "@pCod_Calendario,"
        mStrSQL += "@pDesignacao,"
        mStrSQL += "@pAno,"
        mStrSQL += "1"
        mStrSQL += ")"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
            'ClsEmpresas.GravaContador(enCont.Calendarios)'<<<<-------- Verificar se é  preciso...
        Catch ex As Exception
            MsgBox("GravaCalendarios:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function ApagaCalendarios(ByVal pCod_Calendario As String) Método para Apagar um Registo da Tabela Calendarios
    '''      Gerado em 29/11/2022 14:12:53
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function ApagaCalendarios(ByVal pCod_Calendario As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pCod_Calendario", pCod_Calendario)


        mStrSQL = "UPDATE Calendarios SET "
        mStrSQL += "FLG_Ativo=0 "
        mStrSQL += "WHERE Cod_Calendario=@pCod_Calendario"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ApagaCalendarios:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function
End Class



''' <summary>
'''      Classe CalendariosComparer 
'''      Gerado em 29/11/2022 14:12:53
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2022
''' </remarks>
Public Class CalendariosComparer
    Implements IEqualityComparer(Of ClsCalendarios)

    Public Function Equals1(ByVal x As ClsCalendarios, ByVal y As ClsCalendarios) As Boolean Implements IEqualityComparer(Of ClsCalendarios).Equals

        If x Is y Then Return True

        If x Is Nothing OrElse y Is Nothing Then Return False

        Return (x.Cod_Calendario = y.Cod_Calendario) ' AndAlso (x.Designacao = y.Designacao)
    End Function

    Public Function GetHashCode1(ByVal pCls As ClsCalendarios) As Integer Implements IEqualityComparer(Of ClsCalendarios).GetHashCode

        If pCls Is Nothing Then Return 0

        'Dim Hash_ClsCalendarios_Designacao = pCls.Designacao.GetHashCode()
        Dim Hash_ClsCalendarios_Cod_Calendario = pCls.Cod_Calendario.GetHashCode()

        Return Hash_ClsCalendarios_Cod_Calendario 'Xor Hash_ClsCalendarios_Designacao
    End Function
End Class
