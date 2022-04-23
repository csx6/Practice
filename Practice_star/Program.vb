Imports System

Module Program
    Sub Main(args As String())

        ''1.
        'Console.WriteLine("0.5 * 5 三角アスタリスク")
        'For i As Integer = 1 To 5
        '    For j As Integer = 1 To 5
        '        Console.Write("*")
        '    Next
        '    Console.WriteLine()
        'Next

        ''2. 
        'Console.WriteLine("左上 三角アスタリスク")
        'For i As Integer = 1 To 5
        '    For j As Integer = 1 To 5
        '        If j >= i Then
        '            Console.Write("*")
        '            'Else
        '            '    Console.Write(" ")
        '        End If
        '    Next
        '    Console.WriteLine()
        'Next

        ''2. 
        'Console.WriteLine("左上 三角アスタリスク")
        'For i As Integer = 1 To 5
        '    For j As Integer = 1 To 5
        '        If j <= (6 - i) Then
        '            Console.Write("*")
        '        Else
        '            Console.Write(" ")
        '        End If
        '    Next
        '    Console.WriteLine()
        'Next

        ''3. 
        'Console.WriteLine("右上 三角アスタリスク")
        'For i As Integer = 1 To 5
        '    For j As Integer = 1 To 5
        '        If j >= i Then
        '            Console.Write("*")
        '        Else
        '            Console.Write(" ")
        '        End If
        '    Next
        '    Console.WriteLine()
        'Next

        ''4. 
        'Console.WriteLine("左下 三角アスタリスク")
        'For i As Integer = 1 To 5
        '    For j As Integer = 1 To 5
        '        If i >= j Then
        '            Console.Write("*")
        '        Else
        '            Console.Write(" ")
        '        End If
        '    Next
        '    Console.WriteLine()
        'Next

        ''5. 
        'Console.WriteLine("右下 三角アスタリスク")
        'For i As Integer = 1 To 5
        '    For j As Integer = 1 To 5
        '        If (6 - i) <= j Then
        '            Console.Write("*")
        '        Else
        '            Console.Write(" ")
        '        End If
        '    Next
        '    Console.WriteLine()
        'Next

        '6
        'Console.WriteLine("ダイヤモンド")
        'For i As Integer = 1 To 3
        '    Dim j As Integer = 1

        '    Do While j <= 5
        '        If j < (4 - i) Then
        '            Console.Write(" ")
        '        End If
        '        j += 1
        '    Loop
        '    For k As Integer = 1 To (2 * i - 1)
        '        Console.Write("*")
        '    Next

        '    Console.WriteLine()
        'Next

        'For i As Integer = 4 To 5
        '    Dim j As Integer = 1

        '    Do While j <= 5
        '        If j < (i - 2) Then
        '            Console.Write(" ")
        '        End If
        '        j += 1
        '    Loop
        '    For k As Integer = 1 To (2 * -i + 11)
        '        Console.Write("*")
        '    Next

        '    Console.WriteLine()
        'Next

        '6
        'When outputting star symbols, focus on the dividing line between graphics and blanks.
        'The general idea Is To use the i Function To control the number Of lines, And the j function to control the number of graphics in a single line.
        'On this basis, it Is necessary to confirm the intersection of the blank And the graph. Create axes on the graph so that the set i as the x-axis And the set j as the y-axis. This defines the range of graphs Or blanks.

        Console.WriteLine("diamond")
        Console.WriteLine("How many layers of diamonds do you want to output?(Odd number only)：")
        Dim hgtInt, colInt As Integer
        hgtInt = Console.ReadLine()
        colInt = (hgtInt + 1) / 2
        For i As Integer = 1 To colInt
            Dim j As Integer = 1

            Do While j <= hgtInt
                If j < ((colInt + 1) - i) Then
                    Console.Write(" ")
                End If
                j += 1
            Loop
            For k As Integer = 1 To (2 * i - 1)
                Console.Write("*")
            Next
            Console.WriteLine()
        Next

        For i As Integer = (colInt + 1) To hgtInt
            Dim j As Integer = 1

            Do While j <= hgtInt
                If j < (i - (colInt - 1)) Then
                    Console.Write(" ")
                End If
                j += 1
            Loop
            For k As Integer = 1 To (2 * (-i) + (2 * hgtInt + 1))
                Console.Write("*")
            Next
            Console.WriteLine()
        Next

        Console.Read()
    End Sub
End Module
