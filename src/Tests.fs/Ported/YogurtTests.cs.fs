module TLK.PortalsAndHeroes.Tests.Ported.Yogurt

open NUnit.Framework
open FsUnit.TopLevelOperators
open TLK.PortalsAndHeroes.Kernel

[<Test>]
let ``Yogurt's request is "We. Want. Ohio."``() =

    // arrange
    let yogurt = new Yogurt()

    // assert
    Assert.That(yogurt.Request, Is.EqualTo("We. Want. Ohio."))

[<Test>]
let ``Yogurt's request should be "We. Want. Ohio."``() =

    // arrange
    let yogurt = new Yogurt()

    // assert
    yogurt.Request |> should equal "We. Want. Ohio."
