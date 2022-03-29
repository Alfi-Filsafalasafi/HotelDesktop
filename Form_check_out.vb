Public Class Form_check_out
    Sub bersihteks()

        txt_price.Text = ""
        txt_quantity.Text = ""


        txt_subtotal.Text = ""
    End Sub
    Sub tampilitemlist()
        lv_item.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_reservation_check_out where ReservationRoomID = '" & lbl_id_reservati.Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer
        Do While reader.Read

            lv_item.Items.Add(reader!items)
            lv_item.Items(i).SubItems.Add(reader!Qty)

            lv_item.Items(i).SubItems.Add(reader!CompensationFee)
            lv_item.Items(i).SubItems.Add(reader!TotalCharge)

            i = i + +1
        Loop
    End Sub
    Sub tampilroom()
        txt_room.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_reservationku where Status = 'Sudah Check In'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer
        Do While reader.Read
            txt_room.Items.Add(reader("RoomNumber"))

            i = i + +1
        Loop
    End Sub
    Sub tampiljumlahitem()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select sum(TotalCharge) as harga from v_reservation_check_out where ReservationRoomID = '" & lbl_id_reservati.Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer
        Do While reader.Read
            lbl_jumlah.Text = reader!harga
            i = i + +1
        Loop
    End Sub
    Sub tampilitemstatus()
        txt_item_status.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from ItemStatus where Name = 'Rusak'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer
        Do While reader.Read

            txt_item_status.Items.Add(reader("Name"))
            i = i + +1
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
    Private Sub Form_check_out_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form_check_out_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        tampilitem()
        tampilroom()
        tampilitemstatus()
    End Sub

    Private Sub txt_cari_room_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_room.SelectedIndexChanged

    End Sub

    Private Sub txt_cari_room_TextChanged(sender As Object, e As EventArgs) Handles txt_room.TextChanged
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_reservationku where RoomNumber = '" & txt_room.Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer
        Do While reader.Read
            lbl_id_reservati.Text = reader!ReservationID
            lbl_id_room.Text = reader!ID
        Loop
        tampilitemlist()
        'tampiljumlahitem()
    End Sub

    Private Sub cb_item_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_item.SelectedIndexChanged
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from Item where Name = '" & cb_item.Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer
        Do While reader.Read
            txt_price.Text = reader!CompensationFee
            lbl_item.Text = reader!ID
        Loop
    End Sub

    Private Sub txt_quantity_TextChanged(sender As Object, e As EventArgs) Handles txt_quantity.TextChanged
        txt_subtotal.Text = Val(txt_quantity.Text) * Val(txt_price.Text)
    End Sub

    Private Sub txt_price_TextChanged(sender As Object, e As EventArgs) Handles txt_price.TextChanged
        txt_subtotal.Text = Val(txt_quantity.Text) * Val(txt_price.Text)
    End Sub

    Private Sub btn_add_item_Click(sender As Object, e As EventArgs) Handles btn_add_item.Click
        If cb_item.Text = "" Or txt_quantity.Text = "" Or lbl_id_reservati.Text = "" Or lbl_id_status.Text = "" Or lbl_item.Text = "" Then
            MsgBox("Data belum lengkap", MsgBoxStyle.Critical)

        Else
            Dim message As Integer
            message = MsgBox("apakah anda yakin item ini telah rusak?", MsgBoxStyle.YesNo)
            If message = DialogResult.Yes Then
                konek_db()
                Dim form_employee As Form_employee = New Form_employee

                Dim tambah As New SqlClient.SqlCommand("insert into ReservationCheckOut values ('" & lbl_id_reservati.Text & "', '" & lbl_item.Text & "', '" & lbl_id_status.Text &
                                                                                       "','" & txt_quantity.Text & "','" & txt_subtotal.Text & "')", koneksi)

                Try
                    tampilitemstatus()
                    tampilitemlist()
                    'tampilroom()
                    tampilitem()
                    tambah.ExecuteNonQuery()
                    bersihteks()
                    MsgBox("data berhasil di tambah", MsgBoxStyle.Information)
                    tampiljumlahitem()

                Catch ex As Exception
                    MsgBox("data gagal di hapus karena  " + ex.Message, MsgBoxStyle.Critical)
                End Try
            Else

            End If
        End If
    End Sub

    Private Sub txt_item_status_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_item_status.SelectedIndexChanged

    End Sub

    Private Sub txt_item_status_TextChanged(sender As Object, e As EventArgs) Handles txt_item_status.TextChanged
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from ItemStatus where Name = '" & txt_item_status.Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer
        Do While reader.Read

            lbl_id_status.Text = reader!ID
        Loop
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        konek_db()
        Dim update As New SqlClient.SqlCommand("update Room set Status = 'Tidak Terpakai' where ID = '" & lbl_id_room.Text & "'", koneksi)
        Try
            update.ExecuteNonQuery()
            MsgBox("Berhasil Check out", MsgBoxStyle.Information)
            tampilroom()
            lv_item.Items.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub lbl_jumlah_Click(sender As Object, e As EventArgs) Handles lbl_jumlah.Click

    End Sub

    Private Sub lbl_jumlah_TextChanged(sender As Object, e As EventArgs) Handles lbl_jumlah.TextChanged
        lbl_total.Text = lbl_jumlah.Text
    End Sub

    Private Sub lbl_back_Click(sender As Object, e As EventArgs) Handles lbl_back.Click
        Me.Close()
    End Sub
End Class