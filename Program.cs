using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L21_largestElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int minNumber = 0;
            int maxNumber = 100;
            int stub = 0;
            int[,] mainMatrix = new int[10, 10];
            int largestNumber = minNumber;

            Console.WriteLine("Исходная матрица:");

            for (int i = 0; i < mainMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < mainMatrix.GetLength(1); j++)
                {
                    mainMatrix[i, j] = random.Next(minNumber, maxNumber);
                    Console.Write(mainMatrix[i, j] + " ");

                    if (mainMatrix[i, j] > largestNumber)
                        largestNumber = mainMatrix[i, j];
                }

                Console.WriteLine();
            }

            Console.WriteLine("\nПолученная матрица:");

            for (int i = 0; i < mainMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < mainMatrix.GetLength(1); j++)
                {
                    if (mainMatrix[i, j] == largestNumber)
                        mainMatrix[i, j] = stub;

                    Console.Write(mainMatrix[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine($"\nНаибольший элемент: {largestNumber}");
        }
    }
}
