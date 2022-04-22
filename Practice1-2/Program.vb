Imports System

Module Program
    Sub Main(args As String())
        Dim intYear As Integer
        Console.WriteLine("年を入力してください")
        intYear = Console.ReadLine()

        If intYear Mod 4 <> 0 Then
            Console.WriteLine(intYear & "はうるう年ではありません。")
        ElseIf intYear Mod 100 <> 0 Then
            Console.WriteLine(intYear & "はうるう年です。")
        ElseIf intYear Mod 400 <> 0 Then
            Console.WriteLine(intYear & "はうるう年ではありません。")
        Else
            Console.WriteLine(intYear & "はうるう年です。")
        End If
        'Console.WriteLine(intYear & "はうるう年です。")

        'Console.WriteLine(intYear & "はうるう年ではありません。")

        Console.Read()
    End Sub
End Module
