<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_request_additional
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
        Me.lbl_back = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gp_item = New System.Windows.Forms.GroupBox()
        Me.lbl_id_reservati = New System.Windows.Forms.Label()
        Me.lbl_item = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cb_item = New System.Windows.Forms.ComboBox()
        Me.btn_add_item = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.txt_subtotal = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txt_quantity = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lv_item = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_cari_room = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_jumlah = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbl_id_room = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.gp_item.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.Controls.Add(Me.lbl_back)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1362, 100)
        Me.Panel1.TabIndex = 4
        '
        'lbl_back
        '
        Me.lbl_back.AutoSize = True
        Me.lbl_back.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_back.Location = New System.Drawing.Point(58, 43)
        Me.lbl_back.Name = "lbl_back"
        Me.lbl_back.Size = New System.Drawing.Size(80, 20)
        Me.lbl_back.TabIndex = 10
        Me.lbl_back.Text = "Back Icon"
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1362, 100)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Request Additional Item(s)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gp_item
        '
        Me.gp_item.Controls.Add(Me.lbl_id_reservati)
        Me.gp_item.Controls.Add(Me.lbl_item)
        Me.gp_item.Controls.Add(Me.Panel3)
        Me.gp_item.Controls.Add(Me.btn_add_item)
        Me.gp_item.Controls.Add(Me.Panel7)
        Me.gp_item.Controls.Add(Me.Label10)
        Me.gp_item.Controls.Add(Me.Panel5)
        Me.gp_item.Controls.Add(Me.Label9)
        Me.gp_item.Controls.Add(Me.Panel4)
        Me.gp_item.Controls.Add(Me.Label8)
        Me.gp_item.Controls.Add(Me.Label3)
        Me.gp_item.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gp_item.Location = New System.Drawing.Point(266, 233)
        Me.gp_item.Name = "gp_item"
        Me.gp_item.Size = New System.Drawing.Size(377, 285)
        Me.gp_item.TabIndex = 24
        Me.gp_item.TabStop = False
        Me.gp_item.Text = "Request Additional Items"
        '
        'lbl_id_reservati
        '
        Me.lbl_id_reservati.AutoSize = True
        Me.lbl_id_reservati.Location = New System.Drawing.Point(73, 238)
        Me.lbl_id_reservati.Name = "lbl_id_reservati"
        Me.lbl_id_reservati.Size = New System.Drawing.Size(16, 17)
        Me.lbl_id_reservati.TabIndex = 33
        Me.lbl_id_reservati.Text = "0"
        Me.lbl_id_reservati.Visible = False
        '
        'lbl_item
        '
        Me.lbl_item.AutoSize = True
        Me.lbl_item.Location = New System.Drawing.Point(20, 238)
        Me.lbl_item.Name = "lbl_item"
        Me.lbl_item.Size = New System.Drawing.Size(16, 17)
        Me.lbl_item.TabIndex = 32
        Me.lbl_item.Text = "0"
        Me.lbl_item.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.cb_item)
        Me.Panel3.Location = New System.Drawing.Point(95, 33)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(250, 30)
        Me.Panel3.TabIndex = 30
        '
        'cb_item
        '
        Me.cb_item.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_item.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_item.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_item.FormattingEnabled = True
        Me.cb_item.Location = New System.Drawing.Point(3, 1)
        Me.cb_item.Name = "cb_item"
        Me.cb_item.Size = New System.Drawing.Size(242, 24)
        Me.cb_item.TabIndex = 0
        '
        'btn_add_item
        '
        Me.btn_add_item.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add_item.Location = New System.Drawing.Point(254, 207)
        Me.btn_add_item.Name = "btn_add_item"
        Me.btn_add_item.Size = New System.Drawing.Size(91, 36)
        Me.btn_add_item.TabIndex = 31
        Me.btn_add_item.Text = "Add"
        Me.btn_add_item.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.txt_subtotal)
        Me.Panel7.Location = New System.Drawing.Point(95, 158)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(250, 28)
        Me.Panel7.TabIndex = 26
        '
        'txt_subtotal
        '
        Me.txt_subtotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_subtotal.Enabled = False
        Me.txt_subtotal.Location = New System.Drawing.Point(5, 3)
        Me.txt_subtotal.Multiline = True
        Me.txt_subtotal.Name = "txt_subtotal"
        Me.txt_subtotal.Size = New System.Drawing.Size(241, 20)
        Me.txt_subtotal.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 163)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 17)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Sub Total"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.txt_price)
        Me.Panel5.Location = New System.Drawing.Point(95, 117)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(250, 28)
        Me.Panel5.TabIndex = 24
        '
        'txt_price
        '
        Me.txt_price.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_price.Enabled = False
        Me.txt_price.Location = New System.Drawing.Point(5, 3)
        Me.txt_price.Multiline = True
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(241, 20)
        Me.txt_price.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 125)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 17)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Price"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.txt_quantity)
        Me.Panel4.Location = New System.Drawing.Point(95, 76)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(250, 28)
        Me.Panel4.TabIndex = 22
        '
        'txt_quantity
        '
        Me.txt_quantity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_quantity.Location = New System.Drawing.Point(5, 3)
        Me.txt_quantity.Multiline = True
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.Size = New System.Drawing.Size(241, 20)
        Me.txt_quantity.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 81)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 17)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Quantity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 17)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Item"
        '
        'lv_item
        '
        Me.lv_item.BackColor = System.Drawing.Color.RoyalBlue
        Me.lv_item.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader1})
        Me.lv_item.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_item.ForeColor = System.Drawing.Color.White
        Me.lv_item.FullRowSelect = True
        Me.lv_item.GridLines = True
        Me.lv_item.Location = New System.Drawing.Point(668, 314)
        Me.lv_item.Name = "lv_item"
        Me.lv_item.Size = New System.Drawing.Size(518, 162)
        Me.lv_item.TabIndex = 24
        Me.lv_item.UseCompatibleStateImageBehavior = False
        Me.lv_item.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "ID"
        Me.ColumnHeader5.Width = 57
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Name"
        Me.ColumnHeader6.Width = 145
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Qty"
        Me.ColumnHeader7.Width = 91
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Price"
        Me.ColumnHeader8.Width = 99
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Total"
        Me.ColumnHeader1.Width = 101
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(668, 239)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(384, 69)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Request Additional Items"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txt_cari_room)
        Me.Panel2.Location = New System.Drawing.Point(104, 23)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(250, 30)
        Me.Panel2.TabIndex = 32
        '
        'txt_cari_room
        '
        Me.txt_cari_room.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt_cari_room.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txt_cari_room.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cari_room.FormattingEnabled = True
        Me.txt_cari_room.Location = New System.Drawing.Point(3, 1)
        Me.txt_cari_room.Name = "txt_cari_room"
        Me.txt_cari_room.Size = New System.Drawing.Size(242, 24)
        Me.txt_cari_room.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 17)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Cari Room"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(903, 490)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 20)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Rp."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(813, 490)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 20)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Total Price"
        '
        'lbl_jumlah
        '
        Me.lbl_jumlah.AutoSize = True
        Me.lbl_jumlah.Location = New System.Drawing.Point(943, 490)
        Me.lbl_jumlah.Name = "lbl_jumlah"
        Me.lbl_jumlah.Size = New System.Drawing.Size(14, 20)
        Me.lbl_jumlah.TabIndex = 35
        Me.lbl_jumlah.Text = "-"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1056, 482)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 36)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbl_id_room
        '
        Me.lbl_id_room.AutoSize = True
        Me.lbl_id_room.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id_room.Location = New System.Drawing.Point(760, 200)
        Me.lbl_id_room.Name = "lbl_id_room"
        Me.lbl_id_room.Size = New System.Drawing.Size(0, 17)
        Me.lbl_id_room.TabIndex = 33
        Me.lbl_id_room.Visible = False
        '
        'Form_request_additional
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 699)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbl_id_room)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbl_jumlah)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gp_item)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lv_item)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form_request_additional"
        Me.Text = "HOTEL"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gp_item.ResumeLayout(False)
        Me.gp_item.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_back As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents gp_item As GroupBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents cb_item As ComboBox
    Friend WithEvents btn_add_item As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents txt_subtotal As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txt_price As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txt_quantity As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lv_item As ListView
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txt_cari_room As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_jumlah As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lbl_id_room As Label
    Friend WithEvents lbl_id_reservati As Label
    Friend WithEvents lbl_item As Label
End Class
