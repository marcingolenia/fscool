let addToListIfNotThere list item =
    match (list |> Seq.contains item) with
        | true -> list
        | _ -> item :: list

let addToListIfNotThereAndGt0 list item =
    match (list |> Seq.contains item) with
        | true | _ when item < 0 -> list
        | _ -> item :: list