Imports System.Data.SqlClient
Imports System.IO

Public Class clsTipoPS
    Public Property Designacao As String
    Public MinPreco As Integer      ' 1 * 10
    Public MaxPreco As Integer      ' 1 * 10
    Public MaxStock As Integer
    Public FLG_Marca As Boolean

    Sub New()

    End Sub
    Sub New(pDesignacao As String, pMinPreco As Integer, pMaxPreco As Integer, pMaxStock As Integer, pFLG_Marca As Boolean)
        Designacao = pDesignacao
        MinPreco = pMinPreco
        MaxPreco = pMaxPreco
        MaxStock = pMaxStock
        FLG_Marca = pFLG_Marca
    End Sub
End Class

Public Class clsNomes
    Public Property Nome As String
    Public Property Sexo As String
    Public Property FLG_Ativo As Boolean

    Public Shared Function GetNomes() As List(Of clsNomes)
        Dim mLista As New List(Of clsNomes)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()

        mStrSQL = "SELECT "
        mStrSQL += "Nome,"
        mStrSQL += "Sexo,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Nomes "
        mStrSQL += "WHERE FLG_Ativo=1"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsNomes As New clsNomes

            With mClsNomes
                .Nome = mRDR.GetString(mRDR.GetOrdinal("Nome"))
                .Sexo = mRDR.GetString(mRDR.GetOrdinal("Sexo"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mLista.Add(mClsNomes)

        End While

        mRDR.Close()
        mDB.Close()

        Return mLista
    End Function
End Class

Public Class clsApelidos
    Public Property Apelido As String
    Public Property FLG_Ativo As Boolean


    Public Shared Function GetApelidos() As List(Of clsApelidos)
        Dim mLista As New List(Of clsApelidos)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()

        mStrSQL = "SELECT "
        mStrSQL += "Apelido "
        mStrSQL += "FROM Apelidos "
        mStrSQL += "WHERE FLG_Ativo=1"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsApelidos As New clsApelidos

            With mClsApelidos
                .Apelido = mRDR.GetString(mRDR.GetOrdinal("Apelido"))

            End With


            mLista.Add(mClsApelidos)

        End While

        mRDR.Close()
        mDB.Close()

        Return mLista
    End Function

End Class



Public Class ClsUtils
    Shared Function ImageFromFileNL(pFile As String) As Image
        Dim mReturn As Image = Nothing

        Using mFS = New FileStream(pFile, FileMode.Open, FileAccess.Read)
            mReturn = Image.FromStream(mFS)
        End Using

        Return mReturn
    End Function

End Class

Public Class clsNav
    Public Property Max_Registos As Integer
    Public Property Registo_Atual As Integer

    Sub New()

    End Sub
    Sub New(pMax As Integer)
        Me.Max_Registos = pMax
        Me.Registo_Atual = If(pMax > 0, 1, 0)
    End Sub

    Public Function Anterior() As Integer

        Registo_Atual = If(Registo_Atual > 1, Registo_Atual - 1, Registo_Atual)

        Return Registo_Atual
    End Function

    Public Function Seguinte() As Integer
        Registo_Atual = If(Registo_Atual < Max_Registos, Registo_Atual + 1, Registo_Atual)

        Return Registo_Atual
    End Function
    Public Function Primeiro() As Integer
        Registo_Atual = If(Max_Registos > 0, 1, 0)

        Return Registo_Atual
    End Function
    Public Function Ultimo() As Integer
        Registo_Atual = Max_Registos

        Return Registo_Atual
    End Function

End Class
