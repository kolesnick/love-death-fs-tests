module TLK.PortalsAndHeroes.Tests.BifrostTests

open NUnit.Framework
open TLK.PortalsAndHeroes.Kernel

let testDelegate func = TestDelegate (func)
let shouldNotThrow = testDelegate >> Assert.DoesNotThrow
let shouldThrow action = Assert.That (testDelegate action, Throws.Exception)

let openBifrost key () = (key) |> Bifrost |> ignore

[<Test>]
let ``Hofund should open Bifrost`` () =
    () |> Hofund |> openBifrost |> shouldNotThrow

[<Test>]
let ``Infinity Gauntlet should not open Bifrost`` () =
    () |> InfinityGauntlet |> openBifrost |> shouldThrow
