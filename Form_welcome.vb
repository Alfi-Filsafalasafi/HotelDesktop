Public Class Form_welcome
    Sub tampil_data()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from Job", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Do While reader.Read
            cb_login.Items.Add(reader("Name"))
        Loop


    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        tampil_data()
    End Sub

    Private Sub btn_lanjut_Click(sender As Object, e As EventArgs) Handles btn_lanjut.Click
        If cb_login.Text = "" Then
            MsgBox("pilih data terlebih dahulu", MsgBoxStyle.Critical)
        Else
            Me.Visible = False
            Dim form_loginku As Form_login = New Form_login()
            form_loginku.lbl_hak_akses.Text = cb_login.Text
            form_loginku.Show()
        End If

    End Sub

    Private Sub Form_welcome_Closed(sender As Object, e As EventArgs) Handles Me.Closed

    End Sub

    Private Sub Form_welcome_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub
End Class
