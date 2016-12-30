using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseLinkedList
{
class Program
    {
        static void Main(string[] args)
        {
            LinkItem item = generateLinkList(5);
            printLinkList(item);
            Console.WriteLine("\n REVERSE LINKED LIST...\n ");
            LinkItem newItem = reverseLinkList(item);
            printLinkList(newItem);
            Console.ReadLine();
        }

        static public LinkItem generateLinkList(int total)
        {
            LinkItem item = new LinkItem();
            for (int number = total; number >= 1; number--)
            {
                item = new LinkItem
                {
                    name = string.Format("LINK ITEM NUMBER {0}.", number),
                    next = (number == total) ? null : item
                };
            }
            return item;
        }

        static public void printLinkList(LinkItem item)
        {
            while (item != null)
            {
                Console.WriteLine(item.name);
                item = item.next;
            }
        }

        static public LinkItem reverseLinkList(LinkItem item)
        {
            LinkItem newItem = new LinkItem
            {
                name = item.name,
                next = null
            };

            while (item.next != null)
            {
                newItem = new LinkItem
                {
                    name = item.next.name,
                    next = newItem
                };

                item = item.next;
            }

            return newItem;
        }
    }
}
