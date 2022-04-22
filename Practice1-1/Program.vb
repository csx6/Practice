Imports System

Module Program
    Sub Main(args As String())
        Dim strDay As String

        strDay = Console.ReadLine()
        If strDay = "月" Then
            Console.WriteLine(strDay & "はMondayです。")
        ElseIf strDay = "火" Then
            Console.WriteLine(strDay & "はThesdayです。")
        ElseIf strDay = "水" Then
            Console.WriteLine(strDay & "はWednesdayです。")
        ElseIf strDay = "木" Then
            Console.WriteLine(strDay & "はThursdayです。")
        ElseIf strDay = "金" Then
            Console.WriteLine(strDay & "はFridayです。")
        ElseIf strDay = "土" Then
            Console.WriteLine(strDay & "はSaturdayです。")
        ElseIf strDay = "日" Then
            Console.WriteLine(strDay & "はSundayです。")
        Else
            Console.WriteLine("曜日ではありません")
        End If
        Console.Read()
    End Sub
End Module
