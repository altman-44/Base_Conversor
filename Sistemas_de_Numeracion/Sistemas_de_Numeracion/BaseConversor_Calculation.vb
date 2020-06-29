Module BaseConversor_Calculation
    Private rules As BaseRules = New BaseRules()

    Function calculate(number As String, firstBase As Integer, secondBase As Integer, quantDecimals As Integer) As String
        Dim numberConverted As Double
        Dim result As String

        number = Trim(number).ToUpper()
        numberConverted = convertToDecimal(splitString(number, ".")(0), splitString(number, ".")(1), firstBase)
        result = convertToBase(splitString(numberConverted, ".")(0), splitString(numberConverted, ".")(1), secondBase, quantDecimals)
        Return result
    End Function

    Function convertToDecimal(intPart As String, fractionalPart As String, secondBase As Integer) As Double
        Dim fractionalPartConverted As Double = 0
        Dim intPartConverted As Integer = 0

        If fractionalPart <> "" Then
            fractionalPartConverted = sumTotal(-1, -1, fractionalPart, secondBase)
        End If
        intPartConverted = sumTotal(0, 1, intPart, secondBase)

        Return intPartConverted + fractionalPartConverted
    End Function

    Function sumTotal(initial As Integer, multiplicationDirection As Integer, number As String, base As Integer) As Double
        Dim total As Double = 0
        Dim p As Integer = initial
        Dim initFor As Integer
        Dim endFor As Integer
        Dim numberAux As Integer

        If multiplicationDirection = -1 Then
            ' the string number must be ranged normally
            initFor = 0
            endFor = number.Length - 1
        Else
            ' the string number must be ranged in a reversed way
            initFor = number.Length - 1
            endFor = 0
        End If

        For i = initFor To endFor Step (-1 * multiplicationDirection)
            Try
                numberAux = CStr(number(i))
            Catch ex As Exception
                ' it means it is a letter
                numberAux = rules.getValue(CStr(number(i)))
            End Try
            total += (base ^ p) * numberAux
            p += multiplicationDirection
        Next
        Return total
    End Function

    Function convertToBase(intPart As String, fractionalPart As String, base As Integer, quantDecimals As Integer) As String
        Dim result As String

        result = getRemainders(CInt(intPart), base)

        If fractionalPart <> "" And quantDecimals > 0 Then
            Dim fractionalPartConverted As String
            fractionalPartConverted = convertFractionalPartFromDecimal(fractionalPart, base, quantDecimals)
            result += "." + fractionalPartConverted
        End If

        Return result
    End Function

    Function getRemainders(dividend As Integer, divisor As Integer) As String
        Dim remainders(-1) As String
        Dim result As String = ""

        Do
            ReDim Preserve remainders(remainders.Length)
            remainders(remainders.Length - 1) = rules.getLetter(dividend Mod divisor)
            dividend \= divisor
        Loop While (dividend >= 1)

        remainders = reverseStrArray(remainders)
        For i = 0 To remainders.Length - 1
            result += remainders(i)
        Next

        Return result
    End Function

    Function convertFractionalPartFromDecimal(fractionalPart As String, base As Integer, quantDecimals As Integer) As String
        Dim fraction As String = fractionalPart
        Dim results(-1) As String
        Dim result As Double
        Dim partsOfNumber() As String
        Dim stringFormat As String = ""

        Do
            result = (CDbl("0." + fraction)) * base
            partsOfNumber = splitString(result, ".")
            ReDim Preserve results(results.Length)
            results(results.Length - 1) = rules.getLetter(partsOfNumber(0))
            fraction = partsOfNumber(1)
        Loop While quantDecimals > results.Length

        For i = 0 To results.Length - 1
            stringFormat += results(i)
        Next

        Return stringFormat
    End Function
End Module
