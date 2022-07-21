open SortingAlgorithms

module Program =
    let [<EntryPoint>] main _ =
        let _ = MergeSort.sort [2; 1]
        0
