
Imports System.Data.SqlClient


''' <summary>
'''      Classe ClsTipos_Pagamento Classe da Tabela Tipos_Pagamento
'''      Gerado em 29/11/2022 14:12:55
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2022
''' </remarks>
Public Class ClsTipos_Pagamento


    ' -----------------------------------------
    ' Property's da tabela Tipos_Pagamento
    ' -----------------------------------------

    Public Property Cod_Tipo_Pagamento As String                            ' Len:  4 - SQL_Type: nvarchar
    Public Property Tipo_Pagamento As String                                ' Len: 20 - SQL_Type: nvarchar
    Public Property Cod_Imagem As String                                    ' Len: 15 - SQL_Type: nvarchar
    Public Property FLG_Ativo As Boolean                                    ' SQL_Type: bit


    Sub New()
    End Sub


    Friend Shared Function GetNovoCodigo() As String

        Return "T" & ClsEmpresas.GetContador(enCont.Tipos_Pagamento).ToString("000") ' <-------------- VERIFICAR O Nº de ZEROS

    End Function


    ''' <summary>
    '''      Function GetTipos_Pagamento() Método para devolver a Lista de Tipos_Pagamento
    '''      Gerado em 29/11/2022 14:12:55
    ''' </summary>
    ''' <returns>
    '''      mListaTipos_Pagamento
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function GetTipos_Pagamento() As List(Of ClsTipos_Pagamento)
        Dim mListaTipos_Pagamento As New List(Of ClsTipos_Pagamento)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Tipo_Pagamento,'') As Cod_Tipo_Pagamento,"
        mStrSQL += "ISNULL(Tipo_Pagamento,'') As Tipo_Pagamento,"
        mStrSQL += "ISNULL(Cod_Imagem,'') As Cod_Imagem,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Tipos_Pagamento "
        mStrSQL += "WHERE FLG_Ativo=1"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsTipos_Pagamento As New ClsTipos_Pagamento

            With mClsTipos_Pagamento
                .Cod_Tipo_Pagamento = mRDR.GetString(mRDR.GetOrdinal("Cod_Tipo_Pagamento"))
                .Tipo_Pagamento = mRDR.GetString(mRDR.GetOrdinal("Tipo_Pagamento"))
                .Cod_Imagem = mRDR.GetString(mRDR.GetOrdinal("Cod_Imagem"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaTipos_Pagamento.Add(mClsTipos_Pagamento)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaTipos_Pagamento
    End Function

    ''' <summary>
    '''      Function FiltrarTipos_Pagamento Método para Filtrar os campos da lista de Tipos_Pagamento
    '''      Gerado em 29/11/2022 14:12:55
    ''' </summary>
    ''' <returns>
    '''      mListaTipos_Pagamento
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function FiltrarTipos_Pagamento(ByVal pFiltro As ClsTipos_Pagamento) As List(Of ClsTipos_Pagamento)
        Dim mListaTipos_Pagamento As New List(Of ClsTipos_Pagamento)
        Dim mLista As New List(Of ClsTipos_Pagamento)

        mListaTipos_Pagamento = GetTipos_Pagamento()

        mLista = mListaTipos_Pagamento.FindAll(Function(x) _
        x.Cod_Tipo_Pagamento.Contains(pFiltro.Cod_Tipo_Pagamento)
        )
        '-----------------------------------------------------
        'Pode Colocar em cima mais colunas como esta abaixo...
        '-----------------------------------------------------
        ' AND x.Tipo_Pagamento.Contains(pFiltro.Tipo_Pagamento) 

        Return mLista
    End Function


    ''' <summary>
    '''      Function GetTipos_PagamentoByCod(ByVal pCod_Tipo_Pagamento As String) Método para decolver uma Classe de Tipos_Pagamento
    '''      Gerado em 29/11/2022 14:12:55
    ''' </summary>
    ''' <returns>
    '''      mClsTipos_Pagamento
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function GetTipos_PagamentoByCod(ByVal pCod_Tipo_Pagamento As String) As ClsTipos_Pagamento
        Dim mClsTipos_Pagamento As New ClsTipos_Pagamento

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Tipo_Pagamento", pCod_Tipo_Pagamento)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Tipo_Pagamento,'') As Cod_Tipo_Pagamento,"
        mStrSQL += "ISNULL(Tipo_Pagamento,'') As Tipo_Pagamento,"
        mStrSQL += "ISNULL(Cod_Imagem,'') As Cod_Imagem,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Tipos_Pagamento "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Cod_Tipo_Pagamento=@pCod_Tipo_Pagamento"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsTipos_Pagamento
                .Cod_Tipo_Pagamento = mRDR.GetString(mRDR.GetOrdinal("Cod_Tipo_Pagamento"))
                .Tipo_Pagamento = mRDR.GetString(mRDR.GetOrdinal("Tipo_Pagamento"))
                .Cod_Imagem = mRDR.GetString(mRDR.GetOrdinal("Cod_Imagem"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mClsTipos_Pagamento
    End Function


    ''' <summary>
    '''      Function ModificaTipos_Pagamento(ByVal pClsTipos_Pagamento As ClsTipos_Pagamento) Método para Modificar a TABELA Tipos_Pagamento
    '''      Gerado em 29/11/2022 14:12:55
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function ModificaTipos_Pagamento(ByVal pClsTipos_Pagamento As ClsTipos_Pagamento) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Tipo_Pagamento", pClsTipos_Pagamento.Cod_Tipo_Pagamento.Substring(0, IIf(Len(pClsTipos_Pagamento.Cod_Tipo_Pagamento) > 4, 4, Len(pClsTipos_Pagamento.Cod_Tipo_Pagamento))))
        mCMD.Parameters.AddWithValue("@pTipo_Pagamento", pClsTipos_Pagamento.Tipo_Pagamento.Substring(0, IIf(Len(pClsTipos_Pagamento.Tipo_Pagamento) > 20, 20, Len(pClsTipos_Pagamento.Tipo_Pagamento))))
        mCMD.Parameters.AddWithValue("@pCod_Imagem", pClsTipos_Pagamento.Cod_Imagem.Substring(0, IIf(Len(pClsTipos_Pagamento.Cod_Imagem) > 15, 15, Len(pClsTipos_Pagamento.Cod_Imagem))))


        mStrSQL = "UPDATE Tipos_Pagamento SET "
        mStrSQL += "Tipo_Pagamento=@pTipo_Pagamento,"
        mStrSQL += "Cod_Imagem=@pCod_Imagem "
        mStrSQL += "WHERE Cod_Tipo_Pagamento=@pCod_Tipo_Pagamento"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ModificaTipos_Pagamento:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function GravaTipos_Pagamento(ByVal pNovoTipos_Pagamento As ClsTipos_Pagamento) Método para Gravar a TABELA Tipos_Pagamento
    '''      Gerado em 29/11/2022 14:12:55
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function GravaTipos_Pagamento(ByVal pNovoTipos_Pagamento As ClsTipos_Pagamento) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()


        mCMD.Parameters.AddWithValue("@pCod_Tipo_Pagamento", pNovoTipos_Pagamento.Cod_Tipo_Pagamento.Substring(0, IIf(Len(pNovoTipos_Pagamento.Cod_Tipo_Pagamento) > 4, 4, Len(pNovoTipos_Pagamento.Cod_Tipo_Pagamento))))
        mCMD.Parameters.AddWithValue("@pTipo_Pagamento", pNovoTipos_Pagamento.Tipo_Pagamento.Substring(0, IIf(Len(pNovoTipos_Pagamento.Tipo_Pagamento) > 20, 20, Len(pNovoTipos_Pagamento.Tipo_Pagamento))))
        mCMD.Parameters.AddWithValue("@pCod_Imagem", pNovoTipos_Pagamento.Cod_Imagem.Substring(0, IIf(Len(pNovoTipos_Pagamento.Cod_Imagem) > 15, 15, Len(pNovoTipos_Pagamento.Cod_Imagem))))
        mCMD.Parameters.AddWithValue("@pFLG_Ativo", pNovoTipos_Pagamento.FLG_Ativo)


        mStrSQL = "INSERT INTO Tipos_Pagamento "
        mStrSQL += "("
        mStrSQL += "Cod_Tipo_Pagamento,"
        mStrSQL += "Tipo_Pagamento,"
        mStrSQL += "Cod_Imagem,"
        mStrSQL += "FLG_Ativo "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        mStrSQL += "@pCod_Tipo_Pagamento,"
        mStrSQL += "@pTipo_Pagamento,"
        mStrSQL += "@pCod_Imagem,"
        mStrSQL += "1"
        mStrSQL += ")"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
            ClsEmpresas.GravaContador(enCont.Tipos_Pagamento)
        Catch ex As Exception
            MsgBox("GravaTipos_Pagamento:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function ApagaTipos_Pagamento(ByVal pCod_Tipo_Pagamento As String) Método para Apagar um Registo da Tabela Tipos_Pagamento
    '''      Gerado em 29/11/2022 14:12:55
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function ApagaTipos_Pagamento(ByVal pCod_Tipo_Pagamento As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pCod_Tipo_Pagamento", pCod_Tipo_Pagamento)


        mStrSQL = "UPDATE Tipos_Pagamento SET "
        mStrSQL += "FLG_Ativo=0 "
        mStrSQL += "WHERE Cod_Tipo_Pagamento=@pCod_Tipo_Pagamento"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ApagaTipos_Pagamento:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function
End Class



''' <summary>
'''      Classe Tipos_PagamentoComparer 
'''      Gerado em 29/11/2022 14:12:55
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2022
''' </remarks>
Public Class Tipos_PagamentoComparer
    Implements IEqualityComparer(Of ClsTipos_Pagamento)

    Public Function Equals1(ByVal x As ClsTipos_Pagamento, ByVal y As ClsTipos_Pagamento) As Boolean Implements IEqualityComparer(Of ClsTipos_Pagamento).Equals

        If x Is y Then Return True

        If x Is Nothing OrElse y Is Nothing Then Return False

        Return (x.Cod_Tipo_Pagamento = y.Cod_Tipo_Pagamento) ' AndAlso (x.Tipo_Pagamento = y.Tipo_Pagamento)
    End Function

    Public Function GetHashCode1(ByVal pCls As ClsTipos_Pagamento) As Integer Implements IEqualityComparer(Of ClsTipos_Pagamento).GetHashCode

        If pCls Is Nothing Then Return 0

        'Dim Hash_ClsTipos_Pagamento_Tipo_Pagamento = pCls.Tipo_Pagamento.GetHashCode()
        Dim Hash_ClsTipos_Pagamento_Cod_Tipo_Pagamento = pCls.Cod_Tipo_Pagamento.GetHashCode()

        Return Hash_ClsTipos_Pagamento_Cod_Tipo_Pagamento 'Xor Hash_ClsTipos_Pagamento_Tipo_Pagamento
    End Function
End Class
