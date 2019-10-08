using FluentAssertions;
using NUnit.Framework;
using TLK.LoveDeathFSharp.Kernel;

namespace TLK.LoveDeathFSharp.Tests
{
    internal class YogurtTests
    {
        [Test]
        public void YogurtRequestIsWeWantOhio()
        {
            // arrange
            var yogurt = new Yogurt();

            // assert
            Assert.That(yogurt.Request, Is.EqualTo("We. Want. Ohio."));
        }

        [Test]
        public void YogurtRequestShouldBeWeWantOhio()
        {
            // arrange
            var yogurt = new Yogurt();

            // assert
            yogurt.Request.Should().Be("We. Want. Ohio.");
        }
    }
}
