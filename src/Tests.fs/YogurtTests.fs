module TLK.LoveDeathFSharp.Tests.Yogurt

open NUnit.Framework
open FsUnit.TopLevelOperators
open TLK.LoveDeathFSharp.Kernel

let request (yogurt : Yogurt) = yogurt.Request

[<Test>]
let ``Yogurt's request should be "We. Want. Ohio."`` () =
    () |> Yogurt |> request |> should equal "We. Want. Ohio."
