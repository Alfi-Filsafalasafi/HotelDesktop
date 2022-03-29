Public Class Form_costumer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txt_phone.Text = "" Or txt_email.Text = "" Or txt_gender.Text = "" Or txt_name.Text = "" Or txt_nik.Text = "" Or txt_tgl_lhir.Text = Date.Now Then
            MsgBox("Data belum lengkap", MsgBoxStyle.Critical)

        Else
            Dim message As Integer
            message = MsgBox("apakah anda yakin akan akan menambah data ini?", MsgBoxStyle.YesNo)
            If message = DialogResult.Yes Then
                konek_db()
                Dim tambah As New SqlClient.SqlCommand("insert into Costumer values ('" & txt_name.Text & "', '" & txt_nik.Text &
                                                       "', '" & txt_email.Text & "', '" & txt_gender.Text & "', '" & txt_phone.Text & "', '" & Format(txt_tgl_lhir.Value, "yyyy-MM-dd") & "')", koneksi)

                Try
                    tambah.ExecuteNonQuery()
                    MsgBox("data berhasil di tambah", MsgBoxStyle.Information)
                    Me.Close()
                    Dim reservation As Form_reservation = New Form_reservation
                    reservation.tampilcostumer()
                    reservation.Visible = True

                Catch ex As Exception
                    MsgBox("data gagal di hapus karena  " + ex.Message, MsgBoxStyle.Critical)
                End Try
            Else

            End If
        End If
    End Sub

    Private Sub txt_nik_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nik.KeyPress
        Dim kata As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse kata = Keys.Back) Then
            kata = 0
        Else
            e.Handled = CBool(kata)
        End If
    End Sub

    Private Sub txt_nik_TextChanged(sender As Object, e As EventArgs) Handles txt_nik.TextChanged

    End Sub

    Private Sub txt_phone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_phone.KeyPress
        Dim kata As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse kata = Keys.Back) Then
            kata = 0
        Else
            e.Handled = CBool(kata)
        End If
    End Sub

    Private Sub txt_phone_TextChanged(sender As Object, e As EventArgs) Handles txt_phone.TextChanged

    End Sub
End Class