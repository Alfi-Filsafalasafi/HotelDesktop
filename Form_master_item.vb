Public Class Form_master_item
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
        txt_compensation.Text = ""
        txt_cari.Text = ""
        txt_nama.Text = ""
        txt_request.Text = ""

    End Sub

    Sub aksesteks(akses As Boolean)
        txt_compensation.Enabled = akses
        txt_nama.Enabled = akses
        txt_request.Enabled = akses

    End Sub

    Sub tampildata()
        lv_menu.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from Item", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer
        Do While reader.Read
            lv_menu.Items.Add(reader!ID)
            lv_menu.Items(i).SubItems.Add(reader!Name)
            lv_menu.Items(i).SubItems.Add(reader!RequestPrice)
            lv_menu.Items(i).SubItems.Add(reader!CompensationFee)

            i = i + +1
        Loop
    End Sub
    Private Sub Form_master_item_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub Form_master_item_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        buttonawal()
        tampildata()
        bersihteks()
        aksesteks(False)
    End Sub

    Private Sub btn_batal_Click(sender As Object, e As EventArgs) Handles btn_batal.Click
        buttonawal()
        tampildata()
        bersihteks()
        aksesteks(False)
    End Sub

    Private Sub lv_menu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_menu.SelectedIndexChanged

    End Sub

    Private Sub lv_menu_MouseClick(sender As Object, e As MouseEventArgs) Handles lv_menu.MouseClick
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from Item where ID = '" & lv_menu.SelectedItems(0).SubItems(0).Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer
        Do While reader.Read
            lbl_id.Text = reader!ID
            txt_nama.Text = reader!Name
            txt_request.Text = reader!RequestPrice
            txt_compensation.Text = reader!CompensationFee

            i = i + +1
        Loop

        btn_tambah.Enabled = False
        btn_ubah.Enabled = True
        btn_simpan.Enabled = False
        btn_hapus.Enabled = True
        btn_batal.Enabled = True
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
                MsgBox("data gagal di simpan karena  " + ex.Message, MsgBoxStyle.Critical)
            End Try
        Else

        End If
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        If txt_compensation.Text = "" Or txt_nama.Text = "" Or txt_request.Text = "" Then
            MsgBox("data belum lengkap", MsgBoxStyle.Critical)
        Else

            If aksi = "T" Then
                konek_db()
                Dim tambah As New SqlClient.SqlCommand("insert into Item values ('" & txt_nama.Text & "', '" & txt_request.Text &
                                                       "', '" & txt_compensation.Text & "')", koneksi)

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
                Dim ubah As New SqlClient.SqlCommand("update Item set Name = '" & txt_nama.Text & "' , RequestPrice = '" & txt_request.Text &
                                                     "', CompensationFee = '" & txt_compensation.Text & "' where ID = '" & lbl_id.Text & "'", koneksi)

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

    Private Sub txt_cari_TextChanged(sender As Object, e As EventArgs) Handles txt_cari.TextChanged
        lv_menu.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from Item where Name LIKE '%" & txt_cari.Text & "%'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer
        Do While reader.Read
            lv_menu.Items.Add(reader!ID)
            lv_menu.Items(i).SubItems.Add(reader!Name)
            lv_menu.Items(i).SubItems.Add(reader!RequestPrice)
            lv_menu.Items(i).SubItems.Add(reader!CompensationFee)
            i = i + +1
        Loop
    End Sub

    Private Sub txt_request_TextChanged(sender As Object, e As EventArgs) Handles txt_request.TextChanged

    End Sub

    Private Sub txt_request_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_request.KeyPress
        Dim kata As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse kata = Keys.Back) Then
            kata = 0
        Else
            e.Handled = CBool(kata)
        End If
    End Sub

    Private Sub txt_compensation_TextChanged(sender As Object, e As EventArgs) Handles txt_compensation.TextChanged

    End Sub

    Private Sub txt_compensation_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_compensation.KeyPress
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
End Class