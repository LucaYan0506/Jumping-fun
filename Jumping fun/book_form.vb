﻿Public Class book_form
    'get today date
    Dim curr_date As Date = Date.Now
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

    Private Sub clear_calendar()
        Custom_Calendar.Controls.Clear()
        Custom_Calendar.Controls.Add(Calender_date_container)
        Custom_Calendar.Controls.Add(Calendar_dayWeek)
    End Sub
    Private Sub Personal_detail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(407, 612)
        TabControl1.SelectedTab = TabPage1

        Calendar_date.Text = curr_date.ToString("MMMM") & " " & curr_date.Year
        show_days()
    End Sub
    Private Sub nxt_month_Click(sender As Object, e As EventArgs) Handles nxt_month.Click
        ''clear calendar
        'clear_calendar()
        ''update date
        'dim next_month as integer = curr_date.month + 1
        'dim year as integer = curr_date.year
        'if next_month > 12 then
        '    year += 1
        '    next_month = next_month mod 12
        'end if
        'curr_date = new date(year, next_month, 1)

        ''update calendar_date
        'calendar_date.text = curr_date.tostring("mmmm") & " " & curr_date.year
        'show_days()
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
End Class