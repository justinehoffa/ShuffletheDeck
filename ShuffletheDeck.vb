'Justine Hoffa
'RCET0265
'Fall2020
'https://github.com/justinehoffa/ShuffletheDeck

Option Strict On
Option Explicit On
Option Compare Text

Module ShuffletheDeck

    Sub Main()
        'Write a program that deals a card from a standard deck of 52 playing cards. 
        'The card should be a random suit And value
        'Suits:  spades, clubs, hearts, diamonds
        'Values: 2-10, J, Q, K, A
        'Use a multidimensional array to track if the card has already been dealt. If so draw another random card
        'Shuffle the deck when there are no more cards left Or anytime the user chooses 

        Dim row As Integer = 12
        Dim column As Integer = 3
        Dim currentArray(row, column) As Boolean
        Dim randomColumn As Integer
        Dim randomRow As Integer
        Dim goodData As Boolean
        Dim suite As String
        Dim cardNumber As String
        Dim cardValue As String
        Dim cardsDealt As Integer
        Randomize()

        Do
            Console.WriteLine("Press enter to receive a card." _
                               & vbNewLine & "Type S to shuffle." _
                               & vbNewLine & "Type Q to quit. ")
            cardsDealt += 1

            Console.WriteLine(vbNewLine & "Cards Dealt: " & cardsDealt)

            goodData = False
            Do Until goodData = True
                randomColumn = CInt(Int((4 * Rnd())))
                randomRow = CInt(Int((13 * Rnd())))

                If Not currentArray(randomRow, randomColumn) = True Then
                    currentArray(randomRow, randomColumn) = True
                    goodData = True
                ElseIf goodData = False Then
                End If
            Loop

            cardNumber = CStr(randomRow + 1)
            If cardNumber = "11" Then
                cardValue = "Jack"
            ElseIf cardNumber = "12" Then
                cardValue = "King"
            ElseIf cardNumber = "13" Then
                cardValue = "Queen"
            ElseIf cardNumber = "1" Then
                cardValue = "Ace"
            Else cardValue = cardNumber

            End If

            If randomColumn = 0 Then
                suite = "Spades"
            ElseIf randomColumn = 1 Then
                suite = "Diamonds"
            ElseIf randomColumn = 2 Then
                suite = "Hearts"
            ElseIf randomColumn = 3 Then
                suite = "Clubs"
            End If

            Console.WriteLine(vbNewLine & cardValue & " Of " & suite)

            If cardsDealt = 52 Then
                Console.WriteLine(StrDup(4, vbTab) & "Cards Shuffled")
                For row = 0 To 12
                    For column = 0 To 3
                        currentArray(row, column) = False
                    Next
                    cardsDealt = 0
                Next
            Else
            End If

            Select Case Console.ReadLine()
                Case "Q"
                    Exit Sub
                Case "S"
                    Console.WriteLine(StrDup(4, vbTab) & "Cards Shuffled")
                    For row = 0 To 12
                        For column = 0 To 3
                            currentArray(row, column) = False
                        Next
                        cardsDealt = 0
                    Next
                    Console.ReadLine()
            End Select
            Console.Clear()
        Loop
    End Sub
End Module
