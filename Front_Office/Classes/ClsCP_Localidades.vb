
Imports System.Data.SqlClient


''' <summary>
'''      Classe ClsCP_Localidades Classe da Tabela CP_Localidades
'''      Gerado em 03/03/2023 15:49:34
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2023
''' </remarks>
Public Class ClsCP_Localidades


    ' -----------------------------------------
    ' Property's da tabela CP_Localidades
    ' -----------------------------------------

    Public Property Cod_Postal As String                                    ' Len:  8 - SQL_Type: nvarchar
    Public Property Cod_Distrito As String                                  ' Len:  2 - SQL_Type: nvarchar
    Public Property Cod_Concelho As String                                  ' Len:  2 - SQL_Type: nvarchar
    Public Property Localidade As String                                    ' Len: 50 - SQL_Type: nvarchar
    Public Property FLG_Ativo As Boolean                                    ' SQL_Type: bit


    Sub New()
    End Sub


    '--------------------------------------------
    ' Exemplo de criador de Código por contador
    ' Para ser usado no caso de o Cdigo ser gerado
    ' e o contador existir na tabela Empresas
    '---------------------------------------------

    'Friend Shared Function GetNovoCodigo() As String

    'Return "C" & ClsEmpresas.GetContador(enCont.CP_Localidades).ToString("000")' <-------------- VERIFICAR O Nº de ZEROS

    'End Function


    ''' <summary>
    '''      Function GetCP_Localidades() Método para devolver a Lista de CP_Localidades
    '''      Gerado em 03/03/2023 15:49:34
    ''' </summary>
    ''' <returns>
    '''      mListaCP_Localidades
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function GetCP_Localidades() As List(Of ClsCP_Localidades)
        Dim mListaCP_Localidades As New List(Of ClsCP_Localidades)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Postal,'') As Cod_Postal,"
        mStrSQL += "ISNULL(Cod_Distrito,'') As Cod_Distrito,"
        mStrSQL += "ISNULL(Cod_Concelho,'') As Cod_Concelho,"
        mStrSQL += "ISNULL(Localidade,'') As Localidade,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM CP_Localidades "
        mStrSQL += "WHERE FLG_Ativo=1"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsCP_Localidades As New ClsCP_Localidades

            With mClsCP_Localidades
                .Cod_Postal = mRDR.GetString(mRDR.GetOrdinal("Cod_Postal"))
                .Cod_Distrito = mRDR.GetString(mRDR.GetOrdinal("Cod_Distrito"))
                .Cod_Concelho = mRDR.GetString(mRDR.GetOrdinal("Cod_Concelho"))
                .Localidade = mRDR.GetString(mRDR.GetOrdinal("Localidade"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaCP_Localidades.Add(mClsCP_Localidades)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaCP_Localidades
    End Function

    ''' <summary>
    '''      Function FiltrarCP_Localidades Método para Filtrar os campos da lista de CP_Localidades
    '''      Gerado em 03/03/2023 15:49:34
    ''' </summary>
    ''' <returns>
    '''      mListaCP_Localidades
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function FiltrarCP_Localidades(ByVal pFiltro As ClsCP_Localidades) As List(Of ClsCP_Localidades)
        Dim mListaCP_Localidades As New List(Of ClsCP_Localidades)
        Dim mLista As New List(Of ClsCP_Localidades)

        mListaCP_Localidades = GetCP_Localidades()

        mLista = mListaCP_Localidades.FindAll(Function(x) _
        x.Cod_Postal.Contains(pFiltro.Cod_Postal)
        )
        '-----------------------------------------------------
        'Pode Colocar em cima mais colunas como esta abaixo...
        '-----------------------------------------------------
        ' AND x.Cod_Distrito.Contains(pFiltro.Cod_Distrito) 

        Return mLista
    End Function


    ''' <summary>
    '''      Function GetCP_LocalidadesByCod(ByVal pCod_Postal As String) Método para decolver uma Classe de CP_Localidades
    '''      Gerado em 03/03/2023 15:49:34
    ''' </summary>
    ''' <returns>
    '''      mClsCP_Localidades
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function GetCP_LocalidadesByCod(ByVal pCod_Postal As String) As ClsCP_Localidades
        Dim mClsCP_Localidades As New ClsCP_Localidades

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Postal", pCod_Postal)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Postal,'') As Cod_Postal,"
        mStrSQL += "ISNULL(Cod_Distrito,'') As Cod_Distrito,"
        mStrSQL += "ISNULL(Cod_Concelho,'') As Cod_Concelho,"
        mStrSQL += "ISNULL(Localidade,'') As Localidade,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM CP_Localidades "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Cod_Postal=@pCod_Postal"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsCP_Localidades
                .Cod_Postal = mRDR.GetString(mRDR.GetOrdinal("Cod_Postal"))
                .Cod_Distrito = mRDR.GetString(mRDR.GetOrdinal("Cod_Distrito"))
                .Cod_Concelho = mRDR.GetString(mRDR.GetOrdinal("Cod_Concelho"))
                .Localidade = mRDR.GetString(mRDR.GetOrdinal("Localidade"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mClsCP_Localidades
    End Function


    ''' <summary>
    '''      Function ModificaCP_Localidades(ByVal pClsCP_Localidades As ClsCP_Localidades) Método para Modificar a TABELA CP_Localidades
    '''      Gerado em 03/03/2023 15:49:34
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function ModificaCP_Localidades(ByVal pClsCP_Localidades As ClsCP_Localidades) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Postal", pClsCP_Localidades.Cod_Postal.Substring(0, IIf(Len(pClsCP_Localidades.Cod_Postal) > 8, 8, Len(pClsCP_Localidades.Cod_Postal))))
        mCMD.Parameters.AddWithValue("@pCod_Distrito", pClsCP_Localidades.Cod_Distrito.Substring(0, IIf(Len(pClsCP_Localidades.Cod_Distrito) > 2, 2, Len(pClsCP_Localidades.Cod_Distrito))))
        mCMD.Parameters.AddWithValue("@pCod_Concelho", pClsCP_Localidades.Cod_Concelho.Substring(0, IIf(Len(pClsCP_Localidades.Cod_Concelho) > 2, 2, Len(pClsCP_Localidades.Cod_Concelho))))
        mCMD.Parameters.AddWithValue("@pLocalidade", pClsCP_Localidades.Localidade.Substring(0, IIf(Len(pClsCP_Localidades.Localidade) > 50, 50, Len(pClsCP_Localidades.Localidade))))


        mStrSQL = "UPDATE CP_Localidades SET "
        mStrSQL += "Cod_Distrito=@pCod_Distrito,"
        mStrSQL += "Cod_Concelho=@pCod_Concelho,"
        mStrSQL += "Localidade=@pLocalidade "
        mStrSQL += "WHERE Cod_Postal=@pCod_Postal"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ModificaCP_Localidades:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function GravaCP_Localidades(ByVal pNovoCP_Localidades As ClsCP_Localidades) Método para Gravar a TABELA CP_Localidades
    '''      Gerado em 03/03/2023 15:49:34
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function GravaCP_Localidades(ByVal pNovoCP_Localidades As ClsCP_Localidades) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()


        mCMD.Parameters.AddWithValue("@pCod_Postal", pNovoCP_Localidades.Cod_Postal.Substring(0, IIf(Len(pNovoCP_Localidades.Cod_Postal) > 8, 8, Len(pNovoCP_Localidades.Cod_Postal))))
        mCMD.Parameters.AddWithValue("@pCod_Distrito", pNovoCP_Localidades.Cod_Distrito.Substring(0, IIf(Len(pNovoCP_Localidades.Cod_Distrito) > 2, 2, Len(pNovoCP_Localidades.Cod_Distrito))))
        mCMD.Parameters.AddWithValue("@pCod_Concelho", pNovoCP_Localidades.Cod_Concelho.Substring(0, IIf(Len(pNovoCP_Localidades.Cod_Concelho) > 2, 2, Len(pNovoCP_Localidades.Cod_Concelho))))
        mCMD.Parameters.AddWithValue("@pLocalidade", pNovoCP_Localidades.Localidade.Substring(0, IIf(Len(pNovoCP_Localidades.Localidade) > 50, 50, Len(pNovoCP_Localidades.Localidade))))
        mCMD.Parameters.AddWithValue("@pFLG_Ativo", pNovoCP_Localidades.FLG_Ativo)


        mStrSQL = "INSERT INTO CP_Localidades "
        mStrSQL += "("
        mStrSQL += "Cod_Postal,"
        mStrSQL += "Cod_Distrito,"
        mStrSQL += "Cod_Concelho,"
        mStrSQL += "Localidade,"
        mStrSQL += "FLG_Ativo "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        mStrSQL += "@pCod_Postal,"
        mStrSQL += "@pCod_Distrito,"
        mStrSQL += "@pCod_Concelho,"
        mStrSQL += "@pLocalidade,"
        mStrSQL += "1"
        mStrSQL += ")"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
            'ClsEmpresas.GravaContador(enCont.CP_Localidades)'<<<<-------- Verificar se é  preciso...
        Catch ex As Exception
            MsgBox("GravaCP_Localidades:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function ApagaCP_Localidades(ByVal pCod_Postal As String) Método para Apagar um Registo da Tabela CP_Localidades
    '''      Gerado em 03/03/2023 15:49:34
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function ApagaCP_Localidades(ByVal pCod_Postal As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pCod_Postal", pCod_Postal)


        mStrSQL = "UPDATE CP_Localidades SET "
        mStrSQL += "FLG_Ativo=0 "
        mStrSQL += "WHERE Cod_Postal=@pCod_Postal"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ApagaCP_Localidades:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function
End Class



''' <summary>
'''      Classe CP_LocalidadesComparer 
'''      Gerado em 03/03/2023 15:49:34
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2023
''' </remarks>
Public Class CP_LocalidadesComparer
    Implements IEqualityComparer(Of ClsCP_Localidades)

    Public Function Equals1(ByVal x As ClsCP_Localidades, ByVal y As ClsCP_Localidades) As Boolean Implements IEqualityComparer(Of ClsCP_Localidades).Equals

        If x Is y Then Return True

        If x Is Nothing OrElse y Is Nothing Then Return False

        Return (x.Cod_Postal = y.Cod_Postal) ' AndAlso (x.Cod_Distrito = y.Cod_Distrito)
    End Function

    Public Function GetHashCode1(ByVal pCls As ClsCP_Localidades) As Integer Implements IEqualityComparer(Of ClsCP_Localidades).GetHashCode

        If pCls Is Nothing Then Return 0

        'Dim Hash_ClsCP_Localidades_Cod_Distrito = pCls.Cod_Distrito.GetHashCode()
        Dim Hash_ClsCP_Localidades_Cod_Postal = pCls.Cod_Postal.GetHashCode()

        Return Hash_ClsCP_Localidades_Cod_Postal 'Xor Hash_ClsCP_Localidades_Cod_Distrito
    End Function
End Class
