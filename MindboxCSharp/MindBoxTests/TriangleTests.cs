using Mindbox;
using NUnit.Framework;

namespace MindBoxTests
{
    [TestFixture]
    public class TriangleTests
    {
        [TestCase(1, 1, 1)]
        [TestCase(2, 3, 4)]
        [TestCase(3, 4, 5)]
        public void Triangle_Exist(double a, double b, double c)
        {
            Assert.DoesNotThrow(() => new Triangle(a, b, c));
        }

        [TestCase(4, 2, 1)]
        [TestCase(2, 4, 1)]
        [TestCase(2, 1, 4)]
        [TestCase(0, 0, 0)]
        [TestCase(-1, 3, 5)]
        [TestCase(3, -5, 5)]
        [TestCase(3, 4, -3)]
        public void Triangle_NotExist(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
        }

        [TestCase(3, 4, 5, 6)]
        [TestCase(2, 3, 4, 2.9047375096555625)]
        [TestCase(1, 1, 1, 0.4330127018922193)]
        public void Triangle_Exist_CalculateSquare(double a, double b, double c, double expectedSquare)
        {
            var triangle = new Triangle(a, b, c);

            Assert.That(triangle.Sqare, Is.EqualTo(expectedSquare));
        }

        [TestCase(3, 4, 5, true)]
        [TestCase(1, 1, 1, false)]
        public void Triangle_IsRightTriangle(double a, double b, double c, bool expected)
        {
            var triangle = new Triangle(a, b, c);

            Assert.That(triangle.RightTriangle, Is.EqualTo(expected));
        }
    }
}
