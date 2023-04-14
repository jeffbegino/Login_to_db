Imports MySql.Data.MySqlClient

Public Class Form2
    Private Sub ButtonCustomer_Click(sender As Object, e As EventArgs) Handles ButtonCustomer.Click
        Close()
        Customers.Show()
    End Sub

    Private Sub ButtonOrders_Click(sender As Object, e As EventArgs) Handles ButtonOrders.Click
        Close()
        Orders.Show()
    End Sub

    Private Sub ButtonOrderItem_Click(sender As Object, e As EventArgs) Handles ButtonOrderItem.Click
        Close()
        OrderItem.Show()
    End Sub

    Private Sub ButtonProduct_Click(sender As Object, e As EventArgs) Handles ButtonProduct.Click
        Close()
        Product.Show()
    End Sub

    Private Sub ButtonSupplier_Click(sender As Object, e As EventArgs) Handles ButtonSupplier.Click
        Close()
        Supplier.Show()
    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Application.Exit()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonUpload_Click(sender As Object, e As EventArgs) Handles ButtonUpload.Click
        Close()
        Uploads.Show()
    End Sub

    Private Sub ButtonBackup_Click(sender As Object, e As EventArgs) Handles ButtonBackup.Click
        Dim backup As New SaveFileDialog
        backup.InitialDirectory = "C:\"
        backup.Title = "Database Backup"
        backup.CheckFileExists = False
        backup.CheckPathExists = False
        backup.DefaultExt = "sql"
        backup.Filter = "sql files (*.sql)|*.sql|All files (*.*)|*.*"
        backup.RestoreDirectory = True

        If backup.ShowDialog = Windows.Forms.DialogResult.OK Then
            Call Connect_to_DB()
            Dim cmd As MySqlCommand = New MySqlCommand
            cmd.Connection = myconn
            Dim mb As MySqlBackup = New MySqlBackup(cmd)
            mb.ExportToFile(backup.FileName)
            myconn.Close()
            MessageBox.Show("Database Successfully Backup!", "BACKUP", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf backup.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            Return
        End If

    End Sub
End Class