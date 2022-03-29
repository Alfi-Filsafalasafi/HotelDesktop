Imports System.IO
Public Class Form_room_type
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
        txt_capacity.Text = ""
        txt_cari.Text = ""
        txt_nama.Text = ""
        txt_photo.Text = ""
        txt_room_price.Text = ""
        pc_me.Image = Nothing
    End Sub

    Sub aksesteks(akses As Boolean)
        txt_capacity.Enabled = akses
        txt_nama.Enabled = akses
        txt_room_price.Enabled = akses
        btn_upload.Enabled = akses
    End Sub

    Sub tampildata()
        lv_menu.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from RoomType", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer
        Do While reader.Read
            lv_menu.Items.Add(reader!ID)
            lv_menu.Items(i).SubItems.Add(reader!Name)
            lv_menu.Items(i).SubItems.Add(reader!Capacity)
            lv_menu.Items(i).SubItems.Add(reader!RoomPrice)

            i = i + +1
        Loop
    End Sub
    Private Sub Form_room_type_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub Form_room_type_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        buttonawal()
        tampildata()
        bersihteks()
        aksesteks(False)
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

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub lv_menu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_menu.SelectedIndexChanged

    End Sub

    Private Sub lv_menu_MouseClick(sender As Object, e As MouseEventArgs) Handles lv_menu.MouseClick
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from RoomType where ID = '" & lv_menu.SelectedItems(0).SubItems(0).Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer
        Do While reader.Read
            lbl_id.Text = reader!ID
            txt_capacity.Text = reader!Capacity
            txt_nama.Text = reader!Name
            txt_room_price.Text = reader!RoomPrice
            txt_photo.Text = reader!photo.ToString
            Dim img() As Byte
            img = reader!Photo
            Dim ms As New MemoryStream(img)
            pc_me.Image = Image.FromStream(ms)
            i = i + +1
        Loop

        btn_tambah.Enabled = False
        btn_ubah.Enabled = True
        btn_simpan.Enabled = False
        btn_hapus.Enabled = True
        btn_batal.Enabled = True
    End Sub

    Private Sub btn_upload_Click(sender As Object, e As EventArgs) Handles btn_upload.Click
        open_photo.ShowDialog()
        If open_photo.FileName = "" Then Exit Sub
        pc_me.ImageLocation = open_photo.FileName
        txt_photo.Text = open_photo.FileName
    End Sub

    Private Sub btn_batal_Click(sender As Object, e As EventArgs) Handles btn_batal.Click
        buttonawal()
        tampildata()
        bersihteks()
        aksesteks(False)
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        Dim message As Integer
        message = MsgBox("apakah anda yakin akan akan menghapus data ini?", MsgBoxStyle.YesNo)
        If message = DialogResult.Yes Then
            konek_db()
            Dim hapus As New SqlClient.SqlCommand("delete from RoomType where ID = '" & lbl_id.Text & "'", koneksi)
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
        If txt_capacity.Text = "" Or txt_nama.Text = "" Or txt_room_price.Text = "" Or txt_photo.Text = "" Then
            MsgBox("data belum lengkap", MsgBoxStyle.Critical)
        Else
            Dim ms As New MemoryStream
            pc_me.Image.Save(ms, pc_me.Image.RawFormat)
            If aksi = "T" Then
                konek_db()
                Dim tambah As New SqlClient.SqlCommand("insert into RoomType values ('" & txt_nama.Text & "', '" & txt_capacity.Text &
                                                       "', '" & txt_room_price.Text & "', @image)", koneksi)
                tambah.Parameters.Add("@image", SqlDbType.Image).Value = ms.ToArray
                Try
                    tambah.ExecuteNonQuery()
                    MsgBox("data berhasil di tambah", MsgBoxStyle.Information)
                    buttonawal()
                    tampildata()
                    bersihteks()
                    aksesteks(False)
                Catch ex As Exception
                    MsgBox("data gagal di tambah karena  " + ex.Message, MsgBoxStyle.Critical)
                End Try
            End If
            If aksi = "U" Then
                konek_db()
                Dim ubah As New SqlClient.SqlCommand("update RoomType set Name = '" & txt_nama.Text & "' , Capacity = '" & txt_capacity.Text &
                                                     "', RoomPrice = '" & txt_room_price.Text & "' , photo=@image where ID = '" & lbl_id.Text & "'", koneksi)
                ubah.Parameters.Add("@image", SqlDbType.Image).Value = ms.ToArray
                Try
                    ubah.ExecuteNonQuery()
                    MsgBox("data berhasil di ubah", MsgBoxStyle.Information)
                    buttonawal()
                    tampildata()
                    bersihteks()
                    aksesteks(False)
                Catch ex As Exception
                    MsgBox("data gagal di ubah karena  " + ex.Message, MsgBoxStyle.Critical)
                End Try
            End If
        End If
    End Sub

    Private Sub txt_room_price_TextChanged(sender As Object, e As EventArgs) Handles txt_room_price.TextChanged

    End Sub

    Private Sub txt_room_price_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_room_price.KeyPress
        Dim kata As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse kata = Keys.Back) Then
            kata = 0
        Else
            e.Handled = CBool(kata)
        End If
    End Sub

    Private Sub txt_capacity_TextChanged(sender As Object, e As EventArgs) Handles txt_capacity.TextChanged

    End Sub

    Private Sub txt_capacity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_capacity.KeyPress
        Dim kata As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse kata = Keys.Back) Then
            kata = 0
        Else
            e.Handled = CBool(kata)
        End If
    End Sub

    Private Sub txt_cari_TextChanged(sender As Object, e As EventArgs) Handles txt_cari.TextChanged
        lv_menu.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from RoomType where Name LIKE '%" & txt_cari.Text & "%'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer
        Do While reader.Read
            lv_menu.Items.Add(reader!ID)
            lv_menu.Items(i).SubItems.Add(reader!Name)
            lv_menu.Items(i).SubItems.Add(reader!Capacity)
            lv_menu.Items(i).SubItems.Add(reader!RoomPrice)

            i = i + +1
        Loop
    End Sub

    Private Sub lbl_back_Click(sender As Object, e As EventArgs) Handles lbl_back.Click
        Me.Close()

    End Sub
End Class