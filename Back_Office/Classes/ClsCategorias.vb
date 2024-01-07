
Imports System.Data.SqlClient


''' <summary>
'''      Classe ClsCategorias Classe da Tabela Categorias
'''      Gerado em 30/03/2023 13:41:33
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2023
''' </remarks>
Public Class ClsCategorias


    ' -----------------------------------------
    ' Property's da tabela Categorias
    ' -----------------------------------------

    Public Property Cod_Categoria As String                                 ' Len:  6 - SQL_Type: nvarchar
    Public Property Designacao As String                                    ' Len: 30 - SQL_Type: nvarchar
    Public Property Imagem As String                                        ' Len: 50 - SQL_Type: nvarchar
    Public Property FLG_Ativo As Boolean                                    ' SQL_Type: bit


    Sub New()
    End Sub


    '--------------------------------------------
    ' Exemplo de criador de Código por contador
    ' Para ser usado no caso de o Cdigo ser gerado
    ' e o contador existir na tabela Empresas
    '---------------------------------------------

    Friend Shared Function GetNovoCodigo() As String

        Return "CAT" & ClsEmpresas.GetContador(enCont.Categorias).ToString("00") ' <-------------- VERIFICAR O Nº de ZEROS

    End Function


    ''' <summary>
    '''      Function GetCategorias() Método para devolver a Lista de Categorias
    '''      Gerado em 30/03/2023 13:41:33
    ''' </summary>
    ''' <returns>
    '''      mListaCategorias
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function GetCategorias() As List(Of ClsCategorias)
        Dim mListaCategorias As New List(Of ClsCategorias)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Categoria,'') As Cod_Categoria,"
        mStrSQL += "ISNULL(Designacao,'') As Designacao,"
        mStrSQL += "ISNULL(Imagem,'') As Imagem,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Categorias "
        mStrSQL += "WHERE FLG_Ativo=1"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsCategorias As New ClsCategorias

            With mClsCategorias
                .Cod_Categoria = mRDR.GetString(mRDR.GetOrdinal("Cod_Categoria"))
                .Designacao = mRDR.GetString(mRDR.GetOrdinal("Designacao"))
                .Imagem = mRDR.GetString(mRDR.GetOrdinal("Imagem"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaCategorias.Add(mClsCategorias)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaCategorias
    End Function

    ''' <summary>
    '''      Function FiltrarCategorias Método para Filtrar os campos da lista de Categorias
    '''      Gerado em 30/03/2023 13:41:33
    ''' </summary>
    ''' <returns>
    '''      mListaCategorias
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function FiltrarCategorias(ByVal pFiltro As ClsCategorias) As List(Of ClsCategorias)
        Dim mListaCategorias As New List(Of ClsCategorias)
        Dim mLista As New List(Of ClsCategorias)

        mListaCategorias = GetCategorias()

        mLista = mListaCategorias.FindAll(Function(x) _
        x.Cod_Categoria.Contains(pFiltro.Cod_Categoria)
        )
        '-----------------------------------------------------
        'Pode Colocar em cima mais colunas como esta abaixo...
        '-----------------------------------------------------
        ' AND x.Designacao.Contains(pFiltro.Designacao) 

        Return mLista
    End Function


    ''' <summary>
    '''      Function GetCategoriasByCod(ByVal pCod_Categoria As String) Método para decolver uma Classe de Categorias
    '''      Gerado em 30/03/2023 13:41:33
    ''' </summary>
    ''' <returns>
    '''      mClsCategorias
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function GetCategoriasByCod(ByVal pCod_Categoria As String) As ClsCategorias
        Dim mClsCategorias As New ClsCategorias

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Categoria", pCod_Categoria)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Categoria,'') As Cod_Categoria,"
        mStrSQL += "ISNULL(Designacao,'') As Designacao,"
        mStrSQL += "ISNULL(Imagem,'') As Imagem,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Categorias "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Cod_Categoria=@pCod_Categoria"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsCategorias
                .Cod_Categoria = mRDR.GetString(mRDR.GetOrdinal("Cod_Categoria"))
                .Designacao = mRDR.GetString(mRDR.GetOrdinal("Designacao"))
                .Imagem = mRDR.GetString(mRDR.GetOrdinal("Imagem"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mClsCategorias
    End Function


    ''' <summary>
    '''      Function ModificaCategorias(ByVal pClsCategorias As ClsCategorias) Método para Modificar a TABELA Categorias
    '''      Gerado em 30/03/2023 13:41:33
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function ModificaCategorias(ByVal pClsCategorias As ClsCategorias) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Categoria", pClsCategorias.Cod_Categoria.Substring(0, IIf(Len(pClsCategorias.Cod_Categoria) > 6, 6, Len(pClsCategorias.Cod_Categoria))))
        mCMD.Parameters.AddWithValue("@pDesignacao", pClsCategorias.Designacao.Substring(0, IIf(Len(pClsCategorias.Designacao) > 30, 30, Len(pClsCategorias.Designacao))))
        mCMD.Parameters.AddWithValue("@pImagem", pClsCategorias.Imagem.Substring(0, IIf(Len(pClsCategorias.Imagem) > 50, 50, Len(pClsCategorias.Imagem))))


        mStrSQL = "UPDATE Categorias SET "
        mStrSQL += "Designacao=@pDesignacao,"
        mStrSQL += "Imagem=@pImagem "
        mStrSQL += "WHERE Cod_Categoria=@pCod_Categoria"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ModificaCategorias:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function GravaCategorias(ByVal pNovoCategorias As ClsCategorias) Método para Gravar a TABELA Categorias
    '''      Gerado em 30/03/2023 13:41:33
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function GravaCategorias(ByVal pNovoCategorias As ClsCategorias) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()


        mCMD.Parameters.AddWithValue("@pCod_Categoria", pNovoCategorias.Cod_Categoria.Substring(0, IIf(Len(pNovoCategorias.Cod_Categoria) > 5, 5, Len(pNovoCategorias.Cod_Categoria))))
        mCMD.Parameters.AddWithValue("@pDesignacao", pNovoCategorias.Designacao.Substring(0, IIf(Len(pNovoCategorias.Designacao) > 30, 30, Len(pNovoCategorias.Designacao))))
        mCMD.Parameters.AddWithValue("@pImagem", pNovoCategorias.Imagem.Substring(0, IIf(Len(pNovoCategorias.Imagem) > 50, 50, Len(pNovoCategorias.Imagem))))
        mCMD.Parameters.AddWithValue("@pFLG_Ativo", pNovoCategorias.FLG_Ativo)


        mStrSQL = "INSERT INTO Categorias "
        mStrSQL += "("
        mStrSQL += "Cod_Categoria,"
        mStrSQL += "Designacao,"
        mStrSQL += "Imagem,"
        mStrSQL += "FLG_Ativo "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        mStrSQL += "@pCod_Categoria,"
        mStrSQL += "@pDesignacao,"
        mStrSQL += "@pImagem,"
        mStrSQL += "1"
        mStrSQL += ")"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
            ClsEmpresas.GravaContador(enCont.Categorias) '<<<<-------- Verificar se é  preciso...
        Catch ex As Exception
            MsgBox("GravaCategorias:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function ApagaCategorias(ByVal pCod_Categoria As String) Método para Apagar um Registo da Tabela Categorias
    '''      Gerado em 30/03/2023 13:41:33
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function ApagaCategorias(ByVal pCod_Categoria As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pCod_Categoria", pCod_Categoria)


        mStrSQL = "UPDATE Categorias SET "
        mStrSQL += "FLG_Ativo=0 "
        mStrSQL += "WHERE Cod_Categoria=@pCod_Categoria"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ApagaCategorias:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function
End Class



''' <summary>
'''      Classe CategoriasComparer 
'''      Gerado em 30/03/2023 13:41:33
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2023
''' </remarks>
Public Class CategoriasComparer
    Implements IEqualityComparer(Of ClsCategorias)

    Public Function Equals1(ByVal x As ClsCategorias, ByVal y As ClsCategorias) As Boolean Implements IEqualityComparer(Of ClsCategorias).Equals

        If x Is y Then Return True

        If x Is Nothing OrElse y Is Nothing Then Return False

        Return (x.Cod_Categoria = y.Cod_Categoria) ' AndAlso (x.Designacao = y.Designacao)
    End Function

    Public Function GetHashCode1(ByVal pCls As ClsCategorias) As Integer Implements IEqualityComparer(Of ClsCategorias).GetHashCode

        If pCls Is Nothing Then Return 0

        'Dim Hash_ClsCategorias_Designacao = pCls.Designacao.GetHashCode()
        Dim Hash_ClsCategorias_Cod_Categoria = pCls.Cod_Categoria.GetHashCode()

        Return Hash_ClsCategorias_Cod_Categoria 'Xor Hash_ClsCategorias_Designacao
    End Function
End Class
