Imports System

Module Program
    Sub Main(args As String())
        Dim intTotal1, intTotal2, intTotal3, intTotal4 As Integer
        For i As Integer = 1 To 100
            intTotal1 += i
        Next
        For i As Integer = 2 To 100 Step 2
            intTotal2 += i
        Next
        For i As Integer = 3 To 100 Step 3
            intTotal3 += i
        Next
        For i As Integer = 4 To 100 Step 4
            intTotal4 += i
        Next
        Console.WriteLine("全ての合計 = " & intTotal1)
        Console.WriteLine("2の倍数の合計 = " & intTotal2)
        Console.WriteLine("3の倍数の合計 = " & intTotal3)
        Console.WriteLine("4の倍数の合計 = " & intTotal4)

        Console.Read()


    End Sub
End Module
