namespace MatrixWalk.Tests
{
    using System;
    using HW12Refactoring;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MatrixTests
    {
        [TestMethod]
        public void ShouldCreateValidMatrixWhenValidInputParameter()
        {
            Matrix matrix = new Matrix(10);

            Assert.IsInstanceOfType(matrix, typeof(Matrix));
        }

        [TestMethod]
        public void ShouldCreateValidMatrixWhenNoInputParameter()
        {
            Matrix matrix = new Matrix();

            Assert.IsInstanceOfType(matrix, typeof(Matrix));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ShouldThrowArgumentOutOfRangeWhenInputParameterIsTooLarge()
        {
            var matrix = new Matrix(105);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ShouldThrowArgumentOutOfRangeWhenInputParameterIsZero()
        {
            var matrix = new Matrix(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ShouldThrowArgumentOutOfRangeWhenInputParameterIsNegative()
        {
            var matrix = new Matrix(-6);
        }

        [TestMethod]
        public void ShouldFillMatrixWithCorrectValuesWhenValidParameterIsPassed()
        {
            var matrix = new Matrix(5);

            matrix.FillMatrix();

            string[] expectedMatrixRows = 
            {
                "  1 13 14 15 16",
                " 12  2 21 22 17",
                " 11 22  3 20 18",
                " 10 25 24  4 19",
                "  9  8  7  6  5"
            };

            string expectedMatrixString = string.Join(Environment.NewLine + Environment.NewLine, expectedMatrixRows);

            Assert.AreEqual(expectedMatrixString, matrix.ToString());
        }
    }
}
