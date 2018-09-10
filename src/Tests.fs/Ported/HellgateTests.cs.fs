module TLK.PortalsAndHeroes.Tests.Ported.HellgateTests

open NUnit.Framework
open FsUnit.TopLevelOperators
open TLK.PortalsAndHeroes.Kernel

let createHellgate() = new Hellgate()

[<Test>]
let HellgateInscriptionShouldBeLasciateOgniSperanzaVoiChentrate () =

    // arrange
    let hellgate = createHellgate()

    // assert
    hellgate.Inscription |> should equal "Lasciate ogni speranza, voi ch'entrate"

[<Test>]
let ClosedHellgateInscriptionShouldBeEmpty () =

    // arrange
    let hellgate = createHellgate()

    // act
    hellgate.Close()

    // assert
    hellgate.Inscription |> should be EmptyString
