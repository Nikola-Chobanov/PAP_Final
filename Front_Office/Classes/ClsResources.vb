
Imports System.Data.SqlClient
Imports System.IO


''' <summary>
'''      Classe ClsResources Classe da Tabela Resources
'''      Gerado em 21/03/2023 16:57:55
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2023
''' </remarks>
Public Class ClsResources


    ' -----------------------------------------
    ' Property's da tabela Resources
    ' -----------------------------------------

    Public Property UniqueID As Integer                                     ' SQL_Type: int
    Public Property ResourceID As Integer                                   ' SQL_Type: int
    Public Property ResourceName As String                                  ' Len: 50 - SQL_Type: nvarchar
    Public Property Color As Integer                                        ' SQL_Type: int
    Public Property Image As Stream                                         ' SQL_Type: image
    Public Property CustomField1 As String                                  ' Len: -1 - SQL_Type: nvarchar
    Public Property CustomField2 As String                                  ' Len: -1 - SQL_Type: nvarchar
    Public Property CustomField3 As String                                  ' Len: -1 - SQL_Type: nvarchar


    Sub New()
    End Sub


    '--------------------------------------------
    ' Exemplo de criador de Código por contador
    ' Para ser usado no caso de o Cdigo ser gerado
    ' e o contador existir na tabela Empresas
    '---------------------------------------------

    'Friend Shared Function GetNovoCodigo() As String

    'Return "R" & ClsEmpresas.GetContador(enCont.Resources).ToString("000")' <-------------- VERIFICAR O Nº de ZEROS

    'End Function


    ''' <summary>
    '''      Function GetResources() Método para devolver a Lista de Resources
    '''      Gerado em 21/03/2023 16:57:55
    ''' </summary>
    ''' <returns>
    '''      mListaResources
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function GetResources() As List(Of ClsResources)
        Dim mListaResources As New List(Of ClsResources)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(UniqueID,0) As UniqueID,"
        mStrSQL += "ISNULL(ResourceID,0) As ResourceID,"
        mStrSQL += "ISNULL(ResourceName,'') As ResourceName,"
        mStrSQL += "ISNULL(Color,0) As Color,"
        mStrSQL += "ISNULL(Image,0) As Image,"
        mStrSQL += "ISNULL(CustomField1,'') As CustomField1,"
        mStrSQL += "ISNULL(CustomField2,'') As CustomField2,"
        mStrSQL += "ISNULL(CustomField3,'') As CustomField3 "
        mStrSQL += "FROM Resources "
        mStrSQL += "WHERE FLG_Ativo=1"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsResources As New ClsResources

            With mClsResources
                .UniqueID = mRDR.GetValue(mRDR.GetOrdinal("UniqueID"))
                .ResourceID = mRDR.GetValue(mRDR.GetOrdinal("ResourceID"))
                .ResourceName = mRDR.GetString(mRDR.GetOrdinal("ResourceName"))
                .Color = mRDR.GetValue(mRDR.GetOrdinal("Color"))

                .Image = mRDR.GetStream(mRDR.GetOrdinal("Image"))

                .CustomField1 = mRDR.GetString(mRDR.GetOrdinal("CustomField1"))
                .CustomField2 = mRDR.GetString(mRDR.GetOrdinal("CustomField2"))
                .CustomField3 = mRDR.GetString(mRDR.GetOrdinal("CustomField3"))
            End With


            mListaResources.Add(mClsResources)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaResources
    End Function


    ''' <summary>
    '''      Function GetResourcesByCod(ByVal pUniqueID As Integer) Método para decolver uma Classe de Resources
    '''      Gerado em 21/03/2023 16:57:56
    ''' </summary>
    ''' <returns>
    '''      mClsResources
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function GetResourcesByCod(ByVal pUniqueID As Integer) As ClsResources
        Dim mClsResources As New ClsResources

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pUniqueID", pUniqueID)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(UniqueID,0) As UniqueID,"
        mStrSQL += "ISNULL(ResourceID,0) As ResourceID,"
        mStrSQL += "ISNULL(ResourceName,'') As ResourceName,"
        mStrSQL += "ISNULL(Color,0) As Color,"
        mStrSQL += "ISNULL(Image,0) As Image,"
        mStrSQL += "ISNULL(CustomField1,'') As CustomField1,"
        mStrSQL += "ISNULL(CustomField2,'') As CustomField2,"
        mStrSQL += "ISNULL(CustomField3,'') As CustomField3 "
        mStrSQL += "FROM Resources "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND UniqueID=@pUniqueID"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsResources
                .UniqueID = mRDR.GetValue(mRDR.GetOrdinal("UniqueID"))
                .ResourceID = mRDR.GetValue(mRDR.GetOrdinal("ResourceID"))
                .ResourceName = mRDR.GetString(mRDR.GetOrdinal("ResourceName"))
                .Color = mRDR.GetValue(mRDR.GetOrdinal("Color"))

                .Image = mRDR.GetStream(mRDR.GetOrdinal("Image"))

                .CustomField1 = mRDR.GetString(mRDR.GetOrdinal("CustomField1"))
                .CustomField2 = mRDR.GetString(mRDR.GetOrdinal("CustomField2"))
                .CustomField3 = mRDR.GetString(mRDR.GetOrdinal("CustomField3"))
            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mClsResources
    End Function


    ''' <summary>
    '''      Function ModificaResources(ByVal pClsResources As ClsResources) Método para Modificar a TABELA Resources
    '''      Gerado em 21/03/2023 16:57:56
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function ModificaResources(ByVal pClsResources As ClsResources) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pUniqueID", pClsResources.UniqueID)
        mCMD.Parameters.AddWithValue("@pResourceID", pClsResources.ResourceID)
        mCMD.Parameters.AddWithValue("@pResourceName", pClsResources.ResourceName.Substring(0, IIf(Len(pClsResources.ResourceName) > 50, 50, Len(pClsResources.ResourceName))))
        mCMD.Parameters.AddWithValue("@pColor", pClsResources.Color)
        mCMD.Parameters.AddWithValue("@pImage", pClsResources.Image)
        mCMD.Parameters.AddWithValue("@pCustomField1", pClsResources.CustomField1.Substring(0, IIf(Len(pClsResources.CustomField1) > -1, -1, Len(pClsResources.CustomField1))))
        mCMD.Parameters.AddWithValue("@pCustomField2", pClsResources.CustomField2.Substring(0, IIf(Len(pClsResources.CustomField2) > -1, -1, Len(pClsResources.CustomField2))))


        mStrSQL = "UPDATE Resources SET "
        mStrSQL += "ResourceID=@pResourceID,"
        mStrSQL += "ResourceName=@pResourceName,"
        mStrSQL += "Color=@pColor,"
        mStrSQL += "Image=@pImage,"
        mStrSQL += "CustomField1=@pCustomField1,"
        mStrSQL += "CustomField2=@pCustomField2 "
        mStrSQL += "WHERE UniqueID=@pUniqueID"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ModificaResources:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function GravaResources(ByVal pNovoResources As ClsResources) Método para Gravar a TABELA Resources
    '''      Gerado em 21/03/2023 16:57:56
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function GravaResources(ByVal pNovoResources As ClsResources) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()


        mCMD.Parameters.AddWithValue("@pUniqueID", pNovoResources.UniqueID)
        mCMD.Parameters.AddWithValue("@pResourceID", pNovoResources.ResourceID)
        mCMD.Parameters.AddWithValue("@pResourceName", pNovoResources.ResourceName.Substring(0, IIf(Len(pNovoResources.ResourceName) > 50, 50, Len(pNovoResources.ResourceName))))
        mCMD.Parameters.AddWithValue("@pColor", pNovoResources.Color)
        mCMD.Parameters.AddWithValue("@pImage", pNovoResources.Image)
        mCMD.Parameters.AddWithValue("@pCustomField1", pNovoResources.CustomField1.Substring(0, IIf(Len(pNovoResources.CustomField1) > -1, -1, Len(pNovoResources.CustomField1))))
        mCMD.Parameters.AddWithValue("@pCustomField2", pNovoResources.CustomField2.Substring(0, IIf(Len(pNovoResources.CustomField2) > -1, -1, Len(pNovoResources.CustomField2))))
        mCMD.Parameters.AddWithValue("@pCustomField3", pNovoResources.CustomField3.Substring(0, IIf(Len(pNovoResources.CustomField3) > -1, -1, Len(pNovoResources.CustomField3))))


        mStrSQL = "INSERT INTO Resources "
        mStrSQL += "("
        mStrSQL += "UniqueID,"
        mStrSQL += "ResourceID,"
        mStrSQL += "ResourceName,"
        mStrSQL += "Color,"
        mStrSQL += "Image,"
        mStrSQL += "CustomField1,"
        mStrSQL += "CustomField2,"
        mStrSQL += "CustomField3 "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        mStrSQL += "@pUniqueID,"
        mStrSQL += "@pResourceID,"
        mStrSQL += "@pResourceName,"
        mStrSQL += "@pColor,"
        mStrSQL += "@pImage,"
        mStrSQL += "@pCustomField1,"
        mStrSQL += "@pCustomField2,"
        mStrSQL += "@pCustomField3 "
        mStrSQL += ")"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
            'ClsEmpresas.GravaContador(enCont.Resources)'<<<<-------- Verificar se é  preciso...
        Catch ex As Exception
            MsgBox("GravaResources:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function ApagaResources(ByVal pUniqueID As Integer) Método para Apagar um Registo da Tabela Resources
    '''      Gerado em 21/03/2023 16:57:56
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2023
    ''' </remarks>
    Public Shared Function ApagaResources(ByVal pUniqueID As Integer) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pUniqueID", pUniqueID)


        mStrSQL = "UPDATE Resources SET "
        mStrSQL += "FLG_Ativo=0 "
        mStrSQL += "WHERE UniqueID=@pUniqueID"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ApagaResources:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function
End Class

