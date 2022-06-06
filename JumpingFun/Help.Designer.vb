<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Help
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Help))
        Me.reqLbl = New System.Windows.Forms.Label()
        Me.req_descripLbl = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.price_descripList = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.emptyBox = New System.Windows.Forms.PictureBox()
        Me.priceLbl = New System.Windows.Forms.Label()
        Me.cake_descripTable = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cakeLbl = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cakeInfo = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.price_descripList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.emptyBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cake_descripTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'reqLbl
        '
        Me.reqLbl.AutoSize = True
        Me.reqLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reqLbl.Location = New System.Drawing.Point(8, 9)
        Me.reqLbl.Name = "reqLbl"
        Me.reqLbl.Size = New System.Drawing.Size(274, 20)
        Me.reqLbl.TabIndex = 0
        Me.reqLbl.Text = "Minimum requirements for a sale "
        '
        'req_descripLbl
        '
        Me.req_descripLbl.AutoSize = True
        Me.req_descripLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.req_descripLbl.Location = New System.Drawing.Point(12, 58)
        Me.req_descripLbl.Name = "req_descripLbl"
        Me.req_descripLbl.Size = New System.Drawing.Size(308, 96)
        Me.req_descripLbl.TabIndex = 1
        Me.req_descripLbl.Text = "To book the party please insert the following detail:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  - your name " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  - first " &
    "line of the address " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  - postcode" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  - telephone number" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  - date of party"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.cakeInfo)
        Me.Panel1.Controls.Add(Me.price_descripList)
        Me.Panel1.Controls.Add(Me.emptyBox)
        Me.Panel1.Controls.Add(Me.priceLbl)
        Me.Panel1.Controls.Add(Me.cake_descripTable)
        Me.Panel1.Controls.Add(Me.cakeLbl)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.reqLbl)
        Me.Panel1.Controls.Add(Me.req_descripLbl)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(501, 549)
        Me.Panel1.TabIndex = 3
        '
        'price_descripList
        '
        Me.price_descripList.AllowUserToAddRows = False
        Me.price_descripList.AllowUserToDeleteRows = False
        Me.price_descripList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.price_descripList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.price_descripList.Location = New System.Drawing.Point(12, 425)
        Me.price_descripList.Name = "price_descripList"
        Me.price_descripList.ReadOnly = True
        Me.price_descripList.Size = New System.Drawing.Size(471, 199)
        Me.price_descripList.TabIndex = 6
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.FillWeight = 194.9239!
        Me.DataGridViewTextBoxColumn1.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 317
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.FillWeight = 5.076141!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Cost"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 110
        '
        'emptyBox
        '
        Me.emptyBox.Location = New System.Drawing.Point(36, 537)
        Me.emptyBox.Name = "emptyBox"
        Me.emptyBox.Size = New System.Drawing.Size(100, 50)
        Me.emptyBox.TabIndex = 7
        Me.emptyBox.TabStop = False
        '
        'priceLbl
        '
        Me.priceLbl.AutoSize = True
        Me.priceLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.priceLbl.Location = New System.Drawing.Point(11, 402)
        Me.priceLbl.Name = "priceLbl"
        Me.priceLbl.Size = New System.Drawing.Size(49, 20)
        Me.priceLbl.TabIndex = 5
        Me.priceLbl.Text = "Price"
        '
        'cake_descripTable
        '
        Me.cake_descripTable.AllowUserToAddRows = False
        Me.cake_descripTable.AllowUserToDeleteRows = False
        Me.cake_descripTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.cake_descripTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.cake_descripTable.Location = New System.Drawing.Point(12, 236)
        Me.cake_descripTable.Name = "cake_descripTable"
        Me.cake_descripTable.ReadOnly = True
        Me.cake_descripTable.Size = New System.Drawing.Size(471, 102)
        Me.cake_descripTable.TabIndex = 4
        '
        'Column1
        '
        Me.Column1.HeaderText = "Type of cake"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Size"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Price (normal cake)"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Price (customised cake)"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 128
        '
        'cakeLbl
        '
        Me.cakeLbl.AutoSize = True
        Me.cakeLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cakeLbl.Location = New System.Drawing.Point(8, 213)
        Me.cakeLbl.Name = "cakeLbl"
        Me.cakeLbl.Size = New System.Drawing.Size(182, 20)
        Me.cakeLbl.TabIndex = 3
        Me.cakeLbl.Text = "Cake selection option"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.JumpingFun.My.Resources.Resources.book_system
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Location = New System.Drawing.Point(326, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(102, 156)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'cakeInfo
        '
        Me.cakeInfo.Location = New System.Drawing.Point(12, 341)
        Me.cakeInfo.Name = "cakeInfo"
        Me.cakeInfo.Size = New System.Drawing.Size(469, 61)
        Me.cakeInfo.TabIndex = 8
        Me.cakeInfo.Text = resources.GetString("cakeInfo.Text")
        '
        'Help
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 546)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Help"
        Me.Text = "Help"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.price_descripList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.emptyBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cake_descripTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents reqLbl As Label
    Friend WithEvents req_descripLbl As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cakeLbl As Label
    Friend WithEvents cake_descripTable As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents price_descripList As DataGridView
    Friend WithEvents priceLbl As Label
    Friend WithEvents emptyBox As PictureBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents cakeInfo As Label
End Class
