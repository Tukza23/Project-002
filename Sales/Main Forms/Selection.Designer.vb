<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Selection
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
        Me.transactionBtn = New System.Windows.Forms.Button()
        Me.paymentsBtn = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'transactionBtn
        '
        Me.transactionBtn.BackColor = System.Drawing.Color.Maroon
        Me.transactionBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.transactionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.transactionBtn.ForeColor = System.Drawing.Color.White
        Me.transactionBtn.Location = New System.Drawing.Point(573, 53)
        Me.transactionBtn.Name = "transactionBtn"
        Me.transactionBtn.Size = New System.Drawing.Size(253, 132)
        Me.transactionBtn.TabIndex = 8
        Me.transactionBtn.Text = "Transactions" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "View, Create and Cancellation of Transactions"
        Me.transactionBtn.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.transactionBtn.UseVisualStyleBackColor = False
        '
        'paymentsBtn
        '
        Me.paymentsBtn.BackColor = System.Drawing.Color.Maroon
        Me.paymentsBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.paymentsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.paymentsBtn.ForeColor = System.Drawing.Color.White
        Me.paymentsBtn.Location = New System.Drawing.Point(164, 53)
        Me.paymentsBtn.Name = "paymentsBtn"
        Me.paymentsBtn.Size = New System.Drawing.Size(253, 132)
        Me.paymentsBtn.TabIndex = 6
        Me.paymentsBtn.Text = "Payments" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "View and Update Payments"
        Me.paymentsBtn.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.paymentsBtn.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.RUSI_Sales_Management_System.My.Resources.Resources.Users_icon
        Me.PictureBox3.Location = New System.Drawing.Point(431, 53)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(136, 132)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RUSI_Sales_Management_System.My.Resources.Resources._3d_effect
        Me.PictureBox1.Location = New System.Drawing.Point(24, 53)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(134, 132)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Selection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(855, 242)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.transactionBtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.paymentsBtn)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Selection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selection Form"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents transactionBtn As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents paymentsBtn As System.Windows.Forms.Button
End Class
