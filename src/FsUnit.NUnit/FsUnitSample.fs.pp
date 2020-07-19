﻿namespace $rootnamespace$.Tests

open NUnit.Framework
open FsUnit

type LightBulb(state) =
   member x.On = state
   override x.ToString() =
       match x.On with
       | true  -> "On"
       | false -> "Off"

[<TestFixture>] 
type ``Given a LightBulb that has had its state set to true`` ()=
   let lightBulb = LightBulb(true)

   [<Test>] member __.
    ``when I ask whether it is On it answers true.`` ()=
           lightBulb.On |> should be True

   [<Test>] member __.
    ``when I convert it to a string it becomes "On".`` ()=
           string lightBulb |> should equal "On"

