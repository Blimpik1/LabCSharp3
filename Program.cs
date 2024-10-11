using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        double[,] array = {
            { 3.5, 5.2, 7.8 },
            { 1.9, 6.4, 2.3 },
            { 9.1, 4.6, 8.7 }
        };

        double maxElement = FindMaxElement(array);

        Console.WriteLine($"Найбільший елемент у масиві: {maxElement}");
    }

    static double FindMaxElement(double[,] array)
    {
        double max = array[0, 0]; 

        for (int i = 0; i < array.GetLength(0); i++) 
        {
            for (int j = 0; j < array.GetLength(1); j++) 
            {
                if (array[i, j] > max) 
                {
                    max = array[i, j];
                }
            }
        }

        return max;
    }
}
