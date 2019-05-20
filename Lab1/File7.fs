module File7

open System

let drawTree =
    let width = System.Console.WindowWidth
    let height = System.Console.WindowHeight

    Console.WriteLine("A")
    for i in 0 .. height do        
        for j in width - i .. width do
            Console.Write("*");
        Console.WriteLine();

    Console.WriteLine("B")
    for i in 0 .. height do
        for j in 0 .. width do
            Console.Write("*");
        Console.WriteLine();


    Console.WriteLine("C")
    for i in 0 .. height do
        for j in 0 .. width do
            if j >= i then
                Console.Write("*");
            else 
                Console.Write("");
        Console.WriteLine();

    

    
            
