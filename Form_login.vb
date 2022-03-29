Public Class Form_login
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles ck_password.CheckedChanged
        If ck_password.CheckState = CheckState.Checked Then
            txt_password.UseSystemPasswordChar = True
        Else
            txt_password.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If txt_password.Text = "" Or txt_username.Text = "" Then
            MsgBox("username atau password kosong", MsgBoxStyle.Critical)
        Else
            If lbl_hak_akses.Text = "Admin" Then
                konek_db()
                Dim tampil As New SqlClient.SqlCommand("select * from v_employee where username = '" & txt_username.Text & "' and password = '" & txt_password.Text & "' and Job = '" & lbl_hak_akses.Text & "'", koneksi)
                Dim reader As SqlClient.SqlDataReader
                reader = tampil.ExecuteReader
                Try
                    reader.Read()
                    Dim form_admin As Form_admin = New Form_admin
                    form_admin.lbl_name_admin.Text = reader!Name
                    Me.Visible = False
                    form_admin.Show()
                Catch ex As Exception
                    MsgBox("Username atau password anda salah", MsgBoxStyle.Critical)
                End Try




            End If
            If lbl_hak_akses.Text = "Front Office" Then
                konek_db()
                Dim tampil As New SqlClient.SqlCommand("select * from v_employee where username = '" & txt_username.Text & "' and password = '" & txt_password.Text & "' and Job = '" & lbl_hak_akses.Text & "'", koneksi)
                Dim reader As SqlClient.SqlDataReader
                reader = tampil.ExecuteReader
                Try
                    reader.Read()

                    Dim form_employee As Form_employee = New Form_employee

                    form_employee.lbl_name.Text = reader!Name

                    Me.Visible = False
                    form_employee.Show()


                Catch ex As Exception
                    MsgBox("Username atau password anda salah", MsgBoxStyle.Critical)
                End Try

            End If

        End If
    End Sub

    Private Sub lbl_back_Click(sender As Object, e As EventArgs) Handles lbl_back.Click
        Me.Close()
        Dim form_welcome As Form_welcome = New Form_welcome
        form_welcome.Visible = True
    End Sub
End Class