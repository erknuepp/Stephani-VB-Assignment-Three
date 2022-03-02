Public Class Form1

    Dim coffeSubtotal As Decimal
    Dim donutSubtotal As Decimal
    Dim subtotal As Decimal

    Private Sub ClearSale()
        TextboxSubtotal.Clear()
        SaleTaxBox.Clear()
        TotalDueBox.Clear()
    End Sub

    Private Sub DetermineSubtotal()
        subtotal = coffeSubtotal + donutSubtotal
    End Sub

    Private Function DetermineSalesTax(subtotal As Decimal)
        Return subtotal * 0.06
    End Function

    Private Sub DonutBox_CheckedChanged(sender As RadioButton, e As EventArgs) Handles GlazedRadioButton.CheckedChanged, SugarRadioButton.CheckedChanged, ChocolateRadioButton.CheckedChanged, FilledRadioButton.CheckedChanged
        ClearSale()

        If sender.Equals(GlazedRadioButton) Then
            donutSubtotal = 1.05
        ElseIf sender.Equals(SugarRadioButton) Then
            donutSubtotal = 1.05
        ElseIf sender.Equals(ChocolateRadioButton) Then
            donutSubtotal = 1.25
        ElseIf sender.Equals(FilledRadioButton) Then
            donutSubtotal = 1.5
        End If

    End Sub

    Private Sub CoffeeBox_CheckedChanged(sender As RadioButton, e As EventArgs) Handles NoneRadioButton.CheckedChanged, RegularRadioButton.CheckedChanged, CappuccinoRadioButton.CheckedChanged
        ClearSale()

        If sender.Equals(NoneRadioButton) Then
            coffeSubtotal = 0
        ElseIf sender.Equals(RegularRadioButton) Then
            coffeSubtotal = 1.5
        ElseIf sender.Equals(CappuccinoRadioButton) Then
            coffeSubtotal = 2.75
        End If
    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        DetermineSubtotal()
        TextboxSubtotal.Text = subtotal.ToString("N2")
        Dim salesTax As Decimal
        salesTax = DetermineSalesTax(subtotal)
        SaleTaxBox.Text = salesTax.ToString("N2")
        TotalDueBox.Text = (subtotal + salesTax).ToString("N2")
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Application.Exit()
    End Sub
End Class
