module TLK.PortalsAndHeroes.Tests.``Interdimensional Portal``

open NUnit.Framework
open FsUnit.TopLevelOperators
open TLK.PortalsAndHeroes.Kernel
open System.Linq

let hero = Hero
let dimension = Enumerable.ToList
let teleport hero currentDimension anotherDimension =
    let portal = (currentDimension, anotherDimension) |> InterdimensionalPortal
    hero |> portal.Teleport

let (bard, ranger, rogue, sorcerer, warlock, wizard) =
    (hero "Bard", hero "Ranger", hero "Rogue", hero "Sorcerer", hero "Warlock", hero "Wizard")

[<Test>]
let ``portal should teleport hero from current dimension``() =
    let currentDimension = dimension [ bard; ranger; rogue; wizard ]
    let anotherDimension = dimension [ sorcerer; warlock ]
    currentDimension |> teleport wizard <| anotherDimension
    currentDimension |> should not' (contain wizard)

[<Test>]
let ``portal should teleport hero to another dimension``() =
    let currentDimension = dimension [ bard; ranger; rogue; wizard ]
    let anotherDimension = dimension [ sorcerer; warlock ]
    currentDimension |> teleport wizard <| anotherDimension
    anotherDimension |> should contain wizard
