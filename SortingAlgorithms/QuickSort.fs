namespace SortingAlgorithms

module QuickSort =
    let rec partition pivot list  =
        match list with
        | [] -> [], []
        | head :: tail ->
            let lt, gt = partition pivot tail
            if head < pivot then head :: lt, gt else lt, head :: gt

    let rec sort list =
        match list with
        | [] -> []
        | [ x ] -> [ x ]
        | head :: tail ->
            let lt, gt = partition head tail
            (sort lt) @ head :: (sort gt)
