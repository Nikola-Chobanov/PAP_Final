
Imports System.Data.SqlClient


''' <summary>
'''      Classe ClsPT_Enderecos Classe da Tabela PT_Enderecos
'''      Gerado em 29/11/2022 14:12:54
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2022
''' </remarks>
Public Class ClsPT_Enderecos


    ' -----------------------------------------
    ' Property's da tabela PT_Enderecos
    ' -----------------------------------------

    Public Property Cod_Distrito As String                                  ' Len:  2 - SQL_Type: nvarchar
    Public Property Cod_Concelho As String                                  ' Len:  2 - SQL_Type: nvarchar
    Public Property Cod_Postal As String                                    ' Len:  8 - SQL_Type: nvarchar
    Public Property Endereco As String                                      ' Len:100 - SQL_Type: nvarchar
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

    'Return "P" & ClsEmpresas.GetContador(enCont.PT_Enderecos).ToString("000")' <-------------- VERIFICAR O Nº de ZEROS

    'End Function


    ''' <summary>
    '''      Function GetPT_Enderecos() Método para devolver a Lista de PT_Enderecos
    '''      Gerado em 29/11/2022 14:12:54
    ''' </summary>
    ''' <returns>
    '''      mListaPT_Enderecos
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function GetPT_Enderecos() As List(Of ClsPT_Enderecos)
        Dim mListaPT_Enderecos As New List(Of ClsPT_Enderecos)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Distrito,'') As Cod_Distrito,"
        mStrSQL += "ISNULL(Cod_Concelho,'') As Cod_Concelho,"
        mStrSQL += "ISNULL(Cod_Postal,'') As Cod_Postal,"
        mStrSQL += "ISNULL(Endereco,'') As Endereco,"
        mStrSQL += "ISNULL(Localidade,'') As Localidade,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM PT_Enderecos "
        mStrSQL += "WHERE FLG_Ativo=1"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsPT_Enderecos As New ClsPT_Enderecos

            With mClsPT_Enderecos
                .Cod_Distrito = mRDR.GetString(mRDR.GetOrdinal("Cod_Distrito"))
                .Cod_Concelho = mRDR.GetString(mRDR.GetOrdinal("Cod_Concelho"))
                .Cod_Postal = mRDR.GetString(mRDR.GetOrdinal("Cod_Postal"))
                .Endereco = mRDR.GetString(mRDR.GetOrdinal("Endereco"))
                .Localidade = mRDR.GetString(mRDR.GetOrdinal("Localidade"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaPT_Enderecos.Add(mClsPT_Enderecos)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaPT_Enderecos
    End Function

    ''' <summary>
    '''      Function FiltrarPT_Enderecos Método para Filtrar os campos da lista de PT_Enderecos
    '''      Gerado em 29/11/2022 14:12:54
    ''' </summary>
    ''' <returns>
    '''      mListaPT_Enderecos
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function FiltrarPT_Enderecos(ByVal pFiltro As ClsPT_Enderecos) As List(Of ClsPT_Enderecos)
        Dim mListaPT_Enderecos As New List(Of ClsPT_Enderecos)
        Dim mLista As New List(Of ClsPT_Enderecos)

        mListaPT_Enderecos = GetPT_Enderecos()

        mLista = mListaPT_Enderecos.FindAll(Function(x) _
        x.Cod_Distrito.Contains(pFiltro.Cod_Distrito)
        )
        '-----------------------------------------------------
        'Pode Colocar em cima mais colunas como esta abaixo...
        '-----------------------------------------------------
        ' AND x.Cod_Concelho.Contains(pFiltro.Cod_Concelho) 

        Return mLista
    End Function


    ''' <summary>
    '''      Function GetPT_EnderecosByCod(ByVal pCod_Distrito As String) Método para decolver uma Classe de PT_Enderecos
    '''      Gerado em 29/11/2022 14:12:54
    ''' </summary>
    ''' <returns>
    '''      mClsPT_Enderecos
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function GetPT_EnderecosByCod(ByVal pCod_Distrito As String) As ClsPT_Enderecos
        Dim mClsPT_Enderecos As New ClsPT_Enderecos

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
        mStrSQL += "ISNULL(Cod_Postal,'') As Cod_Postal,"
        mStrSQL += "ISNULL(Endereco,'') As Endereco,"
        mStrSQL += "ISNULL(Localidade,'') As Localidade,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM PT_Enderecos "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Cod_Distrito=@pCod_Distrito"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsPT_Enderecos
                .Cod_Distrito = mRDR.GetString(mRDR.GetOrdinal("Cod_Distrito"))
                .Cod_Concelho = mRDR.GetString(mRDR.GetOrdinal("Cod_Concelho"))
                .Cod_Postal = mRDR.GetString(mRDR.GetOrdinal("Cod_Postal"))
                .Endereco = mRDR.GetString(mRDR.GetOrdinal("Endereco"))
                .Localidade = mRDR.GetString(mRDR.GetOrdinal("Localidade"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mClsPT_Enderecos
    End Function


    ''' <summary>
    '''      Function ModificaPT_Enderecos(ByVal pClsPT_Enderecos As ClsPT_Enderecos) Método para Modificar a TABELA PT_Enderecos
    '''      Gerado em 29/11/2022 14:12:54
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function ModificaPT_Enderecos(ByVal pClsPT_Enderecos As ClsPT_Enderecos) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Distrito", pClsPT_Enderecos.Cod_Distrito.Substring(0, IIf(Len(pClsPT_Enderecos.Cod_Distrito) > 2, 2, Len(pClsPT_Enderecos.Cod_Distrito))))
        mCMD.Parameters.AddWithValue("@pCod_Concelho", pClsPT_Enderecos.Cod_Concelho.Substring(0, IIf(Len(pClsPT_Enderecos.Cod_Concelho) > 2, 2, Len(pClsPT_Enderecos.Cod_Concelho))))
        mCMD.Parameters.AddWithValue("@pCod_Postal", pClsPT_Enderecos.Cod_Postal.Substring(0, IIf(Len(pClsPT_Enderecos.Cod_Postal) > 8, 8, Len(pClsPT_Enderecos.Cod_Postal))))
        mCMD.Parameters.AddWithValue("@pEndereco", pClsPT_Enderecos.Endereco.Substring(0, IIf(Len(pClsPT_Enderecos.Endereco) > 100, 100, Len(pClsPT_Enderecos.Endereco))))
        mCMD.Parameters.AddWithValue("@pLocalidade", pClsPT_Enderecos.Localidade.Substring(0, IIf(Len(pClsPT_Enderecos.Localidade) > 50, 50, Len(pClsPT_Enderecos.Localidade))))


        mStrSQL = "UPDATE PT_Enderecos SET "
        mStrSQL += "Cod_Concelho=@pCod_Concelho,"
        mStrSQL += "Cod_Postal=@pCod_Postal,"
        mStrSQL += "Endereco=@pEndereco,"
        mStrSQL += "Localidade=@pLocalidade "
        mStrSQL += "WHERE Cod_Distrito=@pCod_Distrito"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ModificaPT_Enderecos:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function GravaPT_Enderecos(ByVal pNovoPT_Enderecos As ClsPT_Enderecos) Método para Gravar a TABELA PT_Enderecos
    '''      Gerado em 29/11/2022 14:12:54
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function GravaPT_Enderecos(ByVal pNovoPT_Enderecos As ClsPT_Enderecos) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()


        mCMD.Parameters.AddWithValue("@pCod_Distrito", pNovoPT_Enderecos.Cod_Distrito.Substring(0, IIf(Len(pNovoPT_Enderecos.Cod_Distrito) > 2, 2, Len(pNovoPT_Enderecos.Cod_Distrito))))
        mCMD.Parameters.AddWithValue("@pCod_Concelho", pNovoPT_Enderecos.Cod_Concelho.Substring(0, IIf(Len(pNovoPT_Enderecos.Cod_Concelho) > 2, 2, Len(pNovoPT_Enderecos.Cod_Concelho))))
        mCMD.Parameters.AddWithValue("@pCod_Postal", pNovoPT_Enderecos.Cod_Postal.Substring(0, IIf(Len(pNovoPT_Enderecos.Cod_Postal) > 8, 8, Len(pNovoPT_Enderecos.Cod_Postal))))
        mCMD.Parameters.AddWithValue("@pEndereco", pNovoPT_Enderecos.Endereco.Substring(0, IIf(Len(pNovoPT_Enderecos.Endereco) > 100, 100, Len(pNovoPT_Enderecos.Endereco))))
        mCMD.Parameters.AddWithValue("@pLocalidade", pNovoPT_Enderecos.Localidade.Substring(0, IIf(Len(pNovoPT_Enderecos.Localidade) > 50, 50, Len(pNovoPT_Enderecos.Localidade))))
        mCMD.Parameters.AddWithValue("@pFLG_Ativo", pNovoPT_Enderecos.FLG_Ativo)


        mStrSQL = "INSERT INTO PT_Enderecos "
        mStrSQL += "("
        mStrSQL += "Cod_Distrito,"
        mStrSQL += "Cod_Concelho,"
        mStrSQL += "Cod_Postal,"
        mStrSQL += "Endereco,"
        mStrSQL += "Localidade,"
        mStrSQL += "FLG_Ativo "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        mStrSQL += "@pCod_Distrito,"
        mStrSQL += "@pCod_Concelho,"
        mStrSQL += "@pCod_Postal,"
        mStrSQL += "@pEndereco,"
        mStrSQL += "@pLocalidade,"
        mStrSQL += "1"
        mStrSQL += ")"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
            'ClsEmpresas.GravaContador(enCont.PT_Enderecos)'<<<<-------- Verificar se é  preciso...
        Catch ex As Exception
            MsgBox("GravaPT_Enderecos:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function ApagaPT_Enderecos(ByVal pCod_Distrito As String) Método para Apagar um Registo da Tabela PT_Enderecos
    '''      Gerado em 29/11/2022 14:12:54
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function ApagaPT_Enderecos(ByVal pCod_Distrito As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pCod_Distrito", pCod_Distrito)


        mStrSQL = "UPDATE PT_Enderecos SET "
        mStrSQL += "FLG_Ativo=0 "
        mStrSQL += "WHERE Cod_Distrito=@pCod_Distrito"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ApagaPT_Enderecos:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function
End Class



''' <summary>
'''      Classe PT_EnderecosComparer 
'''      Gerado em 29/11/2022 14:12:54
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2022
''' </remarks>
Public Class PT_EnderecosComparer
    Implements IEqualityComparer(Of ClsPT_Enderecos)

    Public Function Equals1(ByVal x As ClsPT_Enderecos, ByVal y As ClsPT_Enderecos) As Boolean Implements IEqualityComparer(Of ClsPT_Enderecos).Equals

        If x Is y Then Return True

        If x Is Nothing OrElse y Is Nothing Then Return False

        Return (x.Cod_Distrito = y.Cod_Distrito) ' AndAlso (x.Cod_Concelho = y.Cod_Concelho)
    End Function

    Public Function GetHashCode1(ByVal pCls As ClsPT_Enderecos) As Integer Implements IEqualityComparer(Of ClsPT_Enderecos).GetHashCode

        If pCls Is Nothing Then Return 0

        'Dim Hash_ClsPT_Enderecos_Cod_Concelho = pCls.Cod_Concelho.GetHashCode()
        Dim Hash_ClsPT_Enderecos_Cod_Distrito = pCls.Cod_Distrito.GetHashCode()

        Return Hash_ClsPT_Enderecos_Cod_Distrito 'Xor Hash_ClsPT_Enderecos_Cod_Concelho
    End Function
End Class
