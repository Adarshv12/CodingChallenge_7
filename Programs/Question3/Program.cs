// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter year of birth: ");
int year = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter month of birth: ");
int month = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter day of birth: ");
int date = Convert.ToInt32(Console.ReadLine());

DateTime inputtedDate = new DateTime(year, month, date);

Console.WriteLine(inputtedDate);

//leap year or not
if (DateTime.IsLeapYear(inputtedDate.Year))
    Console.WriteLine("Leap year");
else
    Console.WriteLine("Not a leap year");


DateTime today = DateTime.Today;
Console.WriteLine(today);

Console.WriteLine("Your " + (today.Year - inputtedDate.Year) + " years old");
Console.WriteLine("Your " + (today.Year - inputtedDate.Year) * 12 + " months old");
Console.WriteLine("Your " + (today.Year - inputtedDate.Year) * 52 + " Weeks old");
Console.WriteLine("Your " + (today.Year - inputtedDate.Year) * 365 + " days old");
Console.WriteLine("Your " + ((today.Year - inputtedDate.Year) * 365) * 24 + " hours old");