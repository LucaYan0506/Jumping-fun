Public Class book_form
    'get today date
    Dim curr_date As Date = Date.Now

    Dim current_tab As Integer = 0
    Private Sub show_days()
        'Find the first day of the month
        Dim first_day As Date = New Date(curr_date.Year, curr_date.Month, 1)

        'get total days of the month
        Dim total_days As Integer = Date.DaysInMonth(curr_date.Year, curr_date.Month)

        'get which day of the week is the first day of the month(so we know in where 1st day should be located)
        Dim DayOfWeek = first_day.DayOfWeek

        'generate empty_panel 
        For i = 1 To DayOfWeek - 1
            Dim empty_panel As New Panel
            empty_panel.Size = New Size(46, 39)

            Custom_Calendar.Controls.Add(empty_panel)
        Next

        'generate days of the month
        For i = 1 To total_days
            Dim label As New Label
            label.AutoSize = False
            label.Size = New Size(46, label.Height)
            label.TextAlign = ContentAlignment.MiddleCenter
            label.Text = i

            Dim available = New PictureBox
            available.BackColor = Color.Green

            Dim panel As New Panel
            panel.Size = New Size(46, 39)
            panel.Controls.Add(label)
            panel.Controls.Add(available)

            Custom_Calendar.Controls.Add(panel)
        Next


    End Sub

    Function booking_detail_validation() As Boolean
        Return True
    End Function

    Function party_detail_validation() As Boolean
        Return False
    End Function

    Private Sub save_booking_detail()

    End Sub

    Private Sub save_party_detail()

    End Sub

    Private Sub generate_receipt()

    End Sub

    Private Sub save_receipt()

    End Sub

    Private Sub clear_calendar()
        Custom_Calendar.Controls.Clear()
        Custom_Calendar.Controls.Add(Calender_date_container)
        Custom_Calendar.Controls.Add(Calendar_dayWeek)
    End Sub
    Private Sub Personal_detail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'init comboboxs
        ComboBox2.Items.Add(0)
        For i = 1 To 10
            ComboBox1.Items.Add(i * 6)
            ComboBox2.Items.Add(i * 5)
        Next

        Me.Size = New Size(407, 612)
        TabControl1.SelectedTab = TabPage1

        Calendar_date.Text = curr_date.ToString("MMMM") & " " & curr_date.Year
        show_days()
    End Sub
    Private Sub nxt_month_Click(sender As Object, e As EventArgs) Handles nxt_month.Click
        'clear calendar
        clear_calendar()
        'update date
        Dim next_month As Integer = curr_date.Month + 1
        Dim year As Integer = curr_date.Year
        If next_month > 12 Then
            year += 1
            next_month = next_month Mod 12
        End If
        curr_date = New Date(year, next_month, 1)

        'update calendar_date
        Calendar_date.Text = curr_date.ToString("MMMM") & " " & curr_date.Year
        show_days()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        Select Case sender.SelectedIndex
            Case 0
                Me.Size = New Size(407, 612)
            Case 1
                Me.Size = New Size(407, 394)
            Case 2
                Me.Size = New Size(407, 394)
            Case Else
                MsgBox("error")
        End Select
    End Sub

    Private Sub previous_month_Click(sender As Object, e As EventArgs) Handles previous_month.Click
        'clear calendar
        clear_calendar()
        'update date
        Dim previous_month As Integer = curr_date.Month - 1
        Dim year As Integer = curr_date.Year
        If previous_month <= 0 Then
            year -= 1
            previous_month = 12 - previous_month
        End If
        curr_date = New Date(year, previous_month, 1)

        'update calendar_date
        Calendar_date.Text = curr_date.ToString("MMMM") & " " & curr_date.Year
        show_days()
    End Sub

    Private Sub bck_to_home_Click(sender As Object, e As EventArgs) Handles bck_to_home.Click
        Dim main As New Main
        Me.Hide()
        main.Show()
    End Sub

    Private Sub nxt_tab_Click(sender As Object, e As EventArgs) Handles nxt_tab.Click
        TabControl1.SelectedTab = TabPage2
    End Sub

    Private Sub bck_btn_Click(sender As Object, e As EventArgs) Handles bck_btn.Click
        TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub nxt_btn_Click(sender As Object, e As EventArgs) Handles nxt_btn.Click
        TabControl1.SelectedTab = TabPage3
    End Sub

    Private Sub bck_btn2_Click(sender As Object, e As EventArgs) Handles bck_btn2.Click
        TabControl1.SelectedTab = TabPage2
    End Sub


    Private Sub TabControl1_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles TabControl1.Selecting
        'if user is trying to go to the next tab, check if the user completed the current_tab
        If current_tab < e.TabPageIndex Then
            Select Case current_tab
                Case 0
                    Select Case e.TabPageIndex
                        Case 1
                            If booking_detail_validation() = False Then
                                MsgBox("Please, complete booking detail")
                                e.Cancel = True
                            End If
                        Case 2
                            If booking_detail_validation() = False Or party_detail_validation() = False Then
                                MsgBox("Please, complete party detail")
                                e.Cancel = True
                            End If
                    End Select
                Case 1
                    If party_detail_validation() = False Then
                        MsgBox("Please, complete party detail")
                        e.Cancel = True
                    Else
                        generate_receipt()
                    End If
            End Select
        End If
        current_tab = e.TabPageIndex
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class