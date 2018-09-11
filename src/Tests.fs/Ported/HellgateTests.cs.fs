module TLK.PortalsAndHeroes.Tests.Ported.Hellgate

open NUnit.Framework
open FsUnit.TopLevelOperators
open TLK.PortalsAndHeroes.Kernel

let createHellgate() = new Hellgate()

[<Test>]
let ``hellgate inscription is "Lasciate ogni speranza, voi ch'entrate"``() =

    // arrange
    let hellgate = createHellgate()

    // assert
    Assert.That(hellgate.Inscription, Is.EqualTo("Lasciate ogni speranza, voi ch'entrate"))

[<Test>]
let ``hellgate inscription should be "Lasciate ogni speranza, voi ch'entrate"``() =

    // arrange
    let hellgate = createHellgate()

    // assert
    hellgate.Inscription |> should equal "Lasciate ogni speranza, voi ch'entrate"

[<Test>]
let ``closed hellgate inscription should be empty``() =

    // arrange
    let hellgate = createHellgate()

    // act
    hellgate.Close()

    // assert
    hellgate.Inscription |> should be EmptyString
