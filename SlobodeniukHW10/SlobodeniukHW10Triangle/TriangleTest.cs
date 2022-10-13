using SlobodeniukHW10;

namespace TriangleTest
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void TestPerimeter()
        {
            // arrange
            Point a = new Point(1, 2);
            Point b = new Point(1, 10);
            Point c = new Point(3, 8);

            double expected = 12;

            // act
            Triangle test = new Triangle(a, b, c);
            double actual = test.Perimeter();

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestSquare()
        {
            // arrange
            Point a = new Point(4, 2);
            Point b = new Point(4, 6);
            Point c = new Point(2, 3);

            double expected = 3;

            // act
            Triangle test = new Triangle(a, b, c);
            double actual = test.Square();

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestTriangleExist()
        {
            // this triangle does not exist
            // arrange
            Point a = new Point(3, 2);
            Point b = new Point(3, 6);
            Point c = new Point(2, 7);

            // act
            Triangle test = new Triangle(a, b, c);

            // assert
            Assert.IsTrue(test.TriangleExist());
        }
        
        [TestMethod]
        public void TestDistance()
        {
            // arrange
            Point a = new Point(3, 2);
            Point b = new Point(3, 6);
            Point c = new Point(2, 7);

            // act
            Triangle test = new Triangle(a, b, c);
            var actual = test.Distance(a, b) > 0 && test.Distance(b, c) > 0 && test.Distance(c, a) > 0;
            
            //assert
            Assert.IsTrue(actual);
        }
    }
}