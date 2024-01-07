Imports DevExpress.XtraBars.FluentDesignSystem

Public Enum enUserControlsFront
    Dashboard
    Consultas
    Artigos
    Veterinarios
    Procurar
End Enum

Public Class frmMain
    Friend mUC As New UserControl
    Friend mFrm As New Form
    Friend mFrmApp As New frmApp

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadUC(enUserControlsFront.Dashboard)
    End Sub

    Sub loadUC(pUserControls As enUserControlsFront)
        Dim mParent As New Panel
        mParent = pnMain

        Select Case pUserControls
            Case enUserControlsFront.Dashboard
                mUC = New ucDashboard
            Case enUserControlsFront.Consultas
                mFrm = New frmApp

            Case enUserControlsFront.Artigos
                mUC = New ucFaturacao
            Case enUserControlsFront.Veterinarios
                mUC = New ucVeterinarios
            Case enUserControlsFront.Procurar
                mUC = New ucProcurar
        End Select


        mUC.Dock = DockStyle.Fill
        mUC.Parent = mParent
        mUC.Show()
    End Sub

    Private Sub aceDashboard_Click(sender As Object, e As EventArgs) Handles aceDashboard.Click
        mUC.Parent = Nothing
        mUC.Dispose()
        mFrmApp.Hide()
        loadUC(enUserControlsFront.Dashboard)
        aceDashboard.Appearance.Default.BackColor = Color.Coral
        aceConsultas.Appearance.Default.BackColor = Nothing
        aceFaturacao.Appearance.Default.BackColor = Nothing
        aceVeterinarios.Appearance.Default.BackColor = Nothing
        aceProcurar.Appearance.Default.BackColor = Nothing
    End Sub

    Private Sub aceConsultas_Click(sender As Object, e As EventArgs) Handles aceConsultas.Click
        mUC.Dispose()


        mFrmApp.FormBorderStyle = FormBorderStyle.None
        mFrmApp.TopLevel = False
        mFrmApp.Parent = Me.pnMain
        mFrmApp.Dock = DockStyle.Fill

        mFrmApp.Show()

        aceDashboard.Appearance.Normal.BackColor = Nothing
        aceDashboard.Appearance.Default.BackColor = Nothing
        aceConsultas.Appearance.Default.BackColor = Color.Coral
        aceFaturacao.Appearance.Default.BackColor = Nothing
        aceVeterinarios.Appearance.Default.BackColor = Nothing
        aceProcurar.Appearance.Default.BackColor = Nothing
    End Sub


    Friend Sub ArtClick()
        mUC.Parent = Nothing
        mUC.Dispose()
        mFrmApp.Hide()
        loadUC(enUserControlsFront.Artigos)
        aceDashboard.Appearance.Normal.BackColor = Nothing
        aceDashboard.Appearance.Default.BackColor = Nothing
        aceConsultas.Appearance.Default.BackColor = Nothing
        aceFaturacao.Appearance.Default.BackColor = Color.Coral
        aceVeterinarios.Appearance.Default.BackColor = Nothing
        aceProcurar.Appearance.Default.BackColor = Nothing
    End Sub

    Private Sub aceArtigos_Click(sender As Object, e As EventArgs) Handles aceFaturacao.Click
        ArtClick()
    End Sub

    Private Sub aceVeterinarios_Click(sender As Object, e As EventArgs) Handles aceVeterinarios.Click
        mUC.Parent = Nothing
        mUC.Dispose()
        mFrmApp.Hide()
        loadUC(enUserControlsFront.Veterinarios)
        aceDashboard.Appearance.Normal.BackColor = Nothing
        aceDashboard.Appearance.Default.BackColor = Nothing
        aceConsultas.Appearance.Default.BackColor = Nothing
        aceFaturacao.Appearance.Default.BackColor = Nothing
        aceVeterinarios.Appearance.Default.BackColor = Color.Coral
        aceProcurar.Appearance.Default.BackColor = Nothing
    End Sub

    Private Sub aceProcurar_Click(sender As Object, e As EventArgs) Handles aceProcurar.Click
        mUC.Parent = Nothing
        mUC.Dispose()
        loadUC(enUserControlsFront.Procurar)
        aceDashboard.Appearance.Normal.BackColor = Nothing
        aceDashboard.Appearance.Default.BackColor = Nothing
        aceConsultas.Appearance.Default.BackColor = Nothing
        aceFaturacao.Appearance.Default.BackColor = Nothing
        aceVeterinarios.Appearance.Default.BackColor = Nothing
        aceProcurar.Appearance.Default.BackColor = Color.Coral
    End Sub

    Private Sub accSair_Click(sender As Object, e As EventArgs) Handles accSair.Click
        Me.Hide()
        Dim mFrm As New frmLogin
        mFrm.Show()
    End Sub


End Class