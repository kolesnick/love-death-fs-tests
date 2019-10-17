module TLK.LoveDeathFSharp.Tests.Ported.Tank

open NUnit.Framework
open Foq
open TLK.LoveDeathFSharp.Kernel

let shouldThrowException action = Assert.That(new TestDelegate(action), Throws.Exception)

[<Test>]
let ``tank should not shoot with wolf inside``() =

    // arrange
    let wolf = Mock<IShapeshifter>.With(fun x -> <@ x.Shape --> Shape.Wolf @>)
    let tank = new Tank(wolf)

    // act
    let act () = tank.Shoot()

    // assert
    act |> shouldThrowException
