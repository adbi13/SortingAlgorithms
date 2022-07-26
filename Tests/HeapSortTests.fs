namespace SortingAlgorithms.Tests

open SortingAlgorithms
open System
open Xunit

module HeapSortTests =
    [<Fact>]
    let ``HeapSort: Empty list`` () =
        let expected = []
        let actual = HeapSort.sort []
        Assert.Equal<Collections.Generic.IEnumerable<int>>(expected, actual)

    [<Fact>]
    let ``HeapSort: Single item`` () =
        let expected = [2]
        let actual = HeapSort.sort [2]
        Assert.Equal<Collections.Generic.IEnumerable<int>>(expected, actual)

    [<Fact>]
    let ``HeapSort: Two items`` () =
        let expected = [1; 2]
        let actual = HeapSort.sort [2; 1]
        Assert.Equal<Collections.Generic.IEnumerable<int>>(expected, actual)

    [<Fact>]
    let ``HeapSort: Sorted two items`` () =
        let expected = [3; 9]
        let actual = HeapSort.sort [3; 9]
        Assert.Equal<Collections.Generic.IEnumerable<int>>(expected, actual)

    [<Fact>]
    let ``HeapSort: Short list`` () =
        let expected = [1; 2; 3; 4; 5; 8]
        let actual = HeapSort.sort [4; 1; 3; 8; 2; 5]
        Assert.Equal<Collections.Generic.IEnumerable<int>>(expected, actual)

    [<Fact>]
    let ``HeapSort: Long list`` () =
        let expected = [2; 4; 6; 13; 23; 34; 35; 54; 55; 56; 63; 92; 566; 54444487]
        let actual = HeapSort.sort [13; 35; 63; 2; 54; 92; 34; 55; 6; 23; 566; 54444487; 4; 56]
        Assert.Equal<Collections.Generic.IEnumerable<int>>(expected, actual)

    [<Fact>]
    let ``HeapSort: Sorted list`` () =
        let expected = [4; 7; 9; 58; 88; 92; 120; 418; 948]
        let actual = HeapSort.sort [4; 7; 9; 58; 88; 92; 120; 418; 948]
        Assert.Equal<Collections.Generic.IEnumerable<int>>(expected, actual)
