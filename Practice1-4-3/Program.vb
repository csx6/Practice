Imports System

Module Program
    Sub Main(args As String())
        Dim intSum As Integer = 0
        For i As Integer = 1 To 100
            intSum += i
            Console.WriteLine(i & "までの合計は" & intSum)
        Next
        Console.Read()
    End Sub
End Module
