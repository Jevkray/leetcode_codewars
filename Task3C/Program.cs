public class Codewars1
{
    public static void Main()
    {
        Console.WriteLine(Kata.IsPangram("A pangram is a sentence that contains every single letter of the alphabet at least once.  "));
    }


    public static class Kata
    {
        public static bool IsPangram(string str)
        {
            char[] charArray = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            List<char> list = new List<char>(charArray);
            var strLower = str.ToLower();
            foreach (char c in strLower)
            {
                if (list.Contains(c))
                {
                    list.Remove(c);
                    strLower = strLower.Replace(c.ToString(), "");
                }
            }
            if (list.Count == 0)
            {
                return true;
            }
            else return false;
        }
    }

}