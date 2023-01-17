Console.WriteLine("Enter no of odd numbers");
int odd = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter no of even numbers");
int even = Convert.ToInt32(Console.ReadLine());
int n = odd+even;

odd = 0;
even = 1;
double fare = 0;


double[] fares = new double[n];
Console.WriteLine("Enter the fares :");
for (int i = 0;i < n; i++)
{
    fare = Convert.ToDouble(Console.ReadLine());
    if (fare % 2 == 0)
    {
        fares[even] = fare;
        even += 2;
    }
    else
    {
        fares[odd] = fare;
        odd += 2;
    }
    

}

Console.WriteLine("Entered fares are");
foreach(int i in fares)
{
    Console.WriteLine(i);
}