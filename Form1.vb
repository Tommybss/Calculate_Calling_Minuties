Option Strict On

Public Class Form1



    Private Sub btnMakeChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMakeChange.Click
        'Declare variable to hold Input Amount
        Dim intInputAmount As Integer

        'Declare variables for Dollars, Quarters, Dimes, Nickels, Pennies
        Dim intDollars, intQuarters, intDimes, intNickels, intPenniesLeft As Integer

        'Convert User input to pennies and assign to intInputAmount
        intInputAmount = CInt(CDbl(txtDollarAmt.Text) * 100)

        'Now compute how many dollars, quarters, etc......
        intDollars = intInputAmount \ 100
        intPenniesLeft = intInputAmount Mod 100

        intQuarters = intPenniesLeft \ 25
        intPenniesLeft = intPenniesLeft Mod 25

        intDimes = intPenniesLeft \ 10
        intPenniesLeft = intPenniesLeft Mod 10

        intNickels = intPenniesLeft \ 5
        intPenniesLeft = intPenniesLeft Mod 5


        'Display the results in the labels
        lblDollars.Text = CStr(intDollars)
        lblQuarters.Text = CStr(intQuarters)
        lblDimes.Text = CStr(intDimes)
        lblNickels.Text = CStr(intNickels)
        lblDimes.Text = CStr(intDimes)
        lblPennies.Text = CStr(intPenniesLeft)


    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        txtDollarAmt.Text = ""
        lblDollars.Text = ""
        lblQuarters.Text = ""
        lblDimes.Text = ""
        lblNickels.Text = ""
        lblPennies.Text = ""
        txtDollarAmt.Focus()


    End Sub
End Class
