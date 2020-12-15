<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Breakdown = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.comments = New System.Windows.Forms.TextBox()
        Me.deposit = New System.Windows.Forms.TextBox()
        Me.time = New System.Windows.Forms.TextBox()
        Me.resultbox = New System.Windows.Forms.TextBox()
        Me.cusname = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(270, 268)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 34)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Breakdown
        '
        Me.Breakdown.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Breakdown.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Breakdown.Location = New System.Drawing.Point(115, 270)
        Me.Breakdown.Name = "Breakdown"
        Me.Breakdown.Size = New System.Drawing.Size(130, 30)
        Me.Breakdown.TabIndex = 24
        Me.Breakdown.Text = "Show breakdown"
        Me.Breakdown.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(77, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Comments:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(89, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Deposit:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Savings Term:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 223)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Total Savings:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Customer Name:"
        '
        'comments
        '
        Me.comments.Location = New System.Drawing.Point(171, 133)
        Me.comments.Multiline = True
        Me.comments.Name = "comments"
        Me.comments.Size = New System.Drawing.Size(186, 63)
        Me.comments.TabIndex = 18
        '
        'deposit
        '
        Me.deposit.Location = New System.Drawing.Point(171, 97)
        Me.deposit.Name = "deposit"
        Me.deposit.Size = New System.Drawing.Size(206, 20)
        Me.deposit.TabIndex = 17
        '
        'time
        '
        Me.time.Location = New System.Drawing.Point(171, 71)
        Me.time.Name = "time"
        Me.time.Size = New System.Drawing.Size(207, 20)
        Me.time.TabIndex = 16
        '
        'resultbox
        '
        Me.resultbox.Location = New System.Drawing.Point(170, 220)
        Me.resultbox.Name = "resultbox"
        Me.resultbox.Size = New System.Drawing.Size(207, 20)
        Me.resultbox.TabIndex = 15
        '
        'cusname
        '
        Me.cusname.Location = New System.Drawing.Point(170, 45)
        Me.cusname.Name = "cusname"
        Me.cusname.Size = New System.Drawing.Size(207, 20)
        Me.cusname.TabIndex = 14
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(529, 397)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Breakdown)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.comments)
        Me.Controls.Add(Me.deposit)
        Me.Controls.Add(Me.time)
        Me.Controls.Add(Me.resultbox)
        Me.Controls.Add(Me.cusname)
        Me.Name = "Form4"
        Me.Text = "Savings Outlook"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Breakdown As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents comments As TextBox
    Friend WithEvents deposit As TextBox
    Friend WithEvents time As TextBox
    Friend WithEvents resultbox As TextBox
    Friend WithEvents cusname As TextBox
End Class
