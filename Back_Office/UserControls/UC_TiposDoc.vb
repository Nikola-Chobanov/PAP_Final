Imports DevExpress.Office.Utils
''' <summary>
'''      Classe frmTipos_Doc- Form da Tabela de Tipos_Doc
'''      Gerado em 29/11/2022 14:12:55
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2022
''' </remarks>
Public Class UC_TiposDoc
    Dim mLista As New List(Of ClsTipos_Doc)
    Dim mDoc As New ClsDoc
    Dim mTD As New ClsTipos_Doc

    Private Sub frmTipos_Doc_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        mLista = ClsTipos_Doc.GetTipos_Doc
        mNav = New clsNav(mLista.Count)

        UC_NAV11.mFRM = Me

        SetupComps(True)
        UC_NAV11.Load_Status()
        UC_NAV11.SetupNav()
        LoadRegistos()

        Me.Text = "Manutenção da Tabela de Tipos_Doc"


        setupugTD()
    End Sub


    Sub SetupComps(ByVal pBool As Boolean)
        If Not pBool Then
            If Me.UC_NAV11.mNovo Then
                Me.FLGTipoDocTextEdit.Focus()
            Else
                Me.DesignacaoTextEdit.Focus()
            End If
        End If
        FLGTipoDocTextEdit.ReadOnly = pBool
        FLGTipoDocTextEdit.Enabled = Not pBool
        DesignacaoTextEdit.ReadOnly = pBool
        DesignacaoTextEdit.Enabled = Not pBool
        DescritivoImpressaoTextEdit.Enabled = pBool
        DescritivoImpressaoTextEdit.Enabled = Not pBool
        FLGESCTextEdit.ReadOnly = pBool
        FLGESCTextEdit.Enabled = Not pBool
        FLGDCTextEdit.ReadOnly = pBool
        FLGDCTextEdit.Enabled = Not pBool
        FLGEntidadeTextEdit.ReadOnly = pBool
        FLGEntidadeTextEdit.Enabled = Not pBool
        CodSerieTextEdit.ReadOnly = pBool
        CodSerieTextEdit.Enabled = Not pBool
        FLGVendaCheckEdit.Enabled = Not pBool
        FLGCompraCheckEdit.Enabled = Not pBool
        FLGStockCheckEdit.Enabled = Not pBool


    End Sub

    Sub LoadRegistos()
        LimpaTXT()
        If mNav.Registo_Atual > 0 Then
            With mLista(mNav.Registo_Atual - 1)
                DesignacaoTextEdit.Text = .Designacao
                DescritivoImpressaoTextEdit.Text = .Descritivo_Impressao
                FLGESCTextEdit.Text = .FLG_ESC
                FLGDCTextEdit.Text = .FLG_DC
                FLGEntidadeTextEdit.Text = .FLG_Entidade
                FLGVendaCheckEdit.EditValue = .FLG_Venda
                FLGCompraCheckEdit.EditValue = .FLG_Compra
                FLGStockCheckEdit.EditValue = .FLG_Stock
                CodSerieTextEdit.Text = .Cod_Serie
                FLGTipoDocTextEdit.Text = .FLG_Tipo_Doc
            End With

        End If

    End Sub

    Sub LimpaTXT()

        DesignacaoTextEdit.Text = ""
        DescritivoImpressaoTextEdit.Text = ""
        FLGESCTextEdit.Text = ""
        FLGDCTextEdit.Text = ""
        FLGEntidadeTextEdit.Text = ""
        FLGVendaCheckEdit.Text = ""
        FLGCompraCheckEdit.Text = ""
        FLGStockCheckEdit.Text = ""
        CodSerieTextEdit.Text = ""
        '-------------------------------
        FLGTipoDocTextEdit.Text = ""
    End Sub


    Sub Grava(ByVal pbNovo As Boolean)
        Dim mFLG_Gravou As Boolean = False
        Dim mCls As New ClsTipos_Doc
        Dim mRegisto_Atual As Integer = mNav.Registo_Atual
