module TLK.PortalsAndHeroes.Tests.Ported.BifrostTests

open NUnit.Framework
open FsUnit.TopLevelOperators
open TLK.PortalsAndHeroes.Kernel

let shouldNotFail action = Assert.DoesNotThrow(new TestDelegate(action))

let createHofund() = new Hofund()

[<Test>]
let HofundShouldOpenBifrost() =

    // arrange
    let hofund = createHofund()

    // act
    let act = fun () -> new Bifrost(hofund) |> ignore

    // assert
    act |> shouldNotFail
