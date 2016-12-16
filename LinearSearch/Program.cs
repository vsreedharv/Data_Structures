using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            Console.WriteLine("\n Enter a set of 10 values into the Array:");
            for(int i=0; i<a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n Enter a number to search your Array through Linear Search:");
            int x= Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == x)
                {
                    Console.WriteLine("\n Liniear Search is performed and we found the number at index:" + i);
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
