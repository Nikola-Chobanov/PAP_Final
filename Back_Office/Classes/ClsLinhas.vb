
Imports System.Data.SqlClient


''' <summary>
'''      Classe ClsLinhas Classe da Tabela Linhas
'''      Gerado em 29/11/2022 14:12:54
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2022
''' </remarks>
Public Class ClsLinhas
#Region "Properties"

    ' -----------------------------------------
    ' Property's da tabela Linhas
    ' -----------------------------------------

    Public Property Num_Doc As String                                       ' Len: 11 - SQL_Type: nvarchar
    Public Property FLG_Entidade As String
    Public Property Num_Linha As Integer                                    ' SQL_Type: smallint
    Public Property strNum_Linha As String

    Public Property Cod_Consulta As String                                  ' Len:  5 - SQL_Type: nvarchar
    Private _Consulta As String = ""
    Public Property Consulta As String
        Get
            Return If(Cod_Consulta = "", "", ClsTipos_Consulta.GetTipos_ConsultaByCod(Cod_Consulta).Designacao)
        End Get
        Set(value As String)
            _Consulta = value
        End Set
    End Property
    Public Property Quantidade As Integer                                   ' SQL_Type: smallint
    Public Property strQuantidade As String
    Public Property Cod_Artigo As String
    Public ReadOnly Property Unidade As String
        Get
            Return If(Cod_Consulta = "", "", "Un.")
        End Get
    End Property

    Private _Artigo As String
    Public Property Artigo As String
        Get
            Return If(Cod_Artigo = "", "", ClsArtigos.GetArtigosByCod(Cod_Artigo).Designacao)
        End Get
        Set(value As String)
            _Artigo = value
        End Set
    End Property
    Public Property P_Unitario As Decimal                                    ' SQL_Type: numeric
        Get
            Dim mPreco As Decimal = 0D

            mPreco = If(Cod_Artigo = "", 0D, ClsArtigos.GetArtigosByCod(Cod_Artigo).Preco_Venda)

            Return mPreco
        End Get
        Set(value As Decimal)
            _P_Unitario = value
        End Set
    End Property
    Public Property strP_Unitario As String

    Private _P_Unitario As Decimal

    Public Property Taxa_Desconto As Integer                                ' SQL_Type: smallint
    Public Property strTaxa_Desconto As String
    Public ReadOnly Property Taxa_IVA As Integer
        Get
            Return If(Cod_Artigo = "", 0, ClsIVA.GetIVAByTipo(ClsArtigos.GetArtigosByCod(Cod_Artigo).Tipo_IVA))
        End Get
    End Property
    Public Property strTaxa_IVA As String
    Public ReadOnly Property Valor_Iliquido As Decimal
        Get
            Return P_Unitario * Quantidade
        End Get
    End Property

    Public Property strValor_Iliquido As String

    Public ReadOnly Property Valor_Desconto As Decimal
        Get
            Return If(Cod_Artigo = "", 0D, (P_Unitario * Quantidade) * (Taxa_Desconto / 100))
        End Get
    End Property

    Public ReadOnly Property strValor_Desconto As String
        Get
            strValor_Desconto = If(Cod_Artigo = "", " ", FormatCurrency(Valor_Desconto).ToString)
        End Get
    End Property

    Public ReadOnly Property Valor_IVA As Decimal
        Get
            Dim mTaxa As Integer = If(Cod_Artigo = "", 0, ClsIVA.GetIVAByTipo(ClsArtigos.GetArtigosByCod(Cod_Artigo).Tipo_IVA))
            Return If(Cod_Artigo = "", 0D, ((P_Unitario * Quantidade) - Valor_Desconto) * mTaxa / 100)
        End Get
    End Property

    Public ReadOnly Property strValor_IVA As String
        Get
            strValor_IVA = If(Cod_Artigo = "", " ", FormatCurrency(Valor_IVA).ToString)
        End Get
    End Property

    Public ReadOnly Property FLG_Feita As Boolean
        Get
            'Return If(Cod_Artigo = "", False, True)
            Return If(Cod_Artigo <> "", 1, 0)
        End Get
    End Property

    Public ReadOnly Property FLG_PS As String
        Get
            Return If(Cod_Artigo = "", "-", ClsArtigos.GetArtigosByCod(Cod_Artigo).FLG_Produto_Servico)
        End Get
    End Property

    Public Property FLG_Ativo As Boolean                                    ' SQL_Type: bit



