Imports System

Module Program
    Sub Main(args As String())
        Dim intYear As Integer
        Console.WriteLine("�N����͂��Ă�������")
        intYear = Console.ReadLine()

        If intYear Mod 4 <> 0 Then
            Console.WriteLine(intYear & "�͂��邤�N�ł͂���܂���B")
        ElseIf intYear Mod 100 <> 0 Then
            Console.WriteLine(intYear & "�͂��邤�N�ł��B")
        ElseIf intYear Mod 400 <> 0 Then
            Console.WriteLine(intYear & "�͂��邤�N�ł͂���܂���B")
        Else
            Console.WriteLine(intYear & "�͂��邤�N�ł��B")
        End If
        'Console.WriteLine(intYear & "�͂��邤�N�ł��B")

        'Console.WriteLine(intYear & "�͂��邤�N�ł͂���܂���B")

        Console.Read()
    End Sub
End Module
