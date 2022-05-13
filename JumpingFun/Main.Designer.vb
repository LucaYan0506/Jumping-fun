<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.company_nameLbl = New System.Windows.Forms.Label()
        Me.bookBtn = New System.Windows.Forms.PictureBox()
        CType(Me.bookBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'company_nameLbl
        '
        Me.company_nameLbl.AutoSize = True
        Me.company_nameLbl.BackColor = System.Drawing.Color.Transparent
        Me.company_nameLbl.Font = New System.Drawing.Font("Segoe UI", 51.75!)
        Me.company_nameLbl.ForeColor = System.Drawing.Color.DodgerBlue
        Me.company_nameLbl.Location = New System.Drawing.Point(12, 39)
        Me.company_nameLbl.Name = "company_nameLbl"
        Me.company_nameLbl.Size = New System.Drawing.Size(431, 92)
        Me.company_nameLbl.TabIndex = 0
        Me.company_nameLbl.Text = "Jumping Fun"
        '
        'bookBtn
        '
        Me.bookBtn.BackColor = System.Drawing.Color.Transparent
        Me.bookBtn.BackgroundImage = CType(resources.GetObject("bookBtn.BackgroundImage"), System.Drawing.Image)
        Me.bookBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bookBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bookBtn.Location = New System.Drawing.Point(30, 188)
        Me.bookBtn.Name = "bookBtn"
        Me.bookBtn.Size = New System.Drawing.Size(419, 127)
        Me.bookBtn.TabIndex = 1
        Me.bookBtn.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.JumpingFun.My.Resources.Resources.download
        Me.ClientSize = New System.Drawing.Size(597, 325)
        Me.Controls.Add(Me.bookBtn)
        Me.Controls.Add(Me.company_nameLbl)
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Main"
        Me.Text = "Jumping Fun"
        CType(Me.bookBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents company_nameLbl As Label
    Friend WithEvents bookBtn As PictureBox
End Class
