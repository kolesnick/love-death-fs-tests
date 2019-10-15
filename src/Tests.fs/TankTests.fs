module TLK.LoveDeathFSharp.Tests.Tank

open NUnit.Framework
open Foq
open TLK.LoveDeathFSharp.Kernel

let shouldThrowException action = Assert.That(new TestDelegate(action), Throws.Exception)

let shoot (tank : Tank) () = tank.Shoot() |> ignore

[<Test>]
let ``tank should not shoot with wolf inside``() =
    { new IShapeshifter with member x.Shape = Shape.Wolf }
    |> Tank
    |> shoot
    |> shouldThrowException
