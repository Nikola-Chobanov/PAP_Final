
Imports System.Data.SqlClient


''' <summary>
'''      Classe ClsAnimais Classe da Tabela Animais
'''      Gerado em 29/11/2022 14:12:53
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2022
''' </remarks>
Public Class ClsAnimais


    ' -----------------------------------------
    ' Property's da tabela Animais
    ' -----------------------------------------

    Public Property Cod_Animal As String                                    ' Len:  5 - SQL_Type: nvarchar
    Public Property Nome_Animal As String                                   ' Len: 30 - SQL_Type: nvarchar
    Public Property Cod_Entidade As String                                  ' Len:  5 - SQL_Type: nvarchar
    Public Property Cod_Tipo_Animal As String                               ' Len:  4 - SQL_Type: nvarchar
    Public Property Imagem_Animal As String                                 ' Len: 50 - SQL_Type: nvarchar
    Public Property FLG_Ativo As Boolean                                    ' SQL_Type: bit


    Sub New()
    End Sub


    Friend Shared Function GetNovoCodigo() As String

        Return "A" & ClsEmpresas.GetContador(enCont.Animais).ToString("0000") ' <-------------- VERIFICAR O Nº de ZEROS

    End Function


    ''' <summary>
    '''      Function GetAnimais() Método para devolver a Lista de Animais
    '''      Gerado em 29/11/2022 14:12:53
    ''' </summary>
    ''' <returns>
    '''      mListaAnimais
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function GetAnimais() As List(Of ClsAnimais)
        Dim mListaAnimais As New List(Of ClsAnimais)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Animal,'') As Cod_Animal,"
        mStrSQL += "ISNULL(Nome_Animal,'') As Nome_Animal,"
        mStrSQL += "ISNULL(Cod_Entidade,'') As Cod_Entidade,"
        mStrSQL += "ISNULL(Cod_Tipo_Animal,'') As Cod_Tipo_Animal,"
        mStrSQL += "ISNULL(Imagem_Animal,'') As Imagem_Animal,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Animais "
        mStrSQL += "WHERE FLG_Ativo=1"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsAnimais As New ClsAnimais

            With mClsAnimais
                .Cod_Animal = mRDR.GetString(mRDR.GetOrdinal("Cod_Animal"))
                .Nome_Animal = mRDR.GetString(mRDR.GetOrdinal("Nome_Animal"))
                .Cod_Entidade = mRDR.GetString(mRDR.GetOrdinal("Cod_Entidade"))
                .Cod_Tipo_Animal = mRDR.GetString(mRDR.GetOrdinal("Cod_Tipo_Animal"))
                .Imagem_Animal = mRDR.GetString(mRDR.GetOrdinal("Imagem_Animal"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaAnimais.Add(mClsAnimais)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaAnimais
    End Function

    Public Shared Function GetAnimaisByEntidade(ByVal pCodEntidade As String) As List(Of ClsAnimais)
        Dim mListaAnimais As New List(Of ClsAnimais)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCodEntidade", pCodEntidade)

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Animal,'') As Cod_Animal,"
        mStrSQL += "ISNULL(Nome_Animal,'') As Nome_Animal,"
        mStrSQL += "ISNULL(Cod_Entidade,'') As Cod_Entidade,"
        mStrSQL += "ISNULL(Cod_Tipo_Animal,'') As Cod_Tipo_Animal,"
        mStrSQL += "ISNULL(Imagem_Animal,'') As Imagem_Animal,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Animais "
        mStrSQL += "WHERE Cod_Entidade = @pCodEntidade"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsAnimais As New ClsAnimais

            With mClsAnimais
                .Cod_Animal = mRDR.GetString(mRDR.GetOrdinal("Cod_Animal"))
                .Nome_Animal = mRDR.GetString(mRDR.GetOrdinal("Nome_Animal"))
                .Cod_Entidade = mRDR.GetString(mRDR.GetOrdinal("Cod_Entidade"))
                .Cod_Tipo_Animal = mRDR.GetString(mRDR.GetOrdinal("Cod_Tipo_Animal"))
                .Imagem_Animal = mRDR.GetString(mRDR.GetOrdinal("Imagem_Animal"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaAnimais.Add(mClsAnimais)

        End While

        Dim mCount As Integer = mListaAnimais.Count

        For n As Integer = mCount To (20 + (mCount - 1))
            Dim mAnimal As New ClsAnimais()
            With mAnimal
                .Cod_Animal = "A" & (n + 1).ToString("00")
                .Nome_Animal = ""
                .FLG_Ativo = True
            End With
            mListaAnimais.Add(mAnimal)
        Next


        mRDR.Close()
        mDB.Close()

        Return mListaAnimais
    End Function






    ''' <summary>
    '''      Function FiltrarAnimais Método para Filtrar os campos da lista de Animais
    '''      Gerado em 29/11/2022 14:12:53
    ''' </summary>
    ''' <returns>
    '''      mListaAnimais
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function FiltrarAnimais(ByVal pFiltro As ClsAnimais) As List(Of ClsAnimais)
        Dim mListaAnimais As New List(Of ClsAnimais)
        Dim mLista As New List(Of ClsAnimais)

        mListaAnimais = GetAnimais()

        mLista = mListaAnimais.FindAll(Function(x) _
        x.Cod_Animal.Contains(pFiltro.Cod_Animal)
        )
        '-----------------------------------------------------
        'Pode Colocar em cima mais colunas como esta abaixo...
        '-----------------------------------------------------
        ' AND x.Nome_Animal.Contains(pFiltro.Nome_Animal) 

        Return mLista
    End Function


    ''' <summary>
    '''      Function GetAnimaisByCod(ByVal pCod_Animal As String) Método para decolver uma Classe de Animais
    '''      Gerado em 29/11/2022 14:12:53
    ''' </summary>
    ''' <returns>
    '''      mClsAnimais
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function GetAnimaisByCod(ByVal pCod_Animal As String) As ClsAnimais
        Dim mClsAnimais As New ClsAnimais

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Animal", pCod_Animal)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Animal,'') As Cod_Animal,"
        mStrSQL += "ISNULL(Nome_Animal,'') As Nome_Animal,"
        mStrSQL += "ISNULL(Cod_Entidade,'') As Cod_Entidade,"
        mStrSQL += "ISNULL(Cod_Tipo_Animal,'') As Cod_Tipo_Animal,"
        mStrSQL += "ISNULL(Imagem_Animal,'') As Imagem_Animal,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Animais "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Cod_Animal=@pCod_Animal"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsAnimais
                .Cod_Animal = mRDR.GetString(mRDR.GetOrdinal("Cod_Animal"))
                .Nome_Animal = mRDR.GetString(mRDR.GetOrdinal("Nome_Animal"))
                .Cod_Entidade = mRDR.GetString(mRDR.GetOrdinal("Cod_Entidade"))
                .Cod_Tipo_Animal = mRDR.GetString(mRDR.GetOrdinal("Cod_Tipo_Animal"))
                .Imagem_Animal = mRDR.GetString(mRDR.GetOrdinal("Imagem_Animal"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mClsAnimais
    End Function


    ''' <summary>
    '''      Function ModificaAnimais(ByVal pClsAnimais As ClsAnimais) Método para Modificar a TABELA Animais
    '''      Gerado em 29/11/2022 14:12:53
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function ModificaAnimais(ByVal pClsAnimais As ClsAnimais) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Animal", pClsAnimais.Cod_Animal.Substring(0, IIf(Len(pClsAnimais.Cod_Animal) > 5, 5, Len(pClsAnimais.Cod_Animal))))
        mCMD.Parameters.AddWithValue("@pNome_Animal", pClsAnimais.Nome_Animal.Substring(0, IIf(Len(pClsAnimais.Nome_Animal) > 30, 30, Len(pClsAnimais.Nome_Animal))))
        mCMD.Parameters.AddWithValue("@pCod_Entidade", pClsAnimais.Cod_Entidade.Substring(0, IIf(Len(pClsAnimais.Cod_Entidade) > 5, 5, Len(pClsAnimais.Cod_Entidade))))
        mCMD.Parameters.AddWithValue("@pCod_Tipo_Animal", pClsAnimais.Cod_Tipo_Animal.Substring(0, IIf(Len(pClsAnimais.Cod_Tipo_Animal) > 4, 4, Len(pClsAnimais.Cod_Tipo_Animal))))
        mCMD.Parameters.AddWithValue("@pImagem_Animal", pClsAnimais.Imagem_Animal.Substring(0, IIf(Len(pClsAnimais.Imagem_Animal) > 50, 50, Len(pClsAnimais.Imagem_Animal))))


        mStrSQL = "UPDATE Animais SET "
        mStrSQL += "Nome_Animal=@pNome_Animal,"
        mStrSQL += "Cod_Entidade=@pCod_Entidade,"
        mStrSQL += "Cod_Tipo_Animal=@pCod_Tipo_Animal,"
        mStrSQL += "Imagem_Animal=@pImagem_Animal "
        mStrSQL += "WHERE Cod_Animal=@pCod_Animal"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ModificaAnimais:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function GravaAnimais(ByVal pNovoAnimais As ClsAnimais) Método para Gravar a TABELA Animais
    '''      Gerado em 29/11/2022 14:12:53
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function GravaAnimais(ByVal pNovoAnimais As ClsAnimais) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()


        mCMD.Parameters.AddWithValue("@pCod_Animal", pNovoAnimais.Cod_Animal.Substring(0, IIf(Len(pNovoAnimais.Cod_Animal) > 5, 5, Len(pNovoAnimais.Cod_Animal))))
        mCMD.Parameters.AddWithValue("@pNome_Animal", pNovoAnimais.Nome_Animal.Substring(0, IIf(Len(pNovoAnimais.Nome_Animal) > 30, 30, Len(pNovoAnimais.Nome_Animal))))
        mCMD.Parameters.AddWithValue("@pCod_Entidade", pNovoAnimais.Cod_Entidade.Substring(0, IIf(Len(pNovoAnimais.Cod_Entidade) > 5, 5, Len(pNovoAnimais.Cod_Entidade))))
        mCMD.Parameters.AddWithValue("@pCod_Tipo_Animal", pNovoAnimais.Cod_Tipo_Animal.Substring(0, IIf(Len(pNovoAnimais.Cod_Tipo_Animal) > 4, 4, Len(pNovoAnimais.Cod_Tipo_Animal))))
        mCMD.Parameters.AddWithValue("@pImagem_Animal", pNovoAnimais.Imagem_Animal.Substring(0, IIf(Len(pNovoAnimais.Imagem_Animal) > 50, 50, Len(pNovoAnimais.Imagem_Animal))))
        mCMD.Parameters.AddWithValue("@pFLG_Ativo", pNovoAnimais.FLG_Ativo)


        mStrSQL = "INSERT INTO Animais "
        mStrSQL += "("
        mStrSQL += "Cod_Animal,"
        mStrSQL += "Nome_Animal,"
        mStrSQL += "Cod_Entidade,"
        mStrSQL += "Cod_Tipo_Animal,"
        mStrSQL += "Imagem_Animal,"
        mStrSQL += "FLG_Ativo "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        mStrSQL += "@pCod_Animal,"
        mStrSQL += "@pNome_Animal,"
        mStrSQL += "@pCod_Entidade,"
        mStrSQL += "@pCod_Tipo_Animal,"
        mStrSQL += "@pImagem_Animal,"
        mStrSQL += "1"
        mStrSQL += ")"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
            ClsEmpresas.GravaContador(enCont.Animais)
        Catch ex As Exception
            MsgBox("GravaAnimais:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function ApagaAnimais(ByVal pCod_Animal As String) Método para Apagar um Registo da Tabela Animais
    '''      Gerado em 29/11/2022 14:12:53
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function ApagaAnimais(ByVal pCod_Animal As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pCod_Animal", pCod_Animal)


        mStrSQL = "UPDATE Animais SET "
        mStrSQL += "FLG_Ativo=0 "
        mStrSQL += "WHERE Cod_Animal=@pCod_Animal"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ApagaAnimais:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function
End Class



''' <summary>
'''      Classe AnimaisComparer 
'''      Gerado em 29/11/2022 14:12:53
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2022
''' </remarks>
Public Class AnimaisComparer
    Implements IEqualityComparer(Of ClsAnimais)

    Public Function Equals1(ByVal x As ClsAnimais, ByVal y As ClsAnimais) As Boolean Implements IEqualityComparer(Of ClsAnimais).Equals

        If x Is y Then Return True

        If x Is Nothing OrElse y Is Nothing Then Return False

        Return (x.Cod_Animal = y.Cod_Animal) ' AndAlso (x.Nome_Animal = y.Nome_Animal)
    End Function

    Public Function GetHashCode1(ByVal pCls As ClsAnimais) As Integer Implements IEqualityComparer(Of ClsAnimais).GetHashCode

        If pCls Is Nothing Then Return 0

        'Dim Hash_ClsAnimais_Nome_Animal = pCls.Nome_Animal.GetHashCode()
        Dim Hash_ClsAnimais_Cod_Animal = pCls.Cod_Animal.GetHashCode()

        Return Hash_ClsAnimais_Cod_Animal 'Xor Hash_ClsAnimais_Nome_Animal
    End Function
End Class
