Module Program
    Sub Main(args As String())
        Dim dateYearmonth As New DateTime
        Dim dateYearmonth1 As New DateTime
        Dim dateYearmonth2 As New DateTime
        Dim dateYearmonth0 As New DateTime
        Dim intdays As Integer
        'dateyearmonth = Console.ReadLine()


        dateYearmonth = "2013/08"
        dateYearmonth1 = dateYearmonth.AddMonths(1)
        dateYearmonth2 = dateYearmonth1.AddDays(-1)
        dateYearmonth2 = dateYearmonth2.AddDays(-34) 'there are 35 numbers in a chart
        For i As Integer = 1 To 35
            If dateYearmonth2.ToString("ddd") = "÷‹»’" Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.Write(dateYearmonth2.ToString(" dd "))
                Console.ForegroundColor = ConsoleColor.White
            ElseIf dateYearmonth2.ToString("ddd") = "÷‹¡˘" Then
                Console.ForegroundColor = ConsoleColor.Blue
                Console.Write(dateYearmonth2.ToString(" dd "))
                Console.ForegroundColor = ConsoleColor.White
            Else
                Console.Write(dateYearmonth2.ToString(" dd "))
            End If

            dateYearmonth2 = dateYearmonth2.AddDays(1)
        Next







        'Do Until dateyearmonth = dateyearmonth1
        '    Console.Write("Ñ†")
        '    Console.Write(dateyearmonth.ToString(""))
        'Loop

        Console.Read()
    End Sub
End Module
