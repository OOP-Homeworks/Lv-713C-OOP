using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using IDovhyiHomework10;

namespace TriangleTestIDovhyiHomework10
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void Distance_Point00andPoint01_1returned()
        {
            // arrenge
            
            Point point1 = new Point(0,0);
            Point point2 = new Point(0,1);
            Point point3 = new Point(1,0);
                
            double exected = 1;

            // actual
            Triangle triangle = new Triangle(point1,point2,point3);
            double actual = triangle.Distance(point1, point2);

            // assert
            Assert.AreEqual(exected, actual);
        }
        [TestMethod]
        public void Perimeter_Point00Point03Point04_12returned()
        {
            // arrenge

            Point point1 = new Point(0, 0);
            Point point2 = new Point(0, 3);
            Point point3 = new Point(4, 0);

            double exected = 12;

            // actual
            Triangle triangle = new Triangle(point1, point2, point3);
            double actual = triangle.Perimeter();

            // assert
            Assert.AreEqual(exected, actual);
        }
        [TestMethod]
        public void Square_Point00Point03Point04_6returned()
        {
            // arrenge

            Point point1 = new Point(0, 0);
            Point point2 = new Point(0, 3);
            Point point3 = new Point(4, 0);

            double exected = 6;

            // actual
            Triangle triangle = new Triangle(point1, point2, point3);
            double actual = triangle.Square();

            // assert
            Assert.AreEqual(exected, actual);
        }
        [TestMethod]
        public void minDistance_Point01Point02Point22_1returned()
        {
            // arrenge

            Point point1 = new Point(0, 1);
            Point point2 = new Point(0, 2);
            Point point3 = new Point(2, 2);

            double exected = 1;

            // actual
            Triangle triangle = new Triangle(point1, point2, point3);
            double actual = triangle.minDistance();

            // assert
            Assert.AreEqual(exected, actual);
        }
    }
}
