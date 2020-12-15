Imports System.Data.OleDb
Public Class Form5




    Dim connstring As String
    Dim myconnection As OleDbConnection = New OleDbConnection
    Dim provider As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & CurDir() & "\Accounttypes.mdb"
    Dim dr As OleDbDataReader

    Private Sub CusSave_Click(sender As Object, e As EventArgs) Handles CusSave.Click
        Call validate()
    End Sub

    Private Sub validate()

        ' this sub checks if the user input is numbers, if it is all numbers then the do until will then ensure that the numbers used are within the specified ranges 
        'if not it Then will pop up a message box asking the user To use numbers
        If IsNumeric(CusAge.Text) Then
            Call cussubmit()

        Else MsgBox("Customers age should be numbers.")
        End If
    End Sub

    Private Sub cussubmit()


        Dim sqlQuery As String = "INSERT INTO Customers (CustomerName,Age,Comments) Values (@CustomerName,@Age,@Comments)"
        Dim cmd As New OleDbCommand(sqlQuery, myconnection)
        cmd.Parameters.AddWithValue("@CustomerName", CusName.Text)
        cmd.Parameters.AddWithValue("@Age", CusAge.Text)
        cmd.Parameters.AddWithValue("@Comments", CusComments.Text)
        cmd.ExecuteNonQuery()
        Me.Close()

        Dim sqlQuery6 As String = "SELECT * FROM Customers"
        Dim cmddd As New OleDbCommand(sqlQuery6, myconnection)

        Form1.Customername.Items.Clear()
        dr = cmddd.ExecuteReader()
        While dr.Read
            Form1.Customername.Items.Add(dr.GetString(1))
        End While
        MsgBox("Customer successfully added.")

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myconnection.ConnectionString = provider
        myconnection.Open()

    End Sub
End Class