<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Calc = New System.Windows.Forms.Button()
        Me.Reset = New System.Windows.Forms.Button()
        Me.quit = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.hlpbutton = New System.Windows.Forms.HelpProvider()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Customername = New System.Windows.Forms.ComboBox()
        Me.Agebox = New System.Windows.Forms.TextBox()
        Me.Accountbox = New System.Windows.Forms.ComboBox()
        Me.deposittxt = New System.Windows.Forms.TextBox()
        Me.timetxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NewAcc = New System.Windows.Forms.Button()
        Me.newcus = New System.Windows.Forms.Button()
        Me.customerhelp = New System.Windows.Forms.ToolTip(Me.components)
        Me.Accounthelp = New System.Windows.Forms.ToolTip(Me.components)
        Me.deposithelp = New System.Windows.Forms.ToolTip(Me.components)
        Me.savingshelp = New System.Windows.Forms.ToolTip(Me.components)
        Me.calcbutton = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'Calc
        '
        Me.Calc.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Calc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Calc.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Calc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Calc.Location = New System.Drawing.Point(56, 222)
        Me.Calc.Name = "Calc"
        Me.Calc.Size = New System.Drawing.Size(115, 31)
        Me.Calc.TabIndex = 8
        Me.Calc.Text = "Calculate savings"
        Me.calcbutton.SetToolTip(Me.Calc, "Press to see summary")
        Me.Calc.UseVisualStyleBackColor = False
        '
        'Reset
        '
        Me.Reset.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Reset.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reset.Location = New System.Drawing.Point(218, 222)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(92, 31)
        Me.Reset.TabIndex = 9
        Me.Reset.Text = "Reset"
        Me.Reset.UseVisualStyleBackColor = False
        '
        'quit
        '
        Me.quit.BackColor = System.Drawing.SystemColors.ControlLight
        Me.quit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.quit.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quit.Location = New System.Drawing.Point(218, 273)
        Me.quit.Name = "quit"
        Me.quit.Size = New System.Drawing.Size(92, 29)
        Me.quit.TabIndex = 12
        Me.quit.Text = "Quit"
        Me.quit.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(284, 326)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(143, 14)
        Me.LinkLabel1.TabIndex = 14
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Press F1 or click for help."
        '
        'hlpbutton
        '
        Me.hlpbutton.HelpNamespace = "calchelp2.pdf"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 14)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Customer Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(90, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 14)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Age:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 14)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Account Types:"
        '
        'Customername
        '
        Me.Customername.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Customername.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Customername.FormattingEnabled = True
        Me.Customername.Location = New System.Drawing.Point(150, 33)
        Me.Customername.Name = "Customername"
        Me.Customername.Size = New System.Drawing.Size(104, 22)
        Me.Customername.TabIndex = 18
        Me.customerhelp.SetToolTip(Me.Customername, "Please select customer from dropdown menu")
        '
        'Agebox
        '
        Me.Agebox.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agebox.Location = New System.Drawing.Point(150, 64)
        Me.Agebox.Name = "Agebox"
        Me.Agebox.Size = New System.Drawing.Size(83, 20)
        Me.Agebox.TabIndex = 19
        '
        'Accountbox
        '
        Me.Accountbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Accountbox.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Accountbox.FormattingEnabled = True
        Me.Accountbox.Location = New System.Drawing.Point(150, 91)
        Me.Accountbox.Name = "Accountbox"
        Me.Accountbox.Size = New System.Drawing.Size(107, 22)
        Me.Accountbox.TabIndex = 20
        Me.Accounthelp.SetToolTip(Me.Accountbox, "Please select account from dropdown menu")
        '
        'deposittxt
        '
        Me.deposittxt.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deposittxt.Location = New System.Drawing.Point(150, 118)
        Me.deposittxt.Name = "deposittxt"
        Me.deposittxt.Size = New System.Drawing.Size(104, 20)
        Me.deposittxt.TabIndex = 21
        Me.deposithelp.SetToolTip(Me.deposittxt, "Monthly deposit in numbers between 1 and 250000")
        '
        'timetxt
        '
        Me.timetxt.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timetxt.Location = New System.Drawing.Point(150, 144)
        Me.timetxt.Name = "timetxt"
        Me.timetxt.Size = New System.Drawing.Size(104, 20)
        Me.timetxt.TabIndex = 22
        Me.savingshelp.SetToolTip(Me.timetxt, "How long you are saving for ")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(46, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 14)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Initial Deposit:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(48, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 14)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Savings term:"
        '
        'NewAcc
        '
        Me.NewAcc.BackColor = System.Drawing.SystemColors.ControlLight
        Me.NewAcc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewAcc.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewAcc.Location = New System.Drawing.Point(56, 269)
        Me.NewAcc.Name = "NewAcc"
        Me.NewAcc.Size = New System.Drawing.Size(115, 33)
        Me.NewAcc.TabIndex = 25
        Me.NewAcc.Text = "New Account Type"
        Me.ToolTip1.SetToolTip(Me.NewAcc, "Click to add a new account")
        Me.NewAcc.UseVisualStyleBackColor = False
        '
        'newcus
        '
        Me.newcus.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newcus.Location = New System.Drawing.Point(56, 308)
        Me.newcus.Name = "newcus"
        Me.newcus.Size = New System.Drawing.Size(115, 34)
        Me.newcus.TabIndex = 26
        Me.newcus.Text = "New Customer"
        Me.newcus.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(451, 380)
        Me.Controls.Add(Me.newcus)
        Me.Controls.Add(Me.NewAcc)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.timetxt)
        Me.Controls.Add(Me.deposittxt)
        Me.Controls.Add(Me.Accountbox)
        Me.Controls.Add(Me.Agebox)
        Me.Controls.Add(Me.Customername)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.quit)
        Me.Controls.Add(Me.Reset)
        Me.Controls.Add(Me.Calc)
        Me.hlpbutton.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TableOfContents)
        Me.Name = "Form1"
        Me.hlpbutton.SetShowHelp(Me, True)
        Me.Text = "Compound Interest Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Calc As Button
    Friend WithEvents Reset As Button
    Friend WithEvents quit As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents hlpbutton As HelpProvider
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Customername As ComboBox
    Friend WithEvents Agebox As TextBox
    Friend WithEvents Accountbox As ComboBox
    Friend WithEvents deposittxt As TextBox
    Friend WithEvents timetxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents NewAcc As Button
    Friend WithEvents newcus As Button
    Friend WithEvents customerhelp As ToolTip
    Friend WithEvents Accounthelp As ToolTip
    Friend WithEvents deposithelp As ToolTip
    Friend WithEvents savingshelp As ToolTip
    Friend WithEvents calcbutton As ToolTip
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolTip2 As ToolTip
End Class
