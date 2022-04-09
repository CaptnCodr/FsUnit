namespace FsUnit.Test

open Xunit
open FsUnit.Xunit

type ``should startWith tests``() =
    [<Fact>]
    member _.``empty string should start with ""``() =
        "" |> should startWith ""

    [<Fact>]
    member _.``ships should start with ps``() =
        "ships" |> should startWith "sh"

    [<Fact>]
    member _.``ships should not start with ss``() =
        "ships" |> should not' (startWith "ss")

    [<Fact>]
    member _.``ships should not start with ss but messages should equal``() =
        (fun _ -> "ships" |> should startWith "ss")
        |> fun f -> Assert.Throws<MatchException>(f)
        |> fun e -> (e.Expected, e.Actual)
        |> should equal ("ss", "\"ships\"")
