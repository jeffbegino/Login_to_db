Imports MySql.Data.MySqlClient
Public Class Insert_Supplier
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call Connect_to_DB()
        Dim myadapter As New MySqlDataAdapter
        Dim mycmd As MySqlCommand
        Dim mytable As New DataTable
        Dim mygrid As New BindingSource
        Try
            Dim myquery As String
            myquery = "INSERT INTO edp.supplier (Supplier_Id, CompanyName, ContactName, ContactTitle, City, Country, Phone, Fax) values (@User_Id, @CompanyName, @ContactName, @ContactTitle, @City, @Country, @Phone, @Fax)"
            mycmd = New MySqlCommand(myquery, myconn)
            mycmd.Parameters.AddWithValue("@User_Id", TextBoxUser_ID.Text)
            mycmd.Parameters.AddWithValue("@CompanyName", TextBoxFirstName.Text)
            mycmd.Parameters.AddWithValue("@ContactName", TextBoxLastName.Text)
            mycmd.Parameters.AddWithValue("@ContactTitle", TextBoxCity.Text)
            mycmd.Parameters.AddWithValue("@City", TextBoxCountry.Text)
            mycmd.Parameters.AddWithValue("@Country", TextBoxPhone.Text)
            mycmd.Parameters.AddWithValue("@Phone", TextBox2.Text)
            mycmd.Parameters.AddWithValue("@Fax", TextBox1.Text)
            mycmd.ExecuteNonQuery()
            MessageBox.Show("Data inserted successfully.")

            myconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            myconn.Dispose()
        End Try
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Supplier.Show()
        Close()
    End Sub
End Class