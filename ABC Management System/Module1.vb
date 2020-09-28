Imports System.Data.OleDb
Module Module1
    Public acsconn As New OleDbConnection
    Public acsdr As OleDbDataReader
    Public acsda As New OleDbDataAdapter
    Public strsql As String
    Sub Connect()
        acsconn.ConnectionString = "provider=microsoft.ace.oledb.12.0; Data Source =C:\Users\benig\Desktop\UCSI\May 2018 Semester\VB\vb assignment\ABC Management System\bin\Debug\Database6.accdb"
        acsconn.Open()
        If acsconn.State = ConnectionState.Open Then
            MsgBox("Connected")

        End If
    End Sub

End Module
