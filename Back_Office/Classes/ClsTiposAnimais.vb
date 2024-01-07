
Imports System.Data.SqlClient
Imports DevExpress.Pdf.Native

''' <summary>
'''      Classe ClsTiposAnimais1 Classe da Tabela Tipos_Animais
'''      Gerado em 03/03/2023 15:49:35
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2023
''' </remarks>
Public Class ClsTiposAnimais


    ' -----------------------------------------
    ' Property's da tabela Tipos_Animais
    ' -----------------------------------------

    Public Property Cod_Tipo_Animal As String                               ' Len:  4 - SQL_Type: nvarchar
    Public Property Animal As String                                        ' Len: 30 - SQL_Type: nvarchar
    Public Property Imagem As String                                        ' Len: 15 - SQL_Type: nvarchar
    Public Property FLG_Ativo As Boolean                                    ' SQL_Type: bit


    Sub New()
    End Sub


    Friend Shared Function GetNovoCodigo() As String

        Return "TA" & ClsEmpresas.GetContador(enCont.Tipos_Animais).ToString("00") ' <-------------- VERIFICAR O Nº de ZEROS

    End Function


    ''' <summary>
    '''      Function GetTipos_Animais() Método para devolver a Lista de Tipos_Animais
    '''      Gerado em 03/03/2023 15:49:35
    ''' </summary>
    ''' <returns>
    '''      mListaTipos_Animais
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function GetTipos_Animais() As List(Of ClsTiposAnimais)
        Dim mListaTipos_Animais As New List(Of ClsTiposAnimais)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Tipo_Animal,'') As Cod_Tipo_Animal,"
        mStrSQL += "ISNULL(Animal,'') As Animal,"
        mStrSQL += "ISNULL(Imagem,'') As Imagem,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Tipos_Animais "
        mStrSQL += "WHERE FLG_Ativo=1"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsTipos_Animais As New ClsTiposAnimais

            With mClsTipos_Animais
                .Cod_Tipo_Animal = mRDR.GetString(mRDR.GetOrdinal("Cod_Tipo_Animal"))
                .Animal = mRDR.GetString(mRDR.GetOrdinal("Animal"))
                .Imagem = mRDR.GetString(mRDR.GetOrdinal("Imagem"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaTipos_Animais.Add(mClsTipos_Animais)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaTipos_Animais
    End Function

    ''' <summary>
    '''      Function FiltrarTipos_Animais Método para Filtrar os campos da lista de Tipos_Animais
    '''      Gerado em 03/03/2023 15:49:35
    ''' </summary>
    ''' <returns>
    '''      mListaTipos_Animais
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function FiltrarTipos_Animais(ByVal pFiltro As ClsTiposAnimais) As List(Of ClsTiposAnimais)
        Dim mListaTipos_Animais As New List(Of ClsTiposAnimais)
        Dim mLista As New List(Of ClsTiposAnimais)

        mListaTipos_Animais = GetTipos_Animais()

        mLista = mListaTipos_Animais.FindAll(Function(x) _
        x.Cod_Tipo_Animal.Contains(pFiltro.Cod_Tipo_Animal)
        )
        '-----------------------------------------------------
        'Pode Colocar em cima mais colunas como esta abaixo...
        '-----------------------------------------------------
        ' AND x.Animal.Contains(pFiltro.Animal) 

        Return mLista
    End Function


    ''' <summary>
    '''      Function GetTipos_AnimaisByCod(ByVal pCod_Tipo_Animal As String) Método para decolver uma Classe de Tipos_Animais
    '''      Gerado em 03/03/2023 15:49:35
    ''' </summary>
    ''' <returns>
    '''      mClsTipos_Animais
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function GetTipos_AnimaisByCod(ByVal pCod_Tipo_Animal As String) As ClsTiposAnimais
        Dim mClsTipos_Animais As New ClsTiposAnimais

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Tipo_Animal", pCod_Tipo_Animal)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Tipo_Animal,'') As Cod_Tipo_Animal,"
        mStrSQL += "ISNULL(Animal,'') As Animal,"
        mStrSQL += "ISNULL(Imagem,'') As Imagem,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Tipos_Animais "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Cod_Tipo_Animal=@pCod_Tipo_Animal"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsTipos_Animais
                .Cod_Tipo_Animal = mRDR.GetString(mRDR.GetOrdinal("Cod_Tipo_Animal"))
                .Animal = mRDR.GetString(mRDR.GetOrdinal("Animal"))
                .Imagem = mRDR.GetString(mRDR.GetOrdinal("Imagem"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mClsTipos_Animais
    End Function


    ''' <summary>
    '''      Function ModificaTipos_Animais(ByVal pClsTipos_Animais As ClsTiposAnimais1) Método para Modificar a TABELA Tipos_Animais
    '''      Gerado em 03/03/2023 15:49:35
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function ModificaTipos_Animais(ByVal pClsTipos_Animais As ClsTiposAnimais) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Tipo_Animal", pClsTipos_Animais.Cod_Tipo_Animal.Substring(0, IIf(Len(pClsTipos_Animais.Cod_Tipo_Animal) > 4, 4, Len(pClsTipos_Animais.Cod_Tipo_Animal))))
        mCMD.Parameters.AddWithValue("@pAnimal", pClsTipos_Animais.Animal.Substring(0, IIf(Len(pClsTipos_Animais.Animal) > 30, 30, Len(pClsTipos_Animais.Animal))))
        mCMD.Parameters.AddWithValue("@pImagem", pClsTipos_Animais.Imagem.Substring(0, IIf(Len(pClsTipos_Animais.Imagem) > 15, 15, Len(pClsTipos_Animais.Imagem))))


        mStrSQL = "UPDATE Tipos_Animais SET "
        mStrSQL += "Animal=@pAnimal,"
        mStrSQL += "Imagem=@pImagem "
        mStrSQL += "WHERE Cod_Tipo_Animal=@pCod_Tipo_Animal"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ModificaTipos_Animais:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function GravaTipos_Animais(ByVal pNovoTipos_Animais As ClsTiposAnimais1) Método para Gravar a TABELA Tipos_Animais
    '''      Gerado em 03/03/2023 15:49:35
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function GravaTipos_Animais(ByVal pNovoTipos_Animais As ClsTiposAnimais) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()


        mCMD.Parameters.AddWithValue("@pCod_Tipo_Animal", pNovoTipos_Animais.Cod_Tipo_Animal.Substring(0, IIf(Len(pNovoTipos_Animais.Cod_Tipo_Animal) > 4, 4, Len(pNovoTipos_Animais.Cod_Tipo_Animal))))
        mCMD.Parameters.AddWithValue("@pAnimal", pNovoTipos_Animais.Animal.Substring(0, IIf(Len(pNovoTipos_Animais.Animal) > 30, 30, Len(pNovoTipos_Animais.Animal))))
        mCMD.Parameters.AddWithValue("@pAnimal", pNovoTipos_Animais.Animal.Substring(0, IIf(Len(pNovoTipos_Animais.Animal) > 15, 15, Len(pNovoTipos_Animais.Animal))))
        mCMD.Parameters.AddWithValue("@pFLG_Ativo", pNovoTipos_Animais.FLG_Ativo)


        mStrSQL = "INSERT INTO Tipos_Animais "
        mStrSQL += "("
        mStrSQL += "Cod_Tipo_Animal,"
        mStrSQL += "Animal,"
        mStrSQL += "Imagem,"
        mStrSQL += "FLG_Ativo "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        mStrSQL += "@pCod_Tipo_Animal,"
        mStrSQL += "@pAnimal,"
        mStrSQL += "@pImagem,"
        mStrSQL += "1"
        mStrSQL += ")"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
            ClsEmpresas.GravaContador(enCont.Tipos_Animais)
        Catch ex As Exception
            MsgBox("GravaTipos_Animais:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function ApagaTipos_Animais(ByVal pCod_Tipo_Animal As String) Método para Apagar um Registo da Tabela Tipos_Animais
    '''      Gerado em 03/03/2023 15:49:35
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function ApagaTipos_Animais(ByVal pCod_Tipo_Animal As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pCod_Tipo_Animal", pCod_Tipo_Animal)


        mStrSQL = "UPDATE Tipos_Animais SET "
        mStrSQL += "FLG_Ativo=0 "
        mStrSQL += "WHERE Cod_Tipo_Animal=@pCod_Tipo_Animal"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ApagaTipos_Animais:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function
End Class



''' <summary>
'''      Classe Tipos_AnimaisComparer 
'''      Gerado em 03/03/2023 15:49:35
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2023
''' </remarks>
Public Class Tipos_AnimaisComparer1
    Implements IEqualityComparer(Of ClsTiposAnimais)

    Public Function Equals1(ByVal x As ClsTiposAnimais, ByVal y As ClsTiposAnimais) As Boolean Implements IEqualityComparer(Of ClsTiposAnimais).Equals

        If x Is y Then Return True

        If x Is Nothing OrElse y Is Nothing Then Return False

        Return (x.Cod_Tipo_Animal = y.Cod_Tipo_Animal) ' AndAlso (x.Animal = y.Animal)
    End Function

    Public Function GetHashCode1(ByVal pCls As ClsTiposAnimais) As Integer Implements IEqualityComparer(Of ClsTiposAnimais).GetHashCode

        If pCls Is Nothing Then Return 0

        'Dim Hash_ClsTipos_Animais_Animal = pCls.Animal.GetHashCode()
        Dim Hash_ClsTipos_Animais_Cod_Tipo_Animal = pCls.Cod_Tipo_Animal.GetHashCode()

        Return Hash_ClsTipos_Animais_Cod_Tipo_Animal 'Xor Hash_ClsTipos_Animais_Animal
    End Function
End Class
