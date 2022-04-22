Imports System

Module Program
    Sub Main(args As String())
        Dim a, b, sum As Integer
        Console.WriteLine("a")
        a = Console.ReadLine()
        Console.WriteLine("b")

        b = Console.ReadLine()
        For i As Integer = a To (b - 1)
            sum += i
            Console.Write(i & " + ")

        Next
        Console.Write(b & " = " & (sum + b))
        Console.Read()
    End Sub
End Module