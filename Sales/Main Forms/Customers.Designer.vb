<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customers
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.viewcustomersearchTB = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.addressLbl = New System.Windows.Forms.Label()
        Me.contactLbl = New System.Windows.Forms.Label()
        Me.customernameLbl = New System.Windows.Forms.Label()
        Me.customeridLbl = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.addBtn = New System.Windows.Forms.Button()
        Me.addaddressTB = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.addcontactTB = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.addnameTB = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.updateBtn = New System.Windows.Forms.Button()
        Me.updatecustomeridLbl = New System.Windows.Forms.Label()
        Me.updatecustomeraddressTB = New System.Windows.Forms.TextBox()
        Me.updatecustomercontactTB = New System.Windows.Forms.TextBox()
        Me.updatecustomernameTB = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.updatecustomersearchTB = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.deleteBtn = New System.Windows.Forms.Button()
        Me.deletecustomernameLbl = New System.Windows.Forms.Label()
        Me.deletecustomeridLbl = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.deletecustomersearchTB = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ListView3 = New System.Windows.Forms.ListView()
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(967, 501)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.DodgerBlue
        Me.TabPage1.Controls.Add(Me.viewcustomersearchTB)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.ListView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 30)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(959, 467)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "View Customers"
        '
        'viewcustomersearchTB
        '
        Me.viewcustomersearchTB.Location = New System.Drawing.Point(727, 15)
        Me.viewcustomersearchTB.Name = "viewcustomersearchTB"
        Me.viewcustomersearchTB.Size = New System.Drawing.Size(224, 29)
        Me.viewcustomersearchTB.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(624, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 21)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Search Here:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.addressLbl)
        Me.GroupBox1.Controls.Add(Me.contactLbl)
        Me.GroupBox1.Controls.Add(Me.customernameLbl)
        Me.GroupBox1.Controls.Add(Me.customeridLbl)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 284)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(943, 168)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Preview Details"
        '
        'addressLbl
        '
        Me.addressLbl.AutoSize = True
        Me.addressLbl.Location = New System.Drawing.Point(173, 126)
        Me.addressLbl.Name = "addressLbl"
        Me.addressLbl.Size = New System.Drawing.Size(16, 21)
        Me.addressLbl.TabIndex = 50
        Me.addressLbl.Text = "-"
        '
        'contactLbl
        '
        Me.contactLbl.AutoSize = True
        Me.contactLbl.Location = New System.Drawing.Point(173, 96)
        Me.contactLbl.Name = "contactLbl"
        Me.contactLbl.Size = New System.Drawing.Size(16, 21)
        Me.contactLbl.TabIndex = 49
        Me.contactLbl.Text = "-"
        '
        'customernameLbl
        '
        Me.customernameLbl.AutoSize = True
        Me.customernameLbl.Location = New System.Drawing.Point(173, 66)
        Me.customernameLbl.Name = "customernameLbl"
        Me.customernameLbl.Size = New System.Drawing.Size(16, 21)
        Me.customernameLbl.TabIndex = 48
        Me.customernameLbl.Text = "-"
        '
        'customeridLbl
        '
        Me.customeridLbl.AutoSize = True
        Me.customeridLbl.Location = New System.Drawing.Point(173, 36)
        Me.customeridLbl.Name = "customeridLbl"
        Me.customeridLbl.Size = New System.Drawing.Size(16, 21)
        Me.customeridLbl.TabIndex = 47
        Me.customeridLbl.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(33, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 21)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Address:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(33, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 21)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Contact #:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(33, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 21)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(33, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 21)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Customer ID:"
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.Maroon
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListView1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ListView1.ForeColor = System.Drawing.Color.White
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.Location = New System.Drawing.Point(8, 53)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(945, 225)
        Me.ListView1.TabIndex = 34
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Customer ID"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 390
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Contact No."
        Me.ColumnHeader3.Width = 130
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Address"
        Me.ColumnHeader4.Width = 320
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.DodgerBlue
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 30)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(959, 467)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Add Customer"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.addBtn)
        Me.GroupBox2.Controls.Add(Me.addaddressTB)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.addcontactTB)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.addnameTB)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(50, 51)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(854, 375)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Product Details"
        '
        'addBtn
        '
        Me.addBtn.BackColor = System.Drawing.Color.Maroon
        Me.addBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addBtn.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.addBtn.ForeColor = System.Drawing.Color.White
        Me.addBtn.Location = New System.Drawing.Point(685, 261)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(130, 41)
        Me.addBtn.TabIndex = 6
        Me.addBtn.Text = "ADD"
        Me.addBtn.UseVisualStyleBackColor = False
        '
        'addaddressTB
        '
        Me.addaddressTB.Location = New System.Drawing.Point(150, 127)
        Me.addaddressTB.Multiline = True
        Me.addaddressTB.Name = "addaddressTB"
        Me.addaddressTB.Size = New System.Drawing.Size(665, 116)
        Me.addaddressTB.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(33, 130)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 21)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Address:"
        '
        'addcontactTB
        '
        Me.addcontactTB.Location = New System.Drawing.Point(531, 80)
        Me.addcontactTB.Name = "addcontactTB"
        Me.addcontactTB.Size = New System.Drawing.Size(284, 29)
        Me.addcontactTB.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(445, 83)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 21)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Contact #:"
        '
        'addnameTB
        '
        Me.addnameTB.Location = New System.Drawing.Point(150, 80)
        Me.addnameTB.Name = "addnameTB"
        Me.addnameTB.Size = New System.Drawing.Size(284, 29)
        Me.addnameTB.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(33, 83)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 21)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Name:"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.DodgerBlue
        Me.TabPage3.Controls.Add(Me.GroupBox3)
        Me.TabPage3.Controls.Add(Me.ListView2)
        Me.TabPage3.Controls.Add(Me.updatecustomersearchTB)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Location = New System.Drawing.Point(4, 30)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(959, 467)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Update Customer Details"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.updateBtn)
        Me.GroupBox3.Controls.Add(Me.updatecustomeridLbl)
        Me.GroupBox3.Controls.Add(Me.updatecustomeraddressTB)
        Me.GroupBox3.Controls.Add(Me.updatecustomercontactTB)
        Me.GroupBox3.Controls.Add(Me.updatecustomernameTB)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Enabled = False
        Me.GroupBox3.Location = New System.Drawing.Point(8, 275)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(943, 168)
        Me.GroupBox3.TabIndex = 58
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Preview Details"
        '
        'updateBtn
        '
        Me.updateBtn.BackColor = System.Drawing.Color.Maroon
        Me.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.updateBtn.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.updateBtn.ForeColor = System.Drawing.Color.White
        Me.updateBtn.Location = New System.Drawing.Point(770, 59)
        Me.updateBtn.Name = "updateBtn"
        Me.updateBtn.Size = New System.Drawing.Size(130, 41)
        Me.updateBtn.TabIndex = 49
        Me.updateBtn.Text = "UPDATE"
        Me.updateBtn.UseVisualStyleBackColor = False
        '
        'updatecustomeridLbl
        '
        Me.updatecustomeridLbl.AutoSize = True
        Me.updatecustomeridLbl.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.updatecustomeridLbl.Location = New System.Drawing.Point(142, 36)
        Me.updatecustomeridLbl.Name = "updatecustomeridLbl"
        Me.updatecustomeridLbl.Size = New System.Drawing.Size(16, 21)
        Me.updatecustomeridLbl.TabIndex = 48
        Me.updatecustomeridLbl.Text = "-"
        '
        'updatecustomeraddressTB
        '
        Me.updatecustomeraddressTB.Location = New System.Drawing.Point(483, 36)
        Me.updatecustomeraddressTB.Multiline = True
        Me.updatecustomeraddressTB.Name = "updatecustomeraddressTB"
        Me.updatecustomeraddressTB.Size = New System.Drawing.Size(249, 94)
        Me.updatecustomeraddressTB.TabIndex = 47
        '
        'updatecustomercontactTB
        '
        Me.updatecustomercontactTB.Location = New System.Drawing.Point(146, 101)
        Me.updatecustomercontactTB.Name = "updatecustomercontactTB"
        Me.updatecustomercontactTB.Size = New System.Drawing.Size(249, 29)
        Me.updatecustomercontactTB.TabIndex = 46
        '
        'updatecustomernameTB
        '
        Me.updatecustomernameTB.Location = New System.Drawing.Point(146, 66)
        Me.updatecustomernameTB.Name = "updatecustomernameTB"
        Me.updatecustomernameTB.Size = New System.Drawing.Size(249, 29)
        Me.updatecustomernameTB.TabIndex = 45
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label13.Location = New System.Drawing.Point(408, 39)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 21)
        Me.Label13.TabIndex = 44
        Me.Label13.Text = "Address:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label14.Location = New System.Drawing.Point(33, 104)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 21)
        Me.Label14.TabIndex = 43
        Me.Label14.Text = "Contact #:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label16.Location = New System.Drawing.Point(33, 69)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 21)
        Me.Label16.TabIndex = 42
        Me.Label16.Text = "Name:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label19.Location = New System.Drawing.Point(33, 39)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(100, 21)
        Me.Label19.TabIndex = 41
        Me.Label19.Text = "Customer ID:"
        '
        'ListView2
        '
        Me.ListView2.BackColor = System.Drawing.Color.Maroon
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.ListView2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListView2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ListView2.ForeColor = System.Drawing.Color.White
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView2.Location = New System.Drawing.Point(8, 53)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(945, 216)
        Me.ListView2.TabIndex = 57
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Customer ID"
        Me.ColumnHeader5.Width = 100
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Name"
        Me.ColumnHeader6.Width = 390
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Contact No."
        Me.ColumnHeader7.Width = 130
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Address"
        Me.ColumnHeader8.Width = 320
        '
        'updatecustomersearchTB
        '
        Me.updatecustomersearchTB.Location = New System.Drawing.Point(727, 15)
        Me.updatecustomersearchTB.Name = "updatecustomersearchTB"
        Me.updatecustomersearchTB.Size = New System.Drawing.Size(224, 29)
        Me.updatecustomersearchTB.TabIndex = 54
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label15.Location = New System.Drawing.Point(624, 18)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(97, 21)
        Me.Label15.TabIndex = 56
        Me.Label15.Text = "Search Here:"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.DodgerBlue
        Me.TabPage4.Controls.Add(Me.GroupBox7)
        Me.TabPage4.Controls.Add(Me.deletecustomersearchTB)
        Me.TabPage4.Controls.Add(Me.Label17)
        Me.TabPage4.Controls.Add(Me.ListView3)
        Me.TabPage4.Location = New System.Drawing.Point(4, 30)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(959, 467)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Delete Customer Details"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.deleteBtn)
        Me.GroupBox7.Controls.Add(Me.deletecustomernameLbl)
        Me.GroupBox7.Controls.Add(Me.deletecustomeridLbl)
        Me.GroupBox7.Controls.Add(Me.Label21)
        Me.GroupBox7.Controls.Add(Me.Label22)
        Me.GroupBox7.Location = New System.Drawing.Point(8, 279)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(943, 180)
        Me.GroupBox7.TabIndex = 60
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Preview Details"
        '
        'deleteBtn
        '
        Me.deleteBtn.BackColor = System.Drawing.Color.Maroon
        Me.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.deleteBtn.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.deleteBtn.ForeColor = System.Drawing.Color.White
        Me.deleteBtn.Location = New System.Drawing.Point(752, 79)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(130, 41)
        Me.deleteBtn.TabIndex = 60
        Me.deleteBtn.Text = "DELETE"
        Me.deleteBtn.UseVisualStyleBackColor = False
        '
        'deletecustomernameLbl
        '
        Me.deletecustomernameLbl.AutoSize = True
        Me.deletecustomernameLbl.Location = New System.Drawing.Point(189, 100)
        Me.deletecustomernameLbl.Name = "deletecustomernameLbl"
        Me.deletecustomernameLbl.Size = New System.Drawing.Size(16, 21)
        Me.deletecustomernameLbl.TabIndex = 59
        Me.deletecustomernameLbl.Text = "-"
        '
        'deletecustomeridLbl
        '
        Me.deletecustomeridLbl.AutoSize = True
        Me.deletecustomeridLbl.Location = New System.Drawing.Point(189, 69)
        Me.deletecustomeridLbl.Name = "deletecustomeridLbl"
        Me.deletecustomeridLbl.Size = New System.Drawing.Size(16, 21)
        Me.deletecustomeridLbl.TabIndex = 58
        Me.deletecustomeridLbl.Text = "-"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label21.Location = New System.Drawing.Point(49, 100)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(55, 21)
        Me.Label21.TabIndex = 57
        Me.Label21.Text = "Name:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label22.Location = New System.Drawing.Point(49, 69)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(100, 21)
        Me.Label22.TabIndex = 56
        Me.Label22.Text = "Customer ID:"
        '
        'deletecustomersearchTB
        '
        Me.deletecustomersearchTB.Location = New System.Drawing.Point(727, 15)
        Me.deletecustomersearchTB.Name = "deletecustomersearchTB"
        Me.deletecustomersearchTB.Size = New System.Drawing.Size(224, 29)
        Me.deletecustomersearchTB.TabIndex = 57
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label17.Location = New System.Drawing.Point(624, 18)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(97, 21)
        Me.Label17.TabIndex = 59
        Me.Label17.Text = "Search Here:"
        '
        'ListView3
        '
        Me.ListView3.BackColor = System.Drawing.Color.Maroon
        Me.ListView3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader13, Me.ColumnHeader14})
        Me.ListView3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListView3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ListView3.ForeColor = System.Drawing.Color.White
        Me.ListView3.FullRowSelect = True
        Me.ListView3.GridLines = True
        Me.ListView3.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView3.Location = New System.Drawing.Point(8, 53)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(945, 220)
        Me.ListView3.TabIndex = 58
        Me.ListView3.UseCompatibleStateImageBehavior = False
        Me.ListView3.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Customer ID"
        Me.ColumnHeader13.Width = 100
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Name"
        Me.ColumnHeader14.Width = 840
        '
        'Customers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(967, 501)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Customers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customers Form"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents viewcustomersearchTB As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents addressLbl As System.Windows.Forms.Label
    Friend WithEvents contactLbl As System.Windows.Forms.Label
    Friend WithEvents customernameLbl As System.Windows.Forms.Label
    Friend WithEvents customeridLbl As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents addBtn As System.Windows.Forms.Button
    Friend WithEvents addaddressTB As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents addcontactTB As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents addnameTB As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents updatecustomersearchTB As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents deleteBtn As System.Windows.Forms.Button
    Friend WithEvents deletecustomernameLbl As System.Windows.Forms.Label
    Friend WithEvents deletecustomeridLbl As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents deletecustomersearchTB As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents ListView3 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents updatecustomeridLbl As System.Windows.Forms.Label
    Friend WithEvents updatecustomeraddressTB As System.Windows.Forms.TextBox
    Friend WithEvents updatecustomercontactTB As System.Windows.Forms.TextBox
    Friend WithEvents updatecustomernameTB As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents updateBtn As System.Windows.Forms.Button
End Class
