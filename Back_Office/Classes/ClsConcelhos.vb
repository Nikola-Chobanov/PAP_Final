
Imports System.Data.SqlClient


''' <summary>
'''      Classe ClsConcelhos Classe da Tabela Concelhos
'''      Gerado em 29/11/2022 14:12:53
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2022
''' </remarks>
Public Class ClsConcelhos


    ' -----------------------------------------
    ' Property's da tabela Concelhos
    ' -----------------------------------------

    Public Property Cod_Distrito As String                                  ' Len:  2 - SQL_Type: nvarchar
    Public Property Cod_Concelho As String                                  ' Len:  2 - SQL_Type: nvarchar
    Public Property Cod_DC As String                                        ' Len:  4 - SQL_Type: nvarchar
    Public Property Concelho As String                                      ' Len: 50 - SQL_Type: nvarchar
    Public Property FLG_Ativo As Boolean                                    ' SQL_Type: bit


    Sub New()
    End Sub


    '--------------------------------------------
    ' Exemplo de criador de Código por contador
    ' Para ser usado no caso de o Cdigo ser gerado
    ' e o contador existir na tabela Empresas
    '---------------------------------------------

    'Friend Shared Function GetNovoCodigo() As String

    'Return "C" & ClsEmpresas.GetContador(enCont.Concelhos).ToString("000")' <-------------- VERIFICAR O Nº de ZEROS

    'End Function


    ''' <summary>
    '''      Function GetConcelhos() Método para devolver a Lista de Concelhos
    '''      Gerado em 29/11/2022 14:12:53
    ''' </summary>
    ''' <returns>
    '''      mListaConcelhos
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function GetConcelhos() As List(Of ClsConcelhos)
        Dim mListaConcelhos As New List(Of ClsConcelhos)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Distrito,'') As Cod_Distrito,"
        mStrSQL += "ISNULL(Cod_Concelho,'') As Cod_Concelho,"
        mStrSQL += "ISNULL(Cod_DC,'') As Cod_DC,"
        mStrSQL += "ISNULL(Concelho,'') As Concelho,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Concelhos "
        mStrSQL += "WHERE FLG_Ativo=1"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsConcelhos As New ClsConcelhos

            With mClsConcelhos
                .Cod_Distrito = mRDR.GetString(mRDR.GetOrdinal("Cod_Distrito"))
                .Cod_Concelho = mRDR.GetString(mRDR.GetOrdinal("Cod_Concelho"))
                .Cod_DC = mRDR.GetString(mRDR.GetOrdinal("Cod_DC"))
                .Concelho = mRDR.GetString(mRDR.GetOrdinal("Concelho"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaConcelhos.Add(mClsConcelhos)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaConcelhos
    End Function

    ''' <summary>
    '''      Function FiltrarConcelhos Método para Filtrar os campos da lista de Concelhos
    '''      Gerado em 29/11/2022 14:12:53
    ''' </summary>
    ''' <returns>
    '''      mListaConcelhos
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function FiltrarConcelhos(ByVal pFiltro As ClsConcelhos) As List(Of ClsConcelhos)
        Dim mListaConcelhos As New List(Of ClsConcelhos)
        Dim mLista As New List(Of ClsConcelhos)

        mListaConcelhos = GetConcelhos()

        mLista = mListaConcelhos.FindAll(Function(x) _
        x.Cod_Distrito.Contains(pFiltro.Cod_Distrito)
        )
        '-----------------------------------------------------
        'Pode Colocar em cima mais colunas como esta abaixo...
        '-----------------------------------------------------
        ' AND x.Cod_Concelho.Contains(pFiltro.Cod_Concelho) 

        Return mLista
    End Function


    ''' <summary>
    '''      Function GetConcelhosByCod(ByVal pCod_Distrito As String) Método para decolver uma Classe de Concelhos
    '''      Gerado em 29/11/2022 14:12:53
    ''' </summary>
    ''' <returns>
    '''      mClsConcelhos
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function GetConcelhosByCod(ByVal pCod_Distrito As String) As ClsConcelhos
        Dim mClsConcelhos As New ClsConcelhos

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Distrito", pCod_Distrito)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Distrito,'') As Cod_Distrito,"
        mStrSQL += "ISNULL(Cod_Concelho,'') As Cod_Concelho,"
        mStrSQL += "ISNULL(Cod_DC,'') As Cod_DC,"
        mStrSQL += "ISNULL(Concelho,'') As Concelho,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Concelhos "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Cod_Distrito=@pCod_Distrito"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsConcelhos
                .Cod_Distrito = mRDR.GetString(mRDR.GetOrdinal("Cod_Distrito"))
                .Cod_Concelho = mRDR.GetString(mRDR.GetOrdinal("Cod_Concelho"))
                .Cod_DC = mRDR.GetString(mRDR.GetOrdinal("Cod_DC"))
                .Concelho = mRDR.GetString(mRDR.GetOrdinal("Concelho"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mClsConcelhos
    End Function


    ''' <summary>
    '''      Function ModificaConcelhos(ByVal pClsConcelhos As ClsConcelhos) Método para Modificar a TABELA Concelhos
    '''      Gerado em 29/11/2022 14:12:53
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function ModificaConcelhos(ByVal pClsConcelhos As ClsConcelhos) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Distrito", pClsConcelhos.Cod_Distrito.Substring(0, IIf(Len(pClsConcelhos.Cod_Distrito) > 2, 2, Len(pClsConcelhos.Cod_Distrito))))
        mCMD.Parameters.AddWithValue("@pCod_Concelho", pClsConcelhos.Cod_Concelho.Substring(0, IIf(Len(pClsConcelhos.Cod_Concelho) > 2, 2, Len(pClsConcelhos.Cod_Concelho))))
        mCMD.Parameters.AddWithValue("@pCod_DC", pClsConcelhos.Cod_DC.Substring(0, IIf(Len(pClsConcelhos.Cod_DC) > 4, 4, Len(pClsConcelhos.Cod_DC))))
        mCMD.Parameters.AddWithValue("@pConcelho", pClsConcelhos.Concelho.Substring(0, IIf(Len(pClsConcelhos.Concelho) > 50, 50, Len(pClsConcelhos.Concelho))))


        mStrSQL = "UPDATE Concelhos SET "
        mStrSQL += "Cod_Concelho=@pCod_Concelho,"
        mStrSQL += "Cod_DC=@pCod_DC,"
        mStrSQL += "Concelho=@pConcelho "
        mStrSQL += "WHERE Cod_Distrito=@pCod_Distrito"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ModificaConcelhos:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function GravaConcelhos(ByVal pNovoConcelhos As ClsConcelhos) Método para Gravar a TABELA Concelhos
    '''      Gerado em 29/11/2022 14:12:53
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function GravaConcelhos(ByVal pNovoConcelhos As ClsConcelhos) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()


        mCMD.Parameters.AddWithValue("@pCod_Distrito", pNovoConcelhos.Cod_Distrito.Substring(0, IIf(Len(pNovoConcelhos.Cod_Distrito) > 2, 2, Len(pNovoConcelhos.Cod_Distrito))))
        mCMD.Parameters.AddWithValue("@pCod_Concelho", pNovoConcelhos.Cod_Concelho.Substring(0, IIf(Len(pNovoConcelhos.Cod_Concelho) > 2, 2, Len(pNovoConcelhos.Cod_Concelho))))
        mCMD.Parameters.AddWithValue("@pCod_DC", pNovoConcelhos.Cod_DC.Substring(0, IIf(Len(pNovoConcelhos.Cod_DC) > 4, 4, Len(pNovoConcelhos.Cod_DC))))
        mCMD.Parameters.AddWithValue("@pConcelho", pNovoConcelhos.Concelho.Substring(0, IIf(Len(pNovoConcelhos.Concelho) > 50, 50, Len(pNovoConcelhos.Concelho))))
        mCMD.Parameters.AddWithValue("@pFLG_Ativo", pNovoConcelhos.FLG_Ativo)


        mStrSQL = "INSERT INTO Concelhos "
        mStrSQL += "("
        mStrSQL += "Cod_Distrito,"
        mStrSQL += "Cod_Concelho,"
        mStrSQL += "Cod_DC,"
        mStrSQL += "Concelho,"
        mStrSQL += "FLG_Ativo "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        mStrSQL += "@pCod_Distrito,"
        mStrSQL += "@pCod_Concelho,"
        mStrSQL += "@pCod_DC,"
        mStrSQL += "@pConcelho,"
        mStrSQL += "1"
        mStrSQL += ")"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
            'ClsEmpresas.GravaContador(enCont.Concelhos)'<<<<-------- Verificar se é  preciso...
        Catch ex As Exception
            MsgBox("GravaConcelhos:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function ApagaConcelhos(ByVal pCod_Distrito As String) Método para Apagar um Registo da Tabela Concelhos
    '''      Gerado em 29/11/2022 14:12:53
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function ApagaConcelhos(ByVal pCod_Distrito As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pCod_Distrito", pCod_Distrito)


        mStrSQL = "UPDATE Concelhos SET "
        mStrSQL += "FLG_Ativo=0 "
        mStrSQL += "WHERE Cod_Distrito=@pCod_Distrito"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ApagaConcelhos:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function
End Class



''' <summary>
'''      Classe ConcelhosComparer 
'''      Gerado em 29/11/2022 14:12:53
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2022
''' </remarks>
Public Class ConcelhosComparer
    Implements IEqualityComparer(Of ClsConcelhos)

    Public Function Equals1(ByVal x As ClsConcelhos, ByVal y As ClsConcelhos) As Boolean Implements IEqualityComparer(Of ClsConcelhos).Equals

        If x Is y Then Return True

        If x Is Nothing OrElse y Is Nothing Then Return False

        Return (x.Cod_Distrito = y.Cod_Distrito) ' AndAlso (x.Cod_Concelho = y.Cod_Concelho)
    End Function

    Public Function GetHashCode1(ByVal pCls As ClsConcelhos) As Integer Implements IEqualityComparer(Of ClsConcelhos).GetHashCode

        If pCls Is Nothing Then Return 0

        'Dim Hash_ClsConcelhos_Cod_Concelho = pCls.Cod_Concelho.GetHashCode()
        Dim Hash_ClsConcelhos_Cod_Distrito = pCls.Cod_Distrito.GetHashCode()

        Return Hash_ClsConcelhos_Cod_Distrito 'Xor Hash_ClsConcelhos_Cod_Concelho
    End Function
End Class
