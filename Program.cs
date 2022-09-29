using System;

Console.WriteLine("выберите программу");
Console.WriteLine("1. угадай число");
Console.WriteLine("2. таблица умножения");
Console.WriteLine("3. вывод делителей числа");
Console.WriteLine("4. выход из программы");

int nomer = 0;
while (nomer <= 4)
{
    
    nomer = Convert.ToInt32(Console.ReadLine());
    if (nomer == 1)
    {
        Console.WriteLine("угадайте случайное число");
        Random x = new Random();
        int n = x.Next(1, 100);

        int a = 0;

        while (a != n)
        {
            a = Convert.ToInt32(Console.ReadLine());

            if (a>n)
            { Console.WriteLine("надо меньше"); }
            if (a < n)
            { Console.WriteLine("надо больше"); }
        }
        if (a == n)
        { Console.WriteLine("да, это оно "); }
        Console.WriteLine("выберете след программу");
    }
    if (nomer == 2)
    {
        int[,] arr = new int[10, 10];
        int arr1;

        for (int i = 1; i < arr.GetLength(0); ++i)
        {
            for (int j = 1; j < arr.GetLength(1); ++j)
            {

                int sum = i * j;
                if (i == j)
                {
                    arr[i, j] = sum;
                    Console.Write(arr[i, j] + "\t");
                }
                else if (i > j)
                {
                    arr[i, j] = sum;
                    Console.Write(arr[i, j] + "\t");
                }
                else if (i < j)
                {
                    arr[i, j] = sum;
                    Console.Write(arr[i, j] + "\t");
                }

            }
            Console.WriteLine("\n\n");
        }


        Console.Write("выберете след программу");
    }

    if (nomer == 3)
    {
        Console.Write("Введи число ");
        int i = Convert.ToInt32(Console.ReadLine());
        for (int a = 1; a <= i; a++)
        {
            if (i % a == 0) 
                Console.Write("{0} ", a);
        }
        Console.Write("выберете след программу");

    }

}

 