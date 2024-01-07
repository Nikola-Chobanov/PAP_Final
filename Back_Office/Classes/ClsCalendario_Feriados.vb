
Imports System.Data.SqlClient


''' <summary>
'''      Classe ClsCalendario_Feriados Classe da Tabela Calendario_Feriados
'''      Gerado em 29/11/2022 14:12:53
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2022
''' </remarks>
Public Class ClsCalendario_Feriados


    ' -----------------------------------------
    ' Property's da tabela Calendario_Feriados
    ' -----------------------------------------

    Public Property Dia As String                                           ' Len:  2 - SQL_Type: nvarchar
    Public Property Mes As String                                           ' Len:  2 - SQL_Type: nvarchar
    Public Property Descritivo As String                                    ' Len: 50 - SQL_Type: nvarchar
    Public Property FLG_Ativo As Boolean                                    ' SQL_Type: bit


    Sub New()
    End Sub


    '--------------------------------------------
    ' Exemplo de criador de Código por contador
    ' Para ser usado no caso de o Cdigo ser gerado
    ' e o contador existir na tabela Empresas
    '---------------------------------------------

    'Friend Shared Function GetNovoCodigo() As String

    'Return "C" & ClsEmpresas.GetContador(enCont.Calendario_Feriados).ToString("000")' <-------------- VERIFICAR O Nº de ZEROS

    'End Function


    ''' <summary>
    '''      Function GetCalendario_Feriados() Método para devolver a Lista de Calendario_Feriados
    '''      Gerado em 29/11/2022 14:12:53
    ''' </summary>
    ''' <returns>
    '''      mListaCalendario_Feriados
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function GetCalendario_Feriados() As List(Of ClsCalendario_Feriados)
        Dim mListaCalendario_Feriados As New List(Of ClsCalendario_Feriados)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Dia,'') As Dia,"
        mStrSQL += "ISNULL(Mes,'') As Mes,"
        mStrSQL += "ISNULL(Descritivo,'') As Descritivo,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Calendario_Feriados "
        mStrSQL += "WHERE FLG_Ativo=1"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsCalendario_Feriados As New ClsCalendario_Feriados

            With mClsCalendario_Feriados
                .Dia = mRDR.GetString(mRDR.GetOrdinal("Dia"))
                .Mes = mRDR.GetString(mRDR.GetOrdinal("Mes"))
                .Descritivo = mRDR.GetString(mRDR.GetOrdinal("Descritivo"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaCalendario_Feriados.Add(mClsCalendario_Feriados)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaCalendario_Feriados
    End Function


    ''' <summary>
    '''      Function GetCalendario_FeriadosByCod(ByVal pDia As String) Método para decolver uma Classe de Calendario_Feriados
    '''      Gerado em 29/11/2022 14:12:53
    ''' </summary>
    ''' <returns>
    '''      mClsCalendario_Feriados
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function GetCalendario_FeriadosByCod(ByVal pDia As String) As ClsCalendario_Feriados
        Dim mClsCalendario_Feriados As New ClsCalendario_Feriados

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pDia", pDia)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Dia,'') As Dia,"
        mStrSQL += "ISNULL(Mes,'') As Mes,"
        mStrSQL += "ISNULL(Descritivo,'') As Descritivo,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Calendario_Feriados "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Dia=@pDia"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsCalendario_Feriados
                .Dia = mRDR.GetString(mRDR.GetOrdinal("Dia"))
                .Mes = mRDR.GetString(mRDR.GetOrdinal("Mes"))
                .Descritivo = mRDR.GetString(mRDR.GetOrdinal("Descritivo"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mClsCalendario_Feriados
    End Function


    ''' <summary>
    '''      Function ModificaCalendario_Feriados(ByVal pClsCalendario_Feriados As ClsCalendario_Feriados) Método para Modificar a TABELA Calendario_Feriados
    '''      Gerado em 29/11/2022 14:12:53
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function ModificaCalendario_Feriados(ByVal pClsCalendario_Feriados As ClsCalendario_Feriados) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pDia", pClsCalendario_Feriados.Dia.Substring(0, IIf(Len(pClsCalendario_Feriados.Dia) > 2, 2, Len(pClsCalendario_Feriados.Dia))))
        mCMD.Parameters.AddWithValue("@pMes", pClsCalendario_Feriados.Mes.Substring(0, IIf(Len(pClsCalendario_Feriados.Mes) > 2, 2, Len(pClsCalendario_Feriados.Mes))))
        mCMD.Parameters.AddWithValue("@pDescritivo", pClsCalendario_Feriados.Descritivo.Substring(0, IIf(Len(pClsCalendario_Feriados.Descritivo) > 50, 50, Len(pClsCalendario_Feriados.Descritivo))))


        mStrSQL = "UPDATE Calendario_Feriados SET "
        mStrSQL += "Mes=@pMes,"
        mStrSQL += "Descritivo=@pDescritivo "
        mStrSQL += "WHERE Dia=@pDia"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ModificaCalendario_Feriados:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function GravaCalendario_Feriados(ByVal pNovoCalendario_Feriados As ClsCalendario_Feriados) Método para Gravar a TABELA Calendario_Feriados
    '''      Gerado em 29/11/2022 14:12:53
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function GravaCalendario_Feriados(ByVal pNovoCalendario_Feriados As ClsCalendario_Feriados) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()


        mCMD.Parameters.AddWithValue("@pDia", pNovoCalendario_Feriados.Dia.Substring(0, IIf(Len(pNovoCalendario_Feriados.Dia) > 2, 2, Len(pNovoCalendario_Feriados.Dia))))
        mCMD.Parameters.AddWithValue("@pMes", pNovoCalendario_Feriados.Mes.Substring(0, IIf(Len(pNovoCalendario_Feriados.Mes) > 2, 2, Len(pNovoCalendario_Feriados.Mes))))
        mCMD.Parameters.AddWithValue("@pDescritivo", pNovoCalendario_Feriados.Descritivo.Substring(0, IIf(Len(pNovoCalendario_Feriados.Descritivo) > 50, 50, Len(pNovoCalendario_Feriados.Descritivo))))
        mCMD.Parameters.AddWithValue("@pFLG_Ativo", pNovoCalendario_Feriados.FLG_Ativo)


        mStrSQL = "INSERT INTO Calendario_Feriados "
        mStrSQL += "("
        mStrSQL += "Dia,"
        mStrSQL += "Mes,"
        mStrSQL += "Descritivo,"
        mStrSQL += "FLG_Ativo "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        mStrSQL += "@pDia,"
        mStrSQL += "@pMes,"
        mStrSQL += "@pDescritivo,"
        mStrSQL += "1"
        mStrSQL += ")"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
            'ClsEmpresas.GravaContador(enCont.Calendario_Feriados)'<<<<-------- Verificar se é  preciso...
        Catch ex As Exception
            MsgBox("GravaCalendario_Feriados:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function ApagaCalendario_Feriados(ByVal pDia As String) Método para Apagar um Registo da Tabela Calendario_Feriados
    '''      Gerado em 29/11/2022 14:12:53
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function ApagaCalendario_Feriados(ByVal pDia As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pDia", pDia)


        mStrSQL = "UPDATE Calendario_Feriados SET "
        mStrSQL += "FLG_Ativo=0 "
        mStrSQL += "WHERE Dia=@pDia"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ApagaCalendario_Feriados:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function
End Class

