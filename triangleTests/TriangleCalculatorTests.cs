using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using triangleProblem;

namespace triangleTests
{
    [TestClass]
    public class TriangleCalculatorTests
    {
        List<int[]> _triangleRows;

        [TestInitialize]
        public void SetUp(){
            _triangleRows = new List<int[]>();
        }

        [TestMethod]
        public void EmptyTriangleShouldReturnSumOf0()
        {
            int result = TriangleCalculator.CalculateMaxSum(_triangleRows);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TriangleWithOneRowShouldReturnTheNumberInThatRow()
        {
            _triangleRows.Add(new int[] { 4 });
            int result = TriangleCalculator.CalculateMaxSum(_triangleRows);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void TriangleShouldReturnSumOf27()
        {
            _triangleRows.Add(new int[] { 5 });
            _triangleRows.Add(new int[] { 9, 6 });
            _triangleRows.Add(new int[] { 4, 6, 8 });
            _triangleRows.Add(new int[] { 0, 7, 1, 5 });
            int result = TriangleCalculator.CalculateMaxSum(_triangleRows);
            Assert.AreEqual(27, result);
        }

        [TestMethod]
        public void TriangleShouldReturnSumOf23()
        {
            _triangleRows.Add(new int[] { 5 });
            _triangleRows.Add(new int[] { 2, 6 });
            _triangleRows.Add(new int[] { 1, 2, 8 });
            _triangleRows.Add(new int[] { 0, 7, 4, 2 });
            int result = TriangleCalculator.CalculateMaxSum(_triangleRows);
            Assert.AreEqual(23, result);
        }

        [TestMethod]
        public void TriangleShouldReturnSumOf40()
        {
            _triangleRows.Add(new int[] { 5 });
            _triangleRows.Add(new int[] { 2, 6 });
            _triangleRows.Add(new int[] { 1, 2, 8 });
            _triangleRows.Add(new int[] { 0, 7, 4, 2 });
            _triangleRows.Add(new int[] { 9, 8, 6, 5, 4 });
            _triangleRows.Add(new int[] { 3, 1, 4, 5, 6, 7 });
            _triangleRows.Add(new int[] { 5, 4, 3, 2, 1, 0, 0 });
            _triangleRows.Add(new int[] { 9, 8, 7, 4, 2, 1, 1, 1 });
            int result = TriangleCalculator.CalculateMaxSum(_triangleRows);
            Assert.AreEqual(40, result);
        }
    }
}
