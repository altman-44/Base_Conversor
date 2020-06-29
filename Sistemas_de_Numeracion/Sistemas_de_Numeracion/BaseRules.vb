Public Class BaseRules
    Private rulesBases As Array

    Public Sub New()
        rulesBases = {{"11", "A"}, {"12", "AB"}, {"13", "ABC"}, {"14", "ABCD"}, {"15", "ABCDE"}, {"16", "ABCDEF"}}
    End Sub

    Public Function getBases() As Array
        Return rulesBases
    End Function

    Public Function getValue(letter As String) As Integer
        Select Case letter
            Case "A", "a"
                Return 10
            Case "B", "b"
                Return 11
            Case "C", "c"
                Return 12
            Case "D", "d"
                Return 13
            Case "E", "e"
                Return 14
            Case "F", "f"
                Return 15
            Case Else
                Return 0
        End Select
    End Function

    Public Function getLetter(number As Integer) As String
        Select Case number
            Case 11
                Return "A"
            Case 12
                Return "B"
            Case 13
                Return "C"
            Case 14
                Return "D"
            Case 15
                Return "E"
            Case 16
                Return "F"
            Case Else
                Return number
        End Select
    End Function

    Public Function isNumberValid(number As String) As Boolean
        Dim isValid = True
        For Each character As String In number
            If Not IsNumeric(character) And getValue(character) = 0 Then
                isValid = False
            End If
        Next
        Return isValid
    End Function

    Public Function correctBase(base As Integer, number As String) As Boolean
        'Dim rules As BaseRules = New BaseRules()
        Dim charsNumber(-1) As String
        Dim partsOfNumber = splitString(number, ".")
        Dim isCorrect = True

        ' Split the number char by char and pull all that into charsNumber
        For i = 0 To partsOfNumber(0).Length - 1
            ReDim Preserve charsNumber(charsNumber.Length)
            charsNumber(charsNumber.Length - 1) = CStr(partsOfNumber(0)(i))
        Next
        For i = 0 To partsOfNumber(1).Length - 1
            ReDim Preserve charsNumber(charsNumber.Length)
            charsNumber(charsNumber.Length - 1) = CStr(partsOfNumber(1)(i))
        Next

        Select Case base
            Case 0 Or 2 To 10
                Try
                    For i = 0 To charsNumber.Length - 1
                        If CInt(charsNumber(i)) >= base Then
                            isCorrect = False
                        End If
                    Next
                Catch ex As Exception
                    ' it means a not integer input was entered
                    isCorrect = False
                End Try
            Case 11 To 16
                Dim i = 0
                Dim isAllowed = True
                While i < getBases().GetUpperBound(0)
                    If CStr(base) = getBases()(i, 0) Then
                        For Each character As String In charsNumber
                            If Not IsNumeric(character) Then
                                If Not charInString(character, getBases()(i, 1)) Then
                                    isAllowed = False
                                End If
                            End If
                        Next
                        isCorrect = isAllowed
                        Exit While
                    End If
                    i += 1
                End While
        End Select
        Return isCorrect
    End Function
End Class
