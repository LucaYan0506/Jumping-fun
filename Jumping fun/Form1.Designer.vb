<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.AccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateAnAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckPreviousReceiptsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WhyCreateAnAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HeloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FeedbackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SignOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AccountToolStripMenuItem
        '
        Me.AccountToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.CreateAnAccountToolStripMenuItem, Me.ToolStripMenuItem1, Me.CheckPreviousReceiptsToolStripMenuItem, Me.WhyCreateAnAccountToolStripMenuItem, Me.SignOutToolStripMenuItem})
        Me.AccountToolStripMenuItem.Name = "AccountToolStripMenuItem"
        Me.AccountToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.AccountToolStripMenuItem.Text = "Account"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'CreateAnAccountToolStripMenuItem
        '
        Me.CreateAnAccountToolStripMenuItem.Name = "CreateAnAccountToolStripMenuItem"
        Me.CreateAnAccountToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.CreateAnAccountToolStripMenuItem.Text = "Register"
        '
        'CheckPreviousReceiptsToolStripMenuItem
        '
        Me.CheckPreviousReceiptsToolStripMenuItem.Name = "CheckPreviousReceiptsToolStripMenuItem"
        Me.CheckPreviousReceiptsToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.CheckPreviousReceiptsToolStripMenuItem.Text = "Check previous receipts"
        '
        'WhyCreateAnAccountToolStripMenuItem
        '
        Me.WhyCreateAnAccountToolStripMenuItem.Name = "WhyCreateAnAccountToolStripMenuItem"
        Me.WhyCreateAnAccountToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.WhyCreateAnAccountToolStripMenuItem.Text = "Why create an account"
        '
        'HeloToolStripMenuItem
        '
        Me.HeloToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem, Me.ContactToolStripMenuItem, Me.FeedbackToolStripMenuItem})
        Me.HeloToolStripMenuItem.Name = "HeloToolStripMenuItem"
        Me.HeloToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HeloToolStripMenuItem.Text = "Help"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ContactToolStripMenuItem
        '
        Me.ContactToolStripMenuItem.Name = "ContactToolStripMenuItem"
        Me.ContactToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ContactToolStripMenuItem.Text = "Contact Support"
        '
        'FeedbackToolStripMenuItem
        '
        Me.FeedbackToolStripMenuItem.Name = "FeedbackToolStripMenuItem"
        Me.FeedbackToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.FeedbackToolStripMenuItem.Text = "Feedback"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccountToolStripMenuItem, Me.HeloToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(315, 372)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SignOutToolStripMenuItem
        '
        Me.SignOutToolStripMenuItem.Name = "SignOutToolStripMenuItem"
        Me.SignOutToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.SignOutToolStripMenuItem.Text = "Sign out"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(199, 22)
        Me.ToolStripMenuItem1.Text = "Manage account"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreateAnAccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HeloToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FeedbackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckPreviousReceiptsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WhyCreateAnAccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SignOutToolStripMenuItem As ToolStripMenuItem
End Class
