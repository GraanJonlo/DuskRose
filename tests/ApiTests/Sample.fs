module Tests

open Expecto

[<Tests>]
let tests =
    testList "samples" [
        testCase "contains things" <| fun _ ->
            Expect.containsAll [| 2; 3; 4 |] [| 2; 4 |]
                             "This is the case; {2,3,4} contains {2,4}"
    ]
