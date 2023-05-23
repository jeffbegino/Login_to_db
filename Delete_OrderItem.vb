Imports MySql.Data.MySqlClient
Public Class Delete_OrderItem
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call Connect_to_DB()
        Dim myadapter As New MySqlDataAdapter
        Dim mycmd As MySqlCommand
        Dim mytable As New DataTable
        Dim mygrid As New BindingSource
        Try
            Dim myquery As String
            myquery = "DELETE FROM edp.ordersitem WHERE Items_Id = @User_Id"
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
        OrderItem.Show()
        Close()
    End Sub
End Class