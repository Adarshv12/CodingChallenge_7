Console.WriteLine("Enter the overweight of 5 boarding passes");
int[] weights = new int[5];

for (int i = 0; i < 5; i++)
{
    weights[i] = int.Parse(Console.ReadLine());
}

int sum = 0;
int[] prices = new int[5];
for(int i = 0;i < 5;i++)
{
    prices[i] = weights[i] * 15;
    sum += prices[i];
}

Console.WriteLine("..................Extra charges for additional weights...................\n");


Array.Reverse(prices);
foreach (var item in prices)
{
    Console.WriteLine("$"+item);
}
Console.WriteLine($"Total amount = ${sum}");