module TLK.LoveDeathFSharp.Tests.Ported.Wormhole

open NUnit.Framework
open FsUnit.TopLevelOperators
open TLK.LoveDeathFSharp.Kernel
open System.Linq

let blueGoose = new Spaceship("Blue Goose")
let samulakiStation = new SpaceStation("Samulaki Station")
let serenity = new Spaceship("Serenity")
let babylon5 = new SpaceStation("Babylon 5")
let ussVoyager = new Spaceship("USS Voyager")

[<Test>]
let ``wormhole should displace Blue Goose from Local Bubble to Schedar Sector``() =

    // arrange
    let localBubble = Enumerable.ToList<Spacecraft> [ blueGoose; serenity; babylon5; ussVoyager ]
    let schedarSector = Enumerable.ToList<Spacecraft> [ samulakiStation ]
    let wormhole = new Wormhole(localBubble, schedarSector)

    // act
    wormhole.Displace(blueGoose)

    // assert
    localBubble |> should not' (contain blueGoose)
    schedarSector |> should contain blueGoose
