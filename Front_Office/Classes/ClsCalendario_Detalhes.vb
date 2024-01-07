
Imports System.Data.SqlClient
Imports DevExpress.Data.Utils.ServiceModel.Native
Imports DevExpress.Printing.ExportHelpers
Imports DevExpress.Xpo.Helpers

''' <summary>
'''      Classe ClsCalendario_Detalhes Classe da Tabela Calendario_Detalhes
'''      Gerado em 03/03/2023 15:49:33
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2023
''' </remarks>
Public Class ClsCalendario_Detalhes


    ' -----------------------------------------
    ' Property's da tabela Calendario_Detalhes
    ' -----------------------------------------

    Public Property Cod_Calendario As String                                ' Len:  5 - SQL_Type: nvarchar
    Public Property Dia As Date                                             ' SQL_Type: smalldatetime
    Public Property Descritivo_Feriado As String                            ' Len: 50 - SQL_Type: nvarchar

    Public Property FLG_Consultas As Boolean
    Public Property FLG_Feriado As Boolean                                  ' SQL_Type: bit

    Public ReadOnly Property Lista_Consultas As List(Of ClsConsultas)
        Get
            Return If(FLG_Consultas, ClsConsultas.GetConsultasByDia(Dia), Nothing)

        End Get
    End Property

    Public Property FLG_Ativo As Boolean                                    ' SQL_Type: bit


    Sub New()
    End Sub


    Sub New(pDia As Date, pDescritivo_Feriado As String, pFLG_Feriado As Boolean, pFLG_Consultas As Boolean)

        Dim mAno As String = Year(pDia).ToString

        Cod_Calendario = "CAL" & mAno.Substring(2, 2)

        Dia = ClsUtils.GetDataSH(pDia)

        Descritivo_Feriado = pDescritivo_Feriado

        FLG_Consultas = pFLG_Consultas

        FLG_Feriado = pFLG_Feriado

        FLG_Ativo = True
    End Sub

    Public Shared Function GetLista_Feriados_By_Ano(ByVal pAno As String) As List(Of ClsCalendario_Detalhes)
        Dim mListaCalendario_Detalhes As New List(Of ClsCalendario_Detalhes)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        Dim mAno As String = pAno.Substring(2, 2)


        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pAno", mAno)

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Calendario,'') As Cod_Calendario,"
        mStrSQL += "ISNULL(Dia,0) As Dia,"
        mStrSQL += "ISNULL(Descritivo_Feriado,'') As Descritivo_Feriado,"
        mStrSQL += "ISNULL(FLG_Feriado,1) As FLG_Feriado,"
        mStrSQL += "ISNULL(FLG_Consultas,1) As FLG_Consultas,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Calendario_Detalhes "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND FLG_Feriado=1 "
        mStrSQL += "AND RIGHT(Cod_Calendario,2)=@pAno"

        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsCalendario_Detalhes As New ClsCalendario_Detalhes

            With mClsCalendario_Detalhes
                .Cod_Calendario = mRDR.GetString(mRDR.GetOrdinal("Cod_Calendario"))
                .Dia = mRDR.GetDateTime(mRDR.GetOrdinal("Dia"))
                .Descritivo_Feriado = mRDR.GetString(mRDR.GetOrdinal("Descritivo_Feriado"))
                .FLG_Feriado = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Feriado"))
                .FLG_Consultas = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Consultas"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaCalendario_Detalhes.Add(mClsCalendario_Detalhes)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaCalendario_Detalhes
    End Function


    Friend Shared Function Grava_Consultas_CD_CS(ByVal pCS As ClsConsultas) As Boolean
        Dim mReturn As Boolean = True
        Dim mDia As Date = pCS.Dia
        If Not Testa_Existencia_Detalhes(mDia) Then
            Dim mCD As New ClsCalendario_Detalhes(mDia, "Dia Normal de Consulta", False, True)
            mReturn = ClsCalendario_Detalhes.GravaCalendario_Detalhes(mCD)
            If Not mReturn Then
                GoTo SAIR
            End If
        End If
        mReturn = ClsConsultas.GravaConsultas(pCS)

