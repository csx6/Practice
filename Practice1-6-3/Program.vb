Imports System

Module Program
    Sub Main(args As String())
        Dim a, b As Integer '�錾�K�v�ȕϐ���擪�ɂ܂Ƃ߂�
        Console.WriteLine("����") '���͕K�v�ȕϐ�a�Ɋւ��āA���[�U�[�ɕ�����񎦂���
        a = Console.ReadLine() 'a�̓���
        Console.WriteLine("�悱") '���͕K�v�ȕϐ�b�Ɋւ��āA���[�U�[�ɕ�����񎦂���
        b = Console.ReadLine() 'b�̓���

        For i As Integer = 1 To a '���ă��[�v����邽�߁A���[�v��i�ϐ���錾���A���͈̔͂����肷��
            For j As Integer = 1 To b '�悱���[�v�i���s���[�v�j����邽�߁A���[�v��j�ϐ���錾���A���͈̔͂����肷��
                Console.Write("*")
            Next
            Console.WriteLine() '���s
        Next

        Console.Read() '�����Ȃ��悤��
    End Sub
End Module
