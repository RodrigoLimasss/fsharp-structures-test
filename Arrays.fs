module Arrays

let lineArray = [|0; 1; 2; 3; 4; 5|]

let interactionArray = [|for i in 0..100 do if i%2 = 0 then yield i|]

let rangeArray = [|1..2..100|]

let stringArray = [|"Rodrigo", "João", "Jack"|]

let createArray = Array.create(100)(2)

let createZeroArray: string[] = Array.zeroCreate(10)
createZeroArray.SetValue("Rodrigo", 0)

let initArray = Array.init(10)(fun i -> i)

let filesArray = System.IO.Directory.EnumerateDirectories(@"c:\")
                 |> Array.ofSeq