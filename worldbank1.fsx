#r "nuget: XPlot.GoogleCharts"
#r "nuget: Fsharp.Data"

open FSharp.Data
open XPlot.GoogleCharts;

let data = WorldBankData.GetDataContext()

data.Countries.``Poland``
    .Indicators.``CO2 emissions (metric tons per capita)``
      |> Chart.Line
      |> Chart.WithTitle "CO2 emissions"
      |> Chart.WithYTitle "Metric tons"
      |> Chart.WithXTitle "Year"
      |> Chart.Show