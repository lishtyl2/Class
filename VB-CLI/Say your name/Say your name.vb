Module Module1

    Sub Main()
        Dim Message, Title, Myvalue
        Message = "Hello! What's your name?"
        Title = "Name asker"
        Myvalue = InputBox(Message, Title)
        If Myvalue = "Emily" Then
            Console.WriteLine("Hello Emily")
        ElseIf Myvalue = "Joe" Then
            Console.WriteLine("Hello Joe")
        ElseIf Myvalue = "Tyler" Then
            Console.WriteLine("AWWWW Let's get the party started!")
        End If

    End Sub

End Module
