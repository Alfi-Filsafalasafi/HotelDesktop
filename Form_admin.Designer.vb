<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_admin
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_name_admin = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn_room = New System.Windows.Forms.Button()
        Me.btn_room_type = New System.Windows.Forms.Button()
        Me.btn_item = New System.Windows.Forms.Button()
        Me.btn_food_drink = New System.Windows.Forms.Button()
        Me.btn_employee = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_log_out = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_lap_reservasi = New System.Windows.Forms.Button()
        Me.btn_lap_jumlah = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lbl_name_admin)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1362, 100)
        Me.Panel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(985, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(309, 29)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Admin of Hotel Nusantara"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_name_admin
        '
        Me.lbl_name_admin.AutoSize = True
        Me.lbl_name_admin.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name_admin.ForeColor = System.Drawing.Color.White
        Me.lbl_name_admin.Location = New System.Drawing.Point(212, 36)
        Me.lbl_name_admin.Name = "lbl_name_admin"
        Me.lbl_name_admin.Size = New System.Drawing.Size(162, 29)
        Me.lbl_name_admin.TabIndex = 2
        Me.lbl_name_admin.Text = "Admin Name"
        Me.lbl_name_admin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 100)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Welcome , "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 100)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1362, 100)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btn_room)
        Me.TabPage1.Controls.Add(Me.btn_room_type)
        Me.TabPage1.Controls.Add(Me.btn_item)
        Me.TabPage1.Controls.Add(Me.btn_food_drink)
        Me.TabPage1.Controls.Add(Me.btn_employee)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1354, 71)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Master"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btn_room
        '
        Me.btn_room.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_room.Location = New System.Drawing.Point(496, 3)
        Me.btn_room.Name = "btn_room"
        Me.btn_room.Size = New System.Drawing.Size(105, 65)
        Me.btn_room.TabIndex = 4
        Me.btn_room.Text = "Room"
        Me.btn_room.UseVisualStyleBackColor = True
        '
        'btn_room_type
        '
        Me.btn_room_type.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_room_type.Location = New System.Drawing.Point(370, 3)
        Me.btn_room_type.Name = "btn_room_type"
        Me.btn_room_type.Size = New System.Drawing.Size(126, 65)
        Me.btn_room_type.TabIndex = 3
        Me.btn_room_type.Text = "Room Type"
        Me.btn_room_type.UseVisualStyleBackColor = True
        '
        'btn_item
        '
        Me.btn_item.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_item.Location = New System.Drawing.Point(269, 3)
        Me.btn_item.Name = "btn_item"
        Me.btn_item.Size = New System.Drawing.Size(101, 65)
        Me.btn_item.TabIndex = 2
        Me.btn_item.Text = "Item"
        Me.btn_item.UseVisualStyleBackColor = True
        '
        'btn_food_drink
        '
        Me.btn_food_drink.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_food_drink.Location = New System.Drawing.Point(129, 3)
        Me.btn_food_drink.Name = "btn_food_drink"
        Me.btn_food_drink.Size = New System.Drawing.Size(140, 65)
        Me.btn_food_drink.TabIndex = 1
        Me.btn_food_drink.Text = "Food and Drink"
        Me.btn_food_drink.UseVisualStyleBackColor = True
        '
        'btn_employee
        '
        Me.btn_employee.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_employee.Location = New System.Drawing.Point(3, 3)
        Me.btn_employee.Name = "btn_employee"
        Me.btn_employee.Size = New System.Drawing.Size(126, 65)
        Me.btn_employee.TabIndex = 0
        Me.btn_employee.Text = "Employee"
        Me.btn_employee.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btn_exit)
        Me.TabPage2.Controls.Add(Me.btn_log_out)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1354, 71)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "File"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btn_exit
        '
        Me.btn_exit.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_exit.Location = New System.Drawing.Point(129, 3)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(126, 65)
        Me.btn_exit.TabIndex = 2
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_log_out
        '
        Me.btn_log_out.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_log_out.Location = New System.Drawing.Point(3, 3)
        Me.btn_log_out.Name = "btn_log_out"
        Me.btn_log_out.Size = New System.Drawing.Size(126, 65)
        Me.btn_log_out.TabIndex = 1
        Me.btn_log_out.Text = "Log Out"
        Me.btn_log_out.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_lap_reservasi)
        Me.GroupBox1.Controls.Add(Me.btn_lap_jumlah)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(382, 317)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(586, 227)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Laporan"
        Me.GroupBox1.Visible = False
        '
        'btn_lap_reservasi
        '
        Me.btn_lap_reservasi.Location = New System.Drawing.Point(309, 60)
        Me.btn_lap_reservasi.Name = "btn_lap_reservasi"
        Me.btn_lap_reservasi.Size = New System.Drawing.Size(214, 120)
        Me.btn_lap_reservasi.TabIndex = 1
        Me.btn_lap_reservasi.Text = "Reservation"
        Me.btn_lap_reservasi.UseVisualStyleBackColor = True
        '
        'btn_lap_jumlah
        '
        Me.btn_lap_jumlah.Location = New System.Drawing.Point(55, 60)
        Me.btn_lap_jumlah.Name = "btn_lap_jumlah"
        Me.btn_lap_jumlah.Size = New System.Drawing.Size(214, 120)
        Me.btn_lap_jumlah.TabIndex = 0
        Me.btn_lap_jumlah.Text = "Jumlah Pengunjung"
        Me.btn_lap_jumlah.UseVisualStyleBackColor = True
        '
        'Form_admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 741)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form_admin"
        Me.Text = "HOTEL"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_name_admin As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btn_room As Button
    Friend WithEvents btn_room_type As Button
    Friend WithEvents btn_item As Button
    Friend WithEvents btn_food_drink As Button
    Friend WithEvents btn_employee As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_log_out As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_lap_reservasi As Button
    Friend WithEvents btn_lap_jumlah As Button
End Class
