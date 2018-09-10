using FluentAssertions;
using NUnit.Framework;
using TLK.PortalsAndHeroes.Kernel;

namespace TLK.PortalsAndHeroes.Tests
{
    internal class HellgateTests
    {
        [Test]
        public void HellgateInscriptionIsEqualToLasciateOgniSperanzaVoiChentrate()
        {
            // arrange
            var hellgate = CreateHellgate();

            // assert
            Assert.That(hellgate.Inscription, Is.EqualTo("Lasciate ogni speranza, voi ch'entrate"));
        }

        [Test]
        public void HellgateInscriptionShouldBeLasciateOgniSperanzaVoiChentrate()
        {
            // arrange
            var hellgate = CreateHellgate();

            // assert
            hellgate.Inscription.Should().Be("Lasciate ogni speranza, voi ch'entrate");
        }

        [Test]
        public void ClosedHellgateInscriptionShouldBeEmpty()
        {
            // arrange
            var hellgate = CreateHellgate();

            // act
            hellgate.Close();

            // assert
            hellgate.Inscription.Should().BeEmpty();
        }

        private static Hellgate CreateHellgate() => new Hellgate();
    }
}
