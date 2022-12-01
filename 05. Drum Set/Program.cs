using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Drum_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());
            List<int> drumSet = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> referenceList = new List<int> (drumSet);
            string command;

            while ((command = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                int power = int.Parse(command);
                for (int i = 0; i < drumSet.Count; i++)
                {
                    drumSet[i] -= power;

                    if (drumSet[i] <= 0)
                    {
                        if (savings - referenceList[i] * 3 >= 0)
                        {
                            drumSet[i] = referenceList[i];
                            savings -= referenceList[i] * 3;
                        }
                        else
                        {
                            drumSet.RemoveAt(i);
                            referenceList.RemoveAt(i);
                            if (i != drumSet.Count)
                            {
                                i--;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", drumSet));
            Console.WriteLine($"Gabsy has {savings:f2}lv.");
        }
    }
}
