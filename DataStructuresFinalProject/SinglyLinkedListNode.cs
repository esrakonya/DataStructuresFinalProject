using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresFinalProject
{
    public class SinglyLinkedListNode
    {
        public SinglyLinkedListNode Next { get; set; }
        public string Lesson { get; set; }

        public SinglyLinkedListNode(string lesson)
        {
            Lesson = lesson;
        }
        public override string ToString()
        {
            return $"{Lesson}";

        }
    }
}
