module TLK.PortalsAndHeroes.Tests.Ported.``Interdimensional Portal``

open NUnit.Framework
open FsUnit.TopLevelOperators
open TLK.PortalsAndHeroes.Kernel
open System.Linq

let createHero(``class``) = new Hero(``class``)
let createInterdimensionalPortal(currentDimension, anotherDimension) =
    new InterdimensionalPortal(currentDimension, anotherDimension)

let bard = createHero("Bard")
let ranger = createHero("Ranger")
let rogue = createHero("Rogue")
let sorcerer = createHero("Sorcerer")
let warlock = createHero("Warlock")
let wizard = createHero("Wizard")

[<Test>]
let ``portal should teleport hero from current dimension``() =

    // arrange
    let currentDimension = Enumerable.ToList [ bard; ranger; rogue; wizard ]
    let anotherDimension = Enumerable.ToList [ sorcerer; warlock ]
    let portal = createInterdimensionalPortal(currentDimension, anotherDimension)

    // act
    portal.Teleport(wizard)

    // assert
    currentDimension |> should not' (contain wizard)

[<Test>]
let ``portal should teleport hero to another dimension``() =

    // arrange
    let currentDimension = Enumerable.ToList [ bard; ranger; rogue; wizard ]
    let anotherDimension = Enumerable.ToList [ sorcerer; warlock ]
    let portal = createInterdimensionalPortal(currentDimension, anotherDimension)

    // act
    portal.Teleport(wizard)

    // assert
    anotherDimension |> should contain wizard
