Public Class ucSplash
    Sub New()
        Dim mFrmMain As New frmMain

        InitializeComponent()

        Me.labelCopyright.Text = "Clive's ©  2022-" & DateTime.Now.Year.ToString()
        Me.DelayedClose(1500, mFrmMain)
        'AbreForm()
    End Sub

    Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
        MyBase.ProcessCommand(cmd, arg)
    End Sub

    Private Sub ucSplash_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Dim mFrmMain As New frmMain
        mFrmMain.Show()
    End Sub

    Private Sub ucSplash_Click(sender As Object, e As EventArgs) Handles Me.Click
        Close()
    End Sub

    Function AbreForm() As Boolean
        Dim mFrmMain As New frmMain
        mFrmMain.Show()
        Return True
    End Function
    Public Enum SplashScreenCommand
        SomeCommandId
    End Enum

End Class
