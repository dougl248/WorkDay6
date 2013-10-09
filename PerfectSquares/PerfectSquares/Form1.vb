Public Class Form1

    Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click

        lstResult.Items.Clear()

        Dim i As Integer = 0

        Do
            i += 1
            lstResult.Items.Add(CStr(i ^ 2))

        Loop Until i = 10

    End Sub
End Class
