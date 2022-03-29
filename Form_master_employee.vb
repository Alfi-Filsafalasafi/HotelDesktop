Imports System.IO
Public Class Form_master_employee
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
        txt_address.Text = ""
        txt_cari.Text = ""
        txt_name.Text = ""
        txt_photo.Text = ""
        txt_confirm_password.Text = ""
        pc_me.Image = Nothing
        txt_email.Text = ""
        txt_password.Text = ""
        txt_tgl_lhir.Text = Date.Now
        txt_username.Text = ""
    End Sub

    Sub aksesteks(akses As Boolean)
        txt_address.Enabled = akses
        txt_confirm_password.Enabled = akses
        txt_email.Enabled = akses
        txt_name.Enabled = akses
        cb_job.Enabled = akses
        txt_password.Enabled = akses
        txt_tgl_lhir.Enabled = akses
        txt_username.Enabled = akses
        btn_upload.Enabled = akses
    End Sub

    Sub tampildata()
        lv_menu.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_employee", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer
        Do While reader.Read
            lv_menu.Items.Add(reader!ID)
            lv_menu.Items(i).SubItems.Add(reader!Name)
            lv_menu.Items(i).SubItems.Add(reader!Username)
            lv_menu.Items(i).SubItems.Add(reader!Email)
            lv_menu.Items(i).SubItems.Add(reader!Address)
            lv_menu.Items(i).SubItems.Add(reader!Job)

            i = i + +1
        Loop
    End Sub
    Sub tampilJob()
        cb_job.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from Job", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Do While reader.Read
            cb_job.Items.Add(reader("Name"))
        Loop
    End Sub

    Private Sub Form_master_employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs)
        aksi = "T"
        btn_tambah.Enabled = False
        btn_ubah.Enabled = False
        btn_simpan.Enabled = True
        btn_hapus.Enabled = False
        btn_batal.Enabled = True
        lv_menu.Enabled = False
    End Sub

    Private Sub btn_ubah_Click(sender As Object, e As EventArgs)
        aksi = "U"
        btn_tambah.Enabled = False
        btn_ubah.Enabled = False
        btn_simpan.Enabled = True
        btn_hapus.Enabled = False
        btn_batal.Enabled = True
        lv_menu.Enabled = False
    End Sub

    Private Sub Form_master_employee_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        buttonawal()
        tampildata()
        bersihteks()
        aksesteks(False)
        tampilJob()
    End Sub

    Private Sub btn_batal_Click(sender As Object, e As EventArgs) Handles btn_batal.Click
        buttonawal()
        tampildata()
        bersihteks()
        aksesteks(False)
        tampilJob()
    End Sub

    Private Sub btn_tambah_Click_1(sender As Object, e As EventArgs) Handles btn_tambah.Click
        aksi = "T"
        aksesteks(True)
        btn_tambah.Enabled = False
        btn_ubah.Enabled = False
        btn_simpan.Enabled = True
        btn_hapus.Enabled = False
        btn_batal.Enabled = True
        lv_menu.Enabled = False
    End Sub

    Private Sub btn_ubah_Click_1(sender As Object, e As EventArgs) Handles btn_ubah.Click
        aksi = "U"
        aksesteks(True)
        btn_tambah.Enabled = False
        btn_ubah.Enabled = False
        btn_simpan.Enabled = True
        btn_hapus.Enabled = False
        btn_batal.Enabled = True
        lv_menu.Enabled = False
    End Sub

    Private Sub lv_menu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_menu.SelectedIndexChanged

    End Sub

    Private Sub lv_menu_MouseClick(sender As Object, e As MouseEventArgs) Handles lv_menu.MouseClick
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_employee where ID = '" & lv_menu.SelectedItems(0).SubItems(0).Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer
        Do While reader.Read
            lbl_id.Text = reader!ID
            txt_address.Text = reader!Address
            txt_password.Text = reader!Password
            txt_confirm_password.Text = reader!Password
            txt_email.Text = reader!Email
            txt_name.Text = reader!Name
            cb_job.Text = reader!Job
            txt_username.Text = reader!Username
            txt_tgl_lhir.Text = reader!DateOfBirth
            txt_photo.Text = reader!photo.ToString
            Dim img() As Byte
            img = reader!Photo
            Dim ms As New MemoryStream(img)
            pc_me.Image = Image.FromStream(ms)

        Loop

        btn_tambah.Enabled = False
        btn_ubah.Enabled = True
        btn_simpan.Enabled = False
        btn_hapus.Enabled = True
        btn_batal.Enabled = True
    End Sub

    Private Sub cb_job_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_job.SelectedIndexChanged

    End Sub

    Private Sub cb_job_TextChanged(sender As Object, e As EventArgs) Handles cb_job.TextChanged
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select ID from Job where Name = '" & cb_job.Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        If cb_job.Text = "" Then
            lbl_job.Text = ""
        End If
        While reader.Read
            lbl_job.Text = reader!ID
        End While
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        Dim message As Integer
        message = MsgBox("apakah anda yakin akan akan menghapus data ini?", MsgBoxStyle.YesNo)
        If message = DialogResult.Yes Then
            konek_db()
            Dim hapus As New SqlClient.SqlCommand("delete from employee where ID = '" & lbl_id.Text & "'", koneksi)
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

    Private Sub txt_cari_TextChanged(sender As Object, e As EventArgs) Handles txt_cari.TextChanged
        lv_menu.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_employee where Name LIKE '%" & txt_cari.Text & "%'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer
        Do While reader.Read
            lv_menu.Items.Add(reader!ID)
            lv_menu.Items(i).SubItems.Add(reader!Name)
            lv_menu.Items(i).SubItems.Add(reader!Username)
            lv_menu.Items(i).SubItems.Add(reader!Email)
            lv_menu.Items(i).SubItems.Add(reader!Address)
            lv_menu.Items(i).SubItems.Add(reader!Job)

            i = i + +1
        Loop
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        If txt_address.Text = "" Or txt_name.Text = "" Or txt_confirm_password.Text = "" Or txt_email.Text = "" Or txt_password.Text = "" Or txt_photo.Text = "" Or txt_username.Text = "" Then
            MsgBox("data belum lengkap", MsgBoxStyle.Critical)
        Else
            If txt_password.Text <> txt_confirm_password.Text Then
                MsgBox("confirmasi password tidak cocok")
            Else


                Dim ms As New MemoryStream
                pc_me.Image.Save(ms, pc_me.Image.RawFormat)
                If aksi = "T" Then
                    konek_db()
                    Dim tambah As New SqlClient.SqlCommand("insert into employee values ('" & txt_username.Text & "', '" & txt_password.Text &
                                                       "', '" & txt_name.Text & "','" & txt_email.Text & "', '" & txt_address.Text &
                                                       "', '" & Format(txt_tgl_lhir.Value, "yyyy-MM-dd") & "', '" & lbl_job.Text & "', @image)", koneksi)
                    tambah.Parameters.Add("@image", SqlDbType.Image).Value = ms.ToArray
                    Try
                        tambah.ExecuteNonQuery()
                        MsgBox("data berhasil di tambah", MsgBoxStyle.Information)
                        buttonawal()
                        tampilJob()
                        tampildata()
                        bersihteks()
                        aksesteks(False)
                    Catch ex As Exception
                        MsgBox("data gagal di tambah karena  " + ex.Message, MsgBoxStyle.Critical)
                    End Try
                End If
                If aksi = "U" Then
                    konek_db()
                    Dim ubah As New SqlClient.SqlCommand("update employee Set Name = '" & txt_name.Text & "' , Username = '" & txt_username.Text &
                                                     "', Password = '" & txt_password.Text & "' , photo=@image, Email = '" & txt_email.Text & "' , Address = '" & txt_address.Text &
                                                     "', DateOfBirth = '" & Format(txt_tgl_lhir.Value, "yyyy-MM-dd") & "', JOBID = '" & lbl_job.Text & "' where ID = '" & lbl_id.Text & "'", koneksi)
                    ubah.Parameters.Add("@image", SqlDbType.Image).Value = ms.ToArray
                    Try
                        ubah.ExecuteNonQuery()
                        MsgBox("data berhasil di ubah", MsgBoxStyle.Information)
                        buttonawal()
                        tampildata()
                        tampilJob()
                        bersihteks()
                        aksesteks(False)
                    Catch ex As Exception
                        MsgBox("data gagal di ubah karena  " + ex.Message, MsgBoxStyle.Critical)
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub btn_upload_Click(sender As Object, e As EventArgs) Handles btn_upload.Click
        open_photo.ShowDialog()
        If open_photo.FileName = "" Then Exit Sub
        pc_me.ImageLocation = open_photo.FileName
        txt_photo.Text = open_photo.FileName
    End Sub

    Private Sub txt_name_TextChanged(sender As Object, e As EventArgs) Handles txt_name.TextChanged

    End Sub

    Private Sub txt_name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_name.KeyPress
        Dim kata As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[a-z,A-Z, ']" OrElse kata = Keys.Back) Then
            kata = 0
        Else
            e.Handled = CBool(kata)
        End If
    End Sub

    Private Sub lbl_back_Click(sender As Object, e As EventArgs) Handles lbl_back.Click
        Me.Close()

    End Sub
End Class