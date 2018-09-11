module TLK.PortalsAndHeroes.Tests.BifrostTests

open NUnit.Framework
open FsUnit.TopLevelOperators
open TLK.PortalsAndHeroes.Kernel

let testDelegate func = new TestDelegate(func >> ignore)
let shouldNotFail = testDelegate >> Assert.DoesNotThrow

let hofund = new Hofund()
let bifrost key () = new Bifrost(key)

[<Test>]
let ``Hofund should open Bifrost``() =
    hofund |> bifrost |> shouldNotFail
