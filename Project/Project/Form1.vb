Imports System.Data.OleDb
Public Class Form1
    '***************************************************************************************************************************
    '***Author: Craig Saville
    '***Compound interest calculator, will calculate compound interest with initial deposit between £1 and £250,000 with an 
    '***interest rate between 0.01 And 90% with decimals and a duration of between 1 and 36 months. 
    '***begin by dimming variables publicly as multiple subs refer to each varible
    '***the calculation uses the formula F = D * [ (1 + I)M - 1] / I 
    '*** where F is the final amount D is your monthly deposit I is the monthly interest rate and M is the number of months
    '***************************************************************************************************************************



    ' Public dims to save having to put one in every sub as multiple subs refer to each variable
    'I choose to use single where I have as they are decimal numbers but not large enough to warrent using a double
    Dim result As Single
    Dim time As Integer
    Dim interest As Single
    Dim deposit As Single
    Dim i As Integer
    Dim interestyear As Single
    Dim current As Single
    Dim FILE_NAME As String = CurDir() & "\calchelp2.pdf"
    Dim month() As String = {"", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"}
    'the first variable in the array is left blank as it is array number 0 and all my calculations begin from 1
    Dim provider As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & CurDir() & "\Accounttypes.mdb"
    Dim myconnection As OleDbConnection = New OleDbConnection
    Dim dr As OleDbDataReader
    Dim dr2 As OleDbDataReader



    'This is the breakdown sub that is called once the breakdown button is clicked and the ammounts input passes validation


    ' This is the sub that calls the validate and calculate subs once the calculate button is clicked 
    Private Sub Calc_Click(sender As Object, e As EventArgs) Handles Calc.Click

        Call validate()

        'once the input has passed validation the validate sub will call the calcuate sub so it doesn't need to be in this sub

    End Sub

    Private Sub NewAcc_Click(sender As Object, e As EventArgs) Handles NewAcc.Click

        Form3.Show()
    End Sub

    Private Sub quit_Click(sender As Object, e As EventArgs) Handles quit.Click
        'This sub just closes the form for ease of use.
        Me.Close()
    End Sub

    Private Sub calculate()


        'this is the calculate sub that does all the calculations when called using the formula explained at the beginning but with the users variables put in correct places 

        deposit = Val(deposittxt.Text)
        time = Val(timetxt.Text)
        interest = interestyear / (100 * 12)


        result = deposit * ((1 + interest) ^ time - 1) / interest
        'F = D * [ (1 + I)M - 1] / I becomes
        'result = deposit * ((1 + interest) ^ time - 1) / interest once our variables are places into the formula
        Form4.resultbox.Text = FormatCurrency(result)
        '^ formatcurrency will make the output be in £ as this is a compound interest calculator for money
        Form4.time.Text = timetxt.Text
        Form4.deposit.Text = FormatCurrency(deposit)
        Form4.cusname.Text = Customername.Text

        Dim reader As OleDbDataReader
        Dim sqlQuery2 As String = "select * from Accounts where [Account] ='" & Accountbox.Text & "'"
        Dim cmd As New OleDbCommand(sqlQuery2, myconnection)
        reader = cmd.ExecuteReader 'this part of the program reads the account details from the database and loads them into the textbox on form4
        While reader.Read
            Form4.comments.Text = reader("Account") & " Account with " & reader("Interest") & "% Interest" & " - " & reader("Comments")
        End While
        Form4.Show()

    End Sub

    'This is the breakdown sub that is called once the breakdown button is clicked and the ammounts input passes validation
    Public Sub breakdwn()
        ' this does the actual working out and adding to the listview box


        deposit = Val(deposittxt.Text)
        time = Val(timetxt.Text)
        interest = interestyear / (100 * 12)
        Form2.breakbox.Items.Clear()
        Form2.breakbox.View = View.Details
        Form2.breakbox.Visible = True

        For i = 1 To time
            current = (deposit * ((1 + interest) ^ i - 1) / interest)
            'this is the formula that was explained at the beginnin but with each valiarble put into the correct place
            'F = D * [ (1 + I)M - 1] / I becomes
            'current = (deposit * ((1 + interest) ^ i - 1) / interest)

            Form2.breakbox.Items.Add(i)

            Form2.breakbox.Items(i - 1).SubItems.Add(FormatCurrency(current))
            '  this will Stop the form breaking once the number Of months goes over 12 as there are only 12 months in the array it will begin counting from 1 again
            If i < 13 Then
                Form2.breakbox.Items(i - 1).SubItems.Add(month(i))
            ElseIf i > 12 And i < 25 Then
                Form2.breakbox.Items(i - 1).SubItems.Add(month(i - 12))
            ElseIf i > 24 Then
                Form2.breakbox.Items(i - 1).SubItems.Add(month(i - 24))
            End If
        Next



    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        'This sub is activated once the reset button is clicked and will just clear all boxes on form1(main form) and clear and close form2(the breakdown form)
        deposittxt.Clear()
        timetxt.Clear()
        Agebox.Clear()
        Accountbox.ResetText()
        Customername.ResetText()

        Form2.breakbox.Items.Clear()
        Form2.Close()

    End Sub
    Private Sub validate()

        ' this sub checks if the user input is numbers, if it is all numbers then the do until will then ensure that the numbers used are within the specified ranges 
        'if not it Then will pop up a message box asking the user To use numbers
        If IsNumeric(deposittxt.Text) And IsNumeric(timetxt.Text) Then

            deposit = Val(deposittxt.Text)
            time = Val(timetxt.Text)
            ' Call validaterange()
            Do Until deposit < 250001 And deposit >= 1
                'this do until checks the deposit

                deposittxt.Text = InputBox("Deposit must be between 1 and 250,000", "Deposit error", "")

                Call validate()
            Loop


            Do Until time <= 36 And time >= 1
                    'this do until checks the time
                    timetxt.Text = InputBox("Number of months must be between 1 and 36", "Length of time error", "")

                    Call validate()
                Loop
                Call calculate()
            Else MsgBox("Please use numbers only.")
        End If





    End Sub

    Private Sub validaterange()
        Do Until deposit < 250001 And deposit >= 1
            'this do until checks the deposit

            deposittxt.Text = InputBox("Deposit must be between 1 and 250,000", "Deposit error", "")

            Call validate()
        Loop
        Do Until time <= 36 And time >= 1
            'this do until checks the time
            timetxt.Text = InputBox("Number of months must be between 1 and 36", "Length of time error", "")

            Call validate()
        Loop
        'Once all variables are within the specified ranges if somehow the user gets passed the initial validation and into this if statment
        'it will ensure that the value is within range and call the calculate sub I put the call to calculate sub in this sub instead of in the calculate button sub
        'as if the user presses the breakdown button first then it will still calculate the input and put it in the total box for user ease of use.
        If deposit < 250001 And deposit > 0 And time < 37 And time > 0 Then
            Call calculate()
        Else Call validate()

        End If
    End Sub



    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        'This sub is for the help file, this is the hyperlink on the form that allows the user to click the help link rather then pressing F1
        'the file name is dimmed at the top of the code although as this is the only one that uses this variable it could also be placed purely in this sub
        'I chose to put it at the top however as the rest of my variables are up there. If the help page is not available then it will display a message box saying that the file does not exist
        If System.IO.File.Exists(FILE_NAME) = True Then
            Process.Start(FILE_NAME)
        Else
            MsgBox("File Does Not Exist")
        End If

    End Sub






    Private Sub Accountbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Accountbox.SelectedIndexChanged

        Dim reader As OleDbDataReader

        Dim sqlQuery2 As String = "select * from Accounts where Account ='" & Accountbox.Text & "'"
        Dim cmd As New OleDbCommand(sqlQuery2, myconnection)
        reader = cmd.ExecuteReader
        While reader.Read
            interestyear = reader("Interest") 'reads from interest column on database and loads into variable
        End While

    End Sub










    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load




        myconnection.ConnectionString = provider
        myconnection.Open()
        Dim sqlQuery As String = "SELECT * FROM Accounts"
        Dim sqlquery3 As String = "select * from Customers"
        Dim cmddd As New OleDbCommand(sqlQuery, myconnection)
        Dim cmd As New OleDbCommand(sqlquery3, myconnection)
        'loads the combobox items for the customer names and account types
        dr = cmddd.ExecuteReader()
        While dr.Read
            Accountbox.Items.Add(dr.GetString(1))
        End While
        dr.Close()
        dr2 = cmd.ExecuteReader
        While dr2.Read
            Customername.Items.Add(dr2.GetString(1))
        End While
        Form6.Close()
    End Sub



    Private Sub Customername_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Customername.SelectedIndexChanged

        Dim reader As OleDbDataReader

        Dim sqlQuery2 As String = "select * from Customers where [CustomerName] ='" & Customername.Text & "'"
        Dim cmd As New OleDbCommand(sqlQuery2, myconnection)
        reader = cmd.ExecuteReader
        While reader.Read
            Agebox.Text = reader("Age") 'reads the customer name in customername textbox and matches the age from the database
        End While

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles newcus.Click
        Form5.Show()
    End Sub
End Class