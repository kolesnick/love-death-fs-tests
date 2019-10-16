module TLK.LoveDeathFSharp.Tests.Wormhole

open NUnit.Framework
open FsUnit.TopLevelOperators
open TLK.LoveDeathFSharp.Kernel
open System.Linq

let ship = Spaceship
let station = SpaceStation
let spaceSector = Enumerable.ToList<Spacecraft>

let (blueGoose, samulakiStation, serenity, babylon5, ussVoyager) =
    (ship "Blue Goose", station "Samulaki Station", ship "Serenity", station "Babylon 5", ship "USS Voyager")

let displace ship origin destination =
    let wormhole = (origin, destination) |> Wormhole
    ship |> wormhole.Displace

[<Test>]
let ``wormhole should displace Blue Goose from Local Bubble to Schedar Sector`` () =
    let localBubble = spaceSector [ blueGoose; serenity; babylon5; ussVoyager ]
    let schedarSector = spaceSector [ samulakiStation ]

    localBubble |> displace blueGoose <| schedarSector

    localBubble |> should not' (contain blueGoose)
    schedarSector |> should contain blueGoose
