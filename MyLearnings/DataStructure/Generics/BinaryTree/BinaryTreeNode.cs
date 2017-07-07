using Learnings.DS.Algo.DataStructure.Generics.BaseNode;

namespace Learnings.DS.Algo.DataStructure.Generics.BinaryTree
{
    /// <summary>
    /// To provide a binary treespecific node class, 
    /// we can extend the base Node class by creating a BinaryTreeNode class 
    /// that exposes two properties—Left and Right—that operate on the base class's Neighbors property. 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BinaryTreeNode<T> : Node<T>
    {

        public BinaryTreeNode() { }

        public BinaryTreeNode(T data) : base(data, null) { } 
        public BinaryTreeNode(T data, BinaryTreeNode<T> leftChild , BinaryTreeNode<T> rightChild)
        {
            Value = data;
            NodeList<T> childrens = new NodeList<T>(2)
            {
                [0] = leftChild,
                [1] = rightChild
            };
            Neighbours = childrens;
        }

        public BinaryTreeNode<T> Left
        {
            get
            {
                if (base.Neighbours == null) return null;
                else return (BinaryTreeNode<T>) base.Neighbours[0];
            }
            set
            {
                if (base.Neighbours == null)
                base.Neighbours = new NodeList<T>(2);
                base.Neighbours[0] = value;
            }
        }

        public BinaryTreeNode<T> Right
        {
            get
            {
                if (base.Neighbours == null) return null;
                else return (BinaryTreeNode<T>) base.Neighbours[1];
            }
            set
            {
                if (base.Neighbours == null)
                base.Neighbours = new NodeList<T>(2);
                base.Neighbours[1] = value;
            }
        }
    }
}
