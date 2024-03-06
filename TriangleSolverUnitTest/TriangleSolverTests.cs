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
        public static String equilateralTriangleMessage = "An equilateral triangle is formed";
        public static String scaleneTriangleMessage = "A scalene triangle is formed";
        public static String isoscelesTriangleMessage = "An isosceles triangle is formed";
        public static String invalidTriangleMessage = "At least one side entered had a zero - invalid triangle";
        public static String triangleNotFormedMessage = "A triangle cannot be formed";

        [Test]
        //Equilateral Triange Test
        public void AnalyzeTriangle_Input6_OutputScaleneTriange()
        {
            //Arrange
            int side1 = 6; // All 3 sides equal in an equilateral triangle

            //Act
            String actual = Triangle.AnalyzeTriangle(side1, side1, side1);

            //Assert
            Assert.That(actual, Is.EqualTo(equilateralTriangleMessage));

        }

        //Scalene Triangle Test
        [Test]
        public void AnalyzeTriangle_Input_7and10and5_OutputScaleneTriange() {
            //Arrange
            int side1 = 7;
            int side2 = 10;
            int side3 = 5;

            //expected message : "A scalene triangle is formed";

            //Act
            String actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            //Assert
            Assert.That(actual, Is.EqualTo(scaleneTriangleMessage));

        }
    }
}
