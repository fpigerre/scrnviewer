Imports System.Net.Sockets
Imports System.Threading
Imports System.Drawing
Imports System.Runtime.Serialization.Formatters.Binary

Public Class frmStream

    Dim tcpClient As New TcpClient
    Dim port As Integer
    Dim tcpServer As TcpListener
    Dim ns As NetworkStream
    Public threading As New Thread(AddressOf Listen)
    Dim getImage As New Thread(AddressOf gImage)

    Private Sub gImage()
        Dim bf As New BinaryFormatter

        While tcpClient.Connected = True
            ns = tcpClient.GetStream()
            pbScreen.Image = bf.Deserialize(ns)
        End While
    End Sub

    Private Sub Listen()
        While tcpClient.Connected = False
            tcpServer.Start()
            tcpClient = tcpServer.AcceptTcpClient()
        End While
        getImage.Start()
    End Sub

    Private Sub frmStream_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        port = frmConnect.txtPort.Text
        tcpServer = New TcpListener(port)
        threading.Start()
    End Sub
End Class