using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TriangleSolver;

namespace TriangleSolverUnitTest
{
    [TestFixture]
    public class TriangleSolverTests
    {
        [Test]

        public void ValidTriangle_Input_7and10and5_OutputScaleneTriange() {
            //Arrange
            int side1 = 7;
            int side2 = 10;
            int side3 = 5;

            String expected = "A scalene triangle is formed";

            //Act
            String actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));

        }
    }
}
