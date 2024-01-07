
Imports System.Data.SqlClient


''' <summary>
'''      Classe ClsDistritos Classe da Tabela Distritos
'''      Gerado em 29/11/2022 14:12:54
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2022
''' </remarks>
Public Class ClsDistritos


    ' -----------------------------------------
    ' Property's da tabela Distritos
    ' -----------------------------------------

    Public Property Cod_Distrito As String                                  ' Len:  2 - SQL_Type: nvarchar
    Public Property Distrito As String                                      ' Len: 50 - SQL_Type: nvarchar
    Public Property FLG_Ativo As Boolean                                    ' SQL_Type: bit


    Sub New()
    End Sub


    '--------------------------------------------
    ' Exemplo de criador de Código por contador
    ' Para ser usado no caso de o Cdigo ser gerado
    ' e o contador existir na tabela Empresas
    '---------------------------------------------

    'Friend Shared Function GetNovoCodigo() As String

    'Return "D" & ClsEmpresas.GetContador(enCont.Distritos).ToString("000")' <-------------- VERIFICAR O Nº de ZEROS

    'End Function


    ''' <summary>
    '''      Function GetDistritos() Método para devolver a Lista de Distritos
    '''      Gerado em 29/11/2022 14:12:54
    ''' </summary>
    ''' <returns>
    '''      mListaDistritos
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function GetDistritos() As List(Of ClsDistritos)
        Dim mListaDistritos As New List(Of ClsDistritos)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Distrito,'') As Cod_Distrito,"
        mStrSQL += "ISNULL(Distrito,'') As Distrito,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Distritos "
        mStrSQL += "WHERE FLG_Ativo=1"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsDistritos As New ClsDistritos

            With mClsDistritos
                .Cod_Distrito = mRDR.GetString(mRDR.GetOrdinal("Cod_Distrito"))
                .Distrito = mRDR.GetString(mRDR.GetOrdinal("Distrito"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaDistritos.Add(mClsDistritos)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaDistritos
    End Function

    ''' <summary>
    '''      Function FiltrarDistritos Método para Filtrar os campos da lista de Distritos
    '''      Gerado em 29/11/2022 14:12:54
    ''' </summary>
    ''' <returns>
    '''      mListaDistritos
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function FiltrarDistritos(ByVal pFiltro As ClsDistritos) As List(Of ClsDistritos)
        Dim mListaDistritos As New List(Of ClsDistritos)
        Dim mLista As New List(Of ClsDistritos)

        mListaDistritos = GetDistritos()

        mLista = mListaDistritos.FindAll(Function(x) _
        x.Cod_Distrito.Contains(pFiltro.Cod_Distrito)
        )
        '-----------------------------------------------------
        'Pode Colocar em cima mais colunas como esta abaixo...
        '-----------------------------------------------------
        ' AND x.Distrito.Contains(pFiltro.Distrito) 

        Return mLista
    End Function


    ''' <summary>
    '''      Function GetDistritosByCod(ByVal pCod_Distrito As String) Método para decolver uma Classe de Distritos
    '''      Gerado em 29/11/2022 14:12:54
    ''' </summary>
    ''' <returns>
    '''      mClsDistritos
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function GetDistritosByCod(ByVal pCod_Distrito As String) As ClsDistritos
        Dim mClsDistritos As New ClsDistritos

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Distrito", pCod_Distrito)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Distrito,'') As Cod_Distrito,"
        mStrSQL += "ISNULL(Distrito,'') As Distrito,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Distritos "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Cod_Distrito=@pCod_Distrito"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsDistritos
                .Cod_Distrito = mRDR.GetString(mRDR.GetOrdinal("Cod_Distrito"))
                .Distrito = mRDR.GetString(mRDR.GetOrdinal("Distrito"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mClsDistritos
    End Function


    ''' <summary>
    '''      Function ModificaDistritos(ByVal pClsDistritos As ClsDistritos) Método para Modificar a TABELA Distritos
    '''      Gerado em 29/11/2022 14:12:54
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function ModificaDistritos(ByVal pClsDistritos As ClsDistritos) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Distrito", pClsDistritos.Cod_Distrito.Substring(0, IIf(Len(pClsDistritos.Cod_Distrito) > 2, 2, Len(pClsDistritos.Cod_Distrito))))
        mCMD.Parameters.AddWithValue("@pDistrito", pClsDistritos.Distrito.Substring(0, IIf(Len(pClsDistritos.Distrito) > 50, 50, Len(pClsDistritos.Distrito))))


        mStrSQL = "UPDATE Distritos SET "
        mStrSQL += "Distrito=@pDistrito "
        mStrSQL += "WHERE Cod_Distrito=@pCod_Distrito"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ModificaDistritos:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function GravaDistritos(ByVal pNovoDistritos As ClsDistritos) Método para Gravar a TABELA Distritos
    '''      Gerado em 29/11/2022 14:12:54
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function GravaDistritos(ByVal pNovoDistritos As ClsDistritos) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()


        mCMD.Parameters.AddWithValue("@pCod_Distrito", pNovoDistritos.Cod_Distrito.Substring(0, IIf(Len(pNovoDistritos.Cod_Distrito) > 2, 2, Len(pNovoDistritos.Cod_Distrito))))
        mCMD.Parameters.AddWithValue("@pDistrito", pNovoDistritos.Distrito.Substring(0, IIf(Len(pNovoDistritos.Distrito) > 50, 50, Len(pNovoDistritos.Distrito))))
        mCMD.Parameters.AddWithValue("@pFLG_Ativo", pNovoDistritos.FLG_Ativo)


        mStrSQL = "INSERT INTO Distritos "
        mStrSQL += "("
        mStrSQL += "Cod_Distrito,"
        mStrSQL += "Distrito,"
        mStrSQL += "FLG_Ativo "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        mStrSQL += "@pCod_Distrito,"
        mStrSQL += "@pDistrito,"
        mStrSQL += "1"
        mStrSQL += ")"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
            'ClsEmpresas.GravaContador(enCont.Distritos)'<<<<-------- Verificar se é  preciso...
        Catch ex As Exception
            MsgBox("GravaDistritos:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function ApagaDistritos(ByVal pCod_Distrito As String) Método para Apagar um Registo da Tabela Distritos
    '''      Gerado em 29/11/2022 14:12:54
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function ApagaDistritos(ByVal pCod_Distrito As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pCod_Distrito", pCod_Distrito)


        mStrSQL = "UPDATE Distritos SET "
        mStrSQL += "FLG_Ativo=0 "
        mStrSQL += "WHERE Cod_Distrito=@pCod_Distrito"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ApagaDistritos:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function
End Class



''' <summary>
'''      Classe DistritosComparer 
'''      Gerado em 29/11/2022 14:12:54
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2022
''' </remarks>
Public Class DistritosComparer
    Implements IEqualityComparer(Of ClsDistritos)

    Public Function Equals1(ByVal x As ClsDistritos, ByVal y As ClsDistritos) As Boolean Implements IEqualityComparer(Of ClsDistritos).Equals

        If x Is y Then Return True

        If x Is Nothing OrElse y Is Nothing Then Return False

        Return (x.Cod_Distrito = y.Cod_Distrito) ' AndAlso (x.Distrito = y.Distrito)
    End Function

    Public Function GetHashCode1(ByVal pCls As ClsDistritos) As Integer Implements IEqualityComparer(Of ClsDistritos).GetHashCode

        If pCls Is Nothing Then Return 0

        'Dim Hash_ClsDistritos_Distrito = pCls.Distrito.GetHashCode()
        Dim Hash_ClsDistritos_Cod_Distrito = pCls.Cod_Distrito.GetHashCode()

        Return Hash_ClsDistritos_Cod_Distrito 'Xor Hash_ClsDistritos_Distrito
    End Function
End Class
