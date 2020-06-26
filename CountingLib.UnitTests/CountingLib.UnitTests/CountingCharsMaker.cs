using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace CountingLib.UnitTests
{
    [TestFixture]
    public class CountingCharsMaker
    {
        [Test]
        public void Count_InputWordWorld_ReturnsIntegerResultEquals5()
        {
            // Arrange
            string testWord = "world";
            CharCounter charCounter = new CharCounter();

            // Action
            int result = charCounter.GetCountOfChars(testWord);

            // Assert
            Assert.AreEqual(result, 5);
        }
    }
}
