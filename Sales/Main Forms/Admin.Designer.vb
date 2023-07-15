<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Me.productsBtn = New System.Windows.Forms.Button()
        Me.stocksBtn = New System.Windows.Forms.Button()
        Me.customersBtn = New System.Windows.Forms.Button()
        Me.transactionsBtn = New System.Windows.Forms.Button()
        Me.logoutBtn = New System.Windows.Forms.Button()
        Me.reportsBtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'productsBtn
        '
        Me.productsBtn.BackColor = System.Drawing.Color.Maroon
        Me.productsBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.productsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.productsBtn.ForeColor = System.Drawing.Color.White
        Me.productsBtn.Location = New System.Drawing.Point(211, 82)
        Me.productsBtn.Name = "productsBtn"
        Me.productsBtn.Size = New System.Drawing.Size(253, 132)
        Me.productsBtn.TabIndex = 0
        Me.productsBtn.Text = "Products" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "View, Add, Update and Delete Products"
        Me.productsBtn.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.productsBtn.UseVisualStyleBackColor = False
        '
        'stocksBtn
        '
        Me.stocksBtn.BackColor = System.Drawing.Color.Maroon
        Me.stocksBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.stocksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.stocksBtn.ForeColor = System.Drawing.Color.White
        Me.stocksBtn.Location = New System.Drawing.Point(211, 220)
        Me.stocksBtn.Name = "stocksBtn"
        Me.stocksBtn.Size = New System.Drawing.Size(253, 132)
        Me.stocksBtn.TabIndex = 2
        Me.stocksBtn.Text = "Stocks" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "View, Add, Update and Delete Stocks" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.stocksBtn.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.stocksBtn.UseVisualStyleBackColor = False
        '
        'customersBtn
        '
        Me.customersBtn.BackColor = System.Drawing.Color.Maroon
        Me.customersBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.customersBtn.ForeColor = System.Drawing.Color.White
        Me.customersBtn.Location = New System.Drawing.Point(651, 82)
        Me.customersBtn.Name = "customersBtn"
        Me.customersBtn.Size = New System.Drawing.Size(253, 132)
        Me.customersBtn.TabIndex = 4
        Me.customersBtn.Text = "Customers" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "View, Add, Update and Delete Customer Details "
        Me.customersBtn.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.customersBtn.UseVisualStyleBackColor = False
        '
        'transactionsBtn
        '
        Me.transactionsBtn.BackColor = System.Drawing.Color.Maroon
        Me.transactionsBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.transactionsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.transactionsBtn.ForeColor = System.Drawing.Color.White
        Me.transactionsBtn.Location = New System.Drawing.Point(651, 220)
        Me.transactionsBtn.Name = "transactionsBtn"
        Me.transactionsBtn.Size = New System.Drawing.Size(253, 132)
        Me.transactionsBtn.TabIndex = 6
        Me.transactionsBtn.Text = "Transactions && Payments" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "View, Create, and Cancellation of Transactions and Pa" & _
    "yments"
        Me.transactionsBtn.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.transactionsBtn.UseVisualStyleBackColor = False
        '
        'logoutBtn
        '
        Me.logoutBtn.BackColor = System.Drawing.Color.Maroon
        Me.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.logoutBtn.ForeColor = System.Drawing.Color.White
        Me.logoutBtn.Location = New System.Drawing.Point(651, 358)
        Me.logoutBtn.Name = "logoutBtn"
        Me.logoutBtn.Size = New System.Drawing.Size(253, 132)
        Me.logoutBtn.TabIndex = 10
        Me.logoutBtn.Text = "Logout" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Closes the Administration Form"
        Me.logoutBtn.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.logoutBtn.UseVisualStyleBackColor = False
        '
        'reportsBtn
        '
        Me.reportsBtn.BackColor = System.Drawing.Color.Maroon
        Me.reportsBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.reportsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.reportsBtn.ForeColor = System.Drawing.Color.White
        Me.reportsBtn.Location = New System.Drawing.Point(211, 358)
        Me.reportsBtn.Name = "reportsBtn"
        Me.reportsBtn.Size = New System.Drawing.Size(253, 132)
        Me.reportsBtn.TabIndex = 8
        Me.reportsBtn.Text = "Reports" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Summary Reports and Sales Reports" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.reportsBtn.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.reportsBtn.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(222, 28)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "ADMINISTRATION FORM"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.RUSI_Sales_Management_System.My.Resources.Resources.close_no_window_log_out_logout_exit_sign_out_stop_quit_cancel_program_icon
        Me.PictureBox5.Location = New System.Drawing.Point(509, 358)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(136, 132)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 11
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.RUSI_Sales_Management_System.My.Resources.Resources.line_chart_icon
        Me.PictureBox6.Location = New System.Drawing.Point(71, 358)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(134, 132)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 9
        Me.PictureBox6.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.RUSI_Sales_Management_System.My.Resources.Resources.Sheets_icon
        Me.PictureBox4.Location = New System.Drawing.Point(509, 220)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(136, 132)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 7
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.RUSI_Sales_Management_System.My.Resources.Resources.Users_icon
        Me.PictureBox3.Location = New System.Drawing.Point(509, 82)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(136, 132)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.RUSI_Sales_Management_System.My.Resources.Resources.StockPlusIcon
        Me.PictureBox2.Location = New System.Drawing.Point(52, 220)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(153, 132)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RUSI_Sales_Management_System.My.Resources.Resources._3d_effect
        Me.PictureBox1.Location = New System.Drawing.Point(71, 82)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(134, 132)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(996, 520)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.logoutBtn)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.reportsBtn)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.transactionsBtn)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.customersBtn)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.stocksBtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.productsBtn)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administration Form"
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents productsBtn As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents stocksBtn As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents customersBtn As System.Windows.Forms.Button
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents transactionsBtn As System.Windows.Forms.Button
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents logoutBtn As System.Windows.Forms.Button
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents reportsBtn As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
