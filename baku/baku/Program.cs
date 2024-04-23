using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int[] numbers = new int[100];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, 1000);
        }

        int target = 500;
        int index = LinearSearch(numbers, target);
        Console.WriteLine($"Wyszukiwanie liniowe: {target} jest na indeksie {index}");

        int sentinelIndex = SentinelSearch(numbers, target);
        Console.WriteLine($"Wyszukiwanie liniowe z wartownikiem: {target} jest na indeksie {sentinelIndex}");
    }

    static int LinearSearch(int[] numbers, int target)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == target)
            {
                return i;
            }
        }
        return -1;
    }

    static int SentinelSearch(int[] numbers, int target)
    {
        int last = numbers[numbers.Length - 1];
        numbers[numbers.Length - 1] = target;
        int i = 0;
        while (numbers[i] != target)
        {
            i++;
        }
        numbers[numbers.Length - 1] = last;
        if (i < numbers.Length - 1 || numbers[numbers.Length - 1] == target)
        {
            return i;
        }
        return -1;
    }
}
