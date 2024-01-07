
Imports System.Data.SqlClient
Imports Infragistics.Win.UltraWinGrid

Public Enum enCont As Integer

    Clientes
    Funcionarios
    Veterinarios
    Consultas
    Categorias
    Tipos_Consulta
    Animais
    Artigos
    Tipos_Animais
    Tipos_Pagamento
    IVA
    Servicos
    Produtos
    Racas
    Salas

End Enum


''' <summary>
'''      Classe ClsEmpresas Classe da Tabela Empresas
'''      Gerado em 03/03/2023 15:49:34
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2023
''' </remarks>
Public Class ClsEmpresas


    ' -----------------------------------------
    ' Property's da tabela Empresas
    ' -----------------------------------------

    Public Property Cod_Empresa As String                                   ' Len:  1 - SQL_Type: nvarchar
    Public Property Nome As String                                          ' Len: 50 - SQL_Type: nvarchar
    Public Property Endereco As String                                      ' Len: 50 - SQL_Type: nvarchar
    Public Property Pais As String                                          ' Len: 30 - SQL_Type: nvarchar
    Public Property Cod_Postal As String                                    ' Len:  8 - SQL_Type: nvarchar
    Public Property Localidade As String                                    ' Len: 50 - SQL_Type: nvarchar
    Public Property Email As String                                         ' Len: 50 - SQL_Type: nvarchar
    Public Property Num_Telefone As String                                  ' Len:  9 - SQL_Type: nvarchar
    Public Property Capital_Social As String                                ' Len: 14 - SQL_Type: nvarchar
    Public Property Registo_Comercial As String                             ' Len: 30 - SQL_Type: nvarchar
    Public Property Matricula_CRC As String                                 ' Len: 20 - SQL_Type: nvarchar
    Public Property NIF As String                                           ' Len:  9 - SQL_Type: nvarchar
    Public Property Contador_Categorias As Integer                          ' SQL_Type: smallint
    Public Property Contador_Clientes As Integer                            ' SQL_Type: smallint
    Public Property Contador_Funcionarios As Integer                        ' SQL_Type: smallint
    Public Property Contador_Veterinarios As Integer                        ' SQL_Type: smallint
    Public Property Contador_Consultas As Integer                           ' SQL_Type: smallint
    Public Property Contador_Tipos_Consulta As Integer                      ' SQL_Type: smallint
    Public Property Contador_Animais As Integer                             ' SQL_Type: smallint
    Public Property Contador_Artigos As Integer                             ' SQL_Type: smallint
    Public Property Contador_Tipos_Animais As Integer                       ' SQL_Type: smallint
    Public Property Contador_Tipos_Pagamento As Integer                     ' SQL_Type: smallint
    Public Property Contador_IVA As Integer                                 ' SQL_Type: smallint
    Public Property Contador_Servicos As Integer
    Public Property Contador_Produtos As Integer
    Public Property Contador_Racas As Integer                               ' SQL_Type: smallint
    Public Property Contador_Salas As Integer
    Public Property Ano_Trabalho As String                                  ' Len:  4 - SQL_Type: nvarchar
    Public Property FLG_Ativo As Boolean                                    ' SQL_Type: bit


    Sub New()
    End Sub


    '--------------------------------------------
    ' Exemplo de criador de Código por contador
    ' Para ser usado no caso de o Cdigo ser gerado
    ' e o contador existir na tabela Empresas
    '---------------------------------------------

    'Friend Shared Function GetNovoCodigo() As String

    'Return "E" & ClsEmpresas.GetContador(enCont.Empresas).ToString("000")' <-------------- VERIFICAR O Nº de ZEROS

    'End Function

    ''' <summary>
    '''      Function GetContador (ByVal pEnum as Encont) - Método para devolver o contador específico guardado na Tabela Empresas
    '''      Gerado em 03/03/2023 15:49:34
    ''' </summary>
    ''' <returns>
    '''      Contador guardado + 1
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Friend Shared Function GetContador(pEnum As enCont) As Integer
        Dim mReturn As Integer = 0


        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Contador_Categorias,0) As Contador_Categorias,"
        mStrSQL += "ISNULL(Contador_Clientes,0) As Contador_Clientes,"
        mStrSQL += "ISNULL(Contador_Funcionarios,0) As Contador_Funcionarios,"
        mStrSQL += "ISNULL(Contador_Veterinarios,0) As Contador_Veterinarios,"
        mStrSQL += "ISNULL(Contador_Consultas,0) As Contador_Consultas,"
        mStrSQL += "ISNULL(Contador_Tipos_Consulta,0) As Contador_Tipos_Consulta,"
        mStrSQL += "ISNULL(Contador_Animais,0) As Contador_Animais,"
        mStrSQL += "ISNULL(Contador_Artigos,0) As Contador_Artigos,"
        mStrSQL += "ISNULL(Contador_Tipos_Animais,0) As Contador_Tipos_Animais,"
        mStrSQL += "ISNULL(Contador_Tipos_Pagamento,0) As Contador_Tipos_Pagamento,"
        mStrSQL += "ISNULL(Contador_IVA,0) As Contador_IVA,"
        mStrSQL += "ISNULL(Contador_Servicos,0) As Contador_Servicos,"
        mStrSQL += "ISNULL(Contador_Produtos,0) As Contador_Produtos,"
        mStrSQL += "ISNULL(Contador_Racas,0) As Contador_Racas,"
        mStrSQL += "ISNULL(Contador_Salas,0) As Contador_Salas "
        mStrSQL += "FROM Empresas "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Cod_Empresa='1'"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then

            Select Case pEnum

                Case enCont.Categorias
                    mReturn = mRDR.GetValue(mRDR.GetOrdinal("Contador_Categorias"))
                Case enCont.Clientes
                    mReturn = mRDR.GetValue(mRDR.GetOrdinal("Contador_Clientes"))
                Case enCont.Funcionarios
                    mReturn = mRDR.GetValue(mRDR.GetOrdinal("Contador_Funcionarios"))
                Case enCont.Veterinarios
                    mReturn = mRDR.GetValue(mRDR.GetOrdinal("Contador_Veterinarios"))
                Case enCont.Consultas
                    mReturn = mRDR.GetValue(mRDR.GetOrdinal("Contador_Consultas"))
                Case enCont.Tipos_Consulta
                    mReturn = mRDR.GetValue(mRDR.GetOrdinal("Contador_Tipos_Consulta"))
                Case enCont.Animais
                    mReturn = mRDR.GetValue(mRDR.GetOrdinal("Contador_Animais"))
                Case enCont.Artigos
                    mReturn = mRDR.GetValue(mRDR.GetOrdinal("Contador_Artigos"))
                Case enCont.Tipos_Animais
                    mReturn = mRDR.GetValue(mRDR.GetOrdinal("Contador_Tipos_Animais"))
                Case enCont.Tipos_Pagamento
                    mReturn = mRDR.GetValue(mRDR.GetOrdinal("Contador_Tipos_Pagamento"))
                Case enCont.IVA
                    mReturn = mRDR.GetValue(mRDR.GetOrdinal("Contador_IVA"))
                Case enCont.Produtos
                    mReturn = mRDR.GetValue(mRDR.GetOrdinal("Contador_Produtos"))
                Case enCont.Servicos
                    mReturn = mRDR.GetValue(mRDR.GetOrdinal("Contador_Servicos"))
                Case enCont.Racas
                    mReturn = mRDR.GetValue(mRDR.GetOrdinal("Contador_Racas"))
                Case enCont.Salas
                    mReturn = mRDR.GetValue(mRDR.GetOrdinal("Contador_Salas"))

            End Select

        End If
        mRDR.Close()
        mDB.Close()

        Return mReturn + 1
    End Function


    Friend Shared Function GravaAnoAtual(mAnoAtual As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pAnoAtual", mAnoAtual)

        mStrSQL = "UPDATE Empresas SET "
        mStrSQL += "Ano_Trabalho=@pAnoAtual "
        mStrSQL += "WHERE Cod_Empresa='1'"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("GravaAno:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn
    End Function




    ''' <summary>
    '''      Function GravaContador (ByVal pEnum as Encont) - Método para Gravar o Contador específico na Tabela Empresas
    '''      Gerado em 03/03/2023 15:49:34
    ''' </summary>
    ''' <returns>
    '''      True ou False
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Friend Shared Function GravaContador(pEnum As enCont) As Integer
        Dim mReturn As Boolean = True


        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()


        mStrSQL = "UPDATE Empresas SET "
        Select Case pEnum
            Case enCont.Categorias
                mStrSQL += "Contador_Categorias= Contador_Categorias+1 "
            Case enCont.Clientes
                mStrSQL += "Contador_Clientes= Contador_Clientes+1 "
            Case enCont.Funcionarios
                mStrSQL += "Contador_Funcionarios= Contador_Funcionarios+1 "
            Case enCont.Veterinarios
                mStrSQL += "Contador_Veterinarios= Contador_Veterinarios+1 "
            Case enCont.Consultas
                mStrSQL += "Contador_Consultas= Contador_Consultas+1 "
            Case enCont.Tipos_Consulta
                mStrSQL += "Contador_Tipos_Consulta= Contador_Tipos_Consulta+1 "
            Case enCont.Animais
                mStrSQL += "Contador_Animais= Contador_Animais+1 "
            Case enCont.Artigos
                mStrSQL += "Contador_Artigos= Contador_Artigos+1 "
            Case enCont.Tipos_Animais
                mStrSQL += "Contador_Tipos_Animais= Contador_Tipos_Animais+1 "
            Case enCont.Tipos_Pagamento
                mStrSQL += "Contador_Tipos_Pagamento= Contador_Tipos_Pagamento+1 "
            Case enCont.IVA
                mStrSQL += "Contador_IVA= Contador_IVA+1 "
            Case enCont.Servicos
                mStrSQL += "Contador_Servicos= Contador_Servicos+1 "
            Case enCont.Produtos
                mStrSQL += "Contador_Produtos= Contador_Produtos+1 "
            Case enCont.Racas
                mStrSQL += "Contador_Racas= Contador_Racas+1 "
            Case enCont.Salas
                mStrSQL += "Contador_Salas= Contador_Salas+1 "
        End Select
        mStrSQL += "WHERE Cod_Empresa='1'"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("GravaContador:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn
    End Function


    ''' <summary>
    '''      Function GetEmpresas() Método para devolver a Lista de Empresas
    '''      Gerado em 03/03/2023 15:49:34
    ''' </summary>
    ''' <returns>
    '''      mListaEmpresas
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function GetEmpresas() As List(Of ClsEmpresas)
        Dim mListaEmpresas As New List(Of ClsEmpresas)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Empresa,'') As Cod_Empresa,"
        mStrSQL += "ISNULL(Nome,'') As Nome,"
        mStrSQL += "ISNULL(Endereco,'') As Endereco,"
        mStrSQL += "ISNULL(Pais,'') As Pais,"
        mStrSQL += "ISNULL(Cod_Postal,'') As Cod_Postal,"
        mStrSQL += "ISNULL(Localidade,'') As Localidade,"
        mStrSQL += "ISNULL(Email,'') As Email,"
        mStrSQL += "ISNULL(Num_Telefone,'') As Num_Telefone,"
        mStrSQL += "ISNULL(Capital_Social,'') As Capital_Social,"
        mStrSQL += "ISNULL(Registo_Comercial,'') As Registo_Comercial,"
        mStrSQL += "ISNULL(Matricula_CRC,'') As Matricula_CRC,"
        mStrSQL += "ISNULL(NIF,'') As NIF,"
        mStrSQL += "ISNULL(Contador_Categorias,0) As Contador_Categorias,"
        mStrSQL += "ISNULL(Contador_Clientes,0) As Contador_Clientes,"
        mStrSQL += "ISNULL(Contador_Funcionarios,0) As Contador_Funcionarios,"
        mStrSQL += "ISNULL(Contador_Veterinarios,0) As Contador_Veterinarios,"
        mStrSQL += "ISNULL(Contador_Consultas,0) As Contador_Consultas,"
        mStrSQL += "ISNULL(Contador_Tipos_Consulta,0) As Contador_Tipos_Consulta,"
        mStrSQL += "ISNULL(Contador_Animais,0) As Contador_Animais,"
        mStrSQL += "ISNULL(Contador_Artigos,0) As Contador_Artigos,"
        mStrSQL += "ISNULL(Contador_Tipos_Animais,0) As Contador_Tipos_Animais,"
        mStrSQL += "ISNULL(Contador_Tipos_Pagamento,0) As Contador_Tipos_Pagamento,"
        mStrSQL += "ISNULL(Contador_IVA,0) As Contador_IVA,"
        mStrSQL += "ISNULL(Contador_Servicos,0) As Contador_Servicos,"
        mStrSQL += "ISNULL(Contador_Produtos,0) As Contador_Produtos,"
        mStrSQL += "ISNULL(Contador_Racas,0) As Contador_Racas,"
        mStrSQL += "ISNULL(Contador_Salas,0) As Contador_Salas,"
        mStrSQL += "ISNULL(Ano_Trabalho,'') As Ano_Trabalho,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Empresas "
        mStrSQL += "WHERE FLG_Ativo=1"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsEmpresas As New ClsEmpresas

            With mClsEmpresas
                .Cod_Empresa = mRDR.GetString(mRDR.GetOrdinal("Cod_Empresa"))
                .Nome = mRDR.GetString(mRDR.GetOrdinal("Nome"))
                .Endereco = mRDR.GetString(mRDR.GetOrdinal("Endereco"))
                .Pais = mRDR.GetString(mRDR.GetOrdinal("Pais"))
                .Cod_Postal = mRDR.GetString(mRDR.GetOrdinal("Cod_Postal"))
                .Localidade = mRDR.GetString(mRDR.GetOrdinal("Localidade"))
                .Email = mRDR.GetString(mRDR.GetOrdinal("Email"))
                .Num_Telefone = mRDR.GetString(mRDR.GetOrdinal("Num_Telefone"))
                .Capital_Social = mRDR.GetString(mRDR.GetOrdinal("Capital_Social"))
                .Registo_Comercial = mRDR.GetString(mRDR.GetOrdinal("Registo_Comercial"))
                .Matricula_CRC = mRDR.GetString(mRDR.GetOrdinal("Matricula_CRC"))
                .NIF = mRDR.GetString(mRDR.GetOrdinal("NIF"))
                .Contador_Categorias = mRDR.GetValue(mRDR.GetOrdinal("Contador_Categorias"))
                .Contador_Clientes = mRDR.GetValue(mRDR.GetOrdinal("Contador_Clientes"))
                .Contador_Funcionarios = mRDR.GetValue(mRDR.GetOrdinal("Contador_Funcionarios"))
                .Contador_Veterinarios = mRDR.GetValue(mRDR.GetOrdinal("Contador_Veterinarios"))
                .Contador_Consultas = mRDR.GetValue(mRDR.GetOrdinal("Contador_Consultas"))
                .Contador_Tipos_Consulta = mRDR.GetValue(mRDR.GetOrdinal("Contador_Tipos_Consulta"))
                .Contador_Animais = mRDR.GetValue(mRDR.GetOrdinal("Contador_Animais"))
                .Contador_Artigos = mRDR.GetValue(mRDR.GetOrdinal("Contador_Artigos"))
                .Contador_Tipos_Animais = mRDR.GetValue(mRDR.GetOrdinal("Contador_Tipos_Animais"))
                .Contador_Tipos_Pagamento = mRDR.GetValue(mRDR.GetOrdinal("Contador_Tipos_Pagamento"))
                .Contador_IVA = mRDR.GetValue(mRDR.GetOrdinal("Contador_IVA"))
                .Contador_Servicos = mRDR.GetValue(mRDR.GetOrdinal("Contador_Servicos"))
                .Contador_Produtos = mRDR.GetValue(mRDR.GetOrdinal("Contador_Produtos"))
                .Contador_Racas = mRDR.GetValue(mRDR.GetOrdinal("Contador_Racas"))
                .Contador_Salas = mRDR.GetValue(mRDR.GetOrdinal("Contador_Salas"))
                .Ano_Trabalho = mRDR.GetString(mRDR.GetOrdinal("Ano_Trabalho"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaEmpresas.Add(mClsEmpresas)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaEmpresas
    End Function

    ''' <summary>
    '''      Function FiltrarEmpresas Método para Filtrar os campos da lista de Empresas
    '''      Gerado em 03/03/2023 15:49:34
    ''' </summary>
    ''' <returns>
    '''      mListaEmpresas
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function FiltrarEmpresas(ByVal pFiltro As ClsEmpresas) As List(Of ClsEmpresas)
        Dim mListaEmpresas As New List(Of ClsEmpresas)
        Dim mLista As New List(Of ClsEmpresas)

        mListaEmpresas = GetEmpresas()

        mLista = mListaEmpresas.FindAll(Function(x) _
        x.Cod_Empresa.Contains(pFiltro.Cod_Empresa)
        )
        '-----------------------------------------------------
        'Pode Colocar em cima mais colunas como esta abaixo...
        '-----------------------------------------------------
        ' AND x.Nome.Contains(pFiltro.Nome) 

        Return mLista
    End Function


    ''' <summary>
    '''      Function GetEmpresasByCod(ByVal pCod_Empresa As String) Método para decolver uma Classe de Empresas
    '''      Gerado em 03/03/2023 15:49:34
    ''' </summary>
    ''' <returns>
    '''      mClsEmpresas
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function GetEmpresasByCod(ByVal pCod_Empresa As String) As ClsEmpresas
        Dim mClsEmpresas As New ClsEmpresas

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Empresa", pCod_Empresa)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Empresa,'') As Cod_Empresa,"
        mStrSQL += "ISNULL(Nome,'') As Nome,"
        mStrSQL += "ISNULL(Endereco,'') As Endereco,"
        mStrSQL += "ISNULL(Pais,'') As Pais,"
        mStrSQL += "ISNULL(Cod_Postal,'') As Cod_Postal,"
        mStrSQL += "ISNULL(Localidade,'') As Localidade,"
        mStrSQL += "ISNULL(Email,'') As Email,"
        mStrSQL += "ISNULL(Num_Telefone,'') As Num_Telefone,"
        mStrSQL += "ISNULL(Capital_Social,'') As Capital_Social,"
        mStrSQL += "ISNULL(Registo_Comercial,'') As Registo_Comercial,"
        mStrSQL += "ISNULL(Matricula_CRC,'') As Matricula_CRC,"
        mStrSQL += "ISNULL(NIF,'') As NIF,"
        mStrSQL += "ISNULL(Contador_Categorias,0) As Contador_Categorias,"
        mStrSQL += "ISNULL(Contador_Clientes,0) As Contador_Clientes,"
        mStrSQL += "ISNULL(Contador_Funcionarios,0) As Contador_Funcionarios,"
        mStrSQL += "ISNULL(Contador_Veterinarios,0) As Contador_Veterinarios,"
        mStrSQL += "ISNULL(Contador_Consultas,0) As Contador_Consultas,"
        mStrSQL += "ISNULL(Contador_Tipos_Consulta,0) As Contador_Tipos_Consulta,"
        mStrSQL += "ISNULL(Contador_Animais,0) As Contador_Animais,"
        mStrSQL += "ISNULL(Contador_Artigos,0) As Contador_Artigos,"
        mStrSQL += "ISNULL(Contador_Tipos_Animais,0) As Contador_Tipos_Animais,"
        mStrSQL += "ISNULL(Contador_Tipos_Pagamento,0) As Contador_Tipos_Pagamento,"
        mStrSQL += "ISNULL(Contador_IVA,0) As Contador_IVA,"
        mStrSQL += "ISNULL(Contador_Servicos,0) As Contador_Servicos,"
        mStrSQL += "ISNULL(Contador_Produtos,0) As Contador_Produtos,"
        mStrSQL += "ISNULL(Contador_Racas,0) As Contador_Racas,"
        mStrSQL += "ISNULL(Contador_Salas,0) As Contador_Salas,"
        mStrSQL += "ISNULL(Ano_Trabalho,'') As Ano_Trabalho,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Empresas "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Cod_Empresa=@pCod_Empresa"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsEmpresas
                .Cod_Empresa = mRDR.GetString(mRDR.GetOrdinal("Cod_Empresa"))
                .Nome = mRDR.GetString(mRDR.GetOrdinal("Nome"))
                .Endereco = mRDR.GetString(mRDR.GetOrdinal("Endereco"))
                .Pais = mRDR.GetString(mRDR.GetOrdinal("Pais"))
                .Cod_Postal = mRDR.GetString(mRDR.GetOrdinal("Cod_Postal"))
                .Localidade = mRDR.GetString(mRDR.GetOrdinal("Localidade"))
                .Email = mRDR.GetString(mRDR.GetOrdinal("Email"))
                .Num_Telefone = mRDR.GetString(mRDR.GetOrdinal("Num_Telefone"))
                .Capital_Social = mRDR.GetString(mRDR.GetOrdinal("Capital_Social"))
                .Registo_Comercial = mRDR.GetString(mRDR.GetOrdinal("Registo_Comercial"))
                .Matricula_CRC = mRDR.GetString(mRDR.GetOrdinal("Matricula_CRC"))
                .NIF = mRDR.GetString(mRDR.GetOrdinal("NIF"))
                .Contador_Categorias = mRDR.GetValue(mRDR.GetOrdinal("Contador_Categorias"))
                .Contador_Clientes = mRDR.GetValue(mRDR.GetOrdinal("Contador_Clientes"))
                .Contador_Funcionarios = mRDR.GetValue(mRDR.GetOrdinal("Contador_Funcionarios"))
                .Contador_Veterinarios = mRDR.GetValue(mRDR.GetOrdinal("Contador_Veterinarios"))
                .Contador_Consultas = mRDR.GetValue(mRDR.GetOrdinal("Contador_Consultas"))
                .Contador_Tipos_Consulta = mRDR.GetValue(mRDR.GetOrdinal("Contador_Tipos_Consulta"))
                .Contador_Animais = mRDR.GetValue(mRDR.GetOrdinal("Contador_Animais"))
                .Contador_Artigos = mRDR.GetValue(mRDR.GetOrdinal("Contador_Artigos"))
                .Contador_Tipos_Animais = mRDR.GetValue(mRDR.GetOrdinal("Contador_Tipos_Animais"))
                .Contador_Tipos_Pagamento = mRDR.GetValue(mRDR.GetOrdinal("Contador_Tipos_Pagamento"))
                .Contador_IVA = mRDR.GetValue(mRDR.GetOrdinal("Contador_IVA"))
                .Contador_Servicos = mRDR.GetValue(mRDR.GetOrdinal("Contador_Servicos"))
                .Contador_Produtos = mRDR.GetValue(mRDR.GetOrdinal("Contador_Produtos"))
                .Contador_Racas = mRDR.GetValue(mRDR.GetOrdinal("Contador_Racas"))
                .Contador_Salas = mRDR.GetValue(mRDR.GetOrdinal("Contador_Salas"))
                .Ano_Trabalho = mRDR.GetString(mRDR.GetOrdinal("Ano_Trabalho"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mClsEmpresas
    End Function


    ''' <summary>
    '''      Function ModificaEmpresas(ByVal pClsEmpresas As ClsEmpresas) Método para Modificar a TABELA Empresas
    '''      Gerado em 03/03/2023 15:49:34
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function ModificaEmpresas(ByVal pClsEmpresas As ClsEmpresas) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Empresa", pClsEmpresas.Cod_Empresa.Substring(0, IIf(Len(pClsEmpresas.Cod_Empresa) > 1, 1, Len(pClsEmpresas.Cod_Empresa))))
        mCMD.Parameters.AddWithValue("@pNome", pClsEmpresas.Nome.Substring(0, IIf(Len(pClsEmpresas.Nome) > 50, 50, Len(pClsEmpresas.Nome))))
        mCMD.Parameters.AddWithValue("@pEndereco", pClsEmpresas.Endereco.Substring(0, IIf(Len(pClsEmpresas.Endereco) > 50, 50, Len(pClsEmpresas.Endereco))))
        mCMD.Parameters.AddWithValue("@pPais", pClsEmpresas.Pais.Substring(0, IIf(Len(pClsEmpresas.Pais) > 30, 30, Len(pClsEmpresas.Pais))))
        mCMD.Parameters.AddWithValue("@pCod_Postal", pClsEmpresas.Cod_Postal.Substring(0, IIf(Len(pClsEmpresas.Cod_Postal) > 8, 8, Len(pClsEmpresas.Cod_Postal))))
        mCMD.Parameters.AddWithValue("@pLocalidade", pClsEmpresas.Localidade.Substring(0, IIf(Len(pClsEmpresas.Localidade) > 50, 50, Len(pClsEmpresas.Localidade))))
        mCMD.Parameters.AddWithValue("@pEmail", pClsEmpresas.Email.Substring(0, IIf(Len(pClsEmpresas.Email) > 50, 50, Len(pClsEmpresas.Email))))
        mCMD.Parameters.AddWithValue("@pNum_Telefone", pClsEmpresas.Num_Telefone.Substring(0, IIf(Len(pClsEmpresas.Num_Telefone) > 9, 9, Len(pClsEmpresas.Num_Telefone))))
        mCMD.Parameters.AddWithValue("@pCapital_Social", pClsEmpresas.Capital_Social.Substring(0, IIf(Len(pClsEmpresas.Capital_Social) > 14, 14, Len(pClsEmpresas.Capital_Social))))
        mCMD.Parameters.AddWithValue("@pRegisto_Comercial", pClsEmpresas.Registo_Comercial.Substring(0, IIf(Len(pClsEmpresas.Registo_Comercial) > 30, 30, Len(pClsEmpresas.Registo_Comercial))))
        mCMD.Parameters.AddWithValue("@pMatricula_CRC", pClsEmpresas.Matricula_CRC.Substring(0, IIf(Len(pClsEmpresas.Matricula_CRC) > 20, 20, Len(pClsEmpresas.Matricula_CRC))))
        mCMD.Parameters.AddWithValue("@pNIF", pClsEmpresas.NIF.Substring(0, IIf(Len(pClsEmpresas.NIF) > 9, 9, Len(pClsEmpresas.NIF))))
        mCMD.Parameters.AddWithValue("@pContador_Categorias", pClsEmpresas.Contador_Categorias)
        mCMD.Parameters.AddWithValue("@pContador_Clientes", pClsEmpresas.Contador_Clientes)
        mCMD.Parameters.AddWithValue("@pContador_Funcionarios", pClsEmpresas.Contador_Funcionarios)
        mCMD.Parameters.AddWithValue("@pContador_Veterinarios", pClsEmpresas.Contador_Veterinarios)
        mCMD.Parameters.AddWithValue("@pContador_Consultas", pClsEmpresas.Contador_Consultas)
        mCMD.Parameters.AddWithValue("@pContador_Tipos_Consulta", pClsEmpresas.Contador_Tipos_Consulta)
        mCMD.Parameters.AddWithValue("@pContador_Animais", pClsEmpresas.Contador_Animais)
        mCMD.Parameters.AddWithValue("@pContador_Artigos", pClsEmpresas.Contador_Artigos)
        mCMD.Parameters.AddWithValue("@pContador_Tipos_Animais", pClsEmpresas.Contador_Tipos_Animais)
        mCMD.Parameters.AddWithValue("@pContador_Tipos_Pagamento", pClsEmpresas.Contador_Tipos_Pagamento)
        mCMD.Parameters.AddWithValue("@pContador_IVA", pClsEmpresas.Contador_IVA)
        mCMD.Parameters.AddWithValue("@pContador_Servicos", pClsEmpresas.Contador_Servicos)
        mCMD.Parameters.AddWithValue("@pContador_Produtos", pClsEmpresas.Contador_Produtos)
        mCMD.Parameters.AddWithValue("@pContador_Racas", pClsEmpresas.Contador_Racas)
        mCMD.Parameters.AddWithValue("@pContador_Salas", pClsEmpresas.Contador_Salas)
        mCMD.Parameters.AddWithValue("@pAno_Trabalho", pClsEmpresas.Ano_Trabalho.Substring(0, IIf(Len(pClsEmpresas.Ano_Trabalho) > 4, 4, Len(pClsEmpresas.Ano_Trabalho))))


        mStrSQL = "UPDATE Empresas SET "
        mStrSQL += "Nome=@pNome,"
        mStrSQL += "Endereco=@pEndereco,"
        mStrSQL += "Pais=@pPais,"
        mStrSQL += "Cod_Postal=@pCod_Postal,"
        mStrSQL += "Localidade=@pLocalidade,"
        mStrSQL += "Email=@pEmail,"
        mStrSQL += "Num_Telefone=@pNum_Telefone,"
        mStrSQL += "Capital_Social=@pCapital_Social,"
        mStrSQL += "Registo_Comercial=@pRegisto_Comercial,"
        mStrSQL += "Matricula_CRC=@pMatricula_CRC,"
        mStrSQL += "NIF=@pNIF,"
        mStrSQL += "Contador_Categorias=@pContador_Categorias,"
        mStrSQL += "Contador_Clientes=@pContador_Clientes,"
        mStrSQL += "Contador_Funcionarios=@pContador_Funcionarios,"
        mStrSQL += "Contador_Veterinarios=@pContador_Veterinarios,"
        mStrSQL += "Contador_Consultas=@pContador_Consultas,"
        mStrSQL += "Contador_Tipos_Consulta=@pContador_Tipos_Consulta,"
        mStrSQL += "Contador_Animais=@pContador_Animais,"
        mStrSQL += "Contador_Artigos=@pContador_Artigos,"
        mStrSQL += "Contador_Tipos_Animais=@pContador_Tipos_Animais,"
        mStrSQL += "Contador_Tipos_Pagamento=@pContador_Tipos_Pagamento,"
        mStrSQL += "Contador_IVA=@pContador_IVA,"
        mStrSQL += "Contador_Servicos=@pContador_Servicos,"
        mStrSQL += "Contador_Produtos=@pContador_Produtos,"
        mStrSQL += "Contador_Racas=@pContador_Racas,"
        mStrSQL += "Contador_Salas=@pContador_Salas,"
        mStrSQL += "Ano_Trabalho=@pAno_Trabalho "
        mStrSQL += "WHERE Cod_Empresa=@pCod_Empresa"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ModificaEmpresas:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function GravaEmpresas(ByVal pNovoEmpresas As ClsEmpresas) Método para Gravar a TABELA Empresas
    '''      Gerado em 03/03/2023 15:49:34
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function GravaEmpresas(ByVal pNovoEmpresas As ClsEmpresas) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()


        mCMD.Parameters.AddWithValue("@pCod_Empresa", pNovoEmpresas.Cod_Empresa.Substring(0, IIf(Len(pNovoEmpresas.Cod_Empresa) > 1, 1, Len(pNovoEmpresas.Cod_Empresa))))
        mCMD.Parameters.AddWithValue("@pNome", pNovoEmpresas.Nome.Substring(0, IIf(Len(pNovoEmpresas.Nome) > 50, 50, Len(pNovoEmpresas.Nome))))
        mCMD.Parameters.AddWithValue("@pEndereco", pNovoEmpresas.Endereco.Substring(0, IIf(Len(pNovoEmpresas.Endereco) > 50, 50, Len(pNovoEmpresas.Endereco))))
        mCMD.Parameters.AddWithValue("@pPais", pNovoEmpresas.Pais.Substring(0, IIf(Len(pNovoEmpresas.Pais) > 30, 30, Len(pNovoEmpresas.Pais))))
        mCMD.Parameters.AddWithValue("@pCod_Postal", pNovoEmpresas.Cod_Postal.Substring(0, IIf(Len(pNovoEmpresas.Cod_Postal) > 8, 8, Len(pNovoEmpresas.Cod_Postal))))
        mCMD.Parameters.AddWithValue("@pLocalidade", pNovoEmpresas.Localidade.Substring(0, IIf(Len(pNovoEmpresas.Localidade) > 50, 50, Len(pNovoEmpresas.Localidade))))
        mCMD.Parameters.AddWithValue("@pEmail", pNovoEmpresas.Email.Substring(0, IIf(Len(pNovoEmpresas.Email) > 50, 50, Len(pNovoEmpresas.Email))))
        mCMD.Parameters.AddWithValue("@pNum_Telefone", pNovoEmpresas.Num_Telefone.Substring(0, IIf(Len(pNovoEmpresas.Num_Telefone) > 9, 9, Len(pNovoEmpresas.Num_Telefone))))
        mCMD.Parameters.AddWithValue("@pCapital_Social", pNovoEmpresas.Capital_Social.Substring(0, IIf(Len(pNovoEmpresas.Capital_Social) > 14, 14, Len(pNovoEmpresas.Capital_Social))))
        mCMD.Parameters.AddWithValue("@pRegisto_Comercial", pNovoEmpresas.Registo_Comercial.Substring(0, IIf(Len(pNovoEmpresas.Registo_Comercial) > 30, 30, Len(pNovoEmpresas.Registo_Comercial))))
        mCMD.Parameters.AddWithValue("@pMatricula_CRC", pNovoEmpresas.Matricula_CRC.Substring(0, IIf(Len(pNovoEmpresas.Matricula_CRC) > 20, 20, Len(pNovoEmpresas.Matricula_CRC))))
        mCMD.Parameters.AddWithValue("@pNIF", pNovoEmpresas.NIF.Substring(0, IIf(Len(pNovoEmpresas.NIF) > 9, 9, Len(pNovoEmpresas.NIF))))
        mCMD.Parameters.AddWithValue("@pContador_Categorias", pNovoEmpresas.Contador_Categorias)
        mCMD.Parameters.AddWithValue("@pContador_Clientes", pNovoEmpresas.Contador_Clientes)
        mCMD.Parameters.AddWithValue("@pContador_Funcionarios", pNovoEmpresas.Contador_Funcionarios)
        mCMD.Parameters.AddWithValue("@pContador_Veterinarios", pNovoEmpresas.Contador_Veterinarios)
        mCMD.Parameters.AddWithValue("@pContador_Consultas", pNovoEmpresas.Contador_Consultas)
        mCMD.Parameters.AddWithValue("@pContador_Tipos_Consulta", pNovoEmpresas.Contador_Tipos_Consulta)
        mCMD.Parameters.AddWithValue("@pContador_Animais", pNovoEmpresas.Contador_Animais)
        mCMD.Parameters.AddWithValue("@pContador_Artigos", pNovoEmpresas.Contador_Artigos)
        mCMD.Parameters.AddWithValue("@pContador_Tipos_Animais", pNovoEmpresas.Contador_Tipos_Animais)
        mCMD.Parameters.AddWithValue("@pContador_Tipos_Pagamento", pNovoEmpresas.Contador_Tipos_Pagamento)
        mCMD.Parameters.AddWithValue("@pContador_IVA", pNovoEmpresas.Contador_IVA)
        mCMD.Parameters.AddWithValue("@pContador_Servicos", pNovoEmpresas.Contador_Servicos)
        mCMD.Parameters.AddWithValue("@pContador_Produtos", pNovoEmpresas.Contador_Produtos)
        mCMD.Parameters.AddWithValue("@pContador_Racas", pNovoEmpresas.Contador_Racas)
        mCMD.Parameters.AddWithValue("@pContador_Salas", pNovoEmpresas.Contador_Salas)
        mCMD.Parameters.AddWithValue("@pAno_Trabalho", pNovoEmpresas.Ano_Trabalho.Substring(0, IIf(Len(pNovoEmpresas.Ano_Trabalho) > 4, 4, Len(pNovoEmpresas.Ano_Trabalho))))
        mCMD.Parameters.AddWithValue("@pFLG_Ativo", pNovoEmpresas.FLG_Ativo)


        mStrSQL = "INSERT INTO Empresas "
        mStrSQL += "("
        mStrSQL += "Cod_Empresa,"
        mStrSQL += "Nome,"
        mStrSQL += "Endereco,"
        mStrSQL += "Pais,"
        mStrSQL += "Cod_Postal,"
        mStrSQL += "Localidade,"
        mStrSQL += "Email,"
        mStrSQL += "Num_Telefone,"
        mStrSQL += "Capital_Social,"
        mStrSQL += "Registo_Comercial,"
        mStrSQL += "Matricula_CRC,"
        mStrSQL += "NIF,"
        mStrSQL += "Contador_Clientes,"
        mStrSQL += "Contador_Categorias,"
        mStrSQL += "Contador_Funcionarios,"
        mStrSQL += "Contador_Veterinarios,"
        mStrSQL += "Contador_Consultas,"
        mStrSQL += "Contador_Tipos_Consulta,"
        mStrSQL += "Contador_Animais,"
        mStrSQL += "Contador_Artigos,"
        mStrSQL += "Contador_Tipos_Animais,"
        mStrSQL += "Contador_Tipos_Pagamento,"
        mStrSQL += "Contador_IVA,"
        mStrSQL += "Contador_Servicos,"
        mStrSQL += "Contador_Produtos,"
        mStrSQL += "Contador_Racas,"
        mStrSQL += "Contador_Salas,"
        mStrSQL += "Ano_Trabalho,"
        mStrSQL += "FLG_Ativo "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        mStrSQL += "@pCod_Empresa,"
        mStrSQL += "@pNome,"
        mStrSQL += "@pEndereco,"
        mStrSQL += "@pPais,"
        mStrSQL += "@pCod_Postal,"
        mStrSQL += "@pLocalidade,"
        mStrSQL += "@pEmail,"
        mStrSQL += "@pNum_Telefone,"
        mStrSQL += "@pCapital_Social,"
        mStrSQL += "@pRegisto_Comercial,"
        mStrSQL += "@pMatricula_CRC,"
        mStrSQL += "@pNIF,"
        mStrSQL += "@pContador_Categorias,"
        mStrSQL += "@pContador_Clientes,"
        mStrSQL += "@pContador_Funcionarios,"
        mStrSQL += "@pContador_Veterinarios,"
        mStrSQL += "@pContador_Consultas,"
        mStrSQL += "@pContador_Tipos_Consulta,"
        mStrSQL += "@pContador_Animais,"
        mStrSQL += "@pContador_Artigos,"
        mStrSQL += "@pContador_Tipos_Animais,"
        mStrSQL += "@pContador_Tipos_Pagamento,"
        mStrSQL += "@pContador_IVA,"
        mStrSQL += "@pContador_Servicos,"
        mStrSQL += "@pContador_Produtos,"
        mStrSQL += "@pContador_Racas,"
        mStrSQL += "@pContador_Salas,"
        mStrSQL += "@pAno_Trabalho,"
        mStrSQL += "1"
        mStrSQL += ")"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
            'ClsEmpresas.GravaContador(enCont.Empresas)'<<<<-------- Verificar se é  preciso...
        Catch ex As Exception
            MsgBox("GravaEmpresas:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function ApagaEmpresas(ByVal pCod_Empresa As String) Método para Apagar um Registo da Tabela Empresas
    '''      Gerado em 03/03/2023 15:49:34
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function ApagaEmpresas(ByVal pCod_Empresa As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pCod_Empresa", pCod_Empresa)


        mStrSQL = "UPDATE Empresas SET "
        mStrSQL += "FLG_Ativo=0 "
        mStrSQL += "WHERE Cod_Empresa=@pCod_Empresa"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ApagaEmpresas:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function
End Class



''' <summary>
'''      Classe EmpresasComparer 
'''      Gerado em 03/03/2023 15:49:34
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2023
''' </remarks>
Public Class EmpresasComparer
    Implements IEqualityComparer(Of ClsEmpresas)

    Public Function Equals1(ByVal x As ClsEmpresas, ByVal y As ClsEmpresas) As Boolean Implements IEqualityComparer(Of ClsEmpresas).Equals

        If x Is y Then Return True

        If x Is Nothing OrElse y Is Nothing Then Return False

        Return (x.Cod_Empresa = y.Cod_Empresa) ' AndAlso (x.Nome = y.Nome)
    End Function

    Public Function GetHashCode1(ByVal pCls As ClsEmpresas) As Integer Implements IEqualityComparer(Of ClsEmpresas).GetHashCode

        If pCls Is Nothing Then Return 0

        'Dim Hash_ClsEmpresas_Nome = pCls.Nome.GetHashCode()
        Dim Hash_ClsEmpresas_Cod_Empresa = pCls.Cod_Empresa.GetHashCode()

        Return Hash_ClsEmpresas_Cod_Empresa 'Xor Hash_ClsEmpresas_Nome
    End Function
End Class
