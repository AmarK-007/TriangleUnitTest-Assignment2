using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TriangleSolver;

namespace TriangleSolverTest
{
    [TestFixture]
    public class EquilateralTriangleTest {
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
    
}
