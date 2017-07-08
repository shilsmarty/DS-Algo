
namespace Learnings.DS.Algo.DataStructure.Generics.BinaryTree
{
    /// <summary>
    /// Binart Tree implementation.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BinaryTree<T>
    {
        private BinaryTreeNode<T> root = null;

        public BinaryTree()
        {
            root = null;
        }
        public void Clear()
        {
            root = null;
        }

        public BinaryTreeNode<T> Root
        {
            get { return root; }
            set { root = value; }
        }

    }
}
