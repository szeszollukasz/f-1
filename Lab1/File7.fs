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
            let halfOfWidth = (width /2)
            let halfQuantityOfStars = ((2 * i) /2)
            if ( j > (halfOfWidth - halfQuantityOfStars)  && j < (halfOfWidth + halfQuantityOfStars)) then
                Console.Write("*");
            else Console.Write(" ");
        Console.WriteLine();

    //Console.WriteLine("C")
    //for i in 0 .. height do
    //    for j in 0 .. width do
    //        if j >= i then
    //            if (j % 2 = 0) then
    //             Console.Write("*");
    //        else 
    //            Console.Write("");
    //    Console.WriteLine();

    

    
            
