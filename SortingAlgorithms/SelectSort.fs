namespace SortingAlgorithms

open System

module SelectSort =
    let rec selectMin list =
        match list with
        | [] -> raise (ArgumentException("Can't select minimum from an empty list."))
        | [ x ] -> x, []
        | head :: tail ->
            let tailMin, tailWithoutMin = selectMin tail
            (min head tailMin), (max head tailMin) :: tailWithoutMin

    let rec selectSort sorted unsorted =
        match unsorted with
        | [] -> sorted
        | list ->
            let nextMin, unsortedTail = selectMin unsorted
            selectSort (sorted @ [ nextMin ]) unsortedTail

    let sort list =
        selectSort [] list
