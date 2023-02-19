
List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> secondtList = Console.ReadLine().Split().Select(int.Parse).ToList();

List<int> mixedList = new List<int>();

int minLength = Math.Min(firstList.Count, secondtList.Count);

for (int i = 0; i < minLength; i++)
{
    mixedList.Add(firstList[i]);
    mixedList.Add(secondtList[secondtList.Count - 1 - i]);
}

if (firstList.Count > secondtList.Count)
{
    firstList.RemoveRange(0, secondtList.Count);
    secondtList.Clear();
}
else
{
    secondtList.RemoveRange(2, firstList.Count);
    firstList.Clear();
}

//for (int i = 0; i < minLength; i++)
//{
//    firstList.RemoveAt(0);
//}

//int secondListCount = secondtList.Count;

//for (int i = secondtList.Count - 1; i >= secondListCount - minLength; i--)
//{
//    secondtList.RemoveAt(i);
//}

List<int> boundraries = new List<int>();

if (firstList.Count > secondtList.Count)
{
    boundraries = firstList.OrderBy(x => x).ToList();
}
else
{
    boundraries = secondtList.OrderBy(x => x).ToList();
}

int minValue = boundraries[0];
int maxValue = boundraries[1];

List<int> resultList = mixedList
    .Where(x => x > minValue && x < maxValue)
    .OrderBy(x => x)
    .ToList();

Console.WriteLine(string.Join(" ", resultList));

---------------------------------------------------------------------------
//namespace _04._Mixed_up_Lists
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            List<int> list1 = Console.ReadLine().Split().Select(int.Parse).ToList();
//            List<int> list2 = Console.ReadLine().Split().Select(int.Parse).ToList();
//            List<int> mixList = new List<int>();
//            List<int> resultList = new List<int>();

//            int smoletListCount = Math.Min(list1.Count, list2.Count);
//            int counter = 1;

//            for (int i = 0; i < smoletListCount; i++)
//            {
//                mixList.Add(list1[i]);
//                mixList.Add(list2[list2.Count - counter]);
//                counter++;
//            }

//            mixList.Sort();
//            if (list1.Count > list2.Count)
//            {
//                list1.RemoveRange(0, list1.Count - 2);
//                list1.Sort();
//                foreach (var num in mixList)
//                {
//                    if (num > list1[list1.Count - 2] && num < list1[list1.Count - 1])
//                    {
//                        Console.Write(num + " ");
//                    }
//                }
//            }
//            else
//            {
//                list2.RemoveRange(2, list2.Count - 2);
//                list2.Sort();
//                foreach (var num in mixList)
//                {
//                    if (num > list2[0] && num < list2[1])
//                    {
//                        Console.Write(num + " ");
//                    }
//                }
//            }

//        }
//    }
//}
