//namespace Solution
//{
//    public class CWTask
//    {
//        public static void Main()
//        {
//            Console.WriteLine(StripCommentsSolution.StripComments("apples, pears # and bananas\ngrapes\nbananas !apples", new string[] { "#", "!" }));
//        }
//    }

//    public static class StripCommentsSolution
//    {
//        public static string StripComments(string text, string[] commentSymbols)
//        {
//            int indexOfSubstr = -2;
//            string[] substr = new string[] { };
//            string textCopy = text;
//            while (indexOfSubstr != 0)
//            {
//                indexOfSubstr = textCopy.IndexOf("\n") + 1;

//                Array.Resize(ref substr, substr.Length + 1);
//                substr[substr.Length - 1] = textCopy.Substring(indexOfSubstr, textCopy.Length - indexOfSubstr);
//                int indexOfSubSub = substr[substr.Length - 1].IndexOf("\n");
//                if (indexOfSubSub >= 0)
//                {
//                    substr[substr.Length - 1] = "\n" + substr[substr.Length - 1].Substring(0, indexOfSubSub);
//                }
//                else
//                {
//                    substr[substr.Length - 1] = "\n" + substr[substr.Length - 1].Substring(0, indexOfSubSub + substr[substr.Length - 1].Length + 1);
//                    break;
//                }
//                textCopy = textCopy.Substring(indexOfSubstr, textCopy.Length - indexOfSubstr);
//                indexOfSubstr = textCopy.IndexOf("\n") + 1;
//            }
//            for (int i = 0; i < commentSymbols.Length; i++)
//            {
//                indexOfSubstr = text.IndexOf(commentSymbols[i]);
//                if (indexOfSubstr >= 0)
//                {
//                    text = text.Substring(0, indexOfSubstr);
//                }
//            }
//            for (int k = 0; k < substr.Length; k++)
//            {
//                text = text.Insert(text.Length - 1, substr[k]);
//            }
//            return text;
//        }
//    }
//}

namespace Solution
{
    public class CWTask
    {
        public static void Main()
        {
            Console.WriteLine(StripCommentsSolution.StripComments("1fsamdk1sdaka\n", new string[] { "1" }));
        }
    }

    public static class StripCommentsSolution
    {
        public static string StripComments(string text, string[] commentSymbols)
        {
            string[] subStr = new string[] { };
            string textCopy = text;

            int indexOfSubstr = textCopy.IndexOf("\n");

            if (text.Length <= 0 || commentSymbols.Length <= 0)
            {
                return text;
            }

            else if (indexOfSubstr == -1)
            {
                Array.Resize(ref subStr, subStr.Length + 1);
                subStr[subStr.Length - 1] = textCopy;
            }

            else
            {
                Array.Resize(ref subStr, subStr.Length + 1);
                subStr[subStr.Length - 1] = textCopy.Substring(0, indexOfSubstr);
                textCopy = textCopy.Substring(indexOfSubstr, textCopy.Length - indexOfSubstr);

                indexOfSubstr = -2;

                while (indexOfSubstr != -1)
                {

                    indexOfSubstr = textCopy.IndexOf("\n");

                    Array.Resize(ref subStr, subStr.Length + 1);
                    string subSubStr = textCopy.Substring(indexOfSubstr, textCopy.Length - indexOfSubstr).Substring(1);
                    int indexOfSubSub = subSubStr.IndexOf("\n");
                    if (indexOfSubSub >= 0)
                    {
                        subStr[subStr.Length - 1] = "\n" + subSubStr.Substring(0, indexOfSubSub);
                    }
                    else if (indexOfSubSub < 0)
                    {
                        subStr[subStr.Length - 1] = "\n" + subSubStr;
                        break;
                    }
                    textCopy = textCopy.Substring(subStr[subStr.Length - 1].Length, textCopy.Length - subStr[subStr.Length - 1].Length);
                    indexOfSubstr = textCopy.IndexOf("\n");
                }
            }

            for (int i = 0; i < subStr.Length; i++)
            {
                for (int j = 0; j < commentSymbols.Length; j++)
                {
                    indexOfSubstr = subStr[i].IndexOf(commentSymbols[j]);
                    if (indexOfSubstr >= 0)
                    {
                        subStr[i] = subStr[i].Substring(0, indexOfSubstr);
                    }
                }
            }

            text = "";

            foreach (string s in subStr)
            {
                text += s.Trim(new char[] { ' ' });
            }

            return text;
        }
    }
}