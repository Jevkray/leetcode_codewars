using NUnit.Framework;
using Solution;
using System;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

public class StripCommentsTest
{

    private static Random RANDOM = new Random();

    [Test]
    public void StripComments()
    {
        Assert.AreEqual(
            "apples, pears\ngrapes\nbananas",
            StripCommentsSolution.StripComments("apples, pears # and bananas\ngrapes\nbananas !apples", new string[] { "#", "!" }));

        Assert.AreEqual(
                "a\nc\nd",
                StripCommentsSolution.StripComments("a #b\nc\nd $e f g", new string[] { "#", "$" }));
    }

    [Test]
    public void Edges()
    {
        Assert.AreEqual("a\n b\nc", StripCommentsSolution.StripComments("a \n b \nc ", new string[] { "#", "$" }));
        Assert.AreEqual("a", StripCommentsSolution.StripComments("a", new string[] { "1" }));
        Assert.AreEqual("", StripCommentsSolution.StripComments("a", new string[] { "a" }));
        Assert.AreEqual("", StripCommentsSolution.StripComments("            ", new string[] { "#" }));
        Assert.AreEqual("", StripCommentsSolution.StripComments("# some text", new string[] { "#" }));
    }

    [Test]
    public void Random()
    {
        var comments = new string[] { "#", "$", "!", "-" };
        for (int i = 0; i < 20; i++)
        {
            var test = Regex.Replace(RandomString().Replace("1", comments[RANDOM.Next(4)]).Replace("0", "\n"), "\n+$", "");
            Console.WriteLine(test);
            var exp = StripCommentsSolution.StripComments(test, comments);
            Assert.AreEqual(StripComments(test, comments), exp);
        }
    }

    private static string RandomString()
    {
        var max = BigInteger.Pow(2, 1000);
        var rnd = RandomIntegerBelow(max);
        return Regex.Replace(rnd.ToString("X"), "[2-9]+", "\n\n");
    }

    private static BigInteger RandomIntegerBelow(BigInteger N)
    {
        byte[] bytes = N.ToByteArray();
        BigInteger R;
        Random rnd = new Random();
        do
        {
            rnd.NextBytes(bytes);
            bytes[bytes.Length - 1] &= 0x7F; //force sign bit to positive
            R = new BigInteger(bytes);
        } while (R >= N);

        return R;
    }

    private static string StripComments(string text, string[] commentSymbols)
    {
        var pattern = $"[ ]*([{string.Concat(commentSymbols)}].*)?$";
        return string.Join("\n", text.Split('\n').Select(x => Regex.Replace(x, pattern, "")));
    }
}