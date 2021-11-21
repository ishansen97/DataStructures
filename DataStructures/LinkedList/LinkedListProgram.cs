using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList
{
    public static class LinkedListProgram
    {
        public static void Operation()
        {
            // create items
            var item1 = new ListItem { Name = "Ishan", Age = 20 };
            var item2 = new ListItem { Name = "Pika", Age = 20 };
            var item3 = new ListItem { Name = "Janadi", Age = 20 };
            var item4 = new ListItem { Name = "Erandi", Age = 20 };
            var item5 = new ListItem { Name = "Simon Ayya", Age = 20 };

            // create linkedlist
            var linkedList = new LinkedList();

            // insert first
            linkedList.InsertFirst(item1);
            linkedList.InsertFirst(item2);
            linkedList.InsertFirst(item3);
            linkedList.InsertFirst(item4);
            linkedList.InsertFirst(item5);

            /*var removed = linkedList.RemoveFirst();
            Console.WriteLine($"Removed name: {removed.Name}");*/

            // new item
            linkedList.InsertLast(new ListItem { Name = "Manoj", Age = 24 });
            linkedList.InsertLast(new ListItem { Name = "Amashi", Age = 24 });

            // insert after
            linkedList.InsertAfter("Janadi", new ListItem { Name = "Gota", Age = 73 });

            // remove gota
            var gota = linkedList.RemoveAfter("Janadi", new ListItem { Name = "Gota", Age = 73 });
            Console.WriteLine($"Removed Gota: {gota.Name}");

            // display items
            linkedList.TraverseList();
        }
    }
}
