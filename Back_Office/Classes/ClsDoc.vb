Imports System.Data.SqlClient
Imports System.Math
Imports DevExpress.XtraRichEdit.Import.Rtf

Public Class ClsGrava
    Shared mDB As New SqlConnection
    Shared mCMD As New SqlCommand
    Shared mTR As SqlTransaction

    Public Shared Function Grava_Documento(pDoc As ClsDoc, pTD As ClsTipos_Doc) As Boolean
        Dim mReturn As Boolean = True

        mDB.ConnectionString = My.Settings.Connection
        mDB.Open()
        mCMD.Connection = mDB

        mTR = mDB.BeginTransaction
        mCMD.Transaction = mTR

        '-----------------------
        ' GravaDoc
        '-----------------------

        If Not GravaDoc(pDoc) Then
            mTR.Rollback()
            mReturn = False
            GoTo Erro

        End If
        '-----------------------
        ' GravaLinhas
        '-----------------------
        Dim mNum As Integer = 0
        For Each pLinha As ClsLinhas In pDoc.Linhas

            If pLinha.FLG_Feita Then

                pLinha.Num_Linha = mNum
                mNum += 1
                If Not GravaLinhas(pLinha) Then
                    mTR.Rollback()
                    mReturn = False
                    GoTo Erro
                End If

                Dim mArtigo As New ClsArtigos
                mArtigo = ClsArtigos.GetArtigosByCod(pLinha.Cod_Artigo)

            End If
        Next

        '----------------------
        ' GravaContador
        '----------------------
        If Not GravaContador(pTD.Cod_Serie) Then
            mTR.Rollback()
            mReturn = False
            GoTo Erro
        End If

        mTR.Commit()

