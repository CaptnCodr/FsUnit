﻿namespace FsUnit.Test
open Microsoft.VisualStudio.TestTools.UnitTesting
open FsUnit.MsTest

[<TestClass>]
type ``contain tests`` ()=
    [<TestMethod>] member test.
     ``List with item should contain item`` ()=
        [1] |> should contain 1

    [<TestMethod>] member test.
     ``List with multiple items should contain item`` ()=
        [1;2;3] |> should contain 2

    [<TestMethod>] member test.
     ``populated List should not contain item`` ()=
        [2;4;5] |> should not' (contain 3)

    [<TestMethod>] member test.
     ``empty List should not contain item`` ()=
        [] |> should not' (contain 1)

    [<TestMethod>] member test.
     ``Array with multiple items should contain item`` ()=
        [|1;2;3|] |> should contain 2

    [<TestMethod>] member test.
     ``empty Array should not contain item`` ()=
        [||] |> should not' (contain 1)

    [<TestMethod>] member test.
     ``Array with different items should not contain item`` ()=
        [|2;3;4|] |> should not' (contain 1)

    [<TestMethod>] member test.
     ``Seq with item should contain item`` ()=
        seq { 1 } |> should contain 1

    [<TestMethod>] member test.
     ``empty Seq should not contain item`` ()=
        Seq.empty |> should not' (contain 1)

    [<TestMethod>] member test.
     ``Seq with items should contain item`` ()=
        { 2..3 } |> should contain 2

    [<TestMethod>] member test.
     ``Seq with different items should contain item`` ()=
        { 2..3 } |> should not' (contain 1)

    [<TestMethod>] member test.
     ``Enumerable with item should contain item`` ()=
        System.Collections.ArrayList([|1|]) |> should contain 1

    [<TestMethod>] member test.
     ``empty Enumerable should not contain item`` ()=
        System.Collections.ArrayList() |> should not' (contain 1)

    [<TestMethod>] member test.
     ``Enumerable with items should contain item`` ()=
        System.Collections.ArrayList([|2; 3|]) |> should contain 2

    [<TestMethod>] member test.
     ``Enumerable with different items should not contain item`` ()=
        System.Collections.ArrayList([|2; 3|]) |> should not' (contain 1)
