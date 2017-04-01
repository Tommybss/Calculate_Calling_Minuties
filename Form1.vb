Public Class Form1

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub txtWidthOfSide_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtWidthOfSide.TextChanged

    End Sub

    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        'Declare needed variables
        Dim dblLength, dblWidth, dblFenceLength, dblCost As Double

        'Accepth User Input
        dblLength = CDbl(txtLengthOfSide.Text)
        dblWidth = CDbl(txtWidthOfSide.Text)

        'Now do the calculations
        dblFenceLength = 2 * dblLength + 2 * dblWidth
        dblCost = (dblLength + dblWidth) * 2 * 20

        'Now display the results
        lblTotalFence.Text = CStr(dblFenceLength)
        lblCostAnswer.Text = dblCost.ToString("c")

    End Sub
End Class
