
Imports System.Data.SqlClient


''' <summary>
'''      Classe ClsSalas Classe da Tabela Salas
'''      Gerado em 03/03/2023 15:49:35
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2023
''' </remarks>
Public Class ClsSalas


    ' -----------------------------------------
    ' Property's da tabela Salas
    ' -----------------------------------------

    Public Property Cod_Sala As String                                      ' Len:  3 - SQL_Type: nvarchar
    Public Property Sala As String                                          ' Len: 20 - SQL_Type: nvarchar
    Public Property FLG_Ativo As Boolean                                    ' SQL_Type: bit


    Sub New()
    End Sub


    '--------------------------------------------
    ' Exemplo de criador de Código por contador
    ' Para ser usado no caso de o Cdigo ser gerado
    ' e o contador existir na tabela Empresas
    '---------------------------------------------

    Friend Shared Function GetNovoCodigo() As String

        Return "S" & ClsEmpresas.GetContador(enCont.Salas).ToString("00") ' <-------------- VERIFICAR O Nº de ZEROS

    End Function


    ''' <summary>
    '''      Function GetSalas() Método para devolver a Lista de Salas
    '''      Gerado em 03/03/2023 15:49:35
    ''' </summary>
    ''' <returns>
    '''      mListaSalas
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function GetSalas() As List(Of ClsSalas)
        Dim mListaSalas As New List(Of ClsSalas)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Sala,'') As Cod_Sala,"
        mStrSQL += "ISNULL(Sala,'') As Sala,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Salas "
        mStrSQL += "WHERE FLG_Ativo=1"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsSalas As New ClsSalas

            With mClsSalas
                .Cod_Sala = mRDR.GetString(mRDR.GetOrdinal("Cod_Sala"))
                .Sala = mRDR.GetString(mRDR.GetOrdinal("Sala"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaSalas.Add(mClsSalas)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaSalas
    End Function

    ''' <summary>
    '''      Function FiltrarSalas Método para Filtrar os campos da lista de Salas
    '''      Gerado em 03/03/2023 15:49:35
    ''' </summary>
    ''' <returns>
    '''      mListaSalas
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function FiltrarSalas(ByVal pFiltro As ClsSalas) As List(Of ClsSalas)
        Dim mListaSalas As New List(Of ClsSalas)
        Dim mLista As New List(Of ClsSalas)

        mListaSalas = GetSalas()

        mLista = mListaSalas.FindAll(Function(x) _
        x.Cod_Sala.Contains(pFiltro.Cod_Sala)
        )
        '-----------------------------------------------------
        'Pode Colocar em cima mais colunas como esta abaixo...
        '-----------------------------------------------------
        ' AND x.Sala.Contains(pFiltro.Sala) 

        Return mLista
    End Function


    ''' <summary>
    '''      Function GetSalasByCod(ByVal pCod_Sala As String) Método para decolver uma Classe de Salas
    '''      Gerado em 03/03/2023 15:49:35
    ''' </summary>
    ''' <returns>
    '''      mClsSalas
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function GetSalasByCod(ByVal pCod_Sala As String) As ClsSalas
        Dim mClsSalas As New ClsSalas

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Sala", pCod_Sala)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Sala,'') As Cod_Sala,"
        mStrSQL += "ISNULL(Sala,'') As Sala,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Salas "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Cod_Sala=@pCod_Sala"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsSalas
                .Cod_Sala = mRDR.GetString(mRDR.GetOrdinal("Cod_Sala"))
                .Sala = mRDR.GetString(mRDR.GetOrdinal("Sala"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mClsSalas
    End Function


    ''' <summary>
    '''      Function ModificaSalas(ByVal pClsSalas As ClsSalas) Método para Modificar a TABELA Salas
    '''      Gerado em 03/03/2023 15:49:35
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function ModificaSalas(ByVal pClsSalas As ClsSalas) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Sala", pClsSalas.Cod_Sala.Substring(0, IIf(Len(pClsSalas.Cod_Sala) > 3, 3, Len(pClsSalas.Cod_Sala))))
        mCMD.Parameters.AddWithValue("@pSala", pClsSalas.Sala.Substring(0, IIf(Len(pClsSalas.Sala) > 20, 20, Len(pClsSalas.Sala))))


        mStrSQL = "UPDATE Salas SET "
        mStrSQL += "Sala=@pSala "
        mStrSQL += "WHERE Cod_Sala=@pCod_Sala"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ModificaSalas:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function GravaSalas(ByVal pNovoSalas As ClsSalas) Método para Gravar a TABELA Salas
    '''      Gerado em 03/03/2023 15:49:35
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function GravaSalas(ByVal pNovoSalas As ClsSalas) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()


        mCMD.Parameters.AddWithValue("@pCod_Sala", pNovoSalas.Cod_Sala.Substring(0, IIf(Len(pNovoSalas.Cod_Sala) > 3, 3, Len(pNovoSalas.Cod_Sala))))
        mCMD.Parameters.AddWithValue("@pSala", pNovoSalas.Sala.Substring(0, IIf(Len(pNovoSalas.Sala) > 20, 20, Len(pNovoSalas.Sala))))
        mCMD.Parameters.AddWithValue("@pFLG_Ativo", pNovoSalas.FLG_Ativo)


        mStrSQL = "INSERT INTO Salas "
        mStrSQL += "("
        mStrSQL += "Cod_Sala,"
        mStrSQL += "Sala,"
        mStrSQL += "FLG_Ativo "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        mStrSQL += "@pCod_Sala,"
        mStrSQL += "@pSala,"
        mStrSQL += "1"
        mStrSQL += ")"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
            'ClsEmpresas.GravaContador(enCont.Salas)'<<<<-------- Verificar se é  preciso...
        Catch ex As Exception
            MsgBox("GravaSalas:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function ApagaSalas(ByVal pCod_Sala As String) Método para Apagar um Registo da Tabela Salas
    '''      Gerado em 03/03/2023 15:49:35
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function ApagaSalas(ByVal pCod_Sala As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pCod_Sala", pCod_Sala)


        mStrSQL = "UPDATE Salas SET "
        mStrSQL += "FLG_Ativo=0 "
        mStrSQL += "WHERE Cod_Sala=@pCod_Sala"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ApagaSalas:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function
End Class



''' <summary>
'''      Classe SalasComparer 
'''      Gerado em 03/03/2023 15:49:35
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2023
''' </remarks>
Public Class SalasComparer
    Implements IEqualityComparer(Of ClsSalas)

    Public Function Equals1(ByVal x As ClsSalas, ByVal y As ClsSalas) As Boolean Implements IEqualityComparer(Of ClsSalas).Equals

        If x Is y Then Return True

        If x Is Nothing OrElse y Is Nothing Then Return False

        Return (x.Cod_Sala = y.Cod_Sala) ' AndAlso (x.Sala = y.Sala)
    End Function

    Public Function GetHashCode1(ByVal pCls As ClsSalas) As Integer Implements IEqualityComparer(Of ClsSalas).GetHashCode

        If pCls Is Nothing Then Return 0

        'Dim Hash_ClsSalas_Sala = pCls.Sala.GetHashCode()
        Dim Hash_ClsSalas_Cod_Sala = pCls.Cod_Sala.GetHashCode()

        Return Hash_ClsSalas_Cod_Sala 'Xor Hash_ClsSalas_Sala
    End Function
End Class

