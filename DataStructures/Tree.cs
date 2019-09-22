using System;
namespace DataStructures
{
    public abstract class Tree<T>
    {
        public Node<T> Head { get; set; }

        public abstract bool Compare(T node, T compareNode);

        public void Add(T value)
        {
            if(Head != null)
            {
                Head.Add(value);
            } else
            {
                Head = new Node<T>(value);
            }
        }
    }
}
