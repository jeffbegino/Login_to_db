Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Customers
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
        Form2.Show()
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
            Dim myquery As String
            myquery = "select * from edp.customer"
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
        ' Display the FolderBrowserDialog to choose a folder for saving the file
        With FolderBrowserDialog1
            .SelectedPath = "C:\"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                ' Get the selected folder path
                Dim folderPath As String = .SelectedPath

                ' Get the DataGridView data source
                Dim dataSource As DataTable = TryCast(DataGridViewCustomer.DataSource, BindingSource)?.DataSource

                ' Check if the data source is not null and has rows
                If dataSource IsNot Nothing AndAlso dataSource.Rows.Count > 0 Then
                    ' Generate the CSV file path
                    Dim filePath As String = Path.Combine(folderPath, "customer.csv")

                    ' Write the data to the CSV file
                    Using writer As New StreamWriter(filePath)
                        ' Write the header row
                        Dim headerRow As String = String.Join(",", dataSource.Columns.Cast(Of DataColumn).Select(Function(col) col.ColumnName))
                        writer.WriteLine(headerRow)

                        ' Write the data rows
                        For Each row As DataRow In dataSource.Rows
                            Dim dataRow As String = String.Join(",", row.ItemArray.Select(Function(value) value.ToString()))
                            writer.WriteLine(dataRow)
                        Next
                    End Using

                    ' Show success message
                    MsgBox("File saved to " + filePath)
                Else
                    ' Show error message
                    MsgBox("No data to save.")
                End If
            End If
        End With
    End Sub


    Private Sub Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class