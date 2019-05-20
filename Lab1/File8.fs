module File8

open System

let dividers = 
        try
        Console.WriteLine("Prosze podać liczbę")
        let input = System.Console.ReadLine()
        let x = Convert.ToInt32(input)
        seq {for i in 1 .. x-1 do
                if (x % i = 0 ) then
                    yield i 
            }
        with 
                | :? System.FormatException -> 
                    printfn "Invalid number!"
                    null 