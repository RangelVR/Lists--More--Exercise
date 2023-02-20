double savings = double.Parse(Console.ReadLine());
List<int> drumSetOrigin = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> currDrumSet = new List<int>(drumSetOrigin);
string command = Console.ReadLine();

while (command != "Hit it again, Gabsy!")
{

    int hitPower = int.Parse(command);

    for (int i = 0; i < currDrumSet.Count; i++)
    {
        currDrumSet[i] -= hitPower;

        if (currDrumSet[i] <= 0)
        {
            int priceToReplace = drumSetOrigin[i] * 3;

            if (savings - priceToReplace < 0 )
            {
                currDrumSet.RemoveAt(i);
                drumSetOrigin.RemoveAt(i);
                i--;
                continue;
            }
            else
            {
                savings -= (drumSetOrigin[i] * 3);
                currDrumSet[i] = drumSetOrigin[i];
            }
        }
    }

    command = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", currDrumSet));
Console.WriteLine($"Gabsy has {savings:f2}lv.");
