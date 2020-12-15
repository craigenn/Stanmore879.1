Public Class Form2
    'all inputs are done from code in the form1 rather then any in form2

    Dim FILE_NAME As String = CurDir() & "\calchelp2.pdf"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'This sub just closes the second form incase the user wishes to reenter and values
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'this sub handles the help file if the user clicks the link in the form
        If System.IO.File.Exists(FILE_NAME) = True Then
            Process.Start(FILE_NAME)
        Else
            MsgBox("File Does Not Exist")
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class