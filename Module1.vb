﻿Module Module1

    Sub Main()

        For i As Integer = 1 To 100

            If i Mod 3 = 0 And i Mod 5 = 0 Then

                Console.WriteLine("FizzBuzz")

            ElseIf i Mod 3 = 0 Then

                Console.WriteLine("Fizz")

            ElseIf i Mod 5 = 0 Then

                Console.WriteLine("Buzz")

            Else

                Console.WriteLine(i)

            End If

        Next

        Console.Read()

    End Sub

End Module
