module TLK.PortalsAndHeroes.Tests.HellgateTests

open NUnit.Framework
open FsUnit.TopLevelOperators
open TLK.PortalsAndHeroes.Kernel

let hellgate () = new Hellgate()
let inscription (hellgate : Hellgate) = hellgate.Inscription
let close (hellgate : Hellgate) = hellgate.Close(); hellgate

[<Test>]
let ``hellgate inscription should be "Lasciate ogni speranza, voi ch'entrate"`` () =
    () |> hellgate |> inscription |> should equal "Lasciate ogni speranza, voi ch'entrate"

[<Test>]
let ``closed hellgate inscription should be empty`` () =
    () |> hellgate |> close |> inscription |> should be EmptyString
