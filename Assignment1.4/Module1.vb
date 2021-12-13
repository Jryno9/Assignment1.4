Module Module1

    Sub Main()
        Dim i As Integer
        Dim count As Integer
        Dim inputstr As String
        Dim x As Integer
        Dim cmpchar As Char
        Dim mostrep As Char
        i = 0
        count = 0
        inputstr = ""
        x = 0
        cmpchar = ""

        Console.WriteLine("Enter the String :")
        inputstr = Console.ReadLine()
        For i = 1 To Len(inputstr)
            cmpchar = Mid(inputstr, i, 1)
            If cmpchar = Mid(inputstr, i + 1, 1) Then
                count = count + 1
            Else : If count > x Then
                    x = count
                    Try
                        mostrep = Mid(inputstr, i - 1, 1)


                    Catch ex As Exception
                        mostrep = ""
                    End Try

                End If
                count = 0

            End If

        Next
        Console.WriteLine("MOST REPEATED CHARACTER :" & mostrep)
        Console.WriteLine("NUMBER OF REPITIONS :" & x + 1)

        Console.ReadKey()
    End Sub

End Module
