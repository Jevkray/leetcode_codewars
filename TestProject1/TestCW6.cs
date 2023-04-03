namespace TestCW6
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
            string[] a1 = new string[] { "cod", "code", "wars", "ewar" };
            string[] a2 = new string[] { "lively", "alive", "harp", "sharp", "armstrong", "codewars" };
            string[] r = new string[] { "cod", "code", "ewar", "wars" };
            Assert.AreEqual(r, WhichAreIn.inArray(a1, a2));
        }
        [Test]
        public void Test4()
        {
            string[] a1 = new string[] { "cod", "code", "wars", "ewar", "ar" };
            string[] a2 = new string[] { "lively", "alive", "harp", "sharp", "armstrong", "codewars" };
            string[] r = new string[] { "ar", "cod", "code", "ewar", "wars" };
            Assert.AreEqual(r, WhichAreIn.inArray(a1, a2));
        }
        [Test]
        public void Test5()
        {
            string[] a1 = new string[] { "cod", "code", "wars", "ewar", "ar" };
            string[] a2 = new string[] { };
            string[] r = new string[] { };
            Assert.AreEqual(r, WhichAreIn.inArray(a1, a2));
        }
        [Test]
        public void Test6()
        {
            string[] a1 = new string[] { "1295", "code", "1346", "1028", "ar" };
            string[] a2 = new string[] { "12951295", "ode", "46", "10281066", "par" };
            string[] r = new string[] { "1028", "1295", "ar" };
            Assert.AreEqual(r, WhichAreIn.inArray(a1, a2));
        }
        [Test]
        public void Test7()
        {
            string[] a1 = new string[] { "&()", "code", "1346", "1028", "ar" };
            string[] a2 = new string[] { "12&()95", "coderange", "46", "1066", "par" };
            string[] r = new string[] { "&()", "ar", "code" };
            Assert.AreEqual(r, WhichAreIn.inArray(a1, a2));
        }
        [Test]
        public void Test8()
        {
            string[] a1 = new string[] { "ohio", "code", "1346", "1028", "art" };
            string[] a2 = new string[] { "Carolina", "Ohio", "4600", "NY", "California" };
            string[] r = new string[] { };
            Assert.AreEqual(r, WhichAreIn.inArray(a1, a2));
        }
    }
}