namespace TestCodewars5
{ 
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
            string[] a1 = new string[] { "code", "war", "ar" };
            string[] a2 = new string[] { "lively", "alive", "harp", "ar", "war", "codesme" };
            string[] r = new string[] { "code", "war", "ar" };
            Assert.AreEqual(r, WhichAreIn.inArray(a1, a2));
        }

        [Test]
        public void Test3()
        {
            string[] a1 = new string[] { "ar", "code", "war", "lively"  };
            string[] a2 = new string[] { "lively", "alive", "harp", "ar", "war", "desme" };
            string[] r = new string[] { "ar", "war", "lively" };
            Assert.AreEqual(r, WhichAreIn.inArray(a1, a2));
        }
    }
}