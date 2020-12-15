Imports System.Data.OleDb
Public Class Form6

    Dim provider As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & CurDir() & "\Accounttypes.mdb"
    Dim myconnection As OleDbConnection = New OleDbConnection

    Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click

        Dim command As New OleDbCommand("Select * FROM users where [user] = @username AND [pass] = @password", myconnection)
        'selects the user and password in the textbox and finds them in the database
        command.Parameters.Add("@username", OleDbType.VarChar).Value = Textuser.Text
        command.Parameters.AddWithValue("@password", OleDbType.VarChar).Value = Textpass.Text

        Dim adapter As New OleDbDataAdapter(command)
        Dim table As New DataTable

        adapter.Fill(table)
        ' if the database has matching user and pass then the table gets filled then if there is more then 1 row in the table it allows you to log in
        If table.Rows.Count = 0 Then
            MsgBox("Invalid username or password")
        Else

            MsgBox("Login successful")

            Form1.Show()





        End If

    End Sub

    Private Sub newacc_Click(sender As Object, e As EventArgs) Handles newacc.Click
        Form7.Show()
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myconnection.ConnectionString = provider
        myconnection.Open()

    End Sub
End Class