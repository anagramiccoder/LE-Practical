Public Class Form1
    Function isPalindrome(pstring As String) As Boolean
        Dim j As Integer = Len(pstring) - 1
        Dim i As Integer = 0
        While i <= j
            If i = j Then
                Return True
            End If
            If Not pstring.Chars(i) = pstring.Chars(j) Then
                Return False
            End If
            i += 1
            j -= 1
        End While
        Return True
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim stringtest = TextBox1.Text
        If isPalindrome(stringtest) Then
            Label2.Text = "The string you entered, " + stringtest + ", is a palindrome."
        Else
            Label2.Text = "The string you entered," + stringtest + ", is NOT a palindrome."
        End If
    End Sub
End Class
