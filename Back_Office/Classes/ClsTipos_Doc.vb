
Imports System.Data.SqlClient


''' <summary>
'''      Classe ClsTipos_Doc Classe da Tabela Tipos_Doc
'''      Gerado em 29/11/2022 14:12:55
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2022
''' </remarks>
Public Class ClsTipos_Doc


    ' -----------------------------------------
    ' Property's da tabela Tipos_Doc
    ' -----------------------------------------

    Public Property FLG_Tipo_Doc As String                                  ' Len:  3 - SQL_Type: nvarchar
    Public Property Designacao As String                                    ' Len: 50 - SQL_Type: nvarchar
    Public Property Descritivo_Impressao As String                          ' Len: 30 - SQL_Type: nvarchar
    Public Property FLG_ESC As String                                       ' Len:  1 - SQL_Type: nvarchar
    Public Property FLG_DC As String                                        ' Len:  2 - SQL_Type: nvarchar
    Public Property FLG_Entidade As String                                  ' Len:  1 - SQL_Type: nvarchar
    Public Property FLG_Venda As Boolean                                    ' SQL_Type: bit
    Public Property FLG_Compra As Boolean                                   ' SQL_Type: bit
    Public Property FLG_Stock As Boolean                                    ' SQL_Type: bit
    Public Property Cod_Serie As String                                     ' Len:  8 - SQL_Type: nvarchar
    Public ReadOnly Property Contador As String
        Get
            Return ClsSeries.GetSeriesByCod(Cod_Serie).Contador
        End Get
    End Property
    Public Property FLG_Ativo As Boolean                                    ' SQL_Type: bit


    Sub New()
    End Sub


    '--------------------------------------------
    ' Exemplo de criador de Código por contador
    ' Para ser usado no caso de o Cdigo ser gerado
    ' e o contador existir na tabela Empresas
    '---------------------------------------------

    'Friend Shared Function GetNovoCodigo() As String

    'Return "T" & ClsEmpresas.GetContador(enCont.Tipos_Doc).ToString("000")' <-------------- VERIFICAR O Nº de ZEROS

    'End Function


    Friend Shared Function Grava_Serie(pCod_Serie As String, pFLG_Tipo_Doc As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Serie", pCod_Serie)
        mCMD.Parameters.AddWithValue("@pFLG_Tipo_Doc", pFLG_Tipo_Doc)

        mStrSQL = "UPDATE Tipos_Doc SET "
        mStrSQL += "Cod_Serie=@pCod_Serie "
        mStrSQL += "WHERE FLG_Tipo_Doc=@pFLG_Tipo_Doc"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Grava_Serie:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn
    End Function


    ''' <summary>
    '''      Function GetTipos_Doc() Método para devolver a Lista de Tipos_Doc
    '''      Gerado em 29/11/2022 14:12:55
    ''' </summary>
    ''' <returns>
    '''      mListaTipos_Doc
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function GetTipos_Doc(Optional pES As String = "S") As List(Of ClsTipos_Doc)
        Dim mListaTipos_Doc As New List(Of ClsTipos_Doc)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pES", pES)

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(FLG_Tipo_Doc,'') As FLG_Tipo_Doc,"
        mStrSQL += "ISNULL(Designacao,'') As Designacao,"
        mStrSQL += "ISNULL(Descritivo_Impressao,'') As Descritivo_Impressao,"
        mStrSQL += "ISNULL(FLG_ESC,'') As FLG_ESC,"
        mStrSQL += "ISNULL(FLG_DC,'') As FLG_DC,"
        mStrSQL += "ISNULL(FLG_Entidade,'') As FLG_Entidade,"
        mStrSQL += "ISNULL(FLG_Venda,1) As FLG_Venda,"
        mStrSQL += "ISNULL(FLG_Compra,1) As FLG_Compra,"
        mStrSQL += "ISNULL(FLG_Stock,1) As FLG_Stock,"
        mStrSQL += "ISNULL(Cod_Serie,0) As Cod_Serie,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Tipos_Doc "
        mStrSQL += "WHERE FLG_Ativo=1"
        If pES = "S" Then
            mStrSQL += "AND FLG_ESC=@pES"
        End If

        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsTipos_Doc As New ClsTipos_Doc

            With mClsTipos_Doc
                .FLG_Tipo_Doc = mRDR.GetString(mRDR.GetOrdinal("FLG_Tipo_Doc"))
                .Designacao = mRDR.GetString(mRDR.GetOrdinal("Designacao"))
                .Descritivo_Impressao = mRDR.GetString(mRDR.GetOrdinal("Descritivo_Impressao"))
                .FLG_ESC = mRDR.GetString(mRDR.GetOrdinal("FLG_ESC"))
                .FLG_DC = mRDR.GetString(mRDR.GetOrdinal("FLG_DC"))
                .FLG_Entidade = mRDR.GetString(mRDR.GetOrdinal("FLG_Entidade"))
                .FLG_Venda = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Venda"))
                .FLG_Compra = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Compra"))
                .FLG_Stock = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Stock"))
                .Cod_Serie = mRDR.GetString(mRDR.GetOrdinal("Cod_Serie"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaTipos_Doc.Add(mClsTipos_Doc)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaTipos_Doc
    End Function


    ''' <summary>
    '''      Function GetTipos_DocByCod(ByVal pFLG_Tipo_Doc As String) Método para decolver uma Classe de Tipos_Doc
    '''      Gerado em 29/11/2022 14:12:55
    ''' </summary>
    ''' <returns>
    '''      mClsTipos_Doc
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function GetTipos_DocByCod(ByVal pFLG_Tipo_Doc As String) As ClsTipos_Doc
        Dim mClsTipos_Doc As New ClsTipos_Doc

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pFLG_Tipo_Doc", pFLG_Tipo_Doc)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(FLG_Tipo_Doc,'') As FLG_Tipo_Doc,"
        mStrSQL += "ISNULL(Designacao,'') As Designacao,"
        mStrSQL += "ISNULL(Descritivo_Impressao,'') As Descritivo_Impressao,"
        mStrSQL += "ISNULL(FLG_ESC,'') As FLG_ESC,"
        mStrSQL += "ISNULL(FLG_DC,'') As FLG_DC,"
        mStrSQL += "ISNULL(FLG_Entidade,'') As FLG_Entidade,"
        mStrSQL += "ISNULL(FLG_Venda,1) As FLG_Venda,"
        mStrSQL += "ISNULL(FLG_Compra,1) As FLG_Compra,"
        mStrSQL += "ISNULL(FLG_Stock,1) As FLG_Stock,"
        mStrSQL += "ISNULL(Cod_Serie,0) As Cod_Serie,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Tipos_Doc "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND FLG_Tipo_Doc=@pFLG_Tipo_Doc"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsTipos_Doc
                .FLG_Tipo_Doc = mRDR.GetString(mRDR.GetOrdinal("FLG_Tipo_Doc"))
                .Designacao = mRDR.GetString(mRDR.GetOrdinal("Designacao"))
                .Descritivo_Impressao = mRDR.GetString(mRDR.GetOrdinal("Descritivo_Impressao"))
                .FLG_ESC = mRDR.GetString(mRDR.GetOrdinal("FLG_ESC"))
                .FLG_DC = mRDR.GetString(mRDR.GetOrdinal("FLG_DC"))
                .FLG_Entidade = mRDR.GetString(mRDR.GetOrdinal("FLG_Entidade"))
                .FLG_Venda = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Venda"))
                .FLG_Compra = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Compra"))
                .FLG_Stock = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Stock"))
                .Cod_Serie = mRDR.GetString(mRDR.GetOrdinal("Cod_Serie"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mClsTipos_Doc
    End Function


    ''' <summary>
    '''      Function ModificaTipos_Doc(ByVal pClsTipos_Doc As ClsTipos_Doc) Método para Modificar a TABELA Tipos_Doc
    '''      Gerado em 29/11/2022 14:12:55
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function ModificaTipos_Doc(ByVal pClsTipos_Doc As ClsTipos_Doc) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pFLG_Tipo_Doc", pClsTipos_Doc.FLG_Tipo_Doc.Substring(0, IIf(Len(pClsTipos_Doc.FLG_Tipo_Doc) > 3, 3, Len(pClsTipos_Doc.FLG_Tipo_Doc))))
        mCMD.Parameters.AddWithValue("@pDesignacao", pClsTipos_Doc.Designacao.Substring(0, IIf(Len(pClsTipos_Doc.Designacao) > 50, 50, Len(pClsTipos_Doc.Designacao))))
        mCMD.Parameters.AddWithValue("@pDescritivo_Impressao", pClsTipos_Doc.Descritivo_Impressao.Substring(0, IIf(Len(pClsTipos_Doc.Descritivo_Impressao) > 30, 30, Len(pClsTipos_Doc.Descritivo_Impressao))))
        mCMD.Parameters.AddWithValue("@pFLG_ESC", pClsTipos_Doc.FLG_ESC.Substring(0, IIf(Len(pClsTipos_Doc.FLG_ESC) > 1, 1, Len(pClsTipos_Doc.FLG_ESC))))
        mCMD.Parameters.AddWithValue("@pFLG_DC", pClsTipos_Doc.FLG_DC.Substring(0, IIf(Len(pClsTipos_Doc.FLG_DC) > 2, 2, Len(pClsTipos_Doc.FLG_DC))))
        mCMD.Parameters.AddWithValue("@pFLG_Entidade", pClsTipos_Doc.FLG_Entidade.Substring(0, IIf(Len(pClsTipos_Doc.FLG_Entidade) > 1, 1, Len(pClsTipos_Doc.FLG_Entidade))))
        mCMD.Parameters.AddWithValue("@pFLG_Venda", pClsTipos_Doc.FLG_Venda)
        mCMD.Parameters.AddWithValue("@pFLG_Compra", pClsTipos_Doc.FLG_Compra)
        mCMD.Parameters.AddWithValue("@pFLG_Stock", pClsTipos_Doc.FLG_Stock)
        mCMD.Parameters.AddWithValue("@pCod_Serie", pClsTipos_Doc.Cod_Serie.Substring(0, IIf(Len(pClsTipos_Doc.Cod_Serie) > 8, 8, Len(pClsTipos_Doc.Cod_Serie))))


        mStrSQL = "UPDATE Tipos_Doc SET "
        mStrSQL += "Designacao=@pDesignacao,"
        mStrSQL += "Descritivo_Impressao=@pDescritivo_Impressao,"
        mStrSQL += "FLG_ESC=@pFLG_ESC,"
        mStrSQL += "FLG_DC=@pFLG_DC,"
        mStrSQL += "FLG_Entidade=@pFLG_Entidade,"
        mStrSQL += "FLG_Venda=@pFLG_Venda,"
        mStrSQL += "FLG_Compra=@pFLG_Compra,"
        mStrSQL += "FLG_Stock=@pFLG_Stock,"
        mStrSQL += "Cod_Serie=@pCod_Serie "
        mStrSQL += "WHERE FLG_Tipo_Doc=@pFLG_Tipo_Doc"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ModificaTipos_Doc:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function GravaTipos_Doc(ByVal pNovoTipos_Doc As ClsTipos_Doc) Método para Gravar a TABELA Tipos_Doc
    '''      Gerado em 29/11/2022 14:12:55
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function GravaTipos_Doc(ByVal pNovoTipos_Doc As ClsTipos_Doc) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()


        mCMD.Parameters.AddWithValue("@pFLG_Tipo_Doc", pNovoTipos_Doc.FLG_Tipo_Doc.Substring(0, IIf(Len(pNovoTipos_Doc.FLG_Tipo_Doc) > 3, 3, Len(pNovoTipos_Doc.FLG_Tipo_Doc))))
        mCMD.Parameters.AddWithValue("@pDesignacao", pNovoTipos_Doc.Designacao.Substring(0, IIf(Len(pNovoTipos_Doc.Designacao) > 50, 50, Len(pNovoTipos_Doc.Designacao))))
        mCMD.Parameters.AddWithValue("@pDescritivo_Impressao", pNovoTipos_Doc.Descritivo_Impressao.Substring(0, IIf(Len(pNovoTipos_Doc.Descritivo_Impressao) > 30, 30, Len(pNovoTipos_Doc.Descritivo_Impressao))))
        mCMD.Parameters.AddWithValue("@pFLG_ESC", pNovoTipos_Doc.FLG_ESC.Substring(0, IIf(Len(pNovoTipos_Doc.FLG_ESC) > 1, 1, Len(pNovoTipos_Doc.FLG_ESC))))
        mCMD.Parameters.AddWithValue("@pFLG_DC", pNovoTipos_Doc.FLG_DC.Substring(0, IIf(Len(pNovoTipos_Doc.FLG_DC) > 2, 2, Len(pNovoTipos_Doc.FLG_DC))))
        mCMD.Parameters.AddWithValue("@pFLG_Entidade", pNovoTipos_Doc.FLG_Entidade.Substring(0, IIf(Len(pNovoTipos_Doc.FLG_Entidade) > 1, 1, Len(pNovoTipos_Doc.FLG_Entidade))))
        mCMD.Parameters.AddWithValue("@pFLG_Venda", pNovoTipos_Doc.FLG_Venda)
        mCMD.Parameters.AddWithValue("@pFLG_Compra", pNovoTipos_Doc.FLG_Compra)
        mCMD.Parameters.AddWithValue("@pFLG_Stock", pNovoTipos_Doc.FLG_Stock)
        mCMD.Parameters.AddWithValue("@pCod_Serie", pNovoTipos_Doc.Cod_Serie.Substring(0, IIf(Len(pNovoTipos_Doc.Cod_Serie) > 8, 8, Len(pNovoTipos_Doc.Cod_Serie))))
        mCMD.Parameters.AddWithValue("@pFLG_Ativo", pNovoTipos_Doc.FLG_Ativo)


        mStrSQL = "INSERT INTO Tipos_Doc "
        mStrSQL += "("
        mStrSQL += "FLG_Tipo_Doc,"
        mStrSQL += "Designacao,"
        mStrSQL += "Descritivo_Impressao,"
        mStrSQL += "FLG_ESC,"
        mStrSQL += "FLG_DC,"
        mStrSQL += "FLG_Entidade,"
        mStrSQL += "FLG_Venda,"
        mStrSQL += "FLG_Compra,"
        mStrSQL += "FLG_Stock,"
        mStrSQL += "Cod_Serie,"
        mStrSQL += "FLG_Ativo "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        mStrSQL += "@pFLG_Tipo_Doc,"
        mStrSQL += "@pDesignacao,"
        mStrSQL += "@pDescritivo_Impressao,"
        mStrSQL += "@pFLG_ESC,"
        mStrSQL += "@pFLG_DC,"
        mStrSQL += "@pFLG_Entidade,"
        mStrSQL += "@pFLG_Venda,"
        mStrSQL += "@pFLG_Compra,"
        mStrSQL += "@pFLG_Stock,"
        mStrSQL += "@pCod_Serie,"
        mStrSQL += "1"
        mStrSQL += ")"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
            'ClsEmpresas.GravaContador(enCont.Tipos_Doc)'<<<<-------- Verificar se é  preciso...
        Catch ex As Exception
            MsgBox("GravaTipos_Doc:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function ApagaTipos_Doc(ByVal pFLG_Tipo_Doc As String) Método para Apagar um Registo da Tabela Tipos_Doc
    '''      Gerado em 29/11/2022 14:12:55
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function ApagaTipos_Doc(ByVal pFLG_Tipo_Doc As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pFLG_Tipo_Doc", pFLG_Tipo_Doc)


        mStrSQL = "UPDATE Tipos_Doc SET "
        mStrSQL += "FLG_Ativo=0 "
        mStrSQL += "WHERE FLG_Tipo_Doc=@pFLG_Tipo_Doc"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ApagaTipos_Doc:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function
End Class

