Imports System

Module Program
    Sub Main(args As String())
        Dim j As Integer = 0
        For i As Integer = 1 To 100
            Console.Write(CStr(i) & " ")
            j += 1
            If j Mod 5 = 0 Then
                Console.WriteLine()
            End If
        Next
        Console.Read()
    End Sub
End Module
