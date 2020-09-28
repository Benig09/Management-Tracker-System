Public Class UserRegisteration

    Dim existusername As Boolean
    Dim pass As Boolean


    Sub checkusername()
            Dim getname As String = ""
            
            strsql = "select Username from Login where Username ='" & txtUsername.Text & "'"
            Dim acscmd As New OleDb.OleDbCommand
            acscmd.CommandText = strsql
            acscmd.Connection = acsconn
            acsda.SelectCommand = acscmd
            acsdr = acscmd.ExecuteReader

            While (acsdr.Read())
                getname = acsdr("Username")
            End While
            If txtUsername.Text = getname Then
                existusername = True
                epUsername.SetError(txtUsername, "Username already in use.")
            Else
                existusername = False
            End If

        End Sub
        Sub registeraccount()
        strsql = "INSERT INTO Login ([Username], [Password], [sPosition]) values ('" _
                       & txtUsername.Text & "', '" _
                       & txtPassword.Text & "', '" _
                       & cbStatus.Text & "')"
        Dim acscmd As New OleDb.OleDbCommand
            acscmd.CommandText = strsql
            acscmd.Connection = acsconn
            acscmd.ExecuteNonQuery()
            acscmd.Dispose()
            MessageBox.Show("Account Saved", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtConfirm.Text = ""
        txtUsername.Text = ""
            txtPassword.Text = ""
            cbStatus.Text = ""
        End Sub

    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        If txtUsername.Text <> "" Then
            If txtPassword.Text <> "" Then
                If txtConfirm.Text <> "" Then
                    If cbStatus.Text <> "" Then
                        checkusername()
                        If existusername = False Then
                            If txtPassword.Text = txtConfirm.Text Then
                                registeraccount()
                            Else
                                MessageBox.Show("Password is not same with Confirm Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                txtConfirm.Text = ""
                                txtPassword.Text = ""
                                txtPassword.Focus()

                            End If



                        End If
                    Else MessageBox.Show("Please choose your position.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        cbStatus.Focus()
                    End If
                Else
                        MessageBox.Show("Please confirm your password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtConfirm.Focus()
                End If
            Else
                    MessageBox.Show("Please type your password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtPassword.Focus()
            End If
        Else
            MessageBox.Show("Please type your username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtUsername.Focus()
        End If


    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
            Dim result As DialogResult
            result = MessageBox.Show("Do You Want to Back to Main Menu?", "Back", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = Windows.Forms.DialogResult.OK Then
            MainMenu.Show()
            Me.Close()
            End If
        End Sub

    Private Sub UserRegisteration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Module1.Connect()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result As DialogResult
        result = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class