﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookRoom
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSaveBooking = New System.Windows.Forms.Button()
        Me.dtpCheckIn = New System.Windows.Forms.DateTimePicker()
        Me.dtpCheckOut = New System.Windows.Forms.DateTimePicker()
        Me.cmbRoomNumber = New System.Windows.Forms.ComboBox()
        Me.txtGuestName = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(91, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(355, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hotel Room Booking - Book Room"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(84, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Room Number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(104, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Guest Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(72, 291)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Phone Number:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(80, 353)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Check In Date:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(71, 422)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 21)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Check Out Date:"
        '
        'btnSaveBooking
        '
        Me.btnSaveBooking.BackColor = System.Drawing.Color.LightBlue
        Me.btnSaveBooking.ForeColor = System.Drawing.Color.Navy
        Me.btnSaveBooking.Location = New System.Drawing.Point(279, 474)
        Me.btnSaveBooking.Name = "btnSaveBooking"
        Me.btnSaveBooking.Size = New System.Drawing.Size(84, 34)
        Me.btnSaveBooking.TabIndex = 6
        Me.btnSaveBooking.Text = "Save"
        Me.btnSaveBooking.UseVisualStyleBackColor = False
        '
        'dtpCheckIn
        '
        Me.dtpCheckIn.Location = New System.Drawing.Point(229, 345)
        Me.dtpCheckIn.Name = "dtpCheckIn"
        Me.dtpCheckIn.Size = New System.Drawing.Size(190, 29)
        Me.dtpCheckIn.TabIndex = 7
        '
        'dtpCheckOut
        '
        Me.dtpCheckOut.Location = New System.Drawing.Point(229, 414)
        Me.dtpCheckOut.Name = "dtpCheckOut"
        Me.dtpCheckOut.Size = New System.Drawing.Size(190, 29)
        Me.dtpCheckOut.TabIndex = 8
        '
        'cmbRoomNumber
        '
        Me.cmbRoomNumber.FormattingEnabled = True
        Me.cmbRoomNumber.Location = New System.Drawing.Point(229, 107)
        Me.cmbRoomNumber.Name = "cmbRoomNumber"
        Me.cmbRoomNumber.Size = New System.Drawing.Size(190, 29)
        Me.cmbRoomNumber.TabIndex = 9
        '
        'txtGuestName
        '
        Me.txtGuestName.Location = New System.Drawing.Point(229, 167)
        Me.txtGuestName.Name = "txtGuestName"
        Me.txtGuestName.Size = New System.Drawing.Size(190, 29)
        Me.txtGuestName.TabIndex = 10
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(229, 283)
        Me.txtPhone.MaxLength = 10
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(190, 29)
        Me.txtPhone.TabIndex = 11
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.LightBlue
        Me.btnBack.Location = New System.Drawing.Point(-1, -1)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(67, 35)
        Me.btnBack.TabIndex = 13
        Me.btnBack.Text = "<Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(137, 232)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 21)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Price:"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(229, 224)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(190, 29)
        Me.txtPrice.TabIndex = 15
        '
        'BookRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkBlue
        Me.ClientSize = New System.Drawing.Size(520, 538)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtGuestName)
        Me.Controls.Add(Me.cmbRoomNumber)
        Me.Controls.Add(Me.dtpCheckOut)
        Me.Controls.Add(Me.dtpCheckIn)
        Me.Controls.Add(Me.btnSaveBooking)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "BookRoom"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bookings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnSaveBooking As Button
    Friend WithEvents dtpCheckIn As DateTimePicker
    Friend WithEvents dtpCheckOut As DateTimePicker
    Friend WithEvents cmbRoomNumber As ComboBox
    Friend WithEvents txtGuestName As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents btnBack As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPrice As TextBox
End Class
