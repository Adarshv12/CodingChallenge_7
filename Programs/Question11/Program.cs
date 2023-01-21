while (true)
{
    Console.WriteLine("Enter a Character F or W or Q or N or A");
    char option = char.Parse(Console.ReadLine()!);

    switch (option)
    {
        case 'F':
            Console.WriteLine("Odd Flight numbers");
            for (int i = 100; i <= 110; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(String.Join("F", i));
                }
            }
            break;
        case 'W':
            Console.WriteLine("Even Flight numbers");
            for (int i = 100; i <= 110; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(String.Join("W", i));
                }
            }
            break;
        case 'Q':
            int flag = 0;
            Console.WriteLine("Prime Flight numbers:");
            for (int i = 100; i <= 150; i++)
            {
                flag = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        flag++;
                    }
                }
                if (flag == 0)
                {
                    Console.WriteLine("Q"+i);
                }
            }
            break;
        case 'N':
            Console.WriteLine("Fibonacci Flight numbers");
            int n1 = 0;
            int n2 = 1;
            int n3 = 0;
            Console.WriteLine("N"+n1);
            Console.WriteLine("N"+n2);
            for (int i = 2; i <= 1; i++)
            {
                n3 = n1 + n2;
                Console.WriteLine("N"+n3);
                n1 = n2;
                n2 = n3;
            }
            break;
        case 'A':
            for (int i = 100; i < 900; i++)
            {
                int temp = i;
                int res = 0;
                int rem = 0;
                while (temp != 0)
                {
                    rem = temp % 10;
                    res = res + (rem * rem * rem);
                    temp = temp / 10;
                }
                if (res == i)
                {
                    Console.WriteLine("A"+i);
                }
            }
            break;
        default:
            Console.WriteLine("Invalid option");
            break;
    }
}