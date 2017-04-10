Public Class Form1

    Private Sub DiceRoll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDiceRoll.Click
       
        'Declare use of a ramdom number generator object
        Dim Rangen As New Random


        'Declare variables for the dice and total
        Dim intDie1, intDie2, intTotal As Integer

        'Roll the Dice and Display the total
        intDie1 = Rangen.Next(1, 7)
        intDie2 = Rangen.Next(1, 7)
        lblDie1.Text = intDie1.ToString
        lblDie2.Text = intDie2.ToString
        intTotal = intDie1 + intDie2
        lblTotal.Text = intTotal.ToString
        'Now count how many of each we have

        'We need to count how many times each outcome occurs
        'Note the use of CStr.  We could have used ToString instead.
        Select Case intTotal
            Case 2
                L2.Text = CStr(CInt(L2.Text) + 1)
            Case 3
                L3.Text = CStr(CInt(L3.Text) + 1)
            Case 4
                L4.Text = CStr(CInt(L4.Text) + 1)
            Case 5
                L5.Text = CStr(CInt(L5.Text) + 1)
            Case 6
                L6.Text = CStr(CInt(L6.Text) + 1)
            Case 7
                L7.Text = CStr(CInt(L7.Text) + 1)
            Case 8
                L8.Text = CStr(CInt(L8.Text) + 1)
            Case 9
                L9.Text = CStr(CInt(L9.Text) + 1)
            Case 10
                L10.Text = CStr(CInt(L10.Text) + 1)
            Case 11
                L11.Text = CStr(CInt(L11.Text) + 1)
            Case 12
                L12.Text = CStr(CInt(L12.Text) + 1)


        End Select
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    'Here is the code for the String Search
    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        ' Variable declarations
        Dim intStartIndex As Integer ' Starting index of the search
        Dim intFoundIndex As Integer ' Index of the found substring

        ' Determine whether a search string and a valid starting index were given.
        If txtToFind.Text.Length > 0 Then

            ' Get the starting index for the search.


            ' Search for the substring.


            ' Indicate whether the search string was found.
            If intFoundIndex = -1 Then
                'The search string was not found

            Else
                'The search string was found at index position _____

            End If

        Else
            ' Display an error message for bad search string or non-numeric index.
            MessageBox.Show("Please enter a Search String. The index must be numeric and non-negative.")
        End If
    End Sub

    Private Sub lblDie1_Click(sender As System.Object, e As System.EventArgs) Handles lblDie1.Click

    End Sub
End Class
