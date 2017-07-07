namespace Learnings.DS.Algo.DataStructure.Generics.BaseNode
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Node<T>
    {
       //Initialize private members
        private T data;
        private NodeList<T> neighbours = null;

        public Node() { }

        public Node(T data) : this(data, null) { } 
        public Node(T data, NodeList<T> neighbours)
        {
            this.data = data;
            this.neighbours = neighbours;
        }

        public T Value
        {
            get
            {
                return data;
            }
            set { data = value; }
        }

        public NodeList<T> Neighbours
        {
            get
            {
                return neighbours;
            }
            set
            {
                neighbours = value;
            }
        }
    }
}
