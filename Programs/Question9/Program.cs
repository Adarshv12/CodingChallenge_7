// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter 10 date of birth in DD-MM-YYYY : ");
DateTime[] dob = new DateTime[10];

for (int i = 0; i < 10; i++)
{
    dob[i] = DateTime.Parse(Console.ReadLine());
}


DateTime today = DateTime.Now;
foreach (var dt in dob)
{
    if((today.Year - dt.Year) <= 10)
    {
        Console.WriteLine("Kid");
    }
    else if((today.Year - dt.Year) > 10 && (today.Year - dt.Year) <= 30)
    {
        Console.WriteLine("Youth");
    }
    else if((today.Year - dt.Year) > 30 && (today.Year - dt.Year) <= 60)
    {
        Console.WriteLine("Adult");
    }
    else
    {
        Console.WriteLine("Older");
    }
}
