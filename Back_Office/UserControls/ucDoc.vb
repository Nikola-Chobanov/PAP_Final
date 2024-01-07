Imports DevExpress.Charts.Native
Imports DevExpress.Utils.MVVM
Imports DevExpress.XtraEditors.Design
Imports DevExpress.XtraPrinting.Preview
Imports DevExpress.XtraRichEdit.Model

Public Class ucDoc
    Dim mLista As New List(Of ClsDoc)
    Dim mDoc As New ClsDoc
    Dim mDV As Object
    Private Sub ucDoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mLista = ClsDoc.GetDoc
        ugDocs.DataSource = mLista
        setup_ugDocs()
    End Sub

    Sub setup_ugDocs()
        ugDocs.DisplayLayout.Override.AllowDelete = False
        ugDocs.DisplayLayout.Override.AllowAddNew = False
        ugDocs.DisplayLayout.Override.AllowColSwapping = False
        ugDocs.DisplayLayout.Override.AllowColSizing = False
        ugDocs.DisplayLayout.Override.AllowColMoving = False
        ugDocs.DisplayLayout.GroupByBox.Hidden = True
    End Sub

    Sub dvLoad()
        If Not mDV Is Nothing Then
            mDV.Dispose()
        End If
        Dim mxFAT As New xrFAT
        Dim mxQI As New xrQI
        Dim mlistaLinhas As List(Of ClsLinhas)
        mDV = New DocumentViewer

        mlistaLinhas = ClsLinhas.GetLinhas(mDoc.Num_Doc)
        With mxFAT
            .ObjectDataSource1.Parameters(0).Value = mDoc.Num_Doc
        End With
        With mxQI
            .ObjectDataSource2.Parameters(0).Value = mDoc.Num_Doc
        End With

        mDV.DocumentSource = mxFAT
        mDV.Parent = SC.Panel2
        mDV.Dock = DockStyle.Fill
        DocumentViewerBarManager1.DocumentViewer = mDV
    End Sub

    Private Sub ugDocs_AfterCellActivate(sender As Object, e As EventArgs) Handles ugDocs.ClickCell
        If ugDocs.ActiveRow Is Nothing Then
            Exit Sub
        End If
        mDoc = ClsDoc.GetDocByCod(ugDocs.ActiveRow.Cells(0).Text)
        'mDoc.Num_Doc = ugDocs.ActiveRow.Cells(0).Text
        dvLoad()
    End Sub

    Private Sub ugDocs_AfterCellActivate(sender As Object, e As Infragistics.Win.UltraWinGrid.ClickCellEventArgs) Handles ugDocs.ClickCell

    End Sub
End Class