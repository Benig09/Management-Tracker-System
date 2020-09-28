Public Class AddJob
    Dim result As DialogResult
    Dim LRD As Boolean = False
    Dim sregion As Boolean = False
    Dim jt As Boolean = False
    Dim telco As Boolean = False
    Dim sclient As Boolean = False
    Dim status As Boolean = False
    Dim SOW As Boolean = False
    Public tempid As Integer
    Sub disableflag()
        LRD = False
        sregion = False
        jt = False
        telco = False
        sclient = False
        status = False
        SOW = False
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        cLRD()
        cregion()
        cJT()
        cSOW()
        cTelco()
        cClient()
        cStatus()

        If LRD = True And sregion = True And jt = True And telco = True And sclient = True And status = True And SOW = True Then
            saveall()
            ClearTextFields(Me)
            generateid()
            disableflag()

        End If
    End Sub
    Sub saveall()
        Dim result As DialogResult
        result = MessageBox.Show("Do u want to add site??", "Add", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.OK Then
            strsql = "INSERT INTO MTracker ( [SiteLRD], [CADate], [Region], [JobType], [SOW] , [Telco] , [Client] , [Status]) values ('" _
    & TextBox1.Text & "','" _
    & DateTimePicker1.Text & "', '" _
    & ComboBox2.Text & "', '" _
    & ComboBox3.Text & "', '" _
    & TextBox2.Text & "', '" _
    & ComboBox4.Text & "', '" _
    & ComboBox5.Text & "', '" _
    & ComboBox1.Text & "')"



            Dim acscmd As New OleDb.OleDbCommand
            acscmd.CommandText = strsql
            acscmd.Connection = acsconn
            acscmd.ExecuteNonQuery()
            acscmd.Dispose()

            MsgBox("System Updated")

        End If
    End Sub

    Public Sub ClearTextFields(ByVal parent As Control)
        For Each ctl As Control In parent.Controls
            If TypeOf ctl Is TextBox Then
                If Text.Trim() <> String.Empty Then
                    ctl.Text = String.Empty
                End If
            End If
            If TypeOf ctl Is ComboBox Then
                If Text.Trim() <> String.Empty Then
                    ctl.Text = String.Empty
                End If
            End If
        Next
    End Sub
    Sub generateid()

        strsql = "select TOP 1 Number from MTracker order by Number desc"

        Dim acscmd As New OleDb.OleDbCommand
        acscmd.CommandText = strsql
        acscmd.Connection = acsconn
        acsdr = acscmd.ExecuteReader


        If (acsdr.Read()) Then
            tempid = acsdr("Number") + 1
        End If
        acscmd.Dispose()
        acsdr.Close()

        TextBox3.Text = tempid


    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox3.Enabled = False
        generateid()
    End Sub
    Sub cLRD()
        If TextBox1.Text = "" Then
            ErrorProvider1.SetError(TextBox1, "Cannot leave textbox blank")
            MsgBox("Must Fill In SiteLRD")
        ElseIf IsNumeric(TextBox1.Text) Then
            MsgBox("First Name Must be in Alphabet")
        Else
            ErrorProvider1.Clear()
            LRD = True
        End If
    End Sub
    Sub cregion()
        If ComboBox2.Text = "" Then
            ErrorProvider2.SetError(ComboBox2, "Cannot leave textbox blank")
            MsgBox("Must Fill In Region")

        Else
            ErrorProvider2.Clear()
            sregion = True
        End If
    End Sub
    Sub cJT()
        If ComboBox3.Text = "" Then
            ErrorProvider3.SetError(ComboBox3, "Cannot leave textbox blank")
            MsgBox("Must Fill In the Job Type")

        Else
            ErrorProvider3.Clear()
            jt = True
        End If
    End Sub
    Sub cTelco()
        If ComboBox4.Text = "" Then
            ErrorProvider4.SetError(ComboBox4, "Cannot leave textbox blank")
            MsgBox("Must Fill In The Telco Name")

        Else
            ErrorProvider4.Clear()
            telco = True
        End If
    End Sub
    Sub cClient()
        If ComboBox5.Text = "" Then
            ErrorProvider5.SetError(ComboBox5, "Connot leave textbox blank")
            MsgBox("Must Fill In Client Name")
        Else
            ErrorProvider5.Clear()
            sclient = True

        End If
    End Sub
    Sub cStatus()
        If ComboBox1.Text = "" Then
            ErrorProvider6.SetError(ComboBox1, "Cannot leave textbox blank")
            MsgBox("Must Fill in Site Status")
        Else
            ErrorProvider6.Clear()
            status = True

        End If
    End Sub
    Sub cSOW()
        If TextBox2.Text = "" Then
            ErrorProvider7.SetError(TextBox2, "Cannot leave textbox blank")
            MsgBox("Must Fill in Scope of Work")
        Else
            ErrorProvider7.Clear()
            SOW = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim result As DialogResult
        result = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim result As DialogResult
        result = MessageBox.Show("Do You Want to Back to Main Menu?", "Back", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.OK Then
            MainMenu.Show()
            Me.Hide()
        End If
    End Sub

End Class