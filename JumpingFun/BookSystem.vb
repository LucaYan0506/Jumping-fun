Public Class BookSystem
    'get today date
    Dim curr_date As Date = Date.Now
    Dim current_tab As Integer = 0

    'variable to calculate to total cost
    Const adminCost As Integer = 10
    Const guestsFee As Integer = 5
    Dim nGuests As Integer
    Const ballonCost As Decimal = 7.5
    Const bagCost As Integer = 3
    Const bottleCost As Integer = 5
    Const sockCost As Decimal = 2.5
    Const smallCakeCost As Integer = 10
    Const mediumCakeCost As Integer = 20
    Const largeCakeCost As Integer = 35
    Const customCake As Decimal = 1.5
    Const bannerCost As Integer = 5
    Const letterCost As Integer = 1
    Const discount As Integer = 10
    Dim totalCost As Decimal
    Dim organiserName, address, post_code, phoneNumber As String
    Dim dateParty As Date

    Dim currentTabPageIndex = 0

    'variable for key event
    Dim notNumber, notBack As Boolean

    Function bookingDetailLocked() As Boolean
        organiserName = customer_nameTxt.Text
        address = addressTxt.Text
        post_code = post_codeTxt.Text
        phoneNumber = phone_numberTxt.Text

        If organiserName.Replace(" ", "") = "" Then
            MsgBox("Please, make sure that you inserted the customer name")
            Return True
        ElseIf address.Replace(" ", "") = "" Then
            MsgBox("Please, make sure that you inserted the address")
            Return True
        ElseIf post_code.Replace(" ", "") = "" Then
            MsgBox("Please, make sure that you inserted the post code")
            Return True
        ElseIf phoneNumber.Replace(" ", "") = "" Then
            MsgBox("Please, make sure that you inserted the phone number")
            Return True
        ElseIf date_paryLbl.Text = "Date of party" Then
            MsgBox("Please, make sure that you chose the date of party")
            Return True
        End If

        Return False
    End Function

    Function partyDetailLocked() As Boolean
        If n_peopleCombobx.SelectedItem = Nothing Then
            Return True
        End If

        nGuests = Integer.Parse(n_peopleCombobx.SelectedItem)
        Return nGuests = Nothing
    End Function

    Private Sub showReceipt()
        'admin cost
        totalCost = adminCost
        costList.Rows.Add("Administrative cost", adminCost.ToString("F2"))
        'guess fee
        totalCost += guestsFee * nGuests
        costList.Rows.Add("Guests Fee * " + nGuests.ToString(), "£" + (guestsFee * nGuests).ToString("F2"))
        'balloons
        If n_ballonsCombobx.SelectedItem <> Nothing Then
            Dim ballons As Decimal = ballonCost * Integer.Parse(n_ballonsCombobx.SelectedIndex)
            totalCost += ballons
            costList.Rows.Add("Helium Balloons * " + (Integer.Parse(n_ballonsCombobx.SelectedIndex)).ToString(), "£" + (ballons).ToString("F2"))
        End If
        'bags
        If bagsCheckbx.Checked Then
            totalCost += bagCost * nGuests
            costList.Rows.Add("Party bags * " + (nGuests).ToString(), "£" + (bagCost * nGuests).ToString("F2"))
        End If
        'water bottle
        If bottleCheckbx.Checked Then
            totalCost += bottleCost * nGuests
            costList.Rows.Add("Branded water bottles * " + (nGuests).ToString(), "£" + (bottleCost * nGuests).ToString("F2"))
        End If
        'socks
        If socksCheckbx.Checked Then
            totalCost += sockCost * nGuests
            costList.Rows.Add("Socks * " + (nGuests).ToString(), "£" + (sockCost * nGuests).ToString("F2"))
        End If

        'cake
        '0 nocake
        '1 small cake
        '2 medium cake
        '3 large cake
        Dim cake As String = "Cake (none)"
        Dim cakeCost As Decimal = 0
        If small_cakeRadioBtn.Checked Then
            cake = "Cake (small)"
            cakeCost = smallCakeCost
        ElseIf medium_cakeRadioBtn.Checked Then
            cake = "Cake (medium)"
            cakeCost = mediumCakeCost
        ElseIf large_cakeRadioBtn.Checked Then
            cake = "Cake (large)"
            cakeCost = largeCakeCost
        End If

        If cake_customCheckbx.Checked Then
            cake = "Customised " + cake
            cakeCost *= 1.5
        End If

        costList.Rows.Add(cake, "£" + (cakeCost).ToString("F2"))


        'banner
        If bannerCheckbx.Checked Then
            totalCost += bannerCost
            costList.Rows.Add("Banner cost", "£" + (bannerCost).ToString("F2"))
            totalCost += bannerTxt.Text.Length * letterCost
            costList.Rows.Add("Letters cost * " + bannerTxt.Text.Length.ToString(), "£" + (bannerCost).ToString("F2"))
        End If

        'discount
        If totalCost > 250 Then
            totalCost = totalCost - totalCost * discount / 100
            costList.Rows.Add("Discount", "-" + (discount).ToString() + "%")
        End If
        tot_costTxt.Items.Clear()
        tot_costTxt.Items.Add("£" + totalCost.ToString("F2"))
    End Sub

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
        costList.ScrollBars = ScrollBars.Vertical

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
                    e.Cancel = True
                End If
            Case 1
                If tabControl.SelectedIndex = 2 And partyDetailLocked() Then
                    MsgBox("Make sure that you insert the number of people")
                    e.Cancel = True
                Else
                    showReceipt()
                End If
        End Select
    End Sub

    Private Sub bck_to_booking_detailBtn_Click(sender As Object, e As EventArgs) Handles bck_to_booking_detailBtn.Click
        'go to the first tab page
        tabControl.SelectedIndex = 0
    End Sub

    Private Sub bck_to_homeBtn_Click(sender As Object, e As EventArgs) Handles bck_to_homeBtn.Click
        'hide BookSystem
        GlobalVariable.bookSystem.Hide()
        'show Main
        GlobalVariable.main.Show()
    End Sub

    Private Sub phone_numberTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles phone_numberTxt.KeyDown
        'if keydown is back
        notBack = e.KeyCode <> Keys.Back
    End Sub

    Private Sub nxt_to_party_detailBtn_Click(sender As Object, e As EventArgs) Handles nxt_to_party_detailBtn.Click
        'go to the second tab page
        tabControl.SelectedIndex = 1
    End Sub

    Private Sub nxt_to_receiptBtn_Click(sender As Object, e As EventArgs) Handles nxt_to_receiptBtn.Click
        'go to the third tab page
        tabControl.SelectedIndex = 2
    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        SaveFileDialog1.Title = "Receipt"
        SaveFileDialog1.DefaultExt = "txt"
        SaveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        SaveFileDialog1.FileName = "receipt"
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter(SaveFileDialog1.FileName, False)
            file.WriteLine("Organiser detail")
            file.WriteLine("Name: " + organiserName)
            file.WriteLine("Address: " + address)
            file.WriteLine("PostCode: " + post_code)
            file.WriteLine("Phone number: " + phoneNumber)
            file.WriteLine("")
            file.WriteLine("Partydetail")
            file.WriteLine("Date:" + dateParty.ToString("d"))
            'import data from costlist
            Dim str As String
            For i = 0 To costList.RowCount - 1
                str = String.Empty
                For j = 0 To costList.ColumnCount - 1
                    str = str & costList.Rows(i).Cells(j).Value.ToString & "|"
                Next
                str = str.Substring(0, str.Length - 1)
                file.WriteLine(str)
            Next
            file.WriteLine("")
            file.WriteLine("Total cost: " + totalCost.ToString())

            file.Close()
        End If
    End Sub

    Private Sub phone_numberTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles phone_numberTxt.KeyPress
        'if length is 11 or is not a number cancel the key event
        'if key is back don't cancel the event
        If (phone_numberTxt.Text.Length = 11 Or Not Char.IsDigit(e.KeyChar)) And notBack Then
            e.Handled = True
        End If
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