Imports System.Data.SqlClient
Imports System.IO


Public Class ClsUtils
    Shared Function ImageFromFileNL(pFile As String) As Image
        Dim mReturn As Image = Nothing

        Using mFS = New FileStream(pFile, FileMode.Open, FileAccess.Read)
            mReturn = Image.FromStream(mFS)
        End Using

        Return mReturn
    End Function

    Shared Function GetDataSH(pData As Date) As Date
        Dim mData As Date

        mData = FormatDateTime(Year(pData).ToString & "-" & Month(pData).ToString("00") & "-" & pData.Day.ToString("00"), DateFormat.ShortDate)

        Return mData
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
