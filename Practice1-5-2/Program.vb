Imports System

Module Program
    Sub Main(args As String())
        Dim a, b, intSum As Integer
        Console.WriteLine("aの値")
        a = Console.ReadLine()
        Console.WriteLine("bの値")
        b = Console.ReadLine()
        Console.WriteLine("結果")
        For i As Integer = a To b
            intSum += i
        Next
        Console.WriteLine(a & "から" & b & "までの合計値は" & intSum & "です。")
        Console.Read()
    End Sub
End Module
