using System;
using System.Collections.Generic;
using System.Linq;

public class CWTask
{
    public static void Main()
    {
        Console.WriteLine(Kata.OpenOrSenior(new[] { new[] { 45, 12 }, new[] { 55, 21 }, new[] { 19, 2 }, new[] { 104, 20 } }));
    }
}
public class Kata
{
    public static IEnumerable<string> OpenOrSenior(int[][] data)
    {
        IEnumerable<string> status = new string[] { };

        for (int i = 0; i < data.Length; i++)
        {
            bool statusAge = false;
            bool statusHandicap = false;
            for (int j = 0; j < data[i].Length; j++)
            {
                if ( j == 0)
                {
                    if ((data[i][j] >= 55))
                    {
                        statusAge = true;
                    }
                    else statusAge = false;
                }
                else if (j == 1)
                {
                    if ((data[i][j] <= 26) && (data[i][j] >= -2))
                    {
                        if ((data[i][j] > 7))
                        {
                            statusHandicap = true;
                        }
                        else statusHandicap = false;
                    }
                    else return new string[] { };
                }
                else return new string[] { };
     
            }

            if (statusAge == true && statusHandicap == true)
            {
                status = status.Concat(new[] { "Senior" });
            }
            else if (statusAge == false || statusHandicap == false)
            {
                status = status.Concat(new[] { "Open" });
            }
        }
        return status;
    }
}