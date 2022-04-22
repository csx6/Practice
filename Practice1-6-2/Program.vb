Imports System

Module Program
    Sub Main(args As String())
        For i As Integer = 1 To 10

            For j As Integer = 1 To 10
                Console.Write("*")
            Next
            Console.WriteLine()
        Next
        Console.Read()
    End Sub
End Module