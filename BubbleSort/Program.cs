using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                int[] a = new int[10];
                Console.WriteLine("\n Enter 10 random values into the Array for Sorting:");
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = Convert.ToInt32(Console.ReadLine());
                }
                int flag, temp;
                for (int k = 0; k < a.Length - 1; k++)
                {
                    flag = 0;
                    for (int i = 0; i < a.Length - k - 1; i++)
                    {
                        if (a[i] > a[i + 1])
                        {
                            temp = a[i];
                            a[i] = a[i + 1];
                            a[i + 1] = temp;
                            flag = 1;
                        }
                    }
                    if (flag == 0)
                        break;
                }
                Console.WriteLine("Sorted the given list using 'Bubble Sort':");
                for (int i = 0; i < a.Length; i++)
                {
                    Console.Write(" " + a[i]);
                }
                Console.ReadLine();
            }

        }
    }
}
