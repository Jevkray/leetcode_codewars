public class Codewars1
{
    public static void Main()
    {
        Console.WriteLine(Kata.Disemvowel("89128ewiqo"));
    }

    public static class Kata
    {
        public static string Disemvowel(string str)
        {
            string[] charsToRemove = new string[] { "A", "E", "I", "O", "U", "a", "e", "i", "o", "u" };
            foreach (var c in charsToRemove)
            {
                str = str.Replace(c, null);
            }
            return str;
        }
    }

}

