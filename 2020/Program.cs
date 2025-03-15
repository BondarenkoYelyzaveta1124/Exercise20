using System;

class Program
{
    static void Main()
    {
        Console.Write("Введiть довжину, ширину i висоту коробки 1: ");
        string[] input = Console.ReadLine().Split();
        int[] box1 = new int[3];
        for (int i = 0; i < 3; i++)
        {
            box1[i] = int.Parse(input[i]);
        }

        Console.Write("Введiть довжину, ширину i висоту коробки 2: ");
        string[] twodate = Console.ReadLine().Split();
        int[] box2 = new int[3];
        for (int i = 0; i < 3; i++)
        {
            box2[i] = int.Parse(twodate[i]);
        }

        perevirka(box1, box2);
    }
    static void sort(ref int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = 0; j < numbers.Length - 1; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    int temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                }
            }
        }
    }
    static void perevirka(int[] box1, int[] box2)
    {
        sort(ref box1);
        sort(ref box2);

        if (box1[0] < box2[0] && box1[1] < box2[1] && box1[2] < box2[2])
        {
            Console.WriteLine("Перша коробка помiщається у другу");
        }
        else if (box2[0] < box1[0] && box2[1] < box1[1] && box2[2] < box1[2])
        {
            Console.WriteLine("Друга коробка помiщається у першу");
        }
        else
        {
            Console.WriteLine("Жодна з коробок не помiщається в iншу");
        }
    }
}