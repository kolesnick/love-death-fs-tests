using System;
using FluentAssertions;
using NUnit.Framework;
using TLK.LoveDeathFSharp.Kernel;

namespace TLK.LoveDeathFSharp.Tests
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

        [Test]
        public void InfinityGauntletShouldNotOpenBifrost()
        {
            // arrange
            var infinityGauntlet = CreateInfinityGauntlet();

            // act
            Action act = () => new Bifrost(infinityGauntlet);

            // assert
            act.Should().Throw<Exception>();
        }

        private static Hofund CreateHofund() => new Hofund();
        private static InfinityGauntlet CreateInfinityGauntlet() => new InfinityGauntlet();
    }
}
