using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;
using TLK.LoveDeathFSharp.Kernel;

namespace TLK.LoveDeathFSharp.Tests
{
    internal class WormholeTests
    {
        private readonly Spaceship blueGoose = new Spaceship("Blue Goose");
        private readonly SpaceStation samulakiStation = new SpaceStation("Samulaki Station");
        private readonly Spaceship serenity = new Spaceship("Serenity");
        private readonly SpaceStation babylon5 = new SpaceStation("Babylon 5");
        private readonly Spaceship ussVoyager = new Spaceship("USS Voyager");

        [Test]
        public void WormholeShouldDisplaceBlueGooseFromLocalBubbleToSchedarSector()
        {
            // arrange
            var localBubble = new List<Spacecraft> { blueGoose, serenity, babylon5, ussVoyager };
            var schedarSector = new List<Spacecraft> { samulakiStation };
            var wormhole = new Wormhole(localBubble, schedarSector);

            // act
            wormhole.Displace(blueGoose);

            // assert
            localBubble.Should().NotContain(blueGoose);
            schedarSector.Should().Contain(blueGoose);
        }
    }
}
