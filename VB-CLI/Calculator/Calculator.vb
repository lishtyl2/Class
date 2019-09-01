Module Module1

    Sub Main()
        Dim myvalue As String
        Dim message1 As String
        Dim message As String
        Dim sum As Integer
        Dim a As Integer
        Dim b As Integer
        Dim product As Integer
        message = "Choose a number"
        message1 = "Sum or Product"
        a = InputBox(message)
        b = InputBox(message)
        sum = a + b
        product = a * b
        myvalue = InputBox(message1)
        If myvalue = "sum" Then
            Console.WriteLine(sum)
        ElseIf myvalue = "product" Then
            Console.WriteLine(product)

        End If
    End Sub

End Module
