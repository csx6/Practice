Imports System

Module Program
    Sub Main(args As String())
        Dim strDay As String

        strDay = Console.ReadLine()
        If strDay = "��" Then
            Console.WriteLine(strDay & "��Monday�ł��B")
        ElseIf strDay = "��" Then
            Console.WriteLine(strDay & "��Thesday�ł��B")
        ElseIf strDay = "��" Then
            Console.WriteLine(strDay & "��Wednesday�ł��B")
        ElseIf strDay = "��" Then
            Console.WriteLine(strDay & "��Thursday�ł��B")
        ElseIf strDay = "��" Then
            Console.WriteLine(strDay & "��Friday�ł��B")
        ElseIf strDay = "�y" Then
            Console.WriteLine(strDay & "��Saturday�ł��B")
        ElseIf strDay = "��" Then
            Console.WriteLine(strDay & "��Sunday�ł��B")
        Else
            Console.WriteLine("�j���ł͂���܂���")
        End If
        Console.Read()
    End Sub
End Module
