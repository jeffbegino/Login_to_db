Imports MySql.Data.MySqlClient

Public Class Product
    Dim mycmd As MySqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
        Form2.Show()
    End Sub

    Public Sub DataGridViewProduct_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewProduct.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call Connect_to_DB()
        Dim myadapter As New MySqlDataAdapter
        Dim mytable As New DataTable
        Dim mygrid As New BindingSource
        Try
            Dim myquery As String
            myquery = "select * from edp.product"
            mycmd = New MySqlCommand(myquery, myconn)
            myadapter.SelectCommand = mycmd
            myadapter.Fill(mytable)
            mygrid.DataSource = mytable
            DataGridViewProduct.DataSource = mygrid
            myadapter.Update(mytable)

            myconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            myconn.Dispose()
        End Try
    End Sub

    Private Sub Product_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class