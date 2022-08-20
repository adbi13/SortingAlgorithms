namespace SortingAlgorithms

module CountingSort =
    let rec count list leftBound (counts: int array) =
        match list with
        | [] -> counts
        | head :: tail ->
            counts[head - leftBound] <- counts[head - leftBound] + 1
            count tail leftBound counts

    let rec build list (counts: int array) leftBound actual =
        if actual >= counts.Length then
            list
        elif counts[actual] = 0 then
            build list counts leftBound (actual + 1)
        else
            counts[actual] <- counts[actual] - 1
            build (list @ [leftBound + actual]) counts leftBound actual



    let rec sort list =
        match list with
        | [] -> []
        | _ ->
            let listMin = List.min(list)
            let listMax = List.max(list)
            let counts = count list listMin [| for _ in listMin..listMax -> 0 |]
            build [] counts listMin 0
            
            
