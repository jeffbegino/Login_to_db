Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub ButtonExit_Click_1(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Application.Exit()
    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        If (TextBoxUsername.Text = "") Then
            MsgBox("Enter Username")
            Exit Sub
        End If
        If (TextBoxPassword.Text = "") Then
            MsgBox("Enter Password")
            Exit Sub
        End If
        With Me
            Call Connect_to_DB()
            Dim mycomm As New MySqlCommand
            Dim myreader As MySqlDataReader

            Dim mysql As String
            mysql = "select * from users where username='" & TextBoxUsername.Text & "' and password='" & TextBoxPassword.Text & "'"

            mycomm.Connection = myconn
            mycomm.CommandText = mysql

            myreader = mycomm.ExecuteReader
            If myreader.HasRows Then
                .Hide()
                Form2.Show()
                myconn.Close()
            Else
                MessageBox.Show("Invalid username or password!")
                myconn.Close()
            End If
        End With
    End Sub

    Private Sub TextBoxPassword_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPassword.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBoxUsername_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUsername.TextChanged

    End Sub
End Class
