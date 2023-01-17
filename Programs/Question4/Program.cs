// See https://aka.ms/new-console-template for more information

using System;

double[] fares = new double[10];
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Enter the flight fare");
    fares[i] = Convert.ToDouble(Console.ReadLine());
}

Array.Sort(fares);
Console.WriteLine("fare in asc Order");
foreach (var name in fares)
{
    Console.WriteLine(name);
}


//Print reverse order
Array.Reverse(fares);
Console.WriteLine("fare in dsc Order");
foreach (var name in fares)
{
    Console.WriteLine(name + " ");
}

Console.Write("Enter Search fare: ");
double searchName = Convert.ToDouble(Console.ReadLine());

var result = Array.Find(fares, e => e == searchName);
if (result != 0)
{
    Console.WriteLine(result);
}
else
    Console.WriteLine("not found");

Console.WriteLine("Maximum fare: " + fares[0]);
Console.WriteLine("Minimum fare: " + fares[9]);


int count = 0;
string duplicate = "No duplicates found";
for (int i = 0; i < fares.Length; i++)
{
    for (int k = i + 1; k < fares.Length; k++)
    {
        if (fares[i] == fares[k])
        {
            count++;
            Console.WriteLine("Duplicate Found");
            Console.WriteLine(fares[i]);
            duplicate = "Found Duplicates";
        }
    }
}
if (duplicate == "Found Duplicates")
{
    Console.WriteLine("No of duplicates found is " + count);
}
else
    Console.WriteLine(duplicate);