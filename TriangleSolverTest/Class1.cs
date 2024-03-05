using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TriangleSolver;

namespace TriangleSolverTest {
    [TestFixture]
    public class EquilateralTriangleTest {

        /// Only one (1) test for a valid equilateral triangle
        [Test]
        public void AnalyzeTriangle_Input30and30and30_ReturnsEquilateralTriangle() {
            //Arrange
            int firstSide = 30;
            int secondSide = 30;
            int thirdSide = 30;
            string expectedResult = "Equilateral triangle";
            ///Logging for debug purposes
            Console.WriteLine("Input: Running Equilateral Test with sides 30, 30, 30");

            //Act
            string result = TriangleSolver.Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
            ///Logging the result
            Console.WriteLine($"Output: Expected: {expectedResult}, Actual: {result}");

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
    public class IsoscelesTriangleTest {
        
        ///	Three (3) tests for a valid isosceles triangle
        [Test]
        public void AnalyzeTriangle_Input30and30and40_ReturnsIsoscelesTriangle() {
            //Arrange
            int sideA = 40;
            int sideB = 30;
            int sideC = 30;
            string expectedResult = "Isosceles triangle";
            ///Logging for debug purposes
            Console.WriteLine("Input: Running Isosceles Test with sides 40, 30, 30");

            //Act
            string result = TriangleSolver.Triangle.AnalyzeTriangle(sideA, sideB, sideC);
            ///Logging the result
            Console.WriteLine($"Output: Expected: {expectedResult}, Actual: {result}");

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [Test]
        public void AnalyzeTriangle_Input30and40and30_ReturnsIsoscelesTriangle() {
            //Arrange
            int sideA = 30;
            int sideB = 40;
            int sideC = 30;
            string expectedResult = "Isosceles triangle";
            ///Logging for debug purposes
            Console.WriteLine("Input: Running Isosceles Test with sides 30, 40, 30");

            //Act
            string result = TriangleSolver.Triangle.AnalyzeTriangle(sideA, sideB, sideC);
            ///Logging the result
            Console.WriteLine($"Output: Expected: {expectedResult}, Actual: {result}");

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [Test]
        public void AnalyzeTriangle_Input40and30and30_ReturnsIsoscelesTriangle() {
            //Arrange
            int sideA = 30;
            int sideB = 30;
            int sideC = 40;
            string expectedResult = "Isosceles triangle";
            ///Logging for debug purposes
            Console.WriteLine("Input: Running Isosceles Test with sides 30, 30, 40");

            //Act
            string result = TriangleSolver.Triangle.AnalyzeTriangle(sideA, sideB, sideC);
            ///Logging the result
            Console.WriteLine($"Output: Expected: {expectedResult}, Actual: {result}");

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }

    public class ScaleneTriangleTest {
        ///	Five (5) tests for a valid scalene triangle

        [Test]
        public void AnalyzeTriangle_Input30and40and50_ReturnsScaleneTriangle() {
            //Arrange
            int sideA = 30;
            int sideB = 40;
            int sideC = 50;
            string expectedResult = "Scalene triangle";
            ///Logging for debug purposes
            Console.WriteLine("Input: Running Scalene Test with sides 30, 40, 50");

            //Act
            string result = TriangleSolver.Triangle.AnalyzeTriangle(sideA, sideB, sideC);
            ///Logging the result
            Console.WriteLine($"Output: Expected: {expectedResult}, Actual: {result}");

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void AnalyzeTriangle_Input40and30and50_ReturnsScaleneTriangle() {
            //Arrange
            int sideA = 40;
            int sideB = 30;
            int sideC = 50;
            string expectedResult = "Scalene triangle";
            ///Logging for debug purposes
            Console.WriteLine("Input: Running Scalene Test with sides 40, 30, 50");

            //Act
            string result = TriangleSolver.Triangle.AnalyzeTriangle(sideA, sideB, sideC);
            ///Logging the result
            Console.WriteLine($"Output: Expected: {expectedResult}, Actual: {result}");

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void AnalyzeTriangle_Input40and50and30_ReturnsScaleneTriangle() {
            //Arrange
            int sideA = 40;
            int sideB = 50;
            int sideC = 30;
            string expectedResult = "Scalene triangle";
            ///Logging for debug purposes
            Console.WriteLine("Input: Running Scalene Test with sides 40, 50, 30");

            //Act
            string result = TriangleSolver.Triangle.AnalyzeTriangle(sideA, sideB, sideC);
            ///Logging the result
            Console.WriteLine($"Output: Expected: {expectedResult}, Actual: {result}");

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void AnalyzeTriangle_Input50and30and40_ReturnsScaleneTriangle() {
            //Arrange
            int sideA = 50;
            int sideB = 30;
            int sideC = 40;
            string expectedResult = "Scalene triangle";
            ///Logging for debug purposes
            Console.WriteLine("Input: Running Scalene Test with sides 50, 30, 40");

            //Act
            string result = TriangleSolver.Triangle.AnalyzeTriangle(sideA, sideB, sideC);
            ///Logging the result
            Console.WriteLine($"Output: Expected: {expectedResult}, Actual: {result}");

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void AnalyzeTriangle_Input50and40and30_ReturnsScaleneTriangle() {
            //Arrange
            int sideA = 50;
            int sideB = 40;
            int sideC = 30;
            string expectedResult = "Scalene triangle";
            ///Logging for debug purposes
            Console.WriteLine("Input: Running Scalene Test with sides 50, 40, 30");

            //Act
            string result = TriangleSolver.Triangle.AnalyzeTriangle(sideA, sideB, sideC);
            ///Logging the result
            Console.WriteLine($"Output: Expected: {expectedResult}, Actual: {result}");

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
    public class ZeroSideTriangleTest {
        ///	Three (3) tests for verifying a zero length for one or more sides

        [Test]
        public void AnalyzeTriangle_Input0and30and30_ReturnsInvalidTriangle() {
            //Arrange
            int sideA = 0;
            int sideB = 30;
            int sideC = 30;
            string expectedResult = "Invalid Triangle - a zero has been detected";
            ///Logging for debug purposes
            Console.WriteLine("Input: Running Zero Side Test with sides 0, 30, 30");

            //Act
            string result = TriangleSolver.Triangle.AnalyzeTriangle(sideA, sideB, sideC);
            ///Logging the result
            Console.WriteLine($"Output: Expected: {expectedResult}, Actual: {result}");

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void AnalyzeTriangle_Input30and0and30_ReturnsInvalidTriangle() {
            //Arrange
            int sideA = 30;
            int sideB = 0;
            int sideC = 30;
            string expectedResult = "Invalid Triangle - a zero has been detected";
            ///Logging for debug purposes
            Console.WriteLine("Input: Running Zero Side Test with sides 30, 0, 30");

            //Act
            string result = TriangleSolver.Triangle.AnalyzeTriangle(sideA, sideB, sideC);
            ///Logging the result
            Console.WriteLine($"Output: Expected: {expectedResult}, Actual: {result}");

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void AnalyzeTriangle_Input30and30and0_ReturnsInvalidTriangle() {
            //Arrange
            int sideA = 30;
            int sideB = 30;
            int sideC = 0;
            string expectedResult = "Invalid Triangle - a zero has been detected";
            ///Logging for debug purposes
            Console.WriteLine("Input: Running Zero Side Test with sides 30, 30, 0");

            //Act
            string result = TriangleSolver.Triangle.AnalyzeTriangle(sideA, sideB, sideC);
            ///Logging the result
            Console.WriteLine($"Output: Expected: {expectedResult}, Actual: {result}");

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }

    public class InvalidTriangleTest {
        ///	Three (3) tests for verifying an invalid response (other than a zero length)

        [Test]
        public void AnalyzeTriangle_Input10and20and30_ReturnsInvalidTriangle() {
            //Arrange
            int sideA = 10;
            int sideB = 20;
            int sideC = 30;
            string expectedResult = "INVALID!!";
            ///Logging for debug purposes
            Console.WriteLine("Input: Running Invalid Triangle Test with sides 10, 20, 30");

            //Act
            string result = TriangleSolver.Triangle.AnalyzeTriangle(sideA, sideB, sideC);
            ///Logging the result
            Console.WriteLine($"Output: Expected: {expectedResult}, Actual: {result}");

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void AnalyzeTriangle_Input20and10and30_ReturnsInvalidTriangle() {
            //Arrange
            int sideA = 20;
            int sideB = 10;
            int sideC = 30;
            string expectedResult = "INVALID!!";
            ///Logging for debug purposes
            Console.WriteLine("Input: Running Invalid Triangle Test with sides 20, 10, 30");

            //Act
            string result = TriangleSolver.Triangle.AnalyzeTriangle(sideA, sideB, sideC);
            ///Logging the result
            Console.WriteLine($"Output: Expected: {expectedResult}, Actual: {result}");

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void AnalyzeTriangle_Input20and30and10_ReturnsInvalidTriangle() {
            //Arrange
            int sideA = 20;
            int sideB = 30;
            int sideC = 10;
            string expectedResult = "INVALID!!";
            ///Logging for debug purposes
            Console.WriteLine("Input: Running Invalid Triangle Test with sides 20, 30, 10");

            //Act
            string result = TriangleSolver.Triangle.AnalyzeTriangle(sideA, sideB, sideC);
            ///Logging the result
            Console.WriteLine($"Output: Expected: {expectedResult}, Actual: {result}");

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
