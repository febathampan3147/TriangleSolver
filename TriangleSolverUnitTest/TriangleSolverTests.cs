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

        /**Equilateral Triange Test
         * One test for a valid equilateral triangle
         * **/

        [Test]
        public void AnalyzeTriangle_Input6_OutputEquilateralTriangle()
        {
            //Arrange
            int side1 = 6; // All 3 sides equal in an equilateral triangle

            //Act
            String actual = Triangle.AnalyzeTriangle(side1, side1, side1);

            //Assert
            Assert.That(actual, Is.EqualTo(equilateralTriangleMessage));

        }

        /**Isosceles Triangle Test
         *Three (3) tests for a valid isosceles triangle
         * **/

        [Test]
        public void AnalyzeTriangle_Input7and7and4_OutputIsoscelesTriangle()
        {
            //Arrange
            int side1 = 7;
            int side2 = 7;
            int side3 = 4;
            //expected message : "An isosceles triangle is formed";

            //Act
            String actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            //Assert
            Assert.That(actual, Is.EqualTo(isoscelesTriangleMessage));
        }

        [Test]
        public void AnalyzeTriangle_Input8and8and5_OutputIsoscelesTriangle()
        {
            //Arrange
            int side1 = 8;
            int side2 = 8;
            int side3 = 5;
            //expected message : "An isosceles triangle is formed";

            //Act
            String actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            //Assert
            Assert.That(actual, Is.EqualTo(isoscelesTriangleMessage));
        }

        [Test]
        public void AnalyzeTriangle_Input20and20and14_OutputIsoscelesTriangle()
        {
            //Arrange
            int side1 = 20;
            int side2 = 20;
            int side3 = 14;
            //expected message : "An isosceles triangle is formed";

            //Act
            String actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            //Assert
            Assert.That(actual, Is.EqualTo(isoscelesTriangleMessage));
        }

        /**Scalene Triangle Test
         *Five tests for a valid scalene triangle
         ***/

        [Test]
        public void AnalyzeTriangle_Input7and10and5_OutputScaleneTriangle() {
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

        [Test]
        public void AnalyzeTriangle_Input12and15and17_OutputScaleneTriangle()
        {
            //Arrange
            int side1 = 12;
            int side2 = 15;
            int side3 = 17;
            //expected message : "A scalene triangle is formed";

            //Act
            String actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            //Assert
            Assert.That(actual, Is.EqualTo(scaleneTriangleMessage));
        }

        [Test]
        public void AnalyzeTriangle_Input11and16and20_OutputScaleneTriangle()
        {
            //Arrange
            int side1 = 11;
            int side2 = 16;
            int side3 = 20;
            //expected message : "A scalene triangle is formed";

            //Act
            String actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            //Assert
            Assert.That(actual, Is.EqualTo(scaleneTriangleMessage));
        }

        [Test]
        public void AnalyzeTriangle_Input18and24and30_OutputScaleneTriangle()
        {
            //Arrange
            int side1 = 18;
            int side2 = 24;
            int side3 = 30;
            //expected message : "A scalene triangle is formed";

            //Act
            String actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            //Assert
            Assert.That(actual, Is.EqualTo(scaleneTriangleMessage));
        }

        [Test]
        public void AnalyzeTriangle_Input27and36and45_OutputScaleneTriangle()
        {
            //Arrange
            int side1 = 12;
            int side2 = 15;
            int side3 = 17;
            //expected message : "A scalene triangle is formed";

            //Act
            String actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            //Assert
            Assert.That(actual, Is.EqualTo(scaleneTriangleMessage));
        }

        /** Zero length tests
         * Three tests for verifying a zero length for one or more sides
         **/
        [Test]
        public void AnalyzeTriangle_Input0and3and5_OutputInvalidTriangle()
        {
            //Arrange
            int side1 = 0;
            int side2 = 3;
            int side3 = 5;
            //expected message : "At least one side entered had a zero - invalid triangle";

            //Act
            String actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            //Assert
            Assert.That(actual, Is.EqualTo(invalidTriangleMessage));
        }

        [Test]
        public void AnalyzeTriangle_Input0and0and5_OutputInvalidTriangle()
        {
            //Arrange
            int side1 = 0;
            int side2 = 0;
            int side3 = 5;
            //expected message : "At least one side entered had a zero - invalid triangle";

            //Act
            String actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            //Assert
            Assert.That(actual, Is.EqualTo(invalidTriangleMessage));
        }

        [Test]
        public void AnalyzeTriangle_Input0and0and0_OutputInvalidTriangle()
        {
            //Arrange
            int side1 = 0;
            int side2 = 0;
            int side3 = 0;
            //expected message : "At least one side entered had a zero - invalid triangle";

            //Act
            String actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            //Assert
            Assert.That(actual, Is.EqualTo(invalidTriangleMessage));
        }

        /** Invalid response tests
        * Three (3) tests for verifying an invalid response 
        **/
        [Test]
        public void AnalyzeTriangle_Input3and1and1_OutputNotTriangle()
        {
            //Arrange
            int side1 = 3;
            int side2 = 1;
            int side3 = 1;
            //expected message : "At least one side entered had a zero - invalid triangle";

            //Act
            String actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            //Assert
            Assert.That(actual, Is.EqualTo(triangleNotFormedMessage));
        }
        [Test]
        public void AnalyzeTriangle_Input3andminus1and1_OutputNotTriangle()
        {
            //Arrange
            int side1 = 3;
            int side2 = -1;
            int side3 = 1;
            //expected message : "At least one side entered had a zero - invalid triangle";

            //Act
            String actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            //Assert
            Assert.That(actual, Is.EqualTo(triangleNotFormedMessage));
        }
        [Test]
        public void AnalyzeTriangle_Input30and10and1_OutputNotTriangle()
        {
            //Arrange
            int side1 = 30;
            int side2 = 10;
            int side3 = 1;
            //expected message : "At least one side entered had a zero - invalid triangle";

            //Act
            String actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            //Assert
            Assert.That(actual, Is.EqualTo(triangleNotFormedMessage));
        }
    }
}
