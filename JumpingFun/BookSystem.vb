Public Class BookSystem
    'get today date
    Dim curr_date As Date = Date.Now
    Dim current_tab As Integer = 0

    'variable to calculate to total cost
    Const adminCost As Integer = 10
    Const guestsFee As Integer = 5
    Dim nGuests As Integer
    Dim ballonCost As Double = 7.5
    Dim nBallons As Integer
    Const bagCost As Integer = 3
    Const bottleCost As Integer = 5
    Const sockCost As Double = 2.5
    Const bannerCost As Integer = 5
    Const letterCost As Integer = 1
    Const discount As Integer = 10
    Dim totalCost As Double
    Dim organiserName, address, post_code, phoneNumber As String
    Dim dateParty As Date

    Dim currentTabPageIndex = 0

    Function bookingDetailLocked() As Boolean
        organiserName = customer_nameTxt.Text
        address = addressTxt.Text
        post_code = post_codeTxt.Text
        phoneNumber = phone_numberTxt.Text

        If organiserName = "" Or address = "" Or post_code = "" Or phoneNumber = "" Or date_paryLbl.Text = "Date of party" Then
            Return True
        End If

        Return False
    End Function

    Function partyDetailLocked() As Boolean
        nGuests = Integer.Parse(n_peopleCombobx.SelectedItem)
        Return nGuests = Nothing
    End Function

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
            dateParty = New Date(curr_date.Year, curr_date.Month, Integer.Parse(sender.name))
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
        'show dates of the current month
        Calendar_date.Text = curr_date.ToString("MMMM") & " " & curr_date.Year
        show_days()

        'initilize value in the combobox
        n_ballonsCombobx.Items.Add(0)
        For i = 1 To 10
            n_peopleCombobx.Items.Add(i * 6)
            n_ballonsCombobx.Items.Add(i * 5)
        Next
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

    Private Sub TabControl_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles tabControl.Selecting
        Select Case currentTabPageIndex
            Case 0
                If bookingDetailLocked() Then
                    MsgBox("Make sure that you insert all detail")
                    e.Cancel = True
                End If
            Case 1
                If tabControl.SelectedIndex = 2 And partyDetailLocked() Then
                    MsgBox("Make sure that you insert the number of people")
                    e.Cancel = True
                End If
        End Select
    End Sub

    Private Sub bck_to_booking_detailBtn_Click(sender As Object, e As EventArgs) Handles bck_to_booking_detailBtn.Click

    End Sub

    Private Sub bck_to_homeBtn_Click(sender As Object, e As EventArgs) Handles bck_to_homeBtn.Click
        'hide BookSystem
        GlobalVariable.bookSystem.Hide()
        'show Main
        GlobalVariable.main.Show()
    End Sub

    Private Sub TabControl_Selected(sender As Object, e As TabControlEventArgs) Handles tabControl.Selected
        Select Case tabControl.SelectedIndex
            Case 0
                Me.Size = New Size(402, 612)
            Case 1
                Me.Size = New Size(402, 386)
            Case 2
                Me.Size = New Size(402, 386)
        End Select

        currentTabPageIndex = tabControl.SelectedIndex
    End Sub

    Private Sub cake_customCheckbx_CheckedChanged(sender As Object, e As EventArgs) Handles cake_customCheckbx.CheckedChanged
        If cake_customCheckbx.Checked Then
            small_cakeRadioBtn.Text = "Small (£15)"
            medium_cakeRadioBtn.Text = "Medium (£30)"
            large_cakeRadioBtn.Text = "Large (£52.50)"
        Else
            small_cakeRadioBtn.Text = "Small (£10)"
            medium_cakeRadioBtn.Text = "Medium (£20)"
            large_cakeRadioBtn.Text = "Large (£35)"
        End If
    End Sub

    Private Sub bannerCheckbx_CheckedChanged(sender As Object, e As EventArgs) Handles bannerCheckbx.CheckedChanged
        bannerTxt.Visible = bannerCheckbx.Checked
    End Sub
End Class