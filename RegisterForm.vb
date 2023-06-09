﻿Imports MySql.Data.MySqlClient
Public Class RegisterForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call Connect_to_DB()
        Dim myadapter As New MySqlDataAdapter
        Dim mycmd As MySqlCommand
        Dim mytable As New DataTable
        Dim mygrid As New BindingSource
        Try
            Dim myquery As String
            myquery = "INSERT INTO edp.users (username, password, FirstName, MiddleName, LastName) values (@User_Id, @FirstName, @LastName, @City, @Country)"
            mycmd = New MySqlCommand(myquery, myconn)
            mycmd.Parameters.AddWithValue("@User_Id", TextBoxUser_ID.Text)
            mycmd.Parameters.AddWithValue("@FirstName", TextBoxFirstName.Text)
            mycmd.Parameters.AddWithValue("@LastName", TextBoxLastName.Text)
            mycmd.Parameters.AddWithValue("@City", TextBoxCity.Text)
            mycmd.Parameters.AddWithValue("@Country", TextBoxCountry.Text)
            mycmd.ExecuteNonQuery()
            MessageBox.Show("Account created successfully.")

            Close()
            LoginForm.Show()
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            myconn.Dispose()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Close()
        LoginForm.Show()
    End Sub

    Private Sub Insert_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class