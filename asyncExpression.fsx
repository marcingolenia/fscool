#r "nuget: FSharp.Data"
#r "nuget: FSharp.Json"

open FSharp.Data
open FSharp.Json

type move = {
    [<JsonField("name")>]
    Name: string
}

type moveEntry = {
    [<JsonField("move")>]
    Move: move
}

type PokemonInfoDto = {
    [<JsonField("moves")>]
    Moves: moveEntry list
}


let getPokemon pokemonName =
    async {
        let! data = Http.AsyncRequestString(sprintf "https://pokeapi.co/api/v2/pokemon/%s" pokemonName, silentHttpErrors = true)
        return Json.deserialize<PokemonInfoDto> data
    }

let pokemonMoves = getPokemon "psyduck" |> Async.RunSynchronously
printf "%A" pokemonMoves