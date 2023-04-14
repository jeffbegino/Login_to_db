Imports MySql.Data.MySqlClient

Public Class Delete
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxDelete.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call Connect_to_DB()
        Dim myadapter As New MySqlDataAdapter
        Dim mycmd As MySqlCommand
        Dim mytable As New DataTable
        Dim mygrid As New BindingSource
        Try
            Dim myquery As String
            myquery = "DELETE FROM edp.customer WHERE User_Id = @User_Id"
            mycmd = New MySqlCommand(myquery, myconn)
            mycmd.Parameters.AddWithValue("@User_Id", TextBoxDelete.Text)
            mycmd.ExecuteNonQuery()
            MessageBox.Show("Data deleted successfully.")

            myconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            myconn.Dispose()
        End Try
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Customers.Show()
        Close()
    End Sub

    Private Sub Delete_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class