Option Strict On
Option Explicit On

'Dylan Nelson
'RCET0265
'Spring 2021
'Fortune Cookie
'https://github.com/dylannelson58/fortunecookie

Module FortuneCookie

    Sub Main()
        Dim randomNumberCount(5) As Integer
        Dim randomValue As Integer

        For i = 1 To 10000
            randomValue = CInt((3 * Rnd()))     ' Generate random value between 0 and 3.

            Select Case randomValue

                Case 0
                    randomNumberCount(0) += 1
                    Console.WriteLine($"wisdom 1")
                Case 1
                    randomNumberCount(1) += 1
                    Console.WriteLine($"wisdom 2")
                Case 2
                    randomNumberCount(2) += 1
                    Console.WriteLine($"wisdom 3")

            End Select

        Next
        Console.Read()
    End Sub

End Module
