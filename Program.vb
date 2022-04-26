Imports System

Module Program
    Sub Main(args As String())
        Dim dateYearmonth As New DateTime
        Dim dateYearmonth1 As New DateTime
        Dim strSunday As String = "“ú"
        Dim strSaturday As String = "“y"
        'dateyearmonth = Console.ReadLine()


        dateYearmonth = "2013/08"
        dateyearmonth1 = "2013/09"


        Console.WriteLine("„¡„Ÿ„Ÿ„Ÿ„Ÿ„Ÿ„Ÿ„Ÿ„Ÿ„Ÿ„Ÿ„Ÿ„Ÿ„Ÿ„Ÿ„Ÿ„Ÿ„Ÿ„Ÿ„Ÿ„Ÿ„Ÿ„Ÿ„Ÿ„Ÿ„Ÿ„Ÿ„Ÿ„¢")
        Console.Write("„ ")
        Console.Write(dateyearmonth.ToString("yyyy”NMMŒ"))
        Console.Write(vbTab & vbTab & "    ")
        Console.WriteLine("„ ")
        Console.WriteLine("„¥„Ÿ„Ÿ„Ÿ„¦„Ÿ„Ÿ„Ÿ„¦„Ÿ„Ÿ„Ÿ„¦„Ÿ„Ÿ„Ÿ„¦„Ÿ„Ÿ„Ÿ„¦„Ÿ„Ÿ„Ÿ„¦„Ÿ„Ÿ„Ÿ„§")
        Console.Write("„ ")
        Console.ForegroundColor = ConsoleColor.Red
        Console.Write(" “ú")
        Console.ForegroundColor = ConsoleColor.White

        Console.Write("„  Œ„  ‰Î„  …„  –Ø„  ‹à„  ")
        Console.ForegroundColor = ConsoleColor.Blue
        Console.Write("“y")
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("„ ")

        Console.WriteLine("„¥„Ÿ„Ÿ„Ÿ„©„Ÿ„Ÿ„Ÿ„©„Ÿ„Ÿ„Ÿ„©„Ÿ„Ÿ„Ÿ„©„Ÿ„Ÿ„Ÿ„©„Ÿ„Ÿ„Ÿ„©„Ÿ„Ÿ„Ÿ„§")
        Console.WriteLine(dateYearmonth1.ToString("dd") - dateYearmonth.ToString("dd"))

        'Do Until dateyearmonth = dateyearmonth1
        '    Console.Write("„ ")
        '    Console.Write(dateyearmonth.ToString(""))
        'Loop

        Console.Read()
    End Sub
End Module
