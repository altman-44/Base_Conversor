Module StringsManagement
    Function splitString(number As String, substr As String) As String()
        ' this function always returns a String Array with 2 elements
        Dim dividedNumber() As String

        ' Split initial number into integer and decimal part
        dividedNumber = number.Split(substr)
        If dividedNumber.Length <= 1 Then
            ReDim Preserve dividedNumber(dividedNumber.Length)
            dividedNumber(1) = ""
        End If

        Return dividedNumber
    End Function

    Function reverseStrArray(intArray As String()) As String()
        Dim helper(intArray.Length - 1) As String
        Dim counter As Integer = 0

        For i = intArray.Length - 1 To 0 Step -1
            helper(counter) = intArray(i)
            counter += 1
        Next
        Return helper
    End Function

    Function stringInArrayString(str As String, arr As String()) As Boolean
        For Each element In arr
            If str = element Then
                Return True
            End If
        Next
        Return False
    End Function

    Function charInString(character As String, word As String) As Boolean
        For Each c In word
            If character = c Then
                Return True
            End If
        Next
        Return False
    End Function
End Module
