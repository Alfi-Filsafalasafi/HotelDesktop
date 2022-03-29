Public Class Form__master_room
    Dim aksi As String
    Sub buttonawal()
        btn_tambah.Enabled = True
        btn_ubah.Enabled = False
        btn_simpan.Enabled = False
        btn_hapus.Enabled = False
        btn_batal.Enabled = False
        lv_menu.Enabled = True
    End Sub

    Sub bersihteks()
        txt_desc.Text = ""
        txt_cari.Text = ""
        txt_number.Text = ""
        txt_room_floor.Text = ""
        lbl_id_type.Text = ""

    End Sub

    Sub aksesteks(akses As Boolean)
        txt_desc.Enabled = akses
        txt_number.Enabled = akses
        txt_room_floor.Enabled = akses
        cb_type_room.Enabled = akses
    End Sub

    Sub tampildata()
        lv_menu.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_room", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer
        Do While reader.Read
            lv_menu.Items.Add(reader!ID)
            lv_menu.Items(i).SubItems.Add(reader!RoomNumber)
            lv_menu.Items(i).SubItems.Add(reader!Name)
            lv_menu.Items(i).SubItems.Add(reader!RoomFloor)
            lv_menu.Items(i).SubItems.Add(reader!Description)

            i = i + +1
        Loop
    End Sub

    Sub tampiltype()
        cb_type_room.Items.Clear()
        cb_searc_room.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from RoomType", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Do While reader.Read
            cb_type_room.Items.Add(reader("Name"))
            cb_searc_room.Items.Add(reader("Name"))

        Loop
    End Sub

    Sub pemilihan()
        If txt_cari.Text = "" And cb_searc_room.Text = "" Then
            tampildata()
        End If
        If txt_cari.Text = "" And cb_searc_room.Text <> "" Then
            lv_menu.Items.Clear()
            konek_db()
            Dim tampil As New SqlClient.SqlCommand("select * from v_room where Name = '" & cb_searc_room.Text & "'", koneksi)
            Dim reader As SqlClient.SqlDataReader
            reader = tampil.ExecuteReader
            Dim i As Integer
            Do While reader.Read
                lv_menu.Items.Add(reader!ID)
                lv_menu.Items(i).SubItems.Add(reader!RoomNumber)
                lv_menu.Items(i).SubItems.Add(reader!Name)
                lv_menu.Items(i).SubItems.Add(reader!RoomFloor)
                lv_menu.Items(i).SubItems.Add(reader!Description)

                i = i + +1
            Loop
        End If
        If txt_cari.Text <> "" And cb_searc_room.Text = "" Then
            lv_menu.Items.Clear()
            konek_db()
            Dim tampil As New SqlClient.SqlCommand("select * from v_room where RoomNumber LIKE '%" & txt_cari.Text & "%'", koneksi)
            Dim reader As SqlClient.SqlDataReader
            reader = tampil.ExecuteReader
            Dim i As Integer
            Do While reader.Read
                lv_menu.Items.Add(reader!ID)
                lv_menu.Items(i).SubItems.Add(reader!RoomNumber)
                lv_menu.Items(i).SubItems.Add(reader!Name)
                lv_menu.Items(i).SubItems.Add(reader!RoomFloor)
                lv_menu.Items(i).SubItems.Add(reader!Description)

                i = i + +1
            Loop

        End If
        If txt_cari.Text <> "" And cb_searc_room.Text <> "" Then
            lv_menu.Items.Clear()
            konek_db()
            Dim tampil As New SqlClient.SqlCommand("select * from v_room where RoomNumber LIKE '%" & txt_cari.Text & "%' and Name = '" & cb_searc_room.Text & "'", koneksi)
            Dim reader As SqlClient.SqlDataReader
            reader = tampil.ExecuteReader
            Dim i As Integer
            Do While reader.Read
                lv_menu.Items.Add(reader!ID)
                lv_menu.Items(i).SubItems.Add(reader!RoomNumber)
                lv_menu.Items(i).SubItems.Add(reader!Name)
                lv_menu.Items(i).SubItems.Add(reader!RoomFloor)
                lv_menu.Items(i).SubItems.Add(reader!Description)

                i = i + +1
            Loop
        End If
    End Sub
    Private Sub Form__master_room_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        aksi = "T"
        aksesteks(True)
        btn_tambah.Enabled = False
        btn_ubah.Enabled = False
        btn_simpan.Enabled = True
        btn_hapus.Enabled = False
        btn_batal.Enabled = True
        lv_menu.Enabled = False
    End Sub

    Private Sub btn_ubah_Click(sender As Object, e As EventArgs) Handles btn_ubah.Click
        aksi = "U"
        aksesteks(True)
        btn_tambah.Enabled = False
        btn_ubah.Enabled = False
        btn_simpan.Enabled = True
        btn_hapus.Enabled = False
        btn_batal.Enabled = True
        lv_menu.Enabled = False
    End Sub

    Private Sub lbl_back_Click(sender As Object, e As EventArgs) Handles lbl_back.Click
        Me.Close()

    End Sub

    Private Sub txt_nama_TextChanged(sender As Object, e As EventArgs) Handles txt_number.TextChanged

    End Sub

    Private Sub txt_nama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_number.KeyPress
        Dim kata As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse kata = Keys.Back) Then
            kata = 0
        Else
            e.Handled = CBool(kata)
        End If
    End Sub

    Private Sub txt_room_price_TextChanged(sender As Object, e As EventArgs) Handles txt_room_floor.TextChanged

    End Sub

    Private Sub txt_room_price_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_room_floor.KeyPress
        Dim kata As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse kata = Keys.Back) Then
            kata = 0
        Else
            e.Handled = CBool(kata)
        End If
    End Sub

    Private Sub Form__master_room_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        buttonawal()
        tampildata()
        bersihteks()
        aksesteks(False)
        tampiltype()
    End Sub

    Private Sub btn_batal_Click(sender As Object, e As EventArgs) Handles btn_batal.Click
        buttonawal()
        tampildata()
        bersihteks()
        aksesteks(False)
        tampiltype()
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        Dim message As Integer
        message = MsgBox("apakah anda yakin akan menghapus data ini ?", MsgBoxStyle.YesNo)
        If message = DialogResult.Yes Then
            konek_db()
            Dim hapus As New SqlClient.SqlCommand("delete from Room where ID = '" & lbl_id.Text & "'", koneksi)
            Try
                hapus.ExecuteNonQuery()
                MsgBox("data berhasil di hapus", MsgBoxStyle.Information)
                buttonawal()
                tampildata()
                bersihteks()
                aksesteks(False)
            Catch ex As Exception
                MsgBox("data gagal di simpan karena  " + ex.Message, MsgBoxStyle.Critical)
            End Try
        Else

        End If
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        If txt_desc.Text = "" Or txt_number.Text = "" Or txt_room_floor.Text = "" Or lbl_id_type.Text = "" Then
            MsgBox("data belum lengkap", MsgBoxStyle.Critical)
        Else

            If aksi = "T" Then
                konek_db()
                Dim tambah As New SqlClient.SqlCommand("insert into Room values ('" & lbl_id_type.Text & "','" & txt_number.Text &
                                                       "', '" & txt_room_floor.Text & "', '" & txt_desc.Text & "', 'Tidak Terpakai')", koneksi)

                Try
                    tambah.ExecuteNonQuery()
                    MsgBox("data berhasil di tambah", MsgBoxStyle.Information)
                    buttonawal()
                    tampildata()
                    bersihteks()
                    tampiltype()
                    aksesteks(False)
                Catch ex As Exception
                    MsgBox("data gagal di tambah karena  " + ex.Message, MsgBoxStyle.Critical)
                End Try
            End If
            If aksi = "U" Then
                konek_db()
                Dim ubah As New SqlClient.SqlCommand("update Room set RoomTypeID = '" & lbl_id_type.Text & "' , RoomNumber = '" & txt_number.Text &
                                                     "', RoomFloor = '" & txt_room_floor.Text & "' , Description = '" & txt_desc.Text & "' where ID = '" & lbl_id.Text & "'", koneksi)

                Try
                    ubah.ExecuteNonQuery()
                    MsgBox("data berhasil di ubah", MsgBoxStyle.Information)
                    buttonawal()
                    tampiltype()
                    tampildata()
                    bersihteks()
                    aksesteks(False)
                Catch ex As Exception
                    MsgBox("data gagal di ubah karena  " + ex.Message, MsgBoxStyle.Critical)
                End Try
            End If
        End If
    End Sub

    Private Sub lv_menu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_menu.SelectedIndexChanged

    End Sub

    Private Sub lv_menu_MouseClick(sender As Object, e As MouseEventArgs) Handles lv_menu.MouseClick
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_room where ID = '" & lv_menu.SelectedItems(0).SubItems(0).Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer
        Do While reader.Read
            lbl_id.Text = reader!ID
            txt_desc.Text = reader!Description
            txt_number.Text = reader!RoomNumber
            txt_room_floor.Text = reader!RoomFloor
            cb_type_room.Text = reader!Name
            lbl_id_type.Text = reader!RoomTypeID

        Loop

        btn_tambah.Enabled = False
        btn_ubah.Enabled = True
        btn_simpan.Enabled = False
        btn_hapus.Enabled = True
        btn_batal.Enabled = True
    End Sub

    Private Sub cb_type_room_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_type_room.SelectedIndexChanged

    End Sub

    Private Sub cb_type_room_TextChanged(sender As Object, e As EventArgs) Handles cb_type_room.TextChanged
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select ID from RoomType where Name = '" & cb_type_room.Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        If cb_type_room.Text = "" Then
            lbl_id_type.Text = ""
        End If
        While reader.Read
            lbl_id_type.Text = reader!ID
        End While
    End Sub

    Private Sub txt_cari_TextChanged(sender As Object, e As EventArgs) Handles txt_cari.TextChanged
        pemilihan()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txt_cari.Text = ""
        tampiltype()
        tampildata()
    End Sub

    Private Sub cb_type_room_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cb_type_room.KeyPress

    End Sub

    Private Sub txt_cari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cari.KeyPress
        Dim kata As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse kata = Keys.Back) Then
            kata = 0
        Else
            e.Handled = CBool(kata)
        End If
    End Sub

    Private Sub cb_searc_room_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_searc_room.SelectedIndexChanged

    End Sub

    Private Sub cb_searc_room_TextChanged(sender As Object, e As EventArgs) Handles cb_searc_room.TextChanged
        pemilihan()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class