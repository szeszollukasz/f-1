// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =

    File7.drawTree
    Console.ReadLine();

    let dividers=File8.dividers
    for x in dividers do
        printfn "%d" x
    Console.ReadLine();

    let sortedList = File9.sort
    for x in sortedList do
        printfn "%d" x
    Console.ReadLine();

    let value = File10.func 10
    printfn "%b" value
    Console.ReadLine();    

    0 