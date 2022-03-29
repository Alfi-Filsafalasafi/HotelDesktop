Public Class Form_reservation

    Sub bersihteks()
        lbl_item.Text = "-"
        lbl_id_costumer.Text = ""
        lbl_costumer.Text = "-"
        lbl_room_number.Text = "-"
        lbl_room_tpe.Text = ""
        txt_lama.Text = ""
        txt_quantity.Text = ""
        txt_price.Text = ""
        txt_subtotal.Text = ""
        lbl_jml.Text = ""
    End Sub

    Sub aksesteks(akses As Boolean)
        gp_item.Enabled = akses
        gp_room.Enabled = akses
    End Sub
    Sub tampildata()
        lv_menu.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_reservation_room where StartDateTime = '" & Format(Date.Now, "yyyy-MM-dd") & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer
        Do While reader.Read
            lv_menu.Items.Add(reader!ID)
            lv_menu.Items(i).SubItems.Add(reader!Costumer)
            lv_menu.Items(i).SubItems.Add(reader!RoomNumber)
            lv_menu.Items(i).SubItems.Add(reader!Name)
            lv_menu.Items(i).SubItems.Add(reader!CheckInDateTime)
            lv_menu.Items(i).SubItems.Add(reader!CheckOutDateTime)

            i = i + +1
        Loop
    End Sub

    Sub tampilcostumer()
        lv_costumer.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from Costumer", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer
        Do While reader.Read
            lv_costumer.Items.Add(reader!ID)
            lv_costumer.Items(i).SubItems.Add(reader!Name)
            lv_costumer.Items(i).SubItems.Add(reader!Email)
            lv_costumer.Items(i).SubItems.Add(reader!Gender)

            i = i + +1
        Loop
    End Sub
    Sub tampilitemlist()
        lv_item.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_reservation_request_item where ReservationRoomID = '" & lbl_id_reservati.Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer
        Do While reader.Read
            lv_item.Items.Add(reader!ID)
            lv_item.Items(i).SubItems.Add(reader!Name)
            lv_item.Items(i).SubItems.Add(reader!Qty)

            lv_item.Items(i).SubItems.Add(reader!RequestPrice)


            i = i + +1
        Loop
    End Sub
    Sub tampiljumlahitem()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select sum(TotalPrice) as harga from v_reservation_request_item where ReservationRoomID = '" & lbl_id_reservati.Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer
        Do While reader.Read
            lbl_jml.Text = reader!harga


            i = i + +1
        Loop
    End Sub

    Sub tampilidcostumer()

        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_reservation where Costumer  = '" & lbl_costumer.Text & "' and datetime = '" & Format(Date.Now, "yyyy-MM-dd") & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer
        Do While reader.Read
            lbl_id_reservati.Text = reader!ID

        Loop
    End Sub

    Sub tampilroom()
        lv_room.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_room where Status = 'Tidak Terpakai'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer
        Do While reader.Read
            lv_room.Items.Add(reader!ID)
            lv_room.Items(i).SubItems.Add(reader!RoomNumber)
            lv_room.Items(i).SubItems.Add(reader!RoomFloor)
            lv_room.Items(i).SubItems.Add(reader!Description)

            i = i + +1
        Loop
    End Sub
    Sub tampiltype()
        txt_cari_room.Items.Clear()

        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from RoomType", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Do While reader.Read
            txt_cari_room.Items.Add(reader("Name"))


        Loop
    End Sub

    Sub tampilitem()
        cb_item.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from Item", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer
        Do While reader.Read
            cb_item.Items.Add(reader("Name"))
        Loop
    End Sub

    Private Sub Form_reservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txt_cari_room_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_cari_room.SelectedIndexChanged

    End Sub

    Private Sub txt_cari_room_TextChanged(sender As Object, e As EventArgs) Handles txt_cari_room.TextChanged
        lv_room.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_room where Name = '" & txt_cari_room.Text & "' and Status = 'Tidak Terpakai'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer
        Do While reader.Read
            lv_room.Items.Add(reader!ID)
            lv_room.Items(i).SubItems.Add(reader!RoomNumber)
            lv_room.Items(i).SubItems.Add(reader!RoomFloor)
            lv_room.Items(i).SubItems.Add(reader!Description)

            i = i + +1
        Loop
    End Sub

    Private Sub txt_cari_costumer_TextChanged(sender As Object, e As EventArgs) Handles txt_cari_costumer.TextChanged
        lv_costumer.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from costumer where Name Like '%" & txt_cari_costumer.Text & "%'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer
        Do While reader.Read
            lv_costumer.Items.Add(reader!ID)
            lv_costumer.Items(i).SubItems.Add(reader!Name)
            lv_costumer.Items(i).SubItems.Add(reader!Email)
            lv_costumer.Items(i).SubItems.Add(reader!Gender)

            i = i + +1
        Loop
    End Sub

    Private Sub Form_reservation_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        tampilcostumer()
        tampilroom()
        tampiltype()
        tampilitem()
        tampildata()
        aksesteks(False)
    End Sub

    Private Sub lv_room_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_room.SelectedIndexChanged

    End Sub

    Private Sub lv_room_MouseClick(sender As Object, e As MouseEventArgs) Handles lv_room.MouseClick
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_room where ID = '" & lv_room.SelectedItems(0).SubItems(0).Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer
        Do While reader.Read
            lbl_id_room.Text = reader!ID
            lbl_room_number.Text = reader!RoomNumber
            lbl_room_tpe.Text = reader!Name
            lbl_price.Text = reader!RoomPrice

        Loop
    End Sub

    Private Sub lv_costumer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_costumer.SelectedIndexChanged

    End Sub

    Private Sub lv_costumer_MouseClick(sender As Object, e As MouseEventArgs) Handles lv_costumer.MouseClick
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from Costumer where ID = '" & lv_costumer.SelectedItems(0).SubItems(0).Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer
        Do While reader.Read
            lbl_id_costumer.Text = reader!ID
            lbl_email.Text = reader!Email
            lbl_costumer.Text = reader!Name

        Loop
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles gp_room.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_lanjut.Click
        If lbl_costumer.Text = "-" Then
            MsgBox("Plih data terlebih dahulu", MsgBoxStyle.Critical)

        Else
            Dim message As Integer
            message = MsgBox("apakah anda yakin akan melakukan reservasi data ini?", MsgBoxStyle.YesNo)
            If message = DialogResult.Yes Then
                konek_db()
                Dim form_employee As Form_employee = New Form_employee

                Dim tambah As New SqlClient.SqlCommand("insert into Reservation values ('" & Format(Date.Now, "yyyy-MM-dd") & "','1', '" & lbl_id_costumer.Text &
                                                                                       "', 'C " & lbl_id_costumer.Text & "E0" & form_employee.lbl_id.Text & "')", koneksi)

                Try
                    tambah.ExecuteNonQuery()
                    MsgBox("data berhasil di tambah", MsgBoxStyle.Information)
                    tampilidcostumer()
                    Gp_costumer.Enabled = False
                    aksesteks(True)
                Catch ex As Exception
                    MsgBox("data gagal di hapus karena  " + ex.Message, MsgBoxStyle.Critical)
                End Try
            Else

            End If
        End If
    End Sub

    Private Sub cb_item_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_item.SelectedIndexChanged

    End Sub

    Private Sub cb_item_TextChanged(sender As Object, e As EventArgs) Handles cb_item.TextChanged
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from Item where Name = '" & cb_item.Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer
        Do While reader.Read
            txt_price.Text = reader!RequestPrice
            lbl_item.Text = reader!ID
        Loop
    End Sub

    Private Sub txt_quantity_TextChanged(sender As Object, e As EventArgs) Handles txt_quantity.TextChanged
        txt_subtotal.Text = Val(txt_quantity.Text) * Val(txt_price.Text)
    End Sub

    Private Sub btn_add_item_Click(sender As Object, e As EventArgs) Handles btn_add_item.Click
        If cb_item.Text = "" Or txt_quantity.Text = "" Then
            MsgBox("Data belum lengkap", MsgBoxStyle.Critical)

        Else
            Dim message As Integer
            message = MsgBox("apakah anda yakin akan menambah item ini?", MsgBoxStyle.YesNo)
            If message = DialogResult.Yes Then
                konek_db()
                Dim form_employee As Form_employee = New Form_employee

                Dim tambah As New SqlClient.SqlCommand("insert into ReservationRequestItem values ('" & lbl_id_reservati.Text & "', '" & lbl_item.Text &
                                                                                       "','" & txt_quantity.Text & "','" & txt_subtotal.Text & "')", koneksi)

                Try
                    tambah.ExecuteNonQuery()
                    MsgBox("data berhasil di tambah", MsgBoxStyle.Information)
                    tampilitemlist()
                    tampiljumlahitem()
                    txt_price.Text = ""
                    txt_quantity.Text = ""
                    txt_subtotal.Text = ""
                Catch ex As Exception
                    MsgBox("data gagal di hapus karena  " + ex.Message, MsgBoxStyle.Critical)
                End Try
            Else

            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_lama.TextChanged
        'txt_checkOut.Value(DateInterval.Day, 3, txt_checkin.Text)
        If txt_lama.Text = "" Then

        End If
        If txt_lama.Text <> "" Then

            konek_db()
            Dim chek As New SqlClient.SqlCommand("select DATEADD(Day," & txt_lama.Text & ", '" & Format(txt_checkin.Value, "yyyy-MM-dd") & "') as cheks", koneksi)
            Dim reader As SqlClient.SqlDataReader
            reader = chek.ExecuteReader
            Do While reader.Read
                txt_checkOut.Text = reader!cheks
            Loop
        End If
        lbl_total.Text = Val(lbl_total.Text) * Val(txt_lama.Text)

    End Sub

    Private Sub lbl_price_Click(sender As Object, e As EventArgs) Handles lbl_price.Click

    End Sub

    Private Sub lbl_price_TextChanged(sender As Object, e As EventArgs) Handles lbl_price.TextChanged
        lbl_total.Text = Val(lbl_price.Text) + Val(lbl_jml.Text)
    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        If lbl_id_costumer.Text = "" Or lbl_id_reservati.Text = "" Or lbl_id_room.Text = "" Then
            MsgBox("lengkapi data terlebih dahulu", MsgBoxStyle.Information)
        Else
            Dim message As Integer
            message = MsgBox("apakah anda yakin akan melakukan reservasi data ini?", MsgBoxStyle.YesNo)
            If message = DialogResult.Yes Then
                konek_db()
                Dim form_employee As Form_employee = New Form_employee

                Dim tambah As New SqlClient.SqlCommand("insert into ReservationRoom values ('" & lbl_id_reservati.Text & "', '" & lbl_id_room.Text & "','" & Format(Date.Now, "yyyy-MM-dd") &
                                                                                       "','" & txt_lama.Text & "', '" & lbl_total.Text & "', '" & Format(txt_checkin.Value, "yyyy-MM-dd") & "', '" & Format(txt_checkin.Value, "yyyy-MM-dd") & "')", koneksi)
                Dim update As New SqlClient.SqlCommand("update Room set Status ='Reservasi' where ID = '" & lbl_id_room.Text & "'", koneksi)
                Try
                    tambah.ExecuteNonQuery()
                    MsgBox("data berhasil di tambah", MsgBoxStyle.Information)
                    tampilidcostumer()
                    update.ExecuteNonQuery()
                    tampildata()
                    tampilroom()
                    bersihteks()
                    aksesteks(False)
                    Gp_costumer.Enabled = True
                Catch ex As Exception
                    MsgBox("data gagal di hapus karena  " + ex.Message, MsgBoxStyle.Critical)
                End Try
            Else

            End If
        End If
    End Sub

    Private Sub lbl_jml_Click(sender As Object, e As EventArgs) Handles lbl_jml.Click

    End Sub

    Private Sub lbl_jml_TextChanged(sender As Object, e As EventArgs) Handles lbl_jml.TextChanged
        lbl_total.Text = Val(lbl_price.Text) + Val(lbl_jml.Text)
    End Sub

    Private Sub txt_quantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_quantity.KeyPress
        Dim kata As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse kata = Keys.Back) Then
            kata = 0
        Else
            e.Handled = CBool(kata)
        End If
    End Sub

    Private Sub txt_lama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_lama.KeyPress
        Dim kata As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse kata = Keys.Back) Then
            kata = 0
        Else
            e.Handled = CBool(kata)
        End If
    End Sub

    Private Sub lbl_back_Click(sender As Object, e As EventArgs) Handles lbl_back.Click
        Me.Close()
    End Sub

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        Dim s As Form_costumer = New Form_costumer
        s.Show()
        Me.Visible = False
    End Sub
End Class