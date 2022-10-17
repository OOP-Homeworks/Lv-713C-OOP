using HW_10;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestToMyHomework_10
{
    [TestClass]
    public class CalcTriangleTest
    {
        [TestMethod]
        public void Distance_point1_X_1Y4_point2_X2_Y3_2_returned()
        {
            Point point1 = new Point();
            point1.X = 1;
            point1.Y = 4;

            Point point2 = new Point();
            point2.X = 2;
            point2.Y = 3;
            double expected = 2;

            Triangle i = new Triangle();

            double actual = Math.Ceiling(i.Distance(point1, point2));

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Perimetr_10and20and15_45returned()
        {
            double expected = 45;

            Triangle i = new Triangle();
            i.Side1 = 10;
            i.Side2 = 20;
            i.Side3 = 15;
            double actual = i.Perimetr();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Square_10and20and15_73returned()
        {
            double expected = 73;

            Triangle i = new Triangle();
            i.Side1 = 10;
            i.Side2 = 20;
            i.Side3 = 15;
            double actual = Math.Ceiling(i.Squere());

            Assert.AreEqual(expected, actual);
        }
    }
}
