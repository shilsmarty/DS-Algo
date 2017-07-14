using System;

namespace Learnings.DS.Algo.DataStructure.Generics.Stack
{
    public class Stack<T>
    {

        private int _mStackpointer = 0;
        private readonly int _mSize ;
        private readonly T[] _mItem;

        public Stack() : this(100){}

        public Stack(int size)
        {
            _mSize = size;
            _mItem = new T[size];
        }

        public void Push(T item)
        {
            if(_mStackpointer >= _mSize)
                throw new StackOverflowException();
            _mItem[_mStackpointer] = item;
            _mStackpointer++;
        }

        public T Pop()
        {
            _mStackpointer--;
            if (_mStackpointer >= 0)
            {
                return _mItem[_mStackpointer];
            }
            _mStackpointer = 0;
            return default(T);
        }
    }
}
