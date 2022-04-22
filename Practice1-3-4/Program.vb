Imports System

Module Program
    Sub Main(args As String())
        For i As Integer = 1 To 100
            Console.Write(101 - i)
            Console.Write(" ")
        Next
        Console.Read()
    End Sub
End Module
