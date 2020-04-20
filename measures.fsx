[<Measure>] type h
[<Measure>] type day
[<Measure>] type month
[<Measure>] type zl

let workingHoursInDay = 8<h/day>
let averageWorkingDaysInMonth = 21<day/month>

let convertToDay (wage:int<zl/h>) = wage * workingHoursInDay
let convertToMonth (wage:int<zl/day>) = wage * averageWorkingDaysInMonth

let hourlyWage = 15<zl/h>
let dailyWage = hourlyWage |> convertToDay
let monthlyWage = dailyWage |> convertToMonth