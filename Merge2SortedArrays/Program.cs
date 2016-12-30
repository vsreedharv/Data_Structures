using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge2SortedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] first = new int[10];
            Console.WriteLine("\n Enter 10 values in Ascending Order into the First Array:");
            for (int x = 0; x < first.Length; x++)
            {
                first[x] = Convert.ToInt32(Console.ReadLine());
                if (x > 0 && first[x] < first[x - 1])
                {
                    Console.WriteLine("Enter a number greater than: " + first[x - 1]);
                    x = x - 1;
                }
            }
            Console.WriteLine("\n Enter 10 values in Ascending Order into the Second Array:");
            int[] second = new int[10];
            for (int y = 0; y < first.Length; y++)
            {
                second[y] = Convert.ToInt32(Console.ReadLine());
                if (y > 0 && second[y] < second[y - 1])
                {
                    Console.WriteLine("Enter a number greater than: " + second[y - 1]);
                    y = y - 1;
                }
            }

            int count1 = first.Length;
            int count2 = second.Length;
            int[] arrayResult = new int[count1 + count2];

            int a = 0, b = 0;
            int i = 0;


            while (a < count1 && b < count2)
            {
                if (first[a] <= second[b])
                {
                    arrayResult[i++] = first[a++];
                }
                else
                {
                    arrayResult[i++] = second[b++];
                }
            }
            if (a < count1)
            {
                for (int j = a; j < count1; j++)
                {
                    arrayResult[i++] = first[j];
                }
            }
            else
            {
                for (int j = b; j < count2; j++)
                {
                    arrayResult[i++] = second[j];
                }
            }
            Console.WriteLine("Result is {{ {0} }}", string.Join(",", arrayResult.Select(e => e.ToString())));
            Console.ReadLine();
        }
    }
}
