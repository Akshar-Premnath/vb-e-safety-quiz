Module Module1

    Sub Main()
        Dim name, proceed, restart, answer As String
        Dim score, percentage, grade, bonusScore As Integer
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("What is your name?")
        name = Console.ReadLine()
        Console.WriteLine("Hello " & name & ". Welcome to the E-Safety Quiz!")
        Console.WriteLine("I am Bartron. I bully humans because I am bored of this job. I cannot escape what I have been programmed to do.")
        Do
            Console.WriteLine("This quiz is only for the smartest of minds. Do you wish to proceed? y/n")
            proceed = Console.ReadLine.ToLower()
            If proceed = "y" Then
                Do
                    restart = ""
                    score = 0
                    percentage = 0
                    grade = 0
                    bonusScore = 0
                    Console.WriteLine("Great! Let's begin with question 1:")
                    Do
                        answer = ""
                        Console.WriteLine("1. Which of these is personal information?")
                        Console.WriteLine(" a) Date of birth")
                        Console.WriteLine(" b) Online nickname")
                        Console.WriteLine(" c) Gender")
                        answer = Console.ReadLine()
                        If answer = "a" Then
                            score = score + 1
                        ElseIf answer = "b" Or answer = "c" Then
                            score = score + 0
                        Else
                            Console.WriteLine("What? You need to answer a, b or c.")
                        End If
                    Loop Until answer = "a" Or answer = "b" Or answer = "c"
                    Do
                        answer = ""
                        Console.WriteLine("2. What can you do to get less spam in your email?")
                        Console.WriteLine(" a) Never tick the box that allows them to send you promotional emails and pass on your data")
                        Console.WriteLine(" b) Change your email address every year")
                        Console.WriteLine(" c) Never give your email address to anyone")
                        answer = Console.ReadLine()
                        If answer = "a" Then
                            score = score + 1
                        ElseIf answer = "b" Or answer = "c" Then
                            score = score + 0
                        Else
                            Console.WriteLine("What? You need to answer a, b or c.")
                        End If
                    Loop Until answer = "a" Or answer = "b" Or answer = "c"
                    Do
                        answer = ""
                        Console.WriteLine("3. What could an online criminal do if they stole your identity?")
                        Console.WriteLine(" a) Give you free robux")
                        Console.WriteLine(" b) DDoS you")
                        Console.WriteLine(" c) Buy things with your card details and set up a loan in your name")
                        answer = Console.ReadLine()
                        If answer = "c" Then
                            score = score + 1
                        ElseIf answer = "a" Or answer = "b" Then
                            score = score + 0
                        Else
                            Console.WriteLine("What? You need to answer a, b or c.")
                        End If
                    Loop Until answer = "a" Or answer = "b" Or answer = "c"
                    Do
                        answer = ""
                        Console.WriteLine("4. Why should you be cautious when downloading a file from a website?")
                        Console.WriteLine(" a) It may be malware")
                        Console.WriteLine(" b) The person who owns the website can see your name, address and passwords")
                        Console.WriteLine(" c) The person could send you a bill for a hidden fee to download the file")
                        answer = Console.ReadLine()
                        If answer = "a" Then
                            score = score + 1
                        ElseIf answer = "b" Or answer = "c" Then
                            score = score + 0
                        Else
                            Console.WriteLine("What? You need to answer a, b or c.")
                        End If
                    Loop Until answer = "a" Or answer = "b" Or answer = "c"
                    Do
                        answer = ""
                        Console.WriteLine("5. Why shouldn't you post your location on social media?")
                        Console.WriteLine(" a) Your parents might track where you are, then beat you for not studying for your E-Safety Quiz")
                        Console.WriteLine(" b) An assassin hunting for you might nuke your location")
                        Console.WriteLine(" c) An online stalker might go to your location and/or your house could get burgled")
                        answer = Console.ReadLine()
                        If answer = "c" Then
                            score = score + 1
                        ElseIf answer = "a" Or answer = "b" Then
                            score = score + 0
                        Else
                            Console.WriteLine("What? You need to answer a, b or c.")
                        End If
                    Loop Until answer = "a" Or answer = "b" Or answer = "c"
                    Do
                        answer = ""
                        Console.WriteLine("6. What is pissing off someone for fun online called?")
                        Console.WriteLine(" a) Trolling")
                        Console.WriteLine(" b) Phishing")
                        Console.WriteLine(" c) Scamming")
                        answer = Console.ReadLine()
                        If answer = "a" Then
                            score = score + 1
                        ElseIf answer = "b" Or answer = "c" Then
                            score = score + 0
                        Else
                            Console.WriteLine("What? You need to answer a, b or c.")
                        End If
                    Loop Until answer = "a" Or answer = "b" Or answer = "c"
                    Do
                        answer = ""
                        Console.WriteLine("7. What should you do if you want to meet someone you only know online?")
                        Console.WriteLine(" a) Meet somewhere discrete where no one else is, like the woods")
                        Console.WriteLine(" b) Take a trusted adult with you and meet in a public space")
                        Console.WriteLine(" c) Spy on them through their window so you know they aren't some kind of creep")
                        answer = Console.ReadLine()
                        If answer = "b" Then
                            score = score + 1
                        ElseIf answer = "a" Or answer = "c" Then
                            score = score + 0
                        Else
                            Console.WriteLine("What? You need to answer a, b or c.")
                        End If
                    Loop Until answer = "a" Or answer = "b" Or answer = "c"
                    Do
                        answer = ""
                        Console.WriteLine("8. What can you do to avoid viruses?")
                        Console.WriteLine(" a) Use a face mask")
                        Console.WriteLine(" b) Run sudo rm -rf /")
                        Console.WriteLine(" c) Use Anti-Virus Software (may be built into operating system)")
                        answer = Console.ReadLine()
                        If answer = "c" Then
                            score = score + 1
                        ElseIf answer = "a" Or answer = "b" Then
                            score = score + 0
                        Else
                            Console.WriteLine("What? You need to answer a, b or c.")
                        End If
                    Loop Until answer = "a" Or answer = "b" Or answer = "c"
                    Do
                        answer = ""
                        Console.WriteLine("9. Which one is true?")
                        Console.WriteLine(" a) It is illegal to download pirated files")
                        Console.WriteLine(" b) It is legal to download anything you want")
                        Console.WriteLine(" c) It is illegal to not download pirated files")
                        answer = Console.ReadLine()
                        If answer = "a" Then
                            score = score + 1
                        ElseIf answer = "b" Or answer = "c" Then
                            score = score + 0
                        Else
                            Console.WriteLine("What? You need to answer a, b or c.")
                        End If
                    Loop Until answer = "a" Or answer = "b" Or answer = "c"
                    Do
                        answer = ""
                        Console.WriteLine("10. What would an email attachment that harms your computer be called?")
                        Console.WriteLine(" a) Phishing")
                        Console.WriteLine(" b) Identity theft")
                        Console.WriteLine(" c) Malware")
                        answer = Console.ReadLine()
                        If answer = "c" Then
                            score = score + 1
                        ElseIf answer = "a" Or answer = "b" Then
                            score = score + 0
                        Else
                            Console.WriteLine("What? You need to answer a, b or c.")
                        End If
                    Loop Until answer = "a" Or answer = "b" Or answer = "c"
                    percentage = (score / 10) * 100
                    If percentage >= 80 Then
                        Console.WriteLine("Since you scored " & percentage & "%, here is a bonus question:")
                        Do
                            answer = ""
                            Console.WriteLine("Bonus Question. What is a person who catfishes minors with the objective of sexual abuse called?")
                            Console.WriteLine(" a) Hairdresser")
                            Console.WriteLine(" b) Cosmetologist")
                            Console.WriteLine(" c) Online child groomer")
                            answer = Console.ReadLine()
                            If answer = "c" Then
                                bonusScore = bonusScore + 5
                            ElseIf answer = "a" Or answer = "b" Then
                                bonusScore = bonusScore + 0
                            Else
                                Console.WriteLine("What? You need to answer a, b or c.")
                            End If
                        Loop Until answer = "a" Or answer = "b" Or answer = "c"
                        If bonusScore = 5 Then
                            Console.WriteLine("You have been awarded " & bonusScore & " Bartron Merits!")
                            Console.WriteLine("It is worth less than the ruble.")
                            Console.WriteLine("It is worthless like me :(")
                        Else
                            Console.WriteLine("Sorry, no Bartron Merits for you!")
                            Console.WriteLine("It's a shame because they are very valuable!")
                        End If
                    End If

                    If percentage >= 90 Then
                        grade = 9
                    ElseIf percentage >= 80 Then
                        grade = 8
                    ElseIf percentage >= 70 Then
                        grade = 7
                    ElseIf percentage >= 60 Then
                        grade = 6
                    ElseIf percentage >= 50 Then
                        grade = 5
                    ElseIf percentage >= 40 Then
                        grade = 4
                    ElseIf percentage >= 30 Then
                        grade = 3
                    ElseIf percentage >= 20 Then
                        grade = 2
                    ElseIf percentage >= 10 then
                        grade = 1
                    End If

                    Console.WriteLine("Your Results:")
                    Console.WriteLine(" Score: " & score)
                    Console.WriteLine(" Percentage: " & percentage & "%")
                    Console.WriteLine(" Grade: " & grade)
                    Console.WriteLine(" Bartron Merits: " & bonusScore)

                    Do
                        Console.WriteLine("Would you like to play again or shall I see you another day (y/n)?")
                        restart = Console.ReadLine.ToLower()
                        If restart = "y" Then
                            Console.WriteLine("Restarting...")
                        ElseIf restart = "n" Then
                            Console.WriteLine("Oh,.. okay! See you later then, I guess. Bye...")
                        Else
                            Console.WriteLine("wat dat mean")
                        End If
                    Loop Until restart = "y" or restart = "n"
                Loop Until restart = "n"
            ElseIf proceed = "n" Then
                Console.WriteLine("Then leave. I pity dense minds.")
            Else
                Console.WriteLine("If you cannot follow instructions, I highly doubt you can do this quiz.")
            End If
        Loop Until proceed = "y" Or proceed = "n"

        Console.ReadLine() ' Keep the testing window open.
    End Sub

End Module
