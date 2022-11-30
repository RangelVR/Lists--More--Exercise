using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Mixed_up_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> mixList = new List<int>();
            List<int> resultList = new List<int>();

            int smoletListCount = Math.Min(list1.Count, list2.Count);
            int counter = 1;

            for (int i = 0; i < smoletListCount; i++)
            {
                mixList.Add(list1[i]);
                mixList.Add(list2[list2.Count - counter]);
                counter++;
            }

            mixList.Sort();
            if (list1.Count > list2.Count)
            {
                list1.RemoveRange(0, list1.Count - 2);
                list1.Sort();
                foreach (var num in mixList)
                {
                    if (num > list1[list1.Count - 2] && num < list1[list1.Count - 1])
                    {
                        Console.Write(num + " ");
                    }
                }
            }
            else
            {
                list2.RemoveRange(2, list2.Count - 2);
                list2.Sort();
                foreach (var num in mixList)
                {
                    if (num > list2[0] && num < list2[1])
                    {
                        Console.Write(num + " ");
                    }
                }
            }

        }
    }
}
