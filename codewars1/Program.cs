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
            string v = str.Trim(new char[] { 'A', 'E', 'I', 'O', 'U', 'a', 'i', 'o', 'u' });
            return v;
        }
    }

}