Erro:
        mDB.Close()


        Return mReturn
    End Function

    Shared Function GravaContador(pCod_Serie As String) As Boolean
        Dim mReturn As Boolean = True
        Dim mStrSql As String

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Serie", pCod_Serie)

        mStrSql = "UPDATE Series SET "
        mStrSql += "Contador = Contador + 1 "
        mStrSql += "WHERE Cod_Serie = @pCod_Serie"

        mCMD.CommandText = mStrSql

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            'frmMain.udaGrava.Show("Grava Contador!", "Erro ao gravar o contador..." & vbCrLf & ex.ToString)
            MsgBox("Grava Contador:" & vbCrLf & "Erro ao gravar e contador!" & vbCrLf & ex.ToString)
            mReturn = False
        End Try

        Return mReturn
    End Function

    Public Shared Function GravaDoc(ByVal pNovoDoc As ClsDoc) As Boolean
        Dim mReturn As Boolean = True
        Dim mStrSQL As String

        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pNum_Doc", pNovoDoc.Num_Doc.Substring(0, IIf(Len(pNovoDoc.Num_Doc) > 11, 11, Len(pNovoDoc.Num_Doc))))
        mCMD.Parameters.AddWithValue("@pFLG_Tipo_Doc", pNovoDoc.FLG_Tipo_Doc.Substring(0, IIf(Len(pNovoDoc.FLG_Tipo_Doc) > 3, 3, Len(pNovoDoc.FLG_Tipo_Doc))))
        mCMD.Parameters.AddWithValue("@pDesignacao", pNovoDoc.Designacao.Substring(0, IIf(Len(pNovoDoc.Designacao) > 50, 50, Len(pNovoDoc.Designacao))))
        mCMD.Parameters.AddWithValue("@pData_Doc", pNovoDoc.Data_Doc)
        mCMD.Parameters.AddWithValue("@pCod_Entidade", pNovoDoc.Cod_Entidade.Substring(0, IIf(Len(pNovoDoc.Cod_Entidade) > 5, 5, Len(pNovoDoc.Cod_Entidade))))
        mCMD.Parameters.AddWithValue("@pTaxa_Desconto", pNovoDoc.Taxa_Desconto)
        mCMD.Parameters.AddWithValue("@pData_Vencimento", pNovoDoc.Data_Vencimento)
        mCMD.Parameters.AddWithValue("@pFLG_Pago", pNovoDoc.FLG_Pago)
        mCMD.Parameters.AddWithValue("@pTipo_Pagamento", pNovoDoc.Tipo_Pagamento.Substring(0, IIf(Len(pNovoDoc.Tipo_Pagamento) > 30, 30, Len(pNovoDoc.Tipo_Pagamento))))
        mCMD.Parameters.AddWithValue("@pData_Pagamento", pNovoDoc.Data_Pagamento)
        mCMD.Parameters.AddWithValue("@pFLG_Ativo", pNovoDoc.FLG_Ativo)

        mStrSQL = "INSERT INTO Doc "
        mStrSQL += "("
        mStrSQL += "Num_Doc,"
        mStrSQL += "FLG_Tipo_Doc,"
        mStrSQL += "Designacao,"
        mStrSQL += "Data_Doc,"
        mStrSQL += "Cod_Entidade,"
        mStrSQL += "Taxa_Desconto,"
        mStrSQL += "Data_Vencimento,"
        mStrSQL += "FLG_Pago,"
        mStrSQL += "Tipo_Pagamento,"
        mStrSQL += "Data_Pagamento,"
        mStrSQL += "FLG_Ativo "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        mStrSQL += "@pNum_Doc,"
        mStrSQL += "@pFLG_Tipo_Doc,"
        mStrSQL += "@pDesignacao,"
        mStrSQL += "@pData_Doc,"
        mStrSQL += "@pCod_Entidade,"
        mStrSQL += "@pTaxa_Desconto,"
        mStrSQL += "@pData_Vencimento,"
        mStrSQL += "@pFLG_Pago,"
        mStrSQL += "@pTipo_Pagamento,"
        mStrSQL += "@pData_Pagamento,"
        mStrSQL += "1"
        mStrSQL += ")"

        mCMD.CommandText = mStrSQL
        'mDB.Open()
        'mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
            'ClsEmpresas.GravaContador(enCont.Doc)'<<<<-------- Verificar se é  preciso...
        Catch ex As Exception
            'frmLogin.udaGrava.Show("Erro GravaDoc!", "Erro ao Gravar..." & vbCrLf & ex.ToString)
            MsgBox("GravaDoc:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        'mDB.Close()


        Return mReturn
    End Function

    Public Shared Function GravaLinhas(ByVal pNovoLinhas As ClsLinhas) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String

        mCMD.Parameters.Clear()


        mCMD.Parameters.AddWithValue("@pNum_Doc", pNovoLinhas.Num_Doc.Substring(0, IIf(Len(pNovoLinhas.Num_Doc) > 11, 11, Len(pNovoLinhas.Num_Doc))))
        mCMD.Parameters.AddWithValue("@pNum_Linha", pNovoLinhas.Num_Linha)
        mCMD.Parameters.AddWithValue("@pCod_Artigo", pNovoLinhas.Cod_Artigo.Substring(0, IIf(Len(pNovoLinhas.Cod_Artigo) > 8, 8, Len(pNovoLinhas.Cod_Artigo))))
        mCMD.Parameters.AddWithValue("@pQuantidade", pNovoLinhas.Quantidade)
        mCMD.Parameters.AddWithValue("@pP_Unitario", pNovoLinhas.P_Unitario)
        mCMD.Parameters.AddWithValue("@pTaxa_Desconto", pNovoLinhas.Taxa_Desconto)
        mCMD.Parameters.AddWithValue("@pFLG_Ativo", pNovoLinhas.FLG_Ativo)


        mStrSQL = "INSERT INTO Linhas "
        mStrSQL += "("
        mStrSQL += "Num_Doc,"
        mStrSQL += "Num_Linha,"
        mStrSQL += "Cod_Artigo,"
        mStrSQL += "Quantidade,"
        mStrSQL += "P_Unitario,"
        mStrSQL += "Taxa_Desconto,"
        mStrSQL += "FLG_Ativo "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        mStrSQL += "@pNum_Doc,"
        mStrSQL += "@pNum_Linha,"
        mStrSQL += "@pCod_Artigo,"
        mStrSQL += "@pQuantidade,"
        mStrSQL += "@pP_Unitario,"
        mStrSQL += "@pTaxa_Desconto,"
        mStrSQL += "1"
        mStrSQL += ")"


        mCMD.CommandText = mStrSQL
        'mDB.Open()
        'mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
            'ClsEmpresas.GravaContador(enCont.Linhas)'<<<<-------- Verificar se é  preciso...
        Catch ex As Exception
            'frmMain.udaGrava.Show("Erro GravaLinhas!", "Erro ao Gravar..." & vbCrLf & ex.ToString)
            MsgBox("GravaLinhas:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        'mDB.Close()

        Return mReturn

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
End Class

Public Class ClsDoc_Totais
    Public Property Total_Iliquido As Decimal
    Public Property Total_Desconto As Decimal
    Public Property Total_IVA As Decimal
    Public Property Total_Doc As Decimal
    Public Property Acertos As Decimal
    Public Property Total_A_Pagar As Decimal
    Sub New()

    End Sub
    Sub New(pLinhas As List(Of ClsLinhas))

        Total_Iliquido = pLinhas.Sum(Function(x) x.Valor_Iliquido And x.FLG_Feita)
        Total_Desconto = pLinhas.Sum(Function(x) x.Valor_Desconto And x.FLG_Feita)
        Total_IVA = pLinhas.Sum(Function(x) x.Valor_IVA And x.FLG_Feita)
        Total_Doc = (Total_Iliquido - Total_Desconto) + Total_IVA
        Acertos = 0D
        Total_A_Pagar = (Total_Iliquido + Total_IVA) - Total_Desconto

    End Sub
End Class

'Public Class ClsQI
'
'End Class

Public Class ClsTotais
    Public Property Total_Iliquido As Decimal
    Public Property Total_Descontos As Decimal
    Public Property Total_IVA As Decimal
    Public Property Total_Documento As Decimal
    Public Property Acertos As Decimal
    Public Property Total_A_Pagar As Decimal
    Public Property TotalSemanal As Decimal


    Sub New()

    End Sub

    Sub New(pLinhas As List(Of ClsLinhas))

        Total_Iliquido = pLinhas.Sum(Function(x) x.Valor_Iliquido)
        Total_Descontos = pLinhas.Sum(Function(x) x.Valor_Desconto)
        Total_IVA = pLinhas.Sum(Function(x) x.Valor_IVA)
        Total_IVA = Round(Total_IVA, 1)

        Total_Documento = (Total_Iliquido - Total_Descontos) + Total_IVA
        Acertos = 0D
        Total_A_Pagar = Total_Documento + Acertos

    End Sub

    'Sub New(pLinhas As List(Of ClsLinhas), pTD As String)
    '    Dim mDoc As New List(Of ClsDoc1)
    '    Dim mClsDoc As New ClsDoc1
    '    mDoc = ClsDoc1.GetListaDocByTipo(pTD)


    '    mClsDoc.Totais = New ClsDoc_Totais(mDoc)

    '    'With mDoc.Totais
    '    '    Me.lblTotalIliquido.Text = FormatCurrency(.Total_Iliquido)
    '    '    Me.lblTotalDesconto.Text = FormatCurrency(.Total_Desconto)
    '    '    Me.lblTotalIVA.Text = FormatCurrency(.Total_IVA)
    '    '    Me.lblTotalAPagar.Text = FormatCurrency(.Total_A_Pagar)
    '    'End With


    '    Total_Iliquido = pLinhas.Sum(Function(x) x.Valor_Iliquido)
    '    Total_Descontos = pLinhas.Sum(Function(x) x.Valor_Desconto)
    '    Total_IVA = pLinhas.Sum(Function(x) x.Valor_IVA)
    '    Total_IVA = Round(Total_IVA, 1)

    '    Total_Documento = (Total_Iliquido - Total_Descontos) + Total_IVA
    '    Acertos = 0D
    '    Total_A_Pagar = Total_Documento + Acertos
    'End Sub

End Class


''' <summary>
'''      Classe ClsDoc1 Classe da Tabela Doc
'''      Gerado em 03/03/2023 15:49:34
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2023
''' </remarks>
Public Class ClsDoc


    ' -----------------------------------------
    ' Property's da tabela Doc
    ' -----------------------------------------

    Public Property Num_Doc As String                                       ' Len: 11 - SQL_Type: nvarchar
    Public Property FLG_Tipo_Doc As String                                  ' Len:  3 - SQL_Type: nvarchar
    Public Property Cod_Entidade As String                                  ' Len:  8 - SQL_Type: nvarchar
    Public Property Designacao As String                                    ' Len: 50 - SQL_Type: nvarchar
    Public Property Data_Doc As Date                                        ' SQL_Type: smalldatetime
    Public ReadOnly Property Entidade As ClsEntidades
        Get
            Return ClsEntidades.GetEntidadesByCod(Cod_Entidade)
        End Get
    End Property
    Public Property Taxa_Desconto As Integer                                ' SQL_Type: smallint
    Public Property Data_Vencimento As Date                                 ' SQL_Type: smalldatetime
    Public Property FLG_Pago As Boolean                                     ' SQL_Type: bit
    Public Property Tipo_Pagamento As String                                ' Len: 30 - SQL_Type: nvarchar
    Public Property Data_Pagamento As String                                ' Len: 30 - SQL_Type: nvarchar
    Public Property Linhas As New List(Of ClsLinhas)
    Public Property Totais As New ClsDoc_Totais
    Public Property LinhasQI As New List(Of ClsQI)
    Public Property FLG_Ativo As Boolean                                    ' SQL_Type: bit
    Public Property Empresa As ClsEmpresas

    'Public Property Totais As New ClsTotais
    'Public Property QI As New List(Of ClsQI)





    Sub New()
    End Sub

    Sub New(pTD As ClsTipos_Doc)
        With pTD
            Num_Doc = .FLG_Tipo_Doc & (.Contador + 1).ToString("0000") & "/" & .Cod_Serie.Substring(0, 4)
            FLG_Tipo_Doc = .FLG_Tipo_Doc
            Designacao = .Descritivo_Impressao & "-" & Num_Doc

            Linhas = ClsLinhas.Init_Linhas(Num_Doc)

            LinhasQI = ClsQI.GetQI(Linhas)

            Tipo_Pagamento = "Pronto Pagamento"
            Data_Pagamento = Date.Now
            Data_Vencimento = Data_Pagamento
            Data_Doc = Data_Pagamento
            Cod_Entidade = "C001"

            FLG_Ativo = True

        End With

    End Sub



    '--------------------------------------------
    ' Exemplo de criador de Código por contador
    ' Para ser usado no caso de o Cdigo ser gerado
    ' e o contador existir na tabela Empresas
    '---------------------------------------------

    'Friend Shared Function GetNovoCodigo() As String

    'Return "D" & ClsEmpresas.GetContador(enCont.Doc).ToString("000")' <-------------- VERIFICAR O Nº de ZEROS

    'End Function


    ''' <summary>
    '''      Function GetDoc() Método para devolver a Lista de Doc
    '''      Gerado em 03/03/2023 15:49:34
    ''' </summary>
    ''' <returns>
    '''      mListaDoc
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function GetDoc() As List(Of ClsDoc)
        Dim mListaDoc As New List(Of ClsDoc)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Num_Doc,'') As Num_Doc,"
        mStrSQL += "ISNULL(FLG_Tipo_Doc,'') As FLG_Tipo_Doc,"
        mStrSQL += "ISNULL(Cod_Entidade,'') As Cod_Entidade,"
        mStrSQL += "ISNULL(Designacao,'') As Designacao,"
        mStrSQL += "ISNULL(Data_Doc,0) As Data_Doc,"
        mStrSQL += "ISNULL(Taxa_Desconto,0) As Taxa_Desconto,"
        mStrSQL += "ISNULL(Data_Vencimento,0) As Data_Vencimento,"
        mStrSQL += "ISNULL(FLG_Pago,1) As FLG_Pago,"
        mStrSQL += "ISNULL(Tipo_Pagamento,'') As Tipo_Pagamento,"
        mStrSQL += "ISNULL(Data_Pagamento,'') As Data_Pagamento,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Doc "
        mStrSQL += "WHERE FLG_Ativo=1"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsDoc As New ClsDoc

            With mClsDoc
                .Num_Doc = mRDR.GetString(mRDR.GetOrdinal("Num_Doc"))
                .FLG_Tipo_Doc = mRDR.GetString(mRDR.GetOrdinal("FLG_Tipo_Doc"))
                .Cod_Entidade = mRDR.GetString(mRDR.GetOrdinal("Cod_Entidade"))
                .Designacao = mRDR.GetString(mRDR.GetOrdinal("Designacao"))
                .Data_Doc = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Doc"))
                .Taxa_Desconto = mRDR.GetValue(mRDR.GetOrdinal("Taxa_Desconto"))
                .Data_Vencimento = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Vencimento"))
                .FLG_Pago = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Pago"))
                .Tipo_Pagamento = mRDR.GetString(mRDR.GetOrdinal("Tipo_Pagamento"))
                .Data_Pagamento = mRDR.GetString(mRDR.GetOrdinal("Data_Pagamento"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaDoc.Add(mClsDoc)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaDoc
    End Function

    'Public Shared Function GetListaDocByTipo(pTipoDoc As String) As List(Of ClsDoc1)
    '    Dim mListaDoc As New List(Of ClsDoc1)
    '    Dim mAnoAtual As String = Date.Now.Year.ToString


    '    Dim mStrSQL As String
    '    Dim mDB As New SqlConnection
    '    Dim mCMD As New SqlCommand
    '    Dim mRDR As SqlDataReader

    '    mDB.ConnectionString = My.Settings.Connection
    '    mCMD.Parameters.Clear()
    '    mCMD.Parameters.AddWithValue("@pTipoDoc", pTipoDoc)
    '    mCMD.Parameters.AddWithValue("@mData", mAnoAtual)

    '    mStrSQL = "SELECT "
    '    mStrSQL += "ISNULL(Num_Doc,'') As Num_Doc,"
    '    mStrSQL += "ISNULL(FLG_Tipo_Doc,'') As FLG_Tipo_Doc,"
    '    mStrSQL += "ISNULL(Cod_Entidade,'') As Cod_Entidade,"
    '    mStrSQL += "ISNULL(Designacao,'') As Designacao,"
    '    mStrSQL += "ISNULL(Data_Doc,0) As Data_Doc,"
    '    mStrSQL += "ISNULL(Taxa_Desconto,0) As Taxa_Desconto,"
    '    mStrSQL += "ISNULL(Data_Vencimento,0) As Data_Vencimento,"
    '    mStrSQL += "ISNULL(FLG_Pago,1) As FLG_Pago,"
    '    mStrSQL += "ISNULL(Tipo_Pagamento,'') As Tipo_Pagamento,"
    '    mStrSQL += "ISNULL(Data_Pagamento,'') As Data_Pagamento,"
    '    mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
    '    mStrSQL += "FROM Doc "
    '    mStrSQL += "WHERE FLG_Ativo=1 "
    '    mStrSQL += "AND FLG_Tipo_Doc =@pTipoDoc "
    '    mStrSQL += "AND Data_Doc Like '%@mData%' "

    '    mCMD.CommandText = mStrSQL
    '    mDB.Open()
    '    mCMD.Connection = mDB

    '    mRDR = mCMD.ExecuteReader

    '    While mRDR.Read()

    '        Dim mClsDoc As New ClsDoc1

    '        With mClsDoc
    '            .Num_Doc = mRDR.GetString(mRDR.GetOrdinal("Num_Doc"))
    '            .FLG_Tipo_Doc = mRDR.GetString(mRDR.GetOrdinal("FLG_Tipo_Doc"))
    '            .Cod_Entidade = mRDR.GetString(mRDR.GetOrdinal("Cod_Entidade"))
    '            .Designacao = mRDR.GetString(mRDR.GetOrdinal("Designacao"))
    '            .Data_Doc = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Doc"))
    '            .Taxa_Desconto = mRDR.GetValue(mRDR.GetOrdinal("Taxa_Desconto"))
    '            .Data_Vencimento = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Vencimento"))
    '            .FLG_Pago = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Pago"))
    '            .Tipo_Pagamento = mRDR.GetString(mRDR.GetOrdinal("Tipo_Pagamento"))
    '            .Data_Pagamento = mRDR.GetString(mRDR.GetOrdinal("Data_Pagamento"))
    '            .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
    '        End With


    '        mListaDoc.Add(mClsDoc)

    '    End While

    '    mRDR.Close()
    '    mDB.Close()

    '    Return mListaDoc
    'End Function



    ''' <summary>
    '''      Function GetDocByCod(ByVal pNum_Doc As String) Método para decolver uma Classe de Doc
    '''      Gerado em 03/03/2023 15:49:34
    ''' </summary>
    ''' <returns>
    '''      mClsDoc
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function GetDocByCod(ByVal pNum_Doc As String) As ClsDoc
        Dim mClsDoc As New ClsDoc

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pNum_Doc", pNum_Doc)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Num_Doc,'') As Num_Doc,"
        mStrSQL += "ISNULL(FLG_Tipo_Doc,'') As FLG_Tipo_Doc,"
        mStrSQL += "ISNULL(Cod_Entidade,'') As Cod_Entidade,"
        mStrSQL += "ISNULL(Designacao,'') As Designacao,"
        mStrSQL += "ISNULL(Data_Doc,0) As Data_Doc,"
        mStrSQL += "ISNULL(Taxa_Desconto,0) As Taxa_Desconto,"
        mStrSQL += "ISNULL(Data_Vencimento,0) As Data_Vencimento,"
        mStrSQL += "ISNULL(FLG_Pago,1) As FLG_Pago,"
        mStrSQL += "ISNULL(Tipo_Pagamento,'') As Tipo_Pagamento,"
        mStrSQL += "ISNULL(Data_Pagamento,'') As Data_Pagamento,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Doc "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Num_Doc=@pNum_Doc"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsDoc
                .Num_Doc = mRDR.GetString(mRDR.GetOrdinal("Num_Doc"))
                .FLG_Tipo_Doc = mRDR.GetString(mRDR.GetOrdinal("FLG_Tipo_Doc"))
                .Cod_Entidade = mRDR.GetString(mRDR.GetOrdinal("Cod_Entidade"))
                .Designacao = mRDR.GetString(mRDR.GetOrdinal("Designacao"))
                .Data_Doc = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Doc"))
                .Taxa_Desconto = mRDR.GetValue(mRDR.GetOrdinal("Taxa_Desconto"))
                .Data_Vencimento = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Vencimento"))
                .FLG_Pago = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Pago"))
                .Tipo_Pagamento = mRDR.GetString(mRDR.GetOrdinal("Tipo_Pagamento"))
                .Data_Pagamento = mRDR.GetString(mRDR.GetOrdinal("Data_Pagamento"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))

                .Empresa = ClsEmpresas.GetEmpresasByCod("1")
                .Linhas = ClsLinhas.GetListaLinhasByCod(pNum_Doc)
                .Totais = New ClsDoc_Totais(.Linhas)
                .LinhasQI = ClsQI.GetQI(.Linhas)
            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mClsDoc
    End Function


    ''' <summary>
    '''      Function ModificaDoc(ByVal pClsDoc As ClsDoc1) Método para Modificar a TABELA Doc
    '''      Gerado em 03/03/2023 15:49:34
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function ModificaDoc(ByVal pClsDoc As ClsDoc) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pNum_Doc", pClsDoc.Num_Doc.Substring(0, IIf(Len(pClsDoc.Num_Doc) > 11, 11, Len(pClsDoc.Num_Doc))))
        mCMD.Parameters.AddWithValue("@pFLG_Tipo_Doc", pClsDoc.FLG_Tipo_Doc.Substring(0, IIf(Len(pClsDoc.FLG_Tipo_Doc) > 3, 3, Len(pClsDoc.FLG_Tipo_Doc))))
        mCMD.Parameters.AddWithValue("@pCod_Entidade", pClsDoc.Cod_Entidade.Substring(0, IIf(Len(pClsDoc.Cod_Entidade) > 8, 8, Len(pClsDoc.Cod_Entidade))))
        mCMD.Parameters.AddWithValue("@pDesignacao", pClsDoc.Designacao.Substring(0, IIf(Len(pClsDoc.Designacao) > 50, 50, Len(pClsDoc.Designacao))))
        mCMD.Parameters.AddWithValue("@pData_Doc", pClsDoc.Data_Doc)
        mCMD.Parameters.AddWithValue("@pTaxa_Desconto", pClsDoc.Taxa_Desconto)
        mCMD.Parameters.AddWithValue("@pData_Vencimento", pClsDoc.Data_Vencimento)
        mCMD.Parameters.AddWithValue("@pFLG_Pago", pClsDoc.FLG_Pago)
        mCMD.Parameters.AddWithValue("@pTipo_Pagamento", pClsDoc.Tipo_Pagamento.Substring(0, IIf(Len(pClsDoc.Tipo_Pagamento) > 30, 30, Len(pClsDoc.Tipo_Pagamento))))
        mCMD.Parameters.AddWithValue("@pData_Pagamento", pClsDoc.Data_Pagamento.Substring(0, IIf(Len(pClsDoc.Data_Pagamento) > 30, 30, Len(pClsDoc.Data_Pagamento))))


        mStrSQL = "UPDATE Doc SET "
        mStrSQL += "FLG_Tipo_Doc=@pFLG_Tipo_Doc,"
        mStrSQL += "Cod_Entidade=@pCod_Entidade,"
        mStrSQL += "Designacao=@pDesignacao,"
        mStrSQL += "Data_Doc=@pData_Doc,"
        mStrSQL += "Taxa_Desconto=@pTaxa_Desconto,"
        mStrSQL += "Data_Vencimento=@pData_Vencimento,"
        mStrSQL += "FLG_Pago=@pFLG_Pago,"
        mStrSQL += "Tipo_Pagamento=@pTipo_Pagamento,"
        mStrSQL += "Data_Pagamento=@pData_Pagamento "
        mStrSQL += "WHERE Num_Doc=@pNum_Doc"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ModificaDoc:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function GravaDoc(ByVal pNovoDoc As ClsDoc1) Método para Gravar a TABELA Doc
    '''      Gerado em 03/03/2023 15:49:34
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function GravaDoc(ByVal pNovoDoc As ClsDoc) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()


        mCMD.Parameters.AddWithValue("@pNum_Doc", pNovoDoc.Num_Doc.Substring(0, IIf(Len(pNovoDoc.Num_Doc) > 11, 11, Len(pNovoDoc.Num_Doc))))
        mCMD.Parameters.AddWithValue("@pFLG_Tipo_Doc", pNovoDoc.FLG_Tipo_Doc.Substring(0, IIf(Len(pNovoDoc.FLG_Tipo_Doc) > 3, 3, Len(pNovoDoc.FLG_Tipo_Doc))))
        mCMD.Parameters.AddWithValue("@pCod_Entidade", pNovoDoc.Cod_Entidade.Substring(0, IIf(Len(pNovoDoc.Cod_Entidade) > 8, 8, Len(pNovoDoc.Cod_Entidade))))
        mCMD.Parameters.AddWithValue("@pDesignacao", pNovoDoc.Designacao.Substring(0, IIf(Len(pNovoDoc.Designacao) > 50, 50, Len(pNovoDoc.Designacao))))
        mCMD.Parameters.AddWithValue("@pData_Doc", pNovoDoc.Data_Doc)
        mCMD.Parameters.AddWithValue("@pTaxa_Desconto", pNovoDoc.Taxa_Desconto)
        mCMD.Parameters.AddWithValue("@pData_Vencimento", pNovoDoc.Data_Vencimento)
        mCMD.Parameters.AddWithValue("@pFLG_Pago", pNovoDoc.FLG_Pago)
        mCMD.Parameters.AddWithValue("@pTipo_Pagamento", pNovoDoc.Tipo_Pagamento.Substring(0, IIf(Len(pNovoDoc.Tipo_Pagamento) > 30, 30, Len(pNovoDoc.Tipo_Pagamento))))
        mCMD.Parameters.AddWithValue("@pData_Pagamento", pNovoDoc.Data_Pagamento.Substring(0, IIf(Len(pNovoDoc.Data_Pagamento) > 30, 30, Len(pNovoDoc.Data_Pagamento))))
        mCMD.Parameters.AddWithValue("@pFLG_Ativo", pNovoDoc.FLG_Ativo)


        mStrSQL = "INSERT INTO Doc "
        mStrSQL += "("
        mStrSQL += "Num_Doc,"
        mStrSQL += "FLG_Tipo_Doc,"
        mStrSQL += "Cod_Entidade,"
        mStrSQL += "Designacao,"
        mStrSQL += "Data_Doc,"
        mStrSQL += "Taxa_Desconto,"
        mStrSQL += "Data_Vencimento,"
        mStrSQL += "FLG_Pago,"
        mStrSQL += "Tipo_Pagamento,"
        mStrSQL += "Data_Pagamento,"
        mStrSQL += "FLG_Ativo "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        mStrSQL += "@pNum_Doc,"
        mStrSQL += "@pFLG_Tipo_Doc,"
        mStrSQL += "@pCod_Entidade,"
        mStrSQL += "@pDesignacao,"
        mStrSQL += "@pData_Doc,"
        mStrSQL += "@pTaxa_Desconto,"
        mStrSQL += "@pData_Vencimento,"
        mStrSQL += "@pFLG_Pago,"
        mStrSQL += "@pTipo_Pagamento,"
        mStrSQL += "@pData_Pagamento,"
        mStrSQL += "1"
        mStrSQL += ")"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
            'ClsEmpresas.GravaContador(enCont.Doc)'<<<<-------- Verificar se é  preciso...
        Catch ex As Exception
            MsgBox("GravaDoc:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function ApagaDoc(ByVal pNum_Doc As String) Método para Apagar um Registo da Tabela Doc
    '''      Gerado em 03/03/2023 15:49:34
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function ApagaDoc(ByVal pNum_Doc As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pNum_Doc", pNum_Doc)


        mStrSQL = "UPDATE Doc SET "
        mStrSQL += "FLG_Ativo=0 "
        mStrSQL += "WHERE Num_Doc=@pNum_Doc"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ApagaDoc:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function
End Class

