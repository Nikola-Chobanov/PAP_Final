Imports System.Data.SqlClient
Imports System.Windows.Automation

Public Class ClsArtigos
#Region "!!Properties!!"

    Public Property Cod_Artigo As String 'lenght 8
    Public Property FLG_Produto_Servico As String ' lenght 1
    Public Property Cod_Categoria As String
    Public Property Designacao As String ' lenght 100
    Public Property Imagem As String ' length 11
    Public Property Tipo_IVA As String 'lenght 1
    Public Property Preco_Venda As Decimal ' decimal
    Public Property Data_Ultima_Venda As Date ' smalldatetime
    Public Property Data_Registo As Date ' smalldatetime
    Public Property FLG_Ativo As Boolean ' bit
#End Region

    Sub New()
    End Sub

    Friend Shared Function GetNovoCodigo() As String

        Return "A" & ClsEmpresas.GetContador(enCont.Artigos).ToString("000") ' <-------------- VERIFICAR O Nº de ZEROS

    End Function

    Public Shared Function Get_Artigos() As List(Of ClsArtigos)
        Dim mListaArtigos As New List(Of ClsArtigos)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Artigo,'') AS Cod_Artigo,"
        mStrSQL += "ISNULL(FLG_Produto_Servico,'') AS FLG_Produto_Servico,"
        mStrSQL += "ISNULL(Cod_Categoria,'') AS Categoria,"
        mStrSQL += "ISNULL(Designacao,'') AS Designacao,"
        mStrSQL += "ISNULL(Imagem,'') AS Imagem,"
        mStrSQL += "ISNULL(Tipo_IVA,'') AS Tipo_IVA,"
        mStrSQL += "ISNULL(Preco_Venda,0) AS Preco_Venda,"
        mStrSQL += "ISNULL(Data_Ultima_Venda,0) AS Data_Ultima_Venda,"
        mStrSQL += "ISNULL(Data_Registo,0) AS Data_Registo,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Artigos "
        mStrSQL += "WHERE FLG_Ativo = 1"

        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsArtigos As New ClsArtigos

            With mClsArtigos
                .Cod_Artigo = mRDR.GetString(mRDR.GetOrdinal("Cod_Artigo"))
                .FLG_Produto_Servico = mRDR.GetString(mRDR.GetOrdinal("FLG_Produto_Servico"))
                .Cod_Categoria = mRDR.GetString(mRDR.GetOrdinal("Cod_Categoria"))
                .Designacao = mRDR.GetString(mRDR.GetOrdinal("Designacao"))
                .Imagem = mRDR.GetString(mRDR.GetOrdinal("Imagem"))
                .Tipo_IVA = mRDR.GetString(mRDR.GetOrdinal("Tipo_IVA"))
                .Preco_Venda = mRDR.GetDecimal(mRDR.GetOrdinal("Preco_Venda"))
                .Data_Ultima_Venda = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Ultima_Venda"))
                .Data_Registo = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Registo"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaArtigos.Add(mClsArtigos)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaArtigos
    End Function

    Public Shared Function GetArtigosByCategoria(ByVal pCodCategoria As String)
        Dim mListaArtigos As New List(Of ClsArtigos)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Categoria", pCodCategoria)

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Artigo,'') AS Cod_Artigo,"
        mStrSQL += "ISNULL(FLG_Produto_Servico,'') AS FLG_Produto_Servico,"
        mStrSQL += "ISNULL(Cod_Categoria,'') AS Cod_Categoria,"
        mStrSQL += "ISNULL(Designacao,'') AS Designacao,"
        mStrSQL += "ISNULL(Imagem,'') AS Imagem,"
        mStrSQL += "ISNULL(Tipo_IVA,'') AS Tipo_IVA,"
        mStrSQL += "ISNULL(Preco_Venda,0) AS Preco_Venda,"
        mStrSQL += "ISNULL(Data_Ultima_Venda,0) AS Data_Ultima_Venda,"
        mStrSQL += "ISNULL(Data_Registo,0) AS Data_Registo,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Artigos "
        mStrSQL += "WHERE FLG_Ativo = 1"
        mStrSQL += "AND Cod_Categoria = @pCod_Categoria"

        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsArtigos As New ClsArtigos

            With mClsArtigos
                .Cod_Artigo = mRDR.GetString(mRDR.GetOrdinal("Cod_Artigo"))
                .FLG_Produto_Servico = mRDR.GetString(mRDR.GetOrdinal("FLG_Produto_Servico"))
                .Cod_Categoria = mRDR.GetString(mRDR.GetOrdinal("Cod_Categoria"))
                .Designacao = mRDR.GetString(mRDR.GetOrdinal("Designacao"))
                .Imagem = mRDR.GetString(mRDR.GetOrdinal("Imagem"))
                .Tipo_IVA = mRDR.GetString(mRDR.GetOrdinal("Tipo_IVA"))
                .Preco_Venda = mRDR.GetDecimal(mRDR.GetOrdinal("Preco_Venda"))
                .Data_Ultima_Venda = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Ultima_Venda"))
                .Data_Registo = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Registo"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaArtigos.Add(mClsArtigos)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaArtigos

    End Function

    Public Shared Function ProcuraArtigo(ByVal pDesignacao As String) As List(Of ClsArtigos)
        Dim mListaArtigos As New List(Of ClsArtigos)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pDesignacao", "%" & pDesignacao & "%")

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Artigo,'') AS Cod_Artigo,"
        mStrSQL += "ISNULL(FLG_Produto_Servico,'') AS FLG_Produto_Servico,"
        mStrSQL += "ISNULL(Cod_Categoria,'') AS Cod_Categoria,"
        mStrSQL += "ISNULL(Designacao,'') AS Designacao,"
        mStrSQL += "ISNULL(Imagem,'') AS Imagem,"
        mStrSQL += "ISNULL(Tipo_IVA,'') AS Tipo_IVA,"
        mStrSQL += "ISNULL(Preco_Venda,0) AS Preco_Venda,"
        mStrSQL += "ISNULL(Data_Ultima_Venda,0) AS Data_Ultima_Venda,"
        mStrSQL += "ISNULL(Data_Registo,0) AS Data_Registo,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Artigos "
        mStrSQL += "WHERE Designacao LIKE @pDesignacao "

        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsArtigos As New ClsArtigos

            With mClsArtigos
                .Cod_Artigo = mRDR.GetString(mRDR.GetOrdinal("Cod_Artigo"))
                .FLG_Produto_Servico = mRDR.GetString(mRDR.GetOrdinal("FLG_Produto_Servico"))
                .Cod_Categoria = mRDR.GetString(mRDR.GetOrdinal("Cod_Categoria"))
                .Designacao = mRDR.GetString(mRDR.GetOrdinal("Designacao"))
                .Imagem = mRDR.GetString(mRDR.GetOrdinal("Imagem"))
                .Tipo_IVA = mRDR.GetString(mRDR.GetOrdinal("Tipo_IVA"))
                .Preco_Venda = mRDR.GetDecimal(mRDR.GetOrdinal("Preco_Venda"))
                .Data_Ultima_Venda = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Ultima_Venda"))
                .Data_Registo = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Registo"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaArtigos.Add(mClsArtigos)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaArtigos
    End Function
    Public Shared Function GetArtigosByCod(ByVal pCodArtigo As String) As ClsArtigos
        Dim mClsArtigos As New ClsArtigos

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader



        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCodArtigo", pCodArtigo)

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Artigo,'') AS Cod_Artigo,"
        mStrSQL += "ISNULL(FLG_Produto_Servico,'') AS FLG_Produto_Servico,"
        mStrSQL += "ISNULL(Cod_Categoria,'') AS Cod_Categoria,"
        mStrSQL += "ISNULL(Designacao,'') AS Designacao,"
        mStrSQL += "ISNULL(Imagem,'') AS Imagem,"
        mStrSQL += "ISNULL(Tipo_IVA,'') AS Tipo_IVA,"
        mStrSQL += "ISNULL(Preco_Venda,0) AS Preco_Venda,"
        mStrSQL += "ISNULL(Data_Ultima_Venda,0) AS Data_Ultima_Venda,"
        mStrSQL += "ISNULL(Data_Registo,0) AS Data_Registo,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Artigos "
        mStrSQL += "WHERE FLG_Ativo = 1 "
        mStrSQL += "AND Cod_Artigo = @pCodArtigo"

        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read Then
            With mClsArtigos
                .Cod_Artigo = mRDR.GetString(mRDR.GetOrdinal("Cod_Artigo"))
                .FLG_Produto_Servico = mRDR.GetString(mRDR.GetOrdinal("FLG_Produto_Servico"))
                .Cod_Categoria = mRDR.GetString(mRDR.GetOrdinal("Cod_Categoria"))
                .Designacao = mRDR.GetString(mRDR.GetOrdinal("Designacao"))
                .Imagem = mRDR.GetString(mRDR.GetOrdinal("Imagem"))
                .Tipo_IVA = mRDR.GetString(mRDR.GetOrdinal("Tipo_IVA"))
                .Preco_Venda = mRDR.GetDecimal(mRDR.GetOrdinal("Preco_Venda"))
                .Data_Ultima_Venda = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Ultima_Venda"))
                .Data_Registo = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Registo"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With
        End If

        mRDR.Close()
        mDB.Close()

        Return mClsArtigos
    End Function

    Public Shared Function ModificaArtigos(ByVal pClsArtigos As ClsArtigos) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Artigo", pClsArtigos.Cod_Artigo.Substring(0, IIf(Len(pClsArtigos.Cod_Artigo) > 8, 8, Len(pClsArtigos.Cod_Artigo))))
        mCMD.Parameters.AddWithValue("@pFLG_Produto_Servico", pClsArtigos.FLG_Produto_Servico.Substring(0, IIf(Len(pClsArtigos.FLG_Produto_Servico) > 1, 1, Len(pClsArtigos.FLG_Produto_Servico))))
        mCMD.Parameters.AddWithValue("@pCod_Categoria", pClsArtigos.Designacao.Substring(0, IIf(Len(pClsArtigos.Designacao) > 5, 5, Len(pClsArtigos.Designacao))))
        mCMD.Parameters.AddWithValue("@pDesignacao", pClsArtigos.Designacao.Substring(0, IIf(Len(pClsArtigos.Designacao) > 100, 100, Len(pClsArtigos.Designacao))))
        mCMD.Parameters.AddWithValue("@pImagem", pClsArtigos.Imagem.Substring(0, IIf(Len(pClsArtigos.Imagem) > 15, 15, Len(pClsArtigos.Imagem))))
        mCMD.Parameters.AddWithValue("@pTipo_IVA", pClsArtigos.Tipo_IVA.Substring(0, IIf(Len(pClsArtigos.Tipo_IVA) > 1, 1, Len(pClsArtigos.Tipo_IVA))))
        mCMD.Parameters.AddWithValue("@pPreco_Venda", pClsArtigos.Preco_Venda)
        mCMD.Parameters.AddWithValue("@pData_Ultima_Venda", pClsArtigos.Data_Ultima_Venda)
        mCMD.Parameters.AddWithValue("@pData_Registo", pClsArtigos.Data_Registo)


        mStrSQL = "UPDATE Artigos SET "
        mStrSQL += "FLG_Produto_Servico= @pFLG_Produto_Servico,"
        mStrSQL += "Cod_Categoria=@pCod_Categoria,"
        mStrSQL += "Designacao=@pDesignacao,"
        mStrSQL += "Imagem=@pImagem,"
        mStrSQL += "Tipo_IVA=@pTipo_IVA,"
        mStrSQL += "Preco_Venda=@pPreco_Venda,"
        mStrSQL += "Data_Ultima_Venda=@pData_Ultima_Venda,"
        mStrSQL += "Data_Registo=@pData_Registo "
        mStrSQL += "WHERE Cod_Artigo = @pCod_Artigo "


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ModificaArtigos:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()



        Return mReturn
    End Function

    Public Shared Function GravaArtigos(ByVal pNovoArtigos As ClsArtigos) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pCod_Artigo", pNovoArtigos.Cod_Artigo.Substring(0, IIf(Len(pNovoArtigos.Cod_Artigo) > 8, 8, Len(pNovoArtigos.Cod_Artigo))))
        mCMD.Parameters.AddWithValue("@pFLG_Produto_Servico", pNovoArtigos.FLG_Produto_Servico.Substring(0, IIf(Len(pNovoArtigos.FLG_Produto_Servico) > 1, 1, Len(pNovoArtigos.FLG_Produto_Servico))))
        mCMD.Parameters.AddWithValue("@pCod_Categoria", pNovoArtigos.Designacao.Substring(0, IIf(Len(pNovoArtigos.Designacao) > 5, 5, Len(pNovoArtigos.Designacao))))
        mCMD.Parameters.AddWithValue("@pDesignacao", pNovoArtigos.Designacao.Substring(0, IIf(Len(pNovoArtigos.Designacao) > 100, 100, Len(pNovoArtigos.Designacao))))
        mCMD.Parameters.AddWithValue("@pImagem", pNovoArtigos.Imagem.Substring(0, IIf(Len(pNovoArtigos.Imagem) > 15, 15, Len(pNovoArtigos.Imagem))))
        mCMD.Parameters.AddWithValue("@pTipo_IVA", pNovoArtigos.Tipo_IVA.Substring(0, IIf(Len(pNovoArtigos.Tipo_IVA) > 1, 1, Len(pNovoArtigos.Tipo_IVA))))
        mCMD.Parameters.AddWithValue("@pPreco_Venda", pNovoArtigos.Preco_Venda)
        mCMD.Parameters.AddWithValue("@pData_Ultima_Venda", pNovoArtigos.Data_Ultima_Venda)
        mCMD.Parameters.AddWithValue("@pData_Registo", pNovoArtigos.Data_Registo)

        mStrSQL = "INSERT INTO Artigos "
        mStrSQL += "("
        mStrSQL += "Cod_Artigo,"
        mStrSQL += "FLG_Produto_Servico,"
        mStrSQL += "Cod_Categoria,"
        mStrSQL += "Designacao,"
        mStrSQL += "Imagem,"
        mStrSQL += "Tipo_IVA,"
        mStrSQL += "Preco_Venda,"
        mStrSQL += "Data_Ultima_Venda,"
        mStrSQL += "Data_Registo,"
        mStrSQL += "FLG_Ativo "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        mStrSQL += "@pCod_Artigo,"
        mStrSQL += "@pFLG_Produto_Servico,"
        mStrSQL += "@pCod_Categoria"
        mStrSQL += "@pDesignacao,"
        mStrSQL += "@pImagem,"
        mStrSQL += "@pTipo_IVA,"
        mStrSQL += "@pPreco_Venda,"
        mStrSQL += "@pData_Ultima_Venda,"
        mStrSQL += "@pData_Registo,"
        mStrSQL += "1"
        mStrSQL += ")"

        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
            ClsEmpresas.GravaContador(enCont.Artigos)
        Catch ex As Exception
            MsgBox("GravaArtigos:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn
    End Function

    Public Shared Function ApagaArtigos(ByVal pCod_Artigo As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pCod_Artigo", pCod_Artigo)


        mStrSQL = "UPDATE Artigos SET "
        mStrSQL += "FLG_Ativo=0 "
        mStrSQL += "WHERE Cod_Artigo=@pCod_Artigo"

        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ApagaArtigos:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn
    End Function
End Class
