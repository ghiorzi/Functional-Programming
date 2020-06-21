let square number = number * number

let print value =  value |> printfn "%d"

// foward composition
let squareThenPrint = square >> print

[1..5] 
|> List.map squareThenPrint // 1, 4, 9, 16, 25

// Without composition
[1..5] 
|> List.map (fun number -> number * number |> print) // 1, 4, 9, 16, 25