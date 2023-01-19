// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter no of Destinations: ");
int pSize = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the destination names: ");
string[] passengers = new string[pSize];

for(int i = 0;i < pSize; i++)
{
    passengers[i] = Console.ReadLine();
}

Console.WriteLine("Enter the fares of destination: ");
decimal[] fares = new decimal[pSize];

for (int i = 0; i < pSize; i++)
{
    fares[i] = decimal.Parse(Console.ReadLine());
}

Console.WriteLine("Enter the nth number to display the corresponding destination and fare: ");
int index = int.Parse(Console.ReadLine());

if(index > pSize)
{
    Console.WriteLine("Enter valid number");
}
else
{
    Console.WriteLine($" Destination : {passengers[index]} | Fare : {fares[index]}");
}
