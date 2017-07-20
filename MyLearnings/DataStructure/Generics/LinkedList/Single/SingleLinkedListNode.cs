using System;

namespace Learnings.DS.Algo.DataStructure.Generics.LinkedList.Single
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SingleLinkedListNode<T> : IComparable<SingleLinkedListNode<T>> where T : IComparable<T>
    {
        private T _data;
        private SingleLinkedListNode<T> _next;

        public SingleLinkedListNode()
        {
            Data = default(T);
            Next = null;
        }

        public SingleLinkedListNode(T data)
        {
            Data = data;
            Next = null;
        }

        public T Data
        {
            get
            {
                return _data;
            }
            set { _data = value; }
        }

        public SingleLinkedListNode<T> Next
        {
            get
            {
                return _next;
            }
            set { _next = value; }
        } 
        public int CompareTo(SingleLinkedListNode<T> other)
        {
            if (other == null) return -1;
            return Data.CompareTo(other.Data);
        }
    }
}
