// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =

    Console.WriteLine("Zad 7.")
    File7.drawTree

    Console.WriteLine("Zad 8.")
    let dividers=File8.dividers
    for x in dividers do
        printfn "%d" x

    Console.WriteLine("Zad 9.")
    let list = [1; 4; 8; -2; 5; 1; 1; 1; 2; -2; -3;]
    let sortedList = File9.sort list
    for x in sortedList do
        printfn "%d" x

    Console.WriteLine("Zad 10.")
    let value = File10.func 10
    printfn "%b" value
    Console.ReadLine();    

    0 