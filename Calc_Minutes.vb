Public Class Form1

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click

        ' Declare a variable to hold the minutes of the call.
        Dim dblMinutes As Double

        ' Declare a variable to hold the selected rate of the call.
        Dim dblRate As Double

        ' Declare a variable to hold the total charge of the call.
        Dim dblTotalCharge As Double

        ' Get the number of minutes of the call as input from the user.
        If Double.TryParse(txtMinutes.Text, dblMinutes) AndAlso dblMinutes > 0 Then


            'Determine which rate was selected by the user.
            If radDaytime.Checked = True Then
                dblRate = 0.07
            ElseIf radEvening.Checked = True Then
                dblRate = 0.12
            ElseIf radOffPeak.Checked = True Then
                dblRate = 0.05
            End If

            ' Calcuate the total charge by multiplying the minutes by the rate.
            dblTotalCharge = dblMinutes * dblRate

            ' Display the result to the user in the lblTotalCharge label.
            lblTotalCharge.Text = dblTotalCharge.ToString("c")
        Else
            ' Display a message box to the user indicating the input entered for the minutes is invalid.
            MessageBox.Show("Minutes - The value must be a positive number.", "Invalid Input")
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Reset the radDaytime radio button as the default value
        radDaytime.Checked = True

        ' Clear the Text in the txtMinutes text box and lblTotalCharge label.
        txtMinutes.Text = ""
        lblTotalCharge.Text = ""

        ' Send the focus to txtMinutes.
        txtMinutes.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub radEvening_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radEvening.CheckedChanged

    End Sub
End Class
