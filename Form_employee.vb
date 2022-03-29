Public Class Form_employee
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim message As Integer
        message = MsgBox("apakah anda yakin akan keluar ?", MsgBoxStyle.YesNo)
        If message = DialogResult.Yes Then
            Me.Close()
            Dim form_welcome As Form_welcome = New Form_welcome
            form_welcome.Visible = True
        Else

        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim message As Integer
        message = MsgBox("apakah anda yakin akan keluar dari aplikasi ?", MsgBoxStyle.YesNo)
        If message = DialogResult.Yes Then
            Me.Close()
            End
        Else

        End If
    End Sub

    Private Sub btn_room_type_Click(sender As Object, e As EventArgs)
        Dim type As Form_room_type = New Form_room_type
        type.Show()
    End Sub

    Private Sub btn_room_Click(sender As Object, e As EventArgs)
        Dim room As Form__master_room = New Form__master_room
        room.Show()
    End Sub

    Private Sub btn_item_Click(sender As Object, e As EventArgs)
        Dim item As Form_master_item = New Form_master_item
        item.Show()
    End Sub

    Private Sub btn_lap_jumlah_Click(sender As Object, e As EventArgs) Handles btn_reservasi.Click
        Dim s As Form_reservation = New Form_reservation
        s.Show()
    End Sub

    Private Sub btn_check_in_Click(sender As Object, e As EventArgs) Handles btn_check_in.Click
        Dim s As Form_check_in = New Form_check_in
        s.Show()
    End Sub

    Private Sub btn_reques_Click(sender As Object, e As EventArgs) Handles btn_reques.Click
        Dim s As Form_request_additional = New Form_request_additional
        s.Show()

    End Sub

    Private Sub btn_check_out_Click(sender As Object, e As EventArgs) Handles btn_check_out.Click
        Dim s As Form_check_out = New Form_check_out
        s.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim s As Form_report = New Form_report
        s.Show()
    End Sub
End Class