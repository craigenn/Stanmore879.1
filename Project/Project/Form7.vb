Imports System.Data.OleDb
Public Class Form7
    Dim provider As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & CurDir() & "\Accounttypes.mdb"
    Dim myconnection As OleDbConnection = New OleDbConnection
    Dim sqlquery As String = "INSERT into users ([user],[pass]) values (@username, @password)"


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        'inserts new user and pass into the database
        Dim command As New OleDbCommand(sqlquery, myconnection)
        command.Parameters.AddWithValue("@username", TextBox1.Text)
        command.Parameters.AddWithValue("@password", TextBox2.Text)
        command.ExecuteNonQuery()



        MsgBox("Account successfully created.")
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myconnection.ConnectionString = provider
        myconnection.Open()
    End Sub
End Class