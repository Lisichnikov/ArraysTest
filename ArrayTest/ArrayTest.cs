using Arrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ArrayTest
{
    [TestClass]
    public class ArrayTest
    {
        [TestMethod]
        public void Test_SumLine_ReturnsSumOfLine()
        {
            // Arrange
            int M = 3;
            int N = 4;
            int k = 2;
            int[,] A = new int[,] {
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 10, 11, 12 }
        };

            Arrayyy arrayyy = new Arrayyy();

            // Act
            int result = arrayyy.SumLine(A, M, N, k);

            // Assert
            Assert.AreEqual(26, result); // Сумма элементов второй строки: 5+6+7+8 = 26
        }

        [TestMethod]
        public void Test_SumLine_ReturnsZeroForInvalidInput()
        {
            // Arrange
            int M = 3;
            int N = 4;
            int k = 5;
            int[,] A = new int[,] {
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 10, 11, 12 }
        };

            Arrayyy arrayyy = new Arrayyy();

            // Act
            int result = arrayyy.SumLine(A, M, N, k);

            // Assert
            Assert.AreEqual(0, result); // Неправильный индекс строки: возвращает 0
        }
    }
}
