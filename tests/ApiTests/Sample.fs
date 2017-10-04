module Tests

open Api
open Expecto

[<Tests>]
let tests =
    testList "my tests" [
        testList "Category tests" [
            testCase "Admin can create category" <| fun _ ->
                let user = Admin
                let actual = Category.create user
                let expected = Ok ()
                Expect.equal actual expected "Admin user should be able to create category"
            
            testCase "Readonly user cannot create category" <| fun () ->
                let user = ReadOnly
                let actual = Category.create user
                let expected = Error ()
                Expect.equal actual expected "Read only user should not be able to create category"
        ]
    ]
