// See https://aka.ms/new-console-template for more information

//1.Accept 10 passenger names in an array
using System;
using System.Linq;


int n = 10;
string?[] passengerName = new string[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Enter the passenger Name");
    passengerName[i] = Console.ReadLine();
}

Console.WriteLine();

//Print alphabetic order
Array.Sort(passengerName);
Console.WriteLine("Names in Alphabetic Order");
foreach (var name in passengerName)
{
    Console.WriteLine(name);
}

Console.WriteLine();

//Print reverse order
Array.Sort(passengerName);
Array.Reverse(passengerName);
Console.WriteLine("Names in Reverse Order");
foreach (var name in passengerName)
{
    Console.WriteLine(name + " ");
}

Console.WriteLine();

//Input a name and search in array and display
Console.Write("Enter Search Element: ");
String? searchName = Console.ReadLine();

var result = Array.Find(passengerName, e => e == searchName);
if (result != null)
{
    Console.WriteLine(result);
}
else
    Console.WriteLine("not found");

//Print the length of names in each element
foreach (var name in passengerName)
{
    if (name != null)
    {
        Console.Write("length of " + name + " is ");
        Console.WriteLine(name.Length);
    }

}

Console.WriteLine();

//Split the names at space and print for each element

foreach (var name in passengerName)
{
    if (name != null)
    {
        Console.WriteLine("Full Name: " + name);
        var splits = name.Split(' ');
        if (splits.Length == 2)
        {
            Console.WriteLine($"First Name: {splits[0]}");
            Console.WriteLine($"Last Name: {splits[1]}");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine($"First Name: {splits[0]}");
            Console.WriteLine();
        }
    }
}

Console.WriteLine();

//Print duplicate entries
int count = 0;
string duplicate = "No duplicates found";
for (int i = 0; i < passengerName.Length; i++)
{
    for (int k = i + 1; k < passengerName.Length; k++)
    {
        if (passengerName[i] == passengerName[k])
        {
            count++;
            Console.WriteLine("Duplicate Found");
            Console.WriteLine(passengerName[i]);
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





