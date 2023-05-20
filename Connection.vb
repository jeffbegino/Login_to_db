Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop.Excel
Imports System.IO
Imports Microsoft.Office.Interop

Module Connection
    Public myconn As New MySqlConnection
    Public myConnectionString As String
    Public strSQL As String

    Public currentDate As DateTime = DateTime.Now
    Public strpassword = "begino2002"
    'Public xlsPath As String = "C:\Python_Programs\Datasets\dataXls\TEMPLATE\"
    Public xlsFiles As String = "C:\Users\Acer\OneDrive\Mga Dokumento\"

    Public Sub Connect_to_DB()
        myConnectionString = "server=127.0.0.1;" _
                    & "uid=root;" _
                    & "pwd=begino2002;" _
                    & "database=edp"

        Try
            myconn.ConnectionString = myConnectionString
            myconn.Open()
            'MessageBox.Show("Connection Success!")

        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub ExportToExcel(ByVal dgv As DataGridView, ByVal templatefilename As String)
        Dim xlsApp As Excel.Application = Nothing
        Dim xlsWB As Excel.Workbook = Nothing
        Dim xlsSheet As Excel.Worksheet = Nothing
        Dim misValue As Object = System.Reflection.Missing.Value

        xlsApp = New Excel.Application
        xlsApp.Visible = False
        xlsWB = xlsApp.Workbooks.Add(misValue)
        xlsSheet = xlsWB.Sheets("Sheet1")

        'Copy DataGridView values to Excel
        Dim columnsCount As Integer = dgv.Columns.Count
        For column As Integer = 0 To columnsCount - 1
            xlsSheet.Cells(1, column + 1) = dgv.Columns(column).HeaderText
            For row As Integer = 0 To dgv.Rows.Count - 1
                If dgv.Rows(row).Cells(column).Value IsNot Nothing Then
                    xlsSheet.Cells(row + 2, column + 1) = dgv.Rows(row).Cells(column).Value.ToString()
                Else
                    xlsSheet.Cells(row + 2, column + 1) = ""
                End If
            Next
        Next


        'Autofit columns in Excel
        Dim columnsRange As Range = xlsSheet.Columns
        columnsRange.AutoFit()

        'Save the Excel file
        templatefilename = templatefilename.Replace(".xlsx", "")
        templatefilename = templatefilename.Replace(".xls", "")
        Dim myfilename As String = templatefilename & " " & currentDate.ToString("mm-dd-yy hh-mm-ss") & ".xlsx"
        xlsSheet.Protect(strpassword)
        xlsApp.ActiveWindow.View = XlWindowView.xlPageLayoutView
        xlsApp.ActiveWindow.DisplayGridlines = False
        xlsWB.SaveAs(xlsFiles & myfilename, XlFileFormat.xlOpenXMLWorkbook, misValue, misValue, misValue, misValue, XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue)
        xlsWB.Close(True, misValue, misValue)
        xlsApp.Quit()

        releaseObject(xlsSheet)
        releaseObject(xlsWB)
        releaseObject(xlsApp)

        Dim filePath As String = Path.Combine(xlsFiles, myfilename)

        'Open the Excel file
        'System.Diagnostics.Process.Start("excel.exe", """" & xlsFiles & myfilename & """")
        MsgBox("File saved to " + filePath)
    End Sub

    Public Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

End Module
