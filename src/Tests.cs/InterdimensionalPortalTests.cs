using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;
using TLK.PortalsAndHeroes.Kernel;

namespace TLK.PortalsAndHeroes.Tests
{
    internal class InterdimensionalPortalTests
    {
        private readonly Hero bard = CreateHero("Bard");
        private readonly Hero ranger = CreateHero("Ranger");
        private readonly Hero rogue = CreateHero("Rogue");
        private readonly Hero sorcerer = CreateHero("Sorcerer");
        private readonly Hero warlock = CreateHero("Warlock");
        private readonly Hero wizard = CreateHero("Wizard");

        [Test]
        public void PortalShouldTeleportHeroFromCurrentDimension()
        {
            // arrange
            var currentDimension = new List<Hero> { bard, ranger, rogue, wizard };
            var anotherDimension = new List<Hero> { sorcerer, warlock };
            var portal = CreateInterdimensionalPortal(currentDimension, anotherDimension);

            // act
            portal.Teleport(wizard);

            // assert
            currentDimension.Should().NotContain(wizard);
        }

        [Test]
        public void PortalShouldTeleportHeroToAnotherDimension()
        {
            // arrange
            var currentDimension = new List<Hero> { bard, ranger, rogue, wizard };
            var anotherDimension = new List<Hero> { sorcerer, warlock };
            var portal = CreateInterdimensionalPortal(currentDimension, anotherDimension);

            // act
            portal.Teleport(wizard);

            // assert
            anotherDimension.Should().Contain(wizard);
        }

        private static Hero CreateHero(string @class) => new Hero(@class);

        private static InterdimensionalPortal CreateInterdimensionalPortal(ICollection<Hero> currentDimension, ICollection<Hero> anotherDimension) =>
            new InterdimensionalPortal(currentDimension, anotherDimension);
    }
}
