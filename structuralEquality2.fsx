type Person = { Name: string; Surname: string; Age: int}
type CompanyHierarchy = Worker of Person | Manager of Person | Cto of Person

let makePerson companyRole =
    match companyRole with
    | CompanyHierarchy.Manager p | CompanyHierarchy.Cto p | CompanyHierarchy.Worker p -> p

let manager = { Name = "Marcin"; Surname = "Golenia"; Age = 30} |> CompanyHierarchy.Manager
let cto = { Name = "Marcin"; Surname = "Golenia"; Age = 30} |> CompanyHierarchy.Cto
// Test equality and compare
cto > manager |> printfn "%A is greater than %A: %b" cto manager 
cto = manager |> printfn "%A is equal to %A: %b" cto manager
let ctoPerson = cto |> makePerson
let managerPerson = manager |> makePerson
ctoPerson = managerPerson |> printfn "%A is equal to %A: %b" ctoPerson managerPerson 
