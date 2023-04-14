Imports MySql.Data.MySqlClient

Public Class Insert

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call Connect_to_DB()
        Dim myadapter As New MySqlDataAdapter
        Dim mycmd As MySqlCommand
        Dim mytable As New DataTable
        Dim mygrid As New BindingSource
        Try
            Dim myquery As String
            myquery = "INSERT INTO edp.customer (User_Id, FirstName, LastName, City, Country, Phone) values (@User_Id, @FirstName, @LastName, @City, @Country, @Phone)"
            mycmd = New MySqlCommand(myquery, myconn)
            mycmd.Parameters.AddWithValue("@User_Id", TextBoxUser_ID.Text)
            mycmd.Parameters.AddWithValue("@FirstName", TextBoxFirstName.Text)
            mycmd.Parameters.AddWithValue("@LastName", TextBoxLastName.Text)
            mycmd.Parameters.AddWithValue("@City", TextBoxCity.Text)
            mycmd.Parameters.AddWithValue("@Country", TextBoxCountry.Text)
            mycmd.Parameters.AddWithValue("@Phone", TextBoxPhone.Text)
            mycmd.ExecuteNonQuery()
            MessageBox.Show("Data inserted successfully.")

            myconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            myconn.Dispose()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Customers.Show()
        Close()
    End Sub

    Private Sub Insert_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class