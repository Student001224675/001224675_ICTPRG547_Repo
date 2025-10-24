using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Nathan_ICTPRG547_Assignment
{

    public class SinglyLinkedListNode<T>
    {
        public T Value { get; set; }
        public SinglyLinkedListNode<T> Next { get; set; }
        public SinglyLinkedListNode(T value) 
        {
            Value = value;
        }
    }

    public class SinglyLinkedList<T> : ICollection<T>
    {
        public SinglyLinkedListNode<T> Head { get; private set; }
        public SinglyLinkedListNode<T> Tail { get; private set; }

        public int Count { get; private set; }

        public void AddFirst(T value)
        {
            AddFirst(new SinglyLinkedListNode<T>(value));
        }

        public void AddFirst(SinglyLinkedListNode<T> node)
        {
            SinglyLinkedListNode<T> temp = Head;
            Head = node;
            Head.Next = temp;
            Count++;
            if (Count == 1)
            {
                Tail = Head;
            }
        }

        public void AddLast(T value)
        {
            AddLast(new SinglyLinkedListNode<T>(value));
        }

        public void AddLast(SinglyLinkedListNode<T> node)
        {
            if (Count == 0)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
            }
            Tail = node;
            Count++;
        }

        public void RemoveFirst()
        {
            if (Count != 0)
            {
                Head = Head.Next;
                Count--;
                if (Count == 0)
                {
                    Tail = null;
                }
            }
        }

        public void RemoveLast()
        {
            if (Count != 0)
            {
                if (Count == 1)
                {
                    Head = null;
                    Tail = null;
                }
                else
                {
                    SinglyLinkedListNode<T> current = Head;
                    while (current.Next != Tail)
                    {
                        current = current.Next;
                    }
                    current.Next = null;
                    Tail = current;
                }
                Count--;
            }
        }

        public void Add(T item)
        {
            AddFirst(item);
        }

        public bool Contains(T item)
        {
            SinglyLinkedListNode<T> current = Head;
            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            SinglyLinkedListNode<T> current = Head;
            while (current != null)
            {
                array[arrayIndex++] = current.Value;
                current = current.Next;
            }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(T item)
        {
            SinglyLinkedListNode<T> current = Head;
            SinglyLinkedListNode<T> previous = null;
            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                        if (current.Next == null)
                        {
                            Tail = previous;
                        }
                        Count--;
                    }
                    else
                    {
                        RemoveFirst();
                    }
                    return true;
                }
                previous = current;
                current = current.Next;
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            SinglyLinkedListNode<T> current = Head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
    }
}
