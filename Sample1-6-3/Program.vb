Imports System

Module Program
    Sub Main(args As String())
        Dim a, b As Integer '宣言必要な変数を先頭にまとめる
        Console.WriteLine("たて") '入力必要な変数aに関して、ユーザーに文書を提示する
        a = Console.ReadLine() 'aの入力
        Console.WriteLine("よこ") '入力必要な変数bに関して、ユーザーに文書を提示する
        b = Console.ReadLine() 'bの入力

        For i As Integer = 1 To a '立てループを作るため、ループ内i変数を宣言し、その範囲を策定する
            For j As Integer = 1 To b 'よこループ（改行ループ）を作るため、ループ内j変数を宣言し、その範囲を策定する
                Console.Write("*")
            Next
            Console.WriteLine() '改行
        Next

        Console.Read() '消えないように
    End Sub
End Module
