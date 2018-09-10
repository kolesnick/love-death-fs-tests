using FluentAssertions;
using NUnit.Framework;
using TLK.PortalsAndHeroes.Kernel;

namespace TLK.PortalsAndHeroes.Tests
{
    internal class HellgateTests
    {
        private readonly Hellgate hellgate = new Hellgate();

        [Test]
        public void HellgateInscriptionShouldBeLasciateOgniSperanzaVoiChentrate() =>
            hellgate.Inscription.Should().Be("Lasciate ogni speranza, voi ch'entrate");
    }
}
