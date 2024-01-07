Public Enum enUserControls
    Categorias
    Animais
    Artigos
    Inicio
    Calendarios
    Consultas
    Doc
    Entidades
    Series
    TiposDoc
    TipoConsulta
    Enderecos
    TiposAnimais
    IVA
    Veterinarios
End Enum

Public Class frmMain
    Friend mUC As UserControl

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimumSize = Me.Size
        loadUC(enUserControls.Inicio)
    End Sub

    Sub loadUC(pUserControls As enUserControls)
        Dim mParent As New Panel
        mParent = Panel1

        Select Case pUserControls
            Case enUserControls.Animais
                mUC = New UC_Animais
            Case enUserControls.Categorias
                mUC = New UC_Categorias
            Case enUserControls.Inicio
                mUC = New UC_Inicio
            Case enUserControls.Calendarios
                mUC = New UC_Calendarios
            Case enUserControls.Consultas
                mUC = New UC_Consultas
            Case enUserControls.Doc
                mUC = New ucDoc
            Case enUserControls.Entidades
                mUC = New UC_Entidades
            Case enUserControls.Series
                mUC = New UC_Series
            Case enUserControls.TiposDoc
                mUC = New UC_TiposDoc
            Case enUserControls.TipoConsulta
                mUC = New ucTiposConsulta
            Case enUserControls.TiposAnimais
                mUC = New ucTiposAnimais
            Case enUserControls.Artigos
                mUC = New UC_Artigos
            Case enUserControls.IVA
                mUC = New ucIVA
            Case enUserControls.Veterinarios
                mUC = New ucVeterinarios
        End Select

        mUC.Dock = DockStyle.Fill
        mUC.Parent = mParent
        mUC.Show()

    End Sub

    Private Sub accG_Calendarios_Click(sender As Object, e As EventArgs) Handles accG_Calendarios.Click
        mUC.Parent = Nothing
        mUC.Dispose()
        loadUC(enUserControls.Calendarios)

    End Sub

    Private Sub accG_Entidades_Click(sender As Object, e As EventArgs) Handles accG_Entidades.Click
        mUC.Parent = Nothing
        mUC.Dispose()
        loadUC(enUserControls.Entidades)
    End Sub

    Private Sub accG_Doc_Click(sender As Object, e As EventArgs) Handles accG_Doc.Click
        mUC.Parent = Nothing
        mUC.Dispose()
        loadUC(enUserControls.Doc)
    End Sub

    Private Sub accG_Series_Click(sender As Object, e As EventArgs) Handles accG_Series.Click
        mUC.Parent = Nothing
        mUC.Dispose()
        loadUC(enUserControls.Series)
    End Sub

    Private Sub accG_Animais_Click(sender As Object, e As EventArgs) Handles accG_Animais.Click
        mUC.Parent = Nothing
        mUC.Dispose()
        loadUC(enUserControls.Animais)
    End Sub

    Private Sub accG_TD_Click(sender As Object, e As EventArgs) Handles accG_TD.Click
        mUC.Parent = Nothing
        mUC.Dispose()
        loadUC(enUserControls.TiposDoc)
    End Sub

    Private Sub frmMain_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub

    Private Sub accG_TC_Click(sender As Object, e As EventArgs) Handles accG_TC.Click
        mUC.Parent = Nothing
        mUC.Dispose()
        loadUC(enUserControls.TipoConsulta)
    End Sub

    Private Sub accG_Enderecos_Click(sender As Object, e As EventArgs)
        mUC.Parent = Nothing
        mUC.Dispose()
        loadUC(enUserControls.Enderecos)
    End Sub

    Private Sub accG_Artigos_Click(sender As Object, e As EventArgs) Handles accG_Artigos.Click
        mUC.Parent = Nothing
        mUC.Dispose()
        loadUC(enUserControls.Artigos)
    End Sub

    Private Sub accG_IVA_Click(sender As Object, e As EventArgs) Handles accG_IVA.Click
        mUC.Parent = Nothing
        mUC.Dispose()
        loadUC(enUserControls.IVA)
    End Sub

    Private Sub accG_TiposAnimais_Click(sender As Object, e As EventArgs) Handles accG_TiposAnimais.Click
        mUC.Parent = Nothing
        mUC.Dispose()
        loadUC(enUserControls.TiposAnimais)
    End Sub

    Private Sub accG_Categorias_Click(sender As Object, e As EventArgs) Handles accG_Categorias.Click
        mUC.Parent = Nothing
        mUC.Dispose()
        loadUC(enUserControls.Categorias)
    End Sub

    Private Sub accG_Consultas_Click(sender As Object, e As EventArgs) Handles accG_Consultas.Click
        mUC.Parent = Nothing
        mUC.Dispose()
        loadUC(enUserControls.Consultas)
    End Sub

    Private Sub accG_Veterinarios_Click(sender As Object, e As EventArgs) Handles accG_Veterinarios.Click
        mUC.Parent = Nothing
        mUC.Dispose()
        loadUC(enUserControls.Veterinarios)
    End Sub

    Private Sub accSair_Click(sender As Object, e As EventArgs) Handles accSair.Click
        Me.Hide()
        Dim mFrm As New frmLogin
        mFrm.Show()
    End Sub
End Class