SAIR:
        Return mReturn
    End Function

    Friend Shared Function Testa_Existencia_Detalhes(pDia As Date) As Boolean
        Dim mReturn As Boolean = True

        Dim mDia As Date = ClsUtils.GetDataSH(pDia)
        Dim mCod_Calendario As String = "CAL" & (Year(pDia)).ToString.Substring(2, 2)

        Dim mCD As New ClsCalendario_Detalhes()
        mCD = ClsCalendario_Detalhes.GetCalendario_DetalhesByCod(mCod_Calendario, mDia)

        If mCD.Cod_Calendario Is Nothing Then
            mReturn = False
        End If
        If Not mCD.FLG_Consultas And mCD IsNot Nothing Then
            mCD.FLG_Consultas = True
            ClsCalendario_Detalhes.ModificaCalendario_Detalhes(mCD)
        End If



        Return mReturn
    End Function



    Friend Shared Function CalcularDiaCorpoDeus(ByVal pAno As Integer) As Date
        Dim mDia As Date = CalcularDiaPascoa(pAno)

        Return mDia.AddDays(60)

    End Function
    Friend Shared Function CalcularDiaCarnaval(ByVal pAno As Integer) As Date
        Dim mDia As Date = CalcularDiaPascoa(pAno)

        Return mDia.AddDays(-47)

    End Function

    Friend Shared Function CalcularSextaSanta(ByVal pAno As Integer) As Date
        Dim mDia As Date = CalcularDiaPascoa(pAno)

        Return mDia.AddDays(-2)

    End Function

    Friend Shared Function CalcularDiaPascoa(ByVal pAno As Integer) As Date
        'Calcula o dia da Páscoa para o ano fornecido.

        'Cálculo do dia da Páscoa baseado no algoritmo de Meeus/Jones/Butcher.

        Dim a As Integer = pAno Mod 19
        Dim b As Integer = pAno \ 100
        Dim c As Integer = pAno Mod 100
        Dim d As Integer = b \ 4
        Dim e As Integer = b Mod 4
        Dim f As Integer = (b + 8) \ 25
        Dim g As Integer = (b - f + 1) \ 3
        Dim h As Integer = (19 * a + b - d - g + 15) Mod 30
        Dim i As Integer = c \ 4
        Dim k As Integer = c Mod 4
        Dim L As Integer = (32 + 2 * e + 2 * i - h - k) Mod 7
        Dim m As Integer = (a + 11 * h + 22 * L) \ 451
        Dim Mes As Integer = (h + L - 7 * m + 114) \ 31
        Dim Dia As Integer = (h + L - 7 * m + 114) Mod 31 + 1

        Return New Date(pAno, Mes, Dia)

    End Function

    Friend Shared Function CalculaFeriados(ByVal pAno As String) As List(Of ClsCalendario_Feriados)
        Dim mLista As New List(Of ClsCalendario_Feriados)

        mLista = ClsCalendario_Feriados.GetCalendario_Feriados

        '-----------------------------
        ' Acrescenta feriados móveis
        '-----------------------------
        Dim mCF As New ClsCalendario_Feriados

        mCF = New ClsCalendario_Feriados(CalcularDiaPascoa(CInt(pAno)), "Dia de Páscoa")
        mLista.Add(mCF)

        mCF = New ClsCalendario_Feriados(CalcularDiaCarnaval(CInt(pAno)), "Dia de Carnaval")
        mLista.Add(mCF)

        mCF = New ClsCalendario_Feriados(CalcularDiaCorpoDeus(CInt(pAno)), "Dia de Corpo de Deus")
        mLista.Add(mCF)

        mCF = New ClsCalendario_Feriados(CalcularSextaSanta(CInt(pAno)), "Sexta Feira Santa")
        mLista.Add(mCF)


        mLista = mLista.OrderBy(Function(x) (x.Mes & x.Dia)).ToList

        Return mLista
    End Function

    '--------------------------------------------
    ' Exemplo de criador de Código por contador
    ' Para ser usado no caso de o Cdigo ser gerado
    ' e o contador existir na tabela Empresas
    '---------------------------------------------

    'Friend Shared Function GetNovoCodigo() As String

    'Return "C" & ClsEmpresas.GetContador(enCont.Calendario_Detalhes).ToString("000")' <-------------- VERIFICAR O Nº de ZEROS

    'End Function

    Friend Shared Function Cria_Detalhes_Feriados(ByVal pAno As String) As List(Of ClsCalendario_Detalhes)
        Dim mLista As New List(Of ClsCalendario_Detalhes)

        Dim mCod_Calendario As String = "CAL" & pAno.Substring(2, 2)

        Dim mLF As New List(Of ClsCalendario_Feriados)

        mLF = CalculaFeriados(pAno)

        For Each pLF As ClsCalendario_Feriados In mLF

            Dim mCD As New ClsCalendario_Detalhes(New DateTime(CInt(pAno), CInt(pLF.Mes), CInt(pLF.Dia)), pLF.Descritivo, True, False)

            'mCD.Dia = New DateTime(CInt(pAno), CInt(pLF.Mes), CInt(pLF.Dia))

            'If Not ClsCalendario_Detalhes.GravaCalendario_Detalhes(mCD) Then
            '    MsgBox("Não consegui gravar o detalhe " & mCD.Descritivo_Feriado)
            'End If

            mLista.Add(mCD)
        Next

        Return mLista
    End Function



    Friend Shared Function GetLista_Calendario_DetalhesByCod(ByVal pCod_Calendario As String) As List(Of ClsCalendario_Detalhes)
        Dim mListaCalendario_Detalhes As New List(Of ClsCalendario_Detalhes)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Calendario", pCod_Calendario)

        mStrSQL = "Select "
        mStrSQL += "ISNULL(Cod_Calendario,'') As Cod_Calendario,"
        mStrSQL += "ISNULL(Dia,0) As Dia,"
        mStrSQL += "ISNULL(Descritivo_Feriado,'') As Descritivo_Feriado,"
        mStrSQL += "ISNULL(FLG_Feriado,1) As FLG_Feriado,"
        mStrSQL += "ISNULL(FLG_Consultas,1) As FLG_Consultas,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Calendario_Detalhes "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Cod_Calendario=@pCod_Calendario"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsCalendario_Detalhes As New ClsCalendario_Detalhes

            With mClsCalendario_Detalhes
                .Cod_Calendario = mRDR.GetString(mRDR.GetOrdinal("Cod_Calendario"))
                .Dia = mRDR.GetDateTime(mRDR.GetOrdinal("Dia"))
                .Descritivo_Feriado = mRDR.GetString(mRDR.GetOrdinal("Descritivo_Feriado"))
                .FLG_Feriado = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Feriado"))
                .FLG_Consultas = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Consultas"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaCalendario_Detalhes.Add(mClsCalendario_Detalhes)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaCalendario_Detalhes
    End Function



    ''' <summary>
    '''      Function GetCalendario_Detalhes() Método para devolver a Lista de Calendario_Detalhes
    '''      Gerado em 03/03/2023 15:49:33
    ''' </summary>
    ''' <returns>
    '''      mListaCalendario_Detalhes
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function GetCalendario_Detalhes() As List(Of ClsCalendario_Detalhes)
        Dim mListaCalendario_Detalhes As New List(Of ClsCalendario_Detalhes)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Calendario,'') As Cod_Calendario,"
        mStrSQL += "ISNULL(Dia,0) As Dia,"
        mStrSQL += "ISNULL(Descritivo_Feriado,'') As Descritivo_Feriado,"
        mStrSQL += "ISNULL(FLG_Feriado,1) As FLG_Feriado,"
        mStrSQL += "ISNULL(FLG_Consultas,1) As FLG_Consultas,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Calendario_Detalhes "
        mStrSQL += "WHERE FLG_Ativo=1"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsCalendario_Detalhes As New ClsCalendario_Detalhes

            With mClsCalendario_Detalhes
                .Cod_Calendario = mRDR.GetString(mRDR.GetOrdinal("Cod_Calendario"))
                .Dia = mRDR.GetDateTime(mRDR.GetOrdinal("Dia"))
                .Descritivo_Feriado = mRDR.GetString(mRDR.GetOrdinal("Descritivo_Feriado"))
                .FLG_Feriado = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Feriado"))
                .FLG_Consultas = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Consultas"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaCalendario_Detalhes.Add(mClsCalendario_Detalhes)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaCalendario_Detalhes
    End Function

    ''' <summary>
    '''      Function FiltrarCalendario_Detalhes Método para Filtrar os campos da lista de Calendario_Detalhes
    '''      Gerado em 03/03/2023 15:49:33
    ''' </summary>
    ''' <returns>
    '''      mListaCalendario_Detalhes
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function FiltrarCalendario_Detalhes(ByVal pFiltro As ClsCalendario_Detalhes) As List(Of ClsCalendario_Detalhes)
        Dim mListaCalendario_Detalhes As New List(Of ClsCalendario_Detalhes)
        Dim mLista As New List(Of ClsCalendario_Detalhes)

        mListaCalendario_Detalhes = GetCalendario_Detalhes()

        mLista = mListaCalendario_Detalhes.FindAll(Function(x) x.Cod_Calendario.Contains(pFiltro.Cod_Calendario))
        '-----------------------------------------------------
        'Pode Colocar em cima mais colunas como esta abaixo...
        '-----------------------------------------------------
        ' AND x.Dia.Contains(pFiltro.Dia) 

        Return mLista
    End Function


    ''' <summary>
    '''      Function GetCalendario_DetalhesByCod(ByVal pCod_Calendario As String) Método para decolver uma Classe de Calendario_Detalhes
    '''      Gerado em 03/03/2023 15:49:33
    ''' </summary>
    ''' <returns>
    '''      mClsCalendario_Detalhes
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function GetCalendario_DetalhesByCod(ByVal pCod_Calendario As String, ByVal pDia As DateTime) As ClsCalendario_Detalhes
        Dim mClsCalendario_Detalhes As New ClsCalendario_Detalhes

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Calendario", pCod_Calendario)
        mCMD.Parameters.AddWithValue("@pDia", pDia)

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Calendario,'') As Cod_Calendario,"
        mStrSQL += "ISNULL(Dia,0) As Dia,"
        mStrSQL += "ISNULL(Descritivo_Feriado,'') As Descritivo_Feriado,"
        mStrSQL += "ISNULL(FLG_Feriado,1) As FLG_Feriado,"
        mStrSQL += "ISNULL(FLG_Consultas,1) As FLG_Consultas,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Calendario_Detalhes "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Cod_Calendario=@pCod_Calendario AND Dia=@pDia"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsCalendario_Detalhes
                .Cod_Calendario = mRDR.GetString(mRDR.GetOrdinal("Cod_Calendario"))
                .Dia = mRDR.GetDateTime(mRDR.GetOrdinal("Dia"))
                .Descritivo_Feriado = mRDR.GetString(mRDR.GetOrdinal("Descritivo_Feriado"))
                .FLG_Feriado = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Feriado"))
                .FLG_Consultas = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Consultas"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mClsCalendario_Detalhes
    End Function


    ''' <summary>
    '''      Function ModificaCalendario_Detalhes(ByVal pClsCalendario_Detalhes As ClsCalendario_Detalhes) Método para Modificar a TABELA Calendario_Detalhes
    '''      Gerado em 03/03/2023 15:49:33
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function ModificaCalendario_Detalhes(ByVal pClsCalendario_Detalhes As ClsCalendario_Detalhes) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Calendario", pClsCalendario_Detalhes.Cod_Calendario.Substring(0, IIf(Len(pClsCalendario_Detalhes.Cod_Calendario) > 5, 5, Len(pClsCalendario_Detalhes.Cod_Calendario))))
        mCMD.Parameters.AddWithValue("@pDia", pClsCalendario_Detalhes.Dia)
        mCMD.Parameters.AddWithValue("@pDescritivo_Feriado", pClsCalendario_Detalhes.Descritivo_Feriado.Substring(0, IIf(Len(pClsCalendario_Detalhes.Descritivo_Feriado) > 50, 50, Len(pClsCalendario_Detalhes.Descritivo_Feriado))))
        mCMD.Parameters.AddWithValue("@pFLG_Feriado", pClsCalendario_Detalhes.FLG_Feriado)
        mCMD.Parameters.AddWithValue("@pFLG_Consultas", pClsCalendario_Detalhes.FLG_Consultas)


        mStrSQL = "UPDATE Calendario_Detalhes SET "
        mStrSQL += "Dia=@pDia,"
        mStrSQL += "Descritivo_Feriado=@pDescritivo_Feriado,"
        mStrSQL += "FLG_Feriado=@pFLG_Feriado,"
        mStrSQL += "FLG_Consultas=@pFLG_Consultas "
        mStrSQL += "WHERE Cod_Calendario=@pCod_Calendario AND Dia=@pDia"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ModificaCalendario_Detalhes:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function GravaCalendario_Detalhes(ByVal pNovoCalendario_Detalhes As ClsCalendario_Detalhes) Método para Gravar a TABELA Calendario_Detalhes
    '''      Gerado em 03/03/2023 15:49:33
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function GravaCalendario_Detalhes(ByVal pNovoCalendario_Detalhes As ClsCalendario_Detalhes) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()


        mCMD.Parameters.AddWithValue("@pCod_Calendario", pNovoCalendario_Detalhes.Cod_Calendario.Substring(0, IIf(Len(pNovoCalendario_Detalhes.Cod_Calendario) > 5, 5, Len(pNovoCalendario_Detalhes.Cod_Calendario))))
        mCMD.Parameters.AddWithValue("@pDia", pNovoCalendario_Detalhes.Dia)
        mCMD.Parameters.AddWithValue("@pDescritivo_Feriado", pNovoCalendario_Detalhes.Descritivo_Feriado.Substring(0, IIf(Len(pNovoCalendario_Detalhes.Descritivo_Feriado) > 50, 50, Len(pNovoCalendario_Detalhes.Descritivo_Feriado))))
        mCMD.Parameters.AddWithValue("@pFLG_Feriado", pNovoCalendario_Detalhes.FLG_Feriado)
        mCMD.Parameters.AddWithValue("@pFLG_Consultas", pNovoCalendario_Detalhes.FLG_Consultas)
        mCMD.Parameters.AddWithValue("@pFLG_Ativo", pNovoCalendario_Detalhes.FLG_Ativo)


        mStrSQL = "INSERT INTO Calendario_Detalhes "
        mStrSQL += "("
        mStrSQL += "Cod_Calendario,"
        mStrSQL += "Dia,"
        mStrSQL += "Descritivo_Feriado,"
        mStrSQL += "FLG_Feriado,"
        mStrSQL += "FLG_Consultas,"
        mStrSQL += "FLG_Ativo "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        mStrSQL += "@pCod_Calendario,"
        mStrSQL += "@pDia,"
        mStrSQL += "@pDescritivo_Feriado,"
        mStrSQL += "@pFLG_Feriado,"
        mStrSQL += "@pFLG_Consultas,"
        mStrSQL += "1"
        mStrSQL += ")"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
            'ClsEmpresas.GravaContador(enCont.Calendario_Detalhes)'<<<<-------- Verificar se é  preciso...
        Catch ex As Exception
            MsgBox("GravaCalendario_Detalhes:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function ApagaCalendario_Detalhes(ByVal pCod_Calendario As String) Método para Apagar um Registo da Tabela Calendario_Detalhes
    '''      Gerado em 03/03/2023 15:49:33
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function ApagaCalendario_Detalhes(ByVal pCod_Calendario As String, ByVal pDia As DateTime) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pCod_Calendario", pCod_Calendario)
        mCMD.Parameters.AddWithValue("@pDia", pDia)

        mStrSQL = "UPDATE Calendario_Detalhes SET "
        mStrSQL += "FLG_Ativo=0 "
        mStrSQL += "WHERE Cod_Calendario=@pCod_Calendario AND Dia=@pDia"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ApagaCalendario_Detalhes:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function

End Class



''' <summary>
'''      Classe Calendario_DetalhesComparer 
'''      Gerado em 03/03/2023 15:49:33
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2023
''' </remarks>
Public Class Calendario_DetalhesComparer
    Implements IEqualityComparer(Of ClsCalendario_Detalhes)

    Public Function Equals1(ByVal x As ClsCalendario_Detalhes, ByVal y As ClsCalendario_Detalhes) As Boolean Implements IEqualityComparer(Of ClsCalendario_Detalhes).Equals

        If x Is y Then Return True

        If x Is Nothing OrElse y Is Nothing Then Return False

        Return (x.Cod_Calendario = y.Cod_Calendario) ' AndAlso (x.Dia = y.Dia)
    End Function

    Public Function GetHashCode1(ByVal pCls As ClsCalendario_Detalhes) As Integer Implements IEqualityComparer(Of ClsCalendario_Detalhes).GetHashCode

        If pCls Is Nothing Then Return 0

        'Dim Hash_ClsCalendario_Detalhes_Dia = pCls.Dia.GetHashCode()
        Dim Hash_ClsCalendario_Detalhes_Cod_Calendario = pCls.Cod_Calendario.GetHashCode()

        Return Hash_ClsCalendario_Detalhes_Cod_Calendario 'Xor Hash_ClsCalendario_Detalhes_Dia
    End Function
End Class