TD_Erro:
        With mCls

            If pbNovo Then
                CodSerieTextEdit.Text = Year(Date.Now) & "-" & FLGTipoDocTextEdit.Text
            Else
                .FLG_Tipo_Doc = FLGTipoDocTextEdit.Text
            End If

            .Designacao = DesignacaoTextEdit.Text
            .Descritivo_Impressao = DescritivoImpressaoTextEdit.Text
            .FLG_ESC = FLGESCTextEdit.Text
            .FLG_DC = FLGDCTextEdit.Text
            .FLG_Entidade = FLGEntidadeTextEdit.Text
            .FLG_Venda = FLGVendaCheckEdit.CheckState
            .FLG_Compra = FLGCompraCheckEdit.CheckState
            .FLG_Stock = FLGStockCheckEdit.CheckState
            .Cod_Serie = CodSerieTextEdit.Text
        End With

        If FLGTipoDocTextEdit.Text.Count <= 3 Then
            If pbNovo Then
                mFLG_Gravou = ClsTipos_Doc.GravaTipos_Doc(mCls)
            Else
                mFLG_Gravou = ClsTipos_Doc.ModificaTipos_Doc(mCls)
            End If
        Else
            GoTo TD_Erro
        End If


        If mFLG_Gravou Then
            If pbNovo Then
                Me.UC_NAV11.mNovo = False
                mLista = ClsTipos_Doc.GetTipos_Doc
                mNav = New clsNav(mLista.Count)
                mNav.Registo_Atual = mLista.FindIndex(Function(x) x.FLG_Tipo_Doc = mCls.FLG_Tipo_Doc) + 1
                LoadRegistos()
            Else
                mLista = ClsTipos_Doc.GetTipos_Doc
                mNav = New clsNav(mLista.Count)
                mNav.Registo_Atual = mRegisto_Atual
                LoadRegistos()
            End If
        Else
            MsgBox("Erro na gravação:")
        End If
    End Sub


    Sub Apaga_Registo()
        Try
            ClsTipos_Doc.ApagaTipos_Doc(mLista(mNav.Registo_Atual - 1).FLG_Tipo_Doc)
        Catch ex As Exception
            MsgBox("Erro a Apagar o Registo Atual" & vbCrLf & ex.Message)
            Exit Sub
        End Try

        mLista = ClsTipos_Doc.GetTipos_Doc
        mNav = New clsNav(mLista.Count)
        LoadRegistos()
    End Sub


    Private Sub FLGVendaCheckEdit_CheckedChanged(sender As Object, e As EventArgs) Handles FLGVendaCheckEdit.Click
        If FLGVendaCheckEdit.Checked Then
            FLGCompraCheckEdit.CheckState = CheckState.Unchecked
        Else
            FLGCompraCheckEdit.CheckState = CheckState.Indeterminate
        End If
    End Sub

    Private Sub FLGCompraCheckEdit_CheckedChanged(sender As Object, e As EventArgs) Handles FLGCompraCheckEdit.Click
        If FLGCompraCheckEdit.Checked Then
            FLGVendaCheckEdit.CheckState = CheckState.Unchecked
        Else
            FLGVendaCheckEdit.CheckState = CheckState.Indeterminate
        End If
    End Sub

    Private Sub FLGStockCheckEdit_CheckedChanged(sender As Object, e As EventArgs) Handles FLGStockCheckEdit.MouseClick
        If FLGStockCheckEdit.CheckState = CheckState.Checked Then
            FLGStockCheckEdit.CheckState = CheckState.Unchecked
        Else
            FLGStockCheckEdit.CheckState = CheckState.Checked
        End If
    End Sub

    Sub setupugTD()
        Me.ugTD.DataSource = mLista
        With ugTD
            .DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.Select
            .DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None

        End With
    End Sub

    Private Sub FLGTipoDocTextEdit_Leave(sender As Object, e As EventArgs) Handles FLGTipoDocTextEdit.Leave
        CodSerieTextEdit.Text = Year(Date.Now) & "-" & FLGTipoDocTextEdit.Text
    End Sub

    Private Sub FLGDCTextEdit_EditValueChanged(sender As Object, e As EventArgs) Handles FLGDCTextEdit.EditValueChanged

    End Sub

    Private Sub DesignacaoTextEdit_TextChanged(sender As Object, e As EventArgs) Handles DesignacaoTextEdit.LostFocus
        
    End Sub
End Class
