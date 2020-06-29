Public Class BaseConversor_Design
    Private Const formName As String = "Convertidor de Bases"
    Private Const textSelect As String = "Seleccionar base"
    Private items() As String = {"10", "2", "3", "4", "5", "6", "7", "8", "9", "11", "12", "13", "14", "15", "16"}
    Private Const enabledQuantDecimals As Integer = 30
    Private Const placeholderQuantDecimals As String = "Cantidad de decimales"
    Private Const placeholderNmb As String = "Número a convertir"
    Private Const placeholderResult As String = "Resultado"
    Private placeholderColor As Color = SystemColors.GrayText
    Private txtBoxNormalColor As Color = SystemColors.WindowText
    Private Const defaultQuantDecimals As Integer = 4
    Private Sub NumberingSystem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set checkboxes' text
        CmbFirstBase.Text = textSelect
        CmbSecondBase.Text = textSelect

        ' Add items to the checkboxes
        For i = 0 To items.Length - 1
            CmbFirstBase.Items.Add(items(i))
            CmbSecondBase.Items.Add(items(i))
        Next

        ' Placeholder to TextBoxes
        TxtQuantDecimals.Text = placeholderQuantDecimals
        TxtQuantDecimals.ForeColor = placeholderColor
        TxtNumber.Text = placeholderNmb
        TxtNumber.ForeColor = placeholderColor
        TxtResult.Text = placeholderResult
        TxtResult.ForeColor = placeholderColor

        ' Hide text box and label for quantity of decimals
        TxtQuantDecimals.Visible = False
        LblDecimals.Visible = False
    End Sub

    Private Sub BtnConvert_Click(sender As Object, e As EventArgs) Handles BtnConvert.Click
        Dim firstBase As Integer
        Dim secondBase As Integer
        Dim quantDecimals As Integer
        Dim numberConverted As String

        If checkInputs() Then
            firstBase = CmbFirstBase.Text
            secondBase = CmbSecondBase.Text
            Try
                quantDecimals = CInt(TxtQuantDecimals.Text)
            Catch ex As Exception
                ' as checkInputs() returned True, if there is an error here, it means the user did not enter any quantity for the decimals
                quantDecimals = defaultQuantDecimals
            End Try

            Try
                numberConverted = calculate(TxtNumber.Text, firstBase, secondBase, quantDecimals)
                TxtResult.Text = numberConverted
            Catch ex As Exception
                TxtResult.Text = "Número demasiado largo"
            End Try
        End If
    End Sub

    Function checkInputs() As Boolean
        Dim nmb As Integer
        Dim inputNumber As String
        Dim rules As BaseRules = New BaseRules()

        ' Bases
        If Not stringInArrayString(CmbFirstBase.Text, items) Then
            alert("Debe especificar en qué base está el número a ingresar")
            Return False
        End If
        If Not stringInArrayString(CmbSecondBase.Text, items) Then
            alert("Debe especificar a qué base desea convertir el número")
            Return False
        End If

        ' Input number
        inputNumber = Trim(TxtNumber.Text)
        If inputNumber = "" Or inputNumber = placeholderNmb Then
            alert("Debe ingresar algún número")
            Return False
        End If
        If Not rules.correctBase(CmbFirstBase.Text, inputNumber.ToUpper()) Then
            alert("El número debe estar en la base correcta")
            Return False
        End If

        ' Input quantity of enabled decimals
        If Trim(TxtQuantDecimals.Text) <> "" And Trim(TxtQuantDecimals.Text) <> placeholderQuantDecimals Then
            Dim valid = True
            Try
                nmb = CInt(Trim(TxtQuantDecimals.Text))
                If nmb < 0 Or nmb > enabledQuantDecimals Then
                    alert("La cantidad de decimales debe estar entre 0 y " & enabledQuantDecimals)
                    valid = False
                End If
            Catch ex As Exception
                alert("La cantidad de decimales debe ser entera")
                valid = False
            End Try
            If Not valid Then
                Return False
            End If
        End If

        Return True
    End Function

    Function alert(s As String)
        MsgBox(s, vbExclamation, formName)
    End Function

    Private Sub TxtNumber_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNumber.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnConvert_Click(sender, e)
        End If
    End Sub
    Private Sub TxtQuantDecimals_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtQuantDecimals.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnConvert_Click(sender, e)
        End If
    End Sub

    ' Show TextBox for quantity decimals
    Private Sub TxtNumber_TextChanged(sender As Object, e As EventArgs) Handles TxtNumber.TextChanged
        Dim number() As String
        Dim rules As BaseRules = New BaseRules()

        number = splitString(TxtNumber.Text, ".")
        Try
            withDecimals(CDbl(number(1)) > 0)
        Catch ex As Exception
            ' it means that there are letters
            If number(1).Length > 0 Then
                Dim isValid As Boolean
                isValid = rules.isNumberValid(number(1))
                withDecimals(isValid)
            Else
                withDecimals(False)
            End If
        End Try
    End Sub

    Function withDecimals(show As Boolean)
        TxtQuantDecimals.Visible = show
        LblDecimals.Visible = show
    End Function

    ' Focus on TextBoxes
    Private Sub TxtNumber_GotFocus(sender As Object, e As EventArgs) Handles TxtNumber.GotFocus
        If TxtNumber.Text = placeholderNmb Then
            setPlaceholder(False, TxtNumber, placeholderNmb)
        End If
    End Sub
    Private Sub TxtNumber_LostFocus(sender As Object, e As EventArgs) Handles TxtNumber.LostFocus
        If TxtNumber.Text = "" Then
            setPlaceholder(True, TxtNumber, placeholderNmb)
        End If
    End Sub
    Private Sub TxtQuantDecimals_GotFocus(sender As Object, e As EventArgs) Handles TxtQuantDecimals.GotFocus
        If TxtQuantDecimals.Text = placeholderQuantDecimals Then
            setPlaceholder(False, TxtQuantDecimals, placeholderQuantDecimals)
        End If
    End Sub
    Private Sub TxtQuantDecimals_LostFocus(sender As Object, e As EventArgs) Handles TxtQuantDecimals.LostFocus
        If TxtQuantDecimals.Text = "" Then
            setPlaceholder(True, TxtQuantDecimals, placeholderQuantDecimals)
        End If
    End Sub

    ' Placeholder for TextBoxes
    Function setPlaceholder(show As Boolean, element As TextBox, placeholder As String)
        If show Then
            element.ForeColor = placeholderColor
            element.Text = placeholder
        Else
            element.ForeColor = txtBoxNormalColor
            element.Text = ""
        End If
    End Function
End Class
