Public Class Login

    Dim password As String
    Dim username As String
    Public Shared pass As Boolean = False
    Public Shared user As Boolean = True
    Dim userstatus As String
    Sub verifypassword()
        strsql = "select Password from Login where Username ='" & txtUsername.Text & "'"
        Dim acscmd As New OleDb.OleDbCommand
        acscmd.CommandText = strsql
        acscmd.Connection = acsconn
        acsda.SelectCommand = acscmd
        acsdr = acscmd.ExecuteReader

        While (acsdr.Read())
            password = acsdr("Password")
        End While

        If txtPassword.Text = password Then
            pass = True
        End If
        acscmd.Dispose()
        acsdr.Close()
    End Sub
    Sub verifyusername()
        strsql = "select Username from Login where Username ='" & txtUsername.Text & "'"
        Dim acscmd As New OleDb.OleDbCommand
        acscmd.CommandText = strsql
        acscmd.Connection = acsconn
        acsda.SelectCommand = acscmd
        acsdr = acscmd.ExecuteReader

        While (acsdr.Read())
            username = acsdr("Username")
        End While

        If txtUsername.Text = username Then
            user = True
        End If
        acscmd.Dispose()
        acsdr.Close()
    End Sub
    Sub identifystatus()
        strsql = "select sPosition from Login where Username ='" & txtUsername.Text & "'"
        Dim acscmd As New OleDb.OleDbCommand
        acscmd.CommandText = strsql
        acscmd.Connection = acsconn
        acsda.SelectCommand = acscmd
        acsdr = acscmd.ExecuteReader

        While (acsdr.Read())
            userstatus = acsdr("sPosition")
        End While

        acscmd.Dispose()
        acsdr.Close()
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pass = False
        user = False
        Module1.Connect()
       

    End Sub

        Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If txtUsername.Text <> "" Then
            verifyusername()
            If user = True Then
                If txtPassword.Text <> "" Then
                    verifypassword()
                    If pass = True Then
                        identifystatus()
                        If userstatus = "staff" Then
                            MainMenu.Button3.Hide()
                            MainMenu.Button4.Hide()
                            Me.Hide()
                            MessageBox.Show("Access granted. Welcome to ABC Management System.", "WELCOME", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            MainMenu.Show()
                        Else
                            Me.Hide()
                            MessageBox.Show("Access granted. Welcome to ABC Management System.", "WELCOME", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            MainMenu.Show()
                        End If

                    Else
                        MessageBox.Show("Access denied! Incorrect username/password.", "Login fail", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        txtUsername.Focus()
                    End If
                Else
                    MessageBox.Show("Please type your password.", "Login fail", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Access denied! Incorrect username/password.", "Login fail", MessageBoxButtons.OK, MessageBoxIcon.Error)

                txtUsername.Focus()
            End If
        Else
            MessageBox.Show("Please type your username.", "Login fail", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

        Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
            Dim result As DialogResult
            result = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = Windows.Forms.DialogResult.Yes Then
                Me.Close()
            Else
                txtUsername.Focus()
            End If
        End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
