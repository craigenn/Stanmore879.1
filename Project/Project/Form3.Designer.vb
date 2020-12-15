<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AccComments = New System.Windows.Forms.TextBox()
        Me.Savebutton = New System.Windows.Forms.Button()
        Me.interestbox = New System.Windows.Forms.TextBox()
        Me.Accname = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Bright", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(55, 141)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 14)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Comments on Account:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Bright", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(64, 92)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 14)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Account Interest Rate:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(73, 54)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 14)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "New Account Name:"
        '
        'AccComments
        '
        Me.AccComments.Font = New System.Drawing.Font("Lucida Bright", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccComments.Location = New System.Drawing.Point(210, 138)
        Me.AccComments.Margin = New System.Windows.Forms.Padding(2)
        Me.AccComments.Multiline = True
        Me.AccComments.Name = "AccComments"
        Me.AccComments.Size = New System.Drawing.Size(118, 68)
        Me.AccComments.TabIndex = 17
        '
        'Savebutton
        '
        Me.Savebutton.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Savebutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Savebutton.Font = New System.Drawing.Font("Lucida Bright", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Savebutton.Location = New System.Drawing.Point(210, 266)
        Me.Savebutton.Margin = New System.Windows.Forms.Padding(2)
        Me.Savebutton.Name = "Savebutton"
        Me.Savebutton.Size = New System.Drawing.Size(94, 25)
        Me.Savebutton.TabIndex = 16
        Me.Savebutton.Text = "Save Account"
        Me.Savebutton.UseVisualStyleBackColor = False
        '
        'interestbox
        '
        Me.interestbox.Font = New System.Drawing.Font("Lucida Bright", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.interestbox.Location = New System.Drawing.Point(210, 89)
        Me.interestbox.Margin = New System.Windows.Forms.Padding(2)
        Me.interestbox.Name = "interestbox"
        Me.interestbox.Size = New System.Drawing.Size(118, 20)
        Me.interestbox.TabIndex = 15
        '
        'Accname
        '
        Me.Accname.Font = New System.Drawing.Font("Lucida Bright", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Accname.Location = New System.Drawing.Point(210, 51)
        Me.Accname.Margin = New System.Windows.Forms.Padding(2)
        Me.Accname.Name = "Accname"
        Me.Accname.Size = New System.Drawing.Size(118, 20)
        Me.Accname.TabIndex = 14
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(479, 382)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AccComments)
        Me.Controls.Add(Me.Savebutton)
        Me.Controls.Add(Me.interestbox)
        Me.Controls.Add(Me.Accname)
        Me.Name = "Form3"
        Me.Text = "New Accounts"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents AccComments As TextBox
    Friend WithEvents Savebutton As Button
    Friend WithEvents interestbox As TextBox
    Friend WithEvents Accname As TextBox
End Class
