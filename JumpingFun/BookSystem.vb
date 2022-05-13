Public Class BookSystem
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

        'when dayOfweek is 0 means that it is sunday which is the 7th cell in the custom calendar
        If DayOfWeek = 0 Then
            DayOfWeek = 7
        End If

        'generate empty_panel 
        For i = 1 To DayOfWeek - 1
            Dim empty_panel As New Panel
            empty_panel.Size = New Size(46, 39)

            Custom_Calendar.Controls.Add(empty_panel)
        Next

        'generate days of the month
        For i = 1 To total_days
            Dim label As New Label
            label.Name = i
            label.AutoSize = False
            label.Size = New Size(46, label.Height)
            label.TextAlign = ContentAlignment.MiddleCenter
            label.Text = i
            AddHandler label.Click, AddressOf date_Click

            Dim available = New PictureBox
            available.Name = i
            available.BackColor = Color.Green
            AddHandler available.Click, AddressOf date_Click

            'if the date of current panel is past, set it as unavailable
            Dim temp As New Date(curr_date.Year, curr_date.Month, i)
            If temp < DateTime.Today Then
                label.Name = "invalid"
                available.Name = "invalid"
                available.BackColor = Color.Red
            End If

            'If the date of current panel is Monday, set it as unavailable because it is closed
            If temp.DayOfWeek = DayOfWeek.Monday Then
                label.Name = "invalid"
                available.Name = "invalid"
                available.BackColor = Color.Red
            End If

            Dim panel As New Panel
            panel.Size = New Size(46, 39)
            panel.Controls.Add(label)
            panel.Controls.Add(available)
            panel.Cursor = Cursors.Hand

            Custom_Calendar.Controls.Add(panel)
        Next


    End Sub

    Private Sub clear_custom_calendar()
        'clear all controls in the calendar
        Custom_Calendar.Controls.Clear()
        'add back date and weeks container
        Custom_Calendar.Controls.Add(Calender_date_container)
        Custom_Calendar.Controls.Add(dayOfWeekContainer)

    End Sub

    Private Sub date_Click(sender As Object, e As EventArgs)
        If sender.name = "invalid" Then
            MsgBox("Invalid date")
        Else
            date_paryLbl.Text = "Date of party (" + sender.name + "/" + curr_date.ToString("MM") + "/" + curr_date.ToString("yyyy") + ")"
        End If
    End Sub

    Private Sub BookSystem_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        'hide BookSystem
        GlobalVariable.bookSystem.Hide()
        'show Main
        GlobalVariable.main.Show()
    End Sub

    Private Sub BookSystem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Calendar_date.Text = curr_date.ToString("MMMM") & " " & curr_date.Year
        show_days()
    End Sub

    Private Sub nxt_btn_Click(sender As Object, e As EventArgs) Handles nxt_monthBtn.Click
        clear_custom_calendar()
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

    Private Sub prev_monthBtn_Click(sender As Object, e As EventArgs) Handles prev_monthBtn.Click
        'clear calendar
        clear_custom_calendar()
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

End Class