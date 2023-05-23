Imports MySql.Data.MySqlClient
Public Class Update_Supplier
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call Connect_to_DB()
        Dim myadapter As New MySqlDataAdapter
        Dim mycmd As MySqlCommand
        Dim mytable As New DataTable
        Dim mygrid As New BindingSource
        Try
            Dim myquery As String
            myquery = "UPDATE edp.customer SET CompanyName = @FirstName, ContactName = @LastName, ContactTitle = @City, City = @Country, Country = @Phone, Phone = @Textbox2, Fax = @Textbox1 WHERE Supplier_Id = @User_Id"
            mycmd = New MySqlCommand(myquery, myconn)
            mycmd.Parameters.AddWithValue("@User_Id", TextBoxUser_ID.Text)
            mycmd.Parameters.AddWithValue("@FirstName", TextBoxFirstName.Text)
            mycmd.Parameters.AddWithValue("@LastName", TextBoxLastName.Text)
            mycmd.Parameters.AddWithValue("@City", TextBoxCity.Text)
            mycmd.Parameters.AddWithValue("@Country", TextBoxCountry.Text)
            mycmd.Parameters.AddWithValue("@Phone", TextBoxPhone.Text)
            mycmd.Parameters.AddWithValue("@Textbox2", TextBox2.Text)
            mycmd.Parameters.AddWithValue("@Textbox1", TextBox1.Text)
            mycmd.ExecuteNonQuery()
            MessageBox.Show("Data inserted successfully.")

            myconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            myconn.Dispose()
        End Try
    End Sub
End Class