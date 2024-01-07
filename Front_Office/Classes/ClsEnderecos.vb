
Imports System.Data.SqlClient


''' <summary>
'''      Classe ClsEnderecos Classe da Tabela Enderecos
'''      Gerado em 29/11/2022 14:12:54
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2022
''' </remarks>
Public Class ClsEnderecos


    ' -----------------------------------------
    ' Property's da tabela Enderecos
    ' -----------------------------------------

    Public Property Cod_Entidade As String                                  ' Len:  5 - SQL_Type: nvarchar
    Public Property Cod_Endereco As String                                  ' Len:  5 - SQL_Type: nvarchar
    Public Property Descritivo As String                                    ' Len: 30 - SQL_Type: nvarchar
    Public Property Endereco As String                                      ' Len:120 - SQL_Type: nvarchar
    Public Property Cod_Postal As String                                    ' Len:  9 - SQL_Type: nvarchar
    Public Property Localidade As String                                    ' Len: 50 - SQL_Type: nvarchar
    Public Property Data_Registo As Date                                    ' SQL_Type: smalldatetime
    Public Property FLG_Ativo As Boolean                                    ' SQL_Type: bit


    Sub New()
    End Sub


    '--------------------------------------------
    ' Exemplo de criador de Código por contador
    ' Para ser usado no caso de o Cdigo ser gerado
    ' e o contador existir na tabela Empresas
    '---------------------------------------------

    Friend Shared Function GetNovoCodigo(ByVal pCodEntidade As String) As String
        Dim mReturn As Integer = 0

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Entidade", pCodEntidade)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Endereco,'') As Cod_Endereco "
        mStrSQL += "FROM Enderecos "
        mStrSQL += "WHERE Cod_Entidade=@pCod_Entidade"

        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()
            mReturn += 1

        End While


        Return "E00" & mReturn + 1
    End Function


    ''' <summary>
    '''      Function GetEnderecos() Método para devolver a Lista de Enderecos
    '''      Gerado em 29/11/2022 14:12:54
    ''' </summary>
    ''' <returns>
    '''      mListaEnderecos
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function GetEnderecos(ByVal pCod_Entidade As String) As List(Of ClsEnderecos)
        Dim mListaEnderecos As New List(Of ClsEnderecos)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Entidade", pCod_Entidade)

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Entidade,'') As Cod_Entidade,"
        mStrSQL += "ISNULL(Cod_Endereco,'') As Cod_Endereco,"
        mStrSQL += "ISNULL(Descritivo,'') As Descritivo,"
        mStrSQL += "ISNULL(Endereco,'') As Endereco,"
        mStrSQL += "ISNULL(Cod_Postal,'') As Cod_Postal,"
        mStrSQL += "ISNULL(Localidade,'') As Localidade,"
        mStrSQL += "ISNULL(Data_Registo,getdate()) As Data_Registo,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Enderecos "
        mStrSQL += "WHERE Cod_Entidade = @pCod_Entidade"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsEnderecos As New ClsEnderecos

            With mClsEnderecos
                .Cod_Entidade = mRDR.GetString(mRDR.GetOrdinal("Cod_Entidade"))
                .Cod_Endereco = mRDR.GetString(mRDR.GetOrdinal("Cod_Endereco"))
                .Descritivo = mRDR.GetString(mRDR.GetOrdinal("Descritivo"))
                .Endereco = mRDR.GetString(mRDR.GetOrdinal("Endereco"))
                .Cod_Postal = mRDR.GetString(mRDR.GetOrdinal("Cod_Postal"))
                .Localidade = mRDR.GetString(mRDR.GetOrdinal("Localidade"))
                .Data_Registo = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Registo"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaEnderecos.Add(mClsEnderecos)

        End While

        Dim mCount As Integer = mListaEnderecos.Count

        For n As Integer = mCount To (20 + (mCount - 1))
            Dim mEndereco As New ClsEnderecos()
            With mEndereco
                .Cod_Entidade = pCod_Entidade
                .Cod_Endereco = "E" & (n + 1).ToString("00")
                .Descritivo = ""
                .Endereco = ""
                .Cod_Postal = ""
                .Localidade = ""
                .Data_Registo = Date.Now
                .FLG_Ativo = True

            End With
            mListaEnderecos.Add(mEndereco)
        Next


        mRDR.Close()
        mDB.Close()

        Return mListaEnderecos
    End Function

    ''' <summary>
    '''      Function FiltrarEnderecos Método para Filtrar os campos da lista de Enderecos
    '''      Gerado em 29/11/2022 14:12:54
    ''' </summary>
    ''' <returns>
    '''      mListaEnderecos
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>

    'Public Shared Function FiltrarEnderecos(ByVal pFiltro As ClsEnderecos) As List(Of ClsEnderecos)
    '    Dim mListaEnderecos As New List(Of ClsEnderecos)
    '    Dim mLista As New List(Of ClsEnderecos)

    '    mListaEnderecos = GetEnderecos()

    '    mLista = mListaEnderecos.FindAll(Function(x) x.Cod_Entidade.Contains(pFiltro.Cod_Entidade)
    '    )
    '    '-----------------------------------------------------
    '    'Pode Colocar em cima mais colunas como esta abaixo...
    '    '-----------------------------------------------------
    '    ' AND x.Cod_Endereco.Contains(pFiltro.Cod_Endereco) 

    '    Return mLista
    'End Function


    ''' <summary>
    '''      Function GetEnderecosByCod(ByVal pCod_Entidade As String) Método para decolver uma Classe de Enderecos
    '''      Gerado em 29/11/2022 14:12:54
    ''' </summary>
    ''' <returns>
    '''      mClsEnderecos
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function GetEnderecosByCod(ByVal pCod_Entidade As String, ByVal pCod_Endereco As String) As ClsEnderecos
        Dim mListaEnderecos As New ClsEnderecos

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Entidade", pCod_Entidade)
        mCMD.Parameters.AddWithValue("@pCod_Endereco", pCod_Endereco)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Entidade,'') As Cod_Entidade,"
        mStrSQL += "ISNULL(Cod_Endereco,'') As Cod_Endereco,"
        mStrSQL += "ISNULL(Descritivo,'') As Descritivo,"
        mStrSQL += "ISNULL(Endereco,'') As Endereco,"
        mStrSQL += "ISNULL(Cod_Postal,'') As Cod_Postal,"
        mStrSQL += "ISNULL(Localidade,'') As Localidade,"
        mStrSQL += "ISNULL(Data_Registo,getdate()) As Data_Registo,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Enderecos "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Cod_Entidade=@pCod_Entidade "
        mStrSQL += "AND Cod_Endereco=@pCod_Endereco"



        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then

            With mListaEnderecos
                .Cod_Entidade = mRDR.GetString(mRDR.GetOrdinal("Cod_Entidade"))
                .Cod_Endereco = mRDR.GetString(mRDR.GetOrdinal("Cod_Endereco"))
                .Descritivo = mRDR.GetString(mRDR.GetOrdinal("Descritivo"))
                .Endereco = mRDR.GetString(mRDR.GetOrdinal("Endereco"))
                .Cod_Postal = mRDR.GetString(mRDR.GetOrdinal("Cod_Postal"))
                .Localidade = mRDR.GetString(mRDR.GetOrdinal("Localidade"))
                .Data_Registo = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Registo"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mListaEnderecos
    End Function


    ''' <summary>
    '''      Function ModificaEnderecos(ByVal pClsEnderecos As ClsEnderecos) Método para Modificar a TABELA Enderecos
    '''      Gerado em 29/11/2022 14:12:54
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    ''' 
    Public Shared Function ModificaEnderecos(ByVal pClsEnderecos As ClsEnderecos) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Entidade", pClsEnderecos.Cod_Entidade.Substring(0, IIf(Len(pClsEnderecos.Cod_Entidade) > 5, 5, Len(pClsEnderecos.Cod_Entidade))))
        mCMD.Parameters.AddWithValue("@pCod_Endereco", pClsEnderecos.Cod_Endereco.Substring(0, IIf(Len(pClsEnderecos.Cod_Endereco) > 5, 5, Len(pClsEnderecos.Cod_Endereco))))
        mCMD.Parameters.AddWithValue("@pDescritivo", pClsEnderecos.Descritivo.Substring(0, IIf(Len(pClsEnderecos.Descritivo) > 30, 30, Len(pClsEnderecos.Descritivo))))
        mCMD.Parameters.AddWithValue("@pEndereco", pClsEnderecos.Endereco.Substring(0, IIf(Len(pClsEnderecos.Endereco) > 120, 120, Len(pClsEnderecos.Endereco))))
        mCMD.Parameters.AddWithValue("@pCod_Postal", pClsEnderecos.Cod_Postal.Substring(0, IIf(Len(pClsEnderecos.Cod_Postal) > 9, 9, Len(pClsEnderecos.Cod_Postal))))
        mCMD.Parameters.AddWithValue("@pLocalidade", pClsEnderecos.Localidade.Substring(0, IIf(Len(pClsEnderecos.Localidade) > 50, 50, Len(pClsEnderecos.Localidade))))
        mCMD.Parameters.AddWithValue("@pData_Registo", pClsEnderecos.Data_Registo)


        mStrSQL = "UPDATE Enderecos SET "
        mStrSQL += "Cod_Endereco=@pCod_Endereco,"
        mStrSQL += "Descritivo=@pDescritivo,"
        mStrSQL += "Endereco=@pEndereco,"
        mStrSQL += "Cod_Postal=@pCod_Postal,"
        mStrSQL += "Localidade=@pLocalidade,"
        mStrSQL += "Data_Registo=@pData_Registo "
        mStrSQL += "WHERE Cod_Entidade=@pCod_Entidade "
        mStrSQL += "AND Cod_Endereco=@pCod_Endereco"



        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ModificaEnderecos:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function GravaEnderecos(ByVal pNovoEnderecos As ClsEnderecos) Método para Gravar a TABELA Enderecos
    '''      Gerado em 29/11/2022 14:12:54
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function GravaEnderecos(ByVal pNovoEnderecos As ClsEnderecos) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()


        mCMD.Parameters.AddWithValue("@pCod_Entidade", pNovoEnderecos.Cod_Entidade.Substring(0, IIf(Len(pNovoEnderecos.Cod_Entidade) > 5, 5, Len(pNovoEnderecos.Cod_Entidade))))
        mCMD.Parameters.AddWithValue("@pCod_Endereco", pNovoEnderecos.Cod_Endereco.Substring(0, IIf(Len(pNovoEnderecos.Cod_Endereco) > 5, 5, Len(pNovoEnderecos.Cod_Endereco))))
        mCMD.Parameters.AddWithValue("@pDescritivo", pNovoEnderecos.Descritivo.Substring(0, IIf(Len(pNovoEnderecos.Descritivo) > 30, 30, Len(pNovoEnderecos.Descritivo))))
        mCMD.Parameters.AddWithValue("@pEndereco", pNovoEnderecos.Endereco.Substring(0, IIf(Len(pNovoEnderecos.Endereco) > 120, 120, Len(pNovoEnderecos.Endereco))))
        mCMD.Parameters.AddWithValue("@pCod_Postal", pNovoEnderecos.Cod_Postal.Substring(0, IIf(Len(pNovoEnderecos.Cod_Postal) > 9, 9, Len(pNovoEnderecos.Cod_Postal))))
        mCMD.Parameters.AddWithValue("@pLocalidade", pNovoEnderecos.Localidade.Substring(0, IIf(Len(pNovoEnderecos.Localidade) > 50, 50, Len(pNovoEnderecos.Localidade))))
        mCMD.Parameters.AddWithValue("@pData_Registo", pNovoEnderecos.Data_Registo)
        mCMD.Parameters.AddWithValue("@pFLG_Ativo", pNovoEnderecos.FLG_Ativo)


        mStrSQL = "INSERT INTO Enderecos "
        mStrSQL += "("
        mStrSQL += "Cod_Entidade,"
        mStrSQL += "Cod_Endereco,"
        mStrSQL += "Descritivo,"
        mStrSQL += "Endereco,"
        mStrSQL += "Cod_Postal,"
        mStrSQL += "Localidade,"
        mStrSQL += "Data_Registo,"
        mStrSQL += "FLG_Ativo "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        mStrSQL += "@pCod_Entidade,"
        mStrSQL += "@pCod_Endereco,"
        mStrSQL += "@pDescritivo,"
        mStrSQL += "@pEndereco,"
        mStrSQL += "@pCod_Postal,"
        mStrSQL += "@pLocalidade,"
        mStrSQL += "@pData_Registo,"
        mStrSQL += "1"
        mStrSQL += ")"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
            'ClsEmpresas.GravaContador(enCont.Enderecos)'<<<<-------- Verificar se é  preciso...
        Catch ex As Exception
            MsgBox("GravaEnderecos:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function ApagaEnderecos(ByVal pCod_Entidade As String) Método para Apagar um Registo da Tabela Enderecos
    '''      Gerado em 29/11/2022 14:12:54
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function ApagaEnderecos(ByVal pCod_Entidade As String, ByVal pCod_Endereco As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pCod_Entidade", pCod_Entidade)
        mCMD.Parameters.AddWithValue("@pCod_Endereco", pCod_Endereco)


        mStrSQL = "UPDATE Enderecos SET "
        mStrSQL += "FLG_Ativo=0 "
        mStrSQL += "WHERE Cod_Entidade=@pCod_Entidade "
        mStrSQL += "AND Cod_Endereco=@pCod_Endereco"



        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ApagaEnderecos:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function
End Class



''' <summary>
'''      Classe EnderecosComparer 
'''      Gerado em 29/11/2022 14:12:54
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2022
''' </remarks>
Public Class EnderecosComparer
    Implements IEqualityComparer(Of ClsEnderecos)

    Public Function Equals1(ByVal x As ClsEnderecos, ByVal y As ClsEnderecos) As Boolean Implements IEqualityComparer(Of ClsEnderecos).Equals

        If x Is y Then Return True

        If x Is Nothing OrElse y Is Nothing Then Return False

        Return (x.Cod_Entidade = y.Cod_Entidade) ' AndAlso (x.Cod_Endereco = y.Cod_Endereco)
    End Function

    Public Function GetHashCode1(ByVal pCls As ClsEnderecos) As Integer Implements IEqualityComparer(Of ClsEnderecos).GetHashCode

        If pCls Is Nothing Then Return 0

        'Dim Hash_ClsEnderecos_Cod_Endereco = pCls.Cod_Endereco.GetHashCode()
        Dim Hash_ClsEnderecos_Cod_Entidade = pCls.Cod_Entidade.GetHashCode()

        Return Hash_ClsEnderecos_Cod_Entidade 'Xor Hash_ClsEnderecos_Cod_Endereco
    End Function
End Class
