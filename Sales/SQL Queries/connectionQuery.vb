Imports MySql.Data.MySqlClient

Module connectionQuery

    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public dr As MySqlDataReader
    Public result As Integer
    Public sql As String
    Public dt As DataTable
    Public dt2 As DataTable
    Public numAllowed As String = "1234567890."
    Public checkQuantity As Integer = 0

    Public Sub dbConnection()
        Try
            conn = New MySqlConnection
            conn.ConnectionString = "server=localhost; userid=root; password=; database=rusi; Convert Zero Datetime=True;"
            conn.Open()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

End Module
