Imports System

Module Program
    Sub Main(args As String())
        Dim intSum As Integer = 0
        For i As Integer = 2 To 100 Step 2
            intSum += i
        Next
        Console.WriteLine("1����100�܂ł̋����̍��v��" & intSum & "�ł��B")
        Console.Read()
    End Sub
End Module
