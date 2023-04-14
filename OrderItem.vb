Imports System.IO
Imports MySql.Data.MySqlClient

Public Class OrderItem
    Dim mycmd As MySqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
        HomepageForm.Show()
    End Sub

    Public Sub DataGridViewOrderItem_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewOrderItem.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call Connect_to_DB()
        Dim myadapter As New MySqlDataAdapter
        Dim mytable As New DataTable
        Dim mygrid As New BindingSource
        Try
            Dim myquery As String
            myquery = "select * from edp.ordersitem"
            mycmd = New MySqlCommand(myquery, myconn)
            myadapter.SelectCommand = mycmd
            myadapter.Fill(mytable)
            mygrid.DataSource = mytable
            DataGridViewOrderItem.DataSource = mygrid
            myadapter.Update(mytable)

            myconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            myconn.Dispose()
        End Try
    End Sub

    Private Sub OrderItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Call ExportToExcel(Me.DataGridViewOrderItem, "OrderItemDataset.xlsx")
    End Sub
End Class