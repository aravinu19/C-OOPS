Module Module1
    Sub Main()
        Dim c As Char
        Console.WriteLine("Enter a Character")
        c = Console.ReadLine()
        Select Case Asc(c)
            Case 65 to 90
                Console.WriteLine("UPPERCASE")
            Case 97 to 122
                Console.WriteLine("LOWERCASE")
            Case Else   Console.WriteLine("Other Characters")
        End Select

        Console.ReadLine();
    End Sub
End Module