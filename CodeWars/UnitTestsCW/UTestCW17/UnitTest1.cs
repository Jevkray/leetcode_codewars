using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Solution;

[TestFixture]
public class KataTest
{
    public static int Solution(string str)
    {
        str = String.Join("", str.ToLower().OrderBy(c => c));
        return Regex.Matches(str, @"(.)\1+").Count;
    }

    [Test]
    public void KataTests()
    {
        Assert.AreEqual(0, Kata.DuplicateCount(""));
        Assert.AreEqual(0, Kata.DuplicateCount("abcde"));
        Assert.AreEqual(2, Kata.DuplicateCount("aabbcde"));
        Assert.AreEqual(2, Kata.DuplicateCount("aabBcde"), "should ignore case");
        Assert.AreEqual(1, Kata.DuplicateCount("Indivisibility"));
        Assert.AreEqual(2, Kata.DuplicateCount("Indivisibilities"), "characters may not be adjacent");
    }

    [Test]
    public void RandomTests()
    {
        var random = new Random();
        string randomStr;
        for (int i = 0; i < 10; i++)
        {
            randomStr =
              String.Join("", Enumerable.Range(0, 20).Select((o, x) => (char)random.Next('a', 'z') + (char)random.Next('A', 'Z')));

            Assert.AreEqual(Solution(randomStr), Kata.DuplicateCount(randomStr));
        }
    }
}