<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BookSystem
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tabControl = New System.Windows.Forms.TabControl()
        Me.booking_detailPage = New System.Windows.Forms.TabPage()
        Me.date_paryLbl = New System.Windows.Forms.Label()
        Me.nxt_to_party_detailBtn = New System.Windows.Forms.Button()
        Me.bck_to_homeBtn = New System.Windows.Forms.Button()
        Me.Custom_Calendar = New System.Windows.Forms.FlowLayoutPanel()
        Me.Calender_date_container = New System.Windows.Forms.Panel()
        Me.prev_monthBtn = New System.Windows.Forms.Button()
        Me.nxt_monthBtn = New System.Windows.Forms.Button()
        Me.Calendar_date = New System.Windows.Forms.Label()
        Me.dayOfWeekContainer = New System.Windows.Forms.Panel()
        Me.thursdayLbl = New System.Windows.Forms.Label()
        Me.fridayLbl = New System.Windows.Forms.Label()
        Me.wednsdayLbl = New System.Windows.Forms.Label()
        Me.sundayLbl = New System.Windows.Forms.Label()
        Me.saturdayLbl = New System.Windows.Forms.Label()
        Me.tuesdayLbl = New System.Windows.Forms.Label()
        Me.mondayLbl = New System.Windows.Forms.Label()
        Me.post_codeTxt = New System.Windows.Forms.TextBox()
        Me.post_codeLbl = New System.Windows.Forms.Label()
        Me.addressTxt = New System.Windows.Forms.TextBox()
        Me.addressLbl = New System.Windows.Forms.Label()
        Me.phone_numberTxt = New System.Windows.Forms.TextBox()
        Me.phone_numberLbl = New System.Windows.Forms.Label()
        Me.customer_nameTxt = New System.Windows.Forms.TextBox()
        Me.customer_nameLbl = New System.Windows.Forms.Label()
        Me.party_detailPage = New System.Windows.Forms.TabPage()
        Me.nxt_to_receiptBtn = New System.Windows.Forms.Button()
        Me.bck_to_booking_detailBtn = New System.Windows.Forms.Button()
        Me.bannerTxt = New System.Windows.Forms.TextBox()
        Me.bannerCheckbx = New System.Windows.Forms.CheckBox()
        Me.large_cakeRadioBtn = New System.Windows.Forms.RadioButton()
        Me.medium_cakeRadioBtn = New System.Windows.Forms.RadioButton()
        Me.small_cakeRadioBtn = New System.Windows.Forms.RadioButton()
        Me.no_cakeRadioBtn = New System.Windows.Forms.RadioButton()
        Me.cakeLbl2 = New System.Windows.Forms.Label()
        Me.cake_customCheckbx = New System.Windows.Forms.CheckBox()
        Me.cakeLbl = New System.Windows.Forms.Label()
        Me.bottleCheckbx = New System.Windows.Forms.CheckBox()
        Me.bagsCheckbx = New System.Windows.Forms.CheckBox()
        Me.socksCheckbx = New System.Windows.Forms.CheckBox()
        Me.n_ballonsCombobx = New System.Windows.Forms.ComboBox()
        Me.n_ballonsLbl = New System.Windows.Forms.Label()
        Me.n_peopleCombobx = New System.Windows.Forms.ComboBox()
        Me.n_peopleLbl = New System.Windows.Forms.Label()
        Me.receiptPage = New System.Windows.Forms.TabPage()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.bck_to_party_detailBtn = New System.Windows.Forms.Button()
        Me.tot_costTxt = New System.Windows.Forms.ListBox()
        Me.totTxt = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.costlList = New System.Windows.Forms.ListBox()
        Me.detailList = New System.Windows.Forms.ListBox()
        Me.tabControl.SuspendLayout()
        Me.booking_detailPage.SuspendLayout()
        Me.Custom_Calendar.SuspendLayout()
        Me.Calender_date_container.SuspendLayout()
        Me.dayOfWeekContainer.SuspendLayout()
        Me.party_detailPage.SuspendLayout()
        Me.receiptPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabControl
        '
        Me.tabControl.Controls.Add(Me.booking_detailPage)
        Me.tabControl.Controls.Add(Me.party_detailPage)
        Me.tabControl.Controls.Add(Me.receiptPage)
        Me.tabControl.Location = New System.Drawing.Point(0, 0)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedIndex = 0
        Me.tabControl.Size = New System.Drawing.Size(398, 579)
        Me.tabControl.TabIndex = 0
        '
        'booking_detailPage
        '
        Me.booking_detailPage.Controls.Add(Me.date_paryLbl)
        Me.booking_detailPage.Controls.Add(Me.nxt_to_party_detailBtn)
        Me.booking_detailPage.Controls.Add(Me.bck_to_homeBtn)
        Me.booking_detailPage.Controls.Add(Me.Custom_Calendar)
        Me.booking_detailPage.Controls.Add(Me.post_codeTxt)
        Me.booking_detailPage.Controls.Add(Me.post_codeLbl)
        Me.booking_detailPage.Controls.Add(Me.addressTxt)
        Me.booking_detailPage.Controls.Add(Me.addressLbl)
        Me.booking_detailPage.Controls.Add(Me.phone_numberTxt)
        Me.booking_detailPage.Controls.Add(Me.phone_numberLbl)
        Me.booking_detailPage.Controls.Add(Me.customer_nameTxt)
        Me.booking_detailPage.Controls.Add(Me.customer_nameLbl)
        Me.booking_detailPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.booking_detailPage.Location = New System.Drawing.Point(4, 22)
        Me.booking_detailPage.Name = "booking_detailPage"
        Me.booking_detailPage.Padding = New System.Windows.Forms.Padding(3)
        Me.booking_detailPage.Size = New System.Drawing.Size(390, 553)
        Me.booking_detailPage.TabIndex = 0
        Me.booking_detailPage.Text = "Booking Detail"
        Me.booking_detailPage.UseVisualStyleBackColor = True
        '
        'date_paryLbl
        '
        Me.date_paryLbl.AutoSize = True
        Me.date_paryLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.date_paryLbl.Location = New System.Drawing.Point(8, 148)
        Me.date_paryLbl.Name = "date_paryLbl"
        Me.date_paryLbl.Size = New System.Drawing.Size(97, 16)
        Me.date_paryLbl.TabIndex = 12
        Me.date_paryLbl.Text = "Date of party"
        '
        'nxt_to_party_detailBtn
        '
        Me.nxt_to_party_detailBtn.Location = New System.Drawing.Point(301, 518)
        Me.nxt_to_party_detailBtn.Name = "nxt_to_party_detailBtn"
        Me.nxt_to_party_detailBtn.Size = New System.Drawing.Size(76, 25)
        Me.nxt_to_party_detailBtn.TabIndex = 11
        Me.nxt_to_party_detailBtn.Text = "Next"
        Me.nxt_to_party_detailBtn.UseVisualStyleBackColor = True
        '
        'bck_to_homeBtn
        '
        Me.bck_to_homeBtn.Location = New System.Drawing.Point(8, 518)
        Me.bck_to_homeBtn.Name = "bck_to_homeBtn"
        Me.bck_to_homeBtn.Size = New System.Drawing.Size(76, 25)
        Me.bck_to_homeBtn.TabIndex = 11
        Me.bck_to_homeBtn.Text = "Back"
        Me.bck_to_homeBtn.UseVisualStyleBackColor = True
        '
        'Custom_Calendar
        '
        Me.Custom_Calendar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Custom_Calendar.Controls.Add(Me.Calender_date_container)
        Me.Custom_Calendar.Controls.Add(Me.dayOfWeekContainer)
        Me.Custom_Calendar.Location = New System.Drawing.Point(8, 173)
        Me.Custom_Calendar.Name = "Custom_Calendar"
        Me.Custom_Calendar.Size = New System.Drawing.Size(370, 339)
        Me.Custom_Calendar.TabIndex = 10
        '
        'Calender_date_container
        '
        Me.Calender_date_container.BackColor = System.Drawing.Color.Transparent
        Me.Calender_date_container.Controls.Add(Me.prev_monthBtn)
        Me.Calender_date_container.Controls.Add(Me.nxt_monthBtn)
        Me.Calender_date_container.Controls.Add(Me.Calendar_date)
        Me.Calender_date_container.Location = New System.Drawing.Point(3, 3)
        Me.Calender_date_container.Name = "Calender_date_container"
        Me.Calender_date_container.Size = New System.Drawing.Size(365, 39)
        Me.Calender_date_container.TabIndex = 0
        '
        'prev_monthBtn
        '
        Me.prev_monthBtn.Location = New System.Drawing.Point(-1, 0)
        Me.prev_monthBtn.Name = "prev_monthBtn"
        Me.prev_monthBtn.Size = New System.Drawing.Size(40, 39)
        Me.prev_monthBtn.TabIndex = 1
        Me.prev_monthBtn.Text = "<"
        Me.prev_monthBtn.UseVisualStyleBackColor = True
        '
        'nxt_monthBtn
        '
        Me.nxt_monthBtn.Location = New System.Drawing.Point(322, 0)
        Me.nxt_monthBtn.Name = "nxt_monthBtn"
        Me.nxt_monthBtn.Size = New System.Drawing.Size(40, 39)
        Me.nxt_monthBtn.TabIndex = 1
        Me.nxt_monthBtn.Text = ">"
        Me.nxt_monthBtn.UseVisualStyleBackColor = True
        '
        'Calendar_date
        '
        Me.Calendar_date.Location = New System.Drawing.Point(0, 0)
        Me.Calendar_date.Name = "Calendar_date"
        Me.Calendar_date.Size = New System.Drawing.Size(360, 39)
        Me.Calendar_date.TabIndex = 0
        Me.Calendar_date.Text = "March 2022"
        Me.Calendar_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dayOfWeekContainer
        '
        Me.dayOfWeekContainer.Controls.Add(Me.thursdayLbl)
        Me.dayOfWeekContainer.Controls.Add(Me.fridayLbl)
        Me.dayOfWeekContainer.Controls.Add(Me.wednsdayLbl)
        Me.dayOfWeekContainer.Controls.Add(Me.sundayLbl)
        Me.dayOfWeekContainer.Controls.Add(Me.saturdayLbl)
        Me.dayOfWeekContainer.Controls.Add(Me.tuesdayLbl)
        Me.dayOfWeekContainer.Controls.Add(Me.mondayLbl)
        Me.dayOfWeekContainer.Location = New System.Drawing.Point(3, 48)
        Me.dayOfWeekContainer.Name = "dayOfWeekContainer"
        Me.dayOfWeekContainer.Size = New System.Drawing.Size(360, 15)
        Me.dayOfWeekContainer.TabIndex = 1
        '
        'thursdayLbl
        '
        Me.thursdayLbl.AutoSize = True
        Me.thursdayLbl.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.thursdayLbl.Location = New System.Drawing.Point(164, 0)
        Me.thursdayLbl.Name = "thursdayLbl"
        Me.thursdayLbl.Size = New System.Drawing.Size(27, 15)
        Me.thursdayLbl.TabIndex = 16
        Me.thursdayLbl.Text = "Thu"
        '
        'fridayLbl
        '
        Me.fridayLbl.AutoSize = True
        Me.fridayLbl.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.fridayLbl.Location = New System.Drawing.Point(219, 0)
        Me.fridayLbl.Name = "fridayLbl"
        Me.fridayLbl.Size = New System.Drawing.Size(20, 15)
        Me.fridayLbl.TabIndex = 17
        Me.fridayLbl.Text = "Fri"
        '
        'wednsdayLbl
        '
        Me.wednsdayLbl.AutoSize = True
        Me.wednsdayLbl.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.wednsdayLbl.Location = New System.Drawing.Point(113, 0)
        Me.wednsdayLbl.Name = "wednsdayLbl"
        Me.wednsdayLbl.Size = New System.Drawing.Size(31, 15)
        Me.wednsdayLbl.TabIndex = 20
        Me.wednsdayLbl.Text = "Wed"
        '
        'sundayLbl
        '
        Me.sundayLbl.AutoSize = True
        Me.sundayLbl.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.sundayLbl.Location = New System.Drawing.Point(320, 0)
        Me.sundayLbl.Name = "sundayLbl"
        Me.sundayLbl.Size = New System.Drawing.Size(27, 15)
        Me.sundayLbl.TabIndex = 19
        Me.sundayLbl.Text = "Sun"
        '
        'saturdayLbl
        '
        Me.saturdayLbl.AutoSize = True
        Me.saturdayLbl.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.saturdayLbl.Location = New System.Drawing.Point(271, 0)
        Me.saturdayLbl.Name = "saturdayLbl"
        Me.saturdayLbl.Size = New System.Drawing.Size(23, 15)
        Me.saturdayLbl.TabIndex = 18
        Me.saturdayLbl.Text = "Sat"
        '
        'tuesdayLbl
        '
        Me.tuesdayLbl.AutoSize = True
        Me.tuesdayLbl.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tuesdayLbl.Location = New System.Drawing.Point(62, 0)
        Me.tuesdayLbl.Name = "tuesdayLbl"
        Me.tuesdayLbl.Size = New System.Drawing.Size(26, 15)
        Me.tuesdayLbl.TabIndex = 14
        Me.tuesdayLbl.Text = "Tue"
        '
        'mondayLbl
        '
        Me.mondayLbl.AutoSize = True
        Me.mondayLbl.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.mondayLbl.Location = New System.Drawing.Point(11, 0)
        Me.mondayLbl.Name = "mondayLbl"
        Me.mondayLbl.Size = New System.Drawing.Size(32, 15)
        Me.mondayLbl.TabIndex = 13
        Me.mondayLbl.Text = "Mon"
        '
        'post_codeTxt
        '
        Me.post_codeTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.post_codeTxt.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.post_codeTxt.Location = New System.Drawing.Point(240, 73)
        Me.post_codeTxt.Name = "post_codeTxt"
        Me.post_codeTxt.Size = New System.Drawing.Size(137, 25)
        Me.post_codeTxt.TabIndex = 6
        '
        'post_codeLbl
        '
        Me.post_codeLbl.AutoSize = True
        Me.post_codeLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.post_codeLbl.Location = New System.Drawing.Point(244, 54)
        Me.post_codeLbl.Name = "post_codeLbl"
        Me.post_codeLbl.Size = New System.Drawing.Size(76, 16)
        Me.post_codeLbl.TabIndex = 7
        Me.post_codeLbl.Text = "PostCode"
        '
        'addressTxt
        '
        Me.addressTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.addressTxt.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.addressTxt.Location = New System.Drawing.Point(11, 73)
        Me.addressTxt.Name = "addressTxt"
        Me.addressTxt.Size = New System.Drawing.Size(223, 25)
        Me.addressTxt.TabIndex = 4
        '
        'addressLbl
        '
        Me.addressLbl.AutoSize = True
        Me.addressLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.addressLbl.Location = New System.Drawing.Point(8, 54)
        Me.addressLbl.Name = "addressLbl"
        Me.addressLbl.Size = New System.Drawing.Size(129, 16)
        Me.addressLbl.TabIndex = 5
        Me.addressLbl.Text = "Address (1st line)"
        '
        'phone_numberTxt
        '
        Me.phone_numberTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.phone_numberTxt.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.phone_numberTxt.Location = New System.Drawing.Point(8, 120)
        Me.phone_numberTxt.Name = "phone_numberTxt"
        Me.phone_numberTxt.Size = New System.Drawing.Size(369, 25)
        Me.phone_numberTxt.TabIndex = 2
        '
        'phone_numberLbl
        '
        Me.phone_numberLbl.AutoSize = True
        Me.phone_numberLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.phone_numberLbl.Location = New System.Drawing.Point(8, 101)
        Me.phone_numberLbl.Name = "phone_numberLbl"
        Me.phone_numberLbl.Size = New System.Drawing.Size(138, 16)
        Me.phone_numberLbl.TabIndex = 3
        Me.phone_numberLbl.Text = "Telephone number"
        '
        'customer_nameTxt
        '
        Me.customer_nameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.customer_nameTxt.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.customer_nameTxt.Location = New System.Drawing.Point(11, 26)
        Me.customer_nameTxt.Name = "customer_nameTxt"
        Me.customer_nameTxt.Size = New System.Drawing.Size(366, 25)
        Me.customer_nameTxt.TabIndex = 0
        '
        'customer_nameLbl
        '
        Me.customer_nameLbl.AutoSize = True
        Me.customer_nameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.customer_nameLbl.Location = New System.Drawing.Point(8, 7)
        Me.customer_nameLbl.Name = "customer_nameLbl"
        Me.customer_nameLbl.Size = New System.Drawing.Size(199, 16)
        Me.customer_nameLbl.TabIndex = 1
        Me.customer_nameLbl.Text = "Customer name (organiser) "
        '
        'party_detailPage
        '
        Me.party_detailPage.Controls.Add(Me.nxt_to_receiptBtn)
        Me.party_detailPage.Controls.Add(Me.bck_to_booking_detailBtn)
        Me.party_detailPage.Controls.Add(Me.bannerTxt)
        Me.party_detailPage.Controls.Add(Me.bannerCheckbx)
        Me.party_detailPage.Controls.Add(Me.large_cakeRadioBtn)
        Me.party_detailPage.Controls.Add(Me.medium_cakeRadioBtn)
        Me.party_detailPage.Controls.Add(Me.small_cakeRadioBtn)
        Me.party_detailPage.Controls.Add(Me.no_cakeRadioBtn)
        Me.party_detailPage.Controls.Add(Me.cakeLbl2)
        Me.party_detailPage.Controls.Add(Me.cake_customCheckbx)
        Me.party_detailPage.Controls.Add(Me.cakeLbl)
        Me.party_detailPage.Controls.Add(Me.bottleCheckbx)
        Me.party_detailPage.Controls.Add(Me.bagsCheckbx)
        Me.party_detailPage.Controls.Add(Me.socksCheckbx)
        Me.party_detailPage.Controls.Add(Me.n_ballonsCombobx)
        Me.party_detailPage.Controls.Add(Me.n_ballonsLbl)
        Me.party_detailPage.Controls.Add(Me.n_peopleCombobx)
        Me.party_detailPage.Controls.Add(Me.n_peopleLbl)
        Me.party_detailPage.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.party_detailPage.Location = New System.Drawing.Point(4, 22)
        Me.party_detailPage.Name = "party_detailPage"
        Me.party_detailPage.Padding = New System.Windows.Forms.Padding(3)
        Me.party_detailPage.Size = New System.Drawing.Size(390, 553)
        Me.party_detailPage.TabIndex = 1
        Me.party_detailPage.Text = "Party detail"
        Me.party_detailPage.UseVisualStyleBackColor = True
        '
        'nxt_to_receiptBtn
        '
        Me.nxt_to_receiptBtn.Location = New System.Drawing.Point(298, 286)
        Me.nxt_to_receiptBtn.Name = "nxt_to_receiptBtn"
        Me.nxt_to_receiptBtn.Size = New System.Drawing.Size(75, 32)
        Me.nxt_to_receiptBtn.TabIndex = 15
        Me.nxt_to_receiptBtn.Text = "next"
        Me.nxt_to_receiptBtn.UseVisualStyleBackColor = True
        '
        'bck_to_booking_detailBtn
        '
        Me.bck_to_booking_detailBtn.Location = New System.Drawing.Point(3, 286)
        Me.bck_to_booking_detailBtn.Name = "bck_to_booking_detailBtn"
        Me.bck_to_booking_detailBtn.Size = New System.Drawing.Size(75, 32)
        Me.bck_to_booking_detailBtn.TabIndex = 16
        Me.bck_to_booking_detailBtn.Text = "Back"
        Me.bck_to_booking_detailBtn.UseVisualStyleBackColor = True
        '
        'bannerTxt
        '
        Me.bannerTxt.Location = New System.Drawing.Point(8, 251)
        Me.bannerTxt.Name = "bannerTxt"
        Me.bannerTxt.Size = New System.Drawing.Size(365, 29)
        Me.bannerTxt.TabIndex = 17
        Me.bannerTxt.Visible = False
        '
        'bannerCheckbx
        '
        Me.bannerCheckbx.AutoSize = True
        Me.bannerCheckbx.Location = New System.Drawing.Point(8, 220)
        Me.bannerCheckbx.Name = "bannerCheckbx"
        Me.bannerCheckbx.Size = New System.Drawing.Size(365, 25)
        Me.bannerCheckbx.TabIndex = 14
        Me.bannerCheckbx.Text = "Banner (will cost £5 plus £1 per letter and space)"
        Me.bannerCheckbx.UseVisualStyleBackColor = True
        '
        'large_cakeRadioBtn
        '
        Me.large_cakeRadioBtn.AutoSize = True
        Me.large_cakeRadioBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.large_cakeRadioBtn.Location = New System.Drawing.Point(275, 193)
        Me.large_cakeRadioBtn.Name = "large_cakeRadioBtn"
        Me.large_cakeRadioBtn.Size = New System.Drawing.Size(92, 21)
        Me.large_cakeRadioBtn.TabIndex = 11
        Me.large_cakeRadioBtn.TabStop = True
        Me.large_cakeRadioBtn.Text = "Large (£35)"
        Me.large_cakeRadioBtn.UseVisualStyleBackColor = True
        '
        'medium_cakeRadioBtn
        '
        Me.medium_cakeRadioBtn.AutoSize = True
        Me.medium_cakeRadioBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.medium_cakeRadioBtn.Location = New System.Drawing.Point(170, 193)
        Me.medium_cakeRadioBtn.Name = "medium_cakeRadioBtn"
        Me.medium_cakeRadioBtn.Size = New System.Drawing.Size(107, 21)
        Me.medium_cakeRadioBtn.TabIndex = 10
        Me.medium_cakeRadioBtn.TabStop = True
        Me.medium_cakeRadioBtn.Text = "Medium (£20)"
        Me.medium_cakeRadioBtn.UseVisualStyleBackColor = True
        '
        'small_cakeRadioBtn
        '
        Me.small_cakeRadioBtn.AutoSize = True
        Me.small_cakeRadioBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.small_cakeRadioBtn.Location = New System.Drawing.Point(78, 193)
        Me.small_cakeRadioBtn.Name = "small_cakeRadioBtn"
        Me.small_cakeRadioBtn.Size = New System.Drawing.Size(90, 21)
        Me.small_cakeRadioBtn.TabIndex = 9
        Me.small_cakeRadioBtn.TabStop = True
        Me.small_cakeRadioBtn.Text = "Small (£10)"
        Me.small_cakeRadioBtn.UseVisualStyleBackColor = True
        '
        'no_cakeRadioBtn
        '
        Me.no_cakeRadioBtn.AutoSize = True
        Me.no_cakeRadioBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.no_cakeRadioBtn.Location = New System.Drawing.Point(8, 193)
        Me.no_cakeRadioBtn.Name = "no_cakeRadioBtn"
        Me.no_cakeRadioBtn.Size = New System.Drawing.Size(70, 21)
        Me.no_cakeRadioBtn.TabIndex = 8
        Me.no_cakeRadioBtn.TabStop = True
        Me.no_cakeRadioBtn.Text = "No (£0)"
        Me.no_cakeRadioBtn.UseVisualStyleBackColor = True
        '
        'cakeLbl2
        '
        Me.cakeLbl2.AutoSize = True
        Me.cakeLbl2.Location = New System.Drawing.Point(162, 169)
        Me.cakeLbl2.Name = "cakeLbl2"
        Me.cakeLbl2.Size = New System.Drawing.Size(15, 21)
        Me.cakeLbl2.TabIndex = 9
        Me.cakeLbl2.Text = ")"
        '
        'cake_customCheckbx
        '
        Me.cake_customCheckbx.AutoSize = True
        Me.cake_customCheckbx.Location = New System.Drawing.Point(61, 169)
        Me.cake_customCheckbx.Name = "cake_customCheckbx"
        Me.cake_customCheckbx.Size = New System.Drawing.Size(111, 25)
        Me.cake_customCheckbx.TabIndex = 8
        Me.cake_customCheckbx.Text = "Customised"
        Me.cake_customCheckbx.UseVisualStyleBackColor = True
        '
        'cakeLbl
        '
        Me.cakeLbl.AutoSize = True
        Me.cakeLbl.Location = New System.Drawing.Point(8, 169)
        Me.cakeLbl.Name = "cakeLbl"
        Me.cakeLbl.Size = New System.Drawing.Size(53, 21)
        Me.cakeLbl.TabIndex = 7
        Me.cakeLbl.Text = "Cake ("
        '
        'bottleCheckbx
        '
        Me.bottleCheckbx.AutoSize = True
        Me.bottleCheckbx.Location = New System.Drawing.Point(8, 110)
        Me.bottleCheckbx.Name = "bottleCheckbx"
        Me.bottleCheckbx.Size = New System.Drawing.Size(313, 25)
        Me.bottleCheckbx.TabIndex = 6
        Me.bottleCheckbx.Text = "Branded water bottles (£5.00 per person)"
        Me.bottleCheckbx.UseVisualStyleBackColor = True
        '
        'bagsCheckbx
        '
        Me.bagsCheckbx.AutoSize = True
        Me.bagsCheckbx.Location = New System.Drawing.Point(8, 79)
        Me.bagsCheckbx.Name = "bagsCheckbx"
        Me.bagsCheckbx.Size = New System.Drawing.Size(233, 25)
        Me.bagsCheckbx.TabIndex = 5
        Me.bagsCheckbx.Text = "Party bags (£3.00 per person)"
        Me.bagsCheckbx.UseVisualStyleBackColor = True
        '
        'socksCheckbx
        '
        Me.socksCheckbx.AutoSize = True
        Me.socksCheckbx.Location = New System.Drawing.Point(8, 141)
        Me.socksCheckbx.Name = "socksCheckbx"
        Me.socksCheckbx.Size = New System.Drawing.Size(201, 25)
        Me.socksCheckbx.TabIndex = 0
        Me.socksCheckbx.Text = "Socks (£2.50 per person)"
        Me.socksCheckbx.UseVisualStyleBackColor = True
        '
        'n_ballonsCombobx
        '
        Me.n_ballonsCombobx.FormattingEnabled = True
        Me.n_ballonsCombobx.Location = New System.Drawing.Point(8, 43)
        Me.n_ballonsCombobx.Name = "n_ballonsCombobx"
        Me.n_ballonsCombobx.Size = New System.Drawing.Size(43, 29)
        Me.n_ballonsCombobx.TabIndex = 3
        '
        'n_ballonsLbl
        '
        Me.n_ballonsLbl.AutoSize = True
        Me.n_ballonsLbl.Location = New System.Drawing.Point(57, 46)
        Me.n_ballonsLbl.Name = "n_ballonsLbl"
        Me.n_ballonsLbl.Size = New System.Drawing.Size(106, 21)
        Me.n_ballonsLbl.TabIndex = 4
        Me.n_ballonsLbl.Text = "N. of balloons"
        '
        'n_peopleCombobx
        '
        Me.n_peopleCombobx.FormattingEnabled = True
        Me.n_peopleCombobx.Location = New System.Drawing.Point(8, 8)
        Me.n_peopleCombobx.Name = "n_peopleCombobx"
        Me.n_peopleCombobx.Size = New System.Drawing.Size(43, 29)
        Me.n_peopleCombobx.TabIndex = 1
        '
        'n_peopleLbl
        '
        Me.n_peopleLbl.AutoSize = True
        Me.n_peopleLbl.Location = New System.Drawing.Point(57, 11)
        Me.n_peopleLbl.Name = "n_peopleLbl"
        Me.n_peopleLbl.Size = New System.Drawing.Size(94, 21)
        Me.n_peopleLbl.TabIndex = 2
        Me.n_peopleLbl.Text = "N. of people"
        '
        'receiptPage
        '
        Me.receiptPage.Controls.Add(Me.saveBtn)
        Me.receiptPage.Controls.Add(Me.bck_to_party_detailBtn)
        Me.receiptPage.Controls.Add(Me.tot_costTxt)
        Me.receiptPage.Controls.Add(Me.totTxt)
        Me.receiptPage.Controls.Add(Me.ListBox3)
        Me.receiptPage.Controls.Add(Me.costlList)
        Me.receiptPage.Controls.Add(Me.detailList)
        Me.receiptPage.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.receiptPage.Location = New System.Drawing.Point(4, 22)
        Me.receiptPage.Name = "receiptPage"
        Me.receiptPage.Padding = New System.Windows.Forms.Padding(3)
        Me.receiptPage.Size = New System.Drawing.Size(390, 553)
        Me.receiptPage.TabIndex = 2
        Me.receiptPage.Text = "Receipt"
        Me.receiptPage.UseVisualStyleBackColor = True
        '
        'saveBtn
        '
        Me.saveBtn.Location = New System.Drawing.Point(254, 281)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(119, 32)
        Me.saveBtn.TabIndex = 3
        Me.saveBtn.Text = "Save Receipt"
        Me.saveBtn.UseVisualStyleBackColor = True
        '
        'bck_to_party_detailBtn
        '
        Me.bck_to_party_detailBtn.Location = New System.Drawing.Point(6, 281)
        Me.bck_to_party_detailBtn.Name = "bck_to_party_detailBtn"
        Me.bck_to_party_detailBtn.Size = New System.Drawing.Size(75, 32)
        Me.bck_to_party_detailBtn.TabIndex = 17
        Me.bck_to_party_detailBtn.Text = "Back"
        Me.bck_to_party_detailBtn.UseVisualStyleBackColor = True
        '
        'tot_costTxt
        '
        Me.tot_costTxt.FormattingEnabled = True
        Me.tot_costTxt.ItemHeight = 21
        Me.tot_costTxt.Items.AddRange(New Object() {"£153.50"})
        Me.tot_costTxt.Location = New System.Drawing.Point(293, 242)
        Me.tot_costTxt.Name = "tot_costTxt"
        Me.tot_costTxt.Size = New System.Drawing.Size(82, 25)
        Me.tot_costTxt.TabIndex = 19
        '
        'totTxt
        '
        Me.totTxt.FormattingEnabled = True
        Me.totTxt.ItemHeight = 21
        Me.totTxt.Items.AddRange(New Object() {"Total"})
        Me.totTxt.Location = New System.Drawing.Point(8, 242)
        Me.totTxt.Name = "totTxt"
        Me.totTxt.Size = New System.Drawing.Size(286, 25)
        Me.totTxt.TabIndex = 18
        '
        'ListBox3
        '
        Me.ListBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 21
        Me.ListBox3.Items.AddRange(New Object() {"+", "+", "+", "+", "+", "="})
        Me.ListBox3.Location = New System.Drawing.Point(356, 9)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(17, 210)
        Me.ListBox3.TabIndex = 2
        '
        'costlList
        '
        Me.costlList.FormattingEnabled = True
        Me.costlList.ItemHeight = 21
        Me.costlList.Items.AddRange(New Object() {"£10.00", "£7.50", "£36.00", "£60.00", "£30.00", "£10.00", ""})
        Me.costlList.Location = New System.Drawing.Point(293, 8)
        Me.costlList.Name = "costlList"
        Me.costlList.Size = New System.Drawing.Size(82, 235)
        Me.costlList.TabIndex = 1
        '
        'detailList
        '
        Me.detailList.FormattingEnabled = True
        Me.detailList.ItemHeight = 21
        Me.detailList.Items.AddRange(New Object() {"Administrative cost ", "Helium Balloons * 5", "Party bags * 12", "Branded water bottles * 12", "Socks * 12", "Small cake"})
        Me.detailList.Location = New System.Drawing.Point(8, 8)
        Me.detailList.Name = "detailList"
        Me.detailList.Size = New System.Drawing.Size(286, 235)
        Me.detailList.TabIndex = 0
        '
        'BookSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 573)
        Me.Controls.Add(Me.tabControl)
        Me.Name = "BookSystem"
        Me.Text = "BookSystem"
        Me.tabControl.ResumeLayout(False)
        Me.booking_detailPage.ResumeLayout(False)
        Me.booking_detailPage.PerformLayout()
        Me.Custom_Calendar.ResumeLayout(False)
        Me.Calender_date_container.ResumeLayout(False)
        Me.dayOfWeekContainer.ResumeLayout(False)
        Me.dayOfWeekContainer.PerformLayout()
        Me.party_detailPage.ResumeLayout(False)
        Me.party_detailPage.PerformLayout()
        Me.receiptPage.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabControl As TabControl
    Friend WithEvents booking_detailPage As TabPage
    Friend WithEvents party_detailPage As TabPage
    Friend WithEvents receiptPage As TabPage
    Friend WithEvents customer_nameLbl As Label
    Friend WithEvents customer_nameTxt As TextBox
    Friend WithEvents addressTxt As TextBox
    Friend WithEvents addressLbl As Label
    Friend WithEvents phone_numberTxt As TextBox
    Friend WithEvents phone_numberLbl As Label
    Friend WithEvents post_codeTxt As TextBox
    Friend WithEvents post_codeLbl As Label
    Friend WithEvents Custom_Calendar As FlowLayoutPanel
    Friend WithEvents Calender_date_container As Panel
    Friend WithEvents Calendar_date As Label
    Friend WithEvents nxt_monthBtn As Button
    Friend WithEvents prev_monthBtn As Button
    Friend WithEvents nxt_to_party_detailBtn As Button
    Friend WithEvents bck_to_homeBtn As Button
    Friend WithEvents dayOfWeekContainer As Panel
    Friend WithEvents mondayLbl As Label
    Friend WithEvents thursdayLbl As Label
    Friend WithEvents fridayLbl As Label
    Friend WithEvents wednsdayLbl As Label
    Friend WithEvents sundayLbl As Label
    Friend WithEvents saturdayLbl As Label
    Friend WithEvents tuesdayLbl As Label
    Friend WithEvents date_paryLbl As Label
    Friend WithEvents n_peopleLbl As Label
    Friend WithEvents n_peopleCombobx As ComboBox
    Friend WithEvents bottleCheckbx As CheckBox
    Friend WithEvents bagsCheckbx As CheckBox
    Friend WithEvents socksCheckbx As CheckBox
    Friend WithEvents n_ballonsCombobx As ComboBox
    Friend WithEvents n_ballonsLbl As Label
    Friend WithEvents large_cakeRadioBtn As RadioButton
    Friend WithEvents medium_cakeRadioBtn As RadioButton
    Friend WithEvents small_cakeRadioBtn As RadioButton
    Friend WithEvents no_cakeRadioBtn As RadioButton
    Friend WithEvents cakeLbl2 As Label
    Friend WithEvents cake_customCheckbx As CheckBox
    Friend WithEvents cakeLbl As Label
    Friend WithEvents bannerCheckbx As CheckBox
    Friend WithEvents bannerTxt As TextBox
    Friend WithEvents bck_to_booking_detailBtn As Button
    Friend WithEvents nxt_to_receiptBtn As Button
    Friend WithEvents tot_costTxt As ListBox
    Friend WithEvents totTxt As ListBox
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents costlList As ListBox
    Friend WithEvents detailList As ListBox
    Friend WithEvents bck_to_party_detailBtn As Button
    Friend WithEvents saveBtn As Button
End Class
