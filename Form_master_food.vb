Imports System.IO
Public Class Form_master_food
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
        txt_nama.Text = ""
        txt_cari.Text = ""
        txt_price.Text = ""
        txt_photo.Text = ""
        cb_type.Text = ""
        pc_me.Image = Nothing
    End Sub

    Sub aksesteks(akses As Boolean)
        txt_nama.Enabled = akses
        txt_price.Enabled = akses
        cb_type.Enabled = akses
        btn_upload.Enabled = akses
    End Sub

    Sub tampildata()
        lv_menu.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from FoodAndDrinks", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer
        Do While reader.Read
            lv_menu.Items.Add(reader!ID)
            lv_menu.Items(i).SubItems.Add(reader!Name)
            lv_menu.Items(i).SubItems.Add(reader!Type)
            lv_menu.Items(i).SubItems.Add(reader!Price)

            i = i + +1
        Loop
    End Sub

    Sub pemilihan()
        If txt_cari.Text = "" And cb_search_type.Text = "" Then
            tampildata()
        End If
        If txt_cari.Text <> "" And cb_search_type.Text = "" Then
            lv_menu.Items.Clear()
            konek_db()
            Dim tampil As New SqlClient.SqlCommand("select * from FoodAndDrinks where Name LIKE '%" & txt_cari.Text & "%'", koneksi)
            Dim reader As SqlClient.SqlDataReader
            reader = tampil.ExecuteReader
            Dim i As Integer
            Do While reader.Read
                lv_menu.Items.Add(reader!ID)
                lv_menu.Items(i).SubItems.Add(reader!Name)
                lv_menu.Items(i).SubItems.Add(reader!Type)
                lv_menu.Items(i).SubItems.Add(reader!Price)
                i = i + +1
            Loop
        End If
        If txt_cari.Text = "" And cb_search_type.Text <> "" Then
            lv_menu.Items.Clear()
            konek_db()
            Dim tampil As New SqlClient.SqlCommand("select * from FoodAndDrinks where Type LIKE '%" & cb_search_type.Text & "%'", koneksi)
            Dim reader As SqlClient.SqlDataReader
            reader = tampil.ExecuteReader
            Dim i As Integer
            Do While reader.Read
                lv_menu.Items.Add(reader!ID)
                lv_menu.Items(i).SubItems.Add(reader!Name)
                lv_menu.Items(i).SubItems.Add(reader!Type)
                lv_menu.Items(i).SubItems.Add(reader!Price)
                i = i + +1
            Loop
        End If
        If txt_cari.Text <> "" And cb_search_type.Text <> "" Then
            lv_menu.Items.Clear()
            konek_db()
            Dim tampil As New SqlClient.SqlCommand("select * from FoodAndDrinks where Name LIKE '%" & txt_cari.Text & "%' and Type LIKE '%" & cb_search_type.Text & "%'", koneksi)
            Dim reader As SqlClient.SqlDataReader
            reader = tampil.ExecuteReader
            Dim i As Integer
            Do While reader.Read
                lv_menu.Items.Add(reader!ID)
                lv_menu.Items(i).SubItems.Add(reader!Name)
                lv_menu.Items(i).SubItems.Add(reader!Type)
                lv_menu.Items(i).SubItems.Add(reader!Price)
                i = i + +1
            Loop
        End If
    End Sub

    Private Sub Form_master_food_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txt_cari_TextChanged(sender As Object, e As EventArgs) Handles txt_cari.TextChanged
        pemilihan()
    End Sub

    Private Sub lv_menu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_menu.SelectedIndexChanged

    End Sub

    Private Sub Form_master_food_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        buttonawal()
        tampildata()
        bersihteks()
        aksesteks(False)
    End Sub

    Private Sub lv_menu_MouseClick(sender As Object, e As MouseEventArgs) Handles lv_menu.MouseClick
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from FoodAndDrinks where ID = '" & lv_menu.SelectedItems(0).SubItems(0).Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer
        Do While reader.Read
            lbl_id.Text = reader!ID
            txt_nama.Text = reader!Name
            cb_type.Text = reader!Type
            txt_price.Text = reader!Price
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

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        Dim message As Integer
        message = MsgBox("apakah anda yakin akan akan menghapus data ini?", MsgBoxStyle.YesNo)
        If message = DialogResult.Yes Then
            konek_db()
            Dim hapus As New SqlClient.SqlCommand("delete from Item where ID = '" & lbl_id.Text & "'", koneksi)
            Try
                hapus.ExecuteNonQuery()
                MsgBox("data berhasil di hapus", MsgBoxStyle.Information)
                buttonawal()
                tampildata()
                bersihteks()
                aksesteks(False)
            Catch ex As Exception
                MsgBox("data gagal di hapus karena  " + ex.Message, MsgBoxStyle.Critical)
            End Try
        Else

        End If
    End Sub

    Private Sub btn_upload_Click(sender As Object, e As EventArgs) Handles btn_upload.Click
        open_photo.ShowDialog()
        If open_photo.FileName = "" Then Exit Sub
        pc_me.ImageLocation = open_photo.FileName
        txt_photo.Text = open_photo.FileName
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        If txt_price.Text = "" Or txt_nama.Text = "" Or cb_type.Text = "" Or txt_photo.Text = "" Then
            MsgBox("data belum lengkap", MsgBoxStyle.Critical)
        Else
            Dim ms As New MemoryStream
            pc_me.Image.Save(ms, pc_me.Image.RawFormat)
            If aksi = "T" Then
                konek_db()
                Dim tambah As New SqlClient.SqlCommand("insert into FoodAndDrinks values ('" & txt_nama.Text & "', '" & cb_type.Text &
                                                       "', '" & txt_price.Text & "', @image)", koneksi)
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
                Dim ubah As New SqlClient.SqlCommand("update FoodAndDrinks set Name = '" & txt_nama.Text & "' , Type = '" & cb_type.Text &
                                                     "', Price = '" & txt_price.Text & "' , photo=@image where ID = '" & lbl_id.Text & "'", koneksi)
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

    Private Sub lbl_back_Click(sender As Object, e As EventArgs) Handles lbl_back.Click
        Me.Close()

    End Sub

    Private Sub txt_price_TextChanged(sender As Object, e As EventArgs) Handles txt_price.TextChanged

    End Sub

    Private Sub txt_price_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_price.KeyPress
        Dim kata As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse kata = Keys.Back) Then
            kata = 0
        Else
            e.Handled = CBool(kata)
        End If
    End Sub

    Private Sub btn_batal_Click(sender As Object, e As EventArgs) Handles btn_batal.Click
        buttonawal()
        tampildata()
        bersihteks()
        aksesteks(False)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txt_cari.Text = ""
        cb_search_type.Items.Clear()
        cb_search_type.Items.Add("D")
        cb_search_type.Items.Add("F")
        tampildata()


    End Sub

    Private Sub cb_search_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_search_type.SelectedIndexChanged

    End Sub

    Private Sub cb_search_type_TextChanged(sender As Object, e As EventArgs) Handles cb_search_type.TextChanged
        pemilihan()
    End Sub
End Class