module TLK.PortalsAndHeroes.Tests.BifrostTests

open NUnit.Framework
open TLK.PortalsAndHeroes.Kernel

let testDelegate func = new TestDelegate(func)
let shouldNotThrow = testDelegate >> Assert.DoesNotThrow
let shouldThrow action = Assert.That(testDelegate action, Throws.Exception)

let hofund = new Hofund()
let infinityGauntlet = new InfinityGauntlet()
let openBifrost key () = new Bifrost(key) |> ignore

[<Test>]
let ``Hofund should open Bifrost`` () =
    hofund |> openBifrost |> shouldNotThrow

[<Test>]
let ``Infinity Gauntlet should not open Bifrost`` () =
    infinityGauntlet |> openBifrost |> shouldThrow
