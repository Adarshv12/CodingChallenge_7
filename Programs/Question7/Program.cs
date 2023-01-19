// See https://aka.ms/new-console-template for more information

string name = string.Empty;
double miles = 0;

Console.WriteLine("Enter the name of the passenger:");
name = Console.ReadLine();

Console.WriteLine("Enter the miles traveled:");
miles = double.Parse(Console.ReadLine());

if (miles > 10000 && miles <= 20000)
{
    Console.WriteLine("Congrats You got 10 Flyer points");
}
else if(miles > 20000 && miles <= 50000)
{
    Console.WriteLine("Congrats You got 20 Flyer points");
}
else if(miles > 50000 && miles <= 100000)
{
    Console.WriteLine("Congrats You got 30 Flyer points");
}
else if(miles > 100000)
{
    Console.WriteLine("Congrats You got 50 Flyer points");
}
else
{
    Console.WriteLine("Travel more to get flyer points");
}