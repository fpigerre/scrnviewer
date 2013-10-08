Imports System.Net.Sockets
Imports System.Drawing
Imports System.Threading
Imports System.Runtime.Serialization.Formatters.Binary.BinaryFormatter
Imports System.Runtime.Serialization.Formatters.Binary

Public Class Form1

    Dim tcpClient As New TcpClient
    Dim tcpServer As TcpListener
    Dim ns As NetworkStream
    Dim port As Integer

    Private Sub SendDesktop()
        Dim bf As New BinaryFormatter

        ns = tcpClient.GetStream()
        bf.Serialize(ns, Capture2())
    End Sub

    Private Function Capture() As Image
        Dim bounds As Rectangle = Nothing
        Dim scrnshot As System.Drawing.Bitmap = Nothing
        Dim graph As Graphics = Nothing

        bounds = Screen.PrimaryScreen.Bounds
        scrnshot = New Bitmap(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height, System.Drawing.Imaging.PixelFormat.Format32bppRgb)
        graph = Graphics.FromImage(scrnshot)
        graph.CopyFromScreen(0, 0, 0, 0, bounds.Size)
        Return scrnshot
    End Function

    Private Function Capture2()
        Dim bounds As Size = New Size(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
        Dim screenShot As New Bitmap(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
        Dim g As Graphics = Graphics.FromImage(screenShot)

        g.CopyFromScreen(New Point(0, 0), New Point(0, 0), bounds)

        Return screenShot
    End Function

    Private Sub cmdConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConnect.Click
        port = Integer.Parse(txtPort.Text)

        Try
            tcpClient.Connect(txtIp.Text, port)
            MsgBox("Connected", MsgBoxStyle.Information, "")
        Catch ex As Exception
            MsgBox("Connection failed", MsgBoxStyle.Critical, "")
        End Try
    End Sub

    Private Sub cmdSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSend.Click
        tmrSend.Start()
    End Sub

    Private Sub tmrSend_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrSend.Tick
        SendDesktop()
    End Sub
End Class
