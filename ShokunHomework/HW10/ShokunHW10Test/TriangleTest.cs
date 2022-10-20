using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShokunHW10_1;
using System;
using System.Drawing;
using static ShokunHW10_1.Triangle;
using Point = ShokunHW10_1.Point;

namespace ShokunHW10Test
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void DistanceTest()
        {
            Point p1 = new Point(1, 1);
            Point p2 = new Point(2, 2);
            Point p3 = new Point(3, 3);

            double expected = 1.41;

            Triangle test = new Triangle(p1, p2, p3);
            double actual = test.Distance(p1,p2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PerimeterTest()
        {
            Point p1 = new Point(1, 1);
            Point p2 = new Point(2, 2);
            Point p3 = new Point(3, 3);

            double expected = 5.65;

            Triangle test = new Triangle(p1, p2, p3);
            double actual =  test.Perimeter();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SquareTest()
        {
            Point p1 = new Point(1, 5);
            Point p2 = new Point(2, 7);
            Point p3 = new Point(3, 1);

            double expected = 4.01;

            Triangle test = new Triangle(p1, p2, p3);
            double actual = test.Square();

            Assert.AreEqual(expected, actual);
        }
    }
}
