module TLK.PortalsAndHeroes.Tests.Hellgate

open NUnit.Framework
open FsUnit.TopLevelOperators
open TLK.PortalsAndHeroes.Kernel

let inscription (hellgate : Hellgate) = hellgate.Inscription
let close (hellgate : Hellgate) = hellgate.Close(); hellgate

[<Test>]
let ``hellgate inscription should be "Lasciate ogni speranza, voi ch'entrate"`` () =
    () |> Hellgate |> inscription |> should equal "Lasciate ogni speranza, voi ch'entrate"

[<Test>]
let ``closed hellgate inscription should be empty`` () =
    () |> Hellgate |> close |> inscription |> should be EmptyString
