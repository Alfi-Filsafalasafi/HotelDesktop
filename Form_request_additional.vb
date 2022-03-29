Public Class Form_request_additional
    Sub tampilitemlist()
        lv_item.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_reservation_request_item where ReservationRoomID = '" & lbl_id_reservati.Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer
        Do While reader.Read
            lv_item.Items.Add(reader!ID)
            lv_item.Items(i).SubItems.Add(reader!items)
            lv_item.Items(i).SubItems.Add(reader!Qty)

            lv_item.Items(i).SubItems.Add(reader!RequestPrice)
            lv_item.Items(i).SubItems.Add(reader!TotalPrice)

            i = i + +1
        Loop
    End Sub
    Sub tampilroom()
        txt_cari_room.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_reservationku where Status = 'Sudah Check In'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer
        Do While reader.Read
            txt_cari_room.Items.Add(reader("RoomNumber"))

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
    Sub tampiljumlahitem()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select sum(TotalPrice) as harga from v_reservation_request_item where ReservationRoomID = '" & lbl_id_reservati.Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer
        Do While reader.Read
            lbl_jumlah.Text = reader!harga


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
    Private Sub Form_request_additional_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form_request_additional_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        tampilitem() '
        tampilroom()
    End Sub

    Private Sub txt_cari_room_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_cari_room.SelectedIndexChanged

    End Sub

    Private Sub txt_cari_room_TextChanged(sender As Object, e As EventArgs) Handles txt_cari_room.TextChanged
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_reservationku where RoomNumber = '" & txt_cari_room.Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer
        Do While reader.Read
            lbl_id_room.Text = reader!RoomID
            lbl_id_reservati.Text = reader!ReservationID
            tampilitemlist()
            tampiljumlahitem()

        Loop
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

                Catch ex As Exception
                    MsgBox("data gagal di hapus karena  " + ex.Message, MsgBoxStyle.Critical)
                End Try
            Else

            End If
        End If
    End Sub

    Private Sub lbl_back_Click(sender As Object, e As EventArgs) Handles lbl_back.Click
        Me.Close()
    End Sub
End Class