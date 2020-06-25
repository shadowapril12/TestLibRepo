using System;

using CountingLib;
using NUnit.Framework;

namespace CountingLib.UnitTests
{
    [TestFixture]
    public class SumMakerTests
    {
        [Test]
        public void Sum_Arg1Equal4Arg2Equal5_ReturnsIntegerResultEquals9()
        {
            // Arrange
            SumMaker sumMaker = new SumMaker();

            // Act
            int res = sumMaker.Sum(4, 5);

            // Assert
            Assert.AreEqual(9, res);
        }
    }
}
