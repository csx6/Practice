Imports System

Module Program
    Sub Main(args As String())
        Dim a, b, intSum, tmp As Integer
        Console.WriteLine("a�̒l")
        a = Console.ReadLine()
        Console.WriteLine("b�̒l")
        b = Console.ReadLine()

        If a > b Then 'a,b�̐��l�̕��ёւ��̂��߁A�ϐ�tmp���g�p����
            tmp = a
            a = b
            b = tmp
        End If

        Console.WriteLine("����")
        For i As Integer = a To b
            intSum += i
        Next
        Console.WriteLine(a & "����" & b & "�܂ł̍��v�l��" & intSum & "�ł��B")
        Console.Read()



    End Sub
End Module
