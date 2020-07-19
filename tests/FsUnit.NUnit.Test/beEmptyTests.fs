namespace FsUnit.Test

open NUnit.Framework
open FsUnit

[<TestFixture>]
type ``be Empty tests``() =
    [<Test>]
    member __.``empty List should be Empty``() =
        [] |> should be Empty

    [<Test>]
    member __.``non-empty List should fail to be Empty``() =
        shouldFail(fun () -> [ 1 ] |> should be Empty)

    [<Test>]
    member __.``non-empty List should not be Empty``() =
        [ 1 ] |> should not' (be Empty)

    [<Test>]
    member __.``empty List should fail to not be Empty``() =
        shouldFail(fun () -> [] |> should not' (be Empty))

    [<Test>]
    member __.``empty Array should be Empty``() =
        [||] |> should be Empty

    [<Test>]
    member __.``non-empty Array should fail to be Empty``() =
        shouldFail(fun () -> [| 1 |] |> should be Empty)

    [<Test>]
    member __.``non-empty Array should not be Empty``() =
        [| 1 |] |> should not' (be Empty)

    [<Test>]
    member __.``empty Array should fail to not be Empty``() =
        shouldFail(fun () -> [||] |> should not' (be Empty))

    [<Test>]
    member __.``empty Seq should be Empty``() =
        Seq.empty |> should be Empty

    [<Test>]
    member __.``non-empty Seq should fail to be Empty``() =
        shouldFail(fun () -> seq { 1 } |> should be Empty)

    [<Test>]
    member __.``non-empty Seq should not be Empty``() =
        seq { 1 } |> should not' (be Empty)

    [<Test>]
    member __.``empty Seq should fail to not be Empty``() =
        shouldFail(fun () -> Seq.empty |> should not' (be Empty))

    [<Test>]
    member __.``string null should be Empty``() =
        string null |> should be Empty
