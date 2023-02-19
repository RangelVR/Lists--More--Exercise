using System.Reflection;

int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

string text = Console.ReadLine();

int counter = 0;
string message = string.Empty;

for (int i = 0; i < numbers.Length; i++)
{
	int currNum = numbers[i];
    int index = 0;

    while (currNum > 0)
	{
		index += currNum % 10;
		currNum /= 10;
	}

	if (index >= text.Length)
	{
		index %= text.Length;
	}

	message += text[index + counter];
	counter++;
}

Console.WriteLine(message);

-----------------------------------------------------------------------
//using System.Reflection;

//int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

//List<char> text = Console.ReadLine().ToCharArray().ToList();

//string message = string.Empty;

//for (int i = 0; i < numbers.Length; i++)
//{
//	int currNum = numbers[i];
//    int index = 0;

//    while (currNum > 0)
//	{
//		index += currNum % 10;
//		currNum /= 10;
//	}

//	if (index >= text.Count)
//	{
//		index %= text.Count;
//	}

//	message += text[index];
//	text.RemoveAt(index);
//}

//Console.WriteLine(message);	
