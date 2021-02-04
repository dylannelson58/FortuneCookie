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

        Randomize()
        randomValue = CInt((3 * Rnd()))     ' Generate random value between 0 and 3.

            Select Case randomValue

                Case 0
                    randomNumberCount(0) += 1
                Console.WriteLine($"Work done hard is not always hard work done.")
            Case 1
                    randomNumberCount(1) += 1
                Console.WriteLine($"The problems of yesterday show the accomplishments of today.")
            Case 2
                    randomNumberCount(2) += 1
                Console.WriteLine($"Time is nothing; Timing is everything.")

        End Select



        Console.Read()
    End Sub

End Module