#End Region




    Sub New()
    End Sub

    Sub New(pNum_Doc As String, pLinha As Integer)
        Me.Num_Doc = pNum_Doc
        Me.Num_Linha = pLinha
        Me.strNum_Linha = pLinha.ToString("00")
        Me.Cod_Artigo = ""
        Me.Quantidade = 0
        Me.FLG_Entidade = "C"
        Me.Taxa_Desconto = 0

        Me.strP_Unitario = ""
        Me.strQuantidade = ""
        Me.strTaxa_Desconto = ""
        Me.strValor_Iliquido = ""

        Me.FLG_Ativo = True
    End Sub

    Sub New(pNum_Doc As String, pLinha As Integer, pArtigo As ClsArtigos, pQTD As Integer, pDSC As Integer, pFLG_Entidade As String)
        Me.Cod_Artigo = pArtigo.Cod_Artigo

        Me.Num_Doc = pNum_Doc
        Me.Num_Linha = pLinha + 1
        Me.strNum_Linha = Num_Linha.ToString("00")

        Me.Artigo = pArtigo.Designacao
        Me.FLG_Entidade = pFLG_Entidade
        Me.Quantidade = pQTD
        Me.strQuantidade = Quantidade.ToString
        Me.strP_Unitario = FormatCurrency(P_Unitario, 2)
        Me.Taxa_Desconto = pDSC
        Me.strTaxa_Desconto = Taxa_Desconto.ToString
        Me.strTaxa_IVA = Taxa_IVA.ToString
        Me.strValor_Iliquido = FormatCurrency(Valor_Iliquido, 1)

        Me.FLG_Ativo = True
    End Sub

    '--------------------------------------------
    'Subs
    '--------------------------------------------

    '--------------------------------------------
    ' Exemplo de criador de Código por contador
    ' Para ser usado no caso de o Cdigo ser gerado
    ' e o contador existir na tabela Empresas
    '---------------------------------------------

    'Friend Shared Function GetNovoCodigo() As String

    'Return "L" & ClsEmpresas.GetContador(enCont.Linhas).ToString("000")' <-------------- VERIFICAR O Nº de ZEROS

    'End Function


    Friend Shared Function Init_Linhas(pNum_Doc As String, Optional pN As Integer = 1) As List(Of ClsLinhas)
        Dim mLista As New List(Of ClsLinhas)

        For n As Integer = pN To My.Settings.MAX_Linhas
            Dim mClasse As New ClsLinhas(pNum_Doc, n)

            mLista.Add(mClasse)
        Next

        Return mLista
    End Function

    Public Shared Function GetListaLinhasByCod(pNum_Doc As String) As List(Of ClsLinhas)
        Dim mListaLinhas As New List(Of ClsLinhas)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pNum_Doc", pNum_Doc)

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Num_Doc,'') As Num_Doc,"
        mStrSQL += "ISNULL(Num_Linha,0) As Num_Linha,"
        mStrSQL += "ISNULL(Cod_Artigo,'') As Cod_Artigo,"
        mStrSQL += "ISNULL(Quantidade,0) As Quantidade,"
        mStrSQL += "ISNULL(P_Unitario,0) As P_Unitario,"
        mStrSQL += "ISNULL(Taxa_Desconto,0) As Taxa_Desconto,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Linhas "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Num_Doc=@pNum_Doc"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsLinhas As New ClsLinhas

            With mClsLinhas
                .Num_Doc = mRDR.GetString(mRDR.GetOrdinal("Num_Doc"))
                .Num_Linha = mRDR.GetValue(mRDR.GetOrdinal("Num_Linha"))
                .Cod_Artigo = mRDR.GetString(mRDR.GetOrdinal("Cod_Artigo"))
                .Quantidade = mRDR.GetValue(mRDR.GetOrdinal("Quantidade"))
                .P_Unitario = mRDR.GetDecimal(mRDR.GetOrdinal("P_Unitario"))
                .Taxa_Desconto = mRDR.GetValue(mRDR.GetOrdinal("Taxa_Desconto"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))


                .strNum_Linha = .Num_Linha.ToString("00")
                .strQuantidade = .Quantidade.ToString
                .strP_Unitario = FormatCurrency(.P_Unitario, 2)
                .strTaxa_Desconto = .Taxa_Desconto.ToString
                .strTaxa_IVA = .Taxa_IVA.ToString
                .strValor_Iliquido = FormatCurrency(.Valor_Iliquido, 2)

            End With


            mListaLinhas.Add(mClsLinhas)

        End While

        For n As Integer = mListaLinhas.Count + 1 To My.Settings.MAX_Linhas
            Dim mClasse As New ClsLinhas(pNum_Doc, n)

            mListaLinhas.Add(mClasse)
        Next

        mRDR.Close()
        mDB.Close()

        Return mListaLinhas
    End Function


    ''' <summary>
    '''      Function GetLinhas() Método para devolver a Lista de Linhas
    '''      Gerado em 29/11/2022 14:12:54
    ''' </summary>
    ''' <returns>
    '''      mListaLinhas
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function GetLinhas(ByVal pNum_Doc As String) As List(Of ClsLinhas)
        Dim mListaLinhas As New List(Of ClsLinhas)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pNum_Doc", pNum_Doc)

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Num_Doc,'') As Num_Doc,"
        mStrSQL += "ISNULL(Num_Linha,0) As Num_Linha,"
        mStrSQL += "ISNULL(Quantidade,0) As Quantidade,"
        mStrSQL += "ISNULL(P_Unitario,0) As P_Unitario,"
        mStrSQL += "ISNULL(Taxa_Desconto,0) As Taxa_Desconto,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Linhas "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Num_Doc=@pNum_Doc "


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsLinhas As New ClsLinhas

            With mClsLinhas
                .Num_Doc = mRDR.GetString(mRDR.GetOrdinal("Num_Doc"))
                .Num_Linha = mRDR.GetValue(mRDR.GetOrdinal("Num_Linha"))
                .Quantidade = mRDR.GetValue(mRDR.GetOrdinal("Quantidade"))
                .P_Unitario = mRDR.GetDecimal(mRDR.GetOrdinal("P_Unitario"))
                .Taxa_Desconto = mRDR.GetValue(mRDR.GetOrdinal("Taxa_Desconto"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))

                .strQuantidade = .Quantidade.ToString
                .strTaxa_Desconto = .Taxa_Desconto.ToString
            End With

            mListaLinhas.Add(mClsLinhas)

        End While

        For n As Integer = mListaLinhas.Count To My.Settings.MAX_Linhas - 1
            Dim mClsLinhas As New ClsLinhas(pNum_Doc, n)
            mListaLinhas.Add(mClsLinhas)
        Next

        mRDR.Close()
        mDB.Close()

        Return mListaLinhas
    End Function


    ''' <summary>
    '''      Function GetLinhasByCod(ByVal pNum_Doc As String) Método para decolver uma Classe de Linhas
    '''      Gerado em 29/11/2022 14:12:54
    ''' </summary>
    ''' <returns>
    '''      mClsLinhas
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function GetLinhasByCod(ByVal pNum_Doc As String) As ClsLinhas
        Dim mClsLinhas As New ClsLinhas

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pNum_Doc", pNum_Doc)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Num_Doc,'') As Num_Doc,"
        mStrSQL += "ISNULL(Num_Linha,0) As Num_Linha,"
        mStrSQL += "ISNULL(Cod_Consulta,'') As Cod_Consulta,"
        mStrSQL += "ISNULL(Quantidade,0) As Quantidade,"
        mStrSQL += "ISNULL(P_Unitario,0) As P_Unitario,"
        mStrSQL += "ISNULL(Taxa_Desconto,0) As Taxa_Desconto,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Linhas "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Num_Doc=@pNum_Doc"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsLinhas
                .Num_Doc = mRDR.GetString(mRDR.GetOrdinal("Num_Doc"))
                .Num_Linha = mRDR.GetValue(mRDR.GetOrdinal("Num_Linha"))
                .Quantidade = mRDR.GetValue(mRDR.GetOrdinal("Quantidade"))
                .P_Unitario = mRDR.GetDecimal(mRDR.GetOrdinal("P_Unitario"))
                .Taxa_Desconto = mRDR.GetValue(mRDR.GetOrdinal("Taxa_Desconto"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mClsLinhas
    End Function


    ''' <summary>
    '''      Function ModificaLinhas(ByVal pClsLinhas As ClsLinhas) Método para Modificar a TABELA Linhas
    '''      Gerado em 29/11/2022 14:12:54
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function ModificaLinhas(ByVal pClsLinhas As ClsLinhas) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pNum_Doc", pClsLinhas.Num_Doc.Substring(0, IIf(Len(pClsLinhas.Num_Doc) > 11, 11, Len(pClsLinhas.Num_Doc))))
        mCMD.Parameters.AddWithValue("@pNum_Linha", pClsLinhas.Num_Linha)
        mCMD.Parameters.AddWithValue("@pQuantidade", pClsLinhas.Quantidade)
        mCMD.Parameters.AddWithValue("@pP_Unitario", pClsLinhas.P_Unitario)
        mCMD.Parameters.AddWithValue("@pTaxa_Desconto", pClsLinhas.Taxa_Desconto)


        mStrSQL = "UPDATE Linhas SET "
        mStrSQL += "Num_Linha=@pNum_Linha,"
        mStrSQL += "Cod_Consulta=@pCod_Consulta,"
        mStrSQL += "Quantidade=@pQuantidade,"
        mStrSQL += "P_Unitario=@pP_Unitario,"
        mStrSQL += "Taxa_Desconto=@pTaxa_Desconto "
        mStrSQL += "WHERE Num_Doc=@pNum_Doc"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ModificaLinhas:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function GravaLinhas(ByVal pNovoLinhas As ClsLinhas) Método para Gravar a TABELA Linhas
    '''      Gerado em 29/11/2022 14:12:54
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function GravaLinhas(ByVal pNovoLinhas As ClsLinhas) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()


        mCMD.Parameters.AddWithValue("@pNum_Doc", pNovoLinhas.Num_Doc.Substring(0, IIf(Len(pNovoLinhas.Num_Doc) > 11, 11, Len(pNovoLinhas.Num_Doc))))
        mCMD.Parameters.AddWithValue("@pNum_Linha", pNovoLinhas.Num_Linha)
        mCMD.Parameters.AddWithValue("@pCod_Consulta", pNovoLinhas.Cod_Consulta.Substring(0, IIf(Len(pNovoLinhas.Cod_Consulta) > 5, 5, Len(pNovoLinhas.Cod_Consulta))))
        mCMD.Parameters.AddWithValue("@pQuantidade", pNovoLinhas.Quantidade)
        mCMD.Parameters.AddWithValue("@pP_Unitario", pNovoLinhas.P_Unitario)
        mCMD.Parameters.AddWithValue("@pTaxa_Desconto", pNovoLinhas.Taxa_Desconto)
        mCMD.Parameters.AddWithValue("@pFLG_Ativo", pNovoLinhas.FLG_Ativo)


        mStrSQL = "INSERT INTO Linhas "
        mStrSQL += "("
        mStrSQL += "Num_Doc,"
        mStrSQL += "Num_Linha,"
        mStrSQL += "Cod_Consulta,"
        mStrSQL += "Quantidade,"
        mStrSQL += "P_Unitario,"
        mStrSQL += "Taxa_Desconto,"
        mStrSQL += "FLG_Ativo "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        mStrSQL += "@pNum_Doc,"
        mStrSQL += "@pNum_Linha,"
        mStrSQL += "@pCod_Consulta,"
        mStrSQL += "@pQuantidade,"
        mStrSQL += "@pP_Unitario,"
        mStrSQL += "@pTaxa_Desconto,"
        mStrSQL += "1"
        mStrSQL += ")"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
            'ClsEmpresas.GravaContador(enCont.Linhas)'<<<<-------- Verificar se é  preciso...
        Catch ex As Exception
            MsgBox("GravaLinhas:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function ApagaLinhas(ByVal pNum_Doc As String) Método para Apagar um Registo da Tabela Linhas
    '''      Gerado em 29/11/2022 14:12:54
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function ApagaLinhas(ByVal pNum_Doc As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pNum_Doc", pNum_Doc)


        mStrSQL = "UPDATE Linhas SET "
        mStrSQL += "FLG_Ativo=0 "
        mStrSQL += "WHERE Num_Doc=@pNum_Doc"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ApagaLinhas:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function
End Class

