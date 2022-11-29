using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nums = Console.ReadLine().Split().ToList();
            List<char> text = Console.ReadLine().ToCharArray().ToList();
            string word = string.Empty;

            for (int i = 0; i < nums.Count; i++)
            {
                string @string = nums[i];
                int sum = 0;

                for (int k = 0; k < @string.Length; k++)
                {
                    int currNumber = @string[k] - 48;
                    sum += currNumber;
                }
                int index = sum;

                if (index >= text.Count)
                {
                    index -= text.Count;
                }
                word += text[index];
                text.RemoveAt(index);
            }
            Console.WriteLine(word);
        }
    }
}
