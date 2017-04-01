Option Strict On

Public Class Form1

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        ' Declare a named constant for the monthly $10.00 charge.
        Const dblMonthlyCharge As Double = 10.0

        ' Declare a variable to hold the number of checks written.
        Dim intNumChecks As Integer

        ' Declare a variable to hold the check fee.
        Dim dblCheckFees As Double

        ' Declare a variable to hold the total fees.
        Dim dblTotalFees As Double

        Try
            'Get the number of checks written as input from the txtNumChecks text box and put it into intNumChecks.
            intNumChecks = CInt(txtNumChecks.Text)

            'Check that the input is a positive value
            If intNumChecks <= 0 Then
                MessageBox.Show("The input must be a positive value")
            Else  'Compute the fee per check

                If intNumChecks < 20 Then
                    dblCheckFees = 0.1              '10 cents per check
                ElseIf intNumChecks < 40 Then
                    dblCheckFees = 0.08             '8 cents per check
                ElseIf intNumChecks < 60 Then
                    dblCheckFees = 0.06             '6 cents per check
                Else
                    dblCheckFees = 0.04             '4 cents per check

                End If

                'Now compute the total check fees plus the $10 monthly fee
                dblTotalFees = intNumChecks * dblCheckFees + dblMonthlyCharge

                'Display the result
                lblTotalFees.Text = dblTotalFees.ToString("c")
            End If

        Catch  'show error message if user input is incorrect
            MessageBox.Show("Your input must be a positive integer")
            txtNumChecks.Focus()        'Sends focus to Number of Checks

        End Try
        btnClear.Focus()

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Clear the values in txtNumChecks and lblTotalFees
        txtNumChecks.Text = ""
        lblTotalFees.Text = ""

        ' Give the focus to txtNumChecks text box.
        txtNumChecks.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MessageBox.Show("Please enter the number of checks as a postitive integer.")

    End Sub
End Class
