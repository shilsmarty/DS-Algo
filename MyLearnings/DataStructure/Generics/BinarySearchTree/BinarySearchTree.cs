
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
        private int _count = 0;
        private BinaryTreeNode<T> _root = null;
        private readonly IComparer<T> _comparer = Comparer<T>.Default; // used to compare node values when percolating down the tree

        #endregion

        #region constructors
        public BinarySearchTree(){}
        public BinarySearchTree(IComparer<T> comparer) { this._comparer = comparer; }
        #endregion
        int ICollection<T>.Count
        {
            get
            {
                return _count;
            }
        }

        bool ICollection<T>.IsReadOnly
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// Adds a new value to the BST.
        /// </summary>
        /// <param name="item">The data to insert into the BST.</param>
        /// <remarks>Adding a value already in the BST has no effect; that is, the SkipList is not
        /// altered, the Add() method simply exits.</remarks>
        void ICollection<T>.Add(T item)
        {
            BinaryTreeNode<T> node = new BinaryTreeNode<T>(item);

            BinaryTreeNode<T> current = _root;
            BinaryTreeNode<T> parent = null;
            int result;
            // now, insert node into the tree
            // trace down the tree until we hit a NULL
            while (current != null)
            {
                result = _comparer.Compare(current.Value, item);
                if (result == 0) //since no duplicate are allowed , incase if it comes just ignore it.
                    return;
                if (result > 0) // current.Value > data, must add node to current's left subtree
                {
                    parent = current;
                    current = current.Left;
                }
                else if (result < 0) // current.Value < data, must add node to current's right subtree
                {
                    parent = current;
                    current = current.Right;
                }
            }

            // We're ready to add the node!
            _count++;

            if (parent == null)
                // the tree was empty, make n the _root
                _root = node;
            else
            {
                result = _comparer.Compare(parent.Value, item);
                if(result >0)
                    // parent.Value > data, therefore node must be added to the left subtree
                    parent.Left = node;
                if (result <0)
                    // parent.Value < data, therefore node must be added to the right subtree
                    parent.Right = node;
            }
        }

        void ICollection<T>.Clear()
        {
            _root = null;
            _count = 0;
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
