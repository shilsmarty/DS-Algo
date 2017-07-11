
using Learnings.DS.Algo.DataStructure.Generics.BinaryTree;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Learnings.DS.Algo.DataStructure.Generics.BinarySearchTree
{
    /// <summary>
    /// Binart Tree implementation.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BinarySearchTree<T> : ICollection<T>, IEnumerable<T>
    {

        #region private Member Initialization
        private int count = 0;
        private BinaryTreeNode<T> root = null;
        private IComparer<T> comparer = Comparer<T>.Default; // used to compare node values when percolating down the tree

        #endregion

        #region constructors
        public BinarySearchTree(){}
        public BinarySearchTree(IComparer<T> comparer) { this.comparer = comparer; }
        #endregion
        int ICollection<T>.Count
        {
            get
            {
                return count;
            }
        }

        bool ICollection<T>.IsReadOnly
        {
            get
            {
                return false;
            }
        }

        void ICollection<T>.Add(T item)
        {
            throw new NotImplementedException();
        }

        void ICollection<T>.Clear()
        {
            throw new NotImplementedException();
        }

        bool ICollection<T>.Contains(T item)
        {
            throw new NotImplementedException();
        }

        void ICollection<T>.CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        bool ICollection<T>.Remove(T item)
        {
            throw new NotImplementedException();
        }
    }
}
