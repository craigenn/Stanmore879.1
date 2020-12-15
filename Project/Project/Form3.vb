Imports System.Data.OleDb
Public Class Form3

    Dim myconnection As OleDbConnection = New OleDbConnection
    Dim provider As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & CurDir() & "\Accounttypes.mdb"
    Dim dr As OleDbDataReader
    Dim interyear As Single
    Dim interyear2 As String
    Dim acountname As String
    Dim acountcomments As String



    Private Sub validate()

        ' this sub checks if the user input is numbers, if it is all numbers then the do until will then ensure that the numbers used are within the specified ranges 
        'if not it Then will pop up a message box asking the user To use numbers
        If IsNumeric(interestbox.Text) Then
            acountcomments = AccComments.Text
            acountname = Accname.Text
            interyear = Val(interestbox.Text)
            AccComments.Clear()
            Accname.Clear()
            interestbox.Clear()

            Call validaterange()

        Else MsgBox("Interest rate should be numbers only.")
        End If

    End Sub
    Private Sub validate2()
        If IsNumeric(interyear2) Then
            interyear = Val(interyear2)
        Else msgbox("Interest rate should use numbers")
        End If
    End Sub
    Private Sub validaterange()
        Do Until interyear <= 90 And interyear > 0
            'this do until checks the deposit

            interyear2 = InputBox("Interest should be between 0.1 and 90", "Interest rate error", "", 1, 1)

            Call validate2()
        Loop

        'Once all variables are within the specified ranges if somehow the user gets passed the initial validation and into this if statment
        'it will ensure that the value is within range and call the calculate sub I put the call to calculate sub in this sub instead of in the calculate button sub
        'as if the user presses the breakdown button first then it will still calculate the input and put it in the total box for user ease of use.
        If interyear <= 90 And interyear >= 0 Then
            Call submit()


        End If
    End Sub



    Private Sub Savebutton_Click(sender As Object, e As EventArgs) Handles Savebutton.Click

        Call validate()

    End Sub

    Private Sub submit()
        ' Accname.Text = acountname
        ' AccComments.Text = acountcomments
        ' interestbox.Text = interyear

        'inserts into database
        Dim sqlQuery As String = "INSERT INTO Accounts ([Account],[Interest],[Comments]) Values (@Account,@Interest,@Comments)"
        Dim cmd As New OleDbCommand(sqlQuery, myconnection)
        cmd.Parameters.AddWithValue("@Account", acountname)
        cmd.Parameters.AddWithValue("@Interest", interyear)
        cmd.Parameters.AddWithValue("@Comments", acountcomments)
        cmd.ExecuteNonQuery()
        Me.Close()




        MsgBox("Account successfully created.")
        Call reload_combo()
    End Sub
    Private Sub reload_combo()
        Dim sqlQuery6 As String = "SELECT * FROM Accounts"
        Dim cmddd As New OleDbCommand(sqlQuery6, myconnection)
        Form1.Accountbox.Items.Clear()
        dr = cmddd.ExecuteReader()
        While dr.Read
            Form1.Accountbox.Items.Add(dr.GetString(1)) 'reloads the items in the combobox on form1
        End While

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myconnection.ConnectionString = provider
        myconnection.Open()

    End Sub
End Class