Imports System

Module Program
    Sub Main(args As String())
        Dim dateYearmonth As New DateTime
        Dim dateYearmonth1 As New DateTime
        Dim strSunday As String = "��"
        Dim strSaturday As String = "�y"
        'dateyearmonth = Console.ReadLine()


        dateYearmonth = "2013/08"
        dateyearmonth1 = "2013/09"


        Console.WriteLine("����������������������������������������������������������")
        Console.Write("��")
        Console.Write(dateyearmonth.ToString("yyyy�NMM��"))
        Console.Write(vbTab & vbTab & "    ")
        Console.WriteLine("��")
        Console.WriteLine("����������������������������������������������������������")
        Console.Write("��")
        Console.ForegroundColor = ConsoleColor.Red
        Console.Write(" ��")
        Console.ForegroundColor = ConsoleColor.White

        Console.Write("�� ���� �΄� ���� �؄� ���� ")
        Console.ForegroundColor = ConsoleColor.Blue
        Console.Write("�y")
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("��")

        Console.WriteLine("����������������������������������������������������������")
        Console.WriteLine(dateYearmonth1.ToString("dd") - dateYearmonth.ToString("dd"))

        'Do Until dateyearmonth = dateyearmonth1
        '    Console.Write("��")
        '    Console.Write(dateyearmonth.ToString(""))
        'Loop

        Console.Read()
    End Sub
End Module
