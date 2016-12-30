using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.front = q.rear = 0;
            int will = 1;
            int num;
            try
            {
                while (will == 1 || will == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("\t Press 1 for Enter Data " + Environment.NewLine + " \t Or 2 for Delete " + Environment.NewLine + " \t Or Press Any Key to Exit");
                    Console.WriteLine();
                    will = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    switch (will)
                    {
                        case 1:
                            Console.WriteLine("\t Enter Data ");
                            num = Convert.ToInt32(Console.ReadLine());
                            q.Add(num);
                            break;
                        case 2:
                            int ab = q.Del();
                            Console.WriteLine("\t DEL Value is {0} ", ab);
                            Console.WriteLine();
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    class Queue
    {
        private const int MAXSIZE = 5;
        private int[] arr = new int[MAXSIZE];
        public int front, rear;

        public int Add(int data)
        {
            if (rear >= MAXSIZE)
            {
                Console.WriteLine("\t Queue Full");
                Console.WriteLine();
            }
            else
            {
                arr[rear] = data;
                rear++;
                Console.WriteLine();
                Console.WriteLine("\t Value of Rear is " + rear + " \n\t and Value of Front is " + front);
                Console.WriteLine();
            }
            return 1;
        }

        public int Del()
        {
            int b;
            if (front == rear)
            {
                Console.WriteLine("Queue Empty");
                Console.WriteLine();
                return 0;
            }
            else
            {
                b = arr[front];
                front++;
                Console.WriteLine("\t Value of Rear is " + rear + " \n\t and Value of Front is " + front);
                Console.WriteLine();
            }
            return b;
        }
    }

}
