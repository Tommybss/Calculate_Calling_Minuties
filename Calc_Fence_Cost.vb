Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        'Declare needed variables
        Dim dblSide, dblPerimeter, dblCost As Double
        'Accept User Input
        dblSide = CDbl(txtLengthOfSide.Text)
        'Do The Calculations
        dblPerimeter = 4 * dblSide
        dblCost = 20 * dblPerimeter
        'Now display the results
        lblPerimeter.Text = CStr(dblPerimeter)
        lblCost.Text = dblCost.ToString("c")
    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtLengthOfSide.TextChanged

    End Sub

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs) Handles lblCost.Click

    End Sub
End Class
