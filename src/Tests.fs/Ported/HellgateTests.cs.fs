module TLK.PortalsAndHeroes.Tests.Ported.HellgateTests

open NUnit.Framework
open FsUnit.TopLevelOperators
open TLK.PortalsAndHeroes.Kernel

let hellgate = new Hellgate()

[<Test>]
let HellgateInscriptionShouldBeLasciateOgniSperanzaVoiChentrate () =
    hellgate.Inscription |> should equal "Lasciate ogni speranza, voi ch'entrate"
