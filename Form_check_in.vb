Public Class Form_check_in
    Sub tampildata()
        lv_menu.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_reservationku where Status = 'Reservasi'", koneksi)
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
    Sub bersihteks()
        lbl_email.Text = "-"
        lbl_gender.Text = "-"
        lbl_id_booking.Text = "-"
        lbl_id.Text = ""
        lbl_name.Text = ""
        lbl_phone.Text = ""
        lbl_nik.Text = ""

    End Sub
    Private Sub Form_check_in_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form_check_in_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        tampildata()
    End Sub

    Private Sub txt_cari_costumer_TextChanged(sender As Object, e As EventArgs) Handles txt_cari_costumer.TextChanged
        lv_menu.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_reservation_room where BookingCode LIKE '%" & txt_cari_costumer.Text & "%' And Status = 'Belum Check In'", koneksi)
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

    Private Sub lv_menu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_menu.SelectedIndexChanged

    End Sub

    Private Sub lv_menu_MouseClick(sender As Object, e As MouseEventArgs) Handles lv_menu.MouseClick
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_reservationku where ID = '" & lv_menu.SelectedItems(0).SubItems(0).Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer
        Do While reader.Read
            lbl_id.Text = reader!RoomID
            lbl_email.Text = reader!Email
            lbl_gender.Text = reader!Gender
            lbl_nik.Text = reader!NIK
            lbl_phone.Text = reader!PhoneNumber
            lbl_name.Text = reader!Costumer
            lbl_id_booking.Text = reader!BookingCode
            i = i + +1
        Loop
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        konek_db()
        Dim update As New SqlClient.SqlCommand("update Room set Status = 'Sudah Check In' where ID = '" & lbl_id.Text & "'", koneksi)
        Try
            update.ExecuteNonQuery()
            MsgBox("Berhasil Check In", MsgBoxStyle.Information)
            tampildata()
            bersihteks()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub lbl_back_Click(sender As Object, e As EventArgs) Handles lbl_back.Click
        Me.Close()
    End Sub
End Class