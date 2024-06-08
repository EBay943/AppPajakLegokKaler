Imports System.Data.OleDb
Module DBconnect
    Public Conn As OleDbConnection
    Public Da As OleDbDataAdapter
    Public Ds As DataSet
    Public Cmd As OleDbCommand
    Public Rd As OleDbDataReader
    Dim locationDB As String

    Public Sub Connection()
        locationDB = "Provider=Microsoft.ACE.OLEDB.12.0;data source =DataPajakPBBP2.accdb"
        Conn = New OleDbConnection(locationDB)

        If Conn.State = ConnectionState.Closed Then Conn.Open()

    End Sub
End Module
