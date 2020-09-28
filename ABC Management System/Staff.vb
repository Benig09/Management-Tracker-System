Public Class Staff

    Dim tempid As Integer
        Dim firststatus As Boolean = False
        Dim laststattus As Boolean = False
        Dim icstatus As Boolean = False
        Dim positionstatus As Boolean = False
        Dim departmentstatus As Boolean = False
        Sub generateid()

            strsql = "select Top 1 StaffID from Staff order by StaffID desc"

            Dim acscmd As New OleDb.OleDbCommand
            acscmd.CommandText = strsql
            acscmd.Connection = acsconn
            acsda.SelectCommand = acscmd
            acsdr = acscmd.ExecuteReader


            If (acsdr.Read()) Then
                tempid = acsdr("StaffID") + 1
            End If

            acscmd.Dispose()
            acsdr.Close()

            txtid.Text = tempid
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

        Sub filllistview()

            strsql = "select * from Staff order by StaffID"
            Dim acscmd As New OleDb.OleDbCommand
            acscmd.CommandText = strsql
            acscmd.Connection = acsconn
            acsda.SelectCommand = acscmd
            acsdr = acscmd.ExecuteReader

            lvStaff.Items.Clear()

            While (acsdr.Read())
                With lvStaff.Items.Add(acsdr("StaffID"))
                    .subitems.add(acsdr("FirstName"))
                    .subitems.add(acsdr("LastName"))
                    .subitems.add(acsdr("IC"))
                    .subitems.add(acsdr("ContactNumber"))
                    .subitems.add(acsdr("Position"))
                    .subitems.add(acsdr("Department"))
                    .subitems.add(acsdr("Address"))
                    .subitems.add(acsdr("Email"))
                    .subitems.add(acsdr("City"))
                    .subitems.add(acsdr("Poscode"))
                    .subitems.add(acsdr("State"))
                    .subitems.add(acsdr("StaffPic"))
                End With
            End While

            acscmd.Dispose()
            acsdr.Close()
        End Sub
        Sub searchfirstname(ByVal searchword As String)
            strsql = "select * from Staff where FirstName like '%" & searchword & "%'"
            Dim acscmd As New OleDb.OleDbCommand
            acscmd.CommandText = strsql
            acscmd.Connection = acsconn
            acsdr = acscmd.ExecuteReader

            lvStaff.Items.Clear()

            While (acsdr.Read())
                With lvStaff.Items.Add(acsdr("StaffID"))
                    .subitems.add(acsdr("FirstName"))
                    .subitems.add(acsdr("LastName"))
                    .subitems.add(acsdr("IC"))
                    .subitems.add(acsdr("Position"))
                    .subitems.add(acsdr("Department"))
                    .subitems.add(acsdr("ContactNumber"))
                    .subitems.add(acsdr("Address"))
                    .subitems.add(acsdr("Email"))
                    .subitems.add(acsdr("City"))
                    .subitems.add(acsdr("Poscode"))
                    .subitems.add(acsdr("State"))
                    .subitems.add(acsdr("StaffPic"))
                End With
            End While

            acscmd.Dispose()
            acsdr.Close()
        End Sub
        Sub searchic(ByVal searchword As String)
            strsql = "select * from Staff where IC like '%" & searchword & "%'"
            Dim acscmd As New OleDb.OleDbCommand
            acscmd.CommandText = strsql
            acscmd.Connection = acsconn
            acsdr = acscmd.ExecuteReader

            lvStaff.Items.Clear()

            While (acsdr.Read())
                With lvStaff.Items.Add(acsdr("StaffID"))
                    .subitems.add(acsdr("FirstName"))
                    .subitems.add(acsdr("LastName"))
                    .subitems.add(acsdr("IC"))
                    .subitems.add(acsdr("Position"))
                    .subitems.add(acsdr("Department"))
                    .subitems.add(acsdr("ContactNumber"))
                    .subitems.add(acsdr("Address"))
                    .subitems.add(acsdr("Email"))
                    .subitems.add(acsdr("City"))
                    .subitems.add(acsdr("Poscode"))
                    .subitems.add(acsdr("State"))
                    .subitems.add(acsdr("StaffPic"))
                End With
            End While

            acscmd.Dispose()
            acsdr.Close()
        End Sub

        Sub searchdepartment(ByVal searchword As String)
            strsql = "select * from Staff where Department like '%" & searchword & "%'"
            Dim acscmd As New OleDb.OleDbCommand
            acscmd.CommandText = strsql
            acscmd.Connection = acsconn
            acsdr = acscmd.ExecuteReader

            lvStaff.Items.Clear()

            While (acsdr.Read())
                With lvStaff.Items.Add(acsdr("StaffID"))
                    .subitems.add(acsdr("FirstName"))
                    .subitems.add(acsdr("LastName"))
                    .subitems.add(acsdr("IC"))
                    .subitems.add(acsdr("Position"))
                    .subitems.add(acsdr("Department"))
                    .subitems.add(acsdr("ContactNumber"))
                    .subitems.add(acsdr("Address"))
                    .subitems.add(acsdr("Email"))
                    .subitems.add(acsdr("City"))
                    .subitems.add(acsdr("Poscode"))
                    .subitems.add(acsdr("State"))
                    .subitems.add(acsdr("StaffPic"))

                End With
            End While

            acscmd.Dispose()
            acsdr.Close()
        End Sub
        Sub saverecord()
            Dim result As DialogResult
            result = MessageBox.Show("Do You Want to Save?", "Save", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = Windows.Forms.DialogResult.OK Then
                strsql = "INSERT INTO Staff ([FirstName], [LastName], [IC], [ContactNumber], [Address], [Email], [City], [Poscode], [State], [Position], [Department], StaffPic) values ('" _
                & txtfirst.Text & "', '" _
                & txtlast.Text & "', '" _
                & txtic.Text & "', '" _
                & txtnumber.Text & "', '" _
                & txtaddress.Text & "', '" _
                & txtemail.Text & "', '" _
                & txtcity.Text & "', '" _
                & txtposcode.Text & "', '" _
                & txtstate.Text & "', '" _
                & cbposition.Text & "', '" _
                & cbdepartment.Text & "', '" _
                & txtpath.Text & "')"
                Dim acscmd As New OleDb.OleDbCommand
                acscmd.CommandText = strsql
                acscmd.Connection = acsconn
                acscmd.ExecuteNonQuery()
                acscmd.Dispose()

                MsgBox("Added to System")
            End If
        End Sub
        Sub deleterecord()
            Dim result As DialogResult
            result = MessageBox.Show("Do You Want to Delete?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = Windows.Forms.DialogResult.OK Then
                strsql = "delete * from Staff where StaffID = " & txtid.Text

                Dim acscmd As New OleDb.OleDbCommand
                acscmd.CommandText = strsql
                acscmd.Connection = acsconn
                acscmd.ExecuteNonQuery()
                acscmd.Dispose()

                MsgBox("Removed From System")
            End If
        End Sub
        Sub updaterecord()
            Dim result As DialogResult
            result = MessageBox.Show("Do You Want to Edit?", "Edit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = Windows.Forms.DialogResult.OK Then
                strsql = "update Staff set [FirstName] ='" & txtfirst.Text & "'," _
                & "[LastName] ='" & txtlast.Text & "'," _
                & "[IC] ='" & txtic.Text & "'," _
                & "[ContactNumber] ='" & txtnumber.Text & "'," _
                & "[Position] ='" & cbposition.Text & "'," _
                & "[Department] ='" & cbdepartment.Text & "'," _
                & "[Address] ='" & txtaddress.Text & "'," _
                & "[Email] ='" & txtemail.Text & "'," _
                & "[City] ='" & txtic.Text & "'," _
                & "[Poscode] ='" & txtposcode.Text & "'," _
                & "[State] ='" & txtstate.Text & "'," _
                & "[StaffPic]='" & txtpath.Text & "'" _
                & "where [StaffID] = " & txtid.Text

                Dim acscmd As New OleDb.OleDbCommand
                acscmd.CommandText = strsql
                acscmd.Connection = acsconn
                acscmd.ExecuteNonQuery()
                acscmd.Dispose()

                MsgBox("System Updated")
            End If
        End Sub
        Sub firsterror()
            If txtfirst.Text = "" Then
                ErrorProvider1.SetError(txtfirst, "Cannot leave textbox blank")
                MsgBox("Must Fill In The First Name")
            ElseIf IsNumeric(txtfirst.Text) Then
                MsgBox("First Name Must be in Alphabet")
            Else
                ErrorProvider1.Clear()
                firststatus = True
            End If
        End Sub
        Sub lasterror()
            If txtlast.Text = "" Then
                ErrorProvider2.SetError(txtlast, "Cannot leave textbox blank")
                MsgBox("Must Fill In The Last Name")
            ElseIf IsNumeric(txtlast.Text) Then
                MsgBox("Last Name Must be in Alphabet")
            Else
                ErrorProvider2.Clear()
                laststattus = True
            End If
        End Sub
        Sub icerror()
            If txtic.Text = "" Then
                ErrorProvider3.SetError(txtic, "Cannot leave textbox blank")
                MsgBox("Must Fill In The IC Number")
            ElseIf Not IsNumeric(txtic.Text) Then
                ErrorProvider3.SetError(txtic, "Must be in Digits")
                MsgBox("IC Number Must be in Digits")
            Else
                ErrorProvider3.Clear()
                icstatus = True
            End If
        End Sub
        Sub positionerror()
            If cbposition.Text = "" Then
                ErrorProvider4.SetError(cbposition, "Cannot leave textbox blank")
                MsgBox("Must Select The Position")
            Else
                ErrorProvider4.Clear()
                positionstatus = True
            End If
        End Sub
        Sub departmenterror()
            If cbdepartment.Text = "" Then
                ErrorProvider4.SetError(cbdepartment, "Cannot leave textbox blank")
                MsgBox("Must Select The Department")
            Else
                ErrorProvider4.Clear()
                departmentstatus = True
            End If
        End Sub
        Sub disableallflag()
            firststatus = False
            laststattus = False
            icstatus = False
            positionstatus = False
            departmentstatus = False
        End Sub
        Private Sub Staffmanagement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        filllistview()

        generateid()
        btnEdit.Enabled = False
        btnDelete.Enabled = False


    End Sub

        Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
            If cbsearch.Text = "IC" Then
                searchic(txtsearch.Text)
            ElseIf cbsearch.Text = "Department" Then
                searchdepartment(txtsearch.Text)
            Else
                searchfirstname(txtsearch.Text)
            End If

        End Sub

        Private Sub btnbrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbrowse.Click
            Dim myfile As New OpenFileDialog

            myfile.InitialDirectory = "C:\System Pictures"
            myfile.Filter = "All Files|*.*|Bitmaps|*.bmp|GIFs|*.gif|JPEGs|*.jpg|PNGs|*.png"
            myfile.FilterIndex = 1
            If myfile.ShowDialog() = DialogResult.OK Then
                If Dir(myfile.FileName) <> "" Then
                    txtpath.Text = myfile.FileName
                    pbimage.ImageLocation = myfile.FileName
                Else
                    MsgBox("File Not Found", MsgBoxStyle.Critical)
                End If
            End If
        End Sub

        Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
            firsterror()
            lasterror()
            icerror()
            positionerror()
            departmenterror()
            If firststatus = True And laststattus = True And icstatus = True And positionstatus = True And departmentstatus = True Then
                saverecord()
                ClearTextFields(Me)
                filllistview()
                generateid()
                disableallflag()
                pbimage.Image = Nothing
            End If


        End Sub

        Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
            firsterror()
            lasterror()
            icerror()
            positionerror()
            departmenterror()
            If firststatus = True And laststattus = True And icstatus = True And positionstatus = True And departmentstatus = True Then
                updaterecord()
                ClearTextFields(Me)
                filllistview()
                generateid()
                btnEdit.Enabled = False
                btnDelete.Enabled = False
                disableallflag()
                pbimage.Image = Nothing
            End If
            btnAdd.Enabled = True

        End Sub

        Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
            deleterecord()
            ClearTextFields(Me)
            filllistview()
            generateid()
            btnEdit.Enabled = False
            btnDelete.Enabled = False
            pbimage.Image = Nothing
            btnAdd.Enabled = True
        End Sub

        Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
            ClearTextFields(Me)
            generateid()
            filllistview()
            btnAdd.Enabled = True
            btnEdit.Enabled = False
            btnDelete.Enabled = False
            pbimage.Image = Nothing
        End Sub

        Private Sub lvStaff_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvStaff.MouseDoubleClick
            btnAdd.Enabled = False
            btnEdit.Enabled = True
            btnDelete.Enabled = True
            With lvStaff.SelectedItems(0)
                txtid.Text = .SubItems(0).Text
                txtfirst.Text = .SubItems(1).Text
                txtlast.Text = .SubItems(2).Text
                txtic.Text = .SubItems(3).Text
                txtnumber.Text = .SubItems(4).Text
                cbposition.Text = .SubItems(5).Text
                cbdepartment.Text = .SubItems(6).Text
                txtaddress.Text = .SubItems(7).Text
                txtemail.Text = .SubItems(8).Text
                txtcity.Text = .SubItems(9).Text
                txtposcode.Text = .SubItems(10).Text
                txtstate.Text = .SubItems(11).Text
                txtpath.Text = .SubItems(12).Text
            End With

            pbimage.ImageLocation = txtpath.Text

        End Sub

        Private Sub cbsearch_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbsearch.SelectedIndexChanged
            ClearTextFields(Me)
            generateid()
        End Sub

        Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
            Dim result As DialogResult
            result = MessageBox.Show("Do You Want to Back to Main Menu?", "Back", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = Windows.Forms.DialogResult.OK Then
            MainMenu.Show()
            Me.Hide()
            End If
        End Sub

        Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
            Dim result As DialogResult
            result = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = Windows.Forms.DialogResult.Yes Then
                Me.Close()
            End If
        End Sub


End Class
