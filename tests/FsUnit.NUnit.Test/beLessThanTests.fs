namespace FsUnit.Test

open NUnit.Framework
open FsUnit

[<TestFixture>]
type ``be lessThan tests``() =

    [<Test>]
    member _.``10 should be less than 11``() =
        10 |> should be (lessThan 11)

    [<Test>]
    member _.``10[dot]0 should be less than 10[dot]1``() =
        10.0 |> should be (lessThan 10.1)

    [<Test>]
    member _.``10 should not be less than 9``() =
        10 |> should not' (be lessThan 9)

    [<Test>]
    member _.``9[dot]2 should not be less than 9[dot]1``() =
        9.2 |> should not' (be lessThan 9.1)

    [<Test>]
    member _.``9[dot]1 should not be less than 9[dot]1``() =
        9.1 |> should not' (be lessThan 9.1)
