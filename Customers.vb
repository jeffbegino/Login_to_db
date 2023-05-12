Imports System.Data.Common
Imports Excel = Microsoft.Office.Interop.Excel
Imports MySql.Data.MySqlClient

Public Class Customers
    Private myquery As String = "select * from edp.customer"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
        HomepageForm.Show()
    End Sub

    Private Sub DataGridViewCustomer_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewCustomer.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call Connect_to_DB()
        Dim myadapter As New MySqlDataAdapter
        Dim mycmd As MySqlCommand
        Dim mytable As New DataTable
        Dim mygrid As New BindingSource
        Try
            mycmd = New MySqlCommand(myquery, myconn)
            myadapter.SelectCommand = mycmd
            myadapter.Fill(mytable)
            mygrid.DataSource = mytable
            DataGridViewCustomer.DataSource = mygrid
            myadapter.Update(mytable)

            myconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            myconn.Dispose()
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Close()
        Insert.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
        Delete.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
        Update_Table.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Call ExportToExcel(Me.DataGridViewCustomer, "CustomerDataset.xlsx")
    End Sub


    Private Sub Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class