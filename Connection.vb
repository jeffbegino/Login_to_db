Imports MySql.Data.MySqlClient
Module Connection
    Public myconn As New MySql.Data.MySqlClient.MySqlConnection
    Public myConnectionString As String

    Public Sub Connect_to_DB()
        myConnectionString = "server=127.0.0.1;" _
                    & "uid=root;" _
                    & "pwd=begino2002;" _
                    & "database=edp"

        Try
            myconn.ConnectionString = myConnectionString
            myconn.Open()
            'MessageBox.Show("Connection Success!")

        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module
