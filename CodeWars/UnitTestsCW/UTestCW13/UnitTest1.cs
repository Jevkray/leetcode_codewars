using System;
using NUnit.Framework;

namespace Solution
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual(new long[] { 1, 3, 2, 5, 3 }, Digitizer.Digitize(35231));
            Assert.AreEqual(new long[] { 0 }, Digitizer.Digitize(0));
        }
    }
}