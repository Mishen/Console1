using System;

namespace Консоль1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[4,2];
            int increment = 1;
            for (int index = 0; index < 4; index++)
            {
                for (int index2 = 0; index2 < 2; index2++)
                {
                    array[index, index2] = increment++;
                    Console.Write(array[index, index2]);
                }
                Console.WriteLine();
            }

        }
    }
}
