'Date: 20/5/2022
'Author: Zhong Yi Yan
'Program: It allows customers to book a party using an app
'Progress: 
'         create Help form

'Date: 20/5/2022
'Author: Zhong Yi Yan
'Program: It allows customers to book a party using an app
'Progress: 
'         add cakeInfo label
Public Class Help
    Private Sub Help_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'don't close Help, instead, hide
        e.Cancel = True
        'hide Help
        GlobalVariable.help.Hide()
    End Sub

    Private Sub Help_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'add costs of cake
        cake_descripTable.Rows.Add("Small cake", "15cm", "£10.00", "£15.00")
        cake_descripTable.Rows.Add("Medium cake", "25cm", "£20.00", "£30.00")
        cake_descripTable.Rows.Add("Large cake", "40cm", "£35.00", "£52.50")

        'add other costs
        price_descripList.Rows.Add("Administrative cost", "£10.00")
        price_descripList.Rows.Add("Guests fee", "£5.00 per person")
        price_descripList.Rows.Add("Helium Balloons", "£7.50 per 5 ballons")
        price_descripList.Rows.Add("Party bags", "£3.00 per person")
        price_descripList.Rows.Add("Branded water bottles", "£5.00 per person")
        price_descripList.Rows.Add("Socks", "£2.50 per person")
        price_descripList.Rows.Add("The banner", "£5.00")
        price_descripList.Rows.Add("Character written on the banner (space is also count a letter)", "£1.00 per letter")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        'save the picture temporary
        Dim Bitmap = New Bitmap(JumpingFun.My.Resources.book_system)
        Bitmap.Save("book_system.png")
        'open the picture 
        Process.Start("book_system.png")
    End Sub

End Class