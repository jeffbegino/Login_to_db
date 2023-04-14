<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonCustomer = New System.Windows.Forms.Button()
        Me.ButtonOrders = New System.Windows.Forms.Button()
        Me.ButtonOrderItem = New System.Windows.Forms.Button()
        Me.ButtonProduct = New System.Windows.Forms.Button()
        Me.ButtonSupplier = New System.Windows.Forms.Button()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.ButtonUpload = New System.Windows.Forms.Button()
        Me.ButtonBackup = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Green
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Uighur", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(13, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(390, 47)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "'EDP DATABASE'"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonCustomer
        '
        Me.ButtonCustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonCustomer.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCustomer.Location = New System.Drawing.Point(13, 106)
        Me.ButtonCustomer.Name = "ButtonCustomer"
        Me.ButtonCustomer.Size = New System.Drawing.Size(390, 29)
        Me.ButtonCustomer.TabIndex = 1
        Me.ButtonCustomer.Text = "View Customer"
        Me.ButtonCustomer.UseVisualStyleBackColor = False
        '
        'ButtonOrders
        '
        Me.ButtonOrders.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonOrders.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOrders.Location = New System.Drawing.Point(12, 141)
        Me.ButtonOrders.Name = "ButtonOrders"
        Me.ButtonOrders.Size = New System.Drawing.Size(391, 29)
        Me.ButtonOrders.TabIndex = 2
        Me.ButtonOrders.Text = "View Orders"
        Me.ButtonOrders.UseVisualStyleBackColor = False
        '
        'ButtonOrderItem
        '
        Me.ButtonOrderItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonOrderItem.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOrderItem.Location = New System.Drawing.Point(12, 176)
        Me.ButtonOrderItem.Name = "ButtonOrderItem"
        Me.ButtonOrderItem.Size = New System.Drawing.Size(391, 29)
        Me.ButtonOrderItem.TabIndex = 3
        Me.ButtonOrderItem.Text = "View Order Items"
        Me.ButtonOrderItem.UseVisualStyleBackColor = False
        '
        'ButtonProduct
        '
        Me.ButtonProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonProduct.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonProduct.Location = New System.Drawing.Point(12, 211)
        Me.ButtonProduct.Name = "ButtonProduct"
        Me.ButtonProduct.Size = New System.Drawing.Size(390, 29)
        Me.ButtonProduct.TabIndex = 4
        Me.ButtonProduct.Text = "View Product"
        Me.ButtonProduct.UseVisualStyleBackColor = False
        '
        'ButtonSupplier
        '
        Me.ButtonSupplier.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonSupplier.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSupplier.Location = New System.Drawing.Point(12, 246)
        Me.ButtonSupplier.Name = "ButtonSupplier"
        Me.ButtonSupplier.Size = New System.Drawing.Size(390, 29)
        Me.ButtonSupplier.TabIndex = 5
        Me.ButtonSupplier.Text = "View Supplier"
        Me.ButtonSupplier.UseVisualStyleBackColor = False
        '
        'ButtonExit
        '
        Me.ButtonExit.BackColor = System.Drawing.Color.LightCoral
        Me.ButtonExit.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonExit.ForeColor = System.Drawing.Color.Black
        Me.ButtonExit.Location = New System.Drawing.Point(271, 281)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(132, 29)
        Me.ButtonExit.TabIndex = 9
        Me.ButtonExit.Text = "Exit"
        Me.ButtonExit.UseVisualStyleBackColor = False
        '
        'ButtonUpload
        '
        Me.ButtonUpload.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonUpload.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUpload.Location = New System.Drawing.Point(13, 71)
        Me.ButtonUpload.Name = "ButtonUpload"
        Me.ButtonUpload.Size = New System.Drawing.Size(390, 29)
        Me.ButtonUpload.TabIndex = 10
        Me.ButtonUpload.Text = "Upload Dataset"
        Me.ButtonUpload.UseVisualStyleBackColor = False
        '
        'ButtonBackup
        '
        Me.ButtonBackup.BackColor = System.Drawing.Color.SpringGreen
        Me.ButtonBackup.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBackup.ForeColor = System.Drawing.Color.Black
        Me.ButtonBackup.Location = New System.Drawing.Point(12, 281)
        Me.ButtonBackup.Name = "ButtonBackup"
        Me.ButtonBackup.Size = New System.Drawing.Size(253, 29)
        Me.ButtonBackup.TabIndex = 11
        Me.ButtonBackup.Text = "Backup Database"
        Me.ButtonBackup.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(415, 345)
        Me.Controls.Add(Me.ButtonBackup)
        Me.Controls.Add(Me.ButtonUpload)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.ButtonSupplier)
        Me.Controls.Add(Me.ButtonProduct)
        Me.Controls.Add(Me.ButtonOrderItem)
        Me.Controls.Add(Me.ButtonOrders)
        Me.Controls.Add(Me.ButtonCustomer)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonCustomer As Button
    Friend WithEvents ButtonOrders As Button
    Friend WithEvents ButtonOrderItem As Button
    Friend WithEvents ButtonProduct As Button
    Friend WithEvents ButtonSupplier As Button
    Friend WithEvents ButtonExit As Button
    Friend WithEvents ButtonUpload As Button
    Friend WithEvents ButtonBackup As Button
End Class
