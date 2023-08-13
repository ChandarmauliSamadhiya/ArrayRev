using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < numbers.Length / 2; i++)
            {
                int temp = numbers[i];
                numbers[i] = numbers[numbers.Length - 1 - i];
                numbers[numbers.Length - 1 - i] = temp;
            }

            Console.WriteLine("Reversed array:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.ReadLine();
        }
    }
}
