using System;

#pragma warning disable 1570

namespace Learnings.DS.Algo.DataStructure.Generics.CustomTypeSafeList
{
    /// <summary>
    /// TypeSafeList<int> fib = new TypeSafeList<int>(); 
    /// fib.Add(1); fib.Add(1); for (int i = 2; i < 25; i++)     
#pragma warning disable 1570
    /// fib.Add(fib[i - 2] + fib[i - 1]); 
#pragma warning restore 1570
    /// The main advantages of Generics include: 
    /// • Type-safety: a developer using the TypeSafeList class can only add elements that are of the type or are derived from the type specified. For example, trying to add a string to the fib TypeSafeList in the example above would result in a compile-time error.
    /// • Performance: Generics remove the need to type check at run-time, and eliminate the cost associated with boxing and unboxing.
    /// • Reusability: Generics break the tight-coupling between a data structure and the application for which it was created. This provides a higher degree of reuse for data structures. Many of the data structures we'll be examining throughout this series are data structures that utilize Generics, and when creating data structures—such as the binary tree data structure we'll build in Part 3—we'll be utilizing Generics ourselves.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class TypeSafeList<T>
    {
        T[] innerArray = new T[0];
        int currentSize = 0;
        int capacity = 0;

        public void Add(T item)
        {
            // see if array needs to be resized        
            if (currentSize == capacity)
            {
                // resize array             
                capacity = capacity == 0 ? 4 : capacity*2; // double capacity              
                T[] copy = new T[capacity];
                // create newly sized array             
                Array.Copy(innerArray, copy, currentSize);
                // copy over the array            
                innerArray = copy;
                // assign innerArray to the new, larger array        
            }
            innerArray[currentSize] = item;
            currentSize++;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= currentSize) throw new IndexOutOfRangeException();
                return innerArray[index];
            }
            set
            {
                if (index < 0 || index >= currentSize) throw new IndexOutOfRangeException();
                innerArray[index] = value;
            }
        }

        public override string ToString()
        {
            string output = string.Empty;
            for (int i = 0; i < currentSize - 1; i++) output += innerArray[i] + ", ";
            return output + innerArray[currentSize - 1];
        }
    }
}
