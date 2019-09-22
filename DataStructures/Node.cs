using System;
namespace DataStructures
{
    public class Node<T>
    {
        public Node<T> LeftNode { get; set; }
        public Node<T> RightNode { get; set; }
        public T Value { get; set; }

        public Node(T value)
        {
            Value = value;
        }

        public void Add(T value)
        {
            if(value.Equals(Value))
            {
                if(RightNode != null)
                {
                    RightNode = new Node<T>(value);
                } else
                {
                    RightNode.Add(value);
                }
            } else
            {
                if (LeftNode != null)
                {
                    LeftNode.Add(value);
                }
                else
                {
                    LeftNode = new Node<T>(value);
                }
            }
        }
    }
}
