#r "nuget: XPlot.GoogleCharts"
#r "nuget: Fsharp.Data"

open FSharp.Data
open XPlot.GoogleCharts;

type WorldBank = WorldBankDataProvider<"World Development Indicators", Asynchronous=true>
let data = WorldBank.GetDataContext()

type Chart = 
 static member EntitleCo2 =  
    Chart.WithTitle "CO2 emissions" >> Chart.WithYTitle "Metric tons" >> Chart.WithXTitle "Year"

let countries = [data.Countries.``Poland``; data.Countries.``Germany``]
countries
  |> Seq.map(fun country -> country.Indicators.``CO2 emissions (metric tons per capita)``) 
  |> Async.Parallel 
  |> Async.RunSynchronously
  |> Chart.Line
  |> Chart.WithLabels (countries |> Seq.map(fun country -> country.Name))
  |> Chart.EntitleCo2
  |> Chart.Show
