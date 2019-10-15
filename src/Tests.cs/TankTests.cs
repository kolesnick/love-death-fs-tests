using System;
using FluentAssertions;
using Moq;
using NUnit.Framework;
using TLK.LoveDeathFSharp.Kernel;

namespace TLK.LoveDeathFSharp.Tests
{
    internal class TankTests
    {
        [Test]
        public void TankShouldNotShootWithWolfInside()
        {
            // arrange
            var wolf = Mock.Of<IShapeshifter>(x => x.Shape == Shape.Wolf);
            var tank = new Tank(wolf);

            // act
            Action act = () => tank.Shoot();

            // assert
            act.Should().Throw<Exception>();
        }
    }
}
