Public Class Tracker

    Public tempid As Integer


    Sub searchrecord(ByVal searchword As String)
        strsql = "select * from MTracker where SiteLRD like '" & searchword & "%'"
        Dim acscmd As New OleDb.OleDbCommand
        acscmd.CommandText = strsql
        acscmd.Connection = acsconn
        acsdr = acscmd.ExecuteReader

        ListView1.Items.Clear()

        While (acsdr.Read())
            With ListView1.Items.Add(acsdr("Number"))
                .subitems.add(acsdr("SiteLRD"))
                .subitems.add(acsdr("CADate"))
                .subitems.add(acsdr("Region"))
                .subitems.add(acsdr("JobType"))
                .subitems.add(acsdr("SOW"))
                .subitems.add(acsdr("Telco"))
                .subitems.add(acsdr("Client"))
                .subitems.add(acsdr("Status"))

            End With
        End While

        acscmd.Dispose()
        acsdr.Close()
    End Sub
    Sub searchbatch(ByVal searchword As String)
        strsql = "select * from MTracker where Telco like '" & searchword & "%'"
        Dim acscmd As New OleDb.OleDbCommand
        acscmd.CommandText = strsql
        acscmd.Connection = acsconn
        acsdr = acscmd.ExecuteReader

        ListView1.Items.Clear()

        While (acsdr.Read())
            With ListView1.Items.Add(acsdr("Number"))
                .subitems.add(acsdr("SiteLRD"))
                .subitems.add(acsdr("CADate"))
                .subitems.add(acsdr("Region"))
                .subitems.add(acsdr("JobType"))
                .subitems.add(acsdr("SOW"))
                .subitems.add(acsdr("Telco"))
                .subitems.add(acsdr("Client"))
                .subitems.add(acsdr("Status"))


            End With
        End While

        acscmd.Dispose()
        acsdr.Close()
    End Sub
    Sub searchregion(ByVal searchword As String)
        strsql = "select * from MTracker where Region like '" & searchword & "%'"
        Dim acscmd As New OleDb.OleDbCommand
        acscmd.CommandText = strsql
        acscmd.Connection = acsconn
        acsdr = acscmd.ExecuteReader

        ListView1.Items.Clear()

        While (acsdr.Read())
            With ListView1.Items.Add(acsdr("Number"))
                .subitems.add(acsdr("SiteLRD"))
                .subitems.add(acsdr("CADate"))
                .subitems.add(acsdr("Region"))
                .subitems.add(acsdr("JobType"))
                .subitems.add(acsdr("SOW"))
                .subitems.add(acsdr("Telco"))
                .subitems.add(acsdr("Client"))
                .subitems.add(acsdr("Status"))


            End With
        End While

        acscmd.Dispose()
        acsdr.Close()
    End Sub

    Private Sub ListView1_MouseDoubleClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseDoubleClick

        With ListView1.SelectedItems(0)
            TextBox5.Text = .SubItems(0).Text
            TextBox3.Text = .SubItems(1).Text
            DateTimePicker1.Text = .SubItems(2).Text
            ComboBox6.Text = .SubItems(3).Text
            ComboBox3.Text = .SubItems(4).Text
            TextBox4.Text = .SubItems(5).Text
            ComboBox4.Text = .SubItems(6).Text
            ComboBox5.Text = .SubItems(7).Text
            ComboBox1.Text = .SubItems(8).Text


        End With
        Button3.Enabled = True
        Button4.Enabled = True
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

        If ComboBox2.Text = "SiteLRD" Then
            searchrecord(TextBox1.Text)
        ElseIf ComboBox2.Text = "Telco" Then
            searchbatch(TextBox1.Text)
        ElseIf ComboBox2.Text = "Region" Then
            searchregion(TextBox1.Text)
        ElseIf ComboBox2.Text = "SOW" Then
            search(TextBox1.Text)
        Else : searchstatus(TextBox1.Text)
        End If
    End Sub


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        generateid()
        filllistview()
        TextBox5.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
    End Sub
    Sub filllistview()
        strsql = "select * from MTracker order by Number"
        Dim acscmd As New OleDb.OleDbCommand
        acscmd.CommandText = strsql
        acscmd.Connection = acsconn
        acsdr = acscmd.ExecuteReader

        ListView1.Items.Clear()

        While (acsdr.Read())
            With ListView1.Items.Add(acsdr("Number"))
                .subitems.add(acsdr("SiteLRD"))
                .subitems.add(acsdr("CADate"))
                .subitems.add(acsdr("Region"))
                .subitems.add(acsdr("JobType"))
                .subitems.add(acsdr("SOW"))
                .subitems.add(acsdr("Telco"))
                .subitems.add(acsdr("Client"))
                .subitems.add(acsdr("Status"))




            End With
        End While

        acscmd.Dispose()
        acsdr.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        AddJob.Show()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim result As DialogResult
        result = MessageBox.Show("Do You Want to Delete?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.OK Then
            strsql = "delete * from MTracker where Number = " & TextBox5.Text

            Dim acscmd As New OleDb.OleDbCommand
            acscmd.CommandText = strsql
            acscmd.Connection = acsconn
            acscmd.ExecuteNonQuery()
            acscmd.Dispose()

            MsgBox("Removed From System")
            Me.filllistview()
            ClearTextFields(Me)
            Button3.Enabled = False
            Button4.Enabled = False
        End If

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

        TextBox5.Text = tempid


    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim result As DialogResult
        result = MessageBox.Show("Do You Want to Edit?", "Edit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.OK Then
            strsql = "update MTracker set SiteLRD ='" & TextBox3.Text & "'," _
                & "CADate ='" & DateTimePicker1.Text & "'," _
                & "Region ='" & ComboBox6.Text & "'," _
                & "JobType ='" & ComboBox3.Text & "'," _
                & "SOW ='" & TextBox4.Text & "'," _
                & "Telco ='" & ComboBox4.Text & "'," _
                & "Client ='" & ComboBox5.Text & "'," _
                & "Status ='" & ComboBox1.Text & "'" _
                & "where Number = " & TextBox5.Text


            Dim acscmd As New OleDb.OleDbCommand
            acscmd.CommandText = strsql
            acscmd.Connection = acsconn
            acscmd.ExecuteNonQuery()
            acscmd.Dispose()

            MsgBox("System Updated")
            filllistview()
            ClearTextFields(Me)
            Button3.Enabled = False
            Button4.Enabled = False
        End If

    End Sub

    Sub search(ByVal searchword As String)
        strsql = "select * from MTracker where SOW like '" & searchword & "%'"
        Dim acscmd As New OleDb.OleDbCommand
        acscmd.CommandText = strsql
        acscmd.Connection = acsconn
        acsdr = acscmd.ExecuteReader

        ListView1.Items.Clear()

        While (acsdr.Read())
            With ListView1.Items.Add(acsdr("Number"))
                .subitems.add(acsdr("SiteLRD"))
                .subitems.add(acsdr("CADate"))
                .subitems.add(acsdr("Region"))
                .subitems.add(acsdr("JobType"))
                .subitems.add(acsdr("SOW"))
                .subitems.add(acsdr("Telco"))
                .subitems.add(acsdr("Client"))
                .subitems.add(acsdr("Status"))



            End With
        End While

        acscmd.Dispose()
        acsdr.Close()
    End Sub
    Sub searchstatus(ByVal searchword As String)
        strsql = "select * from MTracker where Status like '" & searchword & "%'"
        Dim acscmd As New OleDb.OleDbCommand
        acscmd.CommandText = strsql
        acscmd.Connection = acsconn
        acsdr = acscmd.ExecuteReader

        ListView1.Items.Clear()

        While (acsdr.Read())
            With ListView1.Items.Add(acsdr("Number"))
                .subitems.add(acsdr("SiteLRD"))
                .subitems.add(acsdr("CADate"))
                .subitems.add(acsdr("Region"))
                .subitems.add(acsdr("JobType"))
                .subitems.add(acsdr("SOW"))
                .subitems.add(acsdr("Telco"))
                .subitems.add(acsdr("Client"))
                .subitems.add(acsdr("Status"))


            End With
        End While

        acscmd.Dispose()
        acsdr.Close()
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
    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        filllistview()
        ClearTextFields(Me)
        Button3.Enabled = False
        Button4.Enabled = False

    End Sub


    Private Sub ComboBox2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        TextBox1.Focus()
        TextBox1.Text = ""
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim result As DialogResult
        result = MessageBox.Show("Do You Want to Back to Main Menu?", "Back", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.OK Then
            MainMenu.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result As DialogResult
        result = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub
End Class


