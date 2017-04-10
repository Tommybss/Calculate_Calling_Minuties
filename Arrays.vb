Public Class Form1
    Const intMAX_SUBSCRIPT As Integer = 9

    ' Declare a Class-level Integer Array to hold 10 values.
    Dim intValues(intMAX_SUBSCRIPT) As Integer

    Private Sub btnGenerateValues_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerateValues.Click

        ' Generate the random values and display them in the lstInputValues listbox.
        Dim rangen As New Random
        Dim intCounter As Integer

        'Clear any values showing in the list box
        btnClear.PerformClick()

        For intCounter = 0 To intMAX_SUBSCRIPT
            'Get a randon value and put it into the array intValues
            intValues(intCounter) = rangen.Next(100)

            'Now display this value by adding it to lstInputValues list box
            lstInputValues.Items.Add(intValues(intCounter))

        Next intCounter

        'Enable the buttons
        btnSearch.Enabled = True
        btnAverage.Enabled = True
        btnMax.Enabled = True
        btnMin.Enabled = True
        btnSort.Enabled = True

        'Enable the Menu Items for Search, Average, Max, Min, Sort
        mnuOrderAverage.Enabled = True
        mnuOrderMin.Enabled = True
        mnuOrderMax.Enabled = True
        mnuOrderSort.Enabled = True
        mnuValuesSearch.Enabled = True
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Clear the Items in the list box.
        lstInputValues.Items.Clear()

        ' Set the Text in the labels to an empty string.
        lblLargest.Text = String.Empty
        lblSmallest.Text = String.Empty
        lblAverage.Text = String.Empty

        'Disable the buttons
        btnSearch.Enabled = False
        btnAverage.Enabled = False
        btnMax.Enabled = False
        btnMin.Enabled = False
        btnSort.Enabled = False

        'disable the menues
        mnuOrderAverage.Enabled = False
        mnuOrderMin.Enabled = False
        mnuOrderMax.Enabled = False
        mnuOrderSort.Enabled = False
        mnuValuesSearch.Enabled = False

        'Disable the Average, Search, Max, Min and Sort menu items
        mnuValuesSearch.Enabled = False


        ' Give the focus to the btnGenerateValues button
        btnGenerateValues.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Ask the user to confirm the Exit
        Me.Close()

        
    End Sub

    Private Sub btnMax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMax.Click
        Dim intCount As Integer     ' Loop counter
        Dim intLargest As Integer   ' To hold the largest value

        ' Get the first value in the array.
        intLargest = intValues(0)

        ' Search for the largest value.
        For intCount = 1 To (intValues.Count - 1)
            If intValues(intCount) > intLargest Then
                intLargest = intValues(intCount)
            End If
        Next

        ' Display the largest value.
        lblLargest.Text = intLargest.ToString

    End Sub

    Private Sub btnMinOrder(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMin.Click
        Dim intCount As Integer     ' Loop counter
        Dim intSmallest As Integer  ' To hold the smallest value

        ' Get the first value in the array.
        intSmallest = intValues(0)

        ' Search for the smallest value.

        For intCount = 1 To (intValues.Count - 1)
            If intValues(intCount) < intSmallest Then
                intSmallest = intValues(intCount)
            End If
        Next

        'Display the smallest value.
        lblSmallest.Text = intSmallest.ToString
    End Sub


    Private Sub btnAverage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAverage.Click
        Dim intTotal, intCount As Integer
        Dim dblAverage As Double

        For intCount = 0 To (intMAX_SUBSCRIPT)
            intTotal = intTotal + intValues(intCount)
        Next intCount

        dblAverage = intTotal / intMAX_SUBSCRIPT
        lblAverage.Text = dblAverage.ToString("f2")
    End Sub

    Private Sub btnSort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSort.Click
        Dim intTemp, intIndex As Integer  'Relying on fact the VB will initialize these to 0

        'first clear the list box
        lstInputValues.Items.Clear()

        'This sorting technique is called a Bubble Sort 
        For intCounter = intIndex To intMAX_SUBSCRIPT
            For intIndex = 0 To intMAX_SUBSCRIPT - 1
                If intValues(intIndex) > intValues(intIndex + 1) Then
                    intTemp = intValues(intIndex + 1)
                    intValues(intIndex + 1) = intValues(intIndex)
                    intValues(intIndex) = intTemp
                End If
            Next
        Next

        'Now sort the array using another method
        Array.Sort(intValues)

        'Display the results
        For intCounter = 0 To intMAX_SUBSCRIPT
            lstInputValues.Items.Add(intValues(intCounter))
        Next intCounter
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim intCount, intSearchValue, intFoundPosition As Integer
        Dim blnFound As Boolean = False
        Try
            intSearchValue = CInt(InputBox("Enter a value to search for", "Value to Search"))
            Do While (intCount <= intMAX_SUBSCRIPT) And blnFound = False
                If intValues(intCount) = intSearchValue Then
                    blnFound = True
                    intFoundPosition = intCount
                End If
                intCount += 1
            Loop

            If blnFound Then
                MessageBox.Show("The value " & CStr(intSearchValue) & " was found at index " & CStr(intFoundPosition) & " in the Array")
            Else
                MessageBox.Show("Sorry, value not found")
            End If
        Catch
            MessageBox.Show("You must enter a positive integer")
        End Try
    End Sub

    '============== The code for the menu items, primarily using the Perform command =======================

    Private Sub mnuValuesGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuValuesGenerate.Click
        btnGenerateValues.PerformClick()
    End Sub

    Private Sub mnuValuesSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuValuesSearch.Click

    End Sub

    Private Sub mnuOrderMax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOrderMax.Click

    End Sub

    Private Sub mnuOrderMin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOrderMin.Click

    End Sub

    Private Sub mnuOrderSort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOrderSort.Click

    End Sub

    Private Sub mnuOrderAverage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOrderAverage.Click

    End Sub

    Private Sub mnuValuesClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuValuesClear.Click

    End Sub

    Private Sub mnuAboutArrayDemo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAboutArrayDemo.Click
        MessageBox.Show("Array Demo Version 1.0")
    End Sub

    Private Sub mnuFileExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileExit.Click

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
