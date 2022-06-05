Public Class palindrome
    Function isPalindrome(pstring As String) As Boolean
        Dim j As Integer = Len(pstring) - 1 'getting the last index
        Dim i As Integer = 0 'getting the first index
        While i <= j 'while they are not overlapping basically
            If i = j Then 'if they are equal it means they are pointing to the same letter, so reaching it means palindromic
                Return True
            End If
            If Not pstring.Chars(i) = pstring.Chars(j) Then
                Return False 'if they are not equal, it means they are not palidromic
            End If
            i += 1 'going to next char
            j -= 1
        End While
        Return True 'if they overlapped, it means thay traversed whole word with same letters each step.
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
