using NUnit.Framework;
using Solution;
using System;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

namespace UNITTests
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class WhichAreInTests
    {

        [Test]
        public void Test1()
        {
            string[] a1 = new string[] { "arp", "live", "strong" };
            string[] a2 = new string[] { "lively", "alive", "harp", "sharp", "armstrong" };
            string[] r = new string[] { "arp", "live", "strong" };
            Assert.AreEqual(r, WhichAreIn.inArray(a1, a2));
        }
        [Test]
        public void Test2()
        {
            string[] a1 = new string[] { "arp", "mice", "bull" };
            string[] a2 = new string[] { "lively", "alive", "harp", "sharp", "armstrong" };
            string[] r = new string[] { "arp" };
            Assert.AreEqual(r, WhichAreIn.inArray(a1, a2));
        }
        [Test]
        public void Test3()
        {
            string[] a1 = new string[] { "cod", "code", "wars", "ewar", "ar" };
            string[] a2 = new string[] { };
            string[] r = new string[] { };
            Assert.AreEqual(r, WhichAreIn.inArray(a1, a2));
        }
        [Test]
        public void Test4()
        {
            string[] a1 = new string[] { "ohio", "code", "1346", "1028", "art" };
            string[] a2 = new string[] { "Carolina", "Ohio", "4600", "NY", "California" };
            string[] r = new string[] { };
            Assert.AreEqual(r, WhichAreIn.inArray(a1, a2));
        }
    }
}