Option Strict On

Public Class Form1

    Private Sub btnPopulation_Click(sender As System.Object, e As System.EventArgs) Handles btnPopulation.Click

        Dim curPop As Double = 7000
        Dim curYear As Integer = 2012

        Do While curPop > 6
            curPop /= 2
            curYear -= 50
        Loop

        MessageBox.Show("The year would be " & curYear, "" & curYear)

    End Sub
End Class
