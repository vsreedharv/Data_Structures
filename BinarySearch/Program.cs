using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            Console.WriteLine("\n Enter a set of 10 values into the Array:");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
                if (i>0 && a[i] < a[i - 1])
                {
                    Console.WriteLine("Enter a number greater than: " + a[i-1]);
                    i = i - 1;
                }
            }
            Console.WriteLine("\n Enter a number to search your Array through Binary Search:");
            int x = Convert.ToInt32(Console.ReadLine());
            int n = a.Length - 1;
            int start = 0;
            int end = n - 1;
            int mid;

            while(start<=end)
            {
                mid = (start + end) / 2;
                if (a[mid] == x)
                {
                    Console.WriteLine("Found the number through Binary search at index: " + mid);
                    break;
                }
                else if (x < a[mid])
                {
                    end = mid - 1;
                }
                else
                    start = mid + 1;
            }
            Console.ReadLine();

        }
    }
}
