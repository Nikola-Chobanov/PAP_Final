
Imports System.Data.SqlClient


''' <summary>
'''      Classe ClsPaises Classe da Tabela Paises
'''      Gerado em 29/11/2022 14:12:54
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2022
''' </remarks>
Public Class ClsPaises


    ' -----------------------------------------
    ' Property's da tabela Paises
    ' -----------------------------------------

    Public Property Cod_Pais As String                                      ' Len:  2 - SQL_Type: nvarchar
    Public Property Pais As String                                          ' Len: 50 - SQL_Type: nvarchar
    Public Property FLG_Ativo As Boolean                                    ' SQL_Type: bit


    Sub New()
    End Sub


    '--------------------------------------------
    ' Exemplo de criador de Código por contador
    ' Para ser usado no caso de o Cdigo ser gerado
    ' e o contador existir na tabela Empresas
    '---------------------------------------------

    'Friend Shared Function GetNovoCodigo() As String

    'Return "P" & ClsEmpresas.GetContador(enCont.Paises).ToString("000")' <-------------- VERIFICAR O Nº de ZEROS

    'End Function


    ''' <summary>
    '''      Function GetPaises() Método para devolver a Lista de Paises
    '''      Gerado em 29/11/2022 14:12:54
    ''' </summary>
    ''' <returns>
    '''      mListaPaises
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function GetPaises() As List(Of ClsPaises)
        Dim mListaPaises As New List(Of ClsPaises)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Pais,'') As Cod_Pais,"
        mStrSQL += "ISNULL(Pais,'') As Pais,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Paises "
        mStrSQL += "WHERE FLG_Ativo=1"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsPaises As New ClsPaises

            With mClsPaises
                .Cod_Pais = mRDR.GetString(mRDR.GetOrdinal("Cod_Pais"))
                .Pais = mRDR.GetString(mRDR.GetOrdinal("Pais"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaPaises.Add(mClsPaises)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaPaises
    End Function

    ''' <summary>
    '''      Function FiltrarPaises Método para Filtrar os campos da lista de Paises
    '''      Gerado em 29/11/2022 14:12:54
    ''' </summary>
    ''' <returns>
    '''      mListaPaises
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function FiltrarPaises(ByVal pFiltro As ClsPaises) As List(Of ClsPaises)
        Dim mListaPaises As New List(Of ClsPaises)
        Dim mLista As New List(Of ClsPaises)

        mListaPaises = GetPaises()

        mLista = mListaPaises.FindAll(Function(x) _
        x.Cod_Pais.Contains(pFiltro.Cod_Pais)
        )
        '-----------------------------------------------------
        'Pode Colocar em cima mais colunas como esta abaixo...
        '-----------------------------------------------------
        ' AND x.Pais.Contains(pFiltro.Pais) 

        Return mLista
    End Function


    ''' <summary>
    '''      Function GetPaisesByCod(ByVal pCod_Pais As String) Método para decolver uma Classe de Paises
    '''      Gerado em 29/11/2022 14:12:54
    ''' </summary>
    ''' <returns>
    '''      mClsPaises
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function GetPaisesByCod(ByVal pCod_Pais As String) As ClsPaises
        Dim mClsPaises As New ClsPaises

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Pais", pCod_Pais)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Pais,'') As Cod_Pais,"
        mStrSQL += "ISNULL(Pais,'') As Pais,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Paises "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Cod_Pais=@pCod_Pais"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsPaises
                .Cod_Pais = mRDR.GetString(mRDR.GetOrdinal("Cod_Pais"))
                .Pais = mRDR.GetString(mRDR.GetOrdinal("Pais"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mClsPaises
    End Function


    ''' <summary>
    '''      Function ModificaPaises(ByVal pClsPaises As ClsPaises) Método para Modificar a TABELA Paises
    '''      Gerado em 29/11/2022 14:12:54
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function ModificaPaises(ByVal pClsPaises As ClsPaises) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Pais", pClsPaises.Cod_Pais.Substring(0, IIf(Len(pClsPaises.Cod_Pais) > 2, 2, Len(pClsPaises.Cod_Pais))))
        mCMD.Parameters.AddWithValue("@pPais", pClsPaises.Pais.Substring(0, IIf(Len(pClsPaises.Pais) > 50, 50, Len(pClsPaises.Pais))))


        mStrSQL = "UPDATE Paises SET "
        mStrSQL += "Pais=@pPais "
        mStrSQL += "WHERE Cod_Pais=@pCod_Pais"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ModificaPaises:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function GravaPaises(ByVal pNovoPaises As ClsPaises) Método para Gravar a TABELA Paises
    '''      Gerado em 29/11/2022 14:12:54
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function GravaPaises(ByVal pNovoPaises As ClsPaises) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()


        mCMD.Parameters.AddWithValue("@pCod_Pais", pNovoPaises.Cod_Pais.Substring(0, IIf(Len(pNovoPaises.Cod_Pais) > 2, 2, Len(pNovoPaises.Cod_Pais))))
        mCMD.Parameters.AddWithValue("@pPais", pNovoPaises.Pais.Substring(0, IIf(Len(pNovoPaises.Pais) > 50, 50, Len(pNovoPaises.Pais))))
        mCMD.Parameters.AddWithValue("@pFLG_Ativo", pNovoPaises.FLG_Ativo)


        mStrSQL = "INSERT INTO Paises "
        mStrSQL += "("
        mStrSQL += "Cod_Pais,"
        mStrSQL += "Pais,"
        mStrSQL += "FLG_Ativo "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        mStrSQL += "@pCod_Pais,"
        mStrSQL += "@pPais,"
        mStrSQL += "1"
        mStrSQL += ")"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
            'ClsEmpresas.GravaContador(enCont.Paises)'<<<<-------- Verificar se é  preciso...
        Catch ex As Exception
            MsgBox("GravaPaises:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function ApagaPaises(ByVal pCod_Pais As String) Método para Apagar um Registo da Tabela Paises
    '''      Gerado em 29/11/2022 14:12:54
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function ApagaPaises(ByVal pCod_Pais As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pCod_Pais", pCod_Pais)


        mStrSQL = "UPDATE Paises SET "
        mStrSQL += "FLG_Ativo=0 "
        mStrSQL += "WHERE Cod_Pais=@pCod_Pais"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ApagaPaises:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function
End Class



''' <summary>
'''      Classe PaisesComparer 
'''      Gerado em 29/11/2022 14:12:54
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2022
''' </remarks>
Public Class PaisesComparer
    Implements IEqualityComparer(Of ClsPaises)

    Public Function Equals1(ByVal x As ClsPaises, ByVal y As ClsPaises) As Boolean Implements IEqualityComparer(Of ClsPaises).Equals

        If x Is y Then Return True

        If x Is Nothing OrElse y Is Nothing Then Return False

        Return (x.Cod_Pais = y.Cod_Pais) ' AndAlso (x.Pais = y.Pais)
    End Function

    Public Function GetHashCode1(ByVal pCls As ClsPaises) As Integer Implements IEqualityComparer(Of ClsPaises).GetHashCode

        If pCls Is Nothing Then Return 0

        'Dim Hash_ClsPaises_Pais = pCls.Pais.GetHashCode()
        Dim Hash_ClsPaises_Cod_Pais = pCls.Cod_Pais.GetHashCode()

        Return Hash_ClsPaises_Cod_Pais 'Xor Hash_ClsPaises_Pais
    End Function
End Class
