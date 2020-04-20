#r "nuget: Fsharp.Data"

open FSharp.Data

type Species = 
    HtmlProvider<"http://en.wikipedia.org/wiki/The_world's_100_most_threatened_species">
   
Species.GetSample().Tables.``Species list``.Rows 
    |> Seq.iter(fun item -> printf "%s \n" item.``Common name``)