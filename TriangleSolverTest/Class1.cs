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
            //Act
            string result = TriangleSolver.Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
    public class IsoscelesTriangleTest {
        
        ///	Three (3) tests for a valid isosceles triangle
        [Test]
        public void AnalyzeTriangle_Input30and30and40_ReturnsIsoscelesTriangle_sideA() {
            //Arrange
            int sideA = 40;
            int sideB = 30;
            int sideC = 30;
            string expectedResult = "Isosceles triangle";
            //Act
            string result = TriangleSolver.Triangle.AnalyzeTriangle(sideA, sideB, sideC);
            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [Test]
        public void AnalyzeTriangle_Input30and40and30_ReturnsIsoscelesTriangle_sideB() {
            //Arrange
            int sideA = 30;
            int sideB = 40;
            int sideC = 30;
            string expectedResult = "Isosceles triangle";
            //Act
            string result = TriangleSolver.Triangle.AnalyzeTriangle(sideA, sideB, sideC);
            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [Test]
        public void AnalyzeTriangle_Input40and30and30_ReturnsIsoscelesTriangle_sideC() {
            //Arrange
            int sideA = 30;
            int sideB = 30;
            int sideC = 40;
            string expectedResult = "Isosceles triangle";
            //Act
            string result = TriangleSolver.Triangle.AnalyzeTriangle(sideA, sideB, sideC);
            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }


}
