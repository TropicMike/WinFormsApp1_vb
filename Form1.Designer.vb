<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        txtIPAddress = New TextBox()
        Label2 = New Label()
        txtPort = New TextBox()
        btnSendLights = New Button()
        Label3 = New Label()
        txtCustomMessage = New TextBox()
        btnSendCustom = New Button()
        lblStatus = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(122, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 15)
        Label1.TabIndex = 0
        Label1.Text = "IP Address"
        ' 
        ' txtIPAddress
        ' 
        txtIPAddress.Location = New Point(214, 47)
        txtIPAddress.Name = "txtIPAddress"
        txtIPAddress.Size = New Size(100, 23)
        txtIPAddress.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(122, 92)
        Label2.Name = "Label2"
        Label2.Size = New Size(29, 15)
        Label2.TabIndex = 2
        Label2.Text = "Port"
        ' 
        ' txtPort
        ' 
        txtPort.Location = New Point(214, 89)
        txtPort.Name = "txtPort"
        txtPort.Size = New Size(100, 23)
        txtPort.TabIndex = 3
        ' 
        ' btnSendLights
        ' 
        btnSendLights.Location = New Point(214, 175)
        btnSendLights.Name = "btnSendLights"
        btnSendLights.Size = New Size(75, 23)
        btnSendLights.TabIndex = 4
        btnSendLights.Text = "Turn Lights On"
        btnSendLights.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(122, 227)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 15)
        Label3.TabIndex = 5
        Label3.Text = "Custom Message"
        ' 
        ' txtCustomMessage
        ' 
        txtCustomMessage.Location = New Point(250, 224)
        txtCustomMessage.Name = "txtCustomMessage"
        txtCustomMessage.Size = New Size(100, 23)
        txtCustomMessage.TabIndex = 6
        ' 
        ' btnSendCustom
        ' 
        btnSendCustom.Location = New Point(214, 283)
        btnSendCustom.Name = "btnSendCustom"
        btnSendCustom.Size = New Size(75, 23)
        btnSendCustom.TabIndex = 7
        btnSendCustom.Text = "Send Custom Message"
        btnSendCustom.UseVisualStyleBackColor = True
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Location = New Point(122, 344)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(39, 15)
        lblStatus.TabIndex = 8
        lblStatus.Text = "Ready"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblStatus)
        Controls.Add(btnSendCustom)
        Controls.Add(txtCustomMessage)
        Controls.Add(Label3)
        Controls.Add(btnSendLights)
        Controls.Add(txtPort)
        Controls.Add(Label2)
        Controls.Add(txtIPAddress)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtIPAddress As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPort As TextBox
    Friend WithEvents btnSendLights As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCustomMessage As TextBox
    Friend WithEvents btnSendCustom As Button
    Friend WithEvents lblStatus As Label

End Class
