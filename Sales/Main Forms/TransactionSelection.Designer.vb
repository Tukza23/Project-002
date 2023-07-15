<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransactionSelection
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
        Me.summaryBtn = New System.Windows.Forms.Button()
        Me.individualBtn = New System.Windows.Forms.Button()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'summaryBtn
        '
        Me.summaryBtn.BackColor = System.Drawing.Color.Maroon
        Me.summaryBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.summaryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.summaryBtn.ForeColor = System.Drawing.Color.White
        Me.summaryBtn.Location = New System.Drawing.Point(613, 73)
        Me.summaryBtn.Name = "summaryBtn"
        Me.summaryBtn.Size = New System.Drawing.Size(253, 132)
        Me.summaryBtn.TabIndex = 12
        Me.summaryBtn.Text = "Summary" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Summary Reports"
        Me.summaryBtn.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.summaryBtn.UseVisualStyleBackColor = False
        '
        'individualBtn
        '
        Me.individualBtn.BackColor = System.Drawing.Color.Maroon
        Me.individualBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.individualBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.individualBtn.ForeColor = System.Drawing.Color.White
        Me.individualBtn.Location = New System.Drawing.Point(184, 73)
        Me.individualBtn.Name = "individualBtn"
        Me.individualBtn.Size = New System.Drawing.Size(253, 132)
        Me.individualBtn.TabIndex = 10
        Me.individualBtn.Text = "Individual" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Invidual Customer Transaction Report"
        Me.individualBtn.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.individualBtn.UseVisualStyleBackColor = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.RUSI_Sales_Management_System.My.Resources.Resources.summary
        Me.PictureBox6.Location = New System.Drawing.Point(473, 73)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(134, 132)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 13
        Me.PictureBox6.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RUSI_Sales_Management_System.My.Resources.Resources.individual
        Me.PictureBox1.Location = New System.Drawing.Point(44, 73)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(134, 132)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(33, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(279, 28)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "TRANSACTION REPORTS FORM"
        '
        'TransactionSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(927, 272)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.summaryBtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.individualBtn)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TransactionSelection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaction Selection Form"
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents summaryBtn As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents individualBtn As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
