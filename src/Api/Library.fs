namespace Api

type User =
| Admin
| ReadOnly

module Category =
    let create x =
        match x with
        | Admin -> Ok ()
        | ReadOnly -> Error ()

module UseCases =
    let hello name =
        printfn "Hello %s" name
