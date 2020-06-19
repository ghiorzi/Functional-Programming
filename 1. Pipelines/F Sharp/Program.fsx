open System

let numbers = [1..10]

let isEven number = number % 2 = 0

let square number = number * number

let sumEvenNumbers values =
    values
    |> List.filter isEven
    |> List.map square
    |> List.sum

numbers |> sumEvenNumbers |> printf "%d"