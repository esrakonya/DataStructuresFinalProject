using System.Collections;
using System.Collections.Generic;

namespace DataStructuresFinalProject
{
    internal class SinglyLinkedListEnumerator : IEnumerator
    {
        private SinglyLinkedListNode Head;
        private SinglyLinkedListNode _current;

        public SinglyLinkedListEnumerator(SinglyLinkedListNode head)
        {
            Head = head;
            _current = null;
        }

        public string Current => _current.Lesson;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            Head = null;
        }

        public bool MoveNext()
        {
            if (_current==null)
            {
                _current = Head;
                return true;
            }
            else
            {
                _current = _current.Next;
                return _current != null ? true : false;
            }
        }

        public void Reset()
        {
            _current = null;
        }
    }
}