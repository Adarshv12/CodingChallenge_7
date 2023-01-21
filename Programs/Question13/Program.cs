int n = 1;
int[] flightNo = new int[n];
while (true)
{
    Console.WriteLine("1. Add flight number to array");
    Console.WriteLine("2. View flight numbers");
    Console.WriteLine("3. Quit");
    int o = int.Parse(Console.ReadLine());

    switch (o)
    {
        case 1:
            n += 1;
            Array.Resize(ref flightNo, n);
            Console.WriteLine("flight No: ");
            flightNo[n-2] = int.Parse(Console.ReadLine());
            break;
        case 2:
            Console.WriteLine(".............Entered numbers.................................");
            foreach (var item in flightNo)
            {
                Console.WriteLine(item);
            }
            break;
        case 3:
            Environment.Exit(0);
            break;
        default: 
            Console.WriteLine("Enter valid option");
            break;
    }
}