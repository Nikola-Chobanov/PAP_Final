Public Class ClsQI
    Public Property Num_Doc As String
    Public Property Tipo_IVA As String
    Public Property S_IVA As Decimal
    Public Property V_IVA As Decimal
    Public Property Taxa_IVA As Integer

    Sub New()

    End Sub
    ''' <summary>
    '''  Calculo com este construtor apenas o Sujeito e o Valor por TIPO_IVA
    '''  
    ''' </summary>
    ''' <param name="pTaxa_IVA"></param>
    ''' <param name="pLinhas"></param>
    Sub New(pTaxa_IVA As String, pLinhas As List(Of ClsLinhas))
        Num_Doc = pLinhas(0).Num_Doc
        Taxa_IVA = pTaxa_IVA
        pLinhas = pLinhas.FindAll(Function(x) x.Taxa_IVA = pTaxa_IVA)

        If pLinhas.Count > 0 Then

            For Each pLin As ClsLinhas In pLinhas
                If pLin.Taxa_IVA = pTaxa_IVA And pLin.Cod_Artigo <> "" Then

                    S_IVA = pLinhas.Sum(Function(x) (x.Valor_Iliquido - x.Valor_Desconto))
                    V_IVA = pLinhas.Sum(Function(x) (x.Valor_IVA))

                End If
            Next

            Math.Round(S_IVA, 1)
            Math.Round(V_IVA, 1)
        Else
            S_IVA = 0D
            V_IVA = 0D
        End If

        Tipo_IVA = Taxa_IVA.ToString() & "%"

    End Sub

    Friend Shared Function GetQI(pLinhas As List(Of ClsLinhas)) As List(Of ClsQI)
        Dim mReturn As New List(Of ClsQI)
        Dim mLista_IVA As New List(Of ClsIVA)

        'pLinhas = pLinhas.FindAll(Function(x) x.FLG_Feita)

        mLista_IVA = ClsIVA.GetIVA

        For Each pIVA As ClsIVA In mLista_IVA

            Dim mQI As New ClsQI(pIVA.Taxa_IVA, pLinhas)
            If mQI.S_IVA > 0D Then
                mReturn.Add(mQI)
            End If
        Next

        Return mReturn
    End Function

    Public Shared Function GetQIByCod(ByVal pNum_Doc As String) As List(Of ClsQI)
        Dim mReturn As New List(Of ClsQI)

        Dim mLinhas As New List(Of ClsLinhas)
        mLinhas = ClsLinhas.GetLinhas(pNum_Doc)


        mReturn = ClsQI.GetQI(mLinhas)
        Return mReturn
    End Function
End Class
