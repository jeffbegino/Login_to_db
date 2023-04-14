Imports System.IO
Imports MySql.Data.MySqlClient

Public Class OrderItem
    Dim mycmd As MySqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
        Form2.Show()
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

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ' Display the FolderBrowserDialog to choose a folder for saving the file
        With FolderBrowserDialog1
            .SelectedPath = "C:\Python_Programs\Databases"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                ' Get the selected folder path
                Dim folderPath As String = .SelectedPath

                ' Get the DataGridView data source
                Dim dataSource As DataTable = TryCast(DataGridViewOrderItem.DataSource, BindingSource)?.DataSource

                ' Check if the data source is not null and has rows
                If dataSource IsNot Nothing AndAlso dataSource.Rows.Count > 0 Then
                    ' Generate the CSV file path
                    Dim filePath As String = Path.Combine(folderPath, "OrderItem.csv")

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