using Mindbox;
using NUnit.Framework;

namespace MindBoxTests
{
    [TestFixture]
    public class CircleTests
    {
        [TestCase(1, Math.PI)]
        [TestCase(0.5, 0.7853981633974483)]
        [TestCase(1.23, 4.752915525615998)]
        public void ValidRadius_Square(double radius, double expectedSquare)
        {
            var circle = new Circle(radius);

            Assert.That(circle.Sqare, Is.EqualTo(expectedSquare));
        }

        [TestCase(1)]
        [TestCase(0.5)]
        public void CircleWithPositiveRadiusMoreThenZero_Exist(double radius)
        {
            Assert.DoesNotThrow(() => new Circle(radius));
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void CircleWithRadiusLessOrEqualZero_NotExist(double radius)
        {
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }
    }
}
