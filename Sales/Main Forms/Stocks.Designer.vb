<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stocks
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
        Me.viewstockssearchTB = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.viewpicBox = New System.Windows.Forms.PictureBox()
        Me.stocksLbl = New System.Windows.Forms.Label()
        Me.stocknameLbl = New System.Windows.Forms.Label()
        Me.stockidLbl = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.addstockidLbl = New System.Windows.Forms.Label()
        Me.addBtn = New System.Windows.Forms.Button()
        Me.addstocknameTB = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.addpicBox = New System.Windows.Forms.PictureBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.addstocksearchTB = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.deleteBtn = New System.Windows.Forms.Button()
        Me.deletestocknameLbl = New System.Windows.Forms.Label()
        Me.deletestockidLbl = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.deletepicBox = New System.Windows.Forms.PictureBox()
        Me.deletestocksearchTB = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.addstocksTB = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListView3 = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.deletestocksTB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.viewpicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.addpicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.deletepicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
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
        Me.TabPage1.Controls.Add(Me.viewstockssearchTB)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.ListView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 30)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(959, 467)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "View Stocks"
        '
        'viewstockssearchTB
        '
        Me.viewstockssearchTB.Location = New System.Drawing.Point(727, 15)
        Me.viewstockssearchTB.Name = "viewstockssearchTB"
        Me.viewstockssearchTB.Size = New System.Drawing.Size(224, 29)
        Me.viewstockssearchTB.TabIndex = 1
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
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.stocksLbl)
        Me.GroupBox1.Controls.Add(Me.stocknameLbl)
        Me.GroupBox1.Controls.Add(Me.stockidLbl)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 210)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(943, 249)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Preview Details"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.viewpicBox)
        Me.GroupBox4.Location = New System.Drawing.Point(25, 18)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(215, 193)
        Me.GroupBox4.TabIndex = 53
        Me.GroupBox4.TabStop = False
        '
        'viewpicBox
        '
        Me.viewpicBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.viewpicBox.Location = New System.Drawing.Point(3, 25)
        Me.viewpicBox.Name = "viewpicBox"
        Me.viewpicBox.Size = New System.Drawing.Size(209, 165)
        Me.viewpicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.viewpicBox.TabIndex = 39
        Me.viewpicBox.TabStop = False
        '
        'stocksLbl
        '
        Me.stocksLbl.AutoSize = True
        Me.stocksLbl.Location = New System.Drawing.Point(419, 136)
        Me.stocksLbl.Name = "stocksLbl"
        Me.stocksLbl.Size = New System.Drawing.Size(16, 21)
        Me.stocksLbl.TabIndex = 52
        Me.stocksLbl.Text = "-"
        '
        'stocknameLbl
        '
        Me.stocknameLbl.AutoSize = True
        Me.stocknameLbl.Location = New System.Drawing.Point(419, 105)
        Me.stocknameLbl.Name = "stocknameLbl"
        Me.stocknameLbl.Size = New System.Drawing.Size(16, 21)
        Me.stocknameLbl.TabIndex = 48
        Me.stocknameLbl.Text = "-"
        '
        'stockidLbl
        '
        Me.stockidLbl.AutoSize = True
        Me.stockidLbl.Location = New System.Drawing.Point(419, 74)
        Me.stockidLbl.Name = "stockidLbl"
        Me.stockidLbl.Size = New System.Drawing.Size(16, 21)
        Me.stockidLbl.TabIndex = 47
        Me.stockidLbl.Text = "-"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(279, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 21)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Available Stocks:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(279, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 21)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(279, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 21)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Product ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(46, 214)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 21)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Product Image Preview"
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.Maroon
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader6})
        Me.ListView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListView1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ListView1.ForeColor = System.Drawing.Color.White
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.Location = New System.Drawing.Point(8, 53)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(945, 151)
        Me.ListView1.TabIndex = 34
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Product ID"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 700
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Available Stocks"
        Me.ColumnHeader6.Width = 140
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.DodgerBlue
        Me.TabPage3.Controls.Add(Me.ListView2)
        Me.TabPage3.Controls.Add(Me.GroupBox5)
        Me.TabPage3.Controls.Add(Me.addstocksearchTB)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Location = New System.Drawing.Point(4, 30)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(959, 467)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Stocks In"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.addstocksTB)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.addstockidLbl)
        Me.GroupBox5.Controls.Add(Me.addBtn)
        Me.GroupBox5.Controls.Add(Me.addstocknameTB)
        Me.GroupBox5.Controls.Add(Me.GroupBox6)
        Me.GroupBox5.Controls.Add(Me.Label26)
        Me.GroupBox5.Controls.Add(Me.Label27)
        Me.GroupBox5.Controls.Add(Me.Label28)
        Me.GroupBox5.Enabled = False
        Me.GroupBox5.Location = New System.Drawing.Point(8, 210)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(943, 249)
        Me.GroupBox5.TabIndex = 57
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Preview Details"
        '
        'addstockidLbl
        '
        Me.addstockidLbl.AutoSize = True
        Me.addstockidLbl.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.addstockidLbl.Location = New System.Drawing.Point(427, 72)
        Me.addstockidLbl.Name = "addstockidLbl"
        Me.addstockidLbl.Size = New System.Drawing.Size(16, 21)
        Me.addstockidLbl.TabIndex = 61
        Me.addstockidLbl.Text = "-"
        '
        'addBtn
        '
        Me.addBtn.BackColor = System.Drawing.Color.Maroon
        Me.addBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addBtn.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.addBtn.ForeColor = System.Drawing.Color.White
        Me.addBtn.Location = New System.Drawing.Point(760, 90)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(130, 41)
        Me.addBtn.TabIndex = 59
        Me.addBtn.Text = "ADD STOCKS"
        Me.addBtn.UseVisualStyleBackColor = False
        '
        'addstocknameTB
        '
        Me.addstocknameTB.Enabled = False
        Me.addstocknameTB.Location = New System.Drawing.Point(431, 104)
        Me.addstocknameTB.Name = "addstocknameTB"
        Me.addstocknameTB.Size = New System.Drawing.Size(282, 29)
        Me.addstocknameTB.TabIndex = 55
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.addpicBox)
        Me.GroupBox6.Location = New System.Drawing.Point(25, 18)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(215, 193)
        Me.GroupBox6.TabIndex = 53
        Me.GroupBox6.TabStop = False
        '
        'addpicBox
        '
        Me.addpicBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.addpicBox.Location = New System.Drawing.Point(3, 25)
        Me.addpicBox.Name = "addpicBox"
        Me.addpicBox.Size = New System.Drawing.Size(209, 165)
        Me.addpicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.addpicBox.TabIndex = 39
        Me.addpicBox.TabStop = False
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label26.Location = New System.Drawing.Point(279, 107)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(55, 21)
        Me.Label26.TabIndex = 42
        Me.Label26.Text = "Name:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label27.Location = New System.Drawing.Point(279, 72)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(86, 21)
        Me.Label27.TabIndex = 41
        Me.Label27.Text = "Product ID:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(46, 214)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(164, 21)
        Me.Label28.TabIndex = 40
        Me.Label28.Text = "Product Image Preview"
        '
        'addstocksearchTB
        '
        Me.addstocksearchTB.Location = New System.Drawing.Point(727, 15)
        Me.addstocksearchTB.Name = "addstocksearchTB"
        Me.addstocksearchTB.Size = New System.Drawing.Size(224, 29)
        Me.addstocksearchTB.TabIndex = 54
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
        Me.TabPage4.Controls.Add(Me.ListView3)
        Me.TabPage4.Controls.Add(Me.GroupBox7)
        Me.TabPage4.Controls.Add(Me.deletestocksearchTB)
        Me.TabPage4.Controls.Add(Me.Label17)
        Me.TabPage4.Location = New System.Drawing.Point(4, 30)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(959, 467)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Stocks Out"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.deletestocksTB)
        Me.GroupBox7.Controls.Add(Me.Label4)
        Me.GroupBox7.Controls.Add(Me.deleteBtn)
        Me.GroupBox7.Controls.Add(Me.deletestocknameLbl)
        Me.GroupBox7.Controls.Add(Me.deletestockidLbl)
        Me.GroupBox7.Controls.Add(Me.Label21)
        Me.GroupBox7.Controls.Add(Me.Label22)
        Me.GroupBox7.Controls.Add(Me.Label18)
        Me.GroupBox7.Controls.Add(Me.GroupBox8)
        Me.GroupBox7.Location = New System.Drawing.Point(8, 212)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(943, 247)
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
        Me.deleteBtn.Location = New System.Drawing.Point(747, 101)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(140, 41)
        Me.deleteBtn.TabIndex = 60
        Me.deleteBtn.Text = "DELETE STOCKS"
        Me.deleteBtn.UseVisualStyleBackColor = False
        '
        'deletestocknameLbl
        '
        Me.deletestocknameLbl.AutoSize = True
        Me.deletestocknameLbl.Location = New System.Drawing.Point(422, 107)
        Me.deletestocknameLbl.Name = "deletestocknameLbl"
        Me.deletestocknameLbl.Size = New System.Drawing.Size(16, 21)
        Me.deletestocknameLbl.TabIndex = 59
        Me.deletestocknameLbl.Text = "-"
        '
        'deletestockidLbl
        '
        Me.deletestockidLbl.AutoSize = True
        Me.deletestockidLbl.Location = New System.Drawing.Point(422, 76)
        Me.deletestockidLbl.Name = "deletestockidLbl"
        Me.deletestockidLbl.Size = New System.Drawing.Size(16, 21)
        Me.deletestockidLbl.TabIndex = 58
        Me.deletestockidLbl.Text = "-"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label21.Location = New System.Drawing.Point(282, 107)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(55, 21)
        Me.Label21.TabIndex = 57
        Me.Label21.Text = "Name:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label22.Location = New System.Drawing.Point(282, 76)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(86, 21)
        Me.Label22.TabIndex = 56
        Me.Label22.Text = "Product ID:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(43, 215)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(164, 21)
        Me.Label18.TabIndex = 55
        Me.Label18.Text = "Product Image Preview"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.deletepicBox)
        Me.GroupBox8.Location = New System.Drawing.Point(25, 20)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(215, 193)
        Me.GroupBox8.TabIndex = 54
        Me.GroupBox8.TabStop = False
        '
        'deletepicBox
        '
        Me.deletepicBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.deletepicBox.Location = New System.Drawing.Point(3, 25)
        Me.deletepicBox.Name = "deletepicBox"
        Me.deletepicBox.Size = New System.Drawing.Size(209, 165)
        Me.deletepicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.deletepicBox.TabIndex = 39
        Me.deletepicBox.TabStop = False
        '
        'deletestocksearchTB
        '
        Me.deletestocksearchTB.Location = New System.Drawing.Point(727, 15)
        Me.deletestocksearchTB.Name = "deletestocksearchTB"
        Me.deletestocksearchTB.Size = New System.Drawing.Size(224, 29)
        Me.deletestocksearchTB.TabIndex = 57
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
        'addstocksTB
        '
        Me.addstocksTB.Location = New System.Drawing.Point(431, 139)
        Me.addstocksTB.Name = "addstocksTB"
        Me.addstocksTB.Size = New System.Drawing.Size(282, 29)
        Me.addstocksTB.TabIndex = 63
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(279, 142)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 21)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "Stocks:"
        '
        'ListView2
        '
        Me.ListView2.BackColor = System.Drawing.Color.Maroon
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListView2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListView2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ListView2.ForeColor = System.Drawing.Color.White
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView2.Location = New System.Drawing.Point(8, 53)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(945, 151)
        Me.ListView2.TabIndex = 58
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Product ID"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Name"
        Me.ColumnHeader4.Width = 700
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Available Stocks"
        Me.ColumnHeader5.Width = 140
        '
        'ListView3
        '
        Me.ListView3.BackColor = System.Drawing.Color.Maroon
        Me.ListView3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.ListView3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListView3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ListView3.ForeColor = System.Drawing.Color.White
        Me.ListView3.FullRowSelect = True
        Me.ListView3.GridLines = True
        Me.ListView3.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView3.Location = New System.Drawing.Point(8, 53)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(945, 151)
        Me.ListView3.TabIndex = 61
        Me.ListView3.UseCompatibleStateImageBehavior = False
        Me.ListView3.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Product ID"
        Me.ColumnHeader7.Width = 100
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Name"
        Me.ColumnHeader8.Width = 700
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Available Stocks"
        Me.ColumnHeader9.Width = 140
        '
        'deletestocksTB
        '
        Me.deletestocksTB.Location = New System.Drawing.Point(426, 135)
        Me.deletestocksTB.Name = "deletestocksTB"
        Me.deletestocksTB.Size = New System.Drawing.Size(282, 29)
        Me.deletestocksTB.TabIndex = 65
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(282, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 21)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Stocks:"
        '
        'Stocks
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
        Me.Name = "Stocks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stocks Form"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.viewpicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.addpicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        CType(Me.deletepicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents viewstockssearchTB As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents viewpicBox As System.Windows.Forms.PictureBox
    Friend WithEvents stocksLbl As System.Windows.Forms.Label
    Friend WithEvents stocknameLbl As System.Windows.Forms.Label
    Friend WithEvents stockidLbl As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents addstocksTB As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents addstockidLbl As System.Windows.Forms.Label
    Friend WithEvents addBtn As System.Windows.Forms.Button
    Friend WithEvents addstocknameTB As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents addpicBox As System.Windows.Forms.PictureBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents addstocksearchTB As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents ListView3 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents deleteBtn As System.Windows.Forms.Button
    Friend WithEvents deletestocknameLbl As System.Windows.Forms.Label
    Friend WithEvents deletestockidLbl As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents deletepicBox As System.Windows.Forms.PictureBox
    Friend WithEvents deletestocksearchTB As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents deletestocksTB As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
