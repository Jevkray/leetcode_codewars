using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Dynamic;

public class CWTask
{
    public static void Main()
    {
        Console.WriteLine(ListFilterer.GetIntegersFromList(new List<object>() { 1, 2, "a", "b" }));
    }
}

public class ListFilterer
{
    public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
    {
        List<int> listOfInts = new();
        for (int i = 0; i < listOfItems.Count; i++)
        {
            if (listOfItems[i] is Int32)
            {
                listOfInts.Add(Convert.ToInt32(listOfItems[i]));
            }
        }
        return listOfInts;
    }   
}

