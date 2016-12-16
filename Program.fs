// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
module Program

open System

[<EntryPoint>]
let main argv =
    //printfn "%A" argv
    printfn "%A" Arrays.lineArray
    let key = Console.ReadKey()
    0 // return an integer exit code
