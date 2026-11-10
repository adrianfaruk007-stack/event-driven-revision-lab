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
        btnLogin = New Button()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        btnTest = New Button()
        lblStatus = New Label()
        btnRemove = New Button()
        SuspendLayout()
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(207, 266)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(125, 29)
        btnLogin.TabIndex = 0
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(207, 71)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(125, 27)
        txtUsername.TabIndex = 1
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(207, 146)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(125, 27)
        txtPassword.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(59, 75)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 20)
        Label1.TabIndex = 3
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(59, 153)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 20)
        Label2.TabIndex = 4
        Label2.Text = "Password"
        ' 
        ' btnTest
        ' 
        btnTest.Location = New Point(226, 408)
        btnTest.Name = "btnTest"
        btnTest.Size = New Size(94, 29)
        btnTest.TabIndex = 5
        btnTest.Text = "Test"
        btnTest.UseVisualStyleBackColor = True
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Location = New Point(80, 408)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(60, 20)
        lblStatus.TabIndex = 6
        lblStatus.Text = "Waiting"
        ' 
        ' btnRemove
        ' 
        btnRemove.Location = New Point(226, 486)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(94, 29)
        btnRemove.TabIndex = 7
        btnRemove.Text = "Remove"
        btnRemove.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 766)
        Controls.Add(btnRemove)
        Controls.Add(lblStatus)
        Controls.Add(btnTest)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(btnLogin)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnTest As Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnRemove As Button

End Class
