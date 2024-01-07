Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Reflection
Imports DevExpress.XtraBars.BarItemVisibility
Public Class UC_NAV

    Public Property mFRM As Object
    Friend mNovo As Boolean = False
    Sub Load_Status()

        If mNav.Registo_Atual > 0 Then
            Me.bbStatus.Caption = "Registo " & mNav.Registo_Atual.ToString("000") & " de " & mNav.Max_Registos.ToString("000")
        Else
            Me.bbStatus.Caption = ""
        End If
        SetupNav()


    End Sub

    Private Sub bbPrimeiro_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbPrimeiro.ItemClick
        mNav.Registo_Atual = mNav.Primeiro()
        mFRM.LoadRegistos()

        Load_Status()
    End Sub

    Private Sub bbAnterior_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbAnterior.ItemClick
        mNav.Registo_Atual = mNav.Anterior()
        mFRM.LoadRegistos()

        Load_Status()
    End Sub

    Private Sub bbSeguinte_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbSeguinte.ItemClick
        mNav.Registo_Atual = mNav.Seguinte()
        mFRM.LoadRegistos()
        Load_Status()
    End Sub

    Private Sub bbUltimo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbUltimo.ItemClick
        mNav.Registo_Atual = mNav.Ultimo()
        mFRM.LoadRegistos()

        Load_Status()
    End Sub

    Sub SetupBotoes(pBool As Boolean)

        Me.bbNovo.Visibility = If(Not pBool, Never, Always)
        Me.bbModifica.Visibility = If(Not pBool, Never, Always)
        Me.bbApaga.Visibility = If(Not pBool, Never, Always)
        Me.bbSair.Visibility = If(Not pBool, Never, Always)
        Me.bbGrava.Visibility = If(pBool, Never, Always)
        Me.bbCancela.Visibility = If(pBool, Never, Always)

        If mNovo Then bbStatus.Caption = ""

        bbPrimeiro.Enabled = pBool
        bbUltimo.Enabled = pBool
        bbSeguinte.Enabled = pBool
        bbAnterior.Enabled = pBool

    End Sub

    Sub SetupNav()

        bbPrimeiro.Enabled = (mNav.Registo_Atual > 1)
        bbUltimo.Enabled = (mNav.Registo_Atual < mNav.Max_Registos)
        bbSeguinte.Enabled = (mNav.Registo_Atual < mNav.Max_Registos)
        bbAnterior.Enabled = (mNav.Registo_Atual > 1)


    End Sub
    Private Sub bbSair_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbSair.ItemClick
        Try
            mFRM.close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub bbNovo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbNovo.ItemClick
        mNovo = True
        SetupBotoes(False)
        mFRM.setupcomps(False)
        mFRM.LimpaTXT
    End Sub

    Private Sub bbModifica_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbModifica.ItemClick
        mFRM.setupcomps(False)
        SetupBotoes(False)
    End Sub

    Private Sub bbApaga_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbApaga.ItemClick
        SetupBotoes(False)
        If MsgBox("Confirma que quer apagar o registo atual?", MsgBoxStyle.YesNo, "Apagar Registo") = MsgBoxResult.Yes Then
            mFRM.Apaga_Registo()
        End If
        SetupBotoes(True)
        Load_Status()
    End Sub

    Private Sub bbGrava_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbGrava.ItemClick
        mFRM.Grava(mNovo)
        mNovo = False
        mFRM.setupcomps(True)

        SetupBotoes(True)
        Load_Status()
    End Sub

    Private Sub bbCancela_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbCancela.ItemClick

        mNovo = False
        mFRM.setupcomps(True)
        mFRM.LoadRegistos

        SetupBotoes(True)
        Load_Status()
    End Sub

    Private Sub UC_NAV1_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetupBotoes(True)
        bbStatus.Caption = ""

    End Sub
End Class
