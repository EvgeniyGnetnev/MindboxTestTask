using NUnit.Framework;
using System;

namespace MindboxTestTask.UnitTests
{
    public class Tests
    {
        [Test]
        public void Circle_NegativeRadius_ThrowsException()
        {
            double negativeRadius = -1;

            Assert.Throws<Exception>(() => new Circle(negativeRadius));
        }

        [Test]
        public void Triangle_NegativeLengthsSides_ThrowsException()
        {
            double negativeSideLength = -1;
            double positiveSideLength = 1;

            Assert.Throws<Exception>(() => new Triangle(negativeSideLength, positiveSideLength, positiveSideLength));
            Assert.Throws<Exception>(() => new Triangle(positiveSideLength, negativeSideLength, positiveSideLength));
            Assert.Throws<Exception>(() => new Triangle(positiveSideLength, positiveSideLength, negativeSideLength));
        }

        [Test]
        public void IsRight_RightTriangle_ReturnsTrue()
        {
            Triangle rightTriangle = new Triangle(3, 4, 5);

            var actual = rightTriangle.IsRight();

            Assert.IsTrue(actual);
        }
    }
}