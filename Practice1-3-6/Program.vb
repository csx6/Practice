Imports System

Module Program
    Sub Main(args As String())
        'For i As Integer = 1 To 100
        '    If i Mod 6 = 0 Then
        '        Console.Write(CStr(i) & " ")
        '    End If
        'Next
        For i As Integer = 6 To 100 Step 6
            Console.Write(CStr(i) & " ")
        Next
        Console.Read()
    End Sub
End Module
