Imports System.Data.SqlClient
Imports DevExpress.Utils.Mdi

''' <summary>
'''      Classe ClsEntidades Classe da Tabela Entidades
'''      Gerado em 29/11/2022 14:12:54
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2022
''' </remarks>
Public Class ClsVeterinarios

#Region "Properties"
    ' -----------------------------------------
    ' Property's da tabela Entidades
    ' -----------------------------------------

    Public Property Cod_Veterinario As String                                  ' Len:  5 - SQL_Type: nvarchar
    Public Property Nome As String                                          ' Len: 80 - SQL_Type: nvarchar
    Public Property Num_Telefone As String                                  ' Len: 15 - SQL_Type: nvarchar
    Public Property Num_Telemovel As String                                 ' Len: 15 - SQL_Type: nvarchar
    Public Property Email As String                                         ' Len: 80 - SQL_Type: nvarchar
    Public Property Utilizador As String
    Public Property Password As String                                      ' Len: 20 - SQL_Type: nvarchar
    Public Property Fotografia As String                                    ' Len: 50 - SQL_Type: nvarchar
    Public Property FLG_Ativo As Boolean                                ' SQL_Type: bit


    ' -----------------------------------------
    ' Property's da tabela Entidades
    ' -----------------------------------------
#End Region

    Sub New()
    End Sub


    '--------------------------------------------
    ' Exemplo de criador de Código por contador
    ' Para ser usado no caso de o Cdigo ser gerado
    ' e o contador existir na tabela Empresas
    '---------------------------------------------


    ''' <summary>
    '''      Function GetVeterinarios() Método para devolver a Lista de Veterinarios
    '''      Gerado em 29/11/2022 14:12:54
    ''' </summary>
    ''' <returns>
    '''      mListaVeterinarios
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function GetVeterinarios() As List(Of ClsVeterinarios)
        Dim mListaVeterinarios As New List(Of ClsVeterinarios)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Veterinario,'') As Cod_Veterinario,"
        mStrSQL += "ISNULL(Nome,'') As Nome,"
        mStrSQL += "ISNULL(Num_Telefone,'') As Num_Telefone,"
        mStrSQL += "ISNULL(Num_Telemovel,'') As Num_Telemovel,"
        mStrSQL += "ISNULL(Email,'') As Email,"
        mStrSQL += "ISNULL(Utilizador,'') As Utilizador,"
        mStrSQL += "ISNULL(Password,'') As Password,"
        mStrSQL += "ISNULL(Fotografia,'') As Fotografia,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Veterinarios "
        mStrSQL += "WHERE FLG_Ativo=1"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsVeterinarios As New ClsVeterinarios

            With mClsVeterinarios
                .Cod_Veterinario = mRDR.GetString(mRDR.GetOrdinal("Cod_Veterinario"))
                .Nome = mRDR.GetString(mRDR.GetOrdinal("Nome"))
                .Num_Telefone = mRDR.GetString(mRDR.GetOrdinal("Num_Telefone"))
                .Num_Telemovel = mRDR.GetString(mRDR.GetOrdinal("Num_Telemovel"))
                .Email = mRDR.GetString(mRDR.GetOrdinal("Email"))
                .Utilizador = mRDR.GetString(mRDR.GetOrdinal("Utilizador"))
                .Password = mRDR.GetString(mRDR.GetOrdinal("Password"))
                .Fotografia = mRDR.GetString(mRDR.GetOrdinal("Fotografia"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))

            End With


            mListaVeterinarios.Add(mClsVeterinarios)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaVeterinarios
    End Function

    Public Shared Function GetCountVeterinarios()
        Dim mCountVeterinarios As Integer = 0

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()

        mStrSQL = "SELECT COUNT "
        mStrSQL += "(Cod_Veterinario) As Cod_Veterinario "
        mStrSQL += "FROM Veterinarios "
        mStrSQL += "WHERE FLG_Ativo=1 "


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB


        mCountVeterinarios = Convert.ToInt32(mCMD.ExecuteScalar())

        mDB.Close()

        Return mCountVeterinarios
    End Function

    ''' <summary>
    '''      Function GetVeterinariosByCod(ByVal pCod_Veterinario As String) Método para decolver uma Classe de Veterinarios
    '''      Gerado em 29/11/2022 14:12:54
    ''' </summary>
    ''' <returns>
    '''      mClsVeterinarios
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function GetVeterinariosByCod(ByVal pCod_Veterinario As String) As ClsVeterinarios
        Dim mClsVeterinarios As New ClsVeterinarios

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Veterinario", pCod_Veterinario)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Veterinario,'') As Cod_Veterinario,"
        mStrSQL += "ISNULL(Nome,'') As Nome,"
        mStrSQL += "ISNULL(Num_Telefone,'') As Num_Telefone,"
        mStrSQL += "ISNULL(Num_Telemovel,'') As Num_Telemovel,"
        mStrSQL += "ISNULL(Email,'') As Email,"
        mStrSQL += "ISNULL(Utilizador,'') As Utilizador,"
        mStrSQL += "ISNULL(Password,'') As Password,"
        mStrSQL += "ISNULL(Fotografia,'') As Fotografia,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Veterinarios "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Cod_Veterinario=@pCod_Veterinario"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()


            With mClsVeterinarios
                .Cod_Veterinario = mRDR.GetString(mRDR.GetOrdinal("Cod_Veterinario"))
                .Nome = mRDR.GetString(mRDR.GetOrdinal("Nome"))
                .Num_Telefone = mRDR.GetString(mRDR.GetOrdinal("Num_Telefone"))
                .Num_Telemovel = mRDR.GetString(mRDR.GetOrdinal("Num_Telemovel"))
                .Email = mRDR.GetString(mRDR.GetOrdinal("Email"))
                .Utilizador = mRDR.GetString(mRDR.GetOrdinal("Utilizador"))
                .Password = mRDR.GetString(mRDR.GetOrdinal("Password"))
                .Fotografia = mRDR.GetString(mRDR.GetOrdinal("Fotografia"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With

        End While

        mRDR.Close()
        mDB.Close()

        Return mClsVeterinarios
    End Function


    ' Public Shared Function GetVeterinariosByFLG(Optional ByVal pFLG_Entidade As String = "C") As List(Of ClsVeterinarios)
    '     Dim mListaVeterinarios As New List(Of ClsVeterinarios)
    '
    '
    '
    '     Dim mStrSQL As String
    '     Dim mDB As New SqlConnection
    '     Dim mCMD As New SqlCommand
    '     Dim mRDR As SqlDataReader
    '
    '     mDB.ConnectionString = My.Settings.Connection
    '     mCMD.Parameters.Clear()
    '     mCMD.Parameters.AddWithValue("@pFLG_Entidade", pFLG_Entidade)
    '
    '
    '     mStrSQL = "SELECT "
    '     mStrSQL += "ISNULL(Cod_Veterinario,'') As Cod_Veterinario,"
    '     mStrSQL += "ISNULL(FLG_Entidade,'') As FLG_Entidade,"
    '     mStrSQL += "ISNULL(Nome,'') As Nome,"
    '     mStrSQL += "ISNULL(Cod_Pais,'') As Cod_Pais,"
    '     mStrSQL += "ISNULL(Num_Telefone,'') As Num_Telefone,"
    '     mStrSQL += "ISNULL(Num_Telemovel,'') As Num_Telemovel,"
    '     mStrSQL += "ISNULL(Email,'') As Email,"
    '     mStrSQL += "ISNULL(NIF,'') As NIF,"
    '     mStrSQL += "ISNULL(Data_Registo,0) As Data_Registo,"
    '
    '     mStrSQL += "ISNULL(Utilizador,'') As Utilizador,"
    '     mStrSQL += "ISNULL(Password,'') As Password,"
    '     mStrSQL += "ISNULL(Fotografia,'') As Fotografia,"
    '     mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
    '     mStrSQL += "FROM Veterinarios "
    '     mStrSQL += "WHERE FLG_Ativo=1 "
    '     mStrSQL += "AND FLG_Entidade= @pFLG_Entidade"
    '
    '
    '     mCMD.CommandText = mStrSQL
    '     mDB.Open()
    '     mCMD.Connection = mDB
    '
    '     mRDR = mCMD.ExecuteReader
    '
    '     While mRDR.Read()
    '
    '         Dim mClsVeterinarios As New ClsVeterinarios
    '
    '         With mClsVeterinarios
    '             .Cod_Veterinario = mRDR.GetString(mRDR.GetOrdinal("Cod_Veterinario"))
    '             .FLG_Entidade = mRDR.GetString(mRDR.GetOrdinal("FLG_Entidade"))
    '             .Nome = mRDR.GetString(mRDR.GetOrdinal("Nome"))
    '             .Cod_Pais = mRDR.GetString(mRDR.GetOrdinal("Cod_Pais"))
    '             .Num_Telefone = mRDR.GetString(mRDR.GetOrdinal("Num_Telefone"))
    '             .Num_Telemovel = mRDR.GetString(mRDR.GetOrdinal("Num_Telemovel"))
    '             .Email = mRDR.GetString(mRDR.GetOrdinal("Email"))
    '             .NIF = mRDR.GetString(mRDR.GetOrdinal("NIF"))
    '             .Data_Registo = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Registo"))
    '
    '             .Utilizador = mRDR.GetString(mRDR.GetOrdinal("Utilizador"))
    '             .Password = mRDR.GetString(mRDR.GetOrdinal("Password"))
    '             .Fotografia = mRDR.GetString(mRDR.GetOrdinal("Fotografia"))
    '             .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
    '         End With
    '
    '         mListaVeterinarios.Add(mClsVeterinarios)
    '
    '     End While
    '
    '     mRDR.Close()
    '     mDB.Close()
    '
    '     Return mListaVeterinarios
    ' End Function


    ''' <summary>
    '''      Function ModificaVeterinarios(ByVal pClsVeterinarios As ClsVeterinarios) Método para Modificar a TABELA Veterinarios
    '''      Gerado em 29/11/2022 14:12:54
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function ModificaVeterinarios(ByVal pClsVeterinarios As ClsVeterinarios) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Veterinario", pClsVeterinarios.Cod_Veterinario.Substring(0, IIf(Len(pClsVeterinarios.Cod_Veterinario) > 5, 5, Len(pClsVeterinarios.Cod_Veterinario))))
        mCMD.Parameters.AddWithValue("@pNome", pClsVeterinarios.Nome.Substring(0, IIf(Len(pClsVeterinarios.Nome) > 80, 80, Len(pClsVeterinarios.Nome))))
        mCMD.Parameters.AddWithValue("@pNum_Telefone", pClsVeterinarios.Num_Telefone.Substring(0, IIf(Len(pClsVeterinarios.Num_Telefone) > 15, 15, Len(pClsVeterinarios.Num_Telefone))))
        mCMD.Parameters.AddWithValue("@pNum_Telemovel", pClsVeterinarios.Num_Telemovel.Substring(0, IIf(Len(pClsVeterinarios.Num_Telemovel) > 15, 15, Len(pClsVeterinarios.Num_Telemovel))))
        mCMD.Parameters.AddWithValue("@pEmail", pClsVeterinarios.Email.Substring(0, IIf(Len(pClsVeterinarios.Email) > 80, 80, Len(pClsVeterinarios.Email))))
        mCMD.Parameters.AddWithValue("@pUtilizador", pClsVeterinarios.Utilizador.Substring(0, IIf(Len(pClsVeterinarios.Utilizador) > 20, 20, Len(pClsVeterinarios.Utilizador))))
        mCMD.Parameters.AddWithValue("@pPassword", pClsVeterinarios.Password.Substring(0, IIf(Len(pClsVeterinarios.Password) > 20, 20, Len(pClsVeterinarios.Password))))
        mCMD.Parameters.AddWithValue("@pFotografia", pClsVeterinarios.Fotografia.Substring(0, IIf(Len(pClsVeterinarios.Fotografia) > 50, 50, Len(pClsVeterinarios.Fotografia))))



        mStrSQL = "UPDATE Veterinarios SET "
        mStrSQL += "Nome=@pNome,"
        mStrSQL += "Num_Telefone=@pNum_Telefone,"
        mStrSQL += "Num_Telemovel=@pNum_Telemovel,"
        mStrSQL += "Email=@pEmail,"
        mStrSQL += "Utilizador=@pUtilizador, "
        mStrSQL += "Password=@pPassword,"
        mStrSQL += "Fotografia=@pFotografia "
        mStrSQL += "WHERE Cod_Veterinario=@pCod_Veterinario"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ModificaVeterinarios:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function GravaVeterinarios(ByVal pNovoVeterinarios As ClsVeterinarios) Método para Gravar a TABELA Veterinarios
    '''      Gerado em 29/11/2022 14:12:54
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function GravaVeterinarios(ByVal pNovoVeterinarios As ClsVeterinarios) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        Dim menCont As enCont
        Select Case pNovoVeterinarios.Cod_Veterinario.Substring(0, 1)
            Case "V"
        End Select


        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()


        mCMD.Parameters.AddWithValue("@pCod_Veterinario", pNovoVeterinarios.Cod_Veterinario.Substring(0, IIf(Len(pNovoVeterinarios.Cod_Veterinario) > 5, 5, Len(pNovoVeterinarios.Cod_Veterinario))))
        mCMD.Parameters.AddWithValue("@pNome", pNovoVeterinarios.Nome.Substring(0, IIf(Len(pNovoVeterinarios.Nome) > 80, 80, Len(pNovoVeterinarios.Nome))))
        mCMD.Parameters.AddWithValue("@pNum_Telefone", pNovoVeterinarios.Num_Telefone.Substring(0, IIf(Len(pNovoVeterinarios.Num_Telefone) > 15, 15, Len(pNovoVeterinarios.Num_Telefone))))
        mCMD.Parameters.AddWithValue("@pNum_Telemovel", pNovoVeterinarios.Num_Telemovel.Substring(0, IIf(Len(pNovoVeterinarios.Num_Telemovel) > 15, 15, Len(pNovoVeterinarios.Num_Telemovel))))
        mCMD.Parameters.AddWithValue("@pEmail", pNovoVeterinarios.Email.Substring(0, IIf(Len(pNovoVeterinarios.Email) > 80, 80, Len(pNovoVeterinarios.Email))))
        mCMD.Parameters.AddWithValue("@pUtilizador", pNovoVeterinarios.Utilizador.Substring(0, IIf(Len(pNovoVeterinarios.Utilizador) > 20, 20, Len(pNovoVeterinarios.Utilizador))))
        mCMD.Parameters.AddWithValue("@pPassword", pNovoVeterinarios.Password.Substring(0, IIf(Len(pNovoVeterinarios.Password) > 20, 20, Len(pNovoVeterinarios.Password))))
        mCMD.Parameters.AddWithValue("@pFotografia", pNovoVeterinarios.Fotografia.Substring(0, IIf(Len(pNovoVeterinarios.Fotografia) > 50, 50, Len(pNovoVeterinarios.Fotografia))))
        mCMD.Parameters.AddWithValue("@pFLG_Ativo", pNovoVeterinarios.FLG_Ativo)


        mStrSQL = "INSERT INTO Veterinarios "
        mStrSQL += "("
        mStrSQL += "Cod_Veterinario,"
        mStrSQL += "Nome,"
        mStrSQL += "Num_Telefone,"
        mStrSQL += "Num_Telemovel,"
        mStrSQL += "Email,"
        mStrSQL += "Utilizador,"
        mStrSQL += "Password,"
        mStrSQL += "Fotografia,"
        mStrSQL += "FLG_Ativo "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        mStrSQL += "@pCod_Veterinario,"
        mStrSQL += "@pNome,"
        mStrSQL += "@pNum_Telefone,"
        mStrSQL += "@pNum_Telemovel,"
        mStrSQL += "@pEmail,"
        mStrSQL += "@pUtilizador,"
        mStrSQL += "@pPassword,"
        mStrSQL += "@pFotografia,"
        mStrSQL += "1"
        mStrSQL += ")"

        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
            ClsEmpresas.GravaContador(menCont) '<<<<-------- Verificar se é  preciso...
        Catch ex As Exception
            MsgBox("GravaVeterinarios:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function ApagaVeterinarios(ByVal pCod_Veterinario As String) Método para Apagar um Registo da Tabela Veterinarios
    '''      Gerado em 29/11/2022 14:12:54
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2022
    ''' </remarks>
    Public Shared Function ApagaVeterinarios(ByVal pCod_Veterinario As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pCod_Veterinario", pCod_Veterinario)


        mStrSQL = "UPDATE Veterinarios SET "
        mStrSQL += "FLG_Ativo=0 "
        mStrSQL += "WHERE Cod_Veterinario=@pCod_Veterinario"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ApagaVeterinarios:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function
End Class



''' <summary>
'''      Classe VeterinariosComparer 
'''      Gerado em 29/11/2022 14:12:54
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2022
''' </remarks>
Public Class VeterinariosComparer
    Implements IEqualityComparer(Of ClsVeterinarios)

    Public Function Equals1(ByVal x As ClsVeterinarios, ByVal y As ClsVeterinarios) As Boolean Implements IEqualityComparer(Of ClsVeterinarios).Equals

        If x Is y Then Return True

        If x Is Nothing OrElse y Is Nothing Then Return False

        Return (x.Cod_Veterinario = y.Cod_Veterinario) ' AndAlso (x.FLG_Entidade = y.FLG_Entidade)
    End Function

    Public Function GetHashCode1(ByVal pCls As ClsVeterinarios) As Integer Implements IEqualityComparer(Of ClsVeterinarios).GetHashCode

        If pCls Is Nothing Then Return 0

        'Dim Hash_ClsVeterinarios_FLG_Entidade = pCls.FLG_Entidade.GetHashCode()
        Dim Hash_ClsVeterinarios_Cod_Veterinario = pCls.Cod_Veterinario.GetHashCode()

        Return Hash_ClsVeterinarios_Cod_Veterinario 'Xor Hash_ClsVeterinarios_FLG_Entidade
    End Function
End Class

