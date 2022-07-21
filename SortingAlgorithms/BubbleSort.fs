namespace SortingAlgorithms

module BubbleSort =
    let rec bubble list =
        match list with
        | [] -> [], false
        | [ x ] -> [ x ], false
        | first :: second :: tail when first > second -> bubbleNext second (first :: tail) true
        | first :: second :: tail -> bubbleNext first (second :: tail) false
    
    and bubbleNext head tail swapped =
        let tailSorted, tailSwapped = bubble tail
        (head :: tailSorted), (swapped || tailSwapped)

    let rec sort list =
        match bubble list with
        | sortedList, false -> sortedList
        | unsortedList, true -> sort unsortedList
