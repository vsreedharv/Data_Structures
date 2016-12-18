using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            Console.WriteLine("\n Enter 10 random values into the Array for Sorting:");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int key, k;
            for(int j=1; j<a.Length; j++)
            {
                key = a[j];
                k = j - 1;
                while(k>=0 && a[k]>key)
                {
                    a[k + 1] = a[k];
                    k = k - 1;
                }
                a[k + 1] = key;
            }
            Console.WriteLine("Sorted the given list using 'Insertion Sort':");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(" " + a[i]);
            }
            Console.ReadLine();
        }
    }
}
