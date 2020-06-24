let multiplyBy = (*)

let multiplyBy2 = multiplyBy 2

[2;7;9] |> List.map multiplyBy2 |> printfn "%A" // 4, 14, 18

multiplyBy 2 9 |> printfn "%d" // 18

