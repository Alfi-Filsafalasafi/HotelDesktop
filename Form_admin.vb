Public Class Form_admin
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btn_log_out.Click
        Dim message As Integer
        message = MsgBox("apakah anda yakin akan keluar dari akun ini ?", MsgBoxStyle.YesNo)
        If message = DialogResult.Yes Then
            Me.Close()
            Dim form_welcome As Form_welcome = New Form_welcome
            form_welcome.Visible = True
        Else

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_food_drink.Click
        Dim food As Form_master_food = New Form_master_food
        food.Show()

    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Dim message As Integer
        message = MsgBox("apakah anda yakin akan keluar dari aplikasi ?", MsgBoxStyle.YesNo)
        If message = DialogResult.Yes Then

            Me.Close()
            End
        Else

        End If
    End Sub

    Private Sub btn_employee_Click(sender As Object, e As EventArgs) Handles btn_employee.Click

        Dim form_employee As Form_master_employee = New Form_master_employee
        form_employee.Show()
    End Sub

    Private Sub btn_item_Click(sender As Object, e As EventArgs) Handles btn_item.Click

        Dim form_item As Form_master_item = New Form_master_item
        form_item.Show()
    End Sub

    Private Sub btn_room_type_Click(sender As Object, e As EventArgs) Handles btn_room_type.Click

        Dim form_room_type As Form_room_type = New Form_room_type
        form_room_type.Show()
    End Sub

    Private Sub btn_room_Click(sender As Object, e As EventArgs) Handles btn_room.Click

        Dim form_room As Form__master_room = New Form__master_room
        form_room.Show()
    End Sub

    Private Sub btn_lap_jumlah_Click(sender As Object, e As EventArgs) Handles btn_lap_jumlah.Click
        Dim s As Form_report = New Form_report
        s.Show()
    End Sub
End Class