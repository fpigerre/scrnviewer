Public Class frmConnect

    Private Sub cmdListen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdListen.Click
        frmStream.Show()
    End Sub

    Private Sub cmdStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStop.Click
        frmStream.threading.Abort()
    End Sub
End Class
