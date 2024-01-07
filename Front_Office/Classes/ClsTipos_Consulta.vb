
Imports System.Data.SqlClient


''' <summary>
'''      Classe ClsTipos_Consulta Classe da Tabela Tipos_Consulta
'''      Gerado em 03/03/2023 15:49:35
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2023
''' </remarks>
Public Class ClsTipos_Consulta


    ' -----------------------------------------
    ' Property's da tabela Tipos_Consulta
    ' -----------------------------------------

    Public Property Cod_Tipo_Consulta As String                             ' Len:  5 - SQL_Type: nvarchar
    Public Property Designacao As String                                    ' Len: 30 - SQL_Type: nvarchar
    Public Property FLG_Ativo As Boolean                                    ' SQL_Type: bit


    Sub New()
    End Sub


    Friend Shared Function GetNovoCodigo() As String

        Return "TC" & ClsEmpresas.GetContador(enCont.Tipos_Consulta).ToString("000") ' <-------------- VERIFICAR O Nº de ZEROS

    End Function


    ''' <summary>
    '''      Function GetTipos_Consulta() Método para devolver a Lista de Tipos_Consulta
    '''      Gerado em 03/03/2023 15:49:35
    ''' </summary>
    ''' <returns>
    '''      mListaTipos_Consulta
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function GetTipos_Consulta() As List(Of ClsTipos_Consulta)
        Dim mListaTipos_Consulta As New List(Of ClsTipos_Consulta)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Tipo_Consulta,'') As Cod_Tipo_Consulta,"
        mStrSQL += "ISNULL(Designacao,'') As Designacao,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Tipos_Consulta "
        mStrSQL += "WHERE FLG_Ativo=1"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsTipos_Consulta As New ClsTipos_Consulta

            With mClsTipos_Consulta
                .Cod_Tipo_Consulta = mRDR.GetString(mRDR.GetOrdinal("Cod_Tipo_Consulta"))
                .Designacao = mRDR.GetString(mRDR.GetOrdinal("Designacao"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaTipos_Consulta.Add(mClsTipos_Consulta)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaTipos_Consulta
    End Function

    ''' <summary>
    '''      Function FiltrarTipos_Consulta Método para Filtrar os campos da lista de Tipos_Consulta
    '''      Gerado em 03/03/2023 15:49:35
    ''' </summary>
    ''' <returns>
    '''      mListaTipos_Consulta
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function FiltrarTipos_Consulta(ByVal pFiltro As ClsTipos_Consulta) As List(Of ClsTipos_Consulta)
        Dim mListaTipos_Consulta As New List(Of ClsTipos_Consulta)
        Dim mLista As New List(Of ClsTipos_Consulta)

        mListaTipos_Consulta = GetTipos_Consulta()

        mLista = mListaTipos_Consulta.FindAll(Function(x) _
        x.Cod_Tipo_Consulta.Contains(pFiltro.Cod_Tipo_Consulta)
        )
        '-----------------------------------------------------
        'Pode Colocar em cima mais colunas como esta abaixo...
        '-----------------------------------------------------
        ' AND x.Designacao.Contains(pFiltro.Designacao) 

        Return mLista
    End Function


    ''' <summary>
    '''      Function GetTipos_ConsultaByCod(ByVal pCod_Tipo_Consulta As String) Método para decolver uma Classe de Tipos_Consulta
    '''      Gerado em 03/03/2023 15:49:35
    ''' </summary>
    ''' <returns>
    '''      mClsTipos_Consulta
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function GetTipos_ConsultaByCod(ByVal pCod_Tipo_Consulta As String) As ClsTipos_Consulta
        Dim mClsTipos_Consulta As New ClsTipos_Consulta

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Tipo_Consulta", pCod_Tipo_Consulta)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Tipo_Consulta,'') As Cod_Tipo_Consulta,"
        mStrSQL += "ISNULL(Designacao,'') As Designacao,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Tipos_Consulta "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Cod_Tipo_Consulta=@pCod_Tipo_Consulta"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsTipos_Consulta
                .Cod_Tipo_Consulta = mRDR.GetString(mRDR.GetOrdinal("Cod_Tipo_Consulta"))
                .Designacao = mRDR.GetString(mRDR.GetOrdinal("Designacao"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mClsTipos_Consulta
    End Function


    ''' <summary>
    '''      Function ModificaTipos_Consulta(ByVal pClsTipos_Consulta As ClsTipos_Consulta) Método para Modificar a TABELA Tipos_Consulta
    '''      Gerado em 03/03/2023 15:49:35
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function ModificaTipos_Consulta(ByVal pClsTipos_Consulta As ClsTipos_Consulta) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Tipo_Consulta", pClsTipos_Consulta.Cod_Tipo_Consulta.Substring(0, IIf(Len(pClsTipos_Consulta.Cod_Tipo_Consulta) > 5, 5, Len(pClsTipos_Consulta.Cod_Tipo_Consulta))))
        mCMD.Parameters.AddWithValue("@pDesignacao", pClsTipos_Consulta.Designacao.Substring(0, IIf(Len(pClsTipos_Consulta.Designacao) > 30, 30, Len(pClsTipos_Consulta.Designacao))))


        mStrSQL = "UPDATE Tipos_Consulta SET "
        mStrSQL += "Designacao=@pDesignacao,"
        mStrSQL += "WHERE Cod_Tipo_Consulta=@pCod_Tipo_Consulta"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ModificaTipos_Consulta:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function GravaTipos_Consulta(ByVal pNovoTipos_Consulta As ClsTipos_Consulta) Método para Gravar a TABELA Tipos_Consulta
    '''      Gerado em 03/03/2023 15:49:35
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function GravaTipos_Consulta(ByVal pNovoTipos_Consulta As ClsTipos_Consulta) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()


        mCMD.Parameters.AddWithValue("@pCod_Tipo_Consulta", pNovoTipos_Consulta.Cod_Tipo_Consulta.Substring(0, IIf(Len(pNovoTipos_Consulta.Cod_Tipo_Consulta) > 5, 5, Len(pNovoTipos_Consulta.Cod_Tipo_Consulta))))
        mCMD.Parameters.AddWithValue("@pDesignacao", pNovoTipos_Consulta.Designacao.Substring(0, IIf(Len(pNovoTipos_Consulta.Designacao) > 30, 30, Len(pNovoTipos_Consulta.Designacao))))
        mCMD.Parameters.AddWithValue("@pFLG_Ativo", pNovoTipos_Consulta.FLG_Ativo)


        mStrSQL = "INSERT INTO Tipos_Consulta "
        mStrSQL += "("
        mStrSQL += "Cod_Tipo_Consulta,"
        mStrSQL += "Designacao,"
        mStrSQL += "FLG_Ativo "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        mStrSQL += "@pCod_Tipo_Consulta,"
        mStrSQL += "@pDesignacao,"
        mStrSQL += "1"
        mStrSQL += ")"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
            ClsEmpresas.GravaContador(enCont.Tipos_Consulta)
        Catch ex As Exception
            MsgBox("GravaTipos_Consulta:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function ApagaTipos_Consulta(ByVal pCod_Tipo_Consulta As String) Método para Apagar um Registo da Tabela Tipos_Consulta
    '''      Gerado em 03/03/2023 15:49:35
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function ApagaTipos_Consulta(ByVal pCod_Tipo_Consulta As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pCod_Tipo_Consulta", pCod_Tipo_Consulta)


        mStrSQL = "UPDATE Tipos_Consulta SET "
        mStrSQL += "FLG_Ativo=0 "
        mStrSQL += "WHERE Cod_Tipo_Consulta=@pCod_Tipo_Consulta"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ApagaTipos_Consulta:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function
End Class



''' <summary>
'''      Classe Tipos_ConsultaComparer 
'''      Gerado em 03/03/2023 15:49:35
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2023
''' </remarks>
Public Class Tipos_ConsultaComparer
    Implements IEqualityComparer(Of ClsTipos_Consulta)

    Public Function Equals1(ByVal x As ClsTipos_Consulta, ByVal y As ClsTipos_Consulta) As Boolean Implements IEqualityComparer(Of ClsTipos_Consulta).Equals

        If x Is y Then Return True

        If x Is Nothing OrElse y Is Nothing Then Return False

        Return (x.Cod_Tipo_Consulta = y.Cod_Tipo_Consulta) ' AndAlso (x.Designacao = y.Designacao)
    End Function

    Public Function GetHashCode1(ByVal pCls As ClsTipos_Consulta) As Integer Implements IEqualityComparer(Of ClsTipos_Consulta).GetHashCode

        If pCls Is Nothing Then Return 0

        'Dim Hash_ClsTipos_Consulta_Designacao = pCls.Designacao.GetHashCode()
        Dim Hash_ClsTipos_Consulta_Cod_Tipo_Consulta = pCls.Cod_Tipo_Consulta.GetHashCode()

        Return Hash_ClsTipos_Consulta_Cod_Tipo_Consulta 'Xor Hash_ClsTipos_Consulta_Designacao
    End Function
End Class
