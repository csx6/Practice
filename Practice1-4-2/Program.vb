Imports System

Module Program
    Sub Main(args As String())
        Dim intTotal As Integer
        For i As Integer = 1 To 100
            intTotal += i
        Next
        Console.WriteLine(intTotal)
        Console.Read()
    End Sub
End Module
