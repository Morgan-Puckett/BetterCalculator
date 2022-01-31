'Morgan Puckett
'RCET0265
'Spring 2022
'Better Calculator
'https://github.com/Morgan-Puckett/BetterCalculator.git

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
        Dim goHome As Boolean
        goA = False
        goB = False
        goC = False
        goHome = False
        Dim menu As String
        Dim result As Integer
        menu = $"1. Add{vbNewLine}2. Subtract{vbNewLine}3. Muiltiply{vbNewLine}4. Divide"


        Do While goHome = False
            goA = False
            goB = True
            goC = True
            goHome = True
            Console.WriteLine("Please Enter 2 Numbers. Enter " & Chr(34) & "Q" & Chr(34) & " at anytime to quit.")
            Do While goA = False

                Console.WriteLine("Choose a number:")
                userResponseA = Console.ReadLine()
                goA = True

                Try
                    firstNumber = CInt(userResponseA)
                    goA = True
                    goB = False
                    goC = True
                    goHome = True
                    Console.WriteLine($"You entered ""{firstNumber}""")
                Catch ex As Exception

                    Select Case userResponseA

                        Case "q"
                            goA = True
                            goB = True
                            goC = True
                            goHome = True
                        Case Else
                            Console.WriteLine($"You entered ""{userResponseA}"", please enter a whole number.")

                            goA = False
                    End Select


                End Try
            Loop



            Do While goB = False
                Console.WriteLine("Choose a number:")
                userResponseB = Console.ReadLine()
                Try
                    secondNumber = CInt(userResponseB)
                    goA = True
                    goB = True
                    goC = False
                    goHome = True
                    Console.WriteLine($"You entered ""{secondNumber}""")
                Catch ex As Exception
                    Select Case userResponseB
                        Case "q"
                            goA = True
                            goB = True
                            goC = True
                            goHome = True
                        Case Else
                            Console.WriteLine($"You entered ""{userResponseB}"" please enter a whole number.")
                            goB = False
                    End Select

                End Try
            Loop



            Do While goC = False
                Console.WriteLine(menu)
                userResponseC = Console.ReadLine()
                Try
                    thirdNumber = CInt(userResponseC)
                    Select Case thirdNumber
                        Case 1
                            result = firstNumber + secondNumber
                            Console.WriteLine($"{firstNumber} + {secondNumber} = {result}")
                            goA = False
                            goB = False
                            goC = True
                            goHome = False
                        Case 2
                            result = firstNumber - secondNumber
                            Console.WriteLine($"{firstNumber} - {secondNumber} = {result}")
                            goA = False
                            goB = False
                            goC = True
                            goHome = False
                        Case 3
                            result = firstNumber * secondNumber
                            Console.WriteLine($"{firstNumber} * {secondNumber} = {result}")
                            goA = False
                            goB = False
                            goC = True
                            goHome = False
                        Case 4
                            result = firstNumber \ secondNumber
                            Console.WriteLine($"{firstNumber} \ {secondNumber} = {result}")
                            goA = False
                            goB = False
                            goC = True
                            goHome = False
                        Case Else
                            Console.WriteLine($"You entered ""{userResponseC}""")
                            goC = False
                    End Select

                Catch ex As Exception
                    Select Case userResponseC
                        Case "q"
                            goA = True
                            goB = True
                            goC = True
                            goHome = True
                        Case Else
                            Console.WriteLine($"You entered ""{userResponseC}""")
                            goC = False
                    End Select

                End Try

            Loop


        Loop

        Console.WriteLine("Have a nice day")
        Console.ReadLine()
    End Sub

End Module
