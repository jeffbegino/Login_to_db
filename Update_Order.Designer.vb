﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Update_Order
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Update_Order))
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBoxCountry = New System.Windows.Forms.TextBox()
        Me.TextBoxLastName = New System.Windows.Forms.TextBox()
        Me.TextBoxCity = New System.Windows.Forms.TextBox()
        Me.TextBoxFirstName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxUser_ID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ButtonCancel
        '
        Me.ButtonCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonCancel.Location = New System.Drawing.Point(240, 248)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(147, 34)
        Me.ButtonCancel.TabIndex = 58
        Me.ButtonCancel.Text = "Close"
        Me.ButtonCancel.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 20)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Update Total Amount:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 20)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Update Order Number:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 20)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Update Customer ID:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 20)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Update Orders Date:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Location = New System.Drawing.Point(87, 248)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 34)
        Me.Button1.TabIndex = 53
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBoxCountry
        '
        Me.TextBoxCountry.Location = New System.Drawing.Point(182, 167)
        Me.TextBoxCountry.Multiline = True
        Me.TextBoxCountry.Name = "TextBoxCountry"
        Me.TextBoxCountry.Size = New System.Drawing.Size(204, 20)
        Me.TextBoxCountry.TabIndex = 52
        '
        'TextBoxLastName
        '
        Me.TextBoxLastName.Location = New System.Drawing.Point(182, 115)
        Me.TextBoxLastName.Multiline = True
        Me.TextBoxLastName.Name = "TextBoxLastName"
        Me.TextBoxLastName.Size = New System.Drawing.Size(204, 20)
        Me.TextBoxLastName.TabIndex = 51
        '
        'TextBoxCity
        '
        Me.TextBoxCity.Location = New System.Drawing.Point(182, 141)
        Me.TextBoxCity.Multiline = True
        Me.TextBoxCity.Name = "TextBoxCity"
        Me.TextBoxCity.Size = New System.Drawing.Size(205, 20)
        Me.TextBoxCity.TabIndex = 50
        '
        'TextBoxFirstName
        '
        Me.TextBoxFirstName.Location = New System.Drawing.Point(182, 89)
        Me.TextBoxFirstName.Name = "TextBoxFirstName"
        Me.TextBoxFirstName.Size = New System.Drawing.Size(204, 20)
        Me.TextBoxFirstName.TabIndex = 49
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 20)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Enter Order ID:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBoxUser_ID
        '
        Me.TextBoxUser_ID.Location = New System.Drawing.Point(182, 63)
        Me.TextBoxUser_ID.Name = "TextBoxUser_ID"
        Me.TextBoxUser_ID.Size = New System.Drawing.Size(204, 20)
        Me.TextBoxUser_ID.TabIndex = 47
        '
        'Update_Order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(415, 345)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBoxCountry)
        Me.Controls.Add(Me.TextBoxLastName)
        Me.Controls.Add(Me.TextBoxCity)
        Me.Controls.Add(Me.TextBoxFirstName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxUser_ID)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Update_Order"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update_Order"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonCancel As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBoxCountry As TextBox
    Friend WithEvents TextBoxLastName As TextBox
    Friend WithEvents TextBoxCity As TextBox
    Friend WithEvents TextBoxFirstName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxUser_ID As TextBox
End Class
