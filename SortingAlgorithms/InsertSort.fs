namespace SortingAlgorithms

module InsertSort =
    let rec insert list value =
        match list with
        | [] -> [ value ]
        | [ x ] -> [ min value x; max value x]
        | head :: tail when head > value -> value :: head :: tail
        | head :: tail -> head :: (insert tail value)

    let rec insertSort sorted unsorted =
        match unsorted with
        | [] -> sorted
        | head :: tail -> insertSort (insert sorted head) tail

    let sort list =
        insertSort [] list
