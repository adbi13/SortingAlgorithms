namespace SortingAlgorithms

module MergeSort =
    let rec merge list1 list2 =
        match list1, list2 with
        | list, [] | [], list -> list
        | head1 :: tail1, head2 :: tail2 when head1 <= head2 -> head1 :: (merge tail1 (head2 :: tail2))
        | head1 :: tail1, head2 :: tail2 -> head2 :: (merge (head1 :: tail1) tail2)
    
    let rec sort list =
        match list with
        | [] -> []
        | [ x ] -> [ x ]
        | _ -> merge (sort list[..(list.Length / 2) - 1]) (sort list[(list.Length / 2)..])
