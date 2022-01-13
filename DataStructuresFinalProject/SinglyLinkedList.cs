using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresFinalProject
{
    public class SinglyLinkedList : IEnumerable
    {
        public SinglyLinkedListNode Head { get; set; }

        public void Push(string lesson)
        {
            var newNode = new SinglyLinkedListNode(lesson);
            newNode.Next = Head;
            Head = newNode;
        }

        public void AddLast(string lesson)
        {
            var newNode = new SinglyLinkedListNode(lesson);
            var current = Head;

            if (Head==null)
            {
                Head = newNode;
                return;
            }

            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }

        public void InsertAfter(SinglyLinkedListNode prevNode, string lesson)
        {
            if (prevNode == null)
            {
                Console.WriteLine("The given previous node" + " cannot be null");
                return;
            }

            SinglyLinkedListNode newNode = new SinglyLinkedListNode(lesson);
            newNode.Next = prevNode.Next;
            prevNode.Next = newNode;
        }


        public void PrintList()
        {
            SinglyLinkedListNode travellerNode = Head;
            while (travellerNode != null)
            {
                Console.WriteLine(travellerNode.Lesson + " ");
                travellerNode = travellerNode.Next;
            }
        }


        public void DeleteNode(string key)
        {
            SinglyLinkedListNode temp = Head;
            SinglyLinkedListNode prev = null;

            if (temp != null && temp.Lesson == key)
            {
                Head = temp.Next;
                return;
            }

            while (temp != null && temp.Lesson != key)
            {
                prev = temp;
                temp = temp.Next;
            }

            if (temp == null)
            {
                return;
            }
            prev.Next = temp.Next;
        }

        public int GetCount()
        {
            SinglyLinkedListNode temp = Head;
            int count = 0;
            while (temp != null)
            {
                count++;
                temp = temp.Next;
            }
            return count;
        }

        public bool Search(SinglyLinkedListNode head, string item)
        {
            SinglyLinkedListNode current = head;
            while (current != null)
            {
                if (current.Lesson == item)
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }
        public IEnumerator GetEnumerator()
        {
            return new SinglyLinkedListEnumerator(Head);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
