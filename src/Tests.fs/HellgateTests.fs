module TLK.PortalsAndHeroes.Tests.HellgateTests

open NUnit.Framework
open FsUnit.TopLevelOperators
open TLK.PortalsAndHeroes.Kernel

let hellgate = new Hellgate()

[<Test>]
let ``hellgate inscription should be "Lasciate ogni speranza, voi ch'entrate"`` () =
    hellgate.Inscription |> should equal "Lasciate ogni speranza, voi ch'entrate"
