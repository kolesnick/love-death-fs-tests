using System;
using FluentAssertions;
using NUnit.Framework;
using TLK.PortalsAndHeroes.Kernel;

namespace TLK.PortalsAndHeroes.Tests
{
    internal class BifrostTests
    {
        [Test]
        public void HofundShouldOpenBifrost()
        {
            // arrange
            var hofund = CreateHofund();

            // act
            Action act = () => new Bifrost(hofund);

            // assert
            act.Should().NotThrow();
        }

        private static Hofund CreateHofund() => new Hofund();
    }
}
