option explicit on
Option Strict On
Option Compare Binary

Imports System

Module Program
    Sub Main()
      Dim userInput as String
      'console.cls() TODO: this don't work
      Console.WriteLine("Hello, What is your name?")
      userInput = Console.ReadLine()
      Console.WriteLine("Hello " & userInput)
    End Sub
  End Module
