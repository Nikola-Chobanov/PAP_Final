
Imports System.Data.SqlClient


''' <summary>
'''      Classe ClsRaca_Animais Classe da Tabela Raca_Animais
'''      Gerado em 03/03/2023 15:49:35
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2023
''' </remarks>
Public Class ClsRaca_Animais


    ' -----------------------------------------
    ' Property's da tabela Raca_Animais
    ' -----------------------------------------

    Public Property Cod_Raca As String                                      ' Len:  4 - SQL_Type: nvarchar
    Public Property Raca As String                                          ' Len: 30 - SQL_Type: nvarchar
    Public Property Cod_Tipo_Animal As String                               ' Len:  4 - SQL_Type: nvarchar
    Public Property FLG_Ativo As Boolean                                    ' SQL_Type: bit


    Sub New()
    End Sub


    '--------------------------------------------
    ' Exemplo de criador de Código por contador
    ' Para ser usado no caso de o Cdigo ser gerado
    ' e o contador existir na tabela Empresas
    '---------------------------------------------

    'Friend Shared Function GetNovoCodigo() As String

    'Return "R" & ClsEmpresas.GetContador(enCont.Raca_Animais).ToString("000")' <-------------- VERIFICAR O Nº de ZEROS

    'End Function


    ''' <summary>
    '''      Function GetRaca_Animais() Método para devolver a Lista de Raca_Animais
    '''      Gerado em 03/03/2023 15:49:35
    ''' </summary>
    ''' <returns>
    '''      mListaRaca_Animais
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function GetRaca_Animais() As List(Of ClsRaca_Animais)
        Dim mListaRaca_Animais As New List(Of ClsRaca_Animais)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Raca,'') As Cod_Raca,"
        mStrSQL += "ISNULL(Raca,'') As Raca,"
        mStrSQL += "ISNULL(Cod_Tipo_Animal,'') As Cod_Tipo_Animal,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Raca_Animais "
        mStrSQL += "WHERE FLG_Ativo=1"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsRaca_Animais As New ClsRaca_Animais

            With mClsRaca_Animais
                .Cod_Raca = mRDR.GetString(mRDR.GetOrdinal("Cod_Raca"))
                .Raca = mRDR.GetString(mRDR.GetOrdinal("Raca"))
                .Cod_Tipo_Animal = mRDR.GetString(mRDR.GetOrdinal("Cod_Tipo_Animal"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaRaca_Animais.Add(mClsRaca_Animais)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaRaca_Animais
    End Function

    ''' <summary>
    '''      Function FiltrarRaca_Animais Método para Filtrar os campos da lista de Raca_Animais
    '''      Gerado em 03/03/2023 15:49:35
    ''' </summary>
    ''' <returns>
    '''      mListaRaca_Animais
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function FiltrarRaca_Animais(ByVal pFiltro As ClsRaca_Animais) As List(Of ClsRaca_Animais)
        Dim mListaRaca_Animais As New List(Of ClsRaca_Animais)
        Dim mLista As New List(Of ClsRaca_Animais)

        mListaRaca_Animais = GetRaca_Animais()

        mLista = mListaRaca_Animais.FindAll(Function(x) _
x.Cod_Raca.Contains(pFiltro.Cod_Raca)
)
        '-----------------------------------------------------
        'Pode Colocar em cima mais colunas como esta abaixo...
        '-----------------------------------------------------
        ' AND x.Raca.Contains(pFiltro.Raca) 

        Return mLista
    End Function


    ''' <summary>
    '''      Function GetRaca_AnimaisByCod(ByVal pCod_Raca As String) Método para decolver uma Classe de Raca_Animais
    '''      Gerado em 03/03/2023 15:49:35
    ''' </summary>
    ''' <returns>
    '''      mClsRaca_Animais
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function GetRaca_AnimaisByCod(ByVal pCod_Raca As String) As ClsRaca_Animais
        Dim mClsRaca_Animais As New ClsRaca_Animais

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Raca", pCod_Raca)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Raca,'') As Cod_Raca,"
        mStrSQL += "ISNULL(Raca,'') As Raca,"
        mStrSQL += "ISNULL(Cod_Tipo_Animal,'') As Cod_Tipo_Animal,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Raca_Animais "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Cod_Raca=@pCod_Raca"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsRaca_Animais
                .Cod_Raca = mRDR.GetString(mRDR.GetOrdinal("Cod_Raca"))
                .Raca = mRDR.GetString(mRDR.GetOrdinal("Raca"))
                .Cod_Tipo_Animal = mRDR.GetString(mRDR.GetOrdinal("Cod_Tipo_Animal"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mClsRaca_Animais
    End Function


    ''' <summary>
    '''      Function ModificaRaca_Animais(ByVal pClsRaca_Animais As ClsRaca_Animais) Método para Modificar a TABELA Raca_Animais
    '''      Gerado em 03/03/2023 15:49:35
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function ModificaRaca_Animais(ByVal pClsRaca_Animais As ClsRaca_Animais) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Raca", pClsRaca_Animais.Cod_Raca.Substring(0, IIf(Len(pClsRaca_Animais.Cod_Raca) > 4, 4, Len(pClsRaca_Animais.Cod_Raca))))
        mCMD.Parameters.AddWithValue("@pRaca", pClsRaca_Animais.Raca.Substring(0, IIf(Len(pClsRaca_Animais.Raca) > 30, 30, Len(pClsRaca_Animais.Raca))))
        mCMD.Parameters.AddWithValue("@pCod_Tipo_Animal", pClsRaca_Animais.Cod_Tipo_Animal.Substring(0, IIf(Len(pClsRaca_Animais.Cod_Tipo_Animal) > 4, 4, Len(pClsRaca_Animais.Cod_Tipo_Animal))))


        mStrSQL = "UPDATE Raca_Animais SET "
        mStrSQL += "Raca=@pRaca,"
        mStrSQL += "Cod_Tipo_Animal=@pCod_Tipo_Animal "
        mStrSQL += "WHERE Cod_Raca=@pCod_Raca"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ModificaRaca_Animais:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function GravaRaca_Animais(ByVal pNovoRaca_Animais As ClsRaca_Animais) Método para Gravar a TABELA Raca_Animais
    '''      Gerado em 03/03/2023 15:49:35
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function GravaRaca_Animais(ByVal pNovoRaca_Animais As ClsRaca_Animais) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()


        mCMD.Parameters.AddWithValue("@pCod_Raca", pNovoRaca_Animais.Cod_Raca.Substring(0, IIf(Len(pNovoRaca_Animais.Cod_Raca) > 4, 4, Len(pNovoRaca_Animais.Cod_Raca))))
        mCMD.Parameters.AddWithValue("@pRaca", pNovoRaca_Animais.Raca.Substring(0, IIf(Len(pNovoRaca_Animais.Raca) > 30, 30, Len(pNovoRaca_Animais.Raca))))
        mCMD.Parameters.AddWithValue("@pCod_Tipo_Animal", pNovoRaca_Animais.Cod_Tipo_Animal.Substring(0, IIf(Len(pNovoRaca_Animais.Cod_Tipo_Animal) > 4, 4, Len(pNovoRaca_Animais.Cod_Tipo_Animal))))
        mCMD.Parameters.AddWithValue("@pFLG_Ativo", pNovoRaca_Animais.FLG_Ativo)


        mStrSQL = "INSERT INTO Raca_Animais "
        mStrSQL += "("
        mStrSQL += "Cod_Raca,"
        mStrSQL += "Raca,"
        mStrSQL += "Cod_Tipo_Animal,"
        mStrSQL += "FLG_Ativo "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        mStrSQL += "@pCod_Raca,"
        mStrSQL += "@pRaca,"
        mStrSQL += "@pCod_Tipo_Animal,"
        mStrSQL += "1"
        mStrSQL += ")"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
            'ClsEmpresas.GravaContador(enCont.Raca_Animais)'<<<<-------- Verificar se é  preciso...
        Catch ex As Exception
            MsgBox("GravaRaca_Animais:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function ApagaRaca_Animais(ByVal pCod_Raca As String) Método para Apagar um Registo da Tabela Raca_Animais
    '''      Gerado em 03/03/2023 15:49:35
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function ApagaRaca_Animais(ByVal pCod_Raca As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pCod_Raca", pCod_Raca)


        mStrSQL = "UPDATE Raca_Animais SET "
        mStrSQL += "FLG_Ativo=0 "
        mStrSQL += "WHERE Cod_Raca=@pCod_Raca"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ApagaRaca_Animais:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function
End Class



''' <summary>
'''      Classe Raca_AnimaisComparer 
'''      Gerado em 03/03/2023 15:49:35
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2023
''' </remarks>
Public Class Raca_AnimaisComparer
    Implements IEqualityComparer(Of ClsRaca_Animais)

    Public Function Equals1(ByVal x As ClsRaca_Animais, ByVal y As ClsRaca_Animais) As Boolean Implements IEqualityComparer(Of ClsRaca_Animais).Equals

        If x Is y Then Return True

        If x Is Nothing OrElse y Is Nothing Then Return False

        Return (x.Cod_Raca = y.Cod_Raca) ' AndAlso (x.Raca = y.Raca)
    End Function

    Public Function GetHashCode1(ByVal pCls As ClsRaca_Animais) As Integer Implements IEqualityComparer(Of ClsRaca_Animais).GetHashCode

        If pCls Is Nothing Then Return 0

        'Dim Hash_ClsRaca_Animais_Raca = pCls.Raca.GetHashCode()
        Dim Hash_ClsRaca_Animais_Cod_Raca = pCls.Cod_Raca.GetHashCode()

        Return Hash_ClsRaca_Animais_Cod_Raca 'Xor Hash_ClsRaca_Animais_Raca
    End Function
End Class
