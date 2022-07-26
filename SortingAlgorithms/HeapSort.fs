namespace SortingAlgorithms

module HeapSort =
    let moveLastToFirst list =
        match list with
        | [] -> []
        | _ -> list[list.Length - 1] :: list[..list.Length - 2]

    let swap (list: 'a list) first second =
        list[..first - 1] @ list[second] :: list[first + 1..second - 1] @ list[first] :: list[second + 1..]
    
    let rec heapify (list: 'a list) index =
        let leftChildIndex = 2 * index + 1
        let rightChildIndex = 2 * index + 2

        if leftChildIndex >= list.Length then
            list
        elif rightChildIndex >= list.Length then
            if list[index] < list[leftChildIndex] then
                heapify (swap list index leftChildIndex) leftChildIndex
            else
                list

        else
            let greaterChildIndex = if list[rightChildIndex] > list[leftChildIndex] then rightChildIndex else leftChildIndex
            if list[index] < list[greaterChildIndex] then
                heapify (swap list index greaterChildIndex) greaterChildIndex
            else
                list

    let rec buildHeap heap index =
        if index < 0 then
            heap
        else
            buildHeap (heapify heap index) (index - 1)

    let rec heapSort heap =
        match heap with
        | [] -> []
        | head :: tail -> heapSort (heapify (moveLastToFirst tail) 0) @ [head]

    let rec sort list =
        match list with
        | [] -> []
        | [ x ] -> [ x ]
        | _ ->
            let heap = buildHeap list (list.Length - 1)
            heapSort heap