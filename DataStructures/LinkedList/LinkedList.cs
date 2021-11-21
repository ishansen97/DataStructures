using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList
{
    /// <summary>
    /// Singly Linked List Implementation
    /// </summary>
    public class LinkedList
    {
        public ListItem First { get; set; }

        public LinkedList()
        {
            First = null;
        }

        #region Operations
        public void InsertFirst(ListItem item)
        {
            item.Next = First;
            First = item;
        }

        public void InsertLast(ListItem item)
        {
            var last = GetLast();
            last.Next = item;
        }

        public void InsertAfter(string name, ListItem item)
        {
            var prevNode = GetItem(name) ?? throw new ArgumentNullException("Mehema ekak na yako");

            item.Next = prevNode.Next;
            prevNode.Next = item;
        }

        public void TraverseList()
        {
            if (IsEmpty()) throw new ArgumentNullException("Mukuth na meke");
            var node = First;

            while (node != null)
            {
                Console.WriteLine($"Name: {node.Name}");
                node = node.Next;
            }
        }

        private ListItem GetLast()
        {
            if (IsEmpty()) throw new ArgumentNullException("Mukuth na meke");
            var node = First;

            while (node.Next != null)
            {
                node = node.Next;
            }

            return node;
        }

        public ListItem RemoveFirst()
        {
            if (IsEmpty()) throw new ArgumentNullException("Mukuth na meke");

            var node = First;
            First = node.Next;
            node.Next = null;

            return node;
        }

        // RemoveLast?

        public ListItem RemoveAfter(string name, ListItem item)
        {
            var prevNode = GetItem(name) ?? throw new ArgumentNullException("Mehema ekak na yako");
            var removed = prevNode.Next;
            prevNode.Next = removed.Next;
            removed.Next = null;

            return removed;
        }

        #endregion

        #region Helper methods
        public bool IsEmpty() => First == null;

        private ListItem GetItem(string name)
        {
            if (IsEmpty() || name == null) throw new ArgumentNullException("Mukuth na meke");
            var node = First;

            while (node != null)
            {
                if (node.Name == name) return node;
                node = node.Next;
            }

            return null;
        }
        #endregion
    }
}
