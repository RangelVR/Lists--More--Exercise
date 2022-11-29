using System;
using System.Linq;

namespace _02._Car_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] raceTrack = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double leftTime = 0;
            double rightTime = 0;
            int finish = raceTrack.Length / 2;

            for (int left = 0; left < finish; left++)
            {
                if (raceTrack[left] == 0)
                {
                    leftTime *= 0.8;
                }
                leftTime += raceTrack[left];
            }

            for (int right = raceTrack.Length - 1; right > finish; right--)
            {
                if (raceTrack[right] == 0)
                {
                    rightTime *= 0.8;
                }
                rightTime += raceTrack[right];
            }

            if (leftTime < rightTime)
            {
                Console.WriteLine($"The winner is left with total time: {Math.Round(leftTime,1)}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {rightTime}");
            }

        }
    }
}
