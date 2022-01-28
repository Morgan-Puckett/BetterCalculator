
Option Explicit On
Option Strict On
Option Compare Text
Module BetterCalculator

    Sub Main()
        Dim userResponseA As String
        Dim userResponseB As String
        Dim userResponseC As String
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim thirdNumber As Integer
        Dim goA As Boolean
        Dim goB As Boolean
        Dim goC As Boolean
        Dim quitQue As Boolean
        Dim menu As String
        Dim result As Integer
        menu = $"1. Add{vbNewLine}2. Subtract{vbNewLine}3. Muiltiply{vbNewLine}4. Divide"
        quitQue = False

        Do While quitQue = False
            Console.WriteLine("Please Enter 2 Numbers. Enter " & Chr(34) & "Q" & Chr(34) & " at anytime to quit.")
            Do
                Console.WriteLine("Choose a number:")
                userResponseA = Console.ReadLine()
                goA = True

                Try
                    firstNumber = CInt(userResponseA)
                    goA = True
                Catch ex As Exception

                    Select Case userResponseA

                        Case "q"
                            quitQue = True
                            goA = True
                        Case Else
                            Console.WriteLine($"You entered ""{userResponseA}"", please enter a whole number.")

                            goA = False
                    End Select

                End Try
            Loop Until goA = True
            Console.WriteLine($"You entered ""{firstNumber}""")



            Do
                    Console.WriteLine("Choose a number:")
                    userResponseB = Console.ReadLine()
                    Try
                        secondNumber = CInt(userResponseB)
                        goB = True
                    Catch ex As Exception
                        Select Case userResponseB
                            Case "q"
                                quitQue = True
                                goB = True
                            Case Else
                                Console.WriteLine($"You entered ""{userResponseB}"" please enter a whole number.")
                                goB = False
                        End Select

                    End Try
                Loop Until goB = True

            Console.WriteLine($"You entered ""{secondNumber}""")


        Do
                    Console.WriteLine(menu)
                    userResponseC = Console.ReadLine()
                    Try
                        thirdNumber = CInt(userResponseC)
                        Select Case thirdNumber
                            Case 1
                                result = firstNumber + secondNumber
                                Console.WriteLine($"{firstNumber} + {secondNumber} = {result}")
                                goC = True
                            Case 2
                                result = firstNumber - secondNumber
                                Console.WriteLine($"{firstNumber} - {secondNumber} = {result}")
                                goC = True
                            Case 3
                                result = firstNumber * secondNumber
                                Console.WriteLine($"{firstNumber} * {secondNumber} = {result}")
                                goC = True
                            Case 4
                                result = firstNumber \ secondNumber
                                Console.WriteLine($"{firstNumber} \ {secondNumber} = {result}")
                                goC = True
                            Case Else
                                Console.WriteLine($"You entered ""{userResponseC}""")
                                goC = False
                        End Select

                    Catch ex As Exception
                        Console.WriteLine($"You entered ""{userResponseC}""")
                        goC = False
                    End Try

                Loop Until goC = True

            Loop


            Console.WriteLine("Have a nice day")
        Console.ReadLine()
    End Sub

End Module
