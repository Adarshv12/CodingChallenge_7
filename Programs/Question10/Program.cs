// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter 10 Boarding pass numbers");
//int[] passNumbers = new int[10];
var passNumbers = new List<int>();

for (int i = 0; i < 10; i++)
{
    passNumbers.Add(int.Parse(Console.ReadLine()));
}

int[] counter1 = new int[3];
int[] counter2 = new int[3];
int[] counter3 = new int[3];

Random rd = new Random();
int size = 10;

for (int i = 0; i < 3; i++)
{
    int rdNo = rd.Next(0, size - 1);
    counter1[i] = passNumbers[rdNo];
    passNumbers.RemoveAt(rdNo);
    size -= 1;
}

for (int i = 0; i < 3; i++)
{
    int rdNo = rd.Next(0, size);
    counter2[i] = passNumbers[rdNo];
    passNumbers.RemoveAt(rdNo);
    size -= 1;
}

for (int i = 0; i < 3; i++)
{
    int rdNo = rd.Next(0, size);
    counter3[i] = passNumbers[rdNo];
    passNumbers.RemoveAt(rdNo);
    size -= 1;
}

Console.WriteLine("passes in counter no.1 :");
foreach (var item in counter1)
{
    Console.WriteLine(item);
}

Console.WriteLine("passes in counter no.2 :");
foreach (var item in counter2)
{
    Console.WriteLine(item);
}

Console.WriteLine("passes in counter no.3 :");
foreach (var item in counter3)
{
    Console.WriteLine(item);
}

Console.WriteLine("Enter which counter is free");
int cNo = int.Parse(Console.ReadLine());

if (cNo == 1)
{
    counter1[0] = counter1[1];
    counter1[1] = counter1[2];
    counter1[2] = passNumbers[0];
    Console.WriteLine("passes in counter no.1");
    foreach (var item in counter1)
    {
        Console.WriteLine(item);
    }
}
else if(cNo == 2)
{
    counter2[0] = counter2[1];
    counter2[1] = counter2[2];
    counter2[2] = passNumbers[0];
    Console.WriteLine("passes in counter no.2");
    foreach (var item in counter2)
    {
        Console.WriteLine(item);
    }
}
else if(cNo == 3)
{
    counter3[0] = counter3[1];
    counter3[1] = counter3[2];
    counter3[2] = passNumbers[0];
    Console.WriteLine("passes in counter no.3");
    foreach (var item in counter3)
    {
        Console.WriteLine(item);
    }
}
else
{
    Console.WriteLine("Enter valid number");
}