Imports System

Module Program
    Sub Main(args As String())
        Dim intSum As Integer = 0
        For i As Integer = 1 To 100
            intSum += i
            Console.WriteLine(i & "�܂ł̍��v��" & intSum)
        Next
        Console.Read()
    End Sub
End Module
