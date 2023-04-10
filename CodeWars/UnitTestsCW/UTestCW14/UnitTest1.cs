namespace Solution
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class SolutionTest
    {
        private static Random rnd = new Random();

        private static IEnumerable<TestCaseData> sampleTestCases
        {
            get
            {
                yield return new TestCaseData(0).Returns(false);
                yield return new TestCaseData(1).Returns(false);
                yield return new TestCaseData(2).Returns(true);
            }
        }

        [Test, TestCaseSource("sampleTestCases")]
        public bool SampleTest(int n) => Kata.IsPrime(n);

        private static IEnumerable<TestCaseData> fixedTestCases
        {
            get
            {
                yield return new TestCaseData(3).Returns(true);
                yield return new TestCaseData(4).Returns(false);
                yield return new TestCaseData(5).Returns(true);
                yield return new TestCaseData(6).Returns(false);
                yield return new TestCaseData(7).Returns(true);
                yield return new TestCaseData(8).Returns(false);
                yield return new TestCaseData(9).Returns(false);
                yield return new TestCaseData(73).Returns(true);
                yield return new TestCaseData(75).Returns(false);
                yield return new TestCaseData(5099).Returns(true);
                yield return new TestCaseData(-1).Returns(false);
                yield return new TestCaseData(-2).Returns(false);
            }
        }

        [Test, TestCaseSource("fixedTestCases")]
        public bool FixedTest(int n) => Kata.IsPrime(n);

        [Test, Description("Small random Tests")]
        public void SmallRandomTests()
        {
            const int Tests = 500;

            for (int i = 0; i < Tests; ++i)
            {
                int n = rnd.Next(1 << 15);

                bool expected = Solution.IsPrime(n);
                bool actual = Kata.IsPrime(n);

                Assert.AreEqual(expected, actual, $"Incorrect answer for n={n}");
            }
        }


        [Test, Description("Large random Tests")]
        public void LargeRandomTests()
        {
            const int Tests = 500;

            for (int i = 0; i < Tests; ++i)
            {
                int n = rnd.Next();

                bool expected = Solution.IsPrime(n);
                bool actual = Kata.IsPrime(n);

                Assert.AreEqual(expected, actual, $"Incorrect answer for n={n}");
            }
        }
    }

    public static class Solution
    {
        private static Dictionary<int, bool> primesMemo = new Dictionary<int, bool>();

        public static bool IsPrime(int n)
        {
            // Memo Check
            if (primesMemo.ContainsKey(n)) { return primesMemo[n]; }

            double sqrt = Math.Sqrt(n);
            for (double i = 2; i <= sqrt; ++i)
            {
                if (n % i == 0)
                {
                    primesMemo.Add(n, false);
                    return false;
                }
            }

            primesMemo.Add(n, n >= 2);
            return n >= 2;
        }
    }
}