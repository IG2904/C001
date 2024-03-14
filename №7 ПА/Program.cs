using System;

class Program1      //числа в промежутке от M до N
{
    static void Main()
    {
        int M, N;

        Console.Write("Введите значение M: ");
        M = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите значение N: ");
        N = Convert.ToInt32(Console.ReadLine());

        PrintNumbersInRange(M, N);
    }

    static void PrintNumbersInRange(int m, int n)
    {
        if (m <= n)
        {
            Console.WriteLine(m);
            PrintNumbersInRange(m + 1, n);
        }
    }
}


class Program2      //функция Аккермана
{
    static void Main()
    {
        int m, n;

        Console.Write("Введите число m: ");
        m = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите число n: ");
        n = Convert.ToInt32(Console.ReadLine());

        int result = AckermannFunction(m, n);
        Console.WriteLine($"Значение функции Аккермана для m={m} и n={n} равно: {result}");
    }

    static int AckermannFunction(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return AckermannFunction(m - 1, 1);
        }
        else
        {
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        }
    }
}


class Program3      //элементы массива в обратном порядке
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };
        PrintArrayReversed(array, array.Length - 1);
    }

    static void PrintArrayReversed(int[] array, int index)
    {
        if (index < 0)
            return;

        Console.WriteLine(array[index]);
        PrintArrayReversed(array, index - 1);
    }
}
