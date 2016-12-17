using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
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
            int jMin, temp;
            for(int j=0; j<a.Length-1; j++ )
            {
                jMin = j;
                for(int k=j+1; k<a.Length; k++)
                {
                    if(a[k]<a[jMin])
                    {
                        jMin = k;
                    }
                }
                temp = a[j];
                a[j] = a[jMin];
                a[jMin] = temp;
            }
            Console.WriteLine("Sorted the given list using 'Selection Sort':");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(" "+a[i]);
            }
            Console.ReadLine();
        }
    }
}
