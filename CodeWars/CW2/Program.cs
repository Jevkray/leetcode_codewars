public class Codewars1
{
    public static void Main()
    {
        Console.WriteLine(Kata.Maskify("asdsfadgfhsgbvcncxbg354etra"));
    }

    public static class Kata
    {
        public static string Maskify(string cc)
        {
            for (int i = 0; i < cc.Length - 4; i++)
            {
                cc = cc.Remove(i, 1).Insert(i, "#");
            }
            return cc;
        }
    }

}

/*public static class Kata
{
  // return masked string
  public static string Maskify(string cc)
  {
    if (cc.Length < 4)
    return cc;
    else return cc.Substring(cc.Length-4).PadLeft(cc.Length, '#');
  }
}*/