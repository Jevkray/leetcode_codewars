using NUnit.Framework;
using Solution;
using System;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

[TestFixture]
public class CodeWarsTest
{
    [Test]
    public static void SimpleCase()
    {
        Assert.AreEqual(3, Kata.CountCombinations(4, new[] { 1, 2 }));
    }

    [Test]
    public static void AnotherSimpleCase()
    {
        Assert.AreEqual(4, Kata.CountCombinations(10, new[] { 5, 2, 3 }));
    }

    [Test]
    public static void NoChange()
    {
        Assert.AreEqual(0, Kata.CountCombinations(11, new[] { 5, 7 }));
    }

    [Test]
    public static void Case1022()
    {
        Assert.AreEqual(1022, Kata.CountCombinations(300, new[] { 5, 10, 20, 50, 100, 200, 500 }));
    }

    [Test]
    public static void Anther1022Case()
    {
        Assert.AreEqual(1022, Kata.CountCombinations(300, new[] { 500, 5, 50, 100, 20, 200, 10 }));
    }

    [Test]
    public static void Case0()
    {
        Assert.AreEqual(0, Kata.CountCombinations(301, new[] { 5, 10, 20, 50, 100, 200, 500 }));
    }

    [Test]
    public static void Case760()
    {
        Assert.AreEqual(760, Kata.CountCombinations(199, new[] { 3, 5, 9, 15 }));
    }

    [Test]
    public static void Case19()
    {
        Assert.AreEqual(19, Kata.CountCombinations(98, new[] { 3, 14, 8 }));
    }

    [Test]
    public static void CaseTooMany()
    {
        Assert.AreEqual(18515, Kata.CountCombinations(419, new[] { 2, 5, 10, 20, 50 }));
    }
}
