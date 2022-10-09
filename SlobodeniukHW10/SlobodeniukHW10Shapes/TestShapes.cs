using Microsoft.VisualStudio.TestPlatform.Common.Interfaces;
using Shapes;

namespace TestShapes
{
    [TestClass]
    public class TestShapes
    {
        [TestMethod]
        public void TestCompareTo()
        {
            // arrange
            double radius = 5;
            string name = "Circle";
            double side = 5;
            string name1 = "Square";
            int expected = 1;

            // act
            Circle testCircul = new Circle(radius, name);
            Square testSquare = new Square(side, name1);
            testCircul.GetArea();

            // assert
            Assert.AreEqual(expected, testCircul.CompareTo(testSquare));
        }
        [TestMethod]
        public void TestCircleArea()
        {
            // arrange
            double radius = 4;
            string name = "Circle";
            double expected = 50.27;

            // act
            Circle testCircul = new Circle(radius, name);
            testCircul.GetArea();

            // assert
            Assert.AreEqual(expected, testCircul.Area);
        }
        [TestMethod]
        public void TestCirclePerimetr()
        {
            // arrange
            double radius = 4;
            string name = "Circle";
            double expected = 25.13;

            // act
            Circle testCircul = new Circle(radius, name);
            testCircul.GetPerimeter();

            // assert
            Assert.AreEqual(expected, testCircul.Perimeter);
        }
        [TestMethod]
        public void TestSquareArea()
        {
            // arrange
            double side = 10;
            string name = "Square";
            double expected = 100;

            // act
            Square testSquare = new Square(side, name);
            testSquare.GetArea();

            // assert
            Assert.AreEqual(expected, testSquare.Area);
        }
        [TestMethod]
        public void TestSquarePerimeter()
        {
            // arrange
            double side = 10;
            string name = "Square";
            double expected = 40;

            // act
            Square testSquare = new Square(side, name);
            testSquare.GetPerimeter();

            // assert
            Assert.AreEqual(expected, testSquare.Perimeter);
        }
    }
}