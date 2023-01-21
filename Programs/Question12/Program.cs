Console.WriteLine("Enter 3 passengers names:");
string[] passengers = new string[6];

for(int i = 0;i < 3; i++)
{
    passengers[i] = Console.ReadLine();
}

Console.WriteLine("Enter 3 destination:");
string[] destination = new string[3];

for (int i = 0; i < 3; i++)
{
    destination[i] = Console.ReadLine();
}

Console.WriteLine("....................Merging into passenger Array...........................");

int j = 3;

for (int i = 0;i < 3; i++)
{
    passengers[j] = destination[i];
    j++;
}
Console.WriteLine("Array after merging: ");

foreach (var item in passengers)
{
    Console.WriteLine(item);
}