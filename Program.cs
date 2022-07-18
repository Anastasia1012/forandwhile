using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
            // Напишите программу, которая покажет количество чётных чисел в массиве.
            Console.WriteLine("Задайте массив заполненный случайными положительными трёхзначными числами. " +
                "Напишите программу, которая покажет количество чётных чисел в массиве");
            int[] array;
            array = new int[5];
            int i = 0;
            int even = 0;
            Random random = new Random();
            while(i < array.Length)
            {
                array[i] = random.Next(100, 999);
                Console.WriteLine(array[i]);
                i++;

            }

            for (i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                    even = even + 1;

            }
            
            //for (i = 0; )
            Console.WriteLine("количество четных чисел " + even);
            Console.ReadKey();





        }
    }
}
