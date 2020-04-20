let (|Odd|Even|) number = 
  if number % 2 = 0 then Even else Odd

match 5 with
| Even -> "Even"
| Odd -> "Odd"
|> printf "%s"

let (|MultOf|_|) divider number = if number % divider = 0 then Some MultOf else None

let numbers = [|1..50|]

numbers |> Seq.iter(fun number -> 
    match number with
    | MultOf(2) & MultOf(3) -> printf "%i is MultOf 2 and 3" number
    | MultOf(2) -> printf "%i is MultOf 2" number
    | MultOf(3) -> printf "%i is MultOf 3" number
    | _ -> printf "%i Isn't mult of 2, 3." number
    printf "\n"
)

// Pattern matching on collections
let list = ["a1"; "b1"; "c1"]
match list with
| [] -> printf "empty"
| [a] -> printf "just %A" a
| [a; b] -> printf "two elements beginning with %A" a
| a::tail -> printf "many elements beginning with %A" a

// Pattern matching on records
type Person = { FirstName: string; LastName: string; Age: int }
let person = { FirstName="Marcin"; LastName="Golenia"; Age = 30 }
match person with 
| { FirstName="Marcin" }  -> printfn "Matched Marcin" 
| _  -> printfn "Other guy" 