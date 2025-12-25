Imports System.Net
Imports System.Net.Sockets
Imports System.Text

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set default values
        txtIPAddress.Text = "192.168.1.100"
        txtPort.Text = "8888"
        txtCustomMessage.Text = ""
        lblStatus.Text = "Ready"
        lblStatus.ForeColor = Color.Black
    End Sub

    Private Sub SendUDPMessage(message As String)
        Dim ipAddress As String = txtIPAddress.Text
        Dim port As Integer

        ' Validate port number
        If Not Integer.TryParse(txtPort.Text, port) Then
            lblStatus.Text = "Error: Invalid port number"
            lblStatus.ForeColor = Color.Red
            Return
        End If

        Try
            ' Create UDP client
            Using udpClient As New UdpClient()
                ' Convert message to bytes
                Dim messageBytes As Byte() = Encoding.ASCII.GetBytes(message)

                ' Send the UDP packet
                Dim bytesSent As Integer = udpClient.Send(messageBytes, messageBytes.Length, ipAddress, port)

                If bytesSent > 0 Then
                    lblStatus.Text = $"Sent: ""{message}"" to {ipAddress}:{port}"
                    lblStatus.ForeColor = Color.Green
                Else
                    lblStatus.Text = "Error: Failed to send message"
                    lblStatus.ForeColor = Color.Red
                End If
            End Using

        Catch ex As Exception
            lblStatus.Text = $"Error: {ex.Message}"
            lblStatus.ForeColor = Color.Red
        End Try
    End Sub

    Private Sub btnSendLights_Click(sender As Object, e As EventArgs) Handles btnSendLights.Click
        SendUDPMessage("lights_on")
    End Sub

    Private Sub btnSendCustom_Click(sender As Object, e As EventArgs) Handles btnSendCustom.Click
        Dim message As String = txtCustomMessage.Text.Trim()

        If String.IsNullOrEmpty(message) Then
            lblStatus.Text = "Error: Please enter a message to send"
            lblStatus.ForeColor = Color.Red
            Return
        End If

        SendUDPMessage(message)
    End Sub

End Class