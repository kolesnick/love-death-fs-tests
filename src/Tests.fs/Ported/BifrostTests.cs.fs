module TLK.PortalsAndHeroes.Tests.Ported.BifrostTests

open NUnit.Framework
open TLK.PortalsAndHeroes.Kernel

let shouldNotThrow action = Assert.DoesNotThrow(new TestDelegate(action))
let shouldThrow action = Assert.That(new TestDelegate(action), Throws.Exception)

let createHofund() = new Hofund()
let createInfinityGauntlet() = new InfinityGauntlet()

[<Test>]
let ``Hofund should open Bifrost``() =

    // arrange
    let hofund = createHofund()

    // act
    let act = fun () -> new Bifrost(hofund) |> ignore

    // assert
    act |> shouldNotThrow

[<Test>]
let ``Infinity Gauntlet should not open Bifrost``() =

    // arrange
    let infinityGauntlet = createInfinityGauntlet()

    // act
    let act = fun () -> new Bifrost(infinityGauntlet) |> ignore

    // assert
    act |> shouldThrow
