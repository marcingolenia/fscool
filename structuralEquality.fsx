type Person = { Name: string; Surname: string; Age: int}

let person1 = {Name = "Marcin"; Surname = "Golenia"; Age = 30}
let person2 = {Name = "Marcin"; Surname = "Golenia"; Age = 30}
let person3 = {Name = "Mickey"; Surname = "Mouse"; Age = 20}
let pair1 = person1, person3
let pair2 = person2, person3

printfn "%b" (person1 = person2) // prints true
printfn "%b" (pair1 = pair2) // prints true
printfn "%b" (person1 = person3) // prints false

printfn "%b" (person1 < person3) // prints false