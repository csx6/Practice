Imports System

Module Program
    Sub Main(args As String())
        Dim intSum As Integer = 0
        For i As Integer = 2 To 100 Step 2
            intSum += i
        Next
        Console.WriteLine("1から100までの偶数の合計は" & intSum & "です。")
        Console.Read()
    End Sub
End Module
