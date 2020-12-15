<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.breakbox = New System.Windows.Forms.ListView()
        Me.MonthNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Amount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MonthN = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.hlpbutton = New System.Windows.Forms.HelpProvider()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'breakbox
        '
        Me.breakbox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.breakbox.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.MonthNo, Me.Amount, Me.MonthN})
        Me.breakbox.Location = New System.Drawing.Point(12, 39)
        Me.breakbox.Name = "breakbox"
        Me.breakbox.Size = New System.Drawing.Size(342, 373)
        Me.breakbox.TabIndex = 0
        Me.breakbox.UseCompatibleStateImageBehavior = False
        '
        'MonthNo
        '
        Me.MonthNo.Text = "Month number"
        Me.MonthNo.Width = 90
        '
        'Amount
        '
        Me.Amount.Text = "Amount"
        Me.Amount.Width = 120
        '
        'MonthN
        '
        Me.MonthN.Text = "Month Name"
        Me.MonthN.Width = 80
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Your monthly breakdown:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(379, 389)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 22)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Return."
        Me.Button1.UseVisualStyleBackColor = False
        '
        'hlpbutton
        '
        Me.hlpbutton.HelpNamespace = "calchelp2.pdf"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(404, 446)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(71, 13)
        Me.LinkLabel1.TabIndex = 15
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Click for help."
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(496, 468)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.breakbox)
        Me.Name = "Form2"
        Me.Text = "Monthly Breakdown"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents breakbox As ListView
    Friend WithEvents MonthNo As ColumnHeader
    Friend WithEvents Amount As ColumnHeader
    Friend WithEvents MonthN As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents hlpbutton As HelpProvider
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